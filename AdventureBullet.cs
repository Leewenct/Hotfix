using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TrueSync;
using UnityEngine;

[AddComponentMenu("游戏/冒险模块/武器/实体子弹")]
public class AdventureBullet : AdventureBulletBase
{
	public FP delayMove;

	public FP moveSpeed;

	public FP acceleratedVelocity;

	public FP borderVelocitySpeed;

	[Space]
	public FP lifeTime;

	[Space]
	public GameObject muzzleFlashPrefab;

	public GameObject hitPrefab;

	public GameObject hittedPrefab;

	public bool effectTimeScale;

	public GameObject fxPrefab;

	public GameObject trailPrefab;

	[Space]
	public AdventurePlayerFeedbackEffectConfigureData hitFeedbackEffectConfigureData;

	public FP damageImmuneDuration;

	[Space]
	public bool isRangeHit;

	[Space]
	public HitBox.Shape shape;

	[Space]
	public bool randomHit;

	[Space]
	public FP damageRadius;

	[Space]
	public FP damageHeight;

	[Space]
	public FP damageWidth;

	[Space]
	public FP fanInnerRadius;

	[Space]
	public FP fanOuterRadius;

	[Space]
	public FP fanAngle;

	public bool isAreaHit;

	public FP areaHitRadius;

	[Space]
	public bool _isShowShadowBlob;

	protected FP _delayTimer;

	protected FP _lifeTimer;

	protected FP _keepMoveToHitPointTime;

	protected bool _waitMoveToHitPoint;

	private bool _haveReflectFeature;

	private bool _haveHitAreaEffectFeature;

	private AdventureFXPlayer _fx;

	private long _fxToken;

	private const int hitableLayerMaskForActor = 256;

	private const int hitableLayerMaskForActorAndAreaEffect = 131328;

	private const int hitableLayerMaskWithoutAreaEffect = 20736;

	private const int hitableLayerMaskAll = 151808;

	protected int hitableLayerMask;

	protected readonly List<DeterministicRaycastHit> _hitInfos;

	public FP LiftTime
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

	public override bool iShowShadowBlob()
	{
		/*Error: Invalid field token*/;
	}

	public unsafe override void Setup(LogicEntity owner = null, TSVector2 position = default(TSVector2), FP positionY = default(FP), TSVector2 direction = default(TSVector2), LogicEntity target = null, TSVector2 targetPosition = default(TSVector2), FP targetPositionY = default(FP), AimType aimType = AimType.Default)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		System.Runtime.CompilerServices.Unsafe.Read<object>((void*)checked((short)/*Error near IL_0007: Stack underflow*/));
		int num = num;
		/*Error near IL_000a: Unknown opcode: 0xBD*/;
	}

	public unsafe override void Reset(LogicEntity owner = null, TSVector2 position = default(TSVector2), FP positionY = default(FP), TSVector2 direction = default(TSVector2), LogicEntity target = null, TSVector2 targetPosition = default(TSVector2), FP targetPositionY = default(FP))
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		_ = (short)System.Runtime.CompilerServices.Unsafe.Read<object>((void*)checked((short)/*Error near IL_0007: Stack underflow*/));
		/*Error near IL_0009: stloc 2 (out-of-bounds)*/;
		/*Error near IL_000a: Unknown opcode: 0xBD*/;
	}

	public void SetDelayMove(FP delayTime)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}

	public override void Finish(bool cancel = false, bool catched = false, bool _ignorFinishFX = false)
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

	protected override void OnLogicUpdate()
	{
		//Discarded unreachable code: IL_03e7, IL_03f5, IL_0597
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) < 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	private FP GetDamageRaiuds()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected I4, but got Unknown
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
		}
	}

	private FP GetDamageHeight()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected I4, but got Unknown
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
		}
	}

	private FP GetDamageWidth()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected I4, but got Unknown
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
		}
	}

	private FP GetDamageFanInnerRadius()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected I4, but got Unknown
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
		}
	}

	private FP GetDamageFanOuterRadius()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected I4, but got Unknown
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
		}
	}

	public virtual void Move(FP dt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xC9*/;
		}
	}

	public FP GetLeftTime()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: starg 134 (out-of-bounds)*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	private void OnIsRangeHitValueChange()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected I4, but got Unknown
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
		}
	}

	public AdventureBullet()
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
