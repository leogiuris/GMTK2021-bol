using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum HandMode
{
    Palm = 1,
    FistBump = 2,
    Holding = 3

}


public class Hand : MonoBehaviour
{
    public Transform t;
    public int strengh;
    public HandMode hm;
    

    public void ChangeHandMode(HandMode hm)
    {
        Debug.Log("change hand mode");
    }

    public bool Hold()
    {
        return hm == HandMode.Palm;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        GameController.canHold = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        GameController.canHold = false;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.canHold)
            Debug.Log("pode apertar");
    }
}
