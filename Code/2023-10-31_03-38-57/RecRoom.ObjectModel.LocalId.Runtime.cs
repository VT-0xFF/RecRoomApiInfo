using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.ObjectModel
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
			[Cpp2IlInjected.Address(RVA = "0x75E5C0", Offset = "0x75D9C0", VA = "0x18075E5C0")]
			get
			{
				return default(LocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool IsNull
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x5D61A70", Offset = "0x5D60E70", VA = "0x185D61A70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool IsNotNull
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x5D61A50", Offset = "0x5D60E50", VA = "0x185D61A50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x982310", Offset = "0x981710", VA = "0x180982310")]
		public LocalId(int APOENOPNHBG, int FOIKACEEEGH)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5D618D0", Offset = "0x5D60CD0", VA = "0x185D618D0")]
		public static Entity BNPEICKPPJA(LocalId EOHMJBFGDPD)
		{
			return default(Entity);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5D618D0", Offset = "0x5D60CD0", VA = "0x185D618D0")]
		public static LocalId BNPEICKPPJA(Entity EOHMJBFGDPD)
		{
			return default(LocalId);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2252080", Offset = "0x2251480", VA = "0x182252080")]
		public static bool MEMFAJGIIAO(LocalId IBOMHLKOLJB, LocalId FFDHLLBEMJM)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5D517A0", Offset = "0x5D50BA0", VA = "0x185D517A0")]
		public static bool OPPLDLMADNB(LocalId IBOMHLKOLJB, LocalId FFDHLLBEMJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5D57B60", Offset = "0x5D56F60", VA = "0x185D57B60", Slot = "5")]
		public int CompareTo(LocalId LJIBJAOOGGF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5D61910", Offset = "0x5D60D10", VA = "0x185D61910", Slot = "0")]
		public override bool Equals(object BFHPPLDLNCN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7DFAD0", Offset = "0x7DEED0", VA = "0x1807DFAD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5D618F0", Offset = "0x5D60CF0", VA = "0x185D618F0", Slot = "4")]
		public bool Equals(LocalId PIBFDGEOBKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5D619A0", Offset = "0x5D60DA0", VA = "0x185D619A0", Slot = "3")]
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
