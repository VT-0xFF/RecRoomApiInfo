using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface APACBPMHPBF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string HJBMONLMBJM(string HLLDCJMGAKE);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HFDFNIKIGGJ(string HLLDCJMGAKE);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum FPEOIHKBGOB
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[Preserve]
public class OKGEGACCDBC : APACBPMHPBF
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> CFKPBKFNDNF;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] BOOOJHADEGD;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] LACHJBCHMKP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] IHCFPPJKFCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6809E40", Offset = "0x6808A40", VA = "0x186809E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] BBBKBMBJBLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6809C90", Offset = "0x6808890", VA = "0x186809C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6809FA0", Offset = "0x6808BA0", VA = "0x186809FA0")]
	[FJJFAIMPJIC(AMDAGODFNAF.Root, JBEKPLNNIEC.None)]
	private static void LLDKNAFABLI(LLIMAHMFNLB INBELNINGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6809AD0", Offset = "0x68086D0", VA = "0x186809AD0")]
	internal static string[] CFLKHCBPOKJ(string[] KKNJJGOAEMF, string[] AJMCKBHDGIK, List<string> CPBMJDHOAFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6809A30", Offset = "0x6808630", VA = "0x186809A30", Slot = "4")]
	private string AMNGNPNECBH(string HLLDCJMGAKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6809EF0", Offset = "0x6808AF0", VA = "0x186809EF0")]
	public static string HJBMONLMBJM(string HLLDCJMGAKE, [Optional] string NJMAFDCOBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6809BF0", Offset = "0x68087F0", VA = "0x186809BF0", Slot = "5")]
	private bool DDAMIECIIOH(string HLLDCJMGAKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6809E50", Offset = "0x6808A50", VA = "0x186809E50")]
	public static bool HFDFNIKIGGJ(string HLLDCJMGAKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public OKGEGACCDBC()
	{
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
