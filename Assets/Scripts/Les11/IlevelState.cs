using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IlevelState 
{

    void Enter();


    void Do();
    void fixedDo();
    void Exit();
}
