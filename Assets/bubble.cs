using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class bubble : MonoBehaviour
{
    public Transform target; // �����λ�ã�����ȷ�� Text Ԫ�ص�λ��
    private TextMeshProUGUI chatText; // UI Text Ԫ��

    void Start()
    {
        // ��ȡ Text Ԫ�ص�����
        chatText = GetComponentInChildren<TextMeshProUGUI>();
        SetChatText("you can never escape");
    }

   // void Update()
    //{
        // ����������λ����Ϊ�����ͷ��λ��
     //   Vector3 bubblePosition = target.position + Vector3.up * 1.4f; // �����߶�����Ӧ����ͷ��
    //    transform.position = bubblePosition;
    //}

    public void SetChatText(string text)
    {
        // ��������������ʾ���ı�����
        if (chatText != null)
        {
            chatText.text = text;
        }
    }
}



