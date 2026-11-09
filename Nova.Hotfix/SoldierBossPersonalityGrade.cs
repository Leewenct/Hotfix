using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Nova.Hotfix;

public sealed class SoldierBossPersonalityGrade : IMessage<SoldierBossPersonalityGrade>, IMessage, IEquatable<SoldierBossPersonalityGrade>, IDeepCloneable<SoldierBossPersonalityGrade>
{
	private static readonly MessageParser<SoldierBossPersonalityGrade> _parser;

	private UnknownFieldSet _unknownFields;

	public const int SoldierPersonalityGradeFieldNumber = 1;

	private int soldierPersonalityGrade_;

	public const int AdjustValueFieldNumber = 2;

	private string adjustValue_;

	public const int IconFieldNumber = 3;

	private string icon_;

	[DebuggerNonUserCode]
	public static MessageParser<SoldierBossPersonalityGrade> Parser
	{
		get
		{
			if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
			{
				/*Error: Invalid branch target*/;
			}
			_ = -1;
			/*Error: End of method reached without returning.*/;
		}
	}

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		get
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
	}

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor
	{
		get
		{
			_ = ((ushort[])/*Error near IL_0002: Stack underflow*/)[((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/]];
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	[DebuggerNonUserCode]
	public int SoldierPersonalityGrade
	{
		get
		{
			/*Error: Invalid field token*/;
		}
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	[DebuggerNonUserCode]
	public string AdjustValue
	{
		get
		{
			/*Error: Invalid field token*/;
		}
		set
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0006: Unknown opcode: 0xFD*/;
		}
	}

	[DebuggerNonUserCode]
	public string Icon
	{
		get
		{
			/*Error: Invalid field token*/;
		}
		set
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0006: Unknown opcode: 0xFD*/;
		}
	}

	[DebuggerNonUserCode]
	public unsafe SoldierBossPersonalityGrade()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(long*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xA7*/;
	}

	[DebuggerNonUserCode]
	public SoldierBossPersonalityGrade(SoldierBossPersonalityGrade other)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I
		if ((nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) < (nint)0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0008: Invalid metadata token*/;
	}

	[DebuggerNonUserCode]
	public SoldierBossPersonalityGrade Clone()
	{
		/*Error: Invalid field token*/;
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		/*Error near IL_0001: Unknown opcode: 0xF5*/;
	}

	[DebuggerNonUserCode]
	public bool Equals(SoldierBossPersonalityGrade other)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 205 (out-of-bounds)*/;
			/*Error near IL_0003: stloc 1 (out-of-bounds)*/;
			/*Error near IL_0004: Not a type handle*/;
		}
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		/*Error: Unknown opcode: 0xEC*/;
	}

	[DebuggerNonUserCode]
	public override string ToString()
	{
		/*Error: Invalid field token*/;
	}

	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0008: Stack underflow*/ < checked((/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) * 0))
		{
			/*Error: Invalid branch target*/;
		}
		if (/*Error near IL_000e: Stack underflow*/ >= /*Error near IL_000e: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_000e: Unknown opcode: 0xEF*/;
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(SoldierBossPersonalityGrade other)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 204 (out-of-bounds)*/;
			_ = -1;
			/*Error near IL_0004: Unknown opcode: 0xEF*/;
		}
	}

	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
		/*Error near IL_0001: Handle with invalid row number.*/;
	}

	unsafe static SoldierBossPersonalityGrade()
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xF5*/;
	}
}
