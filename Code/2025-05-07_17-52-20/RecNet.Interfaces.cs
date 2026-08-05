using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7198A40", Offset = "0x7197A40", VA = "0x187198A40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA1B220", Offset = "0xA1A220", VA = "0x180A1B220")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA1B260", Offset = "0xA1A260", VA = "0x180A1B260")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface PGNAHLEOJHC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	string OHDIDODLMDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string IBFJODFHPGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface PFJBEGCDCID
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CJHPANODDAM();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<JNFBFBMIKLM> FCACJHFFLPE([Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<PGNAHLEOJHC> HHLLGFHLGBG(string NPLGNNPICKO, string LFLBLDPJMBC, string JJHBEMCOPJF, string? CJGPEFPOBBJ, float HNBENKBGPAC, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<JNFBFBMIKLM> JNKLGCMHJEE(long CFBANPJJEAK, decimal LFFLFPPOBFA, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task JKBNKKGFGAG(string PNBLCEBBDDJ, string CAGGFIHFLKF, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task DLHAFBEHLBO(long KFBNLDNKNID, string CAGGFIHFLKF, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<string> LDPDCMGHLPB(long KFBNLDNKNID, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<string> CENDBIMILIB(string NPLGNNPICKO, string HIFFKLNHIEF, [Optional] string? CFNMLMNHCMF, [Optional] string? PBOJKGAIIPK, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<GIOJGGIGFKG?>? DPAFLPPGAMP(string HIFFKLNHIEF, [Optional] ONOOOJEFPBH? JMAOGCEDADG, [Optional] string? KLGLENDFPGC, [Optional] string? LFLBLDPJMBC, [Optional] string? DPDEBNILFJJ, [Optional] string? NPLGNNPICKO, [Optional] bool? LOBPONCMADD, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<GIOJGGIGFKG> FAKOHOABPJF(string DAOAPLFBLDC, [Optional] ONOOOJEFPBH? JMAOGCEDADG, [Optional] string? DPDEBNILFJJ, [Optional] CancellationToken CBJPDIFOEKF);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class JKCKIBDLOBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private string JMFFIFHDJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private string CMCLMJAIBIM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public string ILNNINHEHDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public string EGBOFAHGAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9F5A20", Offset = "0x9F4A20", VA = "0x1809F5A20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string AAJKGFBPKDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F22B0", VA = "0x1809F32B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public string GEHGGOLACCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9F1780", Offset = "0x9F0780", VA = "0x1809F1780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int? HEFNBFIDINI
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9F6810", Offset = "0x9F5810", VA = "0x1809F6810")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int? IABOMJEHJOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9F17A0", Offset = "0x9F07A0", VA = "0x1809F17A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x71959C0", Offset = "0x71949C0", VA = "0x1871959C0")]
	public JKCKIBDLOBO(string JGMFGDGALBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7195990", Offset = "0x7194990", VA = "0x187195990")]
	public void HIDIHJMCHCH(string AJJLFHDFEEI = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7195890", Offset = "0x7194890", VA = "0x187195890")]
	private void GGNIMFIJHPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface JDEEEMCCBGE
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	HGAOMCLAJHP FGBMLAMOLHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<PHGAFJJAAOB> MMBEBCDKPPF;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<GAJFFPKLOEG> CHABPKINKDK;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<GAJFFPKLOEG> MKCFBCFHFOM(bool LJLJHJONNNE = false, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CAGOJCFILKC([Out] GAJFFPKLOEG BJLJHPBLMED);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class AOAIKNNCLMM
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x718FC40", Offset = "0x718EC40", VA = "0x18718FC40")]
	public static bool MFPONPFNCND(this JDEEEMCCBGE DCGILIKEFGE, [Out] PHGAFJJAAOB FPAJFCJDKLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x718FD20", Offset = "0x718ED20", VA = "0x18718FD20")]
	public static bool NNPDFMOFLAN(this JDEEEMCCBGE DCGILIKEFGE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct BEJKEHBAEFJ : IEquatable<BEJKEHBAEFJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool LHPCJNJIGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly DateTime IBDEHGDKNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly bool FEJEMBMGEGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly KBKDLGNDCGI? KLOGBIFGMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly string PBCJMOLFCCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly int? ICLPLFHLAFD;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public static BEJKEHBAEFJ JAJLEBKKLPI
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2730EF0", Offset = "0x272FEF0", VA = "0x182730EF0")]
		get
		{
			return default(BEJKEHBAEFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7190800", Offset = "0x718F800", VA = "0x187190800")]
	public BEJKEHBAEFJ(DateTime GNOINOIKIEA, bool PLPPEJDLOOJ, KBKDLGNDCGI? ONFAIAACMCL, string GLJFPJNEONO, int? OFMBJGJIHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7190670", Offset = "0x718F670", VA = "0x187190670")]
	public PHGAFJJAAOB KOPBPDOIIOH(HGAOMCLAJHP POFHCGLLAAJ)
	{
		return default(PHGAFJJAAOB);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x71905F0", Offset = "0x718F5F0", VA = "0x1871905F0")]
	private static PHGAFJJAAOB ICMCNCLDKAN(HGAOMCLAJHP POFHCGLLAAJ, DateTime GNOINOIKIEA)
	{
		return default(PHGAFJJAAOB);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7190330", Offset = "0x718F330", VA = "0x187190330", Slot = "4")]
	public bool Equals(BEJKEHBAEFJ MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7190490", Offset = "0x718F490", VA = "0x187190490", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7190540", Offset = "0x718F540", VA = "0x187190540", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7190700", Offset = "0x718F700", VA = "0x187190700")]
	public static bool MMJMCICIDNJ(BEJKEHBAEFJ JOOBCOFNIAM, BEJKEHBAEFJ MCIIEEEAOOL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x71902F0", Offset = "0x718F2F0", VA = "0x1871902F0")]
	public static bool DIKHMNDIIDO(BEJKEHBAEFJ JOOBCOFNIAM, BEJKEHBAEFJ MCIIEEEAOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7190730", Offset = "0x718F730", VA = "0x187190730", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct GAJFFPKLOEG : IEquatable<GAJFFPKLOEG>
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly GAJFFPKLOEG JAJLEBKKLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly bool LKIDIFGHMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly PHGAFJJAAOB LIAKGICCCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly BEJKEHBAEFJ OHIGKJNOOCJ;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x71936D0", Offset = "0x71926D0", VA = "0x1871936D0")]
	public GAJFFPKLOEG(PHGAFJJAAOB FPAJFCJDKLL, BEJKEHBAEFJ DDFGJMJMGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7193230", Offset = "0x7192230", VA = "0x187193230", Slot = "4")]
	public bool Equals(GAJFFPKLOEG MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x71932E0", Offset = "0x71922E0", VA = "0x1871932E0", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7193410", Offset = "0x7192410", VA = "0x187193410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x71934D0", Offset = "0x71924D0", VA = "0x1871934D0")]
	public static bool MMJMCICIDNJ(GAJFFPKLOEG JOOBCOFNIAM, GAJFFPKLOEG MCIIEEEAOOL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7193110", Offset = "0x7192110", VA = "0x187193110")]
	public static bool DIKHMNDIIDO(GAJFFPKLOEG JOOBCOFNIAM, GAJFFPKLOEG MCIIEEEAOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x71935E0", Offset = "0x71925E0", VA = "0x1871935E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum PHGAFJJAAOB : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Expired,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	Active
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class IFNLPLPFJEE : HGAOMCLAJHP
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public const string JNDMLDCDAKC = "ServerTime";

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static readonly Stopwatch FBAMPJKHFHJ;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static DateTimeOffset? IILICNCIJBP;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static readonly IFNLPLPFJEE ELJDCHFNJGK;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static HGAOMCLAJHP MLIJHBGBMKP
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7194E20", Offset = "0x7193E20", VA = "0x187194E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	internal static IFNLPLPFJEE JBAJDODDAOL
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7194E70", Offset = "0x7193E70", VA = "0x187194E70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static DateTimeOffset DKGBKFFBNGE
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7194EC0", Offset = "0x7193EC0", VA = "0x187194EC0")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static DateTime LJPOEDLDEHE
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7195020", Offset = "0x7194020", VA = "0x187195020")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public DateTime JDNILLIMBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x71950B0", Offset = "0x71940B0", VA = "0x1871950B0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DateTimeOffset IGHAHCNICPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7194DC0", Offset = "0x7193DC0", VA = "0x187194DC0", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	private IFNLPLPFJEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7194BA0", Offset = "0x7193BA0", VA = "0x187194BA0")]
	internal static void ALLBAHHKPDK(DateTime? LHMGHABDEKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum DGMMFMEHEGC
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Front,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Back
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public enum LDCHEJDAADP
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	AnimatedPuppet,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Imposter
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[KGJMAOFDNAE]
public class EHGDCJFOLHP : NEKJHAOPALN, FBAKIBIPOMC, MHLEMOAMOMP, HADCGNIOBLA, MBIJMOAAOBD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct IMLBOLJKMOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public EHGDCJFOLHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7195260", Offset = "0x7194260", VA = "0x187195260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7195610", Offset = "0x7194610", VA = "0x187195610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[IgnoreDataMember]
	public static ILOOKKAOHHD CBANHHDKBKB;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid BJLCIJDDMDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xF79DC0", Offset = "0xF78DC0", VA = "0x180F79DC0", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xF79DB0", Offset = "0xF78DB0", VA = "0x180F79DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int GNFOCGLAMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xBEA640", Offset = "0xBE9640", VA = "0x180BEA640", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xC64F60", Offset = "0xC63F60", VA = "0x180C64F60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550", Slot = "40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9F5A20", Offset = "0x9F4A20", VA = "0x1809F5A20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string BPBACGJDGJI
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F22B0", VA = "0x1809F32B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int DFMBJPCDEPP
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA0E750", Offset = "0xA0D750", VA = "0x180A0E750", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xD4F350", Offset = "0xD4E350", VA = "0x180D4F350")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public GGBJCIFEEKL PEDJKOGJKLO
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA0E760", Offset = "0xA0D760", VA = "0x180A0E760", Slot = "44")]
		[CompilerGenerated]
		get
		{
			return default(GGBJCIFEEKL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1467920", Offset = "0x1466920", VA = "0x181467920")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool CLMMDKBAGFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xC11900", Offset = "0xC10900", VA = "0x180C11900", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xCDD520", Offset = "0xCDC520", VA = "0x180CDD520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool OCHOLGOLIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xD68530", Offset = "0xD67530", VA = "0x180D68530", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xD66DD0", Offset = "0xD65DD0", VA = "0x180D66DD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool PLKKACFMMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1E4B470", Offset = "0x1E4A470", VA = "0x181E4B470", Slot = "41")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x1E4A880", Offset = "0x1E49880", VA = "0x181E4A880")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int? DDIAOPDGHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7191ED0", Offset = "0x7190ED0", VA = "0x187191ED0", Slot = "43")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7191EC0", Offset = "0x7190EC0", VA = "0x187191EC0", Slot = "14")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public string OLCLBHJADBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9F4700", Offset = "0x9F3700", VA = "0x1809F4700", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9F46E0", Offset = "0x9F36E0", VA = "0x1809F46E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public string BBLNFMBBACJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9F4710", Offset = "0x9F3710", VA = "0x1809F4710", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9F46D0", Offset = "0x9F36D0", VA = "0x1809F46D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public string HJFBOJCGKGO
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9F46F0", Offset = "0x9F36F0", VA = "0x1809F46F0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9F46C0", Offset = "0x9F36C0", VA = "0x1809F46C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public DateTime HLEKPMBEFEF
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CF0", Offset = "0x9F3CF0", VA = "0x1809F4CF0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xE31080", Offset = "0xE30080", VA = "0x180E31080")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public DateTime GJGOMALEFKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CE0", Offset = "0x9F3CE0", VA = "0x1809F4CE0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xE31860", Offset = "0xE30860", VA = "0x180E31860")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public DGMMFMEHEGC DFFMIBCOMFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xD9BF60", Offset = "0xD9AF60", VA = "0x180D9BF60", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(DGMMFMEHEGC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xE836B0", Offset = "0xE826B0", VA = "0x180E836B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public string PLJJPGMKJBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9F90F0", Offset = "0x9F80F0", VA = "0x1809F90F0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9F9010", Offset = "0x9F8010", VA = "0x1809F9010")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int FCFODIKFBLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xC1B860", Offset = "0xC1A860", VA = "0x180C1B860", Slot = "42")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xC1BB60", Offset = "0xC1AB60", VA = "0x180C1BB60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public IReadOnlyList<LLNKGMGMKMM> LCNGDBOOPGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xBDE270", Offset = "0xBDD270", VA = "0x180BDE270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x12CD960", Offset = "0x12CC960", VA = "0x1812CD960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public IReadOnlyList<JOJMLIAFJPJ> KDDINMHENKB
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xBDE270", Offset = "0xBDD270", VA = "0x180BDE270", Slot = "37")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public PIGJKMDEGFL MFDGEHGDJNI
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9F9040", Offset = "0x9F8040", VA = "0x1809F9040")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9F9050", Offset = "0x9F8050", VA = "0x1809F9050")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public string HOFNFAEDOCK
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7191B60", Offset = "0x7190B60", VA = "0x187191B60", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public OILBOLBBFDD KPPMOCAOEMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xBDE1B0", Offset = "0xBDD1B0", VA = "0x180BDE1B0", Slot = "24")]
		get
		{
			return default(OILBOLBBFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string OJLJBFKDCDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7191B60", Offset = "0x7190B60", VA = "0x187191B60", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string HKGGJOPMJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool CKFBECEKPBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public NGFKJBKJKIN PKGBFGMFFCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xF63780", Offset = "0xF62780", VA = "0x180F63780", Slot = "30")]
		get
		{
			return default(NGFKJBKJKIN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string MCOPKJANMDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230", Slot = "31")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public DKDANGFCEKG? GOPBNIHHAJD
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7191D30", Offset = "0x7190D30", VA = "0x187191D30", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public APCAKCGDFCO MOLJGCJNBNH
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xBDE1B0", Offset = "0xBDD1B0", VA = "0x180BDE1B0", Slot = "33")]
		get
		{
			return default(APCAKCGDFCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool JKHBCDJKKDE
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public EHGDCJFOLHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xF59520", Offset = "0xF58520", VA = "0x180F59520")]
	public EHGDCJFOLHP([Optional] Guid DGPIPOJOJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7191B80", Offset = "0x7190B80", VA = "0x187191B80", Slot = "35")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7191DF0", Offset = "0x7190DF0", VA = "0x187191DF0", Slot = "36")]
	[AsyncStateMachine(typeof(IMLBOLJKMOA))]
	public Task PGKHKEHPKKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7191D80", Offset = "0x7190D80", VA = "0x187191D80")]
	public EHGDCJFOLHP JDEFNGBGNOL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[KGJMAOFDNAE]
public class JHLODMJOFDG : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public string BPBACGJDGJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int DFMBJPCDEPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xBEA640", Offset = "0xBE9640", VA = "0x180BEA640")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xC64F60", Offset = "0xC63F60", VA = "0x180C64F60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int? DDIAOPDGHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xEC4470", Offset = "0xEC3470", VA = "0x180EC4470")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xEC44A0", Offset = "0xEC34A0", VA = "0x180EC44A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public string OLCLBHJADBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F22B0", VA = "0x1809F32B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public GGBJCIFEEKL PEDJKOGJKLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xA0E750", Offset = "0xA0D750", VA = "0x180A0E750")]
		[CompilerGenerated]
		get
		{
			return default(GGBJCIFEEKL);
		}
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xD4F350", Offset = "0xD4E350", VA = "0x180D4F350")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public DGMMFMEHEGC? DFFMIBCOMFK
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xC8C940", Offset = "0xC8B940", VA = "0x180C8C940")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xC8C990", Offset = "0xC8B990", VA = "0x180C8C990")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public JHLODMJOFDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[KGJMAOFDNAE]
public class AFLEGFMKPCB : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int GNFOCGLAMGH
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D30", Offset = "0x9EFD30", VA = "0x1809F0D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int? DDIAOPDGHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xEC43D0", Offset = "0xEC33D0", VA = "0x180EC43D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xECD420", Offset = "0xECC420", VA = "0x180ECD420")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string BBLNFMBBACJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string OLCLBHJADBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9F5A20", Offset = "0x9F4A20", VA = "0x1809F5A20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public AFLEGFMKPCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[KGJMAOFDNAE]
public class FNLIDBHCCBL : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int? DDIAOPDGHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xCF3540", Offset = "0xCF2540", VA = "0x180CF3540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public string OLCLBHJADBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public FNLIDBHCCBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct MLIOIHJELNO
{
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static int BOKEFODAJKJ;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static int FBLKIDGDPGA;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int MBINPGNLKOD
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA3C5A0", Offset = "0xA3B5A0", VA = "0x180A3C5A0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x1292E00", Offset = "0x1291E00", VA = "0x181292E00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int NOHEMFCIIDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7197DC0", Offset = "0x7196DC0", VA = "0x187197DC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public static MLIOIHJELNO OPJKGEJPJBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7197D70", Offset = "0x7196D70", VA = "0x187197D70")]
		get
		{
			return default(MLIOIHJELNO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7197E60", Offset = "0x7196E60", VA = "0x187197E60")]
	public MLIOIHJELNO(int EIJIDJLAJNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[KGJMAOFDNAE]
public class IBNJPOOGIEA : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int PNCAEHGBKIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D30", Offset = "0x9EFD30", VA = "0x1809F0D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int? EIAEMBHMEEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xEC43D0", Offset = "0xEC33D0", VA = "0x180EC43D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xECD420", Offset = "0xECC420", VA = "0x180ECD420")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public string? LNILHMKIEOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7194AF0", Offset = "0x7193AF0", VA = "0x187194AF0")]
	public IBNJPOOGIEA(int GAFFJGMGEBD, int? DCIACCAIHKA, string? NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public IBNJPOOGIEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[KGJMAOFDNAE]
public class GJANAOLJBDF : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public FDJLKDLAMMF.IAAEJFMKBFM JOOIIHPJJDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(FDJLKDLAMMF.IAAEJFMKBFM);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D30", Offset = "0x9EFD30", VA = "0x1809F0D30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public string OPCCKLMJHCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int? JAAEHGFDDNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xC8C980", Offset = "0xC8B980", VA = "0x180C8C980")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public GJANAOLJBDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface JOJMLIAFJPJ
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	long NFJGMBPENOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	Guid BJLCIJDDMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	Guid KJPMNOCOJND
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	string MGDLKIILDLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	string AFMOJMFJELP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	int CGILOPKPFBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	string KNFFGMHAKBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	string LJMIGGGJMJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	string DKKKBPGIAHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	string IPLLECGCDBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	int FCFODIKFBLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[KGJMAOFDNAE]
public class LLNKGMGMKMM : JOJMLIAFJPJ, MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public long NFJGMBPENOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xCF3540", Offset = "0xCF2540", VA = "0x180CF3540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public Guid BJLCIJDDMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xBFFAA0", Offset = "0xBFEAA0", VA = "0x180BFFAA0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xDB9A10", Offset = "0xDB8A10", VA = "0x180DB9A10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public Guid KJPMNOCOJND
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x1286C40", Offset = "0x1285C40", VA = "0x181286C40", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x1286C30", Offset = "0x1285C30", VA = "0x181286C30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public DateTime HLEKPMBEFEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9F1780", Offset = "0x9F0780", VA = "0x1809F1780")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x9F6800", Offset = "0x9F5800", VA = "0x1809F6800")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public string MGDLKIILDLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9F6810", Offset = "0x9F5810", VA = "0x1809F6810", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x9F1580", Offset = "0x9F0580", VA = "0x1809F1580")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public string AFMOJMFJELP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9F17A0", Offset = "0x9F07A0", VA = "0x1809F17A0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9F1500", Offset = "0x9F0500", VA = "0x1809F1500")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public int CGILOPKPFBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xCFC9F0", Offset = "0xCFB9F0", VA = "0x180CFC9F0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xE5AE60", Offset = "0xE59E60", VA = "0x180E5AE60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public string KNFFGMHAKBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x9F4710", Offset = "0x9F3710", VA = "0x1809F4710", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9F46D0", Offset = "0x9F36D0", VA = "0x1809F46D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public string LJMIGGGJMJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9F46F0", Offset = "0x9F36F0", VA = "0x1809F46F0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9F46C0", Offset = "0x9F36C0", VA = "0x1809F46C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public string DKKKBPGIAHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CF0", Offset = "0x9F3CF0", VA = "0x1809F4CF0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CD0", Offset = "0x9F3CD0", VA = "0x1809F4CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public string IPLLECGCDBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CE0", Offset = "0x9F3CE0", VA = "0x1809F4CE0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CC0", Offset = "0x9F3CC0", VA = "0x1809F4CC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public int FCFODIKFBLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xD9BF60", Offset = "0xD9AF60", VA = "0x180D9BF60", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xE836B0", Offset = "0xE826B0", VA = "0x180E836B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "15")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public LLNKGMGMKMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[Flags]
public enum MMHDOGHDONC
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Shirt = 1,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	All = -1
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum HLIAJHAKCLG
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	SearchScoreDescending,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	HotScoreDescending,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	Newest,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	Oldest,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	PriceAscending,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	PriceDescending,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	FeaturedFirst
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class JDDPGEAAJDO
{
	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x71956F0", Offset = "0x71946F0", VA = "0x1871956F0")]
	public static int? FEFKHJNIFBA(MMHDOGHDONC? ANPMJHBKDCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7195780", Offset = "0x7194780", VA = "0x187195780")]
	public static int? JDIGBLOCCIC(HLIAJHAKCLG? JIGDGMFFPDF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[KGJMAOFDNAE]
public class PPIOEJJHFFG : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public string BPBACGJDGJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int? DFMBJPCDEPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xC8C980", Offset = "0xC8B980", VA = "0x180C8C980")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public GGBJCIFEEKL? PEDJKOGJKLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9F1790", Offset = "0x9F0790", VA = "0x1809F1790")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public PPIOEJJHFFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[KGJMAOFDNAE]
public class GIPABNFHILC : EGONCOPCFDP, MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Guid BJLCIJDDMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xF79DC0", Offset = "0xF78DC0", VA = "0x180F79DC0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xF79DB0", Offset = "0xF78DB0", VA = "0x180F79DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public byte IFCMMFOJBML
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9F1560", Offset = "0x9F0560", VA = "0x1809F1560")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9F1530", Offset = "0x9F0530", VA = "0x1809F1530")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public GIPABNFHILC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class PMPOENLHNPI
{
	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7199140", Offset = "0x7198140", VA = "0x187199140")]
	public static HIPIMHFHIGB CJNHOABNGJJ(this GIPABNFHILC OCACDKEJIIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface NEKJHAOPALN
{
	[Cpp2IlInjected.Token(Token = "0x17000063")]
	Guid BJLCIJDDMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	int GNFOCGLAMGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	string BPBACGJDGJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	int DFMBJPCDEPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	GGBJCIFEEKL PEDJKOGJKLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	bool CLMMDKBAGFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool OCHOLGOLIHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool PLKKACFMMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	int? DDIAOPDGHML
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	string OLCLBHJADBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	string BBLNFMBBACJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	string HJFBOJCGKGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	DateTime HLEKPMBEFEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	DateTime GJGOMALEFKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	DGMMFMEHEGC DFFMIBCOMFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	string PLJJPGMKJBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	int FCFODIKFBLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	string HOFNFAEDOCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x71982F0", Offset = "0x71972F0", VA = "0x1871982F0", Slot = "19")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface MBIJMOAAOBD
{
	[Cpp2IlInjected.Token(Token = "0x17000076")]
	IReadOnlyList<JOJMLIAFJPJ> KDDINMHENKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Guid BJLCIJDDMDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	int GNFOCGLAMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	bool PLKKACFMMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	int FCFODIKFBLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	int? DDIAOPDGHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	GGBJCIFEEKL PEDJKOGJKLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class DMJJPFNNOJB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct BFPNFCCADEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public IEnumerable<HADCGNIOBLA> list;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7190BC0", Offset = "0x718FBC0", VA = "0x187190BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7190E70", Offset = "0x718FE70", VA = "0x187190E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x71917C0", Offset = "0x71907C0", VA = "0x1871917C0")]
	public static bool IDOHCKEHAHL(this IEnumerable<MHLEMOAMOMP> OLEDHEBBJPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7191A00", Offset = "0x7190A00", VA = "0x187191A00")]
	[AsyncStateMachine(typeof(BFPNFCCADEE))]
	public static Task NAIKLHDMABG(this IEnumerable<HADCGNIOBLA> OLEDHEBBJPH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct NGHKAOKDFBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly string NGGJMDLHLLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly string CBNMGIONGIA;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public static readonly NGHKAOKDFBL APCCKFBGCNM;

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0xAAAD70", Offset = "0xAA9D70", VA = "0x180AAAD70")]
	public NGHKAOKDFBL(string PAONAEKBGCN, string CNOOJBJPLMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0xEE22A0", Offset = "0xEE12A0", VA = "0x180EE22A0")]
	public bool NJNJIHOCGFM(NGHKAOKDFBL MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7198430", Offset = "0x7197430", VA = "0x187198430", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7198510", Offset = "0x7197510", VA = "0x187198510", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7198580", Offset = "0x7197580", VA = "0x187198580")]
	public static bool MMJMCICIDNJ(NGHKAOKDFBL JOOBCOFNIAM, NGHKAOKDFBL MCIIEEEAOOL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x71983B0", Offset = "0x71973B0", VA = "0x1871983B0")]
	public static bool DIKHMNDIIDO(NGHKAOKDFBL JOOBCOFNIAM, NGHKAOKDFBL MCIIEEEAOOL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface FAIABEOMBBM
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	JKCKIBDLOBO IDOBOHLCCAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	string ADPLKAINAOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	string GMGIIIOBJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	long JNNBINDIFLP
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	string GOPHGEBAOKP
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	string JKIKGAPMPOF
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	string FPLINFGDKNP
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	string ALPGIIOOIAL
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[KGJMAOFDNAE]
public class AEKFKLABGJK : NMDCCOHFGKK
{
	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public string OPBIIMFNBAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public BNOGHPPINOH KGLBEKHHDLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xBEA640", Offset = "0xBE9640", VA = "0x180BEA640")]
		[CompilerGenerated]
		get
		{
			return default(BNOGHPPINOH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xC64F60", Offset = "0xC63F60", VA = "0x180C64F60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public GJADFEIIIAK DKAPNGMOKJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xCFC9B0", Offset = "0xCFB9B0", VA = "0x180CFC9B0")]
		[CompilerGenerated]
		get
		{
			return default(GJADFEIIIAK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xF0C6F0", Offset = "0xF0B6F0", VA = "0x180F0C6F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public CCGPKJHPLDM OMJAKKKOOBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x9F0C90", Offset = "0x9EFC90", VA = "0x1809F0C90")]
		[CompilerGenerated]
		get
		{
			return default(CCGPKJHPLDM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CE0", Offset = "0x9EFCE0", VA = "0x1809F0CE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	[DataMember(Name = "Header")]
	public string? CJHNOHPFJIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F22B0", VA = "0x1809F32B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public string? GDDJONJKHPG
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x9F1780", Offset = "0x9F0780", VA = "0x1809F1780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x9F1770", Offset = "0x9F0770", VA = "0x1809F1770")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public string? IOBNGFEIHAM
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x9F6810", Offset = "0x9F5810", VA = "0x1809F6810")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9F1580", Offset = "0x9F0580", VA = "0x1809F1580")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public List<string> JDFMABHAPJI
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9F17A0", Offset = "0x9F07A0", VA = "0x1809F17A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9F1500", Offset = "0x9F0500", VA = "0x1809F1500")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public List<ECCDOHOFADD> JGDFHHCGLLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x9F4700", Offset = "0x9F3700", VA = "0x1809F4700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x9F46E0", Offset = "0x9F36E0", VA = "0x1809F46E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x718F550", Offset = "0x718E550", VA = "0x18718F550", Slot = "5")]
	public override void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x718F560", Offset = "0x718E560", VA = "0x18718F560")]
	public AEKFKLABGJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum PGMIOGDDAOF
{
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	Url,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	AccountId,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	EventId,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	RoomName,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	Storefront,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	[Obsolete("6/4/21: This was only ever used for an announcement for Shawn's referral event, which is not happening again. Removing as part of a StackUI cleanup")]
	ActionCode,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	Item,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	CustomAvatarItem,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	AuthorizedRecNetUrl,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	Close
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public enum BNOGHPPINOH
{
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	Vertical,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	Horizontal
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum GJADFEIIIAK
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	Small,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	Medium,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	Large
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public enum CCGPKJHPLDM
{
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Before,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	Overlay,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	After
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[KGJMAOFDNAE]
public class ECCDOHOFADD : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public PGMIOGDDAOF EMDBDINAPON
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(PGMIOGDDAOF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D30", Offset = "0x9EFD30", VA = "0x1809F0D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public string? AFBELPHLHEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	[DataMember(Name = "LinkParameter")]
	public string? GPKCCOPICDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public string? FKMNPLIAMEB
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x9F5A20", Offset = "0x9F4A20", VA = "0x1809F5A20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public ECCDOHOFADD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public abstract class NMDCCOHFGKK : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000093")]
	[IgnoreDataMember]
	public string? MLOEKADOBPG
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void FOGENAANJJN();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x71989D0", Offset = "0x71979D0", VA = "0x1871989D0")]
	protected NMDCCOHFGKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[KGJMAOFDNAE]
public class PFDPJDEMONB : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public string? OOAAJPONLBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public PFDPJDEMONB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[KGJMAOFDNAE]
public class GKKPPPDDHFG : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	internal static Func<string, AEKFKLABGJK>? DLPGPNHOCOG;

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	internal static Func<string, LJKFOKNDHCE>? PGILNDIHIFD;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public string? OOAAJPONLBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public string? CCKJGJEPHFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool FCCADEJJPDD
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x9F1560", Offset = "0x9F0560", VA = "0x1809F1560")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x9F1530", Offset = "0x9F0530", VA = "0x1809F1530")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public KBKDLGNDCGI BPIJIKNKMOL
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0xCFC9B0", Offset = "0xCFB9B0", VA = "0x180CFC9B0")]
		[CompilerGenerated]
		get
		{
			return default(KBKDLGNDCGI);
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0xF0C6F0", Offset = "0xF0B6F0", VA = "0x180F0C6F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public FFEEJALAFLP HIJHOAMJFBB
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x9F0C90", Offset = "0x9EFC90", VA = "0x1809F0C90")]
		[CompilerGenerated]
		get
		{
			return default(FFEEJALAFLP);
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CE0", Offset = "0x9EFCE0", VA = "0x1809F0CE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public int MHNIDGOLKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xC63430", Offset = "0xC62430", VA = "0x180C63430")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x13A4DF0", Offset = "0x13A3DF0", VA = "0x1813A4DF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public DateTime PFNLONAOJAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9F1520", Offset = "0x9F0520", VA = "0x1809F1520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	[DataMember(Name = "IsRead")]
	internal bool JEKOCCGDAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0xD6F400", Offset = "0xD6E400", VA = "0x180D6F400")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xD6F420", Offset = "0xD6E420", VA = "0x180D6F420")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	[IgnoreDataMember]
	public bool NNMGBHEAMHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xD6F410", Offset = "0xD6E410", VA = "0x180D6F410")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xD6F430", Offset = "0xD6E430", VA = "0x180D6F430")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public NHAIEPOALMF JCJACEFDCOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0xA0E760", Offset = "0xA0D760", VA = "0x180A0E760")]
		[CompilerGenerated]
		get
		{
			return default(NHAIEPOALMF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x1467920", Offset = "0x1466920", VA = "0x181467920")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public MMLDAEHGKLI LDDBOPCAMLB
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA00120", Offset = "0x9FF120", VA = "0x180A00120")]
		[CompilerGenerated]
		get
		{
			return default(MMLDAEHGKLI);
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xE04AF0", Offset = "0xE03AF0", VA = "0x180E04AF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	internal string? KDFLLFPAOLO
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x9F17A0", Offset = "0x9F07A0", VA = "0x1809F17A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x9F1500", Offset = "0x9F0500", VA = "0x1809F1500")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	[IgnoreDataMember]
	public AEKFKLABGJK? DENFOHKNIPL
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7193AB0", Offset = "0x7192AB0", VA = "0x187193AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	[IgnoreDataMember]
	public LJKFOKNDHCE? OAOGOPJOGIL
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7193700", Offset = "0x7192700", VA = "0x187193700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	[IgnoreDataMember]
	public NMDCCOHFGKK? FGDGIGKOGPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x9F4700", Offset = "0x9F3700", VA = "0x1809F4700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x9F46E0", Offset = "0x9F36E0", VA = "0x1809F46E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7193780", Offset = "0x7192780", VA = "0x187193780", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0xA1B3F0", Offset = "0xA1A3F0", VA = "0x180A1B3F0")]
	public GKKPPPDDHFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[KGJMAOFDNAE]
public class IFLODLDHBJN : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public BGJDLGFHCCD FJCNBDPIEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(BGJDLGFHCCD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D30", Offset = "0x9EFD30", VA = "0x1809F0D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public string CLDLCAHHBMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public int BBALHJGNFKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xBEA640", Offset = "0xBE9640", VA = "0x180BEA640")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xC64F60", Offset = "0xC63F60", VA = "0x180C64F60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7194B50", Offset = "0x7193B50", VA = "0x187194B50")]
	public IFLODLDHBJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[KGJMAOFDNAE]
public class LJKFOKNDHCE : NMDCCOHFGKK
{
	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public string FPFIMAEMPOF
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public string? IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public KMOOOBCFFBE AGDACFKAIAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x9F0C90", Offset = "0x9EFC90", VA = "0x1809F0C90")]
		[CompilerGenerated]
		get
		{
			return default(KMOOOBCFFBE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CE0", Offset = "0x9EFCE0", VA = "0x1809F0CE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	[DataMember(Name = "all_conditions_required")]
	public bool MIEKHIKHLBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x15602D0", Offset = "0x155F2D0", VA = "0x1815602D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xF09130", Offset = "0xF08130", VA = "0x180F09130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public List<IFLODLDHBJN> ABDFGJPDMFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F22B0", VA = "0x1809F32B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7197540", Offset = "0x7196540", VA = "0x187197540", Slot = "5")]
	public override void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x7197550", Offset = "0x7196550", VA = "0x187197550")]
	public LJKFOKNDHCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public enum MMLDAEHGKLI
{
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	ContentBlock,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	JustInTimeTutorialTrigger
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public enum NHAIEPOALMF
{
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Announcements,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	JustInTimeTutorials
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public enum KMOOOBCFFBE
{
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	MakerPenButtonHighlight,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	MakerAIIntroTutorial
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum BGJDLGFHCCD
{
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	EnteredRoom,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	TimeInRoom,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	ObjectInteractionRoom,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	StartedMakerAI
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface FHMCFJPHEOM
{
	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	bool NPPPOBAOHFN
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	NPNKPOOAOFG<GKKPPPDDHFG> AFPJKILAGLA
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	NPNKPOOAOFG<string> BAGEFDIEJNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	NPNKPOOAOFG<GKKPPPDDHFG> KKDFOPBBGDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	NPNKPOOAOFG<GKKPPPDDHFG> LEHAFEJKDMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<GKKPPPDDHFG> JMFDALPLDHH(NHAIEPOALMF DHLCHOOBMKM);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<GKKPPPDDHFG> BJKOKNLBCGI(NHAIEPOALMF DHLCHOOBMKM);

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GKKPPPDDHFG GJJDKMOHCBC(NHAIEPOALMF DHLCHOOBMKM, string BFCPMLOIACK);

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GKKPPPDDHFG BKBJHMALMOI(NHAIEPOALMF DHLCHOOBMKM);

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DOBBHKDLLNC(NHAIEPOALMF DHLCHOOBMKM);

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int JCPPOEMBOAG(NHAIEPOALMF DHLCHOOBMKM);

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task CBCKGPMMHOP();

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task CGDCCGAINLC(GKKPPPDDHFG NAAMEAFIHJI);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface HEAKNPJEKDG
{
	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	ONBMKFDDMAD AIEHPPFGPJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	int EHCOECBJJLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	bool BDDLNMFEPPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	bool MFMCPMALIAD
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	bool GPHDADNBDLA
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	bool PCKNODGNJOA
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	bool IEHPNMIOBAI
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	bool ENCBJNLBMDA
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	bool IGOOMIHJMBE
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action NOOAHJMIJKN;

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "11")]
	KGAPFDAFEHM<JFGPKDMFMOH> IKIEICFDNGO(int BEKCOFDFFEG);

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(Slot = "12")]
	HPIGCMLNLFB LCCLHFKMFGH(DateTime IBFJLLIGGKF);

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(Slot = "13")]
	HPIGCMLNLFB NEGLFGLKDJE(string PJKIBMBJMLL);

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task EAFMGGFNJPD([Optional] CancellationToken CBJPDIFOEKF);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum PAGEBMJHNMA
{
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	Memory,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	Multiplayer
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class HAKOGLGMAMH
{
	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7194190", Offset = "0x7193190", VA = "0x187194190")]
	public static string MFABOCDKDIF(this PAGEBMJHNMA ODEKBMAHGAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface DNJLPEMGFLO
{
	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<GKKPPPDDHFG>> EPGJMHIHLEP(NHAIEPOALMF DHLCHOOBMKM);

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task CGDCCGAINLC(string BFCPMLOIACK);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface LHJHKPHOIPF
{
	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IFMFNMCPIIB> JPOMFMJLHAO();
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface MNMGKIJOEEF
{
	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KGAPFDAFEHM<List<JLJPDCFPEAB>> IBKOBHFPMFH();

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KGAPFDAFEHM<List<JLJPDCFPEAB>> KCEKPHHGHBB();

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<List<JLJPDCFPEAB>> MIPGLEHNPMI([Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KGAPFDAFEHM<List<JLJPDCFPEAB>> LAPNKAMACOA(List<KEEOBDBOKHK> EHENMIPFPKJ);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KGAPFDAFEHM<List<JLJPDCFPEAB>> OBOJCMFNALB(List<KEEOBDBOKHK> EHENMIPFPKJ);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface HGPCKPIAKLB
{
	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	List<BAAIMDALMOP> DOCDGJPEJEF
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<NPAEHGHLPDF> HCJEKNACNKK;

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HPIGCMLNLFB MBLNNEACNII(BAAIMDALMOP BMIKDHDIMIN);

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	[Obsolete("Alternate gift contexts are being phased out. Use LocalRequestGiftPackage(GiftContext context, string message) instead")]
	KGAPFDAFEHM<BAAIMDALMOP> OHKEEGFFNKN(IPAJFKBAJFI INLEBAAACKH, IPAJFKBAJFI? LMEKGIKJNGO, bool DGJNAOKPFEG, string NAAMEAFIHJI);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KGAPFDAFEHM<BAAIMDALMOP> OHKEEGFFNKN(IPAJFKBAJFI INLEBAAACKH, string NAAMEAFIHJI);

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CHBCJKEAPNK(BAAIMDALMOP GHLFOEEBLEN, bool ABLOBMJHCPI = false, bool CGIJEIBCJPJ = false, bool OELBEIDCFLI = true);

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	KGAPFDAFEHM<List<BAAIMDALMOP>> EOMAIKAIDKG();
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface MCAJCMLHMPD
{
	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	string HOFKIDHKOFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	bool KFELMJPKNCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HPIGCMLNLFB LCKJDMPFFCM();

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HPIGCMLNLFB PEBPALOOLKP(string HMHABFKHOID, string LOGDAPLBFPM);

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HPIGCMLNLFB MGFFLKANDMD(string LPEKAIKOLIB);

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CICCKIHIBHE();

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<IFIFDHFHHIE> NGMJHJIHIGA(string PJKIBMBJMLL, string LPEKAIKOLIB, bool KDCGOMKBNKC, string KDKFAKBGOFJ, string OCLBKOCJHKH, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task BBOKGIJMMDI(int BEKCOFDFFEG, string EPIGDNGDLGL, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task CDOINDIMGNB(int BEKCOFDFFEG, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task BELIGBHDAKF([Optional] PAGEBMJHNMA? PPILDELEEAF, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<IReadOnlyList<KDPMHAHADHO>> PBBLGKLKHLO([Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task DKNCPKGFLLP([Optional] CancellationToken CBJPDIFOEKF);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface HFBIPKHKMKP
{
	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<OEICLKBONKJ>> JCJIGNIMFMA([Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<List<DJCCPAPFEMK>> NDKEOPILOON([Optional] CancellationToken CBJPDIFOEKF);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface LCPHDMAJEKI
{
	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task FGBFCHNBHLC([Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HJEEFCHPPAF();
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface KCBAIAGLJEB
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event AINGCLHLHDA? CFBJFFDHCDL;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event AINGCLHLHDA? EPPIKDLJBCJ;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event AINGCLHLHDA? PDIGOOFEGHD;

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<MBEOFKNNOOM> HMICJLONDHK();

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<MBEOFKNNOOM?>? GJNOLMBFPFM(int BEKCOFDFFEG);

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<List<DBFCKDINKKA>> LPCKGHGOHBE(List<int> NCFPKCADDII);

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<IReadOnlyDictionary<int, MBEOFKNNOOM>> HPJAAJKKKJN();

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<List<MBEOFKNNOOM?>?>? ICFPAGMIHAC(int BEKCOFDFFEG);

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task KHHKNHCANKF(int LKOLHBGNLLI);

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<MDPKOJIHEAN> OBDKAMODCIA(MBEOFKNNOOM IEAHLNFHDKK);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public delegate void AINGCLHLHDA(int BEKCOFDFFEG, int LKOLHBGNLLI, MBEOFKNNOOM? IEAHLNFHDKK);
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface ILOOKKAOHHD
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[Flags]
	public enum KCLECBIEILG
	{
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		FilterProfanity = 1,
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		FilterURL = 2
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	string BGKIHPJFBOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	CDIGONBLHDF GMKMEHMDCBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	KBKDLGNDCGI BPIJIKNKMOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	string PBCJMOLFCCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	byte AMINPLLLHFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	int CGDFHMJKGNK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	int BIHKMEFLCLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	bool OBCJEAHPJAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	bool HODBOLBFCHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	bool EKANCJBFEAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	bool EKKPBEAKGCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	bool COIGKBOPLKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	bool GOMCNBIPLII
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	bool NMCJBEKDFIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KGAPFDAFEHM<string> IOOBAEBBHAG();

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<string> FNKCELKKPLN();

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "15")]
	KGAPFDAFEHM<bool> IsPlayerCommunicationRestricted(int BEKCOFDFFEG);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "16")]
	string DAGJLAMACPP(string NFHOBPDKIPM, bool NKBMFJNILBG = true);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<string> HFKGMFGDANB(string NFHOBPDKIPM, bool NKBMFJNILBG = true);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "18")]
	KGAPFDAFEHM<string> MakeRoomNameAdhereToPlatformRequirements(long CINEDGEJAIA, string NFHOBPDKIPM);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool SanitizeDisplayText(string GNCPKBNDNHP, KCLECBIEILG OCMONDCMAAI = KCLECBIEILG.FilterProfanity | KCLECBIEILG.FilterURL);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<string> SanitizeDisplayTextAsync(string GNCPKBNDNHP, KCLECBIEILG OCMONDCMAAI = KCLECBIEILG.FilterProfanity | KCLECBIEILG.FilterURL, bool MAPKEPAONIM = false);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool CheckNameForProfanity(string NFHOBPDKIPM, KCLECBIEILG OCMONDCMAAI = KCLECBIEILG.FilterProfanity | KCLECBIEILG.FilterURL);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "23")]
	KGAPFDAFEHM<string> GetCommerceSubscriptionAccessToken();
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface JEDNOEGENMO
{
	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<COKEPAOCGGE>> KKMGJMFLDJK([Optional] CancellationToken CBJPDIFOEKF);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface GALIJNKHELC
{
	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KKEKMMDAIEK(byte[] CNOOJBJPLMK, byte[] GDKCMGFFGDG);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface PJCGDKDHENN
{
	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task CEDLDHCAFHF(string PACCIEDDEHK);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface ODJDPMOCLIM
{
	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	NPNKPOOAOFG<PLJDCCENOPO> DCIMHGPJLLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<bool> JCDBGJCILJJ(string IMMCNGPOMNH);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<KOOBFFMABND> BOKGHGAHMCD(string IMMCNGPOMNH, string INCILAOOKDC);

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task HCFFIEFIKCD(string IMMCNGPOMNH, IEnumerable<string> CDPALGEMJCK, int LLLNDHJJMGP = 0);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<List<BBMBJJIMEEM<FilteredTextDTO>>> HAOGMFJKHND(uint HBKAMIDNPLA, IEnumerable<string> CDPALGEMJCK);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface ANCLPPOKBID
{
	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ONFPPKHLLJM([Out] bool OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MHAIOCLMHEM([Out] bool OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GEBMELFDCFP([Out] int OHLIHBDBKCE);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public enum CJDEGHKPNCH
{
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	BasedOnBirthday,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	ModerationOverride,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	PendingOverride
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public enum HNBABOOCKOM
{
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	Id,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	Email,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	Phone
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[Flags]
public enum DFCIKPLNGKE
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	SheHer = 1,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	HeHim = 2,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	TheyThem = 4,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	ZeHir = 8,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	ZeZir = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	XeXem = 0x20
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[Flags]
public enum GNDIGJJHAFN
{
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	LGBTQIA = 1,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	Transgender = 2,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	Bisexual = 4,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	Lesbian = 8,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	Pansexual = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	Asexual = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	Intersex = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	Genderqueer = 0x80,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	Nonbinary = 0x100,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	Aromantic = 0x200
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public enum MHNCGGBFGKA
{
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	Daily = 10,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	Weekly = 20,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	Monthly = 30,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	Never = 40,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	Yes = 50
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public enum EMAMJKINDIA
{
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	BELOW_TEN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	BETWEEN_TEN_AND_TWELVE = 10,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	TEEN = 13,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	ADULT = 18,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	UNKNOWN = 999
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface JFGPKDMFMOH
{
	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	int COMMLBDCOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	string LLIPOLEDJHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	string NJIPKMNFOPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	string KEMBBHGHICP
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	string IKAANCGJELC
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	string GENCAMEKGGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	string MEJCHGPNHPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	bool GMCHEDEKECG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	bool MFMGAHNBGEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	DFCIKPLNGKE FAPHDPOIOAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	GNDIGJJHAFN JMAAOIPNPKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	DateTime HLEKPMBEFEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	bool? JEBMEKLCHNK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void NLLNGFKCBNJ(bool EDGAPCIGLOE);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void KADELGGOFIF(bool IFPEEGHGDJO);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface ONBMKFDDMAD : JFGPKDMFMOH
{
	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	string BLCCOOJNOOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	string MFIBCJKGBPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	DateTime? EIPCKGGGILG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	CJDEGHKPNCH JJBGIHKELAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	int? AKAJPKGFIKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	int EEFMPDFFCBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	bool EEOIPKJABFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	bool EOBPJHAHJGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	bool? FDEFLLOAPGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class AEFPEOMJMHM
{
	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public JFGPKDMFMOH JEOBLJDGKNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public HNBABOOCKOM OOLDDABNBBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x9F32A0", Offset = "0x9F22A0", VA = "0x1809F32A0")]
		[CompilerGenerated]
		get
		{
			return default(HNBABOOCKOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public string JAPPAIFKPON
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x6B19150", Offset = "0x6B18150", VA = "0x186B19150")]
	public AEFPEOMJMHM(JFGPKDMFMOH CEOAPELDBLE, HNBABOOCKOM DPDADNHOKAB, string KFIEAPNKGBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface LMKECDLMKKK
{
	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	int COMMLBDCOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	bool KLHIKGJKBOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface KNNLDGKGGMC
{
	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	int COMMLBDCOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	bool FIFCBHEINEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface PHMNOIEDKBE
{
	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	int COMMLBDCOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	string PJNBFAPMEKD
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public enum DKDANGFCEKG
{
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	Outfit,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	HairDye,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	CustomOutfit
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class JLJPDCFPEAB
{
	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public DKDANGFCEKG GOPBNIHHAJD
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(DKDANGFCEKG);
		}
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D30", Offset = "0x9EFD30", VA = "0x1809F0D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public string HKGGJOPMJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public string MMIOLPJIDEC
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public NGFKJBKJKIN PKGBFGMFFCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x9F0C90", Offset = "0x9EFC90", VA = "0x1809F0C90")]
		[CompilerGenerated]
		get
		{
			return default(NGFKJBKJKIN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CE0", Offset = "0x9EFCE0", VA = "0x1809F0CE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public string DHAGEEEOPOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F22B0", VA = "0x1809F32B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public int ILJCGCMLCHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xA0E750", Offset = "0xA0D750", VA = "0x180A0E750")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xD4F350", Offset = "0xD4E350", VA = "0x180D4F350")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public bool FDGHDMGJNKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xE164A0", Offset = "0xE154A0", VA = "0x180E164A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xE16490", Offset = "0xE15490", VA = "0x180E16490")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public KEEOBDBOKHK GOMMIAFJHPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x1282FE0", Offset = "0x1281FE0", VA = "0x181282FE0")]
		[CompilerGenerated]
		get
		{
			return default(KEEOBDBOKHK);
		}
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7195EB0", Offset = "0x7194EB0", VA = "0x187195EB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public ODFBDNOADGM CDJDBMFGDEN
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x192D3A0", Offset = "0x192C3A0", VA = "0x18192D3A0")]
		[CompilerGenerated]
		get
		{
			return default(ODFBDNOADGM);
		}
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x6497E90", Offset = "0x6496E90", VA = "0x186497E90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public string NMHEGGBKEHF
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x9F90F0", Offset = "0x9F80F0", VA = "0x1809F90F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x9F9010", Offset = "0x9F8010", VA = "0x1809F9010")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public DateTime HLEKPMBEFEF
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x9F9100", Offset = "0x9F8100", VA = "0x1809F9100")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x680C260", Offset = "0x680B260", VA = "0x18680C260")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x7196010", Offset = "0x7195010", VA = "0x187196010")]
	internal JLJPDCFPEAB(JGHCOLCIHBH DFKPMMPAOIH, NGJIPCEJOIB KIIDBFFMGDI, POAKPCMKJOA ABPDFJDNHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x7195ED0", Offset = "0x7194ED0", VA = "0x187195ED0")]
	public JLJPDCFPEAB(DKDANGFCEKG IOPNLAOPFJE = DKDANGFCEKG.Outfit, [Optional] KEEOBDBOKHK PFACNPFKJLB, [Optional] string OMCLCFINMNI, [Optional] string LAADEINHGNK, NGFKJBKJKIN NFFLJBGMIFL = NGFKJBKJKIN.Common, [Optional] string LNDEEENNHEG, int MONOBEAOLBH = 0, bool MKJJHAEABJC = false, [Optional] string KKGBCDKONEC, [Optional] DateTime? IPOPOEOJDBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[KGJMAOFDNAE]
public class JGHCOLCIHBH : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public DKDANGFCEKG GOPBNIHHAJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(DKDANGFCEKG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D30", Offset = "0x9EFD30", VA = "0x1809F0D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	[DataMember(Name = "AvatarItemDesc")]
	public string IONOIHBEKFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public string HKGGJOPMJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public string MMIOLPJIDEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x9F5A20", Offset = "0x9F4A20", VA = "0x1809F5A20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public NGFKJBKJKIN PKGBFGMFFCE
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x9F6440", Offset = "0x9F5440", VA = "0x1809F6440")]
		[CompilerGenerated]
		get
		{
			return default(NGFKJBKJKIN);
		}
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x9F67F0", Offset = "0x9F57F0", VA = "0x1809F67F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public string DHAGEEEOPOM
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x9F1780", Offset = "0x9F0780", VA = "0x1809F1780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x9F1770", Offset = "0x9F0770", VA = "0x1809F1770")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public int ILJCGCMLCHH
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0xA00120", Offset = "0x9FF120", VA = "0x180A00120")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0xE04AF0", Offset = "0xE03AF0", VA = "0x180E04AF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public bool FDGHDMGJNKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x1667100", Offset = "0x1666100", VA = "0x181667100")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x1672B20", Offset = "0x1671B20", VA = "0x181672B20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public string JFAANGGIFAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x9F17A0", Offset = "0x9F07A0", VA = "0x1809F17A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x9F1500", Offset = "0x9F0500", VA = "0x1809F1500")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public DateTime HLEKPMBEFEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x9F4700", Offset = "0x9F3700", VA = "0x1809F4700")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0xE16470", Offset = "0xE15470", VA = "0x180E16470")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public JGHCOLCIHBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[KGJMAOFDNAE]
public sealed class LFMHPJKHHOI : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public List<string> FHIBKJDFFNO
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x71974B0", Offset = "0x71964B0", VA = "0x1871974B0")]
	public LFMHPJKHHOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x9FE6D0", Offset = "0x9FD6D0", VA = "0x1809FE6D0")]
	public LFMHPJKHHOI(List<string> EHENMIPFPKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[KGJMAOFDNAE]
public class IFMFNMCPIIB : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public OBPDLECDCNE OBJIPBLANCI
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public HKINNEJNOLG IOLPOANDKFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public IFMFNMCPIIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x9FE5E0", Offset = "0x9FD5E0", VA = "0x1809FE5E0")]
	public IFMFNMCPIIB(OBPDLECDCNE GJEIAMFFDBB, HKINNEJNOLG JEMEJLOOADC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum BOCJAADNIKD
{
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	Braze,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	Rengage
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public enum DDKOGNJJHEL : byte
{
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	APNS,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	Firebase,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	Mock,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	Braze,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	Rengage
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[KGJMAOFDNAE]
public class OBPDLECDCNE : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public BOCJAADNIKD NCFILFHNEBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(BOCJAADNIKD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D30", Offset = "0x9EFD30", VA = "0x1809F0D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public DDKOGNJJHEL? IOHILMJJLJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x2DEE6D0", Offset = "0x2DED6D0", VA = "0x182DEE6D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x7019150", Offset = "0x7018150", VA = "0x187019150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public bool DBPFJCPGBGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x1D48570", Offset = "0x1D47570", VA = "0x181D48570")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x1D48410", Offset = "0x1D47410", VA = "0x181D48410")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x7198AC0", Offset = "0x7197AC0", VA = "0x187198AC0")]
	public OBPDLECDCNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x7198AD0", Offset = "0x7197AD0", VA = "0x187198AD0")]
	public OBPDLECDCNE(BOCJAADNIKD GECANHIHOBF, DDKOGNJJHEL LPNNMFBNEPK, bool DJHOKCFODCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[KGJMAOFDNAE]
public class HKINNEJNOLG : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public string GAEKNFLPFNI
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public string GDNJCPHFFME
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public HKINNEJNOLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x9FE5E0", Offset = "0x9FD5E0", VA = "0x1809FE5E0")]
	public HKINNEJNOLG(string FHAABJIJMKK, string LNOPMAJCJFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public enum CDIGONBLHDF
{
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	VR,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	Screen,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	Mobile,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	VRLow,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	Quest2
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct NPAEHGHLPDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public BAAIMDALMOP MJPJCLIEJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public bool FNPMLGMPJPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public bool ECDILLNGBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public bool ONFOJANOANO;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[KGJMAOFDNAE]
public class BAAIMDALMOP : HADCGNIOBLA, MHLEMOAMOMP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct ELEIAJKDLNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public BAAIMDALMOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x7191F10", Offset = "0x7190F10", VA = "0x187191F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x71920A0", Offset = "0x71910A0", VA = "0x1871920A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	internal static Action<BAAIMDALMOP> OIFBLKPKOGE;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	internal static Func<BAAIMDALMOP, Task> EFOFCHAKHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC1")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	[IgnoreDataMember]
	public bool GEEBJGIMIDG;

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public long? OJLJBFKDCDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xF79DC0", Offset = "0xF78DC0", VA = "0x180F79DC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xF79DB0", Offset = "0xF78DB0", VA = "0x180F79DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public int AGOECKHDGAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xBEA640", Offset = "0xBE9640", VA = "0x180BEA640")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xC64F60", Offset = "0xC63F60", VA = "0x180C64F60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public int? BNBDOOOIPND
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xEC4470", Offset = "0xEC3470", VA = "0x180EC4470")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xEC44A0", Offset = "0xEC34A0", VA = "0x180EC44A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public string MCOPKJANMDF
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F22B0", VA = "0x1809F32B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public DKDANGFCEKG? GOPBNIHHAJD
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x9F1780", Offset = "0x9F0780", VA = "0x1809F1780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x9F6800", Offset = "0x9F5800", VA = "0x1809F6800")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	[DataMember(Name = "AvatarItemDesc")]
	public string PKLEIEIGDPK
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x9F6810", Offset = "0x9F5810", VA = "0x1809F6810")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x9F1580", Offset = "0x9F0580", VA = "0x1809F1580")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public Guid? BJLCIJDDMDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x7190180", Offset = "0x718F180", VA = "0x187190180")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7190170", Offset = "0x718F170", VA = "0x187190170")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public string BFFDHJKHCAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x9F46F0", Offset = "0x9F36F0", VA = "0x1809F46F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x9F46C0", Offset = "0x9F36C0", VA = "0x1809F46C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public string NEHLIKDHFLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CF0", Offset = "0x9F3CF0", VA = "0x1809F4CF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CD0", Offset = "0x9F3CD0", VA = "0x1809F4CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public COAFHABICNE HHNPLOFGEBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xA17D90", Offset = "0xA16D90", VA = "0x180A17D90")]
		[CompilerGenerated]
		get
		{
			return default(COAFHABICNE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x12E4C80", Offset = "0x12E3C80", VA = "0x1812E4C80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public int FIPPELPIBNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0xA17DF0", Offset = "0xA16DF0", VA = "0x180A17DF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x12E4C60", Offset = "0x12E3C60", VA = "0x1812E4C60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public int ICJCBNEJBLP
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xD9BF60", Offset = "0xD9AF60", VA = "0x180D9BF60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0xE836B0", Offset = "0xE826B0", VA = "0x180E836B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public IPAJFKBAJFI PNEKJCEICLO
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xE2AB50", Offset = "0xE29B50", VA = "0x180E2AB50")]
		[CompilerGenerated]
		get
		{
			return default(IPAJFKBAJFI);
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x13434B0", Offset = "0x13424B0", VA = "0x1813434B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public NGFKJBKJKIN DKHJLBKCGGC
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xBE5CB0", Offset = "0xBE4CB0", VA = "0x180BE5CB0")]
		[CompilerGenerated]
		get
		{
			return default(NGFKJBKJKIN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x1318A50", Offset = "0x1317A50", VA = "0x181318A50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	[DataMember(Name = "Message")]
	public string KBOHHPHOMBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x9F9100", Offset = "0x9F8100", VA = "0x1809F9100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x9F8FF0", Offset = "0x9F7FF0", VA = "0x1809F8FF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public string JGOGPEGPAFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0xBDE270", Offset = "0xBDD270", VA = "0x180BDE270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x12CD960", Offset = "0x12CC960", VA = "0x1812CD960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool GNCDAKMMHBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0xE167B0", Offset = "0xE157B0", VA = "0x180E167B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0xE16AB0", Offset = "0xE15AB0", VA = "0x180E16AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public KBKDLGNDCGI BPIJIKNKMOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0xDA6E80", Offset = "0xDA5E80", VA = "0x180DA6E80")]
		[CompilerGenerated]
		get
		{
			return default(KBKDLGNDCGI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xDA4510", Offset = "0xDA3510", VA = "0x180DA4510")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public FFEEJALAFLP EBCADCJGKAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x9F9170", Offset = "0x9F8170", VA = "0x1809F9170")]
		[CompilerGenerated]
		get
		{
			return default(FFEEJALAFLP);
		}
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x9F90E0", Offset = "0x9F80E0", VA = "0x1809F90E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public ENBJEHKMOJF? FOCHGGKBCJG
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7190110", Offset = "0x718F110", VA = "0x187190110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7190120", Offset = "0x718F120", VA = "0x187190120")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public bool EGJOMEIGCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x7190040", Offset = "0x718F040", VA = "0x187190040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public bool PBOGAIHILKI
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7190130", Offset = "0x718F130", VA = "0x187190130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public bool EIEJHGCIALK
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x7190150", Offset = "0x718F150", VA = "0x187190150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	[IgnoreDataMember]
	public bool AKBMEBLPHON
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x9F54C0", Offset = "0x9F44C0", VA = "0x1809F54C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x9F5500", Offset = "0x9F4500", VA = "0x1809F5500")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	[IgnoreDataMember]
	public bool LKIDIFGHMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x2ADC450", Offset = "0x2ADB450", VA = "0x182ADC450")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x2ADC440", Offset = "0x2ADB440", VA = "0x182ADC440")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	[IgnoreDataMember]
	public string KGOINKIPJEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xC0CEE0", Offset = "0xC0BEE0", VA = "0x180C0CEE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0xE430C0", Offset = "0xE420C0", VA = "0x180E430C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	[IgnoreDataMember]
	public string OGIHIEGMJJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0xD36B70", Offset = "0xD35B70", VA = "0x180D36B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xD36B80", Offset = "0xD35B80", VA = "0x180D36B80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	[IgnoreDataMember]
	public bool BJIBDABGNND
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0xF34DA0", Offset = "0xF33DA0", VA = "0x180F34DA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0xBCCE90", Offset = "0xBCBE90", VA = "0x180BCCE90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x71900B0", Offset = "0x718F0B0", VA = "0x1871900B0", Slot = "5")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x71901A0", Offset = "0x718F1A0", VA = "0x1871901A0", Slot = "6")]
	[AsyncStateMachine(typeof(ELEIAJKDLNH))]
	public virtual Task PGKHKEHPKKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x13434B0", Offset = "0x13424B0", VA = "0x1813434B0")]
	public void CIKDEECJNBF(IPAJFKBAJFI INLEBAAACKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public BAAIMDALMOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface BBOPBAIMAHN
{
	[Cpp2IlInjected.Token(Token = "0x17000124")]
	long MFGIGBBNBLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	string ENLDADCHJGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	int LMMOJLGOGHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	string BPBACGJDGJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	string JMBIKEHOJBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	string PNHKFKCEKNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	byte MDGICHBHHAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	int HDJPHOGLDFF
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	int MJJNKLAINMD
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	GGBJCIFEEKL PEDJKOGJKLO
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	bool CLMMDKBAGFM
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	DateTime GJGOMALEFKE
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	DateTime HLEKPMBEFEF
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	DateTime? HDEEMKMNJKN
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	long? EJAEPDAPGBD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	int OAADMGABLHC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	int BGBHODMEGAK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	int IMIEBPOCLHP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	IJNDBPBABID KABEGOJOENJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	IJNDBPBABID AOCHFLKEHAP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	bool CPBKJAIMBEH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	bool JJBLAKOPNEP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	bool PLKKACFMMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	bool LFKKFPCPPNM
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	int? DFMBJPCDEPP
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	bool EKDHIHGBFDM
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	string LFBIPPGCJEF
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PMFMMFNCOHI();

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OOGMFHOHBIL();
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[KGJMAOFDNAE]
public class BEKBAAJDHFF : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public List<APPNANGFABC> NEGJPANFFBD
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x7190980", Offset = "0x718F980", VA = "0x187190980")]
	public List<string> NLLADEKCHPI(params OAPMNGPFEMF[] IKDGFDAFKMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x7190B40", Offset = "0x718FB40", VA = "0x187190B40")]
	public List<string> PIANKCJJDPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x7190840", Offset = "0x718F840", VA = "0x187190840")]
	public List<string> CEIELPIPMOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x7190890", Offset = "0x718F890", VA = "0x187190890", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public BEKBAAJDHFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[KGJMAOFDNAE]
public class FJFADKEHNHB : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public int LMMOJLGOGHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D30", Offset = "0x9EFD30", VA = "0x1809F0D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public FJFADKEHNHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[KGJMAOFDNAE]
public class MCKOHDKGJNJ : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public long MFGIGBBNBLD
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0xCF3540", Offset = "0xCF2540", VA = "0x180CF3540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public string ENLDADCHJGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public int OPDMJMAFFKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0xBEA640", Offset = "0xBE9640", VA = "0x180BEA640")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xC64F60", Offset = "0xC63F60", VA = "0x180C64F60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public bool GIOEBEDIGKP
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0xD07AC0", Offset = "0xD06AC0", VA = "0x180D07AC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0xD070C0", Offset = "0xD060C0", VA = "0x180D070C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public int NNGDNFLIKOA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x9F0C90", Offset = "0x9EFC90", VA = "0x1809F0C90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CE0", Offset = "0x9EFCE0", VA = "0x1809F0CE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public int BBGGIBAEDBH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0xC63430", Offset = "0xC62430", VA = "0x180C63430")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x13A4DF0", Offset = "0x13A3DF0", VA = "0x1813A4DF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public int KOGOGLKDFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x9F6440", Offset = "0x9F5440", VA = "0x1809F6440")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x9F67F0", Offset = "0x9F57F0", VA = "0x1809F67F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public int JKJEGDOOHLG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xA30B60", Offset = "0xA2FB60", VA = "0x180A30B60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0xA2FCA0", Offset = "0xA2ECA0", VA = "0x180A2FCA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public string JBFBNODCJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x9F1780", Offset = "0x9F0780", VA = "0x1809F1780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x9F1770", Offset = "0x9F0770", VA = "0x1809F1770")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public string CDIHJLGPJAH
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x9F6810", Offset = "0x9F5810", VA = "0x1809F6810")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x9F1580", Offset = "0x9F0580", VA = "0x1809F1580")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public DateTime HLEKPMBEFEF
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x9F17A0", Offset = "0x9F07A0", VA = "0x1809F17A0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x6EC77B0", Offset = "0x6EC67B0", VA = "0x186EC77B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public GGBJCIFEEKL? NAEMFACIBGO
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x9F4700", Offset = "0x9F3700", VA = "0x1809F4700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0xE16470", Offset = "0xE15470", VA = "0x180E16470")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public IReadOnlyList<Guid> GCHOGJDJOCB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x9F4710", Offset = "0x9F3710", VA = "0x1809F4710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x9F46D0", Offset = "0x9F36D0", VA = "0x1809F46D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public NGHKAOKDFBL HJONKKMKMPE
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x7197C20", Offset = "0x7196C20", VA = "0x187197C20")]
		get
		{
			return default(NGHKAOKDFBL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x71979B0", Offset = "0x71969B0", VA = "0x1871979B0", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x7197A30", Offset = "0x7196A30", VA = "0x187197A30")]
	public bool NJNJIHOCGFM(MCKOHDKGJNJ IFMEGLHJPDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x7197A40", Offset = "0x7196A40", VA = "0x187197A40")]
	private bool OEJBCLEHKDL(MCKOHDKGJNJ IFMEGLHJPDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x7197910", Offset = "0x7196910", VA = "0x187197910")]
	private static bool ACPBNGPHPOO(IReadOnlyList<Guid> HFGDJHPPLMD, IReadOnlyList<Guid> CPGDAONACLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x278C8A0", Offset = "0x278B8A0", VA = "0x18278C8A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public MCKOHDKGJNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[KGJMAOFDNAE]
public class INGDBPKOLAP : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public int GKIGMCHANCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D30", Offset = "0x9EFD30", VA = "0x1809F0D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public INGDBPKOLAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[KGJMAOFDNAE]
public class NNGKJHFPNFO : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public bool PFFJKLLLFKD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xC649F0", Offset = "0xC639F0", VA = "0x180C649F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xC648C0", Offset = "0xC638C0", VA = "0x180C648C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public NNGKJHFPNFO()
	{
	}
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[KGJMAOFDNAE]
	public class NewInventionRequestDTO : MHLEMOAMOMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public bool hasBetaContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public int instantiationCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public int lightsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public int chipsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public int cloudVariablesCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public int aiCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public byte ugcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public long creationRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public string inventionDataFilename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public List<long> referencedInventions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public IReadOnlyList<Guid> referencedUnityAssetIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public PFBDGKHFNEC creatorAccountRole;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public long? convertedFromInventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public string displayMetadataJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public string longDescription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public ModifyTagsRequest tagsRequest;

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xE9CBF0", Offset = "0xE9BBF0", VA = "0x180E9CBF0", Slot = "4")]
		public void FOGENAANJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x7198A30", Offset = "0x7197A30", VA = "0x187198A30")]
		public NewInventionRequestDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[KGJMAOFDNAE]
	public class AddVersionInventionRequestDTO : MHLEMOAMOMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public long inventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public bool hasBetaContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public int instantiationCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public int lightsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public int chipsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public int cloudVariablesCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public int aiCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public byte ugcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public long creationRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public string inventionDataFilename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public List<long> referencedInventions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public IReadOnlyList<Guid> referencedUnityAssetIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public ModifyTagsRequest tagsRequest;

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xE9CBF0", Offset = "0xE9BBF0", VA = "0x180E9CBF0", Slot = "4")]
		public void FOGENAANJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x7190030", Offset = "0x718F030", VA = "0x187190030")]
		public AddVersionInventionRequestDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[KGJMAOFDNAE]
	public class ModifyTagsRequest : MHLEMOAMOMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public List<string> AutoTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public List<string> CustomTags;

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
		public void FOGENAANJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public ModifyTagsRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[KGJMAOFDNAE]
	public class InventionModifyTagsRequest : ModifyTagsRequest
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public long InventionId;

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public InventionModifyTagsRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[KGJMAOFDNAE]
	public class ReportRequest : MHLEMOAMOMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public long InventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public string Details;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public MBNLFGINNEI ReportCategory;

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
		public void FOGENAANJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public ReportRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[KGJMAOFDNAE]
	public class CheerRequest : MHLEMOAMOMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public long InventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public bool Cheer;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
		public void FOGENAANJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public CheerRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[KGJMAOFDNAE]
	public class UpdatePriceRequest : MHLEMOAMOMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public long InventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public int Price;

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
		public void FOGENAANJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public UpdatePriceRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[KGJMAOFDNAE]
	public class UpdateInventionMetadataRequest : MHLEMOAMOMP
	{
		[Cpp2IlInjected.Token(Token = "0x17000152")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0xCF3540", Offset = "0xCF2540", VA = "0x180CF3540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000154")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000155")]
		public string LongDescription
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x9F5A20", Offset = "0x9F4A20", VA = "0x1809F5A20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000156")]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F22B0", VA = "0x1809F32B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000157")]
		public ModifyTagsRequest TagsRequest
		{
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x9F1780", Offset = "0x9F0780", VA = "0x1809F1780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x9F1770", Offset = "0x9F0770", VA = "0x1809F1770")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0xE9CBF0", Offset = "0xE9BBF0", VA = "0x180E9CBF0", Slot = "4")]
		public void FOGENAANJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public UpdateInventionMetadataRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[KGJMAOFDNAE]
	public class UpdateInventionGeneralPermissionRequest : MHLEMOAMOMP
	{
		[Cpp2IlInjected.Token(Token = "0x17000158")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0xCF3540", Offset = "0xCF2540", VA = "0x180CF3540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000159")]
		public IJNDBPBABID Permission
		{
			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x9F32A0", Offset = "0x9F22A0", VA = "0x1809F32A0")]
			[CompilerGenerated]
			get
			{
				return default(IJNDBPBABID);
			}
			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x9F3290", Offset = "0x9F2290", VA = "0x1809F3290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
		public void FOGENAANJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public UpdateInventionGeneralPermissionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[KGJMAOFDNAE]
	public class PublishInventionRequest : MHLEMOAMOMP
	{
		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0xCF3540", Offset = "0xCF2540", VA = "0x180CF3540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		public IJNDBPBABID Permission
		{
			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x9F32A0", Offset = "0x9F22A0", VA = "0x1809F32A0")]
			[CompilerGenerated]
			get
			{
				return default(IJNDBPBABID);
			}
			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0x9F3290", Offset = "0x9F2290", VA = "0x1809F3290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		public GGBJCIFEEKL Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0xA18A40", Offset = "0xA17A40", VA = "0x180A18A40")]
			[CompilerGenerated]
			get
			{
				return default(GGBJCIFEEKL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0xD541A0", Offset = "0xD531A0", VA = "0x180D541A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		public int? Price
		{
			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0xC8C980", Offset = "0xC8B980", VA = "0x180C8C980")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
		public void FOGENAANJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public PublishInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[KGJMAOFDNAE]
	public class UnpublishInventionRequest : MHLEMOAMOMP
	{
		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0xCF3540", Offset = "0xCF2540", VA = "0x180CF3540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
		public void FOGENAANJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public UnpublishInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[KGJMAOFDNAE]
	public class DeleteInventionRequest : MHLEMOAMOMP
	{
		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0xCF3540", Offset = "0xCF2540", VA = "0x180CF3540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
		public void FOGENAANJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public DeleteInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[KGJMAOFDNAE]
	public class SetInventionVersionAccessibilityRequest : MHLEMOAMOMP
	{
		[Cpp2IlInjected.Token(Token = "0x17000160")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0xCF3540", Offset = "0xCF2540", VA = "0x180CF3540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000161")]
		public int VersionNumber
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x9F32A0", Offset = "0x9F22A0", VA = "0x1809F32A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x9F3290", Offset = "0x9F2290", VA = "0x1809F3290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		public GGBJCIFEEKL NewAccessibility
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0xA18A40", Offset = "0xA17A40", VA = "0x180A18A40")]
			[CompilerGenerated]
			get
			{
				return default(GGBJCIFEEKL);
			}
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0xD541A0", Offset = "0xD531A0", VA = "0x180D541A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
		public void FOGENAANJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public SetInventionVersionAccessibilityRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[KGJMAOFDNAE]
	public class SpecialTags : MHLEMOAMOMP
	{
		[Cpp2IlInjected.Token(Token = "0x17000163")]
		public List<string> AutoTags
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000164")]
		public List<string> AGOnlyTags
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
		public void FOGENAANJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public SpecialTags()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public enum ONBJAEBDEPH
{
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	InvalidParameters,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	PlayerCannotUpload,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	DuplicateName,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	NameTooShort,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	NameTooLong,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	NotCreator,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	DoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	ImageDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	InventionLimitReached,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	DescriptionTooLong,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	InnapropriateName,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	InappropriateDescription,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	CannotBeModified,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	PlayerCannotPublish,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	AlreadyPublished,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	AlreadyUnpublished,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	InventionUnderModerationReview,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	PlayerCannotDownload,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	PlayerAlreadyOwns,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	DescriptionTooShort,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	DoesNotHavePermission,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	PermissionLevelCannotBeChanged,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	AlreadyCheered,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	AlreadyRemovedCheer,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	ModeratorRestrictedPublishing,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	PlayerCannotSell,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	InvalidPrice,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	PriceCannotBeChanged,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	InvalidPermissionForPaidInvention,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	PurchaseFailed,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	CannotDownloadPaidInvention,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	CannotSellUnownedLineage,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	DoesNotAllowTrial,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	StillOnTrialCooldown,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	PlayerCannotTrial,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	PaidInventionPublishingDisabled,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	PaidInventionPurchasingDisabled,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	OperationIsDisabled,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	PlayerRestrictedFromP2PSelling,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	PlayerNotRecRoomPlusMember,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	InvalidInstantiationCost,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	FeaturedInventionNotPublished,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	FeaturedInventionNotActive,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	InventionContainsBlockedFiles,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	PlayerRestrictedFromP2PBuying,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	ReservedWordRuleViolationInName,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	ReservedWordRuleViolationInDescription,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	InventionContainsBetaContent,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	PlatformDoesntSupportPublishing,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	MismatchedUgcVersions,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	ConvertedFromSameUgcVersion,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	ConvertedFromInventionDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	ConvertedFromInventionHigherVersion,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	PlatformDoesntSupportInvention
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public enum MBNLFGINNEI
{
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	CoC_Discriminatory,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	CoC_Sexual,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	CoC_Trolling,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	Misleading,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	Other
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public enum NJKKDIBNBAF
{
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	False,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	True,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	Invited
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public interface KDPMHAHADHO
{
	[Cpp2IlInjected.Token(Token = "0x17000165")]
	KBKDLGNDCGI BPIJIKNKMOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	string PBCJMOLFCCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	int COMMLBDCOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	DateTime ACDJGGIIDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	bool FNDEDJAFKOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	string JDOHLKKDJEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	JFGPKDMFMOH JEOBLJDGKNE
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FOGENAANJJN();

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PMNHBGKMAPL(JFGPKDMFMOH CEOAPELDBLE);
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public interface FCILJAKDADM
{
	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	string KNHBLAEFJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	int JPLLFCIDPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	bool FAPAOCIAFNC
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FOGENAANJJN();
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct IFIFDHFHHIE
{
	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public NEEFMAAKKAO CKMENNJIKOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xA3C5A0", Offset = "0xA3B5A0", VA = "0x180A3C5A0")]
		[CompilerGenerated]
		readonly get
		{
			return default(NEEFMAAKKAO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x1292E00", Offset = "0x1291E00", VA = "0x181292E00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public FCILJAKDADM MOFEEBEHCAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xD7C960", Offset = "0xD7B960", VA = "0x180D7C960")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xD7C770", Offset = "0xD7B770", VA = "0x180D7C770")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public string PHGPDMJKCPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x15EACE0", Offset = "0x15E9CE0", VA = "0x1815EACE0")]
	public IFIFDHFHHIE(NEEFMAAKKAO PJPCILIKLGM, [Optional] FCILJAKDADM GHGFGLNBOCD, [Optional] string OCLBKOCJHKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public enum NEEFMAAKKAO
{
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	ContinueSecurityCode,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	TryAgainSecurityCode,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	RemoteAuthPending
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[KGJMAOFDNAE]
public class OEICLKBONKJ : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public string DCILLECPBGN
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public string MJOFILIHFBD
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public string HODBMJAFBGI
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public string HGCCICIMLAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x9F5A20", Offset = "0x9F4A20", VA = "0x1809F5A20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public List<OEJNELGLGIK> OIFBNNEBFLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F22B0", VA = "0x1809F32B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public OEICLKBONKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x48D74C0", Offset = "0x48D64C0", VA = "0x1848D74C0")]
	public OEICLKBONKJ([Optional] string MFJEOAKPFFI, [Optional] string AHENDINOEMN, [Optional] string MBGHKIHGPGO, [Optional] string DGJKDOBDAIK, [Optional] List<OEJNELGLGIK> IBHKIAHKKPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[KGJMAOFDNAE]
public class OEJNELGLGIK : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public string FPLINFGDKNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public string HGCCICIMLAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public OEJNELGLGIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[KGJMAOFDNAE]
public class DJCCPAPFEMK : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public string MJOFILIHFBD
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public string CKMENNJIKOB
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public string DCILLECPBGN
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public List<string> IMHDCLDLHDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x9F5A20", Offset = "0x9F4A20", VA = "0x1809F5A20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public DJCCPAPFEMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[KGJMAOFDNAE]
public interface MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FOGENAANJJN();
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[KGJMAOFDNAE]
public interface HADCGNIOBLA : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PGKHKEHPKKI();
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[HKHKLFECEBO]
public interface EGONCOPCFDP : MHLEMOAMOMP
{
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[KGJMAOFDNAE]
public class HIPIMHFHIGB : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	public Guid BJLCIJDDMDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0xF79DC0", Offset = "0xF78DC0", VA = "0x180F79DC0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0xF79DB0", Offset = "0xF78DB0", VA = "0x180F79DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	public int IFCMMFOJBML
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xBEA640", Offset = "0xBE9640", VA = "0x180BEA640")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0xC64F60", Offset = "0xC63F60", VA = "0x180C64F60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	public string BJKMDIGACOG
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x9F5A20", Offset = "0x9F4A20", VA = "0x1809F5A20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	public string AFMOJMFJELP
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F22B0", VA = "0x1809F32B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public HIPIMHFHIGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x71942F0", Offset = "0x71932F0", VA = "0x1871942F0")]
	public HIPIMHFHIGB([Optional] Guid DGPIPOJOJGM, int BDNPFHIBMNH = 0, [Optional] string ICBGIMNNDLE, [Optional] string FDAEHOMAPCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[KGJMAOFDNAE]
public class MBEOFKNNOOM : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	public const int IIKPDFKIFLL = 0;

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	public long PFCGKIECHAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0xCF3540", Offset = "0xCF2540", VA = "0x180CF3540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	public EIMFOIMANHI HMIEIKHLJAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	public string ILNMKENBOBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	public List<HIPIMHFHIGB> BHFEMJNMGAA
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x9F5A20", Offset = "0x9F4A20", VA = "0x1809F5A20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	public int KACOMNMFMMA
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x9F6440", Offset = "0x9F5440", VA = "0x1809F6440")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x9F67F0", Offset = "0x9F57F0", VA = "0x1809F67F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x9F1780", Offset = "0x9F0780", VA = "0x1809F1780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x9F1770", Offset = "0x9F0770", VA = "0x1809F1770")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	public GGBJCIFEEKL PEDJKOGJKLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0xA00120", Offset = "0x9FF120", VA = "0x180A00120")]
		[CompilerGenerated]
		get
		{
			return default(GGBJCIFEEKL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0xE04AF0", Offset = "0xE03AF0", VA = "0x180E04AF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	public string MGDLKIILDLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x9F17A0", Offset = "0x9F07A0", VA = "0x1809F17A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x9F1500", Offset = "0x9F0500", VA = "0x1809F1500")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	public bool LDFILLBMMEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x1DD0300", Offset = "0x1DCF300", VA = "0x181DD0300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x7197760", Offset = "0x7196760", VA = "0x187197760")]
	public MBEOFKNNOOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x71977F0", Offset = "0x71967F0", VA = "0x1871977F0")]
	public MBEOFKNNOOM(long LDDIFOMLAII = 0L, [Optional] EIMFOIMANHI OGPLBHCJHNM, [Optional] string DAMLLFNDABK, [Optional] List<HIPIMHFHIGB> CBOLBPFMLPH, int LKOLHBGNLLI = 0, [Optional] string NFHOBPDKIPM, GGBJCIFEEKL MPCIGGLFCOI = GGBJCIFEEKL.Private, [Optional] string FKOLFGDCNLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class DBFCKDINKKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	public readonly int COMMLBDCOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	public readonly MBEOFKNNOOM HDCILAIAACI;

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0xEAD600", Offset = "0xEAC600", VA = "0x180EAD600")]
	public DBFCKDINKKA(int BEKCOFDFFEG, MBEOFKNNOOM IEAHLNFHDKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[KGJMAOFDNAE]
public class EIMFOIMANHI : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	public string CBPJJLJOIMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	public string FMLBNLNKHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	public string NOGLCKDLIEL
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	public string HBBFGFAMEGL
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x9F5A20", Offset = "0x9F4A20", VA = "0x1809F5A20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	public string PBAANIFKDPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F22B0", VA = "0x1809F32B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	public string BHFEMJNMGAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x7191EE0", Offset = "0x7190EE0", VA = "0x187191EE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public EIMFOIMANHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x48D74C0", Offset = "0x48D64C0", VA = "0x1848D74C0")]
	public EIMFOIMANHI([Optional] string BGDJGEILILH, [Optional] string BJDJCACPIDH, [Optional] string EAMKCDPGGCO, [Optional] string HOKBFOFIGDG, [Optional] string FAOPFFICEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[KGJMAOFDNAE]
public class NPHEIDGBBMN : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000190")]
	public Dictionary<int, MBEOFKNNOOM> KJPGIMEDGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public NPHEIDGBBMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[KGJMAOFDNAE]
public class LPOJDIBHIKJ : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000191")]
	public List<int> PGKOLIKCAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000192")]
	public byte? AMINPLLLHFD
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x2DF74D0", Offset = "0x2DF64D0", VA = "0x182DF74D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x2DF74E0", Offset = "0x2DF64E0", VA = "0x182DF74E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000193")]
	public int? CGDFHMJKGNK
	{
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0xEC4460", Offset = "0xEC3460", VA = "0x180EC4460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0xEC4490", Offset = "0xEC3490", VA = "0x180EC4490")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public LPOJDIBHIKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public static class DJMNNKNLABB
{
	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x7191750", Offset = "0x7190750", VA = "0x187191750")]
	public static GIPABNFHILC OAMAOGBKNOB(this HIPIMHFHIGB OCACDKEJIIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[Flags]
public enum FFEEJALAFLP
{
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	Steam = 1,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	Oculus = 2,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	PlayStation = 4,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	Xbox = 8,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	RecNet = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	IOS = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	GooglePlay = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	Standalone = 0x80,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	Pico = 0x100,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	Switch = 0x200,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	All = -1
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public enum KBKDLGNDCGI
{
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	All = -1,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	Steam,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	Oculus,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	PlayStation,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	Xbox,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	RecNet,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	IOS,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	GooglePlay,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	Standalone,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	Pico,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	Switch
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[KGJMAOFDNAE]
public class LDIOKDFMNKL : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000194")]
	[DataMember(Name = "PlayerId")]
	public int COMMLBDCOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D30", Offset = "0x9EFD30", VA = "0x1809F0D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000195")]
	public int HOAMCOAEJDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xB72E60", Offset = "0xB71E60", VA = "0x180B72E60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0xC5C030", Offset = "0xC5B030", VA = "0x180C5C030")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	public int LNKNENKHMKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x9F32A0", Offset = "0x9F22A0", VA = "0x1809F32A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x9F3290", Offset = "0x9F2290", VA = "0x1809F3290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public LDIOKDFMNKL()
	{
	}
}
namespace RecNet
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[KGJMAOFDNAE]
	public class ProgressionEventRecordDTO : MHLEMOAMOMP
	{
		[Cpp2IlInjected.Token(Token = "0x17000197")]
		public int COMMLBDCOLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D30", Offset = "0x9EFD30", VA = "0x1809F0D30")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000198")]
		public int ICJCBNEJBLP
		{
			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0xB72E60", Offset = "0xB71E60", VA = "0x180B72E60")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0xC5C030", Offset = "0xC5B030", VA = "0x180C5C030")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000199")]
		public int KIKOKOPPJBI
		{
			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0x9F32A0", Offset = "0x9F22A0", VA = "0x1809F32A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x9F3290", Offset = "0x9F2290", VA = "0x1809F3290")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019A")]
		public int FEKHCMFEDAD
		{
			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0xA18A40", Offset = "0xA17A40", VA = "0x180A18A40")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0xD541A0", Offset = "0xD531A0", VA = "0x180D541A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019B")]
		public int ABLIJMBICFO
		{
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0xBEA640", Offset = "0xBE9640", VA = "0x180BEA640")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0xC64F60", Offset = "0xC63F60", VA = "0x180C64F60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019C")]
		public DateTime? HFHNAHPIKAL
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x1286C40", Offset = "0x1285C40", VA = "0x181286C40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x1286C30", Offset = "0x1285C30", VA = "0x181286C30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public ProgressionEventRecordDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x7199290", Offset = "0x7198290", VA = "0x187199290")]
		public ProgressionEventRecordDTO(int BEKCOFDFFEG = 0, int DDMGJKPNDFD = 0, int LHAJDKCPLHI = 0, int LAKMGFPAABD = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
		public void FOGENAANJJN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[KGJMAOFDNAE]
	public class ProgressionEventDTO : MHLEMOAMOMP
	{
		[Cpp2IlInjected.Token(Token = "0x1700019D")]
		public long HBGELNIFCPB
		{
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0xCF3540", Offset = "0xCF2540", VA = "0x180CF3540")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019E")]
		public string IJKBIMCGCEM
		{
			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019F")]
		public List<ProgressionEventRewardDTO> PBPOCFNBPIA
		{
			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A0")]
		public List<KeepsakeRoomListDTO> BKIIEGNHKBB
		{
			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x9F5A20", Offset = "0x9F4A20", VA = "0x1809F5A20")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A1")]
		public DateTime NLFLOIODJFG
		{
			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x9F1520", Offset = "0x9F0520", VA = "0x1809F1520")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A2")]
		public DateTime FNNFCOOJGKA
		{
			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x9F1780", Offset = "0x9F0780", VA = "0x1809F1780")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x9F6800", Offset = "0x9F5800", VA = "0x1809F6800")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A3")]
		public DateTime DGGIIDCFBNP
		{
			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x9F6810", Offset = "0x9F5810", VA = "0x1809F6810")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0xE16A00", Offset = "0xE15A00", VA = "0x180E16A00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A4")]
		public bool NAFNNCHOEDO
		{
			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0xC118F0", Offset = "0xC108F0", VA = "0x180C118F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0xC17A10", Offset = "0xC16A10", VA = "0x180C17A10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A5")]
		public int IEPDJJFPEEN
		{
			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x1356C00", Offset = "0x1355C00", VA = "0x181356C00")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x1FDEB30", Offset = "0x1FDDB30", VA = "0x181FDEB30")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A6")]
		public float BBFBKMDEGHL
		{
			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x10AC000", Offset = "0x10AB000", VA = "0x1810AC000")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x134F260", Offset = "0x134E260", VA = "0x18134F260")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A7")]
		public Guid? BLGPJMCGJNB
		{
			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x71991C0", Offset = "0x71981C0", VA = "0x1871991C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x71991B0", Offset = "0x71981B0", VA = "0x1871991B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A8")]
		public string MLDBMKBIFDH
		{
			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x9F4CF0", Offset = "0x9F3CF0", VA = "0x1809F4CF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x9F4CD0", Offset = "0x9F3CD0", VA = "0x1809F4CD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A9")]
		public string NLCILMFNBHC
		{
			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(RVA = "0x9F4CE0", Offset = "0x9F3CE0", VA = "0x1809F4CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x9F4CC0", Offset = "0x9F3CC0", VA = "0x1809F4CC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AA")]
		public string OIAGEAAMPBG
		{
			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0x9F9180", Offset = "0x9F8180", VA = "0x1809F9180")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0x9F9080", Offset = "0x9F8080", VA = "0x1809F9080")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AB")]
		public string BBDAKEBLNKP
		{
			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0x9F90F0", Offset = "0x9F80F0", VA = "0x1809F90F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0x9F9010", Offset = "0x9F8010", VA = "0x1809F9010")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public ProgressionEventDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x71991E0", Offset = "0x71981E0", VA = "0x1871991E0")]
		public ProgressionEventDTO(long FMIBHJAGMML = 0L, [Optional] string NFHOBPDKIPM, [Optional] List<ProgressionEventRewardDTO> GNAJKFJECJL, [Optional] List<KeepsakeRoomListDTO> AALCIFBIFJE, [Optional] DateTime OMDABEJMMKM, [Optional] DateTime MKDGBOGGCJD, [Optional] DateTime ABHKGEFJGGA, bool KPBKEAAFJEO = false, int HHEGDLMGOAK = 0, float AHJBKKPEIIG = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
		public void FOGENAANJJN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[KGJMAOFDNAE]
	public class KeepsakeRoomListDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		public long LLLHIPOOHBI
		{
			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0xCF3540", Offset = "0xCF2540", VA = "0x180CF3540")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AD")]
		public long HBGELNIFCPB
		{
			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0xC5C130", Offset = "0xC5B130", VA = "0x180C5C130")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AE")]
		public int? FMMNJGCCFGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0xC8C980", Offset = "0xC8B980", VA = "0x180C8C980")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AF")]
		public int? LHALKDENJDD
		{
			[Cpp2IlInjected.Token(Token = "0x60003D2")]
			[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x9F1790", Offset = "0x9F0790", VA = "0x1809F1790")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B0")]
		public long? LPEOMNBLDNM
		{
			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0xDBD010", Offset = "0xDBC010", VA = "0x180DBD010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0xDBC840", Offset = "0xDBB840", VA = "0x180DBC840")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B1")]
		public long MAGNPGIJPCI
		{
			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0x9F6810", Offset = "0x9F5810", VA = "0x1809F6810")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60003D7")]
			[Cpp2IlInjected.Address(RVA = "0xE16A00", Offset = "0xE15A00", VA = "0x180E16A00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B2")]
		public TimeSpan JAGNLJJIGNP
		{
			[Cpp2IlInjected.Token(Token = "0x60003D8")]
			[Cpp2IlInjected.Address(RVA = "0x71965D0", Offset = "0x71955D0", VA = "0x1871965D0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B3")]
		public long ILIANAOHKLF
		{
			[Cpp2IlInjected.Token(Token = "0x60003D9")]
			[Cpp2IlInjected.Address(RVA = "0x9F17A0", Offset = "0x9F07A0", VA = "0x1809F17A0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0x6EC77B0", Offset = "0x6EC67B0", VA = "0x186EC77B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B4")]
		public TimeSpan JFGFEPPAJAG
		{
			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0x7196580", Offset = "0x7195580", VA = "0x187196580")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B5")]
		public int ELOIBOHABIB
		{
			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0xCFC9F0", Offset = "0xCFB9F0", VA = "0x180CFC9F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0xE5AE60", Offset = "0xE59E60", VA = "0x180E5AE60")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B6")]
		public MCEBFBBCOHL CGNNPKJMGFE
		{
			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x111F240", Offset = "0x111E240", VA = "0x18111F240")]
			[CompilerGenerated]
			get
			{
				return default(MCEBFBBCOHL);
			}
			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x216A8C0", Offset = "0x21698C0", VA = "0x18216A8C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B7")]
		public List<KeepsakeRoomDTO> APCPCHANDPC
		{
			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x9F4710", Offset = "0x9F3710", VA = "0x1809F4710")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003E1")]
			[Cpp2IlInjected.Address(RVA = "0x9F46D0", Offset = "0x9F36D0", VA = "0x1809F46D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public KeepsakeRoomListDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x7196620", Offset = "0x7195620", VA = "0x187196620")]
		public KeepsakeRoomListDTO(long LEFNFFBHJLH = 0L, long FMIBHJAGMML = 0L, [Optional] int? OAGAPIGKNKI, [Optional] int? JHKCMKCCJJA, [Optional] long? HOLFNHCGGDA, long KKLHCCKEPGO = 0L, long HLGCLOKKIID = 0L, int OFPBFFCPAKA = 0, MCEBFBBCOHL COMHFDPJFFN = MCEBFBBCOHL.Standard, [Optional] List<KeepsakeRoomDTO> EDKLNJCHBGM)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[KGJMAOFDNAE]
	public class KeepsakeRoomDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170001B8")]
		public long IPFOGPLCAOI
		{
			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0xCF3540", Offset = "0xCF2540", VA = "0x180CF3540")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B9")]
		public long BJFFDFGEMMF
		{
			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0xC5C130", Offset = "0xC5B130", VA = "0x180C5C130")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BA")]
		public long LLLHIPOOHBI
		{
			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0xC8C980", Offset = "0xC8B980", VA = "0x180C8C980")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BB")]
		public MCEBFBBCOHL KFIKOGBAHMD
		{
			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x9F0C90", Offset = "0x9EFC90", VA = "0x1809F0C90")]
			[CompilerGenerated]
			get
			{
				return default(MCEBFBBCOHL);
			}
			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0x9F0CE0", Offset = "0x9EFCE0", VA = "0x1809F0CE0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BC")]
		public int JOMGBPGGHFM
		{
			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0xC63430", Offset = "0xC62430", VA = "0x180C63430")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0x13A4DF0", Offset = "0x13A3DF0", VA = "0x1813A4DF0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public KeepsakeRoomDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x7196520", Offset = "0x7195520", VA = "0x187196520")]
		public KeepsakeRoomDTO(long NOPNHMAKDDC = 0L, long CINEDGEJAIA = 0L, long LEFNFFBHJLH = 0L, MCEBFBBCOHL MLCOGCMJLBB = MCEBFBBCOHL.Standard, int PFCGPNCOPEG = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[KGJMAOFDNAE]
	public class ProgressionEventRewardDTO : MHLEMOAMOMP
	{
		[Cpp2IlInjected.Token(Token = "0x170001BD")]
		public long EENFEJAOJBD
		{
			[Cpp2IlInjected.Token(Token = "0x60003EE")]
			[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0xCF3540", Offset = "0xCF2540", VA = "0x180CF3540")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BE")]
		public int DIPFACLGFEP
		{
			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0x9F32A0", Offset = "0x9F22A0", VA = "0x1809F32A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0x9F3290", Offset = "0x9F2290", VA = "0x1809F3290")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BF")]
		public string PNHKFKCEKNC
		{
			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C0")]
		public int ICJCBNEJBLP
		{
			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0x9F0C90", Offset = "0x9EFC90", VA = "0x1809F0C90")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0x9F0CE0", Offset = "0x9EFCE0", VA = "0x1809F0CE0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C1")]
		public int MPDBNBMBOKA
		{
			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0xC63430", Offset = "0xC62430", VA = "0x180C63430")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0x13A4DF0", Offset = "0x13A3DF0", VA = "0x1813A4DF0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C2")]
		public bool MMJEBPBIAIK
		{
			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0xA1DF60", Offset = "0xA1CF60", VA = "0x180A1DF60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0xA1DD80", Offset = "0xA1CD80", VA = "0x180A1DD80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
		public void FOGENAANJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public ProgressionEventRewardDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[KGJMAOFDNAE]
	public class ProgressionEventPurchasableXpBoostDTO : MHLEMOAMOMP
	{
		[Cpp2IlInjected.Token(Token = "0x170001C3")]
		public Guid CBMLOHFODLJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003FC")]
			[Cpp2IlInjected.Address(RVA = "0xF79DC0", Offset = "0xF78DC0", VA = "0x180F79DC0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60003FD")]
			[Cpp2IlInjected.Address(RVA = "0xF79DB0", Offset = "0xF78DB0", VA = "0x180F79DB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C4")]
		public int ANJOOKPGOOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003FE")]
			[Cpp2IlInjected.Address(RVA = "0xBEA640", Offset = "0xBE9640", VA = "0x180BEA640")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003FF")]
			[Cpp2IlInjected.Address(RVA = "0xC64F60", Offset = "0xC63F60", VA = "0x180C64F60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C5")]
		public int FEDCHNAEDNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0xCFC9B0", Offset = "0xCFB9B0", VA = "0x180CFC9B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000401")]
			[Cpp2IlInjected.Address(RVA = "0xF0C6F0", Offset = "0xF0B6F0", VA = "0x180F0C6F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C6")]
		public int NLHBIOGCFEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0x9F0C90", Offset = "0x9EFC90", VA = "0x1809F0C90")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0x9F0CE0", Offset = "0x9EFCE0", VA = "0x1809F0CE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C7")]
		public long IJOMAFIGBCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0x9F1520", Offset = "0x9F0520", VA = "0x1809F1520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C8")]
		public long CLLFNALMCDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x9F1780", Offset = "0x9F0780", VA = "0x1809F1780")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0x9F6800", Offset = "0x9F5800", VA = "0x1809F6800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
		public void FOGENAANJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public ProgressionEventPurchasableXpBoostDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public enum MCEBFBBCOHL
{
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	Premium
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public enum AFACIFHCNFE
{
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	Explore = 0,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	GreenPowerCore = 1,
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	Present = 2,
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	PurplePowerCore = 3,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	UnnamedKeepsakeNumber1 = 4,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	UnnamedKeepsakeNumber2 = 5,
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	UnnamedKeepsakeNumber3 = 6,
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	UnnamedKeepsakeNumber4 = 7,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	UnnamedKeepsakeNumber5 = 8,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	_Test = 1000
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[KGJMAOFDNAE]
public class COKEPAOCGGE : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170001C9")]
	public string NGGJMDLHLLA
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CA")]
	public string? CBNMGIONGIA
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public COKEPAOCGGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public interface JNFBFBMIKLM
{
	[Cpp2IlInjected.Token(Token = "0x170001CB")]
	bool JPLAKFPJJKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CC")]
	string? FMNIANNOKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CD")]
	string? BGEBLMBMMJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public interface PADGCDDPPLM<T> : JNFBFBMIKLM
{
	[Cpp2IlInjected.Token(Token = "0x170001CE")]
	T FPGFCMMHMJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class DEPGPLOBNFG
{
	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x3694640", Offset = "0x3693640", VA = "0x183694640")]
	public static PADGCDDPPLM<T> IOFGLPCMIME<T, U>(this PADGCDDPPLM<U> OBOOAPELMPF, Func<U, T> JFBCMFKBFGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public struct NPMGGJIHKDI<T> : PADGCDDPPLM<T>, JNFBFBMIKLM
{
	[Cpp2IlInjected.Token(Token = "0x170001CF")]
	public bool JPLAKFPJJKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0xF2CE00", Offset = "0xF2BE00", VA = "0x180F2CE00", Slot = "5")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x29A56F0", Offset = "0x29A46F0", VA = "0x1829A56F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D0")]
	public string? FMNIANNOKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0xD7C960", Offset = "0xD7B960", VA = "0x180D7C960", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0xD7C770", Offset = "0xD7B770", VA = "0x180D7C770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D1")]
	public string? BGEBLMBMMJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570", Slot = "7")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D2")]
	public T FPGFCMMHMJG
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x5408790", Offset = "0x5407790", VA = "0x185408790")]
	public static NPMGGJIHKDI<T> IIJKJPIHGDF(T OHLIHBDBKCE)
	{
		return default(NPMGGJIHKDI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x54086D0", Offset = "0x54076D0", VA = "0x1854086D0")]
	public static NPMGGJIHKDI<T> ANFNACBHEOD(string JHEMEKBLBHP, string DOCGHMMILII = "")
	{
		return default(NPMGGJIHKDI<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[KGJMAOFDNAE]
public class MDPKOJIHEAN : JNFBFBMIKLM, MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170001D3")]
	public bool JPLAKFPJJKE
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xC649F0", Offset = "0xC639F0", VA = "0x180C649F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0xC648C0", Offset = "0xC638C0", VA = "0x180C648C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D4")]
	public string? FMNIANNOKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D5")]
	[DataMember(Name = "error_id")]
	public string? BGEBLMBMMJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "8")]
	public virtual void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x7197D00", Offset = "0x7196D00", VA = "0x187197D00")]
	public static MDPKOJIHEAN IIJKJPIHGDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x7197C70", Offset = "0x7196C70", VA = "0x187197C70")]
	public static MDPKOJIHEAN ANFNACBHEOD(string JHEMEKBLBHP, string DOCGHMMILII = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public MDPKOJIHEAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[NHFDOLIJPLM]
public abstract class OKKDFMAGFDP<T> : MDPKOJIHEAN, PADGCDDPPLM<T>, JNFBFBMIKLM
{
	[Cpp2IlInjected.Token(Token = "0x170001D6")]
	public T FPGFCMMHMJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0xDA98B0", Offset = "0xDA88B0", VA = "0x180DA98B0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0xA92FB0", Offset = "0xA91FB0", VA = "0x180A92FB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
	protected OKKDFMAGFDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[NHFDOLIJPLM]
public class LPHNAEFEAEB<T> : OKKDFMAGFDP<T>
{
	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x5136B60", Offset = "0x5135B60", VA = "0x185136B60")]
	private static void CLNMLGKPBBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x4487280", Offset = "0x4486280", VA = "0x184487280")]
	public LPHNAEFEAEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[NHFDOLIJPLM]
public class BBMBJJIMEEM<T> : OKKDFMAGFDP<T>, HADCGNIOBLA, MHLEMOAMOMP where T : MHLEMOAMOMP, new()
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private struct KOGACFDPKGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public BBMBJJIMEEM<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x4FF0120", Offset = "0x4FEF120", VA = "0x184FF0120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x4FF03A0", Offset = "0x4FEF3A0", VA = "0x184FF03A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x61AA2D0", Offset = "0x61A92D0", VA = "0x1861AA2D0", Slot = "8")]
	public override void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x61AA4C0", Offset = "0x61A94C0", VA = "0x1861AA4C0", Slot = "10")]
	[AsyncStateMachine(typeof(BBMBJJIMEEM<>.KOGACFDPKGH))]
	public Task PGKHKEHPKKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x61AA360", Offset = "0x61A9360", VA = "0x1861AA360")]
	public static BBMBJJIMEEM<T> IIJKJPIHGDF(T OHLIHBDBKCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x61AA170", Offset = "0x61A9170", VA = "0x1861AA170")]
	public new static BBMBJJIMEEM<T> ANFNACBHEOD(string JHEMEKBLBHP, string DOCGHMMILII = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x44B8A50", Offset = "0x44B7A50", VA = "0x1844B8A50")]
	public BBMBJJIMEEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[NHFDOLIJPLM]
public class GOGPAKPFOPC<T> : OKKDFMAGFDP<List<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x4487280", Offset = "0x4486280", VA = "0x184487280")]
	public GOGPAKPFOPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[NHFDOLIJPLM]
public class DEGJCEGDGEL<T> : OKKDFMAGFDP<List<T>>, HADCGNIOBLA, MHLEMOAMOMP where T : MHLEMOAMOMP, new()
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private struct PGFCIELCIJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public DEGJCEGDGEL<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x5608BC0", Offset = "0x5607BC0", VA = "0x185608BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x5608DD0", Offset = "0x5607DD0", VA = "0x185608DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x6A56000", Offset = "0x6A55000", VA = "0x186A56000")]
	public static DEGJCEGDGEL<T> IIJKJPIHGDF(List<T> OHLIHBDBKCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x6A55C20", Offset = "0x6A54C20", VA = "0x186A55C20")]
	public new static DEGJCEGDGEL<T> ANFNACBHEOD(string JHEMEKBLBHP, string DOCGHMMILII = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x6A55D80", Offset = "0x6A54D80", VA = "0x186A55D80", Slot = "8")]
	public override void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x6A56150", Offset = "0x6A55150", VA = "0x186A56150", Slot = "10")]
	[AsyncStateMachine(typeof(DEGJCEGDGEL<>.PGFCIELCIJE))]
	public Task PGKHKEHPKKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x4EE9E50", Offset = "0x4EE8E50", VA = "0x184EE9E50")]
	public DEGJCEGDGEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public enum MLOJOBKDNHB
{
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	AI,
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	Auth,
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	API,
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	Commerce,
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	Matchmaking,
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	Notifications,
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	Images,
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	CDN,
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	Storage,
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	Chat,
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	Leaderboard,
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	Accounts,
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	Link,
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	Lists,
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	RoomComments,
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	Clubs,
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	Rooms,
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	PlatformNotifications,
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	Moderation,
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	DataCollection,
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	BugReporting,
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	Discovery,
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	PlayerSettings,
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	Studio,
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	GameLogs,
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	Strings,
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	StringsCDN,
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	WWW,
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	Econ,
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	Data,
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	Cards
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public static class COFANCKLEAH
{
	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x7191730", Offset = "0x7190730", VA = "0x187191730")]
	public static bool CHGOOKFABIO(this MLOJOBKDNHB BEGHPONNAEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x7191730", Offset = "0x7190730", VA = "0x187191730")]
	public static bool HGLIDLKOCON(this MLOJOBKDNHB BEGHPONNAEO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public enum COAFHABICNE
{
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	Invalid = 0,
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	LaserTagTickets = 1,
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	RecCenterTokens = 2,
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	LostSkullsGold = 100,
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	DraculaSilver = 101,
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	RecRoyale_Season1 = 200,
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	RoomCurrency = 300,
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	RoomInventoryItem = 301,
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	ProgressionEvent = 400
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public enum ENBJEHKMOJF
{
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	NonPurchasedNotUsableInP2P = -2,
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	NonPurchasedDefault = -1,
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	SteamPurchased = 0,
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	OculusPurchased = 1,
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	PlayStationPurchased = 2,
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	MicrosoftPurchased = 3,
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	IOSPurchased = 5,
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	GooglePlayPurchased = 6,
	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	PicoPurchased = 8,
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	RecNetPurchased = 4,
	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	SwitchPurchased = 9,
	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	[Obsolete("Subscription benefits for PS4 players were awarded with this balance type. It is not transferrable to other platforms. Usable in P2P economy. We are using PlayStationPurchased instead now. -- bilal - 11/11/2020")]
	PlayStationNonPurchasedP2P = 100,
	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	[Obsolete("Subscription benefits for NON PS4 players were awarded with this balance type. We are using <PlatformType>Purchased instead now. -- bilal - 11/11/2020")]
	NonPlayStationNonPurchasedP2P = 101,
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	NonPurchasedEarnedByP2P = 1000,
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	NonPurchasedEarnedByP2Pv2 = 1001
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public enum IPAJFKBAJFI
{
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	First_Activity = 1,
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	Game_Drop = 2,
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	All_Daily_Challenges_Complete = 3,
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	All_Weekly_Challenge_Complete = 4,
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	Daily_Challenge_Complete = 5,
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	Weekly_Challenge_Complete = 6,
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	Unassigned_Equipment = 10,
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	Unassigned_Avatar = 11,
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	Unassigned_Consumable = 12,
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	Reacquisition = 20,
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	Membership = 21,
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	NUX_TokensAndDressUp = 30,
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	NUX_Experiment1 = 31,
	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	NUX_Experiment2 = 32,
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	NUX_Experiment3 = 33,
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	NUX_Experiment4 = 34,
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	NUX_Experiment5 = 35,
	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	GameRewards = 50,
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	GameRewards_Tokens = 51,
	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	GameRewards_Tokens_Experiment_Override = 52,
	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	GameRewards_A = 53,
	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	GameRewards_B = 54,
	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	LevelUp = 100,
	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	Purchased_Gift_A = 500,
	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	Purchased_Gift_B = 501,
	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	Purchased_Gift_C = 502,
	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	Purchased_Gift_D = 503,
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	Holiday = 1000,
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	Contest = 1001,
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	Promotion = 1002,
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	LimitedTime = 1003,
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	LimitedTimeEvent = 1004,
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	Deprecated = 1100,
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	RecRoyale = 1200,
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	Friendotron_Gift = 1300,
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	DEPRECATED_Paintball_ClearCut = 2000,
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	DEPRECATED_Paintball_Homestead = 2001,
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	DEPRECATED_Paintball_Quarry = 2002,
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	DEPRECATED_Paintball_River = 2003,
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	DEPRECATED_Paintball_Dam = 2004,
	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	DEPRECATED_Paintball_DriveIn = 2005,
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	Paintball_ClearCut = 2010,
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	Paintball_Homestead = 2011,
	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	Paintball_Quarry = 2012,
	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	Paintball_River = 2013,
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	Paintball_Dam = 2014,
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	Paintball_DriveIn = 2015,
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	DEPRECATED_Discgolf_Propulsion = 3000,
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	DEPRECATED_Discgolf_Lake = 3001,
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	Discgolf_Propulsion = 3010,
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	Discgolf_Lake = 3011,
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	Discgolf_Mode_CoopCatch = 3500,
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	Quest_Goblin_A = 4000,
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	Quest_Goblin_B = 4001,
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	Quest_Goblin_C = 4002,
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	Quest_Goblin_S = 4003,
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	Quest_Goblin_Consumable = 4004,
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	Quest_Cauldron_A = 4010,
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	Quest_Cauldron_B = 4011,
	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	Quest_Cauldron_C = 4012,
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	Quest_Cauldron_S = 4013,
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	Quest_Cauldron_Consumable = 4014,
	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	Quest_Pirate1_A = 4100,
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	Quest_Pirate1_B = 4101,
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	Quest_Pirate1_C = 4102,
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	Quest_Pirate1_S = 4103,
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	Quest_Pirate1_X = 4104,
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	Quest_Pirate1_Consumable = 4105,
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	Quest_Dracula1_A = 4200,
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	Quest_Dracula1_B = 4201,
	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	Quest_Dracula1_C = 4202,
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	Quest_Dracula1_S = 4203,
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	Quest_Dracula1_X = 4204,
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	Quest_Dracula1_Consumable = 4205,
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	Quest_Dracula1_SS = 4206,
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	Quest_SciFi_A = 4500,
	[Cpp2IlInjected.Token(Token = "0x4000303")]
	Quest_SciFi_B = 4501,
	[Cpp2IlInjected.Token(Token = "0x4000304")]
	Quest_SciFi_C = 4502,
	[Cpp2IlInjected.Token(Token = "0x4000305")]
	Quest_SciFi_S = 4503,
	[Cpp2IlInjected.Token(Token = "0x4000306")]
	Quest_Scifi_Consumable = 4504,
	[Cpp2IlInjected.Token(Token = "0x4000307")]
	DEPRECATED_Charades = 5000,
	[Cpp2IlInjected.Token(Token = "0x4000308")]
	Charades = 5001,
	[Cpp2IlInjected.Token(Token = "0x4000309")]
	DEPRECATED_Soccer = 6000,
	[Cpp2IlInjected.Token(Token = "0x400030A")]
	Soccer = 6001,
	[Cpp2IlInjected.Token(Token = "0x400030B")]
	DEPRECATED_Paddleball = 7000,
	[Cpp2IlInjected.Token(Token = "0x400030C")]
	Paddleball = 7001,
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	DEPRECATED_Dodgeball = 8000,
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	Dodgeball = 8001,
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	DEPRECATED_Lasertag = 9000,
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	Lasertag = 9001,
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	DEPRECATED_Bowling = 10000,
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	Bowling = 10001,
	[Cpp2IlInjected.Token(Token = "0x4000313")]
	StuntRunner_TheMainEvent_A = 11000,
	[Cpp2IlInjected.Token(Token = "0x4000314")]
	StuntRunner_TheMainEvent_B = 11001,
	[Cpp2IlInjected.Token(Token = "0x4000315")]
	StuntRunner_TheMainEvent_C = 11002,
	[Cpp2IlInjected.Token(Token = "0x4000316")]
	StuntRunner_TheMainEvent_D = 11003,
	[Cpp2IlInjected.Token(Token = "0x4000317")]
	StuntRunner_TheMainEvent_S = 11004,
	[Cpp2IlInjected.Token(Token = "0x4000318")]
	StuntRunner_TheMainEvent_X = 11005,
	[Cpp2IlInjected.Token(Token = "0x4000319")]
	StuntRunner_TheMainEvent_Consumable = 11006,
	[Cpp2IlInjected.Token(Token = "0x400031A")]
	StuntRunner_TheMainEvent_SS = 11007,
	[Cpp2IlInjected.Token(Token = "0x400031B")]
	RecRally = 12000,
	[Cpp2IlInjected.Token(Token = "0x400031C")]
	Showdown_A = 12100,
	[Cpp2IlInjected.Token(Token = "0x400031D")]
	Showdown_B = 12101,
	[Cpp2IlInjected.Token(Token = "0x400031E")]
	Showdown_C = 12102,
	[Cpp2IlInjected.Token(Token = "0x400031F")]
	MyLittleMonsters = 12200,
	[Cpp2IlInjected.Token(Token = "0x4000320")]
	RunTheBlock = 12300,
	[Cpp2IlInjected.Token(Token = "0x4000321")]
	RROStorefront_ToBeNamed_2 = 12400,
	[Cpp2IlInjected.Token(Token = "0x4000322")]
	ProgressionEvent = 13000,
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	Store_LaserTag = 100000,
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	Store_RecCenter = 100010,
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	Consumable = 110000,
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	Token = 110100,
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	Punchcard_Challenge_Complete = 110200,
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	All_Punchcard_Challenges_Complete = 110201,
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	New_Player_Checklist_Item_Complete = 110300,
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	Commerce_Purchase = 200000,
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	Gift_Card_Redemption = 210000
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public enum NGFKJBKJKIN
{
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	Common = 0,
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	Uncommon = 10,
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	Rare = 20,
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	Epic = 30,
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	Legendary = 50
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public enum LNDBPNALOAJ
{
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	OK,
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	TooManyRequests,
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	NotEnoughCredit,
	[Cpp2IlInjected.Token(Token = "0x4000337")]
	AlreadyOwned,
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	NoItemAvailable,
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	CouponNotApplicable,
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	RequestedPriceDoesNotMatch,
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	RequestedAmountNotAllowed,
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	PlayerNotEligible,
	[Cpp2IlInjected.Token(Token = "0x400033D")]
	RequestCannotBeRefunded,
	[Cpp2IlInjected.Token(Token = "0x400033E")]
	PlayerNotApproved
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[KGJMAOFDNAE]
	public class BalanceResponseDTO : MHLEMOAMOMP
	{
		[Cpp2IlInjected.Token(Token = "0x170001D7")]
		public long Balance
		{
			[Cpp2IlInjected.Token(Token = "0x600043F")]
			[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000440")]
			[Cpp2IlInjected.Address(RVA = "0xCF3540", Offset = "0xCF2540", VA = "0x180CF3540")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D8")]
		public COAFHABICNE CurrencyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000441")]
			[Cpp2IlInjected.Address(RVA = "0x9F32A0", Offset = "0x9F22A0", VA = "0x1809F32A0")]
			[CompilerGenerated]
			get
			{
				return default(COAFHABICNE);
			}
			[Cpp2IlInjected.Token(Token = "0x6000442")]
			[Cpp2IlInjected.Address(RVA = "0x9F3290", Offset = "0x9F2290", VA = "0x1809F3290")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D9")]
		[DataMember(Name = "Platform")]
		public ENBJEHKMOJF BalanceType
		{
			[Cpp2IlInjected.Token(Token = "0x6000443")]
			[Cpp2IlInjected.Address(RVA = "0xA18A40", Offset = "0xA17A40", VA = "0x180A18A40")]
			[CompilerGenerated]
			get
			{
				return default(ENBJEHKMOJF);
			}
			[Cpp2IlInjected.Token(Token = "0x6000444")]
			[Cpp2IlInjected.Address(RVA = "0xD541A0", Offset = "0xD531A0", VA = "0x180D541A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
		public virtual void FOGENAANJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public BalanceResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[KGJMAOFDNAE]
	public class FilteredTextDTO : MHLEMOAMOMP
	{
		[Cpp2IlInjected.Token(Token = "0x170001DA")]
		public string KNHBLAEFJHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000447")]
			[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000448")]
			[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DB")]
		public int AMIMCOABLJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000449")]
			[Cpp2IlInjected.Address(RVA = "0x9F32A0", Offset = "0x9F22A0", VA = "0x1809F32A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0x9F3290", Offset = "0x9F2290", VA = "0x1809F3290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
		public void FOGENAANJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public FilteredTextDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[KGJMAOFDNAE]
public class DBFOCDHPDNL : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170001DC")]
	public string ADNBFJBNKMC
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DD")]
	public string AKHCLEMCFHD
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public DBFOCDHPDNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[KGJMAOFDNAE]
public class KOOBFFMABND : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170001DE")]
	public List<DBFOCDHPDNL> LJHHLMOEBHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public KOOBFFMABND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[KGJMAOFDNAE]
public class CCIKHOCIHFN : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170001DF")]
	public string FECNNIONHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x9FE6D0", Offset = "0x9FD6D0", VA = "0x1809FE6D0")]
	public CCIKHOCIHFN(string PCGODPPEEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[KGJMAOFDNAE]
public class KFPCNBPFNEI : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170001E0")]
	public List<DBFOCDHPDNL> LJHHLMOEBHH
	{
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public KFPCNBPFNEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[KGJMAOFDNAE]
public class FPBIDMIFHHI : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170001E1")]
	public List<CCIKHOCIHFN> AFMBHLJAIAP
	{
		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E2")]
	public string IJLGNAMOBLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E3")]
	public bool IFPBODAFCCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x9F1560", Offset = "0x9F0560", VA = "0x1809F1560")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x9F1530", Offset = "0x9F0530", VA = "0x1809F1530")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E4")]
	public int CFKMKPGJDKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0xCFC9B0", Offset = "0xCFB9B0", VA = "0x180CFC9B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0xF0C6F0", Offset = "0xF0B6F0", VA = "0x180F0C6F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public FPBIDMIFHHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x7193030", Offset = "0x7192030", VA = "0x187193030")]
	public FPBIDMIFHHI(string IMMCNGPOMNH, List<CCIKHOCIHFN> CDPALGEMJCK, bool JLGICOENDFB, int LLLNDHJJMGP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[KGJMAOFDNAE]
public class IKBBJGPKKDL : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170001E5")]
	public List<KFPCNBPFNEI> AAKKEJMNPBE
	{
		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E6")]
	public bool IFPBODAFCCC
	{
		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0xAA5F80", Offset = "0xAA4F80", VA = "0x180AA5F80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x9FA1F0", Offset = "0x9F91F0", VA = "0x1809FA1F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public IKBBJGPKKDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[KGJMAOFDNAE]
public class PLJDCCENOPO : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public enum BFLPOHOBAHL
	{
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		EnqueuedPending,
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		DequeuedStarting,
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		CompleteSuccess
	}

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public const string NIMAPEEDKOM = "StringAutoLocalizationJob";

	[Cpp2IlInjected.Token(Token = "0x170001E7")]
	public string IJLGNAMOBLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E8")]
	public BFLPOHOBAHL CKMENNJIKOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x9F32A0", Offset = "0x9F22A0", VA = "0x1809F32A0")]
		[CompilerGenerated]
		get
		{
			return default(BFLPOHOBAHL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x9F3290", Offset = "0x9F2290", VA = "0x1809F3290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x7199130", Offset = "0x7198130", VA = "0x187199130")]
	public PLJDCCENOPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x71990E0", Offset = "0x71980E0", VA = "0x1871990E0")]
	public PLJDCCENOPO(string IMMCNGPOMNH, BFLPOHOBAHL PJPCILIKLGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[KGJMAOFDNAE]
public class KFLMEHKALKM : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170001E9")]
	public bool OPDOKEKIOGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0xC649F0", Offset = "0xC639F0", VA = "0x180C649F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0xC648C0", Offset = "0xC638C0", VA = "0x180C648C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public KFLMEHKALKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public static class FDJLKDLAMMF
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public enum IAAEJFMKBFM
	{
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		CoC_Discriminatory,
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		CoC_Sexual,
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		CoC_Trolling,
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		Misleading,
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		Other,
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		InappropriateClothing
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[KGJMAOFDNAE]
public class HENJIKJCDIM : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170001EA")]
	public long BJFFDFGEMMF
	{
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0xCF3540", Offset = "0xCF2540", VA = "0x180CF3540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001EB")]
	public Guid ILLPHDAEAEN
	{
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0xBFFAA0", Offset = "0xBFEAA0", VA = "0x180BFFAA0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0xDB9A10", Offset = "0xDB8A10", VA = "0x180DB9A10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001EC")]
	public long BKBODBHPALJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x9F1790", Offset = "0x9F0790", VA = "0x1809F1790")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001ED")]
	public LLPFEKMCAFA CEBJFKOAOGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F22B0", VA = "0x1809F32B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public HENJIKJCDIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x7194290", Offset = "0x7193290", VA = "0x187194290")]
	public HENJIKJCDIM(long CINEDGEJAIA, Guid GCPABOHEHBJ, long GFNDILIHOFK, LLPFEKMCAFA HBDOGANPNEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x7194270", Offset = "0x7193270", VA = "0x187194270", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[KGJMAOFDNAE]
public class PDCJOEIFKPI : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170001EE")]
	public MFEBDNMCCIM CIJAJIIDNCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(MFEBDNMCCIM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D30", Offset = "0x9EFD30", VA = "0x1809F0D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001EF")]
	public AOLCJDKHAPO HJAEAMNIHDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public PDCJOEIFKPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0xEAD600", Offset = "0xEAC600", VA = "0x180EAD600")]
	public PDCJOEIFKPI(MFEBDNMCCIM OBOOAPELMPF, AOLCJDKHAPO JOGAAHCGFLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[KGJMAOFDNAE]
public class LLPFEKMCAFA : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170001F0")]
	public Guid? FKLPDLPILFG
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x2DBC9E0", Offset = "0x2DBB9E0", VA = "0x182DBC9E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x7197610", Offset = "0x7196610", VA = "0x187197610")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001F1")]
	public Guid MGBHGNBHKDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0xCFC9D0", Offset = "0xCFB9D0", VA = "0x180CFC9D0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0xF26B40", Offset = "0xF25B40", VA = "0x180F26B40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public LLPFEKMCAFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x7197620", Offset = "0x7196620", VA = "0x187197620")]
	public LLPFEKMCAFA(Guid? ANJBPBOPKKL, Guid JLOCCHKBGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[KGJMAOFDNAE]
public class AOLCJDKHAPO : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170001F2")]
	public long BJFFDFGEMMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0xCF3540", Offset = "0xCF2540", VA = "0x180CF3540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001F3")]
	public Guid ILLPHDAEAEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0xBFFAA0", Offset = "0xBFEAA0", VA = "0x180BFFAA0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0xDB9A10", Offset = "0xDB8A10", VA = "0x180DB9A10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001F4")]
	public long CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x9F1790", Offset = "0x9F0790", VA = "0x1809F1790")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001F5")]
	public Guid LPENJNOHPFG
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0xDBD010", Offset = "0xDBC010", VA = "0x180DBD010")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0xDBC840", Offset = "0xDBB840", VA = "0x180DBC840")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001F6")]
	public DateTime HLEKPMBEFEF
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x9F6810", Offset = "0x9F5810", VA = "0x1809F6810")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0xE16A00", Offset = "0xE15A00", VA = "0x180E16A00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001F7")]
	public DateTime GJGOMALEFKE
	{
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x9F17A0", Offset = "0x9F07A0", VA = "0x1809F17A0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x6EC77B0", Offset = "0x6EC67B0", VA = "0x186EC77B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public AOLCJDKHAPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[KGJMAOFDNAE]
public class LBPKMPNHPIM : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170001F8")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001F9")]
	public string BPBACGJDGJI
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001FA")]
	public string PNHKFKCEKNC
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001FB")]
	public List<long> GANFANEEDMP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x9F5A20", Offset = "0x9F4A20", VA = "0x1809F5A20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001FC")]
	public List<PAMGBGGCNEB> IJEDNGOMPCG
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F22B0", VA = "0x1809F32B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001FD")]
	public string CDFPJGOFFGL
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x9F1780", Offset = "0x9F0780", VA = "0x1809F1780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x9F1770", Offset = "0x9F0770", VA = "0x1809F1770")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001FE")]
	public byte? OIJHMBNJPML
	{
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x7196720", Offset = "0x7195720", VA = "0x187196720")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x7196710", Offset = "0x7195710", VA = "0x187196710")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001FF")]
	public int? OCFGLAAIOOO
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x7191ED0", Offset = "0x7190ED0", VA = "0x187191ED0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x7191EC0", Offset = "0x7190EC0", VA = "0x187191EC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000200")]
	public Guid? EJGKABCGLBF
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x7196730", Offset = "0x7195730", VA = "0x187196730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x7196750", Offset = "0x7195750", VA = "0x187196750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000201")]
	public bool ANBKOOJICFP
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x9FACA0", Offset = "0x9F9CA0", VA = "0x1809FACA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x9FAC90", Offset = "0x9F9C90", VA = "0x1809FAC90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public LBPKMPNHPIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[KGJMAOFDNAE]
public class NAHKCOBJMOP : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000202")]
	public Guid EJGKABCGLBF
	{
		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0xF79DC0", Offset = "0xF78DC0", VA = "0x180F79DC0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0xF79DB0", Offset = "0xF78DB0", VA = "0x180F79DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000203")]
	public long BJFFDFGEMMF
	{
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0xC8C980", Offset = "0xC8B980", VA = "0x180C8C980")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000204")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x9F5A20", Offset = "0x9F4A20", VA = "0x1809F5A20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000205")]
	public string BPBACGJDGJI
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F22B0", VA = "0x1809F32B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000206")]
	public string PNHKFKCEKNC
	{
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x9F1780", Offset = "0x9F0780", VA = "0x1809F1780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x9F1770", Offset = "0x9F0770", VA = "0x1809F1770")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000207")]
	public DateTime HLEKPMBEFEF
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x9F6810", Offset = "0x9F5810", VA = "0x1809F6810")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0xE16A00", Offset = "0xE15A00", VA = "0x180E16A00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000208")]
	public DateTime GJGOMALEFKE
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x9F17A0", Offset = "0x9F07A0", VA = "0x1809F17A0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x6EC77B0", Offset = "0x6EC67B0", VA = "0x186EC77B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000209")]
	public string CDFPJGOFFGL
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x9F4700", Offset = "0x9F3700", VA = "0x1809F4700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x9F46E0", Offset = "0x9F36E0", VA = "0x1809F46E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700020A")]
	public List<long> GANFANEEDMP
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x9F4710", Offset = "0x9F3710", VA = "0x1809F4710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x9F46D0", Offset = "0x9F36D0", VA = "0x1809F46D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700020B")]
	public List<HKDBDNMIAHA> IJEDNGOMPCG
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x9F46F0", Offset = "0x9F36F0", VA = "0x1809F46F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x9F46C0", Offset = "0x9F36C0", VA = "0x1809F46C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700020C")]
	public byte OIJHMBNJPML
	{
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0xD02210", Offset = "0xD01210", VA = "0x180D02210")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x1212180", Offset = "0x1211180", VA = "0x181212180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700020D")]
	public int OCFGLAAIOOO
	{
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0xA26A10", Offset = "0xA25A10", VA = "0x180A26A10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x12E4C70", Offset = "0x12E3C70", VA = "0x1812E4C70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public NAHKCOBJMOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public enum MFEBDNMCCIM
{
	[Cpp2IlInjected.Token(Token = "0x4000383")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x4000384")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000385")]
	RoomInventoryItemDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x4000386")]
	PlayerDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x4000387")]
	RoomDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x4000388")]
	RequestQuantityTooLarge,
	[Cpp2IlInjected.Token(Token = "0x4000389")]
	PlayerHasReachedTheMinimumOwnedAmount,
	[Cpp2IlInjected.Token(Token = "0x400038A")]
	ConcurrencyCodeMismatch,
	[Cpp2IlInjected.Token(Token = "0x400038B")]
	InvalidConcurrencyCode
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public interface KIBFFJKINMA
{
	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OKKDFMAGFDP<NAHKCOBJMOP>> MEMDAIDDBGB(Guid? LBDJDJIFMMO, long CINEDGEJAIA, string NFHOBPDKIPM, string HHPFBMBMELN, string PCHIHCHIMHB, string NOLCGMINIOC, byte HIECCNNOPLP, int NGGKCKILBNF, [Optional] List<long> FNAGIFOGJOE, [Optional] List<HKDBDNMIAHA> HLMEELBCLMF, bool NHLBKAEBPKA = false, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<OKKDFMAGFDP<NAHKCOBJMOP>> BJBHJOGMKDI(Guid GCPABOHEHBJ, long CINEDGEJAIA, [Optional] string NFHOBPDKIPM, [Optional] string HHPFBMBMELN, [Optional] string PCHIHCHIMHB, [Optional] List<long> FNAGIFOGJOE, [Optional] Dictionary<string, string> HLMEELBCLMF, [Optional] string NOLCGMINIOC, [Optional] byte? HIECCNNOPLP, [Optional] int? NGGKCKILBNF, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<MDPKOJIHEAN> ELAEIOLHINB(Guid GCPABOHEHBJ, long CINEDGEJAIA, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<List<NAHKCOBJMOP>> HGFOEGAALKJ(long CINEDGEJAIA, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<List<AOLCJDKHAPO>> LMCBPIIJKEO(long CINEDGEJAIA, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<List<PDCJOEIFKPI>> ALNACKNNHJI(long CINEDGEJAIA, List<HENJIKJCDIM> NNFECOKKCKG, [Optional] CancellationToken CBJPDIFOEKF);
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[KGJMAOFDNAE]
public class PAMGBGGCNEB : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x1700020E")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700020F")]
	public string CDFPJGOFFGL
	{
		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public PAMGBGGCNEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[KGJMAOFDNAE]
public class HKDBDNMIAHA : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000210")]
	public long LGADKPMDFMA
	{
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0xCF3540", Offset = "0xCF2540", VA = "0x180CF3540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000211")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000212")]
	public string CDFPJGOFFGL
	{
		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public HKDBDNMIAHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[KGJMAOFDNAE]
public class KCDNBFAMPMM : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000213")]
	public long LGADKPMDFMA
	{
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0xCF3540", Offset = "0xCF2540", VA = "0x180CF3540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000214")]
	public string CDFPJGOFFGL
	{
		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x48D0690", Offset = "0x48CF690", VA = "0x1848D0690")]
	public KCDNBFAMPMM(long HJPBKGBOCJN, string FBEFHOGBKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public interface DFCGDGCKGFF
{
	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OKKDFMAGFDP<List<HKDBDNMIAHA>>> OHGMEGBHLPA(long CINEDGEJAIA, List<KCDNBFAMPMM> NNFECOKKCKG, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<MDPKOJIHEAN> JKFODGKEBMG(long HJPBKGBOCJN, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<List<HKDBDNMIAHA>> GIFIPLCJJDM(long CINEDGEJAIA, [Optional] CancellationToken CBJPDIFOEKF);
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[KGJMAOFDNAE]
public class KHDEJMAKAOC : KEGPDCCONLK, IEquatable<KHDEJMAKAOC>
{
	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x7196380", Offset = "0x7195380", VA = "0x187196380", Slot = "7")]
	public bool Equals(KHDEJMAKAOC MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x71964B0", Offset = "0x71954B0", VA = "0x1871964B0", Slot = "6")]
	public override KEGPDCCONLK OKKBPPIELHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public KHDEJMAKAOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public static class HMHPAMPBGMF
{
	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x7194360", Offset = "0x7193360", VA = "0x187194360")]
	public static KHDEJMAKAOC FPFIMAEMPOF(this ENODKHBAMBO HOJKNIMMINF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x71943D0", Offset = "0x71933D0", VA = "0x1871943D0")]
	public static KHDEJMAKAOC IFOLFJOHHKB(string PGAKCPFNKFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
[KGJMAOFDNAE]
public class ENODKHBAMBO : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public const int FDFBCFDGDBP = 3;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public const int PCPNIPPGMEP = 40;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public const int PJANKBFCOIJ = 180;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public const int KLDDHDPJICC = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public const int OLBMEPEJLGH = 99999;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public const int MLNBBILJGIH = 8;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public const int OLDKLELICFP = 1;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public const int BGMEJPNNOJO = 1000000000;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public const int EGEKNNNBDAK = 9999;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	[IgnoreDataMember]
	private IReadOnlyDictionary<Guid, int>? ONDPIGFLLMI;

	[Cpp2IlInjected.Token(Token = "0x17000215")]
	public Guid EJGKABCGLBF
	{
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0xF79DC0", Offset = "0xF78DC0", VA = "0x180F79DC0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0xF79DB0", Offset = "0xF78DB0", VA = "0x180F79DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000216")]
	public long BJFFDFGEMMF
	{
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0xC8C980", Offset = "0xC8B980", VA = "0x180C8C980")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000217")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x9F5A20", Offset = "0x9F4A20", VA = "0x1809F5A20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000218")]
	public string? BPBACGJDGJI
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F22B0", VA = "0x1809F32B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000219")]
	public string? PNHKFKCEKNC
	{
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x9F1780", Offset = "0x9F0780", VA = "0x1809F1780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x9F1770", Offset = "0x9F0770", VA = "0x1809F1770")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021A")]
	public int DFMBJPCDEPP
	{
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0xA00120", Offset = "0x9FF120", VA = "0x180A00120")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0xE04AF0", Offset = "0xE03AF0", VA = "0x180E04AF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021B")]
	public Guid? FLGLFGFONKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x7192530", Offset = "0x7191530", VA = "0x187192530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x7192520", Offset = "0x7191520", VA = "0x187192520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021C")]
	public int IDOBOHLCCAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0xD62EF0", Offset = "0xD61EF0", VA = "0x180D62EF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0xD62EE0", Offset = "0xD61EE0", VA = "0x180D62EE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021D")]
	public int? GDNNGMOHMDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x6BA9B10", Offset = "0x6BA8B10", VA = "0x186BA9B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x6BA9B30", Offset = "0x6BA8B30", VA = "0x186BA9B30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021E")]
	public int? KACEGKAACEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x7192550", Offset = "0x7191550", VA = "0x187192550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x7192150", Offset = "0x7191150", VA = "0x187192150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021F")]
	public IReadOnlyList<ECNEMCKPFCK> IGKHLLEFMFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CE0", Offset = "0x9F3CE0", VA = "0x1809F4CE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CC0", Offset = "0x9F3CC0", VA = "0x1809F4CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000220")]
	public DateTime HLEKPMBEFEF
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x9F9180", Offset = "0x9F8180", VA = "0x1809F9180")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0xE30D00", Offset = "0xE2FD00", VA = "0x180E30D00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000221")]
	public DateTime GJGOMALEFKE
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x9F90F0", Offset = "0x9F80F0", VA = "0x1809F90F0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0xE31050", Offset = "0xE30050", VA = "0x180E31050")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000222")]
	[IgnoreDataMember]
	public LBKMNBNEGGK KHACGJDONCO
	{
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x7192170", Offset = "0x7191170", VA = "0x187192170")]
		get
		{
			return default(LBKMNBNEGGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000223")]
	[IgnoreDataMember]
	public IReadOnlyDictionary<Guid, int> ABNHEMBPOAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x7192100", Offset = "0x7191100", VA = "0x187192100")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x9F8FF0", Offset = "0x9F7FF0", VA = "0x1809F8FF0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x7192160", Offset = "0x7191160", VA = "0x187192160", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public ENODKHBAMBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x7192560", Offset = "0x7191560", VA = "0x187192560")]
	public ENODKHBAMBO(Guid LBDJDJIFMMO, long CINEDGEJAIA, string NFHOBPDKIPM, string HHPFBMBMELN, string PCHIHCHIMHB, int NBDBEANPNJP, int? FENKFHBMCEE, int? GCBMCFGOEPN, List<ECNEMCKPFCK> ABNJJLEHKMC, [Optional] DateTime IPOPOEOJDBB, [Optional] DateTime FMICMNKNFFM, [Optional] Guid? DABAMLICNDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x71924B0", Offset = "0x71914B0", VA = "0x1871924B0")]
	private LBKMNBNEGGK JAPHJFELOCD()
	{
		return default(LBKMNBNEGGK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x71921E0", Offset = "0x71911E0", VA = "0x1871921E0")]
	private Dictionary<Guid, int> IJCBGHMJIPC(IReadOnlyList<ECNEMCKPFCK> ABNJJLEHKMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[KGJMAOFDNAE]
public class NDNFMOBEGDM : MHLEMOAMOMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public Guid EJGKABCGLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public long BJFFDFGEMMF;

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public NDNFMOBEGDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[KGJMAOFDNAE]
public class BGLAHANGAJA : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000224")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000225")]
	public string? BPBACGJDGJI
	{
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000226")]
	public string? PNHKFKCEKNC
	{
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000227")]
	public int DFMBJPCDEPP
	{
		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x9F0C90", Offset = "0x9EFC90", VA = "0x1809F0C90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CE0", Offset = "0x9EFCE0", VA = "0x1809F0CE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000228")]
	public int? GDNNGMOHMDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0xEC4450", Offset = "0xEC3450", VA = "0x180EC4450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0xEC4480", Offset = "0xEC3480", VA = "0x180EC4480")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000229")]
	public int? KACEGKAACEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0xC8C950", Offset = "0xC8B950", VA = "0x180C8C950")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0xC8C9A0", Offset = "0xC8B9A0", VA = "0x180C8C9A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022A")]
	public List<ECNEMCKPFCK> IGKHLLEFMFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x9F6810", Offset = "0x9F5810", VA = "0x1809F6810")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x9F1580", Offset = "0x9F0580", VA = "0x1809F1580")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022B")]
	public Guid? AGONOIKDIFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x7190180", Offset = "0x718F180", VA = "0x187190180")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x7190170", Offset = "0x718F170", VA = "0x187190170")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022C")]
	public Guid? EJGKABCGLBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x7190EE0", Offset = "0x718FEE0", VA = "0x187190EE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x7190F00", Offset = "0x718FF00", VA = "0x187190F00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022D")]
	public bool ANBKOOJICFP
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0xD02200", Offset = "0xD01200", VA = "0x180D02200")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x13FC510", Offset = "0x13FB510", VA = "0x1813FC510")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x7190ED0", Offset = "0x718FED0", VA = "0x187190ED0", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public BGLAHANGAJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[KGJMAOFDNAE]
public class ECNEMCKPFCK : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x1700022E")]
	public CEMHNBIBILO KPPMOCAOEMD
	{
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0xC649F0", Offset = "0xC639F0", VA = "0x180C649F0")]
		[CompilerGenerated]
		get
		{
			return default(CEMHNBIBILO);
		}
		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0xC648C0", Offset = "0xC638C0", VA = "0x180C648C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022F")]
	public Guid EKCPLOPLIAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x18A5DC0", Offset = "0x18A4DC0", VA = "0x1818A5DC0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x5844C60", Offset = "0x5843C60", VA = "0x185844C60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000230")]
	public int CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0xCFC9B0", Offset = "0xCFB9B0", VA = "0x180CFC9B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0xF0C6F0", Offset = "0xF0B6F0", VA = "0x180F0C6F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public ECNEMCKPFCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x7191AD0", Offset = "0x7190AD0", VA = "0x187191AD0")]
	public ECNEMCKPFCK(Guid FJMKDAIDLCG, CEMHNBIBILO MLCOGCMJLBB, int JAALIADHHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[KGJMAOFDNAE]
public class FPEDDFNDPOC : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000231")]
	public Guid PINHBFGJNJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0xF79DC0", Offset = "0xF78DC0", VA = "0x180F79DC0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0xF79DB0", Offset = "0xF78DB0", VA = "0x180F79DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000232")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000233")]
	public int DPEGLBCIGEO
	{
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x9F0C90", Offset = "0x9EFC90", VA = "0x1809F0C90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CE0", Offset = "0x9EFCE0", VA = "0x1809F0CE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000234")]
	public DateTime HFHBLLIHHCH
	{
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x9F1520", Offset = "0x9F0520", VA = "0x1809F1520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000235")]
	public int IDOBOHLCCAK
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0xA0E750", Offset = "0xA0D750", VA = "0x180A0E750")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0xD4F350", Offset = "0xD4E350", VA = "0x180D4F350")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x71930A0", Offset = "0x71920A0", VA = "0x1871930A0")]
	public FPEDDFNDPOC(Guid ACMIOGGCAFC, string NFHOBPDKIPM, int ICCLHCNGGKE, DateTime KPHHLDOPKCN, int DJNGLBELENN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public FPEDDFNDPOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[KGJMAOFDNAE]
public class BMIPONGKFFG : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000236")]
	public Guid PINHBFGJNJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0xF79DC0", Offset = "0xF78DC0", VA = "0x180F79DC0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0xF79DB0", Offset = "0xF78DB0", VA = "0x180F79DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000237")]
	public int CLMEBBPBOLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0xBEA640", Offset = "0xBE9640", VA = "0x180BEA640")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0xC64F60", Offset = "0xC63F60", VA = "0x180C64F60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public BMIPONGKFFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x4B23310", Offset = "0x4B22310", VA = "0x184B23310")]
	public BMIPONGKFFG(Guid ACMIOGGCAFC, int JBDHEJLKLPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[KGJMAOFDNAE]
public class JAIAAGECEBA : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000238")]
	public int CLMEBBPBOLH
	{
		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D30", Offset = "0x9EFD30", VA = "0x1809F0D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000239")]
	public Guid IMMDBMJFEAI
	{
		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x18A5DC0", Offset = "0x18A4DC0", VA = "0x1818A5DC0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x5844C60", Offset = "0x5843C60", VA = "0x185844C60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023A")]
	public int EEELOGDGPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0xCFC9B0", Offset = "0xCFB9B0", VA = "0x180CFC9B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0xF0C6F0", Offset = "0xF0B6F0", VA = "0x180F0C6F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023B")]
	public Guid? NGKJFHPADCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0xE3C570", Offset = "0xE3B570", VA = "0x180E3C570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x2174090", Offset = "0x2173090", VA = "0x182174090")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023C")]
	public int HILPHCEMOBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0xA0E760", Offset = "0xA0D760", VA = "0x180A0E760")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x1467920", Offset = "0x1466920", VA = "0x181467920")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023D")]
	public Dictionary<Guid, Guid?> IDFKGLAIELG
	{
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x9F6810", Offset = "0x9F5810", VA = "0x1809F6810")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x9F1580", Offset = "0x9F0580", VA = "0x1809F1580")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public JAIAAGECEBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x7195670", Offset = "0x7194670", VA = "0x187195670")]
	public JAIAAGECEBA(int JBDHEJLKLPP, Guid MADIDFMKIGI, int EINEBHDPMPB, Guid? MCFDCCNBJDI, int PFIIKHDBDDL, Dictionary<Guid, Guid?> DDFLCMACKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
[KGJMAOFDNAE]
public class JJGKBGIHCCM : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x1700023E")]
	public FFNCJAJHGHI OBPCBMKAENI
	{
		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0xC649F0", Offset = "0xC639F0", VA = "0x180C649F0")]
		[CompilerGenerated]
		get
		{
			return default(FFNCJAJHGHI);
		}
		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0xC648C0", Offset = "0xC638C0", VA = "0x180C648C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023F")]
	public LNDBPNALOAJ? DHOBHHFICOF
	{
		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0xEC43D0", Offset = "0xEC33D0", VA = "0x180EC43D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0xECD420", Offset = "0xECC420", VA = "0x180ECD420")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000240")]
	public BalanceResponseDTO CBNMHFPCHPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000241")]
	public List<AOLCJDKHAPO> EGCBAFLHJMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x9F5A20", Offset = "0x9F4A20", VA = "0x1809F5A20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public JJGKBGIHCCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x7195820", Offset = "0x7194820", VA = "0x187195820")]
	public JJGKBGIHCCM(FFNCJAJHGHI MHNLACILOFC, LNDBPNALOAJ? BJJCPOKICNF, BalanceResponseDTO GEBELIMGKPC, List<AOLCJDKHAPO> GNLBCGGIPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x7195810", Offset = "0x7194810", VA = "0x187195810", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public enum CEMHNBIBILO : byte
{
	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	Unset,
	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	RoomInventoryItem
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public enum FFNCJAJHGHI : byte
{
	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	Success = 0,
	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	ConcurrencyCodeMismatch = 1,
	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	RoomOfferDoesNotExist = 2,
	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	InvalidRequest = 3,
	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	AccountIdIsInvalid = 4,
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	PlayerIsP2PBuyingRestricted = 5,
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	ExpectedOfferTotalPriceMismatch = 6,
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	ExpectedOfferVersionMismatch = 7,
	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	InsufficientBalance = 8,
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	OfferUnderModeration = 9,
	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	InvalidExpectedTotalPrice = 10,
	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	InvalidExpectedOfferVersion = 11,
	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	CannotPurchaseMoreThanPerPlayerLimit = 12,
	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	InvalidExpectedPriceUnit = 13,
	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	InsufficientInventoryItems = 14,
	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	NoConcurrencyCodesForInventoryItem = 100,
	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	UnexpectedOfferItemType = 101,
	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	FeatureDisabled = 254,
	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	UnknownError = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public enum LBKMNBNEGGK : byte
{
	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	OneTimePurchase,
	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	BulkPurchase
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public interface AJCBKGPINID
{
	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	static NPNKPOOAOFG<ENODKHBAMBO> BOEDNFLINLO;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	static NPNKPOOAOFG<ENODKHBAMBO> HFIGBMIHKLC;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	static NPNKPOOAOFG<Guid> GGLCJMAOIMC;

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OKKDFMAGFDP<ENODKHBAMBO?>?>? MFGPBMLENDN(Guid? LBDJDJIFMMO, long CINEDGEJAIA, string NFHOBPDKIPM, string? HHPFBMBMELN, string? PCHIHCHIMHB, int NBDBEANPNJP, LBKMNBNEGGK NPCDGFOONOH, [Optional] Dictionary<Guid, int>? LFJOIJADHHP, [Optional] Guid? BEEIKGNACJP, bool NHLBKAEBPKA = false, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<OKKDFMAGFDP<ENODKHBAMBO?>?>? KHAGPLLNDAC(Guid ACMIOGGCAFC, long CINEDGEJAIA, string NFHOBPDKIPM, string? HHPFBMBMELN, string? PCHIHCHIMHB, int NBDBEANPNJP, LBKMNBNEGGK NPCDGFOONOH, [Optional] Dictionary<Guid, int>? LFJOIJADHHP, [Optional] Guid? BEEIKGNACJP, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<MDPKOJIHEAN> AMJDGFAMIKC(Guid ACMIOGGCAFC, long CINEDGEJAIA, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<List<ENODKHBAMBO>> FJKGKELNGNC(long CINEDGEJAIA, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<OKKDFMAGFDP<List<BMIPONGKFFG>>> HOCDLCOKGHO(long CINEDGEJAIA, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<OKKDFMAGFDP<List<FPEDDFNDPOC>>> HDMDJOECEJH(long CINEDGEJAIA, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<JJGKBGIHCCM> LMCLGPBEFBD(Guid ACMIOGGCAFC, long CINEDGEJAIA, int JBDHEJLKLPP, int EINEBHDPMPB, Guid? MCADMAJFPLF, int PFIIKHDBDDL, Dictionary<Guid, Guid?> FKMNMMFFPBL, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x718F830", Offset = "0x718E830", VA = "0x18718F830")]
	static AJCBKGPINID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
[KGJMAOFDNAE]
public class LNHNFGKPJHC : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000242")]
	public long BJFFDFGEMMF
	{
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0xCF3540", Offset = "0xCF2540", VA = "0x180CF3540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000243")]
	public bool EJECJELJAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0xAA5F80", Offset = "0xAA4F80", VA = "0x180AA5F80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x9FA1F0", Offset = "0x9F91F0", VA = "0x1809FA1F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public LNHNFGKPJHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public interface KAMAILPHFOH
{
	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LNHNFGKPJHC> CJAKGOOBKCL(long CINEDGEJAIA, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<MDPKOJIHEAN> JIAJFEKLGDF(long CINEDGEJAIA, bool KIOEPLCGDFB, [Optional] CancellationToken CBJPDIFOEKF);
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[NHFDOLIJPLM]
public class AFAFCGCCJFL<DataType> where DataType : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000244")]
	public long KLEDGCNLIMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0xCF3540", Offset = "0xCF2540", VA = "0x180CF3540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000245")]
	public COAFHABICNE HHNPLOFGEBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x9F32A0", Offset = "0x9F22A0", VA = "0x1809F32A0")]
		[CompilerGenerated]
		get
		{
			return default(COAFHABICNE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x9F3290", Offset = "0x9F2290", VA = "0x1809F3290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000246")]
	public ENBJEHKMOJF FOCHGGKBCJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0xA18A40", Offset = "0xA17A40", VA = "0x180A18A40")]
		[CompilerGenerated]
		get
		{
			return default(ENBJEHKMOJF);
		}
		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0xD541A0", Offset = "0xD531A0", VA = "0x180D541A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000247")]
	public DataType HCNIDPKECHH
	{
		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return (DataType)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public AFAFCGCCJFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[NHFDOLIJPLM]
public class FAAICHAJFEG<DataType> where DataType : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000248")]
	public long KLEDGCNLIMH
	{
		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0xCF3540", Offset = "0xCF2540", VA = "0x180CF3540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000249")]
	public COAFHABICNE HHNPLOFGEBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x9F32A0", Offset = "0x9F22A0", VA = "0x1809F32A0")]
		[CompilerGenerated]
		get
		{
			return default(COAFHABICNE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x9F3290", Offset = "0x9F2290", VA = "0x1809F3290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024A")]
	public ENBJEHKMOJF FOCHGGKBCJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0xA18A40", Offset = "0xA17A40", VA = "0x180A18A40")]
		[CompilerGenerated]
		get
		{
			return default(ENBJEHKMOJF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0xD541A0", Offset = "0xD531A0", VA = "0x180D541A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024B")]
	public List<DataType> HCNIDPKECHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public FAAICHAJFEG()
	{
	}
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[NHFDOLIJPLM]
	public class BalanceUpdateResponseDTO<DataTypeDTO> : BalanceResponseDTO where DataTypeDTO : MHLEMOAMOMP, new()
	{
		[Cpp2IlInjected.Token(Token = "0x20000D7")]
		[NHFDOLIJPLM]
		public class DCMOODBCEDF : HADCGNIOBLA, MHLEMOAMOMP
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000D8")]
			[CompilerGenerated]
			private struct JDFDOGJOBML : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003F5")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003F6")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003F7")]
				public DCMOODBCEDF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003F8")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000592")]
				[Cpp2IlInjected.Address(RVA = "0x4E26520", Offset = "0x4E25520", VA = "0x184E26520", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000593")]
				[Cpp2IlInjected.Address(RVA = "0x4E26800", Offset = "0x4E25800", VA = "0x184E26800", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700024D")]
			public LNDBPNALOAJ KHCENHMPCJE
			{
				[Cpp2IlInjected.Token(Token = "0x600058B")]
				[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0")]
				[CompilerGenerated]
				get
				{
					return default(LNDBPNALOAJ);
				}
				[Cpp2IlInjected.Token(Token = "0x600058C")]
				[Cpp2IlInjected.Address(RVA = "0x9F0D30", Offset = "0x9EFD30", VA = "0x1809F0D30")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700024E")]
			public DataTypeDTO HCNIDPKECHH
			{
				[Cpp2IlInjected.Token(Token = "0x600058D")]
				[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
				[CompilerGenerated]
				get
				{
					return (DataTypeDTO)null;
				}
				[Cpp2IlInjected.Token(Token = "0x600058E")]
				[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600058F")]
			[Cpp2IlInjected.Address(RVA = "0x6A52CA0", Offset = "0x6A51CA0", VA = "0x186A52CA0", Slot = "5")]
			public void FOGENAANJJN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000590")]
			[Cpp2IlInjected.Address(RVA = "0x6A52DA0", Offset = "0x6A51DA0", VA = "0x186A52DA0", Slot = "4")]
			[AsyncStateMachine(typeof(BalanceUpdateResponseDTO<>.DCMOODBCEDF.JDFDOGJOBML))]
			public Task PGKHKEHPKKI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000591")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public DCMOODBCEDF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024C")]
		public List<DCMOODBCEDF> BalanceUpdates
		{
			[Cpp2IlInjected.Token(Token = "0x6000587")]
			[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000588")]
			[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x565E460", Offset = "0x565D460", VA = "0x18565E460", Slot = "5")]
		public override void FOGENAANJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
		public BalanceUpdateResponseDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[NHFDOLIJPLM]
	public class PurchaseBalanceUpdateResponseDTO<DataTypeDTO> : BalanceResponseDTO where DataTypeDTO : MHLEMOAMOMP, new()
	{
		[Cpp2IlInjected.Token(Token = "0x20000DA")]
		[NHFDOLIJPLM]
		public class BOJNIBECDEI : HADCGNIOBLA, MHLEMOAMOMP
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000DB")]
			[CompilerGenerated]
			private struct LCFGFCFBKCN : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003FC")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003FD")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003FE")]
				public BOJNIBECDEI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003FF")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600059F")]
				[Cpp2IlInjected.Address(RVA = "0x50CF3C0", Offset = "0x50CE3C0", VA = "0x1850CF3C0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005A0")]
				[Cpp2IlInjected.Address(RVA = "0x50CF630", Offset = "0x50CE630", VA = "0x1850CF630", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000250")]
			public LNDBPNALOAJ KHCENHMPCJE
			{
				[Cpp2IlInjected.Token(Token = "0x6000598")]
				[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0")]
				[CompilerGenerated]
				get
				{
					return default(LNDBPNALOAJ);
				}
				[Cpp2IlInjected.Token(Token = "0x6000599")]
				[Cpp2IlInjected.Address(RVA = "0x9F0D30", Offset = "0x9EFD30", VA = "0x1809F0D30")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000251")]
			public List<DataTypeDTO> HCNIDPKECHH
			{
				[Cpp2IlInjected.Token(Token = "0x600059A")]
				[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600059B")]
				[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600059C")]
			[Cpp2IlInjected.Address(RVA = "0x63B2BD0", Offset = "0x63B1BD0", VA = "0x1863B2BD0", Slot = "5")]
			public void FOGENAANJJN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600059D")]
			[Cpp2IlInjected.Address(RVA = "0x63B2E70", Offset = "0x63B1E70", VA = "0x1863B2E70", Slot = "4")]
			[AsyncStateMachine(typeof(PurchaseBalanceUpdateResponseDTO<>.BOJNIBECDEI.LCFGFCFBKCN))]
			public Task PGKHKEHPKKI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600059E")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public BOJNIBECDEI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024F")]
		public List<BOJNIBECDEI> BalanceUpdates
		{
			[Cpp2IlInjected.Token(Token = "0x6000594")]
			[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000595")]
			[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x565E460", Offset = "0x565D460", VA = "0x18565E460", Slot = "5")]
		public override void FOGENAANJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
		public PurchaseBalanceUpdateResponseDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
[EHDNHPMPEGO]
public class GLNHGANNJCC : PurchaseBalanceUpdateResponseDTO<BAAIMDALMOP>
{
	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x7193F10", Offset = "0x7192F10", VA = "0x187193F10")]
	public GLNHGANNJCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
[EHDNHPMPEGO]
public class BHMFCOGJOFJ : PurchaseBalanceUpdateResponseDTO<BAAIMDALMOP>.BOJNIBECDEI
{
	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x7190F10", Offset = "0x718FF10", VA = "0x187190F10")]
	public BHMFCOGJOFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
[KGJMAOFDNAE]
public class BBECJNGCOMP : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000252")]
	public EPDOOECNGMH NHGMCBMLOHA
	{
		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000253")]
	public long PNCAEHGBKIG
	{
		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0xC5C130", Offset = "0xC5B130", VA = "0x180C5C130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000254")]
	public GiftItemDTO? NOLKNKICJGG
	{
		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000255")]
	public long? CGNJNDDBJBC
	{
		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x1286C40", Offset = "0x1285C40", VA = "0x181286C40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x1286C30", Offset = "0x1285C30", VA = "0x181286C30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000256")]
	public int CGEKPMCPFKN
	{
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0xA0E750", Offset = "0xA0D750", VA = "0x180A0E750")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0xD4F350", Offset = "0xD4E350", VA = "0x180D4F350")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x7190270", Offset = "0x718F270", VA = "0x187190270")]
	public BBECJNGCOMP(EPDOOECNGMH PEJCCPLAEAH, long GAFFJGMGEBD, GiftItemDTO? BMIKDHDIMIN, int BILIHFEFION = 1, [Optional] long? FNNPIONLMMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
[KGJMAOFDNAE]
public class PFAEBGPDKBN : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000257")]
	public List<BBECJNGCOMP> CCAFLAOJPKC
	{
		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000258")]
	public NDHNCEHANCH? NCJPFJDOOCK
	{
		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0xC5C130", Offset = "0xC5B130", VA = "0x180C5C130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000259")]
	public COAFHABICNE HHNPLOFGEBD
	{
		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0xBEA640", Offset = "0xBE9640", VA = "0x180BEA640")]
		[CompilerGenerated]
		get
		{
			return default(COAFHABICNE);
		}
		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0xC64F60", Offset = "0xC63F60", VA = "0x180C64F60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025A")]
	public bool OHOMMCMDHLG
	{
		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0xD07AC0", Offset = "0xD06AC0", VA = "0x180D07AC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0xD070C0", Offset = "0xD060C0", VA = "0x180D070C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025B")]
	public bool KJFPCCMAEBE
	{
		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x1342210", Offset = "0x1341210", VA = "0x181342210")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x262EE60", Offset = "0x262DE60", VA = "0x18262EE60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(RVA = "0x7198F40", Offset = "0x7197F40", VA = "0x187198F40")]
	public PFAEBGPDKBN(List<BBECJNGCOMP> LKJAGBDLHBA, NDHNCEHANCH? JLKOEGKPAAA, COAFHABICNE JIIJIDFJIGK, bool LAPONJDPKEK, bool KLCPALLGAMN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
[KGJMAOFDNAE]
public class GLJLLBFCNKJ : HADCGNIOBLA, MHLEMOAMOMP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[CompilerGenerated]
	private struct NKNMNFCLDMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public GLJLLBFCNKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x7198690", Offset = "0x7197690", VA = "0x187198690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x7198970", Offset = "0x7197970", VA = "0x187198970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	internal static Action<BAAIMDALMOP>? PFMBKLNGPLF;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	internal static Func<BAAIMDALMOP, Task>? AIPKKILGDOP;

	[Cpp2IlInjected.Token(Token = "0x1700025C")]
	public BAAIMDALMOP MJPJCLIEJCL
	{
		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025D")]
	public EHGDCJFOLHP? EABDGGDMKHH
	{
		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x7193D80", Offset = "0x7192D80", VA = "0x187193D80", Slot = "5")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x7193E40", Offset = "0x7192E40", VA = "0x187193E40", Slot = "6")]
	[AsyncStateMachine(typeof(NKNMNFCLDMH))]
	public virtual Task PGKHKEHPKKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public GLJLLBFCNKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
[EHDNHPMPEGO]
public class EDJEGAEANJC : BalanceUpdateResponseDTO<GLJLLBFCNKJ>
{
	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x7191B20", Offset = "0x7190B20", VA = "0x187191B20")]
	public EDJEGAEANJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
[EHDNHPMPEGO]
public class GLGGDJIBKGO : BalanceUpdateResponseDTO<GLJLLBFCNKJ>.DCMOODBCEDF
{
	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x7193D40", Offset = "0x7192D40", VA = "0x187193D40")]
	public GLGGDJIBKGO()
	{
	}
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	[KGJMAOFDNAE]
	public class GiftItemDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700025E")]
		public int ToPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C7")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D30", Offset = "0x9EFD30", VA = "0x1809F0D30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025F")]
		public string? Message
		{
			[Cpp2IlInjected.Token(Token = "0x60005C8")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005C9")]
			[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000260")]
		public bool Anonymous
		{
			[Cpp2IlInjected.Token(Token = "0x60005CA")]
			[Cpp2IlInjected.Address(RVA = "0x9F1560", Offset = "0x9F0560", VA = "0x1809F1560")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0x9F1530", Offset = "0x9F0530", VA = "0x1809F1530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000261")]
		public IPAJFKBAJFI GiftContext
		{
			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0xCFC9B0", Offset = "0xCFB9B0", VA = "0x180CFC9B0")]
			[CompilerGenerated]
			get
			{
				return default(IPAJFKBAJFI);
			}
			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0xF0C6F0", Offset = "0xF0B6F0", VA = "0x180F0C6F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public GiftItemDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
[KGJMAOFDNAE]
public class PIGJKMDEGFL : MHLEMOAMOMP, GBONMBHCOAE
{
	[Cpp2IlInjected.Token(Token = "0x17000262")]
	public MMOPDGKBAEH? BEDCKOANOKF
	{
		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000263")]
	[IgnoreDataMember]
	public Guid BJLCIJDDMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x7199060", Offset = "0x7198060", VA = "0x187199060", Slot = "5")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000264")]
	public EPDOOECNGMH? HAMALLJNAAE
	{
		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000265")]
	public List<PAMBPODMHLK>? IDIBNFCBPNO
	{
		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000266")]
	public DateTime? OLLPENDCGEC
	{
		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x1286C40", Offset = "0x1285C40", VA = "0x181286C40", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x1286C30", Offset = "0x1285C30", VA = "0x181286C30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000267")]
	public DateTime? MAHMPFMIFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x134D260", Offset = "0x134C260", VA = "0x18134D260", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x134F270", Offset = "0x134E270", VA = "0x18134F270")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000268")]
	public DateTime? BLDPNGBCHDH
	{
		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0xD021D0", Offset = "0xD011D0", VA = "0x180D021D0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x58413F0", Offset = "0x58403F0", VA = "0x1858413F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000269")]
	public bool AFHLPLGFLFH
	{
		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0xBF8AB0", Offset = "0xBF7AB0", VA = "0x180BF8AB0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0xBF8020", Offset = "0xBF7020", VA = "0x180BF8020")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026A")]
	public bool IGFMDEAIBBC
	{
		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x111F160", Offset = "0x111E160", VA = "0x18111F160")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x128DD90", Offset = "0x128CD90", VA = "0x18128DD90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026B")]
	public bool CKFBECEKPBI
	{
		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0xEA41A0", Offset = "0xEA31A0", VA = "0x180EA41A0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x1583640", Offset = "0x1582640", VA = "0x181583640")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026C")]
	public bool OCHOLGOLIHO
	{
		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0xE9F060", Offset = "0xE9E060", VA = "0x180E9F060", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0xEA3E20", Offset = "0xEA2E20", VA = "0x180EA3E20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x7198FB0", Offset = "0x7197FB0", VA = "0x187198FB0")]
	public static PIGJKMDEGFL EEGEDHEGIMA(Guid DGPIPOJOJGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public PIGJKMDEGFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
[KGJMAOFDNAE]
public class HJNGBICMFAI
{
	[Cpp2IlInjected.Token(Token = "0x1700026D")]
	public int IDOBOHLCCAK
	{
		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D30", Offset = "0x9EFD30", VA = "0x1809F0D30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026E")]
	public string HPKGABDCMBH
	{
		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026F")]
	public string CICDEPBHJCD
	{
		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000270")]
	public Dictionary<int, FKFJEBFACDM> LFDKECOFCLK
	{
		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x9F5A20", Offset = "0x9F4A20", VA = "0x1809F5A20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000271")]
	public Dictionary<string, int> BFKCOFHKCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F22B0", VA = "0x1809F32B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000272")]
	public Dictionary<EKMFBCAKACJ, List<int>> EEDPNIHOGAK
	{
		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x9F1780", Offset = "0x9F0780", VA = "0x1809F1780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x9F1770", Offset = "0x9F0770", VA = "0x1809F1770")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000273")]
	public Dictionary<string, string> OEEAHJGEMOM
	{
		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x9F6810", Offset = "0x9F5810", VA = "0x1809F6810")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x9F1580", Offset = "0x9F0580", VA = "0x1809F1580")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public HJNGBICMFAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public enum EKMFBCAKACJ
{
	[Cpp2IlInjected.Token(Token = "0x4000428")]
	DetailsScreen,
	[Cpp2IlInjected.Token(Token = "0x4000429")]
	SignUpScreen,
	[Cpp2IlInjected.Token(Token = "0x400042A")]
	ManageMembershipScreen,
	[Cpp2IlInjected.Token(Token = "0x400042B")]
	ItemDetailsScreen,
	[Cpp2IlInjected.Token(Token = "0x400042C")]
	ActivityRewardsScreen,
	[Cpp2IlInjected.Token(Token = "0x400042D")]
	RoomPublishUpsell
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
[KGJMAOFDNAE]
public class FKFJEBFACDM : OIGCECFCALE
{
	[Cpp2IlInjected.Token(Token = "0x17000274")]
	public FFEEJALAFLP IBDPCJNEMPA
	{
		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(FFEEJALAFLP);
		}
		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D30", Offset = "0x9EFD30", VA = "0x1809F0D30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000275")]
	public bool IBPAAHDJFJH
	{
		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x111FC50", Offset = "0x111EC50", VA = "0x18111FC50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x1357050", Offset = "0x1356050", VA = "0x181357050")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000276")]
	public bool JMOLHBDDPGN
	{
		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x1D48420", Offset = "0x1D47420", VA = "0x181D48420")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x1D48590", Offset = "0x1D47590", VA = "0x181D48590")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000277")]
	public string GPEHAKCLMIK
	{
		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000278")]
	public string NDGLACAKMKB
	{
		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000279")]
	public string ODEPCLKLBBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x9F5A20", Offset = "0x9F4A20", VA = "0x1809F5A20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700027A")]
	public string JOAANNEFMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F22B0", VA = "0x1809F32B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700027B")]
	public Dictionary<KBKDLGNDCGI, string> CGKBOONGHBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x9F1780", Offset = "0x9F0780", VA = "0x1809F1780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x9F1770", Offset = "0x9F0770", VA = "0x1809F1770")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x1357060", Offset = "0x1356060", VA = "0x181357060")]
	public FKFJEBFACDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
[KGJMAOFDNAE]
public class CLMJHLFPLGN : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x1700027C")]
	public IReadOnlyList<MMOPDGKBAEH>? EEJNKLINIEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public CLMJHLFPLGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(RVA = "0x9FE6D0", Offset = "0x9FD6D0", VA = "0x1809FE6D0")]
	public CLMJHLFPLGN(IReadOnlyList<MMOPDGKBAEH>? DOGFLLCGOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public enum APCAKCGDFCO
{
	[Cpp2IlInjected.Token(Token = "0x4000438")]
	Unspecified = -1,
	[Cpp2IlInjected.Token(Token = "0x4000439")]
	XP,
	[Cpp2IlInjected.Token(Token = "0x400043A")]
	OutfitItem,
	[Cpp2IlInjected.Token(Token = "0x400043B")]
	Equipment,
	[Cpp2IlInjected.Token(Token = "0x400043C")]
	Currency,
	[Cpp2IlInjected.Token(Token = "0x400043D")]
	Consumable,
	[Cpp2IlInjected.Token(Token = "0x400043E")]
	Query,
	[Cpp2IlInjected.Token(Token = "0x400043F")]
	HairDye
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public interface GBONMBHCOAE
{
	[Cpp2IlInjected.Token(Token = "0x1700027D")]
	Guid BJLCIJDDMDD
	{
		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700027E")]
	EPDOOECNGMH? HAMALLJNAAE
	{
		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700027F")]
	List<PAMBPODMHLK>? IDIBNFCBPNO
	{
		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000280")]
	DateTime? OLLPENDCGEC
	{
		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000281")]
	DateTime? MAHMPFMIFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000282")]
	DateTime? BLDPNGBCHDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000283")]
	bool AFHLPLGFLFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000284")]
	bool CKFBECEKPBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000285")]
	bool OCHOLGOLIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public interface LNNECACOFKO
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action BGMFODNKBKG;

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task BKJFNLCKCLM(CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task MHHLKGHDLEE(CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FFCEAPKPDAP([Out] MFHIIDPIAOF NFFGNPJGBOO);
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public interface MFHIIDPIAOF
{
	[Cpp2IlInjected.Token(Token = "0x17000286")]
	string HPKGABDCMBH
	{
		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000287")]
	string CICDEPBHJCD
	{
		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000288")]
	IReadOnlyDictionary<EKMFBCAKACJ, IReadOnlyList<OIGCECFCALE>> HMLALOKOLEO
	{
		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000289")]
	IReadOnlyDictionary<string, string> OEEAHJGEMOM
	{
		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public interface OIGCECFCALE
{
	[Cpp2IlInjected.Token(Token = "0x1700028A")]
	string NDGLACAKMKB
	{
		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700028B")]
	string GPEHAKCLMIK
	{
		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700028C")]
	string ODEPCLKLBBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700028D")]
	string JOAANNEFMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public interface FBAKIBIPOMC
{
	[Cpp2IlInjected.Token(Token = "0x1700028E")]
	OILBOLBBFDD KPPMOCAOEMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700028F")]
	string OJLJBFKDCDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000290")]
	string HKGGJOPMJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000291")]
	string HJFBOJCGKGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000292")]
	bool OCHOLGOLIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000293")]
	bool CKFBECEKPBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000294")]
	NGFKJBKJKIN PKGBFGMFFCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000295")]
	string MCOPKJANMDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000296")]
	DKDANGFCEKG? GOPBNIHHAJD
	{
		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000297")]
	APCAKCGDFCO MOLJGCJNBNH
	{
		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000298")]
	bool JKHBCDJKKDE
	{
		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
[KGJMAOFDNAE]
public class EPDOOECNGMH : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000299")]
	public OILBOLBBFDD KFIKOGBAHMD
	{
		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(OILBOLBBFDD);
		}
		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D30", Offset = "0x9EFD30", VA = "0x1809F0D30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029A")]
	public int? MOMEODJELMH
	{
		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0xEC43D0", Offset = "0xEC33D0", VA = "0x180EC43D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0xECD420", Offset = "0xECC420", VA = "0x180ECD420")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029B")]
	public Guid? EEEHCCDKBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x9F8FD0", Offset = "0x9F7FD0", VA = "0x1809F8FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x9F9090", Offset = "0x9F8090", VA = "0x1809F9090")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x71926D0", Offset = "0x71916D0", VA = "0x1871926D0")]
	public static EPDOOECNGMH IMDGNDKDFBD(int LADFILOPOFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x7192770", Offset = "0x7191770", VA = "0x187192770")]
	public static EPDOOECNGMH PJGCMDLKDPB(Guid DGPIPOJOJGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public EPDOOECNGMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public enum OILBOLBBFDD
{
	[Cpp2IlInjected.Token(Token = "0x4000444")]
	PurchasableItem,
	[Cpp2IlInjected.Token(Token = "0x4000445")]
	CustomAvatarItem
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
[KGJMAOFDNAE]
public class PAMBPODMHLK : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x1700029C")]
	public COAFHABICNE HHNPLOFGEBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(COAFHABICNE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D30", Offset = "0x9EFD30", VA = "0x1809F0D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029D")]
	public int DFMBJPCDEPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0xB72E60", Offset = "0xB71E60", VA = "0x180B72E60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0xC5C030", Offset = "0xC5B030", VA = "0x180C5C030")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029E")]
	public GKOCLAEFPKE CMABFDNKMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0xE9CBF0", Offset = "0xE9BBF0", VA = "0x180E9CBF0", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x7198D20", Offset = "0x7197D20", VA = "0x187198D20")]
	public int CIONIKJEHEA(DateTime PLBAFGHLBPJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public PAMBPODMHLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
[KGJMAOFDNAE]
public class GKOCLAEFPKE : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x1700029F")]
	public int HKAKOGOJGFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D30", Offset = "0x9EFD30", VA = "0x1809F0D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A0")]
	public DateTime? FCCJNMBJGNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0xBFFAA0", Offset = "0xBFEAA0", VA = "0x180BFFAA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0xDB9A10", Offset = "0xDB8A10", VA = "0x180DB9A10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A1")]
	public DateTime? NNJAHMAPLCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x1286C40", Offset = "0x1285C40", VA = "0x181286C40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x1286C30", Offset = "0x1285C30", VA = "0x181286C30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x7193C50", Offset = "0x7192C50", VA = "0x187193C50")]
	public bool LBHMAIODDKB(DateTime PLBAFGHLBPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x7193C20", Offset = "0x7192C20", VA = "0x187193C20")]
	public int KCJBPCMIOPM(DateTime PLBAFGHLBPJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x7193B30", Offset = "0x7192B30", VA = "0x187193B30")]
	public TimeSpan? FGJJLMLPPFA(DateTime PLBAFGHLBPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public GKOCLAEFPKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public enum NDHNCEHANCH
{
	[Cpp2IlInjected.Token(Token = "0x400044D")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400044E")]
	LaserTag = 1,
	[Cpp2IlInjected.Token(Token = "0x400044F")]
	RecCenter = 2,
	[Cpp2IlInjected.Token(Token = "0x4000450")]
	Watch = 3,
	[Cpp2IlInjected.Token(Token = "0x4000451")]
	Quest_LostSkulls = 100,
	[Cpp2IlInjected.Token(Token = "0x4000452")]
	Quest_Dracula = 101,
	[Cpp2IlInjected.Token(Token = "0x4000453")]
	Quest_GoldenTrophy = 102,
	[Cpp2IlInjected.Token(Token = "0x4000454")]
	Quest_CrimsonCauldron = 103,
	[Cpp2IlInjected.Token(Token = "0x4000455")]
	RecRoyale = 200,
	[Cpp2IlInjected.Token(Token = "0x4000456")]
	Cafe = 300,
	[Cpp2IlInjected.Token(Token = "0x4000457")]
	Paintball = 400,
	[Cpp2IlInjected.Token(Token = "0x4000458")]
	Paintball_River = 401,
	[Cpp2IlInjected.Token(Token = "0x4000459")]
	Paintball_Homestead = 402,
	[Cpp2IlInjected.Token(Token = "0x400045A")]
	Paintball_Quarry = 403,
	[Cpp2IlInjected.Token(Token = "0x400045B")]
	Paintball_ClearCut = 404,
	[Cpp2IlInjected.Token(Token = "0x400045C")]
	Paintball_Spillway = 405,
	[Cpp2IlInjected.Token(Token = "0x400045D")]
	Paintball_SunsetDriveIn = 406,
	[Cpp2IlInjected.Token(Token = "0x400045E")]
	Bowling = 500,
	[Cpp2IlInjected.Token(Token = "0x400045F")]
	StuntRunner = 600,
	[Cpp2IlInjected.Token(Token = "0x4000460")]
	DormMirror = 700,
	[Cpp2IlInjected.Token(Token = "0x4000461")]
	InventionStore = 800,
	[Cpp2IlInjected.Token(Token = "0x4000462")]
	RoomKeys = 900,
	[Cpp2IlInjected.Token(Token = "0x4000463")]
	Player_Profile = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000464")]
	Room_Save = 1100,
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	RoomCurrencies = 1200,
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	Wishlist = 1300,
	[Cpp2IlInjected.Token(Token = "0x4000467")]
	Friendotron = 1400,
	[Cpp2IlInjected.Token(Token = "0x4000468")]
	RoomConsumables = 1500,
	[Cpp2IlInjected.Token(Token = "0x4000469")]
	RecRally = 1600,
	[Cpp2IlInjected.Token(Token = "0x400046A")]
	PopUpShop_1 = 1700,
	[Cpp2IlInjected.Token(Token = "0x400046B")]
	PopUpShop_2 = 1701,
	[Cpp2IlInjected.Token(Token = "0x400046C")]
	PopUpShop_3 = 1702,
	[Cpp2IlInjected.Token(Token = "0x400046D")]
	PopUpShop_4 = 1703,
	[Cpp2IlInjected.Token(Token = "0x400046E")]
	PopUpShop_5 = 1704,
	[Cpp2IlInjected.Token(Token = "0x400046F")]
	PopUpShop_6 = 1705,
	[Cpp2IlInjected.Token(Token = "0x4000470")]
	PopUpShop_7 = 1706,
	[Cpp2IlInjected.Token(Token = "0x4000471")]
	PopUpShop_8 = 1707,
	[Cpp2IlInjected.Token(Token = "0x4000472")]
	PopUpShop_9 = 1708,
	[Cpp2IlInjected.Token(Token = "0x4000473")]
	PopUpShop_10 = 1709,
	[Cpp2IlInjected.Token(Token = "0x4000474")]
	PopUpShop_11 = 1710,
	[Cpp2IlInjected.Token(Token = "0x4000475")]
	PopUpShop_12 = 1711,
	[Cpp2IlInjected.Token(Token = "0x4000476")]
	PopUpShop_13 = 1712,
	[Cpp2IlInjected.Token(Token = "0x4000477")]
	PopUpShop_14 = 1713,
	[Cpp2IlInjected.Token(Token = "0x4000478")]
	PopUpShop_15 = 1714,
	[Cpp2IlInjected.Token(Token = "0x4000479")]
	PopUpShop_16 = 1715,
	[Cpp2IlInjected.Token(Token = "0x400047A")]
	PopUpShop_17 = 1716,
	[Cpp2IlInjected.Token(Token = "0x400047B")]
	PopUpShop_18 = 1717,
	[Cpp2IlInjected.Token(Token = "0x400047C")]
	PopUpShop_19 = 1718,
	[Cpp2IlInjected.Token(Token = "0x400047D")]
	PopUpShop_20 = 1719,
	[Cpp2IlInjected.Token(Token = "0x400047E")]
	CustomAvatarItems = 1800,
	[Cpp2IlInjected.Token(Token = "0x400047F")]
	ProgressionEventPurchasableXpBoosts = 1900,
	[Cpp2IlInjected.Token(Token = "0x4000480")]
	PopUpShop_ProgressionEvent_1 = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000481")]
	PopUpShop_ProgressionEvent_2 = 2001,
	[Cpp2IlInjected.Token(Token = "0x4000482")]
	PopUpShop_ProgressionEvent_3 = 2002,
	[Cpp2IlInjected.Token(Token = "0x4000483")]
	PopUpShop_ProgressionEvent_4 = 2003,
	[Cpp2IlInjected.Token(Token = "0x4000484")]
	PopUpShop_ProgressionEvent_5 = 2004,
	[Cpp2IlInjected.Token(Token = "0x4000485")]
	RoomOffers = 2100,
	[Cpp2IlInjected.Token(Token = "0x4000486")]
	MyLittleMonsters = 2200,
	[Cpp2IlInjected.Token(Token = "0x4000487")]
	Destiny = 2201,
	[Cpp2IlInjected.Token(Token = "0x4000488")]
	RunTheBlock = 2202,
	[Cpp2IlInjected.Token(Token = "0x4000489")]
	RROStorefront_ToBeNamed_2 = 2203,
	[Cpp2IlInjected.Token(Token = "0x400048A")]
	DevStorefront_DoNotAddToWatch_1 = 2300,
	[Cpp2IlInjected.Token(Token = "0x400048B")]
	DevStorefront_DoNotAddToWatch_2 = 2301,
	[Cpp2IlInjected.Token(Token = "0x400048C")]
	DevStorefront_DoNotAddToWatch_3 = 2302,
	[Cpp2IlInjected.Token(Token = "0x400048D")]
	DevStorefront_DoNotAddToWatch_4 = 2303,
	[Cpp2IlInjected.Token(Token = "0x400048E")]
	DevStorefront_DoNotAddToWatch_5 = 2304
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public enum AAGBAMPLMIJ
{
	[Cpp2IlInjected.Token(Token = "0x4000490")]
	GiftDrop,
	[Cpp2IlInjected.Token(Token = "0x4000491")]
	SeasonTier,
	[Cpp2IlInjected.Token(Token = "0x4000492")]
	SeasonEliteUpgrade
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public enum CMDDEGLKAEL
{
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	Invalid = 0,
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	DirectBalanceWithMultiplier = 1,
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	FromGiftBox = 2,
	[Cpp2IlInjected.Token(Token = "0x4000497")]
	NUXChallenge = 10,
	[Cpp2IlInjected.Token(Token = "0x4000498")]
	AllNUXChallenges = 11,
	[Cpp2IlInjected.Token(Token = "0x4000499")]
	DailyChallenge = 100,
	[Cpp2IlInjected.Token(Token = "0x400049A")]
	AllDailyChallenges = 101,
	[Cpp2IlInjected.Token(Token = "0x400049B")]
	FinishActivity = 200,
	[Cpp2IlInjected.Token(Token = "0x400049C")]
	RecRoyaleMatchFinished = 250,
	[Cpp2IlInjected.Token(Token = "0x400049D")]
	ChecklistCredit = 303,
	[Cpp2IlInjected.Token(Token = "0x400049E")]
	WonGame = 1000,
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	LostGame = 1001,
	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	WonGameRateLimited = 1002,
	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	WonGamePartial = 1003,
	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	LevelUp = 1100,
	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	Registered = 1200,
	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	CreatorReward = 1300,
	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	CommercePurchase = 1400,
	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	CommercePurchaseRevoked = 1401,
	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	Manual_Refund = 2000,
	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	Manual_Thanks = 2010,
	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	Manual_Apology = 2020,
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	TestOnly = 8000
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public enum DAGGDADKPAE
{
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	Interval,
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	PerDay
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public enum FAOKEPNFPED
{
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	PERCENTAGE = 1,
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	EXACT_AMOUNT
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
[KGJMAOFDNAE]
public class FOANPJIEHHD : IEquatable<FOANPJIEHHD>
{
	[Cpp2IlInjected.Token(Token = "0x170002A2")]
	public int? MMAFONCBOEB
	{
		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0xCF3540", Offset = "0xCF2540", VA = "0x180CF3540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A3")]
	public int? EFOJIFFEFDH
	{
		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0xC5C130", Offset = "0xC5B130", VA = "0x180C5C130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A4")]
	public int? AIIKFEMBEEM
	{
		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0xC8C980", Offset = "0xC8B980", VA = "0x180C8C980")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A5")]
	public List<int>? GCIFPCNAICA
	{
		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x9F5A20", Offset = "0x9F4A20", VA = "0x1809F5A20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x7192EC0", Offset = "0x7191EC0", VA = "0x187192EC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x71928D0", Offset = "0x71918D0", VA = "0x1871928D0")]
	public static FOANPJIEHHD EKFLJJMLJIB(int? BNMDDHMNHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x7192930", Offset = "0x7191930", VA = "0x187192930", Slot = "4")]
	public bool Equals(FOANPJIEHHD? MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x7192830", Offset = "0x7191830", VA = "0x187192830")]
	private static bool AJNHLKGHGHH(List<int>? FDJHCIBLFFB, List<int>? CNIMJCCKEDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x7192AB0", Offset = "0x7191AB0", VA = "0x187192AB0", Slot = "0")]
	public override bool Equals(object? BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x7192CE0", Offset = "0x7191CE0", VA = "0x187192CE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public FOANPJIEHHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public struct LDJBIDEBIAE : IEquatable<LDJBIDEBIAE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public readonly OILBOLBBFDD KPPMOCAOEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	private readonly int MOMEODJELMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	private readonly Guid EEEHCCDKBHJ;

	[Cpp2IlInjected.Token(Token = "0x170002A6")]
	public Guid BJLCIJDDMDD
	{
		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x7197190", Offset = "0x7196190", VA = "0x187197190")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A7")]
	public int IEECKJOAMBO
	{
		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x7197180", Offset = "0x7196180", VA = "0x187197180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A8")]
	public string CBMMLKBCLBN
	{
		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x71968B0", Offset = "0x71958B0", VA = "0x1871968B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x7196C30", Offset = "0x7195C30", VA = "0x187196C30")]
	public static bool HBGMKAEOAKP(string AMDHAEEMHLI, [Out] LDJBIDEBIAE JEHIAMEMOAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x7196A70", Offset = "0x7195A70", VA = "0x187196A70")]
	public static LDJBIDEBIAE GKAIMDPHPLD(int HJPLNJNIFLL)
	{
		return default(LDJBIDEBIAE);
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x7196760", Offset = "0x7195760", VA = "0x187196760")]
	public static LDJBIDEBIAE BCMMCGGJJAM(Guid HJPLNJNIFLL)
	{
		return default(LDJBIDEBIAE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x7197070", Offset = "0x7196070", VA = "0x187197070")]
	private static bool IFBJBCMDKEE(string AMDHAEEMHLI, [Out] OILBOLBBFDD OHMPGLBFBMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x71972B0", Offset = "0x71962B0", VA = "0x1871972B0")]
	private LDJBIDEBIAE(OILBOLBBFDD OHMPGLBFBMP, int? PFDDAIJJAOE, Guid? DGPIPOJOJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x7196A00", Offset = "0x7195A00", VA = "0x187196A00", Slot = "4")]
	public bool Equals(LDJBIDEBIAE MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x7196900", Offset = "0x7195900", VA = "0x187196900", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x7196BA0", Offset = "0x7195BA0", VA = "0x187196BA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x7197200", Offset = "0x7196200", VA = "0x187197200", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
[KGJMAOFDNAE]
public abstract class KEGPDCCONLK : IEquatable<KEGPDCCONLK>, MHLEMOAMOMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public Guid JPEKMHAKLEC;

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x7196440", Offset = "0x7195440", VA = "0x187196440", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x71963C0", Offset = "0x71953C0", VA = "0x1871963C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x7196380", Offset = "0x7195380", VA = "0x187196380", Slot = "4")]
	public bool Equals(KEGPDCCONLK MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x7196270", Offset = "0x7195270", VA = "0x187196270", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract KEGPDCCONLK OKKBPPIELHH();

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	protected KEGPDCCONLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public enum JKDLJAFLBMC
{
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	RoomKey,
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	RoomConsumable,
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	RoomCurrencyPurchaseOffer,
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	CustomAvatarItem,
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	StoreUGCAvatarItem,
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	UNDEFINED
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
[KGJMAOFDNAE]
public class MMOPDGKBAEH : KEGPDCCONLK, IEquatable<MMOPDGKBAEH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public JKDLJAFLBMC OHMPGLBFBMP;

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x7198060", Offset = "0x7197060", VA = "0x187198060", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x7197F70", Offset = "0x7196F70", VA = "0x187197F70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public MMOPDGKBAEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x7198100", Offset = "0x7197100", VA = "0x187198100")]
	public MMOPDGKBAEH(JKDLJAFLBMC OHMPGLBFBMP, Guid JPEKMHAKLEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x7197EB0", Offset = "0x7196EB0", VA = "0x187197EB0")]
	public static MMOPDGKBAEH BCMMCGGJJAM(Guid MONOBEAOLBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x7197F20", Offset = "0x7196F20", VA = "0x187197F20", Slot = "7")]
	public bool Equals(MMOPDGKBAEH MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x7197FF0", Offset = "0x7196FF0", VA = "0x187197FF0", Slot = "6")]
	public override KEGPDCCONLK OKKBPPIELHH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public static class PEIEENGMMJI
{
	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(RVA = "0x7198D70", Offset = "0x7197D70", VA = "0x187198D70")]
	public static MMOPDGKBAEH FPFIMAEMPOF(this OJGMLCKBDIB HOJKNIMMINF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x7198DE0", Offset = "0x7197DE0", VA = "0x187198DE0")]
	public static MMOPDGKBAEH IFOLFJOHHKB(string JFCAPPIKPDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x7198ED0", Offset = "0x7197ED0", VA = "0x187198ED0")]
	public static MMOPDGKBAEH LIOFCHNKFOL(Guid BHICOBAOBDK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
[KGJMAOFDNAE]
public class OJGMLCKBDIB : EGONCOPCFDP, MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170002A9")]
	public JKDLJAFLBMC KPPMOCAOEMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(JKDLJAFLBMC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D30", Offset = "0x9EFD30", VA = "0x1809F0D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AA")]
	public Guid BEDCKOANOKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x18A5DC0", Offset = "0x18A4DC0", VA = "0x1818A5DC0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x5844C60", Offset = "0x5843C60", VA = "0x185844C60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AB")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x9F5A20", Offset = "0x9F4A20", VA = "0x1809F5A20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AC")]
	public string BPBACGJDGJI
	{
		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F22B0", VA = "0x1809F32B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AD")]
	public string PNHKFKCEKNC
	{
		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x9F1780", Offset = "0x9F0780", VA = "0x1809F1780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x9F1770", Offset = "0x9F0770", VA = "0x1809F1770")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AE")]
	public long? BJFFDFGEMMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0xEB1930", Offset = "0xEB0930", VA = "0x180EB1930")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0xEB1800", Offset = "0xEB0800", VA = "0x180EB1800")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AF")]
	public long DFMBJPCDEPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x9F4700", Offset = "0x9F3700", VA = "0x1809F4700")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0xE16470", Offset = "0xE15470", VA = "0x180E16470")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B0")]
	public Guid? BGJPHFKJAAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x7198B60", Offset = "0x7197B60", VA = "0x187198B60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x7198B80", Offset = "0x7197B80", VA = "0x187198B80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B1")]
	public DateTime HLEKPMBEFEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CE0", Offset = "0x9F3CE0", VA = "0x1809F4CE0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0xE31860", Offset = "0xE30860", VA = "0x180E31860")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B2")]
	public DateTime GJGOMALEFKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x9F9180", Offset = "0x9F8180", VA = "0x1809F9180")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0xE30D00", Offset = "0xE2FD00", VA = "0x180E30D00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public OJGMLCKBDIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x7198C40", Offset = "0x7197C40", VA = "0x187198C40")]
	public OJGMLCKBDIB(JKDLJAFLBMC OHMPGLBFBMP, Guid JPEKMHAKLEC, [Optional] string NFHOBPDKIPM, [Optional] string HHPFBMBMELN, [Optional] string PCHIHCHIMHB, [Optional] long? CINEDGEJAIA, long NBDBEANPNJP = 0L, [Optional] Guid? CFDJJCFFGGK, [Optional] DateTime IPOPOEOJDBB, [Optional] DateTime FMICMNKNFFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x7198B90", Offset = "0x7197B90", VA = "0x187198B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public enum OAPMNGPFEMF
{
	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	General,
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	Auto,
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	AGOnly,
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	Banned
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public enum JDLCPNJPBHB
{
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	TooManyTags,
	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	TagUseRestricted,
	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	InvalidTag,
	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	InappropriateTag,
	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	TagTooLong,
	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	TagNotFound,
	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	TagAlreadyExists,
	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	NoChange,
	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	TagRepeated,
	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	LacksPermission,
	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	RoomDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	InventionDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	ReservedWordViolation
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
[KGJMAOFDNAE]
public class AJCDICPBHHL : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170002B3")]
	public JDLCPNJPBHB CIJAJIIDNCC
	{
		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(JDLCPNJPBHB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D30", Offset = "0x9EFD30", VA = "0x1809F0D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B4")]
	public List<string> NEGJPANFFBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(RVA = "0x718F990", Offset = "0x718E990", VA = "0x18718F990")]
	public string IOKFJCBMLHN(int CMDLDHKKGCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public AJCDICPBHHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
[KGJMAOFDNAE]
public class APPNANGFABC : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170002B5")]
	public string ACJOIMALHHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B6")]
	public OAPMNGPFEMF KFIKOGBAHMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x9F32A0", Offset = "0x9F22A0", VA = "0x1809F32A0")]
		[CompilerGenerated]
		get
		{
			return default(OAPMNGPFEMF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x9F3290", Offset = "0x9F2290", VA = "0x1809F3290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public APPNANGFABC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public static class HAIBNEAFKGA
{
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public const string BLKDNBEAPBD = "costume";

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public const string FNNKBHACFMP = "gadget";

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public const string ODNKLPEAMOE = "holotar";

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public const string MCBCHFCBDMD = "large";

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public const string GHNKLEIPGOG = "medium";

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public const string EFMDMNEMPJK = "small";

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public const string HBEPFOKCMPO = "sound";

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public const string MGGMCEFKFJE = "dormanchor";

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public const string CDDNNPHNCLI = "reccenteranchor";

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public const string ICJCPCHEJOA = "r2";

	[Cpp2IlInjected.Token(Token = "0x170002B7")]
	public static List<string> DKNPEKGAPMF
	{
		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x7193FC0", Offset = "0x7192FC0", VA = "0x187193FC0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public static class FELIDNINBMH
{
	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public const string IGIGMBNMIKC = "beta";

	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public const string OKDOJKNNMJL = "limitsv2";
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
[KGJMAOFDNAE]
public class ENMAJHPHPEK : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170002B8")]
	public List<string> HJBBGBOKCKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B9")]
	public List<string> ENMMHNBGOCD
	{
		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002BA")]
	public List<string> OBLAGADFCBA
	{
		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public ENMAJHPHPEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public class BJKJNBKDHEG : IEquatable<BJKJNBKDHEG>
{
	[Cpp2IlInjected.Token(Token = "0x170002BB")]
	protected virtual Type KEGGKEILPLH
	{
		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x7191510", Offset = "0x7190510", VA = "0x187191510", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002BC")]
	public MLOJOBKDNHB? MDIIFCDHOCD
	{
		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0xCF3540", Offset = "0xCF2540", VA = "0x180CF3540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002BD")]
	public HttpMethod? PADEOJAGNOG
	{
		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002BE")]
	public string? FGODBGGPKJK
	{
		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x7191680", Offset = "0x7190680", VA = "0x187191680")]
	public BJKJNBKDHEG(MLOJOBKDNHB? MDIIFCDHOCD, HttpMethod? PADEOJAGNOG, string? FGODBGGPKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x7191570", Offset = "0x7190570", VA = "0x187191570", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x7190F90", Offset = "0x718FF90", VA = "0x187190F90", Slot = "6")]
	protected virtual bool EPCHDBBEJNC(StringBuilder KBOCLOKOKJF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0xEE1E90", Offset = "0xEE0E90", VA = "0x180EE1E90")]
	public static bool DIKHMNDIIDO(BJKJNBKDHEG? PLHEPGEBJJB, BJKJNBKDHEG? AOBOBFPJKKO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(RVA = "0xEE1E60", Offset = "0xEE0E60", VA = "0x180EE1E60")]
	public static bool MMJMCICIDNJ(BJKJNBKDHEG? PLHEPGEBJJB, BJKJNBKDHEG? AOBOBFPJKKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(RVA = "0x7191310", Offset = "0x7190310", VA = "0x187191310", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(RVA = "0x71910F0", Offset = "0x71900F0", VA = "0x1871910F0", Slot = "0")]
	public override bool Equals(object? BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B3")]
	[Cpp2IlInjected.Address(RVA = "0x7191180", Offset = "0x7190180", VA = "0x187191180", Slot = "7")]
	public virtual bool Equals(BJKJNBKDHEG? MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(RVA = "0x7191480", Offset = "0x7190480", VA = "0x187191480", Slot = "8")]
	public virtual BJKJNBKDHEG IFEAKEOGCHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(RVA = "0x71916D0", Offset = "0x71906D0", VA = "0x1871916D0")]
	protected BJKJNBKDHEG(BJKJNBKDHEG MKDGMAIADPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B6")]
	[Cpp2IlInjected.Address(RVA = "0x7190F50", Offset = "0x718FF50", VA = "0x187190F50")]
	public void BGDNOIMKKGE([Out] MLOJOBKDNHB? MDIIFCDHOCD, [Out] HttpMethod? PADEOJAGNOG, [Out] string? FGODBGGPKJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public class IBEKFPOONAD : IEquatable<IBEKFPOONAD>
{
	[Cpp2IlInjected.Token(Token = "0x170002BF")]
	protected virtual Type KEGGKEILPLH
	{
		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x7194970", Offset = "0x7193970", VA = "0x187194970", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002C0")]
	public int PDMBJPPIKBF
	{
		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D30", Offset = "0x9EFD30", VA = "0x1809F0D30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002C1")]
	public MGHOHDHDIIM AKCFIMAFAOC
	{
		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0xB72E60", Offset = "0xB71E60", VA = "0x180B72E60")]
		[CompilerGenerated]
		get
		{
			return default(MGHOHDHDIIM);
		}
		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0xC5C030", Offset = "0xC5B030", VA = "0x180C5C030")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(RVA = "0x7194AE0", Offset = "0x7193AE0", VA = "0x187194AE0")]
	public IBEKFPOONAD(int PDMBJPPIKBF, MGHOHDHDIIM AKCFIMAFAOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(RVA = "0x71949D0", Offset = "0x71939D0", VA = "0x1871949D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(RVA = "0x71944F0", Offset = "0x71934F0", VA = "0x1871944F0", Slot = "6")]
	protected virtual bool EPCHDBBEJNC(StringBuilder KBOCLOKOKJF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0xEE1E90", Offset = "0xEE0E90", VA = "0x180EE1E90")]
	public static bool DIKHMNDIIDO(IBEKFPOONAD? PLHEPGEBJJB, IBEKFPOONAD? AOBOBFPJKKO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0xEE1E60", Offset = "0xEE0E60", VA = "0x180EE1E60")]
	public static bool MMJMCICIDNJ(IBEKFPOONAD? PLHEPGEBJJB, IBEKFPOONAD? AOBOBFPJKKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x71947F0", Offset = "0x71937F0", VA = "0x1871947F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x7194760", Offset = "0x7193760", VA = "0x187194760", Slot = "0")]
	public override bool Equals(object? BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x7194620", Offset = "0x7193620", VA = "0x187194620", Slot = "7")]
	public virtual bool Equals(IBEKFPOONAD? MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x7194900", Offset = "0x7193900", VA = "0x187194900", Slot = "8")]
	public virtual IBEKFPOONAD IFEAKEOGCHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0xB72F70", Offset = "0xB71F70", VA = "0x180B72F70")]
	protected IBEKFPOONAD(IBEKFPOONAD MKDGMAIADPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x71944E0", Offset = "0x71934E0", VA = "0x1871944E0")]
	public void BGDNOIMKKGE([Out] int PDMBJPPIKBF, [Out] MGHOHDHDIIM AKCFIMAFAOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public enum MGHOHDHDIIM
{
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	ConnectionTimeout,
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	InternalServerError
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public interface IFCNDIKBIKD
{
	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<BJKJNBKDHEG, IBEKFPOONAD> CKFIBILHLIK();

	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BJPPCPAEPEI(BJKJNBKDHEG OEHHKNIGGMI, IBEKFPOONAD BDCLNIJAFBF);

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BGMGLGCNDHB(BJKJNBKDHEG OEHHKNIGGMI);

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CMHEBPLKCCB();

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task PPKBKBEOBBG(MLOJOBKDNHB BEGHPONNAEO, HttpMethod OAKFMPLKGOM, string ONEIEOBHEBH, CancellationToken CBJPDIFOEKF);
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
[NHFDOLIJPLM]
public class FDPGAAIPEKA<TResult> where TResult : MHLEMOAMOMP, new()
{
	[Cpp2IlInjected.Token(Token = "0x170002C2")]
	public IReadOnlyList<TResult> PNOBAFODHLK
	{
		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002C3")]
	public long IONEPHOFJNA
	{
		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0xC5C130", Offset = "0xC5B130", VA = "0x180C5C130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public FDPGAAIPEKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public enum AALOKKMMDMA
{
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	Development = 1,
	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	QA = 8,
	[Cpp2IlInjected.Token(Token = "0x4000500")]
	Production = 0x100
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public interface OPHBAIBOAEJ
{
	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<AOAKNJHJFNK>> MEOGLCNEICC(bool LJLJHJONNNE = false, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DOBMKNMLLJB([Out] AOAKNJHJFNK? OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<AOAKNJHJFNK> FNMOBJKHBJJ(bool LJLJHJONNNE = false, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LEEJBDOBACO(string DKBCGBFNIGO = "");
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public abstract class MJJLFHCALIK
{
	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	protected MJJLFHCALIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
[KGJMAOFDNAE]
public class AOAKNJHJFNK : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170002C4")]
	public int MGEMGHMBLPL
	{
		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D30", Offset = "0x9EFD30", VA = "0x1809F0D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002C5")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002C6")]
	public string BPBACGJDGJI
	{
		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002C7")]
	public string PNHKFKCEKNC
	{
		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x9F5A20", Offset = "0x9F4A20", VA = "0x1809F5A20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002C8")]
	public int DFMBJPCDEPP
	{
		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x9F6440", Offset = "0x9F5440", VA = "0x1809F6440")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x9F67F0", Offset = "0x9F57F0", VA = "0x1809F67F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002C9")]
	public string NDFFBHAIGDC
	{
		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x9F1780", Offset = "0x9F0780", VA = "0x1809F1780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x9F1770", Offset = "0x9F0770", VA = "0x1809F1770")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002CA")]
	public string BNPLCDIONJE
	{
		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x9F6810", Offset = "0x9F5810", VA = "0x1809F6810")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x9F1580", Offset = "0x9F0580", VA = "0x1809F1580")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002CB")]
	[DataMember(Name = "PsnProductLabel")]
	public string NOKHLJAJJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x9F17A0", Offset = "0x9F07A0", VA = "0x1809F17A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x9F1500", Offset = "0x9F0500", VA = "0x1809F1500")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002CC")]
	public string FDCBHENHOFI
	{
		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x9F4700", Offset = "0x9F3700", VA = "0x1809F4700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x9F46E0", Offset = "0x9F36E0", VA = "0x1809F46E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002CD")]
	public string ECKJPKPJCNC
	{
		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x9F4710", Offset = "0x9F3710", VA = "0x1809F4710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x9F46D0", Offset = "0x9F36D0", VA = "0x1809F46D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002CE")]
	public string AJPGCADEODK
	{
		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x9F46F0", Offset = "0x9F36F0", VA = "0x1809F46F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x9F46C0", Offset = "0x9F36C0", VA = "0x1809F46C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002CF")]
	public string NODGINDEHOD
	{
		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CF0", Offset = "0x9F3CF0", VA = "0x1809F4CF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CD0", Offset = "0x9F3CD0", VA = "0x1809F4CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D0")]
	public string NKOEHNDFICO
	{
		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CE0", Offset = "0x9F3CE0", VA = "0x1809F4CE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CC0", Offset = "0x9F3CC0", VA = "0x1809F4CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D1")]
	public bool DLFLDCCIPON
	{
		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0xC19500", Offset = "0xC18500", VA = "0x180C19500")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0xC19120", Offset = "0xC18120", VA = "0x180C19120")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D2")]
	public bool CJGDKBHLJDD
	{
		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x1589270", Offset = "0x1588270", VA = "0x181589270")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x1589450", Offset = "0x1588450", VA = "0x181589450")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D3")]
	public ADPEFCELODP HCNIDPKECHH
	{
		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x9F90F0", Offset = "0x9F80F0", VA = "0x1809F90F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x9F9010", Offset = "0x9F8010", VA = "0x1809F9010")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D4")]
	[IgnoreDataMember]
	public string IBBFJOMFMNL
	{
		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x9F9100", Offset = "0x9F8100", VA = "0x1809F9100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x9F8FF0", Offset = "0x9F7FF0", VA = "0x1809F8FF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D5")]
	[IgnoreDataMember]
	public string JMBIKEHOJBK
	{
		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0xBDE270", Offset = "0xBDD270", VA = "0x180BDE270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x12CD960", Offset = "0x12CC960", VA = "0x1812CD960")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D6")]
	[IgnoreDataMember]
	public string KMAJPIMCPBO
	{
		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x9F9040", Offset = "0x9F8040", VA = "0x1809F9040")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x9F9050", Offset = "0x9F8050", VA = "0x1809F9050")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D7")]
	[IgnoreDataMember]
	public MJJLFHCALIK PMEJPDEMBBN
	{
		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0xCC02E0", Offset = "0xCBF2E0", VA = "0x180CC02E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0xE32260", Offset = "0xE31260", VA = "0x180E32260")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D8")]
	[IgnoreDataMember]
	public bool JOPHLLJHKOE
	{
		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x718FE10", Offset = "0x718EE10", VA = "0x18718FE10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0x718FE30", Offset = "0x718EE30", VA = "0x18718FE30", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0x718FF20", Offset = "0x718EF20", VA = "0x18718FF20")]
	public static AOAKNJHJFNK LJOGPKPCFOI(int HJPLNJNIFLL, string NFHOBPDKIPM, string PCHIHCHIMHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x718FFC0", Offset = "0x718EFC0", VA = "0x18718FFC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public AOAKNJHJFNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
[KGJMAOFDNAE]
public class ADPEFCELODP : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170002D9")]
	public List<int> GNDENGMKICA
	{
		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DA")]
	public string LNILHMKIEOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DB")]
	public DOIHELLICBB PNJHDCAAOFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0xE9CBF0", Offset = "0xE9BBF0", VA = "0x180E9CBF0", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public ADPEFCELODP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public enum BIOAFDJHLFI
{
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	Gold,
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	Platinum
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public enum PBLOJCMGPDI
{
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	Month,
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	Year,
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	ThreeMonth,
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	SixMonth
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
[KGJMAOFDNAE]
public class DOIHELLICBB : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170002DC")]
	public BIOAFDJHLFI HOAMCOAEJDM
	{
		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(BIOAFDJHLFI);
		}
		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D30", Offset = "0x9EFD30", VA = "0x1809F0D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DD")]
	public PBLOJCMGPDI LDNFOOKPEDO
	{
		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0xB72E60", Offset = "0xB71E60", VA = "0x180B72E60")]
		[CompilerGenerated]
		get
		{
			return default(PBLOJCMGPDI);
		}
		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0xC5C030", Offset = "0xC5B030", VA = "0x180C5C030")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DE")]
	public bool FEJEMBMGEGG
	{
		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0xAA5F80", Offset = "0xAA4F80", VA = "0x180AA5F80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x9FA1F0", Offset = "0x9F91F0", VA = "0x1809FA1F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000711")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public DOIHELLICBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
[KGJMAOFDNAE]
public class PPICDCDJIDN : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170002DF")]
	public string BGGIEPIKLAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E0")]
	public ONOOOJEFPBH? NAOKMAGJDMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E1")]
	public string? BLJANOOBBPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E2")]
	public string? GKJCACGNALC
	{
		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x9F5A20", Offset = "0x9F4A20", VA = "0x1809F5A20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E3")]
	public string? PIKIOHDOMGP
	{
		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F22B0", VA = "0x1809F32B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E4")]
	public string? LPKAAPOKHCG
	{
		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x9F1780", Offset = "0x9F0780", VA = "0x1809F1780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x9F1770", Offset = "0x9F0770", VA = "0x1809F1770")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E5")]
	public bool? BKNBFMKBDCD
	{
		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x7196720", Offset = "0x7195720", VA = "0x187196720")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x7196710", Offset = "0x7195710", VA = "0x187196710")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public PPICDCDJIDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
[KGJMAOFDNAE]
public class MFEAGLFKJML : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170002E6")]
	public string BLPCOOECADL
	{
		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E7")]
	public ONOOOJEFPBH? NAOKMAGJDMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E8")]
	public string? PIKIOHDOMGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public MFEAGLFKJML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
[KGJMAOFDNAE]
public class KCBONAHKPGL : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170002E9")]
	public string LPKAAPOKHCG
	{
		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EA")]
	public string GKJCACGNALC
	{
		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EB")]
	public string GHAJJFBIBCF
	{
		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EC")]
	public string? PMGNEGOCDKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x9F5A20", Offset = "0x9F4A20", VA = "0x1809F5A20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002ED")]
	public float ILHLPJHEMAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0xBE1110", Offset = "0xBE0110", VA = "0x180BE1110")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0xF09100", Offset = "0xF08100", VA = "0x180F09100")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000736")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public KCBONAHKPGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
[KGJMAOFDNAE]
public class JHAIGFEHKHO : PGNAHLEOJHC, MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170002EE")]
	public string OHDIDODLMDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EF")]
	public string IBFJODFHPGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "6")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public JHAIGFEHKHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
[KGJMAOFDNAE]
public class BLGPPCOBJLI : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170002F0")]
	public long BJJANAEJEBD
	{
		[Cpp2IlInjected.Token(Token = "0x600073D")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600073E")]
		[Cpp2IlInjected.Address(RVA = "0xCF3540", Offset = "0xCF2540", VA = "0x180CF3540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F1")]
	public decimal NGFNNBIBPAN
	{
		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0xBFFAA0", Offset = "0xBFEAA0", VA = "0x180BFFAA0")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0xDB9A10", Offset = "0xDB8A10", VA = "0x180DB9A10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000741")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000742")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public BLGPPCOBJLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
[KGJMAOFDNAE]
public class MDBIHINDEFN : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170002F2")]
	public string OHDIDODLMDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F3")]
	public string GPEIFEKIGPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000747")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public MDBIHINDEFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(RVA = "0x9FE5E0", Offset = "0x9FD5E0", VA = "0x1809FE5E0")]
	public MDBIHINDEFN(string PNBLCEBBDDJ, string CAGGFIHFLKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000749")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
[KGJMAOFDNAE]
public class DEBKODPFNKO : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170002F4")]
	public string GPEIFEKIGPG
	{
		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600074C")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public DEBKODPFNKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
[KGJMAOFDNAE]
public class GJMKGBHHFBK : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170002F5")]
	public string LPKAAPOKHCG
	{
		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F6")]
	public string BGGIEPIKLAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F7")]
	public string? EOMGDLMNCFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F8")]
	public string? NHEGOKCPOIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x9F5A20", Offset = "0x9F4A20", VA = "0x1809F5A20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000756")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000757")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public GJMKGBHHFBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
[KGJMAOFDNAE]
public class OONFFOANBJN : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170002F9")]
	public string NGGJMDLHLLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600075A")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600075B")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public OONFFOANBJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
[KGJMAOFDNAE]
public class EOOLNPLGDMJ : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170002FA")]
	public int OJLJBFKDCDP
	{
		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D30", Offset = "0x9EFD30", VA = "0x1809F0D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FB")]
	public string KFIKOGBAHMD
	{
		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FC")]
	public string? IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FD")]
	public IReadOnlyList<int> EFHJGCECLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x9F5A20", Offset = "0x9F4A20", VA = "0x1809F5A20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FE")]
	public string? POCLMFPBHKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F22B0", VA = "0x1809F32B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000766")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000767")]
	[Cpp2IlInjected.Address(RVA = "0x7192640", Offset = "0x7191640", VA = "0x187192640")]
	public EOOLNPLGDMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
[KGJMAOFDNAE]
public class LPMFJAFAOON : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170002FF")]
	public int OJLJBFKDCDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D30", Offset = "0x9EFD30", VA = "0x1809F0D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000300")]
	public Guid? EEEHCCDKBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x21740C0", Offset = "0x21730C0", VA = "0x1821740C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x21740B0", Offset = "0x21730B0", VA = "0x1821740B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000301")]
	public string KFIKOGBAHMD
	{
		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x9F5A20", Offset = "0x9F4A20", VA = "0x1809F5A20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000302")]
	public List<EOOLNPLGDMJ> IFHJMMDMJDL
	{
		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F22B0", VA = "0x1809F32B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000303")]
	public List<EOOLNPLGDMJ> JMILCLGNEAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x9F1780", Offset = "0x9F0780", VA = "0x1809F1780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0x9F1770", Offset = "0x9F0770", VA = "0x1809F1770")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000304")]
	public string? IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x9F6810", Offset = "0x9F5810", VA = "0x1809F6810")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x9F1580", Offset = "0x9F0580", VA = "0x1809F1580")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000305")]
	public string? POCLMFPBHKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x9F17A0", Offset = "0x9F07A0", VA = "0x1809F17A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x9F1500", Offset = "0x9F0500", VA = "0x1809F1500")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000306")]
	public string? AIFFBGAFCEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0x9F4700", Offset = "0x9F3700", VA = "0x1809F4700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0x9F46E0", Offset = "0x9F36E0", VA = "0x1809F46E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000778")]
	[Cpp2IlInjected.Address(RVA = "0x7197670", Offset = "0x7196670", VA = "0x187197670", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000779")]
	[Cpp2IlInjected.Address(RVA = "0x71976A0", Offset = "0x71966A0", VA = "0x1871976A0")]
	public LPMFJAFAOON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
[KGJMAOFDNAE]
public class MOIGIIHPFMA : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000307")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000308")]
	public LPMFJAFAOON IFHJMMDMJDL
	{
		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000309")]
	public LPMFJAFAOON JMILCLGNEAA
	{
		[Cpp2IlInjected.Token(Token = "0x600077E")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600077F")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030A")]
	public string? AIFFBGAFCEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000780")]
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x9F5A20", Offset = "0x9F4A20", VA = "0x1809F5A20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000782")]
	[Cpp2IlInjected.Address(RVA = "0x7198140", Offset = "0x7197140", VA = "0x187198140", Slot = "5")]
	public virtual void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000783")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public MOIGIIHPFMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
[KGJMAOFDNAE]
public class MPBOJILBLOB : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x1700030B")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030C")]
	public IReadOnlyList<LPMFJAFAOON> BIEFAAFIEMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030D")]
	public IReadOnlyList<MOIGIIHPFMA> DJIFCIGFLGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030E")]
	public IReadOnlyList<MPBOJILBLOB> ABNMLMMAEAN
	{
		[Cpp2IlInjected.Token(Token = "0x600078A")]
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0x9F5A20", Offset = "0x9F4A20", VA = "0x1809F5A20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030F")]
	public string? AIFFBGAFCEA
	{
		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F22B0", VA = "0x1809F32B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600078E")]
	[Cpp2IlInjected.Address(RVA = "0x71981A0", Offset = "0x71971A0", VA = "0x1871981A0", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078F")]
	[Cpp2IlInjected.Address(RVA = "0x71981D0", Offset = "0x71971D0", VA = "0x1871981D0")]
	public MPBOJILBLOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
[KGJMAOFDNAE]
public class ONOOOJEFPBH : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000310")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000791")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000311")]
	public string KFIKOGBAHMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000793")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000312")]
	public List<ONOOOJEFPBH>? CKOCFIAIKJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000794")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000795")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000796")]
	[Cpp2IlInjected.Address(RVA = "0x7198D00", Offset = "0x7197D00", VA = "0x187198D00", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000797")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public ONOOOJEFPBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
[KGJMAOFDNAE]
public class GOPFPGFCCEP : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000313")]
	public string OJLJBFKDCDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000799")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000314")]
	public MPBOJILBLOB BOJGKNCLAOB
	{
		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000315")]
	public ONOOOJEFPBH? NAOKMAGJDMD
	{
		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600079D")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000316")]
	public string? BLPCOOECADL
	{
		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0x9F5A20", Offset = "0x9F4A20", VA = "0x1809F5A20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007A0")]
	[Cpp2IlInjected.Address(RVA = "0x7193F50", Offset = "0x7192F50", VA = "0x187193F50", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A1")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public GOPFPGFCCEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
[KGJMAOFDNAE]
public class GIOJGGIGFKG : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000317")]
	public BBMBJJIMEEM<GOPFPGFCCEP> CIJAJIIDNCC
	{
		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007A3")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000318")]
	public decimal BAPPIBMCJLP
	{
		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0xBFFAA0", Offset = "0xBFEAA0", VA = "0x180BFFAA0")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0xDB9A10", Offset = "0xDB8A10", VA = "0x180DB9A10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007A6")]
	[Cpp2IlInjected.Address(RVA = "0x6F4DFD0", Offset = "0x6F4CFD0", VA = "0x186F4DFD0", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A7")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public GIOJGGIGFKG()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000124")]
public class PPHBBBBMJHN
{
	[Cpp2IlInjected.Token(Token = "0x60007A8")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public PPHBBBBMJHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A9")]
	[Cpp2IlInjected.Address(RVA = "0x6EB2EC0", Offset = "0x6EB1EC0", VA = "0x186EB2EC0")]
	public static string GEGBLCCMNJF(byte[] KIEHMFJADIM, byte[] IAEAOGJCDGG)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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
