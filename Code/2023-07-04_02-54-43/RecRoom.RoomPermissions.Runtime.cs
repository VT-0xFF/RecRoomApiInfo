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
		[Cpp2IlInjected.Address(RVA = "0x956600", Offset = "0x954C00", VA = "0x180956600")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6800940", Offset = "0x67FEF40", VA = "0x186800940")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xBD9AB0", Offset = "0xBD80B0", VA = "0x180BD9AB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xEA93B0", Offset = "0xEA79B0", VA = "0x180EA93B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum IBAFDPFGBOL
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface PNLOJFBEBFP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	HHBKGMPBKMJ DIBKBJOONCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<BDGIFIIKJJB> GEFGKAIOPKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event MPADPEDPBCO HDDMAEBDOAJ;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<BDGIFIIKJJB> PEELGHFFHIF(bool IBPDPHJJMNM = false);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BDGIFIIKJJB MLHHFPIIGGK(IFFNBNNJJLC ALOFLFIJONE);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool HBLKBAIFPOA(IFFNBNNJJLC ALOFLFIJONE);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<BDGIFIIKJJB> PGDFDNLJLEN(IFFNBNNJJLC ALOFLFIJONE, bool PIPHMOANBLD = false);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool MBKHKPACJEA(IFFNBNNJJLC EBMAPPAEHEO, IELFPCAAOGM FBODGJKNMOI);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	BDGIFIIKJJB ODJDHBFGKCA(IELFPCAAOGM FBODGJKNMOI);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool KJMEHEDMCCJ<T>(IELFPCAAOGM FBODGJKNMOI, JADGILNJDEB JDKBBLOGAJI, bool MKBMGKDADLA, T NPIEBOHJFEN) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface KHAMPMMACDM
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task ELEEPDPKMBD(NGDMEJFKJLL DNCLKGCICOE, CancellationToken OOAGLCBNIOG);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OHGBPNMCIHH(ref NGDMEJFKJLL DNCLKGCICOE);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface LMJJICIKAOB
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool DNLGKOOPAFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool CNBPDJOLJCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool KJIJADOEGFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool CKCKHPDPJNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool CEKIFODKIDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool NHMJHDLJCII
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class CHEOJPGOFII
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly IReadOnlyList<IELFPCAAOGM> KMFABLLALKA;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x67F6160", Offset = "0x67F4760", VA = "0x1867F6160")]
	public static bool JCANEAODJLB(this IFFNBNNJJLC HIPPLAKEHCK, IELFPCAAOGM FBODGJKNMOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x67F6250", Offset = "0x67F4850", VA = "0x1867F6250")]
	public static bool PMBJDALJJLJ(this IFFNBNNJJLC HIPPLAKEHCK, IELFPCAAOGM FBODGJKNMOI, LMPJDKBMOBF LOCFBHICLIH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class MCNFPBGCPJM : HOOMDFBGCHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly PNLOJFBEBFP DBIIGMLBOFE;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x959E30", Offset = "0x958430", VA = "0x180959E30")]
	[RecRoom.NoEngine.Common.Preserve]
	public MCNFPBGCPJM([NALHKAIJJND(null)] PNLOJFBEBFP GCIDABBEENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x67FFE20", Offset = "0x67FE420", VA = "0x1867FFE20")]
	private static FEOJLOHGGMD? LNGKHGIDICJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x67FF7E0", Offset = "0x67FDDE0", VA = "0x1867FF7E0", Slot = "4")]
	public bool DFOMNCNNNHB(IFFNBNNJJLC NGNNDHLCAFN, IFFNBNNJJLC DANIMBALOMP, IEnumerable<IFFNBNNJJLC> DEOHNNKFGPH, out IBAFDPFGBOL NCMNBGGNEBA, out OAOLDELOELN BMCCJNIHBJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x67FF8F0", Offset = "0x67FDEF0", VA = "0x1867FF8F0")]
	internal bool GLBEMDOHDHL(IFFNBNNJJLC NGNNDHLCAFN, IFFNBNNJJLC DANIMBALOMP, IEnumerable<IFFNBNNJJLC> DEOHNNKFGPH, LMPJDKBMOBF LOCFBHICLIH, FEOJLOHGGMD? EOFCEILBOBD, out IBAFDPFGBOL NCMNBGGNEBA, out OAOLDELOELN BMCCJNIHBJH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BLAHJFPKLFI<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	string BCPCLMNPCLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event NHBJGPFDHEI<TPermission> NEBEHHPPJAE;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public delegate void NHBJGPFDHEI<TPermission>(TPermission JDKBBLOGAJI);
[Cpp2IlInjected.Token(Token = "0x200000E")]
public delegate void MPADPEDPBCO(IFFNBNNJJLC ALOFLFIJONE);
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class BBIOAAFOCCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly string FAIBFIAJKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public readonly Type CLDKELLPJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly FGPJDEHGGKB DDGJKHNILMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly JADGILNJDEB NJFFFMDGDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public KKKAODBEHKE DIMGCMGIEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public EMBMJBLICCG BGEBIMHKIMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public ENGNNJGMCIJ KENDMIOGLLM;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x67F60D0", Offset = "0x67F46D0", VA = "0x1867F60D0")]
	public BBIOAAFOCCB(Type LPIFFFGAMEN, string ILDBOFKKNIM, JADGILNJDEB JDKBBLOGAJI, KKKAODBEHKE EPKCELNHEJF, EMBMJBLICCG KACOCPPONCB, ENGNNJGMCIJ HCBGAJNAKOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x67F5FE0", Offset = "0x67F45E0", VA = "0x1867F5FE0")]
	public object FOMACDFIKFB(object? EJECOGCICOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1D06CE0", Offset = "0x1D052E0", VA = "0x181D06CE0")]
	public void GCIKDNHCIEL<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x67F6020", Offset = "0x67F4620", VA = "0x1867F6020")]
	public void GCIKDNHCIEL(Type KHBPLKDPCMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class BEPIJLGADCA<T> : BBIOAAFOCCB where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal delegate string HKIOFNMGBPE(T FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal delegate T AJCNJDPHMIL(string? CLIHPEAHIJL, T LLDPFOJMFMC);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class IKFFDFPCKIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public HKIOFNMGBPE serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AJCNJDPHMIL parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public IKFFDFPCKIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1FF3090", Offset = "0x1FF1690", VA = "0x181FF3090")]
		internal string BLEGJCHBHJP(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1FF3130", Offset = "0x1FF1730", VA = "0x181FF3130")]
		internal object OPNIPNLCDAC(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2E15F70", Offset = "0x2E14570", VA = "0x182E15F70")]
	public BEPIJLGADCA(JADGILNJDEB JDKBBLOGAJI, string ILDBOFKKNIM, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73A720", Offset = "0x739B20")] BEPIJLGADCA<T>.HKIOFNMGBPE EPKCELNHEJF, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73A780", Offset = "0x739B80")] BEPIJLGADCA<T>.AJCNJDPHMIL KACOCPPONCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2E15500", Offset = "0x2E13B00", VA = "0x182E15500")]
	private static object? EMHFJGFFMPB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73A7E0", Offset = "0x739BE0")] BEPIJLGADCA<T?>.AJCNJDPHMIL? KACOCPPONCB, string? CLIHPEAHIJL, object? LLDPFOJMFMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2E14570", Offset = "0x2E12B70", VA = "0x182E14570")]
	private static string DHDFEGACAHE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73A840", Offset = "0x739C40")] BEPIJLGADCA<T>.HKIOFNMGBPE BEAIJAOLPLH, object? FEBHELIDNED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface HAGPBKNIEPM
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	IFFNBNNJJLC JECPHNFACIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	LHJOLIPPMAL DDPIHOJNEMO
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	LMPJDKBMOBF HIEPDBPOODJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<EEMMKFDCNLC> LBMGGJBJIOJ;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action ODLGLKOOHPF;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IELFPCAAOGM OGIODGJAIJP(IFFNBNNJJLC ALOFLFIJONE);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<EEMMKFDCNLC> FDEKBBJDBML(CancellationToken OOAGLCBNIOG);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task CCPNBJAECAJ(long EDDMGMBKEBK, long LKPOLLBAPFL, IReadOnlyList<OIKGKFOCKBD> PALMBNGCEKO);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<IFFNBNNJJLC> FDAFJNBLEKD();
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class FCFCCBPAKFL
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x67F7BD0", Offset = "0x67F61D0", VA = "0x1867F7BD0")]
	public static IELFPCAAOGM OENHFBOLEFE(this HAGPBKNIEPM IFFGGKDFJJD)
	{
		return default(IELFPCAAOGM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal class AIHPAKLHKHI : BDGIFIIKJJB, FGIIDNJEHBH, LMJJICIKAOB, BLAHJFPKLFI<JADGILNJDEB>
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	internal static readonly LHKKIPKFICG NJPODMFMHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	internal readonly IOKMFLPLLJH MNGNFDCLFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private string? KMFOIHDGAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private string? JPCLLCMHEBE;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private bool MLDIDAIGFDN
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x67F4200", Offset = "0x67F2800", VA = "0x1867F4200", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private bool PJBJMKBHIJB
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x67F40D0", Offset = "0x67F26D0", VA = "0x1867F40D0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private bool HDJAELCLEFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x67F3F40", Offset = "0x67F2540", VA = "0x1867F3F40", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private bool APBDJNLMONC
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x67F53A0", Offset = "0x67F39A0", VA = "0x1867F53A0", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private bool EDJGNONGNNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x67F3CC0", Offset = "0x67F22C0", VA = "0x1867F3CC0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private bool ODMCIJNKCNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x67F3E00", Offset = "0x67F2400", VA = "0x1867F3E00", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public IELFPCAAOGM EOFLODDNEOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x954B90", Offset = "0x953190", VA = "0x180954B90", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(IELFPCAAOGM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x954BA0", Offset = "0x9531A0", VA = "0x180954BA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string BCPCLMNPCLN
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x67F4030", Offset = "0x67F2630", VA = "0x1867F4030", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x67F3EF0", Offset = "0x67F24F0", VA = "0x1867F3EF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string ODPFMFMNAIE
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x67F4030", Offset = "0x67F2630", VA = "0x1867F4030", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool NLBOOHPIAMI
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA75420", Offset = "0xA73A20", VA = "0x180A75420")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA75340", Offset = "0xA73940", VA = "0x180A75340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool DODJDCCDAAF
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x67F5A00", Offset = "0x67F4000", VA = "0x1867F5A00", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public IBAFDPFGBOL HLBGLMDGMAH
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x67F3D10", Offset = "0x67F2310", VA = "0x1867F3D10", Slot = "20")]
		get
		{
			return default(IBAFDPFGBOL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool JHHNNJEKGJM
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x67F4FB0", Offset = "0x67F35B0", VA = "0x1867F4FB0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool MOMKDGEKBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x67F4080", Offset = "0x67F2680", VA = "0x1867F4080", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool DKGJECEIANI
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x67F53F0", Offset = "0x67F39F0", VA = "0x1867F53F0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool JCHBOICOGBE
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x67F5B60", Offset = "0x67F4160", VA = "0x1867F5B60", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool HGHDGBGBAHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x67F5CF0", Offset = "0x67F42F0", VA = "0x1867F5CF0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool OOEFEEAECIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x67F3FE0", Offset = "0x67F25E0", VA = "0x1867F3FE0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool GLJHJKEGJDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x67F3F90", Offset = "0x67F2590", VA = "0x1867F3F90", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool AEFKEEKAFEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x67F5440", Offset = "0x67F3A40", VA = "0x1867F5440", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IReadOnlyList<string> EEDOGMNHFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x67F4340", Offset = "0x67F2940", VA = "0x1867F4340", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool EJABKLAAFGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x67F4200", Offset = "0x67F2800", VA = "0x1867F4200", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool KLOKKIBGMPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x67F3CC0", Offset = "0x67F22C0", VA = "0x1867F3CC0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool CFEPLBNDKDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x67F40D0", Offset = "0x67F26D0", VA = "0x1867F40D0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool FGKOMABIMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x67F5720", Offset = "0x67F3D20", VA = "0x1867F5720", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool LKBOAMHPONC
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x67F56D0", Offset = "0x67F3CD0", VA = "0x1867F56D0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool KNEDDFJNGNF
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x67F3F40", Offset = "0x67F2540", VA = "0x1867F3F40", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool BKJELDAIGHB
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x67F42F0", Offset = "0x67F28F0", VA = "0x1867F42F0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool CEFONKMFPAO
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x67F53A0", Offset = "0x67F39A0", VA = "0x1867F53A0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool FBJMBLBBGNF
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x67F3E00", Offset = "0x67F2400", VA = "0x1867F3E00", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event NHBJGPFDHEI<JADGILNJDEB> NEBEHHPPJAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x67F5C50", Offset = "0x67F4250", VA = "0x1867F5C50", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x67F5BB0", Offset = "0x67F41B0", VA = "0x1867F5BB0", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x10230C0", Offset = "0x10216C0", VA = "0x1810230C0", Slot = "6")]
	public (bool, T?) GLPMLCFNBEJ<T>(JADGILNJDEB JDKBBLOGAJI) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1023080", Offset = "0x1021680", VA = "0x181023080")]
	public AIHPAKLHKHI ABMAEDBNBKN<T>(JADGILNJDEB JDKBBLOGAJI, bool MKBMGKDADLA, T FEBHELIDNED) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x67F5E60", Offset = "0x67F4460", VA = "0x1867F5E60")]
	public AIHPAKLHKHI(IELFPCAAOGM FBODGJKNMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x67F5E40", Offset = "0x67F4440", VA = "0x1867F5E40")]
	public AIHPAKLHKHI(IELFPCAAOGM FBODGJKNMOI, [Optional] string? KMFOIHDGAFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x67F5DB0", Offset = "0x67F43B0", VA = "0x1867F5DB0")]
	public AIHPAKLHKHI(AIHPAKLHKHI MGBIHLAICCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x67F5E80", Offset = "0x67F4480", VA = "0x1867F5E80")]
	internal AIHPAKLHKHI(IELFPCAAOGM ILBLEHINNGD, [Optional] string? KMFOIHDGAFP, [Optional] AIHPAKLHKHI? MGBIHLAICCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x67F3E50", Offset = "0x67F2450", VA = "0x1867F3E50")]
	public static FGPJDEHGGKB BEMDLHEHLAI(JADGILNJDEB JDKBBLOGAJI)
	{
		return default(FGPJDEHGGKB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x67F3ED0", Offset = "0x67F24D0", VA = "0x1867F3ED0")]
	public void BEOEFFFLEFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x67F5770", Offset = "0x67F3D70", VA = "0x1867F5770")]
	internal AIHPAKLHKHI NMMKMGJMEPI(AIHPAKLHKHI ABEDKJNGEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x67F5000", Offset = "0x67F3600", VA = "0x1867F5000")]
	internal IReadOnlyCollection<JADGILNJDEB> JOKLDHADBPL(AIHPAKLHKHI MGBIHLAICCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x67F4120", Offset = "0x67F2720", VA = "0x1867F4120")]
	public bool EECPDMOCHNN(JADGILNJDEB JDKBBLOGAJI, bool MKBMGKDADLA, string JNOPNGPPCKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x67F5A50", Offset = "0x67F4050", VA = "0x1867F5A50")]
	public (bool, string) OEGAMPBNLBJ(JADGILNJDEB JDKBBLOGAJI)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x67F3D60", Offset = "0x67F2360", VA = "0x1867F3D60")]
	internal void AHKFGCDIDNL(JADGILNJDEB JDKBBLOGAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x67F5490", Offset = "0x67F3A90", VA = "0x1867F5490")]
	public NGIGEPJDBDM MANHLKCAGOC(Func<IELFPCAAOGM, Guid> HJOODDIHMHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x67F43A0", Offset = "0x67F29A0", VA = "0x1867F43A0")]
	public void HJKPOFKMFIA(NGIGEPJDBDM NMOINFOCMBK, Func<Guid, IELFPCAAOGM> BFFKINEIKGK, [Optional] IELFPCAAOGM? EIKIHMGDBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x67F4250", Offset = "0x67F2850", VA = "0x1867F4250")]
	[CompilerGenerated]
	private void FLMNGJIPBIA(JADGILNJDEB AABBOJAOCOM, MHLGGCCFKFN KDIDEDIPBGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface HOOMDFBGCHA
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DFOMNCNNNHB(IFFNBNNJJLC NGNNDHLCAFN, IFFNBNNJJLC DANIMBALOMP, IEnumerable<IFFNBNNJJLC> DEOHNNKFGPH, out IBAFDPFGBOL NCMNBGGNEBA, out OAOLDELOELN BMCCJNIHBJH);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum OAOLDELOELN : byte
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	CantKickEventOrganizer
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface FGIIDNJEHBH
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool DODJDCCDAAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool JHHNNJEKGJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool MOMKDGEKBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool DKGJECEIANI
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	bool JCHBOICOGBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool HGHDGBGBAHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool OOEFEEAECIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool GLJHJKEGJDL
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool AEFKEEKAFEE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool FGKOMABIMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool LKBOAMHPONC
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool BKJELDAIGHB
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	IReadOnlyList<string> EEDOGMNHFJI
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	IBAFDPFGBOL HLBGLMDGMAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface BDGIFIIKJJB : FGIIDNJEHBH, LMJJICIKAOB, BLAHJFPKLFI<JADGILNJDEB>
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string ODPFMFMNAIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	IELFPCAAOGM EOFLODDNEOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) GLPMLCFNBEJ<T>(JADGILNJDEB JDKBBLOGAJI) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal abstract class GCJIPPLFDDC
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public object? IIHCENMJBGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x86D400", Offset = "0x86BA00", VA = "0x18086D400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x943F50", Offset = "0x942550", VA = "0x180943F50")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x959E30", Offset = "0x958430", VA = "0x180959E30")]
	protected GCJIPPLFDDC(object? JJFJFBBLFGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool BHPLEEDKOEH(object? FEBHELIDNED);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class IELHKNOBOOO<T> : GCJIPPLFDDC where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private T JHAABBIEANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly IEqualityComparer<T> AEBCGLJOPNE;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T CNODGJBIHLH
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x954B90", Offset = "0x953190", VA = "0x180954B90")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1AD4940", Offset = "0x1AD2F40", VA = "0x181AD4940", Slot = "4")]
	public override bool BHPLEEDKOEH(object? FEBHELIDNED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1AD4B30", Offset = "0x1AD3130", VA = "0x181AD4B30")]
	public bool NALHJPKDOEH(T JBLOFNCNBOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1AD4F30", Offset = "0x1AD3530", VA = "0x181AD4F30")]
	public IELHKNOBOOO(T LLDPFOJMFMC, IEqualityComparer<T> AEBCGLJOPNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal static class DCJLGPFEBBJ
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[Flags]
	public enum CIBHPCKMPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		AG_EVERYONE = 0,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		AG_CREATOR = 0x200000,
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		AG_COOWNER = 0x400000,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		AG_HOST = 0x800000,
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		AG_MODERATOR = 0x1000000
	}

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public static readonly Guid AEKEKCGFFJG;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public static readonly Guid EAMBAFDEHHN;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public static readonly Guid OPBMHBHOJJL;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly Guid IBCNCLODEHA;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly Guid DPJMNIIEEPL;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly HBGABLNHDDA<IELFPCAAOGM, Guid> GJFBEFNDDIA;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal static IEnumerable<IELFPCAAOGM> DJNPBNJLPMK
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x67F6760", Offset = "0x67F4D60", VA = "0x1867F6760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x67F65F0", Offset = "0x67F4BF0", VA = "0x1867F65F0")]
	public static IELFPCAAOGM HDHBHPGCMOJ(Guid IKGPBILBBIK)
	{
		return default(IELFPCAAOGM);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x67F67E0", Offset = "0x67F4DE0", VA = "0x1867F67E0")]
	public static Guid PEDELGFNGPB(IELFPCAAOGM FBODGJKNMOI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x67F6680", Offset = "0x67F4C80", VA = "0x1867F6680")]
	public static bool HEKNBIJNEPB(IELFPCAAOGM FBODGJKNMOI, out Guid IKGPBILBBIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x67F6550", Offset = "0x67F4B50", VA = "0x1867F6550")]
	public static bool DMDDABGPLGK(Guid IKGPBILBBIK, out IELFPCAAOGM FBODGJKNMOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x67F6890", Offset = "0x67F4E90", VA = "0x1867F6890")]
	public static IELFPCAAOGM PKPGNELNHPO(IELFPCAAOGM FBODGJKNMOI)
	{
		return default(IELFPCAAOGM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x67F64A0", Offset = "0x67F4AA0", VA = "0x1867F64A0")]
	public static CIBHPCKMPOJ CGGGCGAOAPC(IELFPCAAOGM DMBKLICPBFO)
	{
		return default(CIBHPCKMPOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x67F6720", Offset = "0x67F4D20", VA = "0x1867F6720")]
	internal static IELFPCAAOGM NDFBNCKKEPA(CIBHPCKMPOJ FONHCLDAFKN)
	{
		return default(IELFPCAAOGM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal delegate string KKKAODBEHKE(object? FEBHELIDNED);
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal delegate object EMBMJBLICCG(string? CLIHPEAHIJL, [Optional] object LLDPFOJMFMC);
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal delegate GCJIPPLFDDC ENGNNJGMCIJ();
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class LHKKIPKFICG
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private class AIFHJHFMENM : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		internal static AIFHJHFMENM FBBAELKBDJK;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x67F39C0", Offset = "0x67F1FC0", VA = "0x1867F39C0", Slot = "4")]
		public bool Equals(List<string> HMINFBNCMPL, List<string> MPEHLADJKCP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x67F3B20", Offset = "0x67F2120", VA = "0x1867F3B20", Slot = "5")]
		public int GetHashCode(List<string> IAMEECMGPIF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public AIFHJHFMENM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private class NOHOFDHBIDK : FALHGFNJFBI<IBAFDPFGBOL>
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6800620", Offset = "0x67FEC20", VA = "0x186800620", Slot = "9")]
		public override string DHDFEGACAHE(IBAFDPFGBOL KJGEDMGMBND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6800710", Offset = "0x67FED10", VA = "0x186800710", Slot = "10")]
		protected override bool JEOGAEOFBCN(string KJGEDMGMBND, out IBAFDPFGBOL FEBHELIDNED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6800900", Offset = "0x67FEF00", VA = "0x186800900")]
		public NOHOFDHBIDK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static readonly OOFJLLEDFIK JDHMNKGHJPF;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly NOHOFDHBIDK IFOBJEBLEHI;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly List<BBIOAAFOCCB> OPPBNNGFNCK;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public IEnumerable<JADGILNJDEB> CANDIEMOFKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x86D400", Offset = "0x86BA00", VA = "0x18086D400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public IReadOnlyDictionary<JADGILNJDEB, BBIOAAFOCCB> KKDKKPKALKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x67FEB50", Offset = "0x67FD150", VA = "0x1867FEB50")]
	public LHKKIPKFICG([Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73A920", Offset = "0x739D20")] IList<BBIOAAFOCCB> IKNIOHNCGCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x67FDF70", Offset = "0x67FC570", VA = "0x1867FDF70")]
	public BBIOAAFOCCB AOENFNLANMC(JADGILNJDEB JDKBBLOGAJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class GFJMAPANBKN : KHAMPMMACDM, PNLOJFBEBFP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class OLNMLMNPPLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AIHPAKLHKHI newRole;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public OLNMLMNPPLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x68009D0", Offset = "0x67FEFD0", VA = "0x1868009D0")]
		internal bool MONHHABOJDG(AIHPAKLHKHI rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class JMIPOKMKCBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public IELFPCAAOGM roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public JMIPOKMKCBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x67FDF60", Offset = "0x67FC560", VA = "0x1867FDF60")]
		internal bool MFNGNODNEAA(IELFPCAAOGM r)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class MFIDBHHMFMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public NGDMEJFKJLL roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public GFJMAPANBKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private bool <isOffline>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private EEMMKFDCNLC <tokenAndPermissionsDto>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private bool <hasRoomRoles>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private EEMMKFDCNLC <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private bool <serverHasPermissions>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73AEB0", Offset = "0x73A2B0")]
		private TaskAwaiter<EEMMKFDCNLC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public MFIDBHHMFMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x67FFE70", Offset = "0x67FE470", VA = "0x1867FFE70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class IMANGMHFOMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public IMANGMHFOMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x67FD510", Offset = "0x67FBB10", VA = "0x1867FD510")]
		internal void IAFFNHLGGOI(NGIGEPJDBDM r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x67FD610", Offset = "0x67FBC10", VA = "0x1867FD610")]
		internal void NNAPCMBMPAJ(NGIGEPJDBDM r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct AKFBPLPKPCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NGDMEJFKJLL roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class JFJAHMFFDEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73AF10", Offset = "0x73A310")]
		public Func<NGIGEPJDBDM, MHLGGCCFKFN> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public JFJAHMFFDEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x67FDE10", Offset = "0x67FC410", VA = "0x1867FDE10")]
		internal void BBKKJCKCHIA(NGIGEPJDBDM r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x67FDE80", Offset = "0x67FC480", VA = "0x1867FDE80")]
		internal void IOPJPNHADHA(NGIGEPJDBDM r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x67FDEF0", Offset = "0x67FC4F0", VA = "0x1867FDEF0")]
		internal void LPPHCCGKKOB(NGIGEPJDBDM r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class DHIAMKFDKJF<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private sealed class <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public DHIAMKFDKJF<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private object <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private int <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private Exception <ex>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73AFD0", Offset = "0x73A3D0")]
			private TaskAwaiter<EEMMKFDCNLC> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
			public <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x1B5B4D0", Offset = "0x1B59AD0", VA = "0x181B5B4D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public GFJMAPANBKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public JADGILNJDEB rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public IELFPCAAOGM accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public FGPJDEHGGKB recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public string serializedNewValue;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public DHIAMKFDKJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2F17220", Offset = "0x2F15820", VA = "0x182F17220")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(DHIAMKFDKJF<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void GPMFEBGFGDO()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct MCBOMOJMOFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public IReadOnlyList<OIKGKFOCKBD> newPermissionOverrides;
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class DJAHMEHCODB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public HAGPBKNIEPM rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public NGDMEJFKJLL roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73B030", Offset = "0x73A430")]
		public IReadOnlyDictionary<IELFPCAAOGM, AIHPAKLHKHI> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public EMOKLDEAGDL debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private StringBuilder <migrationLogBuilder>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73B090", Offset = "0x73A490")]
		private List<OIKGKFOCKBD> <permissionsChangeBatch>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private IEnumerator<NGIGEPJDBDM> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private NGIGEPJDBDM <roleData>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private IELFPCAAOGM <roleAccountType>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private AIHPAKLHKHI <role>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private IReadOnlyList<JADGILNJDEB> <modifiedPermissions>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private IEnumerator<JADGILNJDEB> <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private JADGILNJDEB <permission>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private FGPJDEHGGKB <recNetPermissionType>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73B0F0", Offset = "0x73A4F0")]
		private (bool Overrides, string SerializedValue) <serializedData>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public DJAHMEHCODB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x67F6B90", Offset = "0x67F5190", VA = "0x1867F6B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly HAGPBKNIEPM IFFGGKDFJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly LJBKNPBNICP PKFHAAKPKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly EMOKLDEAGDL LJKGOGKHMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly Dictionary<int, AIHPAKLHKHI> DMDDPKIBIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal readonly Dictionary<IELFPCAAOGM, AIHPAKLHKHI> EGOFAPPGPDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal readonly Dictionary<IELFPCAAOGM, AIHPAKLHKHI> JFLAGNDPHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal readonly List<AIHPAKLHKHI> KLCHKDKPBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool ENNEENIKJFE;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly JADGILNJDEB[] MOKDFLKIJFM;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public HHBKGMPBKMJ DIBKBJOONCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public IEnumerable<BDGIFIIKJJB> GEFGKAIOPKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x67F9DD0", Offset = "0x67F83D0", VA = "0x1867F9DD0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event MPADPEDPBCO HDDMAEBDOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x67F9290", Offset = "0x67F7890", VA = "0x1867F9290", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x67FA500", Offset = "0x67F8B00", VA = "0x1867FA500", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x67FBEF0", Offset = "0x67FA4F0", VA = "0x1867FBEF0")]
	[PJEDGFFEDPC(FLIHEPFCGKG.Room, PDIHHCLCNFI.None)]
	private static void NLFBANBIGIE(EIHIACACEHJ FBBMHADLAOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x67FD280", Offset = "0x67FB880", VA = "0x1867FD280")]
	[UnityEngine.Scripting.Preserve]
	internal GFJMAPANBKN([NALHKAIJJND(null)] HAGPBKNIEPM DEFNCMEIPOL, [NALHKAIJJND(null)] LJBKNPBNICP COKKGDHNPEI, [NALHKAIJJND(null)] EMOKLDEAGDL LJKGOGKHMEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x67F9610", Offset = "0x67F7C10", VA = "0x1867F9610", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x67FC550", Offset = "0x67FAB50", VA = "0x1867FC550")]
	private void OOMMCPMMKJN(IEnumerable<AIHPAKLHKHI> LJLNDAPNBGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x67FA430", Offset = "0x67F8A30", VA = "0x1867FA430", Slot = "12")]
	public bool HBLKBAIFPOA(IFFNBNNJJLC ALOFLFIJONE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x67FC4E0", Offset = "0x67FAAE0", VA = "0x1867FC4E0")]
	private void ODLGLKOOHPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x67FB390", Offset = "0x67F9990", VA = "0x1867FB390")]
	private void LGNILCPINMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x67FCD40", Offset = "0x67FB340", VA = "0x1867FCD40", Slot = "10")]
	public IReadOnlyList<BDGIFIIKJJB> PEELGHFFHIF(bool IBPDPHJJMNM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x67FB6A0", Offset = "0x67F9CA0", VA = "0x1867FB6A0", Slot = "11")]
	public BDGIFIIKJJB MLHHFPIIGGK(IFFNBNNJJLC ALOFLFIJONE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x67F91D0", Offset = "0x67F77D0", VA = "0x1867F91D0")]
	private IELFPCAAOGM CHPLGPNPILN(IFFNBNNJJLC ALOFLFIJONE)
	{
		return default(IELFPCAAOGM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x67FB510", Offset = "0x67F9B10", VA = "0x1867FB510", Slot = "14")]
	public bool MBKHKPACJEA(IFFNBNNJJLC EBMAPPAEHEO, IELFPCAAOGM FBODGJKNMOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x67FC430", Offset = "0x67FAA30", VA = "0x1867FC430", Slot = "15")]
	public BDGIFIIKJJB ODJDHBFGKCA(IELFPCAAOGM FBODGJKNMOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x67F8DE0", Offset = "0x67F73E0", VA = "0x1867F8DE0")]
	private static bool CCNPGDALPGC(AECMOKGCDDM KFDDHNLMDNA, IELFPCAAOGM FBODGJKNMOI, out NGIGEPJDBDM? JIFJHINOAEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x67FA330", Offset = "0x67F8930", VA = "0x1867FA330")]
	private static void HBAENECCFCB(AECMOKGCDDM KFDDHNLMDNA, Action<NGIGEPJDBDM> CAMODMDBKOD, IELFPCAAOGM MIMIMHGONBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x67FA130", Offset = "0x67F8730", VA = "0x1867FA130")]
	private static void HBAENECCFCB(AECMOKGCDDM KFDDHNLMDNA, Action<NGIGEPJDBDM> CAMODMDBKOD, Predicate<IELFPCAAOGM> LIMDHBFPPGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x67FC4F0", Offset = "0x67FAAF0", VA = "0x1867FC4F0")]
	private void OKBFPPEPNPM(IFFNBNNJJLC ALOFLFIJONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x67F9A40", Offset = "0x67F8040", VA = "0x1867F9A40", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MFIDBHHMFMI))]
	public Task ELEEPDPKMBD([CanBeNull] NGDMEJFKJLL DNCLKGCICOE, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
	public void OHGBPNMCIHH(ref NGDMEJFKJLL DNCLKGCICOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x67F7C30", Offset = "0x67F6230", VA = "0x1867F7C30")]
	private void AAENDOJGODE(AECMOKGCDDM APKMDNEAFFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x67FB070", Offset = "0x67F9670", VA = "0x1867FB070")]
	internal static string KICDGIJFKOB(HAGPBKNIEPM IFFGGKDFJJD, NGDMEJFKJLL DNCLKGCICOE, IReadOnlyDictionary<IELFPCAAOGM, AIHPAKLHKHI> EGOFAPPGPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x67F7EB0", Offset = "0x67F64B0", VA = "0x1867F7EB0")]
	private static void ABMEOECCOAE(NGDMEJFKJLL DNCLKGCICOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x67FAD60", Offset = "0x67F9360", VA = "0x1867FAD60")]
	private static void KGNFBIJCNPG(AECMOKGCDDM LFKGFOPNNLC, IReadOnlyDictionary<IELFPCAAOGM, AIHPAKLHKHI> EGOFAPPGPDA, StringBuilder LOFHPGFOKOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x67F9FD0", Offset = "0x67F85D0", VA = "0x1867F9FD0")]
	private static bool GOABCKLOIBO(string ONNJKDEMNDP, out Guid AJKEBIBOCFJ, out IELFPCAAOGM FBODGJKNMOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x67FA740", Offset = "0x67F8D40", VA = "0x1867FA740")]
	private static void ICDCFCLFDJE(NGDMEJFKJLL DNCLKGCICOE, StringBuilder LOFHPGFOKOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x1B78BE0", Offset = "0x1B771E0", VA = "0x181B78BE0", Slot = "16")]
	public bool KJMEHEDMCCJ<T>(IELFPCAAOGM FBODGJKNMOI, JADGILNJDEB JDKBBLOGAJI, bool MKBMGKDADLA, T NPIEBOHJFEN) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x67F9E20", Offset = "0x67F8420", VA = "0x1867F9E20")]
	private void GBDMEACEKIK(IELFPCAAOGM FBODGJKNMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x67F8DC0", Offset = "0x67F73C0", VA = "0x1867F8DC0")]
	private bool BJJDJLPEMHG(IFFNBNNJJLC ALOFLFIJONE, IELFPCAAOGM FBODGJKNMOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x67F9720", Offset = "0x67F7D20", VA = "0x1867F9720")]
	internal AIHPAKLHKHI EJEDEGNONDC(IFFNBNNJJLC ALOFLFIJONE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x67FCDC0", Offset = "0x67FB3C0", VA = "0x1867FCDC0", Slot = "13")]
	public IReadOnlyList<BDGIFIIKJJB> PGDFDNLJLEN(IFFNBNNJJLC ALOFLFIJONE, bool PIPHMOANBLD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x67F9BB0", Offset = "0x67F81B0", VA = "0x1867F9BB0")]
	internal IReadOnlyList<AIHPAKLHKHI> FEMLEPIPJFJ(IFFNBNNJJLC ALOFLFIJONE, bool PIPHMOANBLD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x67FB7B0", Offset = "0x67F9DB0", VA = "0x1867FB7B0")]
	private void MPDABDPPHFG(EEMMKFDCNLC EMGFICKAOAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x67F9330", Offset = "0x67F7930", VA = "0x1867F9330")]
	private static bool DMPPIEBFKBL(AIHPAKLHKHI EOIHHMJPCHB, IReadOnlyDictionary<IELFPCAAOGM, AIHPAKLHKHI> EGOFAPPGPDA, out IReadOnlyList<JADGILNJDEB> AGKLNMLPDBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x67FA5A0", Offset = "0x67F8BA0", VA = "0x1867FA5A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DJAHMEHCODB))]
	private static Task HKENADDHJEJ(HAGPBKNIEPM IFFGGKDFJJD, NGDMEJFKJLL DNCLKGCICOE, IReadOnlyDictionary<IELFPCAAOGM, AIHPAKLHKHI> EGOFAPPGPDA, EMOKLDEAGDL LJKGOGKHMEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x67FCDD0", Offset = "0x67FB3D0", VA = "0x1867FCDD0")]
	[CompilerGenerated]
	internal static void PMGIFNBFOAB(Func<NGIGEPJDBDM, MHLGGCCFKFN> GKBPPKCKCLE, ref AKFBPLPKPCH P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x67FC0A0", Offset = "0x67FA6A0", VA = "0x1867FC0A0")]
	[CompilerGenerated]
	internal static bool OCHMODMEFIE(IELFPCAAOGM FBODGJKNMOI, JADGILNJDEB JDKBBLOGAJI, out OIKGKFOCKBD MEEBJHELBNN, ref MCBOMOJMOFC P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public enum JADGILNJDEB
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	CAN_EDIT_ROOM_ROLES = 1,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	VOTE_KICK_PERMISSION = 3,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	CAN_INVITE = 4,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	CAN_TALK = 6,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	CAN_PRINT_PHOTOS = 7,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	CAN_START_GAMES = 8,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	CAN_SELF_REVIVE = 9,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	AUTO_ASSIGNED_GAME_ROLES = 11,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	CAN_CHANGE_GAME_MODE = 12,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	CAN_USE_MAKER_PEN = 13,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	CAN_USE_DELETE_ALL_BUTTON = 14,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	CAN_SAVE_INVENTIONS = 15,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	DISABLE_MIC_AUTO_MUTE = 16,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	CAN_END_GAMES_EARLY = 17,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	CAN_USE_SHARE_CAM = 18,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	DEPRECATED_CAN_EDIT_CIRCUITS = 19,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	CAN_SPAWN_INVENTIONS = 20,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	CAN_SPAWN_CONSUMABLES = 21,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	CAN_USE_ROOM_RESET_BUTTON = 22,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	CAN_USE_PLAY_GIZMOS_TOGGLE = 23
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class IOKMFLPLLJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly Dictionary<JADGILNJDEB, bool> AELILCINFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly Dictionary<JADGILNJDEB, GCJIPPLFDDC> GBKFCLJCAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly LHKKIPKFICG PEAGPBJKJJM;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x67FDBC0", Offset = "0x67FC1C0", VA = "0x1867FDBC0")]
	public IOKMFLPLLJH(LHKKIPKFICG PEAGPBJKJJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x67FDB50", Offset = "0x67FC150", VA = "0x1867FDB50")]
	public bool LDIFFMDBBID(JADGILNJDEB JDKBBLOGAJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x21696D0", Offset = "0x2167CD0", VA = "0x1821696D0")]
	public bool EGPOLCBLGKF<T>(JADGILNJDEB JDKBBLOGAJI, bool MKBMGKDADLA, T FEBHELIDNED) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2169A20", Offset = "0x2168020", VA = "0x182169A20")]
	public (bool, T?) KGLFEGFJOKO<T>(JADGILNJDEB JDKBBLOGAJI) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x67FD980", Offset = "0x67FBF80", VA = "0x1867FD980")]
	public bool EGPOLCBLGKF(JADGILNJDEB JDKBBLOGAJI, bool MKBMGKDADLA, object FEBHELIDNED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x67FDA60", Offset = "0x67FC060", VA = "0x1867FDA60")]
	public (bool, object) KGLFEGFJOKO(JADGILNJDEB JDKBBLOGAJI)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2169800", Offset = "0x2167E00", VA = "0x182169800")]
	private void GCIKDNHCIEL<T>(JADGILNJDEB JDKBBLOGAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x67FD8C0", Offset = "0x67FBEC0", VA = "0x1867FD8C0")]
	private GCJIPPLFDDC DJJMOHEIKLI(JADGILNJDEB JDKBBLOGAJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x67FD740", Offset = "0x67FBD40", VA = "0x1867FD740")]
	public void BEOEFFFLEFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface HHBKGMPBKMJ
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	BDGIFIIKJJB AHPGJJEOFBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal class LJBKNPBNICP : HHBKGMPBKMJ
{
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public static LJBKNPBNICP HLCPMCEOAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	internal readonly AIHPAKLHKHI FFKGMHMBJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	internal readonly IReadOnlyList<AIHPAKLHKHI> FOIOMPEKGKD;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public BDGIFIIKJJB AHPGJJEOFBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x86D400", Offset = "0x86BA00", VA = "0x18086D400", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x67FF6E0", Offset = "0x67FDCE0", VA = "0x1867FF6E0")]
	public LJBKNPBNICP(AIHPAKLHKHI PHOEDPJBJLH, IReadOnlyList<AIHPAKLHKHI> BONHGOHJKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x67FEEC0", Offset = "0x67FD4C0", VA = "0x1867FEEC0")]
	private static LJBKNPBNICP KBPMHOEGODB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public enum MDPPLCNMAJD
{
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Everyone
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
