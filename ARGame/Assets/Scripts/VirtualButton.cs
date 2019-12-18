using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButton : MonoBehaviour, IVirtualButtonEventHandler {
    public VirtualButtonBehaviour[] actions;
    public Animator animator;

    void Start() {
        actions = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < actions.Length; i++) {
            actions[i].RegisterEventHandler(this);
        }
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb) {
        animator.SetTrigger("Launch");
        animator.ResetTrigger("Idle");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb) {
        animator.SetTrigger("Idle");
        animator.ResetTrigger("Launch");
    }
}