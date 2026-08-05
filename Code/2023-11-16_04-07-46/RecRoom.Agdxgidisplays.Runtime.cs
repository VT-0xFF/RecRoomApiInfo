using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class KEDMGMPNIOA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum OOOLCBMCMJI
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void GGJBLJJJPIE(IntPtr ICLPGCHCHFB, int LHAIIFMNPNK, int KKJKLABBIJM);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int JGEBFEKBDBL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5CEEF00", Offset = "0x5CEDF00", VA = "0x185CEEF00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF260", Offset = "0x5CEE260", VA = "0x185CEF260")]
	private static extern void DNMPMJEHOMI(GGJBLJJJPIE CAEGDBPOJIB);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF3D0", Offset = "0x5CEE3D0", VA = "0x185CEF3D0")]
	[MonoPInvokeCallback(typeof(GGJBLJJJPIE))]
	private static void HBNEHKKCDCH(IntPtr ICLPGCHCHFB, int LHAIIFMNPNK, int KKJKLABBIJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF360", Offset = "0x5CEE360", VA = "0x185CEF360")]
	private static extern void EMCBFDNIFOC();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF2F0", Offset = "0x5CEE2F0", VA = "0x185CEF2F0")]
	private static extern void PICCDJPEAME();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5CEEF00", Offset = "0x5CEDF00", VA = "0x185CEEF00")]
	private static extern int AJCIOIEMGKJ();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5CEEF70", Offset = "0x5CEDF70", VA = "0x185CEEF70")]
	private static extern int BNFACKADJJO(int LPCEACMGEAL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF550", Offset = "0x5CEE550", VA = "0x185CEF550")]
	private static extern int PCCKBFCLPJN(int LPCEACMGEAL);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF4D0", Offset = "0x5CEE4D0", VA = "0x185CEF4D0")]
	private static extern int OJIIGPGPJOC(int LPCEACMGEAL);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF1E0", Offset = "0x5CEE1E0", VA = "0x185CEF1E0")]
	private static extern int CILBGFKFEHB(int LPCEACMGEAL);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF5D0", Offset = "0x5CEE5D0", VA = "0x185CEF5D0")]
	public KEDMGMPNIOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF2F0", Offset = "0x5CEE2F0", VA = "0x185CEF2F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5CEEFF0", Offset = "0x5CEDFF0", VA = "0x185CEEFF0")]
	public Rect BNMOCNEDNLJ(int NANKCKIJFJA)
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
