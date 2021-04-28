using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

[RequireComponent(typeof(RawImage))]
public class VideoGraphic : InstructionElement
{
    public VideoPlayer videoPlayer;
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
        if (!string.IsNullOrEmpty(step.VideoName))
        {
            GetComponent<LayoutElement>().enabled = true;
            videoPlayer.clip = Resources.Load(step.VideoName) as VideoClip;
            GetComponent<RawImage>().SetNativeSize();
            videoPlayer.Play();
        }
        else
        {
            videoPlayer.Stop();
            GetComponent<LayoutElement>().enabled = false;
        }
    }
}
