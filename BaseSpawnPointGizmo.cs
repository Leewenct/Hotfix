using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class BaseSpawnPointGizmo : LogicEntity, IComparable
{
	[ReadOnly]
	public int x;

	[ReadOnly]
	public int y;

	public unsafe virtual string id
	{
		get
		{
			_ = *(byte*)(nint)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xEC*/;
		}
	}

	public BaseSpawnPointGizmo parentGizmo
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
				_ = 0;
				_ = -501814144;
				_ = -1;
				Transform val = default;
				_ = (long)(object)val;
				/*Error near IL_000c: Unknown opcode: 0xE7*/;
			}
		}
	}

	public List<BaseSpawnPointGizmo> childrenGizmos
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		protected set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public bool isSpawnActived
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public bool isSpawnEnabled
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public bool hasSendClearedEventNoSummons
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public bool hasSendClearedEvent
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public bool hasSendActivedEvent
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public bool jumpOverBornPerformance
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		protected set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public virtual void Initialize(int x1, int y1)
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
		_ = -1938815492;
		/*Error near IL_000e: Unknown opcode: 0xE7*/;
	}

	public unsafe virtual void InitChilds()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(IntPtr*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		_ = 4;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public virtual void EnableSpawnLogic()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (ushort)unchecked(checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) * 0);
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public virtual void ReEnableSpawnLogic()
	{
		/*Error near IL_0001: Unknown opcode: 0xC1*/;
	}

	public virtual void ResetSpawnState()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	public virtual void MarkQuitSettlementMonster(bool mark)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			int num = 0;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public virtual void DisableSpawnLogic()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (ushort)unchecked(checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) * 0);
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public virtual bool CheckActiveConditions()
	{
		/*Error: Unknown opcode: 0xC0*/;
	}

	public virtual void UpdateSpawnLogic()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Expected I4, but got Unknown
		int num = checked((/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) * 0);
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public virtual void ExecuteSpawnLogic(AdventureActor summoner = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Expected I4, but got Unknown
		int num = checked((/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) * 0);
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public virtual void SpawnMonsterEnterAction()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Expected I4, but got Unknown
		int num = checked((/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) * 0);
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public unsafe int CompareTo(object obj)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		if ((int)/*Error near IL_0004: Stack underflow*/ > *(int*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/))
		{
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
		_ = (ushort)8;
		_ = 1689299567;
		/*Error near IL_000c: Invalid branch target*/;
	}

	public virtual bool IsAllActived()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Expected I4, but got Unknown
		int num = checked((/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) * 0);
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public virtual bool IsAllActivedAndDied()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Expected I4, but got Unknown
		int num = checked((/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) * 0);
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public virtual bool IsAllActivedAndDied_NoSummons()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Expected I4, but got Unknown
		int num = checked((/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) * 0);
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public virtual void SetAllActiveAndDied()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid calli metadata token*/;
		}
	}

	public virtual List<long> GetSpawnedEntities()
	{
		/*Error: Unknown opcode: 0xC0*/;
	}

	public virtual void JumpOverBornPerformance(bool jumpOver = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (ulong)((nuint)/*Error near IL_0007: Stack underflow*/ * 1690505773);
			/*Error near IL_000e: Unknown opcode: 0xE4*/;
		}
	}

	protected override void OnInit()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) >= 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0007: Unknown opcode: 0xEE*/;
	}

	public virtual void KillAllSummoners()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			int num = 0;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public virtual bool IsSpwanState()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			int num = 0;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public virtual int DiedMonsterCount()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Expected I4, but got Unknown
		int num = checked((/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) * 0);
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public virtual int RemindMonsterCount()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Expected I4, but got Unknown
		int num = checked((/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) * 0);
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	protected BaseSpawnPointGizmo()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid branch target*/;
		}
	}
}
