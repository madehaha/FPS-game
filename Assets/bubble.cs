using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class bubble : MonoBehaviour
{
    public Transform target; // 怪物的位置，用于确定 Text 元素的位置
    private TextMeshProUGUI chatText; // UI Text 元素

    void Start()
    {
        // 获取 Text 元素的引用
        chatText = GetComponentInChildren<TextMeshProUGUI>();
        SetChatText("you can never escape");
    }

   // void Update()
    //{
        // 将聊天气泡位置设为怪物的头顶位置
     //   Vector3 bubblePosition = target.position + Vector3.up * 1.4f; // 调整高度以适应怪物头顶
    //    transform.position = bubblePosition;
    //}

    public void SetChatText(string text)
    {
        // 设置聊天气泡显示的文本内容
        if (chatText != null)
        {
            chatText.text = text;
        }
    }
}



