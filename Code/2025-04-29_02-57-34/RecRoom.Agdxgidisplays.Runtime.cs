using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class DGAIKPFENFF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum LKDNEENMPIC
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void NACJOFOGPKH(IntPtr LFFAIMMKIAM, int LLBNOFGPNDN, int EFKEHBLABMO);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int ONBKBNPMIKA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x785D150", Offset = "0x785C550", VA = "0x18785D150")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x785CFC0", Offset = "0x785C3C0", VA = "0x18785CFC0")]
	private static extern void JKCJPDDJGHF(NACJOFOGPKH IBDCICFCEPJ);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x785D050", Offset = "0x785C450", VA = "0x18785D050")]
	[MonoPInvokeCallback(typeof(NACJOFOGPKH))]
	private static void MONHJCBFKLJ(IntPtr LFFAIMMKIAM, int LLBNOFGPNDN, int EFKEHBLABMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x785CF50", Offset = "0x785C350", VA = "0x18785CF50")]
	private static extern void ENMMELFAOHH();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x785CEE0", Offset = "0x785C2E0", VA = "0x18785CEE0")]
	private static extern void HIOLJHPHNAF();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x785D150", Offset = "0x785C550", VA = "0x18785D150")]
	private static extern int NNBHIPHOLNK();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x785CE60", Offset = "0x785C260", VA = "0x18785CE60")]
	private static extern int BILGJLKDMBE(int FBLIJIPJKFJ);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x785CD60", Offset = "0x785C160", VA = "0x18785CD60")]
	private static extern int AHJGPGLEKNO(int FBLIJIPJKFJ);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x785CDE0", Offset = "0x785C1E0", VA = "0x18785CDE0")]
	private static extern int BFHAMMAEBHG(int FBLIJIPJKFJ);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x785D3B0", Offset = "0x785C7B0", VA = "0x18785D3B0")]
	private static extern int PFFOALMIEAL(int FBLIJIPJKFJ);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x785D430", Offset = "0x785C830", VA = "0x18785D430")]
	public DGAIKPFENFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x785CEE0", Offset = "0x785C2E0", VA = "0x18785CEE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x785D1C0", Offset = "0x785C5C0", VA = "0x18785D1C0")]
	public Rect OEOLBFPOMHC(int NNHLHHDEBBO)
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
