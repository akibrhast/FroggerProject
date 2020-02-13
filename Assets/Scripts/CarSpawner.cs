using UnityEngine;
//This game object will spawn Cars for the game
public class CarSpawner : MonoBehaviour
{
    //Float variable to delay the spawn of a car
	public float spawnDelay = .3f;

    //Reference to the Prefab for a Car game object
	public GameObject car;

    //This is an array of Transform variables where the cars will spawn at
    //MUST be set in the editor
	public Transform[] spawnPoints= new Transform[4];


    //Declare and initialize a float variable for the next time to spawn
    float nextTimeToSpawn = 0f;

    //Update function to check for the next time to spawn a car
    void Update()
    {
        //If the float value for next time to spawn is less than
        //or equal to the time, then do logic
        if (nextTimeToSpawn <= Time.time)
        {
            #region TODO #4
            //Call the spawn car function
            SpawnCar();
            //Set the value for nextTimeToSpawn equal to the time 
            
            //plus the spawnDelay variable
            
            #endregion
        }
    }
    //This function will spawn a car at spawn point
	void SpawnCar()
	{
        #region TODO #5
        //Get a random integer between 0 and the length of the spawn point array

        int ranInt = Random.Range(0, 4);

        //Declare a Transform variable called spawnPoint and initialize it
        //as the random index of the spawnPoints array
       Transform a = spawnPoints[ranInt];


        //Instantiate the Car prefab at the new spawn point's position and rotation
        Instantiate(car,a);
        #endregion
    }

}
