using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[CreateAssetMenu(menuName = "CustomUI/textSO", fileName = "Text")]
public class textSO : ScriptableObject
{
    public themeSO theme;

    public TMP_FontAsset font;
    public float size;
}
