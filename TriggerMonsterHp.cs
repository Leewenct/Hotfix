public class TriggerMonsterHp : TriggerConditionBase
{
	public enum HpType
	{
		Greater,
		Less
	}

	public int monsterID;

	public HpType hpType;

	public int hpPencent;

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

	protected unsafe override void OnDeactive()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected I8, but got I4
		*(long*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) = 0L;
		checked
		{
			_ = (ushort)/*Error near IL_0004: Stack underflow*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	private unsafe void OnHpChanged(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (short)(*unchecked((int*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)));
			/*Error near IL_0003: Invalid field token*/;
		}
	}

	public TriggerMonsterHp()
	{
		/*Error: Invalid field token*/;
	}
}
