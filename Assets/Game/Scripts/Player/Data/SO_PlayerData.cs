namespace AttackRun.Player{

    using UnityEngine;
    [CreateAssetMenu(fileName = "Player Data", menuName = "Data/Player")]
    public class SO_PlayerData : ScriptableObject
    {
        public float MoveSpeed => _moveSpeed;

        [Header("Movement")]
        [SerializeField] float _moveSpeed;

        [Space(10)]
        [Header("Health")]
        [SerializeField] int _basicHealth;    
        [SerializeField] int _healthPerLevel;

        [Space(10)]
        [Header("Attack")]
        [SerializeField] int _basicAttack;
        [SerializeField] int _attackPerLevel;
        
        public int GetHealthAt(int level){
            return _healthPerLevel * level + _basicHealth;
        }
        public int GetAttackAt(int level){
            return _attackPerLevel * level + _basicAttack;
        }
    }
}