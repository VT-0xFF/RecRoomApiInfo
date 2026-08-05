using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum MELNECENNOL
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Root,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Session,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Room
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[Flags]
public enum LAFFCBAHJKM
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	EditorOnly = 1,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	GameOnly = 2
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Method)]
public class FBCFLFBFGIL : PLPLFBFMOJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly MELNECENNOL GKHHKHIPJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly LAFFCBAHJKM LEFOOLHBHGF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x730F910", Offset = "0x730E910", VA = "0x18730F910")]
	public FBCFLFBFGIL(LAFFCBAHJKM EKMJFFBPFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x730F950", Offset = "0x730E950", VA = "0x18730F950")]
	public FBCFLFBFGIL(MELNECENNOL CNDBJIFKPCM, LAFFCBAHJKM EKMJFFBPFKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method)]
public class GCLAPDGGOKM : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xAAA3B0", Offset = "0xAA93B0", VA = "0x180AAA3B0")]
	public GCLAPDGGOKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Method)]
public class PLPLFBFMOJO : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public readonly DLAFBHIONID MPGIHPPLLJH;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x730ACE0", Offset = "0x7309CE0", VA = "0x18730ACE0")]
	public PLPLFBFMOJO(DLAFBHIONID IKABIMIFINC = DLAFBHIONID.Unity_AfterSceneLoad)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum DLAFBHIONID
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Unity_AfterSceneLoad = 0,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Unity_BeforeSceneLoad = 1,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Unity_AfterAssembliesLoaded = 2,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Unity_BeforeSplashScreen = 3,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Unity_SubsystemRegistration = 4,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	ManuallyInvoked = int.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Method)]
public class KGJIADDEADK : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x730ACE0", Offset = "0x7309CE0", VA = "0x18730ACE0")]
	public KGJIADDEADK(int FGJNCOCMMCF = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Method)]
public class JOOLBCFGFFN : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly LLJHODDJBDJ CLHJDPPOJNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly int GPOCBGFAAFK;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x730F990", Offset = "0x730E990", VA = "0x18730F990")]
	public JOOLBCFGFFN(LLJHODDJBDJ CADNMNMAPMH = LLJHODDJBDJ.ExitingPlayMode, int FGJNCOCMMCF = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum LLJHODDJBDJ
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	ExitingPlayMode,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	EnteredEditMode,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	EnteredEditModeNextFrame
}
namespace Cpp2IlInjected;

internal class AddressAttribute : Attribute
{
	public string RVA;

	public string Offset;

	public string VA;

	public string Slot;
}
internal class FieldOffsetAttribute : Attribute
{
	public string Offset;
}
internal class AttributeAttribute : Attribute
{
	public string Name;

	public string RVA;

	public string Offset;
}
internal class MetadataOffsetAttribute : Attribute
{
	public string Offset;
}
internal class TokenAttribute : Attribute
{
	public string Token;
}
internal class AnalysisFailedException : Exception
{
	public AnalysisFailedException(string message)
		: base(message)
	{
	}
}
