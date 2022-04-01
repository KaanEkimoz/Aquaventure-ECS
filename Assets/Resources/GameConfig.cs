using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
    public float minRange;
    public float maxRange;
    public float minSpeed;
    public float maxSpeed;

    public GameObject enemyPrefab;
    public GameConfig playerPrefab;
}
