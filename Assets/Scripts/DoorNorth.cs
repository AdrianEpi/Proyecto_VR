using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

/// <summary>
/// This class describes a door north.
/// </summary>
public class DoorNorth : MonoBehaviour {
    bool opened_ = false;
    public GameObject TextObject;
    
    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start () {
        Button.openDoorNorth += moveDoorNorth;
    }
    
    /// <summary>
    /// Function on Pointer Enter
    /// </summary>
    public void InfoDoorNorth () {
        if (TextObject) {
            GameObject text = Instantiate(TextObject);
            text.transform.position = new Vector3(this.gameObject.transform.position.x - 1, this.gameObject.transform.position.y + 1, this.gameObject.transform.position.z);
        }
    }
    
    /// <summary>
    /// Function on Pointer Click.
    /// </summary>
    public void OpenDoorNorth () {
        opened_ = true;
        Debug.Log("AbrirPuertaNorte");
    }
    
    /// <summary>
    /// Closes a door north on pointer exit.
    /// </summary>
    public void CloseDoorNorth () {
        if (opened_) {
            opened_ = false;
            Debug.Log("CerrarPuertaNorte");
        } 
    }
        
    /// <summary>
    /// Opens the north door.
    /// </summary>
    async public void moveDoorNorth () {
        for (int i = 0; i < 4; i++) {
            transform.position = new Vector3(transform.position.x - 0.75f, transform.position.y, transform.position.z);
            await Task.Delay(500);
        }
        await Task.Delay(1000);
        for (int i = 0; i < 4; i++) {
            transform.position = new Vector3(transform.position.x + 0.75f, transform.position.y, transform.position.z);
            await Task.Delay(500);
        }
    }
}
