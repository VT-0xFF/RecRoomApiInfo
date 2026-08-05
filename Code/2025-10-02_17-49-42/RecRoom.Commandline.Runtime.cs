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
		[Cpp2IlInjected.Address(RVA = "0x83FE690", Offset = "0x83FD090", VA = "0x1883FE690", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29CDED0", Offset = "0x29CC8D0", VA = "0x1829CDED0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KLCFKICOEGO
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string CGKNPGKBBCM(string LGDIEGLPFLO);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JFBBLKDDNPG(string LGDIEGLPFLO);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum LNBCJFKFGHI
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.NoEngine.Common.Preserve]
public class HHGGFBHKCEN : KLCFKICOEGO
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> IFBCCGOIBJE;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] KELEKMDBNKL;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] NGAIHFNGOPC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] EILKOLEGBCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x83FE530", Offset = "0x83FCF30", VA = "0x1883FE530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] HNPDHMOEKDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x83FE1C0", Offset = "0x83FCBC0", VA = "0x1883FE1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x83FE020", Offset = "0x83FCA20", VA = "0x1883FE020")]
	[DMKNBLIJJON.EGFDFBOLNDK]
	internal static void CCKCOACOBKL(JBJKIIKOACK KLIEGJHNGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x83FE370", Offset = "0x83FCD70", VA = "0x1883FE370")]
	internal static string[] FPIEOLFKFIG(string[] DGCAOKOAOLM, string[] IIOOMPNBFAK, List<string> GGEDAAGIPKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x83FE540", Offset = "0x83FCF40", VA = "0x1883FE540", Slot = "4")]
	private string LKHEBNEPJKB(string LGDIEGLPFLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x83FE110", Offset = "0x83FCB10", VA = "0x1883FE110")]
	public static string CGKNPGKBBCM(string LGDIEGLPFLO, [Optional] string KJMOBDOKFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x83FE5F0", Offset = "0x83FCFF0", VA = "0x1883FE5F0", Slot = "5")]
	private bool ODGAPJGEMPK(string LGDIEGLPFLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x83FE490", Offset = "0x83FCE90", VA = "0x1883FE490")]
	public static bool JFBBLKDDNPG(string LGDIEGLPFLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public HHGGFBHKCEN()
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
