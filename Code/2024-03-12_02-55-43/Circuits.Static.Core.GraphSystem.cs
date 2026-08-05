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
		[Cpp2IlInjected.Address(RVA = "0x7E57E0", Offset = "0x7E49E0", VA = "0x1807E57E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1DD0670", Offset = "0x1DCF870", VA = "0x181DD0670")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E5C40", Offset = "0x7E4E40", VA = "0x1807E5C40")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E5C80", Offset = "0x7E4E80", VA = "0x1807E5C80")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct DNIAOFBIOEL<TMInput, TMOutput, TMNode> : IEnumerator<IJMPLGOCAIG<TMNode>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private CMGHLEGJDBG<TMInput, TMOutput, TMNode> PKHEBKOJNBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private MPDKEJMJFCJ<TMInput, TMOutput, TMNode> BPHMNLKEGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private bool CJPPPEFHMFA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly IJMPLGOCAIG<TMNode> DNINAAJGKKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x508AF50", Offset = "0x508A150", VA = "0x18508AF50", Slot = "4")]
		get
		{
			return default(IJMPLGOCAIG<TMNode>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x508ADF0", Offset = "0x5089FF0", VA = "0x18508ADF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x508AE80", Offset = "0x508A080", VA = "0x18508AE80")]
	internal DNIAOFBIOEL([In] CMGHLEGJDBG<TMInput, TMOutput, TMNode> OLONOKHBOGE, [In] MPDKEJMJFCJ<TMInput, TMOutput, TMNode> AMNPMCOLCHD, bool CKOPAPMPGOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x508ACB0", Offset = "0x5089EB0", VA = "0x18508ACB0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x508AD70", Offset = "0x5089F70", VA = "0x18508AD70", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x508AC30", Offset = "0x5089E30", VA = "0x18508AC30", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class CJANGIHKOGA
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x25ED540", Offset = "0x25EC740", VA = "0x1825ED540")]
	public static DNIAOFBIOEL<TMInput, TMOutput, TMNode> GOMGEEBODDD<TMInput, TMOutput, TMNode>([In] BGECIKAGOJH<TMInput, TMOutput, TMNode> EPJBLPIMDDE, IJMPLGOCAIG<TMNode> CPDCLGDPBBB)
	{
		return default(DNIAOFBIOEL<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct MPDKEJMJFCJ<TMInput, TMOutput, TMNode> : IEnumerator<IJMPLGOCAIG<TMInput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DKMDKGGKAIH<IJMPLGOCAIG<TMOutput>>.KIBJOOMIKMJ KEGNJLFEEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private DKMDKGGKAIH<IJMPLGOCAIG<TMInput>>.KIBJOOMIKMJ OEHIPAPMKMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly NECMGLKNFJK<TMInput, TMOutput, TMNode> NCIIKMOPEEP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IJMPLGOCAIG<TMInput> DNINAAJGKKI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3E8EAB0", Offset = "0x3E8DCB0", VA = "0x183E8EAB0", Slot = "4")]
		get
		{
			return default(IJMPLGOCAIG<TMInput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3E8E980", Offset = "0x3E8DB80", VA = "0x183E8E980", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3E8EA30", Offset = "0x3E8DC30", VA = "0x183E8EA30")]
	internal MPDKEJMJFCJ([In] DKMDKGGKAIH<IJMPLGOCAIG<TMOutput>>.KIBJOOMIKMJ IGMKGEOGCPB, [In] DKMDKGGKAIH<IJMPLGOCAIG<TMInput>>.KIBJOOMIKMJ DNAPMEACPDA, [In] NECMGLKNFJK<TMInput, TMOutput, TMNode> MDOJGMHFPEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3E8E7B0", Offset = "0x3E8D9B0", VA = "0x183E8E7B0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3E8E910", Offset = "0x3E8DB10", VA = "0x183E8E910", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3E8E740", Offset = "0x3E8D940", VA = "0x183E8E740", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class FAMBAGHDIOK
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2745110", Offset = "0x2744310", VA = "0x182745110")]
	public static MPDKEJMJFCJ<TMInput, TMOutput, TMNode> GOMGEEBODDD<TMInput, TMOutput, TMNode>([In] BGECIKAGOJH<TMInput, TMOutput, TMNode> EPJBLPIMDDE, IJMPLGOCAIG<TMNode> CPDCLGDPBBB)
	{
		return default(MPDKEJMJFCJ<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct CMGHLEGJDBG<TMInput, TMOutput, TMNode> : IEnumerator<IJMPLGOCAIG<TMOutput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private DKMDKGGKAIH<IJMPLGOCAIG<TMInput>>.KIBJOOMIKMJ MACIPJCOKOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private DKMDKGGKAIH<IJMPLGOCAIG<TMOutput>>.KIBJOOMIKMJ BOAMMCGAMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly AJAPODMDGBJ<TMInput, TMOutput, TMNode> IAJJLCEJFMN;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IJMPLGOCAIG<TMOutput> DNINAAJGKKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3E8EAB0", Offset = "0x3E8DCB0", VA = "0x183E8EAB0", Slot = "4")]
		get
		{
			return default(IJMPLGOCAIG<TMOutput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3E8E980", Offset = "0x3E8DB80", VA = "0x183E8E980", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3E8EA30", Offset = "0x3E8DC30", VA = "0x183E8EA30")]
	internal CMGHLEGJDBG([In] DKMDKGGKAIH<IJMPLGOCAIG<TMInput>>.KIBJOOMIKMJ ACJKAKNCBON, [In] DKMDKGGKAIH<IJMPLGOCAIG<TMOutput>>.KIBJOOMIKMJ DGCDHLPDEMN, [In] AJAPODMDGBJ<TMInput, TMOutput, TMNode> GOLPEMIKAPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3E8E7B0", Offset = "0x3E8D9B0", VA = "0x183E8E7B0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3E8E910", Offset = "0x3E8DB10", VA = "0x183E8E910", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3E8E740", Offset = "0x3E8D940", VA = "0x183E8E740", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class GHCJOBDDOFB
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x27662B0", Offset = "0x27654B0", VA = "0x1827662B0")]
	public static CMGHLEGJDBG<TMInput, TMOutput, TMNode> GOMGEEBODDD<TMInput, TMOutput, TMNode>([In] BGECIKAGOJH<TMInput, TMOutput, TMNode> EPJBLPIMDDE, IJMPLGOCAIG<TMNode> CPDCLGDPBBB)
	{
		return default(CMGHLEGJDBG<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct BGECIKAGOJH<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public AJAPODMDGBJ<TMInput, TMOutput, TMNode> IEKILAHOPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public NECMGLKNFJK<TMInput, TMOutput, TMNode> MAGEJBCGJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public GLGANGJLDBG<TMInput, TMOutput, TMNode> FKKDNGFKKNE;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4797A30", Offset = "0x4796C30", VA = "0x184797A30")]
	internal BGECIKAGOJH([In] AJAPODMDGBJ<TMInput, TMOutput, TMNode> GOLPEMIKAPA, [In] NECMGLKNFJK<TMInput, TMOutput, TMNode> MDOJGMHFPEM, [In] GLGANGJLDBG<TMInput, TMOutput, TMNode> EOPBGLABLJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4797780", Offset = "0x4796980", VA = "0x184797780")]
	public static BGECIKAGOJH<TMInput?, TMOutput?, TMNode?> GOMGEEBODDD()
	{
		return default(BGECIKAGOJH<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class EGCBONAOKJG
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x263CDD0", Offset = "0x263BFD0", VA = "0x18263CDD0")]
	public static KHIBEPFADCB? CJMGAEMJONM<TMInput, TMOutput, TMNode>([In] this BGECIKAGOJH<TMInput, TMOutput, TMNode> KPBGCHDNDLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x263C7D0", Offset = "0x263B9D0", VA = "0x18263C7D0")]
	public static BGECIKAGOJH<TMInput?, TMOutput?, TMNode?> APPDJDLGIOH<TMInput, TMOutput, TMNode>(this KHIBEPFADCB KPBGCHDNDLM)
	{
		return default(BGECIKAGOJH<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x263D3F0", Offset = "0x263C5F0", VA = "0x18263D3F0")]
	public static void JNJLPFFCJBK<TMInput, TMOutput, TMNode>(this BGECIKAGOJH<TMInput, TMOutput, TMNode> KPBGCHDNDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x263D4D0", Offset = "0x263C6D0", VA = "0x18263D4D0")]
	public static void NJMONIFGFAO<TMInput, TMOutput, TMNode>(this BGECIKAGOJH<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMOutput> CHEFAPODHDP, IJMPLGOCAIG<TMInput> EFFGIDBPDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x263D200", Offset = "0x263C400", VA = "0x18263D200")]
	public static void JHMFFMAANIB<TMInput, TMOutput, TMNode>(this BGECIKAGOJH<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMOutput> CHEFAPODHDP, IJMPLGOCAIG<TMInput> EFFGIDBPDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x263CC90", Offset = "0x263BE90", VA = "0x18263CC90")]
	public static bool BJMIEEIDPLI<TMInput, TMOutput, TMNode>([In] this BGECIKAGOJH<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMOutput> CHEFAPODHDP, IJMPLGOCAIG<TMInput> EFFGIDBPDDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x263D0D0", Offset = "0x263C2D0", VA = "0x18263D0D0")]
	public static IJMPLGOCAIG<TMNode?> FMNCBIFLIKP<TMNode, TMInput, TMOutput>(this BGECIKAGOJH<TMInput, TMOutput, TMNode> KPBGCHDNDLM)
	{
		return default(IJMPLGOCAIG<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x263CEB0", Offset = "0x263C0B0", VA = "0x18263CEB0")]
	public static void DABADHFDGIA<TMInput, TMOutput, TMNode>(this BGECIKAGOJH<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMNode> CPDCLGDPBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x263CD60", Offset = "0x263BF60", VA = "0x18263CD60")]
	public static IJMPLGOCAIG<TMInput?> BOKDGCGJDOC<TMInput, TMOutput, TMNode>(this BGECIKAGOJH<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMNode> CPDCLGDPBBB)
	{
		return default(IJMPLGOCAIG<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x263D610", Offset = "0x263C810", VA = "0x18263D610")]
	public static IJMPLGOCAIG<TMOutput?> PKLIEAMMBCH<TMOutput, TMInput, TMNode>(this BGECIKAGOJH<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMNode> CPDCLGDPBBB)
	{
		return default(IJMPLGOCAIG<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x263D450", Offset = "0x263C650", VA = "0x18263D450")]
	public static IJMPLGOCAIG<TMInput?> MKBKOMOLJPH<TMInput, TMOutput, TMNode>(this BGECIKAGOJH<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMNode> CPDCLGDPBBB, int ILNNGHKJMBD)
	{
		return default(IJMPLGOCAIG<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x263C750", Offset = "0x263B950", VA = "0x18263C750")]
	public static IJMPLGOCAIG<TMOutput?> ALCPPNIHKGD<TMOutput, TMInput, TMNode>(this BGECIKAGOJH<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMNode> CPDCLGDPBBB, int ILNNGHKJMBD)
	{
		return default(IJMPLGOCAIG<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x263CBF0", Offset = "0x263BDF0", VA = "0x18263CBF0")]
	public static void BFDCONFMJEG<TMInput, TMOutput, TMNode>(this BGECIKAGOJH<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMNode> CPDCLGDPBBB, int NOEGBMKMIHJ, int KGDHPNDELNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x263D160", Offset = "0x263C360", VA = "0x18263D160")]
	public static void GOGGOBABLLG<TMInput, TMOutput, TMNode>(this BGECIKAGOJH<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMNode> CPDCLGDPBBB, int NOEGBMKMIHJ, int KGDHPNDELNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x263CFC0", Offset = "0x263C1C0", VA = "0x18263CFC0")]
	public static void DLIEAGKJFDA<TMInput, TMOutput, TMNode>(this BGECIKAGOJH<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMInput> MPKOHKKPBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x263D530", Offset = "0x263C730", VA = "0x18263D530")]
	public static void OBDPGAHEPAK<TMInput, TMOutput, TMNode>(this BGECIKAGOJH<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMOutput> MPELNFINDJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x87D8F0", Offset = "0x87CAF0", VA = "0x18087D8F0")]
	public static OCNFGMPPOGH<TMInput?> CHIAIHNLDOB<TMInput, TMOutput, TMNode>([In] this BGECIKAGOJH<TMInput, TMOutput, TMNode> KPBGCHDNDLM)
	{
		return default(OCNFGMPPOGH<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x263D0C0", Offset = "0x263C2C0", VA = "0x18263D0C0")]
	public static OCNFGMPPOGH<TMOutput?> FIFKPCNOHBA<TMOutput, TMInput, TMNode>([In] this BGECIKAGOJH<TMInput, TMOutput, TMNode> KPBGCHDNDLM)
	{
		return default(OCNFGMPPOGH<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x263D0B0", Offset = "0x263C2B0", VA = "0x18263D0B0")]
	public static OCNFGMPPOGH<TMNode?> EKJOKLMAAMO<TMNode, TMInput, TMOutput>([In] this BGECIKAGOJH<TMInput, TMOutput, TMNode> KPBGCHDNDLM)
	{
		return default(OCNFGMPPOGH<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x263C5D0", Offset = "0x263B7D0", VA = "0x18263C5D0")]
	public static MPDKEJMJFCJ<TMInput?, TMOutput?, TMNode?> KNBDDLPKECN<TMInput, TMOutput, TMNode>([In] this BGECIKAGOJH<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMNode> EOHPLEHPKEN)
	{
		return default(MPDKEJMJFCJ<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x263C5D0", Offset = "0x263B7D0", VA = "0x18263C5D0")]
	public static CMGHLEGJDBG<TMInput?, TMOutput?, TMNode?> AAIBEKCLKFG<TMInput, TMOutput, TMNode>([In] this BGECIKAGOJH<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMNode> EOHPLEHPKEN)
	{
		return default(CMGHLEGJDBG<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x263CB40", Offset = "0x263BD40", VA = "0x18263CB40")]
	public static DNIAOFBIOEL<TMInput?, TMOutput?, TMNode?> BENPGCOOFAO<TMInput, TMOutput, TMNode>([In] this BGECIKAGOJH<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMNode> EOHPLEHPKEN)
	{
		return default(DNIAOFBIOEL<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x263C640", Offset = "0x263B840", VA = "0x18263C640")]
	public static ENLIIOGEFKL<IJMPLGOCAIG<TMInput?>, MPDKEJMJFCJ<TMInput?, TMOutput?, TMNode?>> AGJELMHGBLJ<TMInput, TMOutput, TMNode>([In] this BGECIKAGOJH<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMNode> EOHPLEHPKEN)
	{
		return default(ENLIIOGEFKL<IJMPLGOCAIG<TMInput>, MPDKEJMJFCJ<TMInput, TMOutput, TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x263D260", Offset = "0x263C460", VA = "0x18263D260")]
	public static ENLIIOGEFKL<IJMPLGOCAIG<TMNode?>, DNIAOFBIOEL<TMInput?, TMOutput?, TMNode?>> JNDPHJMAKDE<TMNode, TMInput, TMOutput>([In] this BGECIKAGOJH<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMNode> EOHPLEHPKEN)
	{
		return default(ENLIIOGEFKL<IJMPLGOCAIG<TMNode>, DNIAOFBIOEL<TMInput, TMOutput, TMNode>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct AJAPODMDGBJ<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal OCNFGMPPOGH<TMInput> OFPIJJCLLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal MHFBEOMNLGO<TMInput, IJMPLGOCAIG<TMNode>> PJNMFHKGMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal MHFBEOMNLGO<TMInput, DKMDKGGKAIH<IJMPLGOCAIG<TMOutput>>> NCIIKMOPEEP;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x375C540", Offset = "0x375B740", VA = "0x18375C540")]
	internal AJAPODMDGBJ([In] OCNFGMPPOGH<TMInput> JAKDMDNMGMO, [In] MHFBEOMNLGO<TMInput, IJMPLGOCAIG<TMNode>> EOPBGLABLJK, [In] MHFBEOMNLGO<TMInput, DKMDKGGKAIH<IJMPLGOCAIG<TMOutput>>> MDOJGMHFPEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x375C380", Offset = "0x375B580", VA = "0x18375C380")]
	internal static AJAPODMDGBJ<TMInput, TMOutput, TMNode> GOMGEEBODDD()
	{
		return default(AJAPODMDGBJ<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class NHAPDODMEHI
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x28A9470", Offset = "0x28A8670", VA = "0x1828A9470")]
	internal static LHABPIGGJDP CJMGAEMJONM<TMInput, TMOutput, TMNode>([In] this AJAPODMDGBJ<TMInput, TMOutput, TMNode> KPBGCHDNDLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x28A8D90", Offset = "0x28A7F90", VA = "0x1828A8D90")]
	internal static AJAPODMDGBJ<TMInput, TMOutput, TMNode> APPDJDLGIOH<TMInput, TMOutput, TMNode>(this LHABPIGGJDP KPBGCHDNDLM)
	{
		return default(AJAPODMDGBJ<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x28A92A0", Offset = "0x28A84A0", VA = "0x1828A92A0")]
	private static KNJNPNKNGGK CDOKOBJFELP<TMOutput>([In] this DKMDKGGKAIH<IJMPLGOCAIG<TMOutput>> KPBGCHDNDLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x28A9800", Offset = "0x28A8A00", VA = "0x1828A9800")]
	private static DKMDKGGKAIH<IJMPLGOCAIG<TMOutput>> HNHPPJLDODP<TMOutput>(this KNJNPNKNGGK KPBGCHDNDLM)
	{
		return default(DKMDKGGKAIH<IJMPLGOCAIG<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x280A070", Offset = "0x2809270", VA = "0x18280A070")]
	internal static void JNJLPFFCJBK<TMInput, TMOutput, TMNode>(this AJAPODMDGBJ<TMInput, TMOutput, TMNode> KPBGCHDNDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2809E00", Offset = "0x2809000", VA = "0x182809E00")]
	internal static IJMPLGOCAIG<TMInput> FHIEOBHMJIN<TMInput, TMOutput, TMNode>(this AJAPODMDGBJ<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMNode> DEBAEMIFHOC)
	{
		return default(IJMPLGOCAIG<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x280A480", Offset = "0x2809680", VA = "0x18280A480")]
	internal static void PFNABIFCBEO<TMInput, TMOutput, TMNode>(this AJAPODMDGBJ<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMInput> EOHPLEHPKEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x261C630", Offset = "0x261B830", VA = "0x18261C630")]
	public static bool AAFLDINKDHH<TMInput, TMOutput, TMNode>([In] this AJAPODMDGBJ<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMInput> EOHPLEHPKEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x22AC130", Offset = "0x22AB330", VA = "0x1822AC130")]
	public static int AJHKOHDNJIC<TMInput, TMOutput, TMNode>([In] this AJAPODMDGBJ<TMInput, TMOutput, TMNode> KPBGCHDNDLM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2809DE0", Offset = "0x2808FE0", VA = "0x182809DE0")]
	public static IJMPLGOCAIG<TMNode> EDBKEMHICJB<TMNode, TMInput, TMOutput>([In] this AJAPODMDGBJ<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMInput> EOHPLEHPKEN)
	{
		return default(IJMPLGOCAIG<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2764EC0", Offset = "0x27640C0", VA = "0x182764EC0")]
	public static int HOJHODBAMKJ<TMInput, TMOutput, TMNode>([In] this AJAPODMDGBJ<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMInput> EOHPLEHPKEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2764DE0", Offset = "0x2763FE0", VA = "0x182764DE0")]
	public static IJMPLGOCAIG<TMOutput> FFGJDFDKNCM<TMOutput, TMInput, TMNode>([In] this AJAPODMDGBJ<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMInput> EOHPLEHPKEN, int ILNNGHKJMBD)
	{
		return default(IJMPLGOCAIG<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x27648C0", Offset = "0x2763AC0", VA = "0x1827648C0")]
	internal static void BLGHFBMINOA<TMInput, TMOutput, TMNode>(this AJAPODMDGBJ<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMInput> EOHPLEHPKEN, IJMPLGOCAIG<TMOutput> MPELNFINDJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x27648C0", Offset = "0x2763AC0", VA = "0x1827648C0")]
	internal static void OICNMHODGBA<TMInput, TMOutput, TMNode>(this AJAPODMDGBJ<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMInput> EOHPLEHPKEN, IJMPLGOCAIG<TMOutput> MPELNFINDJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x27656C0", Offset = "0x27648C0", VA = "0x1827656C0")]
	public static DKMDKGGKAIH<IJMPLGOCAIG<TMOutput>>.KIBJOOMIKMJ OPEGOCHNBKM<TMOutput, TMInput, TMNode>([In] this AJAPODMDGBJ<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMInput> EOHPLEHPKEN)
	{
		return default(DKMDKGGKAIH<IJMPLGOCAIG<TMOutput>>.KIBJOOMIKMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x27656C0", Offset = "0x27648C0", VA = "0x1827656C0")]
	public static MNHHJHLBMPM<IJMPLGOCAIG<TMOutput>, DKMDKGGKAIH<IJMPLGOCAIG<TMOutput>>.KIBJOOMIKMJ> MBFNNEAFCNM<TMOutput, TMInput, TMNode>([In] this AJAPODMDGBJ<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMInput> EOHPLEHPKEN)
	{
		return default(MNHHJHLBMPM<IJMPLGOCAIG<TMOutput>, DKMDKGGKAIH<IJMPLGOCAIG<TMOutput>>.KIBJOOMIKMJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct GLGANGJLDBG<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal OCNFGMPPOGH<TMNode> OFPIJJCLLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal MHFBEOMNLGO<TMNode, DKMDKGGKAIH<IJMPLGOCAIG<TMInput>>> IAJJLCEJFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal MHFBEOMNLGO<TMNode, DKMDKGGKAIH<IJMPLGOCAIG<TMOutput>>> NCIIKMOPEEP;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x375C540", Offset = "0x375B740", VA = "0x18375C540")]
	internal GLGANGJLDBG([In] OCNFGMPPOGH<TMNode> JAKDMDNMGMO, [In] MHFBEOMNLGO<TMNode, DKMDKGGKAIH<IJMPLGOCAIG<TMInput>>> GOLPEMIKAPA, [In] MHFBEOMNLGO<TMNode, DKMDKGGKAIH<IJMPLGOCAIG<TMOutput>>> MDOJGMHFPEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x375C380", Offset = "0x375B580", VA = "0x18375C380")]
	internal static GLGANGJLDBG<TMInput, TMOutput, TMNode> GOMGEEBODDD()
	{
		return default(GLGANGJLDBG<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class GGEFLHHDFFL
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2764940", Offset = "0x2763B40", VA = "0x182764940")]
	internal static HDBOLFJABAH CJMGAEMJONM<TMInput, TMOutput, TMNode>([In] this GLGANGJLDBG<TMInput, TMOutput, TMNode> KPBGCHDNDLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x27643B0", Offset = "0x27635B0", VA = "0x1827643B0")]
	internal static GLGANGJLDBG<TMInput, TMOutput, TMNode> APPDJDLGIOH<TMInput, TMOutput, TMNode>(this HDBOLFJABAH KPBGCHDNDLM)
	{
		return default(GLGANGJLDBG<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2765760", Offset = "0x2764960", VA = "0x182765760")]
	private static DKCCJMLLAJC OMPAOABHAHC<TMInput>([In] this DKMDKGGKAIH<IJMPLGOCAIG<TMInput>> KPBGCHDNDLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2764F00", Offset = "0x2764100", VA = "0x182764F00")]
	private static DKMDKGGKAIH<IJMPLGOCAIG<TMInput>> IEEGGPGIAEH<TMInput>(this DKCCJMLLAJC KPBGCHDNDLM)
	{
		return default(DKMDKGGKAIH<IJMPLGOCAIG<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2765180", Offset = "0x2764380", VA = "0x182765180")]
	private static KEAGONAHFKA JJKGBBJKPAO<TMOutput>([In] this DKMDKGGKAIH<IJMPLGOCAIG<TMOutput>> KPBGCHDNDLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x27659F0", Offset = "0x2764BF0", VA = "0x1827659F0")]
	private static DKMDKGGKAIH<IJMPLGOCAIG<TMOutput>> PHFJFFCFBFG<TMOutput>(this KEAGONAHFKA KPBGCHDNDLM)
	{
		return default(DKMDKGGKAIH<IJMPLGOCAIG<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2765350", Offset = "0x2764550", VA = "0x182765350")]
	internal static void JNJLPFFCJBK<TMInput, TMOutput, TMNode>(this GLGANGJLDBG<TMInput, TMOutput, TMNode> KPBGCHDNDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2764E30", Offset = "0x2764030", VA = "0x182764E30")]
	internal static IJMPLGOCAIG<TMNode> FHIEOBHMJIN<TMNode, TMInput, TMOutput>(this GLGANGJLDBG<TMInput, TMOutput, TMNode> KPBGCHDNDLM, [In] DKMDKGGKAIH<IJMPLGOCAIG<TMInput>> GOLPEMIKAPA, [In] DKMDKGGKAIH<IJMPLGOCAIG<TMOutput>> MDOJGMHFPEM)
	{
		return default(IJMPLGOCAIG<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2765930", Offset = "0x2764B30", VA = "0x182765930")]
	internal static void PFNABIFCBEO<TMInput, TMOutput, TMNode>(this GLGANGJLDBG<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMNode> EOHPLEHPKEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x261C630", Offset = "0x261B830", VA = "0x18261C630")]
	public static bool AAFLDINKDHH<TMInput, TMOutput, TMNode>([In] this GLGANGJLDBG<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMNode> EOHPLEHPKEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x22AC130", Offset = "0x22AB330", VA = "0x1822AC130")]
	public static int AJHKOHDNJIC<TMInput, TMOutput, TMNode>([In] this GLGANGJLDBG<TMInput, TMOutput, TMNode> KPBGCHDNDLM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2764900", Offset = "0x2763B00", VA = "0x182764900")]
	public static int CJCCPGPMDHI<TMInput, TMOutput, TMNode>([In] this GLGANGJLDBG<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMNode> EOHPLEHPKEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2764EC0", Offset = "0x27640C0", VA = "0x182764EC0")]
	public static int HOJHODBAMKJ<TMInput, TMOutput, TMNode>([In] this GLGANGJLDBG<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMNode> EOHPLEHPKEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2764D50", Offset = "0x2763F50", VA = "0x182764D50")]
	public static IJMPLGOCAIG<TMInput> EALNCDGFIAD<TMInput, TMOutput, TMNode>([In] this GLGANGJLDBG<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMNode> EOHPLEHPKEN, int ILNNGHKJMBD)
	{
		return default(IJMPLGOCAIG<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2764DE0", Offset = "0x2763FE0", VA = "0x182764DE0")]
	public static IJMPLGOCAIG<TMOutput> FFGJDFDKNCM<TMOutput, TMInput, TMNode>([In] this GLGANGJLDBG<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMNode> EOHPLEHPKEN, int ILNNGHKJMBD)
	{
		return default(IJMPLGOCAIG<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2764DA0", Offset = "0x2763FA0", VA = "0x182764DA0")]
	internal static void JELHADAOHOE<TMInput, TMOutput, TMNode>(this GLGANGJLDBG<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMNode> EOHPLEHPKEN, IJMPLGOCAIG<TMInput> MPKOHKKPBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x27648C0", Offset = "0x2763AC0", VA = "0x1827648C0")]
	internal static void BLGHFBMINOA<TMInput, TMOutput, TMNode>(this GLGANGJLDBG<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMNode> EOHPLEHPKEN, IJMPLGOCAIG<TMOutput> MPELNFINDJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2765670", Offset = "0x2764870", VA = "0x182765670")]
	internal static void LFCAKNEINJJ<TMInput, TMOutput, TMNode>(this GLGANGJLDBG<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMNode> EOHPLEHPKEN, int ILNNGHKJMBD, IJMPLGOCAIG<TMInput> MPKOHKKPBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2764D00", Offset = "0x2763F00", VA = "0x182764D00")]
	internal static void DEHMBOAOCPH<TMInput, TMOutput, TMNode>(this GLGANGJLDBG<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMNode> EOHPLEHPKEN, int ILNNGHKJMBD, IJMPLGOCAIG<TMOutput> MPELNFINDJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2764DA0", Offset = "0x2763FA0", VA = "0x182764DA0")]
	internal static void EIGEKECIPLK<TMInput, TMOutput, TMNode>(this GLGANGJLDBG<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMNode> EOHPLEHPKEN, IJMPLGOCAIG<TMInput> MPKOHKKPBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x27648C0", Offset = "0x2763AC0", VA = "0x1827648C0")]
	internal static void OICNMHODGBA<TMInput, TMOutput, TMNode>(this GLGANGJLDBG<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMNode> EOHPLEHPKEN, IJMPLGOCAIG<TMOutput> MPELNFINDJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2765610", Offset = "0x2764810", VA = "0x182765610")]
	public static DKMDKGGKAIH<IJMPLGOCAIG<TMInput>>.KIBJOOMIKMJ KEKFGOPMNGH<TMInput, TMOutput, TMNode>([In] this GLGANGJLDBG<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMNode> EOHPLEHPKEN)
	{
		return default(DKMDKGGKAIH<IJMPLGOCAIG<TMInput>>.KIBJOOMIKMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x27656C0", Offset = "0x27648C0", VA = "0x1827656C0")]
	public static DKMDKGGKAIH<IJMPLGOCAIG<TMOutput>>.KIBJOOMIKMJ OPEGOCHNBKM<TMOutput, TMInput, TMNode>([In] this GLGANGJLDBG<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMNode> EOHPLEHPKEN)
	{
		return default(DKMDKGGKAIH<IJMPLGOCAIG<TMOutput>>.KIBJOOMIKMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2765610", Offset = "0x2764810", VA = "0x182765610")]
	public static MNHHJHLBMPM<IJMPLGOCAIG<TMInput>, DKMDKGGKAIH<IJMPLGOCAIG<TMInput>>.KIBJOOMIKMJ> PMIIEGLPDEN<TMInput, TMOutput, TMNode>([In] this GLGANGJLDBG<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMNode> EOHPLEHPKEN)
	{
		return default(MNHHJHLBMPM<IJMPLGOCAIG<TMInput>, DKMDKGGKAIH<IJMPLGOCAIG<TMInput>>.KIBJOOMIKMJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x27656C0", Offset = "0x27648C0", VA = "0x1827656C0")]
	public static MNHHJHLBMPM<IJMPLGOCAIG<TMOutput>, DKMDKGGKAIH<IJMPLGOCAIG<TMOutput>>.KIBJOOMIKMJ> MBFNNEAFCNM<TMOutput, TMInput, TMNode>([In] this GLGANGJLDBG<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMNode> EOHPLEHPKEN)
	{
		return default(MNHHJHLBMPM<IJMPLGOCAIG<TMOutput>, DKMDKGGKAIH<IJMPLGOCAIG<TMOutput>>.KIBJOOMIKMJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2765720", Offset = "0x2764920", VA = "0x182765720")]
	public static ENLIIOGEFKL<IJMPLGOCAIG<TMNode>, OCNFGMPPOGH<TMNode>.ILHFJAFLDHB> MHNHEPHKKGA<TMNode, TMInput, TMOutput>([In] this GLGANGJLDBG<TMInput, TMOutput, TMNode> KPBGCHDNDLM)
	{
		return default(ENLIIOGEFKL<IJMPLGOCAIG<TMNode>, OCNFGMPPOGH<TMNode>.ILHFJAFLDHB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct NECMGLKNFJK<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal OCNFGMPPOGH<TMOutput> OFPIJJCLLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal MHFBEOMNLGO<TMOutput, IJMPLGOCAIG<TMNode>> PJNMFHKGMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal MHFBEOMNLGO<TMOutput, DKMDKGGKAIH<IJMPLGOCAIG<TMInput>>> IAJJLCEJFMN;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x375C540", Offset = "0x375B740", VA = "0x18375C540")]
	internal NECMGLKNFJK([In] OCNFGMPPOGH<TMOutput> JAKDMDNMGMO, [In] MHFBEOMNLGO<TMOutput, IJMPLGOCAIG<TMNode>> EOPBGLABLJK, [In] MHFBEOMNLGO<TMOutput, DKMDKGGKAIH<IJMPLGOCAIG<TMInput>>> GOLPEMIKAPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x375C380", Offset = "0x375B580", VA = "0x18375C380")]
	internal static NECMGLKNFJK<TMInput, TMOutput, TMNode> GOMGEEBODDD()
	{
		return default(NECMGLKNFJK<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class KDPPAIMEGFM
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2809A50", Offset = "0x2808C50", VA = "0x182809A50")]
	internal static OBFMGALHPIP CJMGAEMJONM<TMInput, TMOutput, TMNode>([In] this NECMGLKNFJK<TMInput, TMOutput, TMNode> KPBGCHDNDLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2809540", Offset = "0x2808740", VA = "0x182809540")]
	internal static NECMGLKNFJK<TMInput, TMOutput, TMNode> APPDJDLGIOH<TMInput, TMOutput, TMNode>(this OBFMGALHPIP KPBGCHDNDLM)
	{
		return default(NECMGLKNFJK<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2809EA0", Offset = "0x28090A0", VA = "0x182809EA0")]
	private static KINHNOMCHJJ ILFGBDLKHHK<TMInput>([In] this DKMDKGGKAIH<IJMPLGOCAIG<TMInput>> KPBGCHDNDLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x280A200", Offset = "0x2809400", VA = "0x18280A200")]
	private static DKMDKGGKAIH<IJMPLGOCAIG<TMInput>> MDNJIFJKHPO<TMInput>(this KINHNOMCHJJ KPBGCHDNDLM)
	{
		return default(DKMDKGGKAIH<IJMPLGOCAIG<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x280A070", Offset = "0x2809270", VA = "0x18280A070")]
	internal static void JNJLPFFCJBK<TMInput, TMOutput, TMNode>(this NECMGLKNFJK<TMInput, TMOutput, TMNode> KPBGCHDNDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2809E00", Offset = "0x2809000", VA = "0x182809E00")]
	internal static IJMPLGOCAIG<TMOutput> FHIEOBHMJIN<TMOutput, TMInput, TMNode>(this NECMGLKNFJK<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMNode> DEBAEMIFHOC)
	{
		return default(IJMPLGOCAIG<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x280A480", Offset = "0x2809680", VA = "0x18280A480")]
	internal static void PFNABIFCBEO<TMInput, TMOutput, TMNode>(this NECMGLKNFJK<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMOutput> EOHPLEHPKEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x261C630", Offset = "0x261B830", VA = "0x18261C630")]
	public static bool AAFLDINKDHH<TMInput, TMOutput, TMNode>([In] this NECMGLKNFJK<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMOutput> EOHPLEHPKEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x22AC130", Offset = "0x22AB330", VA = "0x1822AC130")]
	public static int AJHKOHDNJIC<TMInput, TMOutput, TMNode>([In] this NECMGLKNFJK<TMInput, TMOutput, TMNode> KPBGCHDNDLM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2809DE0", Offset = "0x2808FE0", VA = "0x182809DE0")]
	public static IJMPLGOCAIG<TMNode> EDBKEMHICJB<TMNode, TMInput, TMOutput>([In] this NECMGLKNFJK<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMOutput> EOHPLEHPKEN)
	{
		return default(IJMPLGOCAIG<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2764EC0", Offset = "0x27640C0", VA = "0x182764EC0")]
	public static int CJCCPGPMDHI<TMInput, TMOutput, TMNode>([In] this NECMGLKNFJK<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMOutput> EOHPLEHPKEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2764DE0", Offset = "0x2763FE0", VA = "0x182764DE0")]
	public static IJMPLGOCAIG<TMInput> EALNCDGFIAD<TMInput, TMOutput, TMNode>([In] this NECMGLKNFJK<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMOutput> EOHPLEHPKEN, int ILNNGHKJMBD)
	{
		return default(IJMPLGOCAIG<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x27648C0", Offset = "0x2763AC0", VA = "0x1827648C0")]
	internal static void JELHADAOHOE<TMInput, TMOutput, TMNode>(this NECMGLKNFJK<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMOutput> EOHPLEHPKEN, IJMPLGOCAIG<TMInput> MPKOHKKPBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x27648C0", Offset = "0x2763AC0", VA = "0x1827648C0")]
	internal static void EIGEKECIPLK<TMInput, TMOutput, TMNode>(this NECMGLKNFJK<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMOutput> EOHPLEHPKEN, IJMPLGOCAIG<TMInput> MPKOHKKPBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x27656C0", Offset = "0x27648C0", VA = "0x1827656C0")]
	public static DKMDKGGKAIH<IJMPLGOCAIG<TMInput>>.KIBJOOMIKMJ KEKFGOPMNGH<TMInput, TMOutput, TMNode>([In] this NECMGLKNFJK<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMOutput> EOHPLEHPKEN)
	{
		return default(DKMDKGGKAIH<IJMPLGOCAIG<TMInput>>.KIBJOOMIKMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x27656C0", Offset = "0x27648C0", VA = "0x1827656C0")]
	public static MNHHJHLBMPM<IJMPLGOCAIG<TMInput>, DKMDKGGKAIH<IJMPLGOCAIG<TMInput>>.KIBJOOMIKMJ> PMIIEGLPDEN<TMInput, TMOutput, TMNode>([In] this NECMGLKNFJK<TMInput, TMOutput, TMNode> KPBGCHDNDLM, IJMPLGOCAIG<TMOutput> EOHPLEHPKEN)
	{
		return default(MNHHJHLBMPM<IJMPLGOCAIG<TMInput>, DKMDKGGKAIH<IJMPLGOCAIG<TMInput>>.KIBJOOMIKMJ>);
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
