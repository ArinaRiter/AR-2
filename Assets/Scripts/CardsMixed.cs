using Microsoft.MixedReality.Toolkit.UI;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.XR.CoreUtils;
using UnityEngine;

public class CardsMixed : MonoBehaviour
{
    private List<Vector3> transformList = new();

    private void Start()
    {
        for (int i = 0; i < gameObject.transform.childCount; i++)
        {
            transformList.Add(gameObject.transform.GetChild(i).position);
        }
    }
    public void CardsMix(bool IsRotate)
    {
        for (int i = 0; i < gameObject.transform.childCount; i++)
        {
            gameObject.transform.GetChild(i).position = transformList[i];
            gameObject.transform.GetChild(i).transform.rotation = Quaternion.Euler(-90, 180, 0);
            gameObject.transform.GetChild(i).transform.Rotate(180,0,0);
            if (IsRotate)
                gameObject.transform.GetChild(i).GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            else
                gameObject.transform.GetChild(i).GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        }
        for (int i = 0; i < gameObject.transform.childCount; i++)
        {
            int j = Random.Range(0, gameObject.transform.childCount - 1);
            (gameObject.transform.GetChild(i).position,gameObject.transform.GetChild(j).position) = (gameObject.transform.GetChild(j).position, gameObject.transform.GetChild(i).position);
        }    
    }
}
