using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[TrackClipType(typeof(SDFacialExpressionClip))]
[TrackBindingType(typeof(SDFacialAnimator))]
[TrackColor(0.85f, 0.6f, 0.75f)]
public sealed class SDFacialExpressionTrack : TrackAsset
{
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0001: Unknown opcode: 0xEB*/;
	}

	public SDFacialExpressionTrack()
	{
		/*Error: Invalid field token*/;
	}
}
