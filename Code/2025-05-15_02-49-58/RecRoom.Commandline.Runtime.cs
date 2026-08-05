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
		[Cpp2IlInjected.Address(RVA = "0x7B4EE50", Offset = "0x7B4D450", VA = "0x187B4EE50", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2645EC0", Offset = "0x26444C0", VA = "0x182645EC0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GPNPIENJPLA
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string HKDNOPFCFGA(string MJMGMHHAAHB);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PFKEIHKKAIG(string MJMGMHHAAHB);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum KCJNABNOIJE
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.NoEngine.Common.Preserve]
public class OKGCIGCEICH : GPNPIENJPLA
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> AAEEHHBOEGO;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] HJAEKGMPEIJ;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] MIOAEEANADP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] CEFFMDLOBNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7B4E980", Offset = "0x7B4CF80", VA = "0x187B4E980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] LPGMDBNKOEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7B4E7E0", Offset = "0x7B4CDE0", VA = "0x187B4E7E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7B4EB60", Offset = "0x7B4D160", VA = "0x187B4EB60")]
	[AOJMKBDAFKB.IKKICAJLINL]
	internal static void JPEDEHNINOC(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7B4EA40", Offset = "0x7B4D040", VA = "0x187B4EA40")]
	internal static string[] JOGJEPMCIIH(string[] MPBJADFKAEH, string[] EJNJKFFFIDO, List<string> HNDKKJNDLAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7B4EC60", Offset = "0x7B4D260", VA = "0x187B4EC60", Slot = "4")]
	private string LFKGGGKPJMA(string MJMGMHHAAHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7B4E990", Offset = "0x7B4CF90", VA = "0x187B4E990")]
	public static string HKDNOPFCFGA(string MJMGMHHAAHB, [Optional] string JMMNJNFGHEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7B4ED10", Offset = "0x7B4D310", VA = "0x187B4ED10", Slot = "5")]
	private bool MNGAMIBADMO(string MJMGMHHAAHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7B4EDB0", Offset = "0x7B4D3B0", VA = "0x187B4EDB0")]
	public static bool PFKEIHKKAIG(string MJMGMHHAAHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public OKGCIGCEICH()
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
