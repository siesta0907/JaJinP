using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    public bool isEditing;

    //�ü��� ������ ��, �巡�� ������� ��ġ�ϰ� Ȯ����ư�� ������ �ü��� ��ġ�� ��. 

    public void makeRoom(Room room)
    {
        isEditing = false;
        arrangeRoom(room);
    }


    //Edit��忡�� �ü��� �����ϸ�, �巡�� ������� ��ġ�ϰ� Ȯ����ư�� ������ �ü��� �̵� ��ġ��.
    public void EditRoom(Room room)
    {
        isEditing = true;
        arrangeRoom(room);

    }

    //�巡�� ������� ��ġ�ϰ� Ȯ����ư�� ������ �ü��� �̵� ��ġ
    public void arrangeRoom(Room room)
    {
        //���� ���� num�� Ȯ����
    }


    //�ü��� �����ϸ�, �����Ͻðڽ��ϱ�? ��� �˾��� �߰� ������ ��
    public void DeleteRoom()
    {

    }


}
