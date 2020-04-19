using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Material material;
    Renderer rend;

    void start(){
        rend = GetComponent<Renderer>();
    }

    void UpDate(Collision col)
    {
        if (col.gameObject.tag == "Player"){
            rend.material = material;
        }
    }
}
