using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSettings : MonoBehaviour
{
    private string nameCharacter;
    private CharacterStats characterStats;

    public void SetName(string name)
    {
        nameCharacter = name;
        gameObject.name = $"{nameCharacter}_character";
    }

    public void SetStats(CharacterStats characterStats)
    {
        this.characterStats = characterStats;
    }

    public override string ToString()
    {
        return $"name {nameCharacter}, stats:{characterStats.HP}; {characterStats.damage}; {characterStats.level}";
    }
}
