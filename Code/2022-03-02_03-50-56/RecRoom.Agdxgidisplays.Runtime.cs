using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class CMGGKGKJGEL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum DHCLIFKOMKD
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void HGMLIMKFJCF(IntPtr MOLEAEHPOIL, int ACFAACNMEBO, int IPNLNELEEMI);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int FKIKIJJMOOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x49F6D90", Offset = "0x49F5D90", VA = "0x1849F6D90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x49F70A0", Offset = "0x49F60A0", VA = "0x1849F70A0")]
	private static extern void NNAEEINGKPC(HGMLIMKFJCF FNJEPDKDNHM);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x49F6E80", Offset = "0x49F5E80", VA = "0x1849F6E80")]
	[MonoPInvokeCallback(typeof(HGMLIMKFJCF))]
	private static void JIGNAABHCFN(IntPtr MOLEAEHPOIL, int ACFAACNMEBO, int IPNLNELEEMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x49F6D20", Offset = "0x49F5D20", VA = "0x1849F6D20")]
	private static extern void FHOGAAHHIBC();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x49F6CB0", Offset = "0x49F5CB0", VA = "0x1849F6CB0")]
	private static extern void JECJPKNKPEM();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x49F6D90", Offset = "0x49F5D90", VA = "0x1849F6D90")]
	private static extern int MOAHJOJHMID();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x49F6C30", Offset = "0x49F5C30", VA = "0x1849F6C30")]
	private static extern int DMHIAOOOHLG(int HJPPHGKEPAC);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x49F6E00", Offset = "0x49F5E00", VA = "0x1849F6E00")]
	private static extern int IKDMEPFKDDF(int HJPPHGKEPAC);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x49F7020", Offset = "0x49F6020", VA = "0x1849F7020")]
	private static extern int NLIDDBOKAHD(int HJPPHGKEPAC);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x49F6FA0", Offset = "0x49F5FA0", VA = "0x1849F6FA0")]
	private static extern int KCODEJJCPAH(int HJPPHGKEPAC);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x49F7320", Offset = "0x49F6320", VA = "0x1849F7320")]
	public CMGGKGKJGEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x49F6CB0", Offset = "0x49F5CB0", VA = "0x1849F6CB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x49F7130", Offset = "0x49F6130", VA = "0x1849F7130")]
	public Rect OHEKIGFLCOC(int JLALEGMDHKF)
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
