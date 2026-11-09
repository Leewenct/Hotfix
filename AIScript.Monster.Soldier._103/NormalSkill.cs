namespace AIScript.Monster.Soldier._103;

public class NormalSkill : SkillAdvancedBase
{
	private string actionKey;

	protected override void OnSkillEnable()
	{
		/*Error: Invalid field token*/;
	}

	protected override void OnSkillDisable()
	{
		/*Error: Invalid field token*/;
	}

	public void OnStart()
	{
		/*Error: Read out of bounds.*/;
	}

	protected void OnFinish()
	{
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}

	protected void OnInterrupt()
	{
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}

	public void OnUpdate()
	{
	}

	private void DoMainLogic()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = /*Error near IL_0008: Stack underflow*/^ (ulong)/*Error near IL_0007: Stack underflow*/;
			/*Error near IL_0008: Unknown opcode: 0xFE2C*/;
		}
	}

	private void onCustomEvent(string evt)
	{
	}

	public unsafe NormalSkill()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected I4, but got I8
		*(sbyte*)(nint)/*Error near IL_0003: Stack underflow*/ = (sbyte)(*(long*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0003: ldloc 3 (out-of-bounds)*/;
		/*Error near IL_0004: Unknown opcode: 0xE6*/;
	}
}
