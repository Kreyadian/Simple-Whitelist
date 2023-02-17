
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

[RequireComponent(typeof(VRC_Pickup))]
public class WhitelistedPickup : UdonSharpBehaviour
{
    [SerializeField] SimpleWhitelist whitelist;
    [Tooltip("Make object pickupable or not if whitelisted.")]
    [SerializeField] bool pickupableWhenWhitelisted = true;
    VRC_Pickup pickup;
    
    void Start()
    {
        pickup = (VRC_Pickup)GetComponent(typeof(VRC_Pickup));

        bool onList = whitelist.IsLocalWhitelisted();
        if (pickupableWhenWhitelisted)
            pickup.pickupable = onList;
        else
            pickup.pickupable = !onList;
    }
}
