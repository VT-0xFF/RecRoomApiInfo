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
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
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
		[Cpp2IlInjected.Address(RVA = "0xA2C560", Offset = "0xA2B760", VA = "0x180A2C560")]
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
		[Cpp2IlInjected.Address(RVA = "0xA2C5A0", Offset = "0xA2B7A0", VA = "0x180A2C5A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class AMPHKCBLMEM : AHJMEINBFAL<bool>
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8012A90", Offset = "0x8011C90", VA = "0x188012A90", Slot = "9")]
	public override string ELKKKBEIKKA(bool GLMNBNPBGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8012AE0", Offset = "0x8011CE0", VA = "0x188012AE0", Slot = "10")]
	protected override bool JDGKNKDOODP(string GLMNBNPBGCG, [Out] bool KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8012B40", Offset = "0x8011D40", VA = "0x188012B40")]
	public AMPHKCBLMEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class OMIAEBDMMCD : AHJMEINBFAL<DateTime>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8014060", Offset = "0x8013260", VA = "0x188014060", Slot = "9")]
	public override string ELKKKBEIKKA(DateTime GLMNBNPBGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x80140F0", Offset = "0x80132F0", VA = "0x1880140F0", Slot = "10")]
	protected override bool JDGKNKDOODP(string GLMNBNPBGCG, [Out] DateTime KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8014190", Offset = "0x8013390", VA = "0x188014190")]
	public OMIAEBDMMCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class DLIIAEDAPEI<TEnum> : AHJMEINBFAL<TEnum> where TEnum : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly Type MFFKACCIKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool MAMLMGMJBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly TEnum[] LMKJLPPFOFC;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x422A930", Offset = "0x4229B30", VA = "0x18422A930")]
	[Preserve]
	public DLIIAEDAPEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x422A590", Offset = "0x4229790", VA = "0x18422A590", Slot = "9")]
	public override string ELKKKBEIKKA(TEnum GLMNBNPBGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x422A780", Offset = "0x4229980", VA = "0x18422A780", Slot = "10")]
	protected override bool JDGKNKDOODP(string GLMNBNPBGCG, [Out] TEnum KJIOHKMJAPE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class FHHNLKDACHM<TEnum> : AHJMEINBFAL<TEnum> where TEnum : Enum
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Type MFFKACCIKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly MABNNGPDKNL ABIIFLFBEBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly bool MAMLMGMJBCJ;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4B33D60", Offset = "0x4B32F60", VA = "0x184B33D60")]
	[Preserve]
	public FHHNLKDACHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4B33550", Offset = "0x4B32750", VA = "0x184B33550", Slot = "9")]
	public override string ELKKKBEIKKA(TEnum GLMNBNPBGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4B336F0", Offset = "0x4B328F0", VA = "0x184B336F0", Slot = "10")]
	protected override bool JDGKNKDOODP(string GLMNBNPBGCG, [Out] TEnum KJIOHKMJAPE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class BJBFMBBOOFN
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly Dictionary<Type, MABNNGPDKNL> LFCGLMIGLMA;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8012E50", Offset = "0x8012050", VA = "0x188012E50")]
	public static MABNNGPDKNL KPBKADLKNHM(Type CJBKPBEHJJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class IAPEPDCBDCA<T> : AHJMEINBFAL<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3BC64E0", Offset = "0x3BC56E0", VA = "0x183BC64E0", Slot = "9")]
	public override string ELKKKBEIKKA(T GLMNBNPBGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4DA4C30", Offset = "0x4DA3E30", VA = "0x184DA4C30", Slot = "10")]
	protected override bool JDGKNKDOODP(string GLMNBNPBGCG, [Out] T KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4651EE0", Offset = "0x46510E0", VA = "0x184651EE0")]
	public IAPEPDCBDCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class BNHANJFGFKM<TCollection, T> : AHJMEINBFAL<TCollection> where TCollection : IEnumerable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly OIKEJCNDEBN<T> GEFPHFAPENA;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x627FB00", Offset = "0x627ED00", VA = "0x18627FB00")]
	protected BNHANJFGFKM(OIKEJCNDEBN<T> GEFPHFAPENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x627E2B0", Offset = "0x627D4B0", VA = "0x18627E2B0", Slot = "9")]
	public override string ELKKKBEIKKA(TCollection GLMNBNPBGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x627F430", Offset = "0x627E630", VA = "0x18627F430", Slot = "10")]
	protected override bool JDGKNKDOODP(string GLMNBNPBGCG, [Out] TCollection KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract TCollection BAHDGOAHEFP(IEnumerable<T> LLGFOHBEPNG);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x627FAD0", Offset = "0x627ECD0", VA = "0x18627FAD0", Slot = "12")]
	internal virtual IEnumerable<string> LOKLMOCKDJO(string GLMNBNPBGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x627E520", Offset = "0x627D720", VA = "0x18627E520")]
	[CompilerGenerated]
	private string GFIHMMCNDIC(T JIKDBGFICJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class PKCGPEOGJGD<T> : BNHANJFGFKM<T[], T>
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4C17640", Offset = "0x4C16840", VA = "0x184C17640")]
	[Preserve]
	public PKCGPEOGJGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4201740", Offset = "0x4200940", VA = "0x184201740")]
	[Preserve]
	public PKCGPEOGJGD(OIKEJCNDEBN<T> GEFPHFAPENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x56FE5B0", Offset = "0x56FD7B0", VA = "0x1856FE5B0", Slot = "11")]
	protected override T[] BAHDGOAHEFP(IEnumerable<T> LLGFOHBEPNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class PNIPGBEGPIA<T> : BNHANJFGFKM<List<T>, T>
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4C17640", Offset = "0x4C16840", VA = "0x184C17640")]
	[Preserve]
	public PNIPGBEGPIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4201740", Offset = "0x4200940", VA = "0x184201740")]
	[Preserve]
	public PNIPGBEGPIA([Optional] OIKEJCNDEBN<T> GEFPHFAPENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x57093E0", Offset = "0x57085E0", VA = "0x1857093E0", Slot = "11")]
	protected override List<T> BAHDGOAHEFP(IEnumerable<T> LLGFOHBEPNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class PMJAGGDLMAP<T> : AHJMEINBFAL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly JsonSerializerSettings? MCJIDLBPNDK;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5464A80", Offset = "0x5463C80", VA = "0x185464A80")]
	public PMJAGGDLMAP(JsonSerializerSettings? GDLAGAPIBNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5708190", Offset = "0x5707390", VA = "0x185708190", Slot = "9")]
	public override string ELKKKBEIKKA(T GLMNBNPBGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x57081F0", Offset = "0x57073F0", VA = "0x1857081F0", Slot = "10")]
	protected override bool JDGKNKDOODP([NotNull] string GLMNBNPBGCG, [Out] T KJIOHKMJAPE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class EFDABJGKHNP : AHJMEINBFAL<byte>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8013800", Offset = "0x8012A00", VA = "0x188013800", Slot = "9")]
	public override string ELKKKBEIKKA(byte GLMNBNPBGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8013860", Offset = "0x8012A60", VA = "0x188013860", Slot = "10")]
	protected override bool JDGKNKDOODP(string GLMNBNPBGCG, [Out] byte KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x80138F0", Offset = "0x8012AF0", VA = "0x1880138F0")]
	public EFDABJGKHNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class OLBIPOOJAJP : AHJMEINBFAL<short>
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8013F20", Offset = "0x8013120", VA = "0x188013F20", Slot = "9")]
	public override string ELKKKBEIKKA(short GLMNBNPBGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8013F80", Offset = "0x8013180", VA = "0x188013F80", Slot = "10")]
	protected override bool JDGKNKDOODP(string GLMNBNPBGCG, [Out] short KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8014020", Offset = "0x8013220", VA = "0x188014020")]
	public OLBIPOOJAJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal class NANLFLIHLNI : AHJMEINBFAL<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8013CB0", Offset = "0x8012EB0", VA = "0x188013CB0", Slot = "9")]
	public override string ELKKKBEIKKA(ushort GLMNBNPBGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8013D10", Offset = "0x8012F10", VA = "0x188013D10", Slot = "10")]
	protected override bool JDGKNKDOODP(string GLMNBNPBGCG, [Out] ushort KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8013DB0", Offset = "0x8012FB0", VA = "0x188013DB0")]
	public NANLFLIHLNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class GMNALKGPMJB : AHJMEINBFAL<int>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8013990", Offset = "0x8012B90", VA = "0x188013990", Slot = "9")]
	public override string ELKKKBEIKKA(int GLMNBNPBGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x80139F0", Offset = "0x8012BF0", VA = "0x1880139F0", Slot = "10")]
	protected override bool JDGKNKDOODP(string GLMNBNPBGCG, [Out] int KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8013A80", Offset = "0x8012C80", VA = "0x188013A80")]
	public GMNALKGPMJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class OGMKJCFGDPF : AHJMEINBFAL<uint>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8013DF0", Offset = "0x8012FF0", VA = "0x188013DF0", Slot = "9")]
	public override string ELKKKBEIKKA(uint GLMNBNPBGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8013E50", Offset = "0x8013050", VA = "0x188013E50", Slot = "10")]
	protected override bool JDGKNKDOODP(string GLMNBNPBGCG, [Out] uint KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8013EE0", Offset = "0x80130E0", VA = "0x188013EE0")]
	public OGMKJCFGDPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class HFJCJDBNHAJ : AHJMEINBFAL<long>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8013AC0", Offset = "0x8012CC0", VA = "0x188013AC0", Slot = "9")]
	public override string ELKKKBEIKKA(long GLMNBNPBGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8013B20", Offset = "0x8012D20", VA = "0x188013B20", Slot = "10")]
	protected override bool JDGKNKDOODP(string GLMNBNPBGCG, [Out] long KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8013BC0", Offset = "0x8012DC0", VA = "0x188013BC0")]
	public HFJCJDBNHAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class ECFDEELOLJA : AHJMEINBFAL<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x80136C0", Offset = "0x80128C0", VA = "0x1880136C0", Slot = "9")]
	public override string ELKKKBEIKKA(ulong GLMNBNPBGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8013720", Offset = "0x8012920", VA = "0x188013720", Slot = "10")]
	protected override bool JDGKNKDOODP(string GLMNBNPBGCG, [Out] ulong KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x80137C0", Offset = "0x80129C0", VA = "0x1880137C0")]
	public ECFDEELOLJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class DKMNEPGHAIL : AHJMEINBFAL<float>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8013580", Offset = "0x8012780", VA = "0x188013580", Slot = "9")]
	public override string ELKKKBEIKKA(float GLMNBNPBGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x80135F0", Offset = "0x80127F0", VA = "0x1880135F0", Slot = "10")]
	protected override bool JDGKNKDOODP(string GLMNBNPBGCG, [Out] float KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8013680", Offset = "0x8012880", VA = "0x188013680")]
	public DKMNEPGHAIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface MABNNGPDKNL
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string NNCAAJENNPB(object GLMNBNPBGCG);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LCPOLLNKGOE([CanBeNull] string GLMNBNPBGCG, [Out] object KJIOHKMJAPE);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface OIKEJCNDEBN<T> : MABNNGPDKNL
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string ELKKKBEIKKA(T GLMNBNPBGCG);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GHMCGLNMJHJ([CanBeNull] string GLMNBNPBGCG, [Out] T KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T DFIHCNMIBEC([CanBeNull] string GLMNBNPBGCG, [Optional] T FEOJADDJKIL);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class AHJMEINBFAL<T> : OIKEJCNDEBN<T>, MABNNGPDKNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Type CILAPFNFNLF;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4F25E40", Offset = "0x4F25040", VA = "0x184F25E40")]
	protected AHJMEINBFAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4F25330", Offset = "0x4F24530", VA = "0x184F25330")]
	private T NMFEFIBJJHI(object KFMNDOMPAMC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract string ELKKKBEIKKA(T GLMNBNPBGCG);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4F25700", Offset = "0x4F24900", VA = "0x184F25700", Slot = "7")]
	public string NNCAAJENNPB(object GLMNBNPBGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4F24AD0", Offset = "0x4F23CD0", VA = "0x184F24AD0", Slot = "5")]
	public bool GHMCGLNMJHJ(string GLMNBNPBGCG, [Out] T KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool JDGKNKDOODP([NotNull] string GLMNBNPBGCG, [Out] T KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4F24EF0", Offset = "0x4F240F0", VA = "0x184F24EF0", Slot = "8")]
	private bool GMKLBENNODP(string GLMNBNPBGCG, [Out] object KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4F247E0", Offset = "0x4F239E0", VA = "0x184F247E0", Slot = "6")]
	public T DFIHCNMIBEC(string GLMNBNPBGCG, [Optional] T FEOJADDJKIL)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class GBMNBJLCPPP<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static OIKEJCNDEBN<T> LGHIFDBIJOC
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4B1A3B0", Offset = "0x4B195B0", VA = "0x184B1A3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3B99030", Offset = "0x3B98230", VA = "0x183B99030")]
	public static OIKEJCNDEBN<TSerialized> OGIMKGBGICB<TSerialized>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4BDDF40", Offset = "0x4BDD140", VA = "0x184BDDF40")]
	public static MABNNGPDKNL OGIMKGBGICB(Type ABDCMLNJMPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4BED640", Offset = "0x4BEC840", VA = "0x184BED640")]
	private static MABNNGPDKNL OOEMDBLFAPO(Type PBOMDHONPGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4BDD6B0", Offset = "0x4BDC8B0", VA = "0x184BDD6B0")]
	private static MABNNGPDKNL EJPABHFOICM(Type PBOMDHONPGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class GFGHFLMPPCK<TCollection> : BNHANJFGFKM<TCollection, string> where TCollection : IEnumerable<string>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class NOONHMJEJBM : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
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
		public GFGHFLMPPCK<TCollection> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private NNKAOFHLKDG<StringBuilder> <_>5__2;

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
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xED9970", Offset = "0xED8B70", VA = "0x180ED9970")]
		[DebuggerHidden]
		public NOONHMJEJBM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4B7C940", Offset = "0x4B7BB40", VA = "0x184B7C940", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x54AF090", Offset = "0x54AE290", VA = "0x1854AF090", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x54AF040", Offset = "0x54AE240", VA = "0x1854AF040")]
		private void DOCBGIOIEEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x54AF5A0", Offset = "0x54AE7A0", VA = "0x1854AF5A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x54AF4E0", Offset = "0x54AE6E0", VA = "0x1854AF4E0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x4233640", Offset = "0x4232840", VA = "0x184233640", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool KCDMIBMLNIB;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4BFC860", Offset = "0x4BFBA60", VA = "0x184BFC860")]
	protected GFGHFLMPPCK(bool KCDMIBMLNIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4BFC500", Offset = "0x4BFB700", VA = "0x184BFC500", Slot = "9")]
	public override string ELKKKBEIKKA(TCollection GLMNBNPBGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4BFC7B0", Offset = "0x4BFB9B0", VA = "0x184BFC7B0", Slot = "12")]
	[IteratorStateMachine(typeof(GFGHFLMPPCK<>.NOONHMJEJBM))]
	internal override IEnumerable<string> LOKLMOCKDJO(string GLMNBNPBGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4BFC730", Offset = "0x4BFB930", VA = "0x184BFC730")]
	[CompilerGenerated]
	internal static string GAOININKPKK(StringBuilder HHAIGBDCFAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class OOLGJGOLEKG : GFGHFLMPPCK<List<string>>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8014260", Offset = "0x8013460", VA = "0x188014260")]
	[Preserve]
	public OOLGJGOLEKG(bool KCDMIBMLNIB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x80141D0", Offset = "0x80133D0", VA = "0x1880141D0", Slot = "11")]
	protected override List<string> BAHDGOAHEFP(IEnumerable<string> LLGFOHBEPNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class IHKCJICGLNO : GFGHFLMPPCK<string[]>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8013C60", Offset = "0x8012E60", VA = "0x188013C60")]
	[Preserve]
	public IHKCJICGLNO(bool KCDMIBMLNIB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8013C00", Offset = "0x8012E00", VA = "0x188013C00", Slot = "11")]
	protected override string[] BAHDGOAHEFP(IEnumerable<string> LLGFOHBEPNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class FFHCEBKLBGB : AHJMEINBFAL<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xA7D9B0", Offset = "0xA7CBB0", VA = "0x180A7D9B0", Slot = "9")]
	public override string ELKKKBEIKKA(string GLMNBNPBGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8013930", Offset = "0x8012B30", VA = "0x188013930", Slot = "10")]
	protected override bool JDGKNKDOODP(string GLMNBNPBGCG, [Out] string KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8013950", Offset = "0x8012B50", VA = "0x188013950")]
	public FFHCEBKLBGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class BHHIOFGOMLO : AHJMEINBFAL<TimeSpan>
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8012B80", Offset = "0x8011D80", VA = "0x188012B80", Slot = "9")]
	public override string ELKKKBEIKKA(TimeSpan GLMNBNPBGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8012CA0", Offset = "0x8011EA0", VA = "0x188012CA0", Slot = "10")]
	protected override bool JDGKNKDOODP(string GLMNBNPBGCG, [Out] TimeSpan KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8012E10", Offset = "0x8012010", VA = "0x188012E10")]
	public BHHIOFGOMLO()
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
