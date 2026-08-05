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
		[Cpp2IlInjected.Address(RVA = "0x7F3020", Offset = "0x7F1C20", VA = "0x1807F3020")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F3020", Offset = "0x7F1C20", VA = "0x1807F3020")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A3BD70", Offset = "0x6A3A970", VA = "0x186A3BD70")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A3B0C0", Offset = "0x6A39CC0", VA = "0x186A3B0C0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A3C590", Offset = "0x6A3B190", VA = "0x186A3C590", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct PGLAGHJANGJ<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class PEABPEKPNFI : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public PGLAGHJANGJ<Protobuf> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x843900", Offset = "0x842500", VA = "0x180843900", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A70E20", Offset = "0x3A6FA20", VA = "0x183A70E20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1FB45A0", Offset = "0x1FB31A0", VA = "0x181FB45A0")]
		[DebuggerHidden]
		public PEABPEKPNFI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3A70C30", Offset = "0x3A6F830", VA = "0x183A70C30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3A70DE0", Offset = "0x3A6F9E0", VA = "0x183A70DE0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F3230", Offset = "0x7F1E30", VA = "0x1807F3230")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3A7B720", Offset = "0x3A7A320", VA = "0x183A7B720")]
	private PGLAGHJANGJ(byte[] NLANKBLAOCO, Action<Protobuf> GCGGKDKNPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x334A810", Offset = "0x3349410", VA = "0x18334A810")]
	public static PGLAGHJANGJ<Protobuf> JLAKJAPJOGA<Data>(ReadOnlySpan<byte> KNJBCHEFCED, ReadOnlySpan<Data> CHCFPJJJGHE, Action<Protobuf> GCGGKDKNPNA)
	{
		return default(PGLAGHJANGJ<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3A7B590", Offset = "0x3A7A190", VA = "0x183A7B590", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3A7B5D0", Offset = "0x3A7A1D0", VA = "0x183A7B5D0", Slot = "4")]
	[IteratorStateMachine(typeof(PGLAGHJANGJ<>.PEABPEKPNFI))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3A7B6D0", Offset = "0x3A7A2D0", VA = "0x183A7B6D0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x2E7C0F0", Offset = "0x2E7ACF0", VA = "0x182E7C0F0")]
	private HOEKDGLKAAO(byte[] NLANKBLAOCO, in Protobuf JNADKFFEIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3C93B50", Offset = "0x3C92750", VA = "0x183C93B50")]
	public static HOEKDGLKAAO<Protobuf> JLAKJAPJOGA<T>(ReadOnlySpan<T> CHCFPJJJGHE)
	{
		return default(HOEKDGLKAAO<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2E7C0C0", Offset = "0x2E7ACC0", VA = "0x182E7C0C0")]
	public void LGBBBNEBCGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2E7C030", Offset = "0x2E7AC30", VA = "0x182E7C030")]
	public ByteString GBLNIBAJACB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2E7BF00", Offset = "0x2E7AB00", VA = "0x182E7BF00", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A6ED30", Offset = "0x3A6D930", VA = "0x183A6ED30")]
		public static void LEAMKENGDJN(in T PHMLIFLNFDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x14FE990", Offset = "0x14FD590", VA = "0x1814FE990")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A41960", Offset = "0x6A40560", VA = "0x186A41960")]
	public OFALOACMNEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1F62BA0", Offset = "0x1F617A0", VA = "0x181F62BA0")]
	public void OLBGCODNBJK<T>(T ECNGHFJBIJL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1F647C0", Offset = "0x1F633C0", VA = "0x181F647C0")]
	public T PNBJHLBKMLC<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6A41560", Offset = "0x6A40160", VA = "0x186A41560")]
	public void OLBGCODNBJK(Type FIJCKHKKDCC, CCENOJCALNE ECNGHFJBIJL, int KPLFNABLLDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6A41730", Offset = "0x6A40330", VA = "0x186A41730")]
	public bool PFLIDDOFNIB(Type FIJCKHKKDCC, out CCENOJCALNE PHBHEFAPHDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6A41800", Offset = "0x6A40400", VA = "0x186A41800")]
	public CCENOJCALNE PNBJHLBKMLC(Type FIJCKHKKDCC)
	{
		return default(CCENOJCALNE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6A411C0", Offset = "0x6A3FDC0", VA = "0x186A411C0")]
	public NativeArray<byte>.ReadOnly HNLDJCACBNM(Type FIJCKHKKDCC)
	{
		return default(NativeArray<byte>.ReadOnly);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6A413D0", Offset = "0x6A3FFD0", VA = "0x186A413D0")]
	public bool NAFOHKNGFLD(Type FIJCKHKKDCC, out NativeArray<byte>.ReadOnly PHBHEFAPHDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6A40F30", Offset = "0x6A3FB30", VA = "0x186A40F30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6A40FD0", Offset = "0x6A3FBD0", VA = "0x186A40FD0", Slot = "1")]
	~OFALOACMNEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6A410F0", Offset = "0x6A3FCF0", VA = "0x186A410F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x488F9D0", Offset = "0x488E5D0", VA = "0x18488F9D0")]
		get
		{
			return (T)null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x48920F0", Offset = "0x4890CF0", VA = "0x1848920F0")]
	public static BAGKINIFOEG<T> DGIADCHILCD(T ECNGHFJBIJL)
	{
		return default(BAGKINIFOEG<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x48914D0", Offset = "0x48900D0", VA = "0x1848914D0")]
	public static T DGIADCHILCD(BAGKINIFOEG<T> IGBKLJLDCLC)
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
	[Cpp2IlInjected.Address(RVA = "0x2D04800", Offset = "0x2D03400", VA = "0x182D04800")]
	public static void OLBGCODNBJK<T>(T ECNGHFJBIJL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2D05A10", Offset = "0x2D04610", VA = "0x182D05A10")]
	public static T PNBJHLBKMLC<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C5D0", Offset = "0x6A3B1D0", VA = "0x186A3C5D0")]
	public static NativeArray<byte>.ReadOnly HNLDJCACBNM(Type FIJCKHKKDCC)
	{
		return default(NativeArray<byte>.ReadOnly);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C660", Offset = "0x6A3B260", VA = "0x186A3C660")]
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
		[Cpp2IlInjected.Address(RVA = "0x91F8E0", Offset = "0x91E4E0", VA = "0x18091F8E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int PLEPIEDOEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA81DD0", Offset = "0xA809D0", VA = "0x180A81DD0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x114DF20", Offset = "0x114CB20", VA = "0x18114DF20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int FGLOEBEFDGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x91F8E0", Offset = "0x91E4E0", VA = "0x18091F8E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x91F850", Offset = "0x91E450", VA = "0x18091F850")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int FGKHEPONKIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6A3B280", Offset = "0x6A39E80", VA = "0x186A3B280")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6A3B290", Offset = "0x6A39E90", VA = "0x186A3B290")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8214F0", Offset = "0x8200F0", VA = "0x1808214F0")]
	private DFGMPCKANBL(int MCMFGBNCCMI, int FGHOJPFDCIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x37A6A30", Offset = "0x37A5630", VA = "0x1837A6A30")]
	public static DFGMPCKANBL AKNOMGKADJH(int MCMFGBNCCMI, int FGHOJPFDCIA)
	{
		return default(DFGMPCKANBL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B2A0", Offset = "0x6A39EA0", VA = "0x186A3B2A0")]
	public static DFGMPCKANBL NNFPOLINMML(int DBEIIGKEBIB, int NBBICLPHKEO)
	{
		return default(DFGMPCKANBL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B2B0", Offset = "0x6A39EB0", VA = "0x186A3B2B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct ENKBJEIDMMK : JIALLIDJLOI<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6A3BCF0", Offset = "0x6A3A8F0", VA = "0x186A3BCF0")]
	public float IAODJDJKLAM(in float3 ECNGHFJBIJL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6A3BCF0", Offset = "0x6A3A8F0", VA = "0x186A3BCF0", Slot = "4")]
	private float FDEFLDLLALD(in float3 ECNGHFJBIJL)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct FNIHMCODPEE : JIALLIDJLOI<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C4A0", Offset = "0x6A3B0A0", VA = "0x186A3C4A0")]
	public float IAODJDJKLAM(in float3 ECNGHFJBIJL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C4A0", Offset = "0x6A3B0A0", VA = "0x186A3C4A0", Slot = "4")]
	private float FDEFLDLLALD(in float3 ECNGHFJBIJL)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct FHGIAEHDJGC : JIALLIDJLOI<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x13790B0", Offset = "0x1377CB0", VA = "0x1813790B0")]
	public float IAODJDJKLAM(in float3 ECNGHFJBIJL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x13790B0", Offset = "0x1377CB0", VA = "0x1813790B0", Slot = "4")]
	private float FDEFLDLLALD(in float3 ECNGHFJBIJL)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct POAPEMNACGB : JIALLIDJLOI<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x15B1900", Offset = "0x15B0500", VA = "0x1815B1900")]
	public int IAODJDJKLAM(in int3 ECNGHFJBIJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x15B1900", Offset = "0x15B0500", VA = "0x1815B1900", Slot = "4")]
	private int OLEOFPHANIO(in int3 ECNGHFJBIJL)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct MEJHLFPGBNK : JIALLIDJLOI<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x65BFD60", Offset = "0x65BE960", VA = "0x1865BFD60")]
	public int IAODJDJKLAM(in int3 ECNGHFJBIJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x65BFD60", Offset = "0x65BE960", VA = "0x1865BFD60", Slot = "4")]
	private int OLEOFPHANIO(in int3 ECNGHFJBIJL)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct DOMHBDKABAP : JIALLIDJLOI<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x22D3AB0", Offset = "0x22D26B0", VA = "0x1822D3AB0")]
	public int IAODJDJKLAM(in int3 ECNGHFJBIJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x22D3AB0", Offset = "0x22D26B0", VA = "0x1822D3AB0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A3B030", Offset = "0x6A39C30", VA = "0x186A3B030", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x839000", Offset = "0x837C00", VA = "0x180839000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public World HGMOJEBDBNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public EntityManager EHBCKOIMEPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6A39C20", Offset = "0x6A38820", VA = "0x186A39C20")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public PGDOKNDMILI IOEFOKHCAJD
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x83D1E0", Offset = "0x83BDE0", VA = "0x18083D1E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public BFJGLKGJIEH<DGLDCDLCECP> FIOMNDALOBN
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x838FF0", Offset = "0x837BF0", VA = "0x180838FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x88FE20", Offset = "0x88EA20", VA = "0x18088FE20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public BFJGLKGJIEH<MFCOBEFGBOI> GMLDEHHIHCF
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x843910", Offset = "0x842510", VA = "0x180843910")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x843920", Offset = "0x842520", VA = "0x180843920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public BFJGLKGJIEH<AKKNCOHCIBK> IHDJMOOJEKC
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x89C580", Offset = "0x89B180", VA = "0x18089C580")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x89C6B0", Offset = "0x89B2B0", VA = "0x18089C6B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public World.NoAllocReadOnlyCollection<ComponentSystemBase> DJFECEFGDAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2FBB670", Offset = "0x2FBA270", VA = "0x182FBB670")]
		get
		{
			return default(World.NoAllocReadOnlyCollection<ComponentSystemBase>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public ComponentSystemGroup[] OMPKIAOLEMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7F3240", Offset = "0x7F1E40", VA = "0x1807F3240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6A39860", Offset = "0x6A38460", VA = "0x186A39860")]
	public static AFEABPHNIHP DMJMIMLAFKK(string BPOKAAOBIOI, LNGKPFAGLPC BJCAHHPNCBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A120", Offset = "0x6A38D20", VA = "0x186A3A120")]
	public AFEABPHNIHP(string BPOKAAOBIOI, LNGKPFAGLPC BJCAHHPNCBK = LNGKPFAGLPC.Simulation, PACEBIKNHGA MDFPINHICMD = PACEBIKNHGA.Default, bool HCKNDFMIDDI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6A39E70", Offset = "0x6A38A70", VA = "0x186A39E70")]
	public ComponentSystemBase KHHDMEMKEDJ(Type FIJCKHKKDCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x174F2F0", Offset = "0x174DEF0", VA = "0x18174F2F0")]
	public T KHHDMEMKEDJ<T>() where T : ComponentSystemBase
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6A39800", Offset = "0x6A38400", VA = "0x186A39800")]
	public void DCKJOFGAPLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6A39C40", Offset = "0x6A38840", VA = "0x186A39C40")]
	public void GIACMDIKOIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6A39FE0", Offset = "0x6A38BE0", VA = "0x186A39FE0")]
	public void PGDHBFKNGNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6A39E90", Offset = "0x6A38A90", VA = "0x186A39E90")]
	public void KNIMMGCFILF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6A39E10", Offset = "0x6A38A10", VA = "0x186A39E10")]
	public void JJNLLMFNELN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6A39DB0", Offset = "0x6A389B0", VA = "0x186A39DB0")]
	public void HKOIOEAKGFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6A396C0", Offset = "0x6A382C0", VA = "0x186A396C0")]
	public void AKENMPCLMGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6A39EF0", Offset = "0x6A38AF0", VA = "0x186A39EF0")]
	public void LCAKHHGPIIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6A397A0", Offset = "0x6A383A0", VA = "0x186A397A0")]
	public void BBHKPPJGGFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6A39F80", Offset = "0x6A38B80", VA = "0x186A39F80")]
	public void NLGPPFHEBBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A040", Offset = "0x6A38C40", VA = "0x186A3A040")]
	internal void PNFOINLDGBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6A39720", Offset = "0x6A38320", VA = "0x186A39720")]
	private bool ALEFOKBFGFM(ComponentSystemGroup JDPPDHMPNHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6A39950", Offset = "0x6A38550", VA = "0x186A39950")]
	private void ELNAGHBBCAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6A39CA0", Offset = "0x6A388A0", VA = "0x186A39CA0")]
	private ComponentSystemGroup[] HDEMIFJCDLH(PACEBIKNHGA MDFPINHICMD, bool IBDLFJOOKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6A398E0", Offset = "0x6A384E0", VA = "0x186A398E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class MOEGJNFINMG
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6A40C50", Offset = "0x6A3F850", VA = "0x186A40C50")]
	[MustUseReturnValue]
	public static JobHandle ACLJCEMAKJG(this EntityCommandBufferSystem PPANIHNCFCJ, NativeList<Entity> FPMGLBFKKPO, [Optional] JobHandle NPBMDGDOAPE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6A40DE0", Offset = "0x6A3F9E0", VA = "0x186A40DE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2756C30", Offset = "0x2755830", VA = "0x182756C30")]
	public static void PGBDIAMPABG<T>(this EntityCommandBufferSystem PPANIHNCFCJ, EntityQuery DPBAMGMJJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2756B70", Offset = "0x2755770", VA = "0x182756B70")]
	[MustUseReturnValue]
	public static JobHandle OPNCEBPJOEE<T>(this EntityCommandBufferSystem PPANIHNCFCJ, NativeListAsync<Entity> FPMGLBFKKPO, [Optional] JobHandle NPBMDGDOAPE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x27563F0", Offset = "0x2754FF0", VA = "0x1827563F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x839000", Offset = "0x837C00", VA = "0x180839000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6A41ED0", Offset = "0x6A40AD0", VA = "0x186A41ED0")]
	public PGDOKNDMILI(AFEABPHNIHP GPEEKLGBDDJ, EntityManager LMJGFJDJJLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1F764D0", Offset = "0x1F750D0", VA = "0x181F764D0")]
	public bool MDBBGOOJDFA<T>(Entity CMBJDMJHALL) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1F76510", Offset = "0x1F75110", VA = "0x181F76510")]
	public bool MOFPCFDEKAK<T>(Entity CMBJDMJHALL, out T ECNGHFJBIJL) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1F74980", Offset = "0x1F73580", VA = "0x181F74980")]
	public T LMPKJKBGPGN<T>(Entity CMBJDMJHALL) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1F74100", Offset = "0x1F72D00", VA = "0x181F74100")]
	private ComponentType CKIBMPCHEKG<T>() where T : struct, IComponent
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6A41D40", Offset = "0x6A40940", VA = "0x186A41D40")]
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
		[Cpp2IlInjected.Address(RVA = "0x246A640", Offset = "0x2469240", VA = "0x18246A640")]
		public NativeListAsync<Entity> EKPJNDPEBEC<TPredicate>() where TPredicate : struct, GICACEPGEBH<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2920DF0", Offset = "0x291F9F0", VA = "0x182920DF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F6030", Offset = "0x7F4C30", VA = "0x1807F6030")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6A40EE0", Offset = "0x6A3FAE0", VA = "0x186A40EE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x91E4D0", Offset = "0x91D0D0", VA = "0x18091E4D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xC9F550", Offset = "0xC9E150", VA = "0x180C9F550")]
		[DebuggerHidden]
		public IOPAFAFHAGP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6A3DE50", Offset = "0x6A3CA50", VA = "0x186A3DE50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6A3DB90", Offset = "0x6A3C790", VA = "0x186A3DB90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6A3DB40", Offset = "0x6A3C740", VA = "0x186A3DB40")]
		private void EHFOANOMIIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6A3DE10", Offset = "0x6A3CA10", VA = "0x186A3DE10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6A3DD60", Offset = "0x6A3C960", VA = "0x186A3DD60", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6A3DD60", Offset = "0x6A3C960", VA = "0x186A3DD60", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A3E9A0", Offset = "0x6A3D5A0", VA = "0x186A3E9A0")]
	public static JGJKMCDDCIF JLAKJAPJOGA()
	{
		return default(JGJKMCDDCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E1E0", Offset = "0x6A3CDE0", VA = "0x186A3E1E0")]
	public JGJKMCDDCIF EHMLDGBAGOA(PACEBIKNHGA BJCAHHPNCBK)
	{
		return default(JGJKMCDDCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E9C0", Offset = "0x6A3D5C0", VA = "0x186A3E9C0")]
	public JGJKMCDDCIF MGMHFKGFOFF(IEnumerable<Type> LONDNADJAMP)
	{
		return default(JGJKMCDDCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E990", Offset = "0x6A3D590", VA = "0x186A3E990")]
	public JGJKMCDDCIF JBLFHNMIOGD(bool GHPCJNFPKGM)
	{
		return default(JGJKMCDDCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6A3DF70", Offset = "0x6A3CB70", VA = "0x186A3DF70")]
	public JGJKMCDDCIF ANDLEFEEEPE(bool GCELNGKNAOM)
	{
		return default(JGJKMCDDCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6A3DF80", Offset = "0x6A3CB80", VA = "0x186A3DF80")]
	public NFFGPMNOCOF DIEOPPNBAEK(Type[] AGMDDLAFMJO)
	{
		return default(NFFGPMNOCOF);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6A3DEE0", Offset = "0x6A3CAE0", VA = "0x186A3DEE0")]
	[IteratorStateMachine(typeof(IOPAFAFHAGP))]
	internal IEnumerable<Type> AICMJJAPNCN(IEnumerable<Type> LONDNADJAMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6A3EA00", Offset = "0x6A3D600", VA = "0x186A3EA00")]
	internal Dictionary<Type, List<Type>> OABGBMBILEN(IEnumerable<Type> LONDNADJAMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6A3ECE0", Offset = "0x6A3D8E0", VA = "0x186A3ECE0")]
	private void OEHCIJIJMIF(Dictionary<Type, List<Type>> KKIGAGCNEHG, Type FIJCKHKKDCC, Type GFFIJCJGAJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E020", Offset = "0x6A3CC20", VA = "0x186A3E020")]
	internal HashSet<Type> EDNHPFBFDOM(IEnumerable<Type> CJGHDKIGFAL, Dictionary<Type, List<Type>> GNJLJGGMKOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E1F0", Offset = "0x6A3CDF0", VA = "0x186A3E1F0")]
	internal bool IKGLIEFNFGE(Type FIJCKHKKDCC, PACEBIKNHGA MDFPINHICMD, bool IBDLFJOOKBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E830", Offset = "0x6A3D430", VA = "0x186A3E830")]
	[CompilerGenerated]
	internal static void IPMIDCOKMOD(Type FIJCKHKKDCC, ref DPMOLDAINHO P_1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class DOLJLBPFGJJ
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x36DC5D0", Offset = "0x36DB1D0", VA = "0x1836DC5D0")]
	public static NativeList<Entity> NIDANPLCCPN<T>(this NativeArray<Entity> NEDOPJDBOOK, EntityManager LMJGFJDJJLA, Allocator FKPADLBILGP = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class PHCKPOHNJNK
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private struct PHPCJPHJMEM : JIALLIDJLOI<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> IFNFCNOALAD;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6A41F20", Offset = "0x6A40B20", VA = "0x186A41F20")]
		[BurstCompatible]
		public Entity IAODJDJKLAM(in Entity ECNGHFJBIJL)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6A41F20", Offset = "0x6A40B20", VA = "0x186A41F20", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A3A640", Offset = "0x6A39240", VA = "0x186A3A640")]
	public static bool BIIFBHKMNEE(Type FIJCKHKKDCC, Type DGDGPJEIFCF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public abstract class PMDCKHPFFBE : DEOJGEHECCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6A41FD0", Offset = "0x6A40BD0", VA = "0x186A41FD0", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected abstract ComponentSystemBase ACOOADPIPBA();

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6A41F80", Offset = "0x6A40B80", VA = "0x186A41F80")]
	protected ComponentSystemBase OPDBPNNIPNJ(params ComponentSystemBase[] KHIAODMJMEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1F796F0", Offset = "0x1F782F0", VA = "0x181F796F0")]
	protected ComponentSystemBase OPDBPNNIPNJ<T>(params ComponentSystemBase[] KHIAODMJMEB) where T : DEOJGEHECCJ, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1F795D0", Offset = "0x1F781D0", VA = "0x181F795D0")]
	protected ComponentSystemBase BJAGJCDLMMK<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1F795D0", Offset = "0x1F781D0", VA = "0x181F795D0")]
	protected ComponentSystemBase DGPKLMJLFNH<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6A41F30", Offset = "0x6A40B30", VA = "0x186A41F30")]
	protected ComponentSystemBase MKLPCEGIBBD(params SystemHandleUntyped[] KHIAODMJMEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1F79610", Offset = "0x1F78210", VA = "0x181F79610")]
	protected ComponentSystemBase MKLPCEGIBBD<T>(params SystemHandleUntyped[] KHIAODMJMEB) where T : DEOJGEHECCJ, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1F796A0", Offset = "0x1F782A0", VA = "0x181F796A0")]
	protected SystemHandleUntyped NMNKIAIFLEC<T>() where T : struct, ISystem
	{
		return default(SystemHandleUntyped);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B1F0", Offset = "0x6A39DF0", VA = "0x186A3B1F0")]
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
	BFJGLKGJIEH<BaseClass> MINFOLDOHDJ();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class GJGEHGNCJIE
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2D0A940", Offset = "0x2D09540", VA = "0x182D0A940")]
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
internal struct POJFECOCFBC<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : JIALLIDJLOI<TFrom, TTo>
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
internal struct FDHNPOFEAJH<T, TPredicate> : IJob where T : struct where TPredicate : struct, GICACEPGEBH<T>
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
	[Cpp2IlInjected.Address(RVA = "0x1D640E0", Offset = "0x1D62CE0", VA = "0x181D640E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
internal struct OMFCGMFCCFF<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, JIALLIDJLOI<TFrom, TTo>
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
internal class GPBKOAMMEHF : IBHAHBMDJLH<NKHINJNHLDM, DGLDCDLCECP>
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C850", Offset = "0x6A3B450", VA = "0x186A3C850")]
	public GPBKOAMMEHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal abstract class IBHAHBMDJLH<Attribute, BaseClass> : NBMCIPHNCFJ<BaseClass>, GJEPOCECPGN where Attribute : NIHPIFKMGGM
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
	[Cpp2IlInjected.Address(RVA = "0x4751100", Offset = "0x474FD00", VA = "0x184751100")]
	public IBHAHBMDJLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4750F70", Offset = "0x474FB70", VA = "0x184750F70", Slot = "4")]
	public bool ODOLPHCGINH(int GJCJMGJCOPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4750CC0", Offset = "0x474F8C0", VA = "0x184750CC0", Slot = "5")]
	public BFJGLKGJIEH<BaseClass> MINFOLDOHDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4750A90", Offset = "0x474F690", VA = "0x184750A90", Slot = "7")]
	protected virtual bool BIIFBHKMNEE(Type FIJCKHKKDCC, int GIOIBEJJEBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4750FD0", Offset = "0x474FBD0", VA = "0x184750FD0", Slot = "8")]
	protected virtual int PBPIADAHKIL(Type FIJCKHKKDCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4750B90", Offset = "0x474F790", VA = "0x184750B90")]
	public void FFPJNMKMBJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4750C20", Offset = "0x474F820", VA = "0x184750C20", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x820FC0", Offset = "0x81FBC0", VA = "0x180820FC0")]
		public LDKJPNACANF(ulong AABAOCJNFFN, COMLEFGIJKK JKJJBILHHIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6A3F480", Offset = "0x6A3E080", VA = "0x186A3F480", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6A3F330", Offset = "0x6A3DF30", VA = "0x186A3F330", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xC9F550", Offset = "0xC9E150", VA = "0x180C9F550")]
		[DebuggerHidden]
		public JNGJBINMJCM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6A3F380", Offset = "0x6A3DF80", VA = "0x186A3F380", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6A3EFD0", Offset = "0x6A3DBD0", VA = "0x186A3EFD0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6A3EF80", Offset = "0x6A3DB80", VA = "0x186A3EF80")]
		private void EHFOANOMIIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6A3F2F0", Offset = "0x6A3DEF0", VA = "0x186A3F2F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6A3F240", Offset = "0x6A3DE40", VA = "0x186A3F240", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<COMLEFGIJKK> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Attributes.NameHash>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6A3F240", Offset = "0x6A3DE40", VA = "0x186A3F240", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A40690", Offset = "0x6A3F290", VA = "0x186A40690")]
	public static ulong KJKFEHIMJMJ(int GJCJMGJCOPK)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6A405E0", Offset = "0x6A3F1E0", VA = "0x186A405E0")]
	public static int JFBOPNIILDN(ulong JKJJBILHHIM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6A40900", Offset = "0x6A3F500", VA = "0x186A40900")]
	public static void PBAELFIBGFO(bool HCKNDFMIDDI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6A3FA60", Offset = "0x6A3E660", VA = "0x186A3FA60")]
	private static void CFNJFEAOHGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6A3FB20", Offset = "0x6A3E720", VA = "0x186A3FB20")]
	private static void CFNJFEAOHGP(IEnumerable<Type> LONDNADJAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F980", Offset = "0x6A3E580", VA = "0x186A3F980")]
	private static void CAKDJHLFBLC(int FILOPMLNENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6A40270", Offset = "0x6A3EE70", VA = "0x186A40270")]
	private static void HKPHNIPNJLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6A40780", Offset = "0x6A3F380", VA = "0x186A40780")]
	private static (ulong, IEnumerable<COMLEFGIJKK>) KPGKEHHNHNH(Type FIJCKHKKDCC)
	{
		return default((ulong, IEnumerable<COMLEFGIJKK>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6A406F0", Offset = "0x6A3F2F0", VA = "0x186A406F0")]
	[IteratorStateMachine(typeof(JNGJBINMJCM))]
	private static IEnumerable<COMLEFGIJKK> KNOABKALDDB(Type FIJCKHKKDCC, ulong JKJJBILHHIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6A3FDF0", Offset = "0x6A3E9F0", VA = "0x186A3FDF0")]
	private static void FGFIDBBENNC(ulong JKJJBILHHIM, IEnumerable<COMLEFGIJKK> GMFFEAKKGAE, TypeManager.TypeInfo EEIDDEHCPMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F880", Offset = "0x6A3E480", VA = "0x186A3F880")]
	private static void BDPIJDFBLMM(LDKJPNACANF EEIDDEHCPMB, int GJCJMGJCOPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6A400F0", Offset = "0x6A3ECF0", VA = "0x186A400F0")]
	private static void FHFIJEIOOPA(LDKJPNACANF EEIDDEHCPMB, int GJCJMGJCOPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6A401E0", Offset = "0x6A3EDE0", VA = "0x186A401E0")]
	private static LDKJPNACANF GMIPBBEHMHI(int GJCJMGJCOPK)
	{
		return default(LDKJPNACANF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6A405D0", Offset = "0x6A3F1D0", VA = "0x186A405D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FB9E50", Offset = "0x1FB8A50", VA = "0x181FB9E50")]
			get
			{
				return default(DFGMPCKANBL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T LOFOOLDNEHF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9E60", Offset = "0x1FB8A60", VA = "0x181FB9E60")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public (T, DFGMPCKANBL) NIBFGHDNPCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x386FC20", Offset = "0x386E820", VA = "0x18386FC20")]
			get
			{
				return default((T, DFGMPCKANBL));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x38700E0", Offset = "0x386ECE0", VA = "0x1838700E0")]
		public IOBDCDGKECN(NativeArray<T> EABDNHJFDCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x384BC30", Offset = "0x384A830", VA = "0x18384BC30")]
		public IOBDCDGKECN<T> MEOEHOBEEMI()
		{
			return default(IOBDCDGKECN<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x386FF50", Offset = "0x386EB50", VA = "0x18386FF50")]
		public bool MIOEPBKKBNP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2DC4D50", Offset = "0x2DC3950", VA = "0x182DC4D50")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FB9E50", Offset = "0x1FB8A50", VA = "0x181FB9E50")]
			get
			{
				return default(DFGMPCKANBL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public T LOFOOLDNEHF
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9E60", Offset = "0x1FB8A60", VA = "0x181FB9E60")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public (T value, DFGMPCKANBL range) NIBFGHDNPCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9E80", Offset = "0x1FB8A80", VA = "0x181FB9E80")]
			get
			{
				return default((T, DFGMPCKANBL));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x1FBA1F0", Offset = "0x1FB8DF0", VA = "0x181FBA1F0")]
		public NDHLPCENPNP(NativeArray<T>.ReadOnly EABDNHJFDCB, TComparer GCAEFOMJOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x1FB9F50", Offset = "0x1FB8B50", VA = "0x181FB9F50")]
		public NDHLPCENPNP<T, TComparer> MEOEHOBEEMI()
		{
			return default(NDHLPCENPNP<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x1FB9F90", Offset = "0x1FB8B90", VA = "0x181FB9F90")]
		public bool MIOEPBKKBNP()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2917940", Offset = "0x2916540", VA = "0x182917940")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A41A10", Offset = "0x6A40610", VA = "0x186A41A10")]
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
	[Cpp2IlInjected.Address(RVA = "0x7F3020", Offset = "0x7F1C20", VA = "0x1807F3020")]
	protected IKNIOKDNHBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class MOEBPIEJEHJ
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x268B5B0", Offset = "0x268A1B0", VA = "0x18268B5B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3870A30", Offset = "0x386F630", VA = "0x183870A30", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FC0E80", Offset = "0x1FBFA80", VA = "0x181FC0E80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IEnumerable<BaseClass> DBENEACIGAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x26DC1B0", Offset = "0x26DADB0", VA = "0x1826DC1B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x26DC530", Offset = "0x26DB130", VA = "0x1826DC530")]
	public BFJGLKGJIEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x26DC6C0", Offset = "0x26DB2C0", VA = "0x1826DC6C0")]
	public BFJGLKGJIEH(int CABFJBCMJEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x26DC3E0", Offset = "0x26DAFE0", VA = "0x1826DC3E0")]
	internal void CAILCKFFJIK(int GJCJMGJCOPK, BaseClass CPIEKHBBHCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2836CB0", Offset = "0x28358B0", VA = "0x182836CB0")]
	public bool CJMEEDACJIA<T>(out BaseClass ECNGHFJBIJL) where T : IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x26DC460", Offset = "0x26DB060", VA = "0x1826DC460")]
	public bool CJMEEDACJIA(Type GDOKANFLACL, out BaseClass ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x1FBA430", Offset = "0x1FB9030", VA = "0x181FBA430")]
	public bool PMIPEJMDEHL(int GJCJMGJCOPK, out BaseClass ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2837A70", Offset = "0x2836670", VA = "0x182837A70")]
	public T ELBMGAGFHLI<T>() where T : BaseClass
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x26DC500", Offset = "0x26DB100", VA = "0x1826DC500")]
	public BaseClass ELBMGAGFHLI(Type LLNJOBIDKCE)
	{
		return (BaseClass)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal class KILLGJJIMEA : IBHAHBMDJLH<OALALKKKNCP, MFCOBEFGBOI>
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F410", Offset = "0x6A3E010", VA = "0x186A3F410")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A3C7F0", Offset = "0x6A3B3F0", VA = "0x186A3C7F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class OPKPAOPDKEI
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x1F6D7E0", Offset = "0x1F6C3E0", VA = "0x181F6D7E0")]
	public static NativeArray<T> KIJJPLBIKIL<T>(this NativeList<Entity> PAPBDDPJFAJ, EntityManager LMJGFJDJJLA, Allocator FKPADLBILGP = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x1F6D570", Offset = "0x1F6C170", VA = "0x181F6D570")]
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
	[Cpp2IlInjected.Address(RVA = "0x328B050", Offset = "0x3289C50", VA = "0x18328B050", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class LIPPMCDPHPN
{
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x30868A0", Offset = "0x30854A0", VA = "0x1830868A0")]
	[MustUseReturnValue]
	public static JobHandle NLLFDBKALMO<T>(this EntityCommandBufferSystem PPANIHNCFCJ, EntityCommandBuffer FIENHHJAMHI, EntityQuery DPBAMGMJJLC, T ECNGHFJBIJL) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x30867C0", Offset = "0x30853C0", VA = "0x1830867C0")]
	[MustUseReturnValue]
	public static JobHandle NLLFDBKALMO<T>(this EntityCommandBufferSystem PPANIHNCFCJ, NativeArrayAsync<Entity> FPMGLBFKKPO, NativeArrayAsync<T> ECNGHFJBIJL) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3086650", Offset = "0x3085250", VA = "0x183086650")]
	[MustUseReturnValue]
	public static JobHandle NLLFDBKALMO<T>(this EntityCommandBufferSystem PPANIHNCFCJ, EntityCommandBuffer FIENHHJAMHI, NativeArrayAsync<Entity> FPMGLBFKKPO, NativeArrayAsync<T> ECNGHFJBIJL) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal class ENNLNNLCJGJ : IBHAHBMDJLH<KBFDIMINBEO, AKKNCOHCIBK>
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6A3BD00", Offset = "0x6A3A900", VA = "0x186A3BD00")]
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
		[Cpp2IlInjected.Address(RVA = "0x346C970", Offset = "0x346B570", VA = "0x18346C970", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x26559F0", Offset = "0x26545F0", VA = "0x1826559F0", Slot = "8")]
	protected virtual bool FKIEGFNPIMN(ReadOnlySpan<Data> CHCFPJJJGHE, MHCHCENMNNH LOCFGCDNKMP, out ReadOnlySpan<byte> KNJBCHEFCED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7F3460", Offset = "0x7F2060", VA = "0x1807F3460", Slot = "9")]
	protected virtual bool BAOFGNAPECJ(int FPBNFBFIPHI, Span<Data> CHCFPJJJGHE, in ReadOnlySpan<byte> KNJBCHEFCED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x346C870", Offset = "0x346B470", VA = "0x18346C870", Slot = "5")]
	internal sealed override bool FKIEGFNPIMN(ref Unity.Entities.Chunk NLIPPJGPKOG, int BNNLAPKBIOF, MHCHCENMNNH LOCFGCDNKMP, out ReadOnlySpan<byte> KNJBCHEFCED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x346B0A0", Offset = "0x3469CA0", VA = "0x18346B0A0", Slot = "6")]
	internal sealed override bool BAOFGNAPECJ(int FPBNFBFIPHI, ref Unity.Entities.Chunk NLIPPJGPKOG, int BNNLAPKBIOF, in ReadOnlySpan<byte> KNJBCHEFCED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2DC4C70", Offset = "0x2DC3870", VA = "0x182DC4C70")]
	protected HOEKDGLKAAO<Protobuf> IJOPLFJMPHO<Protobuf>(ReadOnlySpan<Data> CHCFPJJJGHE) where Protobuf : IMessage, new()
	{
		return default(HOEKDGLKAAO<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2DC4CC0", Offset = "0x2DC38C0", VA = "0x182DC4CC0")]
	protected PGLAGHJANGJ<Protobuf> MHDMPPMKNEE<Protobuf>(ReadOnlySpan<byte> KNJBCHEFCED, ReadOnlySpan<Data> CHCFPJJJGHE, Action<Protobuf> GCGGKDKNPNA) where Protobuf : IMessage, new()
	{
		return default(PGLAGHJANGJ<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2854410", Offset = "0x2853010", VA = "0x182854410")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A3F550", Offset = "0x6A3E150", VA = "0x186A3F550", Slot = "5")]
	internal virtual bool FKIEGFNPIMN(ref Unity.Entities.Chunk NLIPPJGPKOG, int BNNLAPKBIOF, MHCHCENMNNH LOCFGCDNKMP, out ReadOnlySpan<byte> KNJBCHEFCED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x7F3460", Offset = "0x7F2060", VA = "0x1807F3460", Slot = "6")]
	internal virtual bool BAOFGNAPECJ(int FPBNFBFIPHI, ref Unity.Entities.Chunk NLIPPJGPKOG, int BNNLAPKBIOF, in ReadOnlySpan<byte> KNJBCHEFCED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
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
		public struct GNBEKNIHDCO<TKey> where TKey : struct, IEquatable<TKey>
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
		public struct EHMNMGDHONM<TKey> where TKey : struct, IEquatable<TKey>
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
		public struct ADEAPCNDMJC<TKey> where TKey : struct, IEquatable<TKey>
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
		public struct MNDKJGCKDNG<TKey> where TKey : struct, IEquatable<TKey>
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
	[Cpp2IlInjected.Address(RVA = "0x328E970", Offset = "0x328D570", VA = "0x18328E970", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2982FE0", Offset = "0x2981BE0", VA = "0x182982FE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x1F1BAC0", Offset = "0x1F1A6C0", VA = "0x181F1BAC0")]
	public static NativeListAsync<Entity> OELIENMIMKN<T, TPredicate>(this NativeArrayAsync<T> PAPBDDPJFAJ, NativeArrayAsync<Entity> NEDOPJDBOOK, Allocator FKPADLBILGP = Allocator.TempJob) where T : struct where TPredicate : struct, GICACEPGEBH<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x1F1B910", Offset = "0x1F1A510", VA = "0x181F1B910")]
	private static NativeListAsync<Entity> BFBPCEJHGKJ<T, TPredicate>(NativeArrayAsync<T> FDMFIPGIBNB, NativeArrayAsync<Entity> NEDOPJDBOOK, int HLPFAIAMMGH, Allocator FKPADLBILGP) where T : struct where TPredicate : struct, GICACEPGEBH<T>
	{
		return default(NativeListAsync<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class ACLLJCCMGPG
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x174CA20", Offset = "0x174B620", VA = "0x18174CA20")]
	[MustUseReturnValue]
	public static JobHandle PBDOFOAPMMF<T>(this EntityCommandBufferSystem PPANIHNCFCJ, NativeArray<Entity> FPMGLBFKKPO, T ECNGHFJBIJL, [Optional] JobHandle NPBMDGDOAPE) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x174C950", Offset = "0x174B550", VA = "0x18174C950")]
	[MustUseReturnValue]
	public static JobHandle PBDOFOAPMMF<T>(this EntityCommandBufferSystem PPANIHNCFCJ, EntityCommandBuffer FIENHHJAMHI, NativeArray<Entity> FPMGLBFKKPO, T ECNGHFJBIJL, [Optional] JobHandle NPBMDGDOAPE) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x174C890", Offset = "0x174B490", VA = "0x18174C890")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D024E0", Offset = "0x2D010E0", VA = "0x182D024E0")]
	public static NativeList<T> EAGPENIJKGE<T>(this NativeList<T> PAPBDDPJFAJ, Allocator FKPADLBILGP = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2D02310", Offset = "0x2D00F10", VA = "0x182D02310")]
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
internal struct FIMKPBDOMLO<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, JIALLIDJLOI<TFrom, TTo>
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
	[Cpp2IlInjected.Address(RVA = "0x6A3AFD0", Offset = "0x6A39BD0", VA = "0x186A3AFD0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[BurstCompile]
internal struct AKIAONOFANI<T, TPredicate> : IJob where T : struct where TPredicate : struct, GICACEPGEBH<T>
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
	[Cpp2IlInjected.Address(RVA = "0x6A3B250", Offset = "0x6A39E50", VA = "0x186A3B250", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B1F0", Offset = "0x6A39DF0", VA = "0x186A3B1F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x839000", Offset = "0x837C00", VA = "0x180839000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x842A50", Offset = "0x841650", VA = "0x180842A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0xB326D0", Offset = "0xB312D0", VA = "0x180B326D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A3AB90", Offset = "0x6A39790", VA = "0x186A3AB90")]
	public static int ILHBPGJKDMF(int GJCJMGJCOPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6A3AEB0", Offset = "0x6A39AB0", VA = "0x186A3AEB0")]
	public static void PBAELFIBGFO(bool HCKNDFMIDDI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6A3AC30", Offset = "0x6A39830", VA = "0x186A3AC30")]
	private static void JLDGCFEPJEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6A3AAC0", Offset = "0x6A396C0", VA = "0x186A3AAC0")]
	private static int CPCDBPJFPGH(Type FIJCKHKKDCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6A3AB10", Offset = "0x6A39710", VA = "0x186A3AB10")]
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
	[Cpp2IlInjected.Address(RVA = "0x1D5EC20", Offset = "0x1D5D820", VA = "0x181D5EC20", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3292B80", Offset = "0x3291780", VA = "0x183292B80", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class AMMGLDMAJIP
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A810", Offset = "0x6A39410", VA = "0x186A3A810")]
	public static ulong GEOLMDPOAFC(Type FIJCKHKKDCC)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A8A0", Offset = "0x6A394A0", VA = "0x186A3A8A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A39590", Offset = "0x6A38190", VA = "0x186A39590")]
	public static void PBAELFIBGFO(bool HCKNDFMIDDI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6A39360", Offset = "0x6A37F60", VA = "0x186A39360")]
	private static void MJFCMCFOCND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6A38FF0", Offset = "0x6A37BF0", VA = "0x186A38FF0")]
	private static void EPDPHHMMABF(Type ELNKCIBOCOL, Type CBHLPGJGAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6A38F70", Offset = "0x6A37B70", VA = "0x186A38F70")]
	private static void ELJLHOEKJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6A391D0", Offset = "0x6A37DD0", VA = "0x186A391D0")]
	public static int HMKNNJIMIKG(Type ELNKCIBOCOL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6A392C0", Offset = "0x6A37EC0", VA = "0x186A392C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A3CB50", Offset = "0x6A3B750", VA = "0x186A3CB50")]
	public static ComponentSystemGroup[] HDEMIFJCDLH(World GPEEKLGBDDJ, PACEBIKNHGA MDFPINHICMD = PACEBIKNHGA.Default, bool IBDLFJOOKBO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6A3CCE0", Offset = "0x6A3B8E0", VA = "0x186A3CCE0")]
	private static Type[] LLOCABGJLFO(PACEBIKNHGA MDFPINHICMD, bool IBDLFJOOKBO, ComponentSystemGroup[] CJGHDKIGFAL, ComponentSystemGroup DLIBOCPFIME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D040", Offset = "0x6A3BC40", VA = "0x186A3D040")]
	private static ComponentSystemGroup[] MEGKBKPHLAH(World GPEEKLGBDDJ, out ComponentSystemGroup DLIBOCPFIME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C8C0", Offset = "0x6A3B4C0", VA = "0x186A3C8C0")]
	internal static bool EMCIOKLDPDI(LNGKPFAGLPC BJCAHHPNCBK, out HJLOAJDGIBN BHPNIOIEDBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D350", Offset = "0x6A3BF50", VA = "0x186A3D350")]
	private static ComponentSystemGroup NMFCFFMKFDI(Type FIJCKHKKDCC, World GPEEKLGBDDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D430", Offset = "0x6A3C030", VA = "0x186A3D430")]
	private static ComponentSystemGroup[] PCJODGPLPMD(Type[] LONDNADJAMP, World GPEEKLGBDDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D560", Offset = "0x6A3C160", VA = "0x186A3D560")]
	internal static void PLKFLIELLCG(World GPEEKLGBDDJ, Type[] CDCNPKINHEM, ComponentSystemGroup[] CJGHDKIGFAL, ComponentSystemGroup DLIBOCPFIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6A3CC80", Offset = "0x6A3B880", VA = "0x186A3CC80")]
	internal static bool LIICPDIGDMI(ComponentSystemBase HHDENPAFOIF, ComponentSystemGroup[] CJGHDKIGFAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6A3CC20", Offset = "0x6A3B820", VA = "0x186A3CC20")]
	private static void IADJNGKOOOD(ComponentSystemGroup[] CJGHDKIGFAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class OALALKKKNCP : NIHPIFKMGGM
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0xB326D0", Offset = "0xB312D0", VA = "0x180B326D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A3EEF0", Offset = "0x6A3DAF0", VA = "0x186A3EEF0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public abstract class BBKLLGEPFAJ : SystemBase, KHPBHBLDCGG
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A970", Offset = "0x6A39570", VA = "0x186A3A970")]
	public ComponentDataFromEntity CCEKPMJGJAH(int GJCJMGJCOPK, bool INCMGOFNCLP = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6A3AA90", Offset = "0x6A39690", VA = "0x186A3AA90")]
	public EntityExistenceLookupByEntity IMKJLPPMDLA()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6A3AA40", Offset = "0x6A39640", VA = "0x186A3AA40")]
	public EntityQuery EGGCMBMNPIC(in EntityQueryDescBuilder EALACKPBAJJ)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6A3AAB0", Offset = "0x6A396B0", VA = "0x186A3AAB0", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x8A3CC0", Offset = "0x8A28C0", VA = "0x1808A3CC0")]
	protected BBKLLGEPFAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public abstract class IKBGPBBHAOK : BBKLLGEPFAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6A3DB10", Offset = "0x6A3C710", VA = "0x186A3DB10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x8A3CC0", Offset = "0x8A28C0", VA = "0x1808A3CC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A3B1F0", Offset = "0x6A39DF0", VA = "0x186A3B1F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E7D3F0", Offset = "0x2E7BFF0", VA = "0x182E7D3F0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public override int KKDFANILMMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2E7C4F0", Offset = "0x2E7B0F0", VA = "0x182E7C4F0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2E7C480", Offset = "0x2E7B080", VA = "0x182E7C480")]
	public Data FPNKHFHGOMJ(Entity CMBJDMJHALL)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract View FGCMFKBIFEL(Entity CMBJDMJHALL);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3C978C0", Offset = "0x3C964C0", VA = "0x183C978C0", Slot = "14")]
	protected internal override T FGCMFKBIFEL<T>(Entity CMBJDMJHALL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2854410", Offset = "0x2853010", VA = "0x182854410")]
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
		[Cpp2IlInjected.Address(RVA = "0x839000", Offset = "0x837C00", VA = "0x180839000", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xDAAA20", Offset = "0xDA9620", VA = "0x180DAAA20")]
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
		[Cpp2IlInjected.Address(RVA = "0xD10B80", Offset = "0xD0F780", VA = "0x180D10B80", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private int HGLMODJIGNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6A3B720", Offset = "0x6A3A320", VA = "0x186A3B720", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private DAEIOAAPCOE[] HHKLFBHKGFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xB5A190", Offset = "0xB58D90", VA = "0x180B5A190", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	protected internal virtual DAEIOAAPCOE[] IMGJKIMNGJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6A3B660", Offset = "0x6A3A260", VA = "0x186A3B660", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B790", Offset = "0x6A3A390", VA = "0x186A3B790")]
	public void PBAELFIBGFO(EntityManager LMJGFJDJJLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x9C6D70", Offset = "0x9C5970", VA = "0x1809C6D70")]
	protected PHIGEONMPOB DCELMIPGPEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "14")]
	protected internal abstract T FGCMFKBIFEL<T>(Entity CMBJDMJHALL) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B510", Offset = "0x6A3A110", VA = "0x186A3B510", Slot = "8")]
	public (uint, uint) ILHBPGJKDMF(Entity CMBJDMJHALL)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B5D0", Offset = "0x6A3A1D0", VA = "0x186A3B5D0", Slot = "9")]
	public bool MFIELPFAIPE(Entity CMBJDMJHALL, (uint order, uint change) FPBNFBFIPHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
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
	[Cpp2IlInjected.Address(RVA = "0xB1CC20", Offset = "0xB1B820", VA = "0x180B1CC20")]
	private EHCAPCHEGDN(List<Type> LONDNADJAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B930", Offset = "0x6A3A530", VA = "0x186A3B930")]
	public static void FFPJNMKMBJA(List<Type> LONDNADJAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B9C0", Offset = "0x6A3A5C0", VA = "0x186A3B9C0")]
	private void KEIFOEFMOLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B8B0", Offset = "0x6A3A4B0", VA = "0x186A3B8B0")]
	private bool BIIFBHKMNEE(Type FIJCKHKKDCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6A3BC00", Offset = "0x6A3A800", VA = "0x186A3BC00")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F3000", Offset = "0x7F1C00", VA = "0x1807F3000")]
		[CompilerGenerated]
		get
		{
			return default(LNGKPFAGLPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F580", Offset = "0x6A3E180", VA = "0x186A3F580")]
	public MJMELKOJNAD(LNGKPFAGLPC BJCAHHPNCBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public class GLODNPPMBII : LBCLEEENKKC
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x8A3CC0", Offset = "0x8A28C0", VA = "0x1808A3CC0")]
	public GLODNPPMBII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public abstract class AKKNCOHCIBK
{
	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x81BCD0", Offset = "0x81A8D0", VA = "0x18081BCD0")]
		public FIMFLEFLLCH(NativeArray<TSrc> EABDNHJFDCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xE90DB0", Offset = "0xE8F9B0", VA = "0x180E90DB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x81BCD0", Offset = "0x81A8D0", VA = "0x18081BCD0")]
		public NPDLCJCGNFL(NativeArray<TSrc> EABDNHJFDCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xE90DB0", Offset = "0xE8F9B0", VA = "0x180E90DB0")]
		public IBOHGPFOMFK<TSrc, TValue, TSelector> LNDGPDJIGJO<TSelector>() where TSelector : struct, JIALLIDJLOI<TSrc, TValue>
		{
			return default(IBOHGPFOMFK<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public readonly struct IBOHGPFOMFK<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, JIALLIDJLOI<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly NativeArray<TSrc> EABDNHJFDCB;

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x81BCD0", Offset = "0x81A8D0", VA = "0x18081BCD0")]
		public IBOHGPFOMFK(NativeArray<TSrc> EABDNHJFDCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x4752250", Offset = "0x4750E50", VA = "0x184752250")]
		public DGOOBOAJBKI<TSrc, TValue, TSelector> OPDBPNNIPNJ()
		{
			return default(DGOOBOAJBKI<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public struct IPHNGCIIHPC<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, JIALLIDJLOI<TSrc, TValue>
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
			[Cpp2IlInjected.Address(RVA = "0x3872840", Offset = "0x3871440", VA = "0x183872840")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int OJOINFOLDPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x7F3220", Offset = "0x7F1E20", VA = "0x1807F3220")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int PJKEDAIIMDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x38728D0", Offset = "0x38714D0", VA = "0x1838728D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3872A10", Offset = "0x3871610", VA = "0x183872A10")]
		public IPHNGCIIHPC(NativeArray<TSrc> EABDNHJFDCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x38728B0", Offset = "0x38714B0", VA = "0x1838728B0")]
		public bool MIOEPBKKBNP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x38728E0", Offset = "0x38714E0", VA = "0x1838728E0")]
		private TSrc OKNGNIBBBIN(int OCIFJAIBHIA)
		{
			return (TSrc)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public struct DGOOBOAJBKI<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, JIALLIDJLOI<TSrc, TValue>
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
			[Cpp2IlInjected.Address(RVA = "0x2A407D0", Offset = "0x2A3F3D0", VA = "0x182A407D0")]
			get
			{
				return default(DFGMPCKANBL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public TValue LOFOOLDNEHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x87CCA0", Offset = "0x87B8A0", VA = "0x18087CCA0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public (TValue value, DFGMPCKANBL range) NIBFGHDNPCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x2A40810", Offset = "0x2A3F410", VA = "0x182A40810")]
			get
			{
				return default((TValue, DFGMPCKANBL));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2A40A20", Offset = "0x2A3F620", VA = "0x182A40A20")]
		public DGOOBOAJBKI(NativeArray<TSrc> EABDNHJFDCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2905170", Offset = "0x2903D70", VA = "0x182905170")]
		public DGOOBOAJBKI<TSrc, TValue, TSelector> MEOEHOBEEMI()
		{
			return default(DGOOBOAJBKI<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x2A408F0", Offset = "0x2A3F4F0", VA = "0x182A408F0")]
		public bool MIOEPBKKBNP()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x174AEE0", Offset = "0x1749AE0", VA = "0x18174AEE0")]
	public static FIMFLEFLLCH<T> DBGHCCIPLMI<T>(this NativeList<T> IFADMANLNLG) where T : struct
	{
		return default(FIMFLEFLLCH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0xE90DB0", Offset = "0xE8F9B0", VA = "0x180E90DB0")]
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
		public struct KIKAENNOKNI<TTo> where TTo : struct
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
		public struct FONEMHEPPHG<TTo> where TTo : struct
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
		public struct KHJCECJKHLD<TTo> where TTo : struct
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
	[Cpp2IlInjected.Address(RVA = "0x6A3F520", Offset = "0x6A3E120", VA = "0x186A3F520", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class LEKBKADGMNN
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x3083FA0", Offset = "0x3082BA0", VA = "0x183083FA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F5D00", Offset = "0x7F4900", VA = "0x1807F5D00", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A910", Offset = "0x6A39510", VA = "0x186A3A910")]
	protected MPCIDEABOID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[DisableAutoCreation]
public sealed class KBHIFALNLKD : MPCIDEABOID
{
	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A910", Offset = "0x6A39510", VA = "0x186A3A910")]
	public KBHIFALNLKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[DisableAutoCreation]
public sealed class DOAKBPMALDE : MPCIDEABOID
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A910", Offset = "0x6A39510", VA = "0x186A3A910")]
	public DOAKBPMALDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[DisableAutoCreation]
public sealed class EFNEFEPPFKH : MPCIDEABOID
{
	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A910", Offset = "0x6A39510", VA = "0x186A3A910")]
	public EFNEFEPPFKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[DisableAutoCreation]
public sealed class MABMHEFJONF : MPCIDEABOID
{
	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A910", Offset = "0x6A39510", VA = "0x186A3A910")]
	public MABMHEFJONF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[DisableAutoCreation]
public sealed class LMHIAGOLJOP : MPCIDEABOID
{
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A910", Offset = "0x6A39510", VA = "0x186A3A910")]
	public LMHIAGOLJOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[DisableAutoCreation]
public sealed class BMHHAHJPDDI : MPCIDEABOID
{
	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A910", Offset = "0x6A39510", VA = "0x186A3A910")]
	public BMHHAHJPDDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[DisableAutoCreation]
public sealed class OPOBJELNJJN : MPCIDEABOID
{
	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A910", Offset = "0x6A39510", VA = "0x186A3A910")]
	public OPOBJELNJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[DisableAutoCreation]
public sealed class NJEAGGCKFJJ : MPCIDEABOID
{
	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A910", Offset = "0x6A39510", VA = "0x186A3A910")]
	public NJEAGGCKFJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[DisableAutoCreation]
public sealed class JCEBHADMNOP : MPCIDEABOID
{
	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A910", Offset = "0x6A39510", VA = "0x186A3A910")]
	public JCEBHADMNOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public sealed class LDKGCNKMDOL : DBNDPGDFGFK
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A910", Offset = "0x6A39510", VA = "0x186A3A910")]
	public LDKGCNKMDOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public sealed class LNPPLPJIOLK : DBNDPGDFGFK
{
	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A910", Offset = "0x6A39510", VA = "0x186A3A910")]
	public LNPPLPJIOLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public sealed class BBDONECNJLI : DBNDPGDFGFK
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A910", Offset = "0x6A39510", VA = "0x186A3A910")]
	public BBDONECNJLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public sealed class PFOGDLOOEFI : DBNDPGDFGFK
{
	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A910", Offset = "0x6A39510", VA = "0x186A3A910")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F5CA0", Offset = "0x7F48A0", VA = "0x1807F5CA0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A910", Offset = "0x6A39510", VA = "0x186A3A910")]
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
	internal static NBMCIPHNCFJ<DGLDCDLCECP> FIOMNDALOBN
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6A3BD90", Offset = "0x6A3A990", VA = "0x186A3BD90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	internal static NBMCIPHNCFJ<MFCOBEFGBOI> GMLDEHHIHCF
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6A3BED0", Offset = "0x6A3AAD0", VA = "0x186A3BED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal static NBMCIPHNCFJ<AKKNCOHCIBK> IHDJMOOJEKC
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x6A3BE70", Offset = "0x6A3AA70", VA = "0x186A3BE70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6A3BF30", Offset = "0x6A3AB30", VA = "0x186A3BF30")]
	public static void PBAELFIBGFO(bool HCKNDFMIDDI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6A3BDF0", Offset = "0x6A3A9F0", VA = "0x186A3BDF0")]
	public static Type[] HJHOGOLLNFB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class PCLEFMFPEJG
{
	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x1F72D40", Offset = "0x1F71940", VA = "0x181F72D40")]
	[MustUseReturnValue]
	public static JobHandle EAEOFDKANDO<T>(this EntityCommandBufferSystem PPANIHNCFCJ, NativeArrayAsync<Entity> FPMGLBFKKPO, NativeArrayAsync<T> PHBHEFAPHDL, [Optional] JobHandle NPBMDGDOAPE) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x1F73250", Offset = "0x1F71E50", VA = "0x181F73250")]
	[MustUseReturnValue]
	public static JobHandle EAEOFDKANDO<T>(this EntityCommandBufferSystem PPANIHNCFCJ, NativeArrayAsync<Entity> FPMGLBFKKPO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x1F72C20", Offset = "0x1F71820", VA = "0x181F72C20")]
	[MustUseReturnValue]
	public static JobHandle EAEOFDKANDO<T>(this EntityCommandBufferSystem PPANIHNCFCJ, NativeArray<Entity> FPMGLBFKKPO, [Optional] JobHandle NPBMDGDOAPE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x1F73130", Offset = "0x1F71D30", VA = "0x181F73130")]
	[MustUseReturnValue]
	public static JobHandle EAEOFDKANDO<T>(this EntityCommandBufferSystem PPANIHNCFCJ, EntityCommandBuffer FIENHHJAMHI, NativeArray<Entity> FPMGLBFKKPO, [Optional] JobHandle NPBMDGDOAPE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6A41A90", Offset = "0x6A40690", VA = "0x186A41A90")]
	[MustUseReturnValue]
	public static JobHandle EAEOFDKANDO(this EntityCommandBufferSystem PPANIHNCFCJ, NativeArray<Entity> FPMGLBFKKPO, ComponentTypes FOAMMHNABBN, [Optional] JobHandle NPBMDGDOAPE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6A41BF0", Offset = "0x6A407F0", VA = "0x186A41BF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A3F7B0", Offset = "0x6A3E3B0", VA = "0x186A3F7B0")]
	private unsafe static Span<byte> PEAFCOBLFHI(Unity.Entities.Chunk* NLIPPJGPKOG, int BNNLAPKBIOF)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x2686270", Offset = "0x2684E70", VA = "0x182686270")]
	public unsafe static Span<T> ELPMFKPEGBM<T>(Unity.Entities.Chunk* NLIPPJGPKOG, int BNNLAPKBIOF)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x2686230", Offset = "0x2684E30", VA = "0x182686230")]
	public static Span<T> ELPMFKPEGBM<T>(this ref Unity.Entities.Chunk NLIPPJGPKOG, int BNNLAPKBIOF)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F740", Offset = "0x6A3E340", VA = "0x186A3F740")]
	public unsafe static Span<Entity> LALLBDCAKCG(Unity.Entities.Chunk* NLIPPJGPKOG)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F5B0", Offset = "0x6A3E1B0", VA = "0x186A3F5B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x81E870", Offset = "0x81D470", VA = "0x18081E870")]
	public MHCHCENMNNH(NativeArray<EntityRemapUtility.EntityRemapInfo> KIOMBJEIJNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F570", Offset = "0x6A3E170", VA = "0x186A3F570")]
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
	[Cpp2IlInjected.Address(RVA = "0x8A3CC0", Offset = "0x8A28C0", VA = "0x1808A3CC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x14FE990", Offset = "0x14FD590", VA = "0x1814FE990")]
		public FDMHKJOLODG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B340", Offset = "0x6A39F40", VA = "0x186A3B340")]
	static DFJLHCDMPLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x2B7EA10", Offset = "0x2B7D610", VA = "0x182B7EA10")]
	public static void HFEOPFFCKDC<T>(COKJNICGJFN<T, T> DPHLLPLPIPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x2B7E7D0", Offset = "0x2B7D3D0", VA = "0x182B7E7D0")]
	public static void HFEOPFFCKDC<From, To>(COKJNICGJFN<From, To> DPHLLPLPIPO, COKJNICGJFN<To, From> AEKDEAOHPIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x2B7E780", Offset = "0x2B7D380", VA = "0x182B7E780")]
	public static void HFEOPFFCKDC<From, To>(COKJNICGJFN<From, To> JNHBOJOGBIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x2B84B80", Offset = "0x2B83780", VA = "0x182B84B80")]
	public static COKJNICGJFN<From, To> MJKAMACBPFN<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x2B7D310", Offset = "0x2B7BF10", VA = "0x182B7D310")]
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
public class FHFLBOGHGEP<TComponentData, TValue> : BMDNPKBCNJC<TValue>, IDisposable where TComponentData : struct, FBNBLAKKAPF
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	private class GEAMGMIBGPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private List<(object token, TValue value)> IFADMANLNLG;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int PLEPIEDOEAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA650", Offset = "0x1FB9250", VA = "0x181FBA650")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x25FE140", Offset = "0x25FCD40", VA = "0x1825FE140")]
		public bool BHPOOGEBGBI(out TValue ECNGHFJBIJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x25FE200", Offset = "0x25FCE00", VA = "0x1825FE200")]
		public void CAILCKFFJIK(object FLDJLPKNKKO, TValue ECNGHFJBIJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x25FE2B0", Offset = "0x25FCEB0", VA = "0x1825FE2B0")]
		public bool CPPHPNNFPKL(object FLDJLPKNKKO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x25FE330", Offset = "0x25FCF30", VA = "0x1825FE330")]
		public int HNIOFAKCMJD(object FLDJLPKNKKO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x25FE3E0", Offset = "0x25FCFE0", VA = "0x1825FE3E0")]
		public GEAMGMIBGPA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly Stack<GEAMGMIBGPA> BODHCNIOABE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private FDLDIAADLDC<GHBLMLDHKJD, GEAMGMIBGPA> DABHKCECOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private EntityManager LMJGFJDJJLA;

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x32B9C10", Offset = "0x32B8810", VA = "0x1832B9C10")]
	public FHFLBOGHGEP(EntityManager LMJGFJDJJLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x32B98E0", Offset = "0x32B84E0", VA = "0x1832B98E0", Slot = "4")]
	public void KNDGHBJCIPF(Entity CMBJDMJHALL, object FLDJLPKNKKO, TValue ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x32B9A80", Offset = "0x32B8680", VA = "0x1832B9A80", Slot = "5")]
	public bool PAALMADNNKG(Entity CMBJDMJHALL, object FLDJLPKNKKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x32B95C0", Offset = "0x32B81C0", VA = "0x1832B95C0", Slot = "6")]
	public bool BHPOOGEBGBI(Entity CMBJDMJHALL, out TValue ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x32B9690", Offset = "0x32B8290", VA = "0x1832B9690", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x32B9A00", Offset = "0x32B8600", VA = "0x1832B9A00")]
	private void MNHCHBKDDDE(GEAMGMIBGPA LMFCFNPNFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x32B9740", Offset = "0x32B8340", VA = "0x1832B9740")]
	private bool FCFJFPIFDIM(Entity CMBJDMJHALL, out GHBLMLDHKJD AAFHCAILJEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x32B96B0", Offset = "0x32B82B0", VA = "0x1832B96B0")]
	private void EDFGBFBDCCH(Entity CMBJDMJHALL, GHBLMLDHKJD AAFHCAILJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x32B95A0", Offset = "0x32B81A0", VA = "0x1832B95A0")]
	private bool AEKGODAMIKA(GHBLMLDHKJD AAFHCAILJEB, out GEAMGMIBGPA LMFCFNPNFHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x32B9810", Offset = "0x32B8410", VA = "0x1832B9810")]
	private GEAMGMIBGPA HPOCDGDDLDI()
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
public struct GHBLMLDHKJD : NMBLHKCDDCH<GHBLMLDHKJD>, LHEDDDDOOOA, IEquatable<GHBLMLDHKJD>
{
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static readonly GHBLMLDHKJD BGKJPCCCNHP;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	[CreateProperty]
	public int OJOINFOLDPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x91F8E0", Offset = "0x91E4E0", VA = "0x18091F8E0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x91F850", Offset = "0x91E450", VA = "0x18091F850", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA81DD0", Offset = "0xA809D0", VA = "0x180A81DD0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x114DF20", Offset = "0x114CB20", VA = "0x18114DF20", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C4B0", Offset = "0x6A3B0B0", VA = "0x186A3C4B0", Slot = "8")]
	public bool Equals(GHBLMLDHKJD MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C500", Offset = "0x6A3B100", VA = "0x186A3C500", Slot = "3")]
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
	private FDLDIAADLDC<GHBLMLDHKJD, HashSet<object>> DABHKCECOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private EntityManager LMJGFJDJJLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private EntityCommandBufferSystem PPANIHNCFCJ;

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x26D5E30", Offset = "0x26D4A30", VA = "0x1826D5E30")]
	public BEMINCHFLDP(EntityManager LMJGFJDJJLA, EntityCommandBufferSystem PPANIHNCFCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x26D4730", Offset = "0x26D3330", VA = "0x1826D4730", Slot = "4")]
	public bool KNDGHBJCIPF(Entity CMBJDMJHALL, object FLDJLPKNKKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x26D5590", Offset = "0x26D4190", VA = "0x1826D5590", Slot = "5")]
	public bool PAALMADNNKG(Entity CMBJDMJHALL, object FLDJLPKNKKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x26D2670", Offset = "0x26D1270", VA = "0x1826D2670", Slot = "6")]
	public bool BABEIMNAAGJ(Entity CMBJDMJHALL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x26D2830", Offset = "0x26D1430", VA = "0x1826D2830", Slot = "10")]
	public bool BABEIMNAAGJ(GHBLMLDHKJD AAFHCAILJEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x26D4C20", Offset = "0x26D3820", VA = "0x1826D4C20", Slot = "7")]
	public IEnumerable<object> OKAKGJPNIKC(Entity CMBJDMJHALL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x26D4DA0", Offset = "0x26D39A0", VA = "0x1826D4DA0", Slot = "11")]
	public IEnumerable<object> OKAKGJPNIKC(GHBLMLDHKJD AAFHCAILJEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x26D39E0", Offset = "0x26D25E0", VA = "0x1826D39E0", Slot = "8")]
	public bool GIOFBNMLLED(Entity CMBJDMJHALL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x26D2F00", Offset = "0x26D1B00", VA = "0x1826D2F00", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x26D4890", Offset = "0x26D3490", VA = "0x1826D4890")]
	private void MNHCHBKDDDE(HashSet<object> LMFCFNPNFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x26D3870", Offset = "0x26D2470", VA = "0x1826D3870")]
	private bool FCFJFPIFDIM(Entity CMBJDMJHALL, out GHBLMLDHKJD AAFHCAILJEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x26D2D40", Offset = "0x26D1940", VA = "0x1826D2D40")]
	private bool CBHPCKALGDL(Entity CMBJDMJHALL, out GHBLMLDHKJD AAFHCAILJEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x26D2A10", Offset = "0x26D1610", VA = "0x1826D2A10")]
	private void BHODPDIAEHL(Entity CMBJDMJHALL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x26D3950", Offset = "0x26D2550", VA = "0x1826D3950")]
	private void GGMNININJIL(Entity CMBJDMJHALL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x26D32F0", Offset = "0x26D1EF0", VA = "0x1826D32F0")]
	private void EGALBADHMDN(Entity CMBJDMJHALL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x26D3190", Offset = "0x26D1D90", VA = "0x1826D3190")]
	private void EDFGBFBDCCH(Entity CMBJDMJHALL, GHBLMLDHKJD AAFHCAILJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x26D5830", Offset = "0x26D4430", VA = "0x1826D5830")]
	private bool PECCHAKOOEA(GHBLMLDHKJD AAFHCAILJEB, out HashSet<object> LMFCFNPNFHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x26D4070", Offset = "0x26D2C70", VA = "0x1826D4070")]
	private HashSet<object> HPOCDGDDLDI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public static class PHGJCBGFBPF
{
	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010")]
	public static void ILDGJLPOJDH(this MFFHLJHLBIG HGFFDKCANPF, NativeArray<Entity> FPMGLBFKKPO, [Optional][CallerFilePath] string FJCMLALIJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010")]
	public static void ILDGJLPOJDH(this MFFHLJHLBIG HGFFDKCANPF, string BPOKAAOBIOI, NativeArray<Entity> FPMGLBFKKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010")]
	public static void ILDGJLPOJDH(this MFFHLJHLBIG HGFFDKCANPF, string FJCMLALIJKN, NativeArray<Entity> FPMGLBFKKPO, bool GPMFMCCDAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010")]
	public static void KMEDBMIIJKB(this MFFHLJHLBIG HGFFDKCANPF, NativeArray<Entity> FPMGLBFKKPO, EntityManager LMJGFJDJJLA, [Optional][CallerFilePath] string FJCMLALIJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010")]
	public static void KMEDBMIIJKB(this MFFHLJHLBIG HGFFDKCANPF, string FJCMLALIJKN, NativeArray<Entity> FPMGLBFKKPO, EntityManager LMJGFJDJJLA, bool GPMFMCCDAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010")]
	public static void EDLBCPBGPME(this MFFHLJHLBIG HGFFDKCANPF, NativeArray<Entity> FPMGLBFKKPO, NativeArray<Entity> MHKKJIBKAII, [Optional][CallerFilePath] string FJCMLALIJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010")]
	public static void EDLBCPBGPME(this MFFHLJHLBIG HGFFDKCANPF, string FJCMLALIJKN, NativeArray<Entity> FPMGLBFKKPO, NativeArray<Entity> MHKKJIBKAII, bool GPMFMCCDAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x1F76A90", Offset = "0x1F75690", VA = "0x181F76A90")]
	public static void JDMCCAKBGDF<T>(this MFFHLJHLBIG HGFFDKCANPF, string BPOKAAOBIOI, NativeArray<Entity> FPMGLBFKKPO, NativeList<T> PHBHEFAPHDL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x1F76A40", Offset = "0x1F75640", VA = "0x181F76A40")]
	public static void JDMCCAKBGDF<T>(this MFFHLJHLBIG HGFFDKCANPF, NativeArray<Entity> FPMGLBFKKPO, NativeArray<T> PHBHEFAPHDL, [Optional][CallerFilePath] string FJCMLALIJKN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x1F76A00", Offset = "0x1F75600", VA = "0x181F76A00")]
	public static void JDMCCAKBGDF<T>(this MFFHLJHLBIG HGFFDKCANPF, string BPOKAAOBIOI, NativeArray<Entity> FPMGLBFKKPO, NativeArray<T> PHBHEFAPHDL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010")]
	public static void JDMCCAKBGDF<T>(this MFFHLJHLBIG HGFFDKCANPF, string FJCMLALIJKN, NativeArray<Entity> FPMGLBFKKPO, NativeArray<T> PHBHEFAPHDL, bool GPMFMCCDAKI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x1F769A0", Offset = "0x1F755A0", VA = "0x181F769A0")]
	public static void HCJINHBILHH<T>(this MFFHLJHLBIG HGFFDKCANPF, NativeList<T> PHBHEFAPHDL, [Optional][CallerFilePath] string FJCMLALIJKN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x1F76970", Offset = "0x1F75570", VA = "0x181F76970")]
	public static void HCJINHBILHH<T>(this MFFHLJHLBIG HGFFDKCANPF, NativeArray<T> PHBHEFAPHDL, [Optional][CallerFilePath] string FJCMLALIJKN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010")]
	public static void HCJINHBILHH<T>(this MFFHLJHLBIG HGFFDKCANPF, string FJCMLALIJKN, NativeArray<T> PHBHEFAPHDL, bool GPMFMCCDAKI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010")]
	public static void AJKDGOHMJHC(this MFFHLJHLBIG HGFFDKCANPF, EntityQuery DPBAMGMJJLC, [Optional][CallerFilePath] string FJCMLALIJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010")]
	public static void AJKDGOHMJHC(this MFFHLJHLBIG HGFFDKCANPF, string BPOKAAOBIOI, EntityQuery DPBAMGMJJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010")]
	public static void AJKDGOHMJHC(this MFFHLJHLBIG HGFFDKCANPF, string FJCMLALIJKN, EntityQuery DPBAMGMJJLC, bool GPMFMCCDAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x1F76940", Offset = "0x1F75540", VA = "0x181F76940")]
	public static void FNDFMMEAAEN<T, T2>(this MFFHLJHLBIG HGFFDKCANPF, string BPOKAAOBIOI, EntityQuery DPBAMGMJJLC) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010")]
	private static void FNDFMMEAAEN<T, T2>(this MFFHLJHLBIG HGFFDKCANPF, string FJCMLALIJKN, EntityQuery DPBAMGMJJLC, bool GPMFMCCDAKI) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x1F76940", Offset = "0x1F75540", VA = "0x181F76940")]
	public static void EGHOIJKPJMO<T>(this MFFHLJHLBIG HGFFDKCANPF, string BPOKAAOBIOI, NativeList<T> EABDNHJFDCB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010")]
	public static void EGHOIJKPJMO<T>(this MFFHLJHLBIG HGFFDKCANPF, string FJCMLALIJKN, NativeList<T> EABDNHJFDCB, bool GPMFMCCDAKI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x1F76940", Offset = "0x1F75540", VA = "0x181F76940")]
	public static void KKECINMOKAL<T>(this MFFHLJHLBIG HGFFDKCANPF, string BPOKAAOBIOI, NativeArray<T> EABDNHJFDCB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010")]
	public static void KKECINMOKAL<T>(this MFFHLJHLBIG HGFFDKCANPF, string FJCMLALIJKN, NativeArray<T> EABDNHJFDCB, bool GPMFMCCDAKI) where T : struct
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public class PFBBJKPLBFC
{
	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
	public PFBBJKPLBFC()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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
