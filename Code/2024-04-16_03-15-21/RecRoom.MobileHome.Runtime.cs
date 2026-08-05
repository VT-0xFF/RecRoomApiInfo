using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AOT;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum HAHIPDOKLCN
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Unknown = 0,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Initializing = 1,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	ReadyForLogin = 2,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	PlayerLoading = 32,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	PlayerLoaded = 33,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	RoomLoading = 64,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	InOrientation = 65,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	InDorm = 66,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	InRoom = 67,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	InEvent = 68,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Logout = 128,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	ExitingClient = 129
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PIBDMOEAFNF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool CHPIOOFAJEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? FFGGFEIIPGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? JKEFGILPIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? AJBKIFJPDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? HMEMHLCAGHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NOLPKEMNIJA(HAHIPDOKLCN GAEMKAANAID);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MEJEOBIHPJE();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ADMPIGCHOJB();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IMPCGDEKBCD(string LPAHKHLPOOD);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OCMMDAAPODC();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LGMJJLENKCE
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task CAKIKBBNIDH(OGKPGFCEBLI KJMNBOJGKFF, [Optional] CancellationToken IOOGCHJMBIE);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class DKMAKFDLDIN : PIBDMOEAFNF
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum CLNNCDCHFOF
	{
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void LOFKJJOKAEF(string KJMNBOJGKFF);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int NGEPMGDDGID();

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static DKMAKFDLDIN KLPCJKOHLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly GJGMEPPNEHB PPLPKCAKCNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool GHBJPIPDLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private bool FGJGGKNPNFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool IPHIKHKGIMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool OJCPMANIOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private long? PFNMNLHGGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool CAEDAEOPJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private long? HPOJEKLMFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private bool DKKKHBCCOGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private Guid? ANOOMMHHKDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private HAHIPDOKLCN NCLCJFIBNMA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool CHPIOOFAJEE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long? FFGGFEIIPGL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x618B600", Offset = "0x618A800", VA = "0x18618B600", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? JKEFGILPIJD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x618A8C0", Offset = "0x6189AC0", VA = "0x18618A8C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Guid? AJBKIFJPDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x618B400", Offset = "0x618A600", VA = "0x18618B400", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float? HMEMHLCAGHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x618AD00", Offset = "0x6189F00", VA = "0x18618AD00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public OGKPGFCEBLI ILFBIOHMPKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7BC530", Offset = "0x7BB730", VA = "0x1807BC530", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7BC520", Offset = "0x7BB720", VA = "0x1807BC520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x618BB00", Offset = "0x618AD00", VA = "0x18618BB00")]
	[Preserve]
	public DKMAKFDLDIN([MINIJLJAKNC(null)] GJGMEPPNEHB PPLPKCAKCNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x618B6F0", Offset = "0x618A8F0", VA = "0x18618B6F0", Slot = "10")]
	public void MEJEOBIHPJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x618B8A0", Offset = "0x618AAA0", VA = "0x18618B8A0", Slot = "13")]
	public void OCMMDAAPODC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x618AE10", Offset = "0x618A010", VA = "0x18618AE10", Slot = "15")]
	public void ELFCNIPLAJC(string CIJIFDDECNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x618A8B0", Offset = "0x6189AB0", VA = "0x18618A8B0", Slot = "11")]
	public void ADMPIGCHOJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x618B3F0", Offset = "0x618A5F0", VA = "0x18618B3F0", Slot = "16")]
	public void KCOJPGLHJFH([Optional] string ELGBCNFOHMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x618B2A0", Offset = "0x618A4A0", VA = "0x18618B2A0", Slot = "12")]
	public void IMPCGDEKBCD(string LPAHKHLPOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x618B7D0", Offset = "0x618A9D0", VA = "0x18618B7D0", Slot = "9")]
	public void NOLPKEMNIJA(HAHIPDOKLCN GAEMKAANAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x618AF80", Offset = "0x618A180", VA = "0x18618AF80")]
	private void EPAADJAEIIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x618AB60", Offset = "0x6189D60", VA = "0x18618AB60")]
	[MonoPInvokeCallback(typeof(LOFKJJOKAEF))]
	private static void CLKMGLEMJKK(string CIJIFDDECNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x618A9B0", Offset = "0x6189BB0", VA = "0x18618A9B0")]
	[MonoPInvokeCallback(typeof(NGEPMGDDGID))]
	private static int CBKBANKCLFE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x618B500", Offset = "0x618A700", VA = "0x18618B500")]
	private void KNENJLGFIJG(string CHLFFIMOPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x618B570", Offset = "0x618A770", VA = "0x18618B570")]
	private void LAJBGDEPIFL(LOFKJJOKAEF CMMPHMKBCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x618B8B0", Offset = "0x618AAB0", VA = "0x18618B8B0")]
	private void PGBDHPOBGGN(NGEPMGDDGID CMMPHMKBCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x618A820", Offset = "0x6189A20", VA = "0x18618A820")]
	private void ADMPIGCHOJB(CLNNCDCHFOF LPMJIGEBKFN, string FCFLPBEBMKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x618B360", Offset = "0x618A560", VA = "0x18618B360")]
	private void JPFKHHIDPDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x618BA50", Offset = "0x618AC50", VA = "0x18618BA50")]
	private long? PPBNHAOPEKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x618B2B0", Offset = "0x618A4B0", VA = "0x18618B2B0")]
	private long? JEBNAMOFMFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x618AAB0", Offset = "0x6189CB0", VA = "0x18618AAB0")]
	private Guid? CHOKIJPIEHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x618AA00", Offset = "0x6189C00", VA = "0x18618AA00")]
	private double? CHEJAPEALJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x618B710", Offset = "0x618A910", VA = "0x18618B710")]
	internal static void NNMKPGJBBMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x618B940", Offset = "0x618AB40", VA = "0x18618B940")]
	private void PGNKFNHMHBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class PCFHANAHJJK
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x618BB80", Offset = "0x618AD80", VA = "0x18618BB80")]
	[BDCLMMIIFOD(CIJFMPALMOO.None)]
	private static void PBBGMOAEECN(JGBEMAKPOMJ BIBKBFDHJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x618B710", Offset = "0x618A910", VA = "0x18618B710")]
	[IAOBFDKCCEF(NNKJNJFOFID.Unity_BeforeSceneLoad)]
	private static void KFJCKACEMBP()
	{
	}
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
