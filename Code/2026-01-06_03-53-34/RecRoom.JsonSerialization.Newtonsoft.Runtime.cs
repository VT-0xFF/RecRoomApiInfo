using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.JsonSerialization
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[Preserve]
	public class NewtonsoftJsonSerializationService : IBKYYCNOLED
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x38A10D0", Offset = "0x389FAD0", VA = "0x1838A10D0", Slot = "4")]
		public string GKPPRJHCKCA<a>(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x38A0F90", Offset = "0x389F990", VA = "0x1838A0F90", Slot = "5")]
		public b BZSNFRMALSV<b>(string a)
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public NewtonsoftJsonSerializationService()
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
