using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class view : MonoBehaviour
{
   public viewSO viewData;

   public GameObject containerTop;
   public GameObject containerCenter;
   public GameObject containerBottom;

   private Image imageTop;
   private Image imageCenter;
   private Image imageBottom;

   private VerticalLayoutGroup verticalLayoutGroup;

   private void Awake(){
      Init();
   }

   public void Init(){
      Setup();
      Configure();
   }

   public void Setup(){
      verticalLayoutGroup = GetComponent<VerticalLayoutGroup>();
      imageTop = containerTop.GetComponent<Image>();
      imageCenter = containerCenter.GetComponent<Image>();
      imageBottom = containerBottom.GetComponent<Image>();
   }

   public void Configure(){
      verticalLayoutGroup.padding = viewData.padding;
      verticalLayoutGroup.spacing = viewData.spacing;

      imageTop.color = viewData.theme.primary_bg;
      imageCenter.color = viewData.theme.secondary_bg;
      imageBottom.color = viewData.theme.tertiary_bg;
   }

   private void OnValidate(){
      Init();
   }

}
