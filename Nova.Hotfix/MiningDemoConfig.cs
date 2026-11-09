using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Nova.Hotfix;

public sealed class MiningDemoConfig : IMessage<MiningDemoConfig>, IMessage, IEquatable<MiningDemoConfig>, IDeepCloneable<MiningDemoConfig>
{
	private static readonly MessageParser<MiningDemoConfig> _parser;

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int GridListFieldNumber = 2;

	private static readonly FieldCodec<int> _repeated_gridList_codec;

	private readonly RepeatedField<int> gridList_;

	public const int RewardListFieldNumber = 3;

	private static readonly FieldCodec<int> _repeated_rewardList_codec;

	private readonly RepeatedField<int> rewardList_;

	public const int RewardAIndexFieldNumber = 4;

	private static readonly FieldCodec<int> _repeated_rewardAIndex_codec;

	private readonly RepeatedField<int> rewardAIndex_;

	public const int RewardBIndexFieldNumber = 5;

	private static readonly FieldCodec<int> _repeated_rewardBIndex_codec;

	private readonly RepeatedField<int> rewardBIndex_;

	public const int RewardCIndexFieldNumber = 6;

	private static readonly FieldCodec<int> _repeated_rewardCIndex_codec;

	private readonly RepeatedField<int> rewardCIndex_;

	public const int RewardDIndexFieldNumber = 7;

	private static readonly FieldCodec<int> _repeated_rewardDIndex_codec;

	private readonly RepeatedField<int> rewardDIndex_;

	public const int RewardDirFieldNumber = 8;

	private static readonly FieldCodec<int> _repeated_rewardDir_codec;

	private readonly RepeatedField<int> rewardDir_;

	public const int GridCoordsFieldNumber = 9;

	private string gridCoords_;

	public const int TreasureGroupIndexFieldNumber = 10;

	private int treasureGroupIndex_;

	public const int CheckFieldNumber = 11;

	private string check_;

	[DebuggerNonUserCode]
	public static MessageParser<MiningDemoConfig> Parser
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
			/*Error near IL_0001: Unknown opcode: 0xE6*/;
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
	public RepeatedField<int> GridList
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<int> RewardList
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<int> RewardAIndex
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<int> RewardBIndex
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<int> RewardCIndex
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<int> RewardDIndex
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<int> RewardDir
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	[DebuggerNonUserCode]
	public string GridCoords
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
	public int TreasureGroupIndex
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
	public string Check
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
	public unsafe MiningDemoConfig()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected native int or pointer, but got F4
		_ = *(IntPtr*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		_ = *(sbyte*)unchecked((nint)4.226525E+23f);
		/*Error near IL_000d: Not a type handle*/;
	}

	[DebuggerNonUserCode]
	public MiningDemoConfig(MiningDemoConfig other)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xEF*/;
		}
	}

	[DebuggerNonUserCode]
	public MiningDemoConfig Clone()
	{
		/*Error: Invalid field token*/;
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		/*Error near IL_0001: Unknown opcode: 0xF5*/;
	}

	[DebuggerNonUserCode]
	public bool Equals(MiningDemoConfig other)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 205 (out-of-bounds)*/;
			/*Error near IL_0003: stloc 1 (out-of-bounds)*/;
			/*Error near IL_0004: Read out of bounds.*/;
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
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xF2*/;
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(MiningDemoConfig other)
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
		((long[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = (long)/*Error near IL_0002: Stack underflow*/;
		/*Error near IL_0002: Unknown opcode: 0xCC*/;
	}

	unsafe static MiningDemoConfig()
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}
}
