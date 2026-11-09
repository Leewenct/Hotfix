namespace AIScript.Booter;

public class HotfixBooter
{
	public void Boot()
	{
		HotfixBootSceneManagers.Setup();
		AdventureBootConfigSubscriber.RegisterSubscriber();
		AdventureLinkFXPlayer.InitLineCastLayerMask();
		HotFixPlayerLoop.Inject();
		WwiseVoiceRuntime.Current = (IWwiseVoiceRuntime)(object)new WwiseVoiceRuntimeImpl();
		Singleton<HotfixDataController>.Instance.Load();
	}

	public void UnBoot()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}
}
