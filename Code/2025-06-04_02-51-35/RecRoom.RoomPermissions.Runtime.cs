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
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x885D5A0", Offset = "0x885BDA0", VA = "0x18885D5A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA536D0", Offset = "0xA51ED0", VA = "0x180A536D0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA53710", Offset = "0xA51F10", VA = "0x180A53710")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum IKNFGFHJDNF
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
		[Cpp2IlInjected.Address(RVA = "0x885E5B0", Offset = "0x885CDB0", VA = "0x18885E5B0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2731690", Offset = "0x272FE90", VA = "0x182731690")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void LOPHJJOPFHJ<TPermission>(TPermission GHKACKCGIEN);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void KKOIKDHLAJI(EIGONBNGIIK OINLJEGCCDI);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum AIGKGJEBLBK
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface PIEAKEPHAJH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool LJICNNBDHNA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool KGLBECGAIGM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool PAAEEPHDFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool AMCPCEEHNNN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool JAELGBAGFAA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool PIEOBMJKDKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class JFBGFFGKPAD
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum AGAGKFFELDN
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
	public static readonly Guid JPNAGDIAKED;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid DOHAENBMAMJ;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid GAOLGMCJEBG;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid IFKOLNHFCOC;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid EHOIDHFOLGD;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid KOMCMCHCFCF;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly LKJNPHDICNA<BAMAEEMHEMC, Guid> FDOGHBMNOBK;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<BAMAEEMHEMC> CJOALDOHHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x885ACC0", Offset = "0x88594C0", VA = "0x18885ACC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x885AA10", Offset = "0x8859210", VA = "0x18885AA10")]
	public static BAMAEEMHEMC KHJCHMHEGGP(Guid JMHOEKKPCPG)
	{
		return default(BAMAEEMHEMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x885AC20", Offset = "0x8859420", VA = "0x18885AC20")]
	public static Guid MNGPGACDACM(BAMAEEMHEMC BLIMNEEJIFL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x885AAA0", Offset = "0x88592A0", VA = "0x18885AAA0")]
	public static bool KPGEPCCDLBJ(BAMAEEMHEMC BLIMNEEJIFL, [Out] Guid JMHOEKKPCPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x885A930", Offset = "0x8859130", VA = "0x18885A930")]
	public static bool APGPPPKNIJP(Guid JMHOEKKPCPG, [Out] BAMAEEMHEMC BLIMNEEJIFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x885A9D0", Offset = "0x88591D0", VA = "0x18885A9D0")]
	public static BAMAEEMHEMC CCFOJJBOICL(BAMAEEMHEMC BLIMNEEJIFL)
	{
		return default(BAMAEEMHEMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x885AB30", Offset = "0x8859330", VA = "0x18885AB30")]
	public static AGAGKFFELDN MAJJFJLIOKE(BAMAEEMHEMC IFHICGNEBMC)
	{
		return default(AGAGKFFELDN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x885ABE0", Offset = "0x88593E0", VA = "0x18885ABE0")]
	internal static BAMAEEMHEMC MMDAENCFFIE(AGAGKFFELDN BFDMLPKNCNO)
	{
		return default(BAMAEEMHEMC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JPIOBNJPKCC
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	EIGONBNGIIK AAIEKHMDGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	LOAOCAFLNEN INJLKHMAOPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	APAMIKOGBPP KAIJLPBKJPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<HNFICDGBCAP> DHKICFGGONF;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action AMEFABDJPHB;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BAMAEEMHEMC MCJGKBBAEMM(EIGONBNGIIK OINLJEGCCDI);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<HNFICDGBCAP> IINIPPAHAAD(CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task HPDCKMKKKAF(long GFHIJAKOMMI, IReadOnlyList<GIAKFKLAKFB> FPBMENABJFA);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task NALHDHIELKN(long GFHIJAKOMMI, long JPKIDMNFGFI, IReadOnlyList<GIAKFKLAKFB> FPBMENABJFA);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<EIGONBNGIIK> LFGMEDPEPMF();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class CMIJDFJAKJP
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x88506C0", Offset = "0x884EEC0", VA = "0x1888506C0")]
	public static BAMAEEMHEMC GFFGLFEPLDL(this JPIOBNJPKCC FAMPDIPEBJL)
	{
		return default(BAMAEEMHEMC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface ANOFBMJOGDL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	BLOHKCKJPEP EJENIAOEJCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event KKOIKDHLAJI HKAIIINBKHC;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<KNFOKONCEAP> PJGGEJGPFCO(bool PDJAELDFALM = false);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KNFOKONCEAP DJMAHIHPMIE(EIGONBNGIIK OINLJEGCCDI);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool EJFNEOHCPHD(EIGONBNGIIK OINLJEGCCDI);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IReadOnlyList<KNFOKONCEAP> AMMHMJAPOBC(EIGONBNGIIK OINLJEGCCDI, bool MIAEDGOHNOA = false);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool DHIEGHGBFAA(EIGONBNGIIK ACLNPINFKCG, BAMAEEMHEMC BLIMNEEJIFL);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KNFOKONCEAP GJMCMBAKODM(BAMAEEMHEMC BLIMNEEJIFL);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool JLHEGOMNAKD<T>(BAMAEEMHEMC BLIMNEEJIFL, EAIHJJGBIAB GHKACKCGIEN, bool OFLDFGEOJBB, T OPAHMKOAAKD, [Optional] Action PLDLKHPCHNG) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string MFNCOENMFCA(EAIHJJGBIAB GHKACKCGIEN);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool HADKEMBEJCB(EIGONBNGIIK OINLJEGCCDI, EAIHJJGBIAB HKJMANNLOAK);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface JCICBLNAHII
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PAMHFIEPHMK(PCENONMPPIA JPCNIAHCHAA, CancellationToken GMEAHOBHMAD);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface EBNMLDDIFNB<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string HPLDGGGGFJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event LOPHJJOPFHJ<TPermission> ONKGIGBMINB;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal abstract class HCONHAHBGBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal object? IFMOJFIJINK;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public object? PKPKHHIBNDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8857B00", Offset = "0x8856300", VA = "0x188857B00")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8857A00", Offset = "0x8856200", VA = "0x188857A00")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8857BD0", Offset = "0x88563D0", VA = "0x188857BD0")]
	protected HCONHAHBGBI(object? BFEDEDGNOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool GEEFJFFEMNC(object? MGONBEDEDON);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class LGBKOHHLHOL<T> : HCONHAHBGBI where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> JPBEDJHBGMM;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public T HDAKFEADKFH
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x52DB7B0", Offset = "0x52D9FB0", VA = "0x1852DB7B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x52DB5A0", Offset = "0x52D9DA0", VA = "0x1852DB5A0", Slot = "4")]
	public override bool GEEFJFFEMNC(object? MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x52DBC70", Offset = "0x52DA470", VA = "0x1852DBC70")]
	public bool OCMHNIHPFDG(T HHNJAHCNACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x52DC060", Offset = "0x52DA860", VA = "0x1852DC060")]
	public LGBKOHHLHOL(T GJPLADDCFJL, IEqualityComparer<T> JPBEDJHBGMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class PBBINEIHKHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<EAIHJJGBIAB, bool> EBNIDIAOEKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<EAIHJJGBIAB, HCONHAHBGBI> OCBJMOEILHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly KKLGHMEIAHI LHNPENFAJMJ;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x885DBB0", Offset = "0x885C3B0", VA = "0x18885DBB0")]
	public PBBINEIHKHL(KKLGHMEIAHI LHNPENFAJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x885D7B0", Offset = "0x885BFB0", VA = "0x18885D7B0")]
	public bool GGBMNCLGHFD(EAIHJJGBIAB GHKACKCGIEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3B95D10", Offset = "0x3B94510", VA = "0x183B95D10")]
	public bool LMIBOHALGMO<T>(EAIHJJGBIAB GHKACKCGIEN, bool OFLDFGEOJBB, T MGONBEDEDON) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3B95810", Offset = "0x3B94010", VA = "0x183B95810")]
	public (bool, T?) DJFEMBCELDF<T>(EAIHJJGBIAB GHKACKCGIEN) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x885DA00", Offset = "0x885C200", VA = "0x18885DA00")]
	public bool LMIBOHALGMO(EAIHJJGBIAB GHKACKCGIEN, bool OFLDFGEOJBB, object MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x885D620", Offset = "0x885BE20", VA = "0x18885D620")]
	public (bool, object) DJFEMBCELDF(EAIHJJGBIAB GHKACKCGIEN)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3B95CB0", Offset = "0x3B944B0", VA = "0x183B95CB0")]
	private void IADPCOFEAIB<T>(EAIHJJGBIAB GHKACKCGIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x885DAE0", Offset = "0x885C2E0", VA = "0x18885DAE0")]
	private HCONHAHBGBI LNALICOPJGN(EAIHJJGBIAB GHKACKCGIEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x885D820", Offset = "0x885C020", VA = "0x18885D820")]
	public void KCEEDDCAENA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class KJHPCPALBKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string DAHGILMMGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type MBHBEMLHPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly PHIJIEDFFCD JEACJAFPHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly EAIHJJGBIAB NAOEECLLOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public DFCKBAFCLPL EODJDJLFLAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public OOLOJDACLCK NHAMPPLJMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public OKAICLPGADN GBDKDANLDMP;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x885B420", Offset = "0x8859C20", VA = "0x18885B420")]
	public KJHPCPALBKN(Type PGKKCEFOKNA, string AHKKKFOPOCC, EAIHJJGBIAB GHKACKCGIEN, DFCKBAFCLPL IHEFIDJBAFL, OOLOJDACLCK KDLLAGPCHBM, OKAICLPGADN HJJELPOJMEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x885B320", Offset = "0x8859B20", VA = "0x18885B320")]
	public object GLFPPNEIIBD(object? KEKEFPAJGHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3A92D70", Offset = "0x3A91570", VA = "0x183A92D70")]
	public void IADPCOFEAIB<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x885B370", Offset = "0x8859B70", VA = "0x18885B370")]
	public void IADPCOFEAIB(Type FOCNDJJFKLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class IJOFCFHNHPL<T> : KJHPCPALBKN where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate string KFOGDINFLID(T MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal delegate T BPICGIPEAIG(string? EILDGCOEGCH, T GJPLADDCFJL);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class GEJDJAHJDJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public KFOGDINFLID serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public BPICGIPEAIG parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public GEJDJAHJDJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4C83F60", Offset = "0x4C82760", VA = "0x184C83F60")]
		internal string CHOMCFDJKME(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4C84030", Offset = "0x4C82830", VA = "0x184C84030")]
		internal object GCNDFOALFJI(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4E86E40", Offset = "0x4E85640", VA = "0x184E86E40")]
	public IJOFCFHNHPL(EAIHJJGBIAB GHKACKCGIEN, string AHKKKFOPOCC, [Optional] KFOGDINFLID? IHEFIDJBAFL, [Optional] BPICGIPEAIG? KDLLAGPCHBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4E86B00", Offset = "0x4E85300", VA = "0x184E86B00")]
	private static object? OLFGCACBCKJ(BPICGIPEAIG? KDLLAGPCHBM, string? EILDGCOEGCH, object? GJPLADDCFJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4E861C0", Offset = "0x4E849C0", VA = "0x184E861C0")]
	private static string GJCNJFECIPF(KFOGDINFLID? MONDKJCINNP, object? MGONBEDEDON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate string DFCKBAFCLPL(object? MGONBEDEDON);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate object OOLOJDACLCK(string? EILDGCOEGCH, [Optional] object GJPLADDCFJL);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal delegate HCONHAHBGBI OKAICLPGADN();
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class KKLGHMEIAHI
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class BDAOGAGLIEJ : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static BDAOGAGLIEJ HPECEAELCLK;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8850390", Offset = "0x884EB90", VA = "0x188850390", Slot = "4")]
		public bool Equals(List<string> BDGPJOKJNIL, List<string> HDAFCDJNHAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x88504E0", Offset = "0x884ECE0", VA = "0x1888504E0", Slot = "5")]
		public int GetHashCode(List<string> HPLLAPMNIJF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public BDAOGAGLIEJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class KHKJNHHODBJ : ENJIDLEHKLE<IKNFGFHJDNF>
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x885B020", Offset = "0x8859820", VA = "0x18885B020", Slot = "9")]
		public override string GJCNJFECIPF(IKNFGFHJDNF FNFJALHKEGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x885B110", Offset = "0x8859910", VA = "0x18885B110", Slot = "10")]
		protected override bool KDCGPHJJMAE(string FNFJALHKEGF, [Out] IKNFGFHJDNF MGONBEDEDON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x885B2E0", Offset = "0x8859AE0", VA = "0x18885B2E0")]
		public KHKJNHHODBJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly ONCOFIMIJON GCKMFMPPNKI;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly KHKJNHHODBJ DOCLBGMKCKO;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<KJHPCPALBKN> IKLNGBOKJNN;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<EAIHJJGBIAB> MELBNEMKPNO
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IReadOnlyDictionary<EAIHJJGBIAB, KJHPCPALBKN> KPGFECEMNNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x885CA30", Offset = "0x885B230", VA = "0x18885CA30")]
	public KKLGHMEIAHI([Optional] IList<KJHPCPALBKN>? BBJEBHMLONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x885B4C0", Offset = "0x8859CC0", VA = "0x18885B4C0")]
	public KJHPCPALBKN FMCHDHKDMNE(EAIHJJGBIAB GHKACKCGIEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface BLOHKCKJPEP
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	KNFOKONCEAP KJBPGCKKBPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class INAFALAGGLO : BLOHKCKJPEP
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static INAFALAGGLO GMHAIGBPOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly IKFANADAFHH CLLOAFFCCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<IKFANADAFHH> PCOKHLNNCCD;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public KNFOKONCEAP KJBPGCKKBPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x885A820", Offset = "0x8859020", VA = "0x18885A820")]
	public INAFALAGGLO(IKFANADAFHH JNIPJINFFFB, IReadOnlyList<IKFANADAFHH> NDINKMGBCMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8859910", Offset = "0x8858110", VA = "0x188859910")]
	private static INAFALAGGLO NKKCAPJPDFA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class DIPOPOLBEFB
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<BAMAEEMHEMC> FJBAEEKLHJL;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8850DF0", Offset = "0x884F5F0", VA = "0x188850DF0")]
	public static bool CAKLPOCHEHP(this EIGONBNGIIK PCJIBHNFPNF, BAMAEEMHEMC BLIMNEEJIFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8850ED0", Offset = "0x884F6D0", VA = "0x188850ED0")]
	public static bool EJIHDLFGCHC(this EIGONBNGIIK PCJIBHNFPNF, BAMAEEMHEMC BLIMNEEJIFL, APAMIKOGBPP CGHNFDIDPDG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface CCGLECHDKMC
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	IReadOnlyList<string> PJBFLPKNBPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	IKNFGFHJDNF JKDKNPHJAON
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface KNFOKONCEAP : CCGLECHDKMC, PIEAKEPHAJH, EBNMLDDIFNB<EAIHJJGBIAB>
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string OFOMFDFAFKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	BAMAEEMHEMC OHDMBBECEMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) CMBOBNDOPLH<T>(EAIHJJGBIAB GHKACKCGIEN) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal class IKFANADAFHH : KNFOKONCEAP, CCGLECHDKMC, PIEAKEPHAJH, EBNMLDDIFNB<EAIHJJGBIAB>
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal static readonly KKLGHMEIAHI MKOJDMOCDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal readonly PBBINEIHKHL BBGGIPIFPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private string? GAHPPCKILIA;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private bool FCNCLAMCLIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x88591F0", Offset = "0x88579F0", VA = "0x1888591F0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private bool OMBEACGCJKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8858C80", Offset = "0x8857480", VA = "0x188858C80", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool OECEECMEPHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8858C30", Offset = "0x8857430", VA = "0x188858C30", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool NDNOBIBDINI
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8858FC0", Offset = "0x88577C0", VA = "0x188858FC0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool HDPMKAAGEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8859010", Offset = "0x8857810", VA = "0x188859010", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool IDJGGIAEAFI
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8859290", Offset = "0x8857A90", VA = "0x188859290", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public BAMAEEMHEMC OHDMBBECEMK
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA76470", Offset = "0xA74C70", VA = "0x180A76470", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(BAMAEEMHEMC);
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA34760", Offset = "0xA32F60", VA = "0x180A34760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public string HPLDGGGGFJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x88593B0", Offset = "0x8857BB0", VA = "0x1888593B0", Slot = "17")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string OFOMFDFAFKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x88593B0", Offset = "0x8857BB0", VA = "0x1888593B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool DJCEHMGNPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA56260", Offset = "0xA54A60", VA = "0x180A56260")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA56080", Offset = "0xA54880", VA = "0x180A56080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IKNFGFHJDNF JKDKNPHJAON
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8859240", Offset = "0x8857A40", VA = "0x188859240", Slot = "8")]
		get
		{
			return default(IKNFGFHJDNF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public IReadOnlyList<string> PJBFLPKNBPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8858B20", Offset = "0x8857320", VA = "0x188858B20", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool LHLOPLMEGHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x88591F0", Offset = "0x88579F0", VA = "0x1888591F0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool KJIOICHBFME
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8859010", Offset = "0x8857810", VA = "0x188859010", Slot = "19")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool LFOHMOPIKMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8858C80", Offset = "0x8857480", VA = "0x188858C80", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool LOIOBODFAEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8858C30", Offset = "0x8857430", VA = "0x188858C30", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool MDAFNDCPFLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8858FC0", Offset = "0x88577C0", VA = "0x188858FC0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool OBDJOBCPDDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8859290", Offset = "0x8857A90", VA = "0x188859290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event LOPHJJOPFHJ<EAIHJJGBIAB> ONKGIGBMINB
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8859300", Offset = "0x8857B00", VA = "0x188859300", Slot = "15")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8858B80", Offset = "0x8857380", VA = "0x188858B80", Slot = "16")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3A28CF0", Offset = "0x3A274F0", VA = "0x183A28CF0", Slot = "6")]
	public (bool, T?) CMBOBNDOPLH<T>(EAIHJJGBIAB GHKACKCGIEN) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3A28C90", Offset = "0x3A27490", VA = "0x183A28C90")]
	public IKFANADAFHH ACNBLNMPCBC<T>(EAIHJJGBIAB GHKACKCGIEN, bool OFLDFGEOJBB, T MGONBEDEDON) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8859790", Offset = "0x8857F90", VA = "0x188859790")]
	public IKFANADAFHH(BAMAEEMHEMC BLIMNEEJIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x88596F0", Offset = "0x8857EF0", VA = "0x1888596F0")]
	public IKFANADAFHH(BAMAEEMHEMC BLIMNEEJIFL, [Optional] string? GAHPPCKILIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8859710", Offset = "0x8857F10", VA = "0x188859710")]
	public IKFANADAFHH(IKFANADAFHH FHENPIILLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x88597B0", Offset = "0x8857FB0", VA = "0x1888597B0")]
	internal IKFANADAFHH(BAMAEEMHEMC LBEBHDKFJMH, [Optional] string? GAHPPCKILIA, [Optional] IKFANADAFHH? FHENPIILLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8859600", Offset = "0x8857E00", VA = "0x188859600")]
	public static PHIJIEDFFCD PFBEBLAOICO(EAIHJJGBIAB GHKACKCGIEN)
	{
		return default(PHIJIEDFFCD);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x88592E0", Offset = "0x8857AE0", VA = "0x1888592E0")]
	public void KCEEDDCAENA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8858CD0", Offset = "0x88574D0", VA = "0x188858CD0")]
	internal IKFANADAFHH FEKEPKLBKHI(IKFANADAFHH GKKENHBEJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8858760", Offset = "0x8856F60", VA = "0x188858760")]
	internal IReadOnlyCollection<EAIHJJGBIAB> BFMJNOOKHBJ(IKFANADAFHH FHENPIILLIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8857D20", Offset = "0x8856520", VA = "0x188857D20")]
	public bool BBFMLIGMNLB(EAIHJJGBIAB GHKACKCGIEN, bool OFLDFGEOJBB, string KPFMBGDKMKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x88590F0", Offset = "0x88578F0", VA = "0x1888590F0")]
	public (bool, string) HJPMDJOKHAE(EAIHJJGBIAB GHKACKCGIEN)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8857CD0", Offset = "0x88564D0", VA = "0x188857CD0")]
	internal void ACIDIGGACCC(EAIHJJGBIAB GHKACKCGIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8859400", Offset = "0x8857C00", VA = "0x188859400")]
	public HFMPHOCFKCG OOMHFHKBBNC(Func<BAMAEEMHEMC, Guid> OKNGMNCHDIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x8857E00", Offset = "0x8856600", VA = "0x188857E00")]
	public void BDLKKDJFINF(HFMPHOCFKCG HHEGJAIFHMF, Func<Guid, BAMAEEMHEMC> IBPIAKGLMEO, [Optional] BAMAEEMHEMC? GDJBPGDOICJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8859060", Offset = "0x8857860", VA = "0x188859060")]
	[CompilerGenerated]
	private void GLOODGLKLID(EAIHJJGBIAB HKJMANNLOAK, BMPNLEEHFKC DKABIJKKDHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class EFKBCMIOELP : JCICBLNAHII, ANOFBMJOGDL, IDisposable, HEMFOGHFDJC
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class IMKNFDFILEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public IKFANADAFHH newRole;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public IMKNFDFILEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x88598E0", Offset = "0x88580E0", VA = "0x1888598E0")]
		internal bool JFALBLBOACN(IKFANADAFHH rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class MJINIGMAIDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public BAMAEEMHEMC roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public MJINIGMAIDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x1D04830", Offset = "0x1D03030", VA = "0x181D04830")]
		internal bool JOFJNNIEBFE(BAMAEEMHEMC r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct CMKKLKPMMMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public EFKBCMIOELP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public PCENONMPPIA roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private TaskAwaiter<HNFICDGBCAP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8850720", Offset = "0x884EF20", VA = "0x188850720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8850D90", Offset = "0x884F590", VA = "0x188850D90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class GFKHGALDKEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public GFKHGALDKEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8857920", Offset = "0x8856120", VA = "0x188857920")]
		internal void FJLIGFNCGOB(HFMPHOCFKCG r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8857800", Offset = "0x8856000", VA = "0x188857800")]
		internal void CCEMOCKDMFO(HFMPHOCFKCG r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct EOHHJJKIPEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public PCENONMPPIA roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class DOALEIFGGNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Func<HFMPHOCFKCG, BMPNLEEHFKC> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public DOALEIFGGNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x88510F0", Offset = "0x884F8F0", VA = "0x1888510F0")]
		internal void DACIMIJGJED(HFMPHOCFKCG r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8851150", Offset = "0x884F950", VA = "0x188851150")]
		internal void ODPNNNLINLM(HFMPHOCFKCG r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8851120", Offset = "0x884F920", VA = "0x188851120")]
		internal void LGHBCMPHEJF(HFMPHOCFKCG r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class OMHDGCCBELC<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private struct <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public OMHDGCCBELC<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private TaskAwaiter<HNFICDGBCAP> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x4232260", Offset = "0x4230A60", VA = "0x184232260", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xA86C20", Offset = "0xA85420", VA = "0x180A86C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public EAIHJJGBIAB rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public BAMAEEMHEMC accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public PHIJIEDFFCD recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public EFKBCMIOELP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public OMHDGCCBELC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x574B4F0", Offset = "0x5749CF0", VA = "0x18574B4F0")]
		[AsyncStateMachine(typeof(OMHDGCCBELC<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void DGBBABHFMLH()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct MNPHMCJNDBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public IReadOnlyList<GIAKFKLAKFB> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct FFHHLMPCHOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public JPIOBNJPKCC rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public PCENONMPPIA roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public IReadOnlyDictionary<BAMAEEMHEMC, IKFANADAFHH> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public AFIBAJHIFMJ debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8856C80", Offset = "0x8855480", VA = "0x188856C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x88577A0", Offset = "0x8855FA0", VA = "0x1888577A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly JPIOBNJPKCC FAMPDIPEBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly INAFALAGGLO PINBPMCDIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly AFIBAJHIFMJ IKIKFGGLHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly Dictionary<int, IKFANADAFHH> NKJADDCNDEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal readonly Dictionary<BAMAEEMHEMC, IKFANADAFHH> HKEBCLJJIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal readonly Dictionary<BAMAEEMHEMC, IKFANADAFHH> MMOJDGIJJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal readonly List<IKFANADAFHH> JJBIDKMBOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool LLALAANLIBI;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly EAIHJJGBIAB[] FJBKFMLMEEF;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public BLOHKCKJPEP EJENIAOEJCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event KKOIKDHLAJI HKAIIINBKHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x88548A0", Offset = "0x88530A0", VA = "0x1888548A0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8855520", Offset = "0x8853D20", VA = "0x188855520", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x8851440", Offset = "0x884FC40", VA = "0x188851440")]
	[NOOFMBJKOEL.BCMLOIAHPDE]
	internal static void BGEJLCAAPFF(OIKNHNBNAFI ECLFBIAPGIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x88569C0", Offset = "0x88551C0", VA = "0x1888569C0")]
	[UnityEngine.Scripting.Preserve]
	internal EFKBCMIOELP([FAPODKMFODF(null)] JPIOBNJPKCC KLAMLCLOODE, [FAPODKMFODF(null)] INAFALAGGLO FGNNFFLBDNP, [FAPODKMFODF(null)] AFIBAJHIFMJ IKIKFGGLHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x8852330", Offset = "0x8850B30", VA = "0x188852330", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x88526F0", Offset = "0x8850EF0", VA = "0x1888526F0")]
	private void EKEAMKOEKJI(IEnumerable<IKFANADAFHH> MJJKHIFHPJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x8852620", Offset = "0x8850E20", VA = "0x188852620", Slot = "10")]
	public bool EJFNEOHCPHD(EIGONBNGIIK OINLJEGCCDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x8851180", Offset = "0x884F980", VA = "0x188851180")]
	private void AMEFABDJPHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x8852440", Offset = "0x8850C40", VA = "0x188852440")]
	private void EBBHBJPNDJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x8856770", Offset = "0x8854F70", VA = "0x188856770", Slot = "8")]
	public IReadOnlyList<KNFOKONCEAP> PJGGEJGPFCO(bool PDJAELDFALM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x8852220", Offset = "0x8850A20", VA = "0x188852220", Slot = "9")]
	public KNFOKONCEAP DJMAHIHPMIE(EIGONBNGIIK OINLJEGCCDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x88547D0", Offset = "0x8852FD0", VA = "0x1888547D0")]
	private BAMAEEMHEMC HPAMCLFIFCA(EIGONBNGIIK OINLJEGCCDI)
	{
		return default(BAMAEEMHEMC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x88520B0", Offset = "0x88508B0", VA = "0x1888520B0", Slot = "12")]
	public bool DHIEGHGBFAA(EIGONBNGIIK ACLNPINFKCG, BAMAEEMHEMC BLIMNEEJIFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8854080", Offset = "0x8852880", VA = "0x188854080", Slot = "13")]
	public KNFOKONCEAP GJMCMBAKODM(BAMAEEMHEMC BLIMNEEJIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8856440", Offset = "0x8854C40", VA = "0x188856440")]
	private static bool PECLJEIBKCD(AJOEOGANDHO MFMLAGOBNKI, BAMAEEMHEMC BLIMNEEJIFL, [Out] HFMPHOCFKCG? IPICGABDCMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8854BD0", Offset = "0x88533D0", VA = "0x188854BD0")]
	private static void IBNFBAANMBL(AJOEOGANDHO MFMLAGOBNKI, Action<HFMPHOCFKCG> JKNBCCDMDHB, BAMAEEMHEMC JGLKJIELMKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8854940", Offset = "0x8853140", VA = "0x188854940")]
	private static void IBNFBAANMBL(AJOEOGANDHO MFMLAGOBNKI, Action<HFMPHOCFKCG> JKNBCCDMDHB, Predicate<BAMAEEMHEMC> KOKKOGFHDBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x88554B0", Offset = "0x8853CB0", VA = "0x1888554B0")]
	private void OADMKBNNMBB(EIGONBNGIIK OINLJEGCCDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x88555C0", Offset = "0x8853DC0", VA = "0x1888555C0", Slot = "4")]
	[AsyncStateMachine(typeof(CMKKLKPMMMO))]
	public Task PAMHFIEPHMK([CanBeNull] PCENONMPPIA JPCNIAHCHAA, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x88532C0", Offset = "0x8851AC0", VA = "0x1888532C0")]
	private void FFMDBEAFCHJ(AJOEOGANDHO JAPHFNJCJMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8855090", Offset = "0x8853890", VA = "0x188855090")]
	internal static string NIHONJKMMAI(JPIOBNJPKCC FAMPDIPEBJL, PCENONMPPIA JPCNIAHCHAA, IReadOnlyDictionary<BAMAEEMHEMC, IKFANADAFHH> HKEBCLJJIID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x88556E0", Offset = "0x8853EE0", VA = "0x1888556E0")]
	private static void PDEGKABNOLF(PCENONMPPIA JPCNIAHCHAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8853D30", Offset = "0x8852530", VA = "0x188853D30")]
	private static void FOKAMPFEHDB(AJOEOGANDHO EFHPEBINLPH, IReadOnlyDictionary<BAMAEEMHEMC, IKFANADAFHH> HKEBCLJJIID, StringBuilder ACHACLHMBNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x88553A0", Offset = "0x8853BA0", VA = "0x1888553A0")]
	private static bool NMDALDCLKEO(string NNPHJFPIPFG, [Out] Guid FABDLDBCOAC, [Out] BAMAEEMHEMC BLIMNEEJIFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8853600", Offset = "0x8851E00", VA = "0x188853600")]
	private static void FMDHCJHHKFI(PCENONMPPIA JPCNIAHCHAA, StringBuilder ACHACLHMBNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3841B50", Offset = "0x3840350", VA = "0x183841B50", Slot = "14")]
	public bool JLHEGOMNAKD<T>(BAMAEEMHEMC BLIMNEEJIFL, EAIHJJGBIAB GHKACKCGIEN, bool OFLDFGEOJBB, T OPAHMKOAAKD, [Optional] Action PLDLKHPCHNG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8855020", Offset = "0x8853820", VA = "0x188855020", Slot = "15")]
	public string MFNCOENMFCA(EAIHJJGBIAB GHKACKCGIEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8854400", Offset = "0x8852C00", VA = "0x188854400", Slot = "16")]
	public bool HADKEMBEJCB(EIGONBNGIIK OINLJEGCCDI, EAIHJJGBIAB HKJMANNLOAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x88544F0", Offset = "0x8852CF0", VA = "0x1888544F0", Slot = "18")]
	public bool HADKEMBEJCB(int LFGOLEKPJOL, EAIHJJGBIAB HKJMANNLOAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8854CE0", Offset = "0x88534E0", VA = "0x188854CE0")]
	private void MEGPHGJIHBF(BAMAEEMHEMC BLIMNEEJIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8854CC0", Offset = "0x88534C0", VA = "0x188854CC0")]
	private bool KLEBKCALADN(EIGONBNGIIK OINLJEGCCDI, BAMAEEMHEMC BLIMNEEJIFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8851D80", Offset = "0x8850580", VA = "0x188851D80")]
	internal IKFANADAFHH CMDJMNJFHMF(EIGONBNGIIK OINLJEGCCDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8851190", Offset = "0x884F990", VA = "0x188851190", Slot = "11")]
	public IReadOnlyList<KNFOKONCEAP> AMMHMJAPOBC(EIGONBNGIIK OINLJEGCCDI, bool MIAEDGOHNOA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x88545A0", Offset = "0x8852DA0", VA = "0x1888545A0")]
	internal IReadOnlyList<IKFANADAFHH> HIMNECGLHAC(EIGONBNGIIK OINLJEGCCDI, bool MIAEDGOHNOA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x88515F0", Offset = "0x884FDF0", VA = "0x1888515F0")]
	private void CBBBAEKDJCB(HNFICDGBCAP OMEPMNDLFLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x8854120", Offset = "0x8852920", VA = "0x188854120")]
	private static bool GLEKFGIEBJI(IKFANADAFHH KOJIHJGNJLF, IReadOnlyDictionary<BAMAEEMHEMC, IKFANADAFHH> HKEBCLJJIID, [Out] IReadOnlyList<EAIHJJGBIAB> KLKGNLPHLFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x8854EE0", Offset = "0x88536E0", VA = "0x188854EE0")]
	[AsyncStateMachine(typeof(FFHHLMPCHOF))]
	private static Task MFGMINKMBFG(JPIOBNJPKCC FAMPDIPEBJL, PCENONMPPIA JPCNIAHCHAA, IReadOnlyDictionary<BAMAEEMHEMC, IKFANADAFHH> HKEBCLJJIID, AFIBAJHIFMJ IKIKFGGLHPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x88511A0", Offset = "0x884F9A0", VA = "0x1888511A0")]
	[CompilerGenerated]
	internal static void ANKGEALOOAB(Func<HFMPHOCFKCG, BMPNLEEHFKC> NELEAAJEPOB, EOHHJJKIPEF P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x8852F40", Offset = "0x8851740", VA = "0x188852F40")]
	[CompilerGenerated]
	internal static bool FBLIFLEAOOE(BAMAEEMHEMC BLIMNEEJIFL, EAIHJJGBIAB GHKACKCGIEN, [Out] GIAKFKLAKFB PNPHEHDKIPD, MNPHMCJNDBK P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface DAFAKEPPKHP
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AJPAGJJLMHB(EIGONBNGIIK IDKCHCBBIAJ, EIGONBNGIIK BPOGBHDDGLB, IEnumerable<EIGONBNGIIK> HHPCLPHMJND, [Out] IKNFGFHJDNF KFMAIICMJAB, [Out] DAFEOLIOKEG PGMAFLHCNCD);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string MPFLMIKFDAM(DAFEOLIOKEG LMFFLPJOPKA);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum DAFEOLIOKEG : byte
{
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	CantKickEventOrganizer,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	Broadcaster,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	GameInProgress,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	OpponentGameInProgress
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class MCLLMDMDKNH : DAFAKEPPKHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly ANOFBMJOGDL JOKGCDJNGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly BEMOLJFIAMG NJAOEDENEOL;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0xA2A040", Offset = "0xA28840", VA = "0x180A2A040")]
	[RecRoom.NoEngine.Common.Preserve]
	public MCLLMDMDKNH([FAPODKMFODF(null)] ANOFBMJOGDL JOKGCDJNGGG, [FAPODKMFODF(null)] BEMOLJFIAMG EEIBHNHNFJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x885CE50", Offset = "0x885B650", VA = "0x18885CE50")]
	private static KPDAGMLDDMN? KPLBOFFIHEN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x885CD50", Offset = "0x885B550", VA = "0x18885CD50", Slot = "4")]
	public bool AJPAGJJLMHB(EIGONBNGIIK IDKCHCBBIAJ, EIGONBNGIIK BPOGBHDDGLB, IEnumerable<EIGONBNGIIK> HHPCLPHMJND, [Out] IKNFGFHJDNF KFMAIICMJAB, [Out] DAFEOLIOKEG PGMAFLHCNCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x885CE90", Offset = "0x885B690", VA = "0x18885CE90", Slot = "5")]
	public string MPFLMIKFDAM(DAFEOLIOKEG LMFFLPJOPKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x885CF90", Offset = "0x885B790", VA = "0x18885CF90")]
	internal bool PCOBLCMJMEO(EIGONBNGIIK IDKCHCBBIAJ, EIGONBNGIIK BPOGBHDDGLB, IEnumerable<EIGONBNGIIK> HHPCLPHMJND, APAMIKOGBPP CGHNFDIDPDG, KPDAGMLDDMN? NGBPIHMKONF, [Out] IKNFGFHJDNF KFMAIICMJAB, [Out] DAFEOLIOKEG PGMAFLHCNCD)
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
