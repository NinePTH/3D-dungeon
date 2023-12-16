using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RoleScriptableObject", menuName = "ClassesAndCharacter/Character")]
public class CharacterList : ScriptableObject
{
    // Start is called before the first frame update
    public GameObject _character;
    public int characterId;
    public string Name;
    public string _class;
    [Header("Stats")]
    public float Hp;
    public float mp;
    public float CharacterExp;
    public float strength;
    public float defense;
    public float speed;
    public Vector3 scaleOb; //Variable scale of Object
    [Header("Skills")]
    public skills_Scriptable[] skills;
    public ScriptableUI AbilitiesSkill;
    //public float[] damageSkill;
}
