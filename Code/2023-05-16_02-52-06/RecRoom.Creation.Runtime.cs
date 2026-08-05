using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Google.Protobuf;
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
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x67B8DB0", Offset = "0x67B7BB0", VA = "0x1867B8DB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x75C880", Offset = "0x75B680", VA = "0x18075C880")]
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
		[Cpp2IlInjected.Address(RVA = "0xA7DB60", Offset = "0xA7C960", VA = "0x180A7DB60")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class NAPPMNINDAE
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x67B8A30", Offset = "0x67B7830", VA = "0x1867B8A30")]
	public static bool LOLEEIMHCEA(DBGONAAOJOB AFKKOMJODGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x67B86B0", Offset = "0x67B74B0", VA = "0x1867B86B0")]
	private static bool LOLEEIMHCEA(ENPJHNCBEEE LPFENKMFEII, ref DBGONAAOJOB AFKKOMJODGA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct CAPLAAEAMAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly GBKODEAGKNP FAENEPAPAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly IReadOnlyList<MEKMDLBCOOO> FHIHKNKLGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x70A170", Offset = "0x709570")]
	public readonly IReadOnlyList<global::HCLEDLPNAAN<BMINDFMCHKD>> KLHFFKDJCEM;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8071A0", Offset = "0x805FA0", VA = "0x1808071A0")]
	public CAPLAAEAMAD(GBKODEAGKNP CFNGNMIKNGO, IReadOnlyList<MEKMDLBCOOO> IAGOKLAIEJK, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x70A1D0", Offset = "0x7095D0")] IReadOnlyList<global::HCLEDLPNAAN<BMINDFMCHKD>> APHPFAPMBLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface LGNLEIMLEHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(JBIJLBBAMKF MMJOHADFCHO, out Dictionary<int, int> EGGLAMNJNFD);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(AIFDHHOCJIF LJCPENBHEGL, NPNPMIGNJFJ HNEJCJKKLGO);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class PFDDFBCDDMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly Guid MEHHDGPHFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<Guid, Guid> BMLGMGIONKK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public IReadOnlyDictionary<Guid, Guid> EOBOKPJAHEB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x741120", Offset = "0x73FF20", VA = "0x180741120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x67B9C50", Offset = "0x67B8A50", VA = "0x1867B9C50")]
	private PFDDFBCDDMH(in Guid EAHNOHKLJDC, Dictionary<Guid, Guid> AHOBHHPPCFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x67B96D0", Offset = "0x67B84D0", VA = "0x1867B96D0")]
	public static PFDDFBCDDMH GFBMDEJFCHG(IReadOnlyDictionary<Guid, Guid> MGKEDFDIEHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x67B98C0", Offset = "0x67B86C0", VA = "0x1867B98C0")]
	public static PFDDFBCDDMH NMHGEILLDGL(IEnumerable<KeyValuePair<Guid, Guid>> MGKEDFDIEHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x67B96E0", Offset = "0x67B84E0", VA = "0x1867B96E0")]
	private static Dictionary<Guid, Guid> NBKKOKPBMCG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x67B97B0", Offset = "0x67B85B0", VA = "0x1867B97B0")]
	public Guid NLLPPGHKENN(in Guid AOKEOLFIKCH, bool OKMENALMEHA)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface FNPPCCNIGNL
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<ByteString> GetValidRoomKeyReplicationIds();

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<ByteString> GetValidRoomCurrencies();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<ByteString> GetValidRoomConsumables();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class GIFHALHKLOH
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public IReadOnlyDictionary<Guid, Guid> LOCGNIPMCCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7406E0", Offset = "0x73F4E0", VA = "0x1807406E0")]
	public GIFHALHKLOH(IReadOnlyDictionary<Guid, Guid> HKKEBAKJAML, IReadOnlyDictionary<Guid, Guid> HFFMMEECODG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class INGGDHBNHDL
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x67B5900", Offset = "0x67B4700", VA = "0x1867B5900")]
	public static LDIKKJJLIOG KAMLOHEEAIH(in CAPLAAEAMAD CGLIIOOHJJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x67B5D00", Offset = "0x67B4B00", VA = "0x1867B5D00")]
	private static void NLMLAPDMEDC(LDIKKJJLIOG APNKLBADFCO, IReadOnlyList<MEKMDLBCOOO> IAGOKLAIEJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x67B44B0", Offset = "0x67B32B0", VA = "0x1867B44B0")]
	public static bool FLIDOOMFECE(LDIKKJJLIOG APNKLBADFCO, POKKMDDFMOE EEHCCFJHEOB, out GIFHALHKLOH? AHOBHHPPCFF, out string? DOIPIGHENCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x67B5A40", Offset = "0x67B4840", VA = "0x1867B5A40")]
	private static void NDHKHCHGDPK(LDIKKJJLIOG APNKLBADFCO, ref POKKMDDFMOE EEHCCFJHEOB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x70A250", Offset = "0x709650")] IReadOnlyCollection<ByteString> DMKKKIBHKAM, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x70A2B0", Offset = "0x7096B0")] IReadOnlyCollection<ByteString> PEEIIIJCEIO, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x70A310", Offset = "0x709710")] IReadOnlyCollection<ByteString> LCPPJHIKMEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x67B52E0", Offset = "0x67B40E0", VA = "0x1867B52E0")]
	private static bool GNMMLGEANPH(LDIKKJJLIOG APNKLBADFCO, AIFDHHOCJIF LJCPENBHEGL, ref POKKMDDFMOE EEHCCFJHEOB, out string DOIPIGHENCB, out Dictionary<int, int> EGGLAMNJNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x67B5A90", Offset = "0x67B4890", VA = "0x1867B5A90")]
	private static Dictionary<Guid, ENPJHNCBEEE> NFBFCNPKNIH(LDIKKJJLIOG APNKLBADFCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x67B5250", Offset = "0x67B4050", VA = "0x1867B5250")]
	private static void GDLFIKDCBBJ(bool NNCBLEPAPKM, MEKMDLBCOOO EKODLDGKCFA, Dictionary<Guid, Guid> MAJOJJBHEKN, PFDDFBCDDMH KNIJKAJACLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x67B4120", Offset = "0x67B2F20", VA = "0x1867B4120")]
	private static void BNOBAMCACCK(MEKMDLBCOOO EKODLDGKCFA, Guid OGNGHLMKFNF, GJEEHPJEHEE? KFBAEDPBLGP, Dictionary<Guid, ENPJHNCBEEE> ENEACKPDKIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x67B43C0", Offset = "0x67B31C0", VA = "0x1867B43C0")]
	private static void COAOIDCMJPK(MEKMDLBCOOO EKODLDGKCFA, Dictionary<Guid, Guid> MAJOJJBHEKN, Dictionary<int, int> EFBDFGCPOGN, AIFDHHOCJIF GAHLJBGMFCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x67B3CE0", Offset = "0x67B2AE0", VA = "0x1867B3CE0")]
	private static void BKKJOIDGDMA(IEnumerable<MEKMDLBCOOO> EJOGLFPMHKE, IReadOnlyCollection<ByteString> DMKKKIBHKAM, IReadOnlyCollection<ByteString> PEEIIIJCEIO, IReadOnlyCollection<ByteString> LCPPJHIKMEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct POKKMDDFMOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public bool NNCBLEPAPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public bool OKBCBKDHIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public GJEEHPJEHEE? KFBAEDPBLGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public GJEEHPJEHEE? BFBJIEEBOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public GBKODEAGKNP CBIPJIMKHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public FNPPCCNIGNL JPBFMJDPBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public LGNLEIMLEHJ BPGHADKFMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public global::HCLEDLPNAAN<BBEMDLBIACH> NDLPOJJFFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public HMCIBBDPDND MJOPNKNNCPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public List<MEKMDLBCOOO> NJNCMGLGJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public Dictionary<string, object> PDILAJDACDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public MIPNBDCDCOB BGDNIKLMCIK;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct GJEEHPJEHEE
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const float FPCCKMAMJGO = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public Vector3 DNPAJCANFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public Quaternion NNAIELBMKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public float LFJHMANOJGJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Matrix4x4 ECJCEMODNEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x67B3920", Offset = "0x67B2720", VA = "0x1867B3920")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1424840", Offset = "0x1423640", VA = "0x181424840")]
	public GJEEHPJEHEE(Vector3 DNPAJCANFPF, Quaternion NNAIELBMKHJ, float LFJHMANOJGJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x67B35F0", Offset = "0x67B23F0", VA = "0x1867B35F0")]
	public static GJEEHPJEHEE BJBDBKBOGEJ(GJEEHPJEHEE GANAMHNGMGO, GJEEHPJEHEE DLJLIEFIMOO)
	{
		return default(GJEEHPJEHEE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x67B3AC0", Offset = "0x67B28C0", VA = "0x1867B3AC0")]
	public static GJEEHPJEHEE JMLJLLKELMG((Vector3, Quaternion, float) MMJOHADFCHO)
	{
		return default(GJEEHPJEHEE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x67B3B10", Offset = "0x67B2910", VA = "0x1867B3B10")]
	public static GJEEHPJEHEE JMLJLLKELMG(Matrix4x4 ACNCPMABDFN)
	{
		return default(GJEEHPJEHEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x67B3790", Offset = "0x67B2590", VA = "0x1867B3790")]
	public GJEEHPJEHEE ENNMCBONCPA(Matrix4x4 KGHIPKNMKHP)
	{
		return default(GJEEHPJEHEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x67B3740", Offset = "0x67B2540", VA = "0x1867B3740")]
	public static GJEEHPJEHEE DOIJJKAFPHI(Vector3 DNPAJCANFPF)
	{
		return default(GJEEHPJEHEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x67B3A20", Offset = "0x67B2820", VA = "0x1867B3A20")]
	public readonly PCIGLIMDCIJ HNFEFLFJNOD()
	{
		return default(PCIGLIMDCIJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class AHBLLIPOPPK
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x67B2B90", Offset = "0x67B1990", VA = "0x1867B2B90")]
	public static GJEEHPJEHEE AOBADAKNBIF(this in PCIGLIMDCIJ LCNEHOGIJPK)
	{
		return default(GJEEHPJEHEE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class PFAAAKPPNHO : GDMJMKDIJNB
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x67B9620", Offset = "0x67B8420", VA = "0x1867B9620", Slot = "4")]
	public void NMAOMODNLID(HIAMBGMFDMA AADNDPMDOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x67B8EA0", Offset = "0x67B7CA0", VA = "0x1867B8EA0")]
	private void FFCPDGHAMHP(Dictionary<Guid, Guid> JIAFJKCHGLK, GPDBDLAAHEC DEODOIEJOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x67B8E40", Offset = "0x67B7C40", VA = "0x1867B8E40")]
	private void FFCPDGHAMHP(Dictionary<Guid, Guid> JIAFJKCHGLK, JAHEBIDBDBN DGMPBPKOFBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x67B93D0", Offset = "0x67B81D0", VA = "0x1867B93D0")]
	private void FFCPDGHAMHP(Dictionary<Guid, Guid> JIAFJKCHGLK, IAOOGBJEKPN EOFAGCIPHCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public PFAAAKPPNHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class CNDADFICABO : GDMJMKDIJNB
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x67B3240", Offset = "0x67B2040", VA = "0x1867B3240", Slot = "4")]
	public void NMAOMODNLID(HIAMBGMFDMA AADNDPMDOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public CNDADFICABO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class NDAJDDAOIBP : GDMJMKDIJNB
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x67B8C40", Offset = "0x67B7A40", VA = "0x1867B8C40", Slot = "4")]
	public void NMAOMODNLID(HIAMBGMFDMA AADNDPMDOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public NDAJDDAOIBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class BENIIIAMLFP : GDMJMKDIJNB
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x67B2F00", Offset = "0x67B1D00", VA = "0x1867B2F00", Slot = "4")]
	public void NMAOMODNLID(HIAMBGMFDMA AADNDPMDOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public BENIIIAMLFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class MFNPPEAMAIB : GDMJMKDIJNB
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x67B84A0", Offset = "0x67B72A0", VA = "0x1867B84A0", Slot = "4")]
	public void NMAOMODNLID(HIAMBGMFDMA AADNDPMDOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public MFNPPEAMAIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class AIMOCIFLCHP : GDMJMKDIJNB
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x67B2C40", Offset = "0x67B1A40", VA = "0x1867B2C40", Slot = "4")]
	public void NMAOMODNLID(HIAMBGMFDMA AADNDPMDOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public AIMOCIFLCHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class CGDIMKMNKLF : GDMJMKDIJNB
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x67B3050", Offset = "0x67B1E50", VA = "0x1867B3050", Slot = "4")]
	public void NMAOMODNLID(HIAMBGMFDMA AADNDPMDOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public CGDIMKMNKLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class JIIJAKIBPJG : GDMJMKDIJNB
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x67B61C0", Offset = "0x67B4FC0", VA = "0x1867B61C0", Slot = "4")]
	public void NMAOMODNLID(HIAMBGMFDMA AADNDPMDOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public JIIJAKIBPJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class CNIMPJDKPNJ : GDMJMKDIJNB
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x67B3300", Offset = "0x67B2100", VA = "0x1867B3300", Slot = "4")]
	public void NMAOMODNLID(HIAMBGMFDMA AADNDPMDOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public CNIMPJDKPNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class NCBLCGPNEMN : GDMJMKDIJNB
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x67B8A70", Offset = "0x67B7870", VA = "0x1867B8A70", Slot = "4")]
	public void NMAOMODNLID(HIAMBGMFDMA AADNDPMDOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public NCBLCGPNEMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class GCPPIMONIFP : GDMJMKDIJNB
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x67B34D0", Offset = "0x67B22D0", VA = "0x1867B34D0", Slot = "4")]
	public void NMAOMODNLID(HIAMBGMFDMA AADNDPMDOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public GCPPIMONIFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class APCPCANJKAC : GDMJMKDIJNB
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly System.Random EFEGEFNMEOI;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x67B2DC0", Offset = "0x67B1BC0", VA = "0x1867B2DC0", Slot = "4")]
	public void NMAOMODNLID(HIAMBGMFDMA AADNDPMDOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public APCPCANJKAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct DBGONAAOJOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public AIFDHHOCJIF HHCMOLFBCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public MMBPEJEGBNA ODJKFAFMCEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public Dictionary<int, int> EFBDFGCPOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public Dictionary<Guid, Guid> JBMBDFKKEBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public MIPNBDCDCOB BGDNIKLMCIK;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface GDMJMKDIJNB
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NMAOMODNLID(HIAMBGMFDMA AADNDPMDOLL);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class LBBOJODDNIP
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly GDMJMKDIJNB[] NICGLEMPILN;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x67B62E0", Offset = "0x67B50E0", VA = "0x1867B62E0")]
	public static void HOGDAINBDAI(MEKMDLBCOOO MMJOHADFCHO, Dictionary<Guid, Guid> FMELMMOLCCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x67B6850", Offset = "0x67B5650", VA = "0x1867B6850")]
	public static void NBPLHJDAJJK(MEKMDLBCOOO? MMJOHADFCHO, PFDDFBCDDMH KNIJKAJACLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x67B64F0", Offset = "0x67B52F0", VA = "0x1867B64F0")]
	public static void LOLEEIMHCEA(HIAMBGMFDMA AADNDPMDOLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct HIAMBGMFDMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public AIFDHHOCJIF IIMGFPAOMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public MEKMDLBCOOO EKODLDGKCFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public Dictionary<int, int> EFBDFGCPOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Dictionary<Guid, Guid> JBMBDFKKEBF;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x67B3C10", Offset = "0x67B2A10", VA = "0x1867B3C10")]
	public Guid HBPOMALHMKI(Guid AOKEOLFIKCH)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface MIPNBDCDCOB
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int KCPFDNJFPOJ, out Guid CMHKPEILHCD);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class LEGJNFMIAHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly HashSet<string> LBOMLAIOGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly Dictionary<long, int> PCLBIMNBFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly HashSet<Guid> AHNBPPOBBEH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyCollection<string> MGJHNAJPFKO
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyDictionary<long, int> GLLKKCMMBLA
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x67B7390", Offset = "0x67B6190", VA = "0x1867B7390")]
	public static LEGJNFMIAHE HLBDFFDKNHN(CKGKBFGOMIH FHDHPJOAAEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x67B7550", Offset = "0x67B6350", VA = "0x1867B7550")]
	public static LEGJNFMIAHE IOCBHDGKHCL(LDIKKJJLIOG MFOAKLGHGJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x67B7400", Offset = "0x67B6200", VA = "0x1867B7400")]
	public static LEGJNFMIAHE ICFIIMDILEA(IEnumerable<string> LBOMLAIOGBM, IDictionary<long, int> PDICHDIDFBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x67B8280", Offset = "0x67B7080", VA = "0x1867B8280")]
	private LEGJNFMIAHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x67B8380", Offset = "0x67B7180", VA = "0x1867B8380")]
	private LEGJNFMIAHE(IEnumerable<string> LBOMLAIOGBM, IDictionary<long, int> PDICHDIDFBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x67B7F50", Offset = "0x67B6D50", VA = "0x1867B7F50")]
	private void KGKHMIAKCIO(CKGKBFGOMIH FHDHPJOAAEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x67B79E0", Offset = "0x67B67E0", VA = "0x1867B79E0")]
	private void KGKHMIAKCIO(LDIKKJJLIOG MFOAKLGHGJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x67B75C0", Offset = "0x67B63C0", VA = "0x1867B75C0")]
	private void KGKHMIAKCIO(AJJICEJGKPE? LFLMFMLCFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x67B8110", Offset = "0x67B6F10", VA = "0x1867B8110")]
	private void KGKHMIAKCIO(FCHLLFKBMJP? IEAGANOGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x67B7BA0", Offset = "0x67B69A0", VA = "0x1867B7BA0")]
	private void KGKHMIAKCIO(MEKMDLBCOOO? EKODLDGKCFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x67B7320", Offset = "0x67B6120", VA = "0x1867B7320")]
	private void ECEABMLLANP(string? EEIPHILNKEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x67B7240", Offset = "0x67B6040", VA = "0x1867B7240")]
	private void CAAOMAMLLHG(FKENLHKDPBM? PNNNAEFBNNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x67B7150", Offset = "0x67B5F50", VA = "0x1867B7150")]
	private void CAAOMAMLLHG(LEMNOJCBJEM? PNNNAEFBNNP)
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
