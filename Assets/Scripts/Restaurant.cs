using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restaurant : Room
{
    private void Start()
    {
        roomType = "Restaurant";
        room = gameObject;
    }
}