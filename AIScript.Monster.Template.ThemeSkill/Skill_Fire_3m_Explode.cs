using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AdventureBehaviour;
using TrueSync;

namespace AIScript.Monster.Template.ThemeSkill;

public class Skill_Fire_3m_Explode : SkillSimpleBase
{
	[CompilerGenerated]
	private sealed class _003CDoMainLogic_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Skill_Fire_3m_Explode _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		[DebuggerHidden]
		public _003CDoMainLogic_003Ed__5(int _003C_003E1__state)
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xBC*/;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			// ILSpy could not decompile this member: Error decompiling @0601514F AIScript.Monster.Template.ThemeSkill.Skill_Fire_3m_Explode.<DoMainLogic>d__5.MoveNext: Index was outside the bounds of the array.
			// Please report the exception below,
			// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
			// Error decompiling @0601514F AIScript.Monster.Template.ThemeSkill.Skill_Fire_3m_Explode.<DoMainLogic>d__5.MoveNext
			// in assembly "D:\Libraries\Downloads\Hotfix_full.dll"
			//  ---> System.IndexOutOfRangeException: Index was outside the bounds of the array.
			//    at Internal.Runtime.CompilerHelpers.ThrowHelpers.ThrowIndexOutOfRangeException() in offset 5
			//    at ICSharpCode.Decompiler.IL.ILReader.ReadBlock(ImportedBlock block, CancellationToken cancellationToken) in ILReader.cs:line 523
			//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in ILReader.cs:line 506
			//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in ILReader.cs:line 726
			//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in CSharpDecompiler.cs:line 2412
			// -- continuing with outer exception (ICSharpCode.Decompiler.DecompilerException) --
			// 
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			_ = (double)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	private readonly FP waitTime;

	private readonly string bullet_Boom;

	private PlayFX _playFx;

	protected override void OnSkillEnable()
	{
		/*Error: Invalid field token*/;
	}

	protected override void OnSkillDisable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			if (false)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	[IteratorStateMachine(typeof(_003CDoMainLogic_003Ed__5))]
	protected unsafe override IEnumerator DoMainLogic()
	{
		if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
		{
			/*Error: Invalid branch target*/;
		}
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0007: Stack underflow*/, /*Error near IL_0005: ldloc 0 (out-of-bounds)*/);
		throw /*Error near IL_0008: Stack underflow*/;
	}

	public Skill_Fire_3m_Explode()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 6;
			/*Error near IL_0002: Unknown opcode: 0xCB*/;
		}
	}
}
