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
using RecRoom.DataLayer.Registration;
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
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C7E200", Offset = "0x7C7D600", VA = "0x187C7E200")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x975680", Offset = "0x974A80", VA = "0x180975680")]
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
		[Cpp2IlInjected.Address(RVA = "0x9756C0", Offset = "0x974AC0", VA = "0x1809756C0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum KDFIHOLAFHD
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
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7C814F0", Offset = "0x7C808F0", VA = "0x187C814F0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x242AF30", Offset = "0x242A330", VA = "0x18242AF30")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void HALOJIBAJGO<TPermission>(TPermission EGHDPMDNEOH);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void ICJNJGGIAJB(OPHKANJGPPK OEIBHCOIKMG);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum HJGDCDBGCDI
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface FPAODFHEKOB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BMMDBEOKNIL
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool GDJKKHBJANN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool LIKAMPCHBKO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool GCMHCMNCHIK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool FMJAOCOIPPN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool NAIGHNGJNKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class PIPCLBDBGHF
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum JLFDIJBPHNL
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
	public static readonly Guid AGICFFFHAKI;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid CKLCIBPMLFH;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid EPLMFLBMEEO;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid CBLKBCGAFIK;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid CEIJECEAIGN;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid NJDIMDMFFBI;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly MIPJNHEPHAG<KNBIGIEKHKK, Guid> HLHJFCPKGFH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<KNBIGIEKHKK> LMFPKICOKGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7C7E570", Offset = "0x7C7D970", VA = "0x187C7E570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7C7E6D0", Offset = "0x7C7DAD0", VA = "0x187C7E6D0")]
	public static KNBIGIEKHKK JJANLLKDCHP(Guid JINNLDEOCMO)
	{
		return default(KNBIGIEKHKK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7C7E830", Offset = "0x7C7DC30", VA = "0x187C7E830")]
	public static Guid MHCEECEMNFM(KNBIGIEKHKK EMCDAKNJOKJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7C7E7A0", Offset = "0x7C7DBA0", VA = "0x187C7E7A0")]
	public static bool MEGNBNGPPKC(KNBIGIEKHKK EMCDAKNJOKJ, [Out] Guid JINNLDEOCMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7C7E630", Offset = "0x7C7DA30", VA = "0x187C7E630")]
	public static bool EOHEEBKMHKE(Guid JINNLDEOCMO, [Out] KNBIGIEKHKK EMCDAKNJOKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7C7E760", Offset = "0x7C7DB60", VA = "0x187C7E760")]
	public static KNBIGIEKHKK MBDCHHKKAMJ(KNBIGIEKHKK EMCDAKNJOKJ)
	{
		return default(KNBIGIEKHKK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7C7E8D0", Offset = "0x7C7DCD0", VA = "0x187C7E8D0")]
	public static JLFDIJBPHNL OJIGIENEJGO(KNBIGIEKHKK LELHPDCIKMB)
	{
		return default(JLFDIJBPHNL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7C7E5F0", Offset = "0x7C7D9F0", VA = "0x187C7E5F0")]
	internal static KNBIGIEKHKK CMHMAJHMCOI(JLFDIJBPHNL FAHGCIOMJPE)
	{
		return default(KNBIGIEKHKK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GIGGPJHAEII : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	CBJFKPHOAFF NFENMFFCNEB
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<CGCJEGFAMCN> IDKPPKBPMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event ICJNJGGIAJB GJOJHNEFBAF;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<CGCJEGFAMCN> GCLGICFJIEI(bool HBOGEDBNOIC = false);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CGCJEGFAMCN NNEPGHLDHIP(OPHKANJGPPK OEIBHCOIKMG);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool ILPILJKNHOL(OPHKANJGPPK OEIBHCOIKMG);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<CGCJEGFAMCN> JAFFEDJFOBB(OPHKANJGPPK OEIBHCOIKMG, bool NNBADCCFFJP = false);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool AGLPAPHGECK(OPHKANJGPPK HJEEPHIOLFP, KNBIGIEKHKK EMCDAKNJOKJ);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	CGCJEGFAMCN BBJKAGKLLAD(KNBIGIEKHKK EMCDAKNJOKJ);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool BIOJLMGJHOJ<T>(KNBIGIEKHKK EMCDAKNJOKJ, PILFJONLANN EGHDPMDNEOH, bool NHKABEKLDED, T ICONKPKJBGN, [Optional] Action NFOHAIJEDFE) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string EKNEOGCBOLH(PILFJONLANN EGHDPMDNEOH);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface PEKEFELECPM
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task NFLCAHJOCEP(BDHMMMHCHAA MIMFFPFKBEA, CancellationToken LAEIHJHNGEK);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HOIJAOHBLEP(BDHMMMHCHAA MIMFFPFKBEA);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JPHFAAMMCNP
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	OPHKANJGPPK CKOIGGKJGGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	GDBFIEIFOFD GIAOPMCNFLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	EPDFKONBMMJ LOFGFEACKLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<FIDINBBNJBE> FNIADPOEBPD;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action CGJLHGCPJDJ;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KNBIGIEKHKK CJFCKDAMJAK(OPHKANJGPPK OEIBHCOIKMG);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<FIDINBBNJBE> FPNCJJBKEBF(CancellationToken LAEIHJHNGEK);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task BMCCPPALDNG(long FFFLOIOFAMB, IReadOnlyList<HBIEMMBKEGM> NPFCEMFIICG);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task JIGHNNAHDFD(long FFFLOIOFAMB, long GHFFAIKCNFL, IReadOnlyList<HBIEMMBKEGM> NPFCEMFIICG);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<OPHKANJGPPK> GLGEJPDOGIF();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class FIOIPPGAEJK
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7C748F0", Offset = "0x7C73CF0", VA = "0x187C748F0")]
	public static KNBIGIEKHKK CKHPCAOGFME(this JPHFAAMMCNP FPJDPMBFFOO)
	{
		return default(KNBIGIEKHKK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface DIPJBFPMHGO<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string EJHNIBIDOJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event HALOJIBAJGO<TPermission> FHIDGOKJGEE;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal abstract class OOCLACJIICG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal object? NDKDKHOHBGD;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? DOHKFKHCLNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7C7E380", Offset = "0x7C7D780", VA = "0x187C7E380")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7C7E280", Offset = "0x7C7D680", VA = "0x187C7E280")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7C7E460", Offset = "0x7C7D860", VA = "0x187C7E460")]
	protected OOCLACJIICG(object? HDJBIGOPFKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool INPBODAIAMI(object? KBGCCIOIGBD);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class BBPIIKFNKEN<T> : OOCLACJIICG where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> BLMEGMHOING;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T DEDOPNLMLPL
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x58367D0", Offset = "0x5835BD0", VA = "0x1858367D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5836EB0", Offset = "0x58362B0", VA = "0x185836EB0", Slot = "4")]
	public override bool INPBODAIAMI(object? KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5837330", Offset = "0x5836730", VA = "0x185837330")]
	public bool JOCOIBDIKEF(T PEINLMNOHNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5837490", Offset = "0x5836890", VA = "0x185837490")]
	public BBPIIKFNKEN(T IDJBNLNBJCD, IEqualityComparer<T> BLMEGMHOING)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class IDDCKGDDLIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<PILFJONLANN, bool> DMLINDJMKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<PILFJONLANN, OOCLACJIICG> BPPMNGOCGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly DHBFHKKLBFJ JDHIPEMIJLK;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7C74F00", Offset = "0x7C74300", VA = "0x187C74F00")]
	public IDDCKGDDLIL(DHBFHKKLBFJ JDHIPEMIJLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7C74E90", Offset = "0x7C74290", VA = "0x187C74E90")]
	public bool PLBEBHKLOEL(PILFJONLANN EGHDPMDNEOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x33BF5D0", Offset = "0x33BE9D0", VA = "0x1833BF5D0")]
	public bool PCHDGMEKDNP<T>(PILFJONLANN EGHDPMDNEOH, bool NHKABEKLDED, T KBGCCIOIGBD) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x33BF130", Offset = "0x33BE530", VA = "0x1833BF130")]
	public (bool, T?) GGLJEPLEJDG<T>(PILFJONLANN EGHDPMDNEOH) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7C74DB0", Offset = "0x7C741B0", VA = "0x187C74DB0")]
	public bool PCHDGMEKDNP(PILFJONLANN EGHDPMDNEOH, bool NHKABEKLDED, object KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7C74B40", Offset = "0x7C73F40", VA = "0x187C74B40")]
	public (bool, object) GGLJEPLEJDG(PILFJONLANN EGHDPMDNEOH)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x33BFB70", Offset = "0x33BEF70", VA = "0x1833BFB70")]
	private void PFLNGFGKPOE<T>(PILFJONLANN EGHDPMDNEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7C74CE0", Offset = "0x7C740E0", VA = "0x187C74CE0")]
	private OOCLACJIICG GLDGPBGLHEF(PILFJONLANN EGHDPMDNEOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7C74950", Offset = "0x7C73D50", VA = "0x187C74950")]
	public void CHOEMPIPBHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class NAJOPJHNBAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string DDMJIJIMJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type MFADBKBBJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly KJANNBGPAGB MKOOMNDECOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly PILFJONLANN DDOHINFKFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public DGDLIDNPBMH BCMGMIGHHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public KJOJBIAOPPM JHELCEBAFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public DHNNOFGLOBE DLMEOLAJJPH;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7C77D30", Offset = "0x7C77130", VA = "0x187C77D30")]
	public NAJOPJHNBAP(Type BLIGGHAFLJO, string OOPCHLJEAEO, PILFJONLANN EGHDPMDNEOH, DGDLIDNPBMH BGILCOILLMG, KJOJBIAOPPM JODFCFDJHDE, DHNNOFGLOBE EMKPFEDONNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7C77C30", Offset = "0x7C77030", VA = "0x187C77C30")]
	public object JEAAHAHKFMN(object? OKCHLIEAIJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x352CE30", Offset = "0x352C230", VA = "0x18352CE30")]
	public void PFLNGFGKPOE<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7C77C80", Offset = "0x7C77080", VA = "0x187C77C80")]
	public void PFLNGFGKPOE(Type KOGGBHKBFBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class HJHPJMOEEHH<T> : NAJOPJHNBAP where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate string PCGNDHKBHLJ(T KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal delegate T GGHPOLCKPJJ(string? CHMMDPKNGNM, T IDJBNLNBJCD);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class AKOJGKMANJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public PCGNDHKBHLJ serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public GGHPOLCKPJJ parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public AKOJGKMANJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x487D120", Offset = "0x487C520", VA = "0x18487D120")]
		internal string MMFIKBIHOOK(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x487CFD0", Offset = "0x487C3D0", VA = "0x18487CFD0")]
		internal object BIBMCJOGPJP(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x461B760", Offset = "0x461AB60", VA = "0x18461B760")]
	public HJHPJMOEEHH(PILFJONLANN EGHDPMDNEOH, string OOPCHLJEAEO, [Optional] PCGNDHKBHLJ? BGILCOILLMG, [Optional] GGHPOLCKPJJ? JODFCFDJHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x461A8F0", Offset = "0x4619CF0", VA = "0x18461A8F0")]
	private static object? GFOCOOKFNLL(GGHPOLCKPJJ? JODFCFDJHDE, string? CHMMDPKNGNM, object? IDJBNLNBJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x461AEE0", Offset = "0x461A2E0", VA = "0x18461AEE0")]
	private static string IMJDHHAECMF(PCGNDHKBHLJ? MHDFIAJJGGP, object? KBGCCIOIGBD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate string DGDLIDNPBMH(object? KBGCCIOIGBD);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate object KJOJBIAOPPM(string? CHMMDPKNGNM, [Optional] object IDJBNLNBJCD);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal delegate OOCLACJIICG DHNNOFGLOBE();
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class DHBFHKKLBFJ
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class MNGLFPCOCDH : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static MNGLFPCOCDH IMFIEPMCPDC;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7C778F0", Offset = "0x7C76CF0", VA = "0x187C778F0", Slot = "4")]
		public bool Equals(List<string> IKAEODCKAIP, List<string> ACCJFOPIMAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7C77A40", Offset = "0x7C76E40", VA = "0x187C77A40", Slot = "5")]
		public int GetHashCode(List<string> GMFKPONAANG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public MNGLFPCOCDH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class LMAFHCOCODO : OCNHMOLGBNC<KDFIHOLAFHD>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7C76630", Offset = "0x7C75A30", VA = "0x187C76630", Slot = "9")]
		public override string IMJDHHAECMF(KDFIHOLAFHD IOJLNNHDMIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7C76720", Offset = "0x7C75B20", VA = "0x187C76720", Slot = "10")]
		protected override bool OIOCMMLCKLE(string IOJLNNHDMIE, [Out] KDFIHOLAFHD KBGCCIOIGBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7C76900", Offset = "0x7C75D00", VA = "0x187C76900")]
		public LMAFHCOCODO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly OOPOHNNAHCM HJDDDFMBDLB;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly LMAFHCOCODO IKHMKKICHMK;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<NAJOPJHNBAP> BFKFBHHFDDA;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<PILFJONLANN> KHFAONIDOPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<PILFJONLANN, NAJOPJHNBAP> CLHAAJJJPMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7C745A0", Offset = "0x7C739A0", VA = "0x187C745A0")]
	public DHBFHKKLBFJ([Optional] IList<NAJOPJHNBAP>? JGEOMBNDBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7C73060", Offset = "0x7C72460", VA = "0x187C73060")]
	public NAJOPJHNBAP HBJPFBPHLNK(PILFJONLANN EGHDPMDNEOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface CBJFKPHOAFF
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	CGCJEGFAMCN AAKGLACAOJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class LMJPGMOHELA : CBJFKPHOAFF
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static LMJPGMOHELA OFBJNKLPCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly POFADHGEPFN OLFEFDBKKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<POFADHGEPFN> KJGBANIPDOG;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public CGCJEGFAMCN AAKGLACAOJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7C777E0", Offset = "0x7C76BE0", VA = "0x187C777E0")]
	public LMJPGMOHELA(POFADHGEPFN DKEIFNPOCHC, IReadOnlyList<POFADHGEPFN> DBJPGFFPPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7C76940", Offset = "0x7C75D40", VA = "0x187C76940")]
	private static LMJPGMOHELA BHKKLANLCHB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class COFGPELPKEB
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<KNBIGIEKHKK> AMBJFMLKGOH;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7C72D50", Offset = "0x7C72150", VA = "0x187C72D50")]
	public static bool JPFFIHKCHKD(this OPHKANJGPPK EFGAKBIDOLG, KNBIGIEKHKK EMCDAKNJOKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7C72E30", Offset = "0x7C72230", VA = "0x187C72E30")]
	public static bool LEDLEMJJJFH(this OPHKANJGPPK EFGAKBIDOLG, KNBIGIEKHKK EMCDAKNJOKJ, EPDFKONBMMJ OMEABIGPMID)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface MIEPJLOCCEI
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool CPNCAMBEOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool OLLHEPPCHDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool PDPJJINOGJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool AHJKLJPGAGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool ECAIEMEBNPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool HNNDMJFCIMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool OPEFBCBFHFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool ALLBINKPGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool JLIGPDIIGPI
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool LOPEKEBNMII
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool GEOGKMMNLEP
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool MHGAMJGOGOL
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> MCHNMDKDNDG
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	KDFIHOLAFHD DJCDINOMHHK
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface CGCJEGFAMCN : MIEPJLOCCEI, FPAODFHEKOB, DIPJBFPMHGO<PILFJONLANN>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string FFEBDELOBJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	KNBIGIEKHKK MCOGPOJLJCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) OAEHEEOBADH<T>(PILFJONLANN EGHDPMDNEOH) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum PILFJONLANN
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
internal class POFADHGEPFN : CGCJEGFAMCN, MIEPJLOCCEI, FPAODFHEKOB, DIPJBFPMHGO<PILFJONLANN>
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly DHBFHKKLBFJ MMEECKJHHEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	internal readonly IDDCKGDDLIL EEFCFENBIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private string? JMEBCMNPEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private string? LFIAMEOFCGL;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool DHGKJAFKALC
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7C7FE60", Offset = "0x7C7F260", VA = "0x187C7FE60", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool DGHDDEJODIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7C7FF00", Offset = "0x7C7F300", VA = "0x187C7FF00", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool LBKNKDFFCEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7C7EEF0", Offset = "0x7C7E2F0", VA = "0x187C7EEF0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool FHCLEELKHNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7C7EF40", Offset = "0x7C7E340", VA = "0x187C7EF40", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool LJOHGIHJPJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7C80200", Offset = "0x7C7F600", VA = "0x187C80200", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool CKCMLLCMONG
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7C7EF90", Offset = "0x7C7E390", VA = "0x187C7EF90", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public KNBIGIEKHKK MCOGPOJLJCK
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xBACAA0", Offset = "0xBABEA0", VA = "0x180BACAA0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(KNBIGIEKHKK);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x949420", Offset = "0x948820", VA = "0x180949420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string EJHNIBIDOJA
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7C80440", Offset = "0x7C7F840", VA = "0x187C80440", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7C80960", Offset = "0x7C7FD60", VA = "0x187C80960")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string FFEBDELOBJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7C80440", Offset = "0x7C7F840", VA = "0x187C80440", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool KOMNNFOJFFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xC14E20", Offset = "0xC14220", VA = "0x180C14E20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xC14E40", Offset = "0xC14240", VA = "0x180C14E40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool CPNCAMBEOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7C80570", Offset = "0x7C7F970", VA = "0x187C80570", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public KDFIHOLAFHD DJCDINOMHHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7C809B0", Offset = "0x7C7FDB0", VA = "0x187C809B0", Slot = "20")]
		get
		{
			return default(KDFIHOLAFHD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool OLLHEPPCHDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7C80250", Offset = "0x7C7F650", VA = "0x187C80250", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool PDPJJINOGJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7C7FF50", Offset = "0x7C7F350", VA = "0x187C7FF50", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool AHJKLJPGAGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7C7FEB0", Offset = "0x7C7F2B0", VA = "0x187C7FEB0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool ECAIEMEBNPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7C80A50", Offset = "0x7C7FE50", VA = "0x187C80A50", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool HNNDMJFCIMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7C7F090", Offset = "0x7C7E490", VA = "0x187C7F090", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool OPEFBCBFHFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7C80910", Offset = "0x7C7FD10", VA = "0x187C80910", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool ALLBINKPGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7C80340", Offset = "0x7C7F740", VA = "0x187C80340", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool JLIGPDIIGPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7C7ECA0", Offset = "0x7C7E0A0", VA = "0x187C7ECA0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> MCHNMDKDNDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7C808B0", Offset = "0x7C7FCB0", VA = "0x187C808B0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool DAFNFKGFCFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7C7FE60", Offset = "0x7C7F260", VA = "0x187C7FE60", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool BMJODMOMGFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7C80200", Offset = "0x7C7F600", VA = "0x187C80200", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool MNJDIAEGMFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7C7FF00", Offset = "0x7C7F300", VA = "0x187C7FF00", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool LOPEKEBNMII
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7C80020", Offset = "0x7C7F420", VA = "0x187C80020", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool GEOGKMMNLEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7C802F0", Offset = "0x7C7F6F0", VA = "0x187C802F0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool PEEGCIJNEED
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7C7EEF0", Offset = "0x7C7E2F0", VA = "0x187C7EEF0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool MHGAMJGOGOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7C802A0", Offset = "0x7C7F6A0", VA = "0x187C802A0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool CHMMJKEOCAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7C7EF40", Offset = "0x7C7E340", VA = "0x187C7EF40", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool CCBAGLAEGAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7C7EF90", Offset = "0x7C7E390", VA = "0x187C7EF90", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event HALOJIBAJGO<PILFJONLANN> FHIDGOKJGEE
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7C80390", Offset = "0x7C7F790", VA = "0x187C80390", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7C7EFE0", Offset = "0x7C7E3E0", VA = "0x187C7EFE0", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x35CFE20", Offset = "0x35CF220", VA = "0x1835CFE20", Slot = "6")]
	public (bool, T?) OAEHEEOBADH<T>(PILFJONLANN EGHDPMDNEOH) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x35D0010", Offset = "0x35CF410", VA = "0x1835D0010")]
	public POFADHGEPFN PGGODCNMLCP<T>(PILFJONLANN EGHDPMDNEOH, bool NHKABEKLDED, T KBGCCIOIGBD) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7C80B50", Offset = "0x7C7FF50", VA = "0x187C80B50")]
	public POFADHGEPFN(KNBIGIEKHKK EMCDAKNJOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7C80B30", Offset = "0x7C7FF30", VA = "0x187C80B30")]
	public POFADHGEPFN(KNBIGIEKHKK EMCDAKNJOKJ, [Optional] string? JMEBCMNPEII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7C80CD0", Offset = "0x7C800D0", VA = "0x187C80CD0")]
	public POFADHGEPFN(POFADHGEPFN MNKIKCMPCLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7C80B70", Offset = "0x7C7FF70", VA = "0x187C80B70")]
	internal POFADHGEPFN(KNBIGIEKHKK GCDENDPEIIA, [Optional] string? JMEBCMNPEII, [Optional] POFADHGEPFN? MNKIKCMPCLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7C7FFA0", Offset = "0x7C7F3A0", VA = "0x187C7FFA0")]
	public static KJANNBGPAGB EOMDFHIEOJK(PILFJONLANN EGHDPMDNEOH)
	{
		return default(KJANNBGPAGB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7C7FE40", Offset = "0x7C7F240", VA = "0x187C7FE40")]
	public void CHOEMPIPBHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7C805C0", Offset = "0x7C7F9C0", VA = "0x187C805C0")]
	internal POFADHGEPFN KJHFOMGAEOH(POFADHGEPFN LEBHFJIGNCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7C7F0E0", Offset = "0x7C7E4E0", VA = "0x187C7F0E0")]
	internal IReadOnlyCollection<PILFJONLANN> CFNGCKEKLEF(POFADHGEPFN MNKIKCMPCLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7C80490", Offset = "0x7C7F890", VA = "0x187C80490")]
	public bool JLDJIICGPNP(PILFJONLANN EGHDPMDNEOH, bool NHKABEKLDED, string GOFICEGCKGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7C80070", Offset = "0x7C7F470", VA = "0x187C80070")]
	public (bool, string) FHGLMEANLKF(PILFJONLANN EGHDPMDNEOH)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7C80A00", Offset = "0x7C7FE00", VA = "0x187C80A00")]
	internal void PECEADAGFLD(PILFJONLANN EGHDPMDNEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7C7ECF0", Offset = "0x7C7E0F0", VA = "0x187C7ECF0")]
	public KJDHCMLEMGL AJHIJKHBOOK(Func<KNBIGIEKHKK, Guid> BMMPMBGOIPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7C7F4C0", Offset = "0x7C7E8C0", VA = "0x187C7F4C0")]
	public void CHMOFHCCLNE(KJDHCMLEMGL EOHHDOALPPO, Func<Guid, KNBIGIEKHKK> NAOCCCLOEOB, [Optional] KNBIGIEKHKK? GOJMDLIHHAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7C80170", Offset = "0x7C7F570", VA = "0x187C80170")]
	[CompilerGenerated]
	private void FLCPACENEBB(PILFJONLANN BKHJIOHCKKF, PEIDMNINPMC FIPGPPGPKOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class NCKLKHAODFJ : PEKEFELECPM, GIGGPJHAEII, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class IOFHJAGKKOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public POFADHGEPFN newRole;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public IOFHJAGKKOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7C751B0", Offset = "0x7C745B0", VA = "0x187C751B0")]
		internal bool DHGLGPCAMJA(POFADHGEPFN rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class FIJDOPBAILP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public KNBIGIEKHKK roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public FIJDOPBAILP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x199F6D0", Offset = "0x199EAD0", VA = "0x18199F6D0")]
		internal bool DIBJEIJNFPG(KNBIGIEKHKK r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct KLJMEJAEEOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public NCKLKHAODFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public BDHMMMHCHAA roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private TaskAwaiter<FIDINBBNJBE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7C75F60", Offset = "0x7C75360", VA = "0x187C75F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7C765D0", Offset = "0x7C759D0", VA = "0x187C765D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class JDIJBBMPHKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public JDIJBBMPHKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7C751E0", Offset = "0x7C745E0", VA = "0x187C751E0")]
		internal void CJLOCMBNABI(KJDHCMLEMGL r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7C752C0", Offset = "0x7C746C0", VA = "0x187C752C0")]
		internal void FFHENMADNAN(KJDHCMLEMGL r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct PIENMDLDNIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public BDHMMMHCHAA roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class NFNJDBGJCDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Func<KJDHCMLEMGL, PEIDMNINPMC> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public NFNJDBGJCDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7C7E1D0", Offset = "0x7C7D5D0", VA = "0x187C7E1D0")]
		internal void MJKHDLHLMAB(KJDHCMLEMGL r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7C7E170", Offset = "0x7C7D570", VA = "0x187C7E170")]
		internal void FDGGDGDEPGO(KJDHCMLEMGL r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7C7E1A0", Offset = "0x7C7D5A0", VA = "0x187C7E1A0")]
		internal void JFHDEKCODPC(KJDHCMLEMGL r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class JGNOEMBDOFI<T> where T : notnull
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
			public JGNOEMBDOFI<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private TaskAwaiter<FIDINBBNJBE> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x3CE65F0", Offset = "0x3CE59F0", VA = "0x183CE65F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xA48F40", Offset = "0xA48340", VA = "0x180A48F40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public PILFJONLANN rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public KNBIGIEKHKK accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public KJANNBGPAGB recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public NCKLKHAODFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public JGNOEMBDOFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4970A20", Offset = "0x496FE20", VA = "0x184970A20")]
		[AsyncStateMachine(typeof(JGNOEMBDOFI<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void DOPLANCNINN()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct EHOBFOLABMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public IReadOnlyList<HBIEMMBKEGM> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct JHDGCLNDJDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public JPHFAAMMCNP rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public BDHMMMHCHAA roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public IReadOnlyDictionary<KNBIGIEKHKK, POFADHGEPFN> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public CCAOPILOOAO debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7C753E0", Offset = "0x7C747E0", VA = "0x187C753E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7C75F00", Offset = "0x7C75300", VA = "0x187C75F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly JPHFAAMMCNP FPJDPMBFFOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly LMJPGMOHELA PLINMGPKLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly CCAOPILOOAO AJLMACGMCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly Dictionary<int, POFADHGEPFN> NPAPEHIHJPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	internal readonly Dictionary<KNBIGIEKHKK, POFADHGEPFN> HKDCBHKLEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	internal readonly Dictionary<KNBIGIEKHKK, POFADHGEPFN> MMPAFMFHLHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	internal readonly List<POFADHGEPFN> HCMKANIAIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private bool PGHIBLDKKKH;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static readonly PILFJONLANN[] EBPOAJKDJLN;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public CBJFKPHOAFF NFENMFFCNEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<CGCJEGFAMCN> IDKPPKBPMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7C786A0", Offset = "0x7C77AA0", VA = "0x187C786A0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event ICJNJGGIAJB GJOJHNEFBAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7C783B0", Offset = "0x7C777B0", VA = "0x187C783B0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7C78A70", Offset = "0x7C77E70", VA = "0x187C78A70", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7C78150", Offset = "0x7C77550", VA = "0x187C78150")]
	[HLOHOCOKELO.JGEFFJBDHJI]
	internal static void AOKDCDMDNDH(GFKEMDIOCPC BFAKMKOHPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7C7D660", Offset = "0x7C7CA60", VA = "0x187C7D660")]
	[UnityEngine.Scripting.Preserve]
	internal NCKLKHAODFJ([IBJCGEMJMJL(null)] JPHFAAMMCNP OCNNOAEPOKM, [IBJCGEMJMJL(null)] LMJPGMOHELA IHIIMNPNKFB, [IBJCGEMJMJL(null)] CCAOPILOOAO AJLMACGMCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7C79910", Offset = "0x7C78D10", VA = "0x187C79910", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7C79090", Offset = "0x7C78490", VA = "0x187C79090")]
	private void DIELDMACJPD(IEnumerable<POFADHGEPFN> LNMAEHGLAPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7C7B090", Offset = "0x7C7A490", VA = "0x187C7B090", Slot = "12")]
	public bool ILPILJKNHOL(OPHKANJGPPK OEIBHCOIKMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7C78B10", Offset = "0x7C77F10", VA = "0x187C78B10")]
	private void CGJLHGCPJDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7C77F60", Offset = "0x7C77360", VA = "0x187C77F60")]
	private void ALGAHNFAPHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7C7AC30", Offset = "0x7C7A030", VA = "0x187C7AC30", Slot = "10")]
	public IReadOnlyList<CGCJEGFAMCN> GCLGICFJIEI(bool HBOGEDBNOIC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7C7C5F0", Offset = "0x7C7B9F0", VA = "0x187C7C5F0", Slot = "11")]
	public CGCJEGFAMCN NNEPGHLDHIP(OPHKANJGPPK OEIBHCOIKMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7C7ACB0", Offset = "0x7C7A0B0", VA = "0x187C7ACB0")]
	private KNBIGIEKHKK HONBKCGCAGI(OPHKANJGPPK OEIBHCOIKMG)
	{
		return default(KNBIGIEKHKK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7C77DD0", Offset = "0x7C771D0", VA = "0x187C77DD0", Slot = "14")]
	public bool AGLPAPHGECK(OPHKANJGPPK HJEEPHIOLFP, KNBIGIEKHKK EMCDAKNJOKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7C78310", Offset = "0x7C77710", VA = "0x187C78310", Slot = "15")]
	public CGCJEGFAMCN BBJKAGKLLAD(KNBIGIEKHKK EMCDAKNJOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7C7B6E0", Offset = "0x7C7AAE0", VA = "0x187C7B6E0")]
	private static bool MHIKEGMFNOA(GIMGIJILDCH PPECHIGOHBL, KNBIGIEKHKK EMCDAKNJOKJ, [Out] KJDHCMLEMGL? KMGGGKGAKMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7C7C500", Offset = "0x7C7B900", VA = "0x187C7C500")]
	private static void NGMPCBFDION(GIMGIJILDCH PPECHIGOHBL, Action<KJDHCMLEMGL> LIMKNMFMDKK, KNBIGIEKHKK JJAKAMPJDEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7C7C270", Offset = "0x7C7B670", VA = "0x187C7C270")]
	private static void NGMPCBFDION(GIMGIJILDCH PPECHIGOHBL, Action<KJDHCMLEMGL> LIMKNMFMDKK, Predicate<KNBIGIEKHKK> OIKNEKMDEBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7C7ABC0", Offset = "0x7C79FC0", VA = "0x187C7ABC0")]
	private void ELALGDHBPMF(OPHKANJGPPK OEIBHCOIKMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7C7C150", Offset = "0x7C7B550", VA = "0x187C7C150", Slot = "4")]
	[AsyncStateMachine(typeof(KLJMEJAEEOI))]
	public Task NFLCAHJOCEP([CanBeNull] BDHMMMHCHAA MIMFFPFKBEA, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
	public void HOIJAOHBLEP(BDHMMMHCHAA MIMFFPFKBEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7C7B3A0", Offset = "0x7C7A7A0", VA = "0x187C7B3A0")]
	private void KLNNDLENPMA(GIMGIJILDCH DCELFPLPBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7C7AD80", Offset = "0x7C7A180", VA = "0x187C7AD80")]
	internal static string IBADLBGIIFK(JPHFAAMMCNP FPJDPMBFFOO, BDHMMMHCHAA MIMFFPFKBEA, IReadOnlyDictionary<KNBIGIEKHKK, POFADHGEPFN> HKDCBHKLEKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7C79D10", Offset = "0x7C79110", VA = "0x187C79D10")]
	private static void EKIKGCLNGOJ(BDHMMMHCHAA MIMFFPFKBEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7C7C700", Offset = "0x7C7BB00", VA = "0x187C7C700")]
	private static void NPMFBGGGOGA(GIMGIJILDCH HAHNJAMKKLJ, IReadOnlyDictionary<KNBIGIEKHKK, POFADHGEPFN> HKDCBHKLEKH, StringBuilder FMELKOLPLEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7C78450", Offset = "0x7C77850", VA = "0x187C78450")]
	private static bool BLOEJCIGLJE(string BPJIGPJFNGO, [Out] Guid LLDJIFPIHGK, [Out] KNBIGIEKHKK EMCDAKNJOKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7C7BA10", Offset = "0x7C7AE10", VA = "0x187C7BA10")]
	private static void NCEAGKHHKBD(BDHMMMHCHAA MIMFFPFKBEA, StringBuilder FMELKOLPLEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3530CB0", Offset = "0x35300B0", VA = "0x183530CB0", Slot = "16")]
	public bool BIOJLMGJHOJ<T>(KNBIGIEKHKK EMCDAKNJOKJ, PILFJONLANN EGHDPMDNEOH, bool NHKABEKLDED, T ICONKPKJBGN, [Optional] Action NFOHAIJEDFE) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7C7AB40", Offset = "0x7C79F40", VA = "0x187C7AB40", Slot = "17")]
	public string EKNEOGCBOLH(PILFJONLANN EGHDPMDNEOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7C7B170", Offset = "0x7C7A570", VA = "0x187C7B170")]
	private void JAOFDFNCPIA(KNBIGIEKHKK EMCDAKNJOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7C7B380", Offset = "0x7C7A780", VA = "0x187C7B380")]
	private bool JEOJMPHHMFF(OPHKANJGPPK OEIBHCOIKMG, KNBIGIEKHKK EMCDAKNJOKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7C78B20", Offset = "0x7C77F20", VA = "0x187C78B20")]
	internal POFADHGEPFN CJGJEMLCEOM(OPHKANJGPPK OEIBHCOIKMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7C7B160", Offset = "0x7C7A560", VA = "0x187C7B160", Slot = "13")]
	public IReadOnlyList<CGCJEGFAMCN> JAFFEDJFOBB(OPHKANJGPPK OEIBHCOIKMG, bool NNBADCCFFJP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7C78E60", Offset = "0x7C78260", VA = "0x187C78E60")]
	internal IReadOnlyList<POFADHGEPFN> COFCNAIAKGC(OPHKANJGPPK OEIBHCOIKMG, bool NNBADCCFFJP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7C7CA50", Offset = "0x7C7BE50", VA = "0x187C7CA50")]
	private void PDELPAIHPBM(FIDINBBNJBE EBKKGHAFPPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7C79A20", Offset = "0x7C78E20", VA = "0x187C79A20")]
	private static bool EJCAKBOLPNE(POFADHGEPFN BDIAAHCKKFG, IReadOnlyDictionary<KNBIGIEKHKK, POFADHGEPFN> HKDCBHKLEKH, [Out] IReadOnlyList<PILFJONLANN> PBPJALFMEKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7C78560", Offset = "0x7C77960", VA = "0x187C78560")]
	[AsyncStateMachine(typeof(JHDGCLNDJDP))]
	private static Task BPMJKJMCFJJ(JPHFAAMMCNP FPJDPMBFFOO, BDHMMMHCHAA MIMFFPFKBEA, IReadOnlyDictionary<KNBIGIEKHKK, POFADHGEPFN> HKDCBHKLEKH, CCAOPILOOAO AJLMACGMCAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7C7D1F0", Offset = "0x7C7C5F0", VA = "0x187C7D1F0")]
	[CompilerGenerated]
	internal static void PKNNEEEMGIA(Func<KJDHCMLEMGL, PEIDMNINPMC> GNFEKHEBKLG, PIENMDLDNIE P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7C786F0", Offset = "0x7C77AF0", VA = "0x187C786F0")]
	[CompilerGenerated]
	internal static bool CEIKOABDNFO(KNBIGIEKHKK EMCDAKNJOKJ, PILFJONLANN EGHDPMDNEOH, [Out] HBIEMMBKEGM OCBFHLEPMLF, EHOBFOLABMM P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface LOBMGKNJAKK
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MALDFHCEHNA(OPHKANJGPPK LAFJEOJMADD, OPHKANJGPPK BEEGBMHIDKI, IEnumerable<OPHKANJGPPK> CFLPFODFLAF, [Out] KDFIHOLAFHD AFPONLEEICE, [Out] KNODAPBHNNC GMCMOLADKHN);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string LAOCILFACBC(KNODAPBHNNC DNLFECOCBNO);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public enum KNODAPBHNNC : byte
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
internal class NEFODFHEKIF : LOBMGKNJAKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly GIGGPJHAEII GADFAMHLKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly NAECFABJCIE HGBGFCOHGNN;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x957D80", Offset = "0x957180", VA = "0x180957D80")]
	[RecRoom.NoEngine.Common.Preserve]
	public NEFODFHEKIF([IBJCGEMJMJL(null)] GIGGPJHAEII HCCLLPNKFMA, [IBJCGEMJMJL(null)] NAECFABJCIE PGPFMABFGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7C7DF30", Offset = "0x7C7D330", VA = "0x187C7DF30")]
	private static KAKJLAMFNPB? FGCELJNODAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7C7E070", Offset = "0x7C7D470", VA = "0x187C7E070", Slot = "4")]
	public bool MALDFHCEHNA(OPHKANJGPPK LAFJEOJMADD, OPHKANJGPPK BEEGBMHIDKI, IEnumerable<OPHKANJGPPK> CFLPFODFLAF, [Out] KDFIHOLAFHD AFPONLEEICE, [Out] KNODAPBHNNC GMCMOLADKHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7C7DF70", Offset = "0x7C7D370", VA = "0x187C7DF70", Slot = "5")]
	public string LAOCILFACBC(KNODAPBHNNC DNLFECOCBNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7C7D920", Offset = "0x7C7CD20", VA = "0x187C7D920")]
	internal bool DHHAJLKBJJM(OPHKANJGPPK LAFJEOJMADD, OPHKANJGPPK BEEGBMHIDKI, IEnumerable<OPHKANJGPPK> CFLPFODFLAF, EPDFKONBMMJ OMEABIGPMID, KAKJLAMFNPB? OPIPKPFJMCN, [Out] KDFIHOLAFHD AFPONLEEICE, [Out] KNODAPBHNNC GMCMOLADKHN)
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
