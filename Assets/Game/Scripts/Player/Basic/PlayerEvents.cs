namespace AttackRun.Player{
    using UnityEngine;
    using AttackRun.Events;
    public struct PlayerEvents
    {
        public EventReference<int> OnDamageRecived;
        public EventReference<int> OnHealthChange;
        public EventReference OnDeath;

        public EventReference<bool> OnBlockStateChange;
        public EventReference<bool> OnAttackStateChange;

        
    }
}