using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryPointGame : MonoBehaviour
{
    List<FindCharacter> enemy;


    private void Awake()
    {
        enemy = new List<FindCharacter>(FindObjectsOfType<FindCharacter>());
        FindObjectOfType<CreatePlayer>().Init();
        foreach (FindCharacter en in enemy)
            en.Init();
    }
}
