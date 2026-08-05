using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class GEDMEKODEOM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum MFJMJCBPFBI
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void CJMGMCDMGFD(IntPtr OLLHJMHJJAI, int LGIEDJBGIJJ, int LGOEKPHGOIK);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int HNCEBAIMMIF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4B1CD70", Offset = "0x4B1B570", VA = "0x184B1CD70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4B1D260", Offset = "0x4B1BA60", VA = "0x184B1D260")]
	private static extern void JBOGDBJEBDB(CJMGMCDMGFD MKGMOFPDGOO);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4B1D050", Offset = "0x4B1B850", VA = "0x184B1D050")]
	[MonoPInvokeCallback(typeof(CJMGMCDMGFD))]
	private static void DJNJMHAEAPK(IntPtr OLLHJMHJJAI, int LGIEDJBGIJJ, int LGOEKPHGOIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4B1D2F0", Offset = "0x4B1BAF0", VA = "0x184B1D2F0")]
	private static extern void LHPLLNMCLEE();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4B1D170", Offset = "0x4B1B970", VA = "0x184B1D170")]
	private static extern void HKMMGBHODNN();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4B1CD70", Offset = "0x4B1B570", VA = "0x184B1CD70")]
	private static extern int MFAOLCNEFOC();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4B1CDE0", Offset = "0x4B1B5E0", VA = "0x184B1CDE0")]
	private static extern int CPHNGLGAGFI(int PEIAGKGLLKC);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4B1D360", Offset = "0x4B1BB60", VA = "0x184B1D360")]
	private static extern int MPKAHHMPEPA(int PEIAGKGLLKC);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4B1D1E0", Offset = "0x4B1B9E0", VA = "0x184B1D1E0")]
	private static extern int GNGGINJPHEO(int PEIAGKGLLKC);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4B1D3E0", Offset = "0x4B1BBE0", VA = "0x184B1D3E0")]
	private static extern int PFAGHMFBKAA(int PEIAGKGLLKC);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4B1D460", Offset = "0x4B1BC60", VA = "0x184B1D460")]
	public GEDMEKODEOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4B1D170", Offset = "0x4B1B970", VA = "0x184B1D170", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4B1CE60", Offset = "0x4B1B660", VA = "0x184B1CE60")]
	public Rect DAODIENHGEI(int IOFLLAILCCN)
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
