using UnityEngine;

public class BoxDriver : MonoBehaviour
{

    private float moveBoundry = 25.8f;
    private float speed = 0.25f;

    Vector3 pointA;
    Vector3 pointB;

    void Update()
    {
        pointA = new Vector3(0, 0, -moveBoundry);
        pointB = new Vector3(0, 0, moveBoundry);

        //PingPong between 0 and 1
        float time = Mathf.PingPong(Time.time * speed, 1);
        transform.position = Vector3.Lerp(pointA, pointB, time);
    }
}

