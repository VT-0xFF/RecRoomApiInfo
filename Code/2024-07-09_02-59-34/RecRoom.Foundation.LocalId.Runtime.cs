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
			[Cpp2IlInjected.Address(RVA = "0x866B30", Offset = "0x865730", VA = "0x180866B30")]
			get
			{
				return default(LocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xC51CA0", Offset = "0xC508A0", VA = "0x180C51CA0")]
		public LocalId(int BAEBMIBABAE, int FAEMFOKJHDK)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA8DA80", Offset = "0xA8C680", VA = "0x180A8DA80")]
		public static Entity ANHILFPCAJJ(LocalId IIPLJLPCLBC)
		{
			return default(Entity);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA8DA80", Offset = "0xA8C680", VA = "0x180A8DA80")]
		public static LocalId ANHILFPCAJJ(Entity IIPLJLPCLBC)
		{
			return default(LocalId);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2BA14D0", Offset = "0x2BA00D0", VA = "0x182BA14D0")]
		public static bool IGDKJEPDLHP(LocalId HFIDNJCGLJB, LocalId MGPFNHKFBHO)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x698F400", Offset = "0x698E000", VA = "0x18698F400")]
		public static bool OAODAFKFIOO(LocalId HFIDNJCGLJB, LocalId MGPFNHKFBHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x69D4A10", Offset = "0x69D3610", VA = "0x1869D4A10", Slot = "5")]
		public int CompareTo(LocalId HEIGABGMPLJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x69D5200", Offset = "0x69D3E00", VA = "0x1869D5200", Slot = "0")]
		public override bool Equals(object BKABBPDOCEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x69D51E0", Offset = "0x69D3DE0", VA = "0x1869D51E0", Slot = "4")]
		public bool Equals(LocalId IDIEOFKIGBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x69D52A0", Offset = "0x69D3EA0", VA = "0x1869D52A0", Slot = "3")]
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
