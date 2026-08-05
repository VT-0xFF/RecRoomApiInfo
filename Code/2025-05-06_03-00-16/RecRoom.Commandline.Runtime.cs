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
		[Cpp2IlInjected.Address(RVA = "0x7A464C0", Offset = "0x7A44CC0", VA = "0x187A464C0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2612DF0", Offset = "0x26115F0", VA = "0x182612DF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OENJEDALNGL
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string DLPBNHNJEIA(string DKNLPKBPECP);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DPLIAGJLAKA(string DKNLPKBPECP);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum IHHMNEKMPIJ
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.NoEngine.Common.Preserve]
public class INIJAANCBCN : OENJEDALNGL
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> PAFBFMEHEGG;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] GCCPOCEELHO;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] LNEJNOFAEKB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] OJGGENDELHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7A46400", Offset = "0x7A44C00", VA = "0x187A46400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] EJLBNMOIEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7A460C0", Offset = "0x7A448C0", VA = "0x187A460C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7A46260", Offset = "0x7A44A60", VA = "0x187A46260")]
	[PJMOOJOMMCC.OJAOBFKEEAO]
	internal static void JMICLABLGOM(HHDGAAFLDEF PMKEELMHMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7A45E50", Offset = "0x7A44650", VA = "0x187A45E50")]
	internal static string[] CDEBPFEJBOJ(string[] BHILFEEMPDB, string[] POCHNNNPDMI, List<string> HMLKFJBHIFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7A46410", Offset = "0x7A44C10", VA = "0x187A46410", Slot = "4")]
	private string PFALOIKDHGN(string DKNLPKBPECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7A45F70", Offset = "0x7A44770", VA = "0x187A45F70")]
	public static string DLPBNHNJEIA(string DKNLPKBPECP, [Optional] string LHCNPHOLELG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7A46360", Offset = "0x7A44B60", VA = "0x187A46360", Slot = "5")]
	private bool KOAAKCCNDLB(string DKNLPKBPECP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7A46020", Offset = "0x7A44820", VA = "0x187A46020")]
	public static bool DPLIAGJLAKA(string DKNLPKBPECP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public INIJAANCBCN()
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
