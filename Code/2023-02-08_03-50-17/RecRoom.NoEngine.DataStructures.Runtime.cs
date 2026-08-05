using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x21DFA30", Offset = "0x21DE830", VA = "0x1821DFA30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9F7FC0", Offset = "0x9F6DC0", VA = "0x1809F7FC0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x106BC90", Offset = "0x106AA90", VA = "0x18106BC90")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class GEBJEFEPEAJ
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface BNHHFFDGMEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string AALGNKHJHLE(string EMKINAHLLBJ);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void IEFBBADHFBO(string ENIJNHAJDKA);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void HIDCPPFEOHB(Exception IHBJIAPIGNJ);
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static BNHHFFDGMEB GEHLGJGIEOF;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct DBHHFPKFDPH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly IDisposable[] LKPLBMMIIHE;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x963B70", Offset = "0x962970", VA = "0x180963B70")]
	public DBHHFPKFDPH(params IDisposable[] JAODPABODGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x9F6F30", Offset = "0x9F5D30", VA = "0x1809F6F30")]
	public static DBHHFPKFDPH PKGIDMHJGMJ(params IDisposable[] JAODPABODGA)
	{
		return default(DBHHFPKFDPH);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x21DF0F0", Offset = "0x21DDEF0", VA = "0x1821DF0F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct GLHIEHLONGB<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly IDisposable NIPPOIEDBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public T MHMGLCIOEKC;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x38B1510", Offset = "0x38B0310", VA = "0x1838B1510")]
	public GLHIEHLONGB(IDisposable AFAIENJNNPO, in T DPJGMDFEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2F0BC70", Offset = "0x2F0AA70", VA = "0x182F0BC70")]
	public static global::GLHIEHLONGB<U> IMIMIDPCDJE<U>(in global::GLHIEHLONGB<T> AFAIENJNNPO, in U DPJGMDFEIDL)
	{
		return default(global::GLHIEHLONGB<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4221180", Offset = "0x421FF80", VA = "0x184221180", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class KACPKBFNKGL
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x322C960", Offset = "0x322B760", VA = "0x18322C960")]
	public static global::GLHIEHLONGB<T> PKGIDMHJGMJ<T>(IDisposable AFAIENJNNPO, in T DPJGMDFEIDL)
	{
		return default(global::GLHIEHLONGB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x322C900", Offset = "0x322B700", VA = "0x18322C900")]
	public static global::GLHIEHLONGB<U> IMIMIDPCDJE<U, T>(in global::GLHIEHLONGB<T> JECNOKLNINJ, in U DPJGMDFEIDL)
	{
		return default(global::GLHIEHLONGB<U>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct HMLMNDHMPLH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6E5BE0", Offset = "0x6E49E0", VA = "0x1806E5BE0")]
	public static HMLMNDHMPLH EEILILFBJJA(Type LAKBKKJKBPK, [Optional] string PMLJEONNDFH, [Optional] string MFCDCIHLAPP, bool MIIEJJIGMHB = false)
	{
		return default(HMLMNDHMPLH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6E5BE0", Offset = "0x6E49E0", VA = "0x1806E5BE0")]
	public static HMLMNDHMPLH EEILILFBJJA<T>([Optional] string PMLJEONNDFH, [Optional] string MFCDCIHLAPP, bool MIIEJJIGMHB = false)
	{
		return default(HMLMNDHMPLH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class GCOFNEOKNEG
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static bool HCDKKHJLJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly string EPKEKDBAMPO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public virtual GCOFNEOKNEG JGNIANKIGAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6CE7A0", Offset = "0x6CD5A0", VA = "0x1806CE7A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x21DF870", Offset = "0x21DE670", VA = "0x1821DF870")]
	protected GCOFNEOKNEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract string CFFNHDCOJGK();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x21DF790", Offset = "0x21DE590", VA = "0x1821DF790", Slot = "6")]
	public virtual string OEEDHIDBDNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x21DF510", Offset = "0x21DE310", VA = "0x1821DF510")]
	public void NKJOEAHLJOM(StringBuilder EDKGIOKKKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x21DF810", Offset = "0x21DE610", VA = "0x1821DF810")]
	public void OIGCILOOEJL(StringBuilder EDKGIOKKKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x21DF3A0", Offset = "0x21DE1A0", VA = "0x1821DF3A0")]
	public void JEAJJDOPNEN(StringBuilder EDKGIOKKKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x21DF2B0", Offset = "0x21DE0B0", VA = "0x1821DF2B0")]
	public void FHCBCDLOING(StringBuilder EDKGIOKKKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x21DF210", Offset = "0x21DE010", VA = "0x1821DF210")]
	public static void EOHNJAAEGFF(StringBuilder EDKGIOKKKAJ, string HNBNDOKAOAN, string DBIAGNIBILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x78C670", Offset = "0x78B470", VA = "0x18078C670", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class NFFALIOBDNJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x21DF950", Offset = "0x21DE750", VA = "0x1821DF950")]
	public NFFALIOBDNJ(string IACFBMPPCKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class GNELIEBKFLP<TErr> : NFFALIOBDNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly TErr NPOMHCJBJEO;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4222480", Offset = "0x4221280", VA = "0x184222480")]
	private GNELIEBKFLP(in TErr GMOGFBACGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x42223B0", Offset = "0x42211B0", VA = "0x1842223B0")]
	public static global::GNELIEBKFLP<TErr> PKGIDMHJGMJ(in TErr GMOGFBACGAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KEIJADMHEGN<out TOptions>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	TOptions MHMGLCIOEKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface DKOLIGBMLHP
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	string GJJJNLBGFCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class HCEICMKAJGP : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x21DF8E0", Offset = "0x21DE6E0", VA = "0x1821DF8E0")]
	public HCEICMKAJGP(string IACFBMPPCKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class ACDGLAJGJHF<TOk> : HCEICMKAJGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly TOk EBKKMGONKPJ;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x40AB7B0", Offset = "0x40AA5B0", VA = "0x1840AB7B0")]
	private ACDGLAJGJHF(in TOk IDCAJCGMCIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x39604A0", Offset = "0x395F2A0", VA = "0x1839604A0")]
	public static global::ACDGLAJGJHF<TOk> PKGIDMHJGMJ(in TOk IDCAJCGMCIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct NCCJCEGIOLD<TOk, TErr> : IEquatable<global::NCCJCEGIOLD<TOk, TErr>>
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly EqualityComparer<TErr> DLGLOGEFJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly TErr NPOMHCJBJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal readonly TOk EBKKMGONKPJ;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool IIFBMKFLDFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x51E2FF0", Offset = "0x51E1DF0", VA = "0x1851E2FF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool KFDFMEGBGDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x51E03A0", Offset = "0x51DF1A0", VA = "0x1851E03A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x51E56B0", Offset = "0x51E44B0", VA = "0x1851E56B0")]
	internal NCCJCEGIOLD(in TErr GMOGFBACGAD, in TOk IDCAJCGMCIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x51E4130", Offset = "0x51E2F30", VA = "0x1851E4130")]
	public static global::NCCJCEGIOLD<TOk, TErr> NAIIFFKNLDP(in TErr GMOGFBACGAD)
	{
		return default(global::NCCJCEGIOLD<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x51E3C90", Offset = "0x51E2A90", VA = "0x1851E3C90")]
	public static global::NCCJCEGIOLD<TOk, TErr> JGNDJKDAJMG(in TOk IDCAJCGMCIL)
	{
		return default(global::NCCJCEGIOLD<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4126450", Offset = "0x4125250", VA = "0x184126450")]
	public global::NCCJCEGIOLD<TOk, UErr> DNPDFGAJMID<UErr>()
	{
		return default(global::NCCJCEGIOLD<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4127130", Offset = "0x4125F30", VA = "0x184127130")]
	public global::NCCJCEGIOLD<UOk, TErr> MFKIIPDGNEJ<UOk>()
	{
		return default(global::NCCJCEGIOLD<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4126D70", Offset = "0x4125B70", VA = "0x184126D70")]
	public global::NCCJCEGIOLD<UOk, TErr> HBOJCOHHBEP<UOk>()
	{
		return default(global::NCCJCEGIOLD<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x41272D0", Offset = "0x41260D0", VA = "0x1841272D0")]
	public global::NCCJCEGIOLD<TOk, UErr> MKEGNAAPODC<UErr>()
	{
		return default(global::NCCJCEGIOLD<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x51E0620", Offset = "0x51DF420", VA = "0x1851E0620")]
	public global::NCCJCEGIOLD<PDIIEEBMKOH, TErr> DOJFBOHDOCB()
	{
		return default(global::NCCJCEGIOLD<PDIIEEBMKOH, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x51E0A60", Offset = "0x51DF860", VA = "0x1851E0A60")]
	public static bool EKDLGPJCFAN(in global::NCCJCEGIOLD<TOk, TErr> NIABGHNJMBG, in global::NCCJCEGIOLD<TOk, TErr> KMEJCCGACHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x51E18C0", Offset = "0x51E06C0", VA = "0x1851E18C0", Slot = "4")]
	public bool Equals(global::NCCJCEGIOLD<TOk, TErr> BNIMMCIKNIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x51E1C10", Offset = "0x51E0A10", VA = "0x1851E1C10", Slot = "0")]
	public override bool Equals(object BNIMMCIKNIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x51E2D00", Offset = "0x51E1B00", VA = "0x1851E2D00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x51E4AD0", Offset = "0x51E38D0", VA = "0x1851E4AD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class EDEBBAMFCPM
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3ACED50", Offset = "0x3ACDB50", VA = "0x183ACED50")]
	public static global::NCCJCEGIOLD<TOk, TErr> EBKKMGONKPJ<TOk, TErr>(this in global::NCCJCEGIOLD<TOk, TErr> BIKHFKCJEPO, in TOk IDCAJCGMCIL)
	{
		return default(global::NCCJCEGIOLD<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3ACEDC0", Offset = "0x3ACDBC0", VA = "0x183ACEDC0")]
	public static global::NCCJCEGIOLD<PDIIEEBMKOH, TErr> EBKKMGONKPJ<TErr>(this in global::NCCJCEGIOLD<PDIIEEBMKOH, TErr> BIKHFKCJEPO)
	{
		return default(global::NCCJCEGIOLD<PDIIEEBMKOH, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3ACED50", Offset = "0x3ACDB50", VA = "0x183ACED50")]
	public static global::NCCJCEGIOLD<TOk, TErr> NPOMHCJBJEO<TOk, TErr>(this in global::NCCJCEGIOLD<TOk, TErr> BIKHFKCJEPO, in TErr GMOGFBACGAD)
	{
		return default(global::NCCJCEGIOLD<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3ACF950", Offset = "0x3ACE750", VA = "0x183ACF950")]
	public static TOk HEFPKOOJEOD<TOk, TErr>(this in global::NCCJCEGIOLD<TOk, TErr> BIKHFKCJEPO)
	{
		return (TOk)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3ACF820", Offset = "0x3ACE620", VA = "0x183ACF820")]
	[AsyncStateMachine(typeof(FFOAJAHHICK))]
	public static Task<TOk> GMOHBBIOGFI<TOk, TErr>(this Task<global::NCCJCEGIOLD<TOk, TErr>> BIKHFKCJEPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3ACFB30", Offset = "0x3ACE930", VA = "0x183ACFB30")]
	public static TErr JFNKJBPKILK<TErr, TOk>(this in global::NCCJCEGIOLD<TOk, TErr> BIKHFKCJEPO)
	{
		return (TErr)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3ACF0C0", Offset = "0x3ACDEC0", VA = "0x183ACF0C0")]
	public static bool EPKCKPODACK<TOk, TErr, UErr, UOk>(this in global::NCCJCEGIOLD<TOk, TErr> BIKHFKCJEPO, out global::NCCJCEGIOLD<UOk, UErr> FDHECKBEBIG) where TErr : UErr
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3ACFD30", Offset = "0x3ACEB30", VA = "0x183ACFD30")]
	public static bool LBCDMGGEKIH<TOk, TErr>(this in global::NCCJCEGIOLD<TOk, TErr> BIKHFKCJEPO, out TOk IDCAJCGMCIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3ACFAB0", Offset = "0x3ACE8B0", VA = "0x183ACFAB0")]
	public static bool HPLACIJOAOH<TOk, TErr>(this in global::NCCJCEGIOLD<TOk, TErr> BIKHFKCJEPO, out TErr GMOGFBACGAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3AD00B0", Offset = "0x3ACEEB0", VA = "0x183AD00B0")]
	public static bool NMGBEBEBALJ<TOk, TErr>(this in global::NCCJCEGIOLD<TOk, TErr> BIKHFKCJEPO, out TOk IDCAJCGMCIL, out TErr GMOGFBACGAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3AD0110", Offset = "0x3ACEF10", VA = "0x183AD0110")]
	public static bool PMJAALLCIKM<TOk, TErr>(this in global::NCCJCEGIOLD<TOk, TErr> BIKHFKCJEPO, out TOk IDCAJCGMCIL, out global::NCCJCEGIOLD<TOk, TErr> FDHECKBEBIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3ACF450", Offset = "0x3ACE250", VA = "0x183ACF450")]
	public static bool EPKCKPODACK<TOk, TErr, UErr, UOk>(this in global::NCCJCEGIOLD<TOk, TErr> BIKHFKCJEPO, out TOk IDCAJCGMCIL, out global::NCCJCEGIOLD<UOk, UErr> FDHECKBEBIG) where TErr : UErr
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3ACE7E0", Offset = "0x3ACD5E0", VA = "0x183ACE7E0")]
	public static bool BDHLMIPBLHJ<TOk, TErr>(this in global::NCCJCEGIOLD<TOk, TErr> BIKHFKCJEPO, out TOk IDCAJCGMCIL, out global::NCCJCEGIOLD<PDIIEEBMKOH, TErr> FDHECKBEBIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3ACFD70", Offset = "0x3ACEB70", VA = "0x183ACFD70")]
	public static global::NCCJCEGIOLD<UOk, UErr> NIJKKIFCNMD<UOk, UErr, TOk, TErr>(this in global::NCCJCEGIOLD<TOk, TErr> BIKHFKCJEPO, in global::NCCJCEGIOLD<UOk, UErr> KNNMPBLOADI) where TOk : UOk where TErr : UErr
	{
		return default(global::NCCJCEGIOLD<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3ACEAA0", Offset = "0x3ACD8A0", VA = "0x183ACEAA0")]
	public static global::NCCJCEGIOLD<TOk[], TErr> DKHJLHBDILA<TOk, TErr>(this IEnumerable<global::NCCJCEGIOLD<TOk, TErr>> BIKHFKCJEPO)
	{
		return default(global::NCCJCEGIOLD<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x321D240", Offset = "0x321C040", VA = "0x18321D240")]
	[IteratorStateMachine(typeof(OAOFFDBMLGK))]
	public static IEnumerable<TOk> GEJPPCFEODO<TOk, TErr>(this IEnumerable<global::NCCJCEGIOLD<TOk, TErr>> BIKHFKCJEPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class EGIOEENCCLH<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2F06810", Offset = "0x2F05610", VA = "0x182F06810")]
	public static global::NCCJCEGIOLD<TOk, T> EBKKMGONKPJ<TOk>(in TOk IDCAJCGMCIL)
	{
		return default(global::NCCJCEGIOLD<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x36CDB40", Offset = "0x36CC940", VA = "0x1836CDB40")]
	public static global::NCCJCEGIOLD<PDIIEEBMKOH, T> EBKKMGONKPJ()
	{
		return default(global::NCCJCEGIOLD<PDIIEEBMKOH, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2F06750", Offset = "0x2F05550", VA = "0x182F06750")]
	public static global::NCCJCEGIOLD<T, TErr> NPOMHCJBJEO<TErr>(in TErr GMOGFBACGAD)
	{
		return default(global::NCCJCEGIOLD<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public sealed class JFEPJDFGOLK<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private readonly struct JPDNBBPICNJ : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly global::JFEPJDFGOLK<T> HCNHFDHIJLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly int EDLCFPPPBJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly bool PDFMDNCKONO;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8DFC20", Offset = "0x8DEA20", VA = "0x1808DFC20")]
		public JPDNBBPICNJ(global::JFEPJDFGOLK<T> NKKOFHPEFFF, int NMCHMHMJGLA, bool FINDKPFNHPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x37042C0", Offset = "0x37030C0", VA = "0x1837042C0")]
		public global::JFEPJDFGOLK<T>.PONDJAKBLLI LEIFMBFFFGJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x37043B0", Offset = "0x37031B0", VA = "0x1837043B0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x37043B0", Offset = "0x37031B0", VA = "0x1837043B0", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class PONDJAKBLLI : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly global::JFEPJDFGOLK<T> HCNHFDHIJLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly int MPNAIGDMKKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int NEJGJCJOAIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly bool PDFMDNCKONO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private bool IKNFMLFOBJC;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public T NFPBMNAHIKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x35BEDB0", Offset = "0x35BDBB0", VA = "0x1835BEDB0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x35BEEF0", Offset = "0x35BDCF0", VA = "0x1835BEEF0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x35BF000", Offset = "0x35BDE00", VA = "0x1835BF000", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x35BF400", Offset = "0x35BE200", VA = "0x1835BF400")]
		public PONDJAKBLLI(global::JFEPJDFGOLK<T> NKKOFHPEFFF, int NMCHMHMJGLA, bool FINDKPFNHPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x35BECE0", Offset = "0x35BDAE0", VA = "0x1835BECE0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x35BEEA0", Offset = "0x35BDCA0", VA = "0x1835BEEA0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class OBDEFPNMAIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x176EA0", Offset = "0x1762A0")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x22E6440", Offset = "0x22E5240", VA = "0x1822E6440")]
		public OBDEFPNMAIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x43E6380", Offset = "0x43E5180", VA = "0x1843E6380")]
		internal T <.ctor>b__0(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly T[] BAFKMBIBOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private int NEJGJCJOAIG;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int LIDFLIONIPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3AF96B0", Offset = "0x3AF84B0", VA = "0x183AF96B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public T NFPBMNAHIKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3AF97A0", Offset = "0x3AF85A0", VA = "0x183AF97A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T JPHCMBFHGGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3AF9770", Offset = "0x3AF8570", VA = "0x183AF9770")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public T BADELHLICNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3AF98F0", Offset = "0x3AF86F0", VA = "0x183AF98F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int PAFNFOIPEMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xBE5FA0", Offset = "0xBE4DA0", VA = "0x180BE5FA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3AF9690", Offset = "0x3AF8490", VA = "0x183AF9690")]
	private static int FIJJBGKILKJ(int DJIEOHJNDEK, int EOKNLPLGCDF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3AF9B30", Offset = "0x3AF8930", VA = "0x183AF9B30")]
	public JFEPJDFGOLK(int LCJMNMLOPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3AF9950", Offset = "0x3AF8750", VA = "0x183AF9950")]
	public JFEPJDFGOLK(int LCJMNMLOPCJ, Func<T> BGKDFMILCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3AF9AA0", Offset = "0x3AF88A0", VA = "0x183AF9AA0")]
	public JFEPJDFGOLK(T[] JAODPABODGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3AF9660", Offset = "0x3AF8460", VA = "0x183AF9660")]
	public void DGHMOBMCMIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3AF95B0", Offset = "0x3AF83B0", VA = "0x183AF95B0")]
	public IEnumerable<T> AMPLAAAPBEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3AF96F0", Offset = "0x3AF84F0", VA = "0x183AF96F0")]
	public global::JFEPJDFGOLK<T>.PONDJAKBLLI LEIFMBFFFGJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2F05900", Offset = "0x2F04700", VA = "0x182F05900", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2F05900", Offset = "0x2F04700", VA = "0x182F05900", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class CJAKDHNEHFG
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3338260", Offset = "0x3337060", VA = "0x183338260")]
	public static global::JFEPJDFGOLK<T> PKGIDMHJGMJ<T>(int LCJMNMLOPCJ, Func<T> BGKDFMILCOI) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class CIGLGCGLHCE<TData> : GCOFNEOKNEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly string MIMBNBKAENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly TData NABFHNKLBGG;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "5")]
	public override string CFFNHDCOJGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x38B2BB0", Offset = "0x38B19B0", VA = "0x1838B2BB0")]
	internal CIGLGCGLHCE(string IACFBMPPCKF, in TData CPLKBCGCHAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class NINCHCLBGOC
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x21DF9C0", Offset = "0x21DE7C0", VA = "0x1821DF9C0")]
	public static global::CIGLGCGLHCE<PDIIEEBMKOH> PKGIDMHJGMJ(string IACFBMPPCKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x321F850", Offset = "0x321E650", VA = "0x18321F850")]
	public static global::CIGLGCGLHCE<TData> PKGIDMHJGMJ<TData>(string IACFBMPPCKF, in TData CPLKBCGCHAN)
	{
		return null;
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
