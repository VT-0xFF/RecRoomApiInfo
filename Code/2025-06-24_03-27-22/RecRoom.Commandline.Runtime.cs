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
		[Cpp2IlInjected.Address(RVA = "0x7CE3550", Offset = "0x7CE2150", VA = "0x187CE3550", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x27CE7F0", Offset = "0x27CD3F0", VA = "0x1827CE7F0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface FFAMPDBOAKD
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string EMMNELPMBBG(string BGBBINOABDF);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JPPKFAFJCDP(string BGBBINOABDF);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum KLOOAAAPDJM
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.NoEngine.Common.Preserve]
public class DKCBCAJMMFB : FFAMPDBOAKD
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> LAHDIJMBLLM;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] BNGCMNDPFPO;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] MNAAJFEGCFJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] KCBOOCOJGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7CE3300", Offset = "0x7CE1F00", VA = "0x187CE3300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] JGAJIGMBIHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7CE33B0", Offset = "0x7CE1FB0", VA = "0x187CE33B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7CE2EE0", Offset = "0x7CE1AE0", VA = "0x187CE2EE0")]
	[IGNGJLOKDFM.EEFPBBAIHAI]
	internal static void BACILHPJJBN(PFGPAPHADOM MHCMGFKMEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7CE31E0", Offset = "0x7CE1DE0", VA = "0x187CE31E0")]
	internal static string[] GECLFLFJHEA(string[] OAOGDDPGCKE, string[] OJODLAGMIPB, List<string> FPBOCHLMDPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7CE3080", Offset = "0x7CE1C80", VA = "0x187CE3080", Slot = "4")]
	private string DOBNALMLHKH(string BGBBINOABDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7CE3130", Offset = "0x7CE1D30", VA = "0x187CE3130")]
	public static string EMMNELPMBBG(string BGBBINOABDF, [Optional] string IPOLOHBNCGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7CE2FE0", Offset = "0x7CE1BE0", VA = "0x187CE2FE0", Slot = "5")]
	private bool BEMKEJOAAAO(string BGBBINOABDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7CE3310", Offset = "0x7CE1F10", VA = "0x187CE3310")]
	public static bool JPPKFAFJCDP(string BGBBINOABDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public DKCBCAJMMFB()
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
