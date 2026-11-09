namespace AIScript;

public abstract class TowerDefenseThemeEnvironmentBase
{
	protected ITowerDefenseGameplayHost host;

	public virtual void Init(ITowerDefenseGameplayHost host)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}

	public virtual void SeedGrid(TowerDefenseMapData.TowerGrid grid)
	{
	}

	public virtual void OnStart()
	{
	}

	public virtual void OnUpdate()
	{
	}

	public virtual void Clear()
	{
	}

	public virtual void OnRolePlaced(int gridIndex)
	{
	}

	public virtual bool IsGridSprayed(int gridIndex)
	{
		/*Error: Unknown opcode: 0xC0*/;
	}

	public virtual bool IsGridOnFire(int gridIndex)
	{
		/*Error: Unknown opcode: 0xC0*/;
	}

	public virtual bool IsGridDeployable(int gridIndex)
	{
		/*Error: Unknown opcode: 0xC0*/;
	}

	public virtual bool IsGridLit(int gridIndex)
	{
		/*Error: Unknown opcode: 0xC0*/;
	}
}
