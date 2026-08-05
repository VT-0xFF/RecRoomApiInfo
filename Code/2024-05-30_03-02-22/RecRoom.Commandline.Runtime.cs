using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface FPBIJPAGILE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string BDFNHDJGGMG(string NAFMIFDABCH);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PDAKMGGALJP(string NAFMIFDABCH);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum IBKJLLCNNDN
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[Preserve]
public class CMLDCLOBLOF : FPBIJPAGILE
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> COBFKBCGGGI;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] AOEMFHFHENN;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] CLGGDHCBJME;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] DLKGMDLJIMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x633C480", Offset = "0x633B680", VA = "0x18633C480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] HKCHHNIKAIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x633BF70", Offset = "0x633B170", VA = "0x18633BF70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x633C270", Offset = "0x633B470", VA = "0x18633C270")]
	[JIMPHGEJKMA(NFKMIHJOIMG.Root, CLDBMEKPFFP.GameOnly)]
	private static void DPFLJEJBPJI(EHGDBDLIOFB IFAAMIKFIMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x633C360", Offset = "0x633B560", VA = "0x18633C360")]
	internal static string[] FPKBJHAHLJH(string[] IJJAHFFDDEI, string[] HNOKAGKLENF, List<string> JNDDGDMAJNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x633C490", Offset = "0x633B690", VA = "0x18633C490", Slot = "4")]
	private string LAKJDEAGBGP(string NAFMIFDABCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x633C120", Offset = "0x633B320", VA = "0x18633C120")]
	public static string BDFNHDJGGMG(string NAFMIFDABCH, [Optional] string AKBALOLNFML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x633C1D0", Offset = "0x633B3D0", VA = "0x18633C1D0", Slot = "5")]
	private bool CANMMLOJKKF(string NAFMIFDABCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x633C530", Offset = "0x633B730", VA = "0x18633C530")]
	public static bool PDAKMGGALJP(string NAFMIFDABCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public CMLDCLOBLOF()
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
