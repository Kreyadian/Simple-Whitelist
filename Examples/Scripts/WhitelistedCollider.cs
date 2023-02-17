
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

[RequireComponent(typeof(Collider))]
public class WhitelistedCollider : UdonSharpBehaviour
{
    [SerializeField] SimpleWhitelist whitelist;
    [Tooltip("Turn the collider on or off if whitelisted.")]
    [SerializeField] bool acitveWhenWhitelisted = false;
    Collider coll;
    
    void Start()
    {
        coll = GetComponent<Collider>();

        bool onList = whitelist.IsLocalWhitelisted();
        if (acitveWhenWhitelisted)
            coll.enabled = onList;
        else
            coll.enabled = !onList;
    }
}
