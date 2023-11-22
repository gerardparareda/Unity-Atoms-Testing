using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityAtoms.BaseAtoms;

public class MoneyIndicator : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textMeshPro;
    [SerializeField] private IntReference playerMoney;
    
    public void Start()
    {
        playerMoney.GetEvent<IntEvent>().Register(ChangeMoneyAmount);
        playerMoney.GetEvent<IntEvent>().Register(ChangeMoneyAmount);
        ChangeMoneyAmount(playerMoney.Value);
    }

    public void ChangeMoneyAmount(int amount)
    {
        textMeshPro.text = amount + "€";
    }

}
