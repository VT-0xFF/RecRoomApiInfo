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
public enum LLNPOCPHECB
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
public interface MGKNIEJFAGG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool ACNBIPMEEMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? MAOGEKANOGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? DGINOOGJFJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? FLLOBHEPIFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? BFJFBCJIKIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IJLKFBHJPGM(LLNPOCPHECB KDDFGNJPJNG);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EOPEJCOCBHD();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OMCENBFMBML();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FMLBDDFJOGA(string MPNKHGPLHND);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OBOLMEBAKPG();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GIBFELIGGJI
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task IEFAGOECNMO(IALFFHLGIJL LFAKBJPHCIC, [Optional] CancellationToken KNKAEBKAEBM);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class FJKCPAMDIKM : MGKNIEJFAGG
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum AMMDEFPKAMK
	{
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void LAPHKLFGPOO(string LFAKBJPHCIC);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int HGHJBMDAEFO();

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static FJKCPAMDIKM DLKEBALDMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly AJLEJELNGKA DKNPHKKNIJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool KACGCBOCHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private bool DMBLOPEFAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool OJPFODGBDHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool HLGNGLNEHPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private long? CEJJALBJDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool PAFCKAHLIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private long? GJGJLHNFNKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private bool HKELOOBNICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private Guid? ADLJKAFDGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private LLNPOCPHECB AHMOODGFFCG;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool ACNBIPMEEMD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long? MAOGEKANOGF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6212300", Offset = "0x6211700", VA = "0x186212300", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? DGINOOGJFJG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6212480", Offset = "0x6211880", VA = "0x186212480", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Guid? FLLOBHEPIFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6211BA0", Offset = "0x6210FA0", VA = "0x186211BA0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float? BFJFBCJIKIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x62121F0", Offset = "0x62115F0", VA = "0x1862121F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IALFFHLGIJL CLLHCOMADLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A10", Offset = "0x7C1E10", VA = "0x1807C2A10", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C1DD0", VA = "0x1807C29D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6212CF0", Offset = "0x62120F0", VA = "0x186212CF0")]
	[Preserve]
	public FJKCPAMDIKM([AKGMOFMFNCG(null)] AJLEJELNGKA DKNPHKKNIJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6211E60", Offset = "0x6211260", VA = "0x186211E60", Slot = "10")]
	public void EOPEJCOCBHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6212AE0", Offset = "0x6211EE0", VA = "0x186212AE0", Slot = "13")]
	public void OBOLMEBAKPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6211CF0", Offset = "0x62110F0", VA = "0x186211CF0", Slot = "15")]
	public void EEFLNDCADAD(string IAEIJBHCEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6212B80", Offset = "0x6211F80", VA = "0x186212B80", Slot = "11")]
	public void OMCENBFMBML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6211B90", Offset = "0x6210F90", VA = "0x186211B90", Slot = "16")]
	public void BIIMHFPNKFI([Optional] string DFOKBPLFCMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6211E80", Offset = "0x6211280", VA = "0x186211E80", Slot = "12")]
	public void FMLBDDFJOGA(string MPNKHGPLHND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6211FE0", Offset = "0x62113E0", VA = "0x186211FE0", Slot = "9")]
	public void IJLKFBHJPGM(LLNPOCPHECB KDDFGNJPJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6212570", Offset = "0x6211970", VA = "0x186212570")]
	private void KPIBNCBFELL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6212890", Offset = "0x6211C90", VA = "0x186212890")]
	[MonoPInvokeCallback(typeof(LAPHKLFGPOO))]
	private static void NCBEMFLBALC(string IAEIJBHCEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6211CA0", Offset = "0x62110A0", VA = "0x186211CA0")]
	[MonoPInvokeCallback(typeof(HGHJBMDAEFO))]
	private static int DMIFOCGFAMI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6211A00", Offset = "0x6210E00", VA = "0x186211A00")]
	private void APGFEKBKOGM(string OFHLMHILCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6212160", Offset = "0x6211560", VA = "0x186212160")]
	private void JGPENNMKKCI(LAPHKLFGPOO KCNCNEMPBGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x62123F0", Offset = "0x62117F0", VA = "0x1862123F0")]
	private void JMOHNIEGNDO(HGHJBMDAEFO KCNCNEMPBGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6212AF0", Offset = "0x6211EF0", VA = "0x186212AF0")]
	private void OMCENBFMBML(AMMDEFPKAMK HOKIEGJILGD, string JJJNODJEFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6211E90", Offset = "0x6211290", VA = "0x186211E90")]
	private void HCBLIMLMJHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6212B90", Offset = "0x6211F90", VA = "0x186212B90")]
	private long? PCNDIKMGAAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6212C40", Offset = "0x6212040", VA = "0x186212C40")]
	private long? PHNCCCKBPMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6212A30", Offset = "0x6211E30", VA = "0x186212A30")]
	private Guid? OAJJHCFHJCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x62120B0", Offset = "0x62114B0", VA = "0x1862120B0")]
	private double? JDDEKEGBPAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6211F20", Offset = "0x6211320", VA = "0x186211F20")]
	internal static void HPFPOHJJGDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6211A70", Offset = "0x6210E70", VA = "0x186211A70")]
	private void BHJADCNGGPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class LLJOOBEBHIK
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6212D70", Offset = "0x6212170", VA = "0x186212D70")]
	[AMCIKKJLCIB(HENHDGEOMOC.None)]
	private static void LGDNKOHAFPG(BNDLKDEPBDF CGBKOFIJCLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6211F20", Offset = "0x6211320", VA = "0x186211F20")]
	[MPOHMOIKDIC(BCAGKJLFEFM.Unity_BeforeSceneLoad)]
	private static void IKGCEJFLCML()
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
