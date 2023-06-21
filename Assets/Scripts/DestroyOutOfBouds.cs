using UnityEngine;

public class DestroyOutOfBouds : MonoBehaviour
{
    private float topBound = -18f;

    void Update()
    {
        if (transform.position.x < topBound)
        {
            gameObject.SetActive(false);
        }
    }
}
