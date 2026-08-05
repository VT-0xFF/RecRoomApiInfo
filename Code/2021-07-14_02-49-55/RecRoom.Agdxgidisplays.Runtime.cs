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
		[Cpp2IlInjected.Address(RVA = "0x382C380", Offset = "0x382B580", VA = "0x18382C380")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x382C570", Offset = "0x382B770", VA = "0x18382C570")]
	private static extern void LGEKMAJFMEI(GBEKAMNPPML AFLPGGJMPOE);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x382C860", Offset = "0x382BA60", VA = "0x18382C860")]
	[MonoPInvokeCallback(typeof(GBEKAMNPPML))]
	private static void OPKIMFDKGPL(IntPtr JMFLHIIJFKL, int OJJOHDIFMEG, int BEKLICEKJOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x382C7F0", Offset = "0x382B9F0", VA = "0x18382C7F0")]
	private static extern void OFFLOPLJBBG();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x382C310", Offset = "0x382B510", VA = "0x18382C310")]
	private static extern void LKDCFBKMMLH();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x382C380", Offset = "0x382B580", VA = "0x18382C380")]
	private static extern int MBOOCHGIAGI();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x382C3F0", Offset = "0x382B5F0", VA = "0x18382C3F0")]
	private static extern int FINLIHDFGIN(int ENJEOLBEALP);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x382C470", Offset = "0x382B670", VA = "0x18382C470")]
	private static extern int HMOGELDGKLI(int ENJEOLBEALP);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x382C290", Offset = "0x382B490", VA = "0x18382C290")]
	private static extern int DCEGGGIAAFG(int ENJEOLBEALP);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x382C4F0", Offset = "0x382B6F0", VA = "0x18382C4F0")]
	private static extern int LDPMFJPGMOA(int ENJEOLBEALP);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x382C980", Offset = "0x382BB80", VA = "0x18382C980")]
	public CAGFADDGJBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x382C310", Offset = "0x382B510", VA = "0x18382C310", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x382C600", Offset = "0x382B800", VA = "0x18382C600")]
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
