using UnityEngine;
using UnityAtoms.BaseAtoms;

[CreateAssetMenu(menuName = "Unity Atoms/Money Logger")]
public class MoneyLogger : IntAction
{
    public override void Do()
    {
        Debug.Log("Event raised");
    }
}