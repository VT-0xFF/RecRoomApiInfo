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
		[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677740", VA = "0x180678B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x6097810", Offset = "0x6096410", VA = "0x186097810")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6926F0", Offset = "0x6912F0", VA = "0x1806926F0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x812880", Offset = "0x811480", VA = "0x180812880")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IOHBJKKOIDI
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface NDFANENPCFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string BHFHHJPNMOC(string LNICNJEJKPL);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MEEILHODDPH(string LGEKLMLBGCB);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void BCFLJABLEAC(Exception FFCMPANFFDB);
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static NDFANENPCFP EBMHMHOHCNI;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct ALEHBBLOIPN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly IDisposable[] LPEKLMAODNM;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x88CB80", Offset = "0x88B780", VA = "0x18088CB80")]
	public ALEHBBLOIPN(params IDisposable[] DGIDNPNKHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0xF05D10", Offset = "0xF04910", VA = "0x180F05D10")]
	public static ALEHBBLOIPN KCNAIILPDFM(params IDisposable[] DGIDNPNKHPD)
	{
		return default(ALEHBBLOIPN);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6096ED0", Offset = "0x6095AD0", VA = "0x186096ED0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct PFGGELCJAGF<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly IDisposable EGCAHIONBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public T AMPEKKPGHLN;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2B55750", Offset = "0x2B54350", VA = "0x182B55750")]
	public PFGGELCJAGF(IDisposable GHGAIHKFDCM, in T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x23B2560", Offset = "0x23B1160", VA = "0x1823B2560")]
	public static global::PFGGELCJAGF<U> LKIAEBBBKFB<U>(in global::PFGGELCJAGF<T> GHGAIHKFDCM, in U GKFICKKHACC)
	{
		return default(global::PFGGELCJAGF<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2B556B0", Offset = "0x2B542B0", VA = "0x182B556B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class LDMOKJDKLCJ
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3D14A70", Offset = "0x3D13670", VA = "0x183D14A70")]
	public static global::PFGGELCJAGF<T> KCNAIILPDFM<T>(IDisposable GHGAIHKFDCM, in T GKFICKKHACC)
	{
		return default(global::PFGGELCJAGF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x233CF70", Offset = "0x233BB70", VA = "0x18233CF70")]
	public static global::PFGGELCJAGF<U> LKIAEBBBKFB<U, T>(in global::PFGGELCJAGF<T> AFFFMHKGHKC, in U GKFICKKHACC)
	{
		return default(global::PFGGELCJAGF<U>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct DDJLGAJJOOM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x67AD00", Offset = "0x679900", VA = "0x18067AD00")]
	public static DDJLGAJJOOM LEEEFIBDGIA(Type BIEGICDMJCM, [Optional] string DDPAFNLFEIL, [Optional] string LOBNOKNIJHE, bool FDHGMBIBPCK = false)
	{
		return default(DDJLGAJJOOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x67AD00", Offset = "0x679900", VA = "0x18067AD00")]
	public static DDJLGAJJOOM LEEEFIBDGIA<T>([Optional] string DDPAFNLFEIL, [Optional] string LOBNOKNIJHE, bool FDHGMBIBPCK = false)
	{
		return default(DDJLGAJJOOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class BMIGOOHOEBL
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static bool JLEHLMJAMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly string JCEFENBEOLC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public virtual BMIGOOHOEBL PJMKMKCNDHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x67E170", Offset = "0x67CD70", VA = "0x18067E170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x60976C0", Offset = "0x60962C0", VA = "0x1860976C0")]
	protected BMIGOOHOEBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract string GFOMHDPEHDK();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x60975A0", Offset = "0x60961A0", VA = "0x1860975A0", Slot = "6")]
	public virtual string ODKHJOONONN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6097060", Offset = "0x6095C60", VA = "0x186097060")]
	public void DEOEOMAEBAC(StringBuilder HBILMDLCHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x60973D0", Offset = "0x6095FD0", VA = "0x1860973D0")]
	public void FCIGGAAGAON(StringBuilder HBILMDLCHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6097430", Offset = "0x6096030", VA = "0x186097430")]
	public void MFFHCPCILFI(StringBuilder HBILMDLCHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x60972E0", Offset = "0x6095EE0", VA = "0x1860972E0")]
	public void ENADBMHNFAP(StringBuilder HBILMDLCHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6097620", Offset = "0x6096220", VA = "0x186097620")]
	public static void PHEKDGNBIGP(StringBuilder HBILMDLCHEA, string CGPGGBMCBBB, string FLODFJFKGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x67E670", Offset = "0x67D270", VA = "0x18067E670", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class LBJIHINGAAE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6097730", Offset = "0x6096330", VA = "0x186097730")]
	public LBJIHINGAAE(string HDKJDEIGPPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class LIIDDKCCODJ<TErr> : LBJIHINGAAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly TErr FHBEOJCDHDL;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2501A50", Offset = "0x2500650", VA = "0x182501A50")]
	private LIIDDKCCODJ(in TErr MNIAMKAIPKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2501980", Offset = "0x2500580", VA = "0x182501980")]
	public static global::LIIDDKCCODJ<TErr> KCNAIILPDFM(in TErr MNIAMKAIPKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LNGIJBODKAL<out TOptions>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	TOptions AMPEKKPGHLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JHEEOEKFBPJ
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	string ONMFGLPAKOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class NBMLBBFBMMH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x60977A0", Offset = "0x60963A0", VA = "0x1860977A0")]
	public NBMLBBFBMMH(string HDKJDEIGPPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class EBBHBAMHHOL<TOk> : NBMLBBFBMMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly TOk CGGLOIGFJKJ;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2DDF700", Offset = "0x2DDE300", VA = "0x182DDF700")]
	private EBBHBAMHHOL(in TOk IALHOGACKCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2DDF5C0", Offset = "0x2DDE1C0", VA = "0x182DDF5C0")]
	public static global::EBBHBAMHHOL<TOk> KCNAIILPDFM(in TOk IALHOGACKCF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct EMFHPGMFAOO<TOk, TErr> : IEquatable<global::EMFHPGMFAOO<TOk, TErr>>
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly EqualityComparer<TErr> FJPFLACNHDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly TErr FHBEOJCDHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal readonly TOk CGGLOIGFJKJ;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool MEGKIFIHIKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x48E4BE0", Offset = "0x48E37E0", VA = "0x1848E4BE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool NFNCPIFIBME
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x48E82D0", Offset = "0x48E6ED0", VA = "0x1848E82D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x48E9D50", Offset = "0x48E8950", VA = "0x1848E9D50")]
	internal EMFHPGMFAOO(in TErr MNIAMKAIPKL, in TOk IALHOGACKCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x48E7EE0", Offset = "0x48E6AE0", VA = "0x1848E7EE0")]
	public static global::EMFHPGMFAOO<TOk, TErr> ODEMKBFFICM(in TErr MNIAMKAIPKL)
	{
		return default(global::EMFHPGMFAOO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x48E8690", Offset = "0x48E7290", VA = "0x1848E8690")]
	public static global::EMFHPGMFAOO<TOk, TErr> PDNLNFPPCPI(in TOk IALHOGACKCF)
	{
		return default(global::EMFHPGMFAOO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x37909F0", Offset = "0x378F5F0", VA = "0x1837909F0")]
	public global::EMFHPGMFAOO<TOk, UErr> DNFGHBGKNBE<UErr>()
	{
		return default(global::EMFHPGMFAOO<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3790FA0", Offset = "0x378FBA0", VA = "0x183790FA0")]
	public global::EMFHPGMFAOO<UOk, TErr> GMPLGJKCFOB<UOk>()
	{
		return default(global::EMFHPGMFAOO<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x37914B0", Offset = "0x37900B0", VA = "0x1837914B0")]
	public global::EMFHPGMFAOO<UOk, TErr> LNNNFNPNLDA<UOk>()
	{
		return default(global::EMFHPGMFAOO<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3791070", Offset = "0x378FC70", VA = "0x183791070")]
	public global::EMFHPGMFAOO<TOk, UErr> LBHJHFANEEO<UErr>()
	{
		return default(global::EMFHPGMFAOO<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x48E6390", Offset = "0x48E4F90", VA = "0x1848E6390")]
	public global::EMFHPGMFAOO<OIGDPEFJPLN, TErr> FEMPNONIBGI()
	{
		return default(global::EMFHPGMFAOO<OIGDPEFJPLN, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x48E76D0", Offset = "0x48E62D0", VA = "0x1848E76D0")]
	public static bool IKJLJMIELNH(in global::EMFHPGMFAOO<TOk, TErr> JDNBANCIMCP, in global::EMFHPGMFAOO<TOk, TErr> KMGMIHIGANB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x48E5760", Offset = "0x48E4360", VA = "0x1848E5760", Slot = "4")]
	public bool Equals(global::EMFHPGMFAOO<TOk, TErr> MCLIMJFDMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x48E5360", Offset = "0x48E3F60", VA = "0x1848E5360", Slot = "0")]
	public override bool Equals(object MCLIMJFDMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x48E6D30", Offset = "0x48E5930", VA = "0x1848E6D30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x48E92A0", Offset = "0x48E7EA0", VA = "0x1848E92A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class LHBLKCGEPBO
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3D14DF0", Offset = "0x3D139F0", VA = "0x183D14DF0")]
	public static global::EMFHPGMFAOO<TOk, TErr> CGGLOIGFJKJ<TOk, TErr>(this in global::EMFHPGMFAOO<TOk, TErr> DLIFLKHFBMM, in TOk IALHOGACKCF)
	{
		return default(global::EMFHPGMFAOO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3D14E60", Offset = "0x3D13A60", VA = "0x183D14E60")]
	public static global::EMFHPGMFAOO<OIGDPEFJPLN, TErr> CGGLOIGFJKJ<TErr>(this in global::EMFHPGMFAOO<OIGDPEFJPLN, TErr> DLIFLKHFBMM)
	{
		return default(global::EMFHPGMFAOO<OIGDPEFJPLN, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3D14E20", Offset = "0x3D13A20", VA = "0x183D14E20")]
	public static global::EMFHPGMFAOO<TOk, TErr> FHBEOJCDHDL<TOk, TErr>(this in global::EMFHPGMFAOO<TOk, TErr> DLIFLKHFBMM, in TErr MNIAMKAIPKL)
	{
		return default(global::EMFHPGMFAOO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3D14D80", Offset = "0x3D13980", VA = "0x183D14D80")]
	public static TOk CEPCJEDAMOG<TOk, TErr>(this in global::EMFHPGMFAOO<TOk, TErr> DLIFLKHFBMM)
	{
		return (TOk)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3D161F0", Offset = "0x3D14DF0", VA = "0x183D161F0")]
	[AsyncStateMachine(typeof(IGKHHGPLKBA))]
	public static Task<TOk> OHPKFKFMOPI<TOk, TErr>(this Task<global::EMFHPGMFAOO<TOk, TErr>> DLIFLKHFBMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3D14F20", Offset = "0x3D13B20", VA = "0x183D14F20")]
	public static TErr EGDKHDIIPKJ<TErr, TOk>(this in global::EMFHPGMFAOO<TOk, TErr> DLIFLKHFBMM)
	{
		return (TErr)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3D15BC0", Offset = "0x3D147C0", VA = "0x183D15BC0")]
	public static bool NPDCONKDHPD<TOk, TErr, UErr, UOk>(this in global::EMFHPGMFAOO<TOk, TErr> DLIFLKHFBMM, out global::EMFHPGMFAOO<UOk, UErr> OMGFGGAKDOI) where TErr : UErr
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3D15940", Offset = "0x3D14540", VA = "0x183D15940")]
	public static bool LAFMCBNOKAC<TOk, TErr>(this in global::EMFHPGMFAOO<TOk, TErr> DLIFLKHFBMM, out TOk IALHOGACKCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3D15140", Offset = "0x3D13D40", VA = "0x183D15140")]
	public static bool ELKPLPPHBIF<TOk, TErr>(this in global::EMFHPGMFAOO<TOk, TErr> DLIFLKHFBMM, out TErr MNIAMKAIPKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3D15500", Offset = "0x3D14100", VA = "0x183D15500")]
	public static bool GHBJIBBBHIF<TOk, TErr>(this in global::EMFHPGMFAOO<TOk, TErr> DLIFLKHFBMM, out TOk IALHOGACKCF, out TErr MNIAMKAIPKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3D150E0", Offset = "0x3D13CE0", VA = "0x183D150E0")]
	public static bool EHGJGEHCPBH<TOk, TErr>(this in global::EMFHPGMFAOO<TOk, TErr> DLIFLKHFBMM, out TOk IALHOGACKCF, out global::EMFHPGMFAOO<TOk, TErr> OMGFGGAKDOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3D15F50", Offset = "0x3D14B50", VA = "0x183D15F50")]
	public static bool NPDCONKDHPD<TOk, TErr, UErr, UOk>(this in global::EMFHPGMFAOO<TOk, TErr> DLIFLKHFBMM, out TOk IALHOGACKCF, out global::EMFHPGMFAOO<UOk, UErr> OMGFGGAKDOI) where TErr : UErr
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3D15640", Offset = "0x3D14240", VA = "0x183D15640")]
	public static bool ILIPFEFKFDH<TOk, TErr>(this in global::EMFHPGMFAOO<TOk, TErr> DLIFLKHFBMM, out TOk IALHOGACKCF, out global::EMFHPGMFAOO<OIGDPEFJPLN, TErr> OMGFGGAKDOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3D151C0", Offset = "0x3D13DC0", VA = "0x183D151C0")]
	public static global::EMFHPGMFAOO<UOk, UErr> FNFHKPFBBEO<UOk, UErr, TOk, TErr>(this in global::EMFHPGMFAOO<TOk, TErr> DLIFLKHFBMM, in global::EMFHPGMFAOO<UOk, UErr> KBICBGPAOHG) where TOk : UOk where TErr : UErr
	{
		return default(global::EMFHPGMFAOO<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3D16450", Offset = "0x3D15050", VA = "0x183D16450")]
	public static global::EMFHPGMFAOO<TOk[], TErr> PFLFOAJJIPB<TOk, TErr>(this IEnumerable<global::EMFHPGMFAOO<TOk, TErr>> DLIFLKHFBMM)
	{
		return default(global::EMFHPGMFAOO<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x22E8550", Offset = "0x22E7150", VA = "0x1822E8550")]
	[IteratorStateMachine(typeof(BCIIGGCDHCN))]
	public static IEnumerable<TOk> EBAAMCOPGNC<TOk, TErr>(this IEnumerable<global::EMFHPGMFAOO<TOk, TErr>> DLIFLKHFBMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class GJJPNCGBNMA<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x23F7F30", Offset = "0x23F6B30", VA = "0x1823F7F30")]
	public static global::EMFHPGMFAOO<TOk, T> CGGLOIGFJKJ<TOk>(in TOk IALHOGACKCF)
	{
		return default(global::EMFHPGMFAOO<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x339DA60", Offset = "0x339C660", VA = "0x18339DA60")]
	public static global::EMFHPGMFAOO<OIGDPEFJPLN, T> CGGLOIGFJKJ()
	{
		return default(global::EMFHPGMFAOO<OIGDPEFJPLN, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x23F7FF0", Offset = "0x23F6BF0", VA = "0x1823F7FF0")]
	public static global::EMFHPGMFAOO<T, TErr> FHBEOJCDHDL<TErr>(in TErr MNIAMKAIPKL)
	{
		return default(global::EMFHPGMFAOO<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public sealed class MEEMLMPGBMB<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private readonly struct OCDIHPCCJAL : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly global::MEEMLMPGBMB<T> MKJNKJIFGIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly int BIOMFGHAAIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly bool NHNLOMNBIEF;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x27E0B80", Offset = "0x27DF780", VA = "0x1827E0B80")]
		public OCDIHPCCJAL(global::MEEMLMPGBMB<T> KAOHCMBJNEB, int FBIDPNBFBDL, bool IBFMBEMGJII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x27E0A50", Offset = "0x27DF650", VA = "0x1827E0A50")]
		public global::MEEMLMPGBMB<T>.IKMHHCGAFFL EMHOENNLHOC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x27E0B40", Offset = "0x27DF740", VA = "0x1827E0B40", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x27E0B40", Offset = "0x27DF740", VA = "0x1827E0B40", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class IKMHHCGAFFL : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly global::MEEMLMPGBMB<T> MKJNKJIFGIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly int DIFAGPNGEPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int HGLGFCHGKNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly bool NHNLOMNBIEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private bool IEPNGKOAPOK;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public T FPPIFCEMCLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x1806CB0", Offset = "0x18058B0", VA = "0x181806CB0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x1806DA0", Offset = "0x18059A0", VA = "0x181806DA0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x1806EE0", Offset = "0x1805AE0", VA = "0x181806EE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x18074A0", Offset = "0x18060A0", VA = "0x1818074A0")]
		public IKMHHCGAFFL(global::MEEMLMPGBMB<T> KAOHCMBJNEB, int FBIDPNBFBDL, bool IBFMBEMGJII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1806D00", Offset = "0x1805900", VA = "0x181806D00", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1806D80", Offset = "0x1805980", VA = "0x181806D80", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class LCCHKHMLOAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x638F80", Offset = "0x638380")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1333410", Offset = "0x1332010", VA = "0x181333410")]
		public LCCHKHMLOAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2A3EAB0", Offset = "0x2A3D6B0", VA = "0x182A3EAB0")]
		internal T <.ctor>b__0(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly T[] KDOAIHCKEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private int HGLGFCHGKNM;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int AOLCBEFGBJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2FF4ED0", Offset = "0x2FF3AD0", VA = "0x182FF4ED0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public T FPPIFCEMCLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x227F270", Offset = "0x227DE70", VA = "0x18227F270")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T BIAGFGAGMMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2FF4C50", Offset = "0x2FF3850", VA = "0x182FF4C50")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public T OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2FF4D00", Offset = "0x2FF3900", VA = "0x182FF4D00")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int ONIEICNEHJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8DDBC0", Offset = "0x8DC7C0", VA = "0x1808DDBC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2FF4EB0", Offset = "0x2FF3AB0", VA = "0x182FF4EB0")]
	private static int KKJPAIFINAF(int BNNEENLPEFO, int PMIIGNOLFGJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2FF51A0", Offset = "0x2FF3DA0", VA = "0x182FF51A0")]
	public MEEMLMPGBMB(int LBLAPKMJFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2FF4FC0", Offset = "0x2FF3BC0", VA = "0x182FF4FC0")]
	public MEEMLMPGBMB(int LBLAPKMJFKP, Func<T> KLDABEOFKHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2FF52B0", Offset = "0x2FF3EB0", VA = "0x182FF52B0")]
	public MEEMLMPGBMB(T[] DGIDNPNKHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2FF4E80", Offset = "0x2FF3A80", VA = "0x182FF4E80")]
	public void HOABOONCALD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2FF4F10", Offset = "0x2FF3B10", VA = "0x182FF4F10")]
	public IEnumerable<T> MBAPEMEHAFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2FF4C80", Offset = "0x2FF3880", VA = "0x182FF4C80")]
	public global::MEEMLMPGBMB<T>.IKMHHCGAFFL EMHOENNLHOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2699890", Offset = "0x2698490", VA = "0x182699890", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2699890", Offset = "0x2698490", VA = "0x182699890", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class OHGPJFKANGM
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2B61E80", Offset = "0x2B60A80", VA = "0x182B61E80")]
	public static global::MEEMLMPGBMB<T> KCNAIILPDFM<T>(int LBLAPKMJFKP, Func<T> KLDABEOFKHB) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class DLDGAPNLLJL<TData> : BMIGOOHOEBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly string IDECJOBHDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly TData PEDANLNGBLI;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "5")]
	public override string GFOMHDPEHDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2F2F140", Offset = "0x2F2DD40", VA = "0x182F2F140")]
	internal DLDGAPNLLJL(string HDKJDEIGPPL, in TData JLFCOOGLPMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class AMDIGIMALOF
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6096FF0", Offset = "0x6095BF0", VA = "0x186096FF0")]
	public static global::DLDGAPNLLJL<OIGDPEFJPLN> KCNAIILPDFM(string HDKJDEIGPPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1A9ED70", Offset = "0x1A9D970", VA = "0x181A9ED70")]
	public static global::DLDGAPNLLJL<TData> KCNAIILPDFM<TData>(string HDKJDEIGPPL, in TData JLFCOOGLPMP)
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
