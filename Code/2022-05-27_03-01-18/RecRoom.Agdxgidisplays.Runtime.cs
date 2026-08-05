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
		[Cpp2IlInjected.Address(RVA = "0x1E39C90", Offset = "0x1E38C90", VA = "0x181E39C90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1E3A190", Offset = "0x1E39190", VA = "0x181E3A190")]
	private static extern void PPBNNICLABF(MGKCIJFCLGP HKHGMJEBNHA);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1E39FF0", Offset = "0x1E38FF0", VA = "0x181E39FF0")]
	[MonoPInvokeCallback(typeof(MGKCIJFCLGP))]
	private static void JELIJGMBIEK(IntPtr DMFHFDFMIOL, int KMCJMFPOINP, int FEEAPJDPAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1E39C20", Offset = "0x1E38C20", VA = "0x181E39C20")]
	private static extern void EDEIJCODOEL();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1E39BB0", Offset = "0x1E38BB0", VA = "0x181E39BB0")]
	private static extern void NHCJEIHLJMB();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1E39C90", Offset = "0x1E38C90", VA = "0x181E39C90")]
	private static extern int FNGDBPCCHGG();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1E3A110", Offset = "0x1E39110", VA = "0x181E3A110")]
	private static extern int MNMOPHNFILB(int IAKMMHHICJO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1E39D80", Offset = "0x1E38D80", VA = "0x181E39D80")]
	private static extern int IDCHMNHAPHE(int IAKMMHHICJO);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1E39D00", Offset = "0x1E38D00", VA = "0x181E39D00")]
	private static extern int HBGELKDFFBH(int IAKMMHHICJO);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1E39B30", Offset = "0x1E38B30", VA = "0x181E39B30")]
	private static extern int DLJEIFLEGEH(int IAKMMHHICJO);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1E3A220", Offset = "0x1E39220", VA = "0x181E3A220")]
	public LLPAGJLNMBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1E39BB0", Offset = "0x1E38BB0", VA = "0x181E39BB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1E39E00", Offset = "0x1E38E00", VA = "0x181E39E00")]
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
