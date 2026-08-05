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
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.NoEngine.Common;
using RecRoom.ObjectModel;
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
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8E18800", Offset = "0x8E17200", VA = "0x188E18800")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD85C0", Offset = "0xAD6FC0", VA = "0x180AD85C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD8600", Offset = "0xAD7000", VA = "0x180AD8600")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum OAAGNJFLELI
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
namespace _AssemblyRegistry.RecRoom_RoomPermissions_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8E1F3F0", Offset = "0x8E1DDF0", VA = "0x188E1F3F0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x29CDED0", Offset = "0x29CC8D0", VA = "0x1829CDED0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void IENJKADGDDF<TPermission>(TPermission MABBIOOHFDB);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void PIGJBFDNKDE(FNAEIBBBBBE BLHNDOLLIDD);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum KELCPCBNELC
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MENHPENHLCM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool FOHOKCMMLBH
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool LEPOBCKIIDD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool JOJGPEPPLIG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool LNBCNMJPPOG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool KDLIBCCBICB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool PEFONFGPOON
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool LANDLEJIGED
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class GBOKLAPHHAC
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum OJBCHEMNJCD
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
	public static readonly Guid CJIMCGBFLFB;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid CKAKMIFBPCO;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid FMGHHNMAGAG;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid LIBPFIIDIAL;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid NLDAJFKKDIA;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid EGPFKJPAAHC;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly LCJNFGLAGGL<LHDJNPMOIOH, Guid> HLBNDLNEKKA;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	internal static IEnumerable<LHDJNPMOIOH> GODBHMICDLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8E14650", Offset = "0x8E13050", VA = "0x188E14650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8E14540", Offset = "0x8E12F40", VA = "0x188E14540")]
	public static LHDJNPMOIOH DBEHDKAALGO(Guid OCONCDFGCOB)
	{
		return default(LHDJNPMOIOH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8E14780", Offset = "0x8E13180", VA = "0x188E14780")]
	public static Guid OJJCHKGNPDL(LHDJNPMOIOH ANOJKINPPNO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8E144B0", Offset = "0x8E12EB0", VA = "0x188E144B0")]
	public static bool AJOMPDGPALI(LHDJNPMOIOH ANOJKINPPNO, [Out] Guid OCONCDFGCOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8E14820", Offset = "0x8E13220", VA = "0x188E14820")]
	public static bool OKKEKOKODOB(Guid OCONCDFGCOB, [Out] LHDJNPMOIOH ANOJKINPPNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8E14610", Offset = "0x8E13010", VA = "0x188E14610")]
	public static LHDJNPMOIOH FLAONKLDHDO(LHDJNPMOIOH ANOJKINPPNO)
	{
		return default(LHDJNPMOIOH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8E146D0", Offset = "0x8E130D0", VA = "0x188E146D0")]
	public static OJBCHEMNJCD NHAPKLJHJME(LHDJNPMOIOH INHBJEKJFGG)
	{
		return default(OJBCHEMNJCD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8E145D0", Offset = "0x8E12FD0", VA = "0x188E145D0")]
	internal static LHDJNPMOIOH FFOMMCJCJGH(OJBCHEMNJCD HFOFPKLLIPI)
	{
		return default(LHDJNPMOIOH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PGCLFIPEDLP
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	FNAEIBBBBBE OPIAAKOABFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	IAOKBCEAMNP POGBJPJLBAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	PKCMPJMLDGM LGNOMIDOKJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<ECOBKIKBKJB> MNENLFJIPPA;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action NGPODBLDPIN;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LHDJNPMOIOH ONOGDKCBPDJ(FNAEIBBBBBE BLHNDOLLIDD);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<ECOBKIKBKJB> ENOKGIPNBOH(CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task HLINOIEPLBJ(long GDCAPMONNDM, IReadOnlyList<ONLPJADAEGC> PGBDGGENPGO);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task LLJFDNONKDN(long GDCAPMONNDM, long FMNCJOBEOEF, IReadOnlyList<ONLPJADAEGC> PGBDGGENPGO);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<FNAEIBBBBBE> FIFNBMMDLAA();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class KLIGHKJCGPA
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8E15A90", Offset = "0x8E14490", VA = "0x188E15A90")]
	public static LHDJNPMOIOH AAIJFBJCEFI(this PGCLFIPEDLP GELHJCKEBDJ)
	{
		return default(LHDJNPMOIOH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface GKLCDBDIMFA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	HGJPNGMLOOH AKLDAMPGHKF
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event PIGJBFDNKDE IBENHECEFLA;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<EMPBKBFAPJM> JJFHBHMJOBH(bool OALCKNCJFOA = false);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EMPBKBFAPJM BNCAKCCPEED(FNAEIBBBBBE BLHNDOLLIDD);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool EDIAENEDMAO(FNAEIBBBBBE BLHNDOLLIDD);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IReadOnlyList<EMPBKBFAPJM> DCFMHMFCHDP(FNAEIBBBBBE BLHNDOLLIDD, bool KOPIMELJGHC = false);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool ABOALDIDCOO(FNAEIBBBBBE MDLELJOJCKJ, LHDJNPMOIOH ANOJKINPPNO);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "8")]
	EMPBKBFAPJM NDCAPILIGGF(LHDJNPMOIOH ANOJKINPPNO);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool JABEFOPGHMB<T>(LHDJNPMOIOH ANOJKINPPNO, GBBLNAFMLEP MABBIOOHFDB, bool HPLKMKGBKPO, T MFHBGCBJCJO, [Optional] Action BLLOEOLFCPC) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string ANBJLADMBAO(GBBLNAFMLEP MABBIOOHFDB);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool EHINFINJMPA(FNAEIBBBBBE BLHNDOLLIDD, GBBLNAFMLEP KLMIPONNOGO);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface LMAMMGLJDFA
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task NGGPBIIJGKE(EHIMHNJBHOL KALMEDGIGPJ, CancellationToken AHOMALKMHKK);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface CBBDHEPMGBN<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string JKDKLAJOPJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event IENJKADGDDF<TPermission> EIPINPEHLCK;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal abstract class EPHHDEGDFOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal object? KPICCEGEGNB;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? IJNNAIMEFIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8E13A00", Offset = "0x8E12400", VA = "0x188E13A00")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8E13900", Offset = "0x8E12300", VA = "0x188E13900")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8E13AD0", Offset = "0x8E124D0", VA = "0x188E13AD0")]
	protected EPHHDEGDFOC(object? IFMIICONFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool PHABBDPNAFH(object? KMAFNKGMDCF);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class PKPGJKLKGHF<T> : EPHHDEGDFOC where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> MELOCBAJPHK;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T AFPBILBCKEL
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5CBF360", Offset = "0x5CBDD60", VA = "0x185CBF360")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5CBFBD0", Offset = "0x5CBE5D0", VA = "0x185CBFBD0", Slot = "4")]
	public override bool PHABBDPNAFH(object? KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5CBF930", Offset = "0x5CBE330", VA = "0x185CBF930")]
	public bool GDGKLLIGFGM(T FCJFHDBNOAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5CBFFA0", Offset = "0x5CBE9A0", VA = "0x185CBFFA0")]
	public PKPGJKLKGHF(T KJMOBDOKFBF, IEqualityComparer<T> MELOCBAJPHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class FIGFNMLFPMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<GBBLNAFMLEP, bool> ABMBKMOJBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<GBBLNAFMLEP, EPHHDEGDFOC> CLDHOBOFLKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly BCNMMKLGAII AHOOCLBHABF;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8E14200", Offset = "0x8E12C00", VA = "0x188E14200")]
	public FIGFNMLFPMI(BCNMMKLGAII AHOOCLBHABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8E13C60", Offset = "0x8E12660", VA = "0x188E13C60")]
	public bool BICGEBOJDGH(GBBLNAFMLEP MABBIOOHFDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3D6E100", Offset = "0x3D6CB00", VA = "0x183D6E100")]
	public bool POLLBNOFLBC<T>(GBBLNAFMLEP MABBIOOHFDB, bool HPLKMKGBKPO, T KMAFNKGMDCF) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3D6DD30", Offset = "0x3D6C730", VA = "0x183D6DD30")]
	public (bool, T?) JBOGFLIKEGJ<T>(GBBLNAFMLEP MABBIOOHFDB) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8E14120", Offset = "0x8E12B20", VA = "0x188E14120")]
	public bool POLLBNOFLBC(GBBLNAFMLEP MABBIOOHFDB, bool HPLKMKGBKPO, object KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8E13EC0", Offset = "0x8E128C0", VA = "0x188E13EC0")]
	public (bool, object) JBOGFLIKEGJ(GBBLNAFMLEP MABBIOOHFDB)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3D6DCF0", Offset = "0x3D6C6F0", VA = "0x183D6DCF0")]
	private void FAIJBKMAAKA<T>(GBBLNAFMLEP MABBIOOHFDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8E14050", Offset = "0x8E12A50", VA = "0x188E14050")]
	private EPHHDEGDFOC OBMPJMGKFAN(GBBLNAFMLEP MABBIOOHFDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8E13CD0", Offset = "0x8E126D0", VA = "0x188E13CD0")]
	public void ELNKNKJCIPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class BGOJHOMKFHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string KMGIKAEEDOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type IJMJJKCACFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly APOEDKHEPBI JGFPCEIHOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly GBBLNAFMLEP LBOOLALCELI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ACIFNOAEPOG POOEHNGJKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public DJDKJPCGDAH DCENAKFBJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public EGAHBJBPEHL OMMIOKFBMPM;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8E12420", Offset = "0x8E10E20", VA = "0x188E12420")]
	public BGOJHOMKFHC(Type BBGACPFMNIM, string CDLCGIGHGJP, GBBLNAFMLEP MABBIOOHFDB, ACIFNOAEPOG KLEGONKOGON, DJDKJPCGDAH HHGMIGIBPIP, EGAHBJBPEHL MGLFBFBFEGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8E123D0", Offset = "0x8E10DD0", VA = "0x188E123D0")]
	public object IDKACFLMENB(object? GOCNHGEHNFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3B29E10", Offset = "0x3B28810", VA = "0x183B29E10")]
	public void FAIJBKMAAKA<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8E12320", Offset = "0x8E10D20", VA = "0x188E12320")]
	public void FAIJBKMAAKA(Type PJFOAKDKEPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class HDFACDKIMFF<T> : BGOJHOMKFHC where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate string HMLBAGOJGNG(T KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal delegate T LFLHJKIBNED(string? OMNOGIGLMIH, T KJMOBDOKFBF);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class BPINIPOHCKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public HMLBAGOJGNG serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public LFLHJKIBNED parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public BPINIPOHCKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x685B7F0", Offset = "0x685A1F0", VA = "0x18685B7F0")]
		internal string DFKCOOJLNMK(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x685B660", Offset = "0x685A060", VA = "0x18685B660")]
		internal object AFLDGJHNCCJ(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x519B2F0", Offset = "0x5199CF0", VA = "0x18519B2F0")]
	public HDFACDKIMFF(GBBLNAFMLEP MABBIOOHFDB, string CDLCGIGHGJP, [Optional] HMLBAGOJGNG? KLEGONKOGON, [Optional] LFLHJKIBNED? HHGMIGIBPIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x519AD20", Offset = "0x5199720", VA = "0x18519AD20")]
	private static object? LEOAOCFGODA(LFLHJKIBNED? HHGMIGIBPIP, string? OMNOGIGLMIH, object? KJMOBDOKFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x519A4F0", Offset = "0x5198EF0", VA = "0x18519A4F0")]
	private static string GCGCKFHBJPB(HMLBAGOJGNG? DLDMNLMEJIL, object? KMAFNKGMDCF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate string ACIFNOAEPOG(object? KMAFNKGMDCF);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate object DJDKJPCGDAH(string? OMNOGIGLMIH, [Optional] object KJMOBDOKFBF);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal delegate EPHHDEGDFOC EGAHBJBPEHL();
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class BCNMMKLGAII
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class OOKDHLFJCIE : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static OOKDHLFJCIE FLGHCDNLMND;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8E1E920", Offset = "0x8E1D320", VA = "0x188E1E920", Slot = "4")]
		public bool Equals(List<string> FKPKEFAKAOE, List<string> KEEMKILMOML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8E1EA70", Offset = "0x8E1D470", VA = "0x188E1EA70", Slot = "5")]
		public int GetHashCode(List<string> PMNHIPACJLN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public OOKDHLFJCIE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class GMCFCGHCNKF : KFLMFFFNCPM<OAAGNJFLELI>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8E15760", Offset = "0x8E14160", VA = "0x188E15760", Slot = "9")]
		public override string GCGCKFHBJPB(OAAGNJFLELI GHANLDMHBLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8E15850", Offset = "0x8E14250", VA = "0x188E15850", Slot = "10")]
		protected override bool LENGHMMDCBN(string GHANLDMHBLD, [Out] OAAGNJFLELI KMAFNKGMDCF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8E15A20", Offset = "0x8E14420", VA = "0x188E15A20")]
		public GMCFCGHCNKF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly LDKBCDFLAAA FODBACBLJDE;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly GMCFCGHCNKF MFGOCBNALKJ;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<BGOJHOMKFHC> BFGPFNPHECE;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<GBBLNAFMLEP> MAOOBMINDOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<GBBLNAFMLEP, BGOJHOMKFHC> KLDLDKALELD
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8E11FD0", Offset = "0x8E109D0", VA = "0x188E11FD0")]
	public BCNMMKLGAII([Optional] IList<BGOJHOMKFHC>? JAKHFKGKFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8E10A30", Offset = "0x8E0F430", VA = "0x188E10A30")]
	public BGOJHOMKFHC ADGPLEJPFLJ(GBBLNAFMLEP MABBIOOHFDB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface HGJPNGMLOOH
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	EMPBKBFAPJM FEIKLKOPGMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class LGDAIKHDMMC : HGJPNGMLOOH
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static LGDAIKHDMMC AIALNGDOMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly NLMGINCECGH JDKMPHBDFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<NLMGINCECGH> IIPAEJEKANI;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public EMPBKBFAPJM FEIKLKOPGMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8E16A40", Offset = "0x8E15440", VA = "0x188E16A40")]
	public LGDAIKHDMMC(NLMGINCECGH MBCEHKFEPGA, IReadOnlyList<NLMGINCECGH> LFADIAIFIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8E15AF0", Offset = "0x8E144F0", VA = "0x188E15AF0")]
	private static LGDAIKHDMMC AKPCMNLPKHE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class COOJIAJAJFK
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<LHDJNPMOIOH> NKCGECDLEDN;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8E12540", Offset = "0x8E10F40", VA = "0x188E12540")]
	public static bool NNCALAADBPB(this FNAEIBBBBBE NBPOBGMPFAH, LHDJNPMOIOH ANOJKINPPNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8E124C0", Offset = "0x8E10EC0", VA = "0x188E124C0")]
	public static bool HEHCMOOBFAD(this FNAEIBBBBBE NBPOBGMPFAH, LHDJNPMOIOH ANOJKINPPNO, PKCMPJMLDGM NDIBIPMCCAA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface NGEJNNADFEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	IReadOnlyList<string> CNODHKPPHFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	OAAGNJFLELI JKNGIPGGIKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface EMPBKBFAPJM : NGEJNNADFEJ, MENHPENHLCM, CBBDHEPMGBN<GBBLNAFMLEP>
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	string POKEHAPCPJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	LHDJNPMOIOH PHIFAJGIOBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) IEJLDGPBNIO<T>(GBBLNAFMLEP MABBIOOHFDB) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal class NLMGINCECGH : EMPBKBFAPJM, NGEJNNADFEJ, MENHPENHLCM, CBBDHEPMGBN<GBBLNAFMLEP>
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal static readonly BCNMMKLGAII NFOJJEFMPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal readonly FIGFNMLFPMI MJFDDOBEGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private string? HPIEKKEBBPG;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private bool JEHMGIOCFPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8E16EA0", Offset = "0x8E158A0", VA = "0x188E16EA0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool LAFGDAGMENA
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8E16E50", Offset = "0x8E15850", VA = "0x188E16E50", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool CJCLDPJPINB
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8E16D80", Offset = "0x8E15780", VA = "0x188E16D80", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool OGGDFLJJJOO
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8E174C0", Offset = "0x8E15EC0", VA = "0x188E174C0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool EPMFMIHDMIB
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8E16B50", Offset = "0x8E15550", VA = "0x188E16B50", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool EJPMGBIBNNC
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8E16BA0", Offset = "0x8E155A0", VA = "0x188E16BA0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private bool OCNBGKDIOMD
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8E17470", Offset = "0x8E15E70", VA = "0x188E17470", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public LHDJNPMOIOH PHIFAJGIOBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xB36DB0", Offset = "0xB357B0", VA = "0x180B36DB0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(LHDJNPMOIOH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xAB2B80", Offset = "0xAB1580", VA = "0x180AB2B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public string JKDKLAJOPJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8E17420", Offset = "0x8E15E20", VA = "0x188E17420", Slot = "18")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public string POKEHAPCPJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8E17420", Offset = "0x8E15E20", VA = "0x188E17420", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool KNLAJIGCNIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xADB270", Offset = "0xAD9C70", VA = "0x180ADB270")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xADAFF0", Offset = "0xAD99F0", VA = "0x180ADAFF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public OAAGNJFLELI JKNGIPGGIKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8E17000", Offset = "0x8E15A00", VA = "0x188E17000", Slot = "8")]
		get
		{
			return default(OAAGNJFLELI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public IReadOnlyList<string> CNODHKPPHFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8E16FA0", Offset = "0x8E159A0", VA = "0x188E16FA0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool KABGMFNGJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8E16EA0", Offset = "0x8E158A0", VA = "0x188E16EA0", Slot = "19")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool ONELEPPMMGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8E16B50", Offset = "0x8E15550", VA = "0x188E16B50", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool PCHCNBIPHDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8E16E50", Offset = "0x8E15850", VA = "0x188E16E50", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool OADEKMNPDAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8E16D80", Offset = "0x8E15780", VA = "0x188E16D80", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool HFJLHDEBAAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8E174C0", Offset = "0x8E15EC0", VA = "0x188E174C0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool OKJBDEMLIIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8E16BA0", Offset = "0x8E155A0", VA = "0x188E16BA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool BLBCEPAIADD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8E17470", Offset = "0x8E15E70", VA = "0x188E17470")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event IENJKADGDDF<GBBLNAFMLEP> EIPINPEHLCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8E17B50", Offset = "0x8E16550", VA = "0x188E17B50", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8E16CD0", Offset = "0x8E156D0", VA = "0x188E16CD0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3F103A0", Offset = "0x3F0EDA0", VA = "0x183F103A0", Slot = "6")]
	public (bool, T?) IEJLDGPBNIO<T>(GBBLNAFMLEP MABBIOOHFDB) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3F10530", Offset = "0x3F0EF30", VA = "0x183F10530")]
	public NLMGINCECGH KEFEBPHMMAN<T>(GBBLNAFMLEP MABBIOOHFDB, bool HPLKMKGBKPO, T KMAFNKGMDCF) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8E18610", Offset = "0x8E17010", VA = "0x188E18610")]
	public NLMGINCECGH(LHDJNPMOIOH ANOJKINPPNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8E185F0", Offset = "0x8E16FF0", VA = "0x188E185F0")]
	public NLMGINCECGH(LHDJNPMOIOH ANOJKINPPNO, [Optional] string? HPIEKKEBBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8E18630", Offset = "0x8E17030", VA = "0x188E18630")]
	public NLMGINCECGH(NLMGINCECGH BNEGHGGGOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8E186C0", Offset = "0x8E170C0", VA = "0x188E186C0")]
	internal NLMGINCECGH(LHDJNPMOIOH PEOOMOJFLJI, [Optional] string? HPIEKKEBBPG, [Optional] NLMGINCECGH? BNEGHGGGOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8E16DD0", Offset = "0x8E157D0", VA = "0x188E16DD0")]
	public static APOEDKHEPBI DHKBPLECOFL(GBBLNAFMLEP MABBIOOHFDB)
	{
		return default(APOEDKHEPBI);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8E16F80", Offset = "0x8E15980", VA = "0x188E16F80")]
	public void ELNKNKJCIPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8E17810", Offset = "0x8E16210", VA = "0x188E17810")]
	internal NLMGINCECGH JIECEMEFFCO(NLMGINCECGH ELAFJFLMLMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8E17050", Offset = "0x8E15A50", VA = "0x188E17050")]
	internal IReadOnlyCollection<GBBLNAFMLEP> GJDBKFJEDMI(NLMGINCECGH BNEGHGGGOMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8E16BF0", Offset = "0x8E155F0", VA = "0x188E16BF0")]
	public bool CPHKODAAOAE(GBBLNAFMLEP MABBIOOHFDB, bool HPLKMKGBKPO, string APHDBLIKKBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8E17710", Offset = "0x8E16110", VA = "0x188E17710")]
	public (bool, string) JAFMNHEDKGG(GBBLNAFMLEP MABBIOOHFDB)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8E17B00", Offset = "0x8E16500", VA = "0x188E17B00")]
	internal void NFGIMMEGOFJ(GBBLNAFMLEP MABBIOOHFDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8E17510", Offset = "0x8E15F10", VA = "0x188E17510")]
	public MHNOFNKJLLJ HGIBKAALGPL(Func<LHDJNPMOIOH, Guid> ANHGMBPMAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8E17C00", Offset = "0x8E16600", VA = "0x188E17C00")]
	public void NNFCDAAODGM(MHNOFNKJLLJ EKNJAMCPANA, Func<Guid, LHDJNPMOIOH> CEFMNAMPEFG, [Optional] LHDJNPMOIOH? PPDHIEGADFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8E16EF0", Offset = "0x8E158F0", VA = "0x188E16EF0")]
	[CompilerGenerated]
	private void EGBKGHCOHPM(GBBLNAFMLEP KLMIPONNOGO, PKGKNKALIPB KPMPOFBFJPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class OIGGKKJJEOP : LMAMMGLJDFA, GKLCDBDIMFA, IDisposable, DBODKOKNDFG
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class KLGDEMLIHLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public NLMGINCECGH newRole;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public KLGDEMLIHLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8E15A60", Offset = "0x8E14460", VA = "0x188E15A60")]
		internal bool FIEJDAJPIKC(NLMGINCECGH rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class OHIAGAMCOJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public LHDJNPMOIOH roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public OHIAGAMCOJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x1F8D520", Offset = "0x1F8BF20", VA = "0x181F8D520")]
		internal bool FEHBPAEAINN(LHDJNPMOIOH r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct EOFHANIIDLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public OIGGKKJJEOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public EHIMHNJBHOL roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private TaskAwaiter<ECOBKIKBKJB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8E13230", Offset = "0x8E11C30", VA = "0x188E13230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8E138A0", Offset = "0x8E122A0", VA = "0x188E138A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class EJCIFDMHFCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public EJCIFDMHFCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8E13030", Offset = "0x8E11A30", VA = "0x188E13030")]
		internal void DGCKKOOIHDI(MHNOFNKJLLJ r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8E13110", Offset = "0x8E11B10", VA = "0x188E13110")]
		internal void DNCILNJFDMF(MHNOFNKJLLJ r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct EGPBPNBJACI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public EHIMHNJBHOL roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class FICDIEPINAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Func<MHNOFNKJLLJ, PKGKNKALIPB> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public FICDIEPINAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8E13C30", Offset = "0x8E12630", VA = "0x188E13C30")]
		internal void NCCJDAIMOPH(MHNOFNKJLLJ r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8E13BD0", Offset = "0x8E125D0", VA = "0x188E13BD0")]
		internal void FFMPKCBOANF(MHNOFNKJLLJ r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8E13C00", Offset = "0x8E12600", VA = "0x188E13C00")]
		internal void ILPGGCEBHHO(MHNOFNKJLLJ r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class BOCCDDKMHLG<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private struct <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public BOCCDDKMHLG<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private TaskAwaiter<ECOBKIKBKJB> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x459D8A0", Offset = "0x459C2A0", VA = "0x18459D8A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public GBBLNAFMLEP rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public LHDJNPMOIOH accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public APOEDKHEPBI recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public OIGGKKJJEOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public BOCCDDKMHLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6784000", Offset = "0x6782A00", VA = "0x186784000")]
		[AsyncStateMachine(typeof(BOCCDDKMHLG<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void JLJCNJMHFPP()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct BBGHMJDPEAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public IReadOnlyList<ONLPJADAEGC> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct GIAKFPLDDAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public PGCLFIPEDLP rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public EHIMHNJBHOL roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public IReadOnlyDictionary<LHDJNPMOIOH, NLMGINCECGH> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public AFCBJHNNPNF debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8E14BE0", Offset = "0x8E135E0", VA = "0x188E14BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8E15700", Offset = "0x8E14100", VA = "0x188E15700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[DependsOn]
	private readonly PGCLFIPEDLP GELHJCKEBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[DependsOn]
	private readonly LGDAIKHDMMC JGFAJBFJDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[DependsOn]
	private readonly AFCBJHNNPNF LEAGHOGAOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private LEDGHCAIHHI? LMGLPBOMNGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly Dictionary<int, LHDJNPMOIOH> GGDDECBMBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly Dictionary<LHDJNPMOIOH, NLMGINCECGH> LBAMGFJCLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal readonly Dictionary<LHDJNPMOIOH, NLMGINCECGH> JGMIEFBBHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal readonly Dictionary<LHDJNPMOIOH, NLMGINCECGH> GLAMDNEDAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal readonly List<NLMGINCECGH> EKINAEMNMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool PKHAJCNOCLF;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private static readonly GBBLNAFMLEP[] NPEPFFGDHIH;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public HGJPNGMLOOH AKLDAMPGHKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event PIGJBFDNKDE IBENHECEFLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8E19B70", Offset = "0x8E18570", VA = "0x188E19B70", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8E1E3C0", Offset = "0x8E1CDC0", VA = "0x188E1E3C0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x8E1B210", Offset = "0x8E19C10", VA = "0x188E1B210")]
	[DMKNBLIJJON.FPNPBOEMEDG]
	internal static void HFPMPAAENFC(JBJKIIKOACK ALFOGEOKGPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x8E1E630", Offset = "0x8E1D030", VA = "0x188E1E630")]
	[UnityEngine.Scripting.Preserve]
	internal OIGGKKJJEOP([BMCONCJPCIA(null)] PGCLFIPEDLP LFEEADDECEE, [BMCONCJPCIA(null)] LGDAIKHDMMC INOCOEAGCLH, [BMCONCJPCIA(null)] AFCBJHNNPNF LEAGHOGAOII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x8E19A60", Offset = "0x8E18460", VA = "0x188E19A60", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x8E19CE0", Offset = "0x8E186E0", VA = "0x188E19CE0")]
	private void EECPOJAHOMF(IEnumerable<NLMGINCECGH> NBDIADGKFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x8E19C10", Offset = "0x8E18610", VA = "0x188E19C10", Slot = "10")]
	public bool EDIAENEDMAO(FNAEIBBBBBE BLHNDOLLIDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x8E1CFC0", Offset = "0x8E1B9C0", VA = "0x188E1CFC0")]
	private void NGPODBLDPIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x8E1CFD0", Offset = "0x8E1B9D0", VA = "0x188E1CFD0", Slot = "19")]
	public void OAMHDJECOLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x8E1C230", Offset = "0x8E1AC30", VA = "0x188E1C230", Slot = "8")]
	public IReadOnlyList<EMPBKBFAPJM> JJFHBHMJOBH(bool OALCKNCJFOA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8E18D80", Offset = "0x8E17780", VA = "0x188E18D80", Slot = "9")]
	public EMPBKBFAPJM BNCAKCCPEED(FNAEIBBBBBE BLHNDOLLIDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8E1D1B0", Offset = "0x8E1BBB0", VA = "0x188E1D1B0")]
	private LHDJNPMOIOH OBMBOLBBJAE(FNAEIBBBBBE BLHNDOLLIDD)
	{
		return default(LHDJNPMOIOH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8E18880", Offset = "0x8E17280", VA = "0x188E18880", Slot = "12")]
	public bool ABOALDIDCOO(FNAEIBBBBBE MDLELJOJCKJ, LHDJNPMOIOH ANOJKINPPNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8E1CE00", Offset = "0x8E1B800", VA = "0x188E1CE00", Slot = "13")]
	public EMPBKBFAPJM NDCAPILIGGF(LHDJNPMOIOH ANOJKINPPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x8E192D0", Offset = "0x8E17CD0", VA = "0x188E192D0")]
	private static bool DIGGPMKKCAH(PFMKNMJLNEM CEMPNDLMDDO, LHDJNPMOIOH ANOJKINPPNO, [Out] MHNOFNKJLLJ? ENHCDAIPKBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x8E1CD10", Offset = "0x8E1B710", VA = "0x188E1CD10")]
	private static void MNBIEPMICFL(PFMKNMJLNEM CEMPNDLMDDO, Action<MHNOFNKJLLJ> EOLGOIDFAFE, LHDJNPMOIOH DPLLDFOEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x8E1CA80", Offset = "0x8E1B480", VA = "0x188E1CA80")]
	private static void MNBIEPMICFL(PFMKNMJLNEM CEMPNDLMDDO, Action<MHNOFNKJLLJ> EOLGOIDFAFE, Predicate<LHDJNPMOIOH> OLEMAPEGFIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8E1A550", Offset = "0x8E18F50", VA = "0x188E1A550")]
	private void EENKKGJDJDI(FNAEIBBBBBE BLHNDOLLIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8E1CEA0", Offset = "0x8E1B8A0", VA = "0x188E1CEA0", Slot = "4")]
	[AsyncStateMachine(typeof(EOFHANIIDLF))]
	public Task NGGPBIIJGKE([CanBeNull] EHIMHNJBHOL KALMEDGIGPJ, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8E18F90", Offset = "0x8E17990", VA = "0x188E18F90")]
	private void DDLBOPCFOGH(PFMKNMJLNEM KKLNANFHMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8E1D280", Offset = "0x8E1BC80", VA = "0x188E1D280")]
	internal static string ODLMDBMALJF(PGCLFIPEDLP GELHJCKEBDJ, EHIMHNJBHOL KALMEDGIGPJ, IReadOnlyDictionary<LHDJNPMOIOH, NLMGINCECGH> JGMIEFBBHDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8E1D590", Offset = "0x8E1BF90", VA = "0x188E1D590")]
	private static void PKOMKAKFOGL(EHIMHNJBHOL KALMEDGIGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x8E19600", Offset = "0x8E18000", VA = "0x188E19600")]
	private static void DIOLDAMIAOA(PFMKNMJLNEM CNNJBHJLDMP, IReadOnlyDictionary<LHDJNPMOIOH, NLMGINCECGH> JGMIEFBBHDJ, StringBuilder NALDCHNCNBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8E19950", Offset = "0x8E18350", VA = "0x188E19950")]
	private static bool DMMINIAEPAM(string EKEIGHALGAI, [Out] Guid KOBCFBMDAOK, [Out] LHDJNPMOIOH ANOJKINPPNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8E1BAF0", Offset = "0x8E1A4F0", VA = "0x188E1BAF0")]
	private static void JGDBKIEMJLF(EHIMHNJBHOL KALMEDGIGPJ, StringBuilder NALDCHNCNBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3F4AB90", Offset = "0x3F49590", VA = "0x183F4AB90", Slot = "14")]
	public bool JABEFOPGHMB<T>(LHDJNPMOIOH ANOJKINPPNO, GBBLNAFMLEP MABBIOOHFDB, bool HPLKMKGBKPO, T MFHBGCBJCJO, [Optional] Action BLLOEOLFCPC) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8E18A10", Offset = "0x8E17410", VA = "0x188E18A10", Slot = "15")]
	public string ANBJLADMBAO(GBBLNAFMLEP MABBIOOHFDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8E1AD60", Offset = "0x8E19760", VA = "0x188E1AD60", Slot = "16")]
	public bool EHINFINJMPA(FNAEIBBBBBE BLHNDOLLIDD, GBBLNAFMLEP KLMIPONNOGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8E18950", Offset = "0x8E17350", VA = "0x188E18950", Slot = "18")]
	public bool AMEDLAEIMHG(OPBIGPJHHKE ANOJKINPPNO, GBBLNAFMLEP KLMIPONNOGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8E1B3D0", Offset = "0x8E19DD0", VA = "0x188E1B3D0")]
	private void IJCAOEMHDPA(LHDJNPMOIOH ANOJKINPPNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8E18EF0", Offset = "0x8E178F0", VA = "0x188E18EF0")]
	private bool CKBGKCEPMBJ(FNAEIBBBBBE BLHNDOLLIDD, LHDJNPMOIOH ANOJKINPPNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8E1AF80", Offset = "0x8E19980", VA = "0x188E1AF80")]
	private NLMGINCECGH ELLNHCGPCAI(LHDJNPMOIOH ANOJKINPPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x8E1C630", Offset = "0x8E1B030", VA = "0x188E1C630")]
	internal LHDJNPMOIOH MEANOANOMMM(FNAEIBBBBBE BLHNDOLLIDD)
	{
		return default(LHDJNPMOIOH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x8E1B5D0", Offset = "0x8E19FD0", VA = "0x188E1B5D0")]
	private void IJKEAOCBHAA(int BLHNDOLLIDD, LHDJNPMOIOH PJACIHLHMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x8E18F10", Offset = "0x8E17910", VA = "0x188E18F10", Slot = "11")]
	public IReadOnlyList<EMPBKBFAPJM> DCFMHMFCHDP(FNAEIBBBBBE BLHNDOLLIDD, bool KOPIMELJGHC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x8E18F10", Offset = "0x8E17910", VA = "0x188E18F10")]
	internal IReadOnlyList<NLMGINCECGH> IDNNLIHGBPG(FNAEIBBBBBE BLHNDOLLIDD, bool KOPIMELJGHC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x8E1C8B0", Offset = "0x8E1B2B0", VA = "0x188E1C8B0")]
	internal IReadOnlyList<NLMGINCECGH> MFHMEJMDECK(LHDJNPMOIOH ANOJKINPPNO, bool KOPIMELJGHC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x8E1A5C0", Offset = "0x8E18FC0", VA = "0x188E1A5C0")]
	private void EGDBGHLAKFF(ECOBKIKBKJB LAOABDEMJGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x8E18A90", Offset = "0x8E17490", VA = "0x188E18A90")]
	private static bool BBLFKFLFDKJ(NLMGINCECGH PKBFDHMMGIB, IReadOnlyDictionary<LHDJNPMOIOH, NLMGINCECGH> JGMIEFBBHDJ, [Out] IReadOnlyList<GBBLNAFMLEP> DJKKHCPKKOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x8E1B710", Offset = "0x8E1A110", VA = "0x188E1B710")]
	[AsyncStateMachine(typeof(GIAKFPLDDAO))]
	private static Task IMIPDDMIEPC(PGCLFIPEDLP GELHJCKEBDJ, EHIMHNJBHOL KALMEDGIGPJ, IReadOnlyDictionary<LHDJNPMOIOH, NLMGINCECGH> JGMIEFBBHDJ, AFCBJHNNPNF LEAGHOGAOII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x8E1B850", Offset = "0x8E1A250", VA = "0x188E1B850")]
	[CompilerGenerated]
	internal static void JGAGPKMHKEM(Func<MHNOFNKJLLJ, PKGKNKALIPB> CBNFLKPLGKF, EGPBPNBJACI P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x8E1C2B0", Offset = "0x8E1ACB0", VA = "0x188E1C2B0")]
	[CompilerGenerated]
	internal static bool JKABGMFPLMB(LHDJNPMOIOH ANOJKINPPNO, GBBLNAFMLEP MABBIOOHFDB, [Out] ONLPJADAEGC BLBBKILMKBD, BBGHMJDPEAL P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface HAMHFGDHLFD
{
	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KMGPONEMBEH(FNAEIBBBBBE ECEBAICEOOK, FNAEIBBBBBE KAGJIMODDPL, IEnumerable<FNAEIBBBBBE> GBHANMNJOHK, [Out] OAAGNJFLELI BBMAIBKDKPP, [Out] BKMPCHMICLC MGDCOIFGCNE);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string MGNHBCMOBMC(BKMPCHMICLC LMEOMIDGMJO);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum BKMPCHMICLC : byte
{
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	CantKickEventOrganizer,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	Broadcaster,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	GameInProgress,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	OpponentGameInProgress
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class EBHGMBJJGIE : HAMHFGDHLFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly GKLCDBDIMFA MBIFBGAGALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly CJIFMPGEEGD EENNOPPHJKH;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0xAB5980", Offset = "0xAB4380", VA = "0x180AB5980")]
	[RecRoom.NoEngine.Common.Preserve]
	public EBHGMBJJGIE([BMCONCJPCIA(null)] GKLCDBDIMFA MBIFBGAGALL, [BMCONCJPCIA(null)] CJIFMPGEEGD HMOLPADKLGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x8E127D0", Offset = "0x8E111D0", VA = "0x188E127D0")]
	private static ICNMJNLKFDK? CHFHHAFJCFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8E12E30", Offset = "0x8E11830", VA = "0x188E12E30", Slot = "4")]
	public bool KMGPONEMBEH(FNAEIBBBBBE ECEBAICEOOK, FNAEIBBBBBE KAGJIMODDPL, IEnumerable<FNAEIBBBBBE> GBHANMNJOHK, [Out] OAAGNJFLELI BBMAIBKDKPP, [Out] BKMPCHMICLC MGDCOIFGCNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x8E12F30", Offset = "0x8E11930", VA = "0x188E12F30", Slot = "5")]
	public string MGNHBCMOBMC(BKMPCHMICLC LMEOMIDGMJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x8E12810", Offset = "0x8E11210", VA = "0x188E12810")]
	internal bool FAAFCGANBHO(FNAEIBBBBBE ECEBAICEOOK, FNAEIBBBBBE KAGJIMODDPL, IEnumerable<FNAEIBBBBBE> GBHANMNJOHK, PKCMPJMLDGM NDIBIPMCCAA, ICNMJNLKFDK? CMIEDNHLIHD, [Out] OAAGNJFLELI BBMAIBKDKPP, [Out] BKMPCHMICLC MGDCOIFGCNE)
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
