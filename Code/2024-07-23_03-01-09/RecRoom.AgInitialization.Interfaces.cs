using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[Flags]
public enum JMIPDAHBNNG
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	EditorOnly = 1,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	GameOnly = 2
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum JAFPILLCEJB
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Root,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Session,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Room
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[KODMLAJCCKP]
[AttributeUsage(AttributeTargets.Method)]
public class GDGALFJPCGE : FCFOCBHCEIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly JAFPILLCEJB CCMDGHHIDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly JMIPDAHBNNG ODFJAPECCDL;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x675DC30", Offset = "0x675CE30", VA = "0x18675DC30")]
	public GDGALFJPCGE(JMIPDAHBNNG ANGEEBBNNIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x675DBF0", Offset = "0x675CDF0", VA = "0x18675DBF0")]
	public GDGALFJPCGE(JAFPILLCEJB AOANHMLCKPG, JMIPDAHBNNG ANGEEBBNNIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method)]
public class DFLMBDCCEBD : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x675DBC0", Offset = "0x675CDC0", VA = "0x18675DBC0")]
	public DFLMBDCCEBD(int CBHPEKJLLAF = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Method)]
public class JIDCLHKIDAF : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly KJECFEIFJAL BFBGKJPCGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly int CLMJDMFGEEH;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x675DC70", Offset = "0x675CE70", VA = "0x18675DC70")]
	public JIDCLHKIDAF(KJECFEIFJAL IPOBIEHNPBF = KJECFEIFJAL.ExitingPlayMode, int CBHPEKJLLAF = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum KJECFEIFJAL
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	ExitingPlayMode,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	EnteredEditMode,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	EnteredEditModeNextFrame
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Method)]
public class KDMKPJDAJLL : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x14D3B10", Offset = "0x14D2D10", VA = "0x1814D3B10")]
	public KDMKPJDAJLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Method)]
public class FCFOCBHCEIP : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly MJLCCMEEJMA JNFGEKJHKHM;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x675DBC0", Offset = "0x675CDC0", VA = "0x18675DBC0")]
	public FCFOCBHCEIP(MJLCCMEEJMA CGNIBFGKCMK = MJLCCMEEJMA.Unity_AfterSceneLoad)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum MJLCCMEEJMA
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	Unity_AfterSceneLoad = 0,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	Unity_BeforeSceneLoad = 1,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	Unity_AfterAssembliesLoaded = 2,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	Unity_BeforeSplashScreen = 3,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	Unity_SubsystemRegistration = 4,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	ManuallyInvoked = int.MaxValue
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
