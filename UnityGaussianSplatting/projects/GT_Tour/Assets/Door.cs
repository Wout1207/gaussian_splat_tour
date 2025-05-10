using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    public GameObject otherRoom;
    private Light _light;

    private void Start()
    {
        _light = GetComponent<Light>();
    }
    public void renderRoom()
    {
        otherRoom.SetActive(true);
        this.gameObject.SetActive(false);
    }

    private void Update()
    {
        _light.intensity = 5*Mathf.Sin(Time.time*3)+5;
    }
}
