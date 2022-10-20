using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//사용자 입력에 따라 플레이어 캐릭터를 움직이는 스크립트
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; //앞 뒤 움직임의 속도
    public float rotateSpeed = 180f;//좌우 회전 속도

    private PlayerInput playerInput; //플레이어 입력을 알려주는 컴포넌트

    private Rigidbody playerRigidbody; //플레이어 캐릭터의 리지드바디
    private Animator playerAnimator; //플레이어 캐릭터의 에니메이터
    
    void Start()
    {   //사용할 컴포넌트들의 참조 가져오기
        
    }

}
