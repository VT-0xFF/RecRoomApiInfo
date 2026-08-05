using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface JCEGDNMDGCD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string ECJAKIEFOFH(string IFNAJKAPIMA);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BMLLOOBPPFI(string IFNAJKAPIMA);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum KKCKCMDAPMH
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[Preserve]
public class CCPIPIHFAII : JCEGDNMDGCD
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> JAMAIMODJLM;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] JDANBCBGPCH;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] APFEOHAMIEP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] GDNBNGNKJOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x627E0F0", Offset = "0x627CAF0", VA = "0x18627E0F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] NEFGIMOHBAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x627E510", Offset = "0x627CF10", VA = "0x18627E510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x627E100", Offset = "0x627CB00", VA = "0x18627E100")]
	[JCOMPLNHMEG(EEKBGOJGGBC.Root, AOHDMBIABEL.GameOnly)]
	private static void EBMPOMEGCDH(ICKBMMGCCPN NFHEIBLLDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x627E350", Offset = "0x627CD50", VA = "0x18627E350")]
	internal static string[] LOPEJFCCJBK(string[] EFGKBBNGLDL, string[] IFADEIEAPMC, List<string> BNOKJMHJOJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x627E2B0", Offset = "0x627CCB0", VA = "0x18627E2B0", Slot = "4")]
	private string IFKBNKMBOEB(string IFNAJKAPIMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x627E200", Offset = "0x627CC00", VA = "0x18627E200")]
	public static string ECJAKIEFOFH(string IFNAJKAPIMA, [Optional] string LFANPJOLHJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x627E470", Offset = "0x627CE70", VA = "0x18627E470", Slot = "5")]
	private bool NPLPLFMEAAA(string IFNAJKAPIMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x627E050", Offset = "0x627CA50", VA = "0x18627E050")]
	public static bool BMLLOOBPPFI(string IFNAJKAPIMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public CCPIPIHFAII()
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
