using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.ObjectModel;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecNet.Data.Interfaces
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[ServiceLifetime(Lifetime.Application)]
	public interface PVSLTZJUZQC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ForceSendPerfMetricAtEmptyScene();
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
