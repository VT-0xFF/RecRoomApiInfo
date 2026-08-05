using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class JMDBFPJOAEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly CIIENGMCOIA EKNDIBHKHBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly long CBILAPKHPBD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int ECLLIGMNPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6239A50", Offset = "0x6238850", VA = "0x186239A50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6239A60", Offset = "0x6238860", VA = "0x186239A60")]
	public JMDBFPJOAEO(CIIENGMCOIA EKOLPKLNMBD, long HLFCMANHPKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface LJKECMFCCLH
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ECJBBEDPNJE PAOOMGGHJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	HEBNGJMIMPC<ANJLHBEBNAP> GJELKDAGKLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	HEBNGJMIMPC<Guid> NENGECALLMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	GNIKJMLLIOJ<NKEGLODILFL, int> FPJOKFHDKEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<IHFDHMKEEAA<ANJLHBEBNAP, string>> JNJGELOHPEG(long NGLNDFKLBFL, string ONIBECKLJDD, string IDLENODONKC, string LBFFNAIKGKH, FDINFEHGJNF EKODFEEOAPM);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<IHFDHMKEEAA<ANJLHBEBNAP, string>> CCBEECHJCEI(Guid FGHLIKAIAHK, [Optional] string ONIBECKLJDD, [Optional] string IDLENODONKC, [Optional] string LBFFNAIKGKH, [Optional] FDINFEHGJNF EKODFEEOAPM);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<IHFDHMKEEAA<bool, string>> KPHHENDDHAN(Guid FGHLIKAIAHK);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IReadOnlyList<ANJLHBEBNAP> EMNKIOJNFLH();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	IReadOnlyList<ANJLHBEBNAP> KMKHFDIMPMM();

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool LPGCEGBJNDK(Guid FGHLIKAIAHK, [Out] ANJLHBEBNAP NNALOLAFKDH);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool JMOPABDFMGI(Guid FGHLIKAIAHK, [Out] NKEGLODILFL CEDNFCCNGMA);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<int> AMOJCFLFLBI(GHMIEPPMENM NJAIFLCCJMF, Guid FGHLIKAIAHK);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<JMDBFPJOAEO> KPEJDNMOMBH(GHMIEPPMENM NJAIFLCCJMF, Guid FGHLIKAIAHK, int JPCCGPIEECF);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	string IKICJLNFOGH(CIIENGMCOIA EKOLPKLNMBD);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool NGOJOKJEHMN();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class NKEGLODILFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly Guid DIOJPKFEFKD;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long CBILAPKHPBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6239B60", Offset = "0x6238960", VA = "0x186239B60")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int ECLLIGMNPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6239D40", Offset = "0x6238B40", VA = "0x186239D40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long OJCBJMIDPNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x765900", Offset = "0x764700", VA = "0x180765900")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x76B120", Offset = "0x769F20", VA = "0x18076B120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long LMIPJFIJGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x768560", Offset = "0x767360", VA = "0x180768560")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7685B0", Offset = "0x7673B0", VA = "0x1807685B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Guid? LGFDJPMCEFK
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7615F0", Offset = "0x7603F0", VA = "0x1807615F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x761650", Offset = "0x760450", VA = "0x180761650")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool IPEKPBNBHFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xEF72A0", Offset = "0xEF60A0", VA = "0x180EF72A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x18817C0", Offset = "0x18805C0", VA = "0x1818817C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6239D60", Offset = "0x6238B60", VA = "0x186239D60")]
	public NKEGLODILFL(KOOFIAPKFBD CMPFHPLBGIA, bool KNGGPNFBNLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1C08190", Offset = "0x1C06F90", VA = "0x181C08190")]
	public NKEGLODILFL(Guid FGHLIKAIAHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6239B70", Offset = "0x6238970", VA = "0x186239B70")]
	public bool PFMOOMMEHLD(KOOFIAPKFBD CMPFHPLBGIA, Action<NKEGLODILFL, int> KAJPDMPLOMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6239B00", Offset = "0x6238900", VA = "0x186239B00")]
	public void IHIPDMKKALC(long MMBAOPOPANJ, Action<NKEGLODILFL, int> KAJPDMPLOMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ANJLHBEBNAP
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public const int FCKAPAHJBFB = 3;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public const int DFNAHBNEOFN = 25;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public const int PLNAKMEJDHH = 180;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public const int CPBLGMKBFGE = 1000;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Guid DIOJPKFEFKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA8D850", Offset = "0xA8C650", VA = "0x180A8D850")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1A730E0", Offset = "0x1A71EE0", VA = "0x181A730E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	internal long DLEPBJODBFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xD5FD40", Offset = "0xD5EB40", VA = "0x180D5FD40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public string KKCKMDALLNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x768580", Offset = "0x767380", VA = "0x180768580")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x768590", Offset = "0x767390", VA = "0x180768590")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string OHJMGNDHNOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x765900", Offset = "0x764700", VA = "0x180765900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7658F0", Offset = "0x7646F0", VA = "0x1807658F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string AAEIDGHDBEI
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x768560", Offset = "0x767360", VA = "0x180768560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x76B130", Offset = "0x769F30", VA = "0x18076B130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	internal DateTime LDMFDOLBHBA
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x18190A0", Offset = "0x1817EA0", VA = "0x1818190A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public DateTime HIEJDHOLMKP
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x76B160", Offset = "0x769F60", VA = "0x18076B160")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x185CC30", Offset = "0x185BA30", VA = "0x18185CC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public FDINFEHGJNF OOKPONCCHOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x764C40", Offset = "0x763A40", VA = "0x180764C40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x764C30", Offset = "0x763A30", VA = "0x180764C30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x62393D0", Offset = "0x62381D0", VA = "0x1862393D0")]
	public ANJLHBEBNAP(JGCFDBEHLOA CMPFHPLBGIA, [Optional] FDINFEHGJNF EKODFEEOAPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class CHBDFCHKMID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NKEGLODILFL CEDNFCCNGMA;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ANJLHBEBNAP PLJHKPFFDEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x763960", Offset = "0x762760", VA = "0x180763960")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public NKEGLODILFL LOBFGILHKFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x62394F0", Offset = "0x62382F0", VA = "0x1862394F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x761630", Offset = "0x760430", VA = "0x180761630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6239580", Offset = "0x6238380", VA = "0x186239580")]
	public CHBDFCHKMID(ANJLHBEBNAP NNALOLAFKDH, [Optional] NKEGLODILFL CEDNFCCNGMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class FDINFEHGJNF : IEquatable<FDINFEHGJNF>
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private const int JHMLHBCNAID = 1;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static FDINFEHGJNF BKEFLEENBBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x62398D0", Offset = "0x62386D0", VA = "0x1862398D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	internal int MMJFKHJNAML
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x761180", Offset = "0x75FF80", VA = "0x180761180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x761610", Offset = "0x760410", VA = "0x180761610")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool ONBPFIDBJGI
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x843190", Offset = "0x841F90", VA = "0x180843190")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x843180", Offset = "0x841F80", VA = "0x180843180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6239920", Offset = "0x6238720", VA = "0x186239920", Slot = "4")]
	public bool Equals(FDINFEHGJNF MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6239950", Offset = "0x6238750", VA = "0x186239950")]
	public static FDINFEHGJNF OCBHPPKFFKB(FDINFEHGJNF EKODFEEOAPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x18DF9C0", Offset = "0x18DE7C0", VA = "0x1818DF9C0")]
	public FDINFEHGJNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal static class KPIOGGELOEG
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6239AA0", Offset = "0x62388A0", VA = "0x186239AA0")]
	public static int BAOEOILDEJI(long OFHIAMAIFEJ)
	{
		return default(int);
	}
}
namespace Cpp2IlInjected;

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
