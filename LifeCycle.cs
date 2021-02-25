using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    // 실행 순서: 초기화 => 물리영역 => 게임 로직 업데이트 => 헤체
    // 활성화: 초기화와 물리영역 사이에서 일어남
    // 비활성화: 게임로직과 헤체영역 사이에서 일어남
    // lifescycle에 대해 나와있는곳
    void Awake () {
        // Awake: 게임 오브젝트 생성할 때, 최초 실행
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }

    void OnEnable() {
        // OnEnable: 게임 오브젝트가 활성화 되었을 때 실행 됨
        Debug.Log("플레이어가 로그인했습니다.");
    }

    void Start () {
        // Start: 업데이트 시작 직전, 최초 실행
        Debug.Log("사냥 장비를 챙겼습니다.");
    }

    void FixedUpdate() {
        // FixedUpdate: 물리 연산을 하기전에 실행되는 업데이트 함수
        // 1초에 50번씩 실행됨
        Debug.Log("이동~");
    }
    
    void Update() {
        // Update: 물리연산에 관련된 로직을 제외한 나머지 주기적으로 변하는 로직을 넣을때 사용하는 함수 입니다.
        // 환경에 따라 실행 주기가 떨어질수 있다
        Debug.Log("몬스터 사냥!!");
    }

    void LateUpdate() {
        // 모든 업데이트가 끝난 후 실행됨
        Debug.Log("경험치 획득.");
    }

    void OnDisable() {
        // OnDisable: 모든 업데이트가 다 끝난후에나 혹은 삭제될때 실행된다.
        // 게임 오브젝트가 비활성화 되었을때 실행됨
        Debug.Log("플레이어가 로그아웃했습니다.");
    }

    void OnDestroy() {
        // OnDestroy: 게임 오브젝트가 삭제될 때 실행됨
        Debug.Log("플레이어 데이터를 해제하였습니다.");
    }



}
