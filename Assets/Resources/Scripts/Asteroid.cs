using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid :MonoBehaviour
{
    // Start is called before the first frame update
    public void Initialize()
    {
        Debug.Log("Asteroid Initialize");
    }

    public void PhysicsRefresh()
    {
        Debug.Log("Asteroid PhysicsReferesh");

    }

    public void PostInitialize()
    {
        Debug.Log("Asteroid PostInitialize");

    }

    public void Refresh()
    {

        Debug.Log("Asteroid Refresh");
    }
}
