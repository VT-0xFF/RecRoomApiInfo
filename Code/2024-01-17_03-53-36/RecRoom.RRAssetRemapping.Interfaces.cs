using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.DataStructures;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7B83D0", Offset = "0x7B71D0", VA = "0x1807B83D0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x663B3A0", Offset = "0x663A1A0", VA = "0x18663B3A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7B9560", Offset = "0x7B8360", VA = "0x1807B9560")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7B95A0", Offset = "0x7B83A0", VA = "0x1807B95A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface BPMIEHLMMAG
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string OKNECDBNGHE(AILBBDICCKJ PIMDNKIGEGF);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AILBBDICCKJ HONCKFFEJNK(string PIMDNKIGEGF);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct AILBBDICCKJ : IEquatable<AILBBDICCKJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly CDLEDLCKHAK MGFFPABBLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly ELGDMANDNGP NJACKMLCNHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid NEMGMFCDJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly RRColor? KAELOFLJPJN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool MDHPEECJBGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6639630", Offset = "0x6638430", VA = "0x186639630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool ENJDGLAFILM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6639AB0", Offset = "0x66388B0", VA = "0x186639AB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6639F80", Offset = "0x6638D80", VA = "0x186639F80")]
	public AILBBDICCKJ(AILBBDICCKJ KCKBPLLMMFD, [Optional] Guid PJNGBPPLKHP, [Optional] RRColor? PIPDACHFJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6639EF0", Offset = "0x6638CF0", VA = "0x186639EF0")]
	public AILBBDICCKJ(CDLEDLCKHAK NOFPJNADILC, ELGDMANDNGP KPOOGALLLOF, [Optional] Guid PJNGBPPLKHP, [Optional] RRColor? PIPDACHFJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x66397E0", Offset = "0x66385E0", VA = "0x1866397E0", Slot = "4")]
	public bool Equals(AILBBDICCKJ GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x66396F0", Offset = "0x66384F0", VA = "0x1866396F0", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x66398E0", Offset = "0x66386E0", VA = "0x1866398E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6639A40", Offset = "0x6638840", VA = "0x186639A40")]
	public static bool KFENMBPPCHH(AILBBDICCKJ PDAKJJLHJDL, AILBBDICCKJ KKCNPIHMPJA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x66399D0", Offset = "0x66387D0", VA = "0x1866399D0")]
	public static bool HABFPBKFOGJ(AILBBDICCKJ PDAKJJLHJDL, AILBBDICCKJ KKCNPIHMPJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6639AF0", Offset = "0x66388F0", VA = "0x186639AF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct CDLEDLCKHAK : IEquatable<CDLEDLCKHAK>, IComparable<CDLEDLCKHAK>, AICBJPBAAMI
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly CDLEDLCKHAK CABPEDJKFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Guid FILMEIPENDI;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1D13320", Offset = "0x1D12120", VA = "0x181D13320")]
	public CDLEDLCKHAK(Guid FILMEIPENDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7F8360", Offset = "0x7F7160", VA = "0x1807F8360", Slot = "6")]
	public Guid DACNCILMFOE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4021700", Offset = "0x4020500", VA = "0x184021700", Slot = "4")]
	public bool Equals(CDLEDLCKHAK GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4021600", Offset = "0x4020400", VA = "0x184021600", Slot = "5")]
	public int CompareTo(CDLEDLCKHAK GDMGBCDFBAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x663A010", Offset = "0x6638E10", VA = "0x18663A010", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4021680", Offset = "0x4020480", VA = "0x184021680", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4021700", Offset = "0x4020500", VA = "0x184021700")]
	public static bool KFENMBPPCHH(CDLEDLCKHAK PDAKJJLHJDL, CDLEDLCKHAK KKCNPIHMPJA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x663A0B0", Offset = "0x6638EB0", VA = "0x18663A0B0")]
	public static bool HABFPBKFOGJ(CDLEDLCKHAK PDAKJJLHJDL, CDLEDLCKHAK KKCNPIHMPJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x663A0E0", Offset = "0x6638EE0", VA = "0x18663A0E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct JHPCEKNMCKO : IEquatable<JHPCEKNMCKO>, IComparable<JHPCEKNMCKO>, AICBJPBAAMI
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly JHPCEKNMCKO CABPEDJKFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Guid FILMEIPENDI;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1D13320", Offset = "0x1D12120", VA = "0x181D13320")]
	public JHPCEKNMCKO(Guid FILMEIPENDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7F8360", Offset = "0x7F7160", VA = "0x1807F8360", Slot = "6")]
	public Guid DACNCILMFOE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4021700", Offset = "0x4020500", VA = "0x184021700", Slot = "4")]
	public bool Equals(JHPCEKNMCKO GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4021600", Offset = "0x4020400", VA = "0x184021600", Slot = "5")]
	public int CompareTo(JHPCEKNMCKO GDMGBCDFBAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x663B070", Offset = "0x6639E70", VA = "0x18663B070", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4021680", Offset = "0x4020480", VA = "0x184021680", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4021700", Offset = "0x4020500", VA = "0x184021700")]
	public static bool KFENMBPPCHH(JHPCEKNMCKO PDAKJJLHJDL, JHPCEKNMCKO KKCNPIHMPJA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x663A0B0", Offset = "0x6638EB0", VA = "0x18663A0B0")]
	public static bool HABFPBKFOGJ(JHPCEKNMCKO PDAKJJLHJDL, JHPCEKNMCKO KKCNPIHMPJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x663B110", Offset = "0x6639F10", VA = "0x18663B110", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct NDMIKLIMBNE : IEquatable<NDMIKLIMBNE>, IComparable<NDMIKLIMBNE>, AICBJPBAAMI
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly NDMIKLIMBNE CABPEDJKFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Guid FILMEIPENDI;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1D13320", Offset = "0x1D12120", VA = "0x181D13320")]
	public NDMIKLIMBNE(Guid FILMEIPENDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7F8360", Offset = "0x7F7160", VA = "0x1807F8360", Slot = "6")]
	public Guid DACNCILMFOE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4021700", Offset = "0x4020500", VA = "0x184021700", Slot = "4")]
	public bool Equals(NDMIKLIMBNE GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4021600", Offset = "0x4020400", VA = "0x184021600", Slot = "5")]
	public int CompareTo(NDMIKLIMBNE GDMGBCDFBAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x663B290", Offset = "0x663A090", VA = "0x18663B290", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4021680", Offset = "0x4020480", VA = "0x184021680", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4021700", Offset = "0x4020500", VA = "0x184021700")]
	public static bool KFENMBPPCHH(NDMIKLIMBNE PDAKJJLHJDL, NDMIKLIMBNE KKCNPIHMPJA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x663A0B0", Offset = "0x6638EB0", VA = "0x18663A0B0")]
	public static bool HABFPBKFOGJ(NDMIKLIMBNE PDAKJJLHJDL, NDMIKLIMBNE KKCNPIHMPJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x663B330", Offset = "0x663A130", VA = "0x18663B330", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct ELGDMANDNGP : IEquatable<ELGDMANDNGP>, IComparable<ELGDMANDNGP>, AICBJPBAAMI
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly ELGDMANDNGP CABPEDJKFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Guid FILMEIPENDI;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public GHIHPNACBEL GKLECIKOPEO
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xB5EDE0", Offset = "0xB5DBE0", VA = "0x180B5EDE0")]
		[CompilerGenerated]
		get
		{
			return default(GHIHPNACBEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public GHIHPNACBEL BMFLJPNIKKP
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xF00F80", Offset = "0xEFFD80", VA = "0x180F00F80")]
		[CompilerGenerated]
		get
		{
			return default(GHIHPNACBEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public GHIHPNACBEL AAMCEDIMGHA
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xE35130", Offset = "0xE33F30", VA = "0x180E35130")]
		[CompilerGenerated]
		get
		{
			return default(GHIHPNACBEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7F8360", Offset = "0x7F7160", VA = "0x1807F8360", Slot = "6")]
	public Guid DACNCILMFOE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x663A680", Offset = "0x6639480", VA = "0x18663A680")]
	public ELGDMANDNGP(Guid FILMEIPENDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x663A6C0", Offset = "0x66394C0", VA = "0x18663A6C0")]
	public ELGDMANDNGP(GHIHPNACBEL CHBEPGFNIGG, GHIHPNACBEL FLGGMPLCAFF, GHIHPNACBEL BOIDKDNKDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x663A4A0", Offset = "0x66392A0", VA = "0x18663A4A0")]
	private Guid IDDGEPOPKIK()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x609C010", Offset = "0x609AE10", VA = "0x18609C010", Slot = "4")]
	public bool Equals(ELGDMANDNGP GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x663A3B0", Offset = "0x66391B0", VA = "0x18663A3B0", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4021680", Offset = "0x4020480", VA = "0x184021680", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x663A5D0", Offset = "0x66393D0", VA = "0x18663A5D0")]
	public static bool KFENMBPPCHH(ELGDMANDNGP PDAKJJLHJDL, ELGDMANDNGP KKCNPIHMPJA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x663A460", Offset = "0x6639260", VA = "0x18663A460")]
	public static bool HABFPBKFOGJ(ELGDMANDNGP PDAKJJLHJDL, ELGDMANDNGP KKCNPIHMPJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x663A370", Offset = "0x6639170", VA = "0x18663A370", Slot = "5")]
	public int CompareTo(ELGDMANDNGP GDMGBCDFBAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x663A610", Offset = "0x6639410", VA = "0x18663A610", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct CLFKLGFEMEP : IEquatable<CLFKLGFEMEP>, IComparable<CLFKLGFEMEP>, AICBJPBAAMI
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly CLFKLGFEMEP CABPEDJKFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid FILMEIPENDI;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1D13320", Offset = "0x1D12120", VA = "0x181D13320")]
	public CLFKLGFEMEP(Guid FILMEIPENDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7F8360", Offset = "0x7F7160", VA = "0x1807F8360", Slot = "6")]
	public Guid DACNCILMFOE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4021700", Offset = "0x4020500", VA = "0x184021700", Slot = "4")]
	public bool Equals(CLFKLGFEMEP GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4021600", Offset = "0x4020400", VA = "0x184021600", Slot = "5")]
	public int CompareTo(CLFKLGFEMEP GDMGBCDFBAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x663A150", Offset = "0x6638F50", VA = "0x18663A150", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4021680", Offset = "0x4020480", VA = "0x184021680", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4021700", Offset = "0x4020500", VA = "0x184021700")]
	public static bool KFENMBPPCHH(CLFKLGFEMEP PDAKJJLHJDL, CLFKLGFEMEP KKCNPIHMPJA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x663A0B0", Offset = "0x6638EB0", VA = "0x18663A0B0")]
	public static bool HABFPBKFOGJ(CLFKLGFEMEP PDAKJJLHJDL, CLFKLGFEMEP KKCNPIHMPJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x663A1F0", Offset = "0x6638FF0", VA = "0x18663A1F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct PGCIIFJHDEB : IEquatable<PGCIIFJHDEB>, IComparable<PGCIIFJHDEB>, AICBJPBAAMI
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly PGCIIFJHDEB CABPEDJKFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid FILMEIPENDI;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1D13320", Offset = "0x1D12120", VA = "0x181D13320")]
	public PGCIIFJHDEB(Guid FILMEIPENDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7F8360", Offset = "0x7F7160", VA = "0x1807F8360", Slot = "6")]
	public Guid DACNCILMFOE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4021700", Offset = "0x4020500", VA = "0x184021700", Slot = "4")]
	public bool Equals(PGCIIFJHDEB GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4021600", Offset = "0x4020400", VA = "0x184021600", Slot = "5")]
	public int CompareTo(PGCIIFJHDEB GDMGBCDFBAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x663B510", Offset = "0x663A310", VA = "0x18663B510", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4021680", Offset = "0x4020480", VA = "0x184021680", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4021700", Offset = "0x4020500", VA = "0x184021700")]
	public static bool KFENMBPPCHH(PGCIIFJHDEB PDAKJJLHJDL, PGCIIFJHDEB KKCNPIHMPJA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x663A0B0", Offset = "0x6638EB0", VA = "0x18663A0B0")]
	public static bool HABFPBKFOGJ(PGCIIFJHDEB PDAKJJLHJDL, PGCIIFJHDEB KKCNPIHMPJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x663B5B0", Offset = "0x663A3B0", VA = "0x18663B5B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct DKMAOPECEFA : IEquatable<DKMAOPECEFA>, IComparable<DKMAOPECEFA>, AICBJPBAAMI
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly DKMAOPECEFA CABPEDJKFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid FILMEIPENDI;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1D13320", Offset = "0x1D12120", VA = "0x181D13320")]
	public DKMAOPECEFA(Guid FILMEIPENDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7F8360", Offset = "0x7F7160", VA = "0x1807F8360", Slot = "6")]
	public Guid DACNCILMFOE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4021700", Offset = "0x4020500", VA = "0x184021700", Slot = "4")]
	public bool Equals(DKMAOPECEFA GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4021600", Offset = "0x4020400", VA = "0x184021600", Slot = "5")]
	public int CompareTo(DKMAOPECEFA GDMGBCDFBAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x663A260", Offset = "0x6639060", VA = "0x18663A260", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4021680", Offset = "0x4020480", VA = "0x184021680", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4021700", Offset = "0x4020500", VA = "0x184021700")]
	public static bool KFENMBPPCHH(DKMAOPECEFA PDAKJJLHJDL, DKMAOPECEFA KKCNPIHMPJA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x663A0B0", Offset = "0x6638EB0", VA = "0x18663A0B0")]
	public static bool HABFPBKFOGJ(DKMAOPECEFA PDAKJJLHJDL, DKMAOPECEFA KKCNPIHMPJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x663A300", Offset = "0x6639100", VA = "0x18663A300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct KKEKFHMFPPO : IEquatable<KKEKFHMFPPO>, IComparable<KKEKFHMFPPO>, AICBJPBAAMI
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly KKEKFHMFPPO CABPEDJKFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly Guid FILMEIPENDI;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1D13320", Offset = "0x1D12120", VA = "0x181D13320")]
	public KKEKFHMFPPO(Guid FILMEIPENDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7F8360", Offset = "0x7F7160", VA = "0x1807F8360", Slot = "6")]
	public Guid DACNCILMFOE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4021700", Offset = "0x4020500", VA = "0x184021700", Slot = "4")]
	public bool Equals(KKEKFHMFPPO GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4021600", Offset = "0x4020400", VA = "0x184021600", Slot = "5")]
	public int CompareTo(KKEKFHMFPPO GDMGBCDFBAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x663B180", Offset = "0x6639F80", VA = "0x18663B180", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4021680", Offset = "0x4020480", VA = "0x184021680", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4021700", Offset = "0x4020500", VA = "0x184021700")]
	public static bool KFENMBPPCHH(KKEKFHMFPPO PDAKJJLHJDL, KKEKFHMFPPO KKCNPIHMPJA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x663A0B0", Offset = "0x6638EB0", VA = "0x18663A0B0")]
	public static bool HABFPBKFOGJ(KKEKFHMFPPO PDAKJJLHJDL, KKEKFHMFPPO KKCNPIHMPJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x663B220", Offset = "0x663A020", VA = "0x18663B220", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct JCBOKJDHBGM : IEquatable<JCBOKJDHBGM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly string?[]? OMMOHDIGJML;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool IJDAKCFEOFC
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x663ACC0", Offset = "0x6639AC0", VA = "0x18663ACC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int GNMACAPKDPL
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x3A2BA40", Offset = "0x3A2A840", VA = "0x183A2BA40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x663AEB0", Offset = "0x6639CB0", VA = "0x18663AEB0")]
	public JCBOKJDHBGM(string? APLDEKEKOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x663AFF0", Offset = "0x6639DF0", VA = "0x18663AFF0")]
	public JCBOKJDHBGM(string?[] EOALIFGOIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x663A930", Offset = "0x6639730", VA = "0x18663A930")]
	private static string?[]? AJJDJDFINAP(string?[]? EOALIFGOIIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x663ADC0", Offset = "0x6639BC0", VA = "0x18663ADC0")]
	public string NJLIBKBBGOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x663ABF0", Offset = "0x66399F0", VA = "0x18663ABF0", Slot = "4")]
	public bool Equals(JCBOKJDHBGM GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x663AB60", Offset = "0x6639960", VA = "0x18663AB60", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x663ACE0", Offset = "0x6639AE0", VA = "0x18663ACE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x663AE20", Offset = "0x6639C20", VA = "0x18663AE20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct GHIHPNACBEL : IEquatable<GHIHPNACBEL>, IComparable<GHIHPNACBEL>, AICBJPBAAMI
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly GHIHPNACBEL CABPEDJKFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Guid FILMEIPENDI;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1D13320", Offset = "0x1D12120", VA = "0x181D13320")]
	public GHIHPNACBEL(Guid FILMEIPENDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7F8360", Offset = "0x7F7160", VA = "0x1807F8360", Slot = "6")]
	public Guid DACNCILMFOE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4021700", Offset = "0x4020500", VA = "0x184021700", Slot = "4")]
	public bool Equals(GHIHPNACBEL GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4021600", Offset = "0x4020400", VA = "0x184021600", Slot = "5")]
	public int CompareTo(GHIHPNACBEL GDMGBCDFBAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x663A820", Offset = "0x6639620", VA = "0x18663A820", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4021680", Offset = "0x4020480", VA = "0x184021680", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4021700", Offset = "0x4020500", VA = "0x184021700")]
	public static bool KFENMBPPCHH(GHIHPNACBEL PDAKJJLHJDL, GHIHPNACBEL KKCNPIHMPJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x663A8C0", Offset = "0x66396C0", VA = "0x18663A8C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct FHIFFOKLCNL : IEquatable<FHIFFOKLCNL>, IComparable<FHIFFOKLCNL>, AICBJPBAAMI
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly FHIFFOKLCNL CABPEDJKFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Guid FILMEIPENDI;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1D13320", Offset = "0x1D12120", VA = "0x181D13320")]
	public FHIFFOKLCNL(Guid FILMEIPENDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7F8360", Offset = "0x7F7160", VA = "0x1807F8360", Slot = "6")]
	public Guid DACNCILMFOE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4021700", Offset = "0x4020500", VA = "0x184021700", Slot = "4")]
	public bool Equals(FHIFFOKLCNL GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4021600", Offset = "0x4020400", VA = "0x184021600", Slot = "5")]
	public int CompareTo(FHIFFOKLCNL GDMGBCDFBAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x663A710", Offset = "0x6639510", VA = "0x18663A710", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4021680", Offset = "0x4020480", VA = "0x184021680", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x663A0B0", Offset = "0x6638EB0", VA = "0x18663A0B0")]
	public static bool HABFPBKFOGJ(FHIFFOKLCNL PDAKJJLHJDL, FHIFFOKLCNL KKCNPIHMPJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x663A7B0", Offset = "0x66395B0", VA = "0x18663A7B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HCMHGIJPDCF<TModern> : JJLDANJCAEO<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string CBGOCCBFLJF(TModern FDJJJGJPNBK);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface AICBJPBAAMI
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid DACNCILMFOE();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface JJLDANJCAEO<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern ACJPGEJADOI(string FDJJJGJPNBK);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface PDEPCHOOMEN
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	HCMHGIJPDCF<CDLEDLCKHAK> PPHAKFBILIF
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	HCMHGIJPDCF<CLFKLGFEMEP> HOOBKMPDLDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	HCMHGIJPDCF<KKEKFHMFPPO> BIEDNOPOPPI
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	HCMHGIJPDCF<ELGDMANDNGP> PCOFIBAPKHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	HCMHGIJPDCF<NDMIKLIMBNE> PFPAHLONELG
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	HCMHGIJPDCF<DKMAOPECEFA> JLFHOOLOHCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	HCMHGIJPDCF<JHPCEKNMCKO> HHCPKCOCBHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	HCMHGIJPDCF<PGCIIFJHDEB> NHGELFNHGBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class OGMDDMDOLII
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x663B420", Offset = "0x663A220", VA = "0x18663B420")]
	public static string[] JBBGFACGBPC(string? APLDEKEKOGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x663B4E0", Offset = "0x663A2E0", VA = "0x18663B4E0")]
	public static string? OADJDGCDLKO(string? NOFPJNADILC)
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
