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
		[Cpp2IlInjected.Address(RVA = "0x876AF0", Offset = "0x8754F0", VA = "0x180876AF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FCB810", Offset = "0x6FCA210", VA = "0x186FCB810")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8775C0", Offset = "0x875FC0", VA = "0x1808775C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x877600", Offset = "0x876000", VA = "0x180877600")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum HHHGFPKFINI
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void KOLHKGJKKAH<TPermission>(TPermission DAEALJPONMC);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void GLPLGMJPMDF(JDKCNIBKGKE HNOBHNILHCN);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum OBHJBJLJFEK
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface KPJBGDCFLJB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BIFAFBCFCCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool PKEOJHIMFFA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool PHGMEGIJFBA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool MPMJAJIFIJK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool LCLOBJMHFDG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool AKAOIOKHIOA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class IIGILHPIABI
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	public enum HCJIBJJECIJ
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
	public static readonly Guid AFCDLLNEIJE;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid DNNAPOOGGMK;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid ILBDKGFONOJ;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid PFLHAGAOPGE;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid DKGAJEDGAJB;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid HDFLADHPKBL;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly PINJDEFJIPF<FOMHPJHDBLN, Guid> KIOKIIGPGBO;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<FOMHPJHDBLN> AAONPININFK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5BF0", Offset = "0x6FC45F0", VA = "0x186FC5BF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6FC58A0", Offset = "0x6FC42A0", VA = "0x186FC58A0")]
	public static FOMHPJHDBLN EBDNJAILKJC(Guid JCMDDLFAGEN)
	{
		return default(FOMHPJHDBLN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6FC5930", Offset = "0x6FC4330", VA = "0x186FC5930")]
	public static Guid GCMKFCDEFOI(FOMHPJHDBLN IGIMJMKHFIK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6FC59D0", Offset = "0x6FC43D0", VA = "0x186FC59D0")]
	public static bool GEOPCEKIKOF(FOMHPJHDBLN IGIMJMKHFIK, [Out] Guid JCMDDLFAGEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6FC5A60", Offset = "0x6FC4460", VA = "0x186FC5A60")]
	public static bool HJKOMODPCJP(Guid JCMDDLFAGEN, [Out] FOMHPJHDBLN IGIMJMKHFIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6FC5C70", Offset = "0x6FC4670", VA = "0x186FC5C70")]
	public static FOMHPJHDBLN OOMMIAMEIAM(FOMHPJHDBLN IGIMJMKHFIK)
	{
		return default(FOMHPJHDBLN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6FC5B40", Offset = "0x6FC4540", VA = "0x186FC5B40")]
	public static HCJIBJJECIJ KHJGFKLAFHN(FOMHPJHDBLN AGPLEGPCFIF)
	{
		return default(HCJIBJJECIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6FC5B00", Offset = "0x6FC4500", VA = "0x186FC5B00")]
	internal static FOMHPJHDBLN JGBKJHOCAPG(HCJIBJJECIJ HMAJNFIBEJO)
	{
		return default(FOMHPJHDBLN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface DPIDEAHFOIA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	MFIKDLIBLDE EDHDFDOLDLC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<MLODGCHHJEM> KNEOJMJBPGO
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event GLPLGMJPMDF IMPDMPKBCOC;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<MLODGCHHJEM> PCFAHNLGMCB(bool COLHFCLILIH = false);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MLODGCHHJEM CIOEPNAPJCO(JDKCNIBKGKE HNOBHNILHCN);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool EOIAGGBNMEI(JDKCNIBKGKE HNOBHNILHCN);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<MLODGCHHJEM> JKGNLIJMPKO(JDKCNIBKGKE HNOBHNILHCN, bool BLCBCEFDIEJ = false);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool EMPJKCPEFDH(JDKCNIBKGKE NNJGALNDHKL, FOMHPJHDBLN IGIMJMKHFIK);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "9")]
	MLODGCHHJEM GNOAJOMPIAK(FOMHPJHDBLN IGIMJMKHFIK);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool NJCPKINKHEC<T>(FOMHPJHDBLN IGIMJMKHFIK, JCBMAGGLIJM DAEALJPONMC, bool LEGALBPGLBI, T PCNJMLOHDMH, [Optional] Action MIELOADBFFM) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string NKHJKPKHOJF(JCBMAGGLIJM DAEALJPONMC);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JOGCMJGFPFD
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task ODFJAEFAPEM(HOHHBPKCDBA IJFOGIEFCHH, CancellationToken AOLOJHLCMLE);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void APBBLAJEMCJ(HOHHBPKCDBA IJFOGIEFCHH);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface HJKILCGALBP
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	JDKCNIBKGKE IEINKFJJGFM
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	MDCEFFOBCGJ CMLFDHLMGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	LGDDBNGBFNG BLKFMIEOHFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<HJEDBNKDDIJ> IKDBPBFKPND;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action LCDCPHDHADB;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FOMHPJHDBLN HMIEJHNDJCH(JDKCNIBKGKE HNOBHNILHCN);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<HJEDBNKDDIJ> PGGFMKJEFFP(CancellationToken AOLOJHLCMLE);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task IIDNPIAIDIE(long ONILLAPMLEN, IReadOnlyList<CAIKKGCODLA> NDIBOAFDNBJ);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task JCFKABJKLCE(long ONILLAPMLEN, long EMDKAGDEANA, IReadOnlyList<CAIKKGCODLA> NDIBOAFDNBJ);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<JDKCNIBKGKE> FBCPMGNGLEO();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class HFKHDOMOLCK
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6FC5030", Offset = "0x6FC3A30", VA = "0x186FC5030")]
	public static FOMHPJHDBLN CMNKDKKOOHO(this HJKILCGALBP AOCLCNEKNAC)
	{
		return default(FOMHPJHDBLN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface EFOFLLIHLBO<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string GOEECLKLJBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event KOLHKGJKKAH<TPermission> BMNBEGPEDIO;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class KIHHOHGNLMC
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? EGCCLBEMPAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x84EC70", Offset = "0x84D670", VA = "0x18084EC70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x84EC30", Offset = "0x84D630", VA = "0x18084EC30")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x852830", Offset = "0x851230", VA = "0x180852830")]
	protected KIHHOHGNLMC(object? PPHPIBDCNAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool JGAEDOBGECC(object? DBOBEHLEAAE);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class EIOIDJLEEPG<T> : KIHHOHGNLMC where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private T CMKLHFBNKHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly IEqualityComparer<T> ABDOJJAJOND;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T NHLIMKDHAIB
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x915D70", Offset = "0x914770", VA = "0x180915D70")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3864DB0", Offset = "0x38637B0", VA = "0x183864DB0", Slot = "4")]
	public override bool JGAEDOBGECC(object? DBOBEHLEAAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3865180", Offset = "0x3863B80", VA = "0x183865180")]
	public bool KDFBJKIDJMH(T FLNPGMMKOJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3865530", Offset = "0x3863F30", VA = "0x183865530")]
	public EIOIDJLEEPG(T JIEGAHKKHCA, IEqualityComparer<T> ABDOJJAJOND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class HGDELIDICCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<JCBMAGGLIJM, bool> MGCEOFDDPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<JCBMAGGLIJM, KIHHOHGNLMC> CPKDCCICHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly KIOPGGIMJFI FBONCCAAEAB;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6FC5560", Offset = "0x6FC3F60", VA = "0x186FC5560")]
	public HGDELIDICCE(KIOPGGIMJFI FBONCCAAEAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6FC54F0", Offset = "0x6FC3EF0", VA = "0x186FC54F0")]
	public bool OIBABCOOFOF(JCBMAGGLIJM DAEALJPONMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2B34720", Offset = "0x2B33120", VA = "0x182B34720")]
	public bool NJHHPGLIDCE<T>(JCBMAGGLIJM DAEALJPONMC, bool LEGALBPGLBI, T DBOBEHLEAAE) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2B34220", Offset = "0x2B32C20", VA = "0x182B34220")]
	public (bool, T?) FJDPMDANNCG<T>(JCBMAGGLIJM DAEALJPONMC) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6FC5410", Offset = "0x6FC3E10", VA = "0x186FC5410")]
	public bool NJHHPGLIDCE(JCBMAGGLIJM DAEALJPONMC, bool LEGALBPGLBI, object DBOBEHLEAAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6FC5340", Offset = "0x6FC3D40", VA = "0x186FC5340")]
	public (bool, object) FJDPMDANNCG(JCBMAGGLIJM DAEALJPONMC)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2B346C0", Offset = "0x2B330C0", VA = "0x182B346C0")]
	private void MPBKCPDEHDD<T>(JCBMAGGLIJM DAEALJPONMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6FC5270", Offset = "0x6FC3C70", VA = "0x186FC5270")]
	private KIHHOHGNLMC EMFINCIONLN(JCBMAGGLIJM DAEALJPONMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6FC5090", Offset = "0x6FC3A90", VA = "0x186FC5090")]
	public void AECOENEIKGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class GLCNOHBKHOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly string BBAOPMPDOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly Type KLEPBKOMCKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly ELIHHNMOEHE FODFBKBPOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly JCBMAGGLIJM GKMICJEABGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public INPKNNBIMED KMKCEPKKOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public FBEKHLFNGNH KFLIICFIBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public LAINLJAGAPG EAAINENPMEM;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6FC4F90", Offset = "0x6FC3990", VA = "0x186FC4F90")]
	public GLCNOHBKHOG(Type PEFHIGPIGHN, string CFJBMDPEFHO, JCBMAGGLIJM DAEALJPONMC, INPKNNBIMED NBHFJPPCICJ, FBEKHLFNGNH LOECLHICBCH, LAINLJAGAPG MCNLHIPDOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6FC4F40", Offset = "0x6FC3940", VA = "0x186FC4F40")]
	public object NDJFJLFIPFL(object? HENLEJBGFIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2B2A5B0", Offset = "0x2B28FB0", VA = "0x182B2A5B0")]
	public void MPBKCPDEHDD<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6FC4E90", Offset = "0x6FC3890", VA = "0x186FC4E90")]
	public void MPBKCPDEHDD(Type IJFJIKCAKEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class BIEAKJBOHGO<T> : GLCNOHBKHOG where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string HOFOFAEALCB(T DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T OHADNDBJLGG(string? HJNHCIINHFN, T JIEGAHKKHCA);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class FGFFKHLFEGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HOFOFAEALCB serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public OHADNDBJLGG parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public FGFFKHLFEGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3BFCE00", Offset = "0x3BFB800", VA = "0x183BFCE00")]
		internal string DBFCLFEJFAB(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3BFCF90", Offset = "0x3BFB990", VA = "0x183BFCF90")]
		internal object HDNKAJEMLCO(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4E1D210", Offset = "0x4E1BC10", VA = "0x184E1D210")]
	public BIEAKJBOHGO(JCBMAGGLIJM DAEALJPONMC, string CFJBMDPEFHO, [Optional] HOFOFAEALCB? NBHFJPPCICJ, [Optional] OHADNDBJLGG? LOECLHICBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4E1C080", Offset = "0x4E1AA80", VA = "0x184E1C080")]
	private static object? FIOJCIMJMME(OHADNDBJLGG? LOECLHICBCH, string? HJNHCIINHFN, object? JIEGAHKKHCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4E1C630", Offset = "0x4E1B030", VA = "0x184E1C630")]
	private static string KJCBMOAEMAH(HOFOFAEALCB? AOHGFHOLAGE, object? DBOBEHLEAAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string INPKNNBIMED(object? DBOBEHLEAAE);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object FBEKHLFNGNH(string? HJNHCIINHFN, [Optional] object JIEGAHKKHCA);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate KIHHOHGNLMC LAINLJAGAPG();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class KIOPGGIMJFI
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class LEHGJOOIGFI : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal static LEHGJOOIGFI OHJMENPNAKB;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6FCB4D0", Offset = "0x6FC9ED0", VA = "0x186FCB4D0", Slot = "4")]
		public bool Equals(List<string> PHDMOAMCFBE, List<string> CPHIHAJIIFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6FCB620", Offset = "0x6FCA020", VA = "0x186FCB620", Slot = "5")]
		public int GetHashCode(List<string> GKHPLGCJCPF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public LEHGJOOIGFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class JMHLIIACBEC : CANEGMKFNNK<HHHGFPKFINI>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6FC81B0", Offset = "0x6FC6BB0", VA = "0x186FC81B0", Slot = "9")]
		public override string KJCBMOAEMAH(HHHGFPKFINI CGAJJAALELM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6FC82A0", Offset = "0x6FC6CA0", VA = "0x186FC82A0", Slot = "10")]
		protected override bool NFJNIGHOPFC(string CGAJJAALELM, [Out] HHHGFPKFINI DBOBEHLEAAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6FC8470", Offset = "0x6FC6E70", VA = "0x186FC8470")]
		public JMHLIIACBEC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly OAGGPEPBMEE PJPLGNEHIIF;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly JMHLIIACBEC HEPKBPIDIBN;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly List<GLCNOHBKHOG> BOLHKNENBHM;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<JCBMAGGLIJM> GCMGDPPFFBG
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x84EC70", Offset = "0x84D670", VA = "0x18084EC70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<JCBMAGGLIJM, GLCNOHBKHOG> NKCHPLKGOPM
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6FCB180", Offset = "0x6FC9B80", VA = "0x186FCB180")]
	public KIOPGGIMJFI([Optional] IList<GLCNOHBKHOG>? FKFNFENBEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6FC9C60", Offset = "0x6FC8660", VA = "0x186FC9C60")]
	public GLCNOHBKHOG IIADDDIKDPI(JCBMAGGLIJM DAEALJPONMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface MFIKDLIBLDE
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	MLODGCHHJEM MKKPEFGOOLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class KIOPEHDMIII : MFIKDLIBLDE
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static KIOPEHDMIII OCHCBMGMMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly JGANGOAPEPO CGKLHIHNFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal readonly IReadOnlyList<JGANGOAPEPO> HODIKDFEONG;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public MLODGCHHJEM MKKPEFGOOLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x84EC70", Offset = "0x84D670", VA = "0x18084EC70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6FC9B50", Offset = "0x6FC8550", VA = "0x186FC9B50")]
	public KIOPEHDMIII(JGANGOAPEPO ODEKJDEMIJF, IReadOnlyList<JGANGOAPEPO> ANEOBMOKIHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6FC8D00", Offset = "0x6FC7700", VA = "0x186FC8D00")]
	private static KIOPEHDMIII NAJBBNFKEII()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class AGDLHKPLAOB
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<FOMHPJHDBLN> AHIGNPJGEON;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6FC39C0", Offset = "0x6FC23C0", VA = "0x186FC39C0")]
	public static bool HEHEGIAEHOI(this JDKCNIBKGKE FFJFLMHOJHA, FOMHPJHDBLN IGIMJMKHFIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6FC3940", Offset = "0x6FC2340", VA = "0x186FC3940")]
	public static bool FLIEMNBEEFA(this JDKCNIBKGKE FFJFLMHOJHA, FOMHPJHDBLN IGIMJMKHFIK, LGDDBNGBFNG MDFHAANEALD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface OBOLHLLDAOH
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool CKBGPHEEFOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool KLNNPOECOPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool AAKOLJAJAAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool OEJNAFPBMOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool JLIDHAAIKEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool PEJOKECEHOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool BDDHNCGHACO
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool JDAEBLCGDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool HDNMKHGLBCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool HPGKLLPGLFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool HABINCECIEF
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool GNAMBDNGJFM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> AKGLKMJOPBC
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	HHHGFPKFINI IHJBKDBGGIF
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface MLODGCHHJEM : OBOLHLLDAOH, KPJBGDCFLJB, EFOFLLIHLBO<JCBMAGGLIJM>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string PGAAFPGHEDC
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	FOMHPJHDBLN ADLAAJPNBOG
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) AOLHEMMGNBB<T>(JCBMAGGLIJM DAEALJPONMC) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum JCBMAGGLIJM
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
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal class JGANGOAPEPO : MLODGCHHJEM, OBOLHLLDAOH, KPJBGDCFLJB, EFOFLLIHLBO<JCBMAGGLIJM>
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	internal static readonly KIOPGGIMJFI IADCAINMAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	internal readonly HGDELIDICCE FKPNEHHLIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private string? NBBJHBDEPGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private string? LLKCGLLJEBG;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool PEDBBEGMFEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6FC0", Offset = "0x6FC59C0", VA = "0x186FC6FC0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool DENBOEBAKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6FC62D0", Offset = "0x6FC4CD0", VA = "0x186FC62D0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool MPAPBEAPMOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6090", Offset = "0x6FC4A90", VA = "0x186FC6090", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool NBPABPDGNAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6230", Offset = "0x6FC4C30", VA = "0x186FC6230", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool KGDMCKDKAIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6FC60E0", Offset = "0x6FC4AE0", VA = "0x186FC60E0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool EGHOBLJOPNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6040", Offset = "0x6FC4A40", VA = "0x186FC6040", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public FOMHPJHDBLN ADLAAJPNBOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x915D70", Offset = "0x914770", VA = "0x180915D70", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(FOMHPJHDBLN);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x85AA60", Offset = "0x859460", VA = "0x18085AA60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string GOEECLKLJBP
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6280", Offset = "0x6FC4C80", VA = "0x186FC6280", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6F70", Offset = "0x6FC5970", VA = "0x186FC6F70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string PGAAFPGHEDC
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6280", Offset = "0x6FC4C80", VA = "0x186FC6280", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool BNICBGKGFJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9D3DE0", Offset = "0x9D27E0", VA = "0x1809D3DE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9D3240", Offset = "0x9D1C40", VA = "0x1809D3240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool CKBGPHEEFOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6F20", Offset = "0x6FC5920", VA = "0x186FC6F20", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public HHHGFPKFINI IHJBKDBGGIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6320", Offset = "0x6FC4D20", VA = "0x186FC6320", Slot = "20")]
		get
		{
			return default(HHHGFPKFINI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool KLNNPOECOPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6690", Offset = "0x6FC5090", VA = "0x186FC6690", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool AAKOLJAJAAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6FC61E0", Offset = "0x6FC4BE0", VA = "0x186FC61E0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool OEJNAFPBMOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6FC7520", Offset = "0x6FC5F20", VA = "0x186FC7520", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool JLIDHAAIKEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5FF0", Offset = "0x6FC49F0", VA = "0x186FC5FF0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool PEJOKECEHOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6FC7370", Offset = "0x6FC5D70", VA = "0x186FC7370", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool BDDHNCGHACO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6FC64C0", Offset = "0x6FC4EC0", VA = "0x186FC64C0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool JDAEBLCGDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6640", Offset = "0x6FC5040", VA = "0x186FC6640", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool HDNMKHGLBCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6A60", Offset = "0x6FC5460", VA = "0x186FC6A60", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> AKGLKMJOPBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6FC7310", Offset = "0x6FC5D10", VA = "0x186FC7310", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool HCIGBLOLECP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6FC0", Offset = "0x6FC59C0", VA = "0x186FC6FC0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool ELKNIOHGDNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6FC60E0", Offset = "0x6FC4AE0", VA = "0x186FC60E0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool NHEBLHEFONK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6FC62D0", Offset = "0x6FC4CD0", VA = "0x186FC62D0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool HPGKLLPGLFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6420", Offset = "0x6FC4E20", VA = "0x186FC6420", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool HABINCECIEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6510", Offset = "0x6FC4F10", VA = "0x186FC6510", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool HMGMHADPPHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6090", Offset = "0x6FC4A90", VA = "0x186FC6090", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool GNAMBDNGJFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6FC7450", Offset = "0x6FC5E50", VA = "0x186FC7450", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool ADLDKGBFGEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6230", Offset = "0x6FC4C30", VA = "0x186FC6230", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool AHDOFGFINMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6040", Offset = "0x6FC4A40", VA = "0x186FC6040", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event KOLHKGJKKAH<JCBMAGGLIJM> BMNBEGPEDIO
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6370", Offset = "0x6FC4D70", VA = "0x186FC6370", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6130", Offset = "0x6FC4B30", VA = "0x186FC6130", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2B7A920", Offset = "0x2B79320", VA = "0x182B7A920", Slot = "6")]
	public (bool, T?) AOLHEMMGNBB<T>(JCBMAGGLIJM DAEALJPONMC) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2B7AB10", Offset = "0x2B79510", VA = "0x182B7AB10")]
	public JGANGOAPEPO CILDFALNOHL<T>(JCBMAGGLIJM DAEALJPONMC, bool LEGALBPGLBI, T DBOBEHLEAAE) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6FC7F80", Offset = "0x6FC6980", VA = "0x186FC7F80")]
	public JGANGOAPEPO(FOMHPJHDBLN IGIMJMKHFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6FC7FA0", Offset = "0x6FC69A0", VA = "0x186FC7FA0")]
	public JGANGOAPEPO(FOMHPJHDBLN IGIMJMKHFIK, [Optional] string? NBBJHBDEPGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6FC8120", Offset = "0x6FC6B20", VA = "0x186FC8120")]
	public JGANGOAPEPO(JGANGOAPEPO ONFGDGGGJOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6FC7FC0", Offset = "0x6FC69C0", VA = "0x186FC7FC0")]
	internal JGANGOAPEPO(FOMHPJHDBLN ICGPECGFJDE, [Optional] string? NBBJHBDEPGF, [Optional] JGANGOAPEPO? ONFGDGGGJOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6FC74A0", Offset = "0x6FC5EA0", VA = "0x186FC74A0")]
	public static ELIHHNMOEHE OLMFHJPECML(JCBMAGGLIJM DAEALJPONMC)
	{
		return default(ELIHHNMOEHE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6FC5FD0", Offset = "0x6FC49D0", VA = "0x186FC5FD0")]
	public void AECOENEIKGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6FC66E0", Offset = "0x6FC50E0", VA = "0x186FC66E0")]
	internal JGANGOAPEPO KFCKGHKHOPN(JGANGOAPEPO EDFPJBAKGCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6FC6AB0", Offset = "0x6FC54B0", VA = "0x186FC6AB0")]
	internal IReadOnlyCollection<JCBMAGGLIJM> KHMOMCMPNHI(JGANGOAPEPO ONFGDGGGJOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6FC6560", Offset = "0x6FC4F60", VA = "0x186FC6560")]
	public bool HBMKBFCOAAF(JCBMAGGLIJM DAEALJPONMC, bool LEGALBPGLBI, string HJNPMPENFMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6FC7210", Offset = "0x6FC5C10", VA = "0x186FC7210")]
	public (bool, string) MIKKAEFHNPO(JCBMAGGLIJM DAEALJPONMC)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6FC6470", Offset = "0x6FC4E70", VA = "0x186FC6470")]
	internal void GIMOHEFIOJA(JCBMAGGLIJM DAEALJPONMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6FC7010", Offset = "0x6FC5A10", VA = "0x186FC7010")]
	public ALPADCMPKEI KPEKEDJBOJL(Func<FOMHPJHDBLN, Guid> CDOIGLBOMPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6FC7570", Offset = "0x6FC5F70", VA = "0x186FC7570")]
	public void PEMNDKFABIG(ALPADCMPKEI EBGGDAHMHEI, Func<Guid, FOMHPJHDBLN> OFDOMMJNLPJ, [Optional] FOMHPJHDBLN? DGKFCIMFFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6FC73C0", Offset = "0x6FC5DC0", VA = "0x186FC73C0")]
	[CompilerGenerated]
	private void OFHAELBFJOG(JCBMAGGLIJM JFAPOILOKLC, NCKCBMNGCDL DGCOGPCNEDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class PGPFAPBDPBE : JOGCMJGFPFD, DPIDEAHFOIA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class OGLEGPPFLJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public JGANGOAPEPO newRole;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public OGLEGPPFLJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6FCB890", Offset = "0x6FCA290", VA = "0x186FCB890")]
		internal bool DNGDDJOFBEM(JGANGOAPEPO rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class HHGGKBCFPOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public FOMHPJHDBLN roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public HHGGKBCFPOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5800", Offset = "0x6FC4200", VA = "0x186FC5800")]
		internal bool KBEHPFHEIBH(FOMHPJHDBLN r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct EMLODLFGDPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public PGPFAPBDPBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public HOHHBPKCDBA roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<HJEDBNKDDIJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6FC47C0", Offset = "0x6FC31C0", VA = "0x186FC47C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4E30", Offset = "0x6FC3830", VA = "0x186FC4E30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class OKGIHHHBCDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public OKGIHHHBCDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6FCB8C0", Offset = "0x6FCA2C0", VA = "0x186FCB8C0")]
		internal void DJGHCLOMKGG(ALPADCMPKEI r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6FCB9A0", Offset = "0x6FCA3A0", VA = "0x186FCB9A0")]
		internal void OMODMLCGNEE(ALPADCMPKEI r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct FFFMBKOLDBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public HOHHBPKCDBA roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class HPIMHNGJECI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Func<ALPADCMPKEI, NCKCBMNGCDL> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public HPIMHNGJECI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5810", Offset = "0x6FC4210", VA = "0x186FC5810")]
		internal void INFMBJIDEOL(ALPADCMPKEI r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5840", Offset = "0x6FC4240", VA = "0x186FC5840")]
		internal void LDICOKJEMLP(ALPADCMPKEI r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5870", Offset = "0x6FC4270", VA = "0x186FC5870")]
		internal void NBEJDDNCGAL(ALPADCMPKEI r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class NKFMEEEFEGH<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
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
			public NKFMEEEFEGH<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private TaskAwaiter<HJEDBNKDDIJ> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x354C5B0", Offset = "0x354AFB0", VA = "0x18354C5B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x9E9250", Offset = "0x9E7C50", VA = "0x1809E9250", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public JCBMAGGLIJM rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public FOMHPJHDBLN accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public ELIHHNMOEHE recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public PGPFAPBDPBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public NKFMEEEFEGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x44E52B0", Offset = "0x44E3CB0", VA = "0x1844E52B0")]
		[AsyncStateMachine(typeof(NKFMEEEFEGH<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void BBIDMFPJCBB()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct NDGLOBELLNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public IReadOnlyList<CAIKKGCODLA> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct BGGNEACIHOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public HJKILCGALBP rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public HOHHBPKCDBA roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public IReadOnlyDictionary<FOMHPJHDBLN, JGANGOAPEPO> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public OLPJGLPPFIJ debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6FC3C50", Offset = "0x6FC2650", VA = "0x186FC3C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4760", Offset = "0x6FC3160", VA = "0x186FC4760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly HJKILCGALBP AOCLCNEKNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly KIOPEHDMIII GNMHIIAAOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly OLPJGLPPFIJ LPIGFFIELAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly Dictionary<int, JGANGOAPEPO> DKKBGAEFHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	internal readonly Dictionary<FOMHPJHDBLN, JGANGOAPEPO> FCBHMEMNIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	internal readonly Dictionary<FOMHPJHDBLN, JGANGOAPEPO> GOKMKBECAMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	internal readonly List<JGANGOAPEPO> MGJJIGBEDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private bool APPDOECKPGO;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly JCBMAGGLIJM[] NFIPPLEEGEM;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public MFIKDLIBLDE EDHDFDOLDLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<MLODGCHHJEM> KNEOJMJBPGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6FCE1B0", Offset = "0x6FCCBB0", VA = "0x186FCE1B0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event GLPLGMJPMDF IMPDMPKBCOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6FCF0F0", Offset = "0x6FCDAF0", VA = "0x186FCF0F0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6FCD2E0", Offset = "0x6FCBCE0", VA = "0x186FCD2E0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6FCC0F0", Offset = "0x6FCAAF0", VA = "0x186FCC0F0")]
	[MHFEIEAPENL(ABEEEPGJOJM.Room, CMFCLNIIIKO.None)]
	private static void CGLKAELBCAP(GPECMKAJNMD MJAMFOPMNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6FD12D0", Offset = "0x6FCFCD0", VA = "0x186FD12D0")]
	[UnityEngine.Scripting.Preserve]
	internal PGPFAPBDPBE([OHLKLPAILPF(null)] HJKILCGALBP NLKIEJKPPOD, [OHLKLPAILPF(null)] KIOPEHDMIII NCHHBOCKPLO, [OHLKLPAILPF(null)] OLPJGLPPFIJ LPIGFFIELAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6FCC3C0", Offset = "0x6FCADC0", VA = "0x186FCC3C0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6FCCA80", Offset = "0x6FCB480", VA = "0x186FCCA80")]
	private void FOLJGMKAAEL(IEnumerable<JGANGOAPEPO> GCDHAJOLHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6FCC660", Offset = "0x6FCB060", VA = "0x186FCC660", Slot = "12")]
	public bool EOIAGGBNMEI(JDKCNIBKGKE HNOBHNILHCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6FCF0E0", Offset = "0x6FCDAE0", VA = "0x186FCF0E0")]
	private void LCDCPHDHADB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6FD0F20", Offset = "0x6FCF920", VA = "0x186FD0F20")]
	private void PPCBFNKCCMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6FD0EA0", Offset = "0x6FCF8A0", VA = "0x186FD0EA0", Slot = "10")]
	public IReadOnlyList<MLODGCHHJEM> PCFAHNLGMCB(bool COLHFCLILIH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6FCC2B0", Offset = "0x6FCACB0", VA = "0x186FCC2B0", Slot = "11")]
	public MLODGCHHJEM CIOEPNAPJCO(JDKCNIBKGKE HNOBHNILHCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6FCD750", Offset = "0x6FCC150", VA = "0x186FCD750")]
	private FOMHPJHDBLN HIMBLCENJFM(JDKCNIBKGKE HNOBHNILHCN)
	{
		return default(FOMHPJHDBLN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6FCC4D0", Offset = "0x6FCAED0", VA = "0x186FCC4D0", Slot = "14")]
	public bool EMPJKCPEFDH(JDKCNIBKGKE NNJGALNDHKL, FOMHPJHDBLN IGIMJMKHFIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6FCD6B0", Offset = "0x6FCC0B0", VA = "0x186FCD6B0", Slot = "15")]
	public MLODGCHHJEM GNOAJOMPIAK(FOMHPJHDBLN IGIMJMKHFIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6FCBAE0", Offset = "0x6FCA4E0", VA = "0x186FCBAE0")]
	private static bool BDDOGPKJPPD(ENCHAJJEIBN FIEMIMALOMA, FOMHPJHDBLN IGIMJMKHFIK, [Out] ALPADCMPKEI? KPNHHMGMCPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6FCD820", Offset = "0x6FCC220", VA = "0x186FCD820")]
	private static void IHCADGKAIKP(ENCHAJJEIBN FIEMIMALOMA, Action<ALPADCMPKEI> GEABHDIDAJE, FOMHPJHDBLN HJPKMLHGMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6FCD910", Offset = "0x6FCC310", VA = "0x186FCD910")]
	private static void IHCADGKAIKP(ENCHAJJEIBN FIEMIMALOMA, Action<ALPADCMPKEI> GEABHDIDAJE, Predicate<FOMHPJHDBLN> AINBKDBJEPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6FD0E30", Offset = "0x6FCF830", VA = "0x186FD0E30")]
	private void PALIACEGCNB(JDKCNIBKGKE HNOBHNILHCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6FD08C0", Offset = "0x6FCF2C0", VA = "0x186FD08C0", Slot = "4")]
	[AsyncStateMachine(typeof(EMLODLFGDPA))]
	public Task ODFJAEFAPEM([CanBeNull] HOHHBPKCDBA IJFOGIEFCHH, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "5")]
	public void APBBLAJEMCJ(HOHHBPKCDBA IJFOGIEFCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6FD09E0", Offset = "0x6FCF3E0", VA = "0x186FD09E0")]
	private void OKOLJFFOAEC(ENCHAJJEIBN EAHPLDOHEEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6FCEBA0", Offset = "0x6FCD5A0", VA = "0x186FCEBA0")]
	internal static string JPGAENDPFKJ(HJKILCGALBP AOCLCNEKNAC, HOHHBPKCDBA IJFOGIEFCHH, IReadOnlyDictionary<FOMHPJHDBLN, JGANGOAPEPO> FCBHMEMNIMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6FCF2D0", Offset = "0x6FCDCD0", VA = "0x186FCF2D0")]
	private static void MNFMKOLNANJ(HOHHBPKCDBA IJFOGIEFCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6FCC730", Offset = "0x6FCB130", VA = "0x186FCC730")]
	private static void FAJCFGNKAJL(ENCHAJJEIBN JIAENBEBENE, IReadOnlyDictionary<FOMHPJHDBLN, JGANGOAPEPO> FCBHMEMNIMK, StringBuilder JLMHHBEBNGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6FD0D20", Offset = "0x6FCF720", VA = "0x186FD0D20")]
	private static bool OLFDGBBFOIH(string EIIBALFBPML, [Out] Guid LPAALGDCJOP, [Out] FOMHPJHDBLN IGIMJMKHFIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6FD0100", Offset = "0x6FCEB00", VA = "0x186FD0100")]
	private static void NFMHHBBLJLK(HOHHBPKCDBA IJFOGIEFCHH, StringBuilder JLMHHBEBNGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2CF16A0", Offset = "0x2CF00A0", VA = "0x182CF16A0", Slot = "16")]
	public bool NJCPKINKHEC<T>(FOMHPJHDBLN IGIMJMKHFIK, JCBMAGGLIJM DAEALJPONMC, bool LEGALBPGLBI, T PCNJMLOHDMH, [Optional] Action MIELOADBFFM) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6FD0840", Offset = "0x6FCF240", VA = "0x186FD0840", Slot = "17")]
	public string NKHJKPKHOJF(JCBMAGGLIJM DAEALJPONMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6FCE9A0", Offset = "0x6FCD3A0", VA = "0x186FCE9A0")]
	private void JOEDGMKHACM(FOMHPJHDBLN IGIMJMKHFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6FCBAC0", Offset = "0x6FCA4C0", VA = "0x186FCBAC0")]
	private bool BBNHKNNMAHF(JDKCNIBKGKE HNOBHNILHCN, FOMHPJHDBLN IGIMJMKHFIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6FCD380", Offset = "0x6FCBD80", VA = "0x186FCD380")]
	internal JGANGOAPEPO GDJIKJOJFAI(JDKCNIBKGKE HNOBHNILHCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6FCE990", Offset = "0x6FCD390", VA = "0x186FCE990", Slot = "13")]
	public IReadOnlyList<MLODGCHHJEM> JKGNLIJMPKO(JDKCNIBKGKE HNOBHNILHCN, bool BLCBCEFDIEJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6FCEEB0", Offset = "0x6FCD8B0", VA = "0x186FCEEB0")]
	internal IReadOnlyList<JGANGOAPEPO> KECEDGLNAMP(JDKCNIBKGKE HNOBHNILHCN, bool BLCBCEFDIEJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6FCE200", Offset = "0x6FCCC00", VA = "0x186FCE200")]
	private void JGIJOABDKPE(HJEDBNKDDIJ HGIFDBOGAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6FCBE10", Offset = "0x6FCA810", VA = "0x186FCBE10")]
	private static bool CDKGDLEEHJA(JGANGOAPEPO JOOMNCDBLNN, IReadOnlyDictionary<FOMHPJHDBLN, JGANGOAPEPO> FCBHMEMNIMK, [Out] IReadOnlyList<JCBMAGGLIJM> KLDECHNJJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6FCF190", Offset = "0x6FCDB90", VA = "0x186FCF190")]
	[AsyncStateMachine(typeof(BGGNEACIHOI))]
	private static Task MFKAKHINKEM(HJKILCGALBP AOCLCNEKNAC, HOHHBPKCDBA IJFOGIEFCHH, IReadOnlyDictionary<FOMHPJHDBLN, JGANGOAPEPO> FCBHMEMNIMK, OLPJGLPPFIJ LPIGFFIELAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6FCDF10", Offset = "0x6FCC910", VA = "0x186FCDF10")]
	[CompilerGenerated]
	internal static void IJDNJFIOBIF(Func<ALPADCMPKEI, NCKCBMNGCDL> BDEDDBANOBK, FFFMBKOLDBC P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6FCDBA0", Offset = "0x6FCC5A0", VA = "0x186FCDBA0")]
	[CompilerGenerated]
	internal static bool IHJAJLDBMDP(FOMHPJHDBLN IGIMJMKHFIK, JCBMAGGLIJM DAEALJPONMC, [Out] CAIKKGCODLA PIAFAEGKKDK, NDGLOBELLNM P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface PNLPEAPCFKP
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ANBLDEHEPID(JDKCNIBKGKE GFBEKFMPPGE, JDKCNIBKGKE LDPEPJLFBNP, IEnumerable<JDKCNIBKGKE> EAPFLOHPFCC, [Out] HHHGFPKFINI DMFKALMHONL, [Out] DMLNECFBFKH DMHFDJDPOFC);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string NCLJMHGLDHJ(DMLNECFBFKH FNBAOECHHEO);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum DMLNECFBFKH : byte
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
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class KHOLFIIFGCC : PNLPEAPCFKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly DPIDEAHFOIA FMJJAFBAAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly FHEOIMGNOOE EOLKEFABGGL;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x854210", Offset = "0x852C10", VA = "0x180854210")]
	[RecRoom.NoEngine.Common.Preserve]
	public KHOLFIIFGCC([OHLKLPAILPF(null)] DPIDEAHFOIA MGMMGFJMMJH, [OHLKLPAILPF(null)] FHEOIMGNOOE FDJMDAHPAPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6FC8BC0", Offset = "0x6FC75C0", VA = "0x186FC8BC0")]
	private static CBJHJLPJNDE? JKLMOLKGGGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6FC84B0", Offset = "0x6FC6EB0", VA = "0x186FC84B0", Slot = "4")]
	public bool ANBLDEHEPID(JDKCNIBKGKE GFBEKFMPPGE, JDKCNIBKGKE LDPEPJLFBNP, IEnumerable<JDKCNIBKGKE> EAPFLOHPFCC, [Out] HHHGFPKFINI DMFKALMHONL, [Out] DMLNECFBFKH DMHFDJDPOFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6FC8C00", Offset = "0x6FC7600", VA = "0x186FC8C00", Slot = "5")]
	public string NCLJMHGLDHJ(DMLNECFBFKH FNBAOECHHEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6FC85B0", Offset = "0x6FC6FB0", VA = "0x186FC85B0")]
	internal bool IGOECAPCDHM(JDKCNIBKGKE GFBEKFMPPGE, JDKCNIBKGKE LDPEPJLFBNP, IEnumerable<JDKCNIBKGKE> EAPFLOHPFCC, LGDDBNGBFNG MDFHAANEALD, CBJHJLPJNDE? FGAFNKAINEO, [Out] HHHGFPKFINI DMFKALMHONL, [Out] DMLNECFBFKH DMHFDJDPOFC)
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
