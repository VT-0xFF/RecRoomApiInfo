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
		[Cpp2IlInjected.Address(RVA = "0x67FB40", Offset = "0x67EB40", VA = "0x18067FB40")]
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
		[Cpp2IlInjected.Address(RVA = "0x5BF2350", Offset = "0x5BF1350", VA = "0x185BF2350")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F8000", Offset = "0x7F7000", VA = "0x1807F8000")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KGNEOCEACAO
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5BF1C90", Offset = "0x5BF0C90", VA = "0x185BF1C90")]
	public static bool OOGEJHCKOOD(ABLGFFMDBKO OOMHJIIFJLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5BF1910", Offset = "0x5BF0910", VA = "0x185BF1910")]
	private static bool OOGEJHCKOOD(JGDCJMONMPI GGCLNKGONMF, ref ABLGFFMDBKO OOMHJIIFJLI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct CJNALJNMLIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public List<EPAMCLOEEBK> EICIKLFECIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public IEnumerable<JIBCLFPIIEE> LIIFDGAFINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public BJCNJMACNDG DEBEAKNKLND;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface BIDBNJDKIIL
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(NEAAEBOMGJB FILAKGLBGGA, out Dictionary<int, int> EINNCMHFGBI);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(GMDPNKPCIHK NKHMNFPCKCN, KMJJNEHCBKN PFOBFIHHCHB);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface IEOEGONLEFP
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
public sealed class JNBIJDFOFEA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Dictionary<Guid, Guid> KPEJPOCAGEC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Dictionary<Guid, Guid> OEHCHPFDCDD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x67FAC0", Offset = "0x67EAC0", VA = "0x18067FAC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x67EF40", Offset = "0x67DF40", VA = "0x18067EF40")]
	public JNBIJDFOFEA(Dictionary<Guid, Guid> KPEJPOCAGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5BF0FC0", Offset = "0x5BEFFC0", VA = "0x185BF0FC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class AKPHEAFPEIJ
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private class CEGHMAHBJBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly HashSet<JIBCLFPIIEE> FDKOHJFMCFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly HashSet<HMMAFAGMNGG> DBANPGMGDPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly List<HMNMOPABEBB> ODMGENAFLOI;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5BEF310", Offset = "0x5BEE310", VA = "0x185BEF310")]
		public CEGHMAHBJBJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class DOBHLIBINIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public HMMAFAGMNGG destinationGraph;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public DOBHLIBINIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5BEF4E0", Offset = "0x5BEE4E0", VA = "0x185BEF4E0")]
		internal bool <InitializeCircuitsV2Remapping>b__0(LNKAPGOJAIK n)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class PLCGAEMLHEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int mpif;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public PLCGAEMLHEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5BF27E0", Offset = "0x5BF17E0", VA = "0x185BF27E0")]
		internal void <InitializeCircuitsV2Remapping>b__1(LNKAPGOJAIK n)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5BEC480", Offset = "0x5BEB480", VA = "0x185BEC480")]
	public static CIDKOGGHOGP KPBKIPOLNII(CJNALJNMLIO NLAAGIPDIGD, out BBOIFEEDIHJ KEECOGGAJJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5BECBD0", Offset = "0x5BEBBD0", VA = "0x185BECBD0")]
	private static void MAJDBKCPKFN(CIDKOGGHOGP MEDKDLPFJEH, CEGHMAHBJBJ HPEHLPCGDKB, out BBOIFEEDIHJ KEECOGGAJJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5BECAB0", Offset = "0x5BEBAB0", VA = "0x185BECAB0")]
	private static void LEDACMLHKOC(EPAMCLOEEBK BDLGFMNECCO, CEGHMAHBJBJ HPEHLPCGDKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5BEDA80", Offset = "0x5BECA80", VA = "0x185BEDA80")]
	private static void OBBOPFPLLLL(CIDKOGGHOGP MEDKDLPFJEH, CEGHMAHBJBJ HPEHLPCGDKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5BECCD0", Offset = "0x5BEBCD0", VA = "0x185BECCD0")]
	private static void MCKNDMDKHLD(ref CJNALJNMLIO IABACHPANKK, CEGHMAHBJBJ HPEHLPCGDKB, EPAMCLOEEBK BDLGFMNECCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5BE9DB0", Offset = "0x5BE8DB0", VA = "0x185BE9DB0")]
	public static bool BBNOBEIPHCN(CIDKOGGHOGP MEDKDLPFJEH, DCGAFBKOKJD CNCLGNGPOFG, out JNBIJDFOFEA? KCBBIDNFPHM, out string? HMOPFJALLDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5BEC2F0", Offset = "0x5BEB2F0", VA = "0x185BEC2F0")]
	private static void IKKBLEAFOLN(CIDKOGGHOGP MEDKDLPFJEH, ref DCGAFBKOKJD CNCLGNGPOFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5BEAAF0", Offset = "0x5BE9AF0", VA = "0x185BEAAF0")]
	private static void EGDOAPHFPKG(CIDKOGGHOGP MEDKDLPFJEH, ref DCGAFBKOKJD CNCLGNGPOFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5BEA4D0", Offset = "0x5BE94D0", VA = "0x185BEA4D0")]
	private static bool ECDJDKDBLDL(CIDKOGGHOGP MEDKDLPFJEH, GMDPNKPCIHK NKHMNFPCKCN, ref DCGAFBKOKJD CNCLGNGPOFG, out string HMOPFJALLDF, out Dictionary<int, int> EINNCMHFGBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5BEB610", Offset = "0x5BEA610", VA = "0x185BEB610")]
	private static Dictionary<Guid, JGDCJMONMPI> HHDDDCPHKMG(CIDKOGGHOGP MEDKDLPFJEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5BEAB30", Offset = "0x5BE9B30", VA = "0x185BEAB30")]
	private static bool FMMCOFFEEEG(CIDKOGGHOGP MEDKDLPFJEH, ref DCGAFBKOKJD CNCLGNGPOFG, out string? HMOPFJALLDF, out EAOMGBBMPGE? HLNEPCODJPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5BEC3F0", Offset = "0x5BEB3F0", VA = "0x185BEC3F0")]
	private static void KIJMKPDDEGC(bool PJPNCMPLCEM, EPAMCLOEEBK BAKMJFIKFPC, Dictionary<Guid, Guid> IOMJDKNMAOB, EAOMGBBMPGE CPCJNAMIHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5BEBEC0", Offset = "0x5BEAEC0", VA = "0x185BEBEC0")]
	private static void IFMLJEIGLAM(bool PJPNCMPLCEM, EPAMCLOEEBK BAKMJFIKFPC, EAOMGBBMPGE HLNEPCODJPL, Guid KIAMKOOBCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5BEDD20", Offset = "0x5BECD20", VA = "0x185BEDD20")]
	private static void PLMFDDDCMGL(EPAMCLOEEBK BAKMJFIKFPC, Guid JEKPDNNJDPI, KCOEOKJIION? ANMOBNEHFEG, Dictionary<Guid, JGDCJMONMPI> AHAMAOGDIBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5BEB520", Offset = "0x5BEA520", VA = "0x185BEB520")]
	private static void GGOFEDMGKFA(EPAMCLOEEBK BAKMJFIKFPC, Dictionary<Guid, Guid> IOMJDKNMAOB, Dictionary<int, int> IADDMEIPGAC, GMDPNKPCIHK AKAGCKOBDJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5BEB880", Offset = "0x5BEA880", VA = "0x185BEB880")]
	public static void HMIBJEMBPPI(RepeatedField<EPAMCLOEEBK> AMKKBDJGMJF, NFKEEHEFFLB HOEDANDBKPH, IEnumerable<ByteString> CCHOEEHIIKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5BECF90", Offset = "0x5BEBF90", VA = "0x185BECF90")]
	private static void NEOAIFANKDF(RepeatedField<EPAMCLOEEBK> AMKKBDJGMJF, BHFICIJBELM GIOMNCCOGBO, IEOEGONLEFP JCJMIAFKMAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct DCGAFBKOKJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public bool PJPNCMPLCEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public bool MPDBNBCBCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public KCOEOKJIION? ANMOBNEHFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public KCOEOKJIION? LONFLAFPPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public BJIOCODCPME ANBFGFPEDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public IEOEGONLEFP JCJMIAFKMAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public BIDBNJDKIIL BDGODFOJHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public Guid KIAMKOOBCHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public BJCNJMACNDG DEBEAKNKLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public List<EPAMCLOEEBK> HNAJKHECMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public Dictionary<string, object> IJKOBBEAICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public LDDAJCNFJBD DCKPBBGEKLA;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct KCOEOKJIION
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private const float IHKJDAKODLA = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public Vector3 IJBELJOFGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public Quaternion EIGPDNIOAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float LAKBNONGKOL;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Matrix4x4 IDMCBLKMFKA
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5BF1490", Offset = "0x5BF0490", VA = "0x185BF1490")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1519F50", Offset = "0x1518F50", VA = "0x181519F50")]
	public KCOEOKJIION(Vector3 IJBELJOFGFA, Quaternion EIGPDNIOAKK, float LAKBNONGKOL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5BF17F0", Offset = "0x5BF07F0", VA = "0x185BF17F0")]
	public KCOEOKJIION(KHNINFNFLEF FMIFEFENIMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5BF1790", Offset = "0x5BF0790", VA = "0x185BF1790")]
	private KCOEOKJIION(AEFIPOJICPP IHFGLLPMDCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5BF1590", Offset = "0x5BF0590", VA = "0x185BF1590")]
	public static KCOEOKJIION NFJOPKDFOEH(JIBCLFPIIEE ODOHBAKGFIK)
	{
		return default(KCOEOKJIION);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5BF1340", Offset = "0x5BF0340", VA = "0x185BF1340")]
	public static KCOEOKJIION MDIKKCNONIN(KCOEOKJIION ICMEPOIJCJO, KCOEOKJIION KDNOLNKFJDL)
	{
		return default(KCOEOKJIION);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5BF11F0", Offset = "0x5BF01F0", VA = "0x185BF11F0")]
	public static KCOEOKJIION LFOOIECCIPM((Vector3, Quaternion, float) FILAKGLBGGA)
	{
		return default(KCOEOKJIION);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5BF1240", Offset = "0x5BF0240", VA = "0x185BF1240")]
	public static KCOEOKJIION LFOOIECCIPM(Matrix4x4 GAHCGJHCODG)
	{
		return default(KCOEOKJIION);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5BF1010", Offset = "0x5BF0010", VA = "0x185BF1010")]
	public KCOEOKJIION BGODIPFIOAL(Matrix4x4 FLCFNMLPAML)
	{
		return default(KCOEOKJIION);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5BF11A0", Offset = "0x5BF01A0", VA = "0x185BF11A0")]
	public static KCOEOKJIION HEGDFALBMEN(Vector3 IJBELJOFGFA)
	{
		return default(KCOEOKJIION);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5BF15C0", Offset = "0x5BF05C0", VA = "0x185BF15C0")]
	[CompilerGenerated]
	internal static KCOEOKJIION OIJNMPBJILC(JIBCLFPIIEE ABKPGPJAFGM)
	{
		return default(KCOEOKJIION);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class HIAIFCDCDHF : PGKNDKNCPBE
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5BF0BD0", Offset = "0x5BEFBD0", VA = "0x185BF0BD0", Slot = "4")]
	public void GJPMOBHIDNK(DIGLEIMJJLL KDFKNLJOOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5BF0450", Offset = "0x5BEF450", VA = "0x185BF0450")]
	private void GFKJMLPGEOO(Dictionary<Guid, Guid> MFDJCJLALKM, FPCNHPIGHIC AHFBJECJDOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5BF03F0", Offset = "0x5BEF3F0", VA = "0x185BF03F0")]
	private void GFKJMLPGEOO(Dictionary<Guid, Guid> MFDJCJLALKM, KKGPGIMDMJA BLAGCBCKMDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5BF0980", Offset = "0x5BEF980", VA = "0x185BF0980")]
	private void GFKJMLPGEOO(Dictionary<Guid, Guid> MFDJCJLALKM, AMMPFNEPACL PBHJANJDHHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public HIAIFCDCDHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class MNCBLNABMOE : PGKNDKNCPBE
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5BF1FC0", Offset = "0x5BF0FC0", VA = "0x185BF1FC0", Slot = "4")]
	public void GJPMOBHIDNK(DIGLEIMJJLL KDFKNLJOOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public MNCBLNABMOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class JAENDGNJPOO : PGKNDKNCPBE
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5BF0E50", Offset = "0x5BEFE50", VA = "0x185BF0E50", Slot = "4")]
	public void GJPMOBHIDNK(DIGLEIMJJLL KDFKNLJOOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public JAENDGNJPOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class NILOHEOEEOO : PGKNDKNCPBE
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5BF2080", Offset = "0x5BF1080", VA = "0x185BF2080", Slot = "4")]
	public void GJPMOBHIDNK(DIGLEIMJJLL KDFKNLJOOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public NILOHEOEEOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class OPAMKMDIGDN : PGKNDKNCPBE
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5BF23E0", Offset = "0x5BF13E0", VA = "0x185BF23E0", Slot = "4")]
	public void GJPMOBHIDNK(DIGLEIMJJLL KDFKNLJOOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public OPAMKMDIGDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class NLIHEBCJPNB : PGKNDKNCPBE
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5BF21D0", Offset = "0x5BF11D0", VA = "0x185BF21D0", Slot = "4")]
	public void GJPMOBHIDNK(DIGLEIMJJLL KDFKNLJOOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public NLIHEBCJPNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class PGKOJMCDNHO : PGKNDKNCPBE
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5BF25F0", Offset = "0x5BF15F0", VA = "0x185BF25F0", Slot = "4")]
	public void GJPMOBHIDNK(DIGLEIMJJLL KDFKNLJOOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public PGKOJMCDNHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class FJJDEBEGLOJ : PGKNDKNCPBE
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5BF02D0", Offset = "0x5BEF2D0", VA = "0x185BF02D0", Slot = "4")]
	public void GJPMOBHIDNK(DIGLEIMJJLL KDFKNLJOOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public FJJDEBEGLOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class MMPKHENLJED : PGKNDKNCPBE
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5BF1DF0", Offset = "0x5BF0DF0", VA = "0x185BF1DF0", Slot = "4")]
	public void GJPMOBHIDNK(DIGLEIMJJLL KDFKNLJOOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public MMPKHENLJED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class HNKBNHFCION : PGKNDKNCPBE
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5BF0C80", Offset = "0x5BEFC80", VA = "0x185BF0C80", Slot = "4")]
	public void GJPMOBHIDNK(DIGLEIMJJLL KDFKNLJOOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public HNKBNHFCION()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class LEPGDBDLMGB : PGKNDKNCPBE
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5BF1CD0", Offset = "0x5BF0CD0", VA = "0x185BF1CD0", Slot = "4")]
	public void GJPMOBHIDNK(DIGLEIMJJLL KDFKNLJOOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public LEPGDBDLMGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class AHDNNGOOKOA : PGKNDKNCPBE
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly System.Random LJBEJELLGOA;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5BE9C70", Offset = "0x5BE8C70", VA = "0x185BE9C70", Slot = "4")]
	public void GJPMOBHIDNK(DIGLEIMJJLL KDFKNLJOOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public AHDNNGOOKOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct ABLGFFMDBKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public GMDPNKPCIHK IIJDDKBOPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public BGCFIBNNBIF BHLLLMJLEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public Dictionary<int, int> IADDMEIPGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Dictionary<Guid, Guid> ACIHCMJMDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public LDDAJCNFJBD DCKPBBGEKLA;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface PGKNDKNCPBE
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GJPMOBHIDNK(DIGLEIMJJLL KDFKNLJOOHC);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface LDDAJCNFJBD
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int BCGEJGIGJCJ, out Guid CFIGNFFEDLI);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class FDGAKNELOPD
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static readonly PGKNDKNCPBE[] NCMPDNODKHG;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5BEF720", Offset = "0x5BEE720", VA = "0x185BEF720")]
	public static void IHHMCJGJJPH(EPAMCLOEEBK FILAKGLBGGA, Dictionary<Guid, Guid> ALMGADALEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5BEF530", Offset = "0x5BEE530", VA = "0x185BEF530")]
	public static void DMJONCOLODK(EPAMCLOEEBK? FILAKGLBGGA, EAOMGBBMPGE CPCJNAMIHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5BEF930", Offset = "0x5BEE930", VA = "0x185BEF930")]
	public static void OOGEJHCKOOD(DIGLEIMJJLL KDFKNLJOOHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct DIGLEIMJJLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public GMDPNKPCIHK AGIEGDBIDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public EPAMCLOEEBK BAKMJFIKFPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Dictionary<int, int> IADDMEIPGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Dictionary<Guid, Guid> ACIHCMJMDFB;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5BEF410", Offset = "0x5BEE410", VA = "0x185BEF410")]
	public Guid OPNHJFPLHAC(Guid FBKLHONPMNF)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class ALOGFNPDBKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly HashSet<string> AAODPOEGAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly Dictionary<long, int> HPODBLHMACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly HashSet<Guid> AJHAOPJNEND;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyCollection<string> PJOICJBIMCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x67FAC0", Offset = "0x67EAC0", VA = "0x18067FAC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<long, int> HCGCDPCEFBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5BEE350", Offset = "0x5BED350", VA = "0x185BEE350")]
	public static ALOGFNPDBKM FNGCHGKLGJM(DOJAMBMLNII GPCLICNBEEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5BEE3C0", Offset = "0x5BED3C0", VA = "0x185BEE3C0")]
	public static ALOGFNPDBKM FPEADBEILJE(CIDKOGGHOGP IPCLKCIFDNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5BEDFC0", Offset = "0x5BECFC0", VA = "0x185BEDFC0")]
	public static ALOGFNPDBKM AIENOMACHEK(IEnumerable<string> AAODPOEGAEI, IDictionary<long, int> NKMLECHPBBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5BEF0F0", Offset = "0x5BEE0F0", VA = "0x185BEF0F0")]
	private ALOGFNPDBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5BEF1F0", Offset = "0x5BEE1F0", VA = "0x185BEF1F0")]
	private ALOGFNPDBKM(IEnumerable<string> AAODPOEGAEI, IDictionary<long, int> NKMLECHPBBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5BEE950", Offset = "0x5BED950", VA = "0x185BEE950")]
	private void JNLNJIEHCPE(DOJAMBMLNII GPCLICNBEEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5BEEB10", Offset = "0x5BEDB10", VA = "0x185BEEB10")]
	private void JNLNJIEHCPE(CIDKOGGHOGP IPCLKCIFDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5BEECD0", Offset = "0x5BEDCD0", VA = "0x185BEECD0")]
	private void JNLNJIEHCPE(NFKEEHEFFLB JMLKLPJONJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5BEE430", Offset = "0x5BED430", VA = "0x185BEE430")]
	private void JNLNJIEHCPE(LNKAPGOJAIK ABKPGPJAFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5BEE5A0", Offset = "0x5BED5A0", VA = "0x185BEE5A0")]
	private void JNLNJIEHCPE(EPAMCLOEEBK BAKMJFIKFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5BEE2E0", Offset = "0x5BED2E0", VA = "0x185BEE2E0")]
	private void BBFCGFCGNNJ(string LMAMBCJAPIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5BEE110", Offset = "0x5BED110", VA = "0x185BEE110")]
	private void ALNPMDPCKPA(BALPHNDGKEM LCDKANLDCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5BEE1F0", Offset = "0x5BED1F0", VA = "0x185BEE1F0")]
	private void ALNPMDPCKPA(LACCEDPGLEJ LCDKANLDCJP)
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
