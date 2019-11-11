using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject rainDropPrefab;

    public float rainDrop_Spawn_Timer = 5f;
    private float current_RainDrop_Spawn_Timer;

    private int rainDrop_Spawn_Count = 0;

    public float min_x = -2.35f , min_y = -4.6f , max_x = 2.35f , max_y = 4.6f ;

    void Start()
    {
        current_RainDrop_Spawn_Timer = rainDrop_Spawn_Timer;
    }

    void Update()
    {
        SpawnRainDrop();

    }

    void SpawnRainDrop()
    {
        current_RainDrop_Spawn_Timer += Time.deltaTime*10;

        if(current_RainDrop_Spawn_Timer >= rainDrop_Spawn_Timer)
        {
            rainDrop_Spawn_Count++;
            Vector4 temp = transform.position;
            temp.x = Random.Range(min_x, max_x);
            temp.y = Random.Range(min_y, max_y);

            GameObject newRainDrop = null;

            if(rainDrop_Spawn_Count < 50)
            {
                newRainDrop = Instantiate(rainDropPrefab, temp, Quaternion.identity);
            }
            else if (rainDrop_Spawn_Count == 30)
            {
            }
            current_RainDrop_Spawn_Timer = 0f;
        }// spawn rainDrop
    }
}
