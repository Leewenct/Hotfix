using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Nova.Hotfix;

public sealed class CharPotential : IMessage<CharPotential>, IMessage, IEquatable<CharPotential>, IDeepCloneable<CharPotential>
{
	private static readonly MessageParser<CharPotential> _parser;

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int MasterSpecificPotentialIdsFieldNumber = 2;

	private static readonly FieldCodec<int> _repeated_masterSpecificPotentialIds_codec;

	private readonly RepeatedField<int> masterSpecificPotentialIds_;

	public const int AssistSpecificPotentialIdsFieldNumber = 3;

	private static readonly FieldCodec<int> _repeated_assistSpecificPotentialIds_codec;

	private readonly RepeatedField<int> assistSpecificPotentialIds_;

	public const int CommonPotentialIdsFieldNumber = 4;

	private static readonly FieldCodec<int> _repeated_commonPotentialIds_codec;

	private readonly RepeatedField<int> commonPotentialIds_;

	public const int MasterNormalPotentialIdsFieldNumber = 5;

	private static readonly FieldCodec<int> _repeated_masterNormalPotentialIds_codec;

	private readonly RepeatedField<int> masterNormalPotentialIds_;

	public const int AssistNormalPotentialIdsFieldNumber = 6;

	private static readonly FieldCodec<int> _repeated_assistNormalPotentialIds_codec;

	private readonly RepeatedField<int> assistNormalPotentialIds_;

	[DebuggerNonUserCode]
	public static MessageParser<CharPotential> Parser
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
			_ = (double)(int)((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
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
	public RepeatedField<int> MasterSpecificPotentialIds
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<int> AssistSpecificPotentialIds
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<int> CommonPotentialIds
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<int> MasterNormalPotentialIds
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<int> AssistNormalPotentialIds
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	[DebuggerNonUserCode]
	public unsafe CharPotential()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(IntPtr*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0007: stloc 1 (out-of-bounds)*/;
		/*Error near IL_0008: stloc 0 (out-of-bounds)*/;
		_ = ((sbyte[])/*Error near IL_000e: Stack underflow*/)[*(sbyte*)(~checked((sbyte)/*Error near IL_000b: Stack underflow*/))];
		/*Error near IL_000e: Unknown opcode: 0xE3*/;
	}

	[DebuggerNonUserCode]
	public CharPotential(CharPotential other)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			_ = 5;
			/*Error near IL_0003: Unknown opcode: 0xA9*/;
		}
	}

	[DebuggerNonUserCode]
	public CharPotential Clone()
	{
		/*Error: Invalid field token*/;
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		/*Error near IL_0001: Unknown opcode: 0xF5*/;
	}

	[DebuggerNonUserCode]
	public bool Equals(CharPotential other)
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
			_ = 8;
			/*Error near IL_0003: Unknown opcode: 0xA9*/;
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(CharPotential other)
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
		/*Error near IL_0001: Unknown opcode: 0xF4*/;
	}

	unsafe static CharPotential()
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}
}
