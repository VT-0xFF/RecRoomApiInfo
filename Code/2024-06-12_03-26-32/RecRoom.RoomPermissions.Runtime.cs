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
		[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FCEB00", Offset = "0x6FCD700", VA = "0x186FCEB00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x86E660", Offset = "0x86D260", VA = "0x18086E660")]
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
		[Cpp2IlInjected.Address(RVA = "0x86E6A0", Offset = "0x86D2A0", VA = "0x18086E6A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum HDOCFAGCEEE
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void MFJJMDAAJOJ<TPermission>(TPermission NCKCEHBIELD);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void MKHNFAAMKDP(OICKONADKGK KBMFHBINANN);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum FFCJGKPDCEK
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PFEODOHKGGF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NGFGKBKDEIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool HEJIJGHAJMF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool IGKMKNBNLFH
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool PACJEDJFGON
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool BOMKPJJFNAC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool PECILCNCNDO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class JFGGHMGLHIG
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	public enum KDGIIBMLPNJ
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
	public static readonly Guid HKHKEKEIEDJ;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid GNDHKHOJIPJ;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid DDNDMPMPEAE;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid KGIBNDNMLMM;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid DNJOLNAAOLG;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid OLELJCLKLCJ;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly MJFODILCEAC<JPGIKODLBNM, Guid> HLJBIKNJBHH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<JPGIKODLBNM> EFPDFEMOEOE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6FCD360", Offset = "0x6FCBF60", VA = "0x186FCD360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6FCD160", Offset = "0x6FCBD60", VA = "0x186FCD160")]
	public static JPGIKODLBNM AFLHGEEALKE(Guid CICFLOBNFHG)
	{
		return default(JPGIKODLBNM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6FCD420", Offset = "0x6FCC020", VA = "0x186FCD420")]
	public static Guid NMPFDFGFNMK(JPGIKODLBNM CDHIDDOPILM)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6FCD290", Offset = "0x6FCBE90", VA = "0x186FCD290")]
	public static bool DKLNFENHBJG(JPGIKODLBNM CDHIDDOPILM, [Out] Guid CICFLOBNFHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6FCD1F0", Offset = "0x6FCBDF0", VA = "0x186FCD1F0")]
	public static bool ALCHJHOFCFO(Guid CICFLOBNFHG, [Out] JPGIKODLBNM CDHIDDOPILM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6FCD320", Offset = "0x6FCBF20", VA = "0x186FCD320")]
	public static JPGIKODLBNM GGDHPODCIJH(JPGIKODLBNM CDHIDDOPILM)
	{
		return default(JPGIKODLBNM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6FCD4C0", Offset = "0x6FCC0C0", VA = "0x186FCD4C0")]
	public static KDGIIBMLPNJ PCFGCNKGPDF(JPGIKODLBNM FOOFJJLNDNN)
	{
		return default(KDGIIBMLPNJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6FCD3E0", Offset = "0x6FCBFE0", VA = "0x186FCD3E0")]
	internal static JPGIKODLBNM LKGMFJMGFKE(KDGIIBMLPNJ HIIBEFENGDJ)
	{
		return default(JPGIKODLBNM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface DJHIJMGEFNN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	IIDFMELMHHB CEOHNJKAENL
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<JNBFFILONMP> LNKIFNDEOIH
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event MKHNFAAMKDP KHGHHHGBEAI;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<JNBFFILONMP> GNMOOIGNPBD(bool ADAMOEIBOOJ = false);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JNBFFILONMP EAGILDPCHOG(OICKONADKGK KBMFHBINANN);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool KKEOFJGKPHM(OICKONADKGK KBMFHBINANN);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<JNBFFILONMP> BMAPEDOKOCP(OICKONADKGK KBMFHBINANN, bool NJLCNJOMCFJ = false);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HFFLALLCALH(OICKONADKGK NPIEAADIAIL, JPGIKODLBNM CDHIDDOPILM);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "9")]
	JNBFFILONMP JDEOOKLOMOO(JPGIKODLBNM CDHIDDOPILM);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool GMAFAKOBBHG<T>(JPGIKODLBNM CDHIDDOPILM, AIEMDAAAHKC NCKCEHBIELD, bool JPBCOKFJHDJ, T KDGMEPEFEJC, [Optional] Action CBEAICJBODE) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string DMOEGHOLNLD(AIEMDAAAHKC NCKCEHBIELD);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JJBIOAHDDGF
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task KEIMDLOBION(HLKJAJHEMPF AFAEGADIMPI, CancellationToken MPLCHGMFENA);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GPJLEKBOPLN(HLKJAJHEMPF AFAEGADIMPI);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface GJOHNENBFII
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	OICKONADKGK ALMALIAEOGA
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	NJAGFBDJADF CGJCNHFJBGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	FMLBFFJHFNC KNFJGCKIGCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<CPAILNCNBOI> IFJGNLAFLOE;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action PGPGOJHNIDJ;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JPGIKODLBNM JOJJFCNHJIN(OICKONADKGK KBMFHBINANN);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<CPAILNCNBOI> LLONALDJLOK(CancellationToken MPLCHGMFENA);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task JJPHABIBAMH(long NBIMAGPPMDN, IReadOnlyList<PMKDMMBNHLM> MGOLPLNADBG);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task DNHAEALNKJK(long NBIMAGPPMDN, long INCOHCKKKJD, IReadOnlyList<PMKDMMBNHLM> MGOLPLNADBG);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<OICKONADKGK> LMOHNBNKPKB();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class ECJENAKOGJC
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6FCC140", Offset = "0x6FCAD40", VA = "0x186FCC140")]
	public static JPGIKODLBNM GOEFEBFBKPA(this GJOHNENBFII DLEJFJKHKEK)
	{
		return default(JPGIKODLBNM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface GNOPPNFKGIE<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string MOMOCBFCJCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event MFJJMDAAJOJ<TPermission> HOBKOFNOOGI;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class LOPMFDBLDDJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? JLJBPGNOFCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8434A0", Offset = "0x8420A0", VA = "0x1808434A0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x852C90", Offset = "0x851890", VA = "0x180852C90")]
	protected LOPMFDBLDDJ(object? IMBNMLNLJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool MFIFNAPDHPO(object? GLMEMJNJKAN);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class BLIMBCOOHDB<T> : LOPMFDBLDDJ where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private T HGEDNEPFBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly IEqualityComparer<T> DPJNHLBPBGL;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T EPAONLOANJK
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x90BF40", Offset = "0x90AB40", VA = "0x18090BF40")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4E63690", Offset = "0x4E62290", VA = "0x184E63690", Slot = "4")]
	public override bool MFIFNAPDHPO(object? GLMEMJNJKAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4E630C0", Offset = "0x4E61CC0", VA = "0x184E630C0")]
	public bool EIMIFDDKDOF(T LHIKLIFIMMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4E63870", Offset = "0x4E62470", VA = "0x184E63870")]
	public BLIMBCOOHDB(T NJMAFDCOBGL, IEqualityComparer<T> DPJNHLBPBGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class PFLJFMELFID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<AIEMDAAAHKC, bool> PELOLHANOEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<AIEMDAAAHKC, LOPMFDBLDDJ> IJGPMNCPEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly CMLOEHKCNAC HGINJAMOLAP;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6FCFA40", Offset = "0x6FCE640", VA = "0x186FCFA40")]
	public PFLJFMELFID(CMLOEHKCNAC HGINJAMOLAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6FCF7E0", Offset = "0x6FCE3E0", VA = "0x186FCF7E0")]
	public bool IPNFAPFAMPF(AIEMDAAAHKC NCKCEHBIELD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2CE9550", Offset = "0x2CE8150", VA = "0x182CE9550")]
	public bool GAADAHPODGE<T>(AIEMDAAAHKC NCKCEHBIELD, bool JPBCOKFJHDJ, T GLMEMJNJKAN) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2CE90B0", Offset = "0x2CE7CB0", VA = "0x182CE90B0")]
	public (bool, T?) FGLHMPLLINL<T>(AIEMDAAAHKC NCKCEHBIELD) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6FCF700", Offset = "0x6FCE300", VA = "0x186FCF700")]
	public bool GAADAHPODGE(AIEMDAAAHKC NCKCEHBIELD, bool JPBCOKFJHDJ, object GLMEMJNJKAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6FCF630", Offset = "0x6FCE230", VA = "0x186FCF630")]
	public (bool, object) FGLHMPLLINL(AIEMDAAAHKC NCKCEHBIELD)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2CE9050", Offset = "0x2CE7C50", VA = "0x182CE9050")]
	private void FDPPPBLLNJE<T>(AIEMDAAAHKC NCKCEHBIELD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6FCF560", Offset = "0x6FCE160", VA = "0x186FCF560")]
	private LOPMFDBLDDJ AGOFDGJDOFC(AIEMDAAAHKC NCKCEHBIELD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6FCF850", Offset = "0x6FCE450", VA = "0x186FCF850")]
	public void LNOAPNBNJFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class ELDCCGKGHDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly string DKCABFIGINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly Type JDJABJNPHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly JAGNPAPHIIC MIDCBCHODEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly AIEMDAAAHKC HPCBJIOHOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public HNHCGLIKOBD IDJMJJKJHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public HKDKHEDDOBO KEIOAFPADOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public OIFHAKJPNON EEOCAEONPKO;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6FCC530", Offset = "0x6FCB130", VA = "0x186FCC530")]
	public ELDCCGKGHDA(Type ANICKBFNADK, string FCOBEKIDIGM, AIEMDAAAHKC NCKCEHBIELD, HNHCGLIKOBD ODHDPAHDDGF, HKDKHEDDOBO FNPHGHEJMHD, OIFHAKJPNON OIEMMBLJGJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6FCC4E0", Offset = "0x6FCB0E0", VA = "0x186FCC4E0")]
	public object PAJLHIMFKII(object? OCNJFCPHJLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x29784B0", Offset = "0x29770B0", VA = "0x1829784B0")]
	public void FDPPPBLLNJE<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6FCC430", Offset = "0x6FCB030", VA = "0x186FCC430")]
	public void FDPPPBLLNJE(Type LLPGKPECFME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class LAEEOPGECED<T> : ELDCCGKGHDA where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string CABGKPCBFBJ(T GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T PEPFFABOANP(string? CLMPLILMHPN, T NJMAFDCOBGL);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class PBOMCBCODAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public CABGKPCBFBJ serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public PEPFFABOANP parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public PBOMCBCODAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x46E8D80", Offset = "0x46E7980", VA = "0x1846E8D80")]
		internal string JLPMHPFODPE(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x46E8DC0", Offset = "0x46E79C0", VA = "0x1846E8DC0")]
		internal object OMAMGHHKGMM(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x41E75E0", Offset = "0x41E61E0", VA = "0x1841E75E0")]
	public LAEEOPGECED(AIEMDAAAHKC NCKCEHBIELD, string FCOBEKIDIGM, [Optional] CABGKPCBFBJ? ODHDPAHDDGF, [Optional] PEPFFABOANP? FNPHGHEJMHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x41E6770", Offset = "0x41E5370", VA = "0x1841E6770")]
	private static object? EGCBEAACMHC(PEPFFABOANP? FNPHGHEJMHD, string? CLMPLILMHPN, object? NJMAFDCOBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x41E7080", Offset = "0x41E5C80", VA = "0x1841E7080")]
	private static string PLFEAILJDFE(CABGKPCBFBJ? IFLPMNFIGEF, object? GLMEMJNJKAN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string HNHCGLIKOBD(object? GLMEMJNJKAN);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object HKDKHEDDOBO(string? CLMPLILMHPN, [Optional] object NJMAFDCOBGL);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate LOPMFDBLDDJ OIFHAKJPNON();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class CMLOEHKCNAC
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class IMAAIBCPNCN : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal static IMAAIBCPNCN GGKBGANLBLD;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6FCC5D0", Offset = "0x6FCB1D0", VA = "0x186FCC5D0", Slot = "4")]
		public bool Equals(List<string> KNFDPFPHEON, List<string> EFBKAEHLBOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6FCC720", Offset = "0x6FCB320", VA = "0x186FCC720", Slot = "5")]
		public int GetHashCode(List<string> HAHECKLGOJC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public IMAAIBCPNCN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class KOFCPCBNLPP : MMJDAIMIPGK<HDOCFAGCEEE>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6FCE9D0", Offset = "0x6FCD5D0", VA = "0x186FCE9D0", Slot = "9")]
		public override string PLFEAILJDFE(HDOCFAGCEEE HJNPKADFMMO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6FCE7F0", Offset = "0x6FCD3F0", VA = "0x186FCE7F0", Slot = "10")]
		protected override bool HFIMINAGKLG(string HJNPKADFMMO, [Out] HDOCFAGCEEE GLMEMJNJKAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6FCEAC0", Offset = "0x6FCD6C0", VA = "0x186FCEAC0")]
		public KOFCPCBNLPP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly IPDIGFBIADN IAIMECDDLJI;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly KOFCPCBNLPP JNHGPOBIMGP;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly List<ELDCCGKGHDA> DOFCEPAFOGD;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<AIEMDAAAHKC> EDGPJKBMJBC
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<AIEMDAAAHKC, ELDCCGKGHDA> IJBLKGEIMHB
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6FCBDC0", Offset = "0x6FCA9C0", VA = "0x186FCBDC0")]
	public CMLOEHKCNAC([Optional] IList<ELDCCGKGHDA>? OBDJOCKMJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6FCA8A0", Offset = "0x6FC94A0", VA = "0x186FCA8A0")]
	public ELDCCGKGHDA LGGCMMINKNA(AIEMDAAAHKC NCKCEHBIELD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface IIDFMELMHHB
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	JNBFFILONMP FOBJIEKHEPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class JHEDNNIHHEG : IIDFMELMHHB
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static JHEDNNIHHEG KDODEPPCFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly BOEKHNPGOOB JGBLPALKKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal readonly IReadOnlyList<BOEKHNPGOOB> AFAGFPPJLOP;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public JNBFFILONMP FOBJIEKHEPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6FCE6E0", Offset = "0x6FCD2E0", VA = "0x186FCE6E0")]
	public JHEDNNIHHEG(BOEKHNPGOOB JODGNBGNAKJ, IReadOnlyList<BOEKHNPGOOB> KKAJOFCGKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6FCD890", Offset = "0x6FCC490", VA = "0x186FCD890")]
	private static JHEDNNIHHEG GBJBPNLDLNG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class PBFAOHNBAMA
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<JPGIKODLBNM> JIFCIPHMJLO;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6FCF2D0", Offset = "0x6FCDED0", VA = "0x186FCF2D0")]
	public static bool LDNKFFCPFFH(this OICKONADKGK COEGBGMLNEL, JPGIKODLBNM CDHIDDOPILM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6FCF250", Offset = "0x6FCDE50", VA = "0x186FCF250")]
	public static bool HMGGHMKMALK(this OICKONADKGK COEGBGMLNEL, JPGIKODLBNM CDHIDDOPILM, FMLBFFJHFNC PINOGOEDJPH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface OJMABHEEGGL
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool AMCDOMFLAOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool LIPBJBOBINO
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool POCMALDICBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool GIJEHIFAPPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool HCLMJIHJHBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool FPCCGGKFHLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool NHLEPDEAAOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool LLKFNCLIPDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool LIEDMMMHMLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool BJHFOFKDONO
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool KNIEIFNNPMK
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool HLLNNLJOFPG
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> ALDLHDCHHHE
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	HDOCFAGCEEE OJANMHGOHAA
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface JNBFFILONMP : OJMABHEEGGL, PFEODOHKGGF, GNOPPNFKGIE<AIEMDAAAHKC>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string JCMNABEBBNO
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	JPGIKODLBNM GOEOCBKNEIB
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) PAKPCIGEGGI<T>(AIEMDAAAHKC NCKCEHBIELD) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum AIEMDAAAHKC
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
internal class BOEKHNPGOOB : JNBFFILONMP, OJMABHEEGGL, PFEODOHKGGF, GNOPPNFKGIE<AIEMDAAAHKC>
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	internal static readonly CMLOEHKCNAC KFFBKOBELMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	internal readonly PFLJFMELFID AOGNOGKGDBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private string? DKGEGEKACKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private string? NFENBKJABIH;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool BBBNIJDJEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6FC9630", Offset = "0x6FC8230", VA = "0x186FC9630", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool PLKLJLPFJFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6FC7FB0", Offset = "0x6FC6BB0", VA = "0x186FC7FB0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool CAKKNBOHOOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6FC8000", Offset = "0x6FC6C00", VA = "0x186FC8000", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool JPAFGPLJBJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6FC9160", Offset = "0x6FC7D60", VA = "0x186FC9160", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool ELFEOBBAECJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6FC86F0", Offset = "0x6FC72F0", VA = "0x186FC86F0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool BGKDPOOKBKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6FC8210", Offset = "0x6FC6E10", VA = "0x186FC8210", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public JPGIKODLBNM GOEOCBKNEIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x90BF40", Offset = "0x90AB40", VA = "0x18090BF40", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(JPGIKODLBNM);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x852F20", Offset = "0x851B20", VA = "0x180852F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string MOMOCBFCJCB
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6FC9720", Offset = "0x6FC8320", VA = "0x186FC9720", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6FC9110", Offset = "0x6FC7D10", VA = "0x186FC9110")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string JCMNABEBBNO
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6FC9720", Offset = "0x6FC8320", VA = "0x186FC9720", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool NBPKMCADGKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9D7F40", Offset = "0x9D6B40", VA = "0x1809D7F40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9D7440", Offset = "0x9D6040", VA = "0x1809D7440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool AMCDOMFLAOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6FC8650", Offset = "0x6FC7250", VA = "0x186FC8650", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public HDOCFAGCEEE OJANMHGOHAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6FC8600", Offset = "0x6FC7200", VA = "0x186FC8600", Slot = "20")]
		get
		{
			return default(HDOCFAGCEEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool LIPBJBOBINO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6FC8550", Offset = "0x6FC7150", VA = "0x186FC8550", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool POCMALDICBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6FC9910", Offset = "0x6FC8510", VA = "0x186FC9910", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool GIJEHIFAPPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6FC9680", Offset = "0x6FC8280", VA = "0x186FC9680", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool HCLMJIHJHBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6FC91B0", Offset = "0x6FC7DB0", VA = "0x186FC91B0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool FPCCGGKFHLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6FC84B0", Offset = "0x6FC70B0", VA = "0x186FC84B0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool NHLEPDEAAOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6FC8050", Offset = "0x6FC6C50", VA = "0x186FC8050", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool LLKFNCLIPDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6FC8500", Offset = "0x6FC7100", VA = "0x186FC8500", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool LIEDMMMHMLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6FC8740", Offset = "0x6FC7340", VA = "0x186FC8740", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> ALDLHDCHHHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6FC85A0", Offset = "0x6FC71A0", VA = "0x186FC85A0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool IMNNNOAFIJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6FC9630", Offset = "0x6FC8230", VA = "0x186FC9630", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool IIDPNGKKLLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6FC86F0", Offset = "0x6FC72F0", VA = "0x186FC86F0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool FAPAKMPJEPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6FC7FB0", Offset = "0x6FC6BB0", VA = "0x186FC7FB0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool BJHFOFKDONO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6FC8460", Offset = "0x6FC7060", VA = "0x186FC8460", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool KNIEIFNNPMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6FC86A0", Offset = "0x6FC72A0", VA = "0x186FC86A0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool HNFHIOPLHEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6FC8000", Offset = "0x6FC6C00", VA = "0x186FC8000", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool HLLNNLJOFPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6FC9A10", Offset = "0x6FC8610", VA = "0x186FC9A10", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool OBPJFCHGAHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6FC9160", Offset = "0x6FC7D60", VA = "0x186FC9160", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool OHAHPJINIMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6FC8210", Offset = "0x6FC6E10", VA = "0x186FC8210", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event MFJJMDAAJOJ<AIEMDAAAHKC> HOBKOFNOOGI
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6FC9960", Offset = "0x6FC8560", VA = "0x186FC9960", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6FC9200", Offset = "0x6FC7E00", VA = "0x186FC9200", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x288A940", Offset = "0x2889540", VA = "0x18288A940", Slot = "6")]
	public (bool, T?) PAKPCIGEGGI<T>(AIEMDAAAHKC NCKCEHBIELD) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x288A8E0", Offset = "0x28894E0", VA = "0x18288A8E0")]
	public BOEKHNPGOOB DAKGCLJMIIF<T>(AIEMDAAAHKC NCKCEHBIELD, bool JPBCOKFJHDJ, T GLMEMJNJKAN) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6FC9C70", Offset = "0x6FC8870", VA = "0x186FC9C70")]
	public BOEKHNPGOOB(JPGIKODLBNM CDHIDDOPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6FC9C50", Offset = "0x6FC8850", VA = "0x186FC9C50")]
	public BOEKHNPGOOB(JPGIKODLBNM CDHIDDOPILM, [Optional] string? DKGEGEKACKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6FC9C90", Offset = "0x6FC8890", VA = "0x186FC9C90")]
	public BOEKHNPGOOB(BOEKHNPGOOB MPIGPPLMFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6FC9AF0", Offset = "0x6FC86F0", VA = "0x186FC9AF0")]
	internal BOEKHNPGOOB(JPGIKODLBNM IICIEENFDLP, [Optional] string? DKGEGEKACKF, [Optional] BOEKHNPGOOB? MPIGPPLMFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6FC9770", Offset = "0x6FC8370", VA = "0x186FC9770")]
	public static JAGNPAPHIIC LFCMINJEFGL(AIEMDAAAHKC NCKCEHBIELD)
	{
		return default(JAGNPAPHIIC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6FC97F0", Offset = "0x6FC83F0", VA = "0x186FC97F0")]
	public void LNOAPNBNJFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6FC92B0", Offset = "0x6FC7EB0", VA = "0x186FC92B0")]
	internal BOEKHNPGOOB IABHGAFBONO(BOEKHNPGOOB BFJCMBNBFMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6FC7B40", Offset = "0x6FC6740", VA = "0x186FC7B40")]
	internal IReadOnlyCollection<AIEMDAAAHKC> AIIIFAEPLFO(BOEKHNPGOOB MPIGPPLMFCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6FC80A0", Offset = "0x6FC6CA0", VA = "0x186FC80A0")]
	public bool BHGCPGDNLPF(AIEMDAAAHKC NCKCEHBIELD, bool JPBCOKFJHDJ, string HDFJGPHLOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6FC9810", Offset = "0x6FC8410", VA = "0x186FC9810")]
	public (bool, string) MBOCLCKDGCN(AIEMDAAAHKC NCKCEHBIELD)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6FC96D0", Offset = "0x6FC82D0", VA = "0x186FC96D0")]
	internal void KDAMBGKJJNG(AIEMDAAAHKC NCKCEHBIELD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6FC8260", Offset = "0x6FC6E60", VA = "0x186FC8260")]
	public GCELFKFLGFL CGCDIGHHNNE(Func<JPGIKODLBNM, Guid> FHHGAHFMJKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6FC8790", Offset = "0x6FC7390", VA = "0x186FC8790")]
	public void GCLNIEGINEJ(GCELFKFLGFL OMEBHGGPBGH, Func<Guid, JPGIKODLBNM> JEKOEOGKDKK, [Optional] JPGIKODLBNM? MJJIEIPGEMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6FC8180", Offset = "0x6FC6D80", VA = "0x186FC8180")]
	[CompilerGenerated]
	private void BKHBKABAPJN(AIEMDAAAHKC IDILBIPPPAF, JNCHLGIGCFE IMFDHOKBOOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class PHNAEOAABPG : JJBIOAHDDGF, DJHIJMGEFNN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class CPECIBCGOHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public BOEKHNPGOOB newRole;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public CPECIBCGOHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6FCC110", Offset = "0x6FCAD10", VA = "0x186FCC110")]
		internal bool BPDFFOBLGOO(BOEKHNPGOOB rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class CABLKEPLJDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public JPGIKODLBNM roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public CABLKEPLJDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6FCA890", Offset = "0x6FC9490", VA = "0x186FCA890")]
		internal bool LEKJKCLBHOP(JPGIKODLBNM r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct OPMPHMMBFNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public PHNAEOAABPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public HLKJAJHEMPF roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<CPAILNCNBOI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6FCEB80", Offset = "0x6FCD780", VA = "0x186FCEB80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6FCF1F0", Offset = "0x6FCDDF0", VA = "0x186FCF1F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class EFKNAJAEFJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public EFKNAJAEFJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6FCC2C0", Offset = "0x6FCAEC0", VA = "0x186FCC2C0")]
		internal void MJMMICCGCFJ(GCELFKFLGFL r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6FCC1A0", Offset = "0x6FCADA0", VA = "0x186FCC1A0")]
		internal void DINIILKEFGJ(GCELFKFLGFL r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct FAKMGOPFALD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public HLKJAJHEMPF roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class EGMKHEIOILO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Func<GCELFKFLGFL, JNCHLGIGCFE> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public EGMKHEIOILO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6FCC3D0", Offset = "0x6FCAFD0", VA = "0x186FCC3D0")]
		internal void ELPDMNOGHNK(GCELFKFLGFL r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6FCC3A0", Offset = "0x6FCAFA0", VA = "0x186FCC3A0")]
		internal void BKIBLAMNHOO(GCELFKFLGFL r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6FCC400", Offset = "0x6FCB000", VA = "0x186FCC400")]
		internal void IBAIAMNLPKO(GCELFKFLGFL r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class ILNGIIFKMAI<T> where T : notnull
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
			public ILNGIIFKMAI<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private TaskAwaiter<CPAILNCNBOI> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x3539DC0", Offset = "0x35389C0", VA = "0x183539DC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x9DD860", Offset = "0x9DC460", VA = "0x1809DD860", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AIEMDAAAHKC rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public JPGIKODLBNM accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public JAGNPAPHIIC recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public PHNAEOAABPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public ILNGIIFKMAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x3E70A00", Offset = "0x3E6F600", VA = "0x183E70A00")]
		[AsyncStateMachine(typeof(ILNGIIFKMAI<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void IFCFIPMIKBF()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct LJOGLKCHAOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public IReadOnlyList<PMKDMMBNHLM> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct BPHIPGIIMFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public GJOHNENBFII rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public HLKJAJHEMPF roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public IReadOnlyDictionary<JPGIKODLBNM, BOEKHNPGOOB> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public PDINJOMHAFF debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6FC9D20", Offset = "0x6FC8920", VA = "0x186FC9D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6FCA830", Offset = "0x6FC9430", VA = "0x186FCA830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly GJOHNENBFII DLEJFJKHKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly JHEDNNIHHEG IKEJIHIMGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly PDINJOMHAFF GMJFPKILIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly Dictionary<int, BOEKHNPGOOB> DHFANEMKENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	internal readonly Dictionary<JPGIKODLBNM, BOEKHNPGOOB> MNPDLMABEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	internal readonly Dictionary<JPGIKODLBNM, BOEKHNPGOOB> DKKJKKGENCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	internal readonly List<BOEKHNPGOOB> HNGDLOFLECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private bool JJDAPCDAHGH;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly AIEMDAAAHKC[] PCLMLKKABNG;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public IIDFMELMHHB CEOHNJKAENL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<JNBFFILONMP> LNKIFNDEOIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6FD26B0", Offset = "0x6FD12B0", VA = "0x186FD26B0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event MKHNFAAMKDP KHGHHHGBEAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6FD4CE0", Offset = "0x6FD38E0", VA = "0x186FD4CE0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6FCFCF0", Offset = "0x6FCE8F0", VA = "0x186FCFCF0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2700", Offset = "0x6FD1300", VA = "0x186FD2700")]
	[FJJFAIMPJIC(AMDAGODFNAF.Room, JBEKPLNNIEC.None)]
	private static void GBNHEMCAJHC(LLIMAHMFNLB IADIMANELHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6FD5550", Offset = "0x6FD4150", VA = "0x186FD5550")]
	[UnityEngine.Scripting.Preserve]
	internal PHNAEOAABPG([GOICEJLKLIB(null)] GJOHNENBFII LKJHBPDCKON, [GOICEJLKLIB(null)] JHEDNNIHHEG ELPOKGAANNN, [GOICEJLKLIB(null)] PDINJOMHAFF GMJFPKILIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6FD0400", Offset = "0x6FCF000", VA = "0x186FD0400", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6FD1470", Offset = "0x6FD0070", VA = "0x186FD1470")]
	private void FCCHNMCEPKJ(IEnumerable<BOEKHNPGOOB> KJJFJGJKEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6FD4550", Offset = "0x6FD3150", VA = "0x186FD4550", Slot = "12")]
	public bool KKEOFJGKPHM(OICKONADKGK KBMFHBINANN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6FD50D0", Offset = "0x6FD3CD0", VA = "0x186FD50D0")]
	private void PGPGOJHNIDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6FD0190", Offset = "0x6FCED90", VA = "0x186FD0190")]
	private void DAGEJMKMMGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2AD0", Offset = "0x6FD16D0", VA = "0x186FD2AD0", Slot = "10")]
	public IReadOnlyList<JNBFFILONMP> GNMOOIGNPBD(bool ADAMOEIBOOJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6FD0510", Offset = "0x6FCF110", VA = "0x186FD0510", Slot = "11")]
	public JNBFFILONMP EAGILDPCHOG(OICKONADKGK KBMFHBINANN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2B50", Offset = "0x6FD1750", VA = "0x186FD2B50")]
	private JPGIKODLBNM HDMICDLGNGH(OICKONADKGK KBMFHBINANN)
	{
		return default(JPGIKODLBNM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2C20", Offset = "0x6FD1820", VA = "0x186FD2C20", Slot = "14")]
	public bool HFFLALLCALH(OICKONADKGK NPIEAADIAIL, JPGIKODLBNM CDHIDDOPILM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6FD4020", Offset = "0x6FD2C20", VA = "0x186FD4020", Slot = "15")]
	public JNBFFILONMP JDEOOKLOMOO(JPGIKODLBNM CDHIDDOPILM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6FD35B0", Offset = "0x6FD21B0", VA = "0x186FD35B0")]
	private static bool IBKEFPHGHKC(GBILDOACABH AFMFKBOCOOC, JPGIKODLBNM CDHIDDOPILM, [Out] GCELFKFLGFL? MKILBABMPAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6FD4620", Offset = "0x6FD3220", VA = "0x186FD4620")]
	private static void KNNJFKGJGKL(GBILDOACABH AFMFKBOCOOC, Action<GCELFKFLGFL> NCAPGKIHGFC, JPGIKODLBNM PEKNPAJHAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6FD4710", Offset = "0x6FD3310", VA = "0x186FD4710")]
	private static void KNNJFKGJGKL(GBILDOACABH AFMFKBOCOOC, Action<GCELFKFLGFL> NCAPGKIHGFC, Predicate<JPGIKODLBNM> FFGJOIFALIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3540", Offset = "0x6FD2140", VA = "0x186FD3540")]
	private void HOHGOPNCPEO(OICKONADKGK KBMFHBINANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6FD4200", Offset = "0x6FD2E00", VA = "0x186FD4200", Slot = "4")]
	[AsyncStateMachine(typeof(OPMPHMMBFNE))]
	public Task KEIMDLOBION([CanBeNull] HLKJAJHEMPF AFAEGADIMPI, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
	public void GPJLEKBOPLN(HLKJAJHEMPF AFAEGADIMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6FD49A0", Offset = "0x6FD35A0", VA = "0x186FD49A0")]
	private void MMBIJDMNHLA(GBILDOACABH MCIFLJOICJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6FD1CF0", Offset = "0x6FD08F0", VA = "0x186FD1CF0")]
	internal static string FELFFFIFPAC(GJOHNENBFII DLEJFJKHKEK, HLKJAJHEMPF AFAEGADIMPI, IReadOnlyDictionary<JPGIKODLBNM, BOEKHNPGOOB> MNPDLMABEEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6FD0620", Offset = "0x6FCF220", VA = "0x186FD0620")]
	private static void EIJFGNAEOGB(HLKJAJHEMPF AFAEGADIMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6FD4D80", Offset = "0x6FD3980", VA = "0x186FD4D80")]
	private static void PAHGNDAPIPL(GBILDOACABH OIHMPPMMPFA, IReadOnlyDictionary<JPGIKODLBNM, BOEKHNPGOOB> MNPDLMABEEP, StringBuilder OIFGEIPPDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6FCFDA0", Offset = "0x6FCE9A0", VA = "0x186FCFDA0")]
	private static bool CCIIGCPLODI(string OBIIPANFGOC, [Out] Guid CDFAMLKLILO, [Out] JPGIKODLBNM CDHIDDOPILM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6FD38E0", Offset = "0x6FD24E0", VA = "0x186FD38E0")]
	private static void IKBFNOFKJBH(HLKJAJHEMPF AFAEGADIMPI, StringBuilder OIFGEIPPDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2CEBEB0", Offset = "0x2CEAAB0", VA = "0x182CEBEB0", Slot = "16")]
	public bool GMAFAKOBBHG<T>(JPGIKODLBNM CDHIDDOPILM, AIEMDAAAHKC NCKCEHBIELD, bool JPBCOKFJHDJ, T KDGMEPEFEJC, [Optional] Action CBEAICJBODE) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6FD0380", Offset = "0x6FCEF80", VA = "0x186FD0380", Slot = "17")]
	public string DMOEGHOLNLD(AIEMDAAAHKC NCKCEHBIELD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6FD28C0", Offset = "0x6FD14C0", VA = "0x186FD28C0")]
	private void GNBDAONIOFG(JPGIKODLBNM CDHIDDOPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6FD1450", Offset = "0x6FD0050", VA = "0x186FD1450")]
	private bool EPFFLJCKLML(OICKONADKGK KBMFHBINANN, JPGIKODLBNM CDHIDDOPILM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2000", Offset = "0x6FD0C00", VA = "0x186FD2000")]
	internal BOEKHNPGOOB FJBKCKJNNEI(OICKONADKGK KBMFHBINANN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6FCFD90", Offset = "0x6FCE990", VA = "0x186FCFD90", Slot = "13")]
	public IReadOnlyList<JNBFFILONMP> BMAPEDOKOCP(OICKONADKGK KBMFHBINANN, bool NJLCNJOMCFJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6FD4320", Offset = "0x6FD2F20", VA = "0x186FD4320")]
	internal IReadOnlyList<BOEKHNPGOOB> KFFIGGCIGEA(OICKONADKGK KBMFHBINANN, bool NJLCNJOMCFJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2DB0", Offset = "0x6FD19B0", VA = "0x186FD2DB0")]
	private void HFLICHJONHE(CPAILNCNBOI NGDJJJGODBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6FCFEB0", Offset = "0x6FCEAB0", VA = "0x186FCFEB0")]
	private static bool CMADPLNFIKH(BOEKHNPGOOB GEFHPOIBDNE, IReadOnlyDictionary<JPGIKODLBNM, BOEKHNPGOOB> MNPDLMABEEP, [Out] IReadOnlyList<AIEMDAAAHKC> FMFMHFKDGHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6FD40C0", Offset = "0x6FD2CC0", VA = "0x186FD40C0")]
	[AsyncStateMachine(typeof(BPHIPGIIMFH))]
	private static Task KBEJPPAKJBL(GJOHNENBFII DLEJFJKHKEK, HLKJAJHEMPF AFAEGADIMPI, IReadOnlyDictionary<JPGIKODLBNM, BOEKHNPGOOB> MNPDLMABEEP, PDINJOMHAFF GMJFPKILIBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6FD50E0", Offset = "0x6FD3CE0", VA = "0x186FD50E0")]
	[CompilerGenerated]
	internal static void PPDGBIHMHPP(Func<GCELFKFLGFL, JNCHLGIGCFE> ICIACGOHLIB, FAKMGOPFALD P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2340", Offset = "0x6FD0F40", VA = "0x186FD2340")]
	[CompilerGenerated]
	internal static bool FLGJMPDPACI(JPGIKODLBNM CDHIDDOPILM, AIEMDAAAHKC NCKCEHBIELD, [Out] PMKDMMBNHLM JEOIAGABMNI, LJOGLKCHAOL P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface BFDPIAHJPJB
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ECCEFBNLBJP(OICKONADKGK FFLGECKDKEM, OICKONADKGK BIMKGOAGMCE, IEnumerable<OICKONADKGK> PLPCDJBGDKI, [Out] HDOCFAGCEEE COODLKGPDFO, [Out] JHFEOPPIPFO OLFJGFCFOAB);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string DMNJOAIDGJD(JHFEOPPIPFO NIEGGOCJJMP);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum JHFEOPPIPFO : byte
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
internal class IODLPPAFEIM : BFDPIAHJPJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly DJHIJMGEFNN JDIOGOFIBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly CDLMLENAPPK KOOLJFFOLNB;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x8503D0", Offset = "0x84EFD0", VA = "0x1808503D0")]
	[RecRoom.NoEngine.Common.Preserve]
	public IODLPPAFEIM([GOICEJLKLIB(null)] DJHIJMGEFNN JEHOOMHLGCK, [GOICEJLKLIB(null)] CDLMLENAPPK MIKPDGDCPPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6FCD120", Offset = "0x6FCBD20", VA = "0x186FCD120")]
	private static JIHOIIMOPPH? HMAPCDHJDHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6FCCA10", Offset = "0x6FCB610", VA = "0x186FCCA10", Slot = "4")]
	public bool ECCEFBNLBJP(OICKONADKGK FFLGECKDKEM, OICKONADKGK BIMKGOAGMCE, IEnumerable<OICKONADKGK> PLPCDJBGDKI, [Out] HDOCFAGCEEE COODLKGPDFO, [Out] JHFEOPPIPFO OLFJGFCFOAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6FCC910", Offset = "0x6FCB510", VA = "0x186FCC910", Slot = "5")]
	public string DMNJOAIDGJD(JHFEOPPIPFO NIEGGOCJJMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6FCCB10", Offset = "0x6FCB710", VA = "0x186FCCB10")]
	internal bool ELEFLJHEIFD(OICKONADKGK FFLGECKDKEM, OICKONADKGK BIMKGOAGMCE, IEnumerable<OICKONADKGK> PLPCDJBGDKI, FMLBFFJHFNC PINOGOEDJPH, JIHOIIMOPPH? LLLGDHDOFJD, [Out] HDOCFAGCEEE COODLKGPDFO, [Out] JHFEOPPIPFO OLFJGFCFOAB)
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
