using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class KCMGHGBBMPK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum DAPNNKNOLEI
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void AABGFOAGHND(IntPtr IBNNNHFPFBF, int OLKJNOHMJPI, int GDBONPKDGAP);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int KBEBKEABNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6A667D0", Offset = "0x6A653D0", VA = "0x186A667D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6A668C0", Offset = "0x6A654C0", VA = "0x186A668C0")]
	private static extern void DPECPLNJGMJ(AABGFOAGHND NNGDIBHFMBF);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6A666D0", Offset = "0x6A652D0", VA = "0x186A666D0")]
	[MonoPInvokeCallback(typeof(AABGFOAGHND))]
	private static void AHOLEOKOHJJ(IntPtr IBNNNHFPFBF, int OLKJNOHMJPI, int GDBONPKDGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6A66D30", Offset = "0x6A65930", VA = "0x186A66D30")]
	private static extern void KMAKNPIEEHP();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6A66950", Offset = "0x6A65550", VA = "0x186A66950")]
	private static extern void INEEJDAIKND();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6A667D0", Offset = "0x6A653D0", VA = "0x186A667D0")]
	private static extern int JPIMIOAHAGG();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6A66CB0", Offset = "0x6A658B0", VA = "0x186A66CB0")]
	private static extern int INKEDJECOJC(int MJDOIIBKEKN);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6A669C0", Offset = "0x6A655C0", VA = "0x186A669C0")]
	private static extern int EFPCLDIHANP(int MJDOIIBKEKN);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6A66A40", Offset = "0x6A65640", VA = "0x186A66A40")]
	private static extern int GGFLMBOFFEB(int MJDOIIBKEKN);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6A66840", Offset = "0x6A65440", VA = "0x186A66840")]
	private static extern int DOOPEDPKOCF(int MJDOIIBKEKN);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6A66DA0", Offset = "0x6A659A0", VA = "0x186A66DA0")]
	public KCMGHGBBMPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6A66950", Offset = "0x6A65550", VA = "0x186A66950", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6A66AC0", Offset = "0x6A656C0", VA = "0x186A66AC0")]
	public Rect HDNFHMHICBK(int CBAJACFAOIE)
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
