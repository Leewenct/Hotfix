using System.Collections.Generic;
using TrueSync;
using UnityEngine;

[AddComponentMenu("游戏/冒险模块/武器特性/阻挡子弹")]
[DisallowMultipleComponent]
public class WeaponFeatureBlockBullet : WeaponFeature
{
	public HitBox.Shape shape;

	public FP width;

	public FP length;

	public FP radius;

	public FP innerRadius;

	public FP angle;

	public FP rotation;

	public TSVector2 offset;

	public TargetType targetType;

	public GameObject finishPrefab;

	protected DeterministicShape _deterministicShape;

	protected List<DeterministicCollider> _bulletCollider;

	public override void OnActive()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_ = checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) << 0;
		/*Error near IL_0003: ldloc 1 (out-of-bounds)*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public override void OnUpdate()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
		_ = -0;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	protected void GetAllBulletByArea()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected I4, but got Unknown
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

	public WeaponFeatureBlockBullet()
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
