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
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA99B00", Offset = "0xA98F00", VA = "0x180A99B00")]
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
		[Cpp2IlInjected.Address(RVA = "0xA99B40", Offset = "0xA98F40", VA = "0x180A99B40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class DGBJFADGFNB : HPHPBBLCFKI<bool>
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x868DA70", Offset = "0x868CE70", VA = "0x18868DA70", Slot = "9")]
	public override string COFPFOKABJF(bool MICKAKKPGLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x868DAC0", Offset = "0x868CEC0", VA = "0x18868DAC0", Slot = "10")]
	protected override bool KIPBFLFIHHN(string MICKAKKPGLH, [Out] bool CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x868DB20", Offset = "0x868CF20", VA = "0x18868DB20")]
	public DGBJFADGFNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class FIPLEMHOIMG : HPHPBBLCFKI<DateTime>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x868DC90", Offset = "0x868D090", VA = "0x18868DC90", Slot = "9")]
	public override string COFPFOKABJF(DateTime MICKAKKPGLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x868DD20", Offset = "0x868D120", VA = "0x18868DD20", Slot = "10")]
	protected override bool KIPBFLFIHHN(string MICKAKKPGLH, [Out] DateTime CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x868DDC0", Offset = "0x868D1C0", VA = "0x18868DDC0")]
	public FIPLEMHOIMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class DHBFFHBBNNE<TEnum> : HPHPBBLCFKI<TEnum> where TEnum : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly Type MELDCCHPAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool KEDPPHGDNPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly TEnum[] EJCCOPPBIIG;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4552A60", Offset = "0x4551E60", VA = "0x184552A60")]
	[Preserve]
	public DHBFFHBBNNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x45526B0", Offset = "0x4551AB0", VA = "0x1845526B0", Slot = "9")]
	public override string COFPFOKABJF(TEnum MICKAKKPGLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x45528A0", Offset = "0x4551CA0", VA = "0x1845528A0", Slot = "10")]
	protected override bool KIPBFLFIHHN(string MICKAKKPGLH, [Out] TEnum CBMEHPPMEEA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class NCOOBCEHIFO<TEnum> : HPHPBBLCFKI<TEnum> where TEnum : Enum
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Type MELDCCHPAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly MDPNIGLOFAO JJBMLPOLIHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly bool KEDPPHGDNPL;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x57ED150", Offset = "0x57EC550", VA = "0x1857ED150")]
	[Preserve]
	public NCOOBCEHIFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x57ECAA0", Offset = "0x57EBEA0", VA = "0x1857ECAA0", Slot = "9")]
	public override string COFPFOKABJF(TEnum MICKAKKPGLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x57ECC40", Offset = "0x57EC040", VA = "0x1857ECC40", Slot = "10")]
	protected override bool KIPBFLFIHHN(string MICKAKKPGLH, [Out] TEnum CBMEHPPMEEA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class ODHGKJFHEOO
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly Dictionary<Type, MDPNIGLOFAO> CNOPPGJPJDA;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x868E630", Offset = "0x868DA30", VA = "0x18868E630")]
	public static MDPNIGLOFAO IKOHOIEOHOB(Type GOOBMBAMKMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class KFCIIIJLAKN<T> : HPHPBBLCFKI<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x31E30F0", Offset = "0x31E24F0", VA = "0x1831E30F0", Slot = "9")]
	public override string COFPFOKABJF(T MICKAKKPGLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x54472C0", Offset = "0x54466C0", VA = "0x1854472C0", Slot = "10")]
	protected override bool KIPBFLFIHHN(string MICKAKKPGLH, [Out] T CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x49A8300", Offset = "0x49A7700", VA = "0x1849A8300")]
	public KFCIIIJLAKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class BNAGGIHAMLF<TCollection, T> : HPHPBBLCFKI<TCollection> where TCollection : IEnumerable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly ILLCDOEKCCK<T> JOLLEHIPBGD;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x68E87E0", Offset = "0x68E7BE0", VA = "0x1868E87E0")]
	protected BNAGGIHAMLF(ILLCDOEKCCK<T> JOLLEHIPBGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x68E52F0", Offset = "0x68E46F0", VA = "0x1868E52F0", Slot = "9")]
	public override string COFPFOKABJF(TCollection MICKAKKPGLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x68E8490", Offset = "0x68E7890", VA = "0x1868E8490", Slot = "10")]
	protected override bool KIPBFLFIHHN(string MICKAKKPGLH, [Out] TCollection CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract TCollection OLMAOHHKMMA(IEnumerable<T> AHGBOFMNHGN);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x68E5C90", Offset = "0x68E5090", VA = "0x1868E5C90", Slot = "12")]
	internal virtual IEnumerable<string> JKCDIOHDJMA(string MICKAKKPGLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x68E4E10", Offset = "0x68E4210", VA = "0x1868E4E10")]
	[CompilerGenerated]
	private string ADEMLMHOLAN(T EMOJJIEJAKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class EDDBCHAGHPO<T> : BNAGGIHAMLF<T[], T>
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x49B64C0", Offset = "0x49B58C0", VA = "0x1849B64C0")]
	[Preserve]
	public EDDBCHAGHPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x49B64A0", Offset = "0x49B58A0", VA = "0x1849B64A0")]
	[Preserve]
	public EDDBCHAGHPO(ILLCDOEKCCK<T> JOLLEHIPBGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x49B6430", Offset = "0x49B5830", VA = "0x1849B6430", Slot = "11")]
	protected override T[] OLMAOHHKMMA(IEnumerable<T> AHGBOFMNHGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class JDFHMHBJILF<T> : BNAGGIHAMLF<List<T>, T>
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x49B64C0", Offset = "0x49B58C0", VA = "0x1849B64C0")]
	[Preserve]
	public JDFHMHBJILF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x49B64A0", Offset = "0x49B58A0", VA = "0x1849B64A0")]
	[Preserve]
	public JDFHMHBJILF([Optional] ILLCDOEKCCK<T> JOLLEHIPBGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5306020", Offset = "0x5305420", VA = "0x185306020", Slot = "11")]
	protected override List<T> OLMAOHHKMMA(IEnumerable<T> AHGBOFMNHGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class GFEIOJNDACC<T> : HPHPBBLCFKI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly JsonSerializerSettings? EFPOMNCHJCD;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4F4DFD0", Offset = "0x4F4D3D0", VA = "0x184F4DFD0")]
	public GFEIOJNDACC(JsonSerializerSettings? OFPKJPDCHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4F4DEB0", Offset = "0x4F4D2B0", VA = "0x184F4DEB0", Slot = "9")]
	public override string COFPFOKABJF(T MICKAKKPGLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4F4DF10", Offset = "0x4F4D310", VA = "0x184F4DF10", Slot = "10")]
	protected override bool KIPBFLFIHHN([NotNull] string MICKAKKPGLH, [Out] T CBMEHPPMEEA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class EMBEBJMHOAG : HPHPBBLCFKI<byte>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x868DB60", Offset = "0x868CF60", VA = "0x18868DB60", Slot = "9")]
	public override string COFPFOKABJF(byte MICKAKKPGLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x868DBC0", Offset = "0x868CFC0", VA = "0x18868DBC0", Slot = "10")]
	protected override bool KIPBFLFIHHN(string MICKAKKPGLH, [Out] byte CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x868DC50", Offset = "0x868D050", VA = "0x18868DC50")]
	public EMBEBJMHOAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class HOOIKEFEOFM : HPHPBBLCFKI<short>
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x868DE00", Offset = "0x868D200", VA = "0x18868DE00", Slot = "9")]
	public override string COFPFOKABJF(short MICKAKKPGLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x868DE60", Offset = "0x868D260", VA = "0x18868DE60", Slot = "10")]
	protected override bool KIPBFLFIHHN(string MICKAKKPGLH, [Out] short CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x868DF00", Offset = "0x868D300", VA = "0x18868DF00")]
	public HOOIKEFEOFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal class CLADLMJFMFC : HPHPBBLCFKI<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x868D930", Offset = "0x868CD30", VA = "0x18868D930", Slot = "9")]
	public override string COFPFOKABJF(ushort MICKAKKPGLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x868D990", Offset = "0x868CD90", VA = "0x18868D990", Slot = "10")]
	protected override bool KIPBFLFIHHN(string MICKAKKPGLH, [Out] ushort CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x868DA30", Offset = "0x868CE30", VA = "0x18868DA30")]
	public CLADLMJFMFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class BGCILEJLKCD : HPHPBBLCFKI<int>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x868D800", Offset = "0x868CC00", VA = "0x18868D800", Slot = "9")]
	public override string COFPFOKABJF(int MICKAKKPGLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x868D860", Offset = "0x868CC60", VA = "0x18868D860", Slot = "10")]
	protected override bool KIPBFLFIHHN(string MICKAKKPGLH, [Out] int CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x868D8F0", Offset = "0x868CCF0", VA = "0x18868D8F0")]
	public BGCILEJLKCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class PPCILLDEOKE : HPHPBBLCFKI<uint>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x868EE30", Offset = "0x868E230", VA = "0x18868EE30", Slot = "9")]
	public override string COFPFOKABJF(uint MICKAKKPGLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x868EE90", Offset = "0x868E290", VA = "0x18868EE90", Slot = "10")]
	protected override bool KIPBFLFIHHN(string MICKAKKPGLH, [Out] uint CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x868EF20", Offset = "0x868E320", VA = "0x18868EF20")]
	public PPCILLDEOKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class LFJIDALHOID : HPHPBBLCFKI<long>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x868E080", Offset = "0x868D480", VA = "0x18868E080", Slot = "9")]
	public override string COFPFOKABJF(long MICKAKKPGLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x868E0E0", Offset = "0x868D4E0", VA = "0x18868E0E0", Slot = "10")]
	protected override bool KIPBFLFIHHN(string MICKAKKPGLH, [Out] long CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x868E180", Offset = "0x868D580", VA = "0x18868E180")]
	public LFJIDALHOID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class KPBAEHJAEBO : HPHPBBLCFKI<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x868DF40", Offset = "0x868D340", VA = "0x18868DF40", Slot = "9")]
	public override string COFPFOKABJF(ulong MICKAKKPGLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x868DFA0", Offset = "0x868D3A0", VA = "0x18868DFA0", Slot = "10")]
	protected override bool KIPBFLFIHHN(string MICKAKKPGLH, [Out] ulong CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x868E040", Offset = "0x868D440", VA = "0x18868E040")]
	public KPBAEHJAEBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class LOCJLFMDEBH : HPHPBBLCFKI<float>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x868E220", Offset = "0x868D620", VA = "0x18868E220", Slot = "9")]
	public override string COFPFOKABJF(float MICKAKKPGLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x868E290", Offset = "0x868D690", VA = "0x18868E290", Slot = "10")]
	protected override bool KIPBFLFIHHN(string MICKAKKPGLH, [Out] float CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x868E320", Offset = "0x868D720", VA = "0x18868E320")]
	public LOCJLFMDEBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface MDPNIGLOFAO
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string EBAALBFDCIK(object MICKAKKPGLH);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KOIKEONGFAA([CanBeNull] string MICKAKKPGLH, [Out] object CBMEHPPMEEA);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface ILLCDOEKCCK<T> : MDPNIGLOFAO
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string COFPFOKABJF(T MICKAKKPGLH);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MDNPGNBFALF([CanBeNull] string MICKAKKPGLH, [Out] T CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T JMEDPCHNDFD([CanBeNull] string MICKAKKPGLH, [Optional] T ABINAMGBLJP);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class HPHPBBLCFKI<T> : ILLCDOEKCCK<T>, MDPNIGLOFAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Type CAFOGCKLDDD;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4FF7260", Offset = "0x4FF6660", VA = "0x184FF7260")]
	protected HPHPBBLCFKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4FF6C00", Offset = "0x4FF6000", VA = "0x184FF6C00")]
	private T OEEDOHBIBFD(object DEJGDIIDCDN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract string COFPFOKABJF(T MICKAKKPGLH);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4FF5D50", Offset = "0x4FF5150", VA = "0x184FF5D50", Slot = "7")]
	public string EBAALBFDCIK(object MICKAKKPGLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4FF6880", Offset = "0x4FF5C80", VA = "0x184FF6880", Slot = "5")]
	public bool MDNPGNBFALF(string MICKAKKPGLH, [Out] T CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool KIPBFLFIHHN([NotNull] string MICKAKKPGLH, [Out] T CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4FF66B0", Offset = "0x4FF5AB0", VA = "0x184FF66B0", Slot = "8")]
	private bool LEOPHBPMFEI(string MICKAKKPGLH, [Out] object CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4FF61B0", Offset = "0x4FF55B0", VA = "0x184FF61B0", Slot = "6")]
	public T JMEDPCHNDFD(string MICKAKKPGLH, [Optional] T ABINAMGBLJP)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class FENEBPCMJIF<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static ILLCDOEKCCK<T> BCIBOEFGOGH
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4E542B0", Offset = "0x4E536B0", VA = "0x184E542B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3E8F130", Offset = "0x3E8E530", VA = "0x183E8F130")]
	public static ILLCDOEKCCK<TSerialized> LIALPAOBGJM<TSerialized>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4E83780", Offset = "0x4E82B80", VA = "0x184E83780")]
	public static MDPNIGLOFAO LIALPAOBGJM(Type LIJMNKLGNJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4E761E0", Offset = "0x4E755E0", VA = "0x184E761E0")]
	private static MDPNIGLOFAO EINFFBMCGNA(Type KADLGDIHHBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4E7D130", Offset = "0x4E7C530", VA = "0x184E7D130")]
	private static MDPNIGLOFAO LCAKPBOAAJC(Type KADLGDIHHBH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class BGGLODEHBDD<TCollection> : BNAGGIHAMLF<TCollection, string> where TCollection : IEnumerable<string>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class GFANANGDLLI : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
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
		public BGGLODEHBDD<TCollection> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private EHEHGAJNKMA<StringBuilder> <_>5__2;

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
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xFC9810", Offset = "0xFC8C10", VA = "0x180FC9810")]
		[DebuggerHidden]
		public GFANANGDLLI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4F0EBE0", Offset = "0x4F0DFE0", VA = "0x184F0EBE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4F4D530", Offset = "0x4F4C930", VA = "0x184F4D530", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4F4D4E0", Offset = "0x4F4C8E0", VA = "0x184F4D4E0")]
		private void DKMCMBPCGHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4F4DA60", Offset = "0x4F4CE60", VA = "0x184F4DA60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x4F4D980", Offset = "0x4F4CD80", VA = "0x184F4D980", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x4F4DA40", Offset = "0x4F4CE40", VA = "0x184F4DA40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool BFKCNOKPBHJ;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x654C700", Offset = "0x654BB00", VA = "0x18654C700")]
	protected BGGLODEHBDD(bool BFKCNOKPBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x654C390", Offset = "0x654B790", VA = "0x18654C390", Slot = "9")]
	public override string COFPFOKABJF(TCollection MICKAKKPGLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x654C650", Offset = "0x654BA50", VA = "0x18654C650", Slot = "12")]
	[IteratorStateMachine(typeof(BGGLODEHBDD<>.GFANANGDLLI))]
	internal override IEnumerable<string> JKCDIOHDJMA(string MICKAKKPGLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x654C5D0", Offset = "0x654B9D0", VA = "0x18654C5D0")]
	[CompilerGenerated]
	internal static string FFMPBACIDIC(StringBuilder JNKOIGEJLAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class AGIIPDJDKGP : BGGLODEHBDD<List<string>>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x868D7B0", Offset = "0x868CBB0", VA = "0x18868D7B0")]
	[Preserve]
	public AGIIPDJDKGP(bool BFKCNOKPBHJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x868D720", Offset = "0x868CB20", VA = "0x18868D720", Slot = "11")]
	protected override List<string> OLMAOHHKMMA(IEnumerable<string> AHGBOFMNHGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class OHDENHKLALJ : BGGLODEHBDD<string[]>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x868EDE0", Offset = "0x868E1E0", VA = "0x18868EDE0")]
	[Preserve]
	public OHDENHKLALJ(bool BFKCNOKPBHJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x868ED80", Offset = "0x868E180", VA = "0x18868ED80", Slot = "11")]
	protected override string[] OLMAOHHKMMA(IEnumerable<string> AHGBOFMNHGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class LIILFOGMMEN : HPHPBBLCFKI<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xAD5C60", Offset = "0xAD5060", VA = "0x180AD5C60", Slot = "9")]
	public override string COFPFOKABJF(string MICKAKKPGLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x868E1C0", Offset = "0x868D5C0", VA = "0x18868E1C0", Slot = "10")]
	protected override bool KIPBFLFIHHN(string MICKAKKPGLH, [Out] string CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x868E1E0", Offset = "0x868D5E0", VA = "0x18868E1E0")]
	public LIILFOGMMEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class NGJPBKKABHJ : HPHPBBLCFKI<TimeSpan>
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x868E360", Offset = "0x868D760", VA = "0x18868E360", Slot = "9")]
	public override string COFPFOKABJF(TimeSpan MICKAKKPGLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x868E480", Offset = "0x868D880", VA = "0x18868E480", Slot = "10")]
	protected override bool KIPBFLFIHHN(string MICKAKKPGLH, [Out] TimeSpan CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x868E5F0", Offset = "0x868D9F0", VA = "0x18868E5F0")]
	public NGJPBKKABHJ()
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
