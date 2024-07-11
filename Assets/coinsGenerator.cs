using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class coinsGenerator : MonoBehaviour
{
    public GameObject coinPrefab; // ���Ԥ�Ƽ�
    public int numberOfCoins = 5; // ÿ�����ɵĽ������
    public float spawnInterval = 100.0f; // ������ɵ�ʱ����
    public Vector3 spawnAreaMin; // ���ɷ�Χ����С��
    public Vector3 spawnAreaMax;

    private List<GameObject> spawnedCoins = new List<GameObject>(); // �洢���ɵĽ��

    void Start()
    {
        spawnAreaMin = new Vector3(-96, 0.6f, -89);
        spawnAreaMax = new Vector3(-52, 0.6f, -52);
        StartCoroutine(SpawnCoinsRoutine()); // ����Э��

    }

    IEnumerator SpawnCoinsRoutine()
    {
        while (true)
        {   
            // ���ɽ��
            SpawnCoins();

            // �ȴ�ָ��ʱ����
            yield return new WaitForSeconds(spawnInterval);

            // ɾ�����
            DestroyCoins();
        }
    }

    void SpawnCoins()
    {
        // ѭ������ָ�������Ľ��
        for (int i = 0; i < numberOfCoins; i++)
        {
            // �������λ��
            Vector3 randomPosition = new Vector3(
                UnityEngine.Random.Range(spawnAreaMin.x, spawnAreaMax.x),
                0.6f,
                UnityEngine.Random.Range(spawnAreaMin.z, spawnAreaMax.z)
            );

            // ʵ�������
            GameObject coin = Instantiate(coinPrefab, randomPosition, Quaternion.identity);
            spawnedCoins.Add(coin); // �����ɵĽ����ӵ��б���
        }
    }

    void DestroyCoins()
    {
        // ɾ���������ɵĽ��
        foreach (GameObject coin in spawnedCoins)
        {
            if (coin != null)
            {
                Destroy(coin);
            }
        }
        spawnedCoins.Clear(); // ����б�
    }
}


