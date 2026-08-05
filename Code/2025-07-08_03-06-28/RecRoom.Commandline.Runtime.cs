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
		[Cpp2IlInjected.Address(RVA = "0x7FD35C0", Offset = "0x7FD23C0", VA = "0x187FD35C0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x286F3E0", Offset = "0x286E1E0", VA = "0x18286F3E0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface JEGDHPCPFBG
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string MKLKHKJBFEB(string LMICOICMKNA);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NDPNJEJMBCL(string LMICOICMKNA);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum KGCIKLOMFDG
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.NoEngine.Common.Preserve]
public class OBKCNLDAPMC : JEGDHPCPFBG
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> IFLDBINBMLK;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] CHLIJCCCEML;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] EFOCPPAJCFH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] KGHBICEBBDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7FD2F50", Offset = "0x7FD1D50", VA = "0x187FD2F50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] KLBEMFJDGJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7FD3100", Offset = "0x7FD1F00", VA = "0x187FD3100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7FD3010", Offset = "0x7FD1E10", VA = "0x187FD3010")]
	[ONLJNMLDJBD.KDDDMPKOLFO]
	internal static void KEKMDAEKNFP(LOAHJOOKLEP CHDHLAGMCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7FD34A0", Offset = "0x7FD22A0", VA = "0x187FD34A0")]
	internal static string[] PODFHDIMKCK(string[] AGLOHPCDLEM, string[] MNJBJLPMDBO, List<string> ELBINKFNGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7FD2F60", Offset = "0x7FD1D60", VA = "0x187FD2F60", Slot = "4")]
	private string FKKIPCAPFOB(string LMICOICMKNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7FD32B0", Offset = "0x7FD20B0", VA = "0x187FD32B0")]
	public static string MKLKHKJBFEB(string LMICOICMKNA, [Optional] string JILABBLHNAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7FD3360", Offset = "0x7FD2160", VA = "0x187FD3360", Slot = "5")]
	private bool MLCCBCKDHLH(string LMICOICMKNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7FD3400", Offset = "0x7FD2200", VA = "0x187FD3400")]
	public static bool NDPNJEJMBCL(string LMICOICMKNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public OBKCNLDAPMC()
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
