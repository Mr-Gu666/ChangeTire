using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RawImage))]
public class ImageGraphic : InstructionElement
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
        if (!string.IsNullOrEmpty(step.ImageName))
        {
            GetComponent<LayoutElement>().enabled = true;
            GetComponent<RawImage>().texture = Resources.Load(step.ImageName) as Texture;
        }
        else
        {
            GetComponent<RawImage>().texture = null;
            GetComponent<LayoutElement>().enabled = false;
        }
        Canvas.ForceUpdateCanvases();
    }
}
