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
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BF4A0", Offset = "0x9BE8A0", VA = "0x1809BF4A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BF4E0", Offset = "0x9BE8E0", VA = "0x1809BF4E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class JOOHMCJJIHO : FICJNCNGGAA<bool>
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB5D0", Offset = "0x7BEA9D0", VA = "0x187BEB5D0", Slot = "9")]
	public override string PELCBGJOJPC(bool PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB620", Offset = "0x7BEAA20", VA = "0x187BEB620", Slot = "10")]
	protected override bool PLIIBEGPKOB(string PJCOHHCODGF, [Out] bool FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB680", Offset = "0x7BEAA80", VA = "0x187BEB680")]
	public JOOHMCJJIHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class PNIMEHIADOH : FICJNCNGGAA<DateTime>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7BEC5B0", Offset = "0x7BEB9B0", VA = "0x187BEC5B0", Slot = "9")]
	public override string PELCBGJOJPC(DateTime PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7BEC640", Offset = "0x7BEBA40", VA = "0x187BEC640", Slot = "10")]
	protected override bool PLIIBEGPKOB(string PJCOHHCODGF, [Out] DateTime FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7BEC6E0", Offset = "0x7BEBAE0", VA = "0x187BEC6E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x51E0000", Offset = "0x51DF400", VA = "0x1851E0000")]
	[Preserve]
	public ODEFEEGAFFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x51DFBF0", Offset = "0x51DEFF0", VA = "0x1851DFBF0", Slot = "9")]
	public override string PELCBGJOJPC(TEnum PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x51DFE30", Offset = "0x51DF230", VA = "0x1851DFE30", Slot = "10")]
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
	[Cpp2IlInjected.Address(RVA = "0x42C5D40", Offset = "0x42C5140", VA = "0x1842C5D40")]
	[Preserve]
	public ELCFGIJNCLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x42C5680", Offset = "0x42C4A80", VA = "0x1842C5680", Slot = "9")]
	public override string PELCBGJOJPC(TEnum PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x42C5820", Offset = "0x42C4C20", VA = "0x1842C5820", Slot = "10")]
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
	[Cpp2IlInjected.Address(RVA = "0x7BEBD20", Offset = "0x7BEB120", VA = "0x187BEBD20")]
	public static DEJPCDPMDJB BFKKCFKILDH(Type KEIBHFEDBAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class HNBPMALHGLD<T> : FICJNCNGGAA<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3D6C7A0", Offset = "0x3D6BBA0", VA = "0x183D6C7A0", Slot = "9")]
	public override string PELCBGJOJPC(T PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x490CFD0", Offset = "0x490C3D0", VA = "0x18490CFD0", Slot = "10")]
	protected override bool PLIIBEGPKOB(string PJCOHHCODGF, [Out] T FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x42619D0", Offset = "0x4260DD0", VA = "0x1842619D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x52C70A0", Offset = "0x52C64A0", VA = "0x1852C70A0")]
	protected PCFGOKEGOCD(HIHPOAELMHI<T> OGJCCPPEFAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x52C3D60", Offset = "0x52C3160", VA = "0x1852C3D60", Slot = "9")]
	public override string PELCBGJOJPC(TCollection PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x52C5BD0", Offset = "0x52C4FD0", VA = "0x1852C5BD0", Slot = "10")]
	protected override bool PLIIBEGPKOB(string PJCOHHCODGF, [Out] TCollection FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract TCollection LLEJPLOGIMJ(IEnumerable<T> OFLDFOLPLBP);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x52C7070", Offset = "0x52C6470", VA = "0x1852C7070", Slot = "12")]
	internal virtual IEnumerable<string> PPHHOCJDELK(string PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x52C3210", Offset = "0x52C2610", VA = "0x1852C3210")]
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
	[Cpp2IlInjected.Address(RVA = "0x42C0530", Offset = "0x42BF930", VA = "0x1842C0530")]
	[Preserve]
	public EFIJLMBCFOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x42BE770", Offset = "0x42BDB70", VA = "0x1842BE770")]
	[Preserve]
	public EFIJLMBCFOO(HIHPOAELMHI<T> OGJCCPPEFAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x42C04B0", Offset = "0x42BF8B0", VA = "0x1842C04B0", Slot = "11")]
	protected override T[] LLEJPLOGIMJ(IEnumerable<T> OFLDFOLPLBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class LMAOKLOAIGG<T> : PCFGOKEGOCD<List<T>, T>
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x42C0530", Offset = "0x42BF930", VA = "0x1842C0530")]
	[Preserve]
	public LMAOKLOAIGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x42BE770", Offset = "0x42BDB70", VA = "0x1842BE770")]
	[Preserve]
	public LMAOKLOAIGG([Optional] HIHPOAELMHI<T> OGJCCPPEFAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4E4A150", Offset = "0x4E49550", VA = "0x184E4A150", Slot = "11")]
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
	[Cpp2IlInjected.Address(RVA = "0x47F1650", Offset = "0x47F0A50", VA = "0x1847F1650")]
	public PADGOJMNJIK(JsonSerializerSettings? BAOGIOELNIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x52B9F10", Offset = "0x52B9310", VA = "0x1852B9F10", Slot = "9")]
	public override string PELCBGJOJPC(T PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x52B9F70", Offset = "0x52B9370", VA = "0x1852B9F70", Slot = "10")]
	protected override bool PLIIBEGPKOB([NotNull] string PJCOHHCODGF, [Out] T FFOEEMKIKJO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class HDAIIAJFJAM : FICJNCNGGAA<byte>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB240", Offset = "0x7BEA640", VA = "0x187BEB240", Slot = "9")]
	public override string PELCBGJOJPC(byte PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB2A0", Offset = "0x7BEA6A0", VA = "0x187BEB2A0", Slot = "10")]
	protected override bool PLIIBEGPKOB(string PJCOHHCODGF, [Out] byte FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB330", Offset = "0x7BEA730", VA = "0x187BEB330")]
	public HDAIIAJFJAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class LHIDOOOMMFM : FICJNCNGGAA<short>
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB860", Offset = "0x7BEAC60", VA = "0x187BEB860", Slot = "9")]
	public override string PELCBGJOJPC(short PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB8C0", Offset = "0x7BEACC0", VA = "0x187BEB8C0", Slot = "10")]
	protected override bool PLIIBEGPKOB(string PJCOHHCODGF, [Out] short FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB960", Offset = "0x7BEAD60", VA = "0x187BEB960")]
	public LHIDOOOMMFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal class PALMLDMHJBH : FICJNCNGGAA<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7BEC470", Offset = "0x7BEB870", VA = "0x187BEC470", Slot = "9")]
	public override string PELCBGJOJPC(ushort PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7BEC4D0", Offset = "0x7BEB8D0", VA = "0x187BEC4D0", Slot = "10")]
	protected override bool PLIIBEGPKOB(string PJCOHHCODGF, [Out] ushort FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7BEC570", Offset = "0x7BEB970", VA = "0x187BEC570")]
	public PALMLDMHJBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class IIBOGJEBPAN : FICJNCNGGAA<int>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB4A0", Offset = "0x7BEA8A0", VA = "0x187BEB4A0", Slot = "9")]
	public override string PELCBGJOJPC(int PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB500", Offset = "0x7BEA900", VA = "0x187BEB500", Slot = "10")]
	protected override bool PLIIBEGPKOB(string PJCOHHCODGF, [Out] int FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB590", Offset = "0x7BEA990", VA = "0x187BEB590")]
	public IIBOGJEBPAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class HKGCOIBOJMI : FICJNCNGGAA<uint>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB370", Offset = "0x7BEA770", VA = "0x187BEB370", Slot = "9")]
	public override string PELCBGJOJPC(uint PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB3D0", Offset = "0x7BEA7D0", VA = "0x187BEB3D0", Slot = "10")]
	protected override bool PLIIBEGPKOB(string PJCOHHCODGF, [Out] uint FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB460", Offset = "0x7BEA860", VA = "0x187BEB460")]
	public HKGCOIBOJMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class KEAHKBKAHBN : FICJNCNGGAA<long>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB720", Offset = "0x7BEAB20", VA = "0x187BEB720", Slot = "9")]
	public override string PELCBGJOJPC(long PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB780", Offset = "0x7BEAB80", VA = "0x187BEB780", Slot = "10")]
	protected override bool PLIIBEGPKOB(string PJCOHHCODGF, [Out] long FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB820", Offset = "0x7BEAC20", VA = "0x187BEB820")]
	public KEAHKBKAHBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class GHKIDJFOOOE : FICJNCNGGAA<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB100", Offset = "0x7BEA500", VA = "0x187BEB100", Slot = "9")]
	public override string PELCBGJOJPC(ulong PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB160", Offset = "0x7BEA560", VA = "0x187BEB160", Slot = "10")]
	protected override bool PLIIBEGPKOB(string PJCOHHCODGF, [Out] ulong FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB200", Offset = "0x7BEA600", VA = "0x187BEB200")]
	public GHKIDJFOOOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class EMPBENIDKAE : FICJNCNGGAA<float>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7BEAEE0", Offset = "0x7BEA2E0", VA = "0x187BEAEE0", Slot = "9")]
	public override string PELCBGJOJPC(float PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7BEAF50", Offset = "0x7BEA350", VA = "0x187BEAF50", Slot = "10")]
	protected override bool PLIIBEGPKOB(string PJCOHHCODGF, [Out] float FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7BEAFE0", Offset = "0x7BEA3E0", VA = "0x187BEAFE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4743BF0", Offset = "0x4742FF0", VA = "0x184743BF0")]
	protected FICJNCNGGAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4742730", Offset = "0x4741B30", VA = "0x184742730")]
	private T ENCIMGKLAHJ(object BLFGIKOAKOL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract string PELCBGJOJPC(T PJCOHHCODGF);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4743410", Offset = "0x4742810", VA = "0x184743410", Slot = "7")]
	public string LNJBNAJFOEP(object PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x47431B0", Offset = "0x47425B0", VA = "0x1847431B0", Slot = "5")]
	public bool JALKMOIONFF(string PJCOHHCODGF, [Out] T FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool PLIIBEGPKOB([NotNull] string PJCOHHCODGF, [Out] T FFOEEMKIKJO);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4742CD0", Offset = "0x47420D0", VA = "0x184742CD0", Slot = "8")]
	private bool IAJBMFOKKGD(string PJCOHHCODGF, [Out] object FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4742450", Offset = "0x4741850", VA = "0x184742450", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x46E2780", Offset = "0x46E1B80", VA = "0x1846E2780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3A61930", Offset = "0x3A60D30", VA = "0x183A61930")]
	public static HIHPOAELMHI<TSerialized> FENAFFODHOF<TSerialized>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4718660", Offset = "0x4717A60", VA = "0x184718660")]
	public static DEJPCDPMDJB FENAFFODHOF(Type HGOPLJOKKMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4715BE0", Offset = "0x4714FE0", VA = "0x184715BE0")]
	private static DEJPCDPMDJB DLNCMLOBIID(Type NOMLDKJCODG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x471DC40", Offset = "0x471D040", VA = "0x18471DC40")]
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
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xDE6750", Offset = "0xDE5B50", VA = "0x180DE6750")]
		[DebuggerHidden]
		public FNDCKMEPNHC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4754990", Offset = "0x4753D90", VA = "0x184754990", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4754360", Offset = "0x4753760", VA = "0x184754360", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x47547D0", Offset = "0x4753BD0", VA = "0x1847547D0")]
		private void OMCGPHJKBHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4754940", Offset = "0x4753D40", VA = "0x184754940", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x4754820", Offset = "0x4753C20", VA = "0x184754820", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x4754900", Offset = "0x4753D00", VA = "0x184754900", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x52D7380", Offset = "0x52D6780", VA = "0x1852D7380")]
	protected PELMLFKFKOL(bool GBENKBHAPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x52D7070", Offset = "0x52D6470", VA = "0x1852D7070", Slot = "9")]
	public override string PELCBGJOJPC(TCollection PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x52D72C0", Offset = "0x52D66C0", VA = "0x1852D72C0", Slot = "12")]
	[IteratorStateMachine(typeof(PELMLFKFKOL<>.FNDCKMEPNHC))]
	internal override IEnumerable<string> PPHHOCJDELK(string PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x52D6FF0", Offset = "0x52D63F0", VA = "0x1852D6FF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7BEB0B0", Offset = "0x7BEA4B0", VA = "0x187BEB0B0")]
	[Preserve]
	public FCIOFBGPBAB(bool GBENKBHAPNG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB020", Offset = "0x7BEA420", VA = "0x187BEB020", Slot = "11")]
	protected override List<string> LLEJPLOGIMJ(IEnumerable<string> OFLDFOLPLBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class MCOFFOGEFKB : PELMLFKFKOL<string[]>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7BEBCD0", Offset = "0x7BEB0D0", VA = "0x187BEBCD0")]
	[Preserve]
	public MCOFFOGEFKB(bool GBENKBHAPNG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7BEBC70", Offset = "0x7BEB070", VA = "0x187BEBC70", Slot = "11")]
	protected override string[] LLEJPLOGIMJ(IEnumerable<string> OFLDFOLPLBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class JOPHCMHONHK : FICJNCNGGAA<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xD5A0F0", Offset = "0xD594F0", VA = "0x180D5A0F0", Slot = "9")]
	public override string PELCBGJOJPC(string PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB6C0", Offset = "0x7BEAAC0", VA = "0x187BEB6C0", Slot = "10")]
	protected override bool PLIIBEGPKOB(string PJCOHHCODGF, [Out] string FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB6E0", Offset = "0x7BEAAE0", VA = "0x187BEB6E0")]
	public JOPHCMHONHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class LJPKDNGJHCB : FICJNCNGGAA<TimeSpan>
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB9A0", Offset = "0x7BEADA0", VA = "0x187BEB9A0", Slot = "9")]
	public override string PELCBGJOJPC(TimeSpan PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7BEBAC0", Offset = "0x7BEAEC0", VA = "0x187BEBAC0", Slot = "10")]
	protected override bool PLIIBEGPKOB(string PJCOHHCODGF, [Out] TimeSpan FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7BEBC30", Offset = "0x7BEB030", VA = "0x187BEBC30")]
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
