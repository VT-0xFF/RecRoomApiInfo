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
public enum MKEOOFNOECI
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
public interface ELDDOPJDGNB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool FCNCHLCDLNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? HCEHGNGENKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? MMBKMCILPLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? CKMEPNAHENP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? FGNCMALLJJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NPFLGJBFAME(MKEOOFNOECI KPFMIIFGAKP);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EBEAKPIECKB();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HHJLIDOINBH();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CHIAAJMNHHG(string IMOHDDFOBNB);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NFCDIHLBOOI();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LJJOAFGIFIL
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task GDEIEMLGBPI(BBNOCALJEEF DBDIPNMOPOP, [Optional] CancellationToken GANAOLJLMGA);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class OMMAKEHDJHB : ELDDOPJDGNB
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum NCHMDGPEAIF
	{
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void LBKALOIGOKE(string DBDIPNMOPOP);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int DABOAFOODMJ();

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static OMMAKEHDJHB PIOFGCGEFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private bool NNNINBJEAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool IMEGDPHBOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private bool ICKJMCDDPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool HDKLPPOJMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private long? EBMPEOMGGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool PJMHGCGHDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private long? FPICCJKHAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool AGCMGGDOIOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private Guid? FFHBMKIOHPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly DENJEHOGNCA NGJFEIHMIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private MKEOOFNOECI FMCJDNDBOAE;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool FCNCHLCDLNK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long? HCEHGNGENKK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5E52510", Offset = "0x5E50D10", VA = "0x185E52510", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? MMBKMCILPLF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5E52600", Offset = "0x5E50E00", VA = "0x185E52600", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Guid? CKMEPNAHENP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5E52410", Offset = "0x5E50C10", VA = "0x185E52410", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float? FGNCMALLJJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5E51770", Offset = "0x5E4FF70", VA = "0x185E51770", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5E52A20", Offset = "0x5E51220", VA = "0x185E52A20")]
	[Preserve]
	public OMMAKEHDJHB([NBBCAEDCKMG(null)] DENJEHOGNCA NGJFEIHMIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5E51CF0", Offset = "0x5E504F0", VA = "0x185E51CF0", Slot = "10")]
	public void EBEAKPIECKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x31E2E70", Offset = "0x31E1670", VA = "0x1831E2E70", Slot = "13")]
	public void NFCDIHLBOOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5E51EC0", Offset = "0x5E506C0", VA = "0x185E51EC0", Slot = "11")]
	public void HHJLIDOINBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5E51EB0", Offset = "0x5E506B0", VA = "0x185E51EB0", Slot = "14")]
	public void GIOCKPMDJIC([Optional] string JHOFIHIHPPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5E51AE0", Offset = "0x5E502E0", VA = "0x185E51AE0", Slot = "12")]
	public void CHIAAJMNHHG(string IMOHDDFOBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5E527A0", Offset = "0x5E50FA0", VA = "0x185E527A0", Slot = "9")]
	public void NPFLGJBFAME(MKEOOFNOECI KPFMIIFGAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5E520F0", Offset = "0x5E508F0", VA = "0x185E520F0")]
	private void JNEMOHDNNPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5E528D0", Offset = "0x5E510D0", VA = "0x185E528D0")]
	[MonoPInvokeCallback(typeof(LBKALOIGOKE))]
	private static void PONHBDCJPNI(string DBHCFLMEDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5E51F60", Offset = "0x5E50760", VA = "0x185E51F60")]
	[MonoPInvokeCallback(typeof(DABOAFOODMJ))]
	private static int HMKENMLDNJD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5E52860", Offset = "0x5E51060", VA = "0x185E52860")]
	private void PADBGAJKICC(string DBNIHDKBKFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5E51A50", Offset = "0x5E50250", VA = "0x185E51A50")]
	private void CGMENFKKKAE(LBKALOIGOKE CGEKFPDGHCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5E51E20", Offset = "0x5E50620", VA = "0x185E51E20")]
	private void ECNALAPCILA(DABOAFOODMJ CGEKFPDGHCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5E51ED0", Offset = "0x5E506D0", VA = "0x185E51ED0")]
	private void HHJLIDOINBH(NCHMDGPEAIF DMEJPDINNBL, string NNNILFJLHLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5E52060", Offset = "0x5E50860", VA = "0x185E52060")]
	private void JMNACKFCFPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5E51880", Offset = "0x5E50080", VA = "0x185E51880")]
	private long? ALOMCPGODBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5E51C40", Offset = "0x5E50440", VA = "0x185E51C40")]
	private long? DFCELGPAPGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5E526F0", Offset = "0x5E50EF0", VA = "0x185E526F0")]
	private Guid? NJGOBJFOBMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5E51FB0", Offset = "0x5E507B0", VA = "0x185E51FB0")]
	private double? HNGPGEFLECA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5E515B0", Offset = "0x5E4FDB0", VA = "0x185E515B0")]
	internal static void KCPCIFPGABB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5E51930", Offset = "0x5E50130", VA = "0x185E51930")]
	private void BGMKEOGDKHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5E51AF0", Offset = "0x5E502F0", VA = "0x185E51AF0")]
	[CompilerGenerated]
	private void DDMEFECGDLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class GLOGCJIOJPA
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5E51670", Offset = "0x5E4FE70", VA = "0x185E51670")]
	[IOOPNJKFHOG(FICJCHGEBPC.None)]
	private static void GOBPJCGLIAD(PHIPPCBHDOE EFKPBKMFDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5E515B0", Offset = "0x5E4FDB0", VA = "0x185E515B0")]
	[LCKMJKIGHKB(BIHOHBMMECD.Unity_BeforeSceneLoad)]
	private static void GHBAOPJGKNJ()
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
