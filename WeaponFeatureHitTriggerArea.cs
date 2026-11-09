using System;
using UnityEngine;

[AddComponentMenu("游戏/冒险模块/武器特性/命中时触发区域效果")]
[DisallowMultipleComponent]
public class WeaponFeatureHitTriggerArea : WeaponFeature
{
	public enum TriggerPositionType
	{
		Self,
		Target
	}

	public GameObject areaEffectPrefab;

	public int maxTriggerCount;

	public bool triggerWithMonster;

	public bool triggerWithPlayer;

	public bool triggerWithDestructibleObstacle;

	public bool triggerWithObstacle;

	public TriggerPositionType triggerPositionType;

	private int _maxTriggerCount;

	private int _triggerCount;

	public override void OnStart()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_ = checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) >> 0;
		/*Error near IL_0003: ldloc 1 (out-of-bounds)*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public override void OnActive()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		_ = /*Error near IL_0004: Stack underflow*/>> (int)(nint)((IntPtr[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/];
		/*Error near IL_0005: ldloc 0 (out-of-bounds)*/;
		/*Error near IL_0006: ldarg 102 (out-of-bounds)*/;
		/*Error near IL_0008: Invalid metadata token*/;
	}

	private void Exceute(LogicEntity target)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		_ = ((sbyte[])checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))[0];
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	private bool HaveTriggerCount()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected I4, but got Unknown
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

	public unsafe override bool OnHitActor(LogicEntity actor, ref DeterministicRaycastHit raycastHit)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		_ = 8;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public override bool OnHitObstacle(AdventureObstacle obstacle, ref DeterministicRaycastHit raycastHit)
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

	public WeaponFeatureHitTriggerArea()
	{
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0002: Invalid metadata token*/;
	}
}
