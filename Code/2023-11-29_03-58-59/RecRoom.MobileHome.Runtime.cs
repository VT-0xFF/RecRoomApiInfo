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
public enum KILFFPPLCNB
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
public interface NEKJLEGMDDM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool FCLHECGJONH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? NEEBDOGENEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? EBMLJPBECBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? MNDIPFJLMIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? LHJPDIJOGHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OMEDNBMAGFI(KILFFPPLCNB IFHMBCKBKKK);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GJHPIDDJMKM();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FCMINHJJLNP();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DELMGLFGEPK(string JOOPMMMLCEJ);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KKINBLMALBK();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface FNFJCIPKHOI
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task DLMDDMFHGFL(OMNLLIMIJFK MOPOEEMOMNO, [Optional] CancellationToken EANFAKGANNH);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ICNGCPBALPG : NEKJLEGMDDM
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum FCCEAHOHHGI
	{
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void IFGPOGFCGGG(string MOPOEEMOMNO);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int MEALKGINPGE();

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static ICNGCPBALPG OJEBKBIJNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private bool ANCGGKMICGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool JAEPKJEFEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private bool HHIDCBKODAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool PNPBDMEGNJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private long? FJBAJDMFJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool LHPKPIJHPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private long? LHIIHNENMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool DEEMNELEFGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private Guid? JOMPGDHEFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly EKLGCGNBGGK AELONJJLJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private KILFFPPLCNB FGPAJAAPGDA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool FCLHECGJONH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long? NEEBDOGENEF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5E534A0", Offset = "0x5E528A0", VA = "0x185E534A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? EBMLJPBECBA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5E53750", Offset = "0x5E52B50", VA = "0x185E53750", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Guid? MNDIPFJLMIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5E52BB0", Offset = "0x5E51FB0", VA = "0x185E52BB0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float? LHJPDIJOGHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5E52AA0", Offset = "0x5E51EA0", VA = "0x185E52AA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5E53DB0", Offset = "0x5E531B0", VA = "0x185E53DB0")]
	[Preserve]
	public ICNGCPBALPG([MJHHGJKKIMK(null)] EKLGCGNBGGK AELONJJLJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5E53620", Offset = "0x5E52A20", VA = "0x185E53620", Slot = "10")]
	public void GJHPIDDJMKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x31CCCC0", Offset = "0x31CC0C0", VA = "0x1831CCCC0", Slot = "13")]
	public void KKINBLMALBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5E530E0", Offset = "0x5E524E0", VA = "0x185E530E0", Slot = "11")]
	public void FCMINHJJLNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5E52A40", Offset = "0x5E51E40", VA = "0x185E52A40", Slot = "14")]
	public void ABPGHOADKFC([Optional] string JPGALIIOGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5E52E70", Offset = "0x5E52270", VA = "0x185E52E70", Slot = "12")]
	public void DELMGLFGEPK(string JOOPMMMLCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5E53C40", Offset = "0x5E53040", VA = "0x185E53C40", Slot = "9")]
	public void OMEDNBMAGFI(KILFFPPLCNB IFHMBCKBKKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5E53180", Offset = "0x5E52580", VA = "0x185E53180")]
	private void FFKKPBCHPNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5E52D20", Offset = "0x5E52120", VA = "0x185E52D20")]
	[MonoPInvokeCallback(typeof(IFGPOGFCGGG))]
	private static void DDFEDDPNKGM(string PPCPJAJEPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5E52A50", Offset = "0x5E51E50", VA = "0x185E52A50")]
	[MonoPInvokeCallback(typeof(MEALKGINPGE))]
	private static int BBMMCKMEINN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5E52CB0", Offset = "0x5E520B0", VA = "0x185E52CB0")]
	private void DAAOPEHEHNN(string GFIBDNIDLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5E53840", Offset = "0x5E52C40", VA = "0x185E53840")]
	private void JJDCENHBLED(IFGPOGFCGGG PDECDCHNHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5E53590", Offset = "0x5E52990", VA = "0x185E53590")]
	private void GIABLPNHAPN(MEALKGINPGE PDECDCHNHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5E530F0", Offset = "0x5E524F0", VA = "0x185E530F0")]
	private void FCMINHJJLNP(FCCEAHOHHGI BKBNKNNDEMK, string LOPLFPBNNNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5E52E80", Offset = "0x5E52280", VA = "0x185E52E80")]
	private void EHDJNHEPPMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5E53030", Offset = "0x5E52430", VA = "0x185E53030")]
	private long? ELJNJLDEDKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5E53D00", Offset = "0x5E53100", VA = "0x185E53D00")]
	private long? PIMBCLMMIJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5E53B90", Offset = "0x5E52F90", VA = "0x185E53B90")]
	private Guid? NADDJKBBOOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5E53AE0", Offset = "0x5E52EE0", VA = "0x185E53AE0")]
	private double? MFEINHHKNBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5E538D0", Offset = "0x5E52CD0", VA = "0x185E538D0")]
	internal static void KKIALDLDGCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5E52F10", Offset = "0x5E52310", VA = "0x185E52F10")]
	private void EICEDOGPEMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5E53990", Offset = "0x5E52D90", VA = "0x185E53990")]
	[CompilerGenerated]
	private void MDBHKCCCNEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class KHJLBBCPLMP
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5E53E30", Offset = "0x5E53230", VA = "0x185E53E30")]
	[JMGGEKJCAGA(PLCOHLLKCIG.None)]
	private static void AMOLMJAIHKI(DIBCBJLEDOH KIMBONFFHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5E538D0", Offset = "0x5E52CD0", VA = "0x185E538D0")]
	[HJCCINDKAPB(LDDPNLEJGAE.Unity_BeforeSceneLoad)]
	private static void CCNFCGCPIDG()
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
