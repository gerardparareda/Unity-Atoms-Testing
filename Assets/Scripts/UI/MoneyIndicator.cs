using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityAtoms.BaseAtoms;

public class MoneyIndicator : MonoBehaviour
{
    private TextMeshPro _textMeshPro;

    // Update is called once per frame
    void Start()
    {
        _textMeshPro = GetComponent<TextMeshPro>();
    }

    public void ChangeMoneyAmount(int amount)
    {
        _textMeshPro.text = amount.ToString() + "€";
    }
}
