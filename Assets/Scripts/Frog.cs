using UnityEngine;
using UnityEngine.SceneManagement; //This package is necessary to utilize loading scenes
//This class controls you, the Frog class for the player
public class Frog : MonoBehaviour
{
    //Your Frog has a rigidBody2D component to allow it to move
	public Rigidbody2D rb;

    //Every frame, the game will check for the user's input
	void Update ()
    {
        #region TODO #1
        //If & If Else Statements: If the user presses down a keycode arrow
        //use the rigid body to move the position of the game object


        rb.MovePosition(rb.position + new Vector2(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical")));


        /*
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //If the up arrow is pressed, move the frog one position up 
            rb.MovePosition(rb.position + Vector2.up);
        }
         
        //If the left arrow is pressed, move the frog one position to the left
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.MovePosition(rb.position + Vector2.down);
        }

        //If the right arrow is pressed, move the frog one position to the right
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.MovePosition(rb.position + Vector2.right);
        }
        //If the down arrow is pressed, move the frog one position down
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.MovePosition(rb.position + Vector2.left);
        }
        */

        #endregion

    }

    //Using the collision attached to this game object, check if the frog has
    //been triggered by car colliding, and if so, restart the level
    void OnTriggerEnter2D (Collider2D col)
	{
        //If the tag is "Car", then do
		if (col.tag == "Car")
		{
            #region TODO #2
            //Log to the console that "YOU LOST!"
            Debug.Log("YOU LOST!");
            //The Score Class's current score will be reset to 0
            Score.CurrentScore = 0;
            //Use SceneManager to LOAD this SCENE, using the current scene's name
            SceneManager.LoadScene("Main");
            #endregion
        }
    }
}
