using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Player;
    public GameObject startUI;
    public static int speed = 2;
    public bool gameStart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameStart == false)
        {
            if(Input.GetKeyDown(KeyCode.Space) == true)
            {
                startUI.SetActive(false);
                gameStart = true;
            }
        }
        if(gameStart == true)
        {
            Player.transform.Translate(1f * Time.deltaTime * speed, 1f * Time.deltaTime * speed, 0f);
        }
        

        
    }

}
