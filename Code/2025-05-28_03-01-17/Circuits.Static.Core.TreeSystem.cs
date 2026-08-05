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
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2845F30", Offset = "0x2844D30", VA = "0x182845F30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA34390", Offset = "0xA33190", VA = "0x180A34390")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA343D0", Offset = "0xA331D0", VA = "0x180A343D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct GJNCJEPGDBL<TMNode> : IEnumerator<BIHBDMOHDCK<TMNode>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly BIHBDMOHDCK<TMNode> FBCOELFHOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly PKGDJDPCMOK<TMNode, BIHBDMOHDCK<TMNode>> DLGJGNAGDEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private BIHBDMOHDCK<TMNode> LIIJMFHLBGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private bool ECCEODBMOPK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public BIHBDMOHDCK<TMNode> CKHLHELFBCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA0D990", Offset = "0xA0C790", VA = "0x180A0D990", Slot = "4")]
		get
		{
			return default(BIHBDMOHDCK<TMNode>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4BCF770", Offset = "0x4BCE570", VA = "0x184BCF770", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4BCF7E0", Offset = "0x4BCE5E0", VA = "0x184BCF7E0")]
	internal GJNCJEPGDBL(BIHBDMOHDCK<TMNode> GNMMLFONKNO, [In] PKGDJDPCMOK<TMNode, BIHBDMOHDCK<TMNode>> GEGMKOHLNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4BCF4F0", Offset = "0x4BCE2F0", VA = "0x184BCF4F0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4BCF760", Offset = "0x4BCE560", VA = "0x184BCF760", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct LPGLILCIAFK<TMNode>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal static readonly BIHBDMOHDCK<TMNode> EBKAGJIIMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal GFAEBDOOJCH<TMNode> AIJEBFBLBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal PKGDJDPCMOK<TMNode, BIHBDMOHDCK<TMNode>> DLGJGNAGDEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal PKGDJDPCMOK<TMNode, ILLOCPJIIID<BIHBDMOHDCK<TMNode>>> IOBGIHFEKBM;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x283CDF0", Offset = "0x283BBF0", VA = "0x18283CDF0")]
	internal LPGLILCIAFK([In] GFAEBDOOJCH<TMNode> BJJOHONFGIJ, [In] PKGDJDPCMOK<TMNode, BIHBDMOHDCK<TMNode>> GEGMKOHLNDI, [In] PKGDJDPCMOK<TMNode, ILLOCPJIIID<BIHBDMOHDCK<TMNode>>> BNOOGMAKJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x51B5180", Offset = "0x51B3F80", VA = "0x1851B5180")]
	public static LPGLILCIAFK<TMNode> NBEICDCLFEE()
	{
		return default(LPGLILCIAFK<TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class GGJPBNAOCLL
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3905010", Offset = "0x3903E10", VA = "0x183905010")]
	public static GKPDFDDGMAG KIDMEGDOMCG<TMNode>([In] this LPGLILCIAFK<TMNode> FPFHIDBMBMI) where TMNode : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x39049A0", Offset = "0x39037A0", VA = "0x1839049A0")]
	internal static OFNPOLNDCOE IBBKDDIOMBN<TMNode>([In] this ILLOCPJIIID<BIHBDMOHDCK<TMNode>> FPFHIDBMBMI) where TMNode : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3904540", Offset = "0x3903340", VA = "0x183904540")]
	internal static ILLOCPJIIID<BIHBDMOHDCK<TMNode>> AGHNCKKPBPM<TMNode>(this OFNPOLNDCOE FPFHIDBMBMI) where TMNode : notnull
	{
		return default(ILLOCPJIIID<BIHBDMOHDCK<TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3904E20", Offset = "0x3903C20", VA = "0x183904E20")]
	public static void KCGBACPBOON<TMNode>(this LPGLILCIAFK<TMNode> FPFHIDBMBMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3904800", Offset = "0x3903600", VA = "0x183904800")]
	public static bool APHGFBFFFFI<TMNode>([In] this LPGLILCIAFK<TMNode> FPFHIDBMBMI, BIHBDMOHDCK<TMNode> FONJFDCCINO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3904C50", Offset = "0x3903A50", VA = "0x183904C50")]
	public static int IIIAIBJFBFG<TMNode>([In] this LPGLILCIAFK<TMNode> FPFHIDBMBMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3904810", Offset = "0x3903610", VA = "0x183904810")]
	public static BIHBDMOHDCK<TMNode?> CFNDECDNKIB<TMNode>(this LPGLILCIAFK<TMNode> FPFHIDBMBMI)
	{
		return default(BIHBDMOHDCK<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x39059F0", Offset = "0x39047F0", VA = "0x1839059F0")]
	public static BIHBDMOHDCK<TMNode?> PEPFPFLHLEE<TMNode>(this LPGLILCIAFK<TMNode> FPFHIDBMBMI, BIHBDMOHDCK<TMNode> BOGJJGPKPIJ)
	{
		return default(BIHBDMOHDCK<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3905680", Offset = "0x3904480", VA = "0x183905680")]
	public static void OJKDNIEEGBG<TMNode>(this LPGLILCIAFK<TMNode> FPFHIDBMBMI, BIHBDMOHDCK<TMNode> FONJFDCCINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3905410", Offset = "0x3904210", VA = "0x183905410")]
	public static bool LFGLGHMNANE<TMNode>([In] this LPGLILCIAFK<TMNode> FPFHIDBMBMI, BIHBDMOHDCK<TMNode> FONJFDCCINO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3777E40", Offset = "0x3776C40", VA = "0x183777E40")]
	public static BIHBDMOHDCK<TMNode?> DLKCDFLPOJC<TMNode>([In] this LPGLILCIAFK<TMNode> FPFHIDBMBMI, BIHBDMOHDCK<TMNode> FONJFDCCINO)
	{
		return default(BIHBDMOHDCK<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3904D30", Offset = "0x3903B30", VA = "0x183904D30")]
	public static BIHBDMOHDCK<TMNode?>? JAJKBBPGEDE<TMNode>([In] this LPGLILCIAFK<TMNode> FPFHIDBMBMI, BIHBDMOHDCK<TMNode> FONJFDCCINO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x39054D0", Offset = "0x39042D0", VA = "0x1839054D0")]
	public static void LMDBPBKBEOE<TMNode>(this LPGLILCIAFK<TMNode> FPFHIDBMBMI, BIHBDMOHDCK<TMNode> FONJFDCCINO, BIHBDMOHDCK<TMNode> CIPKHFNKANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3904910", Offset = "0x3903710", VA = "0x183904910")]
	public static BCGNNKNFCIJ<BIHBDMOHDCK<TMNode?>, ILLOCPJIIID<BIHBDMOHDCK<TMNode?>>.CECKELDNJIH> FOFKKHMBCOH<TMNode>([In] this LPGLILCIAFK<TMNode> FPFHIDBMBMI, BIHBDMOHDCK<TMNode> FONJFDCCINO)
	{
		return default(BCGNNKNFCIJ<BIHBDMOHDCK<TMNode>, ILLOCPJIIID<BIHBDMOHDCK<TMNode>>.CECKELDNJIH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xCA1030", Offset = "0xC9FE30", VA = "0x180CA1030")]
	public static GFAEBDOOJCH<TMNode?> LLAHDDOCPOG<TMNode>([In] this LPGLILCIAFK<TMNode> FPFHIDBMBMI)
	{
		return default(GFAEBDOOJCH<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3777E70", Offset = "0x3776C70", VA = "0x183777E70")]
	public static GFAEBDOOJCH<TMNode?>.IDLFCINOLLP PHEMDOOJNPF<TMNode>([In] this LPGLILCIAFK<TMNode> FPFHIDBMBMI)
	{
		return default(GFAEBDOOJCH<TMNode>.IDLFCINOLLP);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x377A730", Offset = "0x3779530", VA = "0x18377A730")]
	public static BFALJONNEBA<BIHBDMOHDCK<TMNode?>, GFAEBDOOJCH<TMNode?>.IDLFCINOLLP> KMNNOIMBCHO<TMNode>([In] this LPGLILCIAFK<TMNode> FPFHIDBMBMI)
	{
		return default(BFALJONNEBA<BIHBDMOHDCK<TMNode>, GFAEBDOOJCH<TMNode>.IDLFCINOLLP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3904C60", Offset = "0x3903A60", VA = "0x183904C60")]
	public static bool IMIIFPLFMMP<TMNode>([In] this LPGLILCIAFK<TMNode> FPFHIDBMBMI, BIHBDMOHDCK<TMNode> BINEDJHADMC, BIHBDMOHDCK<TMNode> DGLJECBLJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3904BA0", Offset = "0x39039A0", VA = "0x183904BA0")]
	public static BFALJONNEBA<BIHBDMOHDCK<TMNode?>, GJNCJEPGDBL<TMNode?>> ICOCLHEJOED<TMNode>([In] this LPGLILCIAFK<TMNode> FPFHIDBMBMI, BIHBDMOHDCK<TMNode> BINEDJHADMC)
	{
		return default(BFALJONNEBA<BIHBDMOHDCK<TMNode>, GJNCJEPGDBL<TMNode>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class LPCOGBLCLME
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x39FD840", Offset = "0x39FC640", VA = "0x1839FD840")]
	public static LPGLILCIAFK<TMNode> LGDBIGPAFJK<TMNode>(this GKPDFDDGMAG FPFHIDBMBMI) where TMNode : notnull
	{
		return default(LPGLILCIAFK<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2845D40", Offset = "0x2844B40", VA = "0x182845D40")]
	public static void OJKDNIEEGBG(this GKPDFDDGMAG FPFHIDBMBMI, int FONJFDCCINO)
	{
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
