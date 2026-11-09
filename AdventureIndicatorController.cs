using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Game.Graphics.HighlightOutliner;
using Game.Graphics.Overdrawer;
using UnityEngine;

public class AdventureIndicatorController : SceneSingleton<AdventureIndicatorController>
{
	[Header("Graphic Indicator:")]
	public Transform indicatorsRootNode;

	public Transform graphicIndicatorRootNode;

	[Space]
	public GameObject circleGraphicIndicatorPrefab;

	public GameObject fanGraphicIndicatorPrefab;

	public GameObject rectangleGraphicIndicatorPrefab;

	public GameObject ringGraphicIndicatorPrefab;

	public GameObject lineGraphicIndicatorPrefab;

	[Space]
	public GameObject[] targetRangeGraphicIndicatorPrefabs;

	[Header("Highlight Outliner:")]
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

	[Space]
	public Material occlusionHighlightMaterial;

	private readonly Dictionary<int, FanGraphicIndicator> targetFanIndicatorLs;

	private TrueSyncTransform _target;

	private ActorSearchTarget _AcT;

	public static int showIndicatorMode;

	public static List<bool> indicatorLs;

	private FanGraphicIndicator _value;

	[NonSerialized]
	public GameObject blobIndicatorsRootNode;

	[NonSerialized]
	public AdventureShadowBlob shadowBlob;

	[NonSerialized]
	public AdventureTargetBlob targetBlob;

	[NonSerialized]
	public AdventureHighlightBlob highlightBlob;

	[NonSerialized]
	public AdventureJoyStickBlob joyStickBlob;

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

	public HashSet<Overdrawable> activedOcclusionHighlights
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

	public void Setup(HotfixEnum.worldLevelType levelType)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public void Release()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public void DriveLateUpdate()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected I4, but got Unknown
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
		}
	}

	public unsafe void SetupDefaultBlobIndicators()
	{
		//IL_0001: Invalid comparison between Unknown and I4
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		if ((int)/*Error near IL_0006: Stack underflow*/ > (int)(*(byte*)(nint)/*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		((IntPtr[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/] = (IntPtr)/*Error near IL_0007: Stack underflow*/;
		_ = /*Error near IL_0008: Stack underflow*/| /*Error near IL_0008: Stack underflow*/;
		/*Error near IL_0008: Invalid metadata token*/;
	}

	public unsafe void SetupEmptyBlobIndicators()
	{
		_ = *(byte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xBF*/;
	}

	public void SetupBlobIndicators(GameObject newBlobIndicatorsRootNode)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) >= 0)
		{
			/*Error: Invalid branch target*/;
		}
		if (/*Error near IL_000c: Stack underflow*/ >= /*Error near IL_000c: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_000c: Invalid branch target*/;
	}

	public void DestroyBlobIndicators()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected I4, but got Unknown
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

	public void ShowHighlightBlob(bool show)
	{
		/*Error: Unknown opcode: 0xE9*/;
	}

	public void ShowBlobIndicatorsRootNode(bool show)
	{
		/*Error: Unknown opcode: 0xE9*/;
	}

	public void ShowIndicatorN(bool showIndicator, ActorSearchTarget AcT, TrueSyncTransform targetTs = null)
	{
	}

	private void ShowIndicator(bool showIndicator, TrueSyncTransform targetTs = null, float _size = 5f, float _angel = 45f, ActorSearchTarget AcT = null, int _prefabIndex = 0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 218 (out-of-bounds)*/;
			/*Error near IL_0004: Unknown opcode: 0xEE*/;
		}
	}

	public void FadeInTargetBlobRangeGraphic()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected I4, but got Unknown
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

	public void HintAttackRangeGraphic(float fadeInTime = 0.3f, float duration = 0.7f, Action onFinish = null)
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

	public void StartHintAttackRangeGraphic(float fadeInTime = 0.3f)
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

	public void StopHintAttackRangeGraphic(float fadeInTime = 0.3f)
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

	protected unsafe T SpawnGraphicIndicator<T>(GameObject graphicIndicatorPrefab) where T : BaseGraphicIndicator
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and F8
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if ((double)/*Error near IL_0008: Stack underflow*/ != (double)(*(ulong*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)))
		{
			/*Error: Invalid branch target*/;
		}
		_ = /*Error near IL_000c: Stack underflow*/>> (int)checked((uint)(double)/*Error near IL_0008: Stack underflow*/);
		/*Error near IL_000c: Invalid branch target*/;
	}

	public CircleGraphicIndicator SpawnCircleGraphicIndicator(GameObject indicatorPrefab = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: Invalid metadata token*/;
	}

	public FanGraphicIndicator SpawnFanGraphicIndicator(GameObject indicatorPrefab = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: Invalid metadata token*/;
	}

	public RectangleGraphicIndicator SpawnRectangleGraphicIndicator(GameObject indicatorPrefab = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: Invalid metadata token*/;
	}

	public RingGraphicIndicator SpawnRingGraphicIndicator(GameObject indicatorPrefab = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: Invalid metadata token*/;
	}

	public LineGraphicIndicator SpawnLineGraphicIndicator(GameObject indicatorPrefab = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: Invalid metadata token*/;
	}

	public unsafe void DespawnGraphicInspector(BaseGraphicIndicator graphicInspectorInstance)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		//IL_0008: Invalid comparison between Unknown and I8
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
		if ((long)/*Error near IL_000d: Stack underflow*/ >= (long)checked((ulong)(-15274880)))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_000d: Unknown opcode: 0xE1*/;
	}

	public void ActiveHighlightOutline(GameObject target, Color outlineColor)
	{
		/*Error: Unknown opcode: 0xFD*/;
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

	public void ActiveOcclusionHighlight(GameObject target)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Invalid comparison between Unknown and I4
		checked
		{
			if (/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/== 0)
			{
				/*Error: Invalid branch target*/;
			}
			if (unchecked((int)/*Error near IL_0006: Stack underflow*/) > (int)/*Error near IL_0004: Stack underflow*/)
			{
				/*Error near IL_0006: Invalid metadata token*/;
			}
			_ = (int)/*Error near IL_0024: Stack underflow*/;
			/*Error near IL_0024: Unknown opcode: 0xEC*/;
		}
	}

	public void DeactiveOcclusionHighlight(GameObject target)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Invalid comparison between Unknown and I4
		if (checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/) == 0)
		{
			/*Error: Invalid branch target*/;
		}
		if ((int)/*Error near IL_0006: Stack underflow*/ > checked((int)/*Error near IL_0004: Stack underflow*/))
		{
			/*Error near IL_0006: Invalid metadata token*/;
		}
		/*Error near IL_0023: Unknown opcode: 0xB2*/;
	}

	public AdventureIndicatorController()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid calli metadata token*/;
		}
	}

	static AdventureIndicatorController()
	{
		/*Error: Unknown opcode: 0xEB*/;
	}
}
