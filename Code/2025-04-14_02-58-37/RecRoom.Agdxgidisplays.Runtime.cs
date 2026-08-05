using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class PGMKNKELHKL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum IBIPFJDHFPE
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void GNANAEKLDHH(IntPtr EELGNOJLLOB, int PICLDLMFMMM, int AOLOOHICCCF);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int BHNOKHDAMPH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x767DB60", Offset = "0x767C560", VA = "0x18767DB60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x767DE30", Offset = "0x767C830", VA = "0x18767DE30")]
	private static extern void LEJAKDGNJMA(GNANAEKLDHH PCKPGHHEKOC);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x767DF40", Offset = "0x767C940", VA = "0x18767DF40")]
	[MonoPInvokeCallback(typeof(GNANAEKLDHH))]
	private static void LNKGCDIPKOJ(IntPtr EELGNOJLLOB, int PICLDLMFMMM, int AOLOOHICCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x767DCC0", Offset = "0x767C6C0", VA = "0x18767DCC0")]
	private static extern void ELAEPFFNBKM();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x767DC50", Offset = "0x767C650", VA = "0x18767DC50")]
	private static extern void IHJFBMAICBO();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x767DB60", Offset = "0x767C560", VA = "0x18767DB60")]
	private static extern int CGIFELDPDNE();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x767DDB0", Offset = "0x767C7B0", VA = "0x18767DDB0")]
	private static extern int HLOFJNMHMBM(int ICHIIHCEGJD);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x767DD30", Offset = "0x767C730", VA = "0x18767DD30")]
	private static extern int FGEGJPMFIKK(int ICHIIHCEGJD);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x767DEC0", Offset = "0x767C8C0", VA = "0x18767DEC0")]
	private static extern int LNJOFKJFKBH(int ICHIIHCEGJD);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x767DBD0", Offset = "0x767C5D0", VA = "0x18767DBD0")]
	private static extern int DKEOMLCJGHD(int ICHIIHCEGJD);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x767E230", Offset = "0x767CC30", VA = "0x18767E230")]
	public PGMKNKELHKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x767DC50", Offset = "0x767C650", VA = "0x18767DC50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x767E040", Offset = "0x767CA40", VA = "0x18767E040")]
	public Rect MBMELOCCJNE(int CJJAAJCLMJI)
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
