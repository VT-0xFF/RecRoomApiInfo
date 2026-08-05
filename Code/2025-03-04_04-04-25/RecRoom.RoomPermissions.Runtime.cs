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
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D228D0", Offset = "0x7D20ED0", VA = "0x187D228D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x97C6E0", Offset = "0x97ACE0", VA = "0x18097C6E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x97C720", Offset = "0x97AD20", VA = "0x18097C720")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D25BC0", Offset = "0x7D241C0", VA = "0x187D25BC0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x245DCB0", Offset = "0x245C2B0", VA = "0x18245DCB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D22C40", Offset = "0x7D21240", VA = "0x187D22C40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7D22DA0", Offset = "0x7D213A0", VA = "0x187D22DA0")]
	public static KNBIGIEKHKK JJANLLKDCHP(Guid JINNLDEOCMO)
	{
		return default(KNBIGIEKHKK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7D22F00", Offset = "0x7D21500", VA = "0x187D22F00")]
	public static Guid MHCEECEMNFM(KNBIGIEKHKK EMCDAKNJOKJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7D22E70", Offset = "0x7D21470", VA = "0x187D22E70")]
	public static bool MEGNBNGPPKC(KNBIGIEKHKK EMCDAKNJOKJ, [Out] Guid JINNLDEOCMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7D22D00", Offset = "0x7D21300", VA = "0x187D22D00")]
	public static bool EOHEEBKMHKE(Guid JINNLDEOCMO, [Out] KNBIGIEKHKK EMCDAKNJOKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7D22E30", Offset = "0x7D21430", VA = "0x187D22E30")]
	public static KNBIGIEKHKK MBDCHHKKAMJ(KNBIGIEKHKK EMCDAKNJOKJ)
	{
		return default(KNBIGIEKHKK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7D22FA0", Offset = "0x7D215A0", VA = "0x187D22FA0")]
	public static JLFDIJBPHNL OJIGIENEJGO(KNBIGIEKHKK LELHPDCIKMB)
	{
		return default(JLFDIJBPHNL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7D22CC0", Offset = "0x7D212C0", VA = "0x187D22CC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7D18FC0", Offset = "0x7D175C0", VA = "0x187D18FC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D22A50", Offset = "0x7D21050", VA = "0x187D22A50")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7D22950", Offset = "0x7D20F50", VA = "0x187D22950")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7D22B30", Offset = "0x7D21130", VA = "0x187D22B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x589A0C0", Offset = "0x58986C0", VA = "0x18589A0C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x589A7A0", Offset = "0x5898DA0", VA = "0x18589A7A0", Slot = "4")]
	public override bool INPBODAIAMI(object? KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x589AC20", Offset = "0x5899220", VA = "0x18589AC20")]
	public bool JOCOIBDIKEF(T PEINLMNOHNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x589AD80", Offset = "0x5899380", VA = "0x18589AD80")]
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
	[Cpp2IlInjected.Address(RVA = "0x7D195D0", Offset = "0x7D17BD0", VA = "0x187D195D0")]
	public IDDCKGDDLIL(DHBFHKKLBFJ JDHIPEMIJLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7D19560", Offset = "0x7D17B60", VA = "0x187D19560")]
	public bool PLBEBHKLOEL(PILFJONLANN EGHDPMDNEOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x34043C0", Offset = "0x34029C0", VA = "0x1834043C0")]
	public bool PCHDGMEKDNP<T>(PILFJONLANN EGHDPMDNEOH, bool NHKABEKLDED, T KBGCCIOIGBD) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3403F20", Offset = "0x3402520", VA = "0x183403F20")]
	public (bool, T?) GGLJEPLEJDG<T>(PILFJONLANN EGHDPMDNEOH) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7D19480", Offset = "0x7D17A80", VA = "0x187D19480")]
	public bool PCHDGMEKDNP(PILFJONLANN EGHDPMDNEOH, bool NHKABEKLDED, object KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7D19210", Offset = "0x7D17810", VA = "0x187D19210")]
	public (bool, object) GGLJEPLEJDG(PILFJONLANN EGHDPMDNEOH)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3404960", Offset = "0x3402F60", VA = "0x183404960")]
	private void PFLNGFGKPOE<T>(PILFJONLANN EGHDPMDNEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7D193B0", Offset = "0x7D179B0", VA = "0x187D193B0")]
	private OOCLACJIICG GLDGPBGLHEF(PILFJONLANN EGHDPMDNEOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7D19020", Offset = "0x7D17620", VA = "0x187D19020")]
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
	[Cpp2IlInjected.Address(RVA = "0x7D1C400", Offset = "0x7D1AA00", VA = "0x187D1C400")]
	public NAJOPJHNBAP(Type BLIGGHAFLJO, string OOPCHLJEAEO, PILFJONLANN EGHDPMDNEOH, DGDLIDNPBMH BGILCOILLMG, KJOJBIAOPPM JODFCFDJHDE, DHNNOFGLOBE EMKPFEDONNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7D1C300", Offset = "0x7D1A900", VA = "0x187D1C300")]
	public object JEAAHAHKFMN(object? OKCHLIEAIJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3576FD0", Offset = "0x35755D0", VA = "0x183576FD0")]
	public void PFLNGFGKPOE<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7D1C350", Offset = "0x7D1A950", VA = "0x187D1C350")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public AKOJGKMANJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x48BE5C0", Offset = "0x48BCBC0", VA = "0x1848BE5C0")]
		internal string MMFIKBIHOOK(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x48BE470", Offset = "0x48BCA70", VA = "0x1848BE470")]
		internal object BIBMCJOGPJP(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x46852E0", Offset = "0x46838E0", VA = "0x1846852E0")]
	public HJHPJMOEEHH(PILFJONLANN EGHDPMDNEOH, string OOPCHLJEAEO, [Optional] PCGNDHKBHLJ? BGILCOILLMG, [Optional] GGHPOLCKPJJ? JODFCFDJHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4684470", Offset = "0x4682A70", VA = "0x184684470")]
	private static object? GFOCOOKFNLL(GGHPOLCKPJJ? JODFCFDJHDE, string? CHMMDPKNGNM, object? IDJBNLNBJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4684A60", Offset = "0x4683060", VA = "0x184684A60")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D1BFC0", Offset = "0x7D1A5C0", VA = "0x187D1BFC0", Slot = "4")]
		public bool Equals(List<string> IKAEODCKAIP, List<string> ACCJFOPIMAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7D1C110", Offset = "0x7D1A710", VA = "0x187D1C110", Slot = "5")]
		public int GetHashCode(List<string> GMFKPONAANG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public MNGLFPCOCDH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class LMAFHCOCODO : OCNHMOLGBNC<KDFIHOLAFHD>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7D1AD00", Offset = "0x7D19300", VA = "0x187D1AD00", Slot = "9")]
		public override string IMJDHHAECMF(KDFIHOLAFHD IOJLNNHDMIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7D1ADF0", Offset = "0x7D193F0", VA = "0x187D1ADF0", Slot = "10")]
		protected override bool OIOCMMLCKLE(string IOJLNNHDMIE, [Out] KDFIHOLAFHD KBGCCIOIGBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7D1AFD0", Offset = "0x7D195D0", VA = "0x187D1AFD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410")]
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
		[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7D18C70", Offset = "0x7D17270", VA = "0x187D18C70")]
	public DHBFHKKLBFJ([Optional] IList<NAJOPJHNBAP>? JGEOMBNDBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7D17730", Offset = "0x7D15D30", VA = "0x187D17730")]
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
		[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7D1BEB0", Offset = "0x7D1A4B0", VA = "0x187D1BEB0")]
	public LMJPGMOHELA(POFADHGEPFN DKEIFNPOCHC, IReadOnlyList<POFADHGEPFN> DBJPGFFPPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7D1B010", Offset = "0x7D19610", VA = "0x187D1B010")]
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
	[Cpp2IlInjected.Address(RVA = "0x7D17420", Offset = "0x7D15A20", VA = "0x187D17420")]
	public static bool JPFFIHKCHKD(this OPHKANJGPPK EFGAKBIDOLG, KNBIGIEKHKK EMCDAKNJOKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7D17500", Offset = "0x7D15B00", VA = "0x187D17500")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D24530", Offset = "0x7D22B30", VA = "0x187D24530", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool DGHDDEJODIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7D245D0", Offset = "0x7D22BD0", VA = "0x187D245D0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool LBKNKDFFCEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7D235C0", Offset = "0x7D21BC0", VA = "0x187D235C0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool FHCLEELKHNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7D23610", Offset = "0x7D21C10", VA = "0x187D23610", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool LJOHGIHJPJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7D248D0", Offset = "0x7D22ED0", VA = "0x187D248D0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool CKCMLLCMONG
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7D23660", Offset = "0x7D21C60", VA = "0x187D23660", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public KNBIGIEKHKK MCOGPOJLJCK
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xBB40B0", Offset = "0xBB26B0", VA = "0x180BB40B0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(KNBIGIEKHKK);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x950420", Offset = "0x94EA20", VA = "0x180950420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string EJHNIBIDOJA
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7D24B10", Offset = "0x7D23110", VA = "0x187D24B10", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7D25030", Offset = "0x7D23630", VA = "0x187D25030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string FFEBDELOBJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7D24B10", Offset = "0x7D23110", VA = "0x187D24B10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool KOMNNFOJFFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xC1B7C0", Offset = "0xC19DC0", VA = "0x180C1B7C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xC1B7E0", Offset = "0xC19DE0", VA = "0x180C1B7E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool CPNCAMBEOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7D24C40", Offset = "0x7D23240", VA = "0x187D24C40", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public KDFIHOLAFHD DJCDINOMHHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7D25080", Offset = "0x7D23680", VA = "0x187D25080", Slot = "20")]
		get
		{
			return default(KDFIHOLAFHD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool OLLHEPPCHDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7D24920", Offset = "0x7D22F20", VA = "0x187D24920", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool PDPJJINOGJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7D24620", Offset = "0x7D22C20", VA = "0x187D24620", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool AHJKLJPGAGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7D24580", Offset = "0x7D22B80", VA = "0x187D24580", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool ECAIEMEBNPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7D25120", Offset = "0x7D23720", VA = "0x187D25120", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool HNNDMJFCIMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7D23760", Offset = "0x7D21D60", VA = "0x187D23760", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool OPEFBCBFHFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7D24FE0", Offset = "0x7D235E0", VA = "0x187D24FE0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool ALLBINKPGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7D24A10", Offset = "0x7D23010", VA = "0x187D24A10", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool JLIGPDIIGPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7D23370", Offset = "0x7D21970", VA = "0x187D23370", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> MCHNMDKDNDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7D24F80", Offset = "0x7D23580", VA = "0x187D24F80", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool DAFNFKGFCFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7D24530", Offset = "0x7D22B30", VA = "0x187D24530", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool BMJODMOMGFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7D248D0", Offset = "0x7D22ED0", VA = "0x187D248D0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool MNJDIAEGMFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7D245D0", Offset = "0x7D22BD0", VA = "0x187D245D0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool LOPEKEBNMII
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7D246F0", Offset = "0x7D22CF0", VA = "0x187D246F0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool GEOGKMMNLEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7D249C0", Offset = "0x7D22FC0", VA = "0x187D249C0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool PEEGCIJNEED
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7D235C0", Offset = "0x7D21BC0", VA = "0x187D235C0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool MHGAMJGOGOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7D24970", Offset = "0x7D22F70", VA = "0x187D24970", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool CHMMJKEOCAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7D23610", Offset = "0x7D21C10", VA = "0x187D23610", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool CCBAGLAEGAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7D23660", Offset = "0x7D21C60", VA = "0x187D23660", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event HALOJIBAJGO<PILFJONLANN> FHIDGOKJGEE
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7D24A60", Offset = "0x7D23060", VA = "0x187D24A60", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7D236B0", Offset = "0x7D21CB0", VA = "0x187D236B0", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3613AF0", Offset = "0x36120F0", VA = "0x183613AF0", Slot = "6")]
	public (bool, T?) OAEHEEOBADH<T>(PILFJONLANN EGHDPMDNEOH) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3613CE0", Offset = "0x36122E0", VA = "0x183613CE0")]
	public POFADHGEPFN PGGODCNMLCP<T>(PILFJONLANN EGHDPMDNEOH, bool NHKABEKLDED, T KBGCCIOIGBD) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7D25220", Offset = "0x7D23820", VA = "0x187D25220")]
	public POFADHGEPFN(KNBIGIEKHKK EMCDAKNJOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7D25200", Offset = "0x7D23800", VA = "0x187D25200")]
	public POFADHGEPFN(KNBIGIEKHKK EMCDAKNJOKJ, [Optional] string? JMEBCMNPEII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7D253A0", Offset = "0x7D239A0", VA = "0x187D253A0")]
	public POFADHGEPFN(POFADHGEPFN MNKIKCMPCLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7D25240", Offset = "0x7D23840", VA = "0x187D25240")]
	internal POFADHGEPFN(KNBIGIEKHKK GCDENDPEIIA, [Optional] string? JMEBCMNPEII, [Optional] POFADHGEPFN? MNKIKCMPCLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7D24670", Offset = "0x7D22C70", VA = "0x187D24670")]
	public static KJANNBGPAGB EOMDFHIEOJK(PILFJONLANN EGHDPMDNEOH)
	{
		return default(KJANNBGPAGB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7D24510", Offset = "0x7D22B10", VA = "0x187D24510")]
	public void CHOEMPIPBHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7D24C90", Offset = "0x7D23290", VA = "0x187D24C90")]
	internal POFADHGEPFN KJHFOMGAEOH(POFADHGEPFN LEBHFJIGNCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7D237B0", Offset = "0x7D21DB0", VA = "0x187D237B0")]
	internal IReadOnlyCollection<PILFJONLANN> CFNGCKEKLEF(POFADHGEPFN MNKIKCMPCLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7D24B60", Offset = "0x7D23160", VA = "0x187D24B60")]
	public bool JLDJIICGPNP(PILFJONLANN EGHDPMDNEOH, bool NHKABEKLDED, string GOFICEGCKGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7D24740", Offset = "0x7D22D40", VA = "0x187D24740")]
	public (bool, string) FHGLMEANLKF(PILFJONLANN EGHDPMDNEOH)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7D250D0", Offset = "0x7D236D0", VA = "0x187D250D0")]
	internal void PECEADAGFLD(PILFJONLANN EGHDPMDNEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7D233C0", Offset = "0x7D219C0", VA = "0x187D233C0")]
	public KJDHCMLEMGL AJHIJKHBOOK(Func<KNBIGIEKHKK, Guid> BMMPMBGOIPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7D23B90", Offset = "0x7D22190", VA = "0x187D23B90")]
	public void CHMOFHCCLNE(KJDHCMLEMGL EOHHDOALPPO, Func<Guid, KNBIGIEKHKK> NAOCCCLOEOB, [Optional] KNBIGIEKHKK? GOJMDLIHHAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7D24840", Offset = "0x7D22E40", VA = "0x187D24840")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public IOFHJAGKKOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7D19880", Offset = "0x7D17E80", VA = "0x187D19880")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public FIJDOPBAILP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x19BA1A0", Offset = "0x19B87A0", VA = "0x1819BA1A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D1A630", Offset = "0x7D18C30", VA = "0x187D1A630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7D1ACA0", Offset = "0x7D192A0", VA = "0x187D1ACA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public JDIJBBMPHKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7D198B0", Offset = "0x7D17EB0", VA = "0x187D198B0")]
		internal void CJLOCMBNABI(KJDHCMLEMGL r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7D19990", Offset = "0x7D17F90", VA = "0x187D19990")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public NFNJDBGJCDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7D228A0", Offset = "0x7D20EA0", VA = "0x187D228A0")]
		internal void MJKHDLHLMAB(KJDHCMLEMGL r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7D22840", Offset = "0x7D20E40", VA = "0x187D22840")]
		internal void FDGGDGDEPGO(KJDHCMLEMGL r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7D22870", Offset = "0x7D20E70", VA = "0x187D22870")]
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
			[Cpp2IlInjected.Address(RVA = "0x3D2DD30", Offset = "0x3D2C330", VA = "0x183D2DD30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xA50FB0", Offset = "0xA4F5B0", VA = "0x180A50FB0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public JGNOEMBDOFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x49CC420", Offset = "0x49CAA20", VA = "0x1849CC420")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D19AB0", Offset = "0x7D180B0", VA = "0x187D19AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7D1A5D0", Offset = "0x7D18BD0", VA = "0x187D1A5D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<CGCJEGFAMCN> IDKPPKBPMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7D1CD70", Offset = "0x7D1B370", VA = "0x187D1CD70", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event ICJNJGGIAJB GJOJHNEFBAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7D1CA80", Offset = "0x7D1B080", VA = "0x187D1CA80", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7D1D140", Offset = "0x7D1B740", VA = "0x187D1D140", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7D1C820", Offset = "0x7D1AE20", VA = "0x187D1C820")]
	[HLOHOCOKELO.JGEFFJBDHJI]
	internal static void AOKDCDMDNDH(GFKEMDIOCPC BFAKMKOHPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7D21D30", Offset = "0x7D20330", VA = "0x187D21D30")]
	[UnityEngine.Scripting.Preserve]
	internal NCKLKHAODFJ([IBJCGEMJMJL(null)] JPHFAAMMCNP OCNNOAEPOKM, [IBJCGEMJMJL(null)] LMJPGMOHELA IHIIMNPNKFB, [IBJCGEMJMJL(null)] CCAOPILOOAO AJLMACGMCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7D1DFE0", Offset = "0x7D1C5E0", VA = "0x187D1DFE0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7D1D760", Offset = "0x7D1BD60", VA = "0x187D1D760")]
	private void DIELDMACJPD(IEnumerable<POFADHGEPFN> LNMAEHGLAPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F760", Offset = "0x7D1DD60", VA = "0x187D1F760", Slot = "12")]
	public bool ILPILJKNHOL(OPHKANJGPPK OEIBHCOIKMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7D1D1E0", Offset = "0x7D1B7E0", VA = "0x187D1D1E0")]
	private void CGJLHGCPJDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7D1C630", Offset = "0x7D1AC30", VA = "0x187D1C630")]
	private void ALGAHNFAPHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F300", Offset = "0x7D1D900", VA = "0x187D1F300", Slot = "10")]
	public IReadOnlyList<CGCJEGFAMCN> GCLGICFJIEI(bool HBOGEDBNOIC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7D20CC0", Offset = "0x7D1F2C0", VA = "0x187D20CC0", Slot = "11")]
	public CGCJEGFAMCN NNEPGHLDHIP(OPHKANJGPPK OEIBHCOIKMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F380", Offset = "0x7D1D980", VA = "0x187D1F380")]
	private KNBIGIEKHKK HONBKCGCAGI(OPHKANJGPPK OEIBHCOIKMG)
	{
		return default(KNBIGIEKHKK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7D1C4A0", Offset = "0x7D1AAA0", VA = "0x187D1C4A0", Slot = "14")]
	public bool AGLPAPHGECK(OPHKANJGPPK HJEEPHIOLFP, KNBIGIEKHKK EMCDAKNJOKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7D1C9E0", Offset = "0x7D1AFE0", VA = "0x187D1C9E0", Slot = "15")]
	public CGCJEGFAMCN BBJKAGKLLAD(KNBIGIEKHKK EMCDAKNJOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7D1FDB0", Offset = "0x7D1E3B0", VA = "0x187D1FDB0")]
	private static bool MHIKEGMFNOA(GIMGIJILDCH PPECHIGOHBL, KNBIGIEKHKK EMCDAKNJOKJ, [Out] KJDHCMLEMGL? KMGGGKGAKMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7D20BD0", Offset = "0x7D1F1D0", VA = "0x187D20BD0")]
	private static void NGMPCBFDION(GIMGIJILDCH PPECHIGOHBL, Action<KJDHCMLEMGL> LIMKNMFMDKK, KNBIGIEKHKK JJAKAMPJDEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7D20940", Offset = "0x7D1EF40", VA = "0x187D20940")]
	private static void NGMPCBFDION(GIMGIJILDCH PPECHIGOHBL, Action<KJDHCMLEMGL> LIMKNMFMDKK, Predicate<KNBIGIEKHKK> OIKNEKMDEBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F290", Offset = "0x7D1D890", VA = "0x187D1F290")]
	private void ELALGDHBPMF(OPHKANJGPPK OEIBHCOIKMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7D20820", Offset = "0x7D1EE20", VA = "0x187D20820", Slot = "4")]
	[AsyncStateMachine(typeof(KLJMEJAEEOI))]
	public Task NFLCAHJOCEP([CanBeNull] BDHMMMHCHAA MIMFFPFKBEA, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
	public void HOIJAOHBLEP(BDHMMMHCHAA MIMFFPFKBEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7D1FA70", Offset = "0x7D1E070", VA = "0x187D1FA70")]
	private void KLNNDLENPMA(GIMGIJILDCH DCELFPLPBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F450", Offset = "0x7D1DA50", VA = "0x187D1F450")]
	internal static string IBADLBGIIFK(JPHFAAMMCNP FPJDPMBFFOO, BDHMMMHCHAA MIMFFPFKBEA, IReadOnlyDictionary<KNBIGIEKHKK, POFADHGEPFN> HKDCBHKLEKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7D1E3E0", Offset = "0x7D1C9E0", VA = "0x187D1E3E0")]
	private static void EKIKGCLNGOJ(BDHMMMHCHAA MIMFFPFKBEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7D20DD0", Offset = "0x7D1F3D0", VA = "0x187D20DD0")]
	private static void NPMFBGGGOGA(GIMGIJILDCH HAHNJAMKKLJ, IReadOnlyDictionary<KNBIGIEKHKK, POFADHGEPFN> HKDCBHKLEKH, StringBuilder FMELKOLPLEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7D1CB20", Offset = "0x7D1B120", VA = "0x187D1CB20")]
	private static bool BLOEJCIGLJE(string BPJIGPJFNGO, [Out] Guid LLDJIFPIHGK, [Out] KNBIGIEKHKK EMCDAKNJOKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7D200E0", Offset = "0x7D1E6E0", VA = "0x187D200E0")]
	private static void NCEAGKHHKBD(BDHMMMHCHAA MIMFFPFKBEA, StringBuilder FMELKOLPLEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x35AA4C0", Offset = "0x35A8AC0", VA = "0x1835AA4C0", Slot = "16")]
	public bool BIOJLMGJHOJ<T>(KNBIGIEKHKK EMCDAKNJOKJ, PILFJONLANN EGHDPMDNEOH, bool NHKABEKLDED, T ICONKPKJBGN, [Optional] Action NFOHAIJEDFE) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F210", Offset = "0x7D1D810", VA = "0x187D1F210", Slot = "17")]
	public string EKNEOGCBOLH(PILFJONLANN EGHDPMDNEOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F840", Offset = "0x7D1DE40", VA = "0x187D1F840")]
	private void JAOFDFNCPIA(KNBIGIEKHKK EMCDAKNJOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7D1FA50", Offset = "0x7D1E050", VA = "0x187D1FA50")]
	private bool JEOJMPHHMFF(OPHKANJGPPK OEIBHCOIKMG, KNBIGIEKHKK EMCDAKNJOKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7D1D1F0", Offset = "0x7D1B7F0", VA = "0x187D1D1F0")]
	internal POFADHGEPFN CJGJEMLCEOM(OPHKANJGPPK OEIBHCOIKMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F830", Offset = "0x7D1DE30", VA = "0x187D1F830", Slot = "13")]
	public IReadOnlyList<CGCJEGFAMCN> JAFFEDJFOBB(OPHKANJGPPK OEIBHCOIKMG, bool NNBADCCFFJP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7D1D530", Offset = "0x7D1BB30", VA = "0x187D1D530")]
	internal IReadOnlyList<POFADHGEPFN> COFCNAIAKGC(OPHKANJGPPK OEIBHCOIKMG, bool NNBADCCFFJP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7D21120", Offset = "0x7D1F720", VA = "0x187D21120")]
	private void PDELPAIHPBM(FIDINBBNJBE EBKKGHAFPPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7D1E0F0", Offset = "0x7D1C6F0", VA = "0x187D1E0F0")]
	private static bool EJCAKBOLPNE(POFADHGEPFN BDIAAHCKKFG, IReadOnlyDictionary<KNBIGIEKHKK, POFADHGEPFN> HKDCBHKLEKH, [Out] IReadOnlyList<PILFJONLANN> PBPJALFMEKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7D1CC30", Offset = "0x7D1B230", VA = "0x187D1CC30")]
	[AsyncStateMachine(typeof(JHDGCLNDJDP))]
	private static Task BPMJKJMCFJJ(JPHFAAMMCNP FPJDPMBFFOO, BDHMMMHCHAA MIMFFPFKBEA, IReadOnlyDictionary<KNBIGIEKHKK, POFADHGEPFN> HKDCBHKLEKH, CCAOPILOOAO AJLMACGMCAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7D218C0", Offset = "0x7D1FEC0", VA = "0x187D218C0")]
	[CompilerGenerated]
	internal static void PKNNEEEMGIA(Func<KJDHCMLEMGL, PEIDMNINPMC> GNFEKHEBKLG, PIENMDLDNIE P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7D1CDC0", Offset = "0x7D1B3C0", VA = "0x187D1CDC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x95ED80", Offset = "0x95D380", VA = "0x18095ED80")]
	[RecRoom.NoEngine.Common.Preserve]
	public NEFODFHEKIF([IBJCGEMJMJL(null)] GIGGPJHAEII HCCLLPNKFMA, [IBJCGEMJMJL(null)] NAECFABJCIE PGPFMABFGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7D22600", Offset = "0x7D20C00", VA = "0x187D22600")]
	private static KAKJLAMFNPB? FGCELJNODAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7D22740", Offset = "0x7D20D40", VA = "0x187D22740", Slot = "4")]
	public bool MALDFHCEHNA(OPHKANJGPPK LAFJEOJMADD, OPHKANJGPPK BEEGBMHIDKI, IEnumerable<OPHKANJGPPK> CFLPFODFLAF, [Out] KDFIHOLAFHD AFPONLEEICE, [Out] KNODAPBHNNC GMCMOLADKHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7D22640", Offset = "0x7D20C40", VA = "0x187D22640", Slot = "5")]
	public string LAOCILFACBC(KNODAPBHNNC DNLFECOCBNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7D21FF0", Offset = "0x7D205F0", VA = "0x187D21FF0")]
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
