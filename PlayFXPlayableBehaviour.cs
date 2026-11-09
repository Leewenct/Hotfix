using UnityEngine;
using UnityEngine.Playables;

public sealed class PlayFXPlayableBehaviour : PlayableBehaviour
{
	public PlayFXPlayableClip.Mode mode;

	public GameObject fxPrefab;

	public GameObject fxInstance;

	public bool playOnceInLoop;

	public bool stopFXOnFinish;

	public GameObject bindOwner;

	private AdventureFXPlayer _fxPlayer;

	private long _fxToken;

	private bool _playedOnce;

	public override void OnPlayableDestroy(Playable playable)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public override void OnGraphStop(Playable playable)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}

	public PlayFXPlayableBehaviour()
	{
		/*Error: Invalid field token*/;
	}
}
