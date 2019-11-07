using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{

    [Header("對話")]

    public string Say = "";

    public float SaySpeed;

    [Header("任務")]

    public bool Complete = false;

    public int BateryFinish;

    public int Batery;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

