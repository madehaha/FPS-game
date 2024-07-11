using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{

    public float rotationSpeed = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Player player = other.GetComponent<Player>();
            if (player != null)
            {
                player.CollectCoin();
                Destroy(gameObject); // 销毁金币
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        // 每帧只围绕Y轴旋转金币
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
