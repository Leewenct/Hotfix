using TrueSync;
using UnityEngine;

public class TriggerMonsterAttr : TriggerConditionBase
{
	public enum monsterType
	{
		[InspectorName("指定关系")]
		selectType,
		[InspectorName("指定ID")]
		selectId
	}

	public enum relatiobShip
	{
		[InspectorName("敌对")]
		ennemyType,
		[InspectorName("友好")]
		frendelyType
	}

	public int monsterID;

	public FP _compareHp;

	private FDP _compareHpFDP;

	public override void ToActive()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = (ushort)0;
			/*Error near IL_0003: ldarga 236 (out-of-bounds)*/;
			/*Error near IL_0006: Invalid metadata token*/;
		}
	}

	public override void DisableTrigger()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected unsafe void OnActorHpChanged(IEvent ievent)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (byte)(*unchecked((uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)));
			/*Error near IL_0003: Invalid field token*/;
		}
	}

	public TriggerMonsterAttr()
	{
		/*Error: Invalid field token*/;
	}
}
