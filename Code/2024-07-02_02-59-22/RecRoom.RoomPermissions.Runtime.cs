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
		[Cpp2IlInjected.Address(RVA = "0x88F9F0", Offset = "0x88E9F0", VA = "0x18088F9F0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7074940", Offset = "0x7073940", VA = "0x187074940")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x890740", Offset = "0x88F740", VA = "0x180890740")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x890780", Offset = "0x88F780", VA = "0x180890780")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum EADEAPBEIII
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void FCFPDDJHBAK<TPermission>(TPermission BIICMLPHBIO);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void MEEBEBGHDMC(NMCPPAKMEBO GOBKHJJOFMO);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum OMFNDBOPBHG
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface JLLJIPPBPKF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool KBEHGMAAMJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool CKEGMACLIHO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool KDNLGBAIMFA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool PGMNGGBGJEI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool IMHEMMHDNHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool NBFJEGCKLFM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class KKCIHEBHAKA
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	public enum EAMLFODEFFG
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		AG_EVERYONE = 0,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		AG_CREATOR = 0x200000,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		AG_COOWNER = 0x400000,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		AG_HOST = 0x800000,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		AG_MODERATOR = 0x1000000
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly Guid IHFKAPPGLKD;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid LAKBACAAGLL;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid FNIHJCIKIGB;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid PBNJHAJAHJN;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid KNEMANECAKP;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid MOLLANEFKDG;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly HGDBIBBGKNH<PFDMNDENLBK, Guid> MONJNPNKBGC;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<PFDMNDENLBK> DCOHIGBFNND
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7072280", Offset = "0x7071280", VA = "0x187072280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7071FD0", Offset = "0x7070FD0", VA = "0x187071FD0")]
	public static PFDMNDENLBK GKHBNCHHLNM(Guid NNFEKLKANBO)
	{
		return default(PFDMNDENLBK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7071F30", Offset = "0x7070F30", VA = "0x187071F30")]
	public static Guid BFABFFFKNBE(PFDMNDENLBK NKEMKMPPMBN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x70721F0", Offset = "0x70711F0", VA = "0x1870721F0")]
	public static bool OIJCPLFFHOG(PFDMNDENLBK NKEMKMPPMBN, [Out] Guid NNFEKLKANBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7072060", Offset = "0x7071060", VA = "0x187072060")]
	public static bool HJEEMKJLBNM(Guid NNFEKLKANBO, [Out] PFDMNDENLBK NKEMKMPPMBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x70721B0", Offset = "0x70711B0", VA = "0x1870721B0")]
	public static PFDMNDENLBK NEIFFGEAIHE(PFDMNDENLBK NKEMKMPPMBN)
	{
		return default(PFDMNDENLBK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7072100", Offset = "0x7071100", VA = "0x187072100")]
	public static EAMLFODEFFG JDECMGNDGPE(PFDMNDENLBK HKAJPJHLFFO)
	{
		return default(EAMLFODEFFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7072300", Offset = "0x7071300", VA = "0x187072300")]
	internal static PFDMNDENLBK PMHOLDAJJAC(EAMLFODEFFG DPHEJAGNLBB)
	{
		return default(PFDMNDENLBK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FPABHIHDCJN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	FOBAGAAEPPI EOHNKFNJOMG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<OBMEIICEFCF> GGNGBDNNDCM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event MEEBEBGHDMC JOFCDKDOOCC;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<OBMEIICEFCF> OKJFKFCDIKO(bool KHHDIDCIHIK = false);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OBMEIICEFCF ACPOJDAOIJB(NMCPPAKMEBO GOBKHJJOFMO);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LNAGJBGKNNI(NMCPPAKMEBO GOBKHJJOFMO);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<OBMEIICEFCF> BKIMBLKOJFH(NMCPPAKMEBO GOBKHJJOFMO, bool IFGKAGLGEFC = false);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool DFMPBDMGABP(NMCPPAKMEBO PGCKLAOMDLP, PFDMNDENLBK NKEMKMPPMBN);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "9")]
	OBMEIICEFCF EAJDOEIIDAE(PFDMNDENLBK NKEMKMPPMBN);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool IGGDDGACJEO<T>(PFDMNDENLBK NKEMKMPPMBN, KLIEFAAGNPA BIICMLPHBIO, bool MCBIBMKCEKN, T HFLBLCMJIKA, [Optional] Action CGLOCPHHGOE) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string NJBPANIAPAP(KLIEFAAGNPA BIICMLPHBIO);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HEDODPFNIMI
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task HCONEALAIIN(EIGMLKEEHNM ENLCDNNHBBD, CancellationToken DADBOHKBJNO);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GEOGHMOFLDJ(EIGMLKEEHNM ENLCDNNHBBD);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BNKAFJDOMLF
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	NMCPPAKMEBO EGNMAFKFFFA
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	BNPDOGINEIM KPOHJCEBLIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	KBIHKJABELE NLGOFALHAKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<AICIEDPHEKP> ANOHGJGIMCG;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action CNNPHGODEJK;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PFDMNDENLBK EJMLBKPBEDP(NMCPPAKMEBO GOBKHJJOFMO);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<AICIEDPHEKP> PLLPJFHEDKK(CancellationToken DADBOHKBJNO);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task IFBIBKMHNHN(long NBDDMFOIEKN, IReadOnlyList<OCJLDKOMKIC> BFLCFNIOAKO);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task IMKGCDBGIEC(long NBDDMFOIEKN, long ILOMCKJOFJN, IReadOnlyList<OCJLDKOMKIC> BFLCFNIOAKO);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<NMCPPAKMEBO> NPFHPADPHOM();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class DOHGCAPCEOL
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7069270", Offset = "0x7068270", VA = "0x187069270")]
	public static PFDMNDENLBK EDJGDLKPALN(this BNKAFJDOMLF EDCACBCOHII)
	{
		return default(PFDMNDENLBK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface NAEECJLGENF<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string LEGMANCMOAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event FCFPDDJHBAK<TPermission> HAGKCPBLPAF;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class PFENCDGEELK
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? ALOBJBBLCPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8687C0", Offset = "0x8677C0", VA = "0x1808687C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8687E0", Offset = "0x8677E0", VA = "0x1808687E0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x86CB90", Offset = "0x86BB90", VA = "0x18086CB90")]
	protected PFENCDGEELK(object? OCPBAFCAEGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool AKJKJJBMIND(object? CBAEIEAPLIH);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class OIMPADIEGNM<T> : PFENCDGEELK where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private T PMLAOPNFJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly IEqualityComparer<T> PJCHJFCBECF;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T BLBBIKKJHJE
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x932C30", Offset = "0x931C30", VA = "0x180932C30")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x46A69B0", Offset = "0x46A59B0", VA = "0x1846A69B0", Slot = "4")]
	public override bool AKJKJJBMIND(object? CBAEIEAPLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x46A6F20", Offset = "0x46A5F20", VA = "0x1846A6F20")]
	public bool OBMGCCHLFHC(T NMFFJGMOMPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x46A70D0", Offset = "0x46A60D0", VA = "0x1846A70D0")]
	public OIMPADIEGNM(T AJMLHGDNPEK, IEqualityComparer<T> PJCHJFCBECF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class LCLAAKPOEDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<KLIEFAAGNPA, bool> GJFMGFIOODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<KLIEFAAGNPA, PFENCDGEELK> CAHKLEDHFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HKAPKJFCBDP HKOGGDJHALE;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7073CB0", Offset = "0x7072CB0", VA = "0x187073CB0")]
	public LCLAAKPOEDK(HKAPKJFCBDP HKOGGDJHALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x70737C0", Offset = "0x70727C0", VA = "0x1870737C0")]
	public bool BOODAFNLPBC(KLIEFAAGNPA BIICMLPHBIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2BF8DA0", Offset = "0x2BF7DA0", VA = "0x182BF8DA0")]
	public bool KODDODJBDGA<T>(KLIEFAAGNPA BIICMLPHBIO, bool MCBIBMKCEKN, T CBAEIEAPLIH) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2BF8900", Offset = "0x2BF7900", VA = "0x182BF8900")]
	public (bool, T?) FDEECHMHLEF<T>(KLIEFAAGNPA BIICMLPHBIO) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x70739D0", Offset = "0x70729D0", VA = "0x1870739D0")]
	public bool KODDODJBDGA(KLIEFAAGNPA BIICMLPHBIO, bool MCBIBMKCEKN, object CBAEIEAPLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7073900", Offset = "0x7072900", VA = "0x187073900")]
	public (bool, object) FDEECHMHLEF(KLIEFAAGNPA BIICMLPHBIO)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2BF9320", Offset = "0x2BF8320", VA = "0x182BF9320")]
	private void MPCIEGKMBOL<T>(KLIEFAAGNPA BIICMLPHBIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7073830", Offset = "0x7072830", VA = "0x187073830")]
	private PFENCDGEELK DBCAKCEKKHF(KLIEFAAGNPA BIICMLPHBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7073AB0", Offset = "0x7072AB0", VA = "0x187073AB0")]
	public void PMBOEHEMMOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class JBGLPNAJBEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly string BHHKKMMCCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly Type MJOIJNNNCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly DLMFAGJHJFK IALEMAHJPGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly KLIEFAAGNPA IEJOKCBJPDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public GLEKGEIKGII EMBKIFOPCLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public HJKJOHJDEKM KILJFMOIEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public PDJECMJKNDP ALGGFKBELHI;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7071E90", Offset = "0x7070E90", VA = "0x187071E90")]
	public JBGLPNAJBEM(Type CFEGFDLCFCP, string DDPKLNDJNDO, KLIEFAAGNPA BIICMLPHBIO, GLEKGEIKGII LFIBFNGEOAF, HJKJOHJDEKM NFFECIAOBHG, PDJECMJKNDP PHMPGHMIFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7071E40", Offset = "0x7070E40", VA = "0x187071E40")]
	public object PGKMPKKGCFD(object? LJAAPFIIPOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2B81360", Offset = "0x2B80360", VA = "0x182B81360")]
	public void MPCIEGKMBOL<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7071D90", Offset = "0x7070D90", VA = "0x187071D90")]
	public void MPCIEGKMBOL(Type PCEFBCCNPPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class HPHPABLNNCP<T> : JBGLPNAJBEM where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string JMMEMFIPMGO(T CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T GBOHKJHIHIC(string? ALDNBNHCEFO, T AJMLHGDNPEK);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class LDFEFBMBKDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public JMMEMFIPMGO serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public GBOHKJHIHIC parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public LDFEFBMBKDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x42C2C20", Offset = "0x42C1C20", VA = "0x1842C2C20")]
		internal string KHJIJLCBBPO(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x42C2A10", Offset = "0x42C1A10", VA = "0x1842C2A10")]
		internal object HBAJDHGENCM(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3E13E70", Offset = "0x3E12E70", VA = "0x183E13E70")]
	public HPHPABLNNCP(KLIEFAAGNPA BIICMLPHBIO, string DDPKLNDJNDO, [Optional] JMMEMFIPMGO? LFIBFNGEOAF, [Optional] GBOHKJHIHIC? NFFECIAOBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3E12F80", Offset = "0x3E11F80", VA = "0x183E12F80")]
	private static object? JGNOLJBBCJA(GBOHKJHIHIC? NFFECIAOBHG, string? ALDNBNHCEFO, object? AJMLHGDNPEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3E132C0", Offset = "0x3E122C0", VA = "0x183E132C0")]
	private static string KLDBPIDHOEH(JMMEMFIPMGO? IBIFMIOCOCM, object? CBAEIEAPLIH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string GLEKGEIKGII(object? CBAEIEAPLIH);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object HJKJOHJDEKM(string? ALDNBNHCEFO, [Optional] object AJMLHGDNPEK);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate PFENCDGEELK PDJECMJKNDP();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class HKAPKJFCBDP
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class IPKDCJHCJLD : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal static IPKDCJHCJLD IBMHAACFGKI;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7071A50", Offset = "0x7070A50", VA = "0x187071A50", Slot = "4")]
		public bool Equals(List<string> OOALEDCPNBJ, List<string> HDFOCKKCOOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7071BA0", Offset = "0x7070BA0", VA = "0x187071BA0", Slot = "5")]
		public int GetHashCode(List<string> HBFCGFKGCAF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public IPKDCJHCJLD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class CFNPMEPHFJI : HEIKFMOKNOK<EADEAPBEIII>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7069140", Offset = "0x7068140", VA = "0x187069140", Slot = "9")]
		public override string KLDBPIDHOEH(EADEAPBEIII CPEKGDIIDKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7068F60", Offset = "0x7067F60", VA = "0x187068F60", Slot = "10")]
		protected override bool ELMHIOJMKFP(string CPEKGDIIDKL, [Out] EADEAPBEIII CBAEIEAPLIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7069230", Offset = "0x7068230", VA = "0x187069230")]
		public CFNPMEPHFJI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly INLNCGNAOFN DMLEDMGOIEE;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly CFNPMEPHFJI JAALHOBJOFI;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly List<JBGLPNAJBEM> IDCODPLFDLD;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<KLIEFAAGNPA> LFFJCDMMMKN
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8687C0", Offset = "0x8677C0", VA = "0x1808687C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<KLIEFAAGNPA, JBGLPNAJBEM> LMJHGNHAABI
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x706B050", Offset = "0x706A050", VA = "0x18706B050")]
	public HKAPKJFCBDP([Optional] IList<JBGLPNAJBEM>? JKMPOAEEFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7069B30", Offset = "0x7068B30", VA = "0x187069B30")]
	public JBGLPNAJBEM OPONOBACHMA(KLIEFAAGNPA BIICMLPHBIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface FOBAGAAEPPI
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	OBMEIICEFCF NICHHPPCMJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class LBHBCKJNIDG : FOBAGAAEPPI
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static LBHBCKJNIDG ACKAENBCBPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly ODOJBJNKEAC PNCMCBNMMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal readonly IReadOnlyList<ODOJBJNKEAC> KOCJKGHOEOP;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public OBMEIICEFCF NICHHPPCMJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8687C0", Offset = "0x8677C0", VA = "0x1808687C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x70736B0", Offset = "0x70726B0", VA = "0x1870736B0")]
	public LBHBCKJNIDG(ODOJBJNKEAC LCGDNMINKJH, IReadOnlyList<ODOJBJNKEAC> PEFOAEMBKLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7072860", Offset = "0x7071860", VA = "0x187072860")]
	private static LBHBCKJNIDG KNLLMKCGEEP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class NCAHGPCCIFG
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<PFDMNDENLBK> FBDBHHLMENI;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x70746B0", Offset = "0x70736B0", VA = "0x1870746B0")]
	public static bool LGFBHCKNCFL(this NMCPPAKMEBO OFANFPAHCFK, PFDMNDENLBK NKEMKMPPMBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7074630", Offset = "0x7073630", VA = "0x187074630")]
	public static bool AHBLDDLIIKG(this NMCPPAKMEBO OFANFPAHCFK, PFDMNDENLBK NKEMKMPPMBN, KBIHKJABELE DPMMJNEEKNM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface JKKAOFLJFAJ
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool KIDDKKKLHOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool CJCFBBNHNJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool NNBDPLIGNLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool PECLFCAOGEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool JLGBEKGMOPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool KCELJCEFDJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool CHAADCEEPNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool HCHFDHPOPBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool AELBJINGBNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool NEKLAOAODJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool CHEEOKENJOA
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool NIGMJIDGOKM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> AIBCGEHPMDH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	EADEAPBEIII PIMNJICCDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface OBMEIICEFCF : JKKAOFLJFAJ, JLLJIPPBPKF, NAEECJLGENF<KLIEFAAGNPA>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string MHOFDNLBDBF
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	PFDMNDENLBK JGECPFDDBAI
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) GODNGJGEGKK<T>(KLIEFAAGNPA BIICMLPHBIO) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum KLIEFAAGNPA
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	CAN_EDIT_ROOM_ROLES = 1,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	VOTE_KICK_PERMISSION = 3,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	CAN_INVITE = 4,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	CAN_TALK = 6,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	CAN_PRINT_PHOTOS = 7,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	CAN_START_GAMES = 8,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	CAN_SELF_REVIVE = 9,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	AUTO_ASSIGNED_GAME_ROLES = 11,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	CAN_CHANGE_GAME_MODE = 12,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	CAN_USE_MAKER_PEN = 13,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	CAN_USE_DELETE_ALL_BUTTON = 14,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	CAN_SAVE_INVENTIONS = 15,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	DISABLE_MIC_AUTO_MUTE = 16,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	CAN_END_GAMES_EARLY = 17,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	CAN_USE_SHARE_CAM = 18,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	DEPRECATED_CAN_EDIT_CIRCUITS = 19,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	CAN_SPAWN_INVENTIONS = 20,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	CAN_SPAWN_CONSUMABLES = 21,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	CAN_USE_ROOM_RESET_BUTTON = 22,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	CAN_USE_PLAY_GIZMOS_TOGGLE = 23,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	AUTO_ASSIGNED_PLAYER_TAGS = 24,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	CAN_USE_RRS = 25,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	ROOM_LEVEL_THRESHOLD = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	CAN_SAVE_ROOM = 1001,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	CAN_PUBLISH_ROOM = 1002,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	CAN_CLONE_ROOM = 1003,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	CAN_RESTORE_ROOM = 1004,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	CAN_EDIT_MAIN_ROOM_SETTINGS = 1006,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	CAN_EDIT_ROOM_ECON_SETTINGS = 1007,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	CAN_CREATE_SUBROOMS = 1008,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	CAN_NAME_SUBROOMS = 1009,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	CAN_CLONE_SUBROOMS = 1010,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	CAN_MOVE_SUBROOMS = 1011,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	CAN_DELETE_SUBROOMS = 1012,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	CAN_EDIT_SUBROOM_SETTINGS = 1013,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	CAN_RESET_CLOUD_VARIABLES = 1014,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	CAN_DELETE_CLOUD_VARIABLES = 1015,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	CAN_EDIT_ROOM_PROGRESSION = 1016,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	CAN_REMOVE_ROOM_BANS = 1017,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	CAN_ADD_ROOM_BANS = 1018
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal class ODOJBJNKEAC : OBMEIICEFCF, JKKAOFLJFAJ, JLLJIPPBPKF, NAEECJLGENF<KLIEFAAGNPA>
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	internal static readonly HKAPKJFCBDP JGLOOCLBMNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	internal readonly LCLAAKPOEDK HIIJCDIAFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private string? PEAPEFGOGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private string? JBGLADMNAAM;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool MLOMPLHOHOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7074AB0", Offset = "0x7073AB0", VA = "0x187074AB0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool AMLGAFNKLAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7075100", Offset = "0x7074100", VA = "0x187075100", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool JCPODHMAOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7074E40", Offset = "0x7073E40", VA = "0x187074E40", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool GMDPKNOJPKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x70749C0", Offset = "0x70739C0", VA = "0x1870749C0", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool PJCCMOFBAGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7074A10", Offset = "0x7073A10", VA = "0x187074A10", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool GLAFMNINAEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x70751A0", Offset = "0x70741A0", VA = "0x1870751A0", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public PFDMNDENLBK JGECPFDDBAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x932C30", Offset = "0x931C30", VA = "0x180932C30", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(PFDMNDENLBK);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x873440", Offset = "0x872440", VA = "0x180873440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string LEGMANCMOAI
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7075150", Offset = "0x7074150", VA = "0x187075150", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7074F30", Offset = "0x7073F30", VA = "0x187074F30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string MHOFDNLBDBF
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7075150", Offset = "0x7074150", VA = "0x187075150", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool GGLCPOLLHDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9ED240", Offset = "0x9EC240", VA = "0x1809ED240")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9EC480", Offset = "0x9EB480", VA = "0x1809EC480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool KIDDKKKLHOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7076650", Offset = "0x7075650", VA = "0x187076650", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public EADEAPBEIII PIMNJICCDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7075760", Offset = "0x7074760", VA = "0x187075760", Slot = "20")]
		get
		{
			return default(EADEAPBEIII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool CJCFBBNHNJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7075C30", Offset = "0x7074C30", VA = "0x187075C30", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool NNBDPLIGNLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7076600", Offset = "0x7075600", VA = "0x187076600", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool PECLFCAOGEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x70766A0", Offset = "0x70756A0", VA = "0x1870766A0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool JLGBEKGMOPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x70766F0", Offset = "0x70756F0", VA = "0x1870766F0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool KCELJCEFDJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7074E90", Offset = "0x7073E90", VA = "0x187074E90", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool CHAADCEEPNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7076740", Offset = "0x7075740", VA = "0x187076740", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool HCHFDHPOPBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x70750B0", Offset = "0x70740B0", VA = "0x1870750B0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool AELBJINGBNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7074A60", Offset = "0x7073A60", VA = "0x187074A60", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> AIBCGEHPMDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7074D00", Offset = "0x7073D00", VA = "0x187074D00", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool DLPIEPELFJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7074AB0", Offset = "0x7073AB0", VA = "0x187074AB0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool MHNHICABHAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7074A10", Offset = "0x7073A10", VA = "0x187074A10", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool IPIBGJBAJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7075100", Offset = "0x7074100", VA = "0x187075100", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool NEKLAOAODJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7075660", Offset = "0x7074660", VA = "0x187075660", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool CHEEOKENJOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7076890", Offset = "0x7075890", VA = "0x187076890", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool BHBHMAMIMCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7074E40", Offset = "0x7073E40", VA = "0x187074E40", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool NIGMJIDGOKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7074D60", Offset = "0x7073D60", VA = "0x187074D60", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool LMMBCDGJGPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x70749C0", Offset = "0x70739C0", VA = "0x1870749C0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool EHJIAMCNKMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x70751A0", Offset = "0x70741A0", VA = "0x1870751A0", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event FCFPDDJHBAK<KLIEFAAGNPA> HAGKCPBLPAF
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7074F80", Offset = "0x7073F80", VA = "0x187074F80", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x70756B0", Offset = "0x70746B0", VA = "0x1870756B0", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2CAE190", Offset = "0x2CAD190", VA = "0x182CAE190", Slot = "6")]
	public (bool, T?) GODNGJGEGKK<T>(KLIEFAAGNPA BIICMLPHBIO) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2CAE380", Offset = "0x2CAD380", VA = "0x182CAE380")]
	public ODOJBJNKEAC LGBCPFDAEDK<T>(KLIEFAAGNPA BIICMLPHBIO, bool MCBIBMKCEKN, T CBAEIEAPLIH) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7076AF0", Offset = "0x7075AF0", VA = "0x187076AF0")]
	public ODOJBJNKEAC(PFDMNDENLBK NKEMKMPPMBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7076AD0", Offset = "0x7075AD0", VA = "0x187076AD0")]
	public ODOJBJNKEAC(PFDMNDENLBK NKEMKMPPMBN, [Optional] string? PEAPEFGOGIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7076B10", Offset = "0x7075B10", VA = "0x187076B10")]
	public ODOJBJNKEAC(ODOJBJNKEAC FPMAFGLANPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7076970", Offset = "0x7075970", VA = "0x187076970")]
	internal ODOJBJNKEAC(PFDMNDENLBK EFIHAMIPLDE, [Optional] string? PEAPEFGOGIB, [Optional] ODOJBJNKEAC? FPMAFGLANPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7075030", Offset = "0x7074030", VA = "0x187075030")]
	public static DLMFAGJHJFK GMCILANOBHH(KLIEFAAGNPA BIICMLPHBIO)
	{
		return default(DLMFAGJHJFK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7076870", Offset = "0x7075870", VA = "0x187076870")]
	public void PMBOEHEMMOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x70758B0", Offset = "0x70748B0", VA = "0x1870758B0")]
	internal ODOJBJNKEAC LMHJHIKKIKH(ODOJBJNKEAC IAENCKKPGIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x70751F0", Offset = "0x70741F0", VA = "0x1870751F0")]
	internal IReadOnlyCollection<KLIEFAAGNPA> IELCMBBNHEG(ODOJBJNKEAC FPMAFGLANPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7076790", Offset = "0x7075790", VA = "0x187076790")]
	public bool PCFKMHPECND(KLIEFAAGNPA BIICMLPHBIO, bool MCBIBMKCEKN, string FPMDGHPHION)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x70757B0", Offset = "0x70747B0", VA = "0x1870757B0")]
	public (bool, string) LDBDONOJOKE(KLIEFAAGNPA BIICMLPHBIO)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7074EE0", Offset = "0x7073EE0", VA = "0x187074EE0")]
	internal void FHJGFNMOMMO(KLIEFAAGNPA BIICMLPHBIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7074B00", Offset = "0x7073B00", VA = "0x187074B00")]
	public LDCBCBAILFK DBNMMMGHFJJ(Func<PFDMNDENLBK, Guid> MKNNFMGPDKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7075C80", Offset = "0x7074C80", VA = "0x187075C80")]
	public void NEDMOALGMDB(LDCBCBAILFK PPDGPFBOIAP, Func<Guid, PFDMNDENLBK> LBHMGPGFFNF, [Optional] PFDMNDENLBK? PCNNNHGGHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7074DB0", Offset = "0x7073DB0", VA = "0x187074DB0")]
	[CompilerGenerated]
	private void EAGBICCHGCJ(KLIEFAAGNPA CIPGDBFIHAJ, HDNEFDJCLMD EHHONJCECPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class IAHMMFPMDNF : HEDODPFNIMI, FPABHIHDCJN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class BBAGFMHPKJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public ODOJBJNKEAC newRole;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public BBAGFMHPKJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7068F30", Offset = "0x7067F30", VA = "0x187068F30")]
		internal bool FFJDNMGGBPE(ODOJBJNKEAC rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class PJOPIKLPNAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public PFDMNDENLBK roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public PJOPIKLPNAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7076C30", Offset = "0x7075C30", VA = "0x187076C30")]
		internal bool ILLDCCBNAEL(PFDMNDENLBK r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct MEFNPNKGMJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public IAHMMFPMDNF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public EIGMLKEEHNM roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<AICIEDPHEKP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7073F60", Offset = "0x7072F60", VA = "0x187073F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x70745D0", Offset = "0x70735D0", VA = "0x1870745D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class KPANCGEOHIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public KPANCGEOHIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7072660", Offset = "0x7071660", VA = "0x187072660")]
		internal void DMKIMKIJBCM(LDCBCBAILFK r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7072740", Offset = "0x7071740", VA = "0x187072740")]
		internal void DNBMOKHLNJD(LDCBCBAILFK r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct MAPHCCDGDOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public EIGMLKEEHNM roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class OFJNCKEMJNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Func<LDCBCBAILFK, HDNEFDJCLMD> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public OFJNCKEMJNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7076BA0", Offset = "0x7075BA0", VA = "0x187076BA0")]
		internal void EGEHEHBMGNB(LDCBCBAILFK r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7076C00", Offset = "0x7075C00", VA = "0x187076C00")]
		internal void PDGDCEPNHLB(LDCBCBAILFK r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7076BD0", Offset = "0x7075BD0", VA = "0x187076BD0")]
		internal void NONIFACNDOA(LDCBCBAILFK r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class LEDNPIKAHOB<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private struct <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public LEDNPIKAHOB<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private TaskAwaiter<AICIEDPHEKP> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x355CB90", Offset = "0x355BB90", VA = "0x18355CB90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x9FB160", Offset = "0x9FA160", VA = "0x1809FB160", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public KLIEFAAGNPA rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public PFDMNDENLBK accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public DLMFAGJHJFK recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public IAHMMFPMDNF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public LEDNPIKAHOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x42C77C0", Offset = "0x42C67C0", VA = "0x1842C77C0")]
		[AsyncStateMachine(typeof(LEDNPIKAHOB<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void KIMGIOOINOO()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct KAMEDFFCIJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public IReadOnlyList<OCJLDKOMKIC> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct ILEHOEOAFEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public BNKAFJDOMLF rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public EIGMLKEEHNM roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public IReadOnlyDictionary<PFDMNDENLBK, ODOJBJNKEAC> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public DNHLKDIIFLB debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7070EE0", Offset = "0x706FEE0", VA = "0x187070EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x70719F0", Offset = "0x70709F0", VA = "0x1870719F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly BNKAFJDOMLF EDCACBCOHII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly LBHBCKJNIDG AJNHBNEDKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly DNHLKDIIFLB BNNGHMOAPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly Dictionary<int, ODOJBJNKEAC> FEGEOFGHHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	internal readonly Dictionary<PFDMNDENLBK, ODOJBJNKEAC> IIDGLCKJPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	internal readonly Dictionary<PFDMNDENLBK, ODOJBJNKEAC> CECAKGAFOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	internal readonly List<ODOJBJNKEAC> BDJDGLFOHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private bool ADJHBJCGIEO;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly KLIEFAAGNPA[] GFIKMEEONNE;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public FOBAGAAEPPI EOHNKFNJOMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<OBMEIICEFCF> GGNGBDNNDCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x706FE50", Offset = "0x706EE50", VA = "0x18706FE50", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event MEEBEBGHDMC JOFCDKDOOCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x706FAC0", Offset = "0x706EAC0", VA = "0x18706FAC0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x706DB40", Offset = "0x706CB40", VA = "0x18706DB40", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x706EA00", Offset = "0x706DA00", VA = "0x18706EA00")]
	[PECFDJPHGEK(HCAAGBIMBOB.Room, BOIKMOKIOJG.None)]
	private static void KOPFFNBBLLA(DIIANKCHAHD MEBNPCGEJCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7070C20", Offset = "0x706FC20", VA = "0x187070C20")]
	[UnityEngine.Scripting.Preserve]
	internal IAHMMFPMDNF([JFHFHOOOEKP(null)] BNKAFJDOMLF FMGLCEGLEHH, [JFHFHOOOEKP(null)] LBHBCKJNIDG NFGPEEJOFHF, [JFHFHOOOEKP(null)] DNHLKDIIFLB BNNGHMOAPNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x706C130", Offset = "0x706B130", VA = "0x18706C130", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x706D2C0", Offset = "0x706C2C0", VA = "0x18706D2C0")]
	private void HJDAGALNAGC(IEnumerable<ODOJBJNKEAC> BEANGLLMMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x706F9F0", Offset = "0x706E9F0", VA = "0x18706F9F0", Slot = "12")]
	public bool LNAGJBGKNNI(NMCPPAKMEBO GOBKHJJOFMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x706BF90", Offset = "0x706AF90", VA = "0x18706BF90")]
	private void CNNPHGODEJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x706E810", Offset = "0x706D810", VA = "0x18706E810")]
	private void KNJCKEECHMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x70709D0", Offset = "0x706F9D0", VA = "0x1870709D0", Slot = "10")]
	public IReadOnlyList<OBMEIICEFCF> OKJFKFCDIKO(bool KHHDIDCIHIK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x706B3A0", Offset = "0x706A3A0", VA = "0x18706B3A0", Slot = "11")]
	public OBMEIICEFCF ACPOJDAOIJB(NMCPPAKMEBO GOBKHJJOFMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x706D1F0", Offset = "0x706C1F0", VA = "0x18706D1F0")]
	private PFDMNDENLBK HEPDOHLPGNI(NMCPPAKMEBO GOBKHJJOFMO)
	{
		return default(PFDMNDENLBK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x706BFA0", Offset = "0x706AFA0", VA = "0x18706BFA0", Slot = "14")]
	public bool DFMPBDMGABP(NMCPPAKMEBO PGCKLAOMDLP, PFDMNDENLBK NKEMKMPPMBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x706C240", Offset = "0x706B240", VA = "0x18706C240", Slot = "15")]
	public OBMEIICEFCF EAJDOEIIDAE(PFDMNDENLBK NKEMKMPPMBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x706DBE0", Offset = "0x706CBE0", VA = "0x18706DBE0")]
	private static bool JDCBAAPIMPJ(FOFMBACAHBB HBOKAFLMEBK, PFDMNDENLBK NKEMKMPPMBN, [Out] LDCBCBAILFK? GCINHLEJLLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x706E490", Offset = "0x706D490", VA = "0x18706E490")]
	private static void KMMAKELFKCC(FOFMBACAHBB HBOKAFLMEBK, Action<LDCBCBAILFK> IOHIDABHMHM, PFDMNDENLBK BCOGPBPBLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x706E580", Offset = "0x706D580", VA = "0x18706E580")]
	private static void KMMAKELFKCC(FOFMBACAHBB HBOKAFLMEBK, Action<LDCBCBAILFK> IOHIDABHMHM, Predicate<PFDMNDENLBK> FOEBNCAENCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x706CD10", Offset = "0x706BD10", VA = "0x18706CD10")]
	private void FHJKPHLOIOK(NMCPPAKMEBO GOBKHJJOFMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x706D0D0", Offset = "0x706C0D0", VA = "0x18706D0D0", Slot = "4")]
	[AsyncStateMachine(typeof(MEFNPNKGMJL))]
	public Task HCONEALAIIN([CanBeNull] EIGMLKEEHNM ENLCDNNHBBD, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "5")]
	public void GEOGHMOFLDJ(EIGMLKEEHNM ENLCDNNHBBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x706BB40", Offset = "0x706AB40", VA = "0x18706BB40")]
	private void CCFIFMEHFAA(FOFMBACAHBB PKCPKIDIHLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x706B830", Offset = "0x706A830", VA = "0x18706B830")]
	internal static string BOAKKPACCLB(BNKAFJDOMLF EDCACBCOHII, EIGMLKEEHNM ENLCDNNHBBD, IReadOnlyDictionary<PFDMNDENLBK, ODOJBJNKEAC> IIDGLCKJPHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x706EBC0", Offset = "0x706DBC0", VA = "0x18706EBC0")]
	private static void LJPEGCPPLPD(EIGMLKEEHNM ENLCDNNHBBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x706CD80", Offset = "0x706BD80", VA = "0x18706CD80")]
	private static void FJNBKOMMFNJ(FOFMBACAHBB BKLNIALJADH, IReadOnlyDictionary<PFDMNDENLBK, ODOJBJNKEAC> IIDGLCKJPHI, StringBuilder IPEJIJKAFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x706BE80", Offset = "0x706AE80", VA = "0x18706BE80")]
	private static bool CELHHHALFAG(string NMCDBBCIIGC, [Out] Guid BLHBACAONIH, [Out] PFDMNDENLBK NKEMKMPPMBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7070290", Offset = "0x706F290", VA = "0x187070290")]
	private static void NOAJHAKJGME(EIGMLKEEHNM ENLCDNNHBBD, StringBuilder IPEJIJKAFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2B42D70", Offset = "0x2B41D70", VA = "0x182B42D70", Slot = "16")]
	public bool IGGDDGACJEO<T>(PFDMNDENLBK NKEMKMPPMBN, KLIEFAAGNPA BIICMLPHBIO, bool MCBIBMKCEKN, T HFLBLCMJIKA, [Optional] Action CGLOCPHHGOE) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7070210", Offset = "0x706F210", VA = "0x187070210", Slot = "17")]
	public string NJBPANIAPAP(KLIEFAAGNPA BIICMLPHBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x706E280", Offset = "0x706D280", VA = "0x18706E280")]
	private void KJDOKMKBKMF(PFDMNDENLBK NKEMKMPPMBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x706E260", Offset = "0x706D260", VA = "0x18706E260")]
	private bool KHMOEAEGJFL(NMCPPAKMEBO GOBKHJJOFMO, PFDMNDENLBK NKEMKMPPMBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x706DF10", Offset = "0x706CF10", VA = "0x18706DF10")]
	internal ODOJBJNKEAC KCJGGAGPLEC(NMCPPAKMEBO GOBKHJJOFMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x706B820", Offset = "0x706A820", VA = "0x18706B820", Slot = "13")]
	public IReadOnlyList<OBMEIICEFCF> BKIMBLKOJFH(NMCPPAKMEBO GOBKHJJOFMO, bool IFGKAGLGEFC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x706FEA0", Offset = "0x706EEA0", VA = "0x18706FEA0")]
	internal IReadOnlyList<ODOJBJNKEAC> MMOBAGJIOGF(NMCPPAKMEBO GOBKHJJOFMO, bool IFGKAGLGEFC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x706C580", Offset = "0x706B580", VA = "0x18706C580")]
	private void FGLNFIJCGAP(AICIEDPHEKP PCNIECGNGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x706FB60", Offset = "0x706EB60", VA = "0x18706FB60")]
	private static bool MEJLIDGNCID(ODOJBJNKEAC AKNKEPEPEIO, IReadOnlyDictionary<PFDMNDENLBK, ODOJBJNKEAC> IIDGLCKJPHI, [Out] IReadOnlyList<KLIEFAAGNPA> JAMIKJELIIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x70700D0", Offset = "0x706F0D0", VA = "0x1870700D0")]
	[AsyncStateMachine(typeof(ILEHOEOAFEP))]
	private static Task NAMAEJGDOIB(BNKAFJDOMLF EDCACBCOHII, EIGMLKEEHNM ENLCDNNHBBD, IReadOnlyDictionary<PFDMNDENLBK, ODOJBJNKEAC> IIDGLCKJPHI, DNHLKDIIFLB BNNGHMOAPNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x706C2E0", Offset = "0x706B2E0", VA = "0x18706C2E0")]
	[CompilerGenerated]
	internal static void FDLMFANJALM(Func<LDCBCBAILFK, HDNEFDJCLMD> ANFPLNABALP, MAPHCCDGDOC P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x706B4B0", Offset = "0x706A4B0", VA = "0x18706B4B0")]
	[CompilerGenerated]
	internal static bool BFAMLKNELNP(PFDMNDENLBK NKEMKMPPMBN, KLIEFAAGNPA BIICMLPHBIO, [Out] OCJLDKOMKIC BOOPFINDCDD, KAMEDFFCIJE P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface DLGDJBEHFNF
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DDCOAGGOFPB(NMCPPAKMEBO DNPMFIKIJBJ, NMCPPAKMEBO BNKKBIBKIBB, IEnumerable<NMCPPAKMEBO> KEGIJNLNCKP, [Out] EADEAPBEIII GEKIDEHFFFJ, [Out] IIILOJGPDDO KGOJMBAMNLF);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string LPOFEINPCEP(IIILOJGPDDO FMFLJGHHPMC);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum IIILOJGPDDO : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	CantKickEventOrganizer,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	Broadcaster,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	GameInProgress,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	OpponentGameInProgress
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class FPHCDGMLJIE : DLGDJBEHFNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly FPABHIHDCJN MMGLIMOJNFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly KGCDDKAEBNG JDKELGCMPGH;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x86A7E0", Offset = "0x8697E0", VA = "0x18086A7E0")]
	[RecRoom.NoEngine.Common.Preserve]
	public FPHCDGMLJIE([JFHFHOOOEKP(null)] FPABHIHDCJN AHCCCDLELLJ, [JFHFHOOOEKP(null)] KGCDDKAEBNG LNHNBHFNNEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7069AF0", Offset = "0x7068AF0", VA = "0x187069AF0")]
	private static ECEKJCDPLNJ? OFDNDIMHNBO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x70692D0", Offset = "0x70682D0", VA = "0x1870692D0", Slot = "4")]
	public bool DDCOAGGOFPB(NMCPPAKMEBO DNPMFIKIJBJ, NMCPPAKMEBO BNKKBIBKIBB, IEnumerable<NMCPPAKMEBO> KEGIJNLNCKP, [Out] EADEAPBEIII GEKIDEHFFFJ, [Out] IIILOJGPDDO KGOJMBAMNLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x70699F0", Offset = "0x70689F0", VA = "0x1870699F0", Slot = "5")]
	public string LPOFEINPCEP(IIILOJGPDDO FMFLJGHHPMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x70693D0", Offset = "0x70683D0", VA = "0x1870693D0")]
	internal bool JNKOHKKGIKN(NMCPPAKMEBO DNPMFIKIJBJ, NMCPPAKMEBO BNKKBIBKIBB, IEnumerable<NMCPPAKMEBO> KEGIJNLNCKP, KBIHKJABELE DPMMJNEEKNM, ECEKJCDPLNJ? CMOEEOPBGGM, [Out] EADEAPBEIII GEKIDEHFFFJ, [Out] IIILOJGPDDO KGOJMBAMNLF)
	{
		return default(bool);
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
