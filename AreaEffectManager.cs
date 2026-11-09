using System;
using System.Collections.Generic;
using TrueSync;
using UnityEngine;

public class AreaEffectManager : SceneSingleton<AreaEffectManager>
{
	private Logger _logger;

	private readonly Dictionary<int, (int MaxCount, int OverLimitType)> areaConfigDic;

	private List<AreaEffectEntity> _queryList;

	private readonly Dictionary<int, Dictionary<long, FP>> _hittedEntitiesGroupDic;

	private List<LogicEntity> _areaEffectList
	{
		get
		{
			/*Error: Invalid metadata token*/;
		}
	}

	protected override void Awake()
	{
		//Discarded unreachable code: IL_002b
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		checked
		{
			if (/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/!= 0)
			{
				/*Error: Invalid branch target*/;
			}
			_ = ((long[])/*Error near IL_0009: Stack underflow*/)[(sbyte)/*Error near IL_0008: Stack underflow*/];
			/*Error near IL_000a: Unknown opcode: 0xAF*/;
		}
	}

	public long PlayAreaEffect(AdventureActor owner, GameObject areaEffectPrefab, Vector3 spawnPosition, Quaternion spawnRotation, bool isAssemble = false, Action<AreaEffectEntity> onBeforeSetup = null, Action<AreaEffectEntity> onAfterSetup = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/== 0)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (int)/*Error near IL_0004: Stack underflow*/;
			/*Error near IL_0004: Not a type handle*/;
		}
	}

	private unsafe bool CheckMaxCount(int areaHashCode)
	{
		//IL_0001: Invalid comparison between Unknown and I4
		if ((int)/*Error near IL_0003: Stack underflow*/ < (int)(*(short*)(nint)/*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0003: Invalid field token*/;
	}

	public unsafe void StopAreaEffect(long id)
	{
		//IL_0001: Invalid comparison between Unknown and I4
		if ((int)/*Error near IL_0003: Stack underflow*/ > (int)(*(short*)(nint)/*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0003: Invalid field token*/;
	}

	public void StopAreaEffectByTag(string tag1)
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

	public unsafe void StopAreaEffectByTag(int tagHashCode)
	{
		//IL_0001: Invalid comparison between Unknown and I4
		if ((int)/*Error near IL_0003: Stack underflow*/ != *(short*)(nint)/*Error near IL_0001: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0003: Invalid field token*/;
	}

	public void StopAllAreaEffect()
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public void FixMaxCountByTag(string areaTag, int fixCount)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/>= 0)
			{
				/*Error: Invalid branch target*/;
			}
			this = (AreaEffectManager)/*Error near IL_0009: Stack underflow*/;
			int num = default;
			_ = /*Error near IL_000b: Stack underflow*/+ num;
			/*Error near IL_000b: Invalid metadata token*/;
		}
	}

	public void FixMaxCountByTag(int areaHashCode, int fixCount)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 204 (out-of-bounds)*/;
			_ = -1;
			/*Error near IL_0004: Unknown opcode: 0xEE*/;
		}
	}

	public List<AreaEffectEntity> GetAllAreaEffect()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected I4, but got Unknown
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
		}
	}

	public unsafe AreaEffectEntity GetAreaEffect(long id)
	{
		//IL_0001: Invalid comparison between Unknown and I4
		//IL_0007: Invalid comparison between Unknown and I
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		if ((int)/*Error near IL_0006: Stack underflow*/ > (int)(*(short*)(nint)/*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((nint)/*Error near IL_0009: Stack underflow*/ <= (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/))
		{
			/*Error near IL_0009: Unknown opcode: 0xC8*/;
		}
		checked
		{
			if (/*Error near IL_0016: Stack underflow*/ < /*Error near IL_0011: Stack underflow*/+ *unchecked((sbyte*)(nint)/*Error near IL_0010: Stack underflow*/))
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0016: Invalid metadata token*/;
		}
	}

	public List<AreaEffectEntity> GetAreaEffectsByTag(string tag1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 205 (out-of-bounds)*/;
		}
		int num = (int)/*Error near IL_0004: Stack underflow*/;
		/*Error near IL_0004: Not a type handle*/;
	}

	public unsafe List<AreaEffectEntity> GetAreaEffectsByTag(int tagHashCode)
	{
		//IL_0001: Invalid comparison between Unknown and I4
		//IL_0007: Invalid comparison between Unknown and I
		//IL_000b: Unsupported input type for neg.
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		if ((int)/*Error near IL_0006: Stack underflow*/ == *(short*)(nint)/*Error near IL_0001: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		if ((nint)/*Error near IL_0009: Stack underflow*/ <= (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/))
		{
			/*Error near IL_0009: Unknown opcode: 0xCA*/;
		}
		checked
		{
			_ = /*Error near IL_000d: Stack underflow*/+ unchecked(0 - /*Error near IL_000c: Stack underflow*/);
			/*Error near IL_000d: Invalid branch target*/;
		}
	}

	public unsafe List<AreaEffectEntity> GetAreaEffectsByOwner(AdventureActor owner)
	{
		//IL_0007: Invalid comparison between Unknown and I
		//IL_000b: Unsupported input type for neg.
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		if (*(short*)(nint)/*Error near IL_0001: Stack underflow*/ == 0)
		{
			/*Error: Invalid branch target*/;
		}
		if ((nint)/*Error near IL_0009: Stack underflow*/ <= (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/))
		{
			/*Error near IL_0009: Unknown opcode: 0xCC*/;
		}
		checked
		{
			_ = /*Error near IL_000d: Stack underflow*/+ unchecked(0 - /*Error near IL_000c: Stack underflow*/);
			/*Error near IL_000d: Invalid branch target*/;
		}
	}

	internal void SetActorHitedTimeToGroup(AreaEffectEntity areaEffect, long entityId, FP time)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
		}
	}

	internal bool QueryActorHitedTimeoutByGroup(AreaEffectEntity areaEffect, long entityId, out FP hitTime)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/- /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	protected unsafe AreaEffectEntity Spawn(GameObject fxPrefab, Vector3 spawnPosition, Quaternion spawnRotation, bool isAssemble = false)
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		checked
		{
			_ = (byte)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0004: Unknown opcode: 0xE6*/;
		}
	}

	public unsafe void Despawn(AreaEffectEntity entity)
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		checked
		{
			_ = (byte)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0004: Unknown opcode: 0xE6*/;
		}
	}

	public unsafe AreaEffectManager()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0003: Stack underflow*/% (nint)(*(IntPtr*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0003: ldarg 1 (out-of-bounds)*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}
}
