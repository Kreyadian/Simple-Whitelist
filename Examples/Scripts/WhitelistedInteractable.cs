
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class WhitelistedInteractable : UdonSharpBehaviour
{
    [SerializeField] SimpleWhitelist whitelist;
    [Tooltip("Make object interactable or not if whitelisted.")]
    [SerializeField] UdonBehaviour interactableScript;
    [SerializeField] bool interactableWhenWhitelisted = true;
    
    void Start()
    {
        bool onList = whitelist.IsLocalWhitelisted();
        if (interactableWhenWhitelisted)
            interactableScript.DisableInteractive = !onList;
        else
            interactableScript.DisableInteractive = onList;
    }
}
