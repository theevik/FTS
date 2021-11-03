using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openthedoor : MonoBehaviour
{

    public GameObject door; 
   
   public void openDoor()
    {
        Debug.Log("idk man");

        door.SetActive(false);
    }
}
