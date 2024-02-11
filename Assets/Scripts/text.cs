using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class text : MonoBehaviour
{
    public textSO textData;
    public StyleEnum styleEnum;

    private TextMeshProUGUI textMeshProUGUI;

    private void Awake(){
        Init();
    }

    private void Init(){
        Setup();
        Configure();
    }

    private void Setup(){
        textMeshProUGUI = GetComponentInChildren<TextMeshProUGUI>();
    }

    private void Configure(){
        textMeshProUGUI.color = textData.theme.GetTextColor(styleEnum);
        textMeshProUGUI.font = textData.font;
        textMeshProUGUI.fontSize = textData.size;
    }

    void OnValidate(){
        Init();
    }
}
