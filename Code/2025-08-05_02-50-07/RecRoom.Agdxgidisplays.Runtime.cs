using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class ENFOOHAKIPG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum OLBICNFJGDN
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void BJEGPNJCGBO(IntPtr IDLJGJGIGEG, int MPDDFCCPIOM, int AIFHIPGNONC);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int IGBKBAFKLEB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7FBF070", Offset = "0x7FBE470", VA = "0x187FBF070")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7FBF1D0", Offset = "0x7FBE5D0", VA = "0x187FBF1D0")]
	private static extern void HEPHOADKKKA(BJEGPNJCGBO BFDLNHAHOHH);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7FBF450", Offset = "0x7FBE850", VA = "0x187FBF450")]
	[MonoPInvokeCallback(typeof(BJEGPNJCGBO))]
	private static void MIKDMAEHHMI(IntPtr IDLJGJGIGEG, int MPDDFCCPIOM, int AIFHIPGNONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7FBF5D0", Offset = "0x7FBE9D0", VA = "0x187FBF5D0")]
	private static extern void PJOFCLDPLJB();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7FBF160", Offset = "0x7FBE560", VA = "0x187FBF160")]
	private static extern void OGDPHCDAKPJ();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7FBF070", Offset = "0x7FBE470", VA = "0x187FBF070")]
	private static extern int COJKMPJFFHO();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7FBF0E0", Offset = "0x7FBE4E0", VA = "0x187FBF0E0")]
	private static extern int DHADEJIJJDK(int CLNGGGMIBPI);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7FBF550", Offset = "0x7FBE950", VA = "0x187FBF550")]
	private static extern int OOEDJEFKLIF(int CLNGGGMIBPI);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7FBEF70", Offset = "0x7FBE370", VA = "0x187FBEF70")]
	private static extern int BGFIFNALAIF(int CLNGGGMIBPI);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7FBEFF0", Offset = "0x7FBE3F0", VA = "0x187FBEFF0")]
	private static extern int BPJAEFBCCHO(int CLNGGGMIBPI);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7FBF640", Offset = "0x7FBEA40", VA = "0x187FBF640")]
	public ENFOOHAKIPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7FBF160", Offset = "0x7FBE560", VA = "0x187FBF160", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7FBF260", Offset = "0x7FBE660", VA = "0x187FBF260")]
	public Rect IEAMHMPBOHE(int HICNANMANHC)
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
