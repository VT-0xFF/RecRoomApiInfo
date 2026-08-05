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
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA154F0", Offset = "0xA13AF0", VA = "0x180A154F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA15530", Offset = "0xA13B30", VA = "0x180A15530")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class GDHMMAPFHGG : ONJKNCMKDMF<bool>
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7FD45F0", Offset = "0x7FD2BF0", VA = "0x187FD45F0", Slot = "9")]
	public override string DFNAEDFOBIJ(bool HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7FD4640", Offset = "0x7FD2C40", VA = "0x187FD4640", Slot = "10")]
	protected override bool DPOBAFJDPAH(string HPLMFDGMJFE, [Out] bool OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7FD46A0", Offset = "0x7FD2CA0", VA = "0x187FD46A0")]
	public GDHMMAPFHGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class DBMGJHHNBCJ : ONJKNCMKDMF<DateTime>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7FD3F90", Offset = "0x7FD2590", VA = "0x187FD3F90", Slot = "9")]
	public override string DFNAEDFOBIJ(DateTime HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7FD4020", Offset = "0x7FD2620", VA = "0x187FD4020", Slot = "10")]
	protected override bool DPOBAFJDPAH(string HPLMFDGMJFE, [Out] DateTime OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7FD40C0", Offset = "0x7FD26C0", VA = "0x187FD40C0")]
	public DBMGJHHNBCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class FDDPFCKJDHE<TEnum> : ONJKNCMKDMF<TEnum> where TEnum : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly Type NNODEEMKOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool IMPGAEKDGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly TEnum[] DHLGAIMCINE;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4999030", Offset = "0x4997630", VA = "0x184999030")]
	[Preserve]
	public FDDPFCKJDHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4998C30", Offset = "0x4997230", VA = "0x184998C30", Slot = "9")]
	public override string DFNAEDFOBIJ(TEnum HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4998E70", Offset = "0x4997470", VA = "0x184998E70", Slot = "10")]
	protected override bool DPOBAFJDPAH(string HPLMFDGMJFE, [Out] TEnum OHLIHBDBKCE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class MDGNENGDIPK<TEnum> : ONJKNCMKDMF<TEnum> where TEnum : Enum
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Type NNODEEMKOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly OIPFLEFECCA LDENNCCJPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly bool IMPGAEKDGPK;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5337C50", Offset = "0x5336250", VA = "0x185337C50")]
	[Preserve]
	public MDGNENGDIPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5337650", Offset = "0x5335C50", VA = "0x185337650", Slot = "9")]
	public override string DFNAEDFOBIJ(TEnum HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5337740", Offset = "0x5335D40", VA = "0x185337740", Slot = "10")]
	protected override bool DPOBAFJDPAH(string HPLMFDGMJFE, [Out] TEnum OHLIHBDBKCE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class AMGDNBNCLPI
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly Dictionary<Type, OIPFLEFECCA> HBCHNHGKLEE;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7FD3640", Offset = "0x7FD1C40", VA = "0x187FD3640")]
	public static OIPFLEFECCA AHNPOIKKNDH(Type ONJICPJEKHK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class GPCKPEDIAOC<T> : ONJKNCMKDMF<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3FBE670", Offset = "0x3FBCC70", VA = "0x183FBE670", Slot = "9")]
	public override string DFNAEDFOBIJ(T HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4AD3E20", Offset = "0x4AD2420", VA = "0x184AD3E20", Slot = "10")]
	protected override bool DPOBAFJDPAH(string HPLMFDGMJFE, [Out] T OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x44EBE00", Offset = "0x44EA400", VA = "0x1844EBE00")]
	public GPCKPEDIAOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class PLLDOFKLHIA<TCollection, T> : ONJKNCMKDMF<TCollection> where TCollection : IEnumerable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly NBHJDEFAJJO<T> DAOHAJMJIEO;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x562C1E0", Offset = "0x562A7E0", VA = "0x18562C1E0")]
	protected PLLDOFKLHIA(NBHJDEFAJJO<T> DAOHAJMJIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x56284F0", Offset = "0x5626AF0", VA = "0x1856284F0", Slot = "9")]
	public override string DFNAEDFOBIJ(TCollection HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5629780", Offset = "0x5627D80", VA = "0x185629780", Slot = "10")]
	protected override bool DPOBAFJDPAH(string HPLMFDGMJFE, [Out] TCollection OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract TCollection KHJBPPEEPPL(IEnumerable<T> MFNAKEDKNJF);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x56282A0", Offset = "0x56268A0", VA = "0x1856282A0", Slot = "12")]
	internal virtual IEnumerable<string> CJFJHNJCJDH(string HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x562BEC0", Offset = "0x562A4C0", VA = "0x18562BEC0")]
	[CompilerGenerated]
	private string MGMLIJGNCNC(T IINHKHEMEHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class JFLNKJDJOHN<T> : PLLDOFKLHIA<T[], T>
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4A53140", Offset = "0x4A51740", VA = "0x184A53140")]
	[Preserve]
	public JFLNKJDJOHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4963F10", Offset = "0x4962510", VA = "0x184963F10")]
	[Preserve]
	public JFLNKJDJOHN(NBHJDEFAJJO<T> DAOHAJMJIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4E79080", Offset = "0x4E77680", VA = "0x184E79080", Slot = "11")]
	protected override T[] KHJBPPEEPPL(IEnumerable<T> MFNAKEDKNJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class HDNINAJMCOO<T> : PLLDOFKLHIA<List<T>, T>
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4A53140", Offset = "0x4A51740", VA = "0x184A53140")]
	[Preserve]
	public HDNINAJMCOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4963F10", Offset = "0x4962510", VA = "0x184963F10")]
	[Preserve]
	public HDNINAJMCOO([Optional] NBHJDEFAJJO<T> DAOHAJMJIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4B08BB0", Offset = "0x4B071B0", VA = "0x184B08BB0", Slot = "11")]
	protected override List<T> KHJBPPEEPPL(IEnumerable<T> MFNAKEDKNJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class IBHKOCMKKHB<T> : ONJKNCMKDMF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly JsonSerializerSettings? LFEPJPFHIHO;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4C21890", Offset = "0x4C1FE90", VA = "0x184C21890")]
	public IBHKOCMKKHB(JsonSerializerSettings? NBEACOEJLCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4C21760", Offset = "0x4C1FD60", VA = "0x184C21760", Slot = "9")]
	public override string DFNAEDFOBIJ(T HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4C217C0", Offset = "0x4C1FDC0", VA = "0x184C217C0", Slot = "10")]
	protected override bool DPOBAFJDPAH([NotNull] string HPLMFDGMJFE, [Out] T OHLIHBDBKCE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class FDEGADGGEEP : ONJKNCMKDMF<byte>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7FD4380", Offset = "0x7FD2980", VA = "0x187FD4380", Slot = "9")]
	public override string DFNAEDFOBIJ(byte HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7FD43E0", Offset = "0x7FD29E0", VA = "0x187FD43E0", Slot = "10")]
	protected override bool DPOBAFJDPAH(string HPLMFDGMJFE, [Out] byte OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7FD4470", Offset = "0x7FD2A70", VA = "0x187FD4470")]
	public FDEGADGGEEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class FDMEPHBFCNM : ONJKNCMKDMF<short>
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7FD44B0", Offset = "0x7FD2AB0", VA = "0x187FD44B0", Slot = "9")]
	public override string DFNAEDFOBIJ(short HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7FD4510", Offset = "0x7FD2B10", VA = "0x187FD4510", Slot = "10")]
	protected override bool DPOBAFJDPAH(string HPLMFDGMJFE, [Out] short OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7FD45B0", Offset = "0x7FD2BB0", VA = "0x187FD45B0")]
	public FDMEPHBFCNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal class COMMHAOCJMP : ONJKNCMKDMF<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7FD3D70", Offset = "0x7FD2370", VA = "0x187FD3D70", Slot = "9")]
	public override string DFNAEDFOBIJ(ushort HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7FD3DD0", Offset = "0x7FD23D0", VA = "0x187FD3DD0", Slot = "10")]
	protected override bool DPOBAFJDPAH(string HPLMFDGMJFE, [Out] ushort OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7FD3E70", Offset = "0x7FD2470", VA = "0x187FD3E70")]
	public COMMHAOCJMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class ADCIHNLIJJD : ONJKNCMKDMF<int>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7FD3510", Offset = "0x7FD1B10", VA = "0x187FD3510", Slot = "9")]
	public override string DFNAEDFOBIJ(int HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7FD3570", Offset = "0x7FD1B70", VA = "0x187FD3570", Slot = "10")]
	protected override bool DPOBAFJDPAH(string HPLMFDGMJFE, [Out] int OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7FD3600", Offset = "0x7FD1C00", VA = "0x187FD3600")]
	public ADCIHNLIJJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class OKMPACIHBJN : ONJKNCMKDMF<uint>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7FD4C00", Offset = "0x7FD3200", VA = "0x187FD4C00", Slot = "9")]
	public override string DFNAEDFOBIJ(uint HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7FD4C60", Offset = "0x7FD3260", VA = "0x187FD4C60", Slot = "10")]
	protected override bool DPOBAFJDPAH(string HPLMFDGMJFE, [Out] uint OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7FD4CF0", Offset = "0x7FD32F0", VA = "0x187FD4CF0")]
	public OKMPACIHBJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class FAAIEIPKDKF : ONJKNCMKDMF<long>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7FD4240", Offset = "0x7FD2840", VA = "0x187FD4240", Slot = "9")]
	public override string DFNAEDFOBIJ(long HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7FD42A0", Offset = "0x7FD28A0", VA = "0x187FD42A0", Slot = "10")]
	protected override bool DPOBAFJDPAH(string HPLMFDGMJFE, [Out] long OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7FD4340", Offset = "0x7FD2940", VA = "0x187FD4340")]
	public FAAIEIPKDKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class OGGFAGBOIFN : ONJKNCMKDMF<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7FD4AC0", Offset = "0x7FD30C0", VA = "0x187FD4AC0", Slot = "9")]
	public override string DFNAEDFOBIJ(ulong HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7FD4B20", Offset = "0x7FD3120", VA = "0x187FD4B20", Slot = "10")]
	protected override bool DPOBAFJDPAH(string HPLMFDGMJFE, [Out] ulong OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7FD4BC0", Offset = "0x7FD31C0", VA = "0x187FD4BC0")]
	public OGGFAGBOIFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class DNGMLGGMDOA : ONJKNCMKDMF<float>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7FD4100", Offset = "0x7FD2700", VA = "0x187FD4100", Slot = "9")]
	public override string DFNAEDFOBIJ(float HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7FD4170", Offset = "0x7FD2770", VA = "0x187FD4170", Slot = "10")]
	protected override bool DPOBAFJDPAH(string HPLMFDGMJFE, [Out] float OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7FD4200", Offset = "0x7FD2800", VA = "0x187FD4200")]
	public DNGMLGGMDOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface OIPFLEFECCA
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string DNABMMINPHN(object HPLMFDGMJFE);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CKOMEPEOJFH([CanBeNull] string HPLMFDGMJFE, [Out] object OHLIHBDBKCE);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface NBHJDEFAJJO<T> : OIPFLEFECCA
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string DFNAEDFOBIJ(T HPLMFDGMJFE);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HBGMKAEOAKP([CanBeNull] string HPLMFDGMJFE, [Out] T OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T GLNDGKKIMDA([CanBeNull] string HPLMFDGMJFE, [Optional] T JMMNJNFGHEP);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class ONJKNCMKDMF<T> : NBHJDEFAJJO<T>, OIPFLEFECCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Type FJPDOPHOCIK;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x554A070", Offset = "0x5548670", VA = "0x18554A070")]
	protected ONJKNCMKDMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x55491E0", Offset = "0x55477E0", VA = "0x1855491E0")]
	private T KONLIOCIDFH(object BOMDCGFKGKF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract string DFNAEDFOBIJ(T HPLMFDGMJFE);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5548840", Offset = "0x5546E40", VA = "0x185548840", Slot = "7")]
	public string DNABMMINPHN(object HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5548E40", Offset = "0x5547440", VA = "0x185548E40", Slot = "5")]
	public bool HBGMKAEOAKP(string HPLMFDGMJFE, [Out] T OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool DPOBAFJDPAH([NotNull] string HPLMFDGMJFE, [Out] T OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x55497D0", Offset = "0x5547DD0", VA = "0x1855497D0", Slot = "8")]
	private bool NJJHDCJEJDK(string HPLMFDGMJFE, [Out] object OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5548B50", Offset = "0x5547150", VA = "0x185548B50", Slot = "6")]
	public T GLNDGKKIMDA(string HPLMFDGMJFE, [Optional] T JMMNJNFGHEP)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class ALFHCAICFPN<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static NBHJDEFAJJO<T> OPJKGEJPJBC
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4963520", Offset = "0x4961B20", VA = "0x184963520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x37B1AA0", Offset = "0x37B00A0", VA = "0x1837B1AA0")]
	public static NBHJDEFAJJO<TSerialized> AFNEMFBIPBB<TSerialized>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4C83A50", Offset = "0x4C82050", VA = "0x184C83A50")]
	public static OIPFLEFECCA AFNEMFBIPBB(Type BMNPEEGGBFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4C8E710", Offset = "0x4C8CD10", VA = "0x184C8E710")]
	private static OIPFLEFECCA JEFAGHJNJGK(Type FCFOPGKFBIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4C87890", Offset = "0x4C85E90", VA = "0x184C87890")]
	private static OIPFLEFECCA IADJJFIJHLN(Type FCFOPGKFBIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class FIMMEAIMFAH<TCollection> : PLLDOFKLHIA<TCollection, string> where TCollection : IEnumerable<string>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class EGAPJBFEHNB : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
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
		public FIMMEAIMFAH<TCollection> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private CLMBDIOJEPP<StringBuilder> <_>5__2;

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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xE9CA20", Offset = "0xE9B020", VA = "0x180E9CA20")]
		[DebuggerHidden]
		public EGAPJBFEHNB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x450AD50", Offset = "0x4509350", VA = "0x18450AD50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x450A770", Offset = "0x4508D70", VA = "0x18450A770", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x450A720", Offset = "0x4508D20", VA = "0x18450A720")]
		private void KILKBHNKCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x450AD00", Offset = "0x4509300", VA = "0x18450AD00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x450ABE0", Offset = "0x45091E0", VA = "0x18450ABE0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x450ACC0", Offset = "0x45092C0", VA = "0x18450ACC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool JPGMFHFAKBP;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x49AE080", Offset = "0x49AC680", VA = "0x1849AE080")]
	protected FIMMEAIMFAH(bool JPGMFHFAKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x49ADDC0", Offset = "0x49AC3C0", VA = "0x1849ADDC0", Slot = "9")]
	public override string DFNAEDFOBIJ(TCollection HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x49ADD00", Offset = "0x49AC300", VA = "0x1849ADD00", Slot = "12")]
	[IteratorStateMachine(typeof(FIMMEAIMFAH<>.EGAPJBFEHNB))]
	internal override IEnumerable<string> CJFJHNJCJDH(string HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x49AE000", Offset = "0x49AC600", VA = "0x1849AE000")]
	[CompilerGenerated]
	internal static string FHGPKNBEIEH(StringBuilder PAMAJIDJFOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class DAADDOGNPCG : FIMMEAIMFAH<List<string>>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7FD3F40", Offset = "0x7FD2540", VA = "0x187FD3F40")]
	[Preserve]
	public DAADDOGNPCG(bool JPGMFHFAKBP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7FD3EB0", Offset = "0x7FD24B0", VA = "0x187FD3EB0", Slot = "11")]
	protected override List<string> KHJBPPEEPPL(IEnumerable<string> MFNAKEDKNJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class KAMCLILFPCE : FIMMEAIMFAH<string[]>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7FD4A10", Offset = "0x7FD3010", VA = "0x187FD4A10")]
	[Preserve]
	public KAMCLILFPCE(bool JPGMFHFAKBP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7FD49B0", Offset = "0x7FD2FB0", VA = "0x187FD49B0", Slot = "11")]
	protected override string[] KHJBPPEEPPL(IEnumerable<string> MFNAKEDKNJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class LBLPOLMJKPF : ONJKNCMKDMF<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xA89310", Offset = "0xA87910", VA = "0x180A89310", Slot = "9")]
	public override string DFNAEDFOBIJ(string HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7FD4A60", Offset = "0x7FD3060", VA = "0x187FD4A60", Slot = "10")]
	protected override bool DPOBAFJDPAH(string HPLMFDGMJFE, [Out] string OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7FD4A80", Offset = "0x7FD3080", VA = "0x187FD4A80")]
	public LBLPOLMJKPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class JGFBLMEHHOL : ONJKNCMKDMF<TimeSpan>
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7FD46E0", Offset = "0x7FD2CE0", VA = "0x187FD46E0", Slot = "9")]
	public override string DFNAEDFOBIJ(TimeSpan HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7FD4800", Offset = "0x7FD2E00", VA = "0x187FD4800", Slot = "10")]
	protected override bool DPOBAFJDPAH(string HPLMFDGMJFE, [Out] TimeSpan OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7FD4970", Offset = "0x7FD2F70", VA = "0x187FD4970")]
	public JGFBLMEHHOL()
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
