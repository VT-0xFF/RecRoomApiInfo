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
		[Cpp2IlInjected.Address(RVA = "0x7BB63D0", Offset = "0x7BB55D0", VA = "0x187BB63D0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2675970", Offset = "0x2674B70", VA = "0x182675970")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OINALMOGKHN
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string KBJBLADEFOE(string GNKOKDLDGPC);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KKMILILOOFH(string GNKOKDLDGPC);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum IKGKPGCOIKE
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.NoEngine.Common.Preserve]
public class KHINCMDBHPO : OINALMOGKHN
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> MOPPHOJDOOO;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] JOJJMFLBFBI;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] PBNIOCPBNAJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] HDDBBEKHPGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7BB5D60", Offset = "0x7BB4F60", VA = "0x187BB5D60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] GFCAINHDCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7BB6130", Offset = "0x7BB5330", VA = "0x187BB6130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7BB62D0", Offset = "0x7BB54D0", VA = "0x187BB62D0")]
	[DBIDCJGLKKO.BICJMLCNMCI]
	internal static void OIIIADNPFIO(HILJAABEPDC NPCDKJJJIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7BB6010", Offset = "0x7BB5210", VA = "0x187BB6010")]
	internal static string[] MGEOLDANENA(string[] INLMJDGBLPE, string[] PDENCDLKPGN, List<string> JCBNOMDBEAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7BB5F60", Offset = "0x7BB5160", VA = "0x187BB5F60", Slot = "4")]
	private string LCMOPFIMPKL(string GNKOKDLDGPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7BB5E10", Offset = "0x7BB5010", VA = "0x187BB5E10")]
	public static string KBJBLADEFOE(string GNKOKDLDGPC, [Optional] string FAGKKFIFNNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7BB5D70", Offset = "0x7BB4F70", VA = "0x187BB5D70", Slot = "5")]
	private bool JKOPGOKGCJJ(string GNKOKDLDGPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7BB5EC0", Offset = "0x7BB50C0", VA = "0x187BB5EC0")]
	public static bool KKMILILOOFH(string GNKOKDLDGPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public KHINCMDBHPO()
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
