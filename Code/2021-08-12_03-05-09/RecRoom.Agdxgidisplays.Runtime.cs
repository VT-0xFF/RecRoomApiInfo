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
		[Cpp2IlInjected.Address(RVA = "0x38F6460", Offset = "0x38F5460", VA = "0x1838F6460")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x38F6650", Offset = "0x38F5650", VA = "0x1838F6650")]
	private static extern void LGEKMAJFMEI(GBEKAMNPPML AFLPGGJMPOE);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x38F6940", Offset = "0x38F5940", VA = "0x1838F6940")]
	[MonoPInvokeCallback(typeof(GBEKAMNPPML))]
	private static void OPKIMFDKGPL(IntPtr JMFLHIIJFKL, int OJJOHDIFMEG, int BEKLICEKJOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x38F68D0", Offset = "0x38F58D0", VA = "0x1838F68D0")]
	private static extern void OFFLOPLJBBG();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x38F63F0", Offset = "0x38F53F0", VA = "0x1838F63F0")]
	private static extern void LKDCFBKMMLH();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x38F6460", Offset = "0x38F5460", VA = "0x1838F6460")]
	private static extern int MBOOCHGIAGI();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x38F64D0", Offset = "0x38F54D0", VA = "0x1838F64D0")]
	private static extern int FINLIHDFGIN(int ENJEOLBEALP);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x38F6550", Offset = "0x38F5550", VA = "0x1838F6550")]
	private static extern int HMOGELDGKLI(int ENJEOLBEALP);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x38F6370", Offset = "0x38F5370", VA = "0x1838F6370")]
	private static extern int DCEGGGIAAFG(int ENJEOLBEALP);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x38F65D0", Offset = "0x38F55D0", VA = "0x1838F65D0")]
	private static extern int LDPMFJPGMOA(int ENJEOLBEALP);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x38F6A60", Offset = "0x38F5A60", VA = "0x1838F6A60")]
	public CAGFADDGJBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x38F63F0", Offset = "0x38F53F0", VA = "0x1838F63F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x38F66E0", Offset = "0x38F56E0", VA = "0x1838F66E0")]
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
