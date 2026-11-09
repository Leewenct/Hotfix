using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Nova.Hotfix;

public sealed class StoryCondition : IMessage<StoryCondition>, IMessage, IEquatable<StoryCondition>, IDeepCloneable<StoryCondition>
{
	private static readonly MessageParser<StoryCondition> _parser;

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int ConditionIdFieldNumber = 2;

	private string conditionId_;

	public const int CommentFieldNumber = 3;

	private string comment_;

	public const int EvIdsAFieldNumber = 4;

	private static readonly FieldCodec<string> _repeated_evIdsA_codec;

	private readonly RepeatedField<string> evIdsA_;

	public const int EvIdsBFieldNumber = 5;

	private static readonly FieldCodec<string> _repeated_evIdsB_codec;

	private readonly RepeatedField<string> evIdsB_;

	public const int StoryIdAFieldNumber = 6;

	private static readonly FieldCodec<string> _repeated_storyIdA_codec;

	private readonly RepeatedField<string> storyIdA_;

	public const int StoryIdBFieldNumber = 7;

	private static readonly FieldCodec<string> _repeated_storyIdB_codec;

	private readonly RepeatedField<string> storyIdB_;

	public const int PlayerWorldLevelFieldNumber = 8;

	private int playerWorldLevel_;

	public const int AchieveIdsFieldNumber = 9;

	private static readonly FieldCodec<int> _repeated_achieveIds_codec;

	private readonly RepeatedField<int> achieveIds_;

	[DebuggerNonUserCode]
	public static MessageParser<StoryCondition> Parser
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
	public string ConditionId
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
	public string Comment
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
	public RepeatedField<string> EvIdsA
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<string> EvIdsB
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<string> StoryIdA
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<string> StoryIdB
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	[DebuggerNonUserCode]
	public int PlayerWorldLevel
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
	public RepeatedField<int> AchieveIds
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	[DebuggerNonUserCode]
	public unsafe StoryCondition()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(long*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xA7*/;
	}

	[DebuggerNonUserCode]
	public StoryCondition(StoryCondition other)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0003: Unknown opcode: 0xCB*/;
		}
	}

	[DebuggerNonUserCode]
	public StoryCondition Clone()
	{
		/*Error: Invalid field token*/;
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		/*Error near IL_0001: Unknown opcode: 0xF5*/;
	}

	[DebuggerNonUserCode]
	public bool Equals(StoryCondition other)
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
			_ = 0;
			/*Error near IL_0002: ldloc 0 (out-of-bounds)*/;
			/*Error near IL_0003: Unknown opcode: 0xCB*/;
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(StoryCondition other)
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
		//IL_0008: Expected Obj, but got I4
		/*Error: stloc 3 (out-of-bounds)*/;
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
			/*Error: Invalid branch target*/;
		}
		((object[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = ((short[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/];
		checked
		{
			if (/*Error near IL_000a: Stack underflow*/ <= /*Error near IL_000a: Stack underflow*/)
			{
				_ = (short)unchecked((uint)checked((short)/*Error near IL_000b: Stack underflow*/));
				/*Error near IL_000c: Unknown opcode: 0xE5*/;
			}
			/*Error near IL_0052: Unknown opcode: 0xCB*/;
		}
	}

	unsafe static StoryCondition()
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		*(_003F*)(nint)/*Error near IL_0002: Stack underflow*/ = /*Error near IL_0002: Stack underflow*/;
		/*Error near IL_0002: Unknown opcode: 0xE5*/;
	}
}
