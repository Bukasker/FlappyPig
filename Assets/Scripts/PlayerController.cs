using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    static public bool gameOver = false;
    private Rigidbody2D rb;
    public float jumpForce = 600f;
    private Animator anim1;
    private Animator anim2;
    public GameObject wing1;
    public GameObject wing2;
    public Collider2D col;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim1 = wing1.GetComponent<Animator>();
        anim2 = wing2.GetComponent<Animator>();
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (CanvansMenager.PlayGame)
        {
            if (Input.GetKeyUp(KeyCode.Space) && !gameOver)
            {
                anim1.SetTrigger("SpaceTrigger");
                anim2.SetTrigger("SpaceTrigger");
                rb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
                transform.Rotate(0f, 0f, 17f);
            }
            else
            {
                if (!gameOver)
                {
                    transform.Rotate(0f, 0f, -0.05f);
                }
            }
            if (gameOver)
            {
                col.enabled = false;
                transform.Rotate(0, 0.5f, 0);
            }
        }
    }
    public void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.CompareTag("Pillars"))
        {
            gameOver = true;
            CanvansMenager.PlayGame = false;
        }
    }
}
