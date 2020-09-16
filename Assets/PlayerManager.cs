using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public GameObject derrota;
    public GameObject victoria;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Casa")
        {
        Debug.Log("A");
        }
    }
    /*private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Casa")
        {
            if (collision.GetComponent<HouseManager>().isHouseGood == false)
            {
                ScoreManager.multiplier = 1f;
                ScoreManager.moneyScore -= 45 * ScoreManager.multiplier;
                if (GameManager.speed > 2)
                {
                    GameManager.speed -= 1;
                }
            }
        }
    }*/
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Casa")
        {
            if(Input.GetKeyDown(KeyCode.Space) == true)
            {
                if(collision.GetComponent<HouseManager>().isHouseGood == false)
                {
                    Debug.Log("B");
                    ScoreManager.moneyScore += 50 * ScoreManager.multiplier;
                    ScoreManager.multiplier += 0.1f;
                    GameManager.speed += 1;
                    Destroy(collision.transform.gameObject.GetComponent<Collider2D>());
                }

                else
                {
                    ScoreManager.multiplier = 1f;
                    ScoreManager.moneyScore -= 45 * ScoreManager.multiplier;
                    if(GameManager.speed > 2)
                    {
                        GameManager.speed -= 1;
                    }
                    
                }
            }
        }

        if (collision.tag == "Finish")
        {
            GameManager.speed = 0;
            if (ScoreManager.moneyScore <= 200)
            {
                derrota.SetActive(true);
                if (Input.GetKeyDown(KeyCode.Space) == true)
                {
                    SceneManager.LoadScene(0);
                }
            }

            else
            {
                victoria.SetActive(true);
                if (Input.GetKeyDown(KeyCode.Space) == true)
                {
                    SceneManager.LoadScene(0);
                }
            }
        }
    }
}
