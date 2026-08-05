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
		[Cpp2IlInjected.Address(RVA = "0x7B7FAC0", Offset = "0x7B7EAC0", VA = "0x187B7FAC0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2643640", Offset = "0x2642640", VA = "0x182643640")]
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
		[Cpp2IlInjected.Address(RVA = "0x7B7F600", Offset = "0x7B7E600", VA = "0x187B7F600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] LPGMDBNKOEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7B7F450", Offset = "0x7B7E450", VA = "0x187B7F450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7B7F7E0", Offset = "0x7B7E7E0", VA = "0x187B7F7E0")]
	[AOJMKBDAFKB.IKKICAJLINL]
	internal static void JPEDEHNINOC(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7B7F6C0", Offset = "0x7B7E6C0", VA = "0x187B7F6C0")]
	internal static string[] JOGJEPMCIIH(string[] MPBJADFKAEH, string[] EJNJKFFFIDO, List<string> HNDKKJNDLAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7B7F8D0", Offset = "0x7B7E8D0", VA = "0x187B7F8D0", Slot = "4")]
	private string LFKGGGKPJMA(string MJMGMHHAAHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7B7F610", Offset = "0x7B7E610", VA = "0x187B7F610")]
	public static string HKDNOPFCFGA(string MJMGMHHAAHB, [Optional] string JMMNJNFGHEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7B7F980", Offset = "0x7B7E980", VA = "0x187B7F980", Slot = "5")]
	private bool MNGAMIBADMO(string MJMGMHHAAHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7B7FA20", Offset = "0x7B7EA20", VA = "0x187B7FA20")]
	public static bool PFKEIHKKAIG(string MJMGMHHAAHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
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
