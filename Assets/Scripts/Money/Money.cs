using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEditor.Animations;
using UnityEngine;

public class Money : MonoBehaviour
{

    [SerializeField] private IntReference money;
    [SerializeField] private IntVariable playerMoney;
    [SerializeField] private IntConstant initialMoney;
    [SerializeField] private VoidBaseEventReference endAnimationEvent;
    [SerializeField] private Animator moneyAnimator;
    private static readonly int StartPickup = Animator.StringToHash("StartPickup");

    public int Value   // property
    {
      get { return money.Value; }   // get method
    }
    
    // Start is called before the first frame update
    void Start()
    {
        money.Value = initialMoney.Value;
    }

    public void AugmentPlayerMoney()
    {
        playerMoney.Value += money.Value;
    }
    
    public void DestroySelf()
    {
        Destroy(gameObject);
    }
    
    public async void StartPickupAnimation()
    {
        moneyAnimator.SetTrigger(StartPickup);
        await moneyAnimator.GetBehaviour<AnimatorStateMachineBehaviour>().TaskCompletionSource.Task;
        EndPickupAnimation();
    }

    public void EndPickupAnimation()
    {
        endAnimationEvent.GetEvent<VoidEvent>().Raise();
    }

}
