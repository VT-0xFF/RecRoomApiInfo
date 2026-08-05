using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum OMGGGJAFEOF
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
public enum BGEACDHIFOF
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
public class OHDKPIIHCBL : HNDDGAICDJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly OMGGGJAFEOF JIFGDIPAACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly BGEACDHIFOF HKCLPMINFPM;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x72D13B0", Offset = "0x72D03B0", VA = "0x1872D13B0")]
	public OHDKPIIHCBL(BGEACDHIFOF KLBGHMIJGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x72D13F0", Offset = "0x72D03F0", VA = "0x1872D13F0")]
	public OHDKPIIHCBL(OMGGGJAFEOF DKCHJCDAIIO, BGEACDHIFOF KLBGHMIJGAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method)]
public class KADPMDBGJAC : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x9CACE0", Offset = "0x9C9CE0", VA = "0x1809CACE0")]
	public KADPMDBGJAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Method)]
public class HNDDGAICDJM : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public readonly KJNNMKFJALK FKFEGBBFFOF;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x72CC7D0", Offset = "0x72CB7D0", VA = "0x1872CC7D0")]
	public HNDDGAICDJM(KJNNMKFJALK BIGLCLAEMID = KJNNMKFJALK.Unity_AfterSceneLoad)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum KJNNMKFJALK
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
public class PALLNELDEKN : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x72CC7D0", Offset = "0x72CB7D0", VA = "0x1872CC7D0")]
	public PALLNELDEKN(int AGNHICGKOFO = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Method)]
public class PPMJBBHKDPA : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly BIABBNOAALP HBBCLCJDPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly int HCMIGFDDFNN;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x72D1430", Offset = "0x72D0430", VA = "0x1872D1430")]
	public PPMJBBHKDPA(BIABBNOAALP LKAJFNOMMPN = BIABBNOAALP.ExitingPlayMode, int AGNHICGKOFO = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum BIABBNOAALP
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
