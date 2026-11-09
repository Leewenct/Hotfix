using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Nova.Hotfix;

public sealed class TraceHuntScoreSwitch : IMessage<TraceHuntScoreSwitch>, IMessage, IEquatable<TraceHuntScoreSwitch>, IDeepCloneable<TraceHuntScoreSwitch>
{
	private static readonly MessageParser<TraceHuntScoreSwitch> _parser;

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int GroupIdFieldNumber = 2;

	private int groupId_;

	public const int LvFieldNumber = 3;

	private int lv_;

	public const int SwitchRateFieldNumber = 4;

	private float switchRate_;

	[DebuggerNonUserCode]
	public static MessageParser<TraceHuntScoreSwitch> Parser
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
			_ = ((double[])/*Error near IL_0002: Stack underflow*/)[((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/]];
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	[DebuggerNonUserCode]
	public int Id
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
	public int GroupId
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
	public int Lv
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
	public float SwitchRate
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
	public TraceHuntScoreSwitch()
	{
	}

	[DebuggerNonUserCode]
	public unsafe TraceHuntScoreSwitch(TraceHuntScoreSwitch other)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
		System.Runtime.CompilerServices.Unsafe.Read<object>((void*)0L);
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	[DebuggerNonUserCode]
	public TraceHuntScoreSwitch Clone()
	{
		/*Error: Invalid field token*/;
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		/*Error near IL_0001: Unknown opcode: 0xF5*/;
	}

	[DebuggerNonUserCode]
	public bool Equals(TraceHuntScoreSwitch other)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 205 (out-of-bounds)*/;
			/*Error near IL_0003: stloc 1 (out-of-bounds)*/;
			/*Error near IL_0004: Invalid metadata token*/;
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
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			System.Runtime.CompilerServices.Unsafe.Read<object>(null);
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(TraceHuntScoreSwitch other)
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0003: Not a type handle*/;
	}

	unsafe static TraceHuntScoreSwitch()
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xF1*/;
	}
}
