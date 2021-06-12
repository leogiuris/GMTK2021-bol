using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private static GameController _instance;
    public static GameController Instance { get { return _instance; } }
    private float time;
    public Hand playerHand, cpuHand;
    public Player p;
    bool handsHolding;
    public int score = 0;
    public static bool canHold;

    // Start is called before the first frame update
    void Start()
    {
        time = Time.time;
        canHold = false;
    }

    // Update is called once per frame
    void Update()
    {
        


    }
}
