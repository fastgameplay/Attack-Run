namespace AttackRun.Player{
    using AttackRun.Events;
    using UnityEngine;
    public struct PlayerEvents
    {
        public EventReference<Transform> OnTargetChange;

        public EventReference<int> OnDamageRecived;
        public EventReference<int> OnHealthChange;
        public EventReference OnDeath;

        public EventReference<bool> OnBlockStateChange;
        public EventReference<bool> OnAttackStateChange;

    }
}