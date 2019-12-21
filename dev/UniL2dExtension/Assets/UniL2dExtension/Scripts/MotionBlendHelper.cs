using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class MotionBlendHelper : MonoBehaviour
{
    private Animator _blendTree;
    public Dictionary<string, int> _expressionIndexes = new Dictionary<string, int>();
	[SerializeField]
	private List<string> Layers;

    void Start()
    {
        _blendTree = GetComponent<Animator>();
		Layers.ForEach((layer)=>{
			_expressionIndexes.Add(layer,_blendTree.GetLayerIndex(layer));
		});
    }

	public void SetBlend(string layer, float blending, float weight) 
	{
		if (_blendTree == null)
        {
            return;
        }

        _blendTree.SetFloat(layer, blending);

        if (_expressionIndexes.Count != 0) {
            _blendTree.SetLayerWeight(_expressionIndexes[layer], weight);
		}
	}
}