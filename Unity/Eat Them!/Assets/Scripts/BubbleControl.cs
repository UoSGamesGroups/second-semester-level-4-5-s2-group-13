using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleControl : MonoBehaviour
{
    //public GameObject Buoyancy;
    public float Size;
    // public float Density = 100;
    public Rigidbody2D RigBod;
    // private Vector3 localArchimedesForce;


    // Use this for initialization
    void Start()
    {
        Size = Random.Range(0, 0.155f);
        transform.localScale = new Vector3(Size, Size, 0);
        StartCoroutine(Timer());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(30);
        Destroy(gameObject);
    }

    void onTriggerEnter2D  (Collider2D other)
    {
        if (other.gameObject.CompareTag("Bubble"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
    
	/*// The object must have a RidigBody
	if (RigBod == null)
		{
			GameObject.AddComponent<Rigidbody2D>();
			
		}

float volume = RigBod.mass / Density;


    float archimedesForceMagnitude = WATER_DENSITY * Mathf.Abs(Physics.gravity.y) * volume;
    localArchimedesForce = new Vector3(0, archimedesForceMagnitude, 0) / voxels.Count;
}*/
