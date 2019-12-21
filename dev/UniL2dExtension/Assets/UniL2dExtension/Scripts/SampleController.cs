using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static MotionBlendHelper;

public class SampleController : MonoBehaviour
{
    [SerializeField]
    private MotionBlendHelper motionBlendHelper;
    [SerializeField]
    public string Layer = "Pose";
    [SerializeField, Range(0f, 1f)]
    public float Blending = 0f;
    [SerializeField, Range(0f, 1f)]
    public float Weight = 1f;
	
    void Update()
    {
        motionBlendHelper.SetBlend(Layer, Blending, Weight);
    }
}
