using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class NJPOHPNNMGE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum IKCHLAEHACI
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void CEBEGLMJBGN(IntPtr LPOCBPNMNHF, int MKMGHJFMNMB, int MJFNFIPDNEG);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int DPLKEKFCEEN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x672D4E0", Offset = "0x672C8E0", VA = "0x18672D4E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x672D640", Offset = "0x672CA40", VA = "0x18672D640")]
	private static extern void GMICJAODFEE(CEBEGLMJBGN PEPHBHFBJFE);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x672DA30", Offset = "0x672CE30", VA = "0x18672DA30")]
	[MonoPInvokeCallback(typeof(CEBEGLMJBGN))]
	private static void PEMNMFDMLMJ(IntPtr LPOCBPNMNHF, int MKMGHJFMNMB, int MJFNFIPDNEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x672D6D0", Offset = "0x672CAD0", VA = "0x18672D6D0")]
	private static extern void JHHOMPLGCBC();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x672D550", Offset = "0x672C950", VA = "0x18672D550")]
	private static extern void OBAOMFLHDAJ();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x672D4E0", Offset = "0x672C8E0", VA = "0x18672D4E0")]
	private static extern int BHIPHNHHBKB();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x672D740", Offset = "0x672CB40", VA = "0x18672D740")]
	private static extern int KFKMCOAKNAP(int CLOAPFCHKDE);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x672D5C0", Offset = "0x672C9C0", VA = "0x18672D5C0")]
	private static extern int EBHFDMHMFJN(int CLOAPFCHKDE);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x672D9B0", Offset = "0x672CDB0", VA = "0x18672D9B0")]
	private static extern int PCHHJMCAHIH(int CLOAPFCHKDE);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x672D460", Offset = "0x672C860", VA = "0x18672D460")]
	private static extern int BHELKLJEFGL(int CLOAPFCHKDE);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x672DB60", Offset = "0x672CF60", VA = "0x18672DB60")]
	public NJPOHPNNMGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x672D550", Offset = "0x672C950", VA = "0x18672D550", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x672D7C0", Offset = "0x672CBC0", VA = "0x18672D7C0")]
	public Rect KJEPKBFDCEI(int OBMOAAPBICN)
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
