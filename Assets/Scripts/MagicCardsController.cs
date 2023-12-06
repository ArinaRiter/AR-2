using System.Collections;
using Microsoft.MixedReality.Toolkit.UI;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class MagicCardsController : MonoBehaviour
{
    [SerializeField] private GameObject button;
    [SerializeField] private GameObject cards;
    [SerializeField] private GameObject confirmation;
    [SerializeField] private GameObject objectNameBG;
    [SerializeField] private TextMeshProUGUI objectNameUI;
    [SerializeField] private TextMeshProUGUI extraInfoUI;
    [SerializeField] private GameObject extraInfoBG;
    [SerializeField] private GameObject buttonComplete;

    private GameObject selectCard;
    private bool IsSelected = false;
    private Color color;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void MagicCards()
    {
        ClearAditionalInfo();
        button.SetActive(true);
    }
    public void InteractWithCard(ManipulationEventData data)
    {
        if (animator.GetBool("Next1"))
        {
            if (IsSelected)
            {
                selectCard.GetComponent<Renderer>().material.color = color;
                selectCard = data.ManipulationSource.gameObject;
                data.ManipulationSource.GetComponent<Renderer>().material.color = new Color(0.5f, 1, 1);
            }
            else
            {
                selectCard = data.ManipulationSource.gameObject;
                color = data.ManipulationSource.GetComponent<Renderer>().material.color;
                data.ManipulationSource.GetComponent<Renderer>().material.color = new Color(0.5f, 1, 1);
                confirmation.SetActive(true);
                IsSelected = true;
            }
        }
       
    }
    public void Confirm()
    {
        confirmation.SetActive(false);
        button.SetActive(false);
        selectCard.GetComponent<Renderer>().material.color = new Color(0.5f, 1, 1);
        selectCard.transform.eulerAngles = new Vector3(-90f, -90f, 90f);
        selectCard.GetComponent<ObjectController>().ShowObjectName();
        selectCard.GetComponent<ObjectController>().ShowExtraInfo();
        buttonComplete.SetActive(true);
    }
    void ClearAditionalInfo()
    {
        extraInfoBG.SetActive(false);
        extraInfoUI.text = "";
        objectNameBG.SetActive(false);
        objectNameUI.text = "";
    }

    public void Complete()
    {
        IsSelected = false;
        selectCard.GetComponent<Renderer>().material.color = color;
        cards.GetComponent<CardsMixed>().CardsMix(-90);
        ClearAditionalInfo();
        buttonComplete.SetActive(false);
        //функция по перевороту карт на 180
        gameObject.GetComponent<BookAnimator>().CloseBook();
    }

}
