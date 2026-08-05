using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AOT;
using Cpp2IlInjected;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum BKDACNCJHBD
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
public interface HHNHGEFPBII
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NHDIMIDNICD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? LLGKCGLAGGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? MKIHFEDGAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? MLNMOBBJKJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CIJJEGPNPGA(BKDACNCJHBD JEPPHOGINNJ);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FGBNJEBGKMH();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AICJIJDBKBC();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PALHKGNCNIF(string NCDGAIHIGDE);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface PLFFDHCIOLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task GAJIBDMHKKM(OAIIBMFABPJ PEFGJGEBLGB, [Optional] CancellationToken ELGJALILGJE);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class OEOKBHPMJKK : HHNHGEFPBII
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum LJOMCOJPOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void EPDPMFMCNMK(string PEFGJGEBLGB);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int JPJCMBOKDAO();

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static OEOKBHPMJKK LDFPHDMIKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private bool PBLEONNOGAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool CLIMOBJOFJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private bool LJNLKCDGOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private long? AEIMNKFPOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool KPICBKKCMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private long? MIPCJCLGIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool HKAPBNLCMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private Guid? LPEKEJOHMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly FMJHJJHGABO NCJGNAKLJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private BKDACNCJHBD EMGEGKPEEOA;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool NHDIMIDNICD
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long? LLGKCGLAGGN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5CC1690", Offset = "0x5CC0A90", VA = "0x185CC1690", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long? MKIHFEDGAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5CC1E10", Offset = "0x5CC1210", VA = "0x185CC1E10", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Guid? MLNMOBBJKJK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5CC1BC0", Offset = "0x5CC0FC0", VA = "0x185CC1BC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2050", Offset = "0x5CC1450", VA = "0x185CC2050")]
	[Preserve]
	public OEOKBHPMJKK([LOJAGCNCPBJ(null)] FMJHJJHGABO NCJGNAKLJHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5CC1780", Offset = "0x5CC0B80", VA = "0x185CC1780", Slot = "9")]
	public void FGBNJEBGKMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5CC1000", Offset = "0x5CC0400", VA = "0x185CC1000", Slot = "10")]
	public void AICJIJDBKBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5CC1010", Offset = "0x5CC0410", VA = "0x185CC1010", Slot = "12")]
	public void AJKHGHDKMHK([Optional] string FCINFMGKMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5CC1FB0", Offset = "0x5CC13B0", VA = "0x185CC1FB0", Slot = "11")]
	public void PALHKGNCNIF(string NCDGAIHIGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5CC1340", Offset = "0x5CC0740", VA = "0x185CC1340", Slot = "8")]
	public void CIJJEGPNPGA(BKDACNCJHBD JEPPHOGINNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5CC1020", Offset = "0x5CC0420", VA = "0x185CC1020")]
	private void BKBPILCGLEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5CC1400", Offset = "0x5CC0800", VA = "0x185CC1400")]
	[MonoPInvokeCallback(typeof(EPDPMFMCNMK))]
	private static void CPNDPHNKLAN(string FHFLMBPOCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5CC1CC0", Offset = "0x5CC10C0", VA = "0x185CC1CC0")]
	[MonoPInvokeCallback(typeof(JPJCMBOKDAO))]
	private static int LJABKJKLMAN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5CC1DA0", Offset = "0x5CC11A0", VA = "0x185CC1DA0")]
	private void MBGNADOFAKA(string CIKBCAIAEEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5CC1FC0", Offset = "0x5CC13C0", VA = "0x185CC1FC0")]
	private void PHDAHLDHLAL(EPDPMFMCNMK IOKENELNCLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5CC1600", Offset = "0x5CC0A00", VA = "0x185CC1600")]
	private void DNBGBJBFGNC(JPJCMBOKDAO IOKENELNCLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5CC0F70", Offset = "0x5CC0370", VA = "0x185CC0F70")]
	private void AICJIJDBKBC(LJOMCOJPOPJ NNMKOPJHOFI, string BNOALKOIEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5CC1D10", Offset = "0x5CC1110", VA = "0x185CC1D10")]
	private void LOGPLKCKMHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5CC1550", Offset = "0x5CC0950", VA = "0x185CC1550")]
	private long? DDLKJNFGMGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5CC18B0", Offset = "0x5CC0CB0", VA = "0x185CC18B0")]
	private long? HKOJAKNCMNM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5CC1F00", Offset = "0x5CC1300", VA = "0x185CC1F00")]
	private Guid? NODCNLMNFJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5CC0DB0", Offset = "0x5CC01B0", VA = "0x185CC0DB0")]
	internal static void MDBNPKLHIGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5CC1AB0", Offset = "0x5CC0EB0", VA = "0x185CC1AB0")]
	private void JGAOLOANKPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5CC1960", Offset = "0x5CC0D60", VA = "0x185CC1960")]
	[CompilerGenerated]
	private void IOECIPOMCKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class KKBAPEFHIHA
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5CC0E70", Offset = "0x5CC0270", VA = "0x185CC0E70")]
	[JMHDKPKEECF(OPIGPDFNEON.None)]
	private static void GEANPNKJHMH(HLDKHDLHDPB KBPJCNHNBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5CC0DB0", Offset = "0x5CC01B0", VA = "0x185CC0DB0")]
	[NPHAAKAPCJA(MIKPKJFIPHI.Unity_BeforeSceneLoad)]
	private static void BGCBCLDDOBB()
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
