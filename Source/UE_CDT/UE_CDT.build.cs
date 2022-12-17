// Copyright 1998-2016 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.IO;

public class UE_CDT : ModuleRules
{
	public UE_CDT(ReadOnlyTargetRules ROTargetRules) : base(ROTargetRules)
    {
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		
		if (!Directory.Exists(ModuleDirectory))
		{
			string Err = string.Format("UE_CDT not found in {0}", ModuleDirectory);
			System.Console.WriteLine(Err);
			throw new BuildException(Err);
		}
	
		PublicIncludePaths.AddRange(
			new string[] {
			}
		);
			
		
		PrivateIncludePaths.AddRange(
			new string[] {
			}
		);
	
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				"GameplayTags"
				// ... add other public dependencies that you statically link with here ...
			}
		);
			
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject",
				"Engine",
				"Slate",
				"SlateCore",
				// ... add private dependencies that you statically link with here ...	
				
				"CDT",
			}
		);
		
		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
				// ... add any modules that your module loads dynamically here ...
			}
		);
	}
}
