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
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5F3C490", Offset = "0x5F3AC90", VA = "0x185F3C490")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6F06F0", Offset = "0x6EEEF0", VA = "0x1806F06F0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x91F620", Offset = "0x91DE20", VA = "0x18091F620")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum ENOAFHBBMME
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum BGPJNHFCDBC
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void EMMJEDHDHCA<TPermission>(TPermission HICHDCALIJC);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void NIMJKLMDHGM(CPHBKIKDFMP DGCAOGIOOKH);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface JGLDLKAIKJE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool OLPHMBDIPPB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool LMCKLEJBCGE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool MKGIPFHEKOH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool COPHDKDBNCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool OGJIFBKLCBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool IGMGOOJCLDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface FMOCOKNNCHF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	LHNKKHGMMDB ININGOGIFNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	IEnumerable<JJDBGECIFIE> NPHFFKGCEBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event NIMJKLMDHGM LKHIBIACDNA;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<JJDBGECIFIE> IMGNIADNCKD(bool OGFGOHJJDPB = false);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JJDBGECIFIE LABPEPICPIH(CPHBKIKDFMP DGCAOGIOOKH);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool ACCJMHAKNDF(CPHBKIKDFMP DGCAOGIOOKH);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<JJDBGECIFIE> CJDIFPHJNJC(CPHBKIKDFMP DGCAOGIOOKH, bool PGBJDLBFLIP = false);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool DIIMLMKEJLC(CPHBKIKDFMP ELGKFMCNPGM, OMMBGJMJJPN ANKMFKBFFIA);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	JJDBGECIFIE OCNCADLNMJE(OMMBGJMJJPN ANKMFKBFFIA);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool FGPNJDGOKCG<T>(OMMBGJMJJPN ANKMFKBFFIA, JLHELJKAODF HICHDCALIJC, bool BFJNNEJMBFD, T CBHLECKANBK) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MKNOPCAPKCN
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task CMADMABCCMD(MAHPOMANNIJ BJBAPBHIHNI, CancellationToken DIEJHKIAFPL);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DABCPCPKCKD(ref MAHPOMANNIJ BJBAPBHIHNI);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MGLFGCBIECC
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	CPHBKIKDFMP HNLINEPLBMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	HCHDEHIGEBE JDAECCGHAHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	FGCPNAACHIK IHBBABEMJHC
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<ALIIIAGAPND> BGJHNNHPACO;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action OFAINPAJDPH;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OMMBGJMJJPN PPAHMCJNOAE(CPHBKIKDFMP DGCAOGIOOKH);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<ALIIIAGAPND> EOCCIAPIJMF(CancellationToken DIEJHKIAFPL);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task AAMEOMHKPHF(long JJIOFAMOIJP, long NLMOHAPLAPN, IReadOnlyList<BNLPBMJJOMM> DOJIIFDFHBH);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<CPHBKIKDFMP> CHFJGFOEEHI();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class DEPGMEAOPAE
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5F3A340", Offset = "0x5F38B40", VA = "0x185F3A340")]
	public static OMMBGJMJJPN LDPODJBCALJ(this MGLFGCBIECC IACGHNPKKHM)
	{
		return default(OMMBGJMJJPN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface GJPNPHGNMBM<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string EKLCLAGBOGB
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event global::EMMJEDHDHCA<TPermission> EALPMPFJCJK;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal static class ICPJOBIMHJF
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[Flags]
	public enum AGJIOABNKED
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		AG_EVERYONE = 0,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		AG_CREATOR = 0x200000,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		AG_COOWNER = 0x400000,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		AG_HOST = 0x800000,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		AG_MODERATOR = 0x1000000
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly Guid LHOMDMAKOOB;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid PLLBIHIJNGH;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid FCJBDBGEPLK;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid JGNLONAGMMN;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid FPFGPMLOAGJ;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly global::DEGHBPDIOJB<OMMBGJMJJPN, Guid> KHIDHMOPNNA;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	internal static IEnumerable<OMMBGJMJJPN> KIEMOMMNJCM
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5F3B1B0", Offset = "0x5F399B0", VA = "0x185F3B1B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5F3B230", Offset = "0x5F39A30", VA = "0x185F3B230")]
	public static OMMBGJMJJPN ONGGGBGAEDC(Guid CNMALJMHIOD)
	{
		return default(OMMBGJMJJPN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5F3AFF0", Offset = "0x5F397F0", VA = "0x185F3AFF0")]
	public static Guid ALMDHOFEECM(OMMBGJMJJPN ANKMFKBFFIA)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5F3B0E0", Offset = "0x5F398E0", VA = "0x185F3B0E0")]
	public static bool FPBFMLDELKD(OMMBGJMJJPN ANKMFKBFFIA, out Guid CNMALJMHIOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5F3B2C0", Offset = "0x5F39AC0", VA = "0x185F3B2C0")]
	public static bool PKMNHNLFEBD(Guid CNMALJMHIOD, out OMMBGJMJJPN ANKMFKBFFIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5F3B180", Offset = "0x5F39980", VA = "0x185F3B180")]
	public static OMMBGJMJJPN HBCDEFHHADL(OMMBGJMJJPN ANKMFKBFFIA)
	{
		return default(OMMBGJMJJPN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5F3AF40", Offset = "0x5F39740", VA = "0x185F3AF40")]
	public static AGJIOABNKED AGEEBCIFKEK(OMMBGJMJJPN DPAAANKJKLG)
	{
		return default(AGJIOABNKED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5F3B0A0", Offset = "0x5F398A0", VA = "0x185F3B0A0")]
	internal static OMMBGJMJJPN CGEIHCAJOCM(AGJIOABNKED DEFHDAJELEH)
	{
		return default(OMMBGJMJJPN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class KLEGLJAKACB
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? EFAKDIIPEBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6F5130", Offset = "0x6F3930", VA = "0x1806F5130")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6D5F40", Offset = "0x6D4740", VA = "0x1806D5F40")]
	protected KLEGLJAKACB(object? ELNGJGPEOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool LPDBNOLGMBP(object? NPHADDCNBHE);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class MLELNAOJJAP<T> : KLEGLJAKACB where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private T MKIMNBMOEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> GIPMPCIMIBL;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T PPNOOBBHMAN
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8D0", Offset = "0x6EE0D0", VA = "0x1806EF8D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2FB9D30", Offset = "0x2FB8530", VA = "0x182FB9D30", Slot = "4")]
	public override bool LPDBNOLGMBP(object? NPHADDCNBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2FB9800", Offset = "0x2FB8000", VA = "0x182FB9800")]
	public bool EIHMLFBENOC(T EJGEGLCEKFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2FB9FE0", Offset = "0x2FB87E0", VA = "0x182FB9FE0")]
	public MLELNAOJJAP(T CMEPDMFEMEH, IEqualityComparer<T> GIPMPCIMIBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class DFJOLKPLKHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<JLHELJKAODF, bool> KJAFBOGHIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<JLHELJKAODF, KLEGLJAKACB> JMHNPDADAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly ACFCLFNFOJK JIPHAPIOPPI;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5F3A820", Offset = "0x5F39020", VA = "0x185F3A820")]
	public DFJOLKPLKHP(ACFCLFNFOJK JIPHAPIOPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5F3A3A0", Offset = "0x5F38BA0", VA = "0x185F3A3A0")]
	public bool AEOFGIPEIKG(JLHELJKAODF HICHDCALIJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x22FD9F0", Offset = "0x22FC1F0", VA = "0x1822FD9F0")]
	public bool FOCCEIDKNCM<T>(JLHELJKAODF HICHDCALIJC, bool BFJNNEJMBFD, T NPHADDCNBHE) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x22FDD70", Offset = "0x22FC570", VA = "0x1822FDD70")]
	public (bool, T?) IFBAHJMIKFE<T>(JLHELJKAODF HICHDCALIJC) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5F3A410", Offset = "0x5F38C10", VA = "0x185F3A410")]
	public bool FOCCEIDKNCM(JLHELJKAODF HICHDCALIJC, bool BFJNNEJMBFD, object NPHADDCNBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5F3A4F0", Offset = "0x5F38CF0", VA = "0x185F3A4F0")]
	public (bool, object) IFBAHJMIKFE(JLHELJKAODF HICHDCALIJC)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x22FDF80", Offset = "0x22FC780", VA = "0x1822FDF80")]
	private void OBJBHHJIMJH<T>(JLHELJKAODF HICHDCALIJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5F3A760", Offset = "0x5F38F60", VA = "0x185F3A760")]
	private KLEGLJAKACB PALHBFFPNDI(JLHELJKAODF HICHDCALIJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5F3A5C0", Offset = "0x5F38DC0", VA = "0x185F3A5C0")]
	public void JNKJKOBOKNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class FICPJENIOCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string BJMLKDGDDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type GMPBAMLMGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly FEOJFGECKGH BAJKJECNFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly JLHELJKAODF BBBCBAKJJDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NFLDDAEJOGP CIGHAOFNLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public APKIEOCELGG AKJJKFKHOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public OHIJACEGCBH CBHLDFPMAND;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5F3AEB0", Offset = "0x5F396B0", VA = "0x185F3AEB0")]
	public FICPJENIOCC(Type AEDNBFJFMGD, string AIGKKPFNNAM, JLHELJKAODF HICHDCALIJC, NFLDDAEJOGP PIJLPFELNEB, APKIEOCELGG DDFFIBIHHGG, OHIJACEGCBH GHMDIBHMNCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5F3ADC0", Offset = "0x5F395C0", VA = "0x185F3ADC0")]
	public object CEPNMPPLFLJ(object? HAKPJJGEGOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x268C1B0", Offset = "0x268A9B0", VA = "0x18268C1B0")]
	public void OBJBHHJIMJH<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5F3AE00", Offset = "0x5F39600", VA = "0x185F3AE00")]
	public void OBJBHHJIMJH(Type GJILAKKJCGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class GBGLCHIMJFB<T> : FICPJENIOCC where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string HHHEOIDJKFE(T NPHADDCNBHE);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T MPODOIMPALE(string? PBIFOKBFPPK, T CMEPDMFEMEH);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class HHBBPADKHPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public HHHEOIDJKFE serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public MPODOIMPALE parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
		public HHBBPADKHPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x36542F0", Offset = "0x3652AF0", VA = "0x1836542F0")]
		internal string <.ctor>b__0(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x3654390", Offset = "0x3652B90", VA = "0x183654390")]
		internal object <.ctor>b__1(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x378CD20", Offset = "0x378B520", VA = "0x18378CD20")]
	public GBGLCHIMJFB(JLHELJKAODF HICHDCALIJC, string AIGKKPFNNAM, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6882E0", Offset = "0x6876E0")] global::GBGLCHIMJFB<T>.HHHEOIDJKFE PIJLPFELNEB, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x688340", Offset = "0x687740")] global::GBGLCHIMJFB<T>.MPODOIMPALE DDFFIBIHHGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x378B9C0", Offset = "0x378A1C0", VA = "0x18378B9C0")]
	private static object? JFCMHHFNDFE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6883A0", Offset = "0x6877A0")] global::GBGLCHIMJFB<T?>.MPODOIMPALE? DDFFIBIHHGG, string? PBIFOKBFPPK, object? CMEPDMFEMEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x378C410", Offset = "0x378AC10", VA = "0x18378C410")]
	private static string ODHIHDMAPDF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x688400", Offset = "0x687800")] global::GBGLCHIMJFB<T>.HHHEOIDJKFE MBFCJBPKKKB, object? NPHADDCNBHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string NFLDDAEJOGP(object? NPHADDCNBHE);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object APKIEOCELGG(string? PBIFOKBFPPK, [Optional] object CMEPDMFEMEH);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate KLEGLJAKACB OHIJACEGCBH();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class ACFCLFNFOJK
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class KMOANMGOLFN : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static KMOANMGOLFN PDCOCJBICGC;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5F3B630", Offset = "0x5F39E30", VA = "0x185F3B630", Slot = "4")]
		public bool Equals(List<string> NGMFABJMIHP, List<string> OMDBFFDAOFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5F3B790", Offset = "0x5F39F90", VA = "0x185F3B790", Slot = "5")]
		public int GetHashCode(List<string> BFHAMCLNCKB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public KMOANMGOLFN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class BKOFLHDFPLA : global::DLPDGMDBAFI<ENOAFHBBMME>
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5F39980", Offset = "0x5F38180", VA = "0x185F39980", Slot = "9")]
		public override string ODHIHDMAPDF(ENOAFHBBMME JHPDOGGEPPC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5F39790", Offset = "0x5F37F90", VA = "0x185F39790", Slot = "10")]
		protected override bool KPHLFMMLEPD(string JHPDOGGEPPC, out ENOAFHBBMME NPHADDCNBHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5F39A80", Offset = "0x5F38280", VA = "0x185F39A80")]
		public BKOFLHDFPLA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly GJAOELGILDI CKHBPEGBIME;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly BKOFLHDFPLA DAOLDKIENFA;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<FICPJENIOCC> OGHHJHFGODA;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<JLHELJKAODF> CCKNLIAGHEL
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<JLHELJKAODF, FICPJENIOCC> PDKHBAANIKH
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5F36C60", Offset = "0x5F35460", VA = "0x185F36C60")]
	public ACFCLFNFOJK([Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x688460", Offset = "0x687860")] IList<FICPJENIOCC> LJCEAGEPBBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5F36070", Offset = "0x5F34870", VA = "0x185F36070")]
	public FICPJENIOCC GKMHELNJLFE(JLHELJKAODF HICHDCALIJC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface LHNKKHGMMDB
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	JJDBGECIFIE BGEBILLPBME
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class OPGDJNOKCKM : LHNKKHGMMDB
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static OPGDJNOKCKM JOPGNAAEDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly BGDFJNPFLPN OKKOHJGNGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<BGDFJNPFLPN> FBECPEKMNGM;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public JJDBGECIFIE BGEBILLPBME
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5F424B0", Offset = "0x5F40CB0", VA = "0x185F424B0")]
	public OPGDJNOKCKM(BGDFJNPFLPN JAAAOAHHAEG, IReadOnlyList<BGDFJNPFLPN> PLGHLEJOJEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5F41C70", Offset = "0x5F40470", VA = "0x185F41C70")]
	private static OPGDJNOKCKM FJADDEDFKCD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class DINAGPBJAEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<OMMBGJMJJPN> PBOLGFLPLFD;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5F3AB00", Offset = "0x5F39300", VA = "0x185F3AB00")]
	public static bool GIJEJLAIDII(this CPHBKIKDFMP ALIBHEDNBMG, OMMBGJMJJPN ANKMFKBFFIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5F3AA80", Offset = "0x5F39280", VA = "0x185F3AA80")]
	public static bool BIDFNLIOCMP(this CPHBKIKDFMP ALIBHEDNBMG, OMMBGJMJJPN ANKMFKBFFIA, FGCPNAACHIK ECGGLFHNJJL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface ELIDAHFNALF
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool LNPEGDLDNPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool DJCMNBKFPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool IJLGOELPKHF
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool IKIJPMEMJID
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool PCJALFLBEIG
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool LFHOFCHMMJI
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool FNLBLLBCENI
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool CGMFFLKDLGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool IHNCHAJLNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool JJKEOHKLPPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool JLHELLGKNEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool FCPGHHDKECF
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> ABJOKEFDJGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	ENOAFHBBMME PODJHDODFFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface JJDBGECIFIE : ELIDAHFNALF, JGLDLKAIKJE, global::GJPNPHGNMBM<JLHELJKAODF>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string ENCKBCOFLGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	OMMBGJMJJPN NKKHGKKNKPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) JIJIGJDHNGN<T>(JLHELJKAODF HICHDCALIJC) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum JLHELJKAODF
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
	CAN_USE_PLAY_GIZMOS_TOGGLE = 23
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal class BGDFJNPFLPN : JJDBGECIFIE, ELIDAHFNALF, JGLDLKAIKJE, global::GJPNPHGNMBM<JLHELJKAODF>
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal static readonly ACFCLFNFOJK CIJLKMONBMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal readonly DFJOLKPLKHP AFEFOEGLGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private string? ALBHHKIAJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private string? KKLELBABOAG;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool LNPEGDLDNPA
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5F39280", Offset = "0x5F37A80", VA = "0x185F39280", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public ENOAFHBBMME PODJHDODFFH
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5F38E00", Offset = "0x5F37600", VA = "0x185F38E00", Slot = "20")]
		get
		{
			return default(ENOAFHBBMME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool DJCMNBKFPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5F39460", Offset = "0x5F37C60", VA = "0x185F39460", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool IJLGOELPKHF
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5F38D60", Offset = "0x5F37560", VA = "0x185F38D60", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool IKIJPMEMJID
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5F38B60", Offset = "0x5F37360", VA = "0x185F38B60", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool PCJALFLBEIG
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5F38740", Offset = "0x5F36F40", VA = "0x185F38740", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool LFHOFCHMMJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5F38870", Offset = "0x5F37070", VA = "0x185F38870", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool FNLBLLBCENI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5F386F0", Offset = "0x5F36EF0", VA = "0x185F386F0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool CGMFFLKDLGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5F39410", Offset = "0x5F37C10", VA = "0x185F39410", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool IHNCHAJLNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5F386A0", Offset = "0x5F36EA0", VA = "0x185F386A0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public IReadOnlyList<string> ABJOKEFDJGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5F37A50", Offset = "0x5F36250", VA = "0x185F37A50", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool BMFLCCKDENL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5F37BB0", Offset = "0x5F363B0", VA = "0x185F37BB0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool MJCECCJGAGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5F379B0", Offset = "0x5F361B0", VA = "0x185F379B0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool DEOOKKHCKNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5F37C00", Offset = "0x5F36400", VA = "0x185F37C00", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool JJKEOHKLPPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5F39320", Offset = "0x5F37B20", VA = "0x185F39320", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool JLHELLGKNEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5F37A00", Offset = "0x5F36200", VA = "0x185F37A00", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool LMMLJCHDHBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x5F37C50", Offset = "0x5F36450", VA = "0x185F37C50", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool FCPGHHDKECF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5F394B0", Offset = "0x5F37CB0", VA = "0x185F394B0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool POBCJINDCCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5F38D10", Offset = "0x5F37510", VA = "0x185F38D10", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool OCNLPMJAGMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5F38650", Offset = "0x5F36E50", VA = "0x185F38650", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private bool ADCFAPNECLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5F37BB0", Offset = "0x5F363B0", VA = "0x185F37BB0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private bool DIPGKOCLMHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5F37C00", Offset = "0x5F36400", VA = "0x185F37C00", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private bool CFGPNMNEKAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5F37C50", Offset = "0x5F36450", VA = "0x185F37C50", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private bool OONDAEIKFMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x5F38D10", Offset = "0x5F37510", VA = "0x185F38D10", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private bool MFDJIEOLKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x5F379B0", Offset = "0x5F361B0", VA = "0x185F379B0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private bool APAEIBADDAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x5F38650", Offset = "0x5F36E50", VA = "0x185F38650", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public OMMBGJMJJPN NKKHGKKNKPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8D0", Offset = "0x6EE0D0", VA = "0x1806EF8D0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(OMMBGJMJJPN);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x711000", Offset = "0x70F800", VA = "0x180711000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public string EKLCLAGBOGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x5F392D0", Offset = "0x5F37AD0", VA = "0x185F392D0", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x5F38DB0", Offset = "0x5F375B0", VA = "0x185F38DB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public string ENCKBCOFLGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5F392D0", Offset = "0x5F37AD0", VA = "0x185F392D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool CEMNEPGLPGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7A0560", Offset = "0x79ED60", VA = "0x1807A0560")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x936400", Offset = "0x934C00", VA = "0x180936400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event global::EMMJEDHDHCA<JLHELJKAODF> EALPMPFJCJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x5F38C70", Offset = "0x5F37470", VA = "0x185F38C70", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x5F38BB0", Offset = "0x5F373B0", VA = "0x185F38BB0", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5F38950", Offset = "0x5F37150", VA = "0x185F38950")]
	public BFBDAFNHLKO GJIPNKGAPFN(Func<OMMBGJMJJPN, Guid> IEILODFIPEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5F37CA0", Offset = "0x5F364A0", VA = "0x185F37CA0")]
	public void DHKLCNJENPN(BFBDAFNHLKO KGKLNDOCALO, Func<Guid, OMMBGJMJJPN> LEHEOAJBIFB, [Optional] OMMBGJMJJPN? LHJANIDELAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x1F275F0", Offset = "0x1F25DF0", VA = "0x181F275F0", Slot = "6")]
	public (bool, T?) JIJIGJDHNGN<T>(JLHELJKAODF HICHDCALIJC) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1F27780", Offset = "0x1F25F80", VA = "0x181F27780")]
	public BGDFJNPFLPN PIFAHJJPJEM<T>(JLHELJKAODF HICHDCALIJC, bool BFJNNEJMBFD, T NPHADDCNBHE) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5F39750", Offset = "0x5F37F50", VA = "0x185F39750")]
	public BGDFJNPFLPN(OMMBGJMJJPN ANKMFKBFFIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5F39770", Offset = "0x5F37F70", VA = "0x185F39770")]
	public BGDFJNPFLPN(OMMBGJMJJPN ANKMFKBFFIA, [Optional] string? ALBHHKIAJCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5F396C0", Offset = "0x5F37EC0", VA = "0x185F396C0")]
	public BGDFJNPFLPN(BGDFJNPFLPN FFEGFNINLNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5F39570", Offset = "0x5F37D70", VA = "0x185F39570")]
	internal BGDFJNPFLPN(OMMBGJMJJPN DCBLNONFIJG, [Optional] string? ALBHHKIAJCH, [Optional] BGDFJNPFLPN? FFEGFNINLNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5F37930", Offset = "0x5F36130", VA = "0x185F37930")]
	public static FEOJFGECKGH ANNFJKEFLIG(JLHELJKAODF HICHDCALIJC)
	{
		return default(FEOJFGECKGH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5F38C50", Offset = "0x5F37450", VA = "0x185F38C50")]
	public void JNKJKOBOKNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5F375F0", Offset = "0x5F35DF0", VA = "0x185F375F0")]
	internal BGDFJNPFLPN AILOJFBNBPB(BGDFJNPFLPN DJEHDCDIDIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5F38E50", Offset = "0x5F37650", VA = "0x185F38E50")]
	internal IReadOnlyCollection<JLHELJKAODF> LBMJLEFFBAH(BGDFJNPFLPN FFEGFNINLNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5F38790", Offset = "0x5F36F90", VA = "0x185F38790")]
	public bool FDKPGHIDADC(JLHELJKAODF HICHDCALIJC, bool BFJNNEJMBFD, string DNICADACDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5F37AB0", Offset = "0x5F362B0", VA = "0x185F37AB0")]
	public (bool, string) BOEMOEEMFLN(JLHELJKAODF HICHDCALIJC)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5F39370", Offset = "0x5F37B70", VA = "0x185F39370")]
	internal void MNMNJAHMPCH(JLHELJKAODF HICHDCALIJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5F388C0", Offset = "0x5F370C0", VA = "0x185F388C0")]
	[CompilerGenerated]
	private void GJBJJONJMDC(JLHELJKAODF ECCPNCPNIKF, GBECHKGEDKF NIHGNMPHINI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class OMJKHJLFOCO : MKNOPCAPKCN, FMOCOKNNCHF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class MBJBOONBNEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public BGDFJNPFLPN newRole;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public MBJBOONBNEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5F3BA50", Offset = "0x5F3A250", VA = "0x185F3BA50")]
		internal bool <InitializeRolesLists>b__0(BGDFJNPFLPN rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class CMAAPPDDKEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public OMMBGJMJJPN roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public CMAAPPDDKEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5F3A330", Offset = "0x5F38B30", VA = "0x185F3A330")]
		internal bool <UpdateRoleDatas>b__0(OMMBGJMJJPN r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct AFMPFLKGABO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public OMJKHJLFOCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public MAHPOMANNIJ roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x688A10", Offset = "0x687E10")]
		private TaskAwaiter<ALIIIAGAPND> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5F36FD0", Offset = "0x5F357D0", VA = "0x185F36FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6DD320", Offset = "0x6DBB20", VA = "0x1806DD320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class CDFHKPHKHLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public CDFHKPHKHLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5F39AC0", Offset = "0x5F382C0", VA = "0x185F39AC0")]
		internal void <RunBackwardsCompatibilityMigration>b__0(BFBDAFNHLKO r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5F39BA0", Offset = "0x5F383A0", VA = "0x185F39BA0")]
		internal void <RunBackwardsCompatibilityMigration>b__1(BFBDAFNHLKO r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct KEOJMBDAJAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public MAHPOMANNIJ roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class LHAABPNOLKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x688A70", Offset = "0x687E70")]
		public Func<BFBDAFNHLKO, GBECHKGEDKF> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public LHAABPNOLKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5F3B930", Offset = "0x5F3A130", VA = "0x185F3B930")]
		internal void <MigrateLegacyHostSettings>b__1(BFBDAFNHLKO r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5F3B990", Offset = "0x5F3A190", VA = "0x185F3B990")]
		internal void <MigrateLegacyHostSettings>b__2(BFBDAFNHLKO r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5F3B9F0", Offset = "0x5F3A1F0", VA = "0x185F3B9F0")]
		internal void <MigrateLegacyHostSettings>b__3(BFBDAFNHLKO r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class AFHJLBBFAGP<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public OMJKHJLFOCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public JLHELJKAODF rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public OMMBGJMJJPN accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public FEOJFGECKGH recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public string serializedNewValue;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
		public AFHJLBBFAGP()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct PGOKPOFOPOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public IReadOnlyList<BNLPBMJJOMM> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct NJCBLLIHIDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public MGLFGCBIECC rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public MAHPOMANNIJ roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x688B80", Offset = "0x687F80")]
		public IReadOnlyDictionary<OMMBGJMJJPN, BGDFJNPFLPN> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public KCGMHNBBENK debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5F3BA80", Offset = "0x5F3A280", VA = "0x185F3BA80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6DD320", Offset = "0x6DBB20", VA = "0x1806DD320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly MGLFGCBIECC IACGHNPKKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly OPGDJNOKCKM CBJBMHIIACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly KCGMHNBBENK APKCPEOPEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly Dictionary<int, BGDFJNPFLPN> LNPKDJAIAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	internal readonly Dictionary<OMMBGJMJJPN, BGDFJNPFLPN> FFHBCAENMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	internal readonly Dictionary<OMMBGJMJJPN, BGDFJNPFLPN> KCNBCABNBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	internal readonly List<BGDFJNPFLPN> BAOKILBHHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private bool FMJEBHFNCEO;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly JLHELJKAODF[] BMKGKKGKGNO;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public LHNKKHGMMDB ININGOGIFNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<JJDBGECIFIE> NPHFFKGCEBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x5F3F7F0", Offset = "0x5F3DFF0", VA = "0x185F3F7F0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event NIMJKLMDHGM LKHIBIACDNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5F3C750", Offset = "0x5F3AF50", VA = "0x185F3C750", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5F40AF0", Offset = "0x5F3F2F0", VA = "0x185F40AF0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5F3F950", Offset = "0x5F3E150", VA = "0x185F3F950")]
	[HAHBDBPNEOA(OKOGBEPHCIM.Room, MDCFJLLNHDJ.None)]
	private static void LJEJEKJKKPP(BENLBCJOMLF FODIPHGFFDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5F419E0", Offset = "0x5F401E0", VA = "0x185F419E0")]
	[UnityEngine.Scripting.Preserve]
	internal OMJKHJLFOCO([LJAGOLJKNEF(null)] MGLFGCBIECC DFFJKCGEDIB, [LJAGOLJKNEF(null)] OPGDJNOKCKM LDLIBEEOPJB, [LJAGOLJKNEF(null)] KCGMHNBBENK APKCPEOPEFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5F3D7A0", Offset = "0x5F3BFA0", VA = "0x185F3D7A0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5F3FB10", Offset = "0x5F3E310", VA = "0x185F3FB10")]
	private void LNNKPFDEEIK(IEnumerable<BGDFJNPFLPN> OEKOIFJOOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5F3C520", Offset = "0x5F3AD20", VA = "0x185F3C520", Slot = "12")]
	public bool ACCJMHAKNDF(CPHBKIKDFMP DGCAOGIOOKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5F41740", Offset = "0x5F3FF40", VA = "0x185F41740")]
	private void OFAINPAJDPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5F3CF20", Offset = "0x5F3B720", VA = "0x185F3CF20")]
	private void COKFFJLNNJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5F3E490", Offset = "0x5F3CC90", VA = "0x185F3E490", Slot = "10")]
	public IReadOnlyList<JJDBGECIFIE> IMGNIADNCKD(bool OGFGOHJJDPB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5F3F840", Offset = "0x5F3E040", VA = "0x185F3F840", Slot = "11")]
	public JJDBGECIFIE LABPEPICPIH(CPHBKIKDFMP DGCAOGIOOKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5F41750", Offset = "0x5F3FF50", VA = "0x185F41750")]
	private OMMBGJMJJPN ONECLLALJEO(CPHBKIKDFMP DGCAOGIOOKH)
	{
		return default(OMMBGJMJJPN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5F3D610", Offset = "0x5F3BE10", VA = "0x185F3D610", Slot = "14")]
	public bool DIIMLMKEJLC(CPHBKIKDFMP ELGKFMCNPGM, OMMBGJMJJPN ANKMFKBFFIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5F41690", Offset = "0x5F3FE90", VA = "0x185F41690", Slot = "15")]
	public JJDBGECIFIE OCNCADLNMJE(OMMBGJMJJPN ANKMFKBFFIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5F40B90", Offset = "0x5F3F390", VA = "0x185F40B90")]
	private static bool NJPCAPPKELG(CPMDFPEIBJP AJCPKLDBJFC, OMMBGJMJJPN ANKMFKBFFIA, out BFBDAFNHLKO? IKIACENEKKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5F3DAB0", Offset = "0x5F3C2B0", VA = "0x185F3DAB0")]
	private static void GBGLPALJDJF(CPMDFPEIBJP AJCPKLDBJFC, Action<BFBDAFNHLKO> APJHCPBIGLJ, OMMBGJMJJPN KAPCJANDHAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5F3D8B0", Offset = "0x5F3C0B0", VA = "0x185F3D8B0")]
	private static void GBGLPALJDJF(CPMDFPEIBJP AJCPKLDBJFC, Action<BFBDAFNHLKO> APJHCPBIGLJ, Predicate<OMMBGJMJJPN> CDMOHDKBEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5F3E120", Offset = "0x5F3C920", VA = "0x185F3E120")]
	private void IDNCPNMHEMN(CPHBKIKDFMP DGCAOGIOOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5F3CDE0", Offset = "0x5F3B5E0", VA = "0x185F3CDE0", Slot = "4")]
	[AsyncStateMachine(typeof(AFMPFLKGABO))]
	public Task CMADMABCCMD([CanBeNull] MAHPOMANNIJ BJBAPBHIHNI, CancellationToken DIEJHKIAFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "5")]
	public void DABCPCPKCKD(ref MAHPOMANNIJ BJBAPBHIHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5F3D0B0", Offset = "0x5F3B8B0", VA = "0x185F3D0B0")]
	private void COLAHOBNNFB(CPMDFPEIBJP ELFGNDKBNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5F405D0", Offset = "0x5F3EDD0", VA = "0x185F405D0")]
	internal static string MAAOGLCBMFG(MGLFGCBIECC IACGHNPKKHM, MAHPOMANNIJ BJBAPBHIHNI, IReadOnlyDictionary<OMMBGJMJJPN, BGDFJNPFLPN> FFHBCAENMMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5F3E670", Offset = "0x5F3CE70", VA = "0x185F3E670")]
	private static void JNMBLCADFDD(MAHPOMANNIJ BJBAPBHIHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5F3E180", Offset = "0x5F3C980", VA = "0x185F3E180")]
	private static void IJCINHJIKIB(CPMDFPEIBJP GLKLNPCKGME, IReadOnlyDictionary<OMMBGJMJJPN, BGDFJNPFLPN> FFHBCAENMMK, StringBuilder BDKELDEACOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x5F3C5F0", Offset = "0x5F3ADF0", VA = "0x185F3C5F0")]
	private static bool BLNGKKGCDPE(string CFIFMANEPCO, out Guid FKCMKFKDICP, out OMMBGJMJJPN ANKMFKBFFIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5F3C7F0", Offset = "0x5F3AFF0", VA = "0x185F3C7F0")]
	private static void CEIKBLGLHAN(MAHPOMANNIJ BJBAPBHIHNI, StringBuilder BDKELDEACOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x228EC60", Offset = "0x228D460", VA = "0x18228EC60", Slot = "16")]
	public bool FGPNJDGOKCG<T>(OMMBGJMJJPN ANKMFKBFFIA, JLHELJKAODF HICHDCALIJC, bool BFJNNEJMBFD, T CBHLECKANBK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5F3DBD0", Offset = "0x5F3C3D0", VA = "0x185F3DBD0")]
	private void HFIEBHBLHNJ(OMMBGJMJJPN ANKMFKBFFIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5F3DBB0", Offset = "0x5F3C3B0", VA = "0x185F3DBB0")]
	private bool GNPMFANGCAB(CPHBKIKDFMP DGCAOGIOOKH, OMMBGJMJJPN ANKMFKBFFIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5F3F4D0", Offset = "0x5F3DCD0", VA = "0x185F3F4D0")]
	internal BGDFJNPFLPN JOCKDINJFIL(CPHBKIKDFMP DGCAOGIOOKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5F3CDD0", Offset = "0x5F3B5D0", VA = "0x185F3CDD0", Slot = "13")]
	public IReadOnlyList<JJDBGECIFIE> CJDIFPHJNJC(CPHBKIKDFMP DGCAOGIOOKH, bool PGBJDLBFLIP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5F408D0", Offset = "0x5F3F0D0", VA = "0x185F408D0")]
	internal IReadOnlyList<BGDFJNPFLPN> NGNGHHIMCHG(CPHBKIKDFMP DGCAOGIOOKH, bool PGBJDLBFLIP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5F40F50", Offset = "0x5F3F750", VA = "0x185F40F50")]
	private void NMMDHCJHNGA(ALIIIAGAPND FLKBEIAAMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5F3D320", Offset = "0x5F3BB20", VA = "0x185F3D320")]
	private static bool DFMOMHENDMD(BGDFJNPFLPN BKBMDAKMMHN, IReadOnlyDictionary<OMMBGJMJJPN, BGDFJNPFLPN> FFHBCAENMMK, out IReadOnlyList<JLHELJKAODF> LJBBFKEALCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5F3E510", Offset = "0x5F3CD10", VA = "0x185F3E510")]
	[AsyncStateMachine(typeof(NJCBLLIHIDJ))]
	private static Task JBOPEJODGKK(MGLFGCBIECC IACGHNPKKHM, MAHPOMANNIJ BJBAPBHIHNI, IReadOnlyDictionary<OMMBGJMJJPN, BGDFJNPFLPN> FFHBCAENMMK, KCGMHNBBENK APKCPEOPEFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5F40300", Offset = "0x5F3EB00", VA = "0x185F40300")]
	[CompilerGenerated]
	internal static void LODAMIPMGGG(Func<BFBDAFNHLKO, GBECHKGEDKF> OIBMKICLCEC, ref KEOJMBDAJAD P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5F3DD90", Offset = "0x5F3C590", VA = "0x185F3DD90")]
	[CompilerGenerated]
	internal static bool HJANLEDKHPF(OMMBGJMJJPN ANKMFKBFFIA, JLHELJKAODF HICHDCALIJC, out BNLPBMJJOMM GLDKJHJMCEI, ref PGOKPOFOPOM P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface PPCPEJHNLJF
{
	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IHJFHELMOFG(CPHBKIKDFMP PBLMDFHCHBP, CPHBKIKDFMP LHKMAJDLIAJ, IEnumerable<CPHBKIKDFMP> EIGJBPEEALL, out ENOAFHBBMME EANABGMGJOF, out CICJNBMNDME JEJBOAFKMIF);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum CICJNBMNDME : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	CantKickEventOrganizer
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class CIEHLIHHCLK : PPCPEJHNLJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly FMOCOKNNCHF JGOBDJDPHCI;

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6D5F40", Offset = "0x6D4740", VA = "0x1806D5F40")]
	[RecRoom.NoEngine.Common.Preserve]
	public CIEHLIHHCLK([LJAGOLJKNEF(null)] FMOCOKNNCHF OJOJAMAJBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5F3A1D0", Offset = "0x5F389D0", VA = "0x185F3A1D0")]
	private static HPIOAGDJHDH? CNGGOIJAEBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5F3A220", Offset = "0x5F38A20", VA = "0x185F3A220", Slot = "4")]
	public bool IHJFHELMOFG(CPHBKIKDFMP PBLMDFHCHBP, CPHBKIKDFMP LHKMAJDLIAJ, IEnumerable<CPHBKIKDFMP> EIGJBPEEALL, out ENOAFHBBMME EANABGMGJOF, out CICJNBMNDME JEJBOAFKMIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5F39CC0", Offset = "0x5F384C0", VA = "0x185F39CC0")]
	internal bool CGKMOBPHAHG(CPHBKIKDFMP PBLMDFHCHBP, CPHBKIKDFMP LHKMAJDLIAJ, IEnumerable<CPHBKIKDFMP> EIGJBPEEALL, FGCPNAACHIK ECGGLFHNJJL, HPIOAGDJHDH? KCAFNEEBGFO, out ENOAFHBBMME EANABGMGJOF, out CICJNBMNDME JEJBOAFKMIF)
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
