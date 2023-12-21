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
    [SerializeField] private GameObject _particleSystem;
    private int count;
    private string answer;

    public void MagicBall()
    {
        extraInfoBG.SetActive(true);
        extraInfoUI.text = _text.text;
    }
    public void TellMe()
    {
        //ballAnimator.SetBool("IsLighting", true);
        //title.SetActive(true);
        count = Random.Range(0, 5);
        switch (count)
        {
            case 1:
                answer = "��";
                break;
            case 2:
                answer = "���";
                break;
            case 3:
                answer = "���� ������� �����";
                break;
            case 4:
                answer = "�� ������";
                break;
            default:
                answer = "�������� ��";
                break;

        }
        
        _particleSystem.SetActive(true);
        title.GetComponent<TextMeshPro>().text = answer;
    }
    public void Completing()
    {
        ballAnimator.SetBool("IsLighting", false);
        title.SetActive(false);
        extraInfoBG.SetActive(false);
        extraInfoUI.text = "����� ������ ���������� �� ������ ����� - ������� ���������� �����\r\n��� �������������� � ������ ������ �����������:\r\n1) OPEN - ����� ���������\r\n2) MAGIC CARDS - ��������� ������ ����\r\n3) MAGIC BALL - ��������� ������ ���������� ����\r\n4)CLOSE - ����� ���������";
    }

    public IEnumerator TimeSkip()
    {
        ballAnimator.SetBool("IsLighting", true);
        title.SetActive(true);
        yield return new WaitForSeconds(7);
        TellMe();
    }
    public void TellMe2()
    {
        StartCoroutine(TimeSkip());
    }
}
