using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Color color;
    Renderer rend;

    void Start(){
        Debug.Log("Let's do this thing!");
        rend = GetComponent<Renderer>();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player"){
            rend.material.color = color;
            Debug.Log("Collision");
        }
    }
}
