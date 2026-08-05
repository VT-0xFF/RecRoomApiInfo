using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Logger
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public interface EIFPFKWIQJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD85C12E803B3FC2", Offset = "0x0", VA = "0xD85C130003B3FC2", Slot = "0")]
		void Log(object log);

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3B4080803B3FD0", Offset = "0x0", VA = "0x3B4082003B3FD0", Slot = "1")]
		void BUABTVTCRZF(object a);

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3B408E8D85C130", Offset = "0x0", VA = "0x3B40900D85C130", Slot = "2")]
		void WEJRWAXQWGB(object a);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD85C12E803B4142", Offset = "0x0", VA = "0xD85C130003B4142", Slot = "3")]
		void BHEEGAYRTYO(object a, string b, params object[] args);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3B4200803B4150", Offset = "0x0", VA = "0x3B4202003B4150", Slot = "4")]
		void LGFXJUHEOSW(Exception a);
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
