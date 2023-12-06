using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

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
        TitleGroup_2.SetActive(false);
        animator.SetBool("Next2", false);
        animator.SetBool("Next1", true);
        TitleGroup_1.SetActive(true);

    }
    public void NextPage_2()
    {
        TitleGroup_1.SetActive(false);
        animator.SetBool("Next1", false);
        animator.SetBool("Next2", true);
        TitleGroup_2.SetActive(true);
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
    }
}
