using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class AOPHKGPKNEE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum JIEMILCFDPE
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void HCMJBKFFMCK(IntPtr JHKMPCADNAF, int MFKKELONDCC, int BCBOKGJNJMK);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int PIHEKLIKKHE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6C3EA90", Offset = "0x6C3DE90", VA = "0x186C3EA90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6C3EC00", Offset = "0x6C3E000", VA = "0x186C3EC00")]
	private static extern void DMINKHCDHKE(HCMJBKFFMCK BNNBDLHMCLC);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6C3E990", Offset = "0x6C3DD90", VA = "0x186C3E990")]
	[MonoPInvokeCallback(typeof(HCMJBKFFMCK))]
	private static void APAINKAPNJB(IntPtr JHKMPCADNAF, int MFKKELONDCC, int BCBOKGJNJMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6C3EF00", Offset = "0x6C3E300", VA = "0x186C3EF00")]
	private static extern void JLABJFAHLGH();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6C3E920", Offset = "0x6C3DD20", VA = "0x186C3E920")]
	private static extern void ACEAKLKNGKH();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6C3EA90", Offset = "0x6C3DE90", VA = "0x186C3EA90")]
	private static extern int GBGKNAGAPGA();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6C3EC90", Offset = "0x6C3E090", VA = "0x186C3EC90")]
	private static extern int EEADKPLJGMI(int IHELCOHOCAM);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6C3EB80", Offset = "0x6C3DF80", VA = "0x186C3EB80")]
	private static extern int CCACHDGHKMG(int IHELCOHOCAM);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6C3EF70", Offset = "0x6C3E370", VA = "0x186C3EF70")]
	private static extern int LDLGJAEEMDD(int IHELCOHOCAM);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6C3EB00", Offset = "0x6C3DF00", VA = "0x186C3EB00")]
	private static extern int BPCBPNLFCBG(int IHELCOHOCAM);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6C3EFF0", Offset = "0x6C3E3F0", VA = "0x186C3EFF0")]
	public AOPHKGPKNEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6C3E920", Offset = "0x6C3DD20", VA = "0x186C3E920", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6C3ED10", Offset = "0x6C3E110", VA = "0x186C3ED10")]
	public Rect GBBDGKNDJBF(int CLJKGPOHBOA)
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
