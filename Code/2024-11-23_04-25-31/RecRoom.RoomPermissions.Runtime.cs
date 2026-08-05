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
		[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
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
		[Cpp2IlInjected.Address(RVA = "0x754C130", Offset = "0x754AB30", VA = "0x18754C130")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D7890", Offset = "0x8D6290", VA = "0x1808D7890")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D78D0", Offset = "0x8D62D0", VA = "0x1808D78D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum PLNKGJFELAI
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
		[Cpp2IlInjected.Address(RVA = "0x754EF60", Offset = "0x754D960", VA = "0x18754EF60", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2164780", Offset = "0x2163180", VA = "0x182164780")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void JHKOAHNGFDO<TPermission>(TPermission MPKBEEPNPKD);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void HHHIODOOAJP(OGOAPNICIIH JOCAMECBDHO);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum DIFHCHGOHNO
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KIKFLJBNMAP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool ADLJLDEOEMN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool EFCAPIBLAAL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool NAAELGOIFMN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool EEMANMMCDHM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool HGFPHAAJJLL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool HMMFKFCIFFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class CJDAGHKHLBP
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum PCACECNHFBL
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
	public static readonly Guid FLIEFONCJAK;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid NHBBHDNNGIO;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid JEGHCEHFMGE;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid CLOHEIGAJEL;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid ODBINEJMKLH;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid OHOGADODPJI;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly PLDKLKELDFK<AMGEEFGMLAH, Guid> EPDIJNFLBLN;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<AMGEEFGMLAH> LOLIGHDLJIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7540E20", Offset = "0x753F820", VA = "0x187540E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7540D90", Offset = "0x753F790", VA = "0x187540D90")]
	public static AMGEEFGMLAH LHAEFKEMCLE(Guid MMGMNLELLKG)
	{
		return default(AMGEEFGMLAH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7540CF0", Offset = "0x753F6F0", VA = "0x187540CF0")]
	public static Guid JBLCMPOFLMH(AMGEEFGMLAH FDNLCKEPNPK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7540C60", Offset = "0x753F660", VA = "0x187540C60")]
	public static bool DEJDLAGFNPL(AMGEEFGMLAH FDNLCKEPNPK, [Out] Guid MMGMNLELLKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7540F80", Offset = "0x753F980", VA = "0x187540F80")]
	public static bool PGDAFBFLOKB(Guid MMGMNLELLKG, [Out] AMGEEFGMLAH FDNLCKEPNPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7540E90", Offset = "0x753F890", VA = "0x187540E90")]
	public static AMGEEFGMLAH NJFCKPNEHCB(AMGEEFGMLAH FDNLCKEPNPK)
	{
		return default(AMGEEFGMLAH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7540ED0", Offset = "0x753F8D0", VA = "0x187540ED0")]
	public static PCACECNHFBL PFBONBCNICM(AMGEEFGMLAH PKJCLIIBBBN)
	{
		return default(PCACECNHFBL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7540C20", Offset = "0x753F620", VA = "0x187540C20")]
	internal static AMGEEFGMLAH ABHPABGAHJL(PCACECNHFBL ACELHEECHOI)
	{
		return default(AMGEEFGMLAH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DGFNLKOMOMF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	PCEOALJKKIA CCLAGLBMAEP
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<CBMLBEELJHD> ECAHBGNCOGA
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event HHHIODOOAJP JBEDAFAEOCO;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<CBMLBEELJHD> GOANPJFDFDL(bool LOFOINFICNG = false);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CBMLBEELJHD KKNDCNPGHDO(OGOAPNICIIH JOCAMECBDHO);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool IIMKHGLKPFF(OGOAPNICIIH JOCAMECBDHO);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<CBMLBEELJHD> PEKHDIKEOLO(OGOAPNICIIH JOCAMECBDHO, bool EPLEFDIPAOE = false);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool POCICKOAIHJ(OGOAPNICIIH GEFKOEJEMHL, AMGEEFGMLAH FDNLCKEPNPK);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	CBMLBEELJHD BPHGMBDEHNF(AMGEEFGMLAH FDNLCKEPNPK);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool CLIGFKANODP<T>(AMGEEFGMLAH FDNLCKEPNPK, BCOJHLLCAJF MPKBEEPNPKD, bool DHPJHIAHOAO, T BCHPPGPOGNC, [Optional] Action DAOADOMBIIL) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string OIHAGMDOFID(BCOJHLLCAJF MPKBEEPNPKD);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FPPKHEIJMNL
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task HPOPKNBFNBC(FNEPJCIGLHI GJLDCFIFFGA, CancellationToken PPLDCJFFMEP);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HKKJEDNEINH(FNEPJCIGLHI GJLDCFIFFGA);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface DKMBOLLBJBK
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	OGOAPNICIIH LPMJBEMNAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	OABHCPGEKDA HIJHLAGAKEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	IJINIJPNMHJ LDJJIDBLMKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<GOBMBHFKFNB> JGBEIINHKDF;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action BMNAFNKPJID;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AMGEEFGMLAH KDLAGPIJFKA(OGOAPNICIIH JOCAMECBDHO);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<GOBMBHFKFNB> FLEKGCMKBEF(CancellationToken PPLDCJFFMEP);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task JAPABGCFPLJ(long NPGHGEFGHLA, IReadOnlyList<AENOLNFPAOH> LKMABAOHOJF);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task LBEOCKFOIFM(long NPGHGEFGHLA, long GDENKKEDKLA, IReadOnlyList<AENOLNFPAOH> LKMABAOHOJF);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<OGOAPNICIIH> DNGJOEPGHBA();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class DHJOIDGMDOO
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7541310", Offset = "0x753FD10", VA = "0x187541310")]
	public static AMGEEFGMLAH MGOMOPJHEHP(this DKMBOLLBJBK OJGCIJHDOOD)
	{
		return default(AMGEEFGMLAH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface KDHBIAFDHJJ<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string AGNJMKFHKDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event JHKOAHNGFDO<TPermission> GNGFLJILNDF;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal abstract class OLPIPEIPOLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal object? KBFPOINKBBC;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? NIKEBNEHCJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x754C1B0", Offset = "0x754ABB0", VA = "0x18754C1B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x754C280", Offset = "0x754AC80", VA = "0x18754C280")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x754C380", Offset = "0x754AD80", VA = "0x18754C380")]
	protected OLPIPEIPOLL(object? HINDCAJNGLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool PGDFJBEDOMJ(object? PKCLPFEIPFH);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class GIAJOFMACAM<T> : OLPIPEIPOLL where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> FNBJNOCPAIF;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T IPHIEALFCML
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4108EC0", Offset = "0x41078C0", VA = "0x184108EC0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x41098A0", Offset = "0x41082A0", VA = "0x1841098A0", Slot = "4")]
	public override bool PGDFJBEDOMJ(object? PKCLPFEIPFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4109310", Offset = "0x4107D10", VA = "0x184109310")]
	public bool KKMHAGEBHNC(T LDDEFFBHKGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4109BC0", Offset = "0x41085C0", VA = "0x184109BC0")]
	public GIAJOFMACAM(T PFGHNJEFBFP, IEqualityComparer<T> FNBJNOCPAIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class LNIENIKHDLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<BCOJHLLCAJF, bool> GLFJBJLPBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<BCOJHLLCAJF, OLPIPEIPOLL> EGJKIDEKKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly FHAAIOIJBMH MFOCLEOJOHI;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x754B6B0", Offset = "0x754A0B0", VA = "0x18754B6B0")]
	public LNIENIKHDLB(FHAAIOIJBMH MFOCLEOJOHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x754B570", Offset = "0x7549F70", VA = "0x18754B570")]
	public bool HAEPFMGGKEA(BCOJHLLCAJF MPKBEEPNPKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2FC0FE0", Offset = "0x2FBF9E0", VA = "0x182FC0FE0")]
	public bool DJPCMCBAHPG<T>(BCOJHLLCAJF MPKBEEPNPKD, bool DHPJHIAHOAO, T PKCLPFEIPFH) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2FC0B40", Offset = "0x2FBF540", VA = "0x182FC0B40")]
	public (bool, T?) DFJCGCEAPJP<T>(BCOJHLLCAJF MPKBEEPNPKD) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x754B290", Offset = "0x7549C90", VA = "0x18754B290")]
	public bool DJPCMCBAHPG(BCOJHLLCAJF MPKBEEPNPKD, bool DHPJHIAHOAO, object PKCLPFEIPFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x754B100", Offset = "0x7549B00", VA = "0x18754B100")]
	public (bool, object) DFJCGCEAPJP(BCOJHLLCAJF MPKBEEPNPKD)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2FC1560", Offset = "0x2FBFF60", VA = "0x182FC1560")]
	private void NEENPHDJFAI<T>(BCOJHLLCAJF MPKBEEPNPKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x754B5E0", Offset = "0x7549FE0", VA = "0x18754B5E0")]
	private OLPIPEIPOLL HPAFPIMLMJL(BCOJHLLCAJF MPKBEEPNPKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x754B370", Offset = "0x7549D70", VA = "0x18754B370")]
	public void GMMBJMNGHNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class NKINGNNJEDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string GMKJCBCMFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type MADOCCLIMPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly CIJFBCFMMKN DKCHPBELBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly BCOJHLLCAJF FAGLILDAJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ADDAJMKBGLI CFNJFOHBPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public KILNGFHKHPA DGFLLKBIIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public HPJLPDBMOBD FNEEBDFEAHA;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x754BD90", Offset = "0x754A790", VA = "0x18754BD90")]
	public NKINGNNJEDL(Type DOAHAOKEMHA, string AFEDPCMDNPE, BCOJHLLCAJF MPKBEEPNPKD, ADDAJMKBGLI LBALOECBBMG, KILNGFHKHPA EPKBDMLJPPH, HPJLPDBMOBD PBPMBONGBGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x754BC90", Offset = "0x754A690", VA = "0x18754BC90")]
	public object FBFABCDIIPC(object? GDOGPMPJPOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x304EE30", Offset = "0x304D830", VA = "0x18304EE30")]
	public void NEENPHDJFAI<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x754BCE0", Offset = "0x754A6E0", VA = "0x18754BCE0")]
	public void NEENPHDJFAI(Type LOPCPHPJBLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class IIDGKKPGCNL<T> : NKINGNNJEDL where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate string HJJGABLKOCJ(T PKCLPFEIPFH);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal delegate T GFIHMNJENCH(string? JJCFJOPJNIK, T PFGHNJEFBFP);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class PHNKBHIGHIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public HJJGABLKOCJ serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public GFIHMNJENCH parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public PHNKBHIGHIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4B6F560", Offset = "0x4B6DF60", VA = "0x184B6F560")]
		internal string LNCAOAEDEDK(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4B6F6F0", Offset = "0x4B6E0F0", VA = "0x184B6F6F0")]
		internal object PMIMDKICEIN(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x424E5E0", Offset = "0x424CFE0", VA = "0x18424E5E0")]
	public IIDGKKPGCNL(BCOJHLLCAJF MPKBEEPNPKD, string AFEDPCMDNPE, [Optional] HJJGABLKOCJ? LBALOECBBMG, [Optional] GFIHMNJENCH? EPKBDMLJPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x424D3D0", Offset = "0x424BDD0", VA = "0x18424D3D0")]
	private static object? DLDAMIHNNNK(GFIHMNJENCH? EPKBDMLJPPH, string? JJCFJOPJNIK, object? PFGHNJEFBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x424E300", Offset = "0x424CD00", VA = "0x18424E300")]
	private static string HLGBFIEHJDG(HJJGABLKOCJ? JMMNNBADCHO, object? PKCLPFEIPFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate string ADDAJMKBGLI(object? PKCLPFEIPFH);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate object KILNGFHKHPA(string? JJCFJOPJNIK, [Optional] object PFGHNJEFBFP);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal delegate OLPIPEIPOLL HPJLPDBMOBD();
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class FHAAIOIJBMH
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class NINMLCCPOKE : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static NINMLCCPOKE JOLICDCBKGF;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x754B960", Offset = "0x754A360", VA = "0x18754B960", Slot = "4")]
		public bool Equals(List<string> PMBJFHIMJKC, List<string> HBABDGBANAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x754BAB0", Offset = "0x754A4B0", VA = "0x18754BAB0", Slot = "5")]
		public int GetHashCode(List<string> BBNKFKDCOLP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public NINMLCCPOKE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class KBPBFLHDCAH : FJLCIGLEIHL<PLNKGJFELAI>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x754ADF0", Offset = "0x75497F0", VA = "0x18754ADF0", Slot = "9")]
		public override string HLGBFIEHJDG(PLNKGJFELAI CPOLINJHFNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x754AEE0", Offset = "0x75498E0", VA = "0x18754AEE0", Slot = "10")]
		protected override bool PBBPOFKEJPO(string CPOLINJHFNA, [Out] PLNKGJFELAI PKCLPFEIPFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x754B0C0", Offset = "0x7549AC0", VA = "0x18754B0C0")]
		public KBPBFLHDCAH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly BJGKKDMKBFF KDLMCEKFKCG;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly KBPBFLHDCAH KHBPIIGNDKE;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<NKINGNNJEDL> EAPAOCGJBJI;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<BCOJHLLCAJF> NOBKJIDIFFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<BCOJHLLCAJF, NKINGNNJEDL> OINPGFKCBGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7542FE0", Offset = "0x75419E0", VA = "0x187542FE0")]
	public FHAAIOIJBMH([Optional] IList<NKINGNNJEDL>? CBPJKCFFGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7541AD0", Offset = "0x75404D0", VA = "0x187541AD0")]
	public NKINGNNJEDL CLIMDBOALOL(BCOJHLLCAJF MPKBEEPNPKD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface PCEOALJKKIA
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	CBMLBEELJHD MJOIDAGDDNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class PPCFOFAHFFA : PCEOALJKKIA
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static PPCFOFAHFFA EPDAFGCMHNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly GLOJKKCCNBO EEFAHJDMIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<GLOJKKCCNBO> HBDMEPDOOBD;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public CBMLBEELJHD MJOIDAGDDNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x754E6F0", Offset = "0x754D0F0", VA = "0x18754E6F0")]
	public PPCFOFAHFFA(GLOJKKCCNBO JMNBCKCPKIB, IReadOnlyList<GLOJKKCCNBO> OHGMHIAIKFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x754D860", Offset = "0x754C260", VA = "0x18754D860")]
	private static PPCFOFAHFFA KNFGILDFMMH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class NMDOOMAAMPF
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<AMGEEFGMLAH> EKIHOOGICLH;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x754BE30", Offset = "0x754A830", VA = "0x18754BE30")]
	public static bool EJHACBNKAEG(this OGOAPNICIIH CKKFCDKPFAG, AMGEEFGMLAH FDNLCKEPNPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x754BF10", Offset = "0x754A910", VA = "0x18754BF10")]
	public static bool IINJGGILIMI(this OGOAPNICIIH CKKFCDKPFAG, AMGEEFGMLAH FDNLCKEPNPK, IJINIJPNMHJ ENLBBOBGKGH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface BDFIJBEFOMD
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool DBDECMFGCEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool NFJFAPKJPLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool HHBAMFMNKGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool EIADMFNJDJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool IGHJNFFCBAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool MJEDGLCHCHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool MEAGGFNCBCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool EFJMEAMMIJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool OILIDGLKJAM
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool CHEBFKLHECI
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool GMNKPGOICCI
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool BAINPMFIJDG
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> GEHPBCHBCEM
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	PLNKGJFELAI MHDFLEGJAMF
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface CBMLBEELJHD : BDFIJBEFOMD, KIKFLJBNMAP, KDHBIAFDHJJ<BCOJHLLCAJF>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string AEFBJOPLJME
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	AMGEEFGMLAH IPPBCLJIGOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) FEMBFECNIFJ<T>(BCOJHLLCAJF MPKBEEPNPKD) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum BCOJHLLCAJF
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
internal class GLOJKKCCNBO : CBMLBEELJHD, BDFIJBEFOMD, KIKFLJBNMAP, KDHBIAFDHJJ<BCOJHLLCAJF>
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly FHAAIOIJBMH MIIPFMJDDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	internal readonly LNIENIKHDLB LNKLKMJCPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private string? EEFJHJHPMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private string? CIHEPJMOIFL;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool ACJCEKKCBDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7543E70", Offset = "0x7542870", VA = "0x187543E70", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool JNENBCCHLHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7543300", Offset = "0x7541D00", VA = "0x187543300", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool MIKMJBFGIOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7544560", Offset = "0x7542F60", VA = "0x187544560", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool DFAIALFPBND
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7543E20", Offset = "0x7542820", VA = "0x187543E20", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool JMHKMBJHHDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7543400", Offset = "0x7541E00", VA = "0x187543400", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool BOFMCOHLICL
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7543DD0", Offset = "0x75427D0", VA = "0x187543DD0", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public AMGEEFGMLAH IPPBCLJIGOA
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xBB0080", Offset = "0xBAEA80", VA = "0x180BB0080", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(AMGEEFGMLAH);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8B81A0", Offset = "0x8B6BA0", VA = "0x1808B81A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string AGNJMKFHKDC
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7543FD0", Offset = "0x75429D0", VA = "0x187543FD0", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x75450B0", Offset = "0x7543AB0", VA = "0x1875450B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string AEFBJOPLJME
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7543FD0", Offset = "0x75429D0", VA = "0x187543FD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool HNAGAIBIODF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x98A810", Offset = "0x989210", VA = "0x18098A810")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x98A160", Offset = "0x988B60", VA = "0x18098A160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool DBDECMFGCEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7544B00", Offset = "0x7543500", VA = "0x187544B00", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public PLNKGJFELAI MHDFLEGJAMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7543F10", Offset = "0x7542910", VA = "0x187543F10", Slot = "20")]
		get
		{
			return default(PLNKGJFELAI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool NFJFAPKJPLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7544870", Offset = "0x7543270", VA = "0x187544870", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool HHBAMFMNKGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7544600", Offset = "0x7543000", VA = "0x187544600", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool EIADMFNJDJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7544970", Offset = "0x7543370", VA = "0x187544970", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool IGHJNFFCBAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7544A10", Offset = "0x7543410", VA = "0x187544A10", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool MJEDGLCHCHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7544B50", Offset = "0x7543550", VA = "0x187544B50", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool MEAGGFNCBCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7544510", Offset = "0x7542F10", VA = "0x187544510", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool EFJMEAMMIJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7544AB0", Offset = "0x75434B0", VA = "0x187544AB0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool OILIDGLKJAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7543EC0", Offset = "0x75428C0", VA = "0x187543EC0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> GEHPBCHBCEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7544EE0", Offset = "0x75438E0", VA = "0x187544EE0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool PFFBCKPBMPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7543E70", Offset = "0x7542870", VA = "0x187543E70", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool BNOLPPHKJME
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7543400", Offset = "0x7541E00", VA = "0x187543400", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool EPEFAIODHEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7543300", Offset = "0x7541D00", VA = "0x187543300", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool CHEBFKLHECI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7544E90", Offset = "0x7543890", VA = "0x187544E90", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool GMNKPGOICCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7544A60", Offset = "0x7543460", VA = "0x187544A60", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool GOOGPKICJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7544560", Offset = "0x7542F60", VA = "0x187544560", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool BAINPMFIJDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x75449C0", Offset = "0x75433C0", VA = "0x1875449C0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool KEGINDAAMOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7543E20", Offset = "0x7542820", VA = "0x187543E20", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool DMDCCDFDDNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7543DD0", Offset = "0x75427D0", VA = "0x187543DD0", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event JHKOAHNGFDO<BCOJHLLCAJF> GNGFLJILNDF
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7543350", Offset = "0x7541D50", VA = "0x187543350", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x75448C0", Offset = "0x75432C0", VA = "0x1875448C0", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2EF2DB0", Offset = "0x2EF17B0", VA = "0x182EF2DB0", Slot = "6")]
	public (bool, T?) FEMBFECNIFJ<T>(BCOJHLLCAJF MPKBEEPNPKD) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2EF2D50", Offset = "0x2EF1750", VA = "0x182EF2D50")]
	public GLOJKKCCNBO CEJODPCHKDJ<T>(BCOJHLLCAJF MPKBEEPNPKD, bool DHPJHIAHOAO, T PKCLPFEIPFH) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7545350", Offset = "0x7543D50", VA = "0x187545350")]
	public GLOJKKCCNBO(AMGEEFGMLAH FDNLCKEPNPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7545370", Offset = "0x7543D70", VA = "0x187545370")]
	public GLOJKKCCNBO(AMGEEFGMLAH FDNLCKEPNPK, [Optional] string? EEFJHJHPMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7545180", Offset = "0x7543B80", VA = "0x187545180")]
	public GLOJKKCCNBO(GLOJKKCCNBO KNEPHPFCLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7545200", Offset = "0x7543C00", VA = "0x187545200")]
	internal GLOJKKCCNBO(AMGEEFGMLAH HAENNDDPDBH, [Optional] string? EEFJHJHPMOB, [Optional] GLOJKKCCNBO? KNEPHPFCLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7543F60", Offset = "0x7542960", VA = "0x187543F60")]
	public static CIJFBCFMMKN CPBCBPHHCDA(BCOJHLLCAJF MPKBEEPNPKD)
	{
		return default(CIJFBCFMMKN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7544850", Offset = "0x7543250", VA = "0x187544850")]
	public void GMMBJMNGHNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7544BA0", Offset = "0x75435A0", VA = "0x187544BA0")]
	internal GLOJKKCCNBO MKNNOIPPHFM(GLOJKKCCNBO JKODDCMEDGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7544020", Offset = "0x7542A20", VA = "0x187544020")]
	internal IReadOnlyCollection<BCOJHLLCAJF> DEIPJDPOBED(GLOJKKCCNBO KNEPHPFCLIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7544F40", Offset = "0x7543940", VA = "0x187544F40")]
	public bool PMGGHOALBPI(BCOJHLLCAJF MPKBEEPNPKD, bool DHPJHIAHOAO, string CJLCNGENJOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7544410", Offset = "0x7542E10", VA = "0x187544410")]
	public (bool, string) DEJFAOOBBLH(BCOJHLLCAJF MPKBEEPNPKD)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x75445B0", Offset = "0x7542FB0", VA = "0x1875445B0")]
	internal void FCMIAPBGLKD(BCOJHLLCAJF MPKBEEPNPKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7544650", Offset = "0x7543050", VA = "0x187544650")]
	public AKCLDOODBLL GMCNGBHHPBA(Func<AMGEEFGMLAH, Guid> DHBHNLEDBOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7543450", Offset = "0x7541E50", VA = "0x187543450")]
	public void ALHCCMIBCIK(AKCLDOODBLL DLLCLFINELM, Func<Guid, AMGEEFGMLAH> DHLPHKFEAMO, [Optional] AMGEEFGMLAH? KKIJFJJCBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7545020", Offset = "0x7543A20", VA = "0x187545020")]
	[CompilerGenerated]
	private void PMLEEAAGAKN(BCOJHLLCAJF GKHMEOFPGGO, GKMFGBOLGPD FDIHKALMOAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class HEJGIDLOKCN : FPPKHEIJMNL, DGFNLKOMOMF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class ALNLDKEAGPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public GLOJKKCCNBO newRole;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public ALNLDKEAGPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7540BF0", Offset = "0x753F5F0", VA = "0x187540BF0")]
		internal bool GPMPDJENLIA(GLOJKKCCNBO rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class ACMGOGLDFKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public AMGEEFGMLAH roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public ACMGOGLDFKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x75409E0", Offset = "0x753F3E0", VA = "0x1875409E0")]
		internal bool LGJJALBGDDE(AMGEEFGMLAH r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct FGODIOLHJAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public HEJGIDLOKCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public FNEPJCIGLHI roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private TaskAwaiter<GOBMBHFKFNB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7541400", Offset = "0x753FE00", VA = "0x187541400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7541A70", Offset = "0x7540470", VA = "0x187541A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class AIMCPIOALPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public AIMCPIOALPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7540B10", Offset = "0x753F510", VA = "0x187540B10")]
		internal void LAELAILMHEJ(AKCLDOODBLL r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x75409F0", Offset = "0x753F3F0", VA = "0x1875409F0")]
		internal void BPBDDHMOAHM(AKCLDOODBLL r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct MBDLHEOAIDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public FNEPJCIGLHI roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class FFNLGJEKGCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Func<AKCLDOODBLL, GKMFGBOLGPD> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public FFNLGJEKGCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x75413D0", Offset = "0x753FDD0", VA = "0x1875413D0")]
		internal void MGMLBIOOGFF(AKCLDOODBLL r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x75413A0", Offset = "0x753FDA0", VA = "0x1875413A0")]
		internal void LDDFCHMNJFG(AKCLDOODBLL r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7541370", Offset = "0x753FD70", VA = "0x187541370")]
		internal void IBNHAECPBDJ(AKCLDOODBLL r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class NJMPIHKDEDI<T> where T : notnull
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
			public NJMPIHKDEDI<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private TaskAwaiter<GOBMBHFKFNB> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x38CAAA0", Offset = "0x38C94A0", VA = "0x1838CAAA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x903690", Offset = "0x902090", VA = "0x180903690", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public BCOJHLLCAJF rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AMGEEFGMLAH accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public CIJFBCFMMKN recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public HEJGIDLOKCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public NJMPIHKDEDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x49482E0", Offset = "0x4946CE0", VA = "0x1849482E0")]
		[AsyncStateMachine(typeof(NJMPIHKDEDI<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void GPOLLBMJPNA()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct KMAMBDHEBNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public IReadOnlyList<AENOLNFPAOH> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct PCOFNDAOIAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public DKMBOLLBJBK rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public FNEPJCIGLHI roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public IReadOnlyDictionary<AMGEEFGMLAH, GLOJKKCCNBO> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public MKDIGONPDGF debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x754C480", Offset = "0x754AE80", VA = "0x18754C480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x754CFA0", Offset = "0x754B9A0", VA = "0x18754CFA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly DKMBOLLBJBK OJGCIJHDOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly PPCFOFAHFFA FBKKMCJDDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly MKDIGONPDGF KDKHLEEPODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly Dictionary<int, GLOJKKCCNBO> CMAFKJHAPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	internal readonly Dictionary<AMGEEFGMLAH, GLOJKKCCNBO> GIBCPNDIPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	internal readonly Dictionary<AMGEEFGMLAH, GLOJKKCCNBO> FLLCMIOMKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	internal readonly List<GLOJKKCCNBO> BLEAGOFFEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private bool BHBHJEKJHCL;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static readonly BCOJHLLCAJF[] ABLGHDCJAHI;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public PCEOALJKKIA CCLAGLBMAEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<CBMLBEELJHD> ECAHBGNCOGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7546010", Offset = "0x7544A10", VA = "0x187546010", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event HHHIODOOAJP JBEDAFAEOCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x754A6B0", Offset = "0x75490B0", VA = "0x18754A6B0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x75487D0", Offset = "0x75471D0", VA = "0x1875487D0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7545800", Offset = "0x7544200", VA = "0x187545800")]
	[EPFHFFCDLIN.KDFGAEMPDLG]
	internal static void DJJNDGGBFEG(KNPHAFHLPCE LKJFOBDMKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x754AB30", Offset = "0x7549530", VA = "0x18754AB30")]
	[UnityEngine.Scripting.Preserve]
	internal HEJGIDLOKCN([CCLEDEMDDDH(null)] DKMBOLLBJBK GDHNNCKLBHH, [CCLEDEMDDDH(null)] PPCFOFAHFFA NMKPBCNIMKG, [CCLEDEMDDDH(null)] MKDIGONPDGF KDKHLEEPODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7545BB0", Offset = "0x75445B0", VA = "0x187545BB0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x75468E0", Offset = "0x75452E0", VA = "0x1875468E0")]
	private void HJBBPDHMGPK(IEnumerable<GLOJKKCCNBO> BLOMAMKHEJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7547280", Offset = "0x7545C80", VA = "0x187547280", Slot = "12")]
	public bool IIMKHGLKPFF(OGOAPNICIIH JOCAMECBDHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7545540", Offset = "0x7543F40", VA = "0x187545540")]
	private void BMNAFNKPJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x75459C0", Offset = "0x75443C0", VA = "0x1875459C0")]
	private void DMCMOCCCDIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7546860", Offset = "0x7545260", VA = "0x187546860", Slot = "10")]
	public IReadOnlyList<CBMLBEELJHD> GOANPJFDFDL(bool LOFOINFICNG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x75486C0", Offset = "0x75470C0", VA = "0x1875486C0", Slot = "11")]
	public CBMLBEELJHD KKNDCNPGHDO(OGOAPNICIIH JOCAMECBDHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7546410", Offset = "0x7544E10", VA = "0x187546410")]
	private AMGEEFGMLAH GEKHKHDMGMJ(OGOAPNICIIH JOCAMECBDHO)
	{
		return default(AMGEEFGMLAH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x754A7D0", Offset = "0x75491D0", VA = "0x18754A7D0", Slot = "14")]
	public bool POCICKOAIHJ(OGOAPNICIIH GEFKOEJEMHL, AMGEEFGMLAH FDNLCKEPNPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7545550", Offset = "0x7543F50", VA = "0x187545550", Slot = "15")]
	public CBMLBEELJHD BPHGMBDEHNF(AMGEEFGMLAH FDNLCKEPNPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x75495B0", Offset = "0x7547FB0", VA = "0x1875495B0")]
	private static bool MDAMHDKKBJM(KBEMKEAEMBJ DOINDGNDJHL, AMGEEFGMLAH FDNLCKEPNPK, [Out] AKCLDOODBLL? CHLBPANCKGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7546770", Offset = "0x7545170", VA = "0x187546770")]
	private static void GLAIHCPBPFM(KBEMKEAEMBJ DOINDGNDJHL, Action<AKCLDOODBLL> OLPPCMAJLEK, AMGEEFGMLAH JKDKDDOKNKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x75464E0", Offset = "0x7544EE0", VA = "0x1875464E0")]
	private static void GLAIHCPBPFM(KBEMKEAEMBJ DOINDGNDJHL, Action<AKCLDOODBLL> OLPPCMAJLEK, Predicate<AMGEEFGMLAH> MBPMMABCJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7545390", Offset = "0x7543D90", VA = "0x187545390")]
	private void ABNDKEBKBIC(OGOAPNICIIH JOCAMECBDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7547160", Offset = "0x7545B60", VA = "0x187547160", Slot = "4")]
	[AsyncStateMachine(typeof(FGODIOLHJAN))]
	public Task HPOPKNBFNBC([CanBeNull] FNEPJCIGLHI GJLDCFIFFGA, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "5")]
	public void HKKJEDNEINH(FNEPJCIGLHI GJLDCFIFFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x75498E0", Offset = "0x75482E0", VA = "0x1875498E0")]
	private void MECKDOKFGLN(KBEMKEAEMBJ ICKBIAFBPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x75483B0", Offset = "0x7546DB0", VA = "0x1875483B0")]
	internal static string KGIFAJODKJB(DKMBOLLBJBK OJGCIJHDOOD, FNEPJCIGLHI GJLDCFIFFGA, IReadOnlyDictionary<AMGEEFGMLAH, GLOJKKCCNBO> GIBCPNDIPAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7547350", Offset = "0x7545D50", VA = "0x187547350")]
	private static void IOPIBPEEGIJ(FNEPJCIGLHI GJLDCFIFFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7545CC0", Offset = "0x75446C0", VA = "0x187545CC0")]
	private static void EHMBLFIOGHA(KBEMKEAEMBJ FPKLLKLCOON, IReadOnlyDictionary<AMGEEFGMLAH, GLOJKKCCNBO> GIBCPNDIPAL, StringBuilder CPLIFPDAFOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7546300", Offset = "0x7544D00", VA = "0x187546300")]
	private static bool ENCOCOFFEAG(string KBBDDHKGCJM, [Out] Guid ALIFKFLGHNA, [Out] AMGEEFGMLAH FDNLCKEPNPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7549C20", Offset = "0x7548620", VA = "0x187549C20")]
	private static void MJIEBAFKOBK(FNEPJCIGLHI GJLDCFIFFGA, StringBuilder CPLIFPDAFOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2EFD400", Offset = "0x2EFBE00", VA = "0x182EFD400", Slot = "16")]
	public bool CLIGFKANODP<T>(AMGEEFGMLAH FDNLCKEPNPK, BCOJHLLCAJF MPKBEEPNPKD, bool DHPJHIAHOAO, T BCHPPGPOGNC, [Optional] Action DAOADOMBIIL) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x754A750", Offset = "0x7549150", VA = "0x18754A750", Slot = "17")]
	public string OIHAGMDOFID(BCOJHLLCAJF MPKBEEPNPKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x75455F0", Offset = "0x7543FF0", VA = "0x1875455F0")]
	private void CCPBLGCNKMK(AMGEEFGMLAH FDNLCKEPNPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x75480B0", Offset = "0x7546AB0", VA = "0x1875480B0")]
	private bool KCFNIFBDOBD(OGOAPNICIIH JOCAMECBDHO, AMGEEFGMLAH FDNLCKEPNPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x754A360", Offset = "0x7548D60", VA = "0x18754A360")]
	internal GLOJKKCCNBO MOCNPIJEEJA(OGOAPNICIIH JOCAMECBDHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x754A7C0", Offset = "0x75491C0", VA = "0x18754A7C0", Slot = "13")]
	public IReadOnlyList<CBMLBEELJHD> PEKHDIKEOLO(OGOAPNICIIH JOCAMECBDHO, bool EPLEFDIPAOE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7549380", Offset = "0x7547D80", VA = "0x187549380")]
	internal IReadOnlyList<GLOJKKCCNBO> LPLHJKEKNAE(OGOAPNICIIH JOCAMECBDHO, bool EPLEFDIPAOE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7548870", Offset = "0x7547270", VA = "0x187548870")]
	private void KPOJBKNJFDD(GOBMBHFKFNB EFHEKENFPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x75480D0", Offset = "0x7546AD0", VA = "0x1875480D0")]
	private static bool KGEJEKFBKOI(GLOJKKCCNBO BKJCCHCGGGK, IReadOnlyDictionary<AMGEEFGMLAH, GLOJKKCCNBO> GIBCPNDIPAL, [Out] IReadOnlyList<BCOJHLLCAJF> EACKEBINBEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7545400", Offset = "0x7543E00", VA = "0x187545400")]
	[AsyncStateMachine(typeof(PCOFNDAOIAM))]
	private static Task AHBHAKONMBM(DKMBOLLBJBK OJGCIJHDOOD, FNEPJCIGLHI GJLDCFIFFGA, IReadOnlyDictionary<AMGEEFGMLAH, GLOJKKCCNBO> GIBCPNDIPAL, MKDIGONPDGF KDKHLEEPODK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7546060", Offset = "0x7544A60", VA = "0x187546060")]
	[CompilerGenerated]
	internal static void ELJAGMDKEOL(Func<AKCLDOODBLL, GKMFGBOLGPD> DJDEIGBCCHE, MBDLHEOAIDH P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7549000", Offset = "0x7547A00", VA = "0x187549000")]
	[CompilerGenerated]
	internal static bool LBMOIFIDPKI(AMGEEFGMLAH FDNLCKEPNPK, BCOJHLLCAJF MPKBEEPNPKD, [Out] AENOLNFPAOH PIOMKAHAKJO, KMAMBDHEBNP P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface LFJLGLGKLGI
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FNFJENPBDLO(OGOAPNICIIH KLHAOEJKAAM, OGOAPNICIIH MFPPOLIACAP, IEnumerable<OGOAPNICIIH> CDMLOBEDPOO, [Out] PLNKGJFELAI IINEIMJLLEJ, [Out] HOJPPBJHACP EJGBLONDIBL);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string MBILNMABKEI(HOJPPBJHACP GMDCIFOMMGE);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public enum HOJPPBJHACP : byte
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
internal class POMLNHJPJKI : LFJLGLGKLGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly DGFNLKOMOMF DPDEDNKJIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly EPHHMNILCFF OFNKCLAKCGL;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x8BB0D0", Offset = "0x8B9AD0", VA = "0x1808BB0D0")]
	[RecRoom.NoEngine.Common.Preserve]
	public POMLNHJPJKI([CCLEDEMDDDH(null)] DGFNLKOMOMF ABIPCILAEPD, [CCLEDEMDDDH(null)] EPHHMNILCFF LNNCHKFDBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x754D720", Offset = "0x754C120", VA = "0x18754D720")]
	private static JIFONKHMGPA? JDDKCCBPLGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x754D620", Offset = "0x754C020", VA = "0x18754D620", Slot = "4")]
	public bool FNFJENPBDLO(OGOAPNICIIH KLHAOEJKAAM, OGOAPNICIIH MFPPOLIACAP, IEnumerable<OGOAPNICIIH> CDMLOBEDPOO, [Out] PLNKGJFELAI IINEIMJLLEJ, [Out] HOJPPBJHACP EJGBLONDIBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x754D760", Offset = "0x754C160", VA = "0x18754D760", Slot = "5")]
	public string MBILNMABKEI(HOJPPBJHACP GMDCIFOMMGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x754D000", Offset = "0x754BA00", VA = "0x18754D000")]
	internal bool DPEMLMJOPNC(OGOAPNICIIH KLHAOEJKAAM, OGOAPNICIIH MFPPOLIACAP, IEnumerable<OGOAPNICIIH> CDMLOBEDPOO, IJINIJPNMHJ ENLBBOBGKGH, JIFONKHMGPA? HHKIJPDPGMN, [Out] PLNKGJFELAI IINEIMJLLEJ, [Out] HOJPPBJHACP EJGBLONDIBL)
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
