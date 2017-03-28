using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabbing : MonoBehaviour {

    public Transform HoldPoint;
    public GameObject GrabbedObject;
    public float ThrowForce;
    public AudioClip ThrowingObjectSound;
    public bool CanGrab = true;

    public float GrabDelay = 0.1f;

    AudioSource playerAS;

	// Use this for initialization
	void Start () {
		
	}

    IEnumerator ThrowGrabbed()
    {
        Rigidbody2D rb = GrabbedObject.GetComponent<Rigidbody2D>();
        rb.AddForce(-Vector2.right * ThrowForce);
        rb.AddForce(Vector2.left * ThrowForce);
        GrabbedObject = null;
        CanGrab = false;

        yield return new WaitForSeconds(GrabDelay);

        CanGrab = true;

        playerAS = GetComponent<AudioSource>();
    }

    void Update()
    {
        if ( Input.GetKeyUp(KeyCode.RightControl))
        {
            if ( GrabbedObject != null )
            {
                StartCoroutine(ThrowGrabbed());
            }
        }

        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            if (GrabbedObject != null)
            {
                StartCoroutine(ThrowGrabbed());
            }
        }

        playerAS.clip = ThrowingObjectSound;
        playerAS.Play();

        playerAS.PlayOneShot(ThrowingObjectSound);
    }

	// Update is called once per frame
	void LateUpdate () {
		if ( GrabbedObject != null )
        {
            GrabbedObject.transform.position = HoldPoint.position;
        }
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (CanGrab && collision.gameObject.tag == "grabbable") 
        {
            if (GrabbedObject == null)
            {
                GrabbedObject = collision.gameObject;
            }
        }
    }
}
