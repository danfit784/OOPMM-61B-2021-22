using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static GameManager _instance;

    private void Awake()
    {
        if (_instance == null)    //SINGLETON PATTERN
        {
            _instance = this;
        }
        else if (_instance != this)
        {
            Destroy(this.gameObject);
        }
    }


    // Start is called before the first frame update


    void Start()
    {
        
    }


    public void IncreaseScore(int scorevalue)
    {
        GameData.score = GameData.score + scorevalue;
        Debug.Log("Score: " + GameData.score.ToString());
        Text myscoretextobject = GameObject.Find("ScoreText").GetComponent<Text>();
        myscoretextobject.text = "Score : " + GameData.score.ToString();
    }


}
