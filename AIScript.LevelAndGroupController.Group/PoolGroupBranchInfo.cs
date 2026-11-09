using System;
using TrueSync;

namespace AIScript.LevelAndGroupController.Group;

public class PoolGroupBranchInfo : BaseGroupBranchInfo
{
	public int priority;

	public FP cd;

	private FP initCd;

	public bool active;

	public Func<bool> operationConditionFunc;

	public FP startCdTime;

	public FP branchCdExpireTime;

	public PoolGroupBranchInfo(int id, int priority, FP cd, FP initCd, bool active = true, Func<bool> operationConditionFunc = null, MonsterActionBase.OperateDelegate operateIEnumerator = null, Action operateCompleteCallback = null, FP startCdTime = default(FP))
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: Invalid metadata token*/;
	}

	public void SetBranchCdExpireTime(FP cd)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0u;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public void ResetBranchCdExpireTime()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0u;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public void SetBranchActive(bool active)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}
}
