using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class MCOJNDHOHOD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum ECKPKABJKMK
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void BOAAHKGHNBI(IntPtr FLPDPHNPDPK, int GGIJOHIPOOO, int BJJIICOOBAP);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int IGGEPAFMOEM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7CF4D50", Offset = "0x7CF3550", VA = "0x187CF4D50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7CF4DC0", Offset = "0x7CF35C0", VA = "0x187CF4DC0")]
	private static extern void CBFIEAAHJIG(BOAAHKGHNBI LKHIOLGKDDF);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7CF5030", Offset = "0x7CF3830", VA = "0x187CF5030")]
	[MonoPInvokeCallback(typeof(BOAAHKGHNBI))]
	private static void PCPJFGHGNBO(IntPtr FLPDPHNPDPK, int GGIJOHIPOOO, int BJJIICOOBAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7CF4FC0", Offset = "0x7CF37C0", VA = "0x187CF4FC0")]
	private static extern void IEAMPCKAMFG();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7CF4E50", Offset = "0x7CF3650", VA = "0x187CF4E50")]
	private static extern void DKHEJGAPHJA();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7CF4D50", Offset = "0x7CF3550", VA = "0x187CF4D50")]
	private static extern int BMAIAGNELAC();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7CF4F40", Offset = "0x7CF3740", VA = "0x187CF4F40")]
	private static extern int EFDOMCOAMGH(int EBHOIBHGECB);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7CF5130", Offset = "0x7CF3930", VA = "0x187CF5130")]
	private static extern int PGKEOAGMBCN(int EBHOIBHGECB);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7CF4EC0", Offset = "0x7CF36C0", VA = "0x187CF4EC0")]
	private static extern int DMJKFMMJJIF(int EBHOIBHGECB);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7CF4AE0", Offset = "0x7CF32E0", VA = "0x187CF4AE0")]
	private static extern int BJEGAGMKPAF(int EBHOIBHGECB);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7CF51B0", Offset = "0x7CF39B0", VA = "0x187CF51B0")]
	public MCOJNDHOHOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7CF4E50", Offset = "0x7CF3650", VA = "0x187CF4E50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7CF4B60", Offset = "0x7CF3360", VA = "0x187CF4B60")]
	public Rect BLHDFMCAAKA(int GOHNNKLOEHE)
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
