using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public Rigidbody player;
    public float speed = 1000f;
    private int score = 0;
    public int health = 5;
    public Text scoreText;
    public Text healthText;
    public Text winLoseText;
    public Image winLoseBG;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();
        winLoseBG.enabled = false;
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
            SetScoreText();
            //Debug.Log("Score: " + score);
            Destroy(other.gameObject); //removes the coin from the scene.
            //other.gameObject.SetActive(false); // hides the object in the scene, we can reference it but not see it in scene.
        }
        if (other.gameObject.tag == "Trap")
        {
            health -= 1;
            SetHealthText();
            //Debug.Log("Health: " + health);
        }
        if (other.gameObject.tag == "Goal")
        {
            winLoseBG.enabled = true;
            winLoseText.text = "You Win!";
            winLoseText.color = Color.black;
            winLoseBG.color = Color.green;
            //Debug.Log("You win!");
            StartCoroutine(LoadScene(3));
        }
    }

    void Update()
    {
        if (health == 0)
        {
            winLoseBG.enabled = true;
            winLoseText.text = "Game Over!";
            winLoseText.color = Color.white;
            winLoseBG.color = Color.red;
            //Debug.Log("Game Over!");
            StartCoroutine(LoadScene(3));
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("menu");
        }
    }

    void SetScoreText()
    {
        scoreText.text = "Score: " + score;
    }

    void SetHealthText()
    {
        healthText.text = "Health: " + health;
    }

    IEnumerator LoadScene(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // reset scene to their original values
    }
}
