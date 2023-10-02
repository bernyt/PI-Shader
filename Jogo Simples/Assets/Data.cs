using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DataConfigAsset", menuName = "DataConfig", order = 1)]
public class Data : ScriptableObject
{
    public float moveSpeed;
    public float moveRotate;
}
