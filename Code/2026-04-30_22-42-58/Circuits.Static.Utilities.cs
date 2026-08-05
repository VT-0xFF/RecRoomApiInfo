using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Circuits.Static.Api;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Circuits.Static.Utilities
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public sealed class XCBJSBWKBTY<a> : ASXPOOCHMFZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly string XEBPMPWPFVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly a YVVJIHKGLFY;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5017860", Offset = "0x5016C60", VA = "0x185017860")]
		internal XCBJSBWKBTY(string a, [In] a data)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class UEKOEJFHOLX
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2BE30D0", Offset = "0x2BE24D0", VA = "0x182BE30D0")]
		public static XCBJSBWKBTY<None> New(string message)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x405FA50", Offset = "0x405EE50", VA = "0x18405FA50")]
		public static XCBJSBWKBTY<TData> New<TData>(string message, [In] TData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class MULHYEYOQYE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3C05670", Offset = "0x3C04A70", VA = "0x183C05670")]
		public static Result<a, SKKNIPYCQUO> UEKOEJFHOLX<a>([In] this Result<a, SKKNIPYCQUO> self, string a)
		{
			return default(Result<a, SKKNIPYCQUO>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public abstract class ASXPOOCHMFZ : OKJLNQTBITD, SKKNIPYCQUO, FWOTOTOBXEY
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2BABA90", Offset = "0x2BAAE90", VA = "0x182BABA90")]
		protected ASXPOOCHMFZ()
		{
		}
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
