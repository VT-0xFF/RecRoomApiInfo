using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum OCCBJMOEDKI
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
public enum CDFBKAGHDGH
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	EditorOnly = 1,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	GameOnly = 2
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[BMCAHPGJHMD]
[AttributeUsage(AttributeTargets.Method)]
public class PGKDFPMEDOJ : EAKEEMOLAGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly OCCBJMOEDKI LCOFBDLCLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly CDFBKAGHDGH ONAHKEMKDIN;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7237180", Offset = "0x7236580", VA = "0x187237180")]
	public PGKDFPMEDOJ(CDFBKAGHDGH NEPGEOBJODM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7237140", Offset = "0x7236540", VA = "0x187237140")]
	public PGKDFPMEDOJ(OCCBJMOEDKI JELDBGNAPMO, CDFBKAGHDGH NEPGEOBJODM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method)]
public class ABOLEEAAIJJ : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x823850", Offset = "0x822C50", VA = "0x180823850")]
	public ABOLEEAAIJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Method)]
public class EAKEEMOLAGA : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public readonly GCOHNAPHEPC LCFFDLILDKE;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7232570", Offset = "0x7231970", VA = "0x187232570")]
	public EAKEEMOLAGA(GCOHNAPHEPC LHFEJLAJIPO = GCOHNAPHEPC.Unity_AfterSceneLoad)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum GCOHNAPHEPC
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
public class KPMKJNPOFOP : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7232570", Offset = "0x7231970", VA = "0x187232570")]
	public KPMKJNPOFOP(int DDFBJCJBGLB = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Method)]
public class JBOBMCDMAPA : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly LNELBDJPNNB EFEOCJHPKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly int NKHPDOMIFDG;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7237100", Offset = "0x7236500", VA = "0x187237100")]
	public JBOBMCDMAPA(LNELBDJPNNB DDFOIJCDJPF = LNELBDJPNNB.ExitingPlayMode, int DDFBJCJBGLB = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum LNELBDJPNNB
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
