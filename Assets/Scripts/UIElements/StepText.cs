using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent (typeof(Text))]
public class StepText : InstructionElement
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void InstructionUpdate(InstructionStep step)
    {
        GetComponent<Text>().text = "Step: " + step.Name;
    }
}
