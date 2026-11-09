using System;
using System.Runtime.CompilerServices;
using TrueSync;

public sealed class SpecialAttributeList : ICloneable
{
	public delegate void ValueChangedHandle(HotfixEnum.specialAttributeType attributeType, HotfixEnum.parameterType parameterType, FDP old, FDP current);

	[CompilerGenerated]
	private ValueChangedHandle m_ValueChangedEvent;

	private readonly SpecialAttributeEntry[] entries;

	public event ValueChangedHandle ValueChangedEvent
	{
		[CompilerGenerated]
		add
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected I4, but got Unknown
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
			case 5:
				/*Error: Invalid branch target*/;
			case 6:
				/*Error: Invalid branch target*/;
			case 7:
				/*Error: Invalid branch target*/;
			}
		}
		[CompilerGenerated]
		remove
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected I4, but got Unknown
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
			case 5:
				/*Error: Invalid branch target*/;
			case 6:
				/*Error: Invalid branch target*/;
			case 7:
				/*Error: Invalid branch target*/;
			}
		}
	}

	public SpecialAttributeList()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_003F val = checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		if (/*Error near IL_0005: Stack underflow*/ > val + val)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: Invalid metadata token*/;
	}

	public FDP GetAttributeValue(HotfixEnum.specialAttributeType type)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: ldloca 207 (out-of-bounds)*/;
			/*Error near IL_0003: Invalid metadata token*/;
		}
	}

	private void SetAttributeMaxType(HotfixEnum.specialAttributeType type, HotfixEnum.effectAttributeType type1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: ldloca 207 (out-of-bounds)*/;
			/*Error near IL_0003: Invalid metadata token*/;
		}
	}

	public void SetAttributeValue(AttributeList attributeList, HotfixEnum.specialAttributeType type, HotfixEnum.parameterType subType, FDP value)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: ldloca 207 (out-of-bounds)*/;
			/*Error near IL_0004: Unknown opcode: 0xF7*/;
		}
	}

	public object Clone()
	{
		/*Error: Invalid field token*/;
	}
}
