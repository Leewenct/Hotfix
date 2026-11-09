using System;
using System.Collections.Generic;
using TrueSync;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "Combo Clip", menuName = "游戏/动作/连击动作配置")]
public class ComboClip : ScriptableObject
{
	public const float kDefaultFrameRate = 60f;

	public bool enableRootMotion;

	public FP rootMotionCheckDistance;

	public FP rootMotionCheckDistanceLimitUp;

	public TSAnimationCurve rootMotionSides;

	public TSAnimationCurve rootMotionVertical;

	public TSAnimationCurve rootMotionForward;

	public TSVector rootMotionMultiplier;

	public bool enableRootMotionRotate;

	public TSAnimationCurve rootMotionRotateQuaternionX;

	public TSAnimationCurve rootMotionRotateQuaternionY;

	public TSAnimationCurve rootMotionRotateQuaternionZ;

	public TSAnimationCurve rootMotionRotateQuaternionW;

	public AnimationClip animationClip;

	public ActionAnimationType actionAnimType;

	public FP transitionIn;

	public FP transitionOut;

	public FP animationLength;

	public FP playSpeed;

	[ComboClipFrameMinMaxSlider]
	public TSVector2 comboPhaseRange;

	public bool sendSkillTakeEffect;

	[ComboClipFrameSlider]
	public FP skillTakeEffectNormalizedTime;

	public bool sendSkillAllowOtherSkillExecute;

	[FormerlySerializedAs("skillAllowOtherSkillExccuteNormalizedTime")]
	[ComboClipFrameSlider]
	public FP skillAllowOtherSkillExecuteNormalizedTime;

	[FormerlySerializedAs("aimTargetCfgs")]
	public List<ChangeCurrentAttackTargetCfg> changeCurrentAttackTargetCfgs;

	public Dictionary<int, bool> changeCurrentAttackTargetTriggerDict;

	[HideInInspector]
	public bool useExitTime;

	[ComboClipFrameSlider]
	[HideInInspector]
	public FP canExitNormalizedTime;

	public bool enableExtraEventGroup;

	public bool showEventUniqueID;

	public bool showEventPlayerSkinEventOverrideType;

	public Combo.EventSkin[] comboEventSkins;

	[NonSerialized]
	public List<Combo.Event> selectedComboEvents;

	public Combo.EventGroup[] EventGroups;

	public Combo.FeaturePhase[] featurePhases;

	public void CalcRootMotion(FP time, out TSVector rootMotionTranslate, out TSQuaternion rootMotionRotate, out FP rootMotionRotateAngle)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ != /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			FP val = (FP)/*Error near IL_0007: Stack underflow*/;
			_ = ((double[])/*Error near IL_0009: Stack underflow*/)[(nint)/*Error near IL_0008: Stack underflow*/];
			/*Error near IL_000a: Unknown opcode: 0xB0*/;
		}
	}

	public Combo.Phase CalcComboPhase(FP normalizedTime)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			_ = 6;
			/*Error near IL_0002: Unknown opcode: 0xCB*/;
		}
	}

	public FP GetComboPhaseAnimationLength(Combo.Phase phase)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid field token*/;
		}
	}

	public FP GetComboPhaseAnimationDuration(Combo.Phase phase)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid field token*/;
		}
	}

	public ComboClip()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 6;
			/*Error near IL_0002: Unknown opcode: 0xCB*/;
		}
	}
}
