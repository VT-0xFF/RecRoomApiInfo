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
		[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FC5A40", Offset = "0x1FC4840", VA = "0x181FC5A40")]
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
		[Cpp2IlInjected.Address(RVA = "0x11E9610", Offset = "0x11E8410", VA = "0x1811E9610")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KGNEOCEACAO
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1FC5380", Offset = "0x1FC4180", VA = "0x181FC5380")]
	public static bool OOGEJHCKOOD(ABLGFFMDBKO OOMHJIIFJLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1FC5000", Offset = "0x1FC3E00", VA = "0x181FC5000")]
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
		[Cpp2IlInjected.Address(RVA = "0x6AE8E0", Offset = "0x6AD6E0", VA = "0x1806AE8E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x85B5D0", Offset = "0x85A3D0", VA = "0x18085B5D0")]
	public JNBIJDFOFEA(Dictionary<Guid, Guid> KPEJPOCAGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1FC4690", Offset = "0x1FC3490", VA = "0x181FC4690", Slot = "4")]
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

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1FC2A30", Offset = "0x1FC1830", VA = "0x181FC2A30")]
		public CEGHMAHBJBJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class PCHBDLLLKNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public HMMAFAGMNGG destinationGraph;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public PCHBDLLLKNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1FC5CE0", Offset = "0x1FC4AE0", VA = "0x181FC5CE0")]
		internal bool <InitializeCircuitsV2Remapping>b__0(LNKAPGOJAIK n)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class BLFHJGJOFEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int mpif;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public BLFHJGJOFEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1FC2A10", Offset = "0x1FC1810", VA = "0x181FC2A10")]
		internal void <InitializeCircuitsV2Remapping>b__1(LNKAPGOJAIK n)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1FBFB80", Offset = "0x1FBE980", VA = "0x181FBFB80")]
	public static CIDKOGGHOGP KPBKIPOLNII(CJNALJNMLIO NLAAGIPDIGD, out BBOIFEEDIHJ KEECOGGAJJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1FC02D0", Offset = "0x1FBF0D0", VA = "0x181FC02D0")]
	private static void MAJDBKCPKFN(CIDKOGGHOGP MEDKDLPFJEH, CEGHMAHBJBJ HPEHLPCGDKB, out BBOIFEEDIHJ KEECOGGAJJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1FC01B0", Offset = "0x1FBEFB0", VA = "0x181FC01B0")]
	private static void LEDACMLHKOC(EPAMCLOEEBK BDLGFMNECCO, CEGHMAHBJBJ HPEHLPCGDKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1180", Offset = "0x1FBFF80", VA = "0x181FC1180")]
	private static void OBBOPFPLLLL(CIDKOGGHOGP MEDKDLPFJEH, CEGHMAHBJBJ HPEHLPCGDKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1FC03D0", Offset = "0x1FBF1D0", VA = "0x181FC03D0")]
	private static void MCKNDMDKHLD(ref CJNALJNMLIO IABACHPANKK, CEGHMAHBJBJ HPEHLPCGDKB, EPAMCLOEEBK BDLGFMNECCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD190", Offset = "0x1FBBF90", VA = "0x181FBD190")]
	public static bool BBNOBEIPHCN(CIDKOGGHOGP MEDKDLPFJEH, DCGAFBKOKJD CNCLGNGPOFG, out JNBIJDFOFEA? KCBBIDNFPHM, out string? HMOPFJALLDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF9D0", Offset = "0x1FBE7D0", VA = "0x181FBF9D0")]
	private static void IKKBLEAFOLN(CIDKOGGHOGP MEDKDLPFJEH, ref DCGAFBKOKJD CNCLGNGPOFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1FBE920", Offset = "0x1FBD720", VA = "0x181FBE920")]
	public static Dictionary<Guid, Guid> GEOOJOMEOLA(IEnumerable<EPAMCLOEEBK> KNBDNDDACPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1FBDEF0", Offset = "0x1FBCCF0", VA = "0x181FBDEF0")]
	private static void EGDOAPHFPKG(CIDKOGGHOGP MEDKDLPFJEH, ref DCGAFBKOKJD CNCLGNGPOFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD8D0", Offset = "0x1FBC6D0", VA = "0x181FBD8D0")]
	private static bool ECDJDKDBLDL(CIDKOGGHOGP MEDKDLPFJEH, GMDPNKPCIHK NKHMNFPCKCN, ref DCGAFBKOKJD CNCLGNGPOFG, out string HMOPFJALLDF, out Dictionary<int, int> EINNCMHFGBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1FBECF0", Offset = "0x1FBDAF0", VA = "0x181FBECF0")]
	private static Dictionary<Guid, JGDCJMONMPI> HHDDDCPHKMG(CIDKOGGHOGP MEDKDLPFJEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1FBDF30", Offset = "0x1FBCD30", VA = "0x181FBDF30")]
	private static bool FMMCOFFEEEG(CIDKOGGHOGP MEDKDLPFJEH, ref DCGAFBKOKJD CNCLGNGPOFG, out string? HMOPFJALLDF, out EAOMGBBMPGE? HLNEPCODJPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1FBFAF0", Offset = "0x1FBE8F0", VA = "0x181FBFAF0")]
	private static void KIJMKPDDEGC(bool PJPNCMPLCEM, EPAMCLOEEBK BAKMJFIKFPC, Dictionary<Guid, Guid> IOMJDKNMAOB, EAOMGBBMPGE CPCJNAMIHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF5A0", Offset = "0x1FBE3A0", VA = "0x181FBF5A0")]
	private static void IFMLJEIGLAM(bool PJPNCMPLCEM, EPAMCLOEEBK BAKMJFIKFPC, EAOMGBBMPGE HLNEPCODJPL, Guid KIAMKOOBCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1420", Offset = "0x1FC0220", VA = "0x181FC1420")]
	private static void PLMFDDDCMGL(EPAMCLOEEBK BAKMJFIKFPC, Guid JEKPDNNJDPI, KCOEOKJIION? ANMOBNEHFEG, Dictionary<Guid, JGDCJMONMPI> AHAMAOGDIBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1FBEC00", Offset = "0x1FBDA00", VA = "0x181FBEC00")]
	private static void GGOFEDMGKFA(EPAMCLOEEBK BAKMJFIKFPC, Dictionary<Guid, Guid> IOMJDKNMAOB, Dictionary<int, int> IADDMEIPGAC, GMDPNKPCIHK AKAGCKOBDJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1FBEF60", Offset = "0x1FBDD60", VA = "0x181FBEF60")]
	public static void HMIBJEMBPPI(RepeatedField<EPAMCLOEEBK> AMKKBDJGMJF, NFKEEHEFFLB HOEDANDBKPH, IEnumerable<ByteString> CCHOEEHIIKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1FC0690", Offset = "0x1FBF490", VA = "0x181FC0690")]
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
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1FC4B60", Offset = "0x1FC3960", VA = "0x181FC4B60")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1FC4EC0", Offset = "0x1FC3CC0", VA = "0x181FC4EC0")]
	public KCOEOKJIION(Vector3 IJBELJOFGFA, Quaternion EIGPDNIOAKK, float LAKBNONGKOL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1FC4EE0", Offset = "0x1FC3CE0", VA = "0x181FC4EE0")]
	public KCOEOKJIION(KHNINFNFLEF FMIFEFENIMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1FC4E60", Offset = "0x1FC3C60", VA = "0x181FC4E60")]
	private KCOEOKJIION(AEFIPOJICPP IHFGLLPMDCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1FC4C60", Offset = "0x1FC3A60", VA = "0x181FC4C60")]
	public static KCOEOKJIION NFJOPKDFOEH(JIBCLFPIIEE ODOHBAKGFIK)
	{
		return default(KCOEOKJIION);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1FC4A10", Offset = "0x1FC3810", VA = "0x181FC4A10")]
	public static KCOEOKJIION MDIKKCNONIN(KCOEOKJIION ICMEPOIJCJO, KCOEOKJIION KDNOLNKFJDL)
	{
		return default(KCOEOKJIION);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1FC48C0", Offset = "0x1FC36C0", VA = "0x181FC48C0")]
	public static KCOEOKJIION LFOOIECCIPM((Vector3, Quaternion, float) FILAKGLBGGA)
	{
		return default(KCOEOKJIION);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1FC4910", Offset = "0x1FC3710", VA = "0x181FC4910")]
	public static KCOEOKJIION LFOOIECCIPM(Matrix4x4 GAHCGJHCODG)
	{
		return default(KCOEOKJIION);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1FC46E0", Offset = "0x1FC34E0", VA = "0x181FC46E0")]
	public KCOEOKJIION BGODIPFIOAL(Matrix4x4 FLCFNMLPAML)
	{
		return default(KCOEOKJIION);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1FC4870", Offset = "0x1FC3670", VA = "0x181FC4870")]
	public static KCOEOKJIION HEGDFALBMEN(Vector3 IJBELJOFGFA)
	{
		return default(KCOEOKJIION);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1FC4C90", Offset = "0x1FC3A90", VA = "0x181FC4C90")]
	[CompilerGenerated]
	internal static KCOEOKJIION OIJNMPBJILC(JIBCLFPIIEE ABKPGPJAFGM)
	{
		return default(KCOEOKJIION);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class HIAIFCDCDHF : PGKNDKNCPBE
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1FC42A0", Offset = "0x1FC30A0", VA = "0x181FC42A0", Slot = "4")]
	public void GJPMOBHIDNK(DIGLEIMJJLL KDFKNLJOOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1FC3B20", Offset = "0x1FC2920", VA = "0x181FC3B20")]
	private void GFKJMLPGEOO(Dictionary<Guid, Guid> MFDJCJLALKM, FPCNHPIGHIC AHFBJECJDOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1FC3AC0", Offset = "0x1FC28C0", VA = "0x181FC3AC0")]
	private void GFKJMLPGEOO(Dictionary<Guid, Guid> MFDJCJLALKM, KKGPGIMDMJA BLAGCBCKMDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1FC4050", Offset = "0x1FC2E50", VA = "0x181FC4050")]
	private void GFKJMLPGEOO(Dictionary<Guid, Guid> MFDJCJLALKM, AMMPFNEPACL PBHJANJDHHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public HIAIFCDCDHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class MNCBLNABMOE : PGKNDKNCPBE
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1FC56B0", Offset = "0x1FC44B0", VA = "0x181FC56B0", Slot = "4")]
	public void GJPMOBHIDNK(DIGLEIMJJLL KDFKNLJOOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public MNCBLNABMOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class JAENDGNJPOO : PGKNDKNCPBE
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1FC4520", Offset = "0x1FC3320", VA = "0x181FC4520", Slot = "4")]
	public void GJPMOBHIDNK(DIGLEIMJJLL KDFKNLJOOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public JAENDGNJPOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class NILOHEOEEOO : PGKNDKNCPBE
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1FC5770", Offset = "0x1FC4570", VA = "0x181FC5770", Slot = "4")]
	public void GJPMOBHIDNK(DIGLEIMJJLL KDFKNLJOOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public NILOHEOEEOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class OPAMKMDIGDN : PGKNDKNCPBE
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1FC5AD0", Offset = "0x1FC48D0", VA = "0x181FC5AD0", Slot = "4")]
	public void GJPMOBHIDNK(DIGLEIMJJLL KDFKNLJOOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public OPAMKMDIGDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class NLIHEBCJPNB : PGKNDKNCPBE
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1FC58C0", Offset = "0x1FC46C0", VA = "0x181FC58C0", Slot = "4")]
	public void GJPMOBHIDNK(DIGLEIMJJLL KDFKNLJOOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public NLIHEBCJPNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class PGKOJMCDNHO : PGKNDKNCPBE
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1FC5D30", Offset = "0x1FC4B30", VA = "0x181FC5D30", Slot = "4")]
	public void GJPMOBHIDNK(DIGLEIMJJLL KDFKNLJOOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public PGKOJMCDNHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class FJJDEBEGLOJ : PGKNDKNCPBE
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1FC39A0", Offset = "0x1FC27A0", VA = "0x181FC39A0", Slot = "4")]
	public void GJPMOBHIDNK(DIGLEIMJJLL KDFKNLJOOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public FJJDEBEGLOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class MMPKHENLJED : PGKNDKNCPBE
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1FC54E0", Offset = "0x1FC42E0", VA = "0x181FC54E0", Slot = "4")]
	public void GJPMOBHIDNK(DIGLEIMJJLL KDFKNLJOOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public MMPKHENLJED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class HNKBNHFCION : PGKNDKNCPBE
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1FC4350", Offset = "0x1FC3150", VA = "0x181FC4350", Slot = "4")]
	public void GJPMOBHIDNK(DIGLEIMJJLL KDFKNLJOOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public HNKBNHFCION()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class LEPGDBDLMGB : PGKNDKNCPBE
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x1FC53C0", Offset = "0x1FC41C0", VA = "0x181FC53C0", Slot = "4")]
	public void GJPMOBHIDNK(DIGLEIMJJLL KDFKNLJOOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public LEPGDBDLMGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class AHDNNGOOKOA : PGKNDKNCPBE
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly System.Random LJBEJELLGOA;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD050", Offset = "0x1FBBE50", VA = "0x181FBD050", Slot = "4")]
	public void GJPMOBHIDNK(DIGLEIMJJLL KDFKNLJOOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GJPMOBHIDNK(DIGLEIMJJLL KDFKNLJOOHC);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface LDDAJCNFJBD
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int BCGEJGIGJCJ, out Guid CFIGNFFEDLI);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class FDGAKNELOPD
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static readonly PGKNDKNCPBE[] NCMPDNODKHG;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1FC2DF0", Offset = "0x1FC1BF0", VA = "0x181FC2DF0")]
	public static void IHHMCJGJJPH(EPAMCLOEEBK FILAKGLBGGA, Dictionary<Guid, Guid> ALMGADALEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1FC2C00", Offset = "0x1FC1A00", VA = "0x181FC2C00")]
	public static void DMJONCOLODK(EPAMCLOEEBK? FILAKGLBGGA, EAOMGBBMPGE CPCJNAMIHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1FC3000", Offset = "0x1FC1E00", VA = "0x181FC3000")]
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

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1FC2B30", Offset = "0x1FC1930", VA = "0x181FC2B30")]
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
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8E0", Offset = "0x6AD6E0", VA = "0x1806AE8E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<long, int> HCGCDPCEFBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1A50", Offset = "0x1FC0850", VA = "0x181FC1A50")]
	public static ALOGFNPDBKM FNGCHGKLGJM(DOJAMBMLNII GPCLICNBEEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1AC0", Offset = "0x1FC08C0", VA = "0x181FC1AC0")]
	public static ALOGFNPDBKM FPEADBEILJE(CIDKOGGHOGP IPCLKCIFDNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1FC16C0", Offset = "0x1FC04C0", VA = "0x181FC16C0")]
	public static ALOGFNPDBKM AIENOMACHEK(IEnumerable<string> AAODPOEGAEI, IDictionary<long, int> NKMLECHPBBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1FC27F0", Offset = "0x1FC15F0", VA = "0x181FC27F0")]
	private ALOGFNPDBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1FC28F0", Offset = "0x1FC16F0", VA = "0x181FC28F0")]
	private ALOGFNPDBKM(IEnumerable<string> AAODPOEGAEI, IDictionary<long, int> NKMLECHPBBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1FC2050", Offset = "0x1FC0E50", VA = "0x181FC2050")]
	private void JNLNJIEHCPE(DOJAMBMLNII GPCLICNBEEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1FC2210", Offset = "0x1FC1010", VA = "0x181FC2210")]
	private void JNLNJIEHCPE(CIDKOGGHOGP IPCLKCIFDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1FC23D0", Offset = "0x1FC11D0", VA = "0x181FC23D0")]
	private void JNLNJIEHCPE(NFKEEHEFFLB? JMLKLPJONJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1B30", Offset = "0x1FC0930", VA = "0x181FC1B30")]
	private void JNLNJIEHCPE(LNKAPGOJAIK? ABKPGPJAFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1CA0", Offset = "0x1FC0AA0", VA = "0x181FC1CA0")]
	private void JNLNJIEHCPE(EPAMCLOEEBK? BAKMJFIKFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1FC19E0", Offset = "0x1FC07E0", VA = "0x181FC19E0")]
	private void BBFCGFCGNNJ(string? LMAMBCJAPIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1810", Offset = "0x1FC0610", VA = "0x181FC1810")]
	private void ALNPMDPCKPA(BALPHNDGKEM? LCDKANLDCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1FC18F0", Offset = "0x1FC06F0", VA = "0x181FC18F0")]
	private void ALNPMDPCKPA(LACCEDPGLEJ? LCDKANLDCJP)
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
