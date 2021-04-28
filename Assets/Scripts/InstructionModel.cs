using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * store all steps as a list
 */

public class InstructionModel 
{
    [SerializeField]
    private List<InstructionStep> steps = new List<InstructionStep>();

    public void LodaData()
    {
        /*
        steps.Add(new InstructionStep(new List<string> { "0", "Hello World!","Intro bodey text."}));
        steps.Add(new InstructionStep(new List<string> { "1", "This is the first step.", "Body text of first step." }));
        steps.Add(new InstructionStep(new List<string> { "2", "This is the second step.", "Body text of second step." }));
        */
        steps.Clear();
        TextAsset textAsset = (TextAsset)Resources.Load("instructionsCSV");
        fgCSVReader.LoadFromString(textAsset.text,new fgCSVReader.ReadLineDelegate(csvReader));
    }

    private void csvReader(int line_index, List<string> line)
    {
        if (line_index == 0)
        {
            return;
        }
        steps.Add(new InstructionStep(line));
    }

    public InstructionStep GetInstructionStep(int index)
    {
        if(index<0 || index >= steps.Count)
        {
            return null;
        }
        return steps[index];
    }

    public int GetCount()
    {
        return steps.Count;
    }

}
