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
		[Cpp2IlInjected.Address(RVA = "0x6743AD0", Offset = "0x67424D0", VA = "0x186743AD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6743770", Offset = "0x6742170", VA = "0x186743770")]
	private static extern void BLFOHAHPBGF(BBBHHAFOJMA HBBMMHKOEKK);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6743BC0", Offset = "0x67425C0", VA = "0x186743BC0")]
	[MonoPInvokeCallback(typeof(BBBHHAFOJMA))]
	private static void MHCLOMFBMFG(IntPtr GPCNCGBOPJG, int ECGAAJFODGN, int KGKIFJFMABH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6743870", Offset = "0x6742270", VA = "0x186743870")]
	private static extern void HMCGAKKBHMB();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6743800", Offset = "0x6742200", VA = "0x186743800")]
	private static extern void JNJOGGPHAJH();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6743AD0", Offset = "0x67424D0", VA = "0x186743AD0")]
	private static extern int PNCOIHANKLF();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6743CC0", Offset = "0x67426C0", VA = "0x186743CC0")]
	private static extern int NCFBIFFLOGI(int DKFNFHGODON);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x67436F0", Offset = "0x67420F0", VA = "0x1867436F0")]
	private static extern int BFAJMJAAGLD(int DKFNFHGODON);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6743B40", Offset = "0x6742540", VA = "0x186743B40")]
	private static extern int KKLJFBGOJMA(int DKFNFHGODON);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6743D40", Offset = "0x6742740", VA = "0x186743D40")]
	private static extern int OBGOCELMJEH(int DKFNFHGODON);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6743DC0", Offset = "0x67427C0", VA = "0x186743DC0")]
	public OBBNCDMPLKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6743800", Offset = "0x6742200", VA = "0x186743800", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x67438E0", Offset = "0x67422E0", VA = "0x1867438E0")]
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
