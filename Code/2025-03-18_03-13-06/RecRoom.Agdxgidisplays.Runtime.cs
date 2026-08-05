using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class AGONLGCMLOF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum MLHBMCJIFOH
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void HAKFJGDGHMB(IntPtr NKJDMJIDCOG, int IAGJHPFNLHJ, int PNECBKBDBGL);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int IIPPIDJGPHH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x73AB0B0", Offset = "0x73AA2B0", VA = "0x1873AB0B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x73AABB0", Offset = "0x73A9DB0", VA = "0x1873AABB0")]
	private static extern void HFPHHDPPLJA(HAKFJGDGHMB GIIPLELNBKP);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x73AAF30", Offset = "0x73AA130", VA = "0x1873AAF30")]
	[MonoPInvokeCallback(typeof(HAKFJGDGHMB))]
	private static void LOOIEHBNKCI(IntPtr NKJDMJIDCOG, int IAGJHPFNLHJ, int PNECBKBDBGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x73AB120", Offset = "0x73AA320", VA = "0x1873AB120")]
	private static extern void PDAIGIIELDH();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x73AAAC0", Offset = "0x73A9CC0", VA = "0x1873AAAC0")]
	private static extern void BAGFMLJDPEE();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x73AB0B0", Offset = "0x73AA2B0", VA = "0x1873AB0B0")]
	private static extern int NGGFGGCHAEG();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x73AAEB0", Offset = "0x73AA0B0", VA = "0x1873AAEB0")]
	private static extern int IOCKNDANIEG(int JDNOHHGIHEO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x73AB030", Offset = "0x73AA230", VA = "0x1873AB030")]
	private static extern int MCEDLFBPMPE(int JDNOHHGIHEO);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x73AAC40", Offset = "0x73A9E40", VA = "0x1873AAC40")]
	private static extern int HJDKDILLDLK(int JDNOHHGIHEO);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x73AAB30", Offset = "0x73A9D30", VA = "0x1873AAB30")]
	private static extern int FAPHJBBLHAN(int JDNOHHGIHEO);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x73AB190", Offset = "0x73AA390", VA = "0x1873AB190")]
	public AGONLGCMLOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x73AAAC0", Offset = "0x73A9CC0", VA = "0x1873AAAC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x73AACC0", Offset = "0x73A9EC0", VA = "0x1873AACC0")]
	public Rect IJLFCAKHDFM(int GPAPCPFPGHJ)
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
