using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rbody;
    public float speed = 10f;
    public float count;
    public Text countText;  
    public Text winText;

    void Start()
    {
        count = 0;
        countText.text = "";
        winText.text = "";
        rbody= GetComponent<Rigidbody2D>();
        
    }

    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");


        rbody.AddForce(new Vector2(horizontalInput, verticalInput) *speed);
    }

        void OnTriggerEnter2D( Collider2D target)
        {
          if (target.gameObject.CompareTag("PickUp"))
          {
            Destroy(target.gameObject);
            Count();
          }

        }
        void Count(){
            count +=10;
            countText.text = "SCORE: "+ count.ToString(); 

            if(count >= 50)
            {
                winText.text = "YOU WIN!";
                
            }
             
        }
}//class
 
