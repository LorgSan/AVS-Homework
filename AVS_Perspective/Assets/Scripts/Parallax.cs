using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Parallax : MonoBehaviour
{
    private float width, height;
    private Vector2 startPos;
    public GameObject cam;
    [SerializeField] float parallaxEffect;

    void Start()
    {
        startPos.x = transform.position.x;
        startPos.y = transform.position.y;
        //width = GetComponent<Image>().sprite.bounds.size.x;
        //var sortOrder = GetComponent<SpriteRenderer>().sortingOrder;
        //parallaxEffect = ((float)sortOrder)*0.1f;
    }

    void Update()
    {
        float xShift = (cam.transform.position.x * parallaxEffect);
        float yShift = (cam.transform.position.y * parallaxEffect);
        transform.position = new Vector3(startPos.x + xShift, startPos.y + yShift, transform.position.z);

    }

}
