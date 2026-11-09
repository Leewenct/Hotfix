using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public sealed class SDFacialBlinkClip : PlayableAsset, ITimelineClipAsset
{
	[Range(0f, 1f)]
	[Tooltip("闭眼BlendShape权重比例，1=完全闭眼")]
	public float closedWeight;

	public ClipCaps clipCaps
	{
		get
		{
			/*Error: Unknown opcode: 0xAF*/;
		}
	}

	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	public SDFacialBlinkClip()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 6;
			/*Error near IL_0002: Unknown opcode: 0xCB*/;
		}
	}
}
