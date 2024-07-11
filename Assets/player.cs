using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.ComponentModel;

public class Player : MonoBehaviour
{
    public int enable = 1;
    public int coinCount = 0; // 记录金币数量
    public TextMeshProUGUI coinText; // 显示金币数量的UI文本
    public TextMeshProUGUI winText;
    public static Player player;

    void Start()
    {
        player = this;
        UpdateCoinText(); // 初始化显示
    }

    public void CollectCoin()
    {   if(enable==1)
        {
            coinCount++; // 增加金币数量  
            
            UpdateCoinText(); // 更新显示
            if (coinCount >= 30)
            {
                win();
            }
        }
    }

    public void KillGrabCoin(int con)
    {
        if (enable == 1)
        {
            coinCount+= con; // 增加金币数量  
            
            UpdateCoinText(); // 更新显示
            if (coinCount >= 30)
            {
                win();
            }
        }
    }
   

    void UpdateCoinText()
    {
        if (coinText != null)
        {
            coinText.text = "Coins: " + coinCount;
        }
    }
    void win()
    {
        enable = 0;
        winText.text = "You're safe, temporarily";
    }
    void reset()
    {
        enable = 1;
        winText.text = "";
    }
    
}


