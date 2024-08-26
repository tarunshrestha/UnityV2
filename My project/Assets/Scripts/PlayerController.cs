using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]GameObject gameManager;

    [SerializeField]float jump = 8;
    [SerializeField]float speed = 5;
    // public GameObject playerName;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.GetComponent<GameManager>().canplay){
            transform.position += new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);
            // playerName.transform.position = new Vector2(this.transform.position.x, this.transform.position.y);
            if (Input.GetKeyDown(KeyCode.W)){
            rb.velocity = new Vector2 (rb.velocity.x, jump);

            }
        }
    }
}
