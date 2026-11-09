using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cinemachine;
using Game.Graphics.HighlightOutliner;
using TrueSync;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using XLua;

public class DormCameraController : SceneSingleton<DormCameraController>
{
	public CinemachineVirtualCamera dormMainVCam;

	public Transform cameraBeacon;

	public Camera closeupCamera;

	public Camera hudCamera;

	[Range(0.001f, 0.1f)]
	public float dragSensitivity;

	[Range(0.1f, 5f)]
	public float pinchZoomSpeed;

	[Range(0.01f, 1f)]
	public float dragRotateSensitivity;

	private DormCameraConfigureData activedCameraConfigData;

	private static readonly AnimationCurve _fallbackFOVCurve;

	private static readonly AnimationCurve _fallbackHeightCurve;

	private static readonly AnimationCurve _fallbackFocusEaseCurve;

	protected int _cameraControlEnableRC;

	private bool needCameraMove;

	private FP _fixedDuration;

	private Vector3 _cameraFollowTargetPosition;

	private Vector3 _cameraDampPosition;

	private Vector3 _cameraDampVelocity;

	private float _cameraDampAngle;

	private float _cameraDampAngleVelocity;

	private float _cameraRotationDampAngle;

	private float _cameraRotationDampAngleVelocity;

	private float _cameraRotationDragOffset;

	private float _cameraDepth;

	private float _cameraDampDepth;

	private float _cameraDampDepthVelocity;

	private float _cameraFOVDamp;

	private float _cameraFOVDampVelocity;

	protected float _cameraFollowSmoothTime;

	private CinemachineTransposer _cameraTransposer;

	private CinemachineComposer _cameraComposer;

	private float updateCameraDepthValue;

	private GameObject bindFocusObj;

	private float _beaconBaseY;

	private bool _bindFocusObjGroundBased;

	private GameObject _focusAnchor;

	private GameObject _savedFocusObj;

	private bool _savedFocusObjGroundBased;

	private float _savedDepthValue;

	private Vector3 _savedBeaconPosition;

	private bool _isFocusing;

	private bool _cameraInputLocked;

	private float _focusTransitionDuration;

	private float _focusSettleEpsilon;

	private bool _focusTransitionActive;

	private float _focusElapsed;

	private float _focusMoveDuration;

	private bool _focusMovingStage;

	private float _focusStageHoldDepth;

	private const float FOCUS_MOVE_MAX_DURATION = 3f;

	private float _focusBlendDuration;

	private bool _focusKeepPointOnExit;

	private bool _focusSmoothEase;

	private float _focusFrameT;

	private float _focusEasedPrev;

	private bool _focusIgnoreFollowDeadzone;

	private const float FOCUS_MIN_DEPTH = 2f;

	private float _focusMinDepth;

	private float _focusPitchDegrees;

	private float _focusWeight;

	private float _focusWeightVelocity;

	private bool _focusSideViewActive;

	private float _focusSideYawOffset;

	private float _focusSideYaw;

	private bool _focusSideLocked;

	private float _focusSideSign;

	private float _focusAimHeightOffset;

	private float _focusAimHeight;

	private float _focusAimHeightVelocity;

	private bool _focusFOVLocked;

	private float _focusLockedFOV;

	private bool _focusPoseLockedFromEntry;

	private bool mouseScrollWheelDirection;

	private Vector3 cameraShiftValue;

	private Vector3 _dragRngCenter;

	private bool _hasViewCameraSnapshot;

	private Vector3 _viewSnapBeaconPos;

	private float _viewSnapRotationDragOffset;

	private float _viewSnapDepthValue;

	private UniversalAdditionalCameraData _closeupCameraAdditionalCameraData;

	private int _closeupCameraEnabledRC;

	public RenderingMode outlinerRenderingMode;

	[Range(0.15f, 1f)]
	public float outlinerPrimaryRendererScale;

	[Range(0f, 2f)]
	public float outlinerBlurShift;

	[Range(0f, 2f)]
	public float outlinerDilateShift;

	public int outlinerDilateIterations;

	public DilateQuality outlinerDilateQuality;

	public int outlinerBlurIterations;

	public BlurType outlinerBlurType;

	public Color outlineHighlightColor;

	[BlackList]
	public unsafe float cameraFollowDampTime
	{
		get
		{
			//IL_0002: Expected F8, but got I4
			*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0003: Unknown opcode: 0xB1*/;
		}
	}

	[BlackList]
	public unsafe float cameraFollowRngRadius
	{
		get
		{
			//IL_0002: Expected F8, but got I4
			*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0003: Unknown opcode: 0xB1*/;
		}
	}

	[BlackList]
	public unsafe float cameraOffsetRngRadius
	{
		get
		{
			//IL_0002: Expected F8, but got I4
			*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0003: Unknown opcode: 0xB1*/;
		}
	}

	[BlackList]
	public unsafe float cameraViewRngRadius
	{
		get
		{
			//IL_0002: Expected F8, but got I4
			*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0003: Unknown opcode: 0xB1*/;
		}
	}

	[BlackList]
	public unsafe float cameraAngle
	{
		get
		{
			//IL_0002: Expected F8, but got I4
			*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0003: Unknown opcode: 0xB1*/;
		}
	}

	[BlackList]
	public float cameraRotationAngle
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected I4, but got Unknown
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
	}

	[BlackList]
	public int reversalCameraRotationAngle
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	[BlackList]
	public AnimationCurve cameraFOVCurve
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected I4, but got Unknown
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
			}
		}
	}

	[BlackList]
	public float CurrentFOV
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	[BlackList]
	public float CurrentZoomNormalized
	{
		get
		{
			/*Error: Unknown opcode: 0xE9*/;
		}
	}

	[BlackList]
	public AnimationCurve cameraHeightCurve
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected I4, but got Unknown
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
			}
		}
	}

	[BlackList]
	public Vector2 cameraScaleRng
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0003: Expected I8, but got I4
			((long[])/*Error near IL_0003: Stack underflow*/)[checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/)] = 0L;
			_ = ((IntPtr[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/];
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	[BlackList]
	public unsafe float cameraHeightOffset
	{
		get
		{
			//IL_0002: Expected F8, but got I4
			*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0003: Unknown opcode: 0xB1*/;
		}
	}

	[BlackList]
	public unsafe float cameraHorizontalOffset
	{
		get
		{
			//IL_0002: Expected F8, but got I4
			*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0003: Unknown opcode: 0xB1*/;
		}
	}

	public unsafe bool enableCameraDragRng
	{
		get
		{
			//IL_0002: Expected F8, but got I4
			*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0003: Unknown opcode: 0xB1*/;
		}
	}

	[BlackList]
	public unsafe float2 cameraDragRngHorizontal
	{
		get
		{
			//IL_0002: Expected F8, but got I4
			*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0003: Unknown opcode: 0xB1*/;
		}
	}

	[BlackList]
	public unsafe float2 cameraDragRngVertical
	{
		get
		{
			//IL_0002: Expected F8, but got I4
			*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0003: Unknown opcode: 0xB1*/;
		}
	}

	[BlackList]
	public AnimationCurve focusMoveEaseCurve
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected I4, but got Unknown
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
			}
		}
	}

	[BlackList]
	public AnimationCurve focusZoomEaseCurve
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected I4, but got Unknown
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
			}
		}
	}

	[BlackList]
	public AnimationCurve focusMoveDurationCurve
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected I4, but got Unknown
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
			}
		}
	}

	[BlackList]
	public bool cameraControlEnabled
	{
		get
		{
			switch ((uint)checked((nuint)/*Error near IL_0001: Stack underflow*/))
			{
			default:
				/*Error: End of method reached without returning.*/;
			}
		}
	}

	public Transform focusTarget
	{
		get
		{
			/*Error: Unknown opcode: 0xE9*/;
		}
	}

	private float FocusPhaseDuration
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected I4, but got Unknown
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
			}
		}
	}

	private bool FocusLinearActive
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Expected I4, but got Unknown
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
			}
		}
	}

	public bool IsFocusing
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	public bool hasViewCameraSnapshot
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	public HashSet<Outlinable> activedHighlightOutlines
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		private set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public void InitCameraController()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public void ReleaseCameraController()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	private void LateUpdate()
	{
		/*Error: Unknown opcode: 0xE9*/;
	}

	protected override void OnDestroy()
	{
		// ILSpy could not decompile this member: Error decompiling @06002FC8 DormCameraController.OnDestroy: Invalid token. (Parameter 'token')
		// Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// Error decompiling @06002FC8 DormCameraController.OnDestroy
		// in assembly "D:\Libraries\Downloads\Hotfix_full.dll"
		//  ---> System.ArgumentException: Invalid token. (Parameter 'token')
		//    at System.Reflection.Throw.InvalidToken() in offset 15
		//    at ICSharpCode.Decompiler.IL.ILReader.DecodeCall(OpCode opCode) in ILReader.cs:line 1760
		//    at ICSharpCode.Decompiler.IL.ILReader.DecodeInstruction() in ILReader.cs:line 1083
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadBlock(ImportedBlock block, CancellationToken cancellationToken) in ILReader.cs:line 539
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in ILReader.cs:line 506
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in ILReader.cs:line 726
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in CSharpDecompiler.cs:line 2412
		// -- continuing with outer exception (ICSharpCode.Decompiler.DecompilerException) --
		// 
	}

	[BlackList]
	public float GetRotateDurationTime()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected I4, but got Unknown
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

	public void OverrideCameraConfig(DormCameraConfigureData configureData)
	{
		/*Error: Unknown opcode: 0xE9*/;
	}

	public void CameraControlEnable()
	{
		// ILSpy could not decompile this member: Error decompiling @06002FE1 DormCameraController.CameraControlEnable: Invalid token. (Parameter 'token')
		// Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// Error decompiling @06002FE1 DormCameraController.CameraControlEnable
		// in assembly "D:\Libraries\Downloads\Hotfix_full.dll"
		//  ---> System.ArgumentException: Invalid token. (Parameter 'token')
		//    at System.Reflection.Throw.InvalidToken() in offset 15
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadAndDecodeTypeReference() in ILReader.cs:line 239
		//    at ICSharpCode.Decompiler.IL.ILReader.DecodeInstruction() in ILReader.cs:line 1217
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadBlock(ImportedBlock block, CancellationToken cancellationToken) in ILReader.cs:line 539
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in ILReader.cs:line 506
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in ILReader.cs:line 726
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in CSharpDecompiler.cs:line 2412
		// -- continuing with outer exception (ICSharpCode.Decompiler.DecompilerException) --
		// 
	}

	public void CameraControlDisable()
	{
		// ILSpy could not decompile this member: Error decompiling @06002FE2 DormCameraController.CameraControlDisable: Invalid token. (Parameter 'token')
		// Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// Error decompiling @06002FE2 DormCameraController.CameraControlDisable
		// in assembly "D:\Libraries\Downloads\Hotfix_full.dll"
		//  ---> System.ArgumentException: Invalid token. (Parameter 'token')
		//    at System.Reflection.Throw.InvalidToken() in offset 15
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadAndDecodeTypeReference() in ILReader.cs:line 239
		//    at ICSharpCode.Decompiler.IL.ILReader.DecodeInstruction() in ILReader.cs:line 1217
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadBlock(ImportedBlock block, CancellationToken cancellationToken) in ILReader.cs:line 539
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadInstructions(CancellationToken cancellationToken) in ILReader.cs:line 506
		//    at ICSharpCode.Decompiler.IL.ILReader.ReadIL(MethodDefinitionHandle method, MethodBodyBlock body, GenericContext genericContext, ILFunctionKind kind, CancellationToken cancellationToken) in ILReader.cs:line 726
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in CSharpDecompiler.cs:line 2412
		// -- continuing with outer exception (ICSharpCode.Decompiler.DecompilerException) --
		// 
	}

	private void InitCameraValue()
	{
		/*Error: Unknown opcode: 0xE9*/;
	}

	protected void UpdateCameraFollowTargetPosition(bool initialize, float dt)
	{
		/*Error: Unknown opcode: 0xE9*/;
	}

	private Vector3 ClampToDragRng(Vector3 pos)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	private void UpdateCameraValue(float dt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected I4, but got Unknown
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
		case 26:
			/*Error: Invalid branch target*/;
		case 27:
			/*Error: Invalid branch target*/;
		case 28:
			/*Error: Invalid branch target*/;
		case 29:
			/*Error: Invalid branch target*/;
		case 30:
			/*Error: Invalid branch target*/;
		case 31:
			/*Error: Invalid branch target*/;
		case 32:
			/*Error: Invalid branch target*/;
		case 33:
			/*Error: Invalid branch target*/;
		case 34:
			/*Error: Invalid branch target*/;
		case 35:
			/*Error: Invalid branch target*/;
		case 36:
			/*Error: Invalid branch target*/;
		case 37:
			/*Error: Invalid branch target*/;
		case 38:
			/*Error: Invalid branch target*/;
		case 39:
			/*Error: Invalid branch target*/;
		case 40:
			/*Error: Invalid branch target*/;
		case 41:
			/*Error: Invalid branch target*/;
		case 42:
			/*Error: Invalid branch target*/;
		case 43:
			/*Error: Invalid branch target*/;
		case 44:
			/*Error: Invalid branch target*/;
		case 45:
			/*Error: Invalid branch target*/;
		case 46:
			/*Error: Invalid branch target*/;
		case 47:
			/*Error: Invalid branch target*/;
		case 48:
			/*Error: Invalid branch target*/;
		case 49:
			/*Error: Invalid branch target*/;
		case 50:
			/*Error: Invalid branch target*/;
		case 51:
			/*Error: Invalid branch target*/;
		case 52:
			/*Error: Invalid branch target*/;
		case 53:
			/*Error: Invalid branch target*/;
		case 54:
			/*Error: Invalid branch target*/;
		case 55:
			/*Error: Invalid branch target*/;
		case 56:
			/*Error: Invalid branch target*/;
		case 57:
			/*Error: Invalid branch target*/;
		case 58:
			/*Error: Invalid branch target*/;
		case 59:
			/*Error: Invalid branch target*/;
		case 60:
			/*Error: Invalid branch target*/;
		case 61:
			/*Error: Invalid branch target*/;
		case 62:
			/*Error: Invalid branch target*/;
		case 63:
			/*Error: Invalid branch target*/;
		case 64:
			/*Error: Invalid branch target*/;
		case 65:
			/*Error: Invalid branch target*/;
		case 66:
			/*Error: Invalid branch target*/;
		case 67:
			/*Error: Invalid branch target*/;
		case 68:
			/*Error: Invalid branch target*/;
		case 69:
			/*Error: Invalid branch target*/;
		case 70:
			/*Error: Invalid branch target*/;
		case 71:
			/*Error: Invalid branch target*/;
		case 72:
			/*Error: Invalid branch target*/;
		case 73:
			/*Error: Invalid branch target*/;
		case 74:
			/*Error: Invalid branch target*/;
		case 75:
			/*Error: Invalid branch target*/;
		case 76:
			/*Error: Invalid branch target*/;
		case 77:
			/*Error: Invalid branch target*/;
		case 78:
			/*Error: Invalid branch target*/;
		case 79:
			/*Error: Invalid branch target*/;
		case 80:
			/*Error: Invalid branch target*/;
		case 81:
			/*Error: Invalid branch target*/;
		case 82:
			/*Error: Invalid branch target*/;
		case 83:
			/*Error: Invalid branch target*/;
		case 84:
			/*Error: Invalid branch target*/;
		case 85:
			/*Error: Invalid branch target*/;
		case 86:
			/*Error: Invalid branch target*/;
		case 87:
			/*Error: Invalid branch target*/;
		case 88:
			/*Error: Invalid branch target*/;
		case 89:
			/*Error: Invalid branch target*/;
		case 90:
			/*Error: Invalid branch target*/;
		case 91:
			/*Error: Invalid branch target*/;
		case 92:
			/*Error: Invalid branch target*/;
		case 93:
			/*Error: Invalid branch target*/;
		case 94:
			/*Error: Invalid branch target*/;
		case 95:
			/*Error: Invalid branch target*/;
		case 96:
			/*Error: Invalid branch target*/;
		case 97:
			/*Error: Invalid branch target*/;
		case 98:
			/*Error: Invalid branch target*/;
		case 99:
			/*Error: Invalid branch target*/;
		case 100:
			/*Error: Invalid branch target*/;
		case 101:
			/*Error: Invalid branch target*/;
		case 102:
			/*Error: Invalid branch target*/;
		case 103:
			/*Error: Invalid branch target*/;
		case 104:
			/*Error: Invalid branch target*/;
		case 105:
			/*Error: Invalid branch target*/;
		case 106:
			/*Error: Invalid branch target*/;
		case 107:
			/*Error: Invalid branch target*/;
		case 108:
			/*Error: Invalid branch target*/;
		case 109:
			/*Error: Invalid branch target*/;
		case 110:
			/*Error: Invalid branch target*/;
		case 111:
			/*Error: Invalid branch target*/;
		case 112:
			/*Error: Invalid branch target*/;
		case 113:
			/*Error: Invalid branch target*/;
		case 114:
			/*Error: Invalid branch target*/;
		case 115:
			/*Error: Invalid branch target*/;
		case 116:
			/*Error: Invalid branch target*/;
		case 117:
			/*Error: Invalid branch target*/;
		case 118:
			/*Error: Invalid branch target*/;
		case 119:
			/*Error: Invalid branch target*/;
		case 120:
			/*Error: Invalid branch target*/;
		case 121:
			/*Error: Invalid branch target*/;
		case 122:
			/*Error: Invalid branch target*/;
		case 123:
			/*Error: Invalid branch target*/;
		case 124:
			/*Error: Invalid branch target*/;
		case 125:
			/*Error: Invalid branch target*/;
		case 126:
			/*Error: Invalid branch target*/;
		case 127:
			/*Error: Invalid branch target*/;
		case 128:
			/*Error: Invalid branch target*/;
		case 129:
			/*Error: Invalid branch target*/;
		case 130:
			/*Error: Invalid branch target*/;
		case 131:
			/*Error: Invalid branch target*/;
		case 132:
			/*Error: Invalid branch target*/;
		case 133:
			/*Error: Invalid branch target*/;
		case 134:
			/*Error: Invalid branch target*/;
		case 135:
			/*Error: Invalid branch target*/;
		case 136:
			/*Error: Invalid branch target*/;
		case 137:
			/*Error: Invalid branch target*/;
		case 138:
			/*Error: Invalid branch target*/;
		case 139:
			/*Error: Invalid branch target*/;
		case 140:
			/*Error: Invalid branch target*/;
		case 141:
			/*Error: Invalid branch target*/;
		case 142:
			/*Error: Invalid branch target*/;
		case 143:
			/*Error: Invalid branch target*/;
		case 144:
			/*Error: Invalid branch target*/;
		case 145:
			/*Error: Invalid branch target*/;
		case 146:
			/*Error: Invalid branch target*/;
		case 147:
			/*Error: Invalid branch target*/;
		case 148:
			/*Error: Invalid branch target*/;
		case 149:
			/*Error: Invalid branch target*/;
		case 150:
			/*Error: Invalid branch target*/;
		case 151:
			/*Error: Invalid branch target*/;
		case 152:
			/*Error: Invalid branch target*/;
		case 153:
			/*Error: Invalid branch target*/;
		case 154:
			/*Error: Invalid branch target*/;
		}
	}

	private Vector3 ComputeFollowOffset(float rotationAngle, float xzDistance)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected I8, but got I4
		((long[])/*Error near IL_0003: Stack underflow*/)[checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/)] = 0L;
		_ = ((IntPtr[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/];
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	private void UpdateCamera()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (checked(/*Error near IL_0001: Stack underflow*/ - /*Error near IL_0001: Stack underflow*/) == 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0003: Unknown opcode: 0xC9*/;
	}

	public void BindFocusObject(GameObject obj, bool groundBased = true)
	{
		/*Error: Unknown opcode: 0xF0*/;
	}

	public void BindFocusObjectDefault()
	{
		/*Error: Unknown opcode: 0xE9*/;
	}

	private void TickFocusTransitionT(float dt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = ((IntPtr[])checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))[0];
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	private float FocusLinearT(float dt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			_ = 6;
			/*Error near IL_0002: Unknown opcode: 0xCC*/;
		}
	}

	private float DampOrLinear(float current, float target, ref float velocity, float dt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = ((IntPtr[])checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))[0u];
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public void EnterFocus(Vector3 worldPos, float depthScale, float transitionDuration = -1f, float settleEpsilon = 0.01f, float pitchDegrees = -1f, float minDepth = -1f, bool ignoreFollowDeadzone = false, bool lockPoseFromEntry = false, bool smoothEase = false, float aimHeightOffset = 0f, float moveSpeed = -1f, bool keepPointOnExit = false, bool singleBlend = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected I4, but got Unknown
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
		case 26:
			/*Error: Invalid branch target*/;
		case 27:
			/*Error: Invalid branch target*/;
		case 28:
			/*Error: Invalid branch target*/;
		case 29:
			/*Error: Invalid branch target*/;
		case 30:
			/*Error: Invalid branch target*/;
		case 31:
			/*Error: Invalid branch target*/;
		case 32:
			/*Error: Invalid branch target*/;
		case 33:
			/*Error: Invalid branch target*/;
		case 34:
			/*Error: Invalid branch target*/;
		case 35:
			/*Error: Invalid branch target*/;
		case 36:
			/*Error: Invalid branch target*/;
		case 37:
			/*Error: Invalid branch target*/;
		case 38:
			/*Error: Invalid branch target*/;
		case 39:
			/*Error: Invalid branch target*/;
		case 40:
			/*Error: Invalid branch target*/;
		case 41:
			/*Error: Invalid branch target*/;
		case 42:
			/*Error: Invalid branch target*/;
		case 43:
			/*Error: Invalid branch target*/;
		case 44:
			/*Error: Invalid branch target*/;
		case 45:
			/*Error: Invalid branch target*/;
		case 46:
			/*Error: Invalid branch target*/;
		case 47:
			/*Error: Invalid branch target*/;
		case 48:
			/*Error: Invalid branch target*/;
		case 49:
			/*Error: Invalid branch target*/;
		case 50:
			/*Error: Invalid branch target*/;
		case 51:
			/*Error: Invalid branch target*/;
		case 52:
			/*Error: Invalid branch target*/;
		case 53:
			/*Error: Invalid branch target*/;
		case 54:
			/*Error: Invalid branch target*/;
		case 55:
			/*Error: Invalid branch target*/;
		case 56:
			/*Error: Invalid branch target*/;
		case 57:
			/*Error: Invalid branch target*/;
		case 58:
			/*Error: Invalid branch target*/;
		case 59:
			/*Error: Invalid branch target*/;
		case 60:
			/*Error: Invalid branch target*/;
		case 61:
			/*Error: Invalid branch target*/;
		case 62:
			/*Error: Invalid branch target*/;
		case 63:
			/*Error: Invalid branch target*/;
		case 64:
			/*Error: Invalid branch target*/;
		case 65:
			/*Error: Invalid branch target*/;
		case 66:
			/*Error: Invalid branch target*/;
		case 67:
			/*Error: Invalid branch target*/;
		case 68:
			/*Error: Invalid branch target*/;
		case 69:
			/*Error: Invalid branch target*/;
		case 70:
			/*Error: Invalid branch target*/;
		case 71:
			/*Error: Invalid branch target*/;
		case 72:
			/*Error: Invalid branch target*/;
		case 73:
			/*Error: Invalid branch target*/;
		case 74:
			/*Error: Invalid branch target*/;
		case 75:
			/*Error: Invalid branch target*/;
		case 76:
			/*Error: Invalid branch target*/;
		case 77:
			/*Error: Invalid branch target*/;
		case 78:
			/*Error: Invalid branch target*/;
		case 79:
			/*Error: Invalid branch target*/;
		case 80:
			/*Error: Invalid branch target*/;
		case 81:
			/*Error: Invalid branch target*/;
		case 82:
			/*Error: Invalid branch target*/;
		case 83:
			/*Error: Invalid branch target*/;
		case 84:
			/*Error: Invalid branch target*/;
		case 85:
			/*Error: Invalid branch target*/;
		case 86:
			/*Error: Invalid branch target*/;
		case 87:
			/*Error: Invalid branch target*/;
		case 88:
			/*Error: Invalid branch target*/;
		case 89:
			/*Error: Invalid branch target*/;
		case 90:
			/*Error: Invalid branch target*/;
		case 91:
			/*Error: Invalid branch target*/;
		case 92:
			/*Error: Invalid branch target*/;
		case 93:
			/*Error: Invalid branch target*/;
		case 94:
			/*Error: Invalid branch target*/;
		case 95:
			/*Error: Invalid branch target*/;
		case 96:
			/*Error: Invalid branch target*/;
		case 97:
			/*Error: Invalid branch target*/;
		case 98:
			/*Error: Invalid branch target*/;
		case 99:
			/*Error: Invalid branch target*/;
		case 100:
			/*Error: Invalid branch target*/;
		case 101:
			/*Error: Invalid branch target*/;
		case 102:
			/*Error: Invalid branch target*/;
		case 103:
			/*Error: Invalid branch target*/;
		case 104:
			/*Error: Invalid branch target*/;
		case 105:
			/*Error: Invalid branch target*/;
		case 106:
			/*Error: Invalid branch target*/;
		case 107:
			/*Error: Invalid branch target*/;
		case 108:
			/*Error: Invalid branch target*/;
		case 109:
			/*Error: Invalid branch target*/;
		case 110:
			/*Error: Invalid branch target*/;
		case 111:
			/*Error: Invalid branch target*/;
		case 112:
			/*Error: Invalid branch target*/;
		case 113:
			/*Error: Invalid branch target*/;
		case 114:
			/*Error: Invalid branch target*/;
		case 115:
			/*Error: Invalid branch target*/;
		case 116:
			/*Error: Invalid branch target*/;
		case 117:
			/*Error: Invalid branch target*/;
		case 118:
			/*Error: Invalid branch target*/;
		case 119:
			/*Error: Invalid branch target*/;
		case 120:
			/*Error: Invalid branch target*/;
		case 121:
			/*Error: Invalid branch target*/;
		case 122:
			/*Error: Invalid branch target*/;
		case 123:
			/*Error: Invalid branch target*/;
		case 124:
			/*Error: Invalid branch target*/;
		case 125:
			/*Error: Invalid branch target*/;
		case 126:
			/*Error: Invalid branch target*/;
		case 127:
			/*Error: Invalid branch target*/;
		case 128:
			/*Error: Invalid branch target*/;
		case 129:
			/*Error: Invalid branch target*/;
		case 130:
			/*Error: Invalid branch target*/;
		case 131:
			/*Error: Invalid branch target*/;
		case 132:
			/*Error: Invalid branch target*/;
		case 133:
			/*Error: Invalid branch target*/;
		case 134:
			/*Error: Invalid branch target*/;
		case 135:
			/*Error: Invalid branch target*/;
		case 136:
			/*Error: Invalid branch target*/;
		case 137:
			/*Error: Invalid branch target*/;
		case 138:
			/*Error: Invalid branch target*/;
		case 139:
			/*Error: Invalid branch target*/;
		case 140:
			/*Error: Invalid branch target*/;
		case 141:
			/*Error: Invalid branch target*/;
		case 142:
			/*Error: Invalid branch target*/;
		case 143:
			/*Error: Invalid branch target*/;
		case 144:
			/*Error: Invalid branch target*/;
		case 145:
			/*Error: Invalid branch target*/;
		case 146:
			/*Error: Invalid branch target*/;
		case 147:
			/*Error: Invalid branch target*/;
		case 148:
			/*Error: Invalid branch target*/;
		case 149:
			/*Error: Invalid branch target*/;
		case 150:
			/*Error: Invalid branch target*/;
		case 151:
			/*Error: Invalid branch target*/;
		case 152:
			/*Error: Invalid branch target*/;
		case 153:
			/*Error: Invalid branch target*/;
		case 154:
			/*Error: Invalid branch target*/;
		case 155:
			/*Error: Invalid branch target*/;
		case 156:
			/*Error: Invalid branch target*/;
		case 157:
			/*Error: Invalid branch target*/;
		case 158:
			/*Error: Invalid branch target*/;
		case 159:
			/*Error: Invalid branch target*/;
		case 160:
			/*Error: Invalid branch target*/;
		case 161:
			/*Error: Invalid branch target*/;
		case 162:
			/*Error: Invalid branch target*/;
		case 163:
			/*Error: Invalid branch target*/;
		case 164:
			/*Error: Invalid branch target*/;
		case 165:
			/*Error: Invalid branch target*/;
		}
	}

	private void TickFocusStage()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected I4, but got Unknown
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
		}
	}

	public void UpdateFocusPoint(Vector3 worldPos)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected I4, but got Unknown
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

	public void UpdateFocusSideView(bool enable, Vector3 playerPos, Vector3 actorPos, float sideYawOffset)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected F4, but got I
		_003F val = checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		_003F val2 = /*Error near IL_0001: ldloca 211 (out-of-bounds)*/;
		/*OpCode not supported: DebugBreak*/;
		((float[])/*Error near IL_0006: Stack underflow*/)[/*Error near IL_0006: Stack underflow*/] = (nint)((IntPtr[])val)[val2];
		_ = ((long[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/];
		/*Error near IL_0008: Invalid metadata token*/;
	}

	public void ExitFocus()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected I4, but got Unknown
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
		case 26:
			/*Error: Invalid branch target*/;
		case 27:
			/*Error: Invalid branch target*/;
		case 28:
			/*Error: Invalid branch target*/;
		case 29:
			/*Error: Invalid branch target*/;
		case 30:
			/*Error: Invalid branch target*/;
		case 31:
			/*Error: Invalid branch target*/;
		case 32:
			/*Error: Invalid branch target*/;
		case 33:
			/*Error: Invalid branch target*/;
		case 34:
			/*Error: Invalid branch target*/;
		case 35:
			/*Error: Invalid branch target*/;
		case 36:
			/*Error: Invalid branch target*/;
		case 37:
			/*Error: Invalid branch target*/;
		case 38:
			/*Error: Invalid branch target*/;
		case 39:
			/*Error: Invalid branch target*/;
		case 40:
			/*Error: Invalid branch target*/;
		case 41:
			/*Error: Invalid branch target*/;
		case 42:
			/*Error: Invalid branch target*/;
		case 43:
			/*Error: Invalid branch target*/;
		case 44:
			/*Error: Invalid branch target*/;
		case 45:
			/*Error: Invalid branch target*/;
		case 46:
			/*Error: Invalid branch target*/;
		case 47:
			/*Error: Invalid branch target*/;
		case 48:
			/*Error: Invalid branch target*/;
		case 49:
			/*Error: Invalid branch target*/;
		case 50:
			/*Error: Invalid branch target*/;
		case 51:
			/*Error: Invalid branch target*/;
		case 52:
			/*Error: Invalid branch target*/;
		case 53:
			/*Error: Invalid branch target*/;
		}
	}

	private void TickFocusTransitionSettle()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected I4, but got Unknown
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

	private void ResetCameraDampVelocities()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	public void UpdateCameraDepthValue(bool mouseScrollWheelHasInput, float mouseScrollWheelInput)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected I4, but got Unknown
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

	public void UpdateCameraDepthByPinch(bool hasInput, float pinchDelta)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected I4, but got Unknown
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
		}
	}

	public void UpdateCameraShiftValue(bool camerShiftHasInput, Vector2 cameraShiftValue)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected I4, but got Unknown
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
		case 26:
			/*Error: Invalid branch target*/;
		case 27:
			/*Error: Invalid branch target*/;
		case 28:
			/*Error: Invalid branch target*/;
		case 29:
			/*Error: Invalid branch target*/;
		case 30:
			/*Error: Invalid branch target*/;
		case 31:
			/*Error: Invalid branch target*/;
		case 32:
			/*Error: Invalid branch target*/;
		case 33:
			/*Error: Invalid branch target*/;
		case 34:
			/*Error: Invalid branch target*/;
		}
	}

	public void UpdateCameraRotateByDrag(bool hasInput, Vector2 dragDelta, float rangeLimit = -1f)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected I4, but got Unknown
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
		}
	}

	public void ResetCameraRotateDragOffset()
	{
		/*Error near IL_0001: Not a type handle*/;
	}

	public void SetDragRngCenter(Vector3 worldCenter)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}

	public void CenterBeaconToDragRngCenter()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected I4, but got Unknown
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
		}
	}

	public void SaveViewCameraState()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid calli metadata token*/;
		}
	}

	public void RestoreViewCameraState()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected I4, but got Unknown
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
		}
	}

	public unsafe void DiscardViewCameraState()
	{
		System.Runtime.CompilerServices.Unsafe.Read<object>((void*)checked((nuint)/*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0002: Unknown opcode: 0xF7*/;
	}

	public void EnableCloseupCamera()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0007: Invalid metadata token*/;
	}

	public void DisableCloseupCamera()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0007: Invalid metadata token*/;
	}

	private void InitCameraRendering()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	private void ReleaseCameraRendering()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public void ActiveHighlightOutline(GameObject target)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Invalid comparison between Unknown and I4
		if (checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/) == 0)
		{
			/*Error: Invalid branch target*/;
		}
		if ((int)/*Error near IL_0006: Stack underflow*/ >= checked((int)/*Error near IL_0004: Stack underflow*/))
		{
			/*Error near IL_0006: Invalid metadata token*/;
		}
		/*Error near IL_0023: ldarg 3 (out-of-bounds)*/;
		/*Error near IL_0024: Unknown opcode: 0xCA*/;
	}

	public void DeactiveHighlightOutline(GameObject target)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Invalid comparison between Unknown and I4
		if (checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/) == 0)
		{
			/*Error: Invalid branch target*/;
		}
		if ((int)/*Error near IL_0006: Stack underflow*/ < checked((int)/*Error near IL_0004: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: Invalid metadata token*/;
	}

	public DormCameraController()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = (nuint)6u;
			/*Error near IL_0003: Unknown opcode: 0xEB*/;
		}
	}

	static DormCameraController()
	{
		/*Error: Unknown opcode: 0xF7*/;
	}
}
