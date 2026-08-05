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
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1B770", Offset = "0xA1A970", VA = "0x180A1B770")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1B7B0", Offset = "0xA1A9B0", VA = "0x180A1B7B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ELMHJBANOKN : BNHGMLNCOLP<bool>
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x803B940", Offset = "0x803AB40", VA = "0x18803B940", Slot = "9")]
	public override string CEBCPPBDNIB(bool EEEOGOJIPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x803B990", Offset = "0x803AB90", VA = "0x18803B990", Slot = "10")]
	protected override bool FLMCMOIELJG(string EEEOGOJIPGB, [Out] bool MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x803B9F0", Offset = "0x803ABF0", VA = "0x18803B9F0")]
	public ELMHJBANOKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class KKOLJCKIMDF : BNHGMLNCOLP<DateTime>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x803C160", Offset = "0x803B360", VA = "0x18803C160", Slot = "9")]
	public override string CEBCPPBDNIB(DateTime EEEOGOJIPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x803C1F0", Offset = "0x803B3F0", VA = "0x18803C1F0", Slot = "10")]
	protected override bool FLMCMOIELJG(string EEEOGOJIPGB, [Out] DateTime MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x803C290", Offset = "0x803B490", VA = "0x18803C290")]
	public KKOLJCKIMDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class EDOCNBPKNLI<TEnum> : BNHGMLNCOLP<TEnum> where TEnum : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly Type CIPDLJOCAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool LINPMHPBBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly TEnum[] CPMBLPBIGIH;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x452A830", Offset = "0x4529A30", VA = "0x18452A830")]
	[Preserve]
	public EDOCNBPKNLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x452A430", Offset = "0x4529630", VA = "0x18452A430", Slot = "9")]
	public override string CEBCPPBDNIB(TEnum EEEOGOJIPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x452A670", Offset = "0x4529870", VA = "0x18452A670", Slot = "10")]
	protected override bool FLMCMOIELJG(string EEEOGOJIPGB, [Out] TEnum MLCDCHNOCFI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class OEEJMMKNPFB<TEnum> : BNHGMLNCOLP<TEnum> where TEnum : Enum
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Type CIPDLJOCAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly BMJJDNJLHOM ACBMGEOKBHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly bool LINPMHPBBLK;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x54C8E80", Offset = "0x54C8080", VA = "0x1854C8E80")]
	[Preserve]
	public OEEJMMKNPFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x54C8670", Offset = "0x54C7870", VA = "0x1854C8670", Slot = "9")]
	public override string CEBCPPBDNIB(TEnum EEEOGOJIPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x54C8AC0", Offset = "0x54C7CC0", VA = "0x1854C8AC0", Slot = "10")]
	protected override bool FLMCMOIELJG(string EEEOGOJIPGB, [Out] TEnum MLCDCHNOCFI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class BEEBOAMDOJD
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly Dictionary<Type, BMJJDNJLHOM> AILIPFNJOKG;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x803AF90", Offset = "0x803A190", VA = "0x18803AF90")]
	public static BMJJDNJLHOM PHFPEPCJPCC(Type OFJAIPHFBPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class OAINHNLCBNN<T> : BNHGMLNCOLP<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x38BBC80", Offset = "0x38BAE80", VA = "0x1838BBC80", Slot = "9")]
	public override string CEBCPPBDNIB(T EEEOGOJIPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x54B6C60", Offset = "0x54B5E60", VA = "0x1854B6C60", Slot = "10")]
	protected override bool FLMCMOIELJG(string EEEOGOJIPGB, [Out] T MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4519EE0", Offset = "0x45190E0", VA = "0x184519EE0")]
	public OAINHNLCBNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class KHFJIKADCIL<TCollection, T> : BNHGMLNCOLP<TCollection> where TCollection : IEnumerable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly COFCEIGKIJD<T> JHACFAPLDKF;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x500F060", Offset = "0x500E260", VA = "0x18500F060")]
	protected KHFJIKADCIL(COFCEIGKIJD<T> JHACFAPLDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x500DC20", Offset = "0x500CE20", VA = "0x18500DC20", Slot = "9")]
	public override string CEBCPPBDNIB(TCollection EEEOGOJIPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x500E060", Offset = "0x500D260", VA = "0x18500E060", Slot = "10")]
	protected override bool FLMCMOIELJG(string EEEOGOJIPGB, [Out] TCollection MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract TCollection GPDCPHHKFKN(IEnumerable<T> JLALKPGHLDH);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x500EE20", Offset = "0x500E020", VA = "0x18500EE20", Slot = "12")]
	internal virtual IEnumerable<string> JHJCNEEEOCN(string EEEOGOJIPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x500EE50", Offset = "0x500E050", VA = "0x18500EE50")]
	[CompilerGenerated]
	private string MNKIKKDKKEC(T KOBHBJCHIOC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class MAOGDCOLEIG<T> : KHFJIKADCIL<T[], T>
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4CB5AF0", Offset = "0x4CB4CF0", VA = "0x184CB5AF0")]
	[Preserve]
	public MAOGDCOLEIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4521740", Offset = "0x4520940", VA = "0x184521740")]
	[Preserve]
	public MAOGDCOLEIG(COFCEIGKIJD<T> JHACFAPLDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x52D43D0", Offset = "0x52D35D0", VA = "0x1852D43D0", Slot = "11")]
	protected override T[] GPDCPHHKFKN(IEnumerable<T> JLALKPGHLDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class BCLONENJJFC<T> : KHFJIKADCIL<List<T>, T>
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4CB5AF0", Offset = "0x4CB4CF0", VA = "0x184CB5AF0")]
	[Preserve]
	public BCLONENJJFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4521740", Offset = "0x4520940", VA = "0x184521740")]
	[Preserve]
	public BCLONENJJFC([Optional] COFCEIGKIJD<T> JHACFAPLDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5E722E0", Offset = "0x5E714E0", VA = "0x185E722E0", Slot = "11")]
	protected override List<T> GPDCPHHKFKN(IEnumerable<T> JLALKPGHLDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class KPHEIACLPBJ<T> : BNHGMLNCOLP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly JsonSerializerSettings? EBALKKLHBBJ;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x502B1A0", Offset = "0x502A3A0", VA = "0x18502B1A0")]
	public KPHEIACLPBJ(JsonSerializerSettings? APHLLBPOPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x502B070", Offset = "0x502A270", VA = "0x18502B070", Slot = "9")]
	public override string CEBCPPBDNIB(T EEEOGOJIPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x502B0D0", Offset = "0x502A2D0", VA = "0x18502B0D0", Slot = "10")]
	protected override bool FLMCMOIELJG([NotNull] string EEEOGOJIPGB, [Out] T MLCDCHNOCFI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class KCCIIDKMLMB : BNHGMLNCOLP<byte>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x803C030", Offset = "0x803B230", VA = "0x18803C030", Slot = "9")]
	public override string CEBCPPBDNIB(byte EEEOGOJIPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x803C090", Offset = "0x803B290", VA = "0x18803C090", Slot = "10")]
	protected override bool FLMCMOIELJG(string EEEOGOJIPGB, [Out] byte MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x803C120", Offset = "0x803B320", VA = "0x18803C120")]
	public KCCIIDKMLMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class GIGIKBLPIKB : BNHGMLNCOLP<short>
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x803BA30", Offset = "0x803AC30", VA = "0x18803BA30", Slot = "9")]
	public override string CEBCPPBDNIB(short EEEOGOJIPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x803BA90", Offset = "0x803AC90", VA = "0x18803BA90", Slot = "10")]
	protected override bool FLMCMOIELJG(string EEEOGOJIPGB, [Out] short MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x803BB30", Offset = "0x803AD30", VA = "0x18803BB30")]
	public GIGIKBLPIKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal class DFGOGEFHHJC : BNHGMLNCOLP<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x803B800", Offset = "0x803AA00", VA = "0x18803B800", Slot = "9")]
	public override string CEBCPPBDNIB(ushort EEEOGOJIPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x803B860", Offset = "0x803AA60", VA = "0x18803B860", Slot = "10")]
	protected override bool FLMCMOIELJG(string EEEOGOJIPGB, [Out] ushort MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x803B900", Offset = "0x803AB00", VA = "0x18803B900")]
	public DFGOGEFHHJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class HNCLNIHGKIF : BNHGMLNCOLP<int>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x803BEA0", Offset = "0x803B0A0", VA = "0x18803BEA0", Slot = "9")]
	public override string CEBCPPBDNIB(int EEEOGOJIPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x803BF00", Offset = "0x803B100", VA = "0x18803BF00", Slot = "10")]
	protected override bool FLMCMOIELJG(string EEEOGOJIPGB, [Out] int MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x803BF90", Offset = "0x803B190", VA = "0x18803BF90")]
	public HNCLNIHGKIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class PLDGFENANGH : BNHGMLNCOLP<uint>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x803C680", Offset = "0x803B880", VA = "0x18803C680", Slot = "9")]
	public override string CEBCPPBDNIB(uint EEEOGOJIPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x803C6E0", Offset = "0x803B8E0", VA = "0x18803C6E0", Slot = "10")]
	protected override bool FLMCMOIELJG(string EEEOGOJIPGB, [Out] uint MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x803C770", Offset = "0x803B970", VA = "0x18803C770")]
	public PLDGFENANGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class HGPPLPFDBEI : BNHGMLNCOLP<long>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x803BD60", Offset = "0x803AF60", VA = "0x18803BD60", Slot = "9")]
	public override string CEBCPPBDNIB(long EEEOGOJIPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x803BDC0", Offset = "0x803AFC0", VA = "0x18803BDC0", Slot = "10")]
	protected override bool FLMCMOIELJG(string EEEOGOJIPGB, [Out] long MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x803BE60", Offset = "0x803B060", VA = "0x18803BE60")]
	public HGPPLPFDBEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class HEJLAKKBPEK : BNHGMLNCOLP<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x803BC20", Offset = "0x803AE20", VA = "0x18803BC20", Slot = "9")]
	public override string CEBCPPBDNIB(ulong EEEOGOJIPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x803BC80", Offset = "0x803AE80", VA = "0x18803BC80", Slot = "10")]
	protected override bool FLMCMOIELJG(string EEEOGOJIPGB, [Out] ulong MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x803BD20", Offset = "0x803AF20", VA = "0x18803BD20")]
	public HEJLAKKBPEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class CENHBLFCJKA : BNHGMLNCOLP<float>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x803B6C0", Offset = "0x803A8C0", VA = "0x18803B6C0", Slot = "9")]
	public override string CEBCPPBDNIB(float EEEOGOJIPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x803B730", Offset = "0x803A930", VA = "0x18803B730", Slot = "10")]
	protected override bool FLMCMOIELJG(string EEEOGOJIPGB, [Out] float MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x803B7C0", Offset = "0x803A9C0", VA = "0x18803B7C0")]
	public CENHBLFCJKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface BMJJDNJLHOM
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string MFGKCCHBOFA(object EEEOGOJIPGB);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MEAAIALEOBI([CanBeNull] string EEEOGOJIPGB, [Out] object MLCDCHNOCFI);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface COFCEIGKIJD<T> : BMJJDNJLHOM
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string CEBCPPBDNIB(T EEEOGOJIPGB);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ONGMIMEBEHB([CanBeNull] string EEEOGOJIPGB, [Out] T MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T DJLDICFOPAG([CanBeNull] string EEEOGOJIPGB, [Optional] T FAGKKFIFNNI);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class BNHGMLNCOLP<T> : COFCEIGKIJD<T>, BMJJDNJLHOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Type IHKCGHCPJPP;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6077AB0", Offset = "0x6076CB0", VA = "0x186077AB0")]
	protected BNHGMLNCOLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6077060", Offset = "0x6076260", VA = "0x186077060")]
	private T CJDJLMBEOKA(object DBCLNEGBNLN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract string CEBCPPBDNIB(T EEEOGOJIPGB);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6077770", Offset = "0x6076970", VA = "0x186077770", Slot = "7")]
	public string MFGKCCHBOFA(object EEEOGOJIPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x60778E0", Offset = "0x6076AE0", VA = "0x1860778E0", Slot = "5")]
	public bool ONGMIMEBEHB(string EEEOGOJIPGB, [Out] T MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool FLMCMOIELJG([NotNull] string EEEOGOJIPGB, [Out] T MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x60766A0", Offset = "0x60758A0", VA = "0x1860766A0", Slot = "8")]
	private bool CGDFCGGDOII(string EEEOGOJIPGB, [Out] object MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x60772F0", Offset = "0x60764F0", VA = "0x1860772F0", Slot = "6")]
	public T DJLDICFOPAG(string EEEOGOJIPGB, [Optional] T FAGKKFIFNNI)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class BJFCFLEIGPC<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static COFCEIGKIJD<T> EMOEMPAFHHF
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4984EF0", Offset = "0x49840F0", VA = "0x184984EF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x39A5F00", Offset = "0x39A5100", VA = "0x1839A5F00")]
	public static COFCEIGKIJD<TSerialized> DDCDONHAJDC<TSerialized>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5E967E0", Offset = "0x5E959E0", VA = "0x185E967E0")]
	public static BMJJDNJLHOM DDCDONHAJDC(Type MFBOPOLHKOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B820", Offset = "0x5E9AA20", VA = "0x185E9B820")]
	private static BMJJDNJLHOM MCOLPBLFNFC(Type NIHEKCHEINN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5E99620", Offset = "0x5E98820", VA = "0x185E99620")]
	private static BMJJDNJLHOM IHBCOJBJCIF(Type NIHEKCHEINN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class IMAKBMKADEA<TCollection> : KHFJIKADCIL<TCollection, string> where TCollection : IEnumerable<string>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class HCKPHOGFBEP : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
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
		public IMAKBMKADEA<TCollection> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private ONIILEFMLKH<StringBuilder> <_>5__2;

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
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xE9E930", Offset = "0xE9DB30", VA = "0x180E9E930")]
		[DebuggerHidden]
		public HCKPHOGFBEP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x49B3E70", Offset = "0x49B3070", VA = "0x1849B3E70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4B0E630", Offset = "0x4B0D830", VA = "0x184B0E630", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4B0E5E0", Offset = "0x4B0D7E0", VA = "0x184B0E5E0")]
		private void CKKMGPGLJAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4B0EBC0", Offset = "0x4B0DDC0", VA = "0x184B0EBC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x4B0EAA0", Offset = "0x4B0DCA0", VA = "0x184B0EAA0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x4B0EB80", Offset = "0x4B0DD80", VA = "0x184B0EB80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool ECIIMEJNLMG;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4CA3430", Offset = "0x4CA2630", VA = "0x184CA3430")]
	protected IMAKBMKADEA(bool ECIIMEJNLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4CA30B0", Offset = "0x4CA22B0", VA = "0x184CA30B0", Slot = "9")]
	public override string CEBCPPBDNIB(TCollection EEEOGOJIPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4CA3370", Offset = "0x4CA2570", VA = "0x184CA3370", Slot = "12")]
	[IteratorStateMachine(typeof(IMAKBMKADEA<>.HCKPHOGFBEP))]
	internal override IEnumerable<string> JHJCNEEEOCN(string EEEOGOJIPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4CA32F0", Offset = "0x4CA24F0", VA = "0x184CA32F0")]
	[CompilerGenerated]
	internal static string IGCJDCAPNLE(StringBuilder IJONBOEPBFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class NPKNJCEPGGJ : IMAKBMKADEA<List<string>>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x803C360", Offset = "0x803B560", VA = "0x18803C360")]
	[Preserve]
	public NPKNJCEPGGJ(bool ECIIMEJNLMG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x803C2D0", Offset = "0x803B4D0", VA = "0x18803C2D0", Slot = "11")]
	protected override List<string> GPDCPHHKFKN(IEnumerable<string> JLALKPGHLDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class HDAAGPFDPAE : IMAKBMKADEA<string[]>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x803BBD0", Offset = "0x803ADD0", VA = "0x18803BBD0")]
	[Preserve]
	public HDAAGPFDPAE(bool ECIIMEJNLMG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x803BB70", Offset = "0x803AD70", VA = "0x18803BB70", Slot = "11")]
	protected override string[] GPDCPHHKFKN(IEnumerable<string> JLALKPGHLDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class IMCDIKBGEDK : BNHGMLNCOLP<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xAA6950", Offset = "0xAA5B50", VA = "0x180AA6950", Slot = "9")]
	public override string CEBCPPBDNIB(string EEEOGOJIPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x803BFD0", Offset = "0x803B1D0", VA = "0x18803BFD0", Slot = "10")]
	protected override bool FLMCMOIELJG(string EEEOGOJIPGB, [Out] string MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x803BFF0", Offset = "0x803B1F0", VA = "0x18803BFF0")]
	public IMCDIKBGEDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class OALKMHEOKPC : BNHGMLNCOLP<TimeSpan>
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x803C3B0", Offset = "0x803B5B0", VA = "0x18803C3B0", Slot = "9")]
	public override string CEBCPPBDNIB(TimeSpan EEEOGOJIPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x803C4D0", Offset = "0x803B6D0", VA = "0x18803C4D0", Slot = "10")]
	protected override bool FLMCMOIELJG(string EEEOGOJIPGB, [Out] TimeSpan MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x803C640", Offset = "0x803B840", VA = "0x18803C640")]
	public OALKMHEOKPC()
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
