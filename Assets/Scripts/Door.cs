using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Door : MonoBehaviour {
    bool opened_ = false;
    public GameObject TextObject;
    
    // Start is called before the first frame update
    void Start () {
        Button.openDoorNorth += moveDoorNorth;
        Button.openDoorSouth += moveDoorSouth;
        Button.openDoorEast += moveDoorEast;
        Button.openDoorWest += moveDoorWest;
    }
    
    // Update is called once per frame
    void Update () {
        // Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        // Debug.DrawRay(transform.position, forward, Color.green);
    }

    /*=====================================
    =            Pointer Enter            =
    =====================================*/
    
    public void InfoDoorNorth () {
        if (TextObject) {
            GameObject text = Instantiate(TextObject);
            text.transform.position = new Vector3(this.gameObject.transform.position.x - 1, this.gameObject.transform.position.y + 1, this.gameObject.transform.position.z);
        }
        Debug.Log("Next room: ...");
    }

    public void InfoDoorSouth () {
        if (TextObject) {
            GameObject text = Instantiate(TextObject);
            text.transform.position = new Vector3(this.gameObject.transform.position.x + 1, this.gameObject.transform.position.y + 1, this.gameObject.transform.position.z);
        }
        Debug.Log("Next room: ...");
    }

    public void InfoDoorWest () {
        if (TextObject) {
            GameObject text = Instantiate(TextObject);
            text.transform.position = new Vector3(this.gameObject.transform.position.x + 1, this.gameObject.transform.position.y + 1, this.gameObject.transform.position.z - 1);
        }
        Debug.Log("Next room: ...");
    }

    public void InfoDoorEast () {
        if (TextObject) {
            GameObject text = Instantiate(TextObject);
            text.transform.position = new Vector3(this.gameObject.transform.position.x + 1, this.gameObject.transform.position.y + 1, this.gameObject.transform.position.z + 1);
        }
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
        

    public void moveDoorNorth () {
        // Debug.Log(this.gameObject.name);
        for (int i = 0; i < 10; i++) {
            transform.position = new Vector3(transform.position.x + 0.2f, transform.position.y, transform.position.z);
            System.Threading.Thread.Sleep(10);
        }
        
        Debug.Log("N");
    }
    public void moveDoorSouth () {
        // Debug.Log(this.gameObject.name);
        Debug.Log("S");
    }
    public void moveDoorEast () {
        // Debug.Log(this.gameObject.name);
        Debug.Log("E");
    }
    public void moveDoorWest () {
        // Debug.Log(this.gameObject.name);
        Debug.Log("O");
    }
}
