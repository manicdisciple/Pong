using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddles : MonoBehaviour
{
    [SerializeField]
    float speed;

    float height;

    string input;
    public bool isRight;

    // Start is called before the first frame update
    void Start()
    {
        height = transform.localScale.y;
    }

    public void Init(bool isPlayerOne) {

        isRight = isPlayerOne;
        Vector2 pos = Vector2.zero;
    
        if(isPlayerOne) {
            pos = new Vector2(GameManager.topRight.x, 0);
            pos -= Vector2.right * transform.localScale.x; // Margins to left
            input = "PaddleRight";
        } else {
            pos = new Vector2(GameManager.bottomLeft.x, 0);
            pos += Vector2.right * transform.localScale.x; //Margins to right
            input = "PaddleLeft";
        }

        //update
        transform.position = pos;

        transform.name = input;
    }

    
    // Update is called once per frame
    void Update()
    {
        //Betwwen -1 to 1
        float move = Input.GetAxis(input) * Time.deltaTime * speed;
        
        //Restrict movement
        // Restrict paddle movement
        if (transform.position.y < GameManager.bottomLeft.y + height / 2 && move < 0) {
            move = 0;
        }
        if (transform.position.y > GameManager.topRight.y - height / 2 && move > 0) {
            move = 0;
        }
        transform.Translate(move * Vector2.up);
    }
}
