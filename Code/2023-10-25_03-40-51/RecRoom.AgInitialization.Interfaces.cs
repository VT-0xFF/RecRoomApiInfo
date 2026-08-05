using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[Flags]
public enum IEJLPKKICHC
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	EditorOnly = 1,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	GameOnly = 2
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum KHJICKDGEOE
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Root,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Session,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Room
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[LKMCMADIPAB]
[AttributeUsage(AttributeTargets.Method)]
public class DJDJPHIPNFL : NDCOICPCJMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly KHJICKDGEOE DPAFFOCKNMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly IEJLPKKICHC BCOBKJOMGDP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5B7F170", Offset = "0x5B7DF70", VA = "0x185B7F170")]
	public DJDJPHIPNFL(IEJLPKKICHC BOBBIIBDEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5B7F1B0", Offset = "0x5B7DFB0", VA = "0x185B7F1B0")]
	public DJDJPHIPNFL(KHJICKDGEOE FIDMACDFCEP, IEJLPKKICHC BOBBIIBDEGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method)]
public class HBLKLJAPIDJ : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5B7F1F0", Offset = "0x5B7DFF0", VA = "0x185B7F1F0")]
	public HBLKLJAPIDJ(int IDDHHGPCFLF = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Method)]
public class NAMFIDBGMDI : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly HHHGCGKDFJI OAKBOOLODLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly int BLLBILPMICK;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5B7F220", Offset = "0x5B7E020", VA = "0x185B7F220")]
	public NAMFIDBGMDI(HHHGCGKDFJI KBNFBEIDJHC = HHHGCGKDFJI.ExitingPlayMode, int IDDHHGPCFLF = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum HHHGCGKDFJI
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
public class KKGLGPKDMLB : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x76E100", Offset = "0x76CF00", VA = "0x18076E100")]
	public KKGLGPKDMLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Method)]
public class NDCOICPCJMM : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly JMJDGGKCJFL BGECPIALLJG;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5B7F1F0", Offset = "0x5B7DFF0", VA = "0x185B7F1F0")]
	public NDCOICPCJMM(JMJDGGKCJFL NJBANAFMIMK = JMJDGGKCJFL.Unity_AfterSceneLoad)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum JMJDGGKCJFL
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
