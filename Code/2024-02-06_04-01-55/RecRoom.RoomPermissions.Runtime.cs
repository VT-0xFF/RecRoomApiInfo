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
		[Cpp2IlInjected.Address(RVA = "0x7C9520", Offset = "0x7C8920", VA = "0x1807C9520")]
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
		[Cpp2IlInjected.Address(RVA = "0x66F9A00", Offset = "0x66F8E00", VA = "0x1866F9A00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7CA360", Offset = "0x7C9760", VA = "0x1807CA360")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CA3A0", Offset = "0x7C97A0", VA = "0x1807CA3A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum AINOBBBAOPD
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void JKELHNNGEMG<TPermission>(TPermission FFOMMAAGHLD);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void KOGALCOHGEG(KFLCLHKINNK FKOLNPOECGI);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum KDLDEFLGJLH
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface OGPDLNEIDJC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool CHEHLDGOIOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool DJBDBIOOKNK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool MMIMJBEKMIF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool JHMADABCBKK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool LNCAJOGFFJK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool EFPDECCBIGP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class PBALKPGBGEM
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	public enum KMLCBCFNCEB
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
	public static readonly Guid LMINOOEMAPP;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid JPKOOJKKNFN;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid NCJHHAKCHCH;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid GBBMLHMFLEA;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid AECFBNPAKPI;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid JEAIHEKKAGJ;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly JDIGNNKIMOJ<LHHNGKFKNHJ, Guid> OOKPLIMIHNC;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<LHHNGKFKNHJ> EAGNIHNNLCN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x66F9D90", Offset = "0x66F9190", VA = "0x1866F9D90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x66FA070", Offset = "0x66F9470", VA = "0x1866FA070")]
	public static LHHNGKFKNHJ MIKNPHEGNAL(Guid LHLNCEHJAOH)
	{
		return default(LHHNGKFKNHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x66F9EE0", Offset = "0x66F92E0", VA = "0x1866F9EE0")]
	public static Guid IBJGIAEGNLL(LHHNGKFKNHJ GIJIKLCBCNK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x66F9E10", Offset = "0x66F9210", VA = "0x1866F9E10")]
	public static bool EHDBAGAKADE(LHHNGKFKNHJ GIJIKLCBCNK, [Out] Guid LHLNCEHJAOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x66FA100", Offset = "0x66F9500", VA = "0x1866FA100")]
	public static bool NOHAKCDDGCI(Guid LHLNCEHJAOH, [Out] LHHNGKFKNHJ GIJIKLCBCNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x66F9EA0", Offset = "0x66F92A0", VA = "0x1866F9EA0")]
	public static LHHNGKFKNHJ HPIOCCNGIND(LHHNGKFKNHJ GIJIKLCBCNK)
	{
		return default(LHHNGKFKNHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x66F9F80", Offset = "0x66F9380", VA = "0x1866F9F80")]
	public static KMLCBCFNCEB JCHEJPPFAKJ(LHHNGKFKNHJ DBPMDECBJJG)
	{
		return default(KMLCBCFNCEB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x66FA030", Offset = "0x66F9430", VA = "0x1866FA030")]
	internal static LHHNGKFKNHJ LHLNHOJPEII(KMLCBCFNCEB EALPJAGDDIM)
	{
		return default(LHHNGKFKNHJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NKKDGHCBJEJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	AICJLJNELGK BHFLGLLGFJM
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<BMNDKIMONCI> GEGBEAFKGNL
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event KOGALCOHGEG KLJKLBKPLDE;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<BMNDKIMONCI> FGBGCFLKKGJ(bool DLHPDAEGADP = false);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BMNDKIMONCI CCHDMKDDJOK(KFLCLHKINNK FKOLNPOECGI);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CJFGNGBOEGP(KFLCLHKINNK FKOLNPOECGI);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<BMNDKIMONCI> KADFDPCIEKL(KFLCLHKINNK FKOLNPOECGI, bool ODNKMLJNENO = false);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool ODENCABLCMO(KFLCLHKINNK ACCNJPNEAEC, LHHNGKFKNHJ GIJIKLCBCNK);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "9")]
	BMNDKIMONCI DJJDLHHBICC(LHHNGKFKNHJ GIJIKLCBCNK);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool KNCOJFCMGLM<T>(LHHNGKFKNHJ GIJIKLCBCNK, AOBBAGCAMNE FFOMMAAGHLD, bool JJKEMIFNKDM, T CMDECJALHDG) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KAAFOMFNNBK
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task EHENBNFJOJM(NLMALJAJAJA FOIDNCOOLGM, CancellationToken PPJMMMGPFGD);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NLFBIILGPIA(NLMALJAJAJA FOIDNCOOLGM);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface OAKPCAPFDMH
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	KFLCLHKINNK KJAJFPJIMIC
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	OEHGHGGPHPE LDHMFCBPOHI
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	HPNCJKDLPEK PNHFELHEPEF
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<JLILPFNOBOJ> LMJANBLDCLN;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action HKMMHJGFCHA;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LHHNGKFKNHJ ANDJCCABMHL(KFLCLHKINNK FKOLNPOECGI);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<JLILPFNOBOJ> GKPDEJPDKND(CancellationToken PPJMMMGPFGD);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task ILKGHMPKGAN(long KKFMPNCGPKO, long PNGKNHBLMMO, IReadOnlyList<GMFAJOEABMH> HCFLGDFMCHN);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<KFLCLHKINNK> DJPONIKJCBA();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class BEILNAPLMFG
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x66ED340", Offset = "0x66EC740", VA = "0x1866ED340")]
	public static LHHNGKFKNHJ HMHEJIOEFCN(this OAKPCAPFDMH NIJMCKGFMJC)
	{
		return default(LHHNGKFKNHJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface PPECBLJLKHH<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string KMBCFOJKCJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event JKELHNNGEMG<TPermission> PKBNALPCGGF;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class FEHOFPKIOAH
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? DMNGGFGCFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7A26D0", Offset = "0x7A1AD0", VA = "0x1807A26D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7A26E0", Offset = "0x7A1AE0", VA = "0x1807A26E0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7AAC60", Offset = "0x7AA060", VA = "0x1807AAC60")]
	protected FEHOFPKIOAH(object? JCFFGKHGLPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool GEAGEIGGDBG(object? ANJCCKHBJJO);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class JHGIDFNPJGA<T> : FEHOFPKIOAH where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private T CAOMIILCNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly IEqualityComparer<T> BELBPGMFIAC;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T BDGBGLMDOLF
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x817E40", Offset = "0x817240", VA = "0x180817E40")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3A34790", Offset = "0x3A33B90", VA = "0x183A34790", Slot = "4")]
	public override bool GEAGEIGGDBG(object? ANJCCKHBJJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3A34390", Offset = "0x3A33790", VA = "0x183A34390")]
	public bool FBDEFAHBAHI(T JLAGPGNMFIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3A34960", Offset = "0x3A33D60", VA = "0x183A34960")]
	public JHGIDFNPJGA(T ELCHMECHBCC, IEqualityComparer<T> BELBPGMFIAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class HLIJFGGFCJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<AOBBAGCAMNE, bool> LENHOGEPAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<AOBBAGCAMNE, FEHOFPKIOAH> MNCHBEHFNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly DCMAPBJLDGE OOMJHOHFFDP;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x66F7970", Offset = "0x66F6D70", VA = "0x1866F7970")]
	public HLIJFGGFCJP(DCMAPBJLDGE OOMJHOHFFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x66F7750", Offset = "0x66F6B50", VA = "0x1866F7750")]
	public bool IIBLIKJFEIL(AOBBAGCAMNE FFOMMAAGHLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x268D850", Offset = "0x268CC50", VA = "0x18268D850")]
	public bool NALGGIIEIFI<T>(AOBBAGCAMNE FFOMMAAGHLD, bool JJKEMIFNKDM, T ANJCCKHBJJO) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x268D480", Offset = "0x268C880", VA = "0x18268D480")]
	public (bool, T?) HKIAKDMPCPP<T>(AOBBAGCAMNE FFOMMAAGHLD) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x66F77C0", Offset = "0x66F6BC0", VA = "0x1866F77C0")]
	public bool NALGGIIEIFI(AOBBAGCAMNE FFOMMAAGHLD, bool JJKEMIFNKDM, object ANJCCKHBJJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x66F7680", Offset = "0x66F6A80", VA = "0x1866F7680")]
	public (bool, object) HKIAKDMPCPP(AOBBAGCAMNE FFOMMAAGHLD)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x268D440", Offset = "0x268C840", VA = "0x18268D440")]
	private void DDNLLKHGHMK<T>(AOBBAGCAMNE FFOMMAAGHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x66F78A0", Offset = "0x66F6CA0", VA = "0x1866F78A0")]
	private FEHOFPKIOAH PNNFJMLEEFI(AOBBAGCAMNE FFOMMAAGHLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x66F7480", Offset = "0x66F6880", VA = "0x1866F7480")]
	public void DIPLLFFCION()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class ECDFKFMBFDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly string AHFHDEHNJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly Type LJIOKLJGBIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly ACGEFADDKOJ IHHIJLNMFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly AOBBAGCAMNE LMMAAAEHOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public HDADHNANOAB KLBCPIEFNJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NMMNLOKEHPE BBHJCJIFMFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public FJLABDPILDP IBNJHBMPCEG;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x66F1580", Offset = "0x66F0980", VA = "0x1866F1580")]
	public ECDFKFMBFDD(Type CNIMCIOOLCI, string LPCDOJGFLAD, AOBBAGCAMNE FFOMMAAGHLD, HDADHNANOAB MPJKBALKAFD, NMMNLOKEHPE KFOEFMAOKBB, FJLABDPILDP NBLLNAKOPOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x66F1480", Offset = "0x66F0880", VA = "0x1866F1480")]
	public object BFEFCDFFNMB(object? KMJGEHGGFFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2538320", Offset = "0x2537720", VA = "0x182538320")]
	public void DDNLLKHGHMK<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x66F14D0", Offset = "0x66F08D0", VA = "0x1866F14D0")]
	public void DDNLLKHGHMK(Type DLABPBFHGEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class DKGOIHLPFFG<T> : ECDFKFMBFDD where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string DJKKKCMNJJD(T ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T MEIIHKBADHH(string? PJNIJBMCIHC, T ELCHMECHBCC);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class DJAEAJKOEBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public DJKKKCMNJJD serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public MEIIHKBADHH parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public DJAEAJKOEBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4FDF200", Offset = "0x4FDE600", VA = "0x184FDF200")]
		internal string BOHAJKGCMGE(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4FDF340", Offset = "0x4FDE740", VA = "0x184FDF340")]
		internal object MAMCHPDOEPM(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5006FB0", Offset = "0x50063B0", VA = "0x185006FB0")]
	public DKGOIHLPFFG(AOBBAGCAMNE FFOMMAAGHLD, string LPCDOJGFLAD, [Optional] DJKKKCMNJJD? MPJKBALKAFD, [Optional] MEIIHKBADHH? KFOEFMAOKBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x50069D0", Offset = "0x5005DD0", VA = "0x1850069D0")]
	private static object? JCEFODEMOAF(MEIIHKBADHH? KFOEFMAOKBB, string? PJNIJBMCIHC, object? ELCHMECHBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5006410", Offset = "0x5005810", VA = "0x185006410")]
	private static string ILCGODJBNBA(DJKKKCMNJJD? HDNOJEBGFEP, object? ANJCCKHBJJO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string HDADHNANOAB(object? ANJCCKHBJJO);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object NMMNLOKEHPE(string? PJNIJBMCIHC, [Optional] object ELCHMECHBCC);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate FEHOFPKIOAH FJLABDPILDP();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class DCMAPBJLDGE
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class ENJDFJEOIDE : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal static ENJDFJEOIDE GHDJCOLHINO;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x66F1620", Offset = "0x66F0A20", VA = "0x1866F1620", Slot = "4")]
		public bool Equals(List<string> NEEBEKKMNIB, List<string> IGHOLFEOMDB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x66F1770", Offset = "0x66F0B70", VA = "0x1866F1770", Slot = "5")]
		public int GetHashCode(List<string> BHPOPDOKECN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public ENJDFJEOIDE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class PAOCADDIEHC : DGGHFAKKHBO<AINOBBBAOPD>
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x66F9A80", Offset = "0x66F8E80", VA = "0x1866F9A80", Slot = "9")]
		public override string ILCGODJBNBA(AINOBBBAOPD EPJNNNGOOAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x66F9B70", Offset = "0x66F8F70", VA = "0x1866F9B70", Slot = "10")]
		protected override bool JMBHIAHJHGD(string EPJNNNGOOAO, [Out] AINOBBBAOPD ANJCCKHBJJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x66F9D50", Offset = "0x66F9150", VA = "0x1866F9D50")]
		public PAOCADDIEHC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly IHABMHMBDGE CEHGHIIMNOF;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly PAOCADDIEHC EFPKJBPIJFL;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly List<ECDFKFMBFDD> EDNLIPMBLBM;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<AOBBAGCAMNE> KCEKAMMJHFK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7A26D0", Offset = "0x7A1AD0", VA = "0x1807A26D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<AOBBAGCAMNE, ECDFKFMBFDD> PHDBBAEHLED
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x66EEF50", Offset = "0x66EE350", VA = "0x1866EEF50")]
	public DCMAPBJLDGE([Optional] IList<ECDFKFMBFDD>? JALIBDCDEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x66EE0E0", Offset = "0x66ED4E0", VA = "0x1866EE0E0")]
	public ECDFKFMBFDD CGHHOCJHLIJ(AOBBAGCAMNE FFOMMAAGHLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface AICJLJNELGK
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	BMNDKIMONCI HGOICKLJCBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class BIOHOMJEIMK : AICJLJNELGK
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static BIOHOMJEIMK OEGIBPILGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly DLLDGBBDOIG GHMNEMOGLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal readonly IReadOnlyList<DLLDGBBDOIG> NFIFLAIBNII;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public BMNDKIMONCI HGOICKLJCBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7A26D0", Offset = "0x7A1AD0", VA = "0x1807A26D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x66EDDD0", Offset = "0x66ED1D0", VA = "0x1866EDDD0")]
	public BIOHOMJEIMK(DLLDGBBDOIG ECFLIOBNLKP, IReadOnlyList<DLLDGBBDOIG> PEABJHLNBKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x66ED3A0", Offset = "0x66EC7A0", VA = "0x1866ED3A0")]
	private static BIOHOMJEIMK GIPPFGMJHHP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class KENJFFHPNBM
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<LHHNGKFKNHJ> MICNMHIIKDF;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x66F84C0", Offset = "0x66F78C0", VA = "0x1866F84C0")]
	public static bool AIHHIEENJJI(this KFLCLHKINNK FOOMBINNFPN, LHHNGKFKNHJ GIJIKLCBCNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x66F85A0", Offset = "0x66F79A0", VA = "0x1866F85A0")]
	public static bool OOPLGEONPHG(this KFLCLHKINNK FOOMBINNFPN, LHHNGKFKNHJ GIJIKLCBCNK, HPNCJKDLPEK ACDIECKOFJI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface IOBKNMLOGMJ
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool EFDKCLFHJMK
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool AOAANFFMOOD
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool DJPBALBJEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool NNIHPHCGLBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool PNBADKAHCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool EGENMJHNOCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool AELFJHFHIED
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool DGPJFMMHHGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool OOPKHBODDAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool LCEGAKKPPGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool OJCIANGDDIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool JKDLIDFGJEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> DJBAGFLELAN
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	AINOBBBAOPD KIGKDOOODBE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface BMNDKIMONCI : IOBKNMLOGMJ, OGPDLNEIDJC, PPECBLJLKHH<AOBBAGCAMNE>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string NBNELOOCAPO
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	LHHNGKFKNHJ AHDGBLBOENF
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) JKICJDGHGGA<T>(AOBBAGCAMNE FFOMMAAGHLD) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum AOBBAGCAMNE
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
	AUTO_ASSIGNED_PLAYER_TAGS = 24
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal class DLLDGBBDOIG : BMNDKIMONCI, IOBKNMLOGMJ, OGPDLNEIDJC, PPECBLJLKHH<AOBBAGCAMNE>
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal static readonly DCMAPBJLDGE FDONJMKIMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly HLIJFGGFCJP LMINKODKMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private string? EBLLDNCEIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private string? NHBGCMGLJFF;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool EKHJMPKPNFE
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x66EF7F0", Offset = "0x66EEBF0", VA = "0x1866EF7F0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool LFEELGIACON
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x66F0410", Offset = "0x66EF810", VA = "0x1866F0410", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool LAGPFDOHDAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x66F0500", Offset = "0x66EF900", VA = "0x1866F0500", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool NPCGCGAHBCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x66F0370", Offset = "0x66EF770", VA = "0x1866F0370", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool KPKGKEKDDGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x66EF720", Offset = "0x66EEB20", VA = "0x1866EF720", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool FJDGHMHOGKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x66F0460", Offset = "0x66EF860", VA = "0x1866F0460", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public LHHNGKFKNHJ AHDGBLBOENF
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x817E40", Offset = "0x817240", VA = "0x180817E40", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(LHHNGKFKNHJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7ACF80", Offset = "0x7AC380", VA = "0x1807ACF80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string KMBCFOJKCJO
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x66F0A80", Offset = "0x66EFE80", VA = "0x1866F0A80", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x66F0320", Offset = "0x66EF720", VA = "0x1866F0320")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string NBNELOOCAPO
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x66F0A80", Offset = "0x66EFE80", VA = "0x1866F0A80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool GJLGIANLKNF
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x888300", Offset = "0x887700", VA = "0x180888300")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x887D30", Offset = "0x887130", VA = "0x180887D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool EFDKCLFHJMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x66EF2F0", Offset = "0x66EE6F0", VA = "0x1866EF2F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public AINOBBBAOPD KIGKDOOODBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x66F03C0", Offset = "0x66EF7C0", VA = "0x1866F03C0", Slot = "20")]
		get
		{
			return default(AINOBBBAOPD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool AOAANFFMOOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x66EF6D0", Offset = "0x66EEAD0", VA = "0x1866EF6D0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool DJPBALBJEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x66F0550", Offset = "0x66EF950", VA = "0x1866F0550", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool NNIHPHCGLBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x66F0C50", Offset = "0x66F0050", VA = "0x1866F0C50", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool PNBADKAHCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x66F0C00", Offset = "0x66F0000", VA = "0x1866F0C00", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool EGENMJHNOCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x66F02D0", Offset = "0x66EF6D0", VA = "0x1866F02D0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool AELFJHFHIED
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x66F0BB0", Offset = "0x66EFFB0", VA = "0x1866F0BB0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool DGPJFMMHHGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x66F04B0", Offset = "0x66EF8B0", VA = "0x1866F04B0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool OOPKHBODDAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x66EF840", Offset = "0x66EEC40", VA = "0x1866EF840", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> DJBAGFLELAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x66F05A0", Offset = "0x66EF9A0", VA = "0x1866F05A0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool CCLFJDMMGEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x66EF7F0", Offset = "0x66EEBF0", VA = "0x1866EF7F0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool JOOPHOKNAGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x66EF720", Offset = "0x66EEB20", VA = "0x1866EF720", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool HGNEMJKKBCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x66F0410", Offset = "0x66EF810", VA = "0x1866F0410", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool LCEGAKKPPGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x66EF2A0", Offset = "0x66EE6A0", VA = "0x1866EF2A0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool OJCIANGDDIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x66EF5F0", Offset = "0x66EE9F0", VA = "0x1866EF5F0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool GECCGOMHOIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x66F0500", Offset = "0x66EF900", VA = "0x1866F0500", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool JKDLIDFGJEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x66EF8B0", Offset = "0x66EECB0", VA = "0x1866EF8B0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool PDBNBJELGOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x66F0370", Offset = "0x66EF770", VA = "0x1866F0370", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool IFLBOJODPKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x66F0460", Offset = "0x66EF860", VA = "0x1866F0460", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event JKELHNNGEMG<AOBBAGCAMNE> PKBNALPCGGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x66F0CA0", Offset = "0x66F00A0", VA = "0x1866F0CA0", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x66EF340", Offset = "0x66EE740", VA = "0x1866EF340", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x251F930", Offset = "0x251ED30", VA = "0x18251F930", Slot = "6")]
	public (bool, T?) JKICJDGHGGA<T>(AOBBAGCAMNE FFOMMAAGHLD) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x251FAC0", Offset = "0x251EEC0", VA = "0x18251FAC0")]
	public DLLDGBBDOIG PCHLMDIFCJD<T>(AOBBAGCAMNE FFOMMAAGHLD, bool JJKEMIFNKDM, T ANJCCKHBJJO) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x66F1460", Offset = "0x66F0860", VA = "0x1866F1460")]
	public DLLDGBBDOIG(LHHNGKFKNHJ GIJIKLCBCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x66F1250", Offset = "0x66F0650", VA = "0x1866F1250")]
	public DLLDGBBDOIG(LHHNGKFKNHJ GIJIKLCBCNK, [Optional] string? EBLLDNCEIOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x66F1270", Offset = "0x66F0670", VA = "0x1866F1270")]
	public DLLDGBBDOIG(DLLDGBBDOIG CPCJNDAGAAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x66F1300", Offset = "0x66F0700", VA = "0x1866F1300")]
	internal DLLDGBBDOIG(LHHNGKFKNHJ KKGANIDBBJP, [Optional] string? EBLLDNCEIOD, [Optional] DLLDGBBDOIG? CPCJNDAGAAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x66EF770", Offset = "0x66EEB70", VA = "0x1866EF770")]
	public static ACGEFADDKOJ COCHLNBPLOJ(AOBBAGCAMNE FFOMMAAGHLD)
	{
		return default(ACGEFADDKOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x66EF890", Offset = "0x66EEC90", VA = "0x1866EF890")]
	public void DIPLLFFCION()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x66F0600", Offset = "0x66EFA00", VA = "0x1866F0600")]
	internal DLLDGBBDOIG JBHKEEJKDCD(DLLDGBBDOIG KPFPGJONLFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x66F0D50", Offset = "0x66F0150", VA = "0x1866F0D50")]
	internal IReadOnlyCollection<AOBBAGCAMNE> PEJOGFDJNOA(DLLDGBBDOIG CPCJNDAGAAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x66F0AD0", Offset = "0x66EFED0", VA = "0x1866F0AD0")]
	public bool MBPMPPPPPLN(AOBBAGCAMNE FFOMMAAGHLD, bool JJKEMIFNKDM, string MKADDKJJKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x66F0980", Offset = "0x66EFD80", VA = "0x1866F0980")]
	public (bool, string) JFFBLPILNDA(AOBBAGCAMNE FFOMMAAGHLD)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x66EF900", Offset = "0x66EED00", VA = "0x1866EF900")]
	internal void EKKLPAHMNAG(AOBBAGCAMNE FFOMMAAGHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x66EF3F0", Offset = "0x66EE7F0", VA = "0x1866EF3F0")]
	public EICCCEGCBEC AHKAOMDIIDB(Func<LHHNGKFKNHJ, Guid> JMEBPABGNNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x66EF950", Offset = "0x66EED50", VA = "0x1866EF950")]
	public void FAADNEIHFDO(EICCCEGCBEC DKBMHFOBDBE, Func<Guid, LHHNGKFKNHJ> MPNEIEEPGGI, [Optional] LHHNGKFKNHJ? OAMJOMEJLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x66EF640", Offset = "0x66EEA40", VA = "0x1866EF640")]
	[CompilerGenerated]
	private void BMOCCENEOFI(AOBBAGCAMNE LGIOGDFKDCD, MMCJGEGPHHF OBECCKKBOMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class HFHODJIAMEF : KAAFOMFNNBK, NKKDGHCBJEJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class KECDKNDFGDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public DLLDGBBDOIG newRole;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public KECDKNDFGDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x66F8490", Offset = "0x66F7890", VA = "0x1866F8490")]
		internal bool GFNPMAKLPBD(DLLDGBBDOIG rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class IOLBJLKNEMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public LHHNGKFKNHJ roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public IOLBJLKNEMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x66F8480", Offset = "0x66F7880", VA = "0x1866F8480")]
		internal bool MDEGJAAEDLD(LHHNGKFKNHJ r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct NGFOMODDNFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public HFHODJIAMEF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public NLMALJAJAJA roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<JLILPFNOBOJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x66F9340", Offset = "0x66F8740", VA = "0x1866F9340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x66F99A0", Offset = "0x66F8DA0", VA = "0x1866F99A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class BPBFCFAFJBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public BPBFCFAFJBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x66EE000", Offset = "0x66ED400", VA = "0x1866EE000")]
		internal void NBLMBOEMLDF(EICCCEGCBEC r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x66EDEE0", Offset = "0x66ED2E0", VA = "0x1866EDEE0")]
		internal void BPCCLHBJINN(EICCCEGCBEC r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct ENNPBNEBEGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public NLMALJAJAJA roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class GKJICMGOLBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Func<EICCCEGCBEC, MMCJGEGPHHF> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public GKJICMGOLBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x66F1990", Offset = "0x66F0D90", VA = "0x1866F1990")]
		internal void BGIDJBENPMK(EICCCEGCBEC r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x66F19C0", Offset = "0x66F0DC0", VA = "0x1866F19C0")]
		internal void MGALJIEJDOB(EICCCEGCBEC r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x66F1960", Offset = "0x66F0D60", VA = "0x1866F1960")]
		internal void AFOBMCFEBCL(EICCCEGCBEC r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class AIOAKOGCGOM<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private struct <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public AIOAKOGCGOM<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			private object <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private int <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			private TaskAwaiter<JLILPFNOBOJ> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x30C4F60", Offset = "0x30C4360", VA = "0x1830C4F60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x910560", Offset = "0x90F960", VA = "0x180910560", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public HFHODJIAMEF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public AOBBAGCAMNE rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public LHHNGKFKNHJ accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public ACGEFADDKOJ recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public string serializedNewValue;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public AIOAKOGCGOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x36D8BF0", Offset = "0x36D7FF0", VA = "0x1836D8BF0")]
		[AsyncStateMachine(typeof(AIOAKOGCGOM<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void NBBNPBODICG()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct LLGFDIGAEJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public IReadOnlyList<GMFAJOEABMH> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct MBIIJLEHKOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public OAKPCAPFDMH rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public NLMALJAJAJA roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public IReadOnlyDictionary<LHHNGKFKNHJ, DLLDGBBDOIG> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public HDDNBKOPHMD debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x66F87D0", Offset = "0x66F7BD0", VA = "0x1866F87D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x66F92E0", Offset = "0x66F86E0", VA = "0x1866F92E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly OAKPCAPFDMH NIJMCKGFMJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly BIOHOMJEIMK KKBFMEKNBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly HDDNBKOPHMD MONMKMPKKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, DLLDGBBDOIG> HECBKBLIEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	internal readonly Dictionary<LHHNGKFKNHJ, DLLDGBBDOIG> DMGCHADBJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal readonly Dictionary<LHHNGKFKNHJ, DLLDGBBDOIG> FEPFHIFAGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	internal readonly List<DLLDGBBDOIG> LOCFMDDPEDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool NPJKPPDMOCN;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly AOBBAGCAMNE[] EGJNPHGBLOF;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public AICJLJNELGK BHFLGLLGFJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<BMNDKIMONCI> GEGBEAFKGNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x66F5D10", Offset = "0x66F5110", VA = "0x1866F5D10", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event KOGALCOHGEG KLJKLBKPLDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x66F3790", Offset = "0x66F2B90", VA = "0x1866F3790", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x66F3D60", Offset = "0x66F3160", VA = "0x1866F3D60", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x66F60E0", Offset = "0x66F54E0", VA = "0x1866F60E0")]
	[HMKFFNEGBBO(PNDDNINAHEG.Room, FMOKCMPGPEB.None)]
	private static void OGNLIODLBPE(FJIKPBKCIMI ICOACGGPAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x66F71C0", Offset = "0x66F65C0", VA = "0x1866F71C0")]
	[UnityEngine.Scripting.Preserve]
	internal HFHODJIAMEF([POFPGPCOKGP(null)] OAKPCAPFDMH PMMPAFCGOJK, [POFPGPCOKGP(null)] BIOHOMJEIMK PACIFCEIBEH, [POFPGPCOKGP(null)] HDDNBKOPHMD MONMKMPKKPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x66F1C70", Offset = "0x66F1070", VA = "0x1866F1C70", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x66F3E10", Offset = "0x66F3210", VA = "0x1866F3E10")]
	private void KFKBGEFMGBB(IEnumerable<DLLDGBBDOIG> JJCLLLIONND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x66F1B00", Offset = "0x66F0F00", VA = "0x1866F1B00", Slot = "12")]
	public bool CJFGNGBOEGP(KFLCLHKINNK FKOLNPOECGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x66F3830", Offset = "0x66F2C30", VA = "0x1866F3830")]
	private void HKMMHJGFCHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x66F5D60", Offset = "0x66F5160", VA = "0x1866F5D60")]
	private void NDMJDKJAOAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x66F1EA0", Offset = "0x66F12A0", VA = "0x1866F1EA0", Slot = "10")]
	public IReadOnlyList<BMNDKIMONCI> FGBGCFLKKGJ(bool DLHPDAEGADP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x66F19F0", Offset = "0x66F0DF0", VA = "0x1866F19F0", Slot = "11")]
	public BMNDKIMONCI CCHDMKDDJOK(KFLCLHKINNK FKOLNPOECGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x66F3070", Offset = "0x66F2470", VA = "0x1866F3070")]
	private LHHNGKFKNHJ GLBILMGNLBO(KFLCLHKINNK FKOLNPOECGI)
	{
		return default(LHHNGKFKNHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x66F5F50", Offset = "0x66F5350", VA = "0x1866F5F50", Slot = "14")]
	public bool ODENCABLCMO(KFLCLHKINNK ACCNJPNEAEC, LHHNGKFKNHJ GIJIKLCBCNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x66F1BD0", Offset = "0x66F0FD0", VA = "0x1866F1BD0", Slot = "15")]
	public BMNDKIMONCI DJJDLHHBICC(LHHNGKFKNHJ GIJIKLCBCNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x66F48E0", Offset = "0x66F3CE0", VA = "0x1866F48E0")]
	private static bool LOGJNNEDACC(HJCGJNIGGCP MPECHCCNCJC, LHHNGKFKNHJ GIJIKLCBCNK, [Out] EICCCEGCBEC? BPGENCMBCED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x66F29B0", Offset = "0x66F1DB0", VA = "0x1866F29B0")]
	private static void GBNELGINPIN(HJCGJNIGGCP MPECHCCNCJC, Action<EICCCEGCBEC> HFJAMFBNDOC, LHHNGKFKNHJ APPMONNIDOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x66F2AA0", Offset = "0x66F1EA0", VA = "0x1866F2AA0")]
	private static void GBNELGINPIN(HJCGJNIGGCP MPECHCCNCJC, Action<EICCCEGCBEC> HFJAMFBNDOC, Predicate<LHHNGKFKNHJ> AMNOPBGPHLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x66F3840", Offset = "0x66F2C40", VA = "0x1866F3840")]
	private void HPJKEDINPGM(KFLCLHKINNK FKOLNPOECGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x66F1D80", Offset = "0x66F1180", VA = "0x1866F1D80", Slot = "4")]
	[AsyncStateMachine(typeof(NGFOMODDNFN))]
	public Task EHENBNFJOJM([CanBeNull] NLMALJAJAJA FOIDNCOOLGM, CancellationToken PPJMMMGPFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "5")]
	public void NLFBIILGPIA(NLMALJAJAJA FOIDNCOOLGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x66F2D30", Offset = "0x66F2130", VA = "0x1866F2D30")]
	private void GJBPBFFKLFN(HJCGJNIGGCP BCILPIICFJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x66F3490", Offset = "0x66F2890", VA = "0x1866F3490")]
	internal static string GPHPFPEHIGF(OAKPCAPFDMH NIJMCKGFMJC, NLMALJAJAJA FOIDNCOOLGM, IReadOnlyDictionary<LHHNGKFKNHJ, DLLDGBBDOIG> DMGCHADBJNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x66F4C10", Offset = "0x66F4010", VA = "0x1866F4C10")]
	private static void MAJKKMMOFBP(NLMALJAJAJA FOIDNCOOLGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x66F2660", Offset = "0x66F1A60", VA = "0x1866F2660")]
	private static void FLJOHDCFIMJ(HJCGJNIGGCP HJOBEGFJODE, IReadOnlyDictionary<LHHNGKFKNHJ, DLLDGBBDOIG> DMGCHADBJNG, StringBuilder MPEFIKHJKOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x66F6CD0", Offset = "0x66F60D0", VA = "0x1866F6CD0")]
	private static bool PNBMGDJMENP(string PDMNCAOIPBP, [Out] Guid OODEDHHAAOJ, [Out] LHHNGKFKNHJ GIJIKLCBCNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x66F1F20", Offset = "0x66F1320", VA = "0x1866F1F20")]
	private static void FHHDCCJHEOE(NLMALJAJAJA FOIDNCOOLGM, StringBuilder MPEFIKHJKOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2686F80", Offset = "0x2686380", VA = "0x182686F80", Slot = "16")]
	public bool KNCOJFCMGLM<T>(LHHNGKFKNHJ GIJIKLCBCNK, AOBBAGCAMNE FFOMMAAGHLD, bool JJKEMIFNKDM, T CMDECJALHDG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x66F6DE0", Offset = "0x66F61E0", VA = "0x1866F6DE0")]
	private void PNHLIDOLBJI(LHHNGKFKNHJ GIJIKLCBCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x66F4690", Offset = "0x66F3A90", VA = "0x1866F4690")]
	private bool KMHBPMPJNDF(KFLCLHKINNK FKOLNPOECGI, LHHNGKFKNHJ GIJIKLCBCNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x66F3140", Offset = "0x66F2540", VA = "0x1866F3140")]
	internal DLLDGBBDOIG GOKJIPDHLNN(KFLCLHKINNK FKOLNPOECGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x66F3E00", Offset = "0x66F3200", VA = "0x1866F3E00", Slot = "13")]
	public IReadOnlyList<BMNDKIMONCI> KADFDPCIEKL(KFLCLHKINNK FKOLNPOECGI, bool ODNKMLJNENO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x66F46B0", Offset = "0x66F3AB0", VA = "0x1866F46B0")]
	internal IReadOnlyList<DLLDGBBDOIG> LBKGGPJIDGF(KFLCLHKINNK FKOLNPOECGI, bool ODNKMLJNENO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x66F62A0", Offset = "0x66F56A0", VA = "0x1866F62A0")]
	private void PHJCICKEIBN(JLILPFNOBOJ DGDEGNKAIKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x66F5A20", Offset = "0x66F4E20", VA = "0x1866F5A20")]
	private static bool MBCOGEBPAFA(DLLDGBBDOIG DPPHLBMPKPG, IReadOnlyDictionary<LHHNGKFKNHJ, DLLDGBBDOIG> DMGCHADBJNG, [Out] IReadOnlyList<AOBBAGCAMNE> OHJOEMLINDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x66F38B0", Offset = "0x66F2CB0", VA = "0x1866F38B0")]
	[AsyncStateMachine(typeof(MBIIJLEHKOK))]
	private static Task IAOICIOCGEG(OAKPCAPFDMH NIJMCKGFMJC, NLMALJAJAJA FOIDNCOOLGM, IReadOnlyDictionary<LHHNGKFKNHJ, DLLDGBBDOIG> DMGCHADBJNG, HDDNBKOPHMD MONMKMPKKPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x66F6A30", Offset = "0x66F5E30", VA = "0x1866F6A30")]
	[CompilerGenerated]
	internal static void PKAKICMMDNN(Func<EICCCEGCBEC, MMCJGEGPHHF> IFDHKGCHMAG, ENNPBNEBEGA P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x66F39F0", Offset = "0x66F2DF0", VA = "0x1866F39F0")]
	[CompilerGenerated]
	internal static bool IKIJHMFGIHK(LHHNGKFKNHJ GIJIKLCBCNK, AOBBAGCAMNE FFOMMAAGHLD, [Out] GMFAJOEABMH NKPBKBDGBAI, LLGFDIGAEJL P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface NNINKKIEAMO
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MDLIOKICBDD(KFLCLHKINNK PGMGOAJIDHH, KFLCLHKINNK FOMCNMJDNIJ, IEnumerable<KFLCLHKINNK> NGKEGCGKJPA, [Out] AINOBBBAOPD GCFKCFKHEGE, [Out] MKMMNFPCEOO HADONJFKMKC);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string DJIDALJLMAA(MKMMNFPCEOO MGJBEJJKEPG);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum MKMMNFPCEOO : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	CantKickEventOrganizer,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Broadcaster,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	GameInProgress,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	OpponentGameInProgress
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class IFAHGDMLAGP : NNINKKIEAMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly NKKDGHCBJEJ DBOAHDNFNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly LGGAJCLLNDE GEJDHMEKLCC;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7A4380", Offset = "0x7A3780", VA = "0x1807A4380")]
	[RecRoom.NoEngine.Common.Preserve]
	public IFAHGDMLAGP([POFPGPCOKGP(null)] NKKDGHCBJEJ LDACAKJGHBE, [POFPGPCOKGP(null)] LGGAJCLLNDE MOCOLIKMANP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x66F7C20", Offset = "0x66F7020", VA = "0x1866F7C20")]
	private static MFMCMAPBJOO? CHDKHKGCMKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x66F8380", Offset = "0x66F7780", VA = "0x1866F8380", Slot = "4")]
	public bool MDLIOKICBDD(KFLCLHKINNK PGMGOAJIDHH, KFLCLHKINNK FOMCNMJDNIJ, IEnumerable<KFLCLHKINNK> NGKEGCGKJPA, [Out] AINOBBBAOPD GCFKCFKHEGE, [Out] MKMMNFPCEOO HADONJFKMKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x66F7C60", Offset = "0x66F7060", VA = "0x1866F7C60", Slot = "5")]
	public string DJIDALJLMAA(MKMMNFPCEOO MGJBEJJKEPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x66F7D60", Offset = "0x66F7160", VA = "0x1866F7D60")]
	internal bool KFKMBBEMDCJ(KFLCLHKINNK PGMGOAJIDHH, KFLCLHKINNK FOMCNMJDNIJ, IEnumerable<KFLCLHKINNK> NGKEGCGKJPA, HPNCJKDLPEK ACDIECKOFJI, MFMCMAPBJOO? HCJNKCMJDLE, [Out] AINOBBBAOPD GCFKCFKHEGE, [Out] MKMMNFPCEOO HADONJFKMKC)
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
