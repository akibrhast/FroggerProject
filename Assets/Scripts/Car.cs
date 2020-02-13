using UnityEngine;
//This class handles the Car game object
public class Car : MonoBehaviour
{
    //This is a refernce to the RigidBody2D component 
    //attached to the Car GameObject, called rb
	public Rigidbody2D rb;
    
    //These are two float values used to determine
    //the max and minimum speed of the car
	public float minSpeed = 8f;
	public float maxSpeed = 12f;

    //Float value for the speed, declared and initialized to 1f
	float speed = 1f;

	void Start ()
	{
        //Uses Random.Range to take the min and the max to set speed to a new value
		speed = Random.Range(minSpeed, maxSpeed);
	}

	void FixedUpdate ()
    {
        #region TODO #3
        //Declare a Vector 2 called "forward" and initialize it as a new Vector2
        //that has THIS gameObject's transform's right x-value and right y-value

        Vector2 forward = new Vector2(transform.right.x, transform.right.y);


        //Use the RigidBody2D component to move the car forward, using the rigidbody's
        //position, your new forward Vector2, Time, and the speed value
        rb.MovePosition((rb.position + forward) * speed * Time.fixedDeltaTime);
        //Hint: Use Time.fixedDeltaTime for this movement
        
        #endregion
    }
}
