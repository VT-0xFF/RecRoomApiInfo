using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Avatars;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Reactions
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public interface YPMYPMHHAME
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool WFTGYVIQRAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x3B6702803B66B8", Offset = "0x0", VA = "0x3B6704003B66B8", Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		AQWXMNIFQIV PZWMSCPUTXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x3B67028DB1F0BC", Offset = "0x0", VA = "0x3B67040DB1F0BC", Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		AQWXMNIFQIV UACDRGUFSNS
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xDB1F0CE803B670F", Offset = "0x0", VA = "0xDB1F0D0003B670F", Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		List<string> EZFWAAOVWWO
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x3B6729803B670F", Offset = "0x0", VA = "0x3B672B003B670F", Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3B673E8DB1F0E0", Offset = "0x0", VA = "0x3B67400DB1F0E0", Slot = "4")]
		void MLKBYUFAYZS(List<(string, IXZFSOMDNHK.Emote)> a);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xD855586803B6778", Offset = "0x0", VA = "0xD855588003B6778", Slot = "5")]
		string[] FSRTYCZNCXR(string a);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3B67AF803B6780", Offset = "0x0", VA = "0x3B67B1003B6780", Slot = "6")]
		bool CEWHNWFRRGP(string a);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3B67BE8D855598", Offset = "0x0", VA = "0x3B67C00D855598", Slot = "7")]
		string LCWVTJANPAU(string a);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xD8563B6803B68E1", Offset = "0x0", VA = "0xD8563B8003B68E1", Slot = "8")]
		IXZFSOMDNHK.Emote GCHEEASZDUE(string a);
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
