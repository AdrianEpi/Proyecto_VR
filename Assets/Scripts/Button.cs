using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void eventDoorNorth();
public delegate void eventDoorSouth();
public delegate void eventDoorEast();
public delegate void eventDoorWest();


/// <summary>
/// This class describes a button.
/// </summary>
public class Button : MonoBehaviour {
    bool opened_ = false; 
    public static event eventDoorNorth openDoorNorth;
    public static event eventDoorSouth openDoorSouth;
    public static event eventDoorEast openDoorEast;
    public static event eventDoorWest openDoorWest;
    private WumpusGame player_;
    
    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start () {
    }
    
    /// <summary>
    /// Function on Pointer enter for button North.
    /// </summary>
    public void InfoButtonNorth () {
        //Debug.Log("Button for Next room: ...");
    }

    /// <summary>
    /// Function on Pointer enter for button South.
    /// </summary>
    public void InfoButtonSouth () {
        //Debug.Log("Button for Next room: ...");
    }

    /// <summary>
    /// Function on Pointer enter for button West.
    /// </summary>
    public void InfoButtonWest () {
        //Debug.Log("Button for Next room: ...");
    }

    /// <summary>
    /// Function on Pointer enter for button East.
    /// </summary>
    public void InfoButtonEast () {
        //Debug.Log("Button for Next room: ...");
    }
    
    /// <summary>
    /// Function on Pointer click for button North.
    /// </summary>
    public void ClickButtonNorth () {
        opened_ = true;
        openDoorNorth();
        Debug.Log("ClickBotonNorte");
        player_ = GameObject.Find("XRRig").GetComponent<WumpusGame>();
        player_.movePlayer("North");
    }

    /// <summary>
    /// Function on Pointer click for button South.
    /// </summary>
    public void ClickButtonSouth () {
        opened_ = true;
        openDoorSouth();
        Debug.Log("ClickBotonSur");
        player_ = GameObject.Find("XRRig").GetComponent<WumpusGame>();
        player_.movePlayer("South");
    }

    /// <summary>
    /// Function on Pointer click for button West.
    /// </summary>
    public void ClickButtonWest () {
        opened_ = true;
        openDoorWest();
        Debug.Log("ClickBotonOeste");
        player_ = GameObject.Find("XRRig").GetComponent<WumpusGame>();
        player_.movePlayer("West");
    }

    /// <summary>
    /// Function on Pointer click for button East.
    /// </summary>
    public void ClickButtonEast () {
        opened_ = true;
        openDoorEast();
        Debug.Log("ClickBotonEste");
        player_ = GameObject.Find("XRRig").GetComponent<WumpusGame>();
        player_.movePlayer("East");
    }
    
    /// <summary>
    /// Function on pointer close for button north.
    /// </summary>
    public void CloseButtonNorth () {
        if (opened_) {
            opened_ = false;
            //Debug.Log("FinBotonNorte");
        }
    }

    /// <summary>
    /// Function on pointer close for button south.
    /// </summary>
    public void CloseButtonSouth () {
        if (opened_) {
            opened_ = false;
            //Debug.Log("FinBotonSur");
        }
    }

    /// <summary>
    /// Function on pointer close for button west.
    /// </summary>
    public void CloseButtonWest () {
        if (opened_) {
            opened_ = false;
            //Debug.Log("FinBotonOeste");
        }
    }

    /// <summary>
    /// Function on pointer close for button east.
    /// </summary>
    public void CloseButtonEast () {
        if (opened_) {
            opened_ = false;
            //Debug.Log("FinBotonEste");
        }
    }

    /// <summary>
    /// Determines if button clicked.
    /// </summary>
    ///
    /// <returns>True if button clicked, False otherwise.</returns>
    public bool isButtonClicked () {
        if (opened_ == true) {
            Debug.Log("HACE CLICK");
            opened_ = false;
            return true;
        }
        return false;
    }
}
