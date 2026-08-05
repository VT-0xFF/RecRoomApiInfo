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
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
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
		[Cpp2IlInjected.Address(RVA = "0x80B6E80", Offset = "0x80B6280", VA = "0x1880B6E80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9BF4A0", Offset = "0x9BE8A0", VA = "0x1809BF4A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BF4E0", Offset = "0x9BE8E0", VA = "0x1809BF4E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum OHHIJABBFOL
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
		[Cpp2IlInjected.Address(RVA = "0x80B7690", Offset = "0x80B6A90", VA = "0x1880B7690", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x254E750", Offset = "0x254DB50", VA = "0x18254E750")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void HCKFHLOBPAG<TPermission>(TPermission FBLIKKCCPCJ);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void HKALHGPNMOP(DNIGIBHMBIB IBDBHCFLLPC);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum BAJAGGPBNCL
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface LKALLOOMADF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool CAHGALKGEGA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool CLGOACAGBOB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool BMCEIPHGFCG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool MGGMEJODDAD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool EHHGDDOLPMM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool AHADMOGBDIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class CFOBBPKAFLD
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum PKEBNEJHHDK
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
	public static readonly Guid CCOFDLMPIKG;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid KFCBBBHFMKB;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid ICONBEIPODJ;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid ENBLICDCLEN;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid NPOIIILDDJJ;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid MJBFMOAEMCO;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly CCEPICLLJMB<NCKNCPPCAHN, Guid> BKPOPPPKNMB;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<NCKNCPPCAHN> BMGLGFPOHOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x80AB6C0", Offset = "0x80AAAC0", VA = "0x1880AB6C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x80AB580", Offset = "0x80AA980", VA = "0x1880AB580")]
	public static NCKNCPPCAHN NGPHBIIGGOJ(Guid KDBHLLEACIN)
	{
		return default(NCKNCPPCAHN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x80AB4A0", Offset = "0x80AA8A0", VA = "0x1880AB4A0")]
	public static Guid KMKMOFKAKBL(NCKNCPPCAHN PPFFCLHMHDJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x80AB410", Offset = "0x80AA810", VA = "0x1880AB410")]
	public static bool FFEFPNIBCNL(NCKNCPPCAHN PPFFCLHMHDJ, [Out] Guid KDBHLLEACIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x80AB370", Offset = "0x80AA770", VA = "0x1880AB370")]
	public static bool EPPLBCNFKAL(Guid KDBHLLEACIN, [Out] NCKNCPPCAHN PPFFCLHMHDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x80AB540", Offset = "0x80AA940", VA = "0x1880AB540")]
	public static NCKNCPPCAHN LHAOBGALPJC(NCKNCPPCAHN PPFFCLHMHDJ)
	{
		return default(NCKNCPPCAHN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x80AB610", Offset = "0x80AAA10", VA = "0x1880AB610")]
	public static PKEBNEJHHDK PILDDBMAEOK(NCKNCPPCAHN AJABOMKIABK)
	{
		return default(PKEBNEJHHDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x80AB330", Offset = "0x80AA730", VA = "0x1880AB330")]
	internal static NCKNCPPCAHN BFHNNICLNPC(PKEBNEJHHDK PGKEGLLDILB)
	{
		return default(NCKNCPPCAHN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface IAADJNIBCMA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	ABIOOGJHMCF MBFBLPJMKEC
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<HHPAKLBEJAM> JHKKCDPLADB
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event HKALHGPNMOP CCPECLIAHJC;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<HHPAKLBEJAM> PFGBEGILGKE(bool NCCOABGIDDM = false);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HHPAKLBEJAM BMBOJEJGJOA(DNIGIBHMBIB IBDBHCFLLPC);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool FMLBBDBMCCA(DNIGIBHMBIB IBDBHCFLLPC);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<HHPAKLBEJAM> MHIAGKOPEBN(DNIGIBHMBIB IBDBHCFLLPC, bool LIFFNNMHANL = false);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool KMGIHPJCPIO(DNIGIBHMBIB GAEECCLFAEF, NCKNCPPCAHN PPFFCLHMHDJ);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	HHPAKLBEJAM OOGICGPFEPC(NCKNCPPCAHN PPFFCLHMHDJ);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool MKOLCEFBOCO<T>(NCKNCPPCAHN PPFFCLHMHDJ, FCGIHGOBNME FBLIKKCCPCJ, bool DIBLFDJOAAM, T HBNMBAEKPFF, [Optional] Action LNAMBPFDPEM) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string PCOFGIKEEBB(FCGIHGOBNME FBLIKKCCPCJ);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface GPGAKBNPEKG
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task NMJGHKIKAAC(AOIFKBLFGKD LLMAFCHBBPF, CancellationToken LMNHDKIFBOH);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MIIEJFDJHCA(AOIFKBLFGKD LLMAFCHBBPF);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface GICLMOHFLAJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	DNIGIBHMBIB GLIPCCAMJLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	ELMNGLJGGCK DIJMKHAIBDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	IBBAMKLHGAN OPNILIPBKBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<PAAJOBNMPDD> NPBGPIMNOAH;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action BPKNOONLPDA;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NCKNCPPCAHN BJMHDMMOIAI(DNIGIBHMBIB IBDBHCFLLPC);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<PAAJOBNMPDD> CFEHEBALAPE(CancellationToken LMNHDKIFBOH);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task IMKHMFCIENL(long MIFADOBCMAC, IReadOnlyList<LPBCPCGNKGP> BACNEANHDIE);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task BLAPMBEIOOF(long MIFADOBCMAC, long OFAOCKBMEGP, IReadOnlyList<LPBCPCGNKGP> BACNEANHDIE);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<DNIGIBHMBIB> DNJNCAIFNPE();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class KABEKMONECC
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x80AF460", Offset = "0x80AE860", VA = "0x1880AF460")]
	public static NCKNCPPCAHN IFHLBFNDDHC(this GICLMOHFLAJ DFCAKLELDPP)
	{
		return default(NCKNCPPCAHN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface IFBMKJCDAPL<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string ACGGDOOEIEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event HCKFHLOBPAG<TPermission> CADPNLJCMDC;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal abstract class APMKCOOJHFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal object? DEHEKJIJFOF;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? JBHLNDBFLHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x80A8EF0", Offset = "0x80A82F0", VA = "0x1880A8EF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x80A8DF0", Offset = "0x80A81F0", VA = "0x1880A8DF0")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x80A8FC0", Offset = "0x80A83C0", VA = "0x1880A8FC0")]
	protected APMKCOOJHFN(object? BJFNAJDGDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool GBGCNCIFPPL(object? FFOEEMKIKJO);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class NMJOGCFNKBC<T> : APMKCOOJHFN where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> BJPBKLBLNPO;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T HDKOPKMNJCH
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x50E3F00", Offset = "0x50E3300", VA = "0x1850E3F00")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x50E43E0", Offset = "0x50E37E0", VA = "0x1850E43E0", Slot = "4")]
	public override bool GBGCNCIFPPL(object? FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x50E39D0", Offset = "0x50E2DD0", VA = "0x1850E39D0")]
	public bool CDDAPDGCIJE(T BMHLAMOJKMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x50E4680", Offset = "0x50E3A80", VA = "0x1850E4680")]
	public NMJOGCFNKBC(T PFCPDJEHNAP, IEqualityComparer<T> BJPBKLBLNPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class KDJENAPPANB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<FCGIHGOBNME, bool> KGMCNBCOCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<FCGIHGOBNME, APMKCOOJHFN> LFNJAJNEFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly CJAKDMFCAJI EICFCOGKPGG;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x80B05F0", Offset = "0x80AF9F0", VA = "0x1880B05F0")]
	public KDJENAPPANB(CJAKDMFCAJI EICFCOGKPGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x80B0040", Offset = "0x80AF440", VA = "0x1880B0040")]
	public bool IBKFNJBLOCC(FCGIHGOBNME FBLIKKCCPCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x36A82C0", Offset = "0x36A76C0", VA = "0x1836A82C0")]
	public bool IDHJHLBJCGL<T>(FCGIHGOBNME FBLIKKCCPCJ, bool DIBLFDJOAAM, T FFOEEMKIKJO) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x36A8860", Offset = "0x36A7C60", VA = "0x1836A8860")]
	public (bool, T?) MMNGKBIFFLL<T>(FCGIHGOBNME FBLIKKCCPCJ) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x80B00B0", Offset = "0x80AF4B0", VA = "0x1880B00B0")]
	public bool IDHJHLBJCGL(FCGIHGOBNME FBLIKKCCPCJ, bool DIBLFDJOAAM, object FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x80B0190", Offset = "0x80AF590", VA = "0x1880B0190")]
	public (bool, object) MMNGKBIFFLL(FCGIHGOBNME FBLIKKCCPCJ)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x36A8260", Offset = "0x36A7660", VA = "0x1836A8260")]
	private void BDGFKBDBHMD<T>(FCGIHGOBNME FBLIKKCCPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x80B0520", Offset = "0x80AF920", VA = "0x1880B0520")]
	private APMKCOOJHFN NJELHJEDJCF(FCGIHGOBNME FBLIKKCCPCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x80B0320", Offset = "0x80AF720", VA = "0x1880B0320")]
	public void MPPNNOBBJIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class CAMOHJJEHIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string FPBPKFOFMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type PPELPOEOMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly MCKODNJPPJK OHCINHCMNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly FCGIHGOBNME OCHLHLGCMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public EJBPECJDBAB DLAOMHILBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public BMLDFILIJCA MAJMOIKHDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public HFELHHDAOII GOEKNFADHEG;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x80AB290", Offset = "0x80AA690", VA = "0x1880AB290")]
	public CAMOHJJEHIP(Type HPIKJOGEBKL, string OEOLCNJCACI, FCGIHGOBNME FBLIKKCCPCJ, EJBPECJDBAB LPGCHGNEGFF, BMLDFILIJCA MFAECGLPFON, HFELHHDAOII PPGEPBCEGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x80AB240", Offset = "0x80AA640", VA = "0x1880AB240")]
	public object NCFLBPIEFMC(object? KNCKFHOKGJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x33E8630", Offset = "0x33E7A30", VA = "0x1833E8630")]
	public void BDGFKBDBHMD<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x80AB190", Offset = "0x80AA590", VA = "0x1880AB190")]
	public void BDGFKBDBHMD(Type JPCCCFFNIPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class HMKBPHBNAFJ<T> : CAMOHJJEHIP where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate string DPIBMKIHACI(T FFOEEMKIKJO);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal delegate T LAKAFJMNKIA(string? AGJFAAPJODH, T PFCPDJEHNAP);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class FBFEBAJCHCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public DPIBMKIHACI serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public LAKAFJMNKIA parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public FBFEBAJCHCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x46EDC30", Offset = "0x46ED030", VA = "0x1846EDC30")]
		internal string NEKAPODGPIO(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x46EDAE0", Offset = "0x46ECEE0", VA = "0x1846EDAE0")]
		internal object KEOGAEDPOCM(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x490AA00", Offset = "0x4909E00", VA = "0x18490AA00")]
	public HMKBPHBNAFJ(FCGIHGOBNME FBLIKKCCPCJ, string OEOLCNJCACI, [Optional] DPIBMKIHACI? LPGCHGNEGFF, [Optional] LAKAFJMNKIA? MFAECGLPFON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4909BB0", Offset = "0x4908FB0", VA = "0x184909BB0")]
	private static object? HFAEDKNMEEN(LAKAFJMNKIA? MFAECGLPFON, string? AGJFAAPJODH, object? PFCPDJEHNAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x490A730", Offset = "0x4909B30", VA = "0x18490A730")]
	private static string PELCBGJOJPC(DPIBMKIHACI? FAEKCGJEOPI, object? FFOEEMKIKJO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate string EJBPECJDBAB(object? FFOEEMKIKJO);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate object BMLDFILIJCA(string? AGJFAAPJODH, [Optional] object PFCPDJEHNAP);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal delegate APMKCOOJHFN HFELHHDAOII();
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class CJAKDMFCAJI
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class JMDOEGKGOIG : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static JMDOEGKGOIG DNEPPKLGBFA;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x80AF120", Offset = "0x80AE520", VA = "0x1880AF120", Slot = "4")]
		public bool Equals(List<string> MEAMPLHPPKP, List<string> KDELALKKKOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x80AF270", Offset = "0x80AE670", VA = "0x1880AF270", Slot = "5")]
		public int GetHashCode(List<string> BLFGIKOAKOL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public JMDOEGKGOIG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class NHEICIDAFNH : FICJNCNGGAA<OHHIJABBFOL>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x80B6B70", Offset = "0x80B5F70", VA = "0x1880B6B70", Slot = "9")]
		public override string PELCBGJOJPC(OHHIJABBFOL PJCOHHCODGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x80B6C60", Offset = "0x80B6060", VA = "0x1880B6C60", Slot = "10")]
		protected override bool PLIIBEGPKOB(string PJCOHHCODGF, [Out] OHHIJABBFOL FFOEEMKIKJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x80B6E40", Offset = "0x80B6240", VA = "0x1880B6E40")]
		public NHEICIDAFNH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly FCIOFBGPBAB LLEMDJLNDLG;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly NHEICIDAFNH NCFGEEDHKHC;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<CAMOHJJEHIP> ACMEEECICEL;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<FCGIHGOBNME> IFMKEDNKOPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9943E0", Offset = "0x9937E0", VA = "0x1809943E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<FCGIHGOBNME, CAMOHJJEHIP> GGEONOIJIAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x80AD000", Offset = "0x80AC400", VA = "0x1880AD000")]
	public CJAKDMFCAJI([Optional] IList<CAMOHJJEHIP>? IHKICNMPLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x80ABA60", Offset = "0x80AAE60", VA = "0x1880ABA60")]
	public CAMOHJJEHIP GAKMGLAIKLJ(FCGIHGOBNME FBLIKKCCPCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface ABIOOGJHMCF
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	HHPAKLBEJAM NGDAOKPOCAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class EEEEDEDGLBL : ABIOOGJHMCF
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static EEEEDEDGLBL NPGMJBAKGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly BOEHNCHDALB CJKOFADGEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<BOEHNCHDALB> GNABBJCCDHB;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public HHPAKLBEJAM NGDAOKPOCAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9943E0", Offset = "0x9937E0", VA = "0x1809943E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x80AEFE0", Offset = "0x80AE3E0", VA = "0x1880AEFE0")]
	public EEEEDEDGLBL(BOEHNCHDALB KJHBCFOIDGN, IReadOnlyList<BOEHNCHDALB> BMFFFJMFPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x80AE0C0", Offset = "0x80AD4C0", VA = "0x1880AE0C0")]
	private static EEEEDEDGLBL ILGKGLHJAHM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class DCOAFAJMOAK
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<NCKNCPPCAHN> DHIKCDCIMLK;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x80AD350", Offset = "0x80AC750", VA = "0x1880AD350")]
	public static bool EDNBLAIDPKF(this DNIGIBHMBIB GGMAHLNBIDK, NCKNCPPCAHN PPFFCLHMHDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x80AD430", Offset = "0x80AC830", VA = "0x1880AD430")]
	public static bool PJLHGCOFLIF(this DNIGIBHMBIB GGMAHLNBIDK, NCKNCPPCAHN PPFFCLHMHDJ, IBBAMKLHGAN ADBOOCEJEGJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface HGLDKBOEFAC
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool NFHOAFEIHAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool CIHHAAHIHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool MMEFECGDFII
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool LNDCIGBECED
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool IHBOCKMKFFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool FMPLHBBHIHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool DMEJGANDBNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool GHDKAMOONDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool KIBBJECIDHM
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool AONIDHKHMNE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool ODMHNKMJFDK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool KCFHGKJPGFN
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> NLOJOGMNOMF
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	OHHIJABBFOL AIPDNMMOLIK
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface HHPAKLBEJAM : HGLDKBOEFAC, LKALLOOMADF, IFBMKJCDAPL<FCGIHGOBNME>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string IMPBOAHNEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	NCKNCPPCAHN FIDEGENDEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) IFKCJEOGJML<T>(FCGIHGOBNME FBLIKKCCPCJ) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum FCGIHGOBNME
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
	CAN_ADD_ROOM_BANS = 1018,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	CAN_MODIFY_ROOM_WIDE_ASSETS = 1019
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal class BOEHNCHDALB : HHPAKLBEJAM, HGLDKBOEFAC, LKALLOOMADF, IFBMKJCDAPL<FCGIHGOBNME>
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	internal static readonly CJAKDMFCAJI JHGCAICFDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	internal readonly KDJENAPPANB PJJIDODNBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private string? OEPFIJEFDIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private string? DGGECIBFAAN;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool MGGNFMNCLFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x80A9F10", Offset = "0x80A9310", VA = "0x1880A9F10", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool CEFBMEAAFCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x80A9930", Offset = "0x80A8D30", VA = "0x1880A9930", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool EMIJEPOFGIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x80A9840", Offset = "0x80A8C40", VA = "0x1880A9840", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool NEHNGNJEMDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x80A9980", Offset = "0x80A8D80", VA = "0x1880A9980", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool BGCNKOHHGJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x80A98E0", Offset = "0x80A8CE0", VA = "0x1880A98E0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool OEMJDHCBMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x80AA0B0", Offset = "0x80A94B0", VA = "0x1880AA0B0", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public NCKNCPPCAHN FIDEGENDEEK
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9FB880", Offset = "0x9FAC80", VA = "0x1809FB880", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(NCKNCPPCAHN);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x99D7E0", Offset = "0x99CBE0", VA = "0x18099D7E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string ACGGDOOEIEM
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x80AA060", Offset = "0x80A9460", VA = "0x1880AA060", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x80A9B10", Offset = "0x80A8F10", VA = "0x1880A9B10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string IMPBOAHNEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x80AA060", Offset = "0x80A9460", VA = "0x1880AA060", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool NIMKLHMJEMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xCDB920", Offset = "0xCDAD20", VA = "0x180CDB920")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xCDB940", Offset = "0xCDAD40", VA = "0x180CDB940")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool NFHOAFEIHAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x80A9A20", Offset = "0x80A8E20", VA = "0x1880A9A20", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public OHHIJABBFOL AIPDNMMOLIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x80A9A70", Offset = "0x80A8E70", VA = "0x1880A9A70", Slot = "20")]
		get
		{
			return default(OHHIJABBFOL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool CIHHAAHIHCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x80A9E60", Offset = "0x80A9260", VA = "0x1880A9E60", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool MMEFECGDFII
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x80A99D0", Offset = "0x80A8DD0", VA = "0x1880A99D0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool LNDCIGBECED
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x80A9D90", Offset = "0x80A9190", VA = "0x1880A9D90", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool IHBOCKMKFFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x80A9B60", Offset = "0x80A8F60", VA = "0x1880A9B60", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool FMPLHBBHIHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x80AA100", Offset = "0x80A9500", VA = "0x1880AA100", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool DMEJGANDBNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x80A9170", Offset = "0x80A8570", VA = "0x1880A9170", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool GHDKAMOONDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x80AA010", Offset = "0x80A9410", VA = "0x1880AA010", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool KIBBJECIDHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x80AAB40", Offset = "0x80A9F40", VA = "0x1880AAB40", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> NLOJOGMNOMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x80A9EB0", Offset = "0x80A92B0", VA = "0x1880A9EB0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool POBKCCACJGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x80A9F10", Offset = "0x80A9310", VA = "0x1880A9F10", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool MOOONGIHBBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x80A98E0", Offset = "0x80A8CE0", VA = "0x1880A98E0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool NPJCOPONGIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x80A9930", Offset = "0x80A8D30", VA = "0x1880A9930", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool AONIDHKHMNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x80AAB90", Offset = "0x80A9F90", VA = "0x1880AAB90", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool ODMHNKMJFDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x80AAAF0", Offset = "0x80A9EF0", VA = "0x1880AAAF0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool CDPJNENKBLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x80A9840", Offset = "0x80A8C40", VA = "0x1880A9840", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool KCFHGKJPGFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x80A9890", Offset = "0x80A8C90", VA = "0x1880A9890", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool BOGICKKGMBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x80A9980", Offset = "0x80A8D80", VA = "0x1880A9980", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool OMNMAKFEEPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x80AA0B0", Offset = "0x80A94B0", VA = "0x1880AA0B0", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event HCKFHLOBPAG<FCGIHGOBNME> CADPNLJCMDC
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x80A9F60", Offset = "0x80A9360", VA = "0x1880A9F60", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x80A90C0", Offset = "0x80A84C0", VA = "0x1880A90C0", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3387850", Offset = "0x3386C50", VA = "0x183387850", Slot = "6")]
	public (bool, T?) IFKCJEOGJML<T>(FCGIHGOBNME FBLIKKCCPCJ) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x33877F0", Offset = "0x3386BF0", VA = "0x1833877F0")]
	public BOEHNCHDALB BGAAGHJFHHK<T>(FCGIHGOBNME FBLIKKCCPCJ, bool DIBLFDJOAAM, T FFOEEMKIKJO) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x80AB170", Offset = "0x80AA570", VA = "0x1880AB170")]
	public BOEHNCHDALB(NCKNCPPCAHN PPFFCLHMHDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x80AB0C0", Offset = "0x80AA4C0", VA = "0x1880AB0C0")]
	public BOEHNCHDALB(NCKNCPPCAHN PPFFCLHMHDJ, [Optional] string? OEPFIJEFDIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x80AB0E0", Offset = "0x80AA4E0", VA = "0x1880AB0E0")]
	public BOEHNCHDALB(BOEHNCHDALB DBAFDCDLIPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x80AAF60", Offset = "0x80AA360", VA = "0x1880AAF60")]
	internal BOEHNCHDALB(NCKNCPPCAHN LPNFKAPOGFH, [Optional] string? OEPFIJEFDIF, [Optional] BOEHNCHDALB? DBAFDCDLIPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x80A9DE0", Offset = "0x80A91E0", VA = "0x1880A9DE0")]
	public static MCKODNJPPJK KHEKJHEKOOA(FCGIHGOBNME FBLIKKCCPCJ)
	{
		return default(MCKODNJPPJK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x80AA150", Offset = "0x80A9550", VA = "0x1880AA150")]
	public void MPPNNOBBJIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x80AABE0", Offset = "0x80A9FE0", VA = "0x1880AABE0")]
	internal BOEHNCHDALB PMHHBAMNHCB(BOEHNCHDALB IKLLPCLPHGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x80A93C0", Offset = "0x80A87C0", VA = "0x1880A93C0")]
	internal IReadOnlyCollection<FCGIHGOBNME> CCCHPCPMLBA(BOEHNCHDALB DBAFDCDLIPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x80A9CB0", Offset = "0x80A90B0", VA = "0x1880A9CB0")]
	public bool JNCBLBMBAOJ(FCGIHGOBNME FBLIKKCCPCJ, bool DIBLFDJOAAM, string HEPNKPKENHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x80A9BB0", Offset = "0x80A8FB0", VA = "0x1880A9BB0")]
	public (bool, string) JGJCJOHLPEB(FCGIHGOBNME FBLIKKCCPCJ)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x80A9AC0", Offset = "0x80A8EC0", VA = "0x1880A9AC0")]
	internal void HJIAMAFEBNG(FCGIHGOBNME FBLIKKCCPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x80A91C0", Offset = "0x80A85C0", VA = "0x1880A91C0")]
	public LFMMIEFMEAN BFBLBCFADMM(Func<NCKNCPPCAHN, Guid> MBKPLMLLHOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x80AA170", Offset = "0x80A9570", VA = "0x1880AA170")]
	public void OAEMPBBDOKB(LFMMIEFMEAN CAOMHHHLBAG, Func<Guid, NCKNCPPCAHN> KHDKJDMCGFH, [Optional] NCKNCPPCAHN? OBABDGOILHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x80A97B0", Offset = "0x80A8BB0", VA = "0x1880A97B0")]
	[CompilerGenerated]
	private void CHOHJLCIEEB(FCGIHGOBNME DMDKAOJPMCH, CEKBHHCFMAM PAAHLGFPANG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class LODBDKGNCPB : GPGAKBNPEKG, IAADJNIBCMA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class ILAIGFLDMEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public BOEHNCHDALB newRole;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public ILAIGFLDMEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x80AF0F0", Offset = "0x80AE4F0", VA = "0x1880AF0F0")]
		internal bool CBIOKDHPNOE(BOEHNCHDALB rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class MIAGBGLALDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public NCKNCPPCAHN roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public MIAGBGLALDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x1AC00D0", Offset = "0x1ABF4D0", VA = "0x181AC00D0")]
		internal bool FCKLFMHCDOI(NCKNCPPCAHN r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct NBGKKPEKDEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public LODBDKGNCPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AOIFKBLFGKD roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<PAAJOBNMPDD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x80B64A0", Offset = "0x80B58A0", VA = "0x1880B64A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x80B6B10", Offset = "0x80B5F10", VA = "0x1880B6B10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class DENCHMJGDFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public DENCHMJGDFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x80AD660", Offset = "0x80ACA60", VA = "0x1880AD660")]
		internal void HDADDAAIEFB(LFMMIEFMEAN r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x80AD740", Offset = "0x80ACB40", VA = "0x1880AD740")]
		internal void PMKKDDMIHOD(LFMMIEFMEAN r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct BHNBAAAOIGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AOIFKBLFGKD roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class LNGKLODDPCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Func<LFMMIEFMEAN, CEKBHHCFMAM> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public LNGKLODDPCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x80B08A0", Offset = "0x80AFCA0", VA = "0x1880B08A0")]
		internal void BKFBPBDCCAC(LFMMIEFMEAN r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x80B0900", Offset = "0x80AFD00", VA = "0x1880B0900")]
		internal void LFKBNDMEDPO(LFMMIEFMEAN r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x80B08D0", Offset = "0x80AFCD0", VA = "0x1880B08D0")]
		internal void JMBHPPMDPMF(LFMMIEFMEAN r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class HDCLHKNHBHM<T> where T : notnull
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
			public HDCLHKNHBHM<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private TaskAwaiter<PAAJOBNMPDD> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x3E806A0", Offset = "0x3E7FAA0", VA = "0x183E806A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x9F4FB0", Offset = "0x9F43B0", VA = "0x1809F4FB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public FCGIHGOBNME rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public NCKNCPPCAHN accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public MCKODNJPPJK recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public LODBDKGNCPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public HDCLHKNHBHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x48CA720", Offset = "0x48C9B20", VA = "0x1848CA720")]
		[AsyncStateMachine(typeof(HDCLHKNHBHM<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void JIEPMICMIEE()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct HNOPBDAOHBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public IReadOnlyList<LPBCPCGNKGP> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct KABMILEIKJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public GICLMOHFLAJ rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AOIFKBLFGKD roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public IReadOnlyDictionary<NCKNCPPCAHN, BOEHNCHDALB> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public ENCEHJNHPBL debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x80AF4C0", Offset = "0x80AE8C0", VA = "0x1880AF4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x80AFFE0", Offset = "0x80AF3E0", VA = "0x1880AFFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly GICLMOHFLAJ DFCAKLELDPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly EEEEDEDGLBL JMJCPFCEEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly ENCEHJNHPBL HKNGEHEEHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly Dictionary<int, BOEHNCHDALB> EPPGLJHHOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	internal readonly Dictionary<NCKNCPPCAHN, BOEHNCHDALB> GLKAPLONGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	internal readonly Dictionary<NCKNCPPCAHN, BOEHNCHDALB> NCBIOEBFHII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	internal readonly List<BOEHNCHDALB> DMKODOPEAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private bool JPPBIKKKIGN;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly FCGIHGOBNME[] CACBBIMNDEH;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public ABIOOGJHMCF MBFBLPJMKEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<HHPAKLBEJAM> JHKKCDPLADB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x80B5F40", Offset = "0x80B5340", VA = "0x1880B5F40", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event HKALHGPNMOP CCPECLIAHJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x80B1D30", Offset = "0x80B1130", VA = "0x1880B1D30", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x80B23E0", Offset = "0x80B17E0", VA = "0x1880B23E0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x80B2150", Offset = "0x80B1550", VA = "0x1880B2150")]
	[NOCPMGCIOME.FDFINDJJAOF]
	internal static void FJKHLPMEJLC(DHLGDCALOEP EOJAEMANAOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x80B61E0", Offset = "0x80B55E0", VA = "0x1880B61E0")]
	[UnityEngine.Scripting.Preserve]
	internal LODBDKGNCPB([CMKKAFOAFJE(null)] GICLMOHFLAJ AKNMLOKEEPJ, [CMKKAFOAFJE(null)] EEEEDEDGLBL PGBFAFJOLFN, [CMKKAFOAFJE(null)] ENCEHJNHPBL HKNGEHEEHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x80B1C20", Offset = "0x80B1020", VA = "0x1880B1C20", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x80B0E80", Offset = "0x80B0280", VA = "0x1880B0E80")]
	private void AMGJOLNLKMB(IEnumerable<BOEHNCHDALB> EFLLFINLBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x80B2310", Offset = "0x80B1710", VA = "0x1880B2310", Slot = "12")]
	public bool FMLBBDBMCCA(DNIGIBHMBIB IBDBHCFLLPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x80B1820", Offset = "0x80B0C20", VA = "0x1880B1820")]
	private void BPKNOONLPDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x80B2480", Offset = "0x80B1880", VA = "0x1880B2480")]
	private void GBMIAJJDBNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x80B5F90", Offset = "0x80B5390", VA = "0x1880B5F90", Slot = "10")]
	public IReadOnlyList<HHPAKLBEJAM> PFGBEGILGKE(bool NCCOABGIDDM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x80B1710", Offset = "0x80B0B10", VA = "0x1880B1710", Slot = "11")]
	public HHPAKLBEJAM BMBOJEJGJOA(DNIGIBHMBIB IBDBHCFLLPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x80B2670", Offset = "0x80B1A70", VA = "0x1880B2670")]
	private NCKNCPPCAHN GOGMOFAJKKB(DNIGIBHMBIB IBDBHCFLLPC)
	{
		return default(NCKNCPPCAHN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x80B3E60", Offset = "0x80B3260", VA = "0x1880B3E60", Slot = "14")]
	public bool KMGIHPJCPIO(DNIGIBHMBIB GAEECCLFAEF, NCKNCPPCAHN PPFFCLHMHDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x80B5680", Offset = "0x80B4A80", VA = "0x1880B5680", Slot = "15")]
	public HHPAKLBEJAM OOGICGPFEPC(NCKNCPPCAHN PPFFCLHMHDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x80B4300", Offset = "0x80B3700", VA = "0x1880B4300")]
	private static bool LPAIABKIJJI(GHDGNDPJDIA PHPAGPJKPHN, NCKNCPPCAHN PPFFCLHMHDJ, [Out] LFMMIEFMEAN? MNOGNOMOHIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x80B2060", Offset = "0x80B1460", VA = "0x1880B2060")]
	private static void FGEFADKJBMG(GHDGNDPJDIA PHPAGPJKPHN, Action<LFMMIEFMEAN> CGDEOHENBJO, NCKNCPPCAHN NIIJHENOOCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x80B1DD0", Offset = "0x80B11D0", VA = "0x1880B1DD0")]
	private static void FGEFADKJBMG(GHDGNDPJDIA PHPAGPJKPHN, Action<LFMMIEFMEAN> CGDEOHENBJO, Predicate<NCKNCPPCAHN> BLFKILAHMGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x80B1BB0", Offset = "0x80B0FB0", VA = "0x1880B1BB0")]
	private void DEGLICIPOHP(DNIGIBHMBIB IBDBHCFLLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x80B5420", Offset = "0x80B4820", VA = "0x1880B5420", Slot = "4")]
	[AsyncStateMachine(typeof(NBGKKPEKDEC))]
	public Task NMJGHKIKAAC([CanBeNull] AOIFKBLFGKD LLMAFCHBBPF, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
	public void MIIEJFDJHCA(AOIFKBLFGKD LLMAFCHBBPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x80B0B40", Offset = "0x80AFF40", VA = "0x1880B0B40")]
	private void ALLGLDJLOCJ(GHDGNDPJDIA ENEEDEPAAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x80B3FF0", Offset = "0x80B33F0", VA = "0x1880B3FF0")]
	internal static string LMHAALPOLAD(GICLMOHFLAJ DFCAKLELDPP, AOIFKBLFGKD LLMAFCHBBPF, IReadOnlyDictionary<NCKNCPPCAHN, BOEHNCHDALB> GLKAPLONGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x80B2D90", Offset = "0x80B2190", VA = "0x1880B2D90")]
	private static void JIOPEJKMHBI(AOIFKBLFGKD LLMAFCHBBPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x80B4D70", Offset = "0x80B4170", VA = "0x1880B4D70")]
	private static void MFMOELAGEJF(GHDGNDPJDIA EGBDPIOJLOL, IReadOnlyDictionary<NCKNCPPCAHN, BOEHNCHDALB> GLKAPLONGOJ, StringBuilder CHNHFLNBKAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x80B2740", Offset = "0x80B1B40", VA = "0x1880B2740")]
	private static bool HBDPHHEEFIK(string IMKJDBFJEEG, [Out] Guid HEBEHGLGBHF, [Out] NCKNCPPCAHN PPFFCLHMHDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x80B4630", Offset = "0x80B3A30", VA = "0x1880B4630")]
	private static void MEFAOMKEKEH(AOIFKBLFGKD LLMAFCHBBPF, StringBuilder CHNHFLNBKAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x36F92E0", Offset = "0x36F86E0", VA = "0x1836F92E0", Slot = "16")]
	public bool MKOLCEFBOCO<T>(NCKNCPPCAHN PPFFCLHMHDJ, FCGIHGOBNME FBLIKKCCPCJ, bool DIBLFDJOAAM, T HBNMBAEKPFF, [Optional] Action LNAMBPFDPEM) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x80B5EC0", Offset = "0x80B52C0", VA = "0x1880B5EC0", Slot = "17")]
	public string PCOFGIKEEBB(FCGIHGOBNME FBLIKKCCPCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x80B0930", Offset = "0x80AFD30", VA = "0x1880B0930")]
	private void AJNDKLMJADJ(NCKNCPPCAHN PPFFCLHMHDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x80B2B40", Offset = "0x80B1F40", VA = "0x1880B2B40")]
	private bool IBIGGBEHONM(DNIGIBHMBIB IBDBHCFLLPC, NCKNCPPCAHN PPFFCLHMHDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x80B50D0", Offset = "0x80B44D0", VA = "0x1880B50D0")]
	internal BOEHNCHDALB MPBPJFGJLFP(DNIGIBHMBIB IBDBHCFLLPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x80B50C0", Offset = "0x80B44C0", VA = "0x1880B50C0", Slot = "13")]
	public IReadOnlyList<HHPAKLBEJAM> MHIAGKOPEBN(DNIGIBHMBIB IBDBHCFLLPC, bool LIFFNNMHANL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x80B2B60", Offset = "0x80B1F60", VA = "0x1880B2B60")]
	internal IReadOnlyList<BOEHNCHDALB> JHFJGAGMBDE(DNIGIBHMBIB IBDBHCFLLPC, bool LIFFNNMHANL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x80B5720", Offset = "0x80B4B20", VA = "0x1880B5720")]
	private void OPMEGKOGHMH(PAAJOBNMPDD AIKKCEBFHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x80B2850", Offset = "0x80B1C50", VA = "0x1880B2850")]
	private static bool HPFBMGJCDHE(BOEHNCHDALB BBCCBLCCKFJ, IReadOnlyDictionary<NCKNCPPCAHN, BOEHNCHDALB> GLKAPLONGOJ, [Out] IReadOnlyList<FCGIHGOBNME> BEPKCIJMICF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x80B5540", Offset = "0x80B4940", VA = "0x1880B5540")]
	[AsyncStateMachine(typeof(KABMILEIKJC))]
	private static Task NPNONKNDEEN(GICLMOHFLAJ DFCAKLELDPP, AOIFKBLFGKD LLMAFCHBBPF, IReadOnlyDictionary<NCKNCPPCAHN, BOEHNCHDALB> GLKAPLONGOJ, ENCEHJNHPBL HKNGEHEEHMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x80B3BC0", Offset = "0x80B2FC0", VA = "0x1880B3BC0")]
	[CompilerGenerated]
	internal static void KBIHHICHHNP(Func<LFMMIEFMEAN, CEKBHHCFMAM> OMCOOPNLANE, BHNBAAAOIGF P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x80B1830", Offset = "0x80B0C30", VA = "0x1880B1830")]
	[CompilerGenerated]
	internal static bool CFKPABEJDPE(NCKNCPPCAHN PPFFCLHMHDJ, FCGIHGOBNME FBLIKKCCPCJ, [Out] LPBCPCGNKGP CGDNGIOJADI, HNOPBDAOHBH P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface IBOJIKHPALH
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JJLIAKFPGBG(DNIGIBHMBIB DNBKEKEOGAH, DNIGIBHMBIB JDKOIKLGDJK, IEnumerable<DNIGIBHMBIB> OFAMBEFDOGI, [Out] OHHIJABBFOL FDFMBGNIIME, [Out] OEDACCNNBMB LGOLHPAEGOB);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string MALCJMADGHJ(OEDACCNNBMB HBGLDCCHPCI);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public enum OEDACCNNBMB : byte
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
internal class DFHOEPFKJDP : IBOJIKHPALH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly IAADJNIBCMA HKPHNNLNAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly CMIEJLMGHBD JPHJHICJHKC;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x9A3500", Offset = "0x9A2900", VA = "0x1809A3500")]
	[RecRoom.NoEngine.Common.Preserve]
	public DFHOEPFKJDP([CMKKAFOAFJE(null)] IAADJNIBCMA IKLOCAOHHHM, [CMKKAFOAFJE(null)] CMIEJLMGHBD OOPDCGIOGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x80AE080", Offset = "0x80AD480", VA = "0x1880AE080")]
	private static ADLCFHGEHLG? NBPHEODBENF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x80AD860", Offset = "0x80ACC60", VA = "0x1880AD860", Slot = "4")]
	public bool JJLIAKFPGBG(DNIGIBHMBIB DNBKEKEOGAH, DNIGIBHMBIB JDKOIKLGDJK, IEnumerable<DNIGIBHMBIB> OFAMBEFDOGI, [Out] OHHIJABBFOL FDFMBGNIIME, [Out] OEDACCNNBMB LGOLHPAEGOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x80AD960", Offset = "0x80ACD60", VA = "0x1880AD960", Slot = "5")]
	public string MALCJMADGHJ(OEDACCNNBMB HBGLDCCHPCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x80ADA60", Offset = "0x80ACE60", VA = "0x1880ADA60")]
	internal bool MMNONEOGMOH(DNIGIBHMBIB DNBKEKEOGAH, DNIGIBHMBIB JDKOIKLGDJK, IEnumerable<DNIGIBHMBIB> OFAMBEFDOGI, IBBAMKLHGAN ADBOOCEJEGJ, ADLCFHGEHLG? ENCMAPAMCPP, [Out] OHHIJABBFOL FDFMBGNIIME, [Out] OEDACCNNBMB LGOLHPAEGOB)
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
