using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject ballPrefab;
    GameObject ball;

    private void Start()
    {
        ball = Instantiate(ballPrefab, transform);
    }

    public void BallReset()
    {
        ball.GetComponent<Transform>().position = transform.position;
        ball.GetComponent<Rigidbody>().Sleep();
    }
}