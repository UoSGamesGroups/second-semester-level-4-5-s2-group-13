using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlsV2 : MonoBehaviour {
    public KeyCode Up;
    public KeyCode Down;
    public KeyCode Left;
    public KeyCode Right;
    public Rigidbody2D RigBod;
    public float Speed;
    public float Size = 1;


    // Use this for initialization
    void Start () {
        RigBod = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(Up))
        {
            RigBod.AddForce(new Vector2(0, Speed));
        }
        else if (Input.GetKey(Down))
        {
            RigBod.AddForce(new Vector2(0, -Speed));
        }
        if (Input.GetKey(Left))
        {
            RigBod.AddForce(new Vector2(-Speed,0));
        }
        else if (Input.GetKey(Right))
        {
            RigBod.AddForce(new Vector2(Speed, 0));
        }

        transform.localScale = new Vector3(Size, Size, 1);
    }
    
    private void OnTriggerEnter2D(Collider2D coll)
    {
        
        
    }
}
