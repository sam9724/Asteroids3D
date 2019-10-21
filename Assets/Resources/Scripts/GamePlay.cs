using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay 
{
    #region singleton
    // Start is called before the first frame update
    public static GamePlay Instance
    {
        get
        {
            if (instance == null)
                instance = new GamePlay();
            return instance;
        }
    }
    #endregion
    private static GamePlay instance;
    public void Initialize()
    {
        PlayerManager.Instance.Initialize();
        AsteroidManager.Instance.Initialize();
    }

    public void PhysicsRefresh()
    {
        PlayerManager.Instance.PhysicsRefresh();
        AsteroidManager.Instance.PhysicsRefresh();
    }

    public void PostInitialize()
    {
        PlayerManager.Instance.PostInitialize();
        AsteroidManager.Instance.PostInitialize();
    }

    public void Refresh()
    {
        PlayerManager.Instance.Refresh();
        AsteroidManager.Instance.Refresh();
    }


}
