using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;

public class BookAnimator : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private GameObject TitleGroup_1;
    [SerializeField] private GameObject TitleGroup_2;
    public void OpenBook()
    {
        animator.SetBool("IsClosed", false);
        animator.SetBool("IsOpened", true);
    }
    public void NextPage_1()
    {
        animator.SetBool("Next1", true);
        if (animator.GetBool("IsOpened") && !animator.GetBool("Next2"))
        {
            TitleGroup_2.SetActive(false);
            //animator.SetBool("Next2", false);
            TitleGroup_1.SetActive(true);
            gameObject.GetComponent<MagicCardsController>().MagicCards();
        }
        else
        {
            animator.SetBool("Next1", false);
        }
    }
    public void NextPage_2()
    {
        animator.SetBool("Next2", true);
        if (animator.GetBool("IsOpened") && !animator.GetBool("Next1"))
        {
            TitleGroup_1.SetActive(false);
            //animator.SetBool("Next1", false);
            TitleGroup_2.SetActive(true);
            gameObject.GetComponent<MagicBallController>().MagicBall();
        }
        else
        {
            animator.SetBool("Next2", false);
        }
    }
    public void CloseBook()
    {
        TitleGroup_1.SetActive(false);
        TitleGroup_2.SetActive(false);
        animator.SetBool("Next1", false);
        animator.SetBool("Next2", false);
        animator.SetBool("IsOpened", false);
        animator.SetBool("IsClosed", true);
        animator.SetBool("Idle", true);
        gameObject.GetComponent<MagicBallController>().Completing();
    }
}
