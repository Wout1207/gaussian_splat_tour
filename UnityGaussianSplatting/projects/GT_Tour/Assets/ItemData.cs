using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewItemData", menuName = "ItemData")]
public class ItemData : ScriptableObject
{
    public string itemName;
    [TextArea]
    public string description;
    public RenderTexture model;
}
