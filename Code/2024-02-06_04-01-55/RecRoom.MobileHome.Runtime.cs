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
public enum AFCFNPFHCNN
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
public interface IJNPENMBFKO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool LNIABBJNOAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? OMBGNEHMCCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? HBKFCAPEFEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? ECHMEFHAKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? FIHJGALGMAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PPBPNODMKGC(AFCFNPFHCNN DMBLKCJLHHH);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OBMDJKKOMOC();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DFNHJIOEPMH();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ADNMKMAKOMA(string PLLJJKBGMHI);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OPPOANLNEKD();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface DPHIFHBFABP
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task GDFIBJBBHAJ(AHOCNNIHDHN ACLGAMMGGII, [Optional] CancellationToken PPJMMMGPFGD);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class BGHFAGLAKMI : IJNPENMBFKO
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum IAENLLCNAEN
	{
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void OIIAPCHAODJ(string ACLGAMMGGII);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int JAOGOIBDCNK();

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static BGHFAGLAKMI EANIAGEJDFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private bool PDFLICIIEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool PKCEKIIGLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private bool FPEFEJNOMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool JCBFMMJHBPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private long? AAPFPGFEFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool LMINDNLGAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private long? LLBLGNANHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool EBNDEHPJCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private Guid? MMMPNPFHLHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly HNMDOIFKIPI NOPGOFMDGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private AFCFNPFHCNN JHDOBFCOGAB;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool LNIABBJNOAG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long? OMBGNEHMCCG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x60CCC90", Offset = "0x60CC090", VA = "0x1860CCC90", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? HBKFCAPEFEK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x60CD570", Offset = "0x60CC970", VA = "0x1860CD570", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Guid? ECHMEFHAKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x60CCB90", Offset = "0x60CBF90", VA = "0x1860CCB90", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float? FIHJGALGMAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x60CD130", Offset = "0x60CC530", VA = "0x1860CD130", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x60CD870", Offset = "0x60CCC70", VA = "0x1860CD870")]
	[Preserve]
	public BGHFAGLAKMI([POFPGPCOKGP(null)] HNMDOIFKIPI NOPGOFMDGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x60CD240", Offset = "0x60CC640", VA = "0x1860CD240", Slot = "10")]
	public void OBMDJKKOMOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x33A5B30", Offset = "0x33A4F30", VA = "0x1833A5B30", Slot = "13")]
	public void OPPOANLNEKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x60CC720", Offset = "0x60CBB20", VA = "0x1860CC720", Slot = "11")]
	public void DFNHJIOEPMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x60CC7C0", Offset = "0x60CBBC0", VA = "0x1860CC7C0", Slot = "14")]
	public void GADJKPBEKFL([Optional] string CNIBIJECLOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x60CC500", Offset = "0x60CB900", VA = "0x1860CC500", Slot = "12")]
	public void ADNMKMAKOMA(string PLLJJKBGMHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x60CD7B0", Offset = "0x60CCBB0", VA = "0x1860CD7B0", Slot = "9")]
	public void PPBPNODMKGC(AFCFNPFHCNN DMBLKCJLHHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x60CCD80", Offset = "0x60CC180", VA = "0x1860CCD80")]
	private void MPFNDMKGMJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x60CD370", Offset = "0x60CC770", VA = "0x1860CD370")]
	[MonoPInvokeCallback(typeof(OIIAPCHAODJ))]
	private static void PBIENCJGIJO(string ACMAFFNGPHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x60CC660", Offset = "0x60CBA60", VA = "0x1860CC660")]
	[MonoPInvokeCallback(typeof(JAOGOIBDCNK))]
	private static int BPOEPPLKGEN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x60CC6B0", Offset = "0x60CBAB0", VA = "0x1860CC6B0")]
	private void CEFMNFOANFK(string LEKIMBNLFJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x60CCA50", Offset = "0x60CBE50", VA = "0x1860CCA50")]
	private void KCBMOKGECCA(OIIAPCHAODJ KNDPECEGMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x60CD0A0", Offset = "0x60CC4A0", VA = "0x1860CD0A0")]
	private void MPOGOOCNKDP(JAOGOIBDCNK KNDPECEGMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x60CC730", Offset = "0x60CBB30", VA = "0x1860CC730")]
	private void DFNHJIOEPMH(IAENLLCNAEN DGPAFACOBJI, string IMHGLJNFFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x60CC510", Offset = "0x60CB910", VA = "0x1860CC510")]
	private void APLAKANPHAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x60CCAE0", Offset = "0x60CBEE0", VA = "0x1860CCAE0")]
	private long? KEBEEKNFHKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x60CC9A0", Offset = "0x60CBDA0", VA = "0x1860CC9A0")]
	private long? IIFIBKIFFGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x60CD4C0", Offset = "0x60CC8C0", VA = "0x1860CD4C0")]
	private Guid? PKBELGACEAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x60CC7D0", Offset = "0x60CBBD0", VA = "0x1860CC7D0")]
	private double? GHNBLFNAENB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x60CC5A0", Offset = "0x60CB9A0", VA = "0x1860CC5A0")]
	internal static void BMCPOGIELGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x60CC880", Offset = "0x60CBC80", VA = "0x1860CC880")]
	private void GLPGJIMOEBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x60CD660", Offset = "0x60CCA60", VA = "0x1860CD660")]
	[CompilerGenerated]
	private void PNBEFMLNEJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class HFJANEGBNBL
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x60CD8F0", Offset = "0x60CCCF0", VA = "0x1860CD8F0")]
	[HMKFFNEGBBO(FMOKCMPGPEB.None)]
	private static void MNMFKBHJLGC(FJIKPBKCIMI BHGHMPIHGBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x60CC5A0", Offset = "0x60CB9A0", VA = "0x1860CC5A0")]
	[AGCEEPPEOHJ(PHBLJIALGCE.Unity_BeforeSceneLoad)]
	private static void DDEFNBKGBIJ()
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
