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
		[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1F4D4C0", Offset = "0x1F4BCC0", VA = "0x181F4D4C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x86D840", Offset = "0x86C040", VA = "0x18086D840")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x86D880", Offset = "0x86C080", VA = "0x18086D880")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct EECILIBNILO<TMInput, TMOutput, TMNode> : IEnumerator<KPFGDODNFBO<TMNode>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private KFOMKHOPGLI<TMInput, TMOutput, TMNode> KIOFNEFOFIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private MHDLAAADLFJ<TMInput, TMOutput, TMNode> MFPIKPANHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private bool MNFDGLJCKEO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly KPFGDODNFBO<TMNode> APOKPICBEBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3744CD0", Offset = "0x37434D0", VA = "0x183744CD0", Slot = "4")]
		get
		{
			return default(KPFGDODNFBO<TMNode>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3744B70", Offset = "0x3743370", VA = "0x183744B70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3744C00", Offset = "0x3743400", VA = "0x183744C00")]
	internal EECILIBNILO([In] KFOMKHOPGLI<TMInput, TMOutput, TMNode> AHACOLPJFAL, [In] MHDLAAADLFJ<TMInput, TMOutput, TMNode> FIHCDLJMMMD, bool HPHKFEONNKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3744A30", Offset = "0x3743230", VA = "0x183744A30", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3744AF0", Offset = "0x37432F0", VA = "0x183744AF0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x37449B0", Offset = "0x37431B0", VA = "0x1837449B0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class GLGJAEMLELF
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F8E0", Offset = "0x2A8E0E0", VA = "0x182A8F8E0")]
	public static EECILIBNILO<TMInput, TMOutput, TMNode> OJFFIHPLODM<TMInput, TMOutput, TMNode>([In] GBBGHEOMNOA<TMInput, TMOutput, TMNode> ECBBLMJOHDG, KPFGDODNFBO<TMNode> FMPAALMFOIG)
	{
		return default(EECILIBNILO<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct MHDLAAADLFJ<TMInput, TMOutput, TMNode> : IEnumerator<KPFGDODNFBO<TMInput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private JADAHCHJIGA<KPFGDODNFBO<TMOutput>>.EIPCCCCEHKJ PAPHGDONHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private JADAHCHJIGA<KPFGDODNFBO<TMInput>>.EIPCCCCEHKJ KOGJMIIIHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly GMDMEKGKNGG<TMInput, TMOutput, TMNode> ENJHHOIFOKH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public KPFGDODNFBO<TMInput> APOKPICBEBA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4094850", Offset = "0x4093050", VA = "0x184094850", Slot = "4")]
		get
		{
			return default(KPFGDODNFBO<TMInput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4094720", Offset = "0x4092F20", VA = "0x184094720", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x40947D0", Offset = "0x4092FD0", VA = "0x1840947D0")]
	internal MHDLAAADLFJ([In] JADAHCHJIGA<KPFGDODNFBO<TMOutput>>.EIPCCCCEHKJ LPMAKPEOEBB, [In] JADAHCHJIGA<KPFGDODNFBO<TMInput>>.EIPCCCCEHKJ ELMGOKOHAAL, [In] GMDMEKGKNGG<TMInput, TMOutput, TMNode> CJLPBJALDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4094540", Offset = "0x4092D40", VA = "0x184094540", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x40946B0", Offset = "0x4092EB0", VA = "0x1840946B0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x40944D0", Offset = "0x4092CD0", VA = "0x1840944D0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class DPJIIEAHKEP
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x28FCFB0", Offset = "0x28FB7B0", VA = "0x1828FCFB0")]
	public static MHDLAAADLFJ<TMInput, TMOutput, TMNode> OJFFIHPLODM<TMInput, TMOutput, TMNode>([In] GBBGHEOMNOA<TMInput, TMOutput, TMNode> ECBBLMJOHDG, KPFGDODNFBO<TMNode> FMPAALMFOIG)
	{
		return default(MHDLAAADLFJ<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct KFOMKHOPGLI<TMInput, TMOutput, TMNode> : IEnumerator<KPFGDODNFBO<TMOutput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private JADAHCHJIGA<KPFGDODNFBO<TMInput>>.EIPCCCCEHKJ CDEAHHNBOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private JADAHCHJIGA<KPFGDODNFBO<TMOutput>>.EIPCCCCEHKJ FENHDMMHIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly OLLILMIPJJL<TMInput, TMOutput, TMNode> LAONLMFCGIC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public KPFGDODNFBO<TMOutput> APOKPICBEBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4094850", Offset = "0x4093050", VA = "0x184094850", Slot = "4")]
		get
		{
			return default(KPFGDODNFBO<TMOutput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4094720", Offset = "0x4092F20", VA = "0x184094720", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x40947D0", Offset = "0x4092FD0", VA = "0x1840947D0")]
	internal KFOMKHOPGLI([In] JADAHCHJIGA<KPFGDODNFBO<TMInput>>.EIPCCCCEHKJ MKBOKBIGALL, [In] JADAHCHJIGA<KPFGDODNFBO<TMOutput>>.EIPCCCCEHKJ BCLBEFIADNN, [In] OLLILMIPJJL<TMInput, TMOutput, TMNode> FPMJPCCLAIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4094540", Offset = "0x4092D40", VA = "0x184094540", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x40946B0", Offset = "0x4092EB0", VA = "0x1840946B0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x40944D0", Offset = "0x4092CD0", VA = "0x1840944D0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class BMAAKCBFLDD
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x283DD00", Offset = "0x283C500", VA = "0x18283DD00")]
	public static KFOMKHOPGLI<TMInput, TMOutput, TMNode> OJFFIHPLODM<TMInput, TMOutput, TMNode>([In] GBBGHEOMNOA<TMInput, TMOutput, TMNode> ECBBLMJOHDG, KPFGDODNFBO<TMNode> FMPAALMFOIG)
	{
		return default(KFOMKHOPGLI<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct GBBGHEOMNOA<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public OLLILMIPJJL<TMInput, TMOutput, TMNode> BKAHNEONHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public GMDMEKGKNGG<TMInput, TMOutput, TMNode> NEBGAHDKBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public FEJJHBLHNLO<TMInput, TMOutput, TMNode> KIOBDEJOIGJ;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3BBC260", Offset = "0x3BBAA60", VA = "0x183BBC260")]
	internal GBBGHEOMNOA([In] OLLILMIPJJL<TMInput, TMOutput, TMNode> FPMJPCCLAIC, [In] GMDMEKGKNGG<TMInput, TMOutput, TMNode> CJLPBJALDFK, [In] FEJJHBLHNLO<TMInput, TMOutput, TMNode> FHGKIGCPICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3BBBF70", Offset = "0x3BBA770", VA = "0x183BBBF70")]
	public static GBBGHEOMNOA<TMInput?, TMOutput?, TMNode?> OJFFIHPLODM()
	{
		return default(GBBGHEOMNOA<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class JEFEMKJFPEM
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5F30", Offset = "0x2AE4730", VA = "0x182AE5F30")]
	public static POIFFAPGFIH? HNAIEAEAFJH<TMInput, TMOutput, TMNode>([In] this GBBGHEOMNOA<TMInput, TMOutput, TMNode> EGJINJKGIAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2AE69D0", Offset = "0x2AE51D0", VA = "0x182AE69D0")]
	public static GBBGHEOMNOA<TMInput?, TMOutput?, TMNode?> PKPMANIAHDL<TMInput, TMOutput, TMNode>(this POIFFAPGFIH EGJINJKGIAK)
	{
		return default(GBBGHEOMNOA<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6890", Offset = "0x2AE5090", VA = "0x182AE6890")]
	public static void PGFGBHFCFEG<TMInput, TMOutput, TMNode>(this GBBGHEOMNOA<TMInput, TMOutput, TMNode> EGJINJKGIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6480", Offset = "0x2AE4C80", VA = "0x182AE6480")]
	public static void LADKHILAFHL<TMInput, TMOutput, TMNode>(this GBBGHEOMNOA<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMOutput> NBEKJKEDPBE, KPFGDODNFBO<TMInput> OPNPBHOMMHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6930", Offset = "0x2AE5130", VA = "0x182AE6930")]
	public static void PGOCMECKKNP<TMInput, TMOutput, TMNode>(this GBBGHEOMNOA<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMOutput> NBEKJKEDPBE, KPFGDODNFBO<TMInput> OPNPBHOMMHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2AE59E0", Offset = "0x2AE41E0", VA = "0x182AE59E0")]
	public static int DKGKEPHFGBN<TMInput, TMOutput, TMNode>([In] this GBBGHEOMNOA<TMInput, TMOutput, TMNode> EGJINJKGIAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5B30", Offset = "0x2AE4330", VA = "0x182AE5B30")]
	public static bool FCICBEEBDDH<TMInput, TMOutput, TMNode>([In] this GBBGHEOMNOA<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMOutput> NBEKJKEDPBE, KPFGDODNFBO<TMInput> OPNPBHOMMHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5EE0", Offset = "0x2AE46E0", VA = "0x182AE5EE0")]
	public static bool HJIAGJJHPHM<TMInput, TMOutput, TMNode>([In] this GBBGHEOMNOA<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMOutput> KGEJHDKAFFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6850", Offset = "0x2AE5050", VA = "0x182AE6850")]
	public static bool PCHKIJNGKCM<TMInput, TMOutput, TMNode>([In] this GBBGHEOMNOA<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMInput> KGEJHDKAFFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5880", Offset = "0x2AE4080", VA = "0x182AE5880")]
	public static KPFGDODNFBO<TMNode?> CPLKEIOCHLD<TMNode, TMInput, TMOutput>(this GBBGHEOMNOA<TMInput, TMOutput, TMNode> EGJINJKGIAK)
	{
		return default(KPFGDODNFBO<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6520", Offset = "0x2AE4D20", VA = "0x182AE6520")]
	public static void LPMGOELJLJO<TMInput, TMOutput, TMNode>(this GBBGHEOMNOA<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMNode> FMPAALMFOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5950", Offset = "0x2AE4150", VA = "0x182AE5950")]
	public static KPFGDODNFBO<TMInput?> DINGOLJENEI<TMInput, TMOutput, TMNode>(this GBBGHEOMNOA<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMNode> FMPAALMFOIG)
	{
		return default(KPFGDODNFBO<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2AE57E0", Offset = "0x2AE3FE0", VA = "0x182AE57E0")]
	public static KPFGDODNFBO<TMOutput?> BLJGGGIJKDF<TMOutput, TMInput, TMNode>(this GBBGHEOMNOA<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMNode> FMPAALMFOIG)
	{
		return default(KPFGDODNFBO<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2AE66C0", Offset = "0x2AE4EC0", VA = "0x182AE66C0")]
	public static KPFGDODNFBO<TMInput?> MDFKCDAGHIE<TMInput, TMOutput, TMNode>(this GBBGHEOMNOA<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMNode> FMPAALMFOIG, int JBDLDJOINOF)
	{
		return default(KPFGDODNFBO<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6280", Offset = "0x2AE4A80", VA = "0x182AE6280")]
	public static KPFGDODNFBO<TMOutput?> KBCFCBILBBM<TMOutput, TMInput, TMNode>(this GBBGHEOMNOA<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMNode> FMPAALMFOIG, int JBDLDJOINOF)
	{
		return default(KPFGDODNFBO<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2AE56F0", Offset = "0x2AE3EF0", VA = "0x182AE56F0")]
	public static void AFFMGOHNEEO<TMInput, TMOutput, TMNode>(this GBBGHEOMNOA<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMNode> FMPAALMFOIG, int KJAFKLCHMOO, int OEKEGAJOMMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6760", Offset = "0x2AE4F60", VA = "0x182AE6760")]
	public static void NKAPAHJDILO<TMInput, TMOutput, TMNode>(this GBBGHEOMNOA<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMNode> FMPAALMFOIG, int KJAFKLCHMOO, int OEKEGAJOMMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5C50", Offset = "0x2AE4450", VA = "0x182AE5C50")]
	public static void GEIHEAFGBHO<TMInput, TMOutput, TMNode>(this GBBGHEOMNOA<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMInput> CACIDFDKPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6320", Offset = "0x2AE4B20", VA = "0x182AE6320")]
	public static void KEBMNEMIPLH<TMInput, TMOutput, TMNode>(this GBBGHEOMNOA<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMOutput> CJCIDDLJNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8E2600", Offset = "0x8E0E00", VA = "0x1808E2600")]
	public static NNJCIDIHBNF<TMInput?> COMKLLHBLBP<TMInput, TMOutput, TMNode>([In] this GBBGHEOMNOA<TMInput, TMOutput, TMNode> EGJINJKGIAK)
	{
		return default(NNJCIDIHBNF<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1F6A040", Offset = "0x1F68840", VA = "0x181F6A040")]
	public static NNJCIDIHBNF<TMOutput?> MJFHELKLGGE<TMOutput, TMInput, TMNode>([In] this GBBGHEOMNOA<TMInput, TMOutput, TMNode> EGJINJKGIAK)
	{
		return default(NNJCIDIHBNF<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1F68B80", Offset = "0x1F67380", VA = "0x181F68B80")]
	public static NNJCIDIHBNF<TMNode?> EJCDPNBMGNK<TMNode, TMInput, TMOutput>([In] this GBBGHEOMNOA<TMInput, TMOutput, TMNode> EGJINJKGIAK)
	{
		return default(NNJCIDIHBNF<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6200", Offset = "0x2AE4A00", VA = "0x182AE6200")]
	public static MHDLAAADLFJ<TMInput?, TMOutput?, TMNode?> JMDIPHBPIIM<TMInput, TMOutput, TMNode>([In] this GBBGHEOMNOA<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMNode> EGNLNANJFMI)
	{
		return default(MHDLAAADLFJ<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6200", Offset = "0x2AE4A00", VA = "0x182AE6200")]
	public static KFOMKHOPGLI<TMInput?, TMOutput?, TMNode?> OAFHDDFMCHC<TMInput, TMOutput, TMNode>([In] this GBBGHEOMNOA<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMNode> EGNLNANJFMI)
	{
		return default(KFOMKHOPGLI<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6DA0", Offset = "0x2AE55A0", VA = "0x182AE6DA0")]
	public static EECILIBNILO<TMInput?, TMOutput?, TMNode?> PMMIDNGOCID<TMInput, TMOutput, TMNode>([In] this GBBGHEOMNOA<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMNode> EGNLNANJFMI)
	{
		return default(EECILIBNILO<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5DB0", Offset = "0x2AE45B0", VA = "0x182AE5DB0")]
	public static LHLAHEHKEGG<KPFGDODNFBO<TMInput?>, MHDLAAADLFJ<TMInput?, TMOutput?, TMNode?>> HFABEEGCCAI<TMInput, TMOutput, TMNode>([In] this GBBGHEOMNOA<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMNode> EGNLNANJFMI)
	{
		return default(LHLAHEHKEGG<KPFGDODNFBO<TMInput>, MHDLAAADLFJ<TMInput, TMOutput, TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6050", Offset = "0x2AE4850", VA = "0x182AE6050")]
	public static LHLAHEHKEGG<KPFGDODNFBO<TMNode?>, EECILIBNILO<TMInput?, TMOutput?, TMNode?>> JKJKMMLKOKO<TMNode, TMInput, TMOutput>([In] this GBBGHEOMNOA<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMNode> EGNLNANJFMI)
	{
		return default(LHLAHEHKEGG<KPFGDODNFBO<TMNode>, EECILIBNILO<TMInput, TMOutput, TMNode>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct OLLILMIPJJL<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal NNJCIDIHBNF<TMInput> DMNIEJOGGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal PEOPJNDHKBL<TMInput, KPFGDODNFBO<TMNode>> ACLHMPJLCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal PEOPJNDHKBL<TMInput, JADAHCHJIGA<KPFGDODNFBO<TMOutput>>> ENJHHOIFOKH;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3ADEFB0", Offset = "0x3ADD7B0", VA = "0x183ADEFB0")]
	internal OLLILMIPJJL([In] NNJCIDIHBNF<TMInput> BDCCGOGHPMC, [In] PEOPJNDHKBL<TMInput, KPFGDODNFBO<TMNode>> FHGKIGCPICD, [In] PEOPJNDHKBL<TMInput, JADAHCHJIGA<KPFGDODNFBO<TMOutput>>> CJLPBJALDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3ADEDB0", Offset = "0x3ADD5B0", VA = "0x183ADEDB0")]
	internal static OLLILMIPJJL<TMInput, TMOutput, TMNode> OJFFIHPLODM()
	{
		return default(OLLILMIPJJL<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class ELENOPKEPCC
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2921330", Offset = "0x291FB30", VA = "0x182921330")]
	internal static HMOAOFDPAOH HNAIEAEAFJH<TMInput, TMOutput, TMNode>([In] this OLLILMIPJJL<TMInput, TMOutput, TMNode> EGJINJKGIAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2921FB0", Offset = "0x29207B0", VA = "0x182921FB0")]
	internal static OLLILMIPJJL<TMInput, TMOutput, TMNode> PKPMANIAHDL<TMInput, TMOutput, TMNode>(this HMOAOFDPAOH EGJINJKGIAK)
	{
		return default(OLLILMIPJJL<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2921A00", Offset = "0x2920200", VA = "0x182921A00")]
	private static NJPOPNMKLEB JEJBHGAAGEP<TMOutput>([In] this JADAHCHJIGA<KPFGDODNFBO<TMOutput>> EGJINJKGIAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2921730", Offset = "0x291FF30", VA = "0x182921730")]
	private static JADAHCHJIGA<KPFGDODNFBO<TMOutput>> IBFKKDAEAAH<TMOutput>(this NJPOPNMKLEB EGJINJKGIAK)
	{
		return default(JADAHCHJIGA<KPFGDODNFBO<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2921DC0", Offset = "0x29205C0", VA = "0x182921DC0")]
	internal static void PGFGBHFCFEG<TMInput, TMOutput, TMNode>(this OLLILMIPJJL<TMInput, TMOutput, TMNode> EGJINJKGIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2921230", Offset = "0x291FA30", VA = "0x182921230")]
	internal static KPFGDODNFBO<TMInput> GGEAEMAJLHK<TMInput, TMOutput, TMNode>(this OLLILMIPJJL<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMNode> DDLCNKGIKEK)
	{
		return default(KPFGDODNFBO<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2921120", Offset = "0x291F920", VA = "0x182921120")]
	internal static void CHEAPHHCLBO<TMInput, TMOutput, TMNode>(this OLLILMIPJJL<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMInput> EGNLNANJFMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x28301C0", Offset = "0x282E9C0", VA = "0x1828301C0")]
	public static bool HMKIEFDGCCL<TMInput, TMOutput, TMNode>([In] this OLLILMIPJJL<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMInput> EGNLNANJFMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2830440", Offset = "0x282EC40", VA = "0x182830440")]
	public static int PNHJOACJOPG<TMInput, TMOutput, TMNode>([In] this OLLILMIPJJL<TMInput, TMOutput, TMNode> EGJINJKGIAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2921C90", Offset = "0x2920490", VA = "0x182921C90")]
	public static KPFGDODNFBO<TMNode> LMEPJKHEDCN<TMNode, TMInput, TMOutput>([In] this OLLILMIPJJL<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMInput> EGNLNANJFMI)
	{
		return default(KPFGDODNFBO<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2921CD0", Offset = "0x29204D0", VA = "0x182921CD0")]
	public static int NIDMMLIIAOD<TMInput, TMOutput, TMNode>([In] this OLLILMIPJJL<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMInput> EGNLNANJFMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2921D40", Offset = "0x2920540", VA = "0x182921D40")]
	public static KPFGDODNFBO<TMOutput> OGABLGJGDHI<TMOutput, TMInput, TMNode>([In] this OLLILMIPJJL<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMInput> EGNLNANJFMI, int JBDLDJOINOF)
	{
		return default(KPFGDODNFBO<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x29210B0", Offset = "0x291F8B0", VA = "0x1829210B0")]
	internal static void IBPMDIJNHOK<TMInput, TMOutput, TMNode>(this OLLILMIPJJL<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMInput> EGNLNANJFMI, KPFGDODNFBO<TMOutput> CJCIDDLJNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x29210B0", Offset = "0x291F8B0", VA = "0x1829210B0")]
	internal static void ACAMBGINOLC<TMInput, TMOutput, TMNode>(this OLLILMIPJJL<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMInput> EGNLNANJFMI, KPFGDODNFBO<TMOutput> CJCIDDLJNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2921C00", Offset = "0x2920400", VA = "0x182921C00")]
	public static JADAHCHJIGA<KPFGDODNFBO<TMOutput>>.EIPCCCCEHKJ JKONOBHCBEK<TMOutput, TMInput, TMNode>([In] this OLLILMIPJJL<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMInput> EGNLNANJFMI)
	{
		return default(JADAHCHJIGA<KPFGDODNFBO<TMOutput>>.EIPCCCCEHKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2921C00", Offset = "0x2920400", VA = "0x182921C00")]
	public static PCMHDNBJLGM<KPFGDODNFBO<TMOutput>, JADAHCHJIGA<KPFGDODNFBO<TMOutput>>.EIPCCCCEHKJ> OCBFDDHMPEN<TMOutput, TMInput, TMNode>([In] this OLLILMIPJJL<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMInput> EGNLNANJFMI)
	{
		return default(PCMHDNBJLGM<KPFGDODNFBO<TMOutput>, JADAHCHJIGA<KPFGDODNFBO<TMOutput>>.EIPCCCCEHKJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x283E1F0", Offset = "0x283C9F0", VA = "0x18283E1F0")]
	public static LHLAHEHKEGG<KPFGDODNFBO<TMInput>, NNJCIDIHBNF<TMInput>.LLNIGBIFAPP> LKDILMNCMMO<TMInput, TMOutput, TMNode>([In] this OLLILMIPJJL<TMInput, TMOutput, TMNode> EGJINJKGIAK)
	{
		return default(LHLAHEHKEGG<KPFGDODNFBO<TMInput>, NNJCIDIHBNF<TMInput>.LLNIGBIFAPP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct FEJJHBLHNLO<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal NNJCIDIHBNF<TMNode> DMNIEJOGGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal PEOPJNDHKBL<TMNode, JADAHCHJIGA<KPFGDODNFBO<TMInput>>> LAONLMFCGIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal PEOPJNDHKBL<TMNode, JADAHCHJIGA<KPFGDODNFBO<TMOutput>>> ENJHHOIFOKH;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3ADEFB0", Offset = "0x3ADD7B0", VA = "0x183ADEFB0")]
	internal FEJJHBLHNLO([In] NNJCIDIHBNF<TMNode> BDCCGOGHPMC, [In] PEOPJNDHKBL<TMNode, JADAHCHJIGA<KPFGDODNFBO<TMInput>>> FPMJPCCLAIC, [In] PEOPJNDHKBL<TMNode, JADAHCHJIGA<KPFGDODNFBO<TMOutput>>> CJLPBJALDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3ADEDB0", Offset = "0x3ADD5B0", VA = "0x183ADEDB0")]
	internal static FEJJHBLHNLO<TMInput, TMOutput, TMNode> OJFFIHPLODM()
	{
		return default(FEJJHBLHNLO<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class ELOCMJMDFOP
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2923970", Offset = "0x2922170", VA = "0x182923970")]
	internal static NIEFMMMLFNL HNAIEAEAFJH<TMInput, TMOutput, TMNode>([In] this FEJJHBLHNLO<TMInput, TMOutput, TMNode> EGJINJKGIAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2924530", Offset = "0x2922D30", VA = "0x182924530")]
	internal static FEJJHBLHNLO<TMInput, TMOutput, TMNode> PKPMANIAHDL<TMInput, TMOutput, TMNode>(this NIEFMMMLFNL EGJINJKGIAK)
	{
		return default(FEJJHBLHNLO<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x29236B0", Offset = "0x2921EB0", VA = "0x1829236B0")]
	private static KLICHLMPALJ CMKGLHAPBPI<TMInput>([In] this JADAHCHJIGA<KPFGDODNFBO<TMInput>> EGJINJKGIAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2923170", Offset = "0x2921970", VA = "0x182923170")]
	private static JADAHCHJIGA<KPFGDODNFBO<TMInput>> AFBANINAMJO<TMInput>(this KLICHLMPALJ EGJINJKGIAK)
	{
		return default(JADAHCHJIGA<KPFGDODNFBO<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2922F70", Offset = "0x2921770", VA = "0x182922F70")]
	private static AMDBLDMAGHH ADMAAKPFACF<TMOutput>([In] this JADAHCHJIGA<KPFGDODNFBO<TMOutput>> EGJINJKGIAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2923DA0", Offset = "0x29225A0", VA = "0x182923DA0")]
	private static JADAHCHJIGA<KPFGDODNFBO<TMOutput>> IOOCCNDGPHE<TMOutput>(this AMDBLDMAGHH EGJINJKGIAK)
	{
		return default(JADAHCHJIGA<KPFGDODNFBO<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x29241D0", Offset = "0x29229D0", VA = "0x1829241D0")]
	internal static void PGFGBHFCFEG<TMInput, TMOutput, TMNode>(this FEJJHBLHNLO<TMInput, TMOutput, TMNode> EGJINJKGIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x29238B0", Offset = "0x29220B0", VA = "0x1829238B0")]
	internal static KPFGDODNFBO<TMNode> GGEAEMAJLHK<TMNode, TMInput, TMOutput>(this FEJJHBLHNLO<TMInput, TMOutput, TMNode> EGJINJKGIAK, [In] JADAHCHJIGA<KPFGDODNFBO<TMInput>> FPMJPCCLAIC, [In] JADAHCHJIGA<KPFGDODNFBO<TMOutput>> CJLPBJALDFK)
	{
		return default(KPFGDODNFBO<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2923550", Offset = "0x2921D50", VA = "0x182923550")]
	internal static void CHEAPHHCLBO<TMInput, TMOutput, TMNode>(this FEJJHBLHNLO<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMNode> EGNLNANJFMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x28301C0", Offset = "0x282E9C0", VA = "0x1828301C0")]
	public static bool HMKIEFDGCCL<TMInput, TMOutput, TMNode>([In] this FEJJHBLHNLO<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMNode> EGNLNANJFMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2830440", Offset = "0x282EC40", VA = "0x182830440")]
	public static int PNHJOACJOPG<TMInput, TMOutput, TMNode>([In] this FEJJHBLHNLO<TMInput, TMOutput, TMNode> EGJINJKGIAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2924160", Offset = "0x2922960", VA = "0x182924160")]
	public static int NMBIGCDIHCO<TMInput, TMOutput, TMNode>([In] this FEJJHBLHNLO<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMNode> EGNLNANJFMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2921CD0", Offset = "0x29204D0", VA = "0x182921CD0")]
	public static int NIDMMLIIAOD<TMInput, TMOutput, TMNode>([In] this FEJJHBLHNLO<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMNode> EGNLNANJFMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2924AB0", Offset = "0x29232B0", VA = "0x182924AB0")]
	public static KPFGDODNFBO<TMInput> PNLLFACNBLP<TMInput, TMOutput, TMNode>([In] this FEJJHBLHNLO<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMNode> EGNLNANJFMI, int JBDLDJOINOF)
	{
		return default(KPFGDODNFBO<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2921D40", Offset = "0x2920540", VA = "0x182921D40")]
	public static KPFGDODNFBO<TMOutput> OGABLGJGDHI<TMOutput, TMInput, TMNode>([In] this FEJJHBLHNLO<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMNode> EGNLNANJFMI, int JBDLDJOINOF)
	{
		return default(KPFGDODNFBO<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2924070", Offset = "0x2922870", VA = "0x182924070")]
	internal static void KKNJNANHOJM<TMInput, TMOutput, TMNode>(this FEJJHBLHNLO<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMNode> EGNLNANJFMI, KPFGDODNFBO<TMInput> CACIDFDKPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x29210B0", Offset = "0x291F8B0", VA = "0x1829210B0")]
	internal static void IBPMDIJNHOK<TMInput, TMOutput, TMNode>(this FEJJHBLHNLO<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMNode> EGNLNANJFMI, KPFGDODNFBO<TMOutput> CJCIDDLJNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x29234D0", Offset = "0x2921CD0", VA = "0x1829234D0")]
	internal static void CCOOKCIAEOL<TMInput, TMOutput, TMNode>(this FEJJHBLHNLO<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMNode> EGNLNANJFMI, int JBDLDJOINOF, KPFGDODNFBO<TMInput> CACIDFDKPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x29240E0", Offset = "0x29228E0", VA = "0x1829240E0")]
	internal static void NHGAPMLKCEO<TMInput, TMOutput, TMNode>(this FEJJHBLHNLO<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMNode> EGNLNANJFMI, int JBDLDJOINOF, KPFGDODNFBO<TMOutput> CJCIDDLJNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2924070", Offset = "0x2922870", VA = "0x182924070")]
	internal static void JEGCAHEDHDJ<TMInput, TMOutput, TMNode>(this FEJJHBLHNLO<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMNode> EGNLNANJFMI, KPFGDODNFBO<TMInput> CACIDFDKPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x29210B0", Offset = "0x291F8B0", VA = "0x1829210B0")]
	internal static void ACAMBGINOLC<TMInput, TMOutput, TMNode>(this FEJJHBLHNLO<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMNode> EGNLNANJFMI, KPFGDODNFBO<TMOutput> CJCIDDLJNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2923440", Offset = "0x2921C40", VA = "0x182923440")]
	public static JADAHCHJIGA<KPFGDODNFBO<TMInput>>.EIPCCCCEHKJ AKEBOCHPFFI<TMInput, TMOutput, TMNode>([In] this FEJJHBLHNLO<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMNode> EGNLNANJFMI)
	{
		return default(JADAHCHJIGA<KPFGDODNFBO<TMInput>>.EIPCCCCEHKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2921C00", Offset = "0x2920400", VA = "0x182921C00")]
	public static JADAHCHJIGA<KPFGDODNFBO<TMOutput>>.EIPCCCCEHKJ JKONOBHCBEK<TMOutput, TMInput, TMNode>([In] this FEJJHBLHNLO<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMNode> EGNLNANJFMI)
	{
		return default(JADAHCHJIGA<KPFGDODNFBO<TMOutput>>.EIPCCCCEHKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2923440", Offset = "0x2921C40", VA = "0x182923440")]
	public static PCMHDNBJLGM<KPFGDODNFBO<TMInput>, JADAHCHJIGA<KPFGDODNFBO<TMInput>>.EIPCCCCEHKJ> OOGPLNKEGJE<TMInput, TMOutput, TMNode>([In] this FEJJHBLHNLO<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMNode> EGNLNANJFMI)
	{
		return default(PCMHDNBJLGM<KPFGDODNFBO<TMInput>, JADAHCHJIGA<KPFGDODNFBO<TMInput>>.EIPCCCCEHKJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2921C00", Offset = "0x2920400", VA = "0x182921C00")]
	public static PCMHDNBJLGM<KPFGDODNFBO<TMOutput>, JADAHCHJIGA<KPFGDODNFBO<TMOutput>>.EIPCCCCEHKJ> OCBFDDHMPEN<TMOutput, TMInput, TMNode>([In] this FEJJHBLHNLO<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMNode> EGNLNANJFMI)
	{
		return default(PCMHDNBJLGM<KPFGDODNFBO<TMOutput>, JADAHCHJIGA<KPFGDODNFBO<TMOutput>>.EIPCCCCEHKJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x283E1F0", Offset = "0x283C9F0", VA = "0x18283E1F0")]
	public static LHLAHEHKEGG<KPFGDODNFBO<TMNode>, NNJCIDIHBNF<TMNode>.LLNIGBIFAPP> LKDILMNCMMO<TMNode, TMInput, TMOutput>([In] this FEJJHBLHNLO<TMInput, TMOutput, TMNode> EGJINJKGIAK)
	{
		return default(LHLAHEHKEGG<KPFGDODNFBO<TMNode>, NNJCIDIHBNF<TMNode>.LLNIGBIFAPP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct GMDMEKGKNGG<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal NNJCIDIHBNF<TMOutput> DMNIEJOGGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal PEOPJNDHKBL<TMOutput, KPFGDODNFBO<TMNode>> ACLHMPJLCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal PEOPJNDHKBL<TMOutput, JADAHCHJIGA<KPFGDODNFBO<TMInput>>> LAONLMFCGIC;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3ADEFB0", Offset = "0x3ADD7B0", VA = "0x183ADEFB0")]
	internal GMDMEKGKNGG([In] NNJCIDIHBNF<TMOutput> BDCCGOGHPMC, [In] PEOPJNDHKBL<TMOutput, KPFGDODNFBO<TMNode>> FHGKIGCPICD, [In] PEOPJNDHKBL<TMOutput, JADAHCHJIGA<KPFGDODNFBO<TMInput>>> FPMJPCCLAIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3ADEDB0", Offset = "0x3ADD5B0", VA = "0x183ADEDB0")]
	internal static GMDMEKGKNGG<TMInput, TMOutput, TMNode> OJFFIHPLODM()
	{
		return default(GMDMEKGKNGG<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class PAHBFEGAAFA
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2C40CB0", Offset = "0x2C3F4B0", VA = "0x182C40CB0")]
	internal static ABLLABEIFGA HNAIEAEAFJH<TMInput, TMOutput, TMNode>([In] this GMDMEKGKNGG<TMInput, TMOutput, TMNode> EGJINJKGIAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2C41580", Offset = "0x2C3FD80", VA = "0x182C41580")]
	internal static GMDMEKGKNGG<TMInput, TMOutput, TMNode> PKPMANIAHDL<TMInput, TMOutput, TMNode>(this ABLLABEIFGA EGJINJKGIAK)
	{
		return default(GMDMEKGKNGG<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2C41380", Offset = "0x2C3FB80", VA = "0x182C41380")]
	private static JHJOOBOLFNL KLEEOMKCLOF<TMInput>([In] this JADAHCHJIGA<KPFGDODNFBO<TMInput>> EGJINJKGIAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2C410B0", Offset = "0x2C3F8B0", VA = "0x182C410B0")]
	private static JADAHCHJIGA<KPFGDODNFBO<TMInput>> JDOBDKJDJAF<TMInput>(this JHJOOBOLFNL EGJINJKGIAK)
	{
		return default(JADAHCHJIGA<KPFGDODNFBO<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2921DC0", Offset = "0x29205C0", VA = "0x182921DC0")]
	internal static void PGFGBHFCFEG<TMInput, TMOutput, TMNode>(this GMDMEKGKNGG<TMInput, TMOutput, TMNode> EGJINJKGIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2921230", Offset = "0x291FA30", VA = "0x182921230")]
	internal static KPFGDODNFBO<TMOutput> GGEAEMAJLHK<TMOutput, TMInput, TMNode>(this GMDMEKGKNGG<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMNode> DDLCNKGIKEK)
	{
		return default(KPFGDODNFBO<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2921120", Offset = "0x291F920", VA = "0x182921120")]
	internal static void CHEAPHHCLBO<TMInput, TMOutput, TMNode>(this GMDMEKGKNGG<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMOutput> EGNLNANJFMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x28301C0", Offset = "0x282E9C0", VA = "0x1828301C0")]
	public static bool HMKIEFDGCCL<TMInput, TMOutput, TMNode>([In] this GMDMEKGKNGG<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMOutput> EGNLNANJFMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2830440", Offset = "0x282EC40", VA = "0x182830440")]
	public static int PNHJOACJOPG<TMInput, TMOutput, TMNode>([In] this GMDMEKGKNGG<TMInput, TMOutput, TMNode> EGJINJKGIAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2921C90", Offset = "0x2920490", VA = "0x182921C90")]
	public static KPFGDODNFBO<TMNode> LMEPJKHEDCN<TMNode, TMInput, TMOutput>([In] this GMDMEKGKNGG<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMOutput> EGNLNANJFMI)
	{
		return default(KPFGDODNFBO<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2921CD0", Offset = "0x29204D0", VA = "0x182921CD0")]
	public static int NMBIGCDIHCO<TMInput, TMOutput, TMNode>([In] this GMDMEKGKNGG<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMOutput> EGNLNANJFMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2921D40", Offset = "0x2920540", VA = "0x182921D40")]
	public static KPFGDODNFBO<TMInput> PNLLFACNBLP<TMInput, TMOutput, TMNode>([In] this GMDMEKGKNGG<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMOutput> EGNLNANJFMI, int JBDLDJOINOF)
	{
		return default(KPFGDODNFBO<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x29210B0", Offset = "0x291F8B0", VA = "0x1829210B0")]
	internal static void KKNJNANHOJM<TMInput, TMOutput, TMNode>(this GMDMEKGKNGG<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMOutput> EGNLNANJFMI, KPFGDODNFBO<TMInput> CACIDFDKPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x29210B0", Offset = "0x291F8B0", VA = "0x1829210B0")]
	internal static void JEGCAHEDHDJ<TMInput, TMOutput, TMNode>(this GMDMEKGKNGG<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMOutput> EGNLNANJFMI, KPFGDODNFBO<TMInput> CACIDFDKPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2921C00", Offset = "0x2920400", VA = "0x182921C00")]
	public static JADAHCHJIGA<KPFGDODNFBO<TMInput>>.EIPCCCCEHKJ AKEBOCHPFFI<TMInput, TMOutput, TMNode>([In] this GMDMEKGKNGG<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMOutput> EGNLNANJFMI)
	{
		return default(JADAHCHJIGA<KPFGDODNFBO<TMInput>>.EIPCCCCEHKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2921C00", Offset = "0x2920400", VA = "0x182921C00")]
	public static PCMHDNBJLGM<KPFGDODNFBO<TMInput>, JADAHCHJIGA<KPFGDODNFBO<TMInput>>.EIPCCCCEHKJ> OOGPLNKEGJE<TMInput, TMOutput, TMNode>([In] this GMDMEKGKNGG<TMInput, TMOutput, TMNode> EGJINJKGIAK, KPFGDODNFBO<TMOutput> EGNLNANJFMI)
	{
		return default(PCMHDNBJLGM<KPFGDODNFBO<TMInput>, JADAHCHJIGA<KPFGDODNFBO<TMInput>>.EIPCCCCEHKJ>);
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
