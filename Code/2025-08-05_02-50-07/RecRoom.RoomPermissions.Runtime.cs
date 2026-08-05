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
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8BC6FF0", Offset = "0x8BC63F0", VA = "0x188BC6FF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA99B00", Offset = "0xA98F00", VA = "0x180A99B00")]
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
		[Cpp2IlInjected.Address(RVA = "0xA99B40", Offset = "0xA98F40", VA = "0x180A99B40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum NMDNLIPDECO
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
		[Cpp2IlInjected.Address(RVA = "0x8BC8570", Offset = "0x8BC7970", VA = "0x188BC8570", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x291FE80", Offset = "0x291F280", VA = "0x18291FE80")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void BEILDNEBCAK<TPermission>(TPermission ALNLOCPIMLG);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void PAMPELNEEED(NELIJLIGAOD NICGPJDLKCM);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum IHCNKBMCOJG
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface BJGDAHLOBLA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool OJFOCDCIKAF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool PBLEPMCKLDO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool INBOJMFJDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool IGDNNDOILOP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool JCGAEHGMGDE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool OMJGGFKLKNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool AEHNKAKLDMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class PKMKGLJPHJE
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum MHFHECJJKNI
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
	public static readonly Guid CIKBFNJDELA;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid BMMAEDLAMND;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid ALHAAABGCBN;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid ICNDIDEGPGC;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid AJHDDDKPLPP;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid LOCJFJKBCKA;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly DEEBLOMGOFL<JPNNICBILFM, Guid> MCDBAEOOIDC;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	internal static IEnumerable<JPNNICBILFM> HHKBOAPDBAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8BC73B0", Offset = "0x8BC67B0", VA = "0x188BC73B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8BC7430", Offset = "0x8BC6830", VA = "0x188BC7430")]
	public static JPNNICBILFM CHGHMJBMKPH(Guid OOOANFDGEED)
	{
		return default(JPNNICBILFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8BC75D0", Offset = "0x8BC69D0", VA = "0x188BC75D0")]
	public static Guid IPBPFJKDHJN(JPNNICBILFM MLGIIBEOGOM)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8BC74C0", Offset = "0x8BC68C0", VA = "0x188BC74C0")]
	public static bool COKFJOKIGIB(JPNNICBILFM MLGIIBEOGOM, [Out] Guid OOOANFDGEED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8BC7720", Offset = "0x8BC6B20", VA = "0x188BC7720")]
	public static bool OBLABKBKEML(Guid OOOANFDGEED, [Out] JPNNICBILFM MLGIIBEOGOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8BC7550", Offset = "0x8BC6950", VA = "0x188BC7550")]
	public static JPNNICBILFM HEOJAAGCCBL(JPNNICBILFM MLGIIBEOGOM)
	{
		return default(JPNNICBILFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8BC7670", Offset = "0x8BC6A70", VA = "0x188BC7670")]
	public static MHFHECJJKNI LKHBMFAHPNP(JPNNICBILFM HGLPPFOEBKB)
	{
		return default(MHFHECJJKNI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8BC7590", Offset = "0x8BC6990", VA = "0x188BC7590")]
	internal static JPNNICBILFM HIJCKOEBKOH(MHFHECJJKNI AIAKBJODGPP)
	{
		return default(JPNNICBILFM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BIJOCENLPAC
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	NELIJLIGAOD EAEIDFPEPEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	AAKDENBOOJG KMEJPIGBHKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	MBLNIACGJFP IHNDJFPJKPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<CAGIALDELDO> MHANKFFECIL;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action BDOHHNOGDEA;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JPNNICBILFM GOKIAPIHNDE(NELIJLIGAOD NICGPJDLKCM);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<CAGIALDELDO> AKGKBFMJFCJ(CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task NIBBBMEELLE(long DCONEHIDLCB, IReadOnlyList<APIPDLAENGJ> FHAKECLNNDH);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task JGHLAFFNALE(long DCONEHIDLCB, long OBCIDCBDAAN, IReadOnlyList<APIPDLAENGJ> FHAKECLNNDH);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<NELIJLIGAOD> JMNGGPDHDBI();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class LKOGIICNFGB
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8BC3ED0", Offset = "0x8BC32D0", VA = "0x188BC3ED0")]
	public static JPNNICBILFM ELEMMHDDNDM(this BIJOCENLPAC CHBKOBFBCOF)
	{
		return default(JPNNICBILFM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface CADPBKBPMON : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	LKOFNOOAJPB JHKNMMIOJKB
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event PAMPELNEEED NEGHMKBDHCB;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<KLOMHPDKBOJ> IDNEEHHAICA(bool GBHFLDFDLOI = false);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KLOMHPDKBOJ BKNCBODFOMA(NELIJLIGAOD NICGPJDLKCM);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool EPKDJLCJONM(NELIJLIGAOD NICGPJDLKCM);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IReadOnlyList<KLOMHPDKBOJ> EKDGBGPBKNF(NELIJLIGAOD NICGPJDLKCM, bool KHLKIKPCFBP = false);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool AEEGOONOFAO(NELIJLIGAOD HDJHIPBJBCO, JPNNICBILFM MLGIIBEOGOM);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KLOMHPDKBOJ DDFHMLMHJPJ(JPNNICBILFM MLGIIBEOGOM);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool LCIBNOEIECD<T>(JPNNICBILFM MLGIIBEOGOM, JBGEMEIIOHE ALNLOCPIMLG, bool PLJOEFBBPNA, T ALOONCIOJJM, [Optional] Action MLPCFEOMFOI) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string JPNDICFMIOM(JBGEMEIIOHE ALNLOCPIMLG);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool FLMGNGFJADE(NELIJLIGAOD NICGPJDLKCM, JBGEMEIIOHE BJDGKGEHBAJ);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface AIMABJGODNH
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task HNDLOFAHEFO(LCCHGCBPFIP PHIIDLOGBDN, CancellationToken GMKBGHHNCDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface KGEKLEGMKDH<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string OGKECCFBKFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event BEILDNEBCAK<TPermission> AEPKIOFACKC;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal abstract class HFHCMMGDBMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal object? BNIKKOFBKEJ;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? KCNAFAHNMAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8BBBDE0", Offset = "0x8BBB1E0", VA = "0x188BBBDE0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8BBBEC0", Offset = "0x8BBB2C0", VA = "0x188BBBEC0")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8BBBFC0", Offset = "0x8BBB3C0", VA = "0x188BBBFC0")]
	protected HFHCMMGDBMK(object? APNHGODFOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool OEOEKNMFCIO(object? CBMEHPPMEEA);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class IICIIFOBPMF<T> : HFHCMMGDBMK where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> LJGHFBEMAIK;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T JCMAOCOGHGO
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x50E24D0", Offset = "0x50E18D0", VA = "0x1850E24D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x50E2A40", Offset = "0x50E1E40", VA = "0x1850E2A40", Slot = "4")]
	public override bool OEOEKNMFCIO(object? CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x50E2080", Offset = "0x50E1480", VA = "0x1850E2080")]
	public bool DHDOFECEFIC(T DGDNBNNBLCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x50E2D20", Offset = "0x50E2120", VA = "0x1850E2D20")]
	public IICIIFOBPMF(T ABINAMGBLJP, IEqualityComparer<T> LJGHFBEMAIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class DLFJJEMNGPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<JBGEMEIIOHE, bool> OJEJJCHBNGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<JBGEMEIIOHE, HFHCMMGDBMK> CPIFOAHCJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly MOMKCKEOCOH ICMCNHHKNKH;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8BBBB10", Offset = "0x8BBAF10", VA = "0x188BBBB10")]
	public DLFJJEMNGPF(MOMKCKEOCOH ICMCNHHKNKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8BBB8C0", Offset = "0x8BBACC0", VA = "0x188BBB8C0")]
	public bool IBOGHIDPACE(JBGEMEIIOHE ALNLOCPIMLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3B12CE0", Offset = "0x3B120E0", VA = "0x183B12CE0")]
	public bool HMKMDBHODMI<T>(JBGEMEIIOHE ALNLOCPIMLG, bool PLJOEFBBPNA, T CBMEHPPMEEA) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3B12910", Offset = "0x3B11D10", VA = "0x183B12910")]
	public (bool, T?) CPLKHDBLDNB<T>(JBGEMEIIOHE ALNLOCPIMLG) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8BBB7E0", Offset = "0x8BBABE0", VA = "0x188BBB7E0")]
	public bool HMKMDBHODMI(JBGEMEIIOHE ALNLOCPIMLG, bool PLJOEFBBPNA, object CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8BBB640", Offset = "0x8BBAA40", VA = "0x188BBB640")]
	public (bool, object) CPLKHDBLDNB(JBGEMEIIOHE ALNLOCPIMLG)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3B131F0", Offset = "0x3B125F0", VA = "0x183B131F0")]
	private void NBINBADOFFD<T>(JBGEMEIIOHE ALNLOCPIMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8BBB570", Offset = "0x8BBA970", VA = "0x188BBB570")]
	private HFHCMMGDBMK AEGFPKGDHON(JBGEMEIIOHE ALNLOCPIMLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8BBB930", Offset = "0x8BBAD30", VA = "0x188BBB930")]
	public void KALKMKDNGKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class CHEDMMLCKHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string OPFNAEKCLPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type ADPHICHMAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly CPCGFNOCCHG FJPNJKOFCIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly JBGEMEIIOHE HMCINPCHONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public GNOMKDLACJD CDGNHDJLCDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public DCBJCHIENIE FFHPMLGMEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public HKBNCBPBFJE JAJHFLKHNAK;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8BB9830", Offset = "0x8BB8C30", VA = "0x188BB9830")]
	public CHEDMMLCKHB(Type PICPHMBNEOK, string IEFGJLNKNBK, JBGEMEIIOHE ALNLOCPIMLG, GNOMKDLACJD ELMNKMKLHMG, DCBJCHIENIE MCKLLGEJOAN, HKBNCBPBFJE HBEEEMAJBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8BB9730", Offset = "0x8BB8B30", VA = "0x188BB9730")]
	public object KONNNIKCAKI(object? LHDOHAKINKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3AA8750", Offset = "0x3AA7B50", VA = "0x183AA8750")]
	public void NBINBADOFFD<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8BB9780", Offset = "0x8BB8B80", VA = "0x188BB9780")]
	public void NBINBADOFFD(Type CAFOGCKLDDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class IIOFEJCBHLJ<T> : CHEDMMLCKHB where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate string DEDMHNHFHOO(T CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal delegate T PLFPPKCAHNI(string? EHAKNJINMHM, T ABINAMGBLJP);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class FKAINFNBKPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public DEDMHNHFHOO serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public PLFPPKCAHNI parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public FKAINFNBKPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4E9DAD0", Offset = "0x4E9CED0", VA = "0x184E9DAD0")]
		internal string CHCOOHFKFHN(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4E9DB60", Offset = "0x4E9CF60", VA = "0x184E9DB60")]
		internal object KAGNNAFOLGP(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x50E4B90", Offset = "0x50E3F90", VA = "0x1850E4B90")]
	public IIOFEJCBHLJ(JBGEMEIIOHE ALNLOCPIMLG, string IEFGJLNKNBK, [Optional] DEDMHNHFHOO? ELMNKMKLHMG, [Optional] PLFPPKCAHNI? MCKLLGEJOAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x50E3D00", Offset = "0x50E3100", VA = "0x1850E3D00")]
	private static object? DGFNGGGAAON(PLFPPKCAHNI? MCKLLGEJOAN, string? EHAKNJINMHM, object? ABINAMGBLJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x50E3A60", Offset = "0x50E2E60", VA = "0x1850E3A60")]
	private static string COFPFOKABJF(DEDMHNHFHOO? DHADIAKOJPN, object? CBMEHPPMEEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate string GNOMKDLACJD(object? CBMEHPPMEEA);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate object DCBJCHIENIE(string? EHAKNJINMHM, [Optional] object ABINAMGBLJP);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal delegate HFHCMMGDBMK HKBNCBPBFJE();
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class MOMKCKEOCOH
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class PCJPLLNFLJO : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static PCJPLLNFLJO NKAKNKMIPPI;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8BC7070", Offset = "0x8BC6470", VA = "0x188BC7070", Slot = "4")]
		public bool Equals(List<string> FNBJHADJBNG, List<string> MODFPFNICHM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8BC71C0", Offset = "0x8BC65C0", VA = "0x188BC71C0", Slot = "5")]
		public int GetHashCode(List<string> DEJGDIIDCDN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public PCJPLLNFLJO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class PLGJBJHPLOJ : HPHPBBLCFKI<NMDNLIPDECO>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8BC7AE0", Offset = "0x8BC6EE0", VA = "0x188BC7AE0", Slot = "9")]
		public override string COFPFOKABJF(NMDNLIPDECO MICKAKKPGLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8BC7BD0", Offset = "0x8BC6FD0", VA = "0x188BC7BD0", Slot = "10")]
		protected override bool KIPBFLFIHHN(string MICKAKKPGLH, [Out] NMDNLIPDECO CBMEHPPMEEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8BC7DA0", Offset = "0x8BC71A0", VA = "0x188BC7DA0")]
		public PLGJBJHPLOJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly AGIIPDJDKGP JJHKHDJDCEM;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly PLGJBJHPLOJ MDOPBGNEIHE;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<CHEDMMLCKHB> OEJDFFHJEFM;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<JBGEMEIIOHE> JILDEFHEIAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<JBGEMEIIOHE, CHEDMMLCKHB> GLODAKFMOIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8BC5D80", Offset = "0x8BC5180", VA = "0x188BC5D80")]
	public MOMKCKEOCOH([Optional] IList<CHEDMMLCKHB>? LAGPMLAAHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8BC3F30", Offset = "0x8BC3330", VA = "0x188BC3F30")]
	public CHEDMMLCKHB ILNMAEODGCE(JBGEMEIIOHE ALNLOCPIMLG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface LKOFNOOAJPB
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	KLOMHPDKBOJ CKOAAGNMCAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class IJCEJHBPHOB : LKOFNOOAJPB
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static IJCEJHBPHOB CFBEGGADELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly CMMKOKNMPJJ AOMEDIDLIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<CMMKOKNMPJJ> KLLDFHMKCKP;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public KLOMHPDKBOJ CKOAAGNMCAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8BC2EA0", Offset = "0x8BC22A0", VA = "0x188BC2EA0")]
	public IJCEJHBPHOB(CMMKOKNMPJJ BHDCAABILHK, IReadOnlyList<CMMKOKNMPJJ> PDLKDOEMNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8BC1D80", Offset = "0x8BC1180", VA = "0x188BC1D80")]
	private static IJCEJHBPHOB EOKDNEDNDJB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class NCMOAHEMKNN
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<JPNNICBILFM> NILPNMOAJDI;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8BC6C50", Offset = "0x8BC6050", VA = "0x188BC6C50")]
	public static bool BMADHJLDBML(this NELIJLIGAOD GHOBDALFLGI, JPNNICBILFM MLGIIBEOGOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8BC6D30", Offset = "0x8BC6130", VA = "0x188BC6D30")]
	public static bool KOLFOOPPLBG(this NELIJLIGAOD GHOBDALFLGI, JPNNICBILFM MLGIIBEOGOM, MBLNIACGJFP BABBGDPKJHL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface ACBFGGEKGPH
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	IReadOnlyList<string> GPJIBNPANAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	NMDNLIPDECO NJDFFNMCNNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface KLOMHPDKBOJ : ACBFGGEKGPH, BJGDAHLOBLA, KGEKLEGMKDH<JBGEMEIIOHE>
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	string LJNABPIIHAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	JPNNICBILFM GAPBGIMPKPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) ODLGDDHGAOE<T>(JBGEMEIIOHE ALNLOCPIMLG) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal class CMMKOKNMPJJ : KLOMHPDKBOJ, ACBFGGEKGPH, BJGDAHLOBLA, KGEKLEGMKDH<JBGEMEIIOHE>
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal static readonly MOMKCKEOCOH AGABGJENFIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal readonly DLFJJEMNGPF LHIDFAKGKGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private string? PIOIKDBGPHD;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private bool HHOGNAANKKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9ED0", Offset = "0x8BB92D0", VA = "0x188BB9ED0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool MFCGAIBJKLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9A10", Offset = "0x8BB8E10", VA = "0x188BB9A10", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool MMPKFIPLGBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9F20", Offset = "0x8BB9320", VA = "0x188BB9F20", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool OCONDCMIPBM
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9E00", Offset = "0x8BB9200", VA = "0x188BB9E00", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool PKJLOGGELJN
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8BBA0E0", Offset = "0x8BB94E0", VA = "0x188BBA0E0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool MBGLCJMGDKG
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8BBA020", Offset = "0x8BB9420", VA = "0x188BBA020", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private bool FAPCEOPCOBA
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9CB0", Offset = "0x8BB90B0", VA = "0x188BB9CB0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public JPNNICBILFM GAPBGIMPKPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xAC6D20", Offset = "0xAC6120", VA = "0x180AC6D20", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(JPNNICBILFM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA7DA60", Offset = "0xA7CE60", VA = "0x180A7DA60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public string OGKECCFBKFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8BBA070", Offset = "0x8BB9470", VA = "0x188BBA070", Slot = "18")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public string LJNABPIIHAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8BBA070", Offset = "0x8BB9470", VA = "0x188BBA070", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool IKKJJMIEGNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xA9C690", Offset = "0xA9BA90", VA = "0x180A9C690")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xA9C410", Offset = "0xA9B810", VA = "0x180A9C410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public NMDNLIPDECO NJDFFNMCNNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9C60", Offset = "0x8BB9060", VA = "0x188BB9C60", Slot = "8")]
		get
		{
			return default(NMDNLIPDECO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public IReadOnlyList<string> GPJIBNPANAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9F70", Offset = "0x8BB9370", VA = "0x188BB9F70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool BMJBMHMNCOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9ED0", Offset = "0x8BB92D0", VA = "0x188BB9ED0", Slot = "19")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool DENKAJAGMDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8BBA0E0", Offset = "0x8BB94E0", VA = "0x188BBA0E0", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool IBCPCHJCHMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9A10", Offset = "0x8BB8E10", VA = "0x188BB9A10", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool PKALOLCJMAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9F20", Offset = "0x8BB9320", VA = "0x188BB9F20", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool POEEOMLCLCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9E00", Offset = "0x8BB9200", VA = "0x188BB9E00", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool ICBEHCALLPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8BBA020", Offset = "0x8BB9420", VA = "0x188BBA020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool AILMAMKJKIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9CB0", Offset = "0x8BB90B0", VA = "0x188BB9CB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event BEILDNEBCAK<JBGEMEIIOHE> AEPKIOFACKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8BBAD80", Offset = "0x8BBA180", VA = "0x188BBAD80", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9960", Offset = "0x8BB8D60", VA = "0x188BB9960", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3AAD010", Offset = "0x3AAC410", VA = "0x183AAD010", Slot = "6")]
	public (bool, T?) ODLGDDHGAOE<T>(JBGEMEIIOHE ALNLOCPIMLG) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3AACFD0", Offset = "0x3AAC3D0", VA = "0x183AACFD0")]
	public CMMKOKNMPJJ IONNEMKPCIO<T>(JBGEMEIIOHE ALNLOCPIMLG, bool PLJOEFBBPNA, T CBMEHPPMEEA) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8BBB360", Offset = "0x8BBA760", VA = "0x188BBB360")]
	public CMMKOKNMPJJ(JPNNICBILFM MLGIIBEOGOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8BBB410", Offset = "0x8BBA810", VA = "0x188BBB410")]
	public CMMKOKNMPJJ(JPNNICBILFM MLGIIBEOGOM, [Optional] string? PIOIKDBGPHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8BBB380", Offset = "0x8BBA780", VA = "0x188BBB380")]
	public CMMKOKNMPJJ(CMMKOKNMPJJ POHEJPBANCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8BBB430", Offset = "0x8BBA830", VA = "0x188BBB430")]
	internal CMMKOKNMPJJ(JPNNICBILFM IKDIELBILBK, [Optional] string? PIOIKDBGPHD, [Optional] CMMKOKNMPJJ? POHEJPBANCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8BB9E50", Offset = "0x8BB9250", VA = "0x188BB9E50")]
	public static CPCGFNOCCHG EOHBLLIDNML(JBGEMEIIOHE ALNLOCPIMLG)
	{
		return default(CPCGFNOCCHG);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8BBA0C0", Offset = "0x8BB94C0", VA = "0x188BBA0C0")]
	public void KALKMKDNGKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8BBAA90", Offset = "0x8BB9E90", VA = "0x188BBAA90")]
	internal CMMKOKNMPJJ MGEEINLCIAI(CMMKOKNMPJJ EGEIKEICDOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8BBAF10", Offset = "0x8BBA310", VA = "0x188BBAF10")]
	internal IReadOnlyCollection<JBGEMEIIOHE> PKJKLOPGALM(CMMKOKNMPJJ POHEJPBANCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8BBAE30", Offset = "0x8BBA230", VA = "0x188BBAE30")]
	public bool OGGBFAEBPDF(JBGEMEIIOHE ALNLOCPIMLG, bool PLJOEFBBPNA, string BOHCAEGKDGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8BB9D00", Offset = "0x8BB9100", VA = "0x188BB9D00")]
	public (bool, string) DAIFDIFDILH(JBGEMEIIOHE ALNLOCPIMLG)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8BB9FD0", Offset = "0x8BB93D0", VA = "0x188BB9FD0")]
	internal void HPBHPKIDANG(JBGEMEIIOHE ALNLOCPIMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8BB9A60", Offset = "0x8BB8E60", VA = "0x188BB9A60")]
	public HNDIGBACFLM CEKOABLGEAG(Func<JPNNICBILFM, Guid> EPHKHKOMJEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8BBA130", Offset = "0x8BB9530", VA = "0x188BBA130")]
	public void KKFIMIBNPJK(HNDIGBACFLM IOHOBFLMHAF, Func<Guid, JPNNICBILFM> PEHDBCEMCLJ, [Optional] JPNNICBILFM? IOEHNHLGJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8BB98D0", Offset = "0x8BB8CD0", VA = "0x188BB98D0")]
	[CompilerGenerated]
	private void AENNHHFBMMJ(JBGEMEIIOHE BJDGKGEHBAJ, OBOOGJBKJCC NMLGCNDKGAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class IGBPAINONAE : AIMABJGODNH, CADPBKBPMON, IDisposable, CBPFPBIOLFG
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class FLGKMKGDMBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public CMMKOKNMPJJ newRole;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public FLGKMKGDMBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8BBBDB0", Offset = "0x8BBB1B0", VA = "0x188BBBDB0")]
		internal bool FDMNDKNJJLM(CMMKOKNMPJJ rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class AHDKHAIMGBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public JPNNICBILFM roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public AHDKHAIMGBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6F60", Offset = "0x1ED6360", VA = "0x181ED6F60")]
		internal bool AHGJKMNIIEH(JPNNICBILFM r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct LHHJHCDDFGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public IGBPAINONAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public LCCHGCBPFIP roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private TaskAwaiter<CAGIALDELDO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3800", Offset = "0x8BC2C00", VA = "0x188BC3800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3E70", Offset = "0x8BC3270", VA = "0x188BC3E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class ADCDMANKPLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public ADCDMANKPLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9650", Offset = "0x8BB8A50", VA = "0x188BB9650")]
		internal void FECCJIKMAIJ(HNDIGBACFLM r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9530", Offset = "0x8BB8930", VA = "0x188BB9530")]
		internal void DIBLNDFCKMI(HNDIGBACFLM r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct HOJIMAFGMHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public LCCHGCBPFIP roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class NGECHBNDMAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Func<HNDIGBACFLM, OBOOGJBKJCC> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public NGECHBNDMAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8BC6FC0", Offset = "0x8BC63C0", VA = "0x188BC6FC0")]
		internal void NOONBKBFIAG(HNDIGBACFLM r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8BC6F60", Offset = "0x8BC6360", VA = "0x188BC6F60")]
		internal void HOINOKCLNII(HNDIGBACFLM r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8BC6F90", Offset = "0x8BC6390", VA = "0x188BC6F90")]
		internal void JPCJLPMNNEA(HNDIGBACFLM r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class LIHFLDLLEFG<T> where T : notnull
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
			public LIHFLDLLEFG<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private TaskAwaiter<CAGIALDELDO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x44B8820", Offset = "0x44B7C20", VA = "0x1844B8820", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xAC9F20", Offset = "0xAC9320", VA = "0x180AC9F20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public JBGEMEIIOHE rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public JPNNICBILFM accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public CPCGFNOCCHG recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public IGBPAINONAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public LIHFLDLLEFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5515760", Offset = "0x5514B60", VA = "0x185515760")]
		[AsyncStateMachine(typeof(LIHFLDLLEFG<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void JJAGHLGBJNJ()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct IHEGDCDCECA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public IReadOnlyList<APIPDLAENGJ> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct NBCOCPMLPJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public BIJOCENLPAC rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public LCCHGCBPFIP roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public IReadOnlyDictionary<JPNNICBILFM, CMMKOKNMPJJ> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public KEPKCCNNHIG debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8BC60D0", Offset = "0x8BC54D0", VA = "0x188BC60D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8BC6BF0", Offset = "0x8BC5FF0", VA = "0x188BC6BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly BIJOCENLPAC CHBKOBFBCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly IJCEJHBPHOB KNEIFCFAPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly KEPKCCNNHIG NMHGBBCEPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly Dictionary<int, CMMKOKNMPJJ> BKHJEFFMBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal readonly Dictionary<JPNNICBILFM, CMMKOKNMPJJ> POENOHICKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal readonly Dictionary<JPNNICBILFM, CMMKOKNMPJJ> BHFBEAOOMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal readonly List<CMMKOKNMPJJ> AFPBKNNELNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool IBHMMCDFONC;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly JBGEMEIIOHE[] NJPCEBCAAGJ;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public LKOFNOOAJPB JHKNMMIOJKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event PAMPELNEEED NEGHMKBDHCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE470", Offset = "0x8BBD870", VA = "0x188BBE470", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE3D0", Offset = "0x8BBD7D0", VA = "0x188BBE3D0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x8BBCE70", Offset = "0x8BBC270", VA = "0x188BBCE70")]
	[MKODAOGKIAA.PONKMEEEKBE]
	internal static void EMILKHFAJPJ(JFAGCPCLAAF KOCCFDNNPHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x8BC1AC0", Offset = "0x8BC0EC0", VA = "0x188BC1AC0")]
	[UnityEngine.Scripting.Preserve]
	internal IGBPAINONAE([PKIHAALFADL(null)] BIJOCENLPAC PPPCLAMMPBO, [PKIHAALFADL(null)] IJCEJHBPHOB EIEBAGPMMHL, [PKIHAALFADL(null)] KEPKCCNNHIG NMHGBBCEPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x8BBCD50", Offset = "0x8BBC150", VA = "0x188BBCD50", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x8BBC470", Offset = "0x8BBB870", VA = "0x188BBC470")]
	private void DPFKNBEIOKD(IEnumerable<CMMKOKNMPJJ> HHIBCBIBNAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x8BBD030", Offset = "0x8BBC430", VA = "0x188BBD030", Slot = "10")]
	public bool EPKDJLCJONM(NELIJLIGAOD NICGPJDLKCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x8BBC240", Offset = "0x8BBB640", VA = "0x188BBC240")]
	private void BDOHHNOGDEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x8BC0DC0", Offset = "0x8BC01C0", VA = "0x188BC0DC0")]
	private void NFBDFEMBOKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x8BBE8D0", Offset = "0x8BBDCD0", VA = "0x188BBE8D0", Slot = "8")]
	public IReadOnlyList<KLOMHPDKBOJ> IDNEEHHAICA(bool GBHFLDFDLOI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8BBC250", Offset = "0x8BBB650", VA = "0x188BBC250", Slot = "9")]
	public KLOMHPDKBOJ BKNCBODFOMA(NELIJLIGAOD NICGPJDLKCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8BC12E0", Offset = "0x8BC06E0", VA = "0x188BC12E0")]
	private JPNNICBILFM NODNEGNMIBL(NELIJLIGAOD NICGPJDLKCM)
	{
		return default(JPNNICBILFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8BBC0D0", Offset = "0x8BBB4D0", VA = "0x188BBC0D0", Slot = "12")]
	public bool AEEGOONOFAO(NELIJLIGAOD HDJHIPBJBCO, JPNNICBILFM MLGIIBEOGOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8BBC3D0", Offset = "0x8BBB7D0", VA = "0x188BBC3D0", Slot = "13")]
	public KLOMHPDKBOJ DDFHMLMHJPJ(JPNNICBILFM MLGIIBEOGOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x8BBE0A0", Offset = "0x8BBD4A0", VA = "0x188BBE0A0")]
	private static bool GJEAGLDLPLI(ALJBLLHGNFF PEFIPJAEABL, JPNNICBILFM MLGIIBEOGOM, [Out] HNDIGBACFLM? MMCIDGGBIFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x8BBFC70", Offset = "0x8BBF070", VA = "0x188BBFC70")]
	private static void MIECMJDPBCD(ALJBLLHGNFF PEFIPJAEABL, Action<HNDIGBACFLM> EOKEJKMFBCA, JPNNICBILFM PFEKHCPDBHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x8BBF9E0", Offset = "0x8BBEDE0", VA = "0x188BBF9E0")]
	private static void MIECMJDPBCD(ALJBLLHGNFF PEFIPJAEABL, Action<HNDIGBACFLM> EOKEJKMFBCA, Predicate<JPNNICBILFM> FLDIENGCGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8BBC360", Offset = "0x8BBB760", VA = "0x188BBC360")]
	private void BPPMLLJGIIG(NELIJLIGAOD NICGPJDLKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8BBE510", Offset = "0x8BBD910", VA = "0x188BBE510", Slot = "4")]
	[AsyncStateMachine(typeof(LHHJHCDDFGK))]
	public Task HNDLOFAHEFO([CanBeNull] LCCHGCBPFIP PHIIDLOGBDN, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8BC0FA0", Offset = "0x8BC03A0", VA = "0x188BC0FA0")]
	private void NIOIJCMFDKA(ALJBLLHGNFF OFGAIIEHEPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8BBD430", Offset = "0x8BBC830", VA = "0x188BBD430")]
	internal static string FHACOHIAEIB(BIJOCENLPAC CHBKOBFBCOF, LCCHGCBPFIP PHIIDLOGBDN, IReadOnlyDictionary<JPNNICBILFM, CMMKOKNMPJJ> POENOHICKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8BBFF90", Offset = "0x8BBF390", VA = "0x188BBFF90")]
	private static void MNAHICDGDCC(LCCHGCBPFIP PHIIDLOGBDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x8BBEF50", Offset = "0x8BBE350", VA = "0x188BBEF50")]
	private static void KPPHLOLKMFE(ALJBLLHGNFF LOLPFIIIPAC, IReadOnlyDictionary<JPNNICBILFM, CMMKOKNMPJJ> POENOHICKCP, StringBuilder GBHONJECMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8BC14F0", Offset = "0x8BC08F0", VA = "0x188BC14F0")]
	private static bool OIIOEAPHJLF(string NOFBBAGAFIJ, [Out] Guid APDHBPLPOIF, [Out] JPNNICBILFM MLGIIBEOGOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8BBF2A0", Offset = "0x8BBE6A0", VA = "0x188BBF2A0")]
	private static void LECNAEGGOIG(LCCHGCBPFIP PHIIDLOGBDN, StringBuilder GBHONJECMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3CFF6C0", Offset = "0x3CFEAC0", VA = "0x183CFF6C0", Slot = "14")]
	public bool LCIBNOEIECD<T>(JPNNICBILFM MLGIIBEOGOM, JBGEMEIIOHE ALNLOCPIMLG, bool PLJOEFBBPNA, T ALOONCIOJJM, [Optional] Action MLPCFEOMFOI) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8BBEB50", Offset = "0x8BBDF50", VA = "0x188BBEB50", Slot = "15")]
	public string JPNDICFMIOM(JBGEMEIIOHE ALNLOCPIMLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8BBD7F0", Offset = "0x8BBCBF0", VA = "0x188BBD7F0", Slot = "16")]
	public bool FLMGNGFJADE(NELIJLIGAOD NICGPJDLKCM, JBGEMEIIOHE BJDGKGEHBAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8BBD740", Offset = "0x8BBCB40", VA = "0x188BBD740", Slot = "18")]
	public bool FLMGNGFJADE(int CJKINMFPLED, JBGEMEIIOHE BJDGKGEHBAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8BBE950", Offset = "0x8BBDD50", VA = "0x188BBE950")]
	private void IFOLBAFBGKI(JPNNICBILFM MLGIIBEOGOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8BBE080", Offset = "0x8BBD480", VA = "0x188BBE080")]
	private bool GJCHJLOFEHP(NELIJLIGAOD NICGPJDLKCM, JPNNICBILFM MLGIIBEOGOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8BBD100", Offset = "0x8BBC500", VA = "0x188BBD100")]
	internal CMMKOKNMPJJ FANMILEHLBE(NELIJLIGAOD NICGPJDLKCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x8BBCE60", Offset = "0x8BBC260", VA = "0x188BBCE60", Slot = "11")]
	public IReadOnlyList<KLOMHPDKBOJ> EKDGBGPBKNF(NELIJLIGAOD NICGPJDLKCM, bool KHLKIKPCFBP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x8BBFD60", Offset = "0x8BBF160", VA = "0x188BBFD60")]
	internal IReadOnlyList<CMMKOKNMPJJ> MKHBBNHBEJJ(NELIJLIGAOD NICGPJDLKCM, bool KHLKIKPCFBP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x8BBD8E0", Offset = "0x8BBCCE0", VA = "0x188BBD8E0")]
	private void GBENMKJKJLF(CAGIALDELDO IJPAIJHIJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x8BC1600", Offset = "0x8BC0A00", VA = "0x188BC1600")]
	private static bool PGNPHAEDKMD(CMMKOKNMPJJ COFAMKLPMAJ, IReadOnlyDictionary<JPNNICBILFM, CMMKOKNMPJJ> POENOHICKCP, [Out] IReadOnlyList<JBGEMEIIOHE> PMPKNDOLOPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x8BC13B0", Offset = "0x8BC07B0", VA = "0x188BC13B0")]
	[AsyncStateMachine(typeof(NBCOCPMLPJA))]
	private static Task OFLKFAGGMIP(BIJOCENLPAC CHBKOBFBCOF, LCCHGCBPFIP PHIIDLOGBDN, IReadOnlyDictionary<JPNNICBILFM, CMMKOKNMPJJ> POENOHICKCP, KEPKCCNNHIG NMHGBBCEPEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x8BBE630", Offset = "0x8BBDA30", VA = "0x188BBE630")]
	[CompilerGenerated]
	internal static void ICMPBCAFCHO(Func<HNDIGBACFLM, OBOOGJBKJCC> PLHONKGFOCK, HOJIMAFGMHB P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x8BBEBD0", Offset = "0x8BBDFD0", VA = "0x188BBEBD0")]
	[CompilerGenerated]
	internal static bool KACDHKNBALG(JPNNICBILFM MLGIIBEOGOM, JBGEMEIIOHE ALNLOCPIMLG, [Out] APIPDLAENGJ OFLKHAAGMMO, IHEGDCDCECA P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface KELKIDIGOGD
{
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PFDKMBJDEJD(NELIJLIGAOD OOEDPNGOLJK, NELIJLIGAOD NOAHJEJJIMJ, IEnumerable<NELIJLIGAOD> KEGCGDEJMMA, [Out] NMDNLIPDECO JKIDJMAPFCI, [Out] JMHDPKKALPH MPKELGOGFBK);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string CBPHOCNFFBK(JMHDPKKALPH MEMIPFEBPLH);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum JMHDPKKALPH : byte
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
internal class LFAGMLLMCEK : KELKIDIGOGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly CADPBKBPMON ANLMOHONAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly FMLPMAPALBN FGBKACBIDPK;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0xA7A690", Offset = "0xA79A90", VA = "0x180A7A690")]
	[RecRoom.NoEngine.Common.Preserve]
	public LFAGMLLMCEK([PKIHAALFADL(null)] CADPBKBPMON ANLMOHONAPH, [PKIHAALFADL(null)] FMLPMAPALBN IIEOPNIOOPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x8BC30B0", Offset = "0x8BC24B0", VA = "0x188BC30B0")]
	private static PILCIALAKPM? DJDLOBFGIKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x8BC3700", Offset = "0x8BC2B00", VA = "0x188BC3700", Slot = "4")]
	public bool PFDKMBJDEJD(NELIJLIGAOD OOEDPNGOLJK, NELIJLIGAOD NOAHJEJJIMJ, IEnumerable<NELIJLIGAOD> KEGCGDEJMMA, [Out] NMDNLIPDECO JKIDJMAPFCI, [Out] JMHDPKKALPH MPKELGOGFBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x8BC2FB0", Offset = "0x8BC23B0", VA = "0x188BC2FB0", Slot = "5")]
	public string CBPHOCNFFBK(JMHDPKKALPH MEMIPFEBPLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x8BC30F0", Offset = "0x8BC24F0", VA = "0x188BC30F0")]
	internal bool IDCIILIMOMH(NELIJLIGAOD OOEDPNGOLJK, NELIJLIGAOD NOAHJEJJIMJ, IEnumerable<NELIJLIGAOD> KEGCGDEJMMA, MBLNIACGJFP BABBGDPKJHL, PILCIALAKPM? AFJLNLHALGP, [Out] NMDNLIPDECO JKIDJMAPFCI, [Out] JMHDPKKALPH MPKELGOGFBK)
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
