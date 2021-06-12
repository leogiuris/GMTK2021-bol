using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum HandMode
{
    Palm = 0,
    FistBump = 1,
    Holding = 2
}


public class Hand : MonoBehaviour
{
    public List<GameObject> hands;
    
    public int strengh;
    public HandMode hm;
    private int hmIndex;

    public void ChangeHandMode()
    {
        hands[hmIndex].SetActive(false);
        hmIndex = (hmIndex+1) % 3;
        hm = (HandMode)hmIndex;

        hands[hmIndex].SetActive(true);
        //Debug.Log("change hand mode" + hm.ToString());
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

        hmIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (GameController.canHold)
            Debug.Log("pode apertar");
    }
}
