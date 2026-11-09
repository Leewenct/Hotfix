using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Nova.Hotfix;

public sealed class ActivityStoryCondition : IMessage<ActivityStoryCondition>, IMessage, IEquatable<ActivityStoryCondition>, IDeepCloneable<ActivityStoryCondition>
{
	private static readonly MessageParser<ActivityStoryCondition> _parser;

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int ActivityIdFieldNumber = 2;

	private int activityId_;

	public const int CommentFieldNumber = 3;

	private string comment_;

	public const int ActivityStoryIdAFieldNumber = 4;

	private static readonly FieldCodec<int> _repeated_activityStoryIdA_codec;

	private readonly RepeatedField<int> activityStoryIdA_;

	public const int ActivityStoryIdBFieldNumber = 5;

	private static readonly FieldCodec<int> _repeated_activityStoryIdB_codec;

	private readonly RepeatedField<int> activityStoryIdB_;

	public const int ActivityLevelFieldNumber = 6;

	private static readonly FieldCodec<int> _repeated_activityLevel_codec;

	private readonly RepeatedField<int> activityLevel_;

	public const int EvIdsAFieldNumber = 7;

	private static readonly FieldCodec<int> _repeated_evIdsA_codec;

	private readonly RepeatedField<int> evIdsA_;

	public const int EvIdsBFieldNumber = 8;

	private static readonly FieldCodec<int> _repeated_evIdsB_codec;

	private readonly RepeatedField<int> evIdsB_;

	[DebuggerNonUserCode]
	public static MessageParser<ActivityStoryCondition> Parser
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
			_ = *(int*)(int)((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
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
	public int ActivityId
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
	public RepeatedField<int> ActivityStoryIdA
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<int> ActivityStoryIdB
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<int> ActivityLevel
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<int> EvIdsA
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<int> EvIdsB
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	[DebuggerNonUserCode]
	public unsafe ActivityStoryCondition()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(long*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xA7*/;
	}

	[DebuggerNonUserCode]
	public ActivityStoryCondition(ActivityStoryCondition other)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: stloc 0 (out-of-bounds)*/;
			_ = 1.0412271E-09f;
			/*Error near IL_0008: Invalid metadata token*/;
		}
	}

	[DebuggerNonUserCode]
	public ActivityStoryCondition Clone()
	{
		/*Error: Invalid field token*/;
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		/*Error near IL_0001: Unknown opcode: 0xF5*/;
	}

	[DebuggerNonUserCode]
	public bool Equals(ActivityStoryCondition other)
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
		//IL_0009: Invalid comparison between Unknown and F4
		_003F val = checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		_ = 0;
		/*Error near IL_0002: stloc 3 (out-of-bounds)*/;
		if ((float)val >= 4.6887774E-09f)
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
	public void MergeFrom(ActivityStoryCondition other)
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
		_ = -52;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	unsafe static ActivityStoryCondition()
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: ldloc 226 (out-of-bounds)*/;
		/*Error near IL_0003: Invalid metadata token*/;
	}
}
