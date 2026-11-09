using System;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Game/FX/Buff FX Handler")]
[DisallowMultipleComponent]
public class AdventureBuffFXHandler : AdventureFXHandler
{
	[Serializable]
	public class AnimationEffectDataPair
	{
		public SlotType syncSlot;

		public bool syncSlotRotation;

		public bool syncSlotScale;

		[Space]
		public GameObject fxPrefab;

		public GameObject fxPrefabForLargeSize;

		[Space]
		public float playbackSpeed;

		public AnimationEffectDataPair()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
				/*Error near IL_0001: Invalid calli metadata token*/;
			}
		}
	}

	public enum StackFXMode
	{
		[InspectorName("每层播放相同的特效")]
		SameFXEachStack,
		[InspectorName("一层播放一种特效")]
		OneFXOneStack
	}

	public enum StackFXAdditionalMethod
	{
		[InspectorName("叠加")]
		Additional,
		[InspectorName("替换")]
		Replace
	}

	public enum FXPlayMode
	{
		Default,
		Instant,
		HurtInstant
	}

	public AnimationEffectDataPair[] startEffects;

	public float loopDelayTime;

	public AnimationEffectDataPair[] loopEffects;

	public AnimationEffectDataPair[] endEffects;

	public AnimationEffectDataPair[] endEffectsIfFullStack;

	public StackFXMode stackFXMode;

	public StackFXAdditionalMethod stackFXAdditionalMethod;

	public AnimationEffectDataPair[] stackEffects;

	public AnimationEffectDataPair[] stackFullEffects;

	public AnimationEffectDataPair[] hurtEffects;

	[Tooltip("例如用于实现箭矢随机角度插在物体表面")]
	public Vector3 stackEffectRotationRandomAngle;

	[Space]
	public bool enableFXForLargeSize;

	[MinMaxSlider(0f, 10f)]
	public Vector2 largeSizeScaleRange;

	[Space]
	public bool ignoreBodySizeAdaptiveScale;

	protected float _fxSize;

	protected float _playbackTimer;

	protected bool _loopEffectsPlayed;

	protected List<AdventureFXPlayer> _loopPlayers;

	protected int _currentStackCount;

	protected int _maxStackCount;

	protected List<AdventureFXPlayer> _stackPlayers;

	protected List<AdventureFXPlayer> _stackFullPlayers;

	protected GameObject _owner;

	protected AdventureActor _targetActor;

	public GameObject owner
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	public AdventureActor targetActor
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	protected override void OnDisable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid calli metadata token*/;
		}
	}

	public override void DoUpdate()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xAB*/;
		}
	}

	protected static AdventureBuffFXHandler Spawn(GameObject fxPrefab, bool isPreloadSpawn = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	protected static void Despawn(AdventureBuffFXHandler fxHandler)
	{
		/*Error: Invalid field token*/;
	}

	internal static void PreloadFX(GameObject fxPrefab)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public static AdventureBuffFXHandler PlayFX(GameObject fxPrefab, GameObject owner, FXPlayMode playMode, Vector3 fxPosition = default(Vector3), Quaternion fxRotation = default(Quaternion), float fxScale = 1f, AdventureActor targetActor = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		return (AdventureBuffFXHandler)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
	}

	public void PlayFX(GameObject owner, float fxSize = 1f, AdventureActor targetActor = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (ulong)/*Error near IL_0007: Stack underflow*/;
			_ = 701966336;
			/*Error near IL_000c: Unknown opcode: 0xE2*/;
		}
	}

	protected void PlayFX_Internal(AnimationEffectDataPair[] effects, bool isLoopEffects)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 204 (out-of-bounds)*/;
			_ = -1;
			/*Error near IL_0004: Unknown opcode: 0xE8*/;
		}
	}

	public void PlayInstantFX(GameObject owner = null, Vector3 fxPosition = default(Vector3), Quaternion fxRotation = default(Quaternion), float fxSize = 1f, AdventureActor targetActor = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
		}
	}

	public void PlayHurtInstantFX(GameObject owner = null, Vector3 fxPosition = default(Vector3), Quaternion fxRotation = default(Quaternion), float fxSize = 1f, AdventureActor targetActor = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
		}
	}

	public void PlayBuffStackFX(int currentStackCount, int maxStackCount)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	private void PlayBuffStackFX_Stack(int fromStackCount, int toStackCount)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected I4, but got Unknown
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
		}
	}

	private void StopBuffStackFX_Stack(bool interrupt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected I4, but got Unknown
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
		}
	}

	private void PlayBuffStackFX_OneStack(int stackFXIndex)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	private void StopBuffStackFX_OneStack(bool interrupt)
	{
		/*Error: Unknown opcode: 0xE7*/;
	}

	private void PlayBuffStackFX_FullStack()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid calli metadata token*/;
		}
	}

	private void StopBuffStackFX_FullStack(bool interrupt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected I4, but got Unknown
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
		}
	}

	public void StopFX(bool interrupt = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (nuint)/*Error near IL_0007: Stack underflow*/ >> -1804054522;
			/*Error near IL_000e: Unknown opcode: 0xE7*/;
		}
	}

	protected void StopFX_Loop(bool dontPlaySubFX)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected I4, but got Unknown
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
		}
	}

	protected AdventureFXPlayer DoPlayFXInstance(GameObject owner, AdventureActor targetActor, AnimationEffectDataPair effectSetting, Vector3 fxPosition = default(Vector3), Quaternion fxRotation = default(Quaternion), float fxSize = 1f, Vector3 fxLocalRotationRandomAngle = default(Vector3))
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		return (AdventureFXPlayer)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
	}

	protected (float, GameObject) CalcFXScaleWithTargetBody(AdventureActor targetActor, AnimationEffectDataPair effectSetting)
	{
		/*Error: Unknown opcode: 0xF7*/;
	}

	public AdventureBuffFXHandler()
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
