using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class WashingMachineBehaviour : MonoBehaviour
{
    [SerializeField] private IntReference washingMachineState;
    [SerializeField] private Animator coverAnimator;
    private static readonly int OpenTrigger = Animator.StringToHash("Open");
    private static readonly int CloseTrigger = Animator.StringToHash("Close");

    public void Interact()
    {
        switch (washingMachineState.Value)
        {
            case 0:
                Open();
                break;
            case 1:
                Close();
                break;
            case 2:
                break;
        }
    }

    public void SetNextState(int nextState)
    {
        washingMachineState.Value = nextState;
    }

    private void Open()
    {
        coverAnimator.SetTrigger(OpenTrigger);
        washingMachineState.Value = 2;
    }
    
    private void Close()
    {
        coverAnimator.SetTrigger(CloseTrigger);
        washingMachineState.Value = 2;
    }
}
