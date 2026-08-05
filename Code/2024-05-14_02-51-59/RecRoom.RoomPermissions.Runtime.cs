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
		[Cpp2IlInjected.Address(RVA = "0x7EC840", Offset = "0x7EB240", VA = "0x1807EC840")]
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
		[Cpp2IlInjected.Address(RVA = "0x69CC4E0", Offset = "0x69CAEE0", VA = "0x1869CC4E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7ED890", Offset = "0x7EC290", VA = "0x1807ED890")]
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
		[Cpp2IlInjected.Address(RVA = "0x7ED8D0", Offset = "0x7EC2D0", VA = "0x1807ED8D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum KJLLJKGPJFF
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void IPDAPIBGCJE<TPermission>(TPermission MGOENNPNHAP);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void DAJCMMFPMOF(HOPBKANDJCK NHKDHOFEECH);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum OMJNIPFBBFF
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface AGPHEAEECDD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool KEPLLIEDFJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool HPGOOIBPIHP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool KNNHOOHOBIF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool BHGOBPDMJMO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool MDJMIPAJEEM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool OJGJNKJEMAC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class MDEJJLLBGBG
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	public enum DOKDKKEFBHO
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
	public static readonly Guid MOCKHFHEAEI;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid ALPAGLDMGMF;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid DKJDJCHHDMF;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid IENPOCBDLBJ;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid FKHPAJJGJPB;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid KLJKDPGBLIE;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly IPDDJNIOCNG<ODPHDGIGBPN, Guid> FEACIHFAPPI;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<ODPHDGIGBPN> DKIHMHLNJFC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x69C8D70", Offset = "0x69C7770", VA = "0x1869C8D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x69C8BF0", Offset = "0x69C75F0", VA = "0x1869C8BF0")]
	public static ODPHDGIGBPN BKOHKHGLJIL(Guid JHOGCCPFJGM)
	{
		return default(ODPHDGIGBPN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x69C8DF0", Offset = "0x69C77F0", VA = "0x1869C8DF0")]
	public static Guid GICCBEAEPJA(ODPHDGIGBPN ACCMPBMAGLN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x69C8ED0", Offset = "0x69C78D0", VA = "0x1869C8ED0")]
	public static bool PIPCHEKDDPN(ODPHDGIGBPN ACCMPBMAGLN, [Out] Guid JHOGCCPFJGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x69C8F60", Offset = "0x69C7960", VA = "0x1869C8F60")]
	public static bool PJHMKNOGIBO(Guid JHOGCCPFJGM, [Out] ODPHDGIGBPN ACCMPBMAGLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x69C8D30", Offset = "0x69C7730", VA = "0x1869C8D30")]
	public static ODPHDGIGBPN FHHAPCJFGDO(ODPHDGIGBPN ACCMPBMAGLN)
	{
		return default(ODPHDGIGBPN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x69C8C80", Offset = "0x69C7680", VA = "0x1869C8C80")]
	public static DOKDKKEFBHO DNDAAGGFEBD(ODPHDGIGBPN JCNPAAMHKLG)
	{
		return default(DOKDKKEFBHO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x69C8E90", Offset = "0x69C7890", VA = "0x1869C8E90")]
	internal static ODPHDGIGBPN MOOEPKCKJGH(DOKDKKEFBHO AKPHOHEKEGJ)
	{
		return default(ODPHDGIGBPN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FPOFLEBCMBA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	MDFAJLNGMBI POJIFGHKFJC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<FALKDAMMKFM> JHJHPIMDJCI
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event DAJCMMFPMOF MPEEILEBMDN;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<FALKDAMMKFM> EFNNPALMPAD(bool AGNJAIJMFDF = false);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FALKDAMMKFM FCFOCIHBPMP(HOPBKANDJCK NHKDHOFEECH);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool KPLGKAIHEDA(HOPBKANDJCK NHKDHOFEECH);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<FALKDAMMKFM> DLJIIEADHFE(HOPBKANDJCK NHKDHOFEECH, bool FMOAMJBMCEN = false);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool BCKKMBAMIEG(HOPBKANDJCK HHOLDKFECDM, ODPHDGIGBPN ACCMPBMAGLN);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "9")]
	FALKDAMMKFM DCHICCEOEOF(ODPHDGIGBPN ACCMPBMAGLN);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool EDCPHJNDILE<T>(ODPHDGIGBPN ACCMPBMAGLN, AFIEMBDLOBM MGOENNPNHAP, bool FDABICEIMIL, T CMMMKFHDFNK, [Optional] Action KJLPMLNGBGB) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HDINBMGENPH
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task DEAPBCOFFKB(KDPHGEEOLAK GOGGOGGMFEP, CancellationToken CFAFANOFDNJ);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BIENPCEOHHI(KDPHGEEOLAK GOGGOGGMFEP);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface GEIAAIBCJOD
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	HOPBKANDJCK IEMCFKMHIEN
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	MAHIACGDFOP EFPMEHOFNMG
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	ECLKAFGMDKO NHCDNOAMMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<OMBPBDENNOJ> DLLHNDMKJMF;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action DILEMHNIEPF;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ODPHDGIGBPN OINGCOCBHIP(HOPBKANDJCK NHKDHOFEECH);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<OMBPBDENNOJ> NGBLLPMKLKE(CancellationToken CFAFANOFDNJ);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task MCJNACIDFKK(long ECEDKLNOLLD, long ADPGIJLEEII, IReadOnlyList<MOICBMOAFHC> HECLMNFLMAA);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<HOPBKANDJCK> OCBHOCPCMFH();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class AFNOCPFAAJK
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x69C4CA0", Offset = "0x69C36A0", VA = "0x1869C4CA0")]
	public static ODPHDGIGBPN HFDJHMNALBP(this GEIAAIBCJOD FFBJAKJJLEH)
	{
		return default(ODPHDGIGBPN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface JPBEIKIDCJH<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string COBCOHJHLPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event IPDAPIBGCJE<TPermission> CEBLJJAPCIP;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class DKMCCHMAIII
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? NHLPKECFIKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7C4FA0", Offset = "0x7C39A0", VA = "0x1807C4FA0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F10", Offset = "0x7D0910", VA = "0x1807D1F10")]
	protected DKMCCHMAIII(object? MMGKCOOGAJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool GNMEDHKABHJ(object? AEJBOLFACJC);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class ANJKEIBINPH<T> : DKMCCHMAIII where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private T DLPDFLLGKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly IEqualityComparer<T> HBDIIEEEMDN;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T DPMGLPAKGNP
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x860540", Offset = "0x85EF40", VA = "0x180860540")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x397E6D0", Offset = "0x397D0D0", VA = "0x18397E6D0", Slot = "4")]
	public override bool GNMEDHKABHJ(object? AEJBOLFACJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x397E0D0", Offset = "0x397CAD0", VA = "0x18397E0D0")]
	public bool BNKODJKOBLF(T DEBBMIEEAJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x397E910", Offset = "0x397D310", VA = "0x18397E910")]
	public ANJKEIBINPH(T LFANPJOLHJB, IEqualityComparer<T> HBDIIEEEMDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class MEJKHLAMFMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<AFIEMBDLOBM, bool> BAIHGACPFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<AFIEMBDLOBM, DKMCCHMAIII> BBICMMDIJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly BOAGHCOKLNJ HHDIMCDIGLN;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x69C9800", Offset = "0x69C8200", VA = "0x1869C9800")]
	public MEJKHLAMFMM(BOAGHCOKLNJ HHDIMCDIGLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x69C9320", Offset = "0x69C7D20", VA = "0x1869C9320")]
	public bool EDFAHDJDINF(AFIEMBDLOBM MGOENNPNHAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2A1ED70", Offset = "0x2A1D770", VA = "0x182A1ED70")]
	public bool NEPGHCKMCIJ<T>(AFIEMBDLOBM MGOENNPNHAP, bool FDABICEIMIL, T AEJBOLFACJC) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2A1E9A0", Offset = "0x2A1D3A0", VA = "0x182A1E9A0")]
	public (bool, T?) GBABDANKHAN<T>(AFIEMBDLOBM MGOENNPNHAP) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x69C9460", Offset = "0x69C7E60", VA = "0x1869C9460")]
	public bool NEPGHCKMCIJ(AFIEMBDLOBM MGOENNPNHAP, bool FDABICEIMIL, object AEJBOLFACJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x69C9390", Offset = "0x69C7D90", VA = "0x1869C9390")]
	public (bool, object) GBABDANKHAN(AFIEMBDLOBM MGOENNPNHAP)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2A1E960", Offset = "0x2A1D360", VA = "0x182A1E960")]
	private void CDMBIPDBOKD<T>(AFIEMBDLOBM MGOENNPNHAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x69C9540", Offset = "0x69C7F40", VA = "0x1869C9540")]
	private DKMCCHMAIII ODOJIMMLLOC(AFIEMBDLOBM MGOENNPNHAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x69C9610", Offset = "0x69C8010", VA = "0x1869C9610")]
	public void POAMHHODDNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class ELNNOKHALNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly string BMEHLGDELKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly Type DIDIBFMCEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly CNEGNGJAOHN JNHCFIFKEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly AFIEMBDLOBM CIOIJPFJLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public PMCNAMMDLIF BNGEKBMCOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public FCPMJHIEKNH ENLJFDJKFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public JCHGCOALKDD PNAJFFPLEON;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x69C73A0", Offset = "0x69C5DA0", VA = "0x1869C73A0")]
	public ELNNOKHALNH(Type FGCIDAPCBAE, string HICAJHCCFKD, AFIEMBDLOBM MGOENNPNHAP, PMCNAMMDLIF JGHJINNLMEM, FCPMJHIEKNH IHCFINFEAIE, JCHGCOALKDD LNNMPLCMPJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x69C7350", Offset = "0x69C5D50", VA = "0x1869C7350")]
	public object KBOBAPNAKEA(object? HKMMPHJFKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x280DA50", Offset = "0x280C450", VA = "0x18280DA50")]
	public void CDMBIPDBOKD<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x69C72A0", Offset = "0x69C5CA0", VA = "0x1869C72A0")]
	public void CDMBIPDBOKD(Type DILGCEMDFAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class CJDPNHCKLPH<T> : ELNNOKHALNH where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string BLPIKFPMAKL(T AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T BAGJOEFFKPJ(string? JEMEEGEMDNL, T LFANPJOLHJB);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class GEJHKNEOOJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public BLPIKFPMAKL serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public BAGJOEFFKPJ parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public GEJHKNEOOJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3962010", Offset = "0x3960A10", VA = "0x183962010")]
		internal string HEGCCNDNBKB(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3961F80", Offset = "0x3960980", VA = "0x183961F80")]
		internal object DJCJOGMCJBM(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4B9BB70", Offset = "0x4B9A570", VA = "0x184B9BB70")]
	public CJDPNHCKLPH(AFIEMBDLOBM MGOENNPNHAP, string HICAJHCCFKD, [Optional] BLPIKFPMAKL? JGHJINNLMEM, [Optional] BAGJOEFFKPJ? IHCFINFEAIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4B9B580", Offset = "0x4B99F80", VA = "0x184B9B580")]
	private static object? HIBHLHEFCGJ(BAGJOEFFKPJ? IHCFINFEAIE, string? JEMEEGEMDNL, object? LFANPJOLHJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4B9AAB0", Offset = "0x4B994B0", VA = "0x184B9AAB0")]
	private static string BOALAEMEPIG(BLPIKFPMAKL? EGFNCEOIFBE, object? AEJBOLFACJC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string PMCNAMMDLIF(object? AEJBOLFACJC);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object FCPMJHIEKNH(string? JEMEEGEMDNL, [Optional] object LFANPJOLHJB);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate DKMCCHMAIII JCHGCOALKDD();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class BOAGHCOKLNJ
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class OMMFHLBJCNO : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal static OMMFHLBJCNO AINFBDJPIJL;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x69CC560", Offset = "0x69CAF60", VA = "0x1869CC560", Slot = "4")]
		public bool Equals(List<string> HMCMBMJNNLE, List<string> EGPNAKGBGLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x69CC6B0", Offset = "0x69CB0B0", VA = "0x1869CC6B0", Slot = "5")]
		public int GetHashCode(List<string> COMOOAEHALC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public OMMFHLBJCNO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class HBFIFAMALJK : LPJFBOIGLJL<KJLLJKGPJFF>
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x69C7440", Offset = "0x69C5E40", VA = "0x1869C7440", Slot = "9")]
		public override string BOALAEMEPIG(KJLLJKGPJFF KAPFFOPPBJF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x69C7530", Offset = "0x69C5F30", VA = "0x1869C7530", Slot = "10")]
		protected override bool LAGIPCGMCKJ(string KAPFFOPPBJF, [Out] KJLLJKGPJFF AEJBOLFACJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x69C7710", Offset = "0x69C6110", VA = "0x1869C7710")]
		public HBFIFAMALJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly EPNNAADOFAI OEBIMNIFINE;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly HBFIFAMALJK ADHDAMGPKNG;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly List<ELNNOKHALNH> HACCKMDFNNO;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<AFIEMBDLOBM> NBIHFNDJFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<AFIEMBDLOBM, ELNNOKHALNH> DPMJOMHMPBB
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x69C63D0", Offset = "0x69C4DD0", VA = "0x1869C63D0")]
	public BOAGHCOKLNJ([Optional] IList<ELNNOKHALNH>? DPIIBOIGHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x69C4F00", Offset = "0x69C3900", VA = "0x1869C4F00")]
	public ELNNOKHALNH JBLMBKHPFMO(AFIEMBDLOBM MGOENNPNHAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface MDFAJLNGMBI
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	FALKDAMMKFM OMNIPDFABJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class LNCLLDKHMCJ : MDFAJLNGMBI
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static LNCLLDKHMCJ NECDHBNAKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly MOBEBJILJED FNFJDENHMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal readonly IReadOnlyList<MOBEBJILJED> KKFKONNPNEJ;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public FALKDAMMKFM OMNIPDFABJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x69C8AE0", Offset = "0x69C74E0", VA = "0x1869C8AE0")]
	public LNCLLDKHMCJ(MOBEBJILJED HKKGGCLMKJH, IReadOnlyList<MOBEBJILJED> MMHIJMGFAPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x69C7EE0", Offset = "0x69C68E0", VA = "0x1869C7EE0")]
	private static LNCLLDKHMCJ DHJHBHOHLDF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class PBEFNHPCFML
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<ODPHDGIGBPN> JCKGEPEEOPH;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x69CC8A0", Offset = "0x69CB2A0", VA = "0x1869CC8A0")]
	public static bool IKKCHKIBDKB(this HOPBKANDJCK JJDFAIKPBCK, ODPHDGIGBPN ACCMPBMAGLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x69CC980", Offset = "0x69CB380", VA = "0x1869CC980")]
	public static bool PBILHCJIBCM(this HOPBKANDJCK JJDFAIKPBCK, ODPHDGIGBPN ACCMPBMAGLN, ECLKAFGMDKO FGFOLAOIHAC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface LHOHGJMDOAP
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool BMADEHNFABI
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool KPNCABGJGMG
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool IHAPJHLPAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool EBOKPILALOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool HJGJCBBGMII
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool ANOKICGPHFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool DHCAMNBCFMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool LLLEMJJOFLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool CDEJGOEMHOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool PIFPFOLEBHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool IDAOCDOPICD
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool LIBAPMNNKEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> JNAHJKFDBML
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	KJLLJKGPJFF DIJAIFCGHDP
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface FALKDAMMKFM : LHOHGJMDOAP, AGPHEAEECDD, JPBEIKIDCJH<AFIEMBDLOBM>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string NAMLJOHCNBL
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	ODPHDGIGBPN MANEINJNEPL
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) GLLGJOFJDFJ<T>(AFIEMBDLOBM MGOENNPNHAP) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum AFIEMBDLOBM
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
internal class MOBEBJILJED : FALKDAMMKFM, LHOHGJMDOAP, AGPHEAEECDD, JPBEIKIDCJH<AFIEMBDLOBM>
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal static readonly BOAGHCOKLNJ PDJDKEHFFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly MEJKHLAMFMM HHLFMAMMLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private string? ECCAKBDEJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private string? PNNELNLINME;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool KOELDAJNLDM
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x69CAD20", Offset = "0x69C9720", VA = "0x1869CAD20", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool AANIAICELBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x69CB9B0", Offset = "0x69CA3B0", VA = "0x1869CB9B0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool HALEMFOHOEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x69CAD70", Offset = "0x69C9770", VA = "0x1869CAD70", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool KGJIAOAFAFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x69CA300", Offset = "0x69C8D00", VA = "0x1869CA300", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool FINKGOPBJGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x69CADC0", Offset = "0x69C97C0", VA = "0x1869CADC0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool NFFPBJDCMJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x69CB490", Offset = "0x69C9E90", VA = "0x1869CB490", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public ODPHDGIGBPN MANEINJNEPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x860540", Offset = "0x85EF40", VA = "0x180860540", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(ODPHDGIGBPN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D40", Offset = "0x7C3740", VA = "0x1807C4D40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string COBCOHJHLPL
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x69CBA00", Offset = "0x69CA400", VA = "0x1869CBA00", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x69CC110", Offset = "0x69CAB10", VA = "0x1869CC110")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string NAMLJOHCNBL
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x69CBA00", Offset = "0x69CA400", VA = "0x1869CBA00", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool JGMAAJJKBKO
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8A9600", Offset = "0x8A8000", VA = "0x1808A9600")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8A8F80", Offset = "0x8A7980", VA = "0x1808A8F80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool BMADEHNFABI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x69CB960", Offset = "0x69CA360", VA = "0x1869CB960", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public KJLLJKGPJFF DIJAIFCGHDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x69CBAA0", Offset = "0x69CA4A0", VA = "0x1869CBAA0", Slot = "20")]
		get
		{
			return default(KJLLJKGPJFF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool KPNCABGJGMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x69CAFF0", Offset = "0x69C99F0", VA = "0x1869CAFF0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool IHAPJHLPAJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x69CBBA0", Offset = "0x69CA5A0", VA = "0x1869CBBA0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool EBOKPILALOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x69CC1B0", Offset = "0x69CABB0", VA = "0x1869CC1B0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool HJGJCBBGMII
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x69CACD0", Offset = "0x69C96D0", VA = "0x1869CACD0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool ANOKICGPHFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x69CB910", Offset = "0x69CA310", VA = "0x1869CB910", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool DHCAMNBCFMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x69CB4E0", Offset = "0x69C9EE0", VA = "0x1869CB4E0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool LLLEMJJOFLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x69CB530", Offset = "0x69C9F30", VA = "0x1869CB530", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool CDEJGOEMHOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x69CC160", Offset = "0x69CAB60", VA = "0x1869CC160", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> JNAHJKFDBML
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x69CB580", Offset = "0x69C9F80", VA = "0x1869CB580", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool IEPALHCIJMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x69CAD20", Offset = "0x69C9720", VA = "0x1869CAD20", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool PBMJEIOAPBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x69CADC0", Offset = "0x69C97C0", VA = "0x1869CADC0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool NFJBLCOICKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x69CB9B0", Offset = "0x69CA3B0", VA = "0x1869CB9B0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool PIFPFOLEBHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x69CBA50", Offset = "0x69CA450", VA = "0x1869CBA50", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool IDAOCDOPICD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x69CB0C0", Offset = "0x69C9AC0", VA = "0x1869CB0C0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool EFLOGDLNFBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x69CAD70", Offset = "0x69C9770", VA = "0x1869CAD70", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool LIBAPMNNKEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x69CB830", Offset = "0x69CA230", VA = "0x1869CB830", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool NLJHKHFEKJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x69CA300", Offset = "0x69C8D00", VA = "0x1869CA300", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool FBAJPLIBION
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x69CB490", Offset = "0x69C9E90", VA = "0x1869CB490", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event IPDAPIBGCJE<AFIEMBDLOBM> CEBLJJAPCIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x69CBBF0", Offset = "0x69CA5F0", VA = "0x1869CBBF0", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x69CBAF0", Offset = "0x69CA4F0", VA = "0x1869CBAF0", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2A27C00", Offset = "0x2A26600", VA = "0x182A27C00", Slot = "6")]
	public (bool, T?) GLLGJOFJDFJ<T>(AFIEMBDLOBM MGOENNPNHAP) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2A27D90", Offset = "0x2A26790", VA = "0x182A27D90")]
	public MOBEBJILJED OAEJLEJDDIP<T>(AFIEMBDLOBM MGOENNPNHAP, bool FDABICEIMIL, T AEJBOLFACJC) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x69CC4C0", Offset = "0x69CAEC0", VA = "0x1869CC4C0")]
	public MOBEBJILJED(ODPHDGIGBPN ACCMPBMAGLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x69CC410", Offset = "0x69CAE10", VA = "0x1869CC410")]
	public MOBEBJILJED(ODPHDGIGBPN ACCMPBMAGLN, [Optional] string? ECCAKBDEJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x69CC430", Offset = "0x69CAE30", VA = "0x1869CC430")]
	public MOBEBJILJED(MOBEBJILJED CBGBGKPKIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x69CC2B0", Offset = "0x69CACB0", VA = "0x1869CC2B0")]
	internal MOBEBJILJED(ODPHDGIGBPN LPDEMMLPAPL, [Optional] string? ECCAKBDEJIO, [Optional] MOBEBJILJED? CBGBGKPKIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x69CB040", Offset = "0x69C9A40", VA = "0x1869CB040")]
	public static CNEGNGJAOHN DLFIICLFALF(AFIEMBDLOBM MGOENNPNHAP)
	{
		return default(CNEGNGJAOHN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x69CC200", Offset = "0x69CAC00", VA = "0x1869CC200")]
	public void POAMHHODDNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x69CB110", Offset = "0x69C9B10", VA = "0x1869CB110")]
	internal MOBEBJILJED FDALFDMHPEH(MOBEBJILJED JDNBAFELBDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x69CBCA0", Offset = "0x69CA6A0", VA = "0x1869CBCA0")]
	internal IReadOnlyCollection<AFIEMBDLOBM> NEBOBDLOGAK(MOBEBJILJED CBGBGKPKIKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x69CAE10", Offset = "0x69C9810", VA = "0x1869CAE10")]
	public bool CLDCAPCHDKP(AFIEMBDLOBM MGOENNPNHAP, bool FDABICEIMIL, string INIANKBFMIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x69CAEF0", Offset = "0x69C98F0", VA = "0x1869CAEF0")]
	public (bool, string) DKJBNGKAHIB(AFIEMBDLOBM MGOENNPNHAP)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x69CB7E0", Offset = "0x69CA1E0", VA = "0x1869CB7E0")]
	internal void IHNCNDJEOBC(AFIEMBDLOBM MGOENNPNHAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x69CB5E0", Offset = "0x69C9FE0", VA = "0x1869CB5E0")]
	public NELOBFIAIDK HLKBGNAMOCJ(Func<ODPHDGIGBPN, Guid> MIEKFDOLEGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x69CA350", Offset = "0x69C8D50", VA = "0x1869CA350")]
	public void AMKMEDLBOJN(NELOBFIAIDK MOHPKEEBBEA, Func<Guid, ODPHDGIGBPN> GCOJDIINDKH, [Optional] ODPHDGIGBPN? PGHNLKJBNGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x69CB880", Offset = "0x69CA280", VA = "0x1869CB880")]
	[CompilerGenerated]
	private void JDNHIPJCHMF(AFIEMBDLOBM OANBCDPALAC, FIKBBFPDFED LEEAJEABDBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class AFGIGJKJJEJ : HDINBMGENPH, FPOFLEBCMBA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class KCAPEFLFPHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public MOBEBJILJED newRole;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public KCAPEFLFPHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x69C77E0", Offset = "0x69C61E0", VA = "0x1869C77E0")]
		internal bool IDCNBAGKAHG(MOBEBJILJED rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class ELBDEIEOMOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public ODPHDGIGBPN roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public ELBDEIEOMOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x69C7290", Offset = "0x69C5C90", VA = "0x1869C7290")]
		internal bool HJKAOJKALGB(ODPHDGIGBPN r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct KCODELEELBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AFGIGJKJJEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public KDPHGEEOLAK roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<OMBPBDENNOJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x69C7810", Offset = "0x69C6210", VA = "0x1869C7810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x69C7E80", Offset = "0x69C6880", VA = "0x1869C7E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class ALFPCFEGCIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public ALFPCFEGCIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x69C4E20", Offset = "0x69C3820", VA = "0x1869C4E20")]
		internal void IDIPNNOPAMC(NELOBFIAIDK r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x69C4D00", Offset = "0x69C3700", VA = "0x1869C4D00")]
		internal void DNNLOENJEEB(NELOBFIAIDK r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct LFFJHBGNGEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public KDPHGEEOLAK roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class JAFIEDNDNNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Func<NELOBFIAIDK, FIKBBFPDFED> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public JAFIEDNDNNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x69C77B0", Offset = "0x69C61B0", VA = "0x1869C77B0")]
		internal void PGMIIONKHHH(NELOBFIAIDK r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x69C7750", Offset = "0x69C6150", VA = "0x1869C7750")]
		internal void IMGFJDACNFE(NELOBFIAIDK r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x69C7780", Offset = "0x69C6180", VA = "0x1869C7780")]
		internal void MKOMMDBLNEC(NELOBFIAIDK r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class EBLBBBCPFNL<T> where T : notnull
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
			public EBLBBBCPFNL<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private TaskAwaiter<OMBPBDENNOJ> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x32CAA00", Offset = "0x32C9400", VA = "0x1832CAA00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x8B2120", Offset = "0x8B0B20", VA = "0x1808B2120", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public AFGIGJKJJEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public AFIEMBDLOBM rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public ODPHDGIGBPN accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public CNEGNGJAOHN recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public EBLBBBCPFNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x34D3090", Offset = "0x34D1A90", VA = "0x1834D3090")]
		[AsyncStateMachine(typeof(EBLBBBCPFNL<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void FDNAHHLJLGB()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct IFLCDPHJLLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public IReadOnlyList<MOICBMOAFHC> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct DMIFHKFGIIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public GEIAAIBCJOD rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public KDPHGEEOLAK roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public IReadOnlyDictionary<ODPHDGIGBPN, MOBEBJILJED> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public KMDJJDLOPBI debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x69C6720", Offset = "0x69C5120", VA = "0x1869C6720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x69C7230", Offset = "0x69C5C30", VA = "0x1869C7230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly GEIAAIBCJOD FFBJAKJJLEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly LNCLLDKHMCJ EFKIOGBBLCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly KMDJJDLOPBI HILDBFOHDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, MOBEBJILJED> OAKPKOKKPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	internal readonly Dictionary<ODPHDGIGBPN, MOBEBJILJED> KAJGLLNGEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal readonly Dictionary<ODPHDGIGBPN, MOBEBJILJED> PKPIFNMHAFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	internal readonly List<MOBEBJILJED> KNPLAGDLBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool NLHGOHMAOPE;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly AFIEMBDLOBM[] HPCCFIFIOKK;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public MDFAJLNGMBI POJIFGHKFJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<FALKDAMMKFM> JHJHPIMDJCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x69C47C0", Offset = "0x69C31C0", VA = "0x1869C47C0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event DAJCMMFPMOF MPEEILEBMDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x69BFA70", Offset = "0x69BE470", VA = "0x1869BFA70", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x69C32D0", Offset = "0x69C1CD0", VA = "0x1869C32D0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x69C19F0", Offset = "0x69C03F0", VA = "0x1869C19F0")]
	[JCOMPLNHMEG(EEKBGOJGGBC.Room, AOHDMBIABEL.None)]
	private static void GHEMDLAGGBM(ICKBMMGCCPN AIGNNHACHNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x69C49E0", Offset = "0x69C33E0", VA = "0x1869C49E0")]
	[UnityEngine.Scripting.Preserve]
	internal AFGIGJKJJEJ([JDJLHBHAJCP(null)] GEIAAIBCJOD JJPIMIAAIGF, [JDJLHBHAJCP(null)] LNCLLDKHMCJ FNIPLPNMOOF, [JDJLHBHAJCP(null)] KMDJJDLOPBI HILDBFOHDJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x69C0790", Offset = "0x69BF190", VA = "0x1869C0790", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x69C3BC0", Offset = "0x69C25C0", VA = "0x1869C3BC0")]
	private void NBBDOEDHBMB(IEnumerable<MOBEBJILJED> IPIKNNGHIEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x69C36A0", Offset = "0x69C20A0", VA = "0x1869C36A0", Slot = "12")]
	public bool KPLGKAIHEDA(HOPBKANDJCK NHKDHOFEECH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x69C0770", Offset = "0x69BF170", VA = "0x1869C0770")]
	private void DILEMHNIEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x69C1050", Offset = "0x69BFA50", VA = "0x1869C1050")]
	private void FHNHMDGOMJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x69C0C20", Offset = "0x69BF620", VA = "0x1869C0C20", Slot = "10")]
	public IReadOnlyList<FALKDAMMKFM> EFNNPALMPAD(bool AGNJAIJMFDF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x69C0F40", Offset = "0x69BF940", VA = "0x1869C0F40", Slot = "11")]
	public FALKDAMMKFM FCFOCIHBPMP(HOPBKANDJCK NHKDHOFEECH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x69BF180", Offset = "0x69BDB80", VA = "0x1869BF180")]
	private ODPHDGIGBPN ABPIMJGCGME(HOPBKANDJCK NHKDHOFEECH)
	{
		return default(ODPHDGIGBPN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x69BF6D0", Offset = "0x69BE0D0", VA = "0x1869BF6D0", Slot = "14")]
	public bool BCKKMBAMIEG(HOPBKANDJCK HHOLDKFECDM, ODPHDGIGBPN ACCMPBMAGLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x69C02A0", Offset = "0x69BECA0", VA = "0x1869C02A0", Slot = "15")]
	public FALKDAMMKFM DCHICCEOEOF(ODPHDGIGBPN ACCMPBMAGLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x69C3370", Offset = "0x69C1D70", VA = "0x1869C3370")]
	private static bool JDLABGPFIAF(HGIEIKPKJJI AMMJOHECCDL, ODPHDGIGBPN ACCMPBMAGLN, [Out] NELOBFIAIDK? DFGPCMKAFNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x69C08A0", Offset = "0x69BF2A0", VA = "0x1869C08A0")]
	private static void EDPLAMJFKNL(HGIEIKPKJJI AMMJOHECCDL, Action<NELOBFIAIDK> JJAKLPKFHDF, ODPHDGIGBPN IDLIDGIMGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x69C0990", Offset = "0x69BF390", VA = "0x1869C0990")]
	private static void EDPLAMJFKNL(HGIEIKPKJJI AMMJOHECCDL, Action<NELOBFIAIDK> JJAKLPKFHDF, Predicate<ODPHDGIGBPN> GFOAEGBMCAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x69C1980", Offset = "0x69C0380", VA = "0x1869C1980")]
	private void FOGBIHDLIHD(HOPBKANDJCK NHKDHOFEECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x69C0340", Offset = "0x69BED40", VA = "0x1869C0340", Slot = "4")]
	[AsyncStateMachine(typeof(KCODELEELBN))]
	public Task DEAPBCOFFKB([CanBeNull] KDPHGEEOLAK GOGGOGGMFEP, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "5")]
	public void BIENPCEOHHI(KDPHGEEOLAK GOGGOGGMFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x69BF250", Offset = "0x69BDC50", VA = "0x1869BF250")]
	private void APHJFJIEOFM(HGIEIKPKJJI DHCHJGNMFOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x69C0460", Offset = "0x69BEE60", VA = "0x1869C0460")]
	internal static string DHAFOOLHDHK(GEIAAIBCJOD FFBJAKJJLEH, KDPHGEEOLAK GOGGOGGMFEP, IReadOnlyDictionary<ODPHDGIGBPN, MOBEBJILJED> KAJGLLNGEIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x69C1DE0", Offset = "0x69C07E0", VA = "0x1869C1DE0")]
	private static void HBGFCMPAAJG(KDPHGEEOLAK GOGGOGGMFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x69C2C10", Offset = "0x69C1610", VA = "0x1869C2C10")]
	private static void IIBJGOHMBPP(HGIEIKPKJJI NCDDBOJBKLE, IReadOnlyDictionary<ODPHDGIGBPN, MOBEBJILJED> KAJGLLNGEIN, StringBuilder DKGGPGGHAHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x69C3770", Offset = "0x69C2170", VA = "0x1869C3770")]
	private static bool LILFAAIPMLJ(string FBBJGCIAPLG, [Out] Guid HNKNIHHGAKB, [Out] ODPHDGIGBPN ACCMPBMAGLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x69C1240", Offset = "0x69BFC40", VA = "0x1869C1240")]
	private static void FIGPELBGNNP(KDPHGEEOLAK GOGGOGGMFEP, StringBuilder DKGGPGGHAHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2F71A20", Offset = "0x2F70420", VA = "0x182F71A20", Slot = "16")]
	public bool EDCPHJNDILE<T>(ODPHDGIGBPN ACCMPBMAGLN, AFIEMBDLOBM MGOENNPNHAP, bool FDABICEIMIL, T CMMMKFHDFNK, [Optional] Action KJLPMLNGBGB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x69BF860", Offset = "0x69BE260", VA = "0x1869BF860")]
	private void BGILDCDBKCJ(ODPHDGIGBPN ACCMPBMAGLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x69C47A0", Offset = "0x69C31A0", VA = "0x1869C47A0")]
	private bool NLNGIFOKLPP(HOPBKANDJCK NHKDHOFEECH, ODPHDGIGBPN ACCMPBMAGLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x69C3880", Offset = "0x69C2280", VA = "0x1869C3880")]
	internal MOBEBJILJED MPIEMKMFNNJ(HOPBKANDJCK NHKDHOFEECH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x69C0780", Offset = "0x69BF180", VA = "0x1869C0780", Slot = "13")]
	public IReadOnlyList<FALKDAMMKFM> DLJIIEADHFE(HOPBKANDJCK NHKDHOFEECH, bool FMOAMJBMCEN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x69C1BB0", Offset = "0x69C05B0", VA = "0x1869C1BB0")]
	internal IReadOnlyList<MOBEBJILJED> GKJEMFGJMAG(HOPBKANDJCK NHKDHOFEECH, bool FMOAMJBMCEN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x69BFB10", Offset = "0x69BE510", VA = "0x1869BFB10")]
	private void DCDDEKBHAKO(OMBPBDENNOJ AKMMHBBNIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x69C44C0", Offset = "0x69C2EC0", VA = "0x1869C44C0")]
	private static bool NGOCLEEAFNE(MOBEBJILJED BLCDLGNGGEG, IReadOnlyDictionary<ODPHDGIGBPN, MOBEBJILJED> KAJGLLNGEIN, [Out] IReadOnlyList<AFIEMBDLOBM> NIAPIOFFJFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x69BF590", Offset = "0x69BDF90", VA = "0x1869BF590")]
	[AsyncStateMachine(typeof(DMIFHKFGIIK))]
	private static Task BBEKILICMKM(GEIAAIBCJOD FFBJAKJJLEH, KDPHGEEOLAK GOGGOGGMFEP, IReadOnlyDictionary<ODPHDGIGBPN, MOBEBJILJED> KAJGLLNGEIN, KMDJJDLOPBI HILDBFOHDJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x69C0CA0", Offset = "0x69BF6A0", VA = "0x1869C0CA0")]
	[CompilerGenerated]
	internal static void ELDPJAKOJMF(Func<NELOBFIAIDK, FIKBBFPDFED> KEJNDMPJGIE, LFFJHBGNGEA P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x69C2F60", Offset = "0x69C1960", VA = "0x1869C2F60")]
	[CompilerGenerated]
	internal static bool IPEACKNJKMJ(ODPHDGIGBPN ACCMPBMAGLN, AFIEMBDLOBM MGOENNPNHAP, [Out] MOICBMOAFHC GJOKKBKPLIO, IFLCDPHJLLG P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface FOFDPNOBKJF
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HEOMIFBOJJC(HOPBKANDJCK LGAAKIBKCNJ, HOPBKANDJCK FGGHDJLNJCP, IEnumerable<HOPBKANDJCK> JHPIMMIDFGN, [Out] KJLLJKGPJFF ICBOFCHCFOJ, [Out] LNNPCIFPBHD FOMMOOOMGLP);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string JICLKFAGBBI(LNNPCIFPBHD POCMGPGBNIP);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum LNNPCIFPBHD : byte
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
internal class MJNPBFCHBJM : FOFDPNOBKJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly FPOFLEBCMBA GDGKOHOJEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly GJHDEJHIEJP FJKMMNOOHKD;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7D18F0", Offset = "0x7D02F0", VA = "0x1807D18F0")]
	[RecRoom.NoEngine.Common.Preserve]
	public MJNPBFCHBJM([JDJLHBHAJCP(null)] FPOFLEBCMBA DDFGHLIODHN, [JDJLHBHAJCP(null)] GJHDEJHIEJP BCHDBDACEIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x69C9BB0", Offset = "0x69C85B0", VA = "0x1869C9BB0")]
	private static HMFDENAIHPJ? IHNJOBFGAIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x69C9AB0", Offset = "0x69C84B0", VA = "0x1869C9AB0", Slot = "4")]
	public bool HEOMIFBOJJC(HOPBKANDJCK LGAAKIBKCNJ, HOPBKANDJCK FGGHDJLNJCP, IEnumerable<HOPBKANDJCK> JHPIMMIDFGN, [Out] KJLLJKGPJFF ICBOFCHCFOJ, [Out] LNNPCIFPBHD FOMMOOOMGLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x69C9BF0", Offset = "0x69C85F0", VA = "0x1869C9BF0", Slot = "5")]
	public string JICLKFAGBBI(LNNPCIFPBHD POCMGPGBNIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x69C9CF0", Offset = "0x69C86F0", VA = "0x1869C9CF0")]
	internal bool NKOOOLMGHLK(HOPBKANDJCK LGAAKIBKCNJ, HOPBKANDJCK FGGHDJLNJCP, IEnumerable<HOPBKANDJCK> JHPIMMIDFGN, ECLKAFGMDKO FGFOLAOIHAC, HMFDENAIHPJ? KDGIBEMHIKL, [Out] KJLLJKGPJFF ICBOFCHCFOJ, [Out] LNNPCIFPBHD FOMMOOOMGLP)
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
