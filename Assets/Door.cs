using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {
    bool opened_ = false;
    // Start is called before the first frame update
    void Start () {
        
    }

    // Update is called once per frame
    void Update () {
        
    }

    /*=====================================
    =            Pointer Enter            =
    =====================================*/
    
    public void InfoDoorNorth () {
        Debug.Log("Next room: ...");
    }

    public void InfoDoorSouth () {
        Debug.Log("Next room: ...");
    }

    public void InfoDoorWest () {
        Debug.Log("Next room: ...");
    }

    public void InfoDoorEast () {
        Debug.Log("Next room: ...");
    }
    
    /*=====  End of Pointer Enter  ======*/
    
    
    /*=====================================
    =            Pointer Click            =
    =====================================*/
    
    public void OpenDoorNorth () {
        opened_ = true;
        Debug.Log("AbrirPuertaNorte");
    }

    public void OpenDoorSouth () {
        opened_ = true;
        Debug.Log("AbrirPuertaSur");
    }

    public void OpenDoorWest () {
        opened_ = true;
        Debug.Log("AbrirPuertaOeste");
    }

    public void OpenDoorEast () {
        opened_ = true;
        Debug.Log("AbrirPuertaEste");
    }
    
    /*=====  End of Pointer Click  ======*/
    
   
    /*====================================
    =            Pointer Exit            =
    ====================================*/
    
    public void CloseDoorNorth () {
        if (opened_) {
            opened_ = false;
            Debug.Log("CerrarPuertaNorte");
        }
        
    }

    public void CloseDoorSouth () {
        if (opened_) {
            opened_ = false;
            Debug.Log("CerrarPuertaSur");
        }
        
    }

    public void CloseDoorWest () {
        if (opened_) {
            opened_ = false;
            Debug.Log("CerrarPuertaOeste");
        }
        
    }

    public void CloseDoorEast () {
        if (opened_) {
            opened_ = false;
            Debug.Log("CerrarPuertaEste");
        }
        
    }
    
    /*=====  End of Pointer Exit  ======*/
        
}
