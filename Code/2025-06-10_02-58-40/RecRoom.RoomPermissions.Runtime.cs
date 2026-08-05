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
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8517A20", Offset = "0x8516C20", VA = "0x188517A20")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA2C560", Offset = "0xA2B760", VA = "0x180A2C560")]
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
		[Cpp2IlInjected.Address(RVA = "0xA2C5A0", Offset = "0xA2B7A0", VA = "0x180A2C5A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum COOGPANKMCA
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
		[Cpp2IlInjected.Address(RVA = "0x85188D0", Offset = "0x8517AD0", VA = "0x1885188D0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x274B560", Offset = "0x274A760", VA = "0x18274B560")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void EBNMIECDHCK<TPermission>(TPermission GPJEKBKINIF);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void CPLKHKAGCII(BNFABCHNBCL NLIBDKKPKLB);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum PPGIKIACJHE
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface DEFHALNAAGB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool FDKIDMCBIEG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool AJFECKDGDBF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool IDKELPOJFPH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NBGJLHBDMBP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool PHENCGGMNFM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool MKBKILNMCPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class AELHHBCMGGO
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum BCNOIGKBLJF
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
	public static readonly Guid OJJHFNAOHJE;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid NMOHGHPCFFF;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid HMMEDPJPMPJ;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid HNGBOLAPOAC;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid KOJNEGBINKO;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid JFDFCIKCCGB;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly KONHPBINCOP<OHDGGAAKGEM, Guid> OBJFILFFNMK;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<OHDGGAAKGEM> ABNKKJDGFOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8509E80", Offset = "0x8509080", VA = "0x188509E80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x850A100", Offset = "0x8509300", VA = "0x18850A100")]
	public static OHDGGAAKGEM ONPEPKKIIPC(Guid DJOIAEMCFDK)
	{
		return default(OHDGGAAKGEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8509F90", Offset = "0x8509190", VA = "0x188509F90")]
	public static Guid HODJBMPLDCI(OHDGGAAKGEM GEBDMHIFMHN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x850A030", Offset = "0x8509230", VA = "0x18850A030")]
	public static bool KCCLOPNNMGJ(OHDGGAAKGEM GEBDMHIFMHN, [Out] Guid DJOIAEMCFDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8509EF0", Offset = "0x85090F0", VA = "0x188509EF0")]
	public static bool HHHPNOBLAHL(Guid DJOIAEMCFDK, [Out] OHDGGAAKGEM GEBDMHIFMHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8509D90", Offset = "0x8508F90", VA = "0x188509D90")]
	public static OHDGGAAKGEM FICBFOLNDML(OHDGGAAKGEM GEBDMHIFMHN)
	{
		return default(OHDGGAAKGEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8509DD0", Offset = "0x8508FD0", VA = "0x188509DD0")]
	public static BCNOIGKBLJF FIPJNIOMALN(OHDGGAAKGEM POHHENPOHAE)
	{
		return default(BCNOIGKBLJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x850A0C0", Offset = "0x85092C0", VA = "0x18850A0C0")]
	internal static OHDGGAAKGEM OHEIIHLLEIF(BCNOIGKBLJF EIEFLDCICLH)
	{
		return default(OHDGGAAKGEM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LMGKOEMBLFM
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	BNFABCHNBCL NDGKEBACOIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	HPLNAENGEIP JHAJBAIMNIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	EAAMLCEDMMD DJDKIBHLGJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<BFLCFDKLKDK> PEJPCDIDKLI;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action IBJLLLICPHM;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OHDGGAAKGEM HABBLJIEHNC(BNFABCHNBCL NLIBDKKPKLB);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<BFLCFDKLKDK> BOHPPMLGMNA(CancellationToken FHBCOAHILMJ);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task GNGCEKIOPII(long LADMAADOIBG, IReadOnlyList<EFLEFDNDIKP> LLNLCOGMNGB);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task FJFEAMIGEKG(long LADMAADOIBG, long JAFHDCNJHEA, IReadOnlyList<EFLEFDNDIKP> LLNLCOGMNGB);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<BNFABCHNBCL> EBLHFKMNFOI();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class JODDEOLLKBM
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x85138D0", Offset = "0x8512AD0", VA = "0x1885138D0")]
	public static OHDGGAAKGEM CFOFKHDKPAA(this LMGKOEMBLFM KGODGMNJLNI)
	{
		return default(OHDGGAAKGEM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface BILJDDOMPBG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	BLGGIHKKALL FFEMPCMDGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event CPLKHKAGCII CBHABDCHPBC;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<NCKKFFEBHDL> HIBKKNCNDMM(bool KHAOFIPEPND = false);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NCKKFFEBHDL CIALEDFHHJD(BNFABCHNBCL NLIBDKKPKLB);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KHPKIGIGEKE(BNFABCHNBCL NLIBDKKPKLB);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IReadOnlyList<NCKKFFEBHDL> HBDLKCNLGCE(BNFABCHNBCL NLIBDKKPKLB, bool MGMIDFPNKPE = false);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool FJKICAKPBMJ(BNFABCHNBCL BPBJHIIIFOA, OHDGGAAKGEM GEBDMHIFMHN);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	NCKKFFEBHDL BACMKJFBIAD(OHDGGAAKGEM GEBDMHIFMHN);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool KLLAMODPCNB<T>(OHDGGAAKGEM GEBDMHIFMHN, JFGPGKPOGDI GPJEKBKINIF, bool HCCILCHMBIE, T BNCBJIMFGHJ, [Optional] Action FPGEELIEEND) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string IGLIEGGCHNC(JFGPGKPOGDI GPJEKBKINIF);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool IDCNDFEAJGG(BNFABCHNBCL NLIBDKKPKLB, JFGPGKPOGDI FAFKOEJABAO);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface GKNBOCJCFAF
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task EOLPPLHJKJH(OJIMHFCMHLE JCFOMPGDMKN, CancellationToken FHBCOAHILMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface IJGNJHIGOHE<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string DDCLBABIIIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event EBNMIECDHCK<TPermission> BBNNFMKNGLE;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal abstract class MKOAKELOHNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal object? LDGFEDIECFD;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public object? EGPBFNEIBHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x85177A0", Offset = "0x85169A0", VA = "0x1885177A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x85176A0", Offset = "0x85168A0", VA = "0x1885176A0")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8517880", Offset = "0x8516A80", VA = "0x188517880")]
	protected MKOAKELOHNC(object? EONLJKCBMDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool PLOIEIGKCLK(object? KJIOHKMJAPE);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class CMCDPKMDENC<T> : MKOAKELOHNC where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> PFCONGNHPEJ;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public T LFLEGEJLLKE
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x67DD620", Offset = "0x67DC820", VA = "0x1867DD620")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x67DDC70", Offset = "0x67DCE70", VA = "0x1867DDC70", Slot = "4")]
	public override bool PLOIEIGKCLK(object? KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x67DD7F0", Offset = "0x67DC9F0", VA = "0x1867DD7F0")]
	public bool OPIIDIMLCCI(T HCIIINHIAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x67DE130", Offset = "0x67DD330", VA = "0x1867DE130")]
	public CMCDPKMDENC(T FEOJADDJKIL, IEqualityComparer<T> PFCONGNHPEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class DDHLBNDFOAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<JFGPGKPOGDI, bool> HFEBOFMLHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<JFGPGKPOGDI, MKOAKELOHNC> EJBEBNPHMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly LOIBMCHCKHD GCLDDLJGPNM;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x850B2D0", Offset = "0x850A4D0", VA = "0x18850B2D0")]
	public DDHLBNDFOAB(LOIBMCHCKHD GCLDDLJGPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x850B0C0", Offset = "0x850A2C0", VA = "0x18850B0C0")]
	public bool OABEMIEDAJE(JFGPGKPOGDI GPJEKBKINIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3853A50", Offset = "0x3852C50", VA = "0x183853A50")]
	public bool LLEOHNLFEFI<T>(JFGPGKPOGDI GPJEKBKINIF, bool HCCILCHMBIE, T KJIOHKMJAPE) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3853F30", Offset = "0x3853130", VA = "0x183853F30")]
	public (bool, T?) ODOIAMAJGIN<T>(JFGPGKPOGDI GPJEKBKINIF) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x850AFE0", Offset = "0x850A1E0", VA = "0x18850AFE0")]
	public bool LLEOHNLFEFI(JFGPGKPOGDI GPJEKBKINIF, bool HCCILCHMBIE, object KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x850B130", Offset = "0x850A330", VA = "0x18850B130")]
	public (bool, object) ODOIAMAJGIN(JFGPGKPOGDI GPJEKBKINIF)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3853A10", Offset = "0x3852C10", VA = "0x183853A10")]
	private void EAGCOPACGHN<T>(JFGPGKPOGDI GPJEKBKINIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x850AD10", Offset = "0x8509F10", VA = "0x18850AD10")]
	private MKOAKELOHNC FKKCFCCAPDM(JFGPGKPOGDI GPJEKBKINIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x850ADE0", Offset = "0x8509FE0", VA = "0x18850ADE0")]
	public void JFBNJJBILHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class EFJNNHDMEOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string MCPIOFNNGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type DHAKHJPAFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly NOGIFLCPDNM POMKEPJCJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly JFGPGKPOGDI BHNJNNDKHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public PJNCGFOCHHN PHEPCFBPHEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public IJIDIOMJBIO NIKAMHPACJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public LBMAMIKNMHO AHAKMLIDBMK;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x850B680", Offset = "0x850A880", VA = "0x18850B680")]
	public EFJNNHDMEOI(Type CBFPKIKDPBC, string BNIMKPGBJDA, JFGPGKPOGDI GPJEKBKINIF, PJNCGFOCHHN APPKOGLFPOP, IJIDIOMJBIO ALDBGJIBGMC, LBMAMIKNMHO JANIECNFAFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x850B630", Offset = "0x850A830", VA = "0x18850B630")]
	public object JFBLHCHJJFA(object? CMOCFNBHPLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x388C640", Offset = "0x388B840", VA = "0x18388C640")]
	public void EAGCOPACGHN<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x850B580", Offset = "0x850A780", VA = "0x18850B580")]
	public void EAGCOPACGHN(Type CILAPFNFNLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class PLGLJBAIOAO<T> : EFJNNHDMEOI where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate string IBJBDJFONDK(T KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal delegate T FHHLLOHIEEH(string? JPFBINHPMEK, T FEOJADDJKIL);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class FHPENCIEDPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public IBJBDJFONDK serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public FHHLLOHIEEH parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public FHPENCIEDPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4B37A30", Offset = "0x4B36C30", VA = "0x184B37A30")]
		internal string GDFIBKODBPE(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4B37AF0", Offset = "0x4B36CF0", VA = "0x184B37AF0")]
		internal object ONLPHOONMFA(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5705A40", Offset = "0x5704C40", VA = "0x185705A40")]
	public PLGLJBAIOAO(JFGPGKPOGDI GPJEKBKINIF, string BNIMKPGBJDA, [Optional] IBJBDJFONDK? APPKOGLFPOP, [Optional] FHHLLOHIEEH? ALDBGJIBGMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5704710", Offset = "0x5703910", VA = "0x185704710")]
	private static object? BHIBMPPAILM(FHHLLOHIEEH? ALDBGJIBGMC, string? JPFBINHPMEK, object? FEOJADDJKIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5704F40", Offset = "0x5704140", VA = "0x185704F40")]
	private static string ELKKKBEIKKA(IBJBDJFONDK? FJHABHPNENN, object? KJIOHKMJAPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate string PJNCGFOCHHN(object? KJIOHKMJAPE);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate object IJIDIOMJBIO(string? JPFBINHPMEK, [Optional] object FEOJADDJKIL);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal delegate MKOAKELOHNC LBMAMIKNMHO();
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class LOIBMCHCKHD
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class IPGFJNNMJGJ : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static IPGFJNNMJGJ AIBLJDBPKAO;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x85135A0", Offset = "0x85127A0", VA = "0x1885135A0", Slot = "4")]
		public bool Equals(List<string> HGCMPGNMMIB, List<string> PIALGICKFLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x85136F0", Offset = "0x85128F0", VA = "0x1885136F0", Slot = "5")]
		public int GetHashCode(List<string> KFMNDOMPAMC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public IPGFJNNMJGJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class GCJLHJEMKHK : AHJMEINBFAL<COOGPANKMCA>
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8512510", Offset = "0x8511710", VA = "0x188512510", Slot = "9")]
		public override string ELKKKBEIKKA(COOGPANKMCA GLMNBNPBGCG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8512600", Offset = "0x8511800", VA = "0x188512600", Slot = "10")]
		protected override bool JDGKNKDOODP(string GLMNBNPBGCG, [Out] COOGPANKMCA KJIOHKMJAPE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x85127E0", Offset = "0x85119E0", VA = "0x1885127E0")]
		public GCJLHJEMKHK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly OOLGJGOLEKG LJNAMDHDAIM;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly GCJLHJEMKHK ACGFHBHPIEE;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<EFJNNHDMEOI> FOOHALGLLFD;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<JFGPGKPOGDI> PCGFAJFHELF
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IReadOnlyDictionary<JFGPGKPOGDI, EFJNNHDMEOI> DBPHNIOAHPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8517380", Offset = "0x8516580", VA = "0x188517380")]
	public LOIBMCHCKHD([Optional] IList<EFJNNHDMEOI>? EFDFDKLLKPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8515550", Offset = "0x8514750", VA = "0x188515550")]
	public EFJNNHDMEOI GEJLMKGOGGK(JFGPGKPOGDI GPJEKBKINIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface BLGGIHKKALL
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	NCKKFFEBHDL GBKCHKLLILM
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class FIPIBCJPHLP : BLGGIHKKALL
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static FIPIBCJPHLP BEPIGIEALAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly KIGDKINOMAN GIHGFJMCEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<KIGDKINOMAN> FEDGJNOAJPL;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public NCKKFFEBHDL GBKCHKLLILM
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x850C800", Offset = "0x850BA00", VA = "0x18850C800")]
	public FIPIBCJPHLP(KIGDKINOMAN EBEDMEFJLKK, IReadOnlyList<KIGDKINOMAN> FBEMKGCJCFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x850B720", Offset = "0x850A920", VA = "0x18850B720")]
	private static FIPIBCJPHLP IPFKMOHNNHB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class ACONMFKDAMB
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<OHDGGAAKGEM> PIEALOLBBIG;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8509B10", Offset = "0x8508D10", VA = "0x188509B10")]
	public static bool PHEGLLMPADJ(this BNFABCHNBCL NKEACAOKBCJ, OHDGGAAKGEM GEBDMHIFMHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8509A90", Offset = "0x8508C90", VA = "0x188509A90")]
	public static bool LFALFKLMEOA(this BNFABCHNBCL NKEACAOKBCJ, OHDGGAAKGEM GEBDMHIFMHN, EAAMLCEDMMD GBGPPHPELPD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface FKBCMHHPGFL
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	IReadOnlyList<string> CHJCLNGDOFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	COOGPANKMCA MJFIOFDONML
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface NCKKFFEBHDL : FKBCMHHPGFL, DEFHALNAAGB, IJGNJHIGOHE<JFGPGKPOGDI>
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string GEJJIGCPCPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	OHDGGAAKGEM JEJBBEPDGBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) EJOLMLLKOPF<T>(JFGPGKPOGDI GPJEKBKINIF) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal class KIGDKINOMAN : NCKKFFEBHDL, FKBCMHHPGFL, DEFHALNAAGB, IJGNJHIGOHE<JFGPGKPOGDI>
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal static readonly LOIBMCHCKHD EOBBNBNBIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal readonly DDHLBNDFOAB NBJINMFCMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private string? DBDNCHHBNFN;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private bool OCIGPBKJJNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x85145C0", Offset = "0x85137C0", VA = "0x1885145C0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private bool GCLEOCADALG
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8513A80", Offset = "0x8512C80", VA = "0x188513A80", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool LBHMMMFMLNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8513930", Offset = "0x8512B30", VA = "0x188513930", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool POOAFNMODFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8514A50", Offset = "0x8513C50", VA = "0x188514A50", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool ELFAAJMNDFF
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x85139D0", Offset = "0x8512BD0", VA = "0x1885139D0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool OCOFIKOCCGG
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8513980", Offset = "0x8512B80", VA = "0x188513980", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public OHDGGAAKGEM JEJBBEPDGBA
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xB16990", Offset = "0xB15B90", VA = "0x180B16990", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(OHDGGAAKGEM);
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA04160", Offset = "0xA03360", VA = "0x180A04160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public string DDCLBABIIIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8514FE0", Offset = "0x85141E0", VA = "0x188514FE0", Slot = "17")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA00D60", Offset = "0x9FFF60", VA = "0x180A00D60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string GEJJIGCPCPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8514FE0", Offset = "0x85141E0", VA = "0x188514FE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool BFFCNBBMKMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA2F4A0", Offset = "0xA2E6A0", VA = "0x180A2F4A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA2F2C0", Offset = "0xA2E4C0", VA = "0x180A2F2C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public COOGPANKMCA MJFIOFDONML
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8514F20", Offset = "0x8514120", VA = "0x188514F20", Slot = "8")]
		get
		{
			return default(COOGPANKMCA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public IReadOnlyList<string> CHJCLNGDOFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8513A20", Offset = "0x8512C20", VA = "0x188513A20", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool FNJPGMPMLBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x85145C0", Offset = "0x85137C0", VA = "0x1885145C0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool PBAHADKJHAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x85139D0", Offset = "0x8512BD0", VA = "0x1885139D0", Slot = "19")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool EHDGEIMAFII
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8513A80", Offset = "0x8512C80", VA = "0x188513A80", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool FGOMCFGOFMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8513930", Offset = "0x8512B30", VA = "0x188513930", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool JHGNJHHJLML
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8514A50", Offset = "0x8513C50", VA = "0x188514A50", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool FBOFKEPHFFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8513980", Offset = "0x8512B80", VA = "0x188513980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event EBNMIECDHCK<JFGPGKPOGDI> BBNNFMKNGLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8513AD0", Offset = "0x8512CD0", VA = "0x188513AD0", Slot = "15")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8515030", Offset = "0x8514230", VA = "0x188515030", Slot = "16")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3AAE4A0", Offset = "0x3AAD6A0", VA = "0x183AAE4A0", Slot = "6")]
	public (bool, T?) EJOLMLLKOPF<T>(JFGPGKPOGDI GPJEKBKINIF) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3AAE630", Offset = "0x3AAD830", VA = "0x183AAE630")]
	public KIGDKINOMAN JAKMECIAMLG<T>(JFGPGKPOGDI GPJEKBKINIF, bool HCCILCHMBIE, T KJIOHKMJAPE) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8515530", Offset = "0x8514730", VA = "0x188515530")]
	public KIGDKINOMAN(OHDGGAAKGEM GEBDMHIFMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x85153E0", Offset = "0x85145E0", VA = "0x1885153E0")]
	public KIGDKINOMAN(OHDGGAAKGEM GEBDMHIFMHN, [Optional] string? DBDNCHHBNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8515360", Offset = "0x8514560", VA = "0x188515360")]
	public KIGDKINOMAN(KIGDKINOMAN CMGLJJHPDJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8515400", Offset = "0x8514600", VA = "0x188515400")]
	internal KIGDKINOMAN(OHDGGAAKGEM KMEICBHJKDN, [Optional] string? DBDNCHHBNFN, [Optional] KIGDKINOMAN? CMGLJJHPDJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8514F70", Offset = "0x8514170", VA = "0x188514F70")]
	public static NOGIFLCPDNM OBJMIBCCHOB(JFGPGKPOGDI GPJEKBKINIF)
	{
		return default(NOGIFLCPDNM);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x85149E0", Offset = "0x8513BE0", VA = "0x1885149E0")]
	public void JFBNJJBILHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8514C30", Offset = "0x8513E30", VA = "0x188514C30")]
	internal KIGDKINOMAN NLACJGDIPDH(KIGDKINOMAN CABHOJLINBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8514610", Offset = "0x8513810", VA = "0x188514610")]
	internal IReadOnlyCollection<JFGPGKPOGDI> IHNCJHJOAGI(KIGDKINOMAN CMGLJJHPDJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8513B80", Offset = "0x8512D80", VA = "0x188513B80")]
	public bool GEAOGNINCPE(JFGPGKPOGDI GPJEKBKINIF, bool HCCILCHMBIE, string PGOCLLOMJFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8514B30", Offset = "0x8513D30", VA = "0x188514B30")]
	public (bool, string) NECLOPMKDCD(JFGPGKPOGDI GPJEKBKINIF)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8514A00", Offset = "0x8513C00", VA = "0x188514A00")]
	internal void KODJIAMJEAI(JFGPGKPOGDI GPJEKBKINIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x85150E0", Offset = "0x85142E0", VA = "0x1885150E0")]
	public OBBALOMOLOF POBFCECIDEL(Func<OHDGGAAKGEM, Guid> GKJCNMKCFNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x8513C60", Offset = "0x8512E60", VA = "0x188513C60")]
	public void GJCGHHMJHED(OBBALOMOLOF FIDCCABPDCG, Func<Guid, OHDGGAAKGEM> PBLDNKHNMME, [Optional] OHDGGAAKGEM? KNJIGONDKKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8514AA0", Offset = "0x8513CA0", VA = "0x188514AA0")]
	[CompilerGenerated]
	private void MOHGNEMMHGI(JFGPGKPOGDI FAFKOEJABAO, KKKMHKGKLPA ECHAIPAFNMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class FOHKMCAKCAN : GKNBOCJCFAF, BILJDDOMPBG, IDisposable, AIDMPGNGJBN
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class AOPHGLFCKAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public KIGDKINOMAN newRole;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public AOPHGLFCKAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x850A480", Offset = "0x8509680", VA = "0x18850A480")]
		internal bool NBBHLHALNLB(KIGDKINOMAN rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class MEOCKAJLAOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public OHDGGAAKGEM roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public MEOCKAJLAOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x1D00CB0", Offset = "0x1CFFEB0", VA = "0x181D00CB0")]
		internal bool HLKBCHDBNKM(OHDGGAAKGEM r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct OIPOGBCECPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public FOHKMCAKCAN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public OJIMHFCMHLE roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private TaskAwaiter<BFLCFDKLKDK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8517AA0", Offset = "0x8516CA0", VA = "0x188517AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8518110", Offset = "0x8517310", VA = "0x188518110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class GLKFJHBNOKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public GLKFJHBNOKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8512940", Offset = "0x8511B40", VA = "0x188512940")]
		internal void MIFOCCCHFOI(OBBALOMOLOF r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8512820", Offset = "0x8511A20", VA = "0x188512820")]
		internal void IKPLNNOENNM(OBBALOMOLOF r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct NAOMKPHDGHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public OJIMHFCMHLE roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class MNMDDPIGMGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Func<OBBALOMOLOF, KKKMHKGKLPA> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public MNMDDPIGMGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x85179F0", Offset = "0x8516BF0", VA = "0x1885179F0")]
		internal void JPLKODJDFGB(OBBALOMOLOF r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x85179C0", Offset = "0x8516BC0", VA = "0x1885179C0")]
		internal void HPCHGKEDBEH(OBBALOMOLOF r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8517990", Offset = "0x8516B90", VA = "0x188517990")]
		internal void EJMLDBNHFCP(OBBALOMOLOF r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class HKBCAHJEPEJ<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private struct <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public HKBCAHJEPEJ<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private TaskAwaiter<BFLCFDKLKDK> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x41C80F0", Offset = "0x41C72F0", VA = "0x1841C80F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xA508E0", Offset = "0xA4FAE0", VA = "0x180A508E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public JFGPGKPOGDI rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public OHDGGAAKGEM accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NOGIFLCPDNM recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public FOHKMCAKCAN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public HKBCAHJEPEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4CAE510", Offset = "0x4CAD710", VA = "0x184CAE510")]
		[AsyncStateMachine(typeof(HKBCAHJEPEJ<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void HADKOJHFDPG()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct HBIFOFDEACH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public IReadOnlyList<EFLEFDNDIKP> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct IPDJPCLANJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public LMGKOEMBLFM rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public OJIMHFCMHLE roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public IReadOnlyDictionary<OHDGGAAKGEM, KIGDKINOMAN> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public LKKACGOMJHM debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8512A20", Offset = "0x8511C20", VA = "0x188512A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8513540", Offset = "0x8512740", VA = "0x188513540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly LMGKOEMBLFM KGODGMNJLNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly FIPIBCJPHLP MOANHNCIBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly LKKACGOMJHM AEMENHIGDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly Dictionary<int, KIGDKINOMAN> PFEIFKJBJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal readonly Dictionary<OHDGGAAKGEM, KIGDKINOMAN> FCBJBPJDPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal readonly Dictionary<OHDGGAAKGEM, KIGDKINOMAN> ADLAENKDCAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal readonly List<KIGDKINOMAN> KJKKGDONDEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool BGALBGDDFGO;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly JFGPGKPOGDI[] EOFBPHEDLAB;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public BLGGIHKKALL FFEMPCMDGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event CPLKHKAGCII CBHABDCHPBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8510F10", Offset = "0x8510110", VA = "0x188510F10", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x850F170", Offset = "0x850E370", VA = "0x18850F170", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x850D6F0", Offset = "0x850C8F0", VA = "0x18850D6F0")]
	[MGCKGAIBEHC.JIJDPEMKHNE]
	internal static void CNMFKDBOHKK(FJCFOKJAKFO CBAPLOOHOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x8512250", Offset = "0x8511450", VA = "0x188512250")]
	[UnityEngine.Scripting.Preserve]
	internal FOHKMCAKCAN([NGLIAOPBMFM(null)] LMGKOEMBLFM OGEMBAAPBJE, [NGLIAOPBMFM(null)] FIPIBCJPHLP PKIJNAHNMND, [NGLIAOPBMFM(null)] LKKACGOMJHM AEMENHIGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x850DDF0", Offset = "0x850CFF0", VA = "0x18850DDF0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x850CCF0", Offset = "0x850BEF0", VA = "0x18850CCF0")]
	private void CFIONBDOHFL(IEnumerable<KIGDKINOMAN> LAPPGPBNBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x8510E40", Offset = "0x8510040", VA = "0x188510E40", Slot = "10")]
	public bool KHPKIGIGEKE(BNFABCHNBCL NLIBDKKPKLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x8510030", Offset = "0x850F230", VA = "0x188510030")]
	private void IBJLLLICPHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x850FB10", Offset = "0x850ED10", VA = "0x18850FB10")]
	private void HJPGDCCALMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x850F500", Offset = "0x850E700", VA = "0x18850F500", Slot = "8")]
	public IReadOnlyList<NCKKFFEBHDL> HIBKKNCNDMM(bool KHAOFIPEPND = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x850D5E0", Offset = "0x850C7E0", VA = "0x18850D5E0", Slot = "9")]
	public NCKKFFEBHDL CIALEDFHHJD(BNFABCHNBCL NLIBDKKPKLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x8510FB0", Offset = "0x85101B0", VA = "0x188510FB0")]
	private OHDGGAAKGEM LKMHJLIGFAO(BNFABCHNBCL NLIBDKKPKLB)
	{
		return default(OHDGGAAKGEM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x850E4E0", Offset = "0x850D6E0", VA = "0x18850E4E0", Slot = "12")]
	public bool FJKICAKPBMJ(BNFABCHNBCL BPBJHIIIFOA, OHDGGAAKGEM GEBDMHIFMHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x850C910", Offset = "0x850BB10", VA = "0x18850C910", Slot = "13")]
	public NCKKFFEBHDL BACMKJFBIAD(OHDGGAAKGEM GEBDMHIFMHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x850FD00", Offset = "0x850EF00", VA = "0x18850FD00")]
	private static bool HPEFOOLJFID(FHNOFAGLKKD IPPFICIILIB, OHDGGAAKGEM GEBDMHIFMHN, [Out] OBBALOMOLOF? BKHKKFNDCGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x850F810", Offset = "0x850EA10", VA = "0x18850F810")]
	private static void HJELCFFHKCB(FHNOFAGLKKD IPPFICIILIB, Action<OBBALOMOLOF> PHCNLOPKBJK, OHDGGAAKGEM ECHGLHLLCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x850F580", Offset = "0x850E780", VA = "0x18850F580")]
	private static void HJELCFFHKCB(FHNOFAGLKKD IPPFICIILIB, Action<OBBALOMOLOF> PHCNLOPKBJK, Predicate<OHDGGAAKGEM> GLCNBCHCCAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x850E9A0", Offset = "0x850DBA0", VA = "0x18850E9A0")]
	private void FPLCEJNGGCG(BNFABCHNBCL NLIBDKKPKLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x850E040", Offset = "0x850D240", VA = "0x18850E040", Slot = "4")]
	[AsyncStateMachine(typeof(OIPOGBCECPH))]
	public Task EOLPPLHJKJH([CanBeNull] OJIMHFCMHLE JCFOMPGDMKN, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x850C9B0", Offset = "0x850BBB0", VA = "0x18850C9B0")]
	private void BLMBAABNGNL(FHNOFAGLKKD JONFCJFDKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x850DAE0", Offset = "0x850CCE0", VA = "0x18850DAE0")]
	internal static string DMLFBKDIBFF(LMGKOEMBLFM KGODGMNJLNI, OJIMHFCMHLE JCFOMPGDMKN, IReadOnlyDictionary<OHDGGAAKGEM, KIGDKINOMAN> FCBJBPJDPEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8511080", Offset = "0x8510280", VA = "0x188511080")]
	private static void ONDPGNMGMMF(OJIMHFCMHLE JCFOMPGDMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x850E650", Offset = "0x850D850", VA = "0x18850E650")]
	private static void FMFOFJIFIAF(FHNOFAGLKKD KPLDIODOFHC, IReadOnlyDictionary<OHDGGAAKGEM, KIGDKINOMAN> FCBJBPJDPEN, StringBuilder FBNLHFILMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8510250", Offset = "0x850F450", VA = "0x188510250")]
	private static bool JLHDGNPFILI(string PPMAOGFNCEI, [Out] Guid DBMBHBMINOO, [Out] OHDGGAAKGEM GEBDMHIFMHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x850EA30", Offset = "0x850DC30", VA = "0x18850EA30")]
	private static void GFEBBKHKNKD(OJIMHFCMHLE JCFOMPGDMKN, StringBuilder FBNLHFILMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x39F0710", Offset = "0x39EF910", VA = "0x1839F0710", Slot = "14")]
	public bool KLLAMODPCNB<T>(OHDGGAAKGEM GEBDMHIFMHN, JFGPGKPOGDI GPJEKBKINIF, bool HCCILCHMBIE, T BNCBJIMFGHJ, [Optional] Action FPGEELIEEND) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x85101E0", Offset = "0x850F3E0", VA = "0x1885101E0", Slot = "15")]
	public string IGLIEGGCHNC(JFGPGKPOGDI GPJEKBKINIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8510040", Offset = "0x850F240", VA = "0x188510040", Slot = "16")]
	public bool IDCNDFEAJGG(BNFABCHNBCL NLIBDKKPKLB, JFGPGKPOGDI FAFKOEJABAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8510130", Offset = "0x850F330", VA = "0x188510130", Slot = "18")]
	public bool IDCNDFEAJGG(int MKCPMOJFGDP, JFGPGKPOGDI FAFKOEJABAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x850F900", Offset = "0x850EB00", VA = "0x18850F900")]
	private void HJGBDAEEBLA(OHDGGAAKGEM GEBDMHIFMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x850EA10", Offset = "0x850DC10", VA = "0x18850EA10")]
	private bool GCKPDHLADPD(BNFABCHNBCL NLIBDKKPKLB, OHDGGAAKGEM GEBDMHIFMHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8510AF0", Offset = "0x850FCF0", VA = "0x188510AF0")]
	internal KIGDKINOMAN KHFAJNFBKLD(BNFABCHNBCL NLIBDKKPKLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x850F210", Offset = "0x850E410", VA = "0x18850F210", Slot = "11")]
	public IReadOnlyList<NCKKFFEBHDL> HBDLKCNLGCE(BNFABCHNBCL NLIBDKKPKLB, bool MGMIDFPNKPE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x850D8B0", Offset = "0x850CAB0", VA = "0x18850D8B0")]
	internal IReadOnlyList<KIGDKINOMAN> CPOMGPDLAJL(BNFABCHNBCL NLIBDKKPKLB, bool MGMIDFPNKPE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8510360", Offset = "0x850F560", VA = "0x188510360")]
	private void JPCKNBCEHAB(BFLCFDKLKDK GGHLELKEDKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x850F220", Offset = "0x850E420", VA = "0x18850F220")]
	private static bool HGNEHCMLGFE(KIGDKINOMAN LDCEDAGELPF, IReadOnlyDictionary<OHDGGAAKGEM, KIGDKINOMAN> FCBJBPJDPEN, [Out] IReadOnlyList<JFGPGKPOGDI> ECJMGBLPFCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x850DF00", Offset = "0x850D100", VA = "0x18850DF00")]
	[AsyncStateMachine(typeof(IPDJPCLANJA))]
	private static Task EMHCAIOJNPJ(LMGKOEMBLFM KGODGMNJLNI, OJIMHFCMHLE JCFOMPGDMKN, IReadOnlyDictionary<OHDGGAAKGEM, KIGDKINOMAN> FCBJBPJDPEN, LKKACGOMJHM AEMENHIGDPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x8511DE0", Offset = "0x8510FE0", VA = "0x188511DE0")]
	[CompilerGenerated]
	internal static void PEDKHIEHEKG(Func<OBBALOMOLOF, KKKMHKGKLPA> AMHDMLKPCOH, NAOMKPHDGHJ P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x850E160", Offset = "0x850D360", VA = "0x18850E160")]
	[CompilerGenerated]
	internal static bool FIKIIKAFABD(OHDGGAAKGEM GEBDMHIFMHN, JFGPGKPOGDI GPJEKBKINIF, [Out] EFLEFDNDIKP AAJBIDNMGFC, HBIFOFDEACH P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface JKJGNDDIAMO
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JCANJMEADPA(BNFABCHNBCL BODOMJADDBD, BNFABCHNBCL AHLECLGKJGK, IEnumerable<BNFABCHNBCL> FCJDJIEIBPA, [Out] COOGPANKMCA JKDLOMJNAKO, [Out] LLAGHNCPBHF MDEDKCEJBIN);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string DHNPLCHCFBL(LLAGHNCPBHF GFIMCFEOHOM);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum LLAGHNCPBHF : byte
{
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	CantKickEventOrganizer,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	Broadcaster,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	GameInProgress,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	OpponentGameInProgress
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class BHDLMICMGNI : JKJGNDDIAMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly BILJDDOMPBG OEBIKJKFPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly COACLPNMPEF GJFNGBGMEPN;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0xA058E0", Offset = "0xA04AE0", VA = "0x180A058E0")]
	[RecRoom.NoEngine.Common.Preserve]
	public BHDLMICMGNI([NGLIAOPBMFM(null)] BILJDDOMPBG OEBIKJKFPHD, [NGLIAOPBMFM(null)] COACLPNMPEF DCBKIKGOLOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x850ACD0", Offset = "0x8509ED0", VA = "0x18850ACD0")]
	private static JEIHLFPGMON? NLGDAGJPHCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x850ABD0", Offset = "0x8509DD0", VA = "0x18850ABD0", Slot = "4")]
	public bool JCANJMEADPA(BNFABCHNBCL BODOMJADDBD, BNFABCHNBCL AHLECLGKJGK, IEnumerable<BNFABCHNBCL> FCJDJIEIBPA, [Out] COOGPANKMCA JKDLOMJNAKO, [Out] LLAGHNCPBHF MDEDKCEJBIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x850AAD0", Offset = "0x8509CD0", VA = "0x18850AAD0", Slot = "5")]
	public string DHNPLCHCFBL(LLAGHNCPBHF GFIMCFEOHOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x850A4B0", Offset = "0x85096B0", VA = "0x18850A4B0")]
	internal bool CJKNHMOFDHE(BNFABCHNBCL BODOMJADDBD, BNFABCHNBCL AHLECLGKJGK, IEnumerable<BNFABCHNBCL> FCJDJIEIBPA, EAAMLCEDMMD GBGPPHPELPD, JEIHLFPGMON? AAGMEKEODOO, [Out] COOGPANKMCA JKDLOMJNAKO, [Out] LLAGHNCPBHF MDEDKCEJBIN)
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
