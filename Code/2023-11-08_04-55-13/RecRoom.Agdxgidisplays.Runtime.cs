using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class FBIFMAEHKJD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum BIFMACOPIHI
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void CMIFBHKMBEH(IntPtr MGDLKMJIAPA, int ICPPKLAMHFE, int ECJHBIDKMDP);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int LHMACIPLAKM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5CE8A20", Offset = "0x5CE7820", VA = "0x185CE8A20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8A90", Offset = "0x5CE7890", VA = "0x185CE8A90")]
	private static extern void GFNDINJFOCN(CMIFBHKMBEH PJJEKPONKPF);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8650", Offset = "0x5CE7450", VA = "0x185CE8650")]
	[MonoPInvokeCallback(typeof(CMIFBHKMBEH))]
	private static void APLPGAFGAJL(IntPtr MGDLKMJIAPA, int ICPPKLAMHFE, int ECJHBIDKMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8750", Offset = "0x5CE7550", VA = "0x185CE8750")]
	private static extern void CAKCEPELMIL();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5CE89B0", Offset = "0x5CE77B0", VA = "0x185CE89B0")]
	private static extern void ICNFLNGJCLD();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8A20", Offset = "0x5CE7820", VA = "0x185CE8A20")]
	private static extern int GFIDGCMGDKO();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8BA0", Offset = "0x5CE79A0", VA = "0x185CE8BA0")]
	private static extern int NHHCCJMAJIH(int JPODHBJFPKM);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8C20", Offset = "0x5CE7A20", VA = "0x185CE8C20")]
	private static extern int OLHBAMEFODD(int JPODHBJFPKM);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5CE85D0", Offset = "0x5CE73D0", VA = "0x185CE85D0")]
	private static extern int AFFJJECFHHK(int JPODHBJFPKM);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8B20", Offset = "0x5CE7920", VA = "0x185CE8B20")]
	private static extern int JKJNOBAOKLC(int JPODHBJFPKM);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8CA0", Offset = "0x5CE7AA0", VA = "0x185CE8CA0")]
	public FBIFMAEHKJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5CE89B0", Offset = "0x5CE77B0", VA = "0x185CE89B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5CE87C0", Offset = "0x5CE75C0", VA = "0x185CE87C0")]
	public Rect DJOIDDPJLAJ(int IHDAKOHKLLA)
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
