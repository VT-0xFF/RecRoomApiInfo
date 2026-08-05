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
			[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50")]
			get
			{
				return default(LocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xBD9040", Offset = "0xBD7E40", VA = "0x180BD9040")]
		public LocalId(int KNCPCNBMDNF, int BBDOELHAPOH)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x10DCBA0", Offset = "0x10DB9A0", VA = "0x1810DCBA0")]
		public static Entity JCHCBNMNCNP(LocalId IPHILEOFJLB)
		{
			return default(Entity);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x10DCBA0", Offset = "0x10DB9A0", VA = "0x1810DCBA0")]
		public static LocalId JCHCBNMNCNP(Entity IPHILEOFJLB)
		{
			return default(LocalId);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x32B5C20", Offset = "0x32B4A20", VA = "0x1832B5C20")]
		public static bool BHDCHHANDIG(LocalId NMOPBJNEFKL, LocalId KCJDGOIFCIF)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7231B00", Offset = "0x7230900", VA = "0x187231B00")]
		public static bool HGMDHININLF(LocalId NMOPBJNEFKL, LocalId KCJDGOIFCIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x728D360", Offset = "0x728C160", VA = "0x18728D360", Slot = "5")]
		public int CompareTo(LocalId LHMPMCLNOPG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x728DC00", Offset = "0x728CA00", VA = "0x18728DC00", Slot = "0")]
		public override bool Equals(object GJBCOOAGKBH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xC71390", Offset = "0xC70190", VA = "0x180C71390", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x728DBE0", Offset = "0x728C9E0", VA = "0x18728DBE0", Slot = "4")]
		public bool Equals(LocalId ADODGOLJGFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x728DCA0", Offset = "0x728CAA0", VA = "0x18728DCA0", Slot = "3")]
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
