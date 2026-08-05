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
	public class _AssemblyIndex : GADMOBJFAOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6D10C80", Offset = "0x6D10080", VA = "0x186D10C80", Slot = "8")]
		public override void NALDPPFDOAA(JBGBENDLNHF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x64A1D70", Offset = "0x64A1170", VA = "0x1864A1D70")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EFCBEDINLOF
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string JBPFLGGDACH(string BKLOOOLLNJH);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NDNIMINLNBP(string BKLOOOLLNJH);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum CMACOKLPNOI
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.NoEngine.Common.Preserve]
public class CHABOMOCMLM : EFCBEDINLOF
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> GILAJNDNJHL;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] EDKKKFMPABH;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] NLEOGCHLBHG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] ODBNFHPECHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6D10BD0", Offset = "0x6D0FFD0", VA = "0x186D10BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] ECLHCBJOKNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6D10610", Offset = "0x6D0FA10", VA = "0x186D10610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6D107B0", Offset = "0x6D0FBB0", VA = "0x186D107B0")]
	[FHFMOACGLML.PCGBCKINAAE]
	internal static void EJGLCCJGHFF(ACFNHMKNHLL KLAPMCLMAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6D10A00", Offset = "0x6D0FE00", VA = "0x186D10A00")]
	internal static string[] LBGGBHJFPBE(string[] OIOIJLCNPEP, string[] AENDPDFOIFL, List<string> GBKLPFEDJCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6D10B20", Offset = "0x6D0FF20", VA = "0x186D10B20", Slot = "4")]
	private string MGEKENBINNJ(string BKLOOOLLNJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6D10950", Offset = "0x6D0FD50", VA = "0x186D10950")]
	public static string JBPFLGGDACH(string BKLOOOLLNJH, [Optional] string JGBDACMOCCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6D108B0", Offset = "0x6D0FCB0", VA = "0x186D108B0", Slot = "5")]
	private bool ELILNDAPIJC(string BKLOOOLLNJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6D10BE0", Offset = "0x6D0FFE0", VA = "0x186D10BE0")]
	public static bool NDNIMINLNBP(string BKLOOOLLNJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public CHABOMOCMLM()
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
