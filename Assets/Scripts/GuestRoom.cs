using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuestRoom : Room
{
    private void Start()
    {
        roomType = "Guest Room";
        room = gameObject;
    }
}
