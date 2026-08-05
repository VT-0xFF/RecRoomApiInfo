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
		[Cpp2IlInjected.Address(RVA = "0x8BF5C0", Offset = "0x8BE7C0", VA = "0x1808BF5C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x73A7EA0", Offset = "0x73A70A0", VA = "0x1873A7EA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C0750", Offset = "0x8BF950", VA = "0x1808C0750")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C0790", Offset = "0x8BF990", VA = "0x1808C0790")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum LKLFEICLCLP
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
	public class _AssemblyIndex : JFBHLNBAFAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x73A9EB0", Offset = "0x73A90B0", VA = "0x1873A9EB0", Slot = "8")]
		public override void KGHJDOOILCG(KCABLKMBKAN registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x63262B0", Offset = "0x63254B0", VA = "0x1863262B0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void AIMPGOIKOCK<TPermission>(TPermission MAHJFBBKBBA);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void LNDMEOLJJBE(FGKAGKAJGLO BNPABODKIGA);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum GFACFOMIPPI
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface DOGJMDOLEAF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MJPMMEGNNPB
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool NHEJFFFNLJP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool KGAHLFGENKN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool IIHMGKIPDAO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool KAMIPPFNLOD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool LFPDJLFKNFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class IBBGCPKOJPE
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum AMOFGFOPKGH
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
	public static readonly Guid FOOINHAFOEO;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid HIGGGPKCCKL;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid FIBLEDOHMLE;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid KDKADAAEEOH;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid BIKLFMNJJEA;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid JFFODNDDPCG;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly EPNOFOKAAJB<EOLJMOIJNHG, Guid> NEPAIIBFDLL;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<EOLJMOIJNHG> KABJIPJHBJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x739EEF0", Offset = "0x739E0F0", VA = "0x18739EEF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x739ED80", Offset = "0x739DF80", VA = "0x18739ED80")]
	public static EOLJMOIJNHG CMDGHMMMCNB(Guid KGBBBBHDKAF)
	{
		return default(EOLJMOIJNHG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x739ECE0", Offset = "0x739DEE0", VA = "0x18739ECE0")]
	public static Guid CBABAGGFFAM(EOLJMOIJNHG GIGGOOENHKE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x739EC10", Offset = "0x739DE10", VA = "0x18739EC10")]
	public static bool AAHAHIIKDJB(EOLJMOIJNHG GIGGOOENHKE, [Out] Guid KGBBBBHDKAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x739EE10", Offset = "0x739E010", VA = "0x18739EE10")]
	public static bool EBKGMJNKHGM(Guid KGBBBBHDKAF, [Out] EOLJMOIJNHG GIGGOOENHKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x739EEB0", Offset = "0x739E0B0", VA = "0x18739EEB0")]
	public static EOLJMOIJNHG HLMIGLEOCBF(EOLJMOIJNHG GIGGOOENHKE)
	{
		return default(EOLJMOIJNHG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x739EF60", Offset = "0x739E160", VA = "0x18739EF60")]
	public static AMOFGFOPKGH MGKODPLKEOB(EOLJMOIJNHG MAJOMFJCFCG)
	{
		return default(AMOFGFOPKGH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x739ECA0", Offset = "0x739DEA0", VA = "0x18739ECA0")]
	internal static EOLJMOIJNHG BJHEEBLNAPA(AMOFGFOPKGH FAMMNJHOPBC)
	{
		return default(EOLJMOIJNHG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PGFCMLNAKMD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	KLKKMFDABKH LELGBPNPOIO
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<EIBGGANJLCB> BOJMIKCFEDD
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event LNDMEOLJJBE EHCNCHOAPPD;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<EIBGGANJLCB> CFFEHMFBBGN(bool HCIABMPGJAL = false);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EIBGGANJLCB PPLGAIKPGLG(FGKAGKAJGLO BNPABODKIGA);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CJFAFMKMBAN(FGKAGKAJGLO BNPABODKIGA);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<EIBGGANJLCB> EGLJCLFEKIE(FGKAGKAJGLO BNPABODKIGA, bool LEDIBADGCPB = false);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool DCLLMFKBOGM(FGKAGKAJGLO HOPHAMFONEC, EOLJMOIJNHG GIGGOOENHKE);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	EIBGGANJLCB DAJENIBFLJH(EOLJMOIJNHG GIGGOOENHKE);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool CJJFEHGPIDO<T>(EOLJMOIJNHG GIGGOOENHKE, FBGGAFJKEHM MAHJFBBKBBA, bool JLIHONEDFAM, T LFMCCJGKEKP, [Optional] Action ODCCNBNOOPG) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string FPBOFFBBCBJ(FBGGAFJKEHM MAHJFBBKBBA);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface OLKMCJMOEHB
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task LLLOOPIFHAF(IEALNJAENAA AICAHIPDPHC, CancellationToken DDNLBFLLCLM);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CNIMKPADKHK(IEALNJAENAA AICAHIPDPHC);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface NJGDEEACOIG
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	FGKAGKAJGLO HPAIBJDKOCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	GIJAGOPFLLM OHENJOCPHEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	PKKIPDKFKKJ LFPJPIBMGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<NDMPOFFINGL> FHALBGLHBJE;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action CJHGDKEANLB;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EOLJMOIJNHG OBFKKBKHBFD(FGKAGKAJGLO BNPABODKIGA);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<NDMPOFFINGL> NCOAIDBEOKP(CancellationToken DDNLBFLLCLM);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task POEFCBKHOIO(long MMNCPOOFGEF, IReadOnlyList<NANLIBHCKMH> EAPAGPCBMPJ);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task HCDLFOGMJKN(long MMNCPOOFGEF, long JHDHANNEHLK, IReadOnlyList<NANLIBHCKMH> EAPAGPCBMPJ);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<FGKAGKAJGLO> EIGIBBBCKLO();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class IKJLJLIGBNE
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x739F300", Offset = "0x739E500", VA = "0x18739F300")]
	public static EOLJMOIJNHG MHGJGPGOHAH(this NJGDEEACOIG MJNIDNFFMGK)
	{
		return default(EOLJMOIJNHG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface LKAGFFBGCGP<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string LDCEGGNLOJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event AIMPGOIKOCK<TPermission> OPDEJLFOGML;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal abstract class FDCDPHNGBFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal object? HJGGIPEOGDE;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? DOGNIHHLFCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x739DAA0", Offset = "0x739CCA0", VA = "0x18739DAA0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x739D9A0", Offset = "0x739CBA0", VA = "0x18739D9A0")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x739DB70", Offset = "0x739CD70", VA = "0x18739DB70")]
	protected FDCDPHNGBFF(object? PBOKLMCEELI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool CHLIJLINCNL(object? JECHHBGMFLN);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class CAECHDPAOPM<T> : FDCDPHNGBFF where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> BEGOEBAKHOO;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T GOGBANOMEKC
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x55E8630", Offset = "0x55E7830", VA = "0x1855E8630")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x55E8B90", Offset = "0x55E7D90", VA = "0x1855E8B90", Slot = "4")]
	public override bool CHLIJLINCNL(object? JECHHBGMFLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x55E9110", Offset = "0x55E8310", VA = "0x1855E9110")]
	public bool NFBOOCGELDI(T MAAAAJAFNOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x55E9590", Offset = "0x55E8790", VA = "0x1855E9590")]
	public CAECHDPAOPM(T IIGPKDCCLGH, IEqualityComparer<T> BEGOEBAKHOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class JLLHLAHNAEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<FBGGAFJKEHM, bool> HCHEPILGPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<FBGGAFJKEHM, FDCDPHNGBFF> LIDLGGPECJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly OGBAJAONPOD DECMIHKBAMM;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x73A1990", Offset = "0x73A0B90", VA = "0x1873A1990")]
	public JLLHLAHNAEO(OGBAJAONPOD DECMIHKBAMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x73A1920", Offset = "0x73A0B20", VA = "0x1873A1920")]
	public bool LPIPLJKLMHK(FBGGAFJKEHM MAHJFBBKBBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2E7DEE0", Offset = "0x2E7D0E0", VA = "0x182E7DEE0")]
	public bool HODBIEFPCFC<T>(FBGGAFJKEHM MAHJFBBKBBA, bool JLIHONEDFAM, T JECHHBGMFLN) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2E7D9E0", Offset = "0x2E7CBE0", VA = "0x182E7D9E0")]
	public (bool, T?) CBHMKEOCPIO<T>(FBGGAFJKEHM MAHJFBBKBBA) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x73A1770", Offset = "0x73A0970", VA = "0x1873A1770")]
	public bool HODBIEFPCFC(FBGGAFJKEHM MAHJFBBKBBA, bool JLIHONEDFAM, object JECHHBGMFLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x73A13F0", Offset = "0x73A05F0", VA = "0x1873A13F0")]
	public (bool, object) CBHMKEOCPIO(FBGGAFJKEHM MAHJFBBKBBA)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2E7DE80", Offset = "0x2E7D080", VA = "0x182E7DE80")]
	private void GJLOEHMNGDN<T>(FBGGAFJKEHM MAHJFBBKBBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x73A1850", Offset = "0x73A0A50", VA = "0x1873A1850")]
	private FDCDPHNGBFF IFADBPICHFJ(FBGGAFJKEHM MAHJFBBKBBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x73A1580", Offset = "0x73A0780", VA = "0x1873A1580")]
	public void HDDIBIFGPCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class CONFIDPBGBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string LIBEHGHEMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type GCENHPABJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly AIOHNPOAODJ EEFJFKANMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly FBGGAFJKEHM KOBNJMDDHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public OFLCEBLNDBK NDKBDAAGEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NBIHHOHJNMH KJANDHDHDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public ODMDFHBDBCB JKHDHMJNAED;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x739C490", Offset = "0x739B690", VA = "0x18739C490")]
	public CONFIDPBGBL(Type EOBMCKAEOND, string DEJHKKHOJGG, FBGGAFJKEHM MAHJFBBKBBA, OFLCEBLNDBK KPPFMLCFDCC, NBIHHOHJNMH PKHJAIDMPEM, ODMDFHBDBCB ANHGJIAKGFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x739C390", Offset = "0x739B590", VA = "0x18739C390")]
	public object BHGFOGFGCBD(object? KDHPJMADEAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2C2D2D0", Offset = "0x2C2C4D0", VA = "0x182C2D2D0")]
	public void GJLOEHMNGDN<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x739C3E0", Offset = "0x739B5E0", VA = "0x18739C3E0")]
	public void GJLOEHMNGDN(Type LFFDEIMHLAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class ANFJEIFFADO<T> : CONFIDPBGBL where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate string MHBFCBHLPBF(T JECHHBGMFLN);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal delegate T HKBDONNCOAG(string? ELFPAFAPOEM, T IIGPKDCCLGH);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class IALIIJJPIOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public MHBFCBHLPBF serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HKBDONNCOAG parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public IALIIJJPIOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4100E80", Offset = "0x4100080", VA = "0x184100E80")]
		internal string IKGCEPPOOKO(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4100C70", Offset = "0x40FFE70", VA = "0x184100C70")]
		internal object AOBJFGIBDOD(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x43757E0", Offset = "0x43749E0", VA = "0x1843757E0")]
	public ANFJEIFFADO(FBGGAFJKEHM MAHJFBBKBBA, string DEJHKKHOJGG, [Optional] MHBFCBHLPBF? KPPFMLCFDCC, [Optional] HKBDONNCOAG? PKHJAIDMPEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x43749A0", Offset = "0x4373BA0", VA = "0x1843749A0")]
	private static object? GBKBNNNFJGC(HKBDONNCOAG? PKHJAIDMPEM, string? ELFPAFAPOEM, object? IIGPKDCCLGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4374FB0", Offset = "0x43741B0", VA = "0x184374FB0")]
	private static string LMOHAAKIFFE(MHBFCBHLPBF? OIPDABAACIP, object? JECHHBGMFLN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate string OFLCEBLNDBK(object? JECHHBGMFLN);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate object NBIHHOHJNMH(string? ELFPAFAPOEM, [Optional] object IIGPKDCCLGH);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal delegate FDCDPHNGBFF ODMDFHBDBCB();
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class OGBAJAONPOD
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class DNDLLAGBMLI : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static DNDLLAGBMLI FAKOKDPOOAM;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x739C8C0", Offset = "0x739BAC0", VA = "0x18739C8C0", Slot = "4")]
		public bool Equals(List<string> AKHPALIKFFK, List<string> PGLPHKNNCEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x739CA10", Offset = "0x739BC10", VA = "0x18739CA10", Slot = "5")]
		public int GetHashCode(List<string> JMJAOKJJFGJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public DNDLLAGBMLI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class CIEIJBPALKD : BIFHAHKOBKE<LKLFEICLCLP>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x739B9C0", Offset = "0x739ABC0", VA = "0x18739B9C0", Slot = "9")]
		public override string LMOHAAKIFFE(LKLFEICLCLP GJDJIDOLBAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x739BAB0", Offset = "0x739ACB0", VA = "0x18739BAB0", Slot = "10")]
		protected override bool MDILEJMKIOD(string GJDJIDOLBAE, [Out] LKLFEICLCLP JECHHBGMFLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x739BC80", Offset = "0x739AE80", VA = "0x18739BC80")]
		public CIEIJBPALKD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly PENGMLAJPFI FOJDMJAGPHF;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly CIEIJBPALKD ELHFFGDANFN;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<CONFIDPBGBL> HMOOGBFJEFJ;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<FBGGAFJKEHM> EGPIEGGADMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<FBGGAFJKEHM, CONFIDPBGBL> JGMBCMMAPAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x73A9430", Offset = "0x73A8630", VA = "0x1873A9430")]
	public OGBAJAONPOD([Optional] IList<CONFIDPBGBL>? GICIOEEOGOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x73A7F20", Offset = "0x73A7120", VA = "0x1873A7F20")]
	public CONFIDPBGBL DFGFIHCDOMA(FBGGAFJKEHM MAHJFBBKBBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface KLKKMFDABKH
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	EIBGGANJLCB ILILHEJHDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class GNLFDHHDPBL : KLKKMFDABKH
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static GNLFDHHDPBL DBBEGPNKMFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly IPPENIKMAPI OLENEKDFFJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<IPPENIKMAPI> CEKBANBKFNA;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public EIBGGANJLCB ILILHEJHDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x739EB00", Offset = "0x739DD00", VA = "0x18739EB00")]
	public GNLFDHHDPBL(IPPENIKMAPI EONCOEIMPMA, IReadOnlyList<IPPENIKMAPI> AEOFDFENGNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x739DC70", Offset = "0x739CE70", VA = "0x18739DC70")]
	private static GNLFDHHDPBL OGFANIAOCHI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class DLEGIJAPLLM
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<EOLJMOIJNHG> HEFAMDCEJKG;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x739C5C0", Offset = "0x739B7C0", VA = "0x18739C5C0")]
	public static bool BNLANNMFBFC(this FGKAGKAJGLO JDPNPMHABPM, EOLJMOIJNHG GIGGOOENHKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x739C6A0", Offset = "0x739B8A0", VA = "0x18739C6A0")]
	public static bool EJECJJHKBBJ(this FGKAGKAJGLO JDPNPMHABPM, EOLJMOIJNHG GIGGOOENHKE, PKKIPDKFKKJ PBGNGEFAIEF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface EEEAOBIEONG
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool PMAJHGNLEOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool EFJCBJEEHME
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool ICCDAADDNID
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool KMFMPGNJMHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool MDJPNEOLHMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool CEKHLOFEKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool POBELBEBDNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool ABPGIBPGGGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool LFJFKAHIIND
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool LGCPICELJIO
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool OIJJHIPAPPK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool IHIFDNOLHAB
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> OBBLHHFKNLM
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	LKLFEICLCLP FIPLLNJJNAG
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface EIBGGANJLCB : EEEAOBIEONG, DOGJMDOLEAF, LKAGFFBGCGP<FBGGAFJKEHM>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string MIOGKNMIEHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	EOLJMOIJNHG FFHCNPNFHJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) EAFCIIOBCGI<T>(FBGGAFJKEHM MAHJFBBKBBA) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum FBGGAFJKEHM
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
internal class IPPENIKMAPI : EIBGGANJLCB, EEEAOBIEONG, DOGJMDOLEAF, LKAGFFBGCGP<FBGGAFJKEHM>
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly OGBAJAONPOD OGBOACAKCEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	internal readonly JLLHLAHNAEO JFBBAGONDCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private string? EOMCDCLHCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private string? DIDMJPNCAEB;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool FFADOMPLBNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x739F450", Offset = "0x739E650", VA = "0x18739F450", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool MGLPLEJHIIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x739F6C0", Offset = "0x739E8C0", VA = "0x18739F6C0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool GAGGOPENGCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x739F3B0", Offset = "0x739E5B0", VA = "0x18739F3B0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool CMPLBNJHKEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x739F360", Offset = "0x739E560", VA = "0x18739F360", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool PBHANLAFBED
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x739F7D0", Offset = "0x739E9D0", VA = "0x18739F7D0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool AEBBJFKONND
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x739FFE0", Offset = "0x739F1E0", VA = "0x18739FFE0", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public EOLJMOIJNHG FFHCNPNFHJP
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xB325B0", Offset = "0xB317B0", VA = "0x180B325B0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(EOLJMOIJNHG);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x899F30", Offset = "0x899130", VA = "0x180899F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string LDCEGGNLOJA
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x73A0260", Offset = "0x739F460", VA = "0x1873A0260", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x739FBA0", Offset = "0x739EDA0", VA = "0x18739FBA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string MIOGKNMIEHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x73A0260", Offset = "0x739F460", VA = "0x1873A0260", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool LIEJEMBFHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9197E0", Offset = "0x9189E0", VA = "0x1809197E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9191C0", Offset = "0x9183C0", VA = "0x1809191C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool PMAJHGNLEOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x73A02B0", Offset = "0x739F4B0", VA = "0x1873A02B0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public LKLFEICLCLP FIPLLNJJNAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x739F400", Offset = "0x739E600", VA = "0x18739F400", Slot = "20")]
		get
		{
			return default(LKLFEICLCLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool EFJCBJEEHME
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x739F710", Offset = "0x739E910", VA = "0x18739F710", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool ICCDAADDNID
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x73A0210", Offset = "0x739F410", VA = "0x1873A0210", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool KMFMPGNJMHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x739F590", Offset = "0x739E790", VA = "0x18739F590", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool MDJPNEOLHMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x739F4A0", Offset = "0x739E6A0", VA = "0x18739F4A0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool CEKHLOFEKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x73A0C80", Offset = "0x739FE80", VA = "0x1873A0C80", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool POBELBEBDNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x739F820", Offset = "0x739EA20", VA = "0x18739F820", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool ABPGIBPGGGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x739F540", Offset = "0x739E740", VA = "0x18739F540", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool LFJFKAHIIND
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x73A01C0", Offset = "0x739F3C0", VA = "0x1873A01C0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> OBBLHHFKNLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x739F890", Offset = "0x739EA90", VA = "0x18739F890", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool HBHMOJPHMBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x739F450", Offset = "0x739E650", VA = "0x18739F450", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool BEIFPLNDPJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x739F7D0", Offset = "0x739E9D0", VA = "0x18739F7D0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool CMGNOGCEKNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x739F6C0", Offset = "0x739E8C0", VA = "0x18739F6C0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool LGCPICELJIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x739F4F0", Offset = "0x739E6F0", VA = "0x18739F4F0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool OIJJHIPAPPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x739F5E0", Offset = "0x739E7E0", VA = "0x18739F5E0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool ALAPHNINAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x739F3B0", Offset = "0x739E5B0", VA = "0x18739F3B0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool IHIFDNOLHAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x73A1010", Offset = "0x73A0210", VA = "0x1873A1010", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool JPANGFDCHHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x739F360", Offset = "0x739E560", VA = "0x18739F360", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool MGILBIENKGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x739FFE0", Offset = "0x739F1E0", VA = "0x18739FFE0", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event AIMPGOIKOCK<FBGGAFJKEHM> OPDEJLFOGML
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x739F8F0", Offset = "0x739EAF0", VA = "0x18739F8F0", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x73A0110", Offset = "0x739F310", VA = "0x1873A0110", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2E5DD60", Offset = "0x2E5CF60", VA = "0x182E5DD60", Slot = "6")]
	public (bool, T?) EAFCIIOBCGI<T>(FBGGAFJKEHM MAHJFBBKBBA) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2E5DD00", Offset = "0x2E5CF00", VA = "0x182E5DD00")]
	public IPPENIKMAPI APCPKGFMGKD<T>(FBGGAFJKEHM MAHJFBBKBBA, bool JLIHONEDFAM, T JECHHBGMFLN) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x73A11E0", Offset = "0x73A03E0", VA = "0x1873A11E0")]
	public IPPENIKMAPI(EOLJMOIJNHG GIGGOOENHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x73A1280", Offset = "0x73A0480", VA = "0x1873A1280")]
	public IPPENIKMAPI(EOLJMOIJNHG GIGGOOENHKE, [Optional] string? EOMCDCLHCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x73A1200", Offset = "0x73A0400", VA = "0x1873A1200")]
	public IPPENIKMAPI(IPPENIKMAPI ALFKPNCMMJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x73A12A0", Offset = "0x73A04A0", VA = "0x1873A12A0")]
	internal IPPENIKMAPI(EOLJMOIJNHG COFIPOCDOIM, [Optional] string? EOMCDCLHCAL, [Optional] IPPENIKMAPI? ALFKPNCMMJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x739F760", Offset = "0x739E960", VA = "0x18739F760")]
	public static AIOHNPOAODJ GFGBECNHLEB(FBGGAFJKEHM MAHJFBBKBBA)
	{
		return default(AIOHNPOAODJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x739F870", Offset = "0x739EA70", VA = "0x18739F870")]
	public void HDDIBIFGPCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x73A0D20", Offset = "0x739FF20", VA = "0x1873A0D20")]
	internal IPPENIKMAPI OKAPGKACKCL(IPPENIKMAPI IPPKBOLMGOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x739FBF0", Offset = "0x739EDF0", VA = "0x18739FBF0")]
	internal IReadOnlyCollection<FBGGAFJKEHM> JDGMIEOCEEP(IPPENIKMAPI ALFKPNCMMJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x73A0030", Offset = "0x739F230", VA = "0x1873A0030")]
	public bool LDLDMJCIPNB(FBGGAFJKEHM MAHJFBBKBBA, bool JLIHONEDFAM, string JMKFDEGEAHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x73A1060", Offset = "0x73A0260", VA = "0x1873A1060")]
	public (bool, string) PFHMHKFEILP(FBGGAFJKEHM MAHJFBBKBBA)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x73A0CD0", Offset = "0x739FED0", VA = "0x1873A0CD0")]
	internal void NOKOBHBJJBM(FBGGAFJKEHM MAHJFBBKBBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x739F9A0", Offset = "0x739EBA0", VA = "0x18739F9A0")]
	public GANPGJNDKAE ILLJFMKHBAL(Func<EOLJMOIJNHG, Guid> CGAALJJALMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x73A0300", Offset = "0x739F500", VA = "0x1873A0300")]
	public void NGKJJEJECBM(GANPGJNDKAE IJKPDFAOFCL, Func<Guid, EOLJMOIJNHG> OKDPJLFMMPP, [Optional] EOLJMOIJNHG? GCAPDMPBKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x739F630", Offset = "0x739E830", VA = "0x18739F630")]
	[CompilerGenerated]
	private void DELKIKJFGMN(FBGGAFJKEHM HDFKHOJCLHC, OPOIPKBABHK DFNOAEHBAIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class LCBHJGJGBIA : OLKMCJMOEHB, PGFCMLNAKMD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class DOMFOMFBNOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public IPPENIKMAPI newRole;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public DOMFOMFBNOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x739CDF0", Offset = "0x739BFF0", VA = "0x18739CDF0")]
		internal bool EFALKINGAME(IPPENIKMAPI rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class LGJIMHFDGKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public EOLJMOIJNHG roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public LGJIMHFDGKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x73A7630", Offset = "0x73A6830", VA = "0x1873A7630")]
		internal bool EMHJCOIIPKL(EOLJMOIJNHG r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct CNMKOFPFDGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public LCBHJGJGBIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public IEALNJAENAA roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private TaskAwaiter<NDMPOFFINGL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x739BCC0", Offset = "0x739AEC0", VA = "0x18739BCC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x739C330", Offset = "0x739B530", VA = "0x18739C330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class DNFLEOOIOMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public DNFLEOOIOMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x739CBF0", Offset = "0x739BDF0", VA = "0x18739CBF0")]
		internal void MGIGLJGCMFL(GANPGJNDKAE r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x739CCD0", Offset = "0x739BED0", VA = "0x18739CCD0")]
		internal void NBFDCNKFHCK(GANPGJNDKAE r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct MPLHNJBKFGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public IEALNJAENAA roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class DBFDFPIOKIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Func<GANPGJNDKAE, OPOIPKBABHK> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public DBFDFPIOKIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x739C560", Offset = "0x739B760", VA = "0x18739C560")]
		internal void EPAMOGHHHHE(GANPGJNDKAE r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x739C590", Offset = "0x739B790", VA = "0x18739C590")]
		internal void OOKMHIIAPJO(GANPGJNDKAE r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x739C530", Offset = "0x739B730", VA = "0x18739C530")]
		internal void BLLBEMIFPCL(GANPGJNDKAE r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class CPGAILJODMH<T> where T : notnull
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
			public CPGAILJODMH<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private TaskAwaiter<NDMPOFFINGL> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x3825C80", Offset = "0x3824E80", VA = "0x183825C80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x90BE20", Offset = "0x90B020", VA = "0x18090BE20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public FBGGAFJKEHM rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public EOLJMOIJNHG accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public AIOHNPOAODJ recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public LCBHJGJGBIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public CPGAILJODMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x58AA170", Offset = "0x58A9370", VA = "0x1858AA170")]
		[AsyncStateMachine(typeof(CPGAILJODMH<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void IIBIJCBBOAH()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct OLMMOGODEHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public IReadOnlyList<NANLIBHCKMH> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct ELOMEKMJGJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public NJGDEEACOIG rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public IEALNJAENAA roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public IReadOnlyDictionary<EOLJMOIJNHG, IPPENIKMAPI> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public PACHMFNGNKE debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x739CE20", Offset = "0x739C020", VA = "0x18739CE20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x739D940", Offset = "0x739CB40", VA = "0x18739D940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly NJGDEEACOIG MJNIDNFFMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly GNLFDHHDPBL PFPGMEOFJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly PACHMFNGNKE HIMGNMIHEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly Dictionary<int, IPPENIKMAPI> OOGBJKKMNCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	internal readonly Dictionary<EOLJMOIJNHG, IPPENIKMAPI> OCKCMADPOEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	internal readonly Dictionary<EOLJMOIJNHG, IPPENIKMAPI> HDAGFLFICMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	internal readonly List<IPPENIKMAPI> JNKFPMIFBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private bool NDFHEFHMGLA;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static readonly FBGGAFJKEHM[] EFOPKPDLFON;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public KLKKMFDABKH LELGBPNPOIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<EIBGGANJLCB> BOJMIKCFEDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x73A53E0", Offset = "0x73A45E0", VA = "0x1873A53E0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event LNDMEOLJJBE EHCNCHOAPPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x73A5B70", Offset = "0x73A4D70", VA = "0x1873A5B70", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x73A4330", Offset = "0x73A3530", VA = "0x1873A4330", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x73A3000", Offset = "0x73A2200", VA = "0x1873A3000")]
	[NPIOOMADHDK.EDMEHGENIAN]
	internal static void BMGOJHCGLFB(KHAIBIPGEJP BDIDKDEEDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x73A7370", Offset = "0x73A6570", VA = "0x1873A7370")]
	[UnityEngine.Scripting.Preserve]
	internal LCBHJGJGBIA([GEFLINBOFNF(null)] NJGDEEACOIG IBPOLNGADEC, [GEFLINBOFNF(null)] GNLFDHHDPBL NDEGBPJKKJH, [GEFLINBOFNF(null)] PACHMFNGNKE HIMGNMIHEHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x73A3630", Offset = "0x73A2830", VA = "0x1873A3630", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x73A4510", Offset = "0x73A3710", VA = "0x1873A4510")]
	private void HPHBKHDPPLB(IEnumerable<IPPENIKMAPI> BKNOHEIMGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x73A3300", Offset = "0x73A2500", VA = "0x1873A3300", Slot = "12")]
	public bool CJFAFMKMBAN(FGKAGKAJGLO BNPABODKIGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x73A33D0", Offset = "0x73A25D0", VA = "0x1873A33D0")]
	private void CJHGDKEANLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x73A6EB0", Offset = "0x73A60B0", VA = "0x1873A6EB0")]
	private void PLOHGKGHCGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x73A31B0", Offset = "0x73A23B0", VA = "0x1873A31B0", Slot = "10")]
	public IReadOnlyList<EIBGGANJLCB> CFFEHMFBBGN(bool HCIABMPGJAL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x73A7090", Offset = "0x73A6290", VA = "0x1873A7090", Slot = "11")]
	public EIBGGANJLCB PPLGAIKPGLG(FGKAGKAJGLO BNPABODKIGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x73A3230", Offset = "0x73A2430", VA = "0x1873A3230")]
	private EOLJMOIJNHG CHKEOLEJAEF(FGKAGKAJGLO BNPABODKIGA)
	{
		return default(EOLJMOIJNHG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x73A3480", Offset = "0x73A2680", VA = "0x1873A3480", Slot = "14")]
	public bool DCLLMFKBOGM(FGKAGKAJGLO HOPHAMFONEC, EOLJMOIJNHG GIGGOOENHKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x73A33E0", Offset = "0x73A25E0", VA = "0x1873A33E0", Slot = "15")]
	public EIBGGANJLCB DAJENIBFLJH(EOLJMOIJNHG GIGGOOENHKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x73A4D70", Offset = "0x73A3F70", VA = "0x1873A4D70")]
	private static bool IOFJAKMJFBB(CGNNIGIGIPK FAIGPFFBJJG, EOLJMOIJNHG GIGGOOENHKE, [Out] GANPGJNDKAE? DJEGMOOCOOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x73A66E0", Offset = "0x73A58E0", VA = "0x1873A66E0")]
	private static void NKJMNMCKLOM(CGNNIGIGIPK FAIGPFFBJJG, Action<GANPGJNDKAE> CLJBMGMAAPL, EOLJMOIJNHG KMGGJKONHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x73A67D0", Offset = "0x73A59D0", VA = "0x1873A67D0")]
	private static void NKJMNMCKLOM(CGNNIGIGIPK FAIGPFFBJJG, Action<GANPGJNDKAE> CLJBMGMAAPL, Predicate<EOLJMOIJNHG> OALFBDHCGHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x73A3F50", Offset = "0x73A3150", VA = "0x1873A3F50")]
	private void GIGEFOJJKDP(FGKAGKAJGLO BNPABODKIGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x73A6190", Offset = "0x73A5390", VA = "0x1873A6190", Slot = "4")]
	[AsyncStateMachine(typeof(CNMKOFPFDGF))]
	public Task LLLOOPIFHAF([CanBeNull] IEALNJAENAA AICAHIPDPHC, CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "5")]
	public void CNIMKPADKHK(IEALNJAENAA AICAHIPDPHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x73A50A0", Offset = "0x73A42A0", VA = "0x1873A50A0")]
	private void JHABGKMNMCE(CGNNIGIGIPK IABDPDPLCOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x73A1C40", Offset = "0x73A0E40", VA = "0x1873A1C40")]
	internal static string BEGAMJGFPFN(NJGDEEACOIG MJNIDNFFMGK, IEALNJAENAA AICAHIPDPHC, IReadOnlyDictionary<EOLJMOIJNHG, IPPENIKMAPI> OCKCMADPOEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x73A1F50", Offset = "0x73A1150", VA = "0x1873A1F50")]
	private static void BFIJPCEFJDO(IEALNJAENAA AICAHIPDPHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x73A2CB0", Offset = "0x73A1EB0", VA = "0x1873A2CB0")]
	private static void BJCPJOIKILK(CGNNIGIGIPK IFBONMBDJHG, IReadOnlyDictionary<EOLJMOIJNHG, IPPENIKMAPI> OCKCMADPOEH, StringBuilder AIBJEPBPLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x73A6A60", Offset = "0x73A5C60", VA = "0x1873A6A60")]
	private static bool OCDLMNAFKLC(string AOEKEODHNPI, [Out] Guid HLOAICDDIAI, [Out] EOLJMOIJNHG GIGGOOENHKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x73A5430", Offset = "0x73A4630", VA = "0x1873A5430")]
	private static void JMONLCMOGHI(IEALNJAENAA AICAHIPDPHC, StringBuilder AIBJEPBPLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2EEA1C0", Offset = "0x2EE93C0", VA = "0x182EEA1C0", Slot = "16")]
	public bool CJJFEHGPIDO<T>(EOLJMOIJNHG GIGGOOENHKE, FBGGAFJKEHM MAHJFBBKBBA, bool JLIHONEDFAM, T LFMCCJGKEKP, [Optional] Action ODCCNBNOOPG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x73A3EE0", Offset = "0x73A30E0", VA = "0x1873A3EE0", Slot = "17")]
	public string FPBOFFBBCBJ(FBGGAFJKEHM MAHJFBBKBBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x73A64E0", Offset = "0x73A56E0", VA = "0x1873A64E0")]
	private void NHOHPCEGCCJ(EOLJMOIJNHG GIGGOOENHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x73A3610", Offset = "0x73A2810", VA = "0x1873A3610")]
	private bool DILKLJCOMCL(FGKAGKAJGLO BNPABODKIGA, EOLJMOIJNHG GIGGOOENHKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x73A6B70", Offset = "0x73A5D70", VA = "0x1873A6B70")]
	internal IPPENIKMAPI PFMIPEKMADB(FGKAGKAJGLO BNPABODKIGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x73A3740", Offset = "0x73A2940", VA = "0x1873A3740", Slot = "13")]
	public IReadOnlyList<EIBGGANJLCB> EGLJCLFEKIE(FGKAGKAJGLO BNPABODKIGA, bool LEDIBADGCPB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x73A62B0", Offset = "0x73A54B0", VA = "0x1873A62B0")]
	internal IReadOnlyList<IPPENIKMAPI> MIBHPPGMAKA(FGKAGKAJGLO BNPABODKIGA, bool LEDIBADGCPB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x73A3750", Offset = "0x73A2950", VA = "0x1873A3750")]
	private void ELKGGCPLDLE(NDMPOFFINGL EFHMBMPDFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x73A5C10", Offset = "0x73A4E10", VA = "0x1873A5C10")]
	private static bool KOADDOBCNNG(IPPENIKMAPI DFCKAEHMBFF, IReadOnlyDictionary<EOLJMOIJNHG, IPPENIKMAPI> OCKCMADPOEH, [Out] IReadOnlyList<FBGGAFJKEHM> FCPDGPDHJAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x73A43D0", Offset = "0x73A35D0", VA = "0x1873A43D0")]
	[AsyncStateMachine(typeof(ELOMEKMJGJG))]
	private static Task HNFNOLCIPOF(NJGDEEACOIG MJNIDNFFMGK, IEALNJAENAA AICAHIPDPHC, IReadOnlyDictionary<EOLJMOIJNHG, IPPENIKMAPI> OCKCMADPOEH, PACHMFNGNKE HIMGNMIHEHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x73A5EF0", Offset = "0x73A50F0", VA = "0x1873A5EF0")]
	[CompilerGenerated]
	internal static void LLLJGCONKFO(Func<GANPGJNDKAE, OPOIPKBABHK> HDAEPFOFJBA, MPLHNJBKFGM P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x73A3FC0", Offset = "0x73A31C0", VA = "0x1873A3FC0")]
	[CompilerGenerated]
	internal static bool GMCKLJNPCAO(EOLJMOIJNHG GIGGOOENHKE, FBGGAFJKEHM MAHJFBBKBBA, [Out] NANLIBHCKMH BPPEFJJMKEE, OLMMOGODEHI P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface ELPIGFCGCBC
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LIKBDBEKGNA(FGKAGKAJGLO NJFIFBDGLNN, FGKAGKAJGLO ONAHEAIAJHN, IEnumerable<FGKAGKAJGLO> JEMPHOFDMOF, [Out] LKLFEICLCLP JONIEPOMAHM, [Out] LJPJFAHJPDE PGBODABPEGC);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string DEIOPNBBJDK(LJPJFAHJPDE BMLIANLGKOD);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public enum LJPJFAHJPDE : byte
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
internal class MKAFPFLEBLJ : ELPIGFCGCBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly PGFCMLNAKMD NNANAJCBOJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly ICANMDBLDAH GHDJFDNGKJK;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x8A2310", Offset = "0x8A1510", VA = "0x1808A2310")]
	[RecRoom.NoEngine.Common.Preserve]
	public MKAFPFLEBLJ([GEFLINBOFNF(null)] PGFCMLNAKMD HCIGMHNIJLH, [GEFLINBOFNF(null)] ICANMDBLDAH AIOAPBEOMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x73A7D60", Offset = "0x73A6F60", VA = "0x1873A7D60")]
	private static GKJCNNICHNE? KIPFMHDCJFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x73A7DA0", Offset = "0x73A6FA0", VA = "0x1873A7DA0", Slot = "4")]
	public bool LIKBDBEKGNA(FGKAGKAJGLO NJFIFBDGLNN, FGKAGKAJGLO ONAHEAIAJHN, IEnumerable<FGKAGKAJGLO> JEMPHOFDMOF, [Out] LKLFEICLCLP JONIEPOMAHM, [Out] LJPJFAHJPDE PGBODABPEGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x73A7640", Offset = "0x73A6840", VA = "0x1873A7640", Slot = "5")]
	public string DEIOPNBBJDK(LJPJFAHJPDE BMLIANLGKOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x73A7740", Offset = "0x73A6940", VA = "0x1873A7740")]
	internal bool IOGKKBJCLDN(FGKAGKAJGLO NJFIFBDGLNN, FGKAGKAJGLO ONAHEAIAJHN, IEnumerable<FGKAGKAJGLO> JEMPHOFDMOF, PKKIPDKFKKJ PBGNGEFAIEF, GKJCNNICHNE? PFBNCDJEJDK, [Out] LKLFEICLCLP JONIEPOMAHM, [Out] LJPJFAHJPDE PGBODABPEGC)
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
