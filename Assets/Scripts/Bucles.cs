using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucles : MonoBehaviour
{
    private int i = 1;

    public int Num;

    private void Start()
    {
        for (int i = 100; i >= 0; i -= 2)
        {
            Debug.Log(i);
        }

        while (i <= 20)
        {
            Debug.Log("Hola, holita, vecinito");
            i++;
        }

        for (int i = Num; i <= 0; i--)
        {
            Debug.Log(i);
        }
    }
}
