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
			[Cpp2IlInjected.Address(RVA = "0x8B5BB0", Offset = "0x8B4BB0", VA = "0x1808B5BB0")]
			get
			{
				return default(LocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x99A6C0", Offset = "0x9996C0", VA = "0x18099A6C0")]
		public LocalId(int KHAIDMGPIED, int FNBFBBNHKCM)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xE5AFA0", Offset = "0xE59FA0", VA = "0x180E5AFA0")]
		public static Entity ILBKFABDDDI(LocalId BJDKOHEGDOK)
		{
			return default(Entity);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xE5AFA0", Offset = "0xE59FA0", VA = "0x180E5AFA0")]
		public static LocalId ILBKFABDDDI(Entity BJDKOHEGDOK)
		{
			return default(LocalId);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2F95500", Offset = "0x2F94500", VA = "0x182F95500")]
		public static bool LJMKDDBNEAO(LocalId LOPBCKBMJBH, LocalId BMJGCJANGHI)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6E63350", Offset = "0x6E62350", VA = "0x186E63350")]
		public static bool MCPOKKIFBCL(LocalId LOPBCKBMJBH, LocalId BMJGCJANGHI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6EBB6C0", Offset = "0x6EBA6C0", VA = "0x186EBB6C0", Slot = "5")]
		public int CompareTo(LocalId DFABCHNPEEM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6EBBEA0", Offset = "0x6EBAEA0", VA = "0x186EBBEA0", Slot = "0")]
		public override bool Equals(object ICLGPPMPPPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA1E8F0", Offset = "0xA1D8F0", VA = "0x180A1E8F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6EBBE80", Offset = "0x6EBAE80", VA = "0x186EBBE80", Slot = "4")]
		public bool Equals(LocalId NAJNBMNONGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6EBBF30", Offset = "0x6EBAF30", VA = "0x186EBBF30", Slot = "3")]
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
