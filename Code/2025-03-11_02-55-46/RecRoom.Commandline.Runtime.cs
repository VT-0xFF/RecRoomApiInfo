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
		[Cpp2IlInjected.Address(RVA = "0x750F580", Offset = "0x750E980", VA = "0x18750F580", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2491CF0", Offset = "0x24910F0", VA = "0x182491CF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BKJMAIOCHPI
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string JCNKCLFLJCN(string MLLBPGGFLHM);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MMAAEJMDKMA(string MLLBPGGFLHM);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum KKPCAPJHGIH
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.NoEngine.Common.Preserve]
public class HCAHLAOOCEP : BKJMAIOCHPI
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> GGMAJJGIAFG;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] HDCJLEBIEGO;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] PGNFDEOIMME;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] CLMMOAABPID
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x750F210", Offset = "0x750E610", VA = "0x18750F210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] GMPPBAMCFIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x750EFD0", Offset = "0x750E3D0", VA = "0x18750EFD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x750F220", Offset = "0x750E620", VA = "0x18750F220")]
	[AEDFFNEEAKJ.AMNMLEGDOCC]
	internal static void GFLBPMFPPHA(LEPFMCICNAK EOMAFKDOFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x750F3C0", Offset = "0x750E7C0", VA = "0x18750F3C0")]
	internal static string[] JFKKDNDGOII(string[] ACOCDBPGLAB, string[] JPHMGJKKENI, List<string> JGLECKHMKIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x750EF20", Offset = "0x750E320", VA = "0x18750EF20", Slot = "4")]
	private string AKJCJLGMLKP(string MLLBPGGFLHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x750F310", Offset = "0x750E710", VA = "0x18750F310")]
	public static string JCNKCLFLJCN(string MLLBPGGFLHM, [Optional] string CIKOELCEFFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x750F170", Offset = "0x750E570", VA = "0x18750F170", Slot = "5")]
	private bool EDEJGCAMJML(string MLLBPGGFLHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x750F4E0", Offset = "0x750E8E0", VA = "0x18750F4E0")]
	public static bool MMAAEJMDKMA(string MLLBPGGFLHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public HCAHLAOOCEP()
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
