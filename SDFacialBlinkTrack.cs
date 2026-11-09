using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[TrackClipType(typeof(SDFacialBlinkClip))]
[TrackBindingType(typeof(SDFacialAnimator))]
[TrackColor(0.6f, 0.35f, 0.5f)]
public sealed class SDFacialBlinkTrack : TrackAsset
{
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0001: Unknown opcode: 0xEB*/;
	}

	public SDFacialBlinkTrack()
	{
		/*Error: Invalid field token*/;
	}
}
