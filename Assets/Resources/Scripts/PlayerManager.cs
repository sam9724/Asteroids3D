using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager
{
    public Player player { set; get; }
    // Start is called before the first frame update
    public static PlayerManager Instance
    {
        get
        {
            if (instance == null)
                instance = new PlayerManager();
            return instance;
        }   
    }
    private static PlayerManager instance;
    private PlayerManager() { }

    

    public void Initialize()
    {
        Debug.Log("Player Manager Initialize");
        GameObject playerObj = GameObject.Instantiate(Resources.Load<GameObject>("Prefabs/SG_radogost"));
        playerObj.transform.position = WorldLinks.Instance.playerStartLocation.position;
        player = playerObj.GetComponent<Player>();
        player.Initialize();
    }

    public void PhysicsRefresh()
    {
        
        Debug.Log("Player Manager PhysicsReferesh");
        player.PhysicsRefresh();
    }

    public void PostInitialize()
    {
        Debug.Log("Player Manager PostInitialize");
        player.PostInitialize();
    }

    public void Refresh()
    {
        
        Debug.Log("Player Manager Refresh");
        player.Refresh();
    }

}
