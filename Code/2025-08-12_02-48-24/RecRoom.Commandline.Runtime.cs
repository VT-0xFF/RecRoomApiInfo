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
		[Cpp2IlInjected.Address(RVA = "0x836E290", Offset = "0x836C890", VA = "0x18836E290", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2960290", Offset = "0x295E890", VA = "0x182960290")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PAKPMOJPJMH
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string AGKMICCDODI(string KOHOAAFOHKL);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CAJCNCOCHCP(string KOHOAAFOHKL);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum PDFFPLHGGDJ
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.NoEngine.Common.Preserve]
public class JJIOPJCILED : PAKPMOJPJMH
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> CCGKAFOPDCN;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] DLCBDNFAIOH;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] FFMMLNIPIAI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] IGLPKAPACEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x836DE60", Offset = "0x836C460", VA = "0x18836DE60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] OGIOEDNGGCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x836DF10", Offset = "0x836C510", VA = "0x18836DF10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x836DC20", Offset = "0x836C220", VA = "0x18836DC20")]
	[LAFCEDCMNGK.DCDCJCFDIHP]
	internal static void ADENDBKKDEC(CFPMHDJNIAH LOLOEONEEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x836E0C0", Offset = "0x836C6C0", VA = "0x18836E0C0")]
	internal static string[] MJKDBEOJKKP(string[] CPNFGLFBHIC, string[] AIPDGICOFDO, List<string> GEAOPLMEJBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x836E1E0", Offset = "0x836C7E0", VA = "0x18836E1E0", Slot = "4")]
	private string NCBNLKJJOCA(string KOHOAAFOHKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x836DD10", Offset = "0x836C310", VA = "0x18836DD10")]
	public static string AGKMICCDODI(string KOHOAAFOHKL, [Optional] string DAKPJNHJLJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x836DE70", Offset = "0x836C470", VA = "0x18836DE70", Slot = "5")]
	private bool GNLKJLOAMEO(string KOHOAAFOHKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x836DDC0", Offset = "0x836C3C0", VA = "0x18836DDC0")]
	public static bool CAJCNCOCHCP(string KOHOAAFOHKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public JJIOPJCILED()
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
