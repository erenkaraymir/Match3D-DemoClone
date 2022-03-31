using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchManager : MonoBehaviour
{
    [SerializeField]
    private GameObject firstObj;
    [SerializeField]
    private GameObject secondObj;

    private bool isFull;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Object"))
        {
            if(firstObj == null)
            {
                firstObj = other.gameObject;
            }
            else if(secondObj == null)
            {
                secondObj = other.gameObject;
                isFull = true;
            }
            else
            {
                Debug.Log("Slotlar dolu");
            }
        }
    }

    private void Update()
    {
        if (isFull)
        {
            if(firstObj.GetComponent<Object>().number == secondObj.GetComponent<Object>().number)
            {
                Debug.Log("Sayi!!!!!");
                Destroy(firstObj, 0.5f);
                Destroy(secondObj, 0.5f);
                isFull = false;
            }
            else
            {
                Debug.Log("Eþleþme yok");
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (secondObj != null)
        {
            secondObj = null;
            isFull = false;
        }
        else if (firstObj != null)
        {
            firstObj = null;
            isFull = false;
        }
    }
}
