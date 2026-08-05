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
		[Cpp2IlInjected.Address(RVA = "0x7E3470", Offset = "0x7E2270", VA = "0x1807E3470")]
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
		[Cpp2IlInjected.Address(RVA = "0x1DBC8D0", Offset = "0x1DBB6D0", VA = "0x181DBC8D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E43F0", Offset = "0x7E31F0", VA = "0x1807E43F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E4430", Offset = "0x7E3230", VA = "0x1807E4430")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct KJABFMGFJHF<TMInput, TMOutput, TMNode> : IEnumerator<GPIFJNELMMP<TMNode>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private KDAKLLBFGLE<TMInput, TMOutput, TMNode> NJLLECBJNGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private DOIIOMAGOKC<TMInput, TMOutput, TMNode> LBMECCPHNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private bool LFMGHMLIFEI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly GPIFJNELMMP<TMNode> OGCIBGAMGCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3B21E40", Offset = "0x3B20C40", VA = "0x183B21E40", Slot = "4")]
		get
		{
			return default(GPIFJNELMMP<TMNode>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3B21CE0", Offset = "0x3B20AE0", VA = "0x183B21CE0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3B21D70", Offset = "0x3B20B70", VA = "0x183B21D70")]
	internal KJABFMGFJHF([In] KDAKLLBFGLE<TMInput, TMOutput, TMNode> KFJHOPFFOJC, [In] DOIIOMAGOKC<TMInput, TMOutput, TMNode> DOFGHOPKNAK, bool GLDLCCCBHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3B21BA0", Offset = "0x3B209A0", VA = "0x183B21BA0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3B21C60", Offset = "0x3B20A60", VA = "0x183B21C60", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3B21B20", Offset = "0x3B20920", VA = "0x183B21B20", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class NOLIHDHONDL
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x286D4F0", Offset = "0x286C2F0", VA = "0x18286D4F0")]
	public static KJABFMGFJHF<TMInput, TMOutput, TMNode> IKCDCJJCDKO<TMInput, TMOutput, TMNode>([In] ICNADNJACCH<TMInput, TMOutput, TMNode> FDIMDKLBOME, GPIFJNELMMP<TMNode> GOOFHOHFPNL)
	{
		return default(KJABFMGFJHF<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct DOIIOMAGOKC<TMInput, TMOutput, TMNode> : IEnumerator<GPIFJNELMMP<TMInput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private FFPIJGBCMLA<GPIFJNELMMP<TMOutput>>.FGKNNFKLCGN AMHNAHBEBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private FFPIJGBCMLA<GPIFJNELMMP<TMInput>>.FGKNNFKLCGN KNFBNKBJABE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly MHOPGFCLMEH<TMInput, TMOutput, TMNode> ILHIAECHKPM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public GPIFJNELMMP<TMInput> OGCIBGAMGCC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3B01D30", Offset = "0x3B00B30", VA = "0x183B01D30", Slot = "4")]
		get
		{
			return default(GPIFJNELMMP<TMInput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3B01C00", Offset = "0x3B00A00", VA = "0x183B01C00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3B01CB0", Offset = "0x3B00AB0", VA = "0x183B01CB0")]
	internal DOIIOMAGOKC([In] FFPIJGBCMLA<GPIFJNELMMP<TMOutput>>.FGKNNFKLCGN NCELHCDBNIA, [In] FFPIJGBCMLA<GPIFJNELMMP<TMInput>>.FGKNNFKLCGN AKBEKDJGGLD, [In] MHOPGFCLMEH<TMInput, TMOutput, TMNode> NHNIENDEIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3B01A30", Offset = "0x3B00830", VA = "0x183B01A30", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3B01B90", Offset = "0x3B00990", VA = "0x183B01B90", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3B019C0", Offset = "0x3B007C0", VA = "0x183B019C0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class CBPCMDKJAGP
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x258A190", Offset = "0x2588F90", VA = "0x18258A190")]
	public static DOIIOMAGOKC<TMInput, TMOutput, TMNode> IKCDCJJCDKO<TMInput, TMOutput, TMNode>([In] ICNADNJACCH<TMInput, TMOutput, TMNode> FDIMDKLBOME, GPIFJNELMMP<TMNode> GOOFHOHFPNL)
	{
		return default(DOIIOMAGOKC<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct KDAKLLBFGLE<TMInput, TMOutput, TMNode> : IEnumerator<GPIFJNELMMP<TMOutput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private FFPIJGBCMLA<GPIFJNELMMP<TMInput>>.FGKNNFKLCGN DHMFDBMIINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private FFPIJGBCMLA<GPIFJNELMMP<TMOutput>>.FGKNNFKLCGN DKHGMDOJNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly GBPGFJHMMGN<TMInput, TMOutput, TMNode> IBMOMLAKNFE;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public GPIFJNELMMP<TMOutput> OGCIBGAMGCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3B01D30", Offset = "0x3B00B30", VA = "0x183B01D30", Slot = "4")]
		get
		{
			return default(GPIFJNELMMP<TMOutput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3B01C00", Offset = "0x3B00A00", VA = "0x183B01C00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3B01CB0", Offset = "0x3B00AB0", VA = "0x183B01CB0")]
	internal KDAKLLBFGLE([In] FFPIJGBCMLA<GPIFJNELMMP<TMInput>>.FGKNNFKLCGN ADLGHFEGBAO, [In] FFPIJGBCMLA<GPIFJNELMMP<TMOutput>>.FGKNNFKLCGN JKGHPFGKMCB, [In] GBPGFJHMMGN<TMInput, TMOutput, TMNode> IKIGCPEBFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3B01A30", Offset = "0x3B00830", VA = "0x183B01A30", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3B01B90", Offset = "0x3B00990", VA = "0x183B01B90", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3B019C0", Offset = "0x3B007C0", VA = "0x183B019C0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class AMCOENLEEDL
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2D0A020", Offset = "0x2D08E20", VA = "0x182D0A020")]
	public static KDAKLLBFGLE<TMInput, TMOutput, TMNode> IKCDCJJCDKO<TMInput, TMOutput, TMNode>([In] ICNADNJACCH<TMInput, TMOutput, TMNode> FDIMDKLBOME, GPIFJNELMMP<TMNode> GOOFHOHFPNL)
	{
		return default(KDAKLLBFGLE<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct ICNADNJACCH<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public GBPGFJHMMGN<TMInput, TMOutput, TMNode> AFGPIFOFADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public MHOPGFCLMEH<TMInput, TMOutput, TMNode> DHGBKPCAKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public ICHBHINIGEP<TMInput, TMOutput, TMNode> KNJDANKNHDH;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x38722B0", Offset = "0x38710B0", VA = "0x1838722B0")]
	internal ICNADNJACCH([In] GBPGFJHMMGN<TMInput, TMOutput, TMNode> IKIGCPEBFIF, [In] MHOPGFCLMEH<TMInput, TMOutput, TMNode> NHNIENDEIDD, [In] ICHBHINIGEP<TMInput, TMOutput, TMNode> ABCAMALGADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3872000", Offset = "0x3870E00", VA = "0x183872000")]
	public static ICNADNJACCH<TMInput?, TMOutput?, TMNode?> IKCDCJJCDKO()
	{
		return default(ICNADNJACCH<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class IBKCAIMPKLI
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x27794B0", Offset = "0x27782B0", VA = "0x1827794B0")]
	public static AABIMLELKMI? CDDFPMJNNJO<TMInput, TMOutput, TMNode>([In] this ICNADNJACCH<TMInput, TMOutput, TMNode> OELHNDCFEMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x27790B0", Offset = "0x2777EB0", VA = "0x1827790B0")]
	public static ICNADNJACCH<TMInput?, TMOutput?, TMNode?> APHAODHFANA<TMInput, TMOutput, TMNode>(this AABIMLELKMI OELHNDCFEMO)
	{
		return default(ICNADNJACCH<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2779660", Offset = "0x2778460", VA = "0x182779660")]
	public static void COJAMHJFIEG<TMInput, TMOutput, TMNode>(this ICNADNJACCH<TMInput, TMOutput, TMNode> OELHNDCFEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2779050", Offset = "0x2777E50", VA = "0x182779050")]
	public static void AHFEKBCBPHM<TMInput, TMOutput, TMNode>(this ICNADNJACCH<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMOutput> OILKCHCFKKO, GPIFJNELMMP<TMInput> IEDMPFOCMGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2779C90", Offset = "0x2778A90", VA = "0x182779C90")]
	public static void HFHPAFADGEA<TMInput, TMOutput, TMNode>(this ICNADNJACCH<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMOutput> OILKCHCFKKO, GPIFJNELMMP<TMInput> IEDMPFOCMGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2779590", Offset = "0x2778390", VA = "0x182779590")]
	public static bool CFBDOIMHMAN<TMInput, TMOutput, TMNode>([In] this ICNADNJACCH<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMOutput> OILKCHCFKKO, GPIFJNELMMP<TMInput> IEDMPFOCMGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2779810", Offset = "0x2778610", VA = "0x182779810")]
	public static GPIFJNELMMP<TMNode?> DMIGFLPEMFB<TMNode, TMInput, TMOutput>(this ICNADNJACCH<TMInput, TMOutput, TMNode> OELHNDCFEMO)
	{
		return default(GPIFJNELMMP<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2779950", Offset = "0x2778750", VA = "0x182779950")]
	public static void FCEAGEJIPML<TMInput, TMOutput, TMNode>(this ICNADNJACCH<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMNode> GOOFHOHFPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x27797A0", Offset = "0x27785A0", VA = "0x1827797A0")]
	public static GPIFJNELMMP<TMInput?> DBPGNBCECOD<TMInput, TMOutput, TMNode>(this ICNADNJACCH<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMNode> GOOFHOHFPNL)
	{
		return default(GPIFJNELMMP<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2779AE0", Offset = "0x27788E0", VA = "0x182779AE0")]
	public static GPIFJNELMMP<TMOutput?> FGAFFMKJNOJ<TMOutput, TMInput, TMNode>(this ICNADNJACCH<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMNode> GOOFHOHFPNL)
	{
		return default(GPIFJNELMMP<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2779430", Offset = "0x2778230", VA = "0x182779430")]
	public static GPIFJNELMMP<TMInput?> BMMCJBAAMGO<TMInput, TMOutput, TMNode>(this ICNADNJACCH<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMNode> GOOFHOHFPNL, int OHINPGIGDNE)
	{
		return default(GPIFJNELMMP<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2779A60", Offset = "0x2778860", VA = "0x182779A60")]
	public static GPIFJNELMMP<TMOutput?> FCFIHJBLMJF<TMOutput, TMInput, TMNode>(this ICNADNJACCH<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMNode> GOOFHOHFPNL, int OHINPGIGDNE)
	{
		return default(GPIFJNELMMP<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2779BF0", Offset = "0x27789F0", VA = "0x182779BF0")]
	public static void GINEIPGCKML<TMInput, TMOutput, TMNode>(this ICNADNJACCH<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMNode> GOOFHOHFPNL, int EMGLKCBMMJH, int AJKKEBKAGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2779B50", Offset = "0x2778950", VA = "0x182779B50")]
	public static void FJHOGNIGLKI<TMInput, TMOutput, TMNode>(this ICNADNJACCH<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMNode> GOOFHOHFPNL, int EMGLKCBMMJH, int AJKKEBKAGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2779EF0", Offset = "0x2778CF0", VA = "0x182779EF0")]
	public static void ILCBHEFMLDL<TMInput, TMOutput, TMNode>(this ICNADNJACCH<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMInput> NKFNLDOHMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x27796C0", Offset = "0x27784C0", VA = "0x1827796C0")]
	public static void DBPEAGGGDDG<TMInput, TMOutput, TMNode>(this ICNADNJACCH<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMOutput> MKCJIMKGHPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x85C2D0", Offset = "0x85B0D0", VA = "0x18085C2D0")]
	public static NFAJAPJFFDF<TMInput?> PAIPPLBLBIL<TMInput, TMOutput, TMNode>([In] this ICNADNJACCH<TMInput, TMOutput, TMNode> OELHNDCFEMO)
	{
		return default(NFAJAPJFFDF<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2779FE0", Offset = "0x2778DE0", VA = "0x182779FE0")]
	public static NFAJAPJFFDF<TMOutput?> JBEFHFBHKML<TMOutput, TMInput, TMNode>([In] this ICNADNJACCH<TMInput, TMOutput, TMNode> OELHNDCFEMO)
	{
		return default(NFAJAPJFFDF<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2779420", Offset = "0x2778220", VA = "0x182779420")]
	public static NFAJAPJFFDF<TMNode?> BFHAABMJPPP<TMNode, TMInput, TMOutput>([In] this ICNADNJACCH<TMInput, TMOutput, TMNode> OELHNDCFEMO)
	{
		return default(NFAJAPJFFDF<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2779E80", Offset = "0x2778C80", VA = "0x182779E80")]
	public static DOIIOMAGOKC<TMInput?, TMOutput?, TMNode?> PPLFJMCBEJD<TMInput, TMOutput, TMNode>([In] this ICNADNJACCH<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMNode> FJIJLBIGEAH)
	{
		return default(DOIIOMAGOKC<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2779E80", Offset = "0x2778C80", VA = "0x182779E80")]
	public static KDAKLLBFGLE<TMInput?, TMOutput?, TMNode?> IDNCGJEGIHH<TMInput, TMOutput, TMNode>([In] this ICNADNJACCH<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMNode> FJIJLBIGEAH)
	{
		return default(KDAKLLBFGLE<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x27798A0", Offset = "0x27786A0", VA = "0x1827798A0")]
	public static KJABFMGFJHF<TMInput?, TMOutput?, TMNode?> FBJKHMGNEAD<TMInput, TMOutput, TMNode>([In] this ICNADNJACCH<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMNode> FJIJLBIGEAH)
	{
		return default(KJABFMGFJHF<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2779FF0", Offset = "0x2778DF0", VA = "0x182779FF0")]
	public static FJFCBJBPNEH<GPIFJNELMMP<TMInput?>, DOIIOMAGOKC<TMInput?, TMOutput?, TMNode?>> OODOFGJJMFI<TMInput, TMOutput, TMNode>([In] this ICNADNJACCH<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMNode> FJIJLBIGEAH)
	{
		return default(FJFCBJBPNEH<GPIFJNELMMP<TMInput>, DOIIOMAGOKC<TMInput, TMOutput, TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2779CF0", Offset = "0x2778AF0", VA = "0x182779CF0")]
	public static FJFCBJBPNEH<GPIFJNELMMP<TMNode?>, KJABFMGFJHF<TMInput?, TMOutput?, TMNode?>> HHCLFHEHLJP<TMNode, TMInput, TMOutput>([In] this ICNADNJACCH<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMNode> FJIJLBIGEAH)
	{
		return default(FJFCBJBPNEH<GPIFJNELMMP<TMNode>, KJABFMGFJHF<TMInput, TMOutput, TMNode>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct GBPGFJHMMGN<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal NFAJAPJFFDF<TMInput> HBNKCAOOBLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal HALEKHNPJIF<TMInput, GPIFJNELMMP<TMNode>> MIGNLHLJODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal HALEKHNPJIF<TMInput, FFPIJGBCMLA<GPIFJNELMMP<TMOutput>>> ILHIAECHKPM;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x32A7280", Offset = "0x32A6080", VA = "0x1832A7280")]
	internal GBPGFJHMMGN([In] NFAJAPJFFDF<TMInput> MONGILHCPGN, [In] HALEKHNPJIF<TMInput, GPIFJNELMMP<TMNode>> ABCAMALGADA, [In] HALEKHNPJIF<TMInput, FFPIJGBCMLA<GPIFJNELMMP<TMOutput>>> NHNIENDEIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x32A7010", Offset = "0x32A5E10", VA = "0x1832A7010")]
	internal static GBPGFJHMMGN<TMInput, TMOutput, TMNode> IKCDCJJCDKO()
	{
		return default(GBPGFJHMMGN<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class NCKDCOMMGKL
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2864420", Offset = "0x2863220", VA = "0x182864420")]
	internal static JKDOLADGBJF CDDFPMJNNJO<TMInput, TMOutput, TMNode>([In] this GBPGFJHMMGN<TMInput, TMOutput, TMNode> OELHNDCFEMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2863F10", Offset = "0x2862D10", VA = "0x182863F10")]
	internal static GBPGFJHMMGN<TMInput, TMOutput, TMNode> APHAODHFANA<TMInput, TMOutput, TMNode>(this JKDOLADGBJF OELHNDCFEMO)
	{
		return default(GBPGFJHMMGN<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x28647B0", Offset = "0x28635B0", VA = "0x1828647B0")]
	private static ANLJIJCFGFM CEBGGFNFMON<TMOutput>([In] this FFPIJGBCMLA<GPIFJNELMMP<TMOutput>> OELHNDCFEMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2864980", Offset = "0x2863780", VA = "0x182864980")]
	private static FFPIJGBCMLA<GPIFJNELMMP<TMOutput>> CLIEJMOKEJO<TMOutput>(this ANLJIJCFGFM OELHNDCFEMO)
	{
		return default(FFPIJGBCMLA<GPIFJNELMMP<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x26062E0", Offset = "0x26050E0", VA = "0x1826062E0")]
	internal static void COJAMHJFIEG<TMInput, TMOutput, TMNode>(this GBPGFJHMMGN<TMInput, TMOutput, TMNode> OELHNDCFEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2606920", Offset = "0x2605720", VA = "0x182606920")]
	internal static GPIFJNELMMP<TMInput> IHKLLPKOKGF<TMInput, TMOutput, TMNode>(this GBPGFJHMMGN<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMNode> NBFOPMANPGI)
	{
		return default(GPIFJNELMMP<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2606A60", Offset = "0x2605860", VA = "0x182606A60")]
	internal static void KKLNFJEOADM<TMInput, TMOutput, TMNode>(this GBPGFJHMMGN<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMInput> FJIJLBIGEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2601D90", Offset = "0x2600B90", VA = "0x182601D90")]
	public static bool LBIFEOPNNOK<TMInput, TMOutput, TMNode>([In] this GBPGFJHMMGN<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMInput> FJIJLBIGEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x22A5960", Offset = "0x22A4760", VA = "0x1822A5960")]
	public static int MIKCMFEBOEM<TMInput, TMOutput, TMNode>([In] this GBPGFJHMMGN<TMInput, TMOutput, TMNode> OELHNDCFEMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x26066F0", Offset = "0x26054F0", VA = "0x1826066F0")]
	public static GPIFJNELMMP<TMNode> ELIPJPMOEKM<TMNode, TMInput, TMOutput>([In] this GBPGFJHMMGN<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMInput> FJIJLBIGEAH)
	{
		return default(GPIFJNELMMP<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x26069C0", Offset = "0x26057C0", VA = "0x1826069C0")]
	public static int OGJJOMFBDGG<TMInput, TMOutput, TMNode>([In] this GBPGFJHMMGN<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMInput> FJIJLBIGEAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2606AF0", Offset = "0x26058F0", VA = "0x182606AF0")]
	public static GPIFJNELMMP<TMOutput> BKOKHOJONMC<TMOutput, TMInput, TMNode>([In] this GBPGFJHMMGN<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMInput> FJIJLBIGEAH, int OHINPGIGDNE)
	{
		return default(GPIFJNELMMP<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x26068E0", Offset = "0x26056E0", VA = "0x1826068E0")]
	internal static void GCIBFJENMDI<TMInput, TMOutput, TMNode>(this GBPGFJHMMGN<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMInput> FJIJLBIGEAH, GPIFJNELMMP<TMOutput> MKCJIMKGHPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x26068E0", Offset = "0x26056E0", VA = "0x1826068E0")]
	internal static void INOCAHNONMP<TMInput, TMOutput, TMNode>(this GBPGFJHMMGN<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMInput> FJIJLBIGEAH, GPIFJNELMMP<TMOutput> MKCJIMKGHPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2606A00", Offset = "0x2605800", VA = "0x182606A00")]
	public static FFPIJGBCMLA<GPIFJNELMMP<TMOutput>>.FGKNNFKLCGN MDNMFBAFJEK<TMOutput, TMInput, TMNode>([In] this GBPGFJHMMGN<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMInput> FJIJLBIGEAH)
	{
		return default(FFPIJGBCMLA<GPIFJNELMMP<TMOutput>>.FGKNNFKLCGN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2606A00", Offset = "0x2605800", VA = "0x182606A00")]
	public static PKNKEOLHBCK<GPIFJNELMMP<TMOutput>, FFPIJGBCMLA<GPIFJNELMMP<TMOutput>>.FGKNNFKLCGN> BPDOLDINLNI<TMOutput, TMInput, TMNode>([In] this GBPGFJHMMGN<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMInput> FJIJLBIGEAH)
	{
		return default(PKNKEOLHBCK<GPIFJNELMMP<TMOutput>, FFPIJGBCMLA<GPIFJNELMMP<TMOutput>>.FGKNNFKLCGN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct ICHBHINIGEP<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal NFAJAPJFFDF<TMNode> HBNKCAOOBLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal HALEKHNPJIF<TMNode, FFPIJGBCMLA<GPIFJNELMMP<TMInput>>> IBMOMLAKNFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal HALEKHNPJIF<TMNode, FFPIJGBCMLA<GPIFJNELMMP<TMOutput>>> ILHIAECHKPM;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x32A7280", Offset = "0x32A6080", VA = "0x1832A7280")]
	internal ICHBHINIGEP([In] NFAJAPJFFDF<TMNode> MONGILHCPGN, [In] HALEKHNPJIF<TMNode, FFPIJGBCMLA<GPIFJNELMMP<TMInput>>> IKIGCPEBFIF, [In] HALEKHNPJIF<TMNode, FFPIJGBCMLA<GPIFJNELMMP<TMOutput>>> NHNIENDEIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x32A7010", Offset = "0x32A5E10", VA = "0x1832A7010")]
	internal static ICHBHINIGEP<TMInput, TMOutput, TMNode> IKCDCJJCDKO()
	{
		return default(ICHBHINIGEP<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class KHILJDLHHAP
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x27CFCD0", Offset = "0x27CEAD0", VA = "0x1827CFCD0")]
	internal static CKBJCLEIDLE CDDFPMJNNJO<TMInput, TMOutput, TMNode>([In] this ICHBHINIGEP<TMInput, TMOutput, TMNode> OELHNDCFEMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x27CF7C0", Offset = "0x27CE5C0", VA = "0x1827CF7C0")]
	internal static ICHBHINIGEP<TMInput, TMOutput, TMNode> APHAODHFANA<TMInput, TMOutput, TMNode>(this CKBJCLEIDLE OELHNDCFEMO)
	{
		return default(ICHBHINIGEP<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x27D0740", Offset = "0x27CF540", VA = "0x1827D0740")]
	private static FKLNMHEFJHN KKDFNAIEKDK<TMInput>([In] this FFPIJGBCMLA<GPIFJNELMMP<TMInput>> OELHNDCFEMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x27D0A70", Offset = "0x27CF870", VA = "0x1827D0A70")]
	private static FFPIJGBCMLA<GPIFJNELMMP<TMInput>> NHBNFEDOMLK<TMInput>(this FKLNMHEFJHN OELHNDCFEMO)
	{
		return default(FFPIJGBCMLA<GPIFJNELMMP<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x27D0CF0", Offset = "0x27CFAF0", VA = "0x1827D0CF0")]
	private static GFCDPFNNBDG OIGFIGNPNOP<TMOutput>([In] this FFPIJGBCMLA<GPIFJNELMMP<TMOutput>> OELHNDCFEMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x27D04C0", Offset = "0x27CF2C0", VA = "0x1827D04C0")]
	private static FFPIJGBCMLA<GPIFJNELMMP<TMOutput>> JLPPNPCBMKB<TMOutput>(this GFCDPFNNBDG OELHNDCFEMO)
	{
		return default(FFPIJGBCMLA<GPIFJNELMMP<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x27D0090", Offset = "0x27CEE90", VA = "0x1827D0090")]
	internal static void COJAMHJFIEG<TMInput, TMOutput, TMNode>(this ICHBHINIGEP<TMInput, TMOutput, TMNode> OELHNDCFEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x27D0390", Offset = "0x27CF190", VA = "0x1827D0390")]
	internal static GPIFJNELMMP<TMNode> IHKLLPKOKGF<TMNode, TMInput, TMOutput>(this ICHBHINIGEP<TMInput, TMOutput, TMNode> OELHNDCFEMO, [In] FFPIJGBCMLA<GPIFJNELMMP<TMInput>> IKIGCPEBFIF, [In] FFPIJGBCMLA<GPIFJNELMMP<TMOutput>> NHNIENDEIDD)
	{
		return default(GPIFJNELMMP<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x27D0910", Offset = "0x27CF710", VA = "0x1827D0910")]
	internal static void KKLNFJEOADM<TMInput, TMOutput, TMNode>(this ICHBHINIGEP<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMNode> FJIJLBIGEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2601D90", Offset = "0x2600B90", VA = "0x182601D90")]
	public static bool LBIFEOPNNOK<TMInput, TMOutput, TMNode>([In] this ICHBHINIGEP<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMNode> FJIJLBIGEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x22A5960", Offset = "0x22A4760", VA = "0x1822A5960")]
	public static int MIKCMFEBOEM<TMInput, TMOutput, TMNode>([In] this ICHBHINIGEP<TMInput, TMOutput, TMNode> OELHNDCFEMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x27D0420", Offset = "0x27CF220", VA = "0x1827D0420")]
	public static int INIMANDHPFO<TMInput, TMOutput, TMNode>([In] this ICHBHINIGEP<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMNode> FJIJLBIGEAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x26069C0", Offset = "0x26057C0", VA = "0x1826069C0")]
	public static int OGJJOMFBDGG<TMInput, TMOutput, TMNode>([In] this ICHBHINIGEP<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMNode> FJIJLBIGEAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x27D09D0", Offset = "0x27CF7D0", VA = "0x1827D09D0")]
	public static GPIFJNELMMP<TMInput> MHDJIPOIGBL<TMInput, TMOutput, TMNode>([In] this ICHBHINIGEP<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMNode> FJIJLBIGEAH, int OHINPGIGDNE)
	{
		return default(GPIFJNELMMP<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2606AF0", Offset = "0x26058F0", VA = "0x182606AF0")]
	public static GPIFJNELMMP<TMOutput> BKOKHOJONMC<TMOutput, TMInput, TMNode>([In] this ICHBHINIGEP<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMNode> FJIJLBIGEAH, int OHINPGIGDNE)
	{
		return default(GPIFJNELMMP<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x27D0350", Offset = "0x27CF150", VA = "0x1827D0350")]
	internal static void HOPECFLCOBG<TMInput, TMOutput, TMNode>(this ICHBHINIGEP<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMNode> FJIJLBIGEAH, GPIFJNELMMP<TMInput> NKFNLDOHMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x26068E0", Offset = "0x26056E0", VA = "0x1826068E0")]
	internal static void GCIBFJENMDI<TMInput, TMOutput, TMNode>(this ICHBHINIGEP<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMNode> FJIJLBIGEAH, GPIFJNELMMP<TMOutput> MKCJIMKGHPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x27D0A20", Offset = "0x27CF820", VA = "0x1827D0A20")]
	internal static void NENAPEIFEGF<TMInput, TMOutput, TMNode>(this ICHBHINIGEP<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMNode> FJIJLBIGEAH, int OHINPGIGDNE, GPIFJNELMMP<TMInput> NKFNLDOHMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x27D0EC0", Offset = "0x27CFCC0", VA = "0x1827D0EC0")]
	internal static void PNNJLGFNLCM<TMInput, TMOutput, TMNode>(this ICHBHINIGEP<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMNode> FJIJLBIGEAH, int OHINPGIGDNE, GPIFJNELMMP<TMOutput> MKCJIMKGHPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x27D0350", Offset = "0x27CF150", VA = "0x1827D0350")]
	internal static void MNFHGEPOIJD<TMInput, TMOutput, TMNode>(this ICHBHINIGEP<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMNode> FJIJLBIGEAH, GPIFJNELMMP<TMInput> NKFNLDOHMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x26068E0", Offset = "0x26056E0", VA = "0x1826068E0")]
	internal static void INOCAHNONMP<TMInput, TMOutput, TMNode>(this ICHBHINIGEP<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMNode> FJIJLBIGEAH, GPIFJNELMMP<TMOutput> MKCJIMKGHPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x27D0460", Offset = "0x27CF260", VA = "0x1827D0460")]
	public static FFPIJGBCMLA<GPIFJNELMMP<TMInput>>.FGKNNFKLCGN JADIAPFCGBG<TMInput, TMOutput, TMNode>([In] this ICHBHINIGEP<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMNode> FJIJLBIGEAH)
	{
		return default(FFPIJGBCMLA<GPIFJNELMMP<TMInput>>.FGKNNFKLCGN);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2606A00", Offset = "0x2605800", VA = "0x182606A00")]
	public static FFPIJGBCMLA<GPIFJNELMMP<TMOutput>>.FGKNNFKLCGN MDNMFBAFJEK<TMOutput, TMInput, TMNode>([In] this ICHBHINIGEP<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMNode> FJIJLBIGEAH)
	{
		return default(FFPIJGBCMLA<GPIFJNELMMP<TMOutput>>.FGKNNFKLCGN);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x27D0460", Offset = "0x27CF260", VA = "0x1827D0460")]
	public static PKNKEOLHBCK<GPIFJNELMMP<TMInput>, FFPIJGBCMLA<GPIFJNELMMP<TMInput>>.FGKNNFKLCGN> KFIMAGCMOEA<TMInput, TMOutput, TMNode>([In] this ICHBHINIGEP<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMNode> FJIJLBIGEAH)
	{
		return default(PKNKEOLHBCK<GPIFJNELMMP<TMInput>, FFPIJGBCMLA<GPIFJNELMMP<TMInput>>.FGKNNFKLCGN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2606A00", Offset = "0x2605800", VA = "0x182606A00")]
	public static PKNKEOLHBCK<GPIFJNELMMP<TMOutput>, FFPIJGBCMLA<GPIFJNELMMP<TMOutput>>.FGKNNFKLCGN> BPDOLDINLNI<TMOutput, TMInput, TMNode>([In] this ICHBHINIGEP<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMNode> FJIJLBIGEAH)
	{
		return default(PKNKEOLHBCK<GPIFJNELMMP<TMOutput>, FFPIJGBCMLA<GPIFJNELMMP<TMOutput>>.FGKNNFKLCGN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2601EF0", Offset = "0x2600CF0", VA = "0x182601EF0")]
	public static FJFCBJBPNEH<GPIFJNELMMP<TMNode>, NFAJAPJFFDF<TMNode>.PMKHKHELBLO> JPGNJFCBBKO<TMNode, TMInput, TMOutput>([In] this ICHBHINIGEP<TMInput, TMOutput, TMNode> OELHNDCFEMO)
	{
		return default(FJFCBJBPNEH<GPIFJNELMMP<TMNode>, NFAJAPJFFDF<TMNode>.PMKHKHELBLO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct MHOPGFCLMEH<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal NFAJAPJFFDF<TMOutput> HBNKCAOOBLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal HALEKHNPJIF<TMOutput, GPIFJNELMMP<TMNode>> MIGNLHLJODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal HALEKHNPJIF<TMOutput, FFPIJGBCMLA<GPIFJNELMMP<TMInput>>> IBMOMLAKNFE;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x32A7280", Offset = "0x32A6080", VA = "0x1832A7280")]
	internal MHOPGFCLMEH([In] NFAJAPJFFDF<TMOutput> MONGILHCPGN, [In] HALEKHNPJIF<TMOutput, GPIFJNELMMP<TMNode>> ABCAMALGADA, [In] HALEKHNPJIF<TMOutput, FFPIJGBCMLA<GPIFJNELMMP<TMInput>>> IKIGCPEBFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x32A7010", Offset = "0x32A5E10", VA = "0x1832A7010")]
	internal static MHOPGFCLMEH<TMInput, TMOutput, TMNode> IKCDCJJCDKO()
	{
		return default(MHOPGFCLMEH<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class EPCGBNNODFA
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2605F50", Offset = "0x2604D50", VA = "0x182605F50")]
	internal static GILKJLMHIIB CDDFPMJNNJO<TMInput, TMOutput, TMNode>([In] this MHOPGFCLMEH<TMInput, TMOutput, TMNode> OELHNDCFEMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2605A40", Offset = "0x2604840", VA = "0x182605A40")]
	internal static MHOPGFCLMEH<TMInput, TMOutput, TMNode> APHAODHFANA<TMInput, TMOutput, TMNode>(this GILKJLMHIIB OELHNDCFEMO)
	{
		return default(MHOPGFCLMEH<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2606710", Offset = "0x2605510", VA = "0x182606710")]
	private static JDPEFHLMAFF FEBLAGOIMBI<TMInput>([In] this FFPIJGBCMLA<GPIFJNELMMP<TMInput>> OELHNDCFEMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2606470", Offset = "0x2605270", VA = "0x182606470")]
	private static FFPIJGBCMLA<GPIFJNELMMP<TMInput>> DLBBKGEGLEN<TMInput>(this JDPEFHLMAFF OELHNDCFEMO)
	{
		return default(FFPIJGBCMLA<GPIFJNELMMP<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x26062E0", Offset = "0x26050E0", VA = "0x1826062E0")]
	internal static void COJAMHJFIEG<TMInput, TMOutput, TMNode>(this MHOPGFCLMEH<TMInput, TMOutput, TMNode> OELHNDCFEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2606920", Offset = "0x2605720", VA = "0x182606920")]
	internal static GPIFJNELMMP<TMOutput> IHKLLPKOKGF<TMOutput, TMInput, TMNode>(this MHOPGFCLMEH<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMNode> NBFOPMANPGI)
	{
		return default(GPIFJNELMMP<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2606A60", Offset = "0x2605860", VA = "0x182606A60")]
	internal static void KKLNFJEOADM<TMInput, TMOutput, TMNode>(this MHOPGFCLMEH<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMOutput> FJIJLBIGEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2601D90", Offset = "0x2600B90", VA = "0x182601D90")]
	public static bool LBIFEOPNNOK<TMInput, TMOutput, TMNode>([In] this MHOPGFCLMEH<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMOutput> FJIJLBIGEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x22A5960", Offset = "0x22A4760", VA = "0x1822A5960")]
	public static int MIKCMFEBOEM<TMInput, TMOutput, TMNode>([In] this MHOPGFCLMEH<TMInput, TMOutput, TMNode> OELHNDCFEMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x26066F0", Offset = "0x26054F0", VA = "0x1826066F0")]
	public static GPIFJNELMMP<TMNode> ELIPJPMOEKM<TMNode, TMInput, TMOutput>([In] this MHOPGFCLMEH<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMOutput> FJIJLBIGEAH)
	{
		return default(GPIFJNELMMP<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x26069C0", Offset = "0x26057C0", VA = "0x1826069C0")]
	public static int INIMANDHPFO<TMInput, TMOutput, TMNode>([In] this MHOPGFCLMEH<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMOutput> FJIJLBIGEAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2606AF0", Offset = "0x26058F0", VA = "0x182606AF0")]
	public static GPIFJNELMMP<TMInput> MHDJIPOIGBL<TMInput, TMOutput, TMNode>([In] this MHOPGFCLMEH<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMOutput> FJIJLBIGEAH, int OHINPGIGDNE)
	{
		return default(GPIFJNELMMP<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x26068E0", Offset = "0x26056E0", VA = "0x1826068E0")]
	internal static void HOPECFLCOBG<TMInput, TMOutput, TMNode>(this MHOPGFCLMEH<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMOutput> FJIJLBIGEAH, GPIFJNELMMP<TMInput> NKFNLDOHMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x26068E0", Offset = "0x26056E0", VA = "0x1826068E0")]
	internal static void MNFHGEPOIJD<TMInput, TMOutput, TMNode>(this MHOPGFCLMEH<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMOutput> FJIJLBIGEAH, GPIFJNELMMP<TMInput> NKFNLDOHMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2606A00", Offset = "0x2605800", VA = "0x182606A00")]
	public static FFPIJGBCMLA<GPIFJNELMMP<TMInput>>.FGKNNFKLCGN JADIAPFCGBG<TMInput, TMOutput, TMNode>([In] this MHOPGFCLMEH<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMOutput> FJIJLBIGEAH)
	{
		return default(FFPIJGBCMLA<GPIFJNELMMP<TMInput>>.FGKNNFKLCGN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2606A00", Offset = "0x2605800", VA = "0x182606A00")]
	public static PKNKEOLHBCK<GPIFJNELMMP<TMInput>, FFPIJGBCMLA<GPIFJNELMMP<TMInput>>.FGKNNFKLCGN> KFIMAGCMOEA<TMInput, TMOutput, TMNode>([In] this MHOPGFCLMEH<TMInput, TMOutput, TMNode> OELHNDCFEMO, GPIFJNELMMP<TMOutput> FJIJLBIGEAH)
	{
		return default(PKNKEOLHBCK<GPIFJNELMMP<TMInput>, FFPIJGBCMLA<GPIFJNELMMP<TMInput>>.FGKNNFKLCGN>);
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
