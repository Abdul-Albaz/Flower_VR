using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class SlectiveSocketBehavior : XRSocketInteractor
{
    [SerializeField] XRBaseInteractable targetObject;
    

    public override bool CanHover(IXRHoverInteractable interactable)
    {
        return base.CanHover(interactable) && MatchingInteractable(interactable.transform.GetComponent<XRBaseInteractable>());
    }

    public override bool CanSelect(IXRSelectInteractable interactable)
    {
        return base.CanSelect(interactable) && MatchingInteractable(interactable.transform.GetComponent<XRBaseInteractable>());
    }
    private bool MatchingInteractable(XRBaseInteractable interactable) => targetObject.gameObject == interactable.gameObject;
}
