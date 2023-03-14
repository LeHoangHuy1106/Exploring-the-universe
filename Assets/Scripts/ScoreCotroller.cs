using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCotroller : MonoBehaviour
{
    private static ScoreCotroller instance;

    int score, hp, red, blue, yellow;



    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static ScoreCotroller GetInstance()
    {
        return instance;
    }
    public int Score { get => score; set => score = value; }
    public int Hp { get => hp; set => hp = value; }
    public int Red { get => red; set => red = value; }
    public int Blue { get => blue; set => blue = value; }
    public int Yellow { get => yellow; set => yellow = value; }


}
