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
public enum OKPGNAABJCD
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
public interface NIFIFIEOOKN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool LKDLPOAIEAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? EEIAJNPIBMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? NBDGBNBEEHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? EOMOPJDMKNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? ODCBHJJCKCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HDBBCAHAPLO(OKPGNAABJCD ADCHACEKJAF);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FILODNFGCKM();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EDJIKHFHNLH();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IGFOANPPPEJ(string CEFPGGFPHAK);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LJMAFPLGJKD();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface OMLPMNIBNEH
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PCLAGHNNNDI(IHBMBIBEHCG JELIPFIFPJM, [Optional] CancellationToken HHHPDCGPCML);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class OMPOHNCENKB : NIFIFIEOOKN
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum GGLMLBMMPDD
	{
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void NGBGAJKGEKO(string JELIPFIFPJM);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int DOBKDECBPGD();

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static OMPOHNCENKB JDMDDMDPEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private bool CPCOMLCAONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool OJGPKHELHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private bool MJIIBCLELBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool FIMKOOGDNGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private long? ECLNNHGJKJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool PNLLDCFIBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private long? PGMAPLEJBBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool AJPHGIOBAFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private Guid? CMMEINDIBFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly FDGEEPCHEBJ KDGDPFOGMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private OKPGNAABJCD BLKFANLMCDI;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool LKDLPOAIEAK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long? EEIAJNPIBMC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6057BE0", Offset = "0x6056FE0", VA = "0x186057BE0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? NBDGBNBEEHE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6057700", Offset = "0x6056B00", VA = "0x186057700", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Guid? EOMOPJDMKNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6058480", Offset = "0x6057880", VA = "0x186058480", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float? ODCBHJJCKCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6057360", Offset = "0x6056760", VA = "0x186057360", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6058610", Offset = "0x6057A10", VA = "0x186058610")]
	[Preserve]
	public OMPOHNCENKB([AKCMIAONCHN(null)] FDGEEPCHEBJ KDGDPFOGMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6057CD0", Offset = "0x60570D0", VA = "0x186057CD0", Slot = "10")]
	public void FILODNFGCKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x33C2FE0", Offset = "0x33C23E0", VA = "0x1833C2FE0", Slot = "13")]
	public void LJMAFPLGJKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6057B20", Offset = "0x6056F20", VA = "0x186057B20", Slot = "11")]
	public void EDJIKHFHNLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6057A80", Offset = "0x6056E80", VA = "0x186057A80", Slot = "14")]
	public void DPGKBKLPCNH([Optional] string HKOFIFHEPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6058030", Offset = "0x6057430", VA = "0x186058030", Slot = "12")]
	public void IGFOANPPPEJ(string CEFPGGFPHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6057E50", Offset = "0x6057250", VA = "0x186057E50", Slot = "9")]
	public void HDBBCAHAPLO(OKPGNAABJCD ADCHACEKJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6058160", Offset = "0x6057560", VA = "0x186058160")]
	private void LDIJINAAOJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x60577F0", Offset = "0x6056BF0", VA = "0x1860577F0")]
	[MonoPInvokeCallback(typeof(NGBGAJKGEKO))]
	private static void CGPFKFMBEPO(string AOPOEFEKDJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6057E00", Offset = "0x6057200", VA = "0x186057E00")]
	[MonoPInvokeCallback(typeof(DOBKDECBPGD))]
	private static int FMPDMONEIGO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6058040", Offset = "0x6057440", VA = "0x186058040")]
	private void IMHJNMEKLLE(string BBLALIPPAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6058580", Offset = "0x6057980", VA = "0x186058580")]
	private void MOACPBBADAJ(NGBGAJKGEKO COPFOFGFOAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x60579F0", Offset = "0x6056DF0", VA = "0x1860579F0")]
	private void DACGPGDHAAC(DOBKDECBPGD COPFOFGFOAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6057A90", Offset = "0x6056E90", VA = "0x186057A90")]
	private void EDJIKHFHNLH(GGLMLBMMPDD IEEIJMDMOOP, string HOFKHLBDOJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x60575C0", Offset = "0x60569C0", VA = "0x1860575C0")]
	private void AHAJKOBFOCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6057940", Offset = "0x6056D40", VA = "0x186057940")]
	private long? CHNFJIIALAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6057650", Offset = "0x6056A50", VA = "0x186057650")]
	private long? BKJMNCDGPOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x60580B0", Offset = "0x60574B0", VA = "0x1860580B0")]
	private Guid? INKOKBPIBNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6057B30", Offset = "0x6056F30", VA = "0x186057B30")]
	private double? EECMHFHIKBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x60571A0", Offset = "0x60565A0", VA = "0x1860571A0")]
	internal static void KLGGKKELMKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6057F10", Offset = "0x6057310", VA = "0x186057F10")]
	private void HNOCGAMHEBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6057470", Offset = "0x6056870", VA = "0x186057470")]
	[CompilerGenerated]
	private void ADBEEGGGDKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class EIACHGFLCFE
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6057260", Offset = "0x6056660", VA = "0x186057260")]
	[ABIGJEDBLLA(BMBIBJGPNHE.None)]
	private static void PIPKNOKJANG(DFNLNAANFCD MKEGOGNADMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x60571A0", Offset = "0x60565A0", VA = "0x1860571A0")]
	[PFGHMHCOGDP(HCKINNNGEKD.Unity_BeforeSceneLoad)]
	private static void EJIOIPMNJBL()
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
