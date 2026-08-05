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
		[Cpp2IlInjected.Address(RVA = "0x79C400", Offset = "0x79AC00", VA = "0x18079C400")]
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
		[Cpp2IlInjected.Address(RVA = "0x1CCFB30", Offset = "0x1CCE330", VA = "0x181CCFB30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79CCC0", Offset = "0x79B4C0", VA = "0x18079CCC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x79CD00", Offset = "0x79B500", VA = "0x18079CD00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct FPHHOMBLMCH<TMInput, TMOutput, TMNode> : IEnumerator<BIAFJNPKHBL<TMNode>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private JDGABNGDBHG<TMInput, TMOutput, TMNode> EAGAAMGDHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private ONDPDNHMMGI<TMInput, TMOutput, TMNode> OKKAIPMNHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private bool GPOILBEKJBO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly BIAFJNPKHBL<TMNode> POHDIFHCONG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x348B950", Offset = "0x348A150", VA = "0x18348B950", Slot = "4")]
		get
		{
			return default(BIAFJNPKHBL<TMNode>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x348B7F0", Offset = "0x3489FF0", VA = "0x18348B7F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x348B880", Offset = "0x348A080", VA = "0x18348B880")]
	internal FPHHOMBLMCH([In] JDGABNGDBHG<TMInput, TMOutput, TMNode> HJCBAKOCCGN, [In] ONDPDNHMMGI<TMInput, TMOutput, TMNode> BCMHPOILEGO, bool OKIMBHPOMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x348B6B0", Offset = "0x3489EB0", VA = "0x18348B6B0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x348B770", Offset = "0x3489F70", VA = "0x18348B770", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x348B630", Offset = "0x3489E30", VA = "0x18348B630", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class LFLMHBKPDOM
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2568A20", Offset = "0x2567220", VA = "0x182568A20")]
	public static FPHHOMBLMCH<TMInput, TMOutput, TMNode> AKKFLOCCMNP<TMInput, TMOutput, TMNode>([In] BPDEBBGALOB<TMInput, TMOutput, TMNode> HOCJLFKJLHH, BIAFJNPKHBL<TMNode> IEJCDLJALPH)
	{
		return default(FPHHOMBLMCH<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct ONDPDNHMMGI<TMInput, TMOutput, TMNode> : IEnumerator<BIAFJNPKHBL<TMInput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private OJBLBICDDLK<BIAFJNPKHBL<TMOutput>>.JEGAOCIPMMJ KLINPAMKEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private OJBLBICDDLK<BIAFJNPKHBL<TMInput>>.JEGAOCIPMMJ AAMJBGGPAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly GOBMCNJLOFJ<TMInput, TMOutput, TMNode> POFLJBOPFBC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public BIAFJNPKHBL<TMInput> POHDIFHCONG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3E3F250", Offset = "0x3E3DA50", VA = "0x183E3F250", Slot = "4")]
		get
		{
			return default(BIAFJNPKHBL<TMInput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3E3F1A0", Offset = "0x3E3D9A0", VA = "0x183E3F1A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3885B70", Offset = "0x3884370", VA = "0x183885B70")]
	internal ONDPDNHMMGI([In] OJBLBICDDLK<BIAFJNPKHBL<TMOutput>>.JEGAOCIPMMJ NLONNPKIPEN, [In] OJBLBICDDLK<BIAFJNPKHBL<TMInput>>.JEGAOCIPMMJ FLGBNDODELH, [In] GOBMCNJLOFJ<TMInput, TMOutput, TMNode> NNIENAGCMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3E3EFD0", Offset = "0x3E3D7D0", VA = "0x183E3EFD0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3E3F130", Offset = "0x3E3D930", VA = "0x183E3F130", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3E3EF60", Offset = "0x3E3D760", VA = "0x183E3EF60", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class HIFDMPGGLKN
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x24EDD40", Offset = "0x24EC540", VA = "0x1824EDD40")]
	public static ONDPDNHMMGI<TMInput, TMOutput, TMNode> AKKFLOCCMNP<TMInput, TMOutput, TMNode>([In] BPDEBBGALOB<TMInput, TMOutput, TMNode> HOCJLFKJLHH, BIAFJNPKHBL<TMNode> IEJCDLJALPH)
	{
		return default(ONDPDNHMMGI<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct JDGABNGDBHG<TMInput, TMOutput, TMNode> : IEnumerator<BIAFJNPKHBL<TMOutput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private OJBLBICDDLK<BIAFJNPKHBL<TMInput>>.JEGAOCIPMMJ KDDIMMEDEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private OJBLBICDDLK<BIAFJNPKHBL<TMOutput>>.JEGAOCIPMMJ AODDMCGMKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly LHIOHABNIOI<TMInput, TMOutput, TMNode> MCJDAFAMOCE;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public BIAFJNPKHBL<TMOutput> POHDIFHCONG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3885BF0", Offset = "0x38843F0", VA = "0x183885BF0", Slot = "4")]
		get
		{
			return default(BIAFJNPKHBL<TMOutput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3885AA0", Offset = "0x38842A0", VA = "0x183885AA0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3885B70", Offset = "0x3884370", VA = "0x183885B70")]
	internal JDGABNGDBHG([In] OJBLBICDDLK<BIAFJNPKHBL<TMInput>>.JEGAOCIPMMJ JMHOLFPOJHA, [In] OJBLBICDDLK<BIAFJNPKHBL<TMOutput>>.JEGAOCIPMMJ LINGALJIBJL, [In] LHIOHABNIOI<TMInput, TMOutput, TMNode> AENKLOGIEEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3885810", Offset = "0x3884010", VA = "0x183885810", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x38859F0", Offset = "0x38841F0", VA = "0x1838859F0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3885760", Offset = "0x3883F60", VA = "0x183885760", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class CLAJMKIGHHP
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x232F940", Offset = "0x232E140", VA = "0x18232F940")]
	public static JDGABNGDBHG<TMInput, TMOutput, TMNode> AKKFLOCCMNP<TMInput, TMOutput, TMNode>([In] BPDEBBGALOB<TMInput, TMOutput, TMNode> HOCJLFKJLHH, BIAFJNPKHBL<TMNode> IEJCDLJALPH)
	{
		return default(JDGABNGDBHG<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct BPDEBBGALOB<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public LHIOHABNIOI<TMInput, TMOutput, TMNode> LLBJOEAOKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public GOBMCNJLOFJ<TMInput, TMOutput, TMNode> MIMHCILGKIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public DHLIOKBPFDF<TMInput, TMOutput, TMNode> IEHEMLHKAKA;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4607840", Offset = "0x4606040", VA = "0x184607840")]
	internal BPDEBBGALOB([In] LHIOHABNIOI<TMInput, TMOutput, TMNode> AENKLOGIEEL, [In] GOBMCNJLOFJ<TMInput, TMOutput, TMNode> NNIENAGCMCA, [In] DHLIOKBPFDF<TMInput, TMOutput, TMNode> ALECNGGHJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4607590", Offset = "0x4605D90", VA = "0x184607590")]
	public static BPDEBBGALOB<TMInput?, TMOutput?, TMNode?> AKKFLOCCMNP()
	{
		return default(BPDEBBGALOB<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class EODJGLBAAPA
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x23BC150", Offset = "0x23BA950", VA = "0x1823BC150")]
	public static AGEEKGMHNLL? JMOOMJHDBEG<TMInput, TMOutput, TMNode>([In] this BPDEBBGALOB<TMInput, TMOutput, TMNode> PIEBBHMNEOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x23BB4C0", Offset = "0x23B9CC0", VA = "0x1823BB4C0")]
	public static BPDEBBGALOB<TMInput?, TMOutput?, TMNode?> AEDPLFCAHJC<TMInput, TMOutput, TMNode>(this AGEEKGMHNLL PIEBBHMNEOG)
	{
		return default(BPDEBBGALOB<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x23BC500", Offset = "0x23BAD00", VA = "0x1823BC500")]
	public static void PIODDHMICMM<TMInput, TMOutput, TMNode>(this BPDEBBGALOB<TMInput, TMOutput, TMNode> PIEBBHMNEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x23BC0F0", Offset = "0x23BA8F0", VA = "0x1823BC0F0")]
	public static void IOFNEOPBINN<TMInput, TMOutput, TMNode>(this BPDEBBGALOB<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMOutput> BCNGFOHBCGB, BIAFJNPKHBL<TMInput> CNHJILOMFME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x23BBE10", Offset = "0x23BA610", VA = "0x1823BBE10")]
	public static void GAPLBMBIKDK<TMInput, TMOutput, TMNode>(this BPDEBBGALOB<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMOutput> BCNGFOHBCGB, BIAFJNPKHBL<TMInput> CNHJILOMFME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x23BB830", Offset = "0x23BA030", VA = "0x1823BB830")]
	public static bool AGAIAJKJLFD<TMInput, TMOutput, TMNode>([In] this BPDEBBGALOB<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMOutput> BCNGFOHBCGB, BIAFJNPKHBL<TMInput> CNHJILOMFME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x23BBD80", Offset = "0x23BA580", VA = "0x1823BBD80")]
	public static BIAFJNPKHBL<TMNode?> FDDBCIEPGDJ<TMNode, TMInput, TMOutput>(this BPDEBBGALOB<TMInput, TMOutput, TMNode> PIEBBHMNEOG)
	{
		return default(BIAFJNPKHBL<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x23BBF50", Offset = "0x23BA750", VA = "0x1823BBF50")]
	public static void IDEFBFDHLIP<TMInput, TMOutput, TMNode>(this BPDEBBGALOB<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMNode> IEJCDLJALPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x23BC420", Offset = "0x23BAC20", VA = "0x1823BC420")]
	public static BIAFJNPKHBL<TMInput?> OHBJOKONDLC<TMInput, TMOutput, TMNode>(this BPDEBBGALOB<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMNode> IEJCDLJALPH)
	{
		return default(BIAFJNPKHBL<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x23BC490", Offset = "0x23BAC90", VA = "0x1823BC490")]
	public static BIAFJNPKHBL<TMOutput?> OOGFEAEBFLG<TMOutput, TMInput, TMNode>(this BPDEBBGALOB<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMNode> IEJCDLJALPH)
	{
		return default(BIAFJNPKHBL<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x23BC070", Offset = "0x23BA870", VA = "0x1823BC070")]
	public static BIAFJNPKHBL<TMInput?> ILFMOOFMFMM<TMInput, TMOutput, TMNode>(this BPDEBBGALOB<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMNode> IEJCDLJALPH, int EAHCFBMNNCF)
	{
		return default(BIAFJNPKHBL<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x23BB970", Offset = "0x23BA170", VA = "0x1823BB970")]
	public static BIAFJNPKHBL<TMOutput?> CDDDBOAGIFE<TMOutput, TMInput, TMNode>(this BPDEBBGALOB<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMNode> IEJCDLJALPH, int EAHCFBMNNCF)
	{
		return default(BIAFJNPKHBL<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x23BC380", Offset = "0x23BAB80", VA = "0x1823BC380")]
	public static void OBAOIBCAELF<TMInput, TMOutput, TMNode>(this BPDEBBGALOB<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMNode> IEJCDLJALPH, int KKDDEDLDHFK, int KFCNBPOGDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x23BC2E0", Offset = "0x23BAAE0", VA = "0x1823BC2E0")]
	public static void NIDBOPMKKDF<TMInput, TMOutput, TMNode>(this BPDEBBGALOB<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMNode> IEJCDLJALPH, int KKDDEDLDHFK, int KFCNBPOGDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x23BBB00", Offset = "0x23BA300", VA = "0x1823BBB00")]
	public static void CPGFJIGBHFH<TMInput, TMOutput, TMNode>(this BPDEBBGALOB<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMInput> LPCJAHLDKAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x23BBE70", Offset = "0x23BA670", VA = "0x1823BBE70")]
	public static void GLNBHMKMAIP<TMInput, TMOutput, TMNode>(this BPDEBBGALOB<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMOutput> GAABFGHHDHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x84A8F0", Offset = "0x8490F0", VA = "0x18084A8F0")]
	public static KKHCNNBPMJB<TMInput?> EDEGIDFBIOE<TMInput, TMOutput, TMNode>([In] this BPDEBBGALOB<TMInput, TMOutput, TMNode> PIEBBHMNEOG)
	{
		return default(KKHCNNBPMJB<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x23BC060", Offset = "0x23BA860", VA = "0x1823BC060")]
	public static KKHCNNBPMJB<TMOutput?> IJPMHKPCMPG<TMOutput, TMInput, TMNode>([In] this BPDEBBGALOB<TMInput, TMOutput, TMNode> PIEBBHMNEOG)
	{
		return default(KKHCNNBPMJB<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x23BC560", Offset = "0x23BAD60", VA = "0x1823BC560")]
	public static KKHCNNBPMJB<TMNode?> PPNLKHOAODC<TMNode, TMInput, TMOutput>([In] this BPDEBBGALOB<TMInput, TMOutput, TMNode> PIEBBHMNEOG)
	{
		return default(KKHCNNBPMJB<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x23BB900", Offset = "0x23BA100", VA = "0x1823BB900")]
	public static ONDPDNHMMGI<TMInput?, TMOutput?, TMNode?> BMOPHABAPID<TMInput, TMOutput, TMNode>([In] this BPDEBBGALOB<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMNode> MBMFHFDDILC)
	{
		return default(ONDPDNHMMGI<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x23BB900", Offset = "0x23BA100", VA = "0x1823BB900")]
	public static JDGABNGDBHG<TMInput?, TMOutput?, TMNode?> OALMKEJMFKP<TMInput, TMOutput, TMNode>([In] this BPDEBBGALOB<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMNode> MBMFHFDDILC)
	{
		return default(JDGABNGDBHG<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x23BC230", Offset = "0x23BAA30", VA = "0x1823BC230")]
	public static FPHHOMBLMCH<TMInput?, TMOutput?, TMNode?> KLNPJDCDMDN<TMInput, TMOutput, TMNode>([In] this BPDEBBGALOB<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMNode> MBMFHFDDILC)
	{
		return default(FPHHOMBLMCH<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x23BB9F0", Offset = "0x23BA1F0", VA = "0x1823BB9F0")]
	public static LAAJNBMKMHO<BIAFJNPKHBL<TMInput?>, ONDPDNHMMGI<TMInput?, TMOutput?, TMNode?>> CNMIJFMCOGK<TMInput, TMOutput, TMNode>([In] this BPDEBBGALOB<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMNode> MBMFHFDDILC)
	{
		return default(LAAJNBMKMHO<BIAFJNPKHBL<TMInput>, ONDPDNHMMGI<TMInput, TMOutput, TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x23BBBF0", Offset = "0x23BA3F0", VA = "0x1823BBBF0")]
	public static LAAJNBMKMHO<BIAFJNPKHBL<TMNode?>, FPHHOMBLMCH<TMInput?, TMOutput?, TMNode?>> EKJDONPDBKK<TMNode, TMInput, TMOutput>([In] this BPDEBBGALOB<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMNode> MBMFHFDDILC)
	{
		return default(LAAJNBMKMHO<BIAFJNPKHBL<TMNode>, FPHHOMBLMCH<TMInput, TMOutput, TMNode>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct LHIOHABNIOI<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal KKHCNNBPMJB<TMInput> IAKPEPGAHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal DHDAPGCBMBJ<TMInput, BIAFJNPKHBL<TMNode>> MGANCBBNKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal DHDAPGCBMBJ<TMInput, OJBLBICDDLK<BIAFJNPKHBL<TMOutput>>> POFLJBOPFBC;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3534530", Offset = "0x3532D30", VA = "0x183534530")]
	internal LHIOHABNIOI([In] KKHCNNBPMJB<TMInput> NELKNKCIMIB, [In] DHDAPGCBMBJ<TMInput, BIAFJNPKHBL<TMNode>> ALECNGGHJAI, [In] DHDAPGCBMBJ<TMInput, OJBLBICDDLK<BIAFJNPKHBL<TMOutput>>> NNIENAGCMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3534370", Offset = "0x3532B70", VA = "0x183534370")]
	internal static LHIOHABNIOI<TMInput, TMOutput, TMNode> AKKFLOCCMNP()
	{
		return default(LHIOHABNIOI<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class BEJIOILDBPG
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x22C9010", Offset = "0x22C7810", VA = "0x1822C9010")]
	internal static BMNINDFMLKE JMOOMJHDBEG<TMInput, TMOutput, TMNode>([In] this LHIOHABNIOI<TMInput, TMOutput, TMNode> PIEBBHMNEOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x22C8480", Offset = "0x22C6C80", VA = "0x1822C8480")]
	internal static LHIOHABNIOI<TMInput, TMOutput, TMNode> AEDPLFCAHJC<TMInput, TMOutput, TMNode>(this BMNINDFMLKE PIEBBHMNEOG)
	{
		return default(LHIOHABNIOI<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x22C8E40", Offset = "0x22C7640", VA = "0x1822C8E40")]
	private static JAMIIENPOJA FLOEGKJFMLN<TMOutput>([In] this OJBLBICDDLK<BIAFJNPKHBL<TMOutput>> PIEBBHMNEOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x22C8A30", Offset = "0x22C7230", VA = "0x1822C8A30")]
	private static OJBLBICDDLK<BIAFJNPKHBL<TMOutput>> AOPPLAHGAKF<TMOutput>(this JAMIIENPOJA PIEBBHMNEOG)
	{
		return default(OJBLBICDDLK<BIAFJNPKHBL<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x22C9410", Offset = "0x22C7C10", VA = "0x1822C9410")]
	internal static void PIODDHMICMM<TMInput, TMOutput, TMNode>(this LHIOHABNIOI<TMInput, TMOutput, TMNode> PIEBBHMNEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x22C8CB0", Offset = "0x22C74B0", VA = "0x1822C8CB0")]
	internal static BIAFJNPKHBL<TMInput> CJBBHKJKFDA<TMInput, TMOutput, TMNode>(this LHIOHABNIOI<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMNode> ELOONLEOBIM)
	{
		return default(BIAFJNPKHBL<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x22C8D90", Offset = "0x22C7590", VA = "0x1822C8D90")]
	internal static void DABJCHJIOBI<TMInput, TMOutput, TMNode>(this LHIOHABNIOI<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMInput> MBMFHFDDILC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x22C93F0", Offset = "0x22C7BF0", VA = "0x1822C93F0")]
	public static bool ODPBAOJILCN<TMInput, TMOutput, TMNode>([In] this LHIOHABNIOI<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMInput> MBMFHFDDILC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x22C8E20", Offset = "0x22C7620", VA = "0x1822C8E20")]
	public static BIAFJNPKHBL<TMNode> EGJPHCLJMEN<TMNode, TMInput, TMOutput>([In] this LHIOHABNIOI<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMInput> MBMFHFDDILC)
	{
		return default(BIAFJNPKHBL<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x22C8D50", Offset = "0x22C7550", VA = "0x1822C8D50")]
	public static int CJGECEIIFBA<TMInput, TMOutput, TMNode>([In] this LHIOHABNIOI<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMInput> MBMFHFDDILC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x22C93A0", Offset = "0x22C7BA0", VA = "0x1822C93A0")]
	public static BIAFJNPKHBL<TMOutput> NIPHAODDBFA<TMOutput, TMInput, TMNode>([In] this LHIOHABNIOI<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMInput> MBMFHFDDILC, int EAHCFBMNNCF)
	{
		return default(BIAFJNPKHBL<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x22C8990", Offset = "0x22C7190", VA = "0x1822C8990")]
	internal static void APLALDEPMPC<TMInput, TMOutput, TMNode>(this LHIOHABNIOI<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMInput> MBMFHFDDILC, BIAFJNPKHBL<TMOutput> GAABFGHHDHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x22C8990", Offset = "0x22C7190", VA = "0x1822C8990")]
	internal static void AJEOEKAJHCH<TMInput, TMOutput, TMNode>(this LHIOHABNIOI<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMInput> MBMFHFDDILC, BIAFJNPKHBL<TMOutput> GAABFGHHDHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x22C89D0", Offset = "0x22C71D0", VA = "0x1822C89D0")]
	public static OJBLBICDDLK<BIAFJNPKHBL<TMOutput>>.JEGAOCIPMMJ AKAAHEOMBPA<TMOutput, TMInput, TMNode>([In] this LHIOHABNIOI<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMInput> MBMFHFDDILC)
	{
		return default(OJBLBICDDLK<BIAFJNPKHBL<TMOutput>>.JEGAOCIPMMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x22C89D0", Offset = "0x22C71D0", VA = "0x1822C89D0")]
	public static FHBBDJEOIFM<BIAFJNPKHBL<TMOutput>, OJBLBICDDLK<BIAFJNPKHBL<TMOutput>>.JEGAOCIPMMJ> DELJFHGFGEN<TMOutput, TMInput, TMNode>([In] this LHIOHABNIOI<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMInput> MBMFHFDDILC)
	{
		return default(FHBBDJEOIFM<BIAFJNPKHBL<TMOutput>, OJBLBICDDLK<BIAFJNPKHBL<TMOutput>>.JEGAOCIPMMJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct DHLIOKBPFDF<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal KKHCNNBPMJB<TMNode> IAKPEPGAHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal DHDAPGCBMBJ<TMNode, OJBLBICDDLK<BIAFJNPKHBL<TMInput>>> MCJDAFAMOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal DHDAPGCBMBJ<TMNode, OJBLBICDDLK<BIAFJNPKHBL<TMOutput>>> POFLJBOPFBC;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3534530", Offset = "0x3532D30", VA = "0x183534530")]
	internal DHLIOKBPFDF([In] KKHCNNBPMJB<TMNode> NELKNKCIMIB, [In] DHDAPGCBMBJ<TMNode, OJBLBICDDLK<BIAFJNPKHBL<TMInput>>> AENKLOGIEEL, [In] DHDAPGCBMBJ<TMNode, OJBLBICDDLK<BIAFJNPKHBL<TMOutput>>> NNIENAGCMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3534370", Offset = "0x3532B70", VA = "0x183534370")]
	internal static DHLIOKBPFDF<TMInput, TMOutput, TMNode> AKKFLOCCMNP()
	{
		return default(DHLIOKBPFDF<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class ICLPGODAEKP
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2500E00", Offset = "0x24FF600", VA = "0x182500E00")]
	internal static BKMGGBMFIEB JMOOMJHDBEG<TMInput, TMOutput, TMNode>([In] this DHLIOKBPFDF<TMInput, TMOutput, TMNode> PIEBBHMNEOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x25001B0", Offset = "0x24FE9B0", VA = "0x1825001B0")]
	internal static DHLIOKBPFDF<TMInput, TMOutput, TMNode> AEDPLFCAHJC<TMInput, TMOutput, TMNode>(this BKMGGBMFIEB PIEBBHMNEOG)
	{
		return default(DHLIOKBPFDF<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x25012A0", Offset = "0x24FFAA0", VA = "0x1825012A0")]
	private static JCDEDPGHBBM PDFGFHGPFKE<TMInput>([In] this OJBLBICDDLK<BIAFJNPKHBL<TMInput>> PIEBBHMNEOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2500B80", Offset = "0x24FF380", VA = "0x182500B80")]
	private static OJBLBICDDLK<BIAFJNPKHBL<TMInput>> GJGMEAHHJDH<TMInput>(this JCDEDPGHBBM PIEBBHMNEOG)
	{
		return default(OJBLBICDDLK<BIAFJNPKHBL<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x24FFFE0", Offset = "0x24FE7E0", VA = "0x1824FFFE0")]
	private static LHALCMGKGBP AEDGOCJHIHA<TMOutput>([In] this OJBLBICDDLK<BIAFJNPKHBL<TMOutput>> PIEBBHMNEOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2500850", Offset = "0x24FF050", VA = "0x182500850")]
	private static OJBLBICDDLK<BIAFJNPKHBL<TMOutput>> DCDAAOOBDAP<TMOutput>(this LHALCMGKGBP PIEBBHMNEOG)
	{
		return default(OJBLBICDDLK<BIAFJNPKHBL<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2501470", Offset = "0x24FFC70", VA = "0x182501470")]
	internal static void PIODDHMICMM<TMInput, TMOutput, TMNode>(this DHLIOKBPFDF<TMInput, TMOutput, TMNode> PIEBBHMNEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2500700", Offset = "0x24FEF00", VA = "0x182500700")]
	internal static BIAFJNPKHBL<TMNode> CJBBHKJKFDA<TMNode, TMInput, TMOutput>(this DHLIOKBPFDF<TMInput, TMOutput, TMNode> PIEBBHMNEOG, [In] OJBLBICDDLK<BIAFJNPKHBL<TMInput>> AENKLOGIEEL, [In] OJBLBICDDLK<BIAFJNPKHBL<TMOutput>> NNIENAGCMCA)
	{
		return default(BIAFJNPKHBL<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2500790", Offset = "0x24FEF90", VA = "0x182500790")]
	internal static void DABJCHJIOBI<TMInput, TMOutput, TMNode>(this DHLIOKBPFDF<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMNode> MBMFHFDDILC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x22C93F0", Offset = "0x22C7BF0", VA = "0x1822C93F0")]
	public static bool ODPBAOJILCN<TMInput, TMOutput, TMNode>([In] this DHLIOKBPFDF<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMNode> MBMFHFDDILC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2501260", Offset = "0x24FFA60", VA = "0x182501260")]
	public static int OELEIKEFLOI<TMInput, TMOutput, TMNode>([In] this DHLIOKBPFDF<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMNode> MBMFHFDDILC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x22C8D50", Offset = "0x22C7550", VA = "0x1822C8D50")]
	public static int CJGECEIIFBA<TMInput, TMOutput, TMNode>([In] this DHLIOKBPFDF<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMNode> MBMFHFDDILC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2500B30", Offset = "0x24FF330", VA = "0x182500B30")]
	public static BIAFJNPKHBL<TMInput> FLFDJADALLO<TMInput, TMOutput, TMNode>([In] this DHLIOKBPFDF<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMNode> MBMFHFDDILC, int EAHCFBMNNCF)
	{
		return default(BIAFJNPKHBL<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x22C93A0", Offset = "0x22C7BA0", VA = "0x1822C93A0")]
	public static BIAFJNPKHBL<TMOutput> NIPHAODDBFA<TMOutput, TMInput, TMNode>([In] this DHLIOKBPFDF<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMNode> MBMFHFDDILC, int EAHCFBMNNCF)
	{
		return default(BIAFJNPKHBL<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x25006C0", Offset = "0x24FEEC0", VA = "0x1825006C0")]
	internal static void AKPLLALFIJB<TMInput, TMOutput, TMNode>(this DHLIOKBPFDF<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMNode> MBMFHFDDILC, BIAFJNPKHBL<TMInput> LPCJAHLDKAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x22C8990", Offset = "0x22C7190", VA = "0x1822C8990")]
	internal static void APLALDEPMPC<TMInput, TMOutput, TMNode>(this DHLIOKBPFDF<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMNode> MBMFHFDDILC, BIAFJNPKHBL<TMOutput> GAABFGHHDHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2501210", Offset = "0x24FFA10", VA = "0x182501210")]
	internal static void NAHMCMKLFKP<TMInput, TMOutput, TMNode>(this DHLIOKBPFDF<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMNode> MBMFHFDDILC, int EAHCFBMNNCF, BIAFJNPKHBL<TMInput> LPCJAHLDKAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x25011C0", Offset = "0x24FF9C0", VA = "0x1825011C0")]
	internal static void LBOJMDLJBPG<TMInput, TMOutput, TMNode>(this DHLIOKBPFDF<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMNode> MBMFHFDDILC, int EAHCFBMNNCF, BIAFJNPKHBL<TMOutput> GAABFGHHDHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x25006C0", Offset = "0x24FEEC0", VA = "0x1825006C0")]
	internal static void KHGMJAAKEPO<TMInput, TMOutput, TMNode>(this DHLIOKBPFDF<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMNode> MBMFHFDDILC, BIAFJNPKHBL<TMInput> LPCJAHLDKAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x22C8990", Offset = "0x22C7190", VA = "0x1822C8990")]
	internal static void AJEOEKAJHCH<TMInput, TMOutput, TMNode>(this DHLIOKBPFDF<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMNode> MBMFHFDDILC, BIAFJNPKHBL<TMOutput> GAABFGHHDHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2500AD0", Offset = "0x24FF2D0", VA = "0x182500AD0")]
	public static OJBLBICDDLK<BIAFJNPKHBL<TMInput>>.JEGAOCIPMMJ MNCOBFINJBI<TMInput, TMOutput, TMNode>([In] this DHLIOKBPFDF<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMNode> MBMFHFDDILC)
	{
		return default(OJBLBICDDLK<BIAFJNPKHBL<TMInput>>.JEGAOCIPMMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x22C89D0", Offset = "0x22C71D0", VA = "0x1822C89D0")]
	public static OJBLBICDDLK<BIAFJNPKHBL<TMOutput>>.JEGAOCIPMMJ AKAAHEOMBPA<TMOutput, TMInput, TMNode>([In] this DHLIOKBPFDF<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMNode> MBMFHFDDILC)
	{
		return default(OJBLBICDDLK<BIAFJNPKHBL<TMOutput>>.JEGAOCIPMMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2500AD0", Offset = "0x24FF2D0", VA = "0x182500AD0")]
	public static FHBBDJEOIFM<BIAFJNPKHBL<TMInput>, OJBLBICDDLK<BIAFJNPKHBL<TMInput>>.JEGAOCIPMMJ> EKGBOOKJFMD<TMInput, TMOutput, TMNode>([In] this DHLIOKBPFDF<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMNode> MBMFHFDDILC)
	{
		return default(FHBBDJEOIFM<BIAFJNPKHBL<TMInput>, OJBLBICDDLK<BIAFJNPKHBL<TMInput>>.JEGAOCIPMMJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x22C89D0", Offset = "0x22C71D0", VA = "0x1822C89D0")]
	public static FHBBDJEOIFM<BIAFJNPKHBL<TMOutput>, OJBLBICDDLK<BIAFJNPKHBL<TMOutput>>.JEGAOCIPMMJ> DELJFHGFGEN<TMOutput, TMInput, TMNode>([In] this DHLIOKBPFDF<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMNode> MBMFHFDDILC)
	{
		return default(FHBBDJEOIFM<BIAFJNPKHBL<TMOutput>, OJBLBICDDLK<BIAFJNPKHBL<TMOutput>>.JEGAOCIPMMJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x22CE770", Offset = "0x22CCF70", VA = "0x1822CE770")]
	public static LAAJNBMKMHO<BIAFJNPKHBL<TMNode>, KKHCNNBPMJB<TMNode>.OFEOLOHFGNJ> OPOLLADKGFK<TMNode, TMInput, TMOutput>([In] this DHLIOKBPFDF<TMInput, TMOutput, TMNode> PIEBBHMNEOG)
	{
		return default(LAAJNBMKMHO<BIAFJNPKHBL<TMNode>, KKHCNNBPMJB<TMNode>.OFEOLOHFGNJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct GOBMCNJLOFJ<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal KKHCNNBPMJB<TMOutput> IAKPEPGAHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal DHDAPGCBMBJ<TMOutput, BIAFJNPKHBL<TMNode>> MGANCBBNKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal DHDAPGCBMBJ<TMOutput, OJBLBICDDLK<BIAFJNPKHBL<TMInput>>> MCJDAFAMOCE;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3534530", Offset = "0x3532D30", VA = "0x183534530")]
	internal GOBMCNJLOFJ([In] KKHCNNBPMJB<TMOutput> NELKNKCIMIB, [In] DHDAPGCBMBJ<TMOutput, BIAFJNPKHBL<TMNode>> ALECNGGHJAI, [In] DHDAPGCBMBJ<TMOutput, OJBLBICDDLK<BIAFJNPKHBL<TMInput>>> AENKLOGIEEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3534370", Offset = "0x3532B70", VA = "0x183534370")]
	internal static GOBMCNJLOFJ<TMInput, TMOutput, TMNode> AKKFLOCCMNP()
	{
		return default(GOBMCNJLOFJ<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class OFHNKDMBEDB
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x264AB30", Offset = "0x2649330", VA = "0x18264AB30")]
	internal static EHBLLNLPMNJ JMOOMJHDBEG<TMInput, TMOutput, TMNode>([In] this GOBMCNJLOFJ<TMInput, TMOutput, TMNode> PIEBBHMNEOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x264A1D0", Offset = "0x26489D0", VA = "0x18264A1D0")]
	internal static GOBMCNJLOFJ<TMInput, TMOutput, TMNode> AEDPLFCAHJC<TMInput, TMOutput, TMNode>(this EHBLLNLPMNJ PIEBBHMNEOG)
	{
		return default(GOBMCNJLOFJ<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x264A6E0", Offset = "0x2648EE0", VA = "0x18264A6E0")]
	private static LKMGOMHAEOL AKAEHLOEEDK<TMInput>([In] this OJBLBICDDLK<BIAFJNPKHBL<TMInput>> PIEBBHMNEOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x264A8B0", Offset = "0x26490B0", VA = "0x18264A8B0")]
	private static OJBLBICDDLK<BIAFJNPKHBL<TMInput>> BCLNFMDCHFE<TMInput>(this LKMGOMHAEOL PIEBBHMNEOG)
	{
		return default(OJBLBICDDLK<BIAFJNPKHBL<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x22C9410", Offset = "0x22C7C10", VA = "0x1822C9410")]
	internal static void PIODDHMICMM<TMInput, TMOutput, TMNode>(this GOBMCNJLOFJ<TMInput, TMOutput, TMNode> PIEBBHMNEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x22C8CB0", Offset = "0x22C74B0", VA = "0x1822C8CB0")]
	internal static BIAFJNPKHBL<TMOutput> CJBBHKJKFDA<TMOutput, TMInput, TMNode>(this GOBMCNJLOFJ<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMNode> ELOONLEOBIM)
	{
		return default(BIAFJNPKHBL<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x22C8D90", Offset = "0x22C7590", VA = "0x1822C8D90")]
	internal static void DABJCHJIOBI<TMInput, TMOutput, TMNode>(this GOBMCNJLOFJ<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMOutput> MBMFHFDDILC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x22C93F0", Offset = "0x22C7BF0", VA = "0x1822C93F0")]
	public static bool ODPBAOJILCN<TMInput, TMOutput, TMNode>([In] this GOBMCNJLOFJ<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMOutput> MBMFHFDDILC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x22C8E20", Offset = "0x22C7620", VA = "0x1822C8E20")]
	public static BIAFJNPKHBL<TMNode> EGJPHCLJMEN<TMNode, TMInput, TMOutput>([In] this GOBMCNJLOFJ<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMOutput> MBMFHFDDILC)
	{
		return default(BIAFJNPKHBL<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x22C8D50", Offset = "0x22C7550", VA = "0x1822C8D50")]
	public static int OELEIKEFLOI<TMInput, TMOutput, TMNode>([In] this GOBMCNJLOFJ<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMOutput> MBMFHFDDILC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x22C93A0", Offset = "0x22C7BA0", VA = "0x1822C93A0")]
	public static BIAFJNPKHBL<TMInput> FLFDJADALLO<TMInput, TMOutput, TMNode>([In] this GOBMCNJLOFJ<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMOutput> MBMFHFDDILC, int EAHCFBMNNCF)
	{
		return default(BIAFJNPKHBL<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x22C8990", Offset = "0x22C7190", VA = "0x1822C8990")]
	internal static void AKPLLALFIJB<TMInput, TMOutput, TMNode>(this GOBMCNJLOFJ<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMOutput> MBMFHFDDILC, BIAFJNPKHBL<TMInput> LPCJAHLDKAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x22C8990", Offset = "0x22C7190", VA = "0x1822C8990")]
	internal static void KHGMJAAKEPO<TMInput, TMOutput, TMNode>(this GOBMCNJLOFJ<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMOutput> MBMFHFDDILC, BIAFJNPKHBL<TMInput> LPCJAHLDKAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x22C89D0", Offset = "0x22C71D0", VA = "0x1822C89D0")]
	public static OJBLBICDDLK<BIAFJNPKHBL<TMInput>>.JEGAOCIPMMJ MNCOBFINJBI<TMInput, TMOutput, TMNode>([In] this GOBMCNJLOFJ<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMOutput> MBMFHFDDILC)
	{
		return default(OJBLBICDDLK<BIAFJNPKHBL<TMInput>>.JEGAOCIPMMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x22C89D0", Offset = "0x22C71D0", VA = "0x1822C89D0")]
	public static FHBBDJEOIFM<BIAFJNPKHBL<TMInput>, OJBLBICDDLK<BIAFJNPKHBL<TMInput>>.JEGAOCIPMMJ> EKGBOOKJFMD<TMInput, TMOutput, TMNode>([In] this GOBMCNJLOFJ<TMInput, TMOutput, TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMOutput> MBMFHFDDILC)
	{
		return default(FHBBDJEOIFM<BIAFJNPKHBL<TMInput>, OJBLBICDDLK<BIAFJNPKHBL<TMInput>>.JEGAOCIPMMJ>);
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
