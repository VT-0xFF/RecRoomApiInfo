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
		[Cpp2IlInjected.Address(RVA = "0x87BDE0", Offset = "0x87ADE0", VA = "0x18087BDE0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x70907D0", Offset = "0x708F7D0", VA = "0x1870907D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87C700", Offset = "0x87B700", VA = "0x18087C700")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x87C740", Offset = "0x87B740", VA = "0x18087C740")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum HKJAKIBPJJH
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void PFOHJLJDENJ<TPermission>(TPermission MPBEIHLHJJF);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void BINAPHFAHGP(EEPDJJKFILM GOJJHGGKKML);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum OANBEMMLECJ
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface JMNKGPNIJDD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool COLGILKLAMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool BEDKFFNPCIF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool MAMBHJNFNLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool PJOGFKEPKCM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool AFOKDDNPKIO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool HFCCIPOIBGL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class AMKCAANCJAJ
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	public enum JGFLOJDHCAC
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		AG_EVERYONE = 0,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		AG_CREATOR = 0x200000,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		AG_COOWNER = 0x400000,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		AG_HOST = 0x800000,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		AG_MODERATOR = 0x1000000
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly Guid FKDFGCGPANI;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid OFKJJCKNKLC;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid BNIEPIIGJDD;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid BAEDCICBIOB;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid ICDBBGJMHMC;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid JJFICLIHHEN;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly MEOKDPIPNEF<MJKPLCNHABA, Guid> AFNOCLMIIHP;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<MJKPLCNHABA> MABKANBHPLD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7084910", Offset = "0x7083910", VA = "0x187084910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7084730", Offset = "0x7083730", VA = "0x187084730")]
	public static MJKPLCNHABA FAANEOPEADD(Guid CNIMPJMOLDJ)
	{
		return default(MJKPLCNHABA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7084870", Offset = "0x7083870", VA = "0x187084870")]
	public static Guid HNNIIKJNICO(MJKPLCNHABA PJGMBJGGNNH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7084620", Offset = "0x7083620", VA = "0x187084620")]
	public static bool BGMFDHKOANK(MJKPLCNHABA PJGMBJGGNNH, [Out] Guid CNIMPJMOLDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7084990", Offset = "0x7083990", VA = "0x187084990")]
	public static bool OFBBNHHFJHO(Guid CNIMPJMOLDJ, [Out] MJKPLCNHABA PJGMBJGGNNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x70846F0", Offset = "0x70836F0", VA = "0x1870846F0")]
	public static MJKPLCNHABA DBEDNOJDBEG(MJKPLCNHABA PJGMBJGGNNH)
	{
		return default(MJKPLCNHABA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x70847C0", Offset = "0x70837C0", VA = "0x1870847C0")]
	public static JGFLOJDHCAC GDBEFKCGDAI(MJKPLCNHABA PNMBBNEGDKE)
	{
		return default(JGFLOJDHCAC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x70846B0", Offset = "0x70836B0", VA = "0x1870846B0")]
	internal static MJKPLCNHABA DAHGOFLFINE(JGFLOJDHCAC LGGOMLGFJGG)
	{
		return default(MJKPLCNHABA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface JOEFCHENJKC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	MBCFKJFIAFA EEDBPOJINJP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<IHPCBACDFLO> GOGPFKDOOPO
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event BINAPHFAHGP BCMIKBJBDEM;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<IHPCBACDFLO> PEJENINPKPM(bool MDDABFKOPBO = false);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IHPCBACDFLO KEBMHLBFKAM(EEPDJJKFILM GOJJHGGKKML);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CKEANIBACNO(EEPDJJKFILM GOJJHGGKKML);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<IHPCBACDFLO> GGDAKAAFFHF(EEPDJJKFILM GOJJHGGKKML, bool NFFBLLJLGOM = false);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool FIBDNAKMGPK(EEPDJJKFILM IOHLHPLCBNC, MJKPLCNHABA PJGMBJGGNNH);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IHPCBACDFLO ODLLOHIOBCE(MJKPLCNHABA PJGMBJGGNNH);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool JJNDDLHANMN<T>(MJKPLCNHABA PJGMBJGGNNH, PMGDAMAPCCO MPBEIHLHJJF, bool HDMHDLMILAL, T OEMEKBFANIG, [Optional] Action AAEBAMGIPDE) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string NJLIJODEMCI(PMGDAMAPCCO MPBEIHLHJJF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OOIDPLDEKDH
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PHIHECGFOAG(KECMDPPEFHG KBAPBJOHBKA, CancellationToken LABHBAHABKB);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CILFLILFADM(KECMDPPEFHG KBAPBJOHBKA);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LGFJNGBIAFF
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	EEPDJJKFILM MCDLKPFDKBE
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	PJAFGDKDHNF FALODGJMLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	AFJNCMKOAEB DEDLAMEPEIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<OCKHHKAANBO> MPGBOJHPAIK;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action MEDCJDKDOGA;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MJKPLCNHABA AMHNJNOCNOM(EEPDJJKFILM GOJJHGGKKML);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<OCKHHKAANBO> OJBJEEDNOCH(CancellationToken LABHBAHABKB);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task JJNNOKPBICJ(long MFLLPFDNGGL, IReadOnlyList<HPNPEDFBJMJ> CIOKCFAEAHJ);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task CNEDODAONOP(long MFLLPFDNGGL, long KNEHMNKKPOH, IReadOnlyList<HPNPEDFBJMJ> CIOKCFAEAHJ);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<EEPDJJKFILM> ODEPLNKDMGL();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class MPAHMPBKOCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7090460", Offset = "0x708F460", VA = "0x187090460")]
	public static MJKPLCNHABA MDCMNDDJFIA(this LGFJNGBIAFF CKHGOCNELJH)
	{
		return default(MJKPLCNHABA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface IOGBAFLAHBM<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string LLINIIBCNPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event PFOHJLJDENJ<TPermission> DMNHGNNAMNB;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class JEJLLBJKKHH
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? KEKFLPCLNAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x851910", Offset = "0x850910", VA = "0x180851910")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x858C30", Offset = "0x857C30", VA = "0x180858C30")]
	protected JEJLLBJKKHH(object? PLDCBLPEMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool LMLMPGDBJPL(object? JJCEIJMGOAB);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class KABOLEADGGM<T> : JEJLLBJKKHH where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private T MHIGEGKJHAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly IEqualityComparer<T> PBGGGGHIKLD;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T JMEAFIDIDGF
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x95D990", Offset = "0x95C990", VA = "0x18095D990")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x41BB990", Offset = "0x41BA990", VA = "0x1841BB990", Slot = "4")]
	public override bool LMLMPGDBJPL(object? JJCEIJMGOAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x41BBAA0", Offset = "0x41BAAA0", VA = "0x1841BBAA0")]
	public bool NGKIEKJNLMA(T KOBJACBDHIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x41BC020", Offset = "0x41BB020", VA = "0x1841BC020")]
	public KABOLEADGGM(T KCDEJIJHLPJ, IEqualityComparer<T> PBGGGGHIKLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class CKPEEJDMGED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<PMGDAMAPCCO, bool> PDGGMBANCAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<PMGDAMAPCCO, JEJLLBJKKHH> IBBGMPFKIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly POLKGGMLGJA GAHIIGOEODA;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x70860E0", Offset = "0x70850E0", VA = "0x1870860E0")]
	public CKPEEJDMGED(POLKGGMLGJA GAHIIGOEODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7085CE0", Offset = "0x7084CE0", VA = "0x187085CE0")]
	public bool NICMCFPEAEB(PMGDAMAPCCO MPBEIHLHJJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x299CF50", Offset = "0x299BF50", VA = "0x18299CF50")]
	public bool MHMAAHBBPFP<T>(PMGDAMAPCCO MPBEIHLHJJF, bool HDMHDLMILAL, T JJCEIJMGOAB) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x299D4C0", Offset = "0x299C4C0", VA = "0x18299D4C0")]
	public (bool, T?) PPJGIBGOMID<T>(PMGDAMAPCCO MPBEIHLHJJF) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7085C00", Offset = "0x7084C00", VA = "0x187085C00")]
	public bool MHMAAHBBPFP(PMGDAMAPCCO MPBEIHLHJJF, bool HDMHDLMILAL, object JJCEIJMGOAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7086010", Offset = "0x7085010", VA = "0x187086010")]
	public (bool, object) PPJGIBGOMID(PMGDAMAPCCO MPBEIHLHJJF)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x299CEF0", Offset = "0x299BEF0", VA = "0x18299CEF0")]
	private void ECHCCKPJCBA<T>(PMGDAMAPCCO MPBEIHLHJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7085D50", Offset = "0x7084D50", VA = "0x187085D50")]
	private JEJLLBJKKHH PDMHIELMFBO(PMGDAMAPCCO MPBEIHLHJJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7085E20", Offset = "0x7084E20", VA = "0x187085E20")]
	public void PPCMLECELJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class AKAMFPBPJFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly string AFJILKDEOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly Type KNJGAOBPCKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly HJPCBBEBBEG GIHPNIJHMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly PMGDAMAPCCO JLDFGJIBDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public OEENHDFEOHF FKOPFHPEMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NEBHMONAIIE FAHCOGOCJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public BPHNBHPPGAE DNEEFHKDPBG;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7084580", Offset = "0x7083580", VA = "0x187084580")]
	public AKAMFPBPJFP(Type LDDBFIMKMPE, string BAHDAPCHJEE, PMGDAMAPCCO MPBEIHLHJJF, OEENHDFEOHF MJNENAPNCDA, NEBHMONAIIE BHIECAMNBLB, BPHNBHPPGAE GJEFBOPPODO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7084480", Offset = "0x7083480", VA = "0x187084480")]
	public object ECAKMMGCKLM(object? ACBLPNJDJBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x326BC20", Offset = "0x326AC20", VA = "0x18326BC20")]
	public void ECHCCKPJCBA<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x70844D0", Offset = "0x70834D0", VA = "0x1870844D0")]
	public void ECHCCKPJCBA(Type AJBJNCFGBLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class ENCMPPAKCBO<T> : AKAMFPBPJFP where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string GLMEDHKCCEC(T JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T HEOIFFMOFKF(string? GPLLPMFFBBD, T KCDEJIJHLPJ);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class MAFOEODAECL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public GLMEDHKCCEC serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public HEOIFFMOFKF parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public MAFOEODAECL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x44CD890", Offset = "0x44CC890", VA = "0x1844CD890")]
		internal string LGBLPIGLEEK(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x44CD760", Offset = "0x44CC760", VA = "0x1844CD760")]
		internal object KJOIDKOMDDF(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x38AF7F0", Offset = "0x38AE7F0", VA = "0x1838AF7F0")]
	public ENCMPPAKCBO(PMGDAMAPCCO MPBEIHLHJJF, string BAHDAPCHJEE, [Optional] GLMEDHKCCEC? MJNENAPNCDA, [Optional] HEOIFFMOFKF? BHIECAMNBLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x38AE890", Offset = "0x38AD890", VA = "0x1838AE890")]
	private static object? PPFECFLIGJE(HEOIFFMOFKF? BHIECAMNBLB, string? GPLLPMFFBBD, object? KCDEJIJHLPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x38AE0D0", Offset = "0x38AD0D0", VA = "0x1838AE0D0")]
	private static string JMNIMAIKKED(GLMEDHKCCEC? DIKPMBBFMJE, object? JJCEIJMGOAB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string OEENHDFEOHF(object? JJCEIJMGOAB);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object NEBHMONAIIE(string? GPLLPMFFBBD, [Optional] object KCDEJIJHLPJ);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate JEJLLBJKKHH BPHNBHPPGAE();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class POLKGGMLGJA
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class CJNCHOJEJLC : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal static CJNCHOJEJLC PNNELGGLBHA;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x70858C0", Offset = "0x70848C0", VA = "0x1870858C0", Slot = "4")]
		public bool Equals(List<string> PONGAOGJLMF, List<string> FOJLHADHAPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7085A10", Offset = "0x7084A10", VA = "0x187085A10", Slot = "5")]
		public int GetHashCode(List<string> NOPFNIKINJA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public CJNCHOJEJLC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class NDNMPNPENKM : IFCEPHANOKM<HKJAKIBPJJH>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x70906A0", Offset = "0x708F6A0", VA = "0x1870906A0", Slot = "9")]
		public override string JMNIMAIKKED(HKJAKIBPJJH MIFEONEPPKP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x70904C0", Offset = "0x708F4C0", VA = "0x1870904C0", Slot = "10")]
		protected override bool IAPOMJCJIPP(string MIFEONEPPKP, [Out] HKJAKIBPJJH JJCEIJMGOAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7090790", Offset = "0x708F790", VA = "0x187090790")]
		public NDNMPNPENKM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly OPDOJJCGAOO HKMEEOBFDLM;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly NDNMPNPENKM LFKDCDKOHJL;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly List<AKAMFPBPJFP> MNBDNJMDDEI;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<PMGDAMAPCCO> JOMHDBKFAME
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<PMGDAMAPCCO, AKAMFPBPJFP> PAFIHMKMDKB
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7091D70", Offset = "0x7090D70", VA = "0x187091D70")]
	public POLKGGMLGJA([Optional] IList<AKAMFPBPJFP>? ODHBHDFMAHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7090850", Offset = "0x708F850", VA = "0x187090850")]
	public AKAMFPBPJFP MKGCHPMDMML(PMGDAMAPCCO MPBEIHLHJJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface MBCFKJFIAFA
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	IHPCBACDFLO GDAJPEHNDEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class KGECCBODKPA : MBCFKJFIAFA
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static KGECCBODKPA DENBDKMNMKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly JMMDBPIBFFH HBKMPFKKOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal readonly IReadOnlyList<JMMDBPIBFFH> PCJJBJEIJOG;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public IHPCBACDFLO GDAJPEHNDEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x708FA80", Offset = "0x708EA80", VA = "0x18708FA80")]
	public KGECCBODKPA(JMMDBPIBFFH MDIOEMKMAPE, IReadOnlyList<JMMDBPIBFFH> PKKBDDMBCMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x708EC30", Offset = "0x708DC30", VA = "0x18708EC30")]
	private static KGECCBODKPA LDBEOEBKBEO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class EKEIPFEKFHC
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<MJKPLCNHABA> IDONFFDPIKC;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x708C710", Offset = "0x708B710", VA = "0x18708C710")]
	public static bool DFKAJONFBNH(this EEPDJJKFILM ABGNPDBOJGC, MJKPLCNHABA PJGMBJGGNNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x708C7F0", Offset = "0x708B7F0", VA = "0x18708C7F0")]
	public static bool FPHJDPAJBDG(this EEPDJJKFILM ABGNPDBOJGC, MJKPLCNHABA PJGMBJGGNNH, AFJNCMKOAEB HAGNJOLKBDF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface BNBCPDKAMPF
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool PECOEEJDIMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool KKCNHBINFEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool LCHEEKBGPMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool KEIAAKBPHDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool PONHKIJHFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool EDAAFKAACJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool OJMKEKPEAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool CCOPLLBCCML
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool IIJGAGFAAEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool NIPFECOJPML
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool CPEPGCMGKIG
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool MGMKFLAGGNL
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> HDPJOFJPFPG
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	HKJAKIBPJJH MHIPMAKFFPK
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface IHPCBACDFLO : BNBCPDKAMPF, JMNKGPNIJDD, IOGBAFLAHBM<PMGDAMAPCCO>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string JMMBIMLJNCG
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	MJKPLCNHABA BHFPFFONGFL
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) KNAAGAJOBED<T>(PMGDAMAPCCO MPBEIHLHJJF) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum PMGDAMAPCCO
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	CAN_EDIT_ROOM_ROLES = 1,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	VOTE_KICK_PERMISSION = 3,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	CAN_INVITE = 4,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	CAN_TALK = 6,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	CAN_PRINT_PHOTOS = 7,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	CAN_START_GAMES = 8,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	CAN_SELF_REVIVE = 9,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	AUTO_ASSIGNED_GAME_ROLES = 11,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	CAN_CHANGE_GAME_MODE = 12,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	CAN_USE_MAKER_PEN = 13,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	CAN_USE_DELETE_ALL_BUTTON = 14,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	CAN_SAVE_INVENTIONS = 15,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	DISABLE_MIC_AUTO_MUTE = 16,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	CAN_END_GAMES_EARLY = 17,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	CAN_USE_SHARE_CAM = 18,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	DEPRECATED_CAN_EDIT_CIRCUITS = 19,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	CAN_SPAWN_INVENTIONS = 20,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	CAN_SPAWN_CONSUMABLES = 21,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	CAN_USE_ROOM_RESET_BUTTON = 22,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	CAN_USE_PLAY_GIZMOS_TOGGLE = 23,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	AUTO_ASSIGNED_PLAYER_TAGS = 24,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	CAN_USE_RRS = 25,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	ROOM_LEVEL_THRESHOLD = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	CAN_SAVE_ROOM = 1001,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	CAN_PUBLISH_ROOM = 1002,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	CAN_CLONE_ROOM = 1003,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	CAN_RESTORE_ROOM = 1004,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	CAN_EDIT_MAIN_ROOM_SETTINGS = 1006,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	CAN_EDIT_ROOM_ECON_SETTINGS = 1007,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	CAN_CREATE_SUBROOMS = 1008,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	CAN_NAME_SUBROOMS = 1009,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	CAN_CLONE_SUBROOMS = 1010,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	CAN_MOVE_SUBROOMS = 1011,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	CAN_DELETE_SUBROOMS = 1012,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	CAN_EDIT_SUBROOM_SETTINGS = 1013,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	CAN_RESET_CLOUD_VARIABLES = 1014,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	CAN_DELETE_CLOUD_VARIABLES = 1015,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	CAN_EDIT_ROOM_PROGRESSION = 1016,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	CAN_REMOVE_ROOM_BANS = 1017,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	CAN_ADD_ROOM_BANS = 1018
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal class JMMDBPIBFFH : IHPCBACDFLO, BNBCPDKAMPF, JMNKGPNIJDD, IOGBAFLAHBM<PMGDAMAPCCO>
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	internal static readonly POLKGGMLGJA AGHLFHBJMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	internal readonly CKPEEJDMGED BFHCAFCKPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private string? PPMEJPDEFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private string? NPHFCJOOJEI;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool BJEFJAKBBOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x708CBF0", Offset = "0x708BBF0", VA = "0x18708CBF0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool JOBKOOOGADB
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x708D7D0", Offset = "0x708C7D0", VA = "0x18708D7D0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool DGBOLMFKDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x708D910", Offset = "0x708C910", VA = "0x18708D910", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool JEIHOIHADNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x708E110", Offset = "0x708D110", VA = "0x18708E110", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool AMOPJDIINLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x708D6E0", Offset = "0x708C6E0", VA = "0x18708D6E0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool IDCMGAFPKJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x708D870", Offset = "0x708C870", VA = "0x18708D870", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public MJKPLCNHABA BHFPFFONGFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x95D990", Offset = "0x95C990", VA = "0x18095D990", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(MJKPLCNHABA);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x85AE40", Offset = "0x859E40", VA = "0x18085AE40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string LLINIIBCNPA
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x708DCF0", Offset = "0x708CCF0", VA = "0x18708DCF0", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x708CA50", Offset = "0x708BA50", VA = "0x18708CA50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string JMMBIMLJNCG
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x708DCF0", Offset = "0x708CCF0", VA = "0x18708DCF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool JFFFIMDGLIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x95D930", Offset = "0x95C930", VA = "0x18095D930")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xAD84D0", Offset = "0xAD74D0", VA = "0x180AD84D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool PECOEEJDIMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x708DF90", Offset = "0x708CF90", VA = "0x18708DF90", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public HKJAKIBPJJH MHIPMAKFFPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x708D820", Offset = "0x708C820", VA = "0x18708D820", Slot = "20")]
		get
		{
			return default(HKJAKIBPJJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool KKCNHBINFEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x708E0C0", Offset = "0x708D0C0", VA = "0x18708E0C0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool LCHEEKBGPMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x708DC00", Offset = "0x708CC00", VA = "0x18708DC00", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool KEIAAKBPHDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x708CBA0", Offset = "0x708BBA0", VA = "0x18708CBA0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool PONHKIJHFMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x708DCA0", Offset = "0x708CCA0", VA = "0x18708DCA0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool EDAAFKAACJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x708CCC0", Offset = "0x708BCC0", VA = "0x18708CCC0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool OJMKEKPEAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x708DC50", Offset = "0x708CC50", VA = "0x18708DC50", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool CCOPLLBCCML
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x708D8C0", Offset = "0x708C8C0", VA = "0x18708D8C0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool IIJGAGFAAEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x708CAA0", Offset = "0x708BAA0", VA = "0x18708CAA0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> HDPJOFJPFPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x708DAF0", Offset = "0x708CAF0", VA = "0x18708DAF0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool KOGNALIPKGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x708CBF0", Offset = "0x708BBF0", VA = "0x18708CBF0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool PDFKOKBDCPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x708D6E0", Offset = "0x708C6E0", VA = "0x18708D6E0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool AKHGNAGHAJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x708D7D0", Offset = "0x708C7D0", VA = "0x18708D7D0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool NIPFECOJPML
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x708D730", Offset = "0x708C730", VA = "0x18708D730", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool CPEPGCMGKIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x708DF40", Offset = "0x708CF40", VA = "0x18708DF40", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool FDMLLFGDLAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x708D910", Offset = "0x708C910", VA = "0x18708D910", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool MGMKFLAGGNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x708CD10", Offset = "0x708BD10", VA = "0x18708CD10", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool KNIJKIHLNAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x708E110", Offset = "0x708D110", VA = "0x18708E110", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool FNMLOIGFODJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x708D870", Offset = "0x708C870", VA = "0x18708D870", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event PFOHJLJDENJ<PMGDAMAPCCO> DMNHGNNAMNB
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x708CAF0", Offset = "0x708BAF0", VA = "0x18708CAF0", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x708DB50", Offset = "0x708CB50", VA = "0x18708DB50", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2C3EB90", Offset = "0x2C3DB90", VA = "0x182C3EB90", Slot = "6")]
	public (bool, T?) KNAAGAJOBED<T>(PMGDAMAPCCO MPBEIHLHJJF) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2C3EB30", Offset = "0x2C3DB30", VA = "0x182C3EB30")]
	public JMMDBPIBFFH GABHJFBINJI<T>(PMGDAMAPCCO MPBEIHLHJJF, bool HDMHDLMILAL, T JJCEIJMGOAB) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x708EC10", Offset = "0x708DC10", VA = "0x18708EC10")]
	public JMMDBPIBFFH(MJKPLCNHABA PJGMBJGGNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x708EA00", Offset = "0x708DA00", VA = "0x18708EA00")]
	public JMMDBPIBFFH(MJKPLCNHABA PJGMBJGGNNH, [Optional] string? PPMEJPDEFKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x708EB80", Offset = "0x708DB80", VA = "0x18708EB80")]
	public JMMDBPIBFFH(JMMDBPIBFFH MKPBFFCAMDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x708EA20", Offset = "0x708DA20", VA = "0x18708EA20")]
	internal JMMDBPIBFFH(MJKPLCNHABA IJCOLOFIPMB, [Optional] string? PPMEJPDEFKG, [Optional] JMMDBPIBFFH? MKPBFFCAMDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x708CC40", Offset = "0x708BC40", VA = "0x18708CC40")]
	public static HJPCBBEBBEG BMHNOLCFFBI(PMGDAMAPCCO MPBEIHLHJJF)
	{
		return default(HJPCBBEBBEG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x708E950", Offset = "0x708D950", VA = "0x18708E950")]
	public void PPCMLECELJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x708E160", Offset = "0x708D160", VA = "0x18708E160")]
	internal JMMDBPIBFFH NOOIJNKPJBC(JMMDBPIBFFH ADPGOCDLDNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x708E4E0", Offset = "0x708D4E0", VA = "0x18708E4E0")]
	internal IReadOnlyCollection<PMGDAMAPCCO> PANBNAPFBFN(JMMDBPIBFFH MKPBFFCAMDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x708DFE0", Offset = "0x708CFE0", VA = "0x18708DFE0")]
	public bool MMPCOCIPFOL(PMGDAMAPCCO MPBEIHLHJJF, bool HDMHDLMILAL, string HJCBOMOPLOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x708D9F0", Offset = "0x708C9F0", VA = "0x18708D9F0")]
	public (bool, string) JLHOMCENJLC(PMGDAMAPCCO MPBEIHLHJJF)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x708D780", Offset = "0x708C780", VA = "0x18708D780")]
	internal void EPGNIOEBMOK(PMGDAMAPCCO MPBEIHLHJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x708DD40", Offset = "0x708CD40", VA = "0x18708DD40")]
	public EBNHAOOBKAH MFHKFOLMDED(Func<MJKPLCNHABA, Guid> NBMNINLHBPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x708CD60", Offset = "0x708BD60", VA = "0x18708CD60")]
	public void CLAHHIHLJJL(EBNHAOOBKAH MFJENEFNPAP, Func<Guid, MJKPLCNHABA> NNMKEPECMIF, [Optional] MJKPLCNHABA? FOLJIGILGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x708D960", Offset = "0x708C960", VA = "0x18708D960")]
	[CompilerGenerated]
	private void JLGOILKJNBD(PMGDAMAPCCO GOGFNMJBPLI, MNAKJIEDOMJ HMBJFCLGFMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class DAJPIGNAPEP : OOIDPLDEKDH, JOEFCHENJKC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class FPIENFBFBNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public JMMDBPIBFFH newRole;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public FPIENFBFBNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x708CA20", Offset = "0x708BA20", VA = "0x18708CA20")]
		internal bool CLILGMFBHNM(JMMDBPIBFFH rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class CPFDBIGOMHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public MJKPLCNHABA roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public CPFDBIGOMHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7086390", Offset = "0x7085390", VA = "0x187086390")]
		internal bool DKECHFEEBBE(MJKPLCNHABA r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct KJNHGPEOLOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public DAJPIGNAPEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public KECMDPPEFHG roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<OCKHHKAANBO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x708FB90", Offset = "0x708EB90", VA = "0x18708FB90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7090200", Offset = "0x708F200", VA = "0x187090200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class MBHFKPBIBOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public MBHFKPBIBOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7090380", Offset = "0x708F380", VA = "0x187090380")]
		internal void IOKMPLHEBHB(EBNHAOOBKAH r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7090260", Offset = "0x708F260", VA = "0x187090260")]
		internal void FJODLKGGGCB(EBNHAOOBKAH r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct JFCEFDHGEOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public KECMDPPEFHG roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class ABAJINIAMGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Func<EBNHAOOBKAH, MNAKJIEDOMJ> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public ABAJINIAMGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7084450", Offset = "0x7083450", VA = "0x187084450")]
		internal void JOMIBNJFANJ(EBNHAOOBKAH r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7084420", Offset = "0x7083420", VA = "0x187084420")]
		internal void ENJMNDCAAEF(EBNHAOOBKAH r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x70843F0", Offset = "0x70833F0", VA = "0x1870843F0")]
		internal void DEMECNGBHEI(EBNHAOOBKAH r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class JFCCOKJGKHJ<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private struct <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public JFCCOKJGKHJ<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private TaskAwaiter<OCKHHKAANBO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x35CB9B0", Offset = "0x35CA9B0", VA = "0x1835CB9B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0xA6A710", Offset = "0xA69710", VA = "0x180A6A710", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public PMGDAMAPCCO rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public MJKPLCNHABA accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public HJPCBBEBBEG recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public DAJPIGNAPEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public JFCCOKJGKHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x410BF20", Offset = "0x410AF20", VA = "0x18410BF20")]
		[AsyncStateMachine(typeof(JFCCOKJGKHJ<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void EFPIDMFLIHG()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct ODDOIOAADKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public IReadOnlyList<HPNPEDFBJMJ> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct BEBAHHFHKIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public LGFJNGBIAFF rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public KECMDPPEFHG roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public IReadOnlyDictionary<MJKPLCNHABA, JMMDBPIBFFH> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public KKGAIAJPKOC debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7084D50", Offset = "0x7083D50", VA = "0x187084D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7085860", Offset = "0x7084860", VA = "0x187085860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly LGFJNGBIAFF CKHGOCNELJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly KGECCBODKPA ELFJNLALPPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly KKGAIAJPKOC JJHGHICMIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly Dictionary<int, JMMDBPIBFFH> DFJODMOLCKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	internal readonly Dictionary<MJKPLCNHABA, JMMDBPIBFFH> IBLDALGOBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	internal readonly Dictionary<MJKPLCNHABA, JMMDBPIBFFH> PLDEJJAOGMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	internal readonly List<JMMDBPIBFFH> BOCFDMBMBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private bool AFMKJHNPIFK;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly PMGDAMAPCCO[] JPIJAANDHEN;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public MBCFKJFIAFA EEDBPOJINJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<IHPCBACDFLO> GOGPFKDOOPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x708A0B0", Offset = "0x70890B0", VA = "0x18708A0B0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event BINAPHFAHGP BCMIKBJBDEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7086C20", Offset = "0x7085C20", VA = "0x187086C20", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x70885D0", Offset = "0x70875D0", VA = "0x1870885D0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7086CC0", Offset = "0x7085CC0", VA = "0x187086CC0")]
	[ONAOIKEPAJE(NOFONODCPKJ.Room, IKAJKCKEGIH.None)]
	private static void BJONJIDIGGM(NDJGECDCBMH GJMGLGAJGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x708BC00", Offset = "0x708AC00", VA = "0x18708BC00")]
	[UnityEngine.Scripting.Preserve]
	internal DAJPIGNAPEP([JONIFKKOOAA(null)] LGFJNGBIAFF EAKAJNCMMND, [JONIFKKOOAA(null)] KGECCBODKPA MMEEJHKIGFM, [JONIFKKOOAA(null)] KKGAIAJPKOC JJHGHICMIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7087CB0", Offset = "0x7086CB0", VA = "0x187087CB0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x70863A0", Offset = "0x70853A0", VA = "0x1870863A0")]
	private void ANNIHPHBNIK(IEnumerable<JMMDBPIBFFH> LKLIMAMANEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7086E80", Offset = "0x7085E80", VA = "0x187086E80", Slot = "12")]
	public bool CKEANIBACNO(EEPDJJKFILM GOJJHGGKKML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x708A100", Offset = "0x7089100", VA = "0x18708A100")]
	private void MEDCJDKDOGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7089CB0", Offset = "0x7088CB0", VA = "0x187089CB0")]
	private void KMMMHPIFGJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x708B270", Offset = "0x708A270", VA = "0x18708B270", Slot = "10")]
	public IReadOnlyList<IHPCBACDFLO> PEJENINPKPM(bool MDDABFKOPBO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7089410", Offset = "0x7088410", VA = "0x187089410", Slot = "11")]
	public IHPCBACDFLO KEBMHLBFKAM(EEPDJJKFILM GOJJHGGKKML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7089EA0", Offset = "0x7088EA0", VA = "0x187089EA0")]
	private MJKPLCNHABA LMNBEPPAIDI(EEPDJJKFILM GOJJHGGKKML)
	{
		return default(MJKPLCNHABA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7088100", Offset = "0x7087100", VA = "0x187088100", Slot = "14")]
	public bool FIBDNAKMGPK(EEPDJJKFILM IOHLHPLCBNC, MJKPLCNHABA PJGMBJGGNNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x708B1D0", Offset = "0x708A1D0", VA = "0x18708B1D0", Slot = "15")]
	public IHPCBACDFLO ODLLOHIOBCE(MJKPLCNHABA PJGMBJGGNNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7088290", Offset = "0x7087290", VA = "0x187088290")]
	private static bool GFPHFIADKCP(IIPAICNLLNI INDBMBFBDLH, MJKPLCNHABA PJGMBJGGNNH, [Out] EBNHAOOBKAH? NHCPGEOOPFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7088FB0", Offset = "0x7087FB0", VA = "0x187088FB0")]
	private static void JMDPFLOMMDN(IIPAICNLLNI INDBMBFBDLH, Action<EBNHAOOBKAH> OFPJHJMGBMA, MJKPLCNHABA AOCAEHJCGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7088D20", Offset = "0x7087D20", VA = "0x187088D20")]
	private static void JMDPFLOMMDN(IIPAICNLLNI INDBMBFBDLH, Action<EBNHAOOBKAH> OFPJHJMGBMA, Predicate<MJKPLCNHABA> KKGGCFPLCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7086F50", Offset = "0x7085F50", VA = "0x187086F50")]
	private void CLLNAEJJKFI(EEPDJJKFILM GOJJHGGKKML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x708B2F0", Offset = "0x708A2F0", VA = "0x18708B2F0", Slot = "4")]
	[AsyncStateMachine(typeof(KJNHGPEOLOA))]
	public Task PHIHECGFOAG([CanBeNull] KECMDPPEFHG KBAPBJOHBKA, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
	public void CILFLILFADM(KECMDPPEFHG KBAPBJOHBKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7087DC0", Offset = "0x7086DC0", VA = "0x187087DC0")]
	private void FFGOKDAJPHC(IIPAICNLLNI MOPAIGKDFKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7087700", Offset = "0x7086700", VA = "0x187087700")]
	internal static string COIADHCBNGM(LGFJNGBIAFF CKHGOCNELJH, KECMDPPEFHG KBAPBJOHBKA, IReadOnlyDictionary<MJKPLCNHABA, JMMDBPIBFFH> IBLDALGOBEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x708A3A0", Offset = "0x70893A0", VA = "0x18708A3A0")]
	private static void NKKMKIOJMPF(KECMDPPEFHG KBAPBJOHBKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7088670", Offset = "0x7087670", VA = "0x187088670")]
	private static void GNOGIEMNENE(IIPAICNLLNI OAPGEGMJFLC, IReadOnlyDictionary<MJKPLCNHABA, JMMDBPIBFFH> IBLDALGOBEB, StringBuilder PFFACAAMJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x708B920", Offset = "0x708A920", VA = "0x18708B920")]
	private static bool PPNPPJBMNHL(string HMGNGFNEPEC, [Out] Guid JOIHEOJIHLH, [Out] MJKPLCNHABA PJGMBJGGNNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7086FC0", Offset = "0x7085FC0", VA = "0x187086FC0")]
	private static void CNJJPDHMBJB(KECMDPPEFHG KBAPBJOHBKA, StringBuilder PFFACAAMJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x29FB850", Offset = "0x29FA850", VA = "0x1829FB850", Slot = "16")]
	public bool JJNDDLHANMN<T>(MJKPLCNHABA PJGMBJGGNNH, PMGDAMAPCCO MPBEIHLHJJF, bool HDMHDLMILAL, T OEMEKBFANIG, [Optional] Action AAEBAMGIPDE) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x708A320", Offset = "0x7089320", VA = "0x18708A320", Slot = "17")]
	public string NJLIJODEMCI(PMGDAMAPCCO MPBEIHLHJJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x708A110", Offset = "0x7089110", VA = "0x18708A110")]
	private void MGNLJOINNOE(MJKPLCNHABA PJGMBJGGNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7088D00", Offset = "0x7087D00", VA = "0x187088D00")]
	private bool JDPOGDNMMNF(EEPDJJKFILM GOJJHGGKKML, MJKPLCNHABA PJGMBJGGNNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x70889C0", Offset = "0x70879C0", VA = "0x1870889C0")]
	internal JMMDBPIBFFH HCEPAFKDCFH(EEPDJJKFILM GOJJHGGKKML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x70885C0", Offset = "0x70875C0", VA = "0x1870885C0", Slot = "13")]
	public IReadOnlyList<IHPCBACDFLO> GGDAKAAFFHF(EEPDJJKFILM GOJJHGGKKML, bool NFFBLLJLGOM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x708B410", Offset = "0x708A410", VA = "0x18708B410")]
	internal IReadOnlyList<JMMDBPIBFFH> PJOIEMFGDEC(EEPDJJKFILM GOJJHGGKKML, bool NFFBLLJLGOM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7089520", Offset = "0x7088520", VA = "0x187089520")]
	private void KJOJBALEIFD(OCKHHKAANBO JLBDOCHMJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x708B640", Offset = "0x708A640", VA = "0x18708B640")]
	private static bool PKCHLOOFEGC(JMMDBPIBFFH CCOFKMHOLNB, IReadOnlyDictionary<MJKPLCNHABA, JMMDBPIBFFH> IBLDALGOBEB, [Out] IReadOnlyList<PMGDAMAPCCO> PJAOEMJCFGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7089F70", Offset = "0x7088F70", VA = "0x187089F70")]
	[AsyncStateMachine(typeof(BEBAHHFHKIJ))]
	private static Task LNEPIJGCNIB(LGFJNGBIAFF CKHGOCNELJH, KECMDPPEFHG KBAPBJOHBKA, IReadOnlyDictionary<MJKPLCNHABA, JMMDBPIBFFH> IBLDALGOBEB, KKGAIAJPKOC JJHGHICMIMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7087A10", Offset = "0x7086A10", VA = "0x187087A10")]
	[CompilerGenerated]
	internal static void DMOEFAFBACF(Func<EBNHAOOBKAH, MNAKJIEDOMJ> FILCDPLCFCJ, JFCEFDHGEOM P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x70890A0", Offset = "0x70880A0", VA = "0x1870890A0")]
	[CompilerGenerated]
	internal static bool JNEHKIDDKNA(MJKPLCNHABA PJGMBJGGNNH, PMGDAMAPCCO MPBEIHLHJJF, [Out] HPNPEDFBJMJ ONDEFKBILGD, ODDOIOAADKM P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface ECJAJGFGKBI
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IKFCJOIFCEA(EEPDJJKFILM JGDKBELEKFN, EEPDJJKFILM JHMJMNGBCAJ, IEnumerable<EEPDJJKFILM> INDNLDNAMJL, [Out] HKJAKIBPJJH BFAFKANBEBP, [Out] NKPPALMAINE IKFNFJDCHKF);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string FMKFOJNMCOI(NKPPALMAINE IIALINDGHIN);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum NKPPALMAINE : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	CantKickEventOrganizer,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	Broadcaster,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	GameInProgress,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	OpponentGameInProgress
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class DPLACFPOBAL : ECJAJGFGKBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly JOEFCHENJKC OKAKIDFOJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly KIPJAPOKPJK NNBFKJLHFPK;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x857060", Offset = "0x856060", VA = "0x180857060")]
	[RecRoom.NoEngine.Common.Preserve]
	public DPLACFPOBAL([JONIFKKOOAA(null)] JOEFCHENJKC LOBFBEDPNBJ, [JONIFKKOOAA(null)] KIPJAPOKPJK CHAFDNKPKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x708BEC0", Offset = "0x708AEC0", VA = "0x18708BEC0")]
	private static LFBHNNPIDAG? EDGCCANGLFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x708C610", Offset = "0x708B610", VA = "0x18708C610", Slot = "4")]
	public bool IKFCJOIFCEA(EEPDJJKFILM JGDKBELEKFN, EEPDJJKFILM JHMJMNGBCAJ, IEnumerable<EEPDJJKFILM> INDNLDNAMJL, [Out] HKJAKIBPJJH BFAFKANBEBP, [Out] NKPPALMAINE IKFNFJDCHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x708C510", Offset = "0x708B510", VA = "0x18708C510", Slot = "5")]
	public string FMKFOJNMCOI(NKPPALMAINE IIALINDGHIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x708BF00", Offset = "0x708AF00", VA = "0x18708BF00")]
	internal bool FMBIJEEFMCM(EEPDJJKFILM JGDKBELEKFN, EEPDJJKFILM JHMJMNGBCAJ, IEnumerable<EEPDJJKFILM> INDNLDNAMJL, AFJNCMKOAEB HAGNJOLKBDF, LFBHNNPIDAG? EHHDPKBKCAK, [Out] HKJAKIBPJJH BFAFKANBEBP, [Out] NKPPALMAINE IKFNFJDCHKF)
	{
		return default(bool);
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
