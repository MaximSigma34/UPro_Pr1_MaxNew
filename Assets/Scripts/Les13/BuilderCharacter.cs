using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuilderCharacter : ICharacterBuilder
{
    private CharacterSettings prefabs;
    private string prefabName;
    private CharacterStats prefabCharacterStats;
    private Avatar avatar;
    private RuntimeAnimatorController controller;

    public CharacterSettings Build()
    {
        CharacterSettings characterSettings = Object.Instantiate(prefabs);
        characterSettings.SetName(prefabName);
        characterSettings.SetStats(prefabCharacterStats);
        Debug.Log(characterSettings.ToString());
        characterAnim characterAnim = characterSettings.gameObject.AddComponent<characterAnim>();
        characterAnim.FindAnimator();
        characterAnim.SetAvatar(avatar);
        characterAnim.SetControlller(controller);
        return characterSettings;
    }

    public ICharacterBuilder Reset()
    {
        prefabs = null;
        prefabCharacterStats = null;
        prefabName = null;
        avatar = null;
        controller = null;
        return this;
    }

    public ICharacterBuilder SetAvatar(Avatar avatar)
    {
         this.avatar = avatar;
        return this;
    }

    public ICharacterBuilder SetController(RuntimeAnimatorController controller)
    {
        this.controller = controller;
        return this;
    }

    public ICharacterBuilder SetName(string name)
    {
        this.prefabName = name;
        return this;
    }

    public ICharacterBuilder SetPrefabs(CharacterSettings prefabs)
    {
        this.prefabs = prefabs;
        return this;
    }

    public ICharacterBuilder SetStats(CharacterStats stats)
    {
        this.prefabCharacterStats = prefabCharacterStats;
        return this;
    }

  
}
