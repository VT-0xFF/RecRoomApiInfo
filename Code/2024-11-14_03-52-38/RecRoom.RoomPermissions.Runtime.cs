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
		[Cpp2IlInjected.Address(RVA = "0x8C5550", Offset = "0x8C4950", VA = "0x1808C5550")]
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
		[Cpp2IlInjected.Address(RVA = "0x74A0180", Offset = "0x749F580", VA = "0x1874A0180")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C5B80", Offset = "0x8C4F80", VA = "0x1808C5B80")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C5BC0", Offset = "0x8C4FC0", VA = "0x1808C5BC0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum GMHIEBHGFKG
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
	public class _AssemblyIndex : KNLEODIDJOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x74A39B0", Offset = "0x74A2DB0", VA = "0x1874A39B0", Slot = "8")]
		public override void LFFFLDDGBMJ(GFPLBLFDLJF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x63F5FE0", Offset = "0x63F53E0", VA = "0x1863F5FE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void EHDFGIAKIBJ<TPermission>(TPermission EDKLJJPLIII);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void OEBDCPBNGCD(EDHEFFCJEMG FFANAAGKHEI);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum IAHIJMJAJMC
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HODFDNMOLBN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool HGAAAEDNLCB
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool IOGODMBNLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool JBJMCNFEAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NLNPHALGMHK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool HDBGBBAOHEL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool JJNHPHCDEKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class IBEFFLKCNND
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum PGGINAEGGBG
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
	public static readonly Guid CHCLIDCCFNH;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid CPBJNEHOHFH;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid KNBDBKADMJB;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid EJNKGLKIOCM;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid EAAIPGGGLDG;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid OLOLEMEMAGG;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly FFECCPKHIFD<NBJBDKMDDDH, Guid> DCBHACGCCDE;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<NBJBDKMDDDH> NAFBLFMDBKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x749DF10", Offset = "0x749D310", VA = "0x18749DF10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x749DD50", Offset = "0x749D150", VA = "0x18749DD50")]
	public static NBJBDKMDDDH GAKHJDFEHPH(Guid MDOJFEIEAFI)
	{
		return default(NBJBDKMDDDH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x749DF90", Offset = "0x749D390", VA = "0x18749DF90")]
	public static Guid KPCCCMBCLCF(NBJBDKMDDDH HHDEACJJCJK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x749DE80", Offset = "0x749D280", VA = "0x18749DE80")]
	public static bool JHKDIAKHCGP(NBJBDKMDDDH HHDEACJJCJK, [Out] Guid MDOJFEIEAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x749DDE0", Offset = "0x749D1E0", VA = "0x18749DDE0")]
	public static bool HCJBCHLJFGN(Guid MDOJFEIEAFI, [Out] NBJBDKMDDDH HHDEACJJCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x749DD10", Offset = "0x749D110", VA = "0x18749DD10")]
	public static NBJBDKMDDDH AKILMEGGLNN(NBJBDKMDDDH HHDEACJJCJK)
	{
		return default(NBJBDKMDDDH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x749E030", Offset = "0x749D430", VA = "0x18749E030")]
	public static PGGINAEGGBG LLEKMIAOKCP(NBJBDKMDDDH AFHHKFOMLKD)
	{
		return default(PGGINAEGGBG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x749E0E0", Offset = "0x749D4E0", VA = "0x18749E0E0")]
	internal static NBJBDKMDDDH OBCOHPPELEE(PGGINAEGGBG ODJJPFDHOBP)
	{
		return default(NBJBDKMDDDH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BMECELABAGA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	KANFKGFBALN IGIDBNGLCJI
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<EKPHGGICMFB> NMPGELEOPMN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event OEBDCPBNGCD CLNNBECEALP;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<EKPHGGICMFB> MHPCDABNJCI(bool DKELHBGGILE = false);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EKPHGGICMFB IGBLIMIOHOA(EDHEFFCJEMG FFANAAGKHEI);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NDMAMKALJJC(EDHEFFCJEMG FFANAAGKHEI);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<EKPHGGICMFB> LLCGHOKJDLI(EDHEFFCJEMG FFANAAGKHEI, bool IJLJMFHMOMN = false);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool FDAHCDOCLAH(EDHEFFCJEMG MGMGNPMLOOG, NBJBDKMDDDH HHDEACJJCJK);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	EKPHGGICMFB MOCDBALJOJC(NBJBDKMDDDH HHDEACJJCJK);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool HHLBDBFLHDH<T>(NBJBDKMDDDH HHDEACJJCJK, MGDGCEENFHJ EDKLJJPLIII, bool EIKFNHMEICJ, T IDJEKAFFOBD, [Optional] Action KMENECMAGKO) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string NDJCLPFIKMN(MGDGCEENFHJ EDKLJJPLIII);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DDPNAFCINMD
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task MNMPPGHLIOH(CEGBHMDDAMC FKLCHFCGCOM, CancellationToken GBOOEEMCFEA);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DBFLPNIEBCH(CEGBHMDDAMC FKLCHFCGCOM);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface OEGMAOCHMJG
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	EDHEFFCJEMG CJCCCJMHOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	CHJIGPMNPPG ECLMNHDCPBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	INGNDDFNBAI IDLPJPCNLKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<APPBHCMHGAN> HDEOFIEFBOE;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action PPMEPNPAFHC;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NBJBDKMDDDH BKKLCMBJPJD(EDHEFFCJEMG FFANAAGKHEI);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<APPBHCMHGAN> EANPMCPODAJ(CancellationToken GBOOEEMCFEA);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task FDGOONLBEKP(long HLKBDGNJMKK, IReadOnlyList<MALIBJBLOIM> NJIGPONKEKF);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task BNNPMIBNFIN(long HLKBDGNJMKK, long FDCMMJDIOAB, IReadOnlyList<MALIBJBLOIM> NJIGPONKEKF);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<EDHEFFCJEMG> MCFOLDGDOHJ();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class HIDAOABFEOF
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x749DC80", Offset = "0x749D080", VA = "0x18749DC80")]
	public static NBJBDKMDDDH PCLFMOMLNDC(this OEGMAOCHMJG GFMFJKKBDCM)
	{
		return default(NBJBDKMDDDH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface IHGPNFEFDLG<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string HJBOFMFLBEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event EHDFGIAKIBJ<TPermission> KPJDAFHFICP;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal abstract class DDBNFKJEOIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal object? NANHJBPGJNI;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? FMPCAMFHEAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7496AD0", Offset = "0x7495ED0", VA = "0x187496AD0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x74969D0", Offset = "0x7495DD0", VA = "0x1874969D0")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7496BA0", Offset = "0x7495FA0", VA = "0x187496BA0")]
	protected DDBNFKJEOIK(object? MLFNMMDDNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool IICMCIBBOFF(object? PFKKDHPJFEH);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class PFJEKDMNMAJ<T> : DDBNFKJEOIK where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> LFBKIIFECDJ;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T FDJCHKNOIDG
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4B2C8A0", Offset = "0x4B2BCA0", VA = "0x184B2C8A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4B2C480", Offset = "0x4B2B880", VA = "0x184B2C480", Slot = "4")]
	public override bool IICMCIBBOFF(object? PFKKDHPJFEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4B2C320", Offset = "0x4B2B720", VA = "0x184B2C320")]
	public bool EADADNACOFC(T POMNOCHKGBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4B2CF00", Offset = "0x4B2C300", VA = "0x184B2CF00")]
	public PFJEKDMNMAJ(T POOOEFHFGKB, IEqualityComparer<T> LFBKIIFECDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class ADHIDNPLEDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<MGDGCEENFHJ, bool> LILLOPBCBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<MGDGCEENFHJ, DDBNFKJEOIK> KOLPBPFBOOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly MFAGKALAMJP DIHBMDJAPOI;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x74957F0", Offset = "0x7494BF0", VA = "0x1874957F0")]
	public ADHIDNPLEDB(MFAGKALAMJP DIHBMDJAPOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7495780", Offset = "0x7494B80", VA = "0x187495780")]
	public bool LELMCPPKMLK(MGDGCEENFHJ EDKLJJPLIII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x35C07D0", Offset = "0x35BFBD0", VA = "0x1835C07D0")]
	public bool FFCIDMIANDO<T>(MGDGCEENFHJ EDKLJJPLIII, bool EIKFNHMEICJ, T PFKKDHPJFEH) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x35C0330", Offset = "0x35BF730", VA = "0x1835C0330")]
	public (bool, T?) FBHEDKENCOB<T>(MGDGCEENFHJ EDKLJJPLIII) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x74955D0", Offset = "0x74949D0", VA = "0x1874955D0")]
	public bool FFCIDMIANDO(MGDGCEENFHJ EDKLJJPLIII, bool EIKFNHMEICJ, object PFKKDHPJFEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7495440", Offset = "0x7494840", VA = "0x187495440")]
	public (bool, object) FBHEDKENCOB(MGDGCEENFHJ EDKLJJPLIII)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x35C0D50", Offset = "0x35C0150", VA = "0x1835C0D50")]
	private void JMICINLJKDI<T>(MGDGCEENFHJ EDKLJJPLIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x74956B0", Offset = "0x7494AB0", VA = "0x1874956B0")]
	private DDBNFKJEOIK GHEEJIEPMHB(MGDGCEENFHJ EDKLJJPLIII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7495250", Offset = "0x7494650", VA = "0x187495250")]
	public void EOILBPMBNHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class KJGKGINMDHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string IMLAMDBADPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type BFLELNIKBDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly EHCABBJHMEK NJJOKCJGIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly MGDGCEENFHJ OMIMHNMLEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public LDKBMFLDNMG LDKFPPMIFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NHBGFDCJFCM MLINMCENCJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public CFKLMHNMFJJ GELJFMONHMH;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x749E540", Offset = "0x749D940", VA = "0x18749E540")]
	public KJGKGINMDHE(Type CIOECLPNOAB, string AFPNHEGFHHG, MGDGCEENFHJ EDKLJJPLIII, LDKBMFLDNMG MHMFNIHDNIC, NHBGFDCJFCM KEGOOEMEBEM, CFKLMHNMFJJ MFHPOAEBOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x749E4F0", Offset = "0x749D8F0", VA = "0x18749E4F0")]
	public object NBMNNMNMCHH(object? OGKFFDCECEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2F721A0", Offset = "0x2F715A0", VA = "0x182F721A0")]
	public void JMICINLJKDI<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x749E440", Offset = "0x749D840", VA = "0x18749E440")]
	public void JMICINLJKDI(Type LJOHJKCGJMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class CHAFMFGANKJ<T> : KJGKGINMDHE where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate string LJFPPAEKOOD(T PFKKDHPJFEH);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal delegate T MFMJBGBCBNH(string? NFGKCPICLHH, T POOOEFHFGKB);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class PHHIGJKPFCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public LJFPPAEKOOD serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public MFMJBGBCBNH parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public PHHIGJKPFCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4B30080", Offset = "0x4B2F480", VA = "0x184B30080")]
		internal string LJGJHBLLKLC(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4B2FFC0", Offset = "0x4B2F3C0", VA = "0x184B2FFC0")]
		internal object FBJPEOLDBPA(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5634640", Offset = "0x5633A40", VA = "0x185634640")]
	public CHAFMFGANKJ(MGDGCEENFHJ EDKLJJPLIII, string AFPNHEGFHHG, [Optional] LJFPPAEKOOD? MHMFNIHDNIC, [Optional] MFMJBGBCBNH? KEGOOEMEBEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x56336E0", Offset = "0x5632AE0", VA = "0x1856336E0")]
	private static object? LIJBJHOEHGL(MFMJBGBCBNH? KEGOOEMEBEM, string? NFGKCPICLHH, object? POOOEFHFGKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5632EB0", Offset = "0x56322B0", VA = "0x185632EB0")]
	private static string IJIPNHCCMND(LJFPPAEKOOD? EFMPGOFGMAF, object? PFKKDHPJFEH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate string LDKBMFLDNMG(object? PFKKDHPJFEH);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate object NHBGFDCJFCM(string? NFGKCPICLHH, [Optional] object POOOEFHFGKB);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal delegate DDBNFKJEOIK CFKLMHNMFJJ();
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class MFAGKALAMJP
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class OIPPCAKKJAF : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static OIPPCAKKJAF GHDNHBBFDEB;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x74A0D80", Offset = "0x74A0180", VA = "0x1874A0D80", Slot = "4")]
		public bool Equals(List<string> KPPEBBOFEKD, List<string> EJAKPDCBGAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x74A0ED0", Offset = "0x74A02D0", VA = "0x1874A0ED0", Slot = "5")]
		public int GetHashCode(List<string> FAKGLFFOLFI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public OIPPCAKKJAF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class ECCKMLNDAKK : DBCAJGLBKLB<GMHIEBHGFKG>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7496E70", Offset = "0x7496270", VA = "0x187496E70", Slot = "9")]
		public override string IJIPNHCCMND(GMHIEBHGFKG CMILLOOAKEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7496CA0", Offset = "0x74960A0", VA = "0x187496CA0", Slot = "10")]
		protected override bool BKECIFEODPM(string CMILLOOAKEN, [Out] GMHIEBHGFKG PFKKDHPJFEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7496F60", Offset = "0x7496360", VA = "0x187496F60")]
		public ECCKMLNDAKK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly APMAAFIDCCD NAFFGIMOFPM;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly ECCKMLNDAKK CNDEGOKKAJK;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<KJGKGINMDHE> HHPOIIOHPHF;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<MGDGCEENFHJ> COPJDMLGEIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<MGDGCEENFHJ, KJGKGINMDHE> JAMAFAGOMKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x749FE30", Offset = "0x749F230", VA = "0x18749FE30")]
	public MFAGKALAMJP([Optional] IList<KJGKGINMDHE>? ELFEGIBCIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x749E8F0", Offset = "0x749DCF0", VA = "0x18749E8F0")]
	public KJGKGINMDHE BJDBAGABPGE(MGDGCEENFHJ EDKLJJPLIII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface KANFKGFBALN
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	EKPHGGICMFB JOKAFLDDAEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class HDAOPIPEJAM : KANFKGFBALN
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static HDAOPIPEJAM BNHNMBMFCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly PDKFIMBBKEB OCNJBBPJBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<PDKFIMBBKEB> EINPFCJLKGN;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public EKPHGGICMFB JOKAFLDDAEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x749DB70", Offset = "0x749CF70", VA = "0x18749DB70")]
	public HDAOPIPEJAM(PDKFIMBBKEB EPOEIGKNCAG, IReadOnlyList<PDKFIMBBKEB> EAAHCCENFDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x749CCD0", Offset = "0x749C0D0", VA = "0x18749CCD0")]
	private static HDAOPIPEJAM NBMFHMHBAOC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class LANEENJIOGI
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<NBJBDKMDDDH> HPMPBOLABGG;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x749E660", Offset = "0x749DA60", VA = "0x18749E660")]
	public static bool FMOEAFIKFLJ(this EDHEFFCJEMG OPFMLMPJIBL, NBJBDKMDDDH HHDEACJJCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x749E5E0", Offset = "0x749D9E0", VA = "0x18749E5E0")]
	public static bool AGIKGEIFLFN(this EDHEFFCJEMG OPFMLMPJIBL, NBJBDKMDDDH HHDEACJJCJK, INGNDDFNBAI BAOEMGBIIMD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface GHOOGDIADPO
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool IHBEBOKHKJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool FIIJMJDEJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool LAHMFBPPMNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool DDFJPOPPAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool BMIKNODKJDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool GLGBMECIPAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool JCEKHIPFLFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool BNCBMGOIOHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool HFJANOCPDFA
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool JDGMIIPBIBA
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool GDGPJFOMGCA
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool MNKBJJLFOIA
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> DGJEBAJEEGP
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	GMHIEBHGFKG OPLDNNADNHL
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface EKPHGGICMFB : GHOOGDIADPO, HODFDNMOLBN, IHGPNFEFDLG<MGDGCEENFHJ>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string OHMPJEECBMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	NBJBDKMDDDH LLNDAJFALBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) KFHJHLIFIAI<T>(MGDGCEENFHJ EDKLJJPLIII) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum MGDGCEENFHJ
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
internal class PDKFIMBBKEB : EKPHGGICMFB, GHOOGDIADPO, HODFDNMOLBN, IHGPNFEFDLG<MGDGCEENFHJ>
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly MFAGKALAMJP GDFCPLOCLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	internal readonly ADHIDNPLEDB HFDAABFHOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private string? BBMOAPIPABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private string? NCAHEFLBKNO;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool HJDCIDFEONA
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x74A10C0", Offset = "0x74A04C0", VA = "0x1874A10C0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool BIILJDHKJNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x74A1770", Offset = "0x74A0B70", VA = "0x1874A1770", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool HFHLNDHPICJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x74A18B0", Offset = "0x74A0CB0", VA = "0x1874A18B0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool OKMPGHDDOJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x74A1720", Offset = "0x74A0B20", VA = "0x1874A1720", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool IHILJJBNDLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x74A1680", Offset = "0x74A0A80", VA = "0x1874A1680", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool HAGGEFCFBIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x74A1C90", Offset = "0x74A1090", VA = "0x1874A1C90", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public NBJBDKMDDDH LLNDAJFALBH
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xB92390", Offset = "0xB91790", VA = "0x180B92390", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(NBJBDKMDDDH);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8AA6B0", Offset = "0x8A9AB0", VA = "0x1808AA6B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string HJBOFMFLBEE
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x74A1990", Offset = "0x74A0D90", VA = "0x1874A1990", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x74A16D0", Offset = "0x74A0AD0", VA = "0x1874A16D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string OHMPJEECBMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x74A1990", Offset = "0x74A0D90", VA = "0x1874A1990", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool AMDBCPKBDKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x979FA0", Offset = "0x9793A0", VA = "0x180979FA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x979B50", Offset = "0x978F50", VA = "0x180979B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool IHBEBOKHKJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x74A1810", Offset = "0x74A0C10", VA = "0x1874A1810", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public GMHIEBHGFKG OPLDNNADNHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x74A2B90", Offset = "0x74A1F90", VA = "0x1874A2B90", Slot = "20")]
		get
		{
			return default(GMHIEBHGFKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool FIIJMJDEJNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x74A1C40", Offset = "0x74A1040", VA = "0x1874A1C40", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool LAHMFBPPMNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x74A12F0", Offset = "0x74A06F0", VA = "0x1874A12F0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool DDFJPOPPAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x74A17C0", Offset = "0x74A0BC0", VA = "0x1874A17C0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool BMIKNODKJDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x74A1CE0", Offset = "0x74A10E0", VA = "0x1874A1CE0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool GLGBMECIPAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x74A1D80", Offset = "0x74A1180", VA = "0x1874A1D80", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool JCEKHIPFLFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x74A11C0", Offset = "0x74A05C0", VA = "0x1874A11C0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool BNCBMGOIOHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x74A1340", Offset = "0x74A0740", VA = "0x1874A1340", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool HFJANOCPDFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x74A1410", Offset = "0x74A0810", VA = "0x1874A1410", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> DGJEBAJEEGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x74A1BE0", Offset = "0x74A0FE0", VA = "0x1874A1BE0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool GKAJBFACIFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x74A10C0", Offset = "0x74A04C0", VA = "0x1874A10C0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool CBBKBEBEMKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x74A1680", Offset = "0x74A0A80", VA = "0x1874A1680", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool PKFFILNBOEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x74A1770", Offset = "0x74A0B70", VA = "0x1874A1770", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool JDGMIIPBIBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x74A2750", Offset = "0x74A1B50", VA = "0x1874A2750", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool GDGPJFOMGCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x74A1860", Offset = "0x74A0C60", VA = "0x1874A1860", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool NNJNLDDMMEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x74A18B0", Offset = "0x74A0CB0", VA = "0x1874A18B0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool MNKBJJLFOIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x74A1630", Offset = "0x74A0A30", VA = "0x1874A1630", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool MEKONMHDOBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x74A1720", Offset = "0x74A0B20", VA = "0x1874A1720", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool KIKJFNOFKCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x74A1C90", Offset = "0x74A1090", VA = "0x1874A1C90", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event EHDFGIAKIBJ<MGDGCEENFHJ> KPJDAFHFICP
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x74A1460", Offset = "0x74A0860", VA = "0x1874A1460", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x74A1110", Offset = "0x74A0510", VA = "0x1874A1110", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x309B6B0", Offset = "0x309AAB0", VA = "0x18309B6B0", Slot = "6")]
	public (bool, T?) KFHJHLIFIAI<T>(MGDGCEENFHJ EDKLJJPLIII) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x309B650", Offset = "0x309AA50", VA = "0x18309B650")]
	public PDKFIMBBKEB GPBIMCLKEBJ<T>(MGDGCEENFHJ EDKLJJPLIII, bool EIKFNHMEICJ, T PFKKDHPJFEH) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x74A30E0", Offset = "0x74A24E0", VA = "0x1874A30E0")]
	public PDKFIMBBKEB(NBJBDKMDDDH HHDEACJJCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x74A30C0", Offset = "0x74A24C0", VA = "0x1874A30C0")]
	public PDKFIMBBKEB(NBJBDKMDDDH HHDEACJJCJK, [Optional] string? BBMOAPIPABG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x74A3100", Offset = "0x74A2500", VA = "0x1874A3100")]
	public PDKFIMBBKEB(PDKFIMBBKEB ILFKIGKEAKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x74A2F60", Offset = "0x74A2360", VA = "0x1874A2F60")]
	internal PDKFIMBBKEB(NBJBDKMDDDH KCFGFGADFGI, [Optional] string? BBMOAPIPABG, [Optional] PDKFIMBBKEB? ILFKIGKEAKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x74A1390", Offset = "0x74A0790", VA = "0x1874A1390")]
	public static EHCABBJHMEK EFEGMMFPNNJ(MGDGCEENFHJ EDKLJJPLIII)
	{
		return default(EHCABBJHMEK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x74A1510", Offset = "0x74A0910", VA = "0x1874A1510")]
	public void EOILBPMBNHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x74A2BE0", Offset = "0x74A1FE0", VA = "0x1874A2BE0")]
	internal PDKFIMBBKEB PLIEMCHILBH(PDKFIMBBKEB PHALIOJEGLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x74A27A0", Offset = "0x74A1BA0", VA = "0x1874A27A0")]
	internal IReadOnlyCollection<MGDGCEENFHJ> OHDKAOHEEPM(PDKFIMBBKEB ILFKIGKEAKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x74A1210", Offset = "0x74A0610", VA = "0x1874A1210")]
	public bool DGGOPPOHIIM(MGDGCEENFHJ EDKLJJPLIII, bool EIKFNHMEICJ, string ACLGKCGOFBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x74A1530", Offset = "0x74A0930", VA = "0x1874A1530")]
	public (bool, string) EPJHONDAIEL(MGDGCEENFHJ EDKLJJPLIII)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x74A1D30", Offset = "0x74A1130", VA = "0x1874A1D30")]
	internal void NAGNCBIJJLC(MGDGCEENFHJ EDKLJJPLIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x74A19E0", Offset = "0x74A0DE0", VA = "0x1874A19E0")]
	public DLLBGJJAOEF LDHBDKANAPG(Func<NBJBDKMDDDH, Guid> BKLIICLPGLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x74A1DD0", Offset = "0x74A11D0", VA = "0x1874A1DD0")]
	public void OFDLIDFKJLN(DLLBGJJAOEF CPDGGKJEPPI, Func<Guid, NBJBDKMDDDH> BOGINHAJJID, [Optional] NBJBDKMDDDH? GIKEOJDFLDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x74A1900", Offset = "0x74A0D00", VA = "0x1874A1900")]
	[CompilerGenerated]
	private void KIDEBNPJDHL(MGDGCEENFHJ LFHJABCBJIE, DNGFGHKFFNP IMPIKNOMMFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class FNNFGKGCAPI : DDPNAFCINMD, BMECELABAGA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class HJCAEOLCADM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public PDKFIMBBKEB newRole;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public HJCAEOLCADM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x749DCE0", Offset = "0x749D0E0", VA = "0x18749DCE0")]
		internal bool MGELNFCLOPB(PDKFIMBBKEB rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class EDBFEKHAPEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public NBJBDKMDDDH roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public EDBFEKHAPEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7496FA0", Offset = "0x74963A0", VA = "0x187496FA0")]
		internal bool IAFGMFLLADD(NBJBDKMDDDH r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct BLAILMEKHDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public FNNFGKGCAPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public CEGBHMDDAMC roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private TaskAwaiter<APPBHCMHGAN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7495AA0", Offset = "0x7494EA0", VA = "0x187495AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7496110", Offset = "0x7495510", VA = "0x187496110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class EJAFGANKNOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public EJAFGANKNOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x74970D0", Offset = "0x74964D0", VA = "0x1874970D0")]
		internal void OHFAMPFNECP(DLLBGJJAOEF r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7496FB0", Offset = "0x74963B0", VA = "0x187496FB0")]
		internal void FFHKDPFEEFL(DLLBGJJAOEF r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct PLBPONKJOOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public CEGBHMDDAMC roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class PIJGLEKDHBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Func<DLLBGJJAOEF, DNGFGHKFFNP> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public PIJGLEKDHBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x74A31F0", Offset = "0x74A25F0", VA = "0x1874A31F0")]
		internal void LFGBHLPFNCD(DLLBGJJAOEF r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x74A31C0", Offset = "0x74A25C0", VA = "0x1874A31C0")]
		internal void CPPAGFLJFGH(DLLBGJJAOEF r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x74A3190", Offset = "0x74A2590", VA = "0x1874A3190")]
		internal void CINIBDDNIDH(DLLBGJJAOEF r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class HKIALHFIHEN<T> where T : notnull
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
			public HKIALHFIHEN<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private TaskAwaiter<APPBHCMHGAN> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x38B4F80", Offset = "0x38B4380", VA = "0x1838B4F80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x8E9810", Offset = "0x8E8C10", VA = "0x1808E9810", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public MGDGCEENFHJ rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public NBJBDKMDDDH accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public EHCABBJHMEK recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public FNNFGKGCAPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public HKIALHFIHEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x415E700", Offset = "0x415DB00", VA = "0x18415E700")]
		[AsyncStateMachine(typeof(HKIALHFIHEN<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void AILMMGBGONC()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct KPKKHOGKEMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public IReadOnlyList<MALIBJBLOIM> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct OIFEGPCMEEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public OEGMAOCHMJG rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public CEGBHMDDAMC roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public IReadOnlyDictionary<NBJBDKMDDDH, PDKFIMBBKEB> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public MBKGHNEMCHF debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x74A0200", Offset = "0x749F600", VA = "0x1874A0200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x74A0D20", Offset = "0x74A0120", VA = "0x1874A0D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly OEGMAOCHMJG GFMFJKKBDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly HDAOPIPEJAM GKLAAMIGNGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly MBKGHNEMCHF GIHKDNFKCLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly Dictionary<int, PDKFIMBBKEB> KAJHIHBNJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	internal readonly Dictionary<NBJBDKMDDDH, PDKFIMBBKEB> HHMNKAGAOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	internal readonly Dictionary<NBJBDKMDDDH, PDKFIMBBKEB> LGMCFIAIEHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	internal readonly List<PDKFIMBBKEB> ADAONOMLLMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private bool KDNCOIGMEKH;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static readonly MGDGCEENFHJ[] NMOBJIJHGKH;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public KANFKGFBALN IGIDBNGLCJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<EKPHGGICMFB> NMPGELEOPMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7498430", Offset = "0x7497830", VA = "0x187498430", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event OEBDCPBNGCD CLNNBECEALP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7498280", Offset = "0x7497680", VA = "0x187498280", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x749B2E0", Offset = "0x749A6E0", VA = "0x18749B2E0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7499B80", Offset = "0x7498F80", VA = "0x187499B80")]
	[GOEIKLHOLGG.MKEGAHCPJHM]
	internal static void GIDGJLHOKMO(MCLDCOGKKML FKHGLAMHEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x749CA10", Offset = "0x749BE10", VA = "0x18749CA10")]
	[UnityEngine.Scripting.Preserve]
	internal FNNFGKGCAPI([NDMEANGLJKD(null)] OEGMAOCHMJG KEDHLFLMAIO, [NDMEANGLJKD(null)] HDAOPIPEJAM BFKGJCKJCFG, [NDMEANGLJKD(null)] MBKGHNEMCHF GIHKDNFKCLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7498320", Offset = "0x7497720", VA = "0x187498320", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x749BA60", Offset = "0x749AE60", VA = "0x18749BA60")]
	private void OJODJOONBBK(IEnumerable<PDKFIMBBKEB> MFGGFKMGEFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x749B650", Offset = "0x749AA50", VA = "0x18749B650", Slot = "12")]
	public bool NDMAMKALJJC(EDHEFFCJEMG FFANAAGKHEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x749C830", Offset = "0x749BC30", VA = "0x18749C830")]
	private void PPMEPNPAFHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x749C650", Offset = "0x749BA50", VA = "0x18749C650")]
	private void PDCCBNFNFMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x749B390", Offset = "0x749A790", VA = "0x18749B390", Slot = "10")]
	public IReadOnlyList<EKPHGGICMFB> MHPCDABNJCI(bool DKELHBGGILE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x749B070", Offset = "0x749A470", VA = "0x18749B070", Slot = "11")]
	public EKPHGGICMFB IGBLIMIOHOA(EDHEFFCJEMG FFANAAGKHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x74971B0", Offset = "0x74965B0", VA = "0x1874971B0")]
	private NBJBDKMDDDH BGLOANNACII(EDHEFFCJEMG FFANAAGKHEI)
	{
		return default(NBJBDKMDDDH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7498480", Offset = "0x7497880", VA = "0x187498480", Slot = "14")]
	public bool FDAHCDOCLAH(EDHEFFCJEMG MGMGNPMLOOG, NBJBDKMDDDH HHDEACJJCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x749B530", Offset = "0x749A930", VA = "0x18749B530", Slot = "15")]
	public EKPHGGICMFB MOCDBALJOJC(NBJBDKMDDDH HHDEACJJCJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x749A250", Offset = "0x7499650", VA = "0x18749A250")]
	private static bool GOLIEMCKLPN(OMBGPMHJNBK KIPIHLGNLLK, NBJBDKMDDDH HHDEACJJCJK, [Out] DLLBGJJAOEF? JKMBNDPIABC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x749C560", Offset = "0x749B960", VA = "0x18749C560")]
	private static void OKNMJFAADPB(OMBGPMHJNBK KIPIHLGNLLK, Action<DLLBGJJAOEF> CGONKDJLIFA, NBJBDKMDDDH NABAMJAGGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x749C2D0", Offset = "0x749B6D0", VA = "0x18749C2D0")]
	private static void OKNMJFAADPB(OMBGPMHJNBK KIPIHLGNLLK, Action<DLLBGJJAOEF> CGONKDJLIFA, Predicate<NBJBDKMDDDH> PFFHGEDALHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x749A1E0", Offset = "0x74995E0", VA = "0x18749A1E0")]
	private void GNFKOANHHBD(EDHEFFCJEMG FFANAAGKHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x749B410", Offset = "0x749A810", VA = "0x18749B410", Slot = "4")]
	[AsyncStateMachine(typeof(BLAILMEKHDE))]
	public Task MNMPPGHLIOH([CanBeNull] CEGBHMDDAMC FKLCHFCGCOM, CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
	public void DBFLPNIEBCH(CEGBHMDDAMC FKLCHFCGCOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x749B720", Offset = "0x749AB20", VA = "0x18749B720")]
	private void OEBMMOADLCN(OMBGPMHJNBK FPGKMMEDKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x74974B0", Offset = "0x74968B0", VA = "0x1874974B0")]
	internal static string CBKJPJDHNOH(OEGMAOCHMJG GFMFJKKBDCM, CEGBHMDDAMC FKLCHFCGCOM, IReadOnlyDictionary<NBJBDKMDDDH, PDKFIMBBKEB> HHMNKAGAOOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7498950", Offset = "0x7497D50", VA = "0x187498950")]
	private static void FLPALPMOKHN(CEGBHMDDAMC FKLCHFCGCOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x749AD20", Offset = "0x749A120", VA = "0x18749AD20")]
	private static void HIEBLOEPNEO(OMBGPMHJNBK KLCLNNMBIJN, IReadOnlyDictionary<NBJBDKMDDDH, PDKFIMBBKEB> HHMNKAGAOOJ, StringBuilder DPMHLMILHBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7499780", Offset = "0x7498B80", VA = "0x187499780")]
	private static bool GAEEGGLEMGF(string CJDEPHNPALM, [Out] Guid DDLDBNOHMEE, [Out] NBJBDKMDDDH HHDEACJJCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x74977C0", Offset = "0x7496BC0", VA = "0x1874977C0")]
	private static void DCEIABDENDH(CEGBHMDDAMC FKLCHFCGCOM, StringBuilder DPMHLMILHBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2E9FF90", Offset = "0x2E9F390", VA = "0x182E9FF90", Slot = "16")]
	public bool HHLBDBFLHDH<T>(NBJBDKMDDDH HHDEACJJCJK, MGDGCEENFHJ EDKLJJPLIII, bool EIKFNHMEICJ, T IDJEKAFFOBD, [Optional] Action KMENECMAGKO) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x749B5D0", Offset = "0x749A9D0", VA = "0x18749B5D0", Slot = "17")]
	public string NDJCLPFIKMN(MGDGCEENFHJ EDKLJJPLIII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7499FE0", Offset = "0x74993E0", VA = "0x187499FE0")]
	private void GKNLFNJFLMK(NBJBDKMDDDH HHDEACJJCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x749B2C0", Offset = "0x749A6C0", VA = "0x18749B2C0")]
	private bool IONEKDIGOAB(EDHEFFCJEMG FFANAAGKHEI, NBJBDKMDDDH HHDEACJJCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7498610", Offset = "0x7497A10", VA = "0x187498610")]
	internal PDKFIMBBKEB FDIGKDLELKO(EDHEFFCJEMG FFANAAGKHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x749B380", Offset = "0x749A780", VA = "0x18749B380", Slot = "13")]
	public IReadOnlyList<EKPHGGICMFB> LLCGHOKJDLI(EDHEFFCJEMG FFANAAGKHEI, bool IJLJMFHMOMN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7497280", Offset = "0x7496680", VA = "0x187497280")]
	internal IReadOnlyList<PDKFIMBBKEB> BHNBGJELONG(EDHEFFCJEMG FFANAAGKHEI, bool IJLJMFHMOMN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x749A580", Offset = "0x7499980", VA = "0x18749A580")]
	private void GPLHIGDPEOF(APPBHCMHGAN JODHFHHPDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7499890", Offset = "0x7498C90", VA = "0x187499890")]
	private static bool GCCHFAKFNDF(PDKFIMBBKEB BKJMEJCJABK, IReadOnlyDictionary<NBJBDKMDDDH, PDKFIMBBKEB> HHMNKAGAOOJ, [Out] IReadOnlyList<MGDGCEENFHJ> GGFBDDOLPGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x749B180", Offset = "0x749A580", VA = "0x18749B180")]
	[AsyncStateMachine(typeof(OIFEGPCMEEA))]
	private static Task IIICCFDAPAL(OEGMAOCHMJG GFMFJKKBDCM, CEGBHMDDAMC FKLCHFCGCOM, IReadOnlyDictionary<NBJBDKMDDDH, PDKFIMBBKEB> HHMNKAGAOOJ, MBKGHNEMCHF GIHKDNFKCLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7499D40", Offset = "0x7499140", VA = "0x187499D40")]
	[CompilerGenerated]
	internal static void GKKEDPJDNGA(Func<DLLBGJJAOEF, DNGFGHKFFNP> AJHAAIMGDJC, PLBPONKJOOP P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7497F00", Offset = "0x7497300", VA = "0x187497F00")]
	[CompilerGenerated]
	internal static bool DHAHMAJOCMD(NBJBDKMDDDH HHDEACJJCJK, MGDGCEENFHJ EDKLJJPLIII, [Out] MALIBJBLOIM EOFFPJOHKAL, KPKKHOGKEMN P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface IEIFIGFBLIG
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KPLMEPIHKPH(EDHEFFCJEMG MCLFFIMJBAN, EDHEFFCJEMG MDPNOEEHIAE, IEnumerable<EDHEFFCJEMG> OCPKBPONOBJ, [Out] GMHIEBHGFKG AKIJJKECDKI, [Out] OADFGEDKLFP CKGDCDPFAGN);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string CFBGNGPHOAH(OADFGEDKLFP HPAIJPGHEHI);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public enum OADFGEDKLFP : byte
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
internal class CGCGNKPLHNG : IEIFIGFBLIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly BMECELABAGA EBHPHDNBJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly EECPEIOBAAB NOPBCMGPGCJ;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x8AA360", Offset = "0x8A9760", VA = "0x1808AA360")]
	[RecRoom.NoEngine.Common.Preserve]
	public CGCGNKPLHNG([NDMEANGLJKD(null)] BMECELABAGA PKGNDGGMGND, [NDMEANGLJKD(null)] EECPEIOBAAB GGPCKECDLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7496370", Offset = "0x7495770", VA = "0x187496370")]
	private static KPOIKBOPMCK? MNGLNPBDEPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7496270", Offset = "0x7495670", VA = "0x187496270", Slot = "4")]
	public bool KPLMEPIHKPH(EDHEFFCJEMG MCLFFIMJBAN, EDHEFFCJEMG MDPNOEEHIAE, IEnumerable<EDHEFFCJEMG> OCPKBPONOBJ, [Out] GMHIEBHGFKG AKIJJKECDKI, [Out] OADFGEDKLFP CKGDCDPFAGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7496170", Offset = "0x7495570", VA = "0x187496170", Slot = "5")]
	public string CFBGNGPHOAH(OADFGEDKLFP HPAIJPGHEHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x74963B0", Offset = "0x74957B0", VA = "0x1874963B0")]
	internal bool MOKBLMEIDFI(EDHEFFCJEMG MCLFFIMJBAN, EDHEFFCJEMG MDPNOEEHIAE, IEnumerable<EDHEFFCJEMG> OCPKBPONOBJ, INGNDDFNBAI BAOEMGBIIMD, KPOIKBOPMCK? IJFMDJLIHBO, [Out] GMHIEBHGFKG AKIJJKECDKI, [Out] OADFGEDKLFP CKGDCDPFAGN)
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
