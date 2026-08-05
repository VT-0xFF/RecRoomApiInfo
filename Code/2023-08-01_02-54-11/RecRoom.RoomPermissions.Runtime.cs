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
		[Cpp2IlInjected.Address(RVA = "0x8484E0", Offset = "0x8474E0", VA = "0x1808484E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6890830", Offset = "0x688F830", VA = "0x186890830")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xB36FF0", Offset = "0xB35FF0", VA = "0x180B36FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x183B060", Offset = "0x183A060", VA = "0x18183B060")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum CBPEEAGFBOB
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface BOPPBNHNKLD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	MOHDNPIGBJA GFHBOIKEHAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<NKKBLOADMCF> IMNGAABGJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event LOIPCHBBGOG LILIFDEIDKB;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<NKKBLOADMCF> CCGFJPHJFDP(bool GOKIGPEMAEN = false);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NKKBLOADMCF FPBKMGEBOCA(JMNGDDABPMO ECKCAFOFCOA);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool AGBGDMFHINJ(JMNGDDABPMO ECKCAFOFCOA);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<NKKBLOADMCF> KEFNOEECJHD(JMNGDDABPMO ECKCAFOFCOA, bool IPHKJCPNLJL = false);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GPKJDPJJHIN(JMNGDDABPMO JOGLAMJMONM, PMFLBIIBDDN GBMOIGBGEMP);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	NKKBLOADMCF JPNKFJHIELN(PMFLBIIBDDN GBMOIGBGEMP);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool GPIIDGOGNIP<T>(PMFLBIIBDDN GBMOIGBGEMP, OGGFLAIGBFD DNANLOGINGF, bool CNBBOOMAPFF, T HKOOLAFMDPF) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface DNODMFKDHPD
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task AFLCKHAKGBG(HJBOCBIPMIO EICHFPBIJBD, CancellationToken AOAEIGNDKPI);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JLHDCPJIKCE(ref HJBOCBIPMIO EICHFPBIJBD);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface OAMPGBLBGEN
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool HMMNFHELMKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool IFIBNHEJOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool GGPPLHIAKEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool NJCNGEAFDCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool FCPOPMKOCGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool CMNONAKIHMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class OPBDKLLKAEH
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly IReadOnlyList<PMFLBIIBDDN> FIAFKKLGFIK;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x68908C0", Offset = "0x688F8C0", VA = "0x1868908C0")]
	public static bool EMDILHDFFLK(this JMNGDDABPMO GDEGDBOPGEN, PMFLBIIBDDN GBMOIGBGEMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x68909B0", Offset = "0x688F9B0", VA = "0x1868909B0")]
	public static bool PDMMHMGCNLE(this JMNGDDABPMO GDEGDBOPGEN, PMFLBIIBDDN GBMOIGBGEMP, HFCNBIIEHLN KLFEHFNEONK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class GAPKBJDMFCM : KFAAFCKJELB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly BOPPBNHNKLD DAABNHKAPMI;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x934550", Offset = "0x933550", VA = "0x180934550")]
	[RecRoom.NoEngine.Common.Preserve]
	public GAPKBJDMFCM([KMDNJCFAMOJ(null)] BOPPBNHNKLD DHHKCMJHODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6889DD0", Offset = "0x6888DD0", VA = "0x186889DD0")]
	private static BAMBMLHGELE? HDAOHMCIOBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6889790", Offset = "0x6888790", VA = "0x186889790", Slot = "4")]
	public bool AGFMPFLBPHN(JMNGDDABPMO FNLBHFKFHIH, JMNGDDABPMO FHJPGHOCENN, IEnumerable<JMNGDDABPMO> JDNHBMPMCGN, out CBPEEAGFBOB MBGOGKAMBHP, out CCJIBJHPDCP HJJKPDPPNCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x68898A0", Offset = "0x68888A0", VA = "0x1868898A0")]
	internal bool FPFGHOGCCNH(JMNGDDABPMO FNLBHFKFHIH, JMNGDDABPMO FHJPGHOCENN, IEnumerable<JMNGDDABPMO> JDNHBMPMCGN, HFCNBIIEHLN KLFEHFNEONK, BAMBMLHGELE? AEANNJGKOGK, out CBPEEAGFBOB MBGOGKAMBHP, out CCJIBJHPDCP HJJKPDPPNCM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KEKHDBOCKAI<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	string JMLKJLLLKNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event JNHBEPFEDIL<TPermission> DJCKAMEPBDJ;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public delegate void JNHBEPFEDIL<TPermission>(TPermission DNANLOGINGF);
[Cpp2IlInjected.Token(Token = "0x200000E")]
public delegate void LOIPCHBBGOG(JMNGDDABPMO ECKCAFOFCOA);
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class DMEMIDHJMNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly string CKPNJKGCAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public readonly Type JEOGEPLDGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly AEDDMJADPFC DEGFOKIKBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly OGGFLAIGBFD ACEIKIKLPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public AHPLONCCHEG GBMHNHGFDPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public DDDCHICNOKE LHFJOFJFGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public GFHFBIPIJOB JCGLACMBACB;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6885E10", Offset = "0x6884E10", VA = "0x186885E10")]
	public DMEMIDHJMNL(Type CAGIEIGDHLJ, string BOJGDKMMJDF, OGGFLAIGBFD DNANLOGINGF, AHPLONCCHEG NNJFJGFNBDC, DDDCHICNOKE MOHJBKGIIFB, GFHFBIPIJOB EJGGONGOKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6885DD0", Offset = "0x6884DD0", VA = "0x186885DD0")]
	public object GGIOMAODOAE(object? JONIFABKCAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x222AB10", Offset = "0x2229B10", VA = "0x18222AB10")]
	public void GACNNAPICCC<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6885D20", Offset = "0x6884D20", VA = "0x186885D20")]
	public void GACNNAPICCC(Type PBNICHIICIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class AFJJAIBJFLJ<T> : DMEMIDHJMNL where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal delegate string BAAGONAMEKF(T CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal delegate T FMPILGMABFB(string? NPLHDPLPAGA, T AFGLNBMEDLH);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class KFDJBMBCGEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public BAAGONAMEKF serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public FMPILGMABFB parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public KFDJBMBCGEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x23272C0", Offset = "0x23262C0", VA = "0x1823272C0")]
		internal string AMPEBIDKAFP(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2327360", Offset = "0x2326360", VA = "0x182327360")]
		internal object DFBJNOFIBEH(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2FB00A0", Offset = "0x2FAF0A0", VA = "0x182FB00A0")]
	public AFJJAIBJFLJ(OGGFLAIGBFD DNANLOGINGF, string BOJGDKMMJDF, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7347E0", Offset = "0x733BE0")] AFJJAIBJFLJ<T>.BAAGONAMEKF NNJFJGFNBDC, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x734840", Offset = "0x733C40")] AFJJAIBJFLJ<T>.FMPILGMABFB MOHJBKGIIFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2FAF640", Offset = "0x2FAE640", VA = "0x182FAF640")]
	private static object? BPADPDDPOEA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7348A0", Offset = "0x733CA0")] AFJJAIBJFLJ<T?>.FMPILGMABFB? MOHJBKGIIFB, string? NPLHDPLPAGA, object? AFGLNBMEDLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2FAED20", Offset = "0x2FADD20", VA = "0x182FAED20")]
	private static string BCEEACLIKPE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x734900", Offset = "0x733D00")] AFJJAIBJFLJ<T>.BAAGONAMEKF GOHBKEFOICI, object? CKMKMNKGMMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface HAHHKHNHGPG
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	JMNGDDABPMO BJPOJMFLLNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	IACNHFFDGGB EOBCLNIKALH
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	HFCNBIIEHLN GGIAGGIEAFH
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<HEOLLBHFOHG> ICDLLHAAKNN;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action BKAEHNCLKNJ;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PMFLBIIBDDN PNCMOEEDMJH(JMNGDDABPMO ECKCAFOFCOA);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<HEOLLBHFOHG> PGBCMAEJIOO(CancellationToken AOAEIGNDKPI);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task HFABBEJGOMD(long IIKHCGCAMCH, long EMFFAEIKHBM, IReadOnlyList<FIBMBKLGHAN> FHMOFPDLEFP);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<JMNGDDABPMO> FMGPMJJMDLJ();
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class NGDBDDNHBMA
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x68907D0", Offset = "0x688F7D0", VA = "0x1868907D0")]
	public static PMFLBIIBDDN AHFOBCNHCNN(this HAHHKHNHGPG NOPALBLKALN)
	{
		return default(PMFLBIIBDDN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal class FAEMMOOFBCC : NKKBLOADMCF, GKIEDAHEOJD, OAMPGBLBGEN, KEKHDBOCKAI<OGGFLAIGBFD>
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	internal static readonly FECFNBDHOAE JAOMLIDPEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	internal readonly KKOLMDNHEHL JEIMAOEJNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private string? LNPGNCIGHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private string? NHONAMMPDPA;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private bool NALKOFOENKH
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6888210", Offset = "0x6887210", VA = "0x186888210", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private bool PBPKLHOAPCC
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x68865D0", Offset = "0x68855D0", VA = "0x1868865D0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private bool EGCCLGJBMCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6886580", Offset = "0x6885580", VA = "0x186886580", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private bool LNFAKMJCNJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6888080", Offset = "0x6887080", VA = "0x186888080", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private bool ENBEIIBCJDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6886B30", Offset = "0x6885B30", VA = "0x186886B30", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private bool EONCIGFBGID
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6886980", Offset = "0x6885980", VA = "0x186886980", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public PMFLBIIBDDN AKLHJEAHLMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x979400", Offset = "0x978400", VA = "0x180979400", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(PMFLBIIBDDN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xB674B0", Offset = "0xB664B0", VA = "0x180B674B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string JMLKJLLLKNE
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6888410", Offset = "0x6887410", VA = "0x186888410", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6886BD0", Offset = "0x6885BD0", VA = "0x186886BD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string HLBCGNIEMEB
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6888410", Offset = "0x6887410", VA = "0x186888410", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool KBMAJLKPCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x93A750", Offset = "0x939750", VA = "0x18093A750")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x93A6E0", Offset = "0x9396E0", VA = "0x18093A6E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool FAPNEBPAJHI
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6886AE0", Offset = "0x6885AE0", VA = "0x186886AE0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public CBPEEAGFBOB HKGNAKKJKDA
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x68880D0", Offset = "0x68870D0", VA = "0x1868880D0", Slot = "20")]
		get
		{
			return default(CBPEEAGFBOB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool BMADAIKLDOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6886C20", Offset = "0x6885C20", VA = "0x186886C20", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool LALNMNJIOEP
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6887B10", Offset = "0x6886B10", VA = "0x186887B10", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool HJFECAHGJOG
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6888500", Offset = "0x6887500", VA = "0x186888500", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool FGKJEALALLP
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6886B80", Offset = "0x6885B80", VA = "0x186886B80", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool NAEBPINPHKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x68881C0", Offset = "0x68871C0", VA = "0x1868881C0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool PAAKEGNAIMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6888550", Offset = "0x6887550", VA = "0x186888550", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool AFIFJOJHOCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x68869D0", Offset = "0x68859D0", VA = "0x1868869D0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool GHCPCAADANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6888170", Offset = "0x6887170", VA = "0x186888170", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IReadOnlyList<string> FKCMGIEHJIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6886520", Offset = "0x6885520", VA = "0x186886520", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool IKOHJNNKHAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6888210", Offset = "0x6887210", VA = "0x186888210", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool PKEFDCGCFFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6886B30", Offset = "0x6885B30", VA = "0x186886B30", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool KOGDLNMBKCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x68865D0", Offset = "0x68855D0", VA = "0x1868865D0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool EEBIHIDEPDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6888120", Offset = "0x6887120", VA = "0x186888120", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool IPLKFOIBIJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x68868B0", Offset = "0x68858B0", VA = "0x1868868B0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool MCNGOICADDB
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6886580", Offset = "0x6885580", VA = "0x186886580", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool EMFBPFBFOJI
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6886860", Offset = "0x6885860", VA = "0x186886860", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool PKONIJOHLDI
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6888080", Offset = "0x6887080", VA = "0x186888080", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool ABFPGKELJAN
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6886980", Offset = "0x6885980", VA = "0x186886980", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event JNHBEPFEDIL<OGGFLAIGBFD> DJCKAMEPBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6887C40", Offset = "0x6886C40", VA = "0x186887C40", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6886A40", Offset = "0x6885A40", VA = "0x186886A40", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1E15E80", Offset = "0x1E14E80", VA = "0x181E15E80", Slot = "6")]
	public (bool, T?) IDPPLBGKEII<T>(OGGFLAIGBFD DNANLOGINGF) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1E15E40", Offset = "0x1E14E40", VA = "0x181E15E40")]
	public FAEMMOOFBCC HLKEFBGMDMC<T>(OGGFLAIGBFD DNANLOGINGF, bool CNBBOOMAPFF, T CKMKMNKGMMC) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6888610", Offset = "0x6887610", VA = "0x186888610")]
	public FAEMMOOFBCC(PMFLBIIBDDN GBMOIGBGEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6888820", Offset = "0x6887820", VA = "0x186888820")]
	public FAEMMOOFBCC(PMFLBIIBDDN GBMOIGBGEMP, [Optional] string? LNPGNCIGHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6888630", Offset = "0x6887630", VA = "0x186888630")]
	public FAEMMOOFBCC(FAEMMOOFBCC NAEDFJEHIBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x68886C0", Offset = "0x68876C0", VA = "0x1868886C0")]
	internal FAEMMOOFBCC(PMFLBIIBDDN CINDLLLOOMM, [Optional] string? LNPGNCIGHAK, [Optional] FAEMMOOFBCC? NAEDFJEHIBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6886900", Offset = "0x6885900", VA = "0x186886900")]
	public static AEDDMJADPFC DEKFKDJEJLJ(OGGFLAIGBFD DNANLOGINGF)
	{
		return default(AEDDMJADPFC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6886A20", Offset = "0x6885A20", VA = "0x186886A20")]
	public void DMLAEHAJJHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6887880", Offset = "0x6886880", VA = "0x186887880")]
	internal FAEMMOOFBCC HLHLBGLIPIP(FAEMMOOFBCC PHEECOGLKCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6887CE0", Offset = "0x6886CE0", VA = "0x186887CE0")]
	internal IReadOnlyCollection<OGGFLAIGBFD> ICJGLKHKIDI(FAEMMOOFBCC NAEDFJEHIBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6887B60", Offset = "0x6886B60", VA = "0x186887B60")]
	public bool HMGGABGKCJE(OGGFLAIGBFD DNANLOGINGF, bool CNBBOOMAPFF, string IOIGBAPEPIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6888260", Offset = "0x6887260", VA = "0x186888260")]
	public (bool, string) NEKHIGOEMKM(OGGFLAIGBFD DNANLOGINGF)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6888370", Offset = "0x6887370", VA = "0x186888370")]
	internal void NHAGIFNMBBO(OGGFLAIGBFD DNANLOGINGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6886620", Offset = "0x6885620", VA = "0x186886620")]
	public CGDBCAHMFOD BEIKKDBGLIO(Func<PMFLBIIBDDN, Guid> EOINCKMNCFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6886C70", Offset = "0x6885C70", VA = "0x186886C70")]
	public void HLHHOIDHMCF(CGDBCAHMFOD GLEKHOPJLLI, Func<Guid, PMFLBIIBDDN> NMBMJDGNOIB, [Optional] PMFLBIIBDDN? KDPLBFIHOME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6888460", Offset = "0x6887460", VA = "0x186888460")]
	[CompilerGenerated]
	private void OLKMMJIIBGG(OGGFLAIGBFD FFLNAJOMKKD, MNLBLHLKIEH MBHLKMOFNBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KFAAFCKJELB
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AGFMPFLBPHN(JMNGDDABPMO FNLBHFKFHIH, JMNGDDABPMO FHJPGHOCENN, IEnumerable<JMNGDDABPMO> JDNHBMPMCGN, out CBPEEAGFBOB MBGOGKAMBHP, out CCJIBJHPDCP HJJKPDPPNCM);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum CCJIBJHPDCP : byte
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	CantKickEventOrganizer
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface GKIEDAHEOJD
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool FAPNEBPAJHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool BMADAIKLDOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool LALNMNJIOEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool HJFECAHGJOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	bool FGKJEALALLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool NAEBPINPHKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool PAAKEGNAIMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool AFIFJOJHOCK
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool GHCPCAADANB
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool EEBIHIDEPDK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool IPLKFOIBIJF
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool EMFBPFBFOJI
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	IReadOnlyList<string> FKCMGIEHJIF
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	CBPEEAGFBOB HKGNAKKJKDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface NKKBLOADMCF : GKIEDAHEOJD, OAMPGBLBGEN, KEKHDBOCKAI<OGGFLAIGBFD>
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string HLBCGNIEMEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	PMFLBIIBDDN AKLHJEAHLMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) IDPPLBGKEII<T>(OGGFLAIGBFD DNANLOGINGF) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal abstract class CFGEPOAOMGN
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public object? IEGGKBMGAGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x83A5D0", Offset = "0x8395D0", VA = "0x18083A5D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x92FA60", Offset = "0x92EA60", VA = "0x18092FA60")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x934550", Offset = "0x933550", VA = "0x180934550")]
	protected CFGEPOAOMGN(object? JBABFGONFMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool GGOJLLGJIAD(object? CKMKMNKGMMC);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class MPOCLFBKINA<T> : CFGEPOAOMGN where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private T DAMJMACHBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly IEqualityComparer<T> ENFOKHPMBND;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T MNHGIJMEOAH
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x979400", Offset = "0x978400", VA = "0x180979400")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x31BD630", Offset = "0x31BC630", VA = "0x1831BD630", Slot = "4")]
	public override bool GGOJLLGJIAD(object? CKMKMNKGMMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x31BDB30", Offset = "0x31BCB30", VA = "0x1831BDB30")]
	public bool LJAKIMPIPDE(T BJMOHDIBKNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x31BDE10", Offset = "0x31BCE10", VA = "0x1831BDE10")]
	public MPOCLFBKINA(T AFGLNBMEDLH, IEqualityComparer<T> ENFOKHPMBND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal static class GCDBODAODBK
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[Flags]
	public enum IIAOJKAOMEE
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
	public static readonly Guid PDDEBKPMHHL;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public static readonly Guid MBGDDEBMAIE;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public static readonly Guid MMEBFJGDILJ;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly Guid OFAJGLGPPLL;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly Guid FCCEFIDEBAF;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly NEKABHLNBGL<PMFLBIIBDDN, Guid> DOMEHGOHJJM;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal static IEnumerable<PMFLBIIBDDN> EDHJPFKDAKH
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x688A1C0", Offset = "0x68891C0", VA = "0x18688A1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6889F40", Offset = "0x6888F40", VA = "0x186889F40")]
	public static PMFLBIIBDDN KNIAKDFKJHI(Guid AGKIPDJPNCN)
	{
		return default(PMFLBIIBDDN);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6889FD0", Offset = "0x6888FD0", VA = "0x186889FD0")]
	public static Guid MFFLMNABBHL(PMFLBIIBDDN GBMOIGBGEMP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x688A080", Offset = "0x6889080", VA = "0x18688A080")]
	public static bool NIFJLAFAHMK(PMFLBIIBDDN GBMOIGBGEMP, out Guid AGKIPDJPNCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x688A120", Offset = "0x6889120", VA = "0x18688A120")]
	public static bool OACGIJJBEHA(Guid AGKIPDJPNCN, out PMFLBIIBDDN GBMOIGBGEMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6889E20", Offset = "0x6888E20", VA = "0x186889E20")]
	public static PMFLBIIBDDN FOILNLFBBCP(PMFLBIIBDDN GBMOIGBGEMP)
	{
		return default(PMFLBIIBDDN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6889E50", Offset = "0x6888E50", VA = "0x186889E50")]
	public static IIAOJKAOMEE HDLFIJCGCLO(PMFLBIIBDDN BDABKLJEBIP)
	{
		return default(IIAOJKAOMEE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6889F00", Offset = "0x6888F00", VA = "0x186889F00")]
	internal static PMFLBIIBDDN KKEBKLFLHNC(IIAOJKAOMEE ELILMNMLOAK)
	{
		return default(PMFLBIIBDDN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal delegate string AHPLONCCHEG(object? CKMKMNKGMMC);
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal delegate object DDDCHICNOKE(string? NPLHDPLPAGA, [Optional] object AFGLNBMEDLH);
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal delegate CFGEPOAOMGN GFHFBIPIJOB();
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class FECFNBDHOAE
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private class DNPOOADPLHK : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		internal static DNPOOADPLHK PCFKPPACGDB;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6885EA0", Offset = "0x6884EA0", VA = "0x186885EA0", Slot = "4")]
		public bool Equals(List<string> LMFGBCIIJHA, List<string> FPHLKKGCLDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6886000", Offset = "0x6885000", VA = "0x186886000", Slot = "5")]
		public int GetHashCode(List<string> DCGPCJKHCOO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public DNPOOADPLHK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private class IECBHHOPJBG : LBINACLDLGN<CBPEEAGFBOB>
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x688A510", Offset = "0x6889510", VA = "0x18688A510", Slot = "9")]
		public override string BCEEACLIKPE(CBPEEAGFBOB LBDAAAJFHNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x688A600", Offset = "0x6889600", VA = "0x18688A600", Slot = "10")]
		protected override bool JHLBGBAOEMM(string LBDAAAJFHNJ, out CBPEEAGFBOB CKMKMNKGMMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x688A7F0", Offset = "0x68897F0", VA = "0x18688A7F0")]
		public IECBHHOPJBG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static readonly ICEJIGMPAEC MNCIMJMAPHL;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly IECBHHOPJBG AAIJAKHANPK;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly List<DMEMIDHJMNL> PBMMBJKNCAH;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public IEnumerable<OGGFLAIGBFD> MBAHEGEEBCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x83A5D0", Offset = "0x8395D0", VA = "0x18083A5D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public IReadOnlyDictionary<OGGFLAIGBFD, DMEMIDHJMNL> EGBLLBEBMKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6889420", Offset = "0x6888420", VA = "0x186889420")]
	public FECFNBDHOAE([Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7349E0", Offset = "0x733DE0")] IList<DMEMIDHJMNL> ALGMCBHPBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6888840", Offset = "0x6887840", VA = "0x186888840")]
	public DMEMIDHJMNL HEEGAIPPEGC(OGGFLAIGBFD DNANLOGINGF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class LGLDJPMPDOJ : DNODMFKDHPD, BOPPBNHNKLD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class ABBJGMKHEDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public FAEMMOOFBCC newRole;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public ABBJGMKHEDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6883BE0", Offset = "0x6882BE0", VA = "0x186883BE0")]
		internal bool CKGGIECOMGN(FAEMMOOFBCC rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class PFKCOICOBIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public PMFLBIIBDDN roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public PFKCOICOBIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6890C00", Offset = "0x688FC00", VA = "0x186890C00")]
		internal bool HFCFMIJKJAB(PMFLBIIBDDN r)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class DFFHKEFGFMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public HJBOCBIPMIO roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public LGLDJPMPDOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private bool <isOffline>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private HEOLLBHFOHG <tokenAndPermissionsDto>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private bool <hasRoomRoles>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private HEOLLBHFOHG <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private bool <serverHasPermissions>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x734F70", Offset = "0x734370")]
		private TaskAwaiter<HEOLLBHFOHG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public DFFHKEFGFMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6885570", Offset = "0x6884570", VA = "0x186885570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class EEGAEOHFDPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public EEGAEOHFDPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x68862D0", Offset = "0x68852D0", VA = "0x1868862D0")]
		internal void LPGJCMBNGIJ(CGDBCAHMFOD r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x68861A0", Offset = "0x68851A0", VA = "0x1868861A0")]
		internal void FJLMKHCBGJL(CGDBCAHMFOD r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct DIDEEGNOCHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public HJBOCBIPMIO roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class EOMMCIHCKDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x734FD0", Offset = "0x7343D0")]
		public Func<CGDBCAHMFOD, MNLBLHLKIEH> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public EOMMCIHCKDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x68864B0", Offset = "0x68854B0", VA = "0x1868864B0")]
		internal void KCNFLLDEFBA(CGDBCAHMFOD r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6886440", Offset = "0x6885440", VA = "0x186886440")]
		internal void CAELOFGGNFM(CGDBCAHMFOD r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x68863D0", Offset = "0x68853D0", VA = "0x1868863D0")]
		internal void AOEPMAAJKFP(CGDBCAHMFOD r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class CHJMDLNCPAD<T> where T : notnull
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
			public CHJMDLNCPAD<T> <>4__this;

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
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x735090", Offset = "0x734490")]
			private TaskAwaiter<HEOLLBHFOHG> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
			public <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x1A4AF10", Offset = "0x1A49F10", VA = "0x181A4AF10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public LGLDJPMPDOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public OGGFLAIGBFD rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public PMFLBIIBDDN accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public AEDDMJADPFC recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public string serializedNewValue;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public CHJMDLNCPAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2179070", Offset = "0x2178070", VA = "0x182179070")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(CHJMDLNCPAD<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void FAAOIHPPFNL()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct CKHCCPKIGEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public IReadOnlyList<FIBMBKLGHAN> newPermissionOverrides;
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class BPFBGHIJAKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public HAHHKHNHGPG rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public HJBOCBIPMIO roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7350F0", Offset = "0x7344F0")]
		public IReadOnlyDictionary<PMFLBIIBDDN, FAEMMOOFBCC> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public IJBPODBAIMC debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private StringBuilder <migrationLogBuilder>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x735150", Offset = "0x734550")]
		private List<FIBMBKLGHAN> <permissionsChangeBatch>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private IEnumerator<CGDBCAHMFOD> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private CGDBCAHMFOD <roleData>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private PMFLBIIBDDN <roleAccountType>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private FAEMMOOFBCC <role>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private IReadOnlyList<OGGFLAIGBFD> <modifiedPermissions>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private IEnumerator<OGGFLAIGBFD> <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private OGGFLAIGBFD <permission>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private AEDDMJADPFC <recNetPermissionType>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7351B0", Offset = "0x7345B0")]
		private (bool Overrides, string SerializedValue) <serializedData>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public BPFBGHIJAKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6883C10", Offset = "0x6882C10", VA = "0x186883C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly HAHHKHNHGPG NOPALBLKALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly COEFDCBJJIH DLGOHANFIIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly IJBPODBAIMC IHDCNLLNNBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly Dictionary<int, FAEMMOOFBCC> DCJGLOIBMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal readonly Dictionary<PMFLBIIBDDN, FAEMMOOFBCC> MLACBBMNLBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal readonly Dictionary<PMFLBIIBDDN, FAEMMOOFBCC> KGOGGGGKOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal readonly List<FAEMMOOFBCC> EMNAJLPDDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool GMJEEAKHBLB;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly OGGFLAIGBFD[] IILODNDBPPB;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public MOHDNPIGBJA GFHBOIKEHAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public IEnumerable<NKKBLOADMCF> IMNGAABGJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x688D3D0", Offset = "0x688C3D0", VA = "0x18688D3D0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event LOIPCHBBGOG LILIFDEIDKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x688E080", Offset = "0x688D080", VA = "0x18688E080", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x688F430", Offset = "0x688E430", VA = "0x18688F430", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x688CCD0", Offset = "0x688BCD0", VA = "0x18688CCD0")]
	[OHDKPIIHCBL(OMGGGJAFEOF.Room, BGEACDHIFOF.None)]
	private static void ELLMEMEMKGP(ECDJHHJLGGB GGKDJNHCHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6890540", Offset = "0x688F540", VA = "0x186890540")]
	[UnityEngine.Scripting.Preserve]
	internal LGLDJPMPDOJ([KMDNJCFAMOJ(null)] HAHHKHNHGPG DHKILPGOGEL, [KMDNJCFAMOJ(null)] COEFDCBJJIH HJPPEFGJJFD, [KMDNJCFAMOJ(null)] IJBPODBAIMC IHDCNLLNNBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x688BF30", Offset = "0x688AF30", VA = "0x18688BF30", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x688C4E0", Offset = "0x688B4E0", VA = "0x18688C4E0")]
	private void ELIMMNBPBLD(IEnumerable<FAEMMOOFBCC> NEBKDLDOGOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x688B070", Offset = "0x688A070", VA = "0x18688B070", Slot = "12")]
	public bool AGBGDMFHINJ(JMNGDDABPMO ECKCAFOFCOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x688B760", Offset = "0x688A760", VA = "0x18688B760")]
	private void BKAEHNCLKNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x688F2B0", Offset = "0x688E2B0", VA = "0x18688F2B0")]
	private void MHKCMBOLFKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x688B770", Offset = "0x688A770", VA = "0x18688B770", Slot = "10")]
	public IReadOnlyList<NKKBLOADMCF> CCGFJPHJFDP(bool GOKIGPEMAEN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x688D160", Offset = "0x688C160", VA = "0x18688D160", Slot = "11")]
	public NKKBLOADMCF FPBKMGEBOCA(JMNGDDABPMO ECKCAFOFCOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x688F4D0", Offset = "0x688E4D0", VA = "0x18688F4D0")]
	private PMFLBIIBDDN NHPCKKMKPOO(JMNGDDABPMO ECKCAFOFCOA)
	{
		return default(PMFLBIIBDDN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x688D420", Offset = "0x688C420", VA = "0x18688D420", Slot = "14")]
	public bool GPKJDPJJHIN(JMNGDDABPMO JOGLAMJMONM, PMFLBIIBDDN GBMOIGBGEMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x688DCA0", Offset = "0x688CCA0", VA = "0x18688DCA0", Slot = "15")]
	public NKKBLOADMCF JPNKFJHIELN(PMFLBIIBDDN GBMOIGBGEMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x688F910", Offset = "0x688E910", VA = "0x18688F910")]
	private static bool OHGLOGBBGMA(HBCCJJNEOJG DLPEBNAJOHM, PMFLBIIBDDN GBMOIGBGEMP, out CGDBCAHMFOD? FAOIEOHANBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x688FD00", Offset = "0x688ED00", VA = "0x18688FD00")]
	private static void ONFIDKKHMGB(HBCCJJNEOJG DLPEBNAJOHM, Action<CGDBCAHMFOD> NELIJJDCMJI, PMFLBIIBDDN OOENLNDFDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x688FE00", Offset = "0x688EE00", VA = "0x18688FE00")]
	private static void ONFIDKKHMGB(HBCCJJNEOJG DLPEBNAJOHM, Action<CGDBCAHMFOD> NELIJJDCMJI, Predicate<PMFLBIIBDDN> NHFILMMMHNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6890000", Offset = "0x688F000", VA = "0x186890000")]
	private void PKDCOJKJOLG(JMNGDDABPMO ECKCAFOFCOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x688AF00", Offset = "0x6889F00", VA = "0x18688AF00", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DFFHKEFGFMF))]
	public Task AFLCKHAKGBG([CanBeNull] HJBOCBIPMIO EICHFPBIJBD, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
	public void JLHDCPJIKCE(ref HJBOCBIPMIO EICHFPBIJBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x688F030", Offset = "0x688E030", VA = "0x18688F030")]
	private void MGIGKKPMHGI(HBCCJJNEOJG BAGELLHABKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x688D980", Offset = "0x688C980", VA = "0x18688D980")]
	internal static string JBCPNNCELKN(HAHHKHNHGPG NOPALBLKALN, HJBOCBIPMIO EICHFPBIJBD, IReadOnlyDictionary<PMFLBIIBDDN, FAEMMOOFBCC> MLACBBMNLBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x688E120", Offset = "0x688D120", VA = "0x18688E120")]
	private static void MCLECFHHMAN(HJBOCBIPMIO EICHFPBIJBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6890060", Offset = "0x688F060", VA = "0x186890060")]
	private static void PMHGIJFJJBJ(HBCCJJNEOJG FCGHGAPEIFG, IReadOnlyDictionary<PMFLBIIBDDN, FAEMMOOFBCC> MLACBBMNLBI, StringBuilder GFOKMCFBNGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x688D270", Offset = "0x688C270", VA = "0x18688D270")]
	private static bool GCFNCGDLNOC(string JBDBIHEPANF, out Guid DKPKJICMDLG, out PMFLBIIBDDN GBMOIGBGEMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x688B140", Offset = "0x688A140", VA = "0x18688B140")]
	private static void AIDNGCIDOCJ(HJBOCBIPMIO EICHFPBIJBD, StringBuilder GFOKMCFBNGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2354710", Offset = "0x2353710", VA = "0x182354710", Slot = "16")]
	public bool GPIIDGOGNIP<T>(PMFLBIIBDDN GBMOIGBGEMP, OGGFLAIGBFD DNANLOGINGF, bool CNBBOOMAPFF, T HKOOLAFMDPF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x688D5B0", Offset = "0x688C5B0", VA = "0x18688D5B0")]
	private void HELHAKJOHEC(PMFLBIIBDDN GBMOIGBGEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x688C4C0", Offset = "0x688B4C0", VA = "0x18688C4C0")]
	private bool EKHOKNACGJO(JMNGDDABPMO ECKCAFOFCOA, PMFLBIIBDDN GBMOIGBGEMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x688DD60", Offset = "0x688CD60", VA = "0x18688DD60")]
	internal FAEMMOOFBCC LABBFMEEGGN(JMNGDDABPMO ECKCAFOFCOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x688DD50", Offset = "0x688CD50", VA = "0x18688DD50", Slot = "13")]
	public IReadOnlyList<NKKBLOADMCF> KEFNOEECJHD(JMNGDDABPMO ECKCAFOFCOA, bool IPHKJCPNLJL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x688D760", Offset = "0x688C760", VA = "0x18688D760")]
	internal IReadOnlyList<FAEMMOOFBCC> INDCFFMCIGO(JMNGDDABPMO ECKCAFOFCOA, bool IPHKJCPNLJL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x688B7F0", Offset = "0x688A7F0", VA = "0x18688B7F0")]
	private void DFIOBNNPOPB(HEOLLBHFOHG HAJKBOGPAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x688CE80", Offset = "0x688BE80", VA = "0x18688CE80")]
	private static bool FEALIDGMFJL(FAEMMOOFBCC LHAABEFKPHG, IReadOnlyDictionary<PMFLBIIBDDN, FAEMMOOFBCC> MLACBBMNLBI, out IReadOnlyList<OGGFLAIGBFD> DDAJADMFDED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x688C040", Offset = "0x688B040", VA = "0x18688C040")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BPFBGHIJAKB))]
	private static Task EGMJBBLFAOK(HAHHKHNHGPG NOPALBLKALN, HJBOCBIPMIO EICHFPBIJBD, IReadOnlyDictionary<PMFLBIIBDDN, FAEMMOOFBCC> MLACBBMNLBI, IJBPODBAIMC IHDCNLLNNBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x688C1E0", Offset = "0x688B1E0", VA = "0x18688C1E0")]
	[CompilerGenerated]
	internal static void EIEGGLDPKMH(Func<CGDBCAHMFOD, MNLBLHLKIEH> AACCGACJMKD, ref DIDEEGNOCHF P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x688F590", Offset = "0x688E590", VA = "0x18688F590")]
	[CompilerGenerated]
	internal static bool ODKLPAPODDG(PMFLBIIBDDN GBMOIGBGEMP, OGGFLAIGBFD DNANLOGINGF, out FIBMBKLGHAN LDOJFCAHPMF, ref CKHCCPKIGEK P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public enum OGGFLAIGBFD
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
internal class KKOLMDNHEHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly Dictionary<OGGFLAIGBFD, bool> NPANOADMGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly Dictionary<OGGFLAIGBFD, CFGEPOAOMGN> IJIJHKMFBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly FECFNBDHOAE OJJGIEDHANC;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x688ACB0", Offset = "0x6889CB0", VA = "0x18688ACB0")]
	public KKOLMDNHEHL(FECFNBDHOAE OJJGIEDHANC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x688AA70", Offset = "0x6889A70", VA = "0x18688AA70")]
	public bool GJDOIPKNLBI(OGGFLAIGBFD DNANLOGINGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x234DB30", Offset = "0x234CB30", VA = "0x18234DB30")]
	public bool GNHPFEFPENF<T>(OGGFLAIGBFD DNANLOGINGF, bool CNBBOOMAPFF, T CKMKMNKGMMC) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x234DE40", Offset = "0x234CE40", VA = "0x18234DE40")]
	public (bool, T?) LFDKGGPCGMK<T>(OGGFLAIGBFD DNANLOGINGF) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x688AAE0", Offset = "0x6889AE0", VA = "0x18688AAE0")]
	public bool GNHPFEFPENF(OGGFLAIGBFD DNANLOGINGF, bool CNBBOOMAPFF, object CKMKMNKGMMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x688ABC0", Offset = "0x6889BC0", VA = "0x18688ABC0")]
	public (bool, object) LFDKGGPCGMK(OGGFLAIGBFD DNANLOGINGF)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x234D880", Offset = "0x234C880", VA = "0x18234D880")]
	private void GACNNAPICCC<T>(OGGFLAIGBFD DNANLOGINGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x688A830", Offset = "0x6889830", VA = "0x18688A830")]
	private CFGEPOAOMGN CJHLIPFBDCM(OGGFLAIGBFD DNANLOGINGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x688A8F0", Offset = "0x68898F0", VA = "0x18688A8F0")]
	public void DMLAEHAJJHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface MOHDNPIGBJA
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	NKKBLOADMCF DAFCNEFHEBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal class COEFDCBJJIH : MOHDNPIGBJA
{
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public static COEFDCBJJIH EAMFFGGPIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	internal readonly FAEMMOOFBCC ECMAIBOILME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	internal readonly IReadOnlyList<FAEMMOOFBCC> JHGDNKHDPPL;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public NKKBLOADMCF DAFCNEFHEBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x83A5D0", Offset = "0x8395D0", VA = "0x18083A5D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6885070", Offset = "0x6884070", VA = "0x186885070")]
	public COEFDCBJJIH(FAEMMOOFBCC CAGFJAACJOI, IReadOnlyList<FAEMMOOFBCC> MIFIDJAIMCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6884850", Offset = "0x6883850", VA = "0x186884850")]
	private static COEFDCBJJIH EEGLAIEKFOI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public enum LIBNDHNFCNE
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
