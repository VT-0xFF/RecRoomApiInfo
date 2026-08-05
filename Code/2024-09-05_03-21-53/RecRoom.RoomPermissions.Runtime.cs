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
		[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
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
		[Cpp2IlInjected.Address(RVA = "0x72D4DB0", Offset = "0x72D37B0", VA = "0x1872D4DB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8AEC90", Offset = "0x8AD690", VA = "0x1808AEC90")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AECD0", Offset = "0x8AD6D0", VA = "0x1808AECD0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum NBDNFJNDMIP
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
	public class _AssemblyIndex : MGJKNLCKGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x72D5930", Offset = "0x72D4330", VA = "0x1872D5930", Slot = "8")]
		public override void KLIFGJHDPHO(DIMDGJNLMOK registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6283490", Offset = "0x6281E90", VA = "0x186283490")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void FDLAPODPKEK<TPermission>(TPermission LCABCKJKMIN);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void KPEGMNEFAKL(PHNOICNFFCM JGEPDBLHLJG);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum ENLABJHOCPI
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MIPNGOBHAOB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool IOGLLMBBFEH
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool KODAFAMHNDK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool IDNBLPBJHNB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool HKEFOKKGFCL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool JFCBFOFGELO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool KHJOPADMGJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class DIOKAOKKHKC
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum ENOACGOIJEE
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
	public static readonly Guid HPJHINMIGPN;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid EBGENEHGKDE;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid LFHIMIABFJD;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid PCHIAIDIDFJ;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid OHDEKKPNFIA;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid CFMKNIEOICP;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly HCGKFDBNBGF<LHNNEDFONNE, Guid> NHCOCDPJEIF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<LHNNEDFONNE> GHPNFFOOCMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x72C9790", Offset = "0x72C8190", VA = "0x1872C9790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x72C9930", Offset = "0x72C8330", VA = "0x1872C9930")]
	public static LHNNEDFONNE GKLOPIMBDKL(Guid HLIKNGLOMIK)
	{
		return default(LHNNEDFONNE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x72C9890", Offset = "0x72C8290", VA = "0x1872C9890")]
	public static Guid FJLDBAEEBJO(LHNNEDFONNE NLNFLDELJJM)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x72C9800", Offset = "0x72C8200", VA = "0x1872C9800")]
	public static bool DMJLOFFNOAP(LHNNEDFONNE NLNFLDELJJM, [Out] Guid HLIKNGLOMIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x72C9A40", Offset = "0x72C8440", VA = "0x1872C9A40")]
	public static bool NEGNJOADFAP(Guid HLIKNGLOMIK, [Out] LHNNEDFONNE NLNFLDELJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x72C99C0", Offset = "0x72C83C0", VA = "0x1872C99C0")]
	public static LHNNEDFONNE IGHOONMNLPB(LHNNEDFONNE NLNFLDELJJM)
	{
		return default(LHNNEDFONNE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x72C9AE0", Offset = "0x72C84E0", VA = "0x1872C9AE0")]
	public static ENOACGOIJEE PDPHGLIGACA(LHNNEDFONNE IHAAKNKIKPH)
	{
		return default(ENOACGOIJEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x72C9A00", Offset = "0x72C8400", VA = "0x1872C9A00")]
	internal static LHNNEDFONNE KFOAJGCOGOA(ENOACGOIJEE INGAPEEFEPF)
	{
		return default(LHNNEDFONNE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LKIOIPGEHOO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	CNDDJJCBACN IBFJGMEEEOH
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<BLFNPMILCAM> FJPFCOINEJN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event KPEGMNEFAKL DMBFIJIBJCC;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<BLFNPMILCAM> IEFEGFJODAM(bool OJAPCNHOGIH = false);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BLFNPMILCAM KKLAPICIJIN(PHNOICNFFCM JGEPDBLHLJG);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NFGLPIJHEED(PHNOICNFFCM JGEPDBLHLJG);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<BLFNPMILCAM> FACHLBHMEKD(PHNOICNFFCM JGEPDBLHLJG, bool ONDKADGAFIB = false);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool DODIKEEMELM(PHNOICNFFCM NFAAPJHFELB, LHNNEDFONNE NLNFLDELJJM);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	BLFNPMILCAM CPPEEKGNGEN(LHNNEDFONNE NLNFLDELJJM);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool BPGGOGJANDO<T>(LHNNEDFONNE NLNFLDELJJM, HKABDCNAHLP LCABCKJKMIN, bool HHPFCLGAENN, T NBIHLDEPEPA, [Optional] Action HCDLLJGCOLJ) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string AOPICGAJPPK(HKABDCNAHLP LCABCKJKMIN);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CNPMLDCBKKO
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task KEKLBCKPOFH(PCBLLGHKJMO HMIHKJIKEGE, CancellationToken OGJIGALEPCA);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FCGBPIGPNKH(PCBLLGHKJMO HMIHKJIKEGE);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface EMAABBKCFLB
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	PHNOICNFFCM DCDNOACELPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	IFBKLNGMBFG JKBMMDKCNMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	OMGLHECGLKD EEEOHDHABDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<JAEBMNICJBL> OPEGNMNGBAH;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action GDLKMFPJMJD;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LHNNEDFONNE FLGODBNDHCB(PHNOICNFFCM JGEPDBLHLJG);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<JAEBMNICJBL> ALHDJNBPCDG(CancellationToken OGJIGALEPCA);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task JAMMNEPBCOF(long NDAIANNJONA, IReadOnlyList<IMHLJNAALLH> IAPMEDPKPFD);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task EDDDFACMJPA(long NDAIANNJONA, long ENACNDIJBLG, IReadOnlyList<IMHLJNAALLH> IAPMEDPKPFD);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<PHNOICNFFCM> DJCPIPDFICO();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class OHKGFLAKEFF
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x72D4E30", Offset = "0x72D3830", VA = "0x1872D4E30")]
	public static LHNNEDFONNE JGHOAOEFFFB(this EMAABBKCFLB AIOJECDDJCN)
	{
		return default(LHNNEDFONNE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface CAGLIPHCDPP<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string CFBDLCKGDIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event FDLAPODPKEK<TPermission> DLFMMFEJKMP;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal abstract class LNOBMMJOKHG
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? CNKENKMAFMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x882790", Offset = "0x881190", VA = "0x180882790")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x882870", Offset = "0x881270", VA = "0x180882870")]
	protected LNOBMMJOKHG(object? GHMGFOEMMAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool DLCIEAOOIGC(object? CLMKDBDPNNH);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class PFNNJAEGNEK<T> : LNOBMMJOKHG where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private T LFBFEHNGMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly IEqualityComparer<T> MFGCOCEIJOG;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T GJBIHCLEEHA
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9ECD20", Offset = "0x9EB720", VA = "0x1809ECD20")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x491ECD0", Offset = "0x491D6D0", VA = "0x18491ECD0", Slot = "4")]
	public override bool DLCIEAOOIGC(object? CLMKDBDPNNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x491E920", Offset = "0x491D320", VA = "0x18491E920")]
	public bool BJDNPFJPLJN(T GCJLJBGPAGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x491F110", Offset = "0x491DB10", VA = "0x18491F110")]
	public PFNNJAEGNEK(T PEMAOEALEHB, IEqualityComparer<T> MFGCOCEIJOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class HODCEDNBGOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<HKABDCNAHLP, bool> GCPMJDDDALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<HKABDCNAHLP, LNOBMMJOKHG> AOMLKEHJJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly JEAPLMHGDFL BANKJBOHGFP;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x72CA800", Offset = "0x72C9200", VA = "0x1872CA800")]
	public HODCEDNBGOH(JEAPLMHGDFL BANKJBOHGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x72CA6B0", Offset = "0x72C90B0", VA = "0x1872CA6B0")]
	public bool LGINHEDFNMH(HKABDCNAHLP LCABCKJKMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2CBF6C0", Offset = "0x2CBE0C0", VA = "0x182CBF6C0")]
	public bool OCOOEDHILCN<T>(HKABDCNAHLP LCABCKJKMIN, bool HHPFCLGAENN, T CLMKDBDPNNH) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2CBF1C0", Offset = "0x2CBDBC0", VA = "0x182CBF1C0")]
	public (bool, T?) IJGOADCALGL<T>(HKABDCNAHLP LCABCKJKMIN) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x72CA720", Offset = "0x72C9120", VA = "0x1872CA720")]
	public bool OCOOEDHILCN(HKABDCNAHLP LCABCKJKMIN, bool HHPFCLGAENN, object CLMKDBDPNNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x72CA320", Offset = "0x72C8D20", VA = "0x1872CA320")]
	public (bool, object) IJGOADCALGL(HKABDCNAHLP LCABCKJKMIN)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2CBF660", Offset = "0x2CBE060", VA = "0x182CBF660")]
	private void MLOJOHFBNGI<T>(HKABDCNAHLP LCABCKJKMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x72CA5E0", Offset = "0x72C8FE0", VA = "0x1872CA5E0")]
	private LNOBMMJOKHG JDDKGCALLLM(HKABDCNAHLP LCABCKJKMIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x72CA3F0", Offset = "0x72C8DF0", VA = "0x1872CA3F0")]
	public void JAMDCNJOBOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class EJCDGPODEPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly string FMLDLBGKEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly Type HBPPDGBGMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly FGEBNEAFIFB JDBKJHEMBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly HKABDCNAHLP OCJCMPGFHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public MBDGLBINKGD PJKDJGKHCCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public HLGBIHLLJGG HOPIJPFNLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NEBDJMIJCME DKCBPFDGFJI;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x72C9F80", Offset = "0x72C8980", VA = "0x1872C9F80")]
	public EJCDGPODEPA(Type CBDGIGDPDAF, string NONBFLPFCDB, HKABDCNAHLP LCABCKJKMIN, MBDGLBINKGD MGGEANDLBMF, HLGBIHLLJGG DIPJDGFKDIF, NEBDJMIJCME JGNJADJGFBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x72C9E80", Offset = "0x72C8880", VA = "0x1872C9E80")]
	public object AAPPIHDNHOA(object? AIPFCMFLDKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2B23F80", Offset = "0x2B22980", VA = "0x182B23F80")]
	public void MLOJOHFBNGI<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x72C9ED0", Offset = "0x72C88D0", VA = "0x1872C9ED0")]
	public void MLOJOHFBNGI(Type IMDPLCMEKDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class ANDNNFJIKMP<T> : EJCDGPODEPA where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate string LFFGMMGOBGN(T CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal delegate T AHKJBHHFDGP(string? PEDGPIECDAO, T PEMAOEALEHB);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class KNDONOAMHBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public LFFGMMGOBGN serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AHKJBHHFDGP parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public KNDONOAMHBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4393FA0", Offset = "0x43929A0", VA = "0x184393FA0")]
		internal string IPJCNOMAGLI(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4394130", Offset = "0x4392B30", VA = "0x184394130")]
		internal object JAAGGCMJLIL(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3E45760", Offset = "0x3E44160", VA = "0x183E45760")]
	public ANDNNFJIKMP(HKABDCNAHLP LCABCKJKMIN, string NONBFLPFCDB, [Optional] LFFGMMGOBGN? MGGEANDLBMF, [Optional] AHKJBHHFDGP? DIPJDGFKDIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3E44530", Offset = "0x3E42F30", VA = "0x183E44530")]
	private static object? ILDFGHALABA(AHKJBHHFDGP? DIPJDGFKDIF, string? PEDGPIECDAO, object? PEMAOEALEHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3E44B90", Offset = "0x3E43590", VA = "0x183E44B90")]
	private static string LKLOMDOAOHF(LFFGMMGOBGN? PEIJAOGLAGJ, object? CLMKDBDPNNH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate string MBDGLBINKGD(object? CLMKDBDPNNH);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate object HLGBIHLLJGG(string? PEDGPIECDAO, [Optional] object PEMAOEALEHB);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal delegate LNOBMMJOKHG NEBDJMIJCME();
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class JEAPLMHGDFL
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class PEPOFIBIINO : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal static PEPOFIBIINO LPENGNKGBMO;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x72D4E90", Offset = "0x72D3890", VA = "0x1872D4E90", Slot = "4")]
		public bool Equals(List<string> ICJCFEHCALD, List<string> MPEFCGEJLMG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x72D4FE0", Offset = "0x72D39E0", VA = "0x1872D4FE0", Slot = "5")]
		public int GetHashCode(List<string> GIGIFGONEAO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public PEPOFIBIINO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class CJHOJPPOJCL : ELMMJKDIBFA<NBDNFJNDMIP>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x72C8AC0", Offset = "0x72C74C0", VA = "0x1872C8AC0", Slot = "9")]
		public override string LKLOMDOAOHF(NBDNFJNDMIP DKDIADEJLHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x72C88E0", Offset = "0x72C72E0", VA = "0x1872C88E0", Slot = "10")]
		protected override bool KMCOGAHLEAM(string DKDIADEJLHP, [Out] NBDNFJNDMIP CLMKDBDPNNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x72C8BB0", Offset = "0x72C75B0", VA = "0x1872C8BB0")]
		public CJHOJPPOJCL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly GMMEKNAMEHF AFPEFOLCCPM;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly CJHOJPPOJCL OBCFAACBLLG;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly List<EJCDGPODEPA> BPBDFIMGIBM;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<HKABDCNAHLP> AFOFMGOEODB
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<HKABDCNAHLP, EJCDGPODEPA> IFNNAMNMAKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x72CC680", Offset = "0x72CB080", VA = "0x1872CC680")]
	public JEAPLMHGDFL([Optional] IList<EJCDGPODEPA>? BDLMDFEBNEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x72CB180", Offset = "0x72C9B80", VA = "0x1872CB180")]
	public EJCDGPODEPA BJKDDFHLEDL(HKABDCNAHLP LCABCKJKMIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface CNDDJJCBACN
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	BLFNPMILCAM DKICNILNLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class CGKEFMCDBAE : CNDDJJCBACN
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static CGKEFMCDBAE PAPJOFEFLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly LGLMIHGKMDD BKJOAIPGNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal readonly IReadOnlyList<LGLMIHGKMDD> NHEHMAMCLIP;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public BLFNPMILCAM DKICNILNLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x72C87D0", Offset = "0x72C71D0", VA = "0x1872C87D0")]
	public CGKEFMCDBAE(LGLMIHGKMDD MACPEKHIHNB, IReadOnlyList<LGLMIHGKMDD> LNBFENIBFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x72C7990", Offset = "0x72C6390", VA = "0x1872C7990")]
	private static CGKEFMCDBAE GAOMBGMMFBM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class GPEHLGAPHDN
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<LHNNEDFONNE> FIKDILMPBGL;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x72CA0A0", Offset = "0x72C8AA0", VA = "0x1872CA0A0")]
	public static bool NMKJNIINDKK(this PHNOICNFFCM DKLECBNPLDI, LHNNEDFONNE NLNFLDELJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x72CA020", Offset = "0x72C8A20", VA = "0x1872CA020")]
	public static bool EHPMILKAIJD(this PHNOICNFFCM DKLECBNPLDI, LHNNEDFONNE NLNFLDELJJM, OMGLHECGLKD BCIDKOBPOIK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface BJIGOFJCPFC
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool BDIAKCMBMLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool NNLHOJBLNMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool DGGEGEPMPLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool LPIMIFALJPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool NICALPAGJLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool HAEEIANFFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool EAKFFKMMDOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool MPPKEGEGLGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool GPGOCLKHEDM
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool NJIFAPFHHEA
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool EJGOOJLNEGF
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool COKEPICHFDO
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> GHAILHJBIOO
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	NBDNFJNDMIP HKFIAAMFKNF
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface BLFNPMILCAM : BJIGOFJCPFC, MIPNGOBHAOB, CAGLIPHCDPP<HKABDCNAHLP>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string KMKHFLDENDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	LHNNEDFONNE JFHABKIHMGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) HJGBEMBIMDP<T>(HKABDCNAHLP LCABCKJKMIN) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum HKABDCNAHLP
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
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal class LGLMIHGKMDD : BLFNPMILCAM, BJIGOFJCPFC, MIPNGOBHAOB, CAGLIPHCDPP<HKABDCNAHLP>
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	internal static readonly JEAPLMHGDFL OPCHLOIKDGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	internal readonly HODCEDNBGOH CAILADCGGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private string? GNEONHJIDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private string? HAACGOGDKGL;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool OPAPFNHFOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x72CD900", Offset = "0x72CC300", VA = "0x1872CD900", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool IGJCNKNBOEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x72CD670", Offset = "0x72CC070", VA = "0x1872CD670", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool FMMDHOBCFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x72CD760", Offset = "0x72CC160", VA = "0x1872CD760", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool OCEGGLABEEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x72CEE90", Offset = "0x72CD890", VA = "0x1872CEE90", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool MMIJIOIPJCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x72CE370", Offset = "0x72CCD70", VA = "0x1872CE370", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool FMPIMDAOLIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x72CD6C0", Offset = "0x72CC0C0", VA = "0x1872CD6C0", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public LHNNEDFONNE JFHABKIHMGN
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9ECD20", Offset = "0x9EB720", VA = "0x1809ECD20", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(LHNNEDFONNE);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x888E70", Offset = "0x887870", VA = "0x180888E70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string CFBDLCKGDIC
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x72CE8D0", Offset = "0x72CD2D0", VA = "0x1872CE8D0", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x72CE920", Offset = "0x72CD320", VA = "0x1872CE920")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string KMKHFLDENDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x72CE8D0", Offset = "0x72CD2D0", VA = "0x1872CE8D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool PJMJKLEOIND
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9ECCE0", Offset = "0x9EB6E0", VA = "0x1809ECCE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xB66330", Offset = "0xB64D30", VA = "0x180B66330")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool BDIAKCMBMLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x72CE970", Offset = "0x72CD370", VA = "0x1872CE970", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public NBDNFJNDMIP HKFIAAMFKNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x72CEF80", Offset = "0x72CD980", VA = "0x1872CEF80", Slot = "20")]
		get
		{
			return default(NBDNFJNDMIP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool NNLHOJBLNMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x72CE830", Offset = "0x72CD230", VA = "0x1872CE830", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool DGGEGEPMPLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x72CD7B0", Offset = "0x72CC1B0", VA = "0x1872CD7B0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool LPIMIFALJPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x72CE880", Offset = "0x72CD280", VA = "0x1872CE880", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool NICALPAGJLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x72CF0B0", Offset = "0x72CDAB0", VA = "0x1872CF0B0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool HAEEIANFFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x72CEF30", Offset = "0x72CD930", VA = "0x1872CEF30", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool EAKFFKMMDOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x72CEEE0", Offset = "0x72CD8E0", VA = "0x1872CEEE0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool MPPKEGEGLGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x72CD1F0", Offset = "0x72CBBF0", VA = "0x1872CD1F0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool GPGOCLKHEDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x72CD710", Offset = "0x72CC110", VA = "0x1872CD710", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> GHAILHJBIOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x72CEA90", Offset = "0x72CD490", VA = "0x1872CEA90", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool FCOBDKCJECA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x72CD900", Offset = "0x72CC300", VA = "0x1872CD900", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool KBPMNONDAOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x72CE370", Offset = "0x72CCD70", VA = "0x1872CE370", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool IPGHPNLIHON
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x72CD670", Offset = "0x72CC070", VA = "0x1872CD670", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool NJIFAPFHHEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x72CED40", Offset = "0x72CD740", VA = "0x1872CED40", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool EJGOOJLNEGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x72CE2D0", Offset = "0x72CCCD0", VA = "0x1872CE2D0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool AKLIFEHDPEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x72CD760", Offset = "0x72CC160", VA = "0x1872CD760", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool COKEPICHFDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x72CEAF0", Offset = "0x72CD4F0", VA = "0x1872CEAF0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool BIFNLFFOKBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x72CEE90", Offset = "0x72CD890", VA = "0x1872CEE90", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool PONLGKLCOFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x72CD6C0", Offset = "0x72CC0C0", VA = "0x1872CD6C0", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event FDLAPODPKEK<HKABDCNAHLP> DLFMMFEJKMP
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x72CE9C0", Offset = "0x72CD3C0", VA = "0x1872CE9C0", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x72CD5C0", Offset = "0x72CBFC0", VA = "0x1872CD5C0", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2D3D560", Offset = "0x2D3BF60", VA = "0x182D3D560", Slot = "6")]
	public (bool, T?) HJGBEMBIMDP<T>(HKABDCNAHLP LCABCKJKMIN) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2D3D750", Offset = "0x2D3C150", VA = "0x182D3D750")]
	public LGLMIHGKMDD NAFJEHFMPKN<T>(HKABDCNAHLP LCABCKJKMIN, bool HHPFCLGAENN, T CLMKDBDPNNH) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x72CF370", Offset = "0x72CDD70", VA = "0x1872CF370")]
	public LGLMIHGKMDD(LHNNEDFONNE NLNFLDELJJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x72CF2D0", Offset = "0x72CDCD0", VA = "0x1872CF2D0")]
	public LGLMIHGKMDD(LHNNEDFONNE NLNFLDELJJM, [Optional] string? GNEONHJIDFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x72CF2F0", Offset = "0x72CDCF0", VA = "0x1872CF2F0")]
	public LGLMIHGKMDD(LGLMIHGKMDD GMEMGOHKJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x72CF180", Offset = "0x72CDB80", VA = "0x1872CF180")]
	internal LGLMIHGKMDD(LHNNEDFONNE PDPOHLCACJA, [Optional] string? GNEONHJIDFB, [Optional] LGLMIHGKMDD? GMEMGOHKJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x72CD890", Offset = "0x72CC290", VA = "0x1872CD890")]
	public static FGEBNEAFIFB DNGHBNEBBOF(HKABDCNAHLP LCABCKJKMIN)
	{
		return default(FGEBNEAFIFB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x72CEA70", Offset = "0x72CD470", VA = "0x1872CEA70")]
	public void JAMDCNJOBOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x72CD240", Offset = "0x72CBC40", VA = "0x1872CD240")]
	internal LGLMIHGKMDD AHHIJFPODJP(LGLMIHGKMDD BKHDHFLKBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x72CE3C0", Offset = "0x72CCDC0", VA = "0x1872CE3C0")]
	internal IReadOnlyCollection<HKABDCNAHLP> HDIAFBEKCKI(LGLMIHGKMDD GMEMGOHKJJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x72CEFD0", Offset = "0x72CD9D0", VA = "0x1872CEFD0")]
	public bool OBCFBHDCNGN(HKABDCNAHLP LCABCKJKMIN, bool HHPFCLGAENN, string KDCFKLLLCLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x72CED90", Offset = "0x72CD790", VA = "0x1872CED90")]
	public (bool, string) LNOKLHLHLPF(HKABDCNAHLP LCABCKJKMIN)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x72CE320", Offset = "0x72CCD20", VA = "0x1872CE320")]
	internal void GKPMHLBIGNB(HKABDCNAHLP LCABCKJKMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x72CEB40", Offset = "0x72CD540", VA = "0x1872CEB40")]
	public GBGLHKGGIMF KNHGGOECEBA(Func<LHNNEDFONNE, Guid> EEMBDGLLNOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x72CD950", Offset = "0x72CC350", VA = "0x1872CD950")]
	public void GGEBLHCOJIK(GBGLHKGGIMF GDBLHAFAGJK, Func<Guid, LHNNEDFONNE> KEHPMLOBLLE, [Optional] LHNNEDFONNE? BBBHJEPOAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x72CD800", Offset = "0x72CC200", VA = "0x1872CD800")]
	[CompilerGenerated]
	private void DMLBEFJPLMC(HKABDCNAHLP PHOOAAGMFHB, OJFNKKDOJLC PCBHMLNLCJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class NAFDPGPBBIL : CNPMLDCBKKO, LKIOIPGEHOO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class CLJDGEFDCFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public LGLMIHGKMDD newRole;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public CLJDGEFDCFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x72C8BF0", Offset = "0x72C75F0", VA = "0x1872C8BF0")]
		internal bool JLDJBMOGFNL(LGLMIHGKMDD rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class PFOJCMEDOEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public LHNNEDFONNE roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public PFOJCMEDOEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x72D51C0", Offset = "0x72D3BC0", VA = "0x1872D51C0")]
		internal bool OPGGKFBHDKB(LHNNEDFONNE r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct IPMBEGLJBAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public NAFDPGPBBIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public PCBLLGHKJMO roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<JAEBMNICJBL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x72CAAB0", Offset = "0x72C94B0", VA = "0x1872CAAB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x72CB120", Offset = "0x72C9B20", VA = "0x1872CB120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class BKJMDMEKMHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public BKJMDMEKMHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x72C78B0", Offset = "0x72C62B0", VA = "0x1872C78B0")]
		internal void MHIIKGGEIFO(GBGLHKGGIMF r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x72C7790", Offset = "0x72C6190", VA = "0x1872C7790")]
		internal void INDLPLHHNDK(GBGLHKGGIMF r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct NDJDHMOBFCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public PCBLLGHKJMO roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class BBOKAOAJECI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Func<GBGLHKGGIMF, OJFNKKDOJLC> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public BBOKAOAJECI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x72C7730", Offset = "0x72C6130", VA = "0x1872C7730")]
		internal void FGGCFNAMLFF(GBGLHKGGIMF r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x72C7760", Offset = "0x72C6160", VA = "0x1872C7760")]
		internal void OGBMAHPECEI(GBGLHKGGIMF r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x72C7700", Offset = "0x72C6100", VA = "0x1872C7700")]
		internal void FDLGCPJCONB(GBGLHKGGIMF r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class IPOPOOLFDHH<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
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
			public IPOPOOLFDHH<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private TaskAwaiter<JAEBMNICJBL> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x36B2F10", Offset = "0x36B1910", VA = "0x1836B2F10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xB9ACE0", Offset = "0xB996E0", VA = "0x180B9ACE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public HKABDCNAHLP rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public LHNNEDFONNE accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public FGEBNEAFIFB recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public NAFDPGPBBIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public IPOPOOLFDHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x403A890", Offset = "0x4039290", VA = "0x18403A890")]
		[AsyncStateMachine(typeof(IPOPOOLFDHH<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void KNGLFCFCPLK()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct LAMNHHPHEJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public IReadOnlyList<IMHLJNAALLH> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct DEEDOICEODE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public EMAABBKCFLB rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public PCBLLGHKJMO roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public IReadOnlyDictionary<LHNNEDFONNE, LGLMIHGKMDD> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public GFEMHOFJCGN debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x72C8C20", Offset = "0x72C7620", VA = "0x1872C8C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x72C9730", Offset = "0x72C8130", VA = "0x1872C9730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly EMAABBKCFLB AIOJECDDJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly CGKEFMCDBAE HBKNLGGHDDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly GFEMHOFJCGN OOBEMKODKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly Dictionary<int, LGLMIHGKMDD> EAEMELADECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	internal readonly Dictionary<LHNNEDFONNE, LGLMIHGKMDD> IBMHCMIBPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	internal readonly Dictionary<LHNNEDFONNE, LGLMIHGKMDD> KHKPJLLMDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	internal readonly List<LGLMIHGKMDD> GKMNPHPJHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private bool OLCILMDEOJO;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly HKABDCNAHLP[] PLKFPFCMNFJ;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public CNDDJJCBACN IBFJGMEEEOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<BLFNPMILCAM> FJPFCOINEJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x72D3E20", Offset = "0x72D2820", VA = "0x1872D3E20", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event KPEGMNEFAKL DMBFIJIBJCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x72D3D80", Offset = "0x72D2780", VA = "0x1872D3D80", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x72D1C60", Offset = "0x72D0660", VA = "0x1872D1C60", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x72D3440", Offset = "0x72D1E40", VA = "0x1872D3440")]
	[POCMGODEOKB.HFEKBIAFIHM]
	internal static void MEDHEEHHIJF(APIKLLPBEEI PFCFNGPPMDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x72D4AF0", Offset = "0x72D34F0", VA = "0x1872D4AF0")]
	[UnityEngine.Scripting.Preserve]
	internal NAFDPGPBBIL([CNNDHKODGDP(null)] EMAABBKCFLB PNBDIEKHDGA, [CNNDHKODGDP(null)] CGKEFMCDBAE MHIAMMBHKJG, [CNNDHKODGDP(null)] GFEMHOFJCGN OOBEMKODKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x72D13F0", Offset = "0x72CFDF0", VA = "0x1872D13F0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x72D0610", Offset = "0x72CF010", VA = "0x1872D0610")]
	private void CCNJFKNPBJI(IEnumerable<LGLMIHGKMDD> CPJAMMCADON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x72D4110", Offset = "0x72D2B10", VA = "0x1872D4110", Slot = "12")]
	public bool NFGLPIJHEED(PHNOICNFFCM JGEPDBLHLJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x72D1860", Offset = "0x72D0260", VA = "0x1872D1860")]
	private void GDLKMFPJMJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x72CF810", Offset = "0x72CE210", VA = "0x1872CF810")]
	private void BBDEOGMOAED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x72D1D00", Offset = "0x72D0700", VA = "0x1872D1D00", Slot = "10")]
	public IReadOnlyList<BLFNPMILCAM> IEFEGFJODAM(bool OJAPCNHOGIH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x72D2420", Offset = "0x72D0E20", VA = "0x1872D2420", Slot = "11")]
	public BLFNPMILCAM KKLAPICIJIN(PHNOICNFFCM JGEPDBLHLJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x72CF740", Offset = "0x72CE140", VA = "0x1872CF740")]
	private LHNNEDFONNE BAPGADIDHNA(PHNOICNFFCM JGEPDBLHLJG)
	{
		return default(LHNNEDFONNE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x72D1260", Offset = "0x72CFC60", VA = "0x1872D1260", Slot = "14")]
	public bool DODIKEEMELM(PHNOICNFFCM NFAAPJHFELB, LHNNEDFONNE NLNFLDELJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x72D0E80", Offset = "0x72CF880", VA = "0x1872D0E80", Slot = "15")]
	public BLFNPMILCAM CPPEEKGNGEN(LHNNEDFONNE NLNFLDELJJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x72D1500", Offset = "0x72CFF00", VA = "0x1872D1500")]
	private static bool EJDPEMGOEJI(BNCBGFLGEFC NPBGGKJDNJG, LHNNEDFONNE NLNFLDELJJM, [Out] GBGLHKGGIMF? EKBCEGHOKHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x72D01D0", Offset = "0x72CEBD0", VA = "0x1872D01D0")]
	private static void BJGFHKAJDOJ(BNCBGFLGEFC NPBGGKJDNJG, Action<GBGLHKGGIMF> GACAPPJLIFE, LHNNEDFONNE MFNCILIJBEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x72CFF40", Offset = "0x72CE940", VA = "0x1872CFF40")]
	private static void BJGFHKAJDOJ(BNCBGFLGEFC NPBGGKJDNJG, Action<GBGLHKGGIMF> GACAPPJLIFE, Predicate<LHNNEDFONNE> HDPMMCNBLKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x72D2530", Offset = "0x72D0F30", VA = "0x1872D2530")]
	private void KLKKKHBDDKF(PHNOICNFFCM JGEPDBLHLJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x72D2300", Offset = "0x72D0D00", VA = "0x1872D2300", Slot = "4")]
	[AsyncStateMachine(typeof(IPMBEGLJBAH))]
	public Task KEKLBCKPOFH([CanBeNull] PCBLLGHKJMO HMIHKJIKEGE, CancellationToken OGJIGALEPCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
	public void FCGBPIGPNKH(PCBLLGHKJMO HMIHKJIKEGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x72CF390", Offset = "0x72CDD90", VA = "0x1872CF390")]
	private void ANOMMDIOLFG(BNCBGFLGEFC IGCJKOJJFMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x72CFA00", Offset = "0x72CE400", VA = "0x1872CFA00")]
	internal static string BGEKEMCIAAP(EMAABBKCFLB AIOJECDDJCN, PCBLLGHKJMO HMIHKJIKEGE, IReadOnlyDictionary<LHNNEDFONNE, LGLMIHGKMDD> IBMHCMIBPLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x72D26E0", Offset = "0x72D10E0", VA = "0x1872D26E0")]
	private static void KNCGPOFEJDH(PCBLLGHKJMO HMIHKJIKEGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x72D02C0", Offset = "0x72CECC0", VA = "0x1872D02C0")]
	private static void BLMDCHPHLJF(BNCBGFLGEFC GPDEHJJEKLM, IReadOnlyDictionary<LHNNEDFONNE, LGLMIHGKMDD> IBMHCMIBPLK, StringBuilder GHMAJOLLHLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x72D1B50", Offset = "0x72D0550", VA = "0x1872D1B50")]
	private static bool HIBEGJCDOEH(string DCFILFDNHIM, [Out] Guid KBCLIPPLCJB, [Out] LHNNEDFONNE NLNFLDELJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x72D41E0", Offset = "0x72D2BE0", VA = "0x1872D41E0")]
	private static void OFOOLOPHECI(PCBLLGHKJMO HMIHKJIKEGE, StringBuilder GHMAJOLLHLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2DC0D50", Offset = "0x2DBF750", VA = "0x182DC0D50", Slot = "16")]
	public bool BPGGOGJANDO<T>(LHNNEDFONNE NLNFLDELJJM, HKABDCNAHLP LCABCKJKMIN, bool HHPFCLGAENN, T NBIHLDEPEPA, [Optional] Action HCDLLJGCOLJ) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x72CF6D0", Offset = "0x72CE0D0", VA = "0x1872CF6D0", Slot = "17")]
	public string AOPICGAJPPK(HKABDCNAHLP LCABCKJKMIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x72D20F0", Offset = "0x72D0AF0", VA = "0x1872D20F0")]
	private void JHIGGBLKGHJ(LHNNEDFONNE NLNFLDELJJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x72D1840", Offset = "0x72D0240", VA = "0x1872D1840")]
	private bool FCPEELAHEHI(PHNOICNFFCM JGEPDBLHLJG, LHNNEDFONNE NLNFLDELJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x72D0F20", Offset = "0x72CF920", VA = "0x1872D0F20")]
	internal LGLMIHGKMDD DMLAKDIFBHJ(PHNOICNFFCM JGEPDBLHLJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x72D1830", Offset = "0x72D0230", VA = "0x1872D1830", Slot = "13")]
	public IReadOnlyList<BLFNPMILCAM> FACHLBHMEKD(PHNOICNFFCM JGEPDBLHLJG, bool ONDKADGAFIB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x72CFD10", Offset = "0x72CE710", VA = "0x1872CFD10")]
	internal IReadOnlyList<LGLMIHGKMDD> BHHHDMBJILO(PHNOICNFFCM JGEPDBLHLJG, bool ONDKADGAFIB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x72D3600", Offset = "0x72D2000", VA = "0x1872D3600")]
	private void MFKIJLMDIAP(JAEBMNICJBL IFHBANBBHML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x72D1870", Offset = "0x72D0270", VA = "0x1872D1870")]
	private static bool HBHLILDHGJN(LGLMIHGKMDD PLHMLEOBDAO, IReadOnlyDictionary<LHNNEDFONNE, LGLMIHGKMDD> IBMHCMIBPLK, [Out] IReadOnlyList<HKABDCNAHLP> MLIDAGDNNJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x72D25A0", Offset = "0x72D0FA0", VA = "0x1872D25A0")]
	[AsyncStateMachine(typeof(DEEDOICEODE))]
	private static Task KMKOJEELHNG(EMAABBKCFLB AIOJECDDJCN, PCBLLGHKJMO HMIHKJIKEGE, IReadOnlyDictionary<LHNNEDFONNE, LGLMIHGKMDD> IBMHCMIBPLK, GFEMHOFJCGN OOBEMKODKLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x72D3E70", Offset = "0x72D2870", VA = "0x1872D3E70")]
	[CompilerGenerated]
	internal static void NADBHEDPBLC(Func<GBGLHKGGIMF, OJFNKKDOJLC> DGEMGBECFJI, NDJDHMOBFCG P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x72D1D80", Offset = "0x72D0780", VA = "0x1872D1D80")]
	[CompilerGenerated]
	internal static bool INFDDCKDHII(LHNNEDFONNE NLNFLDELJJM, HKABDCNAHLP LCABCKJKMIN, [Out] IMHLJNAALLH MLDACFFDIOI, LAMNHHPHEJD P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface MCGGNHDFKLH
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GLOOFKKKKNK(PHNOICNFFCM JOJLGFJPNCK, PHNOICNFFCM LGBCMMJEJKI, IEnumerable<PHNOICNFFCM> IODAKLGDCBO, [Out] NBDNFJNDMIP OJFAIFLLLGF, [Out] AKKLJGIMFKA GFAINHNOFLP);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string GFINJBBNICG(AKKLJGIMFKA INBLJLNIKFA);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public enum AKKLJGIMFKA : byte
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
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal class KCHGKDFKFJI : MCGGNHDFKLH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly LKIOIPGEHOO NPEIPJIABFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly CBBCENMNKAG FKEMHNBBHOD;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x88B090", Offset = "0x889A90", VA = "0x18088B090")]
	[RecRoom.NoEngine.Common.Preserve]
	public KCHGKDFKFJI([CNNDHKODGDP(null)] LKIOIPGEHOO KMHFHKJPHCA, [CNNDHKODGDP(null)] CBBCENMNKAG LMKOECEFBCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x72CCFB0", Offset = "0x72CB9B0", VA = "0x1872CCFB0")]
	private static GNABJEPCHMO? FNLMKEMPOBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x72CD0F0", Offset = "0x72CBAF0", VA = "0x1872CD0F0", Slot = "4")]
	public bool GLOOFKKKKNK(PHNOICNFFCM JOJLGFJPNCK, PHNOICNFFCM LGBCMMJEJKI, IEnumerable<PHNOICNFFCM> IODAKLGDCBO, [Out] NBDNFJNDMIP OJFAIFLLLGF, [Out] AKKLJGIMFKA GFAINHNOFLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x72CCFF0", Offset = "0x72CB9F0", VA = "0x1872CCFF0", Slot = "5")]
	public string GFINJBBNICG(AKKLJGIMFKA INBLJLNIKFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x72CC9A0", Offset = "0x72CB3A0", VA = "0x1872CC9A0")]
	internal bool FMEGDFKILHM(PHNOICNFFCM JOJLGFJPNCK, PHNOICNFFCM LGBCMMJEJKI, IEnumerable<PHNOICNFFCM> IODAKLGDCBO, OMGLHECGLKD BCIDKOBPOIK, GNABJEPCHMO? PODBJOEKLCI, [Out] NBDNFJNDMIP OJFAIFLLLGF, [Out] AKKLJGIMFKA GFAINHNOFLP)
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
