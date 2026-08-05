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
		[Cpp2IlInjected.Address(RVA = "0x7428760", Offset = "0x7426D60", VA = "0x187428760", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x245DCB0", Offset = "0x245C2B0", VA = "0x18245DCB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7428750", Offset = "0x7426D50", VA = "0x187428750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] OKLPICFEHAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7428180", Offset = "0x7426780", VA = "0x187428180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7428480", Offset = "0x7426A80", VA = "0x187428480")]
	[HLOHOCOKELO.IDGFAEKKODB]
	internal static void HBMGFBHOMDP(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7428630", Offset = "0x7426C30", VA = "0x187428630")]
	internal static string[] IFFLPJFOBHL(string[] NLFIANHNCKM, string[] DLELMGEMMIK, List<string> KBDNIPNJNJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7428330", Offset = "0x7426930", VA = "0x187428330", Slot = "4")]
	private string FHIHGNLGCEA(string JKHHHFODJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7428580", Offset = "0x7426B80", VA = "0x187428580")]
	public static string HIGJINDBJCH(string JKHHHFODJFE, [Optional] string IDJBNLNBJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x74280E0", Offset = "0x74266E0", VA = "0x1874280E0", Slot = "5")]
	private bool BCMBLJCEPNM(string JKHHHFODJFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x74283E0", Offset = "0x74269E0", VA = "0x1874283E0")]
	public static bool HAOLAIFBNED(string JKHHHFODJFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
