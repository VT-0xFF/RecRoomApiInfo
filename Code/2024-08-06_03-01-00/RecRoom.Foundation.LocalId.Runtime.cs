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
			[Cpp2IlInjected.Address(RVA = "0x85E9F0", Offset = "0x85CFF0", VA = "0x18085E9F0")]
			get
			{
				return default(LocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD48E20", Offset = "0xD47420", VA = "0x180D48E20")]
		public LocalId(int EBDMAJMOJLN, int PKICDAADPKG)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xB5EB50", Offset = "0xB5D150", VA = "0x180B5EB50")]
		public static Entity IHCIOHJGPAF(LocalId FEBGGALLBNN)
		{
			return default(Entity);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xB5EB50", Offset = "0xB5D150", VA = "0x180B5EB50")]
		public static LocalId IHCIOHJGPAF(Entity FEBGGALLBNN)
		{
			return default(LocalId);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2C618C0", Offset = "0x2C5FEC0", VA = "0x182C618C0")]
		public static bool MLHBCNDBLOI(LocalId MIGBCLGIEPA, LocalId MMACHIKDDMH)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x69702B0", Offset = "0x696E8B0", VA = "0x1869702B0")]
		public static bool LOCHGFJDMHC(LocalId MIGBCLGIEPA, LocalId MMACHIKDDMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x69B47A0", Offset = "0x69B2DA0", VA = "0x1869B47A0", Slot = "5")]
		public int CompareTo(LocalId OGEIJLCLBIC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x69B4F50", Offset = "0x69B3550", VA = "0x1869B4F50", Slot = "0")]
		public override bool Equals(object LPFLLMADJKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB5EC10", Offset = "0xB5D210", VA = "0x180B5EC10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x69B4F30", Offset = "0x69B3530", VA = "0x1869B4F30", Slot = "4")]
		public bool Equals(LocalId CJKJJBEPLLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x69B4FE0", Offset = "0x69B35E0", VA = "0x1869B4FE0", Slot = "3")]
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
