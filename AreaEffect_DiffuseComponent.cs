using TrueSync;
using UnityEngine;

[AddComponentMenu("Game/Adventure/AreaEffect/AreaEffectComponents/区域效果组件_扩散")]
[RequireComponent(typeof(AreaEffectEntity))]
[DisallowMultipleComponent]
public class AreaEffect_DiffuseComponent : AreaEffect_Component
{
	public enum EdgeDiffuseType
	{
		Default,
		SameRatio,
		OnlyLength,
		OnlyWidth
	}

	public enum InnerRadiusDiffuseType
	{
		SyncRadius,
		SameSpeed
	}

	public FP speed;

	public FP interval;

	public FP delayDiffuseTime;

	public FP maxDiffuseTime;

	public bool changeSpeed;

	public FP delay_Change;

	public FP speed_Change;

	public EdgeDiffuseType edgeDiffuseType;

	public bool radiusTogether;

	public InnerRadiusDiffuseType innerRadiusDiffuseType;

	protected FP _curDiffuseSpeed;

	protected FP _diffuseTime;

	protected FP _delayDiffuseTime;

	protected FP _maxDiffuseTime;

	protected FP _defaultWidth;

	protected FP _defaultLength;

	protected FP _defaultRadius;

	protected FP _defaultInnerRadius;

	protected override bool ShowCheckTag
	{
		get
		{
			/*Error: Unknown opcode: 0xC0*/;
		}
	}

	protected override void OnSetup()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0x77*/;
		}
	}

	protected override void OnLogicUpdate(FP logicDeltaTime)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (nuint)/*Error near IL_0007: Stack underflow*/ + 1689681430;
		}
	}

	private void DispatchEvent()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public override void OnDeactive()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public AreaEffect_DiffuseComponent()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}
}
