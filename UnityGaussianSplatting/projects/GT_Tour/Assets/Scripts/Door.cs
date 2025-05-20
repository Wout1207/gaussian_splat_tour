using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    public GameObject otherRoom;
    //public Light _light;

    public void renderRoom(Transform playerTransform)
    {
        otherRoom.SetActive(true);
        Transform spawnLocation = otherRoom.transform.Find("SpawnLocation");
        playerTransform.position = new Vector3(spawnLocation.position.x, playerTransform.position.y, spawnLocation.position.z);
        playerTransform.Rotate(0,180,0);
        transform.parent.gameObject.SetActive(false);
    }

/*    private void Update()
    {
        _light.intensity = 5*Mathf.Sin(Time.time*3)+5;
    }*/
}
