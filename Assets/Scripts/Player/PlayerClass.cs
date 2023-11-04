using UnityEngine;
using Random = UnityEngine.Random;

namespace Player
{
    public class PlayerClass : MonoBehaviour
    {
        public Vector3 Position; // Public property for the player's position

        private int Health; // Private health variable

        private float timer; // Timer variable to track time
        public float interval = 2f; // Interval in seconds for changing position and decreasing health
    
    
        public void UpdateHealth(int delta)
        {
            Health += delta;

            if (Health <= 0)
            {
                Debug.Log("Player died"); // Print "player died" in the console if health drops to 0 or below
            }
        }
    
        void Update()
        {
            timer += Time.deltaTime; // Increment the timer by the time since the last frame

            if (timer >= interval)
            {
                // Used for HW1
                // Position = new Vector3(Random.Range(-25f, 25f), Random.Range(1f, 10f), Random.Range(-25f, 25f)); // Set a random position
                // transform.position = Position; // Set player's position to new point
            
            
                UpdateHealth(Random.Range(-10, -1)); // Decrease health with a random value between -10 and -1

                timer = 0f; // Reset the timer to start counting again
            }
        }
    }
}
