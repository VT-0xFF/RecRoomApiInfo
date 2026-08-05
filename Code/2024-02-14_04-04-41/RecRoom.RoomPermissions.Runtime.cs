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
		[Cpp2IlInjected.Address(RVA = "0x7C7B20", Offset = "0x7C6F20", VA = "0x1807C7B20")]
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
		[Cpp2IlInjected.Address(RVA = "0x65653E0", Offset = "0x65647E0", VA = "0x1865653E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7C8560", Offset = "0x7C7960", VA = "0x1807C8560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C85A0", Offset = "0x7C79A0", VA = "0x1807C85A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum IEKMNGBBCLE
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void PPNKEHEGCHH<TPermission>(TPermission CHPGDLGEFLA);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void LHIFAGCKAAH(PFJNLKLKGNM LGJIBLMCMPJ);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum GFINNKGCEKC
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NEPLCPHLNEA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool HHNODKLMPCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool GHCEEFKNJAL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool AGLPAIHNGHC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool LOPDMHIFLPE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool NIFIOLKKEMN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool OMLIJEAAOCH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class LLIKOKKIMGO
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	public enum FDNNOFKLJJE
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
	public static readonly Guid MPDFFLAAJAA;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid MDGIDOKNDOD;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid EODCHKAMMLE;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid BCKBACENEOC;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid DOKOCJBEOCK;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid FHIOEFAAJMK;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly LJJFEELPDOG<LAKGBFEFJJG, Guid> CDFPKIDMGCO;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<LAKGBFEFJJG> BNGCJBHHIKF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6564D40", Offset = "0x6564140", VA = "0x186564D40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6564CB0", Offset = "0x65640B0", VA = "0x186564CB0")]
	public static LAKGBFEFJJG BBIAEHLDPGC(Guid INAIFGAIEKH)
	{
		return default(LAKGBFEFJJG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6564E50", Offset = "0x6564250", VA = "0x186564E50")]
	public static Guid FKMHKKNJPJF(LAKGBFEFJJG PJLDPPMCFPD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6564DC0", Offset = "0x65641C0", VA = "0x186564DC0")]
	public static bool BNJBFBKFCAN(LAKGBFEFJJG PJLDPPMCFPD, [Out] Guid INAIFGAIEKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6564EF0", Offset = "0x65642F0", VA = "0x186564EF0")]
	public static bool FPKKOMCAMKD(Guid INAIFGAIEKH, [Out] LAKGBFEFJJG PJLDPPMCFPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6565040", Offset = "0x6564440", VA = "0x186565040")]
	public static LAKGBFEFJJG JHMNADJDEOE(LAKGBFEFJJG PJLDPPMCFPD)
	{
		return default(LAKGBFEFJJG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6564F90", Offset = "0x6564390", VA = "0x186564F90")]
	public static FDNNOFKLJJE HFLKEPFADJI(LAKGBFEFJJG HJCODBFPCAO)
	{
		return default(FDNNOFKLJJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6565080", Offset = "0x6564480", VA = "0x186565080")]
	internal static LAKGBFEFJJG MOIJBLFGCIO(FDNNOFKLJJE OPAACOJDKKD)
	{
		return default(LAKGBFEFJJG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HOAGPNPPMPA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	JMFHMEIIHIC NBEKCDHIGOM
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<FOIGBDKDCGC> PFHMMHBELBM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event LHIFAGCKAAH KIJIIKKJDDE;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<FOIGBDKDCGC> OOCNGHPGENI(bool IJMANOFFLIF = false);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FOIGBDKDCGC DNPDIAFFHHH(PFJNLKLKGNM LGJIBLMCMPJ);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool FBAICOLKPGJ(PFJNLKLKGNM LGJIBLMCMPJ);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<FOIGBDKDCGC> ABKGACJKDFF(PFJNLKLKGNM LGJIBLMCMPJ, bool IHIECLGEADG = false);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool AIFHDDBABOO(PFJNLKLKGNM GLKBJKCIGIA, LAKGBFEFJJG PJLDPPMCFPD);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "9")]
	FOIGBDKDCGC KMELPGPFFAA(LAKGBFEFJJG PJLDPPMCFPD);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool KMGLIDLHPAO<T>(LAKGBFEFJJG PJLDPPMCFPD, MJBBGEOOPDL CHPGDLGEFLA, bool MBOBIPBNHLD, T OEJAGOPNKOK, [Optional] Action NJDICHKLFLK) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GNOAOCBKBBC
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task HPIGGANCMLB(JFMKOBKPDPB ILKGBPMJIJM, CancellationToken HNLFPBLPOKJ);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ILFCBGILJGK(JFMKOBKPDPB ILKGBPMJIJM);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface MHCJOKEICFG
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	PFJNLKLKGNM FBGNALHLIMK
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	JGNOMFHEEPM HEIEHBINHOD
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	KLIMJDPIFED KBDLGJIMNKM
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<CFPLJBHGPIJ> OAPFJJMNCCH;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action GOADJHMHJCG;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LAKGBFEFJJG IFECLBEGAFB(PFJNLKLKGNM LGJIBLMCMPJ);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<CFPLJBHGPIJ> OIHOBGCFLGA(CancellationToken HNLFPBLPOKJ);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task DAMHMMECOEL(long MAONELICPNP, long PHJIFAMIALG, IReadOnlyList<LHCHMAONNDG> EEBNEGPEMEL);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<PFJNLKLKGNM> DEJFEPHJNAP();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class FGDFBBAEOHM
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x655F1E0", Offset = "0x655E5E0", VA = "0x18655F1E0")]
	public static LAKGBFEFJJG GKLGHGFHLAH(this MHCJOKEICFG HJMCLOOJOIK)
	{
		return default(LAKGBFEFJJG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface DHLKPJKPNPC<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string HJAODGCPFMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event PPNKEHEGCHH<TPermission> MFBPAMOENGF;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class LEHIFCNFPDJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? IOJGLCCLGOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x79F200", Offset = "0x79E600", VA = "0x18079F200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x79F440", Offset = "0x79E840", VA = "0x18079F440")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7ABBD0", Offset = "0x7AAFD0", VA = "0x1807ABBD0")]
	protected LEHIFCNFPDJ(object? MIPFILJOKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool JDFDGIMGDPK(object? FDFHGIHHGHO);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class IIEGNOLJEAG<T> : LEHIFCNFPDJ where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private T AHFBPKJJHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly IEqualityComparer<T> GHLKMAKNHEH;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T NAJOFLHMBPO
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x80D7C0", Offset = "0x80CBC0", VA = "0x18080D7C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x37A6430", Offset = "0x37A5830", VA = "0x1837A6430", Slot = "4")]
	public override bool JDFDGIMGDPK(object? FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x37A6000", Offset = "0x37A5400", VA = "0x1837A6000")]
	public bool GPECNKDFLFJ(T LEMEKPKOOGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x37A6800", Offset = "0x37A5C00", VA = "0x1837A6800")]
	public IIEGNOLJEAG(T EOMOMDHMMPP, IEqualityComparer<T> GHLKMAKNHEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class LAIJGBOGNMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<MJBBGEOOPDL, bool> CGLLKNGLJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<MJBBGEOOPDL, LEHIFCNFPDJ> MJMONNFCEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly JGIKNCLFMOB ELFKPIFMICN;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x65643E0", Offset = "0x65637E0", VA = "0x1865643E0")]
	public LAIJGBOGNMH(JGIKNCLFMOB ELFKPIFMICN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6564170", Offset = "0x6563570", VA = "0x186564170")]
	public bool NDLKEHCHIJA(MJBBGEOOPDL CHPGDLGEFLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x26EB040", Offset = "0x26EA440", VA = "0x1826EB040")]
	public bool LLHCLBIPAKB<T>(MJBBGEOOPDL CHPGDLGEFLA, bool MBOBIPBNHLD, T FDFHGIHHGHO) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x26EAC70", Offset = "0x26EA070", VA = "0x1826EAC70")]
	public (bool, T?) IKMPGCOMOCN<T>(MJBBGEOOPDL CHPGDLGEFLA) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6564090", Offset = "0x6563490", VA = "0x186564090")]
	public bool LLHCLBIPAKB(MJBBGEOOPDL CHPGDLGEFLA, bool MBOBIPBNHLD, object FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6563FC0", Offset = "0x65633C0", VA = "0x186563FC0")]
	public (bool, object) IKMPGCOMOCN(MJBBGEOOPDL CHPGDLGEFLA)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x26EAC30", Offset = "0x26EA030", VA = "0x1826EAC30")]
	private void GHHEKFJDKAK<T>(MJBBGEOOPDL CHPGDLGEFLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6563EF0", Offset = "0x65632F0", VA = "0x186563EF0")]
	private LEHIFCNFPDJ DPFEGBFPGNI(MJBBGEOOPDL CHPGDLGEFLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x65641E0", Offset = "0x65635E0", VA = "0x1865641E0")]
	public void OCPAELPKGAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class BGCMIHJLGCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly string MIDBIBPCHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly Type MOPLBPMEABL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly KMHKJOIGADB NEFKJICOLME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly MJBBGEOOPDL EOACOCJDELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public LBECCLJOHMG JPAFKIMKBAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public OBIAKBFBAPN BIMIDBMCEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NMMONHAJJHH PNKDHBOEKKO;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x655E600", Offset = "0x655DA00", VA = "0x18655E600")]
	public BGCMIHJLGCA(Type DBIOIHCEENB, string CNNLEGFEEFC, MJBBGEOOPDL CHPGDLGEFLA, LBECCLJOHMG BEOFFOKHHKI, OBIAKBFBAPN BPLEOLEPIOF, NMMONHAJJHH MEOGMAHDIEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x655E500", Offset = "0x655D900", VA = "0x18655E500")]
	public object DOEABBNMDMK(object? AAMIMDAKFMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2437920", Offset = "0x2436D20", VA = "0x182437920")]
	public void GHHEKFJDKAK<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x655E550", Offset = "0x655D950", VA = "0x18655E550")]
	public void GHHEKFJDKAK(Type GGCKDOPPCKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class IIABAIKPEDL<T> : BGCMIHJLGCA where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string EHMCDGCEGFI(T FDFHGIHHGHO);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T ENODGDHMDAM(string? FGMAHDGIKHJ, T EOMOMDHMMPP);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class MJFFPOHCNFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public EHMCDGCEGFI serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public ENODGDHMDAM parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public MJFFPOHCNFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3D72CC0", Offset = "0x3D720C0", VA = "0x183D72CC0")]
		internal string GOCEDAKMJLI(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3D72B10", Offset = "0x3D71F10", VA = "0x183D72B10")]
		internal object GGEFPLMPLFI(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x37A5360", Offset = "0x37A4760", VA = "0x1837A5360")]
	public IIABAIKPEDL(MJBBGEOOPDL CHPGDLGEFLA, string CNNLEGFEEFC, [Optional] EHMCDGCEGFI? BEOFFOKHHKI, [Optional] ENODGDHMDAM? BPLEOLEPIOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x37A3F30", Offset = "0x37A3330", VA = "0x1837A3F30")]
	private static object? AFFCBAMFOKP(ENODGDHMDAM? BPLEOLEPIOF, string? FGMAHDGIKHJ, object? EOMOMDHMMPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x37A4A40", Offset = "0x37A3E40", VA = "0x1837A4A40")]
	private static string LENOCDGJGPN(EHMCDGCEGFI? AKEBNOALJND, object? FDFHGIHHGHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string LBECCLJOHMG(object? FDFHGIHHGHO);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object OBIAKBFBAPN(string? FGMAHDGIKHJ, [Optional] object EOMOMDHMMPP);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate LEHIFCNFPDJ NMMONHAJJHH();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class JGIKNCLFMOB
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class GDGLJGCGAIA : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal static GDGLJGCGAIA MEGHANKAOBP;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x655FFB0", Offset = "0x655F3B0", VA = "0x18655FFB0", Slot = "4")]
		public bool Equals(List<string> LGHEBJJLAGD, List<string> FGIFEPPMILE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6560100", Offset = "0x655F500", VA = "0x186560100", Slot = "5")]
		public int GetHashCode(List<string> MBCPMMHPENP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public GDGLJGCGAIA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class LDJCHINLNFA : LGGBFJGBDAO<IEKMNGBBCLE>
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6564870", Offset = "0x6563C70", VA = "0x186564870", Slot = "9")]
		public override string LENOCDGJGPN(IEKMNGBBCLE KODNHMICLEA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6564690", Offset = "0x6563A90", VA = "0x186564690", Slot = "10")]
		protected override bool DOAJJNLJPMF(string KODNHMICLEA, [Out] IEKMNGBBCLE FDFHGIHHGHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6564960", Offset = "0x6563D60", VA = "0x186564960")]
		public LDJCHINLNFA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly FMJGAEKCKMK HIODANFPOHD;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly LDJCHINLNFA GMONGPLDOAD;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly List<BGCMIHJLGCA> PAHNFLPDMEA;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<MJBBGEOOPDL> EKAKIPDCEDI
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x79F200", Offset = "0x79E600", VA = "0x18079F200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<MJBBGEOOPDL, BGCMIHJLGCA> CPMOIHJKMPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6563BA0", Offset = "0x6562FA0", VA = "0x186563BA0")]
	public JGIKNCLFMOB([Optional] IList<BGCMIHJLGCA>? EMCOCECPENP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6562D30", Offset = "0x6562130", VA = "0x186562D30")]
	public BGCMIHJLGCA JGNHKDNEFKH(MJBBGEOOPDL CHPGDLGEFLA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface JMFHMEIIHIC
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	FOIGBDKDCGC LLEHCANPFJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class CCBDMGKMDEO : JMFHMEIIHIC
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static CCBDMGKMDEO FCMFPNAKHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly HIKELINCDPF GEKBGKBICKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal readonly IReadOnlyList<HIKELINCDPF> IGNHBJCENDH;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public FOIGBDKDCGC LLEHCANPFJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x79F200", Offset = "0x79E600", VA = "0x18079F200", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x655F0D0", Offset = "0x655E4D0", VA = "0x18655F0D0")]
	public CCBDMGKMDEO(HIKELINCDPF JMMJKPPJPBC, IReadOnlyList<HIKELINCDPF> ODBJLAHFGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x655E6A0", Offset = "0x655DAA0", VA = "0x18655E6A0")]
	private static CCBDMGKMDEO EGJGIMOLAAO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class LLDJMEDEKMB
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<LAKGBFEFJJG> DKDBMBFMKBK;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x65649A0", Offset = "0x6563DA0", VA = "0x1865649A0")]
	public static bool KPMEIHOPGDG(this PFJNLKLKGNM MGJLCIFAFPP, LAKGBFEFJJG PJLDPPMCFPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6564A80", Offset = "0x6563E80", VA = "0x186564A80")]
	public static bool MAABOMJMIOO(this PFJNLKLKGNM MGJLCIFAFPP, LAKGBFEFJJG PJLDPPMCFPD, KLIMJDPIFED APNFAAKEKHN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface LBPPIOEDKID
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool LNPBLEGEEFD
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool ALAGKHPGJGI
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool GPFEBNLBDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool APFEJHNBPOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool KJDOCAMOGFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool MIPNKCCALKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool HOBODCCKACP
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool DAINIGBLGAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool NMPPEEGCPEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool IDDBODDJOOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool LACCAMNONCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool NDOBMKPHDNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> OJNBILNACIB
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	IEKMNGBBCLE FNJILAHILOG
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface FOIGBDKDCGC : LBPPIOEDKID, NEPLCPHLNEA, DHLKPJKPNPC<MJBBGEOOPDL>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string CLGFLGCOKCC
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	LAKGBFEFJJG GJOHDGDCKCP
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) LLFGPPBLDHB<T>(MJBBGEOOPDL CHPGDLGEFLA) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum MJBBGEOOPDL
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
internal class HIKELINCDPF : FOIGBDKDCGC, LBPPIOEDKID, NEPLCPHLNEA, DHLKPJKPNPC<MJBBGEOOPDL>
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal static readonly JGIKNCLFMOB KAAOELNBEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly LAIJGBOGNMH AMOIGNGJGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private string? HCMHAMEHAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private string? IKNCGBDDFCB;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool OIDFELNJKNA
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6560D60", Offset = "0x6560160", VA = "0x186560D60", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool FIHIMAMHFID
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6560E10", Offset = "0x6560210", VA = "0x186560E10", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool HMGMKEIJLDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6560EB0", Offset = "0x65602B0", VA = "0x186560EB0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool JEODOOBGMJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6560E60", Offset = "0x6560260", VA = "0x186560E60", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool GCBKLCOFLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6562040", Offset = "0x6561440", VA = "0x186562040", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool CEBDBCEPOLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6560D10", Offset = "0x6560110", VA = "0x186560D10", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public LAKGBFEFJJG GJOHDGDCKCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x80D7C0", Offset = "0x80CBC0", VA = "0x18080D7C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(LAKGBFEFJJG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7A6180", Offset = "0x7A5580", VA = "0x1807A6180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string HJAODGCPFMF
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6560F00", Offset = "0x6560300", VA = "0x186560F00", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6560C70", Offset = "0x6560070", VA = "0x186560C70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string CLGFLGCOKCC
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6560F00", Offset = "0x6560300", VA = "0x186560F00", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool GJEMJHALMEI
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x884CC0", Offset = "0x8840C0", VA = "0x180884CC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8845B0", Offset = "0x8839B0", VA = "0x1808845B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool LNPBLEGEEFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6560F50", Offset = "0x6560350", VA = "0x186560F50", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IEKMNGBBCLE FNJILAHILOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6561D00", Offset = "0x6561100", VA = "0x186561D00", Slot = "20")]
		get
		{
			return default(IEKMNGBBCLE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool ALAGKHPGJGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6561330", Offset = "0x6560730", VA = "0x186561330", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool GPFEBNLBDNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6561420", Offset = "0x6560820", VA = "0x186561420", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool APFEJHNBPOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x65621C0", Offset = "0x65615C0", VA = "0x1865621C0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool KJDOCAMOGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6560CC0", Offset = "0x65600C0", VA = "0x186560CC0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool MIPNKCCALKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6562170", Offset = "0x6561570", VA = "0x186562170", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool HOBODCCKACP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6561CB0", Offset = "0x65610B0", VA = "0x186561CB0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool DAINIGBLGAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x65613D0", Offset = "0x65607D0", VA = "0x1865613D0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool NMPPEEGCPEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6561150", Offset = "0x6560550", VA = "0x186561150", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> OJNBILNACIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6560DB0", Offset = "0x65601B0", VA = "0x186560DB0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool AOCMAFDBOOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6560D60", Offset = "0x6560160", VA = "0x186560D60", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool PLIDGFLLDOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6562040", Offset = "0x6561440", VA = "0x186562040", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool EKIKJPAHLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6560E10", Offset = "0x6560210", VA = "0x186560E10", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool IDDBODDJOOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6561470", Offset = "0x6560870", VA = "0x186561470", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool LACCAMNONCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x65611A0", Offset = "0x65605A0", VA = "0x1865611A0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool INJCICBJICL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6560EB0", Offset = "0x65602B0", VA = "0x186560EB0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool NDOBMKPHDNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6561380", Offset = "0x6560780", VA = "0x186561380", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool NIDECELLOPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6560E60", Offset = "0x6560260", VA = "0x186560E60", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool CDAIKAFNDNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6560D10", Offset = "0x6560110", VA = "0x186560D10", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event PPNKEHEGCHH<MJBBGEOOPDL> MFBPAMOENGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6561280", Offset = "0x6560680", VA = "0x186561280", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x65610A0", Offset = "0x65604A0", VA = "0x1865610A0", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2649CC0", Offset = "0x26490C0", VA = "0x182649CC0", Slot = "6")]
	public (bool, T?) LLFGPPBLDHB<T>(MJBBGEOOPDL CHPGDLGEFLA) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2649C80", Offset = "0x2649080", VA = "0x182649C80")]
	public HIKELINCDPF LIIHFDIFIHF<T>(MJBBGEOOPDL CHPGDLGEFLA, bool MBOBIPBNHLD, T FDFHGIHHGHO) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6562350", Offset = "0x6561750", VA = "0x186562350")]
	public HIKELINCDPF(LAKGBFEFJJG PJLDPPMCFPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x65622A0", Offset = "0x65616A0", VA = "0x1865622A0")]
	public HIKELINCDPF(LAKGBFEFJJG PJLDPPMCFPD, [Optional] string? HCMHAMEHAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x65622C0", Offset = "0x65616C0", VA = "0x1865622C0")]
	public HIKELINCDPF(HIKELINCDPF GOKJBFGEGPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6562370", Offset = "0x6561770", VA = "0x186562370")]
	internal HIKELINCDPF(LAKGBFEFJJG AGINOENPFEB, [Optional] string? HCMHAMEHAAB, [Optional] HIKELINCDPF? GOKJBFGEGPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6561DA0", Offset = "0x65611A0", VA = "0x186561DA0")]
	public static KMHKJOIGADB MKLNNHOGBFF(MJBBGEOOPDL CHPGDLGEFLA)
	{
		return default(KMHKJOIGADB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6562020", Offset = "0x6561420", VA = "0x186562020")]
	public void OCPAELPKGAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x65614C0", Offset = "0x65608C0", VA = "0x1865614C0")]
	internal HIKELINCDPF KOAPJIPKLFK(HIKELINCDPF CHIBGGOJEFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6561840", Offset = "0x6560C40", VA = "0x186561840")]
	internal IReadOnlyCollection<MJBBGEOOPDL> LEIGIPOJOGD(HIKELINCDPF GOKJBFGEGPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6562090", Offset = "0x6561490", VA = "0x186562090")]
	public bool OOIOGAMKCKN(MJBBGEOOPDL CHPGDLGEFLA, bool MBOBIPBNHLD, string FKDOAIPKOPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6560FA0", Offset = "0x65603A0", VA = "0x186560FA0")]
	public (bool, string) DGEOPKKPOKN(MJBBGEOOPDL CHPGDLGEFLA)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6561D50", Offset = "0x6561150", VA = "0x186561D50")]
	internal void MGMOMPFAHDE(MJBBGEOOPDL CHPGDLGEFLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6561E20", Offset = "0x6561220", VA = "0x186561E20")]
	public HFAMGDPMMHE MOEDOIBIGBN(Func<LAKGBFEFJJG, Guid> MHLJHBJLFDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x65602F0", Offset = "0x655F6F0", VA = "0x1865602F0")]
	public void AAEJPKGGHAD(HFAMGDPMMHE NMNOHKCNNBG, Func<Guid, LAKGBFEFJJG> KBPAOLHGMOF, [Optional] LAKGBFEFJJG? GDOFJPIDFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x65611F0", Offset = "0x65605F0", VA = "0x1865611F0")]
	[CompilerGenerated]
	private void ELACAOOLMFM(MJBBGEOOPDL LEJKOGIMCHA, JHJDKLEPOMM DEKLMDIKHNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class AGEPOJCMBLJ : GNOAOCBKBBC, HOAGPNPPMPA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class POJIHCGJOIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public HIKELINCDPF newRole;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public POJIHCGJOIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6565470", Offset = "0x6564870", VA = "0x186565470")]
		internal bool LEODDLLANHM(HIKELINCDPF rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class OONNNPBDNKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public LAKGBFEFJJG roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public OONNNPBDNKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6565460", Offset = "0x6564860", VA = "0x186565460")]
		internal bool FLOJNJPNNFN(LAKGBFEFJJG r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct BEEDAFBOJHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AGEPOJCMBLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public JFMKOBKPDPB roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<CFPLJBHGPIJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x655DE40", Offset = "0x655D240", VA = "0x18655DE40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x655E4A0", Offset = "0x655D8A0", VA = "0x18655E4A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class GAHAELLDJAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public GAHAELLDJAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x655FDB0", Offset = "0x655F1B0", VA = "0x18655FDB0")]
		internal void HOCPDIKCDAJ(HFAMGDPMMHE r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x655FE90", Offset = "0x655F290", VA = "0x18655FE90")]
		internal void OKNEEDEJKFN(HFAMGDPMMHE r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct JDHHGHKMIMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public JFMKOBKPDPB roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class AGDPEIJGGKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Func<HFAMGDPMMHE, JHJDKLEPOMM> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public AGDPEIJGGKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6558380", Offset = "0x6557780", VA = "0x186558380")]
		internal void FFKKMMMCDIK(HFAMGDPMMHE r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6558350", Offset = "0x6557750", VA = "0x186558350")]
		internal void ECCIKFGCCNP(HFAMGDPMMHE r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6558320", Offset = "0x6557720", VA = "0x186558320")]
		internal void CCONDOPLDLJ(HFAMGDPMMHE r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class MLEFKJLLOEM<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private struct <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public MLEFKJLLOEM<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private TaskAwaiter<CFPLJBHGPIJ> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x3003220", Offset = "0x3002620", VA = "0x183003220", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x90BA80", Offset = "0x90AE80", VA = "0x18090BA80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public AGEPOJCMBLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public MJBBGEOOPDL rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public LAKGBFEFJJG accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public KMHKJOIGADB recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public MLEFKJLLOEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3D90B00", Offset = "0x3D8FF00", VA = "0x183D90B00")]
		[AsyncStateMachine(typeof(MLEFKJLLOEM<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void HOOENCMMAFO()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct AADDJMONMLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public IReadOnlyList<LHCHMAONNDG> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct FKAKNDBDOMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public MHCJOKEICFG rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public JFMKOBKPDPB roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public IReadOnlyDictionary<LAKGBFEFJJG, HIKELINCDPF> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public DICBJLADGGD debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x655F240", Offset = "0x655E640", VA = "0x18655F240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x655FD50", Offset = "0x655F150", VA = "0x18655FD50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly MHCJOKEICFG HJMCLOOJOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly CCBDMGKMDEO KHJHJIMLHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly DICBJLADGGD FBGDNMEEBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, HIKELINCDPF> NFDAMCKGFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	internal readonly Dictionary<LAKGBFEFJJG, HIKELINCDPF> FHJEKALHFPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal readonly Dictionary<LAKGBFEFJJG, HIKELINCDPF> EGBMHJAPEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	internal readonly List<HIKELINCDPF> LLKFIFBPJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool EFABJANMBAK;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly MJBBGEOOPDL[] NCGHGLIJDCF;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public JMFHMEIIHIC NBEKCDHIGOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<FOIGBDKDCGC> PFHMMHBELBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x655CCF0", Offset = "0x655C0F0", VA = "0x18655CCF0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event LHIFAGCKAAH KIJIIKKJDDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6559200", Offset = "0x6558600", VA = "0x186559200", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6559020", Offset = "0x6558420", VA = "0x186559020", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6558E60", Offset = "0x6558260", VA = "0x186558E60")]
	[NEHHKLCIMGL(DIKIGLGFNNP.Room, OJLOCLENGNC.None)]
	private static void FBKBONBGGCH(BHJKECHLECD EAJOHJPGIHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x655DB80", Offset = "0x655CF80", VA = "0x18655DB80")]
	[UnityEngine.Scripting.Preserve]
	internal AGEPOJCMBLJ([CNGDHLLDFHE(null)] MHCJOKEICFG AMENHMLCAAD, [CNGDHLLDFHE(null)] CCBDMGKMDEO BFCFEDLEKKK, [CNGDHLLDFHE(null)] DICBJLADGGD FBGDNMEEBLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6558C80", Offset = "0x6558080", VA = "0x186558C80", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x655D090", Offset = "0x655C490", VA = "0x18655D090")]
	private void NKGEKJNAJOJ(IEnumerable<HIKELINCDPF> MKPJOAECAGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6558D90", Offset = "0x6558190", VA = "0x186558D90", Slot = "12")]
	public bool FBAICOLKPGJ(PFJNLKLKGNM LGJIBLMCMPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x655A1D0", Offset = "0x65595D0", VA = "0x18655A1D0")]
	private void GOADJHMHJCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6559620", Offset = "0x6558A20", VA = "0x186559620")]
	private void FOECHJIPCMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x655D930", Offset = "0x655CD30", VA = "0x18655D930", Slot = "10")]
	public IReadOnlyList<FOIGBDKDCGC> OOCNGHPGENI(bool IJMANOFFLIF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6558B70", Offset = "0x6557F70", VA = "0x186558B70", Slot = "11")]
	public FOIGBDKDCGC DNPDIAFFHHH(PFJNLKLKGNM LGJIBLMCMPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6558AA0", Offset = "0x6557EA0", VA = "0x186558AA0")]
	private LAKGBFEFJJG DAFKJEMAKFH(PFJNLKLKGNM LGJIBLMCMPJ)
	{
		return default(LAKGBFEFJJG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x65583C0", Offset = "0x65577C0", VA = "0x1865583C0", Slot = "14")]
	public bool AIFHDDBABOO(PFJNLKLKGNM GLKBJKCIGIA, LAKGBFEFJJG PJLDPPMCFPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x655C4A0", Offset = "0x655B8A0", VA = "0x18655C4A0", Slot = "15")]
	public FOIGBDKDCGC KMELPGPFFAA(LAKGBFEFJJG PJLDPPMCFPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x655BD10", Offset = "0x655B110", VA = "0x18655BD10")]
	private static bool KDAHJFGHGPK(JBDFFBHIKNF OACJGOBNHGE, LAKGBFEFJJG PJLDPPMCFPD, [Out] HFAMGDPMMHE? NDAPKLPBFDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6559530", Offset = "0x6558930", VA = "0x186559530")]
	private static void FMHICEBPFAG(JBDFFBHIKNF OACJGOBNHGE, Action<HFAMGDPMMHE> KHFLJODHMHM, LAKGBFEFJJG NDHCEMFAAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x65592A0", Offset = "0x65586A0", VA = "0x1865592A0")]
	private static void FMHICEBPFAG(JBDFFBHIKNF OACJGOBNHGE, Action<HFAMGDPMMHE> KHFLJODHMHM, Predicate<LAKGBFEFJJG> OAGPPLBMLLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x655C540", Offset = "0x655B940", VA = "0x18655C540")]
	private void MCLFDDMBJPM(PFJNLKLKGNM LGJIBLMCMPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x655B650", Offset = "0x655AA50", VA = "0x18655B650", Slot = "4")]
	[AsyncStateMachine(typeof(BEEDAFBOJHE))]
	public Task HPIGGANCMLB([CanBeNull] JFMKOBKPDPB ILKGBPMJIJM, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "5")]
	public void ILFCBGILJGK(JFMKOBKPDPB ILKGBPMJIJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6558550", Offset = "0x6557950", VA = "0x186558550")]
	private void BLLDHNPNNOE(JBDFFBHIKNF LPJDLDGHADM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x655B770", Offset = "0x655AB70", VA = "0x18655B770")]
	internal static string IFNCMDFHCFP(MHCJOKEICFG HJMCLOOJOIK, JFMKOBKPDPB ILKGBPMJIJM, IReadOnlyDictionary<LAKGBFEFJJG, HIKELINCDPF> FHJEKALHFPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x655A1E0", Offset = "0x65595E0", VA = "0x18655A1E0")]
	private static void GPMEIHPLOMM(JFMKOBKPDPB ILKGBPMJIJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x655C150", Offset = "0x655B550", VA = "0x18655C150")]
	private static void KKEIPBKJDGI(JBDFFBHIKNF FOGDBIKICEH, IReadOnlyDictionary<LAKGBFEFJJG, HIKELINCDPF> FHJEKALHFPC, StringBuilder LFAAHLEDPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x655C040", Offset = "0x655B440", VA = "0x18655C040")]
	private static bool KJDLOJLDANC(string HDLKJFMDEBI, [Out] Guid KPAOMDJPJAH, [Out] LAKGBFEFJJG PJLDPPMCFPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x655C5B0", Offset = "0x655B9B0", VA = "0x18655C5B0")]
	private static void MDAHFBKEIIH(JFMKOBKPDPB ILKGBPMJIJM, StringBuilder LFAAHLEDPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2C05D30", Offset = "0x2C05130", VA = "0x182C05D30", Slot = "16")]
	public bool KMGLIDLHPAO<T>(LAKGBFEFJJG PJLDPPMCFPD, MJBBGEOOPDL CHPGDLGEFLA, bool MBOBIPBNHLD, T OEJAGOPNKOK, [Optional] Action NJDICHKLFLK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6558890", Offset = "0x6557C90", VA = "0x186558890")]
	private void CCBDCBPEIHC(LAKGBFEFJJG PJLDPPMCFPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x655D910", Offset = "0x655CD10", VA = "0x18655D910")]
	private bool NOEAAKANHFD(PFJNLKLKGNM LGJIBLMCMPJ, LAKGBFEFJJG PJLDPPMCFPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x655CD40", Offset = "0x655C140", VA = "0x18655CD40")]
	internal HIKELINCDPF NEBJFMAMMLM(PFJNLKLKGNM LGJIBLMCMPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x65583B0", Offset = "0x65577B0", VA = "0x1865583B0", Slot = "13")]
	public IReadOnlyList<FOIGBDKDCGC> ABKGACJKDFF(PFJNLKLKGNM LGJIBLMCMPJ, bool IHIECLGEADG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6559810", Offset = "0x6558C10", VA = "0x186559810")]
	internal IReadOnlyList<HIKELINCDPF> GEGLFODBDIJ(PFJNLKLKGNM LGJIBLMCMPJ, bool IHIECLGEADG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6559A40", Offset = "0x6558E40", VA = "0x186559A40")]
	private void GGAMJNHCMDB(CFPLJBHGPIJ JMGKGLDGKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x655B360", Offset = "0x655A760", VA = "0x18655B360")]
	private static bool HBPEGGICHBF(HIKELINCDPF NPBHAHJOGJG, IReadOnlyDictionary<LAKGBFEFJJG, HIKELINCDPF> FHJEKALHFPC, [Out] IReadOnlyList<MJBBGEOOPDL> AMDOLKNEFML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x65590C0", Offset = "0x65584C0", VA = "0x1865590C0")]
	[AsyncStateMachine(typeof(FKAKNDBDOMO))]
	private static Task FGIJPMIPKMN(MHCJOKEICFG HJMCLOOJOIK, JFMKOBKPDPB ILKGBPMJIJM, IReadOnlyDictionary<LAKGBFEFJJG, HIKELINCDPF> FHJEKALHFPC, DICBJLADGGD FBGDNMEEBLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x655BA70", Offset = "0x655AE70", VA = "0x18655BA70")]
	[CompilerGenerated]
	internal static void JBCHIHANOLJ(Func<HFAMGDPMMHE, JHJDKLEPOMM> HEOFGBELMON, JDHHGHKMIMG P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x655AFF0", Offset = "0x655A3F0", VA = "0x18655AFF0")]
	[CompilerGenerated]
	internal static bool HBDNHGKBPCI(LAKGBFEFJJG PJLDPPMCFPD, MJBBGEOOPDL CHPGDLGEFLA, [Out] LHCHMAONNDG DLLHOMEOMLF, AADDJMONMLJ P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface LBLKHEFOKHP
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JOLDAHAHCPG(PFJNLKLKGNM KHCKPGDBKPL, PFJNLKLKGNM JKJKHBLCNBJ, IEnumerable<PFJNLKLKGNM> GEDKKJDJKEH, [Out] IEKMNGBBCLE LLIJNNJEGNA, [Out] KIBHMEOCBHE DODHIPABCMI);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string GNOLLOLCCPF(KIBHMEOCBHE BMFLJGLHEHH);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum KIBHMEOCBHE : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	CantKickEventOrganizer,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	Broadcaster,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	GameInProgress,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	OpponentGameInProgress
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class IMOMLKJIOKL : LBLKHEFOKHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly HOAGPNPPMPA MLGAKAHNNII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly PKIDMIMIPIL NJEIEHJIMPJ;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7A6130", Offset = "0x7A5530", VA = "0x1807A6130")]
	[RecRoom.NoEngine.Common.Preserve]
	public IMOMLKJIOKL([CNGDHLLDFHE(null)] HOAGPNPPMPA AKOAPMEEPCC, [CNGDHLLDFHE(null)] PKIDMIMIPIL NGHNAFBFEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x65624D0", Offset = "0x65618D0", VA = "0x1865624D0")]
	private static CFOHKGFJLLN? ALPKPGBKMHD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6562C30", Offset = "0x6562030", VA = "0x186562C30", Slot = "4")]
	public bool JOLDAHAHCPG(PFJNLKLKGNM KHCKPGDBKPL, PFJNLKLKGNM JKJKHBLCNBJ, IEnumerable<PFJNLKLKGNM> GEDKKJDJKEH, [Out] IEKMNGBBCLE LLIJNNJEGNA, [Out] KIBHMEOCBHE DODHIPABCMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6562510", Offset = "0x6561910", VA = "0x186562510", Slot = "5")]
	public string GNOLLOLCCPF(KIBHMEOCBHE BMFLJGLHEHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6562610", Offset = "0x6561A10", VA = "0x186562610")]
	internal bool INNGPOCGILF(PFJNLKLKGNM KHCKPGDBKPL, PFJNLKLKGNM JKJKHBLCNBJ, IEnumerable<PFJNLKLKGNM> GEDKKJDJKEH, KLIMJDPIFED APNFAAKEKHN, CFOHKGFJLLN? LHPIOLOLAPM, [Out] IEKMNGBBCLE LLIJNNJEGNA, [Out] KIBHMEOCBHE DODHIPABCMI)
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
