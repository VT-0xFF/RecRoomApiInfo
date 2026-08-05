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
		[Cpp2IlInjected.Address(RVA = "0x7BAB50", Offset = "0x7B9F50", VA = "0x1807BAB50")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6674EE0", Offset = "0x66742E0", VA = "0x186674EE0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7BB450", Offset = "0x7BA850", VA = "0x1807BB450")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BB490", Offset = "0x7BA890", VA = "0x1807BB490")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum BHBBMHMDNKK
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void EPONPFIKFNN<TPermission>(TPermission NACCIAENLAJ);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void LAAHEBBGJBK(LGNHMFCMNEG HGINANEPKFN);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum CKALIHOGJHI
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface DHAFDDMNBKK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MEDCOFFJBEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool BGKDFFLNPBL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool HFCMCCOCHGF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool FFHBDACANAP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool DPDKIELMCML
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool EANKMBLAEOB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class DAKJONFNBJL
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	public enum IOIPGHGCGIB
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
	public static readonly Guid MIECKPIMDJH;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid PIJDKJMEPOO;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid PODBGFHOAGJ;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid MILOCLCDHOE;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid FMGKLKLDAGL;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid AIIHEFJJLKN;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly LHDNFCLIBIN<GHGELHEJOLM, Guid> GAKOAOLDMDM;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<GHGELHEJOLM> HDLAMHACLAK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x66696F0", Offset = "0x6668AF0", VA = "0x1866696F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6669990", Offset = "0x6668D90", VA = "0x186669990")]
	public static GHGELHEJOLM OPEIHGLMNGE(Guid EFNPBHMDENF)
	{
		return default(GHGELHEJOLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6669610", Offset = "0x6668A10", VA = "0x186669610")]
	public static Guid BEDFMGCLMOP(GHGELHEJOLM PEOALELMEMH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x66698C0", Offset = "0x6668CC0", VA = "0x1866698C0")]
	public static bool JHBFNMBDGGJ(GHGELHEJOLM PEOALELMEMH, [Out] Guid EFNPBHMDENF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6669770", Offset = "0x6668B70", VA = "0x186669770")]
	public static bool FNDNGDNGOFI(Guid EFNPBHMDENF, [Out] GHGELHEJOLM PEOALELMEMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x66696B0", Offset = "0x6668AB0", VA = "0x1866696B0")]
	public static GHGELHEJOLM BPCAEDNJIFJ(GHGELHEJOLM PEOALELMEMH)
	{
		return default(GHGELHEJOLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6669810", Offset = "0x6668C10", VA = "0x186669810")]
	public static IOIPGHGCGIB GDJMCMNENHL(GHGELHEJOLM BEINOMFFMIH)
	{
		return default(IOIPGHGCGIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6669950", Offset = "0x6668D50", VA = "0x186669950")]
	internal static GHGELHEJOLM OAMLOGMFNAM(IOIPGHGCGIB DKIPAJBMLCA)
	{
		return default(GHGELHEJOLM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface JGOECHPLJEG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	MOOILEHOKGF EFMBLACMNAA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<LOBHJOHDNNP> JIBFOJAAKMD
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event LAAHEBBGJBK KIIKOKOFFEG;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<LOBHJOHDNNP> LAKPJHMODNC(bool KDECDNKNAHB = false);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LOBHJOHDNNP KHJMPEKKKKK(LGNHMFCMNEG HGINANEPKFN);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool DAMJDJEHDNG(LGNHMFCMNEG HGINANEPKFN);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<LOBHJOHDNNP> EPGLCDGJHCI(LGNHMFCMNEG HGINANEPKFN, bool BLFOEKDFIGF = false);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool ADOCFEPELGL(LGNHMFCMNEG OICNPNFOKIN, GHGELHEJOLM PEOALELMEMH);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "9")]
	LOBHJOHDNNP BGAHGDEEMNP(GHGELHEJOLM PEOALELMEMH);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool BGONOADAENP<T>(GHGELHEJOLM PEOALELMEMH, AGJDONMJMGL NACCIAENLAJ, bool BJCPCLINHHG, T NGEFMGOMMMN) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OGBBOPLMBKP
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task MKPAOOMLFPA(MOAAIJOHEOA BLCBNGIOOOL, CancellationToken HHHPDCGPCML);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KHFAILOCEBE(MOAAIJOHEOA BLCBNGIOOOL);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FNFPDJPGNEG
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	LGNHMFCMNEG HAOLPOPCPGI
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	HDAMIGLKGKM KLPAIIJOBFD
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	JNJPAGLJCJK BNHHIICHAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<HAGIHGGMDIG> LLEGCNAJAJH;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action IEEIBJKHKBJ;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GHGELHEJOLM MPPPNDFPECI(LGNHMFCMNEG HGINANEPKFN);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<HAGIHGGMDIG> NIKPPAEEFAP(CancellationToken HHHPDCGPCML);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task PAFDPLKPHHI(long JFLKHKDOLFI, long PECNCELLLNF, IReadOnlyList<INOOHLBGDJB> FENAJEBCDDO);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<LGNHMFCMNEG> IHPMPAAKPCP();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class IPPBKGFAPOE
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x666CD60", Offset = "0x666C160", VA = "0x18666CD60")]
	public static GHGELHEJOLM OFMHIBGHOIA(this FNFPDJPGNEG OKKLIEOPDIO)
	{
		return default(GHGELHEJOLM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface AEGCOMLAHJB<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string NGLPIIJPFOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event EPONPFIKFNN<TPermission> ADAECAICNDO;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class LOHKFAKCAAF
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? FJKHHAKNGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x793920", Offset = "0x792D20", VA = "0x180793920")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x793930", Offset = "0x792D30", VA = "0x180793930")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7967D0", Offset = "0x795BD0", VA = "0x1807967D0")]
	protected LOHKFAKCAAF(object? HMAMFPJKGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool CFMPBGGOLBB(object? PAHKKNONPEO);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class GCIFKEACGDG<T> : LOHKFAKCAAF where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private T PLBGBGDGKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly IEqualityComparer<T> FBMPPJGOOGF;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T BFBAIKCHJBC
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x817E60", Offset = "0x817260", VA = "0x180817E60")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3771B70", Offset = "0x3770F70", VA = "0x183771B70", Slot = "4")]
	public override bool CFMPBGGOLBB(object? PAHKKNONPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3772010", Offset = "0x3771410", VA = "0x183772010")]
	public bool NBJOEPEGJFA(T AEALFJNADDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3772290", Offset = "0x3771690", VA = "0x183772290")]
	public GCIFKEACGDG(T MINBGACMFMB, IEqualityComparer<T> FBMPPJGOOGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class EKADDOFFIGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<AGJDONMJMGL, bool> EOILCADBBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<AGJDONMJMGL, LOHKFAKCAAF> KEMOIECHILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly EBMFMHGIFFP DMGIIFIKIEC;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x666BF60", Offset = "0x666B360", VA = "0x18666BF60")]
	public EKADDOFFIGL(EBMFMHGIFFP DMGIIFIKIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x666BB40", Offset = "0x666AF40", VA = "0x18666BB40")]
	public bool CMPOOCEEMOP(AGJDONMJMGL NACCIAENLAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x24D0240", Offset = "0x24CF640", VA = "0x1824D0240")]
	public bool FBLINPPNLIP<T>(AGJDONMJMGL NACCIAENLAJ, bool BJCPCLINHHG, T PAHKKNONPEO) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x24D0750", Offset = "0x24CFB50", VA = "0x1824D0750")]
	public (bool, T?) KKLFEPNMKFA<T>(AGJDONMJMGL NACCIAENLAJ) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x666BBB0", Offset = "0x666AFB0", VA = "0x18666BBB0")]
	public bool FBLINPPNLIP(AGJDONMJMGL NACCIAENLAJ, bool BJCPCLINHHG, object PAHKKNONPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x666BE90", Offset = "0x666B290", VA = "0x18666BE90")]
	public (bool, object) KKLFEPNMKFA(AGJDONMJMGL NACCIAENLAJ)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x24D0200", Offset = "0x24CF600", VA = "0x1824D0200")]
	private void DDDJOODCHHL<T>(AGJDONMJMGL NACCIAENLAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x666BA70", Offset = "0x666AE70", VA = "0x18666BA70")]
	private LOHKFAKCAAF BBHMCOJBADJ(AGJDONMJMGL NACCIAENLAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x666BC90", Offset = "0x666B090", VA = "0x18666BC90")]
	public void IOEKINAHEDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class KGNAEAEKFKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly string HMHLPEAAEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly Type OKAFDLLCPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly MPDMDEBEGFE PBOGGGFNCIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly AGJDONMJMGL EKOIEHOIPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public FEFJMELHOJP ODLBLMGGBIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public DFCHGCHBJBH LJMANCHICFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public IIDNMHIMKOH NDPIOLKOHKG;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x666F0A0", Offset = "0x666E4A0", VA = "0x18666F0A0")]
	public KGNAEAEKFKE(Type DCJOFLDLJHI, string KCIJHFLPMLP, AGJDONMJMGL NACCIAENLAJ, FEFJMELHOJP PFKPIDMPGIM, DFCHGCHBJBH OELOHIMNIDI, IIDNMHIMKOH EHCMNEJANGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x666F050", Offset = "0x666E450", VA = "0x18666F050")]
	public object OJNAOIOLBNO(object? JLCJEDAFKJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x26A0530", Offset = "0x269F930", VA = "0x1826A0530")]
	public void DDDJOODCHHL<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x666EFA0", Offset = "0x666E3A0", VA = "0x18666EFA0")]
	public void DDDJOODCHHL(Type LKKEGKBHDFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class AAKEPCFMGAK<T> : KGNAEAEKFKE where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string HKCLOINDDOJ(T PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T PILEECGJOFI(string? CMFBOABMLLF, T MINBGACMFMB);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class LKJOCGEHMBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HKCLOINDDOJ serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public PILEECGJOFI parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public LKJOCGEHMBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3C349F0", Offset = "0x3C33DF0", VA = "0x183C349F0")]
		internal string FKOOKHGDJIJ(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3C34AC0", Offset = "0x3C33EC0", VA = "0x183C34AC0")]
		internal object PODEBBHNCDI(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x37151B0", Offset = "0x37145B0", VA = "0x1837151B0")]
	public AAKEPCFMGAK(AGJDONMJMGL NACCIAENLAJ, string KCIJHFLPMLP, [Optional] HKCLOINDDOJ? PFKPIDMPGIM, [Optional] PILEECGJOFI? OELOHIMNIDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x37146C0", Offset = "0x3713AC0", VA = "0x1837146C0")]
	private static object? BOEOGBDBLGM(PILEECGJOFI? OELOHIMNIDI, string? CMFBOABMLLF, object? MINBGACMFMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x37149C0", Offset = "0x3713DC0", VA = "0x1837149C0")]
	private static string GOGJDIDOEDD(HKCLOINDDOJ? MKDFNOKNPDI, object? PAHKKNONPEO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string FEFJMELHOJP(object? PAHKKNONPEO);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object DFCHGCHBJBH(string? CMFBOABMLLF, [Optional] object MINBGACMFMB);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate LOHKFAKCAAF IIDNMHIMKOH();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class EBMFMHGIFFP
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class OJAKFIPBENB : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal static OJAKFIPBENB OKALMGBNAPE;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6674F60", Offset = "0x6674360", VA = "0x186674F60", Slot = "4")]
		public bool Equals(List<string> FHDILOGEHPC, List<string> ICKJJDCCMFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x66750B0", Offset = "0x66744B0", VA = "0x1866750B0", Slot = "5")]
		public int GetHashCode(List<string> DFFBALIDCLL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public OJAKFIPBENB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class EICDDCJGPJP : LLMODPKLCEI<BHBBMHMDNKK>
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x666B760", Offset = "0x666AB60", VA = "0x18666B760", Slot = "9")]
		public override string GOGJDIDOEDD(BHBBMHMDNKK KJOOLMAMLNL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x666B850", Offset = "0x666AC50", VA = "0x18666B850", Slot = "10")]
		protected override bool MBPHAPLIOAP(string KJOOLMAMLNL, [Out] BHBBMHMDNKK PAHKKNONPEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x666BA30", Offset = "0x666AE30", VA = "0x18666BA30")]
		public EICDDCJGPJP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly BDEFBLJFMEA OIPCLGGFMPH;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly EICDDCJGPJP KFHPEOHMBNJ;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly List<KGNAEAEKFKE> AKPNPCJCNGC;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<AGJDONMJMGL> CLOJIGACFOK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x793920", Offset = "0x792D20", VA = "0x180793920")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<AGJDONMJMGL, KGNAEAEKFKE> GGNLIOEMAMP
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x666B410", Offset = "0x666A810", VA = "0x18666B410")]
	public EBMFMHGIFFP([Optional] IList<KGNAEAEKFKE>? ICCOKMCDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x666A5A0", Offset = "0x66699A0", VA = "0x18666A5A0")]
	public KGNAEAEKFKE HHBCDMMNKOP(AGJDONMJMGL NACCIAENLAJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface MOOILEHOKGF
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	LOBHJOHDNNP PCDEBILEECM
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class HOPKKGKBCNN : MOOILEHOKGF
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static HOPKKGKBCNN GBLKMDHOCCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly JNIADKIHMEG JGIIONJOHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal readonly IReadOnlyList<JNIADKIHMEG> BOFDFNBEKLA;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public LOBHJOHDNNP PCDEBILEECM
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x793920", Offset = "0x792D20", VA = "0x180793920", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x666CC50", Offset = "0x666C050", VA = "0x18666CC50")]
	public HOPKKGKBCNN(JNIADKIHMEG MGLDNKGLGEA, IReadOnlyList<JNIADKIHMEG> OLJKOGOLDPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x666C220", Offset = "0x666B620", VA = "0x18666C220")]
	private static HOPKKGKBCNN BMBAPCFCHEF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class MHLGGEGFHLD
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<GHGELHEJOLM> CKLHDGPBNIA;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6674C50", Offset = "0x6674050", VA = "0x186674C50")]
	public static bool EJOAFNNOEKE(this LGNHMFCMNEG NAIIGNCJJBB, GHGELHEJOLM PEOALELMEMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6674BD0", Offset = "0x6673FD0", VA = "0x186674BD0")]
	public static bool DCEIKGLAEOA(this LGNHMFCMNEG NAIIGNCJJBB, GHGELHEJOLM PEOALELMEMH, JNJPAGLJCJK LICFLEFANBD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface EFGMOPEMOPB
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool JFGFOLCCNLE
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool LPPHAKCLHEA
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool IMPECKBICFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool KJOBKBBPNGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool HBOBNNBFLPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool HJBFJNPFIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool NHBPCCMFOAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool GHHCDIDPDDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool LBHKPDLEMDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool IHECPADCNGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool MJBEGGJNDOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool HFHCNKHHBPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> NHMBGHAEODG
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	BHBBMHMDNKK JGCBNDCAEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface LOBHJOHDNNP : EFGMOPEMOPB, DHAFDDMNBKK, AEGCOMLAHJB<AGJDONMJMGL>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string KDCAMIKACJI
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	GHGELHEJOLM ICBCFNLIIFI
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) GKLIEJHPDJI<T>(AGJDONMJMGL NACCIAENLAJ) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum AGJDONMJMGL
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
internal class JNIADKIHMEG : LOBHJOHDNNP, EFGMOPEMOPB, DHAFDDMNBKK, AEGCOMLAHJB<AGJDONMJMGL>
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal static readonly EBMFMHGIFFP GDJPHFNKHBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly EKADDOFFIGL HOLIEGFMPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private string? DLFECOCFMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private string? BAALHBDEFPO;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool KHACJDAFBMH
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x666CFE0", Offset = "0x666C3E0", VA = "0x18666CFE0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool LENJEMMLMCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x666E770", Offset = "0x666DB70", VA = "0x18666E770", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool GANLEGLEIOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x666D080", Offset = "0x666C480", VA = "0x18666D080", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool NIDFAAFAPPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x666D030", Offset = "0x666C430", VA = "0x18666D030", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool KCADOJFPKGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x666DB90", Offset = "0x666CF90", VA = "0x18666DB90", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool KOOMMHPIGCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x666CE10", Offset = "0x666C210", VA = "0x18666CE10", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public GHGELHEJOLM ICBCFNLIIFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x817E60", Offset = "0x817260", VA = "0x180817E60", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(GHGELHEJOLM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x793910", Offset = "0x792D10", VA = "0x180793910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string NGLPIIJPFOP
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x666CDC0", Offset = "0x666C1C0", VA = "0x18666CDC0", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x666DAF0", Offset = "0x666CEF0", VA = "0x18666DAF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string KDCAMIKACJI
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x666CDC0", Offset = "0x666C1C0", VA = "0x18666CDC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool PKDEBCOCJAE
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x81AC50", Offset = "0x81A050", VA = "0x18081AC50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x81A3F0", Offset = "0x8197F0", VA = "0x18081A3F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool JFGFOLCCNLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x666E5D0", Offset = "0x666D9D0", VA = "0x18666E5D0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public BHBBMHMDNKK JGCBNDCAEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x666D630", Offset = "0x666CA30", VA = "0x18666D630", Slot = "20")]
		get
		{
			return default(BHBBMHMDNKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool LPPHAKCLHEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x666D5E0", Offset = "0x666C9E0", VA = "0x18666D5E0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool IMPECKBICFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x666EB90", Offset = "0x666DF90", VA = "0x18666EB90", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool KJOBKBBPNGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x666E7C0", Offset = "0x666DBC0", VA = "0x18666E7C0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool HBOBNNBFLPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x666E620", Offset = "0x666DA20", VA = "0x18666E620", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool HJBFJNPFIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x666E940", Offset = "0x666DD40", VA = "0x18666E940", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool NHBPCCMFOAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x666CE60", Offset = "0x666C260", VA = "0x18666CE60", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool GHHCDIDPDDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x666D160", Offset = "0x666C560", VA = "0x18666D160", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool LBHKPDLEMDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x666E8F0", Offset = "0x666DCF0", VA = "0x18666E8F0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> NHMBGHAEODG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x666D580", Offset = "0x666C980", VA = "0x18666D580", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool PCNMCEGIKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x666CFE0", Offset = "0x666C3E0", VA = "0x18666CFE0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool OHMEBJBHBCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x666DB90", Offset = "0x666CF90", VA = "0x18666DB90", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool PJANGDACNGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x666E770", Offset = "0x666DB70", VA = "0x18666E770", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool IHECPADCNGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x666E670", Offset = "0x666DA70", VA = "0x18666E670", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool MJBEGGJNDOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x666DB40", Offset = "0x666CF40", VA = "0x18666DB40", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool PMJGGIIFMHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x666D080", Offset = "0x666C480", VA = "0x18666D080", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool HFHCNKHHBPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x666D530", Offset = "0x666C930", VA = "0x18666D530", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool KAJHILIIFOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x666D030", Offset = "0x666C430", VA = "0x18666D030", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool DADAIOHCFBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x666CE10", Offset = "0x666C210", VA = "0x18666CE10", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event EPONPFIKFNN<AGJDONMJMGL> ADAECAICNDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x666E6C0", Offset = "0x666DAC0", VA = "0x18666E6C0", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x666CF30", Offset = "0x666C330", VA = "0x18666CF30", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x266E920", Offset = "0x266DD20", VA = "0x18266E920", Slot = "6")]
	public (bool, T?) GKLIEJHPDJI<T>(AGJDONMJMGL NACCIAENLAJ) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x266EAB0", Offset = "0x266DEB0", VA = "0x18266EAB0")]
	public JNIADKIHMEG PIADNNHFEDO<T>(AGJDONMJMGL NACCIAENLAJ, bool BJCPCLINHHG, T PAHKKNONPEO) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x666EED0", Offset = "0x666E2D0", VA = "0x18666EED0")]
	public JNIADKIHMEG(GHGELHEJOLM PEOALELMEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x666EF80", Offset = "0x666E380", VA = "0x18666EF80")]
	public JNIADKIHMEG(GHGELHEJOLM PEOALELMEMH, [Optional] string? DLFECOCFMDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x666EEF0", Offset = "0x666E2F0", VA = "0x18666EEF0")]
	public JNIADKIHMEG(JNIADKIHMEG JAHKFDBAFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x666ED70", Offset = "0x666E170", VA = "0x18666ED70")]
	internal JNIADKIHMEG(GHGELHEJOLM LJCCDCAIILA, [Optional] string? DLFECOCFMDF, [Optional] JNIADKIHMEG? JAHKFDBAFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x666CEB0", Offset = "0x666C2B0", VA = "0x18666CEB0")]
	public static MPDMDEBEGFE BHNODDIOLIJ(AGJDONMJMGL NACCIAENLAJ)
	{
		return default(MPDMDEBEGFE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x666E5B0", Offset = "0x666D9B0", VA = "0x18666E5B0")]
	public void IOEKINAHEDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x666D1B0", Offset = "0x666C5B0", VA = "0x18666D1B0")]
	internal JNIADKIHMEG DEGOGPOEOAL(JNIADKIHMEG FGKFBAADBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x666D680", Offset = "0x666CA80", VA = "0x18666D680")]
	internal IReadOnlyCollection<AGJDONMJMGL> EFBMDIDFCOL(JNIADKIHMEG JAHKFDBAFNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x666E810", Offset = "0x666DC10", VA = "0x18666E810")]
	public bool ODILAMGOPKM(AGJDONMJMGL NACCIAENLAJ, bool BJCPCLINHHG, string EDOBOGLLEMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x666EBE0", Offset = "0x666DFE0", VA = "0x18666EBE0")]
	public (bool, string) PKAMHPNEHFE(AGJDONMJMGL NACCIAENLAJ)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x666E560", Offset = "0x666D960", VA = "0x18666E560")]
	internal void HPNLCEHHJEO(AGJDONMJMGL NACCIAENLAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x666E990", Offset = "0x666DD90", VA = "0x18666E990")]
	public NJCEKHHPOMJ OPGEMKGBKCE(Func<GHGELHEJOLM, Guid> IJLOKHECMEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x666DBE0", Offset = "0x666CFE0", VA = "0x18666DBE0")]
	public void HMFFJBBBAGE(NJCEKHHPOMJ NHDFDAPFKLN, Func<Guid, GHGELHEJOLM> AAJINMIBLNJ, [Optional] GHGELHEJOLM? NJHCBHMELBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x666D0D0", Offset = "0x666C4D0", VA = "0x18666D0D0")]
	[CompilerGenerated]
	private void CAGFPNHHNLO(AGJDONMJMGL NIDGLCFKKPA, AJDFMFFAMBN FNKFJNHFCCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class LCPEFLFNPCI : OGBBOPLMBKP, JGOECHPLJEG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class PHINIPJNIKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public JNIADKIHMEG newRole;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public PHINIPJNIKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6675960", Offset = "0x6674D60", VA = "0x186675960")]
		internal bool GDCMKGBLNCO(JNIADKIHMEG rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class GNDLOHFHNND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public GHGELHEJOLM roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public GNDLOHFHNND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x666C210", Offset = "0x666B610", VA = "0x18666C210")]
		internal bool MHNPDMNDIEE(GHGELHEJOLM r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct PGGMNPMGKOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public LCPEFLFNPCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public MOAAIJOHEOA roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<HAGIHGGMDIG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x66752A0", Offset = "0x66746A0", VA = "0x1866752A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6675900", Offset = "0x6674D00", VA = "0x186675900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class AOPMINJEPFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public AOPMINJEPFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x66688A0", Offset = "0x6667CA0", VA = "0x1866688A0")]
		internal void GCKFMBKMMFF(NJCEKHHPOMJ r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6668980", Offset = "0x6667D80", VA = "0x186668980")]
		internal void LDHKIPAELCG(NJCEKHHPOMJ r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct IGFNAFDIFGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public MOAAIJOHEOA roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class POFAAACPEFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Func<NJCEKHHPOMJ, AJDFMFFAMBN> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public POFAAACPEFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x66759F0", Offset = "0x6674DF0", VA = "0x1866759F0")]
		internal void JMDFIMCCFBC(NJCEKHHPOMJ r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6675990", Offset = "0x6674D90", VA = "0x186675990")]
		internal void BHNCEKPDFLC(NJCEKHHPOMJ r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x66759C0", Offset = "0x6674DC0", VA = "0x1866759C0")]
		internal void DIAMBGLGAAH(NJCEKHHPOMJ r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class GJDMNEGJLNK<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private struct <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public GJDMNEGJLNK<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			private object <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private int <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			private TaskAwaiter<HAGIHGGMDIG> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x3061880", Offset = "0x3060C80", VA = "0x183061880", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x92DFC0", Offset = "0x92D3C0", VA = "0x18092DFC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public LCPEFLFNPCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public AGJDONMJMGL rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public GHGELHEJOLM accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public MPDMDEBEGFE recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public string serializedNewValue;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public GJDMNEGJLNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x37A5ED0", Offset = "0x37A52D0", VA = "0x1837A5ED0")]
		[AsyncStateMachine(typeof(GJDMNEGJLNK<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void PLEDDPDKHCH()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct LPPHDNLOMAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public IReadOnlyList<INOOHLBGDJB> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct CLEGMPMLGAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public FNFPDJPGNEG rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public MOAAIJOHEOA roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public IReadOnlyDictionary<GHGELHEJOLM, JNIADKIHMEG> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public ELGANHKEGLI debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6668AA0", Offset = "0x6667EA0", VA = "0x186668AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x66695B0", Offset = "0x66689B0", VA = "0x1866695B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly FNFPDJPGNEG OKKLIEOPDIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly HOPKKGKBCNN NNKCEPNHEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly ELGANHKEGLI LHMHNGNHLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, JNIADKIHMEG> LFKCBKHFAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	internal readonly Dictionary<GHGELHEJOLM, JNIADKIHMEG> LNAJFLFHDIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal readonly Dictionary<GHGELHEJOLM, JNIADKIHMEG> EOKAKFNAJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	internal readonly List<JNIADKIHMEG> CJNILAFJLAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool CKPEIMAIPDF;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly AGJDONMJMGL[] FGKGHMEMHCD;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public MOOILEHOKGF EFMBLACMNAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<LOBHJOHDNNP> JIBFOJAAKMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x66738E0", Offset = "0x6672CE0", VA = "0x1866738E0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event LAAHEBBGJBK KIIKOKOFFEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6671AF0", Offset = "0x6670EF0", VA = "0x186671AF0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6673030", Offset = "0x6672430", VA = "0x186673030", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6671420", Offset = "0x6670820", VA = "0x186671420")]
	[ABIGJEDBLLA(DFKMKBBAPPA.Room, BMBIBJGPNHE.None)]
	private static void FHPLDDBGBEB(DFNLNAANFCD LGJLCNPCMBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6674910", Offset = "0x6673D10", VA = "0x186674910")]
	[UnityEngine.Scripting.Preserve]
	internal LCPEFLFNPCI([AKCMIAONCHN(null)] FNFPDJPGNEG FLHJBMBKBAI, [AKCMIAONCHN(null)] HOPKKGKBCNN MAGNDMPEAAK, [AKCMIAONCHN(null)] ELGANHKEGLI LHMHNGNHLNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6670F00", Offset = "0x6670300", VA = "0x186670F00", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6670240", Offset = "0x666F640", VA = "0x186670240")]
	private void DAHLJPLNNDF(IEnumerable<JNIADKIHMEG> BMPJKOCLIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6670AC0", Offset = "0x666FEC0", VA = "0x186670AC0", Slot = "12")]
	public bool DAMJDJEHDNG(LGNHMFCMNEG HGINANEPKFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6671B90", Offset = "0x6670F90", VA = "0x186671B90")]
	private void IEEIBJKHKBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6672AF0", Offset = "0x6671EF0", VA = "0x186672AF0")]
	private void LJAKEPMEAPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6672A70", Offset = "0x6671E70", VA = "0x186672A70", Slot = "10")]
	public IReadOnlyList<LOBHJOHDNNP> LAKPJHMODNC(bool KDECDNKNAHB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x66728F0", Offset = "0x6671CF0", VA = "0x1866728F0", Slot = "11")]
	public LOBHJOHDNNP KHJMPEKKKKK(LGNHMFCMNEG HGINANEPKFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6670E30", Offset = "0x6670230", VA = "0x186670E30")]
	private GHGELHEJOLM DLBGNKHDPOB(LGNHMFCMNEG HGINANEPKFN)
	{
		return default(GHGELHEJOLM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x666F140", Offset = "0x666E540", VA = "0x18666F140", Slot = "14")]
	public bool ADOCFEPELGL(LGNHMFCMNEG OICNPNFOKIN, GHGELHEJOLM PEOALELMEMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x666F2D0", Offset = "0x666E6D0", VA = "0x18666F2D0", Slot = "15")]
	public LOBHJOHDNNP BGAHGDEEMNP(GHGELHEJOLM PEOALELMEMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6672020", Offset = "0x6671420", VA = "0x186672020")]
	private static bool JJILLIBEAPH(ACNGJBHLJJF FJPGMAKLFOG, GHGELHEJOLM PEOALELMEMH, [Out] NJCEKHHPOMJ? JENGIKIAMDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6673560", Offset = "0x6672960", VA = "0x186673560")]
	private static void NENFOMLDBFK(ACNGJBHLJJF FJPGMAKLFOG, Action<NJCEKHHPOMJ> HKIHGHDHIGA, GHGELHEJOLM MBMFGAABLCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6673650", Offset = "0x6672A50", VA = "0x186673650")]
	private static void NENFOMLDBFK(ACNGJBHLJJF FJPGMAKLFOG, Action<NJCEKHHPOMJ> HKIHGHDHIGA, Predicate<GHGELHEJOLM> EELPLFJPPFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6672A00", Offset = "0x6671E00", VA = "0x186672A00")]
	private void KPBKPDJIKNI(LGNHMFCMNEG HGINANEPKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6673420", Offset = "0x6672820", VA = "0x186673420", Slot = "4")]
	[AsyncStateMachine(typeof(PGGMNPMGKOH))]
	public Task MKPAOOMLFPA([CanBeNull] MOAAIJOHEOA BLCBNGIOOOL, CancellationToken HHHPDCGPCML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "5")]
	public void KHFAILOCEBE(MOAAIJOHEOA BLCBNGIOOOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6671BA0", Offset = "0x6670FA0", VA = "0x186671BA0")]
	private void IMBADJPMABK(ACNGJBHLJJF CGEJAKOPAOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x66715E0", Offset = "0x66709E0", VA = "0x1866715E0")]
	internal static string FOPMJKJEBJI(FNFPDJPGNEG OKKLIEOPDIO, MOAAIJOHEOA BLCBNGIOOOL, IReadOnlyDictionary<GHGELHEJOLM, JNIADKIHMEG> LNAJFLFHDIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6673930", Offset = "0x6672D30", VA = "0x186673930")]
	private static void PFFJPPOKPEL(MOAAIJOHEOA BLCBNGIOOOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x66730D0", Offset = "0x66724D0", VA = "0x1866730D0")]
	private static void MHMOPHHJAFC(ACNGJBHLJJF JLGMPJNMGEF, IReadOnlyDictionary<GHGELHEJOLM, JNIADKIHMEG> LNAJFLFHDIJ, StringBuilder GEAIJHHJFKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6671310", Offset = "0x6670710", VA = "0x186671310")]
	private static bool FGDEOACCOMH(string EGAGMEDODGN, [Out] Guid MOGBAKNEHKF, [Out] GHGELHEJOLM PEOALELMEMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x666F370", Offset = "0x666E770", VA = "0x18666F370")]
	private static void CGLIFNHBHGN(MOAAIJOHEOA BLCBNGIOOOL, StringBuilder GEAIJHHJFKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x26A4E20", Offset = "0x26A4220", VA = "0x1826A4E20", Slot = "16")]
	public bool BGONOADAENP<T>(GHGELHEJOLM PEOALELMEMH, AGJDONMJMGL NACCIAENLAJ, bool BJCPCLINHHG, T NGEFMGOMMMN) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x66718E0", Offset = "0x6670CE0", VA = "0x1866718E0")]
	private void GCHNJBPGDJB(GHGELHEJOLM PEOALELMEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6673540", Offset = "0x6672940", VA = "0x186673540")]
	private bool NBNOIJADAME(LGNHMFCMNEG HGINANEPKFN, GHGELHEJOLM PEOALELMEMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6672CE0", Offset = "0x66720E0", VA = "0x186672CE0")]
	internal JNIADKIHMEG LJPHFCPAHJC(LGNHMFCMNEG HGINANEPKFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6671010", Offset = "0x6670410", VA = "0x186671010", Slot = "13")]
	public IReadOnlyList<LOBHJOHDNNP> EPGLCDGJHCI(LGNHMFCMNEG HGINANEPKFN, bool BLFOEKDFIGF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6672350", Offset = "0x6671750", VA = "0x186672350")]
	internal IReadOnlyList<JNIADKIHMEG> JPCHAJBFIIH(LGNHMFCMNEG HGINANEPKFN, bool BLFOEKDFIGF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x666FAB0", Offset = "0x666EEB0", VA = "0x18666FAB0")]
	private void CJMJIMDGDJA(HAGIHGGMDIG PGHJLFCMBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6671020", Offset = "0x6670420", VA = "0x186671020")]
	private static bool FALLBCBMADI(JNIADKIHMEG HLBHPLCEFKD, IReadOnlyDictionary<GHGELHEJOLM, JNIADKIHMEG> LNAJFLFHDIJ, [Out] IReadOnlyList<AGJDONMJMGL> KFFDLKBKDIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6671EE0", Offset = "0x66712E0", VA = "0x186671EE0")]
	[AsyncStateMachine(typeof(CLEGMPMLGAM))]
	private static Task JAKOOLJAKGI(FNFPDJPGNEG OKKLIEOPDIO, MOAAIJOHEOA BLCBNGIOOOL, IReadOnlyDictionary<GHGELHEJOLM, JNIADKIHMEG> LNAJFLFHDIJ, ELGANHKEGLI LHMHNGNHLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6670B90", Offset = "0x666FF90", VA = "0x186670B90")]
	[CompilerGenerated]
	internal static void DFFAOGNCKLD(Func<NJCEKHHPOMJ, AJDFMFFAMBN> JDOIKMGFKEL, IGFNAFDIFGM P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6672580", Offset = "0x6671980", VA = "0x186672580")]
	[CompilerGenerated]
	internal static bool KANEGIOFIMN(GHGELHEJOLM PEOALELMEMH, AGJDONMJMGL NACCIAENLAJ, [Out] INOOHLBGDJB NEMHNOJALEP, LPPHDNLOMAK P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface JLDEHKEJLFO
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FLNMAOFGLGE(LGNHMFCMNEG BJMCOBIKEBE, LGNHMFCMNEG HONBIAPIIAA, IEnumerable<LGNHMFCMNEG> CPBGDHHHMIL, [Out] BHBBMHMDNKK AGENICOJLDG, [Out] OECLPIBPGFH CAFPELJJFHB);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string MACBLIFENJA(OECLPIBPGFH HALHMLLILOE);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum OECLPIBPGFH : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	CantKickEventOrganizer,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Broadcaster,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	GameInProgress,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	OpponentGameInProgress
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class DJJGJCCHICJ : JLDEHKEJLFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly JGOECHPLJEG LEPOCDOEBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly PHPGBGOLPAO LCEDPIBBCCB;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7999C0", Offset = "0x798DC0", VA = "0x1807999C0")]
	[RecRoom.NoEngine.Common.Preserve]
	public DJJGJCCHICJ([AKCMIAONCHN(null)] JGOECHPLJEG NCNFLEGJLLI, [AKCMIAONCHN(null)] PHPGBGOLPAO CNFCGIAKDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6669E40", Offset = "0x6669240", VA = "0x186669E40")]
	private static GBPMIFLECGE? ILMFCDDBIMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6669D40", Offset = "0x6669140", VA = "0x186669D40", Slot = "4")]
	public bool FLNMAOFGLGE(LGNHMFCMNEG BJMCOBIKEBE, LGNHMFCMNEG HONBIAPIIAA, IEnumerable<LGNHMFCMNEG> CPBGDHHHMIL, [Out] BHBBMHMDNKK AGENICOJLDG, [Out] OECLPIBPGFH CAFPELJJFHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x666A4A0", Offset = "0x66698A0", VA = "0x18666A4A0", Slot = "5")]
	public string MACBLIFENJA(OECLPIBPGFH HALHMLLILOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6669E80", Offset = "0x6669280", VA = "0x186669E80")]
	internal bool LMMEEDFJFJB(LGNHMFCMNEG BJMCOBIKEBE, LGNHMFCMNEG HONBIAPIIAA, IEnumerable<LGNHMFCMNEG> CPBGDHHHMIL, JNJPAGLJCJK LICFLEFANBD, GBPMIFLECGE? LKDGCKFKIMK, [Out] BHBBMHMDNKK AGENICOJLDG, [Out] OECLPIBPGFH CAFPELJJFHB)
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
