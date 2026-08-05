using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[Flags]
public enum AFMDLPKJFNK
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	EditorOnly = 1,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	GameOnly = 2
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum CEDKDBJGKHF
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Root,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Session,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Room
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[GDDPBDPMDDM]
[AttributeUsage(AttributeTargets.Method)]
public class NJKKEFDLCAD : MPOGKHKBIDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly CEDKDBJGKHF FBCBOPBMHDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly AFMDLPKJFNK MPAJMDODINK;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5BDC720", Offset = "0x5BDAF20", VA = "0x185BDC720")]
	public NJKKEFDLCAD(AFMDLPKJFNK HHJNAANOFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5BDC760", Offset = "0x5BDAF60", VA = "0x185BDC760")]
	public NJKKEFDLCAD(CEDKDBJGKHF LFMHBCJEMNB, AFMDLPKJFNK HHJNAANOFCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method)]
public class NLNOFOJBGPA : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5BDC6F0", Offset = "0x5BDAEF0", VA = "0x185BDC6F0")]
	public NLNOFOJBGPA(int HHCPPOIJJFF = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Method)]
public class GDLMDJGGJNB : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly KNIGDGBBDKN EAIFHEMKBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly int ACEJFBMGDLD;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5BDC6B0", Offset = "0x5BDAEB0", VA = "0x185BDC6B0")]
	public GDLMDJGGJNB(KNIGDGBBDKN BHCOBDPDKLO = KNIGDGBBDKN.ExitingPlayMode, int HHCPPOIJJFF = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum KNIGDGBBDKN
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
public class MHIDAHIOIND : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x772100", Offset = "0x770900", VA = "0x180772100")]
	public MHIDAHIOIND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Method)]
public class MPOGKHKBIDF : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly EDLHBKHFALL OJKCBBDLAAE;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5BDC6F0", Offset = "0x5BDAEF0", VA = "0x185BDC6F0")]
	public MPOGKHKBIDF(EDLHBKHFALL LDFOJAJCNMC = EDLHBKHFALL.Unity_AfterSceneLoad)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum EDLHBKHFALL
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
