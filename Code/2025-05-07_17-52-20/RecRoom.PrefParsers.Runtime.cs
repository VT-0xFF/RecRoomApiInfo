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
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1B220", Offset = "0xA1A220", VA = "0x180A1B220")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1B260", Offset = "0xA1A260", VA = "0x180A1B260")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class GDHMMAPFHGG : ONJKNCMKDMF<bool>
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4A70", Offset = "0x7FE3A70", VA = "0x187FE4A70", Slot = "9")]
	public override string DFNAEDFOBIJ(bool HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4AC0", Offset = "0x7FE3AC0", VA = "0x187FE4AC0", Slot = "10")]
	protected override bool DPOBAFJDPAH(string HPLMFDGMJFE, [Out] bool OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4B20", Offset = "0x7FE3B20", VA = "0x187FE4B20")]
	public GDHMMAPFHGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class DBMGJHHNBCJ : ONJKNCMKDMF<DateTime>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4410", Offset = "0x7FE3410", VA = "0x187FE4410", Slot = "9")]
	public override string DFNAEDFOBIJ(DateTime HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7FE44A0", Offset = "0x7FE34A0", VA = "0x187FE44A0", Slot = "10")]
	protected override bool DPOBAFJDPAH(string HPLMFDGMJFE, [Out] DateTime OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4540", Offset = "0x7FE3540", VA = "0x187FE4540")]
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
	[Cpp2IlInjected.Address(RVA = "0x495A610", Offset = "0x4959610", VA = "0x18495A610")]
	[Preserve]
	public FDDPFCKJDHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x495A1F0", Offset = "0x49591F0", VA = "0x18495A1F0", Slot = "9")]
	public override string DFNAEDFOBIJ(TEnum HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x495A440", Offset = "0x4959440", VA = "0x18495A440", Slot = "10")]
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
	[Cpp2IlInjected.Address(RVA = "0x5310D70", Offset = "0x530FD70", VA = "0x185310D70")]
	[Preserve]
	public MDGNENGDIPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5310760", Offset = "0x530F760", VA = "0x185310760", Slot = "9")]
	public override string DFNAEDFOBIJ(TEnum HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5310850", Offset = "0x530F850", VA = "0x185310850", Slot = "10")]
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
	[Cpp2IlInjected.Address(RVA = "0x7FE3A90", Offset = "0x7FE2A90", VA = "0x187FE3A90")]
	public static OIPFLEFECCA AHNPOIKKNDH(Type ONJICPJEKHK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class GPCKPEDIAOC<T> : ONJKNCMKDMF<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3F677D0", Offset = "0x3F667D0", VA = "0x183F677D0", Slot = "9")]
	public override string DFNAEDFOBIJ(T HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4A987E0", Offset = "0x4A977E0", VA = "0x184A987E0", Slot = "10")]
	protected override bool DPOBAFJDPAH(string HPLMFDGMJFE, [Out] T OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x44ADD20", Offset = "0x44ACD20", VA = "0x1844ADD20")]
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
	[Cpp2IlInjected.Address(RVA = "0x561E900", Offset = "0x561D900", VA = "0x18561E900")]
	protected PLLDOFKLHIA(NBHJDEFAJJO<T> DAOHAJMJIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x561AB90", Offset = "0x5619B90", VA = "0x18561AB90", Slot = "9")]
	public override string DFNAEDFOBIJ(TCollection HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x561BE20", Offset = "0x561AE20", VA = "0x18561BE20", Slot = "10")]
	protected override bool DPOBAFJDPAH(string HPLMFDGMJFE, [Out] TCollection OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract TCollection KHJBPPEEPPL(IEnumerable<T> MFNAKEDKNJF);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x561A940", Offset = "0x5619940", VA = "0x18561A940", Slot = "12")]
	internal virtual IEnumerable<string> CJFJHNJCJDH(string HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x561E5A0", Offset = "0x561D5A0", VA = "0x18561E5A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4A17230", Offset = "0x4A16230", VA = "0x184A17230")]
	[Preserve]
	public JFLNKJDJOHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4924030", Offset = "0x4923030", VA = "0x184924030")]
	[Preserve]
	public JFLNKJDJOHN(NBHJDEFAJJO<T> DAOHAJMJIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4E30530", Offset = "0x4E2F530", VA = "0x184E30530", Slot = "11")]
	protected override T[] KHJBPPEEPPL(IEnumerable<T> MFNAKEDKNJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class HDNINAJMCOO<T> : PLLDOFKLHIA<List<T>, T>
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4A17230", Offset = "0x4A16230", VA = "0x184A17230")]
	[Preserve]
	public HDNINAJMCOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4924030", Offset = "0x4923030", VA = "0x184924030")]
	[Preserve]
	public HDNINAJMCOO([Optional] NBHJDEFAJJO<T> DAOHAJMJIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4ACFEC0", Offset = "0x4ACEEC0", VA = "0x184ACFEC0", Slot = "11")]
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
	[Cpp2IlInjected.Address(RVA = "0x4BEB540", Offset = "0x4BEA540", VA = "0x184BEB540")]
	public IBHKOCMKKHB(JsonSerializerSettings? NBEACOEJLCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4BEB410", Offset = "0x4BEA410", VA = "0x184BEB410", Slot = "9")]
	public override string DFNAEDFOBIJ(T HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4BEB470", Offset = "0x4BEA470", VA = "0x184BEB470", Slot = "10")]
	protected override bool DPOBAFJDPAH([NotNull] string HPLMFDGMJFE, [Out] T OHLIHBDBKCE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class FDEGADGGEEP : ONJKNCMKDMF<byte>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4800", Offset = "0x7FE3800", VA = "0x187FE4800", Slot = "9")]
	public override string DFNAEDFOBIJ(byte HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4860", Offset = "0x7FE3860", VA = "0x187FE4860", Slot = "10")]
	protected override bool DPOBAFJDPAH(string HPLMFDGMJFE, [Out] byte OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7FE48F0", Offset = "0x7FE38F0", VA = "0x187FE48F0")]
	public FDEGADGGEEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class FDMEPHBFCNM : ONJKNCMKDMF<short>
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4930", Offset = "0x7FE3930", VA = "0x187FE4930", Slot = "9")]
	public override string DFNAEDFOBIJ(short HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4990", Offset = "0x7FE3990", VA = "0x187FE4990", Slot = "10")]
	protected override bool DPOBAFJDPAH(string HPLMFDGMJFE, [Out] short OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4A30", Offset = "0x7FE3A30", VA = "0x187FE4A30")]
	public FDMEPHBFCNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal class COMMHAOCJMP : ONJKNCMKDMF<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7FE41F0", Offset = "0x7FE31F0", VA = "0x187FE41F0", Slot = "9")]
	public override string DFNAEDFOBIJ(ushort HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4250", Offset = "0x7FE3250", VA = "0x187FE4250", Slot = "10")]
	protected override bool DPOBAFJDPAH(string HPLMFDGMJFE, [Out] ushort OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7FE42F0", Offset = "0x7FE32F0", VA = "0x187FE42F0")]
	public COMMHAOCJMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class ADCIHNLIJJD : ONJKNCMKDMF<int>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7FE3960", Offset = "0x7FE2960", VA = "0x187FE3960", Slot = "9")]
	public override string DFNAEDFOBIJ(int HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7FE39C0", Offset = "0x7FE29C0", VA = "0x187FE39C0", Slot = "10")]
	protected override bool DPOBAFJDPAH(string HPLMFDGMJFE, [Out] int OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7FE3A50", Offset = "0x7FE2A50", VA = "0x187FE3A50")]
	public ADCIHNLIJJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class OKMPACIHBJN : ONJKNCMKDMF<uint>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7FE5080", Offset = "0x7FE4080", VA = "0x187FE5080", Slot = "9")]
	public override string DFNAEDFOBIJ(uint HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7FE50E0", Offset = "0x7FE40E0", VA = "0x187FE50E0", Slot = "10")]
	protected override bool DPOBAFJDPAH(string HPLMFDGMJFE, [Out] uint OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7FE5170", Offset = "0x7FE4170", VA = "0x187FE5170")]
	public OKMPACIHBJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class FAAIEIPKDKF : ONJKNCMKDMF<long>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7FE46C0", Offset = "0x7FE36C0", VA = "0x187FE46C0", Slot = "9")]
	public override string DFNAEDFOBIJ(long HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4720", Offset = "0x7FE3720", VA = "0x187FE4720", Slot = "10")]
	protected override bool DPOBAFJDPAH(string HPLMFDGMJFE, [Out] long OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7FE47C0", Offset = "0x7FE37C0", VA = "0x187FE47C0")]
	public FAAIEIPKDKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class OGGFAGBOIFN : ONJKNCMKDMF<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4F40", Offset = "0x7FE3F40", VA = "0x187FE4F40", Slot = "9")]
	public override string DFNAEDFOBIJ(ulong HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4FA0", Offset = "0x7FE3FA0", VA = "0x187FE4FA0", Slot = "10")]
	protected override bool DPOBAFJDPAH(string HPLMFDGMJFE, [Out] ulong OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7FE5040", Offset = "0x7FE4040", VA = "0x187FE5040")]
	public OGGFAGBOIFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class DNGMLGGMDOA : ONJKNCMKDMF<float>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4580", Offset = "0x7FE3580", VA = "0x187FE4580", Slot = "9")]
	public override string DFNAEDFOBIJ(float HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7FE45F0", Offset = "0x7FE35F0", VA = "0x187FE45F0", Slot = "10")]
	protected override bool DPOBAFJDPAH(string HPLMFDGMJFE, [Out] float OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4680", Offset = "0x7FE3680", VA = "0x187FE4680")]
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
	[Cpp2IlInjected.Address(RVA = "0x5535950", Offset = "0x5534950", VA = "0x185535950")]
	protected ONJKNCMKDMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5534A50", Offset = "0x5533A50", VA = "0x185534A50")]
	private T KONLIOCIDFH(object BOMDCGFKGKF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract string DFNAEDFOBIJ(T HPLMFDGMJFE);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5534050", Offset = "0x5533050", VA = "0x185534050", Slot = "7")]
	public string DNABMMINPHN(object HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5534660", Offset = "0x5533660", VA = "0x185534660", Slot = "5")]
	public bool HBGMKAEOAKP(string HPLMFDGMJFE, [Out] T OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool DPOBAFJDPAH([NotNull] string HPLMFDGMJFE, [Out] T OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5535090", Offset = "0x5534090", VA = "0x185535090", Slot = "8")]
	private bool NJJHDCJEJDK(string HPLMFDGMJFE, [Out] object OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5534370", Offset = "0x5533370", VA = "0x185534370", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x49235B0", Offset = "0x49225B0", VA = "0x1849235B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x37C1820", Offset = "0x37C0820", VA = "0x1837C1820")]
	public static NBHJDEFAJJO<TSerialized> AFNEMFBIPBB<TSerialized>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4C7BAA0", Offset = "0x4C7AAA0", VA = "0x184C7BAA0")]
	public static OIPFLEFECCA AFNEMFBIPBB(Type BMNPEEGGBFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4C90380", Offset = "0x4C8F380", VA = "0x184C90380")]
	private static OIPFLEFECCA JEFAGHJNJGK(Type FCFOPGKFBIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4C82D70", Offset = "0x4C81D70", VA = "0x184C82D70")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xE8B5B0", Offset = "0xE8A5B0", VA = "0x180E8B5B0")]
		[DebuggerHidden]
		public EGAPJBFEHNB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x44CD9D0", Offset = "0x44CC9D0", VA = "0x1844CD9D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x44CD3E0", Offset = "0x44CC3E0", VA = "0x1844CD3E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x44CD390", Offset = "0x44CC390", VA = "0x1844CD390")]
		private void KILKBHNKCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x44CD980", Offset = "0x44CC980", VA = "0x1844CD980", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x44CD860", Offset = "0x44CC860", VA = "0x1844CD860", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x44CD940", Offset = "0x44CC940", VA = "0x1844CD940", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x496F1F0", Offset = "0x496E1F0", VA = "0x18496F1F0")]
	protected FIMMEAIMFAH(bool JPGMFHFAKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x496EF10", Offset = "0x496DF10", VA = "0x18496EF10", Slot = "9")]
	public override string DFNAEDFOBIJ(TCollection HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x496EE50", Offset = "0x496DE50", VA = "0x18496EE50", Slot = "12")]
	[IteratorStateMachine(typeof(FIMMEAIMFAH<>.EGAPJBFEHNB))]
	internal override IEnumerable<string> CJFJHNJCJDH(string HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x496F170", Offset = "0x496E170", VA = "0x18496F170")]
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
	[Cpp2IlInjected.Address(RVA = "0x7FE43C0", Offset = "0x7FE33C0", VA = "0x187FE43C0")]
	[Preserve]
	public DAADDOGNPCG(bool JPGMFHFAKBP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4330", Offset = "0x7FE3330", VA = "0x187FE4330", Slot = "11")]
	protected override List<string> KHJBPPEEPPL(IEnumerable<string> MFNAKEDKNJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class KAMCLILFPCE : FIMMEAIMFAH<string[]>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4E90", Offset = "0x7FE3E90", VA = "0x187FE4E90")]
	[Preserve]
	public KAMCLILFPCE(bool JPGMFHFAKBP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4E30", Offset = "0x7FE3E30", VA = "0x187FE4E30", Slot = "11")]
	protected override string[] KHJBPPEEPPL(IEnumerable<string> MFNAKEDKNJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class LBLPOLMJKPF : ONJKNCMKDMF<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xA75AA0", Offset = "0xA74AA0", VA = "0x180A75AA0", Slot = "9")]
	public override string DFNAEDFOBIJ(string HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4EE0", Offset = "0x7FE3EE0", VA = "0x187FE4EE0", Slot = "10")]
	protected override bool DPOBAFJDPAH(string HPLMFDGMJFE, [Out] string OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4F00", Offset = "0x7FE3F00", VA = "0x187FE4F00")]
	public LBLPOLMJKPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class JGFBLMEHHOL : ONJKNCMKDMF<TimeSpan>
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4B60", Offset = "0x7FE3B60", VA = "0x187FE4B60", Slot = "9")]
	public override string DFNAEDFOBIJ(TimeSpan HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4C80", Offset = "0x7FE3C80", VA = "0x187FE4C80", Slot = "10")]
	protected override bool DPOBAFJDPAH(string HPLMFDGMJFE, [Out] TimeSpan OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4DF0", Offset = "0x7FE3DF0", VA = "0x187FE4DF0")]
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
