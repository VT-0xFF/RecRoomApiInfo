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
using RecRoom.DataLayer.Attributes;
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
		[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x751B070", Offset = "0x751A470", VA = "0x18751B070")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D4610", Offset = "0x8D3A10", VA = "0x1808D4610")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8D4650", Offset = "0x8D3A50", VA = "0x1808D4650")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum JNINNIAOEEO
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
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : PPJBMGKOMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x751C3D0", Offset = "0x751B7D0", VA = "0x18751C3D0", Slot = "8")]
		public override void JFOOIIGPHCJ(GHGEJHAEAMC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x648F4C0", Offset = "0x648E8C0", VA = "0x18648F4C0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void KDNDCDAJCFC<TPermission>(TPermission ADAIJKBKDJO);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void NAJGENEDGKM(JDJLHJHOJPN PEIJBHPINLD);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum CAMGJKJCFKN
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface NGEMLBCIDIO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool CAIBEAHOOFM
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool HGBABALAEMO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool OECPPCHEDIB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool DNHKIGOMAHG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool NLBICPGAAHN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool BOEICJFAFND
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class DAJMJGJEANB
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum EHHAHPPCKEB
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
	public static readonly Guid PGIKBKHDOIL;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid HDBONDMHKCJ;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid LGOAEEDGAHA;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid MIJAJBLHKOB;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid EFPNDMAEKFB;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid KMHFBDCIAKG;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly EOAIAFKLFCI<LMBPILKJBCB, Guid> BAENBMHHIIJ;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<LMBPILKJBCB> HMNIIEALIFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x750F000", Offset = "0x750E400", VA = "0x18750F000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x750F2A0", Offset = "0x750E6A0", VA = "0x18750F2A0")]
	public static LMBPILKJBCB KOJAMPDEPLA(Guid GPJCGLBMIBA)
	{
		return default(LMBPILKJBCB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x750F110", Offset = "0x750E510", VA = "0x18750F110")]
	public static Guid CKHGGCLEGNE(LMBPILKJBCB EOPHNKIHFJG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x750F330", Offset = "0x750E730", VA = "0x18750F330")]
	public static bool OIGLBCNLAFC(LMBPILKJBCB EOPHNKIHFJG, [Out] Guid GPJCGLBMIBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x750F070", Offset = "0x750E470", VA = "0x18750F070")]
	public static bool CDAOGBKCHED(Guid GPJCGLBMIBA, [Out] LMBPILKJBCB EOPHNKIHFJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x750F3C0", Offset = "0x750E7C0", VA = "0x18750F3C0")]
	public static LMBPILKJBCB PLDOGMKBCHA(LMBPILKJBCB EOPHNKIHFJG)
	{
		return default(LMBPILKJBCB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x750F1F0", Offset = "0x750E5F0", VA = "0x18750F1F0")]
	public static EHHAHPPCKEB IKDHBHBGHNA(LMBPILKJBCB LALMGNFABCI)
	{
		return default(EHHAHPPCKEB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x750F1B0", Offset = "0x750E5B0", VA = "0x18750F1B0")]
	internal static LMBPILKJBCB DNBDIMEGCKM(EHHAHPPCKEB CFBMOCGEOAL)
	{
		return default(LMBPILKJBCB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface IFMMMDIPOKK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	HOJOGFPMFIN EOELFFIAOBO
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<ADOELKGMIKC> BNAADFCDIMC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event NAJGENEDGKM HGOEDCOELFG;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<ADOELKGMIKC> PKODCOKPHBP(bool GMIKBENFNDP = false);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	ADOELKGMIKC FPOONFOBCDK(JDJLHJHOJPN PEIJBHPINLD);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool JPBHELAGLMG(JDJLHJHOJPN PEIJBHPINLD);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<ADOELKGMIKC> MJAAABGFLOD(JDJLHJHOJPN PEIJBHPINLD, bool PFFMLHPCFBM = false);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool DGGMMDJHPOO(JDJLHJHOJPN JKNLDBCEAIH, LMBPILKJBCB EOPHNKIHFJG);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	ADOELKGMIKC JEJNPEICDEG(LMBPILKJBCB EOPHNKIHFJG);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool GNBHBFIHINH<T>(LMBPILKJBCB EOPHNKIHFJG, BBCHJOGHCGH ADAIJKBKDJO, bool KIJIJLEOPAL, T NDJFIKMCNAE, [Optional] Action MKHMAGPJDMN) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string CELLHMEHDPF(BBCHJOGHCGH ADAIJKBKDJO);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CJNBIBNGJBH
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task ECGPKAAHMCG(CALEDHBDGGG AAAHDHHHHGN, CancellationToken NBBCMDKGJKI);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NMGACGMELMC(CALEDHBDGGG AAAHDHHHHGN);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface GOGJNIIADCD
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	JDJLHJHOJPN CPFAJDPOGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	IBCLDPKBHMG GELKIOCCHCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	JHLHOPAPPOB NOGEHOCGPBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<KLPHICBMCCB> CFLPLMADLKN;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action JNOFCMPCDHM;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LMBPILKJBCB HLAMLIEJIFK(JDJLHJHOJPN PEIJBHPINLD);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<KLPHICBMCCB> MJNAOMFELJI(CancellationToken NBBCMDKGJKI);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task PCPPCIABFNJ(long FJBFONPAOAD, IReadOnlyList<EFDPGIPECBA> MEEAGJDALOJ);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task ABEENFIGIKA(long FJBFONPAOAD, long AEGLBCGIGGP, IReadOnlyList<EFDPGIPECBA> MEEAGJDALOJ);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<JDJLHJHOJPN> MAIFGANCCBA();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class JOFAKLJDOGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x751AE10", Offset = "0x751A210", VA = "0x18751AE10")]
	public static LMBPILKJBCB GKFDBPFKMCC(this GOGJNIIADCD HEGNDNPEFAO)
	{
		return default(LMBPILKJBCB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface AKJMFCGLDKL<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string LGICAMKHLOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event KDNDCDAJCFC<TPermission> OBPFCIAFGDJ;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal abstract class JLBHBPIKCNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal object? PANGPBPMGEF;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? GOOFELEIOPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x751AC20", Offset = "0x751A020", VA = "0x18751AC20")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x751AB20", Offset = "0x7519F20", VA = "0x18751AB20")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x751AD00", Offset = "0x751A100", VA = "0x18751AD00")]
	protected JLBHBPIKCNJ(object? CECCFHDPPKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool HDIAEBCMCGC(object? EEPLCHCGAIN);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class AMLPELABDOM<T> : JLBHBPIKCNJ where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> IPJKNPILFIK;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T EEMLDMGPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x40D2080", Offset = "0x40D1480", VA = "0x1840D2080")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x40D1640", Offset = "0x40D0A40", VA = "0x1840D1640", Slot = "4")]
	public override bool HDIAEBCMCGC(object? EEPLCHCGAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x40D1C00", Offset = "0x40D1000", VA = "0x1840D1C00")]
	public bool LPIBNJOKGAP(T DPGDCBPJCCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x40D2350", Offset = "0x40D1750", VA = "0x1840D2350")]
	public AMLPELABDOM(T BMLEAJPEFAD, IEqualityComparer<T> IPJKNPILFIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class HCAONACEPKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<BBCHJOGHCGH, bool> DDOPNCKLBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<BBCHJOGHCGH, JLBHBPIKCNJ> LOACHBHDLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly HIPPCJNOAAP HMGIIPFOIKJ;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7515FE0", Offset = "0x75153E0", VA = "0x187515FE0")]
	public HCAONACEPKP(HIPPCJNOAAP HMGIIPFOIKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7515CB0", Offset = "0x75150B0", VA = "0x187515CB0")]
	public bool MHGCOACHIEB(BBCHJOGHCGH ADAIJKBKDJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2E6DDE0", Offset = "0x2E6D1E0", VA = "0x182E6DDE0")]
	public bool GPJLKCDGDBC<T>(BBCHJOGHCGH ADAIJKBKDJO, bool KIJIJLEOPAL, T EEPLCHCGAIN) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2E6D8E0", Offset = "0x2E6CCE0", VA = "0x182E6D8E0")]
	public (bool, T?) BKOOEENFDBA<T>(BBCHJOGHCGH ADAIJKBKDJO) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7515BD0", Offset = "0x7514FD0", VA = "0x187515BD0")]
	public bool GPJLKCDGDBC(BBCHJOGHCGH ADAIJKBKDJO, bool KIJIJLEOPAL, object EEPLCHCGAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7515A30", Offset = "0x7514E30", VA = "0x187515A30")]
	public (bool, object) BKOOEENFDBA(BBCHJOGHCGH ADAIJKBKDJO)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2E6DD80", Offset = "0x2E6D180", VA = "0x182E6DD80")]
	private void GNPCKPHEGAF<T>(BBCHJOGHCGH ADAIJKBKDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7515F10", Offset = "0x7515310", VA = "0x187515F10")]
	private JLBHBPIKCNJ PLCGNBAKKOH(BBCHJOGHCGH ADAIJKBKDJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7515D20", Offset = "0x7515120", VA = "0x187515D20")]
	public void NKAAMIJCDDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class CHGIBAOKOJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string NCDEOLGHIJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type KECHCINFJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly HKEBMIIMJPI OMPMBDKNBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly BBCHJOGHCGH NLIFABCMDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public GAOLCIBDNMG DAMACPLGABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public IFICNHPIGAH OPDLJCGFBON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MDLGGGKFJCI DGILIMANLOB;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x750EF60", Offset = "0x750E360", VA = "0x18750EF60")]
	public CHGIBAOKOJJ(Type KBONIHKKJKD, string IBGPAEEEKNO, BBCHJOGHCGH ADAIJKBKDJO, GAOLCIBDNMG FNAJBMIGPIJ, IFICNHPIGAH OGIBAJFPIFN, MDLGGGKFJCI DBPCNCFDGOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x750EE60", Offset = "0x750E260", VA = "0x18750EE60")]
	public object ELFPOJECGAC(object? KNLMODPGFOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2C61EE0", Offset = "0x2C612E0", VA = "0x182C61EE0")]
	public void GNPCKPHEGAF<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x750EEB0", Offset = "0x750E2B0", VA = "0x18750EEB0")]
	public void GNPCKPHEGAF(Type KAGCCABELCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class KPHEJMOPEOL<T> : CHGIBAOKOJJ where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate string GMHLHBIHAOA(T EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal delegate T BCOMKHIEPCL(string? NFAFKPBMOBG, T BMLEAJPEFAD);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class AEFDGINCHFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public GMHLHBIHAOA serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public BCOMKHIEPCL parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public AEFDGINCHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3FD2780", Offset = "0x3FD1B80", VA = "0x183FD2780")]
		internal string LDLJEKOJOFM(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3FD2910", Offset = "0x3FD1D10", VA = "0x183FD2910")]
		internal object LFMGLBJCOIN(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4512340", Offset = "0x4511740", VA = "0x184512340")]
	public KPHEJMOPEOL(BBCHJOGHCGH ADAIJKBKDJO, string IBGPAEEEKNO, [Optional] GMHLHBIHAOA? FNAJBMIGPIJ, [Optional] BCOMKHIEPCL? OGIBAJFPIFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4510DC0", Offset = "0x45101C0", VA = "0x184510DC0")]
	private static object? AJCCBGLJAMD(BCOMKHIEPCL? OGIBAJFPIFN, string? NFAFKPBMOBG, object? BMLEAJPEFAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x45116F0", Offset = "0x4510AF0", VA = "0x1845116F0")]
	private static string IFDLICGNEEM(GMHLHBIHAOA? GCAFNKIEEGK, object? EEPLCHCGAIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate string GAOLCIBDNMG(object? EEPLCHCGAIN);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate object IFICNHPIGAH(string? NFAFKPBMOBG, [Optional] object BMLEAJPEFAD);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal delegate JLBHBPIKCNJ MDLGGGKFJCI();
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class HIPPCJNOAAP
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class FCENMKAMNKP : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static FCENMKAMNKP GJPJBBHLIHD;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x75153F0", Offset = "0x75147F0", VA = "0x1875153F0", Slot = "4")]
		public bool Equals(List<string> LBEGFJJGJFP, List<string> GAMIAAAKNPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7515540", Offset = "0x7514940", VA = "0x187515540", Slot = "5")]
		public int GetHashCode(List<string> FMAFBHGACNM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public FCENMKAMNKP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class FKEHDLOIDOA : HANHALOCPBL<JNINNIAOEEO>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x75158F0", Offset = "0x7514CF0", VA = "0x1875158F0", Slot = "9")]
		public override string IFDLICGNEEM(JNINNIAOEEO EBJHHBADCKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7515720", Offset = "0x7514B20", VA = "0x187515720", Slot = "10")]
		protected override bool BLHLAFGLLHC(string EBJHHBADCKF, [Out] JNINNIAOEEO EEPLCHCGAIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x75159E0", Offset = "0x7514DE0", VA = "0x1875159E0")]
		public FKEHDLOIDOA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly BPFIFOALIBO PMKCONFEFGE;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly FKEHDLOIDOA OEGBCKEOBCJ;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<CHGIBAOKOJJ> JJMOCDGEDGN;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<BBCHJOGHCGH> JOIOLGEHBPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<BBCHJOGHCGH, CHGIBAOKOJJ> GCHGHHAMOGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7519830", Offset = "0x7518C30", VA = "0x187519830")]
	public HIPPCJNOAAP([Optional] IList<CHGIBAOKOJJ>? MGCOGHMGLEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7518320", Offset = "0x7517720", VA = "0x187518320")]
	public CHGIBAOKOJJ EOKDNNLDPGC(BBCHJOGHCGH ADAIJKBKDJO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface HOJOGFPMFIN
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	ADOELKGMIKC CBAKGNMMCBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class IDOEHFKCNHI : HOJOGFPMFIN
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static IDOEHFKCNHI NBMDFGPDKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly HIADGEPMDPN AEDEOJOLOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<HIADGEPMDPN> KMCFKBKGEHH;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public ADOELKGMIKC CBAKGNMMCBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x751A9E0", Offset = "0x7519DE0", VA = "0x18751A9E0")]
	public IDOEHFKCNHI(HIADGEPMDPN ICGGAAJHMKF, IReadOnlyList<HIADGEPMDPN> COGACNGJHNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7519B50", Offset = "0x7518F50", VA = "0x187519B50")]
	private static IDOEHFKCNHI NHPNBBHEDHH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class FBEMEDHIOJL
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<LMBPILKJBCB> EKBDMNPDFBA;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x75150F0", Offset = "0x75144F0", VA = "0x1875150F0")]
	public static bool BIPKBPEFPLM(this JDJLHJHOJPN OJEMPAFDPFK, LMBPILKJBCB EOPHNKIHFJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x75151D0", Offset = "0x75145D0", VA = "0x1875151D0")]
	public static bool OHMMJBHDOOC(this JDJLHJHOJPN OJEMPAFDPFK, LMBPILKJBCB EOPHNKIHFJG, JHLHOPAPPOB OAFACHFKNOP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface JCHGPOLAHFM
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool KEGNKLHIJCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool KMJDFOKLHIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool ELCLFJBLFNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool JCONONCKBLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool OJAMLJLEPKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool DCKAIFCEMLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool EMBBMHPLNBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool GFLNKMGNKBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool ECPILCGBDBN
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool BEMLCALIBPM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool COPNDLFLKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool BNNCHPBAIOO
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> DOJCPCFENFN
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	JNINNIAOEEO LAKDOCIHPBP
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface ADOELKGMIKC : JCHGPOLAHFM, NGEMLBCIDIO, AKJMFCGLDKL<BBCHJOGHCGH>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string JGLDNCMLFEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	LMBPILKJBCB INCDFJEJNKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) BHNKMACHCDJ<T>(BBCHJOGHCGH ADAIJKBKDJO) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum BBCHJOGHCGH
{
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	CAN_EDIT_ROOM_ROLES = 1,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	VOTE_KICK_PERMISSION = 3,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	CAN_INVITE = 4,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	CAN_TALK = 6,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	CAN_PRINT_PHOTOS = 7,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	CAN_START_GAMES = 8,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	CAN_SELF_REVIVE = 9,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	AUTO_ASSIGNED_GAME_ROLES = 11,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	CAN_CHANGE_GAME_MODE = 12,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	CAN_USE_MAKER_PEN = 13,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	CAN_USE_DELETE_ALL_BUTTON = 14,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	CAN_SAVE_INVENTIONS = 15,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	DISABLE_MIC_AUTO_MUTE = 16,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	CAN_END_GAMES_EARLY = 17,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	CAN_USE_SHARE_CAM = 18,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	DEPRECATED_CAN_EDIT_CIRCUITS = 19,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	CAN_SPAWN_INVENTIONS = 20,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	CAN_SPAWN_CONSUMABLES = 21,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	CAN_USE_ROOM_RESET_BUTTON = 22,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	CAN_USE_PLAY_GIZMOS_TOGGLE = 23,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	AUTO_ASSIGNED_PLAYER_TAGS = 24,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	CAN_USE_RRS = 25,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	ROOM_LEVEL_THRESHOLD = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	CAN_SAVE_ROOM = 1001,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	CAN_PUBLISH_ROOM = 1002,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	CAN_CLONE_ROOM = 1003,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	CAN_RESTORE_ROOM = 1004,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	CAN_EDIT_MAIN_ROOM_SETTINGS = 1006,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	CAN_EDIT_ROOM_ECON_SETTINGS = 1007,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	CAN_CREATE_SUBROOMS = 1008,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	CAN_NAME_SUBROOMS = 1009,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	CAN_CLONE_SUBROOMS = 1010,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	CAN_MOVE_SUBROOMS = 1011,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	CAN_DELETE_SUBROOMS = 1012,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	CAN_EDIT_SUBROOM_SETTINGS = 1013,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	CAN_RESET_CLOUD_VARIABLES = 1014,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	CAN_DELETE_CLOUD_VARIABLES = 1015,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	CAN_EDIT_ROOM_PROGRESSION = 1016,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	CAN_REMOVE_ROOM_BANS = 1017,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	CAN_ADD_ROOM_BANS = 1018
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal class HIADGEPMDPN : ADOELKGMIKC, JCHGPOLAHFM, NGEMLBCIDIO, AKJMFCGLDKL<BBCHJOGHCGH>
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly HIPPCJNOAAP AIFLPFALFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	internal readonly HCAONACEPKP ILHFPIOMCCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private string? DCKKLOCLAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private string? HLLNLLCDOMO;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool JFAGEHIEHAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x75163D0", Offset = "0x75157D0", VA = "0x1875163D0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool IEEJGCNDAHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x75167A0", Offset = "0x7515BA0", VA = "0x1875167A0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool HDFHIILOFBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7517840", Offset = "0x7516C40", VA = "0x187517840", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool DGCBJOFHJHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7516750", Offset = "0x7515B50", VA = "0x187516750", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool EPBEKPCKADB
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7516290", Offset = "0x7515690", VA = "0x187516290", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool IECKBJKNKFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7517AD0", Offset = "0x7516ED0", VA = "0x187517AD0", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public LMBPILKJBCB INCDFJEJNKH
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xB47470", Offset = "0xB46870", VA = "0x180B47470", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(LMBPILKJBCB);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8B6D60", Offset = "0x8B6160", VA = "0x1808B6D60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string LGICAMKHLOP
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x75167F0", Offset = "0x7515BF0", VA = "0x1875167F0", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7516840", Offset = "0x7515C40", VA = "0x187516840")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string JGLDNCMLFEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x75167F0", Offset = "0x7515BF0", VA = "0x1875167F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool DNEBNIJDELE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x92DDA0", Offset = "0x92D1A0", VA = "0x18092DDA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x92DC40", Offset = "0x92D040", VA = "0x18092DC40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool KEGNKLHIJCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x75162E0", Offset = "0x75156E0", VA = "0x1875162E0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public JNINNIAOEEO LAKDOCIHPBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7516330", Offset = "0x7515730", VA = "0x187516330", Slot = "20")]
		get
		{
			return default(JNINNIAOEEO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool KMJDFOKLHIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7517360", Offset = "0x7516760", VA = "0x187517360", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool ELCLFJBLFNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x75178E0", Offset = "0x7516CE0", VA = "0x1875178E0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool JCONONCKBLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7517B20", Offset = "0x7516F20", VA = "0x187517B20", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool OJAMLJLEPKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x75168E0", Offset = "0x7515CE0", VA = "0x1875168E0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool DCKAIFCEMLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7516380", Offset = "0x7515780", VA = "0x187516380", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool EMBBMHPLNBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7516700", Offset = "0x7515B00", VA = "0x187516700", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool GFLNKMGNKBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7517930", Offset = "0x7516D30", VA = "0x187517930", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool ECPILCGBDBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7517B70", Offset = "0x7516F70", VA = "0x187517B70", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> DOJCPCFENFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x75173B0", Offset = "0x75167B0", VA = "0x1875173B0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool MEIIJPKJAKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x75163D0", Offset = "0x75157D0", VA = "0x1875163D0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool NOMIIFJOENK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7516290", Offset = "0x7515690", VA = "0x187516290", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool NJOEEHFJNOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x75167A0", Offset = "0x7515BA0", VA = "0x1875167A0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool BEMLCALIBPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7517980", Offset = "0x7516D80", VA = "0x187517980", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool COPNDLFLKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7517890", Offset = "0x7516C90", VA = "0x187517890", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool CIGHPLLEFHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7517840", Offset = "0x7516C40", VA = "0x187517840", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool BNNCHPBAIOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7517BE0", Offset = "0x7516FE0", VA = "0x187517BE0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool BIGHAABKDFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7516750", Offset = "0x7515B50", VA = "0x187516750", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool NENEKNJOMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7517AD0", Offset = "0x7516ED0", VA = "0x187517AD0", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event KDNDCDAJCFC<BBCHJOGHCGH> OBPFCIAFGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x75172B0", Offset = "0x75166B0", VA = "0x1875172B0", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7517410", Offset = "0x7516810", VA = "0x187517410", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2E72410", Offset = "0x2E71810", VA = "0x182E72410", Slot = "6")]
	public (bool, T?) BHNKMACHCDJ<T>(BBCHJOGHCGH ADAIJKBKDJO) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2E72600", Offset = "0x2E71A00", VA = "0x182E72600")]
	public HIADGEPMDPN NPKELFCHNGA<T>(BBCHJOGHCGH ADAIJKBKDJO, bool KIJIJLEOPAL, T EEPLCHCGAIN) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7518110", Offset = "0x7517510", VA = "0x187518110")]
	public HIADGEPMDPN(LMBPILKJBCB EOPHNKIHFJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7518130", Offset = "0x7517530", VA = "0x187518130")]
	public HIADGEPMDPN(LMBPILKJBCB EOPHNKIHFJG, [Optional] string? DCKKLOCLAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7518150", Offset = "0x7517550", VA = "0x187518150")]
	public HIADGEPMDPN(HIADGEPMDPN LPKFLIAMBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x75181D0", Offset = "0x75175D0", VA = "0x1875181D0")]
	internal HIADGEPMDPN(LMBPILKJBCB CDLADPDCENH, [Optional] string? DCKKLOCLAPJ, [Optional] HIADGEPMDPN? LPKFLIAMBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7518020", Offset = "0x7517420", VA = "0x187518020")]
	public static HKEBMIIMJPI PDDCGNJJFFJ(BBCHJOGHCGH ADAIJKBKDJO)
	{
		return default(HKEBMIIMJPI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7517BC0", Offset = "0x7516FC0", VA = "0x187517BC0")]
	public void NKAAMIJCDDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x75174C0", Offset = "0x75168C0", VA = "0x1875174C0")]
	internal HIADGEPMDPN KMBJCNLBAEE(HIADGEPMDPN DALCPOIEONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7517C30", Offset = "0x7517030", VA = "0x187517C30")]
	internal IReadOnlyCollection<BBCHJOGHCGH> OOIHJHLMILI(HIADGEPMDPN LPKFLIAMBOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7516620", Offset = "0x7515A20", VA = "0x187516620")]
	public bool BGKFLEGEHMG(BBCHJOGHCGH ADAIJKBKDJO, bool KIJIJLEOPAL, string KBNMOFPLHNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x75179D0", Offset = "0x7516DD0", VA = "0x1875179D0")]
	public (bool, string) LPHHPJPPOAA(BBCHJOGHCGH ADAIJKBKDJO)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7516890", Offset = "0x7515C90", VA = "0x187516890")]
	internal void FCABMHENAOB(BBCHJOGHCGH ADAIJKBKDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7516420", Offset = "0x7515820", VA = "0x187516420")]
	public FLDEPFPLLAF BCPKHAMPIGG(Func<LMBPILKJBCB, Guid> BDNCCCLABFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7516930", Offset = "0x7515D30", VA = "0x187516930")]
	public void FPNPPJDJHLF(FLDEPFPLLAF BKGMBLAMIJB, Func<Guid, LMBPILKJBCB> LAPBHIPONGG, [Optional] LMBPILKJBCB? FHEHIOOBGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x75177B0", Offset = "0x7516BB0", VA = "0x1875177B0")]
	[CompilerGenerated]
	private void KMHPJKEKJLH(BBCHJOGHCGH EFOMMOIFLMG, MDFIIFICCLE FMCDNIFDOAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class EIMIALPAIMF : CJNBIBNGJBH, IFMMMDIPOKK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class IJBJAHFNJJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public HIADGEPMDPN newRole;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public IJBJAHFNJJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x751AAF0", Offset = "0x7519EF0", VA = "0x18751AAF0")]
		internal bool BEFGCIJJCAF(HIADGEPMDPN rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class GPFGMJGEBOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public LMBPILKJBCB roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public GPFGMJGEBOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7515A20", Offset = "0x7514E20", VA = "0x187515A20")]
		internal bool LNCCHBNOGFE(LMBPILKJBCB r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct AMLDCNBNDGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public EIMIALPAIMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public CALEDHBDGGG roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private TaskAwaiter<KLPHICBMCCB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x750DF30", Offset = "0x750D330", VA = "0x18750DF30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x750E5A0", Offset = "0x750D9A0", VA = "0x18750E5A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class KFOGOKAJGLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public KFOGOKAJGLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x751AF90", Offset = "0x751A390", VA = "0x18751AF90")]
		internal void BEJAGKIHFPD(FLDEPFPLLAF r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x751AE70", Offset = "0x751A270", VA = "0x18751AE70")]
		internal void BEDPPLOCBNK(FLDEPFPLLAF r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct BKPKCNNMOGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public CALEDHBDGGG roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class AJNHCLGCLJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Func<FLDEPFPLLAF, MDFIIFICCLE> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public AJNHCLGCLJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x750DF00", Offset = "0x750D300", VA = "0x18750DF00")]
		internal void IFAEPEHIHDF(FLDEPFPLLAF r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x750DEA0", Offset = "0x750D2A0", VA = "0x18750DEA0")]
		internal void FOBGPAJJHJL(FLDEPFPLLAF r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x750DED0", Offset = "0x750D2D0", VA = "0x18750DED0")]
		internal void GKNOJODEALL(FLDEPFPLLAF r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class DKDBFPBPAAO<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private struct <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public DKDBFPBPAAO<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private TaskAwaiter<KLPHICBMCCB> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x3872450", Offset = "0x3871850", VA = "0x183872450", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x918150", Offset = "0x917550", VA = "0x180918150", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public BBCHJOGHCGH rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public LMBPILKJBCB accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public HKEBMIIMJPI recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public EIMIALPAIMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public DKDBFPBPAAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8570", Offset = "0x5CA7970", VA = "0x185CA8570")]
		[AsyncStateMachine(typeof(DKDBFPBPAAO<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void OHOIABBDEGE()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct EEPMNGACCEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public IReadOnlyList<EFDPGIPECBA> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct OEOMFKGNNOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public GOGJNIIADCD rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public CALEDHBDGGG roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public IReadOnlyDictionary<LMBPILKJBCB, HIADGEPMDPN> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public CFKANHJCJBB debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x751B0F0", Offset = "0x751A4F0", VA = "0x18751B0F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x751BC10", Offset = "0x751B010", VA = "0x18751BC10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly GOGJNIIADCD HEGNDNPEFAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly IDOEHFKCNHI BBHHHNEKAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly CFKANHJCJBB IMDPBFNLDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly Dictionary<int, HIADGEPMDPN> FADJLDKDKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	internal readonly Dictionary<LMBPILKJBCB, HIADGEPMDPN> JKDJHDHGJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	internal readonly Dictionary<LMBPILKJBCB, HIADGEPMDPN> GBIEKADBGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	internal readonly List<HIADGEPMDPN> DKCGKCCJKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private bool EJJBGEOFNLN;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static readonly BBCHJOGHCGH[] HCFENOKDKJJ;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public HOJOGFPMFIN EOELFFIAOBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<ADOELKGMIKC> BNAADFCDIMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x750F6F0", Offset = "0x750EAF0", VA = "0x18750F6F0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event NAJGENEDGKM HGOEDCOELFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7514130", Offset = "0x7513530", VA = "0x187514130", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x75127B0", Offset = "0x7511BB0", VA = "0x1875127B0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7514330", Offset = "0x7513730", VA = "0x187514330")]
	[OAJAKDHKADM.NFPBKDCIEPB]
	internal static void MHNICLDHNFP(LBNNADLFMIK PCMEKEJCMGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7514E30", Offset = "0x7514230", VA = "0x187514E30")]
	[UnityEngine.Scripting.Preserve]
	internal EIMIALPAIMF([CCLHMIDBCEM(null)] GOGJNIIADCD GGIJDNEBLJA, [CCLHMIDBCEM(null)] IDOEHFKCNHI EAPCIHDDABJ, [CCLHMIDBCEM(null)] CFKANHJCJBB IMDPBFNLDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7510E50", Offset = "0x7510250", VA = "0x187510E50", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x750F740", Offset = "0x750EB40", VA = "0x18750F740")]
	private void AJACEIMBDFH(IEnumerable<HIADGEPMDPN> LKGDPBIOEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7512860", Offset = "0x7511C60", VA = "0x187512860", Slot = "12")]
	public bool JPBHELAGLMG(JDJLHJHOJPN PEIJBHPINLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7512850", Offset = "0x7511C50", VA = "0x187512850")]
	private void JNOFCMPCDHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7512140", Offset = "0x7511540", VA = "0x187512140")]
	private void JBOOHMLMJML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7514BE0", Offset = "0x7513FE0", VA = "0x187514BE0", Slot = "10")]
	public IReadOnlyList<ADOELKGMIKC> PKODCOKPHBP(bool GMIKBENFNDP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x75119E0", Offset = "0x7510DE0", VA = "0x1875119E0", Slot = "11")]
	public ADOELKGMIKC FPOONFOBCDK(JDJLHJHOJPN PEIJBHPINLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7512070", Offset = "0x7511470", VA = "0x187512070")]
	private LMBPILKJBCB HLHNILAINPG(JDJLHJHOJPN PEIJBHPINLD)
	{
		return default(LMBPILKJBCB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7510750", Offset = "0x750FB50", VA = "0x187510750", Slot = "14")]
	public bool DGGMMDJHPOO(JDJLHJHOJPN JKNLDBCEAIH, LMBPILKJBCB EOPHNKIHFJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7512390", Offset = "0x7511790", VA = "0x187512390", Slot = "15")]
	public ADOELKGMIKC JEJNPEICDEG(LMBPILKJBCB EOPHNKIHFJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7511080", Offset = "0x7510480", VA = "0x187511080")]
	private static bool EDPDDOHMICH(PNNIGNNMANJ KLEHBPCOHHL, LMBPILKJBCB EOPHNKIHFJG, [Out] FLDEPFPLLAF? MABIOCHMKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7512430", Offset = "0x7511830", VA = "0x187512430")]
	private static void JFBIHCCJFKM(PNNIGNNMANJ KLEHBPCOHHL, Action<FLDEPFPLLAF> LGKGEGCJMHB, LMBPILKJBCB AMNNKGLFHFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7512520", Offset = "0x7511920", VA = "0x187512520")]
	private static void JFBIHCCJFKM(PNNIGNNMANJ KLEHBPCOHHL, Action<FLDEPFPLLAF> LGKGEGCJMHB, Predicate<LMBPILKJBCB> DIHBJJPCCNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7512320", Offset = "0x7511720", VA = "0x187512320")]
	private void JCFDKIPEGAC(JDJLHJHOJPN PEIJBHPINLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7510F60", Offset = "0x7510360", VA = "0x187510F60", Slot = "4")]
	[AsyncStateMachine(typeof(AMLDCNBNDGF))]
	public Task ECGPKAAHMCG([CanBeNull] CALEDHBDGGG AAAHDHHHHGN, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "5")]
	public void NMGACGMELMC(CALEDHBDGGG AAAHDHHHHGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x75108E0", Offset = "0x750FCE0", VA = "0x1875108E0")]
	private void DHPHJKODOJI(PNNIGNNMANJ CIHHKGHOBHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7513E20", Offset = "0x7513220", VA = "0x187513E20")]
	internal static string LBPALOEIKLL(GOGJNIIADCD HEGNDNPEFAO, CALEDHBDGGG AAAHDHHHHGN, IReadOnlyDictionary<LMBPILKJBCB, HIADGEPMDPN> JKDJHDHGJBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7512930", Offset = "0x7511D30", VA = "0x187512930")]
	private static void KCAIAEEDCOM(CALEDHBDGGG AAAHDHHHHGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x75113B0", Offset = "0x75107B0", VA = "0x1875113B0")]
	private static void EMDKFHKNNCN(PNNIGNNMANJ JNIIIEMGICA, IReadOnlyDictionary<LMBPILKJBCB, HIADGEPMDPN> JKDJHDHGJBM, StringBuilder HLEEAELBHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x75144F0", Offset = "0x75138F0", VA = "0x1875144F0")]
	private static bool NENLOOIKJML(string KOMEKAGFLEA, [Out] Guid GLIPKPPHNDD, [Out] LMBPILKJBCB EOPHNKIHFJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7510010", Offset = "0x750F410", VA = "0x187510010")]
	private static void DBHCDFGCHFF(CALEDHBDGGG AAAHDHHHHGN, StringBuilder HLEEAELBHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2CCFD20", Offset = "0x2CCF120", VA = "0x182CCFD20", Slot = "16")]
	public bool GNBHBFIHINH<T>(LMBPILKJBCB EOPHNKIHFJG, BBCHJOGHCGH ADAIJKBKDJO, bool KIJIJLEOPAL, T NDJFIKMCNAE, [Optional] Action MKHMAGPJDMN) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x750FFA0", Offset = "0x750F3A0", VA = "0x18750FFA0", Slot = "17")]
	public string CELLHMEHDPF(BBCHJOGHCGH ADAIJKBKDJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7511AF0", Offset = "0x7510EF0", VA = "0x187511AF0")]
	private void GDJNDANPMKK(LMBPILKJBCB EOPHNKIHFJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x75141D0", Offset = "0x75135D0", VA = "0x1875141D0")]
	private bool MAPGOFGCGKC(JDJLHJHOJPN PEIJBHPINLD, LMBPILKJBCB EOPHNKIHFJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7514600", Offset = "0x7513A00", VA = "0x187514600")]
	internal HIADGEPMDPN NNBIBMDHFMN(JDJLHJHOJPN PEIJBHPINLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x75144E0", Offset = "0x75138E0", VA = "0x1875144E0", Slot = "13")]
	public IReadOnlyList<ADOELKGMIKC> MJAAABGFLOD(JDJLHJHOJPN PEIJBHPINLD, bool PFFMLHPCFBM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7510C20", Offset = "0x7510020", VA = "0x187510C20")]
	internal IReadOnlyList<HIADGEPMDPN> DOCNGJIEJOI(JDJLHJHOJPN PEIJBHPINLD, bool PFFMLHPCFBM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7513690", Offset = "0x7512A90", VA = "0x187513690")]
	private void KOOLEIECINI(KLPHICBMCCB JFMNNJBJCCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7511700", Offset = "0x7510B00", VA = "0x187511700")]
	private static bool FGNIOKOLEJE(HIADGEPMDPN FPEMDFDAEIE, IReadOnlyDictionary<LMBPILKJBCB, HIADGEPMDPN> JKDJHDHGJBM, [Out] IReadOnlyList<BBCHJOGHCGH> EPCJJCOFPPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x75141F0", Offset = "0x75135F0", VA = "0x1875141F0")]
	[AsyncStateMachine(typeof(OEOMFKGNNOF))]
	private static Task MGIOKOGDAPH(GOGJNIIADCD HEGNDNPEFAO, CALEDHBDGGG AAAHDHHHHGN, IReadOnlyDictionary<LMBPILKJBCB, HIADGEPMDPN> JKDJHDHGJBM, CFKANHJCJBB IMDPBFNLDEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7514940", Offset = "0x7513D40", VA = "0x187514940")]
	[CompilerGenerated]
	internal static void PGKCHKFGGAH(Func<FLDEPFPLLAF, MDFIIFICCLE> LBKONHKPJLH, BKPKCNNMOGE P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7511CF0", Offset = "0x75110F0", VA = "0x187511CF0")]
	[CompilerGenerated]
	internal static bool HGCOPGPINHO(LMBPILKJBCB EOPHNKIHFJG, BBCHJOGHCGH ADAIJKBKDJO, [Out] EFDPGIPECBA EELANFPJCFB, EEPMNGACCEH P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface HIFCJDLALFL
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KKLCOKOKAKP(JDJLHJHOJPN JKDACLHOCNM, JDJLHJHOJPN PHBFBOPGMLN, IEnumerable<JDJLHJHOJPN> AGHIIGMIHHA, [Out] JNINNIAOEEO AKPMDGFIIIF, [Out] IIHEHEAMMEE JFGDBLBGOLB);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string HHOCMKHFBLC(IIHEHEAMMEE ALPKBCDGJGE);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public enum IIHEHEAMMEE : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	CantKickEventOrganizer,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	Broadcaster,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	GameInProgress,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	OpponentGameInProgress
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal class ANFDLJAKADO : HIFCJDLALFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly IFMMMDIPOKK IIBGEKHMOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly FPBJGMBINOC JOELJDOBAKL;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x8B7B40", Offset = "0x8B6F40", VA = "0x1808B7B40")]
	[RecRoom.NoEngine.Common.Preserve]
	public ANFDLJAKADO([CCLHMIDBCEM(null)] IFMMMDIPOKK FBEMALABLHJ, [CCLHMIDBCEM(null)] FPBJGMBINOC JJKMEHPJBGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x750EE20", Offset = "0x750E220", VA = "0x18750EE20")]
	private static OEOOKOIEBOG? LHHBFOJDFGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x750ED20", Offset = "0x750E120", VA = "0x18750ED20", Slot = "4")]
	public bool KKLCOKOKAKP(JDJLHJHOJPN JKDACLHOCNM, JDJLHJHOJPN PHBFBOPGMLN, IEnumerable<JDJLHJHOJPN> AGHIIGMIHHA, [Out] JNINNIAOEEO AKPMDGFIIIF, [Out] IIHEHEAMMEE JFGDBLBGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x750EC20", Offset = "0x750E020", VA = "0x18750EC20", Slot = "5")]
	public string HHOCMKHFBLC(IIHEHEAMMEE ALPKBCDGJGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x750E600", Offset = "0x750DA00", VA = "0x18750E600")]
	internal bool GPAKDKPJHDG(JDJLHJHOJPN JKDACLHOCNM, JDJLHJHOJPN PHBFBOPGMLN, IEnumerable<JDJLHJHOJPN> AGHIIGMIHHA, JHLHOPAPPOB OAFACHFKNOP, OEOOKOIEBOG? DFAMLPNHNKA, [Out] JNINNIAOEEO AKPMDGFIIIF, [Out] IIHEHEAMMEE JFGDBLBGOLB)
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
