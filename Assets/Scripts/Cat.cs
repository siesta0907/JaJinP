using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    public float speed;
    public Animator animator;

    public CatState myState;
    public AnimationState myAnimationState;

    public void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        myState = CatState.EnterHotel;
        myAnimationState = AnimationState.Walk;
    }

    //�ü�(���� �Ǵ� ����) ������ ������, �ü��� �̵��ϴ� �Լ�
    public void Move(GameObject room)
    {
        //���� ���� �ִٸ�..

        //���� ���� ���� �ʴٸ�...���������ͷ� Ÿ�� �̵��ϰԲ�
    }

    //�ü��� ���ų� ���� �� �θ��� �Լ�
    public void EnterRoom()
    {
        //��� �ü��� �� ������
        //�ü��� isUsing ���� true�� �ٲٱ�
    }

    public void ExitRoom()
    {
        //�ü��� isUsing ���� False�� �ٲٱ�
    }

    
    public void Acting(CatState state)
    {

    }

    public void AnimActing(AnimationState state)
    {
        //�� �ൿ�� �´� �ִϸ��̼��ϰԲ�
    }



}
