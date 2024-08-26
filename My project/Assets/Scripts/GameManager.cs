using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool canplay = false;
    [SerializeField] Camera camera;

    [SerializeField] GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start Game");
        camera  = FindObjectOfType<Camera>();

    }

    // Update is called once per frame
    void Update()
    {
        if((canplay == false) && ((Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.Space)) ) ){
            canplay = true;
        }

        if (canplay){
            CameraFollow(player);
        }
    }

    void CameraFollow(GameObject player){
        camera.transform.position = new Vector3(player.transform.position.x, 0, -10);
    }
}
