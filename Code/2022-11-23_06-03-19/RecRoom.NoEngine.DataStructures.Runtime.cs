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
		[Cpp2IlInjected.Address(RVA = "0x671070", Offset = "0x66FE70", VA = "0x180671070")]
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
		[Cpp2IlInjected.Address(RVA = "0x5EBFE30", Offset = "0x5EBEC30", VA = "0x185EBFE30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6994C0", Offset = "0x6982C0", VA = "0x1806994C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA48B60", Offset = "0xA47960", VA = "0x180A48B60")]
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
	[Cpp2IlInjected.Address(RVA = "0x6507B0", Offset = "0x64F5B0", VA = "0x1806507B0")]
	public ALEHBBLOIPN(params IDisposable[] DGIDNPNKHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x698430", Offset = "0x697230", VA = "0x180698430")]
	public static ALEHBBLOIPN KCNAIILPDFM(params IDisposable[] DGIDNPNKHPD)
	{
		return default(ALEHBBLOIPN);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5EBF4F0", Offset = "0x5EBE2F0", VA = "0x185EBF4F0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x30788A0", Offset = "0x30776A0", VA = "0x1830788A0")]
	public PFGGELCJAGF(IDisposable GHGAIHKFDCM, in T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2710C10", Offset = "0x270FA10", VA = "0x182710C10")]
	public static global::PFGGELCJAGF<U> LKIAEBBBKFB<U>(in global::PFGGELCJAGF<T> GHGAIHKFDCM, in U GKFICKKHACC)
	{
		return default(global::PFGGELCJAGF<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x30787C0", Offset = "0x30775C0", VA = "0x1830787C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class LDMOKJDKLCJ
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2DD3480", Offset = "0x2DD2280", VA = "0x182DD3480")]
	public static global::PFGGELCJAGF<T> KCNAIILPDFM<T>(IDisposable GHGAIHKFDCM, in T GKFICKKHACC)
	{
		return default(global::PFGGELCJAGF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x28F8120", Offset = "0x28F6F20", VA = "0x1828F8120")]
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
	[Cpp2IlInjected.Address(RVA = "0x6681B0", Offset = "0x666FB0", VA = "0x1806681B0")]
	public static DDJLGAJJOOM LEEEFIBDGIA(Type BIEGICDMJCM, [Optional] string DDPAFNLFEIL, [Optional] string LOBNOKNIJHE, bool FDHGMBIBPCK = false)
	{
		return default(DDJLGAJJOOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6681B0", Offset = "0x666FB0", VA = "0x1806681B0")]
	public static DDJLGAJJOOM LEEEFIBDGIA<T>([Optional] string DDPAFNLFEIL, [Optional] string LOBNOKNIJHE, bool FDHGMBIBPCK = false)
	{
		return default(DDJLGAJJOOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x6681A0", Offset = "0x666FA0", VA = "0x1806681A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5EBFCE0", Offset = "0x5EBEAE0", VA = "0x185EBFCE0")]
	protected BMIGOOHOEBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract string GFOMHDPEHDK();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5EBFBC0", Offset = "0x5EBE9C0", VA = "0x185EBFBC0", Slot = "6")]
	public virtual string ODKHJOONONN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5EBF680", Offset = "0x5EBE480", VA = "0x185EBF680")]
	public void DEOEOMAEBAC(StringBuilder HBILMDLCHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5EBF9F0", Offset = "0x5EBE7F0", VA = "0x185EBF9F0")]
	public void FCIGGAAGAON(StringBuilder HBILMDLCHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5EBFA50", Offset = "0x5EBE850", VA = "0x185EBFA50")]
	public void MFFHCPCILFI(StringBuilder HBILMDLCHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5EBF900", Offset = "0x5EBE700", VA = "0x185EBF900")]
	public void ENADBMHNFAP(StringBuilder HBILMDLCHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5EBFC40", Offset = "0x5EBEA40", VA = "0x185EBFC40")]
	public static void PHEKDGNBIGP(StringBuilder HBILMDLCHEA, string CGPGGBMCBBB, string FLODFJFKGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6F52F0", Offset = "0x6F40F0", VA = "0x1806F52F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class LBJIHINGAAE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5EBFD50", Offset = "0x5EBEB50", VA = "0x185EBFD50")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BBF1D0", Offset = "0x2BBDFD0", VA = "0x182BBF1D0")]
	private LIIDDKCCODJ(in TErr MNIAMKAIPKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2BBF100", Offset = "0x2BBDF00", VA = "0x182BBF100")]
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
	[Cpp2IlInjected.Address(RVA = "0x5EBFDC0", Offset = "0x5EBEBC0", VA = "0x185EBFDC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x37E4440", Offset = "0x37E3240", VA = "0x1837E4440")]
	private EBBHBAMHHOL(in TOk IALHOGACKCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x32FD150", Offset = "0x32FBF50", VA = "0x1832FD150")]
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
		[Cpp2IlInjected.Address(RVA = "0x49AA5E0", Offset = "0x49A93E0", VA = "0x1849AA5E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool NFNCPIFIBME
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x49ADCD0", Offset = "0x49ACAD0", VA = "0x1849ADCD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x49AF750", Offset = "0x49AE550", VA = "0x1849AF750")]
	internal EMFHPGMFAOO(in TErr MNIAMKAIPKL, in TOk IALHOGACKCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x49AD8E0", Offset = "0x49AC6E0", VA = "0x1849AD8E0")]
	public static global::EMFHPGMFAOO<TOk, TErr> ODEMKBFFICM(in TErr MNIAMKAIPKL)
	{
		return default(global::EMFHPGMFAOO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x49AE090", Offset = "0x49ACE90", VA = "0x1849AE090")]
	public static global::EMFHPGMFAOO<TOk, TErr> PDNLNFPPCPI(in TOk IALHOGACKCF)
	{
		return default(global::EMFHPGMFAOO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3A11350", Offset = "0x3A10150", VA = "0x183A11350")]
	public global::EMFHPGMFAOO<TOk, UErr> DNFGHBGKNBE<UErr>()
	{
		return default(global::EMFHPGMFAOO<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3A11900", Offset = "0x3A10700", VA = "0x183A11900")]
	public global::EMFHPGMFAOO<UOk, TErr> GMPLGJKCFOB<UOk>()
	{
		return default(global::EMFHPGMFAOO<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3A11E10", Offset = "0x3A10C10", VA = "0x183A11E10")]
	public global::EMFHPGMFAOO<UOk, TErr> LNNNFNPNLDA<UOk>()
	{
		return default(global::EMFHPGMFAOO<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3A119D0", Offset = "0x3A107D0", VA = "0x183A119D0")]
	public global::EMFHPGMFAOO<TOk, UErr> LBHJHFANEEO<UErr>()
	{
		return default(global::EMFHPGMFAOO<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x49ABD90", Offset = "0x49AAB90", VA = "0x1849ABD90")]
	public global::EMFHPGMFAOO<OIGDPEFJPLN, TErr> FEMPNONIBGI()
	{
		return default(global::EMFHPGMFAOO<OIGDPEFJPLN, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x49AD0D0", Offset = "0x49ABED0", VA = "0x1849AD0D0")]
	public static bool IKJLJMIELNH(in global::EMFHPGMFAOO<TOk, TErr> JDNBANCIMCP, in global::EMFHPGMFAOO<TOk, TErr> KMGMIHIGANB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x49AB160", Offset = "0x49A9F60", VA = "0x1849AB160", Slot = "4")]
	public bool Equals(global::EMFHPGMFAOO<TOk, TErr> MCLIMJFDMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x49AAD60", Offset = "0x49A9B60", VA = "0x1849AAD60", Slot = "0")]
	public override bool Equals(object MCLIMJFDMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x49AC730", Offset = "0x49AB530", VA = "0x1849AC730", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x49AECA0", Offset = "0x49ADAA0", VA = "0x1849AECA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class LHBLKCGEPBO
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2DD3800", Offset = "0x2DD2600", VA = "0x182DD3800")]
	public static global::EMFHPGMFAOO<TOk, TErr> CGGLOIGFJKJ<TOk, TErr>(this in global::EMFHPGMFAOO<TOk, TErr> DLIFLKHFBMM, in TOk IALHOGACKCF)
	{
		return default(global::EMFHPGMFAOO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2DD3870", Offset = "0x2DD2670", VA = "0x182DD3870")]
	public static global::EMFHPGMFAOO<OIGDPEFJPLN, TErr> CGGLOIGFJKJ<TErr>(this in global::EMFHPGMFAOO<OIGDPEFJPLN, TErr> DLIFLKHFBMM)
	{
		return default(global::EMFHPGMFAOO<OIGDPEFJPLN, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2DD3830", Offset = "0x2DD2630", VA = "0x182DD3830")]
	public static global::EMFHPGMFAOO<TOk, TErr> FHBEOJCDHDL<TOk, TErr>(this in global::EMFHPGMFAOO<TOk, TErr> DLIFLKHFBMM, in TErr MNIAMKAIPKL)
	{
		return default(global::EMFHPGMFAOO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2DD3790", Offset = "0x2DD2590", VA = "0x182DD3790")]
	public static TOk CEPCJEDAMOG<TOk, TErr>(this in global::EMFHPGMFAOO<TOk, TErr> DLIFLKHFBMM)
	{
		return (TOk)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2DD4C00", Offset = "0x2DD3A00", VA = "0x182DD4C00")]
	[AsyncStateMachine(typeof(IGKHHGPLKBA))]
	public static Task<TOk> OHPKFKFMOPI<TOk, TErr>(this Task<global::EMFHPGMFAOO<TOk, TErr>> DLIFLKHFBMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2DD3930", Offset = "0x2DD2730", VA = "0x182DD3930")]
	public static TErr EGDKHDIIPKJ<TErr, TOk>(this in global::EMFHPGMFAOO<TOk, TErr> DLIFLKHFBMM)
	{
		return (TErr)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2DD45D0", Offset = "0x2DD33D0", VA = "0x182DD45D0")]
	public static bool NPDCONKDHPD<TOk, TErr, UErr, UOk>(this in global::EMFHPGMFAOO<TOk, TErr> DLIFLKHFBMM, out global::EMFHPGMFAOO<UOk, UErr> OMGFGGAKDOI) where TErr : UErr
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2DD4350", Offset = "0x2DD3150", VA = "0x182DD4350")]
	public static bool LAFMCBNOKAC<TOk, TErr>(this in global::EMFHPGMFAOO<TOk, TErr> DLIFLKHFBMM, out TOk IALHOGACKCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2DD3B50", Offset = "0x2DD2950", VA = "0x182DD3B50")]
	public static bool ELKPLPPHBIF<TOk, TErr>(this in global::EMFHPGMFAOO<TOk, TErr> DLIFLKHFBMM, out TErr MNIAMKAIPKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2DD3F10", Offset = "0x2DD2D10", VA = "0x182DD3F10")]
	public static bool GHBJIBBBHIF<TOk, TErr>(this in global::EMFHPGMFAOO<TOk, TErr> DLIFLKHFBMM, out TOk IALHOGACKCF, out TErr MNIAMKAIPKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2DD3AF0", Offset = "0x2DD28F0", VA = "0x182DD3AF0")]
	public static bool EHGJGEHCPBH<TOk, TErr>(this in global::EMFHPGMFAOO<TOk, TErr> DLIFLKHFBMM, out TOk IALHOGACKCF, out global::EMFHPGMFAOO<TOk, TErr> OMGFGGAKDOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2DD4960", Offset = "0x2DD3760", VA = "0x182DD4960")]
	public static bool NPDCONKDHPD<TOk, TErr, UErr, UOk>(this in global::EMFHPGMFAOO<TOk, TErr> DLIFLKHFBMM, out TOk IALHOGACKCF, out global::EMFHPGMFAOO<UOk, UErr> OMGFGGAKDOI) where TErr : UErr
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2DD4050", Offset = "0x2DD2E50", VA = "0x182DD4050")]
	public static bool ILIPFEFKFDH<TOk, TErr>(this in global::EMFHPGMFAOO<TOk, TErr> DLIFLKHFBMM, out TOk IALHOGACKCF, out global::EMFHPGMFAOO<OIGDPEFJPLN, TErr> OMGFGGAKDOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2DD3BD0", Offset = "0x2DD29D0", VA = "0x182DD3BD0")]
	public static global::EMFHPGMFAOO<UOk, UErr> FNFHKPFBBEO<UOk, UErr, TOk, TErr>(this in global::EMFHPGMFAOO<TOk, TErr> DLIFLKHFBMM, in global::EMFHPGMFAOO<UOk, UErr> KBICBGPAOHG) where TOk : UOk where TErr : UErr
	{
		return default(global::EMFHPGMFAOO<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2DD4E60", Offset = "0x2DD3C60", VA = "0x182DD4E60")]
	public static global::EMFHPGMFAOO<TOk[], TErr> PFLFOAJJIPB<TOk, TErr>(this IEnumerable<global::EMFHPGMFAOO<TOk, TErr>> DLIFLKHFBMM)
	{
		return default(global::EMFHPGMFAOO<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1F90C70", Offset = "0x1F8FA70", VA = "0x181F90C70")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A687B0", Offset = "0x2A675B0", VA = "0x182A687B0")]
	public static global::EMFHPGMFAOO<TOk, T> CGGLOIGFJKJ<TOk>(in TOk IALHOGACKCF)
	{
		return default(global::EMFHPGMFAOO<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x31C11C0", Offset = "0x31BFFC0", VA = "0x1831C11C0")]
	public static global::EMFHPGMFAOO<OIGDPEFJPLN, T> CGGLOIGFJKJ()
	{
		return default(global::EMFHPGMFAOO<OIGDPEFJPLN, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2A68870", Offset = "0x2A67670", VA = "0x182A68870")]
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
		[Cpp2IlInjected.Address(RVA = "0xED4C20", Offset = "0xED3A20", VA = "0x180ED4C20")]
		public OCDIHPCCJAL(global::MEEMLMPGBMB<T> KAOHCMBJNEB, int FBIDPNBFBDL, bool IBFMBEMGJII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2F0C3E0", Offset = "0x2F0B1E0", VA = "0x182F0C3E0")]
		public global::MEEMLMPGBMB<T>.IKMHHCGAFFL EMHOENNLHOC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2F0C4D0", Offset = "0x2F0B2D0", VA = "0x182F0C4D0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2F0C4D0", Offset = "0x2F0B2D0", VA = "0x182F0C4D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2596300", Offset = "0x2595100", VA = "0x182596300")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x25963F0", Offset = "0x25951F0", VA = "0x1825963F0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2596530", Offset = "0x2595330", VA = "0x182596530", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2596AF0", Offset = "0x25958F0", VA = "0x182596AF0")]
		public IKMHHCGAFFL(global::MEEMLMPGBMB<T> KAOHCMBJNEB, int FBIDPNBFBDL, bool IBFMBEMGJII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2596350", Offset = "0x2595150", VA = "0x182596350", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x25963D0", Offset = "0x25951D0", VA = "0x1825963D0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "5")]
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
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x612690", Offset = "0x611A90")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1767C30", Offset = "0x1766A30", VA = "0x181767C30")]
		public LCCHKHMLOAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2F41AA0", Offset = "0x2F408A0", VA = "0x182F41AA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x28AB0E0", Offset = "0x28A9EE0", VA = "0x1828AB0E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public T FPPIFCEMCLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2872CA0", Offset = "0x2871AA0", VA = "0x182872CA0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T BIAGFGAGMMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x28AAE60", Offset = "0x28A9C60", VA = "0x1828AAE60")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public T OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x28AAF10", Offset = "0x28A9D10", VA = "0x1828AAF10")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int ONIEICNEHJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x805960", Offset = "0x804760", VA = "0x180805960")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x28AB0C0", Offset = "0x28A9EC0", VA = "0x1828AB0C0")]
	private static int KKJPAIFINAF(int BNNEENLPEFO, int PMIIGNOLFGJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x28AB3E0", Offset = "0x28AA1E0", VA = "0x1828AB3E0")]
	public MEEMLMPGBMB(int LBLAPKMJFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x28AB200", Offset = "0x28AA000", VA = "0x1828AB200")]
	public MEEMLMPGBMB(int LBLAPKMJFKP, Func<T> KLDABEOFKHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x28AB4F0", Offset = "0x28AA2F0", VA = "0x1828AB4F0")]
	public MEEMLMPGBMB(T[] DGIDNPNKHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x28AB090", Offset = "0x28A9E90", VA = "0x1828AB090")]
	public void HOABOONCALD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x28AB120", Offset = "0x28A9F20", VA = "0x1828AB120")]
	public IEnumerable<T> MBAPEMEHAFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x28AAE90", Offset = "0x28A9C90", VA = "0x1828AAE90")]
	public global::MEEMLMPGBMB<T>.IKMHHCGAFFL EMHOENNLHOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x28AB1D0", Offset = "0x28A9FD0", VA = "0x1828AB1D0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x28AB1D0", Offset = "0x28A9FD0", VA = "0x1828AB1D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class OHGPJFKANGM
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3252F70", Offset = "0x3251D70", VA = "0x183252F70")]
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
	[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "5")]
	public override string GFOMHDPEHDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3656D10", Offset = "0x3655B10", VA = "0x183656D10")]
	internal DLDGAPNLLJL(string HDKJDEIGPPL, in TData JLFCOOGLPMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class AMDIGIMALOF
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5EBF610", Offset = "0x5EBE410", VA = "0x185EBF610")]
	public static global::DLDGAPNLLJL<OIGDPEFJPLN> KCNAIILPDFM(string HDKJDEIGPPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x21CC540", Offset = "0x21CB340", VA = "0x1821CC540")]
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
