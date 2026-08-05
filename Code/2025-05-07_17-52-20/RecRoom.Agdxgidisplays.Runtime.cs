using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class LJALDMFKJPB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum NAPKFCLANNM
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void PDCHBNIDLKH(IntPtr HOOJNAMGGBC, int CFNMLMNHCMF, int OEFFGJOKOIF);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int IHKAGACIECM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x79BEA80", Offset = "0x79BDA80", VA = "0x1879BEA80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x79BE970", Offset = "0x79BD970", VA = "0x1879BE970")]
	private static extern void HMLNIGFPJPM(PDCHBNIDLKH COLEJLDPDCO);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x79BED60", Offset = "0x79BDD60", VA = "0x1879BED60")]
	[MonoPInvokeCallback(typeof(PDCHBNIDLKH))]
	private static void MMHEOIINMLP(IntPtr HOOJNAMGGBC, int CFNMLMNHCMF, int OEFFGJOKOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x79BE810", Offset = "0x79BD810", VA = "0x1879BE810")]
	private static extern void ANJKPBDKBKO();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x79BE880", Offset = "0x79BD880", VA = "0x1879BE880")]
	private static extern void CEBDPBNKPCF();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x79BEA80", Offset = "0x79BDA80", VA = "0x1879BEA80")]
	private static extern int KCJLBKDBMOE();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x79BEA00", Offset = "0x79BDA00", VA = "0x1879BEA00")]
	private static extern int JKJEFGHKFNN(int HJPLNJNIFLL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x79BE8F0", Offset = "0x79BD8F0", VA = "0x1879BE8F0")]
	private static extern int FFMKAMILMDB(int HJPLNJNIFLL);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x79BECE0", Offset = "0x79BDCE0", VA = "0x1879BECE0")]
	private static extern int KLLKKLHGMAK(int HJPLNJNIFLL);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x79BEE60", Offset = "0x79BDE60", VA = "0x1879BEE60")]
	private static extern int PMKNAJIADAG(int HJPLNJNIFLL);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x79BEEE0", Offset = "0x79BDEE0", VA = "0x1879BEEE0")]
	public LJALDMFKJPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x79BE880", Offset = "0x79BD880", VA = "0x1879BE880", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x79BEAF0", Offset = "0x79BDAF0", VA = "0x1879BEAF0")]
	public Rect KHALMECPMEH(int BPDAKGAOFFF)
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
