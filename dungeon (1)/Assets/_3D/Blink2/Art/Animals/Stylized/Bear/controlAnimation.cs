using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject Obj;
    private Animator anim;
    private float animTime;
    public bool isClassSelection = false;
    void Start()
    {
        anim = Obj.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isClassSelection)
        {
            IsClassSelection();
        }
        else
        {
            isClassSelection = false;
        }
    }

    void IsClassSelection()
    {
        anim.SetBool("IsClass_Selection", true);
    }
   
}

