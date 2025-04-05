using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryPointLes14F2 : MonoBehaviour
{
    [SerializeField] CharacterSettings ordinary;
    [SerializeField] CharacterSettings magic;
    [SerializeField] CharacterSettings cowboy;
    [SerializeField] RuntimeAnimatorController controller;
    abstractCharacterFactory creator = new CreatorFireCharacter();

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.F))
        {
            creator = new CreatorFireCharacter();
           
        }  if (Input.GetKeyDown(KeyCode.W))
        {
            creator = new CreatorWaterCharacter();
           
        }


        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            
            creator.CreatorOrdinary(ordinary, controller);
        }


        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            
            creator.CreatorCowboy(cowboy, controller);
        }


        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
           
            creator.CreatorMagic(magic, controller);
        }
    }

}
