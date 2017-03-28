using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wave : MonoBehaviour {

    public Rigidbody2D RB;
    GameObject[] RBs;


    // Use this for initialization
    void Start () {
        //        RB.AddForce(new Vector2(-1,0));
        
        StartCoroutine(Timer());
	}
	
	// Update is called once per frame
	void Update () {
        //RB.velocity.add(acceleration);
        //location.add(velocity);
        //acceleration.mult(0);
        float RBXVel = RB.velocity.x;
        float RBXRot = RB.rotation;
             
           
        }


    IEnumerator Timer()
    {
        yield return new WaitForSeconds(Random.Range(0,2));

        //get all objects with a rigid body on them.
        //store them in a game object array (RBs)

        
        float XMovement = Random.Range(-5, 5);
        for (int i=0;i< RBs.Length; i++)
        {
            RB = RBs[i].GetComponent<Rigidbody2D>();
            RB.AddForce(new Vector2(XMovement, 0));

        }
        
    }

   /* void OnTriggerStay2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Obstacles")
        {
            RB.AddForce(coll.RB.gameObject);
        }
    }*/
}
