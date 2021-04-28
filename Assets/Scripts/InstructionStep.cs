using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * construct step
 */

public class InstructionStep 
{
    public string Name;
    public string TitleText;
    public string BodyText;
    public string ImageName;
    public string VideoName;

    private const int NameColumn = 0;
    private const int TitleColumn = 1;
    private const int BodyColumn = 2;
    private const int ImageColumn = 3;
    private const int videoColumn = 4;

    public InstructionStep(List<string> Values)
    {
        foreach (string item in Values)
        {
            if (Values.IndexOf(item) == NameColumn)
            {
                Name = item;
            }
            if (Values.IndexOf(item) == TitleColumn)
            {
                TitleText = item;
            }
            if(Values.IndexOf(item)==BodyColumn)
            {
                BodyText = item;
            }
            if (Values.IndexOf(item) == ImageColumn)
            {
                ImageName = item;
            }
            if (Values.IndexOf(item) == videoColumn)
            {
                VideoName = item;
            }
        }
    }
}
