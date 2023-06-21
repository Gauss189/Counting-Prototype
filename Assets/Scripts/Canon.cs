using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    [SerializeField] private GameObject canonBallPrefab;
    [SerializeField] private GameObject spawnPoint;

    [SerializeField] private float shootForce = 5f;
    private float moveSpeed = 15f;
    private float movementBoundry = 21.5f;
    private float horizontalInput;

    // private Rigidbody canonBallRigidbody;

    private void Start()
    {
        // canonBallRigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        MovementMethod();
        ProjectileShoot();
    }

    private void MovementMethod()
    {
        if (transform.position.z < -movementBoundry)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -movementBoundry);
        }
        if (transform.position.z > movementBoundry)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, movementBoundry);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * horizontalInput);
    }

    private void ProjectileShoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject canonBall = (GameObject)Instantiate(canonBallPrefab, spawnPoint.transform.position, spawnPoint.transform.rotation);
            Rigidbody canonBallRigidbody = canonBall.GetComponent<Rigidbody>();
            canonBallRigidbody.AddForce(canonBall.transform.right * shootForce, ForceMode.Impulse);
        }
    }
}


