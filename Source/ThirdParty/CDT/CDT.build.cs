using System;
using System.IO;
using UnrealBuildTool;

public class CDT : ModuleRules
{
	private string IncludePath
	{
		get { return Path.GetFullPath(Path.Combine(ModuleDirectory, "CDT/CDT/include")); }
	}

	private string LibraryIncludePath
	{
		get { return Path.GetFullPath(Path.Combine(ModuleDirectory, "Library")); }
	}
	
	private string LibraryPath
	{
		get { return Path.GetFullPath(Path.Combine(ModuleDirectory, "Library/Release")); }
	}
	
	public CDT(ReadOnlyTargetRules Target) : base(Target)
	{
		Type = ModuleType.External;
				
		if (!Directory.Exists(ModuleDirectory))
		{
			string Err = string.Format("CDT not found in {0}", ModuleDirectory);
			System.Console.WriteLine(Err);
			throw new BuildException(Err);
		}
	
		if (!Directory.Exists(IncludePath))
		{
			string Err = string.Format("CDT/include not found in {0}", ModuleDirectory);
			System.Console.WriteLine(Err);
			throw new BuildException(Err);
		}
		
		if (!Directory.Exists(LibraryPath))
		{
			string Err = string.Format("Library/Release not found in {0}", ModuleDirectory);
			System.Console.WriteLine(Err);
			throw new BuildException(Err);
		}
			
		if (!Directory.Exists(LibraryIncludePath))
		{
			string Err = string.Format("Library not found in {0}", ModuleDirectory);
			System.Console.WriteLine(Err);
			throw new BuildException(Err);
		}
		
		PublicDefinitions.Add( 
			"CDT_USE_AS_COMPILED_LIBRARY" 
		);
	    
		PublicIncludePaths.Add(IncludePath);
		PublicIncludePaths.Add(LibraryIncludePath);
		
		// library.Add(LibraryPath);
	}
}