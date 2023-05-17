using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;

public class ScoreCotroller : MonoBehaviour
{
    private static ScoreCotroller instance;

    int score=0, hp=5, red = 10, blue = 5, yellow = 0;
    [SerializeField]
    private TextMeshProUGUI textRed, textBlue, textYellow, textPoint, textHP, textkMypoint, textHighestPoint;
    [SerializeField]
    GameObject panelGameOver, player;



    private void Awake()
    {
        textRed.text = "10";
        textBlue.text = "5";
        textYellow.text = "0";
        textPoint.text = "0";
        textHP.text = "5";
        if (instance == null)
        {
            instance = this;
         //   DontDestroyOnLoad(gameObject);
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

    public  int GetScore(string name)
    {
        switch (name)
        {
            case "point":
                return this.score;
            case "hp":
                return this.hp;
            case "red":
                return this.red;
            case "blue":
                return this.blue;
            case "yellow":
                return this.yellow;
            default: return 0;
                
        }
        return 0;
    }
    public void  SetScore(string name, int i)
    {
        switch (name)
        {
            case "point":
                this.score += i;
                textPoint.text = this.score+ "";
                
                return;
            case "hp":
                this.hp += i;
                textHP.text = this.hp + "";
                if(this.hp<=0)
                {
                    GameObject boom = ObjectPool.Instance.GetObject("Boom3");
                    boom.transform.localPosition = transform.localPosition;
                    boom.SetActive(true);
                    player.SetActive(false);
                    StartCoroutine(GameOver());
                }    
                return;
            case "red":
                this.red += i;
                textRed.text = this.red + "";
                Debug.Log("ktra exissts" + textRed.text);
                return;
            case "blue":
                this.blue += i;
                textBlue.text = this.blue + "";
                return;
            case "yellow":
                this.yellow += i;
                textYellow.text = this.yellow + "";
                return;
            default: return;

        }
        return;
    }
    IEnumerator GameOver()
    {

        yield return new WaitForSeconds(2f);
        panelGameOver.SetActive(true);
        Time.timeScale = 0;
       

    }



    //int score, hp, red, blue, yellow;

}
