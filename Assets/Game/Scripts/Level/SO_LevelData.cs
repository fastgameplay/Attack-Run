using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SO_LevelData : MonoBehaviour
{
    [SerializeField] private Vector2 _enemyQuantityRange;
    [SerializeField] private int _enemyBasicAttack;
    [SerializeField] private int _enemyBasicHealth;
    [SerializeField] private int _enemyAttackPerLevel;
    [SerializeField] private int _enemyHealthPerLevel;

    public int GetEnemyAttack(int level) => level * _enemyAttackPerLevel + _enemyBasicAttack;
    public int GetEnemyHealth(int level) => level * _enemyHealthPerLevel + _enemyBasicHealth;
    

}
