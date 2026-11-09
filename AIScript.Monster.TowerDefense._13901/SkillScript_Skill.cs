using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TrueSync;

namespace AIScript.Monster.TowerDefense._13901;

public class SkillScript_Skill : TowerCharacterSkillBase
{
	private const string comboTag_Skill = "139_Skill_Sup";

	private const int loopTimes_Skill = 1;

	private const int loopTimes_Skill_P4 = 3;

	private const string eventName_GenerateAreaEffect_Skill = "139_Sup_Area";

	private const string areaEffectKey_Skill = "AreaEffect_13901_Sup";

	private static readonly TSVector2 offset_AreaEffect_Skill;

	private const int perkId_2 = 1390102;

	private static readonly Dictionary<string, (string bulletKey, FP offsetAngle)> shootInfoDic_P2;

	private static readonly FP shootRadius_P2;

	private static readonly FP shootPositionY_P2;

	private int _totalLoopTimes;

	private int _loopTims;

	protected override void OnSkillEnable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f->IL0001: Incompatible stack heights: 0 vs 1
		checked
		{
			_003F val = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			while (true)
			{
				if (unchecked((int)val) == 0)
				{
					/*Error: Invalid branch target*/;
				}
				_ = /*Error near IL_000d: Stack underflow*/+ (/*Error near IL_000c: Stack underflow*/ >> unchecked((int)(double)(ulong)((long[])(/*Error near IL_0008: Stack underflow*/ ^ /*Error near IL_0008: Stack underflow*/))[(object)this]));
			}
		}
	}

	protected override void OnSkillDisable()
	{
		/*Error: Invalid field token*/;
	}

	public void OnStart()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected I4, but got Unknown
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
		}
	}

	public void OnUpdate()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) == 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0003: Invalid field token*/;
	}

	private unsafe void DoMainLogic()
	{
		_ = *(byte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xF6*/;
	}

	private unsafe void OnAnticipationEnd()
	{
		System.Runtime.CompilerServices.Unsafe.Read<object>((void*)checked((nuint)/*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0002: Unknown opcode: 0xF7*/;
	}

	private void OnComboLoop()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0007: Not a type handle*/;
	}

	private void OnCustomEvent(string evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0006: Invalid metadata token*/;
	}

	private void OnFinish()
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

	private void OnInterrupt()
	{
		/*Error: Invalid field token*/;
	}

	public SkillScript_Skill()
	{
		/*Error: Invalid field token*/;
	}

	static SkillScript_Skill()
	{
		/*Error: Unknown opcode: 0xEB*/;
	}
}
