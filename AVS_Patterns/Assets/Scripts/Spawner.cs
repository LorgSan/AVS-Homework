using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    GameObject apple;
    public float count;
    public float step;
    // Start is called before the first frame update
    void Start()
    {
        Spawn();

    }

    void Spawn()
    {
        for(int i = 0; i < count; i++)
        {
            GameObject apple = Instantiate(Resources.Load("Apple") as GameObject);
            Vector3 newPos = new Vector3(
                (gameObject.transform.position.x + i) * step,
                (gameObject.transform.position.y + i) * step,
                0);
            apple.transform.position = newPos;                     
        }
    }
}
