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
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
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
		[Cpp2IlInjected.Address(RVA = "0x79CB8F0", Offset = "0x79CAAF0", VA = "0x1879CB8F0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x91E490", Offset = "0x91D690", VA = "0x18091E490")]
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
		[Cpp2IlInjected.Address(RVA = "0x91E4D0", Offset = "0x91D6D0", VA = "0x18091E4D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum DPFEFONCOFL
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
		[Cpp2IlInjected.Address(RVA = "0x79CE1F0", Offset = "0x79CD3F0", VA = "0x1879CE1F0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x23EA930", Offset = "0x23E9B30", VA = "0x1823EA930")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void HKLFOKIHJKH<TPermission>(TPermission OEFNADFCFPH);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void AONPNJOGEFP(IAGJLFEFIKH IBFPGGCAJBP);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum LPBEFCIKNJN
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KIKPGOCCGIC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool KICPOJELMGF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool CPHOLFEKDFO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool IHFPDHMMNDD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool KDMJEGCCPKG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool NDOBCKJJKKB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool LOCBPKLCKFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class AGHCMFNNLLC
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum EBKAAEFMBFB
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
	public static readonly Guid GKADAEEAPLE;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid IOIAFMNCIEH;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid PMLGGBFBKDE;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid CMCBMDBGEMA;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid ABHGJNOFAEH;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid FCHMHJIFHAB;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly HKDBNICBMGP<HEOHLAMPJMC, Guid> BNCHNBNHCGK;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<HEOHLAMPJMC> CAGCMLCDNGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x79BFC90", Offset = "0x79BEE90", VA = "0x1879BFC90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x79BFF70", Offset = "0x79BF170", VA = "0x1879BFF70")]
	public static HEOHLAMPJMC OJALNNAIBKB(Guid IBPGMNEANFH)
	{
		return default(HEOHLAMPJMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x79BFED0", Offset = "0x79BF0D0", VA = "0x1879BFED0")]
	public static Guid LKDFLGEGKKJ(HEOHLAMPJMC DGMMAAOBBBA)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x79BFE40", Offset = "0x79BF040", VA = "0x1879BFE40")]
	public static bool KLIHPNCDOME(HEOHLAMPJMC DGMMAAOBBBA, [Out] Guid IBPGMNEANFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x79C0000", Offset = "0x79BF200", VA = "0x1879C0000")]
	public static bool PFNFFJGMCHD(Guid IBPGMNEANFH, [Out] HEOHLAMPJMC DGMMAAOBBBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x79BFD10", Offset = "0x79BEF10", VA = "0x1879BFD10")]
	public static HEOHLAMPJMC EDBNNPLPBHH(HEOHLAMPJMC DGMMAAOBBBA)
	{
		return default(HEOHLAMPJMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x79BFD50", Offset = "0x79BEF50", VA = "0x1879BFD50")]
	public static EBKAAEFMBFB ENIELPBGOAO(HEOHLAMPJMC DPNKFCGKAGC)
	{
		return default(EBKAAEFMBFB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x79BFE00", Offset = "0x79BF000", VA = "0x1879BFE00")]
	internal static HEOHLAMPJMC KENJEEMKLBB(EBKAAEFMBFB CEIBKFHFDKG)
	{
		return default(HEOHLAMPJMC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface POFDMNOPONA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	OJCJMAGHJGM MLNFFGDNAEP
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<NCINFOBFPIO> ACGPNEFFMCB
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event AONPNJOGEFP GLCPDKFNJHG;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<NCINFOBFPIO> KNMKPCCNHID(bool AJEJMLHPIOO = false);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NCINFOBFPIO FBHHBELNBMN(IAGJLFEFIKH IBFPGGCAJBP);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool FCENFJOGOGC(IAGJLFEFIKH IBFPGGCAJBP);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<NCINFOBFPIO> MLGGDGBCMMM(IAGJLFEFIKH IBFPGGCAJBP, bool ODKAKOAOHCK = false);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool PKFDGALILFN(IAGJLFEFIKH INNIIDJKCHL, HEOHLAMPJMC DGMMAAOBBBA);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	NCINFOBFPIO JMBCIGJDMHN(HEOHLAMPJMC DGMMAAOBBBA);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool EEIIDKKGLFN<T>(HEOHLAMPJMC DGMMAAOBBBA, LCEGEMGNKEJ OEFNADFCFPH, bool AJALJPFBHOD, T CJJMPIPLCIJ, [Optional] Action MNMBDMCPMHP) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string KLCDIOEIGNM(LCEGEMGNKEJ OEFNADFCFPH);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JOOGHAPEEJI
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task DLFJGLOFPFG(LJJCDEANBLH JPGPNLNCOHG, CancellationToken BGEKICMONBE);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CGGLNGMBJDP(LJJCDEANBLH JPGPNLNCOHG);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface EJFEMNCBCFG
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	IAGJLFEFIKH NHODNJNBAGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	KHDFIKJLGJL DMDKFHIDIFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	OAOBEPBAJLE FJMANNKMIOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<FOPALPKCCPA> IPODNBFJELB;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action CIOMPJOKJDO;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HEOHLAMPJMC JNNNJEIMPLG(IAGJLFEFIKH IBFPGGCAJBP);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<FOPALPKCCPA> IHMHJPGCGHF(CancellationToken BGEKICMONBE);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task JNAKPBGLIDA(long MOMKFNIIPAA, IReadOnlyList<BIPGEPCFPJF> EKEKBGHPCAH);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task KADJFKPMDCJ(long MOMKFNIIPAA, long GHKEIJKOONC, IReadOnlyList<BIPGEPCFPJF> EKEKBGHPCAH);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<IAGJLFEFIKH> GGFABMOMHGH();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class GCINCCNAEOC
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x79C2770", Offset = "0x79C1970", VA = "0x1879C2770")]
	public static HEOHLAMPJMC CMELEILIKAC(this EJFEMNCBCFG KJJEOODANNN)
	{
		return default(HEOHLAMPJMC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface NICGAAHNDGO<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string OJBPDEMBGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event HKLFOKIHJKH<TPermission> BHJEPDBBAON;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal abstract class FMIKKDIKNAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal object? MFLGMDFONDH;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? NNMHDMGCKNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x79C24A0", Offset = "0x79C16A0", VA = "0x1879C24A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x79C2570", Offset = "0x79C1770", VA = "0x1879C2570")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x79C2670", Offset = "0x79C1870", VA = "0x1879C2670")]
	protected FMIKKDIKNAG(object? CGHGEPCKAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool CEGMDJAEHHG(object? OMEFCJCOLII);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class LFKCKJHNHNJ<T> : FMIKKDIKNAG where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> FHMDPOEGNHH;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T ELOFPHHKCIM
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x49F2C50", Offset = "0x49F1E50", VA = "0x1849F2C50")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x49F2590", Offset = "0x49F1790", VA = "0x1849F2590", Slot = "4")]
	public override bool CEGMDJAEHHG(object? OMEFCJCOLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x49F28B0", Offset = "0x49F1AB0", VA = "0x1849F28B0")]
	public bool CMLMGPFAGOF(T KIBIGIMDJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x49F30A0", Offset = "0x49F22A0", VA = "0x1849F30A0")]
	public LFKCKJHNHNJ(T JEBHMGJFPIP, IEqualityComparer<T> FHMDPOEGNHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class LEMPDPGFIIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<LCEGEMGNKEJ, bool> OJMGEDMGCPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<LCEGEMGNKEJ, FMIKKDIKNAG> FKLCJMOAFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly BBNJDLOMPIM KJCLCOLLDIK;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x79C5650", Offset = "0x79C4850", VA = "0x1879C5650")]
	public LEMPDPGFIIL(BBNJDLOMPIM KJCLCOLLDIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x79C51A0", Offset = "0x79C43A0", VA = "0x1879C51A0")]
	public bool FOBGNIDHKAL(LCEGEMGNKEJ OEFNADFCFPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x33362B0", Offset = "0x33354B0", VA = "0x1833362B0")]
	public bool CBCOPNILGCG<T>(LCEGEMGNKEJ OEFNADFCFPH, bool AJALJPFBHOD, T OMEFCJCOLII) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3336850", Offset = "0x3335A50", VA = "0x183336850")]
	public (bool, T?) NELPAEHCBBD<T>(LCEGEMGNKEJ OEFNADFCFPH) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x79C50C0", Offset = "0x79C42C0", VA = "0x1879C50C0")]
	public bool CBCOPNILGCG(LCEGEMGNKEJ OEFNADFCFPH, bool AJALJPFBHOD, object OMEFCJCOLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x79C54C0", Offset = "0x79C46C0", VA = "0x1879C54C0")]
	public (bool, object) NELPAEHCBBD(LCEGEMGNKEJ OEFNADFCFPH)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3336CF0", Offset = "0x3335EF0", VA = "0x183336CF0")]
	private void PHIEOPDIIPE<T>(LCEGEMGNKEJ OEFNADFCFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x79C53F0", Offset = "0x79C45F0", VA = "0x1879C53F0")]
	private FMIKKDIKNAG MLJKMOMFILE(LCEGEMGNKEJ OEFNADFCFPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x79C5210", Offset = "0x79C4410", VA = "0x1879C5210")]
	public void LMINDMANBEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class ACOMBOPOPOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string OEOKJNDFNOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type ANNLILECFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly DKKAKIGBLDJ OFKNBDNAHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly LCEGEMGNKEJ CDOMHHCFJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public MAKEGOOMGDM ADKAFJENOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public AFJDHNIOGJE HMKAMLCDODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public LEIKDLMGDBH LNKLLBLMMEB;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x79BFBF0", Offset = "0x79BEDF0", VA = "0x1879BFBF0")]
	public ACOMBOPOPOP(Type KCBKFIKFMIB, string NCGFIKACHDK, LCEGEMGNKEJ OEFNADFCFPH, MAKEGOOMGDM KFJLMCNCDJA, AFJDHNIOGJE BPAPPGMCOGE, LEIKDLMGDBH HJCGBCCAFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x79BFAF0", Offset = "0x79BECF0", VA = "0x1879BFAF0")]
	public object JJNALONFJEP(object? JAINJPLCLDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x39E8770", Offset = "0x39E7970", VA = "0x1839E8770")]
	public void PHIEOPDIIPE<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x79BFB40", Offset = "0x79BED40", VA = "0x1879BFB40")]
	public void PHIEOPDIIPE(Type NCHCNCJAJCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class LEJCHCILDMB<T> : ACOMBOPOPOP where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate string DMFHNLPDHOI(T OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal delegate T PJBDNIGJJPA(string? KELNIDKKABC, T JEBHMGJFPIP);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class CBNLFANHFNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public DMFHNLPDHOI serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public PJBDNIGJJPA parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public CBNLFANHFNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x56E22B0", Offset = "0x56E14B0", VA = "0x1856E22B0")]
		internal string PPJPMAAMDBO(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x56E20A0", Offset = "0x56E12A0", VA = "0x1856E20A0")]
		internal object JONDHBOEEGN(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x49DC300", Offset = "0x49DB500", VA = "0x1849DC300")]
	public LEJCHCILDMB(LCEGEMGNKEJ OEFNADFCFPH, string NCGFIKACHDK, [Optional] DMFHNLPDHOI? KFJLMCNCDJA, [Optional] PJBDNIGJJPA? BPAPPGMCOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x49DAE90", Offset = "0x49DA090", VA = "0x1849DAE90")]
	private static object? LAEIJKNHIPI(PJBDNIGJJPA? BPAPPGMCOGE, string? KELNIDKKABC, object? JEBHMGJFPIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x49DBD10", Offset = "0x49DAF10", VA = "0x1849DBD10")]
	private static string LKDLAIOBOFF(DMFHNLPDHOI? HDFNKFALJIP, object? OMEFCJCOLII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate string MAKEGOOMGDM(object? OMEFCJCOLII);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate object AFJDHNIOGJE(string? KELNIDKKABC, [Optional] object JEBHMGJFPIP);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal delegate FMIKKDIKNAG LEIKDLMGDBH();
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class BBNJDLOMPIM
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class KKIOADOLPFM : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static KKIOADOLPFM CLACNPDFIIL;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x79C46A0", Offset = "0x79C38A0", VA = "0x1879C46A0", Slot = "4")]
		public bool Equals(List<string> KIEMJAMMNPB, List<string> IIOFLMMOEPL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x79C47F0", Offset = "0x79C39F0", VA = "0x1879C47F0", Slot = "5")]
		public int GetHashCode(List<string> LCACGJDNDHA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public KKIOADOLPFM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class MACENJNMBMP : LELIAKDGOEM<DPFEFONCOFL>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x79C58F0", Offset = "0x79C4AF0", VA = "0x1879C58F0", Slot = "9")]
		public override string LKDLAIOBOFF(DPFEFONCOFL DFKGLBJBJGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x79C59E0", Offset = "0x79C4BE0", VA = "0x1879C59E0", Slot = "10")]
		protected override bool OIOJOJAMPKC(string DFKGLBJBJGD, [Out] DPFEFONCOFL OMEFCJCOLII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x79C5BB0", Offset = "0x79C4DB0", VA = "0x1879C5BB0")]
		public MACENJNMBMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly CJHJMEAFFIC FCDOJGNBHPM;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly MACENJNMBMP ADLACEIKAOD;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<ACOMBOPOPOP> MAIKFLDBADK;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<LCEGEMGNKEJ> EJNNNMMPFJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<LCEGEMGNKEJ, ACOMBOPOPOP> DAMCLFPLMBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x79C1900", Offset = "0x79C0B00", VA = "0x1879C1900")]
	public BBNJDLOMPIM([Optional] IList<ACOMBOPOPOP>? PBNJEOGAAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x79C03C0", Offset = "0x79BF5C0", VA = "0x1879C03C0")]
	public ACOMBOPOPOP BKBJJIJLCPA(LCEGEMGNKEJ OEFNADFCFPH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface OJCJMAGHJGM
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	NCINFOBFPIO JJDBCKHKCNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class IJFEALPJBJA : OJCJMAGHJGM
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static IJFEALPJBJA HKGEHHIHLPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly PJEDIHBLGJK FHNFCHPBDLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<PJEDIHBLGJK> OFLHDNDJKHK;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public NCINFOBFPIO JJDBCKHKCNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x79C4500", Offset = "0x79C3700", VA = "0x1879C4500")]
	public IJFEALPJBJA(PJEDIHBLGJK LIKJGBCKGFF, IReadOnlyList<PJEDIHBLGJK> BFDBLNNKIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x79C3660", Offset = "0x79C2860", VA = "0x1879C3660")]
	private static IJFEALPJBJA HPGGKPKGGDL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class ICKPHHHACKO
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<HEOHLAMPJMC> LEKBNDCBFDM;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x79C27D0", Offset = "0x79C19D0", VA = "0x1879C27D0")]
	public static bool AJIBLKBBILL(this IAGJLFEFIKH FFIHLKECHEF, HEOHLAMPJMC DGMMAAOBBBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x79C28B0", Offset = "0x79C1AB0", VA = "0x1879C28B0")]
	public static bool CKCAHFNKBND(this IAGJLFEFIKH FFIHLKECHEF, HEOHLAMPJMC DGMMAAOBBBA, OAOBEPBAJLE MLFBMJNDMCH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface BOOMBNAGEMN
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool IGCIKMHLBBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool LAFKEHDPNLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool NGKHOACKMDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool BJBEPLNAFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool EFDJCCFEJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool BFOCMPGOIOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool MOKKEFJLMCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool CHJNHLDPMBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool AOIMHCOPONA
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool BKFKJEKPHGO
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool PHBLOOKNLKO
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool GCNJHBFOPKI
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> GDLPEDDFDIM
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	DPFEFONCOFL KHCIKEHIKJL
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface NCINFOBFPIO : BOOMBNAGEMN, KIKPGOCCGIC, NICGAAHNDGO<LCEGEMGNKEJ>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string CPLNEGKILND
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	HEOHLAMPJMC OGDBIGJNFAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) OCDNCACGOFC<T>(LCEGEMGNKEJ OEFNADFCFPH) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum LCEGEMGNKEJ
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
internal class PJEDIHBLGJK : NCINFOBFPIO, BOOMBNAGEMN, KIKPGOCCGIC, NICGAAHNDGO<LCEGEMGNKEJ>
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly BBNJDLOMPIM DIGJLFNAMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	internal readonly LEMPDPGFIIL OIDPIMKHBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private string? PFGOGNONIDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private string? HAMDGGKMMAE;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool OMKHLIIKLOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x79CC5C0", Offset = "0x79CB7C0", VA = "0x1879CC5C0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool IHNNAHLBHMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x79CC0E0", Offset = "0x79CB2E0", VA = "0x1879CC0E0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool CCAEKNDLKGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x79CCB30", Offset = "0x79CBD30", VA = "0x1879CCB30", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool BFKFMJNNCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x79CC700", Offset = "0x79CB900", VA = "0x1879CC700", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool AIKPCCPMKPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x79CB970", Offset = "0x79CAB70", VA = "0x1879CB970", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool MDJDCBICBHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x79CBDD0", Offset = "0x79CAFD0", VA = "0x1879CBDD0", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public HEOHLAMPJMC OGDBIGJNFAA
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xBB5FE0", Offset = "0xBB51E0", VA = "0x180BB5FE0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(HEOHLAMPJMC);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8FA8F0", Offset = "0x8F9AF0", VA = "0x1808FA8F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string OJBPDEMBGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x79CBD80", Offset = "0x79CAF80", VA = "0x1879CBD80", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x79CBD30", Offset = "0x79CAF30", VA = "0x1879CBD30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string CPLNEGKILND
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x79CBD80", Offset = "0x79CAF80", VA = "0x1879CBD80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool LLDDBONNFHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xC0B620", Offset = "0xC0A820", VA = "0x180C0B620")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xC0B640", Offset = "0xC0A840", VA = "0x180C0B640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool IGCIKMHLBBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x79CC6B0", Offset = "0x79CB8B0", VA = "0x1879CC6B0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public DPFEFONCOFL KHCIKEHIKJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x79CBC40", Offset = "0x79CAE40", VA = "0x1879CBC40", Slot = "20")]
		get
		{
			return default(DPFEFONCOFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool LAFKEHDPNLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x79CBF20", Offset = "0x79CB120", VA = "0x1879CBF20", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool NGKHOACKMDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x79CD6D0", Offset = "0x79CC8D0", VA = "0x1879CD6D0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool BJBEPLNAFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x79CC610", Offset = "0x79CB810", VA = "0x1879CC610", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool EFDJCCFEJFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x79CD720", Offset = "0x79CC920", VA = "0x1879CD720", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool BFOCMPGOIOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x79CBCE0", Offset = "0x79CAEE0", VA = "0x1879CBCE0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool MOKKEFJLMCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x79CC520", Offset = "0x79CB720", VA = "0x1879CC520", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool CHJNHLDPMBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x79CD5D0", Offset = "0x79CC7D0", VA = "0x1879CD5D0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool AOIMHCOPONA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x79CBC90", Offset = "0x79CAE90", VA = "0x1879CBC90", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> GDLPEDDFDIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x79CCB80", Offset = "0x79CBD80", VA = "0x1879CCB80", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool HCKFEEANIFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x79CC5C0", Offset = "0x79CB7C0", VA = "0x1879CC5C0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool EPMNMEJBPKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x79CB970", Offset = "0x79CAB70", VA = "0x1879CB970", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool EAMMHAKGKCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x79CC0E0", Offset = "0x79CB2E0", VA = "0x1879CC0E0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool BKFKJEKPHGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x79CC660", Offset = "0x79CB860", VA = "0x1879CC660", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool PHBLOOKNLKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x79CC570", Offset = "0x79CB770", VA = "0x1879CC570", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool LOCCLFGNCGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x79CCB30", Offset = "0x79CBD30", VA = "0x1879CCB30", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool GCNJHBFOPKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x79CD580", Offset = "0x79CC780", VA = "0x1879CD580", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool IIFFIDDEBPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x79CC700", Offset = "0x79CB900", VA = "0x1879CC700", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool GKMGMNFCFII
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x79CBDD0", Offset = "0x79CAFD0", VA = "0x1879CBDD0", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event HKLFOKIHJKH<LCEGEMGNKEJ> BHJEPDBBAON
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x79CD620", Offset = "0x79CC820", VA = "0x1879CD620", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x79CC470", Offset = "0x79CB670", VA = "0x1879CC470", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3474180", Offset = "0x3473380", VA = "0x183474180", Slot = "6")]
	public (bool, T?) OCDNCACGOFC<T>(LCEGEMGNKEJ OEFNADFCFPH) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3474120", Offset = "0x3473320", VA = "0x183474120")]
	public PJEDIHBLGJK NFAOOBGKJLF<T>(LCEGEMGNKEJ OEFNADFCFPH, bool AJALJPFBHOD, T OMEFCJCOLII) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x79CDA10", Offset = "0x79CCC10", VA = "0x1879CDA10")]
	public PJEDIHBLGJK(HEOHLAMPJMC DGMMAAOBBBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x79CD890", Offset = "0x79CCA90", VA = "0x1879CD890")]
	public PJEDIHBLGJK(HEOHLAMPJMC DGMMAAOBBBA, [Optional] string? PFGOGNONIDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x79CD800", Offset = "0x79CCA00", VA = "0x1879CD800")]
	public PJEDIHBLGJK(PJEDIHBLGJK NALNJICDOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x79CD8B0", Offset = "0x79CCAB0", VA = "0x1879CD8B0")]
	internal PJEDIHBLGJK(HEOHLAMPJMC INACFKFIIKC, [Optional] string? PFGOGNONIDB, [Optional] PJEDIHBLGJK? NALNJICDOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x79CB9C0", Offset = "0x79CABC0", VA = "0x1879CB9C0")]
	public static DKKAKIGBLDJ AELLCIACBJB(LCEGEMGNKEJ OEFNADFCFPH)
	{
		return default(DKKAKIGBLDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x79CD560", Offset = "0x79CC760", VA = "0x1879CD560")]
	public void LMINDMANBEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x79CC180", Offset = "0x79CB380", VA = "0x1879CC180")]
	internal PJEDIHBLGJK FMKBLFPINMP(PJEDIHBLGJK ODAOMDDGJBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x79CC750", Offset = "0x79CB950", VA = "0x1879CC750")]
	internal IReadOnlyCollection<LCEGEMGNKEJ> KBOLCOBAECE(PJEDIHBLGJK NALNJICDOHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x79CBF70", Offset = "0x79CB170", VA = "0x1879CBF70")]
	public bool DMCHJJAHLHN(LCEGEMGNKEJ OEFNADFCFPH, bool AJALJPFBHOD, string PDIMFHKBKMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x79CBE20", Offset = "0x79CB020", VA = "0x1879CBE20")]
	public (bool, string) DHEBFHHJNHC(LCEGEMGNKEJ OEFNADFCFPH)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x79CC130", Offset = "0x79CB330", VA = "0x1879CC130")]
	internal void FGLNNFIKMHJ(LCEGEMGNKEJ OEFNADFCFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x79CBA40", Offset = "0x79CAC40", VA = "0x1879CBA40")]
	public MBOJKCKFGGM ANLOANFCCPG(Func<HEOHLAMPJMC, Guid> INKLBLMAAHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x79CCBE0", Offset = "0x79CBDE0", VA = "0x1879CCBE0")]
	public void LHLAIAEKKBL(MBOJKCKFGGM NBANAKHBGOE, Func<Guid, HEOHLAMPJMC> DBHAINKEIOJ, [Optional] HEOHLAMPJMC? KKBFGDGBAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x79CC050", Offset = "0x79CB250", VA = "0x1879CC050")]
	[CompilerGenerated]
	private void EHMDJPMGCJH(LCEGEMGNKEJ DOOIAJHLJHE, CNBFFHNNIOD LLGCOJCLFFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class MJIPLNGONJN : JOOGHAPEEJI, POFDMNOPONA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class PLLIHKHAELE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public PJEDIHBLGJK newRole;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public PLLIHKHAELE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x79CDA30", Offset = "0x79CCC30", VA = "0x1879CDA30")]
		internal bool DOPKFPKGIEH(PJEDIHBLGJK rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class LCKBGKIKAPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public HEOHLAMPJMC roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public LCKBGKIKAPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x79C50B0", Offset = "0x79C42B0", VA = "0x1879C50B0")]
		internal bool OLJOMIMMCEE(HEOHLAMPJMC r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct KOIDIEAOPHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public MJIPLNGONJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public LJJCDEANBLH roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private TaskAwaiter<FOPALPKCCPA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x79C49E0", Offset = "0x79C3BE0", VA = "0x1879C49E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x79C5050", Offset = "0x79C4250", VA = "0x1879C5050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class NLAKNKBHJCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public NLAKNKBHJCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x79CB810", Offset = "0x79CAA10", VA = "0x1879CB810")]
		internal void JCKDPAEDAGH(MBOJKCKFGGM r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x79CB6F0", Offset = "0x79CA8F0", VA = "0x1879CB6F0")]
		internal void ENOMPGLEANA(MBOJKCKFGGM r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct NNLCGGNGFGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public LJJCDEANBLH roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class JPBALKMDLLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Func<MBOJKCKFGGM, CNBFFHNNIOD> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public JPBALKMDLLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x79C4670", Offset = "0x79C3870", VA = "0x1879C4670")]
		internal void OINCFIIHPPK(MBOJKCKFGGM r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x79C4610", Offset = "0x79C3810", VA = "0x1879C4610")]
		internal void JLHCCCDJEEN(MBOJKCKFGGM r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x79C4640", Offset = "0x79C3840", VA = "0x1879C4640")]
		internal void KFDBEKAPNBI(MBOJKCKFGGM r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class CGBKNMGODAP<T> where T : notnull
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
			public CGBKNMGODAP<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private TaskAwaiter<FOPALPKCCPA> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x3C1CC00", Offset = "0x3C1BE00", VA = "0x183C1CC00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x949E40", Offset = "0x949040", VA = "0x180949E40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public LCEGEMGNKEJ rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public HEOHLAMPJMC accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public DKKAKIGBLDJ recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public MJIPLNGONJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public CGBKNMGODAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5783EA0", Offset = "0x57830A0", VA = "0x185783EA0")]
		[AsyncStateMachine(typeof(CGBKNMGODAP<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void BIOKKAJMLFC()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct OLGIKLKLDAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public IReadOnlyList<BIPGEPCFPJF> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct IIAOBAIMMPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public EJFEMNCBCFG rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public LJJCDEANBLH roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public IReadOnlyDictionary<HEOHLAMPJMC, PJEDIHBLGJK> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public AMGPLCCFDEC debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x79C2AE0", Offset = "0x79C1CE0", VA = "0x1879C2AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x79C3600", Offset = "0x79C2800", VA = "0x1879C3600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly EJFEMNCBCFG KJJEOODANNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly IJFEALPJBJA NAAIJCKMPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly AMGPLCCFDEC OILOAKOCPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly Dictionary<int, PJEDIHBLGJK> DHIJBDBIIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	internal readonly Dictionary<HEOHLAMPJMC, PJEDIHBLGJK> KECNNJJBDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	internal readonly Dictionary<HEOHLAMPJMC, PJEDIHBLGJK> OKAJGNDDEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	internal readonly List<PJEDIHBLGJK> AEFKKBFGKML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private bool ALBEFGGBNJL;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static readonly LCEGEMGNKEJ[] HEFDNOMKFPI;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public OJCJMAGHJGM MLNFFGDNAEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<NCINFOBFPIO> ACGPNEFFMCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x79C5F80", Offset = "0x79C5180", VA = "0x1879C5F80", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event AONPNJOGEFP GLCPDKFNJHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x79C8430", Offset = "0x79C7630", VA = "0x1879C8430", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x79C5BF0", Offset = "0x79C4DF0", VA = "0x1879C5BF0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x79C5FD0", Offset = "0x79C51D0", VA = "0x1879C5FD0")]
	[NAOGKPPNIGE.MIHKMKENDLB]
	internal static void BHMHEMCKFJH(JBPONICDCIO FJGJKHFLABP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x79CB430", Offset = "0x79CA630", VA = "0x1879CB430")]
	[UnityEngine.Scripting.Preserve]
	internal MJIPLNGONJN([FMJHJHHALCB(null)] EJFEMNCBCFG HNIGKFHGODG, [FMJHJHHALCB(null)] IJFEALPJBJA EPLFNGHPHJB, [FMJHJHHALCB(null)] AMGPLCCFDEC OILOAKOCPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x79C77B0", Offset = "0x79C69B0", VA = "0x1879C77B0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x79C9A40", Offset = "0x79C8C40", VA = "0x1879C9A40")]
	private void NPOODEENPCJ(IEnumerable<PJEDIHBLGJK> DFGDMEKEIMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x79C7D90", Offset = "0x79C6F90", VA = "0x1879C7D90", Slot = "12")]
	public bool FCENFJOGOGC(IAGJLFEFIKH IBFPGGCAJBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x79C62D0", Offset = "0x79C54D0", VA = "0x1879C62D0")]
	private void CIOMPJOKJDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x79C8C10", Offset = "0x79C7E10", VA = "0x1879C8C10")]
	private void JFFLJMNAEKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x79C9020", Offset = "0x79C8220", VA = "0x1879C9020", Slot = "10")]
	public IReadOnlyList<NCINFOBFPIO> KNMKPCCNHID(bool AJEJMLHPIOO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x79C7C80", Offset = "0x79C6E80", VA = "0x1879C7C80", Slot = "11")]
	public NCINFOBFPIO FBHHBELNBMN(IAGJLFEFIKH IBFPGGCAJBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x79C90B0", Offset = "0x79C82B0", VA = "0x1879C90B0")]
	private HEOHLAMPJMC MLHOMMLBNNL(IAGJLFEFIKH IBFPGGCAJBP)
	{
		return default(HEOHLAMPJMC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x79CB0D0", Offset = "0x79CA2D0", VA = "0x1879CB0D0", Slot = "14")]
	public bool PKFDGALILFN(IAGJLFEFIKH INNIIDJKCHL, HEOHLAMPJMC DGMMAAOBBBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x79C8DF0", Offset = "0x79C7FF0", VA = "0x1879C8DF0", Slot = "15")]
	public NCINFOBFPIO JMBCIGJDMHN(HEOHLAMPJMC DGMMAAOBBBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x79C8100", Offset = "0x79C7300", VA = "0x1879C8100")]
	private static bool GPOHEEODCHF(KFJFOBGKBFF EMOOHHLMBEA, HEOHLAMPJMC DGMMAAOBBBA, [Out] MBOJKCKFGGM? HPKIPMDEKBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x79C96C0", Offset = "0x79C88C0", VA = "0x1879C96C0")]
	private static void NAANMLDDJPG(KFJFOBGKBFF EMOOHHLMBEA, Action<MBOJKCKFGGM> OKGMCHECFDA, HEOHLAMPJMC GNAKAJEDDDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x79C97B0", Offset = "0x79C89B0", VA = "0x1879C97B0")]
	private static void NAANMLDDJPG(KFJFOBGKBFF EMOOHHLMBEA, Action<MBOJKCKFGGM> OKGMCHECFDA, Predicate<HEOHLAMPJMC> ICIFADFNJAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x79C78C0", Offset = "0x79C6AC0", VA = "0x1879C78C0")]
	private void EBJDABLBFGH(IAGJLFEFIKH IBFPGGCAJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x79C7340", Offset = "0x79C6540", VA = "0x1879C7340", Slot = "4")]
	[AsyncStateMachine(typeof(KOIDIEAOPHE))]
	public Task DLFJGLOFPFG([CanBeNull] LJJCDEANBLH JPGPNLNCOHG, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
	public void CGGLNGMBJDP(LJJCDEANBLH JPGPNLNCOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x79C9380", Offset = "0x79C8580", VA = "0x1879C9380")]
	private void MPGHINJPHNO(KFJFOBGKBFF ANPOFMHLCLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x79C6890", Offset = "0x79C5A90", VA = "0x1879C6890")]
	internal static string DACLODGKDPC(EJFEMNCBCFG KJJEOODANNN, LJJCDEANBLH JPGPNLNCOHG, IReadOnlyDictionary<HEOHLAMPJMC, PJEDIHBLGJK> KECNNJJBDGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x79CA2A0", Offset = "0x79C94A0", VA = "0x1879CA2A0")]
	private static void PFKMGLKHKGO(LJJCDEANBLH JPGPNLNCOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x79C7460", Offset = "0x79C6660", VA = "0x1879C7460")]
	private static void DMAIHIMKNFK(KFJFOBGKBFF GMBCMBAHPPC, IReadOnlyDictionary<HEOHLAMPJMC, PJEDIHBLGJK> KECNNJJBDGA, StringBuilder BBDJHPFLHEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x79C8E90", Offset = "0x79C8090", VA = "0x1879C8E90")]
	private static bool JNHKCJJADBM(string CLEFDCPLKJB, [Out] Guid ONBOOBEJFAP, [Out] HEOHLAMPJMC DGMMAAOBBBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x79C84D0", Offset = "0x79C76D0", VA = "0x1879C84D0")]
	private static void IMDFGECGBPG(LJJCDEANBLH JPGPNLNCOHG, StringBuilder BBDJHPFLHEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3371D90", Offset = "0x3370F90", VA = "0x183371D90", Slot = "16")]
	public bool EEIIDKKGLFN<T>(HEOHLAMPJMC DGMMAAOBBBA, LCEGEMGNKEJ OEFNADFCFPH, bool AJALJPFBHOD, T CJJMPIPLCIJ, [Optional] Action MNMBDMCPMHP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x79C8FA0", Offset = "0x79C81A0", VA = "0x1879C8FA0", Slot = "17")]
	public string KLCDIOEIGNM(LCEGEMGNKEJ OEFNADFCFPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x79C9180", Offset = "0x79C8380", VA = "0x1879C9180")]
	private void MOLHEIKCLNF(HEOHLAMPJMC DGMMAAOBBBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x79C7930", Offset = "0x79C6B30", VA = "0x1879C7930")]
	private bool ENJAMDILNGI(IAGJLFEFIKH IBFPGGCAJBP, HEOHLAMPJMC DGMMAAOBBBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x79C7950", Offset = "0x79C6B50", VA = "0x1879C7950")]
	internal PJEDIHBLGJK EPBEKBPIIFM(IAGJLFEFIKH IBFPGGCAJBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x79C90A0", Offset = "0x79C82A0", VA = "0x1879C90A0", Slot = "13")]
	public IReadOnlyList<NCINFOBFPIO> MLGGDGBCMMM(IAGJLFEFIKH IBFPGGCAJBP, bool ODKAKOAOHCK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x79C6660", Offset = "0x79C5860", VA = "0x1879C6660")]
	internal IReadOnlyList<PJEDIHBLGJK> COLNIBLKADA(IAGJLFEFIKH IBFPGGCAJBP, bool ODKAKOAOHCK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x79C6BA0", Offset = "0x79C5DA0", VA = "0x1879C6BA0")]
	private void DHEOMOCKKGO(FOPALPKCCPA ILMGICKBPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x79C5C90", Offset = "0x79C4E90", VA = "0x1879C5C90")]
	private static bool AMJIHAPGCLJ(PJEDIHBLGJK MIBNNBOGOBF, IReadOnlyDictionary<HEOHLAMPJMC, PJEDIHBLGJK> KECNNJJBDGA, [Out] IReadOnlyList<LCEGEMGNKEJ> JCDFBCBEJBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x79C6190", Offset = "0x79C5390", VA = "0x1879C6190")]
	[AsyncStateMachine(typeof(IIAOBAIMMPN))]
	private static Task BMGHDOMMDIH(EJFEMNCBCFG KJJEOODANNN, LJJCDEANBLH JPGPNLNCOHG, IReadOnlyDictionary<HEOHLAMPJMC, PJEDIHBLGJK> KECNNJJBDGA, AMGPLCCFDEC OILOAKOCPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x79C7E60", Offset = "0x79C7060", VA = "0x1879C7E60")]
	[CompilerGenerated]
	internal static void FDBCMGOAPAM(Func<MBOJKCKFGGM, CNBFFHNNIOD> LJCMFMCAOLE, NNLCGGNGFGJ P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x79C62E0", Offset = "0x79C54E0", VA = "0x1879C62E0")]
	[CompilerGenerated]
	internal static bool COGNMDMNAFL(HEOHLAMPJMC DGMMAAOBBBA, LCEGEMGNKEJ OEFNADFCFPH, [Out] BIPGEPCFPJF KMKJMOFDPLP, OLGIKLKLDAK P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface ABIPMJMHGNH
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LPKMAOFHDNA(IAGJLFEFIKH KAGLBKHOFFK, IAGJLFEFIKH HFHGILMBHDB, IEnumerable<IAGJLFEFIKH> BLJFCCBJAAA, [Out] DPFEFONCOFL MGPKCEFEPEB, [Out] JOLPLICOPPK CNNLAELOFDC);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string ANNHGLPECNP(JOLPLICOPPK MIOEEHECJGD);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public enum JOLPLICOPPK : byte
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
internal class DJPJHBEEMEF : ABIPMJMHGNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly POFDMNOPONA JBMOFKCNJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly GCHPFNFFMAK KOJEGFGPNME;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x8FD3B0", Offset = "0x8FC5B0", VA = "0x1808FD3B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public DJPJHBEEMEF([FMJHJHHALCB(null)] POFDMNOPONA CJICLAMHLPF, [FMJHJHHALCB(null)] GCHPFNFFMAK JDMGCLHDELC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x79C1C50", Offset = "0x79C0E50", VA = "0x1879C1C50")]
	private static NDMIOOGNMJK? AICBDCDMNJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x79C23A0", Offset = "0x79C15A0", VA = "0x1879C23A0", Slot = "4")]
	public bool LPKMAOFHDNA(IAGJLFEFIKH KAGLBKHOFFK, IAGJLFEFIKH HFHGILMBHDB, IEnumerable<IAGJLFEFIKH> BLJFCCBJAAA, [Out] DPFEFONCOFL MGPKCEFEPEB, [Out] JOLPLICOPPK CNNLAELOFDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x79C1C90", Offset = "0x79C0E90", VA = "0x1879C1C90", Slot = "5")]
	public string ANNHGLPECNP(JOLPLICOPPK MIOEEHECJGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x79C1D90", Offset = "0x79C0F90", VA = "0x1879C1D90")]
	internal bool LCHKMLJIAPE(IAGJLFEFIKH KAGLBKHOFFK, IAGJLFEFIKH HFHGILMBHDB, IEnumerable<IAGJLFEFIKH> BLJFCCBJAAA, OAOBEPBAJLE MLFBMJNDMCH, NDMIOOGNMJK? OOMJOMGNAMK, [Out] DPFEFONCOFL MGPKCEFEPEB, [Out] JOLPLICOPPK CNNLAELOFDC)
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
