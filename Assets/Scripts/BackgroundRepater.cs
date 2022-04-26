using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRepater : MonoBehaviour
{
  private Vector3 startPos;
    private float speed = 5;
    private float repeateWidth;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        repeateWidth = GetComponent<BoxCollider>().size.x ;
    }

    // Update is called once per frame
    void Update()
    {
        if (CanvansMenager.PlayGame)
        {
            if (!PlayerController.gameOver)
            {
                transform.Translate(Vector3.left * Time.deltaTime * speed);
                if (transform.position.x < startPos.x - repeateWidth)
                {
                    transform.position = startPos;
                }
            }
        }
    }
}
