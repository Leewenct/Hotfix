using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Nova.Hotfix;

public sealed class table_PeriodicQuestGroup : IMessage<table_PeriodicQuestGroup>, IMessage, IEquatable<table_PeriodicQuestGroup>, IDeepCloneable<table_PeriodicQuestGroup>
{
	private static readonly MessageParser<table_PeriodicQuestGroup> _parser;

	private UnknownFieldSet _unknownFields;

	public const int ListFieldNumber = 1;

	private static readonly FieldCodec<PeriodicQuestGroup> _repeated_list_codec;

	private readonly RepeatedField<PeriodicQuestGroup> list_;

	[DebuggerNonUserCode]
	public static MessageParser<table_PeriodicQuestGroup> Parser
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
			checked
			{
				_ = (nint)unchecked((int)((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/]);
				/*Error near IL_0002: Read out of bounds.*/;
			}
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<PeriodicQuestGroup> List
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	[DebuggerNonUserCode]
	public unsafe table_PeriodicQuestGroup()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(IntPtr*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Invalid metadata token*/;
	}

	[DebuggerNonUserCode]
	public unsafe table_PeriodicQuestGroup(table_PeriodicQuestGroup other)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		*(IntPtr*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) = (IntPtr)0;
		/*Error near IL_0003: Unknown opcode: 0xBF*/;
	}

	[DebuggerNonUserCode]
	public table_PeriodicQuestGroup Clone()
	{
		/*Error: Invalid field token*/;
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		/*Error near IL_0001: Unknown opcode: 0xF5*/;
	}

	[DebuggerNonUserCode]
	public bool Equals(table_PeriodicQuestGroup other)
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
		//IL_0026: Expected I4, but got Unknown
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

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(table_PeriodicQuestGroup other)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 204 (out-of-bounds)*/;
			_ = -1;
			/*Error near IL_0004: Unknown opcode: 0xEE*/;
		}
	}

	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
		/*Error near IL_0003: Not a type handle*/;
	}

	unsafe static table_PeriodicQuestGroup()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c->IL000c: Incompatible stack heights: 1 vs 0
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		if (/*Error near IL_0006: Stack underflow*/ < /*Error near IL_0006: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		checked
		{
			_ = (nuint)/*Error near IL_0007: Stack underflow*/;
			/*Error near IL_0007: stloc 3 (out-of-bounds)*/;
			if (/*Error near IL_000a: Stack underflow*/ > /*Error near IL_000a: Stack underflow*/)
			{
				_ = /*Error near IL_000c: Stack underflow*/+ (short)/*Error near IL_000b: Stack underflow*/;
			}
			/*Error near IL_000c: Invalid field token*/;
		}
	}
}
