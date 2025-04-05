using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatorFireCharacter : abstractCharacterFactory
{
    private void ChooseMaterial(CharacterSettings idle) 
    {
        foreach(var mat in idle.GetComponentsInChildren<Renderer>())
        {
            Material material = mat.material;
            material.color = Color.red;
            mat.material = material;
        }
    }
    ICharacterBuilder character = new BuilderCharacter();
    public override void CreatorMagic(CharacterSettings prefab, RuntimeAnimatorController controller)
    {
        CharacterSettings idle1 = character
                .Reset()
                .SetPrefabs(prefab)
                .SetName("Magic")
                .SetStats(new CharacterStats(5, 10, 3))
                .SetAvatar(null)
                .SetController(controller)
                .Build();
        ChooseMaterial(idle1);
    }

    public override void CreatorCowboy(CharacterSettings prefab, RuntimeAnimatorController controller)
    {
        CharacterSettings idle1 = character
                .Reset()
                .SetPrefabs(prefab)
                .SetName("Cowboy")
                .SetStats(new CharacterStats(5, 10, 3))
                .SetAvatar(null)
                .SetController(controller)
                .Build();
        ChooseMaterial(idle1);
    }

    public override void CreatorOrdinary(CharacterSettings prefab, RuntimeAnimatorController controller)
    {
        CharacterSettings idle1 = character
                .Reset()
                .SetPrefabs(prefab)
                .SetName("Ordinary")
                .SetStats(new CharacterStats(5, 10, 3))
                .SetAvatar(null)
                .SetController(controller)
                .Build();
        ChooseMaterial(idle1);
    }

    
}
