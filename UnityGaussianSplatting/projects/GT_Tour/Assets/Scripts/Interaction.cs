using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteraction : MonoBehaviour
{
    public Camera cameraView;
    public float interactRange = 10f;
    public GameObject UI;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = cameraView.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, interactRange))
            {   
                GameObject item = hit.collider.gameObject;
                Debug.Log("Hit a :" + item.name);
                
                if(item.tag == "Item"){
                    UI.GetComponent<PopUpController>().showInfoScreen(item.GetComponent<Item>().itemData);
                    item.GetComponent<Item>().render.SetActive(true);
                }
                else if(item.tag == "Door"){
                    item.GetComponent<Door>().renderRoom(this.transform);
                }
                }
            }
        }
    }   
