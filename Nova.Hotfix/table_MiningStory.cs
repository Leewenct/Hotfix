using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Nova.Hotfix;

public sealed class table_MiningStory : IMessage<table_MiningStory>, IMessage, IEquatable<table_MiningStory>, IDeepCloneable<table_MiningStory>
{
	private static readonly MessageParser<table_MiningStory> _parser;

	private UnknownFieldSet _unknownFields;

	public const int ListFieldNumber = 1;

	private static readonly FieldCodec<MiningStory> _repeated_list_codec;

	private readonly RepeatedField<MiningStory> list_;

	[DebuggerNonUserCode]
	public static MessageParser<table_MiningStory> Parser
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
	unsafe MessageDescriptor IMessage.Descriptor
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.Read<object>((void*)(int)((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/]);
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<MiningStory> List
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	[DebuggerNonUserCode]
	public unsafe table_MiningStory()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (ushort)(*unchecked((nuint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/)));
			_ = 4;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	[DebuggerNonUserCode]
	public table_MiningStory(table_MiningStory other)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xBB*/;
		}
	}

	[DebuggerNonUserCode]
	public table_MiningStory Clone()
	{
		/*Error: Invalid field token*/;
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		/*Error near IL_0001: Unknown opcode: 0xF5*/;
	}

	[DebuggerNonUserCode]
	public bool Equals(table_MiningStory other)
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
	public void MergeFrom(table_MiningStory other)
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

	unsafe static table_MiningStory()
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		_ = 6;
		/*Error near IL_0002: Unknown opcode: 0xE4*/;
	}
}
