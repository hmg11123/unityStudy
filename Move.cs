using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{   
    Vector3 target = new Vector3(0.04f, 1.5f, 3.71f);

    void Update() {

        // 1. MoveTowards
        // MoveTowards: 등속이동
        // MoveTowards(현재위치, 목표위치, 속도)
        transform.position = 
            Vector3.MoveTowards(transform.position, target, 1f);

        
        // 2. SmoothDamp
        // SmoothDamp: 부드러운 감속 이동
        // SmoothDamp(현재위치, 목표위치, 참조 속도, 속도)
        Vector3 velo = Vector3.up * 50f;
        transform.position = 
            Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f);
        // ref: 참조 접근 -> 실시간으로 바뀌는 값 적용 가능
        

        // 3. Lerp
        // Lefp: 선형 보간, SmoothDamp보다 감속 시간이 김
        // Lefp(현재위치, 목표위치, 속도)
        // 속도 최대값 0~1;
        transform.position = 
            Vector3.Lerp(transform.position, target, 0.05f);

        // 4. Slerp
        // Slerp: 구면 선형 보간, 호를 그리며 이동 or 포물선 이동
        // Slefp(현재위치, 목표위치, 속도)
        transform.position = 
            Vector3.Slerp(transform.position, target, 0.05f);
    }

}
