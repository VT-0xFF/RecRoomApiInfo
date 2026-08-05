using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface MOEBOEFMMFE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string PDOJJKADLKP(string NNJFFKDDDDA);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MPKOIKLDAGP(string NNJFFKDDDDA);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum PEEPIKHEAEL
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[Preserve]
public class INIBPOPEGBE : MOEBOEFMMFE
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> DAKDCACLPJP;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] GABKOBMMFOD;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] PFPFHBDEDKM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] OEMBFAJKAPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6827DF0", Offset = "0x6826FF0", VA = "0x186827DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] GOMAMLKLLHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6827A80", Offset = "0x6826C80", VA = "0x186827A80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6827980", Offset = "0x6826B80", VA = "0x186827980")]
	[GDGALFJPCGE(JAFPILLCEJB.Root, JMIPDAHBNNG.None)]
	private static void CEJDNEABNOB(INCIOHANCNE PGHIDIKDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6827CD0", Offset = "0x6826ED0", VA = "0x186827CD0")]
	internal static string[] KLLNOBMBDJN(string[] BANEIFNGOHB, string[] CGIMFEAGNGA, List<string> CCEDJJKPPKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6827C30", Offset = "0x6826E30", VA = "0x186827C30", Slot = "4")]
	private string KFIGOGOKJOB(string NNJFFKDDDDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6827EA0", Offset = "0x68270A0", VA = "0x186827EA0")]
	public static string PDOJJKADLKP(string NNJFFKDDDDA, [Optional] string LIAHLPBCKNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x68278E0", Offset = "0x6826AE0", VA = "0x1868278E0", Slot = "5")]
	private bool BCGGLLPAKPK(string NNJFFKDDDDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6827E00", Offset = "0x6827000", VA = "0x186827E00")]
	public static bool MPKOIKLDAGP(string NNJFFKDDDDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
	public INIBPOPEGBE()
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
