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
		[Cpp2IlInjected.Address(RVA = "0x79B610", Offset = "0x79AA10", VA = "0x18079B610")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6454FC0", Offset = "0x64543C0", VA = "0x186454FC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79C170", Offset = "0x79B570", VA = "0x18079C170")]
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
		[Cpp2IlInjected.Address(RVA = "0x79C1B0", Offset = "0x79B5B0", VA = "0x18079C1B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum ODAFCODMILG
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void LCJJPBACECE<TPermission>(TPermission JOIEFBKMPPG);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void BBNMIBNHGNK(MCGPJKMOCMD IFMBCNELBJG);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum MBOMIJCNNGK
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface EAOKDPONGPM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool ONOJHHNHHJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool FPKCHMKNJJI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool BJGLOAEILPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool DHAKACAGCFO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool EBGHHIIJMDK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool LHKBBIAJMFH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class FFAKIIIIFGJ
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	public enum ILPHAJEEIAI
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
	public static readonly Guid JNLKPPDDBMO;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid PKJLBOKEMLA;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid NJNFAEJIGED;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid HDHBJKFBKDE;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid JFCGFNFJAOO;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid FPHMOEPGKJN;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly DFFDBGFEMJN<BJCGPHDFGJF, Guid> BBJHNAAFNAC;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<BJCGPHDFGJF> LKGECKKANCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x644B3D0", Offset = "0x644A7D0", VA = "0x18644B3D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x644B450", Offset = "0x644A850", VA = "0x18644B450")]
	public static BJCGPHDFGJF MJFBBOLKNOI(Guid GJKCBNEBGAL)
	{
		return default(BJCGPHDFGJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x644B160", Offset = "0x644A560", VA = "0x18644B160")]
	public static Guid CHABLGLLOPI(BJCGPHDFGJF DKCFGDAHFJN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x644B0D0", Offset = "0x644A4D0", VA = "0x18644B0D0")]
	public static bool AICOFGGBBNF(BJCGPHDFGJF DKCFGDAHFJN, [Out] Guid GJKCBNEBGAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x644B2F0", Offset = "0x644A6F0", VA = "0x18644B2F0")]
	public static bool FGIEBMODNBL(Guid GJKCBNEBGAL, [Out] BJCGPHDFGJF DKCFGDAHFJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x644B200", Offset = "0x644A600", VA = "0x18644B200")]
	public static BJCGPHDFGJF CMAFOGFEKKA(BJCGPHDFGJF DKCFGDAHFJN)
	{
		return default(BJCGPHDFGJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x644B240", Offset = "0x644A640", VA = "0x18644B240")]
	public static ILPHAJEEIAI DGMKNHCNCBM(BJCGPHDFGJF BLLKFOGJPEK)
	{
		return default(ILPHAJEEIAI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x644B390", Offset = "0x644A790", VA = "0x18644B390")]
	internal static BJCGPHDFGJF ILHGPGIGBOK(ILPHAJEEIAI OLGMLEFLNFI)
	{
		return default(BJCGPHDFGJF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NAEGOCJNMAN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	DBKBGOIPOME BLGDDDMBEJC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<PKIPHIGLOMN> BFKMNAAFJBE
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event BBNMIBNHGNK JDHBPLJAHDC;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<PKIPHIGLOMN> CMLGIBGAJHN(bool OMEIDJJJOOL = false);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PKIPHIGLOMN OEIMKOJCOOL(MCGPJKMOCMD IFMBCNELBJG);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool POBLGNALLPN(MCGPJKMOCMD IFMBCNELBJG);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<PKIPHIGLOMN> OLEOFLCJGCL(MCGPJKMOCMD IFMBCNELBJG, bool LEECBKLJJCD = false);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GHHIDKHGKLE(MCGPJKMOCMD PPLBGNIBIPO, BJCGPHDFGJF DKCFGDAHFJN);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "9")]
	PKIPHIGLOMN GIHKCAOJMNG(BJCGPHDFGJF DKCFGDAHFJN);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool ENGPIDGIIJC<T>(BJCGPHDFGJF DKCFGDAHFJN, FGJOPBHCEDG JOIEFBKMPPG, bool GKOBODNJMON, T GKKBCNLLJNC) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ECOOAPKBDHI
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task CBCACDBCJDI(LBKGIILDFAD BMAKDMAHBAB, CancellationToken EANFAKGANNH);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MBEOFOMKHBO(LBKGIILDFAD BMAKDMAHBAB);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DJNOKJNJJAA
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	MCGPJKMOCMD LDNPDGDNPAI
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	PFGAPAENFLN BNLFNFHDBKO
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	FDKNBJIOHGE HHGOHILELOG
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<ALNDMDKLAIG> HEGKJHIEPGN;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action MPPGEHMNIEG;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BJCGPHDFGJF HGJAOKMPJHN(MCGPJKMOCMD IFMBCNELBJG);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<ALNDMDKLAIG> ANCCFKAPAEE(CancellationToken EANFAKGANNH);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task CCOBFKPIIHP(long IIAJMJMGGCI, long LNBMOIBCHHF, IReadOnlyList<HGIGBLPDOOF> LHHPNACJJEO);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<MCGPJKMOCMD> HCNKNOPBKED();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class KOMDHHIBICJ
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6454870", Offset = "0x6453C70", VA = "0x186454870")]
	public static BJCGPHDFGJF MPPDKJMBPCL(this DJNOKJNJJAA NKCMLBDEBBK)
	{
		return default(BJCGPHDFGJF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface EELLPCPFPED<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string KLEELEAPDHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event LCJJPBACECE<TPermission> DDAMNLGDPFH;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class CJEBJPDMMAE
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? NHHBNFMPJAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x772CB0", VA = "0x1807738B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x773880", Offset = "0x772C80", VA = "0x180773880")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x77CC90", Offset = "0x77C090", VA = "0x18077CC90")]
	protected CJEBJPDMMAE(object? DPDNNKJLAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool JCPHNDDGFIE(object? NMENOOMOOJP);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class BLJAKCJHECO<T> : CJEBJPDMMAE where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private T FDAAFNFFFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly IEqualityComparer<T> CIFLAHPMLGH;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T ILNPCEAPFCH
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7F31F0", Offset = "0x7F25F0", VA = "0x1807F31F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4580140", Offset = "0x457F540", VA = "0x184580140", Slot = "4")]
	public override bool JCPHNDDGFIE(object? NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x457FCE0", Offset = "0x457F0E0", VA = "0x18457FCE0")]
	public bool AGCKCGOBOJA(T PINMBMBHHKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4580440", Offset = "0x457F840", VA = "0x184580440")]
	public BLJAKCJHECO(T IEKAHKGFLJB, IEqualityComparer<T> CIFLAHPMLGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class EILAHCPJEIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<FGJOPBHCEDG, bool> PDEFLPOACKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<FGJOPBHCEDG, CJEBJPDMMAE> BDDIDJLDCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly CEKDFKAEOLH EPMGEOMFKCP;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x644AAE0", Offset = "0x6449EE0", VA = "0x18644AAE0")]
	public EILAHCPJEIJ(CEKDFKAEOLH EPMGEOMFKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x644A7F0", Offset = "0x6449BF0", VA = "0x18644A7F0")]
	public bool KOAEHKPPPEC(FGJOPBHCEDG JOIEFBKMPPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x23D3B90", Offset = "0x23D2F90", VA = "0x1823D3B90")]
	public bool OPLLNFJPHAP<T>(FGJOPBHCEDG JOIEFBKMPPG, bool GKOBODNJMON, T NMENOOMOOJP) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x23D37C0", Offset = "0x23D2BC0", VA = "0x1823D37C0")]
	public (bool, T?) LFCAOOIFAMO<T>(FGJOPBHCEDG JOIEFBKMPPG) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x644AA00", Offset = "0x6449E00", VA = "0x18644AA00")]
	public bool OPLLNFJPHAP(FGJOPBHCEDG JOIEFBKMPPG, bool GKOBODNJMON, object NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x644A860", Offset = "0x6449C60", VA = "0x18644A860")]
	public (bool, object) LFCAOOIFAMO(FGJOPBHCEDG JOIEFBKMPPG)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x23D3780", Offset = "0x23D2B80", VA = "0x1823D3780")]
	private void KNOPOCKFPOM<T>(FGJOPBHCEDG JOIEFBKMPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x644A930", Offset = "0x6449D30", VA = "0x18644A930")]
	private CJEBJPDMMAE NLINBBJFFBP(FGJOPBHCEDG JOIEFBKMPPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x644A5F0", Offset = "0x64499F0", VA = "0x18644A5F0")]
	public void IKDALBBMIHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class OPHLLMJBBFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly string PBLHAHKJEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly Type AFKEHMBOGBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly LMBJCBKPMHK PDONDJGDGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly FGJOPBHCEDG IECMJIJKJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public APMAIHOBHGG ILBNAHGLEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public FDJOPEPFGIJ OKPGOJINFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public DKMIAIMPFLA AIJOPIHEKJF;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6455140", Offset = "0x6454540", VA = "0x186455140")]
	public OPHLLMJBBFL(Type HDNAPDPFEMP, string CEFKDFHJEPL, FGJOPBHCEDG JOIEFBKMPPG, APMAIHOBHGG MKEHLBBMGOD, FDJOPEPFGIJ MNMGKLAMGMM, DKMIAIMPFLA LCBKDKMOCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6455040", Offset = "0x6454440", VA = "0x186455040")]
	public object DGFCFBDDNJO(object? LFMLAKDHEFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2663080", Offset = "0x2662480", VA = "0x182663080")]
	public void KNOPOCKFPOM<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6455090", Offset = "0x6454490", VA = "0x186455090")]
	public void KNOPOCKFPOM(Type OLKCFGEIJHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class GLLCPNNAGIM<T> : OPHLLMJBBFL where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string NIGNJIEOAFG(T NMENOOMOOJP);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T KAPHJIKHLPO(string? DLKGBCKLNFO, T IEKAHKGFLJB);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class AHKDFHLEFME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public NIGNJIEOAFG serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public KAPHJIKHLPO parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public AHKDFHLEFME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x355BAF0", Offset = "0x355AEF0", VA = "0x18355BAF0")]
		internal string GIDILCEAPKA(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x355BA50", Offset = "0x355AE50", VA = "0x18355BA50")]
		internal object DHIOBCCBKJA(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3575310", Offset = "0x3574710", VA = "0x183575310")]
	public GLLCPNNAGIM(FGJOPBHCEDG JOIEFBKMPPG, string CEFKDFHJEPL, [Optional] NIGNJIEOAFG? MKEHLBBMGOD, [Optional] KAPHJIKHLPO? MNMGKLAMGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3574A30", Offset = "0x3573E30", VA = "0x183574A30")]
	private static object? JKMDPBEAKHM(KAPHJIKHLPO? MNMGKLAMGMM, string? DLKGBCKLNFO, object? IEKAHKGFLJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3574240", Offset = "0x3573640", VA = "0x183574240")]
	private static string ALIOEPOJFBC(NIGNJIEOAFG? LGJHPFNPEHH, object? NMENOOMOOJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string APMAIHOBHGG(object? NMENOOMOOJP);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object FDJOPEPFGIJ(string? DLKGBCKLNFO, [Optional] object IEKAHKGFLJB);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate CJEBJPDMMAE DKMIAIMPFLA();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class CEKDFKAEOLH
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class EMBDDDMNFDD : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal static EMBDDDMNFDD NMGLFNHIICP;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x644AD90", Offset = "0x644A190", VA = "0x18644AD90", Slot = "4")]
		public bool Equals(List<string> OPHKAEHAFCM, List<string> CLGLFIMLHLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x644AEE0", Offset = "0x644A2E0", VA = "0x18644AEE0", Slot = "5")]
		public int GetHashCode(List<string> ECLCDMJMICA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public EMBDDDMNFDD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class HMNMKNOFCJG : FIIPPEBMGAN<ODAFCODMILG>
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x644BBB0", Offset = "0x644AFB0", VA = "0x18644BBB0", Slot = "9")]
		public override string ALIOEPOJFBC(ODAFCODMILG CGOLCEEBMBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x644BCA0", Offset = "0x644B0A0", VA = "0x18644BCA0", Slot = "10")]
		protected override bool OMFCGOMFFKI(string CGOLCEEBMBE, [Out] ODAFCODMILG NMENOOMOOJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x644BE80", Offset = "0x644B280", VA = "0x18644BE80")]
		public HMNMKNOFCJG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly KLNCIENKJFM MOMIHBCMLMH;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly HMNMKNOFCJG GJPCEAGKIAE;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly List<OPHLLMJBBFL> FPBJCGKOAMP;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<FGJOPBHCEDG> MAEBGMFDPMK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x772CB0", VA = "0x1807738B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<FGJOPBHCEDG, OPHLLMJBBFL> LGBKMBAOHML
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6449730", Offset = "0x6448B30", VA = "0x186449730")]
	public CEKDFKAEOLH([Optional] IList<OPHLLMJBBFL>? AGFHOCANCMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x64488C0", Offset = "0x6447CC0", VA = "0x1864488C0")]
	public OPHLLMJBBFL HIDJHIFGGFN(FGJOPBHCEDG JOIEFBKMPPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface DBKBGOIPOME
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	PKIPHIGLOMN HGLMCBFGAGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class JPBAPIMCKEA : DBKBGOIPOME
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static JPBAPIMCKEA KGLJOLNOAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly JHHMNACAKOM DMCAMKEMAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal readonly IReadOnlyList<JHHMNACAKOM> KNGADIBAKPA;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public PKIPHIGLOMN HGLMCBFGAGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x772CB0", VA = "0x1807738B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6454760", Offset = "0x6453B60", VA = "0x186454760")]
	public JPBAPIMCKEA(JHHMNACAKOM PGLFKPGMELO, IReadOnlyList<JHHMNACAKOM> EHKHPMBNDLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6453D30", Offset = "0x6453130", VA = "0x186453D30")]
	private static JPBAPIMCKEA BJJHNGBIDPK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class FLEKBCGOPCL
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<BJCGPHDFGJF> NPNOONEKAAM;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x644B880", Offset = "0x644AC80", VA = "0x18644B880")]
	public static bool MFNCONEHNOL(this MCGPJKMOCMD KOKKPJCIBFH, BJCGPHDFGJF DKCFGDAHFJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x644B800", Offset = "0x644AC00", VA = "0x18644B800")]
	public static bool GNAAJPMPNAF(this MCGPJKMOCMD KOKKPJCIBFH, BJCGPHDFGJF DKCFGDAHFJN, FDKNBJIOHGE FGNMCMEPKCM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface OHCGHEOLDOJ
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool INHHAOBMGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool LIFEDIJBLOL
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool HOHMKHCKJPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool PDKFNJBNDMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool AHLCHKHKGMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool AGJEGJPBFMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool OBLGKNBBGEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool NFMMNPIKBGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool LACPPBBAAJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool KMLIDHJFNCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool KAPKGNMIBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool OOEPICMNMAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> PBPHDMJPNHB
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	ODAFCODMILG DBJNIMCAEBC
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface PKIPHIGLOMN : OHCGHEOLDOJ, EAOKDPONGPM, EELLPCPFPED<FGJOPBHCEDG>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string HKMCEMKKKCG
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	BJCGPHDFGJF CIGLDDAICAK
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) LJEPIMIDLDA<T>(FGJOPBHCEDG JOIEFBKMPPG) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum FGJOPBHCEDG
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
	AUTO_ASSIGNED_PLAYER_TAGS = 24
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal class JHHMNACAKOM : PKIPHIGLOMN, OHCGHEOLDOJ, EAOKDPONGPM, EELLPCPFPED<FGJOPBHCEDG>
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal static readonly CEKDFKAEOLH FLMLAHPAGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly EILAHCPJEIJ DMIEKMMNOBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private string? BBLJJPKPCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private string? BBFGAKELDHC;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool PFLGOJFLOEF
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x644C6A0", Offset = "0x644BAA0", VA = "0x18644C6A0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool KCCAPDDBFLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x644C390", Offset = "0x644B790", VA = "0x18644C390", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool PENFLIMFEIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x644C480", Offset = "0x644B880", VA = "0x18644C480", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool JCLMPIDOFDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x644BEC0", Offset = "0x644B2C0", VA = "0x18644BEC0", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool OPELLAEMKBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x644CEF0", Offset = "0x644C2F0", VA = "0x18644CEF0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool EPNFAFLHLFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x644C520", Offset = "0x644B920", VA = "0x18644C520", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public BJCGPHDFGJF CIGLDDAICAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7F31F0", Offset = "0x7F25F0", VA = "0x1807F31F0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(BJCGPHDFGJF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x77FF70", Offset = "0x77F370", VA = "0x18077FF70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string KLEELEAPDHL
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x644CE40", Offset = "0x644C240", VA = "0x18644CE40", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x644CD00", Offset = "0x644C100", VA = "0x18644CD00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string HKMCEMKKKCG
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x644CE40", Offset = "0x644C240", VA = "0x18644CE40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool CBOJKMBODBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x85A4E0", Offset = "0x8598E0", VA = "0x18085A4E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x859DB0", Offset = "0x8591B0", VA = "0x180859DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool INHHAOBMGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x644CF40", Offset = "0x644C340", VA = "0x18644CF40", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public ODAFCODMILG DBJNIMCAEBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x644CF90", Offset = "0x644C390", VA = "0x18644CF90", Slot = "20")]
		get
		{
			return default(ODAFCODMILG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool LIFEDIJBLOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x644C4D0", Offset = "0x644B8D0", VA = "0x18644C4D0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool HOHMKHCKJPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x644DA10", Offset = "0x644CE10", VA = "0x18644DA10", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool PDKFNJBNDMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x644CDF0", Offset = "0x644C1F0", VA = "0x18644CDF0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool AHLCHKHKGMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x644CBB0", Offset = "0x644BFB0", VA = "0x18644CBB0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool AGJEGJPBFMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x644C3E0", Offset = "0x644B7E0", VA = "0x18644C3E0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool OBLGKNBBGEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x644C340", Offset = "0x644B740", VA = "0x18644C340", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool NFMMNPIKBGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x644C430", Offset = "0x644B830", VA = "0x18644C430", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool LACPPBBAAJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x644DD90", Offset = "0x644D190", VA = "0x18644DD90", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> PBPHDMJPNHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x644CE90", Offset = "0x644C290", VA = "0x18644CE90", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool EPDPACFHPGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x644C6A0", Offset = "0x644BAA0", VA = "0x18644C6A0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool AMIGPPOBDHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x644CEF0", Offset = "0x644C2F0", VA = "0x18644CEF0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool BOJHCOOLFGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x644C390", Offset = "0x644B790", VA = "0x18644C390", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool KMLIDHJFNCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x644C6F0", Offset = "0x644BAF0", VA = "0x18644C6F0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool KAPKGNMIBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x644DAF0", Offset = "0x644CEF0", VA = "0x18644DAF0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool POAGEGFAIPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x644C480", Offset = "0x644B880", VA = "0x18644C480", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool OOEPICMNMAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x644DD40", Offset = "0x644D140", VA = "0x18644DD40", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool BPFBBNJFCNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x644BEC0", Offset = "0x644B2C0", VA = "0x18644BEC0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool KDIBKAFMEDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x644C520", Offset = "0x644B920", VA = "0x18644C520", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event LCJJPBACECE<FGJOPBHCEDG> DDAMNLGDPFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x644C290", Offset = "0x644B690", VA = "0x18644C290", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x644CFE0", Offset = "0x644C3E0", VA = "0x18644CFE0", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x255D520", Offset = "0x255C920", VA = "0x18255D520", Slot = "6")]
	public (bool, T?) LJEPIMIDLDA<T>(FGJOPBHCEDG JOIEFBKMPPG) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x255D4E0", Offset = "0x255C8E0", VA = "0x18255D4E0")]
	public JHHMNACAKOM LDIIPOGGOFJ<T>(FGJOPBHCEDG JOIEFBKMPPG, bool GKOBODNJMON, T NMENOOMOOJP) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x644DE90", Offset = "0x644D290", VA = "0x18644DE90")]
	public JHHMNACAKOM(BJCGPHDFGJF DKCFGDAHFJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x644DE70", Offset = "0x644D270", VA = "0x18644DE70")]
	public JHHMNACAKOM(BJCGPHDFGJF DKCFGDAHFJN, [Optional] string? BBLJJPKPCHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x644DEB0", Offset = "0x644D2B0", VA = "0x18644DEB0")]
	public JHHMNACAKOM(JHHMNACAKOM CLMHLJJGEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x644DF40", Offset = "0x644D340", VA = "0x18644DF40")]
	internal JHHMNACAKOM(BJCGPHDFGJF LGGBIENLFHF, [Optional] string? BBLJJPKPCHC, [Optional] JHHMNACAKOM? CLMHLJJGEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x644CD50", Offset = "0x644C150", VA = "0x18644CD50")]
	public static LMBJCBKPMHK HLCCPGENNKH(FGJOPBHCEDG JOIEFBKMPPG)
	{
		return default(LMBJCBKPMHK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x644CDD0", Offset = "0x644C1D0", VA = "0x18644CDD0")]
	public void IKDALBBMIHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x644BF10", Offset = "0x644B310", VA = "0x18644BF10")]
	internal JHHMNACAKOM AKHKAEDAOOF(JHHMNACAKOM EMNLEIFEHMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x644C740", Offset = "0x644BB40", VA = "0x18644C740")]
	internal IReadOnlyCollection<FGJOPBHCEDG> FGLMIOHELPL(JHHMNACAKOM CLMHLJJGEOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x644C570", Offset = "0x644B970", VA = "0x18644C570")]
	public bool EGNBEMPMPNN(FGJOPBHCEDG JOIEFBKMPPG, bool GKOBODNJMON, string HPPNAOEBJFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x644CC00", Offset = "0x644C000", VA = "0x18644CC00")]
	public (bool, string) HDMCIHNBDNN(FGJOPBHCEDG JOIEFBKMPPG)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x644C650", Offset = "0x644BA50", VA = "0x18644C650")]
	internal void EJEGNGOGHOK(FGJOPBHCEDG JOIEFBKMPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x644DB40", Offset = "0x644CF40", VA = "0x18644DB40")]
	public NDKJJIJKLED PBGCMCBBFMF(Func<BJCGPHDFGJF, Guid> HBDGDFCALFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x644D090", Offset = "0x644C490", VA = "0x18644D090")]
	public void NPMFEHNFOCJ(NDKJJIJKLED FIKPBDLBKCI, Func<Guid, BJCGPHDFGJF> EDGHLNLDEDJ, [Optional] BJCGPHDFGJF? GDJNNJOHOMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x644DA60", Offset = "0x644CE60", VA = "0x18644DA60")]
	[CompilerGenerated]
	private void OKJFLPGOJFM(FGJOPBHCEDG IOEBBEKFDLK, JOFOOBDNBON KJMODOAIDCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class JIJHLOMJIEP : ECOOAPKBDHI, NAEGOCJNMAN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class MPLINOLIAPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public JHHMNACAKOM newRole;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public MPLINOLIAPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x64548D0", Offset = "0x6453CD0", VA = "0x1864548D0")]
		internal bool KIPEJFMFHLM(JHHMNACAKOM rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class FMFJCOAEKMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public BJCGPHDFGJF roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public FMFJCOAEKMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x644BB10", Offset = "0x644AF10", VA = "0x18644BB10")]
		internal bool EMPGNIGGDIE(BJCGPHDFGJF r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct NMMCKLHDFOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public JIJHLOMJIEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public LBKGIILDFAD roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<ALNDMDKLAIG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6454900", Offset = "0x6453D00", VA = "0x186454900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6454F60", Offset = "0x6454360", VA = "0x186454F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class JIHGCDEBKGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public JIHGCDEBKGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x644E1C0", Offset = "0x644D5C0", VA = "0x18644E1C0")]
		internal void NFMBGMJCJBJ(NDKJJIJKLED r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x644E0A0", Offset = "0x644D4A0", VA = "0x18644E0A0")]
		internal void HCJBAFMPHCG(NDKJJIJKLED r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct HFAMPFBGOOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public LBKGIILDFAD roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class GJDMEPEOIGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Func<NDKJJIJKLED, JOFOOBDNBON> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public GJDMEPEOIGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x644BB80", Offset = "0x644AF80", VA = "0x18644BB80")]
		internal void OOEIGHPOOMH(NDKJJIJKLED r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x644BB20", Offset = "0x644AF20", VA = "0x18644BB20")]
		internal void KMACJCGCMMJ(NDKJJIJKLED r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x644BB50", Offset = "0x644AF50", VA = "0x18644BB50")]
		internal void LNIIIBBMLHH(NDKJJIJKLED r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class BBPDBIBNFLO<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private struct <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public BBPDBIBNFLO<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			private object <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private int <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			private TaskAwaiter<ALNDMDKLAIG> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x2F74340", Offset = "0x2F73740", VA = "0x182F74340", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7F66B0", Offset = "0x7F5AB0", VA = "0x1807F66B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public JIJHLOMJIEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public FGJOPBHCEDG rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public BJCGPHDFGJF accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public LMBJCBKPMHK recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public string serializedNewValue;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public BBPDBIBNFLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4546180", Offset = "0x4545580", VA = "0x184546180")]
		[AsyncStateMachine(typeof(BBPDBIBNFLO<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void PIBAPKJIBPM()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct ELNFGLAOBGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public IReadOnlyList<HGIGBLPDOOF> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct CNBFDGKKNGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public DJNOKJNJJAA rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public LBKGIILDFAD roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public IReadOnlyDictionary<BJCGPHDFGJF, JHHMNACAKOM> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public EEBFEKBNEGF debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6449A80", Offset = "0x6448E80", VA = "0x186449A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x644A590", Offset = "0x6449990", VA = "0x18644A590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly DJNOKJNJJAA NKCMLBDEBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly JPBAPIMCKEA MLILBCLGEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly EEBFEKBNEGF LHDNLKCMMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, JHHMNACAKOM> MLICAJBNPPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	internal readonly Dictionary<BJCGPHDFGJF, JHHMNACAKOM> JJANBOIEKGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal readonly Dictionary<BJCGPHDFGJF, JHHMNACAKOM> IDODCDAPBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	internal readonly List<JHHMNACAKOM> APMNBMPEJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool KDPHACMDAEG;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly FGJOPBHCEDG[] NPOHCCDOCAN;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public DBKBGOIPOME BLGDDDMBEJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<PKIPHIGLOMN> BFKMNAAFJBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x64512F0", Offset = "0x64506F0", VA = "0x1864512F0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event BBNMIBNHGNK JDHBPLJAHDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x644E5F0", Offset = "0x644D9F0", VA = "0x18644E5F0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6450930", Offset = "0x644FD30", VA = "0x186450930", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6452410", Offset = "0x6451810", VA = "0x186452410")]
	[JMGGEKJCAGA(IHKKALDEJFL.Room, PLCOHLLKCIG.None)]
	private static void KLOPPCLPFPI(DIBCBJLEDOH OCLBHAALDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6453A70", Offset = "0x6452E70", VA = "0x186453A70")]
	[UnityEngine.Scripting.Preserve]
	internal JIJHLOMJIEP([MJHHGJKKIMK(null)] DJNOKJNJJAA OJLAIAHLILH, [MJHHGJKKIMK(null)] JPBAPIMCKEA PPEAPIGNHOF, [MJHHGJKKIMK(null)] EEBFEKBNEGF LHDNLKCMMID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6450820", Offset = "0x644FC20", VA = "0x186450820", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x644F9A0", Offset = "0x644EDA0", VA = "0x18644F9A0")]
	private void CDFBGAOBFDO(IEnumerable<JHHMNACAKOM> DFMJNFINIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x64534E0", Offset = "0x64528E0", VA = "0x1864534E0", Slot = "12")]
	public bool POBLGNALLPN(MCGPJKMOCMD IFMBCNELBJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6452A80", Offset = "0x6451E80", VA = "0x186452A80")]
	private void MPPGEHMNIEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x64532F0", Offset = "0x64526F0", VA = "0x1864532F0")]
	private void PMAJMCJOJAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6450590", Offset = "0x644F990", VA = "0x186450590", Slot = "10")]
	public IReadOnlyList<PKIPHIGLOMN> CMLGIBGAJHN(bool OMEIDJJJOOL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6452A90", Offset = "0x6451E90", VA = "0x186452A90", Slot = "11")]
	public PKIPHIGLOMN OEIMKOJCOOL(MCGPJKMOCMD IFMBCNELBJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6451570", Offset = "0x6450970", VA = "0x186451570")]
	private BJCGPHDFGJF IJICJNPDPCI(MCGPJKMOCMD IFMBCNELBJG)
	{
		return default(BJCGPHDFGJF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x64510C0", Offset = "0x64504C0", VA = "0x1864510C0", Slot = "14")]
	public bool GHHIDKHGKLE(MCGPJKMOCMD PPLBGNIBIPO, BJCGPHDFGJF DKCFGDAHFJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6451250", Offset = "0x6450650", VA = "0x186451250", Slot = "15")]
	public PKIPHIGLOMN GIHKCAOJMNG(BJCGPHDFGJF DKCFGDAHFJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6450D90", Offset = "0x6450190", VA = "0x186450D90")]
	private static bool FDPHIGDBPBC(KNICPOHLBMI CMGNGNKLKDD, BJCGPHDFGJF DKCFGDAHFJN, [Out] NDKJJIJKLED? KKBNDCGPMAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x64525D0", Offset = "0x64519D0", VA = "0x1864525D0")]
	private static void LAHFIFLCHMD(KNICPOHLBMI CMGNGNKLKDD, Action<NDKJJIJKLED> KOKEGNNILIC, BJCGPHDFGJF EPLFMPDKOCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x64526C0", Offset = "0x6451AC0", VA = "0x1864526C0")]
	private static void LAHFIFLCHMD(KNICPOHLBMI CMGNGNKLKDD, Action<NDKJJIJKLED> KOKEGNNILIC, Predicate<BJCGPHDFGJF> MFKJCAADBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x64509D0", Offset = "0x644FDD0", VA = "0x1864509D0")]
	private void EPLFJLJJHON(MCGPJKMOCMD IFMBCNELBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x644F880", Offset = "0x644EC80", VA = "0x18644F880", Slot = "4")]
	[AsyncStateMachine(typeof(NMMCKLHDFOD))]
	public Task CBCACDBCJDI([CanBeNull] LBKGIILDFAD BMAKDMAHBAB, CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "5")]
	public void MBEOFOMKHBO(LBKGIILDFAD BMAKDMAHBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6451640", Offset = "0x6450A40", VA = "0x186451640")]
	private void IJKLOPMGOLB(KNICPOHLBMI MDNAIMDJGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6451980", Offset = "0x6450D80", VA = "0x186451980")]
	internal static string JIGNICOHPAL(DJNOKJNJJAA NKCMLBDEBBK, LBKGIILDFAD BMAKDMAHBAB, IReadOnlyDictionary<BJCGPHDFGJF, JHHMNACAKOM> JJANBOIEKGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x644EA70", Offset = "0x644DE70", VA = "0x18644EA70")]
	private static void BLLMAICJNGA(LBKGIILDFAD BMAKDMAHBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6450A40", Offset = "0x644FE40", VA = "0x186450A40")]
	private static void FBDNIIONECG(KNICPOHLBMI ENBKCALOLIO, IReadOnlyDictionary<BJCGPHDFGJF, JHHMNACAKOM> JJANBOIEKGJ, StringBuilder EBJJBHBCEEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6452970", Offset = "0x6451D70", VA = "0x186452970")]
	private static bool MKMEDAGJPPA(string HFOOEKBONOB, [Out] Guid PKDPDEPLHMK, [Out] BJCGPHDFGJF DKCFGDAHFJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6452BB0", Offset = "0x6451FB0", VA = "0x186452BB0")]
	private static void PHEHLJGDKKJ(LBKGIILDFAD BMAKDMAHBAB, StringBuilder EBJJBHBCEEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x255FED0", Offset = "0x255F2D0", VA = "0x18255FED0", Slot = "16")]
	public bool ENGPIDGIIJC<T>(BJCGPHDFGJF DKCFGDAHFJN, FGJOPBHCEDG JOIEFBKMPPG, bool GKOBODNJMON, T GKKBCNLLJNC) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6450610", Offset = "0x644FA10", VA = "0x186450610")]
	private void DOMJCHGGPML(BJCGPHDFGJF DKCFGDAHFJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6452950", Offset = "0x6451D50", VA = "0x186452950")]
	private bool LIDGNLPPKBC(MCGPJKMOCMD IFMBCNELBJG, BJCGPHDFGJF DKCFGDAHFJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x644E2A0", Offset = "0x644D6A0", VA = "0x18644E2A0")]
	internal JHHMNACAKOM AFFLAODNOGF(MCGPJKMOCMD IFMBCNELBJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6452BA0", Offset = "0x6451FA0", VA = "0x186452BA0", Slot = "13")]
	public IReadOnlyList<PKIPHIGLOMN> OLEOFLCJGCL(MCGPJKMOCMD IFMBCNELBJG, bool LEECBKLJJCD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6451340", Offset = "0x6450740", VA = "0x186451340")]
	internal IReadOnlyList<JHHMNACAKOM> IFBGNGIOOBA(MCGPJKMOCMD IFMBCNELBJG, bool LEECBKLJJCD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6451C80", Offset = "0x6451080", VA = "0x186451C80")]
	private void KJIFCFACIAA(ALNDMDKLAIG JBEAFNGAIFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x64535B0", Offset = "0x64529B0", VA = "0x1864535B0")]
	private static bool POEAJHDFAOH(JHHMNACAKOM JHHPDGMBCNL, IReadOnlyDictionary<BJCGPHDFGJF, JHHMNACAKOM> JJANBOIEKGJ, [Out] IReadOnlyList<FGJOPBHCEDG> PDFNFPMBDJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x644E690", Offset = "0x644DA90", VA = "0x18644E690")]
	[AsyncStateMachine(typeof(CNBFDGKKNGI))]
	private static Task APEHHIFDNLJ(DJNOKJNJJAA NKCMLBDEBBK, LBKGIILDFAD BMAKDMAHBAB, IReadOnlyDictionary<BJCGPHDFGJF, JHHMNACAKOM> JJANBOIEKGJ, EEBFEKBNEGF LHDNLKCMMID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x644E7D0", Offset = "0x644DBD0", VA = "0x18644E7D0")]
	[CompilerGenerated]
	internal static void BAEMJIOOBKH(Func<NDKJJIJKLED, JOFOOBDNBON> HMEKIDKHIJK, HFAMPFBGOOM P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6450220", Offset = "0x644F620", VA = "0x186450220")]
	[CompilerGenerated]
	internal static bool CFBACBPKFNH(BJCGPHDFGJF DKCFGDAHFJN, FGJOPBHCEDG JOIEFBKMPPG, [Out] HGIGBLPDOOF KBHDBCMBNBJ, ELNFGLAOBGO P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface MLGALJCJOHF
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NPCCCEJIMJE(MCGPJKMOCMD PFLKLINJMEC, MCGPJKMOCMD JEEKNMFJGAK, IEnumerable<MCGPJKMOCMD> IBMBGAAHFKP, [Out] ODAFCODMILG DIGDBIDPEDC, [Out] CALJDMFGEKG ENHJKIKDCCJ);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string HMJLEAAOEIF(CALJDMFGEKG ILJGMOHFENK);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum CALJDMFGEKG : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	CantKickEventOrganizer,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Broadcaster,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	GameInProgress,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	OpponentGameInProgress
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class PBGADMFNPOP : MLGALJCJOHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly NAEGOCJNMAN PPAMIKIBGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly DPMHBIDJOME DNOFGOPKPGC;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x77CB20", Offset = "0x77BF20", VA = "0x18077CB20")]
	[RecRoom.NoEngine.Common.Preserve]
	public PBGADMFNPOP([MJHHGJKKIMK(null)] NAEGOCJNMAN BKOBKLGPLJE, [MJHHGJKKIMK(null)] DPMHBIDJOME JNEBIKJABEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x64553E0", Offset = "0x64547E0", VA = "0x1864553E0")]
	private static MCOLNNONCKK? OHONJCOFLGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x64552E0", Offset = "0x64546E0", VA = "0x1864552E0", Slot = "4")]
	public bool NPCCCEJIMJE(MCGPJKMOCMD PFLKLINJMEC, MCGPJKMOCMD JEEKNMFJGAK, IEnumerable<MCGPJKMOCMD> IBMBGAAHFKP, [Out] ODAFCODMILG DIGDBIDPEDC, [Out] CALJDMFGEKG ENHJKIKDCCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x64551E0", Offset = "0x64545E0", VA = "0x1864551E0", Slot = "5")]
	public string HMJLEAAOEIF(CALJDMFGEKG ILJGMOHFENK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6455420", Offset = "0x6454820", VA = "0x186455420")]
	internal bool PPDCPLKJOFA(MCGPJKMOCMD PFLKLINJMEC, MCGPJKMOCMD JEEKNMFJGAK, IEnumerable<MCGPJKMOCMD> IBMBGAAHFKP, FDKNBJIOHGE FGNMCMEPKCM, MCOLNNONCKK? FMPAKINGKJG, [Out] ODAFCODMILG DIGDBIDPEDC, [Out] CALJDMFGEKG ENHJKIKDCCJ)
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
