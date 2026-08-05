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
		[Cpp2IlInjected.Address(RVA = "0x77A54D0", Offset = "0x77A48D0", VA = "0x1877A54D0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x254E750", Offset = "0x254DB50", VA = "0x18254E750")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CMKMMAGEBBD
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string DGKAOOBECCA(string EEDLEGPLAKK);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JGFNKHLNLNJ(string EEDLEGPLAKK);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum CAOECIHAALO
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.NoEngine.Common.Preserve]
public class IBIEKGDGEAB : CMKMMAGEBBD
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> LMAAAEDAFEN;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] MEOCIJDADFC;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] MNGBFMCPEGI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] NMOADCEHIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x77A5120", Offset = "0x77A4520", VA = "0x1877A5120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] HBCMJKMDKCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x77A5280", Offset = "0x77A4680", VA = "0x1877A5280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x77A4E50", Offset = "0x77A4250", VA = "0x1877A4E50")]
	[NOCPMGCIOME.CBODKAAMPCM]
	internal static void BBLAOBGDHMG(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x77A4F50", Offset = "0x77A4350", VA = "0x1877A4F50")]
	internal static string[] COFJMFCEFKK(string[] GBJGADGGKLN, string[] DPNGOKMKKKK, List<string> LMGGNAOMNBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x77A5130", Offset = "0x77A4530", VA = "0x1877A5130", Slot = "4")]
	private string GMKFCKHADFC(string EEDLEGPLAKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x77A5070", Offset = "0x77A4470", VA = "0x1877A5070")]
	public static string DGKAOOBECCA(string EEDLEGPLAKK, [Optional] string PFCPDJEHNAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x77A5430", Offset = "0x77A4830", VA = "0x1877A5430", Slot = "5")]
	private bool LECINJHENKJ(string EEDLEGPLAKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x77A51E0", Offset = "0x77A45E0", VA = "0x1877A51E0")]
	public static bool JGFNKHLNLNJ(string EEDLEGPLAKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public IBIEKGDGEAB()
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
