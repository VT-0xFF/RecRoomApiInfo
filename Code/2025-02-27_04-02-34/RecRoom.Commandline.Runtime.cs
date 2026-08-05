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
		[Cpp2IlInjected.Address(RVA = "0x738A6C0", Offset = "0x7389AC0", VA = "0x18738A6C0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x242AF30", Offset = "0x242A330", VA = "0x18242AF30")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HOBPLGJHDBC
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string HIGJINDBJCH(string JKHHHFODJFE);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HAOLAIFBNED(string JKHHHFODJFE);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum BINIHNLCOKJ
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.NoEngine.Common.Preserve]
public class EEIBPAINDME : HOBPLGJHDBC
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> CEOKNLAOJFH;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] OGGBAIBJIAK;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] DIJAGBIKPLG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] IOMBPJCJABG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x738A6B0", Offset = "0x7389AB0", VA = "0x18738A6B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] OKLPICFEHAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x738A0E0", Offset = "0x73894E0", VA = "0x18738A0E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x738A3E0", Offset = "0x73897E0", VA = "0x18738A3E0")]
	[HLOHOCOKELO.IDGFAEKKODB]
	internal static void HBMGFBHOMDP(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x738A590", Offset = "0x7389990", VA = "0x18738A590")]
	internal static string[] IFFLPJFOBHL(string[] NLFIANHNCKM, string[] DLELMGEMMIK, List<string> KBDNIPNJNJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x738A290", Offset = "0x7389690", VA = "0x18738A290", Slot = "4")]
	private string FHIHGNLGCEA(string JKHHHFODJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x738A4E0", Offset = "0x73898E0", VA = "0x18738A4E0")]
	public static string HIGJINDBJCH(string JKHHHFODJFE, [Optional] string IDJBNLNBJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x738A040", Offset = "0x7389440", VA = "0x18738A040", Slot = "5")]
	private bool BCMBLJCEPNM(string JKHHHFODJFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x738A340", Offset = "0x7389740", VA = "0x18738A340")]
	public static bool HAOLAIFBNED(string JKHHHFODJFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public EEIBPAINDME()
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
