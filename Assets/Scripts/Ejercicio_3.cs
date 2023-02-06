using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_3 : MonoBehaviour
{
    public int Num;

    void Start()
    {
        for (int i = Num; i >= 0; i--)
        {
            Debug.Log(i);
        }
    }
}
