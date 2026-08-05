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
public enum KAEBDNOHMJO
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
public interface PCBOJBMMMPP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool CODMGNECHLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? NPODABNLKOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? PDHIMLEBBMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? BELBDAIOPCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? GDLCNILDIAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KKMKEJHHDNP(KAEBDNOHMJO KAADEKGDAHK);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HAJAGMDCLHL();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LEAPEAGKMHL();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CPGEOJGGHJG(string IHHJDMCPGLC);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CHAOLJIBKGH();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface HMDGMCGGCLI
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task OGEBGDOHEOP(KNMEFOAJKPC JNNMDEPDFEI, [Optional] CancellationToken EJGJLLMBDIN);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class GBPGHJEOJPO : PCBOJBMMMPP
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum LKIPKFJLNPI
	{
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void GEMNGOHDMJE(string JNNMDEPDFEI);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int BMENNIEDMLO();

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static GBPGHJEOJPO MCFGKAKKIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly HIGGBJHAIJL ILBMHJCOJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool GBGBHHKNHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private bool MALBHKILDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool ENCAEGGIBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool PDBAFCEMKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private long? OCJDGEPMBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool PAKFDOMHBEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private long? ABPAFFDMOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private bool NMNLNDOBAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private Guid? BKOLLIDJKAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private KAEBDNOHMJO CBKDJODDKDK;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool CODMGNECHLE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7F8B30", Offset = "0x7F7730", VA = "0x1807F8B30", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long? NPODABNLKOI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x617ECE0", Offset = "0x617D8E0", VA = "0x18617ECE0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? PDHIMLEBBMB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x617E070", Offset = "0x617CC70", VA = "0x18617E070", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Guid? BELBDAIOPCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x617EEF0", Offset = "0x617DAF0", VA = "0x18617EEF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float? GDLCNILDIAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x617DEA0", Offset = "0x617CAA0", VA = "0x18617DEA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public KNMEFOAJKPC HBEKOLDNAIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7B7A20", Offset = "0x7B6620", VA = "0x1807B7A20", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7B79A0", Offset = "0x7B65A0", VA = "0x1807B79A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x617F000", Offset = "0x617DC00", VA = "0x18617F000")]
	[Preserve]
	public GBPGHJEOJPO([NNEMKPMNJAE(null)] HIGGBJHAIJL ILBMHJCOJEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x617E2D0", Offset = "0x617CED0", VA = "0x18617E2D0", Slot = "10")]
	public void HAJAGMDCLHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x617DD10", Offset = "0x617C910", VA = "0x18617DD10", Slot = "13")]
	public void CHAOLJIBKGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x617DD30", Offset = "0x617C930", VA = "0x18617DD30", Slot = "15")]
	public void EBEACFFMEFP(string BAOGBOENEHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x617EC40", Offset = "0x617D840", VA = "0x18617EC40", Slot = "11")]
	public void LEAPEAGKMHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x617EFF0", Offset = "0x617DBF0", VA = "0x18617EFF0", Slot = "16")]
	public void PNPMAIBKBAH([Optional] string IACPNDEPJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x617DD20", Offset = "0x617C920", VA = "0x18617DD20", Slot = "12")]
	public void CPGEOJGGHJG(string IHHJDMCPGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x617EA30", Offset = "0x617D630", VA = "0x18617EA30", Slot = "9")]
	public void KKMKEJHHDNP(KAEBDNOHMJO KAADEKGDAHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x617E4C0", Offset = "0x617D0C0", VA = "0x18617E4C0")]
	private void IHJLPKCIGCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x617E890", Offset = "0x617D490", VA = "0x18617E890")]
	[MonoPInvokeCallback(typeof(GEMNGOHDMJE))]
	private static void JNCBMCEIKGI(string BAOGBOENEHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x617E160", Offset = "0x617CD60", VA = "0x18617E160")]
	[MonoPInvokeCallback(typeof(BMENNIEDMLO))]
	private static int FACIMFDKDBM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x617E1B0", Offset = "0x617CDB0", VA = "0x18617E1B0")]
	private void FJLDGIOOPBK(string ILJHAEJCPMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x617EE60", Offset = "0x617DA60", VA = "0x18617EE60")]
	private void PCLPAMGKDNF(GEMNGOHDMJE NLOLPKLGIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x617EB00", Offset = "0x617D700", VA = "0x18617EB00")]
	private void KKOPEJELHAC(BMENNIEDMLO NLOLPKLGIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x617EC50", Offset = "0x617D850", VA = "0x18617EC50")]
	private void LEAPEAGKMHL(LKIPKFJLNPI PBFMPJEICKM, string LEDLJAJCDMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x617EDD0", Offset = "0x617D9D0", VA = "0x18617EDD0")]
	private void NLMOLOKNECI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x617E220", Offset = "0x617CE20", VA = "0x18617E220")]
	private long? FLOBFGOHJJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x617EB90", Offset = "0x617D790", VA = "0x18617EB90")]
	private long? LAAOGBLAJNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x617E7E0", Offset = "0x617D3E0", VA = "0x18617E7E0")]
	private Guid? JKOJKBIPDEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x617E410", Offset = "0x617D010", VA = "0x18617E410")]
	private double? HNIJMDGHNFH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x617DFB0", Offset = "0x617CBB0", VA = "0x18617DFB0")]
	internal static void EIAFAGHLOID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x617E2F0", Offset = "0x617CEF0", VA = "0x18617E2F0")]
	private void HBJHBFBPGGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class INELNNNHNBH
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x617F080", Offset = "0x617DC80", VA = "0x18617F080")]
	[JDFNDIEGGDI(COFBNFOEGIB.None)]
	private static void LBIIPPMJIJI(OJEGDOKHPNO JEAKPHJODOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x617DFB0", Offset = "0x617CBB0", VA = "0x18617DFB0")]
	[KCMJOFEIICM(DPDOCNKHIKA.Unity_BeforeSceneLoad)]
	private static void PNFCDEFPGEE()
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
