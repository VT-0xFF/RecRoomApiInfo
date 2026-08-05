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
			[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240")]
			get
			{
				return default(LocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xCE0AB0", Offset = "0xCDFEB0", VA = "0x180CE0AB0")]
		public LocalId(int COPLIEINKOF, int IPCFHGIMHJJ)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x1214CA0", Offset = "0x12140A0", VA = "0x181214CA0")]
		public static Entity HIHFKEJHDAH(LocalId OOEMJLHLIHJ)
		{
			return default(Entity);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1214CA0", Offset = "0x12140A0", VA = "0x181214CA0")]
		public static LocalId HIHFKEJHDAH(Entity OOEMJLHLIHJ)
		{
			return default(LocalId);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x38C4AF0", Offset = "0x38C3EF0", VA = "0x1838C4AF0")]
		public static bool HGJBAFCOLON(LocalId PPPJAHNPKAO, LocalId DFIFINAEGII)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7AA89A0", Offset = "0x7AA7DA0", VA = "0x187AA89A0")]
		public static bool PBNEENGPCHJ(LocalId PPPJAHNPKAO, LocalId DFIFINAEGII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7B0EA80", Offset = "0x7B0DE80", VA = "0x187B0EA80", Slot = "5")]
		public int CompareTo(LocalId DMMBOHMLHLF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7B10920", Offset = "0x7B0FD20", VA = "0x187B10920", Slot = "0")]
		public override bool Equals(object FHOCBFMIGHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA165E0", Offset = "0xA159E0", VA = "0x180A165E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7B10900", Offset = "0x7B0FD00", VA = "0x187B10900", Slot = "4")]
		public bool Equals(LocalId LAOCDNNIMLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7B109C0", Offset = "0x7B0FDC0", VA = "0x187B109C0", Slot = "3")]
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
