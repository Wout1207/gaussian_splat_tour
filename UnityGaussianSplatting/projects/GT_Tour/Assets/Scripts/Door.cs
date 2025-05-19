using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    public GameObject otherRoom;
    //public Light _light;

    public void renderRoom()
    {
        otherRoom.SetActive(true);
        this.gameObject.SetActive(false);
    }

/*    private void Update()
    {
        _light.intensity = 5*Mathf.Sin(Time.time*3)+5;
    }*/
}
