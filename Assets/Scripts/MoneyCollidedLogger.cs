using UnityEngine;
using UnityAtoms.BaseAtoms;

[CreateAssetMenu(menuName = "Unity Atoms/Money Collided Logger")]
public class MoneyCollidedLogger : IntAction
{
    public override void Do()
    {
        Debug.Log("Event collision raised");
    }
}