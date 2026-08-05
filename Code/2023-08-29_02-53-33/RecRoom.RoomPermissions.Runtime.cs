using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7F1AF0", Offset = "0x7F0EF0", VA = "0x1807F1AF0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x658C740", Offset = "0x658BB40", VA = "0x18658C740")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D1B70", Offset = "0x8D0F70", VA = "0x1808D1B70")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9D7910", Offset = "0x9D6D10", VA = "0x1809D7910")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum LHBEIAOLDCO
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface NJMPNDIFJJL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	GPHDOINNIHD FHMFNLJMCEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<KKHNEDKEAMB> BKDPNJCCBMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event GDMIJNLOCDJ LBBEPLGLPHK;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<KKHNEDKEAMB> PGLOMFDGCJM(bool EPCKNNGGGCM = false);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KKHNEDKEAMB MAEEBACOPME(KAPKJIFIGFH IDPCHCFPHDE);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NGBJANOHLMB(KAPKJIFIGFH IDPCHCFPHDE);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<KKHNEDKEAMB> DNKBJEDIBHI(KAPKJIFIGFH IDPCHCFPHDE, bool BHGPDENOOKN = false);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool KNDJHFJLLMK(KAPKJIFIGFH LOBPHBALKHN, DMEKLMHPMFA BCJPDDIEKHE);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	KKHNEDKEAMB LCNDCJOGKBM(DMEKLMHPMFA BCJPDDIEKHE);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool GALFLANHIHJ<T>(DMEKLMHPMFA BCJPDDIEKHE, KECOHBBAEKF JIGEOBHPABG, bool HNPNLKMAHOH, T FADMIIJIPLK) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface IDBDBAFPNOF
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task EPJIKGBOFJI(MKMOLMPLENB NBHAPFMEJDI, CancellationToken DNKHCCGNODC);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LHEDEKEFFDB(ref MKMOLMPLENB NBHAPFMEJDI);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface OBLEFEMOINN
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool AAKDCDMKENL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool BIJLJKBMFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool GNNDKPKLNMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool IMJCFGBBEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool CGLGCADFILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool AJJLFCGGNCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class PDIKJJKLIOM
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly IReadOnlyList<DMEKLMHPMFA> OBIOFDCKDIG;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x658C850", Offset = "0x658BC50", VA = "0x18658C850")]
	public static bool FEBCPMDKBDG(this KAPKJIFIGFH FDACAGLMNOO, DMEKLMHPMFA BCJPDDIEKHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x658C7D0", Offset = "0x658BBD0", VA = "0x18658C7D0")]
	public static bool BHLMDPBJLHD(this KAPKJIFIGFH FDACAGLMNOO, DMEKLMHPMFA BCJPDDIEKHE, GKENAAINMOP MIMCBAHMACL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class GODNHJLKMIG : DMNOOBMPODN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly NJMPNDIFJJL GGMFJOFLAGG;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7FF090", Offset = "0x7FE490", VA = "0x1807FF090")]
	[RecRoom.NoEngine.Common.Preserve]
	public GODNHJLKMIG([EPGFAMNCJKC(null)] NJMPNDIFJJL BEFHMDAJKHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6584D70", Offset = "0x6584170", VA = "0x186584D70")]
	private static LGJMOMGMKCC? NHABKNLOFFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6584DC0", Offset = "0x65841C0", VA = "0x186584DC0", Slot = "4")]
	public bool PDOOMLPNIIH(KAPKJIFIGFH EBGAPPEIEMN, KAPKJIFIGFH FHNPPLNFGJB, IEnumerable<KAPKJIFIGFH> HJKNHPGLNBI, out LHBEIAOLDCO ELKDGONIECD, out KDJJHEPPNII PIEBIKCHHAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6584840", Offset = "0x6583C40", VA = "0x186584840")]
	internal bool EFCHKBOMKHF(KAPKJIFIGFH EBGAPPEIEMN, KAPKJIFIGFH FHNPPLNFGJB, IEnumerable<KAPKJIFIGFH> HJKNHPGLNBI, GKENAAINMOP MIMCBAHMACL, LGJMOMGMKCC? GNAKAIBDKBI, out LHBEIAOLDCO ELKDGONIECD, out KDJJHEPPNII PIEBIKCHHAI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KOKLKDJNKCC<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	string HEBLBNBJLKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event EMCHIJOPMNA<TPermission> KIEHPKOANJH;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public delegate void EMCHIJOPMNA<TPermission>(TPermission JIGEOBHPABG);
[Cpp2IlInjected.Token(Token = "0x200000E")]
public delegate void GDMIJNLOCDJ(KAPKJIFIGFH IDPCHCFPHDE);
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class FOAGDIILAPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly string MCNCONKIDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public readonly Type JHNMECKKGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly CHBCBEPKDJO ADDNJFEICGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly KECOHBBAEKF OJANJDNBCKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public GPMFJIPGGHI HMMGBPHNIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public GPDMAAAONEB ECPMFDAPPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public AFCNJLKDMPH MCFBMDLBAFN;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x65847B0", Offset = "0x6583BB0", VA = "0x1865847B0")]
	public FOAGDIILAPH(Type IAGAMDKPNML, string DIHEMHKOJAD, KECOHBBAEKF JIGEOBHPABG, GPMFJIPGGHI JNDAMNDEHGB, GPDMAAAONEB EHBAJLGECNP, AFCNJLKDMPH AHPIDBONKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6584770", Offset = "0x6583B70", VA = "0x186584770")]
	public object ICNJDEJCAKN(object? LNOOAJJNCAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1967570", Offset = "0x1966970", VA = "0x181967570")]
	public void HLIEFJNHCEA<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x65846C0", Offset = "0x6583AC0", VA = "0x1865846C0")]
	public void HLIEFJNHCEA(Type LOMHDNBMMEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class KOMDHCCOBME<T> : FOAGDIILAPH where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal delegate string IFMBCLMJDKD(T KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal delegate T FJFFCIMECAN(string? LMEELMGGLDA, T OLNFJPNAOBM);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class FIFNDGHKPOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public IFMBCLMJDKD serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public FJFFCIMECAN parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public FIFNDGHKPOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3476BF0", Offset = "0x3475FF0", VA = "0x183476BF0")]
		internal string MNICOLMCAIE(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3476B70", Offset = "0x3475F70", VA = "0x183476B70")]
		internal object KBFMIJFPKDP(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x240CCA0", Offset = "0x240C0A0", VA = "0x18240CCA0")]
	public KOMDHCCOBME(KECOHBBAEKF JIGEOBHPABG, string DIHEMHKOJAD, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E7080", Offset = "0x6E6480")] KOMDHCCOBME<T>.IFMBCLMJDKD JNDAMNDEHGB, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E70E0", Offset = "0x6E64E0")] KOMDHCCOBME<T>.FJFFCIMECAN EHBAJLGECNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x240C270", Offset = "0x240B670", VA = "0x18240C270")]
	private static object? LFPLIBEJFBF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E7140", Offset = "0x6E6540")] KOMDHCCOBME<T?>.FJFFCIMECAN? EHBAJLGECNP, string? LMEELMGGLDA, object? OLNFJPNAOBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x240B620", Offset = "0x240AA20", VA = "0x18240B620")]
	private static string IBKPGJDIIJI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E71A0", Offset = "0x6E65A0")] KOMDHCCOBME<T>.IFMBCLMJDKD LACPHBAJOPD, object? KKIAKNLLHIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface INOEDHDBPMO
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	KAPKJIFIGFH LJLJOJHHELF
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	JEHNOAPOBDP HCAJOCPKAMI
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	GKENAAINMOP EBKCEHOKGND
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<CDPKAGAGCON> EIEPELDIFIB;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action NMHHEKNIDJL;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DMEKLMHPMFA NFBFJIGCJLH(KAPKJIFIGFH IDPCHCFPHDE);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<CDPKAGAGCON> HGPHKOEFPOF(CancellationToken DNKHCCGNODC);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task APIGNOCDDJG(long KLOAGIPENLJ, long AENJJHCEEHK, IReadOnlyList<EMJGLFBOAPI> NLNNJOJNGGD);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<KAPKJIFIGFH> NNLKMEPFDPH();
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class AOMCJEJGMAC
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x657FDC0", Offset = "0x657F1C0", VA = "0x18657FDC0")]
	public static DMEKLMHPMFA DJHDENDJCNG(this INOEDHDBPMO BMOADCBDCJG)
	{
		return default(DMEKLMHPMFA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal class FCBNMHMAAGG : KKHNEDKEAMB, CAOPDKKEMJA, OBLEFEMOINN, KOKLKDJNKCC<KECOHBBAEKF>
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	internal static readonly HGFFHELHADO OACODCGBGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	internal readonly JEIEEPBEEDG GOPJCDPCOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private string? KPKIMBNJBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private string? KEGOPMLIABF;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private bool OEEKBPCGBHL
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6581E50", Offset = "0x6581250", VA = "0x186581E50", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private bool AGJPKINPIAI
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6582020", Offset = "0x6581420", VA = "0x186582020", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private bool HKOOCKMKHHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6582850", Offset = "0x6581C50", VA = "0x186582850", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private bool PBBKODHDABJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6582A90", Offset = "0x6581E90", VA = "0x186582A90", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private bool LNBHGMKANCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6583C90", Offset = "0x6583090", VA = "0x186583C90", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private bool NGOFJLHIIJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6581C90", Offset = "0x6581090", VA = "0x186581C90", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public DMEKLMHPMFA OEGGNKIEBLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9937F0", Offset = "0x992BF0", VA = "0x1809937F0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DMEKLMHPMFA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x992D00", Offset = "0x992100", VA = "0x180992D00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string HEBLBNBJLKB
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6582E60", Offset = "0x6582260", VA = "0x186582E60", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6582070", Offset = "0x6581470", VA = "0x186582070")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string CJFIHHHDEAD
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6582E60", Offset = "0x6582260", VA = "0x186582E60", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool GBPKPDOLMMO
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA4B130", Offset = "0xA4A530", VA = "0x180A4B130")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA4B060", Offset = "0xA4A460", VA = "0x180A4B060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool OPFFEELJOBM
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6583AE0", Offset = "0x6582EE0", VA = "0x186583AE0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public LHBEIAOLDCO GFAOCOCIKDH
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x65829F0", Offset = "0x6581DF0", VA = "0x1865829F0", Slot = "20")]
		get
		{
			return default(LHBEIAOLDCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool EMCIFPLDGLK
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6582D20", Offset = "0x6582120", VA = "0x186582D20", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool JJGPDJCJPBK
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6582E10", Offset = "0x6582210", VA = "0x186582E10", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool GDFCEEHPMFI
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6582DC0", Offset = "0x65821C0", VA = "0x186582DC0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool BJHPGKGGAPG
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6582D70", Offset = "0x6582170", VA = "0x186582D70", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool FABJPLOFCKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6583CE0", Offset = "0x65830E0", VA = "0x186583CE0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool KMJDKEFGBIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x65829A0", Offset = "0x6581DA0", VA = "0x1865829A0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool OHCILIKJBKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6582950", Offset = "0x6581D50", VA = "0x186582950", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool MFKFHLEOBKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6581CE0", Offset = "0x65810E0", VA = "0x186581CE0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IReadOnlyList<string> CBFKFIFGPGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x65828F0", Offset = "0x6581CF0", VA = "0x1865828F0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool JNLFCLFJJIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6581E50", Offset = "0x6581250", VA = "0x186581E50", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool JCCHKMJNAGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6583C90", Offset = "0x6583090", VA = "0x186583C90", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool IEKCMBIJBNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6582020", Offset = "0x6581420", VA = "0x186582020", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool AFGFBELBJGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x65828A0", Offset = "0x6581CA0", VA = "0x1865828A0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool GNCFGEFNBFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6582A40", Offset = "0x6581E40", VA = "0x186582A40", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool BOEGFGKOELF
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6582850", Offset = "0x6581C50", VA = "0x186582850", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool DMLLNNMIPHD
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6583B30", Offset = "0x6582F30", VA = "0x186583B30", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool KPLIDPIMPBM
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6582A90", Offset = "0x6581E90", VA = "0x186582A90", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool ONEOHINPJCF
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6581C90", Offset = "0x6581090", VA = "0x186581C90", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event EMCHIJOPMNA<KECOHBBAEKF> KIEHPKOANJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6581DB0", Offset = "0x65811B0", VA = "0x186581DB0", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x65820C0", Offset = "0x65814C0", VA = "0x1865820C0", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1DA6540", Offset = "0x1DA5940", VA = "0x181DA6540", Slot = "6")]
	public (bool, T?) FFNMIFIJGAL<T>(KECOHBBAEKF JIGEOBHPABG) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1DA66E0", Offset = "0x1DA5AE0", VA = "0x181DA66E0")]
	public FCBNMHMAAGG GGOIBEBIIED<T>(KECOHBBAEKF JIGEOBHPABG, bool HNPNLKMAHOH, T KKIAKNLLHIO) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6583F90", Offset = "0x6583390", VA = "0x186583F90")]
	public FCBNMHMAAGG(DMEKLMHPMFA BCJPDDIEKHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6583FB0", Offset = "0x65833B0", VA = "0x186583FB0")]
	public FCBNMHMAAGG(DMEKLMHPMFA BCJPDDIEKHE, [Optional] string? KPKIMBNJBIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6583F00", Offset = "0x6583300", VA = "0x186583F00")]
	public FCBNMHMAAGG(FCBNMHMAAGG JAKDPEPKFPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6583DA0", Offset = "0x65831A0", VA = "0x186583DA0")]
	internal FCBNMHMAAGG(DMEKLMHPMFA KCJDOLNKNHL, [Optional] string? KPKIMBNJBIN, [Optional] FCBNMHMAAGG? JAKDPEPKFPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6581D30", Offset = "0x6581130", VA = "0x186581D30")]
	public static CHBCBEPKDJO BIGADFOEKNP(KECOHBBAEKF JIGEOBHPABG)
	{
		return default(CHBCBEPKDJO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6582830", Offset = "0x6581C30", VA = "0x186582830")]
	public void EEELMHOFLOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6582500", Offset = "0x6581900", VA = "0x186582500")]
	internal FCBNMHMAAGG DKNBKAPKHEC(FCBNMHMAAGG LLFEBKBGMPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6582160", Offset = "0x6581560", VA = "0x186582160")]
	internal IReadOnlyCollection<KECOHBBAEKF> DGCDPJOAHEA(FCBNMHMAAGG JAKDPEPKFPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6581EA0", Offset = "0x65812A0", VA = "0x186581EA0")]
	public bool CMDOCDMJJAE(KECOHBBAEKF JIGEOBHPABG, bool HNPNLKMAHOH, string LJCJDODCBDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6583B80", Offset = "0x6582F80", VA = "0x186583B80")]
	public (bool, string) ONNOECCLOBG(KECOHBBAEKF JIGEOBHPABG)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6581F80", Offset = "0x6581380", VA = "0x186581F80")]
	internal void COMELJCDCCA(KECOHBBAEKF JIGEOBHPABG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6582AE0", Offset = "0x6581EE0", VA = "0x186582AE0")]
	public ILINDCIGIOL JIOGLMHEHHF(Func<DMEKLMHPMFA, Guid> PFOOMGAIFGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6582EB0", Offset = "0x65822B0", VA = "0x186582EB0")]
	public void MMNDMFJJOEK(ILINDCIGIOL IGLAAIAHKNP, Func<Guid, DMEKLMHPMFA> NIJGBOCJHHO, [Optional] DMEKLMHPMFA? NLHNFDIDCBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6582790", Offset = "0x6581B90", VA = "0x186582790")]
	[CompilerGenerated]
	private void EEBBNALLKLF(KECOHBBAEKF LPJNGIBOOAC, ELGNBMHAKEM MPOKOJJDAHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface DMNOOBMPODN
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PDOOMLPNIIH(KAPKJIFIGFH EBGAPPEIEMN, KAPKJIFIGFH FHNPPLNFGJB, IEnumerable<KAPKJIFIGFH> HJKNHPGLNBI, out LHBEIAOLDCO ELKDGONIECD, out KDJJHEPPNII PIEBIKCHHAI);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum KDJJHEPPNII : byte
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	CantKickEventOrganizer
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface CAOPDKKEMJA
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool OPFFEELJOBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool EMCIFPLDGLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool JJGPDJCJPBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool GDFCEEHPMFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	bool BJHPGKGGAPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool FABJPLOFCKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool KMJDKEFGBIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool OHCILIKJBKN
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool MFKFHLEOBKD
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool AFGFBELBJGO
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool GNCFGEFNBFO
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool DMLLNNMIPHD
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	IReadOnlyList<string> CBFKFIFGPGD
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	LHBEIAOLDCO GFAOCOCIKDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface KKHNEDKEAMB : CAOPDKKEMJA, OBLEFEMOINN, KOKLKDJNKCC<KECOHBBAEKF>
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string CJFIHHHDEAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	DMEKLMHPMFA OEGGNKIEBLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) FFNMIFIJGAL<T>(KECOHBBAEKF JIGEOBHPABG) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal abstract class DEJEHDEMNKB
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public object? NBDOEIIMBKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7E8110", Offset = "0x7E7510", VA = "0x1807E8110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7F3140", Offset = "0x7F2540", VA = "0x1807F3140")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7FF090", Offset = "0x7FE490", VA = "0x1807FF090")]
	protected DEJEHDEMNKB(object? GKMLBAHKNAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool MGFALPCKMEG(object? KKIAKNLLHIO);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class GDPJENPMHPC<T> : DEJEHDEMNKB where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private T ONFJGLKOCCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly IEqualityComparer<T> HFLKGIFCEEE;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T EEMAOFBHODN
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9937F0", Offset = "0x992BF0", VA = "0x1809937F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x21202C0", Offset = "0x211F6C0", VA = "0x1821202C0", Slot = "4")]
	public override bool MGFALPCKMEG(object? KKIAKNLLHIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2120090", Offset = "0x211F490", VA = "0x182120090")]
	public bool LKBOFHDPOBC(T CHPBPHFKHPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2120600", Offset = "0x211FA00", VA = "0x182120600")]
	public GDPJENPMHPC(T OLNFJPNAOBM, IEqualityComparer<T> HFLKGIFCEEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal static class FIDEGOHCKGP
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[Flags]
	public enum MJKEMEAHPCB
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		AG_EVERYONE = 0,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		AG_CREATOR = 0x200000,
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		AG_COOWNER = 0x400000,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		AG_HOST = 0x800000,
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		AG_MODERATOR = 0x1000000
	}

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public static readonly Guid MOHLGJHFJJD;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public static readonly Guid BIGMGKJLLAE;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public static readonly Guid AJMGIJLCBCA;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly Guid DBHHOAFJGBG;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly Guid DGFOOFLMAOO;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly DOEPLLLHIPG<DMEKLMHPMFA, Guid> FPPHEALFFBN;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal static IEnumerable<DMEKLMHPMFA> AKICMMOMBKF
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6584070", Offset = "0x6583470", VA = "0x186584070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6584120", Offset = "0x6583520", VA = "0x186584120")]
	public static DMEKLMHPMFA HPBLKOHBCDI(Guid EBABBHGKMJL)
	{
		return default(DMEKLMHPMFA);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6584340", Offset = "0x6583740", VA = "0x186584340")]
	public static Guid OAOBJAHHFIF(DMEKLMHPMFA BCJPDDIEKHE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x65842A0", Offset = "0x65836A0", VA = "0x1865842A0")]
	public static bool NNMBKMJMCMM(DMEKLMHPMFA BCJPDDIEKHE, out Guid EBABBHGKMJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6583FD0", Offset = "0x65833D0", VA = "0x186583FD0")]
	public static bool ABFIOKIHHGE(Guid EBABBHGKMJL, out DMEKLMHPMFA BCJPDDIEKHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x65840F0", Offset = "0x65834F0", VA = "0x1865840F0")]
	public static DMEKLMHPMFA DAFEMMNBHIP(DMEKLMHPMFA BCJPDDIEKHE)
	{
		return default(DMEKLMHPMFA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x65841B0", Offset = "0x65835B0", VA = "0x1865841B0")]
	public static MJKEMEAHPCB JLLGIAGJPLJ(DMEKLMHPMFA PBEHEMOFHPM)
	{
		return default(MJKEMEAHPCB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6584260", Offset = "0x6583660", VA = "0x186584260")]
	internal static DMEKLMHPMFA JOFHMFEPCLP(MJKEMEAHPCB HIMBIIEGHBP)
	{
		return default(DMEKLMHPMFA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal delegate string GPMFJIPGGHI(object? KKIAKNLLHIO);
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal delegate object GPDMAAAONEB(string? LMEELMGGLDA, [Optional] object OLNFJPNAOBM);
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal delegate DEJEHDEMNKB AFCNJLKDMPH();
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class HGFFHELHADO
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private class AEGIBHMAPMI : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		internal static AEGIBHMAPMI HLFGGJBLCBK;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x657FAC0", Offset = "0x657EEC0", VA = "0x18657FAC0", Slot = "4")]
		public bool Equals(List<string> GEAEMIOLNKK, List<string> KFMHCNGHPHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x657FC20", Offset = "0x657F020", VA = "0x18657FC20", Slot = "5")]
		public int GetHashCode(List<string> ICNDEPGFBMI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public AEGIBHMAPMI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private class LNEMEEGFFPN : MLAAIBBELGP<LHBEIAOLDCO>
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x658C3B0", Offset = "0x658B7B0", VA = "0x18658C3B0", Slot = "9")]
		public override string IBKPGJDIIJI(LHBEIAOLDCO IGBONFEPFAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x658C1C0", Offset = "0x658B5C0", VA = "0x18658C1C0", Slot = "10")]
		protected override bool HNNBGANABOH(string IGBONFEPFAO, out LHBEIAOLDCO KKIAKNLLHIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x658C4A0", Offset = "0x658B8A0", VA = "0x18658C4A0")]
		public LNEMEEGFFPN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static readonly BGOEKNAAGCN PNMAIEAEADH;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly LNEMEEGFFPN FMPBMOKENDL;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly List<FOAGDIILAPH> NCKLFBLIHNI;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public IEnumerable<KECOHBBAEKF> NJBNOCJNIGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7E8110", Offset = "0x7E7510", VA = "0x1807E8110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public IReadOnlyDictionary<KECOHBBAEKF, FOAGDIILAPH> BAPCJOMGLCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6585EB0", Offset = "0x65852B0", VA = "0x186585EB0")]
	public HGFFHELHADO([Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E7280", Offset = "0x6E6680")] IList<FOAGDIILAPH> JBGLOJPBBFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x65852D0", Offset = "0x65846D0", VA = "0x1865852D0")]
	public FOAGDIILAPH PCPMBLEOLDK(KECOHBBAEKF JIGEOBHPABG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class JCHOMKAIEJE : IDBDBAFPNOF, NJMPNDIFJJL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class NEKCLEFPNNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public FCBNMHMAAGG newRole;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public NEKCLEFPNNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x658C710", Offset = "0x658BB10", VA = "0x18658C710")]
		internal bool OPPOHMPBAON(FCBNMHMAAGG rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class DAPDBPMEFMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public DMEKLMHPMFA roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public DAPDBPMEFMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x65814D0", Offset = "0x65808D0", VA = "0x1865814D0")]
		internal bool JNNBODIDECK(DMEKLMHPMFA r)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class EIGCFMHFEBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public MKMOLMPLENB roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public JCHOMKAIEJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private bool <isOffline>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private CDPKAGAGCON <tokenAndPermissionsDto>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private bool <hasRoomRoles>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private CDPKAGAGCON <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private bool <serverHasPermissions>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E7810", Offset = "0x6E6C10")]
		private TaskAwaiter<CDPKAGAGCON> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public EIGCFMHFEBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x65814E0", Offset = "0x65808E0", VA = "0x1865814E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class MHPMMDOMMGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public MHPMMDOMMGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x658C4E0", Offset = "0x658B8E0", VA = "0x18658C4E0")]
		internal void LIINFCDJFHM(ILINDCIGIOL r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x658C5E0", Offset = "0x658B9E0", VA = "0x18658C5E0")]
		internal void NPCGDIDPMNF(ILINDCIGIOL r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct JMABONAHIFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public MKMOLMPLENB roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class BHPDDLAKHOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E7870", Offset = "0x6E6C70")]
		public Func<ILINDCIGIOL, ELGNBMHAKEM> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public BHPDDLAKHOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6580B40", Offset = "0x657FF40", VA = "0x186580B40")]
		internal void HIPGHCAMMMF(ILINDCIGIOL r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6580AD0", Offset = "0x657FED0", VA = "0x186580AD0")]
		internal void HCLDDPGEEMM(ILINDCIGIOL r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6580A60", Offset = "0x657FE60", VA = "0x186580A60")]
		internal void EKJLBKIKGCC(ILINDCIGIOL r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class MFFLBGLOLHG<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private sealed class <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public MFFLBGLOLHG<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private object <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private int <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private Exception <ex>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E7930", Offset = "0x6E6D30")]
			private TaskAwaiter<CDPKAGAGCON> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
			public <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x1A3A170", Offset = "0x1A39570", VA = "0x181A3A170", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public JCHOMKAIEJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public KECOHBBAEKF rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public DMEKLMHPMFA accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public CHBCBEPKDJO recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public string serializedNewValue;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public MFFLBGLOLHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2F2C070", Offset = "0x2F2B470", VA = "0x182F2C070")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(MFFLBGLOLHG<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void PFLGEAOAEOO()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct PCAHLOALGON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public IReadOnlyList<EMJGLFBOAPI> newPermissionOverrides;
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class BHAFAGMNALO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public INOEDHDBPMO rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public MKMOLMPLENB roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E7990", Offset = "0x6E6D90")]
		public IReadOnlyDictionary<DMEKLMHPMFA, FCBNMHMAAGG> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public MLEHJAMOLIK debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private StringBuilder <migrationLogBuilder>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E79F0", Offset = "0x6E6DF0")]
		private List<EMJGLFBOAPI> <permissionsChangeBatch>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private IEnumerator<ILINDCIGIOL> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private ILINDCIGIOL <roleData>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private DMEKLMHPMFA <roleAccountType>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private FCBNMHMAAGG <role>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private IReadOnlyList<KECOHBBAEKF> <modifiedPermissions>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private IEnumerator<KECOHBBAEKF> <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private KECOHBBAEKF <permission>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private CHBCBEPKDJO <recNetPermissionType>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E7A50", Offset = "0x6E6E50")]
		private (bool Overrides, string SerializedValue) <serializedData>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public BHAFAGMNALO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x657FE20", Offset = "0x657F220", VA = "0x18657FE20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly INOEDHDBPMO BMOADCBDCJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly CFKKPMBODHK AFIHEKOKNPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly MLEHJAMOLIK AEFFNDMNAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly Dictionary<int, FCBNMHMAAGG> IMGALICLHGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal readonly Dictionary<DMEKLMHPMFA, FCBNMHMAAGG> LAAJJGDBLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal readonly Dictionary<DMEKLMHPMFA, FCBNMHMAAGG> JGPECBAADMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal readonly List<FCBNMHMAAGG> DLNMFINEEHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool POCOJLLMPPP;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly KECOHBBAEKF[] LNKJDDEIAJB;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public GPHDOINNIHD FHMFNLJMCEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public IEnumerable<KKHNEDKEAMB> BKDPNJCCBMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6589D80", Offset = "0x6589180", VA = "0x186589D80", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event GDMIJNLOCDJ LBBEPLGLPHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6586C20", Offset = "0x6586020", VA = "0x186586C20", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6586500", Offset = "0x6585900", VA = "0x186586500", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6588630", Offset = "0x6587A30", VA = "0x186588630")]
	[GHLDKGGJCDP(BOCOADOGGBA.Room, FGNCLGKDFDK.None)]
	private static void FGOGAKCFKDL(EPBOEGFMAOO NFNKJJKEMME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x658B860", Offset = "0x658AC60", VA = "0x18658B860")]
	[UnityEngine.Scripting.Preserve]
	internal JCHOMKAIEJE([EPGFAMNCJKC(null)] INOEDHDBPMO AIJLNMGDHKF, [EPGFAMNCJKC(null)] CFKKPMBODHK GMBNIMMJCAJ, [EPGFAMNCJKC(null)] MLEHJAMOLIK AEFFNDMNAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6586E80", Offset = "0x6586280", VA = "0x186586E80", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x658A030", Offset = "0x6589430", VA = "0x18658A030")]
	private void LGBJFLJOLID(IEnumerable<FCBNMHMAAGG> GPKPGPJHMEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x658B390", Offset = "0x658A790", VA = "0x18658B390", Slot = "12")]
	public bool NGBJANOHLMB(KAPKJIFIGFH IDPCHCFPHDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x658B460", Offset = "0x658A860", VA = "0x18658B460")]
	private void NMHHEKNIDJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6589640", Offset = "0x6588A40", VA = "0x186589640")]
	private void JBOKJABGCOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x658B610", Offset = "0x658AA10", VA = "0x18658B610", Slot = "10")]
	public IReadOnlyList<KKHNEDKEAMB> PGLOMFDGCJM(bool EPCKNNGGGCM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x658AF60", Offset = "0x658A360", VA = "0x18658AF60", Slot = "11")]
	public KKHNEDKEAMB MAEEBACOPME(KAPKJIFIGFH IDPCHCFPHDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x65897C0", Offset = "0x6588BC0", VA = "0x1865897C0")]
	private DMEKLMHPMFA JHDIBOOHIAD(KAPKJIFIGFH IDPCHCFPHDE)
	{
		return default(DMEKLMHPMFA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6589DD0", Offset = "0x65891D0", VA = "0x186589DD0", Slot = "14")]
	public bool KNDJHFJLLMK(KAPKJIFIGFH LOBPHBALKHN, DMEKLMHPMFA BCJPDDIEKHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6589F80", Offset = "0x6589380", VA = "0x186589F80", Slot = "15")]
	public KKHNEDKEAMB LCNDCJOGKBM(DMEKLMHPMFA BCJPDDIEKHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x65887E0", Offset = "0x6587BE0", VA = "0x1865887E0")]
	private static bool FKBNFEPDMHK(KDHEAKNHLJI POLCKICLPLH, DMEKLMHPMFA BCJPDDIEKHE, out ILINDCIGIOL? MOKMBBLAAFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x65865A0", Offset = "0x65859A0", VA = "0x1865865A0")]
	private static void CKKDAJBKJJI(KDHEAKNHLJI POLCKICLPLH, Action<ILINDCIGIOL> FGPOMPLNNGM, DMEKLMHPMFA KAKJFGNMGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x65866A0", Offset = "0x6585AA0", VA = "0x1865866A0")]
	private static void CKKDAJBKJJI(KDHEAKNHLJI POLCKICLPLH, Action<ILINDCIGIOL> FGPOMPLNNGM, Predicate<DMEKLMHPMFA> POCOGGDGADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x65892C0", Offset = "0x65886C0", VA = "0x1865892C0")]
	private void IFDLKNOMGMD(KAPKJIFIGFH IDPCHCFPHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6587EA0", Offset = "0x65872A0", VA = "0x186587EA0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EIGCFMHFEBI))]
	public Task EPJIKGBOFJI([CanBeNull] MKMOLMPLENB NBHAPFMEJDI, CancellationToken DNKHCCGNODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
	public void LHEDEKEFFDB(ref MKMOLMPLENB NBHAPFMEJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6588D30", Offset = "0x6588130", VA = "0x186588D30")]
	private void HMGMJCEHFCP(KDHEAKNHLJI CNAMMKAOGCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6589320", Offset = "0x6588720", VA = "0x186589320")]
	internal static string IPFHHKCPEME(INOEDHDBPMO BMOADCBDCJG, MKMOLMPLENB NBHAPFMEJDI, IReadOnlyDictionary<DMEKLMHPMFA, FCBNMHMAAGG> LAAJJGDBLFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6586F90", Offset = "0x6586390", VA = "0x186586F90")]
	private static void EMMFJOOACOD(MKMOLMPLENB NBHAPFMEJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6588FB0", Offset = "0x65883B0", VA = "0x186588FB0")]
	private static void HNLLFPHIFHL(KDHEAKNHLJI JHMLKCDNOHN, IReadOnlyDictionary<DMEKLMHPMFA, FCBNMHMAAGG> LAAJJGDBLFH, StringBuilder NLBKEMAOGBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6588BD0", Offset = "0x6587FD0", VA = "0x186588BD0")]
	private static bool HBBONGPPDCK(string OAGHLGEMHHF, out Guid KAJEMHPJNJO, out DMEKLMHPMFA BCJPDDIEKHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6588010", Offset = "0x6587410", VA = "0x186588010")]
	private static void FBGNMJEJDFD(MKMOLMPLENB NBHAPFMEJDI, StringBuilder NLBKEMAOGBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0xBD3600", Offset = "0xBD2A00", VA = "0x180BD3600", Slot = "16")]
	public bool GALFLANHIHJ<T>(DMEKLMHPMFA BCJPDDIEKHE, KECOHBBAEKF JIGEOBHPABG, bool HNPNLKMAHOH, T FADMIIJIPLK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6586CC0", Offset = "0x65860C0", VA = "0x186586CC0")]
	private void DFKPDHDHCDE(DMEKLMHPMFA BCJPDDIEKHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6589F60", Offset = "0x6589360", VA = "0x186589F60")]
	private bool LCMLGDMHDFK(KAPKJIFIGFH IDPCHCFPHDE, DMEKLMHPMFA BCJPDDIEKHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x658B070", Offset = "0x658A470", VA = "0x18658B070")]
	internal FCBNMHMAAGG NCGNDOEONFD(KAPKJIFIGFH IDPCHCFPHDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6586E70", Offset = "0x6586270", VA = "0x186586E70", Slot = "13")]
	public IReadOnlyList<KKHNEDKEAMB> DNKBJEDIBHI(KAPKJIFIGFH IDPCHCFPHDE, bool BHGPDENOOKN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6589B60", Offset = "0x6588F60", VA = "0x186589B60")]
	internal IReadOnlyList<FCBNMHMAAGG> JMEDAEGJCAI(KAPKJIFIGFH IDPCHCFPHDE, bool BHGPDENOOKN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x658A820", Offset = "0x6589C20", VA = "0x18658A820")]
	private void LLLCMHMIBHF(CDPKAGAGCON NOFFHIANDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6589880", Offset = "0x6588C80", VA = "0x186589880")]
	private static bool JKLMCPJCEGF(FCBNMHMAAGG DFOLPNPGHHD, IReadOnlyDictionary<DMEKLMHPMFA, FCBNMHMAAGG> LAAJJGDBLFH, out IReadOnlyList<KECOHBBAEKF> DOKPJIJLMFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x658B470", Offset = "0x658A870", VA = "0x18658B470")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BHAFAGMNALO))]
	private static Task OGGPFPDOJFL(INOEDHDBPMO BMOADCBDCJG, MKMOLMPLENB NBHAPFMEJDI, IReadOnlyDictionary<DMEKLMHPMFA, FCBNMHMAAGG> LAAJJGDBLFH, MLEHJAMOLIK AEFFNDMNAEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6586220", Offset = "0x6585620", VA = "0x186586220")]
	[CompilerGenerated]
	internal static void CBDGMDJNNIA(Func<ILINDCIGIOL, ELGNBMHAKEM> ILODHPCMMAM, ref JMABONAHIFK P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x65868A0", Offset = "0x6585CA0", VA = "0x1865868A0")]
	[CompilerGenerated]
	internal static bool CNPCBJBIBOH(DMEKLMHPMFA BCJPDDIEKHE, KECOHBBAEKF JIGEOBHPABG, out EMJGLFBOAPI CJDBNKDOMBI, ref PCAHLOALGON P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public enum KECOHBBAEKF
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	CAN_EDIT_ROOM_ROLES = 1,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	VOTE_KICK_PERMISSION = 3,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	CAN_INVITE = 4,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	CAN_TALK = 6,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	CAN_PRINT_PHOTOS = 7,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	CAN_START_GAMES = 8,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	CAN_SELF_REVIVE = 9,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	AUTO_ASSIGNED_GAME_ROLES = 11,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	CAN_CHANGE_GAME_MODE = 12,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	CAN_USE_MAKER_PEN = 13,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	CAN_USE_DELETE_ALL_BUTTON = 14,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	CAN_SAVE_INVENTIONS = 15,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	DISABLE_MIC_AUTO_MUTE = 16,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	CAN_END_GAMES_EARLY = 17,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	CAN_USE_SHARE_CAM = 18,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	DEPRECATED_CAN_EDIT_CIRCUITS = 19,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	CAN_SPAWN_INVENTIONS = 20,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	CAN_SPAWN_CONSUMABLES = 21,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	CAN_USE_ROOM_RESET_BUTTON = 22,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	CAN_USE_PLAY_GIZMOS_TOGGLE = 23
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class JEIEEPBEEDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly Dictionary<KECOHBBAEKF, bool> JFLFDKOFDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly Dictionary<KECOHBBAEKF, DEJEHDEMNKB> BHLPHJEHEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly HGFFHELHADO EKDONMICOJM;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x658BF70", Offset = "0x658B370", VA = "0x18658BF70")]
	public JEIEEPBEEDG(HGFFHELHADO EKDONMICOJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x658BAF0", Offset = "0x658AEF0", VA = "0x18658BAF0")]
	public bool BPDPDICLLOH(KECOHBBAEKF JIGEOBHPABG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0xBD6C00", Offset = "0xBD6000", VA = "0x180BD6C00")]
	public bool PLOKIJILBLG<T>(KECOHBBAEKF JIGEOBHPABG, bool HNPNLKMAHOH, T KKIAKNLLHIO) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0xBD6790", Offset = "0xBD5B90", VA = "0x180BD6790")]
	public (bool, T?) IIDCEIBIBLE<T>(KECOHBBAEKF JIGEOBHPABG) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x658BE90", Offset = "0x658B290", VA = "0x18658BE90")]
	public bool PLOKIJILBLG(KECOHBBAEKF JIGEOBHPABG, bool HNPNLKMAHOH, object KKIAKNLLHIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x658BDA0", Offset = "0x658B1A0", VA = "0x18658BDA0")]
	public (bool, object) IIDCEIBIBLE(KECOHBBAEKF JIGEOBHPABG)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0xBD6570", Offset = "0xBD5970", VA = "0x180BD6570")]
	private void HLIEFJNHCEA<T>(KECOHBBAEKF JIGEOBHPABG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x658BCE0", Offset = "0x658B0E0", VA = "0x18658BCE0")]
	private DEJEHDEMNKB ELCBONFGIEH(KECOHBBAEKF JIGEOBHPABG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x658BB60", Offset = "0x658AF60", VA = "0x18658BB60")]
	public void EEELMHOFLOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface GPHDOINNIHD
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	KKHNEDKEAMB GAJBNKOPEIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal class CFKKPMBODHK : GPHDOINNIHD
{
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public static CFKKPMBODHK DGOLIJPPAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	internal readonly FCBNMHMAAGG KLBMAKOLNDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	internal readonly IReadOnlyList<FCBNMHMAAGG> JDAHDCEJOBM;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public KKHNEDKEAMB GAJBNKOPEIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7E8110", Offset = "0x7E7510", VA = "0x1807E8110", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x65813D0", Offset = "0x65807D0", VA = "0x1865813D0")]
	public CFKKPMBODHK(FCBNMHMAAGG EHPGDECBGIJ, IReadOnlyList<FCBNMHMAAGG> KLKMFLAFOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6580BB0", Offset = "0x657FFB0", VA = "0x186580BB0")]
	private static CFKKPMBODHK BNDDNJIJKEJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public enum BHHLNGFNJNI
{
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Everyone
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
