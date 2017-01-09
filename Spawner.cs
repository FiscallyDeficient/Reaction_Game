using UnityEngine;
using System.Collections;
using System.Timers;
using System;
using System.Threading;

public class Spawner : MonoBehaviour {
    public GameObject enemyPrefab1;
    public GameObject enemyPrefab2;
    public GameObject enemyPrefab3;
    public GameObject enemyPrefab4;
    public int number = 10;
	// Use this for initialization

    void Start()
    {
        //Invoke("simplePattern", 1);
        InvokeRepeating("randomPattern", 1, 1);
    }
    void simplePattern()
    {
        Instantiate(enemyPrefab1, enemyPrefab1.transform.position, enemyPrefab1.transform.rotation);
        Instantiate(enemyPrefab2, enemyPrefab2.transform.position, enemyPrefab2.transform.rotation);
        Instantiate(enemyPrefab3, enemyPrefab3.transform.position, enemyPrefab3.transform.rotation);
        Instantiate(enemyPrefab4, enemyPrefab4.transform.position, enemyPrefab4.transform.rotation);
        Invoke("spiralPattern", 2);

    }
    void spiralPattern()
    {
        spawn1();
        spawn2();
        spawn3();
        spawn4();
    }

    void randomPattern()
    {
        System.Random r = new System.Random();
        Vector3 enemy1 = new Vector3(0, r.Next(5) + 12, 0);
        Vector3 enemy2 = new Vector3(r.Next(5) + 24, 0, 0);
        Vector3 enemy3 = new Vector3(0, -(r.Next(5) + 12), 0);
        Vector3 enemy4 = new Vector3(-(r.Next(5) + 24), 0, 0);
        Instantiate(enemyPrefab1, enemy1, enemyPrefab1.transform.rotation);
        Instantiate(enemyPrefab2, enemy2, enemyPrefab2.transform.rotation);
        Instantiate(enemyPrefab3, enemy3, enemyPrefab3.transform.rotation);
        Instantiate(enemyPrefab4, enemy4, enemyPrefab4.transform.rotation);
    }
    
    void spawn1()
    {
        spawn(enemyPrefab1);
    }

    void spawn2()
    {
        spawn(enemyPrefab2);
    }

    void spawn3()
    {
        spawn(enemyPrefab3);
    }

    void spawn4()
    {
        spawn(enemyPrefab4);
    }
    void spawn(GameObject enemyPrefab)
    {
        Instantiate(enemyPrefab, enemyPrefab.transform.position, enemyPrefab.transform.rotation);
    }
    // Update is called once per frame
    void Update () {
        
	}
}
