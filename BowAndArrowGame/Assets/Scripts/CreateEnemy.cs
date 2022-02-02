using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemy : MonoBehaviour
{
    public GameObject enemy;
    public GameObject target;

    private int xPos;
    private int zPos;
    

    public Transform player;

    private GameObject currentE;
    public List<GameObject> enemyArray = new List<GameObject>();
    private float numOfEnemies = 0;
   
    void Start()
    {
        InvokeRepeating("Spawn", 4, 5);
    }

    Vector3 getRandomPos()
    {
        float _x = Random.Range(-20, 20);
        float _y = 5f;
        float _z = 40;

        Vector3 newPos = new Vector3(_x, _y, _z);
        return newPos;
    }
    void Spawn()
    {
        currentE = Instantiate(enemy, getRandomPos(), new Quaternion(0, 180, 0, 0));
        currentE.transform.LookAt(target.transform);
        numOfEnemies += 1;
        currentE.name = "Enemy" + numOfEnemies;
        enemyArray.Add(currentE);
    }

    void Update()
    {
        
        //foreach (GameObject x in enemyArray)
        //{
        //    Debug.Log(x);
        //}
    }
}
