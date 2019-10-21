using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainEntry : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        GamePlay.Instance.Initialize();
    }

    void Start()
    {
        GamePlay.Instance.Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        GamePlay.Instance.Refresh();
    }

    void FixedUpdate()
    {
        GamePlay.Instance.PhysicsRefresh();
    }
}
