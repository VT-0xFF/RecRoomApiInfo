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
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BC6F0", Offset = "0x9BBAF0", VA = "0x1809BC6F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BC730", Offset = "0x9BBB30", VA = "0x1809BC730")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class MCGDDNNFHID : FLBIAAIFCHH<bool>
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7B77050", Offset = "0x7B76450", VA = "0x187B77050", Slot = "9")]
	public override string LMGGAKIACNI(bool BEAPIEHNNIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7B76FF0", Offset = "0x7B763F0", VA = "0x187B76FF0", Slot = "10")]
	protected override bool EFJBOHLINAN(string BEAPIEHNNIB, [Out] bool FIIKLGCIAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7B770A0", Offset = "0x7B764A0", VA = "0x187B770A0")]
	public MCGDDNNFHID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class KLFNLNMMPKK : FLBIAAIFCHH<DateTime>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7B76DE0", Offset = "0x7B761E0", VA = "0x187B76DE0", Slot = "9")]
	public override string LMGGAKIACNI(DateTime BEAPIEHNNIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7B76D40", Offset = "0x7B76140", VA = "0x187B76D40", Slot = "10")]
	protected override bool EFJBOHLINAN(string BEAPIEHNNIB, [Out] DateTime FIIKLGCIAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7B76E70", Offset = "0x7B76270", VA = "0x187B76E70")]
	public KLFNLNMMPKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class JNALBJABKON<TEnum> : FLBIAAIFCHH<TEnum> where TEnum : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly Type PNPFBMNGOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool FLJJOEEOKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly TEnum[] EDJBENPLFOA;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4C03B20", Offset = "0x4C02F20", VA = "0x184C03B20")]
	[Preserve]
	public JNALBJABKON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4C03800", Offset = "0x4C02C00", VA = "0x184C03800", Slot = "9")]
	public override string LMGGAKIACNI(TEnum BEAPIEHNNIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4C03720", Offset = "0x4C02B20", VA = "0x184C03720", Slot = "10")]
	protected override bool EFJBOHLINAN(string BEAPIEHNNIB, [Out] TEnum FIIKLGCIAGG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class DEDDONLKDFK<TEnum> : FLBIAAIFCHH<TEnum> where TEnum : Enum
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Type PNPFBMNGOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly MNJCBMHCLIJ KNFAFGDOMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly bool FLJJOEEOKIC;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x65B4760", Offset = "0x65B3B60", VA = "0x1865B4760")]
	[Preserve]
	public DEDDONLKDFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x65B4510", Offset = "0x65B3910", VA = "0x1865B4510", Slot = "9")]
	public override string LMGGAKIACNI(TEnum BEAPIEHNNIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x65B3F40", Offset = "0x65B3340", VA = "0x1865B3F40", Slot = "10")]
	protected override bool EFJBOHLINAN(string BEAPIEHNNIB, [Out] TEnum FIIKLGCIAGG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class HPLHAABGDOK
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly Dictionary<Type, MNJCBMHCLIJ> NJAPEEODCCI;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7B76420", Offset = "0x7B75820", VA = "0x187B76420")]
	public static MNJCBMHCLIJ JNLALFNPDAK(Type EKFHCLFDAFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class CHLEPFIMMGM<T> : FLBIAAIFCHH<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3359EC0", Offset = "0x33592C0", VA = "0x183359EC0", Slot = "9")]
	public override string LMGGAKIACNI(T BEAPIEHNNIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x613B1D0", Offset = "0x613A5D0", VA = "0x18613B1D0", Slot = "10")]
	protected override bool EFJBOHLINAN(string BEAPIEHNNIB, [Out] T FIIKLGCIAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x41EE5E0", Offset = "0x41ED9E0", VA = "0x1841EE5E0")]
	public CHLEPFIMMGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class EFALEBGNAAF<TCollection, T> : FLBIAAIFCHH<TCollection> where TCollection : IEnumerable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly PLGODNCKHKI<T> GINCDMDDBBA;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4273510", Offset = "0x4272910", VA = "0x184273510")]
	protected EFALEBGNAAF(PLGODNCKHKI<T> GINCDMDDBBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x42730D0", Offset = "0x42724D0", VA = "0x1842730D0", Slot = "9")]
	public override string LMGGAKIACNI(TCollection BEAPIEHNNIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4270A70", Offset = "0x426FE70", VA = "0x184270A70", Slot = "10")]
	protected override bool EFJBOHLINAN(string BEAPIEHNNIB, [Out] TCollection FIIKLGCIAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract TCollection CIMCMJMCCMD(IEnumerable<T> BJMJFECFHCC);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4272280", Offset = "0x4271680", VA = "0x184272280", Slot = "12")]
	internal virtual IEnumerable<string> GIDPIMKNGPG(string BEAPIEHNNIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x42722B0", Offset = "0x42716B0", VA = "0x1842722B0")]
	[CompilerGenerated]
	private string GIPOOKEMIBK(T AEPDMGGJHKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class GOCOGKNKILM<T> : EFALEBGNAAF<T[], T>
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4202EC0", Offset = "0x42022C0", VA = "0x184202EC0")]
	[Preserve]
	public GOCOGKNKILM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4202E80", Offset = "0x4202280", VA = "0x184202E80")]
	[Preserve]
	public GOCOGKNKILM(PLGODNCKHKI<T> GINCDMDDBBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4837150", Offset = "0x4836550", VA = "0x184837150", Slot = "11")]
	protected override T[] CIMCMJMCCMD(IEnumerable<T> BJMJFECFHCC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class ECJAJMIKJID<T> : EFALEBGNAAF<List<T>, T>
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4202EC0", Offset = "0x42022C0", VA = "0x184202EC0")]
	[Preserve]
	public ECJAJMIKJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4202E80", Offset = "0x4202280", VA = "0x184202E80")]
	[Preserve]
	public ECJAJMIKJID([Optional] PLGODNCKHKI<T> GINCDMDDBBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4202DD0", Offset = "0x42021D0", VA = "0x184202DD0", Slot = "11")]
	protected override List<T> CIMCMJMCCMD(IEnumerable<T> BJMJFECFHCC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class JNICADIBGCO<T> : FLBIAAIFCHH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly JsonSerializerSettings? FINKKLGGJNJ;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4C0BEE0", Offset = "0x4C0B2E0", VA = "0x184C0BEE0")]
	public JNICADIBGCO(JsonSerializerSettings? NPNELJOOMDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4C0BE80", Offset = "0x4C0B280", VA = "0x184C0BE80", Slot = "9")]
	public override string LMGGAKIACNI(T BEAPIEHNNIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4C0BDB0", Offset = "0x4C0B1B0", VA = "0x184C0BDB0", Slot = "10")]
	protected override bool EFJBOHLINAN([NotNull] string BEAPIEHNNIB, [Out] T FIIKLGCIAGG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class ANEECDDPMOH : FLBIAAIFCHH<byte>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7B75F70", Offset = "0x7B75370", VA = "0x187B75F70", Slot = "9")]
	public override string LMGGAKIACNI(byte BEAPIEHNNIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7B75EE0", Offset = "0x7B752E0", VA = "0x187B75EE0", Slot = "10")]
	protected override bool EFJBOHLINAN(string BEAPIEHNNIB, [Out] byte FIIKLGCIAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7B75FD0", Offset = "0x7B753D0", VA = "0x187B75FD0")]
	public ANEECDDPMOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class AKFMMFFKHKB : FLBIAAIFCHH<short>
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7B75E40", Offset = "0x7B75240", VA = "0x187B75E40", Slot = "9")]
	public override string LMGGAKIACNI(short BEAPIEHNNIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7B75DA0", Offset = "0x7B751A0", VA = "0x187B75DA0", Slot = "10")]
	protected override bool EFJBOHLINAN(string BEAPIEHNNIB, [Out] short FIIKLGCIAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7B75EA0", Offset = "0x7B752A0", VA = "0x187B75EA0")]
	public AKFMMFFKHKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal class BPKAFFOOJIA : FLBIAAIFCHH<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7B76250", Offset = "0x7B75650", VA = "0x187B76250", Slot = "9")]
	public override string LMGGAKIACNI(ushort BEAPIEHNNIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7B761B0", Offset = "0x7B755B0", VA = "0x187B761B0", Slot = "10")]
	protected override bool EFJBOHLINAN(string BEAPIEHNNIB, [Out] ushort FIIKLGCIAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7B762B0", Offset = "0x7B756B0", VA = "0x187B762B0")]
	public BPKAFFOOJIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class OJDILAJFKAI : FLBIAAIFCHH<int>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7B77520", Offset = "0x7B76920", VA = "0x187B77520", Slot = "9")]
	public override string LMGGAKIACNI(int BEAPIEHNNIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7B77490", Offset = "0x7B76890", VA = "0x187B77490", Slot = "10")]
	protected override bool EFJBOHLINAN(string BEAPIEHNNIB, [Out] int FIIKLGCIAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7B77580", Offset = "0x7B76980", VA = "0x187B77580")]
	public OJDILAJFKAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class CJJIDPFBPHP : FLBIAAIFCHH<uint>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7B76380", Offset = "0x7B75780", VA = "0x187B76380", Slot = "9")]
	public override string LMGGAKIACNI(uint BEAPIEHNNIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7B762F0", Offset = "0x7B756F0", VA = "0x187B762F0", Slot = "10")]
	protected override bool EFJBOHLINAN(string BEAPIEHNNIB, [Out] uint FIIKLGCIAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7B763E0", Offset = "0x7B757E0", VA = "0x187B763E0")]
	public CJJIDPFBPHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class LOGPCHNKEEE : FLBIAAIFCHH<long>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7B76F50", Offset = "0x7B76350", VA = "0x187B76F50", Slot = "9")]
	public override string LMGGAKIACNI(long BEAPIEHNNIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7B76EB0", Offset = "0x7B762B0", VA = "0x187B76EB0", Slot = "10")]
	protected override bool EFJBOHLINAN(string BEAPIEHNNIB, [Out] long FIIKLGCIAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7B76FB0", Offset = "0x7B763B0", VA = "0x187B76FB0")]
	public LOGPCHNKEEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class BLBAMIMAGAN : FLBIAAIFCHH<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7B760B0", Offset = "0x7B754B0", VA = "0x187B760B0", Slot = "9")]
	public override string LMGGAKIACNI(ulong BEAPIEHNNIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7B76010", Offset = "0x7B75410", VA = "0x187B76010", Slot = "10")]
	protected override bool EFJBOHLINAN(string BEAPIEHNNIB, [Out] ulong FIIKLGCIAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7B76110", Offset = "0x7B75510", VA = "0x187B76110")]
	public BLBAMIMAGAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class ILNNMFGFBKI : FLBIAAIFCHH<float>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7B76BE0", Offset = "0x7B75FE0", VA = "0x187B76BE0", Slot = "9")]
	public override string LMGGAKIACNI(float BEAPIEHNNIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7B76B50", Offset = "0x7B75F50", VA = "0x187B76B50", Slot = "10")]
	protected override bool EFJBOHLINAN(string BEAPIEHNNIB, [Out] float FIIKLGCIAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7B76C50", Offset = "0x7B76050", VA = "0x187B76C50")]
	public ILNNMFGFBKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface MNJCBMHCLIJ
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string CHPHCKJPDFF(object BEAPIEHNNIB);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FIEOIMPIPEH([CanBeNull] string BEAPIEHNNIB, [Out] object FIIKLGCIAGG);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface PLGODNCKHKI<T> : MNJCBMHCLIJ
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string LMGGAKIACNI(T BEAPIEHNNIB);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JJNCKOILBME([CanBeNull] string BEAPIEHNNIB, [Out] T FIIKLGCIAGG);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T KFOPGNEFCKO([CanBeNull] string BEAPIEHNNIB, [Optional] T MBADHELIPJM);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class FLBIAAIFCHH<T> : PLGODNCKHKI<T>, MNJCBMHCLIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Type OKOHJJHLFAK;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x47005E0", Offset = "0x46FF9E0", VA = "0x1847005E0")]
	protected FLBIAAIFCHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x47002B0", Offset = "0x46FF6B0", VA = "0x1847002B0")]
	private T LGELJHIKPKC(object HAPOBHMBDHP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract string LMGGAKIACNI(T BEAPIEHNNIB);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x46FF3C0", Offset = "0x46FE7C0", VA = "0x1846FF3C0", Slot = "7")]
	public string CHPHCKJPDFF(object BEAPIEHNNIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x46FF540", Offset = "0x46FE940", VA = "0x1846FF540", Slot = "5")]
	public bool JJNCKOILBME(string BEAPIEHNNIB, [Out] T FIIKLGCIAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool EFJBOHLINAN([NotNull] string BEAPIEHNNIB, [Out] T FIIKLGCIAGG);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x46FFBA0", Offset = "0x46FEFA0", VA = "0x1846FFBA0", Slot = "8")]
	private bool LCMDNCMIKFP(string BEAPIEHNNIB, [Out] object FIIKLGCIAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x46FF7E0", Offset = "0x46FEBE0", VA = "0x1846FF7E0", Slot = "6")]
	public T KFOPGNEFCKO(string BEAPIEHNNIB, [Optional] T MBADHELIPJM)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class MEJFMHPCNDP<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static PLGODNCKHKI<T> OCEPFJKKOBL
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x46B1FD0", Offset = "0x46B13D0", VA = "0x1846B1FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3BA9710", Offset = "0x3BA8B10", VA = "0x183BA9710")]
	public static PLGODNCKHKI<TSerialized> HEKHIEKAJAE<TSerialized>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4F72270", Offset = "0x4F71670", VA = "0x184F72270")]
	public static MNJCBMHCLIJ HEKHIEKAJAE(Type MJIJGEHIBJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4F7C8C0", Offset = "0x4F7BCC0", VA = "0x184F7C8C0")]
	private static MNJCBMHCLIJ LPHDALPJFLI(Type CCGMBFGAKLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4F73730", Offset = "0x4F72B30", VA = "0x184F73730")]
	private static MNJCBMHCLIJ JDCMEICJLGL(Type CCGMBFGAKLK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class BMPNENLNDHH<TCollection> : EFALEBGNAAF<TCollection, string> where TCollection : IEnumerable<string>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class HDIDPEIJKKH : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
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
		public BMPNENLNDHH<TCollection> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private MOIDAHPGPIF<StringBuilder> <_>5__2;

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
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xDDEBA0", Offset = "0xDDDFA0", VA = "0x180DDEBA0")]
		[DebuggerHidden]
		public HDIDPEIJKKH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4780960", Offset = "0x477FD60", VA = "0x184780960", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x487A1E0", Offset = "0x48795E0", VA = "0x18487A1E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x487A190", Offset = "0x4879590", VA = "0x18487A190")]
		private void KNMHCFDKFOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x487A770", Offset = "0x4879B70", VA = "0x18487A770", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x487A650", Offset = "0x4879A50", VA = "0x18487A650", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x487A730", Offset = "0x4879B30", VA = "0x18487A730", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool AGKEIHNLIJK;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5D705D0", Offset = "0x5D6F9D0", VA = "0x185D705D0")]
	protected BMPNENLNDHH(bool AGKEIHNLIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5D70390", Offset = "0x5D6F790", VA = "0x185D70390", Slot = "9")]
	public override string LMGGAKIACNI(TCollection BEAPIEHNNIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5D702D0", Offset = "0x5D6F6D0", VA = "0x185D702D0", Slot = "12")]
	[IteratorStateMachine(typeof(BMPNENLNDHH<>.HDIDPEIJKKH))]
	internal override IEnumerable<string> GIDPIMKNGPG(string BEAPIEHNNIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5D70250", Offset = "0x5D6F650", VA = "0x185D70250")]
	[CompilerGenerated]
	internal static string FJOHIALCDMD(StringBuilder DOGEJFLHEAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MPMOIDJONII : BMPNENLNDHH<List<string>>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7B77170", Offset = "0x7B76570", VA = "0x187B77170")]
	[Preserve]
	public MPMOIDJONII(bool AGKEIHNLIJK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7B770E0", Offset = "0x7B764E0", VA = "0x187B770E0", Slot = "11")]
	protected override List<string> CIMCMJMCCMD(IEnumerable<string> BJMJFECFHCC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class KIPJCNDBFKD : BMPNENLNDHH<string[]>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7B76CF0", Offset = "0x7B760F0", VA = "0x187B76CF0")]
	[Preserve]
	public KIPJCNDBFKD(bool AGKEIHNLIJK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7B76C90", Offset = "0x7B76090", VA = "0x187B76C90", Slot = "11")]
	protected override string[] CIMCMJMCCMD(IEnumerable<string> BJMJFECFHCC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class BNOFKNGJGCH : FLBIAAIFCHH<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xD54400", Offset = "0xD53800", VA = "0x180D54400", Slot = "9")]
	public override string LMGGAKIACNI(string BEAPIEHNNIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7B76150", Offset = "0x7B75550", VA = "0x187B76150", Slot = "10")]
	protected override bool EFJBOHLINAN(string BEAPIEHNNIB, [Out] string FIIKLGCIAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7B76170", Offset = "0x7B75570", VA = "0x187B76170")]
	public BNOFKNGJGCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class NIGLBKDHKIG : FLBIAAIFCHH<TimeSpan>
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7B77330", Offset = "0x7B76730", VA = "0x187B77330", Slot = "9")]
	public override string LMGGAKIACNI(TimeSpan BEAPIEHNNIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7B771C0", Offset = "0x7B765C0", VA = "0x187B771C0", Slot = "10")]
	protected override bool EFJBOHLINAN(string BEAPIEHNNIB, [Out] TimeSpan FIIKLGCIAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7B77450", Offset = "0x7B76850", VA = "0x187B77450")]
	public NIGLBKDHKIG()
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
