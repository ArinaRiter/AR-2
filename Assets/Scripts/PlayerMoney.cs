using UnityEngine;
public class PlayerMoney : MonoBehaviour
{
    [SerializeField] private int _moneyAmount;

    public void ProcessBuy(int money)
    {
        if(_moneyAmount - money < 0)
        {
            return;
        }
        _moneyAmount -= money;
    }

    public bool CanBuy(int price)
    {
        if(_moneyAmount - price >= 0)
        {
            return true;
        }
        return false;
    }
}
