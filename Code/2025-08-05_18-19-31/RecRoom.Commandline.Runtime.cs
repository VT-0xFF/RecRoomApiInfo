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
		[Cpp2IlInjected.Address(RVA = "0x81B8D50", Offset = "0x81B8150", VA = "0x1881B8D50", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x291FE80", Offset = "0x291F280", VA = "0x18291FE80")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DHLOHNCLPIN
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string FCAMALDMNCP(string KOJGIHKIGBD);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KIKHOJNMADK(string KOJGIHKIGBD);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum GAJBEMHJNHJ
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.NoEngine.Common.Preserve]
public class GOKGAKEPHFP : DHLOHNCLPIN
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> KGBNGOIBCLP;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] IENMKFLNPIA;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] KNPMAAIFLKE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] IOEOLGELPCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x81B8840", Offset = "0x81B7C40", VA = "0x1881B8840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] KHKFBLDODJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x81B8940", Offset = "0x81B7D40", VA = "0x1881B8940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x81B8850", Offset = "0x81B7C50", VA = "0x1881B8850")]
	[MKODAOGKIAA.PMDGGDAFIAI]
	internal static void IBCLJHGLFJL(JFAGCPCLAAF MNCIANLLPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x81B8C30", Offset = "0x81B8030", VA = "0x1881B8C30")]
	internal static string[] PAFFDDEAALH(string[] BDOIDNBJBNE, string[] JHEOMCOHAAL, List<string> MPIJFABEFME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x81B86E0", Offset = "0x81B7AE0", VA = "0x1881B86E0", Slot = "4")]
	private string CGBCDDEBDJG(string KOJGIHKIGBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x81B8790", Offset = "0x81B7B90", VA = "0x1881B8790")]
	public static string FCAMALDMNCP(string KOJGIHKIGBD, [Optional] string ABINAMGBLJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x81B8AF0", Offset = "0x81B7EF0", VA = "0x1881B8AF0", Slot = "5")]
	private bool JGMPDPLGKLP(string KOJGIHKIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x81B8B90", Offset = "0x81B7F90", VA = "0x1881B8B90")]
	public static bool KIKHOJNMADK(string KOJGIHKIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public GOKGAKEPHFP()
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
