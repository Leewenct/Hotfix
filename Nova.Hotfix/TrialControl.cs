using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Nova.Hotfix;

public sealed class TrialControl : IMessage<TrialControl>, IMessage, IEquatable<TrialControl>, IDeepCloneable<TrialControl>
{
	private static readonly MessageParser<TrialControl> _parser;

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int GroupIdsFieldNumber = 2;

	private static readonly FieldCodec<int> _repeated_groupIds_codec;

	private readonly RepeatedField<int> groupIds_;

	public const int GachasFieldNumber = 3;

	private static readonly FieldCodec<int> _repeated_gachas_codec;

	private readonly RepeatedField<int> gachas_;

	public const int UIAssetsFieldNumber = 4;

	private string uIAssets_;

	public const int CtrlNameFieldNumber = 5;

	private string ctrlName_;

	[DebuggerNonUserCode]
	public static MessageParser<TrialControl> Parser
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
			/*Error near IL_0001: Invalid field token*/;
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
	public RepeatedField<int> GroupIds
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<int> Gachas
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	[DebuggerNonUserCode]
	public string UIAssets
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
	public string CtrlName
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
	public unsafe TrialControl()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(IntPtr*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		_ = ((double[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/];
		/*Error near IL_0008: stloc 0 (out-of-bounds)*/;
		_ = *(sbyte*)(~checked((sbyte)/*Error near IL_000b: Stack underflow*/));
		/*Error near IL_000d: Unknown opcode: 0xBD*/;
	}

	[DebuggerNonUserCode]
	public TrialControl(TrialControl other)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/>= 0)
			{
				/*Error: Invalid branch target*/;
			}
			if (/*Error near IL_0009: Stack underflow*/ > /*Error near IL_0009: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			if (unchecked((int)/*Error near IL_000b: Stack underflow*/) == 0)
			{
				_ = /*Error near IL_000d: Stack underflow*/+ (/*Error near IL_000c: Stack underflow*/ >> unchecked((int)/*Error near IL_000c: Stack underflow*/));
				return;
			}
		}
		_ = (ushort)/*Error near IL_0017: Stack underflow*/;
		/*Error near IL_0018: stloc 0 (out-of-bounds)*/;
		/*Error near IL_004a: Unknown opcode: 0xAF*/;
	}

	[DebuggerNonUserCode]
	public TrialControl Clone()
	{
		/*Error: Invalid field token*/;
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		/*Error near IL_0001: Unknown opcode: 0xF5*/;
	}

	[DebuggerNonUserCode]
	public bool Equals(TrialControl other)
	{
		// ILSpy could not decompile this member: Error decompiling @0600A47D Nova.Hotfix.TrialControl.Equals: Invalid token. (Parameter 'token')
		// Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// Error decompiling @0600A47D Nova.Hotfix.TrialControl.Equals
		// in assembly "D:\Libraries\Downloads\Hotfix_full.dll"
		//  ---> System.ArgumentException: Invalid token. (Parameter 'token')
		//    at System.Reflection.Throw.InvalidToken() in offset 15
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadAndDecodeTypeReference() in ILReader.cs:line 239
		//    at ICSharpCode.Decompiler.IL.ILReader.DecodeInstruction() in ILReader.cs:line 1235
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadBlock(ImportedBlock block, CancellationToken cancellationToken) in ILReader.cs:line 539
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in ILReader.cs:line 506
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in ILReader.cs:line 726
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in CSharpDecompiler.cs:line 2412
		// -- continuing with outer exception (ICSharpCode.Decompiler.DecompilerException) --
		// 
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
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) < 0)
		{
			/*Error: Invalid branch target*/;
		}
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
	public void MergeFrom(TrialControl other)
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

	unsafe static TrialControl()
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xCB*/;
	}
}
