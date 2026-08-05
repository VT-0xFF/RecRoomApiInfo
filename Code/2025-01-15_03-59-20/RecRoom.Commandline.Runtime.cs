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
		[Cpp2IlInjected.Address(RVA = "0x6F26AE0", Offset = "0x6F25EE0", VA = "0x186F26AE0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2200990", Offset = "0x21FFD90", VA = "0x182200990")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CIAOODONNGG
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string PPHDNJKJJFJ(string ILIFBFJMIFP);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DKKFHNMEDND(string ILIFBFJMIFP);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum POGOHEIDKNP
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.NoEngine.Common.Preserve]
public class BLIHPINFPMA : CIAOODONNGG
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> BCKMHNOBGGO;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] DGIFCIEGDCH;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] PPCOGCLKNPI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] DLBBDMDLKDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F26480", Offset = "0x6F25880", VA = "0x186F26480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] KDMHFLLOODF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6F26580", Offset = "0x6F25980", VA = "0x186F26580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6F26490", Offset = "0x6F25890", VA = "0x186F26490")]
	[AGCFNMIICNN.OGAOPBBDHOG]
	internal static void BMOABOOGHNH(CGJHFFGEHKC CLDCJHAFFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6F26870", Offset = "0x6F25C70", VA = "0x186F26870")]
	internal static string[] NIJOIOPAMNN(string[] GCKCAAFFNCO, string[] CPBHNNGJGMN, List<string> OKJGBLAJIPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6F267C0", Offset = "0x6F25BC0", VA = "0x186F267C0", Slot = "4")]
	private string DMAMMJCMDBI(string ILIFBFJMIFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6F26A30", Offset = "0x6F25E30", VA = "0x186F26A30")]
	public static string PPHDNJKJJFJ(string ILIFBFJMIFP, [Optional] string EKFBHIJFHMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6F26990", Offset = "0x6F25D90", VA = "0x186F26990", Slot = "5")]
	private bool PBNOENPFBEJ(string ILIFBFJMIFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6F26720", Offset = "0x6F25B20", VA = "0x186F26720")]
	public static bool DKKFHNMEDND(string ILIFBFJMIFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public BLIHPINFPMA()
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
