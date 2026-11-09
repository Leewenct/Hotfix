using System;

namespace XLua.CSObjectWrap;

public static class HotfixGenInitRegister
{
	public static void Register(ObjectTranslator translator)
	{
		if (translator != null)
		{
			translator.DelayWrapLoader(typeof(SoldierLevelController.SoldierMsg), (Action<IntPtr>)SoldierLevelControllerSoldierMsgWrap.__Register);
			translator.DelayWrapLoader(typeof(SoldierLevelController.SoldierLevelMsg), (Action<IntPtr>)SoldierLevelControllerSoldierLevelMsgWrap.__Register);
			translator.DelayWrapLoader(typeof(SoldierLevelController.SoldierAttr), (Action<IntPtr>)SoldierLevelControllerSoldierAttrWrap.__Register);
			translator.DelayWrapLoader(typeof(NovaAPIHotfix), (Action<IntPtr>)NovaAPIHotfixWrap.__Register);
			translator.DelayWrapLoader(typeof(SoldierActor), (Action<IntPtr>)SoldierActorWrap.__Register);
			translator.DelayWrapLoader(typeof(SoldierLevelController), (Action<IntPtr>)SoldierLevelControllerWrap.__Register);
			translator.DelayWrapLoader(typeof(DormModuleHelper_HotFix), (Action<IntPtr>)DormModuleHelper_HotFixWrap.__Register);
			translator.DelayWrapLoader(typeof(NovaAPI), (Action<IntPtr>)NovaAPIWrap.__Register);
			translator.DelayWrapLoader(typeof(AdventureModuleHelper), (Action<IntPtr>)AdventureModuleHelperWrap.__Register);
			translator.DelayWrapLoader(typeof(MainMenuModuleHelper), (Action<IntPtr>)MainMenuModuleHelperWrap.__Register);
			translator.DelayWrapLoader(typeof(InteractiveManager), (Action<IntPtr>)InteractiveManagerWrap.__Register);
			translator.DelayWrapLoader(typeof(FRIndicator), (Action<IntPtr>)FRIndicatorWrap.__Register);
			translator.DelayWrapLoader(typeof(HpBarColor), (Action<IntPtr>)HpBarColorWrap.__Register);
			translator.DelayWrapLoader(typeof(HpBarCanvasGroup), (Action<IntPtr>)HpBarCanvasGroupWrap.__Register);
			translator.DelayWrapLoader(typeof(HpBarRectTransform), (Action<IntPtr>)HpBarRectTransformWrap.__Register);
			translator.DelayWrapLoader(typeof(HpBarRotation), (Action<IntPtr>)HpBarRotationWrap.__Register);
			translator.DelayWrapLoader(typeof(AdventureModuleLevelLoadParams.BootConfigLoadType), (Action<IntPtr>)AdventureModuleLevelLoadParamsBootConfigLoadTypeWrap.__Register);
		}
	}
}
