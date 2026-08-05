using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface DMPDNFFPHIL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string HAGNINOMGEH(string JJCMLJHKNHF);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CAMODCFCIAC(string JJCMLJHKNHF);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum BMLFABFIHNE
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[Preserve]
public class PGPHBBHGONF : DMPDNFFPHIL
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> GJHCGKNJDLO;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] DAJFONDECPJ;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] JLBIGBHNFJJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] LCNDDPBACPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6800CF0", Offset = "0x67FF6F0", VA = "0x186800CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] IPFJJIGPEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x68010F0", Offset = "0x67FFAF0", VA = "0x1868010F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6800E40", Offset = "0x67FF840", VA = "0x186800E40")]
	[MHFEIEAPENL(ABEEEPGJOJM.Root, CMFCLNIIIKO.None)]
	private static void FIFELDOAMFC(GPECMKAJNMD FOPICBKBDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6800F30", Offset = "0x67FF930", VA = "0x186800F30")]
	internal static string[] GIADNGEDLEH(string[] GJONJMJOBJG, string[] NLGPLOEOOFF, List<string> AEFGJGIFIBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6800DA0", Offset = "0x67FF7A0", VA = "0x186800DA0", Slot = "4")]
	private string CPKCDFKCJAI(string JJCMLJHKNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x68012A0", Offset = "0x67FFCA0", VA = "0x1868012A0")]
	public static string HAGNINOMGEH(string JJCMLJHKNHF, [Optional] string JIEGAHKKHCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6801050", Offset = "0x67FFA50", VA = "0x186801050", Slot = "5")]
	private bool GJCHLGBIBGG(string JJCMLJHKNHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6800D00", Offset = "0x67FF700", VA = "0x186800D00")]
	public static bool CAMODCFCIAC(string JJCMLJHKNHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public PGPHBBHGONF()
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
