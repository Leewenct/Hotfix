using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TrueSync;
using UnityEngine;

[AddComponentMenu("游戏/冒险模块/武器/区域激光型子弹")]
public class AdventureAreaLaser : AdventureBulletBase
{
	[Space]
	public FP hitTestInterval;

	public List<LaserLevelConfig> levelConfigs;

	protected Vector3 _endPointPosition3D;

	protected Vector3 _startPointPosition3D;

	protected AdventureFXPlayer _linkFx;

	protected GameObject _hittedPrefab;

	protected FP _laserWidth;

	protected FP _laserLength;

	protected bool _configValid;

	protected TSVector2 _localDirection;

	protected TSVector2 _localStartPosition;

	protected Action<AdventureActor> hitCallback;

	private TSVector2 offset;

	private LaserLevelConfig config;

	private AdventureActor lastTarget;

	public unsafe override void Setup(LogicEntity owner = null, TSVector2 position = default(TSVector2), FP positionY = default(FP), TSVector2 direction = default(TSVector2), LogicEntity target = null, TSVector2 targetPosition = default(TSVector2), FP targetPositionY = default(FP), AimType aimType = AimType.Default)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		System.Runtime.CompilerServices.Unsafe.Read<object>((void*)checked((short)/*Error near IL_0007: Stack underflow*/));
		DeterministicRaycastHit deterministicRaycastHit = deterministicRaycastHit;
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

	public void SetLaserLevel(int level = 1)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	protected unsafe void SyncWithOwner()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected Obj, but got I4
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/), (object)0);
		checked
		{
			_ = (ushort)/*Error near IL_0004: Stack underflow*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public void RegisterHitAction(Action<AdventureActor> cb)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}

	protected override void OnLogicUpdate()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) < 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public override void Finish(bool cancel = false, bool catched = false, bool ignorFinishFX = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: Invalid field token*/;
	}

	public AdventureAreaLaser()
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
