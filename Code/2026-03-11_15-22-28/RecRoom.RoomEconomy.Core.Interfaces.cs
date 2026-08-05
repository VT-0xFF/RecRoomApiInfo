using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Networking.RPC;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.RoomEconomy
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public interface CAPUVVYTGKM
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		BWZDQSTONJS HHITAJBNULJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface NSXQRFINAUD
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool RASKPEAOHAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool XDHCTHVMHBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class GBJACNQYDAU
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8C7EDE0", Offset = "0x8C7DDE0", VA = "0x188C7EDE0")]
		public static int HEDLIUCMETE(long a)
		{
			return default(int);
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
