using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB50", Offset = "0x7B9F50", VA = "0x1807BAB50")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1D23370", Offset = "0x1D22770", VA = "0x181D23370")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7BB450", Offset = "0x7BA850", VA = "0x1807BB450")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7BB490", Offset = "0x7BA890", VA = "0x1807BB490")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct JJANDFOKHPN<TMInput, TMOutput, TMNode> : IEnumerator<AFJMJHOPNGM<TMNode>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private ACOKFKBBMHL<TMInput, TMOutput, TMNode> EFOBKGEEFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NKJNCBGDLHF<TMInput, TMOutput, TMNode> KMKAGBOHEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private bool NAFIAEILECG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly AFJMJHOPNGM<TMNode> POOCHKNOAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3AD6300", Offset = "0x3AD5700", VA = "0x183AD6300", Slot = "4")]
		get
		{
			return default(AFJMJHOPNGM<TMNode>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3AD61A0", Offset = "0x3AD55A0", VA = "0x183AD61A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3AD6230", Offset = "0x3AD5630", VA = "0x183AD6230")]
	internal JJANDFOKHPN([In] ACOKFKBBMHL<TMInput, TMOutput, TMNode> AEINLOGAAEG, [In] NKJNCBGDLHF<TMInput, TMOutput, TMNode> LIILBFDPLAB, bool AHEPIOMHELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3AD6060", Offset = "0x3AD5460", VA = "0x183AD6060", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3AD6120", Offset = "0x3AD5520", VA = "0x183AD6120", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3AD5FE0", Offset = "0x3AD53E0", VA = "0x183AD5FE0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class CABMIGCDMAE
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2456260", Offset = "0x2455660", VA = "0x182456260")]
	public static JJANDFOKHPN<TMInput, TMOutput, TMNode> PIJMMFMEPKL<TMInput, TMOutput, TMNode>([In] KGFNDDMIFHP<TMInput, TMOutput, TMNode> LDLJDGHLOME, AFJMJHOPNGM<TMNode> CEPBGHOOFFL)
	{
		return default(JJANDFOKHPN<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct NKJNCBGDLHF<TMInput, TMOutput, TMNode> : IEnumerator<AFJMJHOPNGM<TMInput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private KGHHEJFCMNO<AFJMJHOPNGM<TMOutput>>.MDAMMMCGEAG IMDNIKIABHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private KGHHEJFCMNO<AFJMJHOPNGM<TMInput>>.MDAMMMCGEAG MKJDNAFNIBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly BCIKAHLLAKN<TMInput, TMOutput, TMNode> IEPPIODGMEC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public AFJMJHOPNGM<TMInput> POOCHKNOAMB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x37232E0", Offset = "0x37226E0", VA = "0x1837232E0", Slot = "4")]
		get
		{
			return default(AFJMJHOPNGM<TMInput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x37231B0", Offset = "0x37225B0", VA = "0x1837231B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3723260", Offset = "0x3722660", VA = "0x183723260")]
	internal NKJNCBGDLHF([In] KGHHEJFCMNO<AFJMJHOPNGM<TMOutput>>.MDAMMMCGEAG ECFPEFJCENH, [In] KGHHEJFCMNO<AFJMJHOPNGM<TMInput>>.MDAMMMCGEAG OEPMJCIGJFN, [In] BCIKAHLLAKN<TMInput, TMOutput, TMNode> OFHIKDPPEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3722FE0", Offset = "0x37223E0", VA = "0x183722FE0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3723140", Offset = "0x3722540", VA = "0x183723140", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3722F70", Offset = "0x3722370", VA = "0x183722F70", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class JEEMBNBDKJE
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2660D50", Offset = "0x2660150", VA = "0x182660D50")]
	public static NKJNCBGDLHF<TMInput, TMOutput, TMNode> PIJMMFMEPKL<TMInput, TMOutput, TMNode>([In] KGFNDDMIFHP<TMInput, TMOutput, TMNode> LDLJDGHLOME, AFJMJHOPNGM<TMNode> CEPBGHOOFFL)
	{
		return default(NKJNCBGDLHF<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct ACOKFKBBMHL<TMInput, TMOutput, TMNode> : IEnumerator<AFJMJHOPNGM<TMOutput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private KGHHEJFCMNO<AFJMJHOPNGM<TMInput>>.MDAMMMCGEAG HLKEPOHHJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private KGHHEJFCMNO<AFJMJHOPNGM<TMOutput>>.MDAMMMCGEAG CEGOJPAAGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly NNKCGKAJNCE<TMInput, TMOutput, TMNode> BAGJHNOMAON;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AFJMJHOPNGM<TMOutput> POOCHKNOAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x37232E0", Offset = "0x37226E0", VA = "0x1837232E0", Slot = "4")]
		get
		{
			return default(AFJMJHOPNGM<TMOutput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x37231B0", Offset = "0x37225B0", VA = "0x1837231B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3723260", Offset = "0x3722660", VA = "0x183723260")]
	internal ACOKFKBBMHL([In] KGHHEJFCMNO<AFJMJHOPNGM<TMInput>>.MDAMMMCGEAG NFODBPMCGAK, [In] KGHHEJFCMNO<AFJMJHOPNGM<TMOutput>>.MDAMMMCGEAG PFCLNKEIAPB, [In] NNKCGKAJNCE<TMInput, TMOutput, TMNode> KPAAJJLDABA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3722FE0", Offset = "0x37223E0", VA = "0x183722FE0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3723140", Offset = "0x3722540", VA = "0x183723140", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3722F70", Offset = "0x3722370", VA = "0x183722F70", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class IBKKIKKJFGI
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x263D9A0", Offset = "0x263CDA0", VA = "0x18263D9A0")]
	public static ACOKFKBBMHL<TMInput, TMOutput, TMNode> PIJMMFMEPKL<TMInput, TMOutput, TMNode>([In] KGFNDDMIFHP<TMInput, TMOutput, TMNode> LDLJDGHLOME, AFJMJHOPNGM<TMNode> CEPBGHOOFFL)
	{
		return default(ACOKFKBBMHL<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct KGFNDDMIFHP<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public NNKCGKAJNCE<TMInput, TMOutput, TMNode> EIKABNLHBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public BCIKAHLLAKN<TMInput, TMOutput, TMNode> EJOHEPOMKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public FKOPGKAIFJB<TMInput, TMOutput, TMNode> EHDJOMGGCHN;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3B37950", Offset = "0x3B36D50", VA = "0x183B37950")]
	internal KGFNDDMIFHP([In] NNKCGKAJNCE<TMInput, TMOutput, TMNode> KPAAJJLDABA, [In] BCIKAHLLAKN<TMInput, TMOutput, TMNode> OFHIKDPPEHH, [In] FKOPGKAIFJB<TMInput, TMOutput, TMNode> OIBLLINBCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3B376A0", Offset = "0x3B36AA0", VA = "0x183B376A0")]
	public static KGFNDDMIFHP<TMInput?, TMOutput?, TMNode?> PIJMMFMEPKL()
	{
		return default(KGFNDDMIFHP<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class LGGGAMCAOBF
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x26A7010", Offset = "0x26A6410", VA = "0x1826A7010")]
	public static BJGIBDCHPML? GOGJDIDOEDD<TMInput, TMOutput, TMNode>([In] this KGFNDDMIFHP<TMInput, TMOutput, TMNode> LHCHBOKBAPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x26A6670", Offset = "0x26A5A70", VA = "0x1826A6670")]
	public static KGFNDDMIFHP<TMInput?, TMOutput?, TMNode?> BOEOGBDBLGM<TMInput, TMOutput, TMNode>(this BJGIBDCHPML LHCHBOKBAPK)
	{
		return default(KGFNDDMIFHP<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x26A70F0", Offset = "0x26A64F0", VA = "0x1826A70F0")]
	public static void GOHOEIHDKHJ<TMInput, TMOutput, TMNode>(this KGFNDDMIFHP<TMInput, TMOutput, TMNode> LHCHBOKBAPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x26A71E0", Offset = "0x26A65E0", VA = "0x1826A71E0")]
	public static void JBDNEMJLMPC<TMInput, TMOutput, TMNode>(this KGFNDDMIFHP<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMOutput> JPMICPCCABD, AFJMJHOPNGM<TMInput> CJLJHBJLJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x26A6B70", Offset = "0x26A5F70", VA = "0x1826A6B70")]
	public static void CHMFHGJAFII<TMInput, TMOutput, TMNode>(this KGFNDDMIFHP<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMOutput> JPMICPCCABD, AFJMJHOPNGM<TMInput> CJLJHBJLJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x26A6F40", Offset = "0x26A6340", VA = "0x1826A6F40")]
	public static bool GOECEFPPIOM<TMInput, TMOutput, TMNode>([In] this KGFNDDMIFHP<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMOutput> JPMICPCCABD, AFJMJHOPNGM<TMInput> CJLJHBJLJBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x26A7150", Offset = "0x26A6550", VA = "0x1826A7150")]
	public static AFJMJHOPNGM<TMNode?> IEAKKCGEDAN<TMNode, TMInput, TMOutput>(this KGFNDDMIFHP<TMInput, TMOutput, TMNode> LHCHBOKBAPK)
	{
		return default(AFJMJHOPNGM<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x26A7350", Offset = "0x26A6750", VA = "0x1826A7350")]
	public static void PECAMGIAOBN<TMInput, TMOutput, TMNode>(this KGFNDDMIFHP<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMNode> CEPBGHOOFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x26A6600", Offset = "0x26A5A00", VA = "0x1826A6600")]
	public static AFJMJHOPNGM<TMInput?> BKPANMDIBKJ<TMInput, TMOutput, TMNode>(this KGFNDDMIFHP<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMNode> CEPBGHOOFFL)
	{
		return default(AFJMJHOPNGM<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x26A72E0", Offset = "0x26A66E0", VA = "0x1826A72E0")]
	public static AFJMJHOPNGM<TMOutput?> NNICKDEHBJL<TMOutput, TMInput, TMNode>(this KGFNDDMIFHP<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMNode> CEPBGHOOFFL)
	{
		return default(AFJMJHOPNGM<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x26A6570", Offset = "0x26A5970", VA = "0x1826A6570")]
	public static AFJMJHOPNGM<TMInput?> AKFKKKEHFAM<TMInput, TMOutput, TMNode>(this KGFNDDMIFHP<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMNode> CEPBGHOOFFL, int FGBBDGJMFEH)
	{
		return default(AFJMJHOPNGM<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x26A6CB0", Offset = "0x26A60B0", VA = "0x1826A6CB0")]
	public static AFJMJHOPNGM<TMOutput?> CNMBGAJAIAG<TMOutput, TMInput, TMNode>(this KGFNDDMIFHP<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMNode> CEPBGHOOFFL, int FGBBDGJMFEH)
	{
		return default(AFJMJHOPNGM<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x26A6EA0", Offset = "0x26A62A0", VA = "0x1826A6EA0")]
	public static void GLNBGKLDINO<TMInput, TMOutput, TMNode>(this KGFNDDMIFHP<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMNode> CEPBGHOOFFL, int EGIPMFJFBHM, int HMAMDOLIJLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x26A7240", Offset = "0x26A6640", VA = "0x1826A7240")]
	public static void MPAMFMOJINI<TMInput, TMOutput, TMNode>(this KGFNDDMIFHP<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMNode> CEPBGHOOFFL, int EGIPMFJFBHM, int HMAMDOLIJLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x26A6DA0", Offset = "0x26A61A0", VA = "0x1826A6DA0")]
	public static void DBPGPCOOHNG<TMInput, TMOutput, TMNode>(this KGFNDDMIFHP<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMInput> OFNFNBNPADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x26A6BD0", Offset = "0x26A5FD0", VA = "0x1826A6BD0")]
	public static void CIOEFAIDAOC<TMInput, TMOutput, TMNode>(this KGFNDDMIFHP<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMOutput> MMEEKIELCPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x872DE0", Offset = "0x8721E0", VA = "0x180872DE0")]
	public static HCIOPIJIMKJ<TMInput?> FCJGJKKCBHO<TMInput, TMOutput, TMNode>([In] this KGFNDDMIFHP<TMInput, TMOutput, TMNode> LHCHBOKBAPK)
	{
		return default(HCIOPIJIMKJ<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x26A6E90", Offset = "0x26A6290", VA = "0x1826A6E90")]
	public static HCIOPIJIMKJ<TMOutput?> EICHLKIBJLF<TMOutput, TMInput, TMNode>([In] this KGFNDDMIFHP<TMInput, TMOutput, TMNode> LHCHBOKBAPK)
	{
		return default(HCIOPIJIMKJ<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x26A65F0", Offset = "0x26A59F0", VA = "0x1826A65F0")]
	public static HCIOPIJIMKJ<TMNode?> BEDHJMFDKCD<TMNode, TMInput, TMOutput>([In] this KGFNDDMIFHP<TMInput, TMOutput, TMNode> LHCHBOKBAPK)
	{
		return default(HCIOPIJIMKJ<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x26A6D30", Offset = "0x26A6130", VA = "0x1826A6D30")]
	public static NKJNCBGDLHF<TMInput?, TMOutput?, TMNode?> FEAHFNHCLDO<TMInput, TMOutput, TMNode>([In] this KGFNDDMIFHP<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMNode> NONJEEALACK)
	{
		return default(NKJNCBGDLHF<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x26A6D30", Offset = "0x26A6130", VA = "0x1826A6D30")]
	public static ACOKFKBBMHL<TMInput?, TMOutput?, TMNode?> DACGDHFJDPB<TMInput, TMOutput, TMNode>([In] this KGFNDDMIFHP<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMNode> NONJEEALACK)
	{
		return default(ACOKFKBBMHL<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x26A64C0", Offset = "0x26A58C0", VA = "0x1826A64C0")]
	public static JJANDFOKHPN<TMInput?, TMOutput?, TMNode?> AIEBKLHHFBA<TMInput, TMOutput, TMNode>([In] this KGFNDDMIFHP<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMNode> NONJEEALACK)
	{
		return default(JJANDFOKHPN<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x26A7460", Offset = "0x26A6860", VA = "0x1826A7460")]
	public static KNEGGGJGGPF<AFJMJHOPNGM<TMInput?>, NKJNCBGDLHF<TMInput?, TMOutput?, TMNode?>> PFGBIGPFCPJ<TMInput, TMOutput, TMNode>([In] this KGFNDDMIFHP<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMNode> NONJEEALACK)
	{
		return default(KNEGGGJGGPF<AFJMJHOPNGM<TMInput>, NKJNCBGDLHF<TMInput, TMOutput, TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x26A69E0", Offset = "0x26A5DE0", VA = "0x1826A69E0")]
	public static KNEGGGJGGPF<AFJMJHOPNGM<TMNode?>, JJANDFOKHPN<TMInput?, TMOutput?, TMNode?>> CDAPMFEDMKA<TMNode, TMInput, TMOutput>([In] this KGFNDDMIFHP<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMNode> NONJEEALACK)
	{
		return default(KNEGGGJGGPF<AFJMJHOPNGM<TMNode>, JJANDFOKHPN<TMInput, TMOutput, TMNode>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct NNKCGKAJNCE<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal HCIOPIJIMKJ<TMInput> NHIBFPHDMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal JLHHOEKCNON<TMInput, AFJMJHOPNGM<TMNode>> LMMFIDBNIKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal JLHHOEKCNON<TMInput, KGHHEJFCMNO<AFJMJHOPNGM<TMOutput>>> IEPPIODGMEC;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x36B9A00", Offset = "0x36B8E00", VA = "0x1836B9A00")]
	internal NNKCGKAJNCE([In] HCIOPIJIMKJ<TMInput> MECCGMPHHOE, [In] JLHHOEKCNON<TMInput, AFJMJHOPNGM<TMNode>> OIBLLINBCCF, [In] JLHHOEKCNON<TMInput, KGHHEJFCMNO<AFJMJHOPNGM<TMOutput>>> OFHIKDPPEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x36B9840", Offset = "0x36B8C40", VA = "0x1836B9840")]
	internal static NNKCGKAJNCE<TMInput, TMOutput, TMNode> PIJMMFMEPKL()
	{
		return default(NNKCGKAJNCE<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class MLPGCAIDBHA
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x26F53D0", Offset = "0x26F47D0", VA = "0x1826F53D0")]
	internal static DLHHMGHJNLK GOGJDIDOEDD<TMInput, TMOutput, TMNode>([In] this NNKCGKAJNCE<TMInput, TMOutput, TMNode> LHCHBOKBAPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x26F4EC0", Offset = "0x26F42C0", VA = "0x1826F4EC0")]
	internal static NNKCGKAJNCE<TMInput, TMOutput, TMNode> BOEOGBDBLGM<TMInput, TMOutput, TMNode>(this DLHHMGHJNLK LHCHBOKBAPK)
	{
		return default(NNKCGKAJNCE<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x26F59E0", Offset = "0x26F4DE0", VA = "0x1826F59E0")]
	private static OLECDHHEOBL OPPBIOCLIEH<TMOutput>([In] this KGHHEJFCMNO<AFJMJHOPNGM<TMOutput>> LHCHBOKBAPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x26F5760", Offset = "0x26F4B60", VA = "0x1826F5760")]
	private static KGHHEJFCMNO<AFJMJHOPNGM<TMOutput>> LBBNJJCKIIG<TMOutput>(this OLECDHHEOBL LHCHBOKBAPK)
	{
		return default(KGHHEJFCMNO<AFJMJHOPNGM<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2643D30", Offset = "0x2643130", VA = "0x182643D30")]
	internal static void GOHOEIHDKHJ<TMInput, TMOutput, TMNode>(this NNKCGKAJNCE<TMInput, TMOutput, TMNode> LHCHBOKBAPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2643830", Offset = "0x2642C30", VA = "0x182643830")]
	internal static AFJMJHOPNGM<TMInput> DGKMCDNONJH<TMInput, TMOutput, TMNode>(this NNKCGKAJNCE<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMNode> LJOKPMONGEA)
	{
		return default(AFJMJHOPNGM<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x26438D0", Offset = "0x2642CD0", VA = "0x1826438D0")]
	internal static void FEPCPPOBHNL<TMInput, TMOutput, TMNode>(this NNKCGKAJNCE<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMInput> NONJEEALACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x24B3F00", Offset = "0x24B3300", VA = "0x1824B3F00")]
	public static bool ANCJEEDCBON<TMInput, TMOutput, TMNode>([In] this NNKCGKAJNCE<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMInput> NONJEEALACK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2643EC0", Offset = "0x26432C0", VA = "0x182643EC0")]
	public static AFJMJHOPNGM<TMNode> IEHGPDMHFIH<TMNode, TMInput, TMOutput>([In] this NNKCGKAJNCE<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMInput> NONJEEALACK)
	{
		return default(AFJMJHOPNGM<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2643960", Offset = "0x2642D60", VA = "0x182643960")]
	public static int KGHMFLKLNHC<TMInput, TMOutput, TMNode>([In] this NNKCGKAJNCE<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMInput> NONJEEALACK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x26437E0", Offset = "0x2642BE0", VA = "0x1826437E0")]
	public static AFJMJHOPNGM<TMOutput> CMPIABEHMDM<TMOutput, TMInput, TMNode>([In] this NNKCGKAJNCE<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMInput> NONJEEALACK, int FGBBDGJMFEH)
	{
		return default(AFJMJHOPNGM<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2643290", Offset = "0x2642690", VA = "0x182643290")]
	internal static void LGGHMLJEBFJ<TMInput, TMOutput, TMNode>(this NNKCGKAJNCE<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMInput> NONJEEALACK, AFJMJHOPNGM<TMOutput> MMEEKIELCPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2643290", Offset = "0x2642690", VA = "0x182643290")]
	internal static void HEAAFDHMIBK<TMInput, TMOutput, TMNode>(this NNKCGKAJNCE<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMInput> NONJEEALACK, AFJMJHOPNGM<TMOutput> MMEEKIELCPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2615AF0", Offset = "0x2614EF0", VA = "0x182615AF0")]
	public static KGHHEJFCMNO<AFJMJHOPNGM<TMOutput>>.MDAMMMCGEAG OGBDFFIBFMD<TMOutput, TMInput, TMNode>([In] this NNKCGKAJNCE<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMInput> NONJEEALACK)
	{
		return default(KGHHEJFCMNO<AFJMJHOPNGM<TMOutput>>.MDAMMMCGEAG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2615AF0", Offset = "0x2614EF0", VA = "0x182615AF0")]
	public static EKKLNDGDDHG<AFJMJHOPNGM<TMOutput>, KGHHEJFCMNO<AFJMJHOPNGM<TMOutput>>.MDAMMMCGEAG> OBNLLBOJDPI<TMOutput, TMInput, TMNode>([In] this NNKCGKAJNCE<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMInput> NONJEEALACK)
	{
		return default(EKKLNDGDDHG<AFJMJHOPNGM<TMOutput>, KGHHEJFCMNO<AFJMJHOPNGM<TMOutput>>.MDAMMMCGEAG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct FKOPGKAIFJB<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal HCIOPIJIMKJ<TMNode> NHIBFPHDMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal JLHHOEKCNON<TMNode, KGHHEJFCMNO<AFJMJHOPNGM<TMInput>>> BAGJHNOMAON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal JLHHOEKCNON<TMNode, KGHHEJFCMNO<AFJMJHOPNGM<TMOutput>>> IEPPIODGMEC;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x36B9A00", Offset = "0x36B8E00", VA = "0x1836B9A00")]
	internal FKOPGKAIFJB([In] HCIOPIJIMKJ<TMNode> MECCGMPHHOE, [In] JLHHOEKCNON<TMNode, KGHHEJFCMNO<AFJMJHOPNGM<TMInput>>> KPAAJJLDABA, [In] JLHHOEKCNON<TMNode, KGHHEJFCMNO<AFJMJHOPNGM<TMOutput>>> OFHIKDPPEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x36B9840", Offset = "0x36B8C40", VA = "0x1836B9840")]
	internal static FKOPGKAIFJB<TMInput, TMOutput, TMNode> PIJMMFMEPKL()
	{
		return default(FKOPGKAIFJB<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class NGPKEMPIOAG
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x274F2B0", Offset = "0x274E6B0", VA = "0x18274F2B0")]
	internal static JDKAKFFIDFN GOGJDIDOEDD<TMInput, TMOutput, TMNode>([In] this FKOPGKAIFJB<TMInput, TMOutput, TMNode> LHCHBOKBAPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x274E8F0", Offset = "0x274DCF0", VA = "0x18274E8F0")]
	internal static FKOPGKAIFJB<TMInput, TMOutput, TMNode> BOEOGBDBLGM<TMInput, TMOutput, TMNode>(this JDKAKFFIDFN LHCHBOKBAPK)
	{
		return default(FKOPGKAIFJB<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x274FBB0", Offset = "0x274EFB0", VA = "0x18274FBB0")]
	private static GFOEODEPOID ILFNGKMNEGE<TMInput>([In] this KGHHEJFCMNO<AFJMJHOPNGM<TMInput>> LHCHBOKBAPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x274E630", Offset = "0x274DA30", VA = "0x18274E630")]
	private static KGHHEJFCMNO<AFJMJHOPNGM<TMInput>> AEOJNDBNJGP<TMInput>(this GFOEODEPOID LHCHBOKBAPK)
	{
		return default(KGHHEJFCMNO<AFJMJHOPNGM<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x274F0E0", Offset = "0x274E4E0", VA = "0x18274F0E0")]
	private static LHKAHPGHFAB FOIIJILLEGJ<TMOutput>([In] this KGHHEJFCMNO<AFJMJHOPNGM<TMOutput>> LHCHBOKBAPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x274F930", Offset = "0x274ED30", VA = "0x18274F930")]
	private static KGHHEJFCMNO<AFJMJHOPNGM<TMOutput>> ICMOJJDCCAI<TMOutput>(this LHKAHPGHFAB LHCHBOKBAPK)
	{
		return default(KGHHEJFCMNO<AFJMJHOPNGM<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x274F670", Offset = "0x274EA70", VA = "0x18274F670")]
	internal static void GOHOEIHDKHJ<TMInput, TMOutput, TMNode>(this FKOPGKAIFJB<TMInput, TMOutput, TMNode> LHCHBOKBAPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x274EEA0", Offset = "0x274E2A0", VA = "0x18274EEA0")]
	internal static AFJMJHOPNGM<TMNode> DGKMCDNONJH<TMNode, TMInput, TMOutput>(this FKOPGKAIFJB<TMInput, TMOutput, TMNode> LHCHBOKBAPK, [In] KGHHEJFCMNO<AFJMJHOPNGM<TMInput>> KPAAJJLDABA, [In] KGHHEJFCMNO<AFJMJHOPNGM<TMOutput>> OFHIKDPPEHH)
	{
		return default(AFJMJHOPNGM<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x274EF90", Offset = "0x274E390", VA = "0x18274EF90")]
	internal static void FEPCPPOBHNL<TMInput, TMOutput, TMNode>(this FKOPGKAIFJB<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMNode> NONJEEALACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x24B3F00", Offset = "0x24B3300", VA = "0x1824B3F00")]
	public static bool ANCJEEDCBON<TMInput, TMOutput, TMNode>([In] this FKOPGKAIFJB<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMNode> NONJEEALACK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x24AFEC0", Offset = "0x24AF2C0", VA = "0x1824AFEC0")]
	public static int FIENPAGGFEK<TMInput, TMOutput, TMNode>([In] this FKOPGKAIFJB<TMInput, TMOutput, TMNode> LHCHBOKBAPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x274F050", Offset = "0x274E450", VA = "0x18274F050")]
	public static int FJLNOMFLNII<TMInput, TMOutput, TMNode>([In] this FKOPGKAIFJB<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMNode> NONJEEALACK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2643960", Offset = "0x2642D60", VA = "0x182643960")]
	public static int KGHMFLKLNHC<TMInput, TMOutput, TMNode>([In] this FKOPGKAIFJB<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMNode> NONJEEALACK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x274EE00", Offset = "0x274E200", VA = "0x18274EE00")]
	public static AFJMJHOPNGM<TMInput> CBLJFHHMOOC<TMInput, TMOutput, TMNode>([In] this FKOPGKAIFJB<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMNode> NONJEEALACK, int FGBBDGJMFEH)
	{
		return default(AFJMJHOPNGM<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x26437E0", Offset = "0x2642BE0", VA = "0x1826437E0")]
	public static AFJMJHOPNGM<TMOutput> CMPIABEHMDM<TMOutput, TMInput, TMNode>([In] this FKOPGKAIFJB<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMNode> NONJEEALACK, int FGBBDGJMFEH)
	{
		return default(AFJMJHOPNGM<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x274E8B0", Offset = "0x274DCB0", VA = "0x18274E8B0")]
	internal static void BFBEMIGFCPH<TMInput, TMOutput, TMNode>(this FKOPGKAIFJB<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMNode> NONJEEALACK, AFJMJHOPNGM<TMInput> OFNFNBNPADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2643290", Offset = "0x2642690", VA = "0x182643290")]
	internal static void LGGHMLJEBFJ<TMInput, TMOutput, TMNode>(this FKOPGKAIFJB<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMNode> NONJEEALACK, AFJMJHOPNGM<TMOutput> MMEEKIELCPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x274EE50", Offset = "0x274E250", VA = "0x18274EE50")]
	internal static void DDBLOKLCMFP<TMInput, TMOutput, TMNode>(this FKOPGKAIFJB<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMNode> NONJEEALACK, int FGBBDGJMFEH, AFJMJHOPNGM<TMInput> OFNFNBNPADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x274F090", Offset = "0x274E490", VA = "0x18274F090")]
	internal static void FNAKCCOPKEN<TMInput, TMOutput, TMNode>(this FKOPGKAIFJB<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMNode> NONJEEALACK, int FGBBDGJMFEH, AFJMJHOPNGM<TMOutput> MMEEKIELCPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x274E8B0", Offset = "0x274DCB0", VA = "0x18274E8B0")]
	internal static void GHACPDBHCDB<TMInput, TMOutput, TMNode>(this FKOPGKAIFJB<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMNode> NONJEEALACK, AFJMJHOPNGM<TMInput> OFNFNBNPADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2643290", Offset = "0x2642690", VA = "0x182643290")]
	internal static void HEAAFDHMIBK<TMInput, TMOutput, TMNode>(this FKOPGKAIFJB<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMNode> NONJEEALACK, AFJMJHOPNGM<TMOutput> MMEEKIELCPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x274EF30", Offset = "0x274E330", VA = "0x18274EF30")]
	public static KGHHEJFCMNO<AFJMJHOPNGM<TMInput>>.MDAMMMCGEAG HPNCCHNKAEL<TMInput, TMOutput, TMNode>([In] this FKOPGKAIFJB<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMNode> NONJEEALACK)
	{
		return default(KGHHEJFCMNO<AFJMJHOPNGM<TMInput>>.MDAMMMCGEAG);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2615AF0", Offset = "0x2614EF0", VA = "0x182615AF0")]
	public static KGHHEJFCMNO<AFJMJHOPNGM<TMOutput>>.MDAMMMCGEAG OGBDFFIBFMD<TMOutput, TMInput, TMNode>([In] this FKOPGKAIFJB<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMNode> NONJEEALACK)
	{
		return default(KGHHEJFCMNO<AFJMJHOPNGM<TMOutput>>.MDAMMMCGEAG);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x274EF30", Offset = "0x274E330", VA = "0x18274EF30")]
	public static EKKLNDGDDHG<AFJMJHOPNGM<TMInput>, KGHHEJFCMNO<AFJMJHOPNGM<TMInput>>.MDAMMMCGEAG> DLDNMMIBAEN<TMInput, TMOutput, TMNode>([In] this FKOPGKAIFJB<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMNode> NONJEEALACK)
	{
		return default(EKKLNDGDDHG<AFJMJHOPNGM<TMInput>, KGHHEJFCMNO<AFJMJHOPNGM<TMInput>>.MDAMMMCGEAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2615AF0", Offset = "0x2614EF0", VA = "0x182615AF0")]
	public static EKKLNDGDDHG<AFJMJHOPNGM<TMOutput>, KGHHEJFCMNO<AFJMJHOPNGM<TMOutput>>.MDAMMMCGEAG> OBNLLBOJDPI<TMOutput, TMInput, TMNode>([In] this FKOPGKAIFJB<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMNode> NONJEEALACK)
	{
		return default(EKKLNDGDDHG<AFJMJHOPNGM<TMOutput>, KGHHEJFCMNO<AFJMJHOPNGM<TMOutput>>.MDAMMMCGEAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x23FB180", Offset = "0x23FA580", VA = "0x1823FB180")]
	public static KNEGGGJGGPF<AFJMJHOPNGM<TMNode>, HCIOPIJIMKJ<TMNode>.FAFAKEIAMKO> GOBAECEAONG<TMNode, TMInput, TMOutput>([In] this FKOPGKAIFJB<TMInput, TMOutput, TMNode> LHCHBOKBAPK)
	{
		return default(KNEGGGJGGPF<AFJMJHOPNGM<TMNode>, HCIOPIJIMKJ<TMNode>.FAFAKEIAMKO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct BCIKAHLLAKN<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal HCIOPIJIMKJ<TMOutput> NHIBFPHDMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal JLHHOEKCNON<TMOutput, AFJMJHOPNGM<TMNode>> LMMFIDBNIKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal JLHHOEKCNON<TMOutput, KGHHEJFCMNO<AFJMJHOPNGM<TMInput>>> BAGJHNOMAON;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x36B9A00", Offset = "0x36B8E00", VA = "0x1836B9A00")]
	internal BCIKAHLLAKN([In] HCIOPIJIMKJ<TMOutput> MECCGMPHHOE, [In] JLHHOEKCNON<TMOutput, AFJMJHOPNGM<TMNode>> OIBLLINBCCF, [In] JLHHOEKCNON<TMOutput, KGHHEJFCMNO<AFJMJHOPNGM<TMInput>>> KPAAJJLDABA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x36B9840", Offset = "0x36B8C40", VA = "0x1836B9840")]
	internal static BCIKAHLLAKN<TMInput, TMOutput, TMNode> PIJMMFMEPKL()
	{
		return default(BCIKAHLLAKN<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class IINHKOJBFEG
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x26439A0", Offset = "0x2642DA0", VA = "0x1826439A0")]
	internal static OBOEPNDMFOC GOGJDIDOEDD<TMInput, TMOutput, TMNode>([In] this BCIKAHLLAKN<TMInput, TMOutput, TMNode> LHCHBOKBAPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x26432D0", Offset = "0x26426D0", VA = "0x1826432D0")]
	internal static BCIKAHLLAKN<TMInput, TMOutput, TMNode> BOEOGBDBLGM<TMInput, TMOutput, TMNode>(this OBOEPNDMFOC LHCHBOKBAPK)
	{
		return default(BCIKAHLLAKN<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2643EE0", Offset = "0x26432E0", VA = "0x182643EE0")]
	private static FMMGNKDKCMD KEOPKNLOABK<TMInput>([In] this KGHHEJFCMNO<AFJMJHOPNGM<TMInput>> LHCHBOKBAPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x26440B0", Offset = "0x26434B0", VA = "0x1826440B0")]
	private static KGHHEJFCMNO<AFJMJHOPNGM<TMInput>> KNDGOCCNEFD<TMInput>(this FMMGNKDKCMD LHCHBOKBAPK)
	{
		return default(KGHHEJFCMNO<AFJMJHOPNGM<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2643D30", Offset = "0x2643130", VA = "0x182643D30")]
	internal static void GOHOEIHDKHJ<TMInput, TMOutput, TMNode>(this BCIKAHLLAKN<TMInput, TMOutput, TMNode> LHCHBOKBAPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2643830", Offset = "0x2642C30", VA = "0x182643830")]
	internal static AFJMJHOPNGM<TMOutput> DGKMCDNONJH<TMOutput, TMInput, TMNode>(this BCIKAHLLAKN<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMNode> LJOKPMONGEA)
	{
		return default(AFJMJHOPNGM<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x26438D0", Offset = "0x2642CD0", VA = "0x1826438D0")]
	internal static void FEPCPPOBHNL<TMInput, TMOutput, TMNode>(this BCIKAHLLAKN<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMOutput> NONJEEALACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x24B3F00", Offset = "0x24B3300", VA = "0x1824B3F00")]
	public static bool ANCJEEDCBON<TMInput, TMOutput, TMNode>([In] this BCIKAHLLAKN<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMOutput> NONJEEALACK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2643EC0", Offset = "0x26432C0", VA = "0x182643EC0")]
	public static AFJMJHOPNGM<TMNode> IEHGPDMHFIH<TMNode, TMInput, TMOutput>([In] this BCIKAHLLAKN<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMOutput> NONJEEALACK)
	{
		return default(AFJMJHOPNGM<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2643960", Offset = "0x2642D60", VA = "0x182643960")]
	public static int FJLNOMFLNII<TMInput, TMOutput, TMNode>([In] this BCIKAHLLAKN<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMOutput> NONJEEALACK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x26437E0", Offset = "0x2642BE0", VA = "0x1826437E0")]
	public static AFJMJHOPNGM<TMInput> CBLJFHHMOOC<TMInput, TMOutput, TMNode>([In] this BCIKAHLLAKN<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMOutput> NONJEEALACK, int FGBBDGJMFEH)
	{
		return default(AFJMJHOPNGM<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2643290", Offset = "0x2642690", VA = "0x182643290")]
	internal static void BFBEMIGFCPH<TMInput, TMOutput, TMNode>(this BCIKAHLLAKN<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMOutput> NONJEEALACK, AFJMJHOPNGM<TMInput> OFNFNBNPADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2643290", Offset = "0x2642690", VA = "0x182643290")]
	internal static void GHACPDBHCDB<TMInput, TMOutput, TMNode>(this BCIKAHLLAKN<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMOutput> NONJEEALACK, AFJMJHOPNGM<TMInput> OFNFNBNPADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2615AF0", Offset = "0x2614EF0", VA = "0x182615AF0")]
	public static KGHHEJFCMNO<AFJMJHOPNGM<TMInput>>.MDAMMMCGEAG HPNCCHNKAEL<TMInput, TMOutput, TMNode>([In] this BCIKAHLLAKN<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMOutput> NONJEEALACK)
	{
		return default(KGHHEJFCMNO<AFJMJHOPNGM<TMInput>>.MDAMMMCGEAG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2615AF0", Offset = "0x2614EF0", VA = "0x182615AF0")]
	public static EKKLNDGDDHG<AFJMJHOPNGM<TMInput>, KGHHEJFCMNO<AFJMJHOPNGM<TMInput>>.MDAMMMCGEAG> DLDNMMIBAEN<TMInput, TMOutput, TMNode>([In] this BCIKAHLLAKN<TMInput, TMOutput, TMNode> LHCHBOKBAPK, AFJMJHOPNGM<TMOutput> NONJEEALACK)
	{
		return default(EKKLNDGDDHG<AFJMJHOPNGM<TMInput>, KGHHEJFCMNO<AFJMJHOPNGM<TMInput>>.MDAMMMCGEAG>);
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
