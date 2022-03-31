using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class NumberCreater : MonoBehaviour
{
    [SerializeField] private List<GameObject> objects;
    private int _number = 0;

    private void Awake()
    {
        NumberCreator();
    }

    public void NumberCreator()
    {
        for (int i = 0; i < objects.Count; i += 2)
        {
            objects[i].GetComponent<Object>().SetNumber(_number);
            //Debug.Log(objects[i].number + "bu objenin" + objects[i].name);
            objects[i + 1].GetComponent<Object>().SetNumber(_number);
            //Debug.Log(objects[i+1].number + "bu objenin" + objects[i+1].name);
            _number++;
        }
    }
}
