using System;
using TrueSync;

namespace AIScript;

public class PoolBranchInfo : BaseBranchInfo
{
	public int priority;

	public FP cd;

	private FP initCd;

	public bool active;

	public Func<bool> operationConditionFunc;

	public FP startCdTime;

	public FP branchCdExpireTime;

	private AdventureActor actor;

	public PoolBranchInfo(AdventureActor actor, int id, int priority, FP cd, FP initCd, bool active = true, FP releaseDistance = default(FP), FP releaseAngle = default(FP), FP traceDuration = default(FP), Func<bool> operationConditionFunc = null, Func<bool> finishTraceConditionFunc = null, MonsterActionBase.OperateDelegate operateIEnumerator = null, Action operateCompleteCallback = null, FP startCdTime = default(FP), Action operateInterruptCallback = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/!= 0)
			{
				/*Error: Invalid branch target*/;
			}
			_ = ((sbyte[])/*Error near IL_0008: Stack underflow*/)[(short)/*Error near IL_0007: Stack underflow*/];
			/*Error near IL_0008: stloc 3 (out-of-bounds)*/;
			_ = 0;
			/*Error near IL_000a: Unknown opcode: 0xBD*/;
		}
	}

	public void SetBranchCdExpireTime(FP cd)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (ulong)/*Error near IL_0007: Stack underflow*/;
			/*Error near IL_0007: Unknown opcode: 0xF6*/;
		}
	}

	public void ResetBranchCdExpireTime()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (ulong)/*Error near IL_0007: Stack underflow*/;
			/*Error near IL_0007: Unknown opcode: 0xF6*/;
		}
	}

	public void SetBranchActive(bool active)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}
}
