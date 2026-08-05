using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class OJLJMAENAKG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum CMIKBOAKMEA
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void EDMADFMKPPH(IntPtr MIMLCIHLPAB, int DDGPJFNNFJK, int EPJDCDOGBGM);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int GGGJCNBMMOP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5E99860", Offset = "0x5E98660", VA = "0x185E99860")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5E998D0", Offset = "0x5E986D0", VA = "0x185E998D0")]
	private static extern void AKBGCJEPDCM(EDMADFMKPPH IDFHKFHMFGD);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5E99A50", Offset = "0x5E98850", VA = "0x185E99A50")]
	[MonoPInvokeCallback(typeof(EDMADFMKPPH))]
	private static void EGKNBIEJKEA(IntPtr MIMLCIHLPAB, int DDGPJFNNFJK, int EPJDCDOGBGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E99B50", Offset = "0x5E98950", VA = "0x185E99B50")]
	private static extern void FCIFMHNEBDM();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E999E0", Offset = "0x5E987E0", VA = "0x185E999E0")]
	private static extern void JPOLFDDMGBH();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E99860", Offset = "0x5E98660", VA = "0x185E99860")]
	private static extern int AIIHOKENMED();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5E99EB0", Offset = "0x5E98CB0", VA = "0x185E99EB0")]
	private static extern int ONPAPGPEFOD(int DGIBOINMLED);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5E99960", Offset = "0x5E98760", VA = "0x185E99960")]
	private static extern int BLBGDFAOMCA(int DGIBOINMLED);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5E99BC0", Offset = "0x5E989C0", VA = "0x185E99BC0")]
	private static extern int IIMGBMAHMOA(int DGIBOINMLED);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5E99E30", Offset = "0x5E98C30", VA = "0x185E99E30")]
	private static extern int OEANMKKAMOJ(int DGIBOINMLED);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5E99F30", Offset = "0x5E98D30", VA = "0x185E99F30")]
	public OJLJMAENAKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5E999E0", Offset = "0x5E987E0", VA = "0x185E999E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5E99C40", Offset = "0x5E98A40", VA = "0x185E99C40")]
	public Rect KOAFGHPPONC(int JHPNFOHGECJ)
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
