using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class BECCMALJLDC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum FIFJPHEIAHC
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void KEAMMPBEJKM(IntPtr AGFMCIMDGME, int FJJGAGKDECJ, int AGPHPJLNNOD);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int JCCGNOAHNLO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x72ABC10", Offset = "0x72AA810", VA = "0x1872ABC10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x72ABC80", Offset = "0x72AA880", VA = "0x1872ABC80")]
	private static extern void JLPAGOOBMFL(KEAMMPBEJKM DKDPAFJDNNF);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x72ABE10", Offset = "0x72AAA10", VA = "0x1872ABE10")]
	[MonoPInvokeCallback(typeof(KEAMMPBEJKM))]
	private static void PDGKMLFLAAD(IntPtr AGFMCIMDGME, int FJJGAGKDECJ, int AGPHPJLNNOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x72AB840", Offset = "0x72AA440", VA = "0x1872AB840")]
	private static extern void AIMKJDEKJHN();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x72ABB20", Offset = "0x72AA720", VA = "0x1872ABB20")]
	private static extern void CIEKDGDECAM();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x72ABC10", Offset = "0x72AA810", VA = "0x1872ABC10")]
	private static extern int HNJPIFIJJFC();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x72ABD90", Offset = "0x72AA990", VA = "0x1872ABD90")]
	private static extern int MHBEFGJHEKL(int HGEMPDBGGBJ);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x72ABB90", Offset = "0x72AA790", VA = "0x1872ABB90")]
	private static extern int DAFAAPKDHBJ(int HGEMPDBGGBJ);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x72ABD10", Offset = "0x72AA910", VA = "0x1872ABD10")]
	private static extern int KDIAHABDKLH(int HGEMPDBGGBJ);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x72AB8B0", Offset = "0x72AA4B0", VA = "0x1872AB8B0")]
	private static extern int AKPPDEDOAPN(int HGEMPDBGGBJ);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x72ABF10", Offset = "0x72AAB10", VA = "0x1872ABF10")]
	public BECCMALJLDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x72ABB20", Offset = "0x72AA720", VA = "0x1872ABB20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x72AB930", Offset = "0x72AA530", VA = "0x1872AB930")]
	public Rect CHEAANGICPC(int LKCEFNDANFA)
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
