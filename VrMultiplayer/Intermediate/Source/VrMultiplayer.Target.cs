using UnrealBuildTool;

public class VrMultiplayerTarget : TargetRules
{
	public VrMultiplayerTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("VrMultiplayer");
	}
}
