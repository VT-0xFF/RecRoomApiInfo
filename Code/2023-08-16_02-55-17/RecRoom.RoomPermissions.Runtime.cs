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
		[Cpp2IlInjected.Address(RVA = "0x7E5080", Offset = "0x7E4280", VA = "0x1807E5080")]
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
		[Cpp2IlInjected.Address(RVA = "0x6518BF0", Offset = "0x6517DF0", VA = "0x186518BF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E3190", Offset = "0x7E2390", VA = "0x1807E3190")]
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
		[Cpp2IlInjected.Address(RVA = "0x17C7540", Offset = "0x17C6740", VA = "0x1817C7540")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum NGGIDKNPOOG
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface KIIJEIKLFBC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	KKJJOJNPNAC HMPLFHPCKDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<ICJMDAGKACL> DNIOIGHKJMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event EGBGGPCMEID CKAELPDGCCG;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<ICJMDAGKACL> GMPAIIMLHMN(bool CGEPBMIEAOD = false);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	ICJMDAGKACL KDKLDFLMFEE(CPCMBHAGMBL NFMOCNFGHOI);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool ELGAKMIGKJH(CPCMBHAGMBL NFMOCNFGHOI);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<ICJMDAGKACL> AEFHBGBHGGA(CPCMBHAGMBL NFMOCNFGHOI, bool PHPDLBPIGKE = false);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool JOMOELNEODO(CPCMBHAGMBL KNGHEFALGKJ, ODGLGJAJPCF BIGFJLEPFIA);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	ICJMDAGKACL LLNCPGPOKFP(ODGLGJAJPCF BIGFJLEPFIA);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool AMPAPHGKEDB<T>(ODGLGJAJPCF BIGFJLEPFIA, GGAFAPOLPEC JCDODFGILJI, bool OAAANKOGCJC, T CIKBJELAGAP) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface BHDKBNKGEOM
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task EKNLPNBDFGL(PPPFGNOFILG DONGKHHNBIB, CancellationToken MELLLMEKJLC);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JDBJHGBDEEK(ref PPPFGNOFILG DONGKHHNBIB);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface BODNNMPPAJA
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool PFPHMODMEPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool CCOCEHHFOBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool BNJGILMCNBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool LDKNGLEEEHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool LMDPCBOMLHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool BEHEPCOMMGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class FGPFFJGLGAK
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly IReadOnlyList<ODGLGJAJPCF> IHPJDPJGDPE;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x650DA90", Offset = "0x650CC90", VA = "0x18650DA90")]
	public static bool NKIDFPIECMN(this CPCMBHAGMBL BJENOGCANAN, ODGLGJAJPCF BIGFJLEPFIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x650DA10", Offset = "0x650CC10", VA = "0x18650DA10")]
	public static bool MFDJOMFKDEC(this CPCMBHAGMBL BJENOGCANAN, ODGLGJAJPCF BIGFJLEPFIA, JICMMHOABAL NJIPHLJIGDC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class CHNDKPKGDJG : HCECHADMPKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly KIIJEIKLFBC OKELLANDBIP;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8888D0", Offset = "0x887AD0", VA = "0x1808888D0")]
	[RecRoom.NoEngine.Common.Preserve]
	public CHNDKPKGDJG([NDGONEEEGIA(null)] KIIJEIKLFBC EFBBEDJGKOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x650D320", Offset = "0x650C520", VA = "0x18650D320")]
	private static INAJDIGOLFE? BFPIDDLHGLB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x650D370", Offset = "0x650C570", VA = "0x18650D370", Slot = "4")]
	public bool HHGNCEHLKMH(CPCMBHAGMBL BKNMBDMLIFC, CPCMBHAGMBL EAMKGLGCBIB, IEnumerable<CPCMBHAGMBL> GKNDKOFIAEN, out NGGIDKNPOOG OFDPDONEGAM, out LHCIHHDMCMD PDGGOFGHKLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x650D480", Offset = "0x650C680", VA = "0x18650D480")]
	internal bool JBJLLJBKGGN(CPCMBHAGMBL BKNMBDMLIFC, CPCMBHAGMBL EAMKGLGCBIB, IEnumerable<CPCMBHAGMBL> GKNDKOFIAEN, JICMMHOABAL NJIPHLJIGDC, INAJDIGOLFE? COFMDLJJFDF, out NGGIDKNPOOG OFDPDONEGAM, out LHCIHHDMCMD PDGGOFGHKLP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface JKPOKANABHO<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	string GNGMKDMEANN
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event EBJLNOEAEHH<TPermission> FNDKOONHAFF;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public delegate void EBJLNOEAEHH<TPermission>(TPermission JCDODFGILJI);
[Cpp2IlInjected.Token(Token = "0x200000E")]
public delegate void EGBGGPCMEID(CPCMBHAGMBL NFMOCNFGHOI);
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class LOJBDFIOFMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly string POPEMGEEHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public readonly Type FDGJGBDKDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly OEGPBBJJPEE BGFDJENKNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly GGAFAPOLPEC ICBMKEFJLMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public DLJCLEKENKC HEIGCMFMILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public KHHGLJKHAFN ABPMGIFBGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public KPFAMJDMPLI KNJMDFNBLBP;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6518380", Offset = "0x6517580", VA = "0x186518380")]
	public LOJBDFIOFMB(Type CJIOGFBNAPC, string BIMCDJPIMPD, GGAFAPOLPEC JCDODFGILJI, DLJCLEKENKC IHAPFDEKGCI, KHHGLJKHAFN HLBLDDPBJLK, KPFAMJDMPLI DBOFIJEOEIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6518290", Offset = "0x6517490", VA = "0x186518290")]
	public object MEPCGIJEEJE(object? JMNBIHILIIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x19FE490", Offset = "0x19FD690", VA = "0x1819FE490")]
	public void OKJHLLAFMGB<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x65182D0", Offset = "0x65174D0", VA = "0x1865182D0")]
	public void OKJHLLAFMGB(Type CANFNKNEIID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class EHAJKHEHMBA<T> : LOJBDFIOFMB where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal delegate string JKBOPDDBBOF(T NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal delegate T JNFGMEHFIJF(string? NCEJBAEDMIH, T HMGHIIACOGF);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class CKIJAAJLGHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public JKBOPDDBBOF serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public JNFGMEHFIJF parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public CKIJAAJLGHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x26B0F50", Offset = "0x26B0150", VA = "0x1826B0F50")]
		internal string EAOJLJMDMMC(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x26B0E00", Offset = "0x26B0000", VA = "0x1826B0E00")]
		internal object BCIDNGHIKBL(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3130990", Offset = "0x312FB90", VA = "0x183130990")]
	public EHAJKHEHMBA(GGAFAPOLPEC JCDODFGILJI, string BIMCDJPIMPD, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0CD0", Offset = "0x6E00D0")] EHAJKHEHMBA<T>.JKBOPDDBBOF IHAPFDEKGCI, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0D30", Offset = "0x6E0130")] EHAJKHEHMBA<T>.JNFGMEHFIJF HLBLDDPBJLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x312FF20", Offset = "0x312F120", VA = "0x18312FF20")]
	private static object? JHIOLOAEPHF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0D90", Offset = "0x6E0190")] EHAJKHEHMBA<T?>.JNFGMEHFIJF? HLBLDDPBJLK, string? NCEJBAEDMIH, object? HMGHIIACOGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x312EF90", Offset = "0x312E190", VA = "0x18312EF90")]
	private static string IOAMGHHAJNN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0DF0", Offset = "0x6E01F0")] EHAJKHEHMBA<T>.JKBOPDDBBOF OLDCKNDJOAA, object? NABCGCEIEGG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface KDPFJMHDDBK
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	CPCMBHAGMBL AFECNDFGPLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	KDLCCGABAHG EDDIDJKBCEF
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	JICMMHOABAL BGNCKIDAPPN
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<MMHGMLBGEBB> KIKNCHJMDHD;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action ADPLGCKCOML;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ODGLGJAJPCF JINPICBMMCE(CPCMBHAGMBL NFMOCNFGHOI);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<MMHGMLBGEBB> ENBJMNLADPB(CancellationToken MELLLMEKJLC);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task OBIOFJCIGPC(long HBFBDJIOFCF, long BGOPDGBJMDP, IReadOnlyList<NNBHHCFGCMD> LCFFFCAHABE);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<CPCMBHAGMBL> DHACJOIOFCF();
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class EKOPLOIKKBO
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x650D9B0", Offset = "0x650CBB0", VA = "0x18650D9B0")]
	public static ODGLGJAJPCF KJPKBAANIGK(this KDPFJMHDDBK JOFKJGNJPDJ)
	{
		return default(ODGLGJAJPCF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal class GGKGIEIGEKP : ICJMDAGKACL, EELHKHOODBH, BODNNMPPAJA, JKPOKANABHO<GGAFAPOLPEC>
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	internal static readonly GCFJKAPKAOD DFBPAEHOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	internal readonly IKGPELPAAFM EIIOLHHHACC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private string? AFMBMPDOIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private string? JCGOMPENHMN;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private bool CBAAOHDKBPK
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x650EE00", Offset = "0x650E000", VA = "0x18650EE00", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private bool IDOEHLKCKNP
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x650FBA0", Offset = "0x650EDA0", VA = "0x18650FBA0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private bool HIPKPIAMEPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x650EEA0", Offset = "0x650E0A0", VA = "0x18650EEA0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private bool JGIFLJIOLAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x650FB00", Offset = "0x650ED00", VA = "0x18650FB00", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private bool KEJKENONENM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x650EE50", Offset = "0x650E050", VA = "0x18650EE50", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private bool HKFMJEICNJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x650F270", Offset = "0x650E470", VA = "0x18650F270", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public ODGLGJAJPCF NEHAGOPKGDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x94D950", Offset = "0x94CB50", VA = "0x18094D950", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(ODGLGJAJPCF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x94D9A0", Offset = "0x94CBA0", VA = "0x18094D9A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string GNGMKDMEANN
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6510C50", Offset = "0x650FE50", VA = "0x186510C50", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x650FA60", Offset = "0x650EC60", VA = "0x18650FA60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string BCPGPKECJLG
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6510C50", Offset = "0x650FE50", VA = "0x186510C50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool GHOFLCBPMKH
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA32400", Offset = "0xA31600", VA = "0x180A32400")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA32340", Offset = "0xA31540", VA = "0x180A32340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool LGONDCEKFHC
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6510A70", Offset = "0x650FC70", VA = "0x186510A70", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public NGGIDKNPOOG FKCDANCICNA
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6510AC0", Offset = "0x650FCC0", VA = "0x186510AC0", Slot = "20")]
		get
		{
			return default(NGGIDKNPOOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool OCMLBGMBNEB
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x650ECA0", Offset = "0x650DEA0", VA = "0x18650ECA0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool MLPLMBCODIN
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6510820", Offset = "0x650FA20", VA = "0x186510820", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool BDKHHMOBKIL
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6510CA0", Offset = "0x650FEA0", VA = "0x186510CA0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool PKANCEBCIFB
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x650FAB0", Offset = "0x650ECB0", VA = "0x18650FAB0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool EHBGNNBKNEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x650FB50", Offset = "0x650ED50", VA = "0x18650FB50", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool IDOBGFKFJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x650F220", Offset = "0x650E420", VA = "0x18650F220", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool IHLILOPJLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6510950", Offset = "0x650FB50", VA = "0x186510950", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool EFIELDKJOOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x650F130", Offset = "0x650E330", VA = "0x18650F130", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IReadOnlyList<string> LDCFKEKJIOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x650F3D0", Offset = "0x650E5D0", VA = "0x18650F3D0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool BNLGLKEBCBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x650EE00", Offset = "0x650E000", VA = "0x18650EE00", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool HFOLANLFCFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x650EE50", Offset = "0x650E050", VA = "0x18650EE50", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool FNGDGNHLADB
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x650FBA0", Offset = "0x650EDA0", VA = "0x18650FBA0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool BANCGGPEFOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x650ECF0", Offset = "0x650DEF0", VA = "0x18650ECF0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool PCIECIMOGLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6510CF0", Offset = "0x650FEF0", VA = "0x186510CF0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool IGCALGONCLF
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x650EEA0", Offset = "0x650E0A0", VA = "0x18650EEA0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool IIDNFAGIOKE
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x65109A0", Offset = "0x650FBA0", VA = "0x1865109A0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool JNGIBKIMOLL
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x650FB00", Offset = "0x650ED00", VA = "0x18650FB00", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool AMAHMOADAMF
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x650F270", Offset = "0x650E470", VA = "0x18650F270", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event EBJLNOEAEHH<GGAFAPOLPEC> FNDKOONHAFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6510BB0", Offset = "0x650FDB0", VA = "0x186510BB0", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x650F180", Offset = "0x650E380", VA = "0x18650F180", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1E29080", Offset = "0x1E28280", VA = "0x181E29080", Slot = "6")]
	public (bool, T?) EKOBOPGEEJK<T>(GGAFAPOLPEC JCDODFGILJI) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1E29220", Offset = "0x1E28420", VA = "0x181E29220")]
	public GGKGIEIGEKP LKEFMIFGGIN<T>(GGAFAPOLPEC JCDODFGILJI, bool OAAANKOGCJC, T NABCGCEIEGG) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6510DD0", Offset = "0x650FFD0", VA = "0x186510DD0")]
	public GGKGIEIGEKP(ODGLGJAJPCF BIGFJLEPFIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6510DB0", Offset = "0x650FFB0", VA = "0x186510DB0")]
	public GGKGIEIGEKP(ODGLGJAJPCF BIGFJLEPFIA, [Optional] string? AFMBMPDOIDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6510DF0", Offset = "0x650FFF0", VA = "0x186510DF0")]
	public GGKGIEIGEKP(GGKGIEIGEKP APFJOCKGMMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6510E80", Offset = "0x6510080", VA = "0x186510E80")]
	internal GGKGIEIGEKP(ODGLGJAJPCF MOLDIKBABJN, [Optional] string? AFMBMPDOIDI, [Optional] GGKGIEIGEKP? APFJOCKGMMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x65109F0", Offset = "0x650FBF0", VA = "0x1865109F0")]
	public static OEGPBBJJPEE LOJOJIAIBAI(GGAFAPOLPEC JCDODFGILJI)
	{
		return default(OEGPBBJJPEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x650EDE0", Offset = "0x650DFE0", VA = "0x18650EDE0")]
	public void ACPPMINFEOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x650F7D0", Offset = "0x650E9D0", VA = "0x18650F7D0")]
	internal GGKGIEIGEKP EAKPFGJEADP(GGKGIEIGEKP EPDJPMOGDCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x650F430", Offset = "0x650E630", VA = "0x18650F430")]
	internal IReadOnlyCollection<GGAFAPOLPEC> DLOFCDEOECF(GGKGIEIGEKP APFJOCKGMMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6510870", Offset = "0x650FA70", VA = "0x186510870")]
	public bool JMEHGIJNBEO(GGAFAPOLPEC JCDODFGILJI, bool OAAANKOGCJC, string BEBANGENMEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x650F2C0", Offset = "0x650E4C0", VA = "0x18650F2C0")]
	public (bool, string) DGAKGMIHMPE(GGAFAPOLPEC JCDODFGILJI)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x650ED40", Offset = "0x650DF40", VA = "0x18650ED40")]
	internal void ACNNFJNMPKK(GGAFAPOLPEC JCDODFGILJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x650EEF0", Offset = "0x650E0F0", VA = "0x18650EEF0")]
	public LKAEDPOGPNK BKPOFHBJEPI(Func<ODGLGJAJPCF, Guid> KCOOGHKJDKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x650FBF0", Offset = "0x650EDF0", VA = "0x18650FBF0")]
	public void IICHBOEJLDA(LKAEDPOGPNK APNDMKFOAKK, Func<Guid, ODGLGJAJPCF> IFLAHPCKPFF, [Optional] ODGLGJAJPCF? LBCCBOLJDGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6510B10", Offset = "0x650FD10", VA = "0x186510B10")]
	[CompilerGenerated]
	private void OEOFMADIAOB(GGAFAPOLPEC EJNJHEFKLLL, BOODBLDOIGK ENEKGKBDNAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface HCECHADMPKM
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HHGNCEHLKMH(CPCMBHAGMBL BKNMBDMLIFC, CPCMBHAGMBL EAMKGLGCBIB, IEnumerable<CPCMBHAGMBL> GKNDKOFIAEN, out NGGIDKNPOOG OFDPDONEGAM, out LHCIHHDMCMD PDGGOFGHKLP);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum LHCIHHDMCMD : byte
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	CantKickEventOrganizer
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface EELHKHOODBH
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool LGONDCEKFHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool OCMLBGMBNEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool MLPLMBCODIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool BDKHHMOBKIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	bool PKANCEBCIFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool EHBGNNBKNEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool IDOBGFKFJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool IHLILOPJLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool EFIELDKJOOO
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool BANCGGPEFOK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool PCIECIMOGLG
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool IIDNFAGIOKE
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	IReadOnlyList<string> LDCFKEKJIOB
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	NGGIDKNPOOG FKCDANCICNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface ICJMDAGKACL : EELHKHOODBH, BODNNMPPAJA, JKPOKANABHO<GGAFAPOLPEC>
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string BCPGPKECJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	ODGLGJAJPCF NEHAGOPKGDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) EKOBOPGEEJK<T>(GGAFAPOLPEC JCDODFGILJI) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal abstract class NGLCODBJNMG
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public object? AMELCINHDGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7E2110", Offset = "0x7E1310", VA = "0x1807E2110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x902EE0", Offset = "0x9020E0", VA = "0x180902EE0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x8888D0", Offset = "0x887AD0", VA = "0x1808888D0")]
	protected NGLCODBJNMG(object? MIABFMDOPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool HJFEACFKPKA(object? NABCGCEIEGG);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class ELFKDCHGHIP<T> : NGLCODBJNMG where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private T BCDLOPBDFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly IEqualityComparer<T> NNHMIGOGOIB;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T HDFPEMDEFEE
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x94D950", Offset = "0x94CB50", VA = "0x18094D950")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x162C9A0", Offset = "0x162BBA0", VA = "0x18162C9A0", Slot = "4")]
	public override bool HJFEACFKPKA(object? NABCGCEIEGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x162C4C0", Offset = "0x162B6C0", VA = "0x18162C4C0")]
	public bool DHEFDOBJLJD(T LKOJIONFALC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x162CC50", Offset = "0x162BE50", VA = "0x18162CC50")]
	public ELFKDCHGHIP(T HMGHIIACOGF, IEqualityComparer<T> NNHMIGOGOIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal static class JKIHBHGFKIP
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[Flags]
	public enum MMBCBKEMGHK
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
	public static readonly Guid OIELGHMOJJK;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public static readonly Guid DMEEDKMLBEI;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public static readonly Guid NHNDCPEBMKI;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly Guid IMPKKOOHJKD;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly Guid EPAFIPADPEK;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly EFDLCENOCIB<ODGLGJAJPCF, Guid> JIHPGDBDNGK;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal static IEnumerable<ODGLGJAJPCF> MNJAEAJHDEP
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x65178A0", Offset = "0x6516AA0", VA = "0x1865178A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6517920", Offset = "0x6516B20", VA = "0x186517920")]
	public static ODGLGJAJPCF AHHCHPIOOFE(Guid BHKAMCELBPN)
	{
		return default(ODGLGJAJPCF);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6517A60", Offset = "0x6516C60", VA = "0x186517A60")]
	public static Guid BANKKLABMOH(ODGLGJAJPCF BIGFJLEPFIA)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6517B40", Offset = "0x6516D40", VA = "0x186517B40")]
	public static bool IBNIMLBDPFF(ODGLGJAJPCF BIGFJLEPFIA, out Guid BHKAMCELBPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6517BE0", Offset = "0x6516DE0", VA = "0x186517BE0")]
	public static bool IDFPLLBEHLM(Guid BHKAMCELBPN, out ODGLGJAJPCF BIGFJLEPFIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6517B10", Offset = "0x6516D10", VA = "0x186517B10")]
	public static ODGLGJAJPCF DHMJHKMHEJO(ODGLGJAJPCF BIGFJLEPFIA)
	{
		return default(ODGLGJAJPCF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x65179B0", Offset = "0x6516BB0", VA = "0x1865179B0")]
	public static MMBCBKEMGHK AILCBBFCHOF(ODGLGJAJPCF JEKANCGDKGJ)
	{
		return default(MMBCBKEMGHK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6517C80", Offset = "0x6516E80", VA = "0x186517C80")]
	internal static ODGLGJAJPCF MJEAJBELGJD(MMBCBKEMGHK FDGIKBLDHLI)
	{
		return default(ODGLGJAJPCF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal delegate string DLJCLEKENKC(object? NABCGCEIEGG);
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal delegate object KHHGLJKHAFN(string? NCEJBAEDMIH, [Optional] object HMGHIIACOGF);
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal delegate NGLCODBJNMG KPFAMJDMPLI();
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class GCFJKAPKAOD
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private class JMOFAKJNGIC : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		internal static JMOFAKJNGIC JHOAALADPKE;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6517F90", Offset = "0x6517190", VA = "0x186517F90", Slot = "4")]
		public bool Equals(List<string> JPBGAMDOIJA, List<string> IIJHAMIHIMK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x65180F0", Offset = "0x65172F0", VA = "0x1865180F0", Slot = "5")]
		public int GetHashCode(List<string> PPNJOAJJOFF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public JMOFAKJNGIC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private class OBGFJFGCKHJ : LPJJPNCCMEC<NGGIDKNPOOG>
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6518C80", Offset = "0x6517E80", VA = "0x186518C80", Slot = "9")]
		public override string IOAMGHHAJNN(NGGIDKNPOOG FBJAKOEONGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6518D70", Offset = "0x6517F70", VA = "0x186518D70", Slot = "10")]
		protected override bool JMIIBLGIIAL(string FBJAKOEONGA, out NGGIDKNPOOG NABCGCEIEGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6518F60", Offset = "0x6518160", VA = "0x186518F60")]
		public OBGFJFGCKHJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static readonly IGKABLPCLOL HHOCEBICBKP;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly OBGFJFGCKHJ OIHGEPDMHFE;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly List<LOJBDFIOFMB> PBBNJFFCHMJ;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public IEnumerable<GGAFAPOLPEC> IFGAJMFHCNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7E2110", Offset = "0x7E1310", VA = "0x1807E2110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public IReadOnlyDictionary<GGAFAPOLPEC, LOJBDFIOFMB> KBLLBCBEFJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x650E930", Offset = "0x650DB30", VA = "0x18650E930")]
	public GCFJKAPKAOD([Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0ED0", Offset = "0x6E02D0")] IList<LOJBDFIOFMB> OIPPAEPGGAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x650DD50", Offset = "0x650CF50", VA = "0x18650DD50")]
	public LOJBDFIOFMB JFMNDIKIIMI(GGAFAPOLPEC JCDODFGILJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class GIGNNBENJNM : BHDKBNKGEOM, KIIJEIKLFBC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class NLALJMNKDKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public GGKGIEIGEKP newRole;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public NLALJMNKDKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6518BC0", Offset = "0x6517DC0", VA = "0x186518BC0")]
		internal bool PBMAJFDMNJG(GGKGIEIGEKP rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class OKIFBPLAMMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public ODGLGJAJPCF roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public OKIFBPLAMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6518FA0", Offset = "0x65181A0", VA = "0x186518FA0")]
		internal bool NMCCJFCPJLP(ODGLGJAJPCF r)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class NJDCPHIFPAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public PPPFGNOFILG roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public GIGNNBENJNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private bool <isOffline>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private MMHGMLBGEBB <tokenAndPermissionsDto>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private bool <hasRoomRoles>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private MMHGMLBGEBB <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private bool <serverHasPermissions>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1460", Offset = "0x6E0860")]
		private TaskAwaiter<MMHGMLBGEBB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public NJDCPHIFPAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6518410", Offset = "0x6517610", VA = "0x186518410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class AGMLJNCMFGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public AGMLJNCMFGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x650C360", Offset = "0x650B560", VA = "0x18650C360")]
		internal void HDJDEKONKKM(LKAEDPOGPNK r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x650C460", Offset = "0x650B660", VA = "0x18650C460")]
		internal void OPMMNCNBJID(LKAEDPOGPNK r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct FJAHMHIMIGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public PPPFGNOFILG roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class BGBNMFFAINO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E14C0", Offset = "0x6E08C0")]
		public Func<LKAEDPOGPNK, BOODBLDOIGK> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public BGBNMFFAINO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x650D2B0", Offset = "0x650C4B0", VA = "0x18650D2B0")]
		internal void DDBHJGLKPMB(LKAEDPOGPNK r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x650D1D0", Offset = "0x650C3D0", VA = "0x18650D1D0")]
		internal void BJHEGKJLELC(LKAEDPOGPNK r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x650D240", Offset = "0x650C440", VA = "0x18650D240")]
		internal void CPIOLJPFDLA(LKAEDPOGPNK r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class GCFBBFIJECF<T> where T : notnull
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
			public GCFBBFIJECF<T> <>4__this;

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
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1580", Offset = "0x6E0980")]
			private TaskAwaiter<MMHGMLBGEBB> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
			public <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x1A4A050", Offset = "0x1A49250", VA = "0x181A4A050", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public GIGNNBENJNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public GGAFAPOLPEC rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public ODGLGJAJPCF accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public OEGPBBJJPEE recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public string serializedNewValue;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public GCFBBFIJECF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x22CE8B0", Offset = "0x22CDAB0", VA = "0x1822CE8B0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(GCFBBFIJECF<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void NPCDBNFAPAF()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct MAPKFIDFPIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public IReadOnlyList<NNBHHCFGCMD> newPermissionOverrides;
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class AIPFKOCFNHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public KDPFJMHDDBK rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public PPPFGNOFILG roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E15E0", Offset = "0x6E09E0")]
		public IReadOnlyDictionary<ODGLGJAJPCF, GGKGIEIGEKP> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public ABOPJMGLBBD debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private StringBuilder <migrationLogBuilder>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1640", Offset = "0x6E0A40")]
		private List<NNBHHCFGCMD> <permissionsChangeBatch>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private IEnumerator<LKAEDPOGPNK> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private LKAEDPOGPNK <roleData>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private ODGLGJAJPCF <roleAccountType>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private GGKGIEIGEKP <role>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private IReadOnlyList<GGAFAPOLPEC> <modifiedPermissions>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private IEnumerator<GGAFAPOLPEC> <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private GGAFAPOLPEC <permission>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private OEGPBBJJPEE <recNetPermissionType>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E16A0", Offset = "0x6E0AA0")]
		private (bool Overrides, string SerializedValue) <serializedData>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public AIPFKOCFNHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x650C590", Offset = "0x650B790", VA = "0x18650C590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly KDPFJMHDDBK JOFKJGNJPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly HMAKAMMFFGA PHFDCKPMCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly ABOPJMGLBBD GBPMIBGGBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly Dictionary<int, GGKGIEIGEKP> OMKEGGFEIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal readonly Dictionary<ODGLGJAJPCF, GGKGIEIGEKP> JFNCAPHFMIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal readonly Dictionary<ODGLGJAJPCF, GGKGIEIGEKP> FPOFJFMPABP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal readonly List<GGKGIEIGEKP> NKMDDNMDIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool HDCBMIONJJO;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly GGAFAPOLPEC[] GAOGIGKBDGB;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public KKJJOJNPNAC HMPLFHPCKDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public IEnumerable<ICJMDAGKACL> DNIOIGHKJMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x65141A0", Offset = "0x65133A0", VA = "0x1865141A0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event EGBGGPCMEID CKAELPDGCCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6512260", Offset = "0x6511460", VA = "0x186512260", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x65132F0", Offset = "0x65124F0", VA = "0x1865132F0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6511CA0", Offset = "0x6510EA0", VA = "0x186511CA0")]
	[GKCPJLBLCDF(FEKEMFJBKCA.Room, EHLDMJJGFKP.None)]
	private static void COJDMCIPHFF(JFLMNMMPBBG MKDJCBAHPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6516620", Offset = "0x6515820", VA = "0x186516620")]
	[UnityEngine.Scripting.Preserve]
	internal GIGNNBENJNM([NDGONEEEGIA(null)] KDPFJMHDDBK OPLBCOGDPPN, [NDGONEEEGIA(null)] HMAKAMMFFGA KABPDJMLGNA, [NDGONEEEGIA(null)] ABOPJMGLBBD GBPMIBGGBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6511E50", Offset = "0x6511050", VA = "0x186511E50", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6513670", Offset = "0x6512870", VA = "0x186513670")]
	private void JAKOMFGHOFH(IEnumerable<GGKGIEIGEKP> JHHIFODGNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6512190", Offset = "0x6511390", VA = "0x186512190", Slot = "12")]
	public bool ELGAKMIGKJH(CPCMBHAGMBL NFMOCNFGHOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6510FE0", Offset = "0x65101E0", VA = "0x186510FE0")]
	private void ADPLGCKCOML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6514E30", Offset = "0x6514030", VA = "0x186514E30")]
	private void MLMOBLHPCAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6512300", Offset = "0x6511500", VA = "0x186512300", Slot = "10")]
	public IReadOnlyList<ICJMDAGKACL> GMPAIIMLHMN(bool CGEPBMIEAOD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x65141F0", Offset = "0x65133F0", VA = "0x1865141F0", Slot = "11")]
	public ICJMDAGKACL KDKLDFLMFEE(CPCMBHAGMBL NFMOCNFGHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6511F60", Offset = "0x6511160", VA = "0x186511F60")]
	private ODGLGJAJPCF EDHIOIBEIEB(CPCMBHAGMBL NFMOCNFGHOI)
	{
		return default(ODGLGJAJPCF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6514010", Offset = "0x6513210", VA = "0x186514010", Slot = "14")]
	public bool JOMOELNEODO(CPCMBHAGMBL KNGHEFALGKJ, ODGLGJAJPCF BIGFJLEPFIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6514BE0", Offset = "0x6513DE0", VA = "0x186514BE0", Slot = "15")]
	public ICJMDAGKACL LLNCPGPOKFP(ODGLGJAJPCF BIGFJLEPFIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x65158D0", Offset = "0x6514AD0", VA = "0x1865158D0")]
	private static bool ONNGJGLIOGN(HCBKDCCCPFL LDINIPHKCOG, ODGLGJAJPCF BIGFJLEPFIA, out LKAEDPOGPNK? ALECIIEMLDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6514FB0", Offset = "0x65141B0", VA = "0x186514FB0")]
	private static void OFNGBEAMAKD(HCBKDCCCPFL LDINIPHKCOG, Action<LKAEDPOGPNK> AFFBNMPDKAC, ODGLGJAJPCF DBCOIEDACCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x65150B0", Offset = "0x65142B0", VA = "0x1865150B0")]
	private static void OFNGBEAMAKD(HCBKDCCCPFL LDINIPHKCOG, Action<LKAEDPOGPNK> AFFBNMPDKAC, Predicate<ODGLGJAJPCF> DNECEHDIOJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6513290", Offset = "0x6512490", VA = "0x186513290")]
	private void HEMJMCLMFKH(CPCMBHAGMBL NFMOCNFGHOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6512020", Offset = "0x6511220", VA = "0x186512020", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NJDCPHIFPAM))]
	public Task EKNLPNBDFGL([CanBeNull] PPPFGNOFILG DONGKHHNBIB, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
	public void JDBJHGBDEEK(ref PPPFGNOFILG DONGKHHNBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x65145E0", Offset = "0x65137E0", VA = "0x1865145E0")]
	private void KPPCILPDGMC(HCBKDCCCPFL LDBKKEEDCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6515E20", Offset = "0x6515020", VA = "0x186515E20")]
	internal static string PHEEILDJEDM(KDPFJMHDDBK JOFKJGNJPDJ, PPPFGNOFILG DONGKHHNBIB, IReadOnlyDictionary<ODGLGJAJPCF, GGKGIEIGEKP> JFNCAPHFMIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6512380", Offset = "0x6511580", VA = "0x186512380")]
	private static void GPEMMLNJIAO(PPPFGNOFILG DONGKHHNBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6516140", Offset = "0x6515340", VA = "0x186516140")]
	private static void PIJFAIJMDEJ(HCBKDCCCPFL BKDKLPGGNLM, IReadOnlyDictionary<ODGLGJAJPCF, GGKGIEIGEKP> JFNCAPHFMIE, StringBuilder ALCIPBLAOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6515CC0", Offset = "0x6514EC0", VA = "0x186515CC0")]
	private static bool PBNPOAPGMHO(string HPGAKDEIPGE, out Guid FEKOELJNBHI, out ODGLGJAJPCF BIGFJLEPFIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x65152B0", Offset = "0x65144B0", VA = "0x1865152B0")]
	private static void OIOJOGJINKB(PPPFGNOFILG DONGKHHNBIB, StringBuilder ALCIPBLAOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x1E29260", Offset = "0x1E28460", VA = "0x181E29260", Slot = "16")]
	public bool AMPAPHGKEDB<T>(ODGLGJAJPCF BIGFJLEPFIA, GGAFAPOLPEC JCDODFGILJI, bool OAAANKOGCJC, T CIKBJELAGAP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6513E60", Offset = "0x6513060", VA = "0x186513E60")]
	private void JIMBHCDHKCF(ODGLGJAJPCF BIGFJLEPFIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6511000", Offset = "0x6510200", VA = "0x186511000")]
	private bool BDMGOEFDBDF(CPCMBHAGMBL NFMOCNFGHOI, ODGLGJAJPCF BIGFJLEPFIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6511020", Offset = "0x6510220", VA = "0x186511020")]
	internal GGKGIEIGEKP BJKDKMAEPAN(CPCMBHAGMBL NFMOCNFGHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6510FF0", Offset = "0x65101F0", VA = "0x186510FF0", Slot = "13")]
	public IReadOnlyList<ICJMDAGKACL> AEFHBGBHGGA(CPCMBHAGMBL NFMOCNFGHOI, bool PHPDLBPIGKE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6511340", Offset = "0x6510540", VA = "0x186511340")]
	internal IReadOnlyList<GGKGIEIGEKP> BLDNJFBGPMF(CPCMBHAGMBL NFMOCNFGHOI, bool PHPDLBPIGKE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6511560", Offset = "0x6510760", VA = "0x186511560")]
	private void CGPHHHLDOOI(MMHGMLBGEBB LFPDJODHNPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6514300", Offset = "0x6513500", VA = "0x186514300")]
	private static bool KHFOBDHPKKE(GGKGIEIGEKP JFLMHEECECJ, IReadOnlyDictionary<ODGLGJAJPCF, GGKGIEIGEKP> JFNCAPHFMIE, out IReadOnlyList<GGAFAPOLPEC> BEEHECLBLJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6514C90", Offset = "0x6513E90", VA = "0x186514C90")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AIPFKOCFNHK))]
	private static Task MECAHNIMLAK(KDPFJMHDDBK JOFKJGNJPDJ, PPPFGNOFILG DONGKHHNBIB, IReadOnlyDictionary<ODGLGJAJPCF, GGKGIEIGEKP> JFNCAPHFMIE, ABOPJMGLBBD GBPMIBGGBAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6513390", Offset = "0x6512590", VA = "0x186513390")]
	[CompilerGenerated]
	internal static void ICFILCCODCG(Func<LKAEDPOGPNK, BOODBLDOIGK> OOKJELLNFBK, ref FJAHMHIMIGK P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6514860", Offset = "0x6513A60", VA = "0x186514860")]
	[CompilerGenerated]
	internal static bool LGIMDIAACBO(ODGLGJAJPCF BIGFJLEPFIA, GGAFAPOLPEC JCDODFGILJI, out NNBHHCFGCMD INCDMPMCJJE, ref MAPKFIDFPIJ P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public enum GGAFAPOLPEC
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
internal class IKGPELPAAFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly Dictionary<GGAFAPOLPEC, bool> FHECMEGIIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly Dictionary<GGAFAPOLPEC, NGLCODBJNMG> GJFHJDCHPJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly GCFJKAPKAOD AEKIOICNGHB;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6517650", Offset = "0x6516850", VA = "0x186517650")]
	public IKGPELPAAFM(GCFJKAPKAOD AEKIOICNGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6517520", Offset = "0x6516720", VA = "0x186517520")]
	public bool FMLPCAHFGOK(GGAFAPOLPEC JCDODFGILJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x1D13D30", Offset = "0x1D12F30", VA = "0x181D13D30")]
	public bool FJKECNAHKOH<T>(GGAFAPOLPEC JCDODFGILJI, bool OAAANKOGCJC, T NABCGCEIEGG) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x1D138C0", Offset = "0x1D12AC0", VA = "0x181D138C0")]
	public (bool, T?) AFHAJFDBPBP<T>(GGAFAPOLPEC JCDODFGILJI) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6517440", Offset = "0x6516640", VA = "0x186517440")]
	public bool FJKECNAHKOH(GGAFAPOLPEC JCDODFGILJI, bool OAAANKOGCJC, object NABCGCEIEGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6517350", Offset = "0x6516550", VA = "0x186517350")]
	public (bool, object) AFHAJFDBPBP(GGAFAPOLPEC JCDODFGILJI)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x1D13E60", Offset = "0x1D13060", VA = "0x181D13E60")]
	private void OKJHLLAFMGB<T>(GGAFAPOLPEC JCDODFGILJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6517590", Offset = "0x6516790", VA = "0x186517590")]
	private NGLCODBJNMG MJDGEELDGLO(GGAFAPOLPEC JCDODFGILJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x65171D0", Offset = "0x65163D0", VA = "0x1865171D0")]
	public void ACPPMINFEOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface KKJJOJNPNAC
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	ICJMDAGKACL HBHOLCAMHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal class HMAKAMMFFGA : KKJJOJNPNAC
{
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public static HMAKAMMFFGA BNDMAFFBGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	internal readonly GGKGIEIGEKP PHGFLBIOMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	internal readonly IReadOnlyList<GGKGIEIGEKP> IFKMHBBKMAC;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public ICJMDAGKACL HBHOLCAMHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7E2110", Offset = "0x7E1310", VA = "0x1807E2110", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x65170D0", Offset = "0x65162D0", VA = "0x1865170D0")]
	public HMAKAMMFFGA(GGKGIEIGEKP OIENNBECNNM, IReadOnlyList<GGKGIEIGEKP> IIBEPIGHBMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x65168B0", Offset = "0x6515AB0", VA = "0x1865168B0")]
	private static HMAKAMMFFGA BMKFEDMGDMK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public enum BJFDFKCGOMK
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
