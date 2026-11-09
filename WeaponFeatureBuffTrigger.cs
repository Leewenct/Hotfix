using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("游戏/冒险模块/武器特性/Buff添加移除(碰撞触发)")]
public class WeaponFeatureBuffTrigger : WeaponFeature, IDeterministicCollisionListener
{
	[SerializeField]
	public List<BuffConfig> buffConfigs;

	private List<DeterministicCollider> _collisionDetectList;

	public override void OnStart()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_ = checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) >> 0;
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

	public unsafe void OnDeterministicCollisionEnter(DeterministicCollider other)
	{
		//Discarded unreachable code: IL_001c, IL_003f
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
		_ = ((ushort[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/];
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public void OnDeterministicCollisionStay(DeterministicCollider other)
	{
	}

	public unsafe void OnDeterministicCollisionExit(DeterministicCollider other)
	{
		//Discarded unreachable code: IL_001c
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
		_ = ((ushort[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/];
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public WeaponFeatureBuffTrigger()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_000d: Stack underflow*/+ (/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/>> 498317791);
			/*Error near IL_000d: Invalid branch target*/;
		}
	}
}
