using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player :MonoBehaviour
{
    // Start is called before the first frame update
    public void Initialize()
    {
        Debug.Log("Player Initialize");

    }

    public void PhysicsRefresh()
    {

        Debug.Log("Player PhysicsReferesh");
    }

    public void PostInitialize()
    {
        Debug.Log("Player PostInitialize");

    }

    public void Refresh()
    {

        Debug.Log("Player Refresh");
    }
}
