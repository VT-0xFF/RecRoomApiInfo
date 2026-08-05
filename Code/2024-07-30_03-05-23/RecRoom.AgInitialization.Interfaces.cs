using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[Flags]
public enum IAFNNCJJPGN
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	EditorOnly = 1,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	GameOnly = 2
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum LIEKAGJMIGB
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Root,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Session,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Room
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[ELNIGFGJCNH]
[AttributeUsage(AttributeTargets.Method)]
public class ILMJIPMJHLC : LBGCFGAFOMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly LIEKAGJMIGB LCPBMCLAJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly IAFNNCJJPGN AMNEBDLKEGH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6870F50", Offset = "0x686F550", VA = "0x186870F50")]
	public ILMJIPMJHLC(IAFNNCJJPGN ADMDAKJLHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6870F90", Offset = "0x686F590", VA = "0x186870F90")]
	public ILMJIPMJHLC(LIEKAGJMIGB CBOBOHHEGOG, IAFNNCJJPGN ADMDAKJLHOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method)]
public class OAHKODIBNHK : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6870FD0", Offset = "0x686F5D0", VA = "0x186870FD0")]
	public OAHKODIBNHK(int LOLKACMOLOC = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Method)]
public class AKHHACKKOPD : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly AIIPENBHOND DFBCOIAHDKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly int DLNOMCBAPBP;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6870F10", Offset = "0x686F510", VA = "0x186870F10")]
	public AKHHACKKOPD(AIIPENBHOND IEJGCNNAIGO = AIIPENBHOND.ExitingPlayMode, int LOLKACMOLOC = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum AIIPENBHOND
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
public class LCBKKPOKICD : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x15163B0", Offset = "0x15149B0", VA = "0x1815163B0")]
	public LCBKKPOKICD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Method)]
public class LBGCFGAFOMG : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly GACAEABCFNO GGJENEPGEMA;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6870FD0", Offset = "0x686F5D0", VA = "0x186870FD0")]
	public LBGCFGAFOMG(GACAEABCFNO CHOJKHFAOJO = GACAEABCFNO.Unity_AfterSceneLoad)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum GACAEABCFNO
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
