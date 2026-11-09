using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Nova.Hotfix;

public sealed class DictionaryTab : IMessage<DictionaryTab>, IMessage, IEquatable<DictionaryTab>, IDeepCloneable<DictionaryTab>
{
	private static readonly MessageParser<DictionaryTab> _parser;

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int IconFieldNumber = 2;

	private string icon_;

	public const int Icon2FieldNumber = 3;

	private string icon2_;

	public const int TitleFieldNumber = 4;

	private string title_;

	public const int HideInBattleFieldNumber = 5;

	private bool hideInBattle_;

	[DebuggerNonUserCode]
	public static MessageParser<DictionaryTab> Parser
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
			_ = (int)((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
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
	public string Icon
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
	public string Icon2
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
	public string Title
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
	public bool HideInBattle
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
	public unsafe DictionaryTab()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(long*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xA7*/;
	}

	[DebuggerNonUserCode]
	public DictionaryTab(DictionaryTab other)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: stloc 1 (out-of-bounds)*/;
			/*Error near IL_0003: Unknown opcode: 0xAC*/;
		}
	}

	[DebuggerNonUserCode]
	public DictionaryTab Clone()
	{
		/*Error: Invalid field token*/;
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		/*Error near IL_0001: Unknown opcode: 0xF5*/;
	}

	[DebuggerNonUserCode]
	public bool Equals(DictionaryTab other)
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
			/*Error near IL_0002: ldarg 172 (out-of-bounds)*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(DictionaryTab other)
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
		/*Error near IL_0003: Not a type handle*/;
	}

	unsafe static DictionaryTab()
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		if (!float.IsFinite(/*Error near IL_0002: Stack underflow*/))
		{
			throw new ArithmeticException();
		}
		/*Error near IL_0002: Unknown opcode: 0xE2*/;
	}
}
