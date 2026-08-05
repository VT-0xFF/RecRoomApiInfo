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
		[Cpp2IlInjected.Address(RVA = "0x5E9E440", Offset = "0x5E9D240", VA = "0x185E9E440")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5E9E120", Offset = "0x5E9CF20", VA = "0x185E9E120")]
	private static extern void DJBEBIBFEDI(DFCNNKNPPMM GKAOJENLDLL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5E9E220", Offset = "0x5E9D020", VA = "0x185E9E220")]
	[MonoPInvokeCallback(typeof(DFCNNKNPPMM))]
	private static void FPOPGJBHHJD(IntPtr NMKJPBEONAN, int MNKEEJPGFOP, int JOEDFCJACJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E9E3D0", Offset = "0x5E9D1D0", VA = "0x185E9E3D0")]
	private static extern void ILMEFAAGLOH();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E9E1B0", Offset = "0x5E9CFB0", VA = "0x185E9E1B0")]
	private static extern void DMFGCMHBPEA();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E9E440", Offset = "0x5E9D240", VA = "0x185E9E440")]
	private static extern int JDKLEDPGJDN();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5E9E350", Offset = "0x5E9D150", VA = "0x185E9E350")]
	private static extern int HKAPFGMFAEK(int FCDKMJOKGIE);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5E9E5B0", Offset = "0x5E9D3B0", VA = "0x185E9E5B0")]
	private static extern int NPMBLOJHLMO(int FCDKMJOKGIE);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5E9E530", Offset = "0x5E9D330", VA = "0x185E9E530")]
	private static extern int NKONGLGCIAI(int FCDKMJOKGIE);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5E9E4B0", Offset = "0x5E9D2B0", VA = "0x185E9E4B0")]
	private static extern int MCAPMLHPBDH(int FCDKMJOKGIE);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5E9E820", Offset = "0x5E9D620", VA = "0x185E9E820")]
	public JOGEALJCPNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5E9E1B0", Offset = "0x5E9CFB0", VA = "0x185E9E1B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5E9E630", Offset = "0x5E9D430", VA = "0x185E9E630")]
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
