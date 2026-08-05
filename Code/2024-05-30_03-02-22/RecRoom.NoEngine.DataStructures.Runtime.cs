using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7F2B00", Offset = "0x7F1D00", VA = "0x1807F2B00")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x64B7BC0", Offset = "0x64B6DC0", VA = "0x1864B7BC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7F3A00", Offset = "0x7F2C00", VA = "0x1807F3A00")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7F3A40", Offset = "0x7F2C40", VA = "0x1807F3A40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class GMLEBBBCLEH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	protected GMLEBBBCLEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class GEJEIBJIEHO<T> : GMLEBBBCLEH
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct DNCHIKACEBD
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum KALLMOBHDJH
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
		public KALLMOBHDJH HHJOOHJDNNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T BGMBJALDBDD;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int NFEJNMPFLEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool LNDIMFIFFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool POOPDPDJAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? JPEBOKGPEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<DNCHIKACEBD>? GLKKNIFHOEA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool MEICODMFMLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x39C5E00", Offset = "0x39C5000", VA = "0x1839C5E00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x39C6680", Offset = "0x39C5880", VA = "0x1839C6680")]
	protected GEJEIBJIEHO(bool POOPDPDJAHK, bool LNDIMFIFFFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x39C6330", Offset = "0x39C5530", VA = "0x1839C6330")]
	protected bool JMCJHPEMIGI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x39C63D0", Offset = "0x39C55D0", VA = "0x1839C63D0")]
	protected void KAPCPCNNBMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x39C6160", Offset = "0x39C5360", VA = "0x1839C6160")]
	protected void FEDFCGBGFKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2869230", Offset = "0x2868430", VA = "0x182869230")]
	private static void NNABPEEKFJO<U>(List<U>? AIMBMINBCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x39C64C0", Offset = "0x39C56C0", VA = "0x1839C64C0", Slot = "4")]
	public void LGLNKEHGBKE(T BGMBJALDBDD, bool CDGDPDFNFFA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x39C5FC0", Offset = "0x39C51C0", VA = "0x1839C5FC0", Slot = "5")]
	public void BIFLKBKPGJE(T BGMBJALDBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x39C5E50", Offset = "0x39C5050", VA = "0x1839C5E50")]
	public void BFDHFEEMFPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface OAMPEDDNNPI
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LGLNKEHGBKE(Action BGMBJALDBDD, bool CDGDPDFNFFA = false);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BIFLKBKPGJE(Action BGMBJALDBDD);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class OJHEJHCKNBB : GEJEIBJIEHO<Action>, OAMPEDDNNPI
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x64B7F60", Offset = "0x64B7160", VA = "0x1864B7F60")]
	public OJHEJHCKNBB(bool POOPDPDJAHK = false, bool LNDIMFIFFFH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x64B7D60", Offset = "0x64B6F60", VA = "0x1864B7D60")]
	public void IPKFGEDDFJP()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x64B7CA0", Offset = "0x64B6EA0", VA = "0x1864B7CA0")]
	public static OJHEJHCKNBB CJEHLBODIDA(OJHEJHCKNBB HLICNPNCIBA, Action BGMBJALDBDD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x64B7D00", Offset = "0x64B6F00", VA = "0x1864B7D00")]
	public static OJHEJHCKNBB HFGNJBDEAKI(OJHEJHCKNBB HLICNPNCIBA, Action BGMBJALDBDD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface PFOPDNFAAAH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LGLNKEHGBKE(Action<T> BGMBJALDBDD, bool CDGDPDFNFFA = false);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BIFLKBKPGJE(Action<T> BGMBJALDBDD);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class HKGPCDCMJHO<T> : GEJEIBJIEHO<Action<T>>, PFOPDNFAAAH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x355FB60", Offset = "0x355ED60", VA = "0x18355FB60")]
	public HKGPCDCMJHO(bool POOPDPDJAHK = false, bool LNDIMFIFFFH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3A48610", Offset = "0x3A47810", VA = "0x183A48610")]
	public void IPKFGEDDFJP(T GIHFGGLMPDC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x355F290", Offset = "0x355E490", VA = "0x18355F290")]
	public static HKGPCDCMJHO<T> CJEHLBODIDA(HKGPCDCMJHO<T> HLICNPNCIBA, Action<T> BGMBJALDBDD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x355F320", Offset = "0x355E520", VA = "0x18355F320")]
	public static HKGPCDCMJHO<T> HFGNJBDEAKI(HKGPCDCMJHO<T> HLICNPNCIBA, Action<T> BGMBJALDBDD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface IFAPMCHOFML<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class LKAEANPNDGO<T, U> : GEJEIBJIEHO<Action<T, U>>, IFAPMCHOFML<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x355FB60", Offset = "0x355ED60", VA = "0x18355FB60")]
	public LKAEANPNDGO(bool POOPDPDJAHK = false, bool LNDIMFIFFFH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3F61DA0", Offset = "0x3F60FA0", VA = "0x183F61DA0")]
	public void IPKFGEDDFJP(T GIHFGGLMPDC, U GNHEACLMDPG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x355F290", Offset = "0x355E490", VA = "0x18355F290")]
	public static LKAEANPNDGO<T, U> CJEHLBODIDA(LKAEANPNDGO<T, U> HLICNPNCIBA, Action<T, U> BGMBJALDBDD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x355F320", Offset = "0x355E520", VA = "0x18355F320")]
	public static LKAEANPNDGO<T, U> HFGNJBDEAKI(LKAEANPNDGO<T, U> HLICNPNCIBA, Action<T, U> BGMBJALDBDD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class KDOKJMBKLDA<T, U, V> : GEJEIBJIEHO<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x355FB60", Offset = "0x355ED60", VA = "0x18355FB60")]
	public KDOKJMBKLDA(bool POOPDPDJAHK = false, bool LNDIMFIFFFH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3E4DF50", Offset = "0x3E4D150", VA = "0x183E4DF50")]
	public void IPKFGEDDFJP(T GIHFGGLMPDC, U GNHEACLMDPG, V HCFEJGBILDB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x355F290", Offset = "0x355E490", VA = "0x18355F290")]
	public static KDOKJMBKLDA<T, U, V> CJEHLBODIDA(KDOKJMBKLDA<T, U, V> HLICNPNCIBA, Action<T, U, V> BGMBJALDBDD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x355F320", Offset = "0x355E520", VA = "0x18355F320")]
	public static KDOKJMBKLDA<T, U, V> HFGNJBDEAKI(KDOKJMBKLDA<T, U, V> HLICNPNCIBA, Action<T, U, V> BGMBJALDBDD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface AELEJFIIBDB<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class IECDBHDLEGO<T, U, V, W> : GEJEIBJIEHO<Action<T, U, V, W>>, AELEJFIIBDB<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x355FB60", Offset = "0x355ED60", VA = "0x18355FB60")]
	public IECDBHDLEGO(bool POOPDPDJAHK = false, bool LNDIMFIFFFH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3B08060", Offset = "0x3B07260", VA = "0x183B08060")]
	public void IPKFGEDDFJP(T GIHFGGLMPDC, U GNHEACLMDPG, V HCFEJGBILDB, W EDEGHDPMPJM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x355F290", Offset = "0x355E490", VA = "0x18355F290")]
	public static IECDBHDLEGO<T, U, V, W> CJEHLBODIDA(IECDBHDLEGO<T, U, V, W> HLICNPNCIBA, Action<T, U, V, W> BGMBJALDBDD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x355F320", Offset = "0x355E520", VA = "0x18355F320")]
	public static IECDBHDLEGO<T, U, V, W> HFGNJBDEAKI(IECDBHDLEGO<T, U, V, W> HLICNPNCIBA, Action<T, U, V, W> BGMBJALDBDD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class EBCFAOBIBMO<T, U, V, W, X> : GEJEIBJIEHO<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x355FB60", Offset = "0x355ED60", VA = "0x18355FB60")]
	public EBCFAOBIBMO(bool POOPDPDJAHK = false, bool LNDIMFIFFFH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x355F3B0", Offset = "0x355E5B0", VA = "0x18355F3B0")]
	public void IPKFGEDDFJP(T GIHFGGLMPDC, U GNHEACLMDPG, V HCFEJGBILDB, W EDEGHDPMPJM, X DCHJALFCEJF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x355F290", Offset = "0x355E490", VA = "0x18355F290")]
	public static EBCFAOBIBMO<T, U, V, W, X> CJEHLBODIDA(EBCFAOBIBMO<T, U, V, W, X> HLICNPNCIBA, Action<T, U, V, W, X> BGMBJALDBDD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x355F320", Offset = "0x355E520", VA = "0x18355F320")]
	public static EBCFAOBIBMO<T, U, V, W, X> HFGNJBDEAKI(EBCFAOBIBMO<T, U, V, W, X> HLICNPNCIBA, Action<T, U, V, W, X> BGMBJALDBDD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class NMIKFIMDODN<T, U, V, W, X, Y> : GEJEIBJIEHO<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x355FB60", Offset = "0x355ED60", VA = "0x18355FB60")]
	public NMIKFIMDODN(bool POOPDPDJAHK = false, bool LNDIMFIFFFH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x41CCB20", Offset = "0x41CBD20", VA = "0x1841CCB20")]
	public void IPKFGEDDFJP(T GIHFGGLMPDC, U GNHEACLMDPG, V HCFEJGBILDB, W EDEGHDPMPJM, X DCHJALFCEJF, Y JFJIMNMJLJE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x355F290", Offset = "0x355E490", VA = "0x18355F290")]
	public static NMIKFIMDODN<T, U, V, W, X, Y> CJEHLBODIDA(NMIKFIMDODN<T, U, V, W, X, Y> HLICNPNCIBA, Action<T, U, V, W, X, Y> BGMBJALDBDD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x355F320", Offset = "0x355E520", VA = "0x18355F320")]
	public static NMIKFIMDODN<T, U, V, W, X, Y> HFGNJBDEAKI(NMIKFIMDODN<T, U, V, W, X, Y> HLICNPNCIBA, Action<T, U, V, W, X, Y> BGMBJALDBDD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class LMKFAIFNKKP<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly KFHOENHGDEO<TKey, TVal> KMDDADCPEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> FPHCKPMOBIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly KFHOENHGDEO<TKey, TVal>.HDEHAMHEILF? JCCEPAJGFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int KFLHNCCMMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly KFHOENHGDEO<TKey, TVal>.JIHPNGKDPHB? OPPKPBOFEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int IPJEOFIAAGH;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int HPPEENFCIDI
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3F6F050", Offset = "0x3F6E250", VA = "0x183F6F050")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int BLFJFFIPIBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7CDFF0", Offset = "0x7CD1F0", VA = "0x1807CDFF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3F6F1B0", Offset = "0x3F6E3B0", VA = "0x183F6F1B0")]
	public LMKFAIFNKKP(int KFLHNCCMMNP, [Optional] KFHOENHGDEO<TKey, TVal>.JIHPNGKDPHB? OPPKPBOFEPH, [Optional] IEqualityComparer<TKey>? MHCNJIJGGND, [Optional] KFHOENHGDEO<TKey, TVal>.HDEHAMHEILF? JCCEPAJGFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3F6E900", Offset = "0x3F6DB00", VA = "0x183F6E900")]
	public void IBNKLDOABDN(TKey MNOIAMGNLNL, TVal HLCKBKFCMPI, bool JEGILAJHHDF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3F6E5A0", Offset = "0x3F6D7A0", VA = "0x183F6E5A0")]
	public bool DNILLOIAHIK(TKey MNOIAMGNLNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3F6E830", Offset = "0x3F6DA30", VA = "0x183F6E830")]
	public bool GMADCLHMMHE(TKey AOIPADELMCO, [Out] TVal HLCKBKFCMPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3F6E370", Offset = "0x3F6D570", VA = "0x183F6E370")]
	private void CPNFIOBMCDN(TKey MNOIAMGNLNL, TVal HLCKBKFCMPI, int AGHIAPEPFJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3F6E6C0", Offset = "0x3F6D8C0", VA = "0x183F6E6C0")]
	public bool EMGBGEFGCAG(TKey MNOIAMGNLNL, TVal HLCKBKFCMPI, bool JEGILAJHHDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3F6E310", Offset = "0x3F6D510", VA = "0x183F6E310")]
	public void BFDHFEEMFPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3F6EB90", Offset = "0x3F6DD90", VA = "0x183F6EB90")]
	private void ILFBIECJILO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3F6EAB0", Offset = "0x3F6DCB0", VA = "0x183F6EAB0")]
	private bool IHCOPHGNOBK(TKey MNOIAMGNLNL, FMDLIMNANNN NCKBEFBPNFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3F6E240", Offset = "0x3F6D440", VA = "0x183F6E240")]
	private void APMGHANHOOB(TKey MNOIAMGNLNL, TVal HLCKBKFCMPI, FMDLIMNANNN NCKBEFBPNFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3F6F090", Offset = "0x3F6E290", VA = "0x183F6F090")]
	private void NGOBHDAEPCC(TKey MNOIAMGNLNL, TVal LGIDDHPGAND, FMDLIMNANNN NCKBEFBPNFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class MLDCJAJIAPB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action CPNBMIACBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool JFPMEHEECIH;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7D5B00", Offset = "0x7D4D00", VA = "0x1807D5B00")]
	public MLDCJAJIAPB(Action JJBMIHNECNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x64B78A0", Offset = "0x64B6AA0", VA = "0x1864B78A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2773AD0", Offset = "0x2772CD0", VA = "0x182773AD0")]
	public static PHKGJMALLOJ<T> ADOMMGOMPJC<T>(T HLCKBKFCMPI, Action JJBMIHNECNF) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class PHKGJMALLOJ<T> : MLDCJAJIAPB where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T OGADOHBOMGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4C0", Offset = "0x7CA6C0", VA = "0x1807CB4C0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x43B2670", Offset = "0x43B1870", VA = "0x1843B2670")]
	public PHKGJMALLOJ(T HLCKBKFCMPI, Action JJBMIHNECNF)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct BPDAEKAOABP : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct EJKMCACJODA : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360")]
		public static EJKMCACJODA EPPBEPCPNMI()
		{
			return default(EJKMCACJODA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2778550", Offset = "0x2777750", VA = "0x182778550")]
	public static string? BINEAEFJIJA<T>([Optional] string? OKODHJDDMIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x27785D0", Offset = "0x27777D0", VA = "0x1827785D0")]
	public static string? GJPPDBMMGAI<T>([Optional] string? FIMNMBKJLBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360")]
	public static BPDAEKAOABP EOEPFJDEGGL(string OKODHJDDMIE, string? FIMNMBKJLBF)
	{
		return default(BPDAEKAOABP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct CMCAOCKOAAO
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool ECKLIKBGOAF(string CKKPAGECFDI, CMCAOCKOAAO JEALBLJNILE);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class KCGLJKLKLGF<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public KCGLJKLKLGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3E45990", Offset = "0x3E44B90", VA = "0x183E45990")]
		internal void ONKMJHBOEGP(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public int GAPFLOIFLPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public string DNPACJCPBFN;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x64B5430", Offset = "0x64B4630", VA = "0x1864B5430")]
	public static Dictionary<string, CMCAOCKOAAO> GLOEBLHMAFL(Type FKMLOAALOEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x27CFA40", Offset = "0x27CEC40", VA = "0x1827CFA40")]
	public static Dictionary<string, CMCAOCKOAAO> GLOEBLHMAFL<T>(Type FKMLOAALOEK, IReadOnlyDictionary<T, string> HHOOJAICMIP) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x27D0260", Offset = "0x27CF460", VA = "0x1827D0260")]
	public static Dictionary<string, CMCAOCKOAAO> NGBLCANIGBK<T>(List<T> NMKBONMKEIB) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x64B5760", Offset = "0x64B4960", VA = "0x1864B5760")]
	public static Dictionary<string, CMCAOCKOAAO> KDCCELOCCGK(Type FKMLOAALOEK, ECKLIKBGOAF KBDDKALKMLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x64B5270", Offset = "0x64B4470", VA = "0x1864B5270")]
	public static Dictionary<int, string> CHJEKHGMMGI(Dictionary<string, CMCAOCKOAAO> GNIGPOPNBEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class GCNNAKAAMEK : NFEBAOOCHCK
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static bool PGNDMOBDLAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly string? MHBGGMPBLEP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public virtual NFEBAOOCHCK? OIGFFAEMHBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7C9E00", Offset = "0x7C9000", VA = "0x1807C9E00", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x64B6EF0", Offset = "0x64B60F0", VA = "0x1864B6EF0")]
	protected GCNNAKAAMEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string HDHLJKIJNJB();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x64B6950", Offset = "0x64B5B50", VA = "0x1864B6950", Slot = "8")]
	public virtual string CNMIGJBMIDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x64B69D0", Offset = "0x64B5BD0", VA = "0x1864B69D0", Slot = "9")]
	public void EKFAHOEKGBC(StringBuilder CNBHEHKJHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x64B68F0", Offset = "0x64B5AF0", VA = "0x1864B68F0", Slot = "10")]
	public void CKDFILCHPEJ(StringBuilder CNBHEHKJHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x64B6DD0", Offset = "0x64B5FD0", VA = "0x1864B6DD0", Slot = "11")]
	public void FJMFKHDBIKI(StringBuilder CNBHEHKJHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x64B6C70", Offset = "0x64B5E70", VA = "0x1864B6C70", Slot = "12")]
	public void FCOKLFGACOB(StringBuilder CNBHEHKJHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x64B6850", Offset = "0x64B5A50", VA = "0x1864B6850")]
	public static void CGPIDHAEHBE(StringBuilder CNBHEHKJHAN, string CFLNFAEFGJP, string IILNAAOEKDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x56D7900", Offset = "0x56D6B00", VA = "0x1856D7900", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class OABEILGLKCO : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x64B7C40", Offset = "0x64B6E40", VA = "0x1864B7C40")]
	public OABEILGLKCO(string PPGBBBOBJLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class HKKADBEPGFA<TErr> : OABEILGLKCO where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly TErr DCEDKBNEGAO;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3A49820", Offset = "0x3A48A20", VA = "0x183A49820")]
	private HKKADBEPGFA([In] TErr CHKHDPFHBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3A49760", Offset = "0x3A48960", VA = "0x183A49760")]
	public static HKKADBEPGFA<TErr> EPPBEPCPNMI([In] TErr CHKHDPFHBHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface NFEBAOOCHCK
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string CNMIGJBMIDL();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string HDHLJKIJNJB();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface JMMBAGLKBOL<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	TOptions OGADOHBOMGE
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface GNIPINJKMKJ
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string CNCDICBIDIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class KAKOELCMAMJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x64B7560", Offset = "0x64B6760", VA = "0x1864B7560")]
	public KAKOELCMAMJ(string PPGBBBOBJLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class GKHFMMCMKKF<TOk> : KAKOELCMAMJ where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly TOk OAOEMILODPH;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x39DA320", Offset = "0x39D9520", VA = "0x1839DA320")]
	private GKHFMMCMKKF([In] TOk JLBKDCOMKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x39AB2A0", Offset = "0x39AA4A0", VA = "0x1839AB2A0")]
	public static GKHFMMCMKKF<TOk> EPPBEPCPNMI([In] TOk JLBKDCOMKOL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct GDHFNIGIAEI<TOk, TErr> : IEquatable<GDHFNIGIAEI<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static readonly EqualityComparer<TErr> GJNKKHFBNJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal readonly TErr DCEDKBNEGAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal readonly TOk OAOEMILODPH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool FMOJBGEANMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x39BB170", Offset = "0x39BA370", VA = "0x1839BB170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool NCHCOFLDPBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x39BCFC0", Offset = "0x39BC1C0", VA = "0x1839BCFC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x39BFCA0", Offset = "0x39BEEA0", VA = "0x1839BFCA0")]
	internal GDHFNIGIAEI([In] TErr CHKHDPFHBHG, [In] TOk JLBKDCOMKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x39BAEE0", Offset = "0x39BA0E0", VA = "0x1839BAEE0")]
	public static GDHFNIGIAEI<TOk, TErr> KEMCFHMKNOP([In] TErr CHKHDPFHBHG)
	{
		return default(GDHFNIGIAEI<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x39B94B0", Offset = "0x39B86B0", VA = "0x1839B94B0")]
	public static GDHFNIGIAEI<TOk, TErr> FKPLBPJLJFB([In] TOk JLBKDCOMKOL)
	{
		return default(GDHFNIGIAEI<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x28671C0", Offset = "0x28663C0", VA = "0x1828671C0")]
	public GDHFNIGIAEI<TOk?, UErr?> JCBFNPLLIHJ<UErr>()
	{
		return default(GDHFNIGIAEI<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2868C90", Offset = "0x2867E90", VA = "0x182868C90")]
	public GDHFNIGIAEI<UOk?, TErr?> JMLNLPHMCGJ<UOk>()
	{
		return default(GDHFNIGIAEI<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2868320", Offset = "0x2867520", VA = "0x182868320")]
	public GDHFNIGIAEI<UOk?, TErr?> JDJMLPKEJJN<UOk>()
	{
		return default(GDHFNIGIAEI<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x28670B0", Offset = "0x28662B0", VA = "0x1828670B0")]
	public GDHFNIGIAEI<TOk?, UErr?> FGOALGBDHPP<UErr>()
	{
		return default(GDHFNIGIAEI<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x39BCB40", Offset = "0x39BBD40", VA = "0x1839BCB40")]
	public GDHFNIGIAEI<PJGNGDCIDLA, TErr> MLMNBEPMDCO()
	{
		return default(GDHFNIGIAEI<PJGNGDCIDLA, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x39BBCB0", Offset = "0x39BAEB0", VA = "0x1839BBCB0")]
	public static bool LOAKJDDAMKI([In] GDHFNIGIAEI<TOk, TErr> ABPADDODFDF, [In] GDHFNIGIAEI<TOk, TErr> DLCDCNECDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x39B8210", Offset = "0x39B7410", VA = "0x1839B8210", Slot = "4")]
	public bool Equals(GDHFNIGIAEI<TOk, TErr> JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x39B8750", Offset = "0x39B7950", VA = "0x1839B8750", Slot = "0")]
	public override bool Equals(object JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x39B9A20", Offset = "0x39B8C20", VA = "0x1839B9A20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x39BF8E0", Offset = "0x39BEAE0", VA = "0x1839BF8E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class OAPLCBOIBFM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct BFCIBGHDJDM<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public Task<GDHFNIGIAEI<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<GDHFNIGIAEI<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x4A50CD0", Offset = "0x4A4FED0", VA = "0x184A50CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x4A515D0", Offset = "0x4A507D0", VA = "0x184A515D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2AED300", Offset = "0x2AEC500", VA = "0x182AED300")]
	public static GDHFNIGIAEI<TOk?, TErr?> OAOEMILODPH<TOk, TErr>([In] this GDHFNIGIAEI<TOk, TErr> CJKIBFNGPNM, [In] TOk JLBKDCOMKOL)
	{
		return default(GDHFNIGIAEI<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2AEF390", Offset = "0x2AEE590", VA = "0x182AEF390")]
	public static GDHFNIGIAEI<PJGNGDCIDLA, TErr?> OAOEMILODPH<TErr>([In] this GDHFNIGIAEI<PJGNGDCIDLA, TErr> CJKIBFNGPNM)
	{
		return default(GDHFNIGIAEI<PJGNGDCIDLA, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2AED300", Offset = "0x2AEC500", VA = "0x182AED300")]
	public static GDHFNIGIAEI<TOk?, TErr?> DCEDKBNEGAO<TOk, TErr>([In] this GDHFNIGIAEI<TOk, TErr> CJKIBFNGPNM, [In] TErr CHKHDPFHBHG)
	{
		return default(GDHFNIGIAEI<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2AEED10", Offset = "0x2AEDF10", VA = "0x182AEED10")]
	public static TOk? LEOALMBHOJP<TOk, TErr>([In] this GDHFNIGIAEI<TOk, TErr> CJKIBFNGPNM)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2AED8B0", Offset = "0x2AECAB0", VA = "0x182AED8B0")]
	[AsyncStateMachine(typeof(BFCIBGHDJDM<, >))]
	public static Task<TOk?>? INIMDEAALEA<TOk, TErr>(this Task<GDHFNIGIAEI<TOk, TErr>> CJKIBFNGPNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2AEF990", Offset = "0x2AEEB90", VA = "0x182AEF990")]
	public static TErr? PJONOPKJGND<TErr, TOk>([In] this GDHFNIGIAEI<TOk, TErr> CJKIBFNGPNM)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2AEDB50", Offset = "0x2AECD50", VA = "0x182AEDB50")]
	public static bool KFFAIHHNJAO<TOk, TErr, UErr, UOk>([In] this GDHFNIGIAEI<TOk, TErr> CJKIBFNGPNM, [Out] GDHFNIGIAEI<UOk, UErr> EDEOENHHKGJ) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2AED410", Offset = "0x2AEC610", VA = "0x182AED410")]
	public static bool FBLLDKLOIMC<TOk, TErr>([In] this GDHFNIGIAEI<TOk, TErr> CJKIBFNGPNM, [Out][NotNullWhen(true)] TOk JLBKDCOMKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2AEF150", Offset = "0x2AEE350", VA = "0x182AEF150")]
	public static bool MPDJEICODCE<TOk, TErr>([In] this GDHFNIGIAEI<TOk, TErr> CJKIBFNGPNM, [Out][NotNullWhen(true)] TErr CHKHDPFHBHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2AECC50", Offset = "0x2AEBE50", VA = "0x182AECC50")]
	public static bool AMBIJHDHOGL<TOk, TErr>([In] this GDHFNIGIAEI<TOk, TErr> CJKIBFNGPNM, [Out][NotNullWhen(true)] TOk JLBKDCOMKOL, [Out][NotNullWhen(false)] TErr CHKHDPFHBHG) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2AEF290", Offset = "0x2AEE490", VA = "0x182AEF290")]
	public static bool NKOLCPELDBD<TOk, TErr>([In] this GDHFNIGIAEI<TOk, TErr> CJKIBFNGPNM, [Out][NotNullWhen(true)] TOk JLBKDCOMKOL, [Out] GDHFNIGIAEI<TOk, TErr> EDEOENHHKGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2AEDC60", Offset = "0x2AECE60", VA = "0x182AEDC60")]
	public static bool KFFAIHHNJAO<TOk, TErr, UErr, UOk>([In] this GDHFNIGIAEI<TOk, TErr> CJKIBFNGPNM, [Out][NotNullWhen(true)] TOk JLBKDCOMKOL, [Out] GDHFNIGIAEI<UOk, UErr> EDEOENHHKGJ) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2AED550", Offset = "0x2AEC750", VA = "0x182AED550")]
	public static bool GKOAHBDHCHH<TOk, TErr>([In] this GDHFNIGIAEI<TOk, TErr> CJKIBFNGPNM, [Out][NotNullWhen(true)] TOk JLBKDCOMKOL, [Out] GDHFNIGIAEI<PJGNGDCIDLA, TErr> EDEOENHHKGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2AECF80", Offset = "0x2AEC180", VA = "0x182AECF80")]
	public static GDHFNIGIAEI<UOk, UErr> AMIKALFKOJM<UOk, UErr, TOk, TErr>([In] this GDHFNIGIAEI<TOk, TErr> CJKIBFNGPNM, [In] GDHFNIGIAEI<UOk, UErr> AOLAKAPHPCK) where TOk : UOk where TErr : UErr
	{
		return default(GDHFNIGIAEI<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2AEF400", Offset = "0x2AEE600", VA = "0x182AEF400")]
	public static GDHFNIGIAEI<TOk?[]?, TErr?> OMNHLGLLIDJ<TOk, TErr>(this IEnumerable<GDHFNIGIAEI<TOk, TErr>> CJKIBFNGPNM)
	{
		return default(GDHFNIGIAEI<TOk[], TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class GEGENKAPNBO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2868F10", Offset = "0x2868110", VA = "0x182868F10")]
	public static GDHFNIGIAEI<TOk, T> OAOEMILODPH<TOk>([In] TOk JLBKDCOMKOL) where TOk : notnull
	{
		return default(GDHFNIGIAEI<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x39C2A40", Offset = "0x39C1C40", VA = "0x1839C2A40")]
	public static GDHFNIGIAEI<PJGNGDCIDLA, T> OAOEMILODPH()
	{
		return default(GDHFNIGIAEI<PJGNGDCIDLA, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2868F10", Offset = "0x2868110", VA = "0x182868F10")]
	public static GDHFNIGIAEI<T, TErr> DCEDKBNEGAO<TErr>([In] TErr CHKHDPFHBHG) where TErr : notnull
	{
		return default(GDHFNIGIAEI<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public sealed class ONPEGMAPLAB<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private readonly struct JABJEMOIMKH : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly ONPEGMAPLAB<T> KFFKCHCFKNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly int MCGJOIDBJFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly bool FFGDMGGKHJI;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x1DAF5A0", Offset = "0x1DAE7A0", VA = "0x181DAF5A0")]
		public JABJEMOIMKH(ONPEGMAPLAB<T> FNFDOEGAMFP, int BEOJLLDECNO, bool PIJDAGFMGKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3CDCBC0", Offset = "0x3CDBDC0", VA = "0x183CDCBC0")]
		public ONPEGMAPLAB<T>.NEAEKHDJNBH KBKKLBPIAFK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x3CDCCA0", Offset = "0x3CDBEA0", VA = "0x183CDCCA0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x3CDCCA0", Offset = "0x3CDBEA0", VA = "0x183CDCCA0", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class NEAEKHDJNBH : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly ONPEGMAPLAB<T> KFFKCHCFKNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly int PNPLGABNOLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private int NKLGDJMCHOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly bool FFGDMGGKHJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private bool AHOJCNJJGMK;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T NPODDCIDCOP
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x419D140", Offset = "0x419C340", VA = "0x18419D140")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x419D2E0", Offset = "0x419C4E0", VA = "0x18419D2E0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x419D370", Offset = "0x419C570", VA = "0x18419D370", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x419DA50", Offset = "0x419CC50", VA = "0x18419DA50")]
		public NEAEKHDJNBH(ONPEGMAPLAB<T> FNFDOEGAMFP, int BEOJLLDECNO, bool PIJDAGFMGKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x419D240", Offset = "0x419C440", VA = "0x18419D240", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x419D2C0", Offset = "0x419C4C0", VA = "0x18419D2C0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class BCDJKFBOJEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public BCDJKFBOJEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x4A46180", Offset = "0x4A45380", VA = "0x184A46180")]
		internal T MBFHJGINPHH(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly T[] JBKFKIJBPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private int NKLGDJMCHOO;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int HMPJPMOFCIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x42F53C0", Offset = "0x42F45C0", VA = "0x1842F53C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public T NPODDCIDCOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x38E08E0", Offset = "0x38DFAE0", VA = "0x1838E08E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T DNHMKPKJANF
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x42F5480", Offset = "0x42F4680", VA = "0x1842F5480")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T FOFBNHMHKAA
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x42F52A0", Offset = "0x42F44A0", VA = "0x1842F52A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int BOHPGPGHAFI
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1844930", Offset = "0x1843B30", VA = "0x181844930")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1096C50", Offset = "0x1095E50", VA = "0x181096C50")]
	private static int HLHMOABNCIK(int PMNHOLIPOMJ, int MKCBFIBLIDD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x42F54B0", Offset = "0x42F46B0", VA = "0x1842F54B0")]
	public ONPEGMAPLAB(int AGHIAPEPFJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x42F5520", Offset = "0x42F4720", VA = "0x1842F5520")]
	public ONPEGMAPLAB(int AGHIAPEPFJE, Func<T> CHEJMMLBBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x42F59A0", Offset = "0x42F4BA0", VA = "0x1842F59A0")]
	public ONPEGMAPLAB(T[] GECPOPGBBAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x42F5180", Offset = "0x42F4380", VA = "0x1842F5180")]
	public void BLHEIPNHNDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x42F5300", Offset = "0x42F4500", VA = "0x1842F5300")]
	public IEnumerable<T> EPGMACPDFEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x42F5400", Offset = "0x42F4600", VA = "0x1842F5400")]
	public ONPEGMAPLAB<T>.NEAEKHDJNBH KBKKLBPIAFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x35A5F20", Offset = "0x35A5120", VA = "0x1835A5F20", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x35A5F20", Offset = "0x35A5120", VA = "0x1835A5F20", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class CLJPLLGHGKA
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x27CF4E0", Offset = "0x27CE6E0", VA = "0x1827CF4E0")]
	public static ONPEGMAPLAB<T> EPPBEPCPNMI<T>(int AGHIAPEPFJE, Func<T> CHEJMMLBBPG) where T : notnull
	{
		return null;
	}
}
namespace RecRoom.NoEngine.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct RRColor : IEquatable<RRColor>, IFormattable
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const float kEpsilon = 1E-05f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x1EAFDB0", Offset = "0x1EAEFB0", VA = "0x181EAFDB0")]
		public RRColor(float EHGBCDPMKNC, float HGCPBJILOOF, float NOIIDJMAOFK, float BPOHBPAMNLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x64B8010", Offset = "0x64B7210", VA = "0x1864B8010", Slot = "4")]
		public bool Equals(RRColor JPLJHFMPDFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x64B8090", Offset = "0x64B7290", VA = "0x1864B8090", Slot = "0")]
		public override bool Equals(object JPLJHFMPDFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x64B8190", Offset = "0x64B7390", VA = "0x1864B8190", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x64B8210", Offset = "0x64B7410", VA = "0x1864B8210", Slot = "5")]
		public string ToString(string IBEIMKOECHH, IFormatProvider NNNOBPBIOBI)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class OPKAAEGOEKP<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public readonly struct OADOEGGOONH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly OPKAAEGOEKP<T> PADHKJEBJGM;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public T OGADOHBOMGE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x427ECA0", Offset = "0x427DEA0", VA = "0x18427ECA0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x427EC70", Offset = "0x427DE70", VA = "0x18427EC70", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x877820", Offset = "0x876A20", VA = "0x180877820")]
		public OADOEGGOONH(OPKAAEGOEKP<T> PADHKJEBJGM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct DPMIAMJJPNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public AsyncTaskMethodBuilder<OADOEGGOONH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public OPKAAEGOEKP<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x534CDB0", Offset = "0x534BFB0", VA = "0x18534CDB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3F44650", Offset = "0x3F43850", VA = "0x183F44650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly SemaphoreSlim CGAFFGPGECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private T ODJHHINLGOI;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x430C680", Offset = "0x430B880", VA = "0x18430C680")]
	public OPKAAEGOEKP([In] T ODJHHINLGOI, int KHMOAKOOGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x430C5C0", Offset = "0x430B7C0", VA = "0x18430C5C0")]
	public OPKAAEGOEKP([In] T ODJHHINLGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x430C120", Offset = "0x430B320", VA = "0x18430C120", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x430C0E0", Offset = "0x430B2E0", VA = "0x18430C0E0")]
	public OADOEGGOONH DMLKCBHAGCP()
	{
		return default(OADOEGGOONH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x430C290", Offset = "0x430B490", VA = "0x18430C290")]
	[AsyncStateMachine(typeof(OPKAAEGOEKP<>.DPMIAMJJPNH))]
	public Task<OPKAAEGOEKP<T>.OADOEGGOONH> LNCODFLNPNB(CancellationToken GILHKFNDIJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x430C160", Offset = "0x430B360", VA = "0x18430C160")]
	public void FGMINJEIMNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class GADMCGPLDGM
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x64B67E0", Offset = "0x64B59E0", VA = "0x1864B67E0")]
	public static OPKAAEGOEKP<PJGNGDCIDLA> EPPBEPCPNMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2803900", Offset = "0x2802B00", VA = "0x182803900")]
	public static OPKAAEGOEKP<T> EPPBEPCPNMI<T>([In] T ODJHHINLGOI) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class GKEOHCEHNKL<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public readonly struct MKNMNDFHHKB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly GKEOHCEHNKL<T> GDNBAEOBEKI;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T OGADOHBOMGE
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x3924660", Offset = "0x3923860", VA = "0x183924660")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x41454C0", Offset = "0x41446C0", VA = "0x1841454C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x877820", Offset = "0x876A20", VA = "0x180877820")]
		internal MKNMNDFHHKB(GKEOHCEHNKL<T> PADHKJEBJGM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public readonly struct FNHBLMJHPKG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly GKEOHCEHNKL<T> GDNBAEOBEKI;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public T OGADOHBOMGE
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x3924660", Offset = "0x3923860", VA = "0x183924660")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x39245C0", Offset = "0x39237C0", VA = "0x1839245C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x877820", Offset = "0x876A20", VA = "0x180877820")]
		internal FNHBLMJHPKG(GKEOHCEHNKL<T> PADHKJEBJGM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct LGIGGHFINIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder<FNHBLMJHPKG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public GKEOHCEHNKL<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private OPKAAEGOEKP<PJGNGDCIDLA>.OADOEGGOONH <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<OPKAAEGOEKP<PJGNGDCIDLA>.OADOEGGOONH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x3F45150", Offset = "0x3F44350", VA = "0x183F45150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x3F44650", Offset = "0x3F43850", VA = "0x183F44650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly OPKAAEGOEKP<int> NCLNGNDOBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly OPKAAEGOEKP<PJGNGDCIDLA> PHOEFIONNAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly OPKAAEGOEKP<PJGNGDCIDLA> LNAODDOIOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private T KIDGCHNKMNB;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x39DA0A0", Offset = "0x39D92A0", VA = "0x1839DA0A0")]
	internal GKEOHCEHNKL(OPKAAEGOEKP<int> GDNMMMLACIK, OPKAAEGOEKP<PJGNGDCIDLA> DACNHCFFDFL, OPKAAEGOEKP<PJGNGDCIDLA> LFCLLELOMCK, [In] T ODJHHINLGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x39D9AC0", Offset = "0x39D8CC0", VA = "0x1839D9AC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x39D9900", Offset = "0x39D8B00", VA = "0x1839D9900")]
	public MKNMNDFHHKB CPFOEAHENHM()
	{
		return default(MKNMNDFHHKB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x39D9490", Offset = "0x39D8690", VA = "0x1839D9490")]
	public FNHBLMJHPKG CBGODNINDBA()
	{
		return default(FNHBLMJHPKG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x39D9C40", Offset = "0x39D8E40", VA = "0x1839D9C40")]
	[AsyncStateMachine(typeof(GKEOHCEHNKL<>.LGIGGHFINIG))]
	public Task<GKEOHCEHNKL<T>.FNHBLMJHPKG> ONHPMEHHHBM(CancellationToken GILHKFNDIJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class CDCJNMPCJHO
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x64B51A0", Offset = "0x64B43A0", VA = "0x1864B51A0")]
	public static GKEOHCEHNKL<PJGNGDCIDLA> EPPBEPCPNMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x27CC710", Offset = "0x27CB910", VA = "0x1827CC710")]
	public static GKEOHCEHNKL<T> EPPBEPCPNMI<T>([In] T ODJHHINLGOI) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class ODJJDIACMCL<TData> : GCNNAKAAMEK where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly string AALAONDECAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly TData GICDCDBMPKH;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "7")]
	public override string HDHLJKIJNJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4285CB0", Offset = "0x4284EB0", VA = "0x184285CB0")]
	internal ODJJDIACMCL(string PPGBBBOBJLN, [In] TData JLJKEBMIIPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class HPMMJICPHPP
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x64B7040", Offset = "0x64B6240", VA = "0x1864B7040")]
	public static ODJJDIACMCL<PJGNGDCIDLA> EPPBEPCPNMI(string PPGBBBOBJLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2773AD0", Offset = "0x2772CD0", VA = "0x182773AD0")]
	public static ODJJDIACMCL<TData> EPPBEPCPNMI<TData>(string PPGBBBOBJLN, [In] TData JLJKEBMIIPF) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class DPMMIJOJLJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly Dictionary<object, float> FAEHLNLHLOA;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float ABLKDKHHHPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x834740", Offset = "0x833940", VA = "0x180834740")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x9F5900", Offset = "0x9F4B00", VA = "0x1809F5900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x64B5C30", Offset = "0x64B4E30", VA = "0x1864B5C30")]
	public void BACMHJHBCMI(float HLCKBKFCMPI, object CEFPPEHCFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x64B5BC0", Offset = "0x64B4DC0", VA = "0x1864B5BC0")]
	public void ADCGPDBINPA(object CEFPPEHCFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x64B5CA0", Offset = "0x64B4EA0", VA = "0x1864B5CA0")]
	public void BFDHFEEMFPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x64B5CF0", Offset = "0x64B4EF0", VA = "0x1864B5CF0")]
	private void MEDPINIKKCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x64B5E20", Offset = "0x64B5020", VA = "0x1864B5E20")]
	public DPMMIJOJLJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class HGPOMHOJCPL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class AFBDAHPCBIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public AFBDAHPCBIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3BA9690", Offset = "0x3BA8890", VA = "0x183BA9690")]
		internal int BBOAMBEAKON(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private HashSet<T>? MABFHLIAJLP;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IReadOnlyCollection<T> PMKLOAHDLIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3A371D0", Offset = "0x3A363D0", VA = "0x183A371D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool MIAMDHAMFBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x3A37350", Offset = "0x3A36550", VA = "0x183A37350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int HJGLMCCDDEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7D01E0", Offset = "0x7CF3E0", VA = "0x1807D01E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7CFAB0", Offset = "0x7CECB0", VA = "0x1807CFAB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3A37200", Offset = "0x3A36400", VA = "0x183A37200")]
	public bool LGLNKEHGBKE(T CEFPPEHCFCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3A37080", Offset = "0x3A36280", VA = "0x183A37080")]
	public bool BIFLKBKPGJE(T CEFPPEHCFCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3A37190", Offset = "0x3A36390", VA = "0x183A37190")]
	public bool EJPMGDOHJOE(T CEFPPEHCFCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3A37380", Offset = "0x3A36580", VA = "0x183A37380", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public HGPOMHOJCPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class PEDLPOJJGDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly string FNBEKDKJMMD;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7D5B00", Offset = "0x7D4D00", VA = "0x1807D5B00")]
	public PEDLPOJJGDE(string FNBEKDKJMMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x64B7FC0", Offset = "0x64B71C0", VA = "0x1864B7FC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class IHDMHCMLFDH
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class MILFBCHGHKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public MILFBCHGHKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x64B77F0", Offset = "0x64B69F0", VA = "0x1864B77F0")]
		internal int BBOAMBEAKON(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private HashSet<object>? MABFHLIAJLP;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public IReadOnlyCollection<object> PMKLOAHDLIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x64B71C0", Offset = "0x64B63C0", VA = "0x1864B71C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool MIAMDHAMFBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x64B73A0", Offset = "0x64B65A0", VA = "0x1864B73A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int HJGLMCCDDEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7D01E0", Offset = "0x7CF3E0", VA = "0x1807D01E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7CFAB0", Offset = "0x7CECB0", VA = "0x1807CFAB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x64B72C0", Offset = "0x64B64C0", VA = "0x1864B72C0")]
	public bool LGLNKEHGBKE(object CEFPPEHCFCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x64B70C0", Offset = "0x64B62C0", VA = "0x1864B70C0")]
	public bool BIFLKBKPGJE(object CEFPPEHCFCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x64B7160", Offset = "0x64B6360", VA = "0x1864B7160")]
	public bool EJPMGDOHJOE(object CEFPPEHCFCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x64B7250", Offset = "0x64B6450", VA = "0x1864B7250")]
	public void KPCNKKDCFOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x64B73B0", Offset = "0x64B65B0", VA = "0x1864B73B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public IHDMHCMLFDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class GAPNAMDEEEN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private struct KACPJBNCJAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float KFMPOMBJHEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public T OGADOHBOMGE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly Dictionary<object, KACPJBNCJAL> FAEHLNLHLOA;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public virtual T JDEGGPKGOGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xFAC1B0", Offset = "0xFAB3B0", VA = "0x180FAC1B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xFAB790", Offset = "0xFAA990", VA = "0x180FAB790", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public object? HBNCDBOGPNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4E0", Offset = "0x7CA6E0", VA = "0x1807CB4E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7CB500", Offset = "0x7CA700", VA = "0x1807CB500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool PMJAJJKGNGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x39A57C0", Offset = "0x39A49C0", VA = "0x1839A57C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x39A54D0", Offset = "0x39A46D0", VA = "0x1839A54D0")]
	public bool BACMHJHBCMI(T HLCKBKFCMPI, object CEFPPEHCFCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x39A4F70", Offset = "0x39A4170", VA = "0x1839A4F70")]
	public bool ADCGPDBINPA(object CEFPPEHCFCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x39A5790", Offset = "0x39A4990", VA = "0x1839A5790")]
	public void BFDHFEEMFPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x39A5890", Offset = "0x39A4A90", VA = "0x1839A5890")]
	public bool GMADCLHMMHE(object CEFPPEHCFCF, [Out] T HLCKBKFCMPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x39A3A80", Offset = "0x39A2C80", VA = "0x1839A3A80")]
	[CNGJDMJIKCE("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool ACCAPBCDEAH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x39A5B70", Offset = "0x39A4D70", VA = "0x1839A5B70")]
	public GAPNAMDEEEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public sealed class ABMNNNDAPKN<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private List<WeakReference<T>>? MABFHLIAJLP;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool MIAMDHAMFBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x39A7310", Offset = "0x39A6510", VA = "0x1839A7310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int HJGLMCCDDEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x39A71D0", Offset = "0x39A63D0", VA = "0x1839A71D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x39A6FD0", Offset = "0x39A61D0", VA = "0x1839A6FD0")]
	public void LGLNKEHGBKE(T CEFPPEHCFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x39A6E70", Offset = "0x39A6070", VA = "0x1839A6E70")]
	public void BIFLKBKPGJE(T CEFPPEHCFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x39A6FB0", Offset = "0x39A61B0", VA = "0x1839A6FB0")]
	public void KPCNKKDCFOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x39A7400", Offset = "0x39A6600", VA = "0x1839A7400", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public ABMNNNDAPKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal static class DDFKKKKCEEB
{
	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x27FE180", Offset = "0x27FD380", VA = "0x1827FE180")]
	public static void CBINLHJFDIB<T>(this List<T> AIMBMINBCPM, int PMNHOLIPOMJ) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface HPKMOHKHMJG
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event CGIJGDBPMKL OACLCHEEDNJ;
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class FMBBEMHLNMD : HPKMOHKHMJG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public readonly struct MOCHGJNEKAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public readonly float HHGMBCMBJBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public readonly float MMPBNMANKLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		internal readonly bool DOILPLLJOOE;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float BGCPNAGJMOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x64B78E0", Offset = "0x64B6AE0", VA = "0x1864B78E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x64B7A60", Offset = "0x64B6C60", VA = "0x1864B7A60")]
		public MOCHGJNEKAJ(float IFNAKMJKBID, float AADBIEHCAOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x64B78F0", Offset = "0x64B6AF0", VA = "0x1864B78F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class COBCGMLDOHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public FMBBEMHLNMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public COBCGMLDOHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x64B5B20", Offset = "0x64B4D20", VA = "0x1864B5B20")]
		internal void OEICKHCDJNL(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly int EFDILNFHNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private int MEJCCGDFCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly HPKMOHKHMJG[] OLEOHLCBPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly CGIJGDBPMKL[] BJEABGEEHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly MOCHGJNEKAJ[] JDDFPDIFIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private MOCHGJNEKAJ GHAPJDNGNBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly MHDLFPJFAMP CHKMEDCFCBH;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event CGIJGDBPMKL OACLCHEEDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x64B6050", Offset = "0x64B5250", VA = "0x1864B6050", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x64B6590", Offset = "0x64B5790", VA = "0x1864B6590", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x64B6650", Offset = "0x64B5850", VA = "0x1864B6650")]
	public FMBBEMHLNMD(int EFDILNFHNJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x64B5FC0", Offset = "0x64B51C0", VA = "0x1864B5FC0")]
	public MHDLFPJFAMP ENIBOBKAOLD(MOCHGJNEKAJ KJOKLMFGMPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x64B6110", Offset = "0x64B5310", VA = "0x1864B6110")]
	public void HIECKBCCFEL(HPKMOHKHMJG PFCLPHPFHIJ, [Optional] MOCHGJNEKAJ HBOGILPIPHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x64B5EB0", Offset = "0x64B50B0", VA = "0x1864B5EB0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public delegate void CGIJGDBPMKL(float LEHGLKLICLJ);
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class BBAILHNPLLG
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class GMJJBGNFJGO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly HPKMOHKHMJG CFKJCBOOIPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly CGIJGDBPMKL GPGHCLCHGND;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x64B6FB0", Offset = "0x64B61B0", VA = "0x1864B6FB0")]
		public GMJJBGNFJGO(HPKMOHKHMJG CFKJCBOOIPO, CGIJGDBPMKL GPGHCLCHGND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x64B6F60", Offset = "0x64B6160", VA = "0x1864B6F60", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x64B5130", Offset = "0x64B4330", VA = "0x1864B5130")]
	internal static bool PGDAKHPCFLJ(float BPOHBPAMNLC, float NOIIDJMAOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x64A82C0", Offset = "0x64A74C0", VA = "0x1864A82C0")]
	internal static float EKJFILIKNKG(float BPOHBPAMNLC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x64B5070", Offset = "0x64B4270", VA = "0x1864B5070")]
	public static IDisposable GNMHFIAFDML(this HPKMOHKHMJG CFKJCBOOIPO, CGIJGDBPMKL GPGHCLCHGND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class MHDLFPJFAMP : HPKMOHKHMJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private float LEHGLKLICLJ;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public float KKFIEPFCJNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x64B75C0", Offset = "0x64B67C0", VA = "0x1864B75C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event CGIJGDBPMKL? OACLCHEEDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x64B76B0", Offset = "0x64B68B0", VA = "0x1864B76B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x64B7750", Offset = "0x64B6950", VA = "0x1864B7750", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public MHDLFPJFAMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class PLBILMCHABO : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5F64620", Offset = "0x5F63820", VA = "0x185F64620")]
	public PLBILMCHABO(string PPGBBBOBJLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[DefaultMember("Item")]
public class ADNHLIHNNHO<TKey, TValue> : EOPECJFDHAG<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, JFHIONBJOJC where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class IDHAADFJHFO : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public ADNHLIHNNHO<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xFAC1B0", Offset = "0xFAB3B0", VA = "0x180FAC1B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x3B067F0", Offset = "0x3B059F0", VA = "0x183B067F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7CD190", Offset = "0x7CC390", VA = "0x1807CD190")]
		[DebuggerHidden]
		public IDHAADFJHFO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x388AA00", Offset = "0x3889C00", VA = "0x18388AA00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x3B061A0", Offset = "0x3B053A0", VA = "0x183B061A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x3B05810", Offset = "0x3B04A10", VA = "0x183B05810")]
		private void BADJBHNLCNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x3B06660", Offset = "0x3B05860", VA = "0x183B06660")]
		private void NFKGCPGOKKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x3B067A0", Offset = "0x3B059A0", VA = "0x183B067A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly EOPECJFDHAG<TKey, TValue> MMIFOHPJCLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly IDictionary<TKey, TValue> PHDOAIFBIFB;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int HJGLMCCDDEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x3BA6AF0", Offset = "0x3BA5CF0", VA = "0x183BA6AF0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool PMLPHGCHDJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public TValue FOFBNHMHKAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x3BA6CB0", Offset = "0x3BA5EB0", VA = "0x183BA6CB0", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x3BA6F10", Offset = "0x3BA6110", VA = "0x183BA6F10", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public ICollection<TKey> IJNLGJPBLGF
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x3BA6CF0", Offset = "0x3BA5EF0", VA = "0x183BA6CF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public ICollection<TValue> CAEOEHJHBMA
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x3BA6DF0", Offset = "0x3BA5FF0", VA = "0x183BA6DF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3BA6970", Offset = "0x3BA5B70", VA = "0x183BA6970")]
	public ADNHLIHNNHO(EOPECJFDHAG<TKey, TValue> MMIFOHPJCLP, [Optional] IDictionary<TKey, TValue>? PHDOAIFBIFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3BA4820", Offset = "0x3BA3A20", VA = "0x183BA4820", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3BA5050", Offset = "0x3BA4250", VA = "0x183BA5050")]
	public void EDAIONDDHGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3BA4130", Offset = "0x3BA3330", VA = "0x183BA4130", Slot = "9")]
	public void Add(TKey MNOIAMGNLNL, TValue HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3BA4690", Offset = "0x3BA3890", VA = "0x183BA4690")]
	public void CIHKGDANKJL(TKey MNOIAMGNLNL, TValue HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3BA5170", Offset = "0x3BA4370", VA = "0x183BA5170")]
	public void FHJFMPKMNBI(TKey MNOIAMGNLNL, TValue HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3BA57F0", Offset = "0x3BA49F0", VA = "0x183BA57F0")]
	public void KNFPEBCBJHJ(TKey MNOIAMGNLNL, TValue HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3BA4520", Offset = "0x3BA3720", VA = "0x183BA4520")]
	public void BNMEJFKJOHJ(TKey MNOIAMGNLNL, TValue HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3BA5FE0", Offset = "0x3BA51E0", VA = "0x183BA5FE0", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> OIJOJELHKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3BA61B0", Offset = "0x3BA53B0", VA = "0x183BA61B0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> OIJOJELHKIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3BA6510", Offset = "0x3BA5710", VA = "0x183BA6510", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> OIJOJELHKIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x3BA4920", Offset = "0x3BA3B20", VA = "0x183BA4920", Slot = "8")]
	public bool ContainsKey(TKey MNOIAMGNLNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x3BA5CA0", Offset = "0x3BA4EA0", VA = "0x183BA5CA0")]
	public bool OBNJKALHPBJ(TKey MNOIAMGNLNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3BA3EE0", Offset = "0x3BA30E0", VA = "0x183BA3EE0")]
	public bool ALJNLHFMGBD(TKey MNOIAMGNLNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3BA5E20", Offset = "0x3BA5020", VA = "0x183BA5E20", Slot = "10")]
	public bool Remove(TKey MNOIAMGNLNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3BA6700", Offset = "0x3BA5900", VA = "0x183BA6700", Slot = "11")]
	public bool TryGetValue(TKey MNOIAMGNLNL, [Out] TValue HLCKBKFCMPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3BA49C0", Offset = "0x3BA3BC0", VA = "0x183BA49C0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] HPGKNFECNHG, int HFIJABHHPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3BA66D0", Offset = "0x3BA58D0", VA = "0x183BA66D0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3BA5300", Offset = "0x3BA4500", VA = "0x183BA5300", Slot = "19")]
	[IteratorStateMachine(typeof(ADNHLIHNNHO<, >.IDHAADFJHFO))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x3BA5B50", Offset = "0x3BA4D50", VA = "0x183BA5B50", Slot = "21")]
	public bool MPOGCIPBEDA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3BA55C0", Offset = "0x3BA47C0", VA = "0x183BA55C0")]
	private TValue KEDCIDNIAAB(TKey MNOIAMGNLNL)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface JFHIONBJOJC
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MPOGCIPBEDA();
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface EOPECJFDHAG<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, JFHIONBJOJC
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[DefaultMember("Item")]
public sealed class KFHOENHGDEO<TKey, TVal> : EOPECJFDHAG<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, JFHIONBJOJC where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public delegate int JIHPNGKDPHB(TKey MNOIAMGNLNL, TVal HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public delegate void HDEHAMHEILF(TKey MNOIAMGNLNL, TVal HLCKBKFCMPI, FMDLIMNANNN NCKBEFBPNFM);

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class EPGFFGCPBFB
	{
		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public TKey HCJOAPEDCHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x83B450", Offset = "0x83A650", VA = "0x18083B450")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public TVal OGADOHBOMGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x831BC0", Offset = "0x830DC0", VA = "0x180831BC0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x8316E0", Offset = "0x8308E0", VA = "0x1808316E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public int BGCPNAGJMOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x807FC0", Offset = "0x8071C0", VA = "0x180807FC0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x807560", Offset = "0x806760", VA = "0x180807560")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public DateTimeOffset GBGCHIAHDIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0xB7FD70", Offset = "0xB7EF70", VA = "0x180B7FD70")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x142BF10", Offset = "0x142B110", VA = "0x18142BF10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x35A6CA0", Offset = "0x35A5EA0", VA = "0x1835A6CA0")]
		public EPGFFGCPBFB(TKey MNOIAMGNLNL, TVal LGIDDHPGAND)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class ELJPEIABCOH : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public KFHOENHGDEO<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private LinkedList<EPGFFGCPBFB>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xFAC1B0", Offset = "0xFAB3B0", VA = "0x180FAC1B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x3596F30", Offset = "0x3596130", VA = "0x183596F30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7CD190", Offset = "0x7CC390", VA = "0x1807CD190")]
		[DebuggerHidden]
		public ELJPEIABCOH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3597090", Offset = "0x3596290", VA = "0x183597090", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3594E10", Offset = "0x3594010", VA = "0x183594E10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3594360", Offset = "0x3593560", VA = "0x183594360")]
		private void BADJBHNLCNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x3596E50", Offset = "0x3596050", VA = "0x183596E50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public const int DNNPJBOHHMP = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly Dictionary<TKey, LinkedListNode<EPGFFGCPBFB>> JDOAKAONFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly LinkedList<EPGFFGCPBFB> ACOJBAACPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly JIHPNGKDPHB? OPPKPBOFEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly TimeSpan JEMIGOODOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly HDEHAMHEILF? JCCEPAJGFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly MFOACBCAKEM IEPIIPPEFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private bool PBOBJNLPPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly List<TKey> KLAHKIANINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly List<TVal> OCDIKEAMOKB;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int BLFJFFIPIBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7D8620", Offset = "0x7D7820", VA = "0x1807D8620")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	internal int HPPEENFCIDI
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xA5E9E0", Offset = "0xA5DBE0", VA = "0x180A5E9E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xA5E700", Offset = "0xA5D900", VA = "0x180A5E700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int HJGLMCCDDEF
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x3E7BE80", Offset = "0x3E7B080", VA = "0x183E7BE80", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	internal int DMCEPDKLOJN
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x3E767F0", Offset = "0x3E759F0", VA = "0x183E767F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public ICollection<TVal> CAEOEHJHBMA
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x3E7BF90", Offset = "0x3E7B190", VA = "0x183E7BF90", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	ICollection<TKey> IDictionary<TKey, TVal>.ILBLCILAEKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x3E78830", Offset = "0x3E77A30", VA = "0x183E78830", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool PMLPHGCHDJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public TVal FOFBNHMHKAA
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x3E7BF00", Offset = "0x3E7B100", VA = "0x183E7BF00", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x3E7BFE0", Offset = "0x3E7B1E0", VA = "0x183E7BFE0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3E73410", Offset = "0x3E72610", VA = "0x183E73410")]
	private bool HBBNPKLNDFC(int EFDILNFHNJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3E6C440", Offset = "0x3E6B640", VA = "0x183E6C440")]
	private void BFGNOJNAJJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x3E7B9D0", Offset = "0x3E7ABD0", VA = "0x183E7B9D0")]
	public KFHOENHGDEO(int EFDILNFHNJD, [Optional] JIHPNGKDPHB? OPPKPBOFEPH, [Optional] IEqualityComparer<TKey>? MHCNJIJGGND, [Optional] HDEHAMHEILF? JCCEPAJGFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x3E79D60", Offset = "0x3E78F60", VA = "0x183E79D60")]
	public KFHOENHGDEO(TimeSpan JEMIGOODOFJ, [Optional] IEqualityComparer<TKey>? MHCNJIJGGND, [Optional] HDEHAMHEILF? JCCEPAJGFAA, [Optional] MFOACBCAKEM? IEPIIPPEFLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x3E79920", Offset = "0x3E78B20", VA = "0x183E79920")]
	public KFHOENHGDEO(int EFDILNFHNJD, TimeSpan JEMIGOODOFJ, [Optional] IEqualityComparer<TKey>? MHCNJIJGGND, [Optional] HDEHAMHEILF? JCCEPAJGFAA, [Optional] MFOACBCAKEM? IEPIIPPEFLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x3E7ABC0", Offset = "0x3E79DC0", VA = "0x183E7ABC0")]
	public KFHOENHGDEO(int EFDILNFHNJD, JIHPNGKDPHB? OPPKPBOFEPH, TimeSpan JEMIGOODOFJ, [Optional] IEqualityComparer<TKey>? MHCNJIJGGND, [Optional] HDEHAMHEILF? JCCEPAJGFAA, [Optional] MFOACBCAKEM? IEPIIPPEFLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x3E76D40", Offset = "0x3E75F40", VA = "0x183E76D40", Slot = "21")]
	public bool MPOGCIPBEDA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x3E76950", Offset = "0x3E75B50", VA = "0x183E76950", Slot = "22")]
	public bool LGBCKPBMMMJ(int AGHIAPEPFJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x3E6FF30", Offset = "0x3E6F130", VA = "0x183E6FF30")]
	private bool DJALDAICNFO(int AGHIAPEPFJE, FMDLIMNANNN NCKBEFBPNFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3E737D0", Offset = "0x3E729D0", VA = "0x183E737D0")]
	public void HNJFJKPNHAB(TKey MNOIAMGNLNL, TVal HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3E6AD80", Offset = "0x3E69F80", VA = "0x183E6AD80", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> OIJOJELHKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3E6A9E0", Offset = "0x3E69BE0", VA = "0x183E6A9E0", Slot = "9")]
	public void Add(TKey MNOIAMGNLNL, TVal HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3E6C9E0", Offset = "0x3E6BBE0", VA = "0x183E6C9E0", Slot = "8")]
	public bool ContainsKey(TKey MNOIAMGNLNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x3E78070", Offset = "0x3E77270", VA = "0x183E78070", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> OIJOJELHKIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x3E77A80", Offset = "0x3E76C80", VA = "0x183E77A80", Slot = "10")]
	public bool Remove(TKey MNOIAMGNLNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x3E783B0", Offset = "0x3E775B0", VA = "0x183E783B0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> OIJOJELHKIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x3E71D90", Offset = "0x3E70F90", VA = "0x183E71D90")]
	private bool EAIPGCNLGCJ(TKey MNOIAMGNLNL, [Out] TVal HLCKBKFCMPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x3E761A0", Offset = "0x3E753A0", VA = "0x183E761A0")]
	private TVal JIBGFLOLNJM(TKey AOIPADELMCO)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x3E78890", Offset = "0x3E77A90", VA = "0x183E78890", Slot = "11")]
	public bool TryGetValue(TKey AOIPADELMCO, [Out] TVal HLCKBKFCMPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x3E6C850", Offset = "0x3E6BA50", VA = "0x183E6C850", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3E6E100", Offset = "0x3E6D300", VA = "0x183E6E100", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] HPGKNFECNHG, int HFIJABHHPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x3E774A0", Offset = "0x3E766A0", VA = "0x183E774A0")]
	private void NGOBHDAEPCC(TKey MNOIAMGNLNL, TVal LGIDDHPGAND, FMDLIMNANNN NCKBEFBPNFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x3E69880", Offset = "0x3E68A80", VA = "0x183E69880")]
	private bool AFDNFIOGOOF(EPGFFGCPBFB EGBGNLOFPDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x3E746F0", Offset = "0x3E738F0", VA = "0x183E746F0")]
	private void JDKMBCANEDK(LinkedListNode<EPGFFGCPBFB> MNMGAEPMCII, TVal LMGOHOIPBAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x3E6B7B0", Offset = "0x3E6A9B0", VA = "0x183E6B7B0")]
	private void BACMHJHBCMI(TKey MNOIAMGNLNL, TVal HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3E72C60", Offset = "0x3E71E60", VA = "0x183E72C60")]
	private void EGMGDIEJLNK(EPGFFGCPBFB EGBGNLOFPDH, TVal LMGOHOIPBAN, int AEEIDPFNOMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x3E73260", Offset = "0x3E72460", VA = "0x183E73260", Slot = "19")]
	[IteratorStateMachine(typeof(KFHOENHGDEO<, >.ELJPEIABCOH))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x3E78860", Offset = "0x3E77A60", VA = "0x183E78860", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public enum FMDLIMNANNN : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	RemovedViaClear,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	Overwritten
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class MGPCFEPBJGO<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly TKey OMAOFPHEGKA;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x4134AF0", Offset = "0x4133CF0", VA = "0x184134AF0")]
	public MGPCFEPBJGO(TKey LLMMACLICJI, Exception CGMMHAPBHBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class GNFHJOKJIEO : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5857CE0", Offset = "0x5856EE0", VA = "0x185857CE0")]
	public GNFHJOKJIEO(string PPGBBBOBJLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class FLKLKKPPMNM<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class OKOLDIJKPOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public FLKLKKPPMNM<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public OKOLDIJKPOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x42A0C90", Offset = "0x429FE90", VA = "0x1842A0C90")]
		internal Task<TResource> PILFMOPAMCF(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private struct PFEHKCOPJKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public FLKLKKPPMNM<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x43AE1C0", Offset = "0x43AD3C0", VA = "0x1843AE1C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x43AE480", Offset = "0x43AD680", VA = "0x1843AE480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct OBAMKFBAGFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x4280780", Offset = "0x427F980", VA = "0x184280780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x42810B0", Offset = "0x42802B0", VA = "0x1842810B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly IIPFPINKIPO<TId, Task<TResource>> NAEHBEPPIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> CPDMJLONNDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? HCLCNAGMPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly Action<TResource>? JKDOKHIKNGB;

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x3922540", Offset = "0x3921740", VA = "0x183922540")]
	public FLKLKKPPMNM(int OFCOBKFBGFG = 0, [Optional] IEqualityComparer<TId>? LFBHKPIJJIE, [Optional] Func<TId, CancellationToken, Task<TResource>>? JBBLHEKFPHM, [Optional] Action<TResource>? NHMODNOKFME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x3921B10", Offset = "0x3920D10", VA = "0x183921B10")]
	public PHKGJMALLOJ<Task<TResource>> MNADKEBFJLE(TId IFAFPBGLEJO, [Optional] Func<TId, CancellationToken, Task<TResource>>? JBBLHEKFPHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x39215C0", Offset = "0x39207C0", VA = "0x1839215C0")]
	private void DKANOOPFGPL(Task<TResource> IKEBALIIPCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x39216C0", Offset = "0x39208C0", VA = "0x1839216C0")]
	[AsyncStateMachine(typeof(FLKLKKPPMNM<, >.PFEHKCOPJKH))]
	private Task ECCJCNPIMMD(Task<TResource> IKEBALIIPCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x3921390", Offset = "0x3920590", VA = "0x183921390")]
	public void CODDNOCCKJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x39219C0", Offset = "0x3920BC0", VA = "0x1839219C0")]
	public IIPFPINKIPO<TId, Task<TResource>>.DCKPIAJMFIM KBKKLBPIAFK()
	{
		return default(IIPFPINKIPO<TId, Task<TResource>>.DCKPIAJMFIM);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x3922410", Offset = "0x3921610", VA = "0x183922410", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x3922410", Offset = "0x3921610", VA = "0x183922410", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x3921FF0", Offset = "0x39211F0", VA = "0x183921FF0")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(FLKLKKPPMNM<, >.OBAMKFBAGFP))]
	internal static Task OAMBGFNCHGB(Task<TResource> IKEBALIIPCC, CancellationTokenSource JNMNDCDMBOB, Dictionary<Task<TResource>, CancellationTokenSource> KOHHLBLMADN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class IIPFPINKIPO<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private sealed class LNIHBMIODMK : IEquatable<LNIHBMIODMK>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public readonly TValue OGADOHBOMGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int EJFEBCIDLBB;

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x89CD90", Offset = "0x89BF90", VA = "0x18089CD90")]
		public LNIHBMIODMK(TValue HLCKBKFCMPI, int OHGAPKJPOKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3F6F370", Offset = "0x3F6E570", VA = "0x183F6F370", Slot = "4")]
		public bool Equals(LNIHBMIODMK? JPLJHFMPDFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3F6F3F0", Offset = "0x3F6E5F0", VA = "0x183F6F3F0", Slot = "0")]
		public override bool Equals(object? CDJAKLIPEBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3F6F580", Offset = "0x3F6E780", VA = "0x183F6F580", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public struct DCKPIAJMFIM : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private Dictionary<TKey, LNIHBMIODMK>.Enumerator IHELDFFOFNG;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x53205B0", Offset = "0x531F7B0", VA = "0x1853205B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public (TKey Key, TValue Value, int RefCount) NPODDCIDCOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x53209E0", Offset = "0x531FBE0", VA = "0x1853209E0", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x53207A0", Offset = "0x531F9A0", VA = "0x1853207A0")]
		public DCKPIAJMFIM(IIPFPINKIPO<TKey, TValue> FAEHLNLHLOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x53202B0", Offset = "0x531F4B0", VA = "0x1853202B0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x53202F0", Offset = "0x531F4F0", VA = "0x1853202F0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x53203B0", Offset = "0x531F5B0", VA = "0x1853203B0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class MBKNCMOGLDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public IIPFPINKIPO<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public LNIHBMIODMK refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public MBKNCMOGLDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x412C820", Offset = "0x412BA20", VA = "0x18412C820")]
		internal void PILFMOPAMCF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly Dictionary<TKey, LNIHBMIODMK> EFDNGBGFNFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly Func<TKey, TValue>? ODHHDGLFGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly Action<TValue>? LBKBKPDIGAK;

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x3B1A5F0", Offset = "0x3B197F0", VA = "0x183B1A5F0")]
	public IIPFPINKIPO(int OFCOBKFBGFG = 0, [Optional] IEqualityComparer<TKey>? MHCNJIJGGND, [Optional] Func<TKey, TValue>? FBLCBHBIFOJ, [Optional] Action<TValue>? OGOLLGJJLAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x3B19C20", Offset = "0x3B18E20", VA = "0x183B19C20")]
	public PHKGJMALLOJ<TValue> MNADKEBFJLE(TKey MNOIAMGNLNL, [Optional] Func<TKey, TValue>? CPLJONOEKLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x3B194F0", Offset = "0x3B186F0", VA = "0x183B194F0")]
	private void BNPNHCAJEDK(TKey MNOIAMGNLNL, LNIHBMIODMK JPGBFEOOCPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x3B195E0", Offset = "0x3B187E0", VA = "0x183B195E0")]
	public void CODDNOCCKJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x3B19B60", Offset = "0x3B18D60", VA = "0x183B19B60")]
	public DCKPIAJMFIM KBKKLBPIAFK()
	{
		return default(DCKPIAJMFIM);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x3B1A430", Offset = "0x3B19630", VA = "0x183B1A430", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x3B1A430", Offset = "0x3B19630", VA = "0x183B1A430", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
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
