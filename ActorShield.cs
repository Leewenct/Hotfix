using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TrueSync;
using UnityEngine;

public class ActorShield : LogicMonoComponent, ILogicComponentUpdate, ILogicComponent
{
	public delegate void ShieldChangedHandle(long oneValueC, long oneValueM);

	[CompilerGenerated]
	private ShieldChangedHandle m_shieldChangedEvent;

	[HideInInspector]
	public AdventureActor damageFrom;

	private long _shieldValue;

	private long _maxShildValue;

	private int normalFxIndex;

	private AdventureBuffFXHandler normalAdventureFx;

	public List<ShieldEntity> shieldList
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		private set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public AdventureActor OwnerActor
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		private set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public long shiledValue
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	public long maxShieldValue
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	public event ShieldChangedHandle shieldChangedEvent
	{
		[CompilerGenerated]
		add
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected I4, but got Unknown
			switch (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
			{
			default:
				/*Error: End of method reached without returning.*/;
			case 0:
				/*Error: Invalid branch target*/;
			case 1:
				/*Error: Invalid branch target*/;
			case 2:
				/*Error: Invalid branch target*/;
			case 3:
				/*Error: Invalid branch target*/;
			case 4:
				/*Error: Invalid branch target*/;
			case 5:
				/*Error: Invalid branch target*/;
			case 6:
				/*Error: Invalid branch target*/;
			case 7:
				/*Error: Invalid branch target*/;
			}
		}
		[CompilerGenerated]
		remove
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected I4, but got Unknown
			switch (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
			{
			default:
				/*Error: End of method reached without returning.*/;
			case 0:
				/*Error: Invalid branch target*/;
			case 1:
				/*Error: Invalid branch target*/;
			case 2:
				/*Error: Invalid branch target*/;
			case 3:
				/*Error: Invalid branch target*/;
			case 4:
				/*Error: Invalid branch target*/;
			case 5:
				/*Error: Invalid branch target*/;
			case 6:
				/*Error: Invalid branch target*/;
			case 7:
				/*Error: Invalid branch target*/;
			}
		}
	}

	protected override void OnInit()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (ushort)((object[])(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))[0];
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public override void OnActive()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected F4, but got I4
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_003F val = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			((float[])(byte)0)[/*Error near IL_0003: ldarg 236 (out-of-bounds)*/] = 4f;
			if (/*Error near IL_0009: Stack underflow*/ > val)
			{
			}
			if (/*Error near IL_000b: Stack underflow*/ + /*Error near IL_0009: ldarg 2 (out-of-bounds)*/== 0)
			{
				/*Error: Invalid branch target*/;
			}
		}
		_ = /*Error near IL_000e: Stack underflow*/>> (int)/*Error near IL_000e: Stack underflow*/;
		/*Error near IL_000e: Unknown opcode: 0xE3*/;
	}

	public void OnLogicUpdate()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (nuint)/*Error near IL_0007: Stack underflow*/;
			/*Error near IL_0007: Unknown opcode: 0xF6*/;
		}
	}

	private unsafe void LogicUpdate(FP deltaTime)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected F8, but got I4
		_003F val = checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		((double[])0)[/*Error near IL_0003: ldarg 236 (out-of-bounds)*/] = 4.0;
		_ = (nuint)val;
		int num = default;
		_ = (short)System.Runtime.CompilerServices.Unsafe.Read<object>((void*)num);
		/*Error near IL_000b: Invalid field token*/;
	}

	public long DamageToShield(long damageValue, LogicEntity from = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected Obj, but got Unknown
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			List<ShieldEntity> list = (List<ShieldEntity>)(/*Error near IL_0003: ldarg 236 (out-of-bounds)*/ | (ushort)4);
			/*Error near IL_0009: Invalid metadata token*/;
		}
	}

	public void UpdateShieldValue(bool iRecycle = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
		default:
			/*Error: End of method reached without returning.*/;
		case 0:
			/*Error: Invalid branch target*/;
		case 1:
			/*Error: Invalid branch target*/;
		case 2:
			/*Error: Invalid branch target*/;
		case 3:
			/*Error: Invalid branch target*/;
		case 4:
			/*Error: Invalid branch target*/;
		case 5:
			/*Error: Invalid branch target*/;
		case 6:
			/*Error: Invalid branch target*/;
		case 7:
			/*Error: Invalid branch target*/;
		case 8:
			/*Error: Invalid branch target*/;
		case 9:
			/*Error: Invalid branch target*/;
		case 10:
			/*Error: Invalid branch target*/;
		case 11:
			/*Error: Invalid branch target*/;
		case 12:
			/*Error: Invalid branch target*/;
		case 13:
			/*Error: Invalid branch target*/;
		case 14:
			/*Error: Invalid branch target*/;
		case 15:
			/*Error: Invalid branch target*/;
		case 16:
			/*Error: Invalid branch target*/;
		case 17:
			/*Error: Invalid branch target*/;
		case 18:
			/*Error: Invalid branch target*/;
		case 19:
			/*Error: Invalid branch target*/;
		case 20:
			/*Error: Invalid branch target*/;
		case 21:
			/*Error: Invalid branch target*/;
		case 22:
			/*Error: Invalid branch target*/;
		case 23:
			/*Error: Invalid branch target*/;
		case 24:
			/*Error: Invalid branch target*/;
		case 25:
			/*Error: Invalid branch target*/;
		case 26:
			/*Error: Invalid branch target*/;
		case 27:
			/*Error: Invalid branch target*/;
		case 28:
			/*Error: Invalid branch target*/;
		case 29:
			/*Error: Invalid branch target*/;
		case 30:
			/*Error: Invalid branch target*/;
		case 31:
			/*Error: Invalid branch target*/;
		case 32:
			/*Error: Invalid branch target*/;
		case 33:
			/*Error: Invalid branch target*/;
		case 34:
			/*Error: Invalid branch target*/;
		case 35:
			/*Error: Invalid branch target*/;
		case 36:
			/*Error: Invalid branch target*/;
		}
	}

	private void ResetUIshieldValues()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	protected void ShieldEvent(bool iRecycle = false, bool lastHaveValue = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
		((IntPtr[])0u)[/*Error near IL_0003: ldarg 236 (out-of-bounds)*/] = (IntPtr)4;
		/*Error near IL_0007: Unknown opcode: 0xA6*/;
	}

	public void AddShield(int shieldID, AdventureActor fromActor)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected Obj, but got I4
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = (byte)0;
			List<ShieldEntity> list = (List<ShieldEntity>)(sbyte)((double[])/*Error near IL_0003: ldarg 236 (out-of-bounds)*/)[4];
			_ = 8;
			/*Error near IL_000a: Unknown opcode: 0xAF*/;
		}
	}

	public void AjustShieldTime_Value(int Id, FP addTime)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	public unsafe void ResetShield(int shieldID, FP leftTime, long[] sheildValue, long currentValue, int valueID)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected F4, but got I4
		//IL_0009: Invalid comparison between Unknown and I
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Invalid comparison between Unknown and I4
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		_003F val = checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		((float[])0)[/*Error near IL_0003: ldarg 236 (out-of-bounds)*/] = 4f;
		if ((nint)/*Error near IL_000b: Stack underflow*/ != (nint)(nuint)val)
		{
			_ = /*Error near IL_000e: Stack underflow*/>> (int)(ushort)/*Error near IL_000c: Stack underflow*/;
			/*Error near IL_000e: Unknown opcode: 0xEF*/;
		}
		if ((int)/*Error near IL_0034: Stack underflow*/ >= (int)(*(ushort*)(nint)(/*Error near IL_002e: Stack underflow*/ ^ /*Error near IL_002e: Stack underflow*/)))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0034: Unknown opcode: 0xEE*/;
	}

	public void OnNormalFx(bool iAdd, int num = 1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: ldloca 32 (out-of-bounds)*/;
			/*OpCode not supported: DebugBreak*/;
			/*Error near IL_0004: Unknown opcode: 0xEE*/;
		}
	}

	public bool CheckShieldByID(int id)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected F4, but got I4
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			((float[])0)[/*Error near IL_0003: ldarg 236 (out-of-bounds)*/] = 4f;
			_ = 1858425906;
			/*Error near IL_000c: Unknown opcode: 0xFE77*/;
		}
	}

	public bool CheckShieldByTag(int tag)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected F4, but got I4
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			((float[])0)[/*Error near IL_0003: ldarg 236 (out-of-bounds)*/] = 4f;
			_ = 1858425882;
			/*Error near IL_000c: Unknown opcode: 0xFE77*/;
		}
	}

	public void RemoveShieldByShieldID(int shieldID)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected F4, but got I4
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			((float[])0)[/*Error near IL_0003: ldarg 236 (out-of-bounds)*/] = 4f;
			/*Error near IL_0007: starg 42 (out-of-bounds)*/;
			/*Error near IL_000a: Unknown opcode: 0xC5*/;
		}
	}

	public void RemoveShieldByTag(int tag)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected F4, but got I4
		//IL_0009: Expected Obj, but got Unknown
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_003F val = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			((float[])0)[/*Error near IL_0003: ldarg 236 (out-of-bounds)*/] = 4f;
			this = (ActorShield)val;
			_ = /*Error near IL_000b: Stack underflow*/+ /*Error near IL_0009: ldarg 2 (out-of-bounds)*/;
			_ = 7;
			/*Error near IL_000c: Unknown opcode: 0xEF*/;
		}
	}

	public unsafe void RemoveShield(ShieldEntity shield)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected F8, but got I4
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		_003F val = checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		((double[])0)[/*Error near IL_0003: ldarg 236 (out-of-bounds)*/] = 4.0;
		if (/*Error near IL_0009: Stack underflow*/ <= val)
		{
			_ = /*Error near IL_000a: Stack underflow*/* /*Error near IL_000a: Stack underflow*/;
			/*Error near IL_000a: Unknown opcode: 0xB0*/;
		}
		((object[])/*Error near IL_0023: Stack underflow*/)[/*Error near IL_0023: Stack underflow*/] = System.Runtime.CompilerServices.Unsafe.Read<object>((void*)checked((nuint)(/*Error near IL_0020: Stack underflow*/ << unchecked((int)/*Error near IL_0020: Stack underflow*/))));
		_ = null;
		/*Error near IL_0025: Read out of bounds.*/;
	}

	public void RemoveAllShield(bool iRecycle = false)
	{
		// ILSpy could not decompile this member: Error decompiling @06001CD0 ActorShield.RemoveAllShield: Invalid token. (Parameter 'token')
		// Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// Error decompiling @06001CD0 ActorShield.RemoveAllShield
		// in assembly "D:\Libraries\Downloads\Hotfix_full.dll"
		//  ---> System.ArgumentException: Invalid token. (Parameter 'token')
		//    at System.Reflection.Throw.InvalidToken() in offset 15
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadAndDecodeTypeReference() in ILReader.cs:line 239
		//    at ICSharpCode.Decompiler.IL.ILReader.DecodeInstruction() in ILReader.cs:line 1173
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadBlock(ImportedBlock block, CancellationToken cancellationToken) in ILReader.cs:line 539
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in ILReader.cs:line 506
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in ILReader.cs:line 726
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in CSharpDecompiler.cs:line 2412
		// -- continuing with outer exception (ICSharpCode.Decompiler.DecompilerException) --
		// 
	}

	public void OnClear()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid calli metadata token*/;
		}
	}

	public override void OnDeactive()
	{
		/*Error: Invalid field token*/;
	}

	public void FireShieldUiEvent(int id, long shieldValue, FP leftTime, string name)
	{
	}

	public ActorShield()
	{
		/*Error: Invalid field token*/;
	}
}
