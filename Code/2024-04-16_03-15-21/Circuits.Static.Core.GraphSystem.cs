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
		[Cpp2IlInjected.Address(RVA = "0x7DEA50", Offset = "0x7DDC50", VA = "0x1807DEA50")]
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
		[Cpp2IlInjected.Address(RVA = "0x1E1CCF0", Offset = "0x1E1BEF0", VA = "0x181E1CCF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DED90", Offset = "0x7DDF90", VA = "0x1807DED90")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DEDD0", Offset = "0x7DDFD0", VA = "0x1807DEDD0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct POPGEEJONAO<TMInput, TMOutput, TMNode> : IEnumerator<KHCIOCBLCGC<TMNode>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private HFFNKFOLKDB<TMInput, TMOutput, TMNode> NENNOPNKAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private MGABMPBLNIH<TMInput, TMOutput, TMNode> IOGOGECIKGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private bool CHFFNPGNKGA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly KHCIOCBLCGC<TMNode> KOOHOOFHLKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x41C0D80", Offset = "0x41BFF80", VA = "0x1841C0D80", Slot = "4")]
		get
		{
			return default(KHCIOCBLCGC<TMNode>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x41C0C30", Offset = "0x41BFE30", VA = "0x1841C0C30", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x41C0CB0", Offset = "0x41BFEB0", VA = "0x1841C0CB0")]
	internal POPGEEJONAO([In] HFFNKFOLKDB<TMInput, TMOutput, TMNode> EJOBLOCPDGN, [In] MGABMPBLNIH<TMInput, TMOutput, TMNode> LFDPLFJHHDC, bool LFAFOCDCKJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x41C0AF0", Offset = "0x41BFCF0", VA = "0x1841C0AF0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x41C0BB0", Offset = "0x41BFDB0", VA = "0x1841C0BB0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x41C0A80", Offset = "0x41BFC80", VA = "0x1841C0A80", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class AEPPFKMPPBD
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2EA7680", Offset = "0x2EA6880", VA = "0x182EA7680")]
	public static POPGEEJONAO<TMInput, TMOutput, TMNode> DHBNKMCPKNO<TMInput, TMOutput, TMNode>([In] HJJJJKLNJLM<TMInput, TMOutput, TMNode> AALBPNNMAKE, KHCIOCBLCGC<TMNode> MBBENIIFGEP)
	{
		return default(POPGEEJONAO<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct MGABMPBLNIH<TMInput, TMOutput, TMNode> : IEnumerator<KHCIOCBLCGC<TMInput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private HKBGLAIKAIG<KHCIOCBLCGC<TMOutput>>.COPJIAJAIMG JMAMDFGLPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private HKBGLAIKAIG<KHCIOCBLCGC<TMInput>>.COPJIAJAIMG BNIIPICMEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly DIENMNKCHHC<TMInput, TMOutput, TMNode> ENBFEHNLPKJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public KHCIOCBLCGC<TMInput> KOOHOOFHLKE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3963A00", Offset = "0x3962C00", VA = "0x183963A00", Slot = "4")]
		get
		{
			return default(KHCIOCBLCGC<TMInput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x39638E0", Offset = "0x3962AE0", VA = "0x1839638E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3963980", Offset = "0x3962B80", VA = "0x183963980")]
	internal MGABMPBLNIH([In] HKBGLAIKAIG<KHCIOCBLCGC<TMOutput>>.COPJIAJAIMG GMNLLAMFDMH, [In] HKBGLAIKAIG<KHCIOCBLCGC<TMInput>>.COPJIAJAIMG DFIAELNNNCF, [In] DIENMNKCHHC<TMInput, TMOutput, TMNode> JDEIDENAEGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3963720", Offset = "0x3962920", VA = "0x183963720", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3963870", Offset = "0x3962A70", VA = "0x183963870", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x39636B0", Offset = "0x39628B0", VA = "0x1839636B0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class FNKBLJKPKLC
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x287E7C0", Offset = "0x287D9C0", VA = "0x18287E7C0")]
	public static MGABMPBLNIH<TMInput, TMOutput, TMNode> DHBNKMCPKNO<TMInput, TMOutput, TMNode>([In] HJJJJKLNJLM<TMInput, TMOutput, TMNode> AALBPNNMAKE, KHCIOCBLCGC<TMNode> MBBENIIFGEP)
	{
		return default(MGABMPBLNIH<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct HFFNKFOLKDB<TMInput, TMOutput, TMNode> : IEnumerator<KHCIOCBLCGC<TMOutput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private HKBGLAIKAIG<KHCIOCBLCGC<TMInput>>.COPJIAJAIMG LLHAGBDKEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private HKBGLAIKAIG<KHCIOCBLCGC<TMOutput>>.COPJIAJAIMG CFKBLAHGHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly FIMHDIGJJMN<TMInput, TMOutput, TMNode> HAFILOEPIHD;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public KHCIOCBLCGC<TMOutput> KOOHOOFHLKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3963A00", Offset = "0x3962C00", VA = "0x183963A00", Slot = "4")]
		get
		{
			return default(KHCIOCBLCGC<TMOutput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x39638E0", Offset = "0x3962AE0", VA = "0x1839638E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3963980", Offset = "0x3962B80", VA = "0x183963980")]
	internal HFFNKFOLKDB([In] HKBGLAIKAIG<KHCIOCBLCGC<TMInput>>.COPJIAJAIMG MIALEJLEIFD, [In] HKBGLAIKAIG<KHCIOCBLCGC<TMOutput>>.COPJIAJAIMG IHJNIKNGJPJ, [In] FIMHDIGJJMN<TMInput, TMOutput, TMNode> BIFMLIGMEOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3963720", Offset = "0x3962920", VA = "0x183963720", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3963870", Offset = "0x3962A70", VA = "0x183963870", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x39636B0", Offset = "0x39628B0", VA = "0x1839636B0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class AIGBKEEOMEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2EA92C0", Offset = "0x2EA84C0", VA = "0x182EA92C0")]
	public static HFFNKFOLKDB<TMInput, TMOutput, TMNode> DHBNKMCPKNO<TMInput, TMOutput, TMNode>([In] HJJJJKLNJLM<TMInput, TMOutput, TMNode> AALBPNNMAKE, KHCIOCBLCGC<TMNode> MBBENIIFGEP)
	{
		return default(HFFNKFOLKDB<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct HJJJJKLNJLM<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public FIMHDIGJJMN<TMInput, TMOutput, TMNode> KAKNBLEBMCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public DIENMNKCHHC<TMInput, TMOutput, TMNode> GOFKEJIILLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public MCJPGMIADAK<TMInput, TMOutput, TMNode> CHJDFBEOCGD;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3974A40", Offset = "0x3973C40", VA = "0x183974A40")]
	internal HJJJJKLNJLM([In] FIMHDIGJJMN<TMInput, TMOutput, TMNode> BIFMLIGMEOK, [In] DIENMNKCHHC<TMInput, TMOutput, TMNode> JDEIDENAEGI, [In] MCJPGMIADAK<TMInput, TMOutput, TMNode> MCMNPMKHJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x39747A0", Offset = "0x39739A0", VA = "0x1839747A0")]
	public static HJJJJKLNJLM<TMInput?, TMOutput?, TMNode?> DHBNKMCPKNO()
	{
		return default(HJJJJKLNJLM<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class EKPLDMGMLEB
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2743F50", Offset = "0x2743150", VA = "0x182743F50")]
	public static HNPPPJKAHCE? JCBMCDNAHJB<TMInput, TMOutput, TMNode>([In] this HJJJJKLNJLM<TMInput, TMOutput, TMNode> AOFIGDLFNLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x27442A0", Offset = "0x27434A0", VA = "0x1827442A0")]
	public static HJJJJKLNJLM<TMInput?, TMOutput?, TMNode?> MAOCPLNNJJM<TMInput, TMOutput, TMNode>(this HNPPPJKAHCE AOFIGDLFNLH)
	{
		return default(HJJJJKLNJLM<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x27439B0", Offset = "0x2742BB0", VA = "0x1827439B0")]
	public static void CJPKHGMGMMP<TMInput, TMOutput, TMNode>(this HJJJJKLNJLM<TMInput, TMOutput, TMNode> AOFIGDLFNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2744700", Offset = "0x2743900", VA = "0x182744700")]
	public static void NPFHFJPJGCF<TMInput, TMOutput, TMNode>(this HJJJJKLNJLM<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMOutput> PAFLPPOBMOG, KHCIOCBLCGC<TMInput> HKGFBLIPGLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2744120", Offset = "0x2743320", VA = "0x182744120")]
	public static void JNBLFPKBIGF<TMInput, TMOutput, TMNode>(this HJJJJKLNJLM<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMOutput> PAFLPPOBMOG, KHCIOCBLCGC<TMInput> HKGFBLIPGLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2743A10", Offset = "0x2742C10", VA = "0x182743A10")]
	public static bool DEKBDOAAAPM<TMInput, TMOutput, TMNode>([In] this HJJJJKLNJLM<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMOutput> PAFLPPOBMOG, KHCIOCBLCGC<TMInput> HKGFBLIPGLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2743B80", Offset = "0x2742D80", VA = "0x182743B80")]
	public static KHCIOCBLCGC<TMNode?> GFGECPFECDF<TMNode, TMInput, TMOutput>(this HJJJJKLNJLM<TMInput, TMOutput, TMNode> AOFIGDLFNLH)
	{
		return default(KHCIOCBLCGC<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2743C10", Offset = "0x2742E10", VA = "0x182743C10")]
	public static void GKGOJOBEAHO<TMInput, TMOutput, TMNode>(this HJJJJKLNJLM<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMNode> MBBENIIFGEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x27440B0", Offset = "0x27432B0", VA = "0x1827440B0")]
	public static KHCIOCBLCGC<TMInput?> JMOGHNHPOCB<TMInput, TMOutput, TMNode>(this HJJJJKLNJLM<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMNode> MBBENIIFGEP)
	{
		return default(KHCIOCBLCGC<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2744610", Offset = "0x2743810", VA = "0x182744610")]
	public static KHCIOCBLCGC<TMOutput?> MCCKGDJAIJD<TMOutput, TMInput, TMNode>(this HJJJJKLNJLM<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMNode> MBBENIIFGEP)
	{
		return default(KHCIOCBLCGC<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2744680", Offset = "0x2743880", VA = "0x182744680")]
	public static KHCIOCBLCGC<TMInput?> MMNKMAMHOFP<TMInput, TMOutput, TMNode>(this HJJJJKLNJLM<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMNode> MBBENIIFGEP, int MBGANDEDPDN)
	{
		return default(KHCIOCBLCGC<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2744030", Offset = "0x2743230", VA = "0x182744030")]
	public static KHCIOCBLCGC<TMOutput?> JCDILKMPDPB<TMOutput, TMInput, TMNode>(this HJJJJKLNJLM<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMNode> MBBENIIFGEP, int MBGANDEDPDN)
	{
		return default(KHCIOCBLCGC<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2743AE0", Offset = "0x2742CE0", VA = "0x182743AE0")]
	public static void EFKKCGLKFPI<TMInput, TMOutput, TMNode>(this HJJJJKLNJLM<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMNode> MBBENIIFGEP, int PBGPEEEODIJ, int GFNEJJNJDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2743D20", Offset = "0x2742F20", VA = "0x182743D20")]
	public static void HDEDNAKFJHP<TMInput, TMOutput, TMNode>(this HJJJJKLNJLM<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMNode> MBBENIIFGEP, int PBGPEEEODIJ, int GFNEJJNJDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2744760", Offset = "0x2743960", VA = "0x182744760")]
	public static void PHPIAEHNLKP<TMInput, TMOutput, TMNode>(this HJJJJKLNJLM<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMInput> HNCOCKJDHMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x27437A0", Offset = "0x27429A0", VA = "0x1827437A0")]
	public static void BCECEEGKFNI<TMInput, TMOutput, TMNode>(this HJJJJKLNJLM<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMOutput> BDBHJLOOAPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8788E0", Offset = "0x877AE0", VA = "0x1808788E0")]
	public static PFCKHHIJLEE<TMInput?> HHJHLAFNLCG<TMInput, TMOutput, TMNode>([In] this HJJJJKLNJLM<TMInput, TMOutput, TMNode> AOFIGDLFNLH)
	{
		return default(PFCKHHIJLEE<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2744290", Offset = "0x2743490", VA = "0x182744290")]
	public static PFCKHHIJLEE<TMOutput?> LKAJNLIAFPM<TMOutput, TMInput, TMNode>([In] this HJJJJKLNJLM<TMInput, TMOutput, TMNode> AOFIGDLFNLH)
	{
		return default(PFCKHHIJLEE<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2743930", Offset = "0x2742B30", VA = "0x182743930")]
	public static PFCKHHIJLEE<TMNode?> CICGBINKFIO<TMNode, TMInput, TMOutput>([In] this HJJJJKLNJLM<TMInput, TMOutput, TMNode> AOFIGDLFNLH)
	{
		return default(PFCKHHIJLEE<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2743940", Offset = "0x2742B40", VA = "0x182743940")]
	public static MGABMPBLNIH<TMInput?, TMOutput?, TMNode?> KHEGPOLHBKG<TMInput, TMOutput, TMNode>([In] this HJJJJKLNJLM<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMNode> POAELFIOKHK)
	{
		return default(MGABMPBLNIH<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2743940", Offset = "0x2742B40", VA = "0x182743940")]
	public static HFFNKFOLKDB<TMInput?, TMOutput?, TMNode?> CIIEOBOJOFG<TMInput, TMOutput, TMNode>([In] this HJJJJKLNJLM<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMNode> POAELFIOKHK)
	{
		return default(HFFNKFOLKDB<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2743880", Offset = "0x2742A80", VA = "0x182743880")]
	public static POPGEEJONAO<TMInput?, TMOutput?, TMNode?> BHKJMNFEMNB<TMInput, TMOutput, TMNode>([In] this HJJJJKLNJLM<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMNode> POAELFIOKHK)
	{
		return default(POPGEEJONAO<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2744180", Offset = "0x2743380", VA = "0x182744180")]
	public static FKOGJKIBHGK<KHCIOCBLCGC<TMInput?>, MGABMPBLNIH<TMInput?, TMOutput?, TMNode?>> KKKFNDDPGKP<TMInput, TMOutput, TMNode>([In] this HJJJJKLNJLM<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMNode> POAELFIOKHK)
	{
		return default(FKOGJKIBHGK<KHCIOCBLCGC<TMInput>, MGABMPBLNIH<TMInput, TMOutput, TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2743DC0", Offset = "0x2742FC0", VA = "0x182743DC0")]
	public static FKOGJKIBHGK<KHCIOCBLCGC<TMNode?>, POPGEEJONAO<TMInput?, TMOutput?, TMNode?>> HFBAPJGMNFP<TMNode, TMInput, TMOutput>([In] this HJJJJKLNJLM<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMNode> POAELFIOKHK)
	{
		return default(FKOGJKIBHGK<KHCIOCBLCGC<TMNode>, POPGEEJONAO<TMInput, TMOutput, TMNode>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct FIMHDIGJJMN<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal PFCKHHIJLEE<TMInput> IIFBKKCFLID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal FNDGEEMAGCJ<TMInput, KHCIOCBLCGC<TMNode>> CLBLHDPGBJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal FNDGEEMAGCJ<TMInput, HKBGLAIKAIG<KHCIOCBLCGC<TMOutput>>> ENBFEHNLPKJ;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x37B2C90", Offset = "0x37B1E90", VA = "0x1837B2C90")]
	internal FIMHDIGJJMN([In] PFCKHHIJLEE<TMInput> CNAHEPIILLF, [In] FNDGEEMAGCJ<TMInput, KHCIOCBLCGC<TMNode>> MCMNPMKHJJL, [In] FNDGEEMAGCJ<TMInput, HKBGLAIKAIG<KHCIOCBLCGC<TMOutput>>> JDEIDENAEGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x37B2AE0", Offset = "0x37B1CE0", VA = "0x1837B2AE0")]
	internal static FIMHDIGJJMN<TMInput, TMOutput, TMNode> DHBNKMCPKNO()
	{
		return default(FIMHDIGJJMN<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class OHHFDNEONIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2A037A0", Offset = "0x2A029A0", VA = "0x182A037A0")]
	internal static FHENIOPOILB JCBMCDNAHJB<TMInput, TMOutput, TMNode>([In] this FIMHDIGJJMN<TMInput, TMOutput, TMNode> AOFIGDLFNLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2A03B20", Offset = "0x2A02D20", VA = "0x182A03B20")]
	internal static FIMHDIGJJMN<TMInput, TMOutput, TMNode> MAOCPLNNJJM<TMInput, TMOutput, TMNode>(this FHENIOPOILB AOFIGDLFNLH)
	{
		return default(FIMHDIGJJMN<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2A03360", Offset = "0x2A02560", VA = "0x182A03360")]
	private static KIMKOIIDAMC FBECMAKINIA<TMOutput>([In] this HKBGLAIKAIG<KHCIOCBLCGC<TMOutput>> AOFIGDLFNLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2A03530", Offset = "0x2A02730", VA = "0x182A03530")]
	private static HKBGLAIKAIG<KHCIOCBLCGC<TMOutput>> HHLNELAFOEC<TMOutput>(this KIMKOIIDAMC AOFIGDLFNLH)
	{
		return default(HKBGLAIKAIG<KHCIOCBLCGC<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x28A2290", Offset = "0x28A1490", VA = "0x1828A2290")]
	internal static void CJPKHGMGMMP<TMInput, TMOutput, TMNode>(this FIMHDIGJJMN<TMInput, TMOutput, TMNode> AOFIGDLFNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x28A28F0", Offset = "0x28A1AF0", VA = "0x1828A28F0")]
	internal static KHCIOCBLCGC<TMInput> ILKJCDANLHA<TMInput, TMOutput, TMNode>(this FIMHDIGJJMN<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMNode> JCCACJKHFKB)
	{
		return default(KHCIOCBLCGC<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x28A2D10", Offset = "0x28A1F10", VA = "0x1828A2D10")]
	internal static void JKJINJEHPOI<TMInput, TMOutput, TMNode>(this FIMHDIGJJMN<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMInput> POAELFIOKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x271E600", Offset = "0x271D800", VA = "0x18271E600")]
	public static bool BFJAEMLKAPK<TMInput, TMOutput, TMNode>([In] this FIMHDIGJJMN<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMInput> POAELFIOKHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2724420", Offset = "0x2723620", VA = "0x182724420")]
	public static int NAJFOKPMGAH<TMInput, TMOutput, TMNode>([In] this FIMHDIGJJMN<TMInput, TMOutput, TMNode> AOFIGDLFNLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x28A2DA0", Offset = "0x28A1FA0", VA = "0x1828A2DA0")]
	public static KHCIOCBLCGC<TMNode> KLPNOBJHHHE<TMNode, TMInput, TMOutput>([In] this FIMHDIGJJMN<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMInput> POAELFIOKHK)
	{
		return default(KHCIOCBLCGC<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x28A2250", Offset = "0x28A1450", VA = "0x1828A2250")]
	public static int DLEOHCJAJHK<TMInput, TMOutput, TMNode>([In] this FIMHDIGJJMN<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMInput> POAELFIOKHK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x28A2630", Offset = "0x28A1830", VA = "0x1828A2630")]
	public static KHCIOCBLCGC<TMOutput> GLLIEOELMGG<TMOutput, TMInput, TMNode>([In] this FIMHDIGJJMN<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMInput> POAELFIOKHK, int MBGANDEDPDN)
	{
		return default(KHCIOCBLCGC<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x28A2420", Offset = "0x28A1620", VA = "0x1828A2420")]
	internal static void MKMHNFOIMOG<TMInput, TMOutput, TMNode>(this FIMHDIGJJMN<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMInput> POAELFIOKHK, KHCIOCBLCGC<TMOutput> BDBHJLOOAPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x28A2420", Offset = "0x28A1620", VA = "0x1828A2420")]
	internal static void DCMNBOKNKHB<TMInput, TMOutput, TMNode>(this FIMHDIGJJMN<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMInput> POAELFIOKHK, KHCIOCBLCGC<TMOutput> BDBHJLOOAPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x28A32C0", Offset = "0x28A24C0", VA = "0x1828A32C0")]
	public static HKBGLAIKAIG<KHCIOCBLCGC<TMOutput>>.COPJIAJAIMG IGKCECFAADE<TMOutput, TMInput, TMNode>([In] this FIMHDIGJJMN<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMInput> POAELFIOKHK)
	{
		return default(HKBGLAIKAIG<KHCIOCBLCGC<TMOutput>>.COPJIAJAIMG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x28A32C0", Offset = "0x28A24C0", VA = "0x1828A32C0")]
	public static NBMKDLCHCHO<KHCIOCBLCGC<TMOutput>, HKBGLAIKAIG<KHCIOCBLCGC<TMOutput>>.COPJIAJAIMG> HNNLLNMDADO<TMOutput, TMInput, TMNode>([In] this FIMHDIGJJMN<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMInput> POAELFIOKHK)
	{
		return default(NBMKDLCHCHO<KHCIOCBLCGC<TMOutput>, HKBGLAIKAIG<KHCIOCBLCGC<TMOutput>>.COPJIAJAIMG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct MCJPGMIADAK<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal PFCKHHIJLEE<TMNode> IIFBKKCFLID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal FNDGEEMAGCJ<TMNode, HKBGLAIKAIG<KHCIOCBLCGC<TMInput>>> HAFILOEPIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal FNDGEEMAGCJ<TMNode, HKBGLAIKAIG<KHCIOCBLCGC<TMOutput>>> ENBFEHNLPKJ;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x37B2C90", Offset = "0x37B1E90", VA = "0x1837B2C90")]
	internal MCJPGMIADAK([In] PFCKHHIJLEE<TMNode> CNAHEPIILLF, [In] FNDGEEMAGCJ<TMNode, HKBGLAIKAIG<KHCIOCBLCGC<TMInput>>> BIFMLIGMEOK, [In] FNDGEEMAGCJ<TMNode, HKBGLAIKAIG<KHCIOCBLCGC<TMOutput>>> JDEIDENAEGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x37B2AE0", Offset = "0x37B1CE0", VA = "0x1837B2AE0")]
	internal static MCJPGMIADAK<TMInput, TMOutput, TMNode> DHBNKMCPKNO()
	{
		return default(MCJPGMIADAK<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class PABCNPILKLM
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2A0D4C0", Offset = "0x2A0C6C0", VA = "0x182A0D4C0")]
	internal static ODMGOLDLHDM JCBMCDNAHJB<TMInput, TMOutput, TMNode>([In] this MCJPGMIADAK<TMInput, TMOutput, TMNode> AOFIGDLFNLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2A0D920", Offset = "0x2A0CB20", VA = "0x182A0D920")]
	internal static MCJPGMIADAK<TMInput, TMOutput, TMNode> MAOCPLNNJJM<TMInput, TMOutput, TMNode>(this ODMGOLDLHDM AOFIGDLFNLH)
	{
		return default(MCJPGMIADAK<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2A0E0F0", Offset = "0x2A0D2F0", VA = "0x182A0E0F0")]
	private static IAOHIJDBOGH PGFBFFIGOOD<TMInput>([In] this HKBGLAIKAIG<KHCIOCBLCGC<TMInput>> AOFIGDLFNLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2A0CF50", Offset = "0x2A0C150", VA = "0x182A0CF50")]
	private static HKBGLAIKAIG<KHCIOCBLCGC<TMInput>> FFHOENHBALI<TMInput>(this IAOHIJDBOGH AOFIGDLFNLH)
	{
		return default(HKBGLAIKAIG<KHCIOCBLCGC<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2A0D2F0", Offset = "0x2A0C4F0", VA = "0x182A0D2F0")]
	private static HINMOHHANFD JBKFJKGLCEP<TMOutput>([In] this HKBGLAIKAIG<KHCIOCBLCGC<TMOutput>> AOFIGDLFNLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2A0DE80", Offset = "0x2A0D080", VA = "0x182A0DE80")]
	private static HKBGLAIKAIG<KHCIOCBLCGC<TMOutput>> OGLDPODEEFC<TMOutput>(this HINMOHHANFD AOFIGDLFNLH)
	{
		return default(HKBGLAIKAIG<KHCIOCBLCGC<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2A0CC00", Offset = "0x2A0BE00", VA = "0x182A0CC00")]
	internal static void CJPKHGMGMMP<TMInput, TMOutput, TMNode>(this MCJPGMIADAK<TMInput, TMOutput, TMNode> AOFIGDLFNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2A0D210", Offset = "0x2A0C410", VA = "0x182A0D210")]
	internal static KHCIOCBLCGC<TMNode> ILKJCDANLHA<TMNode, TMInput, TMOutput>(this MCJPGMIADAK<TMInput, TMOutput, TMNode> AOFIGDLFNLH, [In] HKBGLAIKAIG<KHCIOCBLCGC<TMInput>> BIFMLIGMEOK, [In] HKBGLAIKAIG<KHCIOCBLCGC<TMOutput>> JDEIDENAEGI)
	{
		return default(KHCIOCBLCGC<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2A0D860", Offset = "0x2A0CA60", VA = "0x182A0D860")]
	internal static void JKJINJEHPOI<TMInput, TMOutput, TMNode>(this MCJPGMIADAK<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMNode> POAELFIOKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x271E600", Offset = "0x271D800", VA = "0x18271E600")]
	public static bool BFJAEMLKAPK<TMInput, TMOutput, TMNode>([In] this MCJPGMIADAK<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMNode> POAELFIOKHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2724420", Offset = "0x2723620", VA = "0x182724420")]
	public static int NAJFOKPMGAH<TMInput, TMOutput, TMNode>([In] this MCJPGMIADAK<TMInput, TMOutput, TMNode> AOFIGDLFNLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2A0CBC0", Offset = "0x2A0BDC0", VA = "0x182A0CBC0")]
	public static int CEEKJOIIAGB<TMInput, TMOutput, TMNode>([In] this MCJPGMIADAK<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMNode> POAELFIOKHK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x28A2250", Offset = "0x28A1450", VA = "0x1828A2250")]
	public static int DLEOHCJAJHK<TMInput, TMOutput, TMNode>([In] this MCJPGMIADAK<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMNode> POAELFIOKHK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2A0D1C0", Offset = "0x2A0C3C0", VA = "0x182A0D1C0")]
	public static KHCIOCBLCGC<TMInput> FKPFJGLDOLA<TMInput, TMOutput, TMNode>([In] this MCJPGMIADAK<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMNode> POAELFIOKHK, int MBGANDEDPDN)
	{
		return default(KHCIOCBLCGC<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x28A2630", Offset = "0x28A1830", VA = "0x1828A2630")]
	public static KHCIOCBLCGC<TMOutput> GLLIEOELMGG<TMOutput, TMInput, TMNode>([In] this MCJPGMIADAK<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMNode> POAELFIOKHK, int MBGANDEDPDN)
	{
		return default(KHCIOCBLCGC<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2A0CEC0", Offset = "0x2A0C0C0", VA = "0x182A0CEC0")]
	internal static void GINNOKPOMBI<TMInput, TMOutput, TMNode>(this MCJPGMIADAK<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMNode> POAELFIOKHK, KHCIOCBLCGC<TMInput> HNCOCKJDHMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x28A2420", Offset = "0x28A1620", VA = "0x1828A2420")]
	internal static void MKMHNFOIMOG<TMInput, TMOutput, TMNode>(this MCJPGMIADAK<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMNode> POAELFIOKHK, KHCIOCBLCGC<TMOutput> BDBHJLOOAPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2A0CF00", Offset = "0x2A0C100", VA = "0x182A0CF00")]
	internal static void EOBGLOJCMNM<TMInput, TMOutput, TMNode>(this MCJPGMIADAK<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMNode> POAELFIOKHK, int MBGANDEDPDN, KHCIOCBLCGC<TMInput> HNCOCKJDHMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2A0D2A0", Offset = "0x2A0C4A0", VA = "0x182A0D2A0")]
	internal static void JBEGDPAFIOE<TMInput, TMOutput, TMNode>(this MCJPGMIADAK<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMNode> POAELFIOKHK, int MBGANDEDPDN, KHCIOCBLCGC<TMOutput> BDBHJLOOAPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2A0CEC0", Offset = "0x2A0C0C0", VA = "0x182A0CEC0")]
	internal static void EKBIOLLOKII<TMInput, TMOutput, TMNode>(this MCJPGMIADAK<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMNode> POAELFIOKHK, KHCIOCBLCGC<TMInput> HNCOCKJDHMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x28A2420", Offset = "0x28A1620", VA = "0x1828A2420")]
	internal static void DCMNBOKNKHB<TMInput, TMOutput, TMNode>(this MCJPGMIADAK<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMNode> POAELFIOKHK, KHCIOCBLCGC<TMOutput> BDBHJLOOAPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2A0DE20", Offset = "0x2A0D020", VA = "0x182A0DE20")]
	public static HKBGLAIKAIG<KHCIOCBLCGC<TMInput>>.COPJIAJAIMG OMFLIHIMBND<TMInput, TMOutput, TMNode>([In] this MCJPGMIADAK<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMNode> POAELFIOKHK)
	{
		return default(HKBGLAIKAIG<KHCIOCBLCGC<TMInput>>.COPJIAJAIMG);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x28A32C0", Offset = "0x28A24C0", VA = "0x1828A32C0")]
	public static HKBGLAIKAIG<KHCIOCBLCGC<TMOutput>>.COPJIAJAIMG IGKCECFAADE<TMOutput, TMInput, TMNode>([In] this MCJPGMIADAK<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMNode> POAELFIOKHK)
	{
		return default(HKBGLAIKAIG<KHCIOCBLCGC<TMOutput>>.COPJIAJAIMG);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2A0DE20", Offset = "0x2A0D020", VA = "0x182A0DE20")]
	public static NBMKDLCHCHO<KHCIOCBLCGC<TMInput>, HKBGLAIKAIG<KHCIOCBLCGC<TMInput>>.COPJIAJAIMG> OFFNAJFJIFC<TMInput, TMOutput, TMNode>([In] this MCJPGMIADAK<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMNode> POAELFIOKHK)
	{
		return default(NBMKDLCHCHO<KHCIOCBLCGC<TMInput>, HKBGLAIKAIG<KHCIOCBLCGC<TMInput>>.COPJIAJAIMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x28A32C0", Offset = "0x28A24C0", VA = "0x1828A32C0")]
	public static NBMKDLCHCHO<KHCIOCBLCGC<TMOutput>, HKBGLAIKAIG<KHCIOCBLCGC<TMOutput>>.COPJIAJAIMG> HNNLLNMDADO<TMOutput, TMInput, TMNode>([In] this MCJPGMIADAK<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMNode> POAELFIOKHK)
	{
		return default(NBMKDLCHCHO<KHCIOCBLCGC<TMOutput>, HKBGLAIKAIG<KHCIOCBLCGC<TMOutput>>.COPJIAJAIMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2879950", Offset = "0x2878B50", VA = "0x182879950")]
	public static FKOGJKIBHGK<KHCIOCBLCGC<TMNode>, PFCKHHIJLEE<TMNode>.IGFPELDHGHB> BGLPBHHGBFD<TMNode, TMInput, TMOutput>([In] this MCJPGMIADAK<TMInput, TMOutput, TMNode> AOFIGDLFNLH)
	{
		return default(FKOGJKIBHGK<KHCIOCBLCGC<TMNode>, PFCKHHIJLEE<TMNode>.IGFPELDHGHB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct DIENMNKCHHC<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal PFCKHHIJLEE<TMOutput> IIFBKKCFLID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal FNDGEEMAGCJ<TMOutput, KHCIOCBLCGC<TMNode>> CLBLHDPGBJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal FNDGEEMAGCJ<TMOutput, HKBGLAIKAIG<KHCIOCBLCGC<TMInput>>> HAFILOEPIHD;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x37B2C90", Offset = "0x37B1E90", VA = "0x1837B2C90")]
	internal DIENMNKCHHC([In] PFCKHHIJLEE<TMOutput> CNAHEPIILLF, [In] FNDGEEMAGCJ<TMOutput, KHCIOCBLCGC<TMNode>> MCMNPMKHJJL, [In] FNDGEEMAGCJ<TMOutput, HKBGLAIKAIG<KHCIOCBLCGC<TMInput>>> BIFMLIGMEOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x37B2AE0", Offset = "0x37B1CE0", VA = "0x1837B2AE0")]
	internal static DIENMNKCHHC<TMInput, TMOutput, TMNode> DHBNKMCPKNO()
	{
		return default(DIENMNKCHHC<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class GOKJCBDKGAD
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x28A2990", Offset = "0x28A1B90", VA = "0x1828A2990")]
	internal static GJBHBAPINJP JCBMCDNAHJB<TMInput, TMOutput, TMNode>([In] this DIENMNKCHHC<TMInput, TMOutput, TMNode> AOFIGDLFNLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x28A2DC0", Offset = "0x28A1FC0", VA = "0x1828A2DC0")]
	internal static DIENMNKCHHC<TMInput, TMOutput, TMNode> MAOCPLNNJJM<TMInput, TMOutput, TMNode>(this GJBHBAPINJP AOFIGDLFNLH)
	{
		return default(DIENMNKCHHC<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x28A2460", Offset = "0x28A1660", VA = "0x1828A2460")]
	private static PHPCHCJIHKP FEMMAFILPBD<TMInput>([In] this HKBGLAIKAIG<KHCIOCBLCGC<TMInput>> AOFIGDLFNLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x28A2680", Offset = "0x28A1880", VA = "0x1828A2680")]
	private static HKBGLAIKAIG<KHCIOCBLCGC<TMInput>> GFNNDMHGLCB<TMInput>(this PHPCHCJIHKP AOFIGDLFNLH)
	{
		return default(HKBGLAIKAIG<KHCIOCBLCGC<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x28A2290", Offset = "0x28A1490", VA = "0x1828A2290")]
	internal static void CJPKHGMGMMP<TMInput, TMOutput, TMNode>(this DIENMNKCHHC<TMInput, TMOutput, TMNode> AOFIGDLFNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x28A28F0", Offset = "0x28A1AF0", VA = "0x1828A28F0")]
	internal static KHCIOCBLCGC<TMOutput> ILKJCDANLHA<TMOutput, TMInput, TMNode>(this DIENMNKCHHC<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMNode> JCCACJKHFKB)
	{
		return default(KHCIOCBLCGC<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x28A2D10", Offset = "0x28A1F10", VA = "0x1828A2D10")]
	internal static void JKJINJEHPOI<TMInput, TMOutput, TMNode>(this DIENMNKCHHC<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMOutput> POAELFIOKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x271E600", Offset = "0x271D800", VA = "0x18271E600")]
	public static bool BFJAEMLKAPK<TMInput, TMOutput, TMNode>([In] this DIENMNKCHHC<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMOutput> POAELFIOKHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2724420", Offset = "0x2723620", VA = "0x182724420")]
	public static int NAJFOKPMGAH<TMInput, TMOutput, TMNode>([In] this DIENMNKCHHC<TMInput, TMOutput, TMNode> AOFIGDLFNLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x28A2DA0", Offset = "0x28A1FA0", VA = "0x1828A2DA0")]
	public static KHCIOCBLCGC<TMNode> KLPNOBJHHHE<TMNode, TMInput, TMOutput>([In] this DIENMNKCHHC<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMOutput> POAELFIOKHK)
	{
		return default(KHCIOCBLCGC<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x28A2250", Offset = "0x28A1450", VA = "0x1828A2250")]
	public static int CEEKJOIIAGB<TMInput, TMOutput, TMNode>([In] this DIENMNKCHHC<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMOutput> POAELFIOKHK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x28A2630", Offset = "0x28A1830", VA = "0x1828A2630")]
	public static KHCIOCBLCGC<TMInput> FKPFJGLDOLA<TMInput, TMOutput, TMNode>([In] this DIENMNKCHHC<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMOutput> POAELFIOKHK, int MBGANDEDPDN)
	{
		return default(KHCIOCBLCGC<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x28A2420", Offset = "0x28A1620", VA = "0x1828A2420")]
	internal static void GINNOKPOMBI<TMInput, TMOutput, TMNode>(this DIENMNKCHHC<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMOutput> POAELFIOKHK, KHCIOCBLCGC<TMInput> HNCOCKJDHMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x28A2420", Offset = "0x28A1620", VA = "0x1828A2420")]
	internal static void EKBIOLLOKII<TMInput, TMOutput, TMNode>(this DIENMNKCHHC<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMOutput> POAELFIOKHK, KHCIOCBLCGC<TMInput> HNCOCKJDHMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x28A32C0", Offset = "0x28A24C0", VA = "0x1828A32C0")]
	public static HKBGLAIKAIG<KHCIOCBLCGC<TMInput>>.COPJIAJAIMG OMFLIHIMBND<TMInput, TMOutput, TMNode>([In] this DIENMNKCHHC<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMOutput> POAELFIOKHK)
	{
		return default(HKBGLAIKAIG<KHCIOCBLCGC<TMInput>>.COPJIAJAIMG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x28A32C0", Offset = "0x28A24C0", VA = "0x1828A32C0")]
	public static NBMKDLCHCHO<KHCIOCBLCGC<TMInput>, HKBGLAIKAIG<KHCIOCBLCGC<TMInput>>.COPJIAJAIMG> OFFNAJFJIFC<TMInput, TMOutput, TMNode>([In] this DIENMNKCHHC<TMInput, TMOutput, TMNode> AOFIGDLFNLH, KHCIOCBLCGC<TMOutput> POAELFIOKHK)
	{
		return default(NBMKDLCHCHO<KHCIOCBLCGC<TMInput>, HKBGLAIKAIG<KHCIOCBLCGC<TMInput>>.COPJIAJAIMG>);
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
