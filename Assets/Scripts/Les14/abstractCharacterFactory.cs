using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class abstractCharacterFactory 
{
    public abstract void CreatorOrdinary(CharacterSettings prefab, RuntimeAnimatorController controller);
    public abstract void CreatorCowboy(CharacterSettings prefab, RuntimeAnimatorController controller);
    public abstract void CreatorMagic(CharacterSettings prefab, RuntimeAnimatorController controller);

}
