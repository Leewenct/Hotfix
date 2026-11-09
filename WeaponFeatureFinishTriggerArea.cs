using TrueSync;
using UnityEngine;

[AddComponentMenu("游戏/冒险模块/武器特性/完结时触发区域效果")]
public class WeaponFeatureFinishTriggerArea : WeaponFeature
{
	[Space]
	public GameObject areaEffectPrefab;

	public bool notSyncWeaponRotation;

	private FP _defaultTerrainHeight;

	public override void OnStart()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_ = checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) >> 0;
		/*Error near IL_0003: ldloc 1 (out-of-bounds)*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public override bool OnEnd()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0001: stloc 2 (out-of-bounds)*/;
		_ = ((uint[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/];
		/*Error near IL_0006: Invalid metadata token*/;
	}

	private void OnExceute()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		_ = checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) % 0;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public WeaponFeatureFinishTriggerArea()
	{
		/*Error: Invalid field token*/;
	}
}
