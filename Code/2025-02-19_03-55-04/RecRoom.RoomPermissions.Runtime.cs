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
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CA6780", Offset = "0x7CA5380", VA = "0x187CA6780")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9836D0", Offset = "0x9822D0", VA = "0x1809836D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x983710", Offset = "0x982310", VA = "0x180983710")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum ABHFHBDIFKL
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
		[Cpp2IlInjected.Address(RVA = "0x7CA7960", Offset = "0x7CA6560", VA = "0x187CA7960", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x240ECE0", Offset = "0x240D8E0", VA = "0x18240ECE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void NGFOINDFHLJ<TPermission>(TPermission PPOEGPMMCAA);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void AHJLMMAKKKK(GDNMNFALBCN ECDFLCCNIEO);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum GGLANPIJLPK
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface LOMPEPFJDFP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool LHDDIDIDCOG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool NBEFCMDOPDP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool HKIJGCELGMA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool KLMPPBGECCL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool GDJMENIGJMI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool BAOJKOOANDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class JBBDPFGLBDE
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum HNOPDBIHHLD
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
	public static readonly Guid HEABLNAJLOP;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid INOCMDJJKPF;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid FDBBOBNBCPF;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid DHOEIPNEGHP;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid BEPJENFEHDP;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid FNGLKPLFJIJ;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly CHFCJGFBHGF<HNNAMAANNEG, Guid> MHFMKKFEFKM;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<HNNAMAANNEG> CNDLHMJBLFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7C9BBE0", Offset = "0x7C9A7E0", VA = "0x187C9BBE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7C9BB10", Offset = "0x7C9A710", VA = "0x187C9BB10")]
	public static HNNAMAANNEG AAIDOOLDHDH(Guid IEIMOIIMGDN)
	{
		return default(HNNAMAANNEG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7C9BE70", Offset = "0x7C9AA70", VA = "0x187C9BE70")]
	public static Guid PFGBGEIMCMC(HNNAMAANNEG FHNMLKMLDFN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7C9BC90", Offset = "0x7C9A890", VA = "0x187C9BC90")]
	public static bool HHLLCHCMEJO(HNNAMAANNEG FHNMLKMLDFN, [Out] Guid IEIMOIIMGDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7C9BD20", Offset = "0x7C9A920", VA = "0x187C9BD20")]
	public static bool HPFODKAJGIN(Guid IEIMOIIMGDN, [Out] HNNAMAANNEG FHNMLKMLDFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7C9BC50", Offset = "0x7C9A850", VA = "0x187C9BC50")]
	public static HNNAMAANNEG EOOMLDHCDFJ(HNNAMAANNEG FHNMLKMLDFN)
	{
		return default(HNNAMAANNEG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7C9BDC0", Offset = "0x7C9A9C0", VA = "0x187C9BDC0")]
	public static HNOPDBIHHLD NBLMBJFKMIH(HNNAMAANNEG KKMBCBHFJFO)
	{
		return default(HNOPDBIHHLD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7C9BBA0", Offset = "0x7C9A7A0", VA = "0x187C9BBA0")]
	internal static HNNAMAANNEG BFKAAMMNBJO(HNOPDBIHHLD POPCOLBMMAH)
	{
		return default(HNNAMAANNEG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KFACLNEELLD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	IOIMLJDHDLA MPPBKDEKEFI
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<HDMIEDCJDFA> JILCEPKFHPL
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event AHJLMMAKKKK AAEPPGMPMFO;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<HDMIEDCJDFA> ABDEKOCOGPO(bool KHLDJAKGMHJ = false);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HDMIEDCJDFA AFOPIKAABJK(GDNMNFALBCN ECDFLCCNIEO);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool EBNEGKPPAOK(GDNMNFALBCN ECDFLCCNIEO);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<HDMIEDCJDFA> JALGGKIODNA(GDNMNFALBCN ECDFLCCNIEO, bool DDGDJBAEBOK = false);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HBEPCPKNPCC(GDNMNFALBCN ECMPMAKDDOP, HNNAMAANNEG FHNMLKMLDFN);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	HDMIEDCJDFA LHOIOLMKGIN(HNNAMAANNEG FHNMLKMLDFN);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool MNDGBNOHOJP<T>(HNNAMAANNEG FHNMLKMLDFN, NOGGBMIAFBL PPOEGPMMCAA, bool NNCLNNEPDEF, T GJPLANLJOMM, [Optional] Action MMNFOBIJFOP) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string CEEPGGBHEDF(NOGGBMIAFBL PPOEGPMMCAA);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface AOPNPKAPHMM
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task KOHIFHNDGDN(OFOCKDHGIHJ FDFFMDBCAPG, CancellationToken NAOIMKEDKEJ);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AOMJDFIHDKH(OFOCKDHGIHJ FDFFMDBCAPG);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JHLGEEIGIDF
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	GDNMNFALBCN DCCCIJHEOJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	GJIEMBMKFED MLACALBADOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	BCPENJPKFJJ CEGCIDADGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<MEJFNGOIDMP> NHFBPIDDAAM;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action CHACEMMNBBF;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HNNAMAANNEG MNOGLLFIAMG(GDNMNFALBCN ECDFLCCNIEO);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<MEJFNGOIDMP> EKKGBHGPHIF(CancellationToken NAOIMKEDKEJ);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task MAPCAGEBCBC(long EPGJLNEAJPA, IReadOnlyList<LKOMFOJEGPP> ONJAHDDHJAP);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task CELDAOEEFMP(long EPGJLNEAJPA, long HPCDEBDHAFJ, IReadOnlyList<LKOMFOJEGPP> ONJAHDDHJAP);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<GDNMNFALBCN> ILCECCNLGNL();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class EBOHNENPHPO
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7C996A0", Offset = "0x7C982A0", VA = "0x187C996A0")]
	public static HNNAMAANNEG IBPAAMMIFCL(this JHLGEEIGIDF MDFFBHFHCBG)
	{
		return default(HNNAMAANNEG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface CLNCPBPIDCM<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string BEECMLNILFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event NGFOINDFHLJ<TPermission> CLENFGILABG;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal abstract class MPOGAMKCABH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal object? MBOCLMMDNOO;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? CJOMGJICBCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7CA0A50", Offset = "0x7C9F650", VA = "0x187CA0A50")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7CA0B30", Offset = "0x7C9F730", VA = "0x187CA0B30")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7CA0C30", Offset = "0x7C9F830", VA = "0x187CA0C30")]
	protected MPOGAMKCABH(object? EEBGDBNPJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool KMDBGJLFJEP(object? MPDLOLIOGJL);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class KMJNPOMDOHI<T> : MPOGAMKCABH where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> CFOLKBKPHDN;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T GNLOKINMAMH
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4A7A0C0", Offset = "0x4A78CC0", VA = "0x184A7A0C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4A7A690", Offset = "0x4A79290", VA = "0x184A7A690", Slot = "4")]
	public override bool KMDBGJLFJEP(object? MPDLOLIOGJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4A7AAE0", Offset = "0x4A796E0", VA = "0x184A7AAE0")]
	public bool OIEJJBEDIML(T BNGOCLFNBJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4A7AFB0", Offset = "0x4A79BB0", VA = "0x184A7AFB0")]
	public KMJNPOMDOHI(T NBKBMLNEBHK, IEqualityComparer<T> CFOLKBKPHDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class PLILCBLDAFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<NOGGBMIAFBL, bool> HHHNCGKJLEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<NOGGBMIAFBL, MPOGAMKCABH> HJPJHOJHAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly LBMAFNOHICB AOBAOIJDCEF;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7CA6F50", Offset = "0x7CA5B50", VA = "0x187CA6F50")]
	public PLILCBLDAFO(LBMAFNOHICB AOBAOIJDCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7CA6EE0", Offset = "0x7CA5AE0", VA = "0x187CA6EE0")]
	public bool PMGELNMAGNO(NOGGBMIAFBL PPOEGPMMCAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3561F20", Offset = "0x3560B20", VA = "0x183561F20")]
	public bool MFDKGGAKMJA<T>(NOGGBMIAFBL PPOEGPMMCAA, bool NNCLNNEPDEF, T MPDLOLIOGJL) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3561A80", Offset = "0x3560680", VA = "0x183561A80")]
	public (bool, T?) CCIGMJAPADM<T>(NOGGBMIAFBL PPOEGPMMCAA) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7CA6B40", Offset = "0x7CA5740", VA = "0x187CA6B40")]
	public bool MFDKGGAKMJA(NOGGBMIAFBL PPOEGPMMCAA, bool NNCLNNEPDEF, object MPDLOLIOGJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7CA69A0", Offset = "0x7CA55A0", VA = "0x187CA69A0")]
	public (bool, object) CCIGMJAPADM(NOGGBMIAFBL PPOEGPMMCAA)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x35624A0", Offset = "0x35610A0", VA = "0x1835624A0")]
	private void NGKHAOHEKCA<T>(NOGGBMIAFBL PPOEGPMMCAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7CA6C20", Offset = "0x7CA5820", VA = "0x187CA6C20")]
	private MPOGAMKCABH NKMBILMBIKA(NOGGBMIAFBL PPOEGPMMCAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7CA6CF0", Offset = "0x7CA58F0", VA = "0x187CA6CF0")]
	public void PJBHHNADHPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class OMEHNOIGGMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string GHINAKGEMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type NIDOCNJNKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly PDBEFIPOLCN JPBFBIDMMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly NOGGBMIAFBL LCFJFBCHPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public IBCCADJIJDP KIGNFDGKNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public FIBCHAGHFGF KICMHMAFIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public OJHFGHEMDAG GBDHECHAGHD;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7CA6900", Offset = "0x7CA5500", VA = "0x187CA6900")]
	public OMEHNOIGGMF(Type IMOLBBOLHKN, string MFFNGHBBOHO, NOGGBMIAFBL PPOEGPMMCAA, IBCCADJIJDP DDJKONEGJHI, FIBCHAGHFGF OOHDLFHJIJC, OJHFGHEMDAG DFLHLIMODJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7CA6800", Offset = "0x7CA5400", VA = "0x187CA6800")]
	public object MPHLOBAHBMK(object? PELBNOCGOOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x354EF80", Offset = "0x354DB80", VA = "0x18354EF80")]
	public void NGKHAOHEKCA<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7CA6850", Offset = "0x7CA5450", VA = "0x187CA6850")]
	public void NGKHAOHEKCA(Type ECLLNGCBDOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class EDDKFLPOKLD<T> : OMEHNOIGGMF where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate string HFIAEEEMHAP(T MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal delegate T GNOFHELOAAK(string? LKHCDDOKINP, T NBKBMLNEBHK);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class AEAIKDNJJKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public HFIAEEEMHAP serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public GNOFHELOAAK parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public AEAIKDNJJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x454AA50", Offset = "0x4549650", VA = "0x18454AA50")]
		internal string IAJIPBONKMF(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x454A900", Offset = "0x4549500", VA = "0x18454A900")]
		internal object EHAFEAADPFP(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3FB6AE0", Offset = "0x3FB56E0", VA = "0x183FB6AE0")]
	public EDDKFLPOKLD(NOGGBMIAFBL PPOEGPMMCAA, string MFFNGHBBOHO, [Optional] HFIAEEEMHAP? DDJKONEGJHI, [Optional] GNOFHELOAAK? OOHDLFHJIJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3FB5E00", Offset = "0x3FB4A00", VA = "0x183FB5E00")]
	private static object? KOHMJABOPGF(GNOFHELOAAK? OOHDLFHJIJC, string? LKHCDDOKINP, object? NBKBMLNEBHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3FB5570", Offset = "0x3FB4170", VA = "0x183FB5570")]
	private static string DHDDBDHCOJI(HFIAEEEMHAP? AOLFECBGPGH, object? MPDLOLIOGJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate string IBCCADJIJDP(object? MPDLOLIOGJL);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate object FIBCHAGHFGF(string? LKHCDDOKINP, [Optional] object NBKBMLNEBHK);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal delegate MPOGAMKCABH OJHFGHEMDAG();
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class LBMAFNOHICB
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class FHEHBEIFEMO : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static FHEHBEIFEMO FFLNCJPMHOJ;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7C99700", Offset = "0x7C98300", VA = "0x187C99700", Slot = "4")]
		public bool Equals(List<string> MDFKHKOGFDI, List<string> ELJEANFLEPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7C99850", Offset = "0x7C98450", VA = "0x187C99850", Slot = "5")]
		public int GetHashCode(List<string> CFMCKCBBBKK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public FHEHBEIFEMO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class IJAPNMCBMPO : GDEJHLLJGOM<ABHFHBDIFKL>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7C9B190", Offset = "0x7C99D90", VA = "0x187C9B190", Slot = "9")]
		public override string DHDDBDHCOJI(ABHFHBDIFKL CPPOMEHPJCH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7C9AFB0", Offset = "0x7C99BB0", VA = "0x187C9AFB0", Slot = "10")]
		protected override bool CINAAONMDJH(string CPPOMEHPJCH, [Out] ABHFHBDIFKL MPDLOLIOGJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7C9B280", Offset = "0x7C99E80", VA = "0x187C9B280")]
		public IJAPNMCBMPO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly KNAHPCLHEKE GEDDCOJKJBB;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly IJAPNMCBMPO EHMMMHBEMFF;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<OMEHNOIGGMF> BJOGLBLOIBH;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<NOGGBMIAFBL> OILDOMOKIPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<NOGGBMIAFBL, OMEHNOIGGMF> BCLBHBAAAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7CA0730", Offset = "0x7C9F330", VA = "0x187CA0730")]
	public LBMAFNOHICB([Optional] IList<OMEHNOIGGMF>? LHMEFGPGPBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7C9F220", Offset = "0x7C9DE20", VA = "0x187C9F220")]
	public OMEHNOIGGMF HBLEELFJMKG(NOGGBMIAFBL PPOEGPMMCAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface IOIMLJDHDLA
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	HDMIEDCJDFA OHBJHHFCILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class KLNPJDFKNNA : IOIMLJDHDLA
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static KLNPJDFKNNA FBGHKEACOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly KLMNPMOJDBN HOMLKFAOCFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<KLMNPMOJDBN> BDFIIAAIIEM;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public HDMIEDCJDFA OHBJHHFCILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7C9F110", Offset = "0x7C9DD10", VA = "0x187C9F110")]
	public KLNPJDFKNNA(KLMNPMOJDBN ANCBOLDLCGD, IReadOnlyList<KLMNPMOJDBN> HGGDJHMNGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7C9E280", Offset = "0x7C9CE80", VA = "0x187C9E280")]
	private static KLNPJDFKNNA JFFNPCKNCDN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class GIFIHBFJNCP
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<HNNAMAANNEG> DPBNNICFHNH;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7C9AD00", Offset = "0x7C99900", VA = "0x187C9AD00")]
	public static bool NBHBEFKIBLJ(this GDNMNFALBCN JCNJPDCHNEJ, HNNAMAANNEG FHNMLKMLDFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7C9AC80", Offset = "0x7C99880", VA = "0x187C9AC80")]
	public static bool EICHDGNKIHO(this GDNMNFALBCN JCNJPDCHNEJ, HNNAMAANNEG FHNMLKMLDFN, BCPENJPKFJJ DMHINAGAHMH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface FCHPMGLDOMF
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool LBJAPMKIBJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool NCCMBBKHMGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool IGMFJEGIAKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool JJFNOJOJDEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool ICMFGPGGFGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool ONHCPMEBKJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool GIFMNJENKHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool JMAEAHKKMJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool FPFINGPNBIB
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool CFKDONGLHFI
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool JHGCGBCEDBA
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool INPDJOMIAAO
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> GFEDPCKOBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	ABHFHBDIFKL JBGCDBGNAAM
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface HDMIEDCJDFA : FCHPMGLDOMF, LOMPEPFJDFP, CLNCPBPIDCM<NOGGBMIAFBL>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string NCJPHPEHAMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	HNNAMAANNEG CDMJEJPCAPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) ILNDEHACKFK<T>(NOGGBMIAFBL PPOEGPMMCAA) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum NOGGBMIAFBL
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
internal class KLMNPMOJDBN : HDMIEDCJDFA, FCHPMGLDOMF, LOMPEPFJDFP, CLNCPBPIDCM<NOGGBMIAFBL>
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly LBMAFNOHICB GIHLJBJDGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	internal readonly PLILCBLDAFO GKFPJPLNHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private string? OLHFIDEGNOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private string? FPJJBJDJJNA;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool IGJLABNDIAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7C9D760", Offset = "0x7C9C360", VA = "0x187C9D760", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool ELBJHMLKIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DCF0", Offset = "0x7C9C8F0", VA = "0x187C9DCF0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool HBIEEOIJGNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C7C0", Offset = "0x7C9B3C0", VA = "0x187C9C7C0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool CPMLLMODADP
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C630", Offset = "0x7C9B230", VA = "0x187C9C630", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool HEHBHLHNNCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C680", Offset = "0x7C9B280", VA = "0x187C9C680", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool AAADIMHMLOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C770", Offset = "0x7C9B370", VA = "0x187C9C770", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public HNNAMAANNEG CDMJEJPCAPG
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xBB8D00", Offset = "0xBB7900", VA = "0x180BB8D00", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(HNNAMAANNEG);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963120", VA = "0x180964520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string BEECMLNILFK
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C250", Offset = "0x7C9AE50", VA = "0x187C9C250", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C860", Offset = "0x7C9B460", VA = "0x187C9C860")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string NCJPHPEHAMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C250", Offset = "0x7C9AE50", VA = "0x187C9C250", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool GKABFBGHEEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xC22580", Offset = "0xC21180", VA = "0x180C22580")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xC225A0", Offset = "0xC211A0", VA = "0x180C225A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool LBJAPMKIBJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DB30", Offset = "0x7C9C730", VA = "0x187C9DB30", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public ABHFHBDIFKL JBGCDBGNAAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C6D0", Offset = "0x7C9B2D0", VA = "0x187C9C6D0", Slot = "20")]
		get
		{
			return default(ABHFHBDIFKL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool NCCMBBKHMGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DA50", Offset = "0x7C9C650", VA = "0x187C9DA50", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool IGMFJEGIAKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DE20", Offset = "0x7C9CA20", VA = "0x187C9DE20", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool JJFNOJOJDEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C200", Offset = "0x7C9AE00", VA = "0x187C9C200", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool ICMFGPGGFGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DA00", Offset = "0x7C9C600", VA = "0x187C9DA00", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool ONHCPMEBKJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C810", Offset = "0x7C9B410", VA = "0x187C9C810", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool GIFMNJENKHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7C9D9B0", Offset = "0x7C9C5B0", VA = "0x187C9D9B0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool JMAEAHKKMJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C5E0", Offset = "0x7C9B1E0", VA = "0x187C9C5E0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool FPFINGPNBIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7C9D710", Offset = "0x7C9C310", VA = "0x187C9D710", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> GFEDPCKOBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DEC0", Offset = "0x7C9CAC0", VA = "0x187C9DEC0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool AFKOLOKACCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7C9D760", Offset = "0x7C9C360", VA = "0x187C9D760", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool AFMKBJAOFLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C680", Offset = "0x7C9B280", VA = "0x187C9C680", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool NIFOONEHHHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DCF0", Offset = "0x7C9C8F0", VA = "0x187C9DCF0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool CFKDONGLHFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DB80", Offset = "0x7C9C780", VA = "0x187C9DB80", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool JHGCGBCEDBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C590", Offset = "0x7C9B190", VA = "0x187C9C590", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool BHFAAFIDFJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C7C0", Offset = "0x7C9B3C0", VA = "0x187C9C7C0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool INPDJOMIAAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DE70", Offset = "0x7C9CA70", VA = "0x187C9DE70", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool IKPKHDGGIGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C630", Offset = "0x7C9B230", VA = "0x187C9C630", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool IPBOAMDDBIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C770", Offset = "0x7C9B370", VA = "0x187C9C770", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event NGFOINDFHLJ<NOGGBMIAFBL> CLENFGILABG
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DBD0", Offset = "0x7C9C7D0", VA = "0x187C9DBD0", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF20", Offset = "0x7C9CB20", VA = "0x187C9DF20", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x343C990", Offset = "0x343B590", VA = "0x18343C990", Slot = "6")]
	public (bool, T?) ILNDEHACKFK<T>(NOGGBMIAFBL PPOEGPMMCAA) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x343C930", Offset = "0x343B530", VA = "0x18343C930")]
	public KLMNPMOJDBN DGOPIJBAPIL<T>(NOGGBMIAFBL PPOEGPMMCAA, bool NNCLNNEPDEF, T MPDLOLIOGJL) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7C9E1C0", Offset = "0x7C9CDC0", VA = "0x187C9E1C0")]
	public KLMNPMOJDBN(HNNAMAANNEG FHNMLKMLDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7C9E1E0", Offset = "0x7C9CDE0", VA = "0x187C9E1E0")]
	public KLMNPMOJDBN(HNNAMAANNEG FHNMLKMLDFN, [Optional] string? OLHFIDEGNOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7C9E200", Offset = "0x7C9CE00", VA = "0x187C9E200")]
	public KLMNPMOJDBN(KLMNPMOJDBN PCFIJEIOMEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7C9E070", Offset = "0x7C9CC70", VA = "0x187C9E070")]
	internal KLMNPMOJDBN(HNNAMAANNEG CCGFKFCPLBJ, [Optional] string? OLHFIDEGNOF, [Optional] KLMNPMOJDBN? PCFIJEIOMEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DC80", Offset = "0x7C9C880", VA = "0x187C9DC80")]
	public static PDBEFIPOLCN LMPBAECPFEL(NOGGBMIAFBL PPOEGPMMCAA)
	{
		return default(PDBEFIPOLCN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DFD0", Offset = "0x7C9CBD0", VA = "0x187C9DFD0")]
	public void PJBHHNADHPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7C9C2A0", Offset = "0x7C9AEA0", VA = "0x187C9C2A0")]
	internal KLMNPMOJDBN AKMMBKHCLLH(KLMNPMOJDBN EEMBKFIBJCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7C9C8B0", Offset = "0x7C9B4B0", VA = "0x187C9C8B0")]
	internal IReadOnlyCollection<NOGGBMIAFBL> EIJHJGCMIKM(KLMNPMOJDBN PCFIJEIOMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DD40", Offset = "0x7C9C940", VA = "0x187C9DD40")]
	public bool NCBHKPLJKOD(NOGGBMIAFBL PPOEGPMMCAA, bool NNCLNNEPDEF, string OHFJGNMFLBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7C9CC90", Offset = "0x7C9B890", VA = "0x187C9CC90")]
	public (bool, string) EKPKEGJPEBC(NOGGBMIAFBL PPOEGPMMCAA)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7C9C720", Offset = "0x7C9B320", VA = "0x187C9C720")]
	internal void BIGGDJNGLFP(NOGGBMIAFBL PPOEGPMMCAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7C9D7B0", Offset = "0x7C9C3B0", VA = "0x187C9D7B0")]
	public IFIOPMKAAEG HCGICLOIFCI(Func<HNNAMAANNEG, Guid> IOJMAMMAJIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7C9CD90", Offset = "0x7C9B990", VA = "0x187C9CD90")]
	public void FKNJEFJMOGO(IFIOPMKAAEG BGIEFJDLMCD, Func<Guid, HNNAMAANNEG> DJLCNJJPCJH, [Optional] HNNAMAANNEG? NGCJGLKFFDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DAA0", Offset = "0x7C9C6A0", VA = "0x187C9DAA0")]
	[CompilerGenerated]
	private void JOGFHEMJMPC(NOGGBMIAFBL FDFBKDKAPDH, OFFBPIBEKPL GHIIDLJHNKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class NBKFFACLPAA : AOPNPKAPHMM, KFACLNEELLD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class GKHLFNHDAPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public KLMNPMOJDBN newRole;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public GKHLFNHDAPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7C9AF80", Offset = "0x7C99B80", VA = "0x187C9AF80")]
		internal bool MJBJNAMBEIL(KLMNPMOJDBN rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class DCEOBCGADAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public HNNAMAANNEG roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public DCEOBCGADAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7C99690", Offset = "0x7C98290", VA = "0x187C99690")]
		internal bool MCCGJMODHKH(HNNAMAANNEG r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct FJBNHAPAHLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public NBKFFACLPAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public OFOCKDHGIHJ roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private TaskAwaiter<MEJFNGOIDMP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7C99A30", Offset = "0x7C98630", VA = "0x187C99A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7C9A0A0", Offset = "0x7C98CA0", VA = "0x187C9A0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class BGMBAGGECOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public BGMBAGGECOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7C99400", Offset = "0x7C98000", VA = "0x187C99400")]
		internal void CPEIECDODCJ(IFIOPMKAAEG r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7C994E0", Offset = "0x7C980E0", VA = "0x187C994E0")]
		internal void LBPPNCDJLID(IFIOPMKAAEG r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct FKADLNHKLHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public OFOCKDHGIHJ roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class COADMFCBDOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Func<IFIOPMKAAEG, OFFBPIBEKPL> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public COADMFCBDOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7C99630", Offset = "0x7C98230", VA = "0x187C99630")]
		internal void MFCILBKJNOO(IFIOPMKAAEG r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7C99600", Offset = "0x7C98200", VA = "0x187C99600")]
		internal void HIGBOPMBKIL(IFIOPMKAAEG r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7C99660", Offset = "0x7C98260", VA = "0x187C99660")]
		internal void PIBPIFANFGI(IFIOPMKAAEG r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class JMMPNFNGEGA<T> where T : notnull
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
			public JMMPNFNGEGA<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private TaskAwaiter<MEJFNGOIDMP> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x3CB1510", Offset = "0x3CB0110", VA = "0x183CB1510", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xA47DB0", Offset = "0xA469B0", VA = "0x180A47DB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public NOGGBMIAFBL rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public HNNAMAANNEG accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public PDBEFIPOLCN recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public NBKFFACLPAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public JMMPNFNGEGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x49460A0", Offset = "0x4944CA0", VA = "0x1849460A0")]
		[AsyncStateMachine(typeof(JMMPNFNGEGA<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void OIMAMNHAIJO()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct GJIELOIPECL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public IReadOnlyList<LKOMFOJEGPP> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct FMIHDLCOKKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public JHLGEEIGIDF rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public OFOCKDHGIHJ roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public IReadOnlyDictionary<HNNAMAANNEG, KLMNPMOJDBN> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public NFPCFNAHBIE debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7C9A100", Offset = "0x7C98D00", VA = "0x187C9A100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7C9AC20", Offset = "0x7C99820", VA = "0x187C9AC20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly JHLGEEIGIDF MDFFBHFHCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly KLNPJDFKNNA PCJBOLFGEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly NFPCFNAHBIE PABJDHMLLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly Dictionary<int, KLMNPMOJDBN> DLPBHPNCPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	internal readonly Dictionary<HNNAMAANNEG, KLMNPMOJDBN> OCGEPLKPACH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	internal readonly Dictionary<HNNAMAANNEG, KLMNPMOJDBN> GBGEHHCKFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	internal readonly List<KLMNPMOJDBN> GGDJKNADJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private bool FMIMKEDCGMN;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static readonly NOGGBMIAFBL[] NOMGHFPDLMD;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public IOIMLJDHDLA MPPBKDEKEFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<HDMIEDCJDFA> JILCEPKFHPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7CA5240", Offset = "0x7CA3E40", VA = "0x187CA5240", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event AHJLMMAKKKK AAEPPGMPMFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7CA4940", Offset = "0x7CA3540", VA = "0x187CA4940", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7CA11B0", Offset = "0x7C9FDB0", VA = "0x187CA11B0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7CA4780", Offset = "0x7CA3380", VA = "0x187CA4780")]
	[DMDJPIBKEJJ.BGJJNCECJDH]
	internal static void HMDEJEGKIBO(KPLLBHIBBNH DMGOKFDJBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7CA64C0", Offset = "0x7CA50C0", VA = "0x187CA64C0")]
	[UnityEngine.Scripting.Preserve]
	internal NBKFFACLPAA([GJMNBPKNJPO(null)] JHLGEEIGIDF PMFPNINPOAN, [GJMNBPKNJPO(null)] KLNPJDFKNNA ECAEFLPCABN, [GJMNBPKNJPO(null)] NFPCFNAHBIE PABJDHMLLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7CA2060", Offset = "0x7CA0C60", VA = "0x187CA2060", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5750", Offset = "0x7CA4350", VA = "0x187CA5750")]
	private void OELKIBIFMMC(IEnumerable<KLMNPMOJDBN> PJOMPACPPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7CA2170", Offset = "0x7CA0D70", VA = "0x187CA2170", Slot = "12")]
	public bool EBNEGKPPAOK(GDNMNFALBCN ECDFLCCNIEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7CA1540", Offset = "0x7CA0140", VA = "0x187CA1540")]
	private void CHACEMMNBBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7CA2240", Offset = "0x7CA0E40", VA = "0x187CA2240")]
	private void ECKANIEHKMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7CA1020", Offset = "0x7C9FC20", VA = "0x187CA1020", Slot = "10")]
	public IReadOnlyList<HDMIEDCJDFA> ABDEKOCOGPO(bool KHLDJAKGMHJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7CA10A0", Offset = "0x7C9FCA0", VA = "0x187CA10A0", Slot = "11")]
	public HDMIEDCJDFA AFOPIKAABJK(GDNMNFALBCN ECDFLCCNIEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7CA46B0", Offset = "0x7CA32B0", VA = "0x187CA46B0")]
	private HNNAMAANNEG HLPNKJLGLBF(GDNMNFALBCN ECDFLCCNIEO)
	{
		return default(HNNAMAANNEG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7CA34B0", Offset = "0x7CA20B0", VA = "0x187CA34B0", Slot = "14")]
	public bool HBEPCPKNPCC(GDNMNFALBCN ECMPMAKDDOP, HNNAMAANNEG FHNMLKMLDFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7CA51A0", Offset = "0x7CA3DA0", VA = "0x187CA51A0", Slot = "15")]
	public HDMIEDCJDFA LHOIOLMKGIN(HNNAMAANNEG FHNMLKMLDFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5FC0", Offset = "0x7CA4BC0", VA = "0x187CA5FC0")]
	private static bool PJJJBMPMMLB(OLGEDMPAFPL DDDDBIAFNGO, HNNAMAANNEG FHNMLKMLDFN, [Out] IFIOPMKAAEG? AOPDEPNKBJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7CA1550", Offset = "0x7CA0150", VA = "0x187CA1550")]
	private static void CIOJCIBKEDF(OLGEDMPAFPL DDDDBIAFNGO, Action<IFIOPMKAAEG> HCGFJHKIJCO, HNNAMAANNEG PMJOHNPHCAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7CA1640", Offset = "0x7CA0240", VA = "0x187CA1640")]
	private static void CIOJCIBKEDF(OLGEDMPAFPL DDDDBIAFNGO, Action<IFIOPMKAAEG> HCGFJHKIJCO, Predicate<HNNAMAANNEG> HGPBBKLANGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7CA1250", Offset = "0x7C9FE50", VA = "0x187CA1250")]
	private void BACIBKPIADD(GDNMNFALBCN ECDFLCCNIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7CA4D30", Offset = "0x7CA3930", VA = "0x187CA4D30", Slot = "4")]
	[AsyncStateMachine(typeof(FJBNHAPAHLF))]
	public Task KOHIFHNDGDN([CanBeNull] OFOCKDHGIHJ FDFFMDBCAPG, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
	public void AOMJDFIHDKH(OFOCKDHGIHJ FDFFMDBCAPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7CA49F0", Offset = "0x7CA35F0", VA = "0x187CA49F0")]
	private void JBKBILJNFPO(OLGEDMPAFPL DIPDACNGLHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7CA43A0", Offset = "0x7CA2FA0", VA = "0x187CA43A0")]
	internal static string HEHEKJLDBPI(JHLGEEIGIDF MDFFBHFHCBG, OFOCKDHGIHJ FDFFMDBCAPG, IReadOnlyDictionary<HNNAMAANNEG, KLMNPMOJDBN> OCGEPLKPACH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7CA3640", Offset = "0x7CA2240", VA = "0x187CA3640")]
	private static void HBKDOBKHKEJ(OFOCKDHGIHJ FDFFMDBCAPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7CA4E50", Offset = "0x7CA3A50", VA = "0x187CA4E50")]
	private static void LGNILLCBBAE(OLGEDMPAFPL MCOMFBJHGLM, IReadOnlyDictionary<HNNAMAANNEG, KLMNPMOJDBN> OCGEPLKPACH, StringBuilder FODNAAJDIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7CA26D0", Offset = "0x7CA12D0", VA = "0x187CA26D0")]
	private static bool ENOPLFOMBEO(string LNMPEMGJFID, [Out] Guid JJCHBAAFKKE, [Out] HNNAMAANNEG FHNMLKMLDFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7CA27E0", Offset = "0x7CA13E0", VA = "0x187CA27E0")]
	private static void FMEODCMCKKK(OFOCKDHGIHJ FDFFMDBCAPG, StringBuilder FODNAAJDIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x34D6560", Offset = "0x34D5160", VA = "0x1834D6560", Slot = "16")]
	public bool MNDGBNOHOJP<T>(HNNAMAANNEG FHNMLKMLDFN, NOGGBMIAFBL PPOEGPMMCAA, bool NNCLNNEPDEF, T GJPLANLJOMM, [Optional] Action MMNFOBIJFOP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7CA14D0", Offset = "0x7CA00D0", VA = "0x187CA14D0", Slot = "17")]
	public string CEEPGGBHEDF(NOGGBMIAFBL PPOEGPMMCAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7CA12C0", Offset = "0x7C9FEC0", VA = "0x187CA12C0")]
	private void BMNINLCHIKJ(HNNAMAANNEG FHNMLKMLDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7CA2F20", Offset = "0x7CA1B20", VA = "0x187CA2F20")]
	private bool FNMJJMHIDPG(GDNMNFALBCN ECDFLCCNIEO, HNNAMAANNEG FHNMLKMLDFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7CA2F40", Offset = "0x7CA1B40", VA = "0x187CA2F40")]
	internal KLMNPMOJDBN GIOCICMIEKD(GDNMNFALBCN ECDFLCCNIEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7CA49E0", Offset = "0x7CA35E0", VA = "0x187CA49E0", Slot = "13")]
	public IReadOnlyList<HDMIEDCJDFA> JALGGKIODNA(GDNMNFALBCN ECDFLCCNIEO, bool DDGDJBAEBOK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7CA3280", Offset = "0x7CA1E80", VA = "0x187CA3280")]
	internal IReadOnlyList<KLMNPMOJDBN> GNEMOLGBBAP(GDNMNFALBCN ECDFLCCNIEO, bool DDGDJBAEBOK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7CA18D0", Offset = "0x7CA04D0", VA = "0x187CA18D0")]
	private void DDMJNJHGEPF(MEJFNGOIDMP PPGFGFAIIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7CA0D40", Offset = "0x7C9F940", VA = "0x187CA0D40")]
	private static bool AAABPJCJCJM(KLMNPMOJDBN OPMBKGHKCGH, IReadOnlyDictionary<HNNAMAANNEG, KLMNPMOJDBN> OCGEPLKPACH, [Out] IReadOnlyList<NOGGBMIAFBL> ANHDOGCHODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5290", Offset = "0x7CA3E90", VA = "0x187CA5290")]
	[AsyncStateMachine(typeof(FMIHDLCOKKC))]
	private static Task MMEPEIJOEPC(JHLGEEIGIDF MDFFBHFHCBG, OFOCKDHGIHJ FDFFMDBCAPG, IReadOnlyDictionary<HNNAMAANNEG, KLMNPMOJDBN> OCGEPLKPACH, NFPCFNAHBIE PABJDHMLLBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7CA2430", Offset = "0x7CA1030", VA = "0x187CA2430")]
	[CompilerGenerated]
	internal static void ELBKOGKIBGJ(Func<IFIOPMKAAEG, OFFBPIBEKPL> BONLDGJLCGE, FKADLNHKLHE P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7CA53D0", Offset = "0x7CA3FD0", VA = "0x187CA53D0")]
	[CompilerGenerated]
	internal static bool NJJOKGDPMMJ(HNNAMAANNEG FHNMLKMLDFN, NOGGBMIAFBL PPOEGPMMCAA, [Out] LKOMFOJEGPP CAAMMIABLLA, GJIELOIPECL P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface MAILDHMAAFI
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JONJJJNMCFB(GDNMNFALBCN MBCHADDLICB, GDNMNFALBCN PLNGNILCNHH, IEnumerable<GDNMNFALBCN> MONAGHHDHND, [Out] ABHFHBDIFKL AKGABOHODIO, [Out] KFPAAIMHCKI CDGLLJEBGHE);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string IADOIKEELDM(KFPAAIMHCKI GFOFGAPCIJP);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public enum KFPAAIMHCKI : byte
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
internal class IMCFIOLFBDM : MAILDHMAAFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly KFACLNEELLD GFEGMBCEFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly MFLLMFMIKNC DMKPFFHMLJO;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x9677A0", Offset = "0x9663A0", VA = "0x1809677A0")]
	[RecRoom.NoEngine.Common.Preserve]
	public IMCFIOLFBDM([GJMNBPKNJPO(null)] KFACLNEELLD DLPLIBAJDFM, [GJMNBPKNJPO(null)] MFLLMFMIKNC CLAIEFGEHCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7C9B8D0", Offset = "0x7C9A4D0", VA = "0x187C9B8D0")]
	private static NCALNDEKLOP? HHFLIENMNOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7C9BA10", Offset = "0x7C9A610", VA = "0x187C9BA10", Slot = "4")]
	public bool JONJJJNMCFB(GDNMNFALBCN MBCHADDLICB, GDNMNFALBCN PLNGNILCNHH, IEnumerable<GDNMNFALBCN> MONAGHHDHND, [Out] ABHFHBDIFKL AKGABOHODIO, [Out] KFPAAIMHCKI CDGLLJEBGHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7C9B910", Offset = "0x7C9A510", VA = "0x187C9B910", Slot = "5")]
	public string IADOIKEELDM(KFPAAIMHCKI GFOFGAPCIJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7C9B2C0", Offset = "0x7C99EC0", VA = "0x187C9B2C0")]
	internal bool FHKDMEGEFNF(GDNMNFALBCN MBCHADDLICB, GDNMNFALBCN PLNGNILCNHH, IEnumerable<GDNMNFALBCN> MONAGHHDHND, BCPENJPKFJJ DMHINAGAHMH, NCALNDEKLOP? PMIGECCBGHL, [Out] ABHFHBDIFKL AKGABOHODIO, [Out] KFPAAIMHCKI CDGLLJEBGHE)
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
