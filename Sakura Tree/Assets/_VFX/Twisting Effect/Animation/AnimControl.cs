
using System;
using System.Collections;
using UnityEngine;

public class AnimControl : MonoBehaviour
{
    [SerializeField] private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        StartCoroutine(PlayAnimation());
    }

    [ContextMenu("Play Logo Animation")]
    private void PlayAgain()
    {
        StartCoroutine(PlayAnimation());
    }

    private IEnumerator PlayAnimation()
    {
        yield return new WaitForSeconds(0.2f);
        animator.SetTrigger("LogoOn");
        yield return new WaitForSeconds(10f);
        animator.SetTrigger("LogoOff");
        yield return new WaitForSeconds(6f);
    }
}
