using UnityEngine;
using TMPro;

public class MainTimer : MonoBehaviour
{

    public float mainTime = 5f;
    public float miniTime = 10f;

    public float targetTime;

    public int randomIndex;

    public bool miniStart;

    public GameObject[] allMinigames;
    public GameObject miniGame;

    public GameObject mainBG;
    public GameObject mainPlayer;

    public PlayerController movingPlayer;

    void Start()
    {
        miniStart = false;
        targetTime = mainTime;
    }

    // Update is called once per frame
    void Update()
    {
        targetTime -= Time.deltaTime;

        if (targetTime <= -0.1f && miniStart == false) //if the timer has reached zero and the minigame wasn't played last
        {
            miniStart = true;
            mainBG.SetActive(false);
            mainPlayer.SetActive(false);
            mainPlayer.transform.position = new Vector3(0, -4, 0);
            PickMiniGame();
        }
        if (targetTime <= 0.0f && miniStart == true) //if the timer has reached zero and a minigame was played last
        {
            if (movingPlayer.playerHit == true)
            {
                minigameLost();
            }
            miniStart = false;
            miniGame.SetActive(false);
            mainBG.SetActive(true);
            mainPlayer.SetActive(true);
            targetTime = mainTime;
        }
    }

    void PickMiniGame()
    {
        randomIndex = Random.Range(0, allMinigames.Length); //picks a random index from the array, deciding which minigame to pick

        if (randomIndex == 0) //For Minigame One
        {
            allMinigames[0].SetActive(true);
            miniGame = allMinigames[0];

            miniGame.SetActive(true);
            targetTime = miniTime;

            if (targetTime <= 0.0f) //for safety probably not needed
            {
                miniStart = false;
                miniGame.SetActive(false);
                targetTime = mainTime;
            }

        }

        if (randomIndex == 1) //Minigame Two
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

    void minigameWin()
    {
        //Play Winning Animation of selected minigame

        //Proceed to next round
    }

    void minigameLost()
    {
        //Play Losing Animation of selected minigame

        //Take away one heart
        

        //Proceed to next round

        if (randomIndex == 0)
        {
            Debug.Log("Got hit, lose one heart!");
            movingPlayer.playerHit = false;
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
