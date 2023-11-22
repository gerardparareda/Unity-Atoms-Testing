using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    [SerializeField] private MeshRenderer hoverMeshIndicator;
    [SerializeField] private CanvasGroup hoverUIIndicator;
    [SerializeField] private VoidBaseEventReference onUseEvent;
    private bool isHovered;
    
    public bool IsHovered   // property
    {
      get { return isHovered; }   // get method
      set { isHovered = value; }
    }

    public void Interact()
    {
        onUseEvent.GetEvent<VoidEvent>().Raise();
    }

    public void Start()
    {
        // Set hovered color inital value to 0
        Color color = hoverMeshIndicator.material.color;
        color.a = 0.0f;
        hoverMeshIndicator.material.SetColor("_Color", color);
    }

    void toggleHover()
    {
        if (IsHovered)
        {
            hoverMeshIndicator.material.DOFade(1.0f, 0.5f);
            hoverUIIndicator.DOFade(1.0f, 0.5f);
        }
        else
        {
            hoverMeshIndicator.material.DOFade(0.0f, 0.5f);
            hoverUIIndicator.DOFade(0.0f, 0.5f);
        }
    }
    
    public void Hover(bool hovered)
    {
        IsHovered = hovered;
        toggleHover();
    }
}
