using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnim : MonoBehaviour
{
    Animator Anim;  
    // Start is called before the first frame update
    void Start()
    {
        Animator Anim = gameObject.GetComponent<Animator>();
        Debug.Log(Anim);
        Invoke("StartAnim", Random.Range(0f,3f));
    }

    void StartAnim()
    {
        gameObject.GetComponent<Animator>().SetTrigger("startanim");
    }
}
