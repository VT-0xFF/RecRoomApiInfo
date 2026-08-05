using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class DCBELLDBCPM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum EIBAGGNNCBO
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void MCOPEFDPGNH(IntPtr MJJCOLDOFAC, int GFFAGBDKDAI, int ACIEOANIPHO);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int OKEOABIDHIE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6148940", Offset = "0x6147940", VA = "0x186148940")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6148A30", Offset = "0x6147A30", VA = "0x186148A30")]
	private static extern void KFFIBOICIFE(MCOPEFDPGNH HLFIKKGGCCK);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x61486E0", Offset = "0x61476E0", VA = "0x1861486E0")]
	[MonoPInvokeCallback(typeof(MCOPEFDPGNH))]
	private static void CFKELODMNFI(IntPtr MJJCOLDOFAC, int GFFAGBDKDAI, int ACIEOANIPHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x61487E0", Offset = "0x61477E0", VA = "0x1861487E0")]
	private static extern void CJMKLAKCCOG();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6148850", Offset = "0x6147850", VA = "0x186148850")]
	private static extern void KNAGBGOHGKB();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6148940", Offset = "0x6147940", VA = "0x186148940")]
	private static extern int ENOELJLPPEF();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x61485E0", Offset = "0x61475E0", VA = "0x1861485E0")]
	private static extern int AIFDPACILEP(int JKEKANKKCCC);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6148660", Offset = "0x6147660", VA = "0x186148660")]
	private static extern int ALHOFOPDGGP(int JKEKANKKCCC);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x61489B0", Offset = "0x61479B0", VA = "0x1861489B0")]
	private static extern int FGLHBPJLPDG(int JKEKANKKCCC);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x61488C0", Offset = "0x61478C0", VA = "0x1861488C0")]
	private static extern int EBJBMALHPAC(int JKEKANKKCCC);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6148AC0", Offset = "0x6147AC0", VA = "0x186148AC0")]
	public DCBELLDBCPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6148850", Offset = "0x6147850", VA = "0x186148850", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x61483F0", Offset = "0x61473F0", VA = "0x1861483F0")]
	public Rect AGEHFBHLMOM(int EDFGDAIBDJI)
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
