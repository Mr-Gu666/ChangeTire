using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

/*
 * CurrentStep is a number
 * currentInstructionModrl is current model, store all steps
 */

public class InstructionController : MonoBehaviour
{
    private int CurrentStep;
    private InstructionModel currentInstructionModel = new InstructionModel();
    public InstructionEvent OnInstructionUpdate = new InstructionEvent();

    private void Awake()
    {
        currentInstructionModel.LodaData();
    }

    // Start is called before the first frame update
    void Start()
    {
        CurrentStep = 0;
        CurrentInstructionUpdate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextStep()
    {
        if (CurrentStep < currentInstructionModel.GetCount() - 1)
        {
            ++CurrentStep;
            CurrentInstructionUpdate();
        }
    }

    public void PreviousStep()
    {
        if (CurrentStep > 0)
        {
             --CurrentStep;
             CurrentInstructionUpdate();
        }
    }

    private void CurrentInstructionUpdate()
    {
        InstructionStep step = currentInstructionModel.GetInstructionStep(CurrentStep);
        OnInstructionUpdate.Invoke(step);
    }

}

public class InstructionEvent: UnityEvent<InstructionStep> { }
