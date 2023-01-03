using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Rigidbody player;
    public float speed = 1000f;
    private int score = 0;
    public int health = 5;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        // AddForce(float x, float y, float z)
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            player.AddForce(0, 0, speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            player.AddForce(0, 0, -speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            player.AddForce(-speed * Time.deltaTime, 0, 0);

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            player.AddForce(speed * Time.deltaTime, 0, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pickup")
        {
            score += 1;
            Debug.Log("Score: " + score);
            Destroy(other.gameObject); //removes the coin from the scene.
            //other.gameObject.SetActive(false); // hides the object in the scene, we can reference it but not see it in scene.
        }
        if (other.gameObject.tag == "Trap")
        {
            health -= 1;
            Debug.Log("Health: " + health);
        }
        if (other.gameObject.tag == "Goal")
        {
            Debug.Log("You win!");
        }
    }

    void Update()
    {
        if (health == 0)
        {
            Debug.Log("Game Over!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // reset scene to their original values
        }
    }
}
