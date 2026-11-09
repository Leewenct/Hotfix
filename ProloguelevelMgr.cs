using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class ProloguelevelMgr : LogicEntity
{
	protected static ProloguelevelMgr g_instance;

	public RefTool refTool;

	public CinemachineVirtualCamera PrologueVCam;

	public Transform npcTargetPos;

	public List<WorldOBB> edgeOBBs;

	public WorldOBB endOBB_1;

	public Transform preSlidePos;

	public WorldOBB runOBB;

	public WorldOBB monsterOBB;

	public Transform battle2StartPoint;

	public Transform climbStartPos;

	public WorldOBB sandstormOBB;

	public Transform climbEndPos;

	public List<WorldOBB> edgeOBBs_3;

	public WorldOBB climbOBB;

	public WorldOBB endOBB_3;

	public Transform EndPos;

	public CanvasGroup uiMask;

	private AIAdapter _aiAdapter;

	public unsafe static ProloguelevelMgr Instance
	{
		get
		{
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xEA*/;
		}
	}

	protected unsafe override void OnInit()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected F4, but got I4
		*(float*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) = 0f;
		checked
		{
			_ = (ushort)/*Error near IL_0004: Stack underflow*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	protected unsafe override void OnActive()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		*(int*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) = 0;
		checked
		{
			_ = (ushort)/*Error near IL_0004: Stack underflow*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	protected unsafe override void OnDeactive()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected I8, but got I4
		*(long*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) = 0L;
		checked
		{
			_ = (ushort)/*Error near IL_0004: Stack underflow*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	protected override void OnLogicUpdate()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	protected virtual void OnLevelStart(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xC1*/;
		}
	}

	protected virtual void OnLevelStop(IEvent evt)
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

	private void SortEntity()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public void SetVCamPriority(int value)
	{
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}

	public void SetGravity(Vector3 gravity)
	{
		/*Error: Invalid field token*/;
	}

	public unsafe Vector3 GetGravity()
	{
		*(ushort*)(nint)/*Error near IL_0002: Stack underflow*/ = ((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		/*Error near IL_0002: Read out of bounds.*/;
	}

	public ProloguelevelMgr()
	{
		/*Error: Invalid field token*/;
	}
}
