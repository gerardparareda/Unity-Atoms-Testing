using System;
using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.UI;

// [CreateAssetMenu(menuName = "Unity Atoms/Actions/Examples/InteractHover")]
public class Crosshair : MonoBehaviour
{
    [SerializeField] private BoolReference interacting;
    [SerializeField] private Sprite crosshairDefault;
    [SerializeField] private Sprite crosshairHovered;
    [SerializeField] private Image crosshair;

    public void Start()
    {
        interacting.GetEvent<BoolEvent>().Register(UpdateCrosshairSprite);
    }

    public void UpdateCrosshairSprite(bool hovered)
    {
        if (hovered)
        {
            crosshair.sprite = crosshairHovered;
        }
        else
        {
            crosshair.sprite = crosshairDefault;
        }
    }
}
