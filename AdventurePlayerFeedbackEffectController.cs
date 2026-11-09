using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

public class AdventurePlayerFeedbackEffectController : SceneSingleton<AdventurePlayerFeedbackEffectController>
{
	protected class PostProcessHandler
	{
		public enum State
		{
			FadeIn,
			Hold,
			FadeOut,
			Stoped
		}

		public VolumeProfile profile;

		public Volume volume;

		public float fadeIn;

		public float duration;

		public float fadeOut;

		public State state;

		public float timer;

		public void Play(float fadeIn, float duration, float fadeOut)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
				{
					/*Error: Invalid branch target*/;
				}
				_ = (ulong)/*Error near IL_0007: Stack underflow*/;
			}
			_ = -(nint)1793325572;
			/*Error near IL_000e: Unknown opcode: 0xE7*/;
		}

		public void Stop()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected I4, but got Unknown
			switch (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
			{
			default:
				/*Error: End of method reached without returning.*/;
			case 0:
				/*Error: Invalid branch target*/;
			case 1:
				/*Error: Invalid branch target*/;
			case 2:
				/*Error: Invalid branch target*/;
			case 3:
				/*Error: Invalid branch target*/;
			case 4:
				/*Error: Invalid branch target*/;
			case 5:
				/*Error: Invalid branch target*/;
			case 6:
				/*Error: Invalid branch target*/;
			case 7:
				/*Error: Invalid branch target*/;
			case 8:
				/*Error: Invalid branch target*/;
			case 9:
				/*Error: Invalid branch target*/;
			case 10:
				/*Error: Invalid branch target*/;
			}
		}

		public void Update(float dt)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I8
			if (/*Error near IL_0006: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
			{
				/*Error: Invalid branch target*/;
			}
			if ((long)/*Error near IL_0009: Stack underflow*/ <= (long)checked((ulong)/*Error near IL_0007: Stack underflow*/))
			{
				/*Error near IL_0009: Unknown opcode: 0xFA*/;
			}
			checked
			{
				_ = (long)/*Error near IL_000e: Stack underflow*/;
				/*Error near IL_000e: Unknown opcode: 0xE7*/;
			}
		}

		public PostProcessHandler()
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Invalid field token*/;
		}
	}

	public VolumeProfile racialBlurProfile;

	private long _racialBlurUniqueId;

	protected List<PostProcessHandler> _postprocessHandlers;

	protected GameObject _frozenTimeFXPrefab;

	protected AdventureFXPlayer _frozenTimeFXPlayer;

	public bool isPlayingWitchTimeFX
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		private set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public bool isPlayingFrozenTimeFX
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		private set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	protected void Start()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected void OnDisable()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected void LateUpdate()
	{
		/*Error: Invalid field token*/;
	}

	public (long, long) Play(AdventurePlayerFeedbackEffectConfigureData configData, Vector3 effectPosition, GameObject effectTarget, int _cameraShakeSort = 0)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public void Stop(AdventurePlayerFeedbackEffectConfigureData configData, long cameraShakeUniqueId = -1L, long racialBlurUniqueId = -1L)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/))
		{
		default:
			/*Error: End of method reached without returning.*/;
		case 0:
			/*Error: Invalid branch target*/;
		case 1:
			/*Error: Invalid branch target*/;
		case 2:
			/*Error: Invalid branch target*/;
		case 3:
			/*Error: Invalid branch target*/;
		case 4:
			/*Error: Invalid branch target*/;
		case 5:
			/*Error: Invalid branch target*/;
		case 6:
			/*Error: Invalid branch target*/;
		}
	}

	protected long PlayRacialBlur(AdventurePlayerFeedbackEffectConfigureData configData, Vector3 centerScreenPosition)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I8
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c->IL000c: Incompatible stack heights: 1 vs 0
		if (/*Error near IL_0006: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((long)/*Error near IL_0009: Stack underflow*/ <= (long)checked((ulong)/*Error near IL_0007: Stack underflow*/))
		{
			if (!float.IsFinite(3))
			{
				throw new ArithmeticException();
			}
			_ = /*Error near IL_000c: Stack underflow*/>> 3;
		}
		checked
		{
			_ = /*Error near IL_000d: Stack underflow*/+ /*Error near IL_000d: Stack underflow*/;
		}
		return (long)/*OpCode not supported: Nop*/;
	}

	protected void StopRacialBlur(long racialBlurUniqueId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (ulong)/*Error near IL_0007: Stack underflow*/;
			/*Error near IL_0007: Unknown opcode: 0xE2*/;
		}
	}

	protected PostProcessHandler PlayPostProcess(VolumeProfile profile, float fadeIn, float duration, float fadeOut)
	{
		/*Error: Unknown opcode: 0xE9*/;
	}

	protected void UpdatePostProcess()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public void PlayWitchTimeFX(AdventureActor witchTimeOwner, AdventureActor witchtimeAttackTarget)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public void StopWitchTimeFX()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public void PlayFrozenTimeFX()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
		default:
			/*Error: End of method reached without returning.*/;
		case 0:
			/*Error: Invalid branch target*/;
		case 1:
			/*Error: Invalid branch target*/;
		case 2:
			/*Error: Invalid branch target*/;
		case 3:
			/*Error: Invalid branch target*/;
		case 4:
			/*Error: Invalid branch target*/;
		case 5:
			/*Error: Invalid branch target*/;
		case 6:
			/*Error: Invalid branch target*/;
		case 7:
			/*Error: Invalid branch target*/;
		case 8:
			/*Error: Invalid branch target*/;
		case 9:
			/*Error: Invalid branch target*/;
		case 10:
			/*Error: Invalid branch target*/;
		case 11:
			/*Error: Invalid branch target*/;
		case 12:
			/*Error: Invalid branch target*/;
		case 13:
			/*Error: Invalid branch target*/;
		case 14:
			/*Error: Invalid branch target*/;
		case 15:
			/*Error: Invalid branch target*/;
		case 16:
			/*Error: Invalid branch target*/;
		case 17:
			/*Error: Invalid branch target*/;
		case 18:
			/*Error: Invalid branch target*/;
		case 19:
			/*Error: Invalid branch target*/;
		case 20:
			/*Error: Invalid branch target*/;
		case 21:
			/*Error: Invalid branch target*/;
		case 22:
			/*Error: Invalid branch target*/;
		case 23:
			/*Error: Invalid branch target*/;
		case 24:
			/*Error: Invalid branch target*/;
		case 25:
			/*Error: Invalid branch target*/;
		case 26:
			/*Error: Invalid branch target*/;
		case 27:
			/*Error: Invalid branch target*/;
		case 28:
			/*Error: Invalid branch target*/;
		case 29:
			/*Error: Invalid branch target*/;
		case 30:
			/*Error: Invalid branch target*/;
		case 31:
			/*Error: Invalid branch target*/;
		case 32:
			/*Error: Invalid branch target*/;
		case 33:
			/*Error: Invalid branch target*/;
		case 34:
			/*Error: Invalid branch target*/;
		case 35:
			/*Error: Invalid branch target*/;
		case 36:
			/*Error: Invalid branch target*/;
		case 37:
			/*Error: Invalid branch target*/;
		case 38:
			/*Error: Invalid branch target*/;
		}
	}

	public void StopFrozenTimeFX()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
		default:
			/*Error: End of method reached without returning.*/;
		case 0:
			/*Error: Invalid branch target*/;
		case 1:
			/*Error: Invalid branch target*/;
		case 2:
			/*Error: Invalid branch target*/;
		case 3:
			/*Error: Invalid branch target*/;
		case 4:
			/*Error: Invalid branch target*/;
		case 5:
			/*Error: Invalid branch target*/;
		case 6:
			/*Error: Invalid branch target*/;
		case 7:
			/*Error: Invalid branch target*/;
		case 8:
			/*Error: Invalid branch target*/;
		case 9:
			/*Error: Invalid branch target*/;
		case 10:
			/*Error: Invalid branch target*/;
		case 11:
			/*Error: Invalid branch target*/;
		}
	}

	protected void OnWitchTimeEnter(IEvent e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	protected void OnWitchTimeExit(IEvent e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	protected void OnFXPlayerOwnerActorBind(AdventureFXPlayer fxPlayer)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public void StopAllFX()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public unsafe AdventurePlayerFeedbackEffectController()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I
		if ((nint)/*Error near IL_0004: Stack underflow*/ <= (nint)(*(IntPtr*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/)))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}
}
