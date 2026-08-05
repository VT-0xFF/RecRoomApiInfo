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
		[Cpp2IlInjected.Address(RVA = "0x7E7D80", Offset = "0x7E7180", VA = "0x1807E7D80")]
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
		[Cpp2IlInjected.Address(RVA = "0x68189C0", Offset = "0x6817DC0", VA = "0x1868189C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E8560", Offset = "0x7E7960", VA = "0x1807E8560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E85A0", Offset = "0x7E79A0", VA = "0x1807E85A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum KEPJAGHMADO
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void ALJLHCCHOEA<TPermission>(TPermission BCLIONLDECF);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void NFHPOIMDMHL(MKFCBDEMMMH MLFPIJHNEAA);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum BAFKEGNKFJH
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface OPLENHAFCMK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool ABDKKFJNANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool JHCNBDPFJFH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool LGCMDMDJDIM
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool DFMLMBEHKCL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool HKNDLHNCMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool EHOFFLIAFJP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class DPHOIIKIJEA
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	public enum NJLHJPJJJBK
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
	public static readonly Guid EIILGONIECC;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid FANBGFGNGHK;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid AIFOIIEEMHK;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid DOBGFKGIPEG;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid OJMNDDDAAGG;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid HCGEHBCCLFE;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly IEMJAHMMLCE<PPEKJCECPND, Guid> OAEJMIELEEL;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<PPEKJCECPND> PJJILDLFDNC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x680C1B0", Offset = "0x680B5B0", VA = "0x18680C1B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x680C300", Offset = "0x680B700", VA = "0x18680C300")]
	public static PPEKJCECPND KDLIDEPJKJL(Guid GFLAAGJEJNJ)
	{
		return default(PPEKJCECPND);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x680C390", Offset = "0x680B790", VA = "0x18680C390")]
	public static Guid PBDKAGAGBMJ(PPEKJCECPND HOKKABPNFHF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x680C230", Offset = "0x680B630", VA = "0x18680C230")]
	public static bool HPDGCCCKEEP(PPEKJCECPND HOKKABPNFHF, [Out] Guid GFLAAGJEJNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x680C0D0", Offset = "0x680B4D0", VA = "0x18680C0D0")]
	public static bool EDDMBDJIHPL(Guid GFLAAGJEJNJ, [Out] PPEKJCECPND HOKKABPNFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x680C170", Offset = "0x680B570", VA = "0x18680C170")]
	public static PPEKJCECPND EIDBFAIGGBE(PPEKJCECPND HOKKABPNFHF)
	{
		return default(PPEKJCECPND);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x680C020", Offset = "0x680B420", VA = "0x18680C020")]
	public static NJLHJPJJJBK DKBMLLPGHGG(PPEKJCECPND OCDNIKDFLLD)
	{
		return default(NJLHJPJJJBK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x680C2C0", Offset = "0x680B6C0", VA = "0x18680C2C0")]
	internal static PPEKJCECPND IJKIDFACFAO(NJLHJPJJJBK BGHFIKLOLNM)
	{
		return default(PPEKJCECPND);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NGPDHPHJGAO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	ANLCMFPANOA DOOBHKDEJHP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<LKAPBODFNHI> FECCKEMNEJO
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event NFHPOIMDMHL OHEJCNCEKFM;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<LKAPBODFNHI> OPCMAEINIAN(bool IFKLHHOIMEB = false);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LKAPBODFNHI KFEHGJJIJFA(MKFCBDEMMMH MLFPIJHNEAA);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NGIGLDGJLDG(MKFCBDEMMMH MLFPIJHNEAA);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<LKAPBODFNHI> MCFIGMFPCFI(MKFCBDEMMMH MLFPIJHNEAA, bool LNGCLEEFPLI = false);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool JMGFBOEBNNL(MKFCBDEMMMH NFMBIJFNCHH, PPEKJCECPND HOKKABPNFHF);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "9")]
	LKAPBODFNHI OPMABHJDPGL(PPEKJCECPND HOKKABPNFHF);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool ELIPHFPBPBK<T>(PPEKJCECPND HOKKABPNFHF, OJPOAKJDIJM BCLIONLDECF, bool PJOEKOCIAGP, T PBBNOGAMKJE, [Optional] Action CDOEKFKOMNE) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JHGLHNENCMO
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PBPIFAODGLD(DFCHLNBLLMO HADHNEGDEKF, CancellationToken KNKAEBKAEBM);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FGCEDLILCHL(DFCHLNBLLMO HADHNEGDEKF);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FEILDIEPJOA
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	MKFCBDEMMMH FMIBLLPPOKM
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	DHOCBLKANBD MFFCBMCMILI
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	DAFHOICEHFC NKCMOMDLDPC
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<KOLLHLBDFIC> ENFBFNNAGKF;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action CEECKGGHHBL;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PPEKJCECPND EPMKGIALNGL(MKFCBDEMMMH MLFPIJHNEAA);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<KOLLHLBDFIC> PMJBEENDIPE(CancellationToken KNKAEBKAEBM);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task KMODIDHPMPN(long NIJFNKBIOIC, long LFGAFDMLOJL, IReadOnlyList<LOOBACILBIJ> AMICJLMBNMC);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<MKFCBDEMMMH> MDLAOBMKDFB();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class DDOLPNMNCKO
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x680BF30", Offset = "0x680B330", VA = "0x18680BF30")]
	public static PPEKJCECPND OMNHLOOOAHL(this FEILDIEPJOA BJEMNJOJFIC)
	{
		return default(PPEKJCECPND);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface MOKMEHPGCFO<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string FFHBHOECCKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event ALJLHCCHOEA<TPermission> FBMCBAIMPGA;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class OFABOHNHHDH
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? ODNODAAELAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A50", Offset = "0x7BFE50", VA = "0x1807C0A50")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5D0", Offset = "0x7C99D0", VA = "0x1807CA5D0")]
	protected OFABOHNHHDH(object? DBKGLGCJDBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool IEOJFHFJBJL(object? PCGOHCLJAPN);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class OOJPFPAFHHA<T> : OFABOHNHHDH where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private T GKOAPHPANDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly IEqualityComparer<T> BBCPKHJJCDG;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T EIHNEEOMIED
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x827D00", Offset = "0x827100", VA = "0x180827D00")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4101560", Offset = "0x4100960", VA = "0x184101560", Slot = "4")]
	public override bool IEOJFHFJBJL(object? PCGOHCLJAPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4101250", Offset = "0x4100650", VA = "0x184101250")]
	public bool HCNFJMJANIF(T MJDDFPFJBOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4101930", Offset = "0x4100D30", VA = "0x184101930")]
	public OOJPFPAFHHA(T DADBDDPBLHB, IEqualityComparer<T> BBCPKHJJCDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class KOLOHIIJCCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<OJPOAKJDIJM, bool> MPBLLPAGEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<OJPOAKJDIJM, OFABOHNHHDH> BKDBDOPAHAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly NCJGOMMMAGC ECDJNEOAAJM;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x680FFF0", Offset = "0x680F3F0", VA = "0x18680FFF0")]
	public KOLOHIIJCCE(NCJGOMMMAGC ECDJNEOAAJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x680FF80", Offset = "0x680F380", VA = "0x18680FF80")]
	public bool OLFLMFBJHLO(OJPOAKJDIJM BCLIONLDECF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x28807D0", Offset = "0x287FBD0", VA = "0x1828807D0")]
	public bool AELAIHCHKFC<T>(OJPOAKJDIJM BCLIONLDECF, bool PJOEKOCIAGP, T PCGOHCLJAPN) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2880CE0", Offset = "0x28800E0", VA = "0x182880CE0")]
	public (bool, T?) HPOALGHJGAB<T>(OJPOAKJDIJM BCLIONLDECF) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x680FB00", Offset = "0x680EF00", VA = "0x18680FB00")]
	public bool AELAIHCHKFC(OJPOAKJDIJM BCLIONLDECF, bool PJOEKOCIAGP, object PCGOHCLJAPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x680FDE0", Offset = "0x680F1E0", VA = "0x18680FDE0")]
	public (bool, object) HPOALGHJGAB(OJPOAKJDIJM BCLIONLDECF)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x28810B0", Offset = "0x28804B0", VA = "0x1828810B0")]
	private void ILGDOCOOPIP<T>(OJPOAKJDIJM BCLIONLDECF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x680FEB0", Offset = "0x680F2B0", VA = "0x18680FEB0")]
	private OFABOHNHHDH KCJNBCCGMHF(OJPOAKJDIJM BCLIONLDECF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x680FBE0", Offset = "0x680EFE0", VA = "0x18680FBE0")]
	public void GHBBHACLJHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class ABIIJNJMAPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly string BJPOHEIDEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly Type KGEPLFLNMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IGPIFNNAGNB DDOCLFCCMNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly OJPOAKJDIJM BINJIECMBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public HAFDLLMKNHJ MJFBBNIBGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NIOPILNCIPB FALPLJLMJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public JFHCEEJBIEB IMLJJFAEHDE;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x680B980", Offset = "0x680AD80", VA = "0x18680B980")]
	public ABIIJNJMAPO(Type BBOFJPAPAKN, string DLJMCMIEOLA, OJPOAKJDIJM BCLIONLDECF, HAFDLLMKNHJ BMDIGNPEHJE, NIOPILNCIPB PGFJDANBIHI, JFHCEEJBIEB EJMJHABMCAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x680B930", Offset = "0x680AD30", VA = "0x18680B930")]
	public object KPNKIHNAOAI(object? MGDPHHCBMMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2DA84D0", Offset = "0x2DA78D0", VA = "0x182DA84D0")]
	public void ILGDOCOOPIP<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x680B880", Offset = "0x680AC80", VA = "0x18680B880")]
	public void ILGDOCOOPIP(Type MEAKKAEFNFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class FOEAEEJDGNK<T> : ABIIJNJMAPO where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string FJHAINPCALJ(T PCGOHCLJAPN);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T IEJCICHCLFI(string? COGEGJGAENB, T DADBDDPBLHB);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class PAAIPCGAPLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public FJHAINPCALJ serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public IEJCICHCLFI parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public PAAIPCGAPLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x41919F0", Offset = "0x4190DF0", VA = "0x1841919F0")]
		internal string LHNBKEHCNOJ(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4191950", Offset = "0x4190D50", VA = "0x184191950")]
		internal object KDPDPGLADGC(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3706400", Offset = "0x3705800", VA = "0x183706400")]
	public FOEAEEJDGNK(OJPOAKJDIJM BCLIONLDECF, string DLJMCMIEOLA, [Optional] FJHAINPCALJ? BMDIGNPEHJE, [Optional] IEJCICHCLFI? PGFJDANBIHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x37052B0", Offset = "0x37046B0", VA = "0x1837052B0")]
	private static object? CMCHCKHHIFC(IEJCICHCLFI? PGFJDANBIHI, string? COGEGJGAENB, object? DADBDDPBLHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3705AE0", Offset = "0x3704EE0", VA = "0x183705AE0")]
	private static string HBIMCCJEPGN(FJHAINPCALJ? ONCJFAJDAJF, object? PCGOHCLJAPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string HAFDLLMKNHJ(object? PCGOHCLJAPN);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object NIOPILNCIPB(string? COGEGJGAENB, [Optional] object DADBDDPBLHB);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate OFABOHNHHDH JFHCEEJBIEB();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class NCJGOMMMAGC
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class EAABHOIPAMA : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal static EAABHOIPAMA GDCHCCJBKDM;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x680C750", Offset = "0x680BB50", VA = "0x18680C750", Slot = "4")]
		public bool Equals(List<string> LCKGOLLEJPE, List<string> OHIBEIOBHMK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x680C8A0", Offset = "0x680BCA0", VA = "0x18680C8A0", Slot = "5")]
		public int GetHashCode(List<string> LIKEKIACGIL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public EAABHOIPAMA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class BLOPNHNFHOA : FAIILNNOOMO<KEPJAGHMADO>
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x680BE00", Offset = "0x680B200", VA = "0x18680BE00", Slot = "9")]
		public override string HBIMCCJEPGN(KEPJAGHMADO CIBLPGDHGMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x680BC20", Offset = "0x680B020", VA = "0x18680BC20", Slot = "10")]
		protected override bool AJOIEMOLKOG(string CIBLPGDHGMJ, [Out] KEPJAGHMADO PCGOHCLJAPN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x680BEF0", Offset = "0x680B2F0", VA = "0x18680BEF0")]
		public BLOPNHNFHOA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly FMFAGJLFIJF HIMEMIHENCF;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly BLOPNHNFHOA FLFNLEGBCKI;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly List<ABIIJNJMAPO> OLOAJOPGGBG;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<OJPOAKJDIJM> BNHLKBFCFJL
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<OJPOAKJDIJM, ABIIJNJMAPO> FJIJBDAFAPO
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6818670", Offset = "0x6817A70", VA = "0x186818670")]
	public NCJGOMMMAGC([Optional] IList<ABIIJNJMAPO>? HAPGPFOKLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6817800", Offset = "0x6816C00", VA = "0x186817800")]
	public ABIIJNJMAPO ELEBONBNEHA(OJPOAKJDIJM BCLIONLDECF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface ANLCMFPANOA
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	LKAPBODFNHI NMNOKJJOHLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class GLPLGLLKCHP : ANLCMFPANOA
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static GLPLGLLKCHP FEMOIICGEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly HFDFBFKBKAN OAGOKKFKNEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal readonly IReadOnlyList<HFDFBFKBKAN> PAJCDICHOIA;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public LKAPBODFNHI NMNOKJJOHLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x680D4F0", Offset = "0x680C8F0", VA = "0x18680D4F0")]
	public GLPLGLLKCHP(HFDFBFKBKAN AKBNJHAOENA, IReadOnlyList<HFDFBFKBKAN> OAJPEIMFOLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x680CAC0", Offset = "0x680BEC0", VA = "0x18680CAC0")]
	private static GLPLGLLKCHP CMMNGKMILCH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class GMDOAJCMCFD
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<PPEKJCECPND> BCOKECABIGA;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x680D600", Offset = "0x680CA00", VA = "0x18680D600")]
	public static bool IHEDHLLIIMI(this MKFCBDEMMMH PFIBGBIOJOF, PPEKJCECPND HOKKABPNFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x680D6E0", Offset = "0x680CAE0", VA = "0x18680D6E0")]
	public static bool PJHNHJMIMCD(this MKFCBDEMMMH PFIBGBIOJOF, PPEKJCECPND HOKKABPNFHF, DAFHOICEHFC MBNPDJACMNH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface DBGCFNDILAA
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool OLPNOHOGNPM
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool LJGKPGAJAHB
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool GKIBJIIHLMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool PBOMLFFMBOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool JPIJHFEAGFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool AIDBCPOFPBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool KMHMGEMELBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool AIEHMDPHGKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool EFLIMLMMPGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool IHCGFOKHFGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool JJJNHLFILJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool KCDCHCPBJOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> IAGBEPKALED
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	KEPJAGHMADO KDCKEMIPJDA
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface LKAPBODFNHI : DBGCFNDILAA, OPLENHAFCMK, MOKMEHPGCFO<OJPOAKJDIJM>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string EOKLHOAAEEI
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	PPEKJCECPND CNIELDKFEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) ELKCKNBNIHN<T>(OJPOAKJDIJM BCLIONLDECF) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum OJPOAKJDIJM
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
internal class HFDFBFKBKAN : LKAPBODFNHI, DBGCFNDILAA, OPLENHAFCMK, MOKMEHPGCFO<OJPOAKJDIJM>
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal static readonly NCJGOMMMAGC HCLDBCHDOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly KOLOHIIJCCE GFDMHGJINGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private string? HLEMCABOFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private string? PJHIKBPDHBO;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool LHMAOHELAHO
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x680E8F0", Offset = "0x680DCF0", VA = "0x18680E8F0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool DFMNKGNGAHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x680DAA0", Offset = "0x680CEA0", VA = "0x18680DAA0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool KLEACAMNOBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x680DAF0", Offset = "0x680CEF0", VA = "0x18680DAF0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool PBPCILGOIIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x680DA50", Offset = "0x680CE50", VA = "0x18680DA50", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool NGKBJALFGCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x680D960", Offset = "0x680CD60", VA = "0x18680D960", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool GOCEJOBNHJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x680E9E0", Offset = "0x680DDE0", VA = "0x18680E9E0", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public PPEKJCECPND CNIELDKFEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x827D00", Offset = "0x827100", VA = "0x180827D00", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(PPEKJCECPND);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7CBD20", Offset = "0x7CB120", VA = "0x1807CBD20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string FFHBHOECCKA
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x680E940", Offset = "0x680DD40", VA = "0x18680E940", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x680F190", Offset = "0x680E590", VA = "0x18680F190")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string EOKLHOAAEEI
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x680E940", Offset = "0x680DD40", VA = "0x18680E940", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool HBHHLBLMOBK
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x87B900", Offset = "0x87AD00", VA = "0x18087B900")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x87AE90", Offset = "0x87A290", VA = "0x18087AE90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool OLPNOHOGNPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x680F480", Offset = "0x680E880", VA = "0x18680F480", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public KEPJAGHMADO KDCKEMIPJDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x680F350", Offset = "0x680E750", VA = "0x18680F350", Slot = "20")]
		get
		{
			return default(KEPJAGHMADO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool LJGKPGAJAHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x680F300", Offset = "0x680E700", VA = "0x18680F300", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool GKIBJIIHLMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x680DA00", Offset = "0x680CE00", VA = "0x18680DA00", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool PBOMLFFMBOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x680F2B0", Offset = "0x680E6B0", VA = "0x18680F2B0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool JPIJHFEAGFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x680D910", Offset = "0x680CD10", VA = "0x18680D910", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool AIDBCPOFPBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x680D9B0", Offset = "0x680CDB0", VA = "0x18680D9B0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool KMHMGEMELBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x680EF60", Offset = "0x680E360", VA = "0x18680EF60", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool AIEHMDPHGKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x680F260", Offset = "0x680E660", VA = "0x18680F260", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool EFLIMLMMPGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x680EF10", Offset = "0x680E310", VA = "0x18680EF10", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> IAGBEPKALED
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x680F720", Offset = "0x680EB20", VA = "0x18680F720", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool COALBEDDOBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x680E8F0", Offset = "0x680DCF0", VA = "0x18680E8F0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool PBJCMFNLBNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x680D960", Offset = "0x680CD60", VA = "0x18680D960", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool PBOCEFMNDNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x680DAA0", Offset = "0x680CEA0", VA = "0x18680DAA0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool IHCGFOKHFGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x680E990", Offset = "0x680DD90", VA = "0x18680E990", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool JJJNHLFILJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x680EA30", Offset = "0x680DE30", VA = "0x18680EA30", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool INEFGPEBLHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x680DAF0", Offset = "0x680CEF0", VA = "0x18680DAF0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool KCDCHCPBJOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x680EFB0", Offset = "0x680E3B0", VA = "0x18680EFB0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool ONENHHOLBLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x680DA50", Offset = "0x680CE50", VA = "0x18680DA50", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool PKKCKOCKCEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x680E9E0", Offset = "0x680DDE0", VA = "0x18680E9E0", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event ALJLHCCHOEA<OJPOAKJDIJM> FBMCBAIMPGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x680E4C0", Offset = "0x680D8C0", VA = "0x18680E4C0", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x680F780", Offset = "0x680EB80", VA = "0x18680F780", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x27F96F0", Offset = "0x27F8AF0", VA = "0x1827F96F0", Slot = "6")]
	public (bool, T?) ELKCKNBNIHN<T>(OJPOAKJDIJM BCLIONLDECF) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x27F96B0", Offset = "0x27F8AB0", VA = "0x1827F96B0")]
	public HFDFBFKBKAN BCBDMOEDEFC<T>(OJPOAKJDIJM BCLIONLDECF, bool PJOEKOCIAGP, T PCGOHCLJAPN) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x680F8C0", Offset = "0x680ECC0", VA = "0x18680F8C0")]
	public HFDFBFKBKAN(PPEKJCECPND HOKKABPNFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x680F8E0", Offset = "0x680ECE0", VA = "0x18680F8E0")]
	public HFDFBFKBKAN(PPEKJCECPND HOKKABPNFHF, [Optional] string? HLEMCABOFJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x680F900", Offset = "0x680ED00", VA = "0x18680F900")]
	public HFDFBFKBKAN(HFDFBFKBKAN JONLPDJLONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x680F990", Offset = "0x680ED90", VA = "0x18680F990")]
	internal HFDFBFKBKAN(PPEKJCECPND MPNEBKBIJDI, [Optional] string? HLEMCABOFJF, [Optional] HFDFBFKBKAN? JONLPDJLONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x680F1E0", Offset = "0x680E5E0", VA = "0x18680F1E0")]
	public static IGPIFNNAGNB IIBNJDGIGDE(OJPOAKJDIJM BCLIONLDECF)
	{
		return default(IGPIFNNAGNB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x680EEF0", Offset = "0x680E2F0", VA = "0x18680EEF0")]
	public void GHBBHACLJHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x680E570", Offset = "0x680D970", VA = "0x18680E570")]
	internal HFDFBFKBKAN EGACBDEDBIJ(HFDFBFKBKAN EDOLBOLOJJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x680EA80", Offset = "0x680DE80", VA = "0x18680EA80")]
	internal IReadOnlyCollection<OJPOAKJDIJM> GEAKIBIKCED(HFDFBFKBKAN JONLPDJLONH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x680F3A0", Offset = "0x680E7A0", VA = "0x18680F3A0")]
	public bool MGBLGKDOIOA(OJPOAKJDIJM BCLIONLDECF, bool PJOEKOCIAGP, string GLJGKGCGFPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x680F090", Offset = "0x680E490", VA = "0x18680F090")]
	public (bool, string) IFIAPONCDEE(OJPOAKJDIJM BCLIONLDECF)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x680F6D0", Offset = "0x680EAD0", VA = "0x18680F6D0")]
	internal void OECKJELHEBA(OJPOAKJDIJM BCLIONLDECF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x680F4D0", Offset = "0x680E8D0", VA = "0x18680F4D0")]
	public DEHMLEFFLPL NIAFDBCCMKM(Func<PPEKJCECPND, Guid> AJCOEGMLPMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x680DB40", Offset = "0x680CF40", VA = "0x18680DB40")]
	public void EAKBFCFFPKF(DEHMLEFFLPL CFJNNNJAINM, Func<Guid, PPEKJCECPND> KNEPLCHJKJF, [Optional] PPEKJCECPND? IPIBFLLPMDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x680F000", Offset = "0x680E400", VA = "0x18680F000")]
	[CompilerGenerated]
	private void HOJIGNLHHAJ(OJPOAKJDIJM GNKKLFIJFGD, PBDGPNKCFDB JJFPDEOENHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class MLKGCCIACOL : JHGLHNENCMO, NGPDHPHJGAO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class ENMLNNLLICG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public HFDFBFKBKAN newRole;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public ENMLNNLLICG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x680CA90", Offset = "0x680BE90", VA = "0x18680CA90")]
		internal bool IGNIDALAKOL(HFDFBFKBKAN rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class JDNGMBHGAEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public PPEKJCECPND roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public JDNGMBHGAEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x680FAF0", Offset = "0x680EEF0", VA = "0x18680FAF0")]
		internal bool PNJINFCKPKP(PPEKJCECPND r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct LHMMEHPDEAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public MLKGCCIACOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public DFCHLNBLLMO roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<KOLLHLBDFIC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6810B00", Offset = "0x680FF00", VA = "0x186810B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6811170", Offset = "0x6810570", VA = "0x186811170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class BIPGOIDJLIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public BIPGOIDJLIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x680BB40", Offset = "0x680AF40", VA = "0x18680BB40")]
		internal void MEJNGLMPDNF(DEHMLEFFLPL r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x680BA20", Offset = "0x680AE20", VA = "0x18680BA20")]
		internal void KAGDBIEPKFH(DEHMLEFFLPL r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct MKADODKAHLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public DFCHLNBLLMO roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class DGDOIGGNNIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Func<DEHMLEFFLPL, PBDGPNKCFDB> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public DGDOIGGNNIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x680BFF0", Offset = "0x680B3F0", VA = "0x18680BFF0")]
		internal void MDGPAEBPMID(DEHMLEFFLPL r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x680BFC0", Offset = "0x680B3C0", VA = "0x18680BFC0")]
		internal void GJOABILLAHP(DEHMLEFFLPL r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x680BF90", Offset = "0x680B390", VA = "0x18680BF90")]
		internal void CDPHKMFCNAP(DEHMLEFFLPL r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class HGEIAABHJFJ<T> where T : notnull
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
			public HGEIAABHJFJ<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private TaskAwaiter<KOLLHLBDFIC> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x311A5B0", Offset = "0x31199B0", VA = "0x18311A5B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x8A3110", Offset = "0x8A2510", VA = "0x1808A3110", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public MLKGCCIACOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public OJPOAKJDIJM rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public PPEKJCECPND accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public IGPIFNNAGNB recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public HGEIAABHJFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x385AD90", Offset = "0x385A190", VA = "0x18385AD90")]
		[AsyncStateMachine(typeof(HGEIAABHJFJ<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void OPPGGNMPOFA()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct KKBHFANLHFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public IReadOnlyList<LOOBACILBIJ> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct NBCAJFEMMCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public FEILDIEPJOA rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public DFCHLNBLLMO roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public IReadOnlyDictionary<PPEKJCECPND, HFDFBFKBKAN> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public BOKLJLGEHAO debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6816C90", Offset = "0x6816090", VA = "0x186816C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x68177A0", Offset = "0x6816BA0", VA = "0x1868177A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly FEILDIEPJOA BJEMNJOJFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly GLPLGLLKCHP MCHCMPEGOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly BOKLJLGEHAO EHILJPFJPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, HFDFBFKBKAN> NDIOIKDMGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	internal readonly Dictionary<PPEKJCECPND, HFDFBFKBKAN> FHKPHIPEEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal readonly Dictionary<PPEKJCECPND, HFDFBFKBKAN> OKFLGDFBPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	internal readonly List<HFDFBFKBKAN> MLBANHMKPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool MALJEDJPLCE;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly OJPOAKJDIJM[] DJIADIBLKIP;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public ANLCMFPANOA DOOBHKDEJHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<LKAPBODFNHI> FECCKEMNEJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6812220", Offset = "0x6811620", VA = "0x186812220", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event NFHPOIMDMHL OHEJCNCEKFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6812460", Offset = "0x6811860", VA = "0x186812460", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6813420", Offset = "0x6812820", VA = "0x186813420", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6812CC0", Offset = "0x68120C0", VA = "0x186812CC0")]
	[AMCIKKJLCIB(FDMHFCDINAO.Room, HENHDGEOMOC.None)]
	private static void IEDLFPKPNAO(BNDLKDEPBDF PLABOMGPCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x68169D0", Offset = "0x6815DD0", VA = "0x1868169D0")]
	[UnityEngine.Scripting.Preserve]
	internal MLKGCCIACOL([AKGMOFMFNCG(null)] FEILDIEPJOA JGCEJFKPLDJ, [AKGMOFMFNCG(null)] GLPLGLLKCHP NFGJEFLOCBC, [AKGMOFMFNCG(null)] BOKLJLGEHAO EHILJPFJPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x68120A0", Offset = "0x68114A0", VA = "0x1868120A0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6815D70", Offset = "0x6815170", VA = "0x186815D70")]
	private void PHMJPBOMCPP(IEnumerable<HFDFBFKBKAN> FFFIJOAEJKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6814820", Offset = "0x6813C20", VA = "0x186814820", Slot = "12")]
	public bool NGIGLDGJLDG(MKFCBDEMMMH MLFPIJHNEAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6811DA0", Offset = "0x68111A0", VA = "0x186811DA0")]
	private void CEECKGGHHBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6812270", Offset = "0x6811670", VA = "0x186812270")]
	private void FMNNPNFDNKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6814D00", Offset = "0x6814100", VA = "0x186814D00", Slot = "10")]
	public IReadOnlyList<LKAPBODFNHI> OPCMAEINIAN(bool IFKLHHOIMEB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6814110", Offset = "0x6813510", VA = "0x186814110", Slot = "11")]
	public LKAPBODFNHI KFEHGJJIJFA(MKFCBDEMMMH MLFPIJHNEAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6814C30", Offset = "0x6814030", VA = "0x186814C30")]
	private PPEKJCECPND OHIJAGPGCFC(MKFCBDEMMMH MLFPIJHNEAA)
	{
		return default(PPEKJCECPND);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6813C50", Offset = "0x6813050", VA = "0x186813C50", Slot = "14")]
	public bool JMGFBOEBNNL(MKFCBDEMMMH NFMBIJFNCHH, PPEKJCECPND HOKKABPNFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6814D80", Offset = "0x6814180", VA = "0x186814D80", Slot = "15")]
	public LKAPBODFNHI OPMABHJDPGL(PPEKJCECPND HOKKABPNFHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6813DE0", Offset = "0x68131E0", VA = "0x186813DE0")]
	private static bool KECBBLJNNEF(GMFMMFFJHKP AJBBIOKLCJO, PPEKJCECPND HOKKABPNFHF, [Out] DEHMLEFFLPL? GJKCHPFKLNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6811CB0", Offset = "0x68110B0", VA = "0x186811CB0")]
	private static void BPGGFDKKGPK(GMFMMFFJHKP AJBBIOKLCJO, Action<DEHMLEFFLPL> AIBFMPLJOMK, PPEKJCECPND COBBBPANINA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6811A20", Offset = "0x6810E20", VA = "0x186811A20")]
	private static void BPGGFDKKGPK(GMFMMFFJHKP AJBBIOKLCJO, Action<DEHMLEFFLPL> AIBFMPLJOMK, Predicate<PPEKJCECPND> PDBMJOJGMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x68121B0", Offset = "0x68115B0", VA = "0x1868121B0")]
	private void EHPDGNGHCMJ(MKFCBDEMMMH MLFPIJHNEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6814E20", Offset = "0x6814220", VA = "0x186814E20", Slot = "4")]
	[AsyncStateMachine(typeof(LHMMEHPDEAD))]
	public Task PBPIFAODGLD([CanBeNull] DFCHLNBLLMO HADHNEGDEKF, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "5")]
	public void FGCEDLILCHL(DFCHLNBLLMO HADHNEGDEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x68148F0", Offset = "0x6813CF0", VA = "0x1868148F0")]
	private void NJILEGINBII(GMFMMFFJHKP JPFCGKJPIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x68129B0", Offset = "0x6811DB0", VA = "0x1868129B0")]
	internal static string HNDKIANBKEC(FEILDIEPJOA BJEMNJOJFIC, DFCHLNBLLMO HADHNEGDEKF, IReadOnlyDictionary<PPEKJCECPND, HFDFBFKBKAN> FHKPHIPEEOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6814F40", Offset = "0x6814340", VA = "0x186814F40")]
	private static void PHBAKFPGJDD(DFCHLNBLLMO HADHNEGDEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6812EA0", Offset = "0x68122A0", VA = "0x186812EA0")]
	private static void IGEOAGEAFFL(GMFMMFFJHKP APEPAMGGPEF, IReadOnlyDictionary<PPEKJCECPND, HFDFBFKBKAN> FHKPHIPEEOL, StringBuilder BJOJEANJPAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x68111D0", Offset = "0x68105D0", VA = "0x1868111D0")]
	private static bool ALONFHAIDOE(string CCLAPCKBMOI, [Out] Guid IAHNEBLJLBF, [Out] PPEKJCECPND HOKKABPNFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x68112E0", Offset = "0x68106E0", VA = "0x1868112E0")]
	private static void BODEDOBFDOO(DFCHLNBLLMO HADHNEGDEKF, StringBuilder BJOJEANJPAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x28B1EC0", Offset = "0x28B12C0", VA = "0x1828B1EC0", Slot = "16")]
	public bool ELIPHFPBPBK<T>(PPEKJCECPND HOKKABPNFHF, OJPOAKJDIJM BCLIONLDECF, bool PJOEKOCIAGP, T PBBNOGAMKJE, [Optional] Action CDOEKFKOMNE) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x68165F0", Offset = "0x68159F0", VA = "0x1868165F0")]
	private void PLDFOHDKDBD(PPEKJCECPND HOKKABPNFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6812E80", Offset = "0x6812280", VA = "0x186812E80")]
	private bool IEOMHIAPBOG(MKFCBDEMMMH MLFPIJHNEAA, PPEKJCECPND HOKKABPNFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6814220", Offset = "0x6813620", VA = "0x186814220")]
	internal HFDFBFKBKAN LLNMBKHPEOM(MKFCBDEMMMH MLFPIJHNEAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6814570", Offset = "0x6813970", VA = "0x186814570", Slot = "13")]
	public IReadOnlyList<LKAPBODFNHI> MCFIGMFPCFI(MKFCBDEMMMH MLFPIJHNEAA, bool LNGCLEEFPLI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x68131F0", Offset = "0x68125F0", VA = "0x1868131F0")]
	internal IReadOnlyList<HFDFBFKBKAN> IJOKFANIBPP(MKFCBDEMMMH MLFPIJHNEAA, bool LNGCLEEFPLI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x68134C0", Offset = "0x68128C0", VA = "0x1868134C0")]
	private void JFPENAPJJDH(KOLLHLBDFIC GFIEJDHEGGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6811DB0", Offset = "0x68111B0", VA = "0x186811DB0")]
	private static bool DNMCPCKKCDD(HFDFBFKBKAN JPFIOKPOBKO, IReadOnlyDictionary<PPEKJCECPND, HFDFBFKBKAN> FHKPHIPEEOL, [Out] IReadOnlyList<OJPOAKJDIJM> FLOIMKLLFMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6812500", Offset = "0x6811900", VA = "0x186812500")]
	[AsyncStateMachine(typeof(NBCAJFEMMCB))]
	private static Task HBEHPMKNGKH(FEILDIEPJOA BJEMNJOJFIC, DFCHLNBLLMO HADHNEGDEKF, IReadOnlyDictionary<PPEKJCECPND, HFDFBFKBKAN> FHKPHIPEEOL, BOKLJLGEHAO EHILJPFJPJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6814580", Offset = "0x6813980", VA = "0x186814580")]
	[CompilerGenerated]
	internal static void NFLBJKKNPBC(Func<DEHMLEFFLPL, PBDGPNKCFDB> BDNFJENHDKF, MKADODKAHLG P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6812640", Offset = "0x6811A40", VA = "0x186812640")]
	[CompilerGenerated]
	internal static bool HGCFEEKAKGF(PPEKJCECPND HOKKABPNFHF, OJPOAKJDIJM BCLIONLDECF, [Out] LOOBACILBIJ BLHNDBBIICK, KKBHFANLHFC P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface NDKNNFBPHOF
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CHLCEHDBDGO(MKFCBDEMMMH NLJJMNDLEPI, MKFCBDEMMMH HOJJPPKAHIA, IEnumerable<MKFCBDEMMMH> LHBNFJMIIKK, [Out] KEPJAGHMADO DHOIDOKLMJN, [Out] BEPJFNLEPLE IACAFLHAFFO);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string BPDKMNMPEMB(BEPJFNLEPLE EILOCLMMKFN);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum BEPJFNLEPLE : byte
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
internal class LCBNJMOJGDG : NDKNNFBPHOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly NGPDHPHJGAO PGKFEJJBFHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly OPDBCHELFEB NGKMGPFCNNF;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7C3C10", Offset = "0x7C3010", VA = "0x1807C3C10")]
	[RecRoom.NoEngine.Common.Preserve]
	public LCBNJMOJGDG([AKGMOFMFNCG(null)] NGPDHPHJGAO MPCJDJFNCBD, [AKGMOFMFNCG(null)] OPDBCHELFEB FEELOOMGAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x68104A0", Offset = "0x680F8A0", VA = "0x1868104A0")]
	private static NOJGIHLHKPE? JMJJMFDPKPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x68103A0", Offset = "0x680F7A0", VA = "0x1868103A0", Slot = "4")]
	public bool CHLCEHDBDGO(MKFCBDEMMMH NLJJMNDLEPI, MKFCBDEMMMH HOJJPPKAHIA, IEnumerable<MKFCBDEMMMH> LHBNFJMIIKK, [Out] KEPJAGHMADO DHOIDOKLMJN, [Out] BEPJFNLEPLE IACAFLHAFFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x68102A0", Offset = "0x680F6A0", VA = "0x1868102A0", Slot = "5")]
	public string BPDKMNMPEMB(BEPJFNLEPLE EILOCLMMKFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x68104E0", Offset = "0x680F8E0", VA = "0x1868104E0")]
	internal bool ODAFIBJBDCD(MKFCBDEMMMH NLJJMNDLEPI, MKFCBDEMMMH HOJJPPKAHIA, IEnumerable<MKFCBDEMMMH> LHBNFJMIIKK, DAFHOICEHFC MBNPDJACMNH, NOJGIHLHKPE? KFPNEIDJFKD, [Out] KEPJAGHMADO DHOIDOKLMJN, [Out] BEPJFNLEPLE IACAFLHAFFO)
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
