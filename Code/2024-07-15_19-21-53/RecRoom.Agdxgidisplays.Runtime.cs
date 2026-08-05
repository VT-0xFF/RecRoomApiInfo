using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class OBBNCDMPLKE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum HNBIFCPPDML
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void BBBHHAFOJMA(IntPtr GPCNCGBOPJG, int ECGAAJFODGN, int KGKIFJFMABH);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int JJNKECHFEJO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x67439D0", Offset = "0x67421D0", VA = "0x1867439D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6743670", Offset = "0x6741E70", VA = "0x186743670")]
	private static extern void BLFOHAHPBGF(BBBHHAFOJMA HBBMMHKOEKK);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6743AC0", Offset = "0x67422C0", VA = "0x186743AC0")]
	[MonoPInvokeCallback(typeof(BBBHHAFOJMA))]
	private static void MHCLOMFBMFG(IntPtr GPCNCGBOPJG, int ECGAAJFODGN, int KGKIFJFMABH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6743770", Offset = "0x6741F70", VA = "0x186743770")]
	private static extern void HMCGAKKBHMB();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6743700", Offset = "0x6741F00", VA = "0x186743700")]
	private static extern void JNJOGGPHAJH();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x67439D0", Offset = "0x67421D0", VA = "0x1867439D0")]
	private static extern int PNCOIHANKLF();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6743BC0", Offset = "0x67423C0", VA = "0x186743BC0")]
	private static extern int NCFBIFFLOGI(int DKFNFHGODON);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x67435F0", Offset = "0x6741DF0", VA = "0x1867435F0")]
	private static extern int BFAJMJAAGLD(int DKFNFHGODON);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6743A40", Offset = "0x6742240", VA = "0x186743A40")]
	private static extern int KKLJFBGOJMA(int DKFNFHGODON);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6743C40", Offset = "0x6742440", VA = "0x186743C40")]
	private static extern int OBGOCELMJEH(int DKFNFHGODON);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6743CC0", Offset = "0x67424C0", VA = "0x186743CC0")]
	public OBBNCDMPLKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6743700", Offset = "0x6741F00", VA = "0x186743700", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x67437E0", Offset = "0x6741FE0", VA = "0x1867437E0")]
	public Rect JJHJMELIMMK(int DKKHIMPEBOH)
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
