using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeUpdate : MonoBehaviour
{
    private GameManagerX gameManagerX;
    public TextMeshProUGUI timeText;

    public float time =60;
    // Start is called before the first frame update
    void Start()
    {
        gameManagerX = GameObject.Find("Game Manager").GetComponent<GameManagerX>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManagerX.isGameActive)
        {
            time -= Time.deltaTime;
            timeText.text = "Time: " + Mathf.Round(time);
        }        
        if(time<0)
        {
            gameManagerX.GameOver();
        }
    }
}
