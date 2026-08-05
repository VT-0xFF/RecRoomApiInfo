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
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70")]
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
		[Cpp2IlInjected.Address(RVA = "0x68DCA40", Offset = "0x68DB440", VA = "0x1868DCA40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x847190", Offset = "0x845B90", VA = "0x180847190")]
		public NullableAttribute(byte[] P_0)
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

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x143BBF0", Offset = "0x143A5F0", VA = "0x18143BBF0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MDMKOLNBEKH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x68DC490", Offset = "0x68DAE90", VA = "0x1868DC490")]
	public static bool NLJDFHIGABE(IADHOJIENLB OMHAGJEMJOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x68DC4D0", Offset = "0x68DAED0", VA = "0x1868DC4D0")]
	private static bool NLJDFHIGABE(BAGGANFGJBI PGKFNPJJKMC, ref IADHOJIENLB OMHAGJEMJOK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct IIKENBOPLPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly IMANAEBLADE EOGGNKNGEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly IReadOnlyList<NMCMOHGEFMP> JBICGBGKLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7035F0", Offset = "0x7029F0")]
	public readonly IReadOnlyList<global::FPEOKLIPFFB<NGJJKHMEJHA>> IGLMBBKNCCM;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x875B60", Offset = "0x874560", VA = "0x180875B60")]
	public IIKENBOPLPC(IMANAEBLADE GFENNPGBGOO, IReadOnlyList<NMCMOHGEFMP> HKJCJDDOJPF, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x703650", Offset = "0x702A50")] IReadOnlyList<global::FPEOKLIPFFB<NGJJKHMEJHA>> GGCCNJEOAEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface EMMBOCFLDKK
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(MIOJOJJBDJE MNILNHMNKJK, out Dictionary<int, int> CNDPDELEBML);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(CPAGDJOEHDB JHGJNMLBKPC, BBLJDLJOPCK CAGFPJENJJF);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class CJCGFHDMMFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly Guid EIIIAIKIOND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<Guid, Guid> NBMNGAFDECL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public IReadOnlyDictionary<Guid, Guid> CACJPHJGCFM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6F0", Offset = "0x7AE0F0", VA = "0x1807AF6F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x68D7D20", Offset = "0x68D6720", VA = "0x1868D7D20")]
	private CJCGFHDMMFF(in Guid EDBDFBNAGIP, Dictionary<Guid, Guid> FCFLMAOCHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x68D7C00", Offset = "0x68D6600", VA = "0x1868D7C00")]
	public static CJCGFHDMMFF MMIEPLHJEKK(IReadOnlyDictionary<Guid, Guid> IMCELEDDPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x68D7870", Offset = "0x68D6270", VA = "0x1868D7870")]
	public static CJCGFHDMMFF FGFCKJEPLAN(IEnumerable<KeyValuePair<Guid, Guid>> IMCELEDDPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x68D77A0", Offset = "0x68D61A0", VA = "0x1868D77A0")]
	private static Dictionary<Guid, Guid> CFLIDPOAIGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x68D7C10", Offset = "0x68D6610", VA = "0x1868D7C10")]
	public Guid NJABMKLDCPK(in Guid GDCMPFDFIDH, bool PNDNAADENFH)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface ADEBPFPCMCL
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
public sealed class JIBKABECGIO
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public IReadOnlyDictionary<Guid, Guid> LBDHMCMLFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x84CDF0", Offset = "0x84B7F0", VA = "0x18084CDF0")]
	public JIBKABECGIO(IReadOnlyDictionary<Guid, Guid> GLNAKAFDAHD, IReadOnlyDictionary<Guid, Guid> LMODGHMOEDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class DLNKMOIJCBH
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x68D8BE0", Offset = "0x68D75E0", VA = "0x1868D8BE0")]
	public static HIJLBAEIPJH AEBEABAFKBP(in IIKENBOPLPC PMNKGEMNJHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x68D9230", Offset = "0x68D7C30", VA = "0x1868D9230")]
	private static void DFGPJADCCGG(HIJLBAEIPJH FHMJLOFJODA, IReadOnlyList<NMCMOHGEFMP> HKJCJDDOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x68DA230", Offset = "0x68D8C30", VA = "0x1868DA230")]
	public static bool NKKFLJDCLID(HIJLBAEIPJH FHMJLOFJODA, NGONGBCEJIA KDLCGMBBDNB, out JIBKABECGIO? FCFLMAOCHFB, out string? MCCDEFDHGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x68D9D10", Offset = "0x68D8710", VA = "0x1868D9D10")]
	private static void HHAEOLCPKCI(HIJLBAEIPJH FHMJLOFJODA, ref NGONGBCEJIA KDLCGMBBDNB, IReadOnlyCollection<ByteString> JKAJCHMMMHN, IReadOnlyCollection<ByteString> JHPJMGGIIOF, IReadOnlyCollection<ByteString> KCHMLNONGKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x68D96F0", Offset = "0x68D80F0", VA = "0x1868D96F0")]
	private static bool HGIGLJODDLD(HIJLBAEIPJH FHMJLOFJODA, CPAGDJOEHDB JHGJNMLBKPC, ref NGONGBCEJIA KDLCGMBBDNB, out string MCCDEFDHGFH, out Dictionary<int, int> CNDPDELEBML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x68D8FC0", Offset = "0x68D79C0", VA = "0x1868D8FC0")]
	private static Dictionary<Guid, BAGGANFGJBI> CPCDDHINGAJ(HIJLBAEIPJH FHMJLOFJODA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x68DA1A0", Offset = "0x68D8BA0", VA = "0x1868DA1A0")]
	private static void LEDNCFPPDLC(bool KKDKEPKEOLM, NMCMOHGEFMP LIACPJLMENB, Dictionary<Guid, Guid> EMDNJOJINCP, CJCGFHDMMFF LOBLNIEFKHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x68D8D20", Offset = "0x68D7720", VA = "0x1868D8D20")]
	private static void BIJHEDJIJCM(NMCMOHGEFMP LIACPJLMENB, Guid IIJOGCNBFBN, BLKELLMEIEO? NANLOHNMKKN, Dictionary<Guid, BAGGANFGJBI> JEOPBFHFGIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x68DAE90", Offset = "0x68D9890", VA = "0x1868DAE90")]
	private static void OEFDGHAPAFD(NMCMOHGEFMP LIACPJLMENB, Dictionary<Guid, Guid> EMDNJOJINCP, Dictionary<int, int> DCPOJKLAJAI, CPAGDJOEHDB OAANEFGONGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x68D9D60", Offset = "0x68D8760", VA = "0x1868D9D60")]
	private static void JFDMHCFJEAL(IEnumerable<NMCMOHGEFMP> KHDPPKFEDFO, IReadOnlyCollection<ByteString> JKAJCHMMMHN, IReadOnlyCollection<ByteString> JHPJMGGIIOF, IReadOnlyCollection<ByteString> KCHMLNONGKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct NGONGBCEJIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public bool KKDKEPKEOLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public bool AKLPMIGOAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public BLKELLMEIEO? NANLOHNMKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public BLKELLMEIEO? JDNBHGFNPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public IMANAEBLADE OMPCPFOHMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public ADEBPFPCMCL DJCNHOGJNCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public EMMBOCFLDKK EDDIIMALPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public global::FPEOKLIPFFB<JPNFGIKIKAL> ECPBCDLJEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public MCEFJGHJHEH KAGOFGINBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public List<NMCMOHGEFMP> NBHKAKJKCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public Dictionary<string, object> OFJCCICMCFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public FJIBIBONNFN HMNEFEIEALF;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct BLKELLMEIEO
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const float MMHJBGCNJFE = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public Vector3 LHCEFCJDGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public Quaternion FDBNIAOOEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public float EADEBIPFPFD;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Matrix4x4 EOLFCNKAOEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x68D76A0", Offset = "0x68D60A0", VA = "0x1868D76A0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x23966B0", Offset = "0x23950B0", VA = "0x1823966B0")]
	public BLKELLMEIEO(Vector3 LHCEFCJDGIJ, Quaternion FDBNIAOOEMB, float EADEBIPFPFD = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x68D7320", Offset = "0x68D5D20", VA = "0x1868D7320")]
	public static BLKELLMEIEO FCMLJJCOGJH(BLKELLMEIEO EOBFGLJBCIJ, BLKELLMEIEO EBGBCKBPPJJ)
	{
		return default(BLKELLMEIEO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x68D7280", Offset = "0x68D5C80", VA = "0x1868D7280")]
	public static BLKELLMEIEO EHMKDPHHPBI((Vector3, Quaternion, float) MNILNHMNKJK)
	{
		return default(BLKELLMEIEO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x68D7180", Offset = "0x68D5B80", VA = "0x1868D7180")]
	public static BLKELLMEIEO EHMKDPHHPBI(Matrix4x4 IBDCPOEGKBE)
	{
		return default(BLKELLMEIEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x68D7510", Offset = "0x68D5F10", VA = "0x1868D7510")]
	public BLKELLMEIEO IHEBEAGCKPA(Matrix4x4 DBMMOFPNJHL)
	{
		return default(BLKELLMEIEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x68D72D0", Offset = "0x68D5CD0", VA = "0x1868D72D0")]
	public static BLKELLMEIEO EKBAHMGCJOP(Vector3 LHCEFCJDGIJ)
	{
		return default(BLKELLMEIEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x68D7470", Offset = "0x68D5E70", VA = "0x1868D7470")]
	public readonly HIMAPHINPEC GEEAIMHLOBN()
	{
		return default(HIMAPHINPEC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class MFGFLJBHPNF
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x68DC850", Offset = "0x68DB250", VA = "0x1868DC850")]
	public static BLKELLMEIEO FJAKOMDBPME(this in HIMAPHINPEC IKHBPJOEIEB)
	{
		return default(BLKELLMEIEO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class KHCGBBKCJLA : HOIMNKANHAN
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x68DC3E0", Offset = "0x68DADE0", VA = "0x1868DC3E0", Slot = "4")]
	public void MJMOKMOHBCH(GMOMGPHFJJD MFEIEKGCGDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x68DBE50", Offset = "0x68DA850", VA = "0x1868DBE50")]
	private void BCEBMNJHMNO(Dictionary<Guid, Guid> FKCEOIJOJNK, IKIDNEHOGAK CKGEEBJIPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x68DC380", Offset = "0x68DAD80", VA = "0x1868DC380")]
	private void BCEBMNJHMNO(Dictionary<Guid, Guid> FKCEOIJOJNK, LKJBEMCPBFB JFHNLFDCCEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x68DBC00", Offset = "0x68DA600", VA = "0x1868DBC00")]
	private void BCEBMNJHMNO(Dictionary<Guid, Guid> FKCEOIJOJNK, OPBLBJNKBHA GKELLKEKOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public KHCGBBKCJLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class PMGMMDIPHGO : HOIMNKANHAN
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x68DCBF0", Offset = "0x68DB5F0", VA = "0x1868DCBF0", Slot = "4")]
	public void MJMOKMOHBCH(GMOMGPHFJJD MFEIEKGCGDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public PMGMMDIPHGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class HDEFCJDANIM : HOIMNKANHAN
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x68DB8C0", Offset = "0x68DA2C0", VA = "0x1868DB8C0", Slot = "4")]
	public void MJMOKMOHBCH(GMOMGPHFJJD MFEIEKGCGDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public HDEFCJDANIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class ADDEBJDGPCH : HOIMNKANHAN
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x68D5CE0", Offset = "0x68D46E0", VA = "0x1868D5CE0", Slot = "4")]
	public void MJMOKMOHBCH(GMOMGPHFJJD MFEIEKGCGDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public ADDEBJDGPCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class EAFBEPCFGEJ : HOIMNKANHAN
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x68DB150", Offset = "0x68D9B50", VA = "0x1868DB150", Slot = "4")]
	public void MJMOKMOHBCH(GMOMGPHFJJD MFEIEKGCGDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public EAFBEPCFGEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class ENJFNDOPKEH : HOIMNKANHAN
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x68DB550", Offset = "0x68D9F50", VA = "0x1868DB550", Slot = "4")]
	public void MJMOKMOHBCH(GMOMGPHFJJD MFEIEKGCGDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public ENJFNDOPKEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class EHENHFGDABD : HOIMNKANHAN
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x68DB360", Offset = "0x68D9D60", VA = "0x1868DB360", Slot = "4")]
	public void MJMOKMOHBCH(GMOMGPHFJJD MFEIEKGCGDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public EHENHFGDABD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class FNAMEKIEFJG : HOIMNKANHAN
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x68DB6D0", Offset = "0x68DA0D0", VA = "0x1868DB6D0", Slot = "4")]
	public void MJMOKMOHBCH(GMOMGPHFJJD MFEIEKGCGDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public FNAMEKIEFJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class HFKMIKACNIM : HOIMNKANHAN
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x68DBA30", Offset = "0x68DA430", VA = "0x1868DBA30", Slot = "4")]
	public void MJMOKMOHBCH(GMOMGPHFJJD MFEIEKGCGDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public HFKMIKACNIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class EAAKCEKMFJA : HOIMNKANHAN
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x68DAF80", Offset = "0x68D9980", VA = "0x1868DAF80", Slot = "4")]
	public void MJMOKMOHBCH(GMOMGPHFJJD MFEIEKGCGDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public EAAKCEKMFJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class OOKCHAFHFCF : HOIMNKANHAN
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x68DCAD0", Offset = "0x68DB4D0", VA = "0x1868DCAD0", Slot = "4")]
	public void MJMOKMOHBCH(GMOMGPHFJJD MFEIEKGCGDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public OOKCHAFHFCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class MHHADFBJDOG : HOIMNKANHAN
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly System.Random DHINMEKAOPK;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x68DC900", Offset = "0x68DB300", VA = "0x1868DC900", Slot = "4")]
	public void MJMOKMOHBCH(GMOMGPHFJJD MFEIEKGCGDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public MHHADFBJDOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct IADHOJIENLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public CPAGDJOEHDB LHIPGOMOMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NDCFDNFADKM PFHOAABJJIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public Dictionary<int, int> DCPOJKLAJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public Dictionary<Guid, Guid> OODHJJJMMJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public FJIBIBONNFN HMNEFEIEALF;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface HOIMNKANHAN
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MJMOKMOHBCH(GMOMGPHFJJD MFEIEKGCGDL);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class CPNPMNIEPJL
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly HOIMNKANHAN[] JJNBMCDBOAP;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x68D7D70", Offset = "0x68D6770", VA = "0x1868D7D70")]
	public static void FOIBAAFDMIM(NMCMOHGEFMP MNILNHMNKJK, Dictionary<Guid, Guid> CKDIAAOIAMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x68D7F80", Offset = "0x68D6980", VA = "0x1868D7F80")]
	public static void JCFKMJPAIPH(NMCMOHGEFMP? MNILNHMNKJK, CJCGFHDMMFF LOBLNIEFKHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x68D8240", Offset = "0x68D6C40", VA = "0x1868D8240")]
	public static void NLJDFHIGABE(GMOMGPHFJJD MFEIEKGCGDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct GMOMGPHFJJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public CPAGDJOEHDB KOGBKOPHBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NMCMOHGEFMP LIACPJLMENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public Dictionary<int, int> DCPOJKLAJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Dictionary<Guid, Guid> OODHJJJMMJO;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x68DB7F0", Offset = "0x68DA1F0", VA = "0x1868DB7F0")]
	public Guid JFBGPGKEAOP(Guid GDCMPFDFIDH)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface FJIBIBONNFN
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int GMICONIGMGB, out Guid PGENEJDMBNO);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class ADIIAODMJPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly HashSet<string> HFHLBFICDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly Dictionary<long, int> EJFIJJOBDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly HashSet<Guid> JCLCBEJKJML;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyCollection<string> HELOKLPADNB
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyDictionary<long, int> BIKLEDPAMKE
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x68D60E0", Offset = "0x68D4AE0", VA = "0x1868D60E0")]
	public static ADIIAODMJPM NENHPJMFLEC(PPDGLIGMGBC EIFFMACPBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x68D6070", Offset = "0x68D4A70", VA = "0x1868D6070")]
	public static ADIIAODMJPM NAGGGFNMDHI(HIJLBAEIPJH MEHJPNLPEPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x68D6150", Offset = "0x68D4B50", VA = "0x1868D6150")]
	public static ADIIAODMJPM PDDGGNCJJIN(IEnumerable<string> HFHLBFICDPL, IDictionary<long, int> FAMKDPPFHGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x68D7080", Offset = "0x68D5A80", VA = "0x1868D7080")]
	private ADIIAODMJPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x68D6F60", Offset = "0x68D5960", VA = "0x1868D6F60")]
	private ADIIAODMJPM(IEnumerable<string> HFHLBFICDPL, IDictionary<long, int> FAMKDPPFHGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x68D67C0", Offset = "0x68D51C0", VA = "0x1868D67C0")]
	private void PMHCBIKCBDL(PPDGLIGMGBC EIFFMACPBMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x68D6DA0", Offset = "0x68D57A0", VA = "0x1868D6DA0")]
	private void PMHCBIKCBDL(HIJLBAEIPJH MEHJPNLPEPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x68D6980", Offset = "0x68D5380", VA = "0x1868D6980")]
	private void PMHCBIKCBDL(GNCENFPMGOH? MNGLAEJHIMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x68D62A0", Offset = "0x68D4CA0", VA = "0x1868D62A0")]
	private void PMHCBIKCBDL(DOHFCHGLGCP? GBBOAEGAMHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x68D6410", Offset = "0x68D4E10", VA = "0x1868D6410")]
	private void PMHCBIKCBDL(NMCMOHGEFMP? LIACPJLMENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x68D6000", Offset = "0x68D4A00", VA = "0x1868D6000")]
	private void HJHOJBEELML(string? BHGLNGNDDKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x68D5F20", Offset = "0x68D4920", VA = "0x1868D5F20")]
	private void BEBLEPDOGJF(KJNMBLEKJKE? KKNJNEKBHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x68D5E30", Offset = "0x68D4830", VA = "0x1868D5E30")]
	private void BEBLEPDOGJF(LGEENBIIDBN? KKNJNEKBHLO)
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
