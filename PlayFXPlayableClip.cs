using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public sealed class PlayFXPlayableClip : PlayableAsset, ITimelineClipAsset
{
	public enum Mode
	{
		[InspectorName("播放预制体特效")]
		PlayFX = 1,
		[InspectorName("播放内嵌在Timeline上的特效")]
		PlaySelfFX,
		[InspectorName("停止内嵌在Timeline上的特效")]
		StopSelfFX
	}

	public Mode mode;

	public GameObject fxPrefab;

	public ExposedReference<GameObject> fxInstance;

	public bool playOnceInLoop;

	public bool stopFXOnFinish;

	public ExposedReference<GameObject> bindOwner;

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

	public PlayFXPlayableClip()
	{
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0002: Invalid field token*/;
	}
}
