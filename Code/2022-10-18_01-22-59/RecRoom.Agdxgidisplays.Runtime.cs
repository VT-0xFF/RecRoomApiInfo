using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class JOGEALJCPNK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum EDAAHIHOPOB
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void DFCNNKNPPMM(IntPtr NMKJPBEONAN, int MNKEEJPGFOP, int JOEDFCJACJF);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int INCDIFGFCGI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5E9EF10", Offset = "0x5E9DF10", VA = "0x185E9EF10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5E9EBF0", Offset = "0x5E9DBF0", VA = "0x185E9EBF0")]
	private static extern void DJBEBIBFEDI(DFCNNKNPPMM GKAOJENLDLL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5E9ECF0", Offset = "0x5E9DCF0", VA = "0x185E9ECF0")]
	[MonoPInvokeCallback(typeof(DFCNNKNPPMM))]
	private static void FPOPGJBHHJD(IntPtr NMKJPBEONAN, int MNKEEJPGFOP, int JOEDFCJACJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E9EEA0", Offset = "0x5E9DEA0", VA = "0x185E9EEA0")]
	private static extern void ILMEFAAGLOH();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E9EC80", Offset = "0x5E9DC80", VA = "0x185E9EC80")]
	private static extern void DMFGCMHBPEA();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E9EF10", Offset = "0x5E9DF10", VA = "0x185E9EF10")]
	private static extern int JDKLEDPGJDN();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5E9EE20", Offset = "0x5E9DE20", VA = "0x185E9EE20")]
	private static extern int HKAPFGMFAEK(int FCDKMJOKGIE);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5E9F080", Offset = "0x5E9E080", VA = "0x185E9F080")]
	private static extern int NPMBLOJHLMO(int FCDKMJOKGIE);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5E9F000", Offset = "0x5E9E000", VA = "0x185E9F000")]
	private static extern int NKONGLGCIAI(int FCDKMJOKGIE);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5E9EF80", Offset = "0x5E9DF80", VA = "0x185E9EF80")]
	private static extern int MCAPMLHPBDH(int FCDKMJOKGIE);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5E9F2F0", Offset = "0x5E9E2F0", VA = "0x185E9F2F0")]
	public JOGEALJCPNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5E9EC80", Offset = "0x5E9DC80", VA = "0x185E9EC80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5E9F100", Offset = "0x5E9E100", VA = "0x185E9F100")]
	public Rect OPEBBJDPMGG(int FJOBGMJABEC)
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
