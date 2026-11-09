using System;
using System.Collections.Generic;
using System.Text;
using AK.Wwise;
using TrueSync;
using UnityEngine;
using UnityEngine.Serialization;

[Serializable]
public class Combo
{
	[Flags]
	public enum Phase
	{
		None = 0,
		Anticipation = 1,
		Activation = 2,
		Recovery = 4,
		All = Anticipation | Activation | Recovery
	}

	public enum ComboMode
	{
		Normal,
		Endless
	}

	public enum ComboClipMode
	{
		Once,
		Loop
	}

	[Serializable]
	public class CompositeComboClip
	{
		public ComboClip comboClip;

		public string eventGroupTag;

		public unsafe CompositeComboClip()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			_ = *(long*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
			/*Error near IL_0002: Unknown opcode: 0x77*/;
		}
	}

	[Serializable]
	public class Event
	{
		public enum EventType
		{
			[InspectorName("自定义事件")]
			Custom = 0,
			[InspectorName("攻击")]
			Hit = 1,
			[InspectorName("射击")]
			Shoot = 2,
			[InspectorName("添加Buff")]
			AddBuff = 3,
			[InspectorName("区域效果")]
			AreaEffect = 5,
			[InspectorName("添加护盾")]
			AddShield = 7,
			[InspectorName("播放音效或语音")]
			PlayWwiseEvent = 9,
			[InspectorName("冻结时间（仅限抽卡角色）")]
			FrozenTime = 10,
			[InspectorName("特效")]
			Effect = 90,
			[InspectorName("关闭特效")]
			StopEffect = -90,
			[InspectorName("触发角色玩法逻辑公共事件")]
			TriggerCharGamePlayLogicCommonEvent = 20
		}

		public enum ClipPreconditionType
		{
			Any,
			Only,
			Except
		}

		public enum HitBoxConfigureWithGameData
		{
			Disable = 0,
			VisionData = 10,
			VisionDataWithDistanceOnly = 11,
			VisionDataWithAngleOnly = 12,
			HearData = 20,
			BodyDataWithSize = 31
		}

		public enum PlayerSkinEventOverrideType
		{
			[InspectorName("无")]
			None,
			[InspectorName("新增")]
			Add,
			[InspectorName("替换")]
			Replace,
			[InspectorName("删除")]
			Remove
		}

		public enum audioPlayType
		{
			[InspectorName("播放音效")]
			eventPlay,
			[InspectorName("播放语音")]
			voicePlay
		}

		public enum audioEvetType
		{
			[InspectorName("音效资源")]
			eventSource,
			[InspectorName("音效事件")]
			eventName
		}

		[HideInInspector]
		public bool fixedEventType;

		[HideInInspector]
		public bool isSimpleMode;

		public EventType type;

		public string uniqueID;

		public PlayerSkinEventOverrideType playerSkinEventOverrideType;

		public string tag;

		public bool IsShowInHitBoxEditor;

		public string name;

		[ComboClipFrameMinMaxSlider]
		public TSVector2 activeNormalizedTimeRange;

		public bool playOnceInLoopMode;

		public ClipPreconditionType clipPreconditionType;

		public ComboClip preconditionClip;

		public HitBox.Shape hitBoxShape;

		public FP hitBoxWidth;

		public FP hitBoxLength;

		public FP hitBoxRadius;

		public FP hitBoxInnerRadius;

		public FP hitBoxAngle;

		public HitBoxConfigureWithGameData hitBoxConfigureWithGameData;

		public FP hitBoxRotation;

		public TSVector2 hitBoxOffset;

		public FP hitBoxOffsetY;

		public bool offsetFollowActor;

		public bool lockHitBoxTransformOnEnd;

		public FP hitBoxRotationOnEnd;

		public TSVector2 hitBoxOffsetOnEnd;

		public bool enableHitBoxCurveMotion;

		public TSVector2 hitBoxCurveMotionControlPoint1;

		public TSVector2 hitBoxCurveMotionControlPoint2;

		public bool areaWithActorScale;

		public int hitDamageId;

		public HitBox.FeatureFlag hitFlags;

		public HitBox.HitBoxFeatureData hitFeatureData;

		public HitBox.HurtAnimType hurtAnimType;

		public GameObject hittedEffectPrefab;

		public bool isHittedEffectScale;

		public bool effectIgnoreTimeScale;

		public FP damageImmuneDuration;

		public FP damageDetectInterval;

		public bool haveFeedbackEffect;

		public bool blockBullet;

		public TargetType blockBulletTargetType;

		public GameObject blockFinishFx;

		public GameObject bulletPrefab;

		public int ControlIndex;

		[Min(0f)]
		public int bulletCount;

		[Min(0f)]
		public int reduceAmmoCount;

		public AdventureWeapon.MultipleShootStyle multipleShootStyle;

		public bool useShootDeviationCalcScatteringRadius;

		public FP shootScatteringRadius;

		public FP multipleShootBulletDirectionOffset;

		public bool alignShoot;

		public FP alignShootDelay;

		public FP innerRadius;

		public FP range;

		public AimType aimType;

		public BulletDirectionType bulletDirectionType;

		[FormerlySerializedAs("oneShotEffectPrefab")]
		public GameObject effectPrefab;

		public bool isEarlyWarningEffect;

		public float effectScale;

		public bool actorScale;

		public float effectPlaySpeed;

		public FP effectDuration;

		public bool interruptCancelEffect;

		public bool cancelEffectWhenLoopStop;

		public AdventurePlayerFeedbackEffectConfigureData playerfeedbackEffectConfigureData;

		public bool interruptCancelPlayerFeedbackEffect;

		public List<int> buffIds;

		public GameObject AreaEffectPrefab;

		public bool lockTarget;

		public bool useOwnerDirection;

		public FP rotationAngleOffset;

		public float distance;

		public float offset;

		public int shiledID;

		public bool toTeam;

		public audioPlayType _audioPlayType;

		public string mainVoice;

		public string asseitVoice;

		public audioEvetType _audioEvetType;

		public Event _wwiseEvent;

		public string wwiseEventName;

		public bool _includeSelf;

		[Space]
		public bool triggerFateCardTheme;

		public bool normalAttackTriggerForFateCard;

		public bool dodgeTriggerForFateCard;

		public bool skillTriggerForFateCard;

		public bool ultimateTriggerForFateCard;

		public FP activeNormaliedDuration
		{
			get
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
				{
					/*Error: Invalid branch target*/;
				}
				/*Error near IL_0006: Unknown opcode: 0xF6*/;
			}
		}

		public bool isInstantEvent
		{
			get
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
				{
					/*Error: Invalid branch target*/;
				}
				/*Error near IL_0006: Unknown opcode: 0xF6*/;
			}
		}

		public unsafe Event()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			_ = *(long*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
			/*Error near IL_0002: Unknown opcode: 0xA7*/;
		}

		public unsafe Event(EventType eventType, bool isSimpleMode)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			_ = *(long*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
			/*Error near IL_0002: Unknown opcode: 0xA7*/;
		}

		public FP GetAreaScale(AdventureActor actor)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return (FP)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		}
	}

	[Serializable]
	public class EventSkin
	{
		[HideInInspector]
		public int skinId;

		public bool preview;

		public Event[] comboEvents;
	}

	[Serializable]
	public class EventGroup
	{
		[HideInInspector]
		public int index;

		public string tag;

		public EventSkin[] ComboEventSkins;

		public unsafe EventGroup()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			_ = *(long*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	[Serializable]
	public class FeaturePhase
	{
		public string label;

		[HideInInspector]
		public bool autoGenerateForAnticipation;

		[HideInInspector]
		public bool autoGenerateForActivation;

		[HideInInspector]
		public bool autoGenerateForRecovery;

		[ComboClipFrameSlider]
		public FP activeNormalizedTime;

		public AdventureSkillPhaseConfig skillPhaseConfig;

		public bool autoGenerate
		{
			get
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				//IL_0019: Expected I4, but got Unknown
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

		public unsafe FeaturePhase()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = (long)(*unchecked((ulong*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/)));
				/*Error near IL_0004: Unknown opcode: 0xE2*/;
			}
		}
	}

	public ComboClipMode comboClipMode;

	public const int MinActionKeyNumber = 1;

	public const int MaxActionKeyNumber = 10;

	public bool autoLoad;

	public bool useActionKeys;

	public ComboInputBuffer.ActionKey[] requestKeys;

	public string actionTag;

	public CompositeComboClip[] compositeComboClips;

	public ComboSkillType comboSkillType;

	[HideInInspector]
	public bool useExitTime;

	private static StringBuilder _sb;

	public static readonly Dictionary<ComboInputBuffer.ActionKey, string> ActionKeyInspectorNames;

	public string requestKeysText
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Expected I4, but got Unknown
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
			case 20:
				/*Error: Invalid branch target*/;
			case 21:
				/*Error: Invalid branch target*/;
			case 22:
				/*Error: Invalid branch target*/;
			case 23:
				/*Error: Invalid branch target*/;
			case 24:
				/*Error: Invalid branch target*/;
			case 25:
				/*Error: Invalid branch target*/;
			}
		}
	}

	public Combo()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid calli metadata token*/;
		}
	}

	unsafe static Combo()
	{
		//IL_0001: Invalid comparison between Unknown and I4
		if ((int)/*Error near IL_0006: Stack underflow*/ > (int)(*(short*)(nint)/*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		_ = ((float[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/];
		/*Error near IL_0007: Invalid metadata token*/;
	}
}
