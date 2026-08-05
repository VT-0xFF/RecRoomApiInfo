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
		[Cpp2IlInjected.Address(RVA = "0x78B4D0", Offset = "0x789CD0", VA = "0x18078B4D0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6288E90", Offset = "0x6287690", VA = "0x186288E90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78C320", Offset = "0x78AB20", VA = "0x18078C320")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x78C360", Offset = "0x78AB60", VA = "0x18078C360")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum OEIJNNGENIM
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void CMJIJAPGADE<TPermission>(TPermission FAMHPEJNGOC);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void MBGKACKBPII(OGIKDEMJHKP FKJFOKDFAFI);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum ABOAFLOFJAP
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NNPIFOOMAKJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool LOPDCPMDGGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool EBDKAGMOONO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool ABFDKAIDBKB
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool PJCIFODNPIC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool FKEOJHHBPJP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool KOGPMIMNMDK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class BCAPLLOMLPL
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	public enum HFCBEFILGHG
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
	public static readonly Guid PDAALHDAFBN;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid CNGOACGPNLC;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid IFHOKBGEHHN;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid JDMEKBBLLMM;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid AGLBJHAEBML;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid NEKIJNJEPNL;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly FKBKMGMPLEB<EDMLCNGKNBJ, Guid> HAHJJDNINBJ;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<EDMLCNGKNBJ> KIIJELGIGAN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x627E070", Offset = "0x627C870", VA = "0x18627E070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x627E210", Offset = "0x627CA10", VA = "0x18627E210")]
	public static EDMLCNGKNBJ NGHNBJHGIEM(Guid ACBJLDAEBBN)
	{
		return default(EDMLCNGKNBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x627E130", Offset = "0x627C930", VA = "0x18627E130")]
	public static Guid KBHBHBOMLFC(EDMLCNGKNBJ AEKPFCOFCKN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x627E2A0", Offset = "0x627CAA0", VA = "0x18627E2A0")]
	public static bool PDKINGLMBMK(EDMLCNGKNBJ AEKPFCOFCKN, [Out] Guid ACBJLDAEBBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x627DFD0", Offset = "0x627C7D0", VA = "0x18627DFD0")]
	public static bool BPLFKFIDAFF(Guid ACBJLDAEBBN, [Out] EDMLCNGKNBJ AEKPFCOFCKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x627E1D0", Offset = "0x627C9D0", VA = "0x18627E1D0")]
	public static EDMLCNGKNBJ KEFAJNJCGDF(EDMLCNGKNBJ AEKPFCOFCKN)
	{
		return default(EDMLCNGKNBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x627DF20", Offset = "0x627C720", VA = "0x18627DF20")]
	public static HFCBEFILGHG BBGBFOEFNLJ(EDMLCNGKNBJ MOJOLIAFLFD)
	{
		return default(HFCBEFILGHG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x627E0F0", Offset = "0x627C8F0", VA = "0x18627E0F0")]
	internal static EDMLCNGKNBJ JDMNNFOFKMA(HFCBEFILGHG OAPGPIOBKEH)
	{
		return default(EDMLCNGKNBJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LEAJCFLMOAB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	FPCGHLCBKKC IJFDBNMOBNM
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<GJJCMADPMCA> BBCJIFNPOEE
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event MBGKACKBPII GCDELJIAOKE;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<GJJCMADPMCA> FIHHHBBBHKD(bool ECPEBFLIPMH = false);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GJJCMADPMCA BMGNLEADLFH(OGIKDEMJHKP FKJFOKDFAFI);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CACADBFOPGK(OGIKDEMJHKP FKJFOKDFAFI);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<GJJCMADPMCA> PILMDKHDCGL(OGIKDEMJHKP FKJFOKDFAFI, bool HDJJDKBNKBK = false);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool EKGDHNCINJO(OGIKDEMJHKP JAAAMACFJLP, EDMLCNGKNBJ AEKPFCOFCKN);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "9")]
	GJJCMADPMCA EPAAECDEOIP(EDMLCNGKNBJ AEKPFCOFCKN);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool FCPMEBAPDLA<T>(EDMLCNGKNBJ AEKPFCOFCKN, HOMALPCEHNG FAMHPEJNGOC, bool KMDPPKNLHPA, T EIMPEEDPEPM) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface IPBPAOPMLFH
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task BHHDDIOMMEJ(NHKJOGGKLGM EKBIDHDINDL, CancellationToken NCEIDHNHODH);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DJJAACPDION(NHKJOGGKLGM EKBIDHDINDL);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BIGCFBFJIIA
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	OGIKDEMJHKP DICECHIKLPL
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	MFNEBLAPOMP NBKCGLNGNLI
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	EECIHAPGBPO GAGLAHGJBMG
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<DBHHJGMOCLM> DPAGEIDCBGG;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action GPMMDOBANAK;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EDMLCNGKNBJ BMLLAJFHMFG(OGIKDEMJHKP FKJFOKDFAFI);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<DBHHJGMOCLM> OAECHIDCINB(CancellationToken NCEIDHNHODH);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task IFDPAPFDNAL(long EJLCNJNHKAA, long KEECHBIDKCE, IReadOnlyList<CAMDLPCECIN> DDBLEIMIIIP);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<OGIKDEMJHKP> IJLPKECOPHE();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class PMNHIFBDOFO
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6288FA0", Offset = "0x62877A0", VA = "0x186288FA0")]
	public static EDMLCNGKNBJ MKGIIJMAAKD(this BIGCFBFJIIA IPONPOMLBHB)
	{
		return default(EDMLCNGKNBJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface HLEEJBADCCI<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string HINMFCENCCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event CMJIJAPGADE<TPermission> LLFNKJMEECG;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class CMPIDHIEGBM
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? ENHDBFHNLMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x761490", VA = "0x180762C90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x762B90", Offset = "0x761390", VA = "0x180762B90")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x76DD40", Offset = "0x76C540", VA = "0x18076DD40")]
	protected CMPIDHIEGBM(object? BCPEGBBMBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool MJCDIIPOFFM(object? IFKKLLBODIE);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class KKPCIJGNENM<T> : CMPIDHIEGBM where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private T IEEFONKKDOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly IEqualityComparer<T> MBCBBAOFINH;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T GNAEIIEFOAF
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7DE300", Offset = "0x7DCB00", VA = "0x1807DE300")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x38E7220", Offset = "0x38E5A20", VA = "0x1838E7220", Slot = "4")]
	public override bool MJCDIIPOFFM(object? IFKKLLBODIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x38E7040", Offset = "0x38E5840", VA = "0x1838E7040")]
	public bool GDMCANHENCO(T GKFBHEAKBAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x38E76F0", Offset = "0x38E5EF0", VA = "0x1838E76F0")]
	public KKPCIJGNENM(T FEAAGHJCDLM, IEqualityComparer<T> MBCBBAOFINH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class IHINMCPPIKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<HOMALPCEHNG, bool> AFBOLPADICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<HOMALPCEHNG, CMPIDHIEGBM> OGBDJCPHIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly EOMPPJMKJJP FMKHCKDGJIC;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6286CA0", Offset = "0x62854A0", VA = "0x186286CA0")]
	public IHINMCPPIKN(EOMPPJMKJJP FMKHCKDGJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6286880", Offset = "0x6285080", VA = "0x186286880")]
	public bool CIOAPNCEAIG(HOMALPCEHNG FAMHPEJNGOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x23FD900", Offset = "0x23FC100", VA = "0x1823FD900")]
	public bool OLFPHMDBKHD<T>(HOMALPCEHNG FAMHPEJNGOC, bool KMDPPKNLHPA, T IFKKLLBODIE) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x23FD530", Offset = "0x23FBD30", VA = "0x1823FD530")]
	public (bool, T?) NDICAGFHLNK<T>(HOMALPCEHNG FAMHPEJNGOC) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6286BC0", Offset = "0x62853C0", VA = "0x186286BC0")]
	public bool OLFPHMDBKHD(HOMALPCEHNG FAMHPEJNGOC, bool KMDPPKNLHPA, object IFKKLLBODIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6286AF0", Offset = "0x62852F0", VA = "0x186286AF0")]
	public (bool, object) NDICAGFHLNK(HOMALPCEHNG FAMHPEJNGOC)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x23FD4F0", Offset = "0x23FBCF0", VA = "0x1823FD4F0")]
	private void JBHLOIEIJLL<T>(HOMALPCEHNG FAMHPEJNGOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x62867B0", Offset = "0x6284FB0", VA = "0x1862867B0")]
	private CMPIDHIEGBM AMJIDNHEOGK(HOMALPCEHNG FAMHPEJNGOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x62868F0", Offset = "0x62850F0", VA = "0x1862868F0")]
	public void HFHBBIPKKJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class HBMMGINHDNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly string HCNBCPLJCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly Type NAHOGEIFAFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly INBAMNKPNKA OBGIKOIIDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly HOMALPCEHNG JHAFAPKODJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public CGHAGGIFCHK NICHGIAGPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MNENEKMBGJM IANNNJMGIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public JOIGOJBBEKC JEMMJLEBDNA;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x62863D0", Offset = "0x6284BD0", VA = "0x1862863D0")]
	public HBMMGINHDNG(Type DIELCPFKDCN, string ALAPAHNONCA, HOMALPCEHNG FAMHPEJNGOC, CGHAGGIFCHK ABAFKMOPMPG, MNENEKMBGJM FBIIHPAFKOO, JOIGOJBBEKC AJNOJBCBAJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x62862D0", Offset = "0x6284AD0", VA = "0x1862862D0")]
	public object HOPPKFKJNKA(object? GHNNCJBDHKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x23A1D10", Offset = "0x23A0510", VA = "0x1823A1D10")]
	public void JBHLOIEIJLL<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6286320", Offset = "0x6284B20", VA = "0x186286320")]
	public void JBHLOIEIJLL(Type KBAHEIGLEIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class LJLFEPPODCN<T> : HBMMGINHDNG where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string DKDPPGCJNPH(T IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T OELFEFPFMCB(string? MEIFNHJCPHH, T FEAAGHJCDLM);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class KDLBBKDDIIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public DKDPPGCJNPH serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public OELFEFPFMCB parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public KDLBBKDDIIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3895F60", Offset = "0x3894760", VA = "0x183895F60")]
		internal string GCCBPAJHLKB(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3895F90", Offset = "0x3894790", VA = "0x183895F90")]
		internal object OGLGMONJHJB(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x39A31E0", Offset = "0x39A19E0", VA = "0x1839A31E0")]
	public LJLFEPPODCN(HOMALPCEHNG FAMHPEJNGOC, string ALAPAHNONCA, [Optional] DKDPPGCJNPH? ABAFKMOPMPG, [Optional] OELFEFPFMCB? FBIIHPAFKOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x39A26F0", Offset = "0x39A0EF0", VA = "0x1839A26F0")]
	private static object? GHFHHMFPNJI(OELFEFPFMCB? FBIIHPAFKOO, string? MEIFNHJCPHH, object? FEAAGHJCDLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x39A29F0", Offset = "0x39A11F0", VA = "0x1839A29F0")]
	private static string NDMEHJLGNHG(DKDPPGCJNPH? MMNLJNKJPHP, object? IFKKLLBODIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string CGHAGGIFCHK(object? IFKKLLBODIE);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object MNENEKMBGJM(string? MEIFNHJCPHH, [Optional] object FEAAGHJCDLM);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate CMPIDHIEGBM JOIGOJBBEKC();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class EOMPPJMKJJP
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class IAPEFPNLDIO : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal static IAPEFPNLDIO LNAOMADBHGP;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6286470", Offset = "0x6284C70", VA = "0x186286470", Slot = "4")]
		public bool Equals(List<string> GEKAGOANEHP, List<string> KFCLHHAJEPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x62865C0", Offset = "0x6284DC0", VA = "0x1862865C0", Slot = "5")]
		public int GetHashCode(List<string> ELOCHLKHPBP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public IAPEFPNLDIO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class DHGOPINPDHP : INDBLLKMKGP<OEIJNNGENIM>
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x627EB40", Offset = "0x627D340", VA = "0x18627EB40", Slot = "9")]
		public override string NDMEHJLGNHG(OEIJNNGENIM EJAHENBAJFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x627E960", Offset = "0x627D160", VA = "0x18627E960", Slot = "10")]
		protected override bool IFKCALNPBKN(string EJAHENBAJFL, [Out] OEIJNNGENIM IFKKLLBODIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x627EC30", Offset = "0x627D430", VA = "0x18627EC30")]
		public DHGOPINPDHP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly HGJAIBDADFK ALPLGGOFLGD;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly DHGOPINPDHP JBOECDKLKBE;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly List<HBMMGINHDNG> CPKMCDJDNKF;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<HOMALPCEHNG> IPFEHOFBAFF
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x761490", VA = "0x180762C90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<HOMALPCEHNG, HBMMGINHDNG> FDDAGLBGLHI
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x62858B0", Offset = "0x62840B0", VA = "0x1862858B0")]
	public EOMPPJMKJJP([Optional] IList<HBMMGINHDNG>? KLCPOOMHIOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6284900", Offset = "0x6283100", VA = "0x186284900")]
	public HBMMGINHDNG NPPLAKJKNDB(HOMALPCEHNG FAMHPEJNGOC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface FPCGHLCBKKC
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	GJJCMADPMCA KPCKBMBPKIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class LNOGOCIAAEG : FPCGHLCBKKC
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static LNOGOCIAAEG EMAIFGFCABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly AANNIJLHDPL GGCOPNFOHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal readonly IReadOnlyList<AANNIJLHDPL> AMFJOJAIODA;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public GJJCMADPMCA KPCKBMBPKIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x761490", VA = "0x180762C90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6288520", Offset = "0x6286D20", VA = "0x186288520")]
	public LNOGOCIAAEG(AANNIJLHDPL ILPIBLHGHKN, IReadOnlyList<AANNIJLHDPL> BFDIFOGJDMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6287AF0", Offset = "0x62862F0", VA = "0x186287AF0")]
	private static LNOGOCIAAEG CBDOCCIFGLN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class BEAIKHDAIGI
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<EDMLCNGKNBJ> OFMBMBDIEFA;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x627E650", Offset = "0x627CE50", VA = "0x18627E650")]
	public static bool GMBHIJHIMEC(this OGIKDEMJHKP INJFADHECIJ, EDMLCNGKNBJ AEKPFCOFCKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x627E730", Offset = "0x627CF30", VA = "0x18627E730")]
	public static bool LAKOKHIOGPJ(this OGIKDEMJHKP INJFADHECIJ, EDMLCNGKNBJ AEKPFCOFCKN, EECIHAPGBPO KENKBOBCPCN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface COAIGBJOBKN
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool ECALLHAHDLO
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool OOJMJHBFGEO
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool JPAJONOHPIM
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool MMNBOCOJIHA
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool DFFKGPKHIAG
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool IBKGLADNMJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool LCHGHEBCKKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool LPJDHKGBEAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool DGGHNINEIEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool NCOFHLEMENL
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool LHNEJNLAOMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool OOAJFIJDNND
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> MNJANFHHGBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	OEIJNNGENIM EKPMIFLNPNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface GJJCMADPMCA : COAIGBJOBKN, NNPIFOOMAKJ, HLEEJBADCCI<HOMALPCEHNG>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string MAINAGJCNBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	EDMLCNGKNBJ OLFDKAMHNEO
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) GJJGJFLPBHJ<T>(HOMALPCEHNG FAMHPEJNGOC) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum HOMALPCEHNG
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
	CAN_USE_PLAY_GIZMOS_TOGGLE = 23
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal class AANNIJLHDPL : GJJCMADPMCA, COAIGBJOBKN, NNPIFOOMAKJ, HLEEJBADCCI<HOMALPCEHNG>
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal static readonly EOMPPJMKJJP OHJCLNPGKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal readonly IHINMCPPIKN EHPHKNMOBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private string? GJDHHIICFFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private string? JBHPADECGAA;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool BCOGIAKEOGK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x627BE80", Offset = "0x627A680", VA = "0x18627BE80", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool FAEOOOEPPLB
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x627BE30", Offset = "0x627A630", VA = "0x18627BE30", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool GNIGENLDKMM
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x627C430", Offset = "0x627AC30", VA = "0x18627C430", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool DIJCGMKKPJK
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x627C6C0", Offset = "0x627AEC0", VA = "0x18627C6C0", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool EFFKKOFCIBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x627BD40", Offset = "0x627A540", VA = "0x18627BD40", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool DIDEOEBBAEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x627BDE0", Offset = "0x627A5E0", VA = "0x18627BDE0", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public EDMLCNGKNBJ OLFDKAMHNEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7DE300", Offset = "0x7DCB00", VA = "0x1807DE300", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(EDMLCNGKNBJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x76BCC0", Offset = "0x76A4C0", VA = "0x18076BCC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string HINMFCENCCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x627D4C0", Offset = "0x627BCC0", VA = "0x18627D4C0", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x627BD90", Offset = "0x627A590", VA = "0x18627BD90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string MAINAGJCNBI
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x627D4C0", Offset = "0x627BCC0", VA = "0x18627D4C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool ICBGPNMDOPO
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7D15B0", Offset = "0x7CFDB0", VA = "0x1807D15B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7D11F0", Offset = "0x7CF9F0", VA = "0x1807D11F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool ECALLHAHDLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x627D510", Offset = "0x627BD10", VA = "0x18627D510", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public OEIJNNGENIM EKPMIFLNPNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x627D640", Offset = "0x627BE40", VA = "0x18627D640", Slot = "20")]
		get
		{
			return default(OEIJNNGENIM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool OOJMJHBFGEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x627D250", Offset = "0x627BA50", VA = "0x18627D250", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool JPAJONOHPIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x627D380", Offset = "0x627BB80", VA = "0x18627D380", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool MMNBOCOJIHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x627BED0", Offset = "0x627A6D0", VA = "0x18627BED0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool DFFKGPKHIAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x627BF70", Offset = "0x627A770", VA = "0x18627BF70", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool IBKGLADNMJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x627DA10", Offset = "0x627C210", VA = "0x18627DA10", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool LCHGHEBCKKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x627D420", Offset = "0x627BC20", VA = "0x18627D420", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool LPJDHKGBEAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x627BF20", Offset = "0x627A720", VA = "0x18627BF20", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool DGGHNINEIEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x627D470", Offset = "0x627BC70", VA = "0x18627D470", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> MNJANFHHGBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x627D560", Offset = "0x627BD60", VA = "0x18627D560", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool MMHNMOMBCDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x627BE80", Offset = "0x627A680", VA = "0x18627BE80", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool FOECPCCPKDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x627BD40", Offset = "0x627A540", VA = "0x18627BD40", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool EEFOFEDHJIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x627BE30", Offset = "0x627A630", VA = "0x18627BE30", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool NCOFHLEMENL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x627C710", Offset = "0x627AF10", VA = "0x18627C710", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool LHNEJNLAOMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x627D150", Offset = "0x627B950", VA = "0x18627D150", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool EKEIBLCKFND
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x627C430", Offset = "0x627AC30", VA = "0x18627C430", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool OOAJFIJDNND
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x627D3D0", Offset = "0x627BBD0", VA = "0x18627D3D0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool MAEMMOFNFNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x627C6C0", Offset = "0x627AEC0", VA = "0x18627C6C0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool BHEFBCMMLFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x627BDE0", Offset = "0x627A5E0", VA = "0x18627BDE0", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event CMJIJAPGADE<HOMALPCEHNG> LLFNKJMEECG
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x627D1A0", Offset = "0x627B9A0", VA = "0x18627D1A0", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x627C480", Offset = "0x627AC80", VA = "0x18627C480", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x29A6CE0", Offset = "0x29A54E0", VA = "0x1829A6CE0", Slot = "6")]
	public (bool, T?) GJJGJFLPBHJ<T>(HOMALPCEHNG FAMHPEJNGOC) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x29A6E70", Offset = "0x29A5670", VA = "0x1829A6E70")]
	public AANNIJLHDPL KKEMFNKNJBF<T>(HOMALPCEHNG FAMHPEJNGOC, bool KMDPPKNLHPA, T IFKKLLBODIE) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x627DCF0", Offset = "0x627C4F0", VA = "0x18627DCF0")]
	public AANNIJLHDPL(EDMLCNGKNBJ AEKPFCOFCKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x627DDA0", Offset = "0x627C5A0", VA = "0x18627DDA0")]
	public AANNIJLHDPL(EDMLCNGKNBJ AEKPFCOFCKN, [Optional] string? GJDHHIICFFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x627DD10", Offset = "0x627C510", VA = "0x18627DD10")]
	public AANNIJLHDPL(AANNIJLHDPL OMMPDNGDPJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x627DDC0", Offset = "0x627C5C0", VA = "0x18627DDC0")]
	internal AANNIJLHDPL(EDMLCNGKNBJ PMHIFECOOHB, [Optional] string? GJDHHIICFFK, [Optional] AANNIJLHDPL? OMMPDNGDPJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x627D5C0", Offset = "0x627BDC0", VA = "0x18627D5C0")]
	public static INBAMNKPNKA NNCHHGIHCDB(HOMALPCEHNG FAMHPEJNGOC)
	{
		return default(INBAMNKPNKA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x627D0E0", Offset = "0x627B8E0", VA = "0x18627D0E0")]
	public void HFHBBIPKKJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x627D690", Offset = "0x627BE90", VA = "0x18627D690")]
	internal AANNIJLHDPL OEGOACOPKKO(AANNIJLHDPL KEOEJFNPKAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x627BFC0", Offset = "0x627A7C0", VA = "0x18627BFC0")]
	internal IReadOnlyCollection<HOMALPCEHNG> FGACGACICLO(AANNIJLHDPL OMMPDNGDPJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x627D2A0", Offset = "0x627BAA0", VA = "0x18627D2A0")]
	public bool LCNEIPIGKBJ(HOMALPCEHNG FAMHPEJNGOC, bool KMDPPKNLHPA, string NABBKEMDMOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x627C530", Offset = "0x627AD30", VA = "0x18627C530")]
	public (bool, string) GEFMGPAODJP(HOMALPCEHNG FAMHPEJNGOC)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x627D100", Offset = "0x627B900", VA = "0x18627D100")]
	internal void HFJMBKEEIEE(HOMALPCEHNG FAMHPEJNGOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x627DA60", Offset = "0x627C260", VA = "0x18627DA60")]
	public OAELBMBFCDD PNELAFAJKPC(Func<EDMLCNGKNBJ, Guid> BOABEAEHLOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x627C760", Offset = "0x627AF60", VA = "0x18627C760")]
	public void HEPGOACEKBK(OAELBMBFCDD FFIGPDNGGND, Func<Guid, EDMLCNGKNBJ> MEPFNAFIEAH, [Optional] EDMLCNGKNBJ? AGCBFMEMMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x627C630", Offset = "0x627AE30", VA = "0x18627C630")]
	[CompilerGenerated]
	private void GHLGDDACKMG(HOMALPCEHNG IFOAJGCJANH, PNIIGCPOBLH EDMJHPOPCMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class DIMIHNPOFBC : IPBPAOPMLFH, LEAJCFLMOAB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class IJFGOGKOFOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public AANNIJLHDPL newRole;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public IJFGOGKOFOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6286F50", Offset = "0x6285750", VA = "0x186286F50")]
		internal bool GCECNDEAGFB(AANNIJLHDPL rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class GEDNBBAPKEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public EDMLCNGKNBJ roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public GEDNBBAPKEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6285C00", Offset = "0x6284400", VA = "0x186285C00")]
		internal bool FCHNJACHJDI(EDMLCNGKNBJ r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct GPJEPOINODM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public DIMIHNPOFBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public NHKJOGGKLGM roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter<DBHHJGMOCLM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6285C10", Offset = "0x6284410", VA = "0x186285C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6286270", Offset = "0x6284A70", VA = "0x186286270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class DJKEMNKPAIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public DJKEMNKPAIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6284700", Offset = "0x6282F00", VA = "0x186284700")]
		internal void HBLPPKPNEJI(OAELBMBFCDD r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x62847E0", Offset = "0x6282FE0", VA = "0x1862847E0")]
		internal void HCPJNFAGHHJ(OAELBMBFCDD r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct IECMNLDPEBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public NHKJOGGKLGM roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class ONGOMDGMPKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Func<OAELBMBFCDD, PNIIGCPOBLH> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public ONGOMDGMPKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6288F10", Offset = "0x6287710", VA = "0x186288F10")]
		internal void BDPHBIJLIIH(OAELBMBFCDD r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6288F40", Offset = "0x6287740", VA = "0x186288F40")]
		internal void FDBOIBFGBIL(OAELBMBFCDD r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6288F70", Offset = "0x6287770", VA = "0x186288F70")]
		internal void PHJPHEPGHAI(OAELBMBFCDD r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class LNOBECKDGOC<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private struct <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public LNOBECKDGOC<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			private object <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			private int <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private TaskAwaiter<DBHHJGMOCLM> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x2E7EF60", Offset = "0x2E7D760", VA = "0x182E7EF60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x843D40", Offset = "0x842540", VA = "0x180843D40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public DIMIHNPOFBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public HOMALPCEHNG rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public EDMLCNGKNBJ accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public INBAMNKPNKA recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public string serializedNewValue;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public LNOBECKDGOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x39C38E0", Offset = "0x39C20E0", VA = "0x1839C38E0")]
		[AsyncStateMachine(typeof(LNOBECKDGOC<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void NOEECNIFFGD()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct ALLJBOKJOPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public IReadOnlyList<CAMDLPCECIN> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct LCKOCMMPGBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public BIGCFBFJIIA rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public NHKJOGGKLGM roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public IReadOnlyDictionary<EDMLCNGKNBJ, AANNIJLHDPL> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public OIBKIPLCFKG debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6286F80", Offset = "0x6285780", VA = "0x186286F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6287A90", Offset = "0x6286290", VA = "0x186287A90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly BIGCFBFJIIA IPONPOMLBHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly LNOGOCIAAEG EMDACDJBGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly OIBKIPLCFKG FFAGLIGABCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly Dictionary<int, AANNIJLHDPL> BNOIPKDIMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	internal readonly Dictionary<EDMLCNGKNBJ, AANNIJLHDPL> HCFPHKPEDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	internal readonly Dictionary<EDMLCNGKNBJ, AANNIJLHDPL> LCCMEALFPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal readonly List<AANNIJLHDPL> NGFLFCKIKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private bool IOMPOLCHKNB;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly HOMALPCEHNG[] PGIOJLGCKKD;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public FPCGHLCBKKC IJFDBNMOBNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<GJJCMADPMCA> BBCJIFNPOEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x627F760", Offset = "0x627DF60", VA = "0x18627F760", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event MBGKACKBPII GCDELJIAOKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6281420", Offset = "0x627FC20", VA = "0x186281420", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6281870", Offset = "0x6280070", VA = "0x186281870", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x627F090", Offset = "0x627D890", VA = "0x18627F090")]
	[OPPPCFMOGOO(CODKNAAEMCD.Room, OIAOEFLOJIJ.None)]
	private static void AJCEEBENPCL(MPCHBJGCNBP EHMBKIJNGEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6284440", Offset = "0x6282C40", VA = "0x186284440")]
	[UnityEngine.Scripting.Preserve]
	internal DIMIHNPOFBC([AKMGDNDIMPI(null)] BIGCFBFJIIA OFMPHPANFCB, [AKMGDNDIMPI(null)] LNOGOCIAAEG LEGJNOODPKH, [AKMGDNDIMPI(null)] OIBKIPLCFKG FFAGLIGABCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6280860", Offset = "0x627F060", VA = "0x186280860", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6280970", Offset = "0x627F170", VA = "0x186280970")]
	private void EJABNHLEMFA(IEnumerable<AANNIJLHDPL> GHELIBCDPCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x627F690", Offset = "0x627DE90", VA = "0x18627F690", Slot = "12")]
	public bool CACADBFOPGK(OGIKDEMJHKP FKJFOKDFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6281540", Offset = "0x627FD40", VA = "0x186281540")]
	private void GPMMDOBANAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6283AD0", Offset = "0x62822D0", VA = "0x186283AD0")]
	private void PGHFLIEIABJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x62814C0", Offset = "0x627FCC0", VA = "0x1862814C0", Slot = "10")]
	public IReadOnlyList<GJJCMADPMCA> FIHHHBBBHKD(bool ECPEBFLIPMH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x627F580", Offset = "0x627DD80", VA = "0x18627F580", Slot = "11")]
	public GJJCMADPMCA BMGNLEADLFH(OGIKDEMJHKP FKJFOKDFAFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x627EC70", Offset = "0x627D470", VA = "0x18627EC70")]
	private EDMLCNGKNBJ AAEHBEFGLPB(OGIKDEMJHKP FKJFOKDFAFI)
	{
		return default(EDMLCNGKNBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x62811F0", Offset = "0x627F9F0", VA = "0x1862811F0", Slot = "14")]
	public bool EKGDHNCINJO(OGIKDEMJHKP JAAAMACFJLP, EDMLCNGKNBJ AEKPFCOFCKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6281380", Offset = "0x627FB80", VA = "0x186281380", Slot = "15")]
	public GJJCMADPMCA EPAAECDEOIP(EDMLCNGKNBJ AEKPFCOFCKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6281910", Offset = "0x6280110", VA = "0x186281910")]
	private static bool IMOBLOKLPFC(AJMENKGJDNF PELHELKPHEM, EDMLCNGKNBJ AEKPFCOFCKN, [Out] OAELBMBFCDD? CICCMBCBNCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6283750", Offset = "0x6281F50", VA = "0x186283750")]
	private static void OGOOHGONKDB(AJMENKGJDNF PELHELKPHEM, Action<OAELBMBFCDD> BPHPCPDMFCL, EDMLCNGKNBJ DMNODCFFIGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6283840", Offset = "0x6282040", VA = "0x186283840")]
	private static void OGOOHGONKDB(AJMENKGJDNF PELHELKPHEM, Action<OAELBMBFCDD> BPHPCPDMFCL, Predicate<EDMLCNGKNBJ> CBEEEMCMNGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x62826D0", Offset = "0x6280ED0", VA = "0x1862826D0")]
	private void LACHAIBPAEM(OGIKDEMJHKP FKJFOKDFAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x627F250", Offset = "0x627DA50", VA = "0x18627F250", Slot = "4")]
	[AsyncStateMachine(typeof(GPJEPOINODM))]
	public Task BHHDDIOMMEJ([CanBeNull] NHKJOGGKLGM EKBIDHDINDL, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "5")]
	public void DJJAACPDION(NHKJOGGKLGM EKBIDHDINDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6282280", Offset = "0x6280A80", VA = "0x186282280")]
	private void KCFMGBLAGBA(AJMENKGJDNF EJLBPEOCCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6281550", Offset = "0x627FD50", VA = "0x186281550")]
	internal static string HEFPHOBJGAI(BIGCFBFJIIA IPONPOMLBHB, NHKJOGGKLGM EKBIDHDINDL, IReadOnlyDictionary<EDMLCNGKNBJ, AANNIJLHDPL> HCFPHKPEDBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x627FA50", Offset = "0x627E250", VA = "0x18627FA50")]
	private static void DMAEAICIMNN(NHKJOGGKLGM EKBIDHDINDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x627ED40", Offset = "0x627D540", VA = "0x18627ED40")]
	private static void AHIKHHIELBC(AJMENKGJDNF FEHPEACDMMJ, IReadOnlyDictionary<EDMLCNGKNBJ, AANNIJLHDPL> HCFPHKPEDBD, StringBuilder KCPLKHPGNEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x62825C0", Offset = "0x6280DC0", VA = "0x1862825C0")]
	private static bool KEALHECJLEL(string KBNDODNNEMK, [Out] Guid FLOIKPABCBH, [Out] EDMLCNGKNBJ AEKPFCOFCKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6282740", Offset = "0x6280F40", VA = "0x186282740")]
	private static void LJFKHIHMKBB(NHKJOGGKLGM EKBIDHDINDL, StringBuilder KCPLKHPGNEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x222B060", Offset = "0x2229860", VA = "0x18222B060", Slot = "16")]
	public bool FCPMEBAPDLA<T>(EDMLCNGKNBJ AEKPFCOFCKN, HOMALPCEHNG FAMHPEJNGOC, bool KMDPPKNLHPA, T EIMPEEDPEPM) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x627F370", Offset = "0x627DB70", VA = "0x18627F370")]
	private void BLJCFGMKCMJ(EDMLCNGKNBJ AEKPFCOFCKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6281850", Offset = "0x6280050", VA = "0x186281850")]
	private bool HIMDCHOBKMP(OGIKDEMJHKP FKJFOKDFAFI, EDMLCNGKNBJ AEKPFCOFCKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6281F30", Offset = "0x6280730", VA = "0x186281F30")]
	internal AANNIJLHDPL JLEJOBLGNMK(OGIKDEMJHKP FKJFOKDFAFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6283CC0", Offset = "0x62824C0", VA = "0x186283CC0", Slot = "13")]
	public IReadOnlyList<GJJCMADPMCA> PILMDKHDCGL(OGIKDEMJHKP FKJFOKDFAFI, bool HDJJDKBNKBK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6284040", Offset = "0x6282840", VA = "0x186284040")]
	internal IReadOnlyList<AANNIJLHDPL> PLPBBFMPKKB(OGIKDEMJHKP FKJFOKDFAFI, bool HDJJDKBNKBK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6282FC0", Offset = "0x62817C0", VA = "0x186282FC0")]
	private void NGNECNKNPIJ(DBHHJGMOCLM DAGPIIJPBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6281C40", Offset = "0x6280440", VA = "0x186281C40")]
	private static bool JBOJOBPNLLE(AANNIJLHDPL NDABBGNHAMC, IReadOnlyDictionary<EDMLCNGKNBJ, AANNIJLHDPL> HCFPHKPEDBD, [Out] IReadOnlyList<HOMALPCEHNG> JPJNILMIIHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6282E80", Offset = "0x6281680", VA = "0x186282E80")]
	[AsyncStateMachine(typeof(LCKOCMMPGBC))]
	private static Task LJIFOKNBICN(BIGCFBFJIIA IPONPOMLBHB, NHKJOGGKLGM EKBIDHDINDL, IReadOnlyDictionary<EDMLCNGKNBJ, AANNIJLHDPL> HCFPHKPEDBD, OIBKIPLCFKG FFAGLIGABCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x627F7B0", Offset = "0x627DFB0", VA = "0x18627F7B0")]
	[CompilerGenerated]
	internal static void CFLBJHEODOO(Func<OAELBMBFCDD, PNIIGCPOBLH> MHJDFJPMKMJ, IECMNLDPEBF P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6283CD0", Offset = "0x62824D0", VA = "0x186283CD0")]
	[CompilerGenerated]
	internal static bool PKHCMBJBJLL(EDMLCNGKNBJ AEKPFCOFCKN, HOMALPCEHNG FAMHPEJNGOC, [Out] CAMDLPCECIN GNEAEDGNJCA, ALLJBOKJOPN P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface MLFFBDCNNJB
{
	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CBLEOALBBOK(OGIKDEMJHKP KDKDOFNNLIC, OGIKDEMJHKP AAIILPJGHFI, IEnumerable<OGIKDEMJHKP> MDANKOJBHOH, [Out] OEIJNNGENIM EOLIMGGHKAA, [Out] NIEKBLGNLLO POHGEKJBOOG);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string BKHLGGLFDKC(NIEKBLGNLLO PNIOIDIGNPC);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum NIEKBLGNLLO : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	CantKickEventOrganizer,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	Broadcaster,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	GameInProgress,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	OpponentGameInProgress
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class MNMAOEPLJMD : MLFFBDCNNJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly LEAJCFLMOAB NGCOCJFMENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly ABFNBGFDLCC IAFEDIACFHA;

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x760A40", Offset = "0x75F240", VA = "0x180760A40")]
	[RecRoom.NoEngine.Common.Preserve]
	public MNMAOEPLJMD([AKMGDNDIMPI(null)] LEAJCFLMOAB FLELCGLJGDF, [AKMGDNDIMPI(null)] ABFNBGFDLCC KICFHKLHJLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6288630", Offset = "0x6286E30", VA = "0x186288630")]
	private static NJGJMBFILMP? AMJLAILJIIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6288770", Offset = "0x6286F70", VA = "0x186288770", Slot = "4")]
	public bool CBLEOALBBOK(OGIKDEMJHKP KDKDOFNNLIC, OGIKDEMJHKP AAIILPJGHFI, IEnumerable<OGIKDEMJHKP> MDANKOJBHOH, [Out] OEIJNNGENIM EOLIMGGHKAA, [Out] NIEKBLGNLLO POHGEKJBOOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6288670", Offset = "0x6286E70", VA = "0x186288670", Slot = "5")]
	public string BKHLGGLFDKC(NIEKBLGNLLO PNIOIDIGNPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6288870", Offset = "0x6287070", VA = "0x186288870")]
	internal bool OBPOJAGBEED(OGIKDEMJHKP KDKDOFNNLIC, OGIKDEMJHKP AAIILPJGHFI, IEnumerable<OGIKDEMJHKP> MDANKOJBHOH, EECIHAPGBPO KENKBOBCPCN, NJGJMBFILMP? MLFBOMFIGNM, [Out] OEIJNNGENIM EOLIMGGHKAA, [Out] NIEKBLGNLLO POHGEKJBOOG)
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
