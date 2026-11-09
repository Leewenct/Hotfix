using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.Protobuf.Collections;
using Nova.Client;
using TrueSync;

public sealed class AttributeList
{
	public delegate void ValueChangedHandle(HotfixEnum.effectAttributeType attributeType, HotfixEnum.parameterType parameterType, FDP old, FDP diff);

	private class Limit
	{
		public bool IsLimited;

		public bool OnlyLimitPlayer;

		public bool IsLimitedForPercent;

		public bool OnlyLimitPlayerForPercent;

		public FDP Lower
		{
			[CompilerGenerated]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		public FDP Upper
		{
			[CompilerGenerated]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		public FDP LowerForPercent
		{
			[CompilerGenerated]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		public FDP UpperForPercent
		{
			[CompilerGenerated]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		public Limit()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			if (/*Error near IL_0006: Stack underflow*/ != checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0006: Unknown opcode: 0xF0*/;
		}

		public Limit(bool isLimited, FDP low, FDP up, bool onlyLimitPlayer, bool isLimitedForPercent, FDP lowForPercent, FDP upForPercent, bool onlyLimitPlayerForPercent)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			if (/*Error near IL_0006: Stack underflow*/ != checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0006: Unknown opcode: 0xF0*/;
		}
	}

	[CompilerGenerated]
	private ValueChangedHandle m_ValueChangedEvent;

	private readonly AttributeEntry[] entries;

	private readonly Dictionary<HotfixEnum.effectAttributeType, FDP> assignmentValueDict;

	private bool isBelongToPlayer;

	private static readonly Limit[] limits;

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

	private static Limit GetLimit(HotfixEnum.effectAttributeType type)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: ldloca 208 (out-of-bounds)*/;
			/*OpCode not supported: DebugBreak*/;
			/*Error near IL_0004: Unknown opcode: 0xF3*/;
		}
	}

	public bool IsAttributeAssignment(HotfixEnum.effectAttributeType type)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: ldloca 208 (out-of-bounds)*/;
			/*Error near IL_0003: Not a type handle*/;
		}
	}

	public void Init(bool belongToPlayer = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (ulong)/*Error near IL_0007: Stack underflow*/;
			_ = -490319360;
			/*Error near IL_000c: Invalid metadata token*/;
		}
	}

	private static FDP ComputeAdjustValue(int val, FDP ratio, int fix)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = (sbyte)0;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	private static FDP ComputeAdjustValue(long val, FDP ratio, long fix)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) != 0)
		{
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
		_ = 0;
		/*Error near IL_0006: Unknown opcode: 0xF3*/;
	}

	public FDP GetAttributeValue(HotfixEnum.effectAttributeType type)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: ldloca 208 (out-of-bounds)*/;
			/*Error near IL_0003: Not a type handle*/;
		}
	}

	public void CopyValueFrom(AttributeList from)
	{
		//Discarded unreachable code: IL_0054
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected I4, but got Unknown
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		int num = (int)checked(/*Error near IL_0008: Stack underflow*/ + (ulong)/*Error near IL_0007: Stack underflow*/);
		/*Error near IL_0009: ldarg 2 (out-of-bounds)*/;
		/*Error near IL_000a: Unknown opcode: 0xAF*/;
	}

	public void AddValueFrom(AttributeList from)
	{
		//Discarded unreachable code: IL_0049
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected I4, but got Unknown
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		int num = (int)checked(/*Error near IL_0008: Stack underflow*/ + (ulong)/*Error near IL_0007: Stack underflow*/);
		/*Error near IL_0009: ldarg 2 (out-of-bounds)*/;
		/*Error near IL_000a: Unknown opcode: 0xAF*/;
	}

	public void Clear()
	{
		/*Error: Unknown opcode: 0xEC*/;
	}

	public void SetOriginIntValue(HotfixEnum.effectAttributeType type, int val, FDP ratio)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: ldloca 208 (out-of-bounds)*/;
			/*Error near IL_0003: Not a type handle*/;
		}
	}

	public void SetOriginFloatValue(HotfixEnum.effectAttributeType type, FDP val, FDP ratio)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: ldloca 208 (out-of-bounds)*/;
			/*Error near IL_0003: Not a type handle*/;
		}
	}

	public void SetOriginLongValue(HotfixEnum.effectAttributeType type, long val, FDP ratio)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: ldloca 208 (out-of-bounds)*/;
			/*Error near IL_0003: Not a type handle*/;
		}
	}

	public FDP GetOriginValue(HotfixEnum.effectAttributeType type)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: ldloca 208 (out-of-bounds)*/;
			/*Error near IL_0003: Not a type handle*/;
		}
	}

	public FDP GetBaseValue(HotfixEnum.effectAttributeType type)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: ldloca 208 (out-of-bounds)*/;
			/*Error near IL_0003: Not a type handle*/;
		}
	}

	public void SetAmendValue(HotfixEnum.effectAttributeType type, HotfixEnum.parameterType subType, FDP val)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: ldloca 208 (out-of-bounds)*/;
			/*Error near IL_0003: Not a type handle*/;
		}
	}

	public FDP GetAmendValue(HotfixEnum.effectAttributeType type, HotfixEnum.parameterType subType, bool applyPercentLimit = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: ldloca 208 (out-of-bounds)*/;
			/*Error near IL_0003: Not a type handle*/;
		}
	}

	public void SetOriginIntValueAdjust(HotfixEnum.effectAttributeType type, int val, FDP ratio, int adjustRatio, int adjustFix)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: ldloca 208 (out-of-bounds)*/;
			/*Error near IL_0003: Not a type handle*/;
		}
	}

	public void SetOriginLongValueAdjust(HotfixEnum.effectAttributeType type, long val, FDP ratio, int adjustRatio, long adjustFix)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: ldloca 208 (out-of-bounds)*/;
			/*Error near IL_0003: Not a type handle*/;
		}
	}

	public void SetOriginIntFloatValue(HotfixEnum.effectAttributeType type, int val, FDP ratio)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: ldloca 208 (out-of-bounds)*/;
			/*Error near IL_0003: Not a type handle*/;
		}
	}

	public void ChangeValue(int firstSubType, int secondSubType, FDP value)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0003: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		_ = 0;
		/*Error near IL_0004: Unknown opcode: 0xE9*/;
	}

	public void ChangeAssignmentValue(int firstSubType, int secondSubType, FDP value, bool assign)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0003: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		_ = 0;
		/*Error near IL_0004: Unknown opcode: 0xE9*/;
	}

	public FDP GetHarmElementValue(HotfixEnum.elementType type)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid calli metadata token*/;
		}
	}

	public FDP GetResistanceElementValue(HotfixEnum.elementType type)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid calli metadata token*/;
		}
	}

	public FDP GetPentrateElementValue(HotfixEnum.elementType type)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid calli metadata token*/;
		}
	}

	public FDP GetIgnoringInjuredElementValue(HotfixEnum.elementType type)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid calli metadata token*/;
		}
	}

	public FDP GetInjuredElementValue(HotfixEnum.elementType type)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid calli metadata token*/;
		}
	}

	public void CopyOwnerValue(AttributeList owner, FDP ratio)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 204 (out-of-bounds)*/;
			_ = -1;
			/*Error near IL_0004: Unknown opcode: 0xFB*/;
		}
	}

	public unsafe void WriteMessage(RepeatedField<Attribute> attributes)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
		_ = 1;
		/*Error near IL_0003: Invalid metadata token*/;
	}

	public AttributeList()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = -6700757505130772948L;
			/*Error near IL_000a: Unknown opcode: 0xB1*/;
		}
	}

	static AttributeList()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Expected F8, but got Unknown
		_003F val = /*Error near IL_0003: Stack underflow*/<< -41;
		((double[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/] = (double)val;
		if (/*Error near IL_000a: Stack underflow*/ <= /*Error near IL_000a: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_000a: Unknown opcode: 0xC8*/;
	}
}
