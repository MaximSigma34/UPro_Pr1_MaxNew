using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryPointLes14F1 : MonoBehaviour
{
    [SerializeField] CharacterSettings ordinary;
    [SerializeField] CharacterSettings magic;
    [SerializeField] CharacterSettings cowboy;
    [SerializeField] RuntimeAnimatorController controller;
    AbstractCreator creator;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            creator = new CreatorOrdinary();
            creator.CreatorCharacter(ordinary, controller);
        }


        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            creator = new CreatorCowboy();
            creator.CreatorCharacter(cowboy, controller);
        }


        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            creator = new CreatorMagic();
            creator.CreatorCharacter(magic, controller);
        }
    }

}
