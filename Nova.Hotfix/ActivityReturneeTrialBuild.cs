using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Nova.Hotfix;

public sealed class ActivityReturneeTrialBuild : IMessage<ActivityReturneeTrialBuild>, IMessage, IEquatable<ActivityReturneeTrialBuild>, IDeepCloneable<ActivityReturneeTrialBuild>
{
	private static readonly MessageParser<ActivityReturneeTrialBuild> _parser;

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int GroupFieldNumber = 2;

	private int group_;

	public const int IndexFieldNumber = 3;

	private int index_;

	public const int TrialBuildIdFieldNumber = 4;

	private int trialBuildId_;

	[DebuggerNonUserCode]
	public static MessageParser<ActivityReturneeTrialBuild> Parser
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
			*(ushort*)(nint)/*Error near IL_0002: Stack underflow*/ = ((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
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
	public int Group
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
	public int Index
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
	public int TrialBuildId
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
	public ActivityReturneeTrialBuild()
	{
	}

	[DebuggerNonUserCode]
	public ActivityReturneeTrialBuild(ActivityReturneeTrialBuild other)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Expected F8, but got I
		((double[])/*Error near IL_0004: Stack underflow*/)[checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/)] = 0.0;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	[DebuggerNonUserCode]
	public ActivityReturneeTrialBuild Clone()
	{
		/*Error: Invalid field token*/;
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		/*Error near IL_0001: Unknown opcode: 0xF5*/;
	}

	[DebuggerNonUserCode]
	public bool Equals(ActivityReturneeTrialBuild other)
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
		//IL_0004: Expected F8, but got Unknown
		((double[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/] = checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/+ 0);
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(ActivityReturneeTrialBuild other)
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

	unsafe static ActivityReturneeTrialBuild()
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		_ = 7;
		/*Error near IL_0002: Unknown opcode: 0xE2*/;
	}
}
