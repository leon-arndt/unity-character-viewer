using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Portrait", menuName = "ScriptableObjects/Portrait", order = 1)]
public class Portrait : ScriptableObject
{
    public string portraitName;

    public GameObject meshPrefab;
    public GameObject particlePrefab;
    public AnimationClip animClip;
    public bool shouldLoopAnimation;
}
