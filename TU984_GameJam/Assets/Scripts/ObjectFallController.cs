using UnityEngine;

public class ObjectFallController : MonoBehaviour
{

    public float wait = 0.8f;
    public float targetTime;

    public GameObject fallingObject;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //InvokeRepeating("Fall", wait, wait);
        targetTime = wait;
    }

    void Update()
    {
        targetTime -= Time.deltaTime;

        if (targetTime <= 0.0f)
        {
            Instantiate(fallingObject, new Vector3(Random.Range(-10, 10), 10, 0), Quaternion.identity);
            targetTime = wait;
        }
    }
}
