using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static float moneyScore = 0;
    public static float multiplier = 1;
    public GameObject scoreUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreUI.GetComponent<TMP_Text>().text = "$"+ moneyScore;
        if(moneyScore < 0)
        {
            scoreUI.GetComponent<TMP_Text>().faceColor = Color.red;
        }
        else
        {
            scoreUI.GetComponent<TMP_Text>().faceColor = Color.green;
        }
    }
}
