using UnityEngine;
using TMPro;

public class MainTimer : MonoBehaviour
{

    public float mainTime = 5f;
    public float miniTime = 10f;

    public float targetTime;

    public bool miniEnded;

    public GameObject miniGame;

    void Start()
    {
        miniEnded = false;
        targetTime = mainTime;
    }

    // Update is called once per frame
    void Update()
    {
        targetTime -= Time.deltaTime;

        if(targetTime <= -0.1f)
        {
            miniGameStart();
        }
        if (miniEnded == true)
        {
            targetTime = mainTime;
            miniEnded = false;
        }
    }

    void miniGameStart()
    {
        miniGame.SetActive(true);
        targetTime = miniTime;
        targetTime -= Time.deltaTime;

        if (targetTime <= 0.0f)
        {
            miniEnded = true;
            miniGame.SetActive(false);
        }
    }
}
