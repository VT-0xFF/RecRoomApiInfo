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
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7783D60", Offset = "0x7783160", VA = "0x187783D60")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8F1670", Offset = "0x8F0A70", VA = "0x1808F1670")]
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
		[Cpp2IlInjected.Address(RVA = "0x8F16B0", Offset = "0x8F0AB0", VA = "0x1808F16B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JOPKLKKBJAP
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string GKPJGNLGAKF(HHDIOAFENPE AOOGNGKJLKL);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HHDIOAFENPE KBLFJIABLOP(string AOOGNGKJLKL);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct HHDIOAFENPE : IEquatable<HHDIOAFENPE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly FKEBAHOJOEH AHPBCNIAJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly DOPNIDFJPBN ANKJBIFHOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid PMMDFDOJGMF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool EKKOKEPKAJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7783410", Offset = "0x7782810", VA = "0x187783410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool CDIMJIMLCLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x77833A0", Offset = "0x77827A0", VA = "0x1877833A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x77837A0", Offset = "0x7782BA0", VA = "0x1877837A0")]
	public HHDIOAFENPE(HHDIOAFENPE FELDJIJABEP, [Optional] Guid DFGGLDDDDMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x51DE340", Offset = "0x51DD740", VA = "0x1851DE340")]
	public HHDIOAFENPE(FKEBAHOJOEH CJJEOONCGLJ, DOPNIDFJPBN ABDBLINMLHM, [Optional] Guid DFGGLDDDDMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7783170", Offset = "0x7782570", VA = "0x187783170", Slot = "4")]
	public bool Equals(HHDIOAFENPE BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7783230", Offset = "0x7782630", VA = "0x187783230", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7783310", Offset = "0x7782710", VA = "0x187783310", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x77832E0", Offset = "0x77826E0", VA = "0x1877832E0")]
	public static bool FANHDJJNLED(HHDIOAFENPE KLFFMNNBENE, HHDIOAFENPE EHNIKEHCICN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x77833D0", Offset = "0x77827D0", VA = "0x1877833D0")]
	public static bool KNIDLJBALLO(HHDIOAFENPE KLFFMNNBENE, HHDIOAFENPE EHNIKEHCICN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x77834A0", Offset = "0x77828A0", VA = "0x1877834A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct FKEBAHOJOEH : IEquatable<FKEBAHOJOEH>, IComparable<FKEBAHOJOEH>, MDKKLDNPMCM
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly FKEBAHOJOEH MGEHKGIFIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Guid FNECNONNEND;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0xDD9170", Offset = "0xDD8570", VA = "0x180DD9170")]
	public FKEBAHOJOEH(Guid FNECNONNEND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0xDD9160", Offset = "0xDD8560", VA = "0x180DD9160", Slot = "6")]
	public Guid ELEOGAJCADM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4C45680", Offset = "0x4C44A80", VA = "0x184C45680", Slot = "4")]
	public bool Equals(FKEBAHOJOEH BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4C45650", Offset = "0x4C44A50", VA = "0x184C45650", Slot = "5")]
	public int CompareTo(FKEBAHOJOEH BMKPAKCEMFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7782F50", Offset = "0x7782350", VA = "0x187782F50", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4C45940", Offset = "0x4C44D40", VA = "0x184C45940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4C45680", Offset = "0x4C44A80", VA = "0x184C45680")]
	public static bool FANHDJJNLED(FKEBAHOJOEH KLFFMNNBENE, FKEBAHOJOEH EHNIKEHCICN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7782C30", Offset = "0x7782030", VA = "0x187782C30")]
	public static bool KNIDLJBALLO(FKEBAHOJOEH KLFFMNNBENE, FKEBAHOJOEH EHNIKEHCICN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7782FF0", Offset = "0x77823F0", VA = "0x187782FF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct LGEDBJMHMNA : IEquatable<LGEDBJMHMNA>, IComparable<LGEDBJMHMNA>, MDKKLDNPMCM
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly LGEDBJMHMNA MGEHKGIFIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Guid FNECNONNEND;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xDD9170", Offset = "0xDD8570", VA = "0x180DD9170")]
	public LGEDBJMHMNA(Guid FNECNONNEND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xDD9160", Offset = "0xDD8560", VA = "0x180DD9160", Slot = "6")]
	public Guid ELEOGAJCADM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4C45680", Offset = "0x4C44A80", VA = "0x184C45680", Slot = "4")]
	public bool Equals(LGEDBJMHMNA BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4C45650", Offset = "0x4C44A50", VA = "0x184C45650", Slot = "5")]
	public int CompareTo(LGEDBJMHMNA BMKPAKCEMFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7783B40", Offset = "0x7782F40", VA = "0x187783B40", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4C45940", Offset = "0x4C44D40", VA = "0x184C45940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4C45680", Offset = "0x4C44A80", VA = "0x184C45680")]
	public static bool FANHDJJNLED(LGEDBJMHMNA KLFFMNNBENE, LGEDBJMHMNA EHNIKEHCICN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7782C30", Offset = "0x7782030", VA = "0x187782C30")]
	public static bool KNIDLJBALLO(LGEDBJMHMNA KLFFMNNBENE, LGEDBJMHMNA EHNIKEHCICN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7783BE0", Offset = "0x7782FE0", VA = "0x187783BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct GHOPLCAKCFO : IEquatable<GHOPLCAKCFO>, IComparable<GHOPLCAKCFO>, MDKKLDNPMCM
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly GHOPLCAKCFO MGEHKGIFIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Guid FNECNONNEND;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xDD9170", Offset = "0xDD8570", VA = "0x180DD9170")]
	public GHOPLCAKCFO(Guid FNECNONNEND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xDD9160", Offset = "0xDD8560", VA = "0x180DD9160", Slot = "6")]
	public Guid ELEOGAJCADM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4C45680", Offset = "0x4C44A80", VA = "0x184C45680", Slot = "4")]
	public bool Equals(GHOPLCAKCFO BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4C45650", Offset = "0x4C44A50", VA = "0x184C45650", Slot = "5")]
	public int CompareTo(GHOPLCAKCFO BMKPAKCEMFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7783060", Offset = "0x7782460", VA = "0x187783060", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4C45940", Offset = "0x4C44D40", VA = "0x184C45940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4C45680", Offset = "0x4C44A80", VA = "0x184C45680")]
	public static bool FANHDJJNLED(GHOPLCAKCFO KLFFMNNBENE, GHOPLCAKCFO EHNIKEHCICN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7782C30", Offset = "0x7782030", VA = "0x187782C30")]
	public static bool KNIDLJBALLO(GHOPLCAKCFO KLFFMNNBENE, GHOPLCAKCFO EHNIKEHCICN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7783100", Offset = "0x7782500", VA = "0x187783100", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct DOPNIDFJPBN : IEquatable<DOPNIDFJPBN>, IComparable<DOPNIDFJPBN>, MDKKLDNPMCM
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly DOPNIDFJPBN MGEHKGIFIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Guid FNECNONNEND;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xDD9170", Offset = "0xDD8570", VA = "0x180DD9170")]
	public DOPNIDFJPBN(Guid FNECNONNEND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0xDD9160", Offset = "0xDD8560", VA = "0x180DD9160", Slot = "6")]
	public Guid ELEOGAJCADM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7782CD0", Offset = "0x77820D0", VA = "0x187782CD0", Slot = "4")]
	public bool Equals(DOPNIDFJPBN BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7782D00", Offset = "0x7782100", VA = "0x187782D00", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4C45940", Offset = "0x4C44D40", VA = "0x184C45940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7782CD0", Offset = "0x77820D0", VA = "0x187782CD0")]
	public static bool FANHDJJNLED(DOPNIDFJPBN KLFFMNNBENE, DOPNIDFJPBN EHNIKEHCICN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7782DA0", Offset = "0x77821A0", VA = "0x187782DA0")]
	public static bool KNIDLJBALLO(DOPNIDFJPBN KLFFMNNBENE, DOPNIDFJPBN EHNIKEHCICN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4C45650", Offset = "0x4C44A50", VA = "0x184C45650", Slot = "5")]
	public int CompareTo(DOPNIDFJPBN BMKPAKCEMFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7782DD0", Offset = "0x77821D0", VA = "0x187782DD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0xDD9170", Offset = "0xDD8570", VA = "0x180DD9170")]
	public DOPNIDFJPBN(KFCPMCHPDCP ABPEMJNOIEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct KPAAJPHOOAN : IEquatable<KPAAJPHOOAN>, IComparable<KPAAJPHOOAN>, MDKKLDNPMCM
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly KPAAJPHOOAN MGEHKGIFIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Guid FNECNONNEND;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0xDD9170", Offset = "0xDD8570", VA = "0x180DD9170")]
	public KPAAJPHOOAN(Guid FNECNONNEND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0xDD9160", Offset = "0xDD8560", VA = "0x180DD9160", Slot = "6")]
	public Guid ELEOGAJCADM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4C45680", Offset = "0x4C44A80", VA = "0x184C45680", Slot = "4")]
	public bool Equals(KPAAJPHOOAN BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4C45650", Offset = "0x4C44A50", VA = "0x184C45650", Slot = "5")]
	public int CompareTo(KPAAJPHOOAN BMKPAKCEMFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x77838D0", Offset = "0x7782CD0", VA = "0x1877838D0", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4C45940", Offset = "0x4C44D40", VA = "0x184C45940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4C45680", Offset = "0x4C44A80", VA = "0x184C45680")]
	public static bool FANHDJJNLED(KPAAJPHOOAN KLFFMNNBENE, KPAAJPHOOAN EHNIKEHCICN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7782C30", Offset = "0x7782030", VA = "0x187782C30")]
	public static bool KNIDLJBALLO(KPAAJPHOOAN KLFFMNNBENE, KPAAJPHOOAN EHNIKEHCICN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7783970", Offset = "0x7782D70", VA = "0x187783970", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct DPJDJGPLJGE : IEquatable<DPJDJGPLJGE>, IComparable<DPJDJGPLJGE>, MDKKLDNPMCM
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly DPJDJGPLJGE MGEHKGIFIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Guid FNECNONNEND;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xDD9170", Offset = "0xDD8570", VA = "0x180DD9170")]
	public DPJDJGPLJGE(Guid FNECNONNEND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0xDD9160", Offset = "0xDD8560", VA = "0x180DD9160", Slot = "6")]
	public Guid ELEOGAJCADM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4C45680", Offset = "0x4C44A80", VA = "0x184C45680", Slot = "4")]
	public bool Equals(DPJDJGPLJGE BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4C45650", Offset = "0x4C44A50", VA = "0x184C45650", Slot = "5")]
	public int CompareTo(DPJDJGPLJGE BMKPAKCEMFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7782E40", Offset = "0x7782240", VA = "0x187782E40", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4C45940", Offset = "0x4C44D40", VA = "0x184C45940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4C45680", Offset = "0x4C44A80", VA = "0x184C45680")]
	public static bool FANHDJJNLED(DPJDJGPLJGE KLFFMNNBENE, DPJDJGPLJGE EHNIKEHCICN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7782C30", Offset = "0x7782030", VA = "0x187782C30")]
	public static bool KNIDLJBALLO(DPJDJGPLJGE KLFFMNNBENE, DPJDJGPLJGE EHNIKEHCICN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7782EE0", Offset = "0x77822E0", VA = "0x187782EE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct DKCADIBAFHB : IEquatable<DKCADIBAFHB>, IComparable<DKCADIBAFHB>, MDKKLDNPMCM
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly DKCADIBAFHB MGEHKGIFIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid FNECNONNEND;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xDD9170", Offset = "0xDD8570", VA = "0x180DD9170")]
	public DKCADIBAFHB(Guid FNECNONNEND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xDD9160", Offset = "0xDD8560", VA = "0x180DD9160", Slot = "6")]
	public Guid ELEOGAJCADM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4C45680", Offset = "0x4C44A80", VA = "0x184C45680", Slot = "4")]
	public bool Equals(DKCADIBAFHB BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4C45650", Offset = "0x4C44A50", VA = "0x184C45650", Slot = "5")]
	public int CompareTo(DKCADIBAFHB BMKPAKCEMFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7782B90", Offset = "0x7781F90", VA = "0x187782B90", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4C45940", Offset = "0x4C44D40", VA = "0x184C45940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4C45680", Offset = "0x4C44A80", VA = "0x184C45680")]
	public static bool FANHDJJNLED(DKCADIBAFHB KLFFMNNBENE, DKCADIBAFHB EHNIKEHCICN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7782C30", Offset = "0x7782030", VA = "0x187782C30")]
	public static bool KNIDLJBALLO(DKCADIBAFHB KLFFMNNBENE, DKCADIBAFHB EHNIKEHCICN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7782C60", Offset = "0x7782060", VA = "0x187782C60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct MLPEKEOBFJJ : IEquatable<MLPEKEOBFJJ>, IComparable<MLPEKEOBFJJ>, MDKKLDNPMCM
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly MLPEKEOBFJJ MGEHKGIFIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid FNECNONNEND;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xDD9170", Offset = "0xDD8570", VA = "0x180DD9170")]
	public MLPEKEOBFJJ(Guid FNECNONNEND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0xDD9160", Offset = "0xDD8560", VA = "0x180DD9160", Slot = "6")]
	public Guid ELEOGAJCADM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4C45680", Offset = "0x4C44A80", VA = "0x184C45680", Slot = "4")]
	public bool Equals(MLPEKEOBFJJ BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4C45650", Offset = "0x4C44A50", VA = "0x184C45650", Slot = "5")]
	public int CompareTo(MLPEKEOBFJJ BMKPAKCEMFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7783C50", Offset = "0x7783050", VA = "0x187783C50", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4C45940", Offset = "0x4C44D40", VA = "0x184C45940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4C45680", Offset = "0x4C44A80", VA = "0x184C45680")]
	public static bool FANHDJJNLED(MLPEKEOBFJJ KLFFMNNBENE, MLPEKEOBFJJ EHNIKEHCICN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7782C30", Offset = "0x7782030", VA = "0x187782C30")]
	public static bool KNIDLJBALLO(MLPEKEOBFJJ KLFFMNNBENE, MLPEKEOBFJJ EHNIKEHCICN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7783CF0", Offset = "0x77830F0", VA = "0x187783CF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct CABHCJKGFMC : IEquatable<CABHCJKGFMC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly string?[]? JAPIFGFNJMA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool PJCKOFPFAIG
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x77823C0", Offset = "0x77817C0", VA = "0x1877823C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int PKFCGPAPAHO
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x46D9460", Offset = "0x46D8860", VA = "0x1846D9460")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7782A40", Offset = "0x7781E40", VA = "0x187782A40")]
	public CABHCJKGFMC(string? HIEKACDFIHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x77829C0", Offset = "0x7781DC0", VA = "0x1877829C0")]
	public CABHCJKGFMC(string?[] KEKHAJLLNEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x77825A0", Offset = "0x77819A0", VA = "0x1877825A0")]
	private static string?[]? FEMFDNLBAPH(string?[]? KEKHAJLLNEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x77823E0", Offset = "0x77817E0", VA = "0x1877823E0")]
	public string BOLFFHNHPON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x77824D0", Offset = "0x77818D0", VA = "0x1877824D0", Slot = "4")]
	public bool Equals(CABHCJKGFMC BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7782440", Offset = "0x7781840", VA = "0x187782440", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7782850", Offset = "0x7781C50", VA = "0x187782850", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7782930", Offset = "0x7781D30", VA = "0x187782930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct KFCPMCHPDCP : IEquatable<KFCPMCHPDCP>, IComparable<KFCPMCHPDCP>, MDKKLDNPMCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid FNECNONNEND;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xDD9170", Offset = "0xDD8570", VA = "0x180DD9170")]
	public KFCPMCHPDCP(Guid FNECNONNEND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xDD9160", Offset = "0xDD8560", VA = "0x180DD9160", Slot = "6")]
	public Guid ELEOGAJCADM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4C45680", Offset = "0x4C44A80", VA = "0x184C45680", Slot = "4")]
	public bool Equals(KFCPMCHPDCP BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4C45650", Offset = "0x4C44A50", VA = "0x184C45650", Slot = "5")]
	public int CompareTo(KFCPMCHPDCP BMKPAKCEMFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x77837C0", Offset = "0x7782BC0", VA = "0x1877837C0", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4C45940", Offset = "0x4C44D40", VA = "0x184C45940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7783860", Offset = "0x7782C60", VA = "0x187783860", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface PIBHMOCPPJE<TModern> : ODJJGNNCBPD<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string IMAKADIJCOP(TModern GILKBBJEFIL);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface MDKKLDNPMCM
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid ELEOGAJCADM();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface ODJJGNNCBPD<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern EHHBIPLJHBD(string GILKBBJEFIL);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface PLDNGFNJBOA
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	PIBHMOCPPJE<FKEBAHOJOEH> GKBKMBPFGGF
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	PIBHMOCPPJE<KPAAJPHOOAN> MBPKNMCHNMK
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	PIBHMOCPPJE<MLPEKEOBFJJ> OCMICIHIAMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	PIBHMOCPPJE<DOPNIDFJPBN> KEKCLKHFOBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	PIBHMOCPPJE<GHOPLCAKCFO> IMKFEEFNLPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	PIBHMOCPPJE<DKCADIBAFHB> PKJLMNJAGIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	PIBHMOCPPJE<LGEDBJMHMNA> PMDEIGBHNEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	PIBHMOCPPJE<DPJDJGPLJGE> IPHHKHDIMHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class LFKKPHJDMDG
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly char[] OGNBMHOHDGN;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x77839E0", Offset = "0x7782DE0", VA = "0x1877839E0")]
	public static string[] CAEHGMEFOBJ(string? HIEKACDFIHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7783A80", Offset = "0x7782E80", VA = "0x187783A80")]
	public static string? MDJFJPDNNLE(string? CJJEOONCGLJ)
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
