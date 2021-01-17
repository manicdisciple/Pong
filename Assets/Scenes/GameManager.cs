using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Paddles paddles;
    public Pong pong;

    public static Vector2 bottomLeft;
    public static Vector2 topRight;


    // Start is called before the first frame update
    void Start()
    {
        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2 (0, 0));
        topRight = Camera.main.ScreenToWorldPoint(new Vector2 (Screen.width, Screen.height));

        Instantiate (pong);
        Paddles paddle1 = Instantiate (paddles) as Paddles;
        Paddles paddle2 = Instantiate (paddles) as Paddles;

        paddle1.Init (true); //Player 1: right
        paddle2.Init (false); //Player 2: left
    
    }

    void Update() {

         if (Input.GetKey("escape"))
             Application.Quit();

    }

}
