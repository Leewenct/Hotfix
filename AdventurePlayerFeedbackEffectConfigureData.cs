using UnityEngine;

[CreateAssetMenu(fileName = "Player Feedback Effect Configure Data", menuName = "游戏/特效/玩家反馈效果")]
public class AdventurePlayerFeedbackEffectConfigureData : ScriptableObject
{
	public struct PlayerFeedbackEffectInfo
	{
		public long cameraShakeUniqueId;

		public long racialBlurUniqueId;
	}

	public bool enableCameraShake;

	public float cameraShakeFadeIn;

	public float cameraShakeDuration;

	public float cameraShakeFadeOut;

	[Space]
	public Vector3 cameraShakeStrength;

	public float cameraShakeDepth;

	public float cameraShakeRotate;

	public int cameraShakeVibrato;

	[Range(0f, 180f)]
	public float cameraShakeRandomness;

	public bool enableRacialBlur;

	public float racialBlurFadeIn;

	public float racialBlurDuration;

	public float racialBlurFadeOut;

	[Space]
	[Range(0f, 1f)]
	public float racialBlurStrength;

	[Range(-1f, 1f)]
	public float racialBlurDirection;

	[Range(0f, 1f)]
	public float racialBlurInvertScattered;

	[Range(0f, 1f)]
	public float racialBlurRange;

	public PlayerFeedbackEffectInfo Play(Vector3 effectPosition = default(Vector3), GameObject effectTarget = null, int cameraShakeSort = 0)
	{
		/*Error: Unknown opcode: 0xE7*/;
	}

	public void Stop(long cameraShakeUniqueId = -1L, long racialBlurUniqueId = -1L)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public AdventurePlayerFeedbackEffectConfigureData()
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
