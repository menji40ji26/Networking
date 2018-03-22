# Networking
Networking (Making a multi-player game in Unity3D)

Step 1 
Create a Network Manager game object with Network Manager component attached. 

Step 2 
On the player object, adding "if(!isLocalPlayer) return;" to disable the scripts that you don't want to be called by the   others. On the top, add "using UnityEngine.Networking;" and change the MonoBehaviour to NetworkBehaviour. 

Step 3 
Add a Network Identity component to the player. Check the Local player authority option. Then drag the player prefab to the slot of the Network Manager.

Step 4 
Put your spawnable objects into the Registered Spawnable Prefabs slots of the Network Manager.

Step 5 
On your spawn function, add [Command] on its top and add the "Cmd" prefix to your function's name.

Step 6 
Add [SyncVar] on top of the varieties that you want to Synchronize to the server.

This is the basic framework I have discovered so far. Still testing and debugging on my project.
