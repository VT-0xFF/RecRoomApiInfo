using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class CBJABEPIOPG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum CMLAEMFEIIE
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void GMOAJMHLMNK(IntPtr BOBJBDACGIL, int LBLAPKMJFKP, int NFABGLNBNGN);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int ADDJAKEGIMH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1AF0", Offset = "0x5EC08F0", VA = "0x185EC1AF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1F70", Offset = "0x5EC0D70", VA = "0x185EC1F70")]
	private static extern void JBMNMDNMMAM(GMOAJMHLMNK PKPGAEOFIGD);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1C50", Offset = "0x5EC0A50", VA = "0x185EC1C50")]
	[MonoPInvokeCallback(typeof(GMOAJMHLMNK))]
	private static void EEMAHKAACBE(IntPtr BOBJBDACGIL, int LBLAPKMJFKP, int NFABGLNBNGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1D80", Offset = "0x5EC0B80", VA = "0x185EC1D80")]
	private static extern void FNJOFAEFPIL();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1B60", Offset = "0x5EC0960", VA = "0x185EC1B60")]
	private static extern void KFFGEANHPNL();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1AF0", Offset = "0x5EC08F0", VA = "0x185EC1AF0")]
	private static extern int CLJODIHEFKH();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1BD0", Offset = "0x5EC09D0", VA = "0x185EC1BD0")]
	private static extern int EEKDDEGNMDO(int GLGEGPNMJGF);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1E70", Offset = "0x5EC0C70", VA = "0x185EC1E70")]
	private static extern int INONLGOOMKP(int GLGEGPNMJGF);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1EF0", Offset = "0x5EC0CF0", VA = "0x185EC1EF0")]
	private static extern int JBEFPDPONDK(int GLGEGPNMJGF);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1DF0", Offset = "0x5EC0BF0", VA = "0x185EC1DF0")]
	private static extern int IINPBCPOBAJ(int GLGEGPNMJGF);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5EC21F0", Offset = "0x5EC0FF0", VA = "0x185EC21F0")]
	public CBJABEPIOPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1B60", Offset = "0x5EC0960", VA = "0x185EC1B60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5EC2000", Offset = "0x5EC0E00", VA = "0x185EC2000")]
	public Rect KGDIMNJNPHF(int GPMKKCCLKKP)
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
