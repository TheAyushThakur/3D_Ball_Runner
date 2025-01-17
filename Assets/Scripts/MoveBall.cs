using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class MoveBall : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    public int ballSpeed = 0;
    public int jumpSpeed = 0;
    private bool isTouching = false;
    private int Counter;
    public TextMeshProUGUI cointext;
    public AudioSource aSource;
    public AudioClip aClip;


void Start()
    {
       rb = GetComponent<Rigidbody>(); 
        Counter = 30;
        cointext.text = "COINS: "  + Counter;
    }

    // Update is called once per frame
    void Update()
    {
        float hMove = Input.GetAxis("Horizontal");
        float vMove = Input.GetAxis("Vertical");
       
            
        if (isTouching)
        {
            if (rb.velocity.z > 0 && vMove < 0 || rb.velocity.z < 0 && vMove > 0)
            {
                rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, 0); // Stop forward/backward motion
            }
            else if (rb.velocity.x > 0 && hMove < 0 || rb.velocity.x < 0 && hMove > 0)
            {
                rb.velocity = new Vector3(0, rb.velocity.y, rb.velocity.z); // Stop left/right motion
            }
           
               
            
        }
        Vector3 moveBall = new Vector3(hMove, 0.0f, vMove);
        rb.AddForce(moveBall * ballSpeed);





        if ((Input.GetKey(KeyCode.Space))&& isTouching == true)
        {
            Vector3 ballJump = new Vector3(0.0f, 8.0f, 0.0f);
            rb.AddForce(ballJump * jumpSpeed);
        }
        isTouching = false;

   

    }
    private void OnCollisionStay(Collision collision)
    {
        isTouching=true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coinstag")) {
          
            other.gameObject.SetActive(false);
            Counter--;
            cointext.text = "COINS: "+ Counter;
            aSource.PlayOneShot(aClip);

            if(Counter == 0)
            {
                SceneManager.LoadScene("Endscene");
            }
        }
    }
}
