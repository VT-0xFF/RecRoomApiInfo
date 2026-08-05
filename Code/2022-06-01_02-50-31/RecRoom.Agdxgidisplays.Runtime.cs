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
		[Cpp2IlInjected.Address(RVA = "0x4D89B10", Offset = "0x4D88510", VA = "0x184D89B10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4D8A000", Offset = "0x4D88A00", VA = "0x184D8A000")]
	private static extern void GMHGJPPDDIL(NGEIBPJAHIJ JJBCELLHKLO);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4D89DE0", Offset = "0x4D887E0", VA = "0x184D89DE0")]
	[MonoPInvokeCallback(typeof(NGEIBPJAHIJ))]
	private static void EIAIFPKNEPI(IntPtr LKGBFLLCPJC, int OCEBHFCGEGN, int IADKAMPHJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4D8A190", Offset = "0x4D88B90", VA = "0x184D8A190")]
	private static extern void LPDEJFLNIEO();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4D89D70", Offset = "0x4D88770", VA = "0x184D89D70")]
	private static extern void PFALJDEBAGE();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4D89B10", Offset = "0x4D88510", VA = "0x184D89B10")]
	private static extern int BDHFKHCBPMO();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4D8A090", Offset = "0x4D88A90", VA = "0x184D8A090")]
	private static extern int HNMPNFBHDDD(int AKGOJHKMAIK);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4D89F80", Offset = "0x4D88980", VA = "0x184D89F80")]
	private static extern int GAAEOFNCBIA(int AKGOJHKMAIK);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4D8A110", Offset = "0x4D88B10", VA = "0x184D8A110")]
	private static extern int IALNNOAJGDB(int AKGOJHKMAIK);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4D89F00", Offset = "0x4D88900", VA = "0x184D89F00")]
	private static extern int FKFPEBDKLJD(int AKGOJHKMAIK);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4D8A200", Offset = "0x4D88C00", VA = "0x184D8A200")]
	public CJLMICFOAAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4D89D70", Offset = "0x4D88770", VA = "0x184D89D70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4D89B80", Offset = "0x4D88580", VA = "0x184D89B80")]
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
