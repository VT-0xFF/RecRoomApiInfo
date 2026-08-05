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
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D81040", Offset = "0x8D7F640", VA = "0x188D81040")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC0AA0", Offset = "0xABF0A0", VA = "0x180AC0AA0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC0AE0", Offset = "0xABF0E0", VA = "0x180AC0AE0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum GIBIDBOGOFD
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
		[Cpp2IlInjected.Address(RVA = "0x8D81850", Offset = "0x8D7FE50", VA = "0x188D81850", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2960290", Offset = "0x295E890", VA = "0x182960290")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void EGHMEMDDAFD<TPermission>(TPermission MOEBMMOEFPE);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void HJOHMBEPFIM(NGPBJJLAELK LIOICDJHFAF);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum ACJJPIKDADM
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface AJPCIMDNCNB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool PEDOMNBFGKO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool NJGGMPPGHMG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool OMHJLFMOPBA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool CIOEJPJONCI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool MIGFFOEBDOA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool FFOLKNLKBPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool MDFKODNBILG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class MOBAACNFPLH
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum MACDLODOCFN
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
	public static readonly Guid IIPBNGJBDOK;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid HMPPGDPHEKO;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid CGHIOLOGGBB;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid PHGDBLMLIFA;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid NKCPGEKPKPE;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid EAHHDDIPNPM;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly PBOAKLMBFMM<JPDHCCGLEHO, Guid> ICCKHNMKNLF;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	internal static IEnumerable<JPDHCCGLEHO> OMJDPOJKCHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8D80B70", Offset = "0x8D7F170", VA = "0x188D80B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8D80BF0", Offset = "0x8D7F1F0", VA = "0x188D80BF0")]
	public static JPDHCCGLEHO NEDOJKJJDFA(Guid CLPJLOJHBDJ)
	{
		return default(JPDHCCGLEHO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8D80910", Offset = "0x8D7EF10", VA = "0x188D80910")]
	public static Guid BOGGEMIAKMA(JPDHCCGLEHO DOKHFDLMEOG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8D809F0", Offset = "0x8D7EFF0", VA = "0x188D809F0")]
	public static bool GKBMJLOIOOB(JPDHCCGLEHO DOKHFDLMEOG, [Out] Guid CLPJLOJHBDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8D80C80", Offset = "0x8D7F280", VA = "0x188D80C80")]
	public static bool OPGKDHJLALO(Guid CLPJLOJHBDJ, [Out] JPDHCCGLEHO DOKHFDLMEOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8D80A80", Offset = "0x8D7F080", VA = "0x188D80A80")]
	public static JPDHCCGLEHO HAKMFAKINDA(JPDHCCGLEHO DOKHFDLMEOG)
	{
		return default(JPDHCCGLEHO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8D80AC0", Offset = "0x8D7F0C0", VA = "0x188D80AC0")]
	public static MACDLODOCFN HINODGPPBBC(JPDHCCGLEHO ANFBGALMJCN)
	{
		return default(MACDLODOCFN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8D809B0", Offset = "0x8D7EFB0", VA = "0x188D809B0")]
	internal static JPDHCCGLEHO DJDGKIJBNBK(MACDLODOCFN HLIFDJEJKHN)
	{
		return default(JPDHCCGLEHO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GCNCGAKOGMP
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	NGPBJJLAELK OAPPNOICBCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	GBKNNIMJDGO DIKAKBLBMOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	NLKJFHIHAMP GFGKIKDNFGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<GLBFFBKOOOM> ACOIIDKFPAJ;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action BLABMALFBOL;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JPDHCCGLEHO OCAGNEJGKKJ(NGPBJJLAELK LIOICDJHFAF);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<GLBFFBKOOOM> JIJNDHLIEPB(CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task GDMEBBHNEMJ(long PANGCFBNCCJ, IReadOnlyList<NPKHPNNGNKK> OENKDPDKIGM);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task EAAAAJDDPFN(long PANGCFBNCCJ, long IAKLDDCBNEB, IReadOnlyList<NPKHPNNGNKK> OENKDPDKIGM);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<NGPBJJLAELK> EHAKHOPNELM();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class MAGKAADLAGP
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8D808B0", Offset = "0x8D7EEB0", VA = "0x188D808B0")]
	public static JPDHCCGLEHO IBKPEJJPFEE(this GCNCGAKOGMP AKNMMENCDMJ)
	{
		return default(JPDHCCGLEHO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface LNIJLFCEGAD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	ENBHIGLKMGL PMHNGAKNHJA
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event HJOHMBEPFIM FPFPLPLLIJL;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<AMAEGEBAMFF> NDCIDKHCBGI(bool KPOLNELBFBD = false);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AMAEGEBAMFF EMJCACMOGJO(NGPBJJLAELK LIOICDJHFAF);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool CCBLEOCJGMP(NGPBJJLAELK LIOICDJHFAF);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IReadOnlyList<AMAEGEBAMFF> DFAEOPKEICB(NGPBJJLAELK LIOICDJHFAF, bool DODGMKANJLO = false);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool EMFFGMPAIEH(NGPBJJLAELK EFPIMDKGMCA, JPDHCCGLEHO DOKHFDLMEOG);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "8")]
	AMAEGEBAMFF EPINAFAJKFF(JPDHCCGLEHO DOKHFDLMEOG);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool INELJMAMPDH<T>(JPDHCCGLEHO DOKHFDLMEOG, KMKJDHGACLG MOEBMMOEFPE, bool LIIFGNOLJKD, T HOOMHDKIGBG, [Optional] Action DPDCGPOJBOO) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string PPAEBEKJKFL(KMKJDHGACLG MOEBMMOEFPE);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CBLGDJPEKIM(NGPBJJLAELK LIOICDJHFAF, KMKJDHGACLG NMNPMBAPOME);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface HMOPHJJDAMI
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task GACGOGFLEND(CIMPCCNCPLH CPLJEEOPGOB, CancellationToken MEKNAIONNND);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface DFOPLEKANGL<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string FIJEEKJLFGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event EGHMEMDDAFD<TPermission> IILEKAGCGEM;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal abstract class GMBACMDPGIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal object? CHEMNAHNMJI;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? KBKEKDCCKLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8D7FF20", Offset = "0x8D7E520", VA = "0x188D7FF20")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8D80000", Offset = "0x8D7E600", VA = "0x188D80000")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8D80100", Offset = "0x8D7E700", VA = "0x188D80100")]
	protected GMBACMDPGIE(object? DEKAMNIJJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool FGHCPBDJEOJ(object? FKMNCAKIOFK);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class JEPDJJCDPJJ<T> : GMBACMDPGIE where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> NBPCHKHLAIB;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T FAGODIAEODP
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x54AFF80", Offset = "0x54AE580", VA = "0x1854AFF80")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x54AF650", Offset = "0x54ADC50", VA = "0x1854AF650", Slot = "4")]
	public override bool FGHCPBDJEOJ(object? FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x54AFD40", Offset = "0x54AE340", VA = "0x1854AFD40")]
	public bool FMEHHNDFCGE(T JHNEKALOKLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x54B0540", Offset = "0x54AEB40", VA = "0x1854B0540")]
	public JEPDJJCDPJJ(T DAKPJNHJLJO, IEqualityComparer<T> NBPCHKHLAIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class BCALIFCJDBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<KMKJDHGACLG, bool> DMAIBGPJMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<KMKJDHGACLG, GMBACMDPGIE> JEPOPEAJAAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly BODOPHCIPCG KBEIJBPFPGE;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8D794B0", Offset = "0x8D77AB0", VA = "0x188D794B0")]
	public BCALIFCJDBG(BODOPHCIPCG KBEIJBPFPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8D78FD0", Offset = "0x8D775D0", VA = "0x188D78FD0")]
	public bool MMNHGDGDGJB(KMKJDHGACLG MOEBMMOEFPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3B0DB00", Offset = "0x3B0C100", VA = "0x183B0DB00")]
	public bool PHEBGGLLHHI<T>(KMKJDHGACLG MOEBMMOEFPE, bool LIIFGNOLJKD, T FKMNCAKIOFK) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3B0D730", Offset = "0x3B0BD30", VA = "0x183B0D730")]
	public (bool, T?) MPDFMCLLHDA<T>(KMKJDHGACLG MOEBMMOEFPE) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8D791E0", Offset = "0x8D777E0", VA = "0x188D791E0")]
	public bool PHEBGGLLHHI(KMKJDHGACLG MOEBMMOEFPE, bool LIIFGNOLJKD, object FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8D79040", Offset = "0x8D77640", VA = "0x188D79040")]
	public (bool, object) MPDFMCLLHDA(KMKJDHGACLG MOEBMMOEFPE)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3B0D6F0", Offset = "0x3B0BCF0", VA = "0x183B0D6F0")]
	private void DIHFFBCNOJI<T>(KMKJDHGACLG MOEBMMOEFPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8D78F00", Offset = "0x8D77500", VA = "0x188D78F00")]
	private GMBACMDPGIE BELEMNKGMIG(KMKJDHGACLG MOEBMMOEFPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8D792C0", Offset = "0x8D778C0", VA = "0x188D792C0")]
	public void PMNOBFOFFPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class LJDKHJNEEIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string KOEPNMMBJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type KLOACCAIFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly LMJJCBOBFIJ DDECCEAILDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly KMKJDHGACLG CAGPDIHMBKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public BALENHBOHHL BNMFOLAAIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public KGMOODJMHJC ACNCMCADDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public KLACNJOFKGH LDEAOKDCNNK;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8D80810", Offset = "0x8D7EE10", VA = "0x188D80810")]
	public LJDKHJNEEIO(Type CFPOINAPPLD, string PGGAFHEJNAP, KMKJDHGACLG MOEBMMOEFPE, BALENHBOHHL AJOAIDPOKOP, KGMOODJMHJC HHADPLFOGJM, KLACNJOFKGH DPDDMLDKFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8D80710", Offset = "0x8D7ED10", VA = "0x188D80710")]
	public object CADHFBEMKME(object? IBCMCOKAJEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3E81550", Offset = "0x3E7FB50", VA = "0x183E81550")]
	public void DIHFFBCNOJI<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8D80760", Offset = "0x8D7ED60", VA = "0x188D80760")]
	public void DIHFFBCNOJI(Type IAEJEEEHOBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class HMOMHHMMOIA<T> : LJDKHJNEEIO where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate string KCEPEAJANNL(T FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal delegate T MEKPIIDOMLC(string? GLLOEKCBGDF, T DAKPJNHJLJO);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class OBOGFPMGPII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public KCEPEAJANNL serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public MEKPIIDOMLC parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public OBOGFPMGPII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5B3A820", Offset = "0x5B38E20", VA = "0x185B3A820")]
		internal string KHGBLAEHIPK(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5B3A670", Offset = "0x5B38C70", VA = "0x185B3A670")]
		internal object DEMBJFOIDOM(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x51406C0", Offset = "0x513ECC0", VA = "0x1851406C0")]
	public HMOMHHMMOIA(KMKJDHGACLG MOEBMMOEFPE, string PGGAFHEJNAP, [Optional] KCEPEAJANNL? AJOAIDPOKOP, [Optional] MEKPIIDOMLC? HHADPLFOGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x51403B0", Offset = "0x513E9B0", VA = "0x1851403B0")]
	private static object? KJBCLIOBDIC(MEKPIIDOMLC? HHADPLFOGJM, string? GLLOEKCBGDF, object? DAKPJNHJLJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x513F860", Offset = "0x513DE60", VA = "0x18513F860")]
	private static string CAELEDFILEL(KCEPEAJANNL? LDCLLLNHPDC, object? FKMNCAKIOFK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate string BALENHBOHHL(object? FKMNCAKIOFK);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate object KGMOODJMHJC(string? GLLOEKCBGDF, [Optional] object DAKPJNHJLJO);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal delegate GMBACMDPGIE KLACNJOFKGH();
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class BODOPHCIPCG
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class CNADEBDBJDD : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static CNADEBDBJDD DOBPPELCKJD;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8D7B420", Offset = "0x8D79A20", VA = "0x188D7B420", Slot = "4")]
		public bool Equals(List<string> POMPNNDHCKO, List<string> JLAHKMCOIFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8D7B570", Offset = "0x8D79B70", VA = "0x188D7B570", Slot = "5")]
		public int GetHashCode(List<string> NDBJJGOPOFO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public CNADEBDBJDD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class JEGALALCABM : NEDJEPGLGDE<GIBIDBOGOFD>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8D805E0", Offset = "0x8D7EBE0", VA = "0x188D805E0", Slot = "9")]
		public override string CAELEDFILEL(GIBIDBOGOFD EKNLPIEMHNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8D80410", Offset = "0x8D7EA10", VA = "0x188D80410", Slot = "10")]
		protected override bool AGNKKGCJGPC(string EKNLPIEMHNC, [Out] GIBIDBOGOFD FKMNCAKIOFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8D806D0", Offset = "0x8D7ECD0", VA = "0x188D806D0")]
		public JEGALALCABM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly BGKHPJFPHCI JCGFIDKJCDE;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly JEGALALCABM OAHGPJCHGKK;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<LJDKHJNEEIO> CFOFPIABBBD;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<KMKJDHGACLG> LNEJAAOMCDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<KMKJDHGACLG, LJDKHJNEEIO> GDLMFLAFDEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8D7B010", Offset = "0x8D79610", VA = "0x188D7B010")]
	public BODOPHCIPCG([Optional] IList<LJDKHJNEEIO>? BDIEFMCADGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8D79A70", Offset = "0x8D78070", VA = "0x188D79A70")]
	public LJDKHJNEEIO OIMPFPAKKAN(KMKJDHGACLG MOEBMMOEFPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface ENBHIGLKMGL
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	AMAEGEBAMFF HCOJOFHLDJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class EAOGIMJFNBN : ENBHIGLKMGL
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static EAOGIMJFNBN LIAKGJNDIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly DJLIEOJMJIO DKFCNFGNDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<DJLIEOJMJIO> MFEKAKHNJML;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public AMAEGEBAMFF HCOJOFHLDJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8D7EA30", Offset = "0x8D7D030", VA = "0x188D7EA30")]
	public EAOGIMJFNBN(DJLIEOJMJIO ABJBELELKHB, IReadOnlyList<DJLIEOJMJIO> OJJKPJCNCGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8D7DAE0", Offset = "0x8D7C0E0", VA = "0x188D7DAE0")]
	private static EAOGIMJFNBN LMLIEBODOAL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class BMJGEDFOHMI
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<JPDHCCGLEHO> ELBJDFPCBOL;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8D797E0", Offset = "0x8D77DE0", VA = "0x188D797E0")]
	public static bool IDOFHMBONGP(this NGPBJJLAELK NCBFFONBEHD, JPDHCCGLEHO DOKHFDLMEOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8D79760", Offset = "0x8D77D60", VA = "0x188D79760")]
	public static bool HMLNOLHFMPD(this NGPBJJLAELK NCBFFONBEHD, JPDHCCGLEHO DOKHFDLMEOG, NLKJFHIHAMP NDMBGIOHICG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface GGCMIOGPNEK
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	IReadOnlyList<string> IHBECGKIAIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	GIBIDBOGOFD OCKIMBEPCIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface AMAEGEBAMFF : GGCMIOGPNEK, AJPCIMDNCNB, DFOPLEKANGL<KMKJDHGACLG>
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	string KICAIDMJBMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	JPDHCCGLEHO KOEIGMCFGIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) JCDMAICCCOE<T>(KMKJDHGACLG MOEBMMOEFPE) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal class DJLIEOJMJIO : AMAEGEBAMFF, GGCMIOGPNEK, AJPCIMDNCNB, DFOPLEKANGL<KMKJDHGACLG>
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal static readonly BODOPHCIPCG HPOCEPJJJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal readonly BCALIFCJDBG AOIJHBKCIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private string? DOCNOHALANK;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private bool NICAMLJDIJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8D7BEE0", Offset = "0x8D7A4E0", VA = "0x188D7BEE0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool MOJDHBMILFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8D7C4A0", Offset = "0x8D7AAA0", VA = "0x188D7C4A0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool EGBMGDGCNHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8D7C5D0", Offset = "0x8D7ABD0", VA = "0x188D7C5D0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool CDDGDGDFIPG
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8D7BF30", Offset = "0x8D7A530", VA = "0x188D7BF30", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool MLENCIELEMP
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8D7C620", Offset = "0x8D7AC20", VA = "0x188D7C620", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool AGNBBCAPIAL
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8D7C350", Offset = "0x8D7A950", VA = "0x188D7C350", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private bool KLGGPAEPGKL
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8D7C4F0", Offset = "0x8D7AAF0", VA = "0x188D7C4F0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public JPDHCCGLEHO KOEIGMCFGIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xAEAC60", Offset = "0xAE9260", VA = "0x180AEAC60", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(JPDHCCGLEHO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xAA0590", Offset = "0xA9EB90", VA = "0x180AA0590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public string FIJEEKJLFGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8D7D720", Offset = "0x8D7BD20", VA = "0x188D7D720", Slot = "18")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public string KICAIDMJBMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8D7D720", Offset = "0x8D7BD20", VA = "0x188D7D720", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool NNNFCJCDHHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xAC3630", Offset = "0xAC1C30", VA = "0x180AC3630")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xAC33B0", Offset = "0xAC19B0", VA = "0x180AC33B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public GIBIDBOGOFD OCKIMBEPCIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8D7C400", Offset = "0x8D7AA00", VA = "0x188D7C400", Slot = "8")]
		get
		{
			return default(GIBIDBOGOFD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public IReadOnlyList<string> IHBECGKIAIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8D7C3A0", Offset = "0x8D7A9A0", VA = "0x188D7C3A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool BPBELDCDHMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8D7BEE0", Offset = "0x8D7A4E0", VA = "0x188D7BEE0", Slot = "19")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool OACAOPGAGBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8D7C620", Offset = "0x8D7AC20", VA = "0x188D7C620", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool EKGJFCGCIMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8D7C4A0", Offset = "0x8D7AAA0", VA = "0x188D7C4A0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool OFJBPJJHMIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8D7C5D0", Offset = "0x8D7ABD0", VA = "0x188D7C5D0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool KBJMBOAMIDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8D7BF30", Offset = "0x8D7A530", VA = "0x188D7BF30", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool IOFOIHLMPLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8D7C350", Offset = "0x8D7A950", VA = "0x188D7C350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool CONLJFDAGAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8D7C4F0", Offset = "0x8D7AAF0", VA = "0x188D7C4F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event EGHMEMDDAFD<KMKJDHGACLG> IILEKAGCGEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8D7D770", Offset = "0x8D7BD70", VA = "0x188D7D770", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8D7BE30", Offset = "0x8D7A430", VA = "0x188D7BE30", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3BE4140", Offset = "0x3BE2740", VA = "0x183BE4140", Slot = "6")]
	public (bool, T?) JCDMAICCCOE<T>(KMKJDHGACLG MOEBMMOEFPE) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3BE42D0", Offset = "0x3BE28D0", VA = "0x183BE42D0")]
	public DJLIEOJMJIO KOEECOHHDID<T>(KMKJDHGACLG MOEBMMOEFPE, bool LIIFGNOLJKD, T FKMNCAKIOFK) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8D7DAC0", Offset = "0x8D7C0C0", VA = "0x188D7DAC0")]
	public DJLIEOJMJIO(JPDHCCGLEHO DOKHFDLMEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8D7D960", Offset = "0x8D7BF60", VA = "0x188D7D960")]
	public DJLIEOJMJIO(JPDHCCGLEHO DOKHFDLMEOG, [Optional] string? DOCNOHALANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8D7D8D0", Offset = "0x8D7BED0", VA = "0x188D7D8D0")]
	public DJLIEOJMJIO(DJLIEOJMJIO NJDAABHHEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8D7D980", Offset = "0x8D7BF80", VA = "0x188D7D980")]
	internal DJLIEOJMJIO(JPDHCCGLEHO LLJPOLHCCON, [Optional] string? DOCNOHALANK, [Optional] DJLIEOJMJIO? NJDAABHHEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8D7CD40", Offset = "0x8D7B340", VA = "0x188D7CD40")]
	public static LMJJCBOBFIJ LAMGKNJKOGJ(KMKJDHGACLG MOEBMMOEFPE)
	{
		return default(LMJJCBOBFIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8D7D820", Offset = "0x8D7BE20", VA = "0x188D7D820")]
	public void PMNOBFOFFPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8D7CA50", Offset = "0x8D7B050", VA = "0x188D7CA50")]
	internal DJLIEOJMJIO JFFNDLKEBBJ(DJLIEOJMJIO EKODAGFBPPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8D7BF80", Offset = "0x8D7A580", VA = "0x188D7BF80")]
	internal IReadOnlyCollection<KMKJDHGACLG> CCEONOOKKGH(DJLIEOJMJIO NJDAABHHEKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8D7C770", Offset = "0x8D7AD70", VA = "0x188D7C770")]
	public bool IBMFGMFJEKN(KMKJDHGACLG MOEBMMOEFPE, bool LIIFGNOLJKD, string LGDJPHAGOFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8D7C670", Offset = "0x8D7AC70", VA = "0x188D7C670")]
	public (bool, string) GILAJCHAPKO(KMKJDHGACLG MOEBMMOEFPE)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8D7C450", Offset = "0x8D7AA50", VA = "0x188D7C450")]
	internal void DPIGOMLHPNA(KMKJDHGACLG MOEBMMOEFPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8D7C850", Offset = "0x8D7AE50", VA = "0x188D7C850")]
	public GILPKIGNCBK IDKDEINKDAK(Func<JPDHCCGLEHO, Guid> IPFEAHHPMFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8D7CDC0", Offset = "0x8D7B3C0", VA = "0x188D7CDC0")]
	public void MDMOFODGHIM(GILPKIGNCBK BKOCCHPEIOH, Func<Guid, JPDHCCGLEHO> MCCAKPJJIAG, [Optional] JPDHCCGLEHO? BMPDIIEHAIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8D7C540", Offset = "0x8D7AB40", VA = "0x188D7C540")]
	[CompilerGenerated]
	private void FMNBMEJGNNE(KMKJDHGACLG NMNPMBAPOME, BMLEHHHJHBL HLMIFOBGDJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class APEHDDGIENC : HMOPHJJDAMI, LNIJLFCEGAD, IDisposable, INCAMEIFDNK
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class CCGJKOINIFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public DJLIEOJMJIO newRole;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public CCGJKOINIFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8D7B360", Offset = "0x8D79960", VA = "0x188D7B360")]
		internal bool PBHHKLHGBGM(DJLIEOJMJIO rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class AMOGPOJNLGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public JPDHCCGLEHO roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public AMOGPOJNLGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x1F2EF60", Offset = "0x1F2D560", VA = "0x181F2EF60")]
		internal bool EOOLBPNHCFD(JPDHCCGLEHO r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct DFMOOKOCLGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public APEHDDGIENC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public CIMPCCNCPLH roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private TaskAwaiter<GLBFFBKOOOM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8D7B760", Offset = "0x8D79D60", VA = "0x188D7B760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8D7BDD0", Offset = "0x8D7A3D0", VA = "0x188D7BDD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class HKOJOBIHCPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public HKOJOBIHCPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8D80330", Offset = "0x8D7E930", VA = "0x188D80330")]
		internal void LGPEKLHKMDE(GILPKIGNCBK r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8D80210", Offset = "0x8D7E810", VA = "0x188D80210")]
		internal void DJAFFMINIAA(GILPKIGNCBK r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct NMLOHLGKBHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public CIMPCCNCPLH roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class CLJHDPPMCGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Func<GILPKIGNCBK, BMLEHHHJHBL> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public CLJHDPPMCGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8D7B390", Offset = "0x8D79990", VA = "0x188D7B390")]
		internal void JKLPIINDMFO(GILPKIGNCBK r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8D7B3F0", Offset = "0x8D799F0", VA = "0x188D7B3F0")]
		internal void MHDANIDCPKD(GILPKIGNCBK r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8D7B3C0", Offset = "0x8D799C0", VA = "0x188D7B3C0")]
		internal void LFKDEMBFGGN(GILPKIGNCBK r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class OJLLBHJOCPC<T> where T : notnull
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
			public OJLLBHJOCPC<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private TaskAwaiter<GLBFFBKOOOM> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x45436B0", Offset = "0x4541CB0", VA = "0x1845436B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xAE2D00", Offset = "0xAE1300", VA = "0x180AE2D00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public KMKJDHGACLG rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public JPDHCCGLEHO accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public LMJJCBOBFIJ recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public APEHDDGIENC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public OJLLBHJOCPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5B6F1D0", Offset = "0x5B6D7D0", VA = "0x185B6F1D0")]
		[AsyncStateMachine(typeof(OJLLBHJOCPC<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void POJHPLEHGEJ()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct DBIAKPMDEBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public IReadOnlyList<NPKHPNNGNKK> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct GKHFGCPPLPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public GCNCGAKOGMP rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public CIMPCCNCPLH roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public IReadOnlyDictionary<JPDHCCGLEHO, DJLIEOJMJIO> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public DKGIANPHICG debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8D7F3A0", Offset = "0x8D7D9A0", VA = "0x188D7F3A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8D7FEC0", Offset = "0x8D7E4C0", VA = "0x188D7FEC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[DependsOn]
	private readonly GCNCGAKOGMP AKNMMENCDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[DependsOn]
	private readonly EAOGIMJFNBN OJNIHMNAFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[DependsOn]
	private readonly DKGIANPHICG MCCAGOGFMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private KLENIAELIFN? MDGAIIPGCCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly Dictionary<int, JPDHCCGLEHO> HHHAMHFGCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly Dictionary<JPDHCCGLEHO, DJLIEOJMJIO> HLLPLNHOCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal readonly Dictionary<JPDHCCGLEHO, DJLIEOJMJIO> HJBAILOAPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal readonly Dictionary<JPDHCCGLEHO, DJLIEOJMJIO> JGCOELJFMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal readonly List<DJLIEOJMJIO> OIFDCIGJJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool MEEBOIOLLLB;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private static readonly KMKJDHGACLG[] NAEEEKOKODD;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public ENBHIGLKMGL PMHNGAKNHJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event HJOHMBEPFIM FPFPLPLLIJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8D78920", Offset = "0x8D76F20", VA = "0x188D78920", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8D76EE0", Offset = "0x8D754E0", VA = "0x188D76EE0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x8D74FA0", Offset = "0x8D735A0", VA = "0x188D74FA0")]
	[LAFCEDCMNGK.BFGJFLBGMGB]
	internal static void EBJPFNJLIPM(CFPMHDJNIAH MIEGGENMBMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x8D78C10", Offset = "0x8D77210", VA = "0x188D78C10")]
	[UnityEngine.Scripting.Preserve]
	internal APEHDDGIENC([OEKMEJFDAAI(null)] GCNCGAKOGMP KMGCPBBCDFO, [OEKMEJFDAAI(null)] EAOGIMJFNBN DNMNFIACHFG, [OEKMEJFDAAI(null)] DKGIANPHICG MCCAGOGFMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x8D74E90", Offset = "0x8D73490", VA = "0x188D74E90", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x8D76460", Offset = "0x8D74A60", VA = "0x188D76460")]
	private void IGFAKDBGMOH(IEnumerable<DJLIEOJMJIO> EHEKGCMFOCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x8D73A30", Offset = "0x8D72030", VA = "0x188D73A30", Slot = "10")]
	public bool CCBLEOCJGMP(NGPBJJLAELK LIOICDJHFAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x8D73800", Offset = "0x8D71E00", VA = "0x188D73800")]
	private void BLABMALFBOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x8D78740", Offset = "0x8D76D40", VA = "0x188D78740", Slot = "19")]
	public void PMLNIKNLIAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x8D78440", Offset = "0x8D76A40", VA = "0x188D78440", Slot = "8")]
	public IReadOnlyList<AMAEGEBAMFF> NDCIDKHCBGI(bool KPOLNELBFBD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8D753F0", Offset = "0x8D739F0", VA = "0x188D753F0", Slot = "9")]
	public AMAEGEBAMFF EMJCACMOGJO(NGPBJJLAELK LIOICDJHFAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8D76CD0", Offset = "0x8D752D0", VA = "0x188D76CD0")]
	private JPDHCCGLEHO ILGLJPGHBOM(NGPBJJLAELK LIOICDJHFAF)
	{
		return default(JPDHCCGLEHO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8D75320", Offset = "0x8D73920", VA = "0x188D75320", Slot = "12")]
	public bool EMFFGMPAIEH(NGPBJJLAELK EFPIMDKGMCA, JPDHCCGLEHO DOKHFDLMEOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8D75560", Offset = "0x8D73B60", VA = "0x188D75560", Slot = "13")]
	public AMAEGEBAMFF EPINAFAJKFF(JPDHCCGLEHO DOKHFDLMEOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x8D75600", Offset = "0x8D73C00", VA = "0x188D75600")]
	private static bool FLLEKEELOFG(EDPBECMNDAI KDJFMDKKHCN, JPDHCCGLEHO DOKHFDLMEOG, [Out] GILPKIGNCBK? DHHHDMIKDGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x8D760E0", Offset = "0x8D746E0", VA = "0x188D760E0")]
	private static void HOOEIAEGKPN(EDPBECMNDAI KDJFMDKKHCN, Action<GILPKIGNCBK> LOHCNDDGIPM, JPDHCCGLEHO LOKPFBMLABG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x8D761D0", Offset = "0x8D747D0", VA = "0x188D761D0")]
	private static void HOOEIAEGKPN(EDPBECMNDAI KDJFMDKKHCN, Action<GILPKIGNCBK> LOHCNDDGIPM, Predicate<JPDHCCGLEHO> DJCHHFGKKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8D76F80", Offset = "0x8D75580", VA = "0x188D76F80")]
	private void LLHILNMMJNB(NGPBJJLAELK LIOICDJHFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8D75930", Offset = "0x8D73F30", VA = "0x188D75930", Slot = "4")]
	[AsyncStateMachine(typeof(DFMOOKOCLGH))]
	public Task GACGOGFLEND([CanBeNull] CIMPCCNCPLH CPLJEEOPGOB, CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8D75A50", Offset = "0x8D74050", VA = "0x188D75A50")]
	private void GHCIMDOBHLA(EDPBECMNDAI BOJIIEGPFNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8D73B00", Offset = "0x8D72100", VA = "0x188D73B00")]
	internal static string CCFAHKEAOKG(GCNCGAKOGMP AKNMMENCDMJ, CIMPCCNCPLH CPLJEEOPGOB, IReadOnlyDictionary<JPDHCCGLEHO, DJLIEOJMJIO> HJBAILOAPOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8D74060", Offset = "0x8D72660", VA = "0x188D74060")]
	private static void DPIAPMCHDJM(CIMPCCNCPLH CPLJEEOPGOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x8D75D90", Offset = "0x8D74390", VA = "0x188D75D90")]
	private static void HBBDPJBFJDG(EDPBECMNDAI MPKPMPOGFOJ, IReadOnlyDictionary<JPDHCCGLEHO, DJLIEOJMJIO> HJBAILOAPOD, StringBuilder DDELFLCJJNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8D73E10", Offset = "0x8D72410", VA = "0x188D73E10")]
	private static bool CJCOELKNPEG(string MBHBHPPEGOB, [Out] Guid AGLLKJBOAOK, [Out] JPDHCCGLEHO DOKHFDLMEOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8D77CF0", Offset = "0x8D762F0", VA = "0x188D77CF0")]
	private static void NCFLGHPBIBN(CIMPCCNCPLH CPLJEEOPGOB, StringBuilder DDELFLCJJNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x32CAD80", Offset = "0x32C9380", VA = "0x1832CAD80", Slot = "14")]
	public bool INELJMAMPDH<T>(JPDHCCGLEHO DOKHFDLMEOG, KMKJDHGACLG MOEBMMOEFPE, bool LIIFGNOLJKD, T HOOMHDKIGBG, [Optional] Action DPDCGPOJBOO) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8D789C0", Offset = "0x8D76FC0", VA = "0x188D789C0", Slot = "15")]
	public string PPAEBEKJKFL(KMKJDHGACLG MOEBMMOEFPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8D73810", Offset = "0x8D71E10", VA = "0x188D73810", Slot = "16")]
	public bool CBLGDJPEKIM(NGPBJJLAELK LIOICDJHFAF, KMKJDHGACLG NMNPMBAPOME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8D73FA0", Offset = "0x8D725A0", VA = "0x188D73FA0", Slot = "18")]
	public bool DLNIHEDOKCI(EMDHJAPEHGM DOKHFDLMEOG, KMKJDHGACLG NMNPMBAPOME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8D72E60", Offset = "0x8D71460", VA = "0x188D72E60")]
	private void AFNDEFPMJLO(JPDHCCGLEHO DOKHFDLMEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8D77420", Offset = "0x8D75A20", VA = "0x188D77420")]
	private bool MAEJEDNIBBN(NGPBJJLAELK LIOICDJHFAF, JPDHCCGLEHO DOKHFDLMEOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8D77A60", Offset = "0x8D76060", VA = "0x188D77A60")]
	private DJLIEOJMJIO NBJKKDGGDKG(JPDHCCGLEHO DOKHFDLMEOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x8D784C0", Offset = "0x8D76AC0", VA = "0x188D784C0")]
	internal JPDHCCGLEHO OLDCLAKJLMI(NGPBJJLAELK LIOICDJHFAF)
	{
		return default(JPDHCCGLEHO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x8D76DA0", Offset = "0x8D753A0", VA = "0x188D76DA0")]
	private void IMACJGMFKLB(int LIOICDJHFAF, JPDHCCGLEHO AFKHFEBJPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x8D73F20", Offset = "0x8D72520", VA = "0x188D73F20", Slot = "11")]
	public IReadOnlyList<AMAEGEBAMFF> DFAEOPKEICB(NGPBJJLAELK LIOICDJHFAF, bool DODGMKANJLO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x8D73F20", Offset = "0x8D72520", VA = "0x188D73F20")]
	internal IReadOnlyList<DJLIEOJMJIO> JLEKOGJMPKC(NGPBJJLAELK LIOICDJHFAF, bool DODGMKANJLO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x8D75150", Offset = "0x8D73750", VA = "0x188D75150")]
	internal IReadOnlyList<DJLIEOJMJIO> EEMMLCKFDOC(JPDHCCGLEHO DOKHFDLMEOG, bool DODGMKANJLO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x8D73060", Offset = "0x8D71660", VA = "0x188D73060")]
	private void BAGCAKLHPJA(GLBFFBKOOOM HNPDPEBMBKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x8D77130", Offset = "0x8D75730", VA = "0x188D77130")]
	private static bool LPBNJMBEBPL(DJLIEOJMJIO GGFOJAGGHFJ, IReadOnlyDictionary<JPDHCCGLEHO, DJLIEOJMJIO> HJBAILOAPOD, [Out] IReadOnlyList<KMKJDHGACLG> FKOANOHJHDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x8D76FF0", Offset = "0x8D755F0", VA = "0x188D76FF0")]
	[AsyncStateMachine(typeof(GKHFGCPPLPJ))]
	private static Task LNCCCJGJOIO(GCNCGAKOGMP AKNMMENCDMJ, CIMPCCNCPLH CPLJEEOPGOB, IReadOnlyDictionary<JPDHCCGLEHO, DJLIEOJMJIO> HJBAILOAPOD, DKGIANPHICG MCCAGOGFMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x8D777C0", Offset = "0x8D75DC0", VA = "0x188D777C0")]
	[CompilerGenerated]
	internal static void MGGKAKELGGF(Func<GILPKIGNCBK, BMLEHHHJHBL> JBIOEMOIGCH, NMLOHLGKBHN P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x8D77440", Offset = "0x8D75A40", VA = "0x188D77440")]
	[CompilerGenerated]
	internal static bool MDOJDEJENCA(JPDHCCGLEHO DOKHFDLMEOG, KMKJDHGACLG MOEBMMOEFPE, [Out] NPKHPNNGNKK CKNAMPDGOMA, DBIAKPMDEBE P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface OPDIODIKEDC
{
	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OGAILKKIDEL(NGPBJJLAELK HNLDHPBNMBB, NGPBJJLAELK IIBPGAGMKDH, IEnumerable<NGPBJJLAELK> HEMIEAMLPBL, [Out] GIBIDBOGOFD HHJALAPEEDK, [Out] GGCIKFLGKOD FDJLNBPJDOB);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string DJOEGCKNADE(GGCIKFLGKOD DPHDCBPAJCB);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum GGCIKFLGKOD : byte
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
internal class FLBHDCNDJPI : OPDIODIKEDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly LNIJLFCEGAD CGGAMBOGIIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly CIGBGIBFCGA KAMICPBPNFL;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0xA94D60", Offset = "0xA93360", VA = "0x180A94D60")]
	[RecRoom.NoEngine.Common.Preserve]
	public FLBHDCNDJPI([OEKMEJFDAAI(null)] LNIJLFCEGAD CGGAMBOGIIO, [OEKMEJFDAAI(null)] CIGBGIBFCGA GOGGCEHDHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x8D7F260", Offset = "0x8D7D860", VA = "0x188D7F260")]
	private static AFPDAKCCPGL? NENOMGGOABH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8D7F2A0", Offset = "0x8D7D8A0", VA = "0x188D7F2A0", Slot = "4")]
	public bool OGAILKKIDEL(NGPBJJLAELK HNLDHPBNMBB, NGPBJJLAELK IIBPGAGMKDH, IEnumerable<NGPBJJLAELK> HEMIEAMLPBL, [Out] GIBIDBOGOFD HHJALAPEEDK, [Out] GGCIKFLGKOD FDJLNBPJDOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x8D7EB40", Offset = "0x8D7D140", VA = "0x188D7EB40", Slot = "5")]
	public string DJOEGCKNADE(GGCIKFLGKOD DPHDCBPAJCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x8D7EC40", Offset = "0x8D7D240", VA = "0x188D7EC40")]
	internal bool EHFLEPLEOHE(NGPBJJLAELK HNLDHPBNMBB, NGPBJJLAELK IIBPGAGMKDH, IEnumerable<NGPBJJLAELK> HEMIEAMLPBL, NLKJFHIHAMP NDMBGIOHICG, AFPDAKCCPGL? BBINOOMMPMD, [Out] GIBIDBOGOFD HHJALAPEEDK, [Out] GGCIKFLGKOD FDJLNBPJDOB)
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
