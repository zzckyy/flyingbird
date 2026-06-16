using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class birdBehavior : MonoBehaviour
{
    public int score = 0;

    public float jumpForce = 100f;
     Rigidbody2D rb;

    bool isHidup;    
     public Text textSkor;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isHidup = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButton("Jump") && isHidup)
        {
            rb.AddForce(Vector2.up * jumpForce * 10 * Time.deltaTime, ForceMode2D.Impulse);
        }

        textSkor.text = score.ToString();

        if(!isHidup){
            GameOver();
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("obstacle"))
        {
            isHidup = false;
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("pipe")){
            score++;
        }
    }

    void GameOver()
    {
        Debug.Log("Yoan");
    }
}
