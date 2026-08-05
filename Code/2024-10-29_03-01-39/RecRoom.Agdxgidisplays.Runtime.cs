using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class BBPAAGNGEIH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum CICEMIMEAMG
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void OBNMLHHKDFN(IntPtr ONMEAHDGGOB, int MLDINGBBEHA, int NNMDEKGGCFM);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int BLANDKNDAJI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6D02D40", Offset = "0x6D01D40", VA = "0x186D02D40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6D02BD0", Offset = "0x6D01BD0", VA = "0x186D02BD0")]
	private static extern void BHEHOFFFIAN(OBNMLHHKDFN BLNJHEMNIGB);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6D02AD0", Offset = "0x6D01AD0", VA = "0x186D02AD0")]
	[MonoPInvokeCallback(typeof(OBNMLHHKDFN))]
	private static void BCJMMALHIFB(IntPtr ONMEAHDGGOB, int MLDINGBBEHA, int NNMDEKGGCFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6D02C60", Offset = "0x6D01C60", VA = "0x186D02C60")]
	private static extern void CPDDJGLEDNE();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6D02CD0", Offset = "0x6D01CD0", VA = "0x186D02CD0")]
	private static extern void DGHCPDPHLHJ();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6D02D40", Offset = "0x6D01D40", VA = "0x186D02D40")]
	private static extern int DIJGAJNJMNH();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6D03120", Offset = "0x6D02120", VA = "0x186D03120")]
	private static extern int MNJGBELCJIN(int JHCIODFGPNM);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6D02DB0", Offset = "0x6D01DB0", VA = "0x186D02DB0")]
	private static extern int FJBNPDLPIOJ(int JHCIODFGPNM);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6D03020", Offset = "0x6D02020", VA = "0x186D03020")]
	private static extern int IKOAPLEBJCB(int JHCIODFGPNM);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6D030A0", Offset = "0x6D020A0", VA = "0x186D030A0")]
	private static extern int LMDFEDALLBA(int JHCIODFGPNM);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6D031A0", Offset = "0x6D021A0", VA = "0x186D031A0")]
	public BBPAAGNGEIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6D02CD0", Offset = "0x6D01CD0", VA = "0x186D02CD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6D02E30", Offset = "0x6D01E30", VA = "0x186D02E30")]
	public Rect IDJGJDHIAAO(int BNMKECBDENE)
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
