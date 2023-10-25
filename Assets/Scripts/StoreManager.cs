using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreManager: MonoBehaviour
{
    public GameObject StorePanel;
    public Canvas canvasToCloneTo;
    public Image RoomImage;

    private bool isFollowingMouse;


    public void Start()
    {
        HidePanel();
    }
    public void Update()
    {
        if (isFollowingMouse)
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0;
            RoomImage.transform.position = mousePosition;
        }
    
    }

    public void ShowPanel()
    {
        StorePanel.SetActive(true);
    }

    public void HidePanel()
    { 
        StorePanel.SetActive(false); 
    }

    public void BuyFacility(GameObject facility)
    {
        RoomImage = facility.GetComponent<Image>();
        RoomImage.gameObject.SetActive(true);
        isFollowingMouse = true;
    }

}
