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
		[Cpp2IlInjected.Address(RVA = "0x8297C80", Offset = "0x8296A80", VA = "0x188297C80", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2941360", Offset = "0x2940160", VA = "0x182941360")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IMPGLDJJBLM
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string MCMDALNGJOJ(string FNEAAIJJGGG);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HOLKJNIFDLB(string FNEAAIJJGGG);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum OKLCAEMOKMP
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.NoEngine.Common.Preserve]
public class CJALKBNOPKH : IMPGLDJJBLM
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> OGFOINMOPBN;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] OIBMIPCIOMA;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] OGOCMCINFAF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] DNKHNBAIIDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8297B70", Offset = "0x8296970", VA = "0x188297B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] DCENKCAADKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8297610", Offset = "0x8296410", VA = "0x188297610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8297B80", Offset = "0x8296980", VA = "0x188297B80")]
	[NKOKDPHOKEP.APMGAGDLDLC]
	internal static void ODAPPKPCBLD(HJFNEHLLJBB HPOMHCIJOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8297900", Offset = "0x8296700", VA = "0x188297900")]
	internal static string[] BIOLEJLOJNJ(string[] DBBAOEEHEEE, string[] LHFGKHJNDCE, List<string> KEPNFNILDOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x82977B0", Offset = "0x82965B0", VA = "0x1882977B0", Slot = "4")]
	private string AAJNOFNHKCO(string FNEAAIJJGGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8297AC0", Offset = "0x82968C0", VA = "0x188297AC0")]
	public static string MCMDALNGJOJ(string FNEAAIJJGGG, [Optional] string PGFMONBPOJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8297860", Offset = "0x8296660", VA = "0x188297860", Slot = "5")]
	private bool BIBPKFIIIOP(string FNEAAIJJGGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8297A20", Offset = "0x8296820", VA = "0x188297A20")]
	public static bool HOLKJNIFDLB(string FNEAAIJJGGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public CJALKBNOPKH()
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
