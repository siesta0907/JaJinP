using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    public GameObject GuestRoomPrefab;
    public GameObject RestaurantPrefab;
    public GameObject facility;

    //�ü��� ������ ��, �巡�� ������� ��ġ�ϰ� Ȯ����ư�� ������ �ü��� ��ġ�� ��. 

    public void makeRoom(Room room)
    {
        //Ÿ�Կ� �´� �ü� prefab ����
        switch (room.roomType) 
        {
            case "Guest Room":
                facility = Instantiate(GuestRoomPrefab);
                break;
            case "Restaurant":
                facility = Instantiate(RestaurantPrefab);
                break;
            default: break;
        }
        room.isEditing = false;
        
    }


    //Edit��忡�� �ü��� �����ϸ�, �巡�� ������� ��ġ�ϰ� Ȯ����ư�� ������ �ü��� �̵� ��ġ��.
    public void EditRoom(Room room)
    {
        room.isEditing = true;
        arrangeRoom(room);

    }

    //�巡�� ������� ��ġ�ϰ� Ȯ����ư�� ������ �ü��� �̵� ��ġ
    public void arrangeRoom(Room room)
    {
        //���� ���� num�� Ȯ����
    }


    //�ü��� �����ϸ�, �����Ͻðڽ��ϱ�? ��� �˾��� �߰� ������ ��
    public void DeleteRoom(Room room)
    {
        //�˾� ����
        //�ü� �����ϱ�
    }


}
