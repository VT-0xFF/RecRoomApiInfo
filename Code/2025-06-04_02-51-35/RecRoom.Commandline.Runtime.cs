using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_Commandline_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7EBE010", Offset = "0x7EBC810", VA = "0x187EBE010", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2731690", Offset = "0x272FE90", VA = "0x182731690")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface FPGAEAPOKAG
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string KNJMEKDFGMP(string EKCIHMCINHA);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NDKGEGCKDLG(string EKCIHMCINHA);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum AFOMKEDNMKE
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.NoEngine.Common.Preserve]
public class ANKPPNJAFFO : FPGAEAPOKAG
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> DJPELLFPACD;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] EBBCLGOFENG;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] IGHDBKHBDHK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] OMLNFEPKGHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7EBD9B0", Offset = "0x7EBC1B0", VA = "0x187EBD9B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] OEHDCGMELLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7EBDE70", Offset = "0x7EBC670", VA = "0x187EBDE70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7EBDC40", Offset = "0x7EBC440", VA = "0x187EBDC40")]
	[NOOFMBJKOEL.LBENCLOPAFN]
	internal static void MNKNDOLBIJB(OIKNHNBNAFI MBKOPLBCEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7EBDA70", Offset = "0x7EBC270", VA = "0x187EBDA70")]
	internal static string[] KIOCAPEBLAP(string[] BNDFEHABIEK, string[] NIFDKOAIAGL, List<string> BMOLNEPDJAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7EBD9C0", Offset = "0x7EBC1C0", VA = "0x187EBD9C0", Slot = "4")]
	private string HKOILOGJBOG(string EKCIHMCINHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7EBDB90", Offset = "0x7EBC390", VA = "0x187EBDB90")]
	public static string KNJMEKDFGMP(string EKCIHMCINHA, [Optional] string GJPLADDCFJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7EBDDD0", Offset = "0x7EBC5D0", VA = "0x187EBDDD0", Slot = "5")]
	private bool NKOEMIODIMC(string EKCIHMCINHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7EBDD30", Offset = "0x7EBC530", VA = "0x187EBDD30")]
	public static bool NDKGEGCKDLG(string EKCIHMCINHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public ANKPPNJAFFO()
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
