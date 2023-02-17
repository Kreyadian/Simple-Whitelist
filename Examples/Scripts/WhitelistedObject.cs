
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class WhitelistedObject : UdonSharpBehaviour
{
    [SerializeField] SimpleWhitelist whitelist;
    [Tooltip("Turn the object on or off if whitelisted.")]
    [SerializeField] bool activeWhenWhitelisted = true;
    
    void Start()
    {
        bool onList = whitelist.IsLocalWhitelisted();
        if (activeWhenWhitelisted)
            gameObject.SetActive(onList);
        else
            gameObject.SetActive(!onList);
    }
}
