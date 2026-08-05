using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9D5490", Offset = "0x9D4890", VA = "0x1809D5490")]
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

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9D54D0", Offset = "0x9D48D0", VA = "0x1809D54D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class JOOHMCJJIHO : FICJNCNGGAA<bool>
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7C3FA70", Offset = "0x7C3EE70", VA = "0x187C3FA70", Slot = "9")]
	public override string PELCBGJOJPC(bool PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7C3FAC0", Offset = "0x7C3EEC0", VA = "0x187C3FAC0", Slot = "10")]
	protected override bool PLIIBEGPKOB(string PJCOHHCODGF, [Out] bool FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7C3FB20", Offset = "0x7C3EF20", VA = "0x187C3FB20")]
	public JOOHMCJJIHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class PNIMEHIADOH : FICJNCNGGAA<DateTime>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7C40A30", Offset = "0x7C3FE30", VA = "0x187C40A30", Slot = "9")]
	public override string PELCBGJOJPC(DateTime PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7C40AC0", Offset = "0x7C3FEC0", VA = "0x187C40AC0", Slot = "10")]
	protected override bool PLIIBEGPKOB(string PJCOHHCODGF, [Out] DateTime FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7C40B60", Offset = "0x7C3FF60", VA = "0x187C40B60")]
	public PNIMEHIADOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class ODEFEEGAFFC<TEnum> : FICJNCNGGAA<TEnum> where TEnum : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly Type JBNOGMDBBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool ODCHNPEEBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly TEnum[] JGMAGBDHLIF;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5211930", Offset = "0x5210D30", VA = "0x185211930")]
	[Preserve]
	public ODEFEEGAFFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5211530", Offset = "0x5210930", VA = "0x185211530", Slot = "9")]
	public override string PELCBGJOJPC(TEnum PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5211770", Offset = "0x5210B70", VA = "0x185211770", Slot = "10")]
	protected override bool PLIIBEGPKOB(string PJCOHHCODGF, [Out] TEnum FFOEEMKIKJO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class ELCFGIJNCLL<TEnum> : FICJNCNGGAA<TEnum> where TEnum : Enum
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Type JBNOGMDBBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly DEJPCDPMDJB ILBNHIFJKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly bool ODCHNPEEBDB;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x42E4970", Offset = "0x42E3D70", VA = "0x1842E4970")]
	[Preserve]
	public ELCFGIJNCLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x42E42B0", Offset = "0x42E36B0", VA = "0x1842E42B0", Slot = "9")]
	public override string PELCBGJOJPC(TEnum PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x42E4450", Offset = "0x42E3850", VA = "0x1842E4450", Slot = "10")]
	protected override bool PLIIBEGPKOB(string PJCOHHCODGF, [Out] TEnum FFOEEMKIKJO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class NBJMOFDHDFH
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly Dictionary<Type, DEJPCDPMDJB> MEIFJIHINCC;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7C401C0", Offset = "0x7C3F5C0", VA = "0x187C401C0")]
	public static DEJPCDPMDJB BFKKCFKILDH(Type KEIBHFEDBAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class HNBPMALHGLD<T> : FICJNCNGGAA<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3D87580", Offset = "0x3D86980", VA = "0x183D87580", Slot = "9")]
	public override string PELCBGJOJPC(T PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x49256F0", Offset = "0x4924AF0", VA = "0x1849256F0", Slot = "10")]
	protected override bool PLIIBEGPKOB(string PJCOHHCODGF, [Out] T FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x42806C0", Offset = "0x427FAC0", VA = "0x1842806C0")]
	public HNBPMALHGLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class PCFGOKEGOCD<TCollection, T> : FICJNCNGGAA<TCollection> where TCollection : IEnumerable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly HIHPOAELMHI<T> OGJCCPPEFAO;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x52FA980", Offset = "0x52F9D80", VA = "0x1852FA980")]
	protected PCFGOKEGOCD(HIHPOAELMHI<T> OGJCCPPEFAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x52F7690", Offset = "0x52F6A90", VA = "0x1852F7690", Slot = "9")]
	public override string PELCBGJOJPC(TCollection PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x52F94C0", Offset = "0x52F88C0", VA = "0x1852F94C0", Slot = "10")]
	protected override bool PLIIBEGPKOB(string PJCOHHCODGF, [Out] TCollection FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract TCollection LLEJPLOGIMJ(IEnumerable<T> OFLDFOLPLBP);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x52FA950", Offset = "0x52F9D50", VA = "0x1852FA950", Slot = "12")]
	internal virtual IEnumerable<string> PPHHOCJDELK(string PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x52F6B50", Offset = "0x52F5F50", VA = "0x1852F6B50")]
	[CompilerGenerated]
	private string GHLNJKALDHC(T CHAOGBKCKEH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class EFIJLMBCFOO<T> : PCFGOKEGOCD<T[], T>
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x42DF0A0", Offset = "0x42DE4A0", VA = "0x1842DF0A0")]
	[Preserve]
	public EFIJLMBCFOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x42DD2E0", Offset = "0x42DC6E0", VA = "0x1842DD2E0")]
	[Preserve]
	public EFIJLMBCFOO(HIHPOAELMHI<T> OGJCCPPEFAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x42DF020", Offset = "0x42DE420", VA = "0x1842DF020", Slot = "11")]
	protected override T[] LLEJPLOGIMJ(IEnumerable<T> OFLDFOLPLBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class LMAOKLOAIGG<T> : PCFGOKEGOCD<List<T>, T>
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x42DF0A0", Offset = "0x42DE4A0", VA = "0x1842DF0A0")]
	[Preserve]
	public LMAOKLOAIGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x42DD2E0", Offset = "0x42DC6E0", VA = "0x1842DD2E0")]
	[Preserve]
	public LMAOKLOAIGG([Optional] HIHPOAELMHI<T> OGJCCPPEFAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4E70FB0", Offset = "0x4E703B0", VA = "0x184E70FB0", Slot = "11")]
	protected override List<T> LLEJPLOGIMJ(IEnumerable<T> OFLDFOLPLBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class PADGOJMNJIK<T> : FICJNCNGGAA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly JsonSerializerSettings? KADJIEFHOGM;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x480A700", Offset = "0x4809B00", VA = "0x18480A700")]
	public PADGOJMNJIK(JsonSerializerSettings? BAOGIOELNIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x52ED860", Offset = "0x52ECC60", VA = "0x1852ED860", Slot = "9")]
	public override string PELCBGJOJPC(T PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x52ED8C0", Offset = "0x52ECCC0", VA = "0x1852ED8C0", Slot = "10")]
	protected override bool PLIIBEGPKOB([NotNull] string PJCOHHCODGF, [Out] T FFOEEMKIKJO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class HDAIIAJFJAM : FICJNCNGGAA<byte>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F6E0", Offset = "0x7C3EAE0", VA = "0x187C3F6E0", Slot = "9")]
	public override string PELCBGJOJPC(byte PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F740", Offset = "0x7C3EB40", VA = "0x187C3F740", Slot = "10")]
	protected override bool PLIIBEGPKOB(string PJCOHHCODGF, [Out] byte FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F7D0", Offset = "0x7C3EBD0", VA = "0x187C3F7D0")]
	public HDAIIAJFJAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class LHIDOOOMMFM : FICJNCNGGAA<short>
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7C3FD00", Offset = "0x7C3F100", VA = "0x187C3FD00", Slot = "9")]
	public override string PELCBGJOJPC(short PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7C3FD60", Offset = "0x7C3F160", VA = "0x187C3FD60", Slot = "10")]
	protected override bool PLIIBEGPKOB(string PJCOHHCODGF, [Out] short FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7C3FE00", Offset = "0x7C3F200", VA = "0x187C3FE00")]
	public LHIDOOOMMFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal class PALMLDMHJBH : FICJNCNGGAA<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7C408F0", Offset = "0x7C3FCF0", VA = "0x187C408F0", Slot = "9")]
	public override string PELCBGJOJPC(ushort PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7C40950", Offset = "0x7C3FD50", VA = "0x187C40950", Slot = "10")]
	protected override bool PLIIBEGPKOB(string PJCOHHCODGF, [Out] ushort FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7C409F0", Offset = "0x7C3FDF0", VA = "0x187C409F0")]
	public PALMLDMHJBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class IIBOGJEBPAN : FICJNCNGGAA<int>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F940", Offset = "0x7C3ED40", VA = "0x187C3F940", Slot = "9")]
	public override string PELCBGJOJPC(int PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F9A0", Offset = "0x7C3EDA0", VA = "0x187C3F9A0", Slot = "10")]
	protected override bool PLIIBEGPKOB(string PJCOHHCODGF, [Out] int FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7C3FA30", Offset = "0x7C3EE30", VA = "0x187C3FA30")]
	public IIBOGJEBPAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class HKGCOIBOJMI : FICJNCNGGAA<uint>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F810", Offset = "0x7C3EC10", VA = "0x187C3F810", Slot = "9")]
	public override string PELCBGJOJPC(uint PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F870", Offset = "0x7C3EC70", VA = "0x187C3F870", Slot = "10")]
	protected override bool PLIIBEGPKOB(string PJCOHHCODGF, [Out] uint FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F900", Offset = "0x7C3ED00", VA = "0x187C3F900")]
	public HKGCOIBOJMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class KEAHKBKAHBN : FICJNCNGGAA<long>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7C3FBC0", Offset = "0x7C3EFC0", VA = "0x187C3FBC0", Slot = "9")]
	public override string PELCBGJOJPC(long PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7C3FC20", Offset = "0x7C3F020", VA = "0x187C3FC20", Slot = "10")]
	protected override bool PLIIBEGPKOB(string PJCOHHCODGF, [Out] long FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7C3FCC0", Offset = "0x7C3F0C0", VA = "0x187C3FCC0")]
	public KEAHKBKAHBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class GHKIDJFOOOE : FICJNCNGGAA<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F5A0", Offset = "0x7C3E9A0", VA = "0x187C3F5A0", Slot = "9")]
	public override string PELCBGJOJPC(ulong PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F600", Offset = "0x7C3EA00", VA = "0x187C3F600", Slot = "10")]
	protected override bool PLIIBEGPKOB(string PJCOHHCODGF, [Out] ulong FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F6A0", Offset = "0x7C3EAA0", VA = "0x187C3F6A0")]
	public GHKIDJFOOOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class EMPBENIDKAE : FICJNCNGGAA<float>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F380", Offset = "0x7C3E780", VA = "0x187C3F380", Slot = "9")]
	public override string PELCBGJOJPC(float PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F3F0", Offset = "0x7C3E7F0", VA = "0x187C3F3F0", Slot = "10")]
	protected override bool PLIIBEGPKOB(string PJCOHHCODGF, [Out] float FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F480", Offset = "0x7C3E880", VA = "0x187C3F480")]
	public EMPBENIDKAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface DEJPCDPMDJB
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string LNJBNAJFOEP(object PJCOHHCODGF);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FKMCBBFPPGM([CanBeNull] string PJCOHHCODGF, [Out] object FFOEEMKIKJO);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface HIHPOAELMHI<T> : DEJPCDPMDJB
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string PELCBGJOJPC(T PJCOHHCODGF);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JALKMOIONFF([CanBeNull] string PJCOHHCODGF, [Out] T FFOEEMKIKJO);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T APEKMGEEIOO([CanBeNull] string PJCOHHCODGF, [Optional] T PFCPDJEHNAP);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class FICJNCNGGAA<T> : HIHPOAELMHI<T>, DEJPCDPMDJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Type JPCCCFFNIPJ;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x475C5B0", Offset = "0x475B9B0", VA = "0x18475C5B0")]
	protected FICJNCNGGAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x475B0F0", Offset = "0x475A4F0", VA = "0x18475B0F0")]
	private T ENCIMGKLAHJ(object BLFGIKOAKOL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract string PELCBGJOJPC(T PJCOHHCODGF);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x475BDD0", Offset = "0x475B1D0", VA = "0x18475BDD0", Slot = "7")]
	public string LNJBNAJFOEP(object PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x475BB70", Offset = "0x475AF70", VA = "0x18475BB70", Slot = "5")]
	public bool JALKMOIONFF(string PJCOHHCODGF, [Out] T FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool PLIIBEGPKOB([NotNull] string PJCOHHCODGF, [Out] T FFOEEMKIKJO);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x475B690", Offset = "0x475AA90", VA = "0x18475B690", Slot = "8")]
	private bool IAJBMFOKKGD(string PJCOHHCODGF, [Out] object FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x475AE10", Offset = "0x475A210", VA = "0x18475AE10", Slot = "6")]
	public T APEKMGEEIOO(string PJCOHHCODGF, [Optional] T PFCPDJEHNAP)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class FGALHMKJFOJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static HIHPOAELMHI<T> AMGMCPILGIN
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x46FBBC0", Offset = "0x46FAFC0", VA = "0x1846FBBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3B99220", Offset = "0x3B98620", VA = "0x183B99220")]
	public static HIHPOAELMHI<TSerialized> FENAFFODHOF<TSerialized>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x47364B0", Offset = "0x47358B0", VA = "0x1847364B0")]
	public static DEJPCDPMDJB FENAFFODHOF(Type HGOPLJOKKMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x472E9F0", Offset = "0x472DDF0", VA = "0x18472E9F0")]
	private static DEJPCDPMDJB DLNCMLOBIID(Type NOMLDKJCODG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4742170", Offset = "0x4741570", VA = "0x184742170")]
	private static DEJPCDPMDJB HJHPLAIHEAM(Type NOMLDKJCODG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class PELMLFKFKOL<TCollection> : PCFGOKEGOCD<TCollection, string> where TCollection : IEnumerable<string>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class FNDCKMEPNHC : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private string <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private string input;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public string <>3__input;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public PELMLFKFKOL<TCollection> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private LAMDJDMNGDN<StringBuilder> <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private StringBuilder <partBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private bool <insideQuotes>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int <i>5__5;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		string IEnumerator<string>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xDEB050", Offset = "0xDEA450", VA = "0x180DEB050")]
		[DebuggerHidden]
		public FNDCKMEPNHC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x476D5A0", Offset = "0x476C9A0", VA = "0x18476D5A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4780B10", Offset = "0x477FF10", VA = "0x184780B10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4780F80", Offset = "0x4780380", VA = "0x184780F80")]
		private void OMCGPHJKBHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x47810F0", Offset = "0x47804F0", VA = "0x1847810F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x4780FD0", Offset = "0x47803D0", VA = "0x184780FD0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x47810B0", Offset = "0x47804B0", VA = "0x1847810B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool GBENKBHAPNG;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x530AD00", Offset = "0x530A100", VA = "0x18530AD00")]
	protected PELMLFKFKOL(bool GBENKBHAPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x530AA00", Offset = "0x5309E00", VA = "0x18530AA00", Slot = "9")]
	public override string PELCBGJOJPC(TCollection PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x530AC40", Offset = "0x530A040", VA = "0x18530AC40", Slot = "12")]
	[IteratorStateMachine(typeof(PELMLFKFKOL<>.FNDCKMEPNHC))]
	internal override IEnumerable<string> PPHHOCJDELK(string PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x530A980", Offset = "0x5309D80", VA = "0x18530A980")]
	[CompilerGenerated]
	internal static string DNAMAGMMONG(StringBuilder BNJHIIEDKCI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class FCIOFBGPBAB : PELMLFKFKOL<List<string>>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F550", Offset = "0x7C3E950", VA = "0x187C3F550")]
	[Preserve]
	public FCIOFBGPBAB(bool GBENKBHAPNG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F4C0", Offset = "0x7C3E8C0", VA = "0x187C3F4C0", Slot = "11")]
	protected override List<string> LLEJPLOGIMJ(IEnumerable<string> OFLDFOLPLBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class MCOFFOGEFKB : PELMLFKFKOL<string[]>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7C40170", Offset = "0x7C3F570", VA = "0x187C40170")]
	[Preserve]
	public MCOFFOGEFKB(bool GBENKBHAPNG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7C40110", Offset = "0x7C3F510", VA = "0x187C40110", Slot = "11")]
	protected override string[] LLEJPLOGIMJ(IEnumerable<string> OFLDFOLPLBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class JOPHCMHONHK : FICJNCNGGAA<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xD5ECF0", Offset = "0xD5E0F0", VA = "0x180D5ECF0", Slot = "9")]
	public override string PELCBGJOJPC(string PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7C3FB60", Offset = "0x7C3EF60", VA = "0x187C3FB60", Slot = "10")]
	protected override bool PLIIBEGPKOB(string PJCOHHCODGF, [Out] string FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7C3FB80", Offset = "0x7C3EF80", VA = "0x187C3FB80")]
	public JOPHCMHONHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class LJPKDNGJHCB : FICJNCNGGAA<TimeSpan>
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7C3FE40", Offset = "0x7C3F240", VA = "0x187C3FE40", Slot = "9")]
	public override string PELCBGJOJPC(TimeSpan PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7C3FF60", Offset = "0x7C3F360", VA = "0x187C3FF60", Slot = "10")]
	protected override bool PLIIBEGPKOB(string PJCOHHCODGF, [Out] TimeSpan FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7C400D0", Offset = "0x7C3F4D0", VA = "0x187C400D0")]
	public LJPKDNGJHCB()
	{
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
