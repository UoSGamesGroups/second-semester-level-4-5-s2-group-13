using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleControl : MonoBehaviour {

    public float Size;


	// Use this for initialization
	void Start () {
        Size = Random.Range(0, 1f);
        transform.localScale = new Vector3(Size, Size, 0);
        StartCoroutine(Timer());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}
