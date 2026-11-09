using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TrueSync;
using UnityEngine;

public class HitBox : MonoBehaviour
{
	public enum Shape
	{
		Rectangle,
		Circle,
		Fan
	}

	[Flags]
	public enum FeatureFlag : uint
	{
		None = 0u,
		KnockBack = 1u,
		AirBorne = 2u,
		ChangeArea = 8u,
		Stiff = 0x1000u,
		Kill = 0x10000u,
		KillDestructible = 0x80000u,
		NoDiffDamage = 0x20000u,
		DamageFreezeFrame = 0x10000000u,
		AddBuffForSelf = 0x10u,
		AddBuffForTarget = 0x20u,
		RemoveBuffForSelf = 0x40u,
		RemoveBuffForTarget = 0x80u,
		All = uint.MaxValue
	}

	[Serializable]
	public class HitBoxFeatureData
	{
		public FP KnockBackForce;

		public FP KnockBackDistance;

		public bool UseAtttackForward;

		public bool UseHitBoxPosition;

		public FP KnockOutForce;

		public string oldAreaTag;

		public GameObject newAreaEffectPrefab;

		public FP StiffDuration;

		public bool isConfirmKill;

		public bool isConfirmKillDestructible;

		public FreezeFrameType _freezeFrameType;

		public FP FreezeFrameWhenDamage;

		public FP FreezeFrameWhenCrit;

		public FP FreezeFrameWhenToughnessBroken;

		public FP aFreezeFrameWhenDamage;

		public FP aFreezeFrameTimeScaleWhenDamage;

		public FP aFreezeFrameWhenCrit;

		public FP aFreezeFrameTimeScaleWhenCrit;

		public FP aFreezeFrameWhenToughnessBroken;

		public FP aFreezeFrameTimeScaleWhenToughnessBroken;

		public FP bFreezeFrameWhenDamage;

		public FP bFreezeFrameTimeScaleWhenDamage;

		public FP bFreezeFrameWhenCrit;

		public FP bFreezeFrameTimeScaleWhenCrit;

		public FP bFreezeFrameWhenToughnessBroken;

		public FP bFreezeFrameTimeScaleWhenToughnessBroken;

		public List<int> buffIdsForSelf;

		public List<int> buffIdsForTarget;

		public List<int> removeBuffIdsForSelf;

		public List<int> removeBuffIdsForTarget;

		public FP hitStrenth;

		public HitBoxFeatureData()
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

	public enum FreezeFrameType
	{
		Local,
		Global,
		Personalize
	}

	public enum HurtAnimType
	{
		None,
		Small,
		Large
	}

	[Serializable]
	public class HitDamageIdData
	{
		public FP duration;

		public int HitDamageId;

		public HitDamageIdData()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
				_ = 3819791961886430255L;
				/*Error near IL_000a: Unknown opcode: 0xB2*/;
			}
		}
	}

	public static readonly HitBoxFeatureData defaultFeatureData;

	public const int hitableLayerMask = 151808;

	public LogicEntity owner;

	public IHitBoxContext context;

	[Space]
	public FeatureFlag featureFlags;

	public HitBoxFeatureData featureData;

	private int _id;

	private List<HitDamageIdData> _HitDamageIdDatas;

	[Space]
	public HurtAnimType hurtAnimType;

	public GameObject hurtEffectSource;

	protected readonly List<DeterministicCollider> _hitTargets;

	protected AkWeaponHitSwitch weaponTrigger;

	protected bool canWeaponTrigger;

	public AdventureActor actor;

	private const float DefaultDuarationTime = 0.2f;

	public int hitDamageId
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Expected I4, but got Unknown
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
			case 39:
				/*Error: Invalid branch target*/;
			}
		}
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public AdventureActor Actor
	{
		get
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
	}

	public Shape hitBoxShape
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

	public FP hitBoxWidth
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

	public FP hitBoxLength
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

	public FP hitBoxRadius
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

	public FP hitBoxInnerRadius
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

	public FP hitBoxAngle
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

	public TSVector2 hitPos
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

	private void Awake()
	{
		/*Error near IL_0001: Unknown opcode: 0xEA*/;
	}

	public void initHitDamageIdData(HitDamageIdData[] _hitDamageIdDatas)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: ldloca 248 (out-of-bounds)*/;
			/*Error near IL_0003: Not a type handle*/;
		}
	}

	public unsafe static HitBox Setup(GameObject gameObject, LogicEntity owner, IHitBoxContext context)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) == 0)
		{
			/*Error: Invalid branch target*/;
		}
		_ = *(short*)checked((int)/*Error near IL_0004: Stack underflow*/);
		_ = 6;
		/*Error near IL_0006: Invalid metadata token*/;
	}

	public bool RectangleAreaHit(FP width, FP length, TSVector2 pos, FP rot, out int hittedCount, out int damageCount, int uniqueAttackId, GameObject hurtEffectPrefab = null, bool isHittedEffectScale = true, int layerMask = -5, FP damageImmuneDuration = default(FP), bool randomHit = false, Action<AdventureActor> cb = null, bool effectIgnoreTimeScale = true)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	public bool CircleAreaHit(FP radius, FP innerRadius, TSVector2 pos, out int hittedCount, out int damageCount, int uniqueAttackId, GameObject hurtEffectPrefab = null, bool isHittedEffectScale = true, int layerMask = -5, FP damageImmuneDuration = default(FP), bool randomHit = false, bool effectIgnoreTimeScale = true)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid calli metadata token*/;
		}
	}

	public bool FanAreaHit(FP angle, FP radius, FP innerRadius, TSVector2 pos, FP rot, out int hittedCount, out int damageCount, int uniqueAttackId, GameObject hurtEffectPrefab = null, bool isHittedEffectScale = true, FP damageImmuneDuration = default(FP), bool effectIgnoreTimeScale = true)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0002: Unknown opcode: 0xF3*/;
		}
	}

	public bool HitTargets(int uniqueAttackId, List<DeterministicCollider> hitTargets, out int hittedCount, out int damageCount, ref DeterministicRaycastHit raycastHit, GameObject hurtEffectPrefab, bool isHittedEffectScale, FP damageImmuneDuration = default(FP), bool randomHit = false, Action<AdventureActor> cb = null, bool effectIgnoreTimeScale = true)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	private bool CheckActorTargetValidated(LogicEntity target)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected I4, but got Unknown
		return (byte)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/) != 0;
	}

	public bool HitSingleTarget(int uniqueAttackId, DeterministicCollider hitTarget, out bool hitted, out bool damaged, ref DeterministicRaycastHit raycastHit, GameObject hurtEffectPrefab, bool isHittedEffectScale = true, FP damageImmuneDuration = default(FP), int onceAttackTargetCount = 1, bool effectIgnoreTimeScale = true)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public bool _HitSingleTarget(int uniqueAttackId, DeterministicCollider hitTarget, out bool hitted, out bool damaged, ref DeterministicRaycastHit raycastHit, GameObject hurtEffectPrefab, bool isHittedEffectScale = true, FP damageImmuneDuration = default(FP), int onceAttackTargetCount = 1, Action<AdventureActor> cb = null, bool effectIgnoreTimeScale = true)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public bool HitActor(int uniqueAttackId, int onceAttackTargetCount, AdventureActor adventureActor, ref DeterministicRaycastHit raycastHit, out bool damaged, GameObject hurtEffectPrefab, bool isHittedEffectScale, out bool iDamageImmuneDuration, FP damageImmuneDuration = default(FP), Action<AdventureActor> cb = null, bool effectIgnoreTimeScale = true)
	{
		/*Error: Unknown opcode: 0xE3*/;
	}

	protected bool PreProcessHitBoxFeatureFlags(AdventureActor adventureActor, GameObject hurtEffectPrefab = null, bool isHittedEffectScale = true, bool effectIgnoreTimeScale = true)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected I4, but got Unknown
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
		case 39:
			/*Error: Invalid branch target*/;
		case 40:
			/*Error: Invalid branch target*/;
		case 41:
			/*Error: Invalid branch target*/;
		case 42:
			/*Error: Invalid branch target*/;
		case 43:
			/*Error: Invalid branch target*/;
		case 44:
			/*Error: Invalid branch target*/;
		}
	}

	protected void PostProcessHitBoxFeatureFlags(AdventureActor adventureActor, bool damaged)
	{
	}

	public bool CheckWithInRing(LogicEntity entity)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xA6*/;
		}
	}

	public unsafe void HitWithCollider(DeterministicCollider deterministicCollider, GameObject hurtEffectPrefab, FP _damageImmuneDuration = default(FP))
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0002: Invalid metadata token*/;
	}

	public HitBox()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid calli metadata token*/;
		}
	}

	static HitBox()
	{
		/*Error: Invalid metadata token*/;
	}
}
