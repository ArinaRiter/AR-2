using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MagicBallController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private GameObject title;
    private int count;
    private string answer;

    public void TellMe()
    {
        animator.SetBool("IsLighting", true);
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
                answer = "Одзначно стоит";
                break;

        }
        title.GetComponent<TextMeshPro>().text = answer;
    }
    public void ThankYou()
    {
        animator.SetBool("IsLighting", false);
        title.SetActive(false);
    }

}
