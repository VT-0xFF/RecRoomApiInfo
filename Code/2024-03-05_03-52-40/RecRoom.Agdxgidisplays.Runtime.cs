using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class LJCPJPEIGGN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum FGJAPBCLPIB
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void MPKBGEJMDFA(IntPtr GFBEKCAHNCH, int JEOEJJBKODC, int CAAANGFFPCF);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int ENMADJFFDOA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5F832C0", Offset = "0x5F820C0", VA = "0x185F832C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5F83710", Offset = "0x5F82510", VA = "0x185F83710")]
	private static extern void KFMAAABGJOG(MPKBGEJMDFA NHPEKKMOHMO);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5F83150", Offset = "0x5F81F50", VA = "0x185F83150")]
	[MonoPInvokeCallback(typeof(MPKBGEJMDFA))]
	private static void CBLJOKICGEF(IntPtr GFBEKCAHNCH, int JEOEJJBKODC, int CAAANGFFPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5F836A0", Offset = "0x5F824A0", VA = "0x185F836A0")]
	private static extern void KCJBJGBIMAI();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5F83250", Offset = "0x5F82050", VA = "0x185F83250")]
	private static extern void IFFKPNHLFFP();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5F832C0", Offset = "0x5F820C0", VA = "0x185F832C0")]
	private static extern int NEEGIDJGKED();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5F830D0", Offset = "0x5F81ED0", VA = "0x185F830D0")]
	private static extern int APHPOGIHNKG(int FJIJLBIGEAH);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5F83430", Offset = "0x5F82230", VA = "0x185F83430")]
	private static extern int JFGFAKBCLLF(int FJIJLBIGEAH);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5F833B0", Offset = "0x5F821B0", VA = "0x185F833B0")]
	private static extern int IMKOOBPIAOP(int FJIJLBIGEAH);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5F83330", Offset = "0x5F82130", VA = "0x185F83330")]
	private static extern int HLCJACCNCEH(int FJIJLBIGEAH);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5F837A0", Offset = "0x5F825A0", VA = "0x185F837A0")]
	public LJCPJPEIGGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5F83250", Offset = "0x5F82050", VA = "0x185F83250", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5F834B0", Offset = "0x5F822B0", VA = "0x185F834B0")]
	public Rect KCFPHKLIADJ(int ACJMLFBLDIA)
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
