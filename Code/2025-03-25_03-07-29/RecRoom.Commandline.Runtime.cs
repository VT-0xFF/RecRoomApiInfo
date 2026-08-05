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
		[Cpp2IlInjected.Address(RVA = "0x7738C00", Offset = "0x7738000", VA = "0x187738C00", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x251F7B0", Offset = "0x251EBB0", VA = "0x18251F7B0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface FFMKCODMNLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string IHCHDKIMKFP(string KDFAHKIFEME);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IOAGAJKCEKK(string KDFAHKIFEME);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum NONPIIHIBEP
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.NoEngine.Common.Preserve]
public class CGFHKCGEKEB : FFMKCODMNLJ
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> CEOAEALHOPD;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] LBPPPKCMAAJ;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] KNHJNANPOLH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] NIMCJDPDBBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7738BF0", Offset = "0x7737FF0", VA = "0x187738BF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] EALGILKOGHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7738630", Offset = "0x7737A30", VA = "0x187738630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x77389D0", Offset = "0x7737DD0", VA = "0x1877389D0")]
	[BOBPNFIGGBE.NBDKKMMHNGD]
	internal static void KDIILJNJDKF(NPIEGGOELNH PHDMEDCBLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7738AD0", Offset = "0x7737ED0", VA = "0x187738AD0")]
	internal static string[] KKPAIPNLANE(string[] DMBKPEBIGIK, string[] IFICANIKLNN, List<string> IFNOADNNOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x77387D0", Offset = "0x7737BD0", VA = "0x1877387D0", Slot = "4")]
	private string FIMEACIHNNF(string KDFAHKIFEME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7738880", Offset = "0x7737C80", VA = "0x187738880")]
	public static string IHCHDKIMKFP(string KDFAHKIFEME, [Optional] string MBADHELIPJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7738590", Offset = "0x7737990", VA = "0x187738590", Slot = "5")]
	private bool DMJFGGNOGIC(string KDFAHKIFEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7738930", Offset = "0x7737D30", VA = "0x187738930")]
	public static bool IOAGAJKCEKK(string KDFAHKIFEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public CGFHKCGEKEB()
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
