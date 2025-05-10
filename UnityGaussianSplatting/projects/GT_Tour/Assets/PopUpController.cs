using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;

public class PopUpController : MonoBehaviour
{

    public GameObject popUp;
    public GameObject nameText;
    public GameObject descriptionText;
    public GameObject objectImage;
    public GameObject firstPersonController;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showInfoScreen(ItemData item){
        popUp.SetActive(true);
        firstPersonController.GetComponent<FirstPersonController>().playerCanMove = false;
        firstPersonController.GetComponent<FirstPersonController>().cameraCanMove = false;
        Cursor.lockState = CursorLockMode.Confined;

        nameText.GetComponent<TMP_Text>().text = item.name;
        descriptionText.GetComponent<TMP_Text>().text = item.description;
        objectImage.GetComponent<RawImage>().texture = item.model;
    }
    
    public void closeInfoScreen(){
        popUp.SetActive(false);
        firstPersonController.GetComponent<FirstPersonController>().playerCanMove = true;
        firstPersonController.GetComponent<FirstPersonController>().cameraCanMove = true;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
