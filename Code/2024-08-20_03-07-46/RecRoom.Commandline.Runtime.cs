using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface IGHABHKBPPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string IPEOFKOMDCF(string BOJMPDAJCJP);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PMMICJNHJBB(string BOJMPDAJCJP);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum AOCAIGFKKLN
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[Preserve]
public class FLAEEEPEGLH : IGHABHKBPPJ
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> DNJBBDBLALB;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] LBKMCIGJGCG;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] MCINANHHJIF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] OIHLPIAGNOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x68B0F60", Offset = "0x68AFF60", VA = "0x1868B0F60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] BEHNPICGJAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x68B1280", Offset = "0x68B0280", VA = "0x1868B1280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x68B0E60", Offset = "0x68AFE60", VA = "0x1868B0E60")]
	[ONAOIKEPAJE(NOFONODCPKJ.Root, IKAJKCKEGIH.None)]
	private static void ACLEMPFHCOI(NDJGECDCBMH MMBLPJPOBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x68B1020", Offset = "0x68B0020", VA = "0x1868B1020")]
	internal static string[] JNMGNFNOGLM(string[] BEFIADFHJAH, string[] IJLNNNNBLDM, List<string> DHLBCKNLKPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x68B11E0", Offset = "0x68B01E0", VA = "0x1868B11E0", Slot = "4")]
	private string LGPGLCKOBJF(string BOJMPDAJCJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x68B0F70", Offset = "0x68AFF70", VA = "0x1868B0F70")]
	public static string IPEOFKOMDCF(string BOJMPDAJCJP, [Optional] string KCDEJIJHLPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x68B1140", Offset = "0x68B0140", VA = "0x1868B1140", Slot = "5")]
	private bool KJDBLMACCNI(string BOJMPDAJCJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x68B1430", Offset = "0x68B0430", VA = "0x1868B1430")]
	public static bool PMMICJNHJBB(string BOJMPDAJCJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public FLAEEEPEGLH()
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
