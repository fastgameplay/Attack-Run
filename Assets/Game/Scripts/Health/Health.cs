namespace AttackRun.Health{
    using System;
    using UnityEngine;
    public class Health : MonoBehaviour
    {
        private int CurrentHealth {
            get => _currentHealth;
            set {
                if(value <= 0){
                    OnDeath();
                    _isDead = true;
                    value = 0;
                }
                _currentHealth = value;
                OnHealthUpdate(value);
            }
        }
        private Action _onDeath;
        private Action<int> _onHealthChange;
        private int _maxHealth;
        private int _currentHealth;
        private bool _isDead = true;
        public void Init(int maxHealth, Action onDeath, Action<int> onHealthChange){
            _maxHealth = maxHealth;
            _currentHealth = maxHealth;
            _onDeath = onDeath;
            _onHealthChange = onHealthChange;
            _isDead = false;
        }
        
        public void Damage(int damage){
            if(_isDead) return;
            CurrentHealth -= damage;
        }

        private void OnHealthUpdate(int value){
            if(_onHealthChange == null){
                Debug.LogError("_onHealthChange Not assigned");
                return;
            }
            _onHealthChange?.Invoke(value);
        }
        private void OnDeath(){
            if(_onDeath == null) {
                Debug.LogError("_onDeath Not assigned");
                return;
            }
            _onDeath?.Invoke();
        }
        
    }

}
