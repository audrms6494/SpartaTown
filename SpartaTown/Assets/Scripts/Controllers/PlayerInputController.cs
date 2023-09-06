using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownCharacterController
{
    private Camera _camera;
    // Start is called before the first frame update
    void Start()
    {
        _camera = Camera.main;
    }

    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    public void OnMove2(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>(); // �ٶ󺸴� Camera ������ ���콺 ������ ����
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim); // ���� ���������� ��ȯ
        newAim = (worldPos - (Vector2)transform.position.normalized); // ���������ǰ� �÷��̾� ������ ���͸� ���� Aim ����

        if (newAim.magnitude >= .9f)
        {
            CallLookEvent(newAim);
        }
    }

    public void OnFire(InputValue value)
    {
        Debug.Log("OnFire" + value.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
