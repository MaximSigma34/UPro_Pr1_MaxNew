using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterAnim : MonoBehaviour
{
    [SerializeField] private Animator animator;

    public void FindAnimator()
    {
        animator = GetComponent<Animator>();
    }
    
    public void SetAvatar(Avatar avatar)
    {
        if(animator == null)
        {
            Debug.LogError("AnimatorNotFound");
            return;
        }
        animator.avatar = avatar;
    }

    public void SetControlller(RuntimeAnimatorController controller)
    {
        if (animator == null)
        {
            Debug.LogError("AnimatorNotFound");
            return;
        }
        animator.runtimeAnimatorController = controller;
    }
}
