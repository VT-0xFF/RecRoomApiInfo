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
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA838A0", Offset = "0xA826A0", VA = "0x180A838A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA838E0", Offset = "0xA826E0", VA = "0x180A838E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class BMGALFBHKEN : KKBKGFKIBLB<bool>
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8494440", Offset = "0x8493240", VA = "0x188494440", Slot = "9")]
	public override string NEJFHFKCOKJ(bool PADDIEKMDDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8494490", Offset = "0x8493290", VA = "0x188494490", Slot = "10")]
	protected override bool PCCJOMNBKIL(string PADDIEKMDDH, [Out] bool BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x84944F0", Offset = "0x84932F0", VA = "0x1884944F0")]
	public BMGALFBHKEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class CHOFFGFIFBD : KKBKGFKIBLB<DateTime>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8494530", Offset = "0x8493330", VA = "0x188494530", Slot = "9")]
	public override string NEJFHFKCOKJ(DateTime PADDIEKMDDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x84945C0", Offset = "0x84933C0", VA = "0x1884945C0", Slot = "10")]
	protected override bool PCCJOMNBKIL(string PADDIEKMDDH, [Out] DateTime BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8494660", Offset = "0x8493460", VA = "0x188494660")]
	public CHOFFGFIFBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class HNEHBHCCOHD<TEnum> : KKBKGFKIBLB<TEnum> where TEnum : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly Type BOEOHEICOCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool NAHOBCMGBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly TEnum[] FEBLBJIINOM;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4E3E4D0", Offset = "0x4E3D2D0", VA = "0x184E3E4D0")]
	[Preserve]
	public HNEHBHCCOHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4E3E100", Offset = "0x4E3CF00", VA = "0x184E3E100", Slot = "9")]
	public override string NEJFHFKCOKJ(TEnum PADDIEKMDDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4E3E300", Offset = "0x4E3D100", VA = "0x184E3E300", Slot = "10")]
	protected override bool PCCJOMNBKIL(string PADDIEKMDDH, [Out] TEnum BNECONOIKOE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class LFMEPOAAJHI<TEnum> : KKBKGFKIBLB<TEnum> where TEnum : Enum
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Type BOEOHEICOCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly BBHLDDPBCFL FMPNNGPNDAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly bool NAHOBCMGBOH;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5423330", Offset = "0x5422130", VA = "0x185423330")]
	[Preserve]
	public LFMEPOAAJHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5422BB0", Offset = "0x54219B0", VA = "0x185422BB0", Slot = "9")]
	public override string NEJFHFKCOKJ(TEnum PADDIEKMDDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5422F60", Offset = "0x5421D60", VA = "0x185422F60", Slot = "10")]
	protected override bool PCCJOMNBKIL(string PADDIEKMDDH, [Out] TEnum BNECONOIKOE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class LOIACFNIECN
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly Dictionary<Type, BBHLDDPBCFL> DGGFCFMFJEG;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8494DC0", Offset = "0x8493BC0", VA = "0x188494DC0")]
	public static BBHLDDPBCFL CLNLANNMJEH(Type LHLKEHGDINE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class DNABAFNPFED<T> : KKBKGFKIBLB<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3B96AE0", Offset = "0x3B958E0", VA = "0x183B96AE0", Slot = "9")]
	public override string NEJFHFKCOKJ(T PADDIEKMDDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6E1A160", Offset = "0x6E18F60", VA = "0x186E1A160", Slot = "10")]
	protected override bool PCCJOMNBKIL(string PADDIEKMDDH, [Out] T BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x47F8B80", Offset = "0x47F7980", VA = "0x1847F8B80")]
	public DNABAFNPFED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class EINADHOEKPB<TCollection, T> : KKBKGFKIBLB<TCollection> where TCollection : IEnumerable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly FOKBKGDLDMH<T> FGJJOIPMBAI;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x48298A0", Offset = "0x48286A0", VA = "0x1848298A0")]
	protected EINADHOEKPB(FOKBKGDLDMH<T> FGJJOIPMBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x48263B0", Offset = "0x48251B0", VA = "0x1848263B0", Slot = "9")]
	public override string NEJFHFKCOKJ(TCollection PADDIEKMDDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4826C70", Offset = "0x4825A70", VA = "0x184826C70", Slot = "10")]
	protected override bool PCCJOMNBKIL(string PADDIEKMDDH, [Out] TCollection BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract TCollection HGJHKMMJPON(IEnumerable<T> MJEJLMFOAGD);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x48260E0", Offset = "0x4824EE0", VA = "0x1848260E0", Slot = "12")]
	internal virtual IEnumerable<string> EOKMAJEJJHA(string PADDIEKMDDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4825EC0", Offset = "0x4824CC0", VA = "0x184825EC0")]
	[CompilerGenerated]
	private string AEDDNFJNFPM(T FPJNLHKNPEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class AKFPHDFIKID<T> : EINADHOEKPB<T[], T>
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x50B4240", Offset = "0x50B3040", VA = "0x1850B4240")]
	[Preserve]
	public AKFPHDFIKID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4C88B70", Offset = "0x4C87970", VA = "0x184C88B70")]
	[Preserve]
	public AKFPHDFIKID(FOKBKGDLDMH<T> FGJJOIPMBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x50B41C0", Offset = "0x50B2FC0", VA = "0x1850B41C0", Slot = "11")]
	protected override T[] HGJHKMMJPON(IEnumerable<T> MJEJLMFOAGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class CAMNNMEBFCE<T> : EINADHOEKPB<List<T>, T>
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x50B4240", Offset = "0x50B3040", VA = "0x1850B4240")]
	[Preserve]
	public CAMNNMEBFCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4C88B70", Offset = "0x4C87970", VA = "0x184C88B70")]
	[Preserve]
	public CAMNNMEBFCE([Optional] FOKBKGDLDMH<T> FGJJOIPMBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x66FC260", Offset = "0x66FB060", VA = "0x1866FC260", Slot = "11")]
	protected override List<T> HGJHKMMJPON(IEnumerable<T> MJEJLMFOAGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class NDLLOOEPJPM<T> : KKBKGFKIBLB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly JsonSerializerSettings? NCPFKGMMLEM;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x56C2C10", Offset = "0x56C1A10", VA = "0x1856C2C10")]
	public NDLLOOEPJPM(JsonSerializerSettings? FPGCAOFHGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x56D1930", Offset = "0x56D0730", VA = "0x1856D1930", Slot = "9")]
	public override string NEJFHFKCOKJ(T PADDIEKMDDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x56D1990", Offset = "0x56D0790", VA = "0x1856D1990", Slot = "10")]
	protected override bool PCCJOMNBKIL([NotNull] string PADDIEKMDDH, [Out] T BNECONOIKOE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class AICPLBEMDEN : KKBKGFKIBLB<byte>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8494310", Offset = "0x8493110", VA = "0x188494310", Slot = "9")]
	public override string NEJFHFKCOKJ(byte PADDIEKMDDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8494370", Offset = "0x8493170", VA = "0x188494370", Slot = "10")]
	protected override bool PCCJOMNBKIL(string PADDIEKMDDH, [Out] byte BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8494400", Offset = "0x8493200", VA = "0x188494400")]
	public AICPLBEMDEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class PCJFBLGGOMA : KKBKGFKIBLB<short>
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8495950", Offset = "0x8494750", VA = "0x188495950", Slot = "9")]
	public override string NEJFHFKCOKJ(short PADDIEKMDDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x84959B0", Offset = "0x84947B0", VA = "0x1884959B0", Slot = "10")]
	protected override bool PCCJOMNBKIL(string PADDIEKMDDH, [Out] short BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8495A50", Offset = "0x8494850", VA = "0x188495A50")]
	public PCJFBLGGOMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal class OIHDPDIGOOD : KKBKGFKIBLB<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x84957B0", Offset = "0x84945B0", VA = "0x1884957B0", Slot = "9")]
	public override string NEJFHFKCOKJ(ushort PADDIEKMDDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8495810", Offset = "0x8494610", VA = "0x188495810", Slot = "10")]
	protected override bool PCCJOMNBKIL(string PADDIEKMDDH, [Out] ushort BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x84958B0", Offset = "0x84946B0", VA = "0x1884958B0")]
	public OIHDPDIGOOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class DMBEFIPFGOH : KKBKGFKIBLB<int>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x84946A0", Offset = "0x84934A0", VA = "0x1884946A0", Slot = "9")]
	public override string NEJFHFKCOKJ(int PADDIEKMDDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8494700", Offset = "0x8493500", VA = "0x188494700", Slot = "10")]
	protected override bool PCCJOMNBKIL(string PADDIEKMDDH, [Out] int BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8494790", Offset = "0x8493590", VA = "0x188494790")]
	public DMBEFIPFGOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class KPLLGNJPLIC : KKBKGFKIBLB<uint>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8494C90", Offset = "0x8493A90", VA = "0x188494C90", Slot = "9")]
	public override string NEJFHFKCOKJ(uint PADDIEKMDDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8494CF0", Offset = "0x8493AF0", VA = "0x188494CF0", Slot = "10")]
	protected override bool PCCJOMNBKIL(string PADDIEKMDDH, [Out] uint BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8494D80", Offset = "0x8493B80", VA = "0x188494D80")]
	public KPLLGNJPLIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class NMKLDJGPKDC : KKBKGFKIBLB<long>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8495670", Offset = "0x8494470", VA = "0x188495670", Slot = "9")]
	public override string NEJFHFKCOKJ(long PADDIEKMDDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x84956D0", Offset = "0x84944D0", VA = "0x1884956D0", Slot = "10")]
	protected override bool PCCJOMNBKIL(string PADDIEKMDDH, [Out] long BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8495770", Offset = "0x8494570", VA = "0x188495770")]
	public NMKLDJGPKDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class MHONDAKIBLM : KKBKGFKIBLB<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8495530", Offset = "0x8494330", VA = "0x188495530", Slot = "9")]
	public override string NEJFHFKCOKJ(ulong PADDIEKMDDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8495590", Offset = "0x8494390", VA = "0x188495590", Slot = "10")]
	protected override bool PCCJOMNBKIL(string PADDIEKMDDH, [Out] ulong BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8495630", Offset = "0x8494430", VA = "0x188495630")]
	public MHONDAKIBLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class FHACENHAIEC : KKBKGFKIBLB<float>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8494880", Offset = "0x8493680", VA = "0x188494880", Slot = "9")]
	public override string NEJFHFKCOKJ(float PADDIEKMDDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x84948F0", Offset = "0x84936F0", VA = "0x1884948F0", Slot = "10")]
	protected override bool PCCJOMNBKIL(string PADDIEKMDDH, [Out] float BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8494980", Offset = "0x8493780", VA = "0x188494980")]
	public FHACENHAIEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface BBHLDDPBCFL
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string KAMJPMAPFIK(object PADDIEKMDDH);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EIADIFCKGHP([CanBeNull] string PADDIEKMDDH, [Out] object BNECONOIKOE);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface FOKBKGDLDMH<T> : BBHLDDPBCFL
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string NEJFHFKCOKJ(T PADDIEKMDDH);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LHFNPLJCOCP([CanBeNull] string PADDIEKMDDH, [Out] T BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T NDJAPOOMCBB([CanBeNull] string PADDIEKMDDH, [Optional] T JILABBLHNAO);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class KKBKGFKIBLB<T> : FOKBKGDLDMH<T>, BBHLDDPBCFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Type JFDOICANDCD;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x52E3F60", Offset = "0x52E2D60", VA = "0x1852E3F60")]
	protected KKBKGFKIBLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x52E2DB0", Offset = "0x52E1BB0", VA = "0x1852E2DB0")]
	private T BKOKKEHLCAD(object MKPNGAKJFMP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract string NEJFHFKCOKJ(T PADDIEKMDDH);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x52E3720", Offset = "0x52E2520", VA = "0x1852E3720", Slot = "7")]
	public string KAMJPMAPFIK(object PADDIEKMDDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x52E3A00", Offset = "0x52E2800", VA = "0x1852E3A00", Slot = "5")]
	public bool LHFNPLJCOCP(string PADDIEKMDDH, [Out] T BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool PCCJOMNBKIL([NotNull] string PADDIEKMDDH, [Out] T BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x52E3480", Offset = "0x52E2280", VA = "0x1852E3480", Slot = "8")]
	private bool HBPBIPDJIBD(string PADDIEKMDDH, [Out] object BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x52E3A20", Offset = "0x52E2820", VA = "0x1852E3A20", Slot = "6")]
	public T NDJAPOOMCBB(string PADDIEKMDDH, [Optional] T JILABBLHNAO)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class KDKJFADNGCM<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static FOKBKGDLDMH<T> CLGJEJAIGBE
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4C87CF0", Offset = "0x4C86AF0", VA = "0x184C87CF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x41F9780", Offset = "0x41F8580", VA = "0x1841F9780")]
	public static FOKBKGDLDMH<TSerialized> EHMGAPJLEOG<TSerialized>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x52ADF00", Offset = "0x52ACD00", VA = "0x1852ADF00")]
	public static BBHLDDPBCFL EHMGAPJLEOG(Type OAINHPKFNHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x52C2B00", Offset = "0x52C1900", VA = "0x1852C2B00")]
	private static BBHLDDPBCFL GFMDGGGEDKL(Type JJONDEPPKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x52B9970", Offset = "0x52B8770", VA = "0x1852B9970")]
	private static BBHLDDPBCFL FBHJDLNFEKG(Type JJONDEPPKBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class DCCEBJHOPLI<TCollection> : EINADHOEKPB<TCollection, string> where TCollection : IEnumerable<string>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class IFBFDPKOKMM : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
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
		public DCCEBJHOPLI<TCollection> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private BAEBDIENJAP<StringBuilder> <_>5__2;

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
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xF9A0D0", Offset = "0xF98ED0", VA = "0x180F9A0D0")]
		[DebuggerHidden]
		public IFBFDPKOKMM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4D2A9A0", Offset = "0x4D297A0", VA = "0x184D2A9A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4F18E80", Offset = "0x4F17C80", VA = "0x184F18E80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4F18E30", Offset = "0x4F17C30", VA = "0x184F18E30")]
		private void KHMMOEFKMMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4F193B0", Offset = "0x4F181B0", VA = "0x184F193B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x4F192E0", Offset = "0x4F180E0", VA = "0x184F192E0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x4D8F050", Offset = "0x4D8DE50", VA = "0x184D8F050", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool HCMLCIILLHI;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6DC6190", Offset = "0x6DC4F90", VA = "0x186DC6190")]
	protected DCCEBJHOPLI(bool HCMLCIILLHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6DC5F30", Offset = "0x6DC4D30", VA = "0x186DC5F30", Slot = "9")]
	public override string NEJFHFKCOKJ(TCollection PADDIEKMDDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6DC5E00", Offset = "0x6DC4C00", VA = "0x186DC5E00", Slot = "12")]
	[IteratorStateMachine(typeof(DCCEBJHOPLI<>.IFBFDPKOKMM))]
	internal override IEnumerable<string> EOKMAJEJJHA(string PADDIEKMDDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6DC5EB0", Offset = "0x6DC4CB0", VA = "0x186DC5EB0")]
	[CompilerGenerated]
	internal static string GJJLCNGOPLD(StringBuilder JJKILOJLKCI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class PPCIAMACLAP : DCCEBJHOPLI<List<string>>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8495B20", Offset = "0x8494920", VA = "0x188495B20")]
	[Preserve]
	public PPCIAMACLAP(bool HCMLCIILLHI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8495A90", Offset = "0x8494890", VA = "0x188495A90", Slot = "11")]
	protected override List<string> HGJHKMMJPON(IEnumerable<string> MJEJLMFOAGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class EMOFMGKDFMB : DCCEBJHOPLI<string[]>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8494830", Offset = "0x8493630", VA = "0x188494830")]
	[Preserve]
	public EMOFMGKDFMB(bool HCMLCIILLHI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x84947D0", Offset = "0x84935D0", VA = "0x1884947D0", Slot = "11")]
	protected override string[] HGJHKMMJPON(IEnumerable<string> MJEJLMFOAGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class PAKJNKCGGHM : KKBKGFKIBLB<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xAE0DD0", Offset = "0xADFBD0", VA = "0x180AE0DD0", Slot = "9")]
	public override string NEJFHFKCOKJ(string PADDIEKMDDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x84958F0", Offset = "0x84946F0", VA = "0x1884958F0", Slot = "10")]
	protected override bool PCCJOMNBKIL(string PADDIEKMDDH, [Out] string BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8495910", Offset = "0x8494710", VA = "0x188495910")]
	public PAKJNKCGGHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class GNGHMKAOFBH : KKBKGFKIBLB<TimeSpan>
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x84949C0", Offset = "0x84937C0", VA = "0x1884949C0", Slot = "9")]
	public override string NEJFHFKCOKJ(TimeSpan PADDIEKMDDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8494AE0", Offset = "0x84938E0", VA = "0x188494AE0", Slot = "10")]
	protected override bool PCCJOMNBKIL(string PADDIEKMDDH, [Out] TimeSpan BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8494C50", Offset = "0x8493A50", VA = "0x188494C50")]
	public GNGHMKAOFBH()
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
