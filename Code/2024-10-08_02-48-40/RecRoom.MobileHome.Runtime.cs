using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AOT;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_MobileHome_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : JFBHLNBAFAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6CD3560", Offset = "0x6CD2760", VA = "0x186CD3560", Slot = "8")]
		public override void KGHJDOOILCG(KCABLKMBKAN registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x63262B0", Offset = "0x63254B0", VA = "0x1863262B0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum FHKFICAGDFN
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
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GGPMMFCLIAB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NIGEOMANIEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? AKPKHFIOFHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? MJJPJHDKHNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? PKOKMJGEBIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? KOAGHJNIBFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	PBMIHDNMKEE PBFGIKBNJOA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event EventHandler<EventArgs> DGOFLEJAAPP;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NCGICODHPEA(FHKFICAGDFN NHDPLCKEAAN);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DDNLIMMJHCH();

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FINOHGNLKGJ();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HLBOHHNAONI(string CEDHAKCPDLI);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JEGJEMOENBA();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MOJKGCBEPIH
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task FEAJCELHLEE(PBMIHDNMKEE DNFHIAAHIEO, [Optional] CancellationToken DDNLBFLLCLM);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class HGKOGOKFMEG : GGPMMFCLIAB
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private enum AKENOBDDNHC
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate void KOEFIFGHNCM(string DNFHIAAHIEO);

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate int BKGNOAIGNBM();

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static HGKOGOKFMEG PPKIGCGEAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly DEGDDAKEMCN ICMCCGHIIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly KPHDOFGLCFO NCAKMBFLKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool EBGBKAKICJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool MNGODLAKGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool EHNCHDCMCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool PPOOPCJFOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private long? PDNDBONEDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private bool BNBPHIGJNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private long? ANEBOAEFPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private bool LAOKFKEOPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private Guid? NDCCFBGOJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private FHKFICAGDFN DHCDGDBJAAB;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool NIGEOMANIEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? AKPKHFIOFHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6CD29A0", Offset = "0x6CD1BA0", VA = "0x186CD29A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long? MJJPJHDKHNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6CD2F20", Offset = "0x6CD2120", VA = "0x186CD2F20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Guid? PKOKMJGEBIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6CD3080", Offset = "0x6CD2280", VA = "0x186CD3080", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float? KOAGHJNIBFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6CD2690", Offset = "0x6CD1890", VA = "0x186CD2690", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public PBMIHDNMKEE PBFGIKBNJOA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8A2460", Offset = "0x8A1660", VA = "0x1808A2460", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8A2550", Offset = "0x8A1750", VA = "0x1808A2550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event EventHandler<EventArgs> DGOFLEJAAPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6CD2B20", Offset = "0x6CD1D20", VA = "0x186CD2B20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6CD3180", Offset = "0x6CD2380", VA = "0x186CD3180", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6CD33B0", Offset = "0x6CD25B0", VA = "0x186CD33B0")]
	private void OAMJHFNJPBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6CD34C0", Offset = "0x6CD26C0", VA = "0x186CD34C0")]
	[RecRoom.NoEngine.Common.Preserve]
	public HGKOGOKFMEG([GEFLINBOFNF(null)] DEGDDAKEMCN ICMCCGHIIEO, [GEFLINBOFNF(null)] KPHDOFGLCFO NCAKMBFLKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6CD2980", Offset = "0x6CD1B80", VA = "0x186CD2980", Slot = "13")]
	public void DDNLIMMJHCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6CD2F10", Offset = "0x6CD2110", VA = "0x186CD2F10", Slot = "16")]
	public void JEGJEMOENBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6CD2490", Offset = "0x6CD1690", VA = "0x186CD2490", Slot = "17")]
	public void AIGBJCIFBOP(string DHLCCALIEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6CD2C60", Offset = "0x6CD1E60", VA = "0x186CD2C60", Slot = "14")]
	public void FINOHGNLKGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6CD2F00", Offset = "0x6CD2100", VA = "0x186CD2F00", Slot = "18")]
	public void IHPFCBHIHLI([Optional] string PIBLCNLINDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6CD2D20", Offset = "0x6CD1F20", VA = "0x186CD2D20", Slot = "15")]
	public void HLBOHHNAONI(string CEDHAKCPDLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6CD32E0", Offset = "0x6CD24E0", VA = "0x186CD32E0", Slot = "12")]
	public void NCGICODHPEA(FHKFICAGDFN NHDPLCKEAAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6CD2170", Offset = "0x6CD1370", VA = "0x186CD2170")]
	private void AFJNEPGIHNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6CD2850", Offset = "0x6CD1A50", VA = "0x186CD2850")]
	[MonoPInvokeCallback(typeof(KOEFIFGHNCM))]
	private static void BMDHOFIKKIB(string DHLCCALIEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6CD2930", Offset = "0x6CD1B30", VA = "0x186CD2930")]
	[MonoPInvokeCallback(typeof(BKGNOAIGNBM))]
	private static int CKLENBPCDAD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6CD3010", Offset = "0x6CD2210", VA = "0x186CD3010")]
	private void JJPKMMIAIOF(string DLLNHAEGKIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6CD28A0", Offset = "0x6CD1AA0", VA = "0x186CD28A0")]
	private void BNICELPHDOO(KOEFIFGHNCM FKNFKAHALGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6CD2A90", Offset = "0x6CD1C90", VA = "0x186CD2A90")]
	private void EMBBDGKCHFH(BKGNOAIGNBM FKNFKAHALGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6CD2BD0", Offset = "0x6CD1DD0", VA = "0x186CD2BD0")]
	private void FINOHGNLKGJ(AKENOBDDNHC HJGNFPCEHLP, string FAOJDNOALDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6CD3430", Offset = "0x6CD2630", VA = "0x186CD3430")]
	private void OKGHFFLOBAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6CD3230", Offset = "0x6CD2430", VA = "0x186CD3230")]
	private long? LPCPKGLGCIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6CD2E50", Offset = "0x6CD2050", VA = "0x186CD2E50")]
	private long? IACMHHJBIAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6CD2C70", Offset = "0x6CD1E70", VA = "0x186CD2C70")]
	private Guid? GBDFGJPJKJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6CD27A0", Offset = "0x6CD19A0", VA = "0x186CD27A0")]
	private double? BLJPIHFIKBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6CD20B0", Offset = "0x6CD12B0", VA = "0x186CD20B0")]
	internal static void LHKMGOMBLGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6CD2D30", Offset = "0x6CD1F30", VA = "0x186CD2D30")]
	private void HOJBOLEJCCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class BMDJPPMFMIP
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6CD1FC0", Offset = "0x6CD11C0", VA = "0x186CD1FC0")]
	[NPIOOMADHDK.JLDADBHPDAA]
	internal static void FIPBMMBBEEF(KHAIBIPGEJP DDIEINIMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6CD20B0", Offset = "0x6CD12B0", VA = "0x186CD20B0")]
	[FDIPEGGIDGC.LPKMJLHEMIB]
	internal static void LJDDNBPKOJA()
	{
	}
}
namespace Cpp2IlInjected
{
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
}
