using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Networking.DataTypes;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Networking.RPC
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public struct RPCInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly int serverTimestampInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly INetworkedPlayer Sender;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly int ViewId;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x129750", Offset = "0x128B50", VA = "0x180129750")]
		public RPCInfo(int serverTimestampInt, INetworkedPlayer sender, int viewId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2DD180", Offset = "0x2DC580", VA = "0x1802DD180", Slot = "3")]
		public override string ToString()
		{
			return null;
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
