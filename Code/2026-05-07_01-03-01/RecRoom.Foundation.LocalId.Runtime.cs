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
		public static LocalId QVHRTSBDISV
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0")]
			get
			{
				return default(LocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xEA99B0", Offset = "0xEA83B0", VA = "0x180EA99B0")]
		public LocalId(int index, int version)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x15A1F40", Offset = "0x15A0940", VA = "0x1815A1F40")]
		public static implicit operator Entity(LocalId value)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x15A1F40", Offset = "0x15A0940", VA = "0x1815A1F40")]
		public static implicit operator LocalId(Entity value)
		{
			return default(LocalId);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x97D2CC0", Offset = "0x97D16C0", VA = "0x1897D2CC0")]
		public static bool OTUOIXXRZSY(LocalId a, LocalId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x97D2C10", Offset = "0x97D1610", VA = "0x1897D2C10")]
		public static bool JSGIPYLAFHN(LocalId a, LocalId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x985C7D0", Offset = "0x985B1D0", VA = "0x18985C7D0", Slot = "5")]
		public int CompareTo(LocalId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x985DEA0", Offset = "0x985C8A0", VA = "0x18985DEA0", Slot = "0")]
		public override bool Equals(object compare)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xF535F0", Offset = "0xF51FF0", VA = "0x180F535F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x985DE80", Offset = "0x985C880", VA = "0x18985DE80", Slot = "4")]
		public bool Equals(LocalId localId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x985DF30", Offset = "0x985C930", VA = "0x18985DF30", Slot = "3")]
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
