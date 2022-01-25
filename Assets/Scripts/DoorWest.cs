using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

/// <summary>
/// This class describes a door west.
/// </summary>
public class DoorWest : MonoBehaviour {
    bool opened_ = false;
    public GameObject TextObject;
    
    /// <summary>
    /// Start is called before the first frame update
    /// </summary>    
    void Start () {
        Button.openDoorWest += moveDoorWest;
    }
    
    /// <summary>
    /// Function on Pointer Enter
    /// </summary>
    public void InfoDoorWest () {
        if (TextObject) {
            GameObject text = Instantiate(TextObject);
            text.transform.position = new Vector3(this.gameObject.transform.position.x + 1, this.gameObject.transform.position.y + 1, this.gameObject.transform.position.z - 1);
        }
    }
    
    /// <summary>
    /// Function on Pointer Click.
    /// </summary>
    public void OpenDoorWest () {
        opened_ = true;
        Debug.Log("AbrirPuertaOeste");
    }
    
    /// <summary>
    /// Closes a door west on pointer exit.
    /// </summary>
    public void CloseDoorWest () {
        if (opened_) {
            opened_ = false;
            Debug.Log("CerrarPuertaOeste");
        }
        
    }

    /// <summary>
    /// Opens the west door.
    /// </summary>
    async public void moveDoorWest () {
        for (int i = 0; i < 4; i++) {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 0.75f);
            await Task.Delay(500);
        }
        await Task.Delay(1000);
        for (int i = 0; i < 4; i++) {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.75f);
            await Task.Delay(500);
        }
    }
}
