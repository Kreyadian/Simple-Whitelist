
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;
using VRC.Udon;

[RequireComponent(typeof(Slider))]
public class WhitelistedUISlider : UdonSharpBehaviour
{
    [SerializeField] SimpleWhitelist whitelist;
    [Tooltip("Make slider interactable or not if whitelisted.")]
    [SerializeField] bool interactableWhenWhitelisted = true;
    Slider slider;
    
    void Start()
    {
        slider = GetComponent<Slider>();
        
        bool onList = whitelist.IsLocalWhitelisted();
        if (interactableWhenWhitelisted)
            slider.interactable = onList;
        else
            slider.interactable = !onList;
    }
}
