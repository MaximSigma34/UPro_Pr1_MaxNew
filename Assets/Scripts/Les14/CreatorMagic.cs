using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatorMagic : AbstractCreator
{
    ICharacterBuilder character = new BuilderCharacter();

    public override void CreatorCharacter(CharacterSettings prefab, RuntimeAnimatorController controller)
    {
        CharacterSettings idle1 = character
                .Reset()
                .SetPrefabs(prefab)
                .SetName("Magic")
                .SetStats(new CharacterStats(5, 10, 3))
                .SetAvatar(null)
                .SetController(controller)
                .Build();
    }
}
