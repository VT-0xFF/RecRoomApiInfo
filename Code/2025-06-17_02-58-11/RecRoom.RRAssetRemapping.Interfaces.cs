using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x861B6F0", Offset = "0x861A0F0", VA = "0x18861B6F0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA35A80", Offset = "0xA34480", VA = "0x180A35A80")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA35AC0", Offset = "0xA344C0", VA = "0x180A35AC0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface ANMFOAOENNG
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string PGPOMLMDCHO(OAJMHFIAABF OKFHNJPHDOP);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OAJMHFIAABF PGEPBAPICDN(string OKFHNJPHDOP);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct OAJMHFIAABF : IEquatable<OAJMHFIAABF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly CODNEFMDLIN MLMPCGENECN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly DGAJDHHBHCK PFGGJKPJLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid BILGBJJNAIB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool KOEOHNAAHLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x861B9D0", Offset = "0x861A3D0", VA = "0x18861B9D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool ABDIBHBHCIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x861B770", Offset = "0x861A170", VA = "0x18861B770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x861BD70", Offset = "0x861A770", VA = "0x18861BD70")]
	public OAJMHFIAABF(OAJMHFIAABF KMIOHJKEECM, [Optional] Guid LPOCINEMHOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5D41340", Offset = "0x5D3FD40", VA = "0x185D41340")]
	public OAJMHFIAABF(CODNEFMDLIN MEDDCGMBHDP, DGAJDHHBHCK PJKAFLGNEDI, [Optional] Guid LPOCINEMHOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x861B7A0", Offset = "0x861A1A0", VA = "0x18861B7A0", Slot = "4")]
	public bool Equals(OAJMHFIAABF NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x861B860", Offset = "0x861A260", VA = "0x18861B860", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x861B910", Offset = "0x861A310", VA = "0x18861B910", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x861B9A0", Offset = "0x861A3A0", VA = "0x18861B9A0")]
	public static bool IDFALDDOLDN(OAJMHFIAABF OCPABDEGAMF, OAJMHFIAABF MAMEIEKFKPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x861BA60", Offset = "0x861A460", VA = "0x18861BA60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct CODNEFMDLIN : IEquatable<CODNEFMDLIN>, IComparable<CODNEFMDLIN>, OHCFANIPIDE
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly CODNEFMDLIN BOAAIAHJNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Guid FNKCCICOAII;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1361F70", Offset = "0x1360970", VA = "0x181361F70")]
	public CODNEFMDLIN(Guid FNKCCICOAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x11465A0", Offset = "0x1144FA0", VA = "0x1811465A0", Slot = "6")]
	public Guid CLBPGDDMFNE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4D0A920", Offset = "0x4D09320", VA = "0x184D0A920", Slot = "4")]
	public bool Equals(CODNEFMDLIN NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4D0A5D0", Offset = "0x4D08FD0", VA = "0x184D0A5D0", Slot = "5")]
	public int CompareTo(CODNEFMDLIN NDNHELJMDCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x861A4B0", Offset = "0x8618EB0", VA = "0x18861A4B0", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4D0A800", Offset = "0x4D09200", VA = "0x184D0A800", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4D0A920", Offset = "0x4D09320", VA = "0x184D0A920")]
	public static bool IDFALDDOLDN(CODNEFMDLIN OCPABDEGAMF, CODNEFMDLIN MAMEIEKFKPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x861A560", Offset = "0x8618F60", VA = "0x18861A560")]
	public static bool JAIBCELPAPH(CODNEFMDLIN OCPABDEGAMF, CODNEFMDLIN MAMEIEKFKPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x861A590", Offset = "0x8618F90", VA = "0x18861A590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct MFDIBMBMPCI : IEquatable<MFDIBMBMPCI>, IComparable<MFDIBMBMPCI>, OHCFANIPIDE
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly MFDIBMBMPCI BOAAIAHJNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Guid FNKCCICOAII;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1361F70", Offset = "0x1360970", VA = "0x181361F70")]
	public MFDIBMBMPCI(Guid FNKCCICOAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x11465A0", Offset = "0x1144FA0", VA = "0x1811465A0", Slot = "6")]
	public Guid CLBPGDDMFNE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4D0A920", Offset = "0x4D09320", VA = "0x184D0A920", Slot = "4")]
	public bool Equals(MFDIBMBMPCI NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4D0A5D0", Offset = "0x4D08FD0", VA = "0x184D0A5D0", Slot = "5")]
	public int CompareTo(MFDIBMBMPCI NDNHELJMDCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x861B4B0", Offset = "0x8619EB0", VA = "0x18861B4B0", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4D0A800", Offset = "0x4D09200", VA = "0x184D0A800", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4D0A920", Offset = "0x4D09320", VA = "0x184D0A920")]
	public static bool IDFALDDOLDN(MFDIBMBMPCI OCPABDEGAMF, MFDIBMBMPCI MAMEIEKFKPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x861A560", Offset = "0x8618F60", VA = "0x18861A560")]
	public static bool JAIBCELPAPH(MFDIBMBMPCI OCPABDEGAMF, MFDIBMBMPCI MAMEIEKFKPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x861B560", Offset = "0x8619F60", VA = "0x18861B560", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct ENMPHECDLJD : IEquatable<ENMPHECDLJD>, IComparable<ENMPHECDLJD>, OHCFANIPIDE
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly ENMPHECDLJD BOAAIAHJNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Guid FNKCCICOAII;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1361F70", Offset = "0x1360970", VA = "0x181361F70")]
	public ENMPHECDLJD(Guid FNKCCICOAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x11465A0", Offset = "0x1144FA0", VA = "0x1811465A0", Slot = "6")]
	public Guid CLBPGDDMFNE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4D0A920", Offset = "0x4D09320", VA = "0x184D0A920", Slot = "4")]
	public bool Equals(ENMPHECDLJD NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4D0A5D0", Offset = "0x4D08FD0", VA = "0x184D0A5D0", Slot = "5")]
	public int CompareTo(ENMPHECDLJD NDNHELJMDCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x861A9C0", Offset = "0x86193C0", VA = "0x18861A9C0", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4D0A800", Offset = "0x4D09200", VA = "0x184D0A800", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4D0A920", Offset = "0x4D09320", VA = "0x184D0A920")]
	public static bool IDFALDDOLDN(ENMPHECDLJD OCPABDEGAMF, ENMPHECDLJD MAMEIEKFKPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x861A560", Offset = "0x8618F60", VA = "0x18861A560")]
	public static bool JAIBCELPAPH(ENMPHECDLJD OCPABDEGAMF, ENMPHECDLJD MAMEIEKFKPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x861AA70", Offset = "0x8619470", VA = "0x18861AA70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct DGAJDHHBHCK : IEquatable<DGAJDHHBHCK>, IComparable<DGAJDHHBHCK>, OHCFANIPIDE
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly DGAJDHHBHCK BOAAIAHJNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Guid FNKCCICOAII;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1361F70", Offset = "0x1360970", VA = "0x181361F70")]
	public DGAJDHHBHCK(Guid FNKCCICOAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x11465A0", Offset = "0x1144FA0", VA = "0x1811465A0", Slot = "6")]
	public Guid CLBPGDDMFNE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x861A8F0", Offset = "0x86192F0", VA = "0x18861A8F0", Slot = "4")]
	public bool Equals(DGAJDHHBHCK NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x861A840", Offset = "0x8619240", VA = "0x18861A840", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4D0A800", Offset = "0x4D09200", VA = "0x184D0A800", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x861A8F0", Offset = "0x86192F0", VA = "0x18861A8F0")]
	public static bool IDFALDDOLDN(DGAJDHHBHCK OCPABDEGAMF, DGAJDHHBHCK MAMEIEKFKPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x861A920", Offset = "0x8619320", VA = "0x18861A920")]
	public static bool JAIBCELPAPH(DGAJDHHBHCK OCPABDEGAMF, DGAJDHHBHCK MAMEIEKFKPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4D0A5D0", Offset = "0x4D08FD0", VA = "0x184D0A5D0", Slot = "5")]
	public int CompareTo(DGAJDHHBHCK NDNHELJMDCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x861A950", Offset = "0x8619350", VA = "0x18861A950", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1361F70", Offset = "0x1360970", VA = "0x181361F70")]
	public DGAJDHHBHCK(BDIPHEEHBBA OGKDLOKMIIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct COIJKNPJJBA : IEquatable<COIJKNPJJBA>, IComparable<COIJKNPJJBA>, OHCFANIPIDE
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly COIJKNPJJBA BOAAIAHJNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Guid FNKCCICOAII;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1361F70", Offset = "0x1360970", VA = "0x181361F70")]
	public COIJKNPJJBA(Guid FNKCCICOAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x11465A0", Offset = "0x1144FA0", VA = "0x1811465A0", Slot = "6")]
	public Guid CLBPGDDMFNE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4D0A920", Offset = "0x4D09320", VA = "0x184D0A920", Slot = "4")]
	public bool Equals(COIJKNPJJBA NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4D0A5D0", Offset = "0x4D08FD0", VA = "0x184D0A5D0", Slot = "5")]
	public int CompareTo(COIJKNPJJBA NDNHELJMDCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x861A600", Offset = "0x8619000", VA = "0x18861A600", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4D0A800", Offset = "0x4D09200", VA = "0x184D0A800", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4D0A920", Offset = "0x4D09320", VA = "0x184D0A920")]
	public static bool IDFALDDOLDN(COIJKNPJJBA OCPABDEGAMF, COIJKNPJJBA MAMEIEKFKPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x861A560", Offset = "0x8618F60", VA = "0x18861A560")]
	public static bool JAIBCELPAPH(COIJKNPJJBA OCPABDEGAMF, COIJKNPJJBA MAMEIEKFKPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x861A6B0", Offset = "0x86190B0", VA = "0x18861A6B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct MPLHHHEEMJC : IEquatable<MPLHHHEEMJC>, IComparable<MPLHHHEEMJC>, OHCFANIPIDE
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly MPLHHHEEMJC BOAAIAHJNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Guid FNKCCICOAII;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1361F70", Offset = "0x1360970", VA = "0x181361F70")]
	public MPLHHHEEMJC(Guid FNKCCICOAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x11465A0", Offset = "0x1144FA0", VA = "0x1811465A0", Slot = "6")]
	public Guid CLBPGDDMFNE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4D0A920", Offset = "0x4D09320", VA = "0x184D0A920", Slot = "4")]
	public bool Equals(MPLHHHEEMJC NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4D0A5D0", Offset = "0x4D08FD0", VA = "0x184D0A5D0", Slot = "5")]
	public int CompareTo(MPLHHHEEMJC NDNHELJMDCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x861B5D0", Offset = "0x8619FD0", VA = "0x18861B5D0", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4D0A800", Offset = "0x4D09200", VA = "0x184D0A800", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4D0A920", Offset = "0x4D09320", VA = "0x184D0A920")]
	public static bool IDFALDDOLDN(MPLHHHEEMJC OCPABDEGAMF, MPLHHHEEMJC MAMEIEKFKPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x861A560", Offset = "0x8618F60", VA = "0x18861A560")]
	public static bool JAIBCELPAPH(MPLHHHEEMJC OCPABDEGAMF, MPLHHHEEMJC MAMEIEKFKPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x861B680", Offset = "0x861A080", VA = "0x18861B680", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct DDMINFGPHJA : IEquatable<DDMINFGPHJA>, IComparable<DDMINFGPHJA>, OHCFANIPIDE
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly DDMINFGPHJA BOAAIAHJNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid FNKCCICOAII;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x1361F70", Offset = "0x1360970", VA = "0x181361F70")]
	public DDMINFGPHJA(Guid FNKCCICOAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x11465A0", Offset = "0x1144FA0", VA = "0x1811465A0", Slot = "6")]
	public Guid CLBPGDDMFNE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4D0A920", Offset = "0x4D09320", VA = "0x184D0A920", Slot = "4")]
	public bool Equals(DDMINFGPHJA NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4D0A5D0", Offset = "0x4D08FD0", VA = "0x184D0A5D0", Slot = "5")]
	public int CompareTo(DDMINFGPHJA NDNHELJMDCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x861A720", Offset = "0x8619120", VA = "0x18861A720", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4D0A800", Offset = "0x4D09200", VA = "0x184D0A800", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4D0A920", Offset = "0x4D09320", VA = "0x184D0A920")]
	public static bool IDFALDDOLDN(DDMINFGPHJA OCPABDEGAMF, DDMINFGPHJA MAMEIEKFKPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x861A560", Offset = "0x8618F60", VA = "0x18861A560")]
	public static bool JAIBCELPAPH(DDMINFGPHJA OCPABDEGAMF, DDMINFGPHJA MAMEIEKFKPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x861A7D0", Offset = "0x86191D0", VA = "0x18861A7D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct FALLDBEAGKF : IEquatable<FALLDBEAGKF>, IComparable<FALLDBEAGKF>, OHCFANIPIDE
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly FALLDBEAGKF BOAAIAHJNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid FNKCCICOAII;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1361F70", Offset = "0x1360970", VA = "0x181361F70")]
	public FALLDBEAGKF(Guid FNKCCICOAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x11465A0", Offset = "0x1144FA0", VA = "0x1811465A0", Slot = "6")]
	public Guid CLBPGDDMFNE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4D0A920", Offset = "0x4D09320", VA = "0x184D0A920", Slot = "4")]
	public bool Equals(FALLDBEAGKF NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4D0A5D0", Offset = "0x4D08FD0", VA = "0x184D0A5D0", Slot = "5")]
	public int CompareTo(FALLDBEAGKF NDNHELJMDCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x861AAE0", Offset = "0x86194E0", VA = "0x18861AAE0", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4D0A800", Offset = "0x4D09200", VA = "0x184D0A800", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4D0A920", Offset = "0x4D09320", VA = "0x184D0A920")]
	public static bool IDFALDDOLDN(FALLDBEAGKF OCPABDEGAMF, FALLDBEAGKF MAMEIEKFKPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x861A560", Offset = "0x8618F60", VA = "0x18861A560")]
	public static bool JAIBCELPAPH(FALLDBEAGKF OCPABDEGAMF, FALLDBEAGKF MAMEIEKFKPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x861AB90", Offset = "0x8619590", VA = "0x18861AB90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct FMEOGEBJMFH : IEquatable<FMEOGEBJMFH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly string?[]? KHECJGEJEBL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool LFELJFCAJBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x861B0D0", Offset = "0x8619AD0", VA = "0x18861B0D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int FNIBBNNPGFI
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x52AE9E0", Offset = "0x52AD3E0", VA = "0x1852AE9E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x861B200", Offset = "0x8619C00", VA = "0x18861B200")]
	public FMEOGEBJMFH(string? PGDILCNBBJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x861B180", Offset = "0x8619B80", VA = "0x18861B180")]
	public FMEOGEBJMFH(string?[] DNKMBADMPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x861AE40", Offset = "0x8619840", VA = "0x18861AE40")]
	private static string?[]? KPACFAOONPC(string?[]? DNKMBADMPDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x861B070", Offset = "0x8619A70", VA = "0x18861B070")]
	public string NAMENNEPOOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x861AC00", Offset = "0x8619600", VA = "0x18861AC00", Slot = "4")]
	public bool Equals(FMEOGEBJMFH NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x861ACD0", Offset = "0x86196D0", VA = "0x18861ACD0", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x861AD60", Offset = "0x8619760", VA = "0x18861AD60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x861B0F0", Offset = "0x8619AF0", VA = "0x18861B0F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct BDIPHEEHBBA : IEquatable<BDIPHEEHBBA>, IComparable<BDIPHEEHBBA>, OHCFANIPIDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid FNKCCICOAII;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1361F70", Offset = "0x1360970", VA = "0x181361F70")]
	public BDIPHEEHBBA(Guid FNKCCICOAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x11465A0", Offset = "0x1144FA0", VA = "0x1811465A0", Slot = "6")]
	public Guid CLBPGDDMFNE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4D0A920", Offset = "0x4D09320", VA = "0x184D0A920", Slot = "4")]
	public bool Equals(BDIPHEEHBBA NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4D0A5D0", Offset = "0x4D08FD0", VA = "0x184D0A5D0", Slot = "5")]
	public int CompareTo(BDIPHEEHBBA NDNHELJMDCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x861A390", Offset = "0x8618D90", VA = "0x18861A390", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4D0A800", Offset = "0x4D09200", VA = "0x184D0A800", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x861A440", Offset = "0x8618E40", VA = "0x18861A440", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface AJLEABMLMNA<TModern> : MPCMPDJAILK<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string EOBFCKIDAEK(TModern AAHCLBFMHMO);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface OHCFANIPIDE
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid CLBPGDDMFNE();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface MPCMPDJAILK<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern KGIGEOKHAAJ(string AAHCLBFMHMO);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface ELAAHCCONCL
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	AJLEABMLMNA<CODNEFMDLIN> PENCPHDCKNI
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	AJLEABMLMNA<COIJKNPJJBA> NABFPIFNCJK
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	AJLEABMLMNA<FALLDBEAGKF> IBOBGCMADIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	AJLEABMLMNA<DGAJDHHBHCK> PPDBECNCKJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	AJLEABMLMNA<ENMPHECDLJD> KEBLKBLDAPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	AJLEABMLMNA<DDMINFGPHJA> NGEIOBALFGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	AJLEABMLMNA<MFDIBMBMPCI> DNHGPKAPPFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	AJLEABMLMNA<MPLHHHEEMJC> HHAMDHEFMAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class HIKMMAIIFKP
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly char[] FPKLJAKOCMH;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x861B350", Offset = "0x8619D50", VA = "0x18861B350")]
	public static string[] AJKDKMCFHGL(string? PGDILCNBBJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x861B3F0", Offset = "0x8619DF0", VA = "0x18861B3F0")]
	public static string? NCFFLKLMNMN(string? MEDDCGMBHDP)
	{
		return null;
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
