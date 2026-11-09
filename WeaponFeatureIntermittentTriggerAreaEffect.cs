using System.Collections.Generic;
using TrueSync;
using UnityEngine;

[AddComponentMenu("游戏/冒险模块/武器特性/间歇生成区域效果")]
public class WeaponFeatureIntermittentTriggerAreaEffect : WeaponFeature
{
	public bool isBindWeaponLifeCycle;

	public FP delay;

	public bool isIntermittent;

	public FP interval;

	[Space]
	public GameObject areaEffectPrefab;

	private FP _elapsed;

	private bool _isTriggered;

	private bool _isFinish;

	private List<long> _areaEffectIds;

	private FP _defaultTerrainHeight;

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
		/*Error near IL_0003: ldloc 1 (out-of-bounds)*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public override bool OnEnd()
	{
		//Discarded unreachable code: IL_0039
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	private void OnExecute()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		_ = checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) % 0;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public WeaponFeatureIntermittentTriggerAreaEffect()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
		_ = -6;
		/*Error near IL_0003: Unknown opcode: 0xCC*/;
	}
}
