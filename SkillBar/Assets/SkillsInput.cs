using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillsInput : MonoBehaviour
{
    public bool EnableSkill { get; set; }
    
    public void UseSkill1(){
        Debug.Log("Skill 1, ATTACK!!!");
    }
}
