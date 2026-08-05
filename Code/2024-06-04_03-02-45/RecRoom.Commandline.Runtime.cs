using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface GJBKDFOHKAC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string ENINCBDIEEK(string JEOLOLCNKCP);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HIGIOFFPFFM(string JEOLOLCNKCP);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum HABFJDAGMHM
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[Preserve]
public class IMJGNFFKCLG : GJBKDFOHKAC
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> PEPGKLIBMPA;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] NAJOCEHEPBK;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] GHBPAAFFCOC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] DJOJFOBCPIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6793D80", Offset = "0x6792580", VA = "0x186793D80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] DMMCOAILMLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6793730", Offset = "0x6791F30", VA = "0x186793730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6793C80", Offset = "0x6792480", VA = "0x186793C80")]
	[ANLGLDAOJJE(KKPEBAHBECP.Root, ELBANFBEGNE.None)]
	private static void KLKHAMFMIOA(AANDDJDEEFL KDCLBHAMNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x67938D0", Offset = "0x67920D0", VA = "0x1867938D0")]
	internal static string[] DKNOOHNFKOM(string[] JGLFOKLAGEH, string[] LGBIDGEOBCF, List<string> PGBBLHHKFLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6793A90", Offset = "0x6792290", VA = "0x186793A90", Slot = "4")]
	private string EIHHMGPGIBF(string JEOLOLCNKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6793B30", Offset = "0x6792330", VA = "0x186793B30")]
	public static string ENINCBDIEEK(string JEOLOLCNKCP, [Optional] string HLCNDDGKJJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x67939F0", Offset = "0x67921F0", VA = "0x1867939F0", Slot = "5")]
	private bool DLBFOFDDKMB(string JEOLOLCNKCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6793BE0", Offset = "0x67923E0", VA = "0x186793BE0")]
	public static bool HIGIOFFPFFM(string JEOLOLCNKCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public IMJGNFFKCLG()
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
