using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Assets.Scripts.Les9;

public class TextMenuCoin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TMP_Text>().text = "" + BankManager.Instance.Coin;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
