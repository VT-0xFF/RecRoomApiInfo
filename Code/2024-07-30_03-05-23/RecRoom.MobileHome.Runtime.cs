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
public enum IMCANNPKAPF
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
	PlayerCustomization = 34,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	RoomLoading = 64,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	InOrientation = 65,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	InDorm = 66,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	InRoom = 67,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	InEvent = 68,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Logout = 128,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	ExitingClient = 129
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EKNPMLHHGFI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool AHMFDJPNMMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? ODEFPAEHKLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? LMKBIOJOGJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? KMGIDJMLCPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? KEEGAKALDEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	GMPPKMGNMOP DCIJJKAKJME
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event EventHandler<EventArgs> NFMPEJMCOFO;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LKKAABFGGMI(IMCANNPKAPF NEIJPCGNELF);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PNLKNBIHCGI();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JEJMPKPNIOI();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void PMGKOHMOJCD(string JKFNDPHKOFM);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void IGKEHOJEPBJ();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface PDKKNIJIAAG
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task NCACMPJJEIF(GMPPKMGNMOP LEODMNMDNMB, [Optional] CancellationToken FIMAIPEFOAM);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class NGIBPMOJOEA : EKNPMLHHGFI
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum MLJLLNGJJHF
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void CAOKAIMPPGE(string LEODMNMDNMB);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int DPFHJLBBJLH();

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static NGIBPMOJOEA ADJKKNJDKEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly NMMBPCBEFII LBFBFICOIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly BLLMDHJDMNE IDOMPNNAKJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool BLCKKEAOLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool FPCFGOAFCKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool NOFLHBFLOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool EKMJGGFOOIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private long? OALENJPDFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private bool IJNBIHPKGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private long? CHIENNHKHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private bool AGIDGHANGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private Guid? IDLJJNDOPBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private IMCANNPKAPF LIAEMOCPGPI;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool AHMFDJPNMMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? ODEFPAEHKLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6A65990", Offset = "0x6A63F90", VA = "0x186A65990", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long? LMKBIOJOGJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6A64BA0", Offset = "0x6A631A0", VA = "0x186A64BA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Guid? KMGIDJMLCPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6A64AA0", Offset = "0x6A630A0", VA = "0x186A64AA0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float? KEEGAKALDEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6A65350", Offset = "0x6A63950", VA = "0x186A65350", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public GMPPKMGNMOP DCIJJKAKJME
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x86C8D0", Offset = "0x86AED0", VA = "0x18086C8D0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x86C8E0", Offset = "0x86AEE0", VA = "0x18086C8E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event EventHandler<EventArgs> NFMPEJMCOFO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6A654F0", Offset = "0x6A63AF0", VA = "0x186A654F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6A64DC0", Offset = "0x6A633C0", VA = "0x186A64DC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6A64D40", Offset = "0x6A63340", VA = "0x186A64D40")]
	private void EEDOJIJHMLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6A65DA0", Offset = "0x6A643A0", VA = "0x186A65DA0")]
	[Preserve]
	public NGIBPMOJOEA([JAMCDGPOOBO(null)] NMMBPCBEFII LBFBFICOIBL, [JAMCDGPOOBO(null)] BLLMDHJDMNE IDOMPNNAKJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6A65D80", Offset = "0x6A64380", VA = "0x186A65D80", Slot = "13")]
	public void PNLKNBIHCGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6A65250", Offset = "0x6A63850", VA = "0x186A65250", Slot = "16")]
	public void IGKEHOJEPBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6A64E70", Offset = "0x6A63470", VA = "0x186A64E70", Slot = "17")]
	public void FEGCKPHFMFI(string LODJHDGECOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6A65340", Offset = "0x6A63940", VA = "0x186A65340", Slot = "14")]
	public void JEJMPKPNIOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6A65D60", Offset = "0x6A64360", VA = "0x186A65D60", Slot = "18")]
	public void PFIFKLADGGJ([Optional] string GMGEIDHKNEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6A65D70", Offset = "0x6A64370", VA = "0x186A65D70", Slot = "15")]
	public void PMGKOHMOJCD(string JKFNDPHKOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6A655A0", Offset = "0x6A63BA0", VA = "0x186A655A0", Slot = "12")]
	public void LKKAABFGGMI(IMCANNPKAPF NEIJPCGNELF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6A65670", Offset = "0x6A63C70", VA = "0x186A65670")]
	private void MDINOKDGNMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6A64A40", Offset = "0x6A63040", VA = "0x186A64A40")]
	[MonoPInvokeCallback(typeof(CAOKAIMPPGE))]
	private static void ANOJOLAKEBF(string LODJHDGECOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6A65260", Offset = "0x6A63860", VA = "0x186A65260")]
	[MonoPInvokeCallback(typeof(DPFHJLBBJLH))]
	private static int IPHHLKFGMEM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6A65A80", Offset = "0x6A64080", VA = "0x186A65A80")]
	private void NLINLLPLBEO(string OGAIDANINGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6A65110", Offset = "0x6A63710", VA = "0x186A65110")]
	private void HBNIJHCFBPD(CAOKAIMPPGE JMMEJHGHOEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6A65460", Offset = "0x6A63A60", VA = "0x186A65460")]
	private void JGJLPNPCICO(DPFHJLBBJLH JMMEJHGHOEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6A652B0", Offset = "0x6A638B0", VA = "0x186A652B0")]
	private void JEJMPKPNIOI(MLJLLNGJJHF GBNNAJEHACL, string IGKDKLHLEGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6A65AF0", Offset = "0x6A640F0", VA = "0x186A65AF0")]
	private void ONOOFMNHGMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6A64C90", Offset = "0x6A63290", VA = "0x186A64C90")]
	private long? ECIBMLBAELC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6A65060", Offset = "0x6A63660", VA = "0x186A65060")]
	private long? GFFBHJHHEJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6A651A0", Offset = "0x6A637A0", VA = "0x186A651A0")]
	private Guid? HFOOPELKMBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6A65B80", Offset = "0x6A64180", VA = "0x186A65B80")]
	private double? PDHLMAGLJBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6A64980", Offset = "0x6A62F80", VA = "0x186A64980")]
	internal static void DLBMGNIACCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6A65C30", Offset = "0x6A64230", VA = "0x186A65C30")]
	private void PFAPNCOIJOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class EENLIMKGCNG
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6A64880", Offset = "0x6A62E80", VA = "0x186A64880")]
	[ILMJIPMJHLC(IAFNNCJJPGN.None)]
	private static void AHHABOBNNNI(GLOPJKBGAFG PCIOPLPELBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6A64980", Offset = "0x6A62F80", VA = "0x186A64980")]
	[LBGCFGAFOMG(GACAEABCFNO.Unity_BeforeSceneLoad)]
	private static void DFMIKALPPMI()
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
