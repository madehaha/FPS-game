using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class coinsGenerator : MonoBehaviour
{
    public GameObject coinPrefab; // 金币预制件
    public int numberOfCoins = 5; // 每次生成的金币数量
    public float spawnInterval = 100.0f; // 金币生成的时间间隔
    public Vector3 spawnAreaMin; // 生成范围的最小点
    public Vector3 spawnAreaMax;

    private List<GameObject> spawnedCoins = new List<GameObject>(); // 存储生成的金币

    void Start()
    {
        spawnAreaMin = new Vector3(-96, 0.6f, -89);
        spawnAreaMax = new Vector3(-52, 0.6f, -52);
        StartCoroutine(SpawnCoinsRoutine()); // 启动协程

    }

    IEnumerator SpawnCoinsRoutine()
    {
        while (true)
        {   
            // 生成金币
            SpawnCoins();

            // 等待指定时间间隔
            yield return new WaitForSeconds(spawnInterval);

            // 删除金币
            DestroyCoins();
        }
    }

    void SpawnCoins()
    {
        // 循环生成指定数量的金币
        for (int i = 0; i < numberOfCoins; i++)
        {
            // 随机生成位置
            Vector3 randomPosition = new Vector3(
                UnityEngine.Random.Range(spawnAreaMin.x, spawnAreaMax.x),
                0.6f,
                UnityEngine.Random.Range(spawnAreaMin.z, spawnAreaMax.z)
            );

            // 实例化金币
            GameObject coin = Instantiate(coinPrefab, randomPosition, Quaternion.identity);
            spawnedCoins.Add(coin); // 将生成的金币添加到列表中
        }
    }

    void DestroyCoins()
    {
        // 删除所有生成的金币
        foreach (GameObject coin in spawnedCoins)
        {
            if (coin != null)
            {
                Destroy(coin);
            }
        }
        spawnedCoins.Clear(); // 清空列表
    }
}


