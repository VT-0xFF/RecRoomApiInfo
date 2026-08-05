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
		[Cpp2IlInjected.Address(RVA = "0x7E3470", Offset = "0x7E2270", VA = "0x1807E3470")]
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
		[Cpp2IlInjected.Address(RVA = "0x66FEAF0", Offset = "0x66FD8F0", VA = "0x1866FEAF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E43F0", Offset = "0x7E31F0", VA = "0x1807E43F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E4430", Offset = "0x7E3230", VA = "0x1807E4430")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum NBPODJFPPMN
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void GFHJOENLCGP<TPermission>(TPermission IDOOMGDKACP);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void GBPMCPFDCJE(MFDHGPCGOEK EOHHOGEBGCB);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum NOKMLLGMHPM
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NLNGPICJBED
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NEOBIGPAHLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool JGHCBBBPMJB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool DBPBPAECOJC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool GHPICHPCDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool DHBEGNPHOKG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool AILEDEIBHMM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class HHHODAGPEHC
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	public enum BELPCNGIHIP
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
	public static readonly Guid AAJIJPIDGOP;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid FEONGGNJNFK;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid KHJLAHIOOGH;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid BGGGADGAEOF;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid KJNKAILKHDL;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid NALGIBOIAJK;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly HFOELOJPMDO<KFANPMEHJHA, Guid> FOAMCLBJALE;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<KFANPMEHJHA> FPFCPEMEBFC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x66FD0E0", Offset = "0x66FBEE0", VA = "0x1866FD0E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x66FCFC0", Offset = "0x66FBDC0", VA = "0x1866FCFC0")]
	public static KFANPMEHJHA DDPFNIGJCGN(Guid MAAFBDMNKAP)
	{
		return default(KFANPMEHJHA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x66FD160", Offset = "0x66FBF60", VA = "0x1866FD160")]
	public static Guid HDNPDIACMIE(KFANPMEHJHA EBACJALPHHL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x66FD050", Offset = "0x66FBE50", VA = "0x1866FD050")]
	public static bool DKMBIHBBMGB(KFANPMEHJHA EBACJALPHHL, [Out] Guid MAAFBDMNKAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x66FD200", Offset = "0x66FC000", VA = "0x1866FD200")]
	public static bool JHNEANPPLPF(Guid MAAFBDMNKAP, [Out] KFANPMEHJHA EBACJALPHHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x66FD390", Offset = "0x66FC190", VA = "0x1866FD390")]
	public static KFANPMEHJHA OPJFMMBCPKD(KFANPMEHJHA EBACJALPHHL)
	{
		return default(KFANPMEHJHA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x66FD2E0", Offset = "0x66FC0E0", VA = "0x1866FD2E0")]
	public static BELPCNGIHIP MNBAGJCBOIP(KFANPMEHJHA BAOMGEHFEFD)
	{
		return default(BELPCNGIHIP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x66FD2A0", Offset = "0x66FC0A0", VA = "0x1866FD2A0")]
	internal static KFANPMEHJHA KAAMINEJOLG(BELPCNGIHIP GBIIFEAGJCF)
	{
		return default(KFANPMEHJHA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface GODIOHLNOEE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	PCKACAEDHIL IACAAEEGDBC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<OJIDDAFHBDD> KFCAOPJELGI
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event GBPMCPFDCJE PLAEJNNDKEF;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<OJIDDAFHBDD> AOKAOIOJJPN(bool PLFJBNEBAKN = false);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OJIDDAFHBDD IGNGOJDEMDH(MFDHGPCGOEK EOHHOGEBGCB);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool EEEHFLFKICI(MFDHGPCGOEK EOHHOGEBGCB);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<OJIDDAFHBDD> AIPHMODLGLD(MFDHGPCGOEK EOHHOGEBGCB, bool KKDCIEJEBHI = false);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HGGCGEFKJKK(MFDHGPCGOEK MPLLDNFBCFG, KFANPMEHJHA EBACJALPHHL);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "9")]
	OJIDDAFHBDD LKMLBKKBPGF(KFANPMEHJHA EBACJALPHHL);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool COMMDCEGNID<T>(KFANPMEHJHA EBACJALPHHL, KDFDJHPMONC IDOOMGDKACP, bool PMIDPBOOGLH, T ILCDOKLHIEO, [Optional] Action DKOGPIPBBNA) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface APFOIDKKMMN
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task BPHFKEMNGOB(KLBAPEHGMHI BHDDKICEAHJ, CancellationToken MBHHHCCHBAO);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LANEMIODJKJ(KLBAPEHGMHI BHDDKICEAHJ);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DGAIJDFGJJL
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	MFDHGPCGOEK HGEDMCEEIHB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	JINOHAHLDHO APBGOIIDFPF
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	OONJOHBNDFD FNAIBGAIPBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<NOAODFKJCLO> CLLNKCEMLLE;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action PFEFLCOPPDF;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KFANPMEHJHA JCAFBOHEADG(MFDHGPCGOEK EOHHOGEBGCB);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<NOAODFKJCLO> BJNLJFLEAMK(CancellationToken MBHHHCCHBAO);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task BFBGFMMHEIH(long GMKNHGGIMFN, long EDBJFNJNPDL, IReadOnlyList<KFLAPAPNPHF> PAHPDJIIFMG);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<MFDHGPCGOEK> ELBKJCDGHBC();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class MENNGLKOGIG
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x66FEA90", Offset = "0x66FD890", VA = "0x1866FEA90")]
	public static KFANPMEHJHA JOABNJAKHLG(this DGAIJDFGJJL NHGOPKJEILG)
	{
		return default(KFANPMEHJHA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface FKLOMLCKGFA<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string KPCDFEKGPHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event GFHJOENLCGP<TPermission> GJDCCCNDFLI;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class JEGMDJAMOPN
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? LHKMMFEBNPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7B8400", Offset = "0x7B7200", VA = "0x1807B8400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7B8190", Offset = "0x7B6F90", VA = "0x1807B8190")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7C8480", Offset = "0x7C7280", VA = "0x1807C8480")]
	protected JEGMDJAMOPN(object? CMBJMEFINCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool GDJLNHCCFPC(object? MAEBFBHFPDE);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class LKIKLLHLJIM<T> : JEGMDJAMOPN where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private T GJDMGAJFNNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly IEqualityComparer<T> JIEAIILGOFG;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T CIONEDGAKHL
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x87B500", Offset = "0x87A300", VA = "0x18087B500")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3C28B40", Offset = "0x3C27940", VA = "0x183C28B40", Slot = "4")]
	public override bool GDJLNHCCFPC(object? MAEBFBHFPDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3C28410", Offset = "0x3C27210", VA = "0x183C28410")]
	public bool CBMHAKGLFON(T JCGNPMHEDHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3C28C40", Offset = "0x3C27A40", VA = "0x183C28C40")]
	public LKIKLLHLJIM(T KKIHKKGMFIE, IEqualityComparer<T> JIEAIILGOFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class PFCODAAKGOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<KDFDJHPMONC, bool> OHPEANDIDDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<KDFDJHPMONC, JEGMDJAMOPN> PPIGMCBCBKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly EECFFLIMDCA CNMIGPKIHOA;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x66FF060", Offset = "0x66FDE60", VA = "0x1866FF060")]
	public PFCODAAKGOK(EECFFLIMDCA CNMIGPKIHOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x66FEE40", Offset = "0x66FDC40", VA = "0x1866FEE40")]
	public bool GHDAFJOLOII(KDFDJHPMONC IDOOMGDKACP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x28AF940", Offset = "0x28AE740", VA = "0x1828AF940")]
	public bool NBBHFBKACJG<T>(KDFDJHPMONC IDOOMGDKACP, bool PMIDPBOOGLH, T MAEBFBHFPDE) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x28AFE50", Offset = "0x28AEC50", VA = "0x1828AFE50")]
	public (bool, T?) OMLOGOMJPGC<T>(KDFDJHPMONC IDOOMGDKACP) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x66FEEB0", Offset = "0x66FDCB0", VA = "0x1866FEEB0")]
	public bool NBBHFBKACJG(KDFDJHPMONC IDOOMGDKACP, bool PMIDPBOOGLH, object MAEBFBHFPDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x66FEF90", Offset = "0x66FDD90", VA = "0x1866FEF90")]
	public (bool, object) OMLOGOMJPGC(KDFDJHPMONC IDOOMGDKACP)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x28AF900", Offset = "0x28AE700", VA = "0x1828AF900")]
	private void EIECGEAMDCO<T>(KDFDJHPMONC IDOOMGDKACP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x66FED70", Offset = "0x66FDB70", VA = "0x1866FED70")]
	private JEGMDJAMOPN FPNKDONPMLB(KDFDJHPMONC IDOOMGDKACP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x66FEB70", Offset = "0x66FD970", VA = "0x1866FEB70")]
	public void EHNJLLIKNEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class GPJCKLOJDLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly string JHLBBBDKLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly Type CEPDNEOHIHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly OGGFPMPBCGI ELDPINNDGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly KDFDJHPMONC HAEHLBLNENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public DABHPEOPLPM FABHDCOEDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public DDPGKPCEIPJ NEHPIHJMKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public HMEKDAMLFHO GMMEOOGOEFH;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x66FC6C0", Offset = "0x66FB4C0", VA = "0x1866FC6C0")]
	public GPJCKLOJDLB(Type PGPBIBMKKKA, string PACPEJHEMJE, KDFDJHPMONC IDOOMGDKACP, DABHPEOPLPM KMJDGOCBADJ, DDPGKPCEIPJ DMJKMAOBAJG, HMEKDAMLFHO DEBJDOBFPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x66FC5C0", Offset = "0x66FB3C0", VA = "0x1866FC5C0")]
	public object AAGGKKAJBLH(object? EDOEJIMPOFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x275D340", Offset = "0x275C140", VA = "0x18275D340")]
	public void EIECGEAMDCO<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x66FC610", Offset = "0x66FB410", VA = "0x1866FC610")]
	public void EIECGEAMDCO(Type HIGNDHGGHMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class PKEBHBADFBF<T> : GPJCKLOJDLB where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string POHKKFJJMLO(T MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T PGIINHFMLEF(string? NGNLKLHNBHH, T KKIHKKGMFIE);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class JFPHMLMAEDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public POHKKFJJMLO serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public PGIINHFMLEF parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public JFPHMLMAEDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3A5AF80", Offset = "0x3A59D80", VA = "0x183A5AF80")]
		internal string PGMNNJIKNNC(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3A5AE40", Offset = "0x3A59C40", VA = "0x183A5AE40")]
		internal object DLBEFDMHBNK(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x40B47F0", Offset = "0x40B35F0", VA = "0x1840B47F0")]
	public PKEBHBADFBF(KDFDJHPMONC IDOOMGDKACP, string PACPEJHEMJE, [Optional] POHKKFJJMLO? KMJDGOCBADJ, [Optional] PGIINHFMLEF? DMJKMAOBAJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x40B39D0", Offset = "0x40B27D0", VA = "0x1840B39D0")]
	private static object? APHAODHFANA(PGIINHFMLEF? DMJKMAOBAJG, string? NGNLKLHNBHH, object? KKIHKKGMFIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x40B3F80", Offset = "0x40B2D80", VA = "0x1840B3F80")]
	private static string CDDFPMJNNJO(POHKKFJJMLO? EKGIANPDFIL, object? MAEBFBHFPDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string DABHPEOPLPM(object? MAEBFBHFPDE);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object DDPGKPCEIPJ(string? NGNLKLHNBHH, [Optional] object KKIHKKGMFIE);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate JEGMDJAMOPN HMEKDAMLFHO();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class EECFFLIMDCA
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class DBFJOLJEJLF : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal static DBFJOLJEJLF ACHMAPLCKNO;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x66F3450", Offset = "0x66F2250", VA = "0x1866F3450", Slot = "4")]
		public bool Equals(List<string> BJKAJHEJDMP, List<string> FPNMMAJHCIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x66F35A0", Offset = "0x66F23A0", VA = "0x1866F35A0", Slot = "5")]
		public int GetHashCode(List<string> KDHDNCADFDJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public DBFJOLJEJLF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class HNAMADPKANH : LLJIDFJMNJP<NBPODJFPPMN>
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x66FD6F0", Offset = "0x66FC4F0", VA = "0x1866FD6F0", Slot = "9")]
		public override string CDDFPMJNNJO(NBPODJFPPMN PMNEDIFJMIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x66FD7E0", Offset = "0x66FC5E0", VA = "0x1866FD7E0", Slot = "10")]
		protected override bool FJIBMKJOLJK(string PMNEDIFJMIN, [Out] NBPODJFPPMN MAEBFBHFPDE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x66FD9C0", Offset = "0x66FC7C0", VA = "0x1866FD9C0")]
		public HNAMADPKANH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly AINFIANNKHJ ADEGHKPOFCD;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly HNAMADPKANH CFIJMGONHMO;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly List<GPJCKLOJDLB> FGFAHBLPJCC;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<KDFDJHPMONC> ABHOIANDHCC
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7B8400", Offset = "0x7B7200", VA = "0x1807B8400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<KDFDJHPMONC, GPJCKLOJDLB> FMECPOEILAA
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x66F4600", Offset = "0x66F3400", VA = "0x1866F4600")]
	public EECFFLIMDCA([Optional] IList<GPJCKLOJDLB>? CPDHCPIGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x66F3790", Offset = "0x66F2590", VA = "0x1866F3790")]
	public GPJCKLOJDLB MLAPCIGLKCH(KDFDJHPMONC IDOOMGDKACP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface PCKACAEDHIL
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	OJIDDAFHBDD NMGCGNNIOEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class JDLCBEOCPIF : PCKACAEDHIL
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static JDLCBEOCPIF KPKONNGNFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly ELJGBHABKHB CNJPKCIODPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal readonly IReadOnlyList<ELJGBHABKHB> HCGOGKLJEAL;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public OJIDDAFHBDD NMGCGNNIOEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7B8400", Offset = "0x7B7200", VA = "0x1807B8400", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x66FE780", Offset = "0x66FD580", VA = "0x1866FE780")]
	public JDLCBEOCPIF(ELJGBHABKHB NHFAHGNAEDF, IReadOnlyList<ELJGBHABKHB> EMJHCAMHNLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x66FDD50", Offset = "0x66FCB50", VA = "0x1866FDD50")]
	private static JDLCBEOCPIF FKCCADFELMM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class JBLIABMEAGD
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<KFANPMEHJHA> CFMDEODGEOJ;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x66FDA40", Offset = "0x66FC840", VA = "0x1866FDA40")]
	public static bool JAIBKEOOEAC(this MFDHGPCGOEK PMCBHBLOBDP, KFANPMEHJHA EBACJALPHHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x66FDB20", Offset = "0x66FC920", VA = "0x1866FDB20")]
	public static bool ONHJENHGOLA(this MFDHGPCGOEK PMCBHBLOBDP, KFANPMEHJHA EBACJALPHHL, OONJOHBNDFD CDPGPPCFPPF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface OLBFCPILIAG
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool IJPPBAHCKBF
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool OBKIOLOLOPO
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool NJFDMKPLIFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool OJLFNKBMPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool KBOHLBJDJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool NONPABFFCCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool JNOFHHKIEAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool CBFEINIKOGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool NAINDKDEJOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool GCMAPINLFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool MHBIDEKMKME
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool GMIPMOEOLEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> JNHFEFCOOHP
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	NBPODJFPPMN CPAJEMPEJDF
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface OJIDDAFHBDD : OLBFCPILIAG, NLNGPICJBED, FKLOMLCKGFA<KDFDJHPMONC>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string BHBENEJBKAM
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	KFANPMEHJHA PHLILNPGNPE
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) DCNHEJFGJOI<T>(KDFDJHPMONC IDOOMGDKACP) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum KDFDJHPMONC
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
internal class ELJGBHABKHB : OJIDDAFHBDD, OLBFCPILIAG, NLNGPICJBED, FKLOMLCKGFA<KDFDJHPMONC>
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal static readonly EECFFLIMDCA AIHGHGPNBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly PFCODAAKGOK EPJJGKDAACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private string? NBBHCNKONFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private string? JCCJHMMOLFC;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool HDEMPMECPCH
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x66F6720", Offset = "0x66F5520", VA = "0x1866F6720", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool CBGGEMBPPGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x66F49A0", Offset = "0x66F37A0", VA = "0x1866F49A0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool LCFFNHGKHJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x66F4950", Offset = "0x66F3750", VA = "0x1866F4950", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool FLGJHMPHLJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x66F4B40", Offset = "0x66F3940", VA = "0x1866F4B40", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool EGILHOIPHIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x66F5740", Offset = "0x66F4540", VA = "0x1866F5740", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool LNMLEFONFNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x66F4AA0", Offset = "0x66F38A0", VA = "0x1866F4AA0", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public KFANPMEHJHA PHLILNPGNPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x87B500", Offset = "0x87A300", VA = "0x18087B500", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(KFANPMEHJHA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7B83F0", Offset = "0x7B71F0", VA = "0x1807B83F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string KPCDFEKGPHL
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x66F6060", Offset = "0x66F4E60", VA = "0x1866F6060", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x66F5600", Offset = "0x66F4400", VA = "0x1866F5600")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string BHBENEJBKAM
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x66F6060", Offset = "0x66F4E60", VA = "0x1866F6060", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool KHFDLLKMBLB
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x85A650", Offset = "0x859450", VA = "0x18085A650")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x85A060", Offset = "0x858E60", VA = "0x18085A060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool IJPPBAHCKBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x66F58F0", Offset = "0x66F46F0", VA = "0x1866F58F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public NBPODJFPPMN CPAJEMPEJDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x66F5650", Offset = "0x66F4450", VA = "0x1866F5650", Slot = "20")]
		get
		{
			return default(NBPODJFPPMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool OBKIOLOLOPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x66F49F0", Offset = "0x66F37F0", VA = "0x1866F49F0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool NJFDMKPLIFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x66F56F0", Offset = "0x66F44F0", VA = "0x1866F56F0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool OJLFNKBMPDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x66F4C30", Offset = "0x66F3A30", VA = "0x1866F4C30", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool KBOHLBJDJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x66F56A0", Offset = "0x66F44A0", VA = "0x1866F56A0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool NONPABFFCCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x66F4AF0", Offset = "0x66F38F0", VA = "0x1866F4AF0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool JNOFHHKIEAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x66F6100", Offset = "0x66F4F00", VA = "0x1866F6100", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool CBFEINIKOGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x66F66D0", Offset = "0x66F54D0", VA = "0x1866F66D0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool NAINDKDEJOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x66F5FC0", Offset = "0x66F4DC0", VA = "0x1866F5FC0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> JNHFEFCOOHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x66F4A40", Offset = "0x66F3840", VA = "0x1866F4A40", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool HEAANEFNDPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x66F6720", Offset = "0x66F5520", VA = "0x1866F6720", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool GEHMCKNBNDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x66F5740", Offset = "0x66F4540", VA = "0x1866F5740", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool OKBKMJDCKPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x66F49A0", Offset = "0x66F37A0", VA = "0x1866F49A0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool GCMAPINLFHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x66F6010", Offset = "0x66F4E10", VA = "0x1866F6010", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool MHBIDEKMKME
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x66F60B0", Offset = "0x66F4EB0", VA = "0x1866F60B0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool JJKGIOKDLKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x66F4950", Offset = "0x66F3750", VA = "0x1866F4950", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool GMIPMOEOLEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x66F5990", Offset = "0x66F4790", VA = "0x1866F5990", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool OALIJGFDDDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x66F4B40", Offset = "0x66F3940", VA = "0x1866F4B40", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool GKADNDEJLIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x66F4AA0", Offset = "0x66F38A0", VA = "0x1866F4AA0", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event GFHJOENLCGP<KDFDJHPMONC> GJDCCCNDFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x66F5790", Offset = "0x66F4590", VA = "0x1866F5790", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x66F5840", Offset = "0x66F4640", VA = "0x1866F5840", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2604410", Offset = "0x2603210", VA = "0x182604410", Slot = "6")]
	public (bool, T?) DCNHEJFGJOI<T>(KDFDJHPMONC IDOOMGDKACP) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x26043D0", Offset = "0x26031D0", VA = "0x1826043D0")]
	public ELJGBHABKHB AACBHENLNNJ<T>(KDFDJHPMONC IDOOMGDKACP, bool PMIDPBOOGLH, T MAEBFBHFPDE) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x66F69B0", Offset = "0x66F57B0", VA = "0x1866F69B0")]
	public ELJGBHABKHB(KFANPMEHJHA EBACJALPHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x66F6900", Offset = "0x66F5700", VA = "0x1866F6900")]
	public ELJGBHABKHB(KFANPMEHJHA EBACJALPHHL, [Optional] string? NBBHCNKONFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x66F6920", Offset = "0x66F5720", VA = "0x1866F6920")]
	public ELJGBHABKHB(ELJGBHABKHB JBAOJCBNLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x66F69D0", Offset = "0x66F57D0", VA = "0x1866F69D0")]
	internal ELJGBHABKHB(KFANPMEHJHA CPPODJAJCNP, [Optional] string? NBBHCNKONFF, [Optional] ELJGBHABKHB? JBAOJCBNLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x66F4B90", Offset = "0x66F3990", VA = "0x1866F4B90")]
	public static OGGFPMPBCGI DCLNHGCBEIN(KDFDJHPMONC IDOOMGDKACP)
	{
		return default(OGGFPMPBCGI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x66F4C10", Offset = "0x66F3A10", VA = "0x1866F4C10")]
	public void EHNJLLIKNEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x66F6350", Offset = "0x66F5150", VA = "0x1866F6350")]
	internal ELJGBHABKHB ODJILNPNAGI(ELJGBHABKHB FMFPIHKIGFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x66F5B50", Offset = "0x66F4950", VA = "0x1866F5B50")]
	internal IReadOnlyCollection<KDFDJHPMONC> LOCLECIGPFG(ELJGBHABKHB JBAOJCBNLLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x66F5A70", Offset = "0x66F4870", VA = "0x1866F5A70")]
	public bool LNMJCDNKHNG(KDFDJHPMONC IDOOMGDKACP, bool PMIDPBOOGLH, string DHJJHNIFHLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x66F6770", Offset = "0x66F5570", VA = "0x1866F6770")]
	public (bool, string) PLEJAJBFGEH(KDFDJHPMONC IDOOMGDKACP)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x66F5940", Offset = "0x66F4740", VA = "0x1866F5940")]
	internal void LBKALCIENFL(KDFDJHPMONC IDOOMGDKACP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x66F6150", Offset = "0x66F4F50", VA = "0x1866F6150")]
	public DOPMNFGEJCK NCGLOEPOHID(Func<KFANPMEHJHA, Guid> IKIPLDCEDCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x66F4C80", Offset = "0x66F3A80", VA = "0x1866F4C80")]
	public void FKFHINCBDPN(DOPMNFGEJCK JFOEAHIKAPN, Func<Guid, KFANPMEHJHA> DMNIDCBIHJJ, [Optional] KFANPMEHJHA? EKPMKLNKPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x66F59E0", Offset = "0x66F47E0", VA = "0x1866F59E0")]
	[CompilerGenerated]
	private void LHDOFDEMACG(KDFDJHPMONC CNNIJPKKKDD, DJLDDNIHGBO FJCPDANDFHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class FMMKLKKKIIG : APFOIDKKMMN, GODIOHLNOEE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class IFBPNGPAPAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public ELJGBHABKHB newRole;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public IFBPNGPAPAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x66FDA00", Offset = "0x66FC800", VA = "0x1866FDA00")]
		internal bool CHMMFFCFJDH(ELJGBHABKHB rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class IKPMIMAHMMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public KFANPMEHJHA roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public IKPMIMAHMMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x66FDA30", Offset = "0x66FC830", VA = "0x1866FDA30")]
		internal bool JIAEKFHJJDK(KFANPMEHJHA r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct BHBNGNAPKII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public FMMKLKKKIIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public KLBAPEHGMHI roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<NOAODFKJCLO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x66F2220", Offset = "0x66F1020", VA = "0x1866F2220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x66F2880", Offset = "0x66F1680", VA = "0x1866F2880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class KFHANKLPFNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public KFHANKLPFNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x66FE9B0", Offset = "0x66FD7B0", VA = "0x1866FE9B0")]
		internal void LGJEEDJLCAP(DOPMNFGEJCK r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x66FE890", Offset = "0x66FD690", VA = "0x1866FE890")]
		internal void JHIIGLNKBMP(DOPMNFGEJCK r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct MKMOJICIICL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public KLBAPEHGMHI roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class PKMHHCCJHFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Func<DOPMNFGEJCK, DJLDDNIHGBO> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public PKMHHCCJHFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x66FF370", Offset = "0x66FE170", VA = "0x1866FF370")]
		internal void OGMDKHEAGHN(DOPMNFGEJCK r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x66FF310", Offset = "0x66FE110", VA = "0x1866FF310")]
		internal void EMDDEFJLHBM(DOPMNFGEJCK r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x66FF340", Offset = "0x66FE140", VA = "0x1866FF340")]
		internal void LPJMCJAJNGC(DOPMNFGEJCK r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class KIGJJPIFMGC<T> where T : notnull
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
			public KIGJJPIFMGC<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private TaskAwaiter<NOAODFKJCLO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x3090E70", Offset = "0x308FC70", VA = "0x183090E70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x999640", Offset = "0x998440", VA = "0x180999640", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public FMMKLKKKIIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public KDFDJHPMONC rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public KFANPMEHJHA accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public OGGFPMPBCGI recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public KIGJJPIFMGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3B20FC0", Offset = "0x3B1FDC0", VA = "0x183B20FC0")]
		[AsyncStateMachine(typeof(KIGJJPIFMGC<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void KILCIEICIJH()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct JJOAIBPBEJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public IReadOnlyList<KFLAPAPNPHF> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct BHCAEDKMFIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public DGAIJDFGJJL rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public KLBAPEHGMHI roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public IReadOnlyDictionary<KFANPMEHJHA, ELJGBHABKHB> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public ABOHMLOCAHI debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x66F28E0", Offset = "0x66F16E0", VA = "0x1866F28E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x66F33F0", Offset = "0x66F21F0", VA = "0x1866F33F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly DGAIJDFGJJL NHGOPKJEILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly JDLCBEOCPIF NJJHMEFBLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly ABOHMLOCAHI OICLMJCIAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, ELJGBHABKHB> CECIBKOALHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	internal readonly Dictionary<KFANPMEHJHA, ELJGBHABKHB> CPJIGEJPNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal readonly Dictionary<KFANPMEHJHA, ELJGBHABKHB> GNHHPFIAEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	internal readonly List<ELJGBHABKHB> FCOONHLGCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool MDPHACKMNKM;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly KDFDJHPMONC[] JGOJEEJLOGB;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public PCKACAEDHIL IACAAEEGDBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<OJIDDAFHBDD> KFCAOPJELGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x66F7420", Offset = "0x66F6220", VA = "0x1866F7420", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event GBPMCPFDCJE PLAEJNNDKEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x66F7900", Offset = "0x66F6700", VA = "0x1866F7900", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x66F8A10", Offset = "0x66F7810", VA = "0x1866F8A10", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x66F9F20", Offset = "0x66F8D20", VA = "0x1866F9F20")]
	[HBAMLEIOGOF(EOCHJKOJDMN.Room, BHCECOANHAK.None)]
	private static void JFKEJFLLBEE(CMADEFPIMOE HJBDMCEIPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x66FC300", Offset = "0x66FB100", VA = "0x1866FC300")]
	[UnityEngine.Scripting.Preserve]
	internal FMMKLKKKIIG([BMAJFBAIDDE(null)] DGAIJDFGJJL EBJMMNOCAAJ, [BMAJFBAIDDE(null)] JDLCBEOCPIF JPICMLJMLML, [BMAJFBAIDDE(null)] ABOHMLOCAHI OICLMJCIAAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x66F7CE0", Offset = "0x66F6AE0", VA = "0x1866F7CE0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x66F9590", Offset = "0x66F8390", VA = "0x1866F9590")]
	private void HNOKDFLHLEM(IEnumerable<ELJGBHABKHB> MIKMEEONFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x66F7DF0", Offset = "0x66F6BF0", VA = "0x1866F7DF0", Slot = "12")]
	public bool EEEHFLFKICI(MFDHGPCGOEK EOHHOGEBGCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x66FB1D0", Offset = "0x66F9FD0", VA = "0x1866FB1D0")]
	private void PFEFLCOPPDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x66F6EE0", Offset = "0x66F5CE0", VA = "0x1866F6EE0")]
	private void BANNJPLKHNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x66F6C30", Offset = "0x66F5A30", VA = "0x1866F6C30", Slot = "10")]
	public IReadOnlyList<OJIDDAFHBDD> AOKAOIOJJPN(bool PLFJBNEBAKN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x66F9E10", Offset = "0x66F8C10", VA = "0x1866F9E10", Slot = "11")]
	public OJIDDAFHBDD IGNGOJDEMDH(MFDHGPCGOEK EOHHOGEBGCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x66F6B50", Offset = "0x66F5950", VA = "0x1866F6B50")]
	private KFANPMEHJHA AEKCGOAPJLL(MFDHGPCGOEK EOHHOGEBGCB)
	{
		return default(KFANPMEHJHA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x66F9400", Offset = "0x66F8200", VA = "0x1866F9400", Slot = "14")]
	public bool HGGCGEFKJKK(MFDHGPCGOEK MPLLDNFBCFG, KFANPMEHJHA EBACJALPHHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x66FA7C0", Offset = "0x66F95C0", VA = "0x1866FA7C0", Slot = "15")]
	public OJIDDAFHBDD LKMLBKKBPGF(KFANPMEHJHA EBACJALPHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x66FA380", Offset = "0x66F9180", VA = "0x1866FA380")]
	private static bool JHCCNBDBMMO(BMMEKCJKMPJ LIDFILOBNIK, KFANPMEHJHA EBACJALPHHL, [Out] DOPMNFGEJCK? GJJEIIKCGLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x66FA860", Offset = "0x66F9660", VA = "0x1866FA860")]
	private static void MFLFFIPNLEN(BMMEKCJKMPJ LIDFILOBNIK, Action<DOPMNFGEJCK> OHCJCDCHCHK, KFANPMEHJHA KHDHHFOKANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x66FA950", Offset = "0x66F9750", VA = "0x1866FA950")]
	private static void MFLFFIPNLEN(BMMEKCJKMPJ LIDFILOBNIK, Action<DOPMNFGEJCK> OHCJCDCHCHK, Predicate<KFANPMEHJHA> JHJGHIOEIAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x66F89A0", Offset = "0x66F77A0", VA = "0x1866F89A0")]
	private void FEJIBAGKMFD(MFDHGPCGOEK EOHHOGEBGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x66F7470", Offset = "0x66F6270", VA = "0x1866F7470", Slot = "4")]
	[AsyncStateMachine(typeof(BHBNGNAPKII))]
	public Task BPHFKEMNGOB([CanBeNull] KLBAPEHGMHI BHDDKICEAHJ, CancellationToken MBHHHCCHBAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "5")]
	public void LANEMIODJKJ(KLBAPEHGMHI BHDDKICEAHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x66F79A0", Offset = "0x66F67A0", VA = "0x1866F79A0")]
	private void DMMGBEOEACL(BMMEKCJKMPJ GOPIKALLGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x66FABE0", Offset = "0x66F99E0", VA = "0x1866FABE0")]
	internal static string NNAPDHCANFE(DGAIJDFGJJL NHGOPKJEILG, KLBAPEHGMHI BHDDKICEAHJ, IReadOnlyDictionary<KFANPMEHJHA, ELJGBHABKHB> CPJIGEJPNIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x66FB320", Offset = "0x66FA120", VA = "0x1866FB320")]
	private static void PJGCDOAKFND(KLBAPEHGMHI BHDDKICEAHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x66F70D0", Offset = "0x66F5ED0", VA = "0x1866F70D0")]
	private static void BHCLDAGDJPO(BMMEKCJKMPJ NEJHOPFJKCI, IReadOnlyDictionary<KFANPMEHJHA, ELJGBHABKHB> CPJIGEJPNIH, StringBuilder AIPANJBJFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x66FA6B0", Offset = "0x66F94B0", VA = "0x1866FA6B0")]
	private static bool KGCKAMHHGIK(string BMPLOCDIKDF, [Out] Guid IDPHJDPIMIN, [Out] KFANPMEHJHA EBACJALPHHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x66F8CC0", Offset = "0x66F7AC0", VA = "0x1866F8CC0")]
	private static void HFLHHPAHHHK(KLBAPEHGMHI BHDDKICEAHJ, StringBuilder AIPANJBJFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2736320", Offset = "0x2735120", VA = "0x182736320", Slot = "16")]
	public bool COMMDCEGNID<T>(KFANPMEHJHA EBACJALPHHL, KDFDJHPMONC IDOOMGDKACP, bool PMIDPBOOGLH, T ILCDOKLHIEO, [Optional] Action DKOGPIPBBNA) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x66F8AB0", Offset = "0x66F78B0", VA = "0x1866F8AB0")]
	private void GNKMLKNNJKE(KFANPMEHJHA EBACJALPHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x66F6B30", Offset = "0x66F5930", VA = "0x1866F6B30")]
	private bool AADOOALBDIE(MFDHGPCGOEK EOHHOGEBGCB, KFANPMEHJHA EBACJALPHHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x66F8650", Offset = "0x66F7450", VA = "0x1866F8650")]
	internal ELJGBHABKHB ENLEFMHKHGC(MFDHGPCGOEK EOHHOGEBGCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x66F6C20", Offset = "0x66F5A20", VA = "0x1866F6C20", Slot = "13")]
	public IReadOnlyList<OJIDDAFHBDD> AIPHMODLGLD(MFDHGPCGOEK EOHHOGEBGCB, bool KKDCIEJEBHI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x66F6CB0", Offset = "0x66F5AB0", VA = "0x1866F6CB0")]
	internal IReadOnlyList<ELJGBHABKHB> APLAPCLJBAL(MFDHGPCGOEK EOHHOGEBGCB, bool KKDCIEJEBHI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x66F7EC0", Offset = "0x66F6CC0", VA = "0x1866F7EC0")]
	private void ENKEGEJOGND(NOAODFKJCLO PPNIJEKDBAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x66FAEE0", Offset = "0x66F9CE0", VA = "0x1866FAEE0")]
	private static bool OGAFOIOHEPC(ELJGBHABKHB PDCGLOJDAOG, IReadOnlyDictionary<KFANPMEHJHA, ELJGBHABKHB> CPJIGEJPNIH, [Out] IReadOnlyList<KDFDJHPMONC> NHJDKFLOEGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x66FB1E0", Offset = "0x66F9FE0", VA = "0x1866FB1E0")]
	[AsyncStateMachine(typeof(BHCAEDKMFIP))]
	private static Task PGKBICAECHH(DGAIJDFGJJL NHGOPKJEILG, KLBAPEHGMHI BHDDKICEAHJ, IReadOnlyDictionary<KFANPMEHJHA, ELJGBHABKHB> CPJIGEJPNIH, ABOHMLOCAHI OICLMJCIAAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x66FA0E0", Offset = "0x66F8EE0", VA = "0x1866FA0E0")]
	[CompilerGenerated]
	internal static void JGHLMGHHEKM(Func<DOPMNFGEJCK, DJLDDNIHGBO> AKKCADBEGNG, MKMOJICIICL P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x66F7590", Offset = "0x66F6390", VA = "0x1866F7590")]
	[CompilerGenerated]
	internal static bool CAHEMMIJPNG(KFANPMEHJHA EBACJALPHHL, KDFDJHPMONC IDOOMGDKACP, [Out] KFLAPAPNPHF DLMJLLPJAGH, JJOAIBPBEJB P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface LALPEFLBLCK
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PDGCBKFBMNM(MFDHGPCGOEK IMHCMIJFPFG, MFDHGPCGOEK DKMIDKLPBFM, IEnumerable<MFDHGPCGOEK> MJBIDDKJGNC, [Out] NBPODJFPPMN FCMBLKNKJEE, [Out] CNPNPJLBECL KEOGMNOPPCK);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string JEOIFHPNPFO(CNPNPJLBECL GFLJAHOPEBO);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum CNPNPJLBECL : byte
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
internal class HFHJMDNNDEG : LALPEFLBLCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly GODIOHLNOEE AOIHIGCNGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly KPEMKCDLBFL HBDJDBBILBO;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7C6440", Offset = "0x7C5240", VA = "0x1807C6440")]
	[RecRoom.NoEngine.Common.Preserve]
	public HFHJMDNNDEG([BMAJFBAIDDE(null)] GODIOHLNOEE NNJAIGKCJKM, [BMAJFBAIDDE(null)] KPEMKCDLBFL LMAOCIGGAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x66FCD80", Offset = "0x66FBB80", VA = "0x1866FCD80")]
	private static LFIDBMBIOHG? CHIMGOLHBNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x66FCEC0", Offset = "0x66FBCC0", VA = "0x1866FCEC0", Slot = "4")]
	public bool PDGCBKFBMNM(MFDHGPCGOEK IMHCMIJFPFG, MFDHGPCGOEK DKMIDKLPBFM, IEnumerable<MFDHGPCGOEK> MJBIDDKJGNC, [Out] NBPODJFPPMN FCMBLKNKJEE, [Out] CNPNPJLBECL KEOGMNOPPCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x66FCDC0", Offset = "0x66FBBC0", VA = "0x1866FCDC0", Slot = "5")]
	public string JEOIFHPNPFO(CNPNPJLBECL GFLJAHOPEBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x66FC760", Offset = "0x66FB560", VA = "0x1866FC760")]
	internal bool AEFEAOJIFDD(MFDHGPCGOEK IMHCMIJFPFG, MFDHGPCGOEK DKMIDKLPBFM, IEnumerable<MFDHGPCGOEK> MJBIDDKJGNC, OONJOHBNDFD CDPGPPCFPPF, LFIDBMBIOHG? DFHNMIPPKJI, [Out] NBPODJFPPMN FCMBLKNKJEE, [Out] CNPNPJLBECL KEOGMNOPPCK)
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
