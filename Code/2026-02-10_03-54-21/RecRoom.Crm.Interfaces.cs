using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Crm
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public interface RYULSZJOPGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MAKBJZQMBYW(string a, string b, bool c);

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ZWFWQGBMSYY();

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void CNFKPTHCLLC();

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void TBYWFLXNLJP();

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void ELSQARHHHMD(string a, [Optional] string b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface WCGAODAQIDY
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface TIPAERONJXC : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		CrmType TXHOOOYDFKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool JONOFHOVWIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action<CrmAssignmentDTO> HAYNJRZOSKT;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task Initialize();

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Reset();
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
