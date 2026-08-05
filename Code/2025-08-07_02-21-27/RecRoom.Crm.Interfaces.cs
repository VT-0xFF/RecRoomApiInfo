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
	public interface HAGIGSQOZBQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x3B4380803B42D0", Offset = "0x0", VA = "0x3B4382003B42D0", Slot = "0")]
		void MRKOZONKWGZ(string a, string b, bool c);

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3B438E8D85C130", Offset = "0x0", VA = "0x3B43900D85C130", Slot = "1")]
		void EZOFPKFLLJN();

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD85C12E803B4442", Offset = "0x0", VA = "0xD85C130003B4442", Slot = "2")]
		void ODGBJXFOLUR();

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3B4500803B4450", Offset = "0x0", VA = "0x3B4502003B4450", Slot = "3")]
		void DLZYHXWQFYC();

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3B450E8D85C130", Offset = "0x0", VA = "0x3B45100D85C130", Slot = "4")]
		void JMQKEBLCPOS(string a, [Optional] string b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface IRBPWHUGQPL
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface KGETOTDCEKT : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		CrmType VLUMULOUWZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xD85C12E803B45C2", Offset = "0x0", VA = "0xD85C130003B45C2", Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool QDEONMLIACP
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x3B4680803B45D0", Offset = "0x0", VA = "0x3B4682003B45D0", Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action<CrmAssignmentDTO> OXSVNEOPJFW;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3B4800803B4750", Offset = "0x0", VA = "0x3B4802003B4750", Slot = "4")]
		Task Initialize();

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3B480E8D85C130", Offset = "0x0", VA = "0x3B48100D85C130", Slot = "5")]
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
