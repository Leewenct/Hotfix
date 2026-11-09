using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Nova.Hotfix;
using TrueSync;
using UnityEngine;

namespace AIScript;

public abstract class TowerDefenseItemBase
{
	protected FP indicatorRange;

	protected List<LogicEntity> actOnEntities;

	private CoroutineNode coroutine;

	private TowerDefenseItemChargeBase itemChargeTemplete;

	private const string DEFAULT_ITEM_CHARGE_SCIPT_PATH = "AIScript.TowerDefenseItemChargeBase";

	protected ITowerDefenseGameplayHost host;

	public FP IndicatorRng
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	public int curItemNum
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected I4, but got Unknown
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
			}
		}
	}

	public void InitHost(ITowerDefenseGameplayHost host)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}

	protected virtual void GetTakeEffectGrids()
	{
	}

	public unsafe virtual void InitConfig(TowerDefenseItem itemData)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
		checked
		{
			_ = (sbyte)/*Error near IL_0003: Stack underflow*/;
			/*Error near IL_0003: Unknown opcode: 0xCE*/;
		}
	}

	public virtual void UpdateLogic()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
		default:
			/*Error: End of method reached without returning.*/;
		case 0:
			/*Error: Invalid branch target*/;
		case 1:
			/*Error: Invalid branch target*/;
		}
	}

	protected CoroutineNode StartCoroutine(IEnumerator e)
	{
		/*Error: Invalid metadata token*/;
	}

	protected void StopCoroutine(CoroutineNode c)
	{
		if (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		_ = 8;
		_ = 3.6395676E-26f;
		/*Error: End of method reached without returning.*/;
	}

	public void ActOnEntities(List<LogicEntity> entities)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}

	public void StartLogic(TSVector2 position)
	{
		/*Error: Unknown opcode: 0xF0*/;
	}

	public void StartChargeLogic()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
		default:
			/*Error: End of method reached without returning.*/;
		case 0:
			/*Error: Invalid branch target*/;
		case 1:
			/*Error: Invalid branch target*/;
		}
	}

	protected abstract IEnumerator DoMainLogic(TSVector2 position);

	protected AdventureFXPlayer PlayEffect(string path, Vector3 position)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	protected void PlayAreaEffect(int templeteID, string[] fxAlias, TSVector2 position)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		if (checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/) <= /*Error near IL_0001: ldloca 207 (out-of-bounds)*/<< (int)this)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0007: Invalid metadata token*/;
	}

	private long GetGlobAttributeId(int templeteID)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public void MinusItemNum(int num = 1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected I4, but got Unknown
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
		}
	}

	public void AddItemNum(int num = 1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected I4, but got Unknown
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
		}
	}

	public virtual bool GridSatisItem_CanUse(TowerDefenseMapData.TowerGrid grid)
	{
		/*Error: Unknown opcode: 0xE4*/;
	}

	public virtual bool GridSatisItem_TakeEffect(TowerDefenseMapData.TowerGrid grid)
	{
		/*Error: Unknown opcode: 0xE4*/;
	}

	public List<int> GetItemTakeEffectGrids(int index)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0004: Stack underflow*/+ ((sbyte[])(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))[0];
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	protected TowerDefenseItemBase()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}
}
