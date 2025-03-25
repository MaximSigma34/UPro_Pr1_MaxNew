using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static FSMController;

public class characterRun : State
{
    [SerializeField]
    protected float _speedWallkin = 20;

    [SerializeField]
    protected string nameH = "Horizontal";
    [SerializeField]
    protected string nameV = "Vertical";

    public override void Do()
    {
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            GetComponentInParent<FSMController>().SwitchState(CharacterState.Move);
        }

        float move = Input.GetAxis(nameV) * _speedWallkin * Time.deltaTime;

        transform.parent.parent.Translate(0, 0, move);
    }

    public override void Enter()
    {
        base.Enter();
        Debug.Log("Run Enter");
    }
}
