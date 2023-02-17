
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;
using VRC.Udon;

[RequireComponent(typeof(Button))]
public class WhitelistedUIButton : UdonSharpBehaviour
{
    [SerializeField] SimpleWhitelist whitelist;
    [Tooltip("Make button interactable or not if whitelisted.")]
    [SerializeField] bool interactableWhenWhitelisted = true;
    Button button;
    
    void Start()
    {
        button = GetComponent<Button>();
        
        bool onList = whitelist.IsLocalWhitelisted();
        if (interactableWhenWhitelisted)
            button.interactable = onList;
        else
            button.interactable = !onList;
    }
}
