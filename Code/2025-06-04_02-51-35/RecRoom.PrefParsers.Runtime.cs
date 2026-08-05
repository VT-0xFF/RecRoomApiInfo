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
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA536D0", Offset = "0xA51ED0", VA = "0x180A536D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA53710", Offset = "0xA51F10", VA = "0x180A53710")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class OCGKFAINHLI : ENJIDLEHKLE<bool>
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8361C20", Offset = "0x8360420", VA = "0x188361C20", Slot = "9")]
	public override string GJCNJFECIPF(bool FNFJALHKEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8361C70", Offset = "0x8360470", VA = "0x188361C70", Slot = "10")]
	protected override bool KDCGPHJJMAE(string FNFJALHKEGF, [Out] bool MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8361CD0", Offset = "0x83604D0", VA = "0x188361CD0")]
	public OCGKFAINHLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class CJGANOCJHFJ : ENJIDLEHKLE<DateTime>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8360E30", Offset = "0x835F630", VA = "0x188360E30", Slot = "9")]
	public override string GJCNJFECIPF(DateTime FNFJALHKEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8360EC0", Offset = "0x835F6C0", VA = "0x188360EC0", Slot = "10")]
	protected override bool KDCGPHJJMAE(string FNFJALHKEGF, [Out] DateTime MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8360F60", Offset = "0x835F760", VA = "0x188360F60")]
	public CJGANOCJHFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class FFNICKFJBNF<TEnum> : ENJIDLEHKLE<TEnum> where TEnum : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly Type LHEHOGAPCOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool DGCCAICFENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly TEnum[] IFMNLKCJNMD;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4BAA1C0", Offset = "0x4BA89C0", VA = "0x184BAA1C0")]
	[Preserve]
	public FFNICKFJBNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4BA9DA0", Offset = "0x4BA85A0", VA = "0x184BA9DA0", Slot = "9")]
	public override string GJCNJFECIPF(TEnum FNFJALHKEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4BA9FF0", Offset = "0x4BA87F0", VA = "0x184BA9FF0", Slot = "10")]
	protected override bool KDCGPHJJMAE(string FNFJALHKEGF, [Out] TEnum MGONBEDEDON)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class CNFMGDHKGNE<TEnum> : ENJIDLEHKLE<TEnum> where TEnum : Enum
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Type LHEHOGAPCOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly MEGEJHDMPOJ CFCOFCCHACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly bool DGCCAICFENJ;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x679B760", Offset = "0x6799F60", VA = "0x18679B760")]
	[Preserve]
	public CNFMGDHKGNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x679B0A0", Offset = "0x67998A0", VA = "0x18679B0A0", Slot = "9")]
	public override string GJCNJFECIPF(TEnum FNFJALHKEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x679B500", Offset = "0x6799D00", VA = "0x18679B500", Slot = "10")]
	protected override bool KDCGPHJJMAE(string FNFJALHKEGF, [Out] TEnum MGONBEDEDON)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class AJHGKEACLPE
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly Dictionary<Type, MEGEJHDMPOJ> OCJJOMEJIAE;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x83605A0", Offset = "0x835EDA0", VA = "0x1883605A0")]
	public static MEGEJHDMPOJ DGDLHEEJFFM(Type JFNNMPPENHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class CPJNNNALAJN<T> : ENJIDLEHKLE<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x39CE410", Offset = "0x39CCC10", VA = "0x1839CE410", Slot = "9")]
	public override string GJCNJFECIPF(T FNFJALHKEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x68913D0", Offset = "0x688FBD0", VA = "0x1868913D0", Slot = "10")]
	protected override bool KDCGPHJJMAE(string FNFJALHKEGF, [Out] T MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x468BF60", Offset = "0x468A760", VA = "0x18468BF60")]
	public CPJNNNALAJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class PJICIJLEEPE<TCollection, T> : ENJIDLEHKLE<TCollection> where TCollection : IEnumerable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly HFHEOAFFOKE<T> OCJKACLDOKM;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x58B7350", Offset = "0x58B5B50", VA = "0x1858B7350")]
	protected PJICIJLEEPE(HFHEOAFFOKE<T> OCJKACLDOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x58B4090", Offset = "0x58B2890", VA = "0x1858B4090", Slot = "9")]
	public override string GJCNJFECIPF(TCollection FNFJALHKEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x58B4D20", Offset = "0x58B3520", VA = "0x1858B4D20", Slot = "10")]
	protected override bool KDCGPHJJMAE(string FNFJALHKEGF, [Out] TCollection MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract TCollection HBOADGKIGGE(IEnumerable<T> ECOCMLPNFDM);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x58B7320", Offset = "0x58B5B20", VA = "0x1858B7320", Slot = "12")]
	internal virtual IEnumerable<string> PDLLDLBIJJL(string FNFJALHKEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x58B41B0", Offset = "0x58B29B0", VA = "0x1858B41B0")]
	[CompilerGenerated]
	private string ILBINFHFLPB(T KENANDNBOGI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class DIINNBFDLKF<T> : PJICIJLEEPE<T[], T>
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4C87030", Offset = "0x4C85830", VA = "0x184C87030")]
	[Preserve]
	public DIINNBFDLKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x46F1D30", Offset = "0x46F0530", VA = "0x1846F1D30")]
	[Preserve]
	public DIINNBFDLKF(HFHEOAFFOKE<T> OCJKACLDOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6D08770", Offset = "0x6D06F70", VA = "0x186D08770", Slot = "11")]
	protected override T[] HBOADGKIGGE(IEnumerable<T> ECOCMLPNFDM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class GFNMNPDFLPP<T> : PJICIJLEEPE<List<T>, T>
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4C87030", Offset = "0x4C85830", VA = "0x184C87030")]
	[Preserve]
	public GFNMNPDFLPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x46F1D30", Offset = "0x46F0530", VA = "0x1846F1D30")]
	[Preserve]
	public GFNMNPDFLPP([Optional] HFHEOAFFOKE<T> OCJKACLDOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4C86F80", Offset = "0x4C85780", VA = "0x184C86F80", Slot = "11")]
	protected override List<T> HBOADGKIGGE(IEnumerable<T> ECOCMLPNFDM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class LOFFLHGNHIA<T> : ENJIDLEHKLE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly JsonSerializerSettings? IPNCPLDMFPO;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x533F0D0", Offset = "0x533D8D0", VA = "0x18533F0D0")]
	public LOFFLHGNHIA(JsonSerializerSettings? MBAIIOBKCNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x533EFA0", Offset = "0x533D7A0", VA = "0x18533EFA0", Slot = "9")]
	public override string GJCNJFECIPF(T FNFJALHKEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x533F000", Offset = "0x533D800", VA = "0x18533F000", Slot = "10")]
	protected override bool KDCGPHJJMAE([NotNull] string FNFJALHKEGF, [Out] T MGONBEDEDON)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class AKJEBFGLHFI : ENJIDLEHKLE<byte>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8360D00", Offset = "0x835F500", VA = "0x188360D00", Slot = "9")]
	public override string GJCNJFECIPF(byte FNFJALHKEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8360D60", Offset = "0x835F560", VA = "0x188360D60", Slot = "10")]
	protected override bool KDCGPHJJMAE(string FNFJALHKEGF, [Out] byte MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8360DF0", Offset = "0x835F5F0", VA = "0x188360DF0")]
	public AKJEBFGLHFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class LPOLBCPJCHH : ENJIDLEHKLE<short>
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8361A80", Offset = "0x8360280", VA = "0x188361A80", Slot = "9")]
	public override string GJCNJFECIPF(short FNFJALHKEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8361AE0", Offset = "0x83602E0", VA = "0x188361AE0", Slot = "10")]
	protected override bool KDCGPHJJMAE(string FNFJALHKEGF, [Out] short MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8361B80", Offset = "0x8360380", VA = "0x188361B80")]
	public LPOLBCPJCHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal class JMCMKJIJBDA : ENJIDLEHKLE<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x83616E0", Offset = "0x835FEE0", VA = "0x1883616E0", Slot = "9")]
	public override string GJCNJFECIPF(ushort FNFJALHKEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8361740", Offset = "0x835FF40", VA = "0x188361740", Slot = "10")]
	protected override bool KDCGPHJJMAE(string FNFJALHKEGF, [Out] ushort MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x83617E0", Offset = "0x835FFE0", VA = "0x1883617E0")]
	public JMCMKJIJBDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class KOIOINDBHDB : ENJIDLEHKLE<int>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8361950", Offset = "0x8360150", VA = "0x188361950", Slot = "9")]
	public override string GJCNJFECIPF(int FNFJALHKEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x83619B0", Offset = "0x83601B0", VA = "0x1883619B0", Slot = "10")]
	protected override bool KDCGPHJJMAE(string FNFJALHKEGF, [Out] int MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8361A40", Offset = "0x8360240", VA = "0x188361A40")]
	public KOIOINDBHDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class KFKMLMNKIHA : ENJIDLEHKLE<uint>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8361820", Offset = "0x8360020", VA = "0x188361820", Slot = "9")]
	public override string GJCNJFECIPF(uint FNFJALHKEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8361880", Offset = "0x8360080", VA = "0x188361880", Slot = "10")]
	protected override bool KDCGPHJJMAE(string FNFJALHKEGF, [Out] uint MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8361910", Offset = "0x8360110", VA = "0x188361910")]
	public KFKMLMNKIHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class HLJENJMNIEO : ENJIDLEHKLE<long>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x83614F0", Offset = "0x835FCF0", VA = "0x1883614F0", Slot = "9")]
	public override string GJCNJFECIPF(long FNFJALHKEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8361550", Offset = "0x835FD50", VA = "0x188361550", Slot = "10")]
	protected override bool KDCGPHJJMAE(string FNFJALHKEGF, [Out] long MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x83615F0", Offset = "0x835FDF0", VA = "0x1883615F0")]
	public HLJENJMNIEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class DFPKAJIEANA : ENJIDLEHKLE<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8360FA0", Offset = "0x835F7A0", VA = "0x188360FA0", Slot = "9")]
	public override string GJCNJFECIPF(ulong FNFJALHKEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8361000", Offset = "0x835F800", VA = "0x188361000", Slot = "10")]
	protected override bool KDCGPHJJMAE(string FNFJALHKEGF, [Out] ulong MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x83610A0", Offset = "0x835F8A0", VA = "0x1883610A0")]
	public DFPKAJIEANA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class GIBPDLPLECI : ENJIDLEHKLE<float>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x83613B0", Offset = "0x835FBB0", VA = "0x1883613B0", Slot = "9")]
	public override string GJCNJFECIPF(float FNFJALHKEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8361420", Offset = "0x835FC20", VA = "0x188361420", Slot = "10")]
	protected override bool KDCGPHJJMAE(string FNFJALHKEGF, [Out] float MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x83614B0", Offset = "0x835FCB0", VA = "0x1883614B0")]
	public GIBPDLPLECI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface MEGEJHDMPOJ
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string NDMCINMFJFI(object FNFJALHKEGF);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ABBMBLAEGLL([CanBeNull] string FNFJALHKEGF, [Out] object MGONBEDEDON);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface HFHEOAFFOKE<T> : MEGEJHDMPOJ
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string GJCNJFECIPF(T FNFJALHKEGF);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MGMJPBJPHJO([CanBeNull] string FNFJALHKEGF, [Out] T MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T IMFMHFJBBBD([CanBeNull] string FNFJALHKEGF, [Optional] T GJPLADDCFJL);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class ENJIDLEHKLE<T> : HFHEOAFFOKE<T>, MEGEJHDMPOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Type FOCNDJJFKLH;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x474FFE0", Offset = "0x474E7E0", VA = "0x18474FFE0")]
	protected ENJIDLEHKLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x474F160", Offset = "0x474D960", VA = "0x18474F160")]
	private T KEMPJHBMHKM(object HPLLAPMNIJF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract string GJCNJFECIPF(T FNFJALHKEGF);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x474FCE0", Offset = "0x474E4E0", VA = "0x18474FCE0", Slot = "7")]
	public string NDMCINMFJFI(object FNFJALHKEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x474FBE0", Offset = "0x474E3E0", VA = "0x18474FBE0", Slot = "5")]
	public bool MGMJPBJPHJO(string FNFJALHKEGF, [Out] T MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool KDCGPHJJMAE([NotNull] string FNFJALHKEGF, [Out] T MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x474F770", Offset = "0x474DF70", VA = "0x18474F770", Slot = "8")]
	private bool KOJPALCEJAF(string FNFJALHKEGF, [Out] object MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x474EC60", Offset = "0x474D460", VA = "0x18474EC60", Slot = "6")]
	public T IMFMHFJBBBD(string FNFJALHKEGF, [Optional] T GJPLADDCFJL)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class JCDNIPNDNEN<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static HFHEOAFFOKE<T> JMOEBDABFID
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4B91E60", Offset = "0x4B90660", VA = "0x184B91E60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x417D4E0", Offset = "0x417BCE0", VA = "0x18417D4E0")]
	public static HFHEOAFFOKE<TSerialized> BIJENPIKLFC<TSerialized>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5097D20", Offset = "0x5096520", VA = "0x185097D20")]
	public static MEGEJHDMPOJ BIJENPIKLFC(Type HHAIIMKCAEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5092120", Offset = "0x5090920", VA = "0x185092120")]
	private static MEGEJHDMPOJ BICBGEOOMJL(Type FBJHAGEDEEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5099A80", Offset = "0x5098280", VA = "0x185099A80")]
	private static MEGEJHDMPOJ CHDKOCLFNIA(Type FBJHAGEDEEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class MJPCGPFBMCB<TCollection> : PJICIJLEEPE<TCollection, string> where TCollection : IEnumerable<string>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class NLBHFLAJLDE : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
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
		public MJPCGPFBMCB<TCollection> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private JJJEOHECFLJ<StringBuilder> <_>5__2;

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
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xF10EA0", Offset = "0xF0F6A0", VA = "0x180F10EA0")]
		[DebuggerHidden]
		public NLBHFLAJLDE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4C12A60", Offset = "0x4C11260", VA = "0x184C12A60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x55D6530", Offset = "0x55D4D30", VA = "0x1855D6530", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x55D64E0", Offset = "0x55D4CE0", VA = "0x1855D64E0")]
		private void EGKKBNFIFOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x55D6A90", Offset = "0x55D5290", VA = "0x1855D6A90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x55D69B0", Offset = "0x55D51B0", VA = "0x1855D69B0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5168100", Offset = "0x5166900", VA = "0x185168100", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool IEMNMCPMEOA;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5546DA0", Offset = "0x55455A0", VA = "0x185546DA0")]
	protected MJPCGPFBMCB(bool IEMNMCPMEOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5546A00", Offset = "0x5545200", VA = "0x185546A00", Slot = "9")]
	public override string GJCNJFECIPF(TCollection FNFJALHKEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5546CE0", Offset = "0x55454E0", VA = "0x185546CE0", Slot = "12")]
	[IteratorStateMachine(typeof(MJPCGPFBMCB<>.NLBHFLAJLDE))]
	internal override IEnumerable<string> PDLLDLBIJJL(string FNFJALHKEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5546C60", Offset = "0x5545460", VA = "0x185546C60")]
	[CompilerGenerated]
	internal static string JCOJIDKADMD(StringBuilder PDGAOLJEHNA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class ONCOFIMIJON : MJPCGPFBMCB<List<string>>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8361DA0", Offset = "0x83605A0", VA = "0x188361DA0")]
	[Preserve]
	public ONCOFIMIJON(bool IEMNMCPMEOA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8361D10", Offset = "0x8360510", VA = "0x188361D10", Slot = "11")]
	protected override List<string> HBOADGKIGGE(IEnumerable<string> ECOCMLPNFDM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class IILGKDLPAEB : MJPCGPFBMCB<string[]>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8361690", Offset = "0x835FE90", VA = "0x188361690")]
	[Preserve]
	public IILGKDLPAEB(bool IEMNMCPMEOA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8361630", Offset = "0x835FE30", VA = "0x188361630", Slot = "11")]
	protected override string[] HBOADGKIGGE(IEnumerable<string> ECOCMLPNFDM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class NGPBJKJCMDF : ENJIDLEHKLE<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xAA1C90", Offset = "0xAA0490", VA = "0x180AA1C90", Slot = "9")]
	public override string GJCNJFECIPF(string FNFJALHKEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8361BC0", Offset = "0x83603C0", VA = "0x188361BC0", Slot = "10")]
	protected override bool KDCGPHJJMAE(string FNFJALHKEGF, [Out] string MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8361BE0", Offset = "0x83603E0", VA = "0x188361BE0")]
	public NGPBJKJCMDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class FIMDOKAONDL : ENJIDLEHKLE<TimeSpan>
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x83610E0", Offset = "0x835F8E0", VA = "0x1883610E0", Slot = "9")]
	public override string GJCNJFECIPF(TimeSpan FNFJALHKEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8361200", Offset = "0x835FA00", VA = "0x188361200", Slot = "10")]
	protected override bool KDCGPHJJMAE(string FNFJALHKEGF, [Out] TimeSpan MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8361370", Offset = "0x835FB70", VA = "0x188361370")]
	public FIMDOKAONDL()
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
