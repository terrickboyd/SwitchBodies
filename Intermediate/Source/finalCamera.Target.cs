using UnrealBuildTool;

public class finalCameraTarget : TargetRules
{
	public finalCameraTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("finalCamera");
	}
}
