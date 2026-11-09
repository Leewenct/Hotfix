using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Nova.Hotfix;

public sealed class StarTowerDropItem : IMessage<StarTowerDropItem>, IMessage, IEquatable<StarTowerDropItem>, IDeepCloneable<StarTowerDropItem>
{
	private static readonly MessageParser<StarTowerDropItem> _parser;

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int TypeFieldNumber = 2;

	private int type_;

	public const int DropSplitRangeFieldNumber = 3;

	private static readonly FieldCodec<int> _repeated_dropSplitRange_codec;

	private readonly RepeatedField<int> dropSplitRange_;

	public const int RateFieldNumber = 4;

	private static readonly FieldCodec<int> _repeated_rate_codec;

	private readonly RepeatedField<int> rate_;

	public const int ModelFieldNumber = 5;

	private string model_;

	[DebuggerNonUserCode]
	public static MessageParser<StarTowerDropItem> Parser
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
			_ = ((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			/*Error near IL_0001: Unknown opcode: 0xEE*/;
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
	public int Type
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
	public RepeatedField<int> DropSplitRange
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<int> Rate
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	[DebuggerNonUserCode]
	public string Model
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
	public unsafe StarTowerDropItem()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Invalid comparison between Unknown and Obj
		_ = *(IntPtr*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		if (/*Error near IL_0009: Stack underflow*/ != /*Error near IL_0009: Stack underflow*/)
		{
			_ = *(sbyte*)(~checked((sbyte)/*Error near IL_000b: Stack underflow*/));
			/*Error near IL_000e: Unknown opcode: 0xE3*/;
		}
		object obj = System.Runtime.CompilerServices.Unsafe.Read<object>((void*)(nint)/*Error near IL_001d: Stack underflow*/);
		if (System.Runtime.CompilerServices.Unsafe.As<_003F, UIntPtr>(ref /*Error near IL_0022: Stack underflow*/) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			/*Error: Invalid branch target*/;
		}
		((object[])/*Error near IL_0023: Stack underflow*/)[/*Error near IL_0023: Stack underflow*/] = (object)/*Error near IL_0023: Stack underflow*/;
		/*Error near IL_0023: starg 63 (out-of-bounds)*/;
		/*Error near IL_0025: Read out of bounds.*/;
	}

	[DebuggerNonUserCode]
	public unsafe StarTowerDropItem(StarTowerDropItem other)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) < 0)
		{
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
		((int[])/*Error near IL_004f: Stack underflow*/)[/*Error near IL_004f: Stack underflow*/] = *(short*)(nint)/*Error near IL_004e: Stack underflow*/;
		/*Error near IL_004f: Unknown opcode: 0xBD*/;
	}

	[DebuggerNonUserCode]
	public StarTowerDropItem Clone()
	{
		/*Error: Invalid field token*/;
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		/*Error near IL_0001: Unknown opcode: 0xF5*/;
	}

	[DebuggerNonUserCode]
	public bool Equals(StarTowerDropItem other)
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
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) >= 0)
		{
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
		_ = /*Error near IL_004e: Stack underflow*/>> (int)/*Error near IL_004e: Stack underflow*/;
		/*Error near IL_004e: Unknown opcode: 0xE6*/;
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(StarTowerDropItem other)
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
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error near IL_0001: Unknown opcode: 0xAC*/;
	}

	unsafe static StarTowerDropItem()
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: ldloc 3 (out-of-bounds)*/;
		/*Error near IL_0002: Unknown opcode: 0xE5*/;
	}
}
