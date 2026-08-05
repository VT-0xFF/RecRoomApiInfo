using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum MCJFPPEDLHH
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
public enum OJBJGAAILBP
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
public class MPKPGFJAEKF : LNLGMJAECFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly MCJFPPEDLHH MDHLNBBJFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly OJBJGAAILBP JMJHGNAKALP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x15AE810", Offset = "0x15ADA10", VA = "0x1815AE810")]
	public MPKPGFJAEKF(OJBJGAAILBP GKAKGNCFHJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x15AE850", Offset = "0x15ADA50", VA = "0x1815AE850")]
	public MPKPGFJAEKF(MCJFPPEDLHH PKNHLBOKKOE, OJBJGAAILBP GKAKGNCFHJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method)]
public class DKBNFNBEEMJ : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x956D50", Offset = "0x955F50", VA = "0x180956D50")]
	public DKBNFNBEEMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Method)]
public class LNLGMJAECFD : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public readonly KPBPDMIHLCI ALIMIMPNDJC;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x15AADB0", Offset = "0x15A9FB0", VA = "0x1815AADB0")]
	public LNLGMJAECFD(KPBPDMIHLCI MGFODBGJMIO = KPBPDMIHLCI.Unity_AfterSceneLoad)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum KPBPDMIHLCI
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
public class HKJOHMIAGBL : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x15AADB0", Offset = "0x15A9FB0", VA = "0x1815AADB0")]
	public HKJOHMIAGBL(int JPBBCHDLKHJ = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Method)]
public class GCPIAKNECPG : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly DFCDCLLOMEG IFIJCGFADDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly int GIAHOLBDHFI;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x15AE7D0", Offset = "0x15AD9D0", VA = "0x1815AE7D0")]
	public GCPIAKNECPG(DFCDCLLOMEG JCCPPKEDIAP = DFCDCLLOMEG.ExitingPlayMode, int JPBBCHDLKHJ = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum DFCDCLLOMEG
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
