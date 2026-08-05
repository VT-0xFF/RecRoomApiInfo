using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_Commandline_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : PBJLLMOALLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6B87490", Offset = "0x6B85E90", VA = "0x186B87490", Slot = "8")]
		public override void BHEMPDPJNII(CGCPPALGHJA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x632F010", Offset = "0x632DA10", VA = "0x18632F010")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MJMGCOPIBMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string OCEDCHDGHPO(string BPFGNDAPKAJ);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PHBEIMJPKNG(string BPFGNDAPKAJ);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum HIPNFHMBMPE
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.NoEngine.Common.Preserve]
public class DDOOCEKNAEG : MJMGCOPIBMJ
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> LLGHMGGNOOF;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] IIPCPMFBLEA;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] PDFBDEIJGDI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] HLBMNIIFCBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6B86F50", Offset = "0x6B85950", VA = "0x186B86F50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] EFBCAMBCBJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6B870A0", Offset = "0x6B85AA0", VA = "0x186B870A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6B87240", Offset = "0x6B85C40", VA = "0x186B87240")]
	[DJINMBCHLNM.LIHKMGLKGEL]
	internal static void MNJJOBMFJLK(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6B86E30", Offset = "0x6B85830", VA = "0x186B86E30")]
	internal static string[] FJANKGEADJM(string[] POGACIDICCA, string[] FGJBNMLHBBJ, List<string> MCHPFLKOMAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6B86F60", Offset = "0x6B85960", VA = "0x186B86F60", Slot = "4")]
	private string IAJLPGDEIHB(string BPFGNDAPKAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6B87340", Offset = "0x6B85D40", VA = "0x186B87340")]
	public static string OCEDCHDGHPO(string BPFGNDAPKAJ, [Optional] string MCAGMGIJFIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6B87000", Offset = "0x6B85A00", VA = "0x186B87000", Slot = "5")]
	private bool JOFPJJICPEP(string BPFGNDAPKAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6B873F0", Offset = "0x6B85DF0", VA = "0x186B873F0")]
	public static bool PHBEIMJPKNG(string BPFGNDAPKAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public DDOOCEKNAEG()
	{
	}
}
namespace Cpp2IlInjected
{
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
}
