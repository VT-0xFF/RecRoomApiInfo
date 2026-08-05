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
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
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
		[Cpp2IlInjected.Address(RVA = "0x81023A0", Offset = "0x81017A0", VA = "0x1881023A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9D5490", Offset = "0x9D4890", VA = "0x1809D5490")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D54D0", Offset = "0x9D48D0", VA = "0x1809D54D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8102B80", Offset = "0x8101F80", VA = "0x188102B80", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2553680", Offset = "0x2552A80", VA = "0x182553680")]
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
		[Cpp2IlInjected.Address(RVA = "0x80F6E40", Offset = "0x80F6240", VA = "0x1880F6E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x80F6D00", Offset = "0x80F6100", VA = "0x1880F6D00")]
	public static NCKNCPPCAHN NGPHBIIGGOJ(Guid KDBHLLEACIN)
	{
		return default(NCKNCPPCAHN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x80F6C20", Offset = "0x80F6020", VA = "0x1880F6C20")]
	public static Guid KMKMOFKAKBL(NCKNCPPCAHN PPFFCLHMHDJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x80F6B90", Offset = "0x80F5F90", VA = "0x1880F6B90")]
	public static bool FFEFPNIBCNL(NCKNCPPCAHN PPFFCLHMHDJ, [Out] Guid KDBHLLEACIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x80F6AF0", Offset = "0x80F5EF0", VA = "0x1880F6AF0")]
	public static bool EPPLBCNFKAL(Guid KDBHLLEACIN, [Out] NCKNCPPCAHN PPFFCLHMHDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x80F6CC0", Offset = "0x80F60C0", VA = "0x1880F6CC0")]
	public static NCKNCPPCAHN LHAOBGALPJC(NCKNCPPCAHN PPFFCLHMHDJ)
	{
		return default(NCKNCPPCAHN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x80F6D90", Offset = "0x80F6190", VA = "0x1880F6D90")]
	public static PKEBNEJHHDK PILDDBMAEOK(NCKNCPPCAHN AJABOMKIABK)
	{
		return default(PKEBNEJHHDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x80F6AB0", Offset = "0x80F5EB0", VA = "0x1880F6AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x80FAB10", Offset = "0x80F9F10", VA = "0x1880FAB10")]
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
		[Cpp2IlInjected.Address(RVA = "0x80F46B0", Offset = "0x80F3AB0", VA = "0x1880F46B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x80F45B0", Offset = "0x80F39B0", VA = "0x1880F45B0")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x80F4780", Offset = "0x80F3B80", VA = "0x1880F4780")]
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
		[Cpp2IlInjected.Address(RVA = "0x5104F20", Offset = "0x5104320", VA = "0x185104F20")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5105400", Offset = "0x5104800", VA = "0x185105400", Slot = "4")]
	public override bool GBGCNCIFPPL(object? FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x51049F0", Offset = "0x5103DF0", VA = "0x1851049F0")]
	public bool CDDAPDGCIJE(T BMHLAMOJKMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x51056A0", Offset = "0x5104AA0", VA = "0x1851056A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x80FBC90", Offset = "0x80FB090", VA = "0x1880FBC90")]
	public KDJENAPPANB(CJAKDMFCAJI EICFCOGKPGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x80FB6F0", Offset = "0x80FAAF0", VA = "0x1880FB6F0")]
	public bool IBKFNJBLOCC(FCGIHGOBNME FBLIKKCCPCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x36BB330", Offset = "0x36BA730", VA = "0x1836BB330")]
	public bool IDHJHLBJCGL<T>(FCGIHGOBNME FBLIKKCCPCJ, bool DIBLFDJOAAM, T FFOEEMKIKJO) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x36BB8B0", Offset = "0x36BACB0", VA = "0x1836BB8B0")]
	public (bool, T?) MMNGKBIFFLL<T>(FCGIHGOBNME FBLIKKCCPCJ) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x80FB760", Offset = "0x80FAB60", VA = "0x1880FB760")]
	public bool IDHJHLBJCGL(FCGIHGOBNME FBLIKKCCPCJ, bool DIBLFDJOAAM, object FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x80FB840", Offset = "0x80FAC40", VA = "0x1880FB840")]
	public (bool, object) MMNGKBIFFLL(FCGIHGOBNME FBLIKKCCPCJ)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x36BB2D0", Offset = "0x36BA6D0", VA = "0x1836BB2D0")]
	private void BDGFKBDBHMD<T>(FCGIHGOBNME FBLIKKCCPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x80FBBC0", Offset = "0x80FAFC0", VA = "0x1880FBBC0")]
	private APMKCOOJHFN NJELHJEDJCF(FCGIHGOBNME FBLIKKCCPCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x80FB9D0", Offset = "0x80FADD0", VA = "0x1880FB9D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x80F6A10", Offset = "0x80F5E10", VA = "0x1880F6A10")]
	public CAMOHJJEHIP(Type HPIKJOGEBKL, string OEOLCNJCACI, FCGIHGOBNME FBLIKKCCPCJ, EJBPECJDBAB LPGCHGNEGFF, BMLDFILIJCA MFAECGLPFON, HFELHHDAOII PPGEPBCEGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x80F69C0", Offset = "0x80F5DC0", VA = "0x1880F69C0")]
	public object NCFLBPIEFMC(object? KNCKFHOKGJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x33FC590", Offset = "0x33FB990", VA = "0x1833FC590")]
	public void BDGFKBDBHMD<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x80F6910", Offset = "0x80F5D10", VA = "0x1880F6910")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public FBFEBAJCHCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4706DB0", Offset = "0x47061B0", VA = "0x184706DB0")]
		internal string NEKAPODGPIO(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4706C60", Offset = "0x4706060", VA = "0x184706C60")]
		internal object KEOGAEDPOCM(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4923150", Offset = "0x4922550", VA = "0x184923150")]
	public HMKBPHBNAFJ(FCGIHGOBNME FBLIKKCCPCJ, string OEOLCNJCACI, [Optional] DPIBMKIHACI? LPGCHGNEGFF, [Optional] LAKAFJMNKIA? MFAECGLPFON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4922310", Offset = "0x4921710", VA = "0x184922310")]
	private static object? HFAEDKNMEEN(LAKAFJMNKIA? MFAECGLPFON, string? AGJFAAPJODH, object? PFCPDJEHNAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4922E80", Offset = "0x4922280", VA = "0x184922E80")]
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
		[Cpp2IlInjected.Address(RVA = "0x80FA7E0", Offset = "0x80F9BE0", VA = "0x1880FA7E0", Slot = "4")]
		public bool Equals(List<string> MEAMPLHPPKP, List<string> KDELALKKKOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x80FA930", Offset = "0x80F9D30", VA = "0x1880FA930", Slot = "5")]
		public int GetHashCode(List<string> BLFGIKOAKOL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public JMDOEGKGOIG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class NHEICIDAFNH : FICJNCNGGAA<OHHIJABBFOL>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x81020A0", Offset = "0x81014A0", VA = "0x1881020A0", Slot = "9")]
		public override string PELCBGJOJPC(OHHIJABBFOL PJCOHHCODGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8102190", Offset = "0x8101590", VA = "0x188102190", Slot = "10")]
		protected override bool PLIIBEGPKOB(string PJCOHHCODGF, [Out] OHHIJABBFOL FFOEEMKIKJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8102360", Offset = "0x8101760", VA = "0x188102360")]
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
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x80F8710", Offset = "0x80F7B10", VA = "0x1880F8710")]
	public CJAKDMFCAJI([Optional] IList<CAMOHJJEHIP>? IHKICNMPLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x80F71A0", Offset = "0x80F65A0", VA = "0x1880F71A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x80FA6A0", Offset = "0x80F9AA0", VA = "0x1880FA6A0")]
	public EEEEDEDGLBL(BOEHNCHDALB KJHBCFOIDGN, IReadOnlyList<BOEHNCHDALB> BMFFFJMFPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x80F9790", Offset = "0x80F8B90", VA = "0x1880F9790")]
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
	[Cpp2IlInjected.Address(RVA = "0x80F8A30", Offset = "0x80F7E30", VA = "0x1880F8A30")]
	public static bool EDNBLAIDPKF(this DNIGIBHMBIB GGMAHLNBIDK, NCKNCPPCAHN PPFFCLHMHDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x80F8B10", Offset = "0x80F7F10", VA = "0x1880F8B10")]
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
		[Cpp2IlInjected.Address(RVA = "0x80F56C0", Offset = "0x80F4AC0", VA = "0x1880F56C0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool CEFBMEAAFCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x80F50F0", Offset = "0x80F44F0", VA = "0x1880F50F0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool EMIJEPOFGIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x80F5000", Offset = "0x80F4400", VA = "0x1880F5000", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool NEHNGNJEMDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x80F5140", Offset = "0x80F4540", VA = "0x1880F5140", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool BGCNKOHHGJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x80F50A0", Offset = "0x80F44A0", VA = "0x1880F50A0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool OEMJDHCBMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x80F5860", Offset = "0x80F4C60", VA = "0x1880F5860", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public NCKNCPPCAHN FIDEGENDEEK
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xA11750", Offset = "0xA10B50", VA = "0x180A11750", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(NCKNCPPCAHN);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9B3680", Offset = "0x9B2A80", VA = "0x1809B3680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string ACGGDOOEIEM
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x80F5810", Offset = "0x80F4C10", VA = "0x1880F5810", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x80F52D0", Offset = "0x80F46D0", VA = "0x1880F52D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string IMPBOAHNEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x80F5810", Offset = "0x80F4C10", VA = "0x1880F5810", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool NIMKLHMJEMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xCC5610", Offset = "0xCC4A10", VA = "0x180CC5610")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xCC5630", Offset = "0xCC4A30", VA = "0x180CC5630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool NFHOAFEIHAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x80F51E0", Offset = "0x80F45E0", VA = "0x1880F51E0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public OHHIJABBFOL AIPDNMMOLIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x80F5230", Offset = "0x80F4630", VA = "0x1880F5230", Slot = "20")]
		get
		{
			return default(OHHIJABBFOL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool CIHHAAHIHCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x80F5610", Offset = "0x80F4A10", VA = "0x1880F5610", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool MMEFECGDFII
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x80F5190", Offset = "0x80F4590", VA = "0x1880F5190", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool LNDCIGBECED
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x80F5550", Offset = "0x80F4950", VA = "0x1880F5550", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool IHBOCKMKFFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x80F5320", Offset = "0x80F4720", VA = "0x1880F5320", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool FMPLHBBHIHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x80F58B0", Offset = "0x80F4CB0", VA = "0x1880F58B0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool DMEJGANDBNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x80F4930", Offset = "0x80F3D30", VA = "0x1880F4930", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool GHDKAMOONDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x80F57C0", Offset = "0x80F4BC0", VA = "0x1880F57C0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool KIBBJECIDHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x80F62F0", Offset = "0x80F56F0", VA = "0x1880F62F0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> NLOJOGMNOMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x80F5660", Offset = "0x80F4A60", VA = "0x1880F5660", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool POBKCCACJGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x80F56C0", Offset = "0x80F4AC0", VA = "0x1880F56C0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool MOOONGIHBBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x80F50A0", Offset = "0x80F44A0", VA = "0x1880F50A0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool NPJCOPONGIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x80F50F0", Offset = "0x80F44F0", VA = "0x1880F50F0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool AONIDHKHMNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x80F6340", Offset = "0x80F5740", VA = "0x1880F6340", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool ODMHNKMJFDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x80F62A0", Offset = "0x80F56A0", VA = "0x1880F62A0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool CDPJNENKBLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x80F5000", Offset = "0x80F4400", VA = "0x1880F5000", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool KCFHGKJPGFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x80F5050", Offset = "0x80F4450", VA = "0x1880F5050", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool BOGICKKGMBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x80F5140", Offset = "0x80F4540", VA = "0x1880F5140", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool OMNMAKFEEPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x80F5860", Offset = "0x80F4C60", VA = "0x1880F5860", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event HCKFHLOBPAG<FCGIHGOBNME> CADPNLJCMDC
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x80F5710", Offset = "0x80F4B10", VA = "0x1880F5710", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x80F4880", Offset = "0x80F3C80", VA = "0x1880F4880", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x339DAD0", Offset = "0x339CED0", VA = "0x18339DAD0", Slot = "6")]
	public (bool, T?) IFKCJEOGJML<T>(FCGIHGOBNME FBLIKKCCPCJ) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x339DA70", Offset = "0x339CE70", VA = "0x18339DA70")]
	public BOEHNCHDALB BGAAGHJFHHK<T>(FCGIHGOBNME FBLIKKCCPCJ, bool DIBLFDJOAAM, T FFOEEMKIKJO) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x80F68F0", Offset = "0x80F5CF0", VA = "0x1880F68F0")]
	public BOEHNCHDALB(NCKNCPPCAHN PPFFCLHMHDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x80F6850", Offset = "0x80F5C50", VA = "0x1880F6850")]
	public BOEHNCHDALB(NCKNCPPCAHN PPFFCLHMHDJ, [Optional] string? OEPFIJEFDIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x80F6870", Offset = "0x80F5C70", VA = "0x1880F6870")]
	public BOEHNCHDALB(BOEHNCHDALB DBAFDCDLIPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x80F6700", Offset = "0x80F5B00", VA = "0x1880F6700")]
	internal BOEHNCHDALB(NCKNCPPCAHN LPNFKAPOGFH, [Optional] string? OEPFIJEFDIF, [Optional] BOEHNCHDALB? DBAFDCDLIPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x80F55A0", Offset = "0x80F49A0", VA = "0x1880F55A0")]
	public static MCKODNJPPJK KHEKJHEKOOA(FCGIHGOBNME FBLIKKCCPCJ)
	{
		return default(MCKODNJPPJK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x80F5900", Offset = "0x80F4D00", VA = "0x1880F5900")]
	public void MPPNNOBBJIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x80F6390", Offset = "0x80F5790", VA = "0x1880F6390")]
	internal BOEHNCHDALB PMHHBAMNHCB(BOEHNCHDALB IKLLPCLPHGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x80F4B80", Offset = "0x80F3F80", VA = "0x1880F4B80")]
	internal IReadOnlyCollection<FCGIHGOBNME> CCCHPCPMLBA(BOEHNCHDALB DBAFDCDLIPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x80F5470", Offset = "0x80F4870", VA = "0x1880F5470")]
	public bool JNCBLBMBAOJ(FCGIHGOBNME FBLIKKCCPCJ, bool DIBLFDJOAAM, string HEPNKPKENHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x80F5370", Offset = "0x80F4770", VA = "0x1880F5370")]
	public (bool, string) JGJCJOHLPEB(FCGIHGOBNME FBLIKKCCPCJ)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x80F5280", Offset = "0x80F4680", VA = "0x1880F5280")]
	internal void HJIAMAFEBNG(FCGIHGOBNME FBLIKKCCPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x80F4980", Offset = "0x80F3D80", VA = "0x1880F4980")]
	public LFMMIEFMEAN BFBLBCFADMM(Func<NCKNCPPCAHN, Guid> MBKPLMLLHOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x80F5920", Offset = "0x80F4D20", VA = "0x1880F5920")]
	public void OAEMPBBDOKB(LFMMIEFMEAN CAOMHHHLBAG, Func<Guid, NCKNCPPCAHN> KHDKJDMCGFH, [Optional] NCKNCPPCAHN? OBABDGOILHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x80F4F70", Offset = "0x80F4370", VA = "0x1880F4F70")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public ILAIGFLDMEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x80FA7B0", Offset = "0x80F9BB0", VA = "0x1880FA7B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public MIAGBGLALDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x1AD2F40", Offset = "0x1AD2340", VA = "0x181AD2F40")]
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
		[Cpp2IlInjected.Address(RVA = "0x81019D0", Offset = "0x8100DD0", VA = "0x1881019D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8102040", Offset = "0x8101440", VA = "0x188102040", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public DENCHMJGDFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x80F8D30", Offset = "0x80F8130", VA = "0x1880F8D30")]
		internal void HDADDAAIEFB(LFMMIEFMEAN r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x80F8E10", Offset = "0x80F8210", VA = "0x1880F8E10")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public LNGKLODDPCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x80FBF40", Offset = "0x80FB340", VA = "0x1880FBF40")]
		internal void BKFBPBDCCAC(LFMMIEFMEAN r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x80FBFA0", Offset = "0x80FB3A0", VA = "0x1880FBFA0")]
		internal void LFKBNDMEDPO(LFMMIEFMEAN r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x80FBF70", Offset = "0x80FB370", VA = "0x1880FBF70")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E8F720", Offset = "0x3E8EB20", VA = "0x183E8F720", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xA0AFE0", Offset = "0xA0A3E0", VA = "0x180A0AFE0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public HDCLHKNHBHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x48FB900", Offset = "0x48FAD00", VA = "0x1848FB900")]
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
		[Cpp2IlInjected.Address(RVA = "0x80FAB70", Offset = "0x80F9F70", VA = "0x1880FAB70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x80FB690", Offset = "0x80FAA90", VA = "0x1880FB690", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<HHPAKLBEJAM> JHKKCDPLADB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8101470", Offset = "0x8100870", VA = "0x188101470", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event HKALHGPNMOP CCPECLIAHJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x80FD390", Offset = "0x80FC790", VA = "0x1880FD390", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x80FDA30", Offset = "0x80FCE30", VA = "0x1880FDA30", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x80FD7B0", Offset = "0x80FCBB0", VA = "0x1880FD7B0")]
	[NOCPMGCIOME.FDFINDJJAOF]
	internal static void FJKHLPMEJLC(DHLGDCALOEP EOJAEMANAOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8101710", Offset = "0x8100B10", VA = "0x188101710")]
	[UnityEngine.Scripting.Preserve]
	internal LODBDKGNCPB([CMKKAFOAFJE(null)] GICLMOHFLAJ AKNMLOKEEPJ, [CMKKAFOAFJE(null)] EEEEDEDGLBL PGBFAFJOLFN, [CMKKAFOAFJE(null)] ENCEHJNHPBL HKNGEHEEHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x80FD280", Offset = "0x80FC680", VA = "0x1880FD280", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x80FC510", Offset = "0x80FB910", VA = "0x1880FC510")]
	private void AMGJOLNLKMB(IEnumerable<BOEHNCHDALB> EFLLFINLBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x80FD960", Offset = "0x80FCD60", VA = "0x1880FD960", Slot = "12")]
	public bool FMLBBDBMCCA(DNIGIBHMBIB IBDBHCFLLPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x80FCE80", Offset = "0x80FC280", VA = "0x1880FCE80")]
	private void BPKNOONLPDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x80FDAD0", Offset = "0x80FCED0", VA = "0x1880FDAD0")]
	private void GBMIAJJDBNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x81014C0", Offset = "0x81008C0", VA = "0x1881014C0", Slot = "10")]
	public IReadOnlyList<HHPAKLBEJAM> PFGBEGILGKE(bool NCCOABGIDDM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x80FCD70", Offset = "0x80FC170", VA = "0x1880FCD70", Slot = "11")]
	public HHPAKLBEJAM BMBOJEJGJOA(DNIGIBHMBIB IBDBHCFLLPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x80FDCB0", Offset = "0x80FD0B0", VA = "0x1880FDCB0")]
	private NCKNCPPCAHN GOGMOFAJKKB(DNIGIBHMBIB IBDBHCFLLPC)
	{
		return default(NCKNCPPCAHN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x80FF3C0", Offset = "0x80FE7C0", VA = "0x1880FF3C0", Slot = "14")]
	public bool KMGIHPJCPIO(DNIGIBHMBIB GAEECCLFAEF, NCKNCPPCAHN PPFFCLHMHDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x8100BD0", Offset = "0x80FFFD0", VA = "0x188100BD0", Slot = "15")]
	public HHPAKLBEJAM OOGICGPFEPC(NCKNCPPCAHN PPFFCLHMHDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x80FF860", Offset = "0x80FEC60", VA = "0x1880FF860")]
	private static bool LPAIABKIJJI(GHDGNDPJDIA PHPAGPJKPHN, NCKNCPPCAHN PPFFCLHMHDJ, [Out] LFMMIEFMEAN? MNOGNOMOHIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x80FD6C0", Offset = "0x80FCAC0", VA = "0x1880FD6C0")]
	private static void FGEFADKJBMG(GHDGNDPJDIA PHPAGPJKPHN, Action<LFMMIEFMEAN> CGDEOHENBJO, NCKNCPPCAHN NIIJHENOOCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x80FD430", Offset = "0x80FC830", VA = "0x1880FD430")]
	private static void FGEFADKJBMG(GHDGNDPJDIA PHPAGPJKPHN, Action<LFMMIEFMEAN> CGDEOHENBJO, Predicate<NCKNCPPCAHN> BLFKILAHMGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x80FD210", Offset = "0x80FC610", VA = "0x1880FD210")]
	private void DEGLICIPOHP(DNIGIBHMBIB IBDBHCFLLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x8100970", Offset = "0x80FFD70", VA = "0x188100970", Slot = "4")]
	[AsyncStateMachine(typeof(NBGKKPEKDEC))]
	public Task NMJGHKIKAAC([CanBeNull] AOIFKBLFGKD LLMAFCHBBPF, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "5")]
	public void MIIEJFDJHCA(AOIFKBLFGKD LLMAFCHBBPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x80FC1D0", Offset = "0x80FB5D0", VA = "0x1880FC1D0")]
	private void ALLGLDJLOCJ(GHDGNDPJDIA ENEEDEPAAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x80FF550", Offset = "0x80FE950", VA = "0x1880FF550")]
	internal static string LMHAALPOLAD(GICLMOHFLAJ DFCAKLELDPP, AOIFKBLFGKD LLMAFCHBBPF, IReadOnlyDictionary<NCKNCPPCAHN, BOEHNCHDALB> GLKAPLONGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x80FE3C0", Offset = "0x80FD7C0", VA = "0x1880FE3C0")]
	private static void JIOPEJKMHBI(AOIFKBLFGKD LLMAFCHBBPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x81002D0", Offset = "0x80FF6D0", VA = "0x1881002D0")]
	private static void MFMOELAGEJF(GHDGNDPJDIA EGBDPIOJLOL, IReadOnlyDictionary<NCKNCPPCAHN, BOEHNCHDALB> GLKAPLONGOJ, StringBuilder CHNHFLNBKAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x80FDD80", Offset = "0x80FD180", VA = "0x1880FDD80")]
	private static bool HBDPHHEEFIK(string IMKJDBFJEEG, [Out] Guid HEBEHGLGBHF, [Out] NCKNCPPCAHN PPFFCLHMHDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x80FFB90", Offset = "0x80FEF90", VA = "0x1880FFB90")]
	private static void MEFAOMKEKEH(AOIFKBLFGKD LLMAFCHBBPF, StringBuilder CHNHFLNBKAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x370CB00", Offset = "0x370BF00", VA = "0x18370CB00", Slot = "16")]
	public bool MKOLCEFBOCO<T>(NCKNCPPCAHN PPFFCLHMHDJ, FCGIHGOBNME FBLIKKCCPCJ, bool DIBLFDJOAAM, T HBNMBAEKPFF, [Optional] Action LNAMBPFDPEM) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8101400", Offset = "0x8100800", VA = "0x188101400", Slot = "17")]
	public string PCOFGIKEEBB(FCGIHGOBNME FBLIKKCCPCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x80FBFD0", Offset = "0x80FB3D0", VA = "0x1880FBFD0")]
	private void AJNDKLMJADJ(NCKNCPPCAHN PPFFCLHMHDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x80FE170", Offset = "0x80FD570", VA = "0x1880FE170")]
	private bool IBIGGBEHONM(DNIGIBHMBIB IBDBHCFLLPC, NCKNCPPCAHN PPFFCLHMHDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8100630", Offset = "0x80FFA30", VA = "0x188100630")]
	internal BOEHNCHDALB MPBPJFGJLFP(DNIGIBHMBIB IBDBHCFLLPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8100620", Offset = "0x80FFA20", VA = "0x188100620", Slot = "13")]
	public IReadOnlyList<HHPAKLBEJAM> MHIAGKOPEBN(DNIGIBHMBIB IBDBHCFLLPC, bool LIFFNNMHANL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x80FE190", Offset = "0x80FD590", VA = "0x1880FE190")]
	internal IReadOnlyList<BOEHNCHDALB> JHFJGAGMBDE(DNIGIBHMBIB IBDBHCFLLPC, bool LIFFNNMHANL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x8100C70", Offset = "0x8100070", VA = "0x188100C70")]
	private void OPMEGKOGHMH(PAAJOBNMPDD AIKKCEBFHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x80FDE90", Offset = "0x80FD290", VA = "0x1880FDE90")]
	private static bool HPFBMGJCDHE(BOEHNCHDALB BBCCBLCCKFJ, IReadOnlyDictionary<NCKNCPPCAHN, BOEHNCHDALB> GLKAPLONGOJ, [Out] IReadOnlyList<FCGIHGOBNME> BEPKCIJMICF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x8100A90", Offset = "0x80FFE90", VA = "0x188100A90")]
	[AsyncStateMachine(typeof(KABMILEIKJC))]
	private static Task NPNONKNDEEN(GICLMOHFLAJ DFCAKLELDPP, AOIFKBLFGKD LLMAFCHBBPF, IReadOnlyDictionary<NCKNCPPCAHN, BOEHNCHDALB> GLKAPLONGOJ, ENCEHJNHPBL HKNGEHEEHMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x80FF120", Offset = "0x80FE520", VA = "0x1880FF120")]
	[CompilerGenerated]
	internal static void KBIHHICHHNP(Func<LFMMIEFMEAN, CEKBHHCFMAM> OMCOOPNLANE, BHNBAAAOIGF P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x80FCE90", Offset = "0x80FC290", VA = "0x1880FCE90")]
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
	[Cpp2IlInjected.Address(RVA = "0x9B9340", Offset = "0x9B8740", VA = "0x1809B9340")]
	[RecRoom.NoEngine.Common.Preserve]
	public DFHOEPFKJDP([CMKKAFOAFJE(null)] IAADJNIBCMA IKLOCAOHHHM, [CMKKAFOAFJE(null)] CMIEJLMGHBD OOPDCGIOGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x80F9750", Offset = "0x80F8B50", VA = "0x1880F9750")]
	private static ADLCFHGEHLG? NBPHEODBENF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x80F8F30", Offset = "0x80F8330", VA = "0x1880F8F30", Slot = "4")]
	public bool JJLIAKFPGBG(DNIGIBHMBIB DNBKEKEOGAH, DNIGIBHMBIB JDKOIKLGDJK, IEnumerable<DNIGIBHMBIB> OFAMBEFDOGI, [Out] OHHIJABBFOL FDFMBGNIIME, [Out] OEDACCNNBMB LGOLHPAEGOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x80F9030", Offset = "0x80F8430", VA = "0x1880F9030", Slot = "5")]
	public string MALCJMADGHJ(OEDACCNNBMB HBGLDCCHPCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x80F9130", Offset = "0x80F8530", VA = "0x1880F9130")]
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
