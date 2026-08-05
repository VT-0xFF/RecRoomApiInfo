using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class CAGFADDGJBJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum DANJPLIBCOM
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void GBEKAMNPPML(IntPtr JMFLHIIJFKL, int OJJOHDIFMEG, int BEKLICEKJOH);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int AKOBJDKPGOM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x122EA60", Offset = "0x122DA60", VA = "0x18122EA60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x122EC50", Offset = "0x122DC50", VA = "0x18122EC50")]
	private static extern void LGEKMAJFMEI(GBEKAMNPPML AFLPGGJMPOE);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x122EF40", Offset = "0x122DF40", VA = "0x18122EF40")]
	[MonoPInvokeCallback(typeof(GBEKAMNPPML))]
	private static void OPKIMFDKGPL(IntPtr JMFLHIIJFKL, int OJJOHDIFMEG, int BEKLICEKJOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x122EED0", Offset = "0x122DED0", VA = "0x18122EED0")]
	private static extern void OFFLOPLJBBG();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x122E9F0", Offset = "0x122D9F0", VA = "0x18122E9F0")]
	private static extern void LKDCFBKMMLH();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x122EA60", Offset = "0x122DA60", VA = "0x18122EA60")]
	private static extern int MBOOCHGIAGI();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x122EAD0", Offset = "0x122DAD0", VA = "0x18122EAD0")]
	private static extern int FINLIHDFGIN(int ENJEOLBEALP);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x122EB50", Offset = "0x122DB50", VA = "0x18122EB50")]
	private static extern int HMOGELDGKLI(int ENJEOLBEALP);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x122E970", Offset = "0x122D970", VA = "0x18122E970")]
	private static extern int DCEGGGIAAFG(int ENJEOLBEALP);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x122EBD0", Offset = "0x122DBD0", VA = "0x18122EBD0")]
	private static extern int LDPMFJPGMOA(int ENJEOLBEALP);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x122F060", Offset = "0x122E060", VA = "0x18122F060")]
	public CAGFADDGJBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x122E9F0", Offset = "0x122D9F0", VA = "0x18122E9F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x122ECE0", Offset = "0x122DCE0", VA = "0x18122ECE0")]
	public Rect MCLCBFKAEDJ(int BBBIGDIHJLP)
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
