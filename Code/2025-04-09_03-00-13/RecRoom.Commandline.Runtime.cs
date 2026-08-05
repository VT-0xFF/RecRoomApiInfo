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
		[Cpp2IlInjected.Address(RVA = "0x77F1E90", Offset = "0x77F1290", VA = "0x1877F1E90", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2553680", Offset = "0x2552A80", VA = "0x182553680")]
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
		[Cpp2IlInjected.Address(RVA = "0x77F1AF0", Offset = "0x77F0EF0", VA = "0x1877F1AF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] HBCMJKMDKCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x77F1C50", Offset = "0x77F1050", VA = "0x1877F1C50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x77F1830", Offset = "0x77F0C30", VA = "0x1877F1830")]
	[NOCPMGCIOME.CBODKAAMPCM]
	internal static void BBLAOBGDHMG(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x77F1920", Offset = "0x77F0D20", VA = "0x1877F1920")]
	internal static string[] COFJMFCEFKK(string[] GBJGADGGKLN, string[] DPNGOKMKKKK, List<string> LMGGNAOMNBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x77F1B00", Offset = "0x77F0F00", VA = "0x1877F1B00", Slot = "4")]
	private string GMKFCKHADFC(string EEDLEGPLAKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x77F1A40", Offset = "0x77F0E40", VA = "0x1877F1A40")]
	public static string DGKAOOBECCA(string EEDLEGPLAKK, [Optional] string PFCPDJEHNAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x77F1DF0", Offset = "0x77F11F0", VA = "0x1877F1DF0", Slot = "5")]
	private bool LECINJHENKJ(string EEDLEGPLAKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x77F1BB0", Offset = "0x77F0FB0", VA = "0x1877F1BB0")]
	public static bool JGFNKHLNLNJ(string EEDLEGPLAKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
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
