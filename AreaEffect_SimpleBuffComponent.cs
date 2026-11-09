using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Game/Adventure/AreaEffect/AreaEffectComponents/区域效果组件_Buff(简易)")]
[RequireComponent(typeof(AreaEffectEntity))]
public class AreaEffect_SimpleBuffComponent : AreaEffect_Component
{
	public List<int> buffIdList;

	public TargetFilterCriteriaInfo criteriaInfo;

	public bool ignoreTargetSearchableState;

	protected override void OnDeterministicCollisionEnter(LogicEntity entity)
	{
		//Discarded unreachable code: IL_007e
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (nuint)/*Error near IL_0007: Stack underflow*/ + 1689679149;
		}
	}

	protected override void OnDeterministicCollisionExit(LogicEntity entity)
	{
		//Discarded unreachable code: IL_007e
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (nuint)/*Error near IL_0007: Stack underflow*/ + 1689679149;
		}
	}

	public AreaEffect_SimpleBuffComponent()
	{
		/*Error: Invalid field token*/;
	}
}
