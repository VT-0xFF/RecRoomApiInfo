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
		[Cpp2IlInjected.Address(RVA = "0x6E7BE70", Offset = "0x6E7A670", VA = "0x186E7BE70", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x21F3FE0", Offset = "0x21F27E0", VA = "0x1821F3FE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PIPABNENLFP
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string KBOPEJHDKDI(string HCEFDNFIGAF);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HPJBNGMEFFH(string HCEFDNFIGAF);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum MLKDIGGBJCK
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.NoEngine.Common.Preserve]
public class KPFFFDICAGK : PIPABNENLFP
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> CDKFFKDFPAD;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] PDAKEBKPADH;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] FLKIHEMHKLA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] DHMNKJEGOOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6E7BE60", Offset = "0x6E7A660", VA = "0x186E7BE60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] IILONBFJFCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6E7BA40", Offset = "0x6E7A240", VA = "0x186E7BA40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6E7B800", Offset = "0x6E7A000", VA = "0x186E7B800")]
	[PDAMAKFHAHC.GNFCFDNPMLH]
	internal static void EDDDBNCFOFG(CMONJLKOOCI MFHCHOKEAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6E7BD40", Offset = "0x6E7A540", VA = "0x186E7BD40")]
	internal static string[] NOEBNDPOKJN(string[] IKHHCINBKGN, string[] DKPBFABAJCK, List<string> DEMFMMIAKIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6E7BC90", Offset = "0x6E7A490", VA = "0x186E7BC90", Slot = "4")]
	private string NGFDCJFONDM(string HCEFDNFIGAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6E7B990", Offset = "0x6E7A190", VA = "0x186E7B990")]
	public static string KBOPEJHDKDI(string HCEFDNFIGAF, [Optional] string DFEJJOPGBKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6E7BBF0", Offset = "0x6E7A3F0", VA = "0x186E7BBF0", Slot = "5")]
	private bool MLJIKPDGCJA(string HCEFDNFIGAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6E7B8F0", Offset = "0x6E7A0F0", VA = "0x186E7B8F0")]
	public static bool HPJBNGMEFFH(string HCEFDNFIGAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public KPFFFDICAGK()
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
