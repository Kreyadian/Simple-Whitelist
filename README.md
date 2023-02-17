# Simple Whitelist

### [Download on Booth](https://krey.booth.pm/items/4473616)

Simple Whitelist is exactly what it sounds like, a simple whitelist system that allows you to quickly set up items, menus, and areas restricted to a pre-set list of players.

I originally made this just for my own use but figured I might as well polish it up and share it, so here we are!

Real-time editing of the whitelist isn't currently supported but is planned. For now, all included examples
check the whitelist when the world is initially loaded and it's recommended any scrips you write using this asset do the same.

## Features
- Simple and lightweight code that minimizes performance impact.
- Many included example scripts to cover the most common use cases.
- Easy to expand through your own scripts for more niche use cases. Simply refrence the Whitelist prefab and call `IsLocalWhitelisted()` in your own script!

## Included Examples
- Whitelisted Collider
- Whitelisted Object
- Whitelisted Interactable
- Whitelisted Pickup
- Whitelisted UI Button
- Whitelisted UI Slider

## Requirements
- VRChat SKD 3.0
- Udon Sharp

## Setup
1. Drag the Whitelist prefab into your scene
2. Add the VRchat usernames of the players you would like to whitelist to the prefab (it's recomended to copy the usernames directly from vrchat.com to ensure it matches exacly)
3. Add one of the included example scripts to the object you would like to whitelist and assign the whitelist prefab to the script
