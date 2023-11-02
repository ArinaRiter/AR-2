using Microsoft.MixedReality.Toolkit.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChipsTouching : MonoBehaviour
{
    public void KinematicYes(ManipulationEventData mnp)
    {
        gameObject.GetComponent<Rigidbody>().isKinematic = true;
    }

    public void KinematicNo(ManipulationEventData mnp)
    {
        gameObject.GetComponent<Rigidbody>().isKinematic = false;
    }
}
