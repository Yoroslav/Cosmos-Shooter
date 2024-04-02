using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    public float timer = 1f;

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            DestroyObject();
        }
    }

    void DestroyObject()
    {
        Destroy(gameObject);
    }
}
