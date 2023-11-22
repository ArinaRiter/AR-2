using Microsoft.MixedReality.Toolkit.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InspectRaycast : MonoBehaviour
{
     public void InteractWithObject(ManipulationEventData data)
    {
        data.ManipulationSource.GetComponent<ObjectController>().ShowObjectName();
    }
}
