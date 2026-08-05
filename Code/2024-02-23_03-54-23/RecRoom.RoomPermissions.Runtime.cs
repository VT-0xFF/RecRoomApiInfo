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
		[Cpp2IlInjected.Address(RVA = "0x7D1B20", Offset = "0x7D0520", VA = "0x1807D1B20")]
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
		[Cpp2IlInjected.Address(RVA = "0x65E41E0", Offset = "0x65E2BE0", VA = "0x1865E41E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D2560", Offset = "0x7D0F60", VA = "0x1807D2560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D25A0", Offset = "0x7D0FA0", VA = "0x1807D25A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x65E3B40", Offset = "0x65E2540", VA = "0x1865E3B40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x65E3AB0", Offset = "0x65E24B0", VA = "0x1865E3AB0")]
	public static LAKGBFEFJJG BBIAEHLDPGC(Guid INAIFGAIEKH)
	{
		return default(LAKGBFEFJJG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x65E3C50", Offset = "0x65E2650", VA = "0x1865E3C50")]
	public static Guid FKMHKKNJPJF(LAKGBFEFJJG PJLDPPMCFPD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x65E3BC0", Offset = "0x65E25C0", VA = "0x1865E3BC0")]
	public static bool BNJBFBKFCAN(LAKGBFEFJJG PJLDPPMCFPD, [Out] Guid INAIFGAIEKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x65E3CF0", Offset = "0x65E26F0", VA = "0x1865E3CF0")]
	public static bool FPKKOMCAMKD(Guid INAIFGAIEKH, [Out] LAKGBFEFJJG PJLDPPMCFPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x65E3E40", Offset = "0x65E2840", VA = "0x1865E3E40")]
	public static LAKGBFEFJJG JHMNADJDEOE(LAKGBFEFJJG PJLDPPMCFPD)
	{
		return default(LAKGBFEFJJG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x65E3D90", Offset = "0x65E2790", VA = "0x1865E3D90")]
	public static FDNNOFKLJJE HFLKEPFADJI(LAKGBFEFJJG HJCODBFPCAO)
	{
		return default(FDNNOFKLJJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x65E3E80", Offset = "0x65E2880", VA = "0x1865E3E80")]
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
	[Cpp2IlInjected.Address(RVA = "0x65DDFE0", Offset = "0x65DC9E0", VA = "0x1865DDFE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A9200", Offset = "0x7A7C00", VA = "0x1807A9200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7A9440", Offset = "0x7A7E40", VA = "0x1807A9440")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7B5BD0", Offset = "0x7B45D0", VA = "0x1807B5BD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x817570", Offset = "0x815F70", VA = "0x180817570")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x37DF980", Offset = "0x37DE380", VA = "0x1837DF980", Slot = "4")]
	public override bool JDFDGIMGDPK(object? FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x37DF550", Offset = "0x37DDF50", VA = "0x1837DF550")]
	public bool GPECNKDFLFJ(T LEMEKPKOOGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x37DFD50", Offset = "0x37DE750", VA = "0x1837DFD50")]
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
	[Cpp2IlInjected.Address(RVA = "0x65E31E0", Offset = "0x65E1BE0", VA = "0x1865E31E0")]
	public LAIJGBOGNMH(JGIKNCLFMOB ELFKPIFMICN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x65E2F70", Offset = "0x65E1970", VA = "0x1865E2F70")]
	public bool NDLKEHCHIJA(MJBBGEOOPDL CHPGDLGEFLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2741D70", Offset = "0x2740770", VA = "0x182741D70")]
	public bool LLHCLBIPAKB<T>(MJBBGEOOPDL CHPGDLGEFLA, bool MBOBIPBNHLD, T FDFHGIHHGHO) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x27419A0", Offset = "0x27403A0", VA = "0x1827419A0")]
	public (bool, T?) IKMPGCOMOCN<T>(MJBBGEOOPDL CHPGDLGEFLA) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x65E2E90", Offset = "0x65E1890", VA = "0x1865E2E90")]
	public bool LLHCLBIPAKB(MJBBGEOOPDL CHPGDLGEFLA, bool MBOBIPBNHLD, object FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x65E2DC0", Offset = "0x65E17C0", VA = "0x1865E2DC0")]
	public (bool, object) IKMPGCOMOCN(MJBBGEOOPDL CHPGDLGEFLA)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2741960", Offset = "0x2740360", VA = "0x182741960")]
	private void GHHEKFJDKAK<T>(MJBBGEOOPDL CHPGDLGEFLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x65E2CF0", Offset = "0x65E16F0", VA = "0x1865E2CF0")]
	private LEHIFCNFPDJ DPFEGBFPGNI(MJBBGEOOPDL CHPGDLGEFLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x65E2FE0", Offset = "0x65E19E0", VA = "0x1865E2FE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x65DD400", Offset = "0x65DBE00", VA = "0x1865DD400")]
	public BGCMIHJLGCA(Type DBIOIHCEENB, string CNNLEGFEEFC, MJBBGEOOPDL CHPGDLGEFLA, LBECCLJOHMG BEOFFOKHHKI, OBIAKBFBAPN BPLEOLEPIOF, NMMONHAJJHH MEOGMAHDIEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x65DD300", Offset = "0x65DBD00", VA = "0x1865DD300")]
	public object DOEABBNMDMK(object? AAMIMDAKFMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2489330", Offset = "0x2487D30", VA = "0x182489330")]
	public void GHHEKFJDKAK<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x65DD350", Offset = "0x65DBD50", VA = "0x1865DD350")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public MJFFPOHCNFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3DA90D0", Offset = "0x3DA7AD0", VA = "0x183DA90D0")]
		internal string GOCEDAKMJLI(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3DA8F20", Offset = "0x3DA7920", VA = "0x183DA8F20")]
		internal object GGEFPLMPLFI(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x37DE8B0", Offset = "0x37DD2B0", VA = "0x1837DE8B0")]
	public IIABAIKPEDL(MJBBGEOOPDL CHPGDLGEFLA, string CNNLEGFEEFC, [Optional] EHMCDGCEGFI? BEOFFOKHHKI, [Optional] ENODGDHMDAM? BPLEOLEPIOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x37DD480", Offset = "0x37DBE80", VA = "0x1837DD480")]
	private static object? AFFCBAMFOKP(ENODGDHMDAM? BPLEOLEPIOF, string? FGMAHDGIKHJ, object? EOMOMDHMMPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x37DDF90", Offset = "0x37DC990", VA = "0x1837DDF90")]
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
		[Cpp2IlInjected.Address(RVA = "0x65DEDB0", Offset = "0x65DD7B0", VA = "0x1865DEDB0", Slot = "4")]
		public bool Equals(List<string> LGHEBJJLAGD, List<string> FGIFEPPMILE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x65DEF00", Offset = "0x65DD900", VA = "0x1865DEF00", Slot = "5")]
		public int GetHashCode(List<string> MBCPMMHPENP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public GDGLJGCGAIA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class LDJCHINLNFA : LGGBFJGBDAO<IEKMNGBBCLE>
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x65E3670", Offset = "0x65E2070", VA = "0x1865E3670", Slot = "9")]
		public override string LENOCDGJGPN(IEKMNGBBCLE KODNHMICLEA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x65E3490", Offset = "0x65E1E90", VA = "0x1865E3490", Slot = "10")]
		protected override bool DOAJJNLJPMF(string KODNHMICLEA, [Out] IEKMNGBBCLE FDFHGIHHGHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x65E3760", Offset = "0x65E2160", VA = "0x1865E3760")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A9200", Offset = "0x7A7C00", VA = "0x1807A9200")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x65E29A0", Offset = "0x65E13A0", VA = "0x1865E29A0")]
	public JGIKNCLFMOB([Optional] IList<BGCMIHJLGCA>? EMCOCECPENP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x65E1B30", Offset = "0x65E0530", VA = "0x1865E1B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A9200", Offset = "0x7A7C00", VA = "0x1807A9200", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x65DDED0", Offset = "0x65DC8D0", VA = "0x1865DDED0")]
	public CCBDMGKMDEO(HIKELINCDPF JMMJKPPJPBC, IReadOnlyList<HIKELINCDPF> ODBJLAHFGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x65DD4A0", Offset = "0x65DBEA0", VA = "0x1865DD4A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x65E37A0", Offset = "0x65E21A0", VA = "0x1865E37A0")]
	public static bool KPMEIHOPGDG(this PFJNLKLKGNM MGJLCIFAFPP, LAKGBFEFJJG PJLDPPMCFPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x65E3880", Offset = "0x65E2280", VA = "0x1865E3880")]
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
		[Cpp2IlInjected.Address(RVA = "0x65DFB60", Offset = "0x65DE560", VA = "0x1865DFB60", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool FIHIMAMHFID
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x65DFC10", Offset = "0x65DE610", VA = "0x1865DFC10", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool HMGMKEIJLDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x65DFCB0", Offset = "0x65DE6B0", VA = "0x1865DFCB0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool JEODOOBGMJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x65DFC60", Offset = "0x65DE660", VA = "0x1865DFC60", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool GCBKLCOFLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x65E0E40", Offset = "0x65DF840", VA = "0x1865E0E40", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool CEBDBCEPOLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x65DFB10", Offset = "0x65DE510", VA = "0x1865DFB10", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public LAKGBFEFJJG GJOHDGDCKCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x817570", Offset = "0x815F70", VA = "0x180817570", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(LAKGBFEFJJG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7B0180", Offset = "0x7AEB80", VA = "0x1807B0180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string HJAODGCPFMF
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x65DFD00", Offset = "0x65DE700", VA = "0x1865DFD00", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x65DFA70", Offset = "0x65DE470", VA = "0x1865DFA70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string CLGFLGCOKCC
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x65DFD00", Offset = "0x65DE700", VA = "0x1865DFD00", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool GJEMJHALMEI
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8901C0", Offset = "0x88EBC0", VA = "0x1808901C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x88FAB0", Offset = "0x88E4B0", VA = "0x18088FAB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool LNPBLEGEEFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x65DFD50", Offset = "0x65DE750", VA = "0x1865DFD50", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IEKMNGBBCLE FNJILAHILOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x65E0B00", Offset = "0x65DF500", VA = "0x1865E0B00", Slot = "20")]
		get
		{
			return default(IEKMNGBBCLE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool ALAGKHPGJGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x65E0130", Offset = "0x65DEB30", VA = "0x1865E0130", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool GPFEBNLBDNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x65E0220", Offset = "0x65DEC20", VA = "0x1865E0220", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool APFEJHNBPOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x65E0FC0", Offset = "0x65DF9C0", VA = "0x1865E0FC0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool KJDOCAMOGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x65DFAC0", Offset = "0x65DE4C0", VA = "0x1865DFAC0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool MIPNKCCALKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x65E0F70", Offset = "0x65DF970", VA = "0x1865E0F70", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool HOBODCCKACP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x65E0AB0", Offset = "0x65DF4B0", VA = "0x1865E0AB0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool DAINIGBLGAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x65E01D0", Offset = "0x65DEBD0", VA = "0x1865E01D0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool NMPPEEGCPEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x65DFF50", Offset = "0x65DE950", VA = "0x1865DFF50", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> OJNBILNACIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x65DFBB0", Offset = "0x65DE5B0", VA = "0x1865DFBB0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool AOCMAFDBOOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x65DFB60", Offset = "0x65DE560", VA = "0x1865DFB60", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool PLIDGFLLDOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x65E0E40", Offset = "0x65DF840", VA = "0x1865E0E40", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool EKIKJPAHLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x65DFC10", Offset = "0x65DE610", VA = "0x1865DFC10", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool IDDBODDJOOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x65E0270", Offset = "0x65DEC70", VA = "0x1865E0270", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool LACCAMNONCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x65DFFA0", Offset = "0x65DE9A0", VA = "0x1865DFFA0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool INJCICBJICL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x65DFCB0", Offset = "0x65DE6B0", VA = "0x1865DFCB0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool NDOBMKPHDNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x65E0180", Offset = "0x65DEB80", VA = "0x1865E0180", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool NIDECELLOPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x65DFC60", Offset = "0x65DE660", VA = "0x1865DFC60", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool CDAIKAFNDNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x65DFB10", Offset = "0x65DE510", VA = "0x1865DFB10", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event PPNKEHEGCHH<MJBBGEOOPDL> MFBPAMOENGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x65E0080", Offset = "0x65DEA80", VA = "0x1865E0080", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x65DFEA0", Offset = "0x65DE8A0", VA = "0x1865DFEA0", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x269F0B0", Offset = "0x269DAB0", VA = "0x18269F0B0", Slot = "6")]
	public (bool, T?) LLFGPPBLDHB<T>(MJBBGEOOPDL CHPGDLGEFLA) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x269F070", Offset = "0x269DA70", VA = "0x18269F070")]
	public HIKELINCDPF LIIHFDIFIHF<T>(MJBBGEOOPDL CHPGDLGEFLA, bool MBOBIPBNHLD, T FDFHGIHHGHO) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x65E1150", Offset = "0x65DFB50", VA = "0x1865E1150")]
	public HIKELINCDPF(LAKGBFEFJJG PJLDPPMCFPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x65E10A0", Offset = "0x65DFAA0", VA = "0x1865E10A0")]
	public HIKELINCDPF(LAKGBFEFJJG PJLDPPMCFPD, [Optional] string? HCMHAMEHAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x65E10C0", Offset = "0x65DFAC0", VA = "0x1865E10C0")]
	public HIKELINCDPF(HIKELINCDPF GOKJBFGEGPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x65E1170", Offset = "0x65DFB70", VA = "0x1865E1170")]
	internal HIKELINCDPF(LAKGBFEFJJG AGINOENPFEB, [Optional] string? HCMHAMEHAAB, [Optional] HIKELINCDPF? GOKJBFGEGPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x65E0BA0", Offset = "0x65DF5A0", VA = "0x1865E0BA0")]
	public static KMHKJOIGADB MKLNNHOGBFF(MJBBGEOOPDL CHPGDLGEFLA)
	{
		return default(KMHKJOIGADB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x65E0E20", Offset = "0x65DF820", VA = "0x1865E0E20")]
	public void OCPAELPKGAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x65E02C0", Offset = "0x65DECC0", VA = "0x1865E02C0")]
	internal HIKELINCDPF KOAPJIPKLFK(HIKELINCDPF CHIBGGOJEFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x65E0640", Offset = "0x65DF040", VA = "0x1865E0640")]
	internal IReadOnlyCollection<MJBBGEOOPDL> LEIGIPOJOGD(HIKELINCDPF GOKJBFGEGPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x65E0E90", Offset = "0x65DF890", VA = "0x1865E0E90")]
	public bool OOIOGAMKCKN(MJBBGEOOPDL CHPGDLGEFLA, bool MBOBIPBNHLD, string FKDOAIPKOPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x65DFDA0", Offset = "0x65DE7A0", VA = "0x1865DFDA0")]
	public (bool, string) DGEOPKKPOKN(MJBBGEOOPDL CHPGDLGEFLA)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x65E0B50", Offset = "0x65DF550", VA = "0x1865E0B50")]
	internal void MGMOMPFAHDE(MJBBGEOOPDL CHPGDLGEFLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x65E0C20", Offset = "0x65DF620", VA = "0x1865E0C20")]
	public HFAMGDPMMHE MOEDOIBIGBN(Func<LAKGBFEFJJG, Guid> MHLJHBJLFDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x65DF0F0", Offset = "0x65DDAF0", VA = "0x1865DF0F0")]
	public void AAEJPKGGHAD(HFAMGDPMMHE NMNOHKCNNBG, Func<Guid, LAKGBFEFJJG> KBPAOLHGMOF, [Optional] LAKGBFEFJJG? GDOFJPIDFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x65DFFF0", Offset = "0x65DE9F0", VA = "0x1865DFFF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public POJIHCGJOIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x65E4270", Offset = "0x65E2C70", VA = "0x1865E4270")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public OONNNPBDNKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x65E4260", Offset = "0x65E2C60", VA = "0x1865E4260")]
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
		[Cpp2IlInjected.Address(RVA = "0x65DCC40", Offset = "0x65DB640", VA = "0x1865DCC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x65DD2A0", Offset = "0x65DBCA0", VA = "0x1865DD2A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public GAHAELLDJAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x65DEBB0", Offset = "0x65DD5B0", VA = "0x1865DEBB0")]
		internal void HOCPDIKCDAJ(HFAMGDPMMHE r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x65DEC90", Offset = "0x65DD690", VA = "0x1865DEC90")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public AGDPEIJGGKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x65D7180", Offset = "0x65D5B80", VA = "0x1865D7180")]
		internal void FFKKMMMCDIK(HFAMGDPMMHE r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x65D7150", Offset = "0x65D5B50", VA = "0x1865D7150")]
		internal void ECCIKFGCCNP(HFAMGDPMMHE r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x65D7120", Offset = "0x65D5B20", VA = "0x1865D7120")]
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
			[Cpp2IlInjected.Address(RVA = "0x302A7B0", Offset = "0x30291B0", VA = "0x18302A7B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x917090", Offset = "0x915A90", VA = "0x180917090", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public MLEFKJLLOEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3DC7030", Offset = "0x3DC5A30", VA = "0x183DC7030")]
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
		[Cpp2IlInjected.Address(RVA = "0x65DE040", Offset = "0x65DCA40", VA = "0x1865DE040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x65DEB50", Offset = "0x65DD550", VA = "0x1865DEB50", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<FOIGBDKDCGC> PFHMMHBELBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x65DBAF0", Offset = "0x65DA4F0", VA = "0x1865DBAF0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event LHIFAGCKAAH KIJIIKKJDDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x65D8000", Offset = "0x65D6A00", VA = "0x1865D8000", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x65D7E20", Offset = "0x65D6820", VA = "0x1865D7E20", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x65D7C60", Offset = "0x65D6660", VA = "0x1865D7C60")]
	[NEHHKLCIMGL(DIKIGLGFNNP.Room, OJLOCLENGNC.None)]
	private static void FBKBONBGGCH(BHJKECHLECD EAJOHJPGIHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x65DC980", Offset = "0x65DB380", VA = "0x1865DC980")]
	[UnityEngine.Scripting.Preserve]
	internal AGEPOJCMBLJ([CNGDHLLDFHE(null)] MHCJOKEICFG AMENHMLCAAD, [CNGDHLLDFHE(null)] CCBDMGKMDEO BFCFEDLEKKK, [CNGDHLLDFHE(null)] DICBJLADGGD FBGDNMEEBLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x65D7A80", Offset = "0x65D6480", VA = "0x1865D7A80", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x65DBE90", Offset = "0x65DA890", VA = "0x1865DBE90")]
	private void NKGEKJNAJOJ(IEnumerable<HIKELINCDPF> MKPJOAECAGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x65D7B90", Offset = "0x65D6590", VA = "0x1865D7B90", Slot = "12")]
	public bool FBAICOLKPGJ(PFJNLKLKGNM LGJIBLMCMPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x65D8FD0", Offset = "0x65D79D0", VA = "0x1865D8FD0")]
	private void GOADJHMHJCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x65D8420", Offset = "0x65D6E20", VA = "0x1865D8420")]
	private void FOECHJIPCMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x65DC730", Offset = "0x65DB130", VA = "0x1865DC730", Slot = "10")]
	public IReadOnlyList<FOIGBDKDCGC> OOCNGHPGENI(bool IJMANOFFLIF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x65D7970", Offset = "0x65D6370", VA = "0x1865D7970", Slot = "11")]
	public FOIGBDKDCGC DNPDIAFFHHH(PFJNLKLKGNM LGJIBLMCMPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x65D78A0", Offset = "0x65D62A0", VA = "0x1865D78A0")]
	private LAKGBFEFJJG DAFKJEMAKFH(PFJNLKLKGNM LGJIBLMCMPJ)
	{
		return default(LAKGBFEFJJG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x65D71C0", Offset = "0x65D5BC0", VA = "0x1865D71C0", Slot = "14")]
	public bool AIFHDDBABOO(PFJNLKLKGNM GLKBJKCIGIA, LAKGBFEFJJG PJLDPPMCFPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x65DB2A0", Offset = "0x65D9CA0", VA = "0x1865DB2A0", Slot = "15")]
	public FOIGBDKDCGC KMELPGPFFAA(LAKGBFEFJJG PJLDPPMCFPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x65DAB10", Offset = "0x65D9510", VA = "0x1865DAB10")]
	private static bool KDAHJFGHGPK(JBDFFBHIKNF OACJGOBNHGE, LAKGBFEFJJG PJLDPPMCFPD, [Out] HFAMGDPMMHE? NDAPKLPBFDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x65D8330", Offset = "0x65D6D30", VA = "0x1865D8330")]
	private static void FMHICEBPFAG(JBDFFBHIKNF OACJGOBNHGE, Action<HFAMGDPMMHE> KHFLJODHMHM, LAKGBFEFJJG NDHCEMFAAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x65D80A0", Offset = "0x65D6AA0", VA = "0x1865D80A0")]
	private static void FMHICEBPFAG(JBDFFBHIKNF OACJGOBNHGE, Action<HFAMGDPMMHE> KHFLJODHMHM, Predicate<LAKGBFEFJJG> OAGPPLBMLLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x65DB340", Offset = "0x65D9D40", VA = "0x1865DB340")]
	private void MCLFDDMBJPM(PFJNLKLKGNM LGJIBLMCMPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x65DA450", Offset = "0x65D8E50", VA = "0x1865DA450", Slot = "4")]
	[AsyncStateMachine(typeof(BEEDAFBOJHE))]
	public Task HPIGGANCMLB([CanBeNull] JFMKOBKPDPB ILKGBPMJIJM, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "5")]
	public void ILFCBGILJGK(JFMKOBKPDPB ILKGBPMJIJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x65D7350", Offset = "0x65D5D50", VA = "0x1865D7350")]
	private void BLLDHNPNNOE(JBDFFBHIKNF LPJDLDGHADM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x65DA570", Offset = "0x65D8F70", VA = "0x1865DA570")]
	internal static string IFNCMDFHCFP(MHCJOKEICFG HJMCLOOJOIK, JFMKOBKPDPB ILKGBPMJIJM, IReadOnlyDictionary<LAKGBFEFJJG, HIKELINCDPF> FHJEKALHFPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x65D8FE0", Offset = "0x65D79E0", VA = "0x1865D8FE0")]
	private static void GPMEIHPLOMM(JFMKOBKPDPB ILKGBPMJIJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x65DAF50", Offset = "0x65D9950", VA = "0x1865DAF50")]
	private static void KKEIPBKJDGI(JBDFFBHIKNF FOGDBIKICEH, IReadOnlyDictionary<LAKGBFEFJJG, HIKELINCDPF> FHJEKALHFPC, StringBuilder LFAAHLEDPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x65DAE40", Offset = "0x65D9840", VA = "0x1865DAE40")]
	private static bool KJDLOJLDANC(string HDLKJFMDEBI, [Out] Guid KPAOMDJPJAH, [Out] LAKGBFEFJJG PJLDPPMCFPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x65DB3B0", Offset = "0x65D9DB0", VA = "0x1865DB3B0")]
	private static void MDAHFBKEIIH(JFMKOBKPDPB ILKGBPMJIJM, StringBuilder LFAAHLEDPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2C5DC10", Offset = "0x2C5C610", VA = "0x182C5DC10", Slot = "16")]
	public bool KMGLIDLHPAO<T>(LAKGBFEFJJG PJLDPPMCFPD, MJBBGEOOPDL CHPGDLGEFLA, bool MBOBIPBNHLD, T OEJAGOPNKOK, [Optional] Action NJDICHKLFLK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x65D7690", Offset = "0x65D6090", VA = "0x1865D7690")]
	private void CCBDCBPEIHC(LAKGBFEFJJG PJLDPPMCFPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x65DC710", Offset = "0x65DB110", VA = "0x1865DC710")]
	private bool NOEAAKANHFD(PFJNLKLKGNM LGJIBLMCMPJ, LAKGBFEFJJG PJLDPPMCFPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x65DBB40", Offset = "0x65DA540", VA = "0x1865DBB40")]
	internal HIKELINCDPF NEBJFMAMMLM(PFJNLKLKGNM LGJIBLMCMPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x65D71B0", Offset = "0x65D5BB0", VA = "0x1865D71B0", Slot = "13")]
	public IReadOnlyList<FOIGBDKDCGC> ABKGACJKDFF(PFJNLKLKGNM LGJIBLMCMPJ, bool IHIECLGEADG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x65D8610", Offset = "0x65D7010", VA = "0x1865D8610")]
	internal IReadOnlyList<HIKELINCDPF> GEGLFODBDIJ(PFJNLKLKGNM LGJIBLMCMPJ, bool IHIECLGEADG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x65D8840", Offset = "0x65D7240", VA = "0x1865D8840")]
	private void GGAMJNHCMDB(CFPLJBHGPIJ JMGKGLDGKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x65DA160", Offset = "0x65D8B60", VA = "0x1865DA160")]
	private static bool HBPEGGICHBF(HIKELINCDPF NPBHAHJOGJG, IReadOnlyDictionary<LAKGBFEFJJG, HIKELINCDPF> FHJEKALHFPC, [Out] IReadOnlyList<MJBBGEOOPDL> AMDOLKNEFML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x65D7EC0", Offset = "0x65D68C0", VA = "0x1865D7EC0")]
	[AsyncStateMachine(typeof(FKAKNDBDOMO))]
	private static Task FGIJPMIPKMN(MHCJOKEICFG HJMCLOOJOIK, JFMKOBKPDPB ILKGBPMJIJM, IReadOnlyDictionary<LAKGBFEFJJG, HIKELINCDPF> FHJEKALHFPC, DICBJLADGGD FBGDNMEEBLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x65DA870", Offset = "0x65D9270", VA = "0x1865DA870")]
	[CompilerGenerated]
	internal static void JBCHIHANOLJ(Func<HFAMGDPMMHE, JHJDKLEPOMM> HEOFGBELMON, JDHHGHKMIMG P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x65D9DF0", Offset = "0x65D87F0", VA = "0x1865D9DF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7B0130", Offset = "0x7AEB30", VA = "0x1807B0130")]
	[RecRoom.NoEngine.Common.Preserve]
	public IMOMLKJIOKL([CNGDHLLDFHE(null)] HOAGPNPPMPA AKOAPMEEPCC, [CNGDHLLDFHE(null)] PKIDMIMIPIL NGHNAFBFEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x65E12D0", Offset = "0x65DFCD0", VA = "0x1865E12D0")]
	private static CFOHKGFJLLN? ALPKPGBKMHD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x65E1A30", Offset = "0x65E0430", VA = "0x1865E1A30", Slot = "4")]
	public bool JOLDAHAHCPG(PFJNLKLKGNM KHCKPGDBKPL, PFJNLKLKGNM JKJKHBLCNBJ, IEnumerable<PFJNLKLKGNM> GEDKKJDJKEH, [Out] IEKMNGBBCLE LLIJNNJEGNA, [Out] KIBHMEOCBHE DODHIPABCMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x65E1310", Offset = "0x65DFD10", VA = "0x1865E1310", Slot = "5")]
	public string GNOLLOLCCPF(KIBHMEOCBHE BMFLJGLHEHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x65E1410", Offset = "0x65DFE10", VA = "0x1865E1410")]
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
