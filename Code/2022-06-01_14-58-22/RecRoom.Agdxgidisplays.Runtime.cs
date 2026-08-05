using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class CJLMICFOAAO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum NKLCKPHBJBG
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void NGEIBPJAHIJ(IntPtr LKGBFLLCPJC, int OCEBHFCGEGN, int IADKAMPHJNF);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int FONGEKFGGGB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1933000", Offset = "0x1931A00", VA = "0x181933000")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x19334F0", Offset = "0x1931EF0", VA = "0x1819334F0")]
	private static extern void GMHGJPPDDIL(NGEIBPJAHIJ JJBCELLHKLO);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x19332D0", Offset = "0x1931CD0", VA = "0x1819332D0")]
	[MonoPInvokeCallback(typeof(NGEIBPJAHIJ))]
	private static void EIAIFPKNEPI(IntPtr LKGBFLLCPJC, int OCEBHFCGEGN, int IADKAMPHJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1933680", Offset = "0x1932080", VA = "0x181933680")]
	private static extern void LPDEJFLNIEO();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1933260", Offset = "0x1931C60", VA = "0x181933260")]
	private static extern void PFALJDEBAGE();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1933000", Offset = "0x1931A00", VA = "0x181933000")]
	private static extern int BDHFKHCBPMO();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1933580", Offset = "0x1931F80", VA = "0x181933580")]
	private static extern int HNMPNFBHDDD(int AKGOJHKMAIK);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1933470", Offset = "0x1931E70", VA = "0x181933470")]
	private static extern int GAAEOFNCBIA(int AKGOJHKMAIK);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1933600", Offset = "0x1932000", VA = "0x181933600")]
	private static extern int IALNNOAJGDB(int AKGOJHKMAIK);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x19333F0", Offset = "0x1931DF0", VA = "0x1819333F0")]
	private static extern int FKFPEBDKLJD(int AKGOJHKMAIK);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x19336F0", Offset = "0x19320F0", VA = "0x1819336F0")]
	public CJLMICFOAAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1933260", Offset = "0x1931C60", VA = "0x181933260", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1933070", Offset = "0x1931A70", VA = "0x181933070")]
	public Rect BDHOFKFAEPE(int ODFCGENBKNH)
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
