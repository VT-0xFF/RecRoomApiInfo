using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8CB040", Offset = "0x8CA440", VA = "0x1808CB040")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7197F50", Offset = "0x7197350", VA = "0x187197F50")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA6EF70", Offset = "0xA6E370", VA = "0x180A6EF70")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA6EFA0", Offset = "0xA6E3A0", VA = "0x180A6EFA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class CBFNECLMPML
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	protected CBFNECLMPML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class FNFGLJJKEJP<T> : CBFNECLMPML
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct PKBFAALAELL
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum NNJJAPNPJCJ
		{
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public NNJJAPNPJCJ GANFKPHKNKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T NDPBOAHDPLI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int KPNMJABHCPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool OJKMCOLHCCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool AFMBAPLMKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x702510", Offset = "0x701910")]
	protected List<T> DBMGNCMLAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x702570", Offset = "0x701970")]
	private List<PKBFAALAELL> KBMNBNJKEHP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool OGANDLBGJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3815330", Offset = "0x3814730", VA = "0x183815330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3815370", Offset = "0x3814770", VA = "0x183815370")]
	protected FNFGLJJKEJP(bool AFMBAPLMKFP, bool OJKMCOLHCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x38151A0", Offset = "0x38145A0", VA = "0x1838151A0")]
	protected bool PALAIDNDDCD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x38150E0", Offset = "0x38144E0", VA = "0x1838150E0")]
	protected void OCCBDLDKIDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3814C80", Offset = "0x3814080", VA = "0x183814C80")]
	protected void EHONOCGIOGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2018ED0", Offset = "0x20182D0", VA = "0x182018ED0")]
	private static void ICLLCGHLIFG<U>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7025D0", Offset = "0x7019D0")] ref List<U?>? FIONHDMDJNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3814F80", Offset = "0x3814380", VA = "0x183814F80", Slot = "4")]
	public void NNFBEGDMHOD(T NDPBOAHDPLI, bool MIGDKCHBHCG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3814E30", Offset = "0x3814230", VA = "0x183814E30", Slot = "5")]
	public void LOBOHMPHNJE(T NDPBOAHDPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3815220", Offset = "0x3814620", VA = "0x183815220")]
	public void PDPMCCCKLBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface OIMBIKGHALH
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NNFBEGDMHOD(Action NDPBOAHDPLI, bool MIGDKCHBHCG = false);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LOBOHMPHNJE(Action NDPBOAHDPLI);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x702650", Offset = "0x701A50")]
public sealed class MLPFDGHACOI : FNFGLJJKEJP<Action>, OIMBIKGHALH
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7197920", Offset = "0x7196D20", VA = "0x187197920")]
	public MLPFDGHACOI(bool AFMBAPLMKFP = false, bool OJKMCOLHCCF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7197710", Offset = "0x7196B10", VA = "0x187197710")]
	public void LABHLMFNFCH()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x71976B0", Offset = "0x7196AB0", VA = "0x1871976B0")]
	public static MLPFDGHACOI FFOEBJGJBJN(MLPFDGHACOI MBDJFJPBFBC, Action NDPBOAHDPLI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7197650", Offset = "0x7196A50", VA = "0x187197650")]
	public static MLPFDGHACOI DMMHCOPAKPM(MLPFDGHACOI MBDJFJPBFBC, Action NDPBOAHDPLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KFPOFJMKHFP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NNFBEGDMHOD(Action<T> NDPBOAHDPLI, bool MIGDKCHBHCG = false);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LOBOHMPHNJE(Action<T> NDPBOAHDPLI);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7026C0", Offset = "0x701AC0")]
public sealed class PJFJKKKIAHI<T> : FNFGLJJKEJP<Action<T>>, KFPOFJMKHFP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x22EDAC0", Offset = "0x22ECEC0", VA = "0x1822EDAC0")]
	public PJFJKKKIAHI(bool AFMBAPLMKFP = false, bool OJKMCOLHCCF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3CFE820", Offset = "0x3CFDC20", VA = "0x183CFE820")]
	public void LABHLMFNFCH(T NINFMGLENJD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x230D780", Offset = "0x230CB80", VA = "0x18230D780")]
	public static PJFJKKKIAHI<T> FFOEBJGJBJN(PJFJKKKIAHI<T> MBDJFJPBFBC, Action<T> NDPBOAHDPLI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x230D6F0", Offset = "0x230CAF0", VA = "0x18230D6F0")]
	public static PJFJKKKIAHI<T> DMMHCOPAKPM(PJFJKKKIAHI<T> MBDJFJPBFBC, Action<T> NDPBOAHDPLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface EJGPCEDENPC<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x702730", Offset = "0x701B30")]
public sealed class CEFLAGENLCN<T, U> : FNFGLJJKEJP<Action<T, U>>, EJGPCEDENPC<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x22EDAC0", Offset = "0x22ECEC0", VA = "0x1822EDAC0")]
	public CEFLAGENLCN(bool AFMBAPLMKFP = false, bool OJKMCOLHCCF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3159E10", Offset = "0x3159210", VA = "0x183159E10")]
	public void LABHLMFNFCH(T NINFMGLENJD, U FFFCLEBOHNE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x230D780", Offset = "0x230CB80", VA = "0x18230D780")]
	public static CEFLAGENLCN<T, U> FFOEBJGJBJN(CEFLAGENLCN<T, U> MBDJFJPBFBC, Action<T, U> NDPBOAHDPLI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x230D6F0", Offset = "0x230CAF0", VA = "0x18230D6F0")]
	public static CEFLAGENLCN<T, U> DMMHCOPAKPM(CEFLAGENLCN<T, U> MBDJFJPBFBC, Action<T, U> NDPBOAHDPLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7027A0", Offset = "0x701BA0")]
public sealed class MAPBMMJPPEG<T, U, V> : FNFGLJJKEJP<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x22EDAC0", Offset = "0x22ECEC0", VA = "0x1822EDAC0")]
	public MAPBMMJPPEG(bool AFMBAPLMKFP = false, bool OJKMCOLHCCF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x230DCF0", Offset = "0x230D0F0", VA = "0x18230DCF0")]
	public void LABHLMFNFCH(T NINFMGLENJD, U FFFCLEBOHNE, V GFDOPOBNKBA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x230D780", Offset = "0x230CB80", VA = "0x18230D780")]
	public static MAPBMMJPPEG<T, U, V> FFOEBJGJBJN(MAPBMMJPPEG<T, U, V> MBDJFJPBFBC, Action<T, U, V> NDPBOAHDPLI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x230D6F0", Offset = "0x230CAF0", VA = "0x18230D6F0")]
	public static MAPBMMJPPEG<T, U, V> DMMHCOPAKPM(MAPBMMJPPEG<T, U, V> MBDJFJPBFBC, Action<T, U, V> NDPBOAHDPLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface CLOLDEIHFNK<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x702810", Offset = "0x701C10")]
public sealed class FOJELIMBAPG<T, U, V, W> : FNFGLJJKEJP<Action<T, U, V, W>>, CLOLDEIHFNK<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x22EDAC0", Offset = "0x22ECEC0", VA = "0x1822EDAC0")]
	public FOJELIMBAPG(bool AFMBAPLMKFP = false, bool OJKMCOLHCCF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3613720", Offset = "0x3612B20", VA = "0x183613720")]
	public void LABHLMFNFCH(T NINFMGLENJD, U FFFCLEBOHNE, V GFDOPOBNKBA, W OPBCFGIPEAC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x230D780", Offset = "0x230CB80", VA = "0x18230D780")]
	public static FOJELIMBAPG<T, U, V, W> FFOEBJGJBJN(FOJELIMBAPG<T, U, V, W> MBDJFJPBFBC, Action<T, U, V, W> NDPBOAHDPLI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x230D6F0", Offset = "0x230CAF0", VA = "0x18230D6F0")]
	public static FOJELIMBAPG<T, U, V, W> DMMHCOPAKPM(FOJELIMBAPG<T, U, V, W> MBDJFJPBFBC, Action<T, U, V, W> NDPBOAHDPLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x702880", Offset = "0x701C80")]
public sealed class KOHFCDLMLAN<T, U, V, W, X> : FNFGLJJKEJP<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x22EDAC0", Offset = "0x22ECEC0", VA = "0x1822EDAC0")]
	public KOHFCDLMLAN(bool AFMBAPLMKFP = false, bool OJKMCOLHCCF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2E64900", Offset = "0x2E63D00", VA = "0x182E64900")]
	public void LABHLMFNFCH(T NINFMGLENJD, U FFFCLEBOHNE, V GFDOPOBNKBA, W OPBCFGIPEAC, X EOMIKPKMCAG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x230D780", Offset = "0x230CB80", VA = "0x18230D780")]
	public static KOHFCDLMLAN<T, U, V, W, X> FFOEBJGJBJN(KOHFCDLMLAN<T, U, V, W, X> MBDJFJPBFBC, Action<T, U, V, W, X> NDPBOAHDPLI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x230D6F0", Offset = "0x230CAF0", VA = "0x18230D6F0")]
	public static KOHFCDLMLAN<T, U, V, W, X> DMMHCOPAKPM(KOHFCDLMLAN<T, U, V, W, X> MBDJFJPBFBC, Action<T, U, V, W, X> NDPBOAHDPLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7028F0", Offset = "0x701CF0")]
public sealed class LFDALICMEOE<T, U, V, W, X, Y> : FNFGLJJKEJP<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x22EDAC0", Offset = "0x22ECEC0", VA = "0x1822EDAC0")]
	public LFDALICMEOE(bool AFMBAPLMKFP = false, bool OJKMCOLHCCF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2BA7A70", Offset = "0x2BA6E70", VA = "0x182BA7A70")]
	public void LABHLMFNFCH(T NINFMGLENJD, U FFFCLEBOHNE, V GFDOPOBNKBA, W OPBCFGIPEAC, X EOMIKPKMCAG, Y PPNFDCNFKFC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x230D780", Offset = "0x230CB80", VA = "0x18230D780")]
	public static LFDALICMEOE<T, U, V, W, X, Y> FFOEBJGJBJN(LFDALICMEOE<T, U, V, W, X, Y> MBDJFJPBFBC, Action<T, U, V, W, X, Y> NDPBOAHDPLI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x230D6F0", Offset = "0x230CAF0", VA = "0x18230D6F0")]
	public static LFDALICMEOE<T, U, V, W, X, Y> DMMHCOPAKPM(LFDALICMEOE<T, U, V, W, X, Y> MBDJFJPBFBC, Action<T, U, V, W, X, Y> NDPBOAHDPLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class OMNBHFGADPA : FJCGAAAECJI
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static bool BBGBCPEELPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly string? OELHCMBLCIF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public virtual FJCGAAAECJI? DNDLKMPNPPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x821EB0", Offset = "0x8212B0", VA = "0x180821EB0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7198670", Offset = "0x7197A70", VA = "0x187198670")]
	protected OMNBHFGADPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string NBKNGDNHDKI();

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x71985F0", Offset = "0x71979F0", VA = "0x1871985F0", Slot = "8")]
	public virtual string MAPHEAINCIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7197FE0", Offset = "0x71973E0", VA = "0x187197FE0", Slot = "9")]
	public void AAGDCAAHKNA(StringBuilder CKMMNJLHDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7198470", Offset = "0x7197870", VA = "0x187198470", Slot = "10")]
	public void DNAHBCANCEM(StringBuilder CKMMNJLHDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x71984D0", Offset = "0x71978D0", VA = "0x1871984D0", Slot = "11")]
	public void HKJAOMNCCLM(StringBuilder CKMMNJLHDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7198310", Offset = "0x7197710", VA = "0x187198310", Slot = "12")]
	public void AOEKGGBGLMG(StringBuilder CKMMNJLHDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7198270", Offset = "0x7197670", VA = "0x187198270")]
	public static void ABDEKJKMOHA(StringBuilder CKMMNJLHDJP, string FJIALGMLGCF, string AGMBIKAFLAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0xEFB0F0", Offset = "0xEFA4F0", VA = "0x180EFB0F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class IGMBEGEKKAO<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly EEOODGNAPMC<TKey, TVal> JIPENKPPDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7029C0", Offset = "0x701DC0")]
	internal readonly Dictionary<TKey, (TVal value, int size)> PPJFBCPJPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly int COEMMKGEEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x702A90", Offset = "0x701E90")]
	private readonly EEOODGNAPMC<TKey, TVal>.HFKAOEKHPOM OIDMIKKPDOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private int AENCGKLOJCD;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal int NCHJLDJGFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x29E02B0", Offset = "0x29DF6B0", VA = "0x1829E02B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int EENLDMFFFJL
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA0C050", Offset = "0xA0B450", VA = "0x180A0C050")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x29E0590", Offset = "0x29DF990", VA = "0x1829E0590")]
	public IGMBEGEKKAO(int COEMMKGEEAP, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x702AF0", Offset = "0x701EF0")] EEOODGNAPMC<TKey, TVal>.HFKAOEKHPOM OIDMIKKPDOC, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x702B50", Offset = "0x701F50")] IEqualityComparer<TKey> CBOPDPCFOLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x29E0420", Offset = "0x29DF820", VA = "0x1829E0420")]
	public void OCAGBAPBJHO(TKey PMMAAICOJOP, TVal AGLCIEKHLEE, bool KAHCONAOJCA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x29DFF10", Offset = "0x29DF310", VA = "0x1829DFF10")]
	public bool BFDKNHDGDIJ(TKey PMMAAICOJOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x29E0030", Offset = "0x29DF430", VA = "0x1829E0030")]
	public bool CLFAJBNDMHA(TKey JBMNDBMHNJA, out TVal AGLCIEKHLEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x29E00E0", Offset = "0x29DF4E0", VA = "0x1829E00E0")]
	private void EHNPKPBFLPM(TKey PMMAAICOJOP, TVal AGLCIEKHLEE, int AJCINIIEJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x29E02F0", Offset = "0x29DF6F0", VA = "0x1829E02F0")]
	public bool HEPOCLACPKC(TKey PMMAAICOJOP, TVal AGLCIEKHLEE, bool KAHCONAOJCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x29DFF90", Offset = "0x29DF390", VA = "0x1829DFF90")]
	private bool BGOFODEIACF(TKey PMMAAICOJOP)
	{
		return default(bool);
	}
}
namespace RecRoom.NoEngine.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct RRColor : IEquatable<RRColor>, IFormattable
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private const float kEpsilon = 1E-05f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x20D3980", Offset = "0x20D2D80", VA = "0x1820D3980")]
		public RRColor(float OEMJPJIELLC, float HIFDOICJFLH, float KBAEKPMBMFG, float NPBBJPKPNCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x71986F0", Offset = "0x7197AF0", VA = "0x1871986F0", Slot = "4")]
		public bool Equals(RRColor ICELKIGIKKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7198770", Offset = "0x7197B70", VA = "0x187198770", Slot = "0")]
		public override bool Equals(object ICELKIGIKKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7198850", Offset = "0x7197C50", VA = "0x187198850", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x71988C0", Offset = "0x7197CC0", VA = "0x1871988C0", Slot = "5")]
		public string ToString(string EFDFEGMKBJJ, IFormatProvider MPMGCPHHJII)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class IEDJAOPIJCA : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x71973E0", Offset = "0x71967E0", VA = "0x1871973E0")]
	public IEDJAOPIJCA(string FHDJIGKOLJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class DHEEMDDMFJL<TErr> : IEDJAOPIJCA where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly TErr MNAJGABAAJF;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x32CFD90", Offset = "0x32CF190", VA = "0x1832CFD90")]
	private DHEEMDDMFJL(in TErr KKHNEKNEEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x32CFCC0", Offset = "0x32CF0C0", VA = "0x1832CFCC0")]
	public static DHEEMDDMFJL<TErr> NAILOIKCJEC(in TErr KKHNEKNEEDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[DefaultMember("Item")]
public sealed class EEOODGNAPMC<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate int HFKAOEKHPOM(TKey PMMAAICOJOP, TVal AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class HCPDOPKAOGL
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public TKey JGJPKDIBNOF
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x9857D0", Offset = "0x984BD0", VA = "0x1809857D0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public TVal EKGBCCDIAJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x823C10", Offset = "0x823010", VA = "0x180823C10")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x8BBD60", Offset = "0x8BB160", VA = "0x1808BBD60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int MMHHHCFJGNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xE903A0", Offset = "0xE8F7A0", VA = "0x180E903A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xE902C0", Offset = "0xE8F6C0", VA = "0x180E902C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public DateTime KNJIIJGHKID
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x823B60", Offset = "0x822F60", VA = "0x180823B60")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x1770340", Offset = "0x176F740", VA = "0x181770340")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2076110", Offset = "0x2075510", VA = "0x182076110")]
		public HCPDOPKAOGL(TKey PMMAAICOJOP, TVal GBFJPNOAMDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class CDNJGHFEACK : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x703220", Offset = "0x702620")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public EEOODGNAPMC<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x703280", Offset = "0x702680")]
		private LinkedList<EEOODGNAPMC<TKey, TVal>.HCPDOPKAOGL>.Enumerator <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private HCPDOPKAOGL <cacheEntry>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x1122D70", Offset = "0x1122170", VA = "0x181122D70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x3157410", Offset = "0x3156810", VA = "0x183157410", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x19DEBC0", Offset = "0x19DDFC0", VA = "0x1819DEBC0")]
		[DebuggerHidden]
		public CDNJGHFEACK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x22FB570", Offset = "0x22FA970", VA = "0x1822FB570", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3155DF0", Offset = "0x31551F0", VA = "0x183155DF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3156FE0", Offset = "0x31563E0", VA = "0x183156FE0")]
		private void PPOPDODPNIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3157240", Offset = "0x3156640", VA = "0x183157240", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public const int JKADECCLFNG = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x702C10", Offset = "0x702010")]
	private readonly Dictionary<TKey, LinkedListNode<EEOODGNAPMC<TKey, TVal>.HCPDOPKAOGL>> DMLCLJFMPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x702C70", Offset = "0x702070")]
	private readonly LinkedList<EEOODGNAPMC<TKey, TVal>.HCPDOPKAOGL> EBPLMAKAJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x702CD0", Offset = "0x7020D0")]
	private readonly EEOODGNAPMC<TKey, TVal>.HFKAOEKHPOM OIDMIKKPDOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly TimeSpan FFJGLDHFHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HEMECLGPDGP OFLNHEEMJMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private bool HHBDPMKKDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly List<TKey> HEEMFOJOPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly List<TVal> ENNAMNCBECJ;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int EENLDMFFFJL
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xABDAF0", Offset = "0xABCEF0", VA = "0x180ABDAF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	internal int NCHJLDJGFHD
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1E01180", Offset = "0x1E00580", VA = "0x181E01180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x1E01190", Offset = "0x1E00590", VA = "0x181E01190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int HIBMACOFNKK
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x286B440", Offset = "0x286A840", VA = "0x18286B440", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public ICollection<TVal> EAIAEMNCFLA
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3A2ADC0", Offset = "0x3A2A1C0", VA = "0x183A2ADC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	ICollection<TKey> IDictionary<TKey, TVal>.GPAILIOMNKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x3A28A30", Offset = "0x3A27E30", VA = "0x183A28A30", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool BAJNPCIAOLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TVal ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x3A2AD10", Offset = "0x3A2A110", VA = "0x183A2AD10", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x3A2AEA0", Offset = "0x3A2A2A0", VA = "0x183A2AEA0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3A26470", Offset = "0x3A25870", VA = "0x183A26470")]
	private bool MJPMGAAMJAK(int GLDHDJHPIPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3A238D0", Offset = "0x3A22CD0", VA = "0x183A238D0")]
	private void BPJIGJPFFIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3A2A6C0", Offset = "0x3A29AC0", VA = "0x183A2A6C0")]
	public EEOODGNAPMC(int GLDHDJHPIPL, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x702D30", Offset = "0x702130")] EEOODGNAPMC<TKey, TVal>.HFKAOEKHPOM OIDMIKKPDOC, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x702D90", Offset = "0x702190")] IEqualityComparer<TKey> CBOPDPCFOLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3A29540", Offset = "0x3A28940", VA = "0x183A29540")]
	public EEOODGNAPMC(int GLDHDJHPIPL, TimeSpan FFJGLDHFHAE, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x702DF0", Offset = "0x7021F0")] IEqualityComparer<TKey?>? CBOPDPCFOLK, [Optional] HEMECLGPDGP? OFLNHEEMJMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3A29F60", Offset = "0x3A29360", VA = "0x183A29F60")]
	public EEOODGNAPMC(int GLDHDJHPIPL, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x702E50", Offset = "0x702250")] EEOODGNAPMC<TKey?, TVal?>.HFKAOEKHPOM? OIDMIKKPDOC, TimeSpan FFJGLDHFHAE, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x702EB0", Offset = "0x7022B0")] IEqualityComparer<TKey?>? CBOPDPCFOLK, [Optional] HEMECLGPDGP? OFLNHEEMJMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3A27430", Offset = "0x3A26830", VA = "0x183A27430")]
	public bool PLKPADIDCBP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3A26260", Offset = "0x3A25660", VA = "0x183A26260")]
	public bool HJEBEJEJKMG(int AJCINIIEJAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3A21D30", Offset = "0x3A21130", VA = "0x183A21D30")]
	public void AFLFAPDAOKF(TKey PMMAAICOJOP, TVal AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3098530", Offset = "0x3097930", VA = "0x183098530", Slot = "14")]
	public void Add([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x702F10", Offset = "0x702310")] KeyValuePair<TKey, TVal> CFHFBNLLHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3A231E0", Offset = "0x3A225E0", VA = "0x183A231E0", Slot = "9")]
	public void Add(TKey PMMAAICOJOP, TVal AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3A23F30", Offset = "0x3A23330", VA = "0x183A23F30", Slot = "8")]
	public bool ContainsKey(TKey PMMAAICOJOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3A23F30", Offset = "0x3A23330", VA = "0x183A23F30", Slot = "16")]
	public bool Contains([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x702F70", Offset = "0x702370")] KeyValuePair<TKey, TVal> CFHFBNLLHPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3A28250", Offset = "0x3A27650", VA = "0x183A28250", Slot = "10")]
	public bool Remove(TKey PMMAAICOJOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3A28980", Offset = "0x3A27D80", VA = "0x183A28980", Slot = "18")]
	public bool Remove([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x702FD0", Offset = "0x7023D0")] KeyValuePair<TKey, TVal> CFHFBNLLHPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3A26920", Offset = "0x3A25D20", VA = "0x183A26920")]
	private TVal PHGLOPEHIMO(TKey JBMNDBMHNJA)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3A28A70", Offset = "0x3A27E70", VA = "0x183A28A70", Slot = "11")]
	public bool TryGetValue(TKey JBMNDBMHNJA, out TVal AGLCIEKHLEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3A23DB0", Offset = "0x3A231B0", VA = "0x183A23DB0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3A24BE0", Offset = "0x3A23FE0", VA = "0x183A24BE0", Slot = "17")]
	public void CopyTo([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x703030", Offset = "0x702430")] KeyValuePair<TKey, TVal>[] EACKPMFPNLH, int LKNMOMDDHBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3A25520", Offset = "0x3A24920", VA = "0x183A25520")]
	private bool HCOMAIBPNBO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x703090", Offset = "0x702490")] EEOODGNAPMC<TKey, TVal>.HCPDOPKAOGL HKOPLAFKHBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3A22C70", Offset = "0x3A22070", VA = "0x183A22C70")]
	private void AMOAGGGCGFJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7030F0", Offset = "0x7024F0")] LinkedListNode<EEOODGNAPMC<TKey, TVal>.HCPDOPKAOGL> JAPHAGLAIDK, TVal PINJDLEFOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3A28000", Offset = "0x3A27400", VA = "0x183A28000")]
	private void PPPGPECFDDD(TKey PMMAAICOJOP, TVal AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3A26D70", Offset = "0x3A26170", VA = "0x183A26D70")]
	private void PINHILHOBLO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x703150", Offset = "0x702550")] EEOODGNAPMC<TKey, TVal>.HCPDOPKAOGL HKOPLAFKHBG, TVal PINJDLEFOFM, int JCCGGCKDEED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3A25310", Offset = "0x3A24710", VA = "0x183A25310", Slot = "19")]
	[IteratorStateMachine(typeof(EEOODGNAPMC<, >.CDNJGHFEACK))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1D2A3A0", Offset = "0x1D297A0", VA = "0x181D2A3A0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class GNHLCFCFEGN : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x71970A0", Offset = "0x71964A0", VA = "0x1871970A0")]
	public GNHLCFCFEGN(string FHDJIGKOLJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class FCJAIGJAMPD<TOk> : GNHLCFCFEGN where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly TOk HAEIFKDHBPD;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x30E1180", Offset = "0x30E0580", VA = "0x1830E1180")]
	private FCJAIGJAMPD(in TOk FFOCCPIIAOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x25880F0", Offset = "0x25874F0", VA = "0x1825880F0")]
	public static FCJAIGJAMPD<TOk> NAILOIKCJEC(in TOk FFOCCPIIAOD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[DefaultMember("Item")]
public sealed class HDCKDNKNOJE<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private readonly struct BJLFLLGPOHL : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly HDCKDNKNOJE<T> DCNHHFINCHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly int HFILHCBLINP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly bool DNEKICECDLI;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x20637B0", Offset = "0x2062BB0", VA = "0x1820637B0")]
		public BJLFLLGPOHL(HDCKDNKNOJE<T> JGNMLMMCBGP, int DLKONILGDNK, bool JMFBFJAOEDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2063690", Offset = "0x2062A90", VA = "0x182063690")]
		public HDCKDNKNOJE<T>.HAOJNBJMFAA MHIEAIINAGJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2063770", Offset = "0x2062B70", VA = "0x182063770", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2063770", Offset = "0x2062B70", VA = "0x182063770", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class HAOJNBJMFAA : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly HDCKDNKNOJE<T> DCNHHFINCHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly int ANIFIKCCLNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int JNIKNLFJDCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly bool DNEKICECDLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool MFNFEKMJJMA;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public T AOPJILKHAOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x31B3BA0", Offset = "0x31B2FA0", VA = "0x1831B3BA0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x31B3D90", Offset = "0x31B3190", VA = "0x1831B3D90", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x31B3E40", Offset = "0x31B3240", VA = "0x1831B3E40", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x31B4360", Offset = "0x31B3760", VA = "0x1831B4360")]
		public HAOJNBJMFAA(HDCKDNKNOJE<T> JGNMLMMCBGP, int DLKONILGDNK, bool JMFBFJAOEDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x31B3B10", Offset = "0x31B2F10", VA = "0x1831B3B10", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x31B3CE0", Offset = "0x31B30E0", VA = "0x1831B3CE0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class LHECJADPKOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x703350", Offset = "0x702750")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public LHECJADPKOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2BB13B0", Offset = "0x2BB07B0", VA = "0x182BB13B0")]
		internal T GOINEOOFNLD(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly T[] AMBMBFMBIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int JNIKNLFJDCD;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int PLJIJEENCKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2077310", Offset = "0x2076710", VA = "0x182077310")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public T AOPJILKHAOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x13138D0", Offset = "0x1312CD0", VA = "0x1813138D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T BFFIOPALDHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2077030", Offset = "0x2076430", VA = "0x182077030")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2077180", Offset = "0x2076580", VA = "0x182077180")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int NMCJNDHCAJI
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1AF1A30", Offset = "0x1AF0E30", VA = "0x181AF1A30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1529420", Offset = "0x1528820", VA = "0x181529420")]
	private static int DLMFMKDMKBE(int BNOAGGNAMKG, int HBBGBOONHJE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2077590", Offset = "0x2076990", VA = "0x182077590")]
	public HDCKDNKNOJE(int AJCINIIEJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x20776B0", Offset = "0x2076AB0", VA = "0x1820776B0")]
	public HDCKDNKNOJE(int AJCINIIEJAJ, Func<T> OKHGODLOINH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x20773B0", Offset = "0x20767B0", VA = "0x1820773B0")]
	public HDCKDNKNOJE(T[] LEJDAGMDLDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2077350", Offset = "0x2076750", VA = "0x182077350")]
	public void PENAICHBION()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x20771E0", Offset = "0x20765E0", VA = "0x1820771E0")]
	public IEnumerable<T> KGMENIOMAJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2077290", Offset = "0x2076690", VA = "0x182077290")]
	public HDCKDNKNOJE<T>.HAOJNBJMFAA MHIEAIINAGJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2077380", Offset = "0x2076780", VA = "0x182077380", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2077380", Offset = "0x2076780", VA = "0x182077380", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class OCBIPBPKNCE
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2029C90", Offset = "0x2029090", VA = "0x182029C90")]
	public static HDCKDNKNOJE<T> NAILOIKCJEC<T>(int AJCINIIEJAJ, Func<T> OKHGODLOINH) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface FJCGAAAECJI
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string MAPHEAINCIF();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string NBKNGDNHDKI();
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[AttributeUsage(AttributeTargets.Enum)]
public abstract class OKLEMMDOGED : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string EGDPOBLMKNF(string BJIHAMCKFIH);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x823850", Offset = "0x822C50", VA = "0x180823850")]
	protected OKLEMMDOGED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class DPLKHOFOCDM<TData> : OMNBHFGADPA where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly string GDLOACHAOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly TData MLLMENDGMLJ;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "7")]
	public override string NBKNGDNHDKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2E771B0", Offset = "0x2E765B0", VA = "0x182E771B0")]
	internal DPLKHOFOCDM(string FHDJIGKOLJM, in TData CLCAIFLMLCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class PDHGPJGKFCN
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x164DD50", Offset = "0x164D150", VA = "0x18164DD50")]
	public static DPLKHOFOCDM<TData> NAILOIKCJEC<TData>(string FHDJIGKOLJM, in TData CLCAIFLMLCJ) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface HPBDNPMOCDC
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	string EMIMPAFHJDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface LJPKNAJPJMB<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	TOptions EKGBCCDIAJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct ADOGIEMPLPD<TOk, TErr> : IEquatable<ADOGIEMPLPD<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static readonly EqualityComparer<TErr> CIEBAFNHLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal readonly TErr MNAJGABAAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal readonly TOk HAEIFKDHBPD;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool DNADJDDLAJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x2A182C0", Offset = "0x2A176C0", VA = "0x182A182C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool ENOPFIPNEJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x2A15700", Offset = "0x2A14B00", VA = "0x182A15700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2A1B6F0", Offset = "0x2A1AAF0", VA = "0x182A1B6F0")]
	internal ADOGIEMPLPD(in TErr KKHNEKNEEDJ, in TOk FFOCCPIIAOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x2A17E50", Offset = "0x2A17250", VA = "0x182A17E50")]
	public static ADOGIEMPLPD<TOk, TErr> KKPEMLELKJI(in TErr KKHNEKNEEDJ)
	{
		return default(ADOGIEMPLPD<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2A17940", Offset = "0x2A16D40", VA = "0x182A17940")]
	public static ADOGIEMPLPD<TOk, TErr> IEJBJBCKPAD(in TOk FFOCCPIIAOD)
	{
		return default(ADOGIEMPLPD<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x23150D0", Offset = "0x23144D0", VA = "0x1823150D0")]
	public ADOGIEMPLPD<UOk?, TErr?> HEOEDJNHGHD<UOk>()
	{
		return default(ADOGIEMPLPD<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2314AA0", Offset = "0x2313EA0", VA = "0x182314AA0")]
	public ADOGIEMPLPD<UOk?, TErr?> FMLMOEGBOAO<UOk>()
	{
		return default(ADOGIEMPLPD<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x23151A0", Offset = "0x23145A0", VA = "0x1823151A0")]
	public ADOGIEMPLPD<TOk?, UErr?> LHPMDJLLFLF<UErr>()
	{
		return default(ADOGIEMPLPD<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2A18D80", Offset = "0x2A18180", VA = "0x182A18D80")]
	public ADOGIEMPLPD<PNGLJAGHHDL, TErr> MJFACCKEGBA()
	{
		return default(ADOGIEMPLPD<PNGLJAGHHDL, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2A199B0", Offset = "0x2A18DB0", VA = "0x182A199B0")]
	public static bool PHJEMBLBEDF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x703410", Offset = "0x702810")] in ADOGIEMPLPD<TOk, TErr> FINJCDHFPJB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x703480", Offset = "0x702880")] in ADOGIEMPLPD<TOk, TErr> JHJGODIMNAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2A15A30", Offset = "0x2A14E30", VA = "0x182A15A30", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7034F0", Offset = "0x7028F0")] ADOGIEMPLPD<TOk, TErr> ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2A15F50", Offset = "0x2A15350", VA = "0x182A15F50", Slot = "0")]
	public override bool Equals(object ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2A16BB0", Offset = "0x2A15FB0", VA = "0x182A16BB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x313A2C0", Offset = "0x31396C0", VA = "0x18313A2C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class ACDHNKAJLPI
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class GOOOGHGPEJM<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Task<ADOGIEMPLPD<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private ADOGIEMPLPD<TOk, TErr> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private TaskAwaiter<ADOGIEMPLPD<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public GOOOGHGPEJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2C739C0", Offset = "0x2C72DC0", VA = "0x182C739C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class MGOCDEMFEDI<TOk, TErr> : IEnumerable<TOk>, IEnumerable, IEnumerator<TOk>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TOk <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private IEnumerable<ADOGIEMPLPD<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public IEnumerable<ADOGIEMPLPD<TOk, TErr>> <>3__self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private IEnumerator<ADOGIEMPLPD<TOk, TErr>> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private ADOGIEMPLPD<TOk, TErr> <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TOk <ok>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		TOk? IEnumerator<TOk>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (TOk?)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x1CB05A0", Offset = "0x1CAF9A0", VA = "0x181CB05A0")]
		[DebuggerHidden]
		public MGOCDEMFEDI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x22FB570", Offset = "0x22FA970", VA = "0x1822FB570", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x22FB130", Offset = "0x22FA530", VA = "0x1822FB130", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x22FB400", Offset = "0x22FA800", VA = "0x1822FB400")]
		private void PPOPDODPNIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x22FB530", Offset = "0x22FA930", VA = "0x1822FB530", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x22FB450", Offset = "0x22FA850", VA = "0x1822FB450", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TOk?>? IEnumerable<TOk>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x22FB500", Offset = "0x22FA900", VA = "0x1822FB500", Slot = "5")]
		[DebuggerHidden]
		IEnumerator? IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x15D9CE0", Offset = "0x15D90E0", VA = "0x1815D9CE0")]
	public static ADOGIEMPLPD<TOk?, TErr?> HAEIFKDHBPD<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x703590", Offset = "0x702990")] this in ADOGIEMPLPD<TOk?, TErr?> ODBHDBFBMOB, in TOk FFOCCPIIAOD)
	{
		return default(ADOGIEMPLPD<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x15D9D90", Offset = "0x15D9190", VA = "0x1815D9D90")]
	public static ADOGIEMPLPD<PNGLJAGHHDL, TErr?> HAEIFKDHBPD<TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x703630", Offset = "0x702A30")] this in ADOGIEMPLPD<PNGLJAGHHDL, TErr?> ODBHDBFBMOB)
	{
		return default(ADOGIEMPLPD<PNGLJAGHHDL, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x15D9D10", Offset = "0x15D9110", VA = "0x1815D9D10")]
	public static ADOGIEMPLPD<TOk?, TErr?> MNAJGABAAJF<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7036A0", Offset = "0x702AA0")] this in ADOGIEMPLPD<TOk?, TErr?> ODBHDBFBMOB, in TErr KKHNEKNEEDJ)
	{
		return default(ADOGIEMPLPD<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x15D99C0", Offset = "0x15D8DC0", VA = "0x1815D99C0")]
	public static TOk? CDEMOBFLEGI<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x703740", Offset = "0x702B40")] this in ADOGIEMPLPD<TOk?, TErr?> ODBHDBFBMOB)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x15DB540", Offset = "0x15DA940", VA = "0x1815DB540")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GOOOGHGPEJM<, >))]
	public static Task<TOk?>? LPJNOCLBANH<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x703830", Offset = "0x702C30")] this Task<ADOGIEMPLPD<TOk?, TErr?>>? ODBHDBFBMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x15D9AA0", Offset = "0x15D8EA0", VA = "0x1815D9AA0")]
	public static TErr? FHOOIMHFIKO<TErr, TOk>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x703890", Offset = "0x702C90")] this in ADOGIEMPLPD<TOk?, TErr?> ODBHDBFBMOB)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x15DA380", Offset = "0x15D9780", VA = "0x1815DA380")]
	public static bool HNPLDFCAJBA<TOk, TErr, UErr, UOk>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x703900", Offset = "0x702D00")] this in ADOGIEMPLPD<TOk?, TErr?> ODBHDBFBMOB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x703970", Offset = "0x702D70")] out ADOGIEMPLPD<UOk?, UErr?> NFMEBCHDILJ) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x15DB500", Offset = "0x15DA900", VA = "0x1815DB500")]
	public static bool KNCPBHEECFI<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7039D0", Offset = "0x702DD0")] this in ADOGIEMPLPD<TOk?, TErr?> ODBHDBFBMOB, [LOPEJNOEKCJ(true)] out TOk FFOCCPIIAOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x15DB990", Offset = "0x15DAD90", VA = "0x1815DB990")]
	public static bool NMJLNLGLLBC<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x703A80", Offset = "0x702E80")] this in ADOGIEMPLPD<TOk?, TErr?> ODBHDBFBMOB, [LOPEJNOEKCJ(true)] out TErr KKHNEKNEEDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x15D9700", Offset = "0x15D8B00", VA = "0x1815D9700")]
	public static bool BOIFKKALPLA<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x703AF0", Offset = "0x702EF0")] this in ADOGIEMPLPD<TOk, TErr> ODBHDBFBMOB, [LOPEJNOEKCJ(true)] out TOk FFOCCPIIAOD, [LOPEJNOEKCJ(false)] out TErr KKHNEKNEEDJ) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x15DB460", Offset = "0x15DA860", VA = "0x1815DB460")]
	public static bool JBCCEOBOIJO<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x703B60", Offset = "0x702F60")] this in ADOGIEMPLPD<TOk?, TErr?> ODBHDBFBMOB, [LOPEJNOEKCJ(true)] out TOk FFOCCPIIAOD, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x703BD0", Offset = "0x702FD0")] out ADOGIEMPLPD<TOk?, TErr?> NFMEBCHDILJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x15DA4A0", Offset = "0x15D98A0", VA = "0x1815DA4A0")]
	public static bool HNPLDFCAJBA<TOk, TErr, UErr, UOk>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x703C30", Offset = "0x703030")] this in ADOGIEMPLPD<TOk?, TErr?> ODBHDBFBMOB, [LOPEJNOEKCJ(true)] out TOk FFOCCPIIAOD, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x703CA0", Offset = "0x7030A0")] out ADOGIEMPLPD<UOk?, UErr?> NFMEBCHDILJ) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x15DB1A0", Offset = "0x15DA5A0", VA = "0x1815DB1A0")]
	public static bool IHHOJHJBADD<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x703D00", Offset = "0x703100")] this in ADOGIEMPLPD<TOk?, TErr?> ODBHDBFBMOB, [LOPEJNOEKCJ(true)] out TOk FFOCCPIIAOD, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x703DB0", Offset = "0x7031B0")] out ADOGIEMPLPD<PNGLJAGHHDL, TErr?> NFMEBCHDILJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x15DA050", Offset = "0x15D9450", VA = "0x1815DA050")]
	public static ADOGIEMPLPD<UOk, UErr> HHALGPEGJHJ<UOk, UErr, TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x703E10", Offset = "0x703210")] this in ADOGIEMPLPD<TOk, TErr> ODBHDBFBMOB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x703E80", Offset = "0x703280")] in ADOGIEMPLPD<UOk, UErr> PIALDONBLBA) where TOk : UOk where TErr : UErr
	{
		return default(ADOGIEMPLPD<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x15D9400", Offset = "0x15D8800", VA = "0x1815D9400")]
	public static ADOGIEMPLPD<TOk?[]?, TErr?> AJMJKOOGBIJ<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x703EF0", Offset = "0x7032F0")] this IEnumerable<ADOGIEMPLPD<TOk?, TErr?>>? ODBHDBFBMOB)
	{
		return default(ADOGIEMPLPD<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x15D9C60", Offset = "0x15D9060", VA = "0x1815D9C60")]
	[IteratorStateMachine(typeof(MGOCDEMFEDI<, >))]
	public static IEnumerable<TOk?>? FKNGCPJODMK<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x703FB0", Offset = "0x7033B0")] this IEnumerable<ADOGIEMPLPD<TOk?, TErr?>>? ODBHDBFBMOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class MKHGJGIONJF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1BC2FD0", Offset = "0x1BC23D0", VA = "0x181BC2FD0")]
	public static ADOGIEMPLPD<TOk, T> HAEIFKDHBPD<TOk>(in TOk FFOCCPIIAOD) where TOk : notnull
	{
		return default(ADOGIEMPLPD<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2C09F90", Offset = "0x2C09390", VA = "0x182C09F90")]
	public static ADOGIEMPLPD<PNGLJAGHHDL, T> HAEIFKDHBPD()
	{
		return default(ADOGIEMPLPD<PNGLJAGHHDL, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1BC3090", Offset = "0x1BC2490", VA = "0x181BC3090")]
	public static ADOGIEMPLPD<T, TErr> MNAJGABAAJF<TErr>(in TErr KKHNEKNEEDJ) where TErr : notnull
	{
		return default(ADOGIEMPLPD<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct AJAANKKCNBO
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate bool NPGIEIPHJAF(string AOBBNOGOIFP, AJAANKKCNBO LGABOBOJIPK);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int HIMOPIMKOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public string BIAGBDPIHJA;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7195F70", Offset = "0x7195370", VA = "0x187195F70")]
	public static Dictionary<string, AJAANKKCNBO> EECOLFDOOFH(Type AFJFEPCGIJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7196260", Offset = "0x7195660", VA = "0x187196260")]
	public static Dictionary<string, AJAANKKCNBO> FIPNIMNBFHI(Type AFJFEPCGIJM, NPGIEIPHJAF LEGABPBIJMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x71966D0", Offset = "0x7195AD0", VA = "0x1871966D0")]
	public static Dictionary<int, string> JPKBLKCNIEF(Dictionary<string, AJAANKKCNBO> OIEACLJHHPB)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct MOFIBMKDDKO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60")]
	public static MOFIBMKDDKO DJKLNEJICMK(Type GANFKPHKNKH, [Optional] string? HHEMMJPCFOM, [Optional] string? FAMPCLKIONB, bool HIGIPEDGEMA = false)
	{
		return default(MOFIBMKDDKO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60")]
	public static MOFIBMKDDKO DJKLNEJICMK<T>([Optional] string? HHEMMJPCFOM, [Optional] string? FAMPCLKIONB, bool HIGIPEDGEMA = false)
	{
		return default(MOFIBMKDDKO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class ANGADIOHMMB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class CHINBPEBPMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public CHINBPEBPMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x30A2090", Offset = "0x30A1490", VA = "0x1830A2090")]
		internal int DDOLNGEGBNM(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x704010", Offset = "0x703410")]
	private HashSet<T> KKDDOIAGHBK;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public IReadOnlyCollection<T> DKOFHKIOLDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x30D3440", Offset = "0x30D2840", VA = "0x1830D3440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool HJLBKFDCDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x30D3410", Offset = "0x30D2810", VA = "0x1830D3410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int HIBMACOFNKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x978170", Offset = "0x977570", VA = "0x180978170")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD50", Offset = "0x8BB150", VA = "0x1808BBD50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x30D3580", Offset = "0x30D2980", VA = "0x1830D3580")]
	public bool NNFBEGDMHOD(T AEMEEHLIDCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x30D3460", Offset = "0x30D2860", VA = "0x1830D3460")]
	public bool LOBOHMPHNJE(T AEMEEHLIDCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x30D3540", Offset = "0x30D2940", VA = "0x1830D3540")]
	public bool NDHLGOCFLHK(T AEMEEHLIDCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x30D36C0", Offset = "0x30D2AC0", VA = "0x1830D36C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
	public ANGADIOHMMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class IBNOLCFAKOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly string GDHLGPNBDHA;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x8C4170", Offset = "0x8C3570", VA = "0x1808C4170")]
	public IBNOLCFAKOG(string GDHLGPNBDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7197390", Offset = "0x7196790", VA = "0x187197390", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class GLMKJHJBJDA
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class MNJDKLPLJGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public MNJDKLPLJGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7197980", Offset = "0x7196D80", VA = "0x187197980")]
		internal int DDOLNGEGBNM(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x704070", Offset = "0x703470")]
	private HashSet<object> KKDDOIAGHBK;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public IReadOnlyCollection<object> DKOFHKIOLDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7196C30", Offset = "0x7196030", VA = "0x187196C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool HJLBKFDCDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7196C20", Offset = "0x7196020", VA = "0x187196C20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public int HIBMACOFNKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x978170", Offset = "0x977570", VA = "0x180978170")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD50", Offset = "0x8BB150", VA = "0x1808BBD50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7196E00", Offset = "0x7196200", VA = "0x187196E00")]
	public bool NNFBEGDMHOD(object AEMEEHLIDCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x7196D00", Offset = "0x7196100", VA = "0x187196D00")]
	public bool LOBOHMPHNJE(object AEMEEHLIDCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x7196DA0", Offset = "0x71961A0", VA = "0x187196DA0")]
	public bool NDHLGOCFLHK(object AEMEEHLIDCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x7196BB0", Offset = "0x7195FB0", VA = "0x187196BB0")]
	public void FFPCBJDDGFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x7196EE0", Offset = "0x71962E0", VA = "0x187196EE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public GLMKJHJBJDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class HIANALMEENI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct DKKBHHMHFEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float PIMAMNNFCBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public T EKGBCCDIAJC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7040D0", Offset = "0x7034D0")]
	private readonly Dictionary<object, HIANALMEENI<T>.DKKBHHMHFEH> IOKFOMHMAHF;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public virtual T LBNLBEPHIMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x1122D70", Offset = "0x1122170", VA = "0x181122D70", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x1121990", Offset = "0x1120D90", VA = "0x181121990", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public object? NIBKCDKCMJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x823B60", Offset = "0x822F60", VA = "0x180823B60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8BA4C0", Offset = "0x8B98C0", VA = "0x1808BA4C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool MFLIJOIMCBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2080D00", Offset = "0x2080100", VA = "0x182080D00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2082AA0", Offset = "0x2081EA0", VA = "0x182082AA0")]
	public bool PPPGPECFDDD(T AGLCIEKHLEE, object AEMEEHLIDCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2080CA0", Offset = "0x20800A0", VA = "0x182080CA0")]
	public bool LPAOHDMOPAN(object AEMEEHLIDCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2082650", Offset = "0x2081A50", VA = "0x182082650")]
	public void PDPMCCCKLBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x20809A0", Offset = "0x207FDA0", VA = "0x1820809A0")]
	public bool CLFAJBNDMHA(object AEMEEHLIDCM, out T AGLCIEKHLEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2081C60", Offset = "0x2081060", VA = "0x182081C60")]
	private bool OEBMIELIOIJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2083150", Offset = "0x2082550", VA = "0x182083150")]
	public HIANALMEENI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class HANKLELBLMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly Dictionary<object, float> IOKFOMHMAHF;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public float JKKAEDJGJFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x985820", Offset = "0x984C20", VA = "0x180985820")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xFA27E0", Offset = "0xFA1BE0", VA = "0x180FA27E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x71972A0", Offset = "0x71966A0", VA = "0x1871972A0")]
	public void PPPGPECFDDD(float AGLCIEKHLEE, object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7197230", Offset = "0x7196630", VA = "0x187197230")]
	public void LPAOHDMOPAN(object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7197110", Offset = "0x7196510", VA = "0x187197110")]
	private void IGIGGFFJCDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7197310", Offset = "0x7196710", VA = "0x187197310")]
	public HANKLELBLMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public delegate void FGJHIBLKFBB(float HJHGEAOCBMB);
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class EEDENOPBGEE
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private class GAGAECFOCPJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly FGEHDHMGPHB OAKFJIKHKFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly FGJHIBLKFBB IPDGCBIIEII;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7196B20", Offset = "0x7195F20", VA = "0x187196B20")]
		public GAGAECFOCPJ(FGEHDHMGPHB OAKFJIKHKFG, FGJHIBLKFBB IPDGCBIIEII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7196AD0", Offset = "0x7195ED0", VA = "0x187196AD0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7196940", Offset = "0x7195D40", VA = "0x187196940")]
	internal static bool HBMLEDEGBJJ(float NPBBJPKPNCJ, float KBAEKPMBMFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x523FE10", Offset = "0x523F210", VA = "0x18523FE10")]
	internal static float GKKFMJBMOOM(float NPBBJPKPNCJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7196880", Offset = "0x7195C80", VA = "0x187196880")]
	public static IDisposable FIMCPKNHHAD(this FGEHDHMGPHB OAKFJIKHKFG, FGJHIBLKFBB IPDGCBIIEII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class AACAPNPHAPG : FGEHDHMGPHB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public readonly struct AIBGCAHGKIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly float OPKOFIPIHJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public readonly float NPJNKCPHLIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		internal readonly bool NNGOFJDJNOF;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float MMHHHCFJGNH
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x7195C80", Offset = "0x7195080", VA = "0x187195C80")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7195E10", Offset = "0x7195210", VA = "0x187195E10")]
		public AIBGCAHGKIJ(float OANIJIEMEHN, float ELBJBJNOEIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x7195C90", Offset = "0x7195090", VA = "0x187195C90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class EOPEHCNGKLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public AACAPNPHAPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public EOPEHCNGKLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x71969C0", Offset = "0x7195DC0", VA = "0x1871969C0")]
		internal void LKOCPJLNFKJ(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly int GLDHDJHPIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private int BBPDOPELOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly FGEHDHMGPHB[] DLNJEACNCCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly FGJHIBLKFBB[] EOPIGBOAJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly AIBGCAHGKIJ[] FAOMJFJBBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private AIBGCAHGKIJ FMPDKEJJEGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly KDKPDCAOKBD FGFMJDDADEM;

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event FGJHIBLKFBB DOACPPDFDGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7195600", Offset = "0x7194A00", VA = "0x187195600", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x71954B0", Offset = "0x71948B0", VA = "0x1871954B0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7195B00", Offset = "0x7194F00", VA = "0x187195B00")]
	public AACAPNPHAPG(int GLDHDJHPIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7195570", Offset = "0x7194970", VA = "0x187195570")]
	public KDKPDCAOKBD IPKEAHAPHIG(AIBGCAHGKIJ KBMIFPNEOLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x71956C0", Offset = "0x7194AC0", VA = "0x1871956C0")]
	public void OJPFLHDMOFG(FGEHDHMGPHB GKHGGCLLLLE, [Optional] AIBGCAHGKIJ GEKEHMGLFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x71953A0", Offset = "0x71947A0", VA = "0x1871953A0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class KDKPDCAOKBD : FGEHDHMGPHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private float HJHGEAOCBMB;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public float INHFFLLHJDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7197590", Offset = "0x7196990", VA = "0x187197590")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event FGJHIBLKFBB? DOACPPDFDGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x71974F0", Offset = "0x71968F0", VA = "0x1871974F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7197450", Offset = "0x7196850", VA = "0x187197450", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public KDKPDCAOKBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface FGEHDHMGPHB
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event FGJHIBLKFBB DOACPPDFDGA;
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
