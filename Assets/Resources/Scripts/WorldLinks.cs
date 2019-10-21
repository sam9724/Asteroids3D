using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldLinks : MonoBehaviour
{
    // Start is called before the first frame update
    private static WorldLinks instance;
    public static WorldLinks Instance { get { return instance ?? (instance = GameObject.FindObjectOfType<WorldLinks>()); } }

    public Transform playerStartLocation;
}
