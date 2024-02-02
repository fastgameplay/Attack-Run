namespace AttackRun.Player{
    using UnityEngine;
    
    public class Player : MonoBehaviour
    {
        public SO_PlayerData Data => _playerData;
        public PlayerEvents Events;
        [SerializeField] SO_PlayerData _playerData;

        
    }
}