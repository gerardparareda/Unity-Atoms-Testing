using System;
using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.InputSystem;

public class Interact : MonoBehaviour
{

    [SerializeField] private InputActionAsset actions;
    [SerializeField] private BoolReference interactableHoveredVariable;
    [SerializeField] private GameObject hoveredElement;
    
    private int collideMaskLayer = 1 << 6;

    private void Awake()
    {
        // Algo no va aquí i n'estic fins els collons
        actions.FindActionMap("Player").FindAction("Interact").performed += DoInteract;
    }

    private void DoInteract(InputAction.CallbackContext context)
    {
        if (hoveredElement)
        {
            hoveredElement.GetComponent<Interactable>().Interact();
        }
    }
    
    private void FixedUpdate()
    {
        RaycastHit hit;
        
        if (Physics.Raycast(
                Camera.main.transform.position, 
                Camera.main.transform.TransformDirection(Vector3.forward), 
                out hit, Mathf.Infinity, collideMaskLayer
                )
            )
        {
            Debug.DrawRay(
                Camera.main.transform.position, 
                Camera.main.transform.TransformDirection(Vector3.forward) * hit.distance, 
                Color.yellow
                );
            if (hit.collider.gameObject != hoveredElement)
            {
                // Debug.Log("interactable gameObject " + hit.collider.gameObject.name);
                if (hoveredElement)
                {
                    hoveredElement.GetComponent<Interactable>().Hover(false);
                }
                hoveredElement = hit.collider.gameObject;
                hoveredElement.GetComponent<Interactable>().Hover(true);
                interactableHoveredVariable.Value = true;
            } 
        }
        else
        {
            if (hoveredElement)
            {
                hoveredElement.GetComponent<Interactable>().Hover(false);
                hoveredElement = null;
                interactableHoveredVariable.Value = false;
            }
            Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.TransformDirection(Vector3.forward) * 1000, Color.white);
        }
    }
}
