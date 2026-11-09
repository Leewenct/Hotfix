using TrueSync;
using UnityEngine;

[AddComponentMenu("Game/Adventure/AreaEffect/AreaEffectComponents/区域效果组件_修改子弹移动速度")]
[RequireComponent(typeof(AreaEffectEntity))]
public class AreaEffect_ModifyBulletSpeedComponent : AreaEffect_Component
{
	public TargetFilterCriteriaInfo criteriaInfo;

	public FP modifySpeedPercent;

	public bool modifyBulletDamage;

	public int additionalAttrId;

	public GameObject triggerFx;

	protected override void OnDeterministicCollisionEnter(LogicEntity entity)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((nint)/*Error near IL_0009: Stack underflow*/ <= (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/))
		{
			/*Error near IL_0009: Unknown opcode: 0xBD*/;
		}
		/*Error near IL_0014: Unknown opcode: 0xEE*/;
	}

	public AreaEffect_ModifyBulletSpeedComponent()
	{
		/*Error: Invalid field token*/;
	}
}
