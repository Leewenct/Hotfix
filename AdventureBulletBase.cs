using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TrueSync;
using UnityEngine;
using UnityEngine.Serialization;

public class AdventureBulletBase : AdventureWeapon
{
	[Space]
	[FormerlySerializedAs("_damageArea")]
	public FP damageArea;

	[Space]
	public GameObject finishPrefab;

	[HideInInspector]
	public bool isPlayFinishPrefab;

	private LogicEntity _target;

	protected AimType _aimType;

	[HideInInspector]
	public long tagUid;

	protected BulletFinishReason _finishReason;

	public FP damageImmuneDurationForMonsterWeapon;

	protected FP _delayShootTimer;

	public LogicEntity target
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected I4, but got Unknown
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
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public TSVector2 targetPosition
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public FP targetPositionY
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public AimType aimType
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	public int BulletHashCode
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	public bool useDamageImmuneDurationForMonsterWeapon
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
				_ = 0;
				/*Error near IL_0002: Unknown opcode: 0xBE*/;
			}
		}
	}

	public override bool isValid
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected I4, but got Unknown
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
			}
		}
	}

	public bool isFinished
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public List<WeaponFeature> features
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	public override bool isShootableWeapon
	{
		get
		{
			/*Error: Unknown opcode: 0xC0*/;
		}
	}

	public FP delayShoot
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	protected FP GetDamageArea()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected I4, but got Unknown
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

	public unsafe override void Setup(LogicEntity owner = null, TSVector2 position = default(TSVector2), FP positionY = default(FP), TSVector2 direction = default(TSVector2), LogicEntity target = null, TSVector2 targetPosition = default(TSVector2), FP targetPositionY = default(FP), AimType aimType = AimType.Default)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		System.Runtime.CompilerServices.Unsafe.Read<object>((void*)checked((short)/*Error near IL_0007: Stack underflow*/));
		/*Error near IL_0008: ldloc 2 (out-of-bounds)*/;
		/*Error near IL_0009: stloc 2 (out-of-bounds)*/;
		/*Error near IL_000a: Unknown opcode: 0xBD*/;
	}

	protected override void OnInit()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/+ 0;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	protected override void OnActive()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) * 0;
			/*Error near IL_0003: ldloc 1 (out-of-bounds)*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	protected override void OnDeactive()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/- 0;
			/*Error near IL_0003: ldloc 1 (out-of-bounds)*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public unsafe override void Reset(LogicEntity owner = null, TSVector2 position = default(TSVector2), FP positionY = default(FP), TSVector2 direction = default(TSVector2), LogicEntity target = null, TSVector2 targetPosition = default(TSVector2), FP targetPositionY = default(FP))
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		System.Runtime.CompilerServices.Unsafe.Read<object>((void*)checked((short)/*Error near IL_0007: Stack underflow*/));
		_ = null;
		/*Error near IL_0009: stloc 2 (out-of-bounds)*/;
		/*Error near IL_000a: Unknown opcode: 0xBD*/;
	}

	public override void Finish(bool cancel = false, bool catched = false, bool ignorFinishFX = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 4 (out-of-bounds)*/;
			/*OpCode not supported: DebugBreak*/;
			_ = (short)/*Error near IL_0005: Stack underflow*/;
			/*Error near IL_0005: Unknown opcode: 0xE3*/;
		}
	}

	public void Kill(bool cancel = false, bool catched = false, bool ignorFinishFX = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0uL;
			_ = -743176178;
			/*Error near IL_000c: Unknown opcode: 0xE8*/;
		}
	}

	protected override void OnLogicStart()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
		}
	}

	protected override void OnLogicUpdate()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid branch target*/;
		}
	}

	public WeaponFeature QueryAttachedWeaponFeature(Type featureType)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xCC*/;
		}
	}

	public WeaponFeature AttachWeaponFeature(Type featureType, int initLevel = 1)
	{
		/*Error: Invalid metadata token*/;
	}

	public void RemoveWeaponFeature(Type featureType)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xCC*/;
		}
	}

	public bool CheckFinishByWeaponFeature()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid branch target*/;
		}
	}

	protected bool DelayShootUpdate()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected I4, but got Unknown
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
		}
	}

	public override bool OnHitActor(HitBox hitBox, int uniqueAttackId, int onceAttackTargetCount, LogicEntity actor, ref DeterministicRaycastHit raycastHit, out bool damaged, GameObject hurtEffectPrefab, bool isHittedEffectScale = true, bool effectIgnoreTimeScale = true)
	{
		/*Error: Unknown opcode: 0xE3*/;
	}

	public unsafe override bool OnHitShield(HitBox hitBox, AdventureWeapon shield, ref DeterministicRaycastHit raycastHit)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0002: Unknown opcode: 0xCA*/;
	}

	public unsafe override bool OnHitObstacle(HitBox hitBox, AdventureObstacle obstacle, ref DeterministicRaycastHit raycastHit)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0002: Unknown opcode: 0xCA*/;
	}

	public override bool OnHitDestructibleObstacle(HitBox hitBox, int uniqueAttackId, int onceAttackTargetCount, LogicEntity actor, ref DeterministicRaycastHit raycastHit, out bool damaged, GameObject hurtEffectPrefab, bool isHittedEffectScale, bool effectIgnoreTimeScale = true)
	{
		/*Error: Unknown opcode: 0xE3*/;
	}

	public AdventureBulletBase()
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
