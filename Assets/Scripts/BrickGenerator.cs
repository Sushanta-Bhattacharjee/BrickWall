using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickGenerator : MonoBehaviour
{
    
    void Start()
    {
        GameObject prefab = Resources.Load("Brick") as GameObject;
        for (int i = 0; i<12; i++)
        {
            for (int height =0; height <10; height++)
            {
                GameObject Brick = Instantiate(prefab) as GameObject;
                float offset = height % 2;
                Brick.transform.position = new Vector3(transform.position.x + i * 2 + offset, transform.position.y + height, transform.position.z);
            }
        }
    }

    
}
