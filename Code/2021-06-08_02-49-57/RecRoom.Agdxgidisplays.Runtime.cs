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
		[Cpp2IlInjected.Address(RVA = "0x366B5D0", Offset = "0x366A3D0", VA = "0x18366B5D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x366B7C0", Offset = "0x366A5C0", VA = "0x18366B7C0")]
	private static extern void LGEKMAJFMEI(GBEKAMNPPML AFLPGGJMPOE);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x366BAB0", Offset = "0x366A8B0", VA = "0x18366BAB0")]
	[MonoPInvokeCallback(typeof(GBEKAMNPPML))]
	private static void OPKIMFDKGPL(IntPtr JMFLHIIJFKL, int OJJOHDIFMEG, int BEKLICEKJOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x366BA40", Offset = "0x366A840", VA = "0x18366BA40")]
	private static extern void OFFLOPLJBBG();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x366B560", Offset = "0x366A360", VA = "0x18366B560")]
	private static extern void LKDCFBKMMLH();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x366B5D0", Offset = "0x366A3D0", VA = "0x18366B5D0")]
	private static extern int MBOOCHGIAGI();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x366B640", Offset = "0x366A440", VA = "0x18366B640")]
	private static extern int FINLIHDFGIN(int ENJEOLBEALP);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x366B6C0", Offset = "0x366A4C0", VA = "0x18366B6C0")]
	private static extern int HMOGELDGKLI(int ENJEOLBEALP);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x366B4E0", Offset = "0x366A2E0", VA = "0x18366B4E0")]
	private static extern int DCEGGGIAAFG(int ENJEOLBEALP);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x366B740", Offset = "0x366A540", VA = "0x18366B740")]
	private static extern int LDPMFJPGMOA(int ENJEOLBEALP);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x366BBD0", Offset = "0x366A9D0", VA = "0x18366BBD0")]
	public CAGFADDGJBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x366B560", Offset = "0x366A360", VA = "0x18366B560", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x366B850", Offset = "0x366A650", VA = "0x18366B850")]
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
