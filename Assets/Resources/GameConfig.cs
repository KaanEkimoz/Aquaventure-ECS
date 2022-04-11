using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu]
public class GameConfig : ScriptableObject
{
    private static GameConfig _instance;
    public static GameConfig Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = Resources.Load<GameConfig>("GameConfig");
            }
            return _instance;
        }
    }
    //Enemy variables
    public float enemyRange;
    public float enemySpeed;
    public GameObject enemyPrefab;
    [Space]
    public float playerSpeed;
    public GameObject playerPrefab;
    [Space]
    public float bulletSpeed;
    public GameObject bulletPrefab;
    [Space] 
    public float BorderValue;

}
