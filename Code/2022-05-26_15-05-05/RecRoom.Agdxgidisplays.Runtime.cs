using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class LLPAGJLNMBF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum FGOCFNKIMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void MGKCIJFCLGP(IntPtr DMFHFDFMIOL, int KMCJMFPOINP, int FEEAPJDPAJC);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int CECMHKOOKAP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4E825A0", Offset = "0x4E80BA0", VA = "0x184E825A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4E82AA0", Offset = "0x4E810A0", VA = "0x184E82AA0")]
	private static extern void PPBNNICLABF(MGKCIJFCLGP HKHGMJEBNHA);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4E82900", Offset = "0x4E80F00", VA = "0x184E82900")]
	[MonoPInvokeCallback(typeof(MGKCIJFCLGP))]
	private static void JELIJGMBIEK(IntPtr DMFHFDFMIOL, int KMCJMFPOINP, int FEEAPJDPAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4E82530", Offset = "0x4E80B30", VA = "0x184E82530")]
	private static extern void EDEIJCODOEL();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4E824C0", Offset = "0x4E80AC0", VA = "0x184E824C0")]
	private static extern void NHCJEIHLJMB();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4E825A0", Offset = "0x4E80BA0", VA = "0x184E825A0")]
	private static extern int FNGDBPCCHGG();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4E82A20", Offset = "0x4E81020", VA = "0x184E82A20")]
	private static extern int MNMOPHNFILB(int IAKMMHHICJO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4E82690", Offset = "0x4E80C90", VA = "0x184E82690")]
	private static extern int IDCHMNHAPHE(int IAKMMHHICJO);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4E82610", Offset = "0x4E80C10", VA = "0x184E82610")]
	private static extern int HBGELKDFFBH(int IAKMMHHICJO);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4E82440", Offset = "0x4E80A40", VA = "0x184E82440")]
	private static extern int DLJEIFLEGEH(int IAKMMHHICJO);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4E82B30", Offset = "0x4E81130", VA = "0x184E82B30")]
	public LLPAGJLNMBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4E824C0", Offset = "0x4E80AC0", VA = "0x184E824C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4E82710", Offset = "0x4E80D10", VA = "0x184E82710")]
	public Rect IDLBLEKEJDC(int DECFNEKPDHB)
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
