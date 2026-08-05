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
		[Cpp2IlInjected.Address(RVA = "0x680DA30", Offset = "0x680C230", VA = "0x18680DA30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] GOMAMLKLLHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x680D6C0", Offset = "0x680BEC0", VA = "0x18680D6C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x680D5C0", Offset = "0x680BDC0", VA = "0x18680D5C0")]
	[GDGALFJPCGE(JAFPILLCEJB.Root, JMIPDAHBNNG.None)]
	private static void CEJDNEABNOB(INCIOHANCNE PGHIDIKDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x680D910", Offset = "0x680C110", VA = "0x18680D910")]
	internal static string[] KLLNOBMBDJN(string[] BANEIFNGOHB, string[] CGIMFEAGNGA, List<string> CCEDJJKPPKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x680D870", Offset = "0x680C070", VA = "0x18680D870", Slot = "4")]
	private string KFIGOGOKJOB(string NNJFFKDDDDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x680DAE0", Offset = "0x680C2E0", VA = "0x18680DAE0")]
	public static string PDOJJKADLKP(string NNJFFKDDDDA, [Optional] string LIAHLPBCKNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x680D520", Offset = "0x680BD20", VA = "0x18680D520", Slot = "5")]
	private bool BCGGLLPAKPK(string NNJFFKDDDDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x680DA40", Offset = "0x680C240", VA = "0x18680DA40")]
	public static bool MPKOIKLDAGP(string NNJFFKDDDDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
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
