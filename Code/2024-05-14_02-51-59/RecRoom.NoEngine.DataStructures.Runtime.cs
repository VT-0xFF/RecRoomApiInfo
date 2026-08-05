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
		[Cpp2IlInjected.Address(RVA = "0x7EC840", Offset = "0x7EB240", VA = "0x1807EC840")]
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
		[Cpp2IlInjected.Address(RVA = "0x63F65A0", Offset = "0x63F4FA0", VA = "0x1863F65A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7ED890", Offset = "0x7EC290", VA = "0x1807ED890")]
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
		[Cpp2IlInjected.Address(RVA = "0x7ED8D0", Offset = "0x7EC2D0", VA = "0x1807ED8D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class ONDCDODJLGA
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	protected ONDCDODJLGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class PJIOHKJIGAK<T> : ONDCDODJLGA
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct DNPAELBCKKN
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum MBKNFLEMKMF
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
		public MBKNFLEMKMF CGEOAHHPHHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T HKIJJKKNOIF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int FDIHALKJFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool ELAGBCKPEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool PJGEKLIBIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? GDLJFOCAMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<DNPAELBCKKN>? NDAKILFJECG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool NPKBFBOPEHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4303FD0", Offset = "0x43029D0", VA = "0x184303FD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4304500", Offset = "0x4302F00", VA = "0x184304500")]
	protected PJIOHKJIGAK(bool PJGEKLIBIAM, bool ELAGBCKPEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4303F30", Offset = "0x4302930", VA = "0x184303F30")]
	protected bool CHFMCPDLNOO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4303C80", Offset = "0x4302680", VA = "0x184303C80")]
	protected void AIJNIPJICMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4304020", Offset = "0x4302A20", VA = "0x184304020")]
	protected void JHBOBGLMIOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x28C8200", Offset = "0x28C6C00", VA = "0x1828C8200")]
	private static void FFGIGPBLIBG<U>(List<U>? GOJPHGMMOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4303D70", Offset = "0x4302770", VA = "0x184303D70", Slot = "4")]
	public void BIPEDCDHLGG(T HKIJJKKNOIF, bool ACBFMGNDPDB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4304360", Offset = "0x4302D60", VA = "0x184304360", Slot = "5")]
	public void MDELFCPLFEE(T HKIJJKKNOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x43041F0", Offset = "0x4302BF0", VA = "0x1843041F0")]
	public void LDCFGOINEDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NNMDDELDIPM
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BIPEDCDHLGG(Action HKIJJKKNOIF, bool ACBFMGNDPDB = false);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MDELFCPLFEE(Action HKIJJKKNOIF);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class KMHDPFOFGLH : PJIOHKJIGAK<Action>, NNMDDELDIPM
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x63F5AD0", Offset = "0x63F44D0", VA = "0x1863F5AD0")]
	public KMHDPFOFGLH(bool PJGEKLIBIAM = false, bool ELAGBCKPEPD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x63F5810", Offset = "0x63F4210", VA = "0x1863F5810")]
	public void BCLHLDBBMGO()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x63F5A70", Offset = "0x63F4470", VA = "0x1863F5A70")]
	public static KMHDPFOFGLH MOEMOFPBKII(KMHDPFOFGLH JCFGMDOEGDO, Action HKIJJKKNOIF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x63F5A10", Offset = "0x63F4410", VA = "0x1863F5A10")]
	public static KMHDPFOFGLH GGFPFNIEFLK(KMHDPFOFGLH JCFGMDOEGDO, Action HKIJJKKNOIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MDHLKNAOAIH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BIPEDCDHLGG(Action<T> HKIJJKKNOIF, bool ACBFMGNDPDB = false);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MDELFCPLFEE(Action<T> HKIJJKKNOIF);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class OIEIPJOEPJM<T> : PJIOHKJIGAK<Action<T>>, MDHLKNAOAIH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x34FB590", Offset = "0x34F9F90", VA = "0x1834FB590")]
	public OIEIPJOEPJM(bool PJGEKLIBIAM = false, bool ELAGBCKPEPD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4217270", Offset = "0x4215C70", VA = "0x184217270")]
	public void BCLHLDBBMGO(T BIKAIHEBIHG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x34FB500", Offset = "0x34F9F00", VA = "0x1834FB500")]
	public static OIEIPJOEPJM<T> MOEMOFPBKII(OIEIPJOEPJM<T> JCFGMDOEGDO, Action<T> HKIJJKKNOIF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x34FB470", Offset = "0x34F9E70", VA = "0x1834FB470")]
	public static OIEIPJOEPJM<T> GGFPFNIEFLK(OIEIPJOEPJM<T> JCFGMDOEGDO, Action<T> HKIJJKKNOIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OBIOPHHNGBI<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class EHCOJMJAODL<T, U> : PJIOHKJIGAK<Action<T, U>>, OBIOPHHNGBI<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x34FB590", Offset = "0x34F9F90", VA = "0x1834FB590")]
	public EHCOJMJAODL(bool PJGEKLIBIAM = false, bool ELAGBCKPEPD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x34F9050", Offset = "0x34F7A50", VA = "0x1834F9050")]
	public void BCLHLDBBMGO(T BIKAIHEBIHG, U KNNDGNLBAHG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x34FB500", Offset = "0x34F9F00", VA = "0x1834FB500")]
	public static EHCOJMJAODL<T, U> MOEMOFPBKII(EHCOJMJAODL<T, U> JCFGMDOEGDO, Action<T, U> HKIJJKKNOIF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x34FB470", Offset = "0x34F9E70", VA = "0x1834FB470")]
	public static EHCOJMJAODL<T, U> GGFPFNIEFLK(EHCOJMJAODL<T, U> JCFGMDOEGDO, Action<T, U> HKIJJKKNOIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class CNADDHFABOJ<T, U, V> : PJIOHKJIGAK<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x34FB590", Offset = "0x34F9F90", VA = "0x1834FB590")]
	public CNADDHFABOJ(bool PJGEKLIBIAM = false, bool ELAGBCKPEPD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4D71F20", Offset = "0x4D70920", VA = "0x184D71F20")]
	public void BCLHLDBBMGO(T BIKAIHEBIHG, U KNNDGNLBAHG, V DIAGEGELNFD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x34FB500", Offset = "0x34F9F00", VA = "0x1834FB500")]
	public static CNADDHFABOJ<T, U, V> MOEMOFPBKII(CNADDHFABOJ<T, U, V> JCFGMDOEGDO, Action<T, U, V> HKIJJKKNOIF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x34FB470", Offset = "0x34F9E70", VA = "0x1834FB470")]
	public static CNADDHFABOJ<T, U, V> GGFPFNIEFLK(CNADDHFABOJ<T, U, V> JCFGMDOEGDO, Action<T, U, V> HKIJJKKNOIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface NKALLEKLFNJ<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class ILJOICPECNG<T, U, V, W> : PJIOHKJIGAK<Action<T, U, V, W>>, NKALLEKLFNJ<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x34FB590", Offset = "0x34F9F90", VA = "0x1834FB590")]
	public ILJOICPECNG(bool PJGEKLIBIAM = false, bool ELAGBCKPEPD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3ACF040", Offset = "0x3ACDA40", VA = "0x183ACF040")]
	public void BCLHLDBBMGO(T BIKAIHEBIHG, U KNNDGNLBAHG, V DIAGEGELNFD, W PAMCHPJPPPN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x34FB500", Offset = "0x34F9F00", VA = "0x1834FB500")]
	public static ILJOICPECNG<T, U, V, W> MOEMOFPBKII(ILJOICPECNG<T, U, V, W> JCFGMDOEGDO, Action<T, U, V, W> HKIJJKKNOIF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x34FB470", Offset = "0x34F9E70", VA = "0x1834FB470")]
	public static ILJOICPECNG<T, U, V, W> GGFPFNIEFLK(ILJOICPECNG<T, U, V, W> JCFGMDOEGDO, Action<T, U, V, W> HKIJJKKNOIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class CMKBKHFPJLP<T, U, V, W, X> : PJIOHKJIGAK<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x34FB590", Offset = "0x34F9F90", VA = "0x1834FB590")]
	public CMKBKHFPJLP(bool PJGEKLIBIAM = false, bool ELAGBCKPEPD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4D6A7F0", Offset = "0x4D691F0", VA = "0x184D6A7F0")]
	public void BCLHLDBBMGO(T BIKAIHEBIHG, U KNNDGNLBAHG, V DIAGEGELNFD, W PAMCHPJPPPN, X HMCMBMJNNLE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x34FB500", Offset = "0x34F9F00", VA = "0x1834FB500")]
	public static CMKBKHFPJLP<T, U, V, W, X> MOEMOFPBKII(CMKBKHFPJLP<T, U, V, W, X> JCFGMDOEGDO, Action<T, U, V, W, X> HKIJJKKNOIF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x34FB470", Offset = "0x34F9E70", VA = "0x1834FB470")]
	public static CMKBKHFPJLP<T, U, V, W, X> GGFPFNIEFLK(CMKBKHFPJLP<T, U, V, W, X> JCFGMDOEGDO, Action<T, U, V, W, X> HKIJJKKNOIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class MJPOOKLEEJN<T, U, V, W, X, Y> : PJIOHKJIGAK<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x34FB590", Offset = "0x34F9F90", VA = "0x1834FB590")]
	public MJPOOKLEEJN(bool PJGEKLIBIAM = false, bool ELAGBCKPEPD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x40461B0", Offset = "0x4044BB0", VA = "0x1840461B0")]
	public void BCLHLDBBMGO(T BIKAIHEBIHG, U KNNDGNLBAHG, V DIAGEGELNFD, W PAMCHPJPPPN, X HMCMBMJNNLE, Y EGPNAKGBGLN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x34FB500", Offset = "0x34F9F00", VA = "0x1834FB500")]
	public static MJPOOKLEEJN<T, U, V, W, X, Y> MOEMOFPBKII(MJPOOKLEEJN<T, U, V, W, X, Y> JCFGMDOEGDO, Action<T, U, V, W, X, Y> HKIJJKKNOIF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x34FB470", Offset = "0x34F9E70", VA = "0x1834FB470")]
	public static MJPOOKLEEJN<T, U, V, W, X, Y> GGFPFNIEFLK(MJPOOKLEEJN<T, U, V, W, X, Y> JCFGMDOEGDO, Action<T, U, V, W, X, Y> HKIJJKKNOIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class EBDJOBELDOM<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly EHAFBHAOEDE<TKey, TVal> MNDIKBMINBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> KFANJHAANLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly EHAFBHAOEDE<TKey, TVal>.FEDPFBMNKNL? POIIFONNCDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int IFHILGCDOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly EHAFBHAOEDE<TKey, TVal>.IPOIAONAPMC? COPBDODJCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int PBDPGHBNDMI;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int LFIBOEONOAK
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x34D01C0", Offset = "0x34CEBC0", VA = "0x1834D01C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int KPMMKHLLGHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7C87B0", Offset = "0x7C71B0", VA = "0x1807C87B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x34D1130", Offset = "0x34CFB30", VA = "0x1834D1130")]
	public EBDJOBELDOM(int IFHILGCDOMI, [Optional] EHAFBHAOEDE<TKey, TVal>.IPOIAONAPMC? COPBDODJCLK, [Optional] IEqualityComparer<TKey>? HDKGDAFCIJA, [Optional] EHAFBHAOEDE<TKey, TVal>.FEDPFBMNKNL? POIIFONNCDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x34D0910", Offset = "0x34CF310", VA = "0x1834D0910")]
	public void LIJPLNAIDPL(TKey KLDFLAABJKH, TVal AEJBOLFACJC, bool PHPPOHLNKIP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x34D0620", Offset = "0x34CF020", VA = "0x1834D0620")]
	public bool GCELJFGIEPB(TKey KLDFLAABJKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x34D0BA0", Offset = "0x34CF5A0", VA = "0x1834D0BA0")]
	public bool PJCFHHABBNE(TKey GJCLDELGPMF, [Out] TVal AEJBOLFACJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x34D0200", Offset = "0x34CEC00", VA = "0x1834D0200")]
	private void BHJPCEKDDHL(TKey KLDFLAABJKH, TVal AEJBOLFACJC, int CBAOPDHODHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x34D0740", Offset = "0x34CF140", VA = "0x1834D0740")]
	public bool GJIGAMHEFJA(TKey KLDFLAABJKH, TVal AEJBOLFACJC, bool PHPPOHLNKIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x34D08B0", Offset = "0x34CF2B0", VA = "0x1834D08B0")]
	public void LDCFGOINEDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x34D0C70", Offset = "0x34CF670", VA = "0x1834D0C70")]
	private void PLJPPNHOAAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x34D0AC0", Offset = "0x34CF4C0", VA = "0x1834D0AC0")]
	private bool MHPHALJKFKN(TKey KLDFLAABJKH, CJOIABPGGIF FKOGKDPANPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x34D0550", Offset = "0x34CEF50", VA = "0x1834D0550")]
	private void EMDCJGEKMMC(TKey KLDFLAABJKH, TVal AEJBOLFACJC, CJOIABPGGIF FKOGKDPANPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x34D0430", Offset = "0x34CEE30", VA = "0x1834D0430")]
	private void DGDBCKGPKNC(TKey KLDFLAABJKH, TVal OONFDHNBOBC, CJOIABPGGIF FKOGKDPANPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class AGMJEMAJILF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action NMKPGNIIKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool HABEPEBFCFA;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F10", Offset = "0x7D0910", VA = "0x1807D1F10")]
	public AGMJEMAJILF(Action AFFLIEGDLON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x63F3980", Offset = "0x63F2380", VA = "0x1863F3980", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2716500", Offset = "0x2714F00", VA = "0x182716500")]
	public static AOKOEPMOBFO<T> HGOBECNKDLP<T>(T AEJBOLFACJC, Action AFFLIEGDLON) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class AOKOEPMOBFO<T> : AGMJEMAJILF where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T DPMGLPAKGNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7C5500", Offset = "0x7C3F00", VA = "0x1807C5500")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3A6D760", Offset = "0x3A6C160", VA = "0x183A6D760")]
	public AOKOEPMOBFO(T AEJBOLFACJC, Action AFFLIEGDLON)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct CNDCANKNEFB : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct HFEAAOGKOJO : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0")]
		public static HFEAAOGKOJO OLCPJHCMOKI()
		{
			return default(HFEAAOGKOJO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x27BDB70", Offset = "0x27BC570", VA = "0x1827BDB70")]
	public static string? MJAKPCBIPEF<T>([Optional] string? BJAEODGPBNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x27BDAF0", Offset = "0x27BC4F0", VA = "0x1827BDAF0")]
	public static string? MCCEFKABOMD<T>([Optional] string? DPIPJBLBHNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0")]
	public static CNDCANKNEFB LNFAGJAFBAP(string BJAEODGPBNJ, string? DPIPJBLBHNF)
	{
		return default(CNDCANKNEFB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct IBBHNDCDBDE
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool CAGPLKFBIOH(string DFFAKMFMKMG, IBBHNDCDBDE IEDEPDIEELK);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class AICMGEGMPAH<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public AICMGEGMPAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x39743D0", Offset = "0x3972DD0", VA = "0x1839743D0")]
		internal void KIABDNALKON(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public int OPIDCOCFJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public string PECKDIOAPJG;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x63F4EF0", Offset = "0x63F38F0", VA = "0x1863F4EF0")]
	public static Dictionary<string, IBBHNDCDBDE> HLHJBEIGGGP(Type HKMMIPEBLMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x297A4B0", Offset = "0x2978EB0", VA = "0x18297A4B0")]
	public static Dictionary<string, IBBHNDCDBDE> HLHJBEIGGGP<T>(Type HKMMIPEBLMA, IReadOnlyDictionary<T, string> KABFGPCNOGC) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x297ACE0", Offset = "0x29796E0", VA = "0x18297ACE0")]
	public static Dictionary<string, IBBHNDCDBDE> PPBENCKBPBI<T>(List<T> PBGMKNHNFCA) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x63F5220", Offset = "0x63F3C20", VA = "0x1863F5220")]
	public static Dictionary<string, IBBHNDCDBDE> IAIOPJMDOJP(Type HKMMIPEBLMA, CAGPLKFBIOH LCABNHJFKGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x63F4D30", Offset = "0x63F3730", VA = "0x1863F4D30")]
	public static Dictionary<int, string> GODPIHCKHOH(Dictionary<string, IBBHNDCDBDE> HIHHIJKIJFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class LJNADPDGEHJ : CEAFENKMCFB
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static bool INJAPAKIINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly string? KDBDEBMKMEL;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public virtual CEAFENKMCFB? JHBGHMFFKJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7C34C0", Offset = "0x7C1EC0", VA = "0x1807C34C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x63F61D0", Offset = "0x63F4BD0", VA = "0x1863F61D0")]
	protected LJNADPDGEHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string BLGDHPMKGMJ();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x63F5C30", Offset = "0x63F4630", VA = "0x1863F5C30", Slot = "8")]
	public virtual string HNNBJHEAOFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x63F5F30", Offset = "0x63F4930", VA = "0x1863F5F30", Slot = "9")]
	public void MCKKHMDIGIN(StringBuilder AGAFMIAFLNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x63F5BD0", Offset = "0x63F45D0", VA = "0x1863F5BD0", Slot = "10")]
	public void HMEOKNMPMMN(StringBuilder AGAFMIAFLNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x63F5CB0", Offset = "0x63F46B0", VA = "0x1863F5CB0", Slot = "11")]
	public void JMIBFMBMAAA(StringBuilder AGAFMIAFLNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x63F5DD0", Offset = "0x63F47D0", VA = "0x1863F5DD0", Slot = "12")]
	public void KLFACBONNFP(StringBuilder AGAFMIAFLNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x63F5B30", Offset = "0x63F4530", VA = "0x1863F5B30")]
	public static void BOGJCOPOJNG(StringBuilder AGAFMIAFLNA, string PBPBAJNJLNH, string EOHANIMIKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x561BF20", Offset = "0x561A920", VA = "0x18561BF20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FAMHDEAOCFI : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x63F4CD0", Offset = "0x63F36D0", VA = "0x1863F4CD0")]
	public FAMHDEAOCFI(string CPPFNMDMGHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class PIHLHKGIIGM<TErr> : FAMHDEAOCFI where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly TErr JGJJCJPCLPM;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4303720", Offset = "0x4302120", VA = "0x184303720")]
	private PIHLHKGIIGM([In] TErr PBDOCAAOIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4303660", Offset = "0x4302060", VA = "0x184303660")]
	public static PIHLHKGIIGM<TErr> OLCPJHCMOKI([In] TErr PBDOCAAOIJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface CEAFENKMCFB
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string HNNBJHEAOFJ();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string BLGDHPMKGMJ();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface BAGBKOIOIDF<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	TOptions DPMGLPAKGNP
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface MJLDIHHBMKD
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string EPMHHPHAIHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class IMENPPPGMIH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x63F55E0", Offset = "0x63F3FE0", VA = "0x1863F55E0")]
	public IMENPPPGMIH(string CPPFNMDMGHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class OEDEFAABBPJ<TOk> : IMENPPPGMIH where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly TOk HIBFDHHCAHE;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x42082C0", Offset = "0x4206CC0", VA = "0x1842082C0")]
	private OEDEFAABBPJ([In] TOk FECLDNADFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3D69B60", Offset = "0x3D68560", VA = "0x183D69B60")]
	public static OEDEFAABBPJ<TOk> OLCPJHCMOKI([In] TOk FECLDNADFED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct LGGHGMLBJFM<TOk, TErr> : IEquatable<LGGHGMLBJFM<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static readonly EqualityComparer<TErr> KMGIIIABFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal readonly TErr JGJJCJPCLPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal readonly TOk HIBFDHHCAHE;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool OENFLKOHDCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x3E38050", Offset = "0x3E36A50", VA = "0x183E38050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool OOIMKECDOJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x3E3B150", Offset = "0x3E39B50", VA = "0x183E3B150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3E3F8C0", Offset = "0x3E3E2C0", VA = "0x183E3F8C0")]
	internal LGGHGMLBJFM([In] TErr PBDOCAAOIJH, [In] TOk FECLDNADFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3E3AAA0", Offset = "0x3E394A0", VA = "0x183E3AAA0")]
	public static LGGHGMLBJFM<TOk, TErr> KHLDEFLKHCD([In] TErr PBDOCAAOIJH)
	{
		return default(LGGHGMLBJFM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3E3B720", Offset = "0x3E3A120", VA = "0x183E3B720")]
	public static LGGHGMLBJFM<TOk, TErr> PHJIMOLDHLO([In] TOk FECLDNADFED)
	{
		return default(LGGHGMLBJFM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x28951D0", Offset = "0x2893BD0", VA = "0x1828951D0")]
	public LGGHGMLBJFM<TOk?, UErr?> MIBCOEANCOO<UErr>()
	{
		return default(LGGHGMLBJFM<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2893E00", Offset = "0x2892800", VA = "0x182893E00")]
	public LGGHGMLBJFM<UOk?, TErr?> BFFENAGCAEG<UOk>()
	{
		return default(LGGHGMLBJFM<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x28949F0", Offset = "0x28933F0", VA = "0x1828949F0")]
	public LGGHGMLBJFM<UOk?, TErr?> JCODNKAAADG<UOk>()
	{
		return default(LGGHGMLBJFM<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x28937A0", Offset = "0x28921A0", VA = "0x1828937A0")]
	public LGGHGMLBJFM<TOk?, UErr?> ACCBFCBOPHP<UErr>()
	{
		return default(LGGHGMLBJFM<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3E39600", Offset = "0x3E38000", VA = "0x183E39600")]
	public LGGHGMLBJFM<PHKKIFFGKBG, TErr> GEMGOBLCGHD()
	{
		return default(LGGHGMLBJFM<PHKKIFFGKBG, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3E3CA00", Offset = "0x3E3B400", VA = "0x183E3CA00")]
	public static bool PIEEFOPMNNK([In] LGGHGMLBJFM<TOk, TErr> OLKIFIEFDII, [In] LGGHGMLBJFM<TOk, TErr> AEIEBLGGCGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3E38720", Offset = "0x3E37120", VA = "0x183E38720", Slot = "4")]
	public bool Equals(LGGHGMLBJFM<TOk, TErr> HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3E387E0", Offset = "0x3E371E0", VA = "0x183E387E0", Slot = "0")]
	public override bool Equals(object HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3E39F80", Offset = "0x3E38980", VA = "0x183E39F80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3E3D930", Offset = "0x3E3C330", VA = "0x183E3D930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class DCMIMIMEIHF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct GPMBGDGHALK<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public Task<LGGHGMLBJFM<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<LGGHGMLBJFM<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x39BAF80", Offset = "0x39B9980", VA = "0x1839BAF80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x39BB580", Offset = "0x39B9F80", VA = "0x1839BB580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x27E04A0", Offset = "0x27DEEA0", VA = "0x1827E04A0")]
	public static LGGHGMLBJFM<TOk?, TErr?> HIBFDHHCAHE<TOk, TErr>([In] this LGGHGMLBJFM<TOk, TErr> CMJEIEIDHIK, [In] TOk FECLDNADFED)
	{
		return default(LGGHGMLBJFM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x27E04E0", Offset = "0x27DEEE0", VA = "0x1827E04E0")]
	public static LGGHGMLBJFM<PHKKIFFGKBG, TErr?> HIBFDHHCAHE<TErr>([In] this LGGHGMLBJFM<PHKKIFFGKBG, TErr> CMJEIEIDHIK)
	{
		return default(LGGHGMLBJFM<PHKKIFFGKBG, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x27E04A0", Offset = "0x27DEEA0", VA = "0x1827E04A0")]
	public static LGGHGMLBJFM<TOk?, TErr?> JGJJCJPCLPM<TOk, TErr>([In] this LGGHGMLBJFM<TOk, TErr> CMJEIEIDHIK, [In] TErr PBDOCAAOIJH)
	{
		return default(LGGHGMLBJFM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x27E07B0", Offset = "0x27DF1B0", VA = "0x1827E07B0")]
	public static TOk? JFACIOOFFJH<TOk, TErr>([In] this LGGHGMLBJFM<TOk, TErr> CMJEIEIDHIK)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x27DFA90", Offset = "0x27DE490", VA = "0x1827DFA90")]
	[AsyncStateMachine(typeof(GPMBGDGHALK<, >))]
	public static Task<TOk?>? ANHAFGKGCAL<TOk, TErr>(this Task<LGGHGMLBJFM<TOk, TErr>> CMJEIEIDHIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x27E0D60", Offset = "0x27DF760", VA = "0x1827E0D60")]
	public static TErr? KIEBIAJCEGH<TErr, TOk>([In] this LGGHGMLBJFM<TOk, TErr> CMJEIEIDHIK)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x27E1A60", Offset = "0x27E0460", VA = "0x1827E1A60")]
	public static bool PGJFHPAMEIH<TOk, TErr, UErr, UOk>([In] this LGGHGMLBJFM<TOk, TErr> CMJEIEIDHIK, [Out] LGGHGMLBJFM<UOk, UErr> DNEGFHKIELB) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x27E1370", Offset = "0x27DFD70", VA = "0x1827E1370")]
	public static bool NEBJDNBKBEE<TOk, TErr>([In] this LGGHGMLBJFM<TOk, TErr> CMJEIEIDHIK, [Out][NotNullWhen(true)] TOk FECLDNADFED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x27E0670", Offset = "0x27DF070", VA = "0x1827E0670")]
	public static bool IPAGKINIGOP<TOk, TErr>([In] this LGGHGMLBJFM<TOk, TErr> CMJEIEIDHIK, [Out][NotNullWhen(true)] TErr PBDOCAAOIJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x27E1280", Offset = "0x27DFC80", VA = "0x1827E1280")]
	public static bool MDDPCOFEGEM<TOk, TErr>([In] this LGGHGMLBJFM<TOk, TErr> CMJEIEIDHIK, [Out][NotNullWhen(true)] TOk FECLDNADFED, [Out][NotNullWhen(false)] TErr PBDOCAAOIJH) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x27E1180", Offset = "0x27DFB80", VA = "0x1827E1180")]
	public static bool LHLDACAAKJB<TOk, TErr>([In] this LGGHGMLBJFM<TOk, TErr> CMJEIEIDHIK, [Out][NotNullWhen(true)] TOk FECLDNADFED, [Out] LGGHGMLBJFM<TOk, TErr> DNEGFHKIELB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x27E1940", Offset = "0x27E0340", VA = "0x1827E1940")]
	public static bool PGJFHPAMEIH<TOk, TErr, UErr, UOk>([In] this LGGHGMLBJFM<TOk, TErr> CMJEIEIDHIK, [Out][NotNullWhen(true)] TOk FECLDNADFED, [Out] LGGHGMLBJFM<UOk, UErr> DNEGFHKIELB) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x27E0140", Offset = "0x27DEB40", VA = "0x1827E0140")]
	public static bool GLMOJMMPNAO<TOk, TErr>([In] this LGGHGMLBJFM<TOk, TErr> CMJEIEIDHIK, [Out][NotNullWhen(true)] TOk FECLDNADFED, [Out] LGGHGMLBJFM<PHKKIFFGKBG, TErr> DNEGFHKIELB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x27E13E0", Offset = "0x27DFDE0", VA = "0x1827E13E0")]
	public static LGGHGMLBJFM<UOk, UErr> OELNHBGEPAM<UOk, UErr, TOk, TErr>([In] this LGGHGMLBJFM<TOk, TErr> CMJEIEIDHIK, [In] LGGHGMLBJFM<UOk, UErr> GCGDEDCNCCJ) where TOk : UOk where TErr : UErr
	{
		return default(LGGHGMLBJFM<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x27DFD30", Offset = "0x27DE730", VA = "0x1827DFD30")]
	public static LGGHGMLBJFM<TOk?[]?, TErr?> DNHEFPBFAGA<TOk, TErr>(this IEnumerable<LGGHGMLBJFM<TOk, TErr>> CMJEIEIDHIK)
	{
		return default(LGGHGMLBJFM<TOk[], TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class DCGFICHEDGH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x26F4AD0", Offset = "0x26F34D0", VA = "0x1826F4AD0")]
	public static LGGHGMLBJFM<TOk, T> HIBFDHHCAHE<TOk>([In] TOk FECLDNADFED) where TOk : notnull
	{
		return default(LGGHGMLBJFM<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5235E60", Offset = "0x5234860", VA = "0x185235E60")]
	public static LGGHGMLBJFM<PHKKIFFGKBG, T> HIBFDHHCAHE()
	{
		return default(LGGHGMLBJFM<PHKKIFFGKBG, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x26F49C0", Offset = "0x26F33C0", VA = "0x1826F49C0")]
	public static LGGHGMLBJFM<T, TErr> JGJJCJPCLPM<TErr>([In] TErr PBDOCAAOIJH) where TErr : notnull
	{
		return default(LGGHGMLBJFM<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public sealed class NOFGLKBOLDG<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private readonly struct EFHDAAPHIFF : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly NOFGLKBOLDG<T> IGFGDBIIGID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly int DANEKKFEHAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly bool KBDNAPGPIFI;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x1D79DD0", Offset = "0x1D787D0", VA = "0x181D79DD0")]
		public EFHDAAPHIFF(NOFGLKBOLDG<T> KGDPHHJJNLN, int ABAKHDFCBOB, bool JAMMCJOFNMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x34D8080", Offset = "0x34D6A80", VA = "0x1834D8080")]
		public NOFGLKBOLDG<T>.NLPOPNHJBOP HOEJGHKHDAP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x34D8160", Offset = "0x34D6B60", VA = "0x1834D8160", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x34D8160", Offset = "0x34D6B60", VA = "0x1834D8160", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class NLPOPNHJBOP : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly NOFGLKBOLDG<T> IGFGDBIIGID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly int KMJOPNFEHHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private int DNKJMNEGGBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly bool KBDNAPGPIFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private bool MLCCGNJLIJN;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T EIIOCLGDIGI
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x40E40E0", Offset = "0x40E2AE0", VA = "0x1840E40E0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x40E4230", Offset = "0x40E2C30", VA = "0x1840E4230", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x40E43C0", Offset = "0x40E2DC0", VA = "0x1840E43C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x40E4970", Offset = "0x40E3370", VA = "0x1840E4970")]
		public NLPOPNHJBOP(NOFGLKBOLDG<T> KGDPHHJJNLN, int ABAKHDFCBOB, bool JAMMCJOFNMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x40E4160", Offset = "0x40E2B60", VA = "0x1840E4160", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x40E41E0", Offset = "0x40E2BE0", VA = "0x1840E41E0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class NOJICEEOGHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public NOJICEEOGHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x40E8330", Offset = "0x40E6D30", VA = "0x1840E8330")]
		internal T HEGCCNDNBKB(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly T[] DCJDGFMDAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private int DNKJMNEGGBH;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int KJMPEEHHOMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x40E7A30", Offset = "0x40E6430", VA = "0x1840E7A30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public T EIIOCLGDIGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3866830", Offset = "0x3865230", VA = "0x183866830")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T CAFNOMJCOAB
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x40E7C60", Offset = "0x40E6660", VA = "0x1840E7C60")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T MIEEOIIACLC
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x40E7B80", Offset = "0x40E6580", VA = "0x1840E7B80")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int EEALFJDFGFI
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1769E50", Offset = "0x1768850", VA = "0x181769E50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x101A070", Offset = "0x1018A70", VA = "0x18101A070")]
	private static int JFGPHPKIMNL(int ABBNIPHGMGH, int JEKCEPEEELJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x40E7CC0", Offset = "0x40E66C0", VA = "0x1840E7CC0")]
	public NOFGLKBOLDG(int CBAOPDHODHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x40E7DD0", Offset = "0x40E67D0", VA = "0x1840E7DD0")]
	public NOFGLKBOLDG(int CBAOPDHODHO, Func<T> CGFFMMADIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x40E7F30", Offset = "0x40E6930", VA = "0x1840E7F30")]
	public NOFGLKBOLDG(T[] APNNJDENMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x40E7C90", Offset = "0x40E6690", VA = "0x1840E7C90")]
	public void MDGDHMIPHDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x40E7A70", Offset = "0x40E6470", VA = "0x1840E7A70")]
	public IEnumerable<T> HFEFKHMLLJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x40E7BE0", Offset = "0x40E65E0", VA = "0x1840E7BE0")]
	public NOFGLKBOLDG<T>.NLPOPNHJBOP HOEJGHKHDAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3915AB0", Offset = "0x39144B0", VA = "0x183915AB0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3915AB0", Offset = "0x39144B0", VA = "0x183915AB0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class CFEEJOOGNPJ
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x27965E0", Offset = "0x2794FE0", VA = "0x1827965E0")]
	public static NOFGLKBOLDG<T> OLCPJHCMOKI<T>(int CBAOPDHODHO, Func<T> CGFFMMADIJE) where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x1E68F10", Offset = "0x1E67910", VA = "0x181E68F10")]
		public RRColor(float IBKPCEPDIIC, float HKMBLFPJEIE, float AMHFHPBEBNM, float LMANHAAPNDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x63F6900", Offset = "0x63F5300", VA = "0x1863F6900", Slot = "4")]
		public bool Equals(RRColor HKMMPHJFKEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x63F6980", Offset = "0x63F5380", VA = "0x1863F6980", Slot = "0")]
		public override bool Equals(object HKMMPHJFKEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x63F6A80", Offset = "0x63F5480", VA = "0x1863F6A80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x63F6B00", Offset = "0x63F5500", VA = "0x1863F6B00", Slot = "5")]
		public string ToString(string OPPPAIJEHEA, IFormatProvider KILBAEFMBJJ)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class AAFMDLCCBMP<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public readonly struct FOKPIMMMEGF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly AAFMDLCCBMP<T> EPPPIKHNIFE;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public T DPMGLPAKGNP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x38D0990", Offset = "0x38CF390", VA = "0x1838D0990")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x38D09B0", Offset = "0x38CF3B0", VA = "0x1838D09B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x954A30", Offset = "0x953430", VA = "0x180954A30")]
		public FOKPIMMMEGF(AAFMDLCCBMP<T> EPPPIKHNIFE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct DAANIKCIABA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public AsyncTaskMethodBuilder<FOKPIMMMEGF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AAFMDLCCBMP<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5230210", Offset = "0x522EC10", VA = "0x185230210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x32CC1C0", Offset = "0x32CABC0", VA = "0x1832CC1C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly SemaphoreSlim NFFGNLONHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private T HPEKBGLNHGP;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x392ABD0", Offset = "0x39295D0", VA = "0x18392ABD0")]
	public AAFMDLCCBMP([In] T HPEKBGLNHGP, int FAJDJFBNNNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x392AB10", Offset = "0x3929510", VA = "0x18392AB10")]
	public AAFMDLCCBMP([In] T HPEKBGLNHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x392AA70", Offset = "0x3929470", VA = "0x18392AA70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x392AAB0", Offset = "0x39294B0", VA = "0x18392AAB0")]
	public FOKPIMMMEGF FLIPDBNHIAB()
	{
		return default(FOKPIMMMEGF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x392A740", Offset = "0x3929140", VA = "0x18392A740")]
	[AsyncStateMachine(typeof(AAFMDLCCBMP<>.DAANIKCIABA))]
	public Task<AAFMDLCCBMP<T>.FOKPIMMMEGF> BCLHEFAAHMI(CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x392AAF0", Offset = "0x39294F0", VA = "0x18392AAF0")]
	public void MMFKFLIIOIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class LKKNEBBFPOH
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x63F6240", Offset = "0x63F4C40", VA = "0x1863F6240")]
	public static AAFMDLCCBMP<PHKKIFFGKBG> OLCPJHCMOKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x271BA70", Offset = "0x271A470", VA = "0x18271BA70")]
	public static AAFMDLCCBMP<T> OLCPJHCMOKI<T>([In] T HPEKBGLNHGP) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class CEJMFBFJIAP<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public readonly struct EKLOENNDPNG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly CEJMFBFJIAP<T> MCDHAGIIBPF;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T DPMGLPAKGNP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x351A230", Offset = "0x3518C30", VA = "0x18351A230")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x351A250", Offset = "0x3518C50", VA = "0x18351A250", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x954A30", Offset = "0x953430", VA = "0x180954A30")]
		internal EKLOENNDPNG(CEJMFBFJIAP<T> EPPPIKHNIFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public readonly struct MCKACOKKCNH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly CEJMFBFJIAP<T> MCDHAGIIBPF;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public T DPMGLPAKGNP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x351A230", Offset = "0x3518C30", VA = "0x18351A230")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x400CA90", Offset = "0x400B490", VA = "0x18400CA90", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x954A30", Offset = "0x953430", VA = "0x180954A30")]
		internal MCKACOKKCNH(CEJMFBFJIAP<T> EPPPIKHNIFE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct NNHBCNDJCGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder<MCKACOKKCNH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CEJMFBFJIAP<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private AAFMDLCCBMP<PHKKIFFGKBG>.FOKPIMMMEGF <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<AAFMDLCCBMP<PHKKIFFGKBG>.FOKPIMMMEGF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x40E65B0", Offset = "0x40E4FB0", VA = "0x1840E65B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x32CC1C0", Offset = "0x32CABC0", VA = "0x1832CC1C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly AAFMDLCCBMP<int> FFDGPLCJOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly AAFMDLCCBMP<PHKKIFFGKBG> MGHCEDMFHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly AAFMDLCCBMP<PHKKIFFGKBG> KJOLLPFJABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private T MKGLPNGDBGE;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4AB02D0", Offset = "0x4AAECD0", VA = "0x184AB02D0")]
	internal CEJMFBFJIAP(AAFMDLCCBMP<int> LCMCOCGBGLG, AAFMDLCCBMP<PHKKIFFGKBG> BOILFCNGPMH, AAFMDLCCBMP<PHKKIFFGKBG> PJNDDGAFGBB, [In] T HPEKBGLNHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4AAFEF0", Offset = "0x4AAE8F0", VA = "0x184AAFEF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4AAF7A0", Offset = "0x4AAE1A0", VA = "0x184AAF7A0")]
	public EKLOENNDPNG CJAINMNDGDP()
	{
		return default(EKLOENNDPNG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4AAFB20", Offset = "0x4AAE520", VA = "0x184AAFB20")]
	public MCKACOKKCNH DOCDFFDNEMK()
	{
		return default(MCKACOKKCNH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4AB0090", Offset = "0x4AAEA90", VA = "0x184AB0090")]
	[AsyncStateMachine(typeof(CEJMFBFJIAP<>.NNHBCNDJCGK))]
	public Task<CEJMFBFJIAP<T>.MCKACOKKCNH> KHLMHGOOMOC(CancellationToken CFAFANOFDNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class ENIDKOECBDB
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x63F4C00", Offset = "0x63F3600", VA = "0x1863F4C00")]
	public static CEJMFBFJIAP<PHKKIFFGKBG> OLCPJHCMOKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x280E610", Offset = "0x280D010", VA = "0x18280E610")]
	public static CEJMFBFJIAP<T> OLCPJHCMOKI<T>([In] T HPEKBGLNHGP) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class LAPMGLFGCHI<TData> : LJNADPDGEHJ where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly string IFJJAPFHAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly TData PICICNMEMLG;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320", Slot = "7")]
	public override string BLGDHPMKGMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3E1EDC0", Offset = "0x3E1D7C0", VA = "0x183E1EDC0")]
	internal LAPMGLFGCHI(string CPPFNMDMGHI, [In] TData ABDLEBPKDKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class BNHOPAIAFJB
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x63F42E0", Offset = "0x63F2CE0", VA = "0x1863F42E0")]
	public static LAPMGLFGCHI<PHKKIFFGKBG> OLCPJHCMOKI(string CPPFNMDMGHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2716500", Offset = "0x2714F00", VA = "0x182716500")]
	public static LAPMGLFGCHI<TData> OLCPJHCMOKI<TData>(string CPPFNMDMGHI, [In] TData ABDLEBPKDKC) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class NCBPNILFIHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly Dictionary<object, float> CGFGKINIJBO;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float HBJAKMMIOPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x956600", Offset = "0x955000", VA = "0x180956600")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x9566A0", Offset = "0x9550A0", VA = "0x1809566A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x63F64A0", Offset = "0x63F4EA0", VA = "0x1863F64A0")]
	public void NPBIGPPLMMP(float AEJBOLFACJC, object AIDIDMJCFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x63F62B0", Offset = "0x63F4CB0", VA = "0x1863F62B0")]
	public void FKIPJHLLKAC(object AIDIDMJCFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x63F6320", Offset = "0x63F4D20", VA = "0x1863F6320")]
	public void LDCFGOINEDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x63F6370", Offset = "0x63F4D70", VA = "0x1863F6370")]
	private void NCCEMPOEMLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x63F6510", Offset = "0x63F4F10", VA = "0x1863F6510")]
	public NCBPNILFIHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class DCFDBFGMELH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class ECDGEKMNPLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public ECDGEKMNPLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x34D3170", Offset = "0x34D1B70", VA = "0x1834D3170")]
		internal int AGNMLBMJMKO(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private HashSet<T>? FJMAMJBMHPP;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IReadOnlyCollection<T> ONDGFACBCHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x5235A00", Offset = "0x5234400", VA = "0x185235A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool CBGFDMFBEAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x52359D0", Offset = "0x52343D0", VA = "0x1852359D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int IAGPAHCAHED
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7CBFB0", Offset = "0x7CA9B0", VA = "0x1807CBFB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7CC6F0", Offset = "0x7CB0F0", VA = "0x1807CC6F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5235880", Offset = "0x5234280", VA = "0x185235880")]
	public bool BIPEDCDHLGG(T AIDIDMJCFEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5235A30", Offset = "0x5234430", VA = "0x185235A30")]
	public bool MDELFCPLFEE(T AIDIDMJCFEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5235B40", Offset = "0x5234540", VA = "0x185235B40")]
	public bool OBHCHEDFPHH(T AIDIDMJCFEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5235B80", Offset = "0x5234580", VA = "0x185235B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public DCFDBFGMELH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class JIIANIOJCIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly string DEMDAOILJLL;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F10", Offset = "0x7D0910", VA = "0x1807D1F10")]
	public JIIANIOJCIN(string DEMDAOILJLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x63F56E0", Offset = "0x63F40E0", VA = "0x1863F56E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class DMNFIAAEHEB
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class PDKGAOOHKNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public PDKGAOOHKNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x63F6620", Offset = "0x63F5020", VA = "0x1863F6620")]
		internal int AGNMLBMJMKO(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private HashSet<object>? FJMAMJBMHPP;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public IReadOnlyCollection<object> ONDGFACBCHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x63F4720", Offset = "0x63F3120", VA = "0x1863F4720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool CBGFDMFBEAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x63F4710", Offset = "0x63F3110", VA = "0x1863F4710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int IAGPAHCAHED
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7CBFB0", Offset = "0x7CA9B0", VA = "0x1807CBFB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7CC6F0", Offset = "0x7CB0F0", VA = "0x1807CC6F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x63F4630", Offset = "0x63F3030", VA = "0x1863F4630")]
	public bool BIPEDCDHLGG(object AIDIDMJCFEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x63F47B0", Offset = "0x63F31B0", VA = "0x1863F47B0")]
	public bool MDELFCPLFEE(object AIDIDMJCFEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x63F48C0", Offset = "0x63F32C0", VA = "0x1863F48C0")]
	public bool OBHCHEDFPHH(object AIDIDMJCFEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x63F4850", Offset = "0x63F3250", VA = "0x1863F4850")]
	public void MDKHPNOAFED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x63F4920", Offset = "0x63F3320", VA = "0x1863F4920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public DMNFIAAEHEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class NIOLBLBOOKO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private struct BPODNGEGEAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float KJBNJJNAOKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public T DPMGLPAKGNP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly Dictionary<object, BPODNGEGEAB> CGFGKINIJBO;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public virtual T GDHKGJENDBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xF40480", Offset = "0xF3EE80", VA = "0x180F40480", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xF3FA50", Offset = "0xF3E450", VA = "0x180F3FA50", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public object? BBDHMIFJMFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7C8FA0", Offset = "0x7C79A0", VA = "0x1807C8FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool CHJPLJCBCNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x40DD9F0", Offset = "0x40DC3F0", VA = "0x1840DD9F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x40DDA60", Offset = "0x40DC460", VA = "0x1840DDA60")]
	public bool NPBIGPPLMMP(T AEJBOLFACJC, object AIDIDMJCFEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3C80750", Offset = "0x3C7F150", VA = "0x183C80750")]
	public bool FKIPJHLLKAC(object AIDIDMJCFEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x40DDA30", Offset = "0x40DC430", VA = "0x1840DDA30")]
	public void LDCFGOINEDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x40DE3F0", Offset = "0x40DCDF0", VA = "0x1840DE3F0")]
	public bool PJCFHHABBNE(object AIDIDMJCFEK, [Out] T AEJBOLFACJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x40DD690", Offset = "0x40DC090", VA = "0x1840DD690")]
	[CHAHDHKEFIF("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool ABJAEAGLMBL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x40DE570", Offset = "0x40DCF70", VA = "0x1840DE570")]
	public NIOLBLBOOKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public sealed class INLOPHAAHID<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private List<WeakReference<T>>? FJMAMJBMHPP;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool CBGFDMFBEAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x3AD5560", Offset = "0x3AD3F60", VA = "0x183AD5560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int IAGPAHCAHED
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3AD5650", Offset = "0x3AD4050", VA = "0x183AD5650")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3AD5360", Offset = "0x3AD3D60", VA = "0x183AD5360")]
	public void BIPEDCDHLGG(T AIDIDMJCFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3AD5790", Offset = "0x3AD4190", VA = "0x183AD5790")]
	public void MDELFCPLFEE(T AIDIDMJCFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x3AD58D0", Offset = "0x3AD42D0", VA = "0x183AD58D0")]
	public void MDKHPNOAFED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3AD58F0", Offset = "0x3AD42F0", VA = "0x183AD58F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public INLOPHAAHID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal static class AMDLEACMOED
{
	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x29633C0", Offset = "0x2961DC0", VA = "0x1829633C0")]
	public static void PAOAEMMMFIL<T>(this List<T> GOJPHGMMOOM, int ABBNIPHGMGH) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface ODHBDMIJJEC
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event BPFENBAHPOO HJBHKMOKJJG;
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class BHPFCKOAEJC : ODHBDMIJJEC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public readonly struct DCAPMAJIKPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public readonly float HBIPAHEJJPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public readonly float IPCDMOCNHML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		internal readonly bool PCOPBBJPOGB;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float LIKCBNMIJLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x63F4360", Offset = "0x63F2D60", VA = "0x1863F4360")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x63F44D0", Offset = "0x63F2ED0", VA = "0x1863F44D0")]
		public DCAPMAJIKPJ(float HDAPKPHIPPD, float CIJJIBBMFDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x63F4370", Offset = "0x63F2D70", VA = "0x1863F4370", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class JDKBJNJILKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public BHPFCKOAEJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public JDKBJNJILKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x63F5640", Offset = "0x63F4040", VA = "0x1863F5640")]
		internal void NMCMOJHBJAK(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly int JDNEKMCCAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private int JJDHAHPKGJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly ODHBDMIJJEC[] OGDKEHDJDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly BPFENBAHPOO[] NJALJHMFPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly DCAPMAJIKPJ[] LPOGAGJENNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private DCAPMAJIKPJ HFEFJBINJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly PMHGABOONOO MCDBDAFHBEF;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event BPFENBAHPOO HJBHKMOKJJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x63F3EC0", Offset = "0x63F28C0", VA = "0x1863F3EC0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x63F4090", Offset = "0x63F2A90", VA = "0x1863F4090", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x63F4150", Offset = "0x63F2B50", VA = "0x1863F4150")]
	public BHPFCKOAEJC(int JDNEKMCCAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x63F3E30", Offset = "0x63F2830", VA = "0x1863F3E30")]
	public PMHGABOONOO DKLMAFCPKFE(DCAPMAJIKPJ MEFNELDKKKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x63F39C0", Offset = "0x63F23C0", VA = "0x1863F39C0")]
	public void AAJLEEIDLAE(ODHBDMIJJEC MLBNMGMAMAI, [Optional] DCAPMAJIKPJ PECHINBHLNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x63F3F80", Offset = "0x63F2980", VA = "0x1863F3F80", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public delegate void BPFENBAHPOO(float BICDHPDCJLI);
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class DPOBKANPIEI
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class JKJLAPFBBIJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly ODHBDMIJJEC LDIMKFAMHHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly BPFENBAHPOO JNDJHGKPENH;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x63F5780", Offset = "0x63F4180", VA = "0x1863F5780")]
		public JKJLAPFBBIJ(ODHBDMIJJEC LDIMKFAMHHL, BPFENBAHPOO JNDJHGKPENH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x63F5730", Offset = "0x63F4130", VA = "0x1863F5730", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x63F4B90", Offset = "0x63F3590", VA = "0x1863F4B90")]
	internal static bool GLEEBJMGFOP(float LMANHAAPNDE, float AMHFHPBEBNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x63E7970", Offset = "0x63E6370", VA = "0x1863E7970")]
	internal static float JAEADBGAAIC(float LMANHAAPNDE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x63F4AD0", Offset = "0x63F34D0", VA = "0x1863F4AD0")]
	public static IDisposable AJFCOIJMIJM(this ODHBDMIJJEC LDIMKFAMHHL, BPFENBAHPOO JNDJHGKPENH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class PMHGABOONOO : ODHBDMIJJEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private float BICDHPDCJLI;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public float DIFMKKIMNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x63F6810", Offset = "0x63F5210", VA = "0x1863F6810")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event BPFENBAHPOO? HJBHKMOKJJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x63F66D0", Offset = "0x63F50D0", VA = "0x1863F66D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x63F6770", Offset = "0x63F5170", VA = "0x1863F6770", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public PMHGABOONOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class FOGKCIHCFFJ : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5E9BD20", Offset = "0x5E9A720", VA = "0x185E9BD20")]
	public FOGKCIHCFFJ(string CPPFNMDMGHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[DefaultMember("Item")]
public class EPFJGHEHBAM<TKey, TValue> : EBBLGGFEDKA<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, CJCBIPCCCAK where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class CJCEGPKEPIN : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public EPFJGHEHBAM<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xF40480", Offset = "0xF3EE80", VA = "0x180F40480", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4B9A800", Offset = "0x4B99200", VA = "0x184B9A800", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7C2410", Offset = "0x7C0E10", VA = "0x1807C2410")]
		[DebuggerHidden]
		public CJCEGPKEPIN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x38354F0", Offset = "0x3833EF0", VA = "0x1838354F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x4B99FA0", Offset = "0x4B989A0", VA = "0x184B99FA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x4B99B10", Offset = "0x4B98510", VA = "0x184B99B10")]
		private void AOIIEBMEGKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x4B99A70", Offset = "0x4B98470", VA = "0x184B99A70")]
		private void AFFHFGLBOCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x4B9A760", Offset = "0x4B99160", VA = "0x184B9A760", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly EBBLGGFEDKA<TKey, TValue> DEPGOBEFMPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly IDictionary<TKey, TValue> ELDACDBFDIC;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int IAGPAHCAHED
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x352E190", Offset = "0x352CB90", VA = "0x18352E190", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool FIKMFADPAMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public TValue MIEEOIIACLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x352E280", Offset = "0x352CC80", VA = "0x18352E280", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x352E4C0", Offset = "0x352CEC0", VA = "0x18352E4C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public ICollection<TKey> HCMLLGDIBEE
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x352E2C0", Offset = "0x352CCC0", VA = "0x18352E2C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public ICollection<TValue> PMCNHJDBEMD
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x352E3C0", Offset = "0x352CDC0", VA = "0x18352E3C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x352DF40", Offset = "0x352C940", VA = "0x18352DF40")]
	public EPFJGHEHBAM(EBBLGGFEDKA<TKey, TValue> DEPGOBEFMPP, [Optional] IDictionary<TKey, TValue>? ELDACDBFDIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x352BBB0", Offset = "0x352A5B0", VA = "0x18352BBB0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x352D1C0", Offset = "0x352BBC0", VA = "0x18352D1C0")]
	public void NPNKIONANEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x352B4B0", Offset = "0x3529EB0", VA = "0x18352B4B0", Slot = "9")]
	public void Add(TKey KLDFLAABJKH, TValue AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x352BA20", Offset = "0x352A420", VA = "0x18352BA20")]
	public void BCKHFMINKNH(TKey KLDFLAABJKH, TValue AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x352CE40", Offset = "0x352B840", VA = "0x18352CE40")]
	public void JEJNEMGBLGG(TKey KLDFLAABJKH, TValue AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x352C650", Offset = "0x352B050", VA = "0x18352C650")]
	public void EDJGODNHHEL(TKey KLDFLAABJKH, TValue AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x352CCB0", Offset = "0x352B6B0", VA = "0x18352CCB0")]
	public void HBMPIONENAP(TKey KLDFLAABJKH, TValue AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x352D590", Offset = "0x352BF90", VA = "0x18352D590", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> ODDGLLCBILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x352D780", Offset = "0x352C180", VA = "0x18352D780", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> ODDGLLCBILG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x352DAE0", Offset = "0x352C4E0", VA = "0x18352DAE0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> ODDGLLCBILG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x352BCB0", Offset = "0x352A6B0", VA = "0x18352BCB0", Slot = "8")]
	public bool ContainsKey(TKey KLDFLAABJKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x352D0A0", Offset = "0x352BAA0", VA = "0x18352D0A0")]
	public bool LHPJHEGOOJG(TKey KLDFLAABJKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x352D270", Offset = "0x352BC70", VA = "0x18352D270")]
	public bool PBLDJADCHBB(TKey KLDFLAABJKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x352D330", Offset = "0x352BD30", VA = "0x18352D330", Slot = "10")]
	public bool Remove(TKey KLDFLAABJKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x352DDA0", Offset = "0x352C7A0", VA = "0x18352DDA0", Slot = "11")]
	public bool TryGetValue(TKey KLDFLAABJKH, [Out] TValue AEJBOLFACJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x352BF80", Offset = "0x352A980", VA = "0x18352BF80", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] KKAKPOKBAHF, int CJLMKFIOCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x352DCA0", Offset = "0x352C6A0", VA = "0x18352DCA0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x352CB10", Offset = "0x352B510", VA = "0x18352CB10", Slot = "19")]
	[IteratorStateMachine(typeof(EPFJGHEHBAM<, >.CJCEGPKEPIN))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x352CDA0", Offset = "0x352B7A0", VA = "0x18352CDA0", Slot = "21")]
	public bool IFCLGPJPNPL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x352C940", Offset = "0x352B340", VA = "0x18352C940")]
	private TValue EDNNFCNNGCG(TKey KLDFLAABJKH)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface CJCBIPCCCAK
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IFCLGPJPNPL();
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface EBBLGGFEDKA<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, CJCBIPCCCAK
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[DefaultMember("Item")]
public sealed class EHAFBHAOEDE<TKey, TVal> : EBBLGGFEDKA<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, CJCBIPCCCAK where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public delegate int IPOIAONAPMC(TKey KLDFLAABJKH, TVal AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public delegate void FEDPFBMNKNL(TKey KLDFLAABJKH, TVal AEJBOLFACJC, CJOIABPGGIF FKOGKDPANPE);

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class AFGPHJJOJPL
	{
		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public TKey ILKHIKNJEKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x85BFA0", Offset = "0x85A9A0", VA = "0x18085BFA0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public TVal DPMGLPAKGNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x83FF90", Offset = "0x83E990", VA = "0x18083FF90")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x840040", Offset = "0x83EA40", VA = "0x180840040")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public int LIKCBNMIJLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x802330", Offset = "0x800D30", VA = "0x180802330")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x801E10", Offset = "0x800810", VA = "0x180801E10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public DateTimeOffset PGNJONIAIGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0xB01A00", Offset = "0xB00400", VA = "0x180B01A00")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x139F8A0", Offset = "0x139E2A0", VA = "0x18139F8A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x39727C0", Offset = "0x39711C0", VA = "0x1839727C0")]
		public AFGPHJJOJPL(TKey KLDFLAABJKH, TVal OONFDHNBOBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class HLADJMIEGMO : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public EHAFBHAOEDE<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private LinkedList<AFGPHJJOJPL>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xF40480", Offset = "0xF3EE80", VA = "0x180F40480", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3838740", Offset = "0x3837140", VA = "0x183838740", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7C2410", Offset = "0x7C0E10", VA = "0x1807C2410")]
		[DebuggerHidden]
		public HLADJMIEGMO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x38305C0", Offset = "0x382EFC0", VA = "0x1838305C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3A074B0", Offset = "0x3A05EB0", VA = "0x183A074B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3A05C60", Offset = "0x3A04660", VA = "0x183A05C60")]
		private void AOIIEBMEGKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x3A08520", Offset = "0x3A06F20", VA = "0x183A08520", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public const int PNPGBCCKEAC = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly Dictionary<TKey, LinkedListNode<AFGPHJJOJPL>> DMEBABNMIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly LinkedList<AFGPHJJOJPL> GDEKEGOMFEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly IPOIAONAPMC? COPBDODJCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly TimeSpan HMIBCFEHCEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly FEDPFBMNKNL? POIIFONNCDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly HMJDNPNFJLC LMJBBFMKMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private bool KDDIGAHGEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly List<TKey> NENCBMOLPND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly List<TVal> ANCFKIGLKJJ;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int KPMMKHLLGHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7D24E0", Offset = "0x7D0EE0", VA = "0x1807D24E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	internal int LFIBOEONOAK
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x9E2400", Offset = "0x9E0E00", VA = "0x1809E2400")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x9E2050", Offset = "0x9E0A50", VA = "0x1809E2050")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int IAGPAHCAHED
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x34E14B0", Offset = "0x34DFEB0", VA = "0x1834E14B0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	internal int IGHAILNAPOD
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x34D8A00", Offset = "0x34D7400", VA = "0x1834D8A00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public ICollection<TVal> PMCNHJDBEMD
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x34E1590", Offset = "0x34DFF90", VA = "0x1834E1590", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	ICollection<TKey> IDictionary<TKey, TVal>.BACFKBNFENH
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x34DFC10", Offset = "0x34DE610", VA = "0x1834DFC10", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool FIKMFADPAMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public TVal MIEEOIIACLC
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x34E1500", Offset = "0x34DFF00", VA = "0x1834E1500", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x34E1600", Offset = "0x34E0000", VA = "0x1834E1600", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x34D8A40", Offset = "0x34D7440", VA = "0x1834D8A40")]
	private bool AGFLGCKCIJF(int JDNEKMCCAKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x34DD770", Offset = "0x34DC170", VA = "0x1834DD770")]
	private void NLHDLBPEDJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x34E06A0", Offset = "0x34DF0A0", VA = "0x1834E06A0")]
	public EHAFBHAOEDE(int JDNEKMCCAKP, [Optional] IPOIAONAPMC? COPBDODJCLK, [Optional] IEqualityComparer<TKey>? HDKGDAFCIJA, [Optional] FEDPFBMNKNL? POIIFONNCDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x34E0260", Offset = "0x34DEC60", VA = "0x1834E0260")]
	public EHAFBHAOEDE(TimeSpan HMIBCFEHCEA, [Optional] IEqualityComparer<TKey>? HDKGDAFCIJA, [Optional] FEDPFBMNKNL? POIIFONNCDJ, [Optional] HMJDNPNFJLC? LMJBBFMKMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x34E0150", Offset = "0x34DEB50", VA = "0x1834E0150")]
	public EHAFBHAOEDE(int JDNEKMCCAKP, TimeSpan HMIBCFEHCEA, [Optional] IEqualityComparer<TKey>? HDKGDAFCIJA, [Optional] FEDPFBMNKNL? POIIFONNCDJ, [Optional] HMJDNPNFJLC? LMJBBFMKMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x34E0CD0", Offset = "0x34DF6D0", VA = "0x1834E0CD0")]
	public EHAFBHAOEDE(int JDNEKMCCAKP, IPOIAONAPMC? COPBDODJCLK, TimeSpan HMIBCFEHCEA, [Optional] IEqualityComparer<TKey>? HDKGDAFCIJA, [Optional] FEDPFBMNKNL? POIIFONNCDJ, [Optional] HMJDNPNFJLC? LMJBBFMKMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x34DD710", Offset = "0x34DC110", VA = "0x1834DD710", Slot = "21")]
	public bool IFCLGPJPNPL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x34DF330", Offset = "0x34DDD30", VA = "0x1834DF330", Slot = "22")]
	public bool PKADCLBJEAA(int CBAOPDHODHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x34DB9A0", Offset = "0x34DA3A0", VA = "0x1834DB9A0")]
	private bool DGFEJMJMMCF(int CBAOPDHODHO, CJOIABPGGIF FKOGKDPANPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x34DE7B0", Offset = "0x34DD1B0", VA = "0x1834DE7B0")]
	public void NPHNBOIFMNI(TKey KLDFLAABJKH, TVal AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x34D9010", Offset = "0x34D7A10", VA = "0x1834D9010", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> ODDGLLCBILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x34D8ED0", Offset = "0x34D78D0", VA = "0x1834D8ED0", Slot = "9")]
	public void Add(TKey KLDFLAABJKH, TVal AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x34DA1D0", Offset = "0x34D8BD0", VA = "0x1834DA1D0", Slot = "8")]
	public bool ContainsKey(TKey KLDFLAABJKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x34DF820", Offset = "0x34DE220", VA = "0x1834DF820", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> ODDGLLCBILG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x34DF690", Offset = "0x34DE090", VA = "0x1834DF690", Slot = "10")]
	public bool Remove(TKey KLDFLAABJKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x34DFAE0", Offset = "0x34DE4E0", VA = "0x1834DFAE0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> ODDGLLCBILG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x34DF0A0", Offset = "0x34DDAA0", VA = "0x1834DF0A0")]
	private bool PHKEEJDCBEG(TKey KLDFLAABJKH, [Out] TVal AEJBOLFACJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x34DEA90", Offset = "0x34DD490", VA = "0x1834DEA90")]
	private TVal OIFPBAJNOAG(TKey GJCLDELGPMF)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x34DFC70", Offset = "0x34DE670", VA = "0x1834DFC70", Slot = "11")]
	public bool TryGetValue(TKey GJCLDELGPMF, [Out] TVal AEJBOLFACJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x34DA130", Offset = "0x34D8B30", VA = "0x1834DA130", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x34DA2D0", Offset = "0x34D8CD0", VA = "0x1834DA2D0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] KKAKPOKBAHF, int CJLMKFIOCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x34DB240", Offset = "0x34D9C40", VA = "0x1834DB240")]
	private void DGDBCKGPKNC(TKey KLDFLAABJKH, TVal OONFDHNBOBC, CJOIABPGGIF FKOGKDPANPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x34DCA60", Offset = "0x34DB460", VA = "0x1834DCA60")]
	private bool EDOBAKJEHCL(AFGPHJJOJPL PFMPGDJINIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x34D9D00", Offset = "0x34D8700", VA = "0x1834D9D00")]
	private void BNMGAKAMBGN(LinkedListNode<AFGPHJJOJPL> AEJBJKKJMBC, TVal BCHBCOAIMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x34DDB80", Offset = "0x34DC580", VA = "0x1834DDB80")]
	private void NPBIGPPLMMP(TKey KLDFLAABJKH, TVal AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x34DD080", Offset = "0x34DBA80", VA = "0x1834DD080")]
	private void EGPBLFIOJKM(AFGPHJJOJPL PFMPGDJINIC, TVal BCHBCOAIMKJ, int KMDOMBAILCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x34DD5F0", Offset = "0x34DBFF0", VA = "0x1834DD5F0", Slot = "19")]
	[IteratorStateMachine(typeof(EHAFBHAOEDE<, >.HLADJMIEGMO))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x34DFC40", Offset = "0x34DE640", VA = "0x1834DFC40", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public enum CJOIABPGGIF : byte
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
public class KNAPCMBMPNK<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly TKey PGPFKKGGJPK;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3D73BB0", Offset = "0x3D725B0", VA = "0x183D73BB0")]
	public KNAPCMBMPNK(TKey BGJPBBCIFAG, Exception BGHIPOHPBJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class GHPLMBHMKIP : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x579E540", Offset = "0x579CF40", VA = "0x18579E540")]
	public GHPLMBHMKIP(string CPPFNMDMGHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class GCFAHLODPKP<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class ENOAOELBFPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public GCFAHLODPKP<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public ENOAOELBFPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x35227D0", Offset = "0x35211D0", VA = "0x1835227D0")]
		internal Task<TResource> KFCKLCLIPMO(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private struct HJNHJOOLCJG : IAsyncStateMachine
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
		public GCFAHLODPKP<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x39F9B80", Offset = "0x39F8580", VA = "0x1839F9B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x39F9E40", Offset = "0x39F8840", VA = "0x1839F9E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct BIEDNEIKIJG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x494E6C0", Offset = "0x494D0C0", VA = "0x18494E6C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x494EA30", Offset = "0x494D430", VA = "0x18494EA30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly PHFDGKLGJKL<TId, Task<TResource>> PCBKPNGHAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> PBPHLCGEAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? NDANMBDMHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly Action<TResource>? GONJPGMNJOH;

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x39578D0", Offset = "0x39562D0", VA = "0x1839578D0")]
	public GCFAHLODPKP(int HDHELNINKNH = 0, [Optional] IEqualityComparer<TId>? MDKHELGDKMN, [Optional] Func<TId, CancellationToken, Task<TResource>>? KDNKILEFAKB, [Optional] Action<TResource>? HIIOMBJIOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x3956F90", Offset = "0x3955990", VA = "0x183956F90")]
	public AOKOEPMOBFO<Task<TResource>> FOMGECBHHAB(TId MCGNHGLIJDN, [Optional] Func<TId, CancellationToken, Task<TResource>>? KDNKILEFAKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x3956820", Offset = "0x3955220", VA = "0x183956820")]
	private void CEHCKDJCNPF(Task<TResource> KPCFMNKKKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x3957510", Offset = "0x3955F10", VA = "0x183957510")]
	[AsyncStateMachine(typeof(GCFAHLODPKP<, >.HJNHJOOLCJG))]
	private Task OBNJANJMKAC(Task<TResource> KPCFMNKKKMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x3956DB0", Offset = "0x39557B0", VA = "0x183956DB0")]
	public void FHPGFADLKOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x39572C0", Offset = "0x3955CC0", VA = "0x1839572C0")]
	public PHFDGKLGJKL<TId, Task<TResource>>.KBCOGLJNFAC HOEJGHKHDAP()
	{
		return default(PHFDGKLGJKL<TId, Task<TResource>>.KBCOGLJNFAC);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x3957710", Offset = "0x3956110", VA = "0x183957710", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x3957710", Offset = "0x3956110", VA = "0x183957710", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x3956A20", Offset = "0x3955420", VA = "0x183956A20")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(GCFAHLODPKP<, >.BIEDNEIKIJG))]
	internal static Task EGMGMMMBLMO(Task<TResource> KPCFMNKKKMJ, CancellationTokenSource MBLOEIBBGBC, Dictionary<Task<TResource>, CancellationTokenSource> LALMHNEGPFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class PHFDGKLGJKL<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private sealed class EMDJEGBEIOP : IEquatable<EMDJEGBEIOP>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public readonly TValue DPMGLPAKGNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int OHPPHEPBKOM;

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x840450", Offset = "0x83EE50", VA = "0x180840450")]
		public EMDJEGBEIOP(TValue AEJBOLFACJC, int GFGCHLPCPFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x351C260", Offset = "0x351AC60", VA = "0x18351C260", Slot = "4")]
		public bool Equals(EMDJEGBEIOP? HKMMPHJFKEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x351C1D0", Offset = "0x351ABD0", VA = "0x18351C1D0", Slot = "0")]
		public override bool Equals(object? COMOOAEHALC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x351C360", Offset = "0x351AD60", VA = "0x18351C360", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public struct KBCOGLJNFAC : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private Dictionary<TKey, EMDJEGBEIOP>.Enumerator CFHBDKOHMOM;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x3D506E0", Offset = "0x3D4F0E0", VA = "0x183D506E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public (TKey Key, TValue Value, int RefCount) EIIOCLGDIGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x3D50C80", Offset = "0x3D4F680", VA = "0x183D50C80", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3D50830", Offset = "0x3D4F230", VA = "0x183D50830")]
		public KBCOGLJNFAC(PHFDGKLGJKL<TKey, TValue> CGFGKINIJBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3D50340", Offset = "0x3D4ED40", VA = "0x183D50340", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3D503C0", Offset = "0x3D4EDC0", VA = "0x183D503C0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3D504F0", Offset = "0x3D4EEF0", VA = "0x183D504F0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class BBJJPJHFLCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public PHFDGKLGJKL<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public EMDJEGBEIOP refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public BBJJPJHFLCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x4927DD0", Offset = "0x49267D0", VA = "0x184927DD0")]
		internal void KFCKLCLIPMO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly Dictionary<TKey, EMDJEGBEIOP> BCJMPIIIIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly Func<TKey, TValue>? NGFEHMCJNGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly Action<TValue>? FANBNOAJDMM;

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x42FFFE0", Offset = "0x42FE9E0", VA = "0x1842FFFE0")]
	public PHFDGKLGJKL(int HDHELNINKNH = 0, [Optional] IEqualityComparer<TKey>? HDKGDAFCIJA, [Optional] Func<TKey, TValue>? OOFELEJAOML, [Optional] Action<TValue>? IIHKNIDHCCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x42FFAB0", Offset = "0x42FE4B0", VA = "0x1842FFAB0")]
	public AOKOEPMOBFO<TValue> FOMGECBHHAB(TKey KLDFLAABJKH, [Optional] Func<TKey, TValue>? ANLFOFFFAAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x42FEEE0", Offset = "0x42FD8E0", VA = "0x1842FEEE0")]
	private void DMFHFELNIKK(TKey KLDFLAABJKH, EMDJEGBEIOP DJGIKGGIJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x42FEFD0", Offset = "0x42FD9D0", VA = "0x1842FEFD0")]
	public void FHPGFADLKOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x42FFDA0", Offset = "0x42FE7A0", VA = "0x1842FFDA0")]
	public KBCOGLJNFAC HOEJGHKHDAP()
	{
		return default(KBCOGLJNFAC);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x42FFEB0", Offset = "0x42FE8B0", VA = "0x1842FFEB0", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x42FFEB0", Offset = "0x42FE8B0", VA = "0x1842FFEB0", Slot = "5")]
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
