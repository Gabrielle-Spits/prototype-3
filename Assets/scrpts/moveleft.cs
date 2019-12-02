using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveleft : MonoBehaviour
{
    private float speed = 30;
    private playercontroler playerControllerScript;
    private float leftBound = -15;
    
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("player").GetComponent<playercontroler>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (transform.position.x < leftBound)
        {
            
        }
    }
}
