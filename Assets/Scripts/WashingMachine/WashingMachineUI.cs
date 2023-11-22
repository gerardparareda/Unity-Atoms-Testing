using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class WashingMachineUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI panelText;
    [SerializeField] private IntReference washingMachineState;
    
    // Start is called before the first frame update
    void Start()
    {
        washingMachineState.GetEvent<IntEvent>().Register(UpdatePanelText);
        UpdatePanelText(washingMachineState.Value);
    }

    // Update is called once per frame
    void UpdatePanelText(int currentState)
    {
        Debug.Log("are you updating you piece of shit?"+currentState);
        string machineStateText = "";
        switch (currentState)
        {
            case 0:
                machineStateText = "Press E to open";
                break;
            case 1:
                machineStateText = "Press E to close";
                break;
            case 2:
                machineStateText = "Working...";
                break;
        }

        panelText.text = machineStateText;
    }
}
