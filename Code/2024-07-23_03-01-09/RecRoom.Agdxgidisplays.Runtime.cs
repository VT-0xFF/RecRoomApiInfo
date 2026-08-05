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
		[Cpp2IlInjected.Address(RVA = "0x675D6E0", Offset = "0x675C8E0", VA = "0x18675D6E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x675D380", Offset = "0x675C580", VA = "0x18675D380")]
	private static extern void BLFOHAHPBGF(BBBHHAFOJMA HBBMMHKOEKK);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x675D7D0", Offset = "0x675C9D0", VA = "0x18675D7D0")]
	[MonoPInvokeCallback(typeof(BBBHHAFOJMA))]
	private static void MHCLOMFBMFG(IntPtr GPCNCGBOPJG, int ECGAAJFODGN, int KGKIFJFMABH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x675D480", Offset = "0x675C680", VA = "0x18675D480")]
	private static extern void HMCGAKKBHMB();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x675D410", Offset = "0x675C610", VA = "0x18675D410")]
	private static extern void JNJOGGPHAJH();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x675D6E0", Offset = "0x675C8E0", VA = "0x18675D6E0")]
	private static extern int PNCOIHANKLF();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x675D8D0", Offset = "0x675CAD0", VA = "0x18675D8D0")]
	private static extern int NCFBIFFLOGI(int DKFNFHGODON);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x675D300", Offset = "0x675C500", VA = "0x18675D300")]
	private static extern int BFAJMJAAGLD(int DKFNFHGODON);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x675D750", Offset = "0x675C950", VA = "0x18675D750")]
	private static extern int KKLJFBGOJMA(int DKFNFHGODON);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x675D950", Offset = "0x675CB50", VA = "0x18675D950")]
	private static extern int OBGOCELMJEH(int DKFNFHGODON);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x675D9D0", Offset = "0x675CBD0", VA = "0x18675D9D0")]
	public OBBNCDMPLKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x675D410", Offset = "0x675C610", VA = "0x18675D410", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x675D4F0", Offset = "0x675C6F0", VA = "0x18675D4F0")]
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
