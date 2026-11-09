using UnityEngine;

public class HUDFollowTarget_Dorm : MonoBehaviour
{
	private Transform _target;

	private RectTransform _transform;

	private Vector3 _positionOffset;

	private RectTransform _canvasRect;

	private bool _bUpdateHudPos;

	public void SetFollowTarget(Transform target, Vector3 positionOffset)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (ulong)/*Error near IL_0007: Stack underflow*/;
		}
		_ = -2066086404;
		/*Error near IL_000e: Unknown opcode: 0xE7*/;
	}

	public void EnableUpdateHudPos(bool bVisible, bool bEnable)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I8
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) != 0)
		{
			/*Error: Invalid branch target*/;
		}
		if ((long)/*Error near IL_0009: Stack underflow*/ > (long)checked((ulong)/*Error near IL_0007: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0009: stloc 2 (out-of-bounds)*/;
		/*Error near IL_000a: Unknown opcode: 0xB1*/;
	}

	public void LateUpdate()
	{
		/*Error: Unknown opcode: 0xF0*/;
	}

	public void UpdateHudPos()
	{
		/*Error: Unknown opcode: 0xE9*/;
	}

	public HUDFollowTarget_Dorm()
	{
		// ILSpy could not decompile this member: Error decompiling @0600203B HUDFollowTarget_Dorm..ctor: Invalid token. (Parameter 'token')
		// Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// Error decompiling @0600203B HUDFollowTarget_Dorm..ctor
		// in assembly "D:\Libraries\Downloads\Hotfix_full.dll"
		//  ---> System.ArgumentException: Invalid token. (Parameter 'token')
		//    at System.Reflection.Throw.InvalidToken() in offset 15
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadAndDecodeFieldReference() in ILReader.cs:line 251
		//    at ICSharpCode.Decompiler.IL.ILReader.DecodeInstruction() in ILReader.cs:line 1211
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadBlock(ImportedBlock block, CancellationToken cancellationToken) in ILReader.cs:line 539
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in ILReader.cs:line 506
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in ILReader.cs:line 726
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in CSharpDecompiler.cs:line 2412
		// -- continuing with outer exception (ICSharpCode.Decompiler.DecompilerException) --
		// 
	}
}
