using UnityEngine;
namespace AttackRun.Health{
    public abstract class Health : MonoBehaviour
    {
        private int _maxHealth;
        private int _currentHealth;

        protected void Damage(int damage){

        }
        public void Init(int maxHealth){
            _maxHealth = maxHealth;
            _currentHealth = maxHealth;
        }

        protected abstract void OnHealthUpdate(int value);
        protected abstract void OnDeath();

    }

}
