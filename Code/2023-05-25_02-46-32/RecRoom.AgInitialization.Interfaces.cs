using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum BLGLNFDFDJO
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
public enum EDNJEIFHIMJ
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
public class BBAPFPLPODF : GOLHGLLJIPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly BLGLNFDFDJO FEEBIIIPLDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly EDNJEIFHIMJ BKKIDBBNLPJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1694420", Offset = "0x1692C20", VA = "0x181694420")]
	public BBAPFPLPODF(EDNJEIFHIMJ IBDHMNLNLJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1694460", Offset = "0x1692C60", VA = "0x181694460")]
	public BBAPFPLPODF(BLGLNFDFDJO EENKPDMMAPL, EDNJEIFHIMJ IBDHMNLNLJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method)]
public class JFKPICHOBNP : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x92DE00", Offset = "0x92C600", VA = "0x18092DE00")]
	public JFKPICHOBNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Method)]
public class GOLHGLLJIPN : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public readonly OEMLBLOOECK OFEJGHMFHIE;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1690140", Offset = "0x168E940", VA = "0x181690140")]
	public GOLHGLLJIPN(OEMLBLOOECK DMNLINKFLAN = OEMLBLOOECK.Unity_AfterSceneLoad)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum OEMLBLOOECK
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
public class FAFDEJENDOK : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1690140", Offset = "0x168E940", VA = "0x181690140")]
	public FAFDEJENDOK(int KPEDMKNLCKL = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Method)]
public class AGOCEKPENPF : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly ANODGEDDMCH MIJFANCEJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly int FEBAPKLGMEF;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x16943E0", Offset = "0x1692BE0", VA = "0x1816943E0")]
	public AGOCEKPENPF(ANODGEDDMCH FJHMHOINBBB = ANODGEDDMCH.ExitingPlayMode, int KPEDMKNLCKL = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum ANODGEDDMCH
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
