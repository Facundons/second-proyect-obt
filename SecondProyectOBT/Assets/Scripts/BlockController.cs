using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void DestroyBlock()
    {
        GetComponent<SpriteRenderer>().sortingOrder = 8;
        animator.Play("BlockDestroy");
        gameObject.SetActive(false);
    }

}
