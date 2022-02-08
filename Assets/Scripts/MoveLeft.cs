using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 8;
    public float leftBound;
    private PlayerController playerControllerScript;
    void Start()
    {
        playerControllerScript =
        GameObject.Find("Player").GetComponent<PlayerController>();

    }
    void Update()
    {
        if (!playerControllerScript.gameOver)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (transform.position.x < leftBound && gameObject.tag=="obstacle")
        {
            Destroy(gameObject);
        }

    }
}
