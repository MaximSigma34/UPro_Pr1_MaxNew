using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMove : IMoving
{

    [SerializeField] protected float speed;
    protected Transform moveTransform;
    protected Animator anim;
    protected string nameClip;

    public BaseMove(float speed, Transform moveTransform, Animator anim, string nameClip)
    {
        this.speed = speed;
        this.moveTransform = moveTransform;
        this.anim = anim;
        this.nameClip = nameClip;
    }

    virtual public void Move(float move)
    {
        moveTransform.parent.parent.Translate(0, 0, move * speed);
    }

    public void PlayClip()
    {
        if (anim != null)
        {
            anim.Play(nameClip, -1, -1);
        }
    }
}

  
