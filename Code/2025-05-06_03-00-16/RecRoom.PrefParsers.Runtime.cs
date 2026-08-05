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
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA09330", Offset = "0xA07B30", VA = "0x180A09330")]
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
		[Cpp2IlInjected.Address(RVA = "0xA09370", Offset = "0xA07B70", VA = "0x180A09370")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class BAJNNJGPDNF : FECLMDBGLMA<bool>
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7EA45C0", Offset = "0x7EA2DC0", VA = "0x187EA45C0", Slot = "9")]
	public override string LIJGMGKAKKG(bool JEOEDPICHHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7EA4560", Offset = "0x7EA2D60", VA = "0x187EA4560", Slot = "10")]
	protected override bool BLBICEGAHDG(string JEOEDPICHHI, [Out] bool OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7EA4610", Offset = "0x7EA2E10", VA = "0x187EA4610")]
	public BAJNNJGPDNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class EDFAIOKOAFJ : FECLMDBGLMA<DateTime>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7EA4820", Offset = "0x7EA3020", VA = "0x187EA4820", Slot = "9")]
	public override string LIJGMGKAKKG(DateTime JEOEDPICHHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7EA4780", Offset = "0x7EA2F80", VA = "0x187EA4780", Slot = "10")]
	protected override bool BLBICEGAHDG(string JEOEDPICHHI, [Out] DateTime OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7EA48B0", Offset = "0x7EA30B0", VA = "0x187EA48B0")]
	public EDFAIOKOAFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class GLEFAIGEPAO<TEnum> : FECLMDBGLMA<TEnum> where TEnum : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly Type IAKHMPNNHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool JHIKLKKANCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly TEnum[] MGEDIIGJIGC;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x49C35E0", Offset = "0x49C1DE0", VA = "0x1849C35E0")]
	[Preserve]
	public GLEFAIGEPAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x49C32C0", Offset = "0x49C1AC0", VA = "0x1849C32C0", Slot = "9")]
	public override string LIJGMGKAKKG(TEnum JEOEDPICHHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x49C31E0", Offset = "0x49C19E0", VA = "0x1849C31E0", Slot = "10")]
	protected override bool BLBICEGAHDG(string JEOEDPICHHI, [Out] TEnum OPMIAMEJKDH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class BABPFMBGEDO<TEnum> : FECLMDBGLMA<TEnum> where TEnum : Enum
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Type IAKHMPNNHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly KLEKKDAPBHA FHKBPILMFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly bool JHIKLKKANCP;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5D90F30", Offset = "0x5D8F730", VA = "0x185D90F30")]
	[Preserve]
	public BABPFMBGEDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5D90E40", Offset = "0x5D8F640", VA = "0x185D90E40", Slot = "9")]
	public override string LIJGMGKAKKG(TEnum JEOEDPICHHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5D90880", Offset = "0x5D8F080", VA = "0x185D90880", Slot = "10")]
	protected override bool BLBICEGAHDG(string JEOEDPICHHI, [Out] TEnum OPMIAMEJKDH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class AHIOLODKECO
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly Dictionary<Type, KLEKKDAPBHA> DLBAPKCNKJN;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7EA3D00", Offset = "0x7EA2500", VA = "0x187EA3D00")]
	public static KLEKKDAPBHA KFFHHHNIHEP(Type MAIJDCNCJGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class KNDHAIKNJEA<T> : FECLMDBGLMA<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3601630", Offset = "0x35FFE30", VA = "0x183601630", Slot = "9")]
	public override string LIJGMGKAKKG(T JEOEDPICHHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4F3D2C0", Offset = "0x4F3BAC0", VA = "0x184F3D2C0", Slot = "10")]
	protected override bool BLBICEGAHDG(string JEOEDPICHHI, [Out] T OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x43CFBA0", Offset = "0x43CE3A0", VA = "0x1843CFBA0")]
	public KNDHAIKNJEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class DNOKEOOKKJB<TCollection, T> : FECLMDBGLMA<TCollection> where TCollection : IEnumerable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly EDMHIFHNNAC<T> PDPCAIKPHPM;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x68EA0C0", Offset = "0x68E88C0", VA = "0x1868EA0C0")]
	protected DNOKEOOKKJB(EDMHIFHNNAC<T> PDPCAIKPHPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x68E94C0", Offset = "0x68E7CC0", VA = "0x1868E94C0", Slot = "9")]
	public override string LIJGMGKAKKG(TCollection JEOEDPICHHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x68E83E0", Offset = "0x68E6BE0", VA = "0x1868E83E0", Slot = "10")]
	protected override bool BLBICEGAHDG(string JEOEDPICHHI, [Out] TCollection OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract TCollection JLBALOEPJNP(IEnumerable<T> ENLECGNCFFO);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x68E8E30", Offset = "0x68E7630", VA = "0x1868E8E30", Slot = "12")]
	internal virtual IEnumerable<string> CIBNHILIEHP(string JEOEDPICHHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x68E9F50", Offset = "0x68E8750", VA = "0x1868E9F50")]
	[CompilerGenerated]
	private string NGIJCFJHNNH(T AALALMNDJKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class CDFBMPIHCNO<T> : DNOKEOOKKJB<T[], T>
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4961880", Offset = "0x4960080", VA = "0x184961880")]
	[Preserve]
	public CDFBMPIHCNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x43E20D0", Offset = "0x43E08D0", VA = "0x1843E20D0")]
	[Preserve]
	public CDFBMPIHCNO(EDMHIFHNNAC<T> PDPCAIKPHPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x630CA10", Offset = "0x630B210", VA = "0x18630CA10", Slot = "11")]
	protected override T[] JLBALOEPJNP(IEnumerable<T> ENLECGNCFFO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class MKLNCIIFIAJ<T> : DNOKEOOKKJB<List<T>, T>
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4961880", Offset = "0x4960080", VA = "0x184961880")]
	[Preserve]
	public MKLNCIIFIAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x43E20D0", Offset = "0x43E08D0", VA = "0x1843E20D0")]
	[Preserve]
	public MKLNCIIFIAJ([Optional] EDMHIFHNNAC<T> PDPCAIKPHPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x528BB20", Offset = "0x528A320", VA = "0x18528BB20", Slot = "11")]
	protected override List<T> JLBALOEPJNP(IEnumerable<T> ENLECGNCFFO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class NENPDKIHEHD<T> : FECLMDBGLMA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly JsonSerializerSettings? OCMNINAGBIH;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x49D70D0", Offset = "0x49D58D0", VA = "0x1849D70D0")]
	public NENPDKIHEHD(JsonSerializerSettings? BJGBGHONDNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x52FC2A0", Offset = "0x52FAAA0", VA = "0x1852FC2A0", Slot = "9")]
	public override string LIJGMGKAKKG(T JEOEDPICHHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x52FC1D0", Offset = "0x52FA9D0", VA = "0x1852FC1D0", Slot = "10")]
	protected override bool BLBICEGAHDG([NotNull] string JEOEDPICHHI, [Out] T OPMIAMEJKDH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class BBFCPBCMEIG : FECLMDBGLMA<byte>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7EA46E0", Offset = "0x7EA2EE0", VA = "0x187EA46E0", Slot = "9")]
	public override string LIJGMGKAKKG(byte JEOEDPICHHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7EA4650", Offset = "0x7EA2E50", VA = "0x187EA4650", Slot = "10")]
	protected override bool BLBICEGAHDG(string JEOEDPICHHI, [Out] byte OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7EA4740", Offset = "0x7EA2F40", VA = "0x187EA4740")]
	public BBFCPBCMEIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class EPCDOGNDCMI : FECLMDBGLMA<short>
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7EA4AD0", Offset = "0x7EA32D0", VA = "0x187EA4AD0", Slot = "9")]
	public override string LIJGMGKAKKG(short JEOEDPICHHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7EA4A30", Offset = "0x7EA3230", VA = "0x187EA4A30", Slot = "10")]
	protected override bool BLBICEGAHDG(string JEOEDPICHHI, [Out] short OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7EA4B30", Offset = "0x7EA3330", VA = "0x187EA4B30")]
	public EPCDOGNDCMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal class ICOFLNBIEMK : FECLMDBGLMA<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7EA4C70", Offset = "0x7EA3470", VA = "0x187EA4C70", Slot = "9")]
	public override string LIJGMGKAKKG(ushort JEOEDPICHHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7EA4BD0", Offset = "0x7EA33D0", VA = "0x187EA4BD0", Slot = "10")]
	protected override bool BLBICEGAHDG(string JEOEDPICHHI, [Out] ushort OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7EA4CD0", Offset = "0x7EA34D0", VA = "0x187EA4CD0")]
	public ICOFLNBIEMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class POHDLBOEJNJ : FECLMDBGLMA<int>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7EA51B0", Offset = "0x7EA39B0", VA = "0x187EA51B0", Slot = "9")]
	public override string LIJGMGKAKKG(int JEOEDPICHHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7EA5120", Offset = "0x7EA3920", VA = "0x187EA5120", Slot = "10")]
	protected override bool BLBICEGAHDG(string JEOEDPICHHI, [Out] int OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7EA5210", Offset = "0x7EA3A10", VA = "0x187EA5210")]
	public POHDLBOEJNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class AJIDEHMENFC : FECLMDBGLMA<uint>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7EA44C0", Offset = "0x7EA2CC0", VA = "0x187EA44C0", Slot = "9")]
	public override string LIJGMGKAKKG(uint JEOEDPICHHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7EA4430", Offset = "0x7EA2C30", VA = "0x187EA4430", Slot = "10")]
	protected override bool BLBICEGAHDG(string JEOEDPICHHI, [Out] uint OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7EA4520", Offset = "0x7EA2D20", VA = "0x187EA4520")]
	public AJIDEHMENFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class EJEKCHILGCN : FECLMDBGLMA<long>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7EA4990", Offset = "0x7EA3190", VA = "0x187EA4990", Slot = "9")]
	public override string LIJGMGKAKKG(long JEOEDPICHHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7EA48F0", Offset = "0x7EA30F0", VA = "0x187EA48F0", Slot = "10")]
	protected override bool BLBICEGAHDG(string JEOEDPICHHI, [Out] long OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7EA49F0", Offset = "0x7EA31F0", VA = "0x187EA49F0")]
	public EJEKCHILGCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class LGHPEAICKCC : FECLMDBGLMA<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7EA4FD0", Offset = "0x7EA37D0", VA = "0x187EA4FD0", Slot = "9")]
	public override string LIJGMGKAKKG(ulong JEOEDPICHHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7EA4F30", Offset = "0x7EA3730", VA = "0x187EA4F30", Slot = "10")]
	protected override bool BLBICEGAHDG(string JEOEDPICHHI, [Out] ulong OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7EA5030", Offset = "0x7EA3830", VA = "0x187EA5030")]
	public LGHPEAICKCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class JIKBIJBCBOJ : FECLMDBGLMA<float>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7EA4E80", Offset = "0x7EA3680", VA = "0x187EA4E80", Slot = "9")]
	public override string LIJGMGKAKKG(float JEOEDPICHHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7EA4DF0", Offset = "0x7EA35F0", VA = "0x187EA4DF0", Slot = "10")]
	protected override bool BLBICEGAHDG(string JEOEDPICHHI, [Out] float OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7EA4EF0", Offset = "0x7EA36F0", VA = "0x187EA4EF0")]
	public JIKBIJBCBOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface KLEKKDAPBHA
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string KLLHBHBEBFA(object JEOEDPICHHI);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ONPMOEBHJHG([CanBeNull] string JEOEDPICHHI, [Out] object OPMIAMEJKDH);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface EDMHIFHNNAC<T> : KLEKKDAPBHA
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string LIJGMGKAKKG(T JEOEDPICHHI);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AJHOHMFMDLC([CanBeNull] string JEOEDPICHHI, [Out] T OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T ELFKBEABJML([CanBeNull] string JEOEDPICHHI, [Optional] T LHCNPHOLELG);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class FECLMDBGLMA<T> : EDMHIFHNNAC<T>, KLEKKDAPBHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Type AACNDNCHFFM;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4868380", Offset = "0x4866B80", VA = "0x184868380")]
	protected FECLMDBGLMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4867AB0", Offset = "0x48662B0", VA = "0x184867AB0")]
	private T MPPBIHJOKJL(object PNHCNFOFAFI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract string LIJGMGKAKKG(T JEOEDPICHHI);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4867940", Offset = "0x4866140", VA = "0x184867940", Slot = "7")]
	public string KLLHBHBEBFA(object JEOEDPICHHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4866D10", Offset = "0x4865510", VA = "0x184866D10", Slot = "5")]
	public bool AJHOHMFMDLC(string JEOEDPICHHI, [Out] T OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool BLBICEGAHDG([NotNull] string JEOEDPICHHI, [Out] T OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4867030", Offset = "0x4865830", VA = "0x184867030", Slot = "8")]
	private bool BAOBPPAFHKM(string JEOEDPICHHI, [Out] object OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x48675D0", Offset = "0x4865DD0", VA = "0x1848675D0", Slot = "6")]
	public T ELFKBEABJML(string JEOEDPICHHI, [Optional] T LHCNPHOLELG)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class NEGKDEKGPEL<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static EDMHIFHNNAC<T> CONOIFPANGO
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4851140", Offset = "0x484F940", VA = "0x184851140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3AF4E00", Offset = "0x3AF3600", VA = "0x183AF4E00")]
	public static EDMHIFHNNAC<TSerialized> IFBFPPGOJMF<TSerialized>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x52EF110", Offset = "0x52ED910", VA = "0x1852EF110")]
	public static KLEKKDAPBHA IFBFPPGOJMF(Type DIMPJHOOFHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x52F9BF0", Offset = "0x52F83F0", VA = "0x1852F9BF0")]
	private static KLEKKDAPBHA NOMONMBICNN(Type GNFJAIOMBHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x52E3CD0", Offset = "0x52E24D0", VA = "0x1852E3CD0")]
	private static KLEKKDAPBHA BGEKIPCEHBH(Type GNFJAIOMBHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class KBKDCFMEGMK<TCollection> : DNOKEOOKKJB<TCollection, string> where TCollection : IEnumerable<string>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class ENJOEEHNOFJ : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
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
		public KBKDCFMEGMK<TCollection> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private KENMKJMLHKJ<StringBuilder> <_>5__2;

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
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xE73320", Offset = "0xE71B20", VA = "0x180E73320")]
		[DebuggerHidden]
		public ENJOEEHNOFJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4437C90", Offset = "0x4436490", VA = "0x184437C90", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x44376B0", Offset = "0x4435EB0", VA = "0x1844376B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4437660", Offset = "0x4435E60", VA = "0x184437660")]
		private void JCGGFCDKBHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4437C40", Offset = "0x4436440", VA = "0x184437C40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x4437B20", Offset = "0x4436320", VA = "0x184437B20", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x4437C00", Offset = "0x4436400", VA = "0x184437C00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool IEOBCMPPMLD;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4EEAA90", Offset = "0x4EE9290", VA = "0x184EEAA90")]
	protected KBKDCFMEGMK(bool IEOBCMPPMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4EEA850", Offset = "0x4EE9050", VA = "0x184EEA850", Slot = "9")]
	public override string LIJGMGKAKKG(TCollection JEOEDPICHHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4EEA710", Offset = "0x4EE8F10", VA = "0x184EEA710", Slot = "12")]
	[IteratorStateMachine(typeof(KBKDCFMEGMK<>.ENJOEEHNOFJ))]
	internal override IEnumerable<string> CIBNHILIEHP(string JEOEDPICHHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4EEA7D0", Offset = "0x4EE8FD0", VA = "0x184EEA7D0")]
	[CompilerGenerated]
	internal static string HBOFIAHKGAH(StringBuilder AHBBECMMPOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class IOAFEBNHBFG : KBKDCFMEGMK<List<string>>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7EA4DA0", Offset = "0x7EA35A0", VA = "0x187EA4DA0")]
	[Preserve]
	public IOAFEBNHBFG(bool IEOBCMPPMLD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7EA4D10", Offset = "0x7EA3510", VA = "0x187EA4D10", Slot = "11")]
	protected override List<string> JLBALOEPJNP(IEnumerable<string> ENLECGNCFFO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class MLADCCNFDJN : KBKDCFMEGMK<string[]>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7EA50D0", Offset = "0x7EA38D0", VA = "0x187EA50D0")]
	[Preserve]
	public MLADCCNFDJN(bool IEOBCMPPMLD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7EA5070", Offset = "0x7EA3870", VA = "0x187EA5070", Slot = "11")]
	protected override string[] JLBALOEPJNP(IEnumerable<string> ENLECGNCFFO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class FGAAIDAPALC : FECLMDBGLMA<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xA63AC0", Offset = "0xA622C0", VA = "0x180A63AC0", Slot = "9")]
	public override string LIJGMGKAKKG(string JEOEDPICHHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7EA4B70", Offset = "0x7EA3370", VA = "0x187EA4B70", Slot = "10")]
	protected override bool BLBICEGAHDG(string JEOEDPICHHI, [Out] string OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7EA4B90", Offset = "0x7EA3390", VA = "0x187EA4B90")]
	public FGAAIDAPALC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class ACMIMPLAKML : FECLMDBGLMA<TimeSpan>
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7EA3BA0", Offset = "0x7EA23A0", VA = "0x187EA3BA0", Slot = "9")]
	public override string LIJGMGKAKKG(TimeSpan JEOEDPICHHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7EA3A30", Offset = "0x7EA2230", VA = "0x187EA3A30", Slot = "10")]
	protected override bool BLBICEGAHDG(string JEOEDPICHHI, [Out] TimeSpan OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7EA3CC0", Offset = "0x7EA24C0", VA = "0x187EA3CC0")]
	public ACMIMPLAKML()
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
