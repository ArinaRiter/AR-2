using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MagicBallController : MonoBehaviour
{
    [SerializeField] private Animator ballAnimator;
    [SerializeField] private GameObject title;
    [SerializeField] private TextMeshProUGUI extraInfoUI;
    [SerializeField] private GameObject extraInfoBG;
    [SerializeField] private TextMeshProUGUI _text;
    private int count;
    private string answer;

    public void MagicBall()
    {
        extraInfoBG.SetActive(true);
        extraInfoUI.text = _text.text;
    }
    public void TellMe()
    {
        ballAnimator.SetBool("IsLighting", true);
        title.SetActive(true);
        count = Random.Range(0, 5);
        switch (count)
        {
            case 1:
                answer = "Да";
                break;
            case 2:
                answer = "Нет";
                break;
            case 3:
                answer = "Духи ответят позже";
                break;
            case 4:
                answer = "Не уверен";
                break;
            default:
                answer = "Одзначно да";
                break;

        }
        title.GetComponent<TextMeshPro>().text = answer;
    }
    public void Completing()
    {
        ballAnimator.SetBool("IsLighting", false);
        title.SetActive(false);
        extraInfoBG.SetActive(false);
        extraInfoUI.text = "";
    }

}
