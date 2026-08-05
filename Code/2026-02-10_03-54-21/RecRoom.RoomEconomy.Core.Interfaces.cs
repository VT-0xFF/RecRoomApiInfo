using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Networking.RPC;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.RoomEconomy
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public interface FBYQXTSLKWF
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		RYTTEYASCBF MMEMNYOPJEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface LEKTXIDBPAQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool EMDFJRRWJXZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool OXABUMTYCWJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class YLZCKXIBCSR
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8C13DB0", Offset = "0x8C12FB0", VA = "0x188C13DB0")]
		public static int STLTNTUDERF(long a)
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
