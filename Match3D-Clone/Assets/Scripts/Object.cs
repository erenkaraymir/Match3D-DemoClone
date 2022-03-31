using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    public int number;

    public void SetNumber(int _number)
    {
        Debug.Log("set number ulaþtý");
        number = _number;
    }

    private void Start()
    {
        Debug.Log(number);
    }
}
