using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class birdBehavior : MonoBehaviour
{
    public int score = 0;

    public float jumpForce = 100f;
    Rigidbody2D rb;
    AudioSource audio;
    public AudioClip[] _clip;

    bool isHidup;    
    public bool isPlay;
    public Text textSkor;
    public GameObject playButton;
    public GameObject pauseButton;

    public GameObject GameOverUI;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isHidup = true;
        audio = GetComponent<AudioSource>();
        rb.bodyType = RigidbodyType2D.Kinematic;
        isPlay = false;
        
    }

    public void startGame(){
        isPlay = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(isPlay){
            rb.bodyType = RigidbodyType2D.Dynamic;
            playButton.SetActive(false);
            pauseButton.SetActive(true);
            GameOverUI.SetActive(false);
        }else{
            pauseButton.SetActive(false);
        }

        if (Input.GetButton("Jump") && isHidup && isPlay)
        {
            rb.AddForce(Vector2.up * jumpForce * 10 * Time.deltaTime, ForceMode2D.Impulse);
        }

        if (Input.GetButtonDown("Jump") && isHidup && isPlay)
        {
            audio.clip = _clip[0];
            audio.Play();
        }

        textSkor.text = score.ToString();

        if(!isHidup){
            GameOver();
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("obstacle") && isPlay || other.gameObject.CompareTag("boundary")  && isPlay)
        {
            isHidup = false;
            audio.clip = _clip[1];
            audio.Play();
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("scoreCollider") && isHidup && isPlay){
            score++;
        }
    }

    void GameOver()
    {
        isPlay = false;
        GameOverUI.SetActive(true);
    }
}
