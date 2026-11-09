using UnityEngine;

public static class AdventureBootConfigSubscriber
{
	private static bool _registered;

	internal static void RegisterSubscriber()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		if (!_registered)
		{
			Singleton<EventDispatchManager>.Instance.AddEventListener("\uf3c1ǛǶë篢\ude42,筯\uf3f3ǐǶå筦\ude69$筒己\u00b8\uf48dy", (EventDelegate)OnBootConfigReady);
			_registered = true;
		}
	}

	private static void OnBootConfigReady(IEvent evt)
	{
		IEvent obj = ((evt is GeneralEvent) ? evt : null);
		object obj2 = ((obj != null) ? ((GeneralEvent)obj).data : null);
		BootConfigReadyEventData val = (BootConfigReadyEventData)((obj2 is BootConfigReadyEventData) ? obj2 : null);
		if (val == null || (Object)(object)val.BootConfig == (Object)null)
		{
			return;
		}
		BootConfig bootConfig = val.BootConfig as BootConfig;
		if (!((Object)(object)bootConfig == (Object)null))
		{
			AdventureGameContext.LevelLoadParam = bootConfig.adventureModuleLevelLoadParams;
			AdventureGameContext.AutoBattleConfig = bootConfig.autoBattleConfig;
			AdventureGameContext.TeamConfig = bootConfig.teamConfig;
			AdventureGameContext.IsTestBattle = val.IsTestBattle;
			if (!val.IsTestBattle && bootConfig.teamConfig != null)
			{
				bootConfig.teamConfig.playerIngoreCDAndEnergy = false;
				bootConfig.teamConfig.useUltraSkillLoadParams = false;
			}
		}
	}
}
