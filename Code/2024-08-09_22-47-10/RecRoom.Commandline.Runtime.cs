using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface BHGPECGFCKI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string LNDHKIHDFDF(string DFBFDLCGJNG);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OPJCIKIPJKP(string DFBFDLCGJNG);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum DLFJFANIMIK
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[Preserve]
public class BGBODHCMMCO : BHGPECGFCKI
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> NGOGCHFLKDM;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] AIAKEIBEIDO;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] NKPMHDPKEKC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] HGNNKJDNAJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x682D220", Offset = "0x682C620", VA = "0x18682D220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] AKHNEEFJEGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x682D070", Offset = "0x682C470", VA = "0x18682D070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x682D230", Offset = "0x682C630", VA = "0x18682D230")]
	[EAMANMFIEOM(LALOBMMKLJJ.Root, NBICBCAKHEI.None)]
	private static void KHJKHFBAEKH(NFLAEHJHNPL IFELLLJKHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x682CEB0", Offset = "0x682C2B0", VA = "0x18682CEB0")]
	internal static string[] AKDODEEHKIG(string[] OAOBGAHKIJN, string[] JHJLAHNMEMH, List<string> AOMJCCOJHOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x682D480", Offset = "0x682C880", VA = "0x18682D480", Slot = "4")]
	private string PLDGADPNMEK(string DFBFDLCGJNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x682D330", Offset = "0x682C730", VA = "0x18682D330")]
	public static string LNDHKIHDFDF(string DFBFDLCGJNG, [Optional] string DFNADAHDJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x682CFD0", Offset = "0x682C3D0", VA = "0x18682CFD0", Slot = "5")]
	private bool DIFHHNHOGHF(string DFBFDLCGJNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x682D3E0", Offset = "0x682C7E0", VA = "0x18682D3E0")]
	public static bool OPJCIKIPJKP(string DFBFDLCGJNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public BGBODHCMMCO()
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
