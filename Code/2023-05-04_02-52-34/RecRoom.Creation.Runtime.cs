using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Microsoft.CodeAnalysis;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x60D0CC0", Offset = "0x60D00C0", VA = "0x1860D0CC0")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9CC120", Offset = "0x9CB520", VA = "0x1809CC120")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JHBBFOBMCAE
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x60D0980", Offset = "0x60CFD80", VA = "0x1860D0980")]
	public static bool PKJCIKLFOEE(POMACAHPFND MFBGOEFDCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x60D0600", Offset = "0x60CFA00", VA = "0x1860D0600")]
	private static bool PKJCIKLFOEE(BIOHAEANPIH MEMFIMDDIMD, ref POMACAHPFND MFBGOEFDCJK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct CPKEPDDGPNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public List<BADFNEBCNNH> COLDHIJJHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public IEnumerable<GIOOAMLAJBG> HNMPHFMFJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public DBNBABCLCBA NCEINPLKDEB;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface EIPAJBFPNFP
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(HDGICPIDDPO HIDEHJGLNHO, out Dictionary<int, int> EBIDFFIMDLM);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(KKCPFDJMIOB KFIABPAPOIH, INBDNDBFGEL MPAGCNOJHOD);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface ECDLKPAEMLM
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<ByteString> GetValidRoomKeyReplicationIds();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<ByteString> GetValidRoomCurrencies();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<ByteString> GetValidRoomConsumables();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class JKMAMAJMGGE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Dictionary<Guid, Guid> DKLIIJOFLIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<Guid, Guid> LACNJGCDCMJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Dictionary<Guid, Guid> IEJBFKJCOHG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x72B010", Offset = "0x72A410", VA = "0x18072B010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7DE200", Offset = "0x7DD600", VA = "0x1807DE200")]
	public JKMAMAJMGGE(Dictionary<Guid, Guid> DKLIIJOFLIL, Dictionary<Guid, Guid> LACNJGCDCMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x60D09C0", Offset = "0x60CFDC0", VA = "0x1860D09C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class OCJHGNPCOIJ
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private class DGBDDJALILI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly HashSet<GIOOAMLAJBG> NCBOMOGILHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly HashSet<MOAJHKKAOPG> LDLHLPLOPAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly List<NJDJKNMKPLL> EPMHBFECDIO;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x60CE0D0", Offset = "0x60CD4D0", VA = "0x1860CE0D0")]
		public DGBDDJALILI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class NEKKOALNJOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public MOAJHKKAOPG destinationGraph;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public NEKKOALNJOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x60D0C70", Offset = "0x60D0070", VA = "0x1860D0C70")]
		internal bool <InitializeCircuitsV2Remapping>b__0(PHACOPFCMNK n)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class ELCCGCNNPCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int mpif;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public ELCCGCNNPCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x60CF140", Offset = "0x60CE540", VA = "0x1860CF140")]
		internal void <InitializeCircuitsV2Remapping>b__1(PHACOPFCMNK n)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x60D3130", Offset = "0x60D2530", VA = "0x1860D3130")]
	public static CDGJHOJBAMH KOAKMNKIAIP(CPKEPDDGPNG KDMEODNKEJF, out ALEJDGFCOID FENONIGIODL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x60D0FF0", Offset = "0x60D03F0", VA = "0x1860D0FF0")]
	private static void CLMLHIJADJO(CDGJHOJBAMH IJFEAAFBFHI, DGBDDJALILI NKNHJADJDNP, out ALEJDGFCOID FENONIGIODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x60D3B80", Offset = "0x60D2F80", VA = "0x1860D3B80")]
	private static void NBGMBKKBCCG(BADFNEBCNNH DLFFNMDAELA, DGBDDJALILI NKNHJADJDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x60D0D50", Offset = "0x60D0150", VA = "0x1860D0D50")]
	private static void BEBKIODMBIL(CDGJHOJBAMH IJFEAAFBFHI, DGBDDJALILI NKNHJADJDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x60D4650", Offset = "0x60D3A50", VA = "0x1860D4650")]
	private static void PGAMFILLJCD(ref CPKEPDDGPNG OBCFFBHFEKN, DGBDDJALILI NKNHJADJDNP, BADFNEBCNNH DLFFNMDAELA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x60D2880", Offset = "0x60D1C80", VA = "0x1860D2880")]
	public static bool KBBNLGNNOMO(CDGJHOJBAMH IJFEAAFBFHI, JAMAKHCJEOH JMJGABBKCAM, out JKMAMAJMGGE? CFJLBGEKHDF, out string? NOGDNAGMMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x60D3760", Offset = "0x60D2B60", VA = "0x1860D3760")]
	private static void LBBBPJOKEPO(CDGJHOJBAMH IJFEAAFBFHI, ref JAMAKHCJEOH JMJGABBKCAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x60D3CA0", Offset = "0x60D30A0", VA = "0x1860D3CA0")]
	public static Dictionary<Guid, Guid> OCBJBCALBKC(IEnumerable<BADFNEBCNNH> BFDBBIEAJIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x60D2840", Offset = "0x60D1C40", VA = "0x1860D2840")]
	private static void KABDBFFBJFM(CDGJHOJBAMH IJFEAAFBFHI, ref JAMAKHCJEOH JMJGABBKCAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x60D1BE0", Offset = "0x60D0FE0", VA = "0x1860D1BE0")]
	private static bool CNDNBIPAGKC(CDGJHOJBAMH IJFEAAFBFHI, KKCPFDJMIOB KFIABPAPOIH, ref JAMAKHCJEOH JMJGABBKCAM, out string NOGDNAGMMCO, out Dictionary<int, int> EBIDFFIMDLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x60D3910", Offset = "0x60D2D10", VA = "0x1860D3910")]
	private static Dictionary<Guid, BIOHAEANPIH> MGENJCIAEMP(CDGJHOJBAMH IJFEAAFBFHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x60D4910", Offset = "0x60D3D10", VA = "0x1860D4910")]
	private static bool PPKLOPBJPBL(CDGJHOJBAMH IJFEAAFBFHI, ref JAMAKHCJEOH JMJGABBKCAM, out string? NOGDNAGMMCO, out KCAMCABDPPI? KICBCLDGBJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x60D3880", Offset = "0x60D2C80", VA = "0x1860D3880")]
	private static void MEKCIGNCIAO(bool FHIDFELCLKC, BADFNEBCNNH KHKLJBKIGHL, Dictionary<Guid, Guid> NHMILKHOPKK, KCAMCABDPPI MMNNFGPOAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x60D3F80", Offset = "0x60D3380", VA = "0x1860D3F80")]
	private static void OPIMFHGIOKC(bool FHIDFELCLKC, BADFNEBCNNH KHKLJBKIGHL, KCAMCABDPPI KICBCLDGBJP, Guid JDCKLIBBGLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x60D43B0", Offset = "0x60D37B0", VA = "0x1860D43B0")]
	private static void PAOFHJIGPMH(BADFNEBCNNH KHKLJBKIGHL, Guid JNIDIDAECAE, EMCPGICGOKA? FMNMOCIIIGL, Dictionary<Guid, BIOHAEANPIH> HKKBNPGGKBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x60D3040", Offset = "0x60D2440", VA = "0x1860D3040")]
	private static void KNNDOJFAAME(BADFNEBCNNH KHKLJBKIGHL, Dictionary<Guid, Guid> NHMILKHOPKK, Dictionary<int, int> AONGEMNHDDO, KKCPFDJMIOB CDMHBACEOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x60D2200", Offset = "0x60D1600", VA = "0x1860D2200")]
	public static void ILAPAMMDMPN(RepeatedField<BADFNEBCNNH> MGALGKDCGCE, KFAMKDOGEFK NNPNNLHCIEO, IEnumerable<ByteString> LKMKLEIKJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x60D10F0", Offset = "0x60D04F0", VA = "0x1860D10F0")]
	private static void CMDMDCAFKBK(RepeatedField<BADFNEBCNNH> MGALGKDCGCE, NKKAJOGLBKD DHCBJGDGEMM, ECDLKPAEMLM NCHNJNMOGOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct JAMAKHCJEOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public bool FHIDFELCLKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public bool FEMMOPDFOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public EMCPGICGOKA? FMNMOCIIIGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public EMCPGICGOKA? NCOMNCGBAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NGMKNOJAICO EDMGMHLJOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public ECDLKPAEMLM NCHNJNMOGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EIPAJBFPNFP GAIJDAAOIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public Guid JDCKLIBBGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public DBNBABCLCBA NCEINPLKDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public List<BADFNEBCNNH> CEMCDPCDLAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public Dictionary<string, object> DDNAGMLODBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public PLDPKGMKIGE KJMDMBIINOB;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct EMCPGICGOKA
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private const float PNDAHNGDDFP = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public Vector3 PICDPPHNNLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public Quaternion IHCJBCJFELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float AFPPFOOOELL;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Matrix4x4 OODPNNIDFKI
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x60CF2E0", Offset = "0x60CE6E0", VA = "0x1860CF2E0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1334350", Offset = "0x1333750", VA = "0x181334350")]
	public EMCPGICGOKA(Vector3 PICDPPHNNLH, Quaternion IHCJBCJFELL, float AFPPFOOOELL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x60CFA30", Offset = "0x60CEE30", VA = "0x1860CFA30")]
	public EMCPGICGOKA(GHPLKFGFKMN OGFIHEONADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x60CF970", Offset = "0x60CED70", VA = "0x1860CF970")]
	private EMCPGICGOKA(HLPBICLOCCP LPHFHPHOKLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x60CF160", Offset = "0x60CE560", VA = "0x1860CF160")]
	public static EMCPGICGOKA DEHDKCGAAFB(GIOOAMLAJBG KPIHEFINMCO)
	{
		return default(EMCPGICGOKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x60CF190", Offset = "0x60CE590", VA = "0x1860CF190")]
	public static EMCPGICGOKA FBFEEIGLDHE(EMCPGICGOKA GGEKFPEBLKN, EMCPGICGOKA MOCEFELONDF)
	{
		return default(EMCPGICGOKA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x60CF8D0", Offset = "0x60CECD0", VA = "0x1860CF8D0")]
	public static EMCPGICGOKA HPHCHABBDNG((Vector3, Quaternion, float) HIDEHJGLNHO)
	{
		return default(EMCPGICGOKA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x60CF7D0", Offset = "0x60CEBD0", VA = "0x1860CF7D0")]
	public static EMCPGICGOKA HPHCHABBDNG(Matrix4x4 APCCMEFGFJN)
	{
		return default(EMCPGICGOKA);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x60CF640", Offset = "0x60CEA40", VA = "0x1860CF640")]
	public EMCPGICGOKA HEFMPPKBABN(Matrix4x4 CACALPHNCBH)
	{
		return default(EMCPGICGOKA);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x60CF920", Offset = "0x60CED20", VA = "0x1860CF920")]
	public static EMCPGICGOKA JKDBKBHPNNM(Vector3 PICDPPHNNLH)
	{
		return default(EMCPGICGOKA);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x60CF3E0", Offset = "0x60CE7E0", VA = "0x1860CF3E0")]
	[CompilerGenerated]
	internal static EMCPGICGOKA FLKHBIICOLD(GIOOAMLAJBG PPCJAOBHBIP)
	{
		return default(EMCPGICGOKA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class GOFBLCNJEOG : HONAECCINDO
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x60CFB00", Offset = "0x60CEF00", VA = "0x1860CFB00", Slot = "4")]
	public void HBGNEEALPPC(KMGNOIMHKHJ IJHFDPKJCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x60CFE60", Offset = "0x60CF260", VA = "0x1860CFE60")]
	private void HIDPJKFKAJH(Dictionary<Guid, Guid> LLBKGIKFEGO, BLHCEBIBKMK DEHBAEGFMIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x60CFE00", Offset = "0x60CF200", VA = "0x1860CFE00")]
	private void HIDPJKFKAJH(Dictionary<Guid, Guid> LLBKGIKFEGO, BIGKCMKJILG LOMCIIKAHDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x60CFBB0", Offset = "0x60CEFB0", VA = "0x1860CFBB0")]
	private void HIDPJKFKAJH(Dictionary<Guid, Guid> LLBKGIKFEGO, PLAODGEBNOO ABDIMIAKFPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public GOFBLCNJEOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class BNFEGAAIBJP : HONAECCINDO
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x60CE010", Offset = "0x60CD410", VA = "0x1860CE010", Slot = "4")]
	public void HBGNEEALPPC(KMGNOIMHKHJ IJHFDPKJCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public BNFEGAAIBJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class PCKLJKDILHI : HONAECCINDO
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x60D53B0", Offset = "0x60D47B0", VA = "0x1860D53B0", Slot = "4")]
	public void HBGNEEALPPC(KMGNOIMHKHJ IJHFDPKJCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public PCKLJKDILHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class HCELKONIAEB : HONAECCINDO
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x60D0390", Offset = "0x60CF790", VA = "0x1860D0390", Slot = "4")]
	public void HBGNEEALPPC(KMGNOIMHKHJ IJHFDPKJCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public HCELKONIAEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class BIPHPENNCBG : HONAECCINDO
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x60CDBA0", Offset = "0x60CCFA0", VA = "0x1860CDBA0", Slot = "4")]
	public void HBGNEEALPPC(KMGNOIMHKHJ IJHFDPKJCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public BIPHPENNCBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class KNLOIDHLICD : HONAECCINDO
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x60D0AF0", Offset = "0x60CFEF0", VA = "0x1860D0AF0", Slot = "4")]
	public void HBGNEEALPPC(KMGNOIMHKHJ IJHFDPKJCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public KNLOIDHLICD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class ALEKHDBPPAM : HONAECCINDO
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x60CD9B0", Offset = "0x60CCDB0", VA = "0x1860CD9B0", Slot = "4")]
	public void HBGNEEALPPC(KMGNOIMHKHJ IJHFDPKJCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public ALEKHDBPPAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class IPBFBGGGKJM : HONAECCINDO
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x60D04E0", Offset = "0x60CF8E0", VA = "0x1860D04E0", Slot = "4")]
	public void HBGNEEALPPC(KMGNOIMHKHJ IJHFDPKJCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public IPBFBGGGKJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class PNNJHBHDFFJ : HONAECCINDO
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x60D6870", Offset = "0x60D5C70", VA = "0x1860D6870", Slot = "4")]
	public void HBGNEEALPPC(KMGNOIMHKHJ IJHFDPKJCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public PNNJHBHDFFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class DHPLNOLCLLO : HONAECCINDO
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x60CE1D0", Offset = "0x60CD5D0", VA = "0x1860CE1D0", Slot = "4")]
	public void HBGNEEALPPC(KMGNOIMHKHJ IJHFDPKJCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public DHPLNOLCLLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class BLBLNBENCGF : HONAECCINDO
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x60CDDB0", Offset = "0x60CD1B0", VA = "0x1860CDDB0", Slot = "4")]
	public void HBGNEEALPPC(KMGNOIMHKHJ IJHFDPKJCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public BLBLNBENCGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class BMGAMGJEOKE : HONAECCINDO
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly System.Random CMJDFMHPHIM;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x60CDED0", Offset = "0x60CD2D0", VA = "0x1860CDED0", Slot = "4")]
	public void HBGNEEALPPC(KMGNOIMHKHJ IJHFDPKJCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public BMGAMGJEOKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct POMACAHPFND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public KKCPFDJMIOB NHBDMCDLELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public JKGJNLGGOAH NCLKJBOBBEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Dictionary<int, int> AONGEMNHDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public Dictionary<Guid, Guid> ACGENMJIPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public PLDPKGMKIGE KJMDMBIINOB;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface HONAECCINDO
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HBGNEEALPPC(KMGNOIMHKHJ IJHFDPKJCAE);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class DMCGDMECDIP
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static readonly HONAECCINDO[] BIKJPGDGBCA;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x60CE3A0", Offset = "0x60CD7A0", VA = "0x1860CE3A0")]
	public static void GPIMDDKFGPF(BADFNEBCNNH HIDEHJGLNHO, Dictionary<Guid, Guid> AOCALMJIHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x60CE5B0", Offset = "0x60CD9B0", VA = "0x1860CE5B0")]
	public static void NKGDCPDDEFO(BADFNEBCNNH? HIDEHJGLNHO, KCAMCABDPPI MMNNFGPOAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x60CE7A0", Offset = "0x60CDBA0", VA = "0x1860CE7A0")]
	public static void PKJCIKLFOEE(KMGNOIMHKHJ IJHFDPKJCAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct KMGNOIMHKHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public KKCPFDJMIOB JFALFLANGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public BADFNEBCNNH KHKLJBKIGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Dictionary<int, int> AONGEMNHDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public Dictionary<Guid, Guid> ACGENMJIPMB;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x60D0A20", Offset = "0x60CFE20", VA = "0x1860D0A20")]
	public Guid PFOAHKHENNL(Guid NPIFLODGAHD)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface PLDPKGMKIGE
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int GFFKOMCJHGO, out Guid ALKCDEBDKID);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class PHJGAMCCJEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly HashSet<string> OHAOEANAAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<long, int> NKGCOMONCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HashSet<Guid> BKKGNHEMAMM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyCollection<string> PJCKJLCFGOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x72B010", Offset = "0x72A410", VA = "0x18072B010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<long, int> OOGCLIFJJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x60D6420", Offset = "0x60D5820", VA = "0x1860D6420")]
	public static PHJGAMCCJEB NEINADCIEED(ALDNBFOLDOE GOKPFGBACOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x60D56F0", Offset = "0x60D4AF0", VA = "0x1860D56F0")]
	public static PHJGAMCCJEB KDHMBHIGCPB(CDGJHOJBAMH IOINJHPBDIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x60D6500", Offset = "0x60D5900", VA = "0x1860D6500")]
	public static PHJGAMCCJEB POLAPMOMKME(IEnumerable<string> OHAOEANAAAO, IDictionary<long, int> CHGHPOBPNIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x60D6650", Offset = "0x60D5A50", VA = "0x1860D6650")]
	private PHJGAMCCJEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x60D6750", Offset = "0x60D5B50", VA = "0x1860D6750")]
	private PHJGAMCCJEB(IEnumerable<string> OHAOEANAAAO, IDictionary<long, int> CHGHPOBPNIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x60D6260", Offset = "0x60D5660", VA = "0x1860D6260")]
	private void KFFBEOIPICP(ALDNBFOLDOE GOKPFGBACOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x60D60A0", Offset = "0x60D54A0", VA = "0x1860D60A0")]
	private void KFFBEOIPICP(CDGJHOJBAMH IOINJHPBDIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x60D5B10", Offset = "0x60D4F10", VA = "0x1860D5B10")]
	private void KFFBEOIPICP(KFAMKDOGEFK? EAGPPNPHOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x60D5F30", Offset = "0x60D5330", VA = "0x1860D5F30")]
	private void KFFBEOIPICP(PHACOPFCMNK? PPCJAOBHBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x60D5760", Offset = "0x60D4B60", VA = "0x1860D5760")]
	private void KFFBEOIPICP(BADFNEBCNNH? KHKLJBKIGHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x60D6490", Offset = "0x60D5890", VA = "0x1860D6490")]
	private void NKOFEGANFDE(string? EONJLFKAPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x60D5520", Offset = "0x60D4920", VA = "0x1860D5520")]
	private void DJNGILAHOMK(KMPBJFNLAHG? CINNKJMDFDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x60D5600", Offset = "0x60D4A00", VA = "0x1860D5600")]
	private void DJNGILAHOMK(CDODNLDOHKN? CINNKJMDFDF)
	{
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
