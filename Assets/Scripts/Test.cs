using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public void onClick(){
        print(this.gameObject.name);
    }

    void OnMouseDown()
    {
        Debug.Log ("Stop that, it tickles!");
    }

    void OnPointerDown(){
        Debug.Log ("Stop that, it tickles!");
    }
}
