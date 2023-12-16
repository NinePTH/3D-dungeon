using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaleCharacter : MonoBehaviour
{
    
    public CharacterList _character;

    void Awake()
    {
        this.transform.localScale = _character.scaleOb;
    }
}
