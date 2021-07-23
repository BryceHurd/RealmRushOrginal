using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Enemy))]
public class EnemyHealth : MonoBehaviour
{
    
    [SerializeField] int maxHitPoints = 5;

    [Tooltip("Adds Amount to max hitpoints when enemy dies")]
    [SerializeField] int difficultyRamp = 2;
    int currentHitPoints;

    Enemy enemy;

    void OnEnable()
    {
        currentHitPoints = maxHitPoints;
    }

     void Start()
    {
        enemy = GetComponent<Enemy>();
    }

    private void OnParticleCollision(GameObject other)
    {
        ProccessHit();
    }
    
    void ProccessHit()
    {
        currentHitPoints--;
        Debug.Log(currentHitPoints);

        if (currentHitPoints <= 0)
        {
            gameObject.SetActive(false);
            maxHitPoints += difficultyRamp;
            enemy.RewardGold();
        }

    }


}
