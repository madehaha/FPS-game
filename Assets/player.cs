using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.ComponentModel;

public class Player : MonoBehaviour
{
    public int enable = 1;
    public int coinCount = 0; // ��¼�������
    public TextMeshProUGUI coinText; // ��ʾ���������UI�ı�
    public TextMeshProUGUI winText;
    public static Player player;

    void Start()
    {
        player = this;
        UpdateCoinText(); // ��ʼ����ʾ
    }

    public void CollectCoin()
    {   if(enable==1)
        {
            coinCount++; // ���ӽ������  
            
            UpdateCoinText(); // ������ʾ
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
            coinCount+= con; // ���ӽ������  
            
            UpdateCoinText(); // ������ʾ
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


