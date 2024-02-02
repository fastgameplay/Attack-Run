namespace AttackRun.Health{
    using System;
    using UnityEngine;
    public abstract class Health : MonoBehaviour
    {
        private int CurrentHealth {
            get => _currentHealth;
            set {
                if(value <= 0){
                    OnDeath();
                    value = 0;
                }
                _currentHealth = value;
                OnHealthUpdate(value);
            }
        }
        private Action<int> _onDamageReceived;
        private int _maxHealth;
        private int _currentHealth;

        public void Init(int maxHealth, Action<int> onDamageReceived){
            _onDamageReceived = onDamageReceived;
            _onDamageReceived += OnDamage;
            _maxHealth = maxHealth;
            _currentHealth = maxHealth;
        }
        protected void InitEvents(Action<int> onDamageReceived){
            if(_onDamageReceived != null){
                _onDamageReceived -= OnDamage;
                _onDamageReceived = null;
            }
            _onDamageReceived = onDamageReceived;
            _onDamageReceived += OnDamage;
        }
        protected void OnDamage(int damage){
            CurrentHealth -= damage;
        }

        protected abstract void OnHealthUpdate(int value);
        protected abstract void OnDeath();
        private void OnDisable() {
            if(_onDamageReceived == null) return;
            _onDamageReceived -= OnDamage;
            _onDamageReceived = null;
        }
    }

}
