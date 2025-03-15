using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class entryPointLes11 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<FSMController>()?.Init();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
