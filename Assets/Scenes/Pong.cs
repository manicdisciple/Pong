using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pong : MonoBehaviour
{
    [SerializeField]
    float speed;
    
    float radius;
    Vector2 direction;
    
    // Start is called before the first frame update
    void Start()
    {
        direction = Vector2.one.normalized; //Normalized
        radius = transform.localScale.x / 2; //Half
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate (direction * speed * Time.deltaTime);

        if (transform.position.y < GameManager.bottomLeft.y + radius && direction.y < 0) {
            direction.y = -direction.y;
        } if (transform.position.y > GameManager.topRight.y - radius && direction.y > 0) {
            direction.y = -direction.y;
        }

        if (transform.position.x < GameManager.bottomLeft.x + radius && direction.x < 0) {
            Debug.Log ("Too bad Left. You lose!!. You won Right!");

            //Freeze
            Time.timeScale = 0;
            enabled = false;
        }
        if (transform.position.x > GameManager.topRight.x - radius && direction.x > 0) {
            Debug.Log("Too bad Right. You lose!! You won Left!");
            

            //Freeze
            Time.timeScale = 0;
            enabled = false;
        }

    }

    void OnTriggerEnter2D(Collider2D other) {
            if (other.tag == "Paddle") {
                bool isRight = other.GetComponent<Paddles> ().isRight;

                if(isRight == true && direction.x > 0) {
                    direction.x = -direction.x;
                }
                if (isRight == false && direction.x < 0) {
                    direction.x = -direction.x; 
                }
            }
        }

}
