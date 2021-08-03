using System.Collections;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    [SerializeField] private BlockScriptableObject blockScriptableObject;
    [SerializeField] private GameObject blockPrefab;
    private Animator animator;   
    private Vector3 row1;
    private Vector3 row2;
    private Vector3 row3;
    private Vector3 column1;
    private Vector3 column2;
    private Vector3 column3;
    private Transform positionOfBlock;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        MatrixController.onRandomNumberGeneration += onRandomNumberGeneration;
        row1 = new Vector2(0, -1.75f);
        row2 = new Vector2(0, 0.59f);
        row3 = new Vector2(0, 2.93f);
        column1 = new Vector2(-2.344f, 0);
        column2 = new Vector2(0f, 0);
        column3 = new Vector2(2.346f, 0);
    }

    
    private void DestroyBlock()
    {
        GetComponent<SpriteRenderer>().sortingOrder = 8;
        animator.Play("BlockDestroy");
        gameObject.SetActive(false);
    }

    private void onRandomNumberGeneration(object sender, BlockParameters e)
    {
        StartCoroutine(GenerateBlockCoroutine(e));
    }

    private IEnumerator GenerateBlockCoroutine(BlockParameters blockParameters)
    {
        if(blockParameters.getRow() == 1)
        {
            positionOfBlock.position = row1;           
        }
        if (blockParameters.getRow() == 2)
        {
            positionOfBlock.position = row2;
        }
        if (blockParameters.getRow() == 3)
        {
            positionOfBlock.position = row3;
        }
        if (blockParameters.getColumn() == 1)
        {
            positionOfBlock.position = positionOfBlock.position + column1;
        }
        if (blockParameters.getColumn() == 2)
        {
            positionOfBlock.position = positionOfBlock.position + column2;
        }
        if (blockParameters.getColumn() == 3)
        {
            positionOfBlock.position = positionOfBlock.position + column3;
        }
        GameObject block = Instantiate(blockPrefab, positionOfBlock.position, Quaternion.identity);
        //blockScriptableObject.blockSprite = block.GetComponent<Sprite>(); 
        yield return null;
    }

}
