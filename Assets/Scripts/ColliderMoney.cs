using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityAtoms.BaseAtoms;
using UnityEditor.UI;
using UnityEngine;

[CreateAssetMenu(menuName = "Unity Atoms/Examples/Money")]
public class CollidedMoney : ColliderAction
{
    [SerializeField] private IntReference money;
    
    public override void Do(Collider other)
    {
        if (other.CompareTag("Money"))
        {
            money.Value += 10;
            Destroy(other.gameObject);
        }
    }
}
