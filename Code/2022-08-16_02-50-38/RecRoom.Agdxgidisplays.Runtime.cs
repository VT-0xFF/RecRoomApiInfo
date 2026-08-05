using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class OAINGJMKCBH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum LJMHJAOPPKD
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void NFKDAJONALF(IntPtr KCDJHPHCFKN, int AABEJHHLOHL, int JAKAFACMGAL);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int BHEAIKPOIBM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5847AD0", Offset = "0x58466D0", VA = "0x185847AD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5847950", Offset = "0x5846550", VA = "0x185847950")]
	private static extern void DCEBBMLNBOF(NFKDAJONALF HGFJMMOGKFF);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5847D30", Offset = "0x5846930", VA = "0x185847D30")]
	[MonoPInvokeCallback(typeof(NFKDAJONALF))]
	private static void KDDMLNLDDIL(IntPtr KCDJHPHCFKN, int AABEJHHLOHL, int JAKAFACMGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x58478E0", Offset = "0x58464E0", VA = "0x1858478E0")]
	private static extern void CMEOLNMPNEL();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x58479E0", Offset = "0x58465E0", VA = "0x1858479E0")]
	private static extern void MAEOEJKEMDO();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5847AD0", Offset = "0x58466D0", VA = "0x185847AD0")]
	private static extern int EGENPHEPOLE();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5847A50", Offset = "0x5846650", VA = "0x185847A50")]
	private static extern int ECLCLGGDOAL(int PHGKKLLIIFD);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5847F50", Offset = "0x5846B50", VA = "0x185847F50")]
	private static extern int PBHNKJBLHMF(int PHGKKLLIIFD);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5847ED0", Offset = "0x5846AD0", VA = "0x185847ED0")]
	private static extern int ODJAPPOPCJD(int PHGKKLLIIFD);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5847E50", Offset = "0x5846A50", VA = "0x185847E50")]
	private static extern int NLIBBCLEJHP(int PHGKKLLIIFD);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5847FD0", Offset = "0x5846BD0", VA = "0x185847FD0")]
	public OAINGJMKCBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x58479E0", Offset = "0x58465E0", VA = "0x1858479E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5847B40", Offset = "0x5846740", VA = "0x185847B40")]
	public Rect EHAEPCEHGLM(int DCHBBBHHIJO)
	{
		return default(Rect);
	}
}
namespace Cpp2IlInjected;

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
