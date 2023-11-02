using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChipsPlace : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Chips"))
        {
            gameObject.transform.position = other.transform.position;
            other.gameObject.SetActive(false);
        }
    }
}
