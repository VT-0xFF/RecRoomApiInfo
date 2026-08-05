using System;
using System.Buffers;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
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
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8418BE0", Offset = "0x8417FE0", VA = "0x188418BE0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA99B00", Offset = "0xA98F00", VA = "0x180A99B00")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA99B40", Offset = "0xA98F40", VA = "0x180A99B40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class JBBKHNFLJHG
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	protected JBBKHNFLJHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class MAOAIEOPIBE<T> : JBBKHNFLJHG
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct OFHOEJEPAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum IIDJMKOJIPG
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
		public IIDJMKOJIPG IIHAKBEOLJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T ENDEKEOKCCM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int MCGFOMKMHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool INLLEAODJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool LDNGCBOILLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? HHIBPJEHLJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<OFHOEJEPAJJ>? CHDAMEINMMC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool DEFKKFAKPOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5768350", Offset = "0x5767750", VA = "0x185768350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5768C00", Offset = "0x5768000", VA = "0x185768C00")]
	protected MAOAIEOPIBE(bool LDNGCBOILLO, bool INLLEAODJCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5768550", Offset = "0x5767950", VA = "0x185768550")]
	protected bool EAAMGOMNLAI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5768930", Offset = "0x5767D30", VA = "0x185768930")]
	protected void LGAAFBJMPAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5768A30", Offset = "0x5767E30", VA = "0x185768A30")]
	protected void PCPFIDDHKCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x445FEF0", Offset = "0x445F2F0", VA = "0x18445FEF0")]
	private static void DHFFEAFIFBM<U>(List<U>? KIGLENMLJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5768760", Offset = "0x5767B60", VA = "0x185768760", Slot = "4")]
	public void KOBMLIBBKBO(T ENDEKEOKCCM, bool NNFMACFDFMF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x57683A0", Offset = "0x57677A0", VA = "0x1857683A0", Slot = "5")]
	public void CBDHBFLGDII(T ENDEKEOKCCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x57685F0", Offset = "0x57679F0", VA = "0x1857685F0")]
	public void HBLMHKLDBPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class OFFOKCJIMNI : MAOAIEOPIBE<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8418F20", Offset = "0x8418320", VA = "0x188418F20")]
	public OFFOKCJIMNI(bool LDNGCBOILLO = false, bool INLLEAODJCH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8418C60", Offset = "0x8418060", VA = "0x188418C60")]
	public void COEOEEINBLF()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8418E60", Offset = "0x8418260", VA = "0x188418E60")]
	public static OFFOKCJIMNI DKJNPDJFKMG(OFFOKCJIMNI GCCHCKHHCDJ, Action ENDEKEOKCCM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8418EC0", Offset = "0x84182C0", VA = "0x188418EC0")]
	public static OFFOKCJIMNI HBHCMLPJPFF(OFFOKCJIMNI GCCHCKHHCDJ, Action ENDEKEOKCCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface FHLENBLCEPD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KOBMLIBBKBO(Action<T> ENDEKEOKCCM, bool NNFMACFDFMF = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CBDHBFLGDII(Action<T> ENDEKEOKCCM);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class BBKKNBJGBDM<T> : MAOAIEOPIBE<Action<T>>, FHLENBLCEPD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1B60", Offset = "0x4EA0F60", VA = "0x184EA1B60")]
	public BBKKNBJGBDM(bool LDNGCBOILLO = false, bool INLLEAODJCH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x645E900", Offset = "0x645DD00", VA = "0x18645E900")]
	public void COEOEEINBLF(T DBAMLJDDEJL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1A40", Offset = "0x4EA0E40", VA = "0x184EA1A40")]
	public static BBKKNBJGBDM<T> DKJNPDJFKMG(BBKKNBJGBDM<T> GCCHCKHHCDJ, Action<T> ENDEKEOKCCM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1AD0", Offset = "0x4EA0ED0", VA = "0x184EA1AD0")]
	public static BBKKNBJGBDM<T> HBHCMLPJPFF(BBKKNBJGBDM<T> GCCHCKHHCDJ, Action<T> ENDEKEOKCCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface EMEEAHLMPFN<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KOBMLIBBKBO(Action<T, U> ENDEKEOKCCM, bool NNFMACFDFMF = false);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CBDHBFLGDII(Action<T, U> ENDEKEOKCCM);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class NIFKGGOBKPN<T, U> : MAOAIEOPIBE<Action<T, U>>, EMEEAHLMPFN<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1B60", Offset = "0x4EA0F60", VA = "0x184EA1B60")]
	public NIFKGGOBKPN(bool LDNGCBOILLO = false, bool INLLEAODJCH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x58070C0", Offset = "0x58064C0", VA = "0x1858070C0")]
	public void COEOEEINBLF(T DBAMLJDDEJL, U BPMHPMIGOAA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1A40", Offset = "0x4EA0E40", VA = "0x184EA1A40")]
	public static NIFKGGOBKPN<T, U> DKJNPDJFKMG(NIFKGGOBKPN<T, U> GCCHCKHHCDJ, Action<T, U> ENDEKEOKCCM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1AD0", Offset = "0x4EA0ED0", VA = "0x184EA1AD0")]
	public static NIFKGGOBKPN<T, U> HBHCMLPJPFF(NIFKGGOBKPN<T, U> GCCHCKHHCDJ, Action<T, U> ENDEKEOKCCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class FKJIGLNDBNB<T, U, V> : MAOAIEOPIBE<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1B60", Offset = "0x4EA0F60", VA = "0x184EA1B60")]
	public FKJIGLNDBNB(bool LDNGCBOILLO = false, bool INLLEAODJCH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4EA16F0", Offset = "0x4EA0AF0", VA = "0x184EA16F0")]
	public void COEOEEINBLF(T DBAMLJDDEJL, U BPMHPMIGOAA, V EMOJJIEJAKM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1A40", Offset = "0x4EA0E40", VA = "0x184EA1A40")]
	public static FKJIGLNDBNB<T, U, V> DKJNPDJFKMG(FKJIGLNDBNB<T, U, V> GCCHCKHHCDJ, Action<T, U, V> ENDEKEOKCCM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1AD0", Offset = "0x4EA0ED0", VA = "0x184EA1AD0")]
	public static FKJIGLNDBNB<T, U, V> HBHCMLPJPFF(FKJIGLNDBNB<T, U, V> GCCHCKHHCDJ, Action<T, U, V> ENDEKEOKCCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface GMJGMJHIKJD<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class NGPHLBNNMMF<T, U, V, W> : MAOAIEOPIBE<Action<T, U, V, W>>, GMJGMJHIKJD<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1B60", Offset = "0x4EA0F60", VA = "0x184EA1B60")]
	public NGPHLBNNMMF(bool LDNGCBOILLO = false, bool INLLEAODJCH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x57F80E0", Offset = "0x57F74E0", VA = "0x1857F80E0")]
	public void COEOEEINBLF(T DBAMLJDDEJL, U BPMHPMIGOAA, V EMOJJIEJAKM, W DJODONHGGOL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1A40", Offset = "0x4EA0E40", VA = "0x184EA1A40")]
	public static NGPHLBNNMMF<T, U, V, W> DKJNPDJFKMG(NGPHLBNNMMF<T, U, V, W> GCCHCKHHCDJ, Action<T, U, V, W> ENDEKEOKCCM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1AD0", Offset = "0x4EA0ED0", VA = "0x184EA1AD0")]
	public static NGPHLBNNMMF<T, U, V, W> HBHCMLPJPFF(NGPHLBNNMMF<T, U, V, W> GCCHCKHHCDJ, Action<T, U, V, W> ENDEKEOKCCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class ADGLLBHKIDE<T, U, V, W, X> : MAOAIEOPIBE<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1B60", Offset = "0x4EA0F60", VA = "0x184EA1B60")]
	public ADGLLBHKIDE(bool LDNGCBOILLO = false, bool INLLEAODJCH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x51055A0", Offset = "0x51049A0", VA = "0x1851055A0")]
	public void COEOEEINBLF(T DBAMLJDDEJL, U BPMHPMIGOAA, V EMOJJIEJAKM, W DJODONHGGOL, X FNBJHADJBNG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1A40", Offset = "0x4EA0E40", VA = "0x184EA1A40")]
	public static ADGLLBHKIDE<T, U, V, W, X> DKJNPDJFKMG(ADGLLBHKIDE<T, U, V, W, X> GCCHCKHHCDJ, Action<T, U, V, W, X> ENDEKEOKCCM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1AD0", Offset = "0x4EA0ED0", VA = "0x184EA1AD0")]
	public static ADGLLBHKIDE<T, U, V, W, X> HBHCMLPJPFF(ADGLLBHKIDE<T, U, V, W, X> GCCHCKHHCDJ, Action<T, U, V, W, X> ENDEKEOKCCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class AEOLCOFHBCG<T, U, V, W, X, Y> : MAOAIEOPIBE<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1B60", Offset = "0x4EA0F60", VA = "0x184EA1B60")]
	public AEOLCOFHBCG(bool LDNGCBOILLO = false, bool INLLEAODJCH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5108B00", Offset = "0x5107F00", VA = "0x185108B00")]
	public void COEOEEINBLF(T DBAMLJDDEJL, U BPMHPMIGOAA, V EMOJJIEJAKM, W DJODONHGGOL, X FNBJHADJBNG, Y MODFPFNICHM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1A40", Offset = "0x4EA0E40", VA = "0x184EA1A40")]
	public static AEOLCOFHBCG<T, U, V, W, X, Y> DKJNPDJFKMG(AEOLCOFHBCG<T, U, V, W, X, Y> GCCHCKHHCDJ, Action<T, U, V, W, X, Y> ENDEKEOKCCM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1AD0", Offset = "0x4EA0ED0", VA = "0x184EA1AD0")]
	public static AEOLCOFHBCG<T, U, V, W, X, Y> HBHCMLPJPFF(AEOLCOFHBCG<T, U, V, W, X, Y> GCCHCKHHCDJ, Action<T, U, V, W, X, Y> ENDEKEOKCCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class IBDJECOCJFF<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly OGIIDNDKACI<TKey, TVal> MFNBKPLGMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> EJHOECFIIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly OGIIDNDKACI<TKey, TVal>.EGPEAHFPKDM? KKEPNAPJBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int CBLHADLEMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly OGIIDNDKACI<TKey, TVal>.DFAGMFKEGOG? KAKBECDBAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int FDHOLNELEOP;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int CMBOKFPDPBK
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x509BDB0", Offset = "0x509B1B0", VA = "0x18509BDB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int DMBGGHINDFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA6D130", Offset = "0xA6C530", VA = "0x180A6D130")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x509C4E0", Offset = "0x509B8E0", VA = "0x18509C4E0")]
	public IBDJECOCJFF(int CBLHADLEMML, [Optional] OGIIDNDKACI<TKey, TVal>.DFAGMFKEGOG? KAKBECDBAFK, [Optional] IEqualityComparer<TKey>? BCAEPAAMINN, [Optional] OGIIDNDKACI<TKey, TVal>.EGPEAHFPKDM? KKEPNAPJBDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x509BBA0", Offset = "0x509AFA0", VA = "0x18509BBA0")]
	public void FMLHKLGCIAG(TKey PEENICAIFOP, TVal CBMEHPPMEEA, bool JALOHOKNDNL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x509B570", Offset = "0x509A970", VA = "0x18509B570")]
	public bool AIIMBHNEECM(TKey PEENICAIFOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x509BA00", Offset = "0x509AE00", VA = "0x18509BA00")]
	public bool EGMGAAFJGGH(TKey AEPHGJBOGJL, [Out] TVal CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x509C2B0", Offset = "0x509B6B0", VA = "0x18509C2B0")]
	private void PIDOKKABFLH(TKey PEENICAIFOP, TVal CBMEHPPMEEA, int MPDDFCCPIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x509B770", Offset = "0x509AB70", VA = "0x18509B770")]
	public bool BGDNGFCIEDB(TKey PEENICAIFOP, TVal CBMEHPPMEEA, bool JALOHOKNDNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x509BD50", Offset = "0x509B150", VA = "0x18509BD50")]
	public void HBLMHKLDBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x509BDF0", Offset = "0x509B1F0", VA = "0x18509BDF0")]
	private void MJCNDLNFIPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x509B690", Offset = "0x509AA90", VA = "0x18509B690")]
	private bool BAIADMHLJMG(TKey PEENICAIFOP, PAMCJPFBIFJ HBHJOPNAJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x509BAD0", Offset = "0x509AED0", VA = "0x18509BAD0")]
	private void FCBCEPJCBMK(TKey PEENICAIFOP, TVal CBMEHPPMEEA, PAMCJPFBIFJ HBHJOPNAJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x509B8E0", Offset = "0x509ACE0", VA = "0x18509B8E0")]
	private void DGIFGFHGNEN(TKey PEENICAIFOP, TVal DIMKOEFIKCH, PAMCJPFBIFJ HBHJOPNAJMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class CBILGDNNHNI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action FPMAMKFJABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool FPGDKPPKHDF;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xA75990", Offset = "0xA74D90", VA = "0x180A75990")]
	public CBILGDNNHNI(Action GHBJIOBBNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8415860", Offset = "0x8414C60", VA = "0x188415860", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F370", Offset = "0x3A9E770", VA = "0x183A9F370")]
	public static GDOFCMCMKJK<T> CEOONNIFPHP<T>(T CBMEHPPMEEA, Action GHBJIOBBNNH) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class GDOFCMCMKJK<T> : CBILGDNNHNI where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T JCMAOCOGHGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4F42400", Offset = "0x4F41800", VA = "0x184F42400")]
	public GDOFCMCMKJK(T CBMEHPPMEEA, Action GHBJIOBBNNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class CIBLINIDADN<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly GLLLCGKCFBB<T>? EMDJECHNMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> BGBECCGIPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool FPGDKPPKHDF;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly CIBLINIDADN<T> BOBPMJBGCMC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> HLFACIGAIAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6D75420", Offset = "0x6D74820", VA = "0x186D75420")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long DGIEKOECJCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6D754A0", Offset = "0x6D748A0", VA = "0x186D754A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool GAGDCLONJBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6D759B0", Offset = "0x6D74DB0", VA = "0x186D759B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6D75C50", Offset = "0x6D75050", VA = "0x186D75C50")]
	public CIBLINIDADN(GLLLCGKCFBB<T> CBHEFKBLLCK, GLLLCGKCFBB<T> CIFJJPKAMOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6D75D10", Offset = "0x6D75110", VA = "0x186D75D10")]
	public CIBLINIDADN(GLLLCGKCFBB<T> CBHEFKBLLCK, int FDIBAFEDFOG, GLLLCGKCFBB<T> CIFJJPKAMOO, int GKKJCJFPBAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6D75BA0", Offset = "0x6D74FA0", VA = "0x186D75BA0")]
	private CIBLINIDADN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6D75620", Offset = "0x6D74A20", VA = "0x186D75620", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6D75740", Offset = "0x6D74B40", VA = "0x186D75740")]
	public T[] GGJDOCMICNI()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6D757E0", Offset = "0x6D74BE0", VA = "0x186D757E0")]
	public static ReadOnlySequence<T> GKKMDDPCKIG(CIBLINIDADN<T>? GIAHDGILHGB)
	{
		return default(ReadOnlySequence<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct PMLNAGBNNAD<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly IDisposable CHBFNEOBGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public T JCMAOCOGHGO;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5B1ED10", Offset = "0x5B1E110", VA = "0x185B1ED10")]
	public PMLNAGBNNAD(IDisposable CCGANJILKHA, [In] T CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4465F00", Offset = "0x4465300", VA = "0x184465F00")]
	public static PMLNAGBNNAD<U> DKPNJAMDNJJ<U>([In] PMLNAGBNNAD<T> CCGANJILKHA, [In] U CBMEHPPMEEA) where U : notnull
	{
		return default(PMLNAGBNNAD<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5B1EB90", Offset = "0x5B1DF90", VA = "0x185B1EB90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class AMIKHLILJHI
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3204080", Offset = "0x3203480", VA = "0x183204080")]
	public static PMLNAGBNNAD<T> EJOLKNBPCJB<T>(IDisposable CCGANJILKHA, [In] T CBMEHPPMEEA) where T : notnull
	{
		return default(PMLNAGBNNAD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3204050", Offset = "0x3203450", VA = "0x183204050")]
	public static PMLNAGBNNAD<T> BMKNHHNHILI<T>([In] this PMLNAGBNNAD<T> DMFKPMONDPO, [Out] T CBMEHPPMEEA) where T : notnull
	{
		return default(PMLNAGBNNAD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x31E82B0", Offset = "0x31E76B0", VA = "0x1831E82B0")]
	public static PMLNAGBNNAD<U?> DKPNJAMDNJJ<U, T>([In] PMLNAGBNNAD<T> MHLJCGDPDBO, [In] U CBMEHPPMEEA)
	{
		return default(PMLNAGBNNAD<U>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct NMFBOPDALLH : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public readonly struct IJOJHHFLOEF : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810")]
		public static IJOJHHFLOEF EJOLKNBPCJB()
		{
			return default(IJOJHHFLOEF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8418BA0", Offset = "0x8417FA0", VA = "0x188418BA0")]
	public static string AOCPJLPPGCA(Type IIHAKBEOLJD, [Optional] string? AKHCMEIHMJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3E62660", Offset = "0x3E61A60", VA = "0x183E62660")]
	public static string? AOCPJLPPGCA<T>([Optional] string? AKHCMEIHMJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3E626E0", Offset = "0x3E61AE0", VA = "0x183E626E0")]
	public static string? KIDDNLEIALB<T>([Optional] string? DDPDBAHNFPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810")]
	public static NMFBOPDALLH HBEHBGIAPLO(string AKHCMEIHMJA, string? DDPDBAHNFPH)
	{
		return default(NMFBOPDALLH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct ECBOGFMPPNM
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate bool ALHLKNCHKNI(string NJMJNHHFGNE, ECBOGFMPPNM HABFDGCGCPE);

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class LGBFNKBNDBB<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public LGBFNKBNDBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5505DF0", Offset = "0x55051F0", VA = "0x185505DF0")]
		internal void JNEEMMAEFDN(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public int JFDJMGGLGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public string GGNOKCHEJFE;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8416510", Offset = "0x8415910", VA = "0x188416510")]
	public static Dictionary<string, ECBOGFMPPNM> BLFOMGJLFJD(Type MELDCCHPAJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3B2CC70", Offset = "0x3B2C070", VA = "0x183B2CC70")]
	public static Dictionary<string, ECBOGFMPPNM> BLFOMGJLFJD<T>(Type MELDCCHPAJJ, IReadOnlyDictionary<T, string> EKEOBHKHJDH) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3B2C5B0", Offset = "0x3B2B9B0", VA = "0x183B2C5B0")]
	public static Dictionary<string, ECBOGFMPPNM> ANKODMKBFPL<T>(List<T> PJMDBFNJLII) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8416840", Offset = "0x8415C40", VA = "0x188416840")]
	public static Dictionary<string, ECBOGFMPPNM> GLHBBFNOONO(Type MELDCCHPAJJ, ALHLKNCHKNI OCKEJEBBNHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8416C00", Offset = "0x8416000", VA = "0x188416C00")]
	public static Dictionary<int, string> JJFMPJMOKFJ(Dictionary<string, ECBOGFMPPNM> NHDOFIDIKGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class KIBOPIAKFMB : HJLGPDLCPGE
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool KAKIEFHHKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly string? MGGPAFCEJGA;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual HJLGPDLCPGE? MPOLODBPENC
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8418700", Offset = "0x8417B00", VA = "0x188418700")]
	protected KIBOPIAKFMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string HFHAJICOHIA();

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8418340", Offset = "0x8417740", VA = "0x188418340", Slot = "8")]
	public virtual string IFAPBMPKCIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8418460", Offset = "0x8417860", VA = "0x188418460", Slot = "9")]
	public void KGKKHDGOEPL(StringBuilder LDJKPABJDHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8418060", Offset = "0x8417460", VA = "0x188418060", Slot = "10")]
	public void AIJKONDMKPO(StringBuilder LDJKPABJDHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8418220", Offset = "0x8417620", VA = "0x188418220", Slot = "11")]
	public void HKGBOJABEAC(StringBuilder LDJKPABJDHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x84180C0", Offset = "0x84174C0", VA = "0x1884180C0", Slot = "12")]
	public void EMJNOOLBLBI(StringBuilder LDJKPABJDHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x84183C0", Offset = "0x84177C0", VA = "0x1884183C0")]
	public static void JPFCAOHKIDI(StringBuilder LDJKPABJDHL, string LNOGNANOHAB, string KLAHOFCACLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x72EC4A0", Offset = "0x72EB8A0", VA = "0x1872EC4A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class NEKODBGAOGG : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8418B40", Offset = "0x8417F40", VA = "0x188418B40")]
	public NEKODBGAOGG(string AFDNIPHJHMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class IDLDODEBNFH<TErr> : NEKODBGAOGG where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly TErr LOIHBBIKJDB;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x50AAA40", Offset = "0x50A9E40", VA = "0x1850AAA40")]
	private IDLDODEBNFH([In] TErr MHFBLCFPAFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x50AA980", Offset = "0x50A9D80", VA = "0x1850AA980")]
	public static IDLDODEBNFH<TErr> EJOLKNBPCJB([In] TErr MHFBLCFPAFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class FCBGOHCJNBH : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly HashAlgorithm AGIGNJIBGMD;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool DELHOEPBHFC
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool OJLKFCCBLHN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool ONAFDMFECBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long DGIEKOECJCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8417110", Offset = "0x8416510", VA = "0x188417110", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long BKPAIEKHLGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8417180", Offset = "0x8416580", VA = "0x188417180", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x84171F0", Offset = "0x84165F0", VA = "0x1884171F0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x84170A0", Offset = "0x84164A0", VA = "0x1884170A0")]
	public FCBGOHCJNBH(HashAlgorithm AGIGNJIBGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8416EC0", Offset = "0x84162C0", VA = "0x188416EC0", Slot = "35")]
	public override int Read(byte[] JCGBEKOGKKD, int FDIDNNCIDHK, int PPNAGMANAKJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8417070", Offset = "0x8416470", VA = "0x188417070", Slot = "38")]
	public override void Write(byte[] JCGBEKOGKKD, int FDIDNNCIDHK, int PPNAGMANAKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8416F60", Offset = "0x8416360", VA = "0x188416F60", Slot = "33")]
	public override long Seek(long FDIDNNCIDHK, SeekOrigin GOFLCKHIPLK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8416FF0", Offset = "0x84163F0", VA = "0x188416FF0", Slot = "34")]
	public override void SetLength(long CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8416DE0", Offset = "0x84161E0", VA = "0x188416DE0")]
	public byte[] CJGHENMPGKH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface HJLGPDLCPGE
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string IFAPBMPKCIA();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string HFHAJICOHIA();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface ICJKHMOHJIB<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions JCMAOCOGHGO
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface HCCMGCAOBHE
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string PJGHDLEHGFL
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class GLLLCGKCFBB<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static GLLLCGKCFBB<T>? PAKOOBNCAHM;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static object LNFPCOFNCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private IMemoryOwner<T>? JMJAFJBLNCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool FPGDKPPKHDF;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool EGBEIIKGJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xACC370", Offset = "0xACB770", VA = "0x180ACC370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4F63840", Offset = "0x4F62C40", VA = "0x184F63840")]
	private static GLLLCGKCFBB<T> CJBEDMBBEBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4F64560", Offset = "0x4F63960", VA = "0x184F64560")]
	private static void MLPOKBBFKIL(GLLLCGKCFBB<T> JMJNEBNDLKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4F5B060", Offset = "0x4F5A460", VA = "0x184F5B060")]
	private GLLLCGKCFBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4F63690", Offset = "0x4F62A90", VA = "0x184F63690")]
	public static GLLLCGKCFBB<T> CEOONNIFPHP(ReadOnlyMemory<T> EKMAOLGBFIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4F634A0", Offset = "0x4F628A0", VA = "0x184F634A0")]
	public static GLLLCGKCFBB<T> CEOONNIFPHP(IMemoryOwner<T> COOBANDCKNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4F64290", Offset = "0x4F63690", VA = "0x184F64290")]
	public static void ECDGPFFJJNA(GLLLCGKCFBB<T> CBHEFKBLLCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4F63E70", Offset = "0x4F63270", VA = "0x184F63E70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4F643A0", Offset = "0x4F637A0", VA = "0x184F643A0")]
	public GLLLCGKCFBB<T> GHNFBMEEMFD(IMemoryOwner<T> COOBANDCKNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4F63CB0", Offset = "0x4F630B0", VA = "0x184F63CB0")]
	private void DABBKNPJMAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4F64460", Offset = "0x4F63860", VA = "0x184F64460")]
	private GLLLCGKCFBB<T> GNDFLMCBHLC(GLLLCGKCFBB<T> JMJNEBNDLKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class DAOBIDCKAEF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x84160C0", Offset = "0x84154C0", VA = "0x1884160C0")]
	public DAOBIDCKAEF(string AFDNIPHJHMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class DAGJENHEPEK<TOk> : DAOBIDCKAEF where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly TOk CEBBIFMPJFI;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x44FD2D0", Offset = "0x44FC6D0", VA = "0x1844FD2D0")]
	private DAGJENHEPEK([In] TOk GLDFCBMNMID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x44FD090", Offset = "0x44FC490", VA = "0x1844FD090")]
	public static DAGJENHEPEK<TOk> EJOLKNBPCJB([In] TOk GLDFCBMNMID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct DGHPMJAIBNO<TOk, TErr> : IEquatable<DGHPMJAIBNO<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly EqualityComparer<TErr> CPBMFNMKMLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal readonly TErr LOIHBBIKJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal readonly TOk CEBBIFMPJFI;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool DANGEKHEODL
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x4545580", Offset = "0x4544980", VA = "0x184545580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool ILJNPKNOIMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4549520", Offset = "0x4548920", VA = "0x184549520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x454B6B0", Offset = "0x454AAB0", VA = "0x18454B6B0")]
	internal DGHPMJAIBNO([In] TErr MHFBLCFPAFC, [In] TOk GLDFCBMNMID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x45486C0", Offset = "0x4547AC0", VA = "0x1845486C0")]
	public static DGHPMJAIBNO<TOk, TErr> KFPMIBGECCL([In] TErr MHFBLCFPAFC)
	{
		return default(DGHPMJAIBNO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4548FE0", Offset = "0x45483E0", VA = "0x184548FE0")]
	public static DGHPMJAIBNO<TOk, TErr> NCCEHLOBFNO([In] TOk GLDFCBMNMID)
	{
		return default(DGHPMJAIBNO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3DB9E80", Offset = "0x3DB9280", VA = "0x183DB9E80")]
	public DGHPMJAIBNO<TOk?, UErr?> BEFAFIKOPBF<UErr>()
	{
		return default(DGHPMJAIBNO<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3DBABD0", Offset = "0x3DB9FD0", VA = "0x183DBABD0")]
	public DGHPMJAIBNO<UOk?, TErr?> DHFFJANAFBF<UOk>()
	{
		return default(DGHPMJAIBNO<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3DBB840", Offset = "0x3DBAC40", VA = "0x183DBB840")]
	public DGHPMJAIBNO<UOk?, TErr?> EJEEBDFJAMP<UOk>()
	{
		return default(DGHPMJAIBNO<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3DBC2C0", Offset = "0x3DBB6C0", VA = "0x183DBC2C0")]
	public DGHPMJAIBNO<TOk?, UErr?> JHDLCEPNBJK<UErr>()
	{
		return default(DGHPMJAIBNO<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x45459A0", Offset = "0x4544DA0", VA = "0x1845459A0")]
	public DGHPMJAIBNO<EPILOLMBDMK, TErr> DPFNHGHCOHO()
	{
		return default(DGHPMJAIBNO<EPILOLMBDMK, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4547B30", Offset = "0x4546F30", VA = "0x184547B30")]
	public static bool ILMCFLMCOJH([In] DGHPMJAIBNO<TOk, TErr> JLJHECODIOL, [In] DGHPMJAIBNO<TOk, TErr> DABLONGJEGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4545D80", Offset = "0x4545180", VA = "0x184545D80", Slot = "4")]
	public bool Equals(DGHPMJAIBNO<TOk, TErr> LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4545F00", Offset = "0x4545300", VA = "0x184545F00", Slot = "0")]
	public override bool Equals(object LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x45476E0", Offset = "0x4546AE0", VA = "0x1845476E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4549920", Offset = "0x4548D20", VA = "0x184549920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class KIBHEGDIHDN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct KJPLABOEAGF<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Task<DGHPMJAIBNO<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<DGHPMJAIBNO<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5458DD0", Offset = "0x54581D0", VA = "0x185458DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x530D240", Offset = "0x530C640", VA = "0x18530D240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct MGPIMIMDFLL<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<DGHPMJAIBNO<EPILOLMBDMK, TErr>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public Task<DGHPMJAIBNO<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter<DGHPMJAIBNO<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x57732D0", Offset = "0x57726D0", VA = "0x1857732D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5773600", Offset = "0x5772A00", VA = "0x185773600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3D7D4B0", Offset = "0x3D7C8B0", VA = "0x183D7D4B0")]
	public static DGHPMJAIBNO<TOk?, TErr?> CEBBIFMPJFI<TOk, TErr>([In] this DGHPMJAIBNO<TOk, TErr> DMFKPMONDPO, [In] TOk GLDFCBMNMID)
	{
		return default(DGHPMJAIBNO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3D7D590", Offset = "0x3D7C990", VA = "0x183D7D590")]
	public static DGHPMJAIBNO<EPILOLMBDMK, TErr?> CEBBIFMPJFI<TErr>([In] this DGHPMJAIBNO<EPILOLMBDMK, TErr> DMFKPMONDPO)
	{
		return default(DGHPMJAIBNO<EPILOLMBDMK, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3D7D4B0", Offset = "0x3D7C8B0", VA = "0x183D7D4B0")]
	public static DGHPMJAIBNO<TOk?, TErr?> LOIHBBIKJDB<TOk, TErr>([In] this DGHPMJAIBNO<TOk, TErr> DMFKPMONDPO, [In] TErr MHFBLCFPAFC)
	{
		return default(DGHPMJAIBNO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3D80F30", Offset = "0x3D80330", VA = "0x183D80F30")]
	public static TOk? PBJMNJDGPFK<TOk, TErr>([In] this DGHPMJAIBNO<TOk, TErr> DMFKPMONDPO)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3D807E0", Offset = "0x3D7FBE0", VA = "0x183D807E0")]
	[AsyncStateMachine(typeof(KJPLABOEAGF<, >))]
	public static Task<TOk?>? MFAFBNMPCOO<TOk, TErr>(this Task<DGHPMJAIBNO<TOk, TErr>> DMFKPMONDPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3D80330", Offset = "0x3D7F730", VA = "0x183D80330")]
	public static TErr? MEPIPILAGEJ<TErr, TOk>([In] this DGHPMJAIBNO<TOk, TErr> DMFKPMONDPO)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3D7E760", Offset = "0x3D7DB60", VA = "0x183D7E760")]
	public static bool IFFBOGDHKLN<TOk, TErr, UErr, UOk>([In] this DGHPMJAIBNO<TOk, TErr> DMFKPMONDPO, [Out] DGHPMJAIBNO<UOk, UErr> OLAHDIFANFH) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3D7FE90", Offset = "0x3D7F290", VA = "0x183D7FE90")]
	public static bool MEBENMJKBGM<TOk, TErr>([In] this DGHPMJAIBNO<TOk, TErr> DMFKPMONDPO, [Out] TOk GLDFCBMNMID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3D7E500", Offset = "0x3D7D900", VA = "0x183D7E500")]
	public static bool FFNLMNMOMMH<TOk, TErr>([In] this DGHPMJAIBNO<TOk, TErr> DMFKPMONDPO, [Out][NotNullWhen(true)] TErr MHFBLCFPAFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3D7E270", Offset = "0x3D7D670", VA = "0x183D7E270")]
	public static bool FENEMBHOKGE<TOk, TErr>([In] this DGHPMJAIBNO<TOk, TErr> DMFKPMONDPO, [Out][NotNullWhen(true)] TOk GLDFCBMNMID, [Out][NotNullWhen(false)] TErr MHFBLCFPAFC) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3D7D850", Offset = "0x3D7CC50", VA = "0x183D7D850")]
	public static bool EPFBEMAALGJ<TOk, TErr>([In] this DGHPMJAIBNO<TOk, TErr> DMFKPMONDPO, [Out][NotNullWhen(true)] TOk GLDFCBMNMID, [Out] DGHPMJAIBNO<TOk, TErr> OLAHDIFANFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3D7EBF0", Offset = "0x3D7DFF0", VA = "0x183D7EBF0")]
	public static bool IFFBOGDHKLN<TOk, TErr, UErr, UOk>([In] this DGHPMJAIBNO<TOk, TErr> DMFKPMONDPO, [Out][NotNullWhen(true)] TOk GLDFCBMNMID, [Out] DGHPMJAIBNO<UOk, UErr> OLAHDIFANFH) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3D80A70", Offset = "0x3D7FE70", VA = "0x183D80A70")]
	public static bool OHCIHJHOGFC<TOk, TErr>([In] this DGHPMJAIBNO<TOk, TErr> DMFKPMONDPO, [Out][NotNullWhen(true)] TOk GLDFCBMNMID, [Out] DGHPMJAIBNO<EPILOLMBDMK, TErr> OLAHDIFANFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3D7DCB0", Offset = "0x3D7D0B0", VA = "0x183D7DCB0")]
	public static DGHPMJAIBNO<UOk, UErr> EPGCMLLLJCF<UOk, UErr, TOk, TErr>([In] this DGHPMJAIBNO<TOk, TErr> DMFKPMONDPO, [In] DGHPMJAIBNO<UOk, UErr> PCKIEOGDDCF) where TOk : UOk where TErr : UErr
	{
		return default(DGHPMJAIBNO<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3D7FB50", Offset = "0x3D7EF50", VA = "0x183D7FB50")]
	public static DGHPMJAIBNO<TOk?[]?, TErr?> KLFDPAPCKOE<TOk, TErr>(this IEnumerable<DGHPMJAIBNO<TOk, TErr>> DMFKPMONDPO)
	{
		return default(DGHPMJAIBNO<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3D7D230", Offset = "0x3D7C630", VA = "0x183D7D230")]
	public static DGHPMJAIBNO<UOk?, TErr?> ABGFPJEFANO<UOk, TErr, TOk>([In] this DGHPMJAIBNO<TOk, TErr> DMFKPMONDPO, Func<TOk, UOk> FNBFHFBPPAI)
	{
		return default(DGHPMJAIBNO<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3D7D690", Offset = "0x3D7CA90", VA = "0x183D7D690")]
	[AsyncStateMachine(typeof(MGPIMIMDFLL<, >))]
	public static Task<DGHPMJAIBNO<EPILOLMBDMK, TErr?>>? DGDBPDJDOHJ<TErr, TOk>(this Task<DGHPMJAIBNO<TOk, TErr>> DMFKPMONDPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class KFDENGFOKGD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x445A170", Offset = "0x4459570", VA = "0x18445A170")]
	public static DGHPMJAIBNO<TOk, T> CEBBIFMPJFI<TOk>([In] TOk GLDFCBMNMID) where TOk : notnull
	{
		return default(DGHPMJAIBNO<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5447580", Offset = "0x5446980", VA = "0x185447580")]
	public static DGHPMJAIBNO<EPILOLMBDMK, T> CEBBIFMPJFI()
	{
		return default(DGHPMJAIBNO<EPILOLMBDMK, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x445A170", Offset = "0x4459570", VA = "0x18445A170")]
	public static DGHPMJAIBNO<T, TErr> LOIHBBIKJDB<TErr>([In] TErr MHFBLCFPAFC) where TErr : notnull
	{
		return default(DGHPMJAIBNO<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct MBPAIKAMHDM<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly CNAJIACIANN HICHBCHAFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly Dictionary<TKey, TValue> AGIHJLJLCCM;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x576ADF0", Offset = "0x576A1F0", VA = "0x18576ADF0")]
	public static MBPAIKAMHDM<TKey, TValue> EJOLKNBPCJB(string HFJHENFIDEF)
	{
		return default(MBPAIKAMHDM<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x576AF00", Offset = "0x576A300", VA = "0x18576AF00")]
	internal MBPAIKAMHDM(Dictionary<TKey, TValue> CBMEHPPMEEA, CNAJIACIANN DKEAMEEILGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x576AD50", Offset = "0x576A150", VA = "0x18576AD50")]
	public BADGBGDEGON<TKey, TValue> BIOCIAKBOAD([Out] Dictionary<TKey, TValue> CBMEHPPMEEA)
	{
		return default(BADGBGDEGON<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct BADGBGDEGON<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly Dictionary<TKey, TValue> AGIHJLJLCCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly EOMFLCECKKI KLOOCGCMAEO;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2CEFCF0", Offset = "0x2CEF0F0", VA = "0x182CEFCF0")]
	internal BADGBGDEGON(Dictionary<TKey, TValue> CBMEHPPMEEA, EOMFLCECKKI BMABKENEKEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5595D60", Offset = "0x5595160", VA = "0x185595D60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct NLFJALEEHHE<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly CNAJIACIANN HICHBCHAFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly HashSet<T> AGIHJLJLCCM;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x576ADF0", Offset = "0x576A1F0", VA = "0x18576ADF0")]
	public static NLFJALEEHHE<T> EJOLKNBPCJB(string HFJHENFIDEF)
	{
		return default(NLFJALEEHHE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x576AF00", Offset = "0x576A300", VA = "0x18576AF00")]
	internal NLFJALEEHHE(HashSet<T> CBMEHPPMEEA, CNAJIACIANN DKEAMEEILGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x576AD50", Offset = "0x576A150", VA = "0x18576AD50")]
	public PENFFHDFDHG<T> BIOCIAKBOAD([Out] HashSet<T> CBMEHPPMEEA)
	{
		return default(PENFFHDFDHG<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct PENFFHDFDHG<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly HashSet<T> AGIHJLJLCCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly EOMFLCECKKI KLOOCGCMAEO;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2CEFCF0", Offset = "0x2CEF0F0", VA = "0x182CEFCF0")]
	internal PENFFHDFDHG(HashSet<T> CBMEHPPMEEA, EOMFLCECKKI BMABKENEKEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5595D60", Offset = "0x5595160", VA = "0x185595D60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct PAALJHDHAJP<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly CNAJIACIANN HICHBCHAFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly Stack<T> AGIHJLJLCCM;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x576ADF0", Offset = "0x576A1F0", VA = "0x18576ADF0")]
	public static PAALJHDHAJP<T> EJOLKNBPCJB(string HFJHENFIDEF)
	{
		return default(PAALJHDHAJP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x576AF00", Offset = "0x576A300", VA = "0x18576AF00")]
	internal PAALJHDHAJP(Stack<T> CBMEHPPMEEA, CNAJIACIANN DKEAMEEILGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x576AD50", Offset = "0x576A150", VA = "0x18576AD50")]
	public LPGEILALEOD<T> BIOCIAKBOAD([Out] Stack<T> CBMEHPPMEEA)
	{
		return default(LPGEILALEOD<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct LPGEILALEOD<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly Stack<T> AGIHJLJLCCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly EOMFLCECKKI KLOOCGCMAEO;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2CEFCF0", Offset = "0x2CEF0F0", VA = "0x182CEFCF0")]
	internal LPGEILALEOD(Stack<T> CBMEHPPMEEA, EOMFLCECKKI BMABKENEKEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5595D60", Offset = "0x5595160", VA = "0x185595D60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[DefaultMember("Item")]
public sealed class ADHAEPOFCHG<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct MDAKCFCGELO : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly ADHAEPOFCHG<T> MGLMDMDAILN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly int EHFLACPFJIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly bool EGLLAFKIKJF;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2935CA0", Offset = "0x29350A0", VA = "0x182935CA0")]
		public MDAKCFCGELO(ADHAEPOFCHG<T> FCHDCHMAIKA, int MMAAEDDJIBI, bool MKEGMDDJOAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x576C7C0", Offset = "0x576BBC0", VA = "0x18576C7C0")]
		public ADHAEPOFCHG<T>.MJNGDLCGBIN OJAPBOKMMBI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x576C8A0", Offset = "0x576BCA0", VA = "0x18576C8A0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x576C8A0", Offset = "0x576BCA0", VA = "0x18576C8A0", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public sealed class MJNGDLCGBIN : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly ADHAEPOFCHG<T> MGLMDMDAILN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly int JKPGBJGICJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private int GAGLJCGNOGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly bool EGLLAFKIKJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private bool HBDKBEIAPFK;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T FEIHGLOFMJE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x5786290", Offset = "0x5785690", VA = "0x185786290")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x57863E0", Offset = "0x57857E0", VA = "0x1857863E0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x5786570", Offset = "0x5785970", VA = "0x185786570", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5786940", Offset = "0x5785D40", VA = "0x185786940")]
		public MJNGDLCGBIN(ADHAEPOFCHG<T> FCHDCHMAIKA, int MMAAEDDJIBI, bool MKEGMDDJOAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5786310", Offset = "0x5785710", VA = "0x185786310", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5786390", Offset = "0x5785790", VA = "0x185786390", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class APCGJBLBJHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public APCGJBLBJHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x53AA090", Offset = "0x53A9490", VA = "0x1853AA090")]
		internal T CHCOOHFKFHN(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly T[] IANANFBCEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private int GAGLJCGNOGN;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int NGLADCLNDKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5105AE0", Offset = "0x5104EE0", VA = "0x185105AE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T FEIHGLOFMJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x4E55EA0", Offset = "0x4E552A0", VA = "0x184E55EA0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T BKPAKGNHJLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5105960", Offset = "0x5104D60", VA = "0x185105960")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T FMHPKKMCCLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x51059E0", Offset = "0x5104DE0", VA = "0x1851059E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int DGIEKOECJCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x28D9E10", Offset = "0x28D9210", VA = "0x1828D9E10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1D323A0", Offset = "0x1D317A0", VA = "0x181D323A0")]
	private static int PCCPKEHPMJF(int NOEININIMIL, int COONBEDHJNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5105D00", Offset = "0x5105100", VA = "0x185105D00")]
	public ADHAEPOFCHG(int MPDDFCCPIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5105E10", Offset = "0x5105210", VA = "0x185105E10")]
	public ADHAEPOFCHG(int MPDDFCCPIOM, Func<T> CLEHFJGJKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5105F70", Offset = "0x5105370", VA = "0x185105F70")]
	public ADHAEPOFCHG(T[] PHCFLGCBHJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5105930", Offset = "0x5104D30", VA = "0x185105930")]
	public void AKHGPBLBDIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5105B20", Offset = "0x5104F20", VA = "0x185105B20")]
	public IEnumerable<T> LLFHNAMJEGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5105BE0", Offset = "0x5104FE0", VA = "0x185105BE0")]
	public ADHAEPOFCHG<T>.MJNGDLCGBIN OJAPBOKMMBI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x4566BF0", Offset = "0x4565FF0", VA = "0x184566BF0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x4566BF0", Offset = "0x4565FF0", VA = "0x184566BF0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class INAIMBPDFKD
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3D318A0", Offset = "0x3D30CA0", VA = "0x183D318A0")]
	public static ADHAEPOFCHG<T> EJOLKNBPCJB<T>(int MPDDFCCPIOM, Func<T> CLEHFJGJKMK) where T : notnull
	{
		return null;
	}
}
namespace RecRoom.NoEngine.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public struct RRColor : IEquatable<RRColor>, IFormattable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static RRColor White
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x6FDCAB0", Offset = "0x6FDBEB0", VA = "0x186FDCAB0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static RRColor Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x8419C00", Offset = "0x8419000", VA = "0x188419C00")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static RRColor Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x8419C20", Offset = "0x8419020", VA = "0x188419C20")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static RRColor Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x8419C40", Offset = "0x8419040", VA = "0x188419C40")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static RRColor Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x8419BE0", Offset = "0x8418FE0", VA = "0x188419BE0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2A6F300", Offset = "0x2A6E700", VA = "0x182A6F300")]
		public RRColor(float GDOMDKGJNLG, float OCIGECIELML, float JOCIBENNGKI, float HCFCOMCPJPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8294370", Offset = "0x8293770", VA = "0x188294370", Slot = "4")]
		public bool Equals(RRColor LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8419820", Offset = "0x8418C20", VA = "0x188419820", Slot = "0")]
		public override bool Equals(object LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8419920", Offset = "0x8418D20", VA = "0x188419920", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x84199A0", Offset = "0x8418DA0", VA = "0x1884199A0", Slot = "5")]
		public string ToString(string LKPDHLBCOHA, IFormatProvider PEDOFKBGLGM)
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct RRColor32 : IEquatable<RRColor32>, IFormattable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private int rgba;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public byte r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public byte g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public byte b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public byte a;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public static RRColor32 White
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x84197C0", Offset = "0x8418BC0", VA = "0x1884197C0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static RRColor32 Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x8419760", Offset = "0x8418B60", VA = "0x188419760")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static RRColor32 Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x8419790", Offset = "0x8418B90", VA = "0x188419790")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static RRColor32 Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x84197F0", Offset = "0x8418BF0", VA = "0x1884197F0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static RRColor32 Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x8419730", Offset = "0x8418B30", VA = "0x188419730")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x61917A0", Offset = "0x6190BA0", VA = "0x1861917A0")]
		public RRColor32(byte GDOMDKGJNLG, byte OCIGECIELML, byte JOCIBENNGKI, byte HCFCOMCPJPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x247B9F0", Offset = "0x247ADF0", VA = "0x18247B9F0", Slot = "4")]
		public bool Equals(RRColor32 LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8419270", Offset = "0x8418670", VA = "0x188419270", Slot = "0")]
		public override bool Equals(object LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x1543490", Offset = "0x1542890", VA = "0x181543490", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8419300", Offset = "0x8418700", VA = "0x188419300")]
		public static RRColor32 GKKMDDPCKIG(RRColor CHNNNFLKBNN)
		{
			return default(RRColor32);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8419450", Offset = "0x8418850", VA = "0x188419450")]
		public static RRColor GKKMDDPCKIG(RRColor32 CHNNNFLKBNN)
		{
			return default(RRColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x84194C0", Offset = "0x84188C0", VA = "0x1884194C0", Slot = "5")]
		public string ToString(string LKPDHLBCOHA, IFormatProvider PEDOFKBGLGM)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class NCLCONOEGLF<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct DEJFNGMCCCN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private readonly NCLCONOEGLF<T> CLNJOMECLCD;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T JCMAOCOGHGO
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x453D960", Offset = "0x453CD60", VA = "0x18453D960")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x453D930", Offset = "0x453CD30", VA = "0x18453D930", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xE62750", Offset = "0xE61B50", VA = "0x180E62750")]
		public DEJFNGMCCCN(NCLCONOEGLF<T> CLNJOMECLCD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct EDFMAPGJEIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AsyncTaskMethodBuilder<DEJFNGMCCCN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public NCLCONOEGLF<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x49B64E0", Offset = "0x49B58E0", VA = "0x1849B64E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x49B6E60", Offset = "0x49B6260", VA = "0x1849B6E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly SemaphoreSlim INJHOONFGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private T NJJNGJCGMCC;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x57EC810", Offset = "0x57EBC10", VA = "0x1857EC810")]
	public NCLCONOEGLF([In] T NJJNGJCGMCC, int NDPNMMHLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x57EC7F0", Offset = "0x57EBBF0", VA = "0x1857EC7F0")]
	public NCLCONOEGLF([In] T NJJNGJCGMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x57EC310", Offset = "0x57EB710", VA = "0x1857EC310", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x57EC370", Offset = "0x57EB770", VA = "0x1857EC370")]
	public DEJFNGMCCCN OBLKALNLBNA()
	{
		return default(DEJFNGMCCCN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x57EC5D0", Offset = "0x57EB9D0", VA = "0x1857EC5D0")]
	[AsyncStateMachine(typeof(NCLCONOEGLF<>.EDFMAPGJEIC))]
	public Task<NCLCONOEGLF<T>.DEJFNGMCCCN> OGPLEKFAENM(CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x57EC350", Offset = "0x57EB750", VA = "0x1857EC350")]
	public void ILJHNIALMHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class DPMOCMDPMOC
{
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x84164A0", Offset = "0x84158A0", VA = "0x1884164A0")]
	public static NCLCONOEGLF<EPILOLMBDMK> EJOLKNBPCJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3AAC6E0", Offset = "0x3AABAE0", VA = "0x183AAC6E0")]
	public static NCLCONOEGLF<T> EJOLKNBPCJB<T>([In] T NJJNGJCGMCC) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public sealed class IPPPIMEBDHC<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public readonly struct KPHFMPJELCD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly IPPPIMEBDHC<T> NIFIJFJAPDN;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public T JCMAOCOGHGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x5102200", Offset = "0x5101600", VA = "0x185102200")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5472700", Offset = "0x5471B00", VA = "0x185472700", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xE62750", Offset = "0xE61B50", VA = "0x180E62750")]
		internal KPHFMPJELCD(IPPPIMEBDHC<T> CLNJOMECLCD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public readonly struct ACGGIGPOJKG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly IPPPIMEBDHC<T> NIFIJFJAPDN;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public T JCMAOCOGHGO
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x5102200", Offset = "0x5101600", VA = "0x185102200")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x51021B0", Offset = "0x51015B0", VA = "0x1851021B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xE62750", Offset = "0xE61B50", VA = "0x180E62750")]
		internal ACGGIGPOJKG(IPPPIMEBDHC<T> CLNJOMECLCD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct KLHEHNAAFML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public AsyncTaskMethodBuilder<ACGGIGPOJKG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public IPPPIMEBDHC<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private NCLCONOEGLF<EPILOLMBDMK>.DEJFNGMCCCN <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<NCLCONOEGLF<EPILOLMBDMK>.DEJFNGMCCCN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x545D8F0", Offset = "0x545CCF0", VA = "0x18545D8F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x49B6E60", Offset = "0x49B6260", VA = "0x1849B6E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly NCLCONOEGLF<int> NBCJOMEOLNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly NCLCONOEGLF<EPILOLMBDMK> FENCMONDAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly NCLCONOEGLF<EPILOLMBDMK> KGHCFBEBNEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private T PENIDOGDIJG;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x511D810", Offset = "0x511CC10", VA = "0x18511D810")]
	internal IPPPIMEBDHC(NCLCONOEGLF<int> ONJINPBNKHC, NCLCONOEGLF<EPILOLMBDMK> CJNEJEAMCLL, NCLCONOEGLF<EPILOLMBDMK> FAAENOCNNBE, [In] T NJJNGJCGMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x511CB20", Offset = "0x511BF20", VA = "0x18511CB20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x511D650", Offset = "0x511CA50", VA = "0x18511D650")]
	public KPHFMPJELCD LJMMIIDCAAL()
	{
		return default(KPHFMPJELCD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x511CCA0", Offset = "0x511C0A0", VA = "0x18511CCA0")]
	public ACGGIGPOJKG FIAMOLGPIJD()
	{
		return default(ACGGIGPOJKG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x511CF70", Offset = "0x511C370", VA = "0x18511CF70")]
	[AsyncStateMachine(typeof(IPPPIMEBDHC<>.KLHEHNAAFML))]
	public Task<IPPPIMEBDHC<T>.ACGGIGPOJKG> GCCMAODCNJA(CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class HDBIOPFABBG
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x8417270", Offset = "0x8416670", VA = "0x188417270")]
	public static IPPPIMEBDHC<EPILOLMBDMK> EJOLKNBPCJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3CC00B0", Offset = "0x3CBF4B0", VA = "0x183CC00B0")]
	public static IPPPIMEBDHC<T> EJOLKNBPCJB<T>([In] T NJJNGJCGMCC) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public sealed class MLJMIKJLFCC<TData> : KIBOPIAKFMB where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly string PBICDNNDDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly TData NMPPAMCHJMA;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "7")]
	public override string HFHAJICOHIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5790970", Offset = "0x578FD70", VA = "0x185790970")]
	internal MLJMIKJLFCC(string AFDNIPHJHMO, [In] TData NGIAGNLBILI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class CHPAPILLHLO
{
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x84159D0", Offset = "0x8414DD0", VA = "0x1884159D0")]
	public static MLJMIKJLFCC<EPILOLMBDMK> EJOLKNBPCJB(string AFDNIPHJHMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F370", Offset = "0x3A9E770", VA = "0x183A9F370")]
	public static MLJMIKJLFCC<TData> EJOLKNBPCJB<TData>(string AFDNIPHJHMO, [In] TData NGIAGNLBILI) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class CNAJIACIANN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal bool BCBABPJHANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly string NPDOFFDMBLP;

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0xF4BA70", Offset = "0xF4AE70", VA = "0x180F4BA70")]
	private CNAJIACIANN(bool BFCGBLJKJHO, string FFBOAMOPNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x8416050", Offset = "0x8415450", VA = "0x188416050")]
	public static CNAJIACIANN EJOLKNBPCJB(string FFBOAMOPNCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x8415F90", Offset = "0x8415390", VA = "0x188415F90")]
	public EOMFLCECKKI BIOCIAKBOAD()
	{
		return default(EOMFLCECKKI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public readonly struct EOMFLCECKKI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly CNAJIACIANN KJPNDFJEGAF;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0xE62750", Offset = "0xE61B50", VA = "0x180E62750")]
	internal EOMFLCECKKI(CNAJIACIANN HFJHENFIDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x8416DC0", Offset = "0x84161C0", VA = "0x188416DC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
public sealed class FDKHPJDOEOI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class FIIOFDCMNAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public FIIOFDCMNAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x4E929E0", Offset = "0x4E91DE0", VA = "0x184E929E0")]
		internal int IPIPIJKEPPF(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private HashSet<T>? OJMPOJJLIBF;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public IReadOnlyCollection<T> MBKMNIIFPKL
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x4E61060", Offset = "0x4E60460", VA = "0x184E61060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool JEJIMLOFMIK
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x4E61030", Offset = "0x4E60430", VA = "0x184E61030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int JGJMKJIDNDK
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA72120", Offset = "0xA71520", VA = "0x180A72120")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA72110", Offset = "0xA71510", VA = "0x180A72110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x4E61110", Offset = "0x4E60510", VA = "0x184E61110")]
	public bool KOBMLIBBKBO(T MONGIMOHLAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x4E60F20", Offset = "0x4E60320", VA = "0x184E60F20")]
	public bool CBDHBFLGDII(T MONGIMOHLAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x4E60EE0", Offset = "0x4E602E0", VA = "0x184E60EE0")]
	public bool BIEHLJBGGLM(T MONGIMOHLAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x4E61090", Offset = "0x4E60490", VA = "0x184E61090")]
	public void HDLNNFECEND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x4E61260", Offset = "0x4E60660", VA = "0x184E61260", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public FDKHPJDOEOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public sealed class CKBPAEHADCP
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class KFKNGAMLMCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public KFKNGAMLMCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8417FB0", Offset = "0x84173B0", VA = "0x188417FB0")]
		internal int IPIPIJKEPPF(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private HashSet<object>? OJMPOJJLIBF;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyCollection<object> MBKMNIIFPKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8415C00", Offset = "0x8415000", VA = "0x188415C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool JEJIMLOFMIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8415BF0", Offset = "0x8414FF0", VA = "0x188415BF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int JGJMKJIDNDK
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xA72120", Offset = "0xA71520", VA = "0x180A72120")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xA72110", Offset = "0xA71510", VA = "0x180A72110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x8415D00", Offset = "0x8415100", VA = "0x188415D00")]
	public bool KOBMLIBBKBO(object MONGIMOHLAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x8415B50", Offset = "0x8414F50", VA = "0x188415B50")]
	public bool CBDHBFLGDII(object MONGIMOHLAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x8415AF0", Offset = "0x8414EF0", VA = "0x188415AF0")]
	public bool BIEHLJBGGLM(object MONGIMOHLAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x8415C90", Offset = "0x8415090", VA = "0x188415C90")]
	public void HDLNNFECEND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x8415DE0", Offset = "0x84151E0", VA = "0x188415DE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public CKBPAEHADCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class BIMJFEECNNG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private struct JJOKHIINCNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public float FMFDBMLDALO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public T JCMAOCOGHGO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Dictionary<object, JJOKHIINCNK> JAIKDDBMDJG;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public virtual T EDDJHMLFBGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x1243D00", Offset = "0x1243100", VA = "0x181243D00", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x1C0B7A0", Offset = "0x1C0ABA0", VA = "0x181C0B7A0", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public object? LNOPCBKMDDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool NICHKAPJLPN
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x65560B0", Offset = "0x65554B0", VA = "0x1865560B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6556400", Offset = "0x6555800", VA = "0x186556400")]
	public bool JBMMNIEJAPK(T CBMEHPPMEEA, object MONGIMOHLAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x455A380", Offset = "0x4559780", VA = "0x18455A380")]
	public bool LLNGNBGKNFB(object MONGIMOHLAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6556080", Offset = "0x6555480", VA = "0x186556080")]
	public void HBLMHKLDBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6555E90", Offset = "0x6555290", VA = "0x186555E90")]
	public bool EGMGAAFJGGH(object MONGIMOHLAO, [Out] T CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x65568B0", Offset = "0x6555CB0", VA = "0x1865568B0")]
	[PNFIJEAKPLK("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool OIOLMHFDDNE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x455A560", Offset = "0x4559960", VA = "0x18455A560")]
	public BIMJFEECNNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public sealed class JPBKNFHFEPN : ADBDGELDCHC<ACAHCPOBLDI>
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal class DOELGCKJOOJ : IEqualityComparer<ACAHCPOBLDI>
	{
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		internal static readonly DOELGCKJOOJ NKAKNKMIPPI;

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8416400", Offset = "0x8415800", VA = "0x188416400", Slot = "4")]
		public bool Equals(ACAHCPOBLDI FNBJHADJBNG, ACAHCPOBLDI MODFPFNICHM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x74D7830", Offset = "0x74D6C30", VA = "0x1874D7830", Slot = "5")]
		public int GetHashCode(ACAHCPOBLDI DEJGDIIDCDN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public DOELGCKJOOJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x8417F40", Offset = "0x8417340", VA = "0x188417F40")]
	public JPBKNFHFEPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x8417E00", Offset = "0x8417200", VA = "0x188417E00", Slot = "4")]
	public override bool KOBMLIBBKBO(ACAHCPOBLDI MONGIMOHLAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x8417D50", Offset = "0x8417150", VA = "0x188417D50", Slot = "5")]
	public override bool CBDHBFLGDII(ACAHCPOBLDI MONGIMOHLAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x8417EB0", Offset = "0x84172B0", VA = "0x188417EB0")]
	private static void PALLIIMJOHC(ACAHCPOBLDI MONGIMOHLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0xAD6320", Offset = "0xAD5720", VA = "0x180AD6320", Slot = "6")]
	protected override string TokenToString(ACAHCPOBLDI MONGIMOHLAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public sealed class ACAHCPOBLDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly string KOLCDJJEHGP;

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0xA75990", Offset = "0xA74D90", VA = "0x180A75990")]
	public ACAHCPOBLDI(string KOLCDJJEHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x8415810", Offset = "0x8414C10", VA = "0x188415810", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class ADBDGELDCHC<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly IEqualityComparer<T> LJGHFBEMAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private HashSet<T>? OJMPOJJLIBF;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public IReadOnlyCollection<T> MBKMNIIFPKL
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x5104710", Offset = "0x5103B10", VA = "0x185104710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool JEJIMLOFMIK
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x4E61030", Offset = "0x4E60430", VA = "0x184E61030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int JGJMKJIDNDK
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0xACA830", Offset = "0xAC9C30", VA = "0x180ACA830")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0xACB540", Offset = "0xACA940", VA = "0x180ACB540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x51050D0", Offset = "0x51044D0", VA = "0x1851050D0")]
	public ADBDGELDCHC(IEqualityComparer<T> LJGHFBEMAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5104920", Offset = "0x5103D20", VA = "0x185104920", Slot = "4")]
	public virtual bool KOBMLIBBKBO(T MONGIMOHLAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x51044F0", Offset = "0x51038F0", VA = "0x1851044F0", Slot = "5")]
	public virtual bool CBDHBFLGDII(T MONGIMOHLAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5104740", Offset = "0x5103B40", VA = "0x185104740")]
	public void HDLNNFECEND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract string TokenToString(T MONGIMOHLAO);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5104A90", Offset = "0x5103E90", VA = "0x185104A90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public sealed class HELNKODHDJF<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<WeakReference<T>>? OJMPOJJLIBF;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool JEJIMLOFMIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x4FB3C60", Offset = "0x4FB3060", VA = "0x184FB3C60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int JGJMKJIDNDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x4FB3D50", Offset = "0x4FB3150", VA = "0x184FB3D50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x4FB3EB0", Offset = "0x4FB32B0", VA = "0x184FB3EB0")]
	public void KOBMLIBBKBO(T MONGIMOHLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x4FB3B20", Offset = "0x4FB2F20", VA = "0x184FB3B20")]
	public void CBDHBFLGDII(T MONGIMOHLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x4FB3A10", Offset = "0x4FB2E10", VA = "0x184FB3A10")]
	public bool BIEHLJBGGLM(T MONGIMOHLAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x4FB3E90", Offset = "0x4FB3290", VA = "0x184FB3E90")]
	public void HDLNNFECEND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x4FB40B0", Offset = "0x4FB34B0", VA = "0x184FB40B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public HELNKODHDJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class FEONAHADAEA
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3C9C270", Offset = "0x3C9B670", VA = "0x183C9C270")]
	public static void LMGKJCJANMJ<T>(this List<T> KIGLENMLJCP, int NOEININIMIL) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class CHLDICFJDCP<T> where T : notnull, IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private struct HJGMLDCNMCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public float FMFDBMLDALO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public T JCMAOCOGHGO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly Dictionary<ACAHCPOBLDI, HJGMLDCNMCN> JAIKDDBMDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly EqualityComparer<T> AGPDIPPBJAE;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public virtual T EDDJHMLFBGA
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xA703B0", Offset = "0xA6F7B0", VA = "0x180A703B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xA702A0", Offset = "0xA6F6A0", VA = "0x180A702A0", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	private ACAHCPOBLDI? LNOPCBKMDDF
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool NICHKAPJLPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x65560B0", Offset = "0x65554B0", VA = "0x1865560B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6D74B20", Offset = "0x6D73F20", VA = "0x186D74B20")]
	public bool JBMMNIEJAPK(T CBMEHPPMEEA, ACAHCPOBLDI MONGIMOHLAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x455A380", Offset = "0x4559780", VA = "0x18455A380")]
	public bool LLNGNBGKNFB(ACAHCPOBLDI MONGIMOHLAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6556080", Offset = "0x6555480", VA = "0x186556080")]
	public void HBLMHKLDBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6556010", Offset = "0x6555410", VA = "0x186556010")]
	public bool EGMGAAFJGGH(ACAHCPOBLDI MONGIMOHLAO, [Out] T CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6D74C00", Offset = "0x6D74000", VA = "0x186D74C00")]
	[PNFIJEAKPLK("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool OIOLMHFDDNE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6D75260", Offset = "0x6D74660", VA = "0x186D75260")]
	public CHLDICFJDCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class OLGDLKLKBBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly Dictionary<object, float> JAIKDDBMDJG;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public float CELJKMFGLLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xABFF30", Offset = "0xABF330", VA = "0x180ABFF30")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x138FD00", Offset = "0x138F100", VA = "0x18138FD00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x8419100", Offset = "0x8418500", VA = "0x188419100")]
	public void JBMMNIEJAPK(float CBMEHPPMEEA, object MONGIMOHLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x8419170", Offset = "0x8418570", VA = "0x188419170")]
	public void LLNGNBGKNFB(object MONGIMOHLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x84190B0", Offset = "0x84184B0", VA = "0x1884190B0")]
	public void HBLMHKLDBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x8418F80", Offset = "0x8418380", VA = "0x188418F80")]
	private void FDPNOMBFGFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x84191E0", Offset = "0x84185E0", VA = "0x1884191E0")]
	public OLGDLKLKBBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface NHPEHMDHCFM
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event NBADGDDEIDG IEONFJOOMBB;
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class JIIIHNJCLKF : NHPEHMDHCFM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public readonly struct DKJJKBPFBFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public readonly float BCIEBGDAIDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public readonly float ILNENIFJGDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		internal readonly bool JDPJAANKGAC;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public float GDGDNNAMJCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x8416120", Offset = "0x8415520", VA = "0x188416120")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x84162A0", Offset = "0x84156A0", VA = "0x1884162A0")]
		public DKJJKBPFBFO(float FEMDGHMCLCC, float BBCNKKJCHEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8416130", Offset = "0x8415530", VA = "0x188416130", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class CKBHAJJBOHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public JIIIHNJCLKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public CKBHAJJBOHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8415A50", Offset = "0x8414E50", VA = "0x188415A50")]
		internal void ANOIAHJBBJB(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly int HLNAOJHAMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int ICADNJBIIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly NHPEHMDHCFM[] IDLKDMDGAAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly NBADGDDEIDG[] LHIJBEJLBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly DKJJKBPFBFO[] NEOAJIPKFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private DKJJKBPFBFO KEBOCGJCCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly MOMLBLNPBLC HKINCKAHIKL;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event NBADGDDEIDG IEONFJOOMBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8417450", Offset = "0x8416850", VA = "0x188417450", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8417A20", Offset = "0x8416E20", VA = "0x188417A20", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x8417AE0", Offset = "0x8416EE0", VA = "0x188417AE0")]
	public JIIIHNJCLKF(int HLNAOJHAMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x8417990", Offset = "0x8416D90", VA = "0x188417990")]
	public MOMLBLNPBLC NFPLECHIEIG(DKJJKBPFBFO CLIKJBPKKKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x8417510", Offset = "0x8416910", VA = "0x188417510")]
	public void GFBEHKMKIFN(NHPEHMDHCFM AIIMGDGDGFA, [Optional] DKJJKBPFBFO BENDPEAIJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x8417340", Offset = "0x8416740", VA = "0x188417340", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public delegate void NBADGDDEIDG(float JFGJNLEONKB);
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class CCEINPJPKAI
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	private class JOCJMKAMCDO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly NHPEHMDHCFM LCJCFBDNECB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly NBADGDDEIDG BFDLNHAHOHH;

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8417CC0", Offset = "0x84170C0", VA = "0x188417CC0")]
		public JOCJMKAMCDO(NHPEHMDHCFM LCJCFBDNECB, NBADGDDEIDG BFDLNHAHOHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8417C70", Offset = "0x8417070", VA = "0x188417C70", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x84158A0", Offset = "0x8414CA0", VA = "0x1884158A0")]
	internal static bool BEMDJAMNKNE(float HCFCOMCPJPA, float JOCIBENNGKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x8403EE0", Offset = "0x84032E0", VA = "0x188403EE0")]
	internal static float IGAHNMMNHFP(float HCFCOMCPJPA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x8415910", Offset = "0x8414D10", VA = "0x188415910")]
	public static IDisposable LHNLJLEGBCD(this NHPEHMDHCFM LCJCFBDNECB, NBADGDDEIDG BFDLNHAHOHH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class MOMLBLNPBLC : NHPEHMDHCFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private float JFGJNLEONKB;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public float DHFDOCCKCJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8418810", Offset = "0x8417C10", VA = "0x188418810")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event NBADGDDEIDG? IEONFJOOMBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8418770", Offset = "0x8417B70", VA = "0x188418770", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8418900", Offset = "0x8417D00", VA = "0x188418900", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public MOMLBLNPBLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface FOKANADBNBE<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EHEHGAJNKMA<T> OGMDNDFHLGF([Out] T CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HBLMHKLDBPD();
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class NMPJLIIGFPN<T> : FOKANADBNBE<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ConcurrentStack<T> CPDDHIHCPGN;

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x5824D00", Offset = "0x5824100", VA = "0x185824D00", Slot = "4")]
	public EHEHGAJNKMA<T> OGMDNDFHLGF([Out] T CBMEHPPMEEA)
	{
		return default(EHEHGAJNKMA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x5824CA0", Offset = "0x58240A0", VA = "0x185824CA0")]
	public void LLLHPAIEGMF(T OMMONOBJAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x4559B20", Offset = "0x4558F20", VA = "0x184559B20", Slot = "5")]
	public void HBLMHKLDBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "6")]
	protected virtual void DIKEAPPJOIO(T DDHFKCMJNIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x5824C20", Offset = "0x5824020", VA = "0x185824C20")]
	private T DIJAEKOIPED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x5824D90", Offset = "0x5824190", VA = "0x185824D90")]
	public NMPJLIIGFPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public readonly struct EHEHGAJNKMA<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly T OMMONOBJAMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly NMPJLIIGFPN<T> ONFDFPDBLBF;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0xBFDA60", Offset = "0xBFCE60", VA = "0x180BFDA60")]
	internal EHEHGAJNKMA(T CBMEHPPMEEA, NMPJLIIGFPN<T> ONFDFPDBLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x49D2ED0", Offset = "0x49D22D0", VA = "0x1849D2ED0", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class NACKAHHAJJD : NMPJLIIGFPN<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public static readonly NACKAHHAJJD NKAKNKMIPPI;

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x84189A0", Offset = "0x8417DA0", VA = "0x1884189A0")]
	public static EHEHGAJNKMA<StringBuilder> DIJAEKOIPED([Out] StringBuilder CBMEHPPMEEA)
	{
		return default(EHEHGAJNKMA<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x8418A40", Offset = "0x8417E40", VA = "0x188418A40", Slot = "6")]
	protected override void DIKEAPPJOIO(StringBuilder DDHFKCMJNIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x8418B00", Offset = "0x8417F00", VA = "0x188418B00")]
	public NACKAHHAJJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class NOGKOFMDHMC : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7C54520", Offset = "0x7C53920", VA = "0x187C54520")]
	public NOGKOFMDHMC(string AFDNIPHJHMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[DefaultMember("Item")]
public class CIPEHMFOHFD<TKey, TValue> : DPEFOMDEOHG<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IEFLGOHLOCK where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class KOHFGEFKGGL : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public CIPEHMFOHFD<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x1243D00", Offset = "0x1243100", VA = "0x181243D00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x4EF6830", Offset = "0x4EF5C30", VA = "0x184EF6830", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xA7AA30", Offset = "0xA79E30", VA = "0x180A7AA30")]
		[DebuggerHidden]
		public KOHFGEFKGGL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x4EF6900", Offset = "0x4EF5D00", VA = "0x184EF6900", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x546EB10", Offset = "0x546DF10", VA = "0x18546EB10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x546E670", Offset = "0x546DA70", VA = "0x18546E670")]
		private void DKMCMBPCGHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x546E4E0", Offset = "0x546D8E0", VA = "0x18546E4E0")]
		private void AIFLPGLABJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x546F470", Offset = "0x546E870", VA = "0x18546F470", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly DPEFOMDEOHG<TKey, TValue> BNHLFGLIKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly IDictionary<TKey, TValue> GLALLEAAFCF;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int JGJMKJIDNDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6D7EA80", Offset = "0x6D7DE80", VA = "0x186D7EA80", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool NBPHDBEEFKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public TValue FMHPKKMCCLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x6D7EB70", Offset = "0x6D7DF70", VA = "0x186D7EB70", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x6D7EDB0", Offset = "0x6D7E1B0", VA = "0x186D7EDB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public ICollection<TKey> EJHLAIBHCMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x6D7EBB0", Offset = "0x6D7DFB0", VA = "0x186D7EBB0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public ICollection<TValue> ALLICKBJCMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x6D7ECB0", Offset = "0x6D7E0B0", VA = "0x186D7ECB0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6D7E830", Offset = "0x6D7DC30", VA = "0x186D7E830")]
	public CIPEHMFOHFD(DPEFOMDEOHG<TKey, TValue> BNHLFGLIKKG, [Optional] IDictionary<TKey, TValue>? GLALLEAAFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6D7C270", Offset = "0x6D7B670", VA = "0x186D7C270", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x6D7D760", Offset = "0x6D7CB60", VA = "0x186D7D760")]
	public void LHDNJIMALKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6D7BDD0", Offset = "0x6D7B1D0", VA = "0x186D7BDD0", Slot = "9")]
	public void Add(TKey PEENICAIFOP, TValue CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6D7D8D0", Offset = "0x6D7CCD0", VA = "0x186D7D8D0")]
	public void OEKIBAAPGHA(TKey PEENICAIFOP, TValue CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6D7D5D0", Offset = "0x6D7C9D0", VA = "0x186D7D5D0")]
	public void KACEPLNDMPA(TKey PEENICAIFOP, TValue CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6D7D2D0", Offset = "0x6D7C6D0", VA = "0x186D7D2D0")]
	public void JAHHJDDGHBC(TKey PEENICAIFOP, TValue CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x6D7CC10", Offset = "0x6D7C010", VA = "0x186D7CC10")]
	public void DHHBPHMIJMF(TKey PEENICAIFOP, TValue CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x6D7DED0", Offset = "0x6D7D2D0", VA = "0x186D7DED0", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> GBDPBDHPLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6D7DF00", Offset = "0x6D7D300", VA = "0x186D7DF00", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6D7E400", Offset = "0x6D7D800", VA = "0x186D7E400", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6D7C370", Offset = "0x6D7B770", VA = "0x186D7C370", Slot = "8")]
	public bool ContainsKey(TKey PEENICAIFOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x6D7DB90", Offset = "0x6D7CF90", VA = "0x186D7DB90")]
	public bool ONMFNHLJIFD(TKey PEENICAIFOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x6D7D810", Offset = "0x6D7CC10", VA = "0x186D7D810")]
	public bool NACLCIGGKOC(TKey PEENICAIFOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x6D7DD10", Offset = "0x6D7D110", VA = "0x186D7DD10", Slot = "10")]
	public bool Remove(TKey PEENICAIFOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6D7E690", Offset = "0x6D7DA90", VA = "0x186D7E690", Slot = "11")]
	public bool TryGetValue(TKey PEENICAIFOP, [Out] TValue CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6D7C870", Offset = "0x6D7BC70", VA = "0x186D7C870", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] LMLCJEFLFMP, int KJLHONACGJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x540BAC0", Offset = "0x540AEC0", VA = "0x18540BAC0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6D7CD40", Offset = "0x6D7C140", VA = "0x186D7CD40", Slot = "19")]
	[IteratorStateMachine(typeof(CIPEHMFOHFD<, >.KOHFGEFKGGL))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6D7CAA0", Offset = "0x6D7BEA0", VA = "0x186D7CAA0", Slot = "21")]
	public bool DAEFOOLDPEA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x6D7CDD0", Offset = "0x6D7C1D0", VA = "0x186D7CDD0")]
	private TValue IGOJOIAKCIH(TKey PEENICAIFOP)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public interface LEBGMDLPJKE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	string FKFJBAIEDEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface IEFLGOHLOCK
{
	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DAEFOOLDPEA();
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface DPEFOMDEOHG<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IEFLGOHLOCK
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[DefaultMember("Item")]
public sealed class OGIIDNDKACI<TKey, TVal> : DPEFOMDEOHG<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IEFLGOHLOCK where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public delegate int DFAGMFKEGOG(TKey PEENICAIFOP, TVal CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public delegate void EGPEAHFPKDM(TKey PEENICAIFOP, TVal CBMEHPPMEEA, PAMCJPFBIFJ HBHJOPNAJMN);

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private class CGJCCBKGGFB
	{
		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public TKey BPKEMDDKCGD
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xE6E090", Offset = "0xE6D490", VA = "0x180E6E090")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public TVal JCMAOCOGHGO
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0xACA830", Offset = "0xAC9C30", VA = "0x180ACA830")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0xACB540", Offset = "0xACA940", VA = "0x180ACB540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public int GDGDNNAMJCE
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0xC1A7F0", Offset = "0xC19BF0", VA = "0x180C1A7F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x104AEA0", Offset = "0x104A2A0", VA = "0x18104AEA0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public DateTimeOffset PLJJAFJIPMK
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x13E0010", Offset = "0x13DF410", VA = "0x1813E0010")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x1518150", Offset = "0x1517550", VA = "0x181518150")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x6D71140", Offset = "0x6D70540", VA = "0x186D71140")]
		public CGJCCBKGGFB(TKey PEENICAIFOP, TVal DIMKOEFIKCH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class PFCHNBHPEEG : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public OGIIDNDKACI<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private LinkedList<CGJCCBKGGFB>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x1243D00", Offset = "0x1243100", VA = "0x181243D00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x5AC3BA0", Offset = "0x5AC2FA0", VA = "0x185AC3BA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xA7AA30", Offset = "0xA79E30", VA = "0x180A7AA30")]
		[DebuggerHidden]
		public PFCHNBHPEEG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x4539030", Offset = "0x4538430", VA = "0x184539030", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x5AC1560", Offset = "0x5AC0960", VA = "0x185AC1560", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x5AC1210", Offset = "0x5AC0610", VA = "0x185AC1210")]
		private void DKMCMBPCGHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x5AC3740", Offset = "0x5AC2B40", VA = "0x185AC3740", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public const int MJNBMCCLOIC = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly Dictionary<TKey, LinkedListNode<CGJCCBKGGFB>> JODIGDKOPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly LinkedList<CGJCCBKGGFB> BBPFJPPMJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly DFAGMFKEGOG? KAKBECDBAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly TimeSpan HLDEFGNJMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly EGPEAHFPKDM? KKEPNAPJBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly FNAODHMLAAP BHCAGONPHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private bool LKPDIOAEHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly List<TKey> BJCBJFMEKMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly List<TVal> MGLJFAOFNCI;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int DMBGGHINDFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xAD8D80", Offset = "0xAD8180", VA = "0x180AD8D80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	internal int CMBOKFPDPBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xE6C750", Offset = "0xE6BB50", VA = "0x180E6C750")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xF90330", Offset = "0xF8F730", VA = "0x180F90330")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int JGJMKJIDNDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x59B4FF0", Offset = "0x59B43F0", VA = "0x1859B4FF0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	internal int JJJCOINOKDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x49E55C0", Offset = "0x49E49C0", VA = "0x1849E55C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public ICollection<TVal> ALLICKBJCMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x59B50D0", Offset = "0x59B44D0", VA = "0x1859B50D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	ICollection<TKey> IDictionary<TKey, TVal>.FLENFOGIAEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x59B3C00", Offset = "0x59B3000", VA = "0x1859B3C00", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool NBPHDBEEFKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public TVal FMHPKKMCCLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x59B5040", Offset = "0x59B4440", VA = "0x1859B5040", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x59B5140", Offset = "0x59B4540", VA = "0x1859B5140", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x59AEA70", Offset = "0x59ADE70", VA = "0x1859AEA70")]
	private bool BGGACMDMGJB(int HLNAOJHAMJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x59B1280", Offset = "0x59B0680", VA = "0x1859B1280")]
	private void DEALFDMGHJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x59B41E0", Offset = "0x59B35E0", VA = "0x1859B41E0")]
	public OGIIDNDKACI(int HLNAOJHAMJG, [Optional] DFAGMFKEGOG? KAKBECDBAFK, [Optional] IEqualityComparer<TKey>? BCAEPAAMINN, [Optional] EGPEAHFPKDM? KKEPNAPJBDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x59B4190", Offset = "0x59B3590", VA = "0x1859B4190")]
	public OGIIDNDKACI(TimeSpan HLDEFGNJMGF, [Optional] IEqualityComparer<TKey>? BCAEPAAMINN, [Optional] EGPEAHFPKDM? KKEPNAPJBDG, [Optional] FNAODHMLAAP? BHCAGONPHBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x59B4140", Offset = "0x59B3540", VA = "0x1859B4140")]
	public OGIIDNDKACI(int HLNAOJHAMJG, TimeSpan HLDEFGNJMGF, [Optional] IEqualityComparer<TKey>? BCAEPAAMINN, [Optional] EGPEAHFPKDM? KKEPNAPJBDG, [Optional] FNAODHMLAAP? BHCAGONPHBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x59B4B40", Offset = "0x59B3F40", VA = "0x1859B4B40")]
	public OGIIDNDKACI(int HLNAOJHAMJG, DFAGMFKEGOG? KAKBECDBAFK, TimeSpan HLDEFGNJMGF, [Optional] IEqualityComparer<TKey>? BCAEPAAMINN, [Optional] EGPEAHFPKDM? KKEPNAPJBDG, [Optional] FNAODHMLAAP? BHCAGONPHBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x59B1220", Offset = "0x59B0620", VA = "0x1859B1220", Slot = "21")]
	public bool DAEFOOLDPEA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x59B1E50", Offset = "0x59B1250", VA = "0x1859B1E50", Slot = "22")]
	public bool GAAFMCDBFEB(int MPDDFCCPIOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x59AFCD0", Offset = "0x59AF0D0", VA = "0x1859AFCD0")]
	private bool CNLGHPECMBJ(int MPDDFCCPIOM, PAMCJPFBIFJ HBHJOPNAJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x59B27D0", Offset = "0x59B1BD0", VA = "0x1859B27D0")]
	public void LFFCNKDPJLH(TKey PEENICAIFOP, TVal CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x59AE210", Offset = "0x59AD610", VA = "0x1859AE210", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> GBDPBDHPLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x59AE3C0", Offset = "0x59AD7C0", VA = "0x1859AE3C0", Slot = "9")]
	public void Add(TKey PEENICAIFOP, TVal CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x59B07C0", Offset = "0x59AFBC0", VA = "0x1859B07C0", Slot = "8")]
	public bool ContainsKey(TKey PEENICAIFOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x59B38E0", Offset = "0x59B2CE0", VA = "0x1859B38E0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x59B3680", Offset = "0x59B2A80", VA = "0x1859B3680", Slot = "10")]
	public bool Remove(TKey PEENICAIFOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x59B39A0", Offset = "0x59B2DA0", VA = "0x1859B39A0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x59B2EB0", Offset = "0x59B22B0", VA = "0x1859B2EB0")]
	private bool LLNIMCDALCL(TKey PEENICAIFOP, [Out] TVal CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x59B1B50", Offset = "0x59B0F50", VA = "0x1859B1B50")]
	private TVal DIJAEKOIPED(TKey AEPHGJBOGJL)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x59B3C60", Offset = "0x59B3060", VA = "0x1859B3C60", Slot = "11")]
	public bool TryGetValue(TKey AEPHGJBOGJL, [Out] TVal CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x59B06D0", Offset = "0x59AFAD0", VA = "0x1859B06D0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x59B0EF0", Offset = "0x59B02F0", VA = "0x1859B0EF0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] LMLCJEFLFMP, int KJLHONACGJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x59B1690", Offset = "0x59B0A90", VA = "0x1859B1690")]
	private void DGIFGFHGNEN(TKey PEENICAIFOP, TVal DIMKOEFIKCH, PAMCJPFBIFJ HBHJOPNAJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x59B3370", Offset = "0x59B2770", VA = "0x1859B3370")]
	private bool PHAJGBNEFOA(CGJCCBKGGFB EHOKHCBAMJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x59AF350", Offset = "0x59AE750", VA = "0x1859AF350")]
	private void CCHEBNALBEK(LinkedListNode<CGJCCBKGGFB> IBKMFGCLDNM, TVal LEOKHPGPGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x59B2000", Offset = "0x59B1400", VA = "0x1859B2000")]
	private void JBMMNIEJAPK(TKey PEENICAIFOP, TVal CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x59AE6D0", Offset = "0x59ADAD0", VA = "0x1859AE6D0")]
	private void BFHGKMCHLNG(CGJCCBKGGFB EHOKHCBAMJM, TVal LEOKHPGPGKC, int OMIFOFFGBLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x59B1EE0", Offset = "0x59B12E0", VA = "0x1859B1EE0", Slot = "19")]
	[IteratorStateMachine(typeof(OGIIDNDKACI<, >.PFCHNBHPEEG))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x59B3C30", Offset = "0x59B3030", VA = "0x1859B3C30", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public enum PAMCJPFBIFJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	RemovedViaClear,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	Overwritten
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class DOCLDKFFIDA<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly TKey DAIOEHKOCMI;

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x45656F0", Offset = "0x4564AF0", VA = "0x1845656F0")]
	public DOCLDKFFIDA(TKey OPMHFIPMKCC, Exception DNFKLOFLLMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class FEPJJELGGIM : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7475220", Offset = "0x7474620", VA = "0x187475220")]
	public FEPJJELGGIM(string AFDNIPHJHMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class LMIGCBLKHKA<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class HOAIKFIAFCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public LMIGCBLKHKA<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public HOAIKFIAFCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x4FE9360", Offset = "0x4FE8760", VA = "0x184FE9360")]
		internal Task<TResource> EINIDPAFPOH(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct BHNKOMPGBCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public LMIGCBLKHKA<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x6553EE0", Offset = "0x65532E0", VA = "0x186553EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x6554B00", Offset = "0x6553F00", VA = "0x186554B00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct BEGKFCCGJEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x6471FB0", Offset = "0x64713B0", VA = "0x186471FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x6472630", Offset = "0x6471A30", VA = "0x186472630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly CBAIAMMJHKC<TId, Task<TResource>> NJKKLLAFJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> IGLMGALGGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? CDFAJGCONJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly Action<TResource>? ABIDFKCHPGO;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x5521100", Offset = "0x5520500", VA = "0x185521100")]
	public LMIGCBLKHKA(int CGIAPJBPOEG = 0, [Optional] IEqualityComparer<TId>? JLAJIGFPIEP, [Optional] Func<TId, CancellationToken, Task<TResource>>? KLDPJNKHOIA, [Optional] Action<TResource>? NHPOBHHHLEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x5520020", Offset = "0x551F420", VA = "0x185520020")]
	public GDOFCMCMKJK<Task<TResource>> ALLNKMDMIAE(TId CLNGGGMIBPI, [Optional] Func<TId, CancellationToken, Task<TResource>>? KLDPJNKHOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x5520530", Offset = "0x551F930", VA = "0x185520530")]
	private void JNGHMJGIFNP(Task<TResource> KDHFABGBLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x551FB80", Offset = "0x551EF80", VA = "0x18551FB80")]
	[AsyncStateMachine(typeof(LMIGCBLKHKA<, >.BHNKOMPGBCH))]
	private Task AIKLMHAJPPM(Task<TResource> KDHFABGBLNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5520500", Offset = "0x551F900", VA = "0x185520500")]
	public void BLEAMPGIOAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x5520DF0", Offset = "0x55201F0", VA = "0x185520DF0")]
	public CBAIAMMJHKC<TId, Task<TResource>>.GGIPFEGHCCF OJAPBOKMMBI()
	{
		return default(CBAIAMMJHKC<TId, Task<TResource>>.GGIPFEGHCCF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x5520F40", Offset = "0x5520340", VA = "0x185520F40", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x5520F40", Offset = "0x5520340", VA = "0x185520F40", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x5520CC0", Offset = "0x55200C0", VA = "0x185520CC0")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(LMIGCBLKHKA<, >.BEGKFCCGJEF))]
	internal static Task KNLPIIKHIAO(Task<TResource> KDHFABGBLNO, CancellationTokenSource EBACOGHDBNL, Dictionary<Task<TResource>, CancellationTokenSource> PILMDHIDENP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class CBAIAMMJHKC<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class NEJBKFAFEPE : IEquatable<NEJBKFAFEPE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public readonly TValue JCMAOCOGHGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int APFGJFEMCJC;

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xFD7C70", Offset = "0xFD7070", VA = "0x180FD7C70")]
		public NEJBKFAFEPE(TValue CBMEHPPMEEA, int EMPMJHBMDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x57F50A0", Offset = "0x57F44A0", VA = "0x1857F50A0", Slot = "4")]
		public bool Equals(NEJBKFAFEPE? LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x57F5010", Offset = "0x57F4410", VA = "0x1857F5010", Slot = "0")]
		public override bool Equals(object? DEJGDIIDCDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x57F5220", Offset = "0x57F4620", VA = "0x1857F5220", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public struct GGIPFEGHCCF : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private Dictionary<TKey, NEJBKFAFEPE>.Enumerator MPFIBEIBONN;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x4F51F20", Offset = "0x4F51320", VA = "0x184F51F20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public (TKey Key, TValue Value, int RefCount) FEIHGLOFMJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x4F52350", Offset = "0x4F51750", VA = "0x184F52350", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x4F52110", Offset = "0x4F51510", VA = "0x184F52110")]
		public GGIPFEGHCCF(CBAIAMMJHKC<TKey, TValue> JAIKDDBMDJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x4F51B80", Offset = "0x4F50F80", VA = "0x184F51B80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x4F51BC0", Offset = "0x4F50FC0", VA = "0x184F51BC0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x4F51C80", Offset = "0x4F51080", VA = "0x184F51C80", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class DNLPFGKMDJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public CBAIAMMJHKC<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public NEJBKFAFEPE refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public DNLPFGKMDJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x4564B60", Offset = "0x4563F60", VA = "0x184564B60")]
		internal void EINIDPAFPOH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly Dictionary<TKey, NEJBKFAFEPE> AAPJNEAPGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private readonly Func<TKey, TValue>? BBOMLNCNADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly Action<TValue>? HECMICNODKK;

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x6C92B50", Offset = "0x6C91F50", VA = "0x186C92B50")]
	public CBAIAMMJHKC(int CGIAPJBPOEG = 0, [Optional] IEqualityComparer<TKey>? BCAEPAAMINN, [Optional] Func<TKey, TValue>? FFJCNOLPNHJ, [Optional] Action<TValue>? BPHLKHIMDAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x6C91850", Offset = "0x6C90C50", VA = "0x186C91850")]
	public GDOFCMCMKJK<TValue> ALLNKMDMIAE(TKey PEENICAIFOP, [Optional] Func<TKey, TValue>? NMGFDKBMLEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x6C926E0", Offset = "0x6C91AE0", VA = "0x186C926E0")]
	private void LLLHPAIEGMF(TKey PEENICAIFOP, NEJBKFAFEPE EGBOEIBPCHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x6C92430", Offset = "0x6C91830", VA = "0x186C92430")]
	public void BLEAMPGIOAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x6C92910", Offset = "0x6C91D10", VA = "0x186C92910")]
	public GGIPFEGHCCF OJAPBOKMMBI()
	{
		return default(GGIPFEGHCCF);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x6C92990", Offset = "0x6C91D90", VA = "0x186C92990", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x6C92990", Offset = "0x6C91D90", VA = "0x186C92990", Slot = "5")]
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
