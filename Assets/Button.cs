using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {
    bool opened_ = false;
    // Start is called before the first frame update
    void Start () {
        
    }

    // Update is called once per frame
    void Update (){
        
    }

    /*=====================================
    =            Pointer Enter            =
    =====================================*/
    
    public void InfoButtonNorth () {
        Debug.Log("Button for Next room: ...");
    }

    public void InfoButtonSouth () {
        Debug.Log("Button for Next room: ...");
    }

    public void InfoButtonWest () {
        Debug.Log("Button for Next room: ...");
    }

    public void InfoButtonEast () {
        Debug.Log("Button for Next room: ...");
    }
    
    /*=====  End of Pointer Enter  ======*/
    
    
    /*=====================================
    =            Pointer Click            =
    =====================================*/
    
    public void ClickButtonNorth () {
        opened_ = true;
        Debug.Log("ClickBotonNorte");
    }

    public void ClickButtonSouth () {
        opened_ = true;
        Debug.Log("ClickBotonSur");
    }

    public void ClickButtonWest () {
        opened_ = true;
        Debug.Log("ClickBotonOeste");
    }

    public void ClickButtonEast () {
        opened_ = true;
        Debug.Log("ClickBotonEste");
    }
    
    /*=====  End of Pointer Click  ======*/
    
   
    /*====================================
    =            Pointer Exit            =
    ====================================*/
    
    public void CloseButtonNorth () {
        if (opened_) {
            opened_ = false;
            Debug.Log("FinBotonNorte");
        }
        
    }

    public void CloseButtonSouth () {
        if (opened_) {
            opened_ = false;
            Debug.Log("FinBotonSur");
        }
        
    }

    public void CloseButtonWest () {
        if (opened_) {
            opened_ = false;
            Debug.Log("FinBotonOeste");
        }
        
    }

    public void CloseButtonEast () {
        if (opened_) {
            opened_ = false;
            Debug.Log("FinBotonEste");
        }
        
    }
    
    /*=====  End of Pointer Exit  ======*/
}
