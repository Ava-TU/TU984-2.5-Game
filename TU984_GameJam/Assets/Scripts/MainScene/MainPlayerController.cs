using UnityEngine;

public class MainPlayer : MonoBehaviour
{
    public float moveSpeed = 0f;

    private void Update()
    {
        transform.Translate(new Vector2 (1f, 0f) * moveSpeed * Time.deltaTime);
    }
}
