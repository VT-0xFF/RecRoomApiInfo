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
		[Cpp2IlInjected.Address(RVA = "0x680DB30", Offset = "0x680C530", VA = "0x18680DB30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] GOMAMLKLLHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x680D7C0", Offset = "0x680C1C0", VA = "0x18680D7C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x680D6C0", Offset = "0x680C0C0", VA = "0x18680D6C0")]
	[GDGALFJPCGE(JAFPILLCEJB.Root, JMIPDAHBNNG.None)]
	private static void CEJDNEABNOB(INCIOHANCNE PGHIDIKDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x680DA10", Offset = "0x680C410", VA = "0x18680DA10")]
	internal static string[] KLLNOBMBDJN(string[] BANEIFNGOHB, string[] CGIMFEAGNGA, List<string> CCEDJJKPPKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x680D970", Offset = "0x680C370", VA = "0x18680D970", Slot = "4")]
	private string KFIGOGOKJOB(string NNJFFKDDDDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x680DBE0", Offset = "0x680C5E0", VA = "0x18680DBE0")]
	public static string PDOJJKADLKP(string NNJFFKDDDDA, [Optional] string LIAHLPBCKNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x680D620", Offset = "0x680C020", VA = "0x18680D620", Slot = "5")]
	private bool BCGGLLPAKPK(string NNJFFKDDDDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x680DB40", Offset = "0x680C540", VA = "0x18680DB40")]
	public static bool MPKOIKLDAGP(string NNJFFKDDDDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
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
