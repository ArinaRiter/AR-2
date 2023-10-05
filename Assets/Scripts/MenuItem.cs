using System;
using UnityEngine;

[Serializable]
public class MenuItem : MonoBehaviour
{
    [field: SerializeField] public string ID { get; private set; }
    [field: SerializeField] public string Title { get; private set; }
}
