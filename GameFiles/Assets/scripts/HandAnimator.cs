using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnimator : MonoBehaviour{
  [SerializeField] private InputActionProperty tiggerAction;
  [SerializeField] private InputActionProperty gripAction;

  private Animator anim;

  private void Start(){
    anim = GetComponent<Animator>();
  }

  private void Update(){
    float triggerValue = tiggerAction.action.ReadValue<float>();
    float gripValue = gripAction.action.ReadValue<float>();

    anim.SetFloat("Trigger", triggerValue);
    anim.SetFloat("Grip", gripValue);
  }
}
