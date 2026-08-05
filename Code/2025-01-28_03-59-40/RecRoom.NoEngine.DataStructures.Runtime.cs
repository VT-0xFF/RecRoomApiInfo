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
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
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
		[Cpp2IlInjected.Address(RVA = "0x732CA50", Offset = "0x732BC50", VA = "0x18732CA50")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x91E490", Offset = "0x91D690", VA = "0x18091E490")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x91E4D0", Offset = "0x91D6D0", VA = "0x18091E4D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class CCLMDLJCION
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	protected CCLMDLJCION()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class JIMLDDCMGFH<T> : CCLMDLJCION
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct LGIAMGDKAKG
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum AHCNEANNDJL
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
		public AHCNEANNDJL MDOOANEGCAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T KOMGLJOLBFC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int DMKBNDHGGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool IAKECNEIBMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool DNDODCCPIAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? KAMFMIPONAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<LGIAMGDKAKG>? LJPOGABBALF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool GOJHNPNBKHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4830550", Offset = "0x482F750", VA = "0x184830550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x48305B0", Offset = "0x482F7B0", VA = "0x1848305B0")]
	protected JIMLDDCMGFH(bool DNDODCCPIAK, bool IAKECNEIBMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4830390", Offset = "0x482F590", VA = "0x184830390")]
	protected bool MAMCCDNFIHN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4830430", Offset = "0x482F630", VA = "0x184830430")]
	protected void MCJIHEBPALP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4830120", Offset = "0x482F320", VA = "0x184830120")]
	protected void IIOPBJEPLIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3411810", Offset = "0x3410A10", VA = "0x183411810")]
	private static void FGJHEOMDMCC<U>(List<U>? AFNGOKKOBOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x482FB90", Offset = "0x482ED90", VA = "0x18482FB90", Slot = "4")]
	public void CKLHJOINNOK(T KOMGLJOLBFC, bool LMMAJJOIAPI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x482FF50", Offset = "0x482F150", VA = "0x18482FF50", Slot = "5")]
	public void GMODDBABBFK(T KOMGLJOLBFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x482FDA0", Offset = "0x482EFA0", VA = "0x18482FDA0")]
	public void DBGBEIOBMKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class AEJLNDNFINA : JIMLDDCMGFH<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7329C40", Offset = "0x7328E40", VA = "0x187329C40")]
	public AEJLNDNFINA(bool DNDODCCPIAK = false, bool IAKECNEIBMF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x73299E0", Offset = "0x7328BE0", VA = "0x1873299E0")]
	public void HJOIGAOEAFJ()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7329BE0", Offset = "0x7328DE0", VA = "0x187329BE0")]
	public static AEJLNDNFINA OBLDLBNGOBN(AEJLNDNFINA IKEFMBEAFMP, Action KOMGLJOLBFC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7329980", Offset = "0x7328B80", VA = "0x187329980")]
	public static AEJLNDNFINA GIDENFKBALE(AEJLNDNFINA IKEFMBEAFMP, Action KOMGLJOLBFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface BBGCNDIBJMA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CKLHJOINNOK(Action<T> KOMGLJOLBFC, bool LMMAJJOIAPI = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GMODDBABBFK(Action<T> KOMGLJOLBFC);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class DBOBDIFJBBN<T> : JIMLDDCMGFH<Action<T>>, BBGCNDIBJMA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3EFBD20", Offset = "0x3EFAF20", VA = "0x183EFBD20")]
	public DBOBDIFJBBN(bool DNDODCCPIAK = false, bool IAKECNEIBMF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6050210", Offset = "0x604F410", VA = "0x186050210")]
	public void HJOIGAOEAFJ(T EBJDGDIMGBD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x42ED470", Offset = "0x42EC670", VA = "0x1842ED470")]
	public static DBOBDIFJBBN<T> OBLDLBNGOBN(DBOBDIFJBBN<T> IKEFMBEAFMP, Action<T> KOMGLJOLBFC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x42ECC60", Offset = "0x42EBE60", VA = "0x1842ECC60")]
	public static DBOBDIFJBBN<T> GIDENFKBALE(DBOBDIFJBBN<T> IKEFMBEAFMP, Action<T> KOMGLJOLBFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CDDBFCCOBCH<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CKLHJOINNOK(Action<T, U> KOMGLJOLBFC, bool LMMAJJOIAPI = false);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GMODDBABBFK(Action<T, U> KOMGLJOLBFC);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class NJGCEGGLBKK<T, U> : JIMLDDCMGFH<Action<T, U>>, CDDBFCCOBCH<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3EFBD20", Offset = "0x3EFAF20", VA = "0x183EFBD20")]
	public NJGCEGGLBKK(bool DNDODCCPIAK = false, bool IAKECNEIBMF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4C84250", Offset = "0x4C83450", VA = "0x184C84250")]
	public void HJOIGAOEAFJ(T EBJDGDIMGBD, U LIGKMJNIJFJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x42ED470", Offset = "0x42EC670", VA = "0x1842ED470")]
	public static NJGCEGGLBKK<T, U> OBLDLBNGOBN(NJGCEGGLBKK<T, U> IKEFMBEAFMP, Action<T, U> KOMGLJOLBFC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x42ECC60", Offset = "0x42EBE60", VA = "0x1842ECC60")]
	public static NJGCEGGLBKK<T, U> GIDENFKBALE(NJGCEGGLBKK<T, U> IKEFMBEAFMP, Action<T, U> KOMGLJOLBFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class COIMHDMDOOB<T, U, V> : JIMLDDCMGFH<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3EFBD20", Offset = "0x3EFAF20", VA = "0x183EFBD20")]
	public COIMHDMDOOB(bool DNDODCCPIAK = false, bool IAKECNEIBMF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x588C6A0", Offset = "0x588B8A0", VA = "0x18588C6A0")]
	public void HJOIGAOEAFJ(T EBJDGDIMGBD, U LIGKMJNIJFJ, V PBNOOPEKDOL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x42ED470", Offset = "0x42EC670", VA = "0x1842ED470")]
	public static COIMHDMDOOB<T, U, V> OBLDLBNGOBN(COIMHDMDOOB<T, U, V> IKEFMBEAFMP, Action<T, U, V> KOMGLJOLBFC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x42ECC60", Offset = "0x42EBE60", VA = "0x1842ECC60")]
	public static COIMHDMDOOB<T, U, V> GIDENFKBALE(COIMHDMDOOB<T, U, V> IKEFMBEAFMP, Action<T, U, V> KOMGLJOLBFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface KAFDOBJMDOJ<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class JEECALADHOK<T, U, V, W> : JIMLDDCMGFH<Action<T, U, V, W>>, KAFDOBJMDOJ<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3EFBD20", Offset = "0x3EFAF20", VA = "0x183EFBD20")]
	public JEECALADHOK(bool DNDODCCPIAK = false, bool IAKECNEIBMF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x481E680", Offset = "0x481D880", VA = "0x18481E680")]
	public void HJOIGAOEAFJ(T EBJDGDIMGBD, U LIGKMJNIJFJ, V PBNOOPEKDOL, W JIBFOCJJOLJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x42ED470", Offset = "0x42EC670", VA = "0x1842ED470")]
	public static JEECALADHOK<T, U, V, W> OBLDLBNGOBN(JEECALADHOK<T, U, V, W> IKEFMBEAFMP, Action<T, U, V, W> KOMGLJOLBFC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x42ECC60", Offset = "0x42EBE60", VA = "0x1842ECC60")]
	public static JEECALADHOK<T, U, V, W> GIDENFKBALE(JEECALADHOK<T, U, V, W> IKEFMBEAFMP, Action<T, U, V, W> KOMGLJOLBFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class FHPBDPKAKDM<T, U, V, W, X> : JIMLDDCMGFH<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3EFBD20", Offset = "0x3EFAF20", VA = "0x183EFBD20")]
	public FHPBDPKAKDM(bool DNDODCCPIAK = false, bool IAKECNEIBMF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x42ED100", Offset = "0x42EC300", VA = "0x1842ED100")]
	public void HJOIGAOEAFJ(T EBJDGDIMGBD, U LIGKMJNIJFJ, V PBNOOPEKDOL, W JIBFOCJJOLJ, X KIEMJAMMNPB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x42ED470", Offset = "0x42EC670", VA = "0x1842ED470")]
	public static FHPBDPKAKDM<T, U, V, W, X> OBLDLBNGOBN(FHPBDPKAKDM<T, U, V, W, X> IKEFMBEAFMP, Action<T, U, V, W, X> KOMGLJOLBFC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x42ECC60", Offset = "0x42EBE60", VA = "0x1842ECC60")]
	public static FHPBDPKAKDM<T, U, V, W, X> GIDENFKBALE(FHPBDPKAKDM<T, U, V, W, X> IKEFMBEAFMP, Action<T, U, V, W, X> KOMGLJOLBFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class BMGNLBHFABJ<T, U, V, W, X, Y> : JIMLDDCMGFH<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3EFBD20", Offset = "0x3EFAF20", VA = "0x183EFBD20")]
	public BMGNLBHFABJ(bool DNDODCCPIAK = false, bool IAKECNEIBMF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x56505F0", Offset = "0x564F7F0", VA = "0x1856505F0")]
	public void HJOIGAOEAFJ(T EBJDGDIMGBD, U LIGKMJNIJFJ, V PBNOOPEKDOL, W JIBFOCJJOLJ, X KIEMJAMMNPB, Y IIOFLMMOEPL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x42ED470", Offset = "0x42EC670", VA = "0x1842ED470")]
	public static BMGNLBHFABJ<T, U, V, W, X, Y> OBLDLBNGOBN(BMGNLBHFABJ<T, U, V, W, X, Y> IKEFMBEAFMP, Action<T, U, V, W, X, Y> KOMGLJOLBFC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x42ECC60", Offset = "0x42EBE60", VA = "0x1842ECC60")]
	public static BMGNLBHFABJ<T, U, V, W, X, Y> GIDENFKBALE(BMGNLBHFABJ<T, U, V, W, X, Y> IKEFMBEAFMP, Action<T, U, V, W, X, Y> KOMGLJOLBFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class DLAPJCHLIHH<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly IGGALDAFIPN<TKey, TVal> BGCKFAMIFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> HFHJHEMDIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly IGGALDAFIPN<TKey, TVal>.HPIMKMACDHN? OLNLKAIIKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int LJJAAODLGIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly IGGALDAFIPN<TKey, TVal>.GAKOCBHOANI? ACPCIMKACJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int LIGIANBLOOC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int LAHCOEINPFA
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x607CD40", Offset = "0x607BF40", VA = "0x18607CD40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int KCBJAHDNLBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8F5470", Offset = "0x8F4670", VA = "0x1808F5470")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x607DAD0", Offset = "0x607CCD0", VA = "0x18607DAD0")]
	public DLAPJCHLIHH(int LJJAAODLGIC, [Optional] IGGALDAFIPN<TKey, TVal>.GAKOCBHOANI? ACPCIMKACJD, [Optional] IEqualityComparer<TKey>? KJEPNKNBGIG, [Optional] IGGALDAFIPN<TKey, TVal>.HPIMKMACDHN? OLNLKAIIKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x607D8A0", Offset = "0x607CAA0", VA = "0x18607D8A0")]
	public void PCLGKDGMHBM(TKey OFPBICPHALF, TVal OMEFCJCOLII, bool ODEIIFMIDPN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x607C9C0", Offset = "0x607BBC0", VA = "0x18607C9C0")]
	public bool EKBCHDHEIOB(TKey OFPBICPHALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x607CB20", Offset = "0x607BD20", VA = "0x18607CB20")]
	public bool EKHOHBPCPIG(TKey MJJCFLDMEMJ, [Out] TVal OMEFCJCOLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x607CD90", Offset = "0x607BF90", VA = "0x18607CD90")]
	private void MBMKBENEKDF(TKey OFPBICPHALF, TVal OMEFCJCOLII, int AFLMMFDMNOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x607D5B0", Offset = "0x607C7B0", VA = "0x18607D5B0")]
	public bool OAAEBFBMEKL(TKey OFPBICPHALF, TVal OMEFCJCOLII, bool ODEIIFMIDPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x607C7E0", Offset = "0x607B9E0", VA = "0x18607C7E0")]
	public void DBGBEIOBMKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x607D050", Offset = "0x607C250", VA = "0x18607D050")]
	private void MPFOINGBBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x607D760", Offset = "0x607C960", VA = "0x18607D760")]
	private bool OKDKPMHIFHP(TKey OFPBICPHALF, BJLAPHKMFDP GLMJIDMBMEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x607CC20", Offset = "0x607BE20", VA = "0x18607CC20")]
	private void JFJCGFLIEBI(TKey OFPBICPHALF, TVal OMEFCJCOLII, BJLAPHKMFDP GLMJIDMBMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x607C890", Offset = "0x607BA90", VA = "0x18607C890")]
	private void EFHJNONNJLP(TKey OFPBICPHALF, TVal IAPIOFHOONE, BJLAPHKMFDP GLMJIDMBMEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class IJILLPOEIIE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action MBHIAFGOHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool GFLDMJPDEED;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x902B20", Offset = "0x901D20", VA = "0x180902B20")]
	public IJILLPOEIIE(Action CNNPIFMDOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x732AF80", Offset = "0x732A180", VA = "0x18732AF80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x304C770", Offset = "0x304B970", VA = "0x18304C770")]
	public static HLPAFEMDGAE<T> LHPCDDMHIBB<T>(T OMEFCJCOLII, Action CNNPIFMDOGK) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class HLPAFEMDGAE<T> : IJILLPOEIIE where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T ELOFPHHKCIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8F54C0", Offset = "0x8F46C0", VA = "0x1808F54C0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x44EA5E0", Offset = "0x44E97E0", VA = "0x1844EA5E0")]
	public HLPAFEMDGAE(T OMEFCJCOLII, Action CNNPIFMDOGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class HCDHAEHNIIJ<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly ELJGIJHOGNM<T>? IHGDKGOPGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> MKNLCGFBOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool GFLDMJPDEED;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly HCDHAEHNIIJ<T> GNFCEACADKD;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> DFMGIPLJKOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x44BF600", Offset = "0x44BE800", VA = "0x1844BF600")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long JBMLOIOBDME
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x44BF1E0", Offset = "0x44BE3E0", VA = "0x1844BF1E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool PHKHHDPEMAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x44BF540", Offset = "0x44BE740", VA = "0x1844BF540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x44BF900", Offset = "0x44BEB00", VA = "0x1844BF900")]
	public HCDHAEHNIIJ(ELJGIJHOGNM<T> BDPJAMPOMID, ELJGIJHOGNM<T> HMMLFJDAAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x44BFDA0", Offset = "0x44BEFA0", VA = "0x1844BFDA0")]
	public HCDHAEHNIIJ(ELJGIJHOGNM<T> BDPJAMPOMID, int EINJGMILBKO, ELJGIJHOGNM<T> HMMLFJDAAIK, int OIOHBDOPJJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x44BF850", Offset = "0x44BEA50", VA = "0x1844BF850")]
	private HCDHAEHNIIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x44BEFF0", Offset = "0x44BE1F0", VA = "0x1844BEFF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x44BF130", Offset = "0x44BE330", VA = "0x1844BF130")]
	public T[] ECDJLKNEFPJ()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x44BF360", Offset = "0x44BE560", VA = "0x1844BF360")]
	public static ReadOnlySequence<T> KEDBNOKLEHE(HCDHAEHNIIJ<T>? EKBKLDIKAHB)
	{
		return default(ReadOnlySequence<T>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct ADFPDBNKNIO : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct DDNPPEFDJMK : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0")]
		public static DDNPPEFDJMK PAJOIGLPBMN()
		{
			return default(DDNPPEFDJMK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7329940", Offset = "0x7328B40", VA = "0x187329940")]
	public static string POECFFMKGKE(Type MDOOANEGCAH, [Optional] string? LMKDGEKNEAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x39E8DB0", Offset = "0x39E7FB0", VA = "0x1839E8DB0")]
	public static string? POECFFMKGKE<T>([Optional] string? LMKDGEKNEAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x39E8D30", Offset = "0x39E7F30", VA = "0x1839E8D30")]
	public static string? NNNKIHKELLD<T>([Optional] string? EDNJDAPDOBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0")]
	public static ADFPDBNKNIO PLDGGNMENDN(string LMKDGEKNEAK, string? EDNJDAPDOBH)
	{
		return default(ADFPDBNKNIO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct JHEAKECEBKA
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool INMJIIJNOJF(string FAHJFOPCBGC, JHEAKECEBKA GOLDEDOJEBM);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class MOLGMEKPGGJ<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public MOLGMEKPGGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4C24970", Offset = "0x4C23B70", VA = "0x184C24970")]
		internal void NODFELDCFGB(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int NEBBNLAKKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public string BFNGJIEPKGK;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x732B9C0", Offset = "0x732ABC0", VA = "0x18732B9C0")]
	public static Dictionary<string, JHEAKECEBKA> JEDCCNOADOD(Type AEJFINIEEFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x32F2E20", Offset = "0x32F2020", VA = "0x1832F2E20")]
	public static Dictionary<string, JHEAKECEBKA> JEDCCNOADOD<T>(Type AEJFINIEEFK, IReadOnlyDictionary<T, string> JGFPELNHBCH) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x32F26A0", Offset = "0x32F18A0", VA = "0x1832F26A0")]
	public static Dictionary<string, JHEAKECEBKA> CNKCJJLGPEO<T>(List<T> FMLJEGAJFLP) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x732BEB0", Offset = "0x732B0B0", VA = "0x18732BEB0")]
	public static Dictionary<string, JHEAKECEBKA> MDBIELJKJEB(Type AEJFINIEEFK, INMJIIJNOJF GAGKBKHPMIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x732BCF0", Offset = "0x732AEF0", VA = "0x18732BCF0")]
	public static Dictionary<int, string> LDCMAJBLJIP(Dictionary<string, JHEAKECEBKA> PDEGCFKDOBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class ENAONJKJOID : MNCKOMAJMKB
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static bool BLPCNLMKPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly string? JEEBKPBBIJB;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual MNCKOMAJMKB? DCBIEDBIADO
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x732A930", Offset = "0x7329B30", VA = "0x18732A930")]
	protected ENAONJKJOID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string OEJBHPKDIJD();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x732A570", Offset = "0x7329770", VA = "0x18732A570", Slot = "8")]
	public virtual string IAHFDJNCDGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x732A690", Offset = "0x7329890", VA = "0x18732A690", Slot = "9")]
	public void MPGFEHIKAJN(StringBuilder DLKDGDBBOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x732A290", Offset = "0x7329490", VA = "0x18732A290", Slot = "10")]
	public void FLHNIDLNEDK(StringBuilder DLKDGDBBOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x732A2F0", Offset = "0x73294F0", VA = "0x18732A2F0", Slot = "11")]
	public void GGOHNAMFEGP(StringBuilder DLKDGDBBOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x732A410", Offset = "0x7329610", VA = "0x18732A410", Slot = "12")]
	public void HNJLGEODAPP(StringBuilder DLKDGDBBOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x732A5F0", Offset = "0x73297F0", VA = "0x18732A5F0")]
	public static void IFEBDFIEEGC(StringBuilder DLKDGDBBOLD, string KJEMHKAMFCH, string PGIBGCAINKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x642ABC0", Offset = "0x6429DC0", VA = "0x18642ABC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class IDFLOHHBPGN : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x732AC70", Offset = "0x7329E70", VA = "0x18732AC70")]
	public IDFLOHHBPGN(string CBCJFCINKPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class JPEHIJHGDOM<TErr> : IDFLOHHBPGN where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly TErr CFNJEMCIMDK;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x484C600", Offset = "0x484B800", VA = "0x18484C600")]
	private JPEHIJHGDOM([In] TErr FHHFOPCLAFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x484C530", Offset = "0x484B730", VA = "0x18484C530")]
	public static JPEHIJHGDOM<TErr> PAJOIGLPBMN([In] TErr FHHFOPCLAFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class LMHJOAONKKL : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashAlgorithm MHPGKMDHDMB;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool MCIBMHMMKHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool NCCNFNMAKCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool POGGHADGCPD
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long JBMLOIOBDME
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x732C750", Offset = "0x732B950", VA = "0x18732C750", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long FJKLEJNIMLK
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x732C7C0", Offset = "0x732B9C0", VA = "0x18732C7C0", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x732C830", Offset = "0x732BA30", VA = "0x18732C830", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x732C6E0", Offset = "0x732B8E0", VA = "0x18732C6E0")]
	public LMHJOAONKKL(HashAlgorithm MHPGKMDHDMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x732C500", Offset = "0x732B700", VA = "0x18732C500", Slot = "35")]
	public override int Read(byte[] HJDGEKDMIGG, int KLICPJBJAIA, int EOKNBJLIKEG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x732C6B0", Offset = "0x732B8B0", VA = "0x18732C6B0", Slot = "38")]
	public override void Write(byte[] HJDGEKDMIGG, int KLICPJBJAIA, int EOKNBJLIKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x732C5A0", Offset = "0x732B7A0", VA = "0x18732C5A0", Slot = "33")]
	public override long Seek(long KLICPJBJAIA, SeekOrigin KGJLHKKBBFC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x732C630", Offset = "0x732B830", VA = "0x18732C630", Slot = "34")]
	public override void SetLength(long OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x732C420", Offset = "0x732B620", VA = "0x18732C420")]
	public byte[] LJMEKHKIHKF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface MNCKOMAJMKB
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string IAHFDJNCDGL();

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string OEJBHPKDIJD();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface OIKOPNNNFIE<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions ELOFPHHKCIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface KKHOMELMFJI
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string HBKIMBMLNJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class ELJGIJHOGNM<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static ELJGIJHOGNM<T>? GOLDBHLKGLG;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static object JOAIAAJNBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private IMemoryOwner<T>? BLJPDDNPPCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private bool GFLDMJPDEED;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool HOKILEEDJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xC0B620", Offset = "0xC0A820", VA = "0x180C0B620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3F217F0", Offset = "0x3F209F0", VA = "0x183F217F0")]
	private static ELJGIJHOGNM<T> MLEEMMDPEKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3F20520", Offset = "0x3F1F720", VA = "0x183F20520")]
	private static void BNGNCCJINIB(ELJGIJHOGNM<T> IOJJDKDBPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3F22090", Offset = "0x3F21290", VA = "0x183F22090")]
	private ELJGIJHOGNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3F21620", Offset = "0x3F20820", VA = "0x183F21620")]
	public static ELJGIJHOGNM<T> LHPCDDMHIBB(ReadOnlyMemory<T> JNPGFBGJIJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3F21410", Offset = "0x3F20610", VA = "0x183F21410")]
	public static ELJGIJHOGNM<T> LHPCDDMHIBB(IMemoryOwner<T> LNDBFNOFBDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3F21CB0", Offset = "0x3F20EB0", VA = "0x183F21CB0")]
	public static void OJOGMCAIBCM(ELJGIJHOGNM<T> BDPJAMPOMID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3F20AE0", Offset = "0x3F1FCE0", VA = "0x183F20AE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3F20FE0", Offset = "0x3F201E0", VA = "0x183F20FE0")]
	public ELJGIJHOGNM<T> ELIHHEGFEMB(IMemoryOwner<T> LNDBFNOFBDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3F20320", Offset = "0x3F1F520", VA = "0x183F20320")]
	private void BJFHEHLDIKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3F210F0", Offset = "0x3F202F0", VA = "0x183F210F0")]
	private ELJGIJHOGNM<T> HMELCKGDEBF(ELJGIJHOGNM<T> IOJJDKDBPKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class JHJMPIJCHNE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x732C270", Offset = "0x732B470", VA = "0x18732C270")]
	public JHJMPIJCHNE(string CBCJFCINKPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class JNPCIDLLEFA<TOk> : JHJMPIJCHNE where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly TOk DANFDJPOOPF;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4848B20", Offset = "0x4847D20", VA = "0x184848B20")]
	private JNPCIDLLEFA([In] TOk GDHAIBMOKDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x44DFF90", Offset = "0x44DF190", VA = "0x1844DFF90")]
	public static JNPCIDLLEFA<TOk> PAJOIGLPBMN([In] TOk GDHAIBMOKDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct EBOICGKKPAM<TOk, TErr> : IEquatable<EBOICGKKPAM<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly EqualityComparer<TErr> DOMLMIGJBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal readonly TErr CFNJEMCIMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal readonly TOk DANFDJPOOPF;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool EEJFIOKLOKM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3EDC670", Offset = "0x3EDB870", VA = "0x183EDC670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool EHMFONCFLND
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3ED8200", Offset = "0x3ED7400", VA = "0x183ED8200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3EDFEB0", Offset = "0x3EDF0B0", VA = "0x183EDFEB0")]
	internal EBOICGKKPAM([In] TErr FHHFOPCLAFM, [In] TOk GDHAIBMOKDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3EDD260", Offset = "0x3EDC460", VA = "0x183EDD260")]
	public static EBOICGKKPAM<TOk, TErr> KAHKPGGGKDF([In] TErr FHHFOPCLAFM)
	{
		return default(EBOICGKKPAM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3ED89A0", Offset = "0x3ED7BA0", VA = "0x183ED89A0")]
	public static EBOICGKKPAM<TOk, TErr> AOLBAKPBOJP([In] TOk GDHAIBMOKDG)
	{
		return default(EBOICGKKPAM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x32C26D0", Offset = "0x32C18D0", VA = "0x1832C26D0")]
	public EBOICGKKPAM<TOk?, UErr?> CBEGJHBPPCG<UErr>()
	{
		return default(EBOICGKKPAM<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x32C4BA0", Offset = "0x32C3DA0", VA = "0x1832C4BA0")]
	public EBOICGKKPAM<UOk?, TErr?> LJAHKLECENL<UOk>()
	{
		return default(EBOICGKKPAM<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x32C3710", Offset = "0x32C2910", VA = "0x1832C3710")]
	public EBOICGKKPAM<UOk?, TErr?> EKEMANMBGHP<UOk>()
	{
		return default(EBOICGKKPAM<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x32C4060", Offset = "0x32C3260", VA = "0x1832C4060")]
	public EBOICGKKPAM<TOk?, UErr?> LHFJNKDJPOP<UErr>()
	{
		return default(EBOICGKKPAM<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3EDC340", Offset = "0x3EDB540", VA = "0x183EDC340")]
	public EBOICGKKPAM<HEGEDEFNLEJ, TErr> HHNEEODHGCI()
	{
		return default(EBOICGKKPAM<HEGEDEFNLEJ, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3ED9170", Offset = "0x3ED8370", VA = "0x183ED9170")]
	public static bool CCHBIHOFELC([In] EBOICGKKPAM<TOk, TErr> LFOFDHEGDLC, [In] EBOICGKKPAM<TOk, TErr> KMPLOMOLJCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3EDA1F0", Offset = "0x3ED93F0", VA = "0x183EDA1F0", Slot = "4")]
	public bool Equals(EBOICGKKPAM<TOk, TErr> JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3EDA2C0", Offset = "0x3ED94C0", VA = "0x183EDA2C0", Slot = "0")]
	public override bool Equals(object JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3EDB2C0", Offset = "0x3EDA4C0", VA = "0x183EDB2C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3EDDF00", Offset = "0x3EDD100", VA = "0x183EDDF00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class EBPIJFDDKGB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct CDNDOHOMBFH<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Task<EBOICGKKPAM<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskAwaiter<EBOICGKKPAM<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x56E8AA0", Offset = "0x56E7CA0", VA = "0x1856E8AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x56E9400", Offset = "0x56E8600", VA = "0x1856E9400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x31106E0", Offset = "0x310F8E0", VA = "0x1831106E0")]
	public static EBOICGKKPAM<TOk?, TErr?> DANFDJPOOPF<TOk, TErr>([In] this EBOICGKKPAM<TOk, TErr> MLNFAKCEGNM, [In] TOk GDHAIBMOKDG)
	{
		return default(EBOICGKKPAM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x31109F0", Offset = "0x310FBF0", VA = "0x1831109F0")]
	public static EBOICGKKPAM<HEGEDEFNLEJ, TErr?> DANFDJPOOPF<TErr>([In] this EBOICGKKPAM<HEGEDEFNLEJ, TErr> MLNFAKCEGNM)
	{
		return default(EBOICGKKPAM<HEGEDEFNLEJ, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x31106E0", Offset = "0x310F8E0", VA = "0x1831106E0")]
	public static EBOICGKKPAM<TOk?, TErr?> CFNJEMCIMDK<TOk, TErr>([In] this EBOICGKKPAM<TOk, TErr> MLNFAKCEGNM, [In] TErr FHHFOPCLAFM)
	{
		return default(EBOICGKKPAM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3111AF0", Offset = "0x3110CF0", VA = "0x183111AF0")]
	public static TOk? HCBLLDNPDFO<TOk, TErr>([In] this EBOICGKKPAM<TOk, TErr> MLNFAKCEGNM)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3111820", Offset = "0x3110A20", VA = "0x183111820")]
	[AsyncStateMachine(typeof(CDNDOHOMBFH<, >))]
	public static Task<TOk?>? HBCEFBKGNAN<TOk, TErr>(this Task<EBOICGKKPAM<TOk, TErr>> MLNFAKCEGNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3110A90", Offset = "0x310FC90", VA = "0x183110A90")]
	public static TErr? DCDHPCKCGMM<TErr, TOk>([In] this EBOICGKKPAM<TOk, TErr> MLNFAKCEGNM)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x31128A0", Offset = "0x3111AA0", VA = "0x1831128A0")]
	public static bool PBLLCKFFBMD<TOk, TErr, UErr, UOk>([In] this EBOICGKKPAM<TOk, TErr> MLNFAKCEGNM, [Out] EBOICGKKPAM<UOk, UErr> BHGCDCOOCBH) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3110EB0", Offset = "0x31100B0", VA = "0x183110EB0")]
	public static bool DIBNEMPPNJA<TOk, TErr>([In] this EBOICGKKPAM<TOk, TErr> MLNFAKCEGNM, [Out] TOk GDHAIBMOKDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x31108B0", Offset = "0x310FAB0", VA = "0x1831108B0")]
	public static bool CPPILDNJJLM<TOk, TErr>([In] this EBOICGKKPAM<TOk, TErr> MLNFAKCEGNM, [Out][NotNullWhen(true)] TErr FHHFOPCLAFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3112240", Offset = "0x3111440", VA = "0x183112240")]
	public static bool LMHONEOIOBH<TOk, TErr>([In] this EBOICGKKPAM<TOk, TErr> MLNFAKCEGNM, [Out][NotNullWhen(true)] TOk GDHAIBMOKDG, [Out][NotNullWhen(false)] TErr FHHFOPCLAFM) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x310FE00", Offset = "0x310F000", VA = "0x18310FE00")]
	public static bool AHJOOMBMOKK<TOk, TErr>([In] this EBOICGKKPAM<TOk, TErr> MLNFAKCEGNM, [Out][NotNullWhen(true)] TOk GDHAIBMOKDG, [Out] EBOICGKKPAM<TOk, TErr> BHGCDCOOCBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3112630", Offset = "0x3111830", VA = "0x183112630")]
	public static bool PBLLCKFFBMD<TOk, TErr, UErr, UOk>([In] this EBOICGKKPAM<TOk, TErr> MLNFAKCEGNM, [Out][NotNullWhen(true)] TOk GDHAIBMOKDG, [Out] EBOICGKKPAM<UOk, UErr> BHGCDCOOCBH) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x31111C0", Offset = "0x31103C0", VA = "0x1831111C0")]
	public static bool FADHEGNCNHA<TOk, TErr>([In] this EBOICGKKPAM<TOk, TErr> MLNFAKCEGNM, [Out][NotNullWhen(true)] TOk GDHAIBMOKDG, [Out] EBOICGKKPAM<HEGEDEFNLEJ, TErr> BHGCDCOOCBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x310FF00", Offset = "0x310F100", VA = "0x18310FF00")]
	public static EBOICGKKPAM<UOk, UErr> APCBDHAODPM<UOk, UErr, TOk, TErr>([In] this EBOICGKKPAM<TOk, TErr> MLNFAKCEGNM, [In] EBOICGKKPAM<UOk, UErr> PIEFIBOFCOC) where TOk : UOk where TErr : UErr
	{
		return default(EBOICGKKPAM<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x31122C0", Offset = "0x31114C0", VA = "0x1831122C0")]
	public static EBOICGKKPAM<TOk?[]?, TErr?> MNHLFFEIICP<TOk, TErr>(this IEnumerable<EBOICGKKPAM<TOk, TErr>> MLNFAKCEGNM)
	{
		return default(EBOICGKKPAM<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3111570", Offset = "0x3110770", VA = "0x183111570")]
	public static EBOICGKKPAM<UOk?, TErr?> GNFPIFCFBIL<UOk, TErr, TOk>([In] this EBOICGKKPAM<TOk, TErr> MLNFAKCEGNM, Func<TOk, UOk> MLCMGLCHLFJ)
	{
		return default(EBOICGKKPAM<UOk, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class MDAIDOOFLFP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x34186E0", Offset = "0x34178E0", VA = "0x1834186E0")]
	public static EBOICGKKPAM<TOk, T> DANFDJPOOPF<TOk>([In] TOk GDHAIBMOKDG) where TOk : notnull
	{
		return default(EBOICGKKPAM<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4BDC0F0", Offset = "0x4BDB2F0", VA = "0x184BDC0F0")]
	public static EBOICGKKPAM<HEGEDEFNLEJ, T> DANFDJPOOPF()
	{
		return default(EBOICGKKPAM<HEGEDEFNLEJ, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3418650", Offset = "0x3417850", VA = "0x183418650")]
	public static EBOICGKKPAM<T, TErr> CFNJEMCIMDK<TErr>([In] TErr FHHFOPCLAFM) where TErr : notnull
	{
		return default(EBOICGKKPAM<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct ELANPIELKHJ<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly LHOJJKNJAGO MPDKIKFJOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Dictionary<TKey, TValue> DBLCOAJMKJH;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3F201C0", Offset = "0x3F1F3C0", VA = "0x183F201C0")]
	public static ELANPIELKHJ<TKey, TValue> PAJOIGLPBMN(string GCGNIOHLIKK)
	{
		return default(ELANPIELKHJ<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3F202E0", Offset = "0x3F1F4E0", VA = "0x183F202E0")]
	internal ELANPIELKHJ(Dictionary<TKey, TValue> OMEFCJCOLII, LHOJJKNJAGO GBCDDHNMBFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3F20120", Offset = "0x3F1F320", VA = "0x183F20120")]
	public GPPHJGCOMNC<TKey, TValue> NBJFEJBLKFH([Out] Dictionary<TKey, TValue> OMEFCJCOLII)
	{
		return default(GPPHJGCOMNC<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct GPPHJGCOMNC<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly Dictionary<TKey, TValue> DBLCOAJMKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly KODBDMCNMMA DGCNMCGLICH;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2703C70", Offset = "0x2702E70", VA = "0x182703C70")]
	internal GPPHJGCOMNC(Dictionary<TKey, TValue> OMEFCJCOLII, KODBDMCNMMA HFKBOPALNDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x42E2060", Offset = "0x42E1260", VA = "0x1842E2060", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct PCHJJGMPLKJ<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly LHOJJKNJAGO MPDKIKFJOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly HashSet<T> DBLCOAJMKJH;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3F201C0", Offset = "0x3F1F3C0", VA = "0x183F201C0")]
	public static PCHJJGMPLKJ<T> PAJOIGLPBMN(string GCGNIOHLIKK)
	{
		return default(PCHJJGMPLKJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3F202E0", Offset = "0x3F1F4E0", VA = "0x183F202E0")]
	internal PCHJJGMPLKJ(HashSet<T> OMEFCJCOLII, LHOJJKNJAGO GBCDDHNMBFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3F20120", Offset = "0x3F1F320", VA = "0x183F20120")]
	public JJNJDDGOOLE<T> NBJFEJBLKFH([Out] HashSet<T> OMEFCJCOLII)
	{
		return default(JJNJDDGOOLE<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct JJNJDDGOOLE<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly HashSet<T> DBLCOAJMKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly KODBDMCNMMA DGCNMCGLICH;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2703C70", Offset = "0x2702E70", VA = "0x182703C70")]
	internal JJNJDDGOOLE(HashSet<T> OMEFCJCOLII, KODBDMCNMMA HFKBOPALNDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x42E2060", Offset = "0x42E1260", VA = "0x1842E2060", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct FDDNHEMIABG<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly LHOJJKNJAGO MPDKIKFJOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Stack<T> DBLCOAJMKJH;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3F201C0", Offset = "0x3F1F3C0", VA = "0x183F201C0")]
	public static FDDNHEMIABG<T> PAJOIGLPBMN(string GCGNIOHLIKK)
	{
		return default(FDDNHEMIABG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3F202E0", Offset = "0x3F1F4E0", VA = "0x183F202E0")]
	internal FDDNHEMIABG(Stack<T> OMEFCJCOLII, LHOJJKNJAGO GBCDDHNMBFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x42E13D0", Offset = "0x42E05D0", VA = "0x1842E13D0")]
	public FDOKMGBJHAB<T> NBJFEJBLKFH([Out] Stack<T> OMEFCJCOLII)
	{
		return default(FDOKMGBJHAB<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct FDOKMGBJHAB<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Stack<T> DBLCOAJMKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly KODBDMCNMMA DGCNMCGLICH;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2703C70", Offset = "0x2702E70", VA = "0x182703C70")]
	internal FDOKMGBJHAB(Stack<T> OMEFCJCOLII, KODBDMCNMMA HFKBOPALNDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x42E2060", Offset = "0x42E1260", VA = "0x1842E2060", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DefaultMember("Item")]
public sealed class GEBCCEKIGFD<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct OKPOPJINACD : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly GEBCCEKIGFD<T> NLOBHOMPDGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly int DKBPDGHGIDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly bool GCKNHDDDOEJ;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2400650", Offset = "0x23FF850", VA = "0x182400650")]
		public OKPOPJINACD(GEBCCEKIGFD<T> CMFHMEJHOAJ, int MPBLENMOIHO, bool MEFNCBKBOCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x4E38480", Offset = "0x4E37680", VA = "0x184E38480")]
		public GEBCCEKIGFD<T>.JOBCIFILHOB EMKBHPPGLAN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x4E38570", Offset = "0x4E37770", VA = "0x184E38570", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x4E38570", Offset = "0x4E37770", VA = "0x184E38570", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class JOBCIFILHOB : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly GEBCCEKIGFD<T> NLOBHOMPDGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly int ADNMMPPPJKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int FHEKPFJBFBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly bool GCKNHDDDOEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private bool HFCBOAIMBBC;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T AJGNMEAPLII
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x4848E60", Offset = "0x4848060", VA = "0x184848E60")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x4848F90", Offset = "0x4848190", VA = "0x184848F90", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x4849180", Offset = "0x4848380", VA = "0x184849180", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x48495A0", Offset = "0x48487A0", VA = "0x1848495A0")]
		public JOBCIFILHOB(GEBCCEKIGFD<T> CMFHMEJHOAJ, int MPBLENMOIHO, bool MEFNCBKBOCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x4848EA0", Offset = "0x48480A0", VA = "0x184848EA0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x4848F30", Offset = "0x4848130", VA = "0x184848F30", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class HKFKKCLJPIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public HKFKKCLJPIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x44E2F50", Offset = "0x44E2150", VA = "0x1844E2F50")]
		internal T PPJPMAAMDBO(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly T[] LGIBPLLMJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int FHEKPFJBFBO;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int CAJFIEMOPDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x43B3B80", Offset = "0x43B2D80", VA = "0x1843B3B80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T AJGNMEAPLII
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x42CC1B0", Offset = "0x42CB3B0", VA = "0x1842CC1B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T KKNAFBJAICO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x43B3BE0", Offset = "0x43B2DE0", VA = "0x1843B3BE0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T FJMFIOCLMJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x43B3E10", Offset = "0x43B3010", VA = "0x1843B3E10")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int JBMLOIOBDME
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2251920", Offset = "0x2250B20", VA = "0x182251920")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1812CE0", Offset = "0x1811EE0", VA = "0x181812CE0")]
	private static int IHHCAMCDFKN(int CPLNODNGKGB, int BJJBELCKPHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x43B3F70", Offset = "0x43B3170", VA = "0x1843B3F70")]
	public GEBCCEKIGFD(int AFLMMFDMNOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x43B3FF0", Offset = "0x43B31F0", VA = "0x1843B3FF0")]
	public GEBCCEKIGFD(int AFLMMFDMNOE, Func<T> EKIMDIFJIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x43B4430", Offset = "0x43B3630", VA = "0x1843B4430")]
	public GEBCCEKIGFD(T[] GIJCPEPCKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x43B3F40", Offset = "0x43B3140", VA = "0x1843B3F40")]
	public void NADIBIJFODK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x43B3E80", Offset = "0x43B3080", VA = "0x1843B3E80")]
	public IEnumerable<T> LOIEMABBBBI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x43B3C20", Offset = "0x43B2E20", VA = "0x1843B3C20")]
	public GEBCCEKIGFD<T>.JOBCIFILHOB EMKBHPPGLAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x436F9E0", Offset = "0x436EBE0", VA = "0x18436F9E0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x436F9E0", Offset = "0x436EBE0", VA = "0x18436F9E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class IGOHEIFMHDD
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x32B3340", Offset = "0x32B2540", VA = "0x1832B3340")]
	public static GEBCCEKIGFD<T> PAJOIGLPBMN<T>(int AFLMMFDMNOE, Func<T> EKIMDIFJIJO) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class MNGPCBFNEDA<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct LLAMKGCDCMP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly MNGPCBFNEDA<T> BMIOFMJKEHL;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T ELOFPHHKCIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x4A011C0", Offset = "0x4A003C0", VA = "0x184A011C0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x4A011E0", Offset = "0x4A003E0", VA = "0x184A011E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xBC2740", Offset = "0xBC1940", VA = "0x180BC2740")]
		public LLAMKGCDCMP(MNGPCBFNEDA<T> BMIOFMJKEHL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct NBIGMKMMMFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public AsyncTaskMethodBuilder<LLAMKGCDCMP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public MNGPCBFNEDA<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x4C660F0", Offset = "0x4C652F0", VA = "0x184C660F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x465F610", Offset = "0x465E810", VA = "0x18465F610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly SemaphoreSlim HLIEEHEDMCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private T DAFFFIIHPKE;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4C204D0", Offset = "0x4C1F6D0", VA = "0x184C204D0")]
	public MNGPCBFNEDA([In] T DAFFFIIHPKE, int KALNBJIIOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4C203F0", Offset = "0x4C1F5F0", VA = "0x184C203F0")]
	public MNGPCBFNEDA([In] T DAFFFIIHPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4C1FED0", Offset = "0x4C1F0D0", VA = "0x184C1FED0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4C1FF30", Offset = "0x4C1F130", VA = "0x184C1FF30")]
	public LLAMKGCDCMP FJHAFOKNKNL()
	{
		return default(LLAMKGCDCMP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x4C20090", Offset = "0x4C1F290", VA = "0x184C20090")]
	[AsyncStateMachine(typeof(MNGPCBFNEDA<>.NBIGMKMMMFC))]
	public Task<MNGPCBFNEDA<T>.LLAMKGCDCMP> JAIKKMHMEPE(CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4C1FF10", Offset = "0x4C1F110", VA = "0x184C1FF10")]
	public void EBOAHCOCEIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class DPDNADAJDHC
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x732A220", Offset = "0x7329420", VA = "0x18732A220")]
	public static MNGPCBFNEDA<HEGEDEFNLEJ> PAJOIGLPBMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x304E4D0", Offset = "0x304D6D0", VA = "0x18304E4D0")]
	public static MNGPCBFNEDA<T> PAJOIGLPBMN<T>([In] T DAFFFIIHPKE) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class IPIINFBCHPJ<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct JGLNPNKHONI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly IPIINFBCHPJ<T> JOMIANBDNBM;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public T ELOFPHHKCIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x3F29400", Offset = "0x3F28600", VA = "0x183F29400")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x48298D0", Offset = "0x4828AD0", VA = "0x1848298D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xBC2740", Offset = "0xBC1940", VA = "0x180BC2740")]
		internal JGLNPNKHONI(IPIINFBCHPJ<T> BMIOFMJKEHL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct EOFPHJFMDEL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly IPIINFBCHPJ<T> JOMIANBDNBM;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public T ELOFPHHKCIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x3F29400", Offset = "0x3F28600", VA = "0x183F29400")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3F29470", Offset = "0x3F28670", VA = "0x183F29470", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xBC2740", Offset = "0xBC1940", VA = "0x180BC2740")]
		internal EOFPHJFMDEL(IPIINFBCHPJ<T> BMIOFMJKEHL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct MGHFJLCMLLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder<EOFPHJFMDEL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public IPIINFBCHPJ<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private MNGPCBFNEDA<HEGEDEFNLEJ>.LLAMKGCDCMP <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<MNGPCBFNEDA<HEGEDEFNLEJ>.LLAMKGCDCMP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x4BEC2D0", Offset = "0x4BEB4D0", VA = "0x184BEC2D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x465F610", Offset = "0x465E810", VA = "0x18465F610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly MNGPCBFNEDA<int> HLCLIHDLJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly MNGPCBFNEDA<HEGEDEFNLEJ> NHGKOBMFHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly MNGPCBFNEDA<HEGEDEFNLEJ> ELJBNBKGPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private T JDIPCALIIPJ;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x466A930", Offset = "0x4669B30", VA = "0x18466A930")]
	internal IPIINFBCHPJ(MNGPCBFNEDA<int> PLFGMBJOINN, MNGPCBFNEDA<HEGEDEFNLEJ> AAOKMECJCOA, MNGPCBFNEDA<HEGEDEFNLEJ> DFJFDBCNBII, [In] T DAFFFIIHPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4669F10", Offset = "0x4669110", VA = "0x184669F10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x466A1D0", Offset = "0x46693D0", VA = "0x18466A1D0")]
	public JGLNPNKHONI IFPJADONGKG()
	{
		return default(JGLNPNKHONI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4669DA0", Offset = "0x4668FA0", VA = "0x184669DA0")]
	public EOFPHJFMDEL CCDEIAGNOJL()
	{
		return default(EOFPHJFMDEL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x466A790", Offset = "0x4669990", VA = "0x18466A790")]
	[AsyncStateMachine(typeof(IPIINFBCHPJ<>.MGHFJLCMLLP))]
	public Task<IPIINFBCHPJ<T>.EOFPHJFMDEL> NBFHGNMGMFK(CancellationToken BGEKICMONBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class DBPMGFPEMEB
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x732A150", Offset = "0x7329350", VA = "0x18732A150")]
	public static IPIINFBCHPJ<HEGEDEFNLEJ> PAJOIGLPBMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x30F14F0", Offset = "0x30F06F0", VA = "0x1830F14F0")]
	public static IPIINFBCHPJ<T> PAJOIGLPBMN<T>([In] T DAFFFIIHPKE) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public sealed class DMLGANIFPBB<TData> : ENAONJKJOID where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly string DCDNDNHHMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly TData ELDOIBMHPAJ;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "7")]
	public override string OEJBHPKDIJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6082EA0", Offset = "0x60820A0", VA = "0x186082EA0")]
	internal DMLGANIFPBB(string CBCJFCINKPJ, [In] TData LFDKFEEPNFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class AGDLJAAHODE
{
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x7329CA0", Offset = "0x7328EA0", VA = "0x187329CA0")]
	public static DMLGANIFPBB<HEGEDEFNLEJ> PAJOIGLPBMN(string CBCJFCINKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x304C770", Offset = "0x304B970", VA = "0x18304C770")]
	public static DMLGANIFPBB<TData> PAJOIGLPBMN<TData>(string CBCJFCINKPJ, [In] TData LFDKFEEPNFP) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class LHOJJKNJAGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal bool BPDOFCCIIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly string KNFDPOCBPHN;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0xCB1FA0", Offset = "0xCB11A0", VA = "0x180CB1FA0")]
	private LHOJJKNJAGO(bool CLFEKCGNBPP, string GCHHCPBMIAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x732C3B0", Offset = "0x732B5B0", VA = "0x18732C3B0")]
	public static LHOJJKNJAGO PAJOIGLPBMN(string GCHHCPBMIAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x732C2F0", Offset = "0x732B4F0", VA = "0x18732C2F0")]
	public KODBDMCNMMA NBJFEJBLKFH()
	{
		return default(KODBDMCNMMA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct KODBDMCNMMA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly LHOJJKNJAGO MOPNANHIBPM;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0xBC2740", Offset = "0xBC1940", VA = "0x180BC2740")]
	internal KODBDMCNMMA(LHOJJKNJAGO GCGNIOHLIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x732C2D0", Offset = "0x732B4D0", VA = "0x18732C2D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
public sealed class INKODEHPGIM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class ILJCIPIAAIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public ILJCIPIAAIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x464FEA0", Offset = "0x464F0A0", VA = "0x18464FEA0")]
		internal int MBNJCNNONFF(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private HashSet<T>? OKABAOBBJBI;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public IReadOnlyCollection<T> FFALICPKAOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x4661040", Offset = "0x4660240", VA = "0x184661040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool PHLKHHGLLGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x4660FF0", Offset = "0x46601F0", VA = "0x184660FF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int BIMHEMDFFPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D30", Offset = "0x8F3F30", VA = "0x1808F4D30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8F54B0", Offset = "0x8F46B0", VA = "0x1808F54B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4660E30", Offset = "0x4660030", VA = "0x184660E30")]
	public bool CKLHJOINNOK(T BCOHKLCJCPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4661080", Offset = "0x4660280", VA = "0x184661080")]
	public bool GMODDBABBFK(T BCOHKLCJCPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x46611F0", Offset = "0x46603F0", VA = "0x1846611F0")]
	public bool NDFFHEILIJK(T BCOHKLCJCPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4660D50", Offset = "0x465FF50", VA = "0x184660D50")]
	public void CAEEOLFHGJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4661240", Offset = "0x4660440", VA = "0x184661240", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public INKODEHPGIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public sealed class PNEMCEGHFHA
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class OBNPLOIAHLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public OBNPLOIAHLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x732CAD0", Offset = "0x732BCD0", VA = "0x18732CAD0")]
		internal int MBNJCNNONFF(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private HashSet<object>? OKABAOBBJBI;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IReadOnlyCollection<object> FFALICPKAOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x732CF10", Offset = "0x732C110", VA = "0x18732CF10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool PHLKHHGLLGE
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x732CF00", Offset = "0x732C100", VA = "0x18732CF00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int BIMHEMDFFPF
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D30", Offset = "0x8F3F30", VA = "0x1808F4D30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8F54B0", Offset = "0x8F46B0", VA = "0x1808F54B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x732CE20", Offset = "0x732C020", VA = "0x18732CE20")]
	public bool CKLHJOINNOK(object BCOHKLCJCPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x732CFA0", Offset = "0x732C1A0", VA = "0x18732CFA0")]
	public bool GMODDBABBFK(object BCOHKLCJCPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x732D040", Offset = "0x732C240", VA = "0x18732D040")]
	public bool NDFFHEILIJK(object BCOHKLCJCPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x732CDB0", Offset = "0x732BFB0", VA = "0x18732CDB0")]
	public void CAEEOLFHGJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x732D0A0", Offset = "0x732C2A0", VA = "0x18732D0A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public PNEMCEGHFHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class NCAPDKFFCEO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private struct EGPFLIDFMFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public float ENHODIJEFJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public T ELOFPHHKCIM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Dictionary<object, EGPFLIDFMFO> IMCKAINIGJK;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public virtual T DLELEKMDDEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x16D51F0", Offset = "0x16D43F0", VA = "0x1816D51F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x16D37E0", Offset = "0x16D29E0", VA = "0x1816D37E0", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public object? OCPBGFCEPMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D20", Offset = "0x8F3F20", VA = "0x1808F4D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D40", Offset = "0x8F3F40", VA = "0x1808F4D40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool ABDPCEPPJPH
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x4C68EB0", Offset = "0x4C680B0", VA = "0x184C68EB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x4C69890", Offset = "0x4C68A90", VA = "0x184C69890")]
	public bool FBBOPGKJCKB(T OMEFCJCOLII, object BCOHKLCJCPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x484BA30", Offset = "0x484AC30", VA = "0x18484BA30")]
	public bool OPEPHGNFMMF(object BCOHKLCJCPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x462B650", Offset = "0x462A850", VA = "0x18462B650")]
	public void DBGBEIOBMKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x4C69150", Offset = "0x4C68350", VA = "0x184C69150")]
	public bool EKHOHBPCPIG(object BCOHKLCJCPM, [Out] T OMEFCJCOLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x4C69C60", Offset = "0x4C68E60", VA = "0x184C69C60")]
	[ALKCGLMHGAP("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool KPPKDIPHMID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x484BAD0", Offset = "0x484ACD0", VA = "0x18484BAD0")]
	public NCAPDKFFCEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public sealed class IGBBELMMAJJ : IOMEFHNELBD<IGCCAEFBMNB>
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	internal class DBDBFINLDEE : IEqualityComparer<IGCCAEFBMNB>
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		internal static readonly DBDBFINLDEE CLACNPDFIIL;

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x732A0B0", Offset = "0x73292B0", VA = "0x18732A0B0", Slot = "4")]
		public bool Equals(IGCCAEFBMNB KIEMJAMMNPB, IGCCAEFBMNB IIOFLMMOEPL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6616A60", Offset = "0x6615C60", VA = "0x186616A60", Slot = "5")]
		public int GetHashCode(IGCCAEFBMNB LCACGJDNDHA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public DBDBFINLDEE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x732AEC0", Offset = "0x732A0C0", VA = "0x18732AEC0")]
	public IGBBELMMAJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x732ACD0", Offset = "0x7329ED0", VA = "0x18732ACD0", Slot = "4")]
	public override bool CKLHJOINNOK(IGCCAEFBMNB BCOHKLCJCPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x732AD80", Offset = "0x7329F80", VA = "0x18732AD80", Slot = "5")]
	public override bool GMODDBABBFK(IGCCAEFBMNB BCOHKLCJCPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x732AE30", Offset = "0x732A030", VA = "0x18732AE30")]
	private static void OCALPBJGJNJ(IGCCAEFBMNB BCOHKLCJCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x15DC010", Offset = "0x15DB210", VA = "0x1815DC010", Slot = "6")]
	protected override string JPGMCJLMGKM(IGCCAEFBMNB BCOHKLCJCPM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public sealed class IGCCAEFBMNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly string NIJMDOKDLIH;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x902B20", Offset = "0x901D20", VA = "0x180902B20")]
	public IGCCAEFBMNB(string NIJMDOKDLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x732AF30", Offset = "0x732A130", VA = "0x18732AF30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public abstract class IOMEFHNELBD<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly IEqualityComparer<T> FHMDPOEGNHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private HashSet<T>? OKABAOBBJBI;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool PHLKHHGLLGE
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x4668B70", Offset = "0x4667D70", VA = "0x184668B70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int BIMHEMDFFPF
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xA960C0", Offset = "0xA952C0", VA = "0x180A960C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xB25E10", Offset = "0xB25010", VA = "0x180B25E10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x4669010", Offset = "0x4668210", VA = "0x184669010")]
	internal IOMEFHNELBD(IEqualityComparer<T> FHMDPOEGNHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x46689A0", Offset = "0x4667BA0", VA = "0x1846689A0", Slot = "4")]
	public virtual bool CKLHJOINNOK(T BCOHKLCJCPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x4668BB0", Offset = "0x4667DB0", VA = "0x184668BB0", Slot = "5")]
	public virtual bool GMODDBABBFK(T BCOHKLCJCPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x46688C0", Offset = "0x4667AC0", VA = "0x1846688C0")]
	public void CAEEOLFHGJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract string JPGMCJLMGKM(T BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x4668D20", Offset = "0x4667F20", VA = "0x184668D20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class JOELAHHDHCN<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private List<WeakReference<T>>? OKABAOBBJBI;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool PHLKHHGLLGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x484A490", Offset = "0x4849690", VA = "0x18484A490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int BIMHEMDFFPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x484A750", Offset = "0x4849950", VA = "0x18484A750")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x484A220", Offset = "0x4849420", VA = "0x18484A220")]
	public void CKLHJOINNOK(T BCOHKLCJCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x484A5B0", Offset = "0x48497B0", VA = "0x18484A5B0")]
	public void GMODDBABBFK(T BCOHKLCJCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x484A1E0", Offset = "0x48493E0", VA = "0x18484A1E0")]
	public void CAEEOLFHGJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x484A8F0", Offset = "0x4849AF0", VA = "0x18484A8F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public JOELAHHDHCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal static class ONKLJLCBACI
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3336E70", Offset = "0x3336070", VA = "0x183336E70")]
	public static void AEIBHAKFGBI<T>(this List<T> AFNGOKKOBOC, int CPLNODNGKGB) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class CFNNONFLDEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly Dictionary<object, float> IMCKAINIGJK;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public float KHKDBBFLNCN
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xD59F40", Offset = "0xD59140", VA = "0x180D59F40")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xD5A5A0", Offset = "0xD597A0", VA = "0x180D5A5A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7329E10", Offset = "0x7329010", VA = "0x187329E10")]
	public void FBBOPGKJCKB(float OMEFCJCOLII, object BCOHKLCJCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7329FB0", Offset = "0x73291B0", VA = "0x187329FB0")]
	public void OPEPHGNFMMF(object BCOHKLCJCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7329DC0", Offset = "0x7328FC0", VA = "0x187329DC0")]
	public void DBGBEIOBMKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7329E80", Offset = "0x7329080", VA = "0x187329E80")]
	private void LGGNHBCMGOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x732A020", Offset = "0x7329220", VA = "0x18732A020")]
	public CFNNONFLDEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface OONPCCCGCKE
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event ELLICKCNDDG MCGNEMECJDJ;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class IMPDAEGGLLG : OONPCCCGCKE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public readonly struct IAILAFMDLDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public readonly float HFJDLLOGLKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public readonly float MEHOHBKCKNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		internal readonly bool CLGLGAODANF;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float ININOACGFGC
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x732A9A0", Offset = "0x7329BA0", VA = "0x18732A9A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x732AB10", Offset = "0x7329D10", VA = "0x18732AB10")]
		public IAILAFMDLDH(float JEMCAHPLMGJ, float OBOEOHHCBAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x732A9B0", Offset = "0x7329BB0", VA = "0x18732A9B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class BFLNFANNGOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public IMPDAEGGLLG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public BFLNFANNGOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7329D20", Offset = "0x7328F20", VA = "0x187329D20")]
		internal void HNKIGCCNBKO(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly int EKPEFEBPGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private int CBDGIBKEKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly OONPCCCGCKE[] HMLKHGFADJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly ELLICKCNDDG[] CKNLAJJPLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly IAILAFMDLDH[] OHNIEMCDKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private IAILAFMDLDH APOFMJGLCDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly OCHAGJHGHGK PFLBBPEIHKL;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event ELLICKCNDDG MCGNEMECJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x732B690", Offset = "0x732A890", VA = "0x18732B690", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x732B5D0", Offset = "0x732A7D0", VA = "0x18732B5D0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x732B750", Offset = "0x732A950", VA = "0x18732B750")]
	public IMPDAEGGLLG(int EKPEFEBPGMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x732B0D0", Offset = "0x732A2D0", VA = "0x18732B0D0")]
	public OCHAGJHGHGK ELEPAKDJNAK(IAILAFMDLDH CILLHHMAAOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x732B160", Offset = "0x732A360", VA = "0x18732B160")]
	public void GCHNAHKJHGM(OONPCCCGCKE BGLHNOLNBIJ, [Optional] IAILAFMDLDH DLGKBKEAJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x732AFC0", Offset = "0x732A1C0", VA = "0x18732AFC0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public delegate void ELLICKCNDDG(float ILGNNCFDDPC);
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class ACNLBOEPPLN
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class JBBCODPKKJD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly OONPCCCGCKE GJHPAKHJHFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly ELLICKCNDDG FOCHKIPOIOG;

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x732B930", Offset = "0x732AB30", VA = "0x18732B930")]
		public JBBCODPKKJD(OONPCCCGCKE GJHPAKHJHFM, ELLICKCNDDG FOCHKIPOIOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x732B8E0", Offset = "0x732AAE0", VA = "0x18732B8E0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7329810", Offset = "0x7328A10", VA = "0x187329810")]
	internal static bool LPDFAFAHPKL(float KKLLOEEDINO, float NHCGDJCFKIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x731C5C0", Offset = "0x731B7C0", VA = "0x18731C5C0")]
	internal static float MAJPOGECPJB(float KKLLOEEDINO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7329880", Offset = "0x7328A80", VA = "0x187329880")]
	public static IDisposable PHMFKPEHBGA(this OONPCCCGCKE GJHPAKHJHFM, ELLICKCNDDG FOCHKIPOIOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class OCHAGJHGHGK : OONPCCCGCKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private float ILGNNCFDDPC;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public float AKBHCDEANDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x732CCC0", Offset = "0x732BEC0", VA = "0x18732CCC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event ELLICKCNDDG? MCGNEMECJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x732CC20", Offset = "0x732BE20", VA = "0x18732CC20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x732CB80", Offset = "0x732BD80", VA = "0x18732CB80", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public OCHAGJHGHGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface GPCAOPMLEEB<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CAFIJAPCIBJ<T> HFPCILCLDOM([Out] T OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DBGBEIOBMKO();
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class BIMPKFHLACE<T> : GPCAOPMLEEB<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly ConcurrentStack<T> MMGIGGNHEOL;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x56489F0", Offset = "0x5647BF0", VA = "0x1856489F0", Slot = "4")]
	public CAFIJAPCIBJ<T> HFPCILCLDOM([Out] T OMEFCJCOLII)
	{
		return default(CAFIJAPCIBJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5648A90", Offset = "0x5647C90", VA = "0x185648A90")]
	public void OIHANPNKAFH(T DFBGGCCCJPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x3F28D10", Offset = "0x3F27F10", VA = "0x183F28D10", Slot = "5")]
	public void DBGBEIOBMKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "6")]
	protected virtual void CEKBEGPMHNJ(T GBBLGMMPLEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5648950", Offset = "0x5647B50", VA = "0x185648950")]
	private T BGMHNJIJIDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5648B10", Offset = "0x5647D10", VA = "0x185648B10")]
	public BIMPKFHLACE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct CAFIJAPCIBJ<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly T DFBGGCCCJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly BIMPKFHLACE<T> NEOIHHDGEAA;

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x982390", Offset = "0x981590", VA = "0x180982390")]
	internal CAFIJAPCIBJ(T OMEFCJCOLII, BIMPKFHLACE<T> NEOIHHDGEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x56DF450", Offset = "0x56DE650", VA = "0x1856DF450", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class LNCLMAJEKAB : BIMPKFHLACE<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public static readonly LNCLMAJEKAB CLACNPDFIIL;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x732C8B0", Offset = "0x732BAB0", VA = "0x18732C8B0")]
	public static CAFIJAPCIBJ<StringBuilder> BGMHNJIJIDG([Out] StringBuilder OMEFCJCOLII)
	{
		return default(CAFIJAPCIBJ<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x732C950", Offset = "0x732BB50", VA = "0x18732C950", Slot = "6")]
	protected override void CEKBEGPMHNJ(StringBuilder GBBLGMMPLEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x732CA10", Offset = "0x732BC10", VA = "0x18732CA10")]
	public LNCLMAJEKAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class MPCDOBFBJPD : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6CE5D30", Offset = "0x6CE4F30", VA = "0x186CE5D30")]
	public MPCDOBFBJPD(string CBCJFCINKPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[DefaultMember("Item")]
public class MEANJHIMHOG<TKey, TValue> : CIMGMHFHOCI<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, GEAMGHJAJFM where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class OIOCFABECHL : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public MEANJHIMHOG<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x16D51F0", Offset = "0x16D43F0", VA = "0x1816D51F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x4DC21E0", Offset = "0x4DC13E0", VA = "0x184DC21E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8F2CE0", Offset = "0x8F1EE0", VA = "0x1808F2CE0")]
		[DebuggerHidden]
		public OIOCFABECHL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x43162B0", Offset = "0x43154B0", VA = "0x1843162B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x4DC1C70", Offset = "0x4DC0E70", VA = "0x184DC1C70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x4DC1360", Offset = "0x4DC0560", VA = "0x184DC1360")]
		private void MHLANDJELDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x4DC11D0", Offset = "0x4DC03D0", VA = "0x184DC11D0")]
		private void JELILPGANHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x4DC20F0", Offset = "0x4DC12F0", VA = "0x184DC20F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly CIMGMHFHOCI<TKey, TValue> HEONNGMIEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly IDictionary<TKey, TValue> KPLGDICGKMM;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int BIMHEMDFFPF
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x4BE0260", Offset = "0x4BDF460", VA = "0x184BE0260", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool NPIFBDLIKBI
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public TValue FJMFIOCLMJL
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x4BE0370", Offset = "0x4BDF570", VA = "0x184BE0370", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x4BE0640", Offset = "0x4BDF840", VA = "0x184BE0640", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public ICollection<TKey> KEMNOMLLJPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x4BE03C0", Offset = "0x4BDF5C0", VA = "0x184BE03C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public ICollection<TValue> CLGPBIGPAAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x4BE04E0", Offset = "0x4BDF6E0", VA = "0x184BE04E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x4BE0000", Offset = "0x4BDF200", VA = "0x184BE0000")]
	public MEANJHIMHOG(CIMGMHFHOCI<TKey, TValue> HEONNGMIEDM, [Optional] IDictionary<TKey, TValue>? KPLGDICGKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x4BDDA90", Offset = "0x4BDCC90", VA = "0x184BDDA90", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x4BDF130", Offset = "0x4BDE330", VA = "0x184BDF130")]
	public void OIOMLMONOAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x4BDD4C0", Offset = "0x4BDC6C0", VA = "0x184BDD4C0", Slot = "9")]
	public void Add(TKey OFPBICPHALF, TValue OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x4BDD900", Offset = "0x4BDCB00", VA = "0x184BDD900")]
	public void BLPHHNLLPDA(TKey OFPBICPHALF, TValue OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x4BDF250", Offset = "0x4BDE450", VA = "0x184BDF250")]
	public void OLFCMOOMBBM(TKey OFPBICPHALF, TValue OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x4BDE5D0", Offset = "0x4BDD7D0", VA = "0x184BDE5D0")]
	public void IFHMECDNHKF(TKey OFPBICPHALF, TValue OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x4BDF040", Offset = "0x4BDE240", VA = "0x184BDF040")]
	public void LHHMIBFDOEO(TKey OFPBICPHALF, TValue OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x4BDF640", Offset = "0x4BDE840", VA = "0x184BDF640", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> OCLIEIADJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x4BDF6D0", Offset = "0x4BDE8D0", VA = "0x184BDF6D0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> OCLIEIADJMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x4BDFA30", Offset = "0x4BDEC30", VA = "0x184BDFA30", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> OCLIEIADJMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x4BDDBD0", Offset = "0x4BDCDD0", VA = "0x184BDDBD0", Slot = "8")]
	public bool ContainsKey(TKey OFPBICPHALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x4BDE350", Offset = "0x4BDD550", VA = "0x184BDE350")]
	public bool DEMNALBJGFA(TKey OFPBICPHALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x4BDEE40", Offset = "0x4BDE040", VA = "0x184BDEE40")]
	public bool LCKPEFPNBDO(TKey OFPBICPHALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x4BDF4A0", Offset = "0x4BDE6A0", VA = "0x184BDF4A0", Slot = "10")]
	public bool Remove(TKey OFPBICPHALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x4BDFD90", Offset = "0x4BDEF90", VA = "0x184BDFD90", Slot = "11")]
	public bool TryGetValue(TKey OFPBICPHALF, [Out] TValue OMEFCJCOLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x4BDDED0", Offset = "0x4BDD0D0", VA = "0x184BDDED0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] HCOCCGHLKNN, int BKDPKOGEFON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x48D0F80", Offset = "0x48D0180", VA = "0x1848D0F80", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x4BDE520", Offset = "0x4BDD720", VA = "0x184BDE520", Slot = "19")]
	[IteratorStateMachine(typeof(MEANJHIMHOG<, >.OIOCFABECHL))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x4BDED50", Offset = "0x4BDDF50", VA = "0x184BDED50", Slot = "21")]
	public bool JKHGLCEHIJI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x4BDEC40", Offset = "0x4BDDE40", VA = "0x184BDEC40")]
	private TValue INJIEIIEOCE(TKey OFPBICPHALF)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface GEAMGHJAJFM
{
	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JKHGLCEHIJI();
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface CIMGMHFHOCI<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, GEAMGHJAJFM
{
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[DefaultMember("Item")]
public sealed class IGGALDAFIPN<TKey, TVal> : CIMGMHFHOCI<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, GEAMGHJAJFM where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public delegate int GAKOCBHOANI(TKey OFPBICPHALF, TVal OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public delegate void HPIMKMACDHN(TKey OFPBICPHALF, TVal OMEFCJCOLII, BJLAPHKMFDP GLMJIDMBMEG);

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	private class LMLAENGAIII
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public TKey CHCLNDNNNEA
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0xB00AB0", Offset = "0xAFFCB0", VA = "0x180B00AB0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public TVal ELOFPHHKCIM
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0xA960C0", Offset = "0xA952C0", VA = "0x180A960C0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0xB25E10", Offset = "0xB25010", VA = "0x180B25E10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public int ININOACGFGC
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x9335E0", Offset = "0x9327E0", VA = "0x1809335E0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x932BE0", Offset = "0x931DE0", VA = "0x180932BE0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public DateTimeOffset NHJMALEMIEG
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x10A1F60", Offset = "0x10A1160", VA = "0x1810A1F60")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x10A20A0", Offset = "0x10A12A0", VA = "0x1810A20A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x4A04230", Offset = "0x4A03430", VA = "0x184A04230")]
		public LMLAENGAIII(TKey OFPBICPHALF, TVal IAPIOFHOONE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class FPPAHHNBLPD : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public IGGALDAFIPN<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private LinkedList<LMLAENGAIII>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x16D51F0", Offset = "0x16D43F0", VA = "0x1816D51F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x43097F0", Offset = "0x43089F0", VA = "0x1843097F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8F2CE0", Offset = "0x8F1EE0", VA = "0x1808F2CE0")]
		[DebuggerHidden]
		public FPPAHHNBLPD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x42F7C00", Offset = "0x42F6E00", VA = "0x1842F7C00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x4307A80", Offset = "0x4306C80", VA = "0x184307A80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x4306B50", Offset = "0x4305D50", VA = "0x184306B50")]
		private void MHLANDJELDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x4309440", Offset = "0x4308640", VA = "0x184309440", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public const int AHKHJOJBODF = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly Dictionary<TKey, LinkedListNode<LMLAENGAIII>> CICMBIMIEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly LinkedList<LMLAENGAIII> OILEKJIHMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly GAKOCBHOANI? ACPCIMKACJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly TimeSpan GKPNAMECDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly HPIMKMACDHN? OLNLKAIIKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly PMNBGLKENHP GLBHPBFDMKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private bool GPNHPGOJDFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly List<TKey> KEKOGGPMPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly List<TVal> IOINMLMHCOA;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int KCBJAHDNLBG
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x903060", Offset = "0x902260", VA = "0x180903060")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	internal int LAHCOEINPFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xA86BE0", Offset = "0xA85DE0", VA = "0x180A86BE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA86BF0", Offset = "0xA85DF0", VA = "0x180A86BF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int BIMHEMDFFPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x46394A0", Offset = "0x46386A0", VA = "0x1846394A0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	internal int PGEIHHLAODI
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x462B650", Offset = "0x462A850", VA = "0x18462B650")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public ICollection<TVal> CLGPBIGPAAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x4639620", Offset = "0x4638820", VA = "0x184639620", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	ICollection<TKey> IDictionary<TKey, TVal>.POMGHNJMCLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x4634B70", Offset = "0x4633D70", VA = "0x184634B70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool NPIFBDLIKBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public TVal FJMFIOCLMJL
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x46395D0", Offset = "0x46387D0", VA = "0x1846395D0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x4639710", Offset = "0x4638910", VA = "0x184639710", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x462DB30", Offset = "0x462CD30", VA = "0x18462DB30")]
	private bool GFKPMGLFJPM(int EKPEFEBPGMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x462E670", Offset = "0x462D870", VA = "0x18462E670")]
	private void JNKEGGKHALI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x4638CC0", Offset = "0x4637EC0", VA = "0x184638CC0")]
	public IGGALDAFIPN(int EKPEFEBPGMB, [Optional] GAKOCBHOANI? ACPCIMKACJD, [Optional] IEqualityComparer<TKey>? KJEPNKNBGIG, [Optional] HPIMKMACDHN? OLNLKAIIKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x4638630", Offset = "0x4637830", VA = "0x184638630")]
	public IGGALDAFIPN(TimeSpan GKPNAMECDLL, [Optional] IEqualityComparer<TKey>? KJEPNKNBGIG, [Optional] HPIMKMACDHN? OLNLKAIIKCK, [Optional] PMNBGLKENHP? GLBHPBFDMKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x4635F30", Offset = "0x4635130", VA = "0x184635F30")]
	public IGGALDAFIPN(int EKPEFEBPGMB, TimeSpan GKPNAMECDLL, [Optional] IEqualityComparer<TKey>? KJEPNKNBGIG, [Optional] HPIMKMACDHN? OLNLKAIIKCK, [Optional] PMNBGLKENHP? GLBHPBFDMKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x4635FB0", Offset = "0x46351B0", VA = "0x184635FB0")]
	public IGGALDAFIPN(int EKPEFEBPGMB, GAKOCBHOANI? ACPCIMKACJD, TimeSpan GKPNAMECDLL, [Optional] IEqualityComparer<TKey>? KJEPNKNBGIG, [Optional] HPIMKMACDHN? OLNLKAIIKCK, [Optional] PMNBGLKENHP? GLBHPBFDMKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x462E5D0", Offset = "0x462D7D0", VA = "0x18462E5D0", Slot = "21")]
	public bool JKHGLCEHIJI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x462DE40", Offset = "0x462D040", VA = "0x18462DE40", Slot = "22")]
	public bool IIEJAAKAFAG(int AFLMMFDMNOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x4622660", Offset = "0x4621860", VA = "0x184622660")]
	private bool ADCLFHCHMBC(int AFLMMFDMNOE, BJLAPHKMFDP GLMJIDMBMEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x4626840", Offset = "0x4625A40", VA = "0x184626840")]
	public void CEJFMFJKFIE(TKey OFPBICPHALF, TVal OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x4623700", Offset = "0x4622900", VA = "0x184623700", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> OCLIEIADJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x4623C30", Offset = "0x4622E30", VA = "0x184623C30", Slot = "9")]
	public void Add(TKey OFPBICPHALF, TVal OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x46270B0", Offset = "0x46262B0", VA = "0x1846270B0", Slot = "8")]
	public bool ContainsKey(TKey OFPBICPHALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x46344C0", Offset = "0x46336C0", VA = "0x1846344C0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> OCLIEIADJMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x4633D80", Offset = "0x4632F80", VA = "0x184633D80", Slot = "10")]
	public bool Remove(TKey OFPBICPHALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x4634920", Offset = "0x4633B20", VA = "0x184634920", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> OCLIEIADJMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x46299B0", Offset = "0x4628BB0", VA = "0x1846299B0")]
	private bool DMNAJEFBKOC(TKey OFPBICPHALF, [Out] TVal OMEFCJCOLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x4624970", Offset = "0x4623B70", VA = "0x184624970")]
	private TVal BGMHNJIJIDG(TKey MJJCFLDMEMJ)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x4635600", Offset = "0x4634800", VA = "0x184635600", Slot = "11")]
	public bool TryGetValue(TKey MJJCFLDMEMJ, [Out] TVal OMEFCJCOLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x4626E60", Offset = "0x4626060", VA = "0x184626E60", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x4627C00", Offset = "0x4626E00", VA = "0x184627C00", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] HCOCCGHLKNN, int BKDPKOGEFON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x462A900", Offset = "0x4629B00", VA = "0x18462A900")]
	private void EFHJNONNJLP(TKey OFPBICPHALF, TVal IAPIOFHOONE, BJLAPHKMFDP GLMJIDMBMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x462EE60", Offset = "0x462E060", VA = "0x18462EE60")]
	private bool OLKALPPBLLH(LMLAENGAIII ENKLDCDPKEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x46301D0", Offset = "0x462F3D0", VA = "0x1846301D0")]
	private void PFELBENDOAE(LinkedListNode<LMLAENGAIII> AHNAKPHMGPN, TVal FAKLBLICCDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x462B6A0", Offset = "0x462A8A0", VA = "0x18462B6A0")]
	private void FBBOPGKJCKB(TKey OFPBICPHALF, TVal OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x4625D50", Offset = "0x4624F50", VA = "0x184625D50")]
	private void BJNLPPNOAMK(LMLAENGAIII ENKLDCDPKEF, TVal FAKLBLICCDK, int NNJFNPJGBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x462DB80", Offset = "0x462CD80", VA = "0x18462DB80", Slot = "19")]
	[IteratorStateMachine(typeof(IGGALDAFIPN<, >.FPPAHHNBLPD))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x4634BC0", Offset = "0x4633DC0", VA = "0x184634BC0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public enum BJLAPHKMFDP : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	RemovedViaClear,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Overwritten
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class PNMLHKOKLBA<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly TKey PCIMLLHBCFE;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x4F43FB0", Offset = "0x4F431B0", VA = "0x184F43FB0")]
	public PNMLHKOKLBA(TKey KBOBHHKPLKD, Exception EKNOIMPALPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class IEENOPFMOAL : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x65AAD60", Offset = "0x65A9F60", VA = "0x1865AAD60")]
	public IEENOPFMOAL(string CBCJFCINKPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class HKFPDOELIAM<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class CCEOLKBJCIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public HKFPDOELIAM<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public CCEOLKBJCIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x56E25D0", Offset = "0x56E17D0", VA = "0x1856E25D0")]
		internal Task<TResource> FDEFANFDIBF(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct OEKLENLJHII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public HKFPDOELIAM<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x4D9D000", Offset = "0x4D9C200", VA = "0x184D9D000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x4D9D8A0", Offset = "0x4D9CAA0", VA = "0x184D9D8A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private struct KDOEMDAOCLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x4926A00", Offset = "0x4925C00", VA = "0x184926A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x4927420", Offset = "0x4926620", VA = "0x184927420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly KNKKDCDAJEC<TId, Task<TResource>> JJHGNGDGLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> AMFKFMLNPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? PHLGJAAFDAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly Action<TResource>? ICKHNJNEMPF;

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x44E4830", Offset = "0x44E3A30", VA = "0x1844E4830")]
	public HKFPDOELIAM(int AOACOFFBGKJ = 0, [Optional] IEqualityComparer<TId>? PIJJHDMENIA, [Optional] Func<TId, CancellationToken, Task<TResource>>? GDKHEMBNCJB, [Optional] Action<TResource>? OJCIHCIBOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x44E3A50", Offset = "0x44E2C50", VA = "0x1844E3A50")]
	public HLPAFEMDGAE<Task<TResource>> EIAJMECLFBF(TId BEHEHKFONGA, [Optional] Func<TId, CancellationToken, Task<TResource>>? GDKHEMBNCJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x44E33A0", Offset = "0x44E25A0", VA = "0x1844E33A0")]
	private void DBEDJLLOLAG(Task<TResource> JPPEAAIELKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x44E3DA0", Offset = "0x44E2FA0", VA = "0x1844E3DA0")]
	[AsyncStateMachine(typeof(HKFPDOELIAM<, >.OEKLENLJHII))]
	private Task GBALFAOADBM(Task<TResource> JPPEAAIELKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x3ED75C0", Offset = "0x3ED67C0", VA = "0x183ED75C0")]
	public void FLGIMFFPCIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x44E3CB0", Offset = "0x44E2EB0", VA = "0x1844E3CB0")]
	public KNKKDCDAJEC<TId, Task<TResource>>.OANKHJCEBKB EMKBHPPGLAN()
	{
		return default(KNKKDCDAJEC<TId, Task<TResource>>.OANKHJCEBKB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x44E4660", Offset = "0x44E3860", VA = "0x1844E4660", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x44E4660", Offset = "0x44E3860", VA = "0x1844E4660", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x44E4400", Offset = "0x44E3600", VA = "0x1844E4400")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(HKFPDOELIAM<, >.KDOEMDAOCLF))]
	internal static Task KBKAFIGHCBO(Task<TResource> JPPEAAIELKB, CancellationTokenSource ANELJNLCOFI, Dictionary<Task<TResource>, CancellationTokenSource> PNEFIBDPNNM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class KNKKDCDAJEC<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private sealed class JPJMBODMKAA : IEquatable<JPJMBODMKAA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public readonly TValue ELOFPHHKCIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public int ADDPPLGOOMJ;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xFA8980", Offset = "0xFA7B80", VA = "0x180FA8980")]
		public JPJMBODMKAA(TValue OMEFCJCOLII, int KHEIFIBFKIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x484CEE0", Offset = "0x484C0E0", VA = "0x18484CEE0", Slot = "4")]
		public bool Equals(JPJMBODMKAA? JAINJPLCLDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x484CE40", Offset = "0x484C040", VA = "0x18484CE40", Slot = "0")]
		public override bool Equals(object? LCACGJDNDHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x484CF70", Offset = "0x484C170", VA = "0x18484CF70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public struct OANKHJCEBKB : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private Dictionary<TKey, JPJMBODMKAA>.Enumerator PIPGGKFBKEL;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x4D84540", Offset = "0x4D83740", VA = "0x184D84540", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public (TKey Key, TValue Value, int RefCount) AJGNMEAPLII
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x4D84AC0", Offset = "0x4D83CC0", VA = "0x184D84AC0", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x4D84800", Offset = "0x4D83A00", VA = "0x184D84800")]
		public OANKHJCEBKB(KNKKDCDAJEC<TKey, TValue> IMCKAINIGJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x4D841A0", Offset = "0x4D833A0", VA = "0x184D841A0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x4D84260", Offset = "0x4D83460", VA = "0x184D84260", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x4D843F0", Offset = "0x4D835F0", VA = "0x184D843F0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class FNDDBPDEIDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public KNKKDCDAJEC<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public JPJMBODMKAA refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public FNDDBPDEIDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x42F6A90", Offset = "0x42F5C90", VA = "0x1842F6A90")]
		internal void FDEFANFDIBF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly Dictionary<TKey, JPJMBODMKAA> OCJGBEPBJAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly Func<TKey, TValue>? FBABEDBJIHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly Action<TValue>? NBPKGOHBOKN;

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x494F730", Offset = "0x494E930", VA = "0x18494F730")]
	public KNKKDCDAJEC(int AOACOFFBGKJ = 0, [Optional] IEqualityComparer<TKey>? KJEPNKNBGIG, [Optional] Func<TKey, TValue>? FBBIBNJMPAF, [Optional] Action<TValue>? BBMNKGJFABC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x494DE30", Offset = "0x494D030", VA = "0x18494DE30")]
	public HLPAFEMDGAE<TValue> EIAJMECLFBF(TKey OFPBICPHALF, [Optional] Func<TKey, TValue>? IELANOOBFPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x494F310", Offset = "0x494E510", VA = "0x18494F310")]
	private void OIHANPNKAFH(TKey OFPBICPHALF, JPJMBODMKAA AMDDINFNMCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x494EFA0", Offset = "0x494E1A0", VA = "0x18494EFA0")]
	public void FLGIMFFPCIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x494EB00", Offset = "0x494DD00", VA = "0x18494EB00")]
	public OANKHJCEBKB EMKBHPPGLAN()
	{
		return default(OANKHJCEBKB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x494F5F0", Offset = "0x494E7F0", VA = "0x18494F5F0", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x494F5F0", Offset = "0x494E7F0", VA = "0x18494F5F0", Slot = "5")]
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
