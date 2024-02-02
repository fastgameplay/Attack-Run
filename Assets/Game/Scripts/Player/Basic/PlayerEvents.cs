namespace AttackRun.Player{
    using UnityEngine;
    using AttackRun.Events;
    public struct PlayerEvents
    {
        public EventReference<int> OnDamageRecived;
        public EventReference<int> OnDamageApplyed;
        public EventReference OnDeath;
        
    }
}