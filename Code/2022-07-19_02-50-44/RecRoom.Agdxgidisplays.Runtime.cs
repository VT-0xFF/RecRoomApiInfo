using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class AGGIKDDELKO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum AMNPCCFEJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void OGNAEPKDPFB(IntPtr ABKBIBODPME, int MAAFLBOPOCI, int NIPPDIABAIF);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int IHDCDPKGFPA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x52160D0", Offset = "0x52150D0", VA = "0x1852160D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x52161C0", Offset = "0x52151C0", VA = "0x1852161C0")]
	private static extern void MGIMCCDMMOA(OGNAEPKDPFB ACDPINKOGPO);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5216250", Offset = "0x5215250", VA = "0x185216250")]
	[MonoPInvokeCallback(typeof(OGNAEPKDPFB))]
	private static void NGFIACOCGCC(IntPtr ABKBIBODPME, int MAAFLBOPOCI, int NIPPDIABAIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5215D00", Offset = "0x5214D00", VA = "0x185215D00")]
	private static extern void BGKBBGPIDLH();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5215F60", Offset = "0x5214F60", VA = "0x185215F60")]
	private static extern void HEIKODELMBH();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x52160D0", Offset = "0x52150D0", VA = "0x1852160D0")]
	private static extern int HJFBFMHAJAH();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5216050", Offset = "0x5215050", VA = "0x185216050")]
	private static extern int FEEMJMHGMPN(int MDOMNGAAEFJ);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5215FD0", Offset = "0x5214FD0", VA = "0x185215FD0")]
	private static extern int EIKICGFOICA(int MDOMNGAAEFJ);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5215C80", Offset = "0x5214C80", VA = "0x185215C80")]
	private static extern int ACKNDLIFCDH(int MDOMNGAAEFJ);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5216140", Offset = "0x5215140", VA = "0x185216140")]
	private static extern int KDNMHDGMGKJ(int MDOMNGAAEFJ);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5216370", Offset = "0x5215370", VA = "0x185216370")]
	public AGGIKDDELKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5215F60", Offset = "0x5214F60", VA = "0x185215F60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5215D70", Offset = "0x5214D70", VA = "0x185215D70")]
	public Rect DIJIALJBODC(int EFBFMOOPJOG)
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
