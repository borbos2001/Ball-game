using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnimationControl : MonoBehaviour
{
    private Animator _anim;
    private void Start()
    {
        _anim = GetComponent<Animator>();

    }
    public void AnimationRandom()
    {
        _anim.SetInteger("NumAnimation", Random.Range(0,3));
    }
}
