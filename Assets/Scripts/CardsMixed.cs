using Microsoft.MixedReality.Toolkit.UI;
using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;

public class CardsMixed : MonoBehaviour
{
    private List<GameObject> transformList;

    public void CardsMix()
    {
        for (int i = 0; i < gameObject.transform.childCount; i++)
        {
            int j = Random.Range(0, gameObject.transform.childCount - 1);
            (gameObject.transform.GetChild(i).position,gameObject.transform.GetChild(j).position) = (gameObject.transform.GetChild(j).position, gameObject.transform.GetChild(i).position);
        }    
    }
}
