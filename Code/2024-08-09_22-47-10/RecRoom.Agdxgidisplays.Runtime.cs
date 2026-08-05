using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class CMLCJLOMOHG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum IKMPMAHHLOC
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void IEFBJPKHKFE(IntPtr BNAGIPDFDCE, int CGDIEJGGJMK, int OHDGLIBNCND);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int JAIDKEDLJHK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6762020", Offset = "0x6761420", VA = "0x186762020")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6761BB0", Offset = "0x6760FB0", VA = "0x186761BB0")]
	private static extern void AMLNKICELGN(IEFBJPKHKFE PKJIBFLDCKK);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6761CB0", Offset = "0x67610B0", VA = "0x186761CB0")]
	[MonoPInvokeCallback(typeof(IEFBJPKHKFE))]
	private static void IJEDBDPLIAE(IntPtr BNAGIPDFDCE, int CGDIEJGGJMK, int OHDGLIBNCND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6762090", Offset = "0x6761490", VA = "0x186762090")]
	private static extern void MGIGIPLLEKC();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6761C40", Offset = "0x6761040", VA = "0x186761C40")]
	private static extern void IIINOLAHMOD();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6762020", Offset = "0x6761420", VA = "0x186762020")]
	private static extern int OCDOBOPAELO();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6761DB0", Offset = "0x67611B0", VA = "0x186761DB0")]
	private static extern int INBEOKBPMGC(int GNBDDFJPEIA);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6762180", Offset = "0x6761580", VA = "0x186762180")]
	private static extern int PCNPGCNIAFA(int GNBDDFJPEIA);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6762200", Offset = "0x6761600", VA = "0x186762200")]
	private static extern int PHCIJKJHCFE(int GNBDDFJPEIA);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6762100", Offset = "0x6761500", VA = "0x186762100")]
	private static extern int NAAGDNNGEBC(int GNBDDFJPEIA);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6762280", Offset = "0x6761680", VA = "0x186762280")]
	public CMLCJLOMOHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6761C40", Offset = "0x6761040", VA = "0x186761C40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6761E30", Offset = "0x6761230", VA = "0x186761E30")]
	public Rect JJNAEAMHKNA(int AAOCADIHMBF)
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
