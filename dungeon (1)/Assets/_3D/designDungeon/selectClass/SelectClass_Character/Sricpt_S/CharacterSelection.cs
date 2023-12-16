using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelection : MonoBehaviour
{
    [Header("Upload Characters")]
    [SerializeField] private GameObject[] charactersPrefab;
    [SerializeField] private CharacterList[] characters; 
    [Header("Upload Script")]
    [SerializeField] private CharacterDisplay _characterdisplay; // Form script CharacterDisplay.cs
    //[SerializeField] private CharacterDisplay _characterDisplay;
    [SerializeField] private changingScene _changingScene;
    [SerializeField] public controlAnimation controlAnim;
    void Start()
    {
        var chId = 0;
        _characterdisplay.DisplayCharacter(characters[chId], charactersPrefab[chId]);
        _changingScene.Enviroment(characters[chId]);
        //controlAnim.isClassSelection = true;
        
    }

    public void ShowCharacterWar()
    {
        var chId = 0; 
        _characterdisplay.DisplayCharacter(characters[chId], charactersPrefab[chId]);
        _changingScene.Enviroment(characters[chId]);
    }
    public void ShowCharacterMage()
    {
        var chId = 1;
        _characterdisplay.DisplayCharacter(characters[chId], charactersPrefab[chId]);
        _changingScene.Enviroment(characters[chId]);
    }
    public void ShowCharacterArc()
    {
        var chId = 2;
        _characterdisplay.DisplayCharacter(characters[chId], charactersPrefab[chId]);
        _changingScene.Enviroment(characters[chId]);
    }
    
    
}
