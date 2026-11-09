using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TrueSync;
using UnityEngine;

public class AdventureFXManager : SceneSingleton<AdventureFXManager>
{
	public enum CueEffectType
	{
		None,
		Hurt,
		SuperArmor,
		ImmuneControl,
		Invincible
	}

	public enum CueEffectTargetBodySize
	{
		Normal,
		Large
	}

	protected class TintEffectPair
	{
		public CueEffectType type;

		public RendererMaterialStackComponent component;

		public CustomModelMaterialVariantComponent customMaterialVariant;

		public bool isLoop;

		public float timer;

		public float duration;

		public TintCueEffectStyle style;

		public int priority;

		public CueEffectTargetBodySize bodySize;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int GetCueIndex()
		{
			if (type == CueEffectType.Hurt)
			{
				return 0;
			}
			return 1;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Clear()
		{
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			type = CueEffectType.None;
			component = null;
			customMaterialVariant = null;
			isLoop = false;
			timer = 0f;
			duration = 0f;
			style = (TintCueEffectStyle)0;
			priority = 0;
			bodySize = CueEffectTargetBodySize.Normal;
		}
	}

	public const long NULL_TOKEN = 0L;

	internal static long TOKEN_COUNTER = 0L;

	protected static float _globalTimeScale = 1f;

	protected Logger _logger;

	protected bool _lock;

	protected readonly List<AdventureFXHandler> _delayInsertList;

	protected readonly List<AdventureFXHandler> _delayDropList;

	protected List<TintEffectPair> tintCueEffects;

	protected List<TintEffectPair> tintCueEffectPool;

	protected bool tintCueEffectsDirty;

	public List<AdventureFXHandler> handlers
	{
		get;
		[CompilerGenerated]
		protected set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public static float globalTimeScale
	{
		get
		{
			if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
			{
				/*Error: Invalid branch target*/;
			}
			_ = -1;
			/*Error: End of method reached without returning.*/;
		}
		set
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
				/*Error near IL_0001: Unknown opcode: 0xBE*/;
			}
		}
	}

	public static Action<AdventureFXHandler> onFXHandlerSpawn
	{
		[CompilerGenerated]
		get
		{
			if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
			{
				/*Error: Invalid branch target*/;
			}
			_ = -1;
			/*Error: End of method reached without returning.*/;
		}
		[CompilerGenerated]
		set
		{
			/*Error: Invalid field token*/;
		}
	}

	public static Action<AdventureFXHandler> onFXHandlerDespawn
	{
		[CompilerGenerated]
		get
		{
			if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
			{
				/*Error: Invalid branch target*/;
			}
			_ = -1;
			/*Error: End of method reached without returning.*/;
		}
		[CompilerGenerated]
		set
		{
			/*Error: Invalid field token*/;
		}
	}

	public static Action<AdventureFXPlayer> onFXPlayerPlay
	{
		[CompilerGenerated]
		get
		{
			if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
			{
				/*Error: Invalid branch target*/;
			}
			_ = -1;
			/*Error: End of method reached without returning.*/;
		}
		[CompilerGenerated]
		set
		{
			/*Error: Invalid field token*/;
		}
	}

	public static Action<AdventureFXPlayer> onFXPlayerPlayInRemain
	{
		[CompilerGenerated]
		get
		{
			if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
			{
				/*Error: Invalid branch target*/;
			}
			_ = -1;
			/*Error: End of method reached without returning.*/;
		}
		[CompilerGenerated]
		set
		{
			/*Error: Invalid field token*/;
		}
	}

	public static Action<AdventureFXPlayer> onFXPlayerBind
	{
		[CompilerGenerated]
		get
		{
			if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
			{
				/*Error: Invalid branch target*/;
			}
			_ = -1;
			/*Error: End of method reached without returning.*/;
		}
		[CompilerGenerated]
		set
		{
			/*Error: Invalid field token*/;
		}
	}

	public static Action<AdventureFXPlayer> onFXPlayerOwnerActorBind
	{
		[CompilerGenerated]
		get
		{
			if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
			{
				/*Error: Invalid branch target*/;
			}
			_ = -1;
			/*Error: End of method reached without returning.*/;
		}
		[CompilerGenerated]
		set
		{
			/*Error: Invalid field token*/;
		}
	}

	public static bool IsPlayingTimeline
	{
		[CompilerGenerated]
		get
		{
			if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
			{
				/*Error: Invalid branch target*/;
			}
			_ = -1;
			/*Error: End of method reached without returning.*/;
		}
		[CompilerGenerated]
		set
		{
			/*Error: Invalid field token*/;
		}
	}

	protected override void Awake()
	{
		base.Awake();
		_logger = Singleton<LogManager>.Instance["\uf3c0ęŧÜ篦\ude746筲崭0\uf4c9X"];
	}

	internal void DriveUpdate()
	{
		_lock = true;
		for (int i = 0; i < handlers.Count; i++)
		{
			handlers[i].DoUpdate();
		}
		_lock = false;
		UpdateDelayRegisterList();
		UpdateExtensions();
	}

	internal void DriveLateUpdate()
	{
		_lock = true;
		for (int i = 0; i < handlers.Count; i++)
		{
			handlers[i].DoLateUpdate();
		}
		_lock = false;
		UpdateDelayRegisterList();
	}

	internal void RegisterFXHandler(AdventureFXHandler handler, bool delayInsert = false)
	{
		onFXHandlerSpawn?.Invoke(handler);
		if (!delayInsert)
		{
			handler.token = ++TOKEN_COUNTER;
		}
		if (_lock)
		{
			if (!_delayDropList.Remove(handler))
			{
				_delayInsertList.Add(handler);
			}
		}
		else
		{
			handlers.Add(handler);
		}
	}

	internal void UnRegisterFXHandler(AdventureFXHandler handler, bool delayDrop = false)
	{
		onFXHandlerDespawn?.Invoke(handler);
		if (!delayDrop)
		{
			handler.token = 0L;
		}
		if (_lock)
		{
			if (!_delayInsertList.Remove(handler))
			{
				_delayDropList.Add(handler);
			}
		}
		else
		{
			handlers.Remove(handler);
		}
	}

	protected void UpdateDelayRegisterList()
	{
		for (int i = 0; i < _delayDropList.Count; i++)
		{
			UnRegisterFXHandler(_delayDropList[i], delayDrop: true);
		}
		_delayDropList.Clear();
		for (int j = 0; j < _delayInsertList.Count; j++)
		{
			RegisterFXHandler(_delayInsertList[j], delayInsert: true);
		}
		_delayInsertList.Clear();
	}

	protected void OnGlobalTimeScaleChanged()
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public AdventureFXHandler FindHandlerByToken(int token)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public AdventureFXHandler FindHandlerByTag(string tag)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public unsafe void FindAllHandlersByTag(List<AdventureFXHandler> result, string tag)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0002: Invalid metadata token*/;
	}

	public void StopSubFXPlayers(long token, bool dontPlaySubFX = false)
	{
		/*Error: Unknown opcode: 0xE7*/;
	}

	public void StopAllFXPlayersByTag(string tag, bool dontPlaySubFX = false)
	{
		/*Error: Unknown opcode: 0xE7*/;
	}

	public void StopAllFXPlayersByOwner(GameObject owner = null, bool dontPlaySubFX = false)
	{
		/*Error: Unknown opcode: 0xE7*/;
	}

	public void StopAllFXPlayers(bool dontPlaySubFX = false)
	{
		/*Error: Unknown opcode: 0xE7*/;
	}

	public void InterruptFXPlayersByOwner(GameObject owner, bool dontPlaySubFX = false)
	{
		/*Error: Unknown opcode: 0xE7*/;
	}

	public void SetFXPlayersRenderLayerByTag(string tag, int layer)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public void SetFXPlayersRenderLayerByOwner(GameObject owner, int layer)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public void SetFXPlayersRenderLayerByOwnerActor(AdventureActor ownerActor, int layer, bool bindWithActorOnly = false)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public void ResetFXPlayersRenderLayerByTag(string tag)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public void ResetFXPlayersRenderLayerByOwner(GameObject owner)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public void ResetFXPlayersRenderLayerByOwnerActor(AdventureActor ownerActor)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public void ResetAllFXPlayersRenderLayer()
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public void HideAllFX()
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public void HideAllFX<T>() where T : AdventureFXHandler
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public void HideAllFXByTag(string tag)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public void VisibleAllFX()
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public void VisibleAllFX<T>() where T : AdventureFXHandler
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public void VisibleAllFXByTag(string tag)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public static GameObject PreloadFX(string assetPath = null, GameObject prefab = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) >= 0)
		{
			/*Error: Invalid branch target*/;
		}
		if (/*Error near IL_000c: Stack underflow*/ < /*Error near IL_000c: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		if (/*Error near IL_0011: Stack underflow*/ <= /*Error near IL_0011: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		if (/*Error near IL_0016: Stack underflow*/ <= /*Error near IL_0016: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0016: Unknown opcode: 0xFF*/;
	}

	public unsafe static AdventureFXPlayer PlayFX(string assetPath, float playbackSpeed, Vector3 spawnPosition, Quaternion spawnRotation, float spawnSize = 1f, Transform source = null, Vector3 sourcePosition = default(Vector3), Transform target = null, Vector3 targetPosition = default(Vector3))
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Expected I4, but got Unknown
		ulong num = *(byte*)(nint)/*Error near IL_0001: Stack underflow*/;
		_003F val = checked(/*Error near IL_0003: Stack underflow*/ - num);
		((sbyte[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/] = (sbyte)(int)val;
		_ = 8;
		/*Error near IL_0006: Unknown opcode: 0xFF*/;
	}

	public unsafe static AdventureEarlyWarningFXPlayer PlayEarlyWarningFX(string assetPath, float duration, Vector3 spawnPosition, Quaternion spawnRotation, float spawnSize = 1f)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Expected I4, but got Unknown
		ulong num = *(byte*)(nint)/*Error near IL_0001: Stack underflow*/;
		_003F val = checked(/*Error near IL_0003: Stack underflow*/ - num);
		((sbyte[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/] = (sbyte)(int)val;
		_ = 8;
		/*Error near IL_0006: Unknown opcode: 0xFF*/;
	}

	public unsafe static AdventureBuffFXHandler PlayBuffFX(string assetPath, GameObject owner, AdventureBuffFXHandler.FXPlayMode playMode = AdventureBuffFXHandler.FXPlayMode.Default, Vector3 fxPosition = default(Vector3), Quaternion fxRotation = default(Quaternion), float fxSize = 1f, AdventureActor targetActor = null)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Expected I4, but got Unknown
		ulong num = *(byte*)(nint)/*Error near IL_0001: Stack underflow*/;
		_003F val = checked(/*Error near IL_0003: Stack underflow*/ - num);
		((sbyte[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/] = (sbyte)(int)val;
		_ = 8;
		/*Error near IL_0006: Unknown opcode: 0xFF*/;
	}

	public unsafe static AdventureMarkFXHandler PlayMarkFX(string assetPath, AdventureActor owner, Transform syncNode, int initLevel = 1, float fxScale = 1f)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Expected I4, but got Unknown
		ulong num = *(byte*)(nint)/*Error near IL_0001: Stack underflow*/;
		_003F val = checked(/*Error near IL_0003: Stack underflow*/ - num);
		((sbyte[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/] = (sbyte)(int)val;
		_ = 8;
		/*Error near IL_0006: Unknown opcode: 0xFF*/;
	}

	public static GameObject PreloadSkillTimeline(string assetPath = null, GameObject prefab = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_000a: Expected F4, but got Obj
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) >= 0)
		{
			/*Error: Invalid branch target*/;
		}
		((float[])/*Error near IL_000a: Stack underflow*/)[/*Error near IL_0007: ldarg 2 (out-of-bounds)*/] = (float)assetPath;
		/*Error near IL_000a: Unknown opcode: 0xBF*/;
	}

	public unsafe static AdventureSkillTimelinePlayer PlaySkillTimeline(GameObject prefab, AdventureActor actor, Action onComplete)
	{
		checked
		{
			_ = (byte)unchecked((uint)(*(short*)(nint)/*Error near IL_0001: Stack underflow*/));
			/*Error near IL_0002: Unknown opcode: 0xFD*/;
		}
	}

	public static GameObject PreloadMonsterTimeline(string assetPath = null, GameObject prefab = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_000a: Expected F4, but got Obj
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) >= 0)
		{
			/*Error: Invalid branch target*/;
		}
		((float[])/*Error near IL_000a: Stack underflow*/)[/*Error near IL_0007: ldarg 2 (out-of-bounds)*/] = (float)assetPath;
		/*Error near IL_000a: Unknown opcode: 0xBF*/;
	}

	public static AdventureMonsterTimelinePlayer PlayMonsterTimeline(GameObject prefab, AdventureActor actor, Action onComplete)
	{
		_ = (long)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xCE*/;
	}

	protected TintEffectPair GenerateTintCueEffectPair()
	{
		/*Error: Unknown opcode: 0xE9*/;
	}

	protected void ReleaseTintCueEffectPair(TintEffectPair pair)
	{
		pair.Clear();
		tintCueEffectPool.Add(pair);
	}

	public static void PlayTintCueEffect(CueEffectType effectType, HotfixEnum.hurtFlashTintType hurtFlashType, GameObject source, GameObject target, RendererMaterialStackComponent targetMaterialController, CustomModelMaterialVariantComponent customMaterialVariant = null, GameObject effectPrefab = null, bool isEffectScale = false, float effectPlaybackSpeed = 1f, Bounds targetBounds = default(Bounds), FP targetBodySize = default(FP), Vector3 spawnPoint = default(Vector3), Quaternion spawnRotation = default(Quaternion), bool effectIgnoreTimeScale = true)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void StopTintCueEffect(CueEffectType effectType, GameObject source, GameObject target, RendererMaterialStackComponent targetMaterialController)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/- /*Error near IL_0001: Stack underflow*/;
		}
	}

	protected void UpdateTintCueEffects()
	{
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)ModuleController<AdventureModuleController>.Instance == (Object)null)
		{
			return;
		}
		float deltaTime = Time.deltaTime;
		AdventureModuleConfigureData config = AdventureModuleController.Config;
		if (tintCueEffectsDirty)
		{
			tintCueEffects.Sort((TintEffectPair a, TintEffectPair b) =>
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				//IL_0022: Expected I4, but got Unknown
				switch (checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/))
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
			});
			tintCueEffectsDirty = false;
		}
		for (int num = tintCueEffects.Count - 1; num >= 0; num--)
		{
			TintEffectPair tintEffectPair = tintCueEffects[num];
			if ((Object)(object)tintEffectPair.component == (Object)null)
			{
				tintCueEffects.RemoveAt(num);
				ReleaseTintCueEffectPair(tintEffectPair);
				continue;
			}
			tintEffectPair.timer += deltaTime;
			bool flag = tintEffectPair.timer > tintEffectPair.duration;
			if (tintEffectPair.isLoop)
			{
				if (flag)
				{
					tintEffectPair.timer -= tintEffectPair.duration;
				}
			}
			else if (flag)
			{
				GameRenderUtils.ResetTintCueEffect(tintEffectPair.component, tintEffectPair.GetCueIndex());
				tintCueEffects.RemoveAt(num);
				ReleaseTintCueEffectPair(tintEffectPair);
				continue;
			}
			Gradient val = null;
			float exposure = 0f;
			float num2 = 0f;
			float num3 = 0f;
			CustomModelMaterialVariantComponent customMaterialVariant = tintEffectPair.customMaterialVariant;
			switch (tintEffectPair.type)
			{
			case CueEffectType.Hurt:
				val = config.FX_HurtCueEffectGradient;
				exposure = config.FX_HurtCueEffectExposure;
				num2 = config.FX_HurtCueEffectStrokeWidth;
				num3 = config.FX_HurtCueEffectStrokeSmoothness;
				if ((Object)(object)customMaterialVariant != (Object)null && customMaterialVariant.enableCustomHurtCueEffect)
				{
					num2 = customMaterialVariant.customHurtCueEffectStrokeWidth;
					num3 = customMaterialVariant.customHurtCueEffectStrokeSmoothness;
				}
				break;
			case CueEffectType.SuperArmor:
				val = config.FX_SuperArmorCueEffectGradient;
				exposure = config.FX_SuperArmorCueEffectExposure;
				num2 = config.FX_SuperArmorCueEffectStrokeWidth;
				break;
			case CueEffectType.ImmuneControl:
				val = config.FX_ImmuneControlCueEffectGradient;
				exposure = config.FX_ImmuneControlCueEffectExposure;
				num2 = config.FX_ImmuneControlCueEffectStrokeWidth;
				break;
			case CueEffectType.Invincible:
				val = config.FX_InvincibleCueEffectGradient;
				exposure = config.FX_InvincibleCueEffectExposure;
				num2 = config.FX_InvincibleCueEffectStrokeWidth;
				break;
			}
			if (val != null)
			{
				Color val2 = EvaluateTint(tintEffectPair, val, exposure, tintEffectPair.timer / tintEffectPair.duration);
				GameRenderUtils.SetTintCueEffect(tintEffectPair.component, tintEffectPair.GetCueIndex(), val2, tintEffectPair.style, num2, num3);
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static Color EvaluateTint(TintEffectPair pair, Gradient gradient, float exposure, float t)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		Color result = gradient.Evaluate(t);
		if (exposure > float.Epsilon)
		{
			float num = Mathf.Pow(2f, exposure);
			result.r *= num;
			result.g *= num;
			result.b *= num;
		}
		return result;
	}

	public unsafe static void ClearFXInstancePool()
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		checked
		{
			_ = (byte)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0004: Unknown opcode: 0xE6*/;
		}
	}

	public unsafe static float CalcFXScaleWithBody(in Bounds bodyBounds, float scaleFactor, float minScale, float maxScale)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected native int or pointer, but got F8
		_ = *(byte*)(nint)(*(double*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	protected void UpdateExtensions()
	{
		UpdateTintCueEffects();
	}

	public AdventureFXManager()
	{
		handlers = new List<AdventureFXHandler>();
		_delayInsertList = new List<AdventureFXHandler>();
		_delayDropList = new List<AdventureFXHandler>();
		tintCueEffects = new List<TintEffectPair>(50);
		tintCueEffectPool = new List<TintEffectPair>(50);
		base._002Ector();
	}
}
