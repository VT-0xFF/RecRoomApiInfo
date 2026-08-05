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
		[Cpp2IlInjected.Address(RVA = "0x8211F20", Offset = "0x8210920", VA = "0x188211F20", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2906C90", Offset = "0x2905690", VA = "0x182906C90")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HGCEBKAFGFC
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string IOHLHHDILEM(string OLLJNINDADG);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OEJMBKOOFAN(string OLLJNINDADG);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum GDEFFCPFPIL
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.NoEngine.Common.Preserve]
public class IFNOKOHOHDB : HGCEBKAFGFC
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> GHIOAJIGPON;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] FLCIIJAIIKK;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] KFHANNNPDBA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] ILJBBNPKMIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8211B70", Offset = "0x8210570", VA = "0x188211B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] FFGDEIIGKMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x82118A0", Offset = "0x82102A0", VA = "0x1882118A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8211B80", Offset = "0x8210580", VA = "0x188211B80")]
	[PPMDKOHJEBA.KMGFFEOOKKA]
	internal static void EIKIOMKMPDG(CFAMNNNCHJA JBOIKIICKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8211A50", Offset = "0x8210450", VA = "0x188211A50")]
	internal static string[] DKPNLPBKAFA(string[] CMELNKIFECL, string[] NNGAKPONBJC, List<string> GLOGPDLIJMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8211DD0", Offset = "0x82107D0", VA = "0x188211DD0", Slot = "4")]
	private string KDMFJMMLJKD(string OLLJNINDADG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8211D20", Offset = "0x8210720", VA = "0x188211D20")]
	public static string IOHLHHDILEM(string OLLJNINDADG, [Optional] string KKCMINIPIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8211C80", Offset = "0x8210680", VA = "0x188211C80", Slot = "5")]
	private bool INMCIPEHJGL(string OLLJNINDADG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8211E80", Offset = "0x8210880", VA = "0x188211E80")]
	public static bool OEJMBKOOFAN(string OLLJNINDADG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public IFNOKOHOHDB()
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
