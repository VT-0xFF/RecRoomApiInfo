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
		[Cpp2IlInjected.Address(RVA = "0x7F0020", Offset = "0x7EEC20", VA = "0x1807F0020")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F0020", Offset = "0x7EEC20", VA = "0x1807F0020")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A87420", Offset = "0x6A86020", VA = "0x186A87420")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A86770", Offset = "0x6A85370", VA = "0x186A86770", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A87C40", Offset = "0x6A86840", VA = "0x186A87C40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x858040", Offset = "0x856C40", VA = "0x180858040", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x31CB090", Offset = "0x31C9C90", VA = "0x1831CB090", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x254D490", Offset = "0x254C090", VA = "0x18254D490")]
		[DebuggerHidden]
		public OPGKAGIBAJJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x31CAEA0", Offset = "0x31C9AA0", VA = "0x1831CAEA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x31CB050", Offset = "0x31C9C50", VA = "0x1831CB050", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F0230", Offset = "0x7EEE30", VA = "0x1807F0230")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3A83C00", Offset = "0x3A82800", VA = "0x183A83C00")]
	private PGLAGHJANGJ(byte[] NLANKBLAOCO, Action<Protobuf> GCGGKDKNPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3480AC0", Offset = "0x347F6C0", VA = "0x183480AC0")]
	public static global::PGLAGHJANGJ<Protobuf> JLAKJAPJOGA<Data>(ReadOnlySpan<byte> KNJBCHEFCED, ReadOnlySpan<Data> CHCFPJJJGHE, Action<Protobuf> GCGGKDKNPNA)
	{
		return default(global::PGLAGHJANGJ<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3A83A70", Offset = "0x3A82670", VA = "0x183A83A70", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3A83AB0", Offset = "0x3A826B0", VA = "0x183A83AB0", Slot = "4")]
	[IteratorStateMachine(typeof(global::PGLAGHJANGJ<>.OPGKAGIBAJJ))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3A83BB0", Offset = "0x3A827B0", VA = "0x183A83BB0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x477C5B0", Offset = "0x477B1B0", VA = "0x18477C5B0")]
	private HOEKDGLKAAO(byte[] NLANKBLAOCO, in Protobuf JNADKFFEIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3F3CF70", Offset = "0x3F3BB70", VA = "0x183F3CF70")]
	public static global::HOEKDGLKAAO<Protobuf> JLAKJAPJOGA<T>(ReadOnlySpan<T> CHCFPJJJGHE)
	{
		return default(global::HOEKDGLKAAO<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x477C580", Offset = "0x477B180", VA = "0x18477C580")]
	public void LGBBBNEBCGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x477C4F0", Offset = "0x477B0F0", VA = "0x18477C4F0")]
	public ByteString GBLNIBAJACB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x477C3C0", Offset = "0x477AFC0", VA = "0x18477C3C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3DF8530", Offset = "0x3DF7130", VA = "0x183DF8530")]
		public static void LEAMKENGDJN(in T PHMLIFLNFDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x14BBF20", Offset = "0x14BAB20", VA = "0x1814BBF20")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A8CFE0", Offset = "0x6A8BBE0", VA = "0x186A8CFE0")]
	public OFALOACMNEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x20F6BB0", Offset = "0x20F57B0", VA = "0x1820F6BB0")]
	public void OLBGCODNBJK<T>(T ECNGHFJBIJL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x20F87D0", Offset = "0x20F73D0", VA = "0x1820F87D0")]
	public T PNBJHLBKMLC<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6A8CBE0", Offset = "0x6A8B7E0", VA = "0x186A8CBE0")]
	public void OLBGCODNBJK(Type FIJCKHKKDCC, CCENOJCALNE ECNGHFJBIJL, int KPLFNABLLDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6A8CDB0", Offset = "0x6A8B9B0", VA = "0x186A8CDB0")]
	public bool PFLIDDOFNIB(Type FIJCKHKKDCC, out CCENOJCALNE PHBHEFAPHDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6A8CE80", Offset = "0x6A8BA80", VA = "0x186A8CE80")]
	public CCENOJCALNE PNBJHLBKMLC(Type FIJCKHKKDCC)
	{
		return default(CCENOJCALNE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6A8C840", Offset = "0x6A8B440", VA = "0x186A8C840")]
	public NativeArray<byte>.ReadOnly HNLDJCACBNM(Type FIJCKHKKDCC)
	{
		return default(NativeArray<byte>.ReadOnly);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6A8CA50", Offset = "0x6A8B650", VA = "0x186A8CA50")]
	public bool NAFOHKNGFLD(Type FIJCKHKKDCC, out NativeArray<byte>.ReadOnly PHBHEFAPHDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6A8C5B0", Offset = "0x6A8B1B0", VA = "0x186A8C5B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6A8C650", Offset = "0x6A8B250", VA = "0x186A8C650", Slot = "1")]
	~OFALOACMNEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6A8C770", Offset = "0x6A8B370", VA = "0x186A8C770")]
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
		[Cpp2IlInjected.Address(RVA = "0x3BC91D0", Offset = "0x3BC7DD0", VA = "0x183BC91D0")]
		get
		{
			return (T)null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3BCCA70", Offset = "0x3BCB670", VA = "0x183BCCA70")]
	public static global::BAGKINIFOEG<T> DGIADCHILCD(T ECNGHFJBIJL)
	{
		return default(global::BAGKINIFOEG<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3BCA610", Offset = "0x3BC9210", VA = "0x183BCA610")]
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
	[Cpp2IlInjected.Address(RVA = "0x2E9F110", Offset = "0x2E9DD10", VA = "0x182E9F110")]
	public static void OLBGCODNBJK<T>(T ECNGHFJBIJL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2EA0320", Offset = "0x2E9EF20", VA = "0x182EA0320")]
	public static T PNBJHLBKMLC<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6A87C80", Offset = "0x6A86880", VA = "0x186A87C80")]
	public static NativeArray<byte>.ReadOnly HNLDJCACBNM(Type FIJCKHKKDCC)
	{
		return default(NativeArray<byte>.ReadOnly);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6A87D10", Offset = "0x6A86910", VA = "0x186A87D10")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E49B0", Offset = "0x8E35B0", VA = "0x1808E49B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int PLEPIEDOEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xAE5B60", Offset = "0xAE4760", VA = "0x180AE5B60")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x139CA40", Offset = "0x139B640", VA = "0x18139CA40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int FGLOEBEFDGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8E49B0", Offset = "0x8E35B0", VA = "0x1808E49B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x96CBB0", Offset = "0x96B7B0", VA = "0x18096CBB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int FGKHEPONKIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6A86930", Offset = "0x6A85530", VA = "0x186A86930")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6A86940", Offset = "0x6A85540", VA = "0x186A86940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x81E4F0", Offset = "0x81D0F0", VA = "0x18081E4F0")]
	private DFGMPCKANBL(int MCMFGBNCCMI, int FGHOJPFDCIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x39FE950", Offset = "0x39FD550", VA = "0x1839FE950")]
	public static DFGMPCKANBL AKNOMGKADJH(int MCMFGBNCCMI, int FGHOJPFDCIA)
	{
		return default(DFGMPCKANBL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6A86950", Offset = "0x6A85550", VA = "0x186A86950")]
	public static DFGMPCKANBL NNFPOLINMML(int DBEIIGKEBIB, int NBBICLPHKEO)
	{
		return default(DFGMPCKANBL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6A86960", Offset = "0x6A85560", VA = "0x186A86960", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A873A0", Offset = "0x6A85FA0", VA = "0x186A873A0")]
	public float IAODJDJKLAM(in float3 ECNGHFJBIJL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6A873A0", Offset = "0x6A85FA0", VA = "0x186A873A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A87B50", Offset = "0x6A86750", VA = "0x186A87B50")]
	public float IAODJDJKLAM(in float3 ECNGHFJBIJL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6A87B50", Offset = "0x6A86750", VA = "0x186A87B50", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x15DF8B0", Offset = "0x15DE4B0", VA = "0x1815DF8B0")]
	public float IAODJDJKLAM(in float3 ECNGHFJBIJL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x15DF8B0", Offset = "0x15DE4B0", VA = "0x1815DF8B0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x17DFA00", Offset = "0x17DE600", VA = "0x1817DFA00")]
	public int IAODJDJKLAM(in int3 ECNGHFJBIJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x17DFA00", Offset = "0x17DE600", VA = "0x1817DFA00", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6642C20", Offset = "0x6641820", VA = "0x186642C20")]
	public int IAODJDJKLAM(in int3 ECNGHFJBIJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6642C20", Offset = "0x6641820", VA = "0x186642C20", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2557B60", Offset = "0x2556760", VA = "0x182557B60")]
	public int IAODJDJKLAM(in int3 ECNGHFJBIJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2557B60", Offset = "0x2556760", VA = "0x182557B60", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A866E0", Offset = "0x6A852E0", VA = "0x186A866E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x837A60", Offset = "0x836660", VA = "0x180837A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public World HGMOJEBDBNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public EntityManager EHBCKOIMEPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6A852D0", Offset = "0x6A83ED0", VA = "0x186A852D0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public PGDOKNDMILI IOEFOKHCAJD
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8370C0", Offset = "0x835CC0", VA = "0x1808370C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public global::BFJGLKGJIEH<DGLDCDLCECP> FIOMNDALOBN
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x84D780", Offset = "0x84C380", VA = "0x18084D780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8A4420", Offset = "0x8A3020", VA = "0x1808A4420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public global::BFJGLKGJIEH<MFCOBEFGBOI> GMLDEHHIHCF
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x83EB00", Offset = "0x83D700", VA = "0x18083EB00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x83EB20", Offset = "0x83D720", VA = "0x18083EB20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public global::BFJGLKGJIEH<AKKNCOHCIBK> IHDJMOOJEKC
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x83EB10", Offset = "0x83D710", VA = "0x18083EB10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x83EB30", Offset = "0x83D730", VA = "0x18083EB30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public World.NoAllocReadOnlyCollection<ComponentSystemBase> DJFECEFGDAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x31F3100", Offset = "0x31F1D00", VA = "0x1831F3100")]
		get
		{
			return default(World.NoAllocReadOnlyCollection<ComponentSystemBase>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public ComponentSystemGroup[] OMPKIAOLEMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7F0240", Offset = "0x7EEE40", VA = "0x1807F0240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6A84F10", Offset = "0x6A83B10", VA = "0x186A84F10")]
	public static AFEABPHNIHP DMJMIMLAFKK(string BPOKAAOBIOI, LNGKPFAGLPC BJCAHHPNCBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6A857D0", Offset = "0x6A843D0", VA = "0x186A857D0")]
	public AFEABPHNIHP(string BPOKAAOBIOI, LNGKPFAGLPC BJCAHHPNCBK = LNGKPFAGLPC.Simulation, PACEBIKNHGA MDFPINHICMD = PACEBIKNHGA.Default, bool HCKNDFMIDDI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6A85520", Offset = "0x6A84120", VA = "0x186A85520")]
	public ComponentSystemBase KHHDMEMKEDJ(Type FIJCKHKKDCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1958F00", Offset = "0x1957B00", VA = "0x181958F00")]
	public T KHHDMEMKEDJ<T>() where T : ComponentSystemBase
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6A84EB0", Offset = "0x6A83AB0", VA = "0x186A84EB0")]
	public void DCKJOFGAPLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6A852F0", Offset = "0x6A83EF0", VA = "0x186A852F0")]
	public void GIACMDIKOIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6A85690", Offset = "0x6A84290", VA = "0x186A85690")]
	public void PGDHBFKNGNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6A85540", Offset = "0x6A84140", VA = "0x186A85540")]
	public void KNIMMGCFILF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6A854C0", Offset = "0x6A840C0", VA = "0x186A854C0")]
	public void JJNLLMFNELN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6A85460", Offset = "0x6A84060", VA = "0x186A85460")]
	public void HKOIOEAKGFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6A84D70", Offset = "0x6A83970", VA = "0x186A84D70")]
	public void AKENMPCLMGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6A855A0", Offset = "0x6A841A0", VA = "0x186A855A0")]
	public void LCAKHHGPIIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6A84E50", Offset = "0x6A83A50", VA = "0x186A84E50")]
	public void BBHKPPJGGFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6A85630", Offset = "0x6A84230", VA = "0x186A85630")]
	public void NLGPPFHEBBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6A856F0", Offset = "0x6A842F0", VA = "0x186A856F0")]
	internal void PNFOINLDGBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6A84DD0", Offset = "0x6A839D0", VA = "0x186A84DD0")]
	private bool ALEFOKBFGFM(ComponentSystemGroup JDPPDHMPNHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6A85000", Offset = "0x6A83C00", VA = "0x186A85000")]
	private void ELNAGHBBCAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6A85350", Offset = "0x6A83F50", VA = "0x186A85350")]
	private ComponentSystemGroup[] HDEMIFJCDLH(PACEBIKNHGA MDFPINHICMD, bool IBDLFJOOKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6A84F90", Offset = "0x6A83B90", VA = "0x186A84F90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class MOEGJNFINMG
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6A8C2D0", Offset = "0x6A8AED0", VA = "0x186A8C2D0")]
	[MustUseReturnValue]
	public static JobHandle ACLJCEMAKJG(this EntityCommandBufferSystem PPANIHNCFCJ, NativeList<Entity> FPMGLBFKKPO, [Optional] JobHandle NPBMDGDOAPE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6A8C460", Offset = "0x6A8B060", VA = "0x186A8C460")]
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
	[Cpp2IlInjected.Address(RVA = "0x2906FF0", Offset = "0x2905BF0", VA = "0x182906FF0")]
	public static void PGBDIAMPABG<T>(this EntityCommandBufferSystem PPANIHNCFCJ, EntityQuery DPBAMGMJJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2906F30", Offset = "0x2905B30", VA = "0x182906F30")]
	[MustUseReturnValue]
	public static JobHandle OPNCEBPJOEE<T>(this EntityCommandBufferSystem PPANIHNCFCJ, NativeListAsync<Entity> FPMGLBFKKPO, [Optional] JobHandle NPBMDGDOAPE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x29067B0", Offset = "0x29053B0", VA = "0x1829067B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x837A60", Offset = "0x836660", VA = "0x180837A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6A8D550", Offset = "0x6A8C150", VA = "0x186A8D550")]
	public PGDOKNDMILI(AFEABPHNIHP GPEEKLGBDDJ, EntityManager LMJGFJDJJLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x210A4E0", Offset = "0x21090E0", VA = "0x18210A4E0")]
	public bool MDBBGOOJDFA<T>(Entity CMBJDMJHALL) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x210A520", Offset = "0x2109120", VA = "0x18210A520")]
	public bool MOFPCFDEKAK<T>(Entity CMBJDMJHALL, out T ECNGHFJBIJL) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2108990", Offset = "0x2107590", VA = "0x182108990")]
	public T LMPKJKBGPGN<T>(Entity CMBJDMJHALL) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2108110", Offset = "0x2106D10", VA = "0x182108110")]
	private ComponentType CKIBMPCHEKG<T>() where T : struct, IComponent
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6A8D3C0", Offset = "0x6A8BFC0", VA = "0x186A8D3C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x26E6F90", Offset = "0x26E5B90", VA = "0x1826E6F90")]
		public NativeListAsync<Entity> EKPJNDPEBEC<TPredicate>() where TPredicate : struct, global::GICACEPGEBH<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2B812C0", Offset = "0x2B7FEC0", VA = "0x182B812C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F3030", Offset = "0x7F1C30", VA = "0x1807F3030")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6A8C560", Offset = "0x6A8B160", VA = "0x186A8C560")]
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
	[Cpp2IlInjected.Address(RVA = "0x96B830", Offset = "0x96A430", VA = "0x18096B830")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xAF7620", Offset = "0xAF6220", VA = "0x180AF7620")]
		[DebuggerHidden]
		public IOPAFAFHAGP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6A89500", Offset = "0x6A88100", VA = "0x186A89500", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6A89240", Offset = "0x6A87E40", VA = "0x186A89240", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6A891F0", Offset = "0x6A87DF0", VA = "0x186A891F0")]
		private void EHFOANOMIIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6A894C0", Offset = "0x6A880C0", VA = "0x186A894C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6A89410", Offset = "0x6A88010", VA = "0x186A89410", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6A89410", Offset = "0x6A88010", VA = "0x186A89410", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A8A050", Offset = "0x6A88C50", VA = "0x186A8A050")]
	public static JGJKMCDDCIF JLAKJAPJOGA()
	{
		return default(JGJKMCDDCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6A89890", Offset = "0x6A88490", VA = "0x186A89890")]
	public JGJKMCDDCIF EHMLDGBAGOA(PACEBIKNHGA BJCAHHPNCBK)
	{
		return default(JGJKMCDDCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6A8A070", Offset = "0x6A88C70", VA = "0x186A8A070")]
	public JGJKMCDDCIF MGMHFKGFOFF(IEnumerable<Type> LONDNADJAMP)
	{
		return default(JGJKMCDDCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6A8A040", Offset = "0x6A88C40", VA = "0x186A8A040")]
	public JGJKMCDDCIF JBLFHNMIOGD(bool GHPCJNFPKGM)
	{
		return default(JGJKMCDDCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6A89620", Offset = "0x6A88220", VA = "0x186A89620")]
	public JGJKMCDDCIF ANDLEFEEEPE(bool GCELNGKNAOM)
	{
		return default(JGJKMCDDCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6A89630", Offset = "0x6A88230", VA = "0x186A89630")]
	public NFFGPMNOCOF DIEOPPNBAEK(Type[] AGMDDLAFMJO)
	{
		return default(NFFGPMNOCOF);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6A89590", Offset = "0x6A88190", VA = "0x186A89590")]
	[IteratorStateMachine(typeof(IOPAFAFHAGP))]
	internal IEnumerable<Type> AICMJJAPNCN(IEnumerable<Type> LONDNADJAMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6A8A0B0", Offset = "0x6A88CB0", VA = "0x186A8A0B0")]
	internal Dictionary<Type, List<Type>> OABGBMBILEN(IEnumerable<Type> LONDNADJAMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6A8A390", Offset = "0x6A88F90", VA = "0x186A8A390")]
	private void OEHCIJIJMIF(Dictionary<Type, List<Type>> KKIGAGCNEHG, Type FIJCKHKKDCC, Type GFFIJCJGAJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6A896D0", Offset = "0x6A882D0", VA = "0x186A896D0")]
	internal HashSet<Type> EDNHPFBFDOM(IEnumerable<Type> CJGHDKIGFAL, Dictionary<Type, List<Type>> GNJLJGGMKOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6A898A0", Offset = "0x6A884A0", VA = "0x186A898A0")]
	internal bool IKGLIEFNFGE(Type FIJCKHKKDCC, PACEBIKNHGA MDFPINHICMD, bool IBDLFJOOKBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6A89EE0", Offset = "0x6A88AE0", VA = "0x186A89EE0")]
	[CompilerGenerated]
	internal static void IPMIDCOKMOD(Type FIJCKHKKDCC, ref DPMOLDAINHO P_1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class DOLJLBPFGJJ
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x39A9200", Offset = "0x39A7E00", VA = "0x1839A9200")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A8D5A0", Offset = "0x6A8C1A0", VA = "0x186A8D5A0")]
		[BurstCompatible]
		public Entity IAODJDJKLAM(in Entity ECNGHFJBIJL)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6A8D5A0", Offset = "0x6A8C1A0", VA = "0x186A8D5A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A85CF0", Offset = "0x6A848F0", VA = "0x186A85CF0")]
	public static bool BIIFBHKMNEE(Type FIJCKHKKDCC, Type DGDGPJEIFCF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public abstract class PMDCKHPFFBE : DEOJGEHECCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6A8D650", Offset = "0x6A8C250", VA = "0x186A8D650", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected abstract ComponentSystemBase ACOOADPIPBA();

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6A8D600", Offset = "0x6A8C200", VA = "0x186A8D600")]
	protected ComponentSystemBase OPDBPNNIPNJ(params ComponentSystemBase[] KHIAODMJMEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x210D700", Offset = "0x210C300", VA = "0x18210D700")]
	protected ComponentSystemBase OPDBPNNIPNJ<T>(params ComponentSystemBase[] KHIAODMJMEB) where T : DEOJGEHECCJ, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x210D5E0", Offset = "0x210C1E0", VA = "0x18210D5E0")]
	protected ComponentSystemBase BJAGJCDLMMK<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x210D5E0", Offset = "0x210C1E0", VA = "0x18210D5E0")]
	protected ComponentSystemBase DGPKLMJLFNH<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6A8D5B0", Offset = "0x6A8C1B0", VA = "0x186A8D5B0")]
	protected ComponentSystemBase MKLPCEGIBBD(params SystemHandleUntyped[] KHIAODMJMEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x210D620", Offset = "0x210C220", VA = "0x18210D620")]
	protected ComponentSystemBase MKLPCEGIBBD<T>(params SystemHandleUntyped[] KHIAODMJMEB) where T : DEOJGEHECCJ, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x210D6B0", Offset = "0x210C2B0", VA = "0x18210D6B0")]
	protected SystemHandleUntyped NMNKIAIFLEC<T>() where T : struct, ISystem
	{
		return default(SystemHandleUntyped);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6A868A0", Offset = "0x6A854A0", VA = "0x186A868A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2EA5250", Offset = "0x2EA3E50", VA = "0x182EA5250")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BDC820", Offset = "0x2BDB420", VA = "0x182BDC820", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A87F00", Offset = "0x6A86B00", VA = "0x186A87F00")]
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
	[Cpp2IlInjected.Address(RVA = "0x1A03E10", Offset = "0x1A02A10", VA = "0x181A03E10")]
	public IBHAHBMDJLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x1A03C80", Offset = "0x1A02880", VA = "0x181A03C80", Slot = "4")]
	public bool ODOLPHCGINH(int GJCJMGJCOPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x1A039D0", Offset = "0x1A025D0", VA = "0x181A039D0", Slot = "5")]
	public global::BFJGLKGJIEH<BaseClass> MINFOLDOHDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x1A037A0", Offset = "0x1A023A0", VA = "0x181A037A0", Slot = "7")]
	protected virtual bool BIIFBHKMNEE(Type FIJCKHKKDCC, int GIOIBEJJEBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x1A03CE0", Offset = "0x1A028E0", VA = "0x181A03CE0", Slot = "8")]
	protected virtual int PBPIADAHKIL(Type FIJCKHKKDCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x1A038A0", Offset = "0x1A024A0", VA = "0x181A038A0")]
	public void FFPJNMKMBJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x1A03930", Offset = "0x1A02530", VA = "0x181A03930", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x81DFC0", Offset = "0x81CBC0", VA = "0x18081DFC0")]
		public LDKJPNACANF(ulong AABAOCJNFFN, COMLEFGIJKK JKJJBILHHIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6A8AB30", Offset = "0x6A89730", VA = "0x186A8AB30", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6A8A9E0", Offset = "0x6A895E0", VA = "0x186A8A9E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xAF7620", Offset = "0xAF6220", VA = "0x180AF7620")]
		[DebuggerHidden]
		public JNGJBINMJCM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6A8AA30", Offset = "0x6A89630", VA = "0x186A8AA30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6A8A680", Offset = "0x6A89280", VA = "0x186A8A680", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6A8A630", Offset = "0x6A89230", VA = "0x186A8A630")]
		private void EHFOANOMIIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6A8A9A0", Offset = "0x6A895A0", VA = "0x186A8A9A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6A8A8F0", Offset = "0x6A894F0", VA = "0x186A8A8F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<COMLEFGIJKK> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Attributes.NameHash>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6A8A8F0", Offset = "0x6A894F0", VA = "0x186A8A8F0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A8BD10", Offset = "0x6A8A910", VA = "0x186A8BD10")]
	public static ulong KJKFEHIMJMJ(int GJCJMGJCOPK)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6A8BC60", Offset = "0x6A8A860", VA = "0x186A8BC60")]
	public static int JFBOPNIILDN(ulong JKJJBILHHIM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6A8BF80", Offset = "0x6A8AB80", VA = "0x186A8BF80")]
	public static void PBAELFIBGFO(bool HCKNDFMIDDI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6A8B0E0", Offset = "0x6A89CE0", VA = "0x186A8B0E0")]
	private static void CFNJFEAOHGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6A8B1A0", Offset = "0x6A89DA0", VA = "0x186A8B1A0")]
	private static void CFNJFEAOHGP(IEnumerable<Type> LONDNADJAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6A8B000", Offset = "0x6A89C00", VA = "0x186A8B000")]
	private static void CAKDJHLFBLC(int FILOPMLNENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6A8B8F0", Offset = "0x6A8A4F0", VA = "0x186A8B8F0")]
	private static void HKPHNIPNJLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6A8BE00", Offset = "0x6A8AA00", VA = "0x186A8BE00")]
	private static (ulong, IEnumerable<COMLEFGIJKK>) KPGKEHHNHNH(Type FIJCKHKKDCC)
	{
		return default((ulong, IEnumerable<COMLEFGIJKK>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6A8BD70", Offset = "0x6A8A970", VA = "0x186A8BD70")]
	[IteratorStateMachine(typeof(JNGJBINMJCM))]
	private static IEnumerable<COMLEFGIJKK> KNOABKALDDB(Type FIJCKHKKDCC, ulong JKJJBILHHIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6A8B470", Offset = "0x6A8A070", VA = "0x186A8B470")]
	private static void FGFIDBBENNC(ulong JKJJBILHHIM, IEnumerable<COMLEFGIJKK> GMFFEAKKGAE, TypeManager.TypeInfo EEIDDEHCPMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6A8AF00", Offset = "0x6A89B00", VA = "0x186A8AF00")]
	private static void BDPIJDFBLMM(LDKJPNACANF EEIDDEHCPMB, int GJCJMGJCOPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6A8B770", Offset = "0x6A8A370", VA = "0x186A8B770")]
	private static void FHFIJEIOOPA(LDKJPNACANF EEIDDEHCPMB, int GJCJMGJCOPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6A8B860", Offset = "0x6A8A460", VA = "0x186A8B860")]
	private static LDKJPNACANF GMIPBBEHMHI(int GJCJMGJCOPK)
	{
		return default(LDKJPNACANF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6A8BC50", Offset = "0x6A8A850", VA = "0x186A8BC50")]
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
			[Cpp2IlInjected.Address(RVA = "0x28911E0", Offset = "0x288FDE0", VA = "0x1828911E0")]
			get
			{
				return default(DFGMPCKANBL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T LOFOOLDNEHF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x28911F0", Offset = "0x288FDF0", VA = "0x1828911F0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public (T, DFGMPCKANBL) NIBFGHDNPCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x2B43350", Offset = "0x2B41F50", VA = "0x182B43350")]
			get
			{
				return default((T, DFGMPCKANBL));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2B43830", Offset = "0x2B42430", VA = "0x182B43830")]
		public IOBDCDGKECN(NativeArray<T> EABDNHJFDCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2B43420", Offset = "0x2B42020", VA = "0x182B43420")]
		public IOBDCDGKECN<T> MEOEHOBEEMI()
		{
			return default(IOBDCDGKECN<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2B43460", Offset = "0x2B42060", VA = "0x182B43460")]
		public bool MIOEPBKKBNP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3098DF0", Offset = "0x30979F0", VA = "0x183098DF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x28911E0", Offset = "0x288FDE0", VA = "0x1828911E0")]
			get
			{
				return default(DFGMPCKANBL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public T LOFOOLDNEHF
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x28911F0", Offset = "0x288FDF0", VA = "0x1828911F0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public (T value, DFGMPCKANBL range) NIBFGHDNPCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x2891210", Offset = "0x288FE10", VA = "0x182891210")]
			get
			{
				return default((T, DFGMPCKANBL));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2891580", Offset = "0x2890180", VA = "0x182891580")]
		public NDHLPCENPNP(NativeArray<T>.ReadOnly EABDNHJFDCB, TComparer GCAEFOMJOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x28912E0", Offset = "0x288FEE0", VA = "0x1828912E0")]
		public NDHLPCENPNP<T, TComparer> MEOEHOBEEMI()
		{
			return default(NDHLPCENPNP<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2891320", Offset = "0x288FF20", VA = "0x182891320")]
		public bool MIOEPBKKBNP()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2B78030", Offset = "0x2B76C30", VA = "0x182B78030")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A8D090", Offset = "0x6A8BC90", VA = "0x186A8D090")]
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
	[Cpp2IlInjected.Address(RVA = "0x7F0020", Offset = "0x7EEC20", VA = "0x1807F0020")]
	protected IKNIOKDNHBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class MOEBPIEJEHJ
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2359AD0", Offset = "0x23586D0", VA = "0x182359AD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B44400", Offset = "0x2B43000", VA = "0x182B44400", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x27BB8E0", Offset = "0x27BA4E0", VA = "0x1827BB8E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IEnumerable<BaseClass> DBENEACIGAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x27BB560", Offset = "0x27BA160", VA = "0x1827BB560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x27BBAE0", Offset = "0x27BA6E0", VA = "0x1827BBAE0")]
	public BFJGLKGJIEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x27BB940", Offset = "0x27BA540", VA = "0x1827BB940")]
	public BFJGLKGJIEH(int CABFJBCMJEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x27BB790", Offset = "0x27BA390", VA = "0x1827BB790")]
	internal void CAILCKFFJIK(int GJCJMGJCOPK, BaseClass CPIEKHBBHCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2A904C0", Offset = "0x2A8F0C0", VA = "0x182A904C0")]
	public bool CJMEEDACJIA<T>(out BaseClass ECNGHFJBIJL) where T : IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x27BB810", Offset = "0x27BA410", VA = "0x1827BB810")]
	public bool CJMEEDACJIA(Type GDOKANFLACL, out BaseClass ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x27BB910", Offset = "0x27BA510", VA = "0x1827BB910")]
	public bool PMIPEJMDEHL(int GJCJMGJCOPK, out BaseClass ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2A91280", Offset = "0x2A8FE80", VA = "0x182A91280")]
	public T ELBMGAGFHLI<T>() where T : BaseClass
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x27BB8B0", Offset = "0x27BA4B0", VA = "0x1827BB8B0")]
	public BaseClass ELBMGAGFHLI(Type LLNJOBIDKCE)
	{
		return (BaseClass)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal class KILLGJJIMEA : global::IBHAHBMDJLH<OALALKKKNCP, MFCOBEFGBOI>
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6A8AAC0", Offset = "0x6A896C0", VA = "0x186A8AAC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A87EA0", Offset = "0x6A86AA0", VA = "0x186A87EA0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class OPKPAOPDKEI
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x21017F0", Offset = "0x21003F0", VA = "0x1821017F0")]
	public static NativeArray<T> KIJJPLBIKIL<T>(this NativeList<Entity> PAPBDDPJFAJ, EntityManager LMJGFJDJJLA, Allocator FKPADLBILGP = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2101580", Offset = "0x2100180", VA = "0x182101580")]
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
	[Cpp2IlInjected.Address(RVA = "0x358C860", Offset = "0x358B460", VA = "0x18358C860", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class LIPPMCDPHPN
{
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x32C1560", Offset = "0x32C0160", VA = "0x1832C1560")]
	[MustUseReturnValue]
	public static JobHandle NLLFDBKALMO<T>(this EntityCommandBufferSystem PPANIHNCFCJ, EntityCommandBuffer FIENHHJAMHI, EntityQuery DPBAMGMJJLC, T ECNGHFJBIJL) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x32C1480", Offset = "0x32C0080", VA = "0x1832C1480")]
	[MustUseReturnValue]
	public static JobHandle NLLFDBKALMO<T>(this EntityCommandBufferSystem PPANIHNCFCJ, NativeArrayAsync<Entity> FPMGLBFKKPO, NativeArrayAsync<T> ECNGHFJBIJL) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x32C1310", Offset = "0x32BFF10", VA = "0x1832C1310")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A873B0", Offset = "0x6A85FB0", VA = "0x186A873B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B37B10", Offset = "0x2B36710", VA = "0x182B37B10", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x28D34C0", Offset = "0x28D20C0", VA = "0x1828D34C0", Slot = "8")]
	protected virtual bool FKIEGFNPIMN(ReadOnlySpan<Data> CHCFPJJJGHE, MHCHCENMNNH LOCFGCDNKMP, out ReadOnlySpan<byte> KNJBCHEFCED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7F0460", Offset = "0x7EF060", VA = "0x1807F0460", Slot = "9")]
	protected virtual bool BAOFGNAPECJ(int FPBNFBFIPHI, Span<Data> CHCFPJJJGHE, in ReadOnlySpan<byte> KNJBCHEFCED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2B37990", Offset = "0x2B36590", VA = "0x182B37990", Slot = "5")]
	internal sealed override bool FKIEGFNPIMN(ref Unity.Entities.Chunk NLIPPJGPKOG, int BNNLAPKBIOF, MHCHCENMNNH LOCFGCDNKMP, out ReadOnlySpan<byte> KNJBCHEFCED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2B36D40", Offset = "0x2B35940", VA = "0x182B36D40", Slot = "6")]
	internal sealed override bool BAOFGNAPECJ(int FPBNFBFIPHI, ref Unity.Entities.Chunk NLIPPJGPKOG, int BNNLAPKBIOF, in ReadOnlySpan<byte> KNJBCHEFCED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3098D10", Offset = "0x3097910", VA = "0x183098D10")]
	protected global::HOEKDGLKAAO<Protobuf> IJOPLFJMPHO<Protobuf>(ReadOnlySpan<Data> CHCFPJJJGHE) where Protobuf : IMessage, new()
	{
		return default(global::HOEKDGLKAAO<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3098D60", Offset = "0x3097960", VA = "0x183098D60")]
	protected global::PGLAGHJANGJ<Protobuf> MHDMPPMKNEE<Protobuf>(ReadOnlySpan<byte> KNJBCHEFCED, ReadOnlySpan<Data> CHCFPJJJGHE, Action<Protobuf> GCGGKDKNPNA) where Protobuf : IMessage, new()
	{
		return default(global::PGLAGHJANGJ<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2B2B930", Offset = "0x2B2A530", VA = "0x182B2B930")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A8AC00", Offset = "0x6A89800", VA = "0x186A8AC00", Slot = "5")]
	internal virtual bool FKIEGFNPIMN(ref Unity.Entities.Chunk NLIPPJGPKOG, int BNNLAPKBIOF, MHCHCENMNNH LOCFGCDNKMP, out ReadOnlySpan<byte> KNJBCHEFCED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x7F0460", Offset = "0x7EF060", VA = "0x1807F0460", Slot = "6")]
	internal virtual bool BAOFGNAPECJ(int FPBNFBFIPHI, ref Unity.Entities.Chunk NLIPPJGPKOG, int BNNLAPKBIOF, in ReadOnlySpan<byte> KNJBCHEFCED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x358F050", Offset = "0x358DC50", VA = "0x18358F050", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x30DA2C0", Offset = "0x30D8EC0", VA = "0x1830DA2C0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2155450", Offset = "0x2154050", VA = "0x182155450")]
	public static NativeListAsync<Entity> OELIENMIMKN<T, TPredicate>(this NativeArrayAsync<T> PAPBDDPJFAJ, NativeArrayAsync<Entity> NEDOPJDBOOK, Allocator FKPADLBILGP = Allocator.TempJob) where T : struct where TPredicate : struct, global::GICACEPGEBH<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x21552A0", Offset = "0x2153EA0", VA = "0x1821552A0")]
	private static NativeListAsync<Entity> BFBPCEJHGKJ<T, TPredicate>(NativeArrayAsync<T> FDMFIPGIBNB, NativeArrayAsync<Entity> NEDOPJDBOOK, int HLPFAIAMMGH, Allocator FKPADLBILGP) where T : struct where TPredicate : struct, global::GICACEPGEBH<T>
	{
		return default(NativeListAsync<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class ACLLJCCMGPG
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x1956630", Offset = "0x1955230", VA = "0x181956630")]
	[MustUseReturnValue]
	public static JobHandle PBDOFOAPMMF<T>(this EntityCommandBufferSystem PPANIHNCFCJ, NativeArray<Entity> FPMGLBFKKPO, T ECNGHFJBIJL, [Optional] JobHandle NPBMDGDOAPE) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x1956560", Offset = "0x1955160", VA = "0x181956560")]
	[MustUseReturnValue]
	public static JobHandle PBDOFOAPMMF<T>(this EntityCommandBufferSystem PPANIHNCFCJ, EntityCommandBuffer FIENHHJAMHI, NativeArray<Entity> FPMGLBFKKPO, T ECNGHFJBIJL, [Optional] JobHandle NPBMDGDOAPE) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x19564A0", Offset = "0x19550A0", VA = "0x1819564A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2E9CE80", Offset = "0x2E9BA80", VA = "0x182E9CE80")]
	public static NativeList<T> EAGPENIJKGE<T>(this NativeList<T> PAPBDDPJFAJ, Allocator FKPADLBILGP = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2E9CCB0", Offset = "0x2E9B8B0", VA = "0x182E9CCB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A86680", Offset = "0x6A85280", VA = "0x186A86680", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A86900", Offset = "0x6A85500", VA = "0x186A86900", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6A868A0", Offset = "0x6A854A0", VA = "0x186A868A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x837A60", Offset = "0x836660", VA = "0x180837A60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x857190", Offset = "0x855D90", VA = "0x180857190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0xBA8FB0", Offset = "0xBA7BB0", VA = "0x180BA8FB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A86240", Offset = "0x6A84E40", VA = "0x186A86240")]
	public static int ILHBPGJKDMF(int GJCJMGJCOPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6A86560", Offset = "0x6A85160", VA = "0x186A86560")]
	public static void PBAELFIBGFO(bool HCKNDFMIDDI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6A862E0", Offset = "0x6A84EE0", VA = "0x186A862E0")]
	private static void JLDGCFEPJEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6A86170", Offset = "0x6A84D70", VA = "0x186A86170")]
	private static int CPCDBPJFPGH(Type FIJCKHKKDCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6A861C0", Offset = "0x6A84DC0", VA = "0x186A861C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BD65E0", Offset = "0x2BD51E0", VA = "0x182BD65E0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3521CA0", Offset = "0x35208A0", VA = "0x183521CA0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class AMMGLDMAJIP
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6A85EC0", Offset = "0x6A84AC0", VA = "0x186A85EC0")]
	public static ulong GEOLMDPOAFC(Type FIJCKHKKDCC)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6A85F50", Offset = "0x6A84B50", VA = "0x186A85F50")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A84C40", Offset = "0x6A83840", VA = "0x186A84C40")]
	public static void PBAELFIBGFO(bool HCKNDFMIDDI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6A84A10", Offset = "0x6A83610", VA = "0x186A84A10")]
	private static void MJFCMCFOCND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6A846A0", Offset = "0x6A832A0", VA = "0x186A846A0")]
	private static void EPDPHHMMABF(Type ELNKCIBOCOL, Type CBHLPGJGAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6A84620", Offset = "0x6A83220", VA = "0x186A84620")]
	private static void ELJLHOEKJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6A84880", Offset = "0x6A83480", VA = "0x186A84880")]
	public static int HMKNNJIMIKG(Type ELNKCIBOCOL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6A84970", Offset = "0x6A83570", VA = "0x186A84970")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A88200", Offset = "0x6A86E00", VA = "0x186A88200")]
	public static ComponentSystemGroup[] HDEMIFJCDLH(World GPEEKLGBDDJ, PACEBIKNHGA MDFPINHICMD = PACEBIKNHGA.Default, bool IBDLFJOOKBO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6A88390", Offset = "0x6A86F90", VA = "0x186A88390")]
	private static Type[] LLOCABGJLFO(PACEBIKNHGA MDFPINHICMD, bool IBDLFJOOKBO, ComponentSystemGroup[] CJGHDKIGFAL, ComponentSystemGroup DLIBOCPFIME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6A886F0", Offset = "0x6A872F0", VA = "0x186A886F0")]
	private static ComponentSystemGroup[] MEGKBKPHLAH(World GPEEKLGBDDJ, out ComponentSystemGroup DLIBOCPFIME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6A87F70", Offset = "0x6A86B70", VA = "0x186A87F70")]
	internal static bool EMCIOKLDPDI(LNGKPFAGLPC BJCAHHPNCBK, out HJLOAJDGIBN BHPNIOIEDBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6A88A00", Offset = "0x6A87600", VA = "0x186A88A00")]
	private static ComponentSystemGroup NMFCFFMKFDI(Type FIJCKHKKDCC, World GPEEKLGBDDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6A88AE0", Offset = "0x6A876E0", VA = "0x186A88AE0")]
	private static ComponentSystemGroup[] PCJODGPLPMD(Type[] LONDNADJAMP, World GPEEKLGBDDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6A88C10", Offset = "0x6A87810", VA = "0x186A88C10")]
	internal static void PLKFLIELLCG(World GPEEKLGBDDJ, Type[] CDCNPKINHEM, ComponentSystemGroup[] CJGHDKIGFAL, ComponentSystemGroup DLIBOCPFIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6A88330", Offset = "0x6A86F30", VA = "0x186A88330")]
	internal static bool LIICPDIGDMI(ComponentSystemBase HHDENPAFOIF, ComponentSystemGroup[] CJGHDKIGFAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6A882D0", Offset = "0x6A86ED0", VA = "0x186A882D0")]
	private static void IADJNGKOOOD(ComponentSystemGroup[] CJGHDKIGFAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class OALALKKKNCP : NIHPIFKMGGM
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0xBA8FB0", Offset = "0xBA7BB0", VA = "0x180BA8FB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A8A5A0", Offset = "0x6A891A0", VA = "0x186A8A5A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public abstract class BBKLLGEPFAJ : SystemBase, KHPBHBLDCGG
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6A86020", Offset = "0x6A84C20", VA = "0x186A86020")]
	public ComponentDataFromEntity CCEKPMJGJAH(int GJCJMGJCOPK, bool INCMGOFNCLP = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6A86140", Offset = "0x6A84D40", VA = "0x186A86140")]
	public EntityExistenceLookupByEntity IMKJLPPMDLA()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6A860F0", Offset = "0x6A84CF0", VA = "0x186A860F0")]
	public EntityQuery EGGCMBMNPIC(in EntityQueryDescBuilder EALACKPBAJJ)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6A86160", Offset = "0x6A84D60", VA = "0x186A86160", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x8B8290", Offset = "0x8B6E90", VA = "0x1808B8290")]
	protected BBKLLGEPFAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public abstract class IKBGPBBHAOK : BBKLLGEPFAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6A891C0", Offset = "0x6A87DC0", VA = "0x186A891C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x8B8290", Offset = "0x8B6E90", VA = "0x1808B8290")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A868A0", Offset = "0x6A854A0", VA = "0x186A868A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x477CD70", Offset = "0x477B970", VA = "0x18477CD70", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public override int KKDFANILMMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x477C9B0", Offset = "0x477B5B0", VA = "0x18477C9B0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x477C940", Offset = "0x477B540", VA = "0x18477C940")]
	public Data FPNKHFHGOMJ(Entity CMBJDMJHALL)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract View FGCMFKBIFEL(Entity CMBJDMJHALL);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3F407D0", Offset = "0x3F3F3D0", VA = "0x183F407D0", Slot = "14")]
	protected internal override T FGCMFKBIFEL<T>(Entity CMBJDMJHALL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2B2B930", Offset = "0x2B2A530", VA = "0x182B2B930")]
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
		[Cpp2IlInjected.Address(RVA = "0x837A60", Offset = "0x836660", VA = "0x180837A60", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE9F0", Offset = "0xAAD5F0", VA = "0x180AAE9F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xDD2D10", Offset = "0xDD1910", VA = "0x180DD2D10", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private int HGLMODJIGNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6A86DD0", Offset = "0x6A859D0", VA = "0x186A86DD0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private DAEIOAAPCOE[] HHKLFBHKGFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8E2910", Offset = "0x8E1510", VA = "0x1808E2910", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	protected internal virtual DAEIOAAPCOE[] IMGJKIMNGJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6A86D10", Offset = "0x6A85910", VA = "0x186A86D10", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6A86E40", Offset = "0x6A85A40", VA = "0x186A86E40")]
	public void PBAELFIBGFO(EntityManager LMJGFJDJJLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x8D5ED0", Offset = "0x8D4AD0", VA = "0x1808D5ED0")]
	protected PHIGEONMPOB DCELMIPGPEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "14")]
	protected internal abstract T FGCMFKBIFEL<T>(Entity CMBJDMJHALL) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6A86BC0", Offset = "0x6A857C0", VA = "0x186A86BC0", Slot = "8")]
	public (uint, uint) ILHBPGJKDMF(Entity CMBJDMJHALL)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6A86C80", Offset = "0x6A85880", VA = "0x186A86C80", Slot = "9")]
	public bool MFIELPFAIPE(Entity CMBJDMJHALL, (uint order, uint change) FPBNFBFIPHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
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
	[Cpp2IlInjected.Address(RVA = "0xAF3280", Offset = "0xAF1E80", VA = "0x180AF3280")]
	private EHCAPCHEGDN(List<Type> LONDNADJAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6A86FE0", Offset = "0x6A85BE0", VA = "0x186A86FE0")]
	public static void FFPJNMKMBJA(List<Type> LONDNADJAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6A87070", Offset = "0x6A85C70", VA = "0x186A87070")]
	private void KEIFOEFMOLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6A86F60", Offset = "0x6A85B60", VA = "0x186A86F60")]
	private bool BIIFBHKMNEE(Type FIJCKHKKDCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6A872B0", Offset = "0x6A85EB0", VA = "0x186A872B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F0000", Offset = "0x7EEC00", VA = "0x1807F0000")]
		[CompilerGenerated]
		get
		{
			return default(LNGKPFAGLPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x13AA8D0", Offset = "0x13A94D0", VA = "0x1813AA8D0")]
	public MJMELKOJNAD(LNGKPFAGLPC BJCAHHPNCBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public class GLODNPPMBII : LBCLEEENKKC
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x8B8290", Offset = "0x8B6E90", VA = "0x1808B8290")]
	public GLODNPPMBII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public abstract class AKKNCOHCIBK
{
	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x818CD0", Offset = "0x8178D0", VA = "0x180818CD0")]
		public FIMFLEFLLCH(NativeArray<TSrc> EABDNHJFDCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xF944D0", Offset = "0xF930D0", VA = "0x180F944D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x818CD0", Offset = "0x8178D0", VA = "0x180818CD0")]
		public NPDLCJCGNFL(NativeArray<TSrc> EABDNHJFDCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xF944D0", Offset = "0xF930D0", VA = "0x180F944D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x818CD0", Offset = "0x8178D0", VA = "0x180818CD0")]
		public IBOHGPFOMFK(NativeArray<TSrc> EABDNHJFDCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x1A04FF0", Offset = "0x1A03BF0", VA = "0x181A04FF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B46470", Offset = "0x2B45070", VA = "0x182B46470")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int OJOINFOLDPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x7F0220", Offset = "0x7EEE20", VA = "0x1807F0220")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int PJKEDAIIMDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x2B46500", Offset = "0x2B45100", VA = "0x182B46500")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x2B46640", Offset = "0x2B45240", VA = "0x182B46640")]
		public IPHNGCIIHPC(NativeArray<TSrc> EABDNHJFDCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2B464E0", Offset = "0x2B450E0", VA = "0x182B464E0")]
		public bool MIOEPBKKBNP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2B46510", Offset = "0x2B45110", VA = "0x182B46510")]
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
			[Cpp2IlInjected.Address(RVA = "0x3419BD0", Offset = "0x34187D0", VA = "0x183419BD0")]
			get
			{
				return default(DFGMPCKANBL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public TValue LOFOOLDNEHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x837B50", Offset = "0x836750", VA = "0x180837B50")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public (TValue value, DFGMPCKANBL range) NIBFGHDNPCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x3419C10", Offset = "0x3418810", VA = "0x183419C10")]
			get
			{
				return default((TValue, DFGMPCKANBL));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3419E20", Offset = "0x3418A20", VA = "0x183419E20")]
		public DGOOBOAJBKI(NativeArray<TSrc> EABDNHJFDCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2681D30", Offset = "0x2680930", VA = "0x182681D30")]
		public DGOOBOAJBKI<TSrc, TValue, TSelector> MEOEHOBEEMI()
		{
			return default(DGOOBOAJBKI<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3419CF0", Offset = "0x34188F0", VA = "0x183419CF0")]
		public bool MIOEPBKKBNP()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x1954AF0", Offset = "0x19536F0", VA = "0x181954AF0")]
	public static FIMFLEFLLCH<T> DBGHCCIPLMI<T>(this NativeList<T> IFADMANLNLG) where T : struct
	{
		return default(FIMFLEFLLCH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0xF944D0", Offset = "0xF930D0", VA = "0x180F944D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A8ABD0", Offset = "0x6A897D0", VA = "0x186A8ABD0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class LEKBKADGMNN
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x32BEC60", Offset = "0x32BD860", VA = "0x1832BEC60")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F2D00", Offset = "0x7F1900", VA = "0x1807F2D00", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6A85FC0", Offset = "0x6A84BC0", VA = "0x186A85FC0")]
	protected MPCIDEABOID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[DisableAutoCreation]
public sealed class KBHIFALNLKD : MPCIDEABOID
{
	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6A85FC0", Offset = "0x6A84BC0", VA = "0x186A85FC0")]
	public KBHIFALNLKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[DisableAutoCreation]
public sealed class DOAKBPMALDE : MPCIDEABOID
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6A85FC0", Offset = "0x6A84BC0", VA = "0x186A85FC0")]
	public DOAKBPMALDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[DisableAutoCreation]
public sealed class EFNEFEPPFKH : MPCIDEABOID
{
	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6A85FC0", Offset = "0x6A84BC0", VA = "0x186A85FC0")]
	public EFNEFEPPFKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[DisableAutoCreation]
public sealed class MABMHEFJONF : MPCIDEABOID
{
	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6A85FC0", Offset = "0x6A84BC0", VA = "0x186A85FC0")]
	public MABMHEFJONF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[DisableAutoCreation]
public sealed class LMHIAGOLJOP : MPCIDEABOID
{
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6A85FC0", Offset = "0x6A84BC0", VA = "0x186A85FC0")]
	public LMHIAGOLJOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[DisableAutoCreation]
public sealed class BMHHAHJPDDI : MPCIDEABOID
{
	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6A85FC0", Offset = "0x6A84BC0", VA = "0x186A85FC0")]
	public BMHHAHJPDDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[DisableAutoCreation]
public sealed class OPOBJELNJJN : MPCIDEABOID
{
	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6A85FC0", Offset = "0x6A84BC0", VA = "0x186A85FC0")]
	public OPOBJELNJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[DisableAutoCreation]
public sealed class NJEAGGCKFJJ : MPCIDEABOID
{
	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x6A85FC0", Offset = "0x6A84BC0", VA = "0x186A85FC0")]
	public NJEAGGCKFJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[DisableAutoCreation]
public sealed class JCEBHADMNOP : MPCIDEABOID
{
	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6A85FC0", Offset = "0x6A84BC0", VA = "0x186A85FC0")]
	public JCEBHADMNOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public sealed class LDKGCNKMDOL : DBNDPGDFGFK
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6A85FC0", Offset = "0x6A84BC0", VA = "0x186A85FC0")]
	public LDKGCNKMDOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public sealed class LNPPLPJIOLK : DBNDPGDFGFK
{
	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6A85FC0", Offset = "0x6A84BC0", VA = "0x186A85FC0")]
	public LNPPLPJIOLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public sealed class BBDONECNJLI : DBNDPGDFGFK
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6A85FC0", Offset = "0x6A84BC0", VA = "0x186A85FC0")]
	public BBDONECNJLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public sealed class PFOGDLOOEFI : DBNDPGDFGFK
{
	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6A85FC0", Offset = "0x6A84BC0", VA = "0x186A85FC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6A85FC0", Offset = "0x6A84BC0", VA = "0x186A85FC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A87440", Offset = "0x6A86040", VA = "0x186A87440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	internal static global::NBMCIPHNCFJ<MFCOBEFGBOI> GMLDEHHIHCF
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6A87580", Offset = "0x6A86180", VA = "0x186A87580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal static global::NBMCIPHNCFJ<AKKNCOHCIBK> IHDJMOOJEKC
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x6A87520", Offset = "0x6A86120", VA = "0x186A87520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6A875E0", Offset = "0x6A861E0", VA = "0x186A875E0")]
	public static void PBAELFIBGFO(bool HCKNDFMIDDI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6A874A0", Offset = "0x6A860A0", VA = "0x186A874A0")]
	public static Type[] HJHOGOLLNFB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class PCLEFMFPEJG
{
	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x2106D50", Offset = "0x2105950", VA = "0x182106D50")]
	[MustUseReturnValue]
	public static JobHandle EAEOFDKANDO<T>(this EntityCommandBufferSystem PPANIHNCFCJ, NativeArrayAsync<Entity> FPMGLBFKKPO, NativeArrayAsync<T> PHBHEFAPHDL, [Optional] JobHandle NPBMDGDOAPE) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x2107260", Offset = "0x2105E60", VA = "0x182107260")]
	[MustUseReturnValue]
	public static JobHandle EAEOFDKANDO<T>(this EntityCommandBufferSystem PPANIHNCFCJ, NativeArrayAsync<Entity> FPMGLBFKKPO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x2106C30", Offset = "0x2105830", VA = "0x182106C30")]
	[MustUseReturnValue]
	public static JobHandle EAEOFDKANDO<T>(this EntityCommandBufferSystem PPANIHNCFCJ, NativeArray<Entity> FPMGLBFKKPO, [Optional] JobHandle NPBMDGDOAPE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x2107140", Offset = "0x2105D40", VA = "0x182107140")]
	[MustUseReturnValue]
	public static JobHandle EAEOFDKANDO<T>(this EntityCommandBufferSystem PPANIHNCFCJ, EntityCommandBuffer FIENHHJAMHI, NativeArray<Entity> FPMGLBFKKPO, [Optional] JobHandle NPBMDGDOAPE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6A8D110", Offset = "0x6A8BD10", VA = "0x186A8D110")]
	[MustUseReturnValue]
	public static JobHandle EAEOFDKANDO(this EntityCommandBufferSystem PPANIHNCFCJ, NativeArray<Entity> FPMGLBFKKPO, ComponentTypes FOAMMHNABBN, [Optional] JobHandle NPBMDGDOAPE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6A8D270", Offset = "0x6A8BE70", VA = "0x186A8D270")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A8AE30", Offset = "0x6A89A30", VA = "0x186A8AE30")]
	private unsafe static Span<byte> PEAFCOBLFHI(Unity.Entities.Chunk* NLIPPJGPKOG, int BNNLAPKBIOF)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x2354790", Offset = "0x2353390", VA = "0x182354790")]
	public unsafe static Span<T> ELPMFKPEGBM<T>(Unity.Entities.Chunk* NLIPPJGPKOG, int BNNLAPKBIOF)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x2354750", Offset = "0x2353350", VA = "0x182354750")]
	public static Span<T> ELPMFKPEGBM<T>(this ref Unity.Entities.Chunk NLIPPJGPKOG, int BNNLAPKBIOF)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6A8ADC0", Offset = "0x6A899C0", VA = "0x186A8ADC0")]
	public unsafe static Span<Entity> LALLBDCAKCG(Unity.Entities.Chunk* NLIPPJGPKOG)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6A8AC30", Offset = "0x6A89830", VA = "0x186A8AC30")]
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
	[Cpp2IlInjected.Address(RVA = "0x81B870", Offset = "0x81A470", VA = "0x18081B870")]
	public MHCHCENMNNH(NativeArray<EntityRemapUtility.EntityRemapInfo> KIOMBJEIJNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6A8AC20", Offset = "0x6A89820", VA = "0x186A8AC20")]
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
	[Cpp2IlInjected.Address(RVA = "0x8B8290", Offset = "0x8B6E90", VA = "0x1808B8290")]
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
		[Cpp2IlInjected.Address(RVA = "0x14BBF20", Offset = "0x14BAB20", VA = "0x1814BBF20")]
		public FDMHKJOLODG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6A869F0", Offset = "0x6A855F0", VA = "0x186A869F0")]
	static DFJLHCDMPLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x2D80370", Offset = "0x2D7EF70", VA = "0x182D80370")]
	public static void HFEOPFFCKDC<T>(COKJNICGJFN<T, T> DPHLLPLPIPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x2D80130", Offset = "0x2D7ED30", VA = "0x182D80130")]
	public static void HFEOPFFCKDC<From, To>(COKJNICGJFN<From, To> DPHLLPLPIPO, COKJNICGJFN<To, From> AEKDEAOHPIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x2D800E0", Offset = "0x2D7ECE0", VA = "0x182D800E0")]
	public static void HFEOPFFCKDC<From, To>(COKJNICGJFN<From, To> JNHBOJOGBIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x2D864E0", Offset = "0x2D850E0", VA = "0x182D864E0")]
	public static COKJNICGJFN<From, To> MJKAMACBPFN<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x2D7EC70", Offset = "0x2D7D870", VA = "0x182D7EC70")]
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
			[Cpp2IlInjected.Address(RVA = "0x1A0C630", Offset = "0x1A0B230", VA = "0x181A0C630")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x358E3F0", Offset = "0x358CFF0", VA = "0x18358E3F0")]
		public bool BHPOOGEBGBI(out TValue ECNGHFJBIJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x358E4B0", Offset = "0x358D0B0", VA = "0x18358E4B0")]
		public void CAILCKFFJIK(object FLDJLPKNKKO, TValue ECNGHFJBIJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x358E560", Offset = "0x358D160", VA = "0x18358E560")]
		public bool CPPHPNNFPKL(object FLDJLPKNKKO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x358E5E0", Offset = "0x358D1E0", VA = "0x18358E5E0")]
		public int HNIOFAKCMJD(object FLDJLPKNKKO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x358E690", Offset = "0x358D290", VA = "0x18358E690")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BEE6F0", Offset = "0x2BED2F0", VA = "0x182BEE6F0")]
	public FHFLBOGHGEP(EntityManager LMJGFJDJJLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x2BEE350", Offset = "0x2BECF50", VA = "0x182BEE350", Slot = "4")]
	public void KNDGHBJCIPF(Entity CMBJDMJHALL, object FLDJLPKNKKO, TValue ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x2BEE560", Offset = "0x2BED160", VA = "0x182BEE560", Slot = "5")]
	public bool PAALMADNNKG(Entity CMBJDMJHALL, object FLDJLPKNKKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x2BEE030", Offset = "0x2BECC30", VA = "0x182BEE030", Slot = "6")]
	public bool BHPOOGEBGBI(Entity CMBJDMJHALL, out TValue ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x2BEE100", Offset = "0x2BECD00", VA = "0x182BEE100", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x2BEE4E0", Offset = "0x2BED0E0", VA = "0x182BEE4E0")]
	private void MNHCHBKDDDE(EIHNAINMAEH LMFCFNPNFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x2BEE1B0", Offset = "0x2BECDB0", VA = "0x182BEE1B0")]
	private bool FCFJFPIFDIM(Entity CMBJDMJHALL, out GHBLMLDHKJD AAFHCAILJEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x2BEE120", Offset = "0x2BECD20", VA = "0x182BEE120")]
	private void EDFGBFBDCCH(Entity CMBJDMJHALL, GHBLMLDHKJD AAFHCAILJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x2BEE010", Offset = "0x2BECC10", VA = "0x182BEE010")]
	private bool AEKGODAMIKA(GHBLMLDHKJD AAFHCAILJEB, out EIHNAINMAEH LMFCFNPNFHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x2BEE280", Offset = "0x2BECE80", VA = "0x182BEE280")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E49B0", Offset = "0x8E35B0", VA = "0x1808E49B0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x96CBB0", Offset = "0x96B7B0", VA = "0x18096CBB0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE5B60", Offset = "0xAE4760", VA = "0x180AE5B60", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x139CA40", Offset = "0x139B640", VA = "0x18139CA40", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x6A87B60", Offset = "0x6A86760", VA = "0x186A87B60", Slot = "8")]
	public bool Equals(GHBLMLDHKJD MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x6A87BB0", Offset = "0x6A867B0", VA = "0x186A87BB0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x27B4F20", Offset = "0x27B3B20", VA = "0x1827B4F20")]
	public BEMINCHFLDP(EntityManager LMJGFJDJJLA, EntityCommandBufferSystem PPANIHNCFCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x27B3980", Offset = "0x27B2580", VA = "0x1827B3980", Slot = "4")]
	public bool KNDGHBJCIPF(Entity CMBJDMJHALL, object FLDJLPKNKKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x27B47F0", Offset = "0x27B33F0", VA = "0x1827B47F0", Slot = "5")]
	public bool PAALMADNNKG(Entity CMBJDMJHALL, object FLDJLPKNKKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x27B1C00", Offset = "0x27B0800", VA = "0x1827B1C00", Slot = "6")]
	public bool BABEIMNAAGJ(Entity CMBJDMJHALL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x27B1D20", Offset = "0x27B0920", VA = "0x1827B1D20", Slot = "10")]
	public bool BABEIMNAAGJ(GHBLMLDHKJD AAFHCAILJEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x27B41B0", Offset = "0x27B2DB0", VA = "0x1827B41B0", Slot = "7")]
	public IEnumerable<object> OKAKGJPNIKC(Entity CMBJDMJHALL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x27B3E70", Offset = "0x27B2A70", VA = "0x1827B3E70", Slot = "11")]
	public IEnumerable<object> OKAKGJPNIKC(GHBLMLDHKJD AAFHCAILJEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x27B2D90", Offset = "0x27B1990", VA = "0x1827B2D90", Slot = "8")]
	public bool GIOFBNMLLED(Entity CMBJDMJHALL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x27B22F0", Offset = "0x27B0EF0", VA = "0x1827B22F0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x27B3E00", Offset = "0x27B2A00", VA = "0x1827B3E00")]
	private void MNHCHBKDDDE(HashSet<object> LMFCFNPNFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x27B2C20", Offset = "0x27B1820", VA = "0x1827B2C20")]
	private bool FCFJFPIFDIM(Entity CMBJDMJHALL, out GHBLMLDHKJD AAFHCAILJEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x27B2010", Offset = "0x27B0C10", VA = "0x1827B2010")]
	private bool CBHPCKALGDL(Entity CMBJDMJHALL, out GHBLMLDHKJD AAFHCAILJEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x27B1DC0", Offset = "0x27B09C0", VA = "0x1827B1DC0")]
	private void BHODPDIAEHL(Entity CMBJDMJHALL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x27B2D00", Offset = "0x27B1900", VA = "0x1827B2D00")]
	private void GGMNININJIL(Entity CMBJDMJHALL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x27B2820", Offset = "0x27B1420", VA = "0x1827B2820")]
	private void EGALBADHMDN(Entity CMBJDMJHALL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x27B23F0", Offset = "0x27B0FF0", VA = "0x1827B23F0")]
	private void EDFGBFBDCCH(Entity CMBJDMJHALL, GHBLMLDHKJD AAFHCAILJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x27B4C40", Offset = "0x27B3840", VA = "0x1827B4C40")]
	private bool PECCHAKOOEA(GHBLMLDHKJD AAFHCAILJEB, out HashSet<object> LMFCFNPNFHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x27B32E0", Offset = "0x27B1EE0", VA = "0x1827B32E0")]
	private HashSet<object> HPOCDGDDLDI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public static class PHGJCBGFBPF
{
	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010")]
	public static void ILDGJLPOJDH(this MFFHLJHLBIG HGFFDKCANPF, NativeArray<Entity> FPMGLBFKKPO, [Optional][CallerFilePath] string FJCMLALIJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010")]
	public static void ILDGJLPOJDH(this MFFHLJHLBIG HGFFDKCANPF, string BPOKAAOBIOI, NativeArray<Entity> FPMGLBFKKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010")]
	public static void ILDGJLPOJDH(this MFFHLJHLBIG HGFFDKCANPF, string FJCMLALIJKN, NativeArray<Entity> FPMGLBFKKPO, bool GPMFMCCDAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010")]
	public static void KMEDBMIIJKB(this MFFHLJHLBIG HGFFDKCANPF, NativeArray<Entity> FPMGLBFKKPO, EntityManager LMJGFJDJJLA, [Optional][CallerFilePath] string FJCMLALIJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010")]
	public static void KMEDBMIIJKB(this MFFHLJHLBIG HGFFDKCANPF, string FJCMLALIJKN, NativeArray<Entity> FPMGLBFKKPO, EntityManager LMJGFJDJJLA, bool GPMFMCCDAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010")]
	public static void EDLBCPBGPME(this MFFHLJHLBIG HGFFDKCANPF, NativeArray<Entity> FPMGLBFKKPO, NativeArray<Entity> MHKKJIBKAII, [Optional][CallerFilePath] string FJCMLALIJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010")]
	public static void EDLBCPBGPME(this MFFHLJHLBIG HGFFDKCANPF, string FJCMLALIJKN, NativeArray<Entity> FPMGLBFKKPO, NativeArray<Entity> MHKKJIBKAII, bool GPMFMCCDAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x210AAA0", Offset = "0x21096A0", VA = "0x18210AAA0")]
	public static void JDMCCAKBGDF<T>(this MFFHLJHLBIG HGFFDKCANPF, string BPOKAAOBIOI, NativeArray<Entity> FPMGLBFKKPO, NativeList<T> PHBHEFAPHDL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x210AA50", Offset = "0x2109650", VA = "0x18210AA50")]
	public static void JDMCCAKBGDF<T>(this MFFHLJHLBIG HGFFDKCANPF, NativeArray<Entity> FPMGLBFKKPO, NativeArray<T> PHBHEFAPHDL, [Optional][CallerFilePath] string FJCMLALIJKN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x210AA10", Offset = "0x2109610", VA = "0x18210AA10")]
	public static void JDMCCAKBGDF<T>(this MFFHLJHLBIG HGFFDKCANPF, string BPOKAAOBIOI, NativeArray<Entity> FPMGLBFKKPO, NativeArray<T> PHBHEFAPHDL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010")]
	public static void JDMCCAKBGDF<T>(this MFFHLJHLBIG HGFFDKCANPF, string FJCMLALIJKN, NativeArray<Entity> FPMGLBFKKPO, NativeArray<T> PHBHEFAPHDL, bool GPMFMCCDAKI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x210A9B0", Offset = "0x21095B0", VA = "0x18210A9B0")]
	public static void HCJINHBILHH<T>(this MFFHLJHLBIG HGFFDKCANPF, NativeList<T> PHBHEFAPHDL, [Optional][CallerFilePath] string FJCMLALIJKN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x210A980", Offset = "0x2109580", VA = "0x18210A980")]
	public static void HCJINHBILHH<T>(this MFFHLJHLBIG HGFFDKCANPF, NativeArray<T> PHBHEFAPHDL, [Optional][CallerFilePath] string FJCMLALIJKN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010")]
	public static void HCJINHBILHH<T>(this MFFHLJHLBIG HGFFDKCANPF, string FJCMLALIJKN, NativeArray<T> PHBHEFAPHDL, bool GPMFMCCDAKI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010")]
	public static void AJKDGOHMJHC(this MFFHLJHLBIG HGFFDKCANPF, EntityQuery DPBAMGMJJLC, [Optional][CallerFilePath] string FJCMLALIJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010")]
	public static void AJKDGOHMJHC(this MFFHLJHLBIG HGFFDKCANPF, string BPOKAAOBIOI, EntityQuery DPBAMGMJJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010")]
	public static void AJKDGOHMJHC(this MFFHLJHLBIG HGFFDKCANPF, string FJCMLALIJKN, EntityQuery DPBAMGMJJLC, bool GPMFMCCDAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x210A950", Offset = "0x2109550", VA = "0x18210A950")]
	public static void FNDFMMEAAEN<T, T2>(this MFFHLJHLBIG HGFFDKCANPF, string BPOKAAOBIOI, EntityQuery DPBAMGMJJLC) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010")]
	private static void FNDFMMEAAEN<T, T2>(this MFFHLJHLBIG HGFFDKCANPF, string FJCMLALIJKN, EntityQuery DPBAMGMJJLC, bool GPMFMCCDAKI) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x210A950", Offset = "0x2109550", VA = "0x18210A950")]
	public static void EGHOIJKPJMO<T>(this MFFHLJHLBIG HGFFDKCANPF, string BPOKAAOBIOI, NativeList<T> EABDNHJFDCB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010")]
	public static void EGHOIJKPJMO<T>(this MFFHLJHLBIG HGFFDKCANPF, string FJCMLALIJKN, NativeList<T> EABDNHJFDCB, bool GPMFMCCDAKI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x210A950", Offset = "0x2109550", VA = "0x18210A950")]
	public static void KKECINMOKAL<T>(this MFFHLJHLBIG HGFFDKCANPF, string BPOKAAOBIOI, NativeArray<T> EABDNHJFDCB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010")]
	public static void KKECINMOKAL<T>(this MFFHLJHLBIG HGFFDKCANPF, string FJCMLALIJKN, NativeArray<T> EABDNHJFDCB, bool GPMFMCCDAKI) where T : struct
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public class PFBBJKPLBFC
{
	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
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
