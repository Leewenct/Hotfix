public class TriggerLevelFinish : TriggerConditionBase
{
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

	protected override void OnDeactive()
	{
		/*Error: Invalid field token*/;
	}

	private unsafe void OnLevelFinish(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(short*)(int)(*(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0003: Invalid field token*/;
	}

	public TriggerLevelFinish()
	{
		/*Error: Invalid field token*/;
	}
}
