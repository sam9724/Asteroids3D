using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidManager 
{
    public static AsteroidManager Instance
    {
        get
        {
            if (instance == null)
                instance = new AsteroidManager();
            return instance;
        }
    }
    private static AsteroidManager instance;
    private AsteroidManager() { }

    Asteroid asteroid;

    public void Initialize()
    {
        Debug.Log("Asteroid Manager Initialize");
        GameObject asteroidObj = GameObject.Instantiate(Resources.Load<GameObject>("Prefabs/Asteroids"));
        asteroid = asteroidObj.GetComponent<Asteroid>();
        //player.transform.position
        asteroid.Initialize();
        
    }

    public void PhysicsRefresh()
    {
        Debug.Log("Asteroid Manager PhysicsReferesh");
        asteroid.PhysicsRefresh();
    }

    public void PostInitialize()
    {
        Debug.Log("Asteroid Manager PostInitialize");
        asteroid.PostInitialize();
    }

    public void Refresh()
    {

        Debug.Log("Asteroid Manager Refresh");
        asteroid.Refresh();
    }
}
