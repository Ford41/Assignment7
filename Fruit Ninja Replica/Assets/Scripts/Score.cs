using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public static int score;
    public static int numSliced;
    public static int numMissed;
    public static float time = 30f;
    private float startTime;
    private float delay;

    public Text scoreText;
    public Text sliceText;
    public Text missText;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        scoreText.text = score.ToString();
        sliceText.text = numSliced.ToString();
        missText.text = numMissed.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
        sliceText.text = numSliced.ToString();
        missText.text = numMissed.ToString();

        delay = Time.time - startTime;
        if (delay >= time)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
