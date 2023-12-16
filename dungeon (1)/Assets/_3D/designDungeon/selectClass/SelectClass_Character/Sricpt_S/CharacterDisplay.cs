using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class CharacterDisplay : MonoBehaviour
{   [Header("Set point")]
    [SerializeField] private Transform warriorP;
    [SerializeField] private Transform mageP;
    [SerializeField] private Transform archerP;
    // Start is called before the first frame update
    public int idCharacter;
    //UI
    [Header("UI")]
    [SerializeField] private Image characterMp; //UI image
    [SerializeField] private Image characterStrength;
    [SerializeField] private Image characterDefense;
    [SerializeField] private TextMeshProUGUI characterName; //UI Text
    [SerializeField] private TextMeshProUGUI characterClass;
    public void DisplayCharacter(CharacterList _characterList, GameObject chPrefab) //parameter รับ element จาก CharacterSelection.cs
    {
        //destroy character
        if(warriorP.childCount > 0 && _characterList.characterId == 1)
        {
            Destroy(warriorP.GetChild(0).gameObject);

        }else if (warriorP.childCount > 0 && _characterList.characterId != 1){
            Destroy(warriorP.GetChild(0).gameObject);
        }
        
        
        if (mageP.childCount > 0 &&  _characterList.characterId == 2)
        {
            Destroy(mageP.GetChild(0).gameObject);
        }
        else if (mageP.childCount > 0 && _characterList.characterId != 2)
        {
            Destroy(mageP.GetChild(0).gameObject);
        }

        if (archerP.childCount > 0 && _characterList.characterId == 3)
        {
            Destroy(archerP.GetChild(0).gameObject);
        }
        else if (archerP.childCount > 0 && _characterList.characterId != 3)
        {
            Destroy(archerP.GetChild(0).gameObject);
        }

        displayCharacter(_characterList, chPrefab);

        idCharacter = _characterList.characterId;
        //Debug.Log(idCharacter);

        //UI
        characterMp.fillAmount = _characterList.mp /100;
        characterStrength.fillAmount = _characterList.strength / 100;
        characterDefense.fillAmount = _characterList.defense / 100;
        characterName.text = _characterList.Name;
        characterClass.text = _characterList._class;
    }
    public void displayCharacter(CharacterList id, GameObject character)
    {
        if (id.characterId == 1)
        {
            GameObject clone = Instantiate(character, warriorP.position, warriorP.rotation, warriorP); //Display character on Scene
        }
        else if (id.characterId == 2)
        {
            GameObject clone = Instantiate(character, mageP.position, mageP.rotation, mageP);
        }
        else if (id.characterId == 3)
        {
            GameObject clone = Instantiate(character, archerP.position, archerP.rotation, archerP);
        }
    }

    public void destroyObj()
    {
       
    }

    public void StartGameTo()
    {
        PlayerPrefs.SetInt("CharacterID", idCharacter);
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
}
