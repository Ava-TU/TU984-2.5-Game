using UnityEngine;
using TMPro;

public class MainTimer : MonoBehaviour
{

    public float mainTime = 5f;
    public float miniTime = 10f;

    public float targetTime;

    public bool miniStart;

    public GameObject[] allMinigames;
    public GameObject miniGame;

    void Start()
    {
        miniStart = false;
        targetTime = mainTime;
    }

    // Update is called once per frame
    void Update()
    {
        targetTime -= Time.deltaTime;

        if (targetTime <= -0.1f && miniStart == false)
        {
            miniStart = true;
            PickMiniGame();
        }
        if (targetTime <= 0.0f && miniStart == true)
        {
            miniStart = false;
            miniGame.SetActive(false);
            targetTime = mainTime;
        }
    }

    void PickMiniGame()
    {
        int randomIndex = Random.Range(0, allMinigames.Length);

        if (randomIndex == 0)
        {
            allMinigames[0].SetActive(true);
            miniGame = allMinigames[0];

            miniGame.SetActive(true);
            targetTime = miniTime;

            if (targetTime <= 0.0f)
            {
                miniStart = false;
                miniGame.SetActive(false);
                targetTime = mainTime;
            }
        }

        if (randomIndex == 1)
        {
            allMinigames[1].SetActive(true);
            miniGame = allMinigames[1];

            miniGame.SetActive(true);
            targetTime = miniTime;

            if (targetTime <= 0.0f)
            {
                miniStart = false;
                miniGame.SetActive(false);
                targetTime = mainTime;
            }
        }
    }

    void minigameStart()
    {
        

        //miniGame.SetActive(true);
        //targetTime = miniTime;

        //if (targetTime <= 0.0f)
        //{
            //miniStart = false;
            //miniGame.SetActive(false);
            //targetTime = mainTime;
        //}
    }
}
