using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor {
    // prevate: 외부 클래스에 비공개로 설정하는 접근자
    // public: 외부 클래스에 공개로 설정하는 접근자
    public int id;
    public string name;
    public string title;
    public string weapon;
    public float strength;
    public int level;

    public string Talk()
    {
        return "대화를 걸었습니다.";
    }
    public string HasWeapon()
    {
        return weapon;
    }

    public void LevelUp()
    {
        level = level + 1;
    }
}