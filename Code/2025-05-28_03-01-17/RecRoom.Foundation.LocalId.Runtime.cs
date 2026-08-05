using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Foundation
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public readonly struct LocalId : IEquatable<LocalId>, IComparable<LocalId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly int Index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly int Version;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static LocalId Null
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0")]
			get
			{
				return default(LocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD5BDF0", Offset = "0xD5ABF0", VA = "0x180D5BDF0")]
		public LocalId(int GLAOLHCPLLG, int MFIBIFPFGCD)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x12F0E30", Offset = "0x12EFC30", VA = "0x1812F0E30")]
		public static Entity HEKJAOMNHLJ(LocalId OAIIHELJHLG)
		{
			return default(Entity);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x12F0E30", Offset = "0x12EFC30", VA = "0x1812F0E30")]
		public static LocalId HEKJAOMNHLJ(Entity OAIIHELJHLG)
		{
			return default(LocalId);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x38FA8C0", Offset = "0x38F96C0", VA = "0x1838FA8C0")]
		public static bool PBEBFPKJKLO(LocalId ALCLKCHJGII, LocalId GFJPONDOIDH)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7D48E50", Offset = "0x7D47C50", VA = "0x187D48E50")]
		public static bool INFPGDPCEAI(LocalId ALCLKCHJGII, LocalId GFJPONDOIDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7DAE540", Offset = "0x7DAD340", VA = "0x187DAE540", Slot = "5")]
		public int CompareTo(LocalId HBLONCAMFLG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7DAF460", Offset = "0x7DAE260", VA = "0x187DAF460", Slot = "0")]
		public override bool Equals(object ADABPLCKKNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA55A60", Offset = "0xA54860", VA = "0x180A55A60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7DAF440", Offset = "0x7DAE240", VA = "0x187DAF440", Slot = "4")]
		public bool Equals(LocalId CBBNAACPEGP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7DAF4F0", Offset = "0x7DAE2F0", VA = "0x187DAF4F0", Slot = "3")]
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
