using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "Dorm Camera Control Configure Data", menuName = "游戏/摄像机/后宅摄像机控制配置")]
public class DormCameraConfigureData : ScriptableObject
{
	public bool enableCameraFollowSettings;

	[FormerlySerializedAs("cameraFollowDampTimeOnlyPlayer")]
	[Min(0f)]
	public float cameraFollowDampTime;

	[FormerlySerializedAs("cameraFollowDampTimeWithMonsterTime")]
	[Min(0f)]
	public float cameraFollowRngRadius;

	[Min(0f)]
	public float cameraOffsetRngRadius;

	[Min(0f)]
	public float cameraViewRngRadius;

	public bool enableCameraAngleSettings;

	[Range(-90f, 90f)]
	public float cameraAngle;

	[FormerlySerializedAs("enableCameraViewSettings")]
	public bool enableCameraRotationSettings;

	[Range(-180f, 180f)]
	public float cameraRotationAngle;

	[FormerlySerializedAs("enableCameraViewSettings")]
	public bool enableCameraRotationSpdSetting;

	public float cameraRotationDuration;

	public bool enableCameraViewportSettings;

	public AnimationCurve cameraFOVCurve;

	public bool enableCameraDepthSettings;

	public AnimationCurve cameraHeightCurve;

	[FormerlySerializedAs("cameraDepthOffset")]
	public float cameraHeightOffset;

	[HideInInspector]
	[FormerlySerializedAs("cameraHorizontalOffset")]
	public float cameraHorizontalOffset;

	public bool enableCameraDepthExtraSettings;

	public Vector2 monsterHeightRng;

	public Vector2 playerAtkRng;

	public bool enableCameraRenderExtraSettings;

	public float overrideCameraRenderDistance;

	public bool enableCameraDragRngSettings;

	public float2 cameraDragRngVertical;

	public float2 cameraDragRngHorizontal;

	public bool enableCameraFocusSettings;

	public AnimationCurve focusMoveEaseCurve;

	public AnimationCurve focusZoomEaseCurve;

	public AnimationCurve focusMoveDurationCurve;

	private float CurrentFOVPreview
	{
		get
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
	}

	public void OnActive()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected I4, but got Unknown
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
		}
	}

	public void OnDeactive()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected I4, but got Unknown
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
		}
	}

	public DormCameraConfigureData()
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
