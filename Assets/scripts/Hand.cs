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
    public bool amPlayer;
    public int strengh;
    public HandMode hm;
    private int hmIndex;

    private Vector3 init_pos;
    private Quaternion init_rot;

    private void Awake()
    {
        init_pos = this.transform.position;
        init_rot = this.transform.rotation;
    }

    public void Reset()
    {
        this.transform.position = init_pos;
        this.transform.rotation = init_rot;
    }

    public void ChangeHandMode()
    {
        hands[hmIndex].SetActive(false);
        hmIndex = (hmIndex+1) % 3;
        hm = (HandMode)hmIndex;

        hands[hmIndex].SetActive(true);
    }

    public bool Hold()
    {
        return hm == HandMode.Palm;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        GameController.canHold = true;
        if (other.tag == "awkward zone")
        {
            GameController.Instance.handsOn++;
            Debug.Log("awkward");
        }

        //checar se esse script e da mão do player para evitar redundancias
        else if (amPlayer)
        {
            
            //checar se a combinação de mãos esta correta
            if(other.tag == hands[hmIndex].tag)
            {
                Debug.Log("deubom");
                GameController.Instance.Win();
            }
            else
            {
                Debug.Log("deuruim");
                GameController.Instance.Lose();
            }
        }
        
        
        
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
        {
            //Debug.Log("pode apertar");
        }
    }

}
