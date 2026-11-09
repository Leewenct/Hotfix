using UnityEngine;

[AddComponentMenu("Game/Adventure/AreaEffect/AreaEffectComponents/区域效果组件_阻挡飞行道具和武器")]
[RequireComponent(typeof(AreaEffectEntity))]
[DisallowMultipleComponent]
public class AreaEffect_BlockBulletComponent : AreaEffect_Component
{
	public TargetFilterCriteriaInfo criteriaInfo;

	public GameObject finishPrefab;

	public int blockCount;

	public bool finishWhenBlockEmpty;

	private int _blockCount;

	private bool BlockFinish
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected I4, but got Unknown
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

	protected override void OnSetup()
	{
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0002: Unknown opcode: 0xAC*/;
	}

	public override void OnDeactive()
	{
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0002: Unknown opcode: 0xB2*/;
	}

	protected override void OnDeterministicCollisionEnter(LogicEntity entity)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (ulong)((nuint)/*Error near IL_0007: Stack underflow*/ * 1689922860);
			/*Error near IL_000e: Unknown opcode: 0xE4*/;
		}
	}

	public AreaEffect_BlockBulletComponent()
	{
		/*Error: Invalid field token*/;
	}
}
