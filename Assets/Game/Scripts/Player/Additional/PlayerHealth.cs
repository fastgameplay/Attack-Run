namespace AttackRun.Player
{
    using AttackRun.Health;
    using UnityEngine;

    [RequireComponent(typeof(Health))]
    public class PlayerHealth : PlayerBase
    {
        private Health _currentHealth;
        private bool isShielded;
        private bool isAttacking;
        protected override void Awake(){
            base.Awake();
            _currentHealth = GetComponent<Health>();
        }
        private void Start() {
            _currentHealth.Init(
                player.Data.GetHealthAt(player.HealthLevel), 
                player.Events.OnDeath.Event, 
                player.Events.OnHealthChange.Event
            );
        }
        private void OnAttackStateChange(bool state) => isShielded = state;
        private void OnBlockStateChange(bool state) => isAttacking = state;
        private void OnDamageRecived(int damage){
            if(!isAttacking && isShielded) return;

            _currentHealth.Damage(damage);
        }
        private void OnEnable() {
            player.Events.OnDamageRecived += OnDamageRecived;
            player.Events.OnBlockStateChange += OnBlockStateChange;
            player.Events.OnAttackStateChange += OnAttackStateChange;
        }
        private void OnDisable() {
            player.Events.OnDamageRecived -= OnDamageRecived;
            player.Events.OnBlockStateChange -= OnBlockStateChange;
            player.Events.OnAttackStateChange -= OnAttackStateChange;
        }
    }
}