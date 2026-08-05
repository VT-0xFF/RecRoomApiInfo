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
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x606CEE0", Offset = "0x606B8E0", VA = "0x18606CEE0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA36880", Offset = "0xA35280", VA = "0x180A36880")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JHBBFOBMCAE
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x606CBA0", Offset = "0x606B5A0", VA = "0x18606CBA0")]
	public static bool PKJCIKLFOEE(POMACAHPFND MFBGOEFDCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x606C820", Offset = "0x606B220", VA = "0x18606C820")]
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
		[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7B6A40", Offset = "0x7B5440", VA = "0x1807B6A40")]
	public JKMAMAJMGGE(Dictionary<Guid, Guid> DKLIIJOFLIL, Dictionary<Guid, Guid> LACNJGCDCMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x606CBE0", Offset = "0x606B5E0", VA = "0x18606CBE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x606A2F0", Offset = "0x6068CF0", VA = "0x18606A2F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public NEKKOALNJOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x606CE90", Offset = "0x606B890", VA = "0x18606CE90")]
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
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public ELCCGCNNPCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x606B360", Offset = "0x6069D60", VA = "0x18606B360")]
		internal void <InitializeCircuitsV2Remapping>b__1(PHACOPFCMNK n)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x606F350", Offset = "0x606DD50", VA = "0x18606F350")]
	public static CDGJHOJBAMH KOAKMNKIAIP(CPKEPDDGPNG KDMEODNKEJF, out ALEJDGFCOID FENONIGIODL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x606D210", Offset = "0x606BC10", VA = "0x18606D210")]
	private static void CLMLHIJADJO(CDGJHOJBAMH IJFEAAFBFHI, DGBDDJALILI NKNHJADJDNP, out ALEJDGFCOID FENONIGIODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x606FDA0", Offset = "0x606E7A0", VA = "0x18606FDA0")]
	private static void NBGMBKKBCCG(BADFNEBCNNH DLFFNMDAELA, DGBDDJALILI NKNHJADJDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x606CF70", Offset = "0x606B970", VA = "0x18606CF70")]
	private static void BEBKIODMBIL(CDGJHOJBAMH IJFEAAFBFHI, DGBDDJALILI NKNHJADJDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6070870", Offset = "0x606F270", VA = "0x186070870")]
	private static void PGAMFILLJCD(ref CPKEPDDGPNG OBCFFBHFEKN, DGBDDJALILI NKNHJADJDNP, BADFNEBCNNH DLFFNMDAELA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x606EAA0", Offset = "0x606D4A0", VA = "0x18606EAA0")]
	public static bool KBBNLGNNOMO(CDGJHOJBAMH IJFEAAFBFHI, JAMAKHCJEOH JMJGABBKCAM, out JKMAMAJMGGE? CFJLBGEKHDF, out string? NOGDNAGMMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x606F980", Offset = "0x606E380", VA = "0x18606F980")]
	private static void LBBBPJOKEPO(CDGJHOJBAMH IJFEAAFBFHI, ref JAMAKHCJEOH JMJGABBKCAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x606FEC0", Offset = "0x606E8C0", VA = "0x18606FEC0")]
	public static Dictionary<Guid, Guid> OCBJBCALBKC(IEnumerable<BADFNEBCNNH> BFDBBIEAJIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x606EA60", Offset = "0x606D460", VA = "0x18606EA60")]
	private static void KABDBFFBJFM(CDGJHOJBAMH IJFEAAFBFHI, ref JAMAKHCJEOH JMJGABBKCAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x606DE00", Offset = "0x606C800", VA = "0x18606DE00")]
	private static bool CNDNBIPAGKC(CDGJHOJBAMH IJFEAAFBFHI, KKCPFDJMIOB KFIABPAPOIH, ref JAMAKHCJEOH JMJGABBKCAM, out string NOGDNAGMMCO, out Dictionary<int, int> EBIDFFIMDLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x606FB30", Offset = "0x606E530", VA = "0x18606FB30")]
	private static Dictionary<Guid, BIOHAEANPIH> MGENJCIAEMP(CDGJHOJBAMH IJFEAAFBFHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6070B30", Offset = "0x606F530", VA = "0x186070B30")]
	private static bool PPKLOPBJPBL(CDGJHOJBAMH IJFEAAFBFHI, ref JAMAKHCJEOH JMJGABBKCAM, out string? NOGDNAGMMCO, out KCAMCABDPPI? KICBCLDGBJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x606FAA0", Offset = "0x606E4A0", VA = "0x18606FAA0")]
	private static void MEKCIGNCIAO(bool FHIDFELCLKC, BADFNEBCNNH KHKLJBKIGHL, Dictionary<Guid, Guid> NHMILKHOPKK, KCAMCABDPPI MMNNFGPOAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x60701A0", Offset = "0x606EBA0", VA = "0x1860701A0")]
	private static void OPIMFHGIOKC(bool FHIDFELCLKC, BADFNEBCNNH KHKLJBKIGHL, KCAMCABDPPI KICBCLDGBJP, Guid JDCKLIBBGLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x60705D0", Offset = "0x606EFD0", VA = "0x1860705D0")]
	private static void PAOFHJIGPMH(BADFNEBCNNH KHKLJBKIGHL, Guid JNIDIDAECAE, EMCPGICGOKA? FMNMOCIIIGL, Dictionary<Guid, BIOHAEANPIH> HKKBNPGGKBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x606F260", Offset = "0x606DC60", VA = "0x18606F260")]
	private static void KNNDOJFAAME(BADFNEBCNNH KHKLJBKIGHL, Dictionary<Guid, Guid> NHMILKHOPKK, Dictionary<int, int> AONGEMNHDDO, KKCPFDJMIOB CDMHBACEOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x606E420", Offset = "0x606CE20", VA = "0x18606E420")]
	public static void ILAPAMMDMPN(RepeatedField<BADFNEBCNNH> MGALGKDCGCE, KFAMKDOGEFK NNPNNLHCIEO, IEnumerable<ByteString> LKMKLEIKJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x606D310", Offset = "0x606BD10", VA = "0x18606D310")]
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
		[Cpp2IlInjected.Address(RVA = "0x606B500", Offset = "0x6069F00", VA = "0x18606B500")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1487180", Offset = "0x1485B80", VA = "0x181487180")]
	public EMCPGICGOKA(Vector3 PICDPPHNNLH, Quaternion IHCJBCJFELL, float AFPPFOOOELL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x606BC50", Offset = "0x606A650", VA = "0x18606BC50")]
	public EMCPGICGOKA(GHPLKFGFKMN OGFIHEONADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x606BB90", Offset = "0x606A590", VA = "0x18606BB90")]
	private EMCPGICGOKA(HLPBICLOCCP LPHFHPHOKLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x606B380", Offset = "0x6069D80", VA = "0x18606B380")]
	public static EMCPGICGOKA DEHDKCGAAFB(GIOOAMLAJBG KPIHEFINMCO)
	{
		return default(EMCPGICGOKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x606B3B0", Offset = "0x6069DB0", VA = "0x18606B3B0")]
	public static EMCPGICGOKA FBFEEIGLDHE(EMCPGICGOKA GGEKFPEBLKN, EMCPGICGOKA MOCEFELONDF)
	{
		return default(EMCPGICGOKA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x606BAF0", Offset = "0x606A4F0", VA = "0x18606BAF0")]
	public static EMCPGICGOKA HPHCHABBDNG((Vector3, Quaternion, float) HIDEHJGLNHO)
	{
		return default(EMCPGICGOKA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x606B9F0", Offset = "0x606A3F0", VA = "0x18606B9F0")]
	public static EMCPGICGOKA HPHCHABBDNG(Matrix4x4 APCCMEFGFJN)
	{
		return default(EMCPGICGOKA);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x606B860", Offset = "0x606A260", VA = "0x18606B860")]
	public EMCPGICGOKA HEFMPPKBABN(Matrix4x4 CACALPHNCBH)
	{
		return default(EMCPGICGOKA);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x606BB40", Offset = "0x606A540", VA = "0x18606BB40")]
	public static EMCPGICGOKA JKDBKBHPNNM(Vector3 PICDPPHNNLH)
	{
		return default(EMCPGICGOKA);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x606B600", Offset = "0x606A000", VA = "0x18606B600")]
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
	[Cpp2IlInjected.Address(RVA = "0x606BD20", Offset = "0x606A720", VA = "0x18606BD20", Slot = "4")]
	public void HBGNEEALPPC(KMGNOIMHKHJ IJHFDPKJCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x606C080", Offset = "0x606AA80", VA = "0x18606C080")]
	private void HIDPJKFKAJH(Dictionary<Guid, Guid> LLBKGIKFEGO, BLHCEBIBKMK DEHBAEGFMIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x606C020", Offset = "0x606AA20", VA = "0x18606C020")]
	private void HIDPJKFKAJH(Dictionary<Guid, Guid> LLBKGIKFEGO, BIGKCMKJILG LOMCIIKAHDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x606BDD0", Offset = "0x606A7D0", VA = "0x18606BDD0")]
	private void HIDPJKFKAJH(Dictionary<Guid, Guid> LLBKGIKFEGO, PLAODGEBNOO ABDIMIAKFPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public GOFBLCNJEOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class BNFEGAAIBJP : HONAECCINDO
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x606A230", Offset = "0x6068C30", VA = "0x18606A230", Slot = "4")]
	public void HBGNEEALPPC(KMGNOIMHKHJ IJHFDPKJCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public BNFEGAAIBJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class PCKLJKDILHI : HONAECCINDO
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x60715D0", Offset = "0x606FFD0", VA = "0x1860715D0", Slot = "4")]
	public void HBGNEEALPPC(KMGNOIMHKHJ IJHFDPKJCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public PCKLJKDILHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class HCELKONIAEB : HONAECCINDO
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x606C5B0", Offset = "0x606AFB0", VA = "0x18606C5B0", Slot = "4")]
	public void HBGNEEALPPC(KMGNOIMHKHJ IJHFDPKJCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public HCELKONIAEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class BIPHPENNCBG : HONAECCINDO
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6069DC0", Offset = "0x60687C0", VA = "0x186069DC0", Slot = "4")]
	public void HBGNEEALPPC(KMGNOIMHKHJ IJHFDPKJCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public BIPHPENNCBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class KNLOIDHLICD : HONAECCINDO
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x606CD10", Offset = "0x606B710", VA = "0x18606CD10", Slot = "4")]
	public void HBGNEEALPPC(KMGNOIMHKHJ IJHFDPKJCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public KNLOIDHLICD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class ALEKHDBPPAM : HONAECCINDO
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6069BD0", Offset = "0x60685D0", VA = "0x186069BD0", Slot = "4")]
	public void HBGNEEALPPC(KMGNOIMHKHJ IJHFDPKJCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public ALEKHDBPPAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class IPBFBGGGKJM : HONAECCINDO
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x606C700", Offset = "0x606B100", VA = "0x18606C700", Slot = "4")]
	public void HBGNEEALPPC(KMGNOIMHKHJ IJHFDPKJCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public IPBFBGGGKJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class PNNJHBHDFFJ : HONAECCINDO
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6072A90", Offset = "0x6071490", VA = "0x186072A90", Slot = "4")]
	public void HBGNEEALPPC(KMGNOIMHKHJ IJHFDPKJCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public PNNJHBHDFFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class DHPLNOLCLLO : HONAECCINDO
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x606A3F0", Offset = "0x6068DF0", VA = "0x18606A3F0", Slot = "4")]
	public void HBGNEEALPPC(KMGNOIMHKHJ IJHFDPKJCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public DHPLNOLCLLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class BLBLNBENCGF : HONAECCINDO
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6069FD0", Offset = "0x60689D0", VA = "0x186069FD0", Slot = "4")]
	public void HBGNEEALPPC(KMGNOIMHKHJ IJHFDPKJCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x606A0F0", Offset = "0x6068AF0", VA = "0x18606A0F0", Slot = "4")]
	public void HBGNEEALPPC(KMGNOIMHKHJ IJHFDPKJCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x606A5C0", Offset = "0x6068FC0", VA = "0x18606A5C0")]
	public static void GPIMDDKFGPF(BADFNEBCNNH HIDEHJGLNHO, Dictionary<Guid, Guid> AOCALMJIHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x606A7D0", Offset = "0x60691D0", VA = "0x18606A7D0")]
	public static void NKGDCPDDEFO(BADFNEBCNNH? HIDEHJGLNHO, KCAMCABDPPI MMNNFGPOAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x606A9C0", Offset = "0x60693C0", VA = "0x18606A9C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x606CC40", Offset = "0x606B640", VA = "0x18606CC40")]
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
		[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<long, int> OOGCLIFJJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6072640", Offset = "0x6071040", VA = "0x186072640")]
	public static PHJGAMCCJEB NEINADCIEED(ALDNBFOLDOE GOKPFGBACOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6071910", Offset = "0x6070310", VA = "0x186071910")]
	public static PHJGAMCCJEB KDHMBHIGCPB(CDGJHOJBAMH IOINJHPBDIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6072720", Offset = "0x6071120", VA = "0x186072720")]
	public static PHJGAMCCJEB POLAPMOMKME(IEnumerable<string> OHAOEANAAAO, IDictionary<long, int> CHGHPOBPNIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6072870", Offset = "0x6071270", VA = "0x186072870")]
	private PHJGAMCCJEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6072970", Offset = "0x6071370", VA = "0x186072970")]
	private PHJGAMCCJEB(IEnumerable<string> OHAOEANAAAO, IDictionary<long, int> CHGHPOBPNIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6072480", Offset = "0x6070E80", VA = "0x186072480")]
	private void KFFBEOIPICP(ALDNBFOLDOE GOKPFGBACOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x60722C0", Offset = "0x6070CC0", VA = "0x1860722C0")]
	private void KFFBEOIPICP(CDGJHOJBAMH IOINJHPBDIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6071D30", Offset = "0x6070730", VA = "0x186071D30")]
	private void KFFBEOIPICP(KFAMKDOGEFK? EAGPPNPHOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6072150", Offset = "0x6070B50", VA = "0x186072150")]
	private void KFFBEOIPICP(PHACOPFCMNK? PPCJAOBHBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6071980", Offset = "0x6070380", VA = "0x186071980")]
	private void KFFBEOIPICP(BADFNEBCNNH? KHKLJBKIGHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x60726B0", Offset = "0x60710B0", VA = "0x1860726B0")]
	private void NKOFEGANFDE(string? EONJLFKAPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6071740", Offset = "0x6070140", VA = "0x186071740")]
	private void DJNGILAHOMK(KMPBJFNLAHG? CINNKJMDFDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6071820", Offset = "0x6070220", VA = "0x186071820")]
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
