using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MenuItem : MonoBehaviour
{
    //[SerializeField] private TextMeshPro _textField;
    [SerializeField]
    public void Initialize()
    {
        Instantiate(GameObject.FindGameObjectWithTag("Cube"));
    }
    [SerializeField]
    public void Destroyed()
    {
        Destroy(GameObject.FindGameObjectWithTag("Cube"));
    }
    
}
