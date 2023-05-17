using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 
public class StoreController : MonoBehaviour
{

    [SerializeField]
    private GameObject item1, item2, item3, item4;
    [SerializeField]
    private Image img1, img2, img3, img4;
    [SerializeField]
    private TextMeshProUGUI detail;

    int indexBuy = 0;



    private void OnEnable()
    {
        UpdateColor();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }



    void  UpdateColor ()
    {
    
        if (!item1.activeInHierarchy && ScoreCotroller.GetInstance().GetScore("red") >= 20)
        {
            
            ChangeColor(img1, 1);
        }
        else
        {
            ChangeColor(img1, 0);
        }

        if (!item2.activeInHierarchy && ScoreCotroller.GetInstance().GetScore("blue") >= 15)
        {
            ChangeColor(img2, 1);
        }
        else
        {
            ChangeColor(img2, 0);
        }
        if (!item3.activeInHierarchy && ScoreCotroller.GetInstance().GetScore("yellow") >= 10)
        {
            ChangeColor(img3, 1);
        }
        else
        {
            ChangeColor(img3, 0);
        }
        if (!item4.activeInHierarchy && ScoreCotroller.GetInstance().GetScore("red") >= 30)
        {
            ChangeColor(img4, 1);
        }
        else
        {
            ChangeColor(img4, 0);
        }
    }

    void ChangeColor(Image img, int check)
    {

        Color colors = img.color;
        if (check == 0)
        {

            img.color = Color.black;
        }
        else if (check == 1)
        {
            img.color = Color.white;
        }
        
    }

    public  void OnClickItem(int i)
    {

        indexBuy = i;
        if (i == 0)
        {
            detail.text = "Đây là đồng hồ làm chậm thời gian. Không gian xung quanh bạn sẽ di chuyển chậm lại giúp cho bạn dễ dàng né tráng nguy hiểm. \n  Time: 30s";
           
        }
        else if (i == 1)
        {
            detail.text = "Đây là tấm kín bảo vệ máy bay khỏi những nguy hiểm cấp 1, tuy nhiên sẽ bị phá hủy bởi tên lửa. \n  Time: 30s";

        }
        else if (i == 2)
        {
            detail.text = "Đây là động cơ hỗ trợ bắn đạn laser 3 tia 1 lúc, tuy nhiên cần 3 năng lực red  để thực hiện. \n  Time: 30s";

        }
        else if (i == 3)
        {
            detail.text = "Đây là động cơ phản lực giúp máy bay di chuyển nhanh chống \n  Time: 25s";

        }

    }

    public void OnClickBuy()
    {
        if (indexBuy== 0)
        {
            item1.SetActive(true);
            ScoreCotroller.GetInstance().SetScore("red",-20);
        }
        else if (indexBuy == 1)
        {
            item2.SetActive(true);
            ScoreCotroller.GetInstance().SetScore("blue", -10);
        }
        else if (indexBuy == 2)
        {
            item3.SetActive(true);
            ScoreCotroller.GetInstance().SetScore("yellow", -10);
        }
        else if (indexBuy == 3)
        {
            item4.SetActive(true);
            ScoreCotroller.GetInstance().SetScore("red", -30);

        }
        UpdateColor();

    }
        
}
