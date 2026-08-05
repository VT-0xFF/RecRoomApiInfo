using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class DJKNDHBJMNC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum GIPHLMKJCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void KNBBBBEGGFM(IntPtr IFENBNJBPFK, int PGNDNMPLNGG, int HPHFGCEALFL);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int MIDIMLDGJOL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3CFC0B0", Offset = "0x3CFAEB0", VA = "0x183CFC0B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3CFC290", Offset = "0x3CFB090", VA = "0x183CFC290")]
	private static extern void LCBOOADNBCA(KNBBBBEGGFM CNAECKKILBA);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3CFC590", Offset = "0x3CFB390", VA = "0x183CFC590")]
	[MonoPInvokeCallback(typeof(KNBBBBEGGFM))]
	private static void MMBAHBNOEHL(IntPtr IFENBNJBPFK, int PGNDNMPLNGG, int HPHFGCEALFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3CFC120", Offset = "0x3CFAF20", VA = "0x183CFC120")]
	private static extern void FPDOEHBLPNN();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3CFC040", Offset = "0x3CFAE40", VA = "0x183CFC040")]
	private static extern void FIOJFBIAPDC();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3CFC0B0", Offset = "0x3CFAEB0", VA = "0x183CFC0B0")]
	private static extern int NINDGBAICCO();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3CFC510", Offset = "0x3CFB310", VA = "0x183CFC510")]
	private static extern int MEKFBHLKKJI(int LOOMKMDLKEO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3CFC190", Offset = "0x3CFAF90", VA = "0x183CFC190")]
	private static extern int GKDFJIDLCJJ(int LOOMKMDLKEO);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3CFC210", Offset = "0x3CFB010", VA = "0x183CFC210")]
	private static extern int KNFIAFNOECJ(int LOOMKMDLKEO);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3CFBFC0", Offset = "0x3CFADC0", VA = "0x183CFBFC0")]
	private static extern int BAKGDJFINOM(int LOOMKMDLKEO);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3CFC6B0", Offset = "0x3CFB4B0", VA = "0x183CFC6B0")]
	public DJKNDHBJMNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3CFC040", Offset = "0x3CFAE40", VA = "0x183CFC040", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3CFC320", Offset = "0x3CFB120", VA = "0x183CFC320")]
	public Rect LEJCOMEMCCL(int MFPDMPGGONC)
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
