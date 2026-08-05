using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class DGOLFDIBOKC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum PKILCPJLFMB
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void DEPEAHOKFDI(IntPtr MNBFBMPNALN, int BGJKLECOEBO, int PDBJEALHECF);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int LFOIJOIJNGD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4BFEA40", Offset = "0x4BFDA40", VA = "0x184BFEA40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4BFE940", Offset = "0x4BFD940", VA = "0x184BFE940")]
	private static extern void AIJNKJCJBME(DEPEAHOKFDI JKHIBJGOJLH);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4BFEAB0", Offset = "0x4BFDAB0", VA = "0x184BFEAB0")]
	[MonoPInvokeCallback(typeof(DEPEAHOKFDI))]
	private static void DIKCLFMGFEB(IntPtr MNBFBMPNALN, int BGJKLECOEBO, int PDBJEALHECF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4BFE9D0", Offset = "0x4BFD9D0", VA = "0x184BFE9D0")]
	private static extern void AMFLIFGPNGM();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4BFEBD0", Offset = "0x4BFDBD0", VA = "0x184BFEBD0")]
	private static extern void JCGDCDCDDLG();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4BFEA40", Offset = "0x4BFDA40", VA = "0x184BFEA40")]
	private static extern int MKDPKEHGJEA();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4BFEDC0", Offset = "0x4BFDDC0", VA = "0x184BFEDC0")]
	private static extern int ONDBMGPLGGE(int IKMEJIEPFCI);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4BFECC0", Offset = "0x4BFDCC0", VA = "0x184BFECC0")]
	private static extern int KMLEPCHDHMK(int IKMEJIEPFCI);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4BFEC40", Offset = "0x4BFDC40", VA = "0x184BFEC40")]
	private static extern int HFBHDIMCHKL(int IKMEJIEPFCI);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4BFED40", Offset = "0x4BFDD40", VA = "0x184BFED40")]
	private static extern int LDPFMHKANIM(int IKMEJIEPFCI);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4BFF030", Offset = "0x4BFE030", VA = "0x184BFF030")]
	public DGOLFDIBOKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4BFEBD0", Offset = "0x4BFDBD0", VA = "0x184BFEBD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4BFEE40", Offset = "0x4BFDE40", VA = "0x184BFEE40")]
	public Rect PNAJBJPEKNI(int PGHKAPJGIAG)
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
