using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadCharacter : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private CharacterList[] _loadedcharacter;
    [SerializeField] private Transform spawnPoint;
    [HideInInspector] public GameObject character;
   

    void Awake()
    {
        
        int selectedCharacter = PlayerPrefs.GetInt("CharacterID");
        selectedCharacter -= 1;
        //Debug.Log(selectedCharacter);
        GameObject prefab = _loadedcharacter[selectedCharacter]._character;
        
        GameObject clone = Instantiate(prefab, spawnPoint.position, Quaternion.identity);
        character = clone;

        //character.GetComponent<Character>().enabled = true; // active srcipt "Character.cs"
        

        //get Component controlAnimation(srcipt)
        //controlAnimation cA = character.GetComponent<controlAnimation>();
        //cA.isClassSelection = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
