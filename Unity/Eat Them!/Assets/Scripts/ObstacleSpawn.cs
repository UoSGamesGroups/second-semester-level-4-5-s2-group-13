using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    public GameObject Branch;
   // public GameObject Monkf;
    public GameObject Urchins;
   // public GameObject Trolley;
    public GameObject Bubble;
    public bool BranchSpawning = false;
    //public bool MonkfSpawning = false;
    public bool UrchinsSpawning = false;
   // public bool TrolleySpawning = false;
    public bool BubbleSpawn = false;
    public Vector3 ScreenSize;
    public float xvalue;

    // Use this for initialization
    void Start()
    {
        ScreenSize = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
    }

    // Update is called once per frame to produce obstacles 
    void Update()
    {
        if (!BranchSpawning)
        {
            BranchSpawning = true;
            StartCoroutine(BranchTimer());
        }
/*
        if (!MonkfSpawning)
        {
            MonkfSpawning = true;
            StartCoroutine(Timer());
        }*/

        if (!UrchinsSpawning)
        {
            UrchinsSpawning = true;
            StartCoroutine(UrchinsTimer());
        }

       /* if (!TrolleySpawning)
        {
            TrolleySpawning = true;
            StartCoroutine(TrolleyTimer());
        }*/

        if (!BubbleSpawn)
        {
            BubbleSpawn = true;
            StartCoroutine(BubbleTimer());
        }
    }


   public IEnumerator Timer()
    {
        GameObject Obstacle;
        Rigidbody2D rb;
        yield return new WaitForSeconds(Random.Range(1, 5));

        float rand = Random.Range(0.0f, 1.0f);

        if (rand <= 0.5f)
        {
            xvalue = Random.Range(-ScreenSize.x, -1.5f);
        }
        else
        {
            xvalue = Random.Range(1.5f, ScreenSize.x);
        }

        Obstacle = Instantiate(Branch, new Vector3(xvalue, ScreenSize.y, 0), Quaternion.identity);
        //Obstacle = Instantiate(Monkf, new Vector3(xvalue, ScreenSize.y, 0), Quaternion.identity);
        Obstacle = Instantiate(Urchins, new Vector3(xvalue, ScreenSize.y, 0), Quaternion.identity);
       // Obstacle = Instantiate(Trolley, new Vector3(xvalue, ScreenSize.y, 0), Quaternion.identity);
        

        rb = Obstacle.GetComponent<Rigidbody2D>();
        switch (Random.Range(0, 2))
        {
            case 1:
                rb.gravityScale *= -1;

                Obstacle.transform.position = new Vector3(Obstacle.transform.position.x, -ScreenSize.y, 0);
                
                break;

                }

                BranchSpawning = false;
                // MonkfSpawning = false;
                // TrolleySpawning = false;
                UrchinsSpawning = false;

    }


    public IEnumerator BubbleTimer()
    {
        yield return new WaitForSeconds(Random.Range(1, 4));
        Instantiate(Bubble, new Vector3(Random.Range(-ScreenSize.x, ScreenSize.x), Random.Range(-ScreenSize.y, ScreenSize.y), 0), Quaternion.identity);
        BubbleSpawn = false;
    }

    public IEnumerator BranchTimer()
    {
        yield return new WaitForSeconds(Random.Range(1, 4));
        Instantiate(Branch, new Vector3(Random.Range(-ScreenSize.x, ScreenSize.x), Random.Range(-ScreenSize.y, ScreenSize.y), 0), Quaternion.identity);
        BranchSpawning = false;
    }

    /*public IEnumerator TrolleyTimer()
    {
        yield return new WaitForSeconds(Random.Range(1, 10));
        Instantiate(Trolley, new Vector3(Random.Range(-ScreenSize.x, ScreenSize.x), Random.Range(-ScreenSize.y, ScreenSize.y), 0), Quaternion.identity);
        TrolleySpawning = false;
    }*/

    public IEnumerator UrchinsTimer()
    {
        yield return new WaitForSeconds(Random.Range(1, 8));
        Instantiate(Urchins, new Vector3(Random.Range(-ScreenSize.x, ScreenSize.x), Random.Range(-ScreenSize.y, ScreenSize.y), 0), Quaternion.identity);
        UrchinsSpawning = false;
    }
}
