using System;

namespace AIScript.Character._15801;

public class SkillScript_Spawn_Soldier_MainControl : SkillScript_Summoned
{
	protected override void OnSkillEnable()
	{
		/*Error: Read out of bounds.*/;
	}

	public unsafe void OnStart()
	{
		//IL_0003: Expected Obj, but got I4
		//IL_0005: Expected I4, but got Obj
		string text = default;
		((sbyte[])/*Error near IL_0005: Stack underflow*/)[(nint)((Array)(*(byte*)(nint)/*Error near IL_0001: Stack underflow*/)).LongLength] = (sbyte)(int)text;
		/*Error near IL_0006: Invalid metadata token*/;
	}

	private void OnFinish()
	{
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}

	private void OnInterrupt()
	{
		/*Error: Read out of bounds.*/;
	}

	protected override void OnSkillDisable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		((sbyte[])/*Error near IL_0003: Stack underflow*/)[checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/)] = 0;
		_ = /*Error near IL_0004: Stack underflow*/+ /*Error near IL_0004: Stack underflow*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public SkillScript_Spawn_Soldier_MainControl()
	{
		/*Error: Read out of bounds.*/;
	}
}
