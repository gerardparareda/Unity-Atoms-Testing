using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

public class AnimatorStateMachineBehaviour : StateMachineBehaviour
{
    public UniTaskCompletionSource<bool> TaskCompletionSource = new();

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        TaskCompletionSource.TrySetResult(true);
        TaskCompletionSource = new UniTaskCompletionSource<bool>();
    }

}
