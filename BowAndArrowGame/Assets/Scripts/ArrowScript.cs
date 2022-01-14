using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour
{
    private float depth = 0.3f;
    public GameObject arrow;
    public GameObject enemy;

    private GameObject currentE;
    public List<GameObject> enemyArray = new List<GameObject>();

    void Start()
    {
        enemyArray = GameObject.Find("CreateEnemy").GetComponent<CreateEnemy>().enemyArray;
    }
    private void OnCollisionEnter(Collision c)
    {
        string name = "";

        Debug.Log(c.collider.name);
        if(c.collider.tag == "Enemy")
        {
            name = c.collider.name;
            for(int i = 0; i < enemyArray.Capacity; i++)
            {
                if (enemyArray[i].name == name)
                {
                    currentE = enemyArray[i];
                }
            }
        }

        Destroy(currentE);
       
    }
}
