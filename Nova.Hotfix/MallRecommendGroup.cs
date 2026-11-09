using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Nova.Hotfix;

public sealed class MallRecommendGroup : IMessage<MallRecommendGroup>, IMessage, IEquatable<MallRecommendGroup>, IDeepCloneable<MallRecommendGroup>
{
	private static readonly MessageParser<MallRecommendGroup> _parser;

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private string id_;

	public const int SortFieldNumber = 2;

	private int sort_;

	public const int PackageListFieldNumber = 3;

	private static readonly FieldCodec<string> _repeated_packageList_codec;

	private readonly RepeatedField<string> packageList_;

	public const int NameFieldNumber = 4;

	private string name_;

	public const int StartTimeFieldNumber = 5;

	private string startTime_;

	public const int EndTimeFieldNumber = 6;

	private string endTime_;

	[DebuggerNonUserCode]
	public static MessageParser<MallRecommendGroup> Parser
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
			/*Error near IL_0001: Unknown opcode: 0xEF*/;
		}
	}

	[DebuggerNonUserCode]
	public string Id
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
	public int Sort
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
	public RepeatedField<string> PackageList
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	[DebuggerNonUserCode]
	public string Name
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
	public string StartTime
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
	public string EndTime
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
	public unsafe MallRecommendGroup()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(long*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xA7*/;
	}

	[DebuggerNonUserCode]
	public unsafe MallRecommendGroup(MallRecommendGroup other)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_0051: Invalid comparison between F4 and I4
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) >= 0)
		{
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
		((double[])/*Error near IL_003e: Stack underflow*/)[/*Error near IL_003e: Stack underflow*/] = (double)/*Error near IL_003e: Stack underflow*/;
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_003f: Stack underflow*/, /*Error near IL_003f: Stack underflow*/);
		checked
		{
			if ((nuint)/*Error near IL_003f: ldarg 2 (out-of-bounds)*/ != 0)
			{
				/*Error: Invalid branch target*/;
			}
			if (((float[])/*Error near IL_004f: Stack underflow*/)[(ulong)/*Error near IL_0047: Stack underflow*/ >> -1536821756] <= -1f)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0056: Unknown opcode: 0x24*/;
		}
	}

	[DebuggerNonUserCode]
	public MallRecommendGroup Clone()
	{
		/*Error: Invalid field token*/;
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		/*Error near IL_0001: Unknown opcode: 0xF5*/;
	}

	[DebuggerNonUserCode]
	public bool Equals(MallRecommendGroup other)
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
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			if (false)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0007: Invalid branch target*/;
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(MallRecommendGroup other)
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
		/*Error near IL_0001: Unknown opcode: 0xAE*/;
	}

	unsafe static MallRecommendGroup()
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		if (!float.IsFinite(/*Error near IL_0002: Stack underflow*/))
		{
			throw new ArithmeticException();
		}
		/*Error near IL_0002: Unknown opcode: 0xE3*/;
	}
}
