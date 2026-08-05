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
		[Cpp2IlInjected.Address(RVA = "0x71AB0C0", Offset = "0x71A9EC0", VA = "0x1871AB0C0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2408FF0", Offset = "0x2407DF0", VA = "0x182408FF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EAFPFOIDFDM
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string ICBDLPHEIEP(string KBFABHDAKIJ);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KNIAGDKGGCJ(string KBFABHDAKIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum GIPEAKHDDMG
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.NoEngine.Common.Preserve]
public class FBEMPHELAGN : EAFPFOIDFDM
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> KMBFFBMKIND;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] IOLNCCDEJNJ;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] CFKDPLIFGBB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] LBBBHALLJGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x71AAF00", Offset = "0x71A9D00", VA = "0x1871AAF00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] GINBBGOKDOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x71AAF10", Offset = "0x71A9D10", VA = "0x1871AAF10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x71AAA50", Offset = "0x71A9850", VA = "0x1871AAA50")]
	[FOLINPJCBJN.HMBDLNHFFEJ]
	internal static void GGGLAIJELEP(IEPIHLKICIO BCNFHKMHIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x71AAD40", Offset = "0x71A9B40", VA = "0x1871AAD40")]
	internal static string[] JMPEJHBJPMI(string[] NHCNBFALHIO, string[] MDPGBJNNLAH, List<string> MBNCPBMILLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x71AAB40", Offset = "0x71A9940", VA = "0x1871AAB40", Slot = "4")]
	private string HGGLJAHHKED(string KBFABHDAKIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x71AAC90", Offset = "0x71A9A90", VA = "0x1871AAC90")]
	public static string ICBDLPHEIEP(string KBFABHDAKIJ, [Optional] string KBHDDKCAINE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x71AABF0", Offset = "0x71A99F0", VA = "0x1871AABF0", Slot = "5")]
	private bool HJLCEIDJGAM(string KBFABHDAKIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x71AAE60", Offset = "0x71A9C60", VA = "0x1871AAE60")]
	public static bool KNIAGDKGGCJ(string KBFABHDAKIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public FBEMPHELAGN()
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
