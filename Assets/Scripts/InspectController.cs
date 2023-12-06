using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class InspectController : MonoBehaviour
{
    [SerializeField] private GameObject objectNameBG;
    [SerializeField] private TextMeshProUGUI objectNameUI;

    [SerializeField] private float onScreenTimer;
    [SerializeField] private TextMeshProUGUI extraInfoUI;
    [SerializeField] private GameObject extraInfoBG;
    [HideInInspector] public bool startTimer;
    private float timer;

    private void Start()
    {
        objectNameBG.SetActive(true);
        extraInfoBG.SetActive(true);
    }

    //private void Update()
    //{
    //    if (startTimer)
    //    {
    //        timer -= Time.deltaTime;

    //        if (timer <= 0)
    //        {
    //            timer = 0;
    //            ClearAditionalInfo();
    //            startTimer = false;
    //        }
    //    }
    //}

    public void ShowName(string objectName)
    {
        objectNameBG.SetActive(true);
        objectNameUI.text = objectName;
    }

    public void HideName()
    {
        objectNameBG.SetActive(false);
        objectNameUI.text = "";
    }

    public void ShowAdditionalInfo(string newInfo)
    {
        extraInfoBG.SetActive(true);
        extraInfoUI.text = newInfo;
    }

    void ClearAditionalInfo()
    {
        extraInfoBG.SetActive(false);
        extraInfoUI.text = "";
    }
}
