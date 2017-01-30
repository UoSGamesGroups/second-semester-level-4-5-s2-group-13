using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour {
    public GameObject Platform;
    public GameObject Bubble;
    public bool Spawning = false;
    public bool BubbleSpawn = false;
    public Vector3 ScreenSize;


	// Use this for initialization
	void Start () {
        ScreenSize = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
	}
	
	// Update is called once per frame
	void Update () {
        if (!Spawning)
        { 
            Spawning = true;
            StartCoroutine(Timer());
        }
        if (!BubbleSpawn)
        {
            BubbleSpawn = true;
            StartCoroutine(BubbleTimer());
        }
	}


    public IEnumerator Timer()
    {
        yield return new WaitForSeconds(Random.Range(1,10));
        Instantiate(Platform, new Vector3(Random.Range(-ScreenSize.x,0),ScreenSize.y,0), Quaternion.identity);
        Instantiate(Platform, new Vector3(Random.Range(0,ScreenSize.x), ScreenSize.y, 0), Quaternion.identity);
        Spawning = false;
    }


    public IEnumerator BubbleTimer()
    {
        yield return new WaitForSeconds(Random.Range(1, 4));
        Instantiate(Bubble, new Vector3(Random.Range(-ScreenSize.x, ScreenSize.x), Random.Range(-ScreenSize.y, ScreenSize.y), 0), Quaternion.identity);
        BubbleSpawn = false;
    }
}
