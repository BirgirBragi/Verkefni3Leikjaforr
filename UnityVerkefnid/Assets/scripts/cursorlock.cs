using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorlock : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = true;//músin gerð sýnileg
        Cursor.lockState = CursorLockMode.None;//músin stillt þannig að hægt sé að hreyfa hana
        
    }
}
