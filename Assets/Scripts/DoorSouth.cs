using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

/// <summary>
/// This class describes a door south.
/// </summary>
public class DoorSouth : MonoBehaviour {
    bool opened_ = false;
    public GameObject TextObject;
    
    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start () {
        Button.openDoorSouth += moveDoorSouth;
    }

    /// <summary>
    /// Function on Pointer Enter
    /// </summary>
    public void InfoDoorSouth () {
        if (TextObject) {
            GameObject text = Instantiate(TextObject);
            text.transform.position = new Vector3(this.gameObject.transform.position.x + 1, this.gameObject.transform.position.y + 1, this.gameObject.transform.position.z);
        }
    }

    /// <summary>
    /// Function on Pointer Click.
    /// </summary>
    public void OpenDoorSouth () {
        opened_ = true;
        Debug.Log("AbrirPuertaSur");
    }
    
    /// <summary>
    /// Closes a door south on pointer exit.
    /// </summary>
    public void CloseDoorSouth () {
        if (opened_) {
            opened_ = false;
            Debug.Log("CerrarPuertaSur");
        }   
    }

    /// <summary>
    /// Opens the south door.
    /// </summary>
    async public void moveDoorSouth () {
        for (int i = 0; i < 4; i++) {
            transform.position = new Vector3(transform.position.x + 0.75f, transform.position.y, transform.position.z);
            await Task.Delay(500);
        }
        await Task.Delay(1000);
        for (int i = 0; i < 4; i++) {
            transform.position = new Vector3(transform.position.x - 0.75f, transform.position.y, transform.position.z);
            await Task.Delay(500);
        }
    }
}
