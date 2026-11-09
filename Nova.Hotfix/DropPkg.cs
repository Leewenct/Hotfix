using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Nova.Hotfix;

public sealed class DropPkg : IMessage<DropPkg>, IMessage, IEquatable<DropPkg>, IDeepCloneable<DropPkg>
{
	private static readonly MessageParser<DropPkg> _parser;

	private UnknownFieldSet _unknownFields;

	public const int PkgIdFieldNumber = 1;

	private int pkgId_;

	public const int ItemIdFieldNumber = 2;

	private int itemId_;

	[DebuggerNonUserCode]
	public static MessageParser<DropPkg> Parser
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
			/*Error near IL_0001: Not a type handle*/;
		}
	}

	[DebuggerNonUserCode]
	public int PkgId
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
	public int ItemId
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
	public DropPkg()
	{
	}

	[DebuggerNonUserCode]
	public DropPkg(DropPkg other)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) >= 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: Invalid metadata token*/;
	}

	[DebuggerNonUserCode]
	public DropPkg Clone()
	{
		/*Error: Invalid field token*/;
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		/*Error near IL_0001: Unknown opcode: 0xF5*/;
	}

	[DebuggerNonUserCode]
	public bool Equals(DropPkg other)
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
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_0007: Expected F8, but got I4
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) >= 0)
		{
			/*Error: Invalid branch target*/;
		}
		((double[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/] = 4.0;
		if (/*Error near IL_0009: Stack underflow*/ > /*Error near IL_0009: Stack underflow*/)
		{
		}
		if (/*Error near IL_000e: Stack underflow*/ >= /*Error near IL_000e: Stack underflow*/)
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
	public void MergeFrom(DropPkg other)
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
		_ = (ushort)/*Error near IL_0001: ldloc 3 (out-of-bounds)*/;
		/*Error near IL_0003: ldarga 194 (out-of-bounds)*/;
		checked
		{
			_ = (nuint)/*Error near IL_0005: ldarg 3 (out-of-bounds)*/;
			/*Error near IL_0007: Unknown opcode: 0xF1*/;
		}
	}

	unsafe static DropPkg()
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: stloc 1 (out-of-bounds)*/;
		/*Error near IL_0002: Unknown opcode: 0xE3*/;
	}
}
