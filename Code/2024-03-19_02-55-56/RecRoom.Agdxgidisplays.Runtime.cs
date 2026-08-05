using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class MGJDEAABPAB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum BJHKOHKNPDC
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void KABFNKJNCEL(IntPtr LFFEKPPMJHN, int BEELDCKKFJL, int NECIFDPNBPN);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int BGFILDMBMAC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x602F2D0", Offset = "0x602E2D0", VA = "0x18602F2D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x602F810", Offset = "0x602E810", VA = "0x18602F810")]
	private static extern void MCGLBAEJCBE(KABFNKJNCEL ADABDJONAPD);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x602F710", Offset = "0x602E710", VA = "0x18602F710")]
	[MonoPInvokeCallback(typeof(KABFNKJNCEL))]
	private static void IEMGFLKIGKK(IntPtr LFFEKPPMJHN, int BEELDCKKFJL, int NECIFDPNBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x602F3C0", Offset = "0x602E3C0", VA = "0x18602F3C0")]
	private static extern void DPGLELIALOP();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x602F430", Offset = "0x602E430", VA = "0x18602F430")]
	private static extern void KAPFNIBMLFD();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x602F2D0", Offset = "0x602E2D0", VA = "0x18602F2D0")]
	private static extern int CNGLGHIELPM();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x602F250", Offset = "0x602E250", VA = "0x18602F250")]
	private static extern int AHIIAHEOKBJ(int IJKMNFNHLGO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x602F8A0", Offset = "0x602E8A0", VA = "0x18602F8A0")]
	private static extern int PDBNOMGCMPP(int IJKMNFNHLGO);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x602F340", Offset = "0x602E340", VA = "0x18602F340")]
	private static extern int COCININNGLF(int IJKMNFNHLGO);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x602F4A0", Offset = "0x602E4A0", VA = "0x18602F4A0")]
	private static extern int HJLLDNDBBOF(int IJKMNFNHLGO);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x602F920", Offset = "0x602E920", VA = "0x18602F920")]
	public MGJDEAABPAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x602F430", Offset = "0x602E430", VA = "0x18602F430", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x602F520", Offset = "0x602E520", VA = "0x18602F520")]
	public Rect IEBLGEMGDMO(int ELGKGBJKOEM)
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
