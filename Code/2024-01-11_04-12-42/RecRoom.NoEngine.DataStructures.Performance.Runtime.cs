using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
		[Cpp2IlInjected.Address(RVA = "0x7BA380", Offset = "0x7B8D80", VA = "0x1807BA380")]
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
		[Cpp2IlInjected.Address(RVA = "0x60596B0", Offset = "0x60580B0", VA = "0x1860596B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7BA560", Offset = "0x7B8F60", VA = "0x1807BA560")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7BA5A0", Offset = "0x7B8FA0", VA = "0x1807BA5A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class ELGGMHENHLA
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x23AC940", Offset = "0x23AB340", VA = "0x1823AC940")]
	public static DPOHHDHGDIO<T> AADBCLFIEKE<T>(this T[] JFFAAHPEFOB) where T : notnull
	{
		return default(DPOHHDHGDIO<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class NHFLMFFCGCA<T> : IDisposable, OAKBNBJDFIK, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EFFJEOGHPGG<T> IJIBBIFNOGI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int MDLNLAAIONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3E5A560", Offset = "0x3E58F60", VA = "0x183E5A560", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T OBNEKGFINAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3E5A3A0", Offset = "0x3E58DA0", VA = "0x183E5A3A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3E5A440", Offset = "0x3E58E40", VA = "0x183E5A440")]
	public static NHFLMFFCGCA<T> KBFODEGLBLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x35D7A20", Offset = "0x35D6420", VA = "0x1835D7A20")]
	internal NHFLMFFCGCA([In] EFFJEOGHPGG<T> DPFABJBBFIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3E5A3D0", Offset = "0x3E58DD0", VA = "0x183E5A3D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3E5A380", Offset = "0x3E58D80", VA = "0x183E5A380")]
	public void DEHGFIBJMCE(int MPNHPMPEEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3E5A3F0", Offset = "0x3E58DF0", VA = "0x183E5A3F0", Slot = "8")]
	public EFFJEOGHPGG<T>.LKKKBANLJHN GetEnumerator()
	{
		return default(EFFJEOGHPGG<T>.LKKKBANLJHN);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3E5A590", Offset = "0x3E58F90", VA = "0x183E5A590", Slot = "6")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3E5A590", Offset = "0x3E58F90", VA = "0x183E5A590", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct NJAACNDOILB<T, U> : IEnumerable<T>, IEnumerable where U : EPLALAICFCJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U AELIGHNGCIJ;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1D04560", Offset = "0x1D02F60", VA = "0x181D04560")]
	internal NJAACNDOILB([In] U ACBJMLPNKCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7F92D0", Offset = "0x7F7CD0", VA = "0x1807F92D0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3A4DEA0", Offset = "0x3A4C8A0", VA = "0x183A4DEA0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3A4DEA0", Offset = "0x3A4C8A0", VA = "0x183A4DEA0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class NHNDCCLCOLH<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2431E40", Offset = "0x2430840", VA = "0x182431E40")]
	public static NJAACNDOILB<T, U> KBFODEGLBLG<U>([In] U JFFAAHPEFOB) where U : EPLALAICFCJ<T>
	{
		return default(NJAACNDOILB<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct PLBCNGKDOJO<TSourceEnumerator, TSource, TResult> : OAKBNBJDFIK, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : OAKBNBJDFIK, EPLALAICFCJ<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private TSourceEnumerator EFNAFAHGLCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly JBJPHBMEKMP<TSource, TResult> EOJECKDJOHP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public readonly int MDLNLAAIONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3DFC200", Offset = "0x3DFAC00", VA = "0x183DFC200", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public readonly TResult POOCAABBIHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x409E690", Offset = "0x409D090", VA = "0x18409E690", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x409E360", Offset = "0x409CD60", VA = "0x18409E360", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3BAC570", Offset = "0x3BAAF70", VA = "0x183BAC570")]
	internal PLBCNGKDOJO([In] TSourceEnumerator JFFAAHPEFOB, JBJPHBMEKMP<TSource, TResult> LDNKEKAJNKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3DFC2E0", Offset = "0x3DFACE0", VA = "0x183DFC2E0", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3DFC370", Offset = "0x3DFAD70", VA = "0x183DFC370", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3DFC1C0", Offset = "0x3DFABC0", VA = "0x183DFC1C0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct PNBLMENNDBH<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly U AELIGHNGCIJ;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x40A4340", Offset = "0x40A2D40", VA = "0x1840A4340")]
	internal PNBLMENNDBH([In] U ACBJMLPNKCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7F9270", Offset = "0x7F7C70", VA = "0x1807F9270", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x40A4160", Offset = "0x40A2B60", VA = "0x1840A4160", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x40A4160", Offset = "0x40A2B60", VA = "0x1840A4160", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class IMEIBPMMOME<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x21B7920", Offset = "0x21B6320", VA = "0x1821B7920")]
	public static PNBLMENNDBH<T, U> KBFODEGLBLG<U>([In] U JFFAAHPEFOB) where U : IEnumerator<T>
	{
		return default(PNBLMENNDBH<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct MPMBPHKKCEI<TSourceEnumerator, TSource, TResult> : OAKBNBJDFIK, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : OAKBNBJDFIK, IEnumerator<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private TSourceEnumerator EFNAFAHGLCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Func<TSource, TResult> EOJECKDJOHP;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public readonly int MDLNLAAIONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3DFC200", Offset = "0x3DFAC00", VA = "0x183DFC200", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public readonly TResult POOCAABBIHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3DFC4E0", Offset = "0x3DFAEE0", VA = "0x183DFC4E0", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3DFC3F0", Offset = "0x3DFADF0", VA = "0x183DFC3F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3BAC570", Offset = "0x3BAAF70", VA = "0x183BAC570")]
	internal MPMBPHKKCEI([In] TSourceEnumerator JFFAAHPEFOB, Func<TSource, TResult> LDNKEKAJNKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3DFC2E0", Offset = "0x3DFACE0", VA = "0x183DFC2E0", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3DFC370", Offset = "0x3DFAD70", VA = "0x183DFC370", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3DFC1C0", Offset = "0x3DFABC0", VA = "0x183DFC1C0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal static class MEPMFOAMFHN
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x26DE690", Offset = "0x26DD090", VA = "0x1826DE690")]
	public static string IEHMEIDBHKN<T>(this IEnumerable<T> JFFAAHPEFOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x26CFD80", Offset = "0x26CE780", VA = "0x1826CFD80")]
	public static string ECNKPLHEJJM<T>(this IEnumerable<T> JFFAAHPEFOB, string HDBLFAHEECA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class DHPCCNBCLEH
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2478AE0", Offset = "0x24774E0", VA = "0x182478AE0")]
	public static bool GNMEBCDCLFL<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator JFFAAHPEFOB, [In] TArgs BFAMAJEDCBA, [In] DKLNKFFLHNF<TArgs, TSource, bool> CHOCJCHMMOG) where TSourceEnumerator : EPLALAICFCJ<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x24786E0", Offset = "0x24770E0", VA = "0x1824786E0")]
	public static int DGMOHGAENKH<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator JFFAAHPEFOB, [In] TArgs BFAMAJEDCBA, DKLNKFFLHNF<TArgs, TSource, bool> CHOCJCHMMOG) where TSourceEnumerator : EPLALAICFCJ<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2478C70", Offset = "0x2477670", VA = "0x182478C70")]
	public static bool KCEKHKOFKNB<TSourceEnumerator, TSource>(this TSourceEnumerator JFFAAHPEFOB, [In] TSource PPIDKPHGGGP) where TSourceEnumerator : EPLALAICFCJ<TSource> where TSource : DECBLHBCBCN<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2478950", Offset = "0x2477350", VA = "0x182478950")]
	public static int EBJCFBDFKJK<TSourceEnumerator, TSource>(this TSourceEnumerator JFFAAHPEFOB, [In] TSource BEEGCHJLJFC) where TSourceEnumerator : EPLALAICFCJ<TSource> where TSource : DECBLHBCBCN<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2478680", Offset = "0x2477080", VA = "0x182478680")]
	public static PLBCNGKDOJO<TSourceEnumerator, TSource, TResult> BOJGCDMPMOM<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator JFFAAHPEFOB, JBJPHBMEKMP<TSource, TResult> LDNKEKAJNKL) where TSourceEnumerator : OAKBNBJDFIK, EPLALAICFCJ<TSource>
	{
		return default(PLBCNGKDOJO<TSourceEnumerator, TSource, TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2478680", Offset = "0x2477080", VA = "0x182478680")]
	public static MPMBPHKKCEI<TSourceEnumerator, TSource, TResult> EGPEINOLBIK<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator JFFAAHPEFOB, Func<TSource, TResult> LDNKEKAJNKL) where TSourceEnumerator : OAKBNBJDFIK, IEnumerator<TSource>
	{
		return default(MPMBPHKKCEI<TSourceEnumerator, TSource, TResult>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class HENKKAPBIIH<T>
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2F23570", Offset = "0x2F21F70", VA = "0x182F23570")]
	public static bool MONMBCLOHNH<TSourceEnumerator>(TSourceEnumerator JFFAAHPEFOB) where TSourceEnumerator : IEnumerator<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2F23440", Offset = "0x2F21E40", VA = "0x182F23440")]
	public static T EMFFIADFEEF<TSourceEnumerator>(TSourceEnumerator JFFAAHPEFOB) where TSourceEnumerator : EPLALAICFCJ<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2F21190", Offset = "0x2F1FB90", VA = "0x182F21190")]
	public static T[] BMFBFEIKJAL<TSourceEnumerator>(TSourceEnumerator JFFAAHPEFOB) where TSourceEnumerator : OAKBNBJDFIK, IEnumerator<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2F1F690", Offset = "0x2F1E090", VA = "0x182F1F690")]
	public static T BEPHCFGHBGB<TSourceEnumerator>(TSourceEnumerator JFFAAHPEFOB) where TSourceEnumerator : IEnumerator<T>
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface EPLALAICFCJ<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	T POOCAABBIHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface OAKBNBJDFIK
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	int MDLNLAAIONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface POMLJBJEPDL<T> : EPLALAICFCJ<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public readonly struct JLDKCOOOLDE<T, U> : IEnumerable<T>, IEnumerable where U : POMLJBJEPDL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly U AELIGHNGCIJ;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3A4DFB0", Offset = "0x3A4C9B0", VA = "0x183A4DFB0")]
	internal JLDKCOOOLDE([In] U ACBJMLPNKCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x32F8340", Offset = "0x32F6D40", VA = "0x1832F8340", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3A4DF20", Offset = "0x3A4C920", VA = "0x183A4DF20", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3A4DF20", Offset = "0x3A4C920", VA = "0x183A4DF20", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class GPGLFCIMCNN<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2431E70", Offset = "0x2430870", VA = "0x182431E70")]
	public static JLDKCOOOLDE<T, U> KBFODEGLBLG<U>([In] U JFFAAHPEFOB) where U : POMLJBJEPDL<T>
	{
		return default(JLDKCOOOLDE<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public readonly struct DPOHHDHGDIO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct FFDGEAEEPGA : OAKBNBJDFIK, EPLALAICFCJ<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] EFNAFAHGLCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int GMBDMPPMAHN;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public readonly int MDLNLAAIONI
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x1D11030", Offset = "0x1D0FA30", VA = "0x181D11030", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public readonly T POOCAABBIHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x35BEF40", Offset = "0x35BD940", VA = "0x1835BEF40", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x35BE990", Offset = "0x35BD390", VA = "0x1835BE990", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x35BEDF0", Offset = "0x35BD7F0", VA = "0x1835BEDF0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x179EA50", Offset = "0x179D450", VA = "0x18179EA50")]
		private FFDGEAEEPGA(T[] JFFAAHPEFOB, int BNALCEABILL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x35BE7D0", Offset = "0x35BD1D0", VA = "0x1835BE7D0")]
		public static FFDGEAEEPGA KBFODEGLBLG(T[] JFFAAHPEFOB)
		{
			return default(FFDGEAEEPGA);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x1D11050", Offset = "0x1D0FA50", VA = "0x181D11050", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1D11080", Offset = "0x1D0FA80", VA = "0x181D11080", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly T[] CIIMGPOHBKJ;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int PPDKOADJGPD
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1D11030", Offset = "0x1D0FA30", VA = "0x181D11030")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T OBNEKGFINAA
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x244E7F0", Offset = "0x244D1F0", VA = "0x18244E7F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8C16C0", Offset = "0x8C00C0", VA = "0x1808C16C0")]
	internal DPOHHDHGDIO(T[] BHNHFMPCKPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4F793B0", Offset = "0x4F77DB0", VA = "0x184F793B0")]
	public static DPOHHDHGDIO<T> DPEMCFFPABG()
	{
		return default(DPOHHDHGDIO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7F9270", Offset = "0x7F7C70", VA = "0x1807F9270")]
	public IEnumerable<T> NOGGOIENGFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4F79470", Offset = "0x4F77E70", VA = "0x184F79470")]
	public ReadOnlySpan<T> GBNKGJOFFCE()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4F79590", Offset = "0x4F77F90", VA = "0x184F79590")]
	public NJAACNDOILB<T, DPOHHDHGDIO<T>.FFDGEAEEPGA> OANMFHBAGFB()
	{
		return default(NJAACNDOILB<T, FFDGEAEEPGA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4F79500", Offset = "0x4F77F00", VA = "0x184F79500")]
	public FFDGEAEEPGA NBEDJLONDGI()
	{
		return default(FFDGEAEEPGA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4F79330", Offset = "0x4F77D30", VA = "0x184F79330")]
	public IEnumerator<T> DHCNIOBIIDB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4F796B0", Offset = "0x4F780B0", VA = "0x184F796B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class GDGMFHKCGLK
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x23AC9A0", Offset = "0x23AB3A0", VA = "0x1823AC9A0")]
	public static DPOHHDHGDIO<T> OBEEAMHEGIB<T>(params T[] BHNHFMPCKPL) where T : notnull
	{
		return default(DPOHHDHGDIO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6059650", Offset = "0x6058050", VA = "0x186059650")]
	public static Stream PPPKGJJNILO(this DPOHHDHGDIO<byte> JFFAAHPEFOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DebuggerTypeProxy(typeof(EFFJEOGHPGG<>.EIAAEKJKGJH))]
public struct EFFJEOGHPGG<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public struct LKKKBANLJHN : OAKBNBJDFIK, POMLJBJEPDL<T>, EPLALAICFCJ<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly T[] NBJEEPGFGJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly int ILKMAMPBPJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int GMBDMPPMAHN;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public readonly int MDLNLAAIONI
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x1D2A090", Offset = "0x1D28A90", VA = "0x181D2A090", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public readonly T POOCAABBIHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x3BEE050", Offset = "0x3BECA50", VA = "0x183BEE050", Slot = "11")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private readonly T KLJFEOKKNCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x3BEDF20", Offset = "0x3BEC920", VA = "0x183BEDF20", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x3BEDF70", Offset = "0x3BEC970", VA = "0x183BEDF70", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x3BEDFC0", Offset = "0x3BEC9C0", VA = "0x183BEDFC0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1D10F70", Offset = "0x1D0F970", VA = "0x181D10F70")]
		internal LKKKBANLJHN(T[] KGDPBJHHKON, int MPNHPMPEEBM, int BNALCEABILL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3BEDEC0", Offset = "0x3BEC8C0", VA = "0x183BEDEC0")]
		public static LKKKBANLJHN KBFODEGLBLG(EFFJEOGHPGG<T> JFFAAHPEFOB)
		{
			return default(LKKKBANLJHN);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x32B9440", Offset = "0x32B7E40", VA = "0x1832B9440", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1D10F10", Offset = "0x1D0F910", VA = "0x181D10F10", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct DJGENCPPMEO : OAKBNBJDFIK, EPLALAICFCJ<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private LKKKBANLJHN AELIGHNGCIJ;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public int MDLNLAAIONI
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x4F67770", Offset = "0x4F66170", VA = "0x184F67770", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public readonly T POOCAABBIHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x4F67BE0", Offset = "0x4F665E0", VA = "0x184F67BE0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x4F67820", Offset = "0x4F66220", VA = "0x184F67820", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x4F67AB0", Offset = "0x4F664B0", VA = "0x184F67AB0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1D04560", Offset = "0x1D02F60", VA = "0x181D04560")]
		private DJGENCPPMEO([In] LKKKBANLJHN ACBJMLPNKCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4F676C0", Offset = "0x4F660C0", VA = "0x184F676C0")]
		public static DJGENCPPMEO KBFODEGLBLG([In] EFFJEOGHPGG<T> JFFAAHPEFOB)
		{
			return default(DJGENCPPMEO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4F677A0", Offset = "0x4F661A0", VA = "0x184F677A0", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4F677E0", Offset = "0x4F661E0", VA = "0x184F677E0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x4F67680", Offset = "0x4F66080", VA = "0x184F67680", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public sealed class EIAAEKJKGJH
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	internal T[] NBJEEPGFGJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal int ILKMAMPBPJG;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3245210", Offset = "0x3243C10", VA = "0x183245210")]
	public static EFFJEOGHPGG<T> KBFODEGLBLG()
	{
		return default(EFFJEOGHPGG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3245100", Offset = "0x3243B00", VA = "0x183245100")]
	public static EFFJEOGHPGG<T> ILPINKIHACO(int HCAPAJGPPGD)
	{
		return default(EFFJEOGHPGG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3244FF0", Offset = "0x32439F0", VA = "0x183244FF0")]
	public static EFFJEOGHPGG<T> AJBBDKJLCBC(int MPNHPMPEEBM)
	{
		return default(EFFJEOGHPGG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x179EA50", Offset = "0x179D450", VA = "0x18179EA50")]
	internal EFFJEOGHPGG(T[] KGDPBJHHKON, int MPNHPMPEEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3245320", Offset = "0x3243D20", VA = "0x183245320", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class JBPPOCBBGJN
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2656B70", Offset = "0x2655570", VA = "0x182656B70")]
	public static void MMELNECKPAK<T>(this EFFJEOGHPGG<T> JFFAAHPEFOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x26522E0", Offset = "0x2650CE0", VA = "0x1826522E0")]
	public static string GDPHKGIPAGG<T>([In] this EFFJEOGHPGG<T> JFFAAHPEFOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7F9270", Offset = "0x7F7C70", VA = "0x1807F9270")]
	public static T[] PEFJLMDBLEG<T>([In] this EFFJEOGHPGG<T> JFFAAHPEFOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x26516A0", Offset = "0x26500A0", VA = "0x1826516A0")]
	public static T DKMKPEOPLDE<T>([In] this EFFJEOGHPGG<T> JFFAAHPEFOB, int HLIHAMMEEIJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x26516A0", Offset = "0x26500A0", VA = "0x1826516A0")]
	public static T GHLDOFFOILL<T>(this EFFJEOGHPGG<T> JFFAAHPEFOB, int HLIHAMMEEIJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2651960", Offset = "0x2650360", VA = "0x182651960")]
	public static T FJDIKIHBMCN<T>([In] this EFFJEOGHPGG<T> JFFAAHPEFOB, int HLIHAMMEEIJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2656C40", Offset = "0x2655640", VA = "0x182656C40")]
	public static void OGNHOBPFCBA<T>(this EFFJEOGHPGG<T> JFFAAHPEFOB, int HLIHAMMEEIJ, [In] T BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x26511A0", Offset = "0x264FBA0", VA = "0x1826511A0")]
	public static void DGKBMAEBPKK<T>(this EFFJEOGHPGG<T> JFFAAHPEFOB, int HLIHAMMEEIJ, T BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1D2A090", Offset = "0x1D28A90", VA = "0x181D2A090")]
	public static int KGEAHABPDOH<T>([In] this EFFJEOGHPGG<T> JFFAAHPEFOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2651C00", Offset = "0x2650600", VA = "0x182651C00")]
	public static ReadOnlySpan<T> GBNKGJOFFCE<T>([In] this EFFJEOGHPGG<T> JFFAAHPEFOB)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2651AD0", Offset = "0x26504D0", VA = "0x182651AD0")]
	public static T[] GBLEDEEIKJG<T>([In] this EFFJEOGHPGG<T> JFFAAHPEFOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x264FAF0", Offset = "0x264E4F0", VA = "0x18264FAF0")]
	public static T[] ANABCDEMKOF<T>(this EFFJEOGHPGG<T> JFFAAHPEFOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2651CD0", Offset = "0x26506D0", VA = "0x182651CD0")]
	public static DPOHHDHGDIO<T> GDOOHFEMJGE<T>(this EFFJEOGHPGG<T> JFFAAHPEFOB)
	{
		return default(DPOHHDHGDIO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2651350", Offset = "0x264FD50", VA = "0x182651350")]
	public static void DGLLAPEBOKO<T>(this EFFJEOGHPGG<T> JFFAAHPEFOB, [In] T BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2656A40", Offset = "0x2655440", VA = "0x182656A40")]
	public static void MENDHGLBONK<T>(this EFFJEOGHPGG<T> JFFAAHPEFOB, T BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2653D40", Offset = "0x2652740", VA = "0x182653D40")]
	public static void HCCAAAAGJHH<T>(this EFFJEOGHPGG<T> JFFAAHPEFOB, int BNALCEABILL, [In] T BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2654040", Offset = "0x2652A40", VA = "0x182654040")]
	public static void KJPPONJPONA<T>(this EFFJEOGHPGG<T> JFFAAHPEFOB, int BNALCEABILL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2657240", Offset = "0x2655C40", VA = "0x182657240")]
	public static T ONGHGDJGJIH<T>(this EFFJEOGHPGG<T> JFFAAHPEFOB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x264FF20", Offset = "0x264E920", VA = "0x18264FF20")]
	public static void DEHGFIBJMCE<T>(this EFFJEOGHPGG<T> JFFAAHPEFOB, int MPNHPMPEEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2654480", Offset = "0x2652E80", VA = "0x182654480")]
	private static void KMEDPOMMBKE<T>(this EFFJEOGHPGG<T> JFFAAHPEFOB, int HCAPAJGPPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2653F20", Offset = "0x2652920", VA = "0x182653F20")]
	public static void JOBLGFAFDNE<T>(this EFFJEOGHPGG<T> JFFAAHPEFOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x264FB70", Offset = "0x264E570", VA = "0x18264FB70")]
	public static bool BKHMMHCHOKL<T>(this EFFJEOGHPGG<T> JFFAAHPEFOB, [In] T BEEGCHJLJFC) where T : DECBLHBCBCN<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2654030", Offset = "0x2652A30", VA = "0x182654030")]
	public static bool KHGKOOPGFIJ<T>([In] this EFFJEOGHPGG<T> JFFAAHPEFOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2653E70", Offset = "0x2652870", VA = "0x182653E70")]
	public static bool IPMBHLJEEME<T>([In] this EFFJEOGHPGG<T> JFFAAHPEFOB, int HLIHAMMEEIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x23AC7A0", Offset = "0x23AB1A0", VA = "0x1823AC7A0")]
	public static EFFJEOGHPGG<T>.DJGENCPPMEO DHCNIOBIIDB<T>([In] this EFFJEOGHPGG<T> JFFAAHPEFOB)
	{
		return default(EFFJEOGHPGG<T>.DJGENCPPMEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x23AC7A0", Offset = "0x23AB1A0", VA = "0x1823AC7A0")]
	public static EFFJEOGHPGG<T>.LKKKBANLJHN PPHELMNAIFM<T>(this EFFJEOGHPGG<T> JFFAAHPEFOB)
	{
		return default(EFFJEOGHPGG<T>.LKKKBANLJHN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x23AC6C0", Offset = "0x23AB0C0", VA = "0x1823AC6C0")]
	public static NJAACNDOILB<T, EFFJEOGHPGG<T>.DJGENCPPMEO> KPDAPACPOJO<T>([In] this EFFJEOGHPGG<T> JFFAAHPEFOB)
	{
		return default(NJAACNDOILB<T, EFFJEOGHPGG<T>.DJGENCPPMEO>);
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
