using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Google.Protobuf;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Properties;
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
		[Cpp2IlInjected.Address(RVA = "0x80EA90", Offset = "0x80D290", VA = "0x18080EA90")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x80EA90", Offset = "0x80D290", VA = "0x18080EA90")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Unity.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class EntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6AF1DE0", Offset = "0x6AF05E0", VA = "0x186AF1DE0")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct CLPGDLLPIEG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly byte[] NLANKBLAOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly MemoryStream NEOJHOCIJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly CodedOutputStream NHDIPDECGDG;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6AF1130", Offset = "0x6AEF930", VA = "0x186AF1130", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct GHECFKONFHA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly MemoryStream NEOJHOCIJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CodedInputStream PCHHOMMBOGI;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6AF2600", Offset = "0x6AF0E00", VA = "0x186AF2600", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct PGLAGHJANGJ<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class OPGKAGIBAJJ : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public global::PGLAGHJANGJ<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int <i>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private Protobuf <element>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8CDE30", Offset = "0x8CC630", VA = "0x1808CDE30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x3FEFD10", Offset = "0x3FEE510", VA = "0x183FEFD10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2874D80", Offset = "0x2873580", VA = "0x182874D80")]
		[DebuggerHidden]
		public OPGKAGIBAJJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3FEFB20", Offset = "0x3FEE320", VA = "0x183FEFB20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3FEFCD0", Offset = "0x3FEE4D0", VA = "0x183FEFCD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly Action<Protobuf> GCGGKDKNPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly MemoryStream NEOJHOCIJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CodedInputStream PCHHOMMBOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Protobuf JNADKFFEIOO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly int PJKEDAIIMDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x80ECA0", Offset = "0x80D4A0", VA = "0x18080ECA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3D4E6A0", Offset = "0x3D4CEA0", VA = "0x183D4E6A0")]
	private PGLAGHJANGJ(byte[] NLANKBLAOCO, Action<Protobuf> GCGGKDKNPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x37621C0", Offset = "0x37609C0", VA = "0x1837621C0")]
	public static global::PGLAGHJANGJ<Protobuf> JLAKJAPJOGA<Data>(ReadOnlySpan<byte> KNJBCHEFCED, ReadOnlySpan<Data> CHCFPJJJGHE, Action<Protobuf> GCGGKDKNPNA)
	{
		return default(global::PGLAGHJANGJ<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3D4E510", Offset = "0x3D4CD10", VA = "0x183D4E510", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3D4E550", Offset = "0x3D4CD50", VA = "0x183D4E550", Slot = "4")]
	[IteratorStateMachine(typeof(global::PGLAGHJANGJ<>.OPGKAGIBAJJ))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3D4E650", Offset = "0x3D4CE50", VA = "0x183D4E650", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct HOEKDGLKAAO<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly byte[] NLANKBLAOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly Protobuf JNADKFFEIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly MemoryStream NEOJHOCIJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly CodedOutputStream NHDIPDECGDG;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x358AD30", Offset = "0x3589530", VA = "0x18358AD30")]
	private HOEKDGLKAAO(byte[] NLANKBLAOCO, in Protobuf JNADKFFEIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x41C14C0", Offset = "0x41BFCC0", VA = "0x1841C14C0")]
	public static global::HOEKDGLKAAO<Protobuf> JLAKJAPJOGA<T>(ReadOnlySpan<T> CHCFPJJJGHE)
	{
		return default(global::HOEKDGLKAAO<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x358AD00", Offset = "0x3589500", VA = "0x18358AD00")]
	public void LGBBBNEBCGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x358AC70", Offset = "0x3589470", VA = "0x18358AC70")]
	public ByteString GBLNIBAJACB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x358AB40", Offset = "0x3589340", VA = "0x18358AB40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class OFALOACMNEH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class PCDHLENLLMJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static T ECNGHFJBIJL;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static bool NHOHANJCEON;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x409B960", Offset = "0x409A160", VA = "0x18409B960")]
		public static void LEAMKENGDJN(in T PHMLIFLNFDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public PCDHLENLLMJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static readonly MFFHLJHLBIG HGFFDKCANPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NativeHashMap<OFOKJFCNBJJ, int2> IEANJGPBNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private NativeList<byte> NLANKBLAOCO;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6AF79A0", Offset = "0x6AF61A0", VA = "0x186AF79A0")]
	public OFALOACMNEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x23C3BB0", Offset = "0x23C23B0", VA = "0x1823C3BB0")]
	public void OLBGCODNBJK<T>(T ECNGHFJBIJL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x23C57D0", Offset = "0x23C3FD0", VA = "0x1823C57D0")]
	public T PNBJHLBKMLC<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6AF75A0", Offset = "0x6AF5DA0", VA = "0x186AF75A0")]
	public void OLBGCODNBJK(Type FIJCKHKKDCC, CCENOJCALNE ECNGHFJBIJL, int KPLFNABLLDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6AF7770", Offset = "0x6AF5F70", VA = "0x186AF7770")]
	public bool PFLIDDOFNIB(Type FIJCKHKKDCC, out CCENOJCALNE PHBHEFAPHDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6AF7840", Offset = "0x6AF6040", VA = "0x186AF7840")]
	public CCENOJCALNE PNBJHLBKMLC(Type FIJCKHKKDCC)
	{
		return default(CCENOJCALNE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6AF7200", Offset = "0x6AF5A00", VA = "0x186AF7200")]
	public NativeArray<byte>.ReadOnly HNLDJCACBNM(Type FIJCKHKKDCC)
	{
		return default(NativeArray<byte>.ReadOnly);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6AF7410", Offset = "0x6AF5C10", VA = "0x186AF7410")]
	public bool NAFOHKNGFLD(Type FIJCKHKKDCC, out NativeArray<byte>.ReadOnly PHBHEFAPHDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6AF6F70", Offset = "0x6AF5770", VA = "0x186AF6F70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6AF7010", Offset = "0x6AF5810", VA = "0x186AF7010", Slot = "1")]
	~OFALOACMNEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6AF7130", Offset = "0x6AF5930", VA = "0x186AF7130")]
	private NativeArray<byte>.ReadOnly GAICDDNAGJF(int2 JGKPELLEJDE)
	{
		return default(NativeArray<byte>.ReadOnly);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct BAGKINIFOEG<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T MHGNIJCIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4824E70", Offset = "0x4823670", VA = "0x184824E70")]
		get
		{
			return (T)null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4828710", Offset = "0x4826F10", VA = "0x184828710")]
	public static global::BAGKINIFOEG<T> DGIADCHILCD(T ECNGHFJBIJL)
	{
		return default(global::BAGKINIFOEG<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x48262B0", Offset = "0x4824AB0", VA = "0x1848262B0")]
	public static T DGIADCHILCD(global::BAGKINIFOEG<T> IGBKLJLDCLC)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class GHICCDAMBOO
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static OFALOACMNEH KFFGIOGIGMI;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x30B6EC0", Offset = "0x30B56C0", VA = "0x1830B6EC0")]
	public static void OLBGCODNBJK<T>(T ECNGHFJBIJL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x30B80D0", Offset = "0x30B68D0", VA = "0x1830B80D0")]
	public static T PNBJHLBKMLC<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6AF2640", Offset = "0x6AF0E40", VA = "0x186AF2640")]
	public static NativeArray<byte>.ReadOnly HNLDJCACBNM(Type FIJCKHKKDCC)
	{
		return default(NativeArray<byte>.ReadOnly);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6AF26D0", Offset = "0x6AF0ED0", VA = "0x186AF26D0")]
	public static bool PFLIDDOFNIB(Type FIJCKHKKDCC, out CCENOJCALNE PHBHEFAPHDL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct DFGMPCKANBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int MCMFGBNCCMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int FGHOJPFDCIA;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int OIABMDMAMBN
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x95A520", Offset = "0x958D20", VA = "0x18095A520")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int PLEPIEDOEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xB83B10", Offset = "0xB82310", VA = "0x180B83B10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x10CDBC0", Offset = "0x10CC3C0", VA = "0x1810CDBC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int FGLOEBEFDGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x95A520", Offset = "0x958D20", VA = "0x18095A520")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9E26F0", Offset = "0x9E0EF0", VA = "0x1809E26F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int FGKHEPONKIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6AF12F0", Offset = "0x6AEFAF0", VA = "0x186AF12F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6AF1300", Offset = "0x6AEFB00", VA = "0x186AF1300")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x83CF30", Offset = "0x83B730", VA = "0x18083CF30")]
	private DFGMPCKANBL(int MCMFGBNCCMI, int FGHOJPFDCIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3C84330", Offset = "0x3C82B30", VA = "0x183C84330")]
	public static DFGMPCKANBL AKNOMGKADJH(int MCMFGBNCCMI, int FGHOJPFDCIA)
	{
		return default(DFGMPCKANBL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6AF1310", Offset = "0x6AEFB10", VA = "0x186AF1310")]
	public static DFGMPCKANBL NNFPOLINMML(int DBEIIGKEBIB, int NBBICLPHKEO)
	{
		return default(DFGMPCKANBL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6AF1320", Offset = "0x6AEFB20", VA = "0x186AF1320", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct ENKBJEIDMMK : global::JIALLIDJLOI<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6AF1D60", Offset = "0x6AF0560", VA = "0x186AF1D60")]
	public float IAODJDJKLAM(in float3 ECNGHFJBIJL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6AF1D60", Offset = "0x6AF0560", VA = "0x186AF1D60", Slot = "4")]
	private float FDEFLDLLALD(in float3 ECNGHFJBIJL)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct FNIHMCODPEE : global::JIALLIDJLOI<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6AF2510", Offset = "0x6AF0D10", VA = "0x186AF2510")]
	public float IAODJDJKLAM(in float3 ECNGHFJBIJL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6AF2510", Offset = "0x6AF0D10", VA = "0x186AF2510", Slot = "4")]
	private float FDEFLDLLALD(in float3 ECNGHFJBIJL)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct FHGIAEHDJGC : global::JIALLIDJLOI<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x18BC210", Offset = "0x18BAA10", VA = "0x1818BC210")]
	public float IAODJDJKLAM(in float3 ECNGHFJBIJL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x18BC210", Offset = "0x18BAA10", VA = "0x1818BC210", Slot = "4")]
	private float FDEFLDLLALD(in float3 ECNGHFJBIJL)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct POAPEMNACGB : global::JIALLIDJLOI<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x109FDB0", Offset = "0x109E5B0", VA = "0x18109FDB0")]
	public int IAODJDJKLAM(in int3 ECNGHFJBIJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x109FDB0", Offset = "0x109E5B0", VA = "0x18109FDB0", Slot = "4")]
	private int OLEOFPHANIO(in int3 ECNGHFJBIJL)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct MEJHLFPGBNK : global::JIALLIDJLOI<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6726FA0", Offset = "0x67257A0", VA = "0x186726FA0")]
	public int IAODJDJKLAM(in int3 ECNGHFJBIJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6726FA0", Offset = "0x67257A0", VA = "0x186726FA0", Slot = "4")]
	private int OLEOFPHANIO(in int3 ECNGHFJBIJL)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct DOMHBDKABAP : global::JIALLIDJLOI<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x249F130", Offset = "0x249D930", VA = "0x18249F130")]
	public int IAODJDJKLAM(in int3 ECNGHFJBIJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x249F130", Offset = "0x249D930", VA = "0x18249F130", Slot = "4")]
	private int OLEOFPHANIO(in int3 ECNGHFJBIJL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[BurstCompile]
internal struct CAKPLOOMJID : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public ComponentDataFromEntity PAKMJKKODEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	[ReadOnly]
	public NativeArray<Entity> NEDOPJDBOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeList<Entity> ILLPLEPAJNI;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6AF10A0", Offset = "0x6AEF8A0", VA = "0x186AF10A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface HJLOAJDGIBN
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Type CANAHDLDIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Type[] BGKIMDFKKNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class AFEABPHNIHP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly World GPEEKLGBDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly World PLGEJIGAIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly PGDOKNDMILI CPIEKHBBHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly ComponentSystemGroup[] CJGHDKIGFAL;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public World NPOEHFOMAKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x85D1E0", Offset = "0x85B9E0", VA = "0x18085D1E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public World HGMOJEBDBNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public EntityManager EHBCKOIMEPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6AEFC90", Offset = "0x6AEE490", VA = "0x186AEFC90")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public PGDOKNDMILI IOEFOKHCAJD
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8ACF00", Offset = "0x8AB700", VA = "0x1808ACF00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public global::BFJGLKGJIEH<DGLDCDLCECP> FIOMNDALOBN
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7F2A40", Offset = "0x7F1240", VA = "0x1807F2A40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x919F90", Offset = "0x918790", VA = "0x180919F90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public global::BFJGLKGJIEH<MFCOBEFGBOI> GMLDEHHIHCF
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7F3660", Offset = "0x7F1E60", VA = "0x1807F3660")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8B4920", Offset = "0x8B3120", VA = "0x1808B4920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public global::BFJGLKGJIEH<AKKNCOHCIBK> IHDJMOOJEKC
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7F51E0", Offset = "0x7F39E0", VA = "0x1807F51E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8B4930", Offset = "0x8B3130", VA = "0x1808B4930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public World.NoAllocReadOnlyCollection<ComponentSystemBase> DJFECEFGDAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3466220", Offset = "0x3464A20", VA = "0x183466220")]
		get
		{
			return default(World.NoAllocReadOnlyCollection<ComponentSystemBase>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public ComponentSystemGroup[] OMPKIAOLEMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7F2CE0", Offset = "0x7F14E0", VA = "0x1807F2CE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6AEF8D0", Offset = "0x6AEE0D0", VA = "0x186AEF8D0")]
	public static AFEABPHNIHP DMJMIMLAFKK(string BPOKAAOBIOI, LNGKPFAGLPC BJCAHHPNCBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0190", Offset = "0x6AEE990", VA = "0x186AF0190")]
	public AFEABPHNIHP(string BPOKAAOBIOI, LNGKPFAGLPC BJCAHHPNCBK = LNGKPFAGLPC.Simulation, PACEBIKNHGA MDFPINHICMD = PACEBIKNHGA.Default, bool HCKNDFMIDDI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6AEFEE0", Offset = "0x6AEE6E0", VA = "0x186AEFEE0")]
	public ComponentSystemBase KHHDMEMKEDJ(Type FIJCKHKKDCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1C41010", Offset = "0x1C3F810", VA = "0x181C41010")]
	public T KHHDMEMKEDJ<T>() where T : ComponentSystemBase
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6AEF870", Offset = "0x6AEE070", VA = "0x186AEF870")]
	public void DCKJOFGAPLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6AEFCB0", Offset = "0x6AEE4B0", VA = "0x186AEFCB0")]
	public void GIACMDIKOIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0050", Offset = "0x6AEE850", VA = "0x186AF0050")]
	public void PGDHBFKNGNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6AEFF00", Offset = "0x6AEE700", VA = "0x186AEFF00")]
	public void KNIMMGCFILF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6AEFE80", Offset = "0x6AEE680", VA = "0x186AEFE80")]
	public void JJNLLMFNELN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6AEFE20", Offset = "0x6AEE620", VA = "0x186AEFE20")]
	public void HKOIOEAKGFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6AEF730", Offset = "0x6AEDF30", VA = "0x186AEF730")]
	public void AKENMPCLMGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6AEFF60", Offset = "0x6AEE760", VA = "0x186AEFF60")]
	public void LCAKHHGPIIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6AEF810", Offset = "0x6AEE010", VA = "0x186AEF810")]
	public void BBHKPPJGGFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6AEFFF0", Offset = "0x6AEE7F0", VA = "0x186AEFFF0")]
	public void NLGPPFHEBBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6AF00B0", Offset = "0x6AEE8B0", VA = "0x186AF00B0")]
	internal void PNFOINLDGBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6AEF790", Offset = "0x6AEDF90", VA = "0x186AEF790")]
	private bool ALEFOKBFGFM(ComponentSystemGroup JDPPDHMPNHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6AEF9C0", Offset = "0x6AEE1C0", VA = "0x186AEF9C0")]
	private void ELNAGHBBCAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6AEFD10", Offset = "0x6AEE510", VA = "0x186AEFD10")]
	private ComponentSystemGroup[] HDEMIFJCDLH(PACEBIKNHGA MDFPINHICMD, bool IBDLFJOOKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6AEF950", Offset = "0x6AEE150", VA = "0x186AEF950", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class MOEGJNFINMG
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6AF6C90", Offset = "0x6AF5490", VA = "0x186AF6C90")]
	[MustUseReturnValue]
	public static JobHandle ACLJCEMAKJG(this EntityCommandBufferSystem PPANIHNCFCJ, NativeList<Entity> FPMGLBFKKPO, [Optional] JobHandle NPBMDGDOAPE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6AF6E20", Offset = "0x6AF5620", VA = "0x186AF6E20")]
	[MustUseReturnValue]
	public static JobHandle ACLJCEMAKJG(this EntityCommandBufferSystem PPANIHNCFCJ, NativeArrayAsync<Entity> FPMGLBFKKPO)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class AOPAFKLEOEK
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2BBEDD0", Offset = "0x2BBD5D0", VA = "0x182BBEDD0")]
	public static void PGBDIAMPABG<T>(this EntityCommandBufferSystem PPANIHNCFCJ, EntityQuery DPBAMGMJJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2BBED10", Offset = "0x2BBD510", VA = "0x182BBED10")]
	[MustUseReturnValue]
	public static JobHandle OPNCEBPJOEE<T>(this EntityCommandBufferSystem PPANIHNCFCJ, NativeListAsync<Entity> FPMGLBFKKPO, [Optional] JobHandle NPBMDGDOAPE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2BBE590", Offset = "0x2BBCD90", VA = "0x182BBE590")]
	[MustUseReturnValue]
	public static JobHandle OPNCEBPJOEE<T>(this EntityCommandBufferSystem PPANIHNCFCJ, NativeArrayAsync<Entity> FPMGLBFKKPO, [Optional] JobHandle NPBMDGDOAPE)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[Preserve]
public class PGDOKNDMILI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly AFEABPHNIHP GPEEKLGBDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly EntityManager LMJGFJDJJLA;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public AFEABPHNIHP NPOEHFOMAKE
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x85D1E0", Offset = "0x85B9E0", VA = "0x18085D1E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6AF7F10", Offset = "0x6AF6710", VA = "0x186AF7F10")]
	public PGDOKNDMILI(AFEABPHNIHP GPEEKLGBDDJ, EntityManager LMJGFJDJJLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x23D7510", Offset = "0x23D5D10", VA = "0x1823D7510")]
	public bool MDBBGOOJDFA<T>(Entity CMBJDMJHALL) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x23D7550", Offset = "0x23D5D50", VA = "0x1823D7550")]
	public bool MOFPCFDEKAK<T>(Entity CMBJDMJHALL, out T ECNGHFJBIJL) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x23D59C0", Offset = "0x23D41C0", VA = "0x1823D59C0")]
	public T LMPKJKBGPGN<T>(Entity CMBJDMJHALL) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x23D5140", Offset = "0x23D3940", VA = "0x1823D5140")]
	private ComponentType CKIBMPCHEKG<T>() where T : struct, IComponent
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6AF7D80", Offset = "0x6AF6580", VA = "0x186AF7D80")]
	private ComponentType CKIBMPCHEKG(Type FIJCKHKKDCC)
	{
		return default(ComponentType);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class IAHFBHKPJHO
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct AIAPOMFOFJA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public Allocator FKPADLBILGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public NativeArray<Entity> LLGGJAOAAFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public NativeArray<T> BNKBFBBHHCL;
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct MLIHFLIOFHK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public Allocator FKPADLBILGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public NativeList<Entity> LLGGJAOAAFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public NativeArray<T> BNKBFBBHHCL;
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public struct GAJAMKDOAPB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Allocator FKPADLBILGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public NativeArrayAsync<Entity> LLGGJAOAAFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public NativeArrayAsync<T> BNKBFBBHHCL;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2A13870", Offset = "0x2A12070", VA = "0x182A13870")]
		public NativeListAsync<Entity> EKPJNDPEBEC<TPredicate>() where TPredicate : struct, global::GICACEPGEBH<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2DE0CE0", Offset = "0x2DDF4E0", VA = "0x182DE0CE0")]
	public static GAJAMKDOAPB<T> PMDMPBKFCMM<T>(this NativeArrayAsync<Entity> NEDOPJDBOOK, NativeArrayAsync<T> PAPBDDPJFAJ, Allocator FKPADLBILGP = Allocator.TempJob) where T : struct
	{
		return default(GAJAMKDOAPB<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class NKHINJNHLDM : NIHPIFKMGGM
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private Type FNBKKIMOPAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x811A70", Offset = "0x810270", VA = "0x180811A70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6AF6F20", Offset = "0x6AF5720", VA = "0x186AF6F20")]
	public NKHINJNHLDM(Type EEJMEMBCLCD, Type PAKMJKKODEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class GINHNDJBIKL
{
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct NFFGPMNOCOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly Dictionary<Type, List<Type>> PFHNEOLKAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly HashSet<Type> KHIAODMJMEB;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x9E1370", Offset = "0x9DFB70", VA = "0x1809E1370")]
	public NFFGPMNOCOF(Dictionary<Type, List<Type>> PFHNEOLKAIH, HashSet<Type> KHIAODMJMEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct JGJKMCDDCIF
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class IOPAFAFHAGP : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Type <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private IEnumerable<Type> types;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public IEnumerable<Type> <>3__types;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public JGJKMCDDCIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public JGJKMCDDCIF <>3__<>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private IEnumerator<Type> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private Type <type>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private bool <allow>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		Type IEnumerator<Type>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xB955D0", Offset = "0xB93DD0", VA = "0x180B955D0")]
		[DebuggerHidden]
		public IOPAFAFHAGP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6AF3EC0", Offset = "0x6AF26C0", VA = "0x186AF3EC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6AF3C00", Offset = "0x6AF2400", VA = "0x186AF3C00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6AF3BB0", Offset = "0x6AF23B0", VA = "0x186AF3BB0")]
		private void EHFOANOMIIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6AF3E80", Offset = "0x6AF2680", VA = "0x186AF3E80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6AF3DD0", Offset = "0x6AF25D0", VA = "0x186AF3DD0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6AF3DD0", Offset = "0x6AF25D0", VA = "0x186AF3DD0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct DPMOLDAINHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Dictionary<Type, List<Type>> map;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public Queue<Type> queue;
	}

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly MFFHLJHLBIG HGFFDKCANPF;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static readonly Type JNMGJLFKNJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private PACEBIKNHGA MDFPINHICMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private bool BKACKJFKCDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private bool ANKBICKIPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool IBDLFJOOKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private IEnumerable<Type> DPPDAEFIDAH;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6AF4A10", Offset = "0x6AF3210", VA = "0x186AF4A10")]
	public static JGJKMCDDCIF JLAKJAPJOGA()
	{
		return default(JGJKMCDDCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6AF4250", Offset = "0x6AF2A50", VA = "0x186AF4250")]
	public JGJKMCDDCIF EHMLDGBAGOA(PACEBIKNHGA BJCAHHPNCBK)
	{
		return default(JGJKMCDDCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6AF4A30", Offset = "0x6AF3230", VA = "0x186AF4A30")]
	public JGJKMCDDCIF MGMHFKGFOFF(IEnumerable<Type> LONDNADJAMP)
	{
		return default(JGJKMCDDCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6AF4A00", Offset = "0x6AF3200", VA = "0x186AF4A00")]
	public JGJKMCDDCIF JBLFHNMIOGD(bool GHPCJNFPKGM)
	{
		return default(JGJKMCDDCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6AF3FE0", Offset = "0x6AF27E0", VA = "0x186AF3FE0")]
	public JGJKMCDDCIF ANDLEFEEEPE(bool GCELNGKNAOM)
	{
		return default(JGJKMCDDCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6AF3FF0", Offset = "0x6AF27F0", VA = "0x186AF3FF0")]
	public NFFGPMNOCOF DIEOPPNBAEK(Type[] AGMDDLAFMJO)
	{
		return default(NFFGPMNOCOF);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6AF3F50", Offset = "0x6AF2750", VA = "0x186AF3F50")]
	[IteratorStateMachine(typeof(IOPAFAFHAGP))]
	internal IEnumerable<Type> AICMJJAPNCN(IEnumerable<Type> LONDNADJAMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6AF4A70", Offset = "0x6AF3270", VA = "0x186AF4A70")]
	internal Dictionary<Type, List<Type>> OABGBMBILEN(IEnumerable<Type> LONDNADJAMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6AF4D50", Offset = "0x6AF3550", VA = "0x186AF4D50")]
	private void OEHCIJIJMIF(Dictionary<Type, List<Type>> KKIGAGCNEHG, Type FIJCKHKKDCC, Type GFFIJCJGAJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6AF4090", Offset = "0x6AF2890", VA = "0x186AF4090")]
	internal HashSet<Type> EDNHPFBFDOM(IEnumerable<Type> CJGHDKIGFAL, Dictionary<Type, List<Type>> GNJLJGGMKOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6AF4260", Offset = "0x6AF2A60", VA = "0x186AF4260")]
	internal bool IKGLIEFNFGE(Type FIJCKHKKDCC, PACEBIKNHGA MDFPINHICMD, bool IBDLFJOOKBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6AF48A0", Offset = "0x6AF30A0", VA = "0x186AF48A0")]
	[CompilerGenerated]
	internal static void IPMIDCOKMOD(Type FIJCKHKKDCC, ref DPMOLDAINHO P_1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class DOLJLBPFGJJ
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3B45B40", Offset = "0x3B44340", VA = "0x183B45B40")]
	public static NativeList<Entity> NIDANPLCCPN<T>(this NativeArray<Entity> NEDOPJDBOOK, EntityManager LMJGFJDJJLA, Allocator FKPADLBILGP = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class PHCKPOHNJNK
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private struct PHPCJPHJMEM : global::JIALLIDJLOI<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> IFNFCNOALAD;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6AF7F60", Offset = "0x6AF6760", VA = "0x186AF7F60")]
		[BurstCompatible]
		public Entity IAODJDJKLAM(in Entity ECNGHFJBIJL)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6AF7F60", Offset = "0x6AF6760", VA = "0x186AF7F60", Slot = "4")]
		private Entity JCEKMDMCNMC(in Entity ECNGHFJBIJL)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class AGAJFINJMGP
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6AF06B0", Offset = "0x6AEEEB0", VA = "0x186AF06B0")]
	public static bool BIIFBHKMNEE(Type FIJCKHKKDCC, Type DGDGPJEIFCF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public abstract class PMDCKHPFFBE : DEOJGEHECCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6AF8010", Offset = "0x6AF6810", VA = "0x186AF8010", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected abstract ComponentSystemBase ACOOADPIPBA();

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6AF7FC0", Offset = "0x6AF67C0", VA = "0x186AF7FC0")]
	protected ComponentSystemBase OPDBPNNIPNJ(params ComponentSystemBase[] KHIAODMJMEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x23DA730", Offset = "0x23D8F30", VA = "0x1823DA730")]
	protected ComponentSystemBase OPDBPNNIPNJ<T>(params ComponentSystemBase[] KHIAODMJMEB) where T : DEOJGEHECCJ, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x23DA610", Offset = "0x23D8E10", VA = "0x1823DA610")]
	protected ComponentSystemBase BJAGJCDLMMK<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x23DA610", Offset = "0x23D8E10", VA = "0x1823DA610")]
	protected ComponentSystemBase DGPKLMJLFNH<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6AF7F70", Offset = "0x6AF6770", VA = "0x186AF7F70")]
	protected ComponentSystemBase MKLPCEGIBBD(params SystemHandleUntyped[] KHIAODMJMEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x23DA650", Offset = "0x23D8E50", VA = "0x1823DA650")]
	protected ComponentSystemBase MKLPCEGIBBD<T>(params SystemHandleUntyped[] KHIAODMJMEB) where T : DEOJGEHECCJ, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x23DA6E0", Offset = "0x23D8EE0", VA = "0x1823DA6E0")]
	protected SystemHandleUntyped NMNKIAIFLEC<T>() where T : struct, ISystem
	{
		return default(SystemHandleUntyped);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6AF1260", Offset = "0x6AEFA60", VA = "0x186AF1260")]
	protected PMDCKHPFFBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface NBMCIPHNCFJ<BaseClass>
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ODOLPHCGINH(int GJCJMGJCOPK);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::BFJGLKGJIEH<BaseClass> MINFOLDOHDJ();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class GJGEHGNCJIE
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x30BD000", Offset = "0x30BB800", VA = "0x1830BD000")]
	public static NativeList<T> EAGPENIJKGE<T>(NativeList<T> PAPBDDPJFAJ, Allocator FKPADLBILGP) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class AONFAGOABLO
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct POJFECOCFBC<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : global::JIALLIDJLOI<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	[ReadOnly]
	public NativeArray<TFrom> BNKBFBBHHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public NativeList<TFrom> DMDFGMPCOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public NativeHashSet<TTo> AFPDPADDMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public TMap FOGMDOMFJBB;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[BurstCompile]
internal struct FDHNPOFEAJH<T, TPredicate> : IJob where T : struct where TPredicate : struct, global::GICACEPGEBH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	public NativeArray<T> BNKBFBBHHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	public NativeArray<Entity> LLGGJAOAAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeList<Entity> BGMOENIMNEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public TPredicate FOGMDOMFJBB;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x260C170", Offset = "0x260A970", VA = "0x18260C170", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
internal struct OMFCGMFCCFF<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, global::JIALLIDJLOI<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[ReadOnly]
	public NativeArray<TFrom> PMKNCNIKFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	[WriteOnly]
	public NativeList<TTo> PCEBGEHDMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public TMap FOGMDOMFJBB;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[AttributeUsage(AttributeTargets.Class)]
public sealed class BABBANGKBPB : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public PACEBIKNHGA DMJNJJLNDCO;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal class GPBKOAMMEHF : global::IBHAHBMDJLH<NKHINJNHLDM, DGLDCDLCECP>
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6AF28C0", Offset = "0x6AF10C0", VA = "0x186AF28C0")]
	public GPBKOAMMEHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal abstract class IBHAHBMDJLH<Attribute, BaseClass> : global::NBMCIPHNCFJ<BaseClass>, GJEPOCECPGN where Attribute : NIHPIFKMGGM
{
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private static readonly MFFHLJHLBIG HGFFDKCANPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly string BPOKAAOBIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly Dictionary<int, Type> KPNAKNAPBJC;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x51EFBB0", Offset = "0x51EE3B0", VA = "0x1851EFBB0")]
	public IBHAHBMDJLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x51EFA20", Offset = "0x51EE220", VA = "0x1851EFA20", Slot = "4")]
	public bool ODOLPHCGINH(int GJCJMGJCOPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x51EF770", Offset = "0x51EDF70", VA = "0x1851EF770", Slot = "5")]
	public global::BFJGLKGJIEH<BaseClass> MINFOLDOHDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x51EF540", Offset = "0x51EDD40", VA = "0x1851EF540", Slot = "7")]
	protected virtual bool BIIFBHKMNEE(Type FIJCKHKKDCC, int GIOIBEJJEBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x51EFA80", Offset = "0x51EE280", VA = "0x1851EFA80", Slot = "8")]
	protected virtual int PBPIADAHKIL(Type FIJCKHKKDCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x51EF640", Offset = "0x51EDE40", VA = "0x1851EF640")]
	public void FFPJNMKMBJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x51EF6D0", Offset = "0x51EDED0", VA = "0x1851EF6D0", Slot = "6")]
	public void JPCMNIEIIHN(Type FIJCKHKKDCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class MNHKICAIKFJ
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private struct LDKJPNACANF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public readonly ulong PJNELDLHIKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public readonly COMLEFGIJKK FAFGKFJGBEL;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x83CA00", Offset = "0x83B200", VA = "0x18083CA00")]
		public LDKJPNACANF(ulong AABAOCJNFFN, COMLEFGIJKK JKJJBILHHIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6AF54F0", Offset = "0x6AF3CF0", VA = "0x186AF54F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class JNGJBINMJCM : IEnumerable<COMLEFGIJKK>, IEnumerable, IEnumerator<COMLEFGIJKK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private COMLEFGIJKK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private ulong nameHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public ulong <>3__nameHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private IEnumerator<MPLGEIBKPCK> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private MPLGEIBKPCK <attrib>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private COMLEFGIJKK System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.Attributes.NameHash>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(COMLEFGIJKK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x6AF53A0", Offset = "0x6AF3BA0", VA = "0x186AF53A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xB955D0", Offset = "0xB93DD0", VA = "0x180B955D0")]
		[DebuggerHidden]
		public JNGJBINMJCM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6AF53F0", Offset = "0x6AF3BF0", VA = "0x186AF53F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6AF5040", Offset = "0x6AF3840", VA = "0x186AF5040", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6AF4FF0", Offset = "0x6AF37F0", VA = "0x186AF4FF0")]
		private void EHFOANOMIIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6AF5360", Offset = "0x6AF3B60", VA = "0x186AF5360", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6AF52B0", Offset = "0x6AF3AB0", VA = "0x186AF52B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<COMLEFGIJKK> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Attributes.NameHash>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6AF52B0", Offset = "0x6AF3AB0", VA = "0x186AF52B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static readonly MFFHLJHLBIG HGFFDKCANPF;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private static readonly Type MHICKKPIGCL;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static Dictionary<ulong, int> JNHJDBLOOCD;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static LDKJPNACANF[] KFDNEFNMBPP;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static bool NHOHANJCEON;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6AF66D0", Offset = "0x6AF4ED0", VA = "0x186AF66D0")]
	public static ulong KJKFEHIMJMJ(int GJCJMGJCOPK)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6AF6620", Offset = "0x6AF4E20", VA = "0x186AF6620")]
	public static int JFBOPNIILDN(ulong JKJJBILHHIM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6AF6940", Offset = "0x6AF5140", VA = "0x186AF6940")]
	public static void PBAELFIBGFO(bool HCKNDFMIDDI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6AF5AA0", Offset = "0x6AF42A0", VA = "0x186AF5AA0")]
	private static void CFNJFEAOHGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6AF5B60", Offset = "0x6AF4360", VA = "0x186AF5B60")]
	private static void CFNJFEAOHGP(IEnumerable<Type> LONDNADJAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6AF59C0", Offset = "0x6AF41C0", VA = "0x186AF59C0")]
	private static void CAKDJHLFBLC(int FILOPMLNENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6AF62B0", Offset = "0x6AF4AB0", VA = "0x186AF62B0")]
	private static void HKPHNIPNJLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6AF67C0", Offset = "0x6AF4FC0", VA = "0x186AF67C0")]
	private static (ulong, IEnumerable<COMLEFGIJKK>) KPGKEHHNHNH(Type FIJCKHKKDCC)
	{
		return default((ulong, IEnumerable<COMLEFGIJKK>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6AF6730", Offset = "0x6AF4F30", VA = "0x186AF6730")]
	[IteratorStateMachine(typeof(JNGJBINMJCM))]
	private static IEnumerable<COMLEFGIJKK> KNOABKALDDB(Type FIJCKHKKDCC, ulong JKJJBILHHIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6AF5E30", Offset = "0x6AF4630", VA = "0x186AF5E30")]
	private static void FGFIDBBENNC(ulong JKJJBILHHIM, IEnumerable<COMLEFGIJKK> GMFFEAKKGAE, TypeManager.TypeInfo EEIDDEHCPMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6AF58C0", Offset = "0x6AF40C0", VA = "0x186AF58C0")]
	private static void BDPIJDFBLMM(LDKJPNACANF EEIDDEHCPMB, int GJCJMGJCOPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6AF6130", Offset = "0x6AF4930", VA = "0x186AF6130")]
	private static void FHFIJEIOOPA(LDKJPNACANF EEIDDEHCPMB, int GJCJMGJCOPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6AF6220", Offset = "0x6AF4A20", VA = "0x186AF6220")]
	private static LDKJPNACANF GMIPBBEHMHI(int GJCJMGJCOPK)
	{
		return default(LDKJPNACANF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6AF6610", Offset = "0x6AF4E10", VA = "0x186AF6610")]
	private static int HPCLEGMLENH(int GJCJMGJCOPK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class HAKINDMGFKF
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct IOBDCDGKECN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly NativeArray<T>.ReadOnly EABDNHJFDCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private int GOGKDEGLBIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int MGJGMDCIFEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private T OEFONCAFDCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private T MJINNJIFEPF;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public DFGMPCKANBL PEMIFLLALFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x29C3740", Offset = "0x29C1F40", VA = "0x1829C3740")]
			get
			{
				return default(DFGMPCKANBL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T LOFOOLDNEHF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x231CE90", Offset = "0x231B690", VA = "0x18231CE90")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public (T, DFGMPCKANBL) NIBFGHDNPCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x39C6770", Offset = "0x39C4F70", VA = "0x1839C6770")]
			get
			{
				return default((T, DFGMPCKANBL));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x39C6C10", Offset = "0x39C5410", VA = "0x1839C6C10")]
		public IOBDCDGKECN(NativeArray<T> EABDNHJFDCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x367ABD0", Offset = "0x36793D0", VA = "0x18367ABD0")]
		public IOBDCDGKECN<T> MEOEHOBEEMI()
		{
			return default(IOBDCDGKECN<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x39C6840", Offset = "0x39C5040", VA = "0x1839C6840")]
		public bool MIOEPBKKBNP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x332D680", Offset = "0x332BE80", VA = "0x18332D680")]
		public NDHLPCENPNP<T, TComparer> BCMOOKFMMEB<TComparer>([Optional] TComparer GCAEFOMJOFC) where TComparer : struct, IEqualityComparer<T>
		{
			return default(NDHLPCENPNP<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public struct NDHLPCENPNP<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly NativeArray<T>.ReadOnly EABDNHJFDCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int GOGKDEGLBIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private int MGJGMDCIFEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private T OEFONCAFDCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private T MJINNJIFEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TComparer GCAEFOMJOFC;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public DFGMPCKANBL PEMIFLLALFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x29C3740", Offset = "0x29C1F40", VA = "0x1829C3740")]
			get
			{
				return default(DFGMPCKANBL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public T LOFOOLDNEHF
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x231CE90", Offset = "0x231B690", VA = "0x18231CE90")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public (T value, DFGMPCKANBL range) NIBFGHDNPCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x29C3750", Offset = "0x29C1F50", VA = "0x1829C3750")]
			get
			{
				return default((T, DFGMPCKANBL));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x29C3AC0", Offset = "0x29C22C0", VA = "0x1829C3AC0")]
		public NDHLPCENPNP(NativeArray<T>.ReadOnly EABDNHJFDCB, TComparer GCAEFOMJOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x29C3820", Offset = "0x29C2020", VA = "0x1829C3820")]
		public NDHLPCENPNP<T, TComparer> MEOEHOBEEMI()
		{
			return default(NDHLPCENPNP<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x29C3860", Offset = "0x29C2060", VA = "0x1829C3860")]
		public bool MIOEPBKKBNP()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2DD7A50", Offset = "0x2DD6250", VA = "0x182DD7A50")]
	public static IOBDCDGKECN<T> OPDBPNNIPNJ<T>(this NativeArray<T> EABDNHJFDCB) where T : struct
	{
		return default(IOBDCDGKECN<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface JIALLIDJLOI<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo IAODJDJKLAM(in TFrom ECNGHFJBIJL);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class JAKAMAAOIOM
{
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class PCHPBFCHBPN
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class NMDMJFIMEOD<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		public NMDMJFIMEOD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class CJFDFNCGKAD<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		public CJFDFNCGKAD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly List<Func<JobHandle, JobHandle>> IPFJDMNDEIA;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6AF7A50", Offset = "0x6AF6250", VA = "0x186AF7A50")]
	public PCHPBFCHBPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class AMOLOMHFCJD
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public abstract class IKNIOKDNHBL : EntityCommandBufferSystem, KHPBHBLDCGG
{
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x80EA90", Offset = "0x80D290", VA = "0x18080EA90")]
	protected IKNIOKDNHBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class MOEBPIEJEHJ
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2BFF710", Offset = "0x2BFDF10", VA = "0x182BFF710")]
	[MustUseReturnValue]
	public static JobHandle LBINMGCOHEM<T>(this EntityCommandBufferSystem PPANIHNCFCJ, NativeArray<Entity> FPMGLBFKKPO, NativeArray<T> PHBHEFAPHDL, JobHandle NPBMDGDOAPE) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[BurstCompile]
internal struct IODBHLLKGFJ<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	public NativeArray<T> BNKBFBBHHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeList<T> DMDFGMPCOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeHashSet<T> AFPDPADDMJH;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x39C74D0", Offset = "0x39C5CD0", VA = "0x1839C74D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class BFJGLKGJIEH<BaseClass>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly Dictionary<int, BaseClass> ANPDBEBEJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly Dictionary<Type, BaseClass> HJFFJDCKBCI;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int PLEPIEDOEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x29CDB30", Offset = "0x29CC330", VA = "0x1829CDB30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IEnumerable<BaseClass> DBENEACIGAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2D15510", Offset = "0x2D13D10", VA = "0x182D15510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2D15A30", Offset = "0x2D14230", VA = "0x182D15A30")]
	public BFJGLKGJIEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2D15890", Offset = "0x2D14090", VA = "0x182D15890")]
	public BFJGLKGJIEH(int CABFJBCMJEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2D15740", Offset = "0x2D13F40", VA = "0x182D15740")]
	internal void CAILCKFFJIK(int GJCJMGJCOPK, BaseClass CPIEKHBBHCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2D5B550", Offset = "0x2D59D50", VA = "0x182D5B550")]
	public bool CJMEEDACJIA<T>(out BaseClass ECNGHFJBIJL) where T : IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2D157C0", Offset = "0x2D13FC0", VA = "0x182D157C0")]
	public bool CJMEEDACJIA(Type GDOKANFLACL, out BaseClass ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x29C3D60", Offset = "0x29C2560", VA = "0x1829C3D60")]
	public bool PMIPEJMDEHL(int GJCJMGJCOPK, out BaseClass ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2D5C310", Offset = "0x2D5AB10", VA = "0x182D5C310")]
	public T ELBMGAGFHLI<T>() where T : BaseClass
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2D15860", Offset = "0x2D14060", VA = "0x182D15860")]
	public BaseClass ELBMGAGFHLI(Type LLNJOBIDKCE)
	{
		return (BaseClass)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal class KILLGJJIMEA : global::IBHAHBMDJLH<OALALKKKNCP, MFCOBEFGBOI>
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6AF5480", Offset = "0x6AF3C80", VA = "0x186AF5480")]
	public KILLGJJIMEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[BurstCompile]
internal struct GOIDDBDPOKN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[ReadOnly]
	public NativeArray<Entity> FPMGLBFKKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public EntityCommandBuffer FIENHHJAMHI;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6AF2860", Offset = "0x6AF1060", VA = "0x186AF2860", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class OPKPAOPDKEI
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x23CE800", Offset = "0x23CD000", VA = "0x1823CE800")]
	public static NativeArray<T> KIJJPLBIKIL<T>(this NativeList<Entity> PAPBDDPJFAJ, EntityManager LMJGFJDJJLA, Allocator FKPADLBILGP = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x23CE590", Offset = "0x23CCD90", VA = "0x1823CE590")]
	public static NativeArray<T> KIJJPLBIKIL<T>(this NativeArray<Entity> PAPBDDPJFAJ, EntityManager LMJGFJDJJLA, Allocator FKPADLBILGP = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface GOMJLGAGDEN
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class JPDKEOCHKKN
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal struct EIBFMMJEEII<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	public NativeArray<Entity> FPMGLBFKKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	public T ECNGHFJBIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public EntityCommandBuffer FIENHHJAMHI;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3860EC0", Offset = "0x385F6C0", VA = "0x183860EC0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class LIPPMCDPHPN
{
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x354A0C0", Offset = "0x35488C0", VA = "0x18354A0C0")]
	[MustUseReturnValue]
	public static JobHandle NLLFDBKALMO<T>(this EntityCommandBufferSystem PPANIHNCFCJ, EntityCommandBuffer FIENHHJAMHI, EntityQuery DPBAMGMJJLC, T ECNGHFJBIJL) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3549FE0", Offset = "0x35487E0", VA = "0x183549FE0")]
	[MustUseReturnValue]
	public static JobHandle NLLFDBKALMO<T>(this EntityCommandBufferSystem PPANIHNCFCJ, NativeArrayAsync<Entity> FPMGLBFKKPO, NativeArrayAsync<T> ECNGHFJBIJL) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3549E70", Offset = "0x3548670", VA = "0x183549E70")]
	[MustUseReturnValue]
	public static JobHandle NLLFDBKALMO<T>(this EntityCommandBufferSystem PPANIHNCFCJ, EntityCommandBuffer FIENHHJAMHI, NativeArrayAsync<Entity> FPMGLBFKKPO, NativeArrayAsync<T> ECNGHFJBIJL) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal class ENNLNNLCJGJ : global::IBHAHBMDJLH<KBFDIMINBEO, AKKNCOHCIBK>
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6AF1D70", Offset = "0x6AF0570", VA = "0x186AF1D70")]
	public ENNLNNLCJGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public abstract class ILHPNMCGHLL<Data> : MFCOBEFGBOI where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public virtual Data OAEIAFEPBFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x34C19B0", Offset = "0x34C01B0", VA = "0x1834C19B0", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7F3600", Offset = "0x7F1E00", VA = "0x1807F3600", Slot = "8")]
	protected virtual bool FKIEGFNPIMN(ReadOnlySpan<Data> CHCFPJJJGHE, MHCHCENMNNH LOCFGCDNKMP, out ReadOnlySpan<byte> KNJBCHEFCED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7F35F0", Offset = "0x7F1DF0", VA = "0x1807F35F0", Slot = "9")]
	protected virtual bool BAOFGNAPECJ(int FPBNFBFIPHI, Span<Data> CHCFPJJJGHE, in ReadOnlySpan<byte> KNJBCHEFCED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x34C1880", Offset = "0x34C0080", VA = "0x1834C1880", Slot = "5")]
	internal sealed override bool FKIEGFNPIMN(ref Unity.Entities.Chunk NLIPPJGPKOG, int BNNLAPKBIOF, MHCHCENMNNH LOCFGCDNKMP, out ReadOnlySpan<byte> KNJBCHEFCED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x34C0700", Offset = "0x34BEF00", VA = "0x1834C0700", Slot = "6")]
	internal sealed override bool BAOFGNAPECJ(int FPBNFBFIPHI, ref Unity.Entities.Chunk NLIPPJGPKOG, int BNNLAPKBIOF, in ReadOnlySpan<byte> KNJBCHEFCED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x332D5A0", Offset = "0x332BDA0", VA = "0x18332D5A0")]
	protected global::HOEKDGLKAAO<Protobuf> IJOPLFJMPHO<Protobuf>(ReadOnlySpan<Data> CHCFPJJJGHE) where Protobuf : IMessage, new()
	{
		return default(global::HOEKDGLKAAO<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x332D5F0", Offset = "0x332BDF0", VA = "0x18332D5F0")]
	protected global::PGLAGHJANGJ<Protobuf> MHDMPPMKNEE<Protobuf>(ReadOnlySpan<byte> KNJBCHEFCED, ReadOnlySpan<Data> CHCFPJJJGHE, Action<Protobuf> GCGGKDKNPNA) where Protobuf : IMessage, new()
	{
		return default(global::PGLAGHJANGJ<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2E02440", Offset = "0x2E00C40", VA = "0x182E02440")]
	protected ILHPNMCGHLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public abstract class MFCOBEFGBOI
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	protected internal abstract int ODKLBHBAMKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6AF55C0", Offset = "0x6AF3DC0", VA = "0x186AF55C0", Slot = "5")]
	internal virtual bool FKIEGFNPIMN(ref Unity.Entities.Chunk NLIPPJGPKOG, int BNNLAPKBIOF, MHCHCENMNNH LOCFGCDNKMP, out ReadOnlySpan<byte> KNJBCHEFCED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x7F35F0", Offset = "0x7F1DF0", VA = "0x1807F35F0", Slot = "6")]
	internal virtual bool BAOFGNAPECJ(int FPBNFBFIPHI, ref Unity.Entities.Chunk NLIPPJGPKOG, int BNNLAPKBIOF, in ReadOnlySpan<byte> KNJBCHEFCED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	protected MFCOBEFGBOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class HHONOGGLPGI
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public struct ECOGONDPIMI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public struct EOAKHPDECDC<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			internal ECOGONDPIMI<TFrom> ONIJEEBBCHK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		internal Allocator FKPADLBILGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		internal NativeArray<TFrom> LBADBCNNFAH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct IFLDFHDDPNF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public struct ILIKOOCALLN<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			internal IFLDFHDDPNF<TFrom> ONIJEEBBCHK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		internal Allocator FKPADLBILGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		internal NativeList<TFrom> LBADBCNNFAH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct IJJBIPDGJJD<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public struct CFFACEIGPPN<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			internal IJJBIPDGJJD<TFrom> ONIJEEBBCHK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		internal Allocator FKPADLBILGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		internal NativeArrayAsync<TFrom> LBADBCNNFAH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct BBFKAGNMIJF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public struct LAJHILDEMNE<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			internal BBFKAGNMIJF<TFrom> ONIJEEBBCHK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		internal Allocator FKPADLBILGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		internal NativeListAsync<TFrom> LBADBCNNFAH;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[BurstCompile]
internal struct EILEDANDMDK<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	[ReadOnly]
	public ComponentDataFromEntity<T> PIILKJFJHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[ReadOnly]
	public NativeArray<Entity> BNKBFBBHHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[WriteOnly]
	public NativeArray<T> PCEBGEHDMOB;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3863760", Offset = "0x3861F60", VA = "0x183863760", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[BurstCompile]
internal struct DJNAALHLNEL<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	[ReadOnly]
	public ComponentDataFromEntity<T> PAKMJKKODEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[ReadOnly]
	public NativeArray<Entity> NEDOPJDBOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public NativeArray<bool> IACOGNAFBCA;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal struct JHLNKCEEPKM<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	[ReadOnly]
	public NativeArray<Entity> FPMGLBFKKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[ReadOnly]
	public NativeArray<T> EFLCMDHDGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public EntityCommandBuffer FIENHHJAMHI;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x32F9DA0", Offset = "0x32F85A0", VA = "0x1832F9DA0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface OBMJEBOBNEB
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class ILPMDFCJDDP
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x243AD40", Offset = "0x2439540", VA = "0x18243AD40")]
	public static NativeListAsync<Entity> OELIENMIMKN<T, TPredicate>(this NativeArrayAsync<T> PAPBDDPJFAJ, NativeArrayAsync<Entity> NEDOPJDBOOK, Allocator FKPADLBILGP = Allocator.TempJob) where T : struct where TPredicate : struct, global::GICACEPGEBH<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x243AB90", Offset = "0x2439390", VA = "0x18243AB90")]
	private static NativeListAsync<Entity> BFBPCEJHGKJ<T, TPredicate>(NativeArrayAsync<T> FDMFIPGIBNB, NativeArrayAsync<Entity> NEDOPJDBOOK, int HLPFAIAMMGH, Allocator FKPADLBILGP) where T : struct where TPredicate : struct, global::GICACEPGEBH<T>
	{
		return default(NativeListAsync<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class ACLLJCCMGPG
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x1C3E740", Offset = "0x1C3CF40", VA = "0x181C3E740")]
	[MustUseReturnValue]
	public static JobHandle PBDOFOAPMMF<T>(this EntityCommandBufferSystem PPANIHNCFCJ, NativeArray<Entity> FPMGLBFKKPO, T ECNGHFJBIJL, [Optional] JobHandle NPBMDGDOAPE) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x1C3E670", Offset = "0x1C3CE70", VA = "0x181C3E670")]
	[MustUseReturnValue]
	public static JobHandle PBDOFOAPMMF<T>(this EntityCommandBufferSystem PPANIHNCFCJ, EntityCommandBuffer FIENHHJAMHI, NativeArray<Entity> FPMGLBFKKPO, T ECNGHFJBIJL, [Optional] JobHandle NPBMDGDOAPE) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x1C3E5B0", Offset = "0x1C3CDB0", VA = "0x181C3E5B0")]
	[MustUseReturnValue]
	public static JobHandle PBDOFOAPMMF<T>(this EntityCommandBufferSystem PPANIHNCFCJ, EntityCommandBuffer FIENHHJAMHI, NativeArray<Entity> FPMGLBFKKPO, NativeArray<T> EFLCMDHDGNO, [Optional] JobHandle NPBMDGDOAPE) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class KBFDIMINBEO : NIHPIFKMGGM
{
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class GCLBKNDMFBG
{
	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x30B4C30", Offset = "0x30B3430", VA = "0x1830B4C30")]
	public static NativeList<T> EAGPENIJKGE<T>(this NativeList<T> PAPBDDPJFAJ, Allocator FKPADLBILGP = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x30B4A60", Offset = "0x30B3260", VA = "0x1830B4A60")]
	public static NativeList<T> EAGPENIJKGE<T>(this NativeArray<T> PAPBDDPJFAJ, Allocator FKPADLBILGP = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class DJOAGHKONCB
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public struct FKADGKJHBGG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public Allocator FKPADLBILGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public NativeArray<T> BNKBFBBHHCL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct EOCGPMNDOAK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public Allocator FKPADLBILGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public NativeList<T> BNKBFBBHHCL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct EAJFDDBONBJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Allocator FKPADLBILGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public NativeArrayAsync<T> BNKBFBBHHCL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public struct DMPHGNMNBDA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Allocator FKPADLBILGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public NativeListAsync<T> BNKBFBBHHCL;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[BurstCompile]
internal struct FIMKPBDOMLO<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, global::JIALLIDJLOI<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[ReadOnly]
	public NativeArray<TFrom> BNKBFBBHHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	[WriteOnly]
	public NativeArray<TTo> PCEBGEHDMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public TMap FOGMDOMFJBB;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[Flags]
public enum PACEBIKNHGA
{
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	GameObjectConversion = 0x30,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	EntitySceneOptimizations = 4,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	ProcessAfterLoad = 8,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	HybridGameObjectConversion = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	DotsRuntimeGameObjectConversion = 0x20
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface GICACEPGEBH<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EKPJNDPEBEC(T ECNGHFJBIJL);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[BurstCompile]
internal struct BPAADNAIALO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[ReadOnly]
	public NativeArray<Entity> FPMGLBFKKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public EntityCommandBuffer FIENHHJAMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public ComponentTypes FOAMMHNABBN;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6AF1040", Offset = "0x6AEF840", VA = "0x186AF1040", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[BurstCompile]
internal struct AKIAONOFANI<T, TPredicate> : IJob where T : struct where TPredicate : struct, global::GICACEPGEBH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	[ReadOnly]
	public NativeArray<T> BNKBFBBHHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeList<T> DMDFGMPCOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public TPredicate FOGMDOMFJBB;

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class DEOJGEHECCJ : DEAPKDDLFMM
{
	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6AF12C0", Offset = "0x6AEFAC0", VA = "0x186AF12C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6AF1260", Offset = "0x6AEFA60", VA = "0x186AF1260")]
	public DEOJGEHECCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public abstract class NIHPIFKMGGM : LBCLEEENKKC
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Type IBCODNAPCIG
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x85D1E0", Offset = "0x85B9E0", VA = "0x18085D1E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8CCF80", Offset = "0x8CB780", VA = "0x1808CCF80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0xC87AC0", Offset = "0xC862C0", VA = "0x180C87AC0")]
	public NIHPIFKMGGM(Type PAKMJKKODEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class BCNHMKMIHLF
{
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private static readonly Dictionary<int, int> HJKMEKHGCIE;

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private static bool NHOHANJCEON;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0C00", Offset = "0x6AEF400", VA = "0x186AF0C00")]
	public static int ILHBPGJKDMF(int GJCJMGJCOPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0F20", Offset = "0x6AEF720", VA = "0x186AF0F20")]
	public static void PBAELFIBGFO(bool HCKNDFMIDDI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0CA0", Offset = "0x6AEF4A0", VA = "0x186AF0CA0")]
	private static void JLDGCFEPJEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0B30", Offset = "0x6AEF330", VA = "0x186AF0B30")]
	private static int CPCDBPJFPGH(Type FIJCKHKKDCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0B80", Offset = "0x6AEF380", VA = "0x186AF0B80")]
	private static void ELJLHOEKJGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[BurstCompile]
internal struct FBJEHLIELNO<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[ReadOnly]
	public ComponentDataFromEntity<T> PAKMJKKODEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[ReadOnly]
	public NativeArray<Entity> NEDOPJDBOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public NativeArray<bool> IACOGNAFBCA;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x2605C90", Offset = "0x2604490", VA = "0x182605C90", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[BurstCompile]
internal struct EKBGEKJEMBL<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	public NativeArray<Entity> FPMGLBFKKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	public NativeArray<T> PHBHEFAPHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public EntityCommandBuffer FIENHHJAMHI;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x38678B0", Offset = "0x38660B0", VA = "0x1838678B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class AMMGLDMAJIP
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0880", Offset = "0x6AEF080", VA = "0x186AF0880")]
	public static ulong GEOLMDPOAFC(Type FIJCKHKKDCC)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0910", Offset = "0x6AEF110", VA = "0x186AF0910")]
	public static ulong GEOLMDPOAFC(string HCJJNBBFLLM)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
internal static class AEHHFJOHHAA
{
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly Dictionary<Type, int> JKFAFIELGDO;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static bool NHOHANJCEON;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6AEF600", Offset = "0x6AEDE00", VA = "0x186AEF600")]
	public static void PBAELFIBGFO(bool HCKNDFMIDDI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6AEF3D0", Offset = "0x6AEDBD0", VA = "0x186AEF3D0")]
	private static void MJFCMCFOCND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6AEF060", Offset = "0x6AED860", VA = "0x186AEF060")]
	private static void EPDPHHMMABF(Type ELNKCIBOCOL, Type CBHLPGJGAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6AEEFE0", Offset = "0x6AED7E0", VA = "0x186AEEFE0")]
	private static void ELJLHOEKJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6AEF240", Offset = "0x6AEDA40", VA = "0x186AEF240")]
	public static int HMKNNJIMIKG(Type ELNKCIBOCOL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6AEF330", Offset = "0x6AEDB30", VA = "0x186AEF330")]
	public static bool ICMJLMFFENG(Type ELNKCIBOCOL, out int GJCJMGJCOPK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public static class IHPCGJECINF
{
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly MFFHLJHLBIG HGFFDKCANPF;

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6AF2BC0", Offset = "0x6AF13C0", VA = "0x186AF2BC0")]
	public static ComponentSystemGroup[] HDEMIFJCDLH(World GPEEKLGBDDJ, PACEBIKNHGA MDFPINHICMD = PACEBIKNHGA.Default, bool IBDLFJOOKBO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6AF2D50", Offset = "0x6AF1550", VA = "0x186AF2D50")]
	private static Type[] LLOCABGJLFO(PACEBIKNHGA MDFPINHICMD, bool IBDLFJOOKBO, ComponentSystemGroup[] CJGHDKIGFAL, ComponentSystemGroup DLIBOCPFIME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6AF30B0", Offset = "0x6AF18B0", VA = "0x186AF30B0")]
	private static ComponentSystemGroup[] MEGKBKPHLAH(World GPEEKLGBDDJ, out ComponentSystemGroup DLIBOCPFIME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6AF2930", Offset = "0x6AF1130", VA = "0x186AF2930")]
	internal static bool EMCIOKLDPDI(LNGKPFAGLPC BJCAHHPNCBK, out HJLOAJDGIBN BHPNIOIEDBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6AF33C0", Offset = "0x6AF1BC0", VA = "0x186AF33C0")]
	private static ComponentSystemGroup NMFCFFMKFDI(Type FIJCKHKKDCC, World GPEEKLGBDDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6AF34A0", Offset = "0x6AF1CA0", VA = "0x186AF34A0")]
	private static ComponentSystemGroup[] PCJODGPLPMD(Type[] LONDNADJAMP, World GPEEKLGBDDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6AF35D0", Offset = "0x6AF1DD0", VA = "0x186AF35D0")]
	internal static void PLKFLIELLCG(World GPEEKLGBDDJ, Type[] CDCNPKINHEM, ComponentSystemGroup[] CJGHDKIGFAL, ComponentSystemGroup DLIBOCPFIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6AF2CF0", Offset = "0x6AF14F0", VA = "0x186AF2CF0")]
	internal static bool LIICPDIGDMI(ComponentSystemBase HHDENPAFOIF, ComponentSystemGroup[] CJGHDKIGFAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6AF2C90", Offset = "0x6AF1490", VA = "0x186AF2C90")]
	private static void IADJNGKOOOD(ComponentSystemGroup[] CJGHDKIGFAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class OALALKKKNCP : NIHPIFKMGGM
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0xC87AC0", Offset = "0xC862C0", VA = "0x180C87AC0")]
	public OALALKKKNCP(Type PAKMJKKODEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[BurstCompile]
internal struct JJHKCIGFACD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	public ComponentDataFromEntity PAKMJKKODEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	public NativeArray<Entity> NEDOPJDBOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public NativeList<Entity> ILLPLEPAJNI;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6AF4F60", Offset = "0x6AF3760", VA = "0x186AF4F60", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public abstract class BBKLLGEPFAJ : SystemBase, KHPBHBLDCGG
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6AF09E0", Offset = "0x6AEF1E0", VA = "0x186AF09E0")]
	public ComponentDataFromEntity CCEKPMJGJAH(int GJCJMGJCOPK, bool INCMGOFNCLP = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0B00", Offset = "0x6AEF300", VA = "0x186AF0B00")]
	public EntityExistenceLookupByEntity IMKJLPPMDLA()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0AB0", Offset = "0x6AEF2B0", VA = "0x186AF0AB0")]
	public EntityQuery EGGCMBMNPIC(in EntityQueryDescBuilder EALACKPBAJJ)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0B20", Offset = "0x6AEF320", VA = "0x186AF0B20", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x92DE00", Offset = "0x92C600", VA = "0x18092DE00")]
	protected BBKLLGEPFAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public abstract class IKBGPBBHAOK : BBKLLGEPFAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6AF3B80", Offset = "0x6AF2380", VA = "0x186AF3B80", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x92DE00", Offset = "0x92C600", VA = "0x18092DE00")]
	protected IKBGPBBHAOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class KALKHOHOCOC
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface KHPBHBLDCGG
{
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public abstract class DEAPKDDLFMM : ComponentSystemGroup, KHPBHBLDCGG
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6AF1260", Offset = "0x6AEFA60", VA = "0x186AF1260")]
	protected DEAPKDDLFMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public abstract class HOLPBOPBGEA<View, Data> : DGLDCDLCECP where View : struct, IComponent where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static ComponentType INMLBBECFHH;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public override Type EEJHOAPKJKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x358B4F0", Offset = "0x3589CF0", VA = "0x18358B4F0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public override int KKDFANILMMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x358B130", Offset = "0x3589930", VA = "0x18358B130", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x358B0C0", Offset = "0x35898C0", VA = "0x18358B0C0")]
	public Data FPNKHFHGOMJ(Entity CMBJDMJHALL)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract View FGCMFKBIFEL(Entity CMBJDMJHALL);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x41C4D20", Offset = "0x41C3520", VA = "0x1841C4D20", Slot = "14")]
	protected internal override T FGCMFKBIFEL<T>(Entity CMBJDMJHALL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2E02440", Offset = "0x2E00C40", VA = "0x182E02440")]
	protected HOLPBOPBGEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public abstract class DGLDCDLCECP : PHIGEONMPOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private DynamicComponentTypeHandle BCGNENIMLBE;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public EntityManager EHBCKOIMEPG
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x85D1E0", Offset = "0x85B9E0", VA = "0x18085D1E0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x853DE0", Offset = "0x8525E0", VA = "0x180853DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public abstract Type EEJHOAPKJKH
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public abstract int KKDFANILMMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Type MGLPKBHGKGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0xECAC20", Offset = "0xEC9420", VA = "0x180ECAC20", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private int HGLMODJIGNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6AF1790", Offset = "0x6AEFF90", VA = "0x186AF1790", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private DAEIOAAPCOE[] HHKLFBHKGFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x958480", Offset = "0x956C80", VA = "0x180958480", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	protected internal virtual DAEIOAAPCOE[] IMGJKIMNGJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6AF16D0", Offset = "0x6AEFED0", VA = "0x186AF16D0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6AF1800", Offset = "0x6AF0000", VA = "0x186AF1800")]
	public void PBAELFIBGFO(EntityManager LMJGFJDJJLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x94BA40", Offset = "0x94A240", VA = "0x18094BA40")]
	protected PHIGEONMPOB DCELMIPGPEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "14")]
	protected internal abstract T FGCMFKBIFEL<T>(Entity CMBJDMJHALL) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6AF1580", Offset = "0x6AEFD80", VA = "0x186AF1580", Slot = "8")]
	public (uint, uint) ILHBPGJKDMF(Entity CMBJDMJHALL)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6AF1640", Offset = "0x6AEFE40", VA = "0x186AF1640", Slot = "9")]
	public bool MFIELPFAIPE(Entity CMBJDMJHALL, (uint order, uint change) FPBNFBFIPHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	protected DGLDCDLCECP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
internal struct EHCAPCHEGDN
{
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly MFFHLJHLBIG HGFFDKCANPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly List<Type> LONDNADJAMP;

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0xB91230", Offset = "0xB8FA30", VA = "0x180B91230")]
	private EHCAPCHEGDN(List<Type> LONDNADJAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6AF19A0", Offset = "0x6AF01A0", VA = "0x186AF19A0")]
	public static void FFPJNMKMBJA(List<Type> LONDNADJAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6AF1A30", Offset = "0x6AF0230", VA = "0x186AF1A30")]
	private void KEIFOEFMOLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6AF1920", Offset = "0x6AF0120", VA = "0x186AF1920")]
	private bool BIIFBHKMNEE(Type FIJCKHKKDCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6AF1C70", Offset = "0x6AF0470", VA = "0x186AF1C70")]
	private void NDNEJFPEFPK(Type FIJCKHKKDCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public static class HKOFPCEECEN
{
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[BurstCompile]
internal struct FBIHNKBMBAF<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[ReadOnly]
	public ComponentDataFromEntity<T> PIILKJFJHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	[ReadOnly]
	public NativeArray<Entity> BNKBFBBHHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	[WriteOnly]
	public NativeList<T> DMDFGMPCOPK;

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[Flags]
public enum LNGKPFAGLPC
{
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	Live = 1,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	Editor = 3,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	Game = 5,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	Simulation = 9,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	Conversion = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	Staging = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	Shadow = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	Loading = 0x80,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	Saving = 0x100
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class MJMELKOJNAD : LBCLEEENKKC
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public LNGKPFAGLPC LDCMBIKFBDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80D270", VA = "0x18080EA70")]
		[CompilerGenerated]
		get
		{
			return default(LNGKPFAGLPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x1690140", Offset = "0x168E940", VA = "0x181690140")]
	public MJMELKOJNAD(LNGKPFAGLPC BJCAHHPNCBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public class GLODNPPMBII : LBCLEEENKKC
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x92DE00", Offset = "0x92C600", VA = "0x18092DE00")]
	public GLODNPPMBII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public abstract class AKKNCOHCIBK
{
	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	protected AKKNCOHCIBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public static class AAPPNFPNCOF
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public readonly struct FIMFLEFLLCH<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly NativeArray<TSrc> EABDNHJFDCB;

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x837710", Offset = "0x835F10", VA = "0x180837710")]
		public FIMFLEFLLCH(NativeArray<TSrc> EABDNHJFDCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x1118590", Offset = "0x1116D90", VA = "0x181118590")]
		public NPDLCJCGNFL<TSrc, TValue> ELLJOOELFMA<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(NPDLCJCGNFL<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public readonly struct NPDLCJCGNFL<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly NativeArray<TSrc> EABDNHJFDCB;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x837710", Offset = "0x835F10", VA = "0x180837710")]
		public NPDLCJCGNFL(NativeArray<TSrc> EABDNHJFDCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x1118590", Offset = "0x1116D90", VA = "0x181118590")]
		public IBOHGPFOMFK<TSrc, TValue, TSelector> LNDGPDJIGJO<TSelector>() where TSelector : struct, global::JIALLIDJLOI<TSrc, TValue>
		{
			return default(IBOHGPFOMFK<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public readonly struct IBOHGPFOMFK<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, global::JIALLIDJLOI<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly NativeArray<TSrc> EABDNHJFDCB;

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x837710", Offset = "0x835F10", VA = "0x180837710")]
		public IBOHGPFOMFK(NativeArray<TSrc> EABDNHJFDCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x51F0CC0", Offset = "0x51EF4C0", VA = "0x1851F0CC0")]
		public DGOOBOAJBKI<TSrc, TValue, TSelector> OPDBPNNIPNJ()
		{
			return default(DGOOBOAJBKI<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public struct IPHNGCIIHPC<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, global::JIALLIDJLOI<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private readonly NativeArray<TSrc> EABDNHJFDCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private TSelector PEBLDEGHPBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private int NHHNPPKPBIA;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public TValue NIBFGHDNPCH
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x39C9540", Offset = "0x39C7D40", VA = "0x1839C9540")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int OJOINFOLDPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x80EC90", Offset = "0x80D490", VA = "0x18080EC90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int PJKEDAIIMDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x39C95D0", Offset = "0x39C7DD0", VA = "0x1839C95D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x39C9710", Offset = "0x39C7F10", VA = "0x1839C9710")]
		public IPHNGCIIHPC(NativeArray<TSrc> EABDNHJFDCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x39C95B0", Offset = "0x39C7DB0", VA = "0x1839C95B0")]
		public bool MIOEPBKKBNP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x39C95E0", Offset = "0x39C7DE0", VA = "0x1839C95E0")]
		private TSrc OKNGNIBBBIN(int OCIFJAIBHIA)
		{
			return (TSrc)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public struct DGOOBOAJBKI<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, global::JIALLIDJLOI<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private IPHNGCIIHPC<TSrc, TValue, TSelector> ILKMAKIEBIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private TValue OEFONCAFDCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private int GOGKDEGLBIL;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public DFGMPCKANBL PEMIFLLALFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x2F7C3D0", Offset = "0x2F7ABD0", VA = "0x182F7C3D0")]
			get
			{
				return default(DFGMPCKANBL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public TValue LOFOOLDNEHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x8AD980", Offset = "0x8AC180", VA = "0x1808AD980")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public (TValue value, DFGMPCKANBL range) NIBFGHDNPCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x2F7C410", Offset = "0x2F7AC10", VA = "0x182F7C410")]
			get
			{
				return default((TValue, DFGMPCKANBL));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2F7C620", Offset = "0x2F7AE20", VA = "0x182F7C620")]
		public DGOOBOAJBKI(NativeArray<TSrc> EABDNHJFDCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x231CA30", Offset = "0x231B230", VA = "0x18231CA30")]
		public DGOOBOAJBKI<TSrc, TValue, TSelector> MEOEHOBEEMI()
		{
			return default(DGOOBOAJBKI<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x2F7C4F0", Offset = "0x2F7ACF0", VA = "0x182F7C4F0")]
		public bool MIOEPBKKBNP()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x1C3CC00", Offset = "0x1C3B400", VA = "0x181C3CC00")]
	public static FIMFLEFLLCH<T> DBGHCCIPLMI<T>(this NativeList<T> IFADMANLNLG) where T : struct
	{
		return default(FIMFLEFLLCH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x1118590", Offset = "0x1116D90", VA = "0x181118590")]
	public static FIMFLEFLLCH<T> DBGHCCIPLMI<T>(this NativeArray<T> EABDNHJFDCB) where T : struct
	{
		return default(FIMFLEFLLCH<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public static class KEMCKJFMDAF
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public struct PCLIIBMPJCF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		public struct PCOLPKOKLEJ<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public PCLIIBMPJCF<TFrom> LBADBCNNFAH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public Allocator FKPADLBILGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public NativeArray<TFrom> BNKBFBBHHCL;
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public struct MGJBFLDNJMM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		public struct BKNNOGKLNJJ<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public MGJBFLDNJMM<TFrom> LBADBCNNFAH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public Allocator FKPADLBILGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public NativeArrayAsync<TFrom> BNKBFBBHHCL;
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public struct IFPDKHIFGNN<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200008E")]
		public struct MMJDLOGJHGK<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public IFPDKHIFGNN<TFrom> LBADBCNNFAH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public Allocator FKPADLBILGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public NativeListAsync<TFrom> BNKBFBBHHCL;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[BurstCompile]
internal struct LHANGOLLHDL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	[ReadOnly]
	public NativeArray<Entity> FPMGLBFKKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public EntityCommandBuffer FIENHHJAMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public ComponentType GDOKANFLACL;

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6AF5590", Offset = "0x6AF3D90", VA = "0x186AF5590", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class LEKBKADGMNN
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x35477C0", Offset = "0x3545FC0", VA = "0x1835477C0")]
	public static bool JEAGIJJPAJJ<T>(this NativeArray<Entity> NEDOPJDBOOK, EntityManager LMJGFJDJJLA, Allocator FKPADLBILGP = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public static class LGPACOKMPAG
{
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public static class OGBLNOHJMEC
{
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public abstract class MPCIDEABOID : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public virtual bool PNIPNPLFDND
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x811740", Offset = "0x80FF40", VA = "0x180811740", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0980", Offset = "0x6AEF180", VA = "0x186AF0980")]
	protected MPCIDEABOID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[DisableAutoCreation]
public sealed class KBHIFALNLKD : MPCIDEABOID
{
	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0980", Offset = "0x6AEF180", VA = "0x186AF0980")]
	public KBHIFALNLKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[DisableAutoCreation]
public sealed class DOAKBPMALDE : MPCIDEABOID
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0980", Offset = "0x6AEF180", VA = "0x186AF0980")]
	public DOAKBPMALDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[DisableAutoCreation]
public sealed class EFNEFEPPFKH : MPCIDEABOID
{
	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0980", Offset = "0x6AEF180", VA = "0x186AF0980")]
	public EFNEFEPPFKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[DisableAutoCreation]
public sealed class MABMHEFJONF : MPCIDEABOID
{
	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0980", Offset = "0x6AEF180", VA = "0x186AF0980")]
	public MABMHEFJONF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[DisableAutoCreation]
public sealed class LMHIAGOLJOP : MPCIDEABOID
{
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0980", Offset = "0x6AEF180", VA = "0x186AF0980")]
	public LMHIAGOLJOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[DisableAutoCreation]
public sealed class BMHHAHJPDDI : MPCIDEABOID
{
	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0980", Offset = "0x6AEF180", VA = "0x186AF0980")]
	public BMHHAHJPDDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[DisableAutoCreation]
public sealed class OPOBJELNJJN : MPCIDEABOID
{
	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0980", Offset = "0x6AEF180", VA = "0x186AF0980")]
	public OPOBJELNJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[DisableAutoCreation]
public sealed class NJEAGGCKFJJ : MPCIDEABOID
{
	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0980", Offset = "0x6AEF180", VA = "0x186AF0980")]
	public NJEAGGCKFJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[DisableAutoCreation]
public sealed class JCEBHADMNOP : MPCIDEABOID
{
	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0980", Offset = "0x6AEF180", VA = "0x186AF0980")]
	public JCEBHADMNOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public sealed class LDKGCNKMDOL : DBNDPGDFGFK
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0980", Offset = "0x6AEF180", VA = "0x186AF0980")]
	public LDKGCNKMDOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public sealed class LNPPLPJIOLK : DBNDPGDFGFK
{
	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0980", Offset = "0x6AEF180", VA = "0x186AF0980")]
	public LNPPLPJIOLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public sealed class BBDONECNJLI : DBNDPGDFGFK
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0980", Offset = "0x6AEF180", VA = "0x186AF0980")]
	public BBDONECNJLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public sealed class PFOGDLOOEFI : DBNDPGDFGFK
{
	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0980", Offset = "0x6AEF180", VA = "0x186AF0980")]
	public PFOGDLOOEFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[DisableAutoCreation]
[CFNBDFBCDKH(JBOAFHDNBDO.Application)]
public class DBNDPGDFGFK : MPCIDEABOID
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public override bool PNIPNPLFDND
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x80D0A0", Offset = "0x80B8A0", VA = "0x18080D0A0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0980", Offset = "0x6AEF180", VA = "0x186AF0980")]
	public DBNDPGDFGFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public static class FCPECJFOEDA
{
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly GPBKOAMMEHF MHNELLNABLC;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly KILLGJJIMEA ONMIOAAPGNP;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly ENNLNNLCJGJ HENDAAGLIDN;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly List<Type> LLHFOBCEBBF;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static bool NHOHANJCEON;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	internal static global::NBMCIPHNCFJ<DGLDCDLCECP> FIOMNDALOBN
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6AF1E00", Offset = "0x6AF0600", VA = "0x186AF1E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	internal static global::NBMCIPHNCFJ<MFCOBEFGBOI> GMLDEHHIHCF
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6AF1F40", Offset = "0x6AF0740", VA = "0x186AF1F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal static global::NBMCIPHNCFJ<AKKNCOHCIBK> IHDJMOOJEKC
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x6AF1EE0", Offset = "0x6AF06E0", VA = "0x186AF1EE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6AF1FA0", Offset = "0x6AF07A0", VA = "0x186AF1FA0")]
	public static void PBAELFIBGFO(bool HCKNDFMIDDI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6AF1E60", Offset = "0x6AF0660", VA = "0x186AF1E60")]
	public static Type[] HJHOGOLLNFB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class PCLEFMFPEJG
{
	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x23D3D80", Offset = "0x23D2580", VA = "0x1823D3D80")]
	[MustUseReturnValue]
	public static JobHandle EAEOFDKANDO<T>(this EntityCommandBufferSystem PPANIHNCFCJ, NativeArrayAsync<Entity> FPMGLBFKKPO, NativeArrayAsync<T> PHBHEFAPHDL, [Optional] JobHandle NPBMDGDOAPE) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x23D4290", Offset = "0x23D2A90", VA = "0x1823D4290")]
	[MustUseReturnValue]
	public static JobHandle EAEOFDKANDO<T>(this EntityCommandBufferSystem PPANIHNCFCJ, NativeArrayAsync<Entity> FPMGLBFKKPO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x23D3C60", Offset = "0x23D2460", VA = "0x1823D3C60")]
	[MustUseReturnValue]
	public static JobHandle EAEOFDKANDO<T>(this EntityCommandBufferSystem PPANIHNCFCJ, NativeArray<Entity> FPMGLBFKKPO, [Optional] JobHandle NPBMDGDOAPE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x23D4170", Offset = "0x23D2970", VA = "0x1823D4170")]
	[MustUseReturnValue]
	public static JobHandle EAEOFDKANDO<T>(this EntityCommandBufferSystem PPANIHNCFCJ, EntityCommandBuffer FIENHHJAMHI, NativeArray<Entity> FPMGLBFKKPO, [Optional] JobHandle NPBMDGDOAPE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6AF7AD0", Offset = "0x6AF62D0", VA = "0x186AF7AD0")]
	[MustUseReturnValue]
	public static JobHandle EAEOFDKANDO(this EntityCommandBufferSystem PPANIHNCFCJ, NativeArray<Entity> FPMGLBFKKPO, ComponentTypes FOAMMHNABBN, [Optional] JobHandle NPBMDGDOAPE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6AF7C30", Offset = "0x6AF6430", VA = "0x186AF7C30")]
	[MustUseReturnValue]
	public static JobHandle EAEOFDKANDO(this EntityCommandBufferSystem PPANIHNCFCJ, EntityCommandBuffer FIENHHJAMHI, NativeArray<Entity> FPMGLBFKKPO, ComponentTypes FOAMMHNABBN, [Optional] JobHandle NPBMDGDOAPE)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal static class MNHABNEGKKO
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6AF57F0", Offset = "0x6AF3FF0", VA = "0x186AF57F0")]
	private unsafe static Span<byte> PEAFCOBLFHI(Unity.Entities.Chunk* NLIPPJGPKOG, int BNNLAPKBIOF)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x2BFA3D0", Offset = "0x2BF8BD0", VA = "0x182BFA3D0")]
	public unsafe static Span<T> ELPMFKPEGBM<T>(Unity.Entities.Chunk* NLIPPJGPKOG, int BNNLAPKBIOF)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x2BFA390", Offset = "0x2BF8B90", VA = "0x182BFA390")]
	public static Span<T> ELPMFKPEGBM<T>(this ref Unity.Entities.Chunk NLIPPJGPKOG, int BNNLAPKBIOF)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6AF5780", Offset = "0x6AF3F80", VA = "0x186AF5780")]
	public unsafe static Span<Entity> LALLBDCAKCG(Unity.Entities.Chunk* NLIPPJGPKOG)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6AF55F0", Offset = "0x6AF3DF0", VA = "0x186AF55F0")]
	public unsafe static void ELJLHOEKJGC(Unity.Entities.Chunk* NLIPPJGPKOG, int BNNLAPKBIOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class MHCHCENMNNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> KIOMBJEIJNA;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x83A2B0", Offset = "0x838AB0", VA = "0x18083A2B0")]
	public MHCHCENMNNH(NativeArray<EntityRemapUtility.EntityRemapInfo> KIOMBJEIJNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6AF55E0", Offset = "0x6AF3DE0", VA = "0x186AF55E0")]
	public Entity DBJNDGJHGFE(Entity PDHOFJLLEID)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[AttributeUsage(AttributeTargets.Class)]
public class JDCCFBKCJNF : LBCLEEENKKC
{
	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x92DE00", Offset = "0x92C600", VA = "0x18092DE00")]
	public JDCCFBKCJNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class DFJLHCDMPLM
{
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public delegate void COKJNICGJFN<From, To>(From LBADBCNNFAH, ref To EBICJNCHIIB, MHCHCENMNNH LOCFGCDNKMP);

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private class FDMHKJOLODG<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public static COKJNICGJFN<From, To> JNHBOJOGBIK;

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public FDMHKJOLODG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6AF13B0", Offset = "0x6AEFBB0", VA = "0x186AF13B0")]
	static DFJLHCDMPLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x2EA4000", Offset = "0x2EA2800", VA = "0x182EA4000")]
	public static void HFEOPFFCKDC<T>(COKJNICGJFN<T, T> DPHLLPLPIPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x2EA3DC0", Offset = "0x2EA25C0", VA = "0x182EA3DC0")]
	public static void HFEOPFFCKDC<From, To>(COKJNICGJFN<From, To> DPHLLPLPIPO, COKJNICGJFN<To, From> AEKDEAOHPIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x2EA3D70", Offset = "0x2EA2570", VA = "0x182EA3D70")]
	public static void HFEOPFFCKDC<From, To>(COKJNICGJFN<From, To> JNHBOJOGBIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x2EAA170", Offset = "0x2EA8970", VA = "0x182EAA170")]
	public static COKJNICGJFN<From, To> MJKAMACBPFN<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x2EA2900", Offset = "0x2EA1100", VA = "0x182EA2900")]
	public static void GADGIPOPPJA<From, To>(From LBADBCNNFAH, ref To EBICJNCHIIB, MHCHCENMNNH LOCFGCDNKMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public interface HPAEPEPEKLI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KNDGHBJCIPF(Entity CMBJDMJHALL, object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PAALMADNNKG(Entity CMBJDMJHALL, object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BABEIMNAAGJ(Entity CMBJDMJHALL);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IEnumerable<object> OKAKGJPNIKC(Entity CMBJDMJHALL);

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GIOFBNMLLED(Entity CMBJDMJHALL);
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public class FHFLBOGHGEP<TComponentData, TValue> : global::BMDNPKBCNJC<TValue>, IDisposable where TComponentData : struct, FBNBLAKKAPF
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	private class EIHNAINMAEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private List<(object token, TValue value)> IFADMANLNLG;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int PLEPIEDOEAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x1CA0870", Offset = "0x1C9F070", VA = "0x181CA0870")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3862B00", Offset = "0x3861300", VA = "0x183862B00")]
		public bool BHPOOGEBGBI(out TValue ECNGHFJBIJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3862BC0", Offset = "0x38613C0", VA = "0x183862BC0")]
		public void CAILCKFFJIK(object FLDJLPKNKKO, TValue ECNGHFJBIJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3862C70", Offset = "0x3861470", VA = "0x183862C70")]
		public bool CPPHPNNFPKL(object FLDJLPKNKKO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3862CF0", Offset = "0x38614F0", VA = "0x183862CF0")]
		public int HNIOFAKCMJD(object FLDJLPKNKKO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3862DA0", Offset = "0x38615A0", VA = "0x183862DA0")]
		public EIHNAINMAEH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly Stack<EIHNAINMAEH> BODHCNIOABE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private global::FDLDIAADLDC<GHBLMLDHKJD, EIHNAINMAEH> DABHKCECOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private EntityManager LMJGFJDJJLA;

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x35F3BA0", Offset = "0x35F23A0", VA = "0x1835F3BA0")]
	public FHFLBOGHGEP(EntityManager LMJGFJDJJLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x35F3870", Offset = "0x35F2070", VA = "0x1835F3870", Slot = "4")]
	public void KNDGHBJCIPF(Entity CMBJDMJHALL, object FLDJLPKNKKO, TValue ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x35F3A10", Offset = "0x35F2210", VA = "0x1835F3A10", Slot = "5")]
	public bool PAALMADNNKG(Entity CMBJDMJHALL, object FLDJLPKNKKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x35F3550", Offset = "0x35F1D50", VA = "0x1835F3550", Slot = "6")]
	public bool BHPOOGEBGBI(Entity CMBJDMJHALL, out TValue ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x35F3620", Offset = "0x35F1E20", VA = "0x1835F3620", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x35F3990", Offset = "0x35F2190", VA = "0x1835F3990")]
	private void MNHCHBKDDDE(EIHNAINMAEH LMFCFNPNFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x35F36D0", Offset = "0x35F1ED0", VA = "0x1835F36D0")]
	private bool FCFJFPIFDIM(Entity CMBJDMJHALL, out GHBLMLDHKJD AAFHCAILJEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x35F3640", Offset = "0x35F1E40", VA = "0x1835F3640")]
	private void EDFGBFBDCCH(Entity CMBJDMJHALL, GHBLMLDHKJD AAFHCAILJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x35F3530", Offset = "0x35F1D30", VA = "0x1835F3530")]
	private bool AEKGODAMIKA(GHBLMLDHKJD AAFHCAILJEB, out EIHNAINMAEH LMFCFNPNFHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x35F37A0", Offset = "0x35F1FA0", VA = "0x1835F37A0")]
	private EIHNAINMAEH HPOCDGDDLDI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public interface BMDNPKBCNJC<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KNDGHBJCIPF(Entity CMBJDMJHALL, object FLDJLPKNKKO, TValue ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PAALMADNNKG(Entity CMBJDMJHALL, object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BHPOOGEBGBI(Entity CMBJDMJHALL, out TValue ECNGHFJBIJL);
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public interface FBNBLAKKAPF : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	GHBLMLDHKJD IFBAAEKPOPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public struct GHBLMLDHKJD : global::NMBLHKCDDCH<GHBLMLDHKJD>, LHEDDDDOOOA, IEquatable<GHBLMLDHKJD>
{
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static readonly GHBLMLDHKJD BGKJPCCCNHP;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	[CreateProperty]
	public int OJOINFOLDPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x95A520", Offset = "0x958D20", VA = "0x18095A520", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x9E26F0", Offset = "0x9E0EF0", VA = "0x1809E26F0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	[CreateProperty]
	public int ODKLBHBAMKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xB83B10", Offset = "0xB82310", VA = "0x180B83B10", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x10CDBC0", Offset = "0x10CC3C0", VA = "0x1810CDBC0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x6AF2520", Offset = "0x6AF0D20", VA = "0x186AF2520", Slot = "8")]
	public bool Equals(GHBLMLDHKJD MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x6AF2570", Offset = "0x6AF0D70", VA = "0x186AF2570", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public class BEMINCHFLDP<THasTokensTag> : HPAEPEPEKLI, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private Dictionary<Entity, GHBLMLDHKJD> LNAIAMIIAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly Stack<HashSet<object>> BODHCNIOABE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private global::FDLDIAADLDC<GHBLMLDHKJD, HashSet<object>> DABHKCECOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private EntityManager LMJGFJDJJLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private EntityCommandBufferSystem PPANIHNCFCJ;

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x2D0EED0", Offset = "0x2D0D6D0", VA = "0x182D0EED0")]
	public BEMINCHFLDP(EntityManager LMJGFJDJJLA, EntityCommandBufferSystem PPANIHNCFCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x2D0D930", Offset = "0x2D0C130", VA = "0x182D0D930", Slot = "4")]
	public bool KNDGHBJCIPF(Entity CMBJDMJHALL, object FLDJLPKNKKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x2D0E7A0", Offset = "0x2D0CFA0", VA = "0x182D0E7A0", Slot = "5")]
	public bool PAALMADNNKG(Entity CMBJDMJHALL, object FLDJLPKNKKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x2D0BBB0", Offset = "0x2D0A3B0", VA = "0x182D0BBB0", Slot = "6")]
	public bool BABEIMNAAGJ(Entity CMBJDMJHALL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x2D0BCD0", Offset = "0x2D0A4D0", VA = "0x182D0BCD0", Slot = "10")]
	public bool BABEIMNAAGJ(GHBLMLDHKJD AAFHCAILJEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x2D0E160", Offset = "0x2D0C960", VA = "0x182D0E160", Slot = "7")]
	public IEnumerable<object> OKAKGJPNIKC(Entity CMBJDMJHALL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x2D0DE20", Offset = "0x2D0C620", VA = "0x182D0DE20", Slot = "11")]
	public IEnumerable<object> OKAKGJPNIKC(GHBLMLDHKJD AAFHCAILJEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x2D0CD40", Offset = "0x2D0B540", VA = "0x182D0CD40", Slot = "8")]
	public bool GIOFBNMLLED(Entity CMBJDMJHALL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x2D0C2A0", Offset = "0x2D0AAA0", VA = "0x182D0C2A0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x2D0DDB0", Offset = "0x2D0C5B0", VA = "0x182D0DDB0")]
	private void MNHCHBKDDDE(HashSet<object> LMFCFNPNFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x2D0CBD0", Offset = "0x2D0B3D0", VA = "0x182D0CBD0")]
	private bool FCFJFPIFDIM(Entity CMBJDMJHALL, out GHBLMLDHKJD AAFHCAILJEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x2D0BFC0", Offset = "0x2D0A7C0", VA = "0x182D0BFC0")]
	private bool CBHPCKALGDL(Entity CMBJDMJHALL, out GHBLMLDHKJD AAFHCAILJEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x2D0BD70", Offset = "0x2D0A570", VA = "0x182D0BD70")]
	private void BHODPDIAEHL(Entity CMBJDMJHALL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x2D0CCB0", Offset = "0x2D0B4B0", VA = "0x182D0CCB0")]
	private void GGMNININJIL(Entity CMBJDMJHALL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x2D0C7D0", Offset = "0x2D0AFD0", VA = "0x182D0C7D0")]
	private void EGALBADHMDN(Entity CMBJDMJHALL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x2D0C3A0", Offset = "0x2D0ABA0", VA = "0x182D0C3A0")]
	private void EDFGBFBDCCH(Entity CMBJDMJHALL, GHBLMLDHKJD AAFHCAILJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x2D0EBF0", Offset = "0x2D0D3F0", VA = "0x182D0EBF0")]
	private bool PECCHAKOOEA(GHBLMLDHKJD AAFHCAILJEB, out HashSet<object> LMFCFNPNFHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x2D0D290", Offset = "0x2D0BA90", VA = "0x182D0D290")]
	private HashSet<object> HPOCDGDDLDI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public static class PHGJCBGFBPF
{
	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80")]
	public static void ILDGJLPOJDH(this MFFHLJHLBIG HGFFDKCANPF, NativeArray<Entity> FPMGLBFKKPO, [Optional][CallerFilePath] string FJCMLALIJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80")]
	public static void ILDGJLPOJDH(this MFFHLJHLBIG HGFFDKCANPF, string BPOKAAOBIOI, NativeArray<Entity> FPMGLBFKKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80")]
	public static void ILDGJLPOJDH(this MFFHLJHLBIG HGFFDKCANPF, string FJCMLALIJKN, NativeArray<Entity> FPMGLBFKKPO, bool GPMFMCCDAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80")]
	public static void KMEDBMIIJKB(this MFFHLJHLBIG HGFFDKCANPF, NativeArray<Entity> FPMGLBFKKPO, EntityManager LMJGFJDJJLA, [Optional][CallerFilePath] string FJCMLALIJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80")]
	public static void KMEDBMIIJKB(this MFFHLJHLBIG HGFFDKCANPF, string FJCMLALIJKN, NativeArray<Entity> FPMGLBFKKPO, EntityManager LMJGFJDJJLA, bool GPMFMCCDAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80")]
	public static void EDLBCPBGPME(this MFFHLJHLBIG HGFFDKCANPF, NativeArray<Entity> FPMGLBFKKPO, NativeArray<Entity> MHKKJIBKAII, [Optional][CallerFilePath] string FJCMLALIJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80")]
	public static void EDLBCPBGPME(this MFFHLJHLBIG HGFFDKCANPF, string FJCMLALIJKN, NativeArray<Entity> FPMGLBFKKPO, NativeArray<Entity> MHKKJIBKAII, bool GPMFMCCDAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x23D7AD0", Offset = "0x23D62D0", VA = "0x1823D7AD0")]
	public static void JDMCCAKBGDF<T>(this MFFHLJHLBIG HGFFDKCANPF, string BPOKAAOBIOI, NativeArray<Entity> FPMGLBFKKPO, NativeList<T> PHBHEFAPHDL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x23D7A80", Offset = "0x23D6280", VA = "0x1823D7A80")]
	public static void JDMCCAKBGDF<T>(this MFFHLJHLBIG HGFFDKCANPF, NativeArray<Entity> FPMGLBFKKPO, NativeArray<T> PHBHEFAPHDL, [Optional][CallerFilePath] string FJCMLALIJKN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x23D7A40", Offset = "0x23D6240", VA = "0x1823D7A40")]
	public static void JDMCCAKBGDF<T>(this MFFHLJHLBIG HGFFDKCANPF, string BPOKAAOBIOI, NativeArray<Entity> FPMGLBFKKPO, NativeArray<T> PHBHEFAPHDL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80")]
	public static void JDMCCAKBGDF<T>(this MFFHLJHLBIG HGFFDKCANPF, string FJCMLALIJKN, NativeArray<Entity> FPMGLBFKKPO, NativeArray<T> PHBHEFAPHDL, bool GPMFMCCDAKI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x23D79E0", Offset = "0x23D61E0", VA = "0x1823D79E0")]
	public static void HCJINHBILHH<T>(this MFFHLJHLBIG HGFFDKCANPF, NativeList<T> PHBHEFAPHDL, [Optional][CallerFilePath] string FJCMLALIJKN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x23D79B0", Offset = "0x23D61B0", VA = "0x1823D79B0")]
	public static void HCJINHBILHH<T>(this MFFHLJHLBIG HGFFDKCANPF, NativeArray<T> PHBHEFAPHDL, [Optional][CallerFilePath] string FJCMLALIJKN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80")]
	public static void HCJINHBILHH<T>(this MFFHLJHLBIG HGFFDKCANPF, string FJCMLALIJKN, NativeArray<T> PHBHEFAPHDL, bool GPMFMCCDAKI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80")]
	public static void AJKDGOHMJHC(this MFFHLJHLBIG HGFFDKCANPF, EntityQuery DPBAMGMJJLC, [Optional][CallerFilePath] string FJCMLALIJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80")]
	public static void AJKDGOHMJHC(this MFFHLJHLBIG HGFFDKCANPF, string BPOKAAOBIOI, EntityQuery DPBAMGMJJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80")]
	public static void AJKDGOHMJHC(this MFFHLJHLBIG HGFFDKCANPF, string FJCMLALIJKN, EntityQuery DPBAMGMJJLC, bool GPMFMCCDAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x23D7980", Offset = "0x23D6180", VA = "0x1823D7980")]
	public static void FNDFMMEAAEN<T, T2>(this MFFHLJHLBIG HGFFDKCANPF, string BPOKAAOBIOI, EntityQuery DPBAMGMJJLC) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80")]
	private static void FNDFMMEAAEN<T, T2>(this MFFHLJHLBIG HGFFDKCANPF, string FJCMLALIJKN, EntityQuery DPBAMGMJJLC, bool GPMFMCCDAKI) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x23D7980", Offset = "0x23D6180", VA = "0x1823D7980")]
	public static void EGHOIJKPJMO<T>(this MFFHLJHLBIG HGFFDKCANPF, string BPOKAAOBIOI, NativeList<T> EABDNHJFDCB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80")]
	public static void EGHOIJKPJMO<T>(this MFFHLJHLBIG HGFFDKCANPF, string FJCMLALIJKN, NativeList<T> EABDNHJFDCB, bool GPMFMCCDAKI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x23D7980", Offset = "0x23D6180", VA = "0x1823D7980")]
	public static void KKECINMOKAL<T>(this MFFHLJHLBIG HGFFDKCANPF, string BPOKAAOBIOI, NativeArray<T> EABDNHJFDCB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80")]
	public static void KKECINMOKAL<T>(this MFFHLJHLBIG HGFFDKCANPF, string FJCMLALIJKN, NativeArray<T> EABDNHJFDCB, bool GPMFMCCDAKI) where T : struct
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public class PFBBJKPLBFC
{
	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	public PFBBJKPLBFC()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public class __BB_OBFUSCATOR_VERSION_3_9_9
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
