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
		[Cpp2IlInjected.Address(RVA = "0x1342FC0", Offset = "0x1341DC0", VA = "0x181342FC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x13431B0", Offset = "0x1341FB0", VA = "0x1813431B0")]
	private static extern void LGEKMAJFMEI(GBEKAMNPPML AFLPGGJMPOE);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x13434A0", Offset = "0x13422A0", VA = "0x1813434A0")]
	[MonoPInvokeCallback(typeof(GBEKAMNPPML))]
	private static void OPKIMFDKGPL(IntPtr JMFLHIIJFKL, int OJJOHDIFMEG, int BEKLICEKJOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1343430", Offset = "0x1342230", VA = "0x181343430")]
	private static extern void OFFLOPLJBBG();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1342F50", Offset = "0x1341D50", VA = "0x181342F50")]
	private static extern void LKDCFBKMMLH();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1342FC0", Offset = "0x1341DC0", VA = "0x181342FC0")]
	private static extern int MBOOCHGIAGI();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1343030", Offset = "0x1341E30", VA = "0x181343030")]
	private static extern int FINLIHDFGIN(int ENJEOLBEALP);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x13430B0", Offset = "0x1341EB0", VA = "0x1813430B0")]
	private static extern int HMOGELDGKLI(int ENJEOLBEALP);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1342ED0", Offset = "0x1341CD0", VA = "0x181342ED0")]
	private static extern int DCEGGGIAAFG(int ENJEOLBEALP);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1343130", Offset = "0x1341F30", VA = "0x181343130")]
	private static extern int LDPMFJPGMOA(int ENJEOLBEALP);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x13435C0", Offset = "0x13423C0", VA = "0x1813435C0")]
	public CAGFADDGJBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1342F50", Offset = "0x1341D50", VA = "0x181342F50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1343240", Offset = "0x1342040", VA = "0x181343240")]
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
