using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecNet;
using RecRoom.DataLayer.Audio;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x77AB2B0", Offset = "0x77A9CB0", VA = "0x1877AB2B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAB0110", Offset = "0xAAEB10", VA = "0x180AB0110")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAB0150", Offset = "0xAAEB50", VA = "0x180AB0150")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class JAKAGADKOID
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public enum FBEPLAGHLIB
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		Cancelled,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		Success
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public string HAJDBGAOENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public string FOMCCJNANOP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public FBEPLAGHLIB GBJNAKJPMLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
		[CompilerGenerated]
		get
		{
			return default(FBEPLAGHLIB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA90060", Offset = "0xA8EA60", VA = "0x180A90060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool KGGLAKMMINK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x230F810", Offset = "0x230E210", VA = "0x18230F810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BHKANNIFJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x19CC220", Offset = "0x19CAC20", VA = "0x1819CC220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x77A6D20", Offset = "0x77A5720", VA = "0x1877A6D20")]
	[Obsolete("Use RecNet.Store.SkuPurchaseResult instead")]
	public static JAKAGADKOID INJIMBANEAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x77A6D80", Offset = "0x77A5780", VA = "0x1877A6D80")]
	[Obsolete("Use RecNet.Store.SkuPurchaseResult instead")]
	public static JAKAGADKOID NEAININLLBN([Optional] string JHPNKEJPCIC, [Optional] string GOMDMCFBHFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public JAKAGADKOID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface ONFKIGFCODK
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	string OKBODONOABJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	string MDABHBMBNMK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface INFIINCKLFK
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ONFKIGFCODK> CJNACLCOKGN(string HJHBKDMFDHF, string EHEGBKOFLNN, string ODNCJIJIJFK, VoiceOption HIHLOKPILIN, string? CEHLGOHBIOI, float PKDPDIAMEDL, [Optional] CancellationToken OMJKEHOJJFF);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface JLIDFJPMMHL : INFIINCKLFK
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	PPGAABIGHIL? DODOIFNIKDE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	ECMKKKEPCGP<KKNBIACAFFG> JPEADFHIPHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	ECMKKKEPCGP<BCOKCNDFNPB> JGIODAHGCIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	ECMKKKEPCGP<MILKDBJMEFG> IDLDDEHCKAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	HPDJJKCNBLF BAKFHIJLKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HHJNICDMMJJ();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<GEPIOHPHLLO<byte>> FDFDEEICFCA(string PNIDKKDGNMJ, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<GBAJHOFECNH> GNOGBGLIIJL(bool DIIHCMGENDF, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<OCPNILEDNLO<CNPOLEBELBN>> KPKKCIMOEAI(bool AAOLEDMBKFE = false, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<GBAJHOFECNH> HGPMHNINJEK(long DKMPIOFKFMN, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<AMBDMJNECED<GNGCPLCCEOB>> NAGDFDLBKAN(long DKMPIOFKFMN, bool LCPCDAIANNA = false, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<NCHGPBGLEKP> EJAFCODOLKA(bool LCPCDAIANNA = false, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<KCOINKEJNGD> EPEEOEPGPLD([Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task<GBAJHOFECNH> HAJOCFCPPHD(bool LCPCDAIANNA = false, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task<GBAJHOFECNH> GNEODPBMPKB([Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<GBAJHOFECNH> APEAOIMIPFO(string HJHBKDMFDHF, Guid CMKNICHBINH, long DKMPIOFKFMN, long MNAMJIAHNIM, decimal MGCGAJCBBOH, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<OCPNILEDNLO<CNPOLEBELBN>> KPGHJOLIDDJ(Guid CMKNICHBINH, long DKMPIOFKFMN, long MNAMJIAHNIM, decimal MGCGAJCBBOH, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task BOFLLCNBBGP(string NECAJFCJIIO, string KPNCALHOBGN, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<FDHOCGNPFGL> MCDENLOPGOA(string EHEGBKOFLNN, string BHBIIAJCGIJ, bool CEGFLEIJAJN, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task<MILKDBJMEFG> BJKJFHIPHDH(long DKMPIOFKFMN, string CIDIBFGPPBB, string NKEANKNENKE, string BHBIIAJCGIJ, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<MILKDBJMEFG> BDBCKLLPLLP(long DNFBLPBKMLL, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<AKNMNKMOLNO> IGCIEPKFPHK(string? EHEGBKOFLNN, string BHBIIAJCGIJ, string LFKDNOIKOOH, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<AKNMNKMOLNO> IGCIEPKFPHK(string? EHEGBKOFLNN, string BHBIIAJCGIJ, byte[] MAFOEDOMNFM, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "23")]
	Task<AKNMNKMOLNO> AABPMENAJNJ(long DKMPIOFKFMN, string? EHEGBKOFLNN, string BHBIIAJCGIJ, string LFKDNOIKOOH, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "24")]
	Task<AKNMNKMOLNO> AABPMENAJNJ(long DKMPIOFKFMN, string? EHEGBKOFLNN, string BHBIIAJCGIJ, byte[] MAFOEDOMNFM, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Task<FDHOCGNPFGL> DBJEBKDOPDA(long DKMPIOFKFMN, DIKFLOHBNDA NIBLEOGJBJF, byte[] MAFOEDOMNFM, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task<FDHOCGNPFGL> KPDHNOHPOBO(DIKFLOHBNDA NIBLEOGJBJF, string CIDIBFGPPBB, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task<FDHOCGNPFGL> IFEGNDBDFCD(long DKMPIOFKFMN, string EHEGBKOFLNN, string BHBIIAJCGIJ, bool CEGFLEIJAJN, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task<OLAEIDEEHDL> OLCFHFJALOD(string? EHEGBKOFLNN, string BHBIIAJCGIJ, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task<PPGAABIGHIL> MILLGMABFBG(string BHBIIAJCGIJ, MKCOGBMHLOI? AIKHDHCJCDK, IReadOnlyList<MKCOGBMHLOI>? AKOHJCHBACH, IReadOnlyList<string> HMAENFOFFMM, BMJOBIOIGNB CJFJFBGGCAJ, [Optional] string? CBBBBFPFONL, [Optional] string? BGJNABCHDGF, [Optional] string? ILINHFLCMBM, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Task<PPGAABIGHIL> GMIKKKJMJOI(string LKMAOFPCIGJ, MKCOGBMHLOI? AIKHDHCJCDK, IReadOnlyList<string> HMAENFOFFMM, BMJOBIOIGNB CJFJFBGGCAJ, [Optional] string? BGJNABCHDGF, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Task<List<string>> MFPCJGLLIOL(string BHBIIAJCGIJ, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Task<string> BCDMMKGGICI(BMJOBIOIGNB CJFJFBGGCAJ, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task<APFCNHCJCNK> OAELIBMDFCF(string GMLILPJAKBM, VoiceOption HIHLOKPILIN, string? ODNCJIJIJFK, Action<string> PPBENOGNFAA, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task<string> LDHPNIEPHDK(ReadOnlyMemory<byte> MOIEDEKHEDG, int FFFBBGDMCAA, int OBDDMOILNLM, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task<IMBMPFGMCND> BEIFODENFHB(List<HKALBNAMJPP> DLDPHDEAHMK, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task<IMBMPFGMCND> BELAPDAKLMH([Optional] CancellationToken OMJKEHOJJFF);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class JLDNCFMFJAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private string EEJCNENNPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private string AOGEKMMOOCG;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public string PDMAMLBLCGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public string LMMLDCDGGHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public string EOIPNMAFGEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public string DPNAGNECPOI
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int? CLPHNPHAFPE
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA91C70", Offset = "0xA90670", VA = "0x180A91C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int? GKIMKFPIFBF
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA88320", Offset = "0xA86D20", VA = "0x180A88320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x77A7250", Offset = "0x77A5C50", VA = "0x1877A7250")]
	public JLDNCFMFJAH(string DGPKOMDCIGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x77A7220", Offset = "0x77A5C20", VA = "0x1877A7220")]
	public void MPDGOGFCBGF(string JCIKPBKFAMK = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x77A7120", Offset = "0x77A5B20", VA = "0x1877A7120")]
	private void EKDOGHNOHIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface IGOGELKBODE
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	HNGFBLOEPPO LPPDHMFOPFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<BAEECHBHFCG> KFJAKIIAPIK;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<IPPFBIHJOJL> CBHJGDOLHAA;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<IPPFBIHJOJL> APKBALDHEKK(bool FIIMKHNMBEL = false, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool KJIJPOJKKGK([Out] IPPFBIHJOJL IGHLLJFAFDH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class LDLBKENGJPP
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x77A9960", Offset = "0x77A8360", VA = "0x1877A9960")]
	public static bool CMNDAJGOEPM(this IGOGELKBODE MINDJMNIAPB, [Out] BAEECHBHFCG AAHNIAJPDDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x77A9A40", Offset = "0x77A8440", VA = "0x1877A9A40")]
	public static bool HKHOOEOHJLL(this IGOGELKBODE MINDJMNIAPB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface NGLFCCHCHBD
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task EPHPEOLNGBN(CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KJMAOFDHFDE(int JIHCDNJJAHB, [Out] OLPDAAAAIHL? CJFJFBGGCAJ);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface OLPDAAAAIHL
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int LFLMLMPNPEC
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	string? FAHMGKIDCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	string? LHKEDLABPNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool? BGHKOIPEMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	string? APEJMCEMFGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	string? BHBAJEEGHAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	MENJFLHHLBI? INBFFEMCCOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool FKIDAIMHNNH(string GACENOCEKLM, [Out] KLHLNIKHLLC? CJFJFBGGCAJ);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface KLHLNIKHLLC
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	string? KPLKBICGAHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	string? HNDFHNMFPMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string? BJGJNEBLFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	IReadOnlyList<JIMHGOAJCIK>? GHKOBOOGLCL
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	MENJFLHHLBI? INBFFEMCCOL
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	long? HGEKPJDKOGF
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface JIMHGOAJCIK
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	string HNDFHNMFPMC
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	string MMPEDFAPIKH
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	DNJDNJNPJIO EDFKIGLLKNC
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface MENJFLHHLBI
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string HNDFHNMFPMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	string? KLPEMOOMGKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[GBAJJMJPMAP]
public class DOMGJMPHBOF
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int LDLHHBCPGMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA90060", Offset = "0xA8EA60", VA = "0x180A90060")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public List<ILPPMLOGEMJ> MGLANAIJCAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public Dictionary<string, string> NKBOIAKJBKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x77A3430", Offset = "0x77A1E30", VA = "0x1877A3430")]
	public DOMGJMPHBOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[GBAJJMJPMAP]
public class ILPPMLOGEMJ
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int LFLMLMPNPEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA90060", Offset = "0xA8EA60", VA = "0x180A90060")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string FAHMGKIDCFD
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string LHKEDLABPNK
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string APEJMCEMFGM
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string BHBAJEEGHAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool? BGHKOIPEMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xE75C00", Offset = "0xE74600", VA = "0x180E75C00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xE75C10", Offset = "0xE74610", VA = "0x180E75C10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public HCGDIOBFPMO INBFFEMCCOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA91C70", Offset = "0xA90670", VA = "0x180A91C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA88530", Offset = "0xA86F30", VA = "0x180A88530")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Dictionary<string, LMHFMGJONML> LBOIHEGGAEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA88320", Offset = "0xA86D20", VA = "0x180A88320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA88300", Offset = "0xA86D00", VA = "0x180A88300")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x77A6640", Offset = "0x77A5040", VA = "0x1877A6640")]
	public ILPPMLOGEMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[GBAJJMJPMAP]
public class HCGDIOBFPMO
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public string HNDFHNMFPMC
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string KLPEMOOMGKM
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public HCGDIOBFPMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[GBAJJMJPMAP]
public class LMHFMGJONML
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public string KPLKBICGAHN
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public string HNDFHNMFPMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public string BJGJNEBLFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public List<NHHHCGENEBA> GHKOBOOGLCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public HCGDIOBFPMO INBFFEMCCOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public long HGEKPJDKOGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA938F0", Offset = "0xA922F0", VA = "0x180A938F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x77A9F20", Offset = "0x77A8920", VA = "0x1877A9F20")]
	public LMHFMGJONML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum DNJDNJNPJIO
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	DismissDialog,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	CloseWatch,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	GoToStore,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	GoToCreate,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	GoToDayPass,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	PositiveEvent,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	NegativeEvent,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	CancelEvent
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[GBAJJMJPMAP]
public class NHHHCGENEBA
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public string HNDFHNMFPMC
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string MMPEDFAPIKH
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DNJDNJNPJIO EDFKIGLLKNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xAE0120", Offset = "0xADEB20", VA = "0x180AE0120")]
		[CompilerGenerated]
		get
		{
			return default(DNJDNJNPJIO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xAE0110", Offset = "0xADEB10", VA = "0x180AE0110")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public NHHHCGENEBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct ALGMPIIGMOP : IEquatable<ALGMPIIGMOP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly bool CIIMGBCFCFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly DateTime EDOJCBBJGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly bool NKEFFKKKHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly NPJJEBGBNDK? NGIBMPAADMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly string JJBLOFPKMJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int? LEJOMDPNDFL;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public static ALGMPIIGMOP NGHKEPEGKBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x29F3AD0", Offset = "0x29F24D0", VA = "0x1829F3AD0")]
		get
		{
			return default(ALGMPIIGMOP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x77A11D0", Offset = "0x779FBD0", VA = "0x1877A11D0")]
	public ALGMPIIGMOP(DateTime DIPBMLNCFEC, bool AFBFLHECBCF, NPJJEBGBNDK? BJFIKOPEODN, string JLONGOFLFMM, int? ALKCAELNJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x77A1070", Offset = "0x779FA70", VA = "0x1877A1070")]
	public BAEECHBHFCG PNCCFONLIBL(HNGFBLOEPPO JMIIDKAGFJN)
	{
		return default(BAEECHBHFCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x77A0FF0", Offset = "0x779F9F0", VA = "0x1877A0FF0")]
	private static BAEECHBHFCG JOMPKCIIAGA(HNGFBLOEPPO JMIIDKAGFJN, DateTime DIPBMLNCFEC)
	{
		return default(BAEECHBHFCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x77A0D00", Offset = "0x779F700", VA = "0x1877A0D00", Slot = "4")]
	public bool Equals(ALGMPIIGMOP EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x77A0E60", Offset = "0x779F860", VA = "0x1877A0E60", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x77A0F10", Offset = "0x779F910", VA = "0x1877A0F10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x77A0FC0", Offset = "0x779F9C0", VA = "0x1877A0FC0")]
	public static bool JJNADAGGMDE(ALGMPIIGMOP OKDCNKNEMHO, ALGMPIIGMOP AAJFLFEAFBA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x77A0CC0", Offset = "0x779F6C0", VA = "0x1877A0CC0")]
	public static bool CNNLEBNJPBE(ALGMPIIGMOP OKDCNKNEMHO, ALGMPIIGMOP AAJFLFEAFBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x77A1100", Offset = "0x779FB00", VA = "0x1877A1100", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct IPPFBIHJOJL : IEquatable<IPPFBIHJOJL>
{
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public static readonly IPPFBIHJOJL NGHKEPEGKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly bool DKCDJFPCHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly BAEECHBHFCG NCFLGICAJME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly ALGMPIIGMOP CIJEHCBAFHK;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x77A6CF0", Offset = "0x77A56F0", VA = "0x1877A6CF0")]
	public IPPFBIHJOJL(BAEECHBHFCG AAHNIAJPDDJ, ALGMPIIGMOP JFICGFOHDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x77A6980", Offset = "0x77A5380", VA = "0x1877A6980", Slot = "4")]
	public bool Equals(IPPFBIHJOJL EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x77A6850", Offset = "0x77A5250", VA = "0x1877A6850", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x77A6A30", Offset = "0x77A5430", VA = "0x1877A6A30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x77A6AF0", Offset = "0x77A54F0", VA = "0x1877A6AF0")]
	public static bool JJNADAGGMDE(IPPFBIHJOJL OKDCNKNEMHO, IPPFBIHJOJL AAJFLFEAFBA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x77A6730", Offset = "0x77A5130", VA = "0x1877A6730")]
	public static bool CNNLEBNJPBE(IPPFBIHJOJL OKDCNKNEMHO, IPPFBIHJOJL AAJFLFEAFBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x77A6C00", Offset = "0x77A5600", VA = "0x1877A6C00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum BAEECHBHFCG : byte
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	Expired,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	Active
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class DCECMGFHHCD : HNGFBLOEPPO
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public const string OCAADELKJHF = "ServerTime";

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly Stopwatch AKPLAMIFGBE;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static DateTimeOffset? LLFDDNLFELC;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly DCECMGFHHCD PKGDNOOHCCN;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static HNGFBLOEPPO NDAIDGNOFDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x77A24A0", Offset = "0x77A0EA0", VA = "0x1877A24A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	internal static DCECMGFHHCD HJOFDEIEEED
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x77A25B0", Offset = "0x77A0FB0", VA = "0x1877A25B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static DateTimeOffset AHACNABIEMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x77A2340", Offset = "0x77A0D40", VA = "0x1877A2340")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static DateTime BNBEGMMJEOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x77A22B0", Offset = "0x77A0CB0", VA = "0x1877A22B0")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public DateTime DKGIFMHPGOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x77A24F0", Offset = "0x77A0EF0", VA = "0x1877A24F0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public DateTimeOffset FBDCGJLFAOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x77A2600", Offset = "0x77A1000", VA = "0x1877A2600", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	private DCECMGFHHCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x77A2090", Offset = "0x77A0A90", VA = "0x1877A2090")]
	internal static void FAEAPHKLPIG(DateTime? HKDHKCIKBDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum PEMBEDJIHKC
{
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	Front,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	Back
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum LBDCBOFMANL
{
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	AnimatedPuppet,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	Imposter
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[GBAJJMJPMAP]
public class FKCOEBBJFAO : LMFOKCGEBJK, DCGEDIHFEKC, BHOLJOIPLEN, LOCJLHBEEIF, DJDBLHOFGGK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct HNCDLJIOBEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public FKCOEBBJFAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x77A5C70", Offset = "0x77A4670", VA = "0x1877A5C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x77A6020", Offset = "0x77A4A20", VA = "0x1877A6020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[IgnoreDataMember]
	public static CIJOJACAEON HCKBPHBBBBL;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public Guid FLMOBMMCAHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xE823D0", Offset = "0xE80DD0", VA = "0x180E823D0", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xE823E0", Offset = "0xE80DE0", VA = "0x180E823E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int HBCILHNBLEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xAE0120", Offset = "0xADEB20", VA = "0x180AE0120", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xAE0110", Offset = "0xADEB10", VA = "0x180AE0110")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public string FAHMGKIDCFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500", Slot = "40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public string LHKEDLABPNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int BNDLIGFBKCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xAA3B30", Offset = "0xAA2530", VA = "0x180AA3B30", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xEAC2E0", Offset = "0xEAACE0", VA = "0x180EAC2E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public MNNPGENBKHF GJDGGAEABJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xAA3B40", Offset = "0xAA2540", VA = "0x180AA3B40", Slot = "44")]
		[CompilerGenerated]
		get
		{
			return default(MNNPGENBKHF);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x16F4230", Offset = "0x16F2C30", VA = "0x1816F4230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool FJAMJHKHMIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xD49720", Offset = "0xD48120", VA = "0x180D49720", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xE571D0", Offset = "0xE55BD0", VA = "0x180E571D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool JLBCDGCEPOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xEC59B0", Offset = "0xEC43B0", VA = "0x180EC59B0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xEC53B0", Offset = "0xEC3DB0", VA = "0x180EC53B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool EPHKJOFGHGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2134780", Offset = "0x2133180", VA = "0x182134780", Slot = "41")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x21337D0", Offset = "0x21321D0", VA = "0x1821337D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int? BGOMDFJCLGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x77A4AE0", Offset = "0x77A34E0", VA = "0x1877A4AE0", Slot = "43")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x77A47E0", Offset = "0x77A31E0", VA = "0x1877A47E0", Slot = "14")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public string LIBLBDPLBAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xA84210", Offset = "0xA82C10", VA = "0x180A84210", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xA84220", Offset = "0xA82C20", VA = "0x180A84220")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public string ONFABKAIMOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xA84200", Offset = "0xA82C00", VA = "0x180A84200", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA84190", Offset = "0xA82B90", VA = "0x180A84190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string ONIIKEBGOOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xA841E0", Offset = "0xA82BE0", VA = "0x180A841E0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA841C0", Offset = "0xA82BC0", VA = "0x180A841C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public DateTime NEFPGADCCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA841B0", Offset = "0xA82BB0", VA = "0x180A841B0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xFAD490", Offset = "0xFABE90", VA = "0x180FAD490")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public DateTime NDENGKFIMKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xA841F0", Offset = "0xA82BF0", VA = "0x180A841F0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xFAD8C0", Offset = "0xFAC2C0", VA = "0x180FAD8C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public PEMBEDJIHKC EODENEKMGKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xAF41B0", Offset = "0xAF2BB0", VA = "0x180AF41B0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(PEMBEDJIHKC);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x1037BC0", Offset = "0x10365C0", VA = "0x181037BC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public string NJBHDFFGLFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xA909E0", Offset = "0xA8F3E0", VA = "0x180A909E0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xA909C0", Offset = "0xA8F3C0", VA = "0x180A909C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public int CHENAIJJIKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xD743D0", Offset = "0xD72DD0", VA = "0x180D743D0", Slot = "42")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xD746D0", Offset = "0xD730D0", VA = "0x180D746D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public IReadOnlyList<PDBAOIBGPLP> MCJFOEHOHLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xAEDCD0", Offset = "0xAEC6D0", VA = "0x180AEDCD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xAEB9B0", Offset = "0xAEA3B0", VA = "0x180AEB9B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public IReadOnlyList<FPPIPOONFCO> KLEIDGOHCJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xAEDCD0", Offset = "0xAEC6D0", VA = "0x180AEDCD0", Slot = "37")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public KJAHAIAPOIE ONOBDNPDLFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA90900", Offset = "0xA8F300", VA = "0x180A90900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA90890", Offset = "0xA8F290", VA = "0x180A90890")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public string CMEPLJICJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x77A4840", Offset = "0x77A3240", VA = "0x1877A4840", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public NFKAGEEDJKA NLDECOCOLJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xC325B0", Offset = "0xC30FB0", VA = "0x180C325B0", Slot = "24")]
		get
		{
			return default(NFKAGEEDJKA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public string BIKKNIIFDAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x77A4840", Offset = "0x77A3240", VA = "0x1877A4840", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public string BMEFPAKGMBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public bool ENPHCLCELIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public HLLCBMIFJOL CDDDOEEINIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xAD6AA0", Offset = "0xAD54A0", VA = "0x180AD6AA0", Slot = "30")]
		get
		{
			return default(HLLCBMIFJOL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public string JBPKKCONGMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "31")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public NAPDNNCNOPF? PHHPCIODAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x77A47F0", Offset = "0x77A31F0", VA = "0x1877A47F0", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public HLNDJKGLKLL HOLKAHJIJHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xC325B0", Offset = "0xC30FB0", VA = "0x180C325B0", Slot = "33")]
		get
		{
			return default(HLNDJKGLKLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool JAAOPAMMKAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public FKCOEBBJFAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x10D2170", Offset = "0x10D0B70", VA = "0x1810D2170")]
	public FKCOEBBJFAO([Optional] Guid DMABDIEKAKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x77A4860", Offset = "0x77A3260", VA = "0x1877A4860", Slot = "35")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x77A4A10", Offset = "0x77A3410", VA = "0x1877A4A10", Slot = "36")]
	[AsyncStateMachine(typeof(HNCDLJIOBEM))]
	public Task OENOAICBHGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x77A4760", Offset = "0x77A3160", VA = "0x1877A4760")]
	public FKCOEBBJFAO BCDPIPBINMD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[GBAJJMJPMAP]
public class PGMFGCFDFFJ : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string FAHMGKIDCFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public string LHKEDLABPNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int BNDLIGFBKCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xAE0120", Offset = "0xADEB20", VA = "0x180AE0120")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xAE0110", Offset = "0xADEB10", VA = "0x180AE0110")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public int? BGOMDFJCLGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x136E660", Offset = "0x136D060", VA = "0x18136E660")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x10771E0", Offset = "0x1075BE0", VA = "0x1810771E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public string LIBLBDPLBAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public MNNPGENBKHF GJDGGAEABJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xAA3B30", Offset = "0xAA2530", VA = "0x180AA3B30")]
		[CompilerGenerated]
		get
		{
			return default(MNNPGENBKHF);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xEAC2E0", Offset = "0xEAACE0", VA = "0x180EAC2E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public PEMBEDJIHKC? EODENEKMGKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xAD4230", Offset = "0xAD2C30", VA = "0x180AD4230")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xAD4240", Offset = "0xAD2C40", VA = "0x180AD4240")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public PGMFGCFDFFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[GBAJJMJPMAP]
public class ALHFPLNNGIB : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public int HBCILHNBLEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA90060", Offset = "0xA8EA60", VA = "0x180A90060")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public int? BGOMDFJCLGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x136E620", Offset = "0x136D020", VA = "0x18136E620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x13711F0", Offset = "0x136FBF0", VA = "0x1813711F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public string ONFABKAIMOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public string LIBLBDPLBAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public ALHFPLNNGIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[GBAJJMJPMAP]
public class BPNPHJKIAFC : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public int? BGOMDFJCLGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xE6CA00", Offset = "0xE6B400", VA = "0x180E6CA00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public string LIBLBDPLBAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public BPNPHJKIAFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct IENLIFKJIEN
{
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static int HIKBHBFLIKB;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public static int KFAJMJHKCAA;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public int MKBJIAIGNJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xD893D0", Offset = "0xD87DD0", VA = "0x180D893D0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x152BB60", Offset = "0x152A560", VA = "0x18152BB60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public int GOICLIIBNGI
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2FA5300", Offset = "0x2FA3D00", VA = "0x182FA5300")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2FA52F0", Offset = "0x2FA3CF0", VA = "0x182FA52F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public static IENLIFKJIEN MDAKIDAOHEC
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x77A6410", Offset = "0x77A4E10", VA = "0x1877A6410")]
		get
		{
			return default(IENLIFKJIEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x77A64C0", Offset = "0x77A4EC0", VA = "0x1877A64C0")]
	public IENLIFKJIEN(int BHLHMDJCGFA, int LGMNOBHIFBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[GBAJJMJPMAP]
public class EIINIHOFFNA : BHOLJOIPLEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public int KLOMCCKKOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int EENGHEBHHBO;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public EIINIHOFFNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[GBAJJMJPMAP]
public class IKCDKGBALDK : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public int ICNMGCIDOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xA90060", Offset = "0xA8EA60", VA = "0x180A90060")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public int? ELGBDLOIHDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x136E620", Offset = "0x136D020", VA = "0x18136E620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x13711F0", Offset = "0x136FBF0", VA = "0x1813711F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public string? IGNKIAJJGLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x77A65E0", Offset = "0x77A4FE0", VA = "0x1877A65E0")]
	public IKCDKGBALDK(int LJOHGKNMJLN, int? MPIPIFEJGJE, string? ONGDPODJNBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public IKCDKGBALDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[GBAJJMJPMAP]
public class OIDMOIGHPIG : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public LMNMGAKMAJF.INOHEFCCPKG NIPCNFMHBHK
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
		[CompilerGenerated]
		get
		{
			return default(LMNMGAKMAJF.INOHEFCCPKG);
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA90060", Offset = "0xA8EA60", VA = "0x180A90060")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public string BHPNBEBOFPB
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public int? DJBKGFPPGNA
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xDED820", Offset = "0xDEC220", VA = "0x180DED820")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public OIDMOIGHPIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface FPPIPOONFCO
{
	[Cpp2IlInjected.Token(Token = "0x17000076")]
	long JKGDEIOAFMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Guid FLMOBMMCAHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	Guid IAGHKHMHFCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	string ODKHNFBAPAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	string BMAMKMDIDEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	int BHILEGIKIOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	string JIAFAJMCPHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	string EMFLHGCAGPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	string OJNEKGAAFAL
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	string FJEJHFELONL
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	int CHENAIJJIKG
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[GBAJJMJPMAP]
public class PDBAOIBGPLP : FPPIPOONFCO, BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public long JKGDEIOAFMH
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xE6CA00", Offset = "0xE6B400", VA = "0x180E6CA00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Guid FLMOBMMCAHM
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xD5CF80", Offset = "0xD5B980", VA = "0x180D5CF80", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xF32710", Offset = "0xF31110", VA = "0x180F32710")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Guid IAGHKHMHFCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x13D5B70", Offset = "0x13D4570", VA = "0x1813D5B70", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x1514FE0", Offset = "0x15139E0", VA = "0x181514FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public DateTime NEFPGADCCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA938F0", Offset = "0xA922F0", VA = "0x180A938F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public string ODKHNFBAPAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA91C70", Offset = "0xA90670", VA = "0x180A91C70", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xA88530", Offset = "0xA86F30", VA = "0x180A88530")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public string BMAMKMDIDEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xA88320", Offset = "0xA86D20", VA = "0x180A88320", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xA88300", Offset = "0xA86D00", VA = "0x180A88300")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public int BHILEGIKIOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xE86AA0", Offset = "0xE854A0", VA = "0x180E86AA0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xFCA860", Offset = "0xFC9260", VA = "0x180FCA860")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public string JIAFAJMCPHB
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xA84200", Offset = "0xA82C00", VA = "0x180A84200", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xA84190", Offset = "0xA82B90", VA = "0x180A84190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public string EMFLHGCAGPD
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA841E0", Offset = "0xA82BE0", VA = "0x180A841E0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xA841C0", Offset = "0xA82BC0", VA = "0x180A841C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public string OJNEKGAAFAL
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xA841B0", Offset = "0xA82BB0", VA = "0x180A841B0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xA841A0", Offset = "0xA82BA0", VA = "0x180A841A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public string FJEJHFELONL
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xA841F0", Offset = "0xA82BF0", VA = "0x180A841F0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0xA841D0", Offset = "0xA82BD0", VA = "0x180A841D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public int CHENAIJJIKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xAF41B0", Offset = "0xAF2BB0", VA = "0x180AF41B0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x1037BC0", Offset = "0x10365C0", VA = "0x181037BC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "15")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public PDBAOIBGPLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[Flags]
public enum LDMKDLJFCLO
{
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	Shirt = 1,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	All = -1
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum NEMEIANKENG
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	SearchScoreDescending,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	HotScoreDescending,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	Newest,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	Oldest,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	PriceAscending,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	PriceDescending,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	FeaturedFirst
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class DBAFOMABMGG
{
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x77A1F70", Offset = "0x77A0970", VA = "0x1877A1F70")]
	public static int? HCPKKEDLJKG(LDMKDLJFCLO? GAIDADOIABC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x77A2000", Offset = "0x77A0A00", VA = "0x1877A2000")]
	public static int? JAAKCGBBFPA(NEMEIANKENG? ENGPEAPBCBC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[GBAJJMJPMAP]
public class CNKDAODNIBE : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public string FAHMGKIDCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public string LHKEDLABPNK
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public int? BNDLIGFBKCA
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0xDED820", Offset = "0xDEC220", VA = "0x180DED820")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public MNNPGENBKHF? GJDGGAEABJH
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xA882F0", Offset = "0xA86CF0", VA = "0x180A882F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public CNKDAODNIBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[GBAJJMJPMAP]
public class PEIDCEBGHBD : GCELMFGJPLP, BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public Guid FLMOBMMCAHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xE823D0", Offset = "0xE80DD0", VA = "0x180E823D0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0xE823E0", Offset = "0xE80DE0", VA = "0x180E823E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public byte IALOGONDFCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA88540", Offset = "0xA86F40", VA = "0x180A88540")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xA88520", Offset = "0xA86F20", VA = "0x180A88520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public PEIDCEBGHBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class NCLDADPHHHN
{
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x77AA760", Offset = "0x77A9160", VA = "0x1877AA760")]
	public static JHNMIKJKCEJ FNLIHBFOFCE(this PEIDCEBGHBD NLDLHIJAJBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface LMFOKCGEBJK
{
	[Cpp2IlInjected.Token(Token = "0x17000093")]
	Guid FLMOBMMCAHM
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	int HBCILHNBLEB
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	string FAHMGKIDCFD
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	string LHKEDLABPNK
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	int BNDLIGFBKCA
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	MNNPGENBKHF GJDGGAEABJH
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	bool FJAMJHKHMIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	bool JLBCDGCEPOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	bool EPHKJOFGHGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	int? BGOMDFJCLGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	string LIBLBDPLBAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	string ONFABKAIMOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	string ONIIKEBGOOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	DateTime NEFPGADCCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	DateTime NDENGKFIMKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	PEMBEDJIHKC EODENEKMGKL
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	string NJBHDFFGLFH
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	int CHENAIJJIKG
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	string CMEPLJICJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x77A9E60", Offset = "0x77A8860", VA = "0x1877A9E60", Slot = "19")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface DJDBLHOFGGK
{
	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	IReadOnlyList<FPPIPOONFCO> KLEIDGOHCJB
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	Guid FLMOBMMCAHM
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	int HBCILHNBLEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	string FAHMGKIDCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	bool EPHKJOFGHGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	int CHENAIJJIKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	int? BGOMDFJCLGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	MNNPGENBKHF GJDGGAEABJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class LKPFHILNPON
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct IDCGCFNACPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public IEnumerable<LOCJLHBEEIF> list;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x77A6100", Offset = "0x77A4B00", VA = "0x1877A6100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x77A63B0", Offset = "0x77A4DB0", VA = "0x1877A63B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x77A9B50", Offset = "0x77A8550", VA = "0x1877A9B50")]
	public static bool DGBHACBMIMM(this IEnumerable<BHOLJOIPLEN> CKDFPBCCFHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x77A9D90", Offset = "0x77A8790", VA = "0x1877A9D90")]
	[AsyncStateMachine(typeof(IDCGCFNACPA))]
	public static Task FIMGCAMFPDN(this IEnumerable<LOCJLHBEEIF> CKDFPBCCFHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct HCMJMHBJMFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly string ILJJIFMFDNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly string MDHMAPKBLOO;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly HCMJMHBJMFG BHAFCKPMAKK;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0xC12020", Offset = "0xC10A20", VA = "0x180C12020")]
	public HCMJMHBJMFG(string PNIDKKDGNMJ, string KEGBPMLIINA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x13BE890", Offset = "0x13BD290", VA = "0x1813BE890")]
	public bool FMOEJGBHBPC(HCMJMHBJMFG EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x77A53C0", Offset = "0x77A3DC0", VA = "0x1877A53C0", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x77A5490", Offset = "0x77A3E90", VA = "0x1877A5490", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x77A5500", Offset = "0x77A3F00", VA = "0x1877A5500")]
	public static bool JJNADAGGMDE(HCMJMHBJMFG OKDCNKNEMHO, HCMJMHBJMFG AAJFLFEAFBA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x77A5340", Offset = "0x77A3D40", VA = "0x1877A5340")]
	public static bool CNNLEBNJPBE(HCMJMHBJMFG OKDCNKNEMHO, HCMJMHBJMFG AAJFLFEAFBA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface PELCFBNBCGD
{
	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	JLDNCFMFJAH LDLHHBCPGMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	string IPLIKCHIJNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	string MKAEJCMHEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	long FJEMBFHCMAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	string IKJCIDENKJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	string FNOADPGCILL
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	string PKMGKCPPNAB
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	string LABHKOMPKGE
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[GBAJJMJPMAP]
public class FNHHKLICNDL : PGABMOBLEAG
{
	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public string LJNIMBFGBBD
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public HAMPDEHBMKD BKLEEOCAEHK
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xAE0120", Offset = "0xADEB20", VA = "0x180AE0120")]
		[CompilerGenerated]
		get
		{
			return default(HAMPDEHBMKD);
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xAE0110", Offset = "0xADEB10", VA = "0x180AE0110")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public JGOEGDIMENE KJLNBPLNLCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xC33060", Offset = "0xC31A60", VA = "0x180C33060")]
		[CompilerGenerated]
		get
		{
			return default(JGOEGDIMENE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x1058A60", Offset = "0x1057460", VA = "0x181058A60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public IBHALMKBJDP NJPKKGLIHDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5B0", Offset = "0xA8CFB0", VA = "0x180A8E5B0")]
		[CompilerGenerated]
		get
		{
			return default(IBHALMKBJDP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5E0", Offset = "0xA8CFE0", VA = "0x180A8E5E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	[DataMember(Name = "Header")]
	public string? PJFIDEBMOOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public string? KPLKBICGAHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xA88310", Offset = "0xA86D10", VA = "0x180A88310")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public string? DKCLHOJLCCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xA91C70", Offset = "0xA90670", VA = "0x180A91C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xA88530", Offset = "0xA86F30", VA = "0x180A88530")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public List<string> GFOMIGOBHOG
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA88320", Offset = "0xA86D20", VA = "0x180A88320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xA88300", Offset = "0xA86D00", VA = "0x180A88300")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public List<LADLKOFNNNG> GHKOBOOGLCL
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA84210", Offset = "0xA82C10", VA = "0x180A84210")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA84220", Offset = "0xA82C20", VA = "0x180A84220")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x77A4B90", Offset = "0x77A3590", VA = "0x1877A4B90", Slot = "5")]
	public override void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x77A4BA0", Offset = "0x77A35A0", VA = "0x1877A4BA0")]
	public FNHHKLICNDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public enum IODMEMPMNJA
{
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	Url,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	AccountId,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	EventId,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	RoomName,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	Storefront,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[Obsolete("6/4/21: This was only ever used for an announcement for Shawn's referral event, which is not happening again. Removing as part of a StackUI cleanup")]
	ActionCode,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	Item,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	CustomAvatarItem,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	AuthorizedRecNetUrl,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	Close
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum HAMPDEHBMKD
{
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	Vertical,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	Horizontal
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public enum JGOEGDIMENE
{
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	Small,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Medium,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	Large
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public enum IBHALMKBJDP
{
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	Before,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	Overlay,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	After
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[GBAJJMJPMAP]
public class LADLKOFNNNG : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public IODMEMPMNJA MPJPBLDEPFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
		[CompilerGenerated]
		get
		{
			return default(IODMEMPMNJA);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xA90060", Offset = "0xA8EA60", VA = "0x180A90060")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public string? OJKHMJFICLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	[DataMember(Name = "LinkParameter")]
	public string? FFPCMAKJCHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public string? PFOJDAHNOBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public LADLKOFNNNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public abstract class PGABMOBLEAG : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	[IgnoreDataMember]
	public string? GALCAADADEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void MCAPBBPIBEB();

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x77AC170", Offset = "0x77AAB70", VA = "0x1877AC170")]
	protected PGABMOBLEAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[GBAJJMJPMAP]
public class EEOFHJFBFHC : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public string? MBGOONGOCOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public EEOFHJFBFHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[GBAJJMJPMAP]
public class DNJAMDFFKJI : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	internal static Func<string, FNHHKLICNDL>? GMHCFIFFAEM;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	internal static Func<string, DLJJOGGDAGC>? BPDFHHMBOPM;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public string? MBGOONGOCOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public string? IOJADLEOAGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool KMGFLIBOBDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xA88540", Offset = "0xA86F40", VA = "0x180A88540")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xA88520", Offset = "0xA86F20", VA = "0x180A88520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public NPJJEBGBNDK MCMACGOEKEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xC33060", Offset = "0xC31A60", VA = "0x180C33060")]
		[CompilerGenerated]
		get
		{
			return default(NPJJEBGBNDK);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x1058A60", Offset = "0x1057460", VA = "0x181058A60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public KNEJLBPHMMH AHFCPLGALCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5B0", Offset = "0xA8CFB0", VA = "0x180A8E5B0")]
		[CompilerGenerated]
		get
		{
			return default(KNEJLBPHMMH);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5E0", Offset = "0xA8CFE0", VA = "0x180A8E5E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public int MCOLDCCMNAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xAD60D0", Offset = "0xAD4AD0", VA = "0x180AD60D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x1644B20", Offset = "0x1643520", VA = "0x181644B20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public DateTime FPIFKDODAOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA882E0", Offset = "0xA86CE0", VA = "0x180A882E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	[DataMember(Name = "IsRead")]
	internal bool JMMOFCOJKDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xAE6140", Offset = "0xAE4B40", VA = "0x180AE6140")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xAE6AC0", Offset = "0xAE54C0", VA = "0x180AE6AC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	[IgnoreDataMember]
	public bool HMNIMHKKOFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x1525280", Offset = "0x1523C80", VA = "0x181525280")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x1524B50", Offset = "0x1523550", VA = "0x181524B50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public ALHHIDLJHCI CKKHJJKOGEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xAA3B40", Offset = "0xAA2540", VA = "0x180AA3B40")]
		[CompilerGenerated]
		get
		{
			return default(ALHHIDLJHCI);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x16F4230", Offset = "0x16F2C30", VA = "0x1816F4230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public IHIABAMKJIN KKHIMBCEJIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xAF1310", Offset = "0xAEFD10", VA = "0x180AF1310")]
		[CompilerGenerated]
		get
		{
			return default(IHIABAMKJIN);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xAF1670", Offset = "0xAF0070", VA = "0x180AF1670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	internal string? FHHKBAODJOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xA88320", Offset = "0xA86D20", VA = "0x180A88320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xA88300", Offset = "0xA86D00", VA = "0x180A88300")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	[IgnoreDataMember]
	public FNHHKLICNDL? MNIOMGGILEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x77A33A0", Offset = "0x77A1DA0", VA = "0x1877A33A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	[IgnoreDataMember]
	public DLJJOGGDAGC? DADMHMBGODA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x77A2FE0", Offset = "0x77A19E0", VA = "0x1877A2FE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	[IgnoreDataMember]
	public PGABMOBLEAG? OEADHMLMCPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xA84210", Offset = "0xA82C10", VA = "0x180A84210")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA84220", Offset = "0xA82C20", VA = "0x180A84220")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x77A3070", Offset = "0x77A1A70", VA = "0x1877A3070", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0xAAFEE0", Offset = "0xAAE8E0", VA = "0x180AAFEE0")]
	public DNJAMDFFKJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[GBAJJMJPMAP]
public class EDJHCEFPBDE : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public CMBELOFIKNO EANNADHFBDL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
		[CompilerGenerated]
		get
		{
			return default(CMBELOFIKNO);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xA90060", Offset = "0xA8EA60", VA = "0x180A90060")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public string MGGKHGPKLDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public int GKFAFNGGAOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xAE0120", Offset = "0xADEB20", VA = "0x180AE0120")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xAE0110", Offset = "0xADEB10", VA = "0x180AE0110")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x77A3620", Offset = "0x77A2020", VA = "0x1877A3620")]
	public EDJHCEFPBDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[GBAJJMJPMAP]
public class DLJJOGGDAGC : PGABMOBLEAG
{
	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public string BNKJJMGGNNH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public string? FAHMGKIDCFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public KFDBCDAPEMD HCPODONJHPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5B0", Offset = "0xA8CFB0", VA = "0x180A8E5B0")]
		[CompilerGenerated]
		get
		{
			return default(KFDBCDAPEMD);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5E0", Offset = "0xA8CFE0", VA = "0x180A8E5E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	[DataMember(Name = "all_conditions_required")]
	public bool JLFJMEPMLLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x18050E0", Offset = "0x1803AE0", VA = "0x1818050E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x106AE70", Offset = "0x1069870", VA = "0x18106AE70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public List<EDJHCEFPBDE> OJEMMCKIDOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x77A2EA0", Offset = "0x77A18A0", VA = "0x1877A2EA0", Slot = "5")]
	public override void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x77A2EB0", Offset = "0x77A18B0", VA = "0x1877A2EB0")]
	public DLJJOGGDAGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public enum IHIABAMKJIN
{
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	ContentBlock,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	JustInTimeTutorialTrigger
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public enum ALHHIDLJHCI
{
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	Announcements,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	JustInTimeTutorials
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public enum KFDBCDAPEMD
{
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	Unknown = 0,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	MakerPenButtonHighlight = 1,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	PlaceControlTutorial = 3
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public enum CMBELOFIKNO
{
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	EnteredRoom = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	TimeInRoom = 1,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	ObjectInteractionRoom = 2,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	ObjectPlaceStartedRoom = 4
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface PBEKKMJBGAC
{
	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	bool CKOJNDCOBPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	ECMKKKEPCGP<DNJAMDFFKJI> IIBMHGACIDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	ECMKKKEPCGP<string> ECHNFLHLHCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	ECMKKKEPCGP<DNJAMDFFKJI> BCHPPGPGLBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	ECMKKKEPCGP<DNJAMDFFKJI> ILFGHKBHOCF
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<DNJAMDFFKJI> EIBCCINKKHL(ALHHIDLJHCI GEBANPLEEEG);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<DNJAMDFFKJI> DNNGBNBNPLG(ALHHIDLJHCI GEBANPLEEEG);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DNJAMDFFKJI OMLHNMLHCNF(ALHHIDLJHCI GEBANPLEEEG, string MPOMJBFIAML);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DNJAMDFFKJI OFNNPNLPFBC(ALHHIDLJHCI GEBANPLEEEG);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OJBBNBFKPJN(ALHHIDLJHCI GEBANPLEEEG);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int POBOJJKGBEF(ALHHIDLJHCI GEBANPLEEEG);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task ECGDFBBCFAD();

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task KPBIKAFIEPM(DNJAMDFFKJI ONGDPODJNBL);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface MEFCPBHEKGO
{
	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	CGJCMKMFOBC BODLAGCDIBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	int JIPCHKJONGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	bool MKPLFDFGPNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	bool LLGBOABIGDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	bool GKIGCDEKDPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	bool NOBLIECIABH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	bool LDPAOBALAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	bool DIKHOFEGCEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	bool BJKJLGLDHHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	bool EJALFKJBJLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	bool BKCFAKFOEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	bool HJDMDMJMGNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action PAIIINBBIDK;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action NKOMJAKELOO;

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "16")]
	DPMDGLGHBHJ<IEIPJLIICDB> FGLPOIKAAIL(int LHPHKGMDHKM);

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "17")]
	PNBAKNHPHGJ LLMIADBAIHM(DateTime BBEDKNEDNAJ);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "18")]
	PNBAKNHPHGJ ODOAMAPJBOJ(string NHLFIGMLKML);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task JNGPGCLHFOH([Optional] CancellationToken OMJKEHOJJFF);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public enum KNHKKGHHOEL
{
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	Memory,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	Multiplayer
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class AMNFLEPHHLA
{
	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x77A1210", Offset = "0x779FC10", VA = "0x1877A1210")]
	public static string PIPHNKCPGEM(this KNHKKGHHOEL AIEHGBKNBKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface EOKIHLGAFFP
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<DNJAMDFFKJI>> CLABMNLPPBH(ALHHIDLJHCI GEBANPLEEEG);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KPBIKAFIEPM(string MPOMJBFIAML);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface IBMBHBPBOJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LKGLJKLFIBE> GDCDHPKBGLB();
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface EJEABPLFEKE
{
	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DPMDGLGHBHJ<List<CKOEKGKGELG>> PIEIKABCCNA();

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DPMDGLGHBHJ<List<CKOEKGKGELG>> HFELNDOPJOP();

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<List<CKOEKGKGELG>> HLIGKBOKLNB([Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DPMDGLGHBHJ<List<CKOEKGKGELG>> OCLAPFDNCKM(List<ANBOJIKIHHJ> ODLKMOOGLMN);

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DPMDGLGHBHJ<List<CKOEKGKGELG>> AKLJFKHGLKI(List<ANBOJIKIHHJ> ODLKMOOGLMN);
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface KGFKJFFLCNF
{
	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	List<PKPHPAIKFAL> ABLBPLINGGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<KJPHDFMLMPO> JJOONPEGBLH;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<PKPHPAIKFAL> BKOIEGHEDKO;

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PNBAKNHPHGJ PEMBFIBNLDI(PKPHPAIKFAL JFKANPIFAOG);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task CHFDIGABPAD(PKPHPAIKFAL JFKANPIFAOG);

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "7")]
	[Obsolete("Alternate gift contexts are being phased out. Use LocalRequestGiftPackage(GiftContext context, string message) instead")]
	DPMDGLGHBHJ<PKPHPAIKFAL> EPGLHMNMLAJ(APJEKMFCMFG HCLPHJDKMCA, APJEKMFCMFG? KHFMOAGDKDJ, bool OGNBFKFJOHG, string ONGDPODJNBL);

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "8")]
	DPMDGLGHBHJ<PKPHPAIKFAL> EPGLHMNMLAJ(APJEKMFCMFG HCLPHJDKMCA, string ONGDPODJNBL);

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DFDAMPKEEPD(PKPHPAIKFAL KPDNPCBAIOF, bool OLLDPDILHAD = false, bool OKGMDCNFLJF = false, bool OHIPHDMJOAE = true);

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(Slot = "10")]
	DPMDGLGHBHJ<List<PKPHPAIKFAL>> CGIHHKHEPCK();
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface JDDJLFNEJBD
{
	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	string OJGCELJFOCP
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	bool HPLBDAGKBJP
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PNBAKNHPHGJ LGENFDADEOF();

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PNBAKNHPHGJ FAJOKFONIFL(string EJBAJPJCAGB, string PIDDJHFPHCF);

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PNBAKNHPHGJ PKODJBGCAJA(string AEIGHGCLPJP);

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JKHMCLKODGK();

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<JDADCCFKFAP> PBCLHBGONFB(string NHLFIGMLKML, string AEIGHGCLPJP, bool JKNKKNBMIHK, string MPNHIEJPDKH, string NIKJHLIANND, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task ALCMDBDBHCA(int LHPHKGMDHKM, string FHNBPGNFFBA, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task AGMIKNEJELD(int LHPHKGMDHKM, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task MCEPOPGMEFH([Optional] KNHKKGHHOEL? JCCAEEFNAHO, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<IReadOnlyList<GGCJJHIBFEG>> LEEMNAAFNPJ([Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task NPPHCOGAJKL([Optional] CancellationToken OMJKEHOJJFF);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface LFFEFBOGOJD
{
	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<CNNNFHGDLNJ>> NKHEPAFHIGM([Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<List<MIAIEJINELL>> EKLCOMDBIEP([Optional] CancellationToken OMJKEHOJJFF);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface NFOFPLHJAGH
{
	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task BGNNGAMACJK([Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FGLGBKHFALG();
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface PFPBMDGMJNK
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event HMDLEHNKEGE? CFKFIPGCMEP;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event HMDLEHNKEGE? APLLFGFJGPL;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event HMDLEHNKEGE? LJPBEDNDPCJ;

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<JDJOPBCDFGB> GNMLKEJBGNG();

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<JDJOPBCDFGB?>? HEODOPGDJPM(int LHPHKGMDHKM);

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<List<CAIOEJIMOKM>> CPIOFGLJGJM(List<int> BNGCOGOKHNL);

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<IReadOnlyDictionary<int, JDJOPBCDFGB>> KIMNCLGAIBA();

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<List<JDJOPBCDFGB?>?>? FFKOMFFCEAJ(int LHPHKGMDHKM);

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task AGIFBAEIGKC(int DOBBKHLICOG);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<OONMGGAOEHG> JIJDGFDNBJL(JDJOPBCDFGB MGGPIEFFOLF);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public delegate void HMDLEHNKEGE(int LHPHKGMDHKM, int DOBBKHLICOG, JDJOPBCDFGB? MGGPIEFFOLF);
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface CIJOJACAEON : NOAGHEHNNOG, FLGJNBAIAAH
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[Flags]
	public enum PLOMMGEKJNH
	{
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		FilterProfanity = 1,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		FilterURL = 2
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	string EKFPLMDBLKD
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	OLNPCLKFKJH JKOEDDDJDPP
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	NPJJEBGBNDK MCMACGOEKEC
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	string JJBLOFPKMJN
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	byte FGLFCFEPPJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	int DNKMICNJPFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	int NBECDHFOHHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	bool BOJHLPCPHOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	bool OBNIHKFHNBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	bool OKMKHJPJDEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	bool HKDJDFKALBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	bool APDCNNIJDCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	bool KBCCDCDCGGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	bool BOLBKFMCNMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DPMDGLGHBHJ<string> JLLCFHOPIEJ();

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<string> JBNKPOCGJDH();

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DPMDGLGHBHJ<bool> IsPlayerCommunicationRestricted(int LHPHKGMDHKM);

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	string KMPOEOKCPNF(string FLBFBHGDBLM, bool FAFCEMLLAHK = true);

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<string> DGFJKKDLKOJ(string FLBFBHGDBLM, bool FAFCEMLLAHK = true);

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	DPMDGLGHBHJ<string> MakeRoomNameAdhereToPlatformRequirements(long DKMPIOFKFMN, string FLBFBHGDBLM);

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool SanitizeDisplayText(string OAONGIENCOA, PLOMMGEKJNH FEIBLFEALBB = PLOMMGEKJNH.FilterProfanity | PLOMMGEKJNH.FilterURL);

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<string> SanitizeDisplayTextAsync(string OAONGIENCOA, PLOMMGEKJNH FEIBLFEALBB = PLOMMGEKJNH.FilterProfanity | PLOMMGEKJNH.FilterURL, bool MOPBHNECKFI = false);

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool CheckNameForProfanity(string FLBFBHGDBLM, PLOMMGEKJNH FEIBLFEALBB = PLOMMGEKJNH.FilterProfanity | PLOMMGEKJNH.FilterURL);

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(Slot = "23")]
	DPMDGLGHBHJ<string> GetCommerceSubscriptionAccessToken();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface DMAADHIELLM
{
	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<OGMDLPOJNPO>> IKCDEALMCOP([Optional] CancellationToken OMJKEHOJJFF);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface AFOKIIIPBIK
{
	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NIKJFNDLLNE(byte[] KEGBPMLIINA, byte[] MPMOMAIIHLJ);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface NBKBHNMJMNE
{
	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task LCMLJHODFCE(string AEJBAKIGPEC);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface OBBCKIHDFGM
{
	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	ECMKKKEPCGP<LCHFHIIJLND> OJBLGPLFPHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<bool> MGGBFBHLOGI(string CNHFAKOCKCL);

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<KLPLEKCBDLH> COJCOOFNNFM(string CNHFAKOCKCL, string IOHJDFLHOBN);

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task ANHKCENPGAK(string CNHFAKOCKCL, IEnumerable<string> FLMCNDHLDBG, int JPGBGDKOAGI = 0);

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<List<AMBDMJNECED<FilteredTextDTO>>> ANJHCKJEMMA(uint KMOKEFHLOMJ, IEnumerable<string> FLMCNDHLDBG);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface DAPBHJJNPAL
{
	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MCOKIEEBEBD([Out] bool PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BLKFNOCHCOP([Out] bool PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PIFPJPOIFCP([Out] int PDKJBMPOMNC);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public enum OKCGHCLNJNE
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	BasedOnBirthday,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	ModerationOverride,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	PendingOverride
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum CMEPLBOAKLB
{
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Id,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	Email,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	Phone
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[Flags]
public enum DPFFAKFHPBH
{
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	SheHer = 1,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	HeHim = 2,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	TheyThem = 4,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	ZeHir = 8,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	ZeZir = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	XeXem = 0x20
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[Flags]
public enum DAPKEJBAGEL
{
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	LGBTQIA = 1,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	Transgender = 2,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	Bisexual = 4,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	Lesbian = 8,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	Pansexual = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	Asexual = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	Intersex = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	Genderqueer = 0x80,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	Nonbinary = 0x100,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	Aromantic = 0x200
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public enum BOINAJFNAPF
{
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	Daily = 10,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	Weekly = 20,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	Monthly = 30,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	Never = 40,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	Yes = 50
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public enum JENINELOJMF
{
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	BELOW_TEN = 0,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	BETWEEN_TEN_AND_TWELVE = 10,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	TEEN = 13,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	ADULT = 18,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	UNKNOWN = 999
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface IEIPJLIICDB
{
	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	int DIJMFFFNHIF
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	string GJCAKAHDMNC
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	string HALANACBELK
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	string DBGHCHDGBMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	string DMFJIGLCAJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	string LOBLMPCBLIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	string EHHOKGMMFNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	bool IGEENOECDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	bool ENOOEOAMAFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	DPFFAKFHPBH JMDDFGBIHBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	DAPKEJBAGEL KAGLBCBPPFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	DateTime NEFPGADCCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	bool? ONFCOMLCNJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DCAJNMPBNCH(bool AFBIEFBGKJH);

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void AJFJGIBMJPA(bool FODCBOLMECH);
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface CGJCMKMFOBC : IEIPJLIICDB
{
	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	string IAAJKADPNKP
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	string OBKNLNKNALH
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	DateTime? MCBHPEKBFAK
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	OKCGHCLNJNE PCPIJFHALEH
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	int? BMNDHBOHFJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	int MNNBIJFPGGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	bool HIIKEKEFLMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	bool IJGPHDFGLOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	bool? IEAKPLAMMLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class GAEDJHEJNNL
{
	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public IEIPJLIICDB AKPDMIPENPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public CMEPLBOAKLB FDPLDNEDDDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5C0", Offset = "0xA8CFC0", VA = "0x180A8E5C0")]
		[CompilerGenerated]
		get
		{
			return default(CMEPLBOAKLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public string IHJAGEBDEAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x7130DC0", Offset = "0x712F7C0", VA = "0x187130DC0")]
	public GAEDJHEJNNL(IEIPJLIICDB HANNCBFICKK, CMEPLBOAKLB MEHICLNGBMG, string IOLGIJHIPJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public interface HKABKDDBKKD
{
	[Cpp2IlInjected.Token(Token = "0x17000118")]
	int DIJMFFFNHIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	bool EHPOBCBPLAO
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface BPMHBIPCPKP
{
	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	int DIJMFFFNHIF
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	bool OHOAANOCDDM
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public interface FDPFBKGBKLK
{
	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	int DIJMFFFNHIF
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	string KJLNCLAFOKC
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public enum NAPDNNCNOPF
{
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	Outfit,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	HairDye,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	CustomOutfit
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class CKOEKGKGELG
{
	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public NAPDNNCNOPF PHHPCIODAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
		[CompilerGenerated]
		get
		{
			return default(NAPDNNCNOPF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xA90060", Offset = "0xA8EA60", VA = "0x180A90060")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public string BMEFPAKGMBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public string OPBPLKIAMMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public HLLCBMIFJOL CDDDOEEINIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5B0", Offset = "0xA8CFB0", VA = "0x180A8E5B0")]
		[CompilerGenerated]
		get
		{
			return default(HLLCBMIFJOL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5E0", Offset = "0xA8CFE0", VA = "0x180A8E5E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public string FGMPDPILNIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public int DPAFLFCIDHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0xAA3B30", Offset = "0xAA2530", VA = "0x180AA3B30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0xEAC2E0", Offset = "0xEAACE0", VA = "0x180EAC2E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public bool BKCEMAAPKOD
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xF91F00", Offset = "0xF90900", VA = "0x180F91F00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0xF91390", Offset = "0xF8FD90", VA = "0x180F91390")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public ANBOJIKIHHJ APJGDNKOGJN
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x1519920", Offset = "0x1518320", VA = "0x181519920")]
		[CompilerGenerated]
		get
		{
			return default(ANBOJIKIHHJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x77A1780", Offset = "0x77A0180", VA = "0x1877A1780")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public KOELLOADCHB FDMPAGKJKLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x1BF12E0", Offset = "0x1BEFCE0", VA = "0x181BF12E0")]
		[CompilerGenerated]
		get
		{
			return default(KOELLOADCHB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x53213B0", Offset = "0x531FDB0", VA = "0x1853213B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public string MMLCFAGPBDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xA909E0", Offset = "0xA8F3E0", VA = "0x180A909E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0xA909C0", Offset = "0xA8F3C0", VA = "0x180A909C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public DateTime NEFPGADCCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xA909D0", Offset = "0xA8F3D0", VA = "0x180A909D0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x582F810", Offset = "0x582E210", VA = "0x18582F810")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x77A18E0", Offset = "0x77A02E0", VA = "0x1877A18E0")]
	internal CKOEKGKGELG(FEJFJNCGFKA DALKEAMAODE, AGIHLMKDAGP HGJLHPDDDCD, GIAOBDOCLCJ HKJLNLEACIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x77A17A0", Offset = "0x77A01A0", VA = "0x1877A17A0")]
	public CKOEKGKGELG(NAPDNNCNOPF IIEJGKEHFHN = NAPDNNCNOPF.Outfit, [Optional] ANBOJIKIHHJ KFCEJIMBCCO, [Optional] string NKEANKNENKE, [Optional] string JIPOFOKLOJJ, HLLCBMIFJOL HDHOOIKMAHB = HLLCBMIFJOL.Common, [Optional] string CDABBLNAPID, int GDOCOMJBPDA = 0, bool LPGJEONANGH = false, [Optional] string EAJHBCOFNMC, [Optional] DateTime? GCDIBLHKMKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[GBAJJMJPMAP]
public class FEJFJNCGFKA : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public NAPDNNCNOPF PHHPCIODAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
		[CompilerGenerated]
		get
		{
			return default(NAPDNNCNOPF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0xA90060", Offset = "0xA8EA60", VA = "0x180A90060")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	[DataMember(Name = "AvatarItemDesc")]
	public string KAGIANGFILO
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public string BMEFPAKGMBA
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public string OPBPLKIAMMI
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public HLLCBMIFJOL CDDDOEEINIC
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0xA938E0", Offset = "0xA922E0", VA = "0x180A938E0")]
		[CompilerGenerated]
		get
		{
			return default(HLLCBMIFJOL);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xA93AE0", Offset = "0xA924E0", VA = "0x180A93AE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public string FGMPDPILNIO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xA88310", Offset = "0xA86D10", VA = "0x180A88310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public int DPAFLFCIDHO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0xAF1310", Offset = "0xAEFD10", VA = "0x180AF1310")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xAF1670", Offset = "0xAF0070", VA = "0x180AF1670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public bool BKCEMAAPKOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x192DCA0", Offset = "0x192C6A0", VA = "0x18192DCA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x193BDC0", Offset = "0x193A7C0", VA = "0x18193BDC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public string BJNKLIMPDEN
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0xA88320", Offset = "0xA86D20", VA = "0x180A88320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0xA88300", Offset = "0xA86D00", VA = "0x180A88300")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public DateTime NEFPGADCCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xA84210", Offset = "0xA82C10", VA = "0x180A84210")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0xF91920", Offset = "0xF90320", VA = "0x180F91920")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public FEJFJNCGFKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[GBAJJMJPMAP]
public sealed class EFJLEDFBICK : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public List<string> IGAJAHEGMGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x77A3670", Offset = "0x77A2070", VA = "0x1877A3670")]
	public EFJLEDFBICK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0xA93860", Offset = "0xA92260", VA = "0x180A93860")]
	public EFJLEDFBICK(List<string> ODLKMOOGLMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[GBAJJMJPMAP]
public class LKGLJKLFIBE : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public OGMDHBIIBAG AAFJGLHPKHE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public OCLNDDJKGGB AKGHCENHCNH
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public LKGLJKLFIBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0xA93780", Offset = "0xA92180", VA = "0x180A93780")]
	public LKGLJKLFIBE(OGMDHBIIBAG JFDDCKACLDK, OCLNDDJKGGB GFPBEJKHFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public enum GECHJFPPMNA
{
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	Braze,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	Rengage
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public enum PKEFFLKIGBB : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	APNS,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	Firebase,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	Mock,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	Braze,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	Rengage
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[GBAJJMJPMAP]
public class OGMDHBIIBAG : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public GECHJFPPMNA JOAHGCOECKG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
		[CompilerGenerated]
		get
		{
			return default(GECHJFPPMNA);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0xA90060", Offset = "0xA8EA60", VA = "0x180A90060")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public PKEFFLKIGBB? FEKDNGMMHLH
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x3183480", Offset = "0x3181E80", VA = "0x183183480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x7634170", Offset = "0x7632B70", VA = "0x187634170")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public bool AFAMDJOINHK
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x2021D60", Offset = "0x2020760", VA = "0x182021D60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x2021D70", Offset = "0x2020770", VA = "0x182021D70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x77AB3C0", Offset = "0x77A9DC0", VA = "0x1877AB3C0")]
	public OGMDHBIIBAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x77AB330", Offset = "0x77A9D30", VA = "0x1877AB330")]
	public OGMDHBIIBAG(GECHJFPPMNA FPDNOPKDGBJ, PKEFFLKIGBB GDOLEAIOBOA, bool ECDEADEFLND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[GBAJJMJPMAP]
public class OCLNDDJKGGB : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public string LBHDIKMAOFM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public string ECEHKMIFMPF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public OCLNDDJKGGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0xA93780", Offset = "0xA92180", VA = "0x180A93780")]
	public OCLNDDJKGGB(string EDLJIJLPMGA, string HACEHCEMKID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public enum OLNPCLKFKJH
{
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	VR,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	Screen,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	Mobile,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	VRLow,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	Quest2
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct KJPHDFMLMPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public PKPHPAIKFAL KLFKDBCOFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public bool MBJNMFKDBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public bool OICKGMBMLHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public bool NLFAOMKHOND;
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[GBAJJMJPMAP]
public class PKPHPAIKFAL : LOCJLHBEEIF, BHOLJOIPLEN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct ENIDGBPCANM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public PKPHPAIKFAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x77A4150", Offset = "0x77A2B50", VA = "0x1877A4150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x77A42E0", Offset = "0x77A2CE0", VA = "0x1877A42E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400015A")]
	internal static Action<PKPHPAIKFAL> FFLNMNECIMJ;

	[Cpp2IlInjected.Token(Token = "0x400015B")]
	internal static Func<PKPHPAIKFAL, Task> KGCMDOFPLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC1")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[IgnoreDataMember]
	public bool CCOIABDPJAB;

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public long? BIKKNIIFDAP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xE823D0", Offset = "0xE80DD0", VA = "0x180E823D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xE823E0", Offset = "0xE80DE0", VA = "0x180E823E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public int HAGDNBLHJBI
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xAE0120", Offset = "0xADEB20", VA = "0x180AE0120")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xAE0110", Offset = "0xADEB10", VA = "0x180AE0110")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public int? POPFOJLABHE
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x136E660", Offset = "0x136D060", VA = "0x18136E660")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x10771E0", Offset = "0x1075BE0", VA = "0x1810771E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public string JBPKKCONGMC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public NAPDNNCNOPF? PHHPCIODAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0xA938F0", Offset = "0xA922F0", VA = "0x180A938F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	[DataMember(Name = "AvatarItemDesc")]
	public string DDHOMGFKBOM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xA91C70", Offset = "0xA90670", VA = "0x180A91C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xA88530", Offset = "0xA86F30", VA = "0x180A88530")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public Guid? FLMOBMMCAHM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x77A7770", Offset = "0x77A6170", VA = "0x1877A7770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x77A7740", Offset = "0x77A6140", VA = "0x1877A7740")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public string NJIIHJACBOO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xA841E0", Offset = "0xA82BE0", VA = "0x180A841E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xA841C0", Offset = "0xA82BC0", VA = "0x180A841C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public string BDIKMLEFIAA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xA841B0", Offset = "0xA82BB0", VA = "0x180A841B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xA841A0", Offset = "0xA82BA0", VA = "0x180A841A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public OICCDKGHIEL NFLCNKKLELI
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xAAD1D0", Offset = "0xAABBD0", VA = "0x180AAD1D0")]
		[CompilerGenerated]
		get
		{
			return default(OICCDKGHIEL);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x1577D80", Offset = "0x1576780", VA = "0x181577D80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public int JAAHBPDPGGM
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xAAD230", Offset = "0xAABC30", VA = "0x180AAD230")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x1577CF0", Offset = "0x15766F0", VA = "0x181577CF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public int JPJNOCOEPOP
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xAF41B0", Offset = "0xAF2BB0", VA = "0x180AF41B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x1037BC0", Offset = "0x10365C0", VA = "0x181037BC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public APJEKMFCMFG IPPLGDLEAHH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0xAF41E0", Offset = "0xAF2BE0", VA = "0x180AF41E0")]
		[CompilerGenerated]
		get
		{
			return default(APJEKMFCMFG);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x15C32F0", Offset = "0x15C1CF0", VA = "0x1815C32F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public HLLCBMIFJOL NBIBMKNBMNM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xD41DF0", Offset = "0xD407F0", VA = "0x180D41DF0")]
		[CompilerGenerated]
		get
		{
			return default(HLLCBMIFJOL);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x15991B0", Offset = "0x1597BB0", VA = "0x1815991B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	[DataMember(Name = "Message")]
	public string BBFFNHEGPED
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xA909D0", Offset = "0xA8F3D0", VA = "0x180A909D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0xA90970", Offset = "0xA8F370", VA = "0x180A90970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public string GKKKMGKJHNL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xAEDCD0", Offset = "0xAEC6D0", VA = "0x180AEDCD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xAEB9B0", Offset = "0xAEA3B0", VA = "0x180AEB9B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public bool EOOKCBDGIIF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xF91FB0", Offset = "0xF909B0", VA = "0x180F91FB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xF91CA0", Offset = "0xF906A0", VA = "0x180F91CA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public NPJJEBGBNDK MCMACGOEKEC
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xF17670", Offset = "0xF16070", VA = "0x180F17670")]
		[CompilerGenerated]
		get
		{
			return default(NPJJEBGBNDK);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xF15B30", Offset = "0xF14530", VA = "0x180F15B30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public KNEJLBPHMMH PHPLPNEKGME
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0xA909F0", Offset = "0xA8F3F0", VA = "0x180A909F0")]
		[CompilerGenerated]
		get
		{
			return default(KNEJLBPHMMH);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xA908F0", Offset = "0xA8F2F0", VA = "0x180A908F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public NKILPDNDKBO? MMBEAHEGHMG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x14B2A40", Offset = "0x14B1440", VA = "0x1814B2A40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x77AC220", Offset = "0x77AAC20", VA = "0x1877AC220")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public bool EKJDIPPOENB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x77AC2B0", Offset = "0x77AACB0", VA = "0x1877AC2B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public bool MJFDEPDOMKF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x77AC230", Offset = "0x77AAC30", VA = "0x1877AC230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public bool GJAKJPHJILH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x77AC3F0", Offset = "0x77AADF0", VA = "0x1877AC3F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	[IgnoreDataMember]
	public bool EGGFOPDGJMF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xA8F2D0", Offset = "0xA8DCD0", VA = "0x180A8F2D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0xA8F2C0", Offset = "0xA8DCC0", VA = "0x180A8F2C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	[IgnoreDataMember]
	public bool DKCDJFPCHCL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x2E0DA20", Offset = "0x2E0C420", VA = "0x182E0DA20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x2E0D260", Offset = "0x2E0BC60", VA = "0x182E0D260")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	[IgnoreDataMember]
	public string AAOGEDGENAH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0xB406B0", Offset = "0xB3F0B0", VA = "0x180B406B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xB405B0", Offset = "0xB3EFB0", VA = "0x180B405B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	[IgnoreDataMember]
	public string CEJINEPLDKC
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xE93590", Offset = "0xE91F90", VA = "0x180E93590")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0xE935A0", Offset = "0xE91FA0", VA = "0x180E935A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	[IgnoreDataMember]
	public bool IDJGJCEBALB
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x108B810", Offset = "0x108A210", VA = "0x18108B810")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xD2A210", Offset = "0xD28C10", VA = "0x180D2A210")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x77AC250", Offset = "0x77AAC50", VA = "0x1877AC250", Slot = "5")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x77AC320", Offset = "0x77AAD20", VA = "0x1877AC320", Slot = "6")]
	[AsyncStateMachine(typeof(ENIDGBPCANM))]
	public virtual Task OENOAICBHGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x15C32F0", Offset = "0x15C1CF0", VA = "0x1815C32F0")]
	public void LNENHFDMLNE(APJEKMFCMFG HCLPHJDKMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public PKPHPAIKFAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public interface FCPINIKHONM
{
	[Cpp2IlInjected.Token(Token = "0x17000157")]
	long MBLENMJCHCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	string NMDCNEEIOEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	int JINCPGDOAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	string FAHMGKIDCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	string LHKEDLABPNK
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	string JLCGJFKDJCF
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	string HHBAAHCOJDA
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	byte CMECFEBLLCI
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	int ECCBBIPPMFI
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	int IJBCOBKDLCA
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	MNNPGENBKHF GJDGGAEABJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	bool FJAMJHKHMIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	DateTime NDENGKFIMKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	DateTime NEFPGADCCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	DateTime? KJDFGNHIOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	long? KBCOOFFELGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	int EFELDNGFPME
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	int HGMOKMEDBDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	int FGGLBOPKKGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	LKHDDCCGHNO JPEFAENLJLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	LKHDDCCGHNO POGNHACPKHD
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	bool MIDPPCAPKNA
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	bool CFGIGONNMJG
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	bool EPHKJOFGHGH
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	bool FHKBMAOEFDG
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	int? BNDLIGFBKCA
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	bool PBKCOBOHONA
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	string CGPLBNMJCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LKAMCIGNCCG();

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ENMMFCGMCGO();
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[GBAJJMJPMAP]
public class PLACLPHGGKD : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public List<AJMDKHEGLAC> CIBDIGEMLDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x77AC490", Offset = "0x77AAE90", VA = "0x1877AC490")]
	public List<string> LCHEBGDBJOA(params OOEFJEHICNE[] IIPMNJFPGLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x77AC410", Offset = "0x77AAE10", VA = "0x1877AC410")]
	public List<string> BKNGDIJMCOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x77AC650", Offset = "0x77AB050", VA = "0x1877AC650")]
	public List<string> LJGAIHOGGAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x77AC6A0", Offset = "0x77AB0A0", VA = "0x1877AC6A0", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public PLACLPHGGKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[GBAJJMJPMAP]
public class ANHHBDGFDAD : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public int JINCPGDOAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0xA90060", Offset = "0xA8EA60", VA = "0x180A90060")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public ANHHBDGFDAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[GBAJJMJPMAP]
public class OHBAEDAMDIP : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public long MBLENMJCHCP
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xE6CA00", Offset = "0xE6B400", VA = "0x180E6CA00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public string NMDCNEEIOEH
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public int HFCJGHGDFIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xAE0120", Offset = "0xADEB20", VA = "0x180AE0120")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xAE0110", Offset = "0xADEB10", VA = "0x180AE0110")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public bool GJIBDMDNEBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xE64A90", Offset = "0xE63490", VA = "0x180E64A90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xE64630", Offset = "0xE63030", VA = "0x180E64630")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public int LJGMOOGNOAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5B0", Offset = "0xA8CFB0", VA = "0x180A8E5B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5E0", Offset = "0xA8CFE0", VA = "0x180A8E5E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public int MANELMFPMGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xAD60D0", Offset = "0xAD4AD0", VA = "0x180AD60D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x1644B20", Offset = "0x1643520", VA = "0x181644B20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public int DJOHFOMHPED
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0xA938E0", Offset = "0xA922E0", VA = "0x180A938E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xA93AE0", Offset = "0xA924E0", VA = "0x180A93AE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public int HOKLMJCBJMH
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xAC70E0", Offset = "0xAC5AE0", VA = "0x180AC70E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xAC6990", Offset = "0xAC5390", VA = "0x180AC6990")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	public string HEOLPDIGALC
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0xA88310", Offset = "0xA86D10", VA = "0x180A88310")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	public string BOBHCDGCKID
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xA91C70", Offset = "0xA90670", VA = "0x180A91C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xA88530", Offset = "0xA86F30", VA = "0x180A88530")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	public DateTime NEFPGADCCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xA88320", Offset = "0xA86D20", VA = "0x180A88320")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x13AB4E0", Offset = "0x13A9EE0", VA = "0x1813AB4E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	public MNNPGENBKHF? FCIJEJDNKAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0xA84210", Offset = "0xA82C10", VA = "0x180A84210")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0xF91920", Offset = "0xF90320", VA = "0x180F91920")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	public IReadOnlyList<Guid> FHLCICPAOIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0xA84200", Offset = "0xA82C00", VA = "0x180A84200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0xA84190", Offset = "0xA82B90", VA = "0x180A84190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	public HCMJMHBJMFG LIHMMNLKLNF
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x77AB510", Offset = "0x77A9F10", VA = "0x1877AB510")]
		get
		{
			return default(HCMJMHBJMFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x77AB3D0", Offset = "0x77A9DD0", VA = "0x1877AB3D0", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x77AB460", Offset = "0x77A9E60", VA = "0x1877AB460")]
	public bool FMOEJGBHBPC(OHBAEDAMDIP EKKAHCBJBOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x77AB560", Offset = "0x77A9F60", VA = "0x1877AB560")]
	private bool OABOIICLFCP(OHBAEDAMDIP EKKAHCBJBOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x77AB470", Offset = "0x77A9E70", VA = "0x1877AB470")]
	private static bool KLIHABBMPKB(IReadOnlyList<Guid> EDAKEBNFGNG, IReadOnlyList<Guid> NEEJKMGAFKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x2A5E600", Offset = "0x2A5D000", VA = "0x182A5E600", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public OHBAEDAMDIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[GBAJJMJPMAP]
public class HNMBOMMAKGD : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000183")]
	public int KIMCDAPLFNI
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0xA90060", Offset = "0xA8EA60", VA = "0x180A90060")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public HNMBOMMAKGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[GBAJJMJPMAP]
public class CENPPIIBHKI : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000184")]
	public bool HIKBDGGNJEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0xB50B70", Offset = "0xB4F570", VA = "0x180B50B70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0xB50B50", Offset = "0xB4F550", VA = "0x180B50B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public CENPPIIBHKI()
	{
	}
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[GBAJJMJPMAP]
	public class NewInventionRequestDTO : BHOLJOIPLEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public bool hasBetaContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public int instantiationCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public int lightsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public int chipsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public int cloudVariablesCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public int aiCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public byte ugcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public long creationRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public string inventionDataFilename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public List<long> referencedInventions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public IReadOnlyList<Guid> referencedUnityAssetIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public HDAMBOGOJKO creatorAccountRole;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public long? convertedFromInventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public string displayMetadataJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public string longDescription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public ModifyTagsRequest tagsRequest;

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x1046D90", Offset = "0x1045790", VA = "0x181046D90", Slot = "4")]
		public void MCAPBBPIBEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x77AB2A0", Offset = "0x77A9CA0", VA = "0x1877AB2A0")]
		public NewInventionRequestDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[GBAJJMJPMAP]
	public class AddVersionInventionRequestDTO : BHOLJOIPLEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public long inventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public bool hasBetaContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public int instantiationCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int lightsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public int chipsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int cloudVariablesCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public int aiCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public byte ugcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public long creationRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public string inventionDataFilename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public List<long> referencedInventions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public IReadOnlyList<Guid> referencedUnityAssetIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public ModifyTagsRequest tagsRequest;

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x1046D90", Offset = "0x1045790", VA = "0x181046D90", Slot = "4")]
		public void MCAPBBPIBEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x77A1540", Offset = "0x779FF40", VA = "0x1877A1540")]
		public AddVersionInventionRequestDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[GBAJJMJPMAP]
	public class ModifyTagsRequest : BHOLJOIPLEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public List<string> AutoTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public List<string> CustomTags;

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
		public void MCAPBBPIBEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public ModifyTagsRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[GBAJJMJPMAP]
	public class InventionModifyTagsRequest : ModifyTagsRequest
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public long InventionId;

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public InventionModifyTagsRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[GBAJJMJPMAP]
	public class ReportRequest : BHOLJOIPLEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public long InventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public string Details;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public OIMCIAJLMMH ReportCategory;

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
		public void MCAPBBPIBEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public ReportRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[GBAJJMJPMAP]
	public class CheerRequest : BHOLJOIPLEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public long InventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public bool Cheer;

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
		public void MCAPBBPIBEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public CheerRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[GBAJJMJPMAP]
	public class UpdatePriceRequest : BHOLJOIPLEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public long InventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public int Price;

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
		public void MCAPBBPIBEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public UpdatePriceRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[GBAJJMJPMAP]
	public class UpdateInventionMetadataRequest : BHOLJOIPLEN
	{
		[Cpp2IlInjected.Token(Token = "0x17000185")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0xE6CA00", Offset = "0xE6B400", VA = "0x180E6CA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000186")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000187")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000188")]
		public string LongDescription
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000189")]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018A")]
		public ModifyTagsRequest TagsRequest
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0xA88310", Offset = "0xA86D10", VA = "0x180A88310")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x1046D90", Offset = "0x1045790", VA = "0x181046D90", Slot = "4")]
		public void MCAPBBPIBEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public UpdateInventionMetadataRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[GBAJJMJPMAP]
	public class UpdateInventionGeneralPermissionRequest : BHOLJOIPLEN
	{
		[Cpp2IlInjected.Token(Token = "0x1700018B")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0xE6CA00", Offset = "0xE6B400", VA = "0x180E6CA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018C")]
		public LKHDDCCGHNO Permission
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0xA8E5C0", Offset = "0xA8CFC0", VA = "0x180A8E5C0")]
			[CompilerGenerated]
			get
			{
				return default(LKHDDCCGHNO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0xA8E5D0", Offset = "0xA8CFD0", VA = "0x180A8E5D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
		public void MCAPBBPIBEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public UpdateInventionGeneralPermissionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[GBAJJMJPMAP]
	public class PublishInventionRequest : BHOLJOIPLEN
	{
		[Cpp2IlInjected.Token(Token = "0x1700018D")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0xE6CA00", Offset = "0xE6B400", VA = "0x180E6CA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018E")]
		public LKHDDCCGHNO Permission
		{
			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0xA8E5C0", Offset = "0xA8CFC0", VA = "0x180A8E5C0")]
			[CompilerGenerated]
			get
			{
				return default(LKHDDCCGHNO);
			}
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0xA8E5D0", Offset = "0xA8CFD0", VA = "0x180A8E5D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018F")]
		public MNNPGENBKHF Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0xAADF50", Offset = "0xAAC950", VA = "0x180AADF50")]
			[CompilerGenerated]
			get
			{
				return default(MNNPGENBKHF);
			}
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0xEB0C60", Offset = "0xEAF660", VA = "0x180EB0C60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000190")]
		public int? Price
		{
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0xDED820", Offset = "0xDEC220", VA = "0x180DED820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
		public void MCAPBBPIBEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public PublishInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[GBAJJMJPMAP]
	public class UnpublishInventionRequest : BHOLJOIPLEN
	{
		[Cpp2IlInjected.Token(Token = "0x17000191")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(RVA = "0xE6CA00", Offset = "0xE6B400", VA = "0x180E6CA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
		public void MCAPBBPIBEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public UnpublishInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[GBAJJMJPMAP]
	public class DeleteInventionRequest : BHOLJOIPLEN
	{
		[Cpp2IlInjected.Token(Token = "0x17000192")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0xE6CA00", Offset = "0xE6B400", VA = "0x180E6CA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
		public void MCAPBBPIBEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public DeleteInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[GBAJJMJPMAP]
	public class SetInventionVersionAccessibilityRequest : BHOLJOIPLEN
	{
		[Cpp2IlInjected.Token(Token = "0x17000193")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0xE6CA00", Offset = "0xE6B400", VA = "0x180E6CA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000194")]
		public int VersionNumber
		{
			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0xA8E5C0", Offset = "0xA8CFC0", VA = "0x180A8E5C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0xA8E5D0", Offset = "0xA8CFD0", VA = "0x180A8E5D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000195")]
		public MNNPGENBKHF NewAccessibility
		{
			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0xAADF50", Offset = "0xAAC950", VA = "0x180AADF50")]
			[CompilerGenerated]
			get
			{
				return default(MNNPGENBKHF);
			}
			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0xEB0C60", Offset = "0xEAF660", VA = "0x180EB0C60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
		public void MCAPBBPIBEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public SetInventionVersionAccessibilityRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[GBAJJMJPMAP]
	public class SpecialTags : BHOLJOIPLEN
	{
		[Cpp2IlInjected.Token(Token = "0x17000196")]
		public List<string> AutoTags
		{
			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000197")]
		public List<string> AGOnlyTags
		{
			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
		public void MCAPBBPIBEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public SpecialTags()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public enum KIHMBEFPJPD
{
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	InvalidParameters,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	PlayerCannotUpload,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	DuplicateName,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	NameTooShort,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	NameTooLong,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	NotCreator,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	DoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	ImageDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	InventionLimitReached,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	DescriptionTooLong,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	InnapropriateName,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	InappropriateDescription,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	CannotBeModified,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	PlayerCannotPublish,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	AlreadyPublished,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	AlreadyUnpublished,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	InventionUnderModerationReview,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	PlayerCannotDownload,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	PlayerAlreadyOwns,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	DescriptionTooShort,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	DoesNotHavePermission,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	PermissionLevelCannotBeChanged,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	AlreadyCheered,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	AlreadyRemovedCheer,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	ModeratorRestrictedPublishing,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	PlayerCannotSell,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	InvalidPrice,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	PriceCannotBeChanged,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	InvalidPermissionForPaidInvention,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	PurchaseFailed,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	CannotDownloadPaidInvention,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	CannotSellUnownedLineage,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	DoesNotAllowTrial,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	StillOnTrialCooldown,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	PlayerCannotTrial,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	PaidInventionPublishingDisabled,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	PaidInventionPurchasingDisabled,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	OperationIsDisabled,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	PlayerRestrictedFromP2PSelling,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	PlayerNotRecRoomPlusMember,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	InvalidInstantiationCost,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	FeaturedInventionNotPublished,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	FeaturedInventionNotActive,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	InventionContainsBlockedFiles,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	PlayerRestrictedFromP2PBuying,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	ReservedWordRuleViolationInName,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	ReservedWordRuleViolationInDescription,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	InventionContainsBetaContent,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	PlatformDoesntSupportPublishing,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	MismatchedUgcVersions,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	ConvertedFromSameUgcVersion,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	ConvertedFromInventionDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	ConvertedFromInventionHigherVersion,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	PlatformDoesntSupportInvention
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public enum OIMCIAJLMMH
{
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	CoC_Discriminatory,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	CoC_Sexual,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	CoC_Trolling,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	Misleading,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	Other
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public enum ABIAGMMCFHG
{
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	False,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	True,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	Invited
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public interface GGCJJHIBFEG
{
	[Cpp2IlInjected.Token(Token = "0x17000198")]
	NPJJEBGBNDK MCMACGOEKEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	string JJBLOFPKMJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	int DIJMFFFNHIF
	{
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	DateTime ADNAPFIFCLH
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	bool CFHGJLKEBFP
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	string KEEDNMJFEFM
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	IEIPJLIICDB AKPDMIPENPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MCAPBBPIBEB();

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HPCKENPPNID(IEIPJLIICDB HANNCBFICKK);
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public interface LGCCJKLDKCA
{
	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	string HNDFHNMFPMC
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	int NOMMIDHMEJA
	{
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	bool HPFEMBKOFPK
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MCAPBBPIBEB();
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct JDADCCFKFAP
{
	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	public IOAGCCFBLIK KFJEHFLOIKF
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0xD893D0", Offset = "0xD87DD0", VA = "0x180D893D0")]
		[CompilerGenerated]
		readonly get
		{
			return default(IOAGCCFBLIK);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x152BB60", Offset = "0x152A560", VA = "0x18152BB60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	public LGCCJKLDKCA IMFHHMEOAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6D0", Offset = "0xB1C0D0", VA = "0x180B1D6D0")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xEEF710", Offset = "0xEEE110", VA = "0x180EEF710")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	public string NFKAMDLODBB
	{
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x6182130", Offset = "0x6180B30", VA = "0x186182130")]
	public JDADCCFKFAP(IOAGCCFBLIK PIABFOHDCDB, [Optional] LGCCJKLDKCA JHJOONJAKIL, [Optional] string NIKJHLIANND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public enum IOAGCCFBLIK
{
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	ContinueSecurityCode,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	TryAgainSecurityCode,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	RemoteAuthPending
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[GBAJJMJPMAP]
public class CNNNFHGDLNJ : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	public string NBNBLBCGHPC
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	public string CIMKBJKKOHK
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	public string JMCJKDPIPKC
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	public string KDBCEOENMGB
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	public List<AIGMKPDKFHF> OBCMANGNHBO
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public CNNNFHGDLNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x4E90590", Offset = "0x4E8EF90", VA = "0x184E90590")]
	public CNNNFHGDLNJ([Optional] string LCHLAIPKLJN, [Optional] string PNBDEHFPLDN, [Optional] string ODNMJPPNMDL, [Optional] string BOCCINIODIM, [Optional] List<AIGMKPDKFHF> EGGCHBGDFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[GBAJJMJPMAP]
public class AIGMKPDKFHF : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	public string PKMGKCPPNAB
	{
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	public string KDBCEOENMGB
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public AIGMKPDKFHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[GBAJJMJPMAP]
public class MIAIEJINELL : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	public string CIMKBJKKOHK
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	public string KFJEHFLOIKF
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	public string NBNBLBCGHPC
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	public List<string> EFCPPPGINME
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public MIAIEJINELL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[GBAJJMJPMAP]
public interface BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MCAPBBPIBEB();
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[GBAJJMJPMAP]
public interface LOCJLHBEEIF : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task OENOAICBHGF();
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[HHMPFBDOKCG]
public interface GCELMFGJPLP : BHOLJOIPLEN
{
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[GBAJJMJPMAP]
public class JHNMIKJKCEJ : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	public Guid FLMOBMMCAHM
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0xE823D0", Offset = "0xE80DD0", VA = "0x180E823D0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0xE823E0", Offset = "0xE80DE0", VA = "0x180E823E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	public int IALOGONDFCM
	{
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0xAE0120", Offset = "0xADEB20", VA = "0x180AE0120")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xAE0110", Offset = "0xADEB10", VA = "0x180AE0110")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	public string OHOFKLOGAMA
	{
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	public string BMAMKMDIDEB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public JHNMIKJKCEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x77A70B0", Offset = "0x77A5AB0", VA = "0x1877A70B0")]
	public JHNMIKJKCEJ([Optional] Guid DMABDIEKAKJ, int HMKMCCAOOLE = 0, [Optional] string FGJFNEMHHKD, [Optional] string NIMKLOKLMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[GBAJJMJPMAP]
public class JDJOPBCDFGB : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	public const int NKHBPANBLLP = 0;

	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	public long MDBHABELIPB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0xE6CA00", Offset = "0xE6B400", VA = "0x180E6CA00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	public JPMLIKENHKP HKLGHOMGFPA
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	public string OPKCFMMNDFA
	{
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	public List<JHNMIKJKCEJ> CNOOLFNPEAC
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	public int JIMLOJJCIEB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0xA938E0", Offset = "0xA922E0", VA = "0x180A938E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xA93AE0", Offset = "0xA924E0", VA = "0x180A93AE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	public string FAHMGKIDCFD
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0xA88310", Offset = "0xA86D10", VA = "0x180A88310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	public MNNPGENBKHF GJDGGAEABJH
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0xAF1310", Offset = "0xAEFD10", VA = "0x180AF1310")]
		[CompilerGenerated]
		get
		{
			return default(MNNPGENBKHF);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0xAF1670", Offset = "0xAF0070", VA = "0x180AF1670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	public string ODKHNFBAPAK
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0xA88320", Offset = "0xA86D20", VA = "0x180A88320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0xA88300", Offset = "0xA86D00", VA = "0x180A88300")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	public bool CGPIAKGLJCA
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x211F5F0", Offset = "0x211DFF0", VA = "0x18211F5F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x77A6F30", Offset = "0x77A5930", VA = "0x1877A6F30")]
	public JDJOPBCDFGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x77A6E10", Offset = "0x77A5810", VA = "0x1877A6E10")]
	public JDJOPBCDFGB(long LNLBECHOANJ = 0L, [Optional] JPMLIKENHKP OMLBDHHBLMO, [Optional] string GOBBHNBEDDI, [Optional] List<JHNMIKJKCEJ> GMJCDLDBMIP, int DOBBKHLICOG = 0, [Optional] string FLBFBHGDBLM, MNNPGENBKHF HKPCIADPKMN = MNNPGENBKHF.Private, [Optional] string HJHAMEEHPED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public class CAIOEJIMOKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public readonly int DIJMFFFNHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public readonly JDJOPBCDFGB AAGNAGFFPMG;

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x1044F50", Offset = "0x1043950", VA = "0x181044F50")]
	public CAIOEJIMOKM(int LHPHKGMDHKM, JDJOPBCDFGB MGGPIEFFOLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[GBAJJMJPMAP]
public class JPMLIKENHKP : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	public string MLKOKBINCOM
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BE")]
	public string EPOJGFDNPGD
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BF")]
	public string GAHAHOGOHIN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C0")]
	public string ABEPKKJIEEP
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C1")]
	public string OMJFNGPIHGF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C2")]
	public string CNOOLFNPEAC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x77A77B0", Offset = "0x77A61B0", VA = "0x1877A77B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public JPMLIKENHKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x4E90590", Offset = "0x4E8EF90", VA = "0x184E90590")]
	public JPMLIKENHKP([Optional] string PKDOPPCNEFB, [Optional] string HLAGCDLLBLE, [Optional] string FOBJCDABLIA, [Optional] string IEJOMNEKCHG, [Optional] string FLIAOMHODHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[GBAJJMJPMAP]
public class GDEHGBDMLKK : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x170001C3")]
	public Dictionary<int, JDJOPBCDFGB> JPCINLCENKN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public GDEHGBDMLKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[GBAJJMJPMAP]
public class GAILFLMCOCK : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x170001C4")]
	public List<int> LMMDBEOGDOI
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C5")]
	public byte? FGLFCFEPPJN
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x3181350", Offset = "0x317FD50", VA = "0x183181350")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x3181340", Offset = "0x317FD40", VA = "0x183181340")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C6")]
	public int? DNKMICNJPFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x136E650", Offset = "0x136D050", VA = "0x18136E650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x136E680", Offset = "0x136D080", VA = "0x18136E680")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public GAILFLMCOCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class KCAPBNOECFE
{
	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x77A77E0", Offset = "0x77A61E0", VA = "0x1877A77E0")]
	public static PEIDCEBGHBD KELAMBLGLID(this JHNMIKJKCEJ NLDLHIJAJBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[Flags]
public enum KNEJLBPHMMH
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	Steam = 1,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	Oculus = 2,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	PlayStation = 4,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	Xbox = 8,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	RecNet = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	IOS = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	GooglePlay = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	Standalone = 0x80,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	Pico = 0x100,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	Switch = 0x200,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	All = -1
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public enum NPJJEBGBNDK
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	All = -1,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	Steam,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	Oculus,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	PlayStation,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	Xbox,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	RecNet,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	IOS,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	GooglePlay,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	Standalone,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	Pico,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	Switch
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[GBAJJMJPMAP]
public class GEFOGGGMFCO : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x170001C7")]
	[DataMember(Name = "PlayerId")]
	public int DIJMFFFNHIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0xA90060", Offset = "0xA8EA60", VA = "0x180A90060")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C8")]
	public int HKEIHDLAOHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0xAD35E0", Offset = "0xAD1FE0", VA = "0x180AD35E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0xB68BB0", Offset = "0xB675B0", VA = "0x180B68BB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C9")]
	public int ALGFHHKPDCA
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5C0", Offset = "0xA8CFC0", VA = "0x180A8E5C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5D0", Offset = "0xA8CFD0", VA = "0x180A8E5D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public GEFOGGGMFCO()
	{
	}
}
namespace RecNet
{
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[GBAJJMJPMAP]
	public class ProgressionEventRecordDTO : BHOLJOIPLEN
	{
		[Cpp2IlInjected.Token(Token = "0x170001CA")]
		public int DIJMFFFNHIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0xA90060", Offset = "0xA8EA60", VA = "0x180A90060")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CB")]
		public int JPJNOCOEPOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0xAD35E0", Offset = "0xAD1FE0", VA = "0x180AD35E0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0xB68BB0", Offset = "0xB675B0", VA = "0x180B68BB0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CC")]
		public int LIPBLFIKMGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0xA8E5C0", Offset = "0xA8CFC0", VA = "0x180A8E5C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0xA8E5D0", Offset = "0xA8CFD0", VA = "0x180A8E5D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CD")]
		public int BIIKHOFIILH
		{
			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0xAADF50", Offset = "0xAAC950", VA = "0x180AADF50")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0xEB0C60", Offset = "0xEAF660", VA = "0x180EB0C60")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CE")]
		public int PBHJEJPLHKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0xAE0120", Offset = "0xADEB20", VA = "0x180AE0120")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0xAE0110", Offset = "0xADEB10", VA = "0x180AE0110")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CF")]
		public DateTime? FJGLPCBKCFD
		{
			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0x13D5B70", Offset = "0x13D4570", VA = "0x1813D5B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600041B")]
			[Cpp2IlInjected.Address(RVA = "0x1514FE0", Offset = "0x15139E0", VA = "0x181514FE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D0")]
		public int LGCBLEHHPFA
		{
			[Cpp2IlInjected.Token(Token = "0x600041C")]
			[Cpp2IlInjected.Address(RVA = "0xAA3B30", Offset = "0xAA2530", VA = "0x180AA3B30")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600041D")]
			[Cpp2IlInjected.Address(RVA = "0xEAC2E0", Offset = "0xEAACE0", VA = "0x180EAC2E0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public ProgressionEventRecordDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x77AC8D0", Offset = "0x77AB2D0", VA = "0x1877AC8D0")]
		public ProgressionEventRecordDTO(int LHPHKGMDHKM = 0, int MJPLLOPDNFC = 0, int DIKNGKDFKMB = 0, int MGNEENGLLOL = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
		public void MCAPBBPIBEB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[GBAJJMJPMAP]
	public class ProgressionEventDTO : BHOLJOIPLEN
	{
		[Cpp2IlInjected.Token(Token = "0x170001D1")]
		public long MJJFHEHEHCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0xE6CA00", Offset = "0xE6B400", VA = "0x180E6CA00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D2")]
		public string FAHMGKIDCFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D3")]
		public List<ProgressionEventRewardDTO> BNNGKNOAPGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D4")]
		public List<KeepsakeRoomListDTO> MNIHAEACAKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		public DateTime EOPLKEHOFOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0xA882E0", Offset = "0xA86CE0", VA = "0x180A882E0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D6")]
		public DateTime FMBEOALCKLK
		{
			[Cpp2IlInjected.Token(Token = "0x600042B")]
			[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600042C")]
			[Cpp2IlInjected.Address(RVA = "0xA938F0", Offset = "0xA922F0", VA = "0x180A938F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D7")]
		public DateTime GHOOEADHGCG
		{
			[Cpp2IlInjected.Token(Token = "0x600042D")]
			[Cpp2IlInjected.Address(RVA = "0xA91C70", Offset = "0xA90670", VA = "0x180A91C70")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600042E")]
			[Cpp2IlInjected.Address(RVA = "0xF91930", Offset = "0xF90330", VA = "0x180F91930")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D8")]
		public bool CHFFPBLPFBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0xD49710", Offset = "0xD48110", VA = "0x180D49710")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0xD706F0", Offset = "0xD6F0F0", VA = "0x180D706F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D9")]
		public int KLDKBKMDIHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0x146B9E0", Offset = "0x146A3E0", VA = "0x18146B9E0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000432")]
			[Cpp2IlInjected.Address(RVA = "0x22BB5A0", Offset = "0x22B9FA0", VA = "0x1822BB5A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DA")]
		public float DGHCPJALPLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000433")]
			[Cpp2IlInjected.Address(RVA = "0x125C1F0", Offset = "0x125ABF0", VA = "0x18125C1F0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0x15CBD10", Offset = "0x15CA710", VA = "0x1815CBD10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DB")]
		public Guid? HAJLDOKJNHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0x77AC800", Offset = "0x77AB200", VA = "0x1877AC800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000436")]
			[Cpp2IlInjected.Address(RVA = "0x77AC7F0", Offset = "0x77AB1F0", VA = "0x1877AC7F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DC")]
		public string PPFDBJOPDCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000437")]
			[Cpp2IlInjected.Address(RVA = "0xA841B0", Offset = "0xA82BB0", VA = "0x180A841B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0xA841A0", Offset = "0xA82BA0", VA = "0x180A841A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DD")]
		public string PFCDNMJACFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000439")]
			[Cpp2IlInjected.Address(RVA = "0xA841F0", Offset = "0xA82BF0", VA = "0x180A841F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600043A")]
			[Cpp2IlInjected.Address(RVA = "0xA841D0", Offset = "0xA82BD0", VA = "0x180A841D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DE")]
		public string AFMEOLKCDNP
		{
			[Cpp2IlInjected.Token(Token = "0x600043B")]
			[Cpp2IlInjected.Address(RVA = "0xA90910", Offset = "0xA8F310", VA = "0x180A90910")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600043C")]
			[Cpp2IlInjected.Address(RVA = "0xA909B0", Offset = "0xA8F3B0", VA = "0x180A909B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DF")]
		public string PPAGGFACEBG
		{
			[Cpp2IlInjected.Token(Token = "0x600043D")]
			[Cpp2IlInjected.Address(RVA = "0xA909E0", Offset = "0xA8F3E0", VA = "0x180A909E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0xA909C0", Offset = "0xA8F3C0", VA = "0x180A909C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public ProgressionEventDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x77AC820", Offset = "0x77AB220", VA = "0x1877AC820")]
		public ProgressionEventDTO(long MJEOOKBAILL = 0L, [Optional] string FLBFBHGDBLM, [Optional] List<ProgressionEventRewardDTO> OLLHADACDKK, [Optional] List<KeepsakeRoomListDTO> AJNOEGNCEDO, [Optional] DateTime ABGKAAONMGB, [Optional] DateTime OMOENDBOKPL, [Optional] DateTime ELKAPDIPONJ, bool MGGGFPOPAMJ = false, int FHLMDNNDFGL = 0, float LAKKICLNGML = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
		public void MCAPBBPIBEB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[GBAJJMJPMAP]
	public class KeepsakeRoomListDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170001E0")]
		public long HMFFFNONLHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000442")]
			[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000443")]
			[Cpp2IlInjected.Address(RVA = "0xE6CA00", Offset = "0xE6B400", VA = "0x180E6CA00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E1")]
		public long MJJFHEHEHCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000444")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000445")]
			[Cpp2IlInjected.Address(RVA = "0xDD00C0", Offset = "0xDCEAC0", VA = "0x180DD00C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E2")]
		public int? NLBBDAEICOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000446")]
			[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000447")]
			[Cpp2IlInjected.Address(RVA = "0xDED820", Offset = "0xDEC220", VA = "0x180DED820")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E3")]
		public int? PFOPEKJCADF
		{
			[Cpp2IlInjected.Token(Token = "0x6000448")]
			[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000449")]
			[Cpp2IlInjected.Address(RVA = "0xA882F0", Offset = "0xA86CF0", VA = "0x180A882F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		public long? ELDGCOFGAGK
		{
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0xF371D0", Offset = "0xF35BD0", VA = "0x180F371D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600044B")]
			[Cpp2IlInjected.Address(RVA = "0xF36610", Offset = "0xF35010", VA = "0x180F36610")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E5")]
		public long PACMKGJMKPD
		{
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0xA91C70", Offset = "0xA90670", VA = "0x180A91C70")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0xF91930", Offset = "0xF90330", VA = "0x180F91930")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E6")]
		public TimeSpan LHIEAEIKHJG
		{
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0x77A87B0", Offset = "0x77A71B0", VA = "0x1877A87B0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E7")]
		public long LOACHGHCDIA
		{
			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0xA88320", Offset = "0xA86D20", VA = "0x180A88320")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x13AB4E0", Offset = "0x13A9EE0", VA = "0x1813AB4E0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E8")]
		public TimeSpan OMFINGEHLME
		{
			[Cpp2IlInjected.Token(Token = "0x6000451")]
			[Cpp2IlInjected.Address(RVA = "0x77A8760", Offset = "0x77A7160", VA = "0x1877A8760")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E9")]
		public int DKDFCNKLNHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0xE86AA0", Offset = "0xE854A0", VA = "0x180E86AA0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0xFCA860", Offset = "0xFC9260", VA = "0x180FCA860")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EA")]
		public OOPMLGAEEJE HKDDNAJPKOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0x12936F0", Offset = "0x12920F0", VA = "0x1812936F0")]
			[CompilerGenerated]
			get
			{
				return default(OOPMLGAEEJE);
			}
			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0x2495DC0", Offset = "0x24947C0", VA = "0x182495DC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EB")]
		public List<KeepsakeRoomDTO> DCEHOCONAJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0xA84200", Offset = "0xA82C00", VA = "0x180A84200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0xA84190", Offset = "0xA82B90", VA = "0x180A84190")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public KeepsakeRoomListDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x77A8800", Offset = "0x77A7200", VA = "0x1877A8800")]
		public KeepsakeRoomListDTO(long FHHIGOKBOFO = 0L, long MJEOOKBAILL = 0L, [Optional] int? PBPEMKDLNDJ, [Optional] int? IJJCAJOKGIL, [Optional] long? DPEFNPJMGNJ, long NKACLKALAAN = 0L, long EFIIPHGIAMH = 0L, int KAMOECEDLJB = 0, OOPMLGAEEJE BGPPHCKHDGB = OOPMLGAEEJE.Standard, [Optional] List<KeepsakeRoomDTO> IMMPPLFIDLL)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[GBAJJMJPMAP]
	public class KeepsakeRoomDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170001EC")]
		public long HPBDHHBBGGA
		{
			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600045B")]
			[Cpp2IlInjected.Address(RVA = "0xE6CA00", Offset = "0xE6B400", VA = "0x180E6CA00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001ED")]
		public long EDCJBBOOIBH
		{
			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0xDD00C0", Offset = "0xDCEAC0", VA = "0x180DD00C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EE")]
		public long HMFFFNONLHL
		{
			[Cpp2IlInjected.Token(Token = "0x600045E")]
			[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600045F")]
			[Cpp2IlInjected.Address(RVA = "0xDED820", Offset = "0xDEC220", VA = "0x180DED820")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EF")]
		public OOPMLGAEEJE MMPEDFAPIKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000460")]
			[Cpp2IlInjected.Address(RVA = "0xA8E5B0", Offset = "0xA8CFB0", VA = "0x180A8E5B0")]
			[CompilerGenerated]
			get
			{
				return default(OOPMLGAEEJE);
			}
			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0xA8E5E0", Offset = "0xA8CFE0", VA = "0x180A8E5E0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F0")]
		public int LBOOGLOMMME
		{
			[Cpp2IlInjected.Token(Token = "0x6000462")]
			[Cpp2IlInjected.Address(RVA = "0xAD60D0", Offset = "0xAD4AD0", VA = "0x180AD60D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000463")]
			[Cpp2IlInjected.Address(RVA = "0x1644B20", Offset = "0x1643520", VA = "0x181644B20")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public KeepsakeRoomDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x77A8700", Offset = "0x77A7100", VA = "0x1877A8700")]
		public KeepsakeRoomDTO(long DBPDANPJFOB = 0L, long DKMPIOFKFMN = 0L, long FHHIGOKBOFO = 0L, OOPMLGAEEJE AEOGKDPPBBE = OOPMLGAEEJE.Standard, int BDAHFNCBGML = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[GBAJJMJPMAP]
	public class ProgressionEventRewardDTO : BHOLJOIPLEN
	{
		[Cpp2IlInjected.Token(Token = "0x170001F1")]
		public long DMKPNEBJNFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000464")]
			[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000465")]
			[Cpp2IlInjected.Address(RVA = "0xE6CA00", Offset = "0xE6B400", VA = "0x180E6CA00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F2")]
		public int BFBMDJPIOCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0xA8E5C0", Offset = "0xA8CFC0", VA = "0x180A8E5C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000467")]
			[Cpp2IlInjected.Address(RVA = "0xA8E5D0", Offset = "0xA8CFD0", VA = "0x180A8E5D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F3")]
		public string HHBAAHCOJDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000468")]
			[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000469")]
			[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F4")]
		public int JPJNOCOEPOP
		{
			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0xA8E5B0", Offset = "0xA8CFB0", VA = "0x180A8E5B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0xA8E5E0", Offset = "0xA8CFE0", VA = "0x180A8E5E0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F5")]
		public int LEBOKEBAHOC
		{
			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0xAD60D0", Offset = "0xAD4AD0", VA = "0x180AD60D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0x1644B20", Offset = "0x1643520", VA = "0x181644B20")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F6")]
		public bool NMDMHJLANPA
		{
			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0xAB3420", Offset = "0xAB1E20", VA = "0x180AB3420")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0xAB31A0", Offset = "0xAB1BA0", VA = "0x180AB31A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F7")]
		public bool CMGIOFMPCAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000470")]
			[Cpp2IlInjected.Address(RVA = "0xF26B10", Offset = "0xF25510", VA = "0x180F26B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000471")]
			[Cpp2IlInjected.Address(RVA = "0x157F750", Offset = "0x157E150", VA = "0x18157F750")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
		public void MCAPBBPIBEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public ProgressionEventRewardDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[GBAJJMJPMAP]
	public class ProgressionEventPurchasableXpBoostDTO : BHOLJOIPLEN
	{
		[Cpp2IlInjected.Token(Token = "0x170001F8")]
		public Guid EOEDMAOGFPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0xE823D0", Offset = "0xE80DD0", VA = "0x180E823D0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0xE823E0", Offset = "0xE80DE0", VA = "0x180E823E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F9")]
		public int NLOLLHGOPGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0xAE0120", Offset = "0xADEB20", VA = "0x180AE0120")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0xAE0110", Offset = "0xADEB10", VA = "0x180AE0110")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FA")]
		public int KMPNLNDKPNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0xC33060", Offset = "0xC31A60", VA = "0x180C33060")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000479")]
			[Cpp2IlInjected.Address(RVA = "0x1058A60", Offset = "0x1057460", VA = "0x181058A60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FB")]
		public int CKADIBFJOKG
		{
			[Cpp2IlInjected.Token(Token = "0x600047A")]
			[Cpp2IlInjected.Address(RVA = "0xA8E5B0", Offset = "0xA8CFB0", VA = "0x180A8E5B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600047B")]
			[Cpp2IlInjected.Address(RVA = "0xA8E5E0", Offset = "0xA8CFE0", VA = "0x180A8E5E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FC")]
		public long BPEPIFDPGCH
		{
			[Cpp2IlInjected.Token(Token = "0x600047C")]
			[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600047D")]
			[Cpp2IlInjected.Address(RVA = "0xA882E0", Offset = "0xA86CE0", VA = "0x180A882E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FD")]
		public long PIMCJNFDJHC
		{
			[Cpp2IlInjected.Token(Token = "0x600047E")]
			[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600047F")]
			[Cpp2IlInjected.Address(RVA = "0xA938F0", Offset = "0xA922F0", VA = "0x180A938F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
		public void MCAPBBPIBEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public ProgressionEventPurchasableXpBoostDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public enum OOPMLGAEEJE
{
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	Premium
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public enum KCEPIFFHDBI
{
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	Explore = 0,
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	GreenPowerCore = 1,
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	Present = 2,
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	PurplePowerCore = 3,
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	UnnamedKeepsakeNumber1 = 4,
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	UnnamedKeepsakeNumber2 = 5,
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	UnnamedKeepsakeNumber3 = 6,
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	UnnamedKeepsakeNumber4 = 7,
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	UnnamedKeepsakeNumber5 = 8,
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	_Test = 1000
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[GBAJJMJPMAP]
public class OGMDLPOJNPO : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x170001FE")]
	public string ILJJIFMFDNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001FF")]
	public string? MDHMAPKBLOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public OGMDLPOJNPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public interface GBAJHOFECNH
{
	[Cpp2IlInjected.Token(Token = "0x17000200")]
	bool INJIMBANEAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000201")]
	string? JOBPHHGKKFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000202")]
	string? FNLDFPFFJFM
	{
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public interface OCPNILEDNLO<T> : GBAJHOFECNH
{
	[Cpp2IlInjected.Token(Token = "0x17000203")]
	T BHKLFFIKDPE
	{
		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class EFPHFAEFONC
{
	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x3AE00C0", Offset = "0x3ADEAC0", VA = "0x183AE00C0")]
	public static OCPNILEDNLO<T> AMPAFLPNFEK<T, U>(this OCPNILEDNLO<U> AEAMJGPOBKI, Func<U, T> OPEANBDKOGJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public struct FIANFCMEJIH<T> : OCPNILEDNLO<T>, GBAJHOFECNH
{
	[Cpp2IlInjected.Token(Token = "0x17000204")]
	public bool INJIMBANEAK
	{
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x10830E0", Offset = "0x1081AE0", VA = "0x1810830E0", Slot = "5")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x2CC8EC0", Offset = "0x2CC78C0", VA = "0x182CC8EC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000205")]
	public string? JOBPHHGKKFH
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6D0", Offset = "0xB1C0D0", VA = "0x180B1D6D0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0xEEF710", Offset = "0xEEE110", VA = "0x180EEF710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000206")]
	public string? FNLDFPFFJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490", Slot = "7")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000207")]
	public T BHKLFFIKDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x4E0BED0", Offset = "0x4E0A8D0", VA = "0x184E0BED0")]
	public static FIANFCMEJIH<T> MNNJGGODCAN(T PDKJBMPOMNC)
	{
		return default(FIANFCMEJIH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x4E0BE10", Offset = "0x4E0A810", VA = "0x184E0BE10")]
	public static FIANFCMEJIH<T> JJIBBCAPNOP(string GFHOJCCMEDK, string MKNHCEMANLO = "")
	{
		return default(FIANFCMEJIH<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[GBAJJMJPMAP]
public class OONMGGAOEHG : GBAJHOFECNH, BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000208")]
	public bool INJIMBANEAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0xB50B70", Offset = "0xB4F570", VA = "0x180B50B70", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0xB50B50", Offset = "0xB4F550", VA = "0x180B50B50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000209")]
	public string? JOBPHHGKKFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700020A")]
	[DataMember(Name = "error_id")]
	public string? FNLDFPFFJFM
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "8")]
	public virtual void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x77ABB30", Offset = "0x77AA530", VA = "0x1877ABB30")]
	public static OONMGGAOEHG MNNJGGODCAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x77ABAA0", Offset = "0x77AA4A0", VA = "0x1877ABAA0")]
	public static OONMGGAOEHG JJIBBCAPNOP(string GFHOJCCMEDK, string MKNHCEMANLO = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public OONMGGAOEHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[CGOGLCNAGNJ]
public abstract class PCJOEEHNGHJ<T> : OONMGGAOEHG, OCPNILEDNLO<T>, GBAJHOFECNH
{
	[Cpp2IlInjected.Token(Token = "0x1700020B")]
	public T BHKLFFIKDPE
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0xC33050", Offset = "0xC31A50", VA = "0x180C33050", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0xBDAFA0", Offset = "0xBD99A0", VA = "0x180BDAFA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
	protected PCJOEEHNGHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[CGOGLCNAGNJ]
public class EBOCGOPLNHG<T> : PCJOEEHNGHJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x4917A50", Offset = "0x4916450", VA = "0x184917A50")]
	private static void FGFAMNDBGAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x48D4670", Offset = "0x48D3070", VA = "0x1848D4670")]
	public EBOCGOPLNHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[CGOGLCNAGNJ]
public class AMBDMJNECED<T> : PCJOEEHNGHJ<T>, LOCJLHBEEIF, BHOLJOIPLEN where T : BHOLJOIPLEN, new()
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct CKANKILKCFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public AMBDMJNECED<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x6A47EE0", Offset = "0x6A468E0", VA = "0x186A47EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x6A48150", Offset = "0x6A46B50", VA = "0x186A48150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x5316A90", Offset = "0x5315490", VA = "0x185316A90", Slot = "8")]
	public override void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x5316C60", Offset = "0x5315660", VA = "0x185316C60", Slot = "10")]
	[AsyncStateMachine(typeof(AMBDMJNECED<>.CKANKILKCFK))]
	public Task OENOAICBHGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x5316B20", Offset = "0x5315520", VA = "0x185316B20")]
	public static AMBDMJNECED<T> MNNJGGODCAN(T PDKJBMPOMNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x5316940", Offset = "0x5315340", VA = "0x185316940")]
	public new static AMBDMJNECED<T> JJIBBCAPNOP(string GFHOJCCMEDK, string MKNHCEMANLO = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x48FDC10", Offset = "0x48FC610", VA = "0x1848FDC10")]
	public AMBDMJNECED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[CGOGLCNAGNJ]
public class GHMFMPMGANP<T> : PCJOEEHNGHJ<List<T>>
{
	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x48D4670", Offset = "0x48D3070", VA = "0x1848D4670")]
	public GHMFMPMGANP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[CGOGLCNAGNJ]
public class IGMBBFEHOCO<T> : PCJOEEHNGHJ<List<T>>, LOCJLHBEEIF, BHOLJOIPLEN where T : BHOLJOIPLEN, new()
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct PBDCDMFFHME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public IGMBBFEHOCO<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x5AEE4B0", Offset = "0x5AECEB0", VA = "0x185AEE4B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x5AEE6B0", Offset = "0x5AED0B0", VA = "0x185AEE6B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x514AE10", Offset = "0x5149810", VA = "0x18514AE10")]
	public static IGMBBFEHOCO<T> MNNJGGODCAN(List<T> PDKJBMPOMNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x514AA60", Offset = "0x5149460", VA = "0x18514AA60")]
	public new static IGMBBFEHOCO<T> JJIBBCAPNOP(string GFHOJCCMEDK, string MKNHCEMANLO = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x514ABB0", Offset = "0x51495B0", VA = "0x18514ABB0", Slot = "8")]
	public override void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x514AF40", Offset = "0x5149940", VA = "0x18514AF40", Slot = "10")]
	[AsyncStateMachine(typeof(IGMBBFEHOCO<>.PBDCDMFFHME))]
	public Task OENOAICBHGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x514B010", Offset = "0x5149A10", VA = "0x18514B010")]
	public IGMBBFEHOCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public enum PEKPGJGOILC
{
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	AI,
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	Auth,
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	API,
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	Commerce,
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	Matchmaking,
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	Notifications,
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	Images,
	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	CDN,
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	Storage,
	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	Chat,
	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	Leaderboard,
	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	Accounts,
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	Link,
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	Lists,
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	RoomComments,
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	Clubs,
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	Rooms,
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	PlatformNotifications,
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	Moderation,
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	DataCollection,
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	BugReporting,
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	Discovery,
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	PlayerSettings,
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	Studio,
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	GameLogs,
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	Strings,
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	StringsCDN,
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	WWW,
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	Econ,
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	Data,
	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	Cards
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public static class LHOBBMBFLHP
{
	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x77A9B30", Offset = "0x77A8530", VA = "0x1877A9B30")]
	public static bool NAKEHMDBDGG(this PEKPGJGOILC LMPCECBHOAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x77A9B30", Offset = "0x77A8530", VA = "0x1877A9B30")]
	public static bool INIOLJICOKB(this PEKPGJGOILC LMPCECBHOAI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public enum OICCDKGHIEL
{
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	Invalid = 0,
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	LaserTagTickets = 1,
	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	RecCenterTokens = 2,
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	LostSkullsGold = 100,
	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	DraculaSilver = 101,
	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	RecRoyale_Season1 = 200,
	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	RoomCurrency = 300,
	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	RoomInventoryItem = 301,
	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	ProgressionEvent = 400,
	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	RoomieCredits = 500
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public enum NKILPDNDKBO
{
	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	NonPurchasedNotUsableInP2P = -2,
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	NonPurchasedDefault = -1,
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	SteamPurchased = 0,
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	OculusPurchased = 1,
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	PlayStationPurchased = 2,
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	MicrosoftPurchased = 3,
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	IOSPurchased = 5,
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	GooglePlayPurchased = 6,
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	PicoPurchased = 8,
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	RecNetPurchased = 4,
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	SwitchPurchased = 9,
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	[Obsolete("Subscription benefits for PS4 players were awarded with this balance type. It is not transferrable to other platforms. Usable in P2P economy. We are using PlayStationPurchased instead now. -- bilal - 11/11/2020")]
	PlayStationNonPurchasedP2P = 100,
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	[Obsolete("Subscription benefits for NON PS4 players were awarded with this balance type. We are using <PlatformType>Purchased instead now. -- bilal - 11/11/2020")]
	NonPlayStationNonPurchasedP2P = 101,
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	NonPurchasedEarnedByP2P = 1000,
	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	NonPurchasedEarnedByP2Pv2 = 1001,
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	RoomieEnergyPack = 1101
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public enum APJEKMFCMFG
{
	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	First_Activity = 1,
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	Game_Drop = 2,
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	All_Daily_Challenges_Complete = 3,
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	All_Weekly_Challenge_Complete = 4,
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	Daily_Challenge_Complete = 5,
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	Weekly_Challenge_Complete = 6,
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	Unassigned_Equipment = 10,
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	Unassigned_Avatar = 11,
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	Unassigned_Consumable = 12,
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	Reacquisition = 20,
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	Membership = 21,
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	NUX_TokensAndDressUp = 30,
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	NUX_Experiment1 = 31,
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	NUX_Experiment2 = 32,
	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	NUX_Experiment3 = 33,
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	NUX_Experiment4 = 34,
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	NUX_Experiment5 = 35,
	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	GameRewards = 50,
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	GameRewards_Tokens = 51,
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	GameRewards_Tokens_Experiment_Override = 52,
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	GameRewards_A = 53,
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	GameRewards_B = 54,
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	LevelUp = 100,
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	Purchased_Gift_A = 500,
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	Purchased_Gift_B = 501,
	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	Purchased_Gift_C = 502,
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	Purchased_Gift_D = 503,
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	Holiday = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	Contest = 1001,
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	Promotion = 1002,
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	LimitedTime = 1003,
	[Cpp2IlInjected.Token(Token = "0x4000303")]
	LimitedTimeEvent = 1004,
	[Cpp2IlInjected.Token(Token = "0x4000304")]
	Deprecated = 1100,
	[Cpp2IlInjected.Token(Token = "0x4000305")]
	RecRoyale = 1200,
	[Cpp2IlInjected.Token(Token = "0x4000306")]
	Friendotron_Gift = 1300,
	[Cpp2IlInjected.Token(Token = "0x4000307")]
	DEPRECATED_Paintball_ClearCut = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000308")]
	DEPRECATED_Paintball_Homestead = 2001,
	[Cpp2IlInjected.Token(Token = "0x4000309")]
	DEPRECATED_Paintball_Quarry = 2002,
	[Cpp2IlInjected.Token(Token = "0x400030A")]
	DEPRECATED_Paintball_River = 2003,
	[Cpp2IlInjected.Token(Token = "0x400030B")]
	DEPRECATED_Paintball_Dam = 2004,
	[Cpp2IlInjected.Token(Token = "0x400030C")]
	DEPRECATED_Paintball_DriveIn = 2005,
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	Paintball_ClearCut = 2010,
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	Paintball_Homestead = 2011,
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	Paintball_Quarry = 2012,
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	Paintball_River = 2013,
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	Paintball_Dam = 2014,
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	Paintball_DriveIn = 2015,
	[Cpp2IlInjected.Token(Token = "0x4000313")]
	DEPRECATED_Discgolf_Propulsion = 3000,
	[Cpp2IlInjected.Token(Token = "0x4000314")]
	DEPRECATED_Discgolf_Lake = 3001,
	[Cpp2IlInjected.Token(Token = "0x4000315")]
	Discgolf_Propulsion = 3010,
	[Cpp2IlInjected.Token(Token = "0x4000316")]
	Discgolf_Lake = 3011,
	[Cpp2IlInjected.Token(Token = "0x4000317")]
	Discgolf_Mode_CoopCatch = 3500,
	[Cpp2IlInjected.Token(Token = "0x4000318")]
	Quest_Goblin_A = 4000,
	[Cpp2IlInjected.Token(Token = "0x4000319")]
	Quest_Goblin_B = 4001,
	[Cpp2IlInjected.Token(Token = "0x400031A")]
	Quest_Goblin_C = 4002,
	[Cpp2IlInjected.Token(Token = "0x400031B")]
	Quest_Goblin_S = 4003,
	[Cpp2IlInjected.Token(Token = "0x400031C")]
	Quest_Goblin_Consumable = 4004,
	[Cpp2IlInjected.Token(Token = "0x400031D")]
	Quest_Cauldron_A = 4010,
	[Cpp2IlInjected.Token(Token = "0x400031E")]
	Quest_Cauldron_B = 4011,
	[Cpp2IlInjected.Token(Token = "0x400031F")]
	Quest_Cauldron_C = 4012,
	[Cpp2IlInjected.Token(Token = "0x4000320")]
	Quest_Cauldron_S = 4013,
	[Cpp2IlInjected.Token(Token = "0x4000321")]
	Quest_Cauldron_Consumable = 4014,
	[Cpp2IlInjected.Token(Token = "0x4000322")]
	Quest_Pirate1_A = 4100,
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	Quest_Pirate1_B = 4101,
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	Quest_Pirate1_C = 4102,
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	Quest_Pirate1_S = 4103,
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	Quest_Pirate1_X = 4104,
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	Quest_Pirate1_Consumable = 4105,
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	Quest_Dracula1_A = 4200,
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	Quest_Dracula1_B = 4201,
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	Quest_Dracula1_C = 4202,
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	Quest_Dracula1_S = 4203,
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	Quest_Dracula1_X = 4204,
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	Quest_Dracula1_Consumable = 4205,
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	Quest_Dracula1_SS = 4206,
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	Quest_SciFi_A = 4500,
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	Quest_SciFi_B = 4501,
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	Quest_SciFi_C = 4502,
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	Quest_SciFi_S = 4503,
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	Quest_Scifi_Consumable = 4504,
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	DEPRECATED_Charades = 5000,
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	Charades = 5001,
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	DEPRECATED_Soccer = 6000,
	[Cpp2IlInjected.Token(Token = "0x4000337")]
	Soccer = 6001,
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	DEPRECATED_Paddleball = 7000,
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	Paddleball = 7001,
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	DEPRECATED_Dodgeball = 8000,
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	Dodgeball = 8001,
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	DEPRECATED_Lasertag = 9000,
	[Cpp2IlInjected.Token(Token = "0x400033D")]
	Lasertag = 9001,
	[Cpp2IlInjected.Token(Token = "0x400033E")]
	DEPRECATED_Bowling = 10000,
	[Cpp2IlInjected.Token(Token = "0x400033F")]
	Bowling = 10001,
	[Cpp2IlInjected.Token(Token = "0x4000340")]
	StuntRunner_TheMainEvent_A = 11000,
	[Cpp2IlInjected.Token(Token = "0x4000341")]
	StuntRunner_TheMainEvent_B = 11001,
	[Cpp2IlInjected.Token(Token = "0x4000342")]
	StuntRunner_TheMainEvent_C = 11002,
	[Cpp2IlInjected.Token(Token = "0x4000343")]
	StuntRunner_TheMainEvent_D = 11003,
	[Cpp2IlInjected.Token(Token = "0x4000344")]
	StuntRunner_TheMainEvent_S = 11004,
	[Cpp2IlInjected.Token(Token = "0x4000345")]
	StuntRunner_TheMainEvent_X = 11005,
	[Cpp2IlInjected.Token(Token = "0x4000346")]
	StuntRunner_TheMainEvent_Consumable = 11006,
	[Cpp2IlInjected.Token(Token = "0x4000347")]
	StuntRunner_TheMainEvent_SS = 11007,
	[Cpp2IlInjected.Token(Token = "0x4000348")]
	RecRally = 12000,
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	Showdown_A = 12100,
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	Showdown_B = 12101,
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	Showdown_C = 12102,
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	MyLittleMonsters = 12200,
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	RunTheBlock = 12300,
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	RROStorefront_ToBeNamed_2 = 12400,
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	ProgressionEvent = 13000,
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	Store_LaserTag = 100000,
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	Store_RecCenter = 100010,
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	Consumable = 110000,
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	Token = 110100,
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	Punchcard_Challenge_Complete = 110200,
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	All_Punchcard_Challenges_Complete = 110201,
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	New_Player_Checklist_Item_Complete = 110300,
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	Commerce_Purchase = 200000,
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	Gift_Card_Redemption = 210000
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public enum HLLCBMIFJOL
{
	[Cpp2IlInjected.Token(Token = "0x400035A")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	Common = 0,
	[Cpp2IlInjected.Token(Token = "0x400035C")]
	Uncommon = 10,
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	Rare = 20,
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	Epic = 30,
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	Legendary = 50
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public enum LCNOABNNKJA
{
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	OK,
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	TooManyRequests,
	[Cpp2IlInjected.Token(Token = "0x4000363")]
	NotEnoughCredit,
	[Cpp2IlInjected.Token(Token = "0x4000364")]
	AlreadyOwned,
	[Cpp2IlInjected.Token(Token = "0x4000365")]
	NoItemAvailable,
	[Cpp2IlInjected.Token(Token = "0x4000366")]
	CouponNotApplicable,
	[Cpp2IlInjected.Token(Token = "0x4000367")]
	RequestedPriceDoesNotMatch,
	[Cpp2IlInjected.Token(Token = "0x4000368")]
	RequestedAmountNotAllowed,
	[Cpp2IlInjected.Token(Token = "0x4000369")]
	PlayerNotEligible,
	[Cpp2IlInjected.Token(Token = "0x400036A")]
	RequestCannotBeRefunded,
	[Cpp2IlInjected.Token(Token = "0x400036B")]
	PlayerNotApproved
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[GBAJJMJPMAP]
	public class BalanceResponseDTO : BHOLJOIPLEN
	{
		[Cpp2IlInjected.Token(Token = "0x1700020C")]
		public long Balance
		{
			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0xE6CA00", Offset = "0xE6B400", VA = "0x180E6CA00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020D")]
		public OICCDKGHIEL CurrencyType
		{
			[Cpp2IlInjected.Token(Token = "0x60004B9")]
			[Cpp2IlInjected.Address(RVA = "0xA8E5C0", Offset = "0xA8CFC0", VA = "0x180A8E5C0")]
			[CompilerGenerated]
			get
			{
				return default(OICCDKGHIEL);
			}
			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0xA8E5D0", Offset = "0xA8CFD0", VA = "0x180A8E5D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020E")]
		[DataMember(Name = "Platform")]
		public NKILPDNDKBO BalanceType
		{
			[Cpp2IlInjected.Token(Token = "0x60004BB")]
			[Cpp2IlInjected.Address(RVA = "0xAADF50", Offset = "0xAAC950", VA = "0x180AADF50")]
			[CompilerGenerated]
			get
			{
				return default(NKILPDNDKBO);
			}
			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0xEB0C60", Offset = "0xEAF660", VA = "0x180EB0C60")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
		public virtual void MCAPBBPIBEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public BalanceResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[GBAJJMJPMAP]
	public class FilteredTextDTO : BHOLJOIPLEN
	{
		[Cpp2IlInjected.Token(Token = "0x1700020F")]
		public string HNDFHNMFPMC
		{
			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C0")]
			[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000210")]
		public int IJFFNKMBMCI
		{
			[Cpp2IlInjected.Token(Token = "0x60004C1")]
			[Cpp2IlInjected.Address(RVA = "0xA8E5C0", Offset = "0xA8CFC0", VA = "0x180A8E5C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004C2")]
			[Cpp2IlInjected.Address(RVA = "0xA8E5D0", Offset = "0xA8CFD0", VA = "0x180A8E5D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
		public void MCAPBBPIBEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public FilteredTextDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[GBAJJMJPMAP]
public class MAEBOPMBLFN : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000211")]
	public string EEPKPPNLBHD
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000212")]
	public string DOEMFKPPODL
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public MAEBOPMBLFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[GBAJJMJPMAP]
public class KLPLEKCBDLH : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000213")]
	public List<MAEBOPMBLFN> AJPHLDOLKIF
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public KLPLEKCBDLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[GBAJJMJPMAP]
public class LKGFJEPMHMN : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000214")]
	public string KJLOFJBJOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0xA93860", Offset = "0xA92260", VA = "0x180A93860")]
	public LKGFJEPMHMN(string EBILHLMBOEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[GBAJJMJPMAP]
public class DBPJNILLMNP : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000215")]
	public List<MAEBOPMBLFN> AJPHLDOLKIF
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public DBPJNILLMNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[GBAJJMJPMAP]
public class IHLFKOMJJBK : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000216")]
	public List<LKGFJEPMHMN> DODFBKBJAOF
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000217")]
	public string GLBCNGHDBJA
	{
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000218")]
	public bool CDPADKPFIFO
	{
		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0xA88540", Offset = "0xA86F40", VA = "0x180A88540")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0xA88520", Offset = "0xA86F20", VA = "0x180A88520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000219")]
	public int CKNIHPKOMBO
	{
		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0xC33060", Offset = "0xC31A60", VA = "0x180C33060")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x1058A60", Offset = "0x1057460", VA = "0x181058A60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public IHLFKOMJJBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x77A6520", Offset = "0x77A4F20", VA = "0x1877A6520")]
	public IHLFKOMJJBK(string CNHFAKOCKCL, List<LKGFJEPMHMN> FLMCNDHLDBG, bool LMHFKJCOHOE, int JPGBGDKOAGI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[GBAJJMJPMAP]
public class CIIPLBEOONI : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x1700021A")]
	public List<DBPJNILLMNP> JECMIJOCIGO
	{
		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021B")]
	public bool CDPADKPFIFO
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0xAD3450", Offset = "0xAD1E50", VA = "0x180AD3450")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0xA87B30", Offset = "0xA86530", VA = "0x180A87B30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public CIIPLBEOONI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[GBAJJMJPMAP]
public class LCHFHIIJLND : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public enum MCEJCPDIFIF
	{
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		EnqueuedPending,
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		DequeuedStarting,
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		CompleteSuccess
	}

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public const string OINMFAOKIDH = "StringAutoLocalizationJob";

	[Cpp2IlInjected.Token(Token = "0x1700021C")]
	public string GLBCNGHDBJA
	{
		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021D")]
	public MCEJCPDIFIF KFJEHFLOIKF
	{
		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5C0", Offset = "0xA8CFC0", VA = "0x180A8E5C0")]
		[CompilerGenerated]
		get
		{
			return default(MCEJCPDIFIF);
		}
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5D0", Offset = "0xA8CFD0", VA = "0x180A8E5D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x77A8940", Offset = "0x77A7340", VA = "0x1877A8940")]
	public LCHFHIIJLND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x77A88F0", Offset = "0x77A72F0", VA = "0x1877A88F0")]
	public LCHFHIIJLND(string CNHFAKOCKCL, MCEJCPDIFIF PIABFOHDCDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[GBAJJMJPMAP]
public class CADENOMAFME : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x1700021E")]
	public bool FEBJLKJOLFA
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0xB50B70", Offset = "0xB4F570", VA = "0x180B50B70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0xB50B50", Offset = "0xB4F550", VA = "0x180B50B50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public CADENOMAFME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public static class LMNMGAKMAJF
{
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public enum INOHEFCCPKG
	{
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		CoC_Discriminatory,
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		CoC_Sexual,
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		CoC_Trolling,
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		Misleading,
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		Other,
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		InappropriateClothing
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[GBAJJMJPMAP]
public class NFLEPMBKBCN : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x1700021F")]
	public long EDCJBBOOIBH
	{
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0xE6CA00", Offset = "0xE6B400", VA = "0x180E6CA00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000220")]
	public Guid PGNLANNPEAH
	{
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0xD5CF80", Offset = "0xD5B980", VA = "0x180D5CF80")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0xF32710", Offset = "0xF31110", VA = "0x180F32710")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000221")]
	public long CCKFBDCNGME
	{
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0xA882F0", Offset = "0xA86CF0", VA = "0x180A882F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000222")]
	public PLJOHPECOKG PFMNEIKOJJM
	{
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public NFLEPMBKBCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x77AA7F0", Offset = "0x77A91F0", VA = "0x1877AA7F0")]
	public NFLEPMBKBCN(long DKMPIOFKFMN, Guid HIHECPDBCLK, long BOILODJDIKH, PLJOHPECOKG AMOBKMBEJEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x77AA7D0", Offset = "0x77A91D0", VA = "0x1877AA7D0", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[GBAJJMJPMAP]
public class LGEBMNLJFAI : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000223")]
	public ANGICLMMAKO CBAAPALEPCN
	{
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
		[CompilerGenerated]
		get
		{
			return default(ANGICLMMAKO);
		}
		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0xA90060", Offset = "0xA8EA60", VA = "0x180A90060")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000224")]
	public KOGOPPAKDMG BGEOOEFILMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public LGEBMNLJFAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x1044F50", Offset = "0x1043950", VA = "0x181044F50")]
	public LGEBMNLJFAI(ANGICLMMAKO AEAMJGPOBKI, KOGOPPAKDMG AICEMMPOODE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[GBAJJMJPMAP]
public class PLJOHPECOKG : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000225")]
	public Guid? AHELHDHCMGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x31480B0", Offset = "0x3146AB0", VA = "0x1831480B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x77AC790", Offset = "0x77AB190", VA = "0x1877AC790")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000226")]
	public Guid MIMDGDEMDAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0xE86AC0", Offset = "0xE854C0", VA = "0x180E86AC0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x107AF70", Offset = "0x1079970", VA = "0x18107AF70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public PLJOHPECOKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x77AC7A0", Offset = "0x77AB1A0", VA = "0x1877AC7A0")]
	public PLJOHPECOKG(Guid? GEINHDDAKON, Guid FMBDNDHGDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[GBAJJMJPMAP]
public class KOGOPPAKDMG : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000227")]
	public long EDCJBBOOIBH
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0xE6CA00", Offset = "0xE6B400", VA = "0x180E6CA00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000228")]
	public Guid PGNLANNPEAH
	{
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0xD5CF80", Offset = "0xD5B980", VA = "0x180D5CF80")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0xF32710", Offset = "0xF31110", VA = "0x180F32710")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000229")]
	public long NEOIHEKIHEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0xA882F0", Offset = "0xA86CF0", VA = "0x180A882F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022A")]
	public Guid GDEFKBFDDEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0xF371D0", Offset = "0xF35BD0", VA = "0x180F371D0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0xF36610", Offset = "0xF35010", VA = "0x180F36610")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022B")]
	public DateTime NEFPGADCCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0xA91C70", Offset = "0xA90670", VA = "0x180A91C70")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0xF91930", Offset = "0xF90330", VA = "0x180F91930")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022C")]
	public DateTime NDENGKFIMKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0xA88320", Offset = "0xA86D20", VA = "0x180A88320")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x13AB4E0", Offset = "0x13A9EE0", VA = "0x1813AB4E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public KOGOPPAKDMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[GBAJJMJPMAP]
public class IILPLHLHNCA : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x1700022D")]
	public string FAHMGKIDCFD
	{
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022E")]
	public string LHKEDLABPNK
	{
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022F")]
	public string HHBAAHCOJDA
	{
		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000230")]
	public List<long> MFAKEPNPIBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000231")]
	public List<IDMGGOEBEEA> DPJODCLNOAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000232")]
	public string MMCCFOMAHPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0xA88310", Offset = "0xA86D10", VA = "0x180A88310")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000233")]
	public byte? BJCAPAMOEBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x77A65B0", Offset = "0x77A4FB0", VA = "0x1877A65B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x77A65C0", Offset = "0x77A4FC0", VA = "0x1877A65C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000234")]
	public int? FFCBOJIDKFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x77A4AE0", Offset = "0x77A34E0", VA = "0x1877A4AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x77A47E0", Offset = "0x77A31E0", VA = "0x1877A47E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000235")]
	public Guid? NLJLMFHCOBO
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x77A6590", Offset = "0x77A4F90", VA = "0x1877A6590")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x77A65D0", Offset = "0x77A4FD0", VA = "0x1877A65D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000236")]
	public bool OICFNMFFILC
	{
		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0xA91C40", Offset = "0xA90640", VA = "0x180A91C40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0xA91C60", Offset = "0xA90660", VA = "0x180A91C60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public IILPLHLHNCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[GBAJJMJPMAP]
public class BMANFJNADNB : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000237")]
	public Guid NLJLMFHCOBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0xE823D0", Offset = "0xE80DD0", VA = "0x180E823D0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0xE823E0", Offset = "0xE80DE0", VA = "0x180E823E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000238")]
	public long EDCJBBOOIBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0xDED820", Offset = "0xDEC220", VA = "0x180DED820")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000239")]
	public string FAHMGKIDCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023A")]
	public string LHKEDLABPNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023B")]
	public string HHBAAHCOJDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0xA88310", Offset = "0xA86D10", VA = "0x180A88310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023C")]
	public DateTime NEFPGADCCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0xA91C70", Offset = "0xA90670", VA = "0x180A91C70")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0xF91930", Offset = "0xF90330", VA = "0x180F91930")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023D")]
	public DateTime NDENGKFIMKM
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0xA88320", Offset = "0xA86D20", VA = "0x180A88320")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x13AB4E0", Offset = "0x13A9EE0", VA = "0x1813AB4E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023E")]
	public string MMCCFOMAHPE
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0xA84210", Offset = "0xA82C10", VA = "0x180A84210")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0xA84220", Offset = "0xA82C20", VA = "0x180A84220")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023F")]
	public List<long> MFAKEPNPIBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0xA84200", Offset = "0xA82C00", VA = "0x180A84200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0xA84190", Offset = "0xA82B90", VA = "0x180A84190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000240")]
	public List<LNJIDIAMKGO> DPJODCLNOAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0xA841E0", Offset = "0xA82BE0", VA = "0x180A841E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0xA841C0", Offset = "0xA82BC0", VA = "0x180A841C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000241")]
	public byte BJCAPAMOEBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0xAF41D0", Offset = "0xAF2BD0", VA = "0x180AF41D0")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0xAF41C0", Offset = "0xAF2BC0", VA = "0x180AF41C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000242")]
	public int FFCBOJIDKFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0xABCD50", Offset = "0xABB750", VA = "0x180ABCD50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x1578540", Offset = "0x1576F40", VA = "0x181578540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public BMANFJNADNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
[GBAJJMJPMAP]
public class CHNODILMOMJ : BMANFJNADNB
{
	[Cpp2IlInjected.Token(Token = "0x17000243")]
	public Guid EOGDNKBPBAL
	{
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x1BF12E0", Offset = "0x1BEFCE0", VA = "0x181BF12E0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x53213B0", Offset = "0x531FDB0", VA = "0x1853213B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public CHNODILMOMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public enum ANGICLMMAKO
{
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	RoomInventoryItemDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	PlayerDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	RoomDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	RequestQuantityTooLarge,
	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	PlayerHasReachedTheMinimumOwnedAmount,
	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	ConcurrencyCodeMismatch,
	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	InvalidConcurrencyCode
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public interface BILDFMDHIHC
{
	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PCJOEEHNGHJ<BMANFJNADNB>> OKMEOEDHGCO(Guid? JPMACAOCOMP, long DKMPIOFKFMN, string FLBFBHGDBLM, string IGEOMPONAKK, string OCELNAFHMKB, string LEAGIEMANBF, byte EBOPBDPOAOK, int EDNHAEBPHJD, [Optional] List<long> EPAHKBBMOBN, [Optional] List<LNJIDIAMKGO> BMBMIACEPHL, bool DJJDOLPBAFF = false, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<PCJOEEHNGHJ<BMANFJNADNB>> PBBGHIBNPGE(Guid HIHECPDBCLK, long DKMPIOFKFMN, [Optional] string FLBFBHGDBLM, [Optional] string IGEOMPONAKK, [Optional] string OCELNAFHMKB, [Optional] List<long> EPAHKBBMOBN, [Optional] Dictionary<string, string> BMBMIACEPHL, [Optional] string LEAGIEMANBF, [Optional] byte? EBOPBDPOAOK, [Optional] int? EDNHAEBPHJD, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<OONMGGAOEHG> HJJILNKFILL(Guid HIHECPDBCLK, long DKMPIOFKFMN, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<List<BMANFJNADNB>> BLAENAMMGMM(long DKMPIOFKFMN, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<List<KOGOPPAKDMG>> EEMPFIJIBNA(long DKMPIOFKFMN, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<List<LGEBMNLJFAI>> NKJBCHHLBCG(long DKMPIOFKFMN, List<NFLEPMBKBCN> AMKMJDEHLNE, [Optional] CancellationToken OMJKEHOJJFF);
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[GBAJJMJPMAP]
public class IDMGGOEBEEA : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000244")]
	public string FAHMGKIDCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000245")]
	public string MMCCFOMAHPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public IDMGGOEBEEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
[GBAJJMJPMAP]
public class LNJIDIAMKGO : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000246")]
	public long HHFOENNGLPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0xE6CA00", Offset = "0xE6B400", VA = "0x180E6CA00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000247")]
	public string FAHMGKIDCFD
	{
		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000248")]
	public string MMCCFOMAHPE
	{
		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public LNJIDIAMKGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
[GBAJJMJPMAP]
public class CFOIHAACFLC : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000249")]
	public long HHFOENNGLPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0xE6CA00", Offset = "0xE6B400", VA = "0x180E6CA00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024A")]
	public string MMCCFOMAHPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x4EA26A0", Offset = "0x4EA10A0", VA = "0x184EA26A0")]
	public CFOIHAACFLC(long NIKKFIAPLHL, string FNPCEKCMMCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public interface GCKLGHGMFCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PCJOEEHNGHJ<List<LNJIDIAMKGO>>> FAIHILCJBAI(long DKMPIOFKFMN, List<CFOIHAACFLC> AMKMJDEHLNE, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<OONMGGAOEHG> MPDKLEJCCDC(long NIKKFIAPLHL, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<List<LNJIDIAMKGO>> LPLFIMBEIHF(long DKMPIOFKFMN, [Optional] CancellationToken OMJKEHOJJFF);
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[GBAJJMJPMAP]
public class DMDHHOOGEHK : ANAKCDECEIG, IEquatable<DMDHHOOGEHK>
{
	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x77A12F0", Offset = "0x779FCF0", VA = "0x1877A12F0", Slot = "7")]
	public bool Equals(DMDHHOOGEHK EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x77A2F70", Offset = "0x77A1970", VA = "0x1877A2F70", Slot = "6")]
	public override ANAKCDECEIG GICKIFLNCPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public DMDHHOOGEHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public static class ELDGDKEGPOG
{
	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x77A3FD0", Offset = "0x77A29D0", VA = "0x1877A3FD0")]
	public static DMDHHOOGEHK BNKJJMGGNNH(this MJCBLPBPAOA HNLFGCKBFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x77A4040", Offset = "0x77A2A40", VA = "0x1877A4040")]
	public static DMDHHOOGEHK NEODOHOBBKA(string IEKDCDPPOPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
[GBAJJMJPMAP]
public class MJCBLPBPAOA : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public const int PEKKDBBKIFI = 3;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public const int CIEDBCEKDAD = 40;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public const int OEJLFEOGFKJ = 180;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public const int HIMLFLNHIAA = 1000;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public const int BPKKIOFFCIG = 99999;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public const int NDLEJIPOIFK = 8;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public const int GIAFBGGAGGE = 1;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public const int GACNGLCGAJD = 1000000000;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public const int KEOJBFFNONI = 9999;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	[IgnoreDataMember]
	private IReadOnlyDictionary<Guid, int>? HFBBICIBOOF;

	[Cpp2IlInjected.Token(Token = "0x1700024B")]
	public Guid NLJLMFHCOBO
	{
		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0xE823D0", Offset = "0xE80DD0", VA = "0x180E823D0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0xE823E0", Offset = "0xE80DE0", VA = "0x180E823E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024C")]
	public long EDCJBBOOIBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0xDED820", Offset = "0xDEC220", VA = "0x180DED820")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024D")]
	public string FAHMGKIDCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024E")]
	public string? LHKEDLABPNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024F")]
	public string? HHBAAHCOJDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0xA88310", Offset = "0xA86D10", VA = "0x180A88310")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000250")]
	public int BNDLIGFBKCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0xAF1310", Offset = "0xAEFD10", VA = "0x180AF1310")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0xAF1670", Offset = "0xAF0070", VA = "0x180AF1670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000251")]
	public Guid? GNAKFGMMNBM
	{
		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x77AA310", Offset = "0x77A8D10", VA = "0x1877AA310")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x77AA200", Offset = "0x77A8C00", VA = "0x1877AA200")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000252")]
	public int LDLHHBCPGMK
	{
		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0xAE78E0", Offset = "0xAE62E0", VA = "0x180AE78E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0xEC0EE0", Offset = "0xEBF8E0", VA = "0x180EC0EE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000253")]
	public int? MNJHKKIEELL
	{
		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x71C10C0", Offset = "0x71BFAC0", VA = "0x1871C10C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x71C10E0", Offset = "0x71BFAE0", VA = "0x1871C10E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000254")]
	public int? NNBLNFBMBCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x77AA220", Offset = "0x77A8C20", VA = "0x1877AA220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x77AA210", Offset = "0x77A8C10", VA = "0x1877AA210")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000255")]
	public IReadOnlyList<FOJCGNOEFCC> GFFLAMBKKJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0xA841F0", Offset = "0xA82BF0", VA = "0x180A841F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0xA841D0", Offset = "0xA82BD0", VA = "0x180A841D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000256")]
	public DateTime NEFPGADCCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0xA90910", Offset = "0xA8F310", VA = "0x180A90910")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0xFACF30", Offset = "0xFAB930", VA = "0x180FACF30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000257")]
	public DateTime NDENGKFIMKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0xA909E0", Offset = "0xA8F3E0", VA = "0x180A909E0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0xFADA70", Offset = "0xFAC470", VA = "0x180FADA70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000258")]
	[IgnoreDataMember]
	public LGPHGCKFCFP GPPPFNCFHIK
	{
		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x77AA2A0", Offset = "0x77A8CA0", VA = "0x1877AA2A0")]
		get
		{
			return default(LGPHGCKFCFP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000259")]
	[IgnoreDataMember]
	public IReadOnlyDictionary<Guid, int> MPAMPKGHKAG
	{
		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x77AA340", Offset = "0x77A8D40", VA = "0x1877AA340")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0xA90970", Offset = "0xA8F370", VA = "0x180A90970")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x77AA330", Offset = "0x77A8D30", VA = "0x1877AA330", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public MJCBLPBPAOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x77AA660", Offset = "0x77A9060", VA = "0x1877AA660")]
	public MJCBLPBPAOA(Guid JPMACAOCOMP, long DKMPIOFKFMN, string FLBFBHGDBLM, string IGEOMPONAKK, string OCELNAFHMKB, int ELNANKMHFDF, int? NHGOKNPEKFL, int? OGMOEBMDEGA, List<FOJCGNOEFCC> NGNPMHHJFKI, [Optional] DateTime GCDIBLHKMKM, [Optional] DateTime ILNMEAMEHHN, [Optional] Guid? HLDDGEALKKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x77AA230", Offset = "0x77A8C30", VA = "0x1877AA230")]
	private LGPHGCKFCFP KGAOIAHNHOO()
	{
		return default(LGPHGCKFCFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x77AA390", Offset = "0x77A8D90", VA = "0x1877AA390")]
	private Dictionary<Guid, int> OKKAIPACPJF(IReadOnlyList<FOJCGNOEFCC> NGNPMHHJFKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
[GBAJJMJPMAP]
public class MAJJAHPPEBN : BHOLJOIPLEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public Guid NLJLMFHCOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public long EDCJBBOOIBH;

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public MAJJAHPPEBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
[GBAJJMJPMAP]
public class GBIKJOHBDFI : MJCBLPBPAOA
{
	[Cpp2IlInjected.Token(Token = "0x1700025A")]
	public Guid HHHHDEBBPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0xFAD570", Offset = "0xFABF70", VA = "0x180FAD570")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0xFAD4C0", Offset = "0xFABEC0", VA = "0x180FAD4C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025B")]
	public Guid? BAPNHPKIHPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x77A4FE0", Offset = "0x77A39E0", VA = "0x1877A4FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x77A4FC0", Offset = "0x77A39C0", VA = "0x1877A4FC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public GBIKJOHBDFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
[GBAJJMJPMAP]
public class JPFGLBEGADC : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x1700025C")]
	public string FAHMGKIDCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025D")]
	public string? LHKEDLABPNK
	{
		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025E")]
	public string? HHBAAHCOJDA
	{
		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025F")]
	public int BNDLIGFBKCA
	{
		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5B0", Offset = "0xA8CFB0", VA = "0x180A8E5B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5E0", Offset = "0xA8CFE0", VA = "0x180A8E5E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000260")]
	public int? MNJHKKIEELL
	{
		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x136E640", Offset = "0x136D040", VA = "0x18136E640")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x136E670", Offset = "0x136D070", VA = "0x18136E670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000261")]
	public int? NNBLNFBMBCH
	{
		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0xDED7F0", Offset = "0xDEC1F0", VA = "0x180DED7F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0xDED830", Offset = "0xDEC230", VA = "0x180DED830")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000262")]
	public List<FOJCGNOEFCC> GFFLAMBKKJA
	{
		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0xA91C70", Offset = "0xA90670", VA = "0x180A91C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0xA88530", Offset = "0xA86F30", VA = "0x180A88530")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000263")]
	public Guid? BAPNHPKIHPF
	{
		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x77A7770", Offset = "0x77A6170", VA = "0x1877A7770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x77A7740", Offset = "0x77A6140", VA = "0x1877A7740")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000264")]
	public Guid? NLJLMFHCOBO
	{
		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x77A7750", Offset = "0x77A6150", VA = "0x1877A7750")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x77A77A0", Offset = "0x77A61A0", VA = "0x1877A77A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000265")]
	public bool OICFNMFFILC
	{
		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0xE7AD50", Offset = "0xE79750", VA = "0x180E7AD50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0xFE67A0", Offset = "0xFE51A0", VA = "0x180FE67A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x77A7790", Offset = "0x77A6190", VA = "0x1877A7790", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public JPFGLBEGADC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
[GBAJJMJPMAP]
public class FOJCGNOEFCC : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000266")]
	public EOPPOKCCNAH NLDECOCOLJE
	{
		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0xB50B70", Offset = "0xB4F570", VA = "0x180B50B70")]
		[CompilerGenerated]
		get
		{
			return default(EOPPOKCCNAH);
		}
		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0xB50B50", Offset = "0xB4F550", VA = "0x180B50B50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000267")]
	public Guid EHCHIJPCNBM
	{
		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x1B6A010", Offset = "0x1B68A10", VA = "0x181B6A010")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x5D78AC0", Offset = "0x5D774C0", VA = "0x185D78AC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000268")]
	public int NEOIHEKIHEL
	{
		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0xC33060", Offset = "0xC31A60", VA = "0x180C33060")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x1058A60", Offset = "0x1057460", VA = "0x181058A60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public FOJCGNOEFCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x77A4EF0", Offset = "0x77A38F0", VA = "0x1877A4EF0")]
	public FOJCGNOEFCC(Guid KLFOANDPKOD, EOPPOKCCNAH AEOGKDPPBBE, int CDCPIGCEABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
[GBAJJMJPMAP]
public class GKOCEBECPHL : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000269")]
	public Guid MGNDGEKBCPK
	{
		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0xE823D0", Offset = "0xE80DD0", VA = "0x180E823D0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0xE823E0", Offset = "0xE80DE0", VA = "0x180E823E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026A")]
	public string FAHMGKIDCFD
	{
		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026B")]
	public int NODPGMKDGEO
	{
		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5B0", Offset = "0xA8CFB0", VA = "0x180A8E5B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5E0", Offset = "0xA8CFE0", VA = "0x180A8E5E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026C")]
	public DateTime FABNOBAADLA
	{
		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0xA882E0", Offset = "0xA86CE0", VA = "0x180A882E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026D")]
	public int LDLHHBCPGMK
	{
		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0xAA3B30", Offset = "0xAA2530", VA = "0x180AA3B30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0xEAC2E0", Offset = "0xEAACE0", VA = "0x180EAC2E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x77A52D0", Offset = "0x77A3CD0", VA = "0x1877A52D0")]
	public GKOCEBECPHL(Guid PALNOFPGHON, string FLBFBHGDBLM, int EMAFFHIFOIH, DateTime ILNEPPMIGMD, int OHBCMIBMOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public GKOCEBECPHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
[GBAJJMJPMAP]
public class ACHHGIIJMOJ : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x1700026E")]
	public Guid MGNDGEKBCPK
	{
		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0xE823D0", Offset = "0xE80DD0", VA = "0x180E823D0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0xE823E0", Offset = "0xE80DE0", VA = "0x180E823E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026F")]
	public int GBJEHDAOFHH
	{
		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0xAE0120", Offset = "0xADEB20", VA = "0x180AE0120")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0xAE0110", Offset = "0xADEB10", VA = "0x180AE0110")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public ACHHGIIJMOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x5B5EB40", Offset = "0x5B5D540", VA = "0x185B5EB40")]
	public ACHHGIIJMOJ(Guid PALNOFPGHON, int OIPCLCFGALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
[GBAJJMJPMAP]
public class GBCDOLKMHDK : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000270")]
	public int GBJEHDAOFHH
	{
		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0xA90060", Offset = "0xA8EA60", VA = "0x180A90060")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000271")]
	public Guid BFKLPHJNENN
	{
		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x1B6A010", Offset = "0x1B68A10", VA = "0x181B6A010")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x5D78AC0", Offset = "0x5D774C0", VA = "0x185D78AC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000272")]
	public int AJDKEGNMHNG
	{
		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0xC33060", Offset = "0xC31A60", VA = "0x180C33060")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x1058A60", Offset = "0x1057460", VA = "0x181058A60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000273")]
	public Guid? JOMNHNFGAHK
	{
		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0xFA8360", Offset = "0xFA6D60", VA = "0x180FA8360")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x2476390", Offset = "0x2474D90", VA = "0x182476390")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000274")]
	public int OJPEEBPKCFD
	{
		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0xAA3B40", Offset = "0xAA2540", VA = "0x180AA3B40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x16F4230", Offset = "0x16F2C30", VA = "0x1816F4230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000275")]
	public Dictionary<Guid, Guid?> BPMKONFNMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0xA91C70", Offset = "0xA90670", VA = "0x180A91C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0xA88530", Offset = "0xA86F30", VA = "0x180A88530")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public GBCDOLKMHDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0x77A4F40", Offset = "0x77A3940", VA = "0x1877A4F40")]
	public GBCDOLKMHDK(int OIPCLCFGALN, Guid KGMACJHGPJL, int BBEPFBHGKIE, Guid? AIDNGGBNNAE, int CAPAGBIAPCP, Dictionary<Guid, Guid?> OBLJKDCEOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
[GBAJJMJPMAP]
public class KOGDPFJCHIO : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000276")]
	public POOAGOFHKDG NEOAPICAKIE
	{
		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0xB50B70", Offset = "0xB4F570", VA = "0x180B50B70")]
		[CompilerGenerated]
		get
		{
			return default(POOAGOFHKDG);
		}
		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0xB50B50", Offset = "0xB4F550", VA = "0x180B50B50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000277")]
	public LCNOABNNKJA? KFNBKECIACC
	{
		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x136E620", Offset = "0x136D020", VA = "0x18136E620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x13711F0", Offset = "0x136FBF0", VA = "0x1813711F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000278")]
	public BalanceResponseDTO EGGOIOOLBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000279")]
	public List<KOGOPPAKDMG> IDEJFEFFNKI
	{
		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public KOGDPFJCHIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x77A83D0", Offset = "0x77A6DD0", VA = "0x1877A83D0")]
	public KOGDPFJCHIO(POOAGOFHKDG EFONEOAPBFJ, LCNOABNNKJA? PJFFDHGGLPD, BalanceResponseDTO HNFKLPOPGIN, List<KOGOPPAKDMG> HJAHGKDOGPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0x77A83C0", Offset = "0x77A6DC0", VA = "0x1877A83C0", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public enum EOPPOKCCNAH : byte
{
	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	Unset,
	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	RoomInventoryItem
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public enum POOAGOFHKDG : byte
{
	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	Success = 0,
	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	ConcurrencyCodeMismatch = 1,
	[Cpp2IlInjected.Token(Token = "0x4000400")]
	RoomOfferDoesNotExist = 2,
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	InvalidRequest = 3,
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	AccountIdIsInvalid = 4,
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	PlayerIsP2PBuyingRestricted = 5,
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	ExpectedOfferTotalPriceMismatch = 6,
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	ExpectedOfferVersionMismatch = 7,
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	InsufficientBalance = 8,
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	OfferUnderModeration = 9,
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	InvalidExpectedTotalPrice = 10,
	[Cpp2IlInjected.Token(Token = "0x4000409")]
	InvalidExpectedOfferVersion = 11,
	[Cpp2IlInjected.Token(Token = "0x400040A")]
	CannotPurchaseMoreThanPerPlayerLimit = 12,
	[Cpp2IlInjected.Token(Token = "0x400040B")]
	InvalidExpectedPriceUnit = 13,
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	InsufficientInventoryItems = 14,
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	NoConcurrencyCodesForInventoryItem = 100,
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	UnexpectedOfferItemType = 101,
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	FeatureDisabled = 254,
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	UnknownError = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public enum LGPHGCKFCFP : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	OneTimePurchase,
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	BulkPurchase
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public interface EBDKHCDLLOH
{
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	static ECMKKKEPCGP<MJCBLPBPAOA> HALHNCIDBDG;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	static ECMKKKEPCGP<MJCBLPBPAOA> IPFHLCLCKPC;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	static ECMKKKEPCGP<Guid> GANBFDFNCLC;

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PCJOEEHNGHJ<MJCBLPBPAOA?>?>? LCGGLLHIGNM(Guid? JPMACAOCOMP, long DKMPIOFKFMN, string FLBFBHGDBLM, string? IGEOMPONAKK, string? OCELNAFHMKB, int ELNANKMHFDF, LGPHGCKFCFP ELIKADLEOIP, [Optional] Dictionary<Guid, int>? JBFEBDFIPKE, [Optional] Guid? HGBIALCBIJC, bool DJJDOLPBAFF = false, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<PCJOEEHNGHJ<MJCBLPBPAOA?>?>? BCLKINHBMMN(Guid PALNOFPGHON, long DKMPIOFKFMN, string FLBFBHGDBLM, string? IGEOMPONAKK, string? OCELNAFHMKB, int ELNANKMHFDF, LGPHGCKFCFP ELIKADLEOIP, [Optional] Dictionary<Guid, int>? JBFEBDFIPKE, [Optional] Guid? HGBIALCBIJC, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<OONMGGAOEHG> IKLHCJOICLK(Guid PALNOFPGHON, long DKMPIOFKFMN, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<List<MJCBLPBPAOA>> BHIEGPDOBLD(long DKMPIOFKFMN, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<PCJOEEHNGHJ<List<ACHHGIIJMOJ>>> MNCPOFJNIMD(long DKMPIOFKFMN, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<PCJOEEHNGHJ<List<GKOCEBECPHL>>> EMOHOIMNDBL(long DKMPIOFKFMN, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<KOGDPFJCHIO> JHIJKLADOIO(Guid PALNOFPGHON, long DKMPIOFKFMN, int OIPCLCFGALN, int BBEPFBHGKIE, Guid? DFHIAOINGIL, int CAPAGBIAPCP, Dictionary<Guid, Guid?> IFIKHEDOGMK, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x77A34C0", Offset = "0x77A1EC0", VA = "0x1877A34C0")]
	static EBDKHCDLLOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
[GBAJJMJPMAP]
public class ONEPCLGLMAM : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x1700027A")]
	public long EDCJBBOOIBH
	{
		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0xE6CA00", Offset = "0xE6B400", VA = "0x180E6CA00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700027B")]
	public bool PHKAMKFBNKK
	{
		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0xAD3450", Offset = "0xAD1E50", VA = "0x180AD3450")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0xA87B30", Offset = "0xA86530", VA = "0x180A87B30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public ONEPCLGLMAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public interface DPFJJIPFGLN
{
	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ONEPCLGLMAM> NCNBJCCDEPL(long DKMPIOFKFMN, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<OONMGGAOEHG> BIEBKDCCADG(long DKMPIOFKFMN, bool BACLAGHALDI, [Optional] CancellationToken OMJKEHOJJFF);
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
[CGOGLCNAGNJ]
public class GNCEABJHLBH<DataType> where DataType : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x1700027C")]
	public long CBHNADFEIEO
	{
		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0xE6CA00", Offset = "0xE6B400", VA = "0x180E6CA00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700027D")]
	public OICCDKGHIEL NFLCNKKLELI
	{
		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5C0", Offset = "0xA8CFC0", VA = "0x180A8E5C0")]
		[CompilerGenerated]
		get
		{
			return default(OICCDKGHIEL);
		}
		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5D0", Offset = "0xA8CFD0", VA = "0x180A8E5D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700027E")]
	public NKILPDNDKBO MMBEAHEGHMG
	{
		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0xAADF50", Offset = "0xAAC950", VA = "0x180AADF50")]
		[CompilerGenerated]
		get
		{
			return default(NKILPDNDKBO);
		}
		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0xEB0C60", Offset = "0xEAF660", VA = "0x180EB0C60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700027F")]
	public DataType AKBOOJDMDHH
	{
		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return (DataType)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public GNCEABJHLBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
[CGOGLCNAGNJ]
public class GEBHCPKGJFG<DataType> where DataType : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000280")]
	public long CBHNADFEIEO
	{
		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0xE6CA00", Offset = "0xE6B400", VA = "0x180E6CA00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000281")]
	public OICCDKGHIEL NFLCNKKLELI
	{
		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5C0", Offset = "0xA8CFC0", VA = "0x180A8E5C0")]
		[CompilerGenerated]
		get
		{
			return default(OICCDKGHIEL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5D0", Offset = "0xA8CFD0", VA = "0x180A8E5D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000282")]
	public NKILPDNDKBO MMBEAHEGHMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0xAADF50", Offset = "0xAAC950", VA = "0x180AADF50")]
		[CompilerGenerated]
		get
		{
			return default(NKILPDNDKBO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0xEB0C60", Offset = "0xEAF660", VA = "0x180EB0C60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000283")]
	public List<DataType> AKBOOJDMDHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public GEBHCPKGJFG()
	{
	}
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CGOGLCNAGNJ]
	public class BalanceUpdateResponseDTO<DataTypeDTO> : BalanceResponseDTO where DataTypeDTO : BHOLJOIPLEN, new()
	{
		[Cpp2IlInjected.Token(Token = "0x20000E8")]
		[CGOGLCNAGNJ]
		public class LHJHOOALJOM : LOCJLHBEEIF, BHOLJOIPLEN
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000E9")]
			[CompilerGenerated]
			private struct PNBLNPEFOHP : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000425")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000426")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000427")]
				public LHJHOOALJOM <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000428")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000612")]
				[Cpp2IlInjected.Address(RVA = "0x5B56F60", Offset = "0x5B55960", VA = "0x185B56F60", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000613")]
				[Cpp2IlInjected.Address(RVA = "0x5B57220", Offset = "0x5B55C20", VA = "0x185B57220", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000285")]
			public LCNOABNNKJA BMLAJCMLINJ
			{
				[Cpp2IlInjected.Token(Token = "0x600060B")]
				[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
				[CompilerGenerated]
				get
				{
					return default(LCNOABNNKJA);
				}
				[Cpp2IlInjected.Token(Token = "0x600060C")]
				[Cpp2IlInjected.Address(RVA = "0xA90060", Offset = "0xA8EA60", VA = "0x180A90060")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000286")]
			public DataTypeDTO AKBOOJDMDHH
			{
				[Cpp2IlInjected.Token(Token = "0x600060D")]
				[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
				[CompilerGenerated]
				get
				{
					return (DataTypeDTO)null;
				}
				[Cpp2IlInjected.Token(Token = "0x600060E")]
				[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0x560CCD0", Offset = "0x560B6D0", VA = "0x18560CCD0", Slot = "5")]
			public void MCAPBBPIBEB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0x560CE10", Offset = "0x560B810", VA = "0x18560CE10", Slot = "4")]
			[AsyncStateMachine(typeof(BalanceUpdateResponseDTO<>.LHJHOOALJOM.PNBLNPEFOHP))]
			public Task OENOAICBHGF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
			public LHJHOOALJOM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000284")]
		public List<LHJHOOALJOM> BalanceUpdates
		{
			[Cpp2IlInjected.Token(Token = "0x6000607")]
			[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000608")]
			[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x5B8F930", Offset = "0x5B8E330", VA = "0x185B8F930", Slot = "5")]
		public override void MCAPBBPIBEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
		public BalanceUpdateResponseDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[CGOGLCNAGNJ]
	public class PurchaseBalanceUpdateResponseDTO<DataTypeDTO> : BalanceResponseDTO where DataTypeDTO : BHOLJOIPLEN, new()
	{
		[Cpp2IlInjected.Token(Token = "0x20000EB")]
		[CGOGLCNAGNJ]
		public class DJGBANOABHA : LOCJLHBEEIF, BHOLJOIPLEN
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000EC")]
			[CompilerGenerated]
			private struct HOBEFIJBINN : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400042C")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400042D")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400042E")]
				public DJGBANOABHA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400042F")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600061F")]
				[Cpp2IlInjected.Address(RVA = "0x506D8A0", Offset = "0x506C2A0", VA = "0x18506D8A0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000620")]
				[Cpp2IlInjected.Address(RVA = "0x506DB00", Offset = "0x506C500", VA = "0x18506DB00", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000288")]
			public LCNOABNNKJA BMLAJCMLINJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000618")]
				[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
				[CompilerGenerated]
				get
				{
					return default(LCNOABNNKJA);
				}
				[Cpp2IlInjected.Token(Token = "0x6000619")]
				[Cpp2IlInjected.Address(RVA = "0xA90060", Offset = "0xA8EA60", VA = "0x180A90060")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000289")]
			public List<DataTypeDTO> AKBOOJDMDHH
			{
				[Cpp2IlInjected.Token(Token = "0x600061A")]
				[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600061B")]
				[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600061C")]
			[Cpp2IlInjected.Address(RVA = "0x7004EA0", Offset = "0x70038A0", VA = "0x187004EA0", Slot = "5")]
			public void MCAPBBPIBEB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061D")]
			[Cpp2IlInjected.Address(RVA = "0x7005120", Offset = "0x7003B20", VA = "0x187005120", Slot = "4")]
			[AsyncStateMachine(typeof(PurchaseBalanceUpdateResponseDTO<>.DJGBANOABHA.HOBEFIJBINN))]
			public Task OENOAICBHGF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600061E")]
			[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
			public DJGBANOABHA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000287")]
		public List<DJGBANOABHA> BalanceUpdates
		{
			[Cpp2IlInjected.Token(Token = "0x6000614")]
			[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000615")]
			[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x5B8F930", Offset = "0x5B8E330", VA = "0x185B8F930", Slot = "5")]
		public override void MCAPBBPIBEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
		public PurchaseBalanceUpdateResponseDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
[BGEDKDNGCAB]
public class FOIJCHHFLLF : PurchaseBalanceUpdateResponseDTO<PKPHPAIKFAL>
{
	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x77A4EB0", Offset = "0x77A38B0", VA = "0x1877A4EB0")]
	public FOIJCHHFLLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
[BGEDKDNGCAB]
public class KFIJAIJBJLD : PurchaseBalanceUpdateResponseDTO<PKPHPAIKFAL>.DJGBANOABHA
{
	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x77A8030", Offset = "0x77A6A30", VA = "0x1877A8030")]
	public KFIJAIJBJLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
[GBAJJMJPMAP]
public class EIKMKNIPDBD : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x1700028A")]
	public OJAKKHGMPKO OOLPJENKFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028B")]
	public long ICNMGCIDOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0xDD00C0", Offset = "0xDCEAC0", VA = "0x180DD00C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028C")]
	public GiftItemDTO? PABHLGHIHNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028D")]
	public long? FPLFAKDCEBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x13D5B70", Offset = "0x13D4570", VA = "0x1813D5B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x1514FE0", Offset = "0x15139E0", VA = "0x181514FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028E")]
	public int EDCPCGNKKAM
	{
		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0xAA3B30", Offset = "0xAA2530", VA = "0x180AA3B30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0xEAC2E0", Offset = "0xEAACE0", VA = "0x180EAC2E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x77A3F50", Offset = "0x77A2950", VA = "0x1877A3F50")]
	public EIKMKNIPDBD(OJAKKHGMPKO APGLEMLHJAJ, long LJOHGKNMJLN, GiftItemDTO? JFKANPIFAOG, int KPLOFCPOHJM = 1, [Optional] long? JHHJEFFDCFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
[GBAJJMJPMAP]
public class IBIICHNPFDB : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x1700028F")]
	public List<EIKMKNIPDBD> PLKMKNALFBO
	{
		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000290")]
	public FKDMLAMDOEN? HFFGLDDPOAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0xDD00C0", Offset = "0xDCEAC0", VA = "0x180DD00C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000291")]
	public OICCDKGHIEL NFLCNKKLELI
	{
		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0xAE0120", Offset = "0xADEB20", VA = "0x180AE0120")]
		[CompilerGenerated]
		get
		{
			return default(OICCDKGHIEL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0xAE0110", Offset = "0xADEB10", VA = "0x180AE0110")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000292")]
	public bool PKEHAFIGJNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0xE64A90", Offset = "0xE63490", VA = "0x180E64A90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0xE64630", Offset = "0xE63030", VA = "0x180E64630")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000293")]
	public bool EHMIBPAKCMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x15C5CE0", Offset = "0x15C46E0", VA = "0x1815C5CE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x28F2320", Offset = "0x28F0D20", VA = "0x1828F2320")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000294")]
	public Guid? FDIFDOCLFJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0xFA8360", Offset = "0xFA6D60", VA = "0x180FA8360")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x2476390", Offset = "0x2474D90", VA = "0x182476390")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x77A6080", Offset = "0x77A4A80", VA = "0x1877A6080")]
	public IBIICHNPFDB(List<EIKMKNIPDBD> EDDKKHLKIPO, FKDMLAMDOEN? NMLLEDFBKMM, OICCDKGHIEL FNONEKHIKKF, bool NAJDCDLOCFD, bool LMOKJMINPDE = false, [Optional] Guid? HFPLHKPBLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
[GBAJJMJPMAP]
public class NIKNBBJKNMM : LOCJLHBEEIF, BHOLJOIPLEN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private struct PBMIOCBGNCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public NIKNBBJKNMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x77ABD40", Offset = "0x77AA740", VA = "0x1877ABD40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x77AC020", Offset = "0x77AAA20", VA = "0x1877AC020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	internal static Action<PKPHPAIKFAL>? AJFHLMLODDO;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	internal static Func<PKPHPAIKFAL, Task>? KMINHENMHKD;

	[Cpp2IlInjected.Token(Token = "0x17000295")]
	public PKPHPAIKFAL KLFKDBCOFAL
	{
		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000296")]
	public int? LGMAECDJNBE
	{
		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0xDD00C0", Offset = "0xDCEAC0", VA = "0x180DD00C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000297")]
	public FKCOEBBJFAO? COCJFFEELGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x77AA850", Offset = "0x77A9250", VA = "0x1877AA850", Slot = "5")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(RVA = "0x77AA910", Offset = "0x77A9310", VA = "0x1877AA910", Slot = "6")]
	[AsyncStateMachine(typeof(PBMIOCBGNCH))]
	public virtual Task OENOAICBHGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public NIKNBBJKNMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
[BGEDKDNGCAB]
public class FMPNBLBEBPF : BalanceUpdateResponseDTO<NIKNBBJKNMM>
{
	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x77A4AF0", Offset = "0x77A34F0", VA = "0x1877A4AF0")]
	public FMPNBLBEBPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
[BGEDKDNGCAB]
public class EPANAJLFMEH : BalanceUpdateResponseDTO<NIKNBBJKNMM>.LHJHOOALJOM
{
	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x77A4340", Offset = "0x77A2D40", VA = "0x1877A4340")]
	public EPANAJLFMEH()
	{
	}
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[GBAJJMJPMAP]
	public class GiftItemDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000298")]
		public int ToPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x600064A")]
			[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600064B")]
			[Cpp2IlInjected.Address(RVA = "0xA90060", Offset = "0xA8EA60", VA = "0x180A90060")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000299")]
		public string? Message
		{
			[Cpp2IlInjected.Token(Token = "0x600064C")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600064D")]
			[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029A")]
		public bool Anonymous
		{
			[Cpp2IlInjected.Token(Token = "0x600064E")]
			[Cpp2IlInjected.Address(RVA = "0xA88540", Offset = "0xA86F40", VA = "0x180A88540")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600064F")]
			[Cpp2IlInjected.Address(RVA = "0xA88520", Offset = "0xA86F20", VA = "0x180A88520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029B")]
		public APJEKMFCMFG GiftContext
		{
			[Cpp2IlInjected.Token(Token = "0x6000650")]
			[Cpp2IlInjected.Address(RVA = "0xC33060", Offset = "0xC31A60", VA = "0x180C33060")]
			[CompilerGenerated]
			get
			{
				return default(APJEKMFCMFG);
			}
			[Cpp2IlInjected.Token(Token = "0x6000651")]
			[Cpp2IlInjected.Address(RVA = "0x1058A60", Offset = "0x1057460", VA = "0x181058A60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public GiftItemDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
[GBAJJMJPMAP]
public class KJAHAIAPOIE : BHOLJOIPLEN, NEJCKGIEOFF
{
	[Cpp2IlInjected.Token(Token = "0x1700029C")]
	public DLBAECGFOHO? NKKNKFPJNKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029D")]
	[IgnoreDataMember]
	public Guid FLMOBMMCAHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x77A82C0", Offset = "0x77A6CC0", VA = "0x1877A82C0", Slot = "5")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029E")]
	public OJAKKHGMPKO? OOPJBCLDADO
	{
		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029F")]
	public List<EHDLDGEGEDP>? FFPFNDEMPCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A0")]
	public DateTime? AFPGIGKALBA
	{
		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x13D5B70", Offset = "0x13D4570", VA = "0x1813D5B70", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x1514FE0", Offset = "0x15139E0", VA = "0x181514FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A1")]
	public DateTime? AMLEGGMBNFE
	{
		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x15C9370", Offset = "0x15C7D70", VA = "0x1815C9370", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x15CB8C0", Offset = "0x15CA2C0", VA = "0x1815CB8C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A2")]
	public DateTime? BKBBPIPANLF
	{
		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0xE7AD60", Offset = "0xE79760", VA = "0x180E7AD60", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x5D75690", Offset = "0x5D74090", VA = "0x185D75690")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A3")]
	public bool AJFGAGLECHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0xD33040", Offset = "0xD31A40", VA = "0x180D33040", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0xD32530", Offset = "0xD30F30", VA = "0x180D32530")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A4")]
	public bool AHLNNADCLBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x10A2B60", Offset = "0x10A1560", VA = "0x1810A2B60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x1265150", Offset = "0x1263B50", VA = "0x181265150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A5")]
	public bool ENPHCLCELIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x1052880", Offset = "0x1051280", VA = "0x181052880", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x1265140", Offset = "0x1263B40", VA = "0x181265140")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A6")]
	public bool JLBCDGCEPOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x104A310", Offset = "0x1048D10", VA = "0x18104A310", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x10529C0", Offset = "0x10513C0", VA = "0x1810529C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x77A8070", Offset = "0x77A6A70", VA = "0x1877A8070")]
	public static KJAHAIAPOIE AIIPFADJKAH(Guid DMABDIEKAKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public KJAHAIAPOIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
[GBAJJMJPMAP]
public class JFGIEBMIBCI
{
	[Cpp2IlInjected.Token(Token = "0x170002A7")]
	public int LDLHHBCPGMK
	{
		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0xA90060", Offset = "0xA8EA60", VA = "0x180A90060")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A8")]
	public string OLBBMBAIOJG
	{
		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A9")]
	public string KBBJFOIPBCD
	{
		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AA")]
	public Dictionary<int, PIMFGDCJFIO> PCBEALBHDBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AB")]
	public Dictionary<string, int> KFPBCHGOEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AC")]
	public Dictionary<NFLICJCCHLH, List<int>> DCEOIMFINIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0xA88310", Offset = "0xA86D10", VA = "0x180A88310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AD")]
	public Dictionary<string, string> BOBENFMBCFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0xA91C70", Offset = "0xA90670", VA = "0x180A91C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0xA88530", Offset = "0xA86F30", VA = "0x180A88530")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public JFGIEBMIBCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public enum NFLICJCCHLH
{
	[Cpp2IlInjected.Token(Token = "0x400045A")]
	DetailsScreen,
	[Cpp2IlInjected.Token(Token = "0x400045B")]
	SignUpScreen,
	[Cpp2IlInjected.Token(Token = "0x400045C")]
	ManageMembershipScreen,
	[Cpp2IlInjected.Token(Token = "0x400045D")]
	ItemDetailsScreen,
	[Cpp2IlInjected.Token(Token = "0x400045E")]
	ActivityRewardsScreen,
	[Cpp2IlInjected.Token(Token = "0x400045F")]
	RoomPublishUpsell
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
[GBAJJMJPMAP]
public class PIMFGDCJFIO : EJHAHLPCNIG
{
	[Cpp2IlInjected.Token(Token = "0x170002AE")]
	public KNEJLBPHMMH MIBPKHFGONL
	{
		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
		[CompilerGenerated]
		get
		{
			return default(KNEJLBPHMMH);
		}
		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0xA90060", Offset = "0xA8EA60", VA = "0x180A90060")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AF")]
	public bool JPJINJLELIK
	{
		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x1294150", Offset = "0x1292B50", VA = "0x181294150")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x15C7310", Offset = "0x15C5D10", VA = "0x1815C7310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B0")]
	public bool LMFGAIPLAPB
	{
		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x2021D40", Offset = "0x2020740", VA = "0x182021D40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x2021D50", Offset = "0x2020750", VA = "0x182021D50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B1")]
	public string MFJDOCKLLLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B2")]
	public string JPEBFOELAPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B3")]
	public string FGHAINGDEBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B4")]
	public string EKIBCFOIPPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B5")]
	public Dictionary<NPJJEBGBNDK, string> PIAAIIFINEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0xA88310", Offset = "0xA86D10", VA = "0x180A88310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x15C7320", Offset = "0x15C5D20", VA = "0x1815C7320")]
	public PIMFGDCJFIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
[GBAJJMJPMAP]
public class KBLGHBLIGFC : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x170002B6")]
	public IReadOnlyList<DLBAECGFOHO>? JDGBAKOKCKF
	{
		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public KBLGHBLIGFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0xA93860", Offset = "0xA92260", VA = "0x180A93860")]
	public KBLGHBLIGFC(IReadOnlyList<DLBAECGFOHO>? LABMJPDHBMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public enum HLNDJKGLKLL
{
	[Cpp2IlInjected.Token(Token = "0x400046A")]
	Unspecified = -1,
	[Cpp2IlInjected.Token(Token = "0x400046B")]
	XP,
	[Cpp2IlInjected.Token(Token = "0x400046C")]
	OutfitItem,
	[Cpp2IlInjected.Token(Token = "0x400046D")]
	Equipment,
	[Cpp2IlInjected.Token(Token = "0x400046E")]
	Currency,
	[Cpp2IlInjected.Token(Token = "0x400046F")]
	Consumable,
	[Cpp2IlInjected.Token(Token = "0x4000470")]
	Query,
	[Cpp2IlInjected.Token(Token = "0x4000471")]
	HairDye
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public interface NEJCKGIEOFF
{
	[Cpp2IlInjected.Token(Token = "0x170002B7")]
	Guid FLMOBMMCAHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B8")]
	OJAKKHGMPKO? OOPJBCLDADO
	{
		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B9")]
	List<EHDLDGEGEDP>? FFPFNDEMPCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BA")]
	DateTime? AFPGIGKALBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BB")]
	DateTime? AMLEGGMBNFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BC")]
	DateTime? BKBBPIPANLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BD")]
	bool AJFGAGLECHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BE")]
	bool ENPHCLCELIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BF")]
	bool JLBCDGCEPOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public interface OAAKLBGEOBC
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action HKDLKHBIOLI;

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task EPHPEOLNGBN(CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task EAEMLFBLMKH(CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool COBGKAIGPGF([Out] MNOPMKHAONM CJFJFBGGCAJ);
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public interface MNOPMKHAONM
{
	[Cpp2IlInjected.Token(Token = "0x170002C0")]
	string OLBBMBAIOJG
	{
		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C1")]
	string KBBJFOIPBCD
	{
		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C2")]
	IReadOnlyDictionary<NFLICJCCHLH, IReadOnlyList<EJHAHLPCNIG>> EIOKMLKBALG
	{
		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C3")]
	IReadOnlyDictionary<string, string> BOBENFMBCFE
	{
		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public interface EJHAHLPCNIG
{
	[Cpp2IlInjected.Token(Token = "0x170002C4")]
	string JPEBFOELAPC
	{
		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C5")]
	string MFJDOCKLLLG
	{
		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C6")]
	string FGHAINGDEBP
	{
		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C7")]
	string EKIBCFOIPPC
	{
		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public interface DCGEDIHFEKC
{
	[Cpp2IlInjected.Token(Token = "0x170002C8")]
	NFKAGEEDJKA NLDECOCOLJE
	{
		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C9")]
	string BIKKNIIFDAP
	{
		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002CA")]
	string BMEFPAKGMBA
	{
		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002CB")]
	string ONIIKEBGOOL
	{
		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002CC")]
	bool JLBCDGCEPOI
	{
		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002CD")]
	bool ENPHCLCELIC
	{
		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002CE")]
	HLLCBMIFJOL CDDDOEEINIC
	{
		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002CF")]
	string JBPKKCONGMC
	{
		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002D0")]
	NAPDNNCNOPF? PHHPCIODAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002D1")]
	HLNDJKGLKLL HOLKAHJIJHA
	{
		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002D2")]
	bool JAAOPAMMKAE
	{
		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
[GBAJJMJPMAP]
public class OJAKKHGMPKO : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x170002D3")]
	public NFKAGEEDJKA MMPEDFAPIKH
	{
		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
		[CompilerGenerated]
		get
		{
			return default(NFKAGEEDJKA);
		}
		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0xA90060", Offset = "0xA8EA60", VA = "0x180A90060")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D4")]
	public int? GAICBJILICF
	{
		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x136E620", Offset = "0x136D020", VA = "0x18136E620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x13711F0", Offset = "0x136FBF0", VA = "0x1813711F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D5")]
	public Guid? NCGACMONDNM
	{
		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0xA90A10", Offset = "0xA8F410", VA = "0x180A90A10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0xA90A00", Offset = "0xA8F400", VA = "0x180A90A00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(RVA = "0x77ABA00", Offset = "0x77AA400", VA = "0x1877ABA00")]
	public static OJAKKHGMPKO ILAGLFAPLKD(int LGJONAGGGAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(RVA = "0x77AB940", Offset = "0x77AA340", VA = "0x1877AB940")]
	public static OJAKKHGMPKO DDKKPALKPAF(Guid DMABDIEKAKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(RVA = "0x77AB740", Offset = "0x77AA140", VA = "0x1877AB740")]
	public static OJAKKHGMPKO ALJCPDBHFGF(LDKLCMHOOFP HJFDLIEMLGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public OJAKKHGMPKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public enum NFKAGEEDJKA
{
	[Cpp2IlInjected.Token(Token = "0x4000476")]
	PurchasableItem,
	[Cpp2IlInjected.Token(Token = "0x4000477")]
	CustomAvatarItem
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
[GBAJJMJPMAP]
public class EHDLDGEGEDP : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x170002D6")]
	public OICCDKGHIEL NFLCNKKLELI
	{
		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
		[CompilerGenerated]
		get
		{
			return default(OICCDKGHIEL);
		}
		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0xA90060", Offset = "0xA8EA60", VA = "0x180A90060")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D7")]
	public int BNDLIGFBKCA
	{
		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0xAD35E0", Offset = "0xAD1FE0", VA = "0x180AD35E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0xB68BB0", Offset = "0xB675B0", VA = "0x180B68BB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D8")]
	public CLKCEBNNLOF PDMGFINPCAL
	{
		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x1046D90", Offset = "0x1045790", VA = "0x181046D90", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x77A3F00", Offset = "0x77A2900", VA = "0x1877A3F00")]
	public int CLGBPOPFIDC(DateTime CJMKLHDGMGL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public EHDLDGEGEDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
[GBAJJMJPMAP]
public class CLKCEBNNLOF : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x170002D9")]
	public int BEMECALAAHA
	{
		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0xA90060", Offset = "0xA8EA60", VA = "0x180A90060")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DA")]
	public DateTime? PJJKJDMEACJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0xD5CF80", Offset = "0xD5B980", VA = "0x180D5CF80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0xF32710", Offset = "0xF31110", VA = "0x180F32710")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DB")]
	public DateTime? BLLNGKHNCKM
	{
		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x13D5B70", Offset = "0x13D4570", VA = "0x1813D5B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x1514FE0", Offset = "0x15139E0", VA = "0x181514FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x77A1B40", Offset = "0x77A0540", VA = "0x1877A1B40")]
	public bool AJNLEPPEDKL(DateTime CJMKLHDGMGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x77A1C30", Offset = "0x77A0630", VA = "0x1877A1C30")]
	public int GLBBKAICDLJ(DateTime CJMKLHDGMGL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(RVA = "0x77A1C60", Offset = "0x77A0660", VA = "0x1877A1C60")]
	public TimeSpan? LDEIAEAJCEK(DateTime CJMKLHDGMGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public CLKCEBNNLOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public enum FKDMLAMDOEN
{
	[Cpp2IlInjected.Token(Token = "0x400047F")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000480")]
	LaserTag = 1,
	[Cpp2IlInjected.Token(Token = "0x4000481")]
	RecCenter = 2,
	[Cpp2IlInjected.Token(Token = "0x4000482")]
	Watch = 3,
	[Cpp2IlInjected.Token(Token = "0x4000483")]
	Quest_LostSkulls = 100,
	[Cpp2IlInjected.Token(Token = "0x4000484")]
	Quest_Dracula = 101,
	[Cpp2IlInjected.Token(Token = "0x4000485")]
	Quest_GoldenTrophy = 102,
	[Cpp2IlInjected.Token(Token = "0x4000486")]
	Quest_CrimsonCauldron = 103,
	[Cpp2IlInjected.Token(Token = "0x4000487")]
	RecRoyale = 200,
	[Cpp2IlInjected.Token(Token = "0x4000488")]
	Cafe = 300,
	[Cpp2IlInjected.Token(Token = "0x4000489")]
	Paintball = 400,
	[Cpp2IlInjected.Token(Token = "0x400048A")]
	Paintball_River = 401,
	[Cpp2IlInjected.Token(Token = "0x400048B")]
	Paintball_Homestead = 402,
	[Cpp2IlInjected.Token(Token = "0x400048C")]
	Paintball_Quarry = 403,
	[Cpp2IlInjected.Token(Token = "0x400048D")]
	Paintball_ClearCut = 404,
	[Cpp2IlInjected.Token(Token = "0x400048E")]
	Paintball_Spillway = 405,
	[Cpp2IlInjected.Token(Token = "0x400048F")]
	Paintball_SunsetDriveIn = 406,
	[Cpp2IlInjected.Token(Token = "0x4000490")]
	Bowling = 500,
	[Cpp2IlInjected.Token(Token = "0x4000491")]
	StuntRunner = 600,
	[Cpp2IlInjected.Token(Token = "0x4000492")]
	DormMirror = 700,
	[Cpp2IlInjected.Token(Token = "0x4000493")]
	InventionStore = 800,
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	RoomKeys = 900,
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	Player_Profile = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	Room_Save = 1100,
	[Cpp2IlInjected.Token(Token = "0x4000497")]
	RoomCurrencies = 1200,
	[Cpp2IlInjected.Token(Token = "0x4000498")]
	Wishlist = 1300,
	[Cpp2IlInjected.Token(Token = "0x4000499")]
	Friendotron = 1400,
	[Cpp2IlInjected.Token(Token = "0x400049A")]
	RoomConsumables = 1500,
	[Cpp2IlInjected.Token(Token = "0x400049B")]
	RecRally = 1600,
	[Cpp2IlInjected.Token(Token = "0x400049C")]
	PopUpShop_1 = 1700,
	[Cpp2IlInjected.Token(Token = "0x400049D")]
	PopUpShop_2 = 1701,
	[Cpp2IlInjected.Token(Token = "0x400049E")]
	PopUpShop_3 = 1702,
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	PopUpShop_4 = 1703,
	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	PopUpShop_5 = 1704,
	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	PopUpShop_6 = 1705,
	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	PopUpShop_7 = 1706,
	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	PopUpShop_8 = 1707,
	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	PopUpShop_9 = 1708,
	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	PopUpShop_10 = 1709,
	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	PopUpShop_11 = 1710,
	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	PopUpShop_12 = 1711,
	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	PopUpShop_13 = 1712,
	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	PopUpShop_14 = 1713,
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	PopUpShop_15 = 1714,
	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	PopUpShop_16 = 1715,
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	PopUpShop_17 = 1716,
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	PopUpShop_18 = 1717,
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	PopUpShop_19 = 1718,
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	PopUpShop_20 = 1719,
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	CustomAvatarItems = 1800,
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	ProgressionEventPurchasableXpBoosts = 1900,
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	PopUpShop_ProgressionEvent_1 = 2000,
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	PopUpShop_ProgressionEvent_2 = 2001,
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	PopUpShop_ProgressionEvent_3 = 2002,
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	PopUpShop_ProgressionEvent_4 = 2003,
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	PopUpShop_ProgressionEvent_5 = 2004,
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	RoomOffers = 2100,
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	MyLittleMonsters = 2200,
	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	Destiny = 2201,
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	RunTheBlock = 2202,
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	RROStorefront_ToBeNamed_2 = 2203,
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	DevStorefront_DoNotAddToWatch_1 = 2300,
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	DevStorefront_DoNotAddToWatch_2 = 2301,
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	DevStorefront_DoNotAddToWatch_3 = 2302,
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	DevStorefront_DoNotAddToWatch_4 = 2303,
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	DevStorefront_DoNotAddToWatch_5 = 2304
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public enum OMCPPLOOAHG
{
	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	GiftDrop,
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	SeasonTier,
	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	SeasonEliteUpgrade
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public enum ELHMMHPBDJD
{
	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	Invalid = 0,
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	DirectBalanceWithMultiplier = 1,
	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	FromGiftBox = 2,
	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	NUXChallenge = 10,
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	AllNUXChallenges = 11,
	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	DailyChallenge = 100,
	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	AllDailyChallenges = 101,
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	FinishActivity = 200,
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	RecRoyaleMatchFinished = 250,
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	ChecklistCredit = 303,
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	WonGame = 1000,
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	LostGame = 1001,
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	WonGameRateLimited = 1002,
	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	WonGamePartial = 1003,
	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	LevelUp = 1100,
	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	Registered = 1200,
	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	CreatorReward = 1300,
	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	CommercePurchase = 1400,
	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	CommercePurchaseRevoked = 1401,
	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	Manual_Refund = 2000,
	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	Manual_Thanks = 2010,
	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	Manual_Apology = 2020,
	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	TestOnly = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public enum BGNNNPGCKJI
{
	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	Interval,
	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	PerDay
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public enum DOFBKOEGFOK
{
	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	PERCENTAGE = 1,
	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	EXACT_AMOUNT
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
[GBAJJMJPMAP]
public class EHDJEJDJLGF : IEquatable<EHDJEJDJLGF>
{
	[Cpp2IlInjected.Token(Token = "0x170002DC")]
	public int? HGFHBDBCLOP
	{
		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0xE6CA00", Offset = "0xE6B400", VA = "0x180E6CA00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DD")]
	public int? CIHLAHCFGMO
	{
		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0xDD00C0", Offset = "0xDCEAC0", VA = "0x180DD00C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DE")]
	public int? MGGBDKJJDMG
	{
		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0xDED820", Offset = "0xDEC220", VA = "0x180DED820")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DF")]
	public List<int>? HCCGBENGGMA
	{
		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006D8")]
	[Cpp2IlInjected.Address(RVA = "0x77A3D90", Offset = "0x77A2790", VA = "0x1877A3D90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(RVA = "0x77A3D30", Offset = "0x77A2730", VA = "0x1877A3D30")]
	public static EHDJEJDJLGF NKDKFBFBOJL(int? NJDOBGNIDDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(RVA = "0x77A39D0", Offset = "0x77A23D0", VA = "0x1877A39D0", Slot = "4")]
	public bool Equals(EHDJEJDJLGF? EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(RVA = "0x77A3700", Offset = "0x77A2100", VA = "0x1877A3700")]
	private static bool CMKFJJJJGHJ(List<int>? MLLJGIHINDJ, List<int>? ABNAHAKPDNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(RVA = "0x77A37A0", Offset = "0x77A21A0", VA = "0x1877A37A0", Slot = "0")]
	public override bool Equals(object? CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DD")]
	[Cpp2IlInjected.Address(RVA = "0x77A3B50", Offset = "0x77A2550", VA = "0x1877A3B50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public EHDJEJDJLGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public struct LDKLCMHOOFP : IEquatable<LDKLCMHOOFP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public readonly NFKAGEEDJKA NLDECOCOLJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	private readonly int GAICBJILICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	private readonly Guid NCGACMONDNM;

	[Cpp2IlInjected.Token(Token = "0x170002E0")]
	public Guid FLMOBMMCAHM
	{
		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x77A90E0", Offset = "0x77A7AE0", VA = "0x1877A90E0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E1")]
	public int LGMAECDJNBE
	{
		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x77A9260", Offset = "0x77A7C60", VA = "0x1877A9260")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E2")]
	public string JOENINHFBDG
	{
		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x77A8A80", Offset = "0x77A7480", VA = "0x1877A8A80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(RVA = "0x77A9270", Offset = "0x77A7C70", VA = "0x1877A9270")]
	public static bool NGIANNPEOKC(string NBNGFELHGMM, [Out] LDKLCMHOOFP HJFDLIEMLGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(RVA = "0x77A8E10", Offset = "0x77A7810", VA = "0x1877A8E10")]
	public static bool HBNBLACNBLH(string KOEHLDHNKNB, [Out] LDKLCMHOOFP HJFDLIEMLGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E4")]
	[Cpp2IlInjected.Address(RVA = "0x77A8950", Offset = "0x77A7350", VA = "0x1877A8950")]
	public static LDKLCMHOOFP AFHFNABGEDM(int EGJGKBPPPFG)
	{
		return default(LDKLCMHOOFP);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E5")]
	[Cpp2IlInjected.Address(RVA = "0x77A8AD0", Offset = "0x77A74D0", VA = "0x1877A8AD0")]
	public static LDKLCMHOOFP DAOFKNEGLNJ(Guid EGJGKBPPPFG)
	{
		return default(LDKLCMHOOFP);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(RVA = "0x77A9150", Offset = "0x77A7B50", VA = "0x1877A9150")]
	private static bool KGKOGHDKEMJ(string NBNGFELHGMM, [Out] NFKAGEEDJKA LANAPDLOODN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(RVA = "0x77A9760", Offset = "0x77A8160", VA = "0x1877A9760")]
	private LDKLCMHOOFP(NFKAGEEDJKA LANAPDLOODN, int? BAODICCLBBI, Guid? DMABDIEKAKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x77A8D10", Offset = "0x77A7710", VA = "0x1877A8D10", Slot = "4")]
	public bool Equals(LDKLCMHOOFP EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(RVA = "0x77A8C20", Offset = "0x77A7620", VA = "0x1877A8C20", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x77A8D80", Offset = "0x77A7780", VA = "0x1877A8D80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0x77A96B0", Offset = "0x77A80B0", VA = "0x1877A96B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
[GBAJJMJPMAP]
public abstract class ANAKCDECEIG : IEquatable<ANAKCDECEIG>, BHOLJOIPLEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public Guid LKBBCEFGAEA;

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x77A14D0", Offset = "0x779FED0", VA = "0x1877A14D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0x77A1450", Offset = "0x779FE50", VA = "0x1877A1450", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(RVA = "0x77A12F0", Offset = "0x779FCF0", VA = "0x1877A12F0", Slot = "4")]
	public bool Equals(ANAKCDECEIG EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EF")]
	[Cpp2IlInjected.Address(RVA = "0x77A1330", Offset = "0x779FD30", VA = "0x1877A1330", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F0")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract ANAKCDECEIG GICKIFLNCPB();

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	protected ANAKCDECEIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public enum LDDCBLCJHMP
{
	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	RoomKey,
	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	RoomConsumable,
	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	RoomCurrencyPurchaseOffer,
	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	CustomAvatarItem,
	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	StoreUGCAvatarItem,
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	UNDEFINED
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
[GBAJJMJPMAP]
public class DLBAECGFOHO : ANAKCDECEIG, IEquatable<DLBAECGFOHO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public LDDCBLCJHMP LANAPDLOODN;

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0x77A2BF0", Offset = "0x77A15F0", VA = "0x1877A2BF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(RVA = "0x77A2B70", Offset = "0x77A1570", VA = "0x1877A2B70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public DLBAECGFOHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(RVA = "0x77A2C90", Offset = "0x77A1690", VA = "0x1877A2C90")]
	public DLBAECGFOHO(LDDCBLCJHMP LANAPDLOODN, Guid LKBBCEFGAEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(RVA = "0x77A2A40", Offset = "0x77A1440", VA = "0x1877A2A40")]
	public static DLBAECGFOHO DAOFKNEGLNJ(Guid GDOCOMJBPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F8")]
	[Cpp2IlInjected.Address(RVA = "0x77A2AB0", Offset = "0x77A14B0", VA = "0x1877A2AB0", Slot = "7")]
	public bool Equals(DLBAECGFOHO EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F9")]
	[Cpp2IlInjected.Address(RVA = "0x77A2B00", Offset = "0x77A1500", VA = "0x1877A2B00", Slot = "6")]
	public override ANAKCDECEIG GICKIFLNCPB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public static class DKIPCEKEKCA
{
	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(RVA = "0x77A2870", Offset = "0x77A1270", VA = "0x1877A2870")]
	public static DLBAECGFOHO BNKJJMGGNNH(this PAEFNDJGIPH HNLFGCKBFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(RVA = "0x77A2950", Offset = "0x77A1350", VA = "0x1877A2950")]
	public static DLBAECGFOHO NEODOHOBBKA(string BFNEMLPAECN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(RVA = "0x77A28E0", Offset = "0x77A12E0", VA = "0x1877A28E0")]
	public static DLBAECGFOHO MKGAOFICMNH(Guid NFGHBCPBGPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
[GBAJJMJPMAP]
public class PAEFNDJGIPH : GCELMFGJPLP, BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x170002E3")]
	public LDDCBLCJHMP NLDECOCOLJE
	{
		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
		[CompilerGenerated]
		get
		{
			return default(LDDCBLCJHMP);
		}
		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0xA90060", Offset = "0xA8EA60", VA = "0x180A90060")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E4")]
	public Guid NKKNKFPJNKA
	{
		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x1B6A010", Offset = "0x1B68A10", VA = "0x181B6A010")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x5D78AC0", Offset = "0x5D774C0", VA = "0x185D78AC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E5")]
	public string FAHMGKIDCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E6")]
	public string LHKEDLABPNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E7")]
	public string HHBAAHCOJDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0xA88310", Offset = "0xA86D10", VA = "0x180A88310")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E8")]
	public long? EDCJBBOOIBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x1067F60", Offset = "0x1066960", VA = "0x181067F60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x1067F70", Offset = "0x1066970", VA = "0x181067F70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E9")]
	public long BNDLIGFBKCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0xA84210", Offset = "0xA82C10", VA = "0x180A84210")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0xF91920", Offset = "0xF90320", VA = "0x180F91920")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EA")]
	public Guid? OIEPECBIDMI
	{
		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x77ABBB0", Offset = "0x77AA5B0", VA = "0x1877ABBB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x77ABBA0", Offset = "0x77AA5A0", VA = "0x1877ABBA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EB")]
	public DateTime NEFPGADCCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0xA841F0", Offset = "0xA82BF0", VA = "0x180A841F0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0xFAD8C0", Offset = "0xFAC2C0", VA = "0x180FAD8C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EC")]
	public DateTime NDENGKFIMKM
	{
		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0xA90910", Offset = "0xA8F310", VA = "0x180A90910")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0xFACF30", Offset = "0xFAB930", VA = "0x180FACF30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000711")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public PAEFNDJGIPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(RVA = "0x77ABC80", Offset = "0x77AA680", VA = "0x1877ABC80")]
	public PAEFNDJGIPH(LDDCBLCJHMP LANAPDLOODN, Guid LKBBCEFGAEA, [Optional] string FLBFBHGDBLM, [Optional] string IGEOMPONAKK, [Optional] string OCELNAFHMKB, [Optional] long? DKMPIOFKFMN, long ELNANKMHFDF = 0L, [Optional] Guid? KAEPDPGECID, [Optional] DateTime GCDIBLHKMKM, [Optional] DateTime ILNMEAMEHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000713")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000714")]
	[Cpp2IlInjected.Address(RVA = "0x77ABBD0", Offset = "0x77AA5D0", VA = "0x1877ABBD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public interface EMIGPHGMJBK
{
	[Cpp2IlInjected.Token(Token = "0x170002ED")]
	string FAHMGKIDCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public interface PEENOBKILPC<out TId> : EMIGPHGMJBK where TId : struct
{
	[Cpp2IlInjected.Token(Token = "0x170002EE")]
	TId BIKKNIIFDAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
[GBAJJMJPMAP]
public class HMOJIMOBLDM : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x170002EF")]
	public List<KPLIMEGPAHI> NLFHLDHMCJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F0")]
	public List<MBMEKJCDNDG> IJIGKJEKAKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F1")]
	public List<KKKDNFNCPMO> HFHGALJMKBC
	{
		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F2")]
	public List<PEJGNEPAFIM> NLJJPKGIEDD
	{
		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F3")]
	public List<MDHGHNJPEAK> ONCIEHLJMCE
	{
		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F4")]
	public List<BOMHOHNFIOB> DDPODFFNMKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0xA88310", Offset = "0xA86D10", VA = "0x180A88310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F5")]
	public List<DLFICGFHIKB> CDKACHFNIOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0xA91C70", Offset = "0xA90670", VA = "0x180A91C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0xA88530", Offset = "0xA86F30", VA = "0x180A88530")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F6")]
	public GEHGCGJLANI GHFECEEBEGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0xA88320", Offset = "0xA86D20", VA = "0x180A88320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0xA88300", Offset = "0xA86D00", VA = "0x180A88300")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F7")]
	public GEHGCGJLANI GMOLJAOINNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0xA84210", Offset = "0xA82C10", VA = "0x180A84210")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0xA84220", Offset = "0xA82C20", VA = "0x180A84220")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F8")]
	public GEHGCGJLANI LGNLGOJFFCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0xA84200", Offset = "0xA82C00", VA = "0x180A84200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0xA84190", Offset = "0xA82B90", VA = "0x180A84190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0x77A5860", Offset = "0x77A4260", VA = "0x1877A5860", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x77A5A10", Offset = "0x77A4410", VA = "0x1877A5A10")]
	public HMOJIMOBLDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
[GBAJJMJPMAP]
public class KPLIMEGPAHI : BHOLJOIPLEN, IEquatable<KPLIMEGPAHI>
{
	[Cpp2IlInjected.Token(Token = "0x170002F9")]
	public MFIMOPDEOFG BKIHHLDKOAF
	{
		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0xB50B70", Offset = "0xB4F570", VA = "0x180B50B70")]
		[CompilerGenerated]
		get
		{
			return default(MFIMOPDEOFG);
		}
		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0xB50B50", Offset = "0xB4F550", VA = "0x180B50B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FA")]
	public NLDAHBJIIPF JCJCGOEJJIB
	{
		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0xB50B30", Offset = "0xB4F530", VA = "0x180B50B30")]
		[CompilerGenerated]
		get
		{
			return default(NLDAHBJIIPF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0xB50B40", Offset = "0xB4F540", VA = "0x180B50B40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FB")]
	public Guid FHBLDJDCBLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0x1B6A010", Offset = "0x1B68A10", VA = "0x181B6A010")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x5D78AC0", Offset = "0x5D774C0", VA = "0x185D78AC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FC")]
	public Guid JLLGLHPEIAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0xE86AC0", Offset = "0xE854C0", VA = "0x180E86AC0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x107AF70", Offset = "0x1079970", VA = "0x18107AF70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000736")]
	[Cpp2IlInjected.Address(RVA = "0x77A85B0", Offset = "0x77A6FB0", VA = "0x1877A85B0", Slot = "5")]
	public bool Equals(KPLIMEGPAHI EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000737")]
	[Cpp2IlInjected.Address(RVA = "0x77A8440", Offset = "0x77A6E40", VA = "0x1877A8440", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(RVA = "0x77A8650", Offset = "0x77A7050", VA = "0x1877A8650", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000739")]
	[Cpp2IlInjected.Address(RVA = "0x1501BF0", Offset = "0x15005F0", VA = "0x181501BF0")]
	public static bool JJNADAGGMDE(KPLIMEGPAHI OKDCNKNEMHO, KPLIMEGPAHI AAJFLFEAFBA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(RVA = "0x1501350", Offset = "0x14FFD50", VA = "0x181501350")]
	public static bool CNNLEBNJPBE(KPLIMEGPAHI OKDCNKNEMHO, KPLIMEGPAHI AAJFLFEAFBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public KPLIMEGPAHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
[GBAJJMJPMAP]
public class GEHGCGJLANI : BHOLJOIPLEN, PEENOBKILPC<NLDAHBJIIPF>, EMIGPHGMJBK
{
	[Cpp2IlInjected.Token(Token = "0x170002FD")]
	public NLDAHBJIIPF BIKKNIIFDAP
	{
		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(RVA = "0xB50B70", Offset = "0xB4F570", VA = "0x180B50B70", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(NLDAHBJIIPF);
		}
		[Cpp2IlInjected.Token(Token = "0x600073D")]
		[Cpp2IlInjected.Address(RVA = "0xB50B50", Offset = "0xB4F550", VA = "0x180B50B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FE")]
	public string FAHMGKIDCFD
	{
		[Cpp2IlInjected.Token(Token = "0x600073E")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FF")]
	public DEBBPOLPKEI EAFHBJKGAFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000300")]
	public float CPJGIHPNECN
	{
		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0x1083F70", Offset = "0x1082970", VA = "0x181083F70")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x155DD60", Offset = "0x155C760", VA = "0x18155DD60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000301")]
	public float CEJCILCFBBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0xD796D0", Offset = "0xD780D0", VA = "0x180D796D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0xD796E0", Offset = "0xD780E0", VA = "0x180D796E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000302")]
	public float KMIGOPGBPMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0xD3C0A0", Offset = "0xD3AAA0", VA = "0x180D3C0A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x106B670", Offset = "0x106A070", VA = "0x18106B670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(RVA = "0x77A5160", Offset = "0x77A3B60", VA = "0x1877A5160", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000749")]
	[Cpp2IlInjected.Address(RVA = "0x77A51B0", Offset = "0x77A3BB0", VA = "0x1877A51B0")]
	public GEHGCGJLANI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
[GBAJJMJPMAP]
public class MBMEKJCDNDG : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000303")]
	public KPLIMEGPAHI OFFMBGPIJFM
	{
		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000304")]
	public string ADCHIHCLAIM
	{
		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000305")]
	public HDBHNADLMGB CCLKOCKEJHP
	{
		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000750")]
	[Cpp2IlInjected.Address(RVA = "0x1046D90", Offset = "0x1045790", VA = "0x181046D90", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000751")]
	[Cpp2IlInjected.Address(RVA = "0x77AA020", Offset = "0x77A8A20", VA = "0x1877AA020")]
	public MBMEKJCDNDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
[GBAJJMJPMAP]
public class KKKDNFNCPMO : BHOLJOIPLEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public string CFOCDOMJCNP;

	[Cpp2IlInjected.Token(Token = "0x17000306")]
	public NLDAHBJIIPF JCJCGOEJJIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0xB50B70", Offset = "0xB4F570", VA = "0x180B50B70")]
		[CompilerGenerated]
		get
		{
			return default(NLDAHBJIIPF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0xB50B50", Offset = "0xB4F550", VA = "0x180B50B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000754")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000755")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public KKKDNFNCPMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
[GBAJJMJPMAP]
public class PEJGNEPAFIM : BHOLJOIPLEN, PEENOBKILPC<Guid>, EMIGPHGMJBK
{
	[Cpp2IlInjected.Token(Token = "0x17000307")]
	public string FAHMGKIDCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0x77AC080", Offset = "0x77AAA80", VA = "0x1877AC080", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000308")]
	public Guid BIKKNIIFDAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0xE823D0", Offset = "0xE80DD0", VA = "0x180E823D0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0xE823E0", Offset = "0xE80DE0", VA = "0x180E823E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000309")]
	public int FHOLFLHFMAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0xAE0120", Offset = "0xADEB20", VA = "0x180AE0120")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0xAE0110", Offset = "0xADEB10", VA = "0x180AE0110")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030A")]
	public string CFOCDOMJCNP
	{
		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030B")]
	public HDBHNADLMGB CALPOELKNMA
	{
		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600075F")]
	[Cpp2IlInjected.Address(RVA = "0x77AA7D0", Offset = "0x77A91D0", VA = "0x1877AA7D0", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000760")]
	[Cpp2IlInjected.Address(RVA = "0x77AC0F0", Offset = "0x77AAAF0", VA = "0x1877AC0F0")]
	public PEJGNEPAFIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
[GBAJJMJPMAP]
public class MDHGHNJPEAK : BHOLJOIPLEN, PEENOBKILPC<Guid>, EMIGPHGMJBK
{
	[Cpp2IlInjected.Token(Token = "0x1700030C")]
	public string FAHMGKIDCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030D")]
	public Guid BIKKNIIFDAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0xD5CF80", Offset = "0xD5B980", VA = "0x180D5CF80", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0xF32710", Offset = "0xF31110", VA = "0x180F32710")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030E")]
	public float JCNBIIACIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x1083F70", Offset = "0x1082970", VA = "0x181083F70")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x155DD60", Offset = "0x155C760", VA = "0x18155DD60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030F")]
	public IONIMHEDPEB JPFIMIAJCFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x18050E0", Offset = "0x1803AE0", VA = "0x1818050E0")]
		[CompilerGenerated]
		get
		{
			return default(IONIMHEDPEB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x106AE70", Offset = "0x1069870", VA = "0x18106AE70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000310")]
	public List<KNADDECMOFD> IHBPBDGGDDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600076B")]
	[Cpp2IlInjected.Address(RVA = "0x77AA0A0", Offset = "0x77A8AA0", VA = "0x1877AA0A0", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600076C")]
	[Cpp2IlInjected.Address(RVA = "0x77AA140", Offset = "0x77A8B40", VA = "0x1877AA140")]
	public MDHGHNJPEAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
[GBAJJMJPMAP]
public class BOMHOHNFIOB : BHOLJOIPLEN, PEENOBKILPC<Guid>, EMIGPHGMJBK
{
	[Cpp2IlInjected.Token(Token = "0x17000311")]
	public string FAHMGKIDCFD
	{
		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000312")]
	public Guid BIKKNIIFDAP
	{
		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0xD5CF80", Offset = "0xD5B980", VA = "0x180D5CF80", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0xF32710", Offset = "0xF31110", VA = "0x180F32710")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000313")]
	public DEBBPOLPKEI EAFHBJKGAFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000773")]
	[Cpp2IlInjected.Address(RVA = "0x77A16B0", Offset = "0x77A00B0", VA = "0x1877A16B0", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000774")]
	[Cpp2IlInjected.Address(RVA = "0x77A1700", Offset = "0x77A0100", VA = "0x1877A1700")]
	public BOMHOHNFIOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
[GBAJJMJPMAP]
public class DEBBPOLPKEI : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000314")]
	public List<KGKPKCDADAC> FOMFLLGFKEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000777")]
	[Cpp2IlInjected.Address(RVA = "0x77A2750", Offset = "0x77A1150", VA = "0x1877A2750", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000778")]
	[Cpp2IlInjected.Address(RVA = "0x77A2790", Offset = "0x77A1190", VA = "0x1877A2790")]
	public DEBBPOLPKEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
[GBAJJMJPMAP]
public class KGKPKCDADAC : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000315")]
	public float POFCFOMDDEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0xD5C580", Offset = "0xD5AF80", VA = "0x180D5C580")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0xDCD170", Offset = "0xDCBB70", VA = "0x180DCD170")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000316")]
	public float BHKLFFIKDPE
	{
		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0xE64270", Offset = "0xE62C70", VA = "0x180E64270")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0xE641F0", Offset = "0xE62BF0", VA = "0x180E641F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000317")]
	public float EKOIPDJKCML
	{
		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0xADE030", Offset = "0xADCA30", VA = "0x180ADE030")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600077E")]
		[Cpp2IlInjected.Address(RVA = "0x1376300", Offset = "0x1374D00", VA = "0x181376300")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000318")]
	public float LGJDCEOODGH
	{
		[Cpp2IlInjected.Token(Token = "0x600077F")]
		[Cpp2IlInjected.Address(RVA = "0xADE3F0", Offset = "0xADCDF0", VA = "0x180ADE3F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000780")]
		[Cpp2IlInjected.Address(RVA = "0xE920A0", Offset = "0xE90AA0", VA = "0x180E920A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000319")]
	public float LIDNFCJBCDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0xADE3E0", Offset = "0xADCDE0", VA = "0x180ADE3E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x10771D0", Offset = "0x1075BD0", VA = "0x1810771D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031A")]
	public float MODKBCLKNFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0xADFF60", Offset = "0xADE960", VA = "0x180ADFF60")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0xAE0130", Offset = "0xADEB30", VA = "0x180AE0130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031B")]
	public int LHMDJJNKLEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5B0", Offset = "0xA8CFB0", VA = "0x180A8E5B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5E0", Offset = "0xA8CFE0", VA = "0x180A8E5E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031C")]
	public int KMEOLCGKJMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0xAD60D0", Offset = "0xAD4AD0", VA = "0x180AD60D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0x1644B20", Offset = "0x1643520", VA = "0x181644B20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000789")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078A")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public KGKPKCDADAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
[GBAJJMJPMAP]
public class KNADDECMOFD : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x1700031D")]
	public float POFCFOMDDEN
	{
		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0xD5C580", Offset = "0xD5AF80", VA = "0x180D5C580")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0xDCD170", Offset = "0xDCBB70", VA = "0x180DCD170")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031E")]
	public HDBHNADLMGB CALPOELKNMA
	{
		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600078F")]
	[Cpp2IlInjected.Address(RVA = "0x1046D90", Offset = "0x1045790", VA = "0x181046D90", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000790")]
	[Cpp2IlInjected.Address(RVA = "0x77A8340", Offset = "0x77A6D40", VA = "0x1877A8340")]
	public KNADDECMOFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
[GBAJJMJPMAP]
public class HDBHNADLMGB : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x1700031F")]
	public float DCJENPHBJFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000791")]
		[Cpp2IlInjected.Address(RVA = "0xD5C580", Offset = "0xD5AF80", VA = "0x180D5C580")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0xDCD170", Offset = "0xDCBB70", VA = "0x180DCD170")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000320")]
	public float FINKGCLEOLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000793")]
		[Cpp2IlInjected.Address(RVA = "0xE64270", Offset = "0xE62C70", VA = "0x180E64270")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000794")]
		[Cpp2IlInjected.Address(RVA = "0xE641F0", Offset = "0xE62BF0", VA = "0x180E641F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000321")]
	public float NAAJIKIILKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000795")]
		[Cpp2IlInjected.Address(RVA = "0xADE030", Offset = "0xADCA30", VA = "0x180ADE030")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000796")]
		[Cpp2IlInjected.Address(RVA = "0x1376300", Offset = "0x1374D00", VA = "0x181376300")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000322")]
	public float NJMCBDPNPLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000797")]
		[Cpp2IlInjected.Address(RVA = "0xADE3F0", Offset = "0xADCDF0", VA = "0x180ADE3F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(RVA = "0xE920A0", Offset = "0xE90AA0", VA = "0x180E920A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000799")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public HDBHNADLMGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079A")]
	[Cpp2IlInjected.Address(RVA = "0x77A5610", Offset = "0x77A4010", VA = "0x1877A5610")]
	public HDBHNADLMGB(float PENFKHFIGID, float FIKNLIIDFCF, float ABNAHAKPDNC, float MLLJGIHINDJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079B")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
[GBAJJMJPMAP]
public class DLFICGFHIKB : BHOLJOIPLEN, PEENOBKILPC<Guid>, EMIGPHGMJBK
{
	[Cpp2IlInjected.Token(Token = "0x17000323")]
	public string FAHMGKIDCFD
	{
		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600079D")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000324")]
	public Guid BIKKNIIFDAP
	{
		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(RVA = "0xD5CF80", Offset = "0xD5B980", VA = "0x180D5CF80", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0xF32710", Offset = "0xF31110", VA = "0x180F32710")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000325")]
	public string DJABKFFFDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000326")]
	public string CAAANCLMNGE
	{
		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007A3")]
		[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000327")]
	public bool HMKFEGLELOF
	{
		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0xAE6140", Offset = "0xAE4B40", VA = "0x180AE6140")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0xAE6AC0", Offset = "0xAE54C0", VA = "0x180AE6AC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000328")]
	public float NNNGEOCDEFH
	{
		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0xAD7470", Offset = "0xAD5E70", VA = "0x180AD7470")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0xD3A070", Offset = "0xD38A70", VA = "0x180D3A070")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000329")]
	public GFCJDEEHHNL GGBCDGGDOAK
	{
		[Cpp2IlInjected.Token(Token = "0x60007A8")]
		[Cpp2IlInjected.Address(RVA = "0xA91C70", Offset = "0xA90670", VA = "0x180A91C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007A9")]
		[Cpp2IlInjected.Address(RVA = "0xA88530", Offset = "0xA86F30", VA = "0x180A88530")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032A")]
	public GFCJDEEHHNL MCGLNINOIMF
	{
		[Cpp2IlInjected.Token(Token = "0x60007AA")]
		[Cpp2IlInjected.Address(RVA = "0xA88320", Offset = "0xA86D20", VA = "0x180A88320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007AB")]
		[Cpp2IlInjected.Address(RVA = "0xA88300", Offset = "0xA86D00", VA = "0x180A88300")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032B")]
	public GFCJDEEHHNL INJPEJKDMPF
	{
		[Cpp2IlInjected.Token(Token = "0x60007AC")]
		[Cpp2IlInjected.Address(RVA = "0xA84210", Offset = "0xA82C10", VA = "0x180A84210")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007AD")]
		[Cpp2IlInjected.Address(RVA = "0xA84220", Offset = "0xA82C20", VA = "0x180A84220")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032C")]
	public GFCJDEEHHNL HDKPKKJDPJG
	{
		[Cpp2IlInjected.Token(Token = "0x60007AE")]
		[Cpp2IlInjected.Address(RVA = "0xA84200", Offset = "0xA82C00", VA = "0x180A84200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007AF")]
		[Cpp2IlInjected.Address(RVA = "0xA84190", Offset = "0xA82B90", VA = "0x180A84190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032D")]
	public INCIHNKDBCN HFGMIPBIAHE
	{
		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0xA841E0", Offset = "0xA82BE0", VA = "0x180A841E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007B1")]
		[Cpp2IlInjected.Address(RVA = "0xA841C0", Offset = "0xA82BC0", VA = "0x180A841C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007B2")]
	[Cpp2IlInjected.Address(RVA = "0x77A2CD0", Offset = "0x77A16D0", VA = "0x1877A2CD0", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B3")]
	[Cpp2IlInjected.Address(RVA = "0x77A2D90", Offset = "0x77A1790", VA = "0x1877A2D90")]
	public DLFICGFHIKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
[GBAJJMJPMAP]
public class GFCJDEEHHNL : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x1700032E")]
	public NCEBEGMFPBI BLIBIPGDHKL
	{
		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032F")]
	public float LIANKDMPOIC
	{
		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0xADE030", Offset = "0xADCA30", VA = "0x180ADE030")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007B7")]
		[Cpp2IlInjected.Address(RVA = "0x1376300", Offset = "0x1374D00", VA = "0x181376300")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000330")]
	public float KALFAGNIBHA
	{
		[Cpp2IlInjected.Token(Token = "0x60007B8")]
		[Cpp2IlInjected.Address(RVA = "0xADE3F0", Offset = "0xADCDF0", VA = "0x180ADE3F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007B9")]
		[Cpp2IlInjected.Address(RVA = "0xE920A0", Offset = "0xE90AA0", VA = "0x180E920A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000331")]
	public INCIHNKDBCN DIJNGOAMHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60007BA")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007BC")]
	[Cpp2IlInjected.Address(RVA = "0x77A5230", Offset = "0x77A3C30", VA = "0x1877A5230", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BD")]
	[Cpp2IlInjected.Address(RVA = "0x77A5250", Offset = "0x77A3C50", VA = "0x1877A5250")]
	public GFCJDEEHHNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
[GBAJJMJPMAP]
public class NCEBEGMFPBI : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000332")]
	public float FFNJJNNJINN
	{
		[Cpp2IlInjected.Token(Token = "0x60007BE")]
		[Cpp2IlInjected.Address(RVA = "0xD5C580", Offset = "0xD5AF80", VA = "0x180D5C580")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0xDCD170", Offset = "0xDCBB70", VA = "0x180DCD170")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000333")]
	public float OAAEAIBNJBA
	{
		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0xE64270", Offset = "0xE62C70", VA = "0x180E64270")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0xE641F0", Offset = "0xE62BF0", VA = "0x180E641F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007C2")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public NCEBEGMFPBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C3")]
	[Cpp2IlInjected.Address(RVA = "0x77836B0", Offset = "0x77820B0", VA = "0x1877836B0")]
	public NCEBEGMFPBI(float IECENJOJFJH, float OFOCBNJJIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C4")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
	public virtual void MCAPBBPIBEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
[GBAJJMJPMAP]
public class INCIHNKDBCN : NCEBEGMFPBI
{
	[Cpp2IlInjected.Token(Token = "0x17000334")]
	public float HCNNGEDJLNF
	{
		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0xADE030", Offset = "0xADCA30", VA = "0x180ADE030")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(RVA = "0x1376300", Offset = "0x1374D00", VA = "0x181376300")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000335")]
	public float PFKHHKOEPAK
	{
		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0xADE3F0", Offset = "0xADCDF0", VA = "0x180ADE3F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007C8")]
		[Cpp2IlInjected.Address(RVA = "0xE920A0", Offset = "0xE90AA0", VA = "0x180E920A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007C9")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public INCIHNKDBCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CA")]
	[Cpp2IlInjected.Address(RVA = "0x77A5610", Offset = "0x77A4010", VA = "0x1877A5610")]
	public INCIHNKDBCN(float IECENJOJFJH, float OFOCBNJJIJE, float KBPKNDAKOHF, float CINPCLDHBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CB")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
	public override void MCAPBBPIBEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
internal static class GCNFABDBECH
{
	[Cpp2IlInjected.Token(Token = "0x60007CC")]
	[Cpp2IlInjected.Address(RVA = "0x3C62F40", Offset = "0x3C61940", VA = "0x183C62F40")]
	public static void IHGPKJDEFBG<T>(IList<T>? LHEAJNMGMFP) where T : BHOLJOIPLEN
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public enum MFIMOPDEOFG : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	Invalid,
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	Emission,
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	HairColor,
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	PlayerHeadScale,
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	Aura,
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	Texture
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public enum NLDAHBJIIPF : byte
{
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	Invalid,
	[Cpp2IlInjected.Token(Token = "0x400054D")]
	PlayerVoiceInput,
	[Cpp2IlInjected.Token(Token = "0x400054E")]
	PlayerVelocity,
	[Cpp2IlInjected.Token(Token = "0x400054F")]
	AnimationCurve,
	[Cpp2IlInjected.Token(Token = "0x4000550")]
	HighFiveCount,
	[Cpp2IlInjected.Token(Token = "0x4000551")]
	AlwaysOn
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public enum IONIMHEDPEB : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000553")]
	Invalid,
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	Time,
	[Cpp2IlInjected.Token(Token = "0x4000555")]
	ValueRamp
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public static class FJAABMIIBBB
{
	[Cpp2IlInjected.Token(Token = "0x4000556")]
	public static readonly MFIMOPDEOFG[] BDOPCHFPLCP;

	[Cpp2IlInjected.Token(Token = "0x4000557")]
	public static readonly MFIMOPDEOFG[] KIHEENHGOJA;

	[Cpp2IlInjected.Token(Token = "0x4000558")]
	public static readonly NLDAHBJIIPF[] FEEMCJKPFHC;

	[Cpp2IlInjected.Token(Token = "0x4000559")]
	public static readonly NLDAHBJIIPF[] FACBEOAHFAH;
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public enum OOEFJEHICNE
{
	[Cpp2IlInjected.Token(Token = "0x400055C")]
	General,
	[Cpp2IlInjected.Token(Token = "0x400055D")]
	Auto,
	[Cpp2IlInjected.Token(Token = "0x400055E")]
	AGOnly,
	[Cpp2IlInjected.Token(Token = "0x400055F")]
	Banned
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public enum ABJPPHBLHBK
{
	[Cpp2IlInjected.Token(Token = "0x4000561")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000562")]
	TooManyTags,
	[Cpp2IlInjected.Token(Token = "0x4000563")]
	TagUseRestricted,
	[Cpp2IlInjected.Token(Token = "0x4000564")]
	InvalidTag,
	[Cpp2IlInjected.Token(Token = "0x4000565")]
	InappropriateTag,
	[Cpp2IlInjected.Token(Token = "0x4000566")]
	TagTooLong,
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	TagNotFound,
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	TagAlreadyExists,
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	NoChange,
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	TagRepeated,
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	LacksPermission,
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	RoomDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	InventionDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	ReservedWordViolation
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
[GBAJJMJPMAP]
public class NLFBHFMFJHP : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000336")]
	public ABJPPHBLHBK CBAAPALEPCN
	{
		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
		[CompilerGenerated]
		get
		{
			return default(ABJPPHBLHBK);
		}
		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0xA90060", Offset = "0xA8EA60", VA = "0x180A90060")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000337")]
	public List<string> CIBDIGEMLDE
	{
		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007D6")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D7")]
	[Cpp2IlInjected.Address(RVA = "0x77AA9E0", Offset = "0x77A93E0", VA = "0x1877AA9E0")]
	public string OLIIABDFBMG(int NBAMDDMNOJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007D8")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public NLFBHFMFJHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
[GBAJJMJPMAP]
public class AJMDKHEGLAC : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000338")]
	public string JADAEBBLDNA
	{
		[Cpp2IlInjected.Token(Token = "0x60007D9")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007DA")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000339")]
	public OOEFJEHICNE MMPEDFAPIKH
	{
		[Cpp2IlInjected.Token(Token = "0x60007DB")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5C0", Offset = "0xA8CFC0", VA = "0x180A8E5C0")]
		[CompilerGenerated]
		get
		{
			return default(OOEFJEHICNE);
		}
		[Cpp2IlInjected.Token(Token = "0x60007DC")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5D0", Offset = "0xA8CFD0", VA = "0x180A8E5D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007DD")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DE")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public AJMDKHEGLAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public static class FOICMGLIEPE
{
	[Cpp2IlInjected.Token(Token = "0x4000573")]
	public const string GBBMNAIDIBB = "costume";

	[Cpp2IlInjected.Token(Token = "0x4000574")]
	public const string FDKCOLDHFBN = "gadget";

	[Cpp2IlInjected.Token(Token = "0x4000575")]
	public const string ANBOAGDAJLB = "holotar";

	[Cpp2IlInjected.Token(Token = "0x4000576")]
	public const string FMPMGOGDLCD = "large";

	[Cpp2IlInjected.Token(Token = "0x4000577")]
	public const string DHCMHEHGOGL = "medium";

	[Cpp2IlInjected.Token(Token = "0x4000578")]
	public const string APMBKDKJOGM = "small";

	[Cpp2IlInjected.Token(Token = "0x4000579")]
	public const string IAAFKMNPCAF = "sound";

	[Cpp2IlInjected.Token(Token = "0x400057A")]
	public const string DANNDGOLGBL = "dormanchor";

	[Cpp2IlInjected.Token(Token = "0x400057B")]
	public const string EKCGCLHAIIJ = "reccenteranchor";

	[Cpp2IlInjected.Token(Token = "0x400057C")]
	public const string LCKNGIHGMIE = "r2";

	[Cpp2IlInjected.Token(Token = "0x1700033A")]
	public static List<string> CDHHKKCDMBI
	{
		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0x77A4CE0", Offset = "0x77A36E0", VA = "0x1877A4CE0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public static class EIGOOFMILPK
{
	[Cpp2IlInjected.Token(Token = "0x400057D")]
	public const string KNHNGKBJCLF = "beta";

	[Cpp2IlInjected.Token(Token = "0x400057E")]
	public const string PLCJBAMNFLP = "limitsv2";
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
[GBAJJMJPMAP]
public class ONGAFAFBKNA : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x1700033B")]
	public List<string> CMDLBIHKMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007E1")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033C")]
	public List<string> DCPBAPJMAGI
	{
		[Cpp2IlInjected.Token(Token = "0x60007E2")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007E3")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033D")]
	public List<string> NGDIEFFMABM
	{
		[Cpp2IlInjected.Token(Token = "0x60007E4")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007E6")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E7")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public ONGAFAFBKNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
public class KFHDCFOMNCC : IEquatable<KFHDCFOMNCC>
{
	[Cpp2IlInjected.Token(Token = "0x1700033E")]
	protected virtual Type NLBACNKMDLI
	{
		[Cpp2IlInjected.Token(Token = "0x60007E9")]
		[Cpp2IlInjected.Address(RVA = "0x77A7BD0", Offset = "0x77A65D0", VA = "0x1877A7BD0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033F")]
	public PEKPGJGOILC? PNEHFLIEJBO
	{
		[Cpp2IlInjected.Token(Token = "0x60007EA")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0xE6CA00", Offset = "0xE6B400", VA = "0x180E6CA00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000340")]
	public HttpMethod? CFEOOMOGGCF
	{
		[Cpp2IlInjected.Token(Token = "0x60007EC")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007ED")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000341")]
	public string? HIPINPNMPJF
	{
		[Cpp2IlInjected.Token(Token = "0x60007EE")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007EF")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007E8")]
	[Cpp2IlInjected.Address(RVA = "0x77A7FE0", Offset = "0x77A69E0", VA = "0x1877A7FE0")]
	public KFHDCFOMNCC(PEKPGJGOILC? PNEHFLIEJBO, HttpMethod? CFEOOMOGGCF, string? HIPINPNMPJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F0")]
	[Cpp2IlInjected.Address(RVA = "0x77A7E70", Offset = "0x77A6870", VA = "0x1877A7E70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007F1")]
	[Cpp2IlInjected.Address(RVA = "0x77A7850", Offset = "0x77A6250", VA = "0x1877A7850", Slot = "6")]
	protected virtual bool AICAJEMLONH(StringBuilder EBBBAHAEGHJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60007F2")]
	[Cpp2IlInjected.Address(RVA = "0x1269220", Offset = "0x1267C20", VA = "0x181269220")]
	public static bool CNNLEBNJPBE(KFHDCFOMNCC? KMGJNLBHING, KFHDCFOMNCC? ELFIMJDHHOB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60007F3")]
	[Cpp2IlInjected.Address(RVA = "0x12695F0", Offset = "0x1267FF0", VA = "0x1812695F0")]
	public static bool JJNADAGGMDE(KFHDCFOMNCC? KMGJNLBHING, KFHDCFOMNCC? ELFIMJDHHOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007F4")]
	[Cpp2IlInjected.Address(RVA = "0x77A7C70", Offset = "0x77A6670", VA = "0x1877A7C70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007F5")]
	[Cpp2IlInjected.Address(RVA = "0x77A7B40", Offset = "0x77A6540", VA = "0x1877A7B40", Slot = "0")]
	public override bool Equals(object? CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007F6")]
	[Cpp2IlInjected.Address(RVA = "0x77A79B0", Offset = "0x77A63B0", VA = "0x1877A79B0", Slot = "7")]
	public virtual bool Equals(KFHDCFOMNCC? EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007F7")]
	[Cpp2IlInjected.Address(RVA = "0x77A7DE0", Offset = "0x77A67E0", VA = "0x1877A7DE0", Slot = "8")]
	public virtual KFHDCFOMNCC HAFEIFHMPFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007F8")]
	[Cpp2IlInjected.Address(RVA = "0x77A7F80", Offset = "0x77A6980", VA = "0x1877A7F80")]
	protected KFHDCFOMNCC(KFHDCFOMNCC HADHNPCHHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F9")]
	[Cpp2IlInjected.Address(RVA = "0x77A7C30", Offset = "0x77A6630", VA = "0x1877A7C30")]
	public void GNAIPCHGPNM([Out] PEKPGJGOILC? PNEHFLIEJBO, [Out] HttpMethod? CFEOOMOGGCF, [Out] string? HIPINPNMPJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
public class NLMFEDMNOOI : IEquatable<NLMFEDMNOOI>
{
	[Cpp2IlInjected.Token(Token = "0x17000342")]
	protected virtual Type NLBACNKMDLI
	{
		[Cpp2IlInjected.Token(Token = "0x60007FB")]
		[Cpp2IlInjected.Address(RVA = "0x77AAF90", Offset = "0x77A9990", VA = "0x1877AAF90", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000343")]
	public int NBIDNOJDOEL
	{
		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0xA90060", Offset = "0xA8EA60", VA = "0x180A90060")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000344")]
	public PAHPFAIPOGG CCBAACIAKPN
	{
		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0xAD35E0", Offset = "0xAD1FE0", VA = "0x180AD35E0")]
		[CompilerGenerated]
		get
		{
			return default(PAHPFAIPOGG);
		}
		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0xB68BB0", Offset = "0xB675B0", VA = "0x180B68BB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007FA")]
	[Cpp2IlInjected.Address(RVA = "0x77AB290", Offset = "0x77A9C90", VA = "0x1877AB290")]
	public NLMFEDMNOOI(int NBIDNOJDOEL, PAHPFAIPOGG CCBAACIAKPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000800")]
	[Cpp2IlInjected.Address(RVA = "0x77AB180", Offset = "0x77A9B80", VA = "0x1877AB180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000801")]
	[Cpp2IlInjected.Address(RVA = "0x77AAC90", Offset = "0x77A9690", VA = "0x1877AAC90", Slot = "6")]
	protected virtual bool AICAJEMLONH(StringBuilder EBBBAHAEGHJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000802")]
	[Cpp2IlInjected.Address(RVA = "0x1269220", Offset = "0x1267C20", VA = "0x181269220")]
	public static bool CNNLEBNJPBE(NLMFEDMNOOI? KMGJNLBHING, NLMFEDMNOOI? ELFIMJDHHOB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000803")]
	[Cpp2IlInjected.Address(RVA = "0x12695F0", Offset = "0x1267FF0", VA = "0x1812695F0")]
	public static bool JJNADAGGMDE(NLMFEDMNOOI? KMGJNLBHING, NLMFEDMNOOI? ELFIMJDHHOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000804")]
	[Cpp2IlInjected.Address(RVA = "0x77AB000", Offset = "0x77A9A00", VA = "0x1877AB000", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000805")]
	[Cpp2IlInjected.Address(RVA = "0x77AAF00", Offset = "0x77A9900", VA = "0x1877AAF00", Slot = "0")]
	public override bool Equals(object? CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000806")]
	[Cpp2IlInjected.Address(RVA = "0x77AADC0", Offset = "0x77A97C0", VA = "0x1877AADC0", Slot = "7")]
	public virtual bool Equals(NLMFEDMNOOI? EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000807")]
	[Cpp2IlInjected.Address(RVA = "0x77AB110", Offset = "0x77A9B10", VA = "0x1877AB110", Slot = "8")]
	public virtual NLMFEDMNOOI HAFEIFHMPFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000808")]
	[Cpp2IlInjected.Address(RVA = "0xCCDB50", Offset = "0xCCC550", VA = "0x180CCDB50")]
	protected NLMFEDMNOOI(NLMFEDMNOOI HADHNPCHHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000809")]
	[Cpp2IlInjected.Address(RVA = "0x77AAFF0", Offset = "0x77A99F0", VA = "0x1877AAFF0")]
	public void GNAIPCHGPNM([Out] int NBIDNOJDOEL, [Out] PAHPFAIPOGG CCBAACIAKPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
public enum PAHPFAIPOGG
{
	[Cpp2IlInjected.Token(Token = "0x4000588")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000589")]
	ConnectionTimeout,
	[Cpp2IlInjected.Token(Token = "0x400058A")]
	InternalServerError
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
public interface BNIBANLHDJM
{
	[Cpp2IlInjected.Token(Token = "0x600080A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<KFHDCFOMNCC, NLMFEDMNOOI> HGAKDEAKEFH();

	[Cpp2IlInjected.Token(Token = "0x600080B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IHFFLLDANPF(KFHDCFOMNCC LNBCHJPEENA, NLMFEDMNOOI FOAIPBIEILM);

	[Cpp2IlInjected.Token(Token = "0x600080C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JMIEABDDJDC(KFHDCFOMNCC LNBCHJPEENA);

	[Cpp2IlInjected.Token(Token = "0x600080D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DGLJGMCMLEJ();

	[Cpp2IlInjected.Token(Token = "0x600080E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task EDIMCBIPBMN(PEKPGJGOILC LMPCECBHOAI, HttpMethod LOHNFJJANPK, string LLKJIOEIEAO, CancellationToken OMJKEHOJJFF);
}
[Cpp2IlInjected.Token(Token = "0x2000134")]
public interface LNDJHJLOKIC
{
	[Cpp2IlInjected.Token(Token = "0x600080F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<Guid>> MEGFIMDMNPC(string PAMBGILIOIG);
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
[CGOGLCNAGNJ]
public class JOOJCLGELGF<TResult> where TResult : BHOLJOIPLEN, new()
{
	[Cpp2IlInjected.Token(Token = "0x17000345")]
	public IReadOnlyList<TResult> BCJCKIJHHFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000346")]
	public long JLOCLNNKPPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000813")]
		[Cpp2IlInjected.Address(RVA = "0xDD00C0", Offset = "0xDCEAC0", VA = "0x180DD00C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000814")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public JOOJCLGELGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
public enum BKCEIGFIMLI
{
	[Cpp2IlInjected.Token(Token = "0x400058E")]
	Development = 1,
	[Cpp2IlInjected.Token(Token = "0x400058F")]
	QA = 8,
	[Cpp2IlInjected.Token(Token = "0x4000590")]
	Production = 0x100
}
[Cpp2IlInjected.Token(Token = "0x2000137")]
public interface NOAGHEHNNOG : FLGJNBAIAAH
{
	[Cpp2IlInjected.Token(Token = "0x17000347")]
	bool OEPFPDHJFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000816")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task AuthorizePurchaseAsync(long KGMACJHGPJL, CPMLAOBGEMB KIKGEBENMPI);

	[Cpp2IlInjected.Token(Token = "0x6000817")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<JAKAGADKOID> PurchaseAsync(CPMLAOBGEMB KIKGEBENMPI, EHDJEJDJLGF CELCFIAJPCF);

	[Cpp2IlInjected.Token(Token = "0x6000818")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task ValidatePurchasingSupported(MIOLLNOCDLA ILKNCBDODNM, CancellationToken OMJKEHOJJFF);
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
public interface FLGJNBAIAAH
{
	[Cpp2IlInjected.Token(Token = "0x17000348")]
	bool HMJONAOGFAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000819")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600081A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<string> FetchCommerceAccessToken([Optional] CancellationToken OMJKEHOJJFF);
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
public interface EJCLAPPMANN
{
	[Cpp2IlInjected.Token(Token = "0x17000349")]
	int HJOFBBBCBBM
	{
		[Cpp2IlInjected.Token(Token = "0x600081F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600081B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<CPMLAOBGEMB>> KEHPDNPDAMK(bool FIIMKHNMBEL = false, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x600081C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FHLNLHIKCGO([Out] CPMLAOBGEMB? PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x600081D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<CPMLAOBGEMB> BDPABLCFHID(bool FIIMKHNMBEL = false, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x600081E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FEPKNOMEICP(string HDDLNGLMMKN = "");
}
[Cpp2IlInjected.Token(Token = "0x200013A")]
public interface FKCPJCPDHID
{
	[Cpp2IlInjected.Token(Token = "0x6000820")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task CGHMKLLGOOM(MIOLLNOCDLA ILKNCBDODNM, CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000821")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task GPMPCFINEKE(MIOLLNOCDLA ILKNCBDODNM, CancellationToken OMJKEHOJJFF, [Optional] PPMKCGCLOPI? PNIHGODMNAM);
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
public interface PPMKCGCLOPI
{
	[Cpp2IlInjected.Token(Token = "0x6000822")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JPMAFMBMPOM(string BCLNCLHGOEM);
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
public interface FLNNPOABHBI
{
	[Cpp2IlInjected.Token(Token = "0x6000823")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task OPFJODOINFN(MIOLLNOCDLA GENNELNALPE, CancellationToken OMJKEHOJJFF);
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
public interface NBEAAEPFGLK
{
	[Cpp2IlInjected.Token(Token = "0x1700034A")]
	bool NJDECIAJPGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013E")]
public interface NMMJKMELJJC
{
	[Cpp2IlInjected.Token(Token = "0x6000825")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MIOLLNOCDLA JCPLGGJBKLD(CPMLAOBGEMB KIKGEBENMPI, EHDJEJDJLGF CELCFIAJPCF, string PICBKLGJNEB, [Optional] FKCPJCPDHID? HCLPLLELFIK);
}
[Cpp2IlInjected.Token(Token = "0x200013F")]
public interface MMLECHDMMOB
{
	[Cpp2IlInjected.Token(Token = "0x6000826")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NCGOCHAGLKM(FLNNPOABHBI LCJFNEJNIDM);

	[Cpp2IlInjected.Token(Token = "0x6000827")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JEJCDJJJLJM(FLNNPOABHBI LCJFNEJNIDM);

	[Cpp2IlInjected.Token(Token = "0x6000828")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task DCDBAJDMCOF(MIOLLNOCDLA ILKNCBDODNM, CancellationToken OMJKEHOJJFF);
}
[Cpp2IlInjected.Token(Token = "0x2000140")]
public interface MIOLLNOCDLA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700034B")]
	PFOMPMKLKCO DFIKJOIIJEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000829")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700034C")]
	CPMLAOBGEMB AGMLEGHNGEB
	{
		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700034D")]
	EHDJEJDJLGF CEAIMJPFILM
	{
		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700034E")]
	string LMMCCMKFCCP
	{
		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700034F")]
	string IDBGAOOCBCP
	{
		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600082E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<LNCELLBJAAM> FOMAJLFCNCG(CancellationToken BOJKDJLCGKE, [Optional] PPMKCGCLOPI? PNIHGODMNAM);

	[Cpp2IlInjected.Token(Token = "0x600082F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JOKGIEPJPMJ(string LJCGGLBEFFM);

	[Cpp2IlInjected.Token(Token = "0x6000830")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JOKGIEPJPMJ<T>(Func<T, string> LJCGGLBEFFM, [In] T CGIOOMLDBBI);
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
public abstract class CFCEHAGFPHK
{
	[Cpp2IlInjected.Token(Token = "0x6000831")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	protected CFCEHAGFPHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
public enum GHCBMLNKBEL
{
	[Cpp2IlInjected.Token(Token = "0x4000592")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x4000593")]
	InAppPurchaseNotAllowedOnAccount,
	[Cpp2IlInjected.Token(Token = "0x4000594")]
	PlatformPurchaseException,
	[Cpp2IlInjected.Token(Token = "0x4000595")]
	PlatformPurchaseFailure,
	[Cpp2IlInjected.Token(Token = "0x4000596")]
	CommerceInitiatePurchaseFailure,
	[Cpp2IlInjected.Token(Token = "0x4000597")]
	FailedToGetPlatformAccessToken,
	[Cpp2IlInjected.Token(Token = "0x4000598")]
	PlatformAuthorizePurchaseFailure,
	[Cpp2IlInjected.Token(Token = "0x4000599")]
	CommerceCompletePurchaseFailure,
	[Cpp2IlInjected.Token(Token = "0x400059A")]
	PlatformSubscriptionNotSupported,
	[Cpp2IlInjected.Token(Token = "0x400059B")]
	PlatformPurchasesNotSupported,
	[Cpp2IlInjected.Token(Token = "0x400059C")]
	OculusDesktopPlayersMustBeInVR,
	[Cpp2IlInjected.Token(Token = "0x400059D")]
	FailedToRetrieveParentalControls,
	[Cpp2IlInjected.Token(Token = "0x400059E")]
	UserCanceled,
	[Cpp2IlInjected.Token(Token = "0x400059F")]
	DebugError
}
[Cpp2IlInjected.Token(Token = "0x2000143")]
public enum KCDCPHAAIEC : byte
{
	[Cpp2IlInjected.Token(Token = "0x40005A1")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x40005A2")]
	AccountError,
	[Cpp2IlInjected.Token(Token = "0x40005A3")]
	PlatformError,
	[Cpp2IlInjected.Token(Token = "0x40005A4")]
	CommerceError,
	[Cpp2IlInjected.Token(Token = "0x40005A5")]
	UserAction
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
[GBAJJMJPMAP]
public class CPMLAOBGEMB : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000350")]
	public int LFLMLMPNPEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(RVA = "0xA90060", Offset = "0xA8EA60", VA = "0x180A90060")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000351")]
	public string FAHMGKIDCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000835")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000352")]
	public string LHKEDLABPNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000836")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000353")]
	public string HHBAAHCOJDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000354")]
	public int BNDLIGFBKCA
	{
		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(RVA = "0xA938E0", Offset = "0xA922E0", VA = "0x180A938E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600083B")]
		[Cpp2IlInjected.Address(RVA = "0xA93AE0", Offset = "0xA924E0", VA = "0x180A93AE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000355")]
	public string JPHFBDIGOBM
	{
		[Cpp2IlInjected.Token(Token = "0x600083C")]
		[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600083D")]
		[Cpp2IlInjected.Address(RVA = "0xA88310", Offset = "0xA86D10", VA = "0x180A88310")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000356")]
	public string AOPDPGMCBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600083E")]
		[Cpp2IlInjected.Address(RVA = "0xA91C70", Offset = "0xA90670", VA = "0x180A91C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600083F")]
		[Cpp2IlInjected.Address(RVA = "0xA88530", Offset = "0xA86F30", VA = "0x180A88530")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000357")]
	[DataMember(Name = "PsnProductLabel")]
	public string JNAFFPIDJDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000840")]
		[Cpp2IlInjected.Address(RVA = "0xA88320", Offset = "0xA86D20", VA = "0x180A88320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000841")]
		[Cpp2IlInjected.Address(RVA = "0xA88300", Offset = "0xA86D00", VA = "0x180A88300")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000358")]
	public string EKIGMHDBNJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000842")]
		[Cpp2IlInjected.Address(RVA = "0xA84210", Offset = "0xA82C10", VA = "0x180A84210")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000843")]
		[Cpp2IlInjected.Address(RVA = "0xA84220", Offset = "0xA82C20", VA = "0x180A84220")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000359")]
	public string PEDMBLIOIME
	{
		[Cpp2IlInjected.Token(Token = "0x6000844")]
		[Cpp2IlInjected.Address(RVA = "0xA84200", Offset = "0xA82C00", VA = "0x180A84200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000845")]
		[Cpp2IlInjected.Address(RVA = "0xA84190", Offset = "0xA82B90", VA = "0x180A84190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035A")]
	public string DHGCBKNMMCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000846")]
		[Cpp2IlInjected.Address(RVA = "0xA841E0", Offset = "0xA82BE0", VA = "0x180A841E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0xA841C0", Offset = "0xA82BC0", VA = "0x180A841C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035B")]
	public string EJPIALGCDFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0xA841B0", Offset = "0xA82BB0", VA = "0x180A841B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0xA841A0", Offset = "0xA82BA0", VA = "0x180A841A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035C")]
	public string KGAOHBFINPN
	{
		[Cpp2IlInjected.Token(Token = "0x600084A")]
		[Cpp2IlInjected.Address(RVA = "0xA841F0", Offset = "0xA82BF0", VA = "0x180A841F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600084B")]
		[Cpp2IlInjected.Address(RVA = "0xA841D0", Offset = "0xA82BD0", VA = "0x180A841D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035D")]
	public bool ICEAEHEDINA
	{
		[Cpp2IlInjected.Token(Token = "0x600084C")]
		[Cpp2IlInjected.Address(RVA = "0xD72070", Offset = "0xD70A70", VA = "0x180D72070")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600084D")]
		[Cpp2IlInjected.Address(RVA = "0xD71850", Offset = "0xD70250", VA = "0x180D71850")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035E")]
	public bool JELBOOBHGCM
	{
		[Cpp2IlInjected.Token(Token = "0x600084E")]
		[Cpp2IlInjected.Address(RVA = "0x1837D00", Offset = "0x1836700", VA = "0x181837D00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600084F")]
		[Cpp2IlInjected.Address(RVA = "0x1837EE0", Offset = "0x18368E0", VA = "0x181837EE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035F")]
	public LIBGBPEIEOC AKBOOJDMDHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000850")]
		[Cpp2IlInjected.Address(RVA = "0xA909E0", Offset = "0xA8F3E0", VA = "0x180A909E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000851")]
		[Cpp2IlInjected.Address(RVA = "0xA909C0", Offset = "0xA8F3C0", VA = "0x180A909C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000360")]
	[IgnoreDataMember]
	public string MFNNPEDFKPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000852")]
		[Cpp2IlInjected.Address(RVA = "0xA909D0", Offset = "0xA8F3D0", VA = "0x180A909D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000853")]
		[Cpp2IlInjected.Address(RVA = "0xA90970", Offset = "0xA8F370", VA = "0x180A90970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000361")]
	[IgnoreDataMember]
	public string JLCGJFKDJCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000854")]
		[Cpp2IlInjected.Address(RVA = "0xAEDCD0", Offset = "0xAEC6D0", VA = "0x180AEDCD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000855")]
		[Cpp2IlInjected.Address(RVA = "0xAEB9B0", Offset = "0xAEA3B0", VA = "0x180AEB9B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000362")]
	[IgnoreDataMember]
	public string JNDIJCKBLIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000856")]
		[Cpp2IlInjected.Address(RVA = "0xA90900", Offset = "0xA8F300", VA = "0x180A90900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000857")]
		[Cpp2IlInjected.Address(RVA = "0xA90890", Offset = "0xA8F290", VA = "0x180A90890")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000363")]
	[IgnoreDataMember]
	public CFCEHAGFPHK HMOAOKOLFBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000858")]
		[Cpp2IlInjected.Address(RVA = "0xAEE0F0", Offset = "0xAECAF0", VA = "0x180AEE0F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000859")]
		[Cpp2IlInjected.Address(RVA = "0xB40620", Offset = "0xB3F020", VA = "0x180B40620")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000364")]
	[IgnoreDataMember]
	public bool DCOMACLBMEP
	{
		[Cpp2IlInjected.Token(Token = "0x600085A")]
		[Cpp2IlInjected.Address(RVA = "0x77A1DF0", Offset = "0x77A07F0", VA = "0x1877A1DF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000365")]
	[IgnoreDataMember]
	public string APEJMCEMFGM
	{
		[Cpp2IlInjected.Token(Token = "0x600085B")]
		[Cpp2IlInjected.Address(RVA = "0xA89DE0", Offset = "0xA887E0", VA = "0x180A89DE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0xA89E50", Offset = "0xA88850", VA = "0x180A89E50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600085D")]
	[Cpp2IlInjected.Address(RVA = "0x77A1E10", Offset = "0x77A0810", VA = "0x1877A1E10", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085E")]
	[Cpp2IlInjected.Address(RVA = "0x77A1D50", Offset = "0x77A0750", VA = "0x1877A1D50")]
	public static CPMLAOBGEMB AEFGHBKPEDD(int EGJGKBPPPFG, string FLBFBHGDBLM, string OCELNAFHMKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600085F")]
	[Cpp2IlInjected.Address(RVA = "0x77A1F00", Offset = "0x77A0900", VA = "0x1877A1F00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000860")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public CPMLAOBGEMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000145")]
[GBAJJMJPMAP]
public class LIBGBPEIEOC : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000366")]
	public List<int> AKNMBJPFBHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000367")]
	public string IGNKIAJJGLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000864")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000368")]
	public MJLGNAJLPPF KOHOPPMIHMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000865")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000866")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000867")]
	[Cpp2IlInjected.Address(RVA = "0x1046D90", Offset = "0x1045790", VA = "0x181046D90", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000868")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public LIBGBPEIEOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
public readonly struct LNCELLBJAAM
{
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	public enum GOFEHHHEAPL : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		CancelledByUser,
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		Success
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005BE")]
	public readonly GOFEHHHEAPL MJNJBJINEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40005BF")]
	public readonly KCDCPHAAIEC HGKHAFLICOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40005C0")]
	public readonly GHCBMLNKBEL FJFPGMLCKFJ;

	[Cpp2IlInjected.Token(Token = "0x6000869")]
	[Cpp2IlInjected.Address(RVA = "0x77AA010", Offset = "0x77A8A10", VA = "0x1877AA010")]
	private LNCELLBJAAM(GOFEHHHEAPL BLKFHFCBEDC, KCDCPHAAIEC JIEIIAKBCDP = KCDCPHAAIEC.Unknown, GHCBMLNKBEL ABPBELJNLKE = GHCBMLNKBEL.Unknown)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086A")]
	[Cpp2IlInjected.Address(RVA = "0x77A9FB0", Offset = "0x77A89B0", VA = "0x1877A9FB0")]
	public static LNCELLBJAAM INJIMBANEAK()
	{
		return default(LNCELLBJAAM);
	}

	[Cpp2IlInjected.Token(Token = "0x600086B")]
	[Cpp2IlInjected.Address(RVA = "0x77A9FF0", Offset = "0x77A89F0", VA = "0x1877A9FF0")]
	public static LNCELLBJAAM NEAININLLBN()
	{
		return default(LNCELLBJAAM);
	}

	[Cpp2IlInjected.Token(Token = "0x600086C")]
	[Cpp2IlInjected.Address(RVA = "0x77A9FD0", Offset = "0x77A89D0", VA = "0x1877A9FD0")]
	public static LNCELLBJAAM JOBPHHGKKFH(KCDCPHAAIEC JIEIIAKBCDP, GHCBMLNKBEL ABPBELJNLKE)
	{
		return default(LNCELLBJAAM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
public enum OMHEEHOFCBL
{
	[Cpp2IlInjected.Token(Token = "0x40005C6")]
	Gold,
	[Cpp2IlInjected.Token(Token = "0x40005C7")]
	Platinum
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
public enum ODLLAJEFDLM
{
	[Cpp2IlInjected.Token(Token = "0x40005C9")]
	Month,
	[Cpp2IlInjected.Token(Token = "0x40005CA")]
	Year,
	[Cpp2IlInjected.Token(Token = "0x40005CB")]
	ThreeMonth,
	[Cpp2IlInjected.Token(Token = "0x40005CC")]
	SixMonth
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
[GBAJJMJPMAP]
public class MJLGNAJLPPF : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000369")]
	public OMHEEHOFCBL HKEIHDLAOHC
	{
		[Cpp2IlInjected.Token(Token = "0x600086D")]
		[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
		[CompilerGenerated]
		get
		{
			return default(OMHEEHOFCBL);
		}
		[Cpp2IlInjected.Token(Token = "0x600086E")]
		[Cpp2IlInjected.Address(RVA = "0xA90060", Offset = "0xA8EA60", VA = "0x180A90060")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700036A")]
	public ODLLAJEFDLM DNLPBPACHII
	{
		[Cpp2IlInjected.Token(Token = "0x600086F")]
		[Cpp2IlInjected.Address(RVA = "0xAD35E0", Offset = "0xAD1FE0", VA = "0x180AD35E0")]
		[CompilerGenerated]
		get
		{
			return default(ODLLAJEFDLM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000870")]
		[Cpp2IlInjected.Address(RVA = "0xB68BB0", Offset = "0xB675B0", VA = "0x180B68BB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700036B")]
	public bool NKEFFKKKHKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000871")]
		[Cpp2IlInjected.Address(RVA = "0xAD3450", Offset = "0xAD1E50", VA = "0x180AD3450")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000872")]
		[Cpp2IlInjected.Address(RVA = "0xA87B30", Offset = "0xA86530", VA = "0x180A87B30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000873")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000874")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public MJLGNAJLPPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
public enum PFOMPMKLKCO
{
	[Cpp2IlInjected.Token(Token = "0x40005D1")]
	Error = -2,
	[Cpp2IlInjected.Token(Token = "0x40005D2")]
	Cancelled,
	[Cpp2IlInjected.Token(Token = "0x40005D3")]
	Uninitialized,
	[Cpp2IlInjected.Token(Token = "0x40005D4")]
	AttemptStarted,
	[Cpp2IlInjected.Token(Token = "0x40005D5")]
	PurchaseComplete
}
[Cpp2IlInjected.Token(Token = "0x200014C")]
[GBAJJMJPMAP]
public class CNPOLEBELBN : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x1700036C")]
	public long NACBGHMIGCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000875")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000876")]
		[Cpp2IlInjected.Address(RVA = "0xE6CA00", Offset = "0xE6B400", VA = "0x180E6CA00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700036D")]
	public long JIJJACLAIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000877")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000878")]
		[Cpp2IlInjected.Address(RVA = "0xDD00C0", Offset = "0xDCEAC0", VA = "0x180DD00C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700036E")]
	public bool HLINABKACKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(RVA = "0xA88540", Offset = "0xA86F40", VA = "0x180A88540")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0xA88520", Offset = "0xA86F20", VA = "0x180A88520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600087B")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600087C")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public CNPOLEBELBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
[GBAJJMJPMAP]
public class JPAPBEAPNJF : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x1700036F")]
	public string NAGMLLAPMPP
	{
		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600087E")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000370")]
	public MKCOGBMHLOI? DGNJEPOPCFP
	{
		[Cpp2IlInjected.Token(Token = "0x600087F")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000371")]
	public IReadOnlyList<MKCOGBMHLOI>? EJKABEELDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000881")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000882")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000372")]
	public IReadOnlyList<string>? CNIMBCGIEMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000373")]
	public BMJOBIOIGNB MHEGDPPAPBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000886")]
		[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000374")]
	public string? BAICENMDMPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000888")]
		[Cpp2IlInjected.Address(RVA = "0xA88310", Offset = "0xA86D10", VA = "0x180A88310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000375")]
	public string? AEGKAAHJMEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0xA91C70", Offset = "0xA90670", VA = "0x180A91C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0xA88530", Offset = "0xA86F30", VA = "0x180A88530")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000376")]
	public string? OLMONOKDAEB
	{
		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0xA88320", Offset = "0xA86D20", VA = "0x180A88320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600088C")]
		[Cpp2IlInjected.Address(RVA = "0xA88300", Offset = "0xA86D00", VA = "0x180A88300")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600088D")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600088E")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public JPAPBEAPNJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
[GBAJJMJPMAP]
public class MEBLDIDJPOO : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000377")]
	public string ECFFFCOHNGB
	{
		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000890")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000378")]
	public MKCOGBMHLOI? DGNJEPOPCFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000891")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000379")]
	public BMJOBIOIGNB MHEGDPPAPBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700037A")]
	public string? AEGKAAHJMEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700037B")]
	public IReadOnlyList<string>? CNIMBCGIEMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000897")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000899")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600089A")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public MEBLDIDJPOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014F")]
[GBAJJMJPMAP]
public class BMJOBIOIGNB : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x1700037C")]
	public string DGCLJDHOCDI
	{
		[Cpp2IlInjected.Token(Token = "0x600089C")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600089D")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700037D")]
	public bool IIJPNPNENPD
	{
		[Cpp2IlInjected.Token(Token = "0x600089E")]
		[Cpp2IlInjected.Address(RVA = "0xAD3450", Offset = "0xAD1E50", VA = "0x180AD3450")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600089F")]
		[Cpp2IlInjected.Address(RVA = "0xA87B30", Offset = "0xA86530", VA = "0x180A87B30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700037E")]
	public bool CCJEOIJODIL
	{
		[Cpp2IlInjected.Token(Token = "0x60008A0")]
		[Cpp2IlInjected.Address(RVA = "0x11F0560", Offset = "0x11EEF60", VA = "0x1811F0560")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008A1")]
		[Cpp2IlInjected.Address(RVA = "0x136B3C0", Offset = "0x1369DC0", VA = "0x18136B3C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700037F")]
	public bool IHCKLMOMENH
	{
		[Cpp2IlInjected.Token(Token = "0x60008A2")]
		[Cpp2IlInjected.Address(RVA = "0x11F0550", Offset = "0x11EEF50", VA = "0x1811F0550")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008A3")]
		[Cpp2IlInjected.Address(RVA = "0x167FFA0", Offset = "0x167E9A0", VA = "0x18167FFA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000380")]
	public bool KOGNIONDMDN
	{
		[Cpp2IlInjected.Token(Token = "0x60008A4")]
		[Cpp2IlInjected.Address(RVA = "0x11F0540", Offset = "0x11EEF40", VA = "0x1811F0540")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0x54E4AA0", Offset = "0x54E34A0", VA = "0x1854E4AA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000381")]
	public bool GKDDPIOKLGI
	{
		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0xB3DD70", Offset = "0xB3C770", VA = "0x180B3DD70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0xE64D60", Offset = "0xE63760", VA = "0x180E64D60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000382")]
	public bool JKMLLNOLGEP
	{
		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0xB3DB20", Offset = "0xB3C520", VA = "0x180B3DB20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0xE64620", Offset = "0xE63020", VA = "0x180E64620")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000383")]
	public bool KGJBPHLPOOM
	{
		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0x1AD4240", Offset = "0x1AD2C40", VA = "0x181AD4240")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0x77A15F0", Offset = "0x779FFF0", VA = "0x1877A15F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000384")]
	public bool BADLFHIOPKP
	{
		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0x1AC8E50", Offset = "0x1AC7850", VA = "0x181AC8E50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x77A15E0", Offset = "0x779FFE0", VA = "0x1877A15E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000385")]
	public bool LMLIJFFENGC
	{
		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0xA88540", Offset = "0xA86F40", VA = "0x180A88540")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008AF")]
		[Cpp2IlInjected.Address(RVA = "0xA88520", Offset = "0xA86F20", VA = "0x180A88520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000386")]
	public bool FAFMLLCKFII
	{
		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0x1550C40", Offset = "0x154F640", VA = "0x181550C40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008B1")]
		[Cpp2IlInjected.Address(RVA = "0x1550630", Offset = "0x154F030", VA = "0x181550630")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000387")]
	public bool FIDGINALKNG
	{
		[Cpp2IlInjected.Token(Token = "0x60008B2")]
		[Cpp2IlInjected.Address(RVA = "0x1644F80", Offset = "0x1643980", VA = "0x181644F80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008B3")]
		[Cpp2IlInjected.Address(RVA = "0x1644A80", Offset = "0x1643480", VA = "0x181644A80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600089B")]
	[Cpp2IlInjected.Address(RVA = "0x77A1600", Offset = "0x77A0000", VA = "0x1877A1600")]
	public BMJOBIOIGNB(string OPPCJOOOMCK, bool JLKONMMPDJK, bool CEJHNKODCEP, bool LMPMONEJCFE, bool GICJFGIGHCJ, bool AIMJLOBNOED, bool HCDMFHMJBOI, bool AOAJNDECCMJ, bool ODEINKHCJMP, bool PCMGAIMAHGM, bool LPFNNJDKDLK, bool HLLIGNGMALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008B4")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
[GBAJJMJPMAP]
public class EJJADPBBNEN : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000388")]
	public string DKONBFIGNPP
	{
		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000389")]
	public string OLMONOKDAEB
	{
		[Cpp2IlInjected.Token(Token = "0x60008B7")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700038A")]
	public string BAICENMDMPD
	{
		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700038B")]
	public string? BAFEOFHLKJK
	{
		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008BC")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700038C")]
	public string? JECDNPKCIDA
	{
		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700038D")]
	public float BIBPAIENHOP
	{
		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0xAD7480", Offset = "0xAD5E80", VA = "0x180AD7480")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0x1EB7C90", Offset = "0x1EB6690", VA = "0x181EB7C90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008C1")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C2")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public EJJADPBBNEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000151")]
[GBAJJMJPMAP]
public class KOEEDNDNMPP : ONFKIGFCODK, BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x1700038E")]
	public string OKBODONOABJ
	{
		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700038F")]
	public string MDABHBMBNMK
	{
		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008C6")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008C7")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "6")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C8")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public KOEEDNDNMPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000152")]
[GBAJJMJPMAP]
public class JMPMEJJEJHN : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000390")]
	public Guid EBBOFFBBJHK
	{
		[Cpp2IlInjected.Token(Token = "0x60008C9")]
		[Cpp2IlInjected.Address(RVA = "0xE823D0", Offset = "0xE80DD0", VA = "0x180E823D0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60008CA")]
		[Cpp2IlInjected.Address(RVA = "0xE823E0", Offset = "0xE80DE0", VA = "0x180E823E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000391")]
	public long EDCJBBOOIBH
	{
		[Cpp2IlInjected.Token(Token = "0x60008CB")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60008CC")]
		[Cpp2IlInjected.Address(RVA = "0xDED820", Offset = "0xDEC220", VA = "0x180DED820")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000392")]
	public long PEAPNNKOAII
	{
		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0xA882F0", Offset = "0xA86CF0", VA = "0x180A882F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000393")]
	public decimal PHLCEMFIDMK
	{
		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0xF371D0", Offset = "0xF35BD0", VA = "0x180F371D0")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0xF36610", Offset = "0xF35010", VA = "0x180F36610")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008D1")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D2")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public JMPMEJJEJHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000153")]
[GBAJJMJPMAP]
public class JMCEAPBEKDB : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000394")]
	public string OKBODONOABJ
	{
		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000395")]
	public string DCGJHMLFOHP
	{
		[Cpp2IlInjected.Token(Token = "0x60008D5")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008D7")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public JMCEAPBEKDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D8")]
	[Cpp2IlInjected.Address(RVA = "0xA93780", Offset = "0xA92180", VA = "0x180A93780")]
	public JMCEAPBEKDB(string NECAJFCJIIO, string KPNCALHOBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D9")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000154")]
[GBAJJMJPMAP]
public class EPIAOEJAGFI : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000396")]
	public string OLMONOKDAEB
	{
		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000397")]
	public string NAGMLLAPMPP
	{
		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000398")]
	public bool LJMIOGDHEPK
	{
		[Cpp2IlInjected.Token(Token = "0x60008DE")]
		[Cpp2IlInjected.Address(RVA = "0xA88540", Offset = "0xA86F40", VA = "0x180A88540")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008DF")]
		[Cpp2IlInjected.Address(RVA = "0xA88520", Offset = "0xA86F20", VA = "0x180A88520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008E0")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E1")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public EPIAOEJAGFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000155")]
[GBAJJMJPMAP]
public class FDHOCGNPFGL : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x17000399")]
	public string ILJJIFMFDNG
	{
		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700039A")]
	public decimal KBBOGECNPKO
	{
		[Cpp2IlInjected.Token(Token = "0x60008E4")]
		[Cpp2IlInjected.Address(RVA = "0xD5CF80", Offset = "0xD5B980", VA = "0x180D5CF80")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x60008E5")]
		[Cpp2IlInjected.Address(RVA = "0xF32710", Offset = "0xF31110", VA = "0x180F32710")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008E6")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E7")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public FDHOCGNPFGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
[GBAJJMJPMAP]
public class CKONGKBEDLM : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x1700039B")]
	public string OLMONOKDAEB
	{
		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700039C")]
	public string NAGMLLAPMPP
	{
		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008EB")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700039D")]
	public string FFNFDNMEMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008ED")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008EE")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008EF")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public CKONGKBEDLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000157")]
[GBAJJMJPMAP]
public class AKNMNKMOLNO : OLAEIDEEHDL
{
	[Cpp2IlInjected.Token(Token = "0x60008F0")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public AKNMNKMOLNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000158")]
[GBAJJMJPMAP]
public class HBBEHNJNFPA : CJCBFAIPFPD
{
	[Cpp2IlInjected.Token(Token = "0x60008F1")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public HBBEHNJNFPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000159")]
[GBAJJMJPMAP]
public class BCAJFLGHJIN : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x1700039E")]
	public string BMEFPAKGMBA
	{
		[Cpp2IlInjected.Token(Token = "0x60008F2")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008F3")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700039F")]
	public string NAGMLLAPMPP
	{
		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A0")]
	public bool KCAFBIABBBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60008F6")]
		[Cpp2IlInjected.Address(RVA = "0xA88540", Offset = "0xA86F40", VA = "0x180A88540")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008F7")]
		[Cpp2IlInjected.Address(RVA = "0xA88520", Offset = "0xA86F20", VA = "0x180A88520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008F8")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F9")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public BCAJFLGHJIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015A")]
[GBAJJMJPMAP]
public class NIOEIIAFNDL : BCAJFLGHJIN
{
	[Cpp2IlInjected.Token(Token = "0x170003A1")]
	public string HHBAAHCOJDA
	{
		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008FC")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public NIOEIIAFNDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015B")]
[GBAJJMJPMAP]
public class MILKDBJMEFG : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x170003A2")]
	public long IAOBKFIFFHL
	{
		[Cpp2IlInjected.Token(Token = "0x60008FD")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60008FE")]
		[Cpp2IlInjected.Address(RVA = "0xE6CA00", Offset = "0xE6B400", VA = "0x180E6CA00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A3")]
	public string BMEFPAKGMBA
	{
		[Cpp2IlInjected.Token(Token = "0x60008FF")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000900")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A4")]
	public GDBLFANDBKC LGMONJMDHHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000901")]
		[Cpp2IlInjected.Address(RVA = "0xAE0120", Offset = "0xADEB20", VA = "0x180AE0120")]
		[CompilerGenerated]
		get
		{
			return default(GDBLFANDBKC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0xAE0110", Offset = "0xADEB10", VA = "0x180AE0110")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A5")]
	public Guid? IAGHKHMHFCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0x77AA1D0", Offset = "0x77A8BD0", VA = "0x1877AA1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0x77AA1F0", Offset = "0x77A8BF0", VA = "0x1877AA1F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A6")]
	public string? LCJLHJMICPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000906")]
		[Cpp2IlInjected.Address(RVA = "0xA88310", Offset = "0xA86D10", VA = "0x180A88310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000907")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000908")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public MILKDBJMEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015C")]
public enum GDBLFANDBKC
{
	[Cpp2IlInjected.Token(Token = "0x4000612")]
	Requested = 0,
	[Cpp2IlInjected.Token(Token = "0x4000613")]
	ProviderMeshRequested = 1,
	[Cpp2IlInjected.Token(Token = "0x4000614")]
	ProviderMeshGenerated = 2,
	[Cpp2IlInjected.Token(Token = "0x4000615")]
	ProviderMeshGenFailed = 3,
	[Cpp2IlInjected.Token(Token = "0x4000616")]
	CloudBuildRequested = 11,
	[Cpp2IlInjected.Token(Token = "0x4000617")]
	CloudBuildCompleted = 12,
	[Cpp2IlInjected.Token(Token = "0x4000618")]
	CloudBuildFailed = 13,
	[Cpp2IlInjected.Token(Token = "0x4000619")]
	MeshGenCompleted = 21,
	[Cpp2IlInjected.Token(Token = "0x400061A")]
	ImageReferenceRequested = 31,
	[Cpp2IlInjected.Token(Token = "0x400061B")]
	ImageReferenceGenerated = 32,
	[Cpp2IlInjected.Token(Token = "0x400061C")]
	ImageReferenceGenerationFailed = 33
}
[Cpp2IlInjected.Token(Token = "0x200015D")]
[GBAJJMJPMAP]
public class DIKFLOHBNDA : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x170003A7")]
	public string? OLMONOKDAEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000909")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A8")]
	public string NAGMLLAPMPP
	{
		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600090D")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090E")]
	[Cpp2IlInjected.Address(RVA = "0x77A2820", Offset = "0x77A1220", VA = "0x1877A2820")]
	public DIKFLOHBNDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
[GBAJJMJPMAP]
public class CJCBFAIPFPD : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x170003A9")]
	public string OLMONOKDAEB
	{
		[Cpp2IlInjected.Token(Token = "0x600090F")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003AA")]
	public string NAGMLLAPMPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000913")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000914")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public CJCBFAIPFPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015F")]
[GBAJJMJPMAP]
public class OLAEIDEEHDL : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x170003AB")]
	public List<string> PBOILHAKLEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003AC")]
	public decimal NLOLLHGOPGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000917")]
		[Cpp2IlInjected.Address(RVA = "0xD5CF80", Offset = "0xD5B980", VA = "0x180D5CF80")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0xF32710", Offset = "0xF31110", VA = "0x180F32710")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000919")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600091A")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public OLAEIDEEHDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000160")]
[GBAJJMJPMAP]
public class BJMFAKIJGJK : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x170003AD")]
	public int BIKKNIIFDAP
	{
		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600091C")]
		[Cpp2IlInjected.Address(RVA = "0xA90060", Offset = "0xA8EA60", VA = "0x180A90060")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003AE")]
	public string MMPEDFAPIKH
	{
		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600091E")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003AF")]
	public string? FAHMGKIDCFD
	{
		[Cpp2IlInjected.Token(Token = "0x600091F")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000920")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B0")]
	public IReadOnlyList<int> GHMHBPAAEEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B1")]
	public string? PFMCMCBJOAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000925")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000926")]
	[Cpp2IlInjected.Address(RVA = "0x77A1550", Offset = "0x779FF50", VA = "0x1877A1550")]
	public BJMFAKIJGJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000161")]
[GBAJJMJPMAP]
public class JGLDDKJHEHN : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x170003B2")]
	public int BIKKNIIFDAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000927")]
		[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000928")]
		[Cpp2IlInjected.Address(RVA = "0xA90060", Offset = "0xA8EA60", VA = "0x180A90060")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B3")]
	public Guid? NCGACMONDNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0x24765A0", Offset = "0x2474FA0", VA = "0x1824765A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x2476280", Offset = "0x2474C80", VA = "0x182476280")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B4")]
	public string MMPEDFAPIKH
	{
		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B5")]
	public List<BJMFAKIJGJK> ADGCIFKJEPH
	{
		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600092E")]
		[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B6")]
	public List<BJMFAKIJGJK> LPACNNPHKPN
	{
		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0xA88310", Offset = "0xA86D10", VA = "0x180A88310")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B7")]
	public string? FAHMGKIDCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0xA91C70", Offset = "0xA90670", VA = "0x180A91C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000932")]
		[Cpp2IlInjected.Address(RVA = "0xA88530", Offset = "0xA86F30", VA = "0x180A88530")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B8")]
	public string? PFMCMCBJOAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0xA88320", Offset = "0xA86D20", VA = "0x180A88320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(RVA = "0xA88300", Offset = "0xA86D00", VA = "0x180A88300")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B9")]
	public string? LEGADCGPLND
	{
		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0xA84210", Offset = "0xA82C10", VA = "0x180A84210")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0xA84220", Offset = "0xA82C20", VA = "0x180A84220")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000937")]
	[Cpp2IlInjected.Address(RVA = "0x77A6FC0", Offset = "0x77A59C0", VA = "0x1877A6FC0", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000938")]
	[Cpp2IlInjected.Address(RVA = "0x77A6FF0", Offset = "0x77A59F0", VA = "0x1877A6FF0")]
	public JGLDDKJHEHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000162")]
[GBAJJMJPMAP]
public class FNAGEGKBKOE : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x170003BA")]
	public string FAHMGKIDCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000939")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003BB")]
	public JGLDDKJHEHN ADGCIFKJEPH
	{
		[Cpp2IlInjected.Token(Token = "0x600093B")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003BC")]
	public JGLDDKJHEHN LPACNNPHKPN
	{
		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003BD")]
	public string? LEGADCGPLND
	{
		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000941")]
	[Cpp2IlInjected.Address(RVA = "0x77A4B30", Offset = "0x77A3530", VA = "0x1877A4B30", Slot = "5")]
	public virtual void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000942")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public FNAGEGKBKOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
[GBAJJMJPMAP]
public class AINLCAFNMJB : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x170003BE")]
	public string FAHMGKIDCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000943")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000944")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003BF")]
	public IReadOnlyList<JGLDDKJHEHN> GDIHEFGEIFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000945")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C0")]
	public IReadOnlyList<FNAGEGKBKOE> IHBECGLMPNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000948")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C1")]
	public IReadOnlyList<AINLCAFNMJB> DEGCHGJEIPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000949")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C2")]
	public string? LEGADCGPLND
	{
		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600094C")]
		[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600094D")]
	[Cpp2IlInjected.Address(RVA = "0x77A0B70", Offset = "0x779F570", VA = "0x1877A0B70", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600094E")]
	[Cpp2IlInjected.Address(RVA = "0x77A0BA0", Offset = "0x779F5A0", VA = "0x1877A0BA0")]
	public AINLCAFNMJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
[GBAJJMJPMAP]
public class DNMFHMFOOBN : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x4000639")]
	public const string MNLEKMFPMIF = "REPL_";

	[Cpp2IlInjected.Token(Token = "0x170003C3")]
	public string BIKKNIIFDAP
	{
		[Cpp2IlInjected.Token(Token = "0x600094F")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000950")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C4")]
	public int EKKDDMAKOKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000951")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5C0", Offset = "0xA8CFC0", VA = "0x180A8E5C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000952")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5D0", Offset = "0xA8CFD0", VA = "0x180A8E5D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000953")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000954")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public DNMFHMFOOBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
[GBAJJMJPMAP]
public class MKCOGBMHLOI : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x170003C5")]
	public int? OFFMBGPIJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000955")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000956")]
		[Cpp2IlInjected.Address(RVA = "0xE6CA00", Offset = "0xE6B400", VA = "0x180E6CA00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C6")]
	public string? IOJKCHKKDHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000957")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000958")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C7")]
	public string FAHMGKIDCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000959")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600095A")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C8")]
	public string MMPEDFAPIKH
	{
		[Cpp2IlInjected.Token(Token = "0x600095B")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600095C")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C9")]
	public List<MKCOGBMHLOI>? PGBFILJDFEE
	{
		[Cpp2IlInjected.Token(Token = "0x600095D")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600095E")]
		[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003CA")]
	public DNMFHMFOOBN? HCLACCMDLAB
	{
		[Cpp2IlInjected.Token(Token = "0x600095F")]
		[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000960")]
		[Cpp2IlInjected.Address(RVA = "0xA88310", Offset = "0xA86D10", VA = "0x180A88310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000961")]
	[Cpp2IlInjected.Address(RVA = "0x77AA740", Offset = "0x77A9140", VA = "0x1877AA740", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000962")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public MKCOGBMHLOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000166")]
[GBAJJMJPMAP]
public class ONFKBGIDPIP : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x170003CB")]
	public string GMECNKLMKFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000963")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000964")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003CC")]
	public string HAHGLCJCMKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000965")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000966")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000967")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000968")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public ONFKBGIDPIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000167")]
[GBAJJMJPMAP]
public class GDEIIPFPKCI : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x170003CD")]
	public string BIKKNIIFDAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000969")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003CE")]
	public AINLCAFNMJB OPNPLMAOFCM
	{
		[Cpp2IlInjected.Token(Token = "0x600096B")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600096C")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003CF")]
	public MKCOGBMHLOI? DGNJEPOPCFP
	{
		[Cpp2IlInjected.Token(Token = "0x600096D")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600096E")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D0")]
	public List<MKCOGBMHLOI>? EJKABEELDPE
	{
		[Cpp2IlInjected.Token(Token = "0x600096F")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000970")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D1")]
	public IReadOnlyList<JGLDDKJHEHN> OKFKKEOIOMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000971")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000972")]
		[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D2")]
	public IReadOnlyList<ONFKBGIDPIP> NKMCFJLPAHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000973")]
		[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000974")]
		[Cpp2IlInjected.Address(RVA = "0xA88310", Offset = "0xA86D10", VA = "0x180A88310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D3")]
	public string? ECFFFCOHNGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000975")]
		[Cpp2IlInjected.Address(RVA = "0xA91C70", Offset = "0xA90670", VA = "0x180A91C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000976")]
		[Cpp2IlInjected.Address(RVA = "0xA88530", Offset = "0xA86F30", VA = "0x180A88530")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000977")]
	[Cpp2IlInjected.Address(RVA = "0x77A5000", Offset = "0x77A3A00", VA = "0x1877A5000", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000978")]
	[Cpp2IlInjected.Address(RVA = "0x77A5090", Offset = "0x77A3A90", VA = "0x1877A5090")]
	public GDEIIPFPKCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000168")]
[GBAJJMJPMAP]
public class PPGAABIGHIL : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x170003D4")]
	public AMBDMJNECED<GDEIIPFPKCI> CBAAPALEPCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000979")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600097A")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D5")]
	public decimal CNDBHODELNB
	{
		[Cpp2IlInjected.Token(Token = "0x600097B")]
		[Cpp2IlInjected.Address(RVA = "0xD5CF80", Offset = "0xD5B980", VA = "0x180D5CF80")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x600097C")]
		[Cpp2IlInjected.Address(RVA = "0xF32710", Offset = "0xF31110", VA = "0x180F32710")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600097D")]
	[Cpp2IlInjected.Address(RVA = "0x76AAFF0", Offset = "0x76A99F0", VA = "0x1876AAFF0", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097E")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public PPGAABIGHIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000169")]
public enum NKBOOLCPJKN
{
	[Cpp2IlInjected.Token(Token = "0x400064E")]
	Empty,
	[Cpp2IlInjected.Token(Token = "0x400064F")]
	Low,
	[Cpp2IlInjected.Token(Token = "0x4000650")]
	Good
}
[Cpp2IlInjected.Token(Token = "0x200016A")]
[GBAJJMJPMAP]
public class KKNBIACAFFG : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x170003D6")]
	public NKBOOLCPJKN KPDCDHDJJJL
	{
		[Cpp2IlInjected.Token(Token = "0x600097F")]
		[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
		[CompilerGenerated]
		get
		{
			return default(NKBOOLCPJKN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000980")]
		[Cpp2IlInjected.Address(RVA = "0xA90060", Offset = "0xA8EA60", VA = "0x180A90060")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D7")]
	public DateTime CNNPHPDGHOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000981")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000982")]
		[Cpp2IlInjected.Address(RVA = "0xDD00C0", Offset = "0xDCEAC0", VA = "0x180DD00C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000983")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000984")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public KKNBIACAFFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016B")]
[GBAJJMJPMAP]
public class BCOKCNDFNPB : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x170003D8")]
	public NKBOOLCPJKN BFONOOKMJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
		[CompilerGenerated]
		get
		{
			return default(NKBOOLCPJKN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000986")]
		[Cpp2IlInjected.Address(RVA = "0xA90060", Offset = "0xA8EA60", VA = "0x180A90060")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D9")]
	public float HHCBOCKOCBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000987")]
		[Cpp2IlInjected.Address(RVA = "0xE64270", Offset = "0xE62C70", VA = "0x180E64270")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000988")]
		[Cpp2IlInjected.Address(RVA = "0xE641F0", Offset = "0xE62BF0", VA = "0x180E641F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000989")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098A")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public BCOKCNDFNPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016C")]
[GBAJJMJPMAP]
public class NCHGPBGLEKP : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x170003DA")]
	public NKBOOLCPJKN KPDCDHDJJJL
	{
		[Cpp2IlInjected.Token(Token = "0x600098B")]
		[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
		[CompilerGenerated]
		get
		{
			return default(NKBOOLCPJKN);
		}
		[Cpp2IlInjected.Token(Token = "0x600098C")]
		[Cpp2IlInjected.Address(RVA = "0xA90060", Offset = "0xA8EA60", VA = "0x180A90060")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003DB")]
	public DateTime CNNPHPDGHOP
	{
		[Cpp2IlInjected.Token(Token = "0x600098D")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600098E")]
		[Cpp2IlInjected.Address(RVA = "0xDD00C0", Offset = "0xDCEAC0", VA = "0x180DD00C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003DC")]
	public NKBOOLCPJKN BFONOOKMJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600098F")]
		[Cpp2IlInjected.Address(RVA = "0xAE0120", Offset = "0xADEB20", VA = "0x180AE0120")]
		[CompilerGenerated]
		get
		{
			return default(NKBOOLCPJKN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000990")]
		[Cpp2IlInjected.Address(RVA = "0xAE0110", Offset = "0xADEB10", VA = "0x180AE0110")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003DD")]
	public float HHCBOCKOCBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000991")]
		[Cpp2IlInjected.Address(RVA = "0xADFF60", Offset = "0xADE960", VA = "0x180ADFF60")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000992")]
		[Cpp2IlInjected.Address(RVA = "0xAE0130", Offset = "0xADEB30", VA = "0x180AE0130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003DE")]
	public NKBOOLCPJKN OKANCAAIGIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000993")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5B0", Offset = "0xA8CFB0", VA = "0x180A8E5B0")]
		[CompilerGenerated]
		get
		{
			return default(NKBOOLCPJKN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000994")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5E0", Offset = "0xA8CFE0", VA = "0x180A8E5E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003DF")]
	public float OOCFDIDBNNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000995")]
		[Cpp2IlInjected.Address(RVA = "0xD796D0", Offset = "0xD780D0", VA = "0x180D796D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000996")]
		[Cpp2IlInjected.Address(RVA = "0xD796E0", Offset = "0xD780E0", VA = "0x180D796E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000997")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000998")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public NCHGPBGLEKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016D")]
[GBAJJMJPMAP]
public class KCOINKEJNGD : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x170003E0")]
	public TimeSpan HGEKPJDKOGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000999")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0xE6CA00", Offset = "0xE6B400", VA = "0x180E6CA00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E1")]
	public TimeSpan KIMCDAPLFNI
	{
		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x600099C")]
		[Cpp2IlInjected.Address(RVA = "0xDD00C0", Offset = "0xDCEAC0", VA = "0x180DD00C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600099D")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600099E")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public KCOINKEJNGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016E")]
[GBAJJMJPMAP]
public class CMGNDIMJCGO : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x170003E2")]
	public List<string> BHKLFFIKDPE
	{
		[Cpp2IlInjected.Token(Token = "0x600099F")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009A0")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009A1")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A2")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public CMGNDIMJCGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016F")]
[GBAJJMJPMAP]
public class PKMKBAGDJDH : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x170003E3")]
	public string? OLMONOKDAEB
	{
		[Cpp2IlInjected.Token(Token = "0x60009A3")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009A4")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E4")]
	public string ADGCIFKJEPH
	{
		[Cpp2IlInjected.Token(Token = "0x60009A5")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009A6")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E5")]
	public string BAFEOFHLKJK
	{
		[Cpp2IlInjected.Token(Token = "0x60009A7")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009A8")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E6")]
	public string LPMLPPCDCKP
	{
		[Cpp2IlInjected.Token(Token = "0x60009A9")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009AA")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E7")]
	public string? BAICENMDMPD
	{
		[Cpp2IlInjected.Token(Token = "0x60009AB")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009AC")]
		[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E8")]
	public bool CONOKPPIIAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60009AD")]
		[Cpp2IlInjected.Address(RVA = "0xAE6140", Offset = "0xAE4B40", VA = "0x180AE6140")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0xAE6AC0", Offset = "0xAE54C0", VA = "0x180AE6AC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009AF")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B0")]
	[Cpp2IlInjected.Address(RVA = "0x77AC1D0", Offset = "0x77AABD0", VA = "0x1877AC1D0")]
	public PKMKBAGDJDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000170")]
public class APFCNHCJCNK
{
	[Cpp2IlInjected.Token(Token = "0x170003E9")]
	public decimal NLOLLHGOPGE
	{
		[Cpp2IlInjected.Token(Token = "0x60009B1")]
		[Cpp2IlInjected.Address(RVA = "0xE823D0", Offset = "0xE80DD0", VA = "0x180E823D0")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x60009B2")]
		[Cpp2IlInjected.Address(RVA = "0xE823E0", Offset = "0xE80DE0", VA = "0x180E823E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009B3")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public APFCNHCJCNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000171")]
[GBAJJMJPMAP]
public class GNGCPLCCEOB : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x170003EA")]
	public OONMGGAOEHG JDDNMHJPHNF
	{
		[Cpp2IlInjected.Token(Token = "0x60009B4")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009B5")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003EB")]
	public NKBOOLCPJKN CGHKINCJAOK
	{
		[Cpp2IlInjected.Token(Token = "0x60009B6")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5C0", Offset = "0xA8CFC0", VA = "0x180A8E5C0")]
		[CompilerGenerated]
		get
		{
			return default(NKBOOLCPJKN);
		}
		[Cpp2IlInjected.Token(Token = "0x60009B7")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5D0", Offset = "0xA8CFD0", VA = "0x180A8E5D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003EC")]
	public long? EAHCEIPIOHC
	{
		[Cpp2IlInjected.Token(Token = "0x60009B8")]
		[Cpp2IlInjected.Address(RVA = "0xE7AD80", Offset = "0xE79780", VA = "0x180E7AD80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009B9")]
		[Cpp2IlInjected.Address(RVA = "0xF67A70", Offset = "0xF66470", VA = "0x180F67A70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003ED")]
	public DateTime? JOFKIBOAFGD
	{
		[Cpp2IlInjected.Token(Token = "0x60009BA")]
		[Cpp2IlInjected.Address(RVA = "0xF371D0", Offset = "0xF35BD0", VA = "0x180F371D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009BB")]
		[Cpp2IlInjected.Address(RVA = "0xF36610", Offset = "0xF35010", VA = "0x180F36610")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003EE")]
	public long? PNBIKEEHLBB
	{
		[Cpp2IlInjected.Token(Token = "0x60009BC")]
		[Cpp2IlInjected.Address(RVA = "0x1067F60", Offset = "0x1066960", VA = "0x181067F60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009BD")]
		[Cpp2IlInjected.Address(RVA = "0x1067F70", Offset = "0x1066970", VA = "0x181067F70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009BE")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009BF")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public GNGCPLCCEOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000172")]
[GBAJJMJPMAP]
public class OLANNPDLELE : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x170003EF")]
	public List<HKALBNAMJPP> KOOOKNANMKL
	{
		[Cpp2IlInjected.Token(Token = "0x60009C0")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009C1")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009C2")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C3")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public OLANNPDLELE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000173")]
[GBAJJMJPMAP]
public class HKALBNAMJPP : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x170003F0")]
	public string GEMGJEOJFII
	{
		[Cpp2IlInjected.Token(Token = "0x60009C4")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009C5")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009C6")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C7")]
	[Cpp2IlInjected.Address(RVA = "0x77A5670", Offset = "0x77A4070", VA = "0x1877A5670")]
	public HKALBNAMJPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
[GBAJJMJPMAP]
public class IMBMPFGMCND : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x170003F1")]
	public List<COIJMLNEIPF> IDCGONDADCK
	{
		[Cpp2IlInjected.Token(Token = "0x60009C8")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009C9")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003F2")]
	public string BHJCDJKKNIH
	{
		[Cpp2IlInjected.Token(Token = "0x60009CA")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009CB")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009CC")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CD")]
	[Cpp2IlInjected.Address(RVA = "0x77A66D0", Offset = "0x77A50D0", VA = "0x1877A66D0")]
	public IMBMPFGMCND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
[GBAJJMJPMAP]
public class COIJMLNEIPF : BHOLJOIPLEN
{
	[Cpp2IlInjected.Token(Token = "0x170003F3")]
	public string BIKKNIIFDAP
	{
		[Cpp2IlInjected.Token(Token = "0x60009CF")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009D0")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003F4")]
	public string BHFKNCPNFLN
	{
		[Cpp2IlInjected.Token(Token = "0x60009D1")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009D2")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003F5")]
	public string KLFJJPNGIKE
	{
		[Cpp2IlInjected.Token(Token = "0x60009D3")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009D4")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003F6")]
	public string NDEOMOACOKA
	{
		[Cpp2IlInjected.Token(Token = "0x60009D5")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009D6")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003F7")]
	public DateTime NEFPGADCCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60009D7")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60009D8")]
		[Cpp2IlInjected.Address(RVA = "0xA882E0", Offset = "0xA86CE0", VA = "0x180A882E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009CE")]
	[Cpp2IlInjected.Address(RVA = "0xA93860", Offset = "0xA92260", VA = "0x180A93860")]
	public COIJMLNEIPF(string EGJGKBPPPFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D9")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void MCAPBBPIBEB()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000176")]
public class IFNBIANOKDF
{
	[Cpp2IlInjected.Token(Token = "0x60009DA")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public IFNBIANOKDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DB")]
	[Cpp2IlInjected.Address(RVA = "0x74C9350", Offset = "0x74C7D50", VA = "0x1874C9350")]
	public static string GGPGCGCJOGI(byte[] JCBPHBFKIAN, byte[] NOFNICNJALD)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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
