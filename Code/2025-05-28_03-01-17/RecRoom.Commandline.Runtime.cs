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
		[Cpp2IlInjected.Address(RVA = "0x7CB8BB0", Offset = "0x7CB79B0", VA = "0x187CB8BB0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x26D4E40", Offset = "0x26D3C40", VA = "0x1826D4E40")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KPJONPAAIMC
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string NLINJKLCBPO(string CELCCJNPBCN);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EILIFEOBICO(string CELCCJNPBCN);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum MIDICGJDHOM
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.NoEngine.Common.Preserve]
public class HDAEIFKEKOB : KPJONPAAIMC
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> OPHBCFGKMBD;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] EACFMBACADL;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] LONDMAEMCDC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] CHFHAKHIODF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8650", Offset = "0x7CB7450", VA = "0x187CB8650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] NOOOMEAPGHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8A00", Offset = "0x7CB7800", VA = "0x187CB8A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7CB87B0", Offset = "0x7CB75B0", VA = "0x187CB87B0")]
	[ENKLKENGHAE.AANPNKKBMFF]
	internal static void KPJOAGLHFJF(NAELDDAANND AHGNCOFKLHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7CB8530", Offset = "0x7CB7330", VA = "0x187CB8530")]
	internal static string[] AILCJCAJDHP(string[] OPCDOIDOGHB, string[] PFEMHACOINF, List<string> DBLICBNPMPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7CB8700", Offset = "0x7CB7500", VA = "0x187CB8700", Slot = "4")]
	private string JIMHEDADPNB(string CELCCJNPBCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7CB8950", Offset = "0x7CB7750", VA = "0x187CB8950")]
	public static string NLINJKLCBPO(string CELCCJNPBCN, [Optional] string LDGCNLHOBMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7CB88B0", Offset = "0x7CB76B0", VA = "0x187CB88B0", Slot = "5")]
	private bool LDFFELFFGIB(string CELCCJNPBCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7CB8660", Offset = "0x7CB7460", VA = "0x187CB8660")]
	public static bool EILIFEOBICO(string CELCCJNPBCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public HDAEIFKEKOB()
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
