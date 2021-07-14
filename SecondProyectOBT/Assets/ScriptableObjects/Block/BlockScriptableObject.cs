using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "block", menuName ="Block")]
public class BlockScriptableObject : ScriptableObject
{
    public List<Sprite> blockSprite;
    public List<AnimationClip> destroyAnimation;
}
