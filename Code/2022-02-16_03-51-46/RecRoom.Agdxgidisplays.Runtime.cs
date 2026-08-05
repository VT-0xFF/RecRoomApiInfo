using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class DGFOALIFIEM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum LHOOKBKNAIG
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void KKMGPLDDCKG(IntPtr NFKFPAKFGFK, int GDBDJPILDNP, int LCGFCMDFLNF);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int COGEGMAJNPO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1BC5FB0", Offset = "0x1BC47B0", VA = "0x181BC5FB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1BC5E00", Offset = "0x1BC4600", VA = "0x181BC5E00")]
	private static extern void BIGDPKHAHGB(KKMGPLDDCKG HIHNOBNGGBK);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1BC5E90", Offset = "0x1BC4690", VA = "0x181BC5E90")]
	[MonoPInvokeCallback(typeof(KKMGPLDDCKG))]
	private static void CJBFPGKNJIH(IntPtr NFKFPAKFGFK, int GDBDJPILDNP, int LCGFCMDFLNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1BC6400", Offset = "0x1BC4C00", VA = "0x181BC6400")]
	private static extern void PJKFEDAIHFG();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1BC6020", Offset = "0x1BC4820", VA = "0x181BC6020")]
	private static extern void FIFHNOIGMCA();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1BC5FB0", Offset = "0x1BC47B0", VA = "0x181BC5FB0")]
	private static extern int KLADBBMECMM();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1BC6190", Offset = "0x1BC4990", VA = "0x181BC6190")]
	private static extern int NBCJOFEBIKG(int KCKIAGIOHJN);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1BC6090", Offset = "0x1BC4890", VA = "0x181BC6090")]
	private static extern int INABFBFPJCJ(int KCKIAGIOHJN);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1BC6110", Offset = "0x1BC4910", VA = "0x181BC6110")]
	private static extern int LDKGALDCDCP(int KCKIAGIOHJN);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1BC5D80", Offset = "0x1BC4580", VA = "0x181BC5D80")]
	private static extern int AGOIKHJKDNM(int KCKIAGIOHJN);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1BC6470", Offset = "0x1BC4C70", VA = "0x181BC6470")]
	public DGFOALIFIEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1BC6020", Offset = "0x1BC4820", VA = "0x181BC6020", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1BC6210", Offset = "0x1BC4A10", VA = "0x181BC6210")]
	public Rect OCHPDIBMKDM(int MLLOFGJMAEO)
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
