using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

/// <summary>
/// This class describes a door east.
/// </summary>
public class DoorEast : MonoBehaviour {
    bool opened_ = false;
    public GameObject TextObject;
    
    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start () {
        Button.openDoorEast += moveDoorEast;
    }

    /// <summary>
    /// Function on Pointer Enter
    /// </summary>
    public void InfoDoorEast () {
        if (TextObject) {
            GameObject text = Instantiate(TextObject);
            text.transform.position = new Vector3(this.gameObject.transform.position.x + 1, this.gameObject.transform.position.y + 1, this.gameObject.transform.position.z + 1);
        }
    }
    
    /// <summary>
    /// Function on Pointer Click.
    /// </summary>
    public void OpenDoorEast () {
        opened_ = true;
        Debug.Log("AbrirPuertaEste");
    }

    /// <summary>
    /// Closes a door east on pointer exit.
    /// </summary>
    public void CloseDoorEast () {
        if (opened_) {
            opened_ = false;
            Debug.Log("CerrarPuertaEste");
        }
        
    }
    
    /// <summary>
    /// Opens the east door.
    /// </summary>
    async public void moveDoorEast () {
        for (int i = 0; i < 4; i++) {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.75f);
            await Task.Delay(500);
        }
        await Task.Delay(1000);
        for (int i = 0; i < 4; i++) {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 0.75f);
            await Task.Delay(500);
        }
    }

}
