using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[Flags]
public enum AIJEIIPHIJH
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	EditorOnly = 1,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	GameOnly = 2
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum LGHNOHBEMLG
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Root,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Session,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Room
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Method)]
public class NPBDMCLHPNM : KOIFHKBOHLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly LGHNOHBEMLG HGHGOCHDMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly AIJEIIPHIJH BGEPMJMIAMK;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6644670", Offset = "0x6643470", VA = "0x186644670")]
	public NPBDMCLHPNM(AIJEIIPHIJH NLIABKMGBAB = AIJEIIPHIJH.None)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x66446B0", Offset = "0x66434B0", VA = "0x1866446B0")]
	public NPBDMCLHPNM(LGHNOHBEMLG FHANGPOPCKF, AIJEIIPHIJH NLIABKMGBAB = AIJEIIPHIJH.None)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method)]
public class HMHFFLLIIFH : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x65D0660", Offset = "0x65CF460", VA = "0x1865D0660")]
	public HMHFFLLIIFH(int PEOIJCAMOPO = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Method)]
public class PONPKGMPDGG : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly ELCDPILLABI GPINGMONKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly int NDNLMIFPDGL;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x65D1FE0", Offset = "0x65D0DE0", VA = "0x1865D1FE0")]
	public PONPKGMPDGG(ELCDPILLABI LKLDKLKCGEM = ELCDPILLABI.ExitingPlayMode, int PEOIJCAMOPO = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum ELCDPILLABI
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
public class KLCOGBHNPHN : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x860C90", Offset = "0x85FA90", VA = "0x180860C90")]
	public KLCOGBHNPHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Method)]
public class KOIFHKBOHLF : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly NIJEKHCIIFG EMBNHCPIABJ;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x65D0660", Offset = "0x65CF460", VA = "0x1865D0660")]
	public KOIFHKBOHLF(NIJEKHCIIFG BAFCGNDKPGO = NIJEKHCIIFG.Unity_AfterSceneLoad)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum NIJEKHCIIFG
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
