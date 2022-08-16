using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using OpenCvSharp;
using OpenCvSharp.Demo;

public class WebCameraController : WebCamera
{
    private Mat image;
    protected override bool ProcessTexture(WebCamTexture input, ref Texture2D output)
    {
        image = OpenCvSharp.Unity.TextureToMat(input);

        if (output == null)
            output = OpenCvSharp.Unity.MatToTexture(image);
        else
            OpenCvSharp.Unity.MatToTexture(image, output);

        return true;
    }
}
