using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class MHHGBJFNJLD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum PCOONCKEOLN
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void NONKDPNGILC(IntPtr FEBOEFLLEJB, int OCMPILAHMAJ, int NKNMGCHEOFM);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int KHLOIGENDAD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6FFAEE0", Offset = "0x6FF94E0", VA = "0x186FFAEE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6FFACE0", Offset = "0x6FF92E0", VA = "0x186FFACE0")]
	private static extern void GABMENPPDDC(NONKDPNGILC AJNAMFOHMMI);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6FFB250", Offset = "0x6FF9850", VA = "0x186FFB250")]
	[MonoPInvokeCallback(typeof(NONKDPNGILC))]
	private static void PMMBNNEGJIL(IntPtr FEBOEFLLEJB, int OCMPILAHMAJ, int NKNMGCHEOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6FFAE70", Offset = "0x6FF9470", VA = "0x186FFAE70")]
	private static extern void GMAKAKECEDK();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6FFAC70", Offset = "0x6FF9270", VA = "0x186FFAC70")]
	private static extern void BOJICBDOAEP();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6FFAEE0", Offset = "0x6FF94E0", VA = "0x186FFAEE0")]
	private static extern int HJOMENAOOFP();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6FFAFD0", Offset = "0x6FF95D0", VA = "0x186FFAFD0")]
	private static extern int MJHECEFAODG(int MJBJADACIFB);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6FFAF50", Offset = "0x6FF9550", VA = "0x186FFAF50")]
	private static extern int HOFENCLDLPA(int MJBJADACIFB);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6FFAD70", Offset = "0x6FF9370", VA = "0x186FFAD70")]
	private static extern int GCJMDLJCJEG(int MJBJADACIFB);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6FFADF0", Offset = "0x6FF93F0", VA = "0x186FFADF0")]
	private static extern int GFGBAFNKHBM(int MJBJADACIFB);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6FFB380", Offset = "0x6FF9980", VA = "0x186FFB380")]
	public MHHGBJFNJLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6FFAC70", Offset = "0x6FF9270", VA = "0x186FFAC70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6FFB050", Offset = "0x6FF9650", VA = "0x186FFB050")]
	public Rect NEKNNMKHOJI(int GBIBHEEPMFD)
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
