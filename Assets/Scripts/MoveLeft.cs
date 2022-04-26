using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 8;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (CanvansMenager.PlayGame)
        {
            if (!PlayerController.gameOver)
            {
                transform.Translate(Vector3.left * Time.deltaTime * speed);
                if (transform.position.x < -30)
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}
