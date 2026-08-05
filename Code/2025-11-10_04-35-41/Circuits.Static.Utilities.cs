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
	public sealed class ZXSSEPZESVY<a> : UWIINLOGUJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly string EZHNQEWUXQB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly a VQVHWHVOHGG;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3F4B940", Offset = "0x3F4AD40", VA = "0x183F4B940")]
		internal ZXSSEPZESVY(string a, [In] a data)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class SWBEUXYFCMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x28D7850", Offset = "0x28D6C50", VA = "0x1828D7850")]
		public static ZXSSEPZESVY<None> New(string message)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3A68620", Offset = "0x3A67A20", VA = "0x183A68620")]
		public static ZXSSEPZESVY<TData> New<TData>(string message, [In] TData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class YETQPUQBBDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3C1C490", Offset = "0x3C1B890", VA = "0x183C1C490")]
		public static Result<a, RAGLFGQXJZI> SWBEUXYFCMF<a>([In] this Result<a, RAGLFGQXJZI> self, string a)
		{
			return default(Result<a, RAGLFGQXJZI>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public abstract class UWIINLOGUJB : GKLIEWNFSHL, RAGLFGQXJZI, XOJOHOBKPDS
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x28A1410", Offset = "0x28A0810", VA = "0x1828A1410")]
		protected UWIINLOGUJB()
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
