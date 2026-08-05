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
		[Cpp2IlInjected.Address(RVA = "0x7E57E0", Offset = "0x7E49E0", VA = "0x1807E57E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x676F960", Offset = "0x676EB60", VA = "0x18676F960")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E5C40", Offset = "0x7E4E40", VA = "0x1807E5C40")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E5C80", Offset = "0x7E4E80", VA = "0x1807E5C80")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum FDIOABLDELB
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void NIPFKLPAPKN<TPermission>(TPermission ELOBMGDLLEE);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void HNGFJHINLEM(PFFLGDPBKDO DONKKIJPHLE);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum NNNBCMDHBJC
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface ANIPEKFAKAC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool HNNMKJKEDFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool CMOGAFEEJIP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool HHPJJMMGIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool EPPJOMEDDNM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool LLIAOIAGLBH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool MOPCIMMMHNK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class EODGBAGBEBM
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	public enum HMPOIMAFBGE
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
	public static readonly Guid CJBCONCPCEN;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid LBLMEBGEDDL;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid OPKPLAGJBID;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid PHCCLNNNNPN;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid EKEJFCLDGLH;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid GMGHOKJHOGE;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly IONEGOBNOLE<NBFABDGBKDO, Guid> IIMALPABPCJ;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<NBFABDGBKDO> ALHGDKMCCON
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x676AAC0", Offset = "0x6769CC0", VA = "0x18676AAC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x676AC20", Offset = "0x6769E20", VA = "0x18676AC20")]
	public static NBFABDGBKDO HIDIHEPJIGM(Guid OHJPHHKPEGL)
	{
		return default(NBFABDGBKDO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x676ADA0", Offset = "0x6769FA0", VA = "0x18676ADA0")]
	public static Guid NPMGAKENCEK(NBFABDGBKDO OOGLIFHBJHI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x676AA30", Offset = "0x6769C30", VA = "0x18676AA30")]
	public static bool AIGFCLNEMKK(NBFABDGBKDO OOGLIFHBJHI, [Out] Guid OHJPHHKPEGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x676AB40", Offset = "0x6769D40", VA = "0x18676AB40")]
	public static bool EOLJKGIACCJ(Guid OHJPHHKPEGL, [Out] NBFABDGBKDO OOGLIFHBJHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x676ACB0", Offset = "0x6769EB0", VA = "0x18676ACB0")]
	public static NBFABDGBKDO LAEEOPJCMCL(NBFABDGBKDO OOGLIFHBJHI)
	{
		return default(NBFABDGBKDO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x676ACF0", Offset = "0x6769EF0", VA = "0x18676ACF0")]
	public static HMPOIMAFBGE MJPBHKPCNLN(NBFABDGBKDO HMMMKGDNKHK)
	{
		return default(HMPOIMAFBGE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x676ABE0", Offset = "0x6769DE0", VA = "0x18676ABE0")]
	internal static NBFABDGBKDO GPCCFEJCAPI(HMPOIMAFBGE DKHPKIFOADO)
	{
		return default(NBFABDGBKDO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface EEDHGNDJMFD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	MNLHKGJECIE AHJJCOAOLGI
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<BPPLGOECEGD> EBIOKHKOBEB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event HNGFJHINLEM KICGOAPCMND;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<BPPLGOECEGD> BOLDFPIMGFI(bool IBELIHDOMPI = false);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BPPLGOECEGD GEKJIPNKKNI(PFFLGDPBKDO DONKKIJPHLE);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool EMIHGFHIIJE(PFFLGDPBKDO DONKKIJPHLE);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<BPPLGOECEGD> HONCLFPJEDJ(PFFLGDPBKDO DONKKIJPHLE, bool KELCNNPLGGG = false);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool EEMLOINNGNM(PFFLGDPBKDO GKIKKALGCJE, NBFABDGBKDO OOGLIFHBJHI);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "9")]
	BPPLGOECEGD FNECNMEHDBO(NBFABDGBKDO OOGLIFHBJHI);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool PEAOBBKENON<T>(NBFABDGBKDO OOGLIFHBJHI, GKBFAHAADAN ELOBMGDLLEE, bool LAOBIKOJBKK, T CIENKKNJAIC, [Optional] Action GNPNLJAJJIB) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GLKJIBBPGNO
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task ONJJBJLNBEM(KCOMFGNMNDO OMKGFBDCDEE, CancellationToken OBNOJDAGGOE);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KBEOKGGKGPN(KCOMFGNMNDO OMKGFBDCDEE);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CPBPEHOECKI
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	PFFLGDPBKDO OLLMLBOLBGM
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	ODILODLNFCL LGAIOGIGCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	KFGKPCFIHIN EKDOLMINGKA
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<EKBNBLNPNGF> JBKPFNPLGAG;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action PONKDHAPOFA;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NBFABDGBKDO FJKODCFLOOB(PFFLGDPBKDO DONKKIJPHLE);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<EKBNBLNPNGF> AJJEJDHFFLC(CancellationToken OBNOJDAGGOE);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task JBFHEKLAHBC(long NIPGINDOPCB, long NDIHJAHDLAI, IReadOnlyList<GHNLHFEJGHE> CALDHAFJLFK);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<PFFLGDPBKDO> OMNFJONOEDP();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class CAILJAKDAKP
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6763C30", Offset = "0x6762E30", VA = "0x186763C30")]
	public static NBFABDGBKDO MIFOHJMAGPK(this CPBPEHOECKI DEGKLDODJEI)
	{
		return default(NBFABDGBKDO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface KIDHBIIKMCI<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string PCBPAFFBLJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event NIPFKLPAPKN<TPermission> LCMEGKCJBFK;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class GLGKGIDADMG
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? PMFPCKCMFNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3A0", Offset = "0x7B95A0", VA = "0x1807BA3A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7BA400", Offset = "0x7B9600", VA = "0x1807BA400")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7C5FB0", Offset = "0x7C51B0", VA = "0x1807C5FB0")]
	protected GLGKGIDADMG(object? DNFOIDHHJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool EMIGLMHDFJK(object? AFCGKMGKPEF);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class CIGDBHDNBFP<T> : GLGKGIDADMG where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private T EHDONHPAGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly IEqualityComparer<T> AFNKGJFOKIJ;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T FMINBKHGIKA
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x82CC20", Offset = "0x82BE20", VA = "0x18082CC20")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x49D6AD0", Offset = "0x49D5CD0", VA = "0x1849D6AD0", Slot = "4")]
	public override bool EMIGLMHDFJK(object? AFCGKMGKPEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x49D6EF0", Offset = "0x49D60F0", VA = "0x1849D6EF0")]
	public bool OPHMEPMMFPH(T NMPDOJNOJAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x49D72D0", Offset = "0x49D64D0", VA = "0x1849D72D0")]
	public CIGDBHDNBFP(T OJAOIAHHHNE, IEqualityComparer<T> AFNKGJFOKIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class EAPCBEIFMPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<GKBFAHAADAN, bool> FFFCNMLMDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<GKBFAHAADAN, GLGKGIDADMG> DMHKKELIGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly LNCIAIDBHPM HPDFFBLCDPK;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x676A780", Offset = "0x6769980", VA = "0x18676A780")]
	public EAPCBEIFMPK(LNCIAIDBHPM HPDFFBLCDPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x676A510", Offset = "0x6769710", VA = "0x18676A510")]
	public bool HLKJGANPDPF(GKBFAHAADAN ELOBMGDLLEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2636220", Offset = "0x2635420", VA = "0x182636220")]
	public bool FOLGELDGDHK<T>(GKBFAHAADAN ELOBMGDLLEE, bool LAOBIKOJBKK, T AFCGKMGKPEF) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2635E50", Offset = "0x2635050", VA = "0x182635E50")]
	public (bool, T?) FGNJBDIHPLF<T>(GKBFAHAADAN ELOBMGDLLEE) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x676A430", Offset = "0x6769630", VA = "0x18676A430")]
	public bool FOLGELDGDHK(GKBFAHAADAN ELOBMGDLLEE, bool LAOBIKOJBKK, object AFCGKMGKPEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x676A360", Offset = "0x6769560", VA = "0x18676A360")]
	public (bool, object) FGNJBDIHPLF(GKBFAHAADAN ELOBMGDLLEE)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2636730", Offset = "0x2635930", VA = "0x182636730")]
	private void HPGIEFGHCMA<T>(GKBFAHAADAN ELOBMGDLLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x676A290", Offset = "0x6769490", VA = "0x18676A290")]
	private GLGKGIDADMG CEBAFFCNENN(GKBFAHAADAN ELOBMGDLLEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x676A580", Offset = "0x6769780", VA = "0x18676A580")]
	public void NMFGBAHAMHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class LBCHLHJBCKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly string NEGLGEGOBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly Type CIGIMNFKFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly HGOLOCFGDMO PDKGFHMOIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly GKBFAHAADAN IOPPEHHFJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public OCNFLGBBAMN BANGENGOKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public AFADHHMLMBI CKNEKACBIHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public DBIIBGMKBHA EKCJEENCNAK;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x676E700", Offset = "0x676D900", VA = "0x18676E700")]
	public LBCHLHJBCKG(Type INOFNCKLAAL, string LCMCHLLEGOG, GKBFAHAADAN ELOBMGDLLEE, OCNFLGBBAMN CIJBFEKJOCP, AFADHHMLMBI MKADHBMMBBB, DBIIBGMKBHA LCPMPKPJIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x676E600", Offset = "0x676D800", VA = "0x18676E600")]
	public object CEOKNNMACLL(object? NFMPGFPPFKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2826670", Offset = "0x2825870", VA = "0x182826670")]
	public void HPGIEFGHCMA<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x676E650", Offset = "0x676D850", VA = "0x18676E650")]
	public void HPGIEFGHCMA(Type FJHJOKDHEFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class KDOGNOGPLLK<T> : LBCHLHJBCKG where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string PDCDCJDDJBG(T AFCGKMGKPEF);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T AIBMDNAICLG(string? HLNBEGFIIGG, T OJAOIAHHHNE);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class IPLFABOBOFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public PDCDCJDDJBG serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AIBMDNAICLG parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public IPLFABOBOFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x38C9BD0", Offset = "0x38C8DD0", VA = "0x1838C9BD0")]
		internal string IFKGGAHJEJL(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x38C9D10", Offset = "0x38C8F10", VA = "0x1838C9D10")]
		internal object JNLANGFKCJK(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3B4C890", Offset = "0x3B4BA90", VA = "0x183B4C890")]
	public KDOGNOGPLLK(GKBFAHAADAN ELOBMGDLLEE, string LCMCHLLEGOG, [Optional] PDCDCJDDJBG? CIJBFEKJOCP, [Optional] AIBMDNAICLG? MKADHBMMBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3B4B490", Offset = "0x3B4A690", VA = "0x183B4B490")]
	private static object? APPDJDLGIOH(AIBMDNAICLG? MKADHBMMBBB, string? HLNBEGFIIGG, object? OJAOIAHHHNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3B4BD70", Offset = "0x3B4AF70", VA = "0x183B4BD70")]
	private static string CJMGAEMJONM(PDCDCJDDJBG? HKJGMIDMPCI, object? AFCGKMGKPEF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string OCNFLGBBAMN(object? AFCGKMGKPEF);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object AFADHHMLMBI(string? HLNBEGFIIGG, [Optional] object OJAOIAHHHNE);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate GLGKGIDADMG DBIIBGMKBHA();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class LNCIAIDBHPM
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class PAKKAENPKCL : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal static PAKKAENPKCL MJANIPKLNPJ;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x676FCF0", Offset = "0x676EEF0", VA = "0x18676FCF0", Slot = "4")]
		public bool Equals(List<string> DHOHKCEOCND, List<string> CKNDNFKDDJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x676FE40", Offset = "0x676F040", VA = "0x18676FE40", Slot = "5")]
		public int GetHashCode(List<string> MFLACBLODGN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public PAKKAENPKCL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class OEOALGLHBMN : HBAAFNBADJJ<FDIOABLDELB>
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x676FBC0", Offset = "0x676EDC0", VA = "0x18676FBC0", Slot = "9")]
		public override string CJMGAEMJONM(FDIOABLDELB NKIKIMMJFMI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x676F9E0", Offset = "0x676EBE0", VA = "0x18676F9E0", Slot = "10")]
		protected override bool BBOGJCODFBM(string NKIKIMMJFMI, [Out] FDIOABLDELB AFCGKMGKPEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x676FCB0", Offset = "0x676EEB0", VA = "0x18676FCB0")]
		public OEOALGLHBMN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly CLCHJEEBPDE AJIAIMFNBMH;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly OEOALGLHBMN HDDCKCMLAFP;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly List<LBCHLHJBCKG> PEJHJDOPJMG;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<GKBFAHAADAN> BOPLBECBPNC
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3A0", Offset = "0x7B95A0", VA = "0x1807BA3A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<GKBFAHAADAN, LBCHLHJBCKG> MMMJMCLFNAM
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x676F610", Offset = "0x676E810", VA = "0x18676F610")]
	public LNCIAIDBHPM([Optional] IList<LBCHLHJBCKG>? LLAJOEPEPED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x676E7A0", Offset = "0x676D9A0", VA = "0x18676E7A0")]
	public LBCHLHJBCKG AAGBAKAJOGB(GKBFAHAADAN ELOBMGDLLEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface MNLHKGJECIE
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	BPPLGOECEGD HPAGFEFFHKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class BJEELKOHKKP : MNLHKGJECIE
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static BJEELKOHKKP LBHDDPBCHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly GOFOIBPPGGA LKCDAMPMELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal readonly IReadOnlyList<GOFOIBPPGGA> FDEELLNLIBB;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public BPPLGOECEGD HPAGFEFFHKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3A0", Offset = "0x7B95A0", VA = "0x1807BA3A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6763B20", Offset = "0x6762D20", VA = "0x186763B20")]
	public BJEELKOHKKP(GOFOIBPPGGA KCAPLKGMANG, IReadOnlyList<GOFOIBPPGGA> BCJPHEMPNDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x67630F0", Offset = "0x67622F0", VA = "0x1867630F0")]
	private static BJEELKOHKKP EGNKOEAOHEF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class HKCGKCOBEJJ
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<NBFABDGBKDO> PGJBCIBHOKF;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x676DCB0", Offset = "0x676CEB0", VA = "0x18676DCB0")]
	public static bool PEJNBKGAAHL(this PFFLGDPBKDO HDEBPAGEHIB, NBFABDGBKDO OOGLIFHBJHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x676DC30", Offset = "0x676CE30", VA = "0x18676DC30")]
	public static bool FDDODCOMFHN(this PFFLGDPBKDO HDEBPAGEHIB, NBFABDGBKDO OOGLIFHBJHI, KFGKPCFIHIN BAKEONLLCJF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface DGMCMHKGCJL
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool OMNELMHKHON
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool EOAIPMCAKLC
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool HFEMAIIEJAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool FNLCGCLADEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool CACBMOCGAOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool IOGMINGDNOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool COECPJJPFBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool OMKDLNIMEPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool OBCDEJBPNIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool MKFJKJEAKBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool NLHKBNJLOFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool DLFENAIFMDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> ELBPBCNLIJG
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	FDIOABLDELB INCMFAPHDCG
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface BPPLGOECEGD : DGMCMHKGCJL, ANIPEKFAKAC, KIDHBIIKMCI<GKBFAHAADAN>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string CKCKCMKEMHH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	NBFABDGBKDO GOMLACPBBJG
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) DKIKLJDOPHJ<T>(GKBFAHAADAN ELOBMGDLLEE) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum GKBFAHAADAN
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
internal class GOFOIBPPGGA : BPPLGOECEGD, DGMCMHKGCJL, ANIPEKFAKAC, KIDHBIIKMCI<GKBFAHAADAN>
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal static readonly LNCIAIDBHPM PINKGOGEPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly EAPCBEIFMPK PKMIICKDEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private string? ANMOPIMAFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private string? ACNCAJLMNCF;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool JLBHIIMGLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x676CE00", Offset = "0x676C000", VA = "0x18676CE00", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool ABHFHHIAGIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x676D2F0", Offset = "0x676C4F0", VA = "0x18676D2F0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool LMHLAKOBMDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x676D070", Offset = "0x676C270", VA = "0x18676D070", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool AGFFBEAKHKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x676BA50", Offset = "0x676AC50", VA = "0x18676BA50", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool DMHCBOHMMNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x676D1B0", Offset = "0x676C3B0", VA = "0x18676D1B0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool DHPGNFMOENI
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x676D7C0", Offset = "0x676C9C0", VA = "0x18676D7C0", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public NBFABDGBKDO GOMLACPBBJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x82CC20", Offset = "0x82BE20", VA = "0x18082CC20", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(NBFABDGBKDO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7C6280", Offset = "0x7C5480", VA = "0x1807C6280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string PCBPAFFBLJM
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x676BF10", Offset = "0x676B110", VA = "0x18676BF10", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x676CF50", Offset = "0x676C150", VA = "0x18676CF50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string CKCKCMKEMHH
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x676BF10", Offset = "0x676B110", VA = "0x18676BF10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool FEAIHLFDHKL
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x87C400", Offset = "0x87B600", VA = "0x18087C400")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x87B640", Offset = "0x87A840", VA = "0x18087B640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool OMNELMHKHON
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x676D340", Offset = "0x676C540", VA = "0x18676D340", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public FDIOABLDELB INCMFAPHDCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x676C2E0", Offset = "0x676B4E0", VA = "0x18676C2E0", Slot = "20")]
		get
		{
			return default(FDIOABLDELB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool EOAIPMCAKLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x676CFA0", Offset = "0x676C1A0", VA = "0x18676CFA0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool HFEMAIIEJAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x676CDB0", Offset = "0x676BFB0", VA = "0x18676CDB0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool FNLCGCLADEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x676D200", Offset = "0x676C400", VA = "0x18676D200", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool CACBMOCGAOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x676C330", Offset = "0x676B530", VA = "0x18676C330", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool IOGMINGDNOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x676D6C0", Offset = "0x676C8C0", VA = "0x18676D6C0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool COECPJJPFBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x676D470", Offset = "0x676C670", VA = "0x18676D470", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool OMKDLNIMEPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x676D160", Offset = "0x676C360", VA = "0x18676D160", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool OBCDEJBPNIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x676D0C0", Offset = "0x676C2C0", VA = "0x18676D0C0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> ELBPBCNLIJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x676D810", Offset = "0x676CA10", VA = "0x18676D810", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool OFMCNKAJHNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x676CE00", Offset = "0x676C000", VA = "0x18676CE00", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool PIELKCKNNFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x676D1B0", Offset = "0x676C3B0", VA = "0x18676D1B0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool PDDDLAAGHJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x676D2F0", Offset = "0x676C4F0", VA = "0x18676D2F0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool MKFJKJEAKBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x676D250", Offset = "0x676C450", VA = "0x18676D250", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool NLHKBNJLOFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x676D2A0", Offset = "0x676C4A0", VA = "0x18676D2A0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool KFPLIEHPODM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x676D070", Offset = "0x676C270", VA = "0x18676D070", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool DLFENAIFMDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x676D890", Offset = "0x676CA90", VA = "0x18676D890", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool LJNOGABJEGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x676BA50", Offset = "0x676AC50", VA = "0x18676BA50", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool EIFFFONEHGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x676D7C0", Offset = "0x676C9C0", VA = "0x18676D7C0", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event NIPFKLPAPKN<GKBFAHAADAN> LCMEGKCJBFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x676D710", Offset = "0x676C910", VA = "0x18676D710", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x676C380", Offset = "0x676B580", VA = "0x18676C380", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2768C70", Offset = "0x2767E70", VA = "0x182768C70", Slot = "6")]
	public (bool, T?) DKIKLJDOPHJ<T>(GKBFAHAADAN ELOBMGDLLEE) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2768E00", Offset = "0x2768000", VA = "0x182768E00")]
	public GOFOIBPPGGA KBGLCJPPDFD<T>(GKBFAHAADAN ELOBMGDLLEE, bool LAOBIKOJBKK, T AFCGKMGKPEF) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x676DA00", Offset = "0x676CC00", VA = "0x18676DA00")]
	public GOFOIBPPGGA(NBFABDGBKDO OOGLIFHBJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x676DC10", Offset = "0x676CE10", VA = "0x18676DC10")]
	public GOFOIBPPGGA(NBFABDGBKDO OOGLIFHBJHI, [Optional] string? ANMOPIMAFPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x676DA20", Offset = "0x676CC20", VA = "0x18676DA20")]
	public GOFOIBPPGGA(GOFOIBPPGGA MDOAGLDNFJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x676DAB0", Offset = "0x676CCB0", VA = "0x18676DAB0")]
	internal GOFOIBPPGGA(NBFABDGBKDO JFBHHAFDMOE, [Optional] string? ANMOPIMAFPI, [Optional] GOFOIBPPGGA? MDOAGLDNFJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x676CFF0", Offset = "0x676C1F0", VA = "0x18676CFF0")]
	public static HGOLOCFGDMO FFIBNDPBNMN(GKBFAHAADAN ELOBMGDLLEE)
	{
		return default(HGOLOCFGDMO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x676D870", Offset = "0x676CA70", VA = "0x18676D870")]
	public void NMFGBAHAMHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x676BF60", Offset = "0x676B160", VA = "0x18676BF60")]
	internal GOFOIBPPGGA BMBNIEAJJEJ(GOFOIBPPGGA OKLKMNFJEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x676BAA0", Offset = "0x676ACA0", VA = "0x18676BAA0")]
	internal IReadOnlyCollection<GKBFAHAADAN> BADHGPGGKLB(GOFOIBPPGGA MDOAGLDNFJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x676D390", Offset = "0x676C590", VA = "0x18676D390")]
	public bool KPHFKKJGKIC(GKBFAHAADAN ELOBMGDLLEE, bool LAOBIKOJBKK, string EIFMBJOCNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x676CE50", Offset = "0x676C050", VA = "0x18676CE50")]
	public (bool, string) DNGPEPKDKAD(GKBFAHAADAN ELOBMGDLLEE)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x676D110", Offset = "0x676C310", VA = "0x18676D110")]
	internal void HFKNJKHJIGG(GKBFAHAADAN ELOBMGDLLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x676D4C0", Offset = "0x676C6C0", VA = "0x18676D4C0")]
	public PMKBOKMPBCE LBIJJBFGJLF(Func<NBFABDGBKDO, Guid> EFENCCDCFOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x676C430", Offset = "0x676B630", VA = "0x18676C430")]
	public void CLJJFCJCADD(PMKBOKMPBCE MEEGDIJLJFB, Func<Guid, NBFABDGBKDO> AKAOAHOCHHN, [Optional] NBFABDGBKDO? HPLHFPHFMBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x676D8E0", Offset = "0x676CAE0", VA = "0x18676D8E0")]
	[CompilerGenerated]
	private void PGLFNPCPHNB(GKBFAHAADAN BCONMBIJMBL, LAJKAACFGID IHJICDILIDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class CFBPNOCIBNI : GLKJIBBPGNO, EEDHGNDJMFD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class PKPIGAJNLPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public GOFOIBPPGGA newRole;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public PKPIGAJNLPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6770030", Offset = "0x676F230", VA = "0x186770030")]
		internal bool EKPCIHELDHC(GOFOIBPPGGA rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class ADFJPKDGFHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public NBFABDGBKDO roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public ADFJPKDGFHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6762EE0", Offset = "0x67620E0", VA = "0x186762EE0")]
		internal bool HPGJGANFFDL(NBFABDGBKDO r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct KNGLFMHCCPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public CFBPNOCIBNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public KCOMFGNMNDO roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<EKBNBLNPNGF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x676DF40", Offset = "0x676D140", VA = "0x18676DF40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x676E5A0", Offset = "0x676D7A0", VA = "0x18676E5A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class AJAKHKMKAEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public AJAKHKMKAEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6763010", Offset = "0x6762210", VA = "0x186763010")]
		internal void KBOGDPDLPDG(PMKBOKMPBCE r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6762EF0", Offset = "0x67620F0", VA = "0x186762EF0")]
		internal void HKNIHKCPIOG(PMKBOKMPBCE r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct DIJLOCDPAFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public KCOMFGNMNDO roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class GGOOLIOHJLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Func<PMKBOKMPBCE, LAJKAACFGID> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public GGOOLIOHJLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x676B9C0", Offset = "0x676ABC0", VA = "0x18676B9C0")]
		internal void HDMBGIOEHFO(PMKBOKMPBCE r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x676BA20", Offset = "0x676AC20", VA = "0x18676BA20")]
		internal void KEHHFKOEHMJ(PMKBOKMPBCE r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x676B9F0", Offset = "0x676ABF0", VA = "0x18676B9F0")]
		internal void INKCKJIJINK(PMKBOKMPBCE r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class GOBKFBGMIBM<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private struct <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public GOBKFBGMIBM<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private TaskAwaiter<EKBNBLNPNGF> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x30D1440", Offset = "0x30D0640", VA = "0x1830D1440", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x89C0E0", Offset = "0x89B2E0", VA = "0x18089C0E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public CFBPNOCIBNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public GKBFAHAADAN rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public NBFABDGBKDO accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public HGOLOCFGDMO recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public GOBKFBGMIBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3764C40", Offset = "0x3763E40", VA = "0x183764C40")]
		[AsyncStateMachine(typeof(GOBKFBGMIBM<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void NAKGHEHPDLD()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct MCBOHIOPDBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public IReadOnlyList<GHNLHFEJGHE> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct DNJFNOCHCEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public CPBPEHOECKI rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public KCOMFGNMNDO roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public IReadOnlyDictionary<NBFABDGBKDO, GOFOIBPPGGA> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public KFLPEFKGGIK debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6769720", Offset = "0x6768920", VA = "0x186769720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x676A230", Offset = "0x6769430", VA = "0x18676A230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly CPBPEHOECKI DEGKLDODJEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly BJEELKOHKKP NDCEIHIGPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly KFLPEFKGGIK ECMGLPJDBKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, GOFOIBPPGGA> AFAPPMGGPHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	internal readonly Dictionary<NBFABDGBKDO, GOFOIBPPGGA> NFGDGOADDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal readonly Dictionary<NBFABDGBKDO, GOFOIBPPGGA> DFDCINFBIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	internal readonly List<GOFOIBPPGGA> KACFIFPMBCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool CGLHDNAOLKC;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly GKBFAHAADAN[] MKDOLFHKDDO;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public MNLHKGJECIE AHJJCOAOLGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<BPPLGOECEGD> EBIOKHKOBEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6767000", Offset = "0x6766200", VA = "0x186767000", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event HNGFJHINLEM KICGOAPCMND
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6766B70", Offset = "0x6765D70", VA = "0x186766B70", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x67684A0", Offset = "0x67676A0", VA = "0x1867684A0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x67641F0", Offset = "0x67633F0", VA = "0x1867641F0")]
	[JKGCDNJCKNE(MDFHPBOGAKL.Room, LIEILBDPEFI.None)]
	private static void BILEGPKILIM(IAIHJGNDPNA DEDNEEHAEAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6769460", Offset = "0x6768660", VA = "0x186769460")]
	[UnityEngine.Scripting.Preserve]
	internal CFBPNOCIBNI([BALLJMBCNAE(null)] CPBPEHOECKI KOIPIIMPGIP, [BALLJMBCNAE(null)] BJEELKOHKKP ICKPADIBHEG, [BALLJMBCNAE(null)] KFLPEFKGGIK ECMGLPJDBKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6764EC0", Offset = "0x67640C0", VA = "0x186764EC0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6767C20", Offset = "0x6766E20", VA = "0x186767C20")]
	private void MADELHEBNDH(IEnumerable<GOFOIBPPGGA> MNIGGMJFKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6765160", Offset = "0x6764360", VA = "0x186765160", Slot = "12")]
	public bool EMIHGFHIIJE(PFFLGDPBKDO DONKKIJPHLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6769140", Offset = "0x6768340", VA = "0x186769140")]
	private void PONKDHAPOFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6765230", Offset = "0x6764430", VA = "0x186765230")]
	private void EPBEEGOOGHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x67643B0", Offset = "0x67635B0", VA = "0x1867643B0", Slot = "10")]
	public IReadOnlyList<BPPLGOECEGD> BOLDFPIMGFI(bool IBELIHDOMPI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x67662D0", Offset = "0x67654D0", VA = "0x1867662D0", Slot = "11")]
	public BPPLGOECEGD GEKJIPNKKNI(PFFLGDPBKDO DONKKIJPHLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6768BF0", Offset = "0x6767DF0", VA = "0x186768BF0")]
	private NBFABDGBKDO NNOLCGCPGJF(PFFLGDPBKDO DONKKIJPHLE)
	{
		return default(NBFABDGBKDO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6764FD0", Offset = "0x67641D0", VA = "0x186764FD0", Slot = "14")]
	public bool EEMLOINNGNM(PFFLGDPBKDO GKIKKALGCJE, NBFABDGBKDO OOGLIFHBJHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6766230", Offset = "0x6765430", VA = "0x186766230", Slot = "15")]
	public BPPLGOECEGD FNECNMEHDBO(NBFABDGBKDO OOGLIFHBJHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6768540", Offset = "0x6767740", VA = "0x186768540")]
	private static bool NCGFABLBMOB(PPDCMIPPKLI OFBNAPHDLLC, NBFABDGBKDO OOGLIFHBJHI, [Out] PMKBOKMPBCE? OJDGLAGEBAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6768870", Offset = "0x6767A70", VA = "0x186768870")]
	private static void NGBHNCHOPGM(PPDCMIPPKLI OFBNAPHDLLC, Action<PMKBOKMPBCE> MHGBGDFNAPP, NBFABDGBKDO HCBDKLGNGMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6768960", Offset = "0x6767B60", VA = "0x186768960")]
	private static void NGBHNCHOPGM(PPDCMIPPKLI OFBNAPHDLLC, Action<PMKBOKMPBCE> MHGBGDFNAPP, Predicate<NBFABDGBKDO> HNMIGGPIMFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6766C20", Offset = "0x6765E20", VA = "0x186766C20")]
	private void IBDADMJBPJO(PFFLGDPBKDO DONKKIJPHLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6768EF0", Offset = "0x67680F0", VA = "0x186768EF0", Slot = "4")]
	[AsyncStateMachine(typeof(KNGLFMHCCPK))]
	public Task ONJJBJLNBEM([CanBeNull] KCOMFGNMNDO OMKGFBDCDEE, CancellationToken OBNOJDAGGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "5")]
	public void KBEOKGGKGPN(KCOMFGNMNDO OMKGFBDCDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x67678E0", Offset = "0x6766AE0", VA = "0x1867678E0")]
	private void LPFEMLGGGDO(PPDCMIPPKLI BAOJLGICFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x67672F0", Offset = "0x67664F0", VA = "0x1867672F0")]
	internal static string LHHHGBIOIOF(CPBPEHOECKI DEGKLDODJEI, KCOMFGNMNDO OMKGFBDCDEE, IReadOnlyDictionary<NBFABDGBKDO, GOFOIBPPGGA> NFGDGOADDLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6765420", Offset = "0x6764620", VA = "0x186765420")]
	private static void FCHCBFLODKN(KCOMFGNMNDO OMKGFBDCDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6764B70", Offset = "0x6763D70", VA = "0x186764B70")]
	private static void DJPKBCPJDFH(PPDCMIPPKLI FNKMGHMHJNJ, IReadOnlyDictionary<NBFABDGBKDO, GOFOIBPPGGA> NFGDGOADDLI, StringBuilder HLMJIMOHEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6769030", Offset = "0x6768230", VA = "0x186769030")]
	private static bool PHEMGPMIJGH(string NCPLGKOMGDK, [Out] Guid GLLADNDPJBK, [Out] NBFABDGBKDO OOGLIFHBJHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6764430", Offset = "0x6763630", VA = "0x186764430")]
	private static void COCFOPEGAKO(KCOMFGNMNDO OMKGFBDCDEE, StringBuilder HLMJIMOHEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x25EBE30", Offset = "0x25EB030", VA = "0x1825EBE30", Slot = "16")]
	public bool PEAOBBKENON<T>(NBFABDGBKDO OOGLIFHBJHI, GKBFAHAADAN ELOBMGDLLEE, bool LAOBIKOJBKK, T CIENKKNJAIC, [Optional] Action GNPNLJAJJIB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6763FE0", Offset = "0x67631E0", VA = "0x186763FE0")]
	private void BCLOGLBLAAO(NBFABDGBKDO OOGLIFHBJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6769010", Offset = "0x6768210", VA = "0x186769010")]
	private bool PCEJEHGCMGH(PFFLGDPBKDO DONKKIJPHLE, NBFABDGBKDO OOGLIFHBJHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6763C90", Offset = "0x6762E90", VA = "0x186763C90")]
	internal GOFOIBPPGGA AHLKOIEJINJ(PFFLGDPBKDO DONKKIJPHLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6766C10", Offset = "0x6765E10", VA = "0x186766C10", Slot = "13")]
	public IReadOnlyList<BPPLGOECEGD> HONCLFPJEDJ(PFFLGDPBKDO DONKKIJPHLE, bool KELCNNPLGGG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6768CC0", Offset = "0x6767EC0", VA = "0x186768CC0")]
	internal IReadOnlyList<GOFOIBPPGGA> OIKDEJPMNGI(PFFLGDPBKDO DONKKIJPHLE, bool KELCNNPLGGG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x67663E0", Offset = "0x67655E0", VA = "0x1867663E0")]
	private void GJDECIGGPKO(EKBNBLNPNGF NCKPPLJDNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x67675F0", Offset = "0x67667F0", VA = "0x1867675F0")]
	private static bool LMDPIJOJAGD(GOFOIBPPGGA CBJCMMIADNM, IReadOnlyDictionary<NBFABDGBKDO, GOFOIBPPGGA> NFGDGOADDLI, [Out] IReadOnlyList<GKBFAHAADAN> COILAKAEGIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6769150", Offset = "0x6768350", VA = "0x186769150")]
	[AsyncStateMachine(typeof(DNJFNOCHCEJ))]
	private static Task PPBFNEALMEK(CPBPEHOECKI DEGKLDODJEI, KCOMFGNMNDO OMKGFBDCDEE, IReadOnlyDictionary<NBFABDGBKDO, GOFOIBPPGGA> NFGDGOADDLI, KFLPEFKGGIK ECMGLPJDBKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6767050", Offset = "0x6766250", VA = "0x186767050")]
	[CompilerGenerated]
	internal static void LGCDGIKAHKL(Func<PMKBOKMPBCE, LAJKAACFGID> JKPMKHAOKOP, DIJLOCDPAFM P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6766C90", Offset = "0x6765E90", VA = "0x186766C90")]
	[CompilerGenerated]
	internal static bool JHMJGJELJIH(NBFABDGBKDO OOGLIFHBJHI, GKBFAHAADAN ELOBMGDLLEE, [Out] GHNLHFEJGHE EJDPKKLMELE, MCBOHIOPDBK P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface OOOKONPLGDL
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OLNHIBPBJCM(PFFLGDPBKDO KGLAFIOGKKC, PFFLGDPBKDO PIHGNLJGOHA, IEnumerable<PFFLGDPBKDO> FAODIOCOBCP, [Out] FDIOABLDELB CLGPFOIKHPI, [Out] CJONJFCLFLA GLFBEJKCJJL);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string IKEMFPKPDCN(CJONJFCLFLA FDHHBCHDHNB);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum CJONJFCLFLA : byte
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
internal class GDPLMFABAFJ : OOOKONPLGDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly EEDHGNDJMFD ILNFDKPEODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly NNMNBEIGLDO FMFNBBMBKDL;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7BB6A0", Offset = "0x7BA8A0", VA = "0x1807BB6A0")]
	[RecRoom.NoEngine.Common.Preserve]
	public GDPLMFABAFJ([BALLJMBCNAE(null)] EEDHGNDJMFD ABAPELPJHPJ, [BALLJMBCNAE(null)] NNMNBEIGLDO PAECGHPAOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x676B260", Offset = "0x676A460", VA = "0x18676B260")]
	private static COKACEIKMEF? MAJLMLIJGBH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x676B8C0", Offset = "0x676AAC0", VA = "0x18676B8C0", Slot = "4")]
	public bool OLNHIBPBJCM(PFFLGDPBKDO KGLAFIOGKKC, PFFLGDPBKDO PIHGNLJGOHA, IEnumerable<PFFLGDPBKDO> FAODIOCOBCP, [Out] FDIOABLDELB CLGPFOIKHPI, [Out] CJONJFCLFLA GLFBEJKCJJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x676B160", Offset = "0x676A360", VA = "0x18676B160", Slot = "5")]
	public string IKEMFPKPDCN(CJONJFCLFLA FDHHBCHDHNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x676B2A0", Offset = "0x676A4A0", VA = "0x18676B2A0")]
	internal bool OIEHINBLPHI(PFFLGDPBKDO KGLAFIOGKKC, PFFLGDPBKDO PIHGNLJGOHA, IEnumerable<PFFLGDPBKDO> FAODIOCOBCP, KFGKPCFIHIN BAKEONLLCJF, COKACEIKMEF? DFCNPIIMCGK, [Out] FDIOABLDELB CLGPFOIKHPI, [Out] CJONJFCLFLA GLFBEJKCJJL)
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
