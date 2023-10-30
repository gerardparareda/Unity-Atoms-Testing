using System;
using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class AugmentPlayerMoney : ColliderAction
{
    public override void Do(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<PlayerMoney>().Money.Value += 10;
        }
    }
}
