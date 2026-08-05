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
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.NoEngine.Common;
using RecRoom.ObjectModel;
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
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E233C0", Offset = "0x8E219C0", VA = "0x188E233C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD1900", Offset = "0xACFF00", VA = "0x180AD1900")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD1940", Offset = "0xACFF40", VA = "0x180AD1940")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum KCLEJFPLCEB
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
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8E25940", Offset = "0x8E23F40", VA = "0x188E25940", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x29CB0D0", Offset = "0x29C96D0", VA = "0x1829CB0D0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void HNGHOFLBIJB<TPermission>(TPermission LGNOKIBMMII);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void NDLMLOMMNOO(MEINMPIOLGA AGIMJJDFEAF);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum FIMHFKIJAPO
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface LAGGFBBFGJC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool KLBDAJFEICE
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool OJKHCIDFPAG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool HOGNDCNBFGN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool FBFGNMNJBOH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool DICHFFJGPMP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool DIMAOMKCIBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool ICIAGAJKNFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class LPGCHHOGKDB
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum NIFLPFHDJGP
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
	public static readonly Guid AEKOLGFEACH;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid MHCHLKIFMBB;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid FDJICADAKHP;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid FDEPABBDOPO;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid OHGACIBKGLJ;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid ODMGBPCKGMC;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly HGLBBGGAOFG<NNBHCLAOLKE, Guid> NLIEMIAPMLM;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	internal static IEnumerable<NNBHCLAOLKE> PNPIFENDOMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8E20CC0", Offset = "0x8E1F2C0", VA = "0x188E20CC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8E209D0", Offset = "0x8E1EFD0", VA = "0x188E209D0")]
	public static NNBHCLAOLKE FGPPFMDBOKJ(Guid JJCLDINKIFD)
	{
		return default(NNBHCLAOLKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8E20A60", Offset = "0x8E1F060", VA = "0x188E20A60")]
	public static Guid GDFCOECJCDD(NNBHCLAOLKE JFDKPNDDGFG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8E20C30", Offset = "0x8E1F230", VA = "0x188E20C30")]
	public static bool LEPEAACAEND(NNBHCLAOLKE JFDKPNDDGFG, [Out] Guid JJCLDINKIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8E20930", Offset = "0x8E1EF30", VA = "0x188E20930")]
	public static bool CCGOIADIJLN(Guid JJCLDINKIFD, [Out] NNBHCLAOLKE JFDKPNDDGFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8E20B40", Offset = "0x8E1F140", VA = "0x188E20B40")]
	public static NNBHCLAOLKE KCNKLBEKKGE(NNBHCLAOLKE JFDKPNDDGFG)
	{
		return default(NNBHCLAOLKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8E20B80", Offset = "0x8E1F180", VA = "0x188E20B80")]
	public static NIFLPFHDJGP KMCBAONEDCB(NNBHCLAOLKE BMHONKGDLAJ)
	{
		return default(NIFLPFHDJGP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8E20B00", Offset = "0x8E1F100", VA = "0x188E20B00")]
	internal static NNBHCLAOLKE JEHIIGKEGCH(NIFLPFHDJGP MICIIPEMNPM)
	{
		return default(NNBHCLAOLKE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JBNECHIFOAL
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	MEINMPIOLGA KPFDOFKDHBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	JOPLKHGILIH LJMHPFGDJJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	PCHMDNLFCBM CEEDAOOCKPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<LKKEDIOHPOI> NPNBGBCDJHH;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action APKDNJGNEKG;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NNBHCLAOLKE KLJPFJLKKIM(MEINMPIOLGA AGIMJJDFEAF);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<LKKEDIOHPOI> DBEPEKLEJJK(CancellationToken PJCIHHKJKBP);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task GELNJFMDMKJ(long DDLHEHAKJGF, IReadOnlyList<GGNEEIDALJG> PIEGCFNAOOM);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task FJPDEBCEFNL(long DDLHEHAKJGF, long HAHGPICIJJJ, IReadOnlyList<GGNEEIDALJG> PIEGCFNAOOM);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<MEINMPIOLGA> JCLJOHPFECF();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class BCALBDNDKKN
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8E1D000", Offset = "0x8E1B600", VA = "0x188E1D000")]
	public static NNBHCLAOLKE NLLMJBLHPHC(this JBNECHIFOAL JJEAGGFMAIL)
	{
		return default(NNBHCLAOLKE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface OBOFLGAFHOK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	MEBDHAAPDMP MBNKGNJEKFI
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event NDLMLOMMNOO MDODNFGFEGE;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<BKNGMHAJKAE> OHCOGKLLFPP(bool MCJPMIHMPCD = false);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BKNGMHAJKAE FOEDAGHAKHE(MEINMPIOLGA AGIMJJDFEAF);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PDHKKBFPEOD(MEINMPIOLGA AGIMJJDFEAF);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IReadOnlyList<BKNGMHAJKAE> EOJINGPDLGM(MEINMPIOLGA AGIMJJDFEAF, bool GJEPMHCLMMK = false);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool POFGODDKOEH(MEINMPIOLGA EIGIOEBGGBD, NNBHCLAOLKE JFDKPNDDGFG);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "8")]
	BKNGMHAJKAE DGJOLEAKFBA(NNBHCLAOLKE JFDKPNDDGFG);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool AOPIIJHPEBB<T>(NNBHCLAOLKE JFDKPNDDGFG, BGMLECFHONH LGNOKIBMMII, bool POOIFFHGDKN, T CGNPMBIJPEO, [Optional] Action LGJPMNJADHB) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string OOPMJBPDGEH(BGMLECFHONH LGNOKIBMMII);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool BNFBGKJOCEL(MEINMPIOLGA AGIMJJDFEAF, BGMLECFHONH DBCCEKNNHCG);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface CAOICFMCIDL
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task DMBEJGIACKN(NIDHIPJBPAM PGEPJKBFLOM, CancellationToken PJCIHHKJKBP);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface KDKGEKPCOEA<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string NFFOAAKIGAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event HNGHOFLBIJB<TPermission> CCPHDAHBFFM;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal abstract class KHOGOEDGLGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal object? HBJFIAIFNOL;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? ANCKHJFLNDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8E1FE00", Offset = "0x8E1E400", VA = "0x188E1FE00")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8E1FED0", Offset = "0x8E1E4D0", VA = "0x188E1FED0")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8E1FFD0", Offset = "0x8E1E5D0", VA = "0x188E1FFD0")]
	protected KHOGOEDGLGP(object? NMIHGCNOAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool ODEJKIDCLNB(object? KOPHBHGIACG);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class NFCHDHKHGJG<T> : KHOGOEDGLGP where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> HPIFCOACPPF;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T CECIKJNPCJO
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5A7DE60", Offset = "0x5A7C460", VA = "0x185A7DE60")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5A7E130", Offset = "0x5A7C730", VA = "0x185A7E130", Slot = "4")]
	public override bool ODEJKIDCLNB(object? KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5A7E880", Offset = "0x5A7CE80", VA = "0x185A7E880")]
	public bool OJDBBILBFMF(T BDMBIOMIOHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5A7EB70", Offset = "0x5A7D170", VA = "0x185A7EB70")]
	public NFCHDHKHGJG(T APJDJFMLEAP, IEqualityComparer<T> HPIFCOACPPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class KNJPGPBLEAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<BGMLECFHONH, bool> KOEBPIOEMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<BGMLECFHONH, KHOGOEDGLGP> HKFIKJHMADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly NDLCGGPNIPA DLBMKIPJBPM;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8E20680", Offset = "0x8E1EC80", VA = "0x188E20680")]
	public KNJPGPBLEAD(NDLCGGPNIPA DLBMKIPJBPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8E200D0", Offset = "0x8E1E6D0", VA = "0x188E200D0")]
	public bool GJHFGIMEMNB(BGMLECFHONH LGNOKIBMMII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3EB0A80", Offset = "0x3EAF080", VA = "0x183EB0A80")]
	public bool LMKLFFLFLNN<T>(BGMLECFHONH LGNOKIBMMII, bool POOIFFHGDKN, T KOPHBHGIACG) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3EB06B0", Offset = "0x3EAECB0", VA = "0x183EB06B0")]
	public (bool, T?) KDLGMPOBACE<T>(BGMLECFHONH LGNOKIBMMII) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8E202D0", Offset = "0x8E1E8D0", VA = "0x188E202D0")]
	public bool LMKLFFLFLNN(BGMLECFHONH LGNOKIBMMII, bool POOIFFHGDKN, object KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8E20140", Offset = "0x8E1E740", VA = "0x188E20140")]
	public (bool, object) KDLGMPOBACE(BGMLECFHONH LGNOKIBMMII)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3EB0670", Offset = "0x3EAEC70", VA = "0x183EB0670")]
	private void EICGPLCFKLK<T>(BGMLECFHONH LGNOKIBMMII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8E203B0", Offset = "0x8E1E9B0", VA = "0x188E203B0")]
	private KHOGOEDGLGP OPCBINKFHAL(BGMLECFHONH LGNOKIBMMII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8E20480", Offset = "0x8E1EA80", VA = "0x188E20480")]
	public void PBLFEMCGALB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class MBGIMJDCFFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string AIHDEPPKDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type CDLIAKDJINF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly CDHKJDGKIKO EGIELFFDDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly BGMLECFHONH LOFHMEPOKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public OOGBLKHKPBP DMNKIKLDFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public KFPJEFHIGIB CANHKGMOPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public KJOGFDJFCLD MOLPHJEHBFO;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8E21160", Offset = "0x8E1F760", VA = "0x188E21160")]
	public MBGIMJDCFFF(Type GECMEADNEJE, string MEGOHHCJIKL, BGMLECFHONH LGNOKIBMMII, OOGBLKHKPBP GCNCDCFPHJF, KFPJEFHIGIB MJAGABLFGFG, KJOGFDJFCLD PHIENPBCLLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8E21110", Offset = "0x8E1F710", VA = "0x188E21110")]
	public object PFDMMNDOODN(object? AAGCKLPFJME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3ECA580", Offset = "0x3EC8B80", VA = "0x183ECA580")]
	public void EICGPLCFKLK<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8E21060", Offset = "0x8E1F660", VA = "0x188E21060")]
	public void EICGPLCFKLK(Type MPEPKHANNAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class BKOPHAPCFCB<T> : MBGIMJDCFFF where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate string DOMMFEODDMC(T KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal delegate T KKCAHOJBNEP(string? LAMFBPPDOII, T APJDJFMLEAP);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class FLFOICAOOCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public DOMMFEODDMC serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public KKCAHOJBNEP parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public FLFOICAOOCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5022320", Offset = "0x5020920", VA = "0x185022320")]
		internal string KJLMOGFJHPI(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5022280", Offset = "0x5020880", VA = "0x185022280")]
		internal object ICKGOIOHGOE(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6AFAE70", Offset = "0x6AF9470", VA = "0x186AFAE70")]
	public BKOPHAPCFCB(BGMLECFHONH LGNOKIBMMII, string MEGOHHCJIKL, [Optional] DOMMFEODDMC? GCNCDCFPHJF, [Optional] KKCAHOJBNEP? MJAGABLFGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6AFA540", Offset = "0x6AF8B40", VA = "0x186AFA540")]
	private static object? LPNJIHLFELG(KKCAHOJBNEP? MJAGABLFGFG, string? LAMFBPPDOII, object? APJDJFMLEAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6AF9FA0", Offset = "0x6AF85A0", VA = "0x186AF9FA0")]
	private static string ANHNANMIGBP(DOMMFEODDMC? LIGBCGKIDII, object? KOPHBHGIACG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate string OOGBLKHKPBP(object? KOPHBHGIACG);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate object KFPJEFHIGIB(string? LAMFBPPDOII, [Optional] object APJDJFMLEAP);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal delegate KHOGOEDGLGP KJOGFDJFCLD();
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class NDLCGGPNIPA
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class JGPDLKHNFLM : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static JGPDLKHNFLM EHBCEBDHHPE;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8E1FAC0", Offset = "0x8E1E0C0", VA = "0x188E1FAC0", Slot = "4")]
		public bool Equals(List<string> GBNAKFLHCOE, List<string> ODEKEFJCIIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8E1FC10", Offset = "0x8E1E210", VA = "0x188E1FC10", Slot = "5")]
		public int GetHashCode(List<string> MPIDDJPOOMJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public JGPDLKHNFLM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class GIAEPCNJPKM : HAHHNFCMALN<KCLEJFPLCEB>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8E1F4A0", Offset = "0x8E1DAA0", VA = "0x188E1F4A0", Slot = "9")]
		public override string ANHNANMIGBP(KCLEJFPLCEB ECBHOIMIBKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8E1F590", Offset = "0x8E1DB90", VA = "0x188E1F590", Slot = "10")]
		protected override bool MEIFKFJCAFB(string ECBHOIMIBKD, [Out] KCLEJFPLCEB KOPHBHGIACG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8E1F770", Offset = "0x8E1DD70", VA = "0x188E1F770")]
		public GIAEPCNJPKM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly LMOGBBPDACB BHMDMKMMDBE;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly GIAEPCNJPKM MFKIPCEEOIL;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<MBGIMJDCFFF> NPOBCACCPMB;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<BGMLECFHONH> BAANHMKEILA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<BGMLECFHONH, MBGIMJDCFFF> POMEACMDGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8E227A0", Offset = "0x8E20DA0", VA = "0x188E227A0")]
	public NDLCGGPNIPA([Optional] IList<MBGIMJDCFFF>? DOHAECMHMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8E21200", Offset = "0x8E1F800", VA = "0x188E21200")]
	public MBGIMJDCFFF CHIEDJPBCLB(BGMLECFHONH LGNOKIBMMII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface MEBDHAAPDMP
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	BKNGMHAJKAE PNEMJPMJEOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class CCMHFAIPLAP : MEBDHAAPDMP
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static CCMHFAIPLAP CDKLJIFHAHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly OBPPDGLDOBN IADOEJGLMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<OBPPDGLDOBN> PAJNHEEOOFM;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public BKNGMHAJKAE PNEMJPMJEOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8E1DFB0", Offset = "0x8E1C5B0", VA = "0x188E1DFB0")]
	public CCMHFAIPLAP(OBPPDGLDOBN OMPFPICKKDD, IReadOnlyList<OBPPDGLDOBN> DOCNMKKCNCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8E1D060", Offset = "0x8E1B660", VA = "0x188E1D060")]
	private static CCMHFAIPLAP DFGKCIBHEDG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class ICIGBGOLHJI
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<NNBHCLAOLKE> PKBAJKGHIPM;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8E1F7B0", Offset = "0x8E1DDB0", VA = "0x188E1F7B0")]
	public static bool IADIJLFBECK(this MEINMPIOLGA GMPDLOKBGJB, NNBHCLAOLKE JFDKPNDDGFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8E1F890", Offset = "0x8E1DE90", VA = "0x188E1F890")]
	public static bool PHEJHLEOHMI(this MEINMPIOLGA GMPDLOKBGJB, NNBHCLAOLKE JFDKPNDDGFG, PCHMDNLFCBM MANOLEPPJML)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface EDKENEPJAGF
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	IReadOnlyList<string> KCMGKMMJABC
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	KCLEJFPLCEB ABHOGAKCCEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface BKNGMHAJKAE : EDKENEPJAGF, LAGGFBBFGJC, KDKGEKPCOEA<BGMLECFHONH>
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	string BKFAEPAKLKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	NNBHCLAOLKE MAONCBDOFDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) LFGGMGBHEEG<T>(BGMLECFHONH LGNOKIBMMII) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal class OBPPDGLDOBN : BKNGMHAJKAE, EDKENEPJAGF, LAGGFBBFGJC, KDKGEKPCOEA<BGMLECFHONH>
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal static readonly NDLCGGPNIPA EMOIJNAABGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal readonly KNJPGPBLEAD FGMILFOHMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private string? LFIHDMNMNIL;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private bool IFGJPKMACIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8E24AE0", Offset = "0x8E230E0", VA = "0x188E24AE0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool FAMNIFDCJAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8E24130", Offset = "0x8E22730", VA = "0x188E24130", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool KHKKFKAGLOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8E24480", Offset = "0x8E22A80", VA = "0x188E24480", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool NKMNHBDLEHH
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8E242B0", Offset = "0x8E228B0", VA = "0x188E242B0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool KBKCJPELBMM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8E24210", Offset = "0x8E22810", VA = "0x188E24210", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool HPKIOCAIGPF
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8E23780", Offset = "0x8E21D80", VA = "0x188E23780", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private bool OBCBEAKPJIB
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8E23730", Offset = "0x8E21D30", VA = "0x188E23730", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public NNBHCLAOLKE MAONCBDOFDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xB268D0", Offset = "0xB24ED0", VA = "0x180B268D0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(NNBHCLAOLKE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xAB4E30", Offset = "0xAB3430", VA = "0x180AB4E30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public string NFFOAAKIGAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8E24BE0", Offset = "0x8E231E0", VA = "0x188E24BE0", Slot = "18")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xAA9ED0", Offset = "0xAA84D0", VA = "0x180AA9ED0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public string BKFAEPAKLKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8E24BE0", Offset = "0x8E231E0", VA = "0x188E24BE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool PEIPFPOONPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xAD4490", Offset = "0xAD2A90", VA = "0x180AD4490")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xAD43F0", Offset = "0xAD29F0", VA = "0x180AD43F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public KCLEJFPLCEB ABHOGAKCCEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8E24430", Offset = "0x8E22A30", VA = "0x188E24430", Slot = "8")]
		get
		{
			return default(KCLEJFPLCEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public IReadOnlyList<string> KCMGKMMJABC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8E24980", Offset = "0x8E22F80", VA = "0x188E24980", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool FIGBLHPKKDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8E24AE0", Offset = "0x8E230E0", VA = "0x188E24AE0", Slot = "19")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool CHGAGNKBDOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8E24210", Offset = "0x8E22810", VA = "0x188E24210", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool KOOBCODBGEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8E24130", Offset = "0x8E22730", VA = "0x188E24130", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool BFJKJCMBCNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8E24480", Offset = "0x8E22A80", VA = "0x188E24480", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool LDFAAKJOKFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8E242B0", Offset = "0x8E228B0", VA = "0x188E242B0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool HIEELLDMCHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8E23780", Offset = "0x8E21D80", VA = "0x188E23780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool NPFNNBKKBKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8E23730", Offset = "0x8E21D30", VA = "0x188E23730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event HNGHOFLBIJB<BGMLECFHONH> CCPHDAHBFFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8E24B30", Offset = "0x8E23130", VA = "0x188E24B30", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8E24300", Offset = "0x8E22900", VA = "0x188E24300", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3F774B0", Offset = "0x3F75AB0", VA = "0x183F774B0", Slot = "6")]
	public (bool, T?) LFGGMGBHEEG<T>(BGMLECFHONH LGNOKIBMMII) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3F77640", Offset = "0x3F75C40", VA = "0x183F77640")]
	public OBPPDGLDOBN OAGFBPLMPCO<T>(BGMLECFHONH LGNOKIBMMII, bool POOIFFHGDKN, T KOPHBHGIACG) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8E250B0", Offset = "0x8E236B0", VA = "0x188E250B0")]
	public OBPPDGLDOBN(NNBHCLAOLKE JFDKPNDDGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8E250D0", Offset = "0x8E236D0", VA = "0x188E250D0")]
	public OBPPDGLDOBN(NNBHCLAOLKE JFDKPNDDGFG, [Optional] string? LFIHDMNMNIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8E25020", Offset = "0x8E23620", VA = "0x188E25020")]
	public OBPPDGLDOBN(OBPPDGLDOBN PHIGHFNGPKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8E24EE0", Offset = "0x8E234E0", VA = "0x188E24EE0")]
	internal OBPPDGLDOBN(NNBHCLAOLKE NEABIJDLOJH, [Optional] string? LFIHDMNMNIL, [Optional] OBPPDGLDOBN? PHIGHFNGPKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8E243B0", Offset = "0x8E229B0", VA = "0x188E243B0")]
	public static CDHKJDGKIKO ELHDGNJGAIG(BGMLECFHONH LGNOKIBMMII)
	{
		return default(CDHKJDGKIKO);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8E24C30", Offset = "0x8E23230", VA = "0x188E24C30")]
	public void PBLFEMCGALB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8E23440", Offset = "0x8E21A40", VA = "0x188E23440")]
	internal OBPPDGLDOBN ABNIADDPAID(OBPPDGLDOBN IKAILCBPEJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8E245B0", Offset = "0x8E22BB0", VA = "0x188E245B0")]
	internal IReadOnlyCollection<BGMLECFHONH> JOENHKFEPHF(OBPPDGLDOBN PHIGHFNGPKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8E244D0", Offset = "0x8E22AD0", VA = "0x188E244D0")]
	public bool JBAIJPEEDKJ(BGMLECFHONH LGNOKIBMMII, bool POOIFFHGDKN, string OKJNELHIDBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8E249E0", Offset = "0x8E22FE0", VA = "0x188E249E0")]
	public (bool, string) KLOKCCGIKIJ(BGMLECFHONH LGNOKIBMMII)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8E24260", Offset = "0x8E22860", VA = "0x188E24260")]
	internal void DELMCOJBHED(BGMLECFHONH LGNOKIBMMII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8E24C50", Offset = "0x8E23250", VA = "0x188E24C50")]
	public KDDKDAIEDJF PKPKFKAFIOK(Func<NNBHCLAOLKE, Guid> JFBGGNMKCBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8E237D0", Offset = "0x8E21DD0", VA = "0x188E237D0")]
	public void AMOGIEFMNHJ(KDDKDAIEDJF EBNCMMDEMLE, Func<Guid, NNBHCLAOLKE> IPGBFDENBAP, [Optional] NNBHCLAOLKE? OCAGLELOFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8E24180", Offset = "0x8E22780", VA = "0x188E24180")]
	[CompilerGenerated]
	private void CNJGIHKBKCO(BGMLECFHONH DBCCEKNNHCG, PBDDNLANJNA PCGOKLEPAIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class ADGADEOBLKC : CAOICFMCIDL, OBOFLGAFHOK, IDisposable, PIBDBDJHBIB
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class PDICALHHACB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public OBPPDGLDOBN newRole;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public PDICALHHACB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8E25180", Offset = "0x8E23780", VA = "0x188E25180")]
		internal bool OHNLHHPNDDH(OBPPDGLDOBN rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class PCGPPJGNLDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public NNBHCLAOLKE roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public PCGPPJGNLDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x1F85690", Offset = "0x1F83C90", VA = "0x181F85690")]
		internal bool MLKMOANHBMG(NNBHCLAOLKE r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct NIEDIACNDBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public ADGADEOBLKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NIDHIPJBPAM roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private TaskAwaiter<LKKEDIOHPOI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8E22CF0", Offset = "0x8E212F0", VA = "0x188E22CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8E23360", Offset = "0x8E21960", VA = "0x188E23360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class NGFDNOFMOOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public NGFDNOFMOOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8E22AF0", Offset = "0x8E210F0", VA = "0x188E22AF0")]
		internal void GPDIEMOAMMF(KDDKDAIEDJF r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8E22BD0", Offset = "0x8E211D0", VA = "0x188E22BD0")]
		internal void MEJKBPMKBPJ(KDDKDAIEDJF r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct KOEMLJKIDDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public NIDHIPJBPAM roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class PDEGKILJOKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Func<KDDKDAIEDJF, PBDDNLANJNA> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public PDEGKILJOKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8E25120", Offset = "0x8E23720", VA = "0x188E25120")]
		internal void MAAIBCOGCJN(KDDKDAIEDJF r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8E25150", Offset = "0x8E23750", VA = "0x188E25150")]
		internal void NAGBPGIMDJD(KDDKDAIEDJF r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8E250F0", Offset = "0x8E236F0", VA = "0x188E250F0")]
		internal void LMLPNFDMHCH(KDDKDAIEDJF r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class LGFLAPFFFGA<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private struct <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public LGFLAPFFFGA<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private TaskAwaiter<LKKEDIOHPOI> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x45A7B60", Offset = "0x45A6160", VA = "0x1845A7B60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xB035A0", Offset = "0xB01BA0", VA = "0x180B035A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public BGMLECFHONH rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NNBHCLAOLKE accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public CDHKJDGKIKO recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public ADGADEOBLKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public LGFLAPFFFGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x57C7C40", Offset = "0x57C6240", VA = "0x1857C7C40")]
		[AsyncStateMachine(typeof(LGFLAPFFFGA<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void CNHEHLMCHHF()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct HNIHIIJBMOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public IReadOnlyList<GGNEEIDALJG> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct DMJHJIPJFCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public JBNECHIFOAL rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public NIDHIPJBPAM roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public IReadOnlyDictionary<NNBHCLAOLKE, OBPPDGLDOBN> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public KNOKIILHDFE debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8E1E0C0", Offset = "0x8E1C6C0", VA = "0x188E1E0C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8E1EBE0", Offset = "0x8E1D1E0", VA = "0x188E1EBE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[DependsOn]
	private readonly JBNECHIFOAL JJEAGGFMAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[DependsOn]
	private readonly CCMHFAIPLAP PHOOBGHAEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[DependsOn]
	private readonly KNOKIILHDFE NKJNDBENPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private JLOKOABLKAN? OJLAEGOCDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly Dictionary<int, NNBHCLAOLKE> LAIANGEJGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly Dictionary<NNBHCLAOLKE, OBPPDGLDOBN> FHBHEOJFMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal readonly Dictionary<NNBHCLAOLKE, OBPPDGLDOBN> GMAAHNAHBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal readonly Dictionary<NNBHCLAOLKE, OBPPDGLDOBN> NBAOIOGCBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal readonly List<OBPPDGLDOBN> FGOCBKLMFCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool FKGCCLAJMDG;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private static readonly BGMLECFHONH[] DAJNMHGKJFH;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public MEBDHAAPDMP MBNKGNJEKFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event NDLMLOMMNOO MDODNFGFEGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8E1A800", Offset = "0x8E18E00", VA = "0x188E1A800", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8E1AF50", Offset = "0x8E19550", VA = "0x188E1AF50", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x8E18A40", Offset = "0x8E17040", VA = "0x188E18A40")]
	[EGNICHGEFDG.KJKACNMMOJK]
	internal static void FBMOEFONPBI(NMNJFHODGJA MOPOKCOIIMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x8E1CD10", Offset = "0x8E1B310", VA = "0x188E1CD10")]
	[UnityEngine.Scripting.Preserve]
	internal ADGADEOBLKC([EDHLHMEHMKO(null)] JBNECHIFOAL FFMCMIOHMGN, [EDHLHMEHMKO(null)] CCMHFAIPLAP MBFFEFNKGEO, [EDHLHMEHMKO(null)] KNOKIILHDFE NKJNDBENPHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x8E188B0", Offset = "0x8E16EB0", VA = "0x188E188B0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x8E194E0", Offset = "0x8E17AE0", VA = "0x188E194E0")]
	private void FJEMEOMAJOK(IEnumerable<OBPPDGLDOBN> FFKMDNPDDFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x8E1C9A0", Offset = "0x8E1AFA0", VA = "0x188E1C9A0", Slot = "10")]
	public bool PDHKKBFPEOD(MEINMPIOLGA AGIMJJDFEAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x8E16FD0", Offset = "0x8E155D0", VA = "0x188E16FD0")]
	private void APKDNJGNEKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x8E1A0F0", Offset = "0x8E186F0", VA = "0x188E1A0F0", Slot = "19")]
	public void GDDDGAOFODC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x8E1C330", Offset = "0x8E1A930", VA = "0x188E1C330", Slot = "8")]
	public IReadOnlyList<BKNGMHAJKAE> OHCOGKLLFPP(bool MCJPMIHMPCD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8E19D70", Offset = "0x8E18370", VA = "0x188E19D70", Slot = "9")]
	public BKNGMHAJKAE FOEDAGHAKHE(MEINMPIOLGA AGIMJJDFEAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8E16F00", Offset = "0x8E15500", VA = "0x188E16F00")]
	private NNBHCLAOLKE AKKGKDOMFPG(MEINMPIOLGA AGIMJJDFEAF)
	{
		return default(NNBHCLAOLKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8E1CA70", Offset = "0x8E1B070", VA = "0x188E1CA70", Slot = "12")]
	public bool POFGODDKOEH(MEINMPIOLGA EIGIOEBGGBD, NNBHCLAOLKE JFDKPNDDGFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8E18350", Offset = "0x8E16950", VA = "0x188E18350", Slot = "13")]
	public BKNGMHAJKAE DGJOLEAKFBA(NNBHCLAOLKE JFDKPNDDGFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x8E1A8A0", Offset = "0x8E18EA0", VA = "0x188E1A8A0")]
	private static bool IEFFDEBABBG(HBJAMDIGIPB EHPGPJKDOHH, NNBHCLAOLKE JFDKPNDDGFG, [Out] KDDKDAIEDJF? JCMMOPBDMMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x8E1AFF0", Offset = "0x8E195F0", VA = "0x188E1AFF0")]
	private static void JMNMHCFBFCB(HBJAMDIGIPB EHPGPJKDOHH, Action<KDDKDAIEDJF> HCGCCHPBLKM, NNBHCLAOLKE JPILDINHBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x8E1B0E0", Offset = "0x8E196E0", VA = "0x188E1B0E0")]
	private static void JMNMHCFBFCB(HBJAMDIGIPB EHPGPJKDOHH, Action<KDDKDAIEDJF> HCGCCHPBLKM, Predicate<NNBHCLAOLKE> DGHFHBJEEGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8E1A650", Offset = "0x8E18C50", VA = "0x188E1A650")]
	private void HHIKBPCMNLG(MEINMPIOLGA AGIMJJDFEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8E18680", Offset = "0x8E16C80", VA = "0x188E18680", Slot = "4")]
	[AsyncStateMachine(typeof(NIEDIACNDBM))]
	public Task DMBEJGIACKN([CanBeNull] NIDHIPJBPAM PGEPJKBFLOM, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8E1BFF0", Offset = "0x8E1A5F0", VA = "0x188E1BFF0")]
	private void NIKLBIADMNM(HBJAMDIGIPB PCEIGGEGPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8E17210", Offset = "0x8E15810", VA = "0x188E17210")]
	internal static string CKLLNICAKHD(JBNECHIFOAL JJEAGGFMAIL, NIDHIPJBPAM PGEPJKBFLOM, IReadOnlyDictionary<NNBHCLAOLKE, OBPPDGLDOBN> GMAAHNAHBBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8E17520", Offset = "0x8E15B20", VA = "0x188E17520")]
	private static void DELBNIPPBPC(NIDHIPJBPAM PGEPJKBFLOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x8E1A2E0", Offset = "0x8E188E0", VA = "0x188E1A2E0")]
	private static void GKGLNFJNDNJ(HBJAMDIGIPB EJKPGLPKDFI, IReadOnlyDictionary<NNBHCLAOLKE, OBPPDGLDOBN> GMAAHNAHBBG, StringBuilder HIIJGNGNODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8E187A0", Offset = "0x8E16DA0", VA = "0x188E187A0")]
	private static bool DONGBPKKHNB(string MNNHKLCOBBG, [Out] Guid KCHFAFIIKMM, [Out] NNBHCLAOLKE JFDKPNDDGFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8E1B8B0", Offset = "0x8E19EB0", VA = "0x188E1B8B0")]
	private static void MLOFMIBJFCN(NIDHIPJBPAM PGEPJKBFLOM, StringBuilder HIIJGNGNODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x32DA410", Offset = "0x32D8A10", VA = "0x1832DA410", Slot = "14")]
	public bool AOPIIJHPEBB<T>(NNBHCLAOLKE JFDKPNDDGFG, BGMLECFHONH LGNOKIBMMII, bool POOIFFHGDKN, T CGNPMBIJPEO, [Optional] Action LGJPMNJADHB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8E1C630", Offset = "0x8E1AC30", VA = "0x188E1C630", Slot = "15")]
	public string OOPMJBPDGEH(BGMLECFHONH LGNOKIBMMII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8E16FE0", Offset = "0x8E155E0", VA = "0x188E16FE0", Slot = "16")]
	public bool BNFBGKJOCEL(MEINMPIOLGA AGIMJJDFEAF, BGMLECFHONH DBCCEKNNHCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8E185C0", Offset = "0x8E16BC0", VA = "0x188E185C0", Slot = "18")]
	public bool DIGGGDPILBE(MNAALBCCOMC JFDKPNDDGFG, BGMLECFHONH DBCCEKNNHCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8E19EE0", Offset = "0x8E184E0", VA = "0x188E19EE0")]
	private void GBJAPCKIKPC(NNBHCLAOLKE JFDKPNDDGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8E1A630", Offset = "0x8E18C30", VA = "0x188E1A630")]
	private bool GMHHJDBAELM(MEINMPIOLGA AGIMJJDFEAF, NNBHCLAOLKE JFDKPNDDGFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8E1B610", Offset = "0x8E19C10", VA = "0x188E1B610")]
	private OBPPDGLDOBN KOJHDABBLCL(NNBHCLAOLKE JFDKPNDDGFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x8E1C3B0", Offset = "0x8E1A9B0", VA = "0x188E1C3B0")]
	internal NNBHCLAOLKE OHNPJDLHCGE(MEINMPIOLGA AGIMJJDFEAF)
	{
		return default(NNBHCLAOLKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x8E193A0", Offset = "0x8E179A0", VA = "0x188E193A0")]
	private void FIMKHHGLKPO(int AGIMJJDFEAF, NNBHCLAOLKE IEKOBJHMPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x8E189C0", Offset = "0x8E16FC0", VA = "0x188E189C0", Slot = "11")]
	public IReadOnlyList<BKNGMHAJKAE> EOJINGPDLGM(MEINMPIOLGA AGIMJJDFEAF, bool GJEPMHCLMMK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x8E189C0", Offset = "0x8E16FC0", VA = "0x188E189C0")]
	internal IReadOnlyList<OBPPDGLDOBN> NOFJAIKCCHH(MEINMPIOLGA AGIMJJDFEAF, bool GJEPMHCLMMK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x8E183F0", Offset = "0x8E169F0", VA = "0x188E183F0")]
	internal IReadOnlyList<OBPPDGLDOBN> DHCHFJJEFNG(NNBHCLAOLKE JFDKPNDDGFG, bool GJEPMHCLMMK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x8E18C00", Offset = "0x8E17200", VA = "0x188E18C00")]
	private void FHKGIHIEMFI(LKKEDIOHPOI BNBCEIOAEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x8E1C6B0", Offset = "0x8E1ACB0", VA = "0x188E1C6B0")]
	private static bool PANMAHFIBMC(OBPPDGLDOBN GCHMGCPCCKH, IReadOnlyDictionary<NNBHCLAOLKE, OBPPDGLDOBN> GMAAHNAHBBG, [Out] IReadOnlyList<BGMLECFHONH> GLBNIDAGDPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x8E1A6C0", Offset = "0x8E18CC0", VA = "0x188E1A6C0")]
	[AsyncStateMachine(typeof(DMJHJIPJFCL))]
	private static Task HKFEOFNNHIH(JBNECHIFOAL JJEAGGFMAIL, NIDHIPJBPAM PGEPJKBFLOM, IReadOnlyDictionary<NNBHCLAOLKE, OBPPDGLDOBN> GMAAHNAHBBG, KNOKIILHDFE NKJNDBENPHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x8E1B370", Offset = "0x8E19970", VA = "0x188E1B370")]
	[CompilerGenerated]
	internal static void KNNFGNHKIHC(Func<KDDKDAIEDJF, PBDDNLANJNA> MKGPPOFODHF, KOEMLJKIDDN P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x8E1ABD0", Offset = "0x8E191D0", VA = "0x188E1ABD0")]
	[CompilerGenerated]
	internal static bool JEIKFEHADEM(NNBHCLAOLKE JFDKPNDDGFG, BGMLECFHONH LGNOKIBMMII, [Out] GGNEEIDALJG DBLLHBJGAOM, HNIHIIJBMOA P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface MGFGBGPFKJE
{
	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BJEPHJCEEJF(MEINMPIOLGA EBPLJOJFFAB, MEINMPIOLGA GCCOFKELODJ, IEnumerable<MEINMPIOLGA> BDLDKEAGOLK, [Out] KCLEJFPLCEB FEGFNCMFFHF, [Out] GPFOBHIPJNN OJAEIELFIMD);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string IICLHHHNCCF(GPFOBHIPJNN AENHOGNMAJL);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum GPFOBHIPJNN : byte
{
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	CantKickEventOrganizer,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	Broadcaster,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	GameInProgress,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	OpponentGameInProgress
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class ECOGNAJODBE : MGFGBGPFKJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly OBOFLGAFHOK INKNDNMMHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly OMJDHBDOMPD JANNHDNAMLJ;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0xAA7000", Offset = "0xAA5600", VA = "0x180AA7000")]
	[RecRoom.NoEngine.Common.Preserve]
	public ECOGNAJODBE([EDHLHMEHMKO(null)] OBOFLGAFHOK INKNDNMMHGJ, [EDHLHMEHMKO(null)] OMJDHBDOMPD MCBEOHOIHMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x8E1EE40", Offset = "0x8E1D440", VA = "0x188E1EE40")]
	private static BJOPIOKAALI? JMKCHCAJFKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8E1EC40", Offset = "0x8E1D240", VA = "0x188E1EC40", Slot = "4")]
	public bool BJEPHJCEEJF(MEINMPIOLGA EBPLJOJFFAB, MEINMPIOLGA GCCOFKELODJ, IEnumerable<MEINMPIOLGA> BDLDKEAGOLK, [Out] KCLEJFPLCEB FEGFNCMFFHF, [Out] GPFOBHIPJNN OJAEIELFIMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x8E1ED40", Offset = "0x8E1D340", VA = "0x188E1ED40", Slot = "5")]
	public string IICLHHHNCCF(GPFOBHIPJNN AENHOGNMAJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x8E1EE80", Offset = "0x8E1D480", VA = "0x188E1EE80")]
	internal bool NNJJJGLMFNI(MEINMPIOLGA EBPLJOJFFAB, MEINMPIOLGA GCCOFKELODJ, IEnumerable<MEINMPIOLGA> BDLDKEAGOLK, PCHMDNLFCBM MANOLEPPJML, BJOPIOKAALI? FOFCMMDILND, [Out] KCLEJFPLCEB FEGFNCMFFHF, [Out] GPFOBHIPJNN OJAEIELFIMD)
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
