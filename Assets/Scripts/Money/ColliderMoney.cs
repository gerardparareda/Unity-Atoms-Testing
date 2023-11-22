using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityAtoms.BaseAtoms;
using UnityEditor.UI;
using UnityEngine;

[CreateAssetMenu(menuName = "Unity Atoms/Actions/Examples/Money")]
public class CollidedMoney : ColliderAction
{
    [SerializeField] private IntReference money;
    
    public override void Do(Collider other)
    {
        if (other.CompareTag("Money"))
        {
            other.gameObject.GetComponent<Money>().StartPickupAnimation();
        }
    }
}
