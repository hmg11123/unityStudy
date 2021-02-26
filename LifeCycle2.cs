using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle2 : MonoBehaviour
{   
    void Update() {
        // 마우스와 키보드에 한에서 작동이 되는 애들 ====================================
        
        // Input: 게임 내 입력을 관리하는 클래스 
        // 입력방식들: 눌렀을때, 꾹 누르고 있을때, 누르고 땠을때
        // 리턴값 boolean
        // 예: 마우스클릭, 키보드클릭
        if(Input.anyKeyDown) {
            // anyKeyDown: 아무 입력을 최초로 받을 때 true
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");
        }

        if(Input.anyKey) {
            // anyKey: 아무 입력을 받으면 true
            Debug.Log("플레이어가 아무 키를 누르고 있습니다..");
        }


        // GetKey: 키보드 입력을 받으면 true
        if(Input.GetKeyDown(KeyCode.Return))
            Debug.Log("아이템을 구입하였습니다.");
            // enter = Return

        if(Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("왼쪽으로 이동중.");

        if(Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("오른쪽 이동을 멈추었습니다.");

        
        // GetMouse: 마수으 버튼 입력을 받으면 true
        if(Input.GetMouseButtonDown(0))
            Debug.Log("미사일 발사!");
        // 0은 마우스 왼쪽 버튼
        // 1은 마우스 오른쪽 버튼
        if(Input.GetMouseButton(0))
            Debug.Log("미사일 모으는 중 ...");

        if(Input.GetMouseButtonUp(0))
            Debug.Log("슈퍼 미사일 발사!!");

        // ========================================================================



        // unity Hub에 Edit을 누른다 => project setting에 들어간다 => input Manger에 들어간다 => Axes를 누르면 사용 가능한 기능들이 나온다
        // => 거기서 name으로 사용 가능하다( props로 넘겨주면 됨 )
        // GetButton: Input 버튼 입력을 받으면 true
        
        if(Input.GetButtonDown("Jump"))
            Debug.Log("점프!");
        
        if(Input.GetButton("Jump"))
            Debug.Log("점프 모으는 중...");
        
        if(Input.GetButtonUp("Jump"))
            Debug.Log("슈퍼 점프!!");

        // ========================================================================


        // GetAxis는 중간 값이 있고 (섬세하게 움직임)
        // GetAxisRaw은 중간 값이 없다 (조금 섬세하게 움직임?)



        if(Input.GetButton("Horizontal")){
            Debug.Log("횡 이동 중..." + Input.GetAxis("Horizontal"));
            // GetAxis: 수평, 수직 버튼 입력을 받으면 float
        }

        if(Input.GetButton("Horizontal")){
            Debug.Log("횡 이동 중..." + Input.GetAxisRaw("Horizontal"));
            // 오브젝트는 변수 transform을 항상 가지고 있음
            // Horizontal은 방향이 좌우가 기본
        }

        if(Input.GetButton("Vertical")){
            Debug.Log("종 이동 중..." + Input.GetAxisRaw("Vertical"));
            // Vertical은 방향이 위 아래가 기본
        }

        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        transform.Translate(vec);
        // ========================================================================
    }

    void Start() {
        // *********** 오브젝트는 변수 transform을 항상 가지고 있음 ***********
        // *********** transform: 오브젝트 형태에 대한 기본 컴포넌트 ***********
        // 오브젝트와 transform은 1 : 1관계다 

        // transform.Translate("Vector3");
        // Translate: Vector 값을 현재 위치에 더하는 함수
        // Vector1: 1차원
        // Vector2: 2차원
        // Vector3: 3차원
        // Vector: 방향과 그 크기의 값

        int number = 4; // 스칼라 값
        Vector3 vec = new Vector3(0, 0, 0) // Vector 값
        Vector3(x축의 값, y축의 값, z축의 값)

        Vector3 vec = new Vector3(5, 0, 0);
        transform.Translate(vec);
    }

}
