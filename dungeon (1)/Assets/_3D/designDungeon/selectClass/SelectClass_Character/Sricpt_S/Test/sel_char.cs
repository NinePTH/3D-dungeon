using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sel_char : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] characters;
    public int selectedCharacter = 0;
    public string classCharacter;
    private GameObject gOb;
    //[SerializeField] private GameObject cameraA;
    private Animator anim;

    public void NextCharacter()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter = (selectedCharacter + 1) % characters.Length;
        characters[selectedCharacter].SetActive(true);
    }

    public void PreviousCharacter()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter--;
        if(selectedCharacter < 0)
        {
            selectedCharacter += characters.Length;
        }
        characters[selectedCharacter].SetActive(true);
    }

    


    

    void Start()
    {
        gOb = characters[0];
        classCharacter = gOb.name;
        Debug.Log(gOb.name);
        //anim = cameraA.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void warriorClass()
    {
        if (classCharacter != characters[0].name)
        {
            characters[0].SetActive(true);
            selectedCharacter = 0;
            classCharacter = characters[0].name;
            characters[2].SetActive(false);
            characters[1].SetActive(false);
            
        }
        Debug.Log(characters[0].name);
        
    }
    public void mageClass()
    {
        if (classCharacter != characters[2].name)
        {
            characters[2].SetActive(true);
            selectedCharacter = 2;
            classCharacter = characters[2].name;
            characters[0].SetActive(false);
            //anim.SetBool("moveCam", true);
            characters[1].SetActive(false);
        }
        else
        {
            //anim.SetBool("moveCam", false);
        }
        Debug.Log(characters[2].name);
        
        //posCam =  Vector3()

    }
    public void archerClass()
    {
        if (classCharacter != characters[1].name)
        {
            characters[1].SetActive(true);
            selectedCharacter = 1;
            classCharacter = characters[1].name;
            characters[0].SetActive(false);
            characters[2].SetActive(false);
        }
        Debug.Log(characters[1].name);
    }
    public void StartGame()
    {
        PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

}
