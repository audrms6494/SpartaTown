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
        Vector2 newAim = value.Get<Vector2>(); // 바라보는 Camera 기준의 마우스 포지션 추출
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim); // 월드 포지션으로 변환
        newAim = (worldPos - (Vector2)transform.position.normalized); // 월드포지션과 플레이어 사이의 벡터를 통해 Aim 추출

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
