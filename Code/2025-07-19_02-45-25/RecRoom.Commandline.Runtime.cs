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
		[Cpp2IlInjected.Address(RVA = "0x8080D40", Offset = "0x807FD40", VA = "0x188080D40", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x28D9760", Offset = "0x28D8760", VA = "0x1828D9760")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ENEILHIOMGD
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string MCMJLHEBCBP(string DGMLMPAOEHN);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EDOBAOFAFBD(string DGMLMPAOEHN);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum EIGIKBOIADO
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.NoEngine.Common.Preserve]
public class MOJCDLDIFLO : ENEILHIOMGD
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> DGFOMKCLPIA;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] OALEPJLDGFF;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] MAOEHLABKFF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] NENNIHKAJDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8080930", Offset = "0x807F930", VA = "0x188080930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] HGGPEOLEJNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8080B90", Offset = "0x807FB90", VA = "0x188080B90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x80809E0", Offset = "0x807F9E0", VA = "0x1880809E0")]
	[GOMLKAICHII.NIENCEEHOCF]
	internal static void JPGJPCMNFEJ(CBHAAKGBAOP PFJIPDCNGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8080810", Offset = "0x807F810", VA = "0x188080810")]
	internal static string[] ENOLIHPPPBL(string[] JOHNEMNILBO, string[] EPMIAJJHFDH, List<string> DIMDCDCNEMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x80806C0", Offset = "0x807F6C0", VA = "0x1880806C0", Slot = "4")]
	private string BIKMFFFFICL(string DGMLMPAOEHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8080AE0", Offset = "0x807FAE0", VA = "0x188080AE0")]
	public static string MCMJLHEBCBP(string DGMLMPAOEHN, [Optional] string CAILINJCNIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8080940", Offset = "0x807F940", VA = "0x188080940", Slot = "5")]
	private bool JFONDBBMMJJ(string DGMLMPAOEHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8080770", Offset = "0x807F770", VA = "0x188080770")]
	public static bool EDOBAOFAFBD(string DGMLMPAOEHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public MOJCDLDIFLO()
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
