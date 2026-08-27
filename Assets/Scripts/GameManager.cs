using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField]
    private float gameTime;
    
    public bool isPlaying;

    [SerializeField]
    private TMP_Text timerText;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isPlaying = true;
        gameTime = 40;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameTime > 0)
        {
            gameTime -= Time.deltaTime;
            int min = (int)gameTime / 60;
            int seg = (int)gameTime % 60;
            timerText.text = min.ToString("00") + ":" + seg.ToString("00");
            if (gameTime < 0)
            {
                isPlaying = false;
            }
        }
    }

    public void ReloadLevel()
    {
        SceneManager.LoadScene(0);
    }

}
