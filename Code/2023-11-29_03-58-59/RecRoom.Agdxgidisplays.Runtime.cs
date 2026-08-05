using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class DAHNJECPPBE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum HELACLHMHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void HPBNBMHKOAA(IntPtr JAFMNEFDFCM, int PEGIIHFIAHP, int MHGDECGILLH);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int HICMHABKCFK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5D0CDD0", Offset = "0x5D0C1D0", VA = "0x185D0CDD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5D0D210", Offset = "0x5D0C610", VA = "0x185D0D210")]
	private static extern void LJJPJGBGFHK(HPBNBMHKOAA PDECDCHNHMC);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5D0D2A0", Offset = "0x5D0C6A0", VA = "0x185D0D2A0")]
	[MonoPInvokeCallback(typeof(HPBNBMHKOAA))]
	private static void LLIJKPABKFP(IntPtr JAFMNEFDFCM, int PEGIIHFIAHP, int MHGDECGILLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5D0D1A0", Offset = "0x5D0C5A0", VA = "0x185D0D1A0")]
	private static extern void GJHPIDDJMKM();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5D0CEC0", Offset = "0x5D0C2C0", VA = "0x185D0CEC0")]
	private static extern void HOJEPNNNBHH();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5D0CDD0", Offset = "0x5D0C1D0", VA = "0x185D0CDD0")]
	private static extern int CKFCJLDEGHH();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5D0D3A0", Offset = "0x5D0C7A0", VA = "0x185D0D3A0")]
	private static extern int NMGBOPLPEJN(int EPDCALNHKAP);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5D0CD50", Offset = "0x5D0C150", VA = "0x185D0CD50")]
	private static extern int BADMJPLOHNL(int EPDCALNHKAP);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5D0CE40", Offset = "0x5D0C240", VA = "0x185D0CE40")]
	private static extern int DCDBJFLNBII(int EPDCALNHKAP);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5D0D120", Offset = "0x5D0C520", VA = "0x185D0D120")]
	private static extern int GCNPKLLCPKH(int EPDCALNHKAP);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5D0D420", Offset = "0x5D0C820", VA = "0x185D0D420")]
	public DAHNJECPPBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5D0CEC0", Offset = "0x5D0C2C0", VA = "0x185D0CEC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5D0CF30", Offset = "0x5D0C330", VA = "0x185D0CF30")]
	public Rect EKGBLIOILDP(int POENBPAKDPH)
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
