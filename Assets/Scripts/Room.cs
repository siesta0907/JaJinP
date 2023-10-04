using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Room : MonoBehaviour
{
    protected int roomfloor;
    protected int roomNumber;
    public bool isUsing = false;
    public bool isEditing = false;
    public string roomType;
    protected GameObject room;

    public void Start()
    {
        room = gameObject;
        int index = transform.parent.GetSiblingIndex();
        roomfloor = index;
        index = transform.GetSiblingIndex();
        roomNumber = index;
    }

}
