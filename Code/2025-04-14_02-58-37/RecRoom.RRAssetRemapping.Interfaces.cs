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
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x813FC80", Offset = "0x813E680", VA = "0x18813FC80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9D8490", Offset = "0x9D6E90", VA = "0x1809D8490")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D84D0", Offset = "0x9D6ED0", VA = "0x1809D84D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface PDGGKLGBFNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string CFLEALCFLNK(FPDCEKEDCDG OBMEHBOBMDK);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FPDCEKEDCDG DHOLDBOACBA(string OBMEHBOBMDK);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct FPDCEKEDCDG : IEquatable<FPDCEKEDCDG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly MCOHPILBDMI GCKPIDNIOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly BEAKLKOGAHD OCIOPNPFLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid AIGDOOGMEHE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool GOIPOMPHMLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x813E870", Offset = "0x813D270", VA = "0x18813E870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool CPGNPPPBBGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x813E900", Offset = "0x813D300", VA = "0x18813E900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x813EE60", Offset = "0x813D860", VA = "0x18813EE60")]
	public FPDCEKEDCDG(FPDCEKEDCDG JAJGJAIPKFA, [Optional] Guid NJBMCDEDLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x597D400", Offset = "0x597BE00", VA = "0x18597D400")]
	public FPDCEKEDCDG(MCOHPILBDMI MIGHDPKECBA, BEAKLKOGAHD CNKMJFLJHEA, [Optional] Guid NJBMCDEDLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x813E9E0", Offset = "0x813D3E0", VA = "0x18813E9E0", Slot = "4")]
	public bool Equals(FPDCEKEDCDG OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x813E930", Offset = "0x813D330", VA = "0x18813E930", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x813EAA0", Offset = "0x813D4A0", VA = "0x18813EAA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x813EB30", Offset = "0x813D530", VA = "0x18813EB30")]
	public static bool HFGMMLFJJJB(FPDCEKEDCDG AKJAPDOPIOF, FPDCEKEDCDG CPKHJEJFIJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x813EB60", Offset = "0x813D560", VA = "0x18813EB60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct MCOHPILBDMI : IEquatable<MCOHPILBDMI>, IComparable<MCOHPILBDMI>, NBFPJEEGCEI
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly MCOHPILBDMI KPJGFDDMHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Guid BIGAPECKJPI;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1136320", Offset = "0x1134D20", VA = "0x181136320")]
	public MCOHPILBDMI(Guid BIGAPECKJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1136330", Offset = "0x1134D30", VA = "0x181136330", Slot = "6")]
	public Guid BIKPNAIIBLG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x52F0030", Offset = "0x52EEA30", VA = "0x1852F0030", Slot = "4")]
	public bool Equals(MCOHPILBDMI OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x52EFC70", Offset = "0x52EE670", VA = "0x1852EFC70", Slot = "5")]
	public int CompareTo(MCOHPILBDMI OLKLGHOAKNE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x813FA60", Offset = "0x813E460", VA = "0x18813FA60", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x52EFF60", Offset = "0x52EE960", VA = "0x1852EFF60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x52F0030", Offset = "0x52EEA30", VA = "0x1852F0030")]
	public static bool HFGMMLFJJJB(MCOHPILBDMI AKJAPDOPIOF, MCOHPILBDMI CPKHJEJFIJK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x813E510", Offset = "0x813CF10", VA = "0x18813E510")]
	public static bool BDABLEIINAG(MCOHPILBDMI AKJAPDOPIOF, MCOHPILBDMI CPKHJEJFIJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x813FB00", Offset = "0x813E500", VA = "0x18813FB00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct GNGAKHCDFCP : IEquatable<GNGAKHCDFCP>, IComparable<GNGAKHCDFCP>, NBFPJEEGCEI
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly GNGAKHCDFCP KPJGFDDMHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Guid BIGAPECKJPI;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1136320", Offset = "0x1134D20", VA = "0x181136320")]
	public GNGAKHCDFCP(Guid BIGAPECKJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1136330", Offset = "0x1134D30", VA = "0x181136330", Slot = "6")]
	public Guid BIKPNAIIBLG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x52F0030", Offset = "0x52EEA30", VA = "0x1852F0030", Slot = "4")]
	public bool Equals(GNGAKHCDFCP OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x52EFC70", Offset = "0x52EE670", VA = "0x1852EFC70", Slot = "5")]
	public int CompareTo(GNGAKHCDFCP OLKLGHOAKNE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x813EE80", Offset = "0x813D880", VA = "0x18813EE80", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x52EFF60", Offset = "0x52EE960", VA = "0x1852EFF60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x52F0030", Offset = "0x52EEA30", VA = "0x1852F0030")]
	public static bool HFGMMLFJJJB(GNGAKHCDFCP AKJAPDOPIOF, GNGAKHCDFCP CPKHJEJFIJK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x813E510", Offset = "0x813CF10", VA = "0x18813E510")]
	public static bool BDABLEIINAG(GNGAKHCDFCP AKJAPDOPIOF, GNGAKHCDFCP CPKHJEJFIJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x813EF20", Offset = "0x813D920", VA = "0x18813EF20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct HNEGNIKOBIL : IEquatable<HNEGNIKOBIL>, IComparable<HNEGNIKOBIL>, NBFPJEEGCEI
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly HNEGNIKOBIL KPJGFDDMHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Guid BIGAPECKJPI;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1136320", Offset = "0x1134D20", VA = "0x181136320")]
	public HNEGNIKOBIL(Guid BIGAPECKJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1136330", Offset = "0x1134D30", VA = "0x181136330", Slot = "6")]
	public Guid BIKPNAIIBLG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x52F0030", Offset = "0x52EEA30", VA = "0x1852F0030", Slot = "4")]
	public bool Equals(HNEGNIKOBIL OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x52EFC70", Offset = "0x52EE670", VA = "0x1852EFC70", Slot = "5")]
	public int CompareTo(HNEGNIKOBIL OLKLGHOAKNE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x813EF90", Offset = "0x813D990", VA = "0x18813EF90", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x52EFF60", Offset = "0x52EE960", VA = "0x1852EFF60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x52F0030", Offset = "0x52EEA30", VA = "0x1852F0030")]
	public static bool HFGMMLFJJJB(HNEGNIKOBIL AKJAPDOPIOF, HNEGNIKOBIL CPKHJEJFIJK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x813E510", Offset = "0x813CF10", VA = "0x18813E510")]
	public static bool BDABLEIINAG(HNEGNIKOBIL AKJAPDOPIOF, HNEGNIKOBIL CPKHJEJFIJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x813F030", Offset = "0x813DA30", VA = "0x18813F030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct BEAKLKOGAHD : IEquatable<BEAKLKOGAHD>, IComparable<BEAKLKOGAHD>, NBFPJEEGCEI
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly BEAKLKOGAHD KPJGFDDMHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Guid BIGAPECKJPI;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1136320", Offset = "0x1134D20", VA = "0x181136320")]
	public BEAKLKOGAHD(Guid BIGAPECKJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1136330", Offset = "0x1134D30", VA = "0x181136330", Slot = "6")]
	public Guid BIKPNAIIBLG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x813E470", Offset = "0x813CE70", VA = "0x18813E470", Slot = "4")]
	public bool Equals(BEAKLKOGAHD OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x813E3D0", Offset = "0x813CDD0", VA = "0x18813E3D0", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x52EFF60", Offset = "0x52EE960", VA = "0x1852EFF60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x813E470", Offset = "0x813CE70", VA = "0x18813E470")]
	public static bool HFGMMLFJJJB(BEAKLKOGAHD AKJAPDOPIOF, BEAKLKOGAHD CPKHJEJFIJK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x813E3A0", Offset = "0x813CDA0", VA = "0x18813E3A0")]
	public static bool BDABLEIINAG(BEAKLKOGAHD AKJAPDOPIOF, BEAKLKOGAHD CPKHJEJFIJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x52EFC70", Offset = "0x52EE670", VA = "0x1852EFC70", Slot = "5")]
	public int CompareTo(BEAKLKOGAHD OLKLGHOAKNE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x813E4A0", Offset = "0x813CEA0", VA = "0x18813E4A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1136320", Offset = "0x1134D20", VA = "0x181136320")]
	public BEAKLKOGAHD(CLEGOBMMEGH DPLGHBDCCNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct IAIAOHGCJGA : IEquatable<IAIAOHGCJGA>, IComparable<IAIAOHGCJGA>, NBFPJEEGCEI
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly IAIAOHGCJGA KPJGFDDMHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Guid BIGAPECKJPI;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1136320", Offset = "0x1134D20", VA = "0x181136320")]
	public IAIAOHGCJGA(Guid BIGAPECKJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1136330", Offset = "0x1134D30", VA = "0x181136330", Slot = "6")]
	public Guid BIKPNAIIBLG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x52F0030", Offset = "0x52EEA30", VA = "0x1852F0030", Slot = "4")]
	public bool Equals(IAIAOHGCJGA OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x52EFC70", Offset = "0x52EE670", VA = "0x1852EFC70", Slot = "5")]
	public int CompareTo(IAIAOHGCJGA OLKLGHOAKNE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x813F0A0", Offset = "0x813DAA0", VA = "0x18813F0A0", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x52EFF60", Offset = "0x52EE960", VA = "0x1852EFF60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x52F0030", Offset = "0x52EEA30", VA = "0x1852F0030")]
	public static bool HFGMMLFJJJB(IAIAOHGCJGA AKJAPDOPIOF, IAIAOHGCJGA CPKHJEJFIJK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x813E510", Offset = "0x813CF10", VA = "0x18813E510")]
	public static bool BDABLEIINAG(IAIAOHGCJGA AKJAPDOPIOF, IAIAOHGCJGA CPKHJEJFIJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x813F140", Offset = "0x813DB40", VA = "0x18813F140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct FLDKPNGONNC : IEquatable<FLDKPNGONNC>, IComparable<FLDKPNGONNC>, NBFPJEEGCEI
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly FLDKPNGONNC KPJGFDDMHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Guid BIGAPECKJPI;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1136320", Offset = "0x1134D20", VA = "0x181136320")]
	public FLDKPNGONNC(Guid BIGAPECKJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1136330", Offset = "0x1134D30", VA = "0x181136330", Slot = "6")]
	public Guid BIKPNAIIBLG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x52F0030", Offset = "0x52EEA30", VA = "0x1852F0030", Slot = "4")]
	public bool Equals(FLDKPNGONNC OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x52EFC70", Offset = "0x52EE670", VA = "0x1852EFC70", Slot = "5")]
	public int CompareTo(FLDKPNGONNC OLKLGHOAKNE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x813E760", Offset = "0x813D160", VA = "0x18813E760", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x52EFF60", Offset = "0x52EE960", VA = "0x1852EFF60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x52F0030", Offset = "0x52EEA30", VA = "0x1852F0030")]
	public static bool HFGMMLFJJJB(FLDKPNGONNC AKJAPDOPIOF, FLDKPNGONNC CPKHJEJFIJK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x813E510", Offset = "0x813CF10", VA = "0x18813E510")]
	public static bool BDABLEIINAG(FLDKPNGONNC AKJAPDOPIOF, FLDKPNGONNC CPKHJEJFIJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x813E800", Offset = "0x813D200", VA = "0x18813E800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct BLIIEFBMILH : IEquatable<BLIIEFBMILH>, IComparable<BLIIEFBMILH>, NBFPJEEGCEI
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly BLIIEFBMILH KPJGFDDMHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid BIGAPECKJPI;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x1136320", Offset = "0x1134D20", VA = "0x181136320")]
	public BLIIEFBMILH(Guid BIGAPECKJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1136330", Offset = "0x1134D30", VA = "0x181136330", Slot = "6")]
	public Guid BIKPNAIIBLG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x52F0030", Offset = "0x52EEA30", VA = "0x1852F0030", Slot = "4")]
	public bool Equals(BLIIEFBMILH OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x52EFC70", Offset = "0x52EE670", VA = "0x1852EFC70", Slot = "5")]
	public int CompareTo(BLIIEFBMILH OLKLGHOAKNE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x813E540", Offset = "0x813CF40", VA = "0x18813E540", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x52EFF60", Offset = "0x52EE960", VA = "0x1852EFF60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x52F0030", Offset = "0x52EEA30", VA = "0x1852F0030")]
	public static bool HFGMMLFJJJB(BLIIEFBMILH AKJAPDOPIOF, BLIIEFBMILH CPKHJEJFIJK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x813E510", Offset = "0x813CF10", VA = "0x18813E510")]
	public static bool BDABLEIINAG(BLIIEFBMILH AKJAPDOPIOF, BLIIEFBMILH CPKHJEJFIJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x813E5E0", Offset = "0x813CFE0", VA = "0x18813E5E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct NNFFMGJCAON : IEquatable<NNFFMGJCAON>, IComparable<NNFFMGJCAON>, NBFPJEEGCEI
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly NNFFMGJCAON KPJGFDDMHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid BIGAPECKJPI;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1136320", Offset = "0x1134D20", VA = "0x181136320")]
	public NNFFMGJCAON(Guid BIGAPECKJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1136330", Offset = "0x1134D30", VA = "0x181136330", Slot = "6")]
	public Guid BIKPNAIIBLG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x52F0030", Offset = "0x52EEA30", VA = "0x1852F0030", Slot = "4")]
	public bool Equals(NNFFMGJCAON OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x52EFC70", Offset = "0x52EE670", VA = "0x1852EFC70", Slot = "5")]
	public int CompareTo(NNFFMGJCAON OLKLGHOAKNE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x813FB70", Offset = "0x813E570", VA = "0x18813FB70", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x52EFF60", Offset = "0x52EE960", VA = "0x1852EFF60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x52F0030", Offset = "0x52EEA30", VA = "0x1852F0030")]
	public static bool HFGMMLFJJJB(NNFFMGJCAON AKJAPDOPIOF, NNFFMGJCAON CPKHJEJFIJK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x813E510", Offset = "0x813CF10", VA = "0x18813E510")]
	public static bool BDABLEIINAG(NNFFMGJCAON AKJAPDOPIOF, NNFFMGJCAON CPKHJEJFIJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x813FC10", Offset = "0x813E610", VA = "0x18813FC10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct JCKCCOBELDI : IEquatable<JCKCCOBELDI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly string?[]? PKGCOEHMKEE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool DDFCNJDHCLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x813F7E0", Offset = "0x813E1E0", VA = "0x18813F7E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int MFHHCHBEGIP
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5283E10", Offset = "0x5282810", VA = "0x185283E10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x813F890", Offset = "0x813E290", VA = "0x18813F890")]
	public JCKCCOBELDI(string? KFACIDMIMKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x813F9E0", Offset = "0x813E3E0", VA = "0x18813F9E0")]
	public JCKCCOBELDI(string?[] PHGAIDDKLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x813F5B0", Offset = "0x813DFB0", VA = "0x18813F5B0")]
	private static string?[]? JABHMMEGACA(string?[]? PHGAIDDKLKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x813F310", Offset = "0x813DD10", VA = "0x18813F310")]
	public string CEJNIPKLHBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x813F370", Offset = "0x813DD70", VA = "0x18813F370", Slot = "4")]
	public bool Equals(JCKCCOBELDI OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x813F440", Offset = "0x813DE40", VA = "0x18813F440", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x813F4D0", Offset = "0x813DED0", VA = "0x18813F4D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x813F800", Offset = "0x813E200", VA = "0x18813F800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct CLEGOBMMEGH : IEquatable<CLEGOBMMEGH>, IComparable<CLEGOBMMEGH>, NBFPJEEGCEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid BIGAPECKJPI;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1136320", Offset = "0x1134D20", VA = "0x181136320")]
	public CLEGOBMMEGH(Guid BIGAPECKJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1136330", Offset = "0x1134D30", VA = "0x181136330", Slot = "6")]
	public Guid BIKPNAIIBLG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x52F0030", Offset = "0x52EEA30", VA = "0x1852F0030", Slot = "4")]
	public bool Equals(CLEGOBMMEGH OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x52EFC70", Offset = "0x52EE670", VA = "0x1852EFC70", Slot = "5")]
	public int CompareTo(CLEGOBMMEGH OLKLGHOAKNE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x813E650", Offset = "0x813D050", VA = "0x18813E650", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x52EFF60", Offset = "0x52EE960", VA = "0x1852EFF60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x813E6F0", Offset = "0x813D0F0", VA = "0x18813E6F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface ACONCFPALJC<TModern> : NOILDNDGELG<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string ONGIDONMJCK(TModern JDBODLGJMCB);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface NBFPJEEGCEI
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid BIKPNAIIBLG();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface NOILDNDGELG<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern DHIOAMEGEMH(string JDBODLGJMCB);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface BFKGFOMADKP
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	ACONCFPALJC<MCOHPILBDMI> GCDPOJFINAD
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	ACONCFPALJC<IAIAOHGCJGA> GFIOJKOPION
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	ACONCFPALJC<NNFFMGJCAON> CBJNHHKLGMD
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	ACONCFPALJC<BEAKLKOGAHD> HIKPIBFCEPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	ACONCFPALJC<HNEGNIKOBIL> ENDAILEFABB
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	ACONCFPALJC<BLIIEFBMILH> MNCHDBLNAEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	ACONCFPALJC<GNGAKHCDFCP> FJDJPHLELFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	ACONCFPALJC<FLDKPNGONNC> JBDPJHFGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class IAJMNEHHHDG
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly char[] HCKKABDIEHI;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x813F1B0", Offset = "0x813DBB0", VA = "0x18813F1B0")]
	public static string[] ACADNAJCPGI(string? KFACIDMIMKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x813F250", Offset = "0x813DC50", VA = "0x18813F250")]
	public static string? FKJLNNACFDO(string? MIGHDPKECBA)
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
