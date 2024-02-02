namespace AttackRun.Player{
    using UnityEngine;
    
    public class Player : MonoBehaviour
    {
        public SO_PlayerData Data => _playerData;
        public PlayerEvents Events;

        public int HealthLevel => _healthLevel;
        public int AttackLevel => AttackLevel;

        [SerializeField] private SO_PlayerData _playerData;
        [SerializeField] private int _healthLevel = 1;
        [SerializeField] private int _attackLevel = 1;
    }
}