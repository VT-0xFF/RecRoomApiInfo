using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class LEDPJELIGHN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum HFEMFPJBEDN
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void JPFGCIMJOBI(IntPtr GKGMLGAAHGF, int BNLHOMCBDLM, int PFKCDMAIKEA);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int BFMPLBCKCMH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4E40300", Offset = "0x4E3EF00", VA = "0x184E40300")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4E40560", Offset = "0x4E3F160", VA = "0x184E40560")]
	private static extern void GFAOABIFLNE(JPFGCIMJOBI DBNMPCEBPKD);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4E40860", Offset = "0x4E3F460", VA = "0x184E40860")]
	[MonoPInvokeCallback(typeof(JPFGCIMJOBI))]
	private static void IFCLFDACCCJ(IntPtr GKGMLGAAHGF, int BNLHOMCBDLM, int PFKCDMAIKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4E40980", Offset = "0x4E3F580", VA = "0x184E40980")]
	private static extern void JIBFOCILIBI();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4E404F0", Offset = "0x4E3F0F0", VA = "0x184E404F0")]
	private static extern void EPGKFLNHMLK();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4E40300", Offset = "0x4E3EF00", VA = "0x184E40300")]
	private static extern int JLKOCEKFHDN();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4E40370", Offset = "0x4E3EF70", VA = "0x184E40370")]
	private static extern int AOFPLNAGDEB(int DGHEBFGIDHG);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4E405F0", Offset = "0x4E3F1F0", VA = "0x184E405F0")]
	private static extern int GFLCGDNJMLI(int DGHEBFGIDHG);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4E403F0", Offset = "0x4E3EFF0", VA = "0x184E403F0")]
	private static extern int BIOCMANAOHL(int DGHEBFGIDHG);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4E40470", Offset = "0x4E3F070", VA = "0x184E40470")]
	private static extern int DJNHLNDBECM(int DGHEBFGIDHG);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4E409F0", Offset = "0x4E3F5F0", VA = "0x184E409F0")]
	public LEDPJELIGHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4E404F0", Offset = "0x4E3F0F0", VA = "0x184E404F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4E40670", Offset = "0x4E3F270", VA = "0x184E40670")]
	public Rect HFPMFAHNPCC(int GIBJKPDGDKO)
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
