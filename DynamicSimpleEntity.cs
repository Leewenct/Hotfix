using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DynamicSimpleEntity : MonoBehaviour
{
	protected Logger _logger;

	public unsafe int entityType
	{
		get
		{
			_ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xB1*/;
		}
		protected set
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected I8, but got Unknown
			/*Error near IL_0001: stloc 2 (out-of-bounds)*/;
			_003F val = checked(/*Error near IL_0003: Stack underflow*/ + /*Error near IL_0003: Stack underflow*/);
			*(long*)(nint)/*Error near IL_0006: Stack underflow*/ = (long)val;
			_ = ((Array)/*Error near IL_0007: Stack underflow*/).LongLength;
			/*Error near IL_0007: Invalid branch target*/;
		}
	}

	public long id
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		internal set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public bool isInvalid
	{
		get
		{
			if (/*Error near IL_0003: Stack underflow*/ >= /*Error: ldloc 0 (out-of-bounds)*/)
			{
				/*Error: Invalid branch target*/;
			}
			if (/*Error near IL_0005: Stack underflow*/ > /*Error near IL_0005: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0005: Unknown opcode: 0xEB*/;
		}
	}

	public string poolName
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

	public bool isSpawnFromPool
	{
		get
		{
			/*Error: Unknown opcode: 0xF0*/;
		}
	}

	protected virtual void Awake()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) >= 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0007: Unknown opcode: 0xA8*/;
	}

	protected unsafe virtual void OnEnable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got I8
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		if ((int)/*Error near IL_0007: Stack underflow*/ == 0)
		{
			/*Error: Invalid branch target*/;
		}
		checked
		{
			_003F val = /*Error near IL_0008: Stack underflow*/+ /*Error near IL_0008: Stack underflow*/;
			long num = (long)unchecked((ulong)checked((long)(object)this));
			if (!float.IsFinite(num))
			{
				throw new ArithmeticException();
			}
			((object[])/*Error near IL_0010: Stack underflow*/)[val] = num;
			/*Error near IL_0010: Invalid field token*/;
		}
	}

	protected virtual void OnDisable()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public virtual void DoLogicUpdate(float dt)
	{
	}

	public virtual void DoLateLogicUpdate(float dt)
	{
	}

	public virtual void DoVisualUpdate(float dt)
	{
	}

	public static T SpawnInstance<T>(string poolName, GameObject prefab) where T : DynamicSimpleEntity
	{
		/*Error: Unknown opcode: 0xE7*/;
	}

	public virtual void DespawnInstance()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
		}
	}

	internal void OnDelayDespawnInstance()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) != 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	protected virtual void OnSpawned()
	{
	}

	protected virtual void OnDespawned()
	{
	}

	protected virtual void InitializeComponents()
	{
	}

	protected virtual void ReleaseComponents()
	{
	}

	[DebuggerHidden]
	protected void Log(string message)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected I4, but got Unknown
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

	[DebuggerHidden]
	protected void LogWarning(string message)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected I4, but got Unknown
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

	[DebuggerHidden]
	protected void LogError(string message)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected I4, but got Unknown
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

	public DynamicSimpleEntity()
	{
		/*Error: Unknown opcode: 0xF0*/;
	}
}
