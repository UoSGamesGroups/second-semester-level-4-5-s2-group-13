using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControlsV2 : MonoBehaviour {
    public KeyCode Up;
    public KeyCode Down;
    public KeyCode Left;
    public KeyCode Right;
    public KeyCode RightControl;
    public KeyCode LeftControl;
    public Rigidbody2D RigBod;
    public float Speed;
    public float Size = 1.5f;
    public GameObject bubble;

   // GameObject canvas;
    
   
    private int count;
    //public Text Counter;
   // public Text Counter2;

    //public Text Winning;
    


    // Use this for initialization
    void Start () {
        RigBod = GetComponent<Rigidbody2D>();
        //count = 0;
        //Winning.text = "";

        //canvas = GameObject.Find("Canvas");
        //cc = canvas.GetComponent<CanvasController>();

        //SetCounter();
    }

    // Update is called once per frame

    //public class DestroyOther : MonoBehaviour
    
        
    
    private void Update ()
    {
        //Kills the game object bubble
        if (Input.GetKey(KeyCode.RightControl))
            {
                DestroyImmediate(bubble);
            }
        
        //Right player controllers
        
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

    
    private void OnTriggerEnter2D(Collider2D other) // create collision and collect bubbles
    {
        if (other.gameObject.CompareTag("Bubble"))
        {
            other.gameObject.SetActive(false);
            Size++;
            
        }

    }
                
    //private void OnCollision2D(Collision col)  // Recognises when it eats a bubble and increases in size.
    //{
    //    if(col.gameObject.name == "Bubble")
    //    {
             
    //    }
    //}
  }
/*//keeps score of bubbles eaten. Scores and nominates the winner
    void SetCounter()
    {
        if (this.gameObject.tag == "player1")
        {
            cc.updatePlayerOneCounter(count);
        }
        else if (this.gameObject.tag == "player2")
        {
            cc.updatePlayerTwoCounter(count);
        }

        if (count >= 10)
        {
            Winning.text = "Winner!";
        }
    }*/

