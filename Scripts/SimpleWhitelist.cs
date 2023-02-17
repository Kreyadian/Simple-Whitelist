
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class SimpleWhitelist : UdonSharpBehaviour
{
    [Tooltip("Place the usernames of whitelisted players here.")]
    public string[] whitelist;
    
    VRCPlayerApi localPlayer => Networking.LocalPlayer;

    public bool IsLocalWhitelisted() => IsPlayerWhitelisted(localPlayer);
    
    public bool IsPlayerWhitelisted(VRCPlayerApi player)
    {
        foreach(string username in whitelist)
        {
            if (player.displayName == username)
            {
                return true;
            }
        }
        return false;
    }

}
